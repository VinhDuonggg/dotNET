using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Framework;
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
    public void addGameView()
    {
        Console.WriteLine("Enter the name of the game: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the genre of the game: ");
        string genre = Console.ReadLine();
        Console.WriteLine("Enter the year of the game: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the description of the game: ");
        string description = Console.ReadLine();
        Router.Forward($"add_confirm?name={name}&genre={genre}&year={year}&description={description}");
    }
}



