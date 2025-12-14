using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03.function_Programming_Paradigm
{
    public static class FPPReturnDelegate
    {

        //public static void SayHi()
        //{
        //    Console.WriteLine("Hi");
        //}

        //public static bool IsPositive(int Number)
        //{
        //    return Number >= 0;
        //}
        //public static string AddCharToString(char[] Word)
        //{
        //    //return string.Concat(Word);
        //    // or
        //    return new string(Word);    
        //}


        public static Action DelegateAction()
        {


            // return delegate as a anonymous method
            // return void method use Action delegate Cuz it has no return type
            //() => for no parameter
            return () => Console.WriteLine("Say hi");
        }


        public static Predicate<int> DelegatePredicate()
        {
            return (n => n >= 0);
           
        }


        public static Func<char[],string> DelegateFunc()
        {
            return ((Word) => string.Concat(Word)/*new string(Word)*/);
        }
    }
}
