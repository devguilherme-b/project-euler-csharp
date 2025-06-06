using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ProjectEuler;

public class LargestPrimeFactor
{
    public static void CalculaPrimeFactor(long entrada)
    {
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