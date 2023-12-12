class ListingActivity : Activity
{
    private List<string> _OSUserInputs = new List<string>();

    public ListingActivity(string ASName, string OSDescription, List<string> OSPrompts) : base(ASName, OSDescription, OSPrompts)
    {

    }


    public void OSSpecificActivity()
    {
        Console.Write(">");
        string OSNewInput = Console.ReadLine();
        _OSUserInputs.Add(OSNewInput);
    }

    public void ASRunActivity()
    {

        ASStartingMessage();
        DateTime OSStartActivity = DateTime.Now;
        DateTime OSEndTime = OSStartActivity.AddSeconds(_OSDuration);

        Console.WriteLine("Please read the following prompt:");
        int OSRandomPrompt = base.OSReturnRandomNumber(_OSPrompts);
        string OSChosenPrompt = _OSPrompts[OSRandomPrompt];
        Console.WriteLine($"{OSChosenPrompt}");
        Thread.Sleep(1000);
        Console.Write("You may begin in: ");
        OSCreateCountdown(5);
        Console.WriteLine();

        while (DateTime.Now < OSEndTime)
        {
            Console.Write(">");
            string OSNewInput = Console.ReadLine();
            _OSUserInputs.Add(OSNewInput);
        }
        Console.WriteLine($"You entered in {_OSUserInputs.Count()} items. ");


        OSEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    }
}