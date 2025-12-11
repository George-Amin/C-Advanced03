using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.Examples03
{
    internal static class HelperCkeckConditions
    {
        public static bool CheckEvenNums(int number)
        {
            //if (listOdd[i] % 2 == 0)
            //{
            //    listToRetirn.Add(listOdd[i]);
            //}
            return number % 2 == 0;
        }
        public static bool CheckOddNums(int number)
        {
            //if (listOdd[i] % 2 == 1)
            //{
            //    listToRetirn.Add(listOdd[i]);
            //}
            return number % 2 == 1;

        }

        public static bool CheckMoreChars(string charsOfString)
        {
          return charsOfString.Length >= 4 ;
        }
        public static bool CheckLessChars(string charsOfString)
        {

            return charsOfString.Length < 4 ;
        }
        public static void Print<T>(T[] n)
        {
            foreach (T i in n)
            {
                Console.Write(i + " ");
            }
        }



    }
}
