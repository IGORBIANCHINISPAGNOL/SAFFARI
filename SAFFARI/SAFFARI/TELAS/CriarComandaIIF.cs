using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class CriarComandaIIF : Form
    {      
        Cliente cliente = new Cliente();
        public CriarComandaIIF(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            lblNomeCliente.Text = cliente.Nome;
            txtNPulseira.Select();
        }
        private void CriarComandaIIF_Load(object sender, EventArgs e)
        {
            int[] numerosBistro = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosSofa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosCamarotes = { 1, 2 };
            ComboBistro.DataSource = numerosBistro;
            ComboSofa.DataSource = numerosSofa;
            ComboCamarote.DataSource = numerosCamarotes;
            ComboCamarote.Text = "";
            ComboBistro.Text = "";
            ComboSofa.Text = "";          
            lblStats.Text = "";
        }

        private bool Pagar = true;
        private bool Cobrar = true;
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            try
            {
                comanda.Nome = cliente.Nome;
                comanda.CPF = cliente.CPF;
                comanda.Pulseira = txtNPulseira.Text;
                comanda.Posicao = lblStats.Text;
                comanda.ClienteId = cliente.Id;
                comanda.Salvar();
                CMDINFO INF = new CMDINFO(comanda);
                INF.Show();
                Close();
            }
            catch { MessageBox.Show($"Selecione o cliente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void ComboCamarote_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = (ComboCamarote.SelectedIndex + 1).ToString();
            lblStats.Text = "CAMAROTE " + a;
        }
        private void ComboBistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = (ComboBistro.SelectedIndex + 1).ToString();
            lblStats.Text = "BISTRO " + a;
        }
        private void ComboSofa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = (ComboSofa.SelectedIndex + 1).ToString();
            lblStats.Text = "SOFA " + a;
        }
        private void btnNenhum_Click(object sender, EventArgs e) { lblStats.Text = "NENHUM"; }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Pagar && Cobrar)
            {
                CriarComandaF criar = new CriarComandaF();
                criar.Show();
                Close();
            }
            else
                MessageBox.Show("Entrada cobrada você deve finalizar à comanda", "Erro!");
        }
        private void CriarComandaIIF_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btnGravar_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnVoltar_Click(sender, e);
                    break;                    
            }
        }
        private void txtNPulseira_MouseClick(object sender, MouseEventArgs e) { txtNPulseira.Text = ""; }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            Pagar = false;
            Comanda comanda = new Comanda();
            comanda.Nome = cliente.Nome;
            comanda.CPF = cliente.CPF;
            comanda.Pulseira = txtNPulseira.Text;
            comanda.Posicao = "000";
            comanda.ClienteId = cliente.Id;
            FinalizarCF finalizarCF = new FinalizarCF(comanda);
            finalizarCF.ShowDialog();
            if (finalizarCF.Result)
            {
                CriarComandaF cmd = new CriarComandaF();
                cmd.Show();
                Close();
            }
        }
        private void btnAdicionarEntrada_Click(object sender, EventArgs e)
        {
            lblEntradaCobr.Visible = true;
            Cobrar = false;
            Consumo consumo = new Consumo();
            consumo.Produto = "ENTRADA";
            consumo.Valor = Convert.ToDecimal(txtAdicionarEntrada.Text);
            consumo.Qtd = 1;
            consumo.Horario = DateTime.Now;
            consumo.ClienteId = cliente.Id;
            consumo.ProdutoId = 99999; 
            consumo.Salvar();
        }              
        private void txtAdicionarEntrada_MouseClick(object sender, MouseEventArgs e) { txtAdicionarEntrada.Text = ""; }       
    }
}
