
string? name;
double price;
double vatRate = 7.5;

Console.WriteLine("Welcome to Muyiwa's VAT Calculator");
Console.WriteLine($"The VAT is presently at 7.5%");

Console.WriteLine($"What is your name");
name = Console.ReadLine();



Console.Write($"{name},  Enter the price of product you purchased: ");

if (double.TryParse(Console.ReadLine(), out price))
{
    double taxAmount = (price * vatRate) / 100;

    Console.WriteLine($"Hi {name}, you purchased a product worth #{price}.00 ");
    Console.WriteLine($"Your Value Added Tax is #{taxAmount}.00");

}

else
{
    Console.WriteLine($"Invalid Input, Please enter a valid amount");

}
