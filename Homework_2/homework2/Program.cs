using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> middleElements = FindMiddleElements(numbers);

        Console.WriteLine("Middle element(s):");
        foreach (var element in middleElements)
        {
            Console.WriteLine(element);
        }
    }

    static List<T> FindMiddleElements<T>(List<T> list)
    {
        int count = list.Count;

        if (count == 0)
        {
            Console.WriteLine("The list is empty.");
        }

        int middleIndex = count / 2;

        if (count % 2 == 0)
        {
            return list.GetRange(middleIndex - 1, 2);
        }
        else
        {
            return new List<T> { list[middleIndex] };
        }
    }
}