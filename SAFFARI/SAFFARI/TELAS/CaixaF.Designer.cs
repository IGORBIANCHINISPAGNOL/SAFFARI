
namespace ProjetoLauge.TELAS
{
    partial class CaixaF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelEstadodoCaixa = new System.Windows.Forms.Panel();
            this.lblStatCaixa = new System.Windows.Forms.Label();
            this.lblStatData = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.txtCartaoCredito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.GridCaixa = new System.Windows.Forms.DataGridView();
            this.btnExcluirLancamento = new System.Windows.Forms.Button();
            this.btnImprimirMovimentacao = new System.Windows.Forms.Button();
            this.btnAdicionarEntradaSaida = new System.Windows.Forms.Button();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalDinheiro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaidaPix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaidaDinheiro = new System.Windows.Forms.TextBox();
            this.txtCartaoDebito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistoricoCaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelEstadodoCaixa.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCaixa)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnAbrirCaixa);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panelEstadodoCaixa);
            this.panel1.Controls.Add(this.lblStatData);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 560);
            this.panel1.TabIndex = 3;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAbrirCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaixa.ImageIndex = 6;
            this.btnAbrirCaixa.ImageList = this.imageList1;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(16, 504);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(142, 39);
            this.btnAbrirCaixa.TabIndex = 29;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imprimir-sinal-de-ferramenta-de-interface-preenchido.png");
            this.imageList1.Images.SetKeyName(1, "lixeira.png");
            this.imageList1.Images.SetKeyName(2, "mais.png");
            this.imageList1.Images.SetKeyName(3, "cadeado-aberto.png");
            this.imageList1.Images.SetKeyName(4, "cadeado.png");
            this.imageList1.Images.SetKeyName(5, "relogio.png");
            this.imageList1.Images.SetKeyName(6, "cadeado-fechado.png");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(13, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Saldo inicial";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(9, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Data da Abertura:";
            // 
            // panelEstadodoCaixa
            // 
            this.panelEstadodoCaixa.BackColor = System.Drawing.Color.LimeGreen;
            this.panelEstadodoCaixa.Controls.Add(this.lblStatCaixa);
            this.panelEstadodoCaixa.Location = new System.Drawing.Point(0, 0);
            this.panelEstadodoCaixa.Name = "panelEstadodoCaixa";
            this.panelEstadodoCaixa.Size = new System.Drawing.Size(192, 51);
            this.panelEstadodoCaixa.TabIndex = 26;
            // 
            // lblStatCaixa
            // 
            this.lblStatCaixa.AutoSize = true;
            this.lblStatCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatCaixa.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatCaixa.Location = new System.Drawing.Point(6, 13);
            this.lblStatCaixa.Name = "lblStatCaixa";
            this.lblStatCaixa.Size = new System.Drawing.Size(164, 25);
            this.lblStatCaixa.TabIndex = 13;
            this.lblStatCaixa.Text = "estado do caixa";
            // 
            // lblStatData
            // 
            this.lblStatData.AutoSize = true;
            this.lblStatData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatData.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatData.Location = new System.Drawing.Point(12, 346);
            this.lblStatData.Name = "lblStatData";
            this.lblStatData.Size = new System.Drawing.Size(36, 18);
            this.lblStatData.TabIndex = 25;
            this.lblStatData.Text = "data";
            this.lblStatData.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtSaldoInicial);
            this.panel3.Location = new System.Drawing.Point(12, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 33);
            this.panel3.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(40, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "R$";
            this.label13.Visible = false;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.BackColor = System.Drawing.Color.DimGray;
            this.txtSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSaldoInicial.Location = new System.Drawing.Point(71, 6);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(71, 17);
            this.txtSaldoInicial.TabIndex = 30;
            this.txtSaldoInicial.Text = "00,00";
            this.txtSaldoInicial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSaldoInicial_MouseClick);
            // 
            // txtCartaoCredito
            // 
            this.txtCartaoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtCartaoCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCartaoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartaoCredito.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCartaoCredito.Location = new System.Drawing.Point(192, 104);
            this.txtCartaoCredito.Name = "txtCartaoCredito";
            this.txtCartaoCredito.Size = new System.Drawing.Size(83, 15);
            this.txtCartaoCredito.TabIndex = 23;
            this.txtCartaoCredito.Text = "0,00";
            this.txtCartaoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "CARTÃO/CRÉDITO:";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDinheiro.Location = new System.Drawing.Point(192, 49);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(83, 15);
            this.txtDinheiro.TabIndex = 21;
            this.txtDinheiro.Text = "0,00";
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "CARTÃO/DÉBITO:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSaldo.Location = new System.Drawing.Point(8, 19);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(186, 16);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "(+) ENTRADAS NO CAIXA";
            // 
            // GridCaixa
            // 
            this.GridCaixa.AllowUserToAddRows = false;
            this.GridCaixa.AllowUserToDeleteRows = false;
            this.GridCaixa.AllowUserToResizeColumns = false;
            this.GridCaixa.AllowUserToResizeRows = false;
            this.GridCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridCaixa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCaixa.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridCaixa.Location = new System.Drawing.Point(198, 50);
            this.GridCaixa.MultiSelect = false;
            this.GridCaixa.Name = "GridCaixa";
            this.GridCaixa.ReadOnly = true;
            this.GridCaixa.RowHeadersVisible = false;
            this.GridCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCaixa.Size = new System.Drawing.Size(637, 449);
            this.GridCaixa.TabIndex = 10;
            // 
            // btnExcluirLancamento
            // 
            this.btnExcluirLancamento.FlatAppearance.BorderSize = 0;
            this.btnExcluirLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirLancamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirLancamento.ImageIndex = 1;
            this.btnExcluirLancamento.ImageList = this.imageList1;
            this.btnExcluirLancamento.Location = new System.Drawing.Point(198, 505);
            this.btnExcluirLancamento.Name = "btnExcluirLancamento";
            this.btnExcluirLancamento.Size = new System.Drawing.Size(178, 39);
            this.btnExcluirLancamento.TabIndex = 5;
            this.btnExcluirLancamento.Text = "Excluir Lançamento";
            this.btnExcluirLancamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirLancamento.UseVisualStyleBackColor = true;
            this.btnExcluirLancamento.Click += new System.EventHandler(this.btnExcluirLancamento_Click);
            // 
            // btnImprimirMovimentacao
            // 
            this.btnImprimirMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnImprimirMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirMovimentacao.ImageIndex = 0;
            this.btnImprimirMovimentacao.ImageList = this.imageList1;
            this.btnImprimirMovimentacao.Location = new System.Drawing.Point(382, 505);
            this.btnImprimirMovimentacao.Name = "btnImprimirMovimentacao";
            this.btnImprimirMovimentacao.Size = new System.Drawing.Size(215, 39);
            this.btnImprimirMovimentacao.TabIndex = 6;
            this.btnImprimirMovimentacao.Text = "Imprimir Movimentação";
            this.btnImprimirMovimentacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirMovimentacao.UseVisualStyleBackColor = true;
            this.btnImprimirMovimentacao.Click += new System.EventHandler(this.btnImprimirMovimentacao_Click);
            // 
            // btnAdicionarEntradaSaida
            // 
            this.btnAdicionarEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnAdicionarEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarEntradaSaida.ImageIndex = 2;
            this.btnAdicionarEntradaSaida.ImageList = this.imageList1;
            this.btnAdicionarEntradaSaida.Location = new System.Drawing.Point(900, 6);
            this.btnAdicionarEntradaSaida.Name = "btnAdicionarEntradaSaida";
            this.btnAdicionarEntradaSaida.Size = new System.Drawing.Size(223, 39);
            this.btnAdicionarEntradaSaida.TabIndex = 8;
            this.btnAdicionarEntradaSaida.Text = "Adicionar Entrada / Saída";
            this.btnAdicionarEntradaSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarEntradaSaida.UseVisualStyleBackColor = true;
            this.btnAdicionarEntradaSaida.Click += new System.EventHandler(this.btnAdicionarEntradaSaida_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.FlatAppearance.BorderSize = 0;
            this.btnFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharCaixa.ImageIndex = 6;
            this.btnFecharCaixa.ImageList = this.imageList1;
            this.btnFecharCaixa.Location = new System.Drawing.Point(841, 505);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(142, 39);
            this.btnFecharCaixa.TabIndex = 9;
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtTotalDinheiro);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPix);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtSaidaPix);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSaidaDinheiro);
            this.panel2.Controls.Add(this.txtCartaoDebito);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCartaoCredito);
            this.panel2.Controls.Add(this.lblSaldo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDinheiro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(841, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 449);
            this.panel2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(16, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotal.Location = new System.Drawing.Point(192, 310);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(83, 15);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDinheiro
            // 
            this.txtTotalDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtTotalDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDinheiro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalDinheiro.Location = new System.Drawing.Point(192, 286);
            this.txtTotalDinheiro.Name = "txtTotalDinheiro";
            this.txtTotalDinheiro.Size = new System.Drawing.Size(83, 15);
            this.txtTotalDinheiro.TabIndex = 35;
            this.txtTotalDinheiro.Text = "0,00";
            this.txtTotalDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(16, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Somente Dinheiro:";
            // 
            // txtPix
            // 
            this.txtPix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtPix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPix.Location = new System.Drawing.Point(192, 130);
            this.txtPix.Name = "txtPix";
            this.txtPix.Size = new System.Drawing.Size(83, 15);
            this.txtPix.TabIndex = 33;
            this.txtPix.Text = "0,00";
            this.txtPix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(16, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "PIX:";
            // 
            // txtSaidaPix
            // 
            this.txtSaidaPix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtSaidaPix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaidaPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidaPix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSaidaPix.Location = new System.Drawing.Point(192, 219);
            this.txtSaidaPix.Name = "txtSaidaPix";
            this.txtSaidaPix.Size = new System.Drawing.Size(83, 15);
            this.txtSaidaPix.TabIndex = 31;
            this.txtSaidaPix.Text = "0,00";
            this.txtSaidaPix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(16, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "PIX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "DINHEIRO:";
            // 
            // txtSaidaDinheiro
            // 
            this.txtSaidaDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtSaidaDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaidaDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidaDinheiro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSaidaDinheiro.Location = new System.Drawing.Point(192, 194);
            this.txtSaidaDinheiro.Name = "txtSaidaDinheiro";
            this.txtSaidaDinheiro.Size = new System.Drawing.Size(83, 15);
            this.txtSaidaDinheiro.TabIndex = 28;
            this.txtSaidaDinheiro.Text = "0,00";
            this.txtSaidaDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCartaoDebito
            // 
            this.txtCartaoDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.txtCartaoDebito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCartaoDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartaoDebito.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCartaoDebito.Location = new System.Drawing.Point(192, 76);
            this.txtCartaoDebito.Name = "txtCartaoDebito";
            this.txtCartaoDebito.Size = new System.Drawing.Size(83, 15);
            this.txtCartaoDebito.TabIndex = 27;
            this.txtCartaoDebito.Text = "0,00";
            this.txtCartaoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "DINHEIRO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(8, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "(=) SALDO FINAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(8, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "(-) SAÍDAS DO CAIXA";
            // 
            // btnHistoricoCaixa
            // 
            this.btnHistoricoCaixa.FlatAppearance.BorderSize = 0;
            this.btnHistoricoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoricoCaixa.ImageIndex = 5;
            this.btnHistoricoCaixa.ImageList = this.imageList1;
            this.btnHistoricoCaixa.Location = new System.Drawing.Point(609, 505);
            this.btnHistoricoCaixa.Name = "btnHistoricoCaixa";
            this.btnHistoricoCaixa.Size = new System.Drawing.Size(173, 39);
            this.btnHistoricoCaixa.TabIndex = 11;
            this.btnHistoricoCaixa.Text = "Histórico do Caixa";
            this.btnHistoricoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistoricoCaixa.UseVisualStyleBackColor = true;
            this.btnHistoricoCaixa.Click += new System.EventHandler(this.btnHistoricoCaixa_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.ImageIndex = 6;
            this.btnSair.Location = new System.Drawing.Point(1034, 513);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 31);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair (Esc)";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // CaixaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1140, 556);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistoricoCaixa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.btnAdicionarEntradaSaida);
            this.Controls.Add(this.btnImprimirMovimentacao);
            this.Controls.Add(this.btnExcluirLancamento);
            this.Controls.Add(this.GridCaixa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CaixaF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINANCEIRO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaixaF_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEstadodoCaixa.ResumeLayout(false);
            this.panelEstadodoCaixa.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCaixa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEstadodoCaixa;
        private System.Windows.Forms.Label lblStatCaixa;
        private System.Windows.Forms.Label lblStatData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCartaoCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridView GridCaixa;
        private System.Windows.Forms.Button btnExcluirLancamento;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnImprimirMovimentacao;
        private System.Windows.Forms.Button btnAdicionarEntradaSaida;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCartaoDebito;
        private System.Windows.Forms.TextBox txtPix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaidaPix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaidaDinheiro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalDinheiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Button btnHistoricoCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAbrirCaixa;
    }
}