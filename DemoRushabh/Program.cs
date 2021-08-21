using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRushabh
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 10;
            
            Console.WriteLine("Enter Number",+ j);
            if (j > 0 && j <101)
            {
                int result = j / 3;
                Console.WriteLine(result);

            }

            else
            {
                Console.WriteLine("Please Provide a valid positive number.");

            }
            Console.ReadKey();
        }
    }
}
