using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a number (0 to stop): ");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
              if (number != 0)
            {
                numbers.Add(number);
            }

            int sum = 0;

            foreach (int item in numbers)
            {
                sum = sum + item;
            }
            Console.WriteLine($"The sum is {sum}");


            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is {average}");


            int max = numbers[0];

            foreach (int Number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is {max}");
        }

    }
}