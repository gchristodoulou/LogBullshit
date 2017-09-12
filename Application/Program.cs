using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUsers
{
    using System.Threading;

    using LogTest;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            ILog  logger = new AsyncLog();

            for (int i = 0; i < 120; i++)
            {
                logger.WriteAsync("Number with Flush: " + i.ToString());
                //Thread.Sleep(20);
            }

            //logger.StopWithFlush();

            ILog logger2 = new AsyncLog();

            for (int i = 150; i > 0; i--)
            {
                logger2.WriteAsync("Number with No flush: " + i.ToString());
                //Thread.Sleep(50);
            }

            //logger2.StopWithoutFlush();

            Console.ReadLine();

        }
    }
}
