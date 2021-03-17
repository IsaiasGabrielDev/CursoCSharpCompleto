using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Primeiro_Projeto
{
    class OO
    {
        /*
        static void Main(string[] args) //Resolvendo o problema sem OO.
        {
            double xa, xb, xc, ya, yb, yc = 0;
            double px, py, areax, areay = 0;
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            px = (xa + xb + xc) / 2;
            py = (ya + yb + yc) / 2;

            areax = Math.Sqrt(px*(px-xa)*(px - xb)*(px - xc));
            areay = Math.Sqrt(py * (py - ya) * (py - yb) * (py - yc));

            Console.WriteLine("Área de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if(areax > areay)
            {
                Console.WriteLine("A maior Área é a de X");
            }
            else { Console.WriteLine("A maior Área é a de Y"); }
        }*/

        /*  static void Main(string[] args) //Resolvendo o problema com OO.
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            double px, py, areax, areay = 0;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            px = (x.A + x.B + x.C) / 2;
            py = (y.A + y.B + y.C) / 2;

            areax = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));
            areay = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            Console.WriteLine("Área de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("A maior Área é a de X");
            }
            else { Console.WriteLine("A maior Área é a de Y"); }
        } 
        */

        /*  
       static void Main(string[] args) //Resolvendo exercicio 1 com OO.
       {
           Pessoa a, b;
           a = new Pessoa();
           b = new Pessoa();

           Console.WriteLine("Digite o nome da primeira Pessoa: ");
           a.nome = Console.ReadLine();
           Console.WriteLine("Digite a idade da primeira Pessoa: ");
           a.idade = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o nome da segunda Pessoa: ");
           b.nome = Console.ReadLine();
           Console.WriteLine("Digite a idade da segunda Pessoa: ");
           b.idade = int.Parse(Console.ReadLine());

           if(a.idade > b.idade)
           {
               Console.WriteLine("Pessoa mais velha: " + a.nome);
           }
           else if(b.idade > a.idade)
           {
               Console.WriteLine("Pessoa mais velha: " + b.nome);
           }
           else { Console.WriteLine("{0} e {1} tem a mesma idade", a.nome, b.nome); }


       } 
        */

        /* static void Main(string[] args) //Resolvendo exercicio 1 com OO.
        {
            Empresa a, b;
            a = new Empresa();
            b = new Empresa();
            double media = 0;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: "); a.nome = Console.ReadLine();
            Console.Write("Salário: "); a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: "); b.nome = Console.ReadLine();
            Console.Write("Salário: "); b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (a.salario + b.salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

        */

    }
}

