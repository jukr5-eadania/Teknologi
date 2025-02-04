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

        static bool keepRunning = true;

        static void ReactToDeath(Player p)
        {
            Console.WriteLine($"{p} died");
            keepRunning = false;
        }

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
            num.Sort(new Comparison<int>(LowFirst));

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            //Sorts a list from highest to lowest
            num.Sort(new Comparison<int>(HighFirst));

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            //Delegate array to use more methods
            Func<int, int, int>[] delegateArray =
            {
                AddNumbers,
                SubtractNumbers
            };

            foreach (var item in delegateArray)
            {
                WriteToScreen(item, 2, 2);
                WriteToScreen(item, 5, 7);
                WriteToScreen(item, 10, 25);
            }

            Player p = new Player("Nimi Nightmare");
            p.DeathEvent += ReactToDeath;

            while (keepRunning)
            {
                p.Health--;

                Console.WriteLine(p.Health);
            }

            Console.ReadLine();
        }

        static int LowFirst(int a, int b)
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

        static int HighFirst(int a, int b)
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

        static int AddNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static int SubtractNumbers(int a, int b)
        {
            int c = a - b;
            return c;
        }

        static void WriteToScreen(Func<int, int, int> action, int a, int b)
        {
            int result = action(a, b);
            Console.WriteLine(result);
        }
    }
}
