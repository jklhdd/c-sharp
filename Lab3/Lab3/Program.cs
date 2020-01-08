using System;
using System.Threading;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(count);
            t.Start();
            

        }
        public static void count()
        {
            for(int i = 600;i > 0; i--)
            {
                Console.WriteLine(i / 60 +":"+ i % 60);
                Thread.Sleep(1000);
            }
        }
    }
}
