using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you score? ");
        string score = Console.ReadLine();
        int percent = int.Parse(score);


        if (percent >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}