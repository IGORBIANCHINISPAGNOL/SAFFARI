
namespace SAFFARI.TELAS
{
    partial class CMDINFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMDINFO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNomedoCliente = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnFinalizarComanda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPulseira = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnLocalizarProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdcValores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnVoltar.Location = new System.Drawing.Point(85, 597);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(184, 54);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = " Voltar (ESC)";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNomedoCliente
            // 
            this.lblNomedoCliente.AutoSize = true;
            this.lblNomedoCliente.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomedoCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNomedoCliente.Location = new System.Drawing.Point(293, 21);
            this.lblNomedoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomedoCliente.Name = "lblNomedoCliente";
            this.lblNomedoCliente.Size = new System.Drawing.Size(299, 32);
            this.lblNomedoCliente.TabIndex = 8;
            this.lblNomedoCliente.Text = "NOME DO CLIENTE\r\n";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "removido (1).png");
            this.imageList1.Images.SetKeyName(1, "imprimir-sinal-de-ferramenta-de-interface-preenchido.png");
            this.imageList1.Images.SetKeyName(2, "cadeira-e-mesa.png");
            this.imageList1.Images.SetKeyName(3, "pesquisa-de-lupa.png");
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.FlatAppearance.BorderSize = 0;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItem.ImageIndex = 0;
            this.btnRemoverItem.ImageList = this.imageList1;
            this.btnRemoverItem.Location = new System.Drawing.Point(299, 654);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(161, 57);
            this.btnRemoverItem.TabIndex = 17;
            this.btnRemoverItem.Text = "Remover\r\nProduto\r\n";
            this.btnRemoverItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnFinalizarComanda
            // 
            this.btnFinalizarComanda.BackColor = System.Drawing.Color.Red;
            this.btnFinalizarComanda.FlatAppearance.BorderSize = 0;
            this.btnFinalizarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarComanda.ForeColor = System.Drawing.Color.Wheat;
            this.btnFinalizarComanda.Location = new System.Drawing.Point(1071, 652);
            this.btnFinalizarComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarComanda.Name = "btnFinalizarComanda";
            this.btnFinalizarComanda.Size = new System.Drawing.Size(238, 57);
            this.btnFinalizarComanda.TabIndex = 18;
            this.btnFinalizarComanda.Text = "Pagamentos (F4)";
            this.btnFinalizarComanda.UseVisualStyleBackColor = false;
            this.btnFinalizarComanda.Click += new System.EventHandler(this.btnFinalizarComanda_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPulseira);
            this.panel1.Controls.Add(this.lblLugar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 715);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "PULSEIRA";
            // 
            // lblPulseira
            // 
            this.lblPulseira.AutoSize = true;
            this.lblPulseira.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulseira.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPulseira.Location = new System.Drawing.Point(168, 22);
            this.lblPulseira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPulseira.Name = "lblPulseira";
            this.lblPulseira.Size = new System.Drawing.Size(55, 36);
            this.lblPulseira.TabIndex = 10;
            this.lblPulseira.Text = "00";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLugar.Location = new System.Drawing.Point(13, 84);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(150, 28);
            this.lblLugar.TabIndex = 9;
            this.lblLugar.Text = "Camarote 1";
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.FlatAppearance.BorderSize = 0;
            this.btnInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInformacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformacoes.ImageIndex = 3;
            this.btnInformacoes.ImageList = this.imageList1;
            this.btnInformacoes.Location = new System.Drawing.Point(636, 654);
            this.btnInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(160, 57);
            this.btnInformacoes.TabIndex = 31;
            this.btnInformacoes.Text = "Editar\r\nLocal";
            this.btnInformacoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImageIndex = 1;
            this.btnImprimir.ImageList = this.imageList1;
            this.btnImprimir.Location = new System.Drawing.Point(468, 654);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 57);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Location = new System.Drawing.Point(291, 589);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 57);
            this.panel3.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(688, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotal.Location = new System.Drawing.Point(779, 12);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(165, 34);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.Text = "00,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLocalizarProduto
            // 
            this.btnLocalizarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizarProduto.FlatAppearance.BorderSize = 0;
            this.btnLocalizarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizarProduto.ImageIndex = 3;
            this.btnLocalizarProduto.ImageList = this.imageList1;
            this.btnLocalizarProduto.Location = new System.Drawing.Point(1013, 11);
            this.btnLocalizarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizarProduto.Name = "btnLocalizarProduto";
            this.btnLocalizarProduto.Size = new System.Drawing.Size(296, 47);
            this.btnLocalizarProduto.TabIndex = 40;
            this.btnLocalizarProduto.Text = "Localizar Produtos (F3)";
            this.btnLocalizarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalizarProduto.UseVisualStyleBackColor = false;
            this.btnLocalizarProduto.Click += new System.EventHandler(this.btnLocalizarProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qtd,
            this.Produto,
            this.Valor,
            this.Horario});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(291, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 523);
            this.dataGridView1.TabIndex = 41;
            // 
            // Qtd
            // 
            this.Qtd.DataPropertyName = "Qtd";
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.MinimumWidth = 6;
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 125;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 125;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Preço";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 125;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.MinimumWidth = 6;
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 125;
            // 
            // btnAdcValores
            // 
            this.btnAdcValores.FlatAppearance.BorderSize = 0;
            this.btnAdcValores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdcValores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdcValores.ImageIndex = 3;
            this.btnAdcValores.Location = new System.Drawing.Point(804, 654);
            this.btnAdcValores.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdcValores.Name = "btnAdcValores";
            this.btnAdcValores.Size = new System.Drawing.Size(160, 57);
            this.btnAdcValores.TabIndex = 42;
            this.btnAdcValores.Text = "Adicionar\r\nValores";
            this.btnAdcValores.UseVisualStyleBackColor = true;
            this.btnAdcValores.Click += new System.EventHandler(this.btnAdcValores_Click);
            // 
            // CMDINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 714);
            this.Controls.Add(this.btnAdcValores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLocalizarProduto);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.lblNomedoCliente);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnFinalizarComanda);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CMDINFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMDINFO_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNomedoCliente;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnFinalizarComanda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblPulseira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLocalizarProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.Button btnAdcValores;
    }
}