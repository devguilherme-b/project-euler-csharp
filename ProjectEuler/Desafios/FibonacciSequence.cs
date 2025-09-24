using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler.Desafios;

public static class FibonacciSequence
{
    public static void Create()
    {
        Console.WriteLine("\nInsert a limit number for create the Fibonacci sequence:");
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
}
