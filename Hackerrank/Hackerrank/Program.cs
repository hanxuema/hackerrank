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
            var text = Console.ReadLine();

          
            Console.ReadKey();
        }

        public static int addOne(int value)
        {
            return value + 1;
        }

        public static void print(string text)
        {
            var value = 0;
            for (int b = 0; b < 1; b++)
            {
                for (int a = 0; a < 2; a++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            value = value + 5;
                        }
                    }
                }
            }
            Console.WriteLine(value);
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

        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
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

        // Complete the whatFlavors function below.
        public static void whatFlavors(int[] cost, int money)
        {
            var output = new StringBuilder(); ;
            var results = CalcWhatFlavors(cost, money);

            foreach (var kvp in results)
            {
                output.AppendLine(string.Format("{0} {1}", kvp.Key, kvp.Value));
            }

            Console.Write(output.ToString());
        }

        public static Dictionary<int, int> CalcWhatFlavors(int[] cost, int money)
        {
            var result = new Dictionary<int, int>();
            for (int i = 0; i < cost.Length; i++)
            {
                var gap = money - cost[i];
                var foundIndex = CheckIfItemInArrayAndReturnIndex(cost, gap, i);
                if (foundIndex >= 0 && i < foundIndex)
                {
                    if (!result.ContainsKey(i + 1))
                    {
                        result.Add(i + 1, foundIndex + 1);
                    }
                }
            }
            return result;
        }

        public static int CheckIfItemInArrayAndReturnIndex(int[] arr, int item, int currentIdx)
        {
            var result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i] && i != currentIdx)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static bool CheckIfItemInArray(int[] arr, int item)
        {
            var result = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    result = true;
                    break;
                }
            }
            return result;
        }


    }
}
