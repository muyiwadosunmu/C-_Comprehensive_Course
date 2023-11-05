namespace BankApp;

public class Program
{
    static List<UserAccount> userAccounts = new List<UserAccount>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the ATM machine!");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Transfer Money");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        BankAppOps.CreateAccount(userAccounts);
                        break;
                    case 2:
                        BankAppOps.DepositMoney(userAccounts);
                        break;
                    case 3:
                        BankAppOps.TransferMoney(userAccounts);
                        break;
                    case 4:
                        Console.WriteLine("Exiting the ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine();
        }
    }
}
