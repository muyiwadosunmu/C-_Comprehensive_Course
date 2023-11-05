
namespace DemoLibrary
{
    public class Person
    {
        protected string? _formerLastName = "";
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }



        private string? _ssn;
        public string SSN
        {
            get { return $"_ssn.Substring(_ssn.Length -4)"; }
            set { _ssn = value; }
        }

        public void ChangeLastName(string newLastName)
        {
            _formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string? conn = data.GetConnectionString();
        }
    }
}