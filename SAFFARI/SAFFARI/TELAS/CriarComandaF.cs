using Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class CriarComandaF : Form
    {

        public CriarComandaF()
        {
            InitializeComponent();
        }
        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            try
            {        
                Cliente cliente = (Cliente)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                Comanda comanda = new Comanda();
                comanda.ClienteId = cliente.Id;
                var existe = comanda.BuscarComanda();
                if (existe.Count == 0)
                {
                    CriarComandaIIF criar = new CriarComandaIIF(cliente);
                    criar.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Já existe comanda aberta nesse cadastro");
            }
            catch { MessageBox.Show("Cliente Inválido"); }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
                Buscar();
        }
        private void Buscar()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                Cliente clientes = new Cliente();
                clientes.Nome = txtBuscar.Text;
                dataGridView1.DataSource = clientes.Buscar();
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
        private void ComandaF_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnSelecionarCliente_Click(sender, e);
                    break;
                case Keys.F3:
                    btnCadastrar_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnCancelar_Click(sender, e);
                    break;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ComandaF comanda = new ComandaF();
            comanda.Show();
            Close();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {       
            CadtCliente2 client = new CadtCliente2();
            client.Show();
            Hide();         
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
    }
}
