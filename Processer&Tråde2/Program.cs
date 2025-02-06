using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Processer_Tråde2
{
    internal class Program
    {
        public static int state = 5;
        static readonly object lockObject = new object();

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Thread t = new Thread(RunMe);
                t.Start();
            }
        }

        static void RunMe()
        {
            int i = 0;
            while (true)
            {
                lock (lockObject)
                {
                    if (state == 5)
                    {
                        state++;
                        Trace.Assert(state == 6, "Race condition in loop " + i);
                    }
                    state = 5;
                }
                i++;
            }
        }
    }
}
