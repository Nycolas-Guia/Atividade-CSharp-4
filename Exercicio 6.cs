using System;

class Program {
  public static void Main (string[] args) {

    //6 – Crie um programa que permite que o usuário digite o valor de um numero qualquer, verificar se o numero é múltiplo de 3 e de 7 ao mesmo tempo, caso seja imprimir na tela “Múltiplo de 3 e 7”, caso não imprimir “Não é múltiplo”.
    double x;

   Console.WriteLine("Digite um número: ");
    x = Convert.ToDouble(Console.ReadLine());

   if(x % 3 == 0 && x % 7 == 0){
    Console.WriteLine("Multiplo de 3 e 7");
      
    } else if(x % 3 == 0 || x % 7 == 0){
      Console.WriteLine("Multiplo ou de 3 ou de 7");
      
    } else {
      Console.WriteLine("Não é multiplo de 3 nem de 7");
      
    }
    
Console.ReadKey();
  }
}