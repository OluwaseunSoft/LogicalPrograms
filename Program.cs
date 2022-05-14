using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int IsPrimeNumber(int start, int end)
        {

            Console.WriteLine("This Program prints the prime numbers in a range of numbers.\n" +
                "Enter a starting number, and an end number");
            Console.WriteLine("Enter the start number: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number: ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {start} and {end} are : ");
            for(int i = start; i <= end; i++)
            {

            }
        }
    }
}
