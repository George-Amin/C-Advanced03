using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.Examples03
{
    public delegate TResult FilterListFuncDelegate<out TResult, in T>(T number);
    //public delegate bool FilterListFuncGelegate(int N)
    public static class FilterLists<T>
    {


        public static List<T> FindElements(List<T> element, FilterListFuncDelegate<bool , T> FilterOddOrEvenFromDelegate)
        {
            List<T> listToRetirn = new List<T>();
            //numbers is not null && numbers.Count > 0
            if ((element?.Count > 0) && FilterOddOrEvenFromDelegate is not null)
            {


                for (int i = 0; i < element.Count; i++)
                {
                    //if (listOdd[i] % 2 == 0)
                    //{
                    //     listToRetirn.Add(listOdd[i]);
                    //}
                    //delegate
                    //if (FilterOddOrEvenFromDelegate(numbers[i]))
                    if (FilterOddOrEvenFromDelegate.Invoke(element[i]))
                    {
                        listToRetirn.Add(element[i]);
                    }
                    ;

                }
            }
            return listToRetirn;
        }
    }
}
