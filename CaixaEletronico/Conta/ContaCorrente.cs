using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.ContaBanco
{
    class ContaCorrente : Conta
    {

        public override bool Saca(double valor)
        {
            if (valor > this.Saldo || valor < 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= (valor + 0.1);
                return true;
            }
        }
    }
}
