using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class ParseInput
    {
        bool inPeren = false;
        List<string> perenString = new List<string>();
        public List<double> Holding = new List<double>();
        public List<char> HoldingChar = new List<char>();

        //public void Box(string input)
        //{
        //    string[] parsedInput = input.Split(' ');
        //    foreach (string x in parsedInput)
        //    {
        //        try
        //        {
        //            int number = Int32.Parse(x);
        //            Console.Write("{0} ", number);
        //            Holding.Add(number);
        //        }
        //        catch (FormatException)
        //        {
        //            try
        //            {
        //                long number = long.Parse(x);
        //                Console.Write("{0} ", number);
        //               Holding.Add(number);
        //            }
        //            catch (FormatException)
        //            {
        //                double number = double.Parse(x);
        //                Console.Write("{0} ", number);
        //                Holding.Add(number);
        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Invalid Entry, what are you trying to do to me?");
        //            }
        //        }
        //        catch (OverflowException)
        //        {
        //            try
        //            {
        //                long number = long.Parse(x);
        //                Console.Write("{0} ", number);
        //                Holding.Add(number);
        //            }
        //            catch (FormatException)
        //            {
        //                double number = double.Parse(x);
        //                Console.Write("{0} ", number);
        //               Holding.Add(number);
        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Invalid Entry, what are you trying to do to me?");
        //            }
        //        }
        //    }
        //}

        //public void UnBox(List<ValueType> boxedlist)
        //{

        //}

        //public double ParseIt(string input)
        //{
        //    string tempString = null;
        //    string[] stringInputArray = input.Split(' ');
        //    foreach (string str in stringInputArray)
        //    {
        //        if ()
        //            tempString = StringPeren(str);
        //    }

        //}

        public void Parseinput(string input)
        {
            string[] parsedInput = input.Split(' ');
            foreach (string x in parsedInput)
            {
                if(string.IsNullOrEmpty(x))
                { continue; }
                try
                {
                    double number = Convert.ToDouble(x);
                    Console.Write("{0} ", number);
                    Holding.Add(number);
                }
                catch(FormatException)
                {
                    try
                    {
                        char character = Convert.ToChar(x);
                        HoldingChar.Add(character);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Please edit your input to match the correct format.");
                    }
                }
            }
        }

        //removes perenthesis and returns a string that should be able to be converted to a double
        //public string[] StringPeren(string input)
        //{
        //    List<string> next = new List<string>();
        //    string tempString = null;
        //    string[] stringInputArray = input.Split(' ');
        //    foreach (string str in stringInputArray)
        //    {
        //        if (inPeren)
        //        {
        //            perenString.Add(str);
        //            continue;
        //        }
        //        if (str.StartsWith("("))
        //        {
        //            builder.Remove(0, 0);
        //            if (!string.IsNullOrEmpty(str))
        //            {
        //                perenString.Add(str);
        //            }
        //            inPeren = true;
        //            continue;
        //        }
        //        if (str.EndsWith(")"))
        //        {
        //            builder.Remove(str.Length, 0);

        //            if (!string.IsNullOrEmpty(str))
        //            {
        //                perenString.Add(str);
        //            }
        //            foreach (string addedString in perenString)
        //            {
        //                tempString += addedString;
        //            }
        //            inPeren = false;
        //            //tempString needs to be math solved and added as a (string)double into next list
        //            continue;
        //        }
        //        next.Add(str);
        //    }

        //    return next.ToArray<string>();
        //}

        public double DoMath(List<double> holdi, List<char> charz)
        {
            int counter = 0;
            double finished = 0;
            foreach (char item in charz)
            {
                if (finished == 0)
                {
                    
                    switch (item)
                    {
                        case '+':
                            finished = holdi[counter] + holdi[counter + 1];
                            counter++;
                            continue;
                        case '-':
                            finished = holdi[counter] - holdi[counter + 1];
                            counter++;
                            continue;
                        case '*':
                            finished = holdi[counter] * holdi[counter + 1];
                            counter++;

                            continue;
                        case '/':
                            finished = holdi[counter] / holdi[counter + 1];
                            counter++;
                            continue;
                    }
                }
                else
                {
                    switch (item)
                    {
                        
                        case '+':
                            finished += holdi[counter +1];
                            counter++;
                            continue;
                        case '-':
                            finished -= holdi[counter +1];
                            counter++;
                            continue;
                        case '*':
                            finished *= holdi[counter +1];
                            counter++;
                            continue;
                        case '/':
                            finished /= holdi[counter +1];
                            counter++;
                            continue;
                    }
                }
            }
            return finished;
        }

        ////takes a string array and converts to double
        //public List<double> ConvertToDoubleList(string[] input)
        //{
        //    List<double> toMath = new List<double>();
        //    foreach (string thing in input)
        //    {
        //        double number = Convert.ToDouble(thing);
        //        toMath.Add(number);
        //    }
        //    return toMath;
        //}
    }
}