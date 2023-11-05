namespace MethodOverload;

class Program
{
    static void Main(string[] ars)
    {
        var person = new PersonModel("Muyiwa", "Dosunmu");
        person.GenerateEmail()
        Console.ReadLine();

    }
}


public class PersonModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public PersonModel()
    {

    }

    public PersonModel(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public PersonModel(string? firstName, string? lastName, string? email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public void GenerateEmail()
    {
        Email = $"{FirstName}.{LastName}@aol.com";
    }

    public void GenerateEmail(string domain)
    {
        Email = $"{FirstName}.{LastName}@{domain}";
    }

    public void GenerateEmail(string domain, bool firstInitialMethod)
    {
        if (firstInitialMethod == true)
        {
            Email = $"{FirstName?.Substring(0, 1)}.{LastName}@{domain}";
        }
        else
        {
            Email = $"{FirstName}.{LastName}@aol.com";
        }
    }
}