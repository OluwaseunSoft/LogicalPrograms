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
            Program program = new Program();
            //program.Circle();
            //Console.WriteLine(program.CalculateFactorial(12));
            program.StrongNumberRange();
        }

        public void ReverseString()
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            foreach (char c in originalString)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }

        public void StrongNumber()
        {
            int number, sum = 0;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            int quot = number;
            int remainder;

            while (quot != 0)
            {
                remainder = quot % 10;
                int fact = CalculateFactorial(remainder);
                quot = quot / 10;
                sum = sum + fact;
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is a Strong Number");
            }
            else
            {
                Console.WriteLine(number + " is not a Strong Number");
            }
        }

        public void StrongNumberRange()
        {
            int number = 0;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            int remainder;
            Console.WriteLine("Strong Number Numbers Between 1 and " + number + " : ");
            for(int i = 1; i <= number; i++)
            {
                int quot = i, sum = 0;
                while(quot != 0)
                {
                    remainder = quot % 10;
                    int fact = CalculateFactorial(remainder);
                    quot = quot / 10;
                    sum = sum + fact;
                }
                if (sum == i)
                {
                    Console.WriteLine(i + " ");
                }
            }   
        }


        public int CalculateFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public void Circle()
        {
            Console.WriteLine("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle: " + area);
            Console.ReadLine();
        }

        public void IsPrimeNumber()
        {
            int start, end;
            Console.WriteLine("This Program prints the prime numbers in a range of numbers.\n" +
                "Enter a starting number, and an end number");
            Console.WriteLine("Enter the start number: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number: ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {start} and {end} are : ");
            for (int i = start; i <= end; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("{0} ", i);
                }
            }

            Console.ReadKey();
        }
    }
}
