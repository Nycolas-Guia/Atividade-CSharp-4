using System;

class Program {
  public static void Main (string[] args) {

    //4 – Criar um programa que permita que o usuário digite um número, verificar e mostrar na tela se o número é positivo, negativo ou zero.
    
      double x;



   Console.WriteLine("Digite um número: ");
    x = Convert.ToDouble(Console.ReadLine());
      
    if(x >= 1){
    Console.WriteLine("Seu número é positivo.");
      
    } else if(x == 0){
      
     Console.WriteLine("Seu número é zero.");
    
    } else{



     Console.WriteLine("Seu número é negativo.");
    }
    
Console.ReadKey();
  }
}