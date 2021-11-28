using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give Fibonacci Sequence number");
            int number = int.Parse(Console.ReadLine());
            Fibonacci Seque = new Fibonacci();
            Stopwatch sw = new Stopwatch();

            sw.Start();

            Console.WriteLine("Fibonaccis is {0}", Seque.MemoizationRecrusive(number));
            sw.Stop();

            Console.WriteLine("Elapsed={0} seconds", sw.Elapsed.TotalSeconds);

            Console.ReadLine();
        }
    }
}
