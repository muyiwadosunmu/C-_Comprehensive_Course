

string name;
do
{
    Console.Write("What is your name: ");
    name = Console.ReadLine();
    if (name == "Tim" || name == "tim")
    {
        Console.WriteLine($"Welcome, Professor {name}");
    }
    else
    {
        Console.WriteLine($"Welcome , student {name}");
    }
} while (name != "exit")