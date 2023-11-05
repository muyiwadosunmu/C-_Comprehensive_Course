// Console.WriteLine("Welcome To Arrays");
// /**
// 0 based counting
// */
// string[] firstNames = new string[5]; //This variable holds five strinfs
// firstNames[0] = "Tim";
// firstNames[1] = "Sue";
// firstNames[2] = "Bob";
// firstNames[4] = "Jane";

// Console.WriteLine($"The firstnames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

// firstNames[0] = "Timothy";
// Console.WriteLine($"{firstNames[0]}");


// single quote identifies a character --> it's a little more efficient
// double quote identifies a string value
string data = "Tim, Sue, Bob, Jane, Frank";
string[] firstNames = data.Split(',');
Console.WriteLine(data);
Console.WriteLine(firstNames[firstNames.Length - 1]);

firstNames.Length;
Console.WriteLine($"{firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}");

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };
int[] ages = new int[] { 1, 2, 3, 4, 5 };
float[] weight = new float[] { 21.0, 32.67, };
