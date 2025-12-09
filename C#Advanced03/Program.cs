using C_Advanced03.Example01;
using C_Advanced03.Example02;
using System.Diagnostics;

namespace C_Advanced03
{
    internal class Program
    {
        //public static void Print()
        //{
        //    Console.WriteLine("I am print method");
        //}

        // step 0 = defining a Delegate
        //public delegate int StringFuncDelegate(string? s);
        // new delegate [Class]
        //..reference from this delegate can refer to =>
        // 1. one function or more [pointer To Function]
        // 2. this function maybe static function or not static
        // 3. but these function must be with the same signature of Delegate (parameter List - return Type)

        static void Main(string[] args)
        {
            #region Delegate
            // delegate is class
            // ...use to 
            // 1. Implement function programming  paradigm = make functions return function or send function as a parameter in functions
            // 2. Implement Event-Driven programming Paradigm = Like a trigger function when action fire the event will work
            //Print();
            //int x = Program.Print(); // Invalid
            //var x = Program.Print(); // Invalid

            #region EX01
            //Console.WriteLine("Enter your Name");
            //string Name = Console.ReadLine();
            //string name ="GEORGE";

            //Console.WriteLine(StringFunction.GetCountOfUpperCaseChar(name));

            // Step 1 = Declare for reference from delegate
            //StringFuncDelegate stringFunc; // default = null
            // Step 2 = Initialize Reference  from delegate {Pointer To Function}
            //stringFunc = new StringFuncDelegate(StringFunction.GetCountOfUpperCaseChar);

            // syntax sugar
            //stringFunc = StringFunction.GetCountOfUpperCaseChar;
            //Console.WriteLine(stringFunc);

            // step 3 Use delegate
            // use the Reference to Invoke [Call] the delegate 

            //int WhiteSpace = stringFunc.Invoke("   ");
            //int NameToCount = stringFunc.Invoke("GeorgeEE");
            //int NameToCount01 = stringFunc.Invoke("GeorgeEE");


            //Console.WriteLine(WhiteSpace);
            //Console.WriteLine(NameToCount);
            //Console.WriteLine(NameToCount01);

            // Make the delegate To refer to two functions 
            //step1 declare the delegate
            //StringFuncDelegate stringLowerCase;
            // step 3 initialize reference as a pointer to function
            //stringLowerCase = StringFunction.GetCountOfLowerCaseChar;
            // step 4 invoke 
            //int CounterLowerCase = stringLowerCase.Invoke("goooG");
            //Console.WriteLine(CounterLowerCase); 


            #endregion



            #region  EX02

            int[] nums = { 10, 2, 5, 6, 82, 54 };
            SotingAlgorithms<int>.BobbleSort(nums, SortingAscOrDesc.SortingAsc);
            SortingAscOrDesc.PrintNums(nums);

            Console.WriteLine("/**********************************************/");
            SotingAlgorithms<int>.BobbleSort(nums, SortingAscOrDesc.SortingDesc);
            SortingAscOrDesc.PrintNums(nums);


            #region EX02 Generic delegate
            string[] names = new string[] { "aaa", "cccc", "bbb" };

            SotingAlgorithms<string>.BobbleSort(names, SortingAscOrDesc.SortingDesc);
            SortingAscOrDesc.PrintNums<string>(names);
            #endregion

            #endregion


            #endregion
        }
    }
}



