using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Processer_Tråde
{
    internal class Class1
    {
        Thread internalThread;
        string data;

        public  Class1(string data)
        {
            this.data = data;
            internalThread = new Thread(ThreadMethod);
            internalThread.IsBackground = true;
        }

        private void ThreadMethod()
        {
            Console.WriteLine("The Thread Recieved the following message : {0}", data);
        }

        public void Start()
        {
            internalThread.Start();
        }
    }
}
