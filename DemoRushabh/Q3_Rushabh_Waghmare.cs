using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRushabh
{
    class Q3_Rushabh_Waghmare
    {
       static string checkPath(string a)
        {
            int size = a.Length;
            char[] ch = new char[a.Length];

            Console.WriteLine("-");


            for (int i = 0; i < a.Length; i++)
            {
                ch[i] = a[i];
            }
            Console.WriteLine("-");

            foreach (char c in ch)
            {
                if (c == Convert.ToChar("U"))
                {
                    Console.WriteLine("/");
                    
                }
                else if(c == Convert.ToChar("D"))
                {
                    Console.WriteLine("//");
                }
                Console.WriteLine(c);
            }
            Console.WriteLine("-");
         
            return a;
        }


       public static void Main(string[] args)
        {
            string A = "UUDUD";
            Console.WriteLine(checkPath(A));
            Console.ReadLine();
        }
    }
}
