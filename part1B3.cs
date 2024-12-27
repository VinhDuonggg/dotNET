namespace part1B3
{
    using System;
    using System.Collections.Generic;

    class Property
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int YearOfAcquisition { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price:C}\nYear of Acquisition: {YearOfAcquisition}\nStatus: {Status}\n";
        }
    }

    class part1B3
    {
        static List<Property> properties = new List<Property>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\nProperty Management System");
                Console.WriteLine("1. Add a New Property");
                Console.WriteLine("2. Display All Properties");
                Console.WriteLine("3. Remove a Property");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProperty();
                        break;
                    case 2:
                        DisplayProperties();
                        break;
                    case 3:
                        RemoveProperty();
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

        static void AddProperty()
        {
            Console.WriteLine("\nAdd a New Property");

            Console.Write("Enter the property name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the year of acquisition: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the status : ");
            string status = Console.ReadLine();

            properties.Add(new Property
            {
                Name = name,
                Price = price,
                YearOfAcquisition = year,
                Status = status
            });

            Console.WriteLine("Property added successfully!");
        }

        static void DisplayProperties()
        {
            Console.WriteLine("\nList of All Properties");

            if (properties.Count == 0)
            {
                Console.WriteLine("No properties found.");
                return;
            }

            foreach (var property in properties)
            {
                Console.WriteLine(property);
            }
        }

        static void RemoveProperty()
        {
            Console.WriteLine("\nRemove a Property");

            if (properties.Count == 0)
            {
                Console.WriteLine("No properties to remove.");
                return;
            }

            Console.Write("Enter the name of the property to remove: ");
            string name = Console.ReadLine();

            var propertyToRemove = properties.Find(property => property.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (propertyToRemove != null)
            {
                properties.Remove(propertyToRemove);
                Console.WriteLine("Property removed successfully!");
            }
            else
            {
                Console.WriteLine("Property not found.");
            }
        }
    }

}
