using System;

    class DivisionByFive
    {
        static void Main()
        {
            Console.WriteLine("Eneter the start number:");
            uint startNum = uint.Parse(Console.ReadLine());
            Console.WriteLine("Eneter the end number:");
            uint endNum = uint.Parse(Console.ReadLine());
            string divNum=null;
            //bool check;
            for (uint i = startNum; i <= endNum; i++)
            {
                if (i % 5 == 0)
                {
                   divNum +=" "+ i + " ";                    
                }                
            }
            Console.WriteLine(divNum ?? "Sequence did not contain thedesired numbers.");
        }
    }

