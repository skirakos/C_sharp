using System;
using System.Collections.Generic;

class DataStructures
{
    static void Main(string[] args)
    {
        // 1. Create a list of integers and add 5 elements to it
        List<int> numbersList = new List<int>();
        AddElementsToList(numbersList, new int[] { 1, 2, 3, 4, 5 });

        // 2. Create a dictionary with string keys and integer values, and add 5 key-value pairs to it
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        AddElementsToDictionary(dictionary, new string[] { "One", "Two", "Three", "Four", "Five" }, new int[] { 1, 2, 3, 4, 5 });

        // 3. Create a queue of integers and add 5 elements to it
        Queue<int> queue = new Queue<int>();
        Enqueue(queue, new int[] { 10, 20, 30, 40, 50 });

        // 4. Create a stack of integers and add 5 elements to it
        Stack<int> stack = new Stack<int>();
        PushStack(stack, new int[] { 100, 200, 300, 400, 500 });

        // Operations on Data Structures
        // 1. Calculate and print the sum of all elements in the list
        int sumList = CalculateListSum(numbersList);
        Console.WriteLine("Sum of all elements in the list: " + sumList);

        // 2. Calculate and print the sum of all values in the dictionary
        int sumDictionary = CalculateDictionarySum(dictionary);
        Console.WriteLine("Sum of all values in the dictionary: " + sumDictionary);

        // 3. Remove 2 elements from the queue and print the remaining elements
        Dequeue(queue, 2);
        Console.WriteLine("Remaining elements in the queue:");
        PrintQueue(queue);

        // 4. Remove 2 elements from the stack and print the remaining elements
        PopStack(stack, 2);
        Console.WriteLine("Remaining elements in the stack:");
        PrintStack(stack);

        // Additional Tasks
        // 1. Print all elements of the list
        Console.WriteLine("Elements in the list:");
        PrintList(numbersList);

        // 2. From a three-digit number (e.g., 124), print the largest digit
        int threeDigitNumber = 124;
        int largestDigit = FindLargestDigit(threeDigitNumber);
        Console.WriteLine($"Largest digit in {threeDigitNumber}: {largestDigit}");

        // 3. From a three-digit number (e.g., 124), print the smallest digit
        int smallestDigit = FindSmallestDigit(threeDigitNumber);
        Console.WriteLine($"Smallest digit in {threeDigitNumber}: {smallestDigit}");

        // 4. From an array, find all even values and print their sum
        int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sumEven = CalculateSumOfEvenNumbers(numberArray);
        Console.WriteLine("Sum of all even values in the array: " + sumEven);

        // 5. Calculate and print the average of all elements in the array
        double average = CalculateAverage(numberArray);
        Console.WriteLine("Average of all elements in the array: " + average);
    }

    // Functions
    static void AddElementsToList(List<int> list, int[] elements)
    {
        foreach (int element in elements)
        {
            list.Add(element);
        }
    }
    static void AddElementsToDictionary(Dictionary<string, int> dictionary, string[] keys, int[] values)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            dictionary.Add(keys[i], values[i]);
        }
    }
    static void Enqueue(Queue<int> queue, int[] elements)
    {
        foreach (int element in elements)
        {
            queue.Enqueue(element);
        }
    }
    static void PushStack(Stack<int> stack, int[] elements)
    {
        foreach (int element in elements)
        {
            stack.Push(element);
        }
    }
    static int CalculateListSum(List<int> list)
    {
        int sum = 0;
        foreach (int number in list)
        {
            sum += number;
        }
        return sum;
    }
    static int CalculateDictionarySum(Dictionary<string, int> dictionary)
    {
        int sum = 0;
        foreach (var kvp in dictionary)
        {
            sum += kvp.Value;
        }
        return sum;
    }
    static void Dequeue(Queue<int> queue, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (queue.Count > 0)
            {
                queue.Dequeue();
            }
        }
    }
    static void PopStack(Stack<int> stack, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
        }
    }
    static void PrintQueue(Queue<int> queue)
    {
        foreach (int element in queue)
        {
            Console.WriteLine(element);
        }
    }
    static void PrintStack(Stack<int> stack)
    {
        foreach (int element in stack)
        {
            Console.WriteLine(element);
        }
    }
    static void PrintList(List<int> list)
    {
        foreach (int number in list)
        {
            Console.WriteLine(number);
        }
    }
    static int FindLargestDigit(int number)
    {
        int largest = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > largest)
            {
                largest = digit;
            }
            number /= 10;
        }
        return largest;
    }
    static int FindSmallestDigit(int number)
    {
        int smallest = 9;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit < smallest)
            {
                smallest = digit;
            }
            number /= 10;
        }
        return smallest;
    }
    static int CalculateSumOfEvenNumbers(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }
        return sum;
    }
    static double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return (double)sum / array.Length;
    }
}