
namespace ProjetoLauge.TELAS
{
    partial class AdcEntSaidF
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
            this.ckSaida = new System.Windows.Forms.CheckBox();
            this.ckEntrada = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckDinheiro = new System.Windows.Forms.CheckBox();
            this.ckPix = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckDebito = new System.Windows.Forms.CheckBox();
            this.ckCredito = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckSaida
            // 
            this.ckSaida.AutoSize = true;
            this.ckSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSaida.Location = new System.Drawing.Point(156, 98);
            this.ckSaida.Name = "ckSaida";
            this.ckSaida.Size = new System.Drawing.Size(252, 19);
            this.ckSaida.TabIndex = 0;
            this.ckSaida.Text = "Saída - Sangria/Lancamento de Despesa";
            this.ckSaida.UseVisualStyleBackColor = true;
            this.ckSaida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckSaida_MouseClick);
            // 
            // ckEntrada
            // 
            this.ckEntrada.AutoSize = true;
            this.ckEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckEntrada.Location = new System.Drawing.Point(156, 138);
            this.ckEntrada.Name = "ckEntrada";
            this.ckEntrada.Size = new System.Drawing.Size(69, 19);
            this.ckEntrada.TabIndex = 1;
            this.ckEntrada.Text = "Entrada";
            this.ckEntrada.UseVisualStyleBackColor = true;
            this.ckEntrada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckEntrada_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo da operação:";
            // 
            // ckDinheiro
            // 
            this.ckDinheiro.AutoSize = true;
            this.ckDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDinheiro.Location = new System.Drawing.Point(156, 45);
            this.ckDinheiro.Name = "ckDinheiro";
            this.ckDinheiro.Size = new System.Drawing.Size(73, 19);
            this.ckDinheiro.TabIndex = 4;
            this.ckDinheiro.Text = "Dinheiro";
            this.ckDinheiro.UseVisualStyleBackColor = true;
            this.ckDinheiro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckDinheiro_MouseClick);
            // 
            // ckPix
            // 
            this.ckPix.AutoSize = true;
            this.ckPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPix.Location = new System.Drawing.Point(399, 45);
            this.ckPix.Name = "ckPix";
            this.ckPix.Size = new System.Drawing.Size(45, 19);
            this.ckPix.TabIndex = 5;
            this.ckPix.Text = "PIX";
            this.ckPix.UseVisualStyleBackColor = true;
            this.ckPix.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckPix_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observação:";
            // 
            // ckDebito
            // 
            this.ckDebito.AutoSize = true;
            this.ckDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDebito.Location = new System.Drawing.Point(237, 45);
            this.ckDebito.Name = "ckDebito";
            this.ckDebito.Size = new System.Drawing.Size(73, 19);
            this.ckDebito.TabIndex = 9;
            this.ckDebito.Text = "C/Débito";
            this.ckDebito.UseVisualStyleBackColor = true;
            this.ckDebito.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckDebito_MouseClick);
            // 
            // ckCredito
            // 
            this.ckCredito.AutoSize = true;
            this.ckCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCredito.Location = new System.Drawing.Point(317, 45);
            this.ckCredito.Name = "ckCredito";
            this.ckCredito.Size = new System.Drawing.Size(76, 19);
            this.ckCredito.TabIndex = 10;
            this.ckCredito.Text = "C/Crédito";
            this.ckCredito.UseVisualStyleBackColor = true;
            this.ckCredito.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckCredito_MouseClick);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(156, 186);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(69, 21);
            this.txtValor.TabIndex = 11;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(156, 242);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(264, 21);
            this.txtObs.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(345, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(264, 296);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // AdcEntSaidF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(469, 349);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.ckCredito);
            this.Controls.Add(this.ckDebito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckPix);
            this.Controls.Add(this.ckDinheiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckEntrada);
            this.Controls.Add(this.ckSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdcEntSaidF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada/Saída";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckSaida;
        private System.Windows.Forms.CheckBox ckEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckDinheiro;
        private System.Windows.Forms.CheckBox ckPix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckDebito;
        private System.Windows.Forms.CheckBox ckCredito;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
    }
}