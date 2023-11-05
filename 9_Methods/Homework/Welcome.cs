namespace User;

public static class Welcome
{
    public static string GetUser()
    {
        Console.WriteLine($"What is your name?: ");
        string? userName = Console.ReadLine();
        return userName;

    }
}


