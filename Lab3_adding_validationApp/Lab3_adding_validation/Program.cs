using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_adding_validation
{
    internal class 
        Program
    {
            static void Main()
            {
            int num = 1;
            int rem;
            var validInput = false;
                
            while (!validInput)
            { 
                Console.WriteLine("Please enter a number between 1 and 100.");
                num = Convert.ToInt32(Console.ReadLine());

                validInput = num >= 1 && num <= 100;

                if(!validInput)
                {
                    Console.WriteLine("The number you entered is: " + (num) + " but needs to be between 1 and 100!!");
                }
                }
                try
                {
                    rem = num % 2;
         
                if ((rem == 0) && (num < 25))
                {
                    Console.WriteLine("{0} is an even number and less than 25.", num);
                }
                else if ((rem == 1) && (num > 60))
                { 
                    Console.WriteLine("{0} is odd.", num);
                }
                else if ((rem == 1) && (num <= 100))
                {
                    Console.WriteLine("{0} is odd.", num);
                }
                else if ((rem == 0) && (num >= 60))
                {
                    Console.WriteLine("{0} is even.", num);
                }
                else if ((rem == 0) && (num >= 26 && num <= 60))
                {
                    Console.WriteLine("Even", num);
                }  
                }
                catch (Exception ex)
                {
                {
                    Console.WriteLine("Please try again.");
                }
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
