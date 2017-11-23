namespace CaixaEletronico
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDestinatario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoValorTransferencia = new System.Windows.Forms.TextBox();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldoDestinatario = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Enabled = false;
            this.textoTitular.Location = new System.Drawing.Point(63, 66);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.Text = "Titular";
            // 
            // textoNumero
            // 
            this.textoNumero.Enabled = false;
            this.textoNumero.Location = new System.Drawing.Point(63, 108);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.Text = "Numero";
            // 
            // textoSaldo
            // 
            this.textoSaldo.Enabled = false;
            this.textoSaldo.Location = new System.Drawing.Point(63, 150);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            this.textoSaldo.Text = "Saldo";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(12, 194);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            this.textoValor.TextChanged += new System.EventHandler(this.textoValor_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(124, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(205, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(63, 27);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 7;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titular";
            // 
            // comboDestinatario
            // 
            this.comboDestinatario.FormattingEnabled = true;
            this.comboDestinatario.Location = new System.Drawing.Point(81, 262);
            this.comboDestinatario.Name = "comboDestinatario";
            this.comboDestinatario.Size = new System.Drawing.Size(121, 21);
            this.comboDestinatario.TabIndex = 9;
            this.comboDestinatario.SelectedIndexChanged += new System.EventHandler(this.comboDestinatario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destinatario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TRANSFERENCIA";
            // 
            // textoValorTransferencia
            // 
            this.textoValorTransferencia.Location = new System.Drawing.Point(81, 306);
            this.textoValorTransferencia.Name = "textoValorTransferencia";
            this.textoValorTransferencia.Size = new System.Drawing.Size(100, 20);
            this.textoValorTransferencia.TabIndex = 12;
            this.textoValorTransferencia.TextChanged += new System.EventHandler(this.textoValorTransferencia_TextChanged);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Enabled = false;
            this.btnTransferencia.Location = new System.Drawing.Point(188, 306);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(75, 23);
            this.btnTransferencia.TabIndex = 13;
            this.btnTransferencia.Text = "Transferir";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Saldo Destinatario:";
            // 
            // lblSaldoDestinatario
            // 
            this.lblSaldoDestinatario.AutoSize = true;
            this.lblSaldoDestinatario.Location = new System.Drawing.Point(109, 358);
            this.lblSaldoDestinatario.Name = "lblSaldoDestinatario";
            this.lblSaldoDestinatario.Size = new System.Drawing.Size(0, 13);
            this.lblSaldoDestinatario.TabIndex = 16;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(12, 311);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 17;
            this.Valor.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Titular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Saldo";
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(205, 386);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConta.TabIndex = 21;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(16, 386);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 22;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 421);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.lblSaldoDestinatario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.textoValorTransferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDestinatario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDestinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoValorTransferencia;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldoDestinatario;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button btnTeste;
    }
}

