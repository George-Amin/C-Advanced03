using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.Example02
{
    internal static class SortingAscOrDesc

    {
        public static bool SortingAsc(int x, int y)
        {
            return x > y;
        }

        public static bool SortingDesc(int x, int y)
        {
            return x < y;
        }



        public static bool SortingAsc(string? x, string? y)
        {
            return x?.Length > y?.Length;
        }

        public static bool SortingDesc(string? x, string? y)
        {
            return x?.Length < y?.Length;
        }


        public static void PrintNums<T>(T[] n)
        {
            foreach (T i in n)
            {
                Console.WriteLine(i);
            }
        }
  
    }
}
