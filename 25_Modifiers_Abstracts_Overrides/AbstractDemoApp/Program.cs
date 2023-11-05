using AbstractClassDemo;

namespace AbstractClassDemo;


class Program
{
    static void Main(string[] args)
    {
        InventoryItem book1 = new Book();
        Vehicle car = new Car();
        car.
        Console.ReadLine();

    }
}


public class Book : InventoryItem
{

}

public abstract class Vehicle : InventoryItem
{
    public string? VIN { get; set; }
    public string? Manufacturer { get; set; }
    public int YearManufactured { get; set; }
}



public class Car : Vehicle
{
    public int NumberOfWheels { get; set; }


}