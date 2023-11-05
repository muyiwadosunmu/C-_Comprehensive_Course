namespace InterfaceDemo;


/**
Interfaces is a contract
Classes implements interfaces
**/
class Program
{
    static void Main(string[] args)
    {
        // The power of interfaces helps us to achieve this
        List<IComputerController> controllers = new List<IComputerController>();
        Keyboard keyboard = new Keyboard();
        GameController gameController = new GameController();
        BatteryPoweredGameController battery = new BatteryPoweredGameController();
        BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

        controllers.Add(keyboard);
        controllers.Add(gameController);
        controllers.Add(battery);



        foreach (IComputerController controller in controllers)
        {
            // A trick we used in our inheritances
            if (controller is GameController gc)
            {

            }

            if (controller is IBatteryPowered powered)
            {

            }

        }

        //The IDisposable interface helps to achieve this snippet below
        using (GameController dc = new GameController())
        {

        }

        List<IBatteryPowered> powereds = new List<IBatteryPowered>();

        powereds.Add(battery);
        powereds.Add(batteryKeyboard);


        Console.ReadLine();

    }
}
public interface IComputerController : IDisposable
{
    void Connect() { }
    void CurrentKeyPressed() { }
}

public interface IBatteryPowered
{
    int BatteryLevel { get; set; }
}

public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
{
    public int BatteryLevel { get; set; }
}

public class Keyboard : IComputerController
{
    public void Connect()
    {

    }
    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public string? ConnectionType { get; set; }


}


public class GameController : IComputerController, IDisposable
{
    public void Connect() { }

    public void CurrentKeyPressed() { }

    public void Dispose()
    {
        // do whatever shutdown tasks needed
    }


}


public class BatteryPoweredGameController : GameController, IBatteryPowered
{
    public int BatteryLevel { get; set; }

}