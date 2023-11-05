using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userEntry = -1;
        while (userEntry != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            
            string userInput = Console.ReadLine();
            userEntry = int.Parse(userInput);
            
            if (userEntry != 0)
            {
                numbers.Add(userEntry);
            }
        }

        //Total of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Total: {sum}");

        //Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Max Number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}