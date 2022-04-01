using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class EditarImpressaoF : Form
    {
        bool result { get; set; }
        string Produto = "";
        Comanda comanda = new Comanda();
        int Qtd = 0;
        public EditarImpressaoF(Comanda comanda, string produto, int qtd)
        {
            InitializeComponent();
            this.comanda = comanda;
            Produto = produto;
            Qtd += qtd;
            comanda.Pulseira = "PULSEIRA " + comanda.Pulseira;
        }
        private void btnImprimirInformacoes_Click(object sender, EventArgs e)
        {
            using (var pd = new System.Drawing.Printing.PrintDocument())
            {
                pd.PrinterSettings.PrinterName = "IMPRESSORADACOZINHA";
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
            Close();
        }

        private void Pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font letradata = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letranome = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letraproduto = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letralocal = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Pixel);
            Font letrapulseira = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point pontodata = new Point(20, 10);
            Point pontonome = new Point(20, 25);
            Point pontopulseira = new Point(20, 60);
            Point pontolocal = new Point(20, 100);
            Point pontoproduto = new Point(20, 150);
            Point pontotexto = new Point(20, 190);
            try
            {
                string texto = TxbInformacoes.Text;
                Produto = Produto.Insert(0, $"{Qtd.ToString()} - ");
                if (Produto.Length > 20) { Produto = Produto.Insert(20, "\n"); pontotexto = new Point(20, 210); }
                if (Produto.Length > 40) { Produto = Produto.Insert(40, "\n"); pontotexto = new Point(20, 230); }
                if (Produto.Length > 60) { Produto = Produto.Insert(60, "\n"); pontotexto = new Point(20, 250); }
                if (texto.Length > 30) { texto = texto.Insert(30, "\n"); }
                string data = DateTime.Now.ToString();
                e.Graphics.DrawString(data, letradata, cor, pontodata);
                e.Graphics.DrawString(comanda.Nome, letranome, cor, pontonome);
                e.Graphics.DrawString(comanda.Pulseira, letrapulseira, cor, pontopulseira);
                e.Graphics.DrawString(comanda.Posicao, letralocal, cor, pontolocal);
                e.Graphics.DrawString(Produto, letraproduto, cor, pontoproduto);
                e.Graphics.DrawString(texto, letranome, cor, pontotexto);
            }
            catch
            {
                string erro = "Erro ao tentar imprimir\n\nNenhum item selecionado";
                MessageBox.Show(erro);
                e.Graphics.DrawString(erro, letraproduto, cor, pontoproduto);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            result = false;
            Close();
        }
    }
}
