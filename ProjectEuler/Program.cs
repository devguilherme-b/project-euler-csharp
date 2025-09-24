using System;
using System.Linq;
using ProjectEuler.Desafios;
using System.Diagnostics;

namespace ProjectEuler;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Desafios já desenvolvidos: \n\n1. Multiples of 3 or 5\n2. Even Fibonacci Numbers\n3. Largest Prime Factor\n4 - Sum os square;\n");
        Console.WriteLine("Digite apenas o número do desafio para executá-lo! :)");
        int escolha = Convert.ToInt32(Console.ReadLine().Trim());

        switch (escolha)
        {
            case 1:
                Desafios.MultiplesOfTwoNumbers.Execute();
                break;
            case 2:
                Desafios.FibonacciSequence.Create();
                break;
            case 3:
                Desafios.BiggestFactorFirstOf.Execute();
                break;
            case 4:
                Desafios.SumOfSquaresDifference.Execute();
                break;
            default:
                Console.WriteLine("Confira se o número está certa");
                break;
        }
    }
}
