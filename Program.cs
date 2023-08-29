using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.
            string a = "Hello There";
            Console.WriteLine(ReverseString(a));
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
            char[] arr;
            int o = 0;
            Console.WriteLine(charArray.Length);
            for (int i = arrayLength - 1; i >= 0; i--)
            {   
                arr[] = charArray[i];
                Console.WriteLine(charArray[i]);
                o++;
            }
            Console.WriteLine(new string(charArray));
            // return new string(charArray);
            return "";
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            // TODO: Calculate the factorial.
            return 0;
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
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            return 0;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            // TODO: Determine if the string is a palindrome.
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            return "";
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            return "";
        }
    }
}
