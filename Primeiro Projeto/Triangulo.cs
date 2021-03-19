using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro_Projeto
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Calc()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }


    }

    class Pessoa
    {
        public string nome;
        public int idade;

            
    }

    class Empresa
    {
        public string nome;
        public double salario;
    }
}
