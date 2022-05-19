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
            program.FibonacciSeries();
        }

        public void FibonacciSeries()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber,
                numberOfElements;
            //Console.WriteLine("Enter the number of elements to print: ");
            Console.WriteLine("Enter the Nth number of the Fibonacci series : ");
            numberOfElements = int.Parse(Console.ReadLine());
            //if(numberOfElements < 2)
            //{
            //    Console.WriteLine("Please enter a number greater than two");
            //}
            //else
            //{
            //    Console.WriteLine(firstNumber + " " + secondNumber);
            //    for(int i = 2; i < numberOfElements; i++)
            //    {
            //        nextNumber = firstNumber + secondNumber;
            //        Console.WriteLine(nextNumber + " ");
            //        firstNumber = secondNumber;
            //        secondNumber = nextNumber;
            //    }
            //}
            //FibonacciSeriesFn(0, 1, 1, numberOfElements);
            numberOfElements = numberOfElements - 1;
            Console.WriteLine(NthFibonacciNumber(numberOfElements));
            Console.ReadKey();
        }

        private static int NthFibonacciNumber(int number)
        {
            if((number == 0) || (number == 1))
            {
                return number;
            }
            else
            {
                return (NthFibonacciNumber(number - 1) +
                    NthFibonacciNumber(number - 2));
            }
        }

        public static void FibonacciSeriesFn(int firstNum, int secondNum,
            int counter, int number)
        {
            Console.WriteLine(firstNum + " ");
            if(counter < number)
            {
                FibonacciSeriesFn(secondNum, firstNum + secondNum,
                    counter + 1, number);
            }
        }

        public void SumOfNumbers()
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            //int sum = SumOfDigits(number);
            int sum = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();


            //while(number > 0)
            //{
            //    reminder = number % 10;
            //    sum = sum + reminder;
            //    number = number / 10;
            //}
            Console.WriteLine($"The sum of the digit is: {sum}");
            Console.ReadKey();
        }

        public void SwappingNumber()
        {
            int number1 = 5, number2 = 3;
            string name1 = "Seun", name2 = "Akinwale";
            Console.WriteLine($"Before swapping number1 = {number1}, number2 = {number2}");
            //temp = number1;
            //number1 = number2;
            //number2 = temp;
            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            Console.WriteLine($"After swapping number1 = {number1}, number2 = {number2}");
            Console.WriteLine($"Before swapping name1 = {name1}, name2 = {name2}");
            name1 = name1 + name2;
            name2 = name1.Substring(0, name1.Length - name2.Length);
            name1 = name1.Substring(name2.Length);
            Console.WriteLine($"After swapping name1 = {name1}, number2 = {name2}");
            Console.ReadKey();
        }

        static int SumOfDigits(int number)
        {
            if (number != 0)
            {
                return (number % 10 + SumOfDigits(number / 10));
            }
            else
            {
                return 0;
            }
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
            for (int i = 1; i <= number; i++)
            {
                int quot = i, sum = 0;
                while (quot != 0)
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
