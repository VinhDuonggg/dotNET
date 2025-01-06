using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Controllers;

namespace VideoGameManagement.Framework;

internal class Router
{
    static GameController gameController = new();
    static MainController mainController = new();
    public static void Forward(string route)
    {
        switch (route.ToLower())
        {
            case "help":
                mainController.Help();
                break;
            case "clear":
                mainController.Clear();
                break;
            case "list":
                gameController.ListGames();
                break;
            case "single":
                gameController.SingleGame(route);
                break;
            default:
                Console.WriteLine("Command not found");
                break;
        }
    }
}
