using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Framework;

namespace VideoGameManagement.Views;

internal class MainView
{
    public void HelpView()
    {
        Console.WriteLine("-- HELP --");
        Console.WriteLine("Add - Add a new video game");
        Console.WriteLine("List - Show the list of video games");
        Console.WriteLine("Single - Show the detail of a game");
        Console.WriteLine("Clear - Clear the console");
        Console.WriteLine("Delete - Delete a game");
        Console.WriteLine("Help - Show the list of commands");
    }
    public void ClearView()
    {
        Console.Clear();
    }
    public void ErrorView()
    {
        Console.WriteLine("Invalid command");
    }
    public void DeleteView()
    {
        Console.WriteLine("Enter the name of the game you want to delete: ");
        var name = Console.ReadLine();
        Console.WriteLine("Do you really want to delete this game(yes/no): ");
        var answer = Console.ReadLine();
        if (answer == "yes")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game deleted");
            Router.Forward($"delete_confirm?name={name}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game not deleted");
            Console.ResetColor();
        }
    }
}
