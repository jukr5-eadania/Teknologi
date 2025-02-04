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
            stringDelegate tmp = CollectString;
            tmp("Nimi", "is", "wife");
            Console.ReadLine();
        }
    }
}
