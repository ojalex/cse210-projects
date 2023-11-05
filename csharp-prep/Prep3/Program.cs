using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicInput = Console.ReadLine();
        int magicNumber = int.Parse(magicInput);
        
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);


        while (guess != magicNumber)
        {

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You guessed it!");
               
            }

            
        }
        

    }
}