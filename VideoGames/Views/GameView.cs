using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Models;

namespace VideoGameManagement.Views;
internal class GameView
{
    public void ListView(Game[] model)
    {
        foreach (var b in model)
        {
            Console.WriteLine($"Name: {b.Name}");
            Console.WriteLine($"Genre: {b.Genre}");
            Console.WriteLine($"Year: {b.Year}");
            Console.WriteLine($"Description: {b.Description}");
        }
    }
    public void SingleView(Game model)
    {
        Console.WriteLine($"Name: {model.Name}");
        Console.WriteLine($"Genre: {model.Genre}");
        Console.WriteLine($"Year: {model.Year}");
        Console.WriteLine($"Description: {model.Description}");
    }
}



