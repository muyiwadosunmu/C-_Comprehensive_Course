namespace Methods;

public static class MathShortcuts
{
    public static double Add(double x, double y)
    {
        // Console.WriteLine($"The value of {x} + {y} = {x + y}");
        double output = x + y;
        return output;

    }
    public static void AddAll(double[] values)
    {
        double result = 0;
        foreach (double value in values)
        {
            result += value;
        }
        // Console.WriteLine($"Addition of these numbers will give {result}");

    }
    public static void Subtract(double x, double y)
    {
        Console.WriteLine($"The value of {x} - {y} = {x - y}");
    }

    public static void Multiply(double x, double y)
    {
        Console.WriteLine($"The value of {x} * {y} = {x * y}");
    }

    public static void Divide(double x, double y)
    {
        Console.WriteLine($"The value of {x} / {y} = {x / y}");
    }
}