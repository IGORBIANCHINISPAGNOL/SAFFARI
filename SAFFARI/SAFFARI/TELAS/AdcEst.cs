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
    public partial class AdcEst : Form
    {
        private Produto _produto;
        public AdcEst(Produto produto)
        {
            InitializeComponent();
            _produto = produto;
            if (produto != null)
                Preencher();
        }
        public void Preencher()
        {
            txbQuantidade.Select();
            txbNome.Text = _produto.Nome;
            txbQuantidade.Text = _produto.Qtd.ToString();
            txbPreco.Text = _produto.Valor.ToString("N2");
            comboTipo.Text = _produto.Categoria;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo do nome está vazio");
                txbNome.Select();
            }
            else if (txbPreco.Text.Replace(" ", "").Replace(",", "") == "" || txbPreco.Text.Length < 4)
            {
                MessageBox.Show("Preço inválido\n\nFormato aceito EX: R$ 19,99");
                txbPreco.Select();
            }
            else
            {
                try
                {
                    Produto produto = new Produto();
                    if (_produto == null)
                        produto.Id = 0;
                    else
                        produto.Id = _produto.Id;
                    produto.Nome = txbNome.Text.ToUpper().Trim();
                    produto.Valor = Convert.ToDecimal(txbPreco.Text.Replace(".",","));
                    produto.Qtd = int.Parse(txbQuantidade.Text);
                    produto.Categoria = comboTipo.Text.ToUpper();
                    produto.Salvar();
                    if (produto.Id == 0)
                    {
                        MessageBox.Show("Produto cadastrado com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbNome.Select();
                        txbNome.Text = "";
                        txbPreco.Text = "";
                        txbQuantidade.Text = "";
                    }
                    else
                        MessageBox.Show("Produto alterado com sucesso", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch { MessageBox.Show("Erro, verifique os valores", "Erro"); }               
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
