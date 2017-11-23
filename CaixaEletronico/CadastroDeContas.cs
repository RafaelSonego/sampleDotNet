using CaixaEletronico.ClienteBanco;
using CaixaEletronico.ContaBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            if (!string.IsNullOrEmpty(titular) || string.IsNullOrEmpty(textoNumeroDaConta.Text))
            {
                int numero = Convert.ToInt32(textoNumeroDaConta.Text);
                Cliente cli = new Cliente(titular);
                cli.idade = 27;
                Conta conta = new ContaPoupanca()
                {
                    Numero = numero,
                    Titular = cli,

                };

                this.aplicacaoPrincipal.adicionaConta(conta);
                this.Close();
            }
        }
    }
}
