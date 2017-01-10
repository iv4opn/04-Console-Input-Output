using System;

    class PrintNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the last number of sequence:");
            int n = int.Parse(Console.ReadLine());
            int i=1;
            //for (int i = 1; i <= n; i++)
            //{Console.WriteLine(i);}
            Console.WriteLine("The sequence is:");
            while (i<=n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

