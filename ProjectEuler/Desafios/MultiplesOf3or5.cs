using System;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler.Desafios;

namespace ProjectEuler.Desafios;

public class MultiplesOf3or5
{
    // Primeira Sokução
    public static void SearchMultiples()
    {
        // HashSet<T> para armazenar os multiplos 
        HashSet<int> multiples = new HashSet<int>();
        // Valores
        int valorA = 3;
        int valorB = 5;
        int condicao = 1000;

        int resto;
        for (int y = 1; y < condicao; y++)
        {
            resto = y % valorA;
            if (resto == 0)
                multiples.Add(y);
        }
        for (int z = 1; z < condicao; z++)
        {
            resto = z % valorB;
            if (resto == 0)
                multiples.Add(z);
        }
        int soma = multiples.Sum();
        Console.WriteLine($"O resultado é: {soma}");
    }
    // Forma Simplificada
    public static void SearchMultiplesOtimized()
    {
        // HashSet<T> para armazenar os multiplos 
        HashSet<int> multiples = new();
        // Valores de entrada
        int valorA = 3;
        int valorB = 5;
        int condicao = 1000;

        for (int y = 1; y < condicao; y++)
        {
            if (y % valorA == 0 || y % valorB == 0)
                multiples.Add(y);
        }

        int soma = multiples.Sum();
        Console.WriteLine($"A soma dos multiplos de {valorA} e {valorB} menores que {condicao} é: {soma}");
    }
}
