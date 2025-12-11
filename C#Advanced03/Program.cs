using C_Advanced03.BuiltInDelegateExFile;
using C_Advanced03.Example01;
using C_Advanced03.Example02;
using C_Advanced03.Examples03;
using System.Data;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Xml.Linq;

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

            //int[] nums = { 10, 2, 5, 6, 82, 54 };
            //SotingAlgorithms<int>.BobbleSort(nums, SortingAscOrDesc.SortingAsc);
            //SortingAscOrDesc.PrintNums(nums);

            //Console.WriteLine("/**********************************************/");
            //SotingAlgorithms<int>.BobbleSort(nums, SortingAscOrDesc.SortingDesc);
            //SortingAscOrDesc.PrintNums(nums);


            #region EX02 Generic delegate
            //string[] names = new string[] { "aaa", "cccc", "bbb" };

            //SotingAlgorithms<string>.BobbleSort(names, SortingAscOrDesc.SortingDesc);
            //SortingAscOrDesc.PrintNums<string>(names);
            #endregion

            #endregion


            #region EX03

            //List<int> list = new List<int>() { 1, 2, 8, 6, 3, 74 };
            //List<int> result = FilterLists.OddNums(list);
            //foreach (int i in result) { Console.WriteLine(i); }
            //Console.WriteLine(FilterLists.OddNums(list).ToList());

            //  List<int> nums = Enumerable.Range(1, 100).ToList();

            //List<int> oddNumbers = FilterLists.FindElements(nums, HelperCkeckConditions.CheckOddNums);

            //foreach (int item in oddNumbers)
            //{
            //    Console.Write($"{item} ");
            //}


            //Console.WriteLine("\n-----------Even Numbers-------------");

            //int[] oddNums = FilterLists<int>.FindElements(nums, HelperCkeckConditions.CheckEvenNums).ToArray();
            //HelperCkeckConditions.Prin<int>(oddNums);

            #region generic To get the even number or odd and get the string have more then 4 chars nad less then 4 chars 

            //List<string> names = new List<string>()
            //{
            //    "Georege" , "Amin" , "AA" , "aaa"
            //};

            ////List<string> filterString = FilterLists<string>.FindElements(names, HelperCkeckConditions.CheckLessChars);
            //List<string> filterString = FilterLists<string>.FindElements(names, HelperCkeckConditions.CheckMoreChars);

            //HelperCkeckConditions.Print<string>(filterString.ToArray());

            #endregion

            #endregion




            #endregion

            #region Built In Delegates


            #region Action<T>
            // Action [Non - Generic] => Can refer To Functions take 0 parameter And Must be return void
            // Action<T> Generic => Can be refer to function Take 1 - 16 parameter from any data type and must be return Void 
            // void return type


            //Action ActionVoidReturn = BuiltInDalegate.PrintHi;
            //ActionVoidReturn.Invoke();

            //Action<string> action = BuiltInDalegate.SayHiToName;
            //action.Invoke("George");
            //Console.WriteLine(action);


            #endregion



            #region Func<T,TResult>
            // Func<T , TResult> Generic =>can refer to Function with 0 - 16 parameter from any data type  and return Generic dataType <out TResult>.

            //Func<int, string> Result = BuiltInDalegate.CastNumberToString;
            //string returnResult = Result.Invoke(120);
            //Console.WriteLine(returnResult);

            //Console.WriteLine(returnResult.GetType()); // System.String
            #endregion

            #region Predicate<T>
            //Predicate<T> => can refer to Function Take One parameter Only From Any Data Type And must be return boolean value
            //Predicate<int> numberToConvert = BuiltInDalegate.CheckPositive;
            //bool Result = numberToConvert.Invoke(-1);
            //Console.WriteLine(Result);
            //bool Result1 = numberToConvert.Invoke(1);
            //Console.WriteLine(Result1);

            #endregion



            #endregion





        }
    }
}



