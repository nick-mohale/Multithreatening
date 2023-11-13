using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreatening
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread thread = Thread.CurrentThread;

            thread.Name = "Main Thread";

            Console.WriteLine(thread.Name);

            Thread thread1 = new Thread(countUp);
            Thread thread2 = new Thread(countDown);
            thread1.Start();
            thread2.Start();





            Console.ReadKey();

        }

        public static void countUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Timer 1 : " + i );
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer 1 Completed");
        }

        public static void countDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer 2 : " + i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Thread 2 Completed");
        }
    }
}
