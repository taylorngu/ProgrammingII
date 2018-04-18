using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleColorChanger1
{
    enum Color { BlueRed, MagentaWhite, RedYellow, YellowCyan, GreenBlue }

  
    class Program
    {
        static void myTimerMethod(Object o)
        {

            Random gen = new Random();

            Color randomColor = (Color)gen.Next((int) Color.BlueRed, (int)Color.GreenBlue + 1);


            switch (randomColor)
            { 
            
                case (Color.BlueRed):
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;

                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine("Watch the colors of the Console change\n Press Ctrl+C to end the program");
                    }

                    break;

                case (Color.MagentaWhite):
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine("Watch the colors of the Console change\n Press Ctrl+C to end the program");

                    }

                    break;

                case (Color.RedYellow):
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine("Watch the colors of the Console change\n Press Ctrl+C to end the program");

                    }

                    break;
                case (Color.YellowCyan):
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine("Watch the colors of the Console change\n Press Ctrl+C to end the program");

                    }

                    break;
                case (Color.GreenBlue):
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;

                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine("Watch the colors of the Console change\nPress Ctrl+C to end the program");

                    }
                    break;
            
            }

        }

        static void Main(string[] args)
        {

            Timer tmrColor = new Timer(myTimerMethod, null, 0, 500);

            Console.ReadLine();

        }
    }
}
