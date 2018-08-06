using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(rotLeft(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13));
            Console.ReadKey();
        }
        public static int[] rotLeft(int[] a, int d)
        {
            if (d == a.Length)
            {
                return a;
            }
            //create new array with same length 
            var newArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i + d > a.Length - 1)
                {
                    newArr[i] = a[i + d - a.Length];
                }
                else
                {
                    newArr[i] = a[i + d];
                }
            }

            return newArr;
        }

        public static void checkMagazine(string[] magazine, string[] note)
        {
            var result = true;
            var noteDic = ConvertStringArrayToDictionary(note);
            var magazineDic = ConvertStringArrayToDictionary(magazine);

            foreach (var kvp in noteDic)
            {
                if (!magazineDic.ContainsKey(kvp.Key))
                {
                    result = false;
                    break;
                }
                if (magazineDic[kvp.Key] < kvp.Value)
                {
                    result = false;
                    break;
                }
            }
            Console.Write(result ? "Yes" : "No");
        }

        public static Dictionary<string, int> ConvertStringArrayToDictionary(string[] array)
        {
            var noteDic = new Dictionary<string, int>();
            for (int i = 0; i < array.Length; i++)
            {
                var word = array[i];
                if (noteDic.ContainsKey(word))
                {
                    noteDic[word]++;
                }
                else
                {
                    noteDic.Add(word, 1);
                }
            }
            return noteDic;
        }

        public static string CheckBalancedBracket(string input)
        {
            var stack = new Stack<string>();
            var result = "YES";
            for (int k = 0; k < input.Length; k++)
            {
                var newValue = input[k].ToString();
                var match = true;
                var current = stack.Count == 0 ? null : stack.Peek();

                if (current != null)
                {
                    switch (current)
                    {
                        case "{":
                            if (newValue == "]" || newValue == ")")
                            {
                                match = false;
                            }
                            break;
                        case "[":
                            if (newValue == "}" || newValue == ")")
                            {
                                match = false;
                            }
                            break;
                        case "(":
                            if (newValue == "]" || newValue == "}")
                            {
                                match = false;
                            }
                            break;
                    }
                }

                stack.Push(newValue);

                if (!match)
                {
                    result = "NO";
                    break;
                }
            }
            return result;
        }
        public static string CheckBalancedBrackets(string input)
        {
            var result = ""; 

            result = CheckBalancedBracket(input);

            return result;
        }


    }
}
