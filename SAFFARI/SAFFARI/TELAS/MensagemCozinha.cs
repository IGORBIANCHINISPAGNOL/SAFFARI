using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class MensagemCozinha : Form
    {      
        public MensagemCozinha()
        {
            InitializeComponent();   
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font letratexto = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point pontodata = new Point(20, 10);
            Point pontotexto = new Point(20, 70);
            try
            {
                string texto = TxbInformacoes.Text;
                string data = DateTime.Now.ToString();
                if (texto.Length > 20) { texto = texto.Insert(20, "\n"); }
                if (texto.Length > 40) { texto = texto.Insert(40, "\n"); }
                if (texto.Length > 60) { texto = texto.Insert(60, "\n"); }
                e.Graphics.DrawString(data, letratexto, cor, pontodata);
                e.Graphics.DrawString(texto, letratexto, cor, pontotexto);
            }
            catch
            {
                string erro = "Erro ao tentar imprimir\n\nNenhum item selecionado";
                MessageBox.Show(erro);
                e.Graphics.DrawString(erro, letratexto, cor, pontotexto);
            }
        }

        private void btnImprimirInformacoes_Click(object sender, EventArgs e)
        {            
            try
            {
                using (var pd = new System.Drawing.Printing.PrintDocument())
                {
                    pd.PrinterSettings.PrinterName = "IMPRESSORADACOZINHA";
                    pd.PrintPage += Imprimir;
                    pd.Print();                    
                }
                MessageBox.Show("Mensagem eviada para impressão");
                Close();
            }
            catch { MessageBox.Show("Erro ao tentar imprimir\nVerifique o nome da impressora."); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
