namespace ConsoleUI;

public class Program
{
    public static void Main(string[] args)
    {
        PersonModel person = new("Dosunmu")
        {
            FirstName = "Muyiwa",
            // LastName = "Dosunmu",
            Age = 25,
            SSN = "123-45-678-910"
        };

        Console.WriteLine(person.SSN);
        Console.WriteLine(person.FullName);

    }
}