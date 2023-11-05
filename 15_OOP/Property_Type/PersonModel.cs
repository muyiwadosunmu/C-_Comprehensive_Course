namespace ConsoleUI;


public class PersonModel
{

    public string? FirstName { private get; set; }
    public string? LastName { get; private set; }
    // public int Age { get; set; }

    private string? _password;
    public string Password
    {
        set { _password = value; }
    }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }


    private int _age; //private backing field Do not manipulate directly
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 0 && value < 126)
            {
                _age = value;

            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Age needs to be in a valid range");
            }
        }
    }

    private string? _ssn;
    public string? SSN
    {
        get
        {
            // 123-45-6789 => 11 -4 =7;
            string output = "***-***" + _ssn?.Substring(_ssn.Length - 4);
            return output;
        }
        set
        {
            _ssn = value;
        }
    }
    public PersonModel()
    {

    }

    public PersonModel(string lastName)
    {
        LastName = lastName;
    }
}