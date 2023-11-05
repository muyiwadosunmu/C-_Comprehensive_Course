namespace ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            BadCall();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"There was an exception thrown in our app");
            Console.WriteLine(ex.Message);


        }

    }

    private static void BadCall()
    {
        int[] ages = new int[] { 1, 3, 5 };

        for (int i = 0; i <= ages.Length; i++)
        {
            try
            {
                Console.WriteLine(ages[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We had an error");
                Console.WriteLine($"{ex.Message}"); //Might be good for a user
                // Console.WriteLine($"{ex}");
                // throw; //using throe helps don't use throe ex;
                throw new Exception("There was an error handling the excepion", ex); //Used fo preserve stack trace and line numbers
            }

        }
    }

}




