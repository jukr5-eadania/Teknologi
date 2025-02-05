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
        public static bool keepRunning = true;

        static void Main(string[] args)
        {
            Thread myThread = new Thread(ThreadWork);
            myThread.IsBackground = true;
            Class1 dataThread = new Class1("Hello World");
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            t1.IsBackground = true;
            t2.IsBackground = true;

            //dataThread.Start();
            //myThread.Start();
            t1.Start();
            t2.Start();


            //Console.WriteLine("Bruh1");
            //while (running)
            //{
            //    if (counter >= 1)
            //    {
            //        running = false;
            //    }
            //}

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

        private static void M1()
        {
            while (keepRunning)
            {
                Console.WriteLine("Tap Tap");
                Thread.Sleep(500);
            }
        }

        private static void M2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Tapir");
                Thread.Sleep(500);
            }

            keepRunning = false;
            Console.WriteLine("Press any button to stop the program");

        }
    }
}
