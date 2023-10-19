using System;

class Program {
  public static void Main (string[] args) {

    //3 – A prefeitura esta concedendo empréstimos a seus funcionários seguindo a regra de que a prestação não pode ser maior que 30% do valor do salário. Criar um programa que permita a entrada do salário e da prestação do empréstimo, verificar se a prestação digitada corresponde a regra de empréstimo descrita acima.


     double x, y, z;



   Console.WriteLine("Digite seu sálario: ");
    x = Convert.ToDouble(Console.ReadLine());
     
    Console.WriteLine("Digite o valor da prestação ");
    y = Convert.ToDouble(Console.ReadLine());



   z = (x) * 30 / 100;
      
    if(y > z){
    Console.WriteLine("Você não obteve o beneficio.\nSalário: R$" + x);
      
    } else{
      
     Console.WriteLine("Você recebeu o beneficio\nSalário: R$" + (x+z));
    
    }
    
Console.ReadKey();
  }
}