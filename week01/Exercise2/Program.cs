using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage ");
        string answer =  Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";
         if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";    
        }
        else if (percent >= 70)
            {
                letter = "C";
            }

        else if (percent >= 60)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            } 
        Console.WriteLine($"Your Grade is {letter}");
        int LastDigit = percent %10;
        string sign ="";

         if (LastDigit >= 7)
            {
                sign = "+";
            }
        else if (LastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }
        
        Console.WriteLine($"Your Grade is {letter}{sign}");
        }
    }
