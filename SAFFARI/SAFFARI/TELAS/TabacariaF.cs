using Business;
using System;
using System.Windows.Forms;

namespace ProjetoLauge.TELAS
{
    public partial class TabacariaF : Form
    {
        public TabacariaF()
        {
            InitializeComponent();
            CarregarTabelas();
        }
        private void CarregarTabelas()
        {
            try
            {
                Produtos produtos = new Produtos();
                Comanda comandas = new Comanda();
                dataGridView1.DataSource = produtos.TodosProdutos("Produtos_Tabacaria");
                dataGridView2.DataSource = comandas.TodosComandas("Venda_Prazo");
                lblContagem.Text = dataGridView1.Rows.Count.ToString();
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Close();
        }
        private void btnVenderPrazo_Click(object sender, EventArgs e)
        {       
            CriarComandaF criar = new CriarComandaF(false);
            criar.ShowDialog();
            Hide();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            VNDINFO VN = new VNDINFO("", "", true);
            VN.Show();
            Hide();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CPFDoCliente = (string)dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value;
            string NomeDoCliente = (string)dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value;
            VNDINFO vn = new VNDINFO(NomeDoCliente, CPFDoCliente, false);
            vn.Show();
            Hide();
        }

        private void btnreceber_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Visible)
                dataGridView2.Visible = false;
            else
                dataGridView2.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string produto = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value;
            string valor = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString().Replace(",00", ",");
            int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
            lblNome.Visible = true;
            lblValor.Visible = true;
            lblQtd.Visible = true;
            lblR.Visible = true;
            lblNome.Text = produto;
            lblValor.Text = valor;
            lblQtd.Text = qtd.ToString();
        }

        private void btnAdicionarQtd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                string produto = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value;
                double valor = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                int a = int.Parse(txtAdicionarQtd.Text);
                Produtos p = new Produtos();
                p.AdicionarQtd(id, produto, valor, qtd += a, "Produtos_Tabacaria");
                lblQtd.Text = qtd.ToString();
                CarregarTabelas();
                if (p.Mensagem.Equals(""))
                    MessageBox.Show("Unidade(s) adicionadas com sucesso!!", "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(p.Mensagem);
            }
            catch (Exception) { MessageBox.Show("ERRO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdcEst adicionar = new AdcEst(0, "", 0.0, 0, "Produtos_Tabacaria");
            adicionar.ShowDialog();
            CarregarTabelas();
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string produto = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value;
            double valor = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
            int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
            AdcEst adicionar = new AdcEst(id, produto, valor, qtd, "Produtos_Tabacaria");
            adicionar.ShowDialog();
            CarregarTabelas();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            Produtos produtos = new Produtos();
            if (produtos.Mensagem.Equals(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar esse produto permanentemente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    produtos.Id = id;
                    produtos.RemoverItens("Produtos_Tabacaria");
                    MessageBox.Show("Produto removido", "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show(produtos.Mensagem);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
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
                else
                    a = z;
                dataGridView1.DataSource = produtos.TodosProdutosSelect(a, b, "Produtos_Tabacaria");
                lblContagem.Text = dataGridView1.Rows.Count.ToString();
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnRosh_Click(object sender, EventArgs e) { Buscar("Essência"); }
        private void btnBebidas_Click(object sender, EventArgs e) { Buscar("Bebidas"); }
        private void btnEstoque_Click(object sender, EventArgs e) { CarregarTabelas(); }
        private void TabacariaF_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    btnVoltar_Click(sender, e);
                    break;
            }
        }
    }
}
