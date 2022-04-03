using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Business;

namespace SAFFARI.TELAS
{
    public partial class ComandaF : Form
    {
        private Comanda comanda;
        private List<Comanda> comandalist;
        public ComandaF()
        {
            InitializeComponent();
            comanda = new Comanda();
            CarregarTabelas();
        }
        private void CarregarTabelas()
        {            
            dataGridView1.AutoGenerateColumns = false;
            try 
            {
                comandalist = comanda.Todos();
                dataGridView1.DataSource = comandalist;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].Width = 100;
                //dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;     
                lblContagem.Text = dataGridView1.Rows.Count.ToString(); 
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {             
            Comanda a = (Comanda)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;         
            CMDINFO INF = new CMDINFO(a);
            INF.Show();
            Hide();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Close();
        }
        private void btnCriarNovaComanda_Click(object sender, EventArgs e)
        {
            CriarComandaF criar = new CriarComandaF();
            criar.ShowDialog();
            Hide();
        }
        private void ComandaF_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnCriarNovaComanda_Click(sender, e);
                    break;
                case Keys.F3:
                    btnCadastrar_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnVoltar_Click(sender, e);
                    break;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente a = null;
            CadtClient client = new CadtClient(a, false);
            client.ShowDialog();
        }             
        private void Buscar(int type, string chave)
        {
            try
            {
                List<Comanda> list = new List<Comanda>();
                foreach (Comanda p in comandalist)
                {
                    if (type == 0)
                    {
                        if (p.Pulseira.ToString().StartsWith(chave))
                            list.Add(p);
                    }
                    if (type == 1)
                    {
                        if (p.Nome.Contains(chave))
                            list.Add(p);
                    }
                    if (type == 2)
                    {
                        if (p.Nome.Contains("-"))
                            list.Add(p);
                    }
                    if (type == 3)
                    {
                        if (p.Nome.Contains("*"))
                            list.Add(p);
                    }
                    if (type == 4)
                    {
                        if (!p.Nome.Contains("-") & !p.Nome.Contains("*"))
                            list.Add(p);
                    }
                }
                dataGridView1.DataSource = list;
            }
            catch { MessageBox.Show("Erro ao tentar se comunicar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }              
        private void txtBuscarComandaPulseira_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:                    
                    btnAbrirComanda_Click(sender, e);
                    break;
            }
        }
        private void btnAbrirComanda_Click(object sender, EventArgs e)
        {
            AbrirComanda();
        }
        private void AbrirComanda()
        {
            try
            {
                dataGridView1.Select();
                Comanda comanda = (Comanda)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                CMDINFO INF = new CMDINFO(comanda);
                INF.Show();
                Hide();
            }
            catch { MessageBox.Show("Selecione a comanda "); }
        }                         

        private void txtBuscarComandaPulseira_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscarComandaPulseira.Text.Trim();
            Buscar(0, buscar);
        }

        private void txtBuscarComandaNome_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscarComandaNome.Text.ToUpper().Trim();
            Buscar(1, buscar);            
        }

        private void txtBuscarComandaNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    btnAbrirComanda_Click(sender, e);
                    break;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MensagemCozinha mensagemCozinha = new MensagemCozinha();
            mensagemCozinha.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscarComandaPulseira.Text.Trim();
            Buscar(2, buscar);
        }

        private void btnAtivas_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscarComandaPulseira.Text.Trim();
            Buscar(4, buscar);
        }

        private void btnArquivadas_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscarComandaPulseira.Text.Trim();
            Buscar(3, buscar);
            Teste();
        }
        private void Teste()
        {

        }
    }
}
