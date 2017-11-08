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
            Console.WriteLine("Please enter your calculation.");
            Console.WriteLine("Seperate the items by spaces.");
            Console.WriteLine("Example: '4 + 12 * 2' will equal 32");
            ParseInput parse = new ParseInput();
            do
            {
                string x = Console.ReadLine();

                parse.ParseUInput(x);
                var output = (parse.DoMath(parse.holding, parse.holdingChar));
                Console.WriteLine(output.ToString());
                Console.ReadLine();
            } while (true);

        }
    }
}
