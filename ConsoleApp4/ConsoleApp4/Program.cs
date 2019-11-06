using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your num:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            while (num != 1)
            {
                result = result * (num * (num - 1));
                num--;
            }

            Console.WriteLine("The result is: {0}", result);
            Console.ReadKey();
        }
    }
}

