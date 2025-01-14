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
        var command = route.Split("?")[0].ToLower();
        switch (command.ToLower())
        {
            case "help":
                mainController.Help();
                break;
            case "add":
                gameController.AddGame();
                break;
            case "add_confirm":
                var add = Params(route);
                gameController.AddGameConfirm(add["name"], add["genre"], int.Parse(add["year"]), add["description"]);
                break;
            case "clear":
                mainController.Clear();
                break;
            case "list":
                gameController.ListGames();
                break;
            case "single":
                var dict = Params(route);
                gameController.SingleGame(dict["name"]);
                break;
            default:
                mainController.Error();
                break;
            case "delete":
                mainController.Delete();
                break;
            case "delete_confirm":
                var del = Params(route);
                gameController.DeleteGame(del["name"]);
                break;
        }
    }
    static Dictionary<string, string> Params(string query)
    {
        var dict = new Dictionary<string, string>();
        var items = query.Split("?");
        var pairs = items[1].Split("&");
        foreach (var pair in pairs)
        {
            var keyValues = pair.Split('=');
            dict.Add(keyValues[0], keyValues[1]);
        }
        return dict;
    }
}
