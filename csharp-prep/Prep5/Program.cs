using System;

class Program
{
    static void Main(string[] args)
     {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        
    }
    static int PromptUserNumber(int userNumber)
    {
        Console.Write("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int Number)
    {
        int square = Number * Number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}