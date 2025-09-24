using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler.Desafios;

public static class BiggestFactorFirstOf
{
    public static void Execute()
    {
        Console.WriteLine("\nInsert any limit number dor the sequence");
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
