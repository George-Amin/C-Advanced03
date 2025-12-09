using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.Example02
{
    // Non-Generic Delegate ....
    // public delegate bool SortingAscOrDescDelegate(int num1, int num2);
    // Generic Delegate ....
    public delegate Tresult SortingAscOrDescDelegate< out Tresult,in T1,in T2>(T1 num1, T2 num2); // delegate is the diff class
    // in for input = parameter
    // out for outPut type = return 
    internal static class SotingAlgorithms <T>
    {
        public static void BobbleSort(T[] arr, SortingAscOrDescDelegate< bool, T,T>? sortingAscOrDesc)
        {
            //if (arr is not null && arr.Length > 0 && sortingAscOrDesc is not null)
            if(arr?.Length>0 && sortingAscOrDesc is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length  - 1-i; j++)
                    {
                        // Delegate
                        if (sortingAscOrDesc(arr[j], arr[j + 1]))
                        {

                            Swap(ref arr[j], ref arr[j + 1]);

                        }
                    }
                }
            }

        }

        private static void Swap(ref T v1, ref T v2)
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;
        }
    }
}
