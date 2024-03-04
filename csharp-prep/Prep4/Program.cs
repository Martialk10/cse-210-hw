using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> language = new List<string>();
        language.Add("Java");
        language.Add("Python");
        language.Add("C#");
        Console.WriteLine("Browse list with loop foreach");

        foreach(string item in language)
        {
            Console.WriteLine("item");
        }

        Console.WriteLine("Browse  list with the loop for");

        for(int i = 0; i<language.Count; i++)
        {
            Console.WriteLine("language[i]");
        }
    }

}