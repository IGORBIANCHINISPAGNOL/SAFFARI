using Business;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SAFFARI.TELAS
{
    public partial class FinalizarCF : Form
    {
        public bool Result { get; set; } = false;
        private Comanda _comanda;
        private Financeiro _financeiro;
        private Caixa _caixa;
        private Consumo _consumo;
        private Pagamento _pagamento;    
        private List<Pagamento> _listpagamentos;
        public FinalizarCF(Comanda comanda)
        {
            InitializeComponent();
            _comanda = comanda;
            CarregarTabela();
            SomarTotal();
        }
        public void SomarTotal()
        {
            decimal total = 0;
            decimal totalpago = 0;
            foreach (DataGridViewRow linha in dataGridView2.Rows)
            {
                var valor = Convert.ToDecimal(linha.Cells[2].Value);
                var qtd = Convert.ToDecimal(linha.Cells[0].Value);
                total += valor * qtd;
            }
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                var conta = Convert.ToDecimal(linha.Cells[1].Value);
                if (conta > 0)
                    totalpago += conta;
            }
            txtTotal.Text = total.ToString("N2");
            txtTotalPago.Text = totalpago.ToString("N2");
            var sobra = total - totalpago;
            if (sobra >= 0)
            {
                lblfalta.Text = "Falta:";
                txtFalta.Text = sobra.ToString("N2");
                btnFaltando.Text = sobra.ToString("N2");
            }
            else
            {
                lblfalta.Text = "Troco:";
                txtFalta.Text = (sobra * -1).ToString("N2");
            }     
            
        }
        private void CarregarTabela()
        {
            _consumo = new Consumo();
            _pagamento = new Pagamento();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;            
            _consumo.ClienteId = _comanda.ClienteId;
            _pagamento.ClienteId = _comanda.ClienteId;
            _listpagamentos = _pagamento.Pagamentos();
            dataGridView2.DataSource = _consumo.Consumos();
            dataGridView1.DataSource = _listpagamentos;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[0].Width = 40;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Red;
            SomarTotal();
        }
        string tipo;
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (lblfalta.Text != "Falta:" || txtFalta.Text == "0,00")
            {
                _financeiro = new Financeiro();
                _consumo = new Consumo();
                _pagamento = new Pagamento();
                _caixa = new Caixa();
                var caixlist = _caixa.Todos();
                var data = caixlist[0].Data;
                var datahoje = DateTime.Now;
                foreach (Pagamento pgto in _listpagamentos)
                {
                    var entrada = Convert.ToDecimal(pgto.Entrada);
                    var saida = Convert.ToDecimal(pgto.Saida);
                    if (entrada != saida)
                    {
                        _financeiro.Descrição = _comanda.Nome;
                        _financeiro.Dia = data;
                        _financeiro.Data = datahoje;
                        _financeiro.Entrada = entrada;
                        _financeiro.Saida = saida;
                        _financeiro.FormaPgto = pgto.FormaPagt;
                        _financeiro.Salvar();
                    }                  
                }
                Comanda cmd = new Comanda();
                var id = _comanda.ClienteId;
                cmd.ClienteId = id;
                _consumo.ClienteId = id;
                _pagamento.ClienteId = id;
                cmd.ExcluirId();
                _consumo.LimparConsumo();
                _pagamento.LimparConsumo();
                printDocument2.Print();
                if (MessageBox.Show("Imprimir 2° via do recibo ?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    printDocument2.Print();
                Result = true;
                Close();
            }
            else { MessageBox.Show("Não é poossível encerrar a comanda com itens em aberto."); }
        }
        private void btnCancelar_Click(object sender, EventArgs e) { Close(); }
        private void txtValorEntrada_MouseClick(object sender, MouseEventArgs e) { txtValorEntrada.Text = ""; }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                double falta = Convert.ToDouble(txtFalta.Text);
                if (lblfalta.Text == "Falta:")
                {
                    double valor = Convert.ToDouble(txtValorEntrada.Text.ToString().Replace(".", ","));                                  
                    _pagamento = new Pagamento();
                    _pagamento.Descricao = tipo;
                    _pagamento.FormaPagt = tipo;
                    _pagamento.Entrada = (decimal)valor;
                    if (valor > falta)
                    {
                        var result = valor - falta;
                        _pagamento.Saida = (decimal)result;
                    }
                    else
                        _pagamento.Saida = 0;
                    _pagamento.ClienteId = _comanda.ClienteId;
                    _pagamento.Salvar();
                    CarregarTabela();
                    SomarTotal();
                }
                else { MessageBox.Show("Não é possivel lançar mais dinheiro do que \no necessário para finalizar à comanda...!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show($"Erro", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void btnDinheiro_Click_1(object sender, EventArgs e)
        {
            panelDinheiro.Visible = true;
            panelValores.Visible = true;
            btnDinheiro.BackColor = Color.FromArgb(255, 192, 192);
            btnPIX.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoCredito.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoDebito.BackColor = Color.FromArgb(235, 236, 239);
            this.tipo = "DINHEIRO";
        }
        private void btnCartaoDebito_Click_1(object sender, EventArgs e)
        {
            panelValores.Visible = true;
            if (panelDinheiro.Visible)
                panelDinheiro.Visible = false;
            btnCartaoDebito.BackColor = Color.FromArgb(255, 192, 192);
            btnPIX.BackColor = Color.FromArgb(235, 236, 239);
            btnDinheiro.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoCredito.BackColor = Color.FromArgb(235, 236, 239);
            this.tipo = "CARTÃO/DÉBITO";
        }
        private void btnCartaoCredito_Click(object sender, EventArgs e)
        {
            panelValores.Visible = true;
            if (panelDinheiro.Visible)
                panelDinheiro.Visible = false;
            btnPIX.BackColor = Color.FromArgb(235, 236, 239);
            btnDinheiro.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoDebito.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoCredito.BackColor = Color.FromArgb(255, 192, 192);
            this.tipo = "CARTÃO/CRÉDITO";
        }
        private void btnPIX_Click(object sender, EventArgs e)
        {
            panelValores.Visible = true;
            if (panelDinheiro.Visible)
                panelDinheiro.Visible = false;
            btnPIX.BackColor = Color.FromArgb(255, 192, 192);
            btnDinheiro.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoDebito.BackColor = Color.FromArgb(235, 236, 239);
            btnCartaoCredito.BackColor = Color.FromArgb(235, 236, 239);
            this.tipo = "PIX";
        }
        private void btnLimpar_Click(object sender, EventArgs e) { txtValorEntrada.Text = "0,00"; }

        private void CalcularValores(double valor)
        {
            if (txtValorEntrada.Text == "") { txtValorEntrada.Text = "0"; }
            double a = Convert.ToDouble(txtValorEntrada.Text.ToString(CultureInfo.InvariantCulture).Replace(".", ","));
            a += valor; string c = a.ToString(); var b = c.Length;
            if (c.IndexOf(",") > 0) { txtValorEntrada.Text = c; }
            else { txtValorEntrada.Text = c.Insert(b, ",00"); }
        }

        private void btnAgregar2_Click(object sender, EventArgs e) { CalcularValores(2); }       
        private void btnAgregar5_Click(object sender, EventArgs e) { CalcularValores(5); }       
        private void btnAgregar10_Click(object sender, EventArgs e) { CalcularValores(10); }
        private void btnAgregar20_Click(object sender, EventArgs e) { CalcularValores(20); }
        private void btnAgregar50_Click(object sender, EventArgs e) { CalcularValores(50); }
        private void btnAgregar100_Click(object sender, EventArgs e) { CalcularValores(100); }
        private void btnAgregar200_Click(object sender, EventArgs e) { CalcularValores(200); }
        private void btnFaltando_Click(object sender, EventArgs e) { txtValorEntrada.Text = btnFaltando.Text; }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    pd.PrinterSettings.PrinterName = "IMPRESSORADOCAIXA";
                    pd.PrintPage += ImprimirRecibo;
                    pd.Print();
                }
            }
            catch { MessageBox.Show("Erro ao tentar imprimir\nVerifique o nome da impressora."); }
        }
        private void ImprimirRecibo(object sender, PrintPageEventArgs e)
        {
            Font letralogo = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letranome = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letraconsumos = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letradata = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            try
            {
                string logo = "SAFFARI LOUNGE";
                string nome = _comanda.Nome;
                string produto = "";
                string valor = "";
                string data = DateTime.Now.ToString();
                string txt = "--------------------------------------------------------------";
                List<string> listavalor = new List<string>();
                List<string> listaprodutos = new List<string>();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    listavalor.Add(Convert.ToString(dataGridView2.Rows[i].Cells[2].Value));
                    listaprodutos.Add(Convert.ToString(dataGridView2.Rows[i].Cells[1].Value));
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    listavalor.Add(Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
                    listaprodutos.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                }
                foreach (string i in listavalor)
                    valor += i.ToString().Insert(0, "R$ ") + "\n\n\n";
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Pagamento pg = (Pagamento)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                pg.ExcluirId();
                MessageBox.Show("Item Excluido com Sucesso", "Sucesso");
                CarregarTabela();
            }
            catch
            {
                string erro = $"Nenhum pagamento selecionado";
                MessageBox.Show(erro);
            }
        }
    }
}
