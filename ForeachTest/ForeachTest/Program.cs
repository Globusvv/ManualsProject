using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 87, 45, 67, 34, 56, 12};
            int total = 0;
            foreach (int number in array)
                total += number;
            Console.WriteLine("{0}", total);
        }
    }
}
