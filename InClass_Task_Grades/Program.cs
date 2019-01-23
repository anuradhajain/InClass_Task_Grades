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
               
                string Letter = Cal_grade(marks); // calling the Cal_grade function
                Console.WriteLine("The Letter Grade is: " + String.Format("{0,10}", Letter));

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
        private static string Cal_grade(int marks)
        {
            // calculate the grade based on the conditions in the syllabus
            // A series of if, else if and else statements to perform the task
            string caculated_letter = " "; 
            if (marks >= 95 && marks <= 100)
            {
                caculated_letter = "A+";
                //return caculated_letter;

            } // end of if (grade >= 95 && grade < 100)

            else if (marks >= 90 && marks < 95)
            {
                caculated_letter = "A";
                //return caculated_letter;
            }

            else if (marks >= 87 && marks < 90)
            {
                 caculated_letter = "A-";
                //return caculated_letter;
            }

            else if (marks >= 84 && marks < 87)
            {
                 caculated_letter = "B+";
                //return caculated_letter;
            }

            else if (marks >= 80 && marks < 84)
            {
                 caculated_letter = "B";
                //return caculated_letter; 
            }

            else if (marks >= 77 && marks < 80)
            {
                 caculated_letter = "B-";
                //return caculated_letter;
            }

            else if (marks >= 74 && marks < 77)
            {
                 caculated_letter = "C+";
                //return caculated_letter;
            }

            else if (marks >= 70 && marks < 74)
            {
                 caculated_letter = "C";
                //return caculated_letter;
            }

            else if (marks >= 67 && marks < 70)
            {
                 caculated_letter = "C-";
                //return caculated_letter;
            }

            else if (marks >= 63 && marks < 67)
            {
                 caculated_letter = "D+";
                //return caculated_letter;
            }

            else if (marks >= 60 && marks < 63)
            {
                 caculated_letter = "D";
                //return caculated_letter;
            }

            else if (marks >= 0 && marks < 60)
            {
                 caculated_letter = " ";
                //return caculated_letter;
            }
            return caculated_letter;

        } // end of Cal_grade

    } //end of class
} // end of namespace
