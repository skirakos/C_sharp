using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int result = FindMax(numbers);

        Console.WriteLine("The largest element: ");
        Console.WriteLine(result);
    }

    static int FindMax(List<int> numbers)
    {
        //The first version using sort
        numbers.Sort();
        return numbers[numbers.Count - 1];
        //The second one
        //
        //
        // if (numbers.Count == 0)
        // {
        //     Console.WriteLine("The list is empty.");
        //     return -1;
        // }
        // else
        // {
        //     int maxNumber = numbers[0];
        //
        //     foreach (var number in numbers)
        //     {
        //         if (number > maxNumber)
        //         {
        //             maxNumber = number;
        //         }
        //     }
        //
        //     return maxNumber;
        // }
    }
}