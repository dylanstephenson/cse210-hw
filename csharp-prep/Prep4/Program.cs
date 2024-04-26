using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numberInp = -1;
        int sum = 0;
        int bigNum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numberInp != 0)
        {
            Console.Write("Enter number: ");
            numberInp = int.Parse(Console.ReadLine());

            numbers.Add(numberInp);
            if (numberInp > bigNum)
            {
                bigNum = numberInp;
            }
        numbers.Remove(0);
        }
        foreach (int number in numbers)
        {
            sum += number;
        }

        int numberCount = numbers.Count;
        float average = (float)sum / (float)numberCount;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"the average is: {average}");
        Console.WriteLine($"The largest number is: {bigNum}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}