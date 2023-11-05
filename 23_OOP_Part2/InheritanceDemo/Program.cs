namespace InheritanceDemo;


class Program
{
    public static void Main(string[] args)
    {
        //    Phone phone = new SmartPhone(); --> This could be useful
        List<Phone> phones = new();
        phones.Add(new SmartPhone());
        phones.Add(new CellPhone());

        /**Though ther's a performance penalty for this ut it's not huge but it;s there */
        foreach (var phone in phones)
        {
            if (phone is CellPhone cell)
            {
                cell.Carrier = "";
            }
            if (phone is SmartPhone smartPhone)
            {
                smartPhone.ConnectToInternet();
            }
        }

        Console.ReadLine();
    }

}
