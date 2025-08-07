using System;

namespace DEPI_Day_04_C_
{
    internal class Program
    {
        //part2 & Q2
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //part1

            #region Problems

            //problem 1):

            // 1. Using new int[size]
            //int[] arr1 = new int[3];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //// 2. Using initializer list
            //int[] arr2 = { 5, 15, 25 };

            //// 3. Using array syntax sugar (same as initializer list)
            //int[] arr3 = new[] { 2, 4, 6 };

            //Console.WriteLine("Array 1:");
            //foreach (var item in arr1) Console.WriteLine(item);

            //Console.WriteLine("Array 2:");
            //foreach (var item in arr2) Console.WriteLine(item);

            //Console.WriteLine("Array 3:");
            //foreach (var item in arr3) Console.WriteLine(item);

            //// Exception --> OutOfRange TO SOLVE : 
            //try
            //{
            //    Console.WriteLine(arr1[3]); // Index out of bounds
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Caught Exception: " + ex.Message);
            //}
            //-----------------------------------------------------------------

            //problem 2):
            //int[] arr1 = { 1, 2, 3 };

            //// Shallow copy (refe copy)
            //int[] arr2 = arr1;

            //arr2[0] = 100;
            //Console.WriteLine("After modify arr2:"); //Affect 
            //Console.WriteLine("arr1[0] = " + arr1[0]); 

            //// Deep copy using Clone
            //int[] arr3 = (int[])arr1.Clone();
            //arr3[0] = 999;

            //Console.WriteLine("After modifying arr3:");
            //Console.WriteLine("arr1[0] = " + arr1[0]); // Unaffected
            //Console.WriteLine("arr3[0] = " + arr3[0]);

            //-----------------------------------------------------------------

            //problem 3

            //int[,] grades = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grades for student {i + 1}:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nGrades Matrix:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Student {i + 1}: ");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //-----------------------------------------------------------------

            //problem 4):

            //int[] arr = { 9, 5, 2, 7, 1 };

            //Console.WriteLine("Original: " + string.Join(", ", arr));

            //Array.Sort(arr);
            //Console.WriteLine("Sorted: " + string.Join(", ", arr));

            //Array.Reverse(arr);
            //Console.WriteLine("Reversed: " + string.Join(", ", arr));

            //int index = Array.IndexOf(arr, 7);
            //Console.WriteLine("Index of 7: " + index);

            //int[] copyArr = new int[5];
            //Array.Copy(arr, copyArr, arr.Length);
            //Console.WriteLine("Copied Array: " + string.Join(", ", copyArr));

            //Array.Clear(arr, 0, arr.Length);
            //Console.WriteLine("Cleared Array: " + string.Join(", ", arr));
            //-----------------------------------------------------------------

            //problem 5):

            //int[] arr = { 10, 20, 30, 40 };

            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            //Console.WriteLine("Using foreach loop:");
            //foreach (int item in arr)
            //    Console.WriteLine(item);

            //Console.WriteLine("Using while loop (reverse):");
            //int j = arr.Length - 1;
            //while (j >= 0)
            //{
            //    Console.WriteLine(arr[j]);
            //    j--;
            //}
            //-----------------------------------------------------------------

            //problem 6

            //int number;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out number) && number > 0 && number % 2 != 0)
            //    {
            //        Console.WriteLine("Valid input: " + number);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Try again.");
            //    }
            //} while (true);
            //-----------------------------------------------------------------

            //problem 7)

            //    int[,] matrix = {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //    Console.WriteLine("Matrix:");
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //            Console.Write(matrix[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //-----------------------------------------------------------------

            //problem 8)

            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //// Using if-else
            //if (month == 1) Console.WriteLine("January");
            //else if (month == 2) Console.WriteLine("February");
            //else Console.WriteLine("... (rest omitted)");

            //// Using switch
            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    default: Console.WriteLine("Invalid month"); break;
            //}
            //-----------------------------------------------------------------

            //problem 9)

            //int[] numbers = { 4, 7, 2, 9, 7 };

            //Array.Sort(numbers);
            //Console.WriteLine("Sorted: " + string.Join(", ", numbers));

            //int indexFirst = Array.IndexOf(numbers, 7);
            //int indexLast = Array.LastIndexOf(numbers, 7);

            //Console.WriteLine($"First Index of 7: {indexFirst}");
            //Console.WriteLine($"Last Index of 7: {indexLast}");

            //-----------------------------------------------------------------

            //problem 10)

            //int[] arr = { 1, 2, 3, 4, 5 };

            //int sumFor = 0;
            //for (int i = 0; i < arr.Length; i++)
            //    sumFor += arr[i];

            //int sumForeach = 0;
            //foreach (int item in arr)
            //    sumForeach += item;

