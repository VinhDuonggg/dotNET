namespace part1B2
{
    using System;
    using System.Collections.Generic;

    class Course
    {
        public string Name { get; set; }
        public int Credit { get; set; }
        public string Description { get; set; }
        public string Semester { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nCredit: {Credit}\nDescription: {Description}\nSemester: {Semester}\n";
        }
    }

    class part1B2
    {
        static List<Course> courses = new List<Course>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\nCourse Management System");
                Console.WriteLine("1. Add a New Course");
                Console.WriteLine("2. Display All Courses");
                Console.WriteLine("3. Remove a Course");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCourse();
                        break;
                    case 2:
                        DisplayCourses();
                        break;
                    case 3:
                        RemoveCourse();
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

        static void AddCourse()
        {
            Console.WriteLine("\nAdd a New Course");

            Console.Write("Enter the course name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of credits: ");
            int credit = int.Parse(Console.ReadLine());

            Console.Write("Enter a brief description of the course: ");
            string description = Console.ReadLine();

            Console.Write("Enter the semester (e.g., Spring, Fall): ");
            string semester = Console.ReadLine();

            courses.Add(new Course
            {
                Name = name,
                Credit = credit,
                Description = description,
                Semester = semester
            });

            Console.WriteLine("Course added successfully!");
        }

        static void DisplayCourses()
        {
            Console.WriteLine("\nList of All Courses");

            if (courses.Count == 0)
            {
                Console.WriteLine("No courses found.");
                return;
            }

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }

        static void RemoveCourse()
        {
            Console.WriteLine("\nRemove a Course");

            if (courses.Count == 0)
            {
                Console.WriteLine("No courses to remove.");
                return;
            }

            Console.Write("Enter the name of the course to remove: ");
            string name = Console.ReadLine();

            var courseToRemove = courses.Find(course => course.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
                Console.WriteLine("Course removed successfully!");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }
    }

}
