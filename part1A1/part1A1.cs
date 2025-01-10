namespace part1A1
{
    using System;

    class part1A1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value for n:");
            int n = int.Parse(Console.ReadLine());

            double S1 = CalculateS1(n);
            double S2 = CalculateS2(n);
            double S5 = CalculateS5(n);
            double S6 = CalculateS6(n);
            double S7 = CalculateS7(n);

            Console.WriteLine($"S1 = {S1}");
            Console.WriteLine($"S2 = {S2}");
            Console.WriteLine($"S5 = {S5}");
            Console.WriteLine($"S6 = {S6}");
            Console.WriteLine($"S7 = {S7}");
        }

        static double CalculateS1(int n)
        {
            double sum = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum -= Math.Pow(-1, i + 1) / (1.0 + Math.Pow(i, 2));
            }
            return sum;
        }

        static double CalculateS2(int n)
        {
            double sum = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-2, i) / Factorial(i);
            }
            return sum;
        }

        static double CalculateS5(int n)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i + 1) / (2.0 * i);
            }
            return sum;
        }

        static double CalculateS6(int n)
        {
            double sum = 1.0;
            double denominator = 0.0;
            for (int i = 1; i <= n; i++)
            {
                denominator += i;
                sum += Math.Pow(-1, i + 1) / denominator;
            }
            return sum;
        }

        static double CalculateS7(int n)
        {
            double sum = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(2, i) / Factorial(i);
            }
            return sum;
        }

        static double Factorial(int num)
        {
            double result = 1.0;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}
