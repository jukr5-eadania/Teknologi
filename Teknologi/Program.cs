using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologi
{
    internal class Program
    {
        delegate void stringDelegate(string a, string b, string c);

        static void CollectString(string a, string b, string c)
        {
            Console.WriteLine($"{a} {b} {c}");
        }

        static void Main(string[] args)
        {
            stringDelegate str = CollectString;
            str("Nimi", "is", "wife");

            List<int> num = new List<int>() { 4, 32, 73, 312, 58215 };

            //Sorts a list from lowest to highest
            num.Sort(new Comparison<int>(lowFirst));

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            //Sorts a list from highest to lowest
            num.Sort(new Comparison<int>(highFirst));

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static int lowFirst(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (b > a)
            {
                return -1;
            }
            return 0;
        }

        static int highFirst(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (b < a)
            {
                return -1;
            }
            return 0;
        }
    }
}
