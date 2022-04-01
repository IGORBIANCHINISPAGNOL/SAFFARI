
namespace SAFFARI.TELAS
{
    partial class CriarComandaIIF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarComandaIIF));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEntradaCobr = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAdicionarEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdicionarEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboCamarote = new System.Windows.Forms.ComboBox();
            this.txtNPulseira = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.ComboSofa = new System.Windows.Forms.ComboBox();
            this.ComboBistro = new System.Windows.Forms.ComboBox();
            this.btnSofa = new System.Windows.Forms.Button();
            this.btnBistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "sofa-preto-da-sala.png");
            this.imageList2.Images.SetKeyName(1, "mesa-de-cafe.png");
            this.imageList2.Images.SetKeyName(2, "salve-.png");
            this.imageList2.Images.SetKeyName(3, "cancelar.png");
            this.imageList2.Images.SetKeyName(4, "imprimir-sinal-de-ferramenta-de-interface-preenchido.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEntradaCobr);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.btnAdicionarEntrada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAdicionarEntrada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(297, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 243);
            this.panel1.TabIndex = 98;
            // 
            // lblEntradaCobr
            // 
            this.lblEntradaCobr.AutoSize = true;
            this.lblEntradaCobr.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaCobr.ForeColor = System.Drawing.Color.Red;
            this.lblEntradaCobr.Location = new System.Drawing.Point(19, 199);
            this.lblEntradaCobr.Name = "lblEntradaCobr";
            this.lblEntradaCobr.Size = new System.Drawing.Size(222, 22);
            this.lblEntradaCobr.TabIndex = 99;
            this.lblEntradaCobr.Text = "ENTRADA COBRADA";
            this.lblEntradaCobr.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPagar.Location = new System.Drawing.Point(136, 144);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(109, 34);
            this.btnPagar.TabIndex = 87;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnAdicionarEntrada
            // 
            this.btnAdicionarEntrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdicionarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarEntrada.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEntrada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdicionarEntrada.Location = new System.Drawing.Point(21, 144);
            this.btnAdicionarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarEntrada.Name = "btnAdicionarEntrada";
            this.btnAdicionarEntrada.Size = new System.Drawing.Size(109, 34);
            this.btnAdicionarEntrada.TabIndex = 81;
            this.btnAdicionarEntrada.Text = "Cobrar";
            this.btnAdicionarEntrada.UseVisualStyleBackColor = false;
            this.btnAdicionarEntrada.Click += new System.EventHandler(this.btnAdicionarEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 40);
            this.label1.TabIndex = 80;
            this.label1.Text = "R$";
            // 
            // txtAdicionarEntrada
            // 
            this.txtAdicionarEntrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAdicionarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionarEntrada.Location = new System.Drawing.Point(117, 75);
            this.txtAdicionarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdicionarEntrada.Name = "txtAdicionarEntrada";
            this.txtAdicionarEntrada.Size = new System.Drawing.Size(89, 53);
            this.txtAdicionarEntrada.TabIndex = 68;
            this.txtAdicionarEntrada.Text = "20";
            this.txtAdicionarEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdicionarEntrada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdicionarEntrada_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(49, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 40);
            this.label3.TabIndex = 79;
            this.label3.Text = "Entrada";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImageIndex = 2;
            this.btnVoltar.Location = new System.Drawing.Point(13, 501);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(165, 57);
            this.btnVoltar.TabIndex = 97;
            this.btnVoltar.Text = "Voltar (ESC)";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 40);
            this.label2.TabIndex = 95;
            this.label2.Text = "N° PULSEIRA";
            // 
            // ComboCamarote
            // 
            this.ComboCamarote.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ComboCamarote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCamarote.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCamarote.FormattingEnabled = true;
            this.ComboCamarote.Location = new System.Drawing.Point(209, 271);
            this.ComboCamarote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboCamarote.Name = "ComboCamarote";
            this.ComboCamarote.Size = new System.Drawing.Size(45, 36);
            this.ComboCamarote.TabIndex = 86;
            this.ComboCamarote.SelectedIndexChanged += new System.EventHandler(this.ComboCamarote_SelectedIndexChanged);
            // 
            // txtNPulseira
            // 
            this.txtNPulseira.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNPulseira.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPulseira.Location = new System.Drawing.Point(331, 395);
            this.txtNPulseira.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNPulseira.Name = "txtNPulseira";
            this.txtNPulseira.Size = new System.Drawing.Size(129, 75);
            this.txtNPulseira.TabIndex = 83;
            this.txtNPulseira.Text = "000";
            this.txtNPulseira.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNPulseira_MouseClick);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(24, 270);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 35);
            this.textBox3.TabIndex = 94;
            this.textBox3.Text = " CAMAROTE";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(91, 199);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 35);
            this.textBox2.TabIndex = 93;
            this.textBox2.Text = " SOFA";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 35);
            this.textBox1.TabIndex = 92;
            this.textBox1.Text = " BISTRÔ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblNomeCliente);
            this.panel2.Controls.Add(this.lblStats);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 110);
            this.panel2.TabIndex = 91;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNomeCliente.Location = new System.Drawing.Point(4, 4);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(348, 32);
            this.lblNomeCliente.TabIndex = 43;
            this.lblNomeCliente.Text = "NOME COMPLETO CLIENTE";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStats.Location = new System.Drawing.Point(3, 55);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(188, 47);
            this.lblStats.TabIndex = 41;
            this.lblStats.Text = "0000000";
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.ImageIndex = 2;
            this.btnGravar.ImageList = this.imageList2;
            this.btnGravar.Location = new System.Drawing.Point(353, 501);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(205, 57);
            this.btnGravar.TabIndex = 88;
            this.btnGravar.Text = "Gravar (F5)";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // ComboSofa
            // 
            this.ComboSofa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ComboSofa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboSofa.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSofa.FormattingEnabled = true;
            this.ComboSofa.Location = new System.Drawing.Point(209, 202);
            this.ComboSofa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboSofa.Name = "ComboSofa";
            this.ComboSofa.Size = new System.Drawing.Size(45, 36);
            this.ComboSofa.TabIndex = 85;
            this.ComboSofa.SelectedIndexChanged += new System.EventHandler(this.ComboSofa_SelectedIndexChanged);
            // 
            // ComboBistro
            // 
            this.ComboBistro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ComboBistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBistro.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBistro.FormattingEnabled = true;
            this.ComboBistro.Location = new System.Drawing.Point(209, 138);
            this.ComboBistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBistro.Name = "ComboBistro";
            this.ComboBistro.Size = new System.Drawing.Size(45, 36);
            this.ComboBistro.TabIndex = 84;
            this.ComboBistro.SelectedIndexChanged += new System.EventHandler(this.ComboBistro_SelectedIndexChanged);
            // 
            // btnSofa
            // 
            this.btnSofa.FlatAppearance.BorderSize = 0;
            this.btnSofa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSofa.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSofa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSofa.ImageIndex = 0;
            this.btnSofa.ImageList = this.imageList2;
            this.btnSofa.Location = new System.Drawing.Point(13, 190);
            this.btnSofa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSofa.Name = "btnSofa";
            this.btnSofa.Size = new System.Drawing.Size(56, 49);
            this.btnSofa.TabIndex = 90;
            this.btnSofa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSofa.UseVisualStyleBackColor = true;
            // 
            // btnBistro
            // 
            this.btnBistro.FlatAppearance.BorderSize = 0;
            this.btnBistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBistro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBistro.ImageIndex = 1;
            this.btnBistro.ImageList = this.imageList2;
            this.btnBistro.Location = new System.Drawing.Point(13, 129);
            this.btnBistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBistro.Name = "btnBistro";
            this.btnBistro.Size = new System.Drawing.Size(45, 46);
            this.btnBistro.TabIndex = 89;
            this.btnBistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBistro.UseVisualStyleBackColor = true;
            // 
            // CriarComandaIIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(571, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboCamarote);
            this.Controls.Add(this.txtNPulseira);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.ComboSofa);
            this.Controls.Add(this.ComboBistro);
            this.Controls.Add(this.btnSofa);
            this.Controls.Add(this.btnBistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CriarComandaIIF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriarComandaIIF";
            this.Load += new System.EventHandler(this.CriarComandaIIF_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CriarComandaIIF_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAdicionarEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdicionarEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboCamarote;
        private System.Windows.Forms.TextBox txtNPulseira;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox ComboSofa;
        private System.Windows.Forms.ComboBox ComboBistro;
        private System.Windows.Forms.Button btnSofa;
        private System.Windows.Forms.Button btnBistro;
        private System.Windows.Forms.Label lblEntradaCobr;
    }
}