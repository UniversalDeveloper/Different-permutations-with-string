using System;
using System.Linq;

namespace WordComb
{
    class Program
    {
        public static string[] permutStr(string str)
        {
            var len = str.Length;
            int counter = 0;
            var strChar = str.ToCharArray();
            var resaltArr = new string[len * (len - 1)];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    swap(ref strChar[j], ref strChar[j + 1]);
                    var concatRow = new string(strChar);
                    resaltArr[counter++] = concatRow;
                }
            }
            return resaltArr;
        }
        public static void swap(ref char a, ref char b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        public static string permutTest(string str)
        {
            var actualRes = permutStr(str);
            var expectLen = str.Length * (str.Length - 1);
            if (expectLen == actualRes.Length)
            {
                for (int i = 0; i < actualRes.Length; i++)
                {
                    for (int j = 0; j < actualRes.Length; j++)
                    {
                        if (i == j) continue;
                        if (actualRes[i] == actualRes[j])
                        {
                            return "False: Repeating element in array.";
                        }
                        else if (actualRes[i].Length != str.Length)
                        {
                            var el = actualRes[i].Length;
                            return "False: The length of the element does not match the  length of the input string.";

                        }

                    }
                }
            }
            else
            {
                return "False:" + str + " expected length " + expectLen + ", actual length " + actualRes.Length; ;
            }
            return "Pass. For " + str + ": expected length " + expectLen + ", actual length " + actualRes.Length;
            
        }
        public static void showPermutArr(string str)
        {
            var resArr = permutStr(str);

            foreach (string s in resArr)
            {
                Console.WriteLine(s);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(permutTest("123"));
            Console.WriteLine(permutTest("1234"));
            Console.WriteLine(permutTest("012349"));
            Console.WriteLine(permutTest("0123456789"));

        }
    }
}
