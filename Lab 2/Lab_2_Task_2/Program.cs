﻿using System;

namespace Lab_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(new TimeSpan(0, 0, 0, 0, 100), false, () =>
               {
                   Console.WriteLine("Tick");
               });
            Console.WriteLine("Enter 1 to start, 2 to pause, 3 to cancel timer. Anything else will exit the program.");

            while (true)
            {
                string inputStr = Console.ReadLine();
                int token;
                if (int.TryParse(inputStr, out token))
                {
                    switch (token)
                    {
                        case 1:
                            myTimer.Start();
                            break;
                        case 2:
                            myTimer.Stop();
                            break;
                        case 3:
                            myTimer.Cancel();
                            break;
                        default:
                            goto outer;
                    }
                }
            }
        outer:;
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
