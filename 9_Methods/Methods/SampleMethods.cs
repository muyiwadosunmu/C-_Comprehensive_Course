namespace Methods;
public static class SampleMethods
{
    public static void SayHi(string firstName)
    {
        Console.WriteLine($"Hello {firstName}!");
        Console.WriteLine($"Are you doing okay");


    }

    public static string GetUserName()
    {
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        return name;

    }

    public static (string, string) GetFullName()
    {
        Console.WriteLine("What is your First Name?");
        string? firstName = Console.ReadLine();

        Console.WriteLine("What is your LastName Name?");
        string? lastName = Console.ReadLine();

        return (firstName, lastName);
    }

    public static void SayGoodbye()
    {
        Console.WriteLine($"Goodbye user");
        Console.WriteLine($"Thank you for visiting");


    }
}

