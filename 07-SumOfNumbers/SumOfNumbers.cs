using System;

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Ener number of sums: ");
            byte n = byte.Parse(Console.ReadLine());
            double sum=0;
            Console.WriteLine("Enter numbers:");
            for (int i = 1; i <=n; i++)
            {
                double num=double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("The sum of numbers is: " + sum);
        }
    }

