using Methods;


string? name = SampleMethods.GetUserName();
SampleMethods.SayHi(name);

SampleMethods.SayGoodbye();

double sum = MathShortcuts.Add(5.0, 6.8);
Console.WriteLine($"{sum}");

MathShortcuts.Subtract(5.0, 6.8);
MathShortcuts.Multiply(5.0, 6.8);
MathShortcuts.Divide(5.0, 6.8);

double[] vals = new double[] { 3.5, 6.23, 98, 52, 39 };
MathShortcuts.AddAll(vals);


// Discard Character (_) -> We don't care about it
// (string firstName, _) = SampleMethods.GetFullName();
// (string firstName, string lastName) fullName = SampleMethods.GetFullName();
(string firstName, string lastName) = SampleMethods.GetFullName();

// var fullName = SampleMethods.GetFullName(); --> using var is like using a shortcut
Console.WriteLine($"Firstname: {firstName}");
Console.WriteLine($"Lastname: {lastName}");






/**
DRY -> Don't Repeat Yourself
SOLID -> 
    S -> Single Responsibility Principle
    O -> /
**/

