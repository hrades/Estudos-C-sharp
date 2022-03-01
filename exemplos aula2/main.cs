/*Objetivo: Fazer um programa que realize as 4 operações e possua uma interface de escolha de operação.
Autor: Heloísa Rades de Souza
Data: 01/03/2022
*/

using System;

class Program {
  public static void Main (string[] args) {
    int comando = 6;

    while(comando != 0){
    //interface que indica quais números equivalem a quais comandos
      Console.WriteLine("Escolha o que quer fazer:");
      Console.WriteLine("- 1 para somar 2 números");
      Console.WriteLine("- 2 para subtrair 2 números");
      Console.WriteLine("- 3 para multiplicar 2 números");
      Console.WriteLine("- 4 para dividir 2 números");
      Console.WriteLine("- 0 para finalizar o programa");

        //recebe o número que equivale a um comando
      comando = Convert.ToInt32(Console.ReadLine()); 
      Console.WriteLine("");

      switch(comando)  //executa uma função a partir do número informado
      {
        case 0:  //finaliza o programa
            continue;
        case 1:
            Soma();
            Console.WriteLine("");
            break;
        case 2:
            Subtracao();
            Console.WriteLine("");
            break;
        case 3:
            Multiplicar();
            Console.WriteLine("");
            break;
        case 4:
            Divisao();
            Console.WriteLine("");
            break;
      }
    }
    Console.WriteLine("Fim do Programa");
  }
  static void Soma(){ //função de soma
    double num1 = 0, num2 = 0, soma;

    Console.WriteLine("Escreva o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Escreva o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    
    soma = num1 + num2;
    
    Console.WriteLine("O resultado da soma dos números informados é: {0}", soma);
  }
  static void Subtracao(){  //função de subtração
    double num1 = 0, num2 = 0, sub;

    Console.WriteLine("Escreva o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Escreva o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    
    sub = num1 - num2;
    
    Console.WriteLine("O resultado da subtração dos números informados é: {0}", sub);
  }
  static void Multiplicar(){  //função de multiplicação
    double num1 = 0, num2 = 0, mult;

    Console.WriteLine("Escreva o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Escreva o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    
    mult = num1 * num2;
    
    Console.WriteLine("O resultado da multiplicação dos números informados é: {0}", mult);
  }
  static void Divisao(){  //função de divisão
    double num1 = 0, num2 = 0, div;

    Console.WriteLine("Escreva o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Escreva o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    
    div = num1 / num2;
    
    Console.WriteLine("O resultado da divisão dos números informados é: {0}", div);
  }
}