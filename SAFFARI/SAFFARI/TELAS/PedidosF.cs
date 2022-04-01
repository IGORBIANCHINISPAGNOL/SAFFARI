using Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoLauge.TELAS
{
    public partial class PedidosF : Form
    {
        public PedidosF()
        {
            InitializeComponent();
            CarregarTabela();
        }      
        private void CarregarTabela()
        {
            Consumo consumo = new Consumo();
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            try { dataGridView1.DataSource = consumo.TodosPedidos(data, data);}
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Gray;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Gray;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[4].Width = 80;
        }
        private void button1_Click(object sender, EventArgs e) { ComandaF comanda = new ComandaF(); comanda.Show(); Close(); }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string dataentrada = txtEntradaData.Text;
                string datasaida = txtSaidaData.Text;
                if (dataentrada == "  /  /" || Convert.ToInt32(dataentrada.Replace("/", "")) < 10000)
                    MessageBox.Show("Data Inválida");
                else if (datasaida == "  /  /" || Convert.ToInt32(datasaida.Replace("/", "")) < 10000)
                    MessageBox.Show("Data Inválida");
                else
                {
                    try
                    {
                        Consumo consumo = new Consumo();
                        dataGridView1.DataSource = consumo.TodosPedidos(dataentrada, datasaida);
                    }
                    catch { MessageBox.Show($"DATA INVÁLIDA", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Gray;
                    dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Gray;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].Width = 200;
                    dataGridView1.Columns[3].Width = 150;
                    dataGridView1.Columns[1].Width = 100;
                    dataGridView1.Columns[4].Width = 80;
                }
            }
            catch { MessageBox.Show($"Erro", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
