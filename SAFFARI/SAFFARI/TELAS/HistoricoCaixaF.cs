using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoLauge.TELAS
{
    public partial class HistoricoCaixaF : Form
    {
        public HistoricoCaixaF()
        {
            InitializeComponent();
            CarregarTabela();
        }
        private void CarregarTabela()
        {
            try
            {
                Financeiro financeiro = new Financeiro();
                dataGridView1.DataSource = financeiro.TodosDoFinanceiro();
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
                dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Red;
                SomarTotal();
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SomarTotal()
        {
            try
            {
                double total = 0;
                double dinheiro = 0;
                double dinheirosaida = 0;
                double pixsaida = 0;
                double cartaodebito = 0;
                double cartaocredito = 0;
                double pix = 0;
                foreach (DataGridViewRow linha in dataGridView1.Rows) { total += Convert.ToDouble(linha.Cells[2].Value); }
                foreach (DataGridViewRow lin in dataGridView1.Rows)
                {
                    if (lin.Cells[4].Value.Equals("DINHEIRO"))
                        dinheiro += Convert.ToDouble(lin.Cells[2].Value);
                }
                string Dinheiro = dinheiro.ToString(); var b = Dinheiro.Length;
                if (Dinheiro.IndexOf(",") > 0) { txtDinheiro.Text = Dinheiro; }
                else { txtDinheiro.Text = Dinheiro.Insert(b, ",00"); }
                foreach (DataGridViewRow lin in dataGridView1.Rows)
                {
                    if (lin.Cells[4].Value.Equals("CARTÃO/DÉBITO"))
                        cartaodebito += Convert.ToDouble(lin.Cells[2].Value);
                }
                string Cartaodebito = cartaodebito.ToString(); var c = Cartaodebito.Length;
                if (Cartaodebito.IndexOf(",") > 0) { txtCartaoDebito.Text = Cartaodebito; }
                else { txtCartaoDebito.Text = Cartaodebito.Insert(c, ",00"); }
                foreach (DataGridViewRow lin in dataGridView1.Rows)
                {
                    if (lin.Cells[4].Value.Equals("CARTÃO/CRÉDITO"))
                        cartaocredito += Convert.ToDouble(lin.Cells[2].Value);
                }
                string CartaoCredito = cartaocredito.ToString(); var d = CartaoCredito.Length;
                if (CartaoCredito.IndexOf(",") > 0) { txtCartaoCredito.Text = CartaoCredito; }
                else { txtCartaoCredito.Text = CartaoCredito.Insert(d, ",00"); }
                foreach (DataGridViewRow lin in dataGridView1.Rows)
                {
                    if (lin.Cells[4].Value.Equals("PIX"))
                        pix += Convert.ToDouble(lin.Cells[2].Value);
                }
                string PIX = pix.ToString(); var e = PIX.Length;
                if (PIX.IndexOf(",") > 0) { txtPix.Text = PIX; }
                else { txtPix.Text = PIX.Insert(e, ",00"); }
                foreach (DataGridViewRow lin in dataGridView1.Rows)
                {
                    if (lin.Cells[4].Value.Equals("DINHEIRO"))
                        dinheirosaida += Convert.ToDouble(lin.Cells[3].Value);
                }
                string DinheiroSaida = dinheirosaida.ToString(); var f = DinheiroSaida.Length;
                if (DinheiroSaida.IndexOf(",") > 0) { txtSaidaDinheiro.Text = DinheiroSaida; }
                else { txtSaidaDinheiro.Text = DinheiroSaida.Insert(f, ",00"); }
                foreach (DataGridViewRow lin in dataGridView1.Rows)
                {
                    if (lin.Cells[4].Value.Equals("PIX"))
                        pixsaida += Convert.ToDouble(lin.Cells[3].Value);
                }
                string PixSaida = pixsaida.ToString(); var g = PixSaida.Length;
                if (PixSaida.IndexOf(",") > 0) { txtSaidaPix.Text = PixSaida; }
                else { txtSaidaPix.Text = PixSaida.Insert(g, ",00"); }
                double SomenteDinheiro = dinheiro - dinheirosaida;
                double SaldoFinal = total - dinheirosaida - pixsaida;
                string Total = SaldoFinal.ToString(); var a = Total.Length;
                if (Total.IndexOf(",") > 0) { txtTotal.Text = Total; }
                else { txtTotal.Text = Total.Insert(a, ",00"); }
                string TotalDinheiro = SomenteDinheiro.ToString(); var h = TotalDinheiro.Length;
                if (TotalDinheiro.IndexOf(",") > 0) { txtTotalDinheiro.Text = TotalDinheiro; }
                else { txtTotalDinheiro.Text = TotalDinheiro.Insert(h, ",00"); }
            }
            catch { MessageBox.Show("Erro na soma", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


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
                        Financeiro financeiro = new Financeiro();
                        dataGridView1.DataSource = financeiro.TodosDoHistorico(dataentrada, datasaida);
                    }
                    catch { MessageBox.Show($"DATA INVÁLIDA", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
                    dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Red;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    SomarTotal();
                }
            }
            catch { MessageBox.Show($"Erro", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnImprimirMovimentacao_Click(object sender, EventArgs e)
        {
            List<string> descricao = new List<string>();
            foreach (DataGridViewRow tabela in dataGridView1.Rows)
            {
                descricao.Add(tabela.Cells[1].Value.ToString().Replace(" - ", "\n - "));
                descricao.Add(tabela.Cells[0].Value.ToString());
                descricao.Add(tabela.Cells[2].Value.ToString().Insert(0, "Entrada: R$ "));
                descricao.Add(tabela.Cells[3].Value.ToString().Insert(0, "Saida: R$ "));
                descricao.Add(tabela.Cells[4].Value.ToString().Insert(0, "Form Pgto: "));
                descricao.Add("------------------------------------------");
            }
            string a = descricao.Aggregate((x, y) => x + "\n" + y);
            ImprimirF imp = new ImprimirF(a);
            imp.ShowDialog();
        }
    }
}
