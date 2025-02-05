using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Processer_Tråde
{
    internal class Program
    {
        public static bool running = true;
        public static int counter;

        static void Main(string[] args)
        {
            Thread myThread = new Thread(ThreadWork);
            Class1 dataThread = new Class1("Hello World");

            dataThread.Start();

            myThread.IsBackground = true;
            myThread.Start();

            Console.WriteLine("Bruh1");
            while (running)
            {
                if (counter >= 10)
                {
                    running = false;
                }
            }

            Console.WriteLine("Press any button to stop the program");
            Console.ReadKey();
        }

        private static void ThreadWork()
        {
            while (running)
            {
                Console.WriteLine("Bruh2");
                counter++;
                Thread.Sleep(1000);
            }
        }
    }
}
