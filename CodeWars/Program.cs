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
    public class Multyplier
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
            string str = num.ToString();
            str = string.Concat(str.OrderByDescending(h => h));
            return int.Parse(str);
        }
    }
    public static class MoveAllVowels
    {
        public static string MoveVowel(string input) => string.Concat(input.OrderBy(x => "aeiou".Contains(x)));                        
    }
    public class Unique
    {
        public static bool HasUniqueChars(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < str.Length; j++)
                {
                    if (j == i) continue;
                    else if (str[i] == str[j]) return false;
                }
            }
            return true;
        }
    }
    public static class Crazy
    {
        public static int CrazyFormula(long n)
        {
            string str = Convert.ToString(n);
            while(str.Length != 1)
            {
                long[] arr = new long[str.Length];
                string[] strArr = new string[str.Length];
                for (int i = 0; i < str.Length; i++) strArr[i] = str[i].ToString();
                for (int i = 0; i < strArr.Length; i++) arr[i] = int.Parse(strArr[i]);
                int length = arr.Length;
                if (length % 2 == 0) { arr[length - 1] = 0; length--; }
                if (arr[length / 2] % 2 == 1) arr[length / 2] *= -1;
                if (arr[length / 2] % 2 == 0 && arr[length - 1] % 2 == 0) arr[length - 1] *= -1;
                if (arr[length / 2] % 2 == 0 && arr[length - 1] % 2 == 1) arr[0] = (int)Math.Pow(arr[0], 2);
                int sum = 0;
                foreach (int val in arr) sum += val;
                if (sum < 0) sum *= -1;
                str = sum.ToString();
            }
            return int.Parse(str);
        }
    }
    public class AlanTravelsToLondon
    {
        public static string Alan(string[] x)
        {
            if (x.Contains("Rejection") & x.Contains("Disappointment") & x.Contains("Backstabbing Central") & x.Contains("Shattered Dreams Parkway")) return "Smell my cheese you mother!";
            return "No, seriously, run. You will miss it.";
        }
    }
    public class Solution
    {
        public static string[] StringToArray(string str) => str.Split(' ');
    }
    public class Circle
    {
        public double AreaLargestSquare(int r) => 2 * r * r;
    }
    public class ConvertBinaryArrayToNumber
    {
        public static int binaryArrayToNumber(int[] arr) => Convert.ToInt32(string.Join(string.Empty, arr), 2);
    }
    public class Slaphead
    {
        public static string[] Bald(string x)
        {
            int count = 0;
            string str = "";
            for (int i = 0; i < x.Length; i++) str += "-";
            foreach (var val in x) if (val == '/') count++;
            if (count < 1) return new string[] { str, "Clean!" };
            else if(count < 2) return new string[] { str, "Unicorn!" };
            else if(count < 3) return new string[] { str, "Homer!" };
            else if(count < 6) return new string[] { str, "Careless!" };
            else return new string[] { str, "Hobo!" };
        }
    }
    public static class DisemVowelTrolls
    {
        public static string Disemvowel(string str)
        {
            str = str.Replace("a", String.Empty);
            str = str.Replace("e", String.Empty);
            str = str.Replace("i", String.Empty);
            str = str.Replace("o", String.Empty);
            str = str.Replace("u", String.Empty);
            str = str.Replace("A", String.Empty);
            str = str.Replace("E", String.Empty);
            str = str.Replace("I", String.Empty);
            str = str.Replace("O", String.Empty);
            str = str.Replace("U", String.Empty);
            return str;
        }
    }
    public class Wallpaper
    {
        public string WallPaper(double l, double w, double h)
        {
            string[] arr = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
            double s = 2 * l * h + 2 * w * h;
            double sr = 0.52 * 10;
            double res = s / sr;
            res = res * 1.15;
            int result;
            if (res % 1 != 0) result = (int)res + 1;
            else result = (int)res;
            if (l * w * h == 0) return arr[0];
            return arr[result];
        }
    }
    public class stringArrayMethods
    {
        public static double[] ToDoubleArray(string[] strArr)
        {
            double[] arr = new double[strArr.Length];
            for (int i = 0; i < strArr.Length; i++) arr[i] = Convert.ToDouble(strArr[i]);
            return arr;
        }
    }
    public static class LongestVowel
    {
        public static int Solve(string str)
        {
            var arr = str.ToCharArray();
            int count = 0; int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u') count++;
                else { if (result <= count) result = count; count = 0; }  
            }
            return result <= count ? count : result;
        }
    }
    public class TheMiddleElement
    {
        public static int Gimme(double[] arr)
        {
            double mid = 0;
            foreach(var val in arr) if (val != arr.Max() & val != arr.Min()) mid = val;
            for(int i = 0; i < arr.Length; i++) if (arr[i] == mid) return i;
            return 0;
        }
    }
    public class MenAndBoys
    {
        public static int[] MenFromBoys(int[] a)
        {
            return a.Where(x => x % 2 == 0).OrderBy(x => x).Concat(a.Where(x => x % 2 != 0).OrderByDescending(x => x)).Distinct().ToArray();
        }
    }
    public static class SpacesRemover
    {
        public static string NoSpace(string str)
        {

            return str.Replace(" ", String.Empty);
        }
    }
    public class BuildTheText
    {
        public static string BuildRowText(int i, char c)
        {
            if (i == 0) return $"|{c.ToString()}| | | | | | | | |";
            else if (i == 1) return $"| |{c.ToString()}| | | | | | | |";
            else if (i == 2) return $"| | |{c.ToString()}| | | | | | |";
            else if (i == 3) return $"| | | |{c.ToString()}| | | | | |";
            else if (i == 4) return $"| | | | |{c.ToString()}| | | | |";
            else if (i == 5) return $"| | | | | |{c.ToString()}| | | |";
            else if (i == 6) return $"| | | | | | |{c.ToString()}| | |";
            else if (i == 7) return $"| | | | | | | |{c.ToString()}| |";
            else return $"| | | | | | | | |{c.ToString()}|";
        }
    }
    public class SumElementsOfAnArray
    {
        public static int SumMix(object[] obArr)
        {
            return obArr.Sum(Convert.ToInt32);
        }
    }
    public class MaxProduct
    {
        public static int AdjacentElementsProduct(int[] arr)
        {
            int max = Int32.MinValue;
            for(int i = 0; i < arr.Length - 1; i++) if (arr[i] * arr[i + 1] >= max) max = arr[i] * arr[i + 1];
            return max;
        }
    }
    public class ReverseTheLetter
    {
        public string ReverseLetter(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            for(int i = 0; i < arr.Length; i++) if (alphabet.Contains(arr[i]) == false) arr[i] = ' ';
            str = "";
            for(int i = 0; i < arr.Length; i++) str += arr[i].ToString();
            str = str.Replace(" ", "");
            return str;
        }
    }
    public class ReverseTheNumber
    {
        public static int ReverseNumber(int n) => int.Parse(string.Concat(Math.Abs(n).ToString().Reverse())) * (n < 0 ? -1 : 1);
    }
    public static class CountSalutesClass
    {
        public static int CountSalutes(string str)
        {
            int a = 0;
            for(int i = 0; i < str.Length; i++) if (str[i] == '>') a += str.Substring(i, str.Length).Count(x => x == '<');
            return a * 2;
        }
    }
    public static class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            if (name.Length == 0) return "no one likes this";
            else if (name.Length == 1) return $"{name[0]} likes this";
            else if (name.Length == 2) return $"{name[0]} and {name[1]} like this";
            else if (name.Length == 3) return $"{name[0]}, {name[1]} and {name[2]} like this";
            else return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }
    }
    public static class HighestAndLowest
    {
        public static string HighAndLow(string n) => $"{n.Split(' ').Select(x => int.Parse(x)).ToArray().Max()} { n.Split(' ').Select(x => int.Parse(x)).ToArray().Min()}";
    }
    public class TwistedSum
    {
        public static long Solution(long n)
        {
            int[] intArr = new int[n]; for (int i = 0; i < n; i++) intArr[i] = i + 1;
            string str = ""; foreach (var val in intArr) str = $"{str}{val}";
            char[] charArr = str.ToCharArray();
            int[] numbers = new int[charArr.Length]; for (int i = 0; i < numbers.Length; i++) numbers[i] = int.Parse(charArr[i].ToString());
            int count = 0; foreach (var val in numbers) count += val;
            return count;
        }
    }
    public class SplittingTheNumber
    {
        public static long[] SplitOddAndEven(long n)
        {
            string str = n.ToString();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (int.Parse(str[i].ToString()) % 2 == 0 && int.Parse(str[i + 1].ToString()) % 2 == 1)
                {
                    str = $"{str.Substring(0, (i + 1))}|{str.Substring((i + 1), str.Length - (i + 1))}";
                    i++;
                }
                else if (int.Parse(str[i].ToString()) % 2 == 1 && int.Parse(str[i + 1].ToString()) % 2 == 0)
                {
                    str = $"{str.Substring(0, (i + 1))}|{str.Substring((i + 1), str.Length - (i + 1))}";
                    i++;
                }
            }
            return Array.ConvertAll(str.Split('|'), x => long.Parse(x));
        }
    }
    public static class Sheeps
    {
        public static int CountSheeps(bool[] arr) => arr.Count(x => x);
    }
    public class DivisionMaster
    {
        public static int Divisions(int n, int divisor)
        {
            int count = 0;
            while(n >= divisor)
            {
                n = (int)(n/divisor);
                count++;
            }
            return count;
        }
    }
    public class DoubleLinear
    {

        public static int DblLinear(int n)
        {
            var list = new List<int> { 1 };
            int i = -1;
            while (++i < n)
            {
                if (i == n) return list[0];         
                list.AddRange(new List<int> { list[i] * 2 + 1, list[i] * 3 + 1 });
                list.RemoveAt(0);
                list.Sort();
            }
            return 0;
        }
        public static int DblLinear1(int n)
        {
            var arr = new int[] { 1 };
            int i = -1;
            while (++i < n)
            {
                Array.Resize(ref arr, arr.Length + 2);
                arr[arr.Length - 1] = arr[i] * 2 + 1;
                arr[arr.Length - 2] = arr[i] * 3 + 1;
                Array.Sort(arr);
            }
            return arr.Distinct().ToArray()[n];
        }
    }
    class SumParts
    {
        public static int[] PartsSums(int[] ls)
        {
            int[] arr = new int[ls.Length + 1];
            int sum = ls.Sum();
            arr[0] = sum;
            for (int i = 1; i < arr.Length; i++)
            {
                sum -= ls[i - 1];
                arr[i] = sum;
            }
            return arr;
        }
    }
    public class DnaStrand
    {
        public static string MakeComplement(string dna) => dna.Replace("A", "?").Replace("T", "A").Replace("?", "T").Replace("G", "?").Replace("C", "G").Replace("?", "C");
    }
    public class JohnMeeting
    {
        public static string Meeting(string s) => string.Concat(s.ToUpper().Split(';').Select(x => $"({x.Split(":")[1]}, {x.Split(":")[0]})").OrderBy(x => x));
    }
    public static class OrderTheString
    {
        public static string Order(string words)
        {
            var res = new string[words.Split(' ').Length];
            var arr = words.Split(' ');
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if (Char.IsDigit(arr[i][j])) res[int.Parse(arr[i][j].ToString()) - 1] = arr[i];
                }
            }
            string str = "";
            foreach (var val in res) str += $" {val}";
            return str.Trim();
        }
    }
    public class StockList
    {
        //НЕ ПРОХОДИТ ВСЕ ТЕСТЫ
        public static string stockSummary(string[] art, string[] ltr)
        {
            string[] count = new string[ltr.Length];
            string letters = string.Concat(ltr);
            var arr = art.Where(x => letters.Contains(x[0])).ToArray();

            for (int i = 0; i < ltr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                    if (ltr[i] == arr[j][0].ToString())
                        for (int l = 0; l < arr[j].Length; l++)
                            if (Char.IsDigit(arr[j][l]))
                            {
                                if (l == arr[j].Length - 1) count[i] = $"{count[i]}{arr[j][l]}|";
                                else count[i] += arr[j][l];
                            }
            int[] intCount = new int[count.Length];
            for (int i = 0; i < count.Length; i++)
            {
                string[] ccc = count[i].Split('|').ToArray();
                for (int j = 0; j < ccc.Length - 1; j++) intCount[i] += int.Parse(ccc[j]);
            }
            string str = string.Concat(ltr.Select((x, i) => $"({x} : {intCount[i]}) - "));
            return str.Substring(0, str.Length - 3);
        }
    }
    public class Stringing
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            string str = "";
            for(int i = 0; i < word.Length; i++)
            {
                if(word.Substring(0,i).Contains(word[i]) || word.Substring(i + 1, word.Length - i - 1).Contains(word[i])) str += ")";
                else str += "(";
            }
            return str;
        }
    }
    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++) if (a.Contains((int)Math.Sqrt(b[i])) == false) return false;
            for (int i = 0; i < a.Length; i++) if (b.Contains(a[i] * a[i]) == false) return false;
            if (string.Concat(a.OrderBy(x => x)) != string.Concat(b.Select(x => (int)Math.Sqrt(x)).OrderBy(x => x))) return false;
            return true;
        }
    }
    public class StopSpinningMyWords
    {
        public static string SpinWords(string sen)
        {
            var arr = sen.Split(' ').ToArray();
            for(int i = 0; i < arr.Length; i++)
                if (arr[i].Length >= 5)
                    arr[i] = new string(arr[i].ToCharArray().Reverse().ToArray());
            return string.Concat(arr.Select(x => $"{x} ")).Trim();
        }
    }
    public static class ToTime
    {
        public static string ToTimee(int s) => $"{s / 3600} hour(s) and {s % 3600 / 60} minute(s)";
    }
    public class NokiaKata
    {
        public static string Unlock(string str)
        {
            string res = "";
            str = str.ToLower();
            foreach(var val in str)
            {
                if (val == 'a' || val == 'b' || val == 'c') res += "2";
                else if (val == 'd' || val == 'e' || val == 'f') res += "3";
                else if (val == 'g' || val == 'h' || val == 'i') res += "4";
                else if (val == 'j' || val == 'k' || val == 'l') res += "5";
                else if (val == 'm' || val == 'n' || val == 'o') res += "6";
                else if (val == 'p' || val == 'q' || val == 'r' || val == 's') res += "7";
                else if (val == 't' || val == 'u' || val == 'v') res += "8";
                else if (val == 'w' || val == 'x' || val == 'y' || val == 'z') res += "9";
            }
            return res;
        }
    }
    class NSmallest
    {
        public static int[] FirstNSmallest(int[] arr, int n)
        {
            List<int> min = arr.OrderBy(x => x).Where((x, i) => i < n).ToList();
            return arr.Where(x => min.Remove(x)).ToArray();
        }
    }
    public class StringRepeater
    {
        public static string Repeater(string s, int n)
        {
            string res = "";
            while(n-- > 0) res += s;
            return res;
        }
    }
    public class Kata
    {
        public static string High(string s)
        {
            s = s.ToLower();
            List<string> alphabet = new List<string>() { "a","b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] words = s.Split(" ");
            List<int> scores = new List<int>();
            for (int i = 0; i < words.Length; i++)
                scores.Add(0);
            for(int i = 0; i < words.Length; i++)
                for (int j = 0; j < words[i].Length; j++)
                    scores[i] += alphabet.IndexOf(words[i][j].ToString()) + 1;
            int index = scores.IndexOf(scores.Max(x => x));
            return words[index];
        }
    }
}

