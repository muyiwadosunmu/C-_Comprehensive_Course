namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            List<PersonModel> people = new List<PersonModel>();
            PersonModel person = new PersonModel();

            person.firstName = "Muyiwa";

            people.Add(person);

            person = new PersonModel();

            person.firstName = "Tommy";

            people.Add(person);

            foreach (PersonModel p in people)
            {
                Console.WriteLine(p.firstName);

            }
            */
            List<PersonModel> people = new();
            string? firstName;

            do
            {
                Console.WriteLine("What is your first Name (or type exit to stop)");
                firstName = Console.ReadLine();

                Console.WriteLine("What is your last Name (or type exit to stop)");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }

            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
                ProcessPerson.GreetPerson(p);
            }

        }
    }

}
