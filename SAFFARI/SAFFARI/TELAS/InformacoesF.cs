using Business;
using SAFFARI.TELAS;
using System;
using System.Windows.Forms;

namespace ProjetoLauge.TELAS
{
    public partial class InformacoesF : Form
    {
        private Comanda _comanda;
        public InformacoesF(Comanda comanda)
        {
            InitializeComponent();
            _comanda = comanda;
        }
        private void InformacoesF_Load(object sender, EventArgs e)
        {
            int[] numerosBistro = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosSofa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosCamarotes = { 1, 2 };
            ComboBistro.DataSource = numerosBistro;
            ComboSofa.DataSource = numerosSofa;
            ComboCamarote.DataSource = numerosCamarotes;
            txtNPulseira.Text = _comanda.Pulseira;
            ComboCamarote.Text = "";
            ComboBistro.Text = "";
            ComboSofa.Text = "";
            lblTitular.Text = "";
            lblStats.Text = _comanda.Posicao;
            lblNomeCliente.Text = _comanda.Nome;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CMDINFO comandainfo = new CMDINFO(_comanda);
            comandainfo.Show();
            Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            try
            {
                comanda.Id = _comanda.Id;
                comanda.CPF =  _comanda.CPF;
                comanda.Nome = _comanda.Nome;
                comanda.Pulseira = txtNPulseira.Text;
                comanda.Posicao = lblStats.Text;
                comanda.ClienteId = _comanda.ClienteId;
                comanda.Salvar();
                CMDINFO comandainfo = new CMDINFO(comanda);
                comandainfo.Show();
                Close();               
                MessageBox.Show($"Registro salvo\n\n{_comanda.Nome}\n\n{lblStats.Text}\n\nPulseira {txtNPulseira.Text}", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Erro"); }
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
        private void btnNenhum_Click(object sender, EventArgs e)
        {
            lblStats.Text = "NENHUM";
        }
        private void InformacoesF_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnGravar_Click(sender, e);
                    break;
            }
        }
    }
}
