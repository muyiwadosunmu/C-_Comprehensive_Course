
namespace ConsoleUI;

public class RequestData
{


    public static string GetAString(string message)
    {
        Console.Write(message);
        string? output = Console.ReadLine();
        return output;


    }
    public static double GetADouble(string message)
    {
        double output;
        Console.WriteLine(message);
        string? numberText = Console.ReadLine();

        bool isDouble = double.TryParse(numberText, out output);

        while (isDouble == false)
        {
            Console.WriteLine($"That was not a valid number, please try agaain");
            Console.WriteLine(message);
            numberText = Console.ReadLine();

            isDouble = double.TryParse(numberText, out output);


        }
        return output;

    }

}
