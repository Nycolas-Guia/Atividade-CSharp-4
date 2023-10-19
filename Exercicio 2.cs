using System;

class Program {
  public static void Main (string[] args) {

    //2 – Criar um programa que permita que o usuário digite um número, verificar se o mesmo é múltiplo de 5.

    double x, v;

    Console.WriteLine("Digite um número: ");
    x = Convert.ToDouble(Console.ReadLine());
    v = x % 5;

    if(v == 0){
    Console.WriteLine("Múltiplo de 5");
      
    } else{
     Console.WriteLine("Não é multiplo de 5");
    
    }
    
    Console.ReadKey();
  }
}