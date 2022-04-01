using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class EstoqueF : Form
    {
        private Produto _produtos;
        private List<Produto> _produtosList;
        public EstoqueF()
        {
            InitializeComponent();
            _produtos = new Produto();
            CarregarProdutos();
        }
        private void CarregarProdutos()
        {
            try
            {
                _produtosList = _produtos.Todos();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _produtosList;
                lblContagem.Text = dataGridView1.Rows.Count.ToString();
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
                dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Green;
                dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 80;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Buscar(string chave, bool typ)
        {
            try
            {
                List<Produto> list = new List<Produto>();
                foreach (Produto p in _produtosList)
                {
                    if (typ)
                        if (p.Nome.Contains(chave)) { list.Add(p); }
                    if (!typ)
                        if (p.Categoria.Equals(chave)) { list.Add(p); }
                }
                dataGridView1.DataSource = list;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.ToUpper();
            Buscar(buscar, true);
        }
        private void btnEstoque_Click(object sender, EventArgs e) { CarregarProdutos(); }
        private void btnBebidas_Click(object sender, EventArgs e) { Buscar("Bebidas", false); }
        private void btnRosh_Click(object sender, EventArgs e) { Buscar("Rosh", false); }
        private void btnCombo_Click(object sender, EventArgs e) { Buscar("Combos", false); }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produtos = (Produto)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            lblNome.Visible = true;
            lblQtd.Visible = true;
            lblValor.Visible = true;
            lblR.Visible = true;
            lblNome.Text = produtos.Nome;
            lblValor.Text = produtos.Valor.ToString("N2");
            lblQtd.Text = produtos.Qtd.ToString();
        }

        private void btnAdicionarQtd_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produtos = (Produto)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                _produtos.Id = produtos.Id;
                _produtos.Nome = produtos.Nome;
                _produtos.Qtd = Convert.ToInt32(txtAdicionarQtd.Text);
                _produtos.Valor = produtos.Valor;
                _produtos.Categoria = produtos.Categoria;
                _produtos.Salvar();
                lblQtd.Text = produtos.Qtd.ToString();
                CarregarProdutos();
                MessageBox.Show("Unidade(s) adicionadas com sucesso!!", "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { MessageBox.Show("ERRO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produtos = null;
            AdcEst adicionar = new AdcEst(produtos);
            adicionar.ShowDialog();
            CarregarProdutos();
        }
        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            Produto produtos = (Produto)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            AdcEst adicionar = new AdcEst(produtos);
            adicionar.ShowDialog();
            CarregarProdutos();
        }
        private void btnVoltar_Click(object sender, EventArgs e) { Close(); }       
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            Produto produtos = (Produto)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            produtos.ExcluirId();
            CarregarProdutos();
            MessageBox.Show("Produto Removido com sucesso!", "SUCESSO!!");
        }
    }
}
