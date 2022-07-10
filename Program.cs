using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {

        static void Main(string[] args)
        {

            LinqTraining.PrimeNumber(2);
            Console.ReadLine();
        }

        public static void RemoveDuplicateInArray(int[] arr)
        {
            int i, j = 0;
            //for (i = 0; i < arr.Length; i++)
            //{
            //    for (j = 0; j < arr.Length; j++)
            //    {
            //        if (i == j) continue;
            //        if (arr[j] == arr[i]) break;
            //    }
            //    if (arr.Length == j)
            //        Console.WriteLine(arr[i] + " ");
            //}

            int n = arr.Length;
            //Step 2
            Array.Sort(arr);
            if (arr[0] != arr[1])
                Console.WriteLine(arr[0] + " ");
            for (i = 1; i < n - 1; i++)
                if (arr[i] != arr[i + 1] && arr[i] != arr[i - 1])
                    Console.WriteLine(arr[i] + " ");
            if (arr[n - 2] != arr[n - 1])
                Console.WriteLine(arr[n - 1] + " ");
        }

        public static void RightCircularArray()
        {
            int[] oneDimesionalArray = new int[6];
            Console.WriteLine("Enter the 1D Array Elements : ");
            for (int i = 0; i < oneDimesionalArray.Length; i++)
            {
                oneDimesionalArray[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (int j = 0; j < oneDimesionalArray.Length - 1; j++)
            {
                temp = oneDimesionalArray[0];
                oneDimesionalArray[0] = oneDimesionalArray[j + 1];
                oneDimesionalArray[j + 1] = temp;
            }
            Console.WriteLine("Array Elements After Right Circular Rotation " +
                " Test project: ");
            foreach (int num in oneDimesionalArray)
            {
                Console.WriteLine(num + " ");
                Console.WriteLine(num + " ");
                Console.WriteLine(num + " ");
            }
        }

        public static void AngleOfAClock()
        {
            Console.WriteLine("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minutesInDegrees = minutes * 6;
            double diff = Math.Abs(hourInDegrees - minutesInDegrees);

            if (diff > 180)
                diff = 360 - diff;
            Console.WriteLine($"Angle between {hours} hours and {minutes} minute is {diff} degrees");

        }

        public static void BinarySearch()
        {
            int[] intArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
            int target = 17;
            int pos = Array.BinarySearch(intArray, target);
            if (pos >= 0)
                Console.WriteLine($"Item {intArray[pos]} found at position {pos + 1}. ");
            else
                Console.WriteLine("Item not found");
            Console.WriteLine("Item not found");
            Console.WriteLine("Item not found");
        }

        public static void DictionaryDataStruc()
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An element with key = \"txt\" already exists. {0}", ex.Message);
            }

            Console.WriteLine("For Key = \"rtf\", Value = {0}.", openWith["rtf"]);
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For Key = \"rtf\", Value = {0}.", openWith["rtf"]);
            openWith["doc"] = "winword.exe";

            try
            {
                Console.WriteLine("For key = \"tif\", Value = {0}", openWith["tif"]);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Key = \"tif\" is not found. {0}", ex.Message);
            }

        }

        public static void ModeChar(string value)
        {
            Dictionary<char, int> CharList = new Dictionary<char, int>();
            char[] newChar = value.ToCharArray();
            foreach (var oneChar in newChar)
            {
                int number = newChar.Where(x => x == oneChar).Count();
                if (!CharList.ContainsKey(oneChar))
                    CharList.Add(oneChar, number);
            }
            foreach (KeyValuePair<char, int> mode in CharList)
            {
                Console.WriteLine("Char {0} appears {1} times", mode.Key, mode.Value);
            }
        }

        public static void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("senero99@gmail.com");
                message.To.Add(new MailAddress("akinwaleoluwaseun2015@gmail.com"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("senero99@gmail.com", "@4123Seun");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void LinkedListEx()
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values: ");
            Console.WriteLine("sentence.Contains(\"jumps\") = {0}", sentence.Contains("jumps"));

            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to the beginning of the list: ");

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node: ");

            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test  3: change the last node to 'yesterday': ");

            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node: ");

            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the': ");

            current = sentence.Find("fox");
            IndicateNode(current, "Test 7: Indicate the 'fox' node: ");

            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");
            IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox': ");

            mark1 = current;
            LinkedListNode<string> mark2 = current.Previous;
            current = sentence.Find("dog");
            IndicateNode(current, "Test 9: Indicate the 'dog' node: ");

            Console.WriteLine("Test 10: Throw by adding node (fox) already in the list: ");
            try
            {
                sentence.AddBefore(current, mark1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }
            Console.WriteLine();

            sentence.Remove(mark1);
            sentence.AddBefore(current, mark1);
            IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog): ");

            sentence.Remove(current);
            IndicateNode(current, "Test 12: Remove current node (dog) and attempt to indicate it: ");

            sentence.AddAfter(mark2, current);
            IndicateNode(current, "Test 13: Add node removed in test 11 after a referenced node (brown):");

            sentence.Remove("old");
            Display(sentence, "Test 14: Remove node that has the value 'old':");

            sentence.RemoveLast();
            ICollection<string> icoll = sentence;
            icoll.Add("rhinoceros");
            Display(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros': ");

            Console.WriteLine("Test 16: Copy the list to an array: ");

            string[] sArray = new string[sentence.Count];
            sentence.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            sentence.Clear();

            Console.WriteLine();
            Console.WriteLine("Test 17: Clear linked list. Contains 'jumps' = {0}", sentence.Contains("jumps"));

            Console.ReadLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n", node.Value);
                return;
            }
            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.WriteLine(word + " " + "");
                Console.WriteLine(word + " " + "");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void SampleQueue()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            Console.WriteLine("myQ");
            Console.WriteLine("\tCount: {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues(myQ);
        }

        private static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write(" {0}", obj);
                Console.WriteLine();
            }
        }

        public void FibonacciSeries()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber,
                numberOfElements;
            //Console.WriteLine("Enter the number of elements to print: ");
            Console.WriteLine("Enter the Nth number of the Fibonacci series : ");
            numberOfElements = int.Parse(Console.ReadLine());
            numberOfElements = numberOfElements - 1;
            Console.WriteLine(NthFibonacciNumber(numberOfElements));
            Console.ReadKey();
        }

        public static void StackData()
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("One");
            numbers.Push("Two");
            numbers.Push("Three");
            numbers.Push("Four");
            numbers.Push("Five");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
            Console.WriteLine("Popping '{0}'", numbers.Pop());

            Stack<string> stack2 = new Stack<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy: ");
            foreach (string number in stack2)
            {
                Console.WriteLine(number);
            }

            string[] arrays2 = new string[numbers.Count * 2];
            numbers.CopyTo(arrays2, numbers.Count);

            Stack<string> stack3 = new Stack<string>(arrays2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls: ");
            foreach (string number in stack3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                stack2.Contains("Four"));

            Console.WriteLine("\nstack2.clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }

        private static int NthFibonacciNumber(int number)
        {
            if ((number == 0) || (number == 1))
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
            if (counter < number)
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
