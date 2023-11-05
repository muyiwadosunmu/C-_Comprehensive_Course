using BattleshipLibrary;
using BattleshipLibrary.Models;

namespace BattleshipLite;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMesssage();

        PlayerInfoModel player1 = CreatePlayer("Player 1");
        PlayerInfoModel player2 = CreatePlayer("Player 2");
        PlayerInfoModel winner = null;

        do
        {
            // Display grid from player 1 on where they fired
            // Ask player 1 for a shot
            // Determine if it is a valid short
            // Determine if the game is over
            //if over , set player1 as the winner 
            // else , go to player 2
        } while (winner == null);

        Console.ReadLine();

    }

    private static void WelcomeMesssage()
    {
        Console.WriteLine("Welcome to Battleship Lite");
        Console.WriteLine("Created By struct.io");


    }

    private static PlayerInfoModel CreatePlayer(string playerTitle)
    {
        PlayerInfoModel output = new PlayerInfoModel();

        Console.WriteLine($"Player Information for {playerTitle}");
        // Ask the user for their name
        output.UsersName = AskForUsersName();

        //Load up the shot grid
        GameLogic.InitializeGrid(output);

        // Ask the user for their 5  ship placement
        PlaceShips(output);
        //clear the screen
        Console.Clear();

        return output;

    }

    private static string AskForUsersName()
    {

        Console.WriteLine("What is your name?: ");
        string? output = Console.ReadLine();
        return output;
    }

    private static void PlaceShips(PlayerInfoModel model)
    {
        do
        {
            Console.WriteLine($"Where do you want to place ship number {model.ShipLocations.Count + 1}:  ");
            string? location = Console.ReadLine();

            bool isValidLocation = GameLogic.PlaceShip(model, location);

            if (isValidLocation == false)
            {
                Console.WriteLine($"That was not a valid location, please try again");

            }

        } while (model.ShipLocations.Count < 5);
    }
}