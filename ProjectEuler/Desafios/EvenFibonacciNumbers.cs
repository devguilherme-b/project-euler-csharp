using System;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler;

namespace ProjectEuler.Desafios;

public class EvenFibonacciNumbers
{
    public static void CreateFibonacciSequence()
    {
        // Listas necessarias
        List<int> sequenciaFibonacci = new List<int> { 1, 2 };
        List<int> evenNumbers = new List<int> { 2 };
        int condicao = 4_000_000;
        int newItem = 0;

        // Limita para 10 interacoes
        for (int i = 0; i <= 100; i++)
        {
            // Indexadores de pesquisa da List<T>
            int ultimoIndex = sequenciaFibonacci[sequenciaFibonacci.Count - 1];
            int penultimoIndex = sequenciaFibonacci[sequenciaFibonacci.Count - 2];
            newItem = ultimoIndex + penultimoIndex;
            if (newItem < condicao)
            {
                sequenciaFibonacci.Add(newItem);
                if (newItem % 2 == 0)
                    evenNumbers.Add(newItem);
            }
        }

        int resultado = evenNumbers.Sum();
        Console.WriteLine($"\nA soma de todos os números pares da Sequência de Fibonacci menores que {condicao} é: \n\nResultado = " + resultado);
    }

    public static void CreateFibonacciSequenceOtimized()
    {
        // Listas necessarias
        List<int> sequenciaFibonacci = new List<int> { 1, 2 };
        List<int> evenNumbers = new List<int> { 2 };
        int condicao = 4_000_000;
        int newItem = 0;
        // Console.WriteLine(newItem);
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
        Console.WriteLine($"\nA soma de todos os números pares da Sequência de Fibonacci menores que {condicao} é: \n\nResultado = " + resultado);
    }
}