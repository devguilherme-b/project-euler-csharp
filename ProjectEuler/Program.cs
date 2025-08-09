using System;
using System.Linq;
using ProjectEuler.Desafios;
using System.Diagnostics;

namespace ProjectEuler;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Desafios já desenvolvidos: \n\n1. Multiples of 3 or 5\n2. Even Fibonacci Numbers\n3. Largest Prime Factor\n");
        Console.WriteLine("Digite apenas o número do desafio para executá-lo! :)");
        int escolha = Convert.ToInt32(Console.ReadLine().Trim());

        switch (escolha)
        {
            case 1:
                Desafios.DesafiosFeitos.MultiplesOfTwoNumbers();
                break;
            case 2:
                Desafios.DesafiosFeitos.CreateFibonacciSequence();
                break;
            case 3:
                Desafios.DesafiosFeitos.MultiplesOfTwoNumbers();
                break;
            default:
                Console.WriteLine("Confira se o número está certa");
                break;
        }
    }
}
