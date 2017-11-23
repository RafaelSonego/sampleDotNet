using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.ClienteBanco;

namespace CaixaEletronico.ContaBanco
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public virtual void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }

        public virtual bool Saca(double valor)
        {
            if (valor > this.Saldo || valor < 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    if (valor <= 200)
                    {
                        this.Saldo -= valor;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }

    }
}
