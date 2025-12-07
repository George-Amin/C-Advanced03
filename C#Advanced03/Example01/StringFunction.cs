using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.Example01
{
    internal static class StringFunction
    {
        public static int GetCountOfUpperCaseChar(string? str)
        {
            // function will return the counter of chars if upperCase
            int Counter = 0;
            if (!string.IsNullOrWhiteSpace(str)) // without ! will retnr true if there is null or white Space
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                    {
                        Counter++;
                    }
                }

            }
            return Counter;
        }

    }
}
