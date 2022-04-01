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
    public partial class CadtCliente2 : Form
    {
        public CadtCliente2()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CriarComandaF criarComandaF = new CriarComandaF();
            criarComandaF.Show();
            Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarCadastro();
        }
        public void GravarCadastro()
        {
            if (txtNome.Text.Replace(" ", "") == "")
                MessageBox.Show("Campo do nome está vazio");
            if (maskCPF.Text.Replace("-", "").Replace(".", "") == "")
                MessageBox.Show("Campo do CPF vazio");
            if (maskNascimento.Text == "  /  /" || Convert.ToInt32(maskNascimento.Text.Replace("/", "")) < 10000)
                MessageBox.Show("Campo da data de nascimento está vazio ou incompleto");
            else
            {
                Cliente cliente = new Cliente();
                cliente.CPF = maskCPF.Text;
                cliente.Nome = txtNome.Text.ToUpper().Trim();
                cliente.Telefone = maskTelefone.Text;
                cliente.Nascimento = maskNascimento.Text;              
                var verificacao = cliente.BuscarCliente();
                if (verificacao.CPF == null || verificacao.Nome == null)
                {
                    try
                    {
                        if (Convert.ToDateTime(maskNascimento.Text).AddYears(18) > DateTime.Now)
                        {
                            if (MessageBox.Show("CLIENTE MENOR DE IDADE!!\n\nCadastrar mesmo assim?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                cliente.Salvar();
                        }
                        else
                            cliente.Salvar();
                        var clientenovo = cliente.BuscarCliente();
                        CriarComandaIIF criar = new CriarComandaIIF(clientenovo);
                        criar.Show();
                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"DATA INVÁLIDA", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show($"Já existe cadastro nesse cpf", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
