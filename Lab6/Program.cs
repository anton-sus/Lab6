using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string max = "";
            foreach (string s in stringArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("самое длинное слово в строке: {0}", max);
            Console.ReadKey();
        }
    }
}
