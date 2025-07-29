using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace DEPI_day02_Task
{
    internal class Program
    {//problem_4 pointer and reference
        public class point
        {
            public int x;
            public int y;


        }
        static void Main(string[] args)
        {
            #region problems
            ////------------------------------------problem1
            ///Add both single-line and multi-line comments
            #region p-1
            //int x = 10;  single line comment

            /*int y = 20;
            int sum = x + y;        multlineComment
            Console.WriteLine(sum);*/
            #endregion

            ////------------------------------------problem2
            /*Identify and fix the errors in this code snippet:
            int x = "10";
            console.WriteLine(x + y);*/
            #region p-2
            ////1-error in variable y undefined you must defind --> int y;
            ////2-the variable x is intger must have int data not string -> ""
            ////3- the keyword --> console is uncorrect must write => Console the first Carac is.. Capital
            //int x = 10 , y=default;
            //Console.WriteLine(x + y); 
            #endregion

            ////------------------------------------problem3
            /*Declare variables using proper naming conventions to store:
                 Your full name. Your age.  Your monthly salary.  Whether you are a student.*/
            #region p-3
            //string fullName = "TharwatAbdulhamed";
            //int Age = 22;
            //decimal salary = 15_000;
            //bool Student = false; 
            #endregion

            ////------------------------------------problem4 
            //Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object.
            #region p-4
            //point p1; //declare
            //p1 = new point(); //make new object
            //point p2 = new point(); //// Assign point1 to another reference variable
            //p1.x = 5;
            //p2 = p1;
            //Console.WriteLine(p1.x); //5
            //Console.WriteLine(p2.x); //5
            //Console.WriteLine(p1.GetHashCode()); //58225482
            //Console.WriteLine(p2.GetHashCode()); //58225482
            ////both have same hashcode in memory two point reference ==>look the same adderss in heap 
            //p2.x = 4;
            //Console.WriteLine(p1.x); //4
            //Console.WriteLine(p2.x); //4 
            #endregion

            ////------------------------------------problem5
            /*Create a program that calculates the following using variables x = 15 and y = 4:
                o Sum o Differenceo   o Product o Division_result o Remainder */
            //--Sol
            #region p-5
            //int x = 15;
            //int y = 4;

            //int sum = x + y;
            //int difference = x - y;
            //int product = x * y;
            //double division = (double)x / y;  // Cast to double for accurate division
            //int remainder = x % y;

            //Console.WriteLine("x = " + x);
            //Console.WriteLine("y = " + y);
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + difference);
            //Console.WriteLine("Product: " + product);
            //Console.WriteLine("Division Result: " + division);
            //Console.WriteLine("Remainder: " + remainder); 
            #endregion

            ////------------------------------------problem6
            ///Write a program that checks if a given number is both:

            #region p-6
            //Console.Write("Enter a number please !: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 10 && number % 2 == 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number not match the condation.");
            //} 
            #endregion

            ////------------------------------------problem7
            ///Implement a program that takes a double input from the user and casts it to an int.
            //Use both implicit and explicit casting, then print the results.
            #region p-7
            //// Take double input from the user
            //Console.Write("Enter a dec num ex:  1.1: ");
            //double Input = Convert.ToDouble(Console.ReadLine());

            //// Explicit casting: double to int --unsafe casting --> may have overflow
            //int castedToInt = (int)Input;

            //// Implicit casting: int to double  --safe casting no have problem 
            //double castedBackToDouble = castedToInt;

            //// Output 
            //Console.WriteLine("Original double value: " + Input);
            //Console.WriteLine("After explicit cast to int: " + castedToInt);
            //Console.WriteLine("After implicit cast back to double: " + castedBackToDouble); 
            #endregion

            ////------------------------------------problem8
            /*Write a program that: (G01 Bonus, G02 mandatory)
            o Prompts the user for their age as a string.
            o Converts the string to an integer using Parse
            o Checks if the age is valid(e.g., greater than 0). */

            #region p-8
            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();

            //try
            //{
            //    // Convert string to int using Parse
            //    int age = int.Parse(ageInput);

            //    // Check if age is valid
            //    if (age > 0)
            //    {
            //        Console.WriteLine("Your age is valid: " + age);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Age must be greater than 0.");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter a numeric value.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number you entered is too large.");
            //} 
            #endregion

            ////------------------------------------problem9
            ///Write a program that demonstrates the difference between prefix and postfix
            //increment operators using a variable x.
            #region p-9
            //int x;
            //// Postfix increment: x++
            //x = 5;
            //Console.WriteLine("Postfix Increment:");
            //Console.WriteLine("Initial x: " + x); //5
            //Console.WriteLine("Value using x++: " + (x++)); // Use then increment //5
            //Console.WriteLine("Value after x++: " + x);     // Now x is incremented //6

            //Console.WriteLine("---------------------------");

            //// Prefix increment: ++x
            //x = 5;
            //Console.WriteLine("Prefix Increment:");
            //Console.WriteLine("Initial x: " + x); //5
            //Console.WriteLine("Value using ++x: " + (++x)); // Increment then use //6
            //Console.WriteLine("Value after ++x: " + x);     // x is already incremented //6 
            #endregion

            #endregion


            #region Questions

            #region Q-1
            //What is the shortcut to comment and uncomment a selected block of code in Visual
            //Studio ?

            //CTRL + C --> Comment
            //CTRL + U --> UnComment
            #endregion

            #region Q-2
            //Explain the difference between a runtime error and a logical error with examples.
            //-------runtime error 
            //int x = 4 , y = 0 ;
            //Console.WriteLine(x/y); //Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //-------Logic Error
            //int length = 5;
            //int width = 3;

            //// Intended to calculate area, but mistakenly adds
            //int area = length + width;  // Logical error must use * insted of +
            //Console.WriteLine("Area: " + area);  // Output: 8 instead of 15

            #endregion

            #region Q-3
            //Why is it important to follow naming conventions such as PascalCase in C#?
            //iam explain using example
            // Easy to read
            //public class StudentProfile { }

            // // Harder to read
            //  public class studentprofile { }

            #endregion

            #region Q-4
            /*Explain the difference between value types and reference types in terms of memory
                allocation.*/
            //--in value type 
            // 1- know the memory size  , 2-allocate in stack  , 3-ex: enum , struct 
            //--in reference type 
            // 1- un known the memory size , 2-allocate in heap and make reference in stack 
            //3- ex - class , interface , 
            #endregion

            #region Q-5
            //What will be the output of the following code? Explain why:
            //int a = 2, b = 7;
            //   Console.WriteLine(a%b);
            //output : 2 divided by 7 equals 0 with a remainder of 2, because 7 doesn’t fit into 2 even once.
            #endregion

            #region Q-6
            //How does the && (logical AND) operator differ from the & (bitwise AND) operator?
            //Short circut: If the first condition is false, the second condition is not evaluated
            //EXAMPLE : 
            //int a = 5;
            //int b = 10;

            //if (a > 0 && b > 5)
            //{
            //    Console.WriteLine("Both conditions are true.");
            //}
            //long circut : Always evaluates both sides. read all code without stop if get false 
            //to use  write single logic operators -> & , | 
            //int x = 5 , y = 10;
            //if (x > 4 & y > 10)
            //{
            //    Console.WriteLine("in this code first value return flase not stop bur write second value --> Y");
            //}
            #endregion

            #region Q-7
            //Why is explicit casting required when converting a double to an int?
            //--> because A double (e.g., 5.78) has a fractional part 0.78, while an int only stores whole numbers --> 5.
            #endregion

            #region Q-8
            //What exception might occur if the input is invalid and how can you handle it
            //--> FormatException
            // occur when add string insted of int value : ex
            //int x = 0;
            //Console.WriteLine("please enter the intger value");
            //var intvalue = int.Parse(Console.ReadLine());
            //if enter this : tharwat --> return 
            //Unhandled exception. System.FormatException: Input string was not in a correct format.
            #endregion

            #region Q-9
            //Given the code below, what is the value of x after execution? Explain why
            //int x = 5;
            //int y = ++x + x++;
            // the intial value of x is 5
            // in y : first take the same value of x with increamnt +1  = 6
            // than x++ print than increamnt = 6 in run code after = 7 
            // y =( (5+1) + 6) == 12 
            //Console.WriteLine(x); //7 
            //Console.WriteLine(y); //12
            #endregion

            #endregion

        }
    }
}



