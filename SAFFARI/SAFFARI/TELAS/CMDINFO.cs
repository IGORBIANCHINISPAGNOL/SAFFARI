using Business;
using ProjetoLauge.TELAS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SAFFARI.TELAS
{
    public partial class CMDINFO : Form
    {      
        private Comanda comanda;
        private Consumo consumo;
        private List<Consumo> consumosList;
        public CMDINFO(Comanda comanda)
        {
            InitializeComponent();
            consumo = new Consumo();
            this.comanda = comanda;
            lblNomedoCliente.Text = comanda.Nome;
            lblPulseira.Text = comanda.Pulseira;
            lblLugar.Text = comanda.Posicao;
            CarregarTabConsumo();
            SomarTotal();
             
        }        
        public void CarregarTabConsumo()
        {
            consumo.ClienteId = comanda.ClienteId;
            consumosList = consumo.Consumos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = consumosList;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Gray;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;        
            SomarTotal();
        }
        public void SomarTotal()
        {
            Decimal total = 0;         
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                var conta = Convert.ToDecimal(linha.Cells[2].Value);
                var qtd = Convert.ToInt32(linha.Cells[0].Value);
                total += conta * qtd;                
            }                       
            txtTotal.Text = total.ToString("N2");          
        }
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            ComandaF comanda = new ComandaF();
            comanda.Show();
            Close();
        }
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover esse item?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                RemoverItem();            
        }
        public void RemoverItem()
        {
            try
            {
                consumo = (Consumo)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
                consumo.ExcluirId();
                CarregarTabConsumo();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnFinalizarComanda_Click(object sender, EventArgs e)
        {
            FinalizarCF finalizarCF = new FinalizarCF(comanda);
            finalizarCF.ShowDialog();            
            if (finalizarCF.Result)
            {
                ComandaF cmd = new ComandaF();
                cmd.Show();
                Close();
            }
            else
                CarregarTabConsumo();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            InformacoesF informacoes = new InformacoesF(comanda);
            informacoes.ShowDialog();
            Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows == null)
                    MessageBox.Show("Selecione um produto para reemprimir");
                else if (MessageBox.Show("Reenviar esse item para cozinha?", "Cozinha", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string produto = (string)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                    int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                    EditarImpressaoF editar = new EditarImpressaoF(comanda, produto, qtd);
                    editar.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CMDINFO_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    btnLocalizarProduto_Click(sender, e);
                    break;
                case Keys.F4:btnFinalizarComanda_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnVoltar_Click(sender, e);
                    break;
            }
        }
        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {         
            ProdCMD prod = new ProdCMD(comanda);
            prod.ShowDialog();   
            CarregarTabConsumo();
        }

        private void btnAdcValores_Click(object sender, EventArgs e)
        {
            AdcValores adc = new AdcValores(comanda);
            adc.ShowDialog();
            CarregarTabConsumo();
        }
    }
}
