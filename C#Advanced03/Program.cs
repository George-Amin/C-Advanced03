using C_Advanced03.BuiltInDelegateExFile;
using C_Advanced03.Example01;
using C_Advanced03.Example02;
using C_Advanced03.Examples03;
using C_Advanced03.function_Programming_Paradigm;
using C_Advanced03.ListMethods;
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
            //List<int> result = FilterLists<int>.FindElements(list);
            //foreach (int i in result) { Console.WriteLine(i); }
            //Console.WriteLine(FilterLists<int>.FindElements(list).ToList());

            //List<int> nums = Enumerable.Range(1, 100).ToList();

            //List<int> oddNumbers = FilterLists<int>.FindElements(nums, HelperCkeckConditions.CheckOddNums);

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


            #region Anonymous Methods


            //inline Method without any giving name 

            //Action<>
            //() => for void
            //Action ActionVoidReturn = delegate () { Console.WriteLine("Say ,Hi"); };
            //ActionVoidReturn.Invoke();




            //Action<string?> action = delegate (string? name) { Console.WriteLine("Hi ," + name); };
            //action.Invoke("George");
            //Console.WriteLine(action);




            //Func<int, string> Result = delegate (int numToString) { return numToString.ToString(); } ;
            //string returnResult = Result.Invoke(120);
            //Console.WriteLine(returnResult);

            //Console.WriteLine(returnResult.GetType()); // System.String




            //Predicate<int> numberToConvert = delegate (int numToCkeck) { return numToCkeck > 0; }; // inline method or anonymous
            //bool Result = numberToConvert.Invoke(-1);
            //Console.WriteLine(Result);
            //bool Result1 = numberToConvert.Invoke(1);
            //Console.WriteLine(Result1);



            #region Lambda Expression => ()


            //Action SayHi = () => Console.WriteLine("Hi");
            //SayHi.Invoke();
            ////SayHi();

            //Action<string> SayHiToName = (n) => Console.WriteLine($"Hi  ,{n}");
            //SayHiToName.Invoke("George");

            //SayHiToName("Georgeeee");


            //Console.WriteLine(SayHi);

            //Func<int, int, int> addNumbers = (a, b) => { return a + b; }; // <out int , in int , in int>

            //int result = addNumbers.Invoke(5, 10);
            //Console.WriteLine(result);

            //Predicate<int> CheckOdd = (num) => num % 2 != 0;
            //bool Result = CheckOdd.Invoke(5);

            //Console.WriteLine(Result);


            #endregion


            #endregion


            #region List<> Methods

            List<int> Numbers = new()
            {
               1,58,12,56,2,8,51,845,18485,51,5,18,52,11,1,-8
            };

            List<Employee> ListOfEmployees = new List<Employee>()
            {
                new Employee(){ Id=1, Name="George", Age=30},
                new Employee(){ Id=2, Name="Amin", Age=25},
                new Employee(){ Id=3, Name="Sara", Age=28},
                new Employee(){ Id=4, Name="Lina", Age=22},
                new Employee(){ Id=5, Name="Khalid", Age=35},
            };

            #region Exist()

            //bool Result = Numbers.Exists(Even => Even % 2 == 0); // Like Searching if have any Element match the condition will Return true Else will be false     
            //Console.WriteLine(Result);

            #endregion

            #region Find()
            //int Result = Numbers.Find(n => n == 452); // return the first element that match the condition   if the element not found will return the default value of data type = 0 
            //Console.WriteLine(Result);

            #endregion


            #region FindLast()

            // int Result = Numbers.FindLast(n => n % 2 == 0); // 52 match the condition // return the last element that match the condition   if the element not found will return the default value of data type = 0 

            #endregion

            #region FindIndex()

            //int Result = Numbers.FindIndex(n => n == 11); // return the index of the first element that matches the condition; if not found, return -1


            #endregion

            #region FindLastInxed()

            //int Result = Numbers.FindLastIndex(n => n % 2 == 0);


            #endregion

            #region FindAll()
            //List<int> OddNumbers = Numbers.FindAll(num => num%2 == 1);// return all element that match the condition as List<T> if not found will return empty list

            //Console.WriteLine("Odd Numbers:-");
            //foreach (var item in OddNumbers)
            //{ 
            //    Console.Write(item + " ");
            //}
            //List<int> EvenNumbers = Numbers.FindAll(num => num%2 == 0);// return all element that match the condition as List<T> if not found will return empty list
            //Console.WriteLine("\nEven Numbers:-");
            //foreach (var item in EvenNumbers)
            //{ 
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Foreach()
            //Numbers.ForEach(n => Console.WriteLine(n)); // apply action on each element in the list return type is void

            #endregion


            #region Ex Employee List of methods

            //foreach (var item in ListOfEmployees)
            //{
            //    Console.WriteLine(item);
            //}
            //emps.ForEach(e => Console.WriteLine(e)); //delegate=> action on each employee   

            // make chage in foreach

            //foreach (Employee item in ListOfEmployees)
            //{
            //    item.Id++;
            //    Console.WriteLine(item.Id);
            //}


            //foreach (var i in ListOfEmployees)
            //{

            //    Console.WriteLine(i);
            //}


            #endregion

            #region Remove() - RemoveAll()
            //Numbers.Remove(845); // remove the first occurrence of the specified element from the list
            //Numbers.Remove(18485); // remove the first occurrence of the specified element from the list
            //HelperMethodsForList<int>.PrintIn(Numbers.ToArray());

            //int Result = Numbers.RemoveAll(one => one == 1);
            //////remove all occurrence that match the condition(any emelemnt == 1) => return number of removed elements
            //Console.WriteLine(Result);// 2
            //HelperMethodsForList<int>.PrintIn(Numbers.ToArray()); // make sure any 1 removed and make change in the original list


            #endregion


            #region TrueForAll()
            //bool allPositive = Numbers.TrueForAll(N => N > 0); // check if all elements match the condition; if all match, return true; else false  
            //Console.WriteLine(allPositive);
            //False because -8 is in the list not match the condition
            #endregion


            #endregion


            #region FPP
            //char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            //string Word = FPPReturnDelegate.AddCharToString(chars);

            //Console.WriteLine(Word.GetType());

            //int zero = 0;
            //bool Result = FPPReturnDelegate.IsPositive(zero);
            //Console.WriteLine(Result);
            //int number = 5;
            //bool Result = FPPReturnDelegate.IsPositive(number);
            //Console.WriteLine(Result);

            //int negativeNumber = -3;
            //bool Result = FPPReturnDelegate.IsPositive(negativeNumber);
            //Console.WriteLine(Result);

            //FPPReturnDelegate.SayHi();

            #region Function return function

            //Action a = FPPReturnDelegate.DelegateAction();// just calling it is not working
            //..a is reference from delegate Action Name DelegateAction() function that return delegate Action
            //a.Invoke(); // now it work because we call the returned delegate and invoke it

            //Predicate<int> P = FPPReturnDelegate.DelegatePredicate();
            //bool res = P.Invoke(-5); // false  
            //Console.WriteLine(res);

            //char[] chars = { 'W', 'o', 'r', 'l', 'd' };

            //Func<char[], string> func = FPPReturnDelegate.DelegateFunc();
            //string Result = func.Invoke(chars); // "World"  

            //Console.WriteLine(Result);

            #endregion

            #endregion

        }
    }
}



