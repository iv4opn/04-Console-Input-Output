using System;


    class SumOfRealNum
    {
        static void Main()
        {
            Console.Write("Enter the bigger fractional part: ");
            int n = int.Parse(Console.ReadLine());
            double sum=1.0;
            for (int i = 2, j = 1; i <= n; i++, j++)
            {
                double realNubmer = 1.0 / i;
                
                if (j % 2 == 0)
                {
                    realNubmer = -(realNubmer);
                }
                sum = sum +realNubmer;
            }
            Console.WriteLine("The sum of fractal numbers is: {0:F3}", sum);
        }
    }

