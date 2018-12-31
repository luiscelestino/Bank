namespace Bank
{
    partial class FormRelatorios
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
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltraSaldo5000 = new System.Windows.Forms.Button();
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.groupBoxResumo = new System.Windows.Forms.GroupBox();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelValorSaldoTotal = new System.Windows.Forms.Label();
            this.labelValorMaiorSaldo = new System.Windows.Forms.Label();
            this.groupBoxResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(13, 13);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(775, 228);
            this.listBoxResultado.TabIndex = 0;
            // 
            // botaoFiltraSaldo5000
            // 
            this.botaoFiltraSaldo5000.Location = new System.Drawing.Point(13, 392);
            this.botaoFiltraSaldo5000.Name = "botaoFiltraSaldo5000";
            this.botaoFiltraSaldo5000.Size = new System.Drawing.Size(209, 28);
            this.botaoFiltraSaldo5000.TabIndex = 1;
            this.botaoFiltraSaldo5000.Text = "Saldo maior do que 5000";
            this.botaoFiltraSaldo5000.UseVisualStyleBackColor = true;
            this.botaoFiltraSaldo5000.Click += new System.EventHandler(this.botaoFiltroSaldo5000_Click);
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.Location = new System.Drawing.Point(258, 392);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(114, 27);
            this.botaoAntigas.TabIndex = 2;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = true;
            this.botaoAntigas.Click += new System.EventHandler(this.botaoAntigas_Click);
            // 
            // groupBoxResumo
            // 
            this.groupBoxResumo.Controls.Add(this.labelValorMaiorSaldo);
            this.groupBoxResumo.Controls.Add(this.labelValorSaldoTotal);
            this.groupBoxResumo.Controls.Add(this.labelMaiorSaldo);
            this.groupBoxResumo.Controls.Add(this.labelSaldoTotal);
            this.groupBoxResumo.Location = new System.Drawing.Point(13, 247);
            this.groupBoxResumo.Name = "groupBoxResumo";
            this.groupBoxResumo.Size = new System.Drawing.Size(775, 139);
            this.groupBoxResumo.TabIndex = 3;
            this.groupBoxResumo.TabStop = false;
            this.groupBoxResumo.Text = "Resumo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(33, 30);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(80, 17);
            this.labelSaldoTotal.TabIndex = 0;
            this.labelSaldoTotal.Text = "Saldo Total";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(33, 74);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(83, 17);
            this.labelMaiorSaldo.TabIndex = 1;
            this.labelMaiorSaldo.Text = "Maior Saldo";
            // 
            // labelValorSaldoTotal
            // 
            this.labelValorSaldoTotal.AutoSize = true;
            this.labelValorSaldoTotal.Location = new System.Drawing.Point(207, 30);
            this.labelValorSaldoTotal.Name = "labelValorSaldoTotal";
            this.labelValorSaldoTotal.Size = new System.Drawing.Size(177, 17);
            this.labelValorSaldoTotal.TabIndex = 2;
            this.labelValorSaldoTotal.Text = "<filtrar para calcular valor>";
            // 
            // labelValorMaiorSaldo
            // 
            this.labelValorMaiorSaldo.AutoSize = true;
            this.labelValorMaiorSaldo.Location = new System.Drawing.Point(207, 74);
            this.labelValorMaiorSaldo.Name = "labelValorMaiorSaldo";
            this.labelValorMaiorSaldo.Size = new System.Drawing.Size(177, 17);
            this.labelValorMaiorSaldo.TabIndex = 3;
            this.labelValorMaiorSaldo.Text = "<filtrar para calcular valor>";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResumo);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.botaoFiltraSaldo5000);
            this.Controls.Add(this.listBoxResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBoxResumo.ResumeLayout(false);
            this.groupBoxResumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button botaoFiltraSaldo5000;
        private System.Windows.Forms.Button botaoAntigas;
        private System.Windows.Forms.GroupBox groupBoxResumo;
        private System.Windows.Forms.Label labelValorMaiorSaldo;
        private System.Windows.Forms.Label labelValorSaldoTotal;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
    }
}