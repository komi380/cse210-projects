using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("enter a list of numbers, type 0 when finished.");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        float average = 0;
        int largest = int.MinValue;
        while (number != 0)
        {
            numbers.Add(number);
            number = int.Parse(Console.ReadLine());
        }
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        average = (float)sum / numbers.Count;
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);
    }
}