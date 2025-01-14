using System;
using VideoGameManagement.Models;
using VideoGameManagement.Views;
using VideoGameManagement.Repositories;
using VideoGameManagement.Controllers;
using VideoGameManagement.Framework;
using System.Diagnostics.Metrics;
namespace VideoGameManagement;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- VIDEO GAME MANAGEMENT --");

        //BookControllers bookControllers = new();
        //MainController mainController = new();

        while (true)
        {
            Console.WriteLine(">>>");
            var route = Console.ReadLine();
            Router.Forward(route);
        }
    }
}
