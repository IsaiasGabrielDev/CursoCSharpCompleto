using System;
using System.Globalization;

namespace ConsoleApplication2
{
	class Program
	{
		/* static void Main(string[] args)
		{
			string produto1 = "Computador";
			string produto2 = "Mesa de escritório";

			byte idade = 30;
			int codigo = 5290;
			char genero = 'M';

			double preco1 = 2100.00;
			double preco2 = 650.50;
			double medida = 53.234567;

			Console.WriteLine("Produtos:");
			Console.WriteLine(produto1 + ", cujo o preço é $ " + preco1.ToString("F2"));
			Console.WriteLine(produto2 + ", cujo o preço é $ " + preco2.ToString("F2"));
			Console.WriteLine("Registro: " + idade + " anos de idade, código: " + codigo + " e gênero: " + genero);
			Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
			Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
			Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
		} */


		//Entrada de dados, dividindo uma frase em variaveis 
		/*  static void Main(string[] args) 
        {
			
			
			string frase = Console.ReadLine();
			string x = Console.ReadLine();
			string y = Console.ReadLine();
			string z = Console.ReadLine();
			
			string[] v = Console.ReadLine().Split(' ');
			string a = v[0];
			string b = v[1];
			string c = v[2];
			Console.WriteLine("Você digitou: ");
            Console.WriteLine(x);
			Console.WriteLine(y);
			Console.WriteLine(z);
			Console.WriteLine("Por variável: ");
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine("resultado laço:");


			for (int i = 0; i < 3; i++)
            {
				Console.WriteLine(v[i]);
			}


		}*/

		/*  static void Main(string[] args)
	   {
		   int n1 = int.Parse(Console.ReadLine());
		   char ch = char.Parse(Console.ReadLine());
		   double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		   Console.WriteLine("Você digitou");
		   Console.WriteLine(n1);
		   Console.WriteLine(ch);
		   Console.WriteLine(n2);


	   }*/


		// uso do Split para separar String Split(' ');
		/*static void Main(string[] args) //exercicio de fixação
        {
            Console.WriteLine("Entre com seu nome completo: ");
			string name = Console.ReadLine();
			Console.WriteLine("Quantos Quartos tem a sua casa? ");
			int rooms = int.Parse(Console.ReadLine());
			Console.WriteLine("Entre com o preço de um produto: ");
			double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Entre com o seu nome, idade e altura (na mesma linha): ");
			
			String [] vet = Console.ReadLine().Split(' ');
			string lastname = vet[0];
			int idade = int.Parse(vet[1]);
			double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou; ");
			Console.WriteLine(name);
			Console.WriteLine(rooms);
			Console.WriteLine(value);
			Console.WriteLine(lastname);
			Console.WriteLine(idade);
			Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
			

			



		}*/

		/*
		 using  System ;


		// Programa para calcular horas.
        static  void  Main ( string [] args ) 
		{

            string [] valores  =  Console . ReadLine (). Dividir ( '' );
            int  horaInicial  =  int . Parse ( valores [ 0 ]);
            int  horaFinal  =  int . Parse ( valores [ 1 ]);

            int  duracao ;
            if ( horaInicial  <  horaFinal ) {
                duracao  =  horaFinal  -  horaInicial ;
            }
            else {
                duracao  =  24  -  horaInicial  +  horaFinal ;
            }

            Console . WriteLine ( " O JOGO DUROU "  +  duracao  +  " HORA (S) " );
        }
    

		 */

		/* //Estrutura While
		static void Main(string[] args)
		{
		double x = 0;

		while (x >=0) 
		{

			Console.WriteLine("Digite um numero: ");
			x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			double raiz = Math.Sqrt(x);
			Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
		}
		Console.WriteLine("O numero é negativo! ");

		} */

		/* static void Main(string[] args) //Laço for
		{
			double soma = 0;
			
			Console.Write("Quantos numeros você irá digitar: " );
			int m = int.Parse(Console.ReadLine());


			for(int i = 1; i <= m; i++)
            {
                
				Console.WriteLine("Valor #{0}:", i);
				soma += double.Parse(Console.ReadLine());
				
			}

			Console.WriteLine("Soma = " + soma);

		}
		*/


	}
}
