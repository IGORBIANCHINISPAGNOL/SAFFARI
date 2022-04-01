using Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class CadtClient : Form
    {
        bool Alterar;
        Cliente cliente = new Cliente();
        public CadtClient(Cliente cliente, bool alterar)
        {
            InitializeComponent();
            Alterar = alterar;
            this.cliente = cliente;
            if (alterar)
                Preencher(cliente);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Preencher(Cliente cliente)
        {
            txtNome.Text = cliente.Nome;
            maskCPF.Text = cliente.CPF;
            maskTelefone.Text = cliente.Telefone;
            maskNascimento.Text = cliente.Nascimento;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarCadastro();
            if (Alterar)
                Close();
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
                Cliente clientes = new Cliente();
                if (Alterar)
                    clientes.Id = cliente.Id;
                clientes.CPF = maskCPF.Text;
                clientes.Nome = txtNome.Text.ToUpper().Trim();
                clientes.Telefone = maskTelefone.Text;
                clientes.Nascimento = maskNascimento.Text;
                Cliente verificacao = null;
                if (!Alterar)
                    verificacao = clientes.BuscarCliente();
                else
                    verificacao = null;
                if (verificacao == null)
                {
                    try
                    {
                        if (Convert.ToDateTime(maskNascimento.Text).AddYears(18) > DateTime.Now)
                        {
                            if (MessageBox.Show("CLIENTE MENOR DE IDADE!!\n\nCadastrar mesmo assim?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                clientes.Salvar();
                                MessageBox.Show("Cliente cadastrado com sucesso!!", "SUCESSO!!");
                                txtNome.Text = "";
                                maskCPF.Text = "";
                                maskTelefone.Text = "";
                                maskNascimento.Text = "";
                                txtNome.Select();
                            }
                        }
                        else
                        {
                            clientes.Salvar();
                            MessageBox.Show("Cliente cadastrado com sucesso!!", "SUCESSO!!");
                            txtNome.Text = "";
                            maskCPF.Text = "";
                            maskTelefone.Text = "";
                            maskNascimento.Text = "";
                            txtNome.Select();
                        }
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
