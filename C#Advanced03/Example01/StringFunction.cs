using C_Advanced03.Example02;
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
            // "function will return the counter of chars if upperCase"
            int Counter = 0;
            //if (LoweOrUpper)
            //{
                if (!string.IsNullOrWhiteSpace(str)) // without ! will return true if there is null or white Space
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (char.IsUpper(str[i]))
                        {
                            Counter++;
                        }
                    }

                }
            //}
            //else
            //{
            //    if (!string.IsNullOrWhiteSpace(str)) // without ! will return true if there is null or white Space
            //    {
            //        for (int i = 0; i < str.Length; i++)
            //        {
            //            if (char.IsLower(str[i]))
            //            {
            //                Counter++;
            //            }
            //        }

            //    }

            //}
            return Counter;
        }

        // need to make the delegate to refer to two functions

        public static int GetCountOfLowerCaseChar(string? str)
        {
            // "function will return the counter of chars if upperCase"
            int Counter = 0;
            if (!string.IsNullOrWhiteSpace(str)) // without ! will return true if there is null or white Space
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                    {
                        Counter++;
                    }
                }

            }
            return Counter;
        }

    }
}
