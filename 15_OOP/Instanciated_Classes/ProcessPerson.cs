namespace ConsoleUI;

public static class ProcessPerson
{
    public static void GreetPerson(PersonModel person)
    {
        Console.WriteLine($" Hello {person.FirstName} {person.LastName}");
        person.HasBeenGreeted = true;


    }
}