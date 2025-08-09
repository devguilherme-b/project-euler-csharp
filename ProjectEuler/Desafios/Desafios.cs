using System;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler;

namespace ProjectEuler.Desafios;

public static class DesafiosFeitos
{
    public static void MultiplesOfTwoNumbers()
    {
        Console.WriteLine("What's your first number for the sum?");
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

    public static void CreateFibonacciSequence()
    {
        int condicao = Convert.ToInt16(Console.ReadLine().Trim());
        List<int> sequenciaFibonacci = new List<int> { 1, 2 };
        List<int> evenNumbers = new List<int> { 2 };
        int newItem = 0;
        while (newItem < condicao)
        {
            int ultimoIndex = sequenciaFibonacci[sequenciaFibonacci.Count - 1];
            int penultimoIndex = sequenciaFibonacci[sequenciaFibonacci.Count - 2];
            newItem = ultimoIndex + penultimoIndex;
            sequenciaFibonacci.Add(newItem);
            if (newItem % 2 == 0)
                evenNumbers.Add(newItem);
        }
        int resultado = evenNumbers.Sum();
        Console.WriteLine($"\nA soma de todos os números pares da Sequência de Fibonacci menores que {condicao} é: " + resultado);
    }

    public static void BiggestFactorFirstOf()
    {
        long entrada = Convert.ToInt64(Console.ReadLine());
        List<long> Fatorados = [];
        for (long x = 1; x <= entrada; x++)
        {
            long resto = entrada % x;
            if (resto == 0)
            {
                if (x != 1)
                {
                    long ultimo = Fatorados[Fatorados.Count - 1];
                    long mult = x * ultimo;
                    Fatorados.Add(mult);
                    if (mult == entrada)
                    {
                        Console.WriteLine($"O maior fator primo de {entrada} é {x}");
                        break;
                    }
                }
                else
                    Fatorados.Add(x);
            }
        }
    }


}