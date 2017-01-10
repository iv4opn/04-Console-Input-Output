using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter the coefficients 'a', 'b', 'c', 'a' must be different from zero:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x,x1,x2 = 0;
            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Discriminant is: " + D);
            if (D<0 && a!=0)
            {
                Console.WriteLine("Equation doesn't real roots");
            }
            else if (D == 0 && a != 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine("When D==0, x is {0:F2}:", x);
            }
            else if (D > 0 && a != 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("First real root is: {0:F2}\nSecond real root is: {1:F2}", x1,x2);

            }

        }
    }

