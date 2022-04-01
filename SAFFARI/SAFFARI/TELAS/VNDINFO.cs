using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProjetoLauge.TELAS
{
    public partial class VNDINFO : Form
    {
        string CPFDoCliente;
        string NomeDoCliente;
        bool Venda;
        public VNDINFO(string NomeDoCliente, string CPFDoCliente, bool venda)
        {
            InitializeComponent();
            this.NomeDoCliente = NomeDoCliente;
            this.CPFDoCliente = CPFDoCliente;
            Venda = venda;
            lblNomedoCliente.Text = NomeDoCliente;
            lblCPFDoCliente.Text = CPFDoCliente;
            CarregarTabConsumo();
            SomarTotal();
        }
        public void CarregarTabConsumo()
        {
            Produtos produtos = new Produtos();
            Consumo consumo = new Consumo();
            dataGridView1.DataSource = produtos.TodosProdutos("Produtos_Tabacaria");
            if (!Venda)
                dataGridView2.DataSource = consumo.TodosConsumos(CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
            if (Venda)
                dataGridView2.DataSource = consumo.TodosConsumos("Venda");
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SomarTotal();
        }
        string Total;
        public void SomarTotal()
        {
            double total = 0;
            foreach (DataGridViewRow linha in dataGridView2.Rows)
            {
                total += Convert.ToDouble(linha.Cells[2].Value);
            }
            Total = total.ToString().Replace(".", ",");
            string Totall = total.ToString();
            var a = Totall.Length;
            if (Totall.IndexOf(",") > 0)
                txtTotal.Text = Totall;
            else
                txtTotal.Text = Totall.Insert(a, ",00");
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TabacariaF tb = new TabacariaF();
            tb.Show();
            Close();
        }
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover esse item?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                RemoverItem(0);
            CarregarTabConsumo();
        }
        public void RemoverItem(int a)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value);
                string produto = (string)(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value);
                double valor = Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[2].Value);
                Consumo consumo = new Consumo();
                if (consumo.Mensagem.Equals(""))
                {
                    if (a == 0)
                    {
                        consumo.RemoverItens(id, "Venda");
                        Produtos produtos = new Produtos();
                        if (!produto.StartsWith("*"))
                        {
                            produtos.Produto = produto;
                            produtos.AlterarQtd("Produtos_tabacaria");
                        }
                        MessageBox.Show("Item removido com sucesso");
                    }
                    else
                    {
                        string valorr = valor.ToString().Replace(".", ",");
                        FinalizarCF finalizar = new FinalizarCF(CPFDoCliente, NomeDoCliente);
                        finalizar.ShowDialog();
                        if (finalizar.Result)
                        {
                            consumo.RemoverItens(id, "Venda");
                            printDocument3.Print();
                            MessageBox.Show("Produto Pago!! ");
                        }
                    }
                }
                else
                    MessageBox.Show(consumo.Mensagem);
            }
            catch { MessageBox.Show("Erro"); }
        }
        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (var pd = new PrintDocument())
            {
                try
                {
                    pd.PrinterSettings.PrinterName = "Caixa";
                    pd.PrintPage += Pdd_PrintPage;
                    pd.Print();
                }
                catch { MessageBox.Show("Erro ao tentar imprimir\nVerifique o nome da impressora."); }
            }
        }
        private void Pdd_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                string produto = (string)(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value);
                string valor = (Convert.ToString(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[2].Value));
                Font letralogo = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Pixel);
                Font letranome = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
                Font letraconsumos = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel);
                Font letradata = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
                SolidBrush cor = new SolidBrush(Color.Black);
                string logo = "SAFFARI LOUNGE";
                string nome = NomeDoCliente;
                string data = DateTime.Now.ToString();
                string txt = "----------------------------------------------------------------------------";
                var b = produto;
                if (produto.Length > 35)
                    b = produto.Insert(35, "\n");
                var a = valor.ToString().Insert(0, "R$ ").Replace(",00", ",");
                e.Graphics.DrawString(data, letradata, cor, 150, 10);
                e.Graphics.DrawString(logo, letralogo, cor, 15, 40);
                e.Graphics.DrawString(txt, letranome, cor, 0, 70);
                e.Graphics.DrawString(nome, letranome, cor, 1, 90);
                e.Graphics.DrawString(txt, letranome, cor, 0, 110);
                e.Graphics.DrawString($"TOTAL R$ {a}", letranome, cor, 90, 130);
                e.Graphics.DrawString(txt, letranome, cor, 0, 150);
                e.Graphics.DrawString(b, letraconsumos, cor, 1, 175);
                e.Graphics.DrawString(a, letraconsumos, cor, 238, 180);
            }
            catch (Exception ex)
            {
                string erro = $"Erro ao tentar imprimir\n\n{ex}";
                MessageBox.Show(erro);
            }
        }
        private void btnPagarParcial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pagar esse item antecipado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                RemoverItem(1);
            CarregarTabConsumo();
        }
        private void btnFinalizarComanda_Click(object sender, EventArgs e)
        {
            Consumo consumo = new Consumo();
            if (consumo.Mensagem.Equals(""))
            {
                FinalizarCF finalizarCF = new FinalizarCF(CPFDoCliente, NomeDoCliente);
                finalizarCF.ShowDialog();
                if (finalizarCF.Result)
                {
                    printDocument2.Print();
                    TabacariaF tabacaria = new TabacariaF();
                    tabacaria.Show();
                    Close();
                }
            }
            else
                MessageBox.Show(consumo.Mensagem);
        }
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    pd.PrinterSettings.PrinterName = "Caixa";
                    pd.PrintPage += Pd_PrintPage;
                    pd.Print();
                }
            }
            catch { MessageBox.Show("Erro ao tentar imprimir\nVerifique o nome da impressora."); }
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font letralogo = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letranome = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letraconsumos = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letradata = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            try
            {
                string logo = "SAFFARI LOUNGE";
                string nome = NomeDoCliente;
                string produto = "";
                string valor = "";
                string data = DateTime.Now.ToString();
                string txt = "----------------------------------------------------------------------------";
                List<string> listavalor = new List<string>();
                List<string> listaprodutos = new List<string>();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    listavalor.Add(Convert.ToString(dataGridView2.Rows[i].Cells[2].Value));
                    listaprodutos.Add(Convert.ToString(dataGridView2.Rows[i].Cells[1].Value));
                }
                foreach (string i in listavalor)
                    valor += i.ToString().Insert(0, "R$ ").Replace(",00", ",") + "\n\n\n";
                foreach (string i in listaprodutos)
                {
                    if (i.Length > 35)
                        produto += i.Insert(35, "\n") + "\n\n";
                    else
                        produto += i + "\n\n\n";
                }
                e.Graphics.DrawString(data, letradata, cor, 150, 10);
                e.Graphics.DrawString(logo, letralogo, cor, 15, 40);
                e.Graphics.DrawString(txt, letranome, cor, 0, 70);
                e.Graphics.DrawString(nome, letranome, cor, 1, 90);
                e.Graphics.DrawString(txt, letranome, cor, 0, 110);
                e.Graphics.DrawString($"TOTAL R$ {txtTotal.Text}", letranome, cor, 90, 130);
                e.Graphics.DrawString(txt, letranome, cor, 0, 150);
                e.Graphics.DrawString(produto, letraconsumos, cor, 1, 175);
                e.Graphics.DrawString(valor, letraconsumos, cor, 238, 180);
            }
            catch (Exception ex)
            {
                string erro = $"Erro ao tentar imprimir\n\n{ex}";
                MessageBox.Show(erro);
                e.Graphics.DrawString(erro, letranome, cor, 0, 115);
            }
        }
        private void btnBuscarCodigoProduto_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (ValidarBuscar2())
                Buscar("Id");
        }
        private bool ValidarBuscar2()
        {
            if (txbCodigoProduto.Text.Trim().ToUpper() == "")
            {
                MessageBox.Show("Campo vazio");
                txtBuscar.Focus();
                return false;
            }
            return true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (ValidarBuscar())
                Buscar("Produto");
        }
        private bool ValidarBuscar()
        {
            if (txtBuscar.Text.Trim().ToUpper() == "")
            {
                MessageBox.Show("Campo vazio");
                txtBuscar.Focus();
                return false;
            }
            return true;
        }
        private void Buscar(string z)
        {
            dataGridView1.Visible = true;
            try
            {
                Produtos produtos = new Produtos();
                string a = "";
                string b = "Categoria";
                if (z.Equals("Produto"))
                {
                    a = txtBuscar.Text.Replace("'", "");
                    b = z;
                }
                else if (z.Equals("Id"))
                {
                    a = txbCodigoProduto.Text.Replace("'", "");
                    b = z;
                }
                else
                    a = z;
                dataGridView1.DataSource = produtos.TodosProdutosSelect(a, b, "Produtos_Tabacaria");
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            CarregarTabConsumo();
            dataGridView1.Visible = true;
        }
        private void btnBebidas_Click(object sender, EventArgs e) { Buscar("Bebidas"); }
        private void btnRosh_Click(object sender, EventArgs e) { Buscar("Essência"); }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                string produto = (string)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                double valor = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                string categoria = (string)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                Consumo consumo = new Consumo();
                Produtos produtos = new Produtos();
                produtos.Id = id;
                produtos.Produto = produto;
                produtos.Valor = valor;
                produtos.Qtd = qtd - 1;
                produtos.GravarAlterarProdutos("", "Produtos_Tabacaria");
                if (consumo.Mensagem.Equals(""))
                {
                    if (!Venda)
                    {
                        consumo.AdicionarConsumo(produto, valor, CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
                        MessageBox.Show("Item Adicionado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.DataSource = consumo.TodosConsumos(CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
                    }
                    if (Venda)
                    {
                        consumo.AdicionarConsumo(produto, valor, "Venda");
                        dataGridView2.DataSource = consumo.TodosConsumos("Venda");
                    }
                }
                else
                    MessageBox.Show(consumo.Mensagem);
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SomarTotal();
            }
            catch (Exception) { MessageBox.Show($"Nenhum item selecionado", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                string produto = (string)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                double valor = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                string categoria = (string)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                Consumo consumo = new Consumo();
                Produtos produtos = new Produtos();
                produtos.Id = id;
                produtos.Produto = produto;
                produtos.Valor = valor;
                produtos.Qtd = qtd - 1;
                produtos.GravarAlterarProdutos("", "Produtos_Tabacaria");
                if (consumo.Mensagem.Equals(""))
                {
                    if (!Venda)
                    {
                        consumo.AdicionarConsumo(produto, valor, CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
                        MessageBox.Show("Item Adicionado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.DataSource = consumo.TodosConsumos(CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
                    }
                    if (Venda)
                    {
                        consumo.AdicionarConsumo(produto, valor, "Venda");
                        dataGridView2.DataSource = consumo.TodosConsumos("Venda");
                    }
                }
                else
                    MessageBox.Show(consumo.Mensagem);
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SomarTotal();
            }
            catch (Exception) { MessageBox.Show($"Nenhum item selecionado", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void VNDINFO_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    btnFinalizarComanda_Click(sender, e);
                    break;
                case Keys.F4:
                    btnVoltar_Click(sender, e);
                    break;
            }
        }
        private void txbCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    btnBuscarCodigoProduto_Click(sender, e);
                    btnAdicionar_Click(sender, e);
                    break;
            }
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    btnBuscar_Click(sender, e);
                    break;
            }
        }
        private void txbCodigoProduto_MouseClick(object sender, MouseEventArgs e) { txbCodigoProduto.Text = ""; }
        private void txtBuscar_MouseClick(object sender, MouseEventArgs e) { txtBuscar.Text = ""; }
        private void btnAdicionarValor_Click(object sender, EventArgs e) { Adicionarvalor(true); }       
        private void btnRemoverValor_Click(object sender, EventArgs e) { Adicionarvalor(true); }
        private void Adicionarvalor(bool type)
        {
            try
            {
                Consumo consumo = new Consumo();
                var produto = txbDescricaovaloradd.Text;
                double valor = 0.0;
                if (type)
                {
                    valor = Convert.ToDouble(txbValorAddRemov.Text.Replace(".", ","));
                    produto = produto.Insert(0, "* + ");
                }
                if (!type)
                {
                    valor = -Convert.ToDouble(txbValorAddRemov.Text.Replace(".", ","));
                    produto = produto.Insert(0, "* - ");
                }
                if (!Venda)
                {
                    consumo.AdicionarConsumo(produto, valor, CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
                    MessageBox.Show("Item Adicionado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView2.DataSource = consumo.TodosConsumos(CPFDoCliente.Replace(".", "").Replace("-", "").Insert(0, "PRAZO"));
                }
                if (Venda)
                {
                    consumo.AdicionarConsumo(produto, valor, "Venda");
                    dataGridView2.DataSource = consumo.TodosConsumos("Venda");
                }
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SomarTotal();
            }
            catch (Exception) { MessageBox.Show($"ERRO!!...", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
