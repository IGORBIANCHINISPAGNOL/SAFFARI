using Business;
using System;
using System.Windows.Forms;

namespace ProjetoLauge.TELAS
{
    public partial class AdcEntSaidF : Form
    {
        public AdcEntSaidF()
        {
            InitializeComponent();

        }      
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string formapgt = "";
                bool operacao = true;
                string obs = txtObs.Text.ToUpper();
                if (ckDinheiro.Checked) { formapgt = "DINHEIRO"; }
                if (ckDebito.Checked) { formapgt = "CARTÃO/DÉBITO"; }
                if (ckCredito.Checked) { formapgt = "CARTÃO/CRÉDITO"; }
                if (ckPix.Checked) { formapgt = "PIX"; }
                if (ckSaida.Checked) { operacao = false; }
                if (ckEntrada.Checked) { operacao = true; }
                if (formapgt == "")
                    MessageBox.Show("Marque uma forma de Pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (!ckEntrada.Checked && !ckSaida.Checked)
                        MessageBox.Show("Marque um tipo de operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (txtValor.Text == "")
                            MessageBox.Show("Digite um valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            double valor = Convert.ToDouble(txtValor.Text.Replace(".", ","));
                            if (txtObs.Text == "")
                                MessageBox.Show("Escreva em Observação o tipo de operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                Financeiro financeiro = new Financeiro();
                                double a = 0;
                                double b = 0;
                                if (operacao)
                                    a = valor;
                                if (!operacao)
                                    b = valor;
                                financeiro.PassarTotal(obs, a, b, formapgt);
                                if (financeiro.Mensagem.Equals(""))
                                {
                                    MessageBox.Show("Entrada/Saída Adicionada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); Close();
                                }
                                else
                                    MessageBox.Show("Erro ao adicionar no financeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ckDinheiro_MouseClick(object sender, MouseEventArgs e)
        {
            ckCredito.Checked = false;
            ckDebito.Checked = false;
            ckPix.Checked = false;
        }
        private void ckDebito_MouseClick(object sender, MouseEventArgs e)
        {
            ckCredito.Checked = false;
            ckDinheiro.Checked = false;
            ckPix.Checked = false;
            if (ckSaida.Checked)
                ckDebito.Checked = false;
        }
        private void ckCredito_MouseClick(object sender, MouseEventArgs e)
        {
            ckDebito.Checked = false;
            ckDinheiro.Checked = false;
            ckPix.Checked = false;
            if (ckSaida.Checked)
                ckCredito.Checked = false;
        }
        private void ckPix_MouseClick(object sender, MouseEventArgs e)
        {
            ckDebito.Checked = false;
            ckDinheiro.Checked = false;
            ckCredito.Checked = false;
        }
        private void ckSaida_MouseClick(object sender, MouseEventArgs e)
        {
            ckSaida.Checked = true;
            ckCredito.Checked = false;
            ckDebito.Checked = false;
            ckEntrada.Checked = false;
        }
        private void ckEntrada_MouseClick(object sender, MouseEventArgs e)
        {
            ckEntrada.Checked = true;
            ckSaida.Checked = false;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
