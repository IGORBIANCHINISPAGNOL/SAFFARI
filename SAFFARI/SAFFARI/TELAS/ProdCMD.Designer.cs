
namespace SAFFARI.TELAS
{
    partial class ProdCMD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdCMD));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnRosh = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.txtQtdmaismenos = new System.Windows.Forms.TextBox();
            this.btnQtdmenos = new System.Windows.Forms.Button();
            this.btnQtdmais = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Valor,
            this.Qtd,
            this.Categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(973, 569);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Código";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Produto";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 135;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Preço";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Qtd
            // 
            this.Qtd.DataPropertyName = "Qtd";
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.MinimumWidth = 6;
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 80;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 80;
            // 
            // txbCodigoProduto
            // 
            this.txbCodigoProduto.BackColor = System.Drawing.Color.DimGray;
            this.txbCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.txbCodigoProduto.Location = new System.Drawing.Point(24, 10);
            this.txbCodigoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txbCodigoProduto.Name = "txbCodigoProduto";
            this.txbCodigoProduto.Size = new System.Drawing.Size(100, 22);
            this.txbCodigoProduto.TabIndex = 6;
            this.txbCodigoProduto.Text = "Código...";
            this.txbCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCodigoProduto.Click += new System.EventHandler(this.txbCodigoProduto_Click);
            this.txbCodigoProduto.TextChanged += new System.EventHandler(this.txbCodigoProduto_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.DimGray;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.Location = new System.Drawing.Point(47, 10);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(311, 22);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.Text = "Digite aqui o nome do produto...";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(27, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 44);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txbCodigoProduto);
            this.panel2.Location = new System.Drawing.Point(459, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 44);
            this.panel2.TabIndex = 11;
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackColor = System.Drawing.SystemColors.Control;
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.ImageKey = "cervejas (1).png";
            this.btnBebidas.ImageList = this.imageList2;
            this.btnBebidas.Location = new System.Drawing.Point(199, 86);
            this.btnBebidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(160, 43);
            this.btnBebidas.TabIndex = 39;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBebidas.UseVisualStyleBackColor = false;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "botao-voltar.png");
            this.imageList2.Images.SetKeyName(1, "pesquisa-de-lupa.png");
            this.imageList2.Images.SetKeyName(2, "cervejas (1).png");
            this.imageList2.Images.SetKeyName(3, "cardapio-do-restaurante.png");
            this.imageList2.Images.SetKeyName(4, "cervejas.png");
            this.imageList2.Images.SetKeyName(5, "cachimbo-de-agua.png");
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombo.ImageKey = "cervejas.png";
            this.btnCombo.ImageList = this.imageList2;
            this.btnCombo.Location = new System.Drawing.Point(569, 86);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(160, 43);
            this.btnCombo.TabIndex = 38;
            this.btnCombo.Text = "Combos";
            this.btnCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnRosh
            // 
            this.btnRosh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRosh.FlatAppearance.BorderSize = 0;
            this.btnRosh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosh.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRosh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRosh.ImageKey = "cachimbo-de-agua.png";
            this.btnRosh.ImageList = this.imageList2;
            this.btnRosh.Location = new System.Drawing.Point(387, 86);
            this.btnRosh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRosh.Name = "btnRosh";
            this.btnRosh.Size = new System.Drawing.Size(160, 43);
            this.btnRosh.TabIndex = 37;
            this.btnRosh.Text = "Rosh";
            this.btnRosh.UseVisualStyleBackColor = false;
            this.btnRosh.Click += new System.EventHandler(this.btnRosh_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.SystemColors.Control;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.ImageKey = "cardapio-do-restaurante.png";
            this.btnProdutos.ImageList = this.imageList2;
            this.btnProdutos.Location = new System.Drawing.Point(11, 86);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(160, 43);
            this.btnProdutos.TabIndex = 36;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // txtQtdmaismenos
            // 
            this.txtQtdmaismenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdmaismenos.Location = new System.Drawing.Point(893, 41);
            this.txtQtdmaismenos.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdmaismenos.Name = "txtQtdmaismenos";
            this.txtQtdmaismenos.ReadOnly = true;
            this.txtQtdmaismenos.Size = new System.Drawing.Size(41, 37);
            this.txtQtdmaismenos.TabIndex = 49;
            this.txtQtdmaismenos.Text = "1";
            this.txtQtdmaismenos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQtdmenos
            // 
            this.btnQtdmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdmenos.Location = new System.Drawing.Point(931, 41);
            this.btnQtdmenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnQtdmenos.Name = "btnQtdmenos";
            this.btnQtdmenos.Size = new System.Drawing.Size(47, 38);
            this.btnQtdmenos.TabIndex = 48;
            this.btnQtdmenos.Text = "-";
            this.btnQtdmenos.UseVisualStyleBackColor = true;
            this.btnQtdmenos.Click += new System.EventHandler(this.btnQtdmenos_Click);
            // 
            // btnQtdmais
            // 
            this.btnQtdmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdmais.Location = new System.Drawing.Point(853, 41);
            this.btnQtdmais.Margin = new System.Windows.Forms.Padding(4);
            this.btnQtdmais.Name = "btnQtdmais";
            this.btnQtdmais.Size = new System.Drawing.Size(47, 38);
            this.btnQtdmais.TabIndex = 47;
            this.btnQtdmais.Text = "+";
            this.btnQtdmais.UseVisualStyleBackColor = true;
            this.btnQtdmais.Click += new System.EventHandler(this.btnQtdmais_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.ImageIndex = 1;
            this.btnAdicionar.Location = new System.Drawing.Point(853, 86);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(123, 38);
            this.btnAdicionar.TabIndex = 46;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImageIndex = 0;
            this.btnVoltar.Location = new System.Drawing.Point(853, 718);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 49);
            this.btnVoltar.TabIndex = 54;
            this.btnVoltar.Text = " Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ProdCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(992, 772);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnRosh);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.txtQtdmaismenos);
            this.Controls.Add(this.btnQtdmenos);
            this.Controls.Add(this.btnQtdmais);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProdCMD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdCMD";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProdCMD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbCodigoProduto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnRosh;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txtQtdmaismenos;
        private System.Windows.Forms.Button btnQtdmenos;
        private System.Windows.Forms.Button btnQtdmais;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}