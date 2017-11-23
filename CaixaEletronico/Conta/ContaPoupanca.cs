using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.ContaBanco
{
    class ContaPoupanca : Conta
    {
        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor + 0.1;
            }
        }
    }
}
