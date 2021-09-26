using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects._1
{
    class program
    {
        public static void runProgram(string[] args)
        {
            Console.WriteLine("This is program 1. Find PI to the Nth Digit.");
            Console.Write("Enter N:");


            try
            {
                int N = Int32.Parse(Console.ReadLine());
                if (N > 15)
                {
                    Console.WriteLine("N is too much. Will display N = 15");
                    Console.WriteLine("{0:f15}", Math.PI);
                } 
                else
                {

                    string formatString = String.Concat("{0:F", N, "}");

                    Console.WriteLine(formatString, Math.PI);
                }
            } 
            catch (FormatException)
            {
                Console.WriteLine("Could not parse input to an integer");
            }
            
            
        }
    }
}
