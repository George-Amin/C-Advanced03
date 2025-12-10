using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.Examples03
{

    public static class FilterLists<T>
    {
        public static List<int> OddNums(List<int> listOdd)
        {
                List<int> listToRetirn = new List<int>();
            if (listOdd is not null && listOdd.Count > 0)
            {


                for (int i = 0; i < listOdd.Count; i++)
                {

                    if (listOdd[i] % 2 == 0)
                    {
                         listToRetirn.Add(listOdd[i]);
                    }
                }
            }
            return listToRetirn;
        }
    }
}
