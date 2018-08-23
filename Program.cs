using System;
using System.Linq;
using System.Collections.Generic;

public class Filtering
{
    public static void Main()
    {
        // Find the words in the collection that start with the letter 'L'
        List<string> Fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

        List<string> LFruits = (from fruit in Fruits
                                where fruit.StartsWith("L")
                                select fruit).ToList();


        foreach (string f in LFruits)
        {
            Console.WriteLine(f);
        }


        // Which of the following numbers are multiples of 4 or 6
        List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

        List<int> fourSixMultiples = numbers.Where(n => (n % 4 == 0) || (n % 6 ==0)).ToList();

        foreach (int n in fourSixMultiples) {
            Console.WriteLine(n);
        }
    }
}
