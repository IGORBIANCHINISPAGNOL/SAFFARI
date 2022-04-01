
namespace ProjetoLauge.TELAS
{
    partial class TabacariaF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabacariaF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVenderPrazo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnVender = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnRosh = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContagem = new System.Windows.Forms.Label();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.txtAdicionarQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnAdicionarQtd = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnreceber = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.btnVenderPrazo);
            this.panel3.Controls.Add(this.btnVoltar);
            this.panel3.Controls.Add(this.btnVender);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 66);
            this.panel3.TabIndex = 21;
            // 
            // btnVenderPrazo
            // 
            this.btnVenderPrazo.BackColor = System.Drawing.Color.Red;
            this.btnVenderPrazo.FlatAppearance.BorderSize = 0;
            this.btnVenderPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenderPrazo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderPrazo.ForeColor = System.Drawing.Color.White;
            this.btnVenderPrazo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderPrazo.ImageIndex = 4;
            this.btnVenderPrazo.Location = new System.Drawing.Point(1140, 6);
            this.btnVenderPrazo.Name = "btnVenderPrazo";
            this.btnVenderPrazo.Size = new System.Drawing.Size(128, 52);
            this.btnVenderPrazo.TabIndex = 53;
            this.btnVenderPrazo.Text = "VENDA À PRAZO";
            this.btnVenderPrazo.UseVisualStyleBackColor = false;
            this.btnVenderPrazo.Click += new System.EventHandler(this.btnVenderPrazo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImageIndex = 0;
            this.btnVoltar.ImageList = this.imageList2;
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(81, 66);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "(F4)";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "botao-voltar.png");
            this.imageList2.Images.SetKeyName(1, "pesquisa-de-lupa.png");
            this.imageList2.Images.SetKeyName(2, "cardapio-do-restaurante.png");
            this.imageList2.Images.SetKeyName(3, "cervejas.png");
            this.imageList2.Images.SetKeyName(4, "cachimbo-de-agua.png");
            this.imageList2.Images.SetKeyName(5, "cervejas (1).png");
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Red;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.ImageIndex = 4;
            this.btnVender.Location = new System.Drawing.Point(996, 6);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(128, 52);
            this.btnVender.TabIndex = 37;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.ImageKey = "cervejas (1).png";
            this.btnBebidas.ImageList = this.imageList2;
            this.btnBebidas.Location = new System.Drawing.Point(164, 339);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(140, 40);
            this.btnBebidas.TabIndex = 50;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnRosh
            // 
            this.btnRosh.FlatAppearance.BorderSize = 0;
            this.btnRosh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnRosh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRosh.ImageKey = "cachimbo-de-agua.png";
            this.btnRosh.ImageList = this.imageList2;
            this.btnRosh.Location = new System.Drawing.Point(319, 339);
            this.btnRosh.Name = "btnRosh";
            this.btnRosh.Size = new System.Drawing.Size(155, 40);
            this.btnRosh.TabIndex = 48;
            this.btnRosh.Text = "Essências";
            this.btnRosh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRosh.UseVisualStyleBackColor = true;
            this.btnRosh.Click += new System.EventHandler(this.btnRosh_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.Location = new System.Drawing.Point(880, 348);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(329, 31);
            this.txtBuscar.TabIndex = 38;
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.ImageKey = "cardapio-do-restaurante.png";
            this.btnEstoque.ImageList = this.imageList2;
            this.btnEstoque.Location = new System.Drawing.Point(9, 339);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(140, 40);
            this.btnEstoque.TabIndex = 45;
            this.btnEstoque.Text = "Produtos";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageIndex = 1;
            this.btnBuscar.ImageList = this.imageList2;
            this.btnBuscar.Location = new System.Drawing.Point(1215, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 29);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(313, 684);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(43, 29);
            this.lblR.TabIndex = 46;
            this.lblR.Text = "R$";
            this.lblR.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Itens";
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagem.Location = new System.Drawing.Point(796, 688);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(21, 24);
            this.lblContagem.TabIndex = 19;
            this.lblContagem.Text = "0";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.FlatAppearance.BorderSize = 0;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItem.ImageKey = "removido (1).png";
            this.btnRemoverItem.ImageList = this.imageList1;
            this.btnRemoverItem.Location = new System.Drawing.Point(1120, 652);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(128, 35);
            this.btnRemoverItem.TabIndex = 17;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adicionar-botao.png");
            this.imageList1.Images.SetKeyName(1, "editar.png");
            this.imageList1.Images.SetKeyName(2, "removido (1).png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bodoni MT", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bodoni MT", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(8, 385);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 261);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.ImageIndex = 0;
            this.btnAdicionar.ImageList = this.imageList1;
            this.btnAdicionar.Location = new System.Drawing.Point(898, 652);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 35);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Novo";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.FlatAppearance.BorderSize = 0;
            this.btnAlterarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarItem.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarItem.ImageKey = "editar.png";
            this.btnAlterarItem.ImageList = this.imageList1;
            this.btnAlterarItem.Location = new System.Drawing.Point(1006, 652);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(102, 35);
            this.btnAlterarItem.TabIndex = 16;
            this.btnAlterarItem.Text = "Editar";
            this.btnAlterarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
            // 
            // txtAdicionarQtd
            // 
            this.txtAdicionarQtd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtAdicionarQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionarQtd.Location = new System.Drawing.Point(93, 684);
            this.txtAdicionarQtd.Name = "txtAdicionarQtd";
            this.txtAdicionarQtd.Size = new System.Drawing.Size(47, 31);
            this.txtAdicionarQtd.TabIndex = 43;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(27, 686);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(26, 29);
            this.lblQtd.TabIndex = 42;
            this.lblQtd.Text = "0";
            this.lblQtd.Visible = false;
            // 
            // btnAdicionarQtd
            // 
            this.btnAdicionarQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarQtd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdicionarQtd.Location = new System.Drawing.Point(164, 683);
            this.btnAdicionarQtd.Name = "btnAdicionarQtd";
            this.btnAdicionarQtd.Size = new System.Drawing.Size(124, 33);
            this.btnAdicionarQtd.TabIndex = 44;
            this.btnAdicionarQtd.Text = "&Adicionar";
            this.btnAdicionarQtd.UseVisualStyleBackColor = true;
            this.btnAdicionarQtd.Click += new System.EventHandler(this.btnAdicionarQtd_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 655);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(597, 25);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "NOME DO PRODUTO MESMO QUE ELE FOR GRANDE \r\n";
            this.lblNome.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(359, 684);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(71, 29);
            this.lblValor.TabIndex = 41;
            this.lblValor.Text = "00,00";
            this.lblValor.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(12, 132);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(619, 202);
            this.dataGridView2.TabIndex = 51;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnreceber
            // 
            this.btnreceber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreceber.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnreceber.Location = new System.Drawing.Point(12, 86);
            this.btnreceber.Name = "btnreceber";
            this.btnreceber.Size = new System.Drawing.Size(130, 40);
            this.btnreceber.TabIndex = 53;
            this.btnreceber.Text = "À RECEBER";
            this.btnreceber.UseVisualStyleBackColor = true;
            this.btnreceber.Click += new System.EventHandler(this.btnreceber_Click);
            // 
            // TabacariaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnreceber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.btnAlterarItem);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRosh);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtAdicionarQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.btnAdicionarQtd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TabacariaF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabacariaF";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TabacariaF_KeyDown);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnRosh;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.TextBox txtAdicionarQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnAdicionarQtd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnVenderPrazo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnreceber;
    }
}