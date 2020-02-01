using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // The following is a method called 'Main', which is always the name of the entry point of a C# application
        // Parameters have <TYPE> and <NAME>, which in this case is: String Array as string[] and name as args
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            
            var result = 0.0;

            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"Total grades: {grades.Count}");
            Console.WriteLine($"The average grade is {result:N1}");

            if(args.Length > 0)
            {
                // The following is read as: 'args sub 0'
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
