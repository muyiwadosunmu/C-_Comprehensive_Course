using DemoLibrary;

namespace AccessModifierDemo;

class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        // DataAccess data = new DataAccess();

        person.SavePerson();

        Console.ReadLine();
    }
}
