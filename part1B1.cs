namespace part1B1
{
    using System;
    using System.Collections.Generic;

    class VideoGame
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int YearOfProduction { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nGenre: {Genre}\nYear of Production: {YearOfProduction}\nDescription: {Description}\n";
        }
    }

    class part1B1
    {
        static List<VideoGame> games = new List<VideoGame>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\nVideo Game Management System");
                Console.WriteLine("1. Add a New Game");
                Console.WriteLine("2. Display All Games");
                Console.WriteLine("3. Remove a Game");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddGame();
                        break;
                    case 2:
                        DisplayGames();
                        break;
                    case 3:
                        RemoveGame();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);
        }

        static void AddGame()
        {
            Console.WriteLine("\nAdd a New Game");

            Console.Write("Enter the game name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter the year of production: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter a brief description: ");
            string description = Console.ReadLine();

            games.Add(new VideoGame
            {
                Name = name,
                Genre = genre,
                YearOfProduction = year,
                Description = description
            });

            Console.WriteLine("Game added successfully!");
        }

        static void DisplayGames()
        {
            Console.WriteLine("\nList of All Games");

            if (games.Count == 0)
            {
                Console.WriteLine("No games found.");
                return;
            }

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }

        static void RemoveGame()
        {
            Console.WriteLine("\nRemove a Game");

            if (games.Count == 0)
            {
                Console.WriteLine("No games to remove.");
                return;
            }

            Console.Write("Enter the name of the game to remove: ");
            string name = Console.ReadLine();

            var gameToRemove = games.Find(game => game.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (gameToRemove != null)
            {
                games.Remove(gameToRemove);
                Console.WriteLine("Game removed successfully!");
            }
            else
            {
                Console.WriteLine("Game not found.");
            }
        }
    }
}


