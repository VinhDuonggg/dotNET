namespace part1A2
{
    using System;

    class part1A2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter epsilon (accuracy):");
            double epsilon = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x for sin(x) and cos(x) calculations:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x for ln(1+x) calculation (x > -1):");
            double lnX = double.Parse(Console.ReadLine());

            double piApproximation = ApproximatePi(epsilon);
            double sinApproximation = ApproximateSin(x, epsilon);
            double lnApproximation = ApproximateLn(lnX, epsilon);
            double cosApproximation = ApproximateCos(x, epsilon);

            Console.WriteLine($"\nApproximations:");
            Console.WriteLine($"Pi = {piApproximation}");
            Console.WriteLine($"sin({x}) = {sinApproximation}");
            Console.WriteLine($"ln(1 + {lnX}) = {lnApproximation}");
            Console.WriteLine($"cos({x}) = {cosApproximation}");
        }

        static double ApproximatePi(double epsilon)
        {
            double piOver4 = 0;
            double term;
            int n = 0;

            do
            {
                term = Math.Pow(-1, n) / (2 * n + 1);
                piOver4 += term;
                n++;
            } while (Math.Abs(term) > epsilon);

            return 4 * piOver4;
        }

        static double ApproximateSin(double x, double epsilon)
        {
            double sin = 0;
            double term = x; // First term in the series
            int n = 1;

            while (Math.Abs(term) > epsilon)
            {
                sin += term;
                n++;
                term = Math.Pow(-1, n - 1) * Math.Pow(x, 2 * n - 1) / Factorial(2 * n - 1);
            }

            return sin;
        }

        static double ApproximateLn(double x, double epsilon)
        {
            if (x <= -1)
            {
                throw new ArgumentException("x must be greater than -1 for ln(1 + x) calculation.");
            }

            double ln = 0;
            double term = x;
            int n = 1;

            while (Math.Abs(term) > epsilon)
            {
                ln += term;
                n++;
                term = Math.Pow(-1, n - 1) * Math.Pow(x, n) / n;
            }

            return ln;
        }

        static double ApproximateCos(double x, double epsilon)
        {
            double cos = 1; // First term in the series
            double term = 1;
            int n = 1;

            while (Math.Abs(term) > epsilon)
            {
                term = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
                cos += term;
                n++;
            }

            return cos;
        }

        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

