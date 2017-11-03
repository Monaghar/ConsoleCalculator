using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class Calculate
    {
        #region Adding
        public static int Add(int[] x)
        {
            int y = 0;
            foreach (int i in x)
            {
                y += i;
            }
            return y;
        }

        public static long Add(long[] x)
        {
            long y = 0;
            foreach (int i in x)
            {
                y += i;
            }
            return y;
        }

        public static double Add(double[] x)
        {
            double y = 0;
            foreach (int i in x)
            {
                y += i;
            }
            return y;
        }

        #endregion
        #region Subtracting
        public static int Subtract(int[] x)
        {
            int y = x[0];
            foreach (int i in x.Skip(1))
            {
                y -= i;
            }
            return y;
        }

        public static long Subtract(long[] x)
        {
            long y = x[0];
            foreach (long i in x.Skip(1))
            {
                y -= i;
            }
            return y;
        }

        public static double Subtract(double[] x)
        {
            double y = x[0];
            foreach (double i in x.Skip(1))
            {
                y -= i;
            }
            return y;
        }

        #endregion
        #region Multiply
        public static int Multiply(int[] x)
        {
            int y = 0;
            foreach (int i in x)
            {
                y += i;
            }
            return y;
        }
        public static long Multiply(long[] x)
        {
            long y = 0;
            foreach (int i in x)
            {
                y += i;
            }
            return y;
        }
        public static double Multiply(double[] x)
        {
            double y = 0;
            foreach (int i in x)
            {
                y = y / i;
            }
            return y;
        }
        #endregion
        #region Divide
        public static int Divide(int[] x)
        {
            int y = x[0];
            foreach (int i in x.Skip(1))
            {
               y = y / i;
            }
            return y;
        }

        public static long Divide(long[] x)
        {
            long y = x[0];
            foreach (long i in x.Skip(1))
            {
                y = y / i;
            }
            return y;
        }

        public static double Divide(double[] x)
        {
            double y = x[0];
            foreach (double i in x.Skip(1))
            {
                y -= i;
            }
            return y;
        }
    }
#endregion
}