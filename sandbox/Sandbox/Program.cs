using System;
using System.Collections.Generic;


public class WayToLearnX {
    public static void Main() {


         
        List<string> langage = new List<string> ();

        
        langage.Add("Java");
        langage.Add("Python");
        langage.Add("C#");
        langage.Add("PHP");
        langage.Add("C++");
        langage.Add("SQL");

        Console.WriteLine("browse the list of languages:");
        foreach(string item in langage) {
            Console.WriteLine(item);
        }

        Console.WriteLine("browse the list of languages :");
        for (int i = 0; i < langage.Count; i++) {
            Console.WriteLine(langage[i]);
        }
    }
}