namespace part1B4
{
    using System;
    using System.Collections.Generic;

    class Movie
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int YearOfProduction { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nLength: {Length} minutes\nYear of Production: {YearOfProduction}\nDescription: {Description}\n";
        }
    }

    class part1B4
    {
        static List<Movie> movies = new List<Movie>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\nMovie Management System");
                Console.WriteLine("1. Add a New Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Remove a Movie");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        DisplayMovies();
                        break;
                    case 3:
                        RemoveMovie();
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

        static void AddMovie()
        {
            Console.WriteLine("\nAdd a New Movie");

            Console.Write("Enter the movie name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the length of the movie (in minutes): ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the year of production: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter a brief description of the movie: ");
            string description = Console.ReadLine();

            movies.Add(new Movie
            {
                Name = name,
                Length = length,
                YearOfProduction = year,
                Description = description
            });

            Console.WriteLine("Movie added successfully!");
        }

        static void DisplayMovies()
        {
            Console.WriteLine("\nList of All Movies");

            if (movies.Count == 0)
            {
                Console.WriteLine("No movies found.");
                return;
            }

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }

        static void RemoveMovie()
        {
            Console.WriteLine("\nRemove a Movie");

            if (movies.Count == 0)
            {
                Console.WriteLine("No movies to remove.");
                return;
            }

            Console.Write("Enter the name of the movie to remove: ");
            string name = Console.ReadLine();

            var movieToRemove = movies.Find(movie => movie.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (movieToRemove != null)
            {
                movies.Remove(movieToRemove);
                Console.WriteLine("Movie removed successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }
    }

}
