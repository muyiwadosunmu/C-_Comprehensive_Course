namespace ConsoleUI;

public class Program
{
    public static void Main(string[] args)
    {
        string? name = "";
        try
        {
            DifferentMethod();
            Console.WriteLine($"What is your name?: ");
            name = Console.ReadLine();
            ComplexMethod(name);
            SimpleMethod();

        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("You should not be calling these methods");
            Console.WriteLine(ex.Message);


        }

        catch (NotImplementedException)
        {
            Console.WriteLine("You forgot to finish your code");

        }
        catch (Exception ex) when (name.ToLower() == "muyiwa")
        {
            Console.WriteLine(ex);
            Console.WriteLine("You used Muyiwa's name, didn't you");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            // Console.WriteLine(ex.Message);
        }

        finally
        {
            Console.WriteLine("I always run");

        }

    }

    private static void ComplexMethod(string name)
    {
        if (name.ToLower() == "muyiwa")
        {
            throw new InsufficientMemoryException("Muyiwa is too big for this method");
        }
        else
        {
            throw new ArgumentException($"This person, {name} isn't muyiwa");
        }
    }
    private static void SimpleMethod()
    {
        throw new InvalidOperationException("You shaould not be calling the SimpleMethod");
    }

    private static void DifferentMethod()
    {
        Console.WriteLine($"This is the different method working properly");
    }

}