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

namespace ProjetoLauge.TELAS
{
    public partial class CaixaF : Form
    {
        public CaixaF()
        {
            InitializeComponent();
            try { Existe(); SomarTotal(); }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnSair_Click(object sender, EventArgs e) { Close(); }
        private void txtSaldoInicial_MouseClick(object sender, MouseEventArgs e) { txtSaldoInicial.Text = ""; }
        private void Existe()
        {
            Financeiro fin = new Financeiro();
            if (fin.Existe())
            {
                var data = fin.VerificarDiaCaixa();
                lblStatData.Text = data;
                lblStatData.Visible = true;
                lblStatCaixa.Text = "CAIXA ABERTO";
                CarregarTabela();
            }
            else
                lblStatCaixa.Text = "CAIXA FECHADO";
        }
        private void CarregarTabela()
        {
            try
            {
                Financeiro financeiro = new Financeiro();
                if (lblStatCaixa.Text.Equals("CAIXA ABERTO"))
                {
                    GridCaixa.DataSource = financeiro.TodosDoFinanceiro();
                    GridCaixa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    GridCaixa.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
                    GridCaixa.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                    GridCaixa.Columns[3].DefaultCellStyle.ForeColor = Color.Red;                    
                }
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
                foreach (DataGridViewRow linha in GridCaixa.Rows) { total += Convert.ToDouble(linha.Cells[2].Value); }                                    
                foreach (DataGridViewRow lin in GridCaixa.Rows) { if (lin.Cells[4].Value.Equals("DINHEIRO")) 
                        dinheiro += Convert.ToDouble(lin.Cells[2].Value); }                
                string Dinheiro = dinheiro.ToString(); var b = Dinheiro.Length;
                if (Dinheiro.IndexOf(",") > 0) { txtDinheiro.Text = Dinheiro; }                    
                else { txtDinheiro.Text = Dinheiro.Insert(b, ",00"); }                        
                foreach (DataGridViewRow lin in GridCaixa.Rows) { if (lin.Cells[4].Value.Equals("CARTÃO/DÉBITO")) 
                        cartaodebito += Convert.ToDouble(lin.Cells[2].Value); }                
                string Cartaodebito = cartaodebito.ToString(); var c = Cartaodebito.Length;
                if (Cartaodebito.IndexOf(",") > 0) { txtCartaoDebito.Text = Cartaodebito; }                    
                else { txtCartaoDebito.Text = Cartaodebito.Insert(c, ",00"); }                       
                foreach (DataGridViewRow lin in GridCaixa.Rows) { if (lin.Cells[4].Value.Equals("CARTÃO/CRÉDITO")) 
                        cartaocredito += Convert.ToDouble(lin.Cells[2].Value); }                                                                           
                string CartaoCredito = cartaocredito.ToString(); var d = CartaoCredito.Length;
                if (CartaoCredito.IndexOf(",") > 0) { txtCartaoCredito.Text = CartaoCredito; }                    
                else { txtCartaoCredito.Text = CartaoCredito.Insert(d, ",00"); }                    
                foreach (DataGridViewRow lin in GridCaixa.Rows) { if (lin.Cells[4].Value.Equals("PIX"))
                        pix += Convert.ToDouble(lin.Cells[2].Value); }                
                string PIX = pix.ToString(); var e = PIX.Length;
                if (PIX.IndexOf(",") > 0) { txtPix.Text = PIX; }                    
                else { txtPix.Text = PIX.Insert(e, ",00"); }
                foreach (DataGridViewRow lin in GridCaixa.Rows){ if (lin.Cells[4].Value.Equals("DINHEIRO"))
                        dinheirosaida += Convert.ToDouble(lin.Cells[3].Value); }
                string DinheiroSaida = dinheirosaida.ToString(); var f = DinheiroSaida.Length;
                if (DinheiroSaida.IndexOf(",") > 0) { txtSaidaDinheiro.Text = DinheiroSaida; }
                else { txtSaidaDinheiro.Text = DinheiroSaida.Insert(f, ",00"); }
                foreach (DataGridViewRow lin in GridCaixa.Rows) { if (lin.Cells[4].Value.Equals("PIX"))
                        pixsaida += Convert.ToDouble(lin.Cells[3].Value); }
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
        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            if (lblStatCaixa.Text.Equals("CAIXA FECHADO"))
            {
                lblStatData.Text = DateTime.Now.ToString();
                double entrada = Convert.ToDouble(txtSaldoInicial.Text.Replace(".", ","));
                financeiro.AbrirCaixaa(entrada);
                if (financeiro.Mensagem.Equals(""))
                {
                    lblStatCaixa.Text = "CAIXA ABERTO";
                    lblStatData.Visible = true;
                    MessageBox.Show("Caixa Aberto", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"{financeiro.Mensagem}", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Caixa já está aberto", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            CarregarTabela();
        }
        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            if (lblStatCaixa.Text.Equals("CAIXA ABERTO"))
            {
                financeiro.FechandoCaixaa(lblStatData.Text);
                lblStatCaixa.Text = "CAIXA FECHADO";
                lblStatData.Visible = false;
                GridCaixa.DataSource = "";
                MessageBox.Show("Caixa fechado", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Caixa já está fechado", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void CaixaF_FormClosed(object sender, FormClosedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
        }
        private void btnAdicionarEntradaSaida_Click(object sender, EventArgs e)
        {
            AdcEntSaidF adc = new AdcEntSaidF();
            adc.ShowDialog();
            CarregarTabela();
        }

        private void btnImprimirMovimentacao_Click(object sender, EventArgs e)
        {
            List<string> descricao = new List<string>();
            foreach(DataGridViewRow tabela in GridCaixa.Rows)
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
        private void btnExcluirLancamento_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            string data = Convert.ToString(GridCaixa.Rows[GridCaixa.CurrentCell.RowIndex].Cells[0].Value);
            financeiro.ExcluirDoCaixa(data);
            if (financeiro.Mensagem.Equals(""))
                MessageBox.Show("Item excluido com sucesso", "Sucesso!");    
            else
                MessageBox.Show(financeiro.Mensagem, "Sucesso!");
            CarregarTabela();
        }

        private void btnHistoricoCaixa_Click(object sender, EventArgs e)
        {
            HistoricoCaixaF hist = new HistoricoCaixaF();
            hist.ShowDialog();
        }
    }
}
