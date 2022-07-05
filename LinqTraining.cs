using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class LinqTraining
    {
        public static void LinqAllNumbers(int[] numbers)
        {
            var lowNums = from n in numbers
                          select n;
            Console.WriteLine("Print all number");
            foreach(var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        public static void LinqEvenNumber(int[] numbers)
        {
            var lowNums = (from n in numbers
                           where (n % 2 == 0)
                           select n);
            Console.WriteLine("Select even number only");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(lowNums);
        }
    }
}
