using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SomaDois();
        }

        static void PrimeiroExemplo()
        {
            string letras;
            Console.WriteLine("Bom dia! Seja bem vindo! Digite seu nome: ");
            letras = Console.ReadLine();
        }

        static void SomaDois()
        {
            int num1, num2, soma;

            Console.Write("Digite um número: ");
            num1 = Convert.ToInt32(Console/*comentário no meio*/.ReadLine()); //ou int.Parse(letra)
            Console.Write("Digite outro número para fazer uma soma: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;

            if (soma >= 5 && soma <= 20)
            {
                Console.WriteLine("\nO resultado da soma é: " + soma);
            }
            else{
                Console.WriteLine("\nO resultado da soma não está no intervalo correto");
            }

        }
    }
}
