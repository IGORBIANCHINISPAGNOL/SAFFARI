using Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class Clientes2 : Form
    {
        private Cliente _cliente;
        private List<Cliente> _clienteList;
        public Clientes2()
        {
            InitializeComponent();
            _cliente = new Cliente();                  
            Carregar();
        }

        public void Carregar()
        {
            try
            {
                _clienteList = _cliente.Todos();
                dataGridView1.AutoGenerateColumns = false;           
                dataGridView1.DataSource = _clienteList;
                //lblContagem.Text = dataGridView1.Rows.Count.ToString();
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MENU m = new MENU();
            m.Show();
            Close();
        }


        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Entre com o nome do cliente...")
                txtBuscar.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.ToUpper();
            Buscar(buscar);
        }
        private void Buscar(string chave)
        {     
            List<Cliente> list = new List<Cliente>();     
            foreach (Cliente p in _clienteList)
            {
                if (p.Nome.Contains(chave))
                    list.Add(p);
            }
            dataGridView1.DataSource = list;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.ToUpper();
            Buscar(buscar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente a = (Cliente)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            CadtClient CAD = new CadtClient(a, true);
            CAD.ShowDialog();
            Carregar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cliente a = null;            
            CadtClient CAD = new CadtClient(a, false);
            CAD.ShowDialog();
            Carregar();
        }
    }
}
