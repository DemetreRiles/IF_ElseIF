/*
Author: Demetre Riles
Date: 1/23/2019
Comments: This C# application asks for user input to determine what letter grade would be received in ISM 4300

*/
using System;


namespace ConditionalStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.WriteLine("Hello! Please enter what grade do you expect to recieve in ISM 4300...");

            // Try and catch block to validate the users input
            try
            {
                // Stores input into varible
                string input = Console.ReadLine();

                // Parses input inside the input variable into an integer
                int grade = int.Parse(input);

                /* IF else statments to test the value in the grade
                  variable to determine what grade would be recived
                */
                if (grade >= 98 && grade <= 100) { Console.WriteLine("You would receive an A+."); }
                else if (grade >= 92 && grade <= 97) { Console.WriteLine("You would receive an A."); }
                else if (grade <= 91 && grade >= 90) { Console.WriteLine("You would receive an A-."); }
                else if (grade <= 89 && grade >= 88) { Console.WriteLine("You would receive a B+."); }
                else if (grade >= 82 && grade <= 87) { Console.WriteLine("You would receive a B."); }
                else if (grade <= 81 && grade >= 80) { Console.WriteLine("You would recive a B-."); }
                else if (grade <= 79 && grade >= 78) { Console.WriteLine("You would receive a C+."); }
                else if (grade >= 72 && grade <= 77) { Console.WriteLine("You would receive a C."); }
                else if (grade <= 71 && grade >= 70) { Console.WriteLine("You would recive a C-."); }
                else if (grade <= 69 && grade >= 68) { Console.WriteLine("You would receive a D+."); }
                else if (grade >= 62 && grade <= 67) { Console.WriteLine("You would receive a D."); }
                else if (grade <= 61 && grade >= 60) { Console.WriteLine("You would recive a D-."); }

                // Tests values in the grade variable to ensure that they are betweem 0-100 
                else if (grade > 100) { Console.WriteLine("Please enter a value between 0 - 100."); }
                else { Console.WriteLine("You would recive a F"); }

                // Ask for user input to exit the program
                Console.WriteLine("Enter any key to exit this program...");
                Console.ReadKey(true);
            }

            catch
            {

                // Catch block for inputs that are not integers
                Console.WriteLine("Please enter an integer value next time.");
                Console.WriteLine("Enter any key to exit this program...");
                Console.ReadKey(true);

            }
        }
    }
}

