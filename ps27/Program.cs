using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 100, sum = 0;
            do
            {
                sum = sum + number;
                number = number + 1;

            } while (number <= 200);
            Console.WriteLine("sum of all numbers between 100 and 200");
            Console.Write(sum);
            Console.Read();
        }
    }
}
