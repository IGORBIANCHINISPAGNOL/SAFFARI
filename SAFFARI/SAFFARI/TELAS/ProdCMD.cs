using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class ProdCMD : Form
    {
        private Comanda _comanda;
        private Produto _produto;
        private List<Produto> _produtosList;
        public ProdCMD(Comanda comanda)
        {
            InitializeComponent();
            _comanda = comanda;
            _produto = new Produto();
            CarregarTabConsumo();            
        }
        public void CarregarTabConsumo()
        {
            _produtosList = _produto.Todos();
            dataGridView1.AutoGenerateColumns = false;     
            dataGridView1.DataSource = _produtosList;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Gray;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Consumo consumo = new Consumo();
                Pedido pedidos = new Pedido();
                _produto = (Produto)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                consumo.Produto = _produto.Nome;
                consumo.Valor = _produto.Valor;
                int num = Convert.ToInt32(txtQtdmaismenos.Text);
                consumo.Qtd = num;
                var horario = DateTime.Now;
                consumo.Horario = horario;
                consumo.ClienteId = _comanda.ClienteId;
                consumo.ProdutoId = _produto.Id;
                consumo.Salvar();
                pedidos.Cliente = _comanda.Nome;
                pedidos.CPF = _comanda.CPF;
                pedidos.Produto = _produto.Nome;
                pedidos.Horario = horario;             
                pedidos.Qtd = num;
                pedidos.ClienteId = _comanda.ClienteId;
                pedidos.Salvar();
                if (MessageBox.Show("Enviar para cozinha?", "Cozinha", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EditarImpressaoF editar = new EditarImpressaoF(_comanda, _produto.Nome, num);
                    editar.ShowDialog();
                }
                MessageBox.Show("Item Adicionado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTabConsumo();
            }
            catch (Exception) { MessageBox.Show($"Nenhum item selecionado", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtBuscar_Click(object sender, EventArgs e) { txtBuscar.Text = ""; }
        private void txbCodigoProduto_Click(object sender, EventArgs e) { txbCodigoProduto.Text = ""; }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.ToUpper();
            Buscar(0, buscar);
        }
        private void txbCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            string chave = txbCodigoProduto.Text;
            Buscar(1, chave);
        }
        private void Buscar(int type, string chave)
        {
            List<Produto> list = new List<Produto>();
            foreach (Produto p in _produtosList)
            {
                if (type == 1)
                {
                    if (p.Id.ToString().StartsWith(chave))
                        list.Add(p);
                }
                if (type == 0)
                {
                    if (p.Nome.Contains(chave))
                        list.Add(p);
                }
                if (type == 2)
                {
                    if (p.Categoria.Contains(chave))
                        list.Add(p);
                }
            }
            dataGridView1.DataSource = list;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Consumo consumo = new Consumo();
                Pedido pedidos = new Pedido();
                _produto = (Produto)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                consumo.Produto = _produto.Nome;
                consumo.Valor = _produto.Valor;
                consumo.Qtd = 1;
                var horario = DateTime.Now;
                consumo.Horario = horario;
                consumo.ClienteId = Convert.ToInt32(_comanda.ClienteId);
                consumo.ProdutoId = _produto.Id;
                consumo.Salvar();
                pedidos.Cliente = _comanda.Nome;
                pedidos.CPF = _comanda.CPF;
                pedidos.Produto = _produto.Nome;
                pedidos.Horario = horario;              
                pedidos.Qtd = 1;
                pedidos.ClienteId = _comanda.ClienteId;
                pedidos.Salvar();
                if (MessageBox.Show("Enviar para cozinha?", "Cozinha", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EditarImpressaoF editar = new EditarImpressaoF(_comanda, _produto.Nome, 1);
                    editar.ShowDialog();
                }
                MessageBox.Show("Item Adicionado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTabConsumo();
            }
            catch (Exception) { MessageBox.Show($"Nenhum item selecionado", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnQtdmais_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtQtdmaismenos.Text);
            txtQtdmaismenos.Text = (num + 1).ToString();
        }
        private void btnQtdmenos_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtQtdmaismenos.Text);
            if (num >= 2)
                txtQtdmaismenos.Text = (num - 1).ToString();
        }
        private void btnVoltar_Click(object sender, EventArgs e) { Close(); }
        private void btnProdutos_Click(object sender, EventArgs e) { dataGridView1.DataSource = _produtosList; }
        private void btnBebidas_Click(object sender, EventArgs e) { Buscar(2, "Bebidas"); }
        private void btnRosh_Click(object sender, EventArgs e) { Buscar(2, "Rosh"); }
        private void btnCombo_Click(object sender, EventArgs e) { Buscar(2, "Combos"); }

        private void ProdCMD_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnVoltar_Click(sender, e);
                    break;
            }
        }
    }
}
