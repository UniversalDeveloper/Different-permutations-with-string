using System;

namespace WordComb{
    class Program {
            public static string[] permutOfSymbolInString(String str){
            var resaltArr = new string[30];
            string concatRow;
            int counter = 0;
            char[] strChar = str.ToCharArray();
            for (int i = 0; i < str.Length; i++){
                for (int j = 0; j<str.Length-1; j++){
                    swap(ref strChar[j], ref strChar[j + 1]);                   
                    concatRow = new string(strChar);
                    resaltArr[counter++] = concatRow;
                }
            }
         return resaltArr;
        }
        public static void swap(ref char a, ref char b){
            char temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args){
            permutOfSymbolInString("котe");
            permutOfSymbolInString("кот");
            permutOfSymbolInString("33");
            permutOfSymbolInString("ко");
        }
    }
}
