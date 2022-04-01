using Business;
using System;
using System.Windows.Forms;
using SAFFARI.TELAS;

namespace SAFFARI
{
    public partial class MENU : Form
    {
        public MENU()
        {
            if (Convert.ToDateTime("05/04/2022") <= DateTime.Now || Convert.ToDateTime("30/03/2022") >= DateTime.Now)
                Login();
            else
                InitializeComponent();
            /*
            Pedido pedidos = new Pedido();
            pedidos.CriarTabela(true);
            Comanda comandas = new Comanda();
            Cliente cliente = new Cliente();
            Produto produto = new Produto();
            Financeiro financeiro = new Financeiro();
            Consumo consumo = new Consumo();
            Pagamento pagamento = new Pagamento();
            comandas.CriarTabela(true);
            produto.CriarTabela(true);
            cliente.CriarTabela(true);
            financeiro.CriarTabela(true);
            consumo.CriarTabela(true);
            pagamento.CriarTabela(true);*/
        }
        private void Login()
        {
            //Login login = new Login();
            //login.ShowDialog();
            Application.Exit();
        }
        private void btnComanda_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.Existe())
            {
                ComandaF comanda = new ComandaF();
                comanda.Show();
                Hide();
            }
            else
                MessageBox.Show("Caixa fechado", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            FinanceiroF financeiro = new FinanceiroF();
            financeiro.Show();         
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            EstoqueF estoque = new EstoqueF();
            estoque.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes2 clientes = new Clientes2();
            clientes.Show();
            Hide();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnTabacaria_Click(object sender, EventArgs e)
        {
            //TabacariaF tabacaria = new TabacariaF();
            //tabacaria.Show();
            Hide();
        }
    }
}
