using System.Diagnostics;
using GuestBookLibrary.Models;

namespace ConsoleUII;

public class Program
{
    private static List<GuestModel> guests = new List<GuestModel>();
    static void Main(string[] args)
    {

        GetGuestInfo();



        Console.ReadLine();
    }

    private static void GetGuestInfo()
    {
        string? moreGuestComing = "";

        do
        {
            GuestModel guest = new GuestModel();

            guest.FirstName = GetInfoFromConsole("What is your first name?: ");

            guest.LastName = GetInfoFromConsole("What is your last name?: ");


            guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host?: ");

            moreGuestComing = GetInfoFromConsole("Are more guest coming? (yes/no) ");

            guests.Add(guest);

            Console.Clear();
        } while (moreGuestComing.ToLower() == "yes");
    }

    private static void PrintGuestInfo()
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);

        }
    }

    private static string GetInfoFromConsole(string message)
    {
        string? output;
        Console.Write(message);
        output = Console.ReadLine();
        return output;
    }
};