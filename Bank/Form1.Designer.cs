namespace Bank
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.labelTitular = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.butaoSacar = new System.Windows.Forms.Button();
            this.groupBoxConta = new System.Windows.Forms.GroupBox();
            this.botaoTransferir = new System.Windows.Forms.Button();
            this.labelEscolhaAConta = new System.Windows.Forms.Label();
            this.groupBoxBuscaDeConta = new System.Windows.Forms.GroupBox();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.textoBuscarTitular = new System.Windows.Forms.TextBox();
            this.labelBuscaPorTitular = new System.Windows.Forms.Label();
            this.comboIndice = new System.Windows.Forms.ComboBox();
            this.labelDestinoDaTransferencia = new System.Windows.Forms.Label();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoCalcularTributos = new System.Windows.Forms.Button();
            this.groupBoxTransferencia = new System.Windows.Forms.GroupBox();
            this.botaoRelatorios = new System.Windows.Forms.Button();
            this.groupBoxConta.SuspendLayout();
            this.groupBoxBuscaDeConta.SuspendLayout();
            this.groupBoxTransferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(27, 184);
            this.botaoDepositar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(85, 30);
            this.botaoDepositar.TabIndex = 0;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(235, 26);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(121, 22);
            this.textoTitular.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(235, 54);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(121, 22);
            this.textoNumero.TabIndex = 2;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(235, 82);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(121, 22);
            this.textoSaldo.TabIndex = 3;
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(24, 27);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(48, 17);
            this.labelTitular.TabIndex = 4;
            this.labelTitular.Text = "Titular";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(24, 57);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(58, 17);
            this.labelNumero.TabIndex = 5;
            this.labelNumero.Text = "Numero";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(24, 85);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(44, 17);
            this.labelSaldo.TabIndex = 6;
            this.labelSaldo.Text = "Saldo";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(24, 148);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(41, 17);
            this.labelValor.TabIndex = 7;
            this.labelValor.Text = "Valor";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(235, 146);
            this.textoValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(121, 22);
            this.textoValor.TabIndex = 8;
            // 
            // butaoSacar
            // 
            this.butaoSacar.Location = new System.Drawing.Point(149, 184);
            this.butaoSacar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butaoSacar.Name = "butaoSacar";
            this.butaoSacar.Size = new System.Drawing.Size(85, 30);
            this.butaoSacar.TabIndex = 9;
            this.butaoSacar.Text = "Sacar";
            this.butaoSacar.UseVisualStyleBackColor = true;
            this.butaoSacar.Click += new System.EventHandler(this.botaoSacar_Click);
            // 
            // groupBoxConta
            // 
            this.groupBoxConta.Controls.Add(this.botaoTransferir);
            this.groupBoxConta.Controls.Add(this.textoSaldo);
            this.groupBoxConta.Controls.Add(this.butaoSacar);
            this.groupBoxConta.Controls.Add(this.botaoDepositar);
            this.groupBoxConta.Controls.Add(this.textoValor);
            this.groupBoxConta.Controls.Add(this.textoTitular);
            this.groupBoxConta.Controls.Add(this.labelValor);
            this.groupBoxConta.Controls.Add(this.textoNumero);
            this.groupBoxConta.Controls.Add(this.labelSaldo);
            this.groupBoxConta.Controls.Add(this.labelTitular);
            this.groupBoxConta.Controls.Add(this.labelNumero);
            this.groupBoxConta.Location = new System.Drawing.Point(12, 197);
            this.groupBoxConta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxConta.Name = "groupBoxConta";
            this.groupBoxConta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxConta.Size = new System.Drawing.Size(383, 229);
            this.groupBoxConta.TabIndex = 10;
            this.groupBoxConta.TabStop = false;
            this.groupBoxConta.Text = "Conta";
            // 
            // botaoTransferir
            // 
            this.botaoTransferir.Location = new System.Drawing.Point(273, 184);
            this.botaoTransferir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botaoTransferir.Name = "botaoTransferir";
            this.botaoTransferir.Size = new System.Drawing.Size(84, 30);
            this.botaoTransferir.TabIndex = 10;
            this.botaoTransferir.Text = "Transferir";
            this.botaoTransferir.UseVisualStyleBackColor = true;
            this.botaoTransferir.Click += new System.EventHandler(this.botaoTransferir_Click);
            // 
            // labelEscolhaAConta
            // 
            this.labelEscolhaAConta.AutoSize = true;
            this.labelEscolhaAConta.Location = new System.Drawing.Point(24, 28);
            this.labelEscolhaAConta.Name = "labelEscolhaAConta";
            this.labelEscolhaAConta.Size = new System.Drawing.Size(109, 17);
            this.labelEscolhaAConta.TabIndex = 11;
            this.labelEscolhaAConta.Text = "Escolha a conta";
            // 
            // groupBoxBuscaDeConta
            // 
            this.groupBoxBuscaDeConta.Controls.Add(this.botaoBuscar);
            this.groupBoxBuscaDeConta.Controls.Add(this.textoBuscarTitular);
            this.groupBoxBuscaDeConta.Controls.Add(this.labelBuscaPorTitular);
            this.groupBoxBuscaDeConta.Controls.Add(this.comboIndice);
            this.groupBoxBuscaDeConta.Controls.Add(this.labelEscolhaAConta);
            this.groupBoxBuscaDeConta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBuscaDeConta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscaDeConta.Name = "groupBoxBuscaDeConta";
            this.groupBoxBuscaDeConta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscaDeConta.Size = new System.Drawing.Size(383, 102);
            this.groupBoxBuscaDeConta.TabIndex = 14;
            this.groupBoxBuscaDeConta.TabStop = false;
            this.groupBoxBuscaDeConta.Text = "Busca de Conta";
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(281, 54);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(75, 23);
            this.botaoBuscar.TabIndex = 17;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
            // 
            // textoBuscarTitular
            // 
            this.textoBuscarTitular.Location = new System.Drawing.Point(175, 55);
            this.textoBuscarTitular.Name = "textoBuscarTitular";
            this.textoBuscarTitular.Size = new System.Drawing.Size(100, 22);
            this.textoBuscarTitular.TabIndex = 16;
            // 
            // labelBuscaPorTitular
            // 
            this.labelBuscaPorTitular.AutoSize = true;
            this.labelBuscaPorTitular.Location = new System.Drawing.Point(24, 58);
            this.labelBuscaPorTitular.Name = "labelBuscaPorTitular";
            this.labelBuscaPorTitular.Size = new System.Drawing.Size(111, 17);
            this.labelBuscaPorTitular.TabIndex = 15;
            this.labelBuscaPorTitular.Text = "Busca por titular";
            // 
            // comboIndice
            // 
            this.comboIndice.FormattingEnabled = true;
            this.comboIndice.Location = new System.Drawing.Point(235, 25);
            this.comboIndice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboIndice.Name = "comboIndice";
            this.comboIndice.Size = new System.Drawing.Size(121, 24);
            this.comboIndice.TabIndex = 14;
            this.comboIndice.SelectedIndexChanged += new System.EventHandler(this.comboIndice_SelectedIndexChanged);
            // 
            // labelDestinoDaTransferencia
            // 
            this.labelDestinoDaTransferencia.AutoSize = true;
            this.labelDestinoDaTransferencia.Location = new System.Drawing.Point(24, 29);
            this.labelDestinoDaTransferencia.Name = "labelDestinoDaTransferencia";
            this.labelDestinoDaTransferencia.Size = new System.Drawing.Size(163, 17);
            this.labelDestinoDaTransferencia.TabIndex = 16;
            this.labelDestinoDaTransferencia.Text = "Destino da transferência";
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(236, 26);
            this.comboDestinoTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(121, 24);
            this.comboDestinoTransferencia.TabIndex = 15;
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(13, 437);
            this.botaoNovaConta.Margin = new System.Windows.Forms.Padding(4);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(111, 28);
            this.botaoNovaConta.TabIndex = 15;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // botaoCalcularTributos
            // 
            this.botaoCalcularTributos.Enabled = false;
            this.botaoCalcularTributos.Location = new System.Drawing.Point(161, 437);
            this.botaoCalcularTributos.Margin = new System.Windows.Forms.Padding(4);
            this.botaoCalcularTributos.Name = "botaoCalcularTributos";
            this.botaoCalcularTributos.Size = new System.Drawing.Size(85, 28);
            this.botaoCalcularTributos.TabIndex = 16;
            this.botaoCalcularTributos.Text = "Tributos";
            this.botaoCalcularTributos.UseVisualStyleBackColor = true;
            this.botaoCalcularTributos.Click += new System.EventHandler(this.botaoCalcularTributos_Click);
            // 
            // groupBoxTransferencia
            // 
            this.groupBoxTransferencia.Controls.Add(this.comboDestinoTransferencia);
            this.groupBoxTransferencia.Controls.Add(this.labelDestinoDaTransferencia);
            this.groupBoxTransferencia.Location = new System.Drawing.Point(12, 119);
            this.groupBoxTransferencia.Name = "groupBoxTransferencia";
            this.groupBoxTransferencia.Size = new System.Drawing.Size(383, 73);
            this.groupBoxTransferencia.TabIndex = 17;
            this.groupBoxTransferencia.TabStop = false;
            this.groupBoxTransferencia.Text = "Transferência";
            // 
            // botaoRelatorios
            // 
            this.botaoRelatorios.Location = new System.Drawing.Point(285, 437);
            this.botaoRelatorios.Name = "botaoRelatorios";
            this.botaoRelatorios.Size = new System.Drawing.Size(110, 28);
            this.botaoRelatorios.TabIndex = 18;
            this.botaoRelatorios.Text = "Relatórios";
            this.botaoRelatorios.UseVisualStyleBackColor = true;
            this.botaoRelatorios.Click += new System.EventHandler(this.botaoRelatorios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 478);
            this.Controls.Add(this.botaoRelatorios);
            this.Controls.Add(this.groupBoxTransferencia);
            this.Controls.Add(this.botaoCalcularTributos);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBoxBuscaDeConta);
            this.Controls.Add(this.groupBoxConta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConta.ResumeLayout(false);
            this.groupBoxConta.PerformLayout();
            this.groupBoxBuscaDeConta.ResumeLayout(false);
            this.groupBoxBuscaDeConta.PerformLayout();
            this.groupBoxTransferencia.ResumeLayout(false);
            this.groupBoxTransferencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button butaoSacar;
        private System.Windows.Forms.GroupBox groupBoxConta;
        private System.Windows.Forms.Label labelEscolhaAConta;
        private System.Windows.Forms.GroupBox groupBoxBuscaDeConta;
        private System.Windows.Forms.ComboBox comboIndice;
        private System.Windows.Forms.Button botaoTransferir;
        private System.Windows.Forms.Label labelDestinoDaTransferencia;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoCalcularTributos;
        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.TextBox textoBuscarTitular;
        private System.Windows.Forms.Label labelBuscaPorTitular;
        private System.Windows.Forms.GroupBox groupBoxTransferencia;
        private System.Windows.Forms.Button botaoRelatorios;
    }
}

