
namespace BankApp;
public class BankAppOps
{
    public static void CreateAccount(List<UserAccount> userAccounts)
    {
        Console.Write("Enter a username: ");
        string? username = Console.ReadLine();

        Console.Write("Enter an email: ");
        string? email = Console.ReadLine();

        // Generate a random account number
        Random random = new Random();
        string? accountNumber = random.Next(10000, 99999).ToString();

        UserAccount? newAccount = new UserAccount(username, email, accountNumber);
        userAccounts.Add(newAccount);

        Console.WriteLine($"Account created successfully. Your account number is: {accountNumber}");
    }

    public static void DepositMoney(List<UserAccount> userAccounts)
    {
        Console.Write("Enter your account number: ");
        string? accountNumber = Console.ReadLine();

        UserAccount? user = userAccounts.FirstOrDefault(u => u.AccountNumber == accountNumber);

        if (user != null)
        {
            Console.Write("Enter the amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                user.Balance += amount;
                Console.WriteLine($"Deposited {amount:C} successfully. Your new balance is: {user.Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid positive number.");
            }
        }
        else
        {
            Console.WriteLine("Account not found. Please check your account number.");
        }
    }

    public static void TransferMoney(List<UserAccount> userAccounts)
    {
        Console.Write("Enter your account number: ");
        string? sourceAccountNumber = Console.ReadLine();

        UserAccount? sourceUser = userAccounts.FirstOrDefault(u => u.AccountNumber == sourceAccountNumber);

        if (sourceUser != null)
        {
            Console.Write("Enter the recipient's account number: ");
            string? targetAccountNumber = Console.ReadLine();

            UserAccount? targetUser = userAccounts.FirstOrDefault(u => u.AccountNumber == targetAccountNumber);

            if (targetUser != null)
            {
                Console.Write("Enter the amount to transfer: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                {
                    if (sourceUser.Balance >= amount)
                    {
                        sourceUser.Balance -= amount;
                        targetUser.Balance += amount;
                        Console.WriteLine($"Transferred {amount:C} successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance to make the transfer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a valid positive number.");
                }
            }
            else
            {
                Console.WriteLine("Recipient's account not found. Please check the account number.");
            }
        }
        else
        {
            Console.WriteLine("Account not found. Please check your account number.");
        }
    }
}

