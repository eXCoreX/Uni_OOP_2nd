using System;
using System.Collections.Generic;

namespace Lab_2_Task_3
{
    class Program
    {
        static int[] MySelectIf(int[] arr, Predicate<int> predicate)
        {
            List<int> selected = new List<int>();

            foreach (var item in arr)
            {
                if (predicate(item))
                {
                    selected.Add(item);
                }
            }
            return selected.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer array (in a single line):");
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);

            Console.WriteLine("Choose option:\n" +
                              "1. Divisible by 3\n" +
                              "2. Divisible by 7");
            int option = int.Parse(Console.ReadLine());
            if (option == 1 || option == 2)
            {
                option--;
                Predicate<int>[] lambdas = { x => x % 3 == 0, x => x % 7 == 0 };
                int[] result = MySelectIf(arr, lambdas[option]);
                Console.WriteLine(string.Join(" ", result));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
