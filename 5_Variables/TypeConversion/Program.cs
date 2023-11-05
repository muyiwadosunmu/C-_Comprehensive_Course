
string? ageText;
Console.Write("What is your age: ");
ageText = Console.ReadLine();

// int age = int.Parse(ageText);
/*We needed to use the below one for mre like error handling*/
int age;
bool isValidInt = int.TryParse(ageText, out age);

Console.WriteLine(isValidInt);

if (isValidInt)
{
    Console.WriteLine(age);
}


Console.WriteLine(age + 15);


double testDouble = age;
decimal testDecimal = (decimal)testDouble;
