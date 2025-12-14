using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.ListMethods
{
    public static class HelperMethodsForList<T>
    {
        public static void PrintIn(T[]? ItemToPrint)
        {
            foreach (var item in ItemToPrint)
            {
                Console.WriteLine(item);
            }
        }

    }
}