            //Console.WriteLine("Sum using for: " + sumFor);
            //Console.WriteLine("Sum using foreach: " + sumForeach);
            //-----------------------------------------------------------------

            #endregion

            //-------------------------------------------

            #region Quetions


            // Question 1: What is the default value assigned to array elements in C#?
            // Answer:
            // In C#, arrays are automatically initialized with default values depending on the data type.
            // Examples:
            // int → 0
            // bool → false
            // string → null
            // double → 0.0
            // char → '\0'

            //----------------------------------------------------------------------------------

            // Question 2: What is the difference between Array.Clone() and Array.Copy()?
            // Answer:
            // Array.Clone():
            // - Returns a shallow copy of the array.
            // - Returns the result as object, so you need to cast it.
            // - Always copies the entire array.
            // Array.Copy():
            // - Copies elements from one array to another (can be partial).
            // - No return value (void).
            // - Allows specifying source and destination indices and lengths.

            //----------------------------------------------------------------------------------

            // Question 3: What is the difference between GetLength() and Length for multidimensional arrays?
            // Answer:
            // Length:
            // - Returns the total number of elements in the array (rows * columns).
            // GetLength(dimension):
            // - Returns the number of elements in a specific dimension.
            // Example:
            // int[,] arr = new int[3, 4];
            // arr.Length → 12
            // arr.GetLength(0) → 3 (number of rows)
            // arr.GetLength(1) → 4 (number of columns)

            //----------------------------------------------------------------------------------

            // Question 4: What is the difference between Array.Copy() and Array.ConstrainedCopy()?
            // Answer:
            // Array.Copy():
            // - Copies data from one array to another.
            // - No strict checks for exception safety.
            // Array.ConstrainedCopy():
            // - Ensures that the copy is exception-safe.
            // - If any part of the copy fails, the destination array remains unchanged.
            // - Useful in critical or secure code scenarios.

            //----------------------------------------------------------------------------------

            // Question 5: Why is foreach preferred for read-only operations on arrays?
            // Answer:
            // - foreach is safer and avoids modifying elements by mistake.
            // - It prevents index-related errors (e.g., IndexOutOfRangeException).
            // - Code is simpler and easier to read.
            // - Suitable for iterating without needing the index.

            //----------------------------------------------------------------------------------

            // Question 6: Why is input validation important when working with user inputs?
            // Answer:
            // - Prevents invalid data from being processed.
            // - Avoids runtime exceptions like FormatException.
            // - Enhances security and prevents abuse (e.g., injection attacks).
            // - Improves overall program stability and reliability.

            //----------------------------------------------------------------------------------

            // Question 7: How can you format the output of a 2D array for better readability?
            // Answer:
            // - Use Console.Write instead of Console.WriteLine inside inner loop.
            // - Use tab characters (\t) to align columns.
            // Example:
            // Console.Write(array[i, j] + "\t");
            // Console.WriteLine(); // move to the next row

            //----------------------------------------------------------------------------------

            // Question 8: When should you prefer a switch statement over if-else?
            // Answer:
            // - When checking a variable against multiple constant values.
            // - When the logic involves clean and direct cases (like menu options or enums).
            // - switch provides better readability and performance compared to long if-else chains.
            // Avoid using switch for complex conditions (e.g., value > 10).

            //----------------------------------------------------------------------------------

            // Question 9: What is the time complexity of Array.Sort()?
            // Answer:
            // - The time complexity is O(n log n) on average and in the worst case.
            // - Internally, it uses QuickSort, MergeSort, or IntroSort based on the type and .NET version.

            //----------------------------------------------------------------------------------

            // Question 10: Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?
            // Answer:
            // - Both for and foreach are efficient for summing array elements.
            // - foreach is safer and more readable for simple iterations.
            // - for loop provides more control (e.g., access to index).
            // - In terms of performance, the difference is minimal and usually negligible.

            #endregion

            //--------------------------------------------------------------------

            //Part2):
            //Q2): 
            /*
             Enum + User Input
             Define an enum called DayOfWeek with values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.
             Write a program that takes an integer input from the user (1–7) and prints the corresponding day using the enum.
             Use Enum.Parse to convert an integer to an enum value.
             */
            Console.Write("Enter a number between 1 and 7: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber))
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    // Convert integer to corresponding enum value using casting
                    DayOfWeek day = (DayOfWeek)dayNumber;
                    Console.WriteLine($"The day is: {day}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }


            //---------------------------------
            //
            /*
      🧠 Question 3: What happens if the user enters a value outside 1–7?

       ✅ Answer:

            If the user enters a number outside the range of 1 to 7, 
            the code inside the else block will execute and display a message indicating that the input is invalid.
            Without this validation, 
            casting the number directly to an enum may result in displaying an undefined or meaningless value,
            or cause unexpected behavior in the program.
             
             */
        }
    }
}
