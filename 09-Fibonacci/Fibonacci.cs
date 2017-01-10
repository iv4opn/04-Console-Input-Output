using System;
using System.Numerics;


    class Fibonacci
    {
        static void Main()
        {       
            
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger sum;
            Console.WriteLine("F0:{0}\nF1:{1}",a ,b);
            
            for (int i = 2; i <= 100; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                Console.WriteLine("F{0}:{1}",i,sum);

            }
        
            
        }
    }

