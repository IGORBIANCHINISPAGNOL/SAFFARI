
namespace SAFFARI.TELAS
{
    partial class ComandaF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandaF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCriarNovaComanda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblContagem = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtBuscarComandaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarComandaPulseira = new System.Windows.Forms.TextBox();
            this.btnAbrirComanda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulseira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnAtivas = new System.Windows.Forms.Button();
            this.btnArquivadas = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarNovaComanda
            // 
            this.btnCriarNovaComanda.BackColor = System.Drawing.SystemColors.Control;
            this.btnCriarNovaComanda.FlatAppearance.BorderSize = 0;
            this.btnCriarNovaComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarNovaComanda.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCriarNovaComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarNovaComanda.ImageIndex = 0;
            this.btnCriarNovaComanda.ImageList = this.imageList1;
            this.btnCriarNovaComanda.Location = new System.Drawing.Point(404, 4);
            this.btnCriarNovaComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarNovaComanda.Name = "btnCriarNovaComanda";
            this.btnCriarNovaComanda.Size = new System.Drawing.Size(189, 62);
            this.btnCriarNovaComanda.TabIndex = 5;
            this.btnCriarNovaComanda.Text = "(F2)  Criar\r\nComanda\r\n";
            this.btnCriarNovaComanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarNovaComanda.UseVisualStyleBackColor = false;
            this.btnCriarNovaComanda.Click += new System.EventHandler(this.btnCriarNovaComanda_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adicionar-ficheiro.png");
            this.imageList1.Images.SetKeyName(1, "adicionar-usuario.png");
            this.imageList1.Images.SetKeyName(2, "pedido.png");
            this.imageList1.Images.SetKeyName(3, "imprimir-sinal-de-ferramenta-de-interface-preenchido.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "pesquisa-de-lupa.png");
            this.imageList2.Images.SetKeyName(1, "botao-voltar.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.btnVoltar);
            this.panel3.Controls.Add(this.lblContagem);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnCriarNovaComanda);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 781);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 71);
            this.panel3.TabIndex = 20;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImageIndex = 1;
            this.btnVoltar.ImageList = this.imageList2;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(124, 61);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "(ESC)";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.BackColor = System.Drawing.Color.Transparent;
            this.lblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagem.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContagem.Location = new System.Drawing.Point(172, 22);
            this.lblContagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(27, 29);
            this.lblContagem.TabIndex = 31;
            this.lblContagem.Text = "0";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImageIndex = 3;
            this.btnImprimir.ImageList = this.imageList1;
            this.btnImprimir.Location = new System.Drawing.Point(598, 4);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(189, 62);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Mensagem\r\nà cozinha\r\n";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtBuscarComandaNome
            // 
            this.txtBuscarComandaNome.BackColor = System.Drawing.Color.White;
            this.txtBuscarComandaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComandaNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarComandaNome.Location = new System.Drawing.Point(269, 613);
            this.txtBuscarComandaNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarComandaNome.Name = "txtBuscarComandaNome";
            this.txtBuscarComandaNome.Size = new System.Drawing.Size(323, 37);
            this.txtBuscarComandaNome.TabIndex = 4;
            this.txtBuscarComandaNome.TextChanged += new System.EventHandler(this.txtBuscarComandaNome_TextChanged);
            this.txtBuscarComandaNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarComandaNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 621);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 621);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pulseira";
            // 
            // txtBuscarComandaPulseira
            // 
            this.txtBuscarComandaPulseira.BackColor = System.Drawing.Color.White;
            this.txtBuscarComandaPulseira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComandaPulseira.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarComandaPulseira.Location = new System.Drawing.Point(114, 613);
            this.txtBuscarComandaPulseira.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarComandaPulseira.Name = "txtBuscarComandaPulseira";
            this.txtBuscarComandaPulseira.Size = new System.Drawing.Size(68, 37);
            this.txtBuscarComandaPulseira.TabIndex = 1;
            this.txtBuscarComandaPulseira.TextChanged += new System.EventHandler(this.txtBuscarComandaPulseira_TextChanged);
            this.txtBuscarComandaPulseira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarComandaPulseira_KeyPress);
            // 
            // btnAbrirComanda
            // 
            this.btnAbrirComanda.FlatAppearance.BorderSize = 0;
            this.btnAbrirComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirComanda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAbrirComanda.ImageIndex = 1;
            this.btnAbrirComanda.Location = new System.Drawing.Point(603, 613);
            this.btnAbrirComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirComanda.Name = "btnAbrirComanda";
            this.btnAbrirComanda.Size = new System.Drawing.Size(176, 37);
            this.btnAbrirComanda.TabIndex = 6;
            this.btnAbrirComanda.Text = "Abrir Comanda";
            this.btnAbrirComanda.UseVisualStyleBackColor = true;
            this.btnAbrirComanda.Click += new System.EventHandler(this.btnAbrirComanda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Pulseira});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 594);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // Pulseira
            // 
            this.Pulseira.DataPropertyName = "Pulseira";
            this.Pulseira.HeaderText = "Pulseira";
            this.Pulseira.MinimumWidth = 6;
            this.Pulseira.Name = "Pulseira";
            this.Pulseira.ReadOnly = true;
            this.Pulseira.Width = 125;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.SystemColors.Control;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFuncionarios.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.ImageIndex = 0;
            this.btnFuncionarios.Location = new System.Drawing.Point(127, 663);
            this.btnFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(199, 41);
            this.btnFuncionarios.TabIndex = 27;
            this.btnFuncionarios.Text = "FUNCIONÁRIOS";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnAtivas
            // 
            this.btnAtivas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtivas.FlatAppearance.BorderSize = 0;
            this.btnAtivas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtivas.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAtivas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivas.ImageIndex = 0;
            this.btnAtivas.Location = new System.Drawing.Point(14, 663);
            this.btnAtivas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtivas.Name = "btnAtivas";
            this.btnAtivas.Size = new System.Drawing.Size(105, 41);
            this.btnAtivas.TabIndex = 28;
            this.btnAtivas.Text = "ATIVAS";
            this.btnAtivas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtivas.UseVisualStyleBackColor = false;
            this.btnAtivas.Click += new System.EventHandler(this.btnAtivas_Click);
            // 
            // btnArquivadas
            // 
            this.btnArquivadas.BackColor = System.Drawing.SystemColors.Control;
            this.btnArquivadas.FlatAppearance.BorderSize = 0;
            this.btnArquivadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArquivadas.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnArquivadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArquivadas.ImageIndex = 0;
            this.btnArquivadas.Location = new System.Drawing.Point(334, 663);
            this.btnArquivadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnArquivadas.Name = "btnArquivadas";
            this.btnArquivadas.Size = new System.Drawing.Size(174, 41);
            this.btnArquivadas.TabIndex = 29;
            this.btnArquivadas.Text = "ARQUIVADAS";
            this.btnArquivadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArquivadas.UseVisualStyleBackColor = false;
            this.btnArquivadas.Click += new System.EventHandler(this.btnArquivadas_Click);
            // 
            // ComandaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 852);
            this.Controls.Add(this.btnArquivadas);
            this.Controls.Add(this.btnAtivas);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAbrirComanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarComandaPulseira);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBuscarComandaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComandaF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComandaF_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCriarNovaComanda;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtBuscarComandaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarComandaPulseira;
        private System.Windows.Forms.Button btnAbrirComanda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulseira;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnAtivas;
        private System.Windows.Forms.Button btnArquivadas;
    }
}