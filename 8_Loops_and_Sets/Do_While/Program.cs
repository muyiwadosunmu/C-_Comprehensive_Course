

bool isValidAge;
int age;
do
{
    Console.WriteLine($"What is your age?: ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);
    if (isValidAge == false)
    {
        Console.WriteLine($"That is an invalid age");

    }

} while (isValidAge == false);

Console.WriteLine($"Your age is {age}");
