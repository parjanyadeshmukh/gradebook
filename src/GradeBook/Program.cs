using System;

using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Parjanya's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The Name of the Book is {book.Name}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter }");

        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("Enter the grades or q to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("**");
                }

            }
        }

        static void OnGradeAdded(object sender,EventArgs e)
        {
            System.Console.WriteLine("Grade was added");
        }
    }
}
