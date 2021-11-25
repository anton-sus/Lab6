using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string formatString = "";
            bool f = false;
            foreach (string s in stringArray)
            {
                formatString += s.Substring(0, 1).ToLower() + s.Substring(1);
            }
            int n = formatString.Length;
            char[] arrayOfLetters = formatString.ToCharArray();
            for (int first = 0, last = n - 1; first < last; ++first, --last)
            {
                if (arrayOfLetters[first] != arrayOfLetters[last])
                {
                    Console.WriteLine("не палиндром");
                    f = true;
                    break;
                }
            }
            if (!f)
            Console.WriteLine("палиндром");
            Console.ReadKey();
        }
    }
}