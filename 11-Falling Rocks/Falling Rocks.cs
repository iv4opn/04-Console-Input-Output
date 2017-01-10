using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class FallingRocks
    {
        struct Symbols
        {
            public int x;
            public int y;
            public string sign;
            public ConsoleColor color;
        }

        static void PrintSymbol(int x, int y, string symbol, ConsoleColor tint = ConsoleColor.Blue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = tint;
            Console.Write(symbol);
        }
        static void PrintStringSymbol(int x, int y, string symbol, ConsoleColor tint = ConsoleColor.Blue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = tint;
            Console.Write(symbol);
        }
        
        
        static void Main()
        {
            int gameAreaWidth = 40;
            int points=0;
            int lives = 3;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth=60;

            Symbols mySymbol = new Symbols();
            mySymbol.x = 19;
            mySymbol.y = Console.WindowHeight-1;
            mySymbol.sign = "(0)";
            mySymbol.color = ConsoleColor.White;
            Random randomSimbols = new Random();
            List<Symbols> signs= new List<Symbols>();

            while (true)
            {
                {
                    Symbols newSymbol = new Symbols();
                    newSymbol.color = ConsoleColor.Yellow;
                    newSymbol.x = randomSimbols.Next(0, gameAreaWidth);
                    newSymbol.y = 0;
                    newSymbol.sign = "&&";                    
                    signs.Add(newSymbol);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if (mySymbol.x - 1 >= 0)
                        {
                            mySymbol.x = mySymbol.x - 1;
                        }
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (mySymbol.x + 1 < gameAreaWidth)
                        {
                            mySymbol.x = mySymbol.x + 1;
                        }
                    }

                }

                List<Symbols> newS = new List<Symbols>();
                for (int i = 0; i < signs.Count; i++)
                {
                    Symbols oldSym = signs[i];
                    Symbols newSym = new Symbols();
                    newSym.x = oldSym.x;
                    newSym.y = oldSym.y + 1;
                    newSym.sign = oldSym.sign;
                    newSym.color = oldSym.color;
                    if (newSym.y==mySymbol.y && newSym.x==mySymbol.x )
                    {
                        lives--;
                        if (lives<=0)
                        {
                            
                            PrintStringSymbol(45, 10, "Game Over", ConsoleColor.Red);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (newSym.y < Console.WindowHeight)
                    {
                        newS.Add(newSym);
                    }
                    
                    if (newSym.y < Console.WindowHeight)
                    {
                        points++;
                        PrintStringSymbol(45, 15, "Points: " + points, ConsoleColor.White);

                    }
                   
                }

                signs = newS;
                Console.Clear();
                PrintSymbol(mySymbol.x, mySymbol.y, mySymbol.sign, mySymbol.color);

                foreach (Symbols symbol in signs)
                {
                    PrintSymbol(symbol.x, symbol.y, symbol.sign, symbol.color);

                }
                PrintStringSymbol(45, 5, "Lives: " + lives, ConsoleColor.White);
                Thread.Sleep(150);

            }
        }
    }
