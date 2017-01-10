using System;

    class GetGreatNumber
    {
        static void Main()
        {
           // Console.WriteLine("Enter two possitive integer numbers:");
            float firstNum = float.Parse(Console.ReadLine());
            float secondNum = float.Parse(Console.ReadLine());
            bool check=true;
            //Console.Write("The bigger number is:");
            //Console.WriteLine(check==(firstNum<secondNum) ? secondNum:firstNum);
            Console.WriteLine(Math.Max(firstNum,secondNum)); //Other solution
        }
    }
