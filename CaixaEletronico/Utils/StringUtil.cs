using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Utils
{
    public static class StringUtil
    {
        public static string Delicia(this string nome)
        {
            return nome + " delicia";
        }

        public static int somaUm(this int valor, int valorASerSomado)
        {
            return valor + valorASerSomado;
        }

    }


}
