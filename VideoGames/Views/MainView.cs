using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameManagement.Views;

internal class MainView
{
    public void HelpView()
    {
        Console.WriteLine("-- HELP --");
        Console.WriteLine("List - Show the list of video games");
        Console.WriteLine("Single - Show the detail of a game");
        Console.WriteLine("Clear - Clear the console");
        Console.WriteLine("Help - Show the list of commands");
    }
    public void ClearView()
    {
        Console.Clear();
    }
}
