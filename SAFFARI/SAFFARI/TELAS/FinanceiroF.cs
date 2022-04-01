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
    public partial class FinanceiroF : Form
    {
        public FinanceiroF()
        {
            InitializeComponent();
            try { Existe(); }
            catch (Exception e) { MessageBox.Show("Erro ao tentar se comunicar\n\n" + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Existe()
        {
            Caixa caixaaberto = new Caixa();
            if (caixaaberto.Existe())
            {
                var caixlist = caixaaberto.Todos();
                lblStatData.Text = caixlist[0].Data.ToString();
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
                    GridCaixa.AutoGenerateColumns = false;
                    financeiro.Dia = Convert.ToDateTime(lblStatData.Text);
                    GridCaixa.DataSource = financeiro.Busca();
                    GridCaixa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    GridCaixa.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
                    GridCaixa.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                    GridCaixa.Columns[3].DefaultCellStyle.ForeColor = Color.Red;
                }
                SomarTotal();
            }
            catch (Exception e) { MessageBox.Show($"Erro ao tentar se comunicar\n\n{e}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                foreach (DataGridViewRow linha in GridCaixa.Rows)
                {

                    if (!linha.Cells[1].Value.Equals("CAIXA ABERTO"))
                        total += Convert.ToDouble(linha.Cells[2].Value);
                }
                foreach (DataGridViewRow lin in GridCaixa.Rows)
                {
                    if (lin.Cells[4].Value.Equals("DINHEIRO"))
                        dinheiro += Convert.ToDouble(lin.Cells[2].Value);
                    if (lin.Cells[4].Value.Equals("DINHEIRO"))
                        dinheirosaida += Convert.ToDouble(lin.Cells[3].Value);
                    if (lin.Cells[4].Value.Equals("CARTÃO/DÉBITO"))
                        cartaodebito += Convert.ToDouble(lin.Cells[2].Value);
                    if (lin.Cells[4].Value.Equals("CARTÃO/CRÉDITO"))
                        cartaocredito += Convert.ToDouble(lin.Cells[2].Value);
                    if (lin.Cells[4].Value.Equals("PIX"))
                        pix += Convert.ToDouble(lin.Cells[2].Value);
                    if (lin.Cells[4].Value.Equals("PIX"))
                        pixsaida += Convert.ToDouble(lin.Cells[3].Value);
                }
                string Dinheiro = dinheiro.ToString(); var b = Dinheiro.Length;
                if (Dinheiro.IndexOf(",") > 0) { txtDinheiro.Text = Dinheiro; }
                else { txtDinheiro.Text = Dinheiro.Insert(b, ",00"); }
                string DinheiroSaida = dinheirosaida.ToString(); var f = DinheiroSaida.Length;
                if (DinheiroSaida.IndexOf(",") > 0) { txtSaidaDinheiro.Text = DinheiroSaida; }
                else { txtSaidaDinheiro.Text = DinheiroSaida.Insert(f, ",00"); }
                string Cartaodebito = cartaodebito.ToString(); var c = Cartaodebito.Length;
                if (Cartaodebito.IndexOf(",") > 0) { txtCartaoDebito.Text = Cartaodebito; }
                else { txtCartaoDebito.Text = Cartaodebito.Insert(c, ",00"); }
                string CartaoCredito = cartaocredito.ToString(); var d = CartaoCredito.Length;
                if (CartaoCredito.IndexOf(",") > 0) { txtCartaoCredito.Text = CartaoCredito; }
                else { txtCartaoCredito.Text = CartaoCredito.Insert(d, ",00"); }
                string PIX = pix.ToString(); var e = PIX.Length;
                if (PIX.IndexOf(",") > 0) { txtPix.Text = PIX; }
                else { txtPix.Text = PIX.Insert(e, ",00"); }
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

        private void btnSair_Click(object sender, EventArgs e) { Close(); }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {

            Financeiro financeiro = new Financeiro();
            Caixa caixaaberto = new Caixa();
            if (lblStatCaixa.Text.Equals("CAIXA FECHADO"))
            {
                try
                {
                    var data = DateTime.Now;
                    var dataverificar = DateTime.Now.ToString("dd/MM/yyyy");
                    var verificacao = financeiro.VerificarAbertura();
                    if (verificacao[0].Dia < Convert.ToDateTime(dataverificar))
                    {
                        lblStatData.Text = data.ToString("dd/MM/yyyy");
                        financeiro.Entrada = Convert.ToDecimal(txtSaldoInicial.Text.Replace(".", ","));
                        financeiro.Dia = data;
                        financeiro.Data = data;
                        financeiro.Descrição = "CAIXA ABERTO";
                        financeiro.Saida = 0;
                        financeiro.FormaPgto = "DINHEIRO";
                        financeiro.Salvar();
                        caixaaberto.CriarTabela(true);
                        caixaaberto.Data = data;
                        caixaaberto.Salvar();
                        lblStatCaixa.Text = "CAIXA ABERTO";
                        lblStatData.Visible = true;
                        MessageBox.Show("Caixa Aberto", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Existe();
                    }
                    else
                        MessageBox.Show("Já existe registro de abertura de caixa na data " + verificacao[0].Dia, "Erro");
                }
                catch (Exception a) { MessageBox.Show($"Erro ao tentar se comunicar\n\n{a}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
                MessageBox.Show("Caixa já está aberto", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o caixa?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Financeiro financeiro = new Financeiro();
                if (lblStatCaixa.Text.Equals("CAIXA ABERTO"))
                {
                    financeiro.Entrada = 0;
                    financeiro.Dia = Convert.ToDateTime(lblStatData.Text);
                    financeiro.Data = DateTime.Now;
                    financeiro.Descrição = "CAIXA FECHADO";
                    financeiro.Saida = 0;
                    financeiro.FormaPgto = "";
                    financeiro.Salvar();
                    financeiro.FecharCaixa();
                    lblStatCaixa.Text = "CAIXA FECHADO";
                    lblStatData.Visible = false;
                    GridCaixa.DataSource = "CAIXA FECHADO";
                    MessageBox.Show("Caixa fechado", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Caixa já está fechado", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluirLancamento_Click(object sender, EventArgs e)
        {
            try
            {
                Financeiro fi = (Financeiro)GridCaixa.Rows[GridCaixa.CurrentCell.RowIndex].DataBoundItem;
                fi.ExcluirId();
                MessageBox.Show("Lançamento Excluido com Sucesso", "Sucesso");
                CarregarTabela();
            }
            catch { MessageBox.Show("Nenhum item selecionado", "Erro!"); }
        }

        private void btnAdicionarEntradaSaida_Click(object sender, EventArgs e)
        {
            AdicionarEntradaSaidaF adc = new AdicionarEntradaSaidaF(lblStatData.Text);
            adc.ShowDialog();
            CarregarTabela();
        }
        private void txtSaldoInicial_MouseClick(object sender, MouseEventArgs e) { txtSaldoInicial.Text = ""; }

        private void btnImprimirMovimentacao_Click(object sender, EventArgs e)
        {

        }
    }
}
