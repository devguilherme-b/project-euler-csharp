using System;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler.Desafios;

namespace ProjectEuler.Desafios;

public class MultiplesOf3or5
{
    public static void SearchMultiples(int valorA, int valorB, int condicao)
    {
        HashSet<int> multiples = new HashSet<int>();
        int resto;
        for (int y = 1; y < condicao; y++)
        {
            resto = y % valorA;
            if (y % valorA == 0 || y % valorB == 0)
                multiples.Add(y);
        }
        int soma = multiples.Sum();
        Console.WriteLine($"A soma dos multiplos de {valorA} e {valorB} menores que {condicao} é: {soma}");
    }
}
