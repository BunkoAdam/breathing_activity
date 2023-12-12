using System;

class Program
{
    static void Main(string[] args)
    {
        int ASMenuChoice = 0;

        while (ASMenuChoice != 4)
        {
            ASMenuChoice = OSMenu();
            if (ASMenuChoice == 1)
            {
                BreathingActivity OSActivity = new BreathingActivity("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ");
                OSActivity.ASRunActivity();

            }
            else if (ASMenuChoice == 2)
            {
                string OSReflectionDescription = "this activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";
                List<string> OSReflectionPrompts = new List<string>{
                    "Think of a time when you stood up for someone else. ",
                    "Think of a time when you did something really difficult. ",
                    "Think of a time when you helped someone in need. ",
                    "Think of a time when you did something truly selfless. "
                };
                ReflectionActivity OSActivity = new ReflectionActivity("Reflection Activity", OSReflectionDescription, OSReflectionPrompts, 8);
                OSActivity.ASRunActivity();
            }
            else if (ASMenuChoice == 3)
            {
                string OSListingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ";
                List<string> OSListingPrompts = new List<string>{
                    "Who are people that you appreciate? ",
                    "What are personal strengths of yours? ",
                    "Who are people that you have helped this week? ",
                    "When have you felt the Holy Ghost this month? ",
                    "Who are some of your personal heroes? "
                };
                ListingActivity OSActivity = new ListingActivity("Listing Activity", OSListingDescription, OSListingPrompts);
                OSActivity.ASRunActivity();

            }
            else if (ASMenuChoice == 4)
            {
                Console.WriteLine("Thank you for participating in the mindfulness activities! ");

            }
            else
            {
                Console.WriteLine("That was not a menu option. Please select a number from the menu. ");
            }
        }
    }


    static int OSMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        int ASMenuChoice = int.Parse(Console.ReadLine());
        return ASMenuChoice;
    }
}