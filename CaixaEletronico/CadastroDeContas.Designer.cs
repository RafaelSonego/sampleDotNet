namespace CaixaEletronico
{
    partial class CadastroDeContas
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
            this.textoNumeroDaConta = new System.Windows.Forms.TextBox();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(79, 33);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumeroDaConta
            // 
            this.textoNumeroDaConta.Location = new System.Drawing.Point(79, 78);
            this.textoNumeroDaConta.Name = "textoNumeroDaConta";
            this.textoNumeroDaConta.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroDaConta.TabIndex = 1;
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(79, 137);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConta.TabIndex = 2;
            this.btnNovaConta.Text = "Novo";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.textoNumeroDaConta);
            this.Controls.Add(this.textoTitular);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumeroDaConta;
        private System.Windows.Forms.Button btnNovaConta;
    }
}