using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Random random = new Random();

        int min = random.Next(1, 50);
        int max = random.Next(51, 100);

        if (min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }

        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (uniqueNumbers.Count < (max - min))
        {
            int number = random.Next(min, max + 1);
            uniqueNumbers.Add(number);
        }

        int[] numbersArray = new int[uniqueNumbers.Count];
        uniqueNumbers.CopyTo(numbersArray);

        Console.WriteLine($"Límites: {min} a {max}");
        Console.WriteLine("Números no repetidos:");
        foreach (var number in numbersArray)
        {
            Console.WriteLine(number);
        }
    }
}
