// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to ForEach Loop");

string data = "Tim, Sue, Bob, Jane";
List<string> firstNames = data.Split(',').ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);

}


