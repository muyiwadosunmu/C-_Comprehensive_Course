namespace ConsoleUI;


class Program
{
    static void Main(string[] args)
    {

        string? firstName = RequestData.GetAString("What is your first name");

        UserMessages.ApplicationStartMessage(firstName);

        double x = RequestData.GetADouble("Please Enter your first Number: ");
        double y = RequestData.GetADouble("Please Enter your second Number: ");

        double result = CalculateData.Add(x, y);
        UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");

    }


}