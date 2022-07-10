using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class LinqTraining
    {
        public static void CharacterFrequency(string message)
        {
            message = message.Replace(" ", string.Empty);

            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0] == message[j]) count++;
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }
        }

        public static void LinqParticularElement(int[] numbers)
        {
            var lowNums = numbers.Where(p => p <= 12);
            //(from n in numbers

            //   select n).Max();

            Console.WriteLine("Select particular item from list");
            //if (numbers.Length == lowNums.Count())
            //{
            //    Console.WriteLine("Number is distinct");
            //}
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(lowNums.ToString());
        }
        public static void LinqGT5Numbers(int[] numbers)
        {
            var lowNums = from n in numbers
                          where (n > 5 && n < 7)
                          select n;
            Console.WriteLine("Print all item where item is greater than 5");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }
        public static void LinqAllNumbers(int[] numbers)
        {
            var lowNums = from n in numbers
                          select n;
            Console.WriteLine("Print all number");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        public static void PrimeNumber(int number)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", number);
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
