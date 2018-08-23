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
    }
}
