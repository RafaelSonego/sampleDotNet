using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.ClienteBanco;
using CaixaEletronico.ContaBanco;
using CaixaEletronico.Utils;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        ContaBanco.Conta contaOrigem;
        ContaBanco.Conta contaDestino;
        ContaBanco.Conta[] contas = new ContaBanco.Conta[100];
        private int quantidadeDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas[0] = new ContaCorrente();
            this.contas[0].Numero = 1;
            this.contas[0].Titular = new ClienteBanco.Cliente("Rafael");
            this.contas[0].Titular.idade = 32;
            quantidadeDeContas++;
            this.contas[1] = new ContaPoupanca();
            this.contas[1].Numero = 2;
            this.contas[1].Titular = new ClienteBanco.Cliente("Jessica");
            this.contas[1].Titular.idade = 32;
            quantidadeDeContas++;

            foreach (ContaBanco.Conta conta in contas)
            {
                if(conta != null)
                {
                    comboContas.Items.Add(conta);
                    comboContas.DisplayMember = "Titular";
                    comboDestinatario.Items.Add(conta);
                    comboDestinatario.DisplayMember = "Titular";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(contaOrigem != null)
            {
                string textoDoValorDoDeposito = textoValor.Text;
                double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
                this.contaOrigem.Deposita(valorDeposito);

                this.MostraConta(this.contaOrigem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(contaOrigem != null)
            {
                string textoDoValorDoSaque = textoValor.Text;
                double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
                this.contaOrigem.Saca(valorSaque);

                this.MostraConta(this.contaOrigem);
            }
        }

        private void MostraConta(ContaBanco.Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoValor.Text = "";
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            ContaBanco.Conta contaSelecionada = this.contas[indiceSelecionado];
            this.contaOrigem = contaSelecionada;
            this.MostraConta(contaSelecionada);
        }

        private void comboDestinatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboDestinatario.SelectedIndex;
            ContaBanco.Conta contaSelecionada = this.contas[indiceSelecionado];
            this.contaDestino = contaSelecionada;
            if (contaDestino.Equals(contaOrigem))
            {
                btnTransferencia.Enabled = false;
                contaDestino = null;
            }
            else
            {
                lblSaldoDestinatario.Text = Convert.ToString(contaDestino.Saldo);
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            if(contaDestino != null)
            {
                double valorTransferencia = Convert.ToDouble(textoValorTransferencia.Text);
                contaOrigem.Transfere(valorTransferencia, contaDestino);
                lblSaldoDestinatario.Text = Convert.ToString(contaDestino.Saldo);
                textoValorTransferencia.Text = "";
                btnTransferencia.Enabled = false;
                MostraConta(contaOrigem);
            }
        }

        private void textoValorTransferencia_TextChanged(object sender, EventArgs e)
        {
            btnTransferencia.Enabled = !string.IsNullOrEmpty(textoValorTransferencia.Text) && contaDestino != null;
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textoValor.Text) && contaOrigem != null;
            button2.Enabled = textoValor.Text.Length > 0 && contaOrigem != null;
        }

        public void adicionaConta(Conta conta)
        {
            this.contas[quantidadeDeContas++] = conta;
            quantidadeDeContas++;
            comboContas.Items.Add(conta);
            comboDestinatario.Items.Add(conta);
            comboDestinatario.DisplayMember = "Titular";
            comboContas.DisplayMember = "Titular".Delicia();
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastro = new CadastroDeContas(this);
            cadastro.ShowDialog();
        }

        private Conta criarContaTeste(double valor)
        {
            Conta c = new ContaCorrente();
            c.Deposita(valor);
            return c;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            var newContas = new List<Conta>();
            newContas.Add(criarContaTeste(200.0));//Esse
            newContas.Add(criarContaTeste(100.0));
            newContas.Add(criarContaTeste(30.0));
            newContas.Add(criarContaTeste(400.0));//Esse
            newContas.Add(criarContaTeste(70.0));

            var filtradas = from c in newContas
                            where c.Saldo > 100
                            orderby c.Saldo descending
                            select c;

            double saldoTotal = filtradas.Sum(c => c.Saldo);
            MessageBox.Show("Saldo é: " + saldoTotal);

            /*foreach(Conta c in filtradas)
            {
                MessageBox.Show("Resultado: " + + c.Saldo);
            }*/

        }
    }
}