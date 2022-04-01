namespace SAFFARI.TELAS
{
    partial class AdcValores
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbDescricaovaloradd = new System.Windows.Forms.TextBox();
            this.txbValorAddRemov = new System.Windows.Forms.TextBox();
            this.btnAdicionarValor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txbDescricaovaloradd);
            this.panel4.Controls.Add(this.txbValorAddRemov);
            this.panel4.Controls.Add(this.btnAdicionarValor);
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(-3, -4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 219);
            this.panel4.TabIndex = 39;
            // 
            // txbDescricaovaloradd
            // 
            this.txbDescricaovaloradd.BackColor = System.Drawing.SystemColors.Control;
            this.txbDescricaovaloradd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDescricaovaloradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricaovaloradd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbDescricaovaloradd.Location = new System.Drawing.Point(16, 77);
            this.txbDescricaovaloradd.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescricaovaloradd.Multiline = true;
            this.txbDescricaovaloradd.Name = "txbDescricaovaloradd";
            this.txbDescricaovaloradd.Size = new System.Drawing.Size(320, 74);
            this.txbDescricaovaloradd.TabIndex = 40;
            this.txbDescricaovaloradd.Text = "Descrição...";
            this.txbDescricaovaloradd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbDescricaovaloradd_MouseClick);
            // 
            // txbValorAddRemov
            // 
            this.txbValorAddRemov.BackColor = System.Drawing.SystemColors.Window;
            this.txbValorAddRemov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValorAddRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorAddRemov.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txbValorAddRemov.Location = new System.Drawing.Point(178, 29);
            this.txbValorAddRemov.Margin = new System.Windows.Forms.Padding(4);
            this.txbValorAddRemov.Name = "txbValorAddRemov";
            this.txbValorAddRemov.Size = new System.Drawing.Size(102, 31);
            this.txbValorAddRemov.TabIndex = 39;
            this.txbValorAddRemov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionarValor
            // 
            this.btnAdicionarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarValor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdicionarValor.Location = new System.Drawing.Point(217, 170);
            this.btnAdicionarValor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarValor.Name = "btnAdicionarValor";
            this.btnAdicionarValor.Size = new System.Drawing.Size(119, 36);
            this.btnAdicionarValor.TabIndex = 41;
            this.btnAdicionarValor.Text = "Adicionar";
            this.btnAdicionarValor.UseVisualStyleBackColor = true;
            this.btnAdicionarValor.Click += new System.EventHandler(this.btnAdicionarValor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(16, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "VALOR    R$";
            // 
            // AdcValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 209);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdcValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdcValores";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbDescricaovaloradd;
        private System.Windows.Forms.TextBox txbValorAddRemov;
        private System.Windows.Forms.Button btnAdicionarValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}