using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the numeric score? "); //displays text to ask for user input
            double score = Convert.ToDouble(Console.ReadLine()); //converts user text to double variable named score

            switch(score) //switch statement to determine the letter grade of variable score
            {
                case >= 89.5: //determines if score meets the neceassary score for an A
                    Console.WriteLine("The letter grade for score " + score + " is: A"); //displays text of the letter grade
                    break; //breaks from switch statement
                case >= 79.5: //determines if score meets the neceassary score for an B
                    Console.WriteLine("The letter grade for score " + score + " is: B"); //displays text of the letter grade
                    break; //breaks from switch statement
                case >= 69.5: //determines if score meets the neceassary score for an C
                    Console.WriteLine("The letter grade for score " + score + " is: C"); //displays text of the letter grade
                    break; //breaks from switch statement
                case >= 59.5: //determines if score meets the neceassary score for an D
                    Console.WriteLine("The letter grade for score " + score + " is: D"); //displays text of the letter grade
                    break; //breaks from switch statement
                default: //if the score does not meet any of the cases, it will default to an F
                    Console.WriteLine("The letter grade for score " + score + " is: F"); //displays text of the letter grade
                    break; //breaks from switch statement
            }

            Console.ReadLine();
        }
    }
}
