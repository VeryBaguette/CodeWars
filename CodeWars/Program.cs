using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class Kata1
    {
        public static int[] MultiplyAll(int[] arr, int n)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] *= n; 
            }
            return arr;
        }
    }
    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            int count = 0;
            foreach(int val in values)
            {
                if (val % 2 == 0) count++;
            }
            int[] arr = new int[count];
            count = 0;
            for(int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    arr[count] = values[i];
                    count++;
                }
            }
            return arr;
        }
    }
    public class Fixer
    {
        public static List<int> PipeFix(List<int> arr)
        {
            int min = 2147483647;
            int max = -2147483647;
            foreach(int val in arr)
            {
                if (val >= max) max = val;
                if (val <= min) min = val;
            }
            var arr1 = new List<int>();
            for(int i = min; i <= max; i++)
            {
                arr1.Add(i);
            }
            return arr1;
        }
    }
    public class Printer
    {
        public static string PrinterError(String s)
        {
            s.ToLower();
            var arr = s.ToCharArray();
            int count = 0;
            int max = arr.Length;
            var errors = new char[] {'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            foreach(char val in arr)
            {
                foreach(char error in errors)
                {
                    if (val == error) count++;
                }
            }
            return $"{count}/{max}";
        }
    }
    public class Kata2
    {
        public static string Switcher(string[] x)
        {
            char[] alphabet = new char[26] { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };
            int[] arr = new int[x.Length];
            for (int i = 0; i < x.Length; i++) { arr[i] = int.Parse(x[i]); }
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 29) str += " ";
                else if (arr[i] == 28) str += "?";
                else if (arr[i] == 27) str += "!";
                else str += alphabet[arr[i] - 1];
            }
            return str;
        }
    }
    public static class HeronsFormula
    {
        public static double heron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    public class EvenOrOddKata
    {
        public static string EvenOrOdd(string str)
        {
            int[] arr = new int[str.Length];
            int even = 0;
            int odd = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (int.Parse(str[i].ToString()) % 2 == 0) even += int.Parse(str[i].ToString());
                else odd += int.Parse(str[i].ToString());
            }
            if (even > odd) return "Even is greater than Odd";
            else if (odd > even) return "Odd is greater than Even";
            else return "Even and Odd are the same";
        }
    }
    public class LostNumber
    {
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            bool block;
            foreach(int val in startingList)
            {
                block = false;
                foreach(int mix in mixedList)
                {
                    if (val == mix) block = true;
                }
                if (block == false) return val;
            }
            return 0;
        }
    }
    public class LargestFiveDigitNumber
    {
        public static int GetNumber(string str)
        {
            int max = 0;
            string numStr;
            for (int i = 0; i < str.Length - 4; i++)
            {
                numStr = str[i].ToString() + str[i + 1].ToString() + str[i + 2].ToString() + str[i + 3].ToString() + str[i + 4].ToString();
                if (int.Parse(numStr) > max) max = int.Parse(numStr);
            }
            return max;
        }
    }
    public class RearrangeNumber
    {
        public static int? MaxRedigit(int num)
        {
            if (num <= 0) return null;
            int length = 0;
            while(num != 0) { num /= 10; length++; }

        }
    }
}

