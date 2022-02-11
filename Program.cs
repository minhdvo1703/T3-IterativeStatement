using System;

//Minh Vo
//Tech Assignment #3 - Using Iterative Statements
//This program is used to convert CAD to USD values
//02/10/2022
namespace T3_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.WriteLine("Enter a value in CAD: ");

            // Using try-catch to validate user input
            try {
                
                string cad = Console.ReadLine(); // This variable stores data from user input
                decimal value_cad = decimal.Parse(cad); // This variable will be used in iterative statements and is parsed as an integer

                //Storing values to do the conversion
                decimal CAD = 0m;
                decimal USD = 0.00m;
                decimal conversion = 0.792367m;

                //Check if the input is between 5 and 25, or ask user to enter again
                while ((value_cad) < 5 || (value_cad) > 25)
                {
                    Console.WriteLine("Try again! The value entered should be between 5 and 25");
                    cad = Console.ReadLine();
                    value_cad = decimal.Parse(cad);
                }

                // Increment CAD shown in each row if the value is between 5 and 25 amd cannot exceed 200
                Console.WriteLine("The CAD Increment Value = " + value_cad.ToString());
                Console.WriteLine("CAD   US$");
                while (CAD <= 200)
                {
                    USD = CAD * conversion;
                    Console.WriteLine("${0}   ${1}", CAD,Math.Round(USD,2));
                    CAD += value_cad;
                }

            } 
            catch {
                Console.WriteLine("Try again! The value entered should be between 5 and 25");
                Console.WriteLine("Please enter a valid number");
                Console.ReadKey(true);
            }
        }
    }
}
