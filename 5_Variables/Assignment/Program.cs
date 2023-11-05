string? input;
int alphabetCount;
int numberCount;
int symbolCount;
string? rearrangedAlphabets;
int[] numbers;

while (true)
{
    Console.WriteLine("Enter a string (min 6, max 500 characters):");
    input = Console.ReadLine();

    if (input.Length >= 6 && input.Length <= 500)
    {
        break;
    }

    Console.WriteLine("Input length must be between 6 and 500 characters.");
}

/* Alphabet Count logic*/
alphabetCount = input.Count(char.IsLetter);
numberCount = input.Count(char.IsDigit);
symbolCount = input.Count(c => !char.IsLetterOrDigit(c));

Console.WriteLine($"Number of alphabets: {alphabetCount}");
Console.WriteLine($"Number of Numbers: {numberCount}");
Console.WriteLine($"Number of Symbols: {symbolCount}");

// Rearrange alphabets in ascending order
rearrangedAlphabets = string.Join("", input.Where(char.IsLetter).OrderBy(c => c));
Console.WriteLine($"Rearranged alphabets: {rearrangedAlphabets}");

// Rearrange numbers in ascending order starting from 1
numbers = input.Where(char.IsDigit).Select(c => int.Parse(c.ToString())).OrderBy(x => x).ToArray();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

Console.WriteLine($"Rearranged numbers: {string.Join("", numbers)}");

// Calculate sums and perform the final calculation
int sumAlphabets = alphabetCount;
int sumNumbers = numbers.Sum();
int sumSymbols = symbolCount;
double result = (sumAlphabets + sumNumbers + sumSymbols) / 2.0;

Console.WriteLine($"Sum of alphabets: {sumAlphabets}");
Console.WriteLine($"Sum of numbers: {sumNumbers}");
Console.WriteLine($"Sum of symbols: {sumSymbols}");
Console.WriteLine($"Result: {result}");
