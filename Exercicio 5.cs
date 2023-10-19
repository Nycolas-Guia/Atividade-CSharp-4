using System;

class Program {
  public static void Main (string[] args) {

    //5 – Crie um programa que permita que o usuário digite o valor das vendas que executou neste mês, imprimir na tela o premio que ganhou por estas vendas de acordo com os critérios abaixo:
//Menor que R$ 1000,00 (Sem premio).
//Maior igual a R$ 1000,00 e menor que R$ 3000,00 (premio de R$ 150,00).
//Maior igual a R$ 3000,00 (premio de R$ 300,00).
    
      double x;



   Console.WriteLine("Digite o valor total de suas vendas? ");
    x = Convert.ToDouble(Console.ReadLine());
      
    if(x < 1000){
    Console.WriteLine("Sem premio.");
      
    } else if(x < 3000){
      
     Console.WriteLine("Premio de R$150,00.");
    
    } else{



     Console.WriteLine("Premio de R$300,00.");
    }
    
Console.ReadKey();
  }
}