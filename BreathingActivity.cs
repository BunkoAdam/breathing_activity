class BreathingActivity : Activity
{
    private string _OSBreatheIn = "Breathe In...";
    private string _OSBreatheOut = "Breathe Out...";
    private int _OSPause;



    public BreathingActivity(string ASName, string OSDescription) : base(ASName, OSDescription)
    {
        _ASName = ASName;
        _OSDescription = OSDescription;


    }
    public void OSSetPause()
    {
        bool OSPauseAssigned = false;
        do
        {
            Console.Write("Would you like to breathe in 4 second intervals or 7 second intervals? ");

            int OSPauseTime = int.Parse(Console.ReadLine());
            if (OSPauseTime == 4 || OSPauseTime == 7)
            {
                _OSPause = OSPauseTime;
                OSPauseAssigned = true;
            }
            else
            {
                Console.WriteLine("You must choose either 4 or 7.");
            }
        } while (OSPauseAssigned == false);

    }





    public void ASRunActivity()
    {

        base.ASStartingMessage();
        OSSetPause();
        DateTime OSStartActivity = DateTime.Now;
        DateTime OSEndTime = OSStartActivity.AddSeconds(_OSDuration);

        while (DateTime.Now < OSEndTime)
        {
            Console.Write(_OSBreatheIn);
            OSCreateCountdown(_OSPause);
            Console.WriteLine();
            Console.Write(_OSBreatheOut);
            OSCreateCountdown(_OSPause);
            Console.WriteLine();

        }

        base.OSEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    }

}