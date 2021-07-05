using System;
using System.Linq;

namespace WordComb
{
    class Program
    {
        public static string[] permutOfSymbolInString(string str)
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
            char temp = a;
            a = b;
            b = temp;
        }
        public static void wordPermutTest(string str)
        {
            switch (str)
            {
                case "123":
                    string[] expLenTree = new string[] { "213", "231", "321", "312", "132", "123" };
                    string[] actualLenTree = Program.permutOfSymbolInString(str);
                    if (expLenTree.SequenceEqual(actualLenTree))
                    {
                        Console.WriteLine("True for string 123: shows 6 variants of permutations.");
                    }
                    else
                    {
                        Console.WriteLine("False: does not worked for string 123");
                    }
                    break;

                case "1234":
                    string[] expLenFour = new string[] { "2134", "2314", "2341", "3241", "3421", "3412", "4312", "4132", "4123", "1423", "1243", "1234" };
                    string[] actualLenFour = Program.permutOfSymbolInString(str);
                    if (expLenFour.SequenceEqual(actualLenFour))
                    {
                        Console.WriteLine("True for string 1234: shows 12 variants of permutations.");
                    }
                    else
                    {
                        Console.WriteLine("False: does not worked for string 1234");
                    }

                    break;

                case "12345":
                    string[] expLenFive = new string[] { "21345", "23145", "23415", "23451", "32451", "34251", "34521", "34512", "43512", "45312", "45132", "45123", "54123", "51423", "51243", "51234", "15234", "12534", "12354", "12345" };
                    string[] actualLenFive = Program.permutOfSymbolInString(str);
                    if (expLenFive.SequenceEqual(actualLenFive))
                    {
                        Console.WriteLine("True for string 12345: shows 20 variants of permutations.");
                    }
                    else
                    {
                        Console.WriteLine("False: does not worked for string 12345");
                    }

                    break;
            }

        }
        public static void showPermutations(string str)
        {
            var resaltArr = Program.permutOfSymbolInString(str);

            foreach (string s in resaltArr)
            {
                Console.WriteLine(s);
            }

        }
        static void Main(string[] args)
        {
            showPermutations("123");
            wordPermutTest("123");
            showPermutations("1234");
            wordPermutTest("1234");
            showPermutations("12345");
            wordPermutTest("12345");


        }
    }
}
