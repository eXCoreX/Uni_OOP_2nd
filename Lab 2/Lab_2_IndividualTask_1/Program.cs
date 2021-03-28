using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_IndividualTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter command:\n" +
                              "0 x -- sqrt(abs(x))\n" +
                              "1 x -- x^3\n" +
                              "2 x -- x + 3.5\n" +
                              "Any other input will end the program.");
            Func<double, double>[] funcs = { x => Math.Sqrt(Math.Abs(x)),
                                             x => x * x * x,
                                             x => x + 3.5 };
            try
            {
                while (true)
                {
                    string[] command = Console.ReadLine().Trim().Split();
                    int idx = int.Parse(command[0]);
                    double x = double.Parse(command[1]);
                    Console.WriteLine(funcs[idx](x));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
