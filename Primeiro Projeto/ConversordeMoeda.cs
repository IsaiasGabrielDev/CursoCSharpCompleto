using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro_Projeto
{
    class ConversordeMoeda
    {
        public static double iof = 6.00;

        public static double DolarparaReal(double valor, double cotacao)
        {
            double total = valor * cotacao;
            return total + total * (iof / 100);
        }
    }
}
