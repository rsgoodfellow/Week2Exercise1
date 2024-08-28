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
            Console.Write("What is the numeric score? ");
            double score = Convert.ToDouble(Console.ReadLine());

            switch(score)
            {
                case >= 89.5: 
                    Console.WriteLine("The letter grade for score " + score + " is: A");
                    break;
                case >= 79.5:
                    Console.WriteLine("The letter grade for score " + score + " is: B");
                    break;
                case >= 69.5:
                    Console.WriteLine("The letter grade for score " + score + " is: C");
                    break;
                case >= 59.5:
                    Console.WriteLine("The letter grade for score " + score + " is: D");
                    break;
                default:
                    Console.WriteLine("The letter grade for score " + score + " is: F");
                    break;
            }

            Console.ReadLine();
        }
    }
}
