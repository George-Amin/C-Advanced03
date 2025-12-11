using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.BuiltInDelegateExFile
{
    public static class BuiltInDalegate
    {
        public static bool CheckPositive(int numToCkeck)
        {
            return numToCkeck > 0;
        }
        public static string CastNumberToString(int numToString)
        {
            return numToString.ToString();
        }
        public static void PrintHi()
        {
            Console.WriteLine("Say ,Hi");
        }
        public static void SayHiToName(string? name)
        {
            Console.WriteLine("Hi ," + name);
        }

    }
}
