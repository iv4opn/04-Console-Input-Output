using System;


    class SumIntNum
    {
        static void Main()
        {
            Console.WriteLine("Enter three integer numbers:");
            int intFirst = int.Parse(Console.ReadLine());
            int intSecond = int.Parse(Console.ReadLine());
            int intThird = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of enetered three numbers is: "+(intFirst+intSecond+intThird));
        }
    }

