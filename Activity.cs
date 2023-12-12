using System;

class Activity
{
    protected string _ASName;
    protected string _OSDescription;
    protected int _OSDuration;
    protected List<string> _OSPrompts = new List<string>();
    private List<string> _OSAnimationItems = new List<string> { "|", "/", "-", "\\" };



    public Activity(string ASName, string OSDescription)
    {
        _ASName = ASName;
        _OSDescription = OSDescription;
    }


    public Activity(string ASName, string OSDescription, List<string> OSPrompts)
    {
        _ASName = ASName;
        _OSDescription = OSDescription;
        _OSPrompts = OSPrompts;
    }
    protected void OSCreateAnimation(int time)
    {
        DateTime OSStartTime = DateTime.Now;
        DateTime OSEndTime = OSStartTime.AddSeconds(time);
        int i = 0;
        while (DateTime.Now < OSEndTime)
        {
            string s = _OSAnimationItems[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i == _OSAnimationItems.Count())
            {
                i = 0;
            }


        }
        // foreach (string item in OSAnimationItems){
        //     Console.Write(item);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");

        // }
    }

    protected void OSCreateCountdown(int OSNumber)
    {
        for (int i = OSNumber; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    protected int OSReturnRandomNumber(List<string> OSList)
    {
        Random OSGenerator = new Random();
        int OSNumber = OSGenerator.Next(0, OSList.Count());
        return OSNumber;
    }
    protected void ASStartingMessage()
    {
        Console.WriteLine($" Welcome to the{_ASName}. ");
        Console.WriteLine();
        Console.WriteLine($"{_OSDescription} ");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Write("How long, in seconds, would you like your session to last? ");

        _OSDuration = int.Parse(Console.ReadLine());


        Thread.Sleep(1000);
        Console.WriteLine($"Your activity will last for {_OSDuration} seconds.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Write("Get ready...");
        OSCreateAnimation(5);
        Console.WriteLine();
        // Thread.Sleep(2000);
    }

    protected void OSEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {_OSDuration} seconds of {_ASName}");
        Thread.Sleep(2000);

    }





}