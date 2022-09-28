using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auladerevisao
{
     internal class program
    {
        static void Main(string[]args)
        {
            Text();
            Tiposvariaveis();
            Entradadedados();
            LacoIf();
            LacoWhile();
            LacoFor();

        }
        static void Text()
        {
            int numero1=1,numero2=9,resultado;
            resultado = -numero1 + numero2;

            Console.WriteLine("boa tarde"+resultado);

        }
        static void Tiposvariaveis()
        {
            Console.WriteLine ("aqui esta as declarações das variaveis!");

            bool falsa = false;
            int num1 = 1;
            double numeroreal = 2.1;
            float nn = 0f;
            const char nome = 'n';
            string nome2 = "ola";

            Console.WriteLine(num1 + " " + numeroreal + " " + nn + " " + nome + " " + nome2);


        }

        static void Entradadedados()
        {
            Console.WriteLine("aqui esta a entarda de dados");
            int num1 ;
            double numeroreal;
            string nome;

            Console.WriteLine("digite um numero inteiro . (um numero sem virgula)");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite um numero real . (um numero com virgula)");
            numeroreal = double.Parse(Console.ReadLine());

            Console.WriteLine("digite um nome ");
            nome =Console.ReadLine();
        }
        static void LacoIf()
        {
            int numero1=0,numero2=10;

            if (numero1 > numero2)
            {
                Console.WriteLine("numero maior");
            }
            else
            {
                Console.WriteLine("numero menor");
            }
        static void LacoWhile()
            {
                int cont = 0, numero2 = 5;
                while (cont<numero2)
                {
                    Console.WriteLine("eu sou o melhor do senai");
                    cont++;
                }

            }

        }
            static void LacoFor()
            {
             int numero2=5

                for (int cont=1; cont<numero2; cont++)
                {
                Console.WriteLine("eu sou o melhor do senai");
                }
            }
        

    }
}