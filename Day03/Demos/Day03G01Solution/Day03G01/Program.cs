using System;

namespace Day03G01
{
    internal class Program
    {
        //public static void Print<T>(T item) // tempelate
        //{
        //    Console.WriteLine(item);
        //}
        //public static void Print1(object item) // Object
        //{
        //    // Defensive code
        //    Console.WriteLine(item);
        //}
        static void Main()
        {
            #region Casting Problems
            // Valid/Invlaid casting
            //string S = "7";
            //string S = "Ali";
            //int X = int.Parse(S);
            //int X = Convert.ToInt32(S);
            //Console.WriteLine(X);//7 //System.FormatException 
            #endregion

            #region TryParse
            ////tryparse
            //// true  false  
            //// No exception
            //string S = "ali";
            ////int X;
            //bool flag = int.TryParse(S, out int X);
            //bool flag01 = bool.TryParse(S, out bool X01);
            //// true    7
            //// false    default value of x >> 0
            //Console.WriteLine(flag);
            //Console.WriteLine(X);
            #endregion

            #region Object
            //// object 
            //// ref type 
            //// object

            //// 2002 : Object 
            //// parent to all datatypes
            //// waht's parent ?
            //// parent to refer to my childs
            //// Animal : Dog , Cat , Lion
            //// Animal = new Animal();
            //// animalk is an animal
            //// Animal = new cat();
            //// cat is an animal
            //// Ref refer to object of my type + any type inherit from my type

            //// 2002-2005
            //// Generics 
            //// object :1-  Generics alternative

            ////// version Generic
            ////Print<int>(4);
            ////Print<string>("ali");
            ////Print<char>('a');
            ////// version object
            ////Print(4); // Boxing : memory destructive
            ////Print("ali");
            ////Print('a');

            //// 2- set of behaviors/functions 
            //// should be inherited
            //// parent : inherit childs his behaviors
            //// 1- ToString(); //default : NS.DT >> override
            //// 2- GetHashCode(); //generate code uniqie (based on its address memory)
            //// Hash_based collections (Dictionary,HashSets)
            //// override : based on state / values >> Real usage
            //// 3- Equals(obj) : Comapare (Equality) / address
            //// override compare based on state
            //// 4- GetType() : type og object

            //// Parent to all Datatypes 
            //// Class view ?

            //object O1;
            ////declare ref of type object, refer to null
            ////ClR allocate 4 bytes for ref "O1" at stack(uninitialized)
            ////CLR allocate 0 bytes at heap
            //// ref "O1" refer to instance of type object or type? (ALL) inherit from him

            //O1 = "ali";
            //O1 = 6;

            ////GethashgCode : generate code based on its address(Unique)>> Will Change
            ////// Hashing >> self

            //O1 = new object();
            //Object O2 = new Object();
            //Console.WriteLine(O1.GetHashCode()); //58225482
            //Console.WriteLine(O2.GetHashCode()); //54267293
            //Console.WriteLine();
            //O2 = O1;
            //Console.WriteLine(O1.GetHashCode()); // 58225482
            //Console.WriteLine(O2.GetHashCode()); // 58225482 
            #endregion

            #region String Vs StringBuilder
            // string //Ref
            //string Name;
            //declare ref of type string, refer to null
            //ClR allocate 4 bytes for ref "Name" at stack(uninitialized)
            //CLR allocate 0 bytes at heap
            // ref "Name" refer to instance of type string 

            //Name = new string("Ali"); // 3*2 = 6 bytes
            // Clr allocate required bytes (6 bytes)
            // initializa with default value ' ' (space)
            // call user defined ctor ("Ali")
            // assign ref

            //Name = "Ali"; // syntax sugar
            //Console.WriteLine(Name);
            //Console.WriteLine(Name.GetHashCode());//-1961277083
            //string Name02 = "Ali";
            //Console.WriteLine(Name02); // Ali
            //Console.WriteLine(Name02.GetHashCode());//-1961277083
            ////optimize memory + Compare == >> self
            //// string interning // intern pool : inside heap

            //string N1 = "Abdo";
            //Console.WriteLine(N1); //abdo
            //Console.WriteLine(N1.GetHashCode()); 
            //string N2 = "Shaaban";
            //Console.WriteLine(N2);//shaaban
            //Console.WriteLine(N2.GetHashCode());

            //Console.Clear();
            //N2 = N1;
            //Console.WriteLine(N1); //abdo
            //Console.WriteLine(N1.GetHashCode()); //68899
            //Console.WriteLine(N2); // abdo
            //Console.WriteLine(N2.GetHashCode()); //68899
            //N1 = "Ismail";
            //Console.WriteLine(N2);// Ismail  // Abdo

            //Console.Clear();
            //// part 03
            //string Msg = " Hi ";
            //Console.WriteLine(Msg); // Hi 
            //Console.WriteLine(Msg.GetHashCode());// 78979
            //// Modify :
            //Msg += " Sharks ";
            //Console.WriteLine(Msg); // Hi Sharks
            //Console.WriteLine(Msg.GetHashCode());// 1234

            //// String builder 
            //// string alternative for text need modification
            //// StringBuilder >> Class / REf type
            //// Mutable type : can change my value
            //// intrnally linkedlist : add / modify 
            //StringBuilder SB;
            //SB = new StringBuilder("Hi");
            //Console.WriteLine(SB); // Hi 
            //Console.WriteLine(SB.GetHashCode());// 78979

            //SB.Append("Sharks");
            //Console.WriteLine(SB); // Hi sharks
            //Console.WriteLine(SB.GetHashCode());// 78979 
            #endregion

            #region string formatting
            //// string formatting
            //// res : 10 + 5 = 15
            //int X = 10; int Y = 5;

            //// unrecommended
            //////Concat : + Operator > overloaded to Concat function 
            ////string Msg = "res : " + X + " + " + Y + " = " + (X + Y);
            ////Console.WriteLine(Msg);
            //////intermediate object 5 (4  + 1 Final result)
            ////// result output
            /////

            ////// Composite formatting ? rEadable / final output
            ////string Msg = string.Format("res : {0} + {1} = {2}", X, Y, (X + Y));
            ////Console.WriteLine(Msg);

            ////Highly recommended
            //////string interpolation C# 7.0
            ////// ES 6  // $ `   `
            ////// $ : manipulation operator
            ////string Msg = $"res : {X} + {Y} = {X + Y}";
            ////Console.WriteLine(Msg); 
            #endregion

            #region Built_in functions
            //// String (Immutable)
            //string name = "Abdulrahman";
            //Console.WriteLine(name.ToUpper());             // ABDULRAHMAN
            //Console.WriteLine(name.Substring(0, 5));       // Abdul
            //Console.WriteLine(name.Replace("Abdul", "Mr")); // Mrrahman
            //Console.WriteLine(name.Contains("rah"));       // True
            //Console.WriteLine(name.Length);                // 11

            //// StringBuilder (Mutable)
            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(" World");
            //sb.Replace("World", "C#");
            //sb.Insert(0, "Say: ");
            //sb.Remove(0, 5);
            //Console.WriteLine(sb.ToString());              // : Hello C#
            //Console.WriteLine("Length: " + sb.Length);     // 10 
            #endregion

            #region Conditional statements
            ////If statement
            //Console.WriteLine("Enter month number at first quarter : ");
            ////int MonthNumber = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out int MonthNumber);
            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Feb");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("Mar");
            //else
            //    Console.WriteLine("not in first quarter");


            ////switch statement
            //Console.WriteLine("Enter the month");
            //int MonthNumber = int.Parse(Console.ReadLine());
            ////int.TryParse(Console.ReadLine(), out int MonthNumber);
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Not in Q01");
            //        break;
            //}
            //////jump >> Switch on var of type numeric >> equality :
            ////// Compiler Gernerate Jump table 
            ////// Jump table ?
            ////// Get in one step
            ////// internally hash table >> One step >> Key - Valu pair
            ////// search : dll >> link library >> optimized Code(Release Mode)
            ////// IL spy : assembly file >> Hash table 
            #endregion

            #region Conditional Statements - part02
            //condition on string >> scenarios NO >>>
            //1 - <= 5 >>> if statement win
            //2 - > 5 >>> switch
            //Dev Experience

            //Console.WriteLine("Please Enter Your Name");
            //string Name = Console.ReadLine();
            //if (Name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (Name == "Ali")
            //    Console.WriteLine("Hello Ali");
            //else if (Name == "Esraa")
            //    Console.WriteLine("Hello Esraa");
            //else if (Name == "Mai")
            //    Console.WriteLine("Hello Mai");

            //string Name1 = Console.ReadLine();
            //switch (Name1)
            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("Hello Ali");
            //        break;
            //    case "Esraa":
            //        Console.WriteLine("Hello Esraa");
            //        break;
            //    case "Mai":
            //        Console.WriteLine("Hello Mai");
            //        break;
            //}

            // Self : 
            // .rdata section, Switch evolution in C# versions , where upperhand to c# 
            #endregion
        }
    }
}
