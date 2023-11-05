// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to using List!");

//string[] firstNames = new string[5];
List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");
firstNames.Add("Frank");

Console.WriteLine(firstNames[1]);
Console.WriteLine(firstNames.Count - 1);


List<int> ages = new List<int> { };
ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);
ages.Add(5);
Console.WriteLine(ages);

//List<T> -- Generic
string data = "Corey, Smith, Jonas";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");
Console.WriteLine(lastNames);



