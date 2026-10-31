using System;

class Program
{
    static void Main(string[] args)
    {
        
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);

    int guess = 0;
    int guess_count = 0;
    while (guess != magicNumber)
    {
        Console.Write("What is the magic number: ");
        guess = int.Parse(Console.ReadLine());

        guess_count = guess_count + 1; 
        if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
        else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
        else
            {
                Console.WriteLine("You guessed  it ");
            }  

        Console.WriteLine($"It took you {guess_count} guess");

        Console.Write("Do you want to play again (yes/no)? ");
        string playAgain = Console.ReadLine();
        if (playAgain == "yes")
            {
                Console.WriteLine();
            }
        else if (playAgain == "no")
            {
                Console.WriteLine("Thank you for playing");
                break;
            }
        else
            {
                Console.WriteLine("Please pick a valid option");
            }
    }
    }
}