namespace SAFFARI.TELAS
{
    partial class MensagemCozinha
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimirInformacoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbInformacoes = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(136, 183);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimirInformacoes
            // 
            this.btnImprimirInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirInformacoes.Location = new System.Drawing.Point(292, 183);
            this.btnImprimirInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirInformacoes.Name = "btnImprimirInformacoes";
            this.btnImprimirInformacoes.Size = new System.Drawing.Size(148, 42);
            this.btnImprimirInformacoes.TabIndex = 8;
            this.btnImprimirInformacoes.Text = "Imprimir";
            this.btnImprimirInformacoes.UseVisualStyleBackColor = true;
            this.btnImprimirInformacoes.Click += new System.EventHandler(this.btnImprimirInformacoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informações adicionais para cozinha";
            // 
            // TxbInformacoes
            // 
            this.TxbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbInformacoes.Location = new System.Drawing.Point(13, 42);
            this.TxbInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.TxbInformacoes.Multiline = true;
            this.TxbInformacoes.Name = "TxbInformacoes";
            this.TxbInformacoes.Size = new System.Drawing.Size(425, 133);
            this.TxbInformacoes.TabIndex = 6;
            // 
            // MensagemCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 238);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimirInformacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensagemCozinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensagemCozinha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimirInformacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbInformacoes;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}