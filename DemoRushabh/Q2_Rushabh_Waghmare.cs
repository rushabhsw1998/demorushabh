using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRushabh
{
    class Q2_Rushabh_Waghmare
    {
        static string logestCommomPre(string[] a)
        {
            int size = a.Length;
            if (size == 0)
            {
                return "";
            }
            if (size == 1)
            {
                return a[0];
            }
            Array.Sort(a);
            int end = Math.Min(a[0].Length, a[size - 1].Length);
            int i = 0;
            while (i < end && a[0][i] == a[size - 1][i])
                i++;

            string pre = a[0].Substring(0, i);
            return pre;
        }

        static void Main(string[] args)
        {
            


            string[] A = { "aabADSd", "aabBHA", "aabRUsb" };
            Console.WriteLine(logestCommomPre(A));
            Console.ReadLine();
        }
        
    }
}
