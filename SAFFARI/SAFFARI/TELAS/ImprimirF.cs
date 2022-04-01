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

namespace ProjetoLauge.TELAS
{
    public partial class ImprimirF : Form
    {
        public ImprimirF(string descricao)
        {
            InitializeComponent();         
            richTextBox1.Text = descricao;           
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    pd.PrinterSettings.PrinterName = "Caixa";
                    pd.PrintPage += Imprimir;
                    pd.Print();
                }
            }
            catch { MessageBox.Show("Erro ao tentar imprimir\nVerifique o nome da impressora."); }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {            
            SolidBrush cor = new SolidBrush(Color.Black);
            Point ponto = new Point(20, 10);
            Font letra = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            try { e.Graphics.DrawString(richTextBox1.Text, letra, cor, ponto); }          
            catch
            {
                string erro = "Erro ao tentar imprimir\n\nNenhum item selecionado";
                MessageBox.Show(erro);
                e.Graphics.DrawString(erro, letra, cor, ponto);
            }
        }
    }
}
