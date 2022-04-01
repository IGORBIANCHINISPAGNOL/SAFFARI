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
    public partial class AdcValores : Form
    {
        private Comanda _comanda;
        public AdcValores(Comanda comanda)
        {
            InitializeComponent();
            _comanda = comanda;
        }
        private void btnAdicionarValor_Click(object sender, EventArgs e)
        {
            try
            {
                Consumo consumo = new Consumo();                   
                consumo.Produto = txbDescricaovaloradd.Text.Insert(0, " + "); ;
                consumo.Valor = Convert.ToDecimal(txbValorAddRemov.Text.Replace(".", ","));                
                consumo.Horario = DateTime.Now;
                consumo.Qtd = 1;
                consumo.ClienteId = _comanda.ClienteId;
                consumo.ProdutoId = 9999;           
                consumo.Salvar();
                Close();
                MessageBox.Show("Valor Adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { MessageBox.Show($"ERRO!!...", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbDescricaovaloradd_MouseClick(object sender, MouseEventArgs e)
        {
            txbDescricaovaloradd.Text = "";
        }
    }
}
