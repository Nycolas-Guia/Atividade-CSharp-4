using System;

class Program {
  public static void Main (string[] args) {

       //1 – Criar um programa que permita que o usuário digite um número,
            // verificar se este número é maior que 20, se for maior mostrar na tela a metade do número digitado,
            // caso seja menor 20 mostrar o dobro do número digitado.

            double x, r;

            Console.WriteLine("Digite um número: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x >= 20)
            {
                r = x / 2;
                Console.WriteLine("Metade do número:" + r);
            } else 
            {
                r = x * 2;
                Console.WriteLine("Dobro do número:" + r);
            }


            Console.ReadKey();
  }
}