using System;

    class CircleArea
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of Circle:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the circle is {0:F2}\nThe perimeter of the circle is {1:F2}",(Math.PI*Math.Pow(radius,2)),(2*Math.PI*radius));            
        }
    }

