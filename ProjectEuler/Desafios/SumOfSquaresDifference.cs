using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler.Desafios;

public static class SumOfSquaresDifference
{
    public static List<int> squares = [];
    public static int sumSquares;
    public static int SumFirstTenNaturalNumbers;

    public static void Execute()
    {
        var limit = GetDatas();
        LogicExecute(limit);

    }
    private static int GetDatas()
    {
        Console.WriteLine("\nWhat's of the limit nutaral number?");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int SumSquaresOfTheFirstTenNaturalNumbers(int condition)
    {
        for (int i = 1; i <= condition; i++)
        {
            squares.Add(Convert.ToInt32(Math.Pow(i, 2)));
        }
        return squares.Sum();
    }

    private static void LogicExecute(int limit)
    {
        // Sum squares first ten natural numbers 
        sumSquares = SumSquaresOfTheFirstTenNaturalNumbers(limit);
        // Sum first ten natural numbers
        SumFirstTenNaturalNumbers = SuOfTheFirstTenNaturalNumbers(limit);
        // Difference
        Console.WriteLine(SumFirstTenNaturalNumbers - sumSquares);
    }

    private static int SuOfTheFirstTenNaturalNumbers(int condition)
    {
        squares.Clear();
        for (int i = 1; i <= condition; i++)
        {
            squares.Add(i);
        }
        return Convert.ToInt32(Math.Pow(squares.Sum(), 2));
    }

}
