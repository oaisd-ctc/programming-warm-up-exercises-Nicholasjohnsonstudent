using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.
            string a = "racecar";
            string b = "Driving";
            string ab = "Hello there";
            char c = 'c';
            int d = 35;
            int e = 23;
            int f = 24;
            int g = 9;
            int[] h = {1,4,3,76,44,3,5,4};
            Console.WriteLine(d + " + " + e + " = " + Add(d,e));

            Console.WriteLine(d + " is even = " + IsEven(d));

            Console.WriteLine(MaxOfThree(d,e,f) + " is the max of " + d + ", " + e + ", and " + f);

            Console.WriteLine(b + " is " + StringLength(b) + "characters long");

            Console.WriteLine(ab + " starts with 'Hello' = " + StartsHello(ab));

            Console.WriteLine(ab + " reversed is " + ReverseString(ab));

            Console.WriteLine(g + "! is " + Factorial(g));
            
            Console.WriteLine(e + " is a prime number = " + IsPrime(e));

            Console.WriteLine("The " + g + "th number in the fibonacci sequence is " + Fibonacci(g));

            Console.Write("The Largest number in ");
            foreach (int num in h)
            {
                Console.Write(num + ", ");
            }
            Console.Write(" is " + LargestInArray(h));
            Console.WriteLine();

            Console.WriteLine(a + " is a palindrome = " + IsPalindrome(a));

            Console.Write("The sum of ");
            foreach (int num in h)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("is " + ArraySum(h));

            Console.WriteLine("The amount of " + c + "s in " + a + " are " + CharCount(a, c));

            Console.WriteLine("The combination of " + a + " and " + b + " is " + ConcatenateStrings(a,b));

            Console.WriteLine(b + " with swaped ends is " + SwapEnds(b));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            // TODO: Implement this method.
            int c = a + b;
            return c;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // TODO: Implement this method.
            bool isEven;
            int mode = number % 2;
            if (mode == 0)
            {
                isEven = true;
            }
            else 
            {
                isEven = false;
            }
            
            return isEven;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int largest = 0;
            Math.Max(a, b);
            largest = Math.Max(Math.Max(a,b), c);

            return largest;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            // TODO: Implement this method.
            char[] a = s.ToCharArray();
            int length = 0;
            for (int i = 1; i <= a.Length; i++){length = i;}
            return length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            bool doesMatch = true;
            char[] twine = s.ToCharArray();
            char[] g = {'H', 'e', 'l', 'l', 'o'};
            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] != twine[i])
                {
                    doesMatch = false;
                    break;
                }
            }
            return doesMatch;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.
            int arrayLength = charArray.Length;
            char[] arr = new char[charArray.Length];
            int o = 0;
            for (int i = arrayLength - 1; i >= 0; i--)
            {   
                arr[o] = charArray[i];
                o++;
            }
            return new string(arr);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            int fact = n;
            if (n == 0) return 1;
            // TODO: Calculate the factorial.
            for (int i = n - 1; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            // TODO: Return the correct boolean value.
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            int fibNumber = 0;
            int a = 0;
            int b = 1;
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            
            for (int i = n-1; i > 0; i--)
            {
                fibNumber = a+b;
                a = b;
                b = fibNumber;
            }
            return fibNumber;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
                // TODO: Find the largest number in the array.
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            char[] arr = s.ToCharArray();
            int a = arr.Length - 1;
            Console.WriteLine(arr.Length);
            // TODO: Determine if the string is a palindrome.
            for (int i = 0; i < a; i++)
            {
                if (arr[i] != arr[a])
                {
                    return false;
                }
                a--;
            }
            return true;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            foreach (int number in numbers)
            {
                sum+=number;
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            char[] arr = s.ToCharArray();
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            
            // TODO: Concatenate the two strings with a space in between.
            return str1 + " " + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char[] charS = s.ToCharArray();
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            char[] newArr = charS;
            newArr[0] = lastChar;
            newArr[s.Length - 1] = firstChar;
            
            // TODO: Swap the first and last characters and return the modified string.
            return new string(newArr);
        }
    }
}
