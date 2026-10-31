using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        string full_name = first_name + " " + last_name;
        Console.WriteLine();
        Console.WriteLine($"Your name is {first_name}, {full_name}."); 



    }
}