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
            var temp = a;
            a = b;
            b = temp;
        }
        public static void wordPermutTest(string str)
        {
            var expLenTree = new string[] { "213", "231", "321", "312", "132", "123" };
            var expLenFour = new string[] { "2134", "2314", "2341", "3241", "3421", "3412", "4312", "4132", "4123", "1423", "1243", "1234" };
            var expLenFive = new string[] { "21345", "23145", "23415", "23451", "32451", "34251", "34521", "34512", "43512", "45312", "45132", "45123", "54123", "51423", "51243", "51234", "15234", "12534", "12354", "12345" };
            var actualRes = permutOfSymbolInString(str);

            if (expLenTree.SequenceEqual(actualRes))
            {
                Console.WriteLine("True. Prmutations are correct for string 123 wich length is 3.");
            }
            else if (expLenFour.SequenceEqual(actualRes))
            {
                Console.WriteLine("True. Prmutations are correct for string 1234 wich length is 4.");

            }
            else if (expLenFive.SequenceEqual(actualRes))
            {
                Console.WriteLine("True. Prmutations are correct for string 12345 wich length is 5.");

            }
            else
            {
                Console.WriteLine("False: Prmutations are not correct.");
            }
        }
        public static void showPermutations(string str)
        {
            var resaltArr = permutOfSymbolInString(str);

            foreach (string s in resaltArr)
            {
                Console.WriteLine(s);
            }

        }
        static void Main(string[] args)
        {
            wordPermutTest("123");
            wordPermutTest("1234");
            wordPermutTest("12345");
        }
    }
}
