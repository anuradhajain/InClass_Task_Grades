using System;

namespace InClass_Age_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Taking user input for marks
                Console.WriteLine("Enter your marks in DIS Class between 0 and 100 ");
                string input = Console.ReadLine(); // reading from console
                int marks = int.Parse(input); // Parsing user input

                Cal_grade(marks); // calling the Cal_grade function

                // exit statement
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);

            } // end of try

            // If error occurs in try block, catch block is executed. Else it is not executed
            catch
            {
                Console.WriteLine("Please enter a valid input next time");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // end of catch

        } // end of main

        // Defining Cal_grade method
        private static void Cal_grade(int marks)
        {
            // calculate the grade based on the conditions in the syllabus
            // A series of if, else if and else statements to perform the task
            if (marks >= 95 && marks <= 100)
            {
                Console.WriteLine("The Letter grade is A+" ); // Displaying the results to the console

            } // end of if (grade >= 95 && grade < 100)

            else if (marks >= 90 && marks < 95)
            {
                Console.WriteLine("The Letter grade is A"); // Displaying the results to the console
            }

            else if (marks >= 87 && marks < 90)
            {
                Console.WriteLine("The Letter grade is A-"); // Displaying the results to the console
            }

            else if (marks >= 84 && marks < 87)
            {
                Console.WriteLine("The Letter grade is B+"); // Displaying the results to the console
            }

            else if (marks >= 80 && marks < 84)
            {
                Console.WriteLine("The Letter grade is B"); // Displaying the results to the console
            }

            else if (marks >= 77 && marks < 80)
            {
                Console.WriteLine("The Letter grade is B-"); // Displaying the results to the console
            }

            else if (marks >= 74 && marks < 77)
            {
                Console.WriteLine("The Letter grade is C+"); // Displaying the results to the console
            }

            else if (marks >= 70 && marks < 74)
            {
                Console.WriteLine("The Letter grade is C"); // Displaying the results to the console
            }

            else if (marks >= 67 && marks < 70)
            {
                Console.WriteLine("The Letter grade is C-"); // Displaying the results to the console
            }

            else if (marks >= 63 && marks < 67)
            {
                Console.WriteLine("The Letter grade is D+"); // Displaying the results to the console
            }

            else if (marks >= 60 && marks < 63)
            {
                Console.WriteLine("The Letter grade is D"); // Displaying the results to the console
            }

            else if (marks >= 0 && marks < 60)
            {
                Console.WriteLine("The Letter grade is F"); // Displaying the results to the console
            }

            else
            {
                Console.WriteLine("Please enter a number between 0 and 100");
            }
        } // end of Cal_grade

    } //end of class
} // end of namespace
