namespace BankApp;

public class UserAccount
{
    public string Username { get; }
    public string Email { get; }
    public string AccountNumber { get; }
    public decimal Balance { get; set; }

    public UserAccount(string username, string email, string accountNumber)
    {
        Username = username;
        Email = email;
        AccountNumber = accountNumber;
        Balance = 0;
    }
}

