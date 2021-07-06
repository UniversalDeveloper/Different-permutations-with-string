using System;
using System.Linq;

namespace WordComb
{
    class Program
    {
        private const string _123 = "213,231,321,312,132,123";
        private const string _1234 = "2134,2314,2341,3241,3421,3412,4312,4132,4123,1423,1243,1234";
        private const string _012345 = "102345,120345,123045,123405,123450,213450,231450,234150,234510,234501,324501,342501,345201,345021,345012,435012,453012,450312,450132,450123,540123,504123,501423,501243,501234,051234,015234,012534,012354,012345";
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
        public static void wordPermutTest(string str, string[] actualRes)
        {
            var actualStr = string.Join(",", actualRes);

            if (str.SequenceEqual(actualStr))
            {
                Console.WriteLine("True. Prmutations are correct." + actualStr);
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
            wordPermutTest(_123, permutOfSymbolInString("123"));
            wordPermutTest(_1234, permutOfSymbolInString("1234"));
            wordPermutTest(_012345, permutOfSymbolInString("012345"));
        }
    }
}
