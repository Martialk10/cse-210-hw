[18:42, 31/03/2024] MVRKO ANG&LS: using System;
// as a stretch, I tried to keep a log fo how many times activities were performed. 
// I tried to make sure that there were no prompts repeated. 

class Program
{
    static void Main(string[] args)
    {
        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;

        // Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity"…
[18:45, 31/03/2024] MVRKO ANG&LS: using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();
        Console.Write("\n** Welcome to the Mindfulness Program ***\n");
        //Call Choices
        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
              …
[18:59, 31/03/2024] MVRKO ANG&LS: using System;

public class EternalGoal : Goal
{
    // Attributes
    private string _type = "Eternal Goal:";
    private bool _status;


    // Constructors
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }

    // Methods

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }


