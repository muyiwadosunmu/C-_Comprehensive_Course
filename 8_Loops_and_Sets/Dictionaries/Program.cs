

Console.WriteLine($"Welcome to a Dictionary");

Dictionary<int, string> lookUp = new Dictionary<int, string>();

lookUp[1] = " Not a Human";
lookUp[2] = "Not a human that swims";
lookUp[3] = "Us";

Console.WriteLine($"The definition of fish is {lookUp[1]}");
Console.WriteLine(lookUp);

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;
Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]} days");






