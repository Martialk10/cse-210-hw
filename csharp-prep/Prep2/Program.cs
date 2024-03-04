using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your math grade out 20 ?: ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter ="";
        if(grade >= 11)
        {
            letter = "A";
            Console.WriteLine("Good job");
        }
        else if (grade == 10)
        {
            letter ="B";
            Console.WriteLine("You are just average");
        }
        else
        {
            letter = "C";
        }

        Console.WriteLine($"Your math grade is {letter}");

        if (grade >= 10)
        {
            Console.WriteLine("You passed the math test");
        }

        else
        {
            Console.WriteLine("Sorry, you have to do again the test because you did not pass.");
        }

    }
}