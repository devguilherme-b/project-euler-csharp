using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler.Desafios;

public static class MultiplesOfTwoNumbers
{
    public static void Execute()
    {
        Console.WriteLine("\nWhat's your first number for the sum?");
        int firstNum = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("\nWhat's your second number for the sum?");
        int secondNum = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("\nWhat's your condition for the sum?");
        int condicao = Convert.ToInt16(Console.ReadLine());

        HashSet<int> multiples = new HashSet<int>();
        int resto;
        for (int y = 1; y < condicao; y++)
        {
            resto = y % firstNum;
            if (y % firstNum == 0 || y % secondNum == 0)
                multiples.Add(y);
        }
        int soma = multiples.Sum();
        Console.WriteLine($"A soma dos multiplos de {firstNum} e {secondNum} menores que {condicao} é: {soma}");
    }
}
