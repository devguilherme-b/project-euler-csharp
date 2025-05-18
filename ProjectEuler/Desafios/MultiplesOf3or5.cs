using System;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler.Desafios;

namespace ProjectEuler.Desafios;

public class MultiplesOf3or5
{


    public static void SearchMultiplesOf3or5()
    {
        // HashSet<T> para armazenar os multiplos 
        HashSet<int> multiples = new HashSet<int>();
        // Valores de entrad
        int valorA = 3;
        int valorB = 5;
        // Valor para a condicional
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
}
