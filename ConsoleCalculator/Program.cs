using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers you would like to caluclate.");
            Console.WriteLine("Seperate the numbers by spaces.");
            string input = (Console.ReadLine());
            string[] parsedInput = input.Split(' ');
            foreach (string x in parsedInput)
            {
                try
                {
                    int number = Int32.Parse(x);
                    Console.Write("{0} ", number);
                }
                catch(System.FormatException ex1)
                {
                    try
                    {
                        long number = long.Parse(x);
                        Console.Write("{0} ", number);
                    }
                    catch (System.FormatException ex2)
                    {
                        double number = double.Parse(x);
                        Console.Write("{0} ", number);
                    }
                    catch (SystemException wtf)
                    {
                        Console.WriteLine("Invalid Entry, what are you trying to do to me?");
                    }
                }
                catch (System.OverflowException exOV)
                {
                    try
                    {
                        long number = long.Parse(x);
                        Console.Write("{0} ", number);
                    }
                    catch (System.FormatException exOV1)
                    {
                        double number = double.Parse(x);
                        Console.Write("{0} ", number);
                    }
                    catch(SystemException wtf)
                    {
                        Console.WriteLine("Invalid Entry, what are you trying to do to me?");
                    }
                }

            }
            Console.Read();

        }
    }
}
