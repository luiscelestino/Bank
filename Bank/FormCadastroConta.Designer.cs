using System;

namespace Bank
{
    partial class FormCadastroConta
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
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelTitular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(101, 12);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(101, 39);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(101, 76);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(100, 23);
            this.botaoCadastrar.TabIndex = 2;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(14, 15);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 3;
            this.labelNumero.Text = "Numero";
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(14, 42);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(36, 13);
            this.labelTitular.TabIndex = 4;
            this.labelTitular.Text = "Titular";
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 111);
            this.Controls.Add(this.labelTitular);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.textoNumero);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelTitular;
    }
}