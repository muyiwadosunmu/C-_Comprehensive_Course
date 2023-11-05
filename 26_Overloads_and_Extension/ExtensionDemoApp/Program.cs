namespace ExtensionMethodDemo;


class Program
{
    static void Main(string[] args)
    {
        "Hello World".PrintToConsole();

        HotelRoomModel room = new HotelRoomModel();
        /*This is known as fluent design*/
        room.TurnOnAir().SetTemperature(72).OpenShades();

        room.TurnOffAir().CloseShades();

        Console.ReadLine();
    }


}

public class HotelRoomModel
{
    public int Temperature { get; set; }
    public bool isAirRunning { get; set; }
    public bool AreShadeOpen { get; set; }
}
public static class ExtensionSamples
{
    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }

    public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
    {
        room.isAirRunning = true;
        return room;
    }

    public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
    {
        room.isAirRunning = false;
        return room;
    }

    public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
    {
        room.Temperature = temperature;
        return room;
    }

    public static HotelRoomModel OpenShades(this HotelRoomModel room)
    {
        room.AreShadeOpen = true;
        return room;
    }

    public static HotelRoomModel CloseShades(this HotelRoomModel room)
    {
        room.AreShadeOpen = false;
        return room;
    }
}

