using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    interface IParseinput
    {
        bool inPeren { get; set; }
        double DoMath();
        void ParseInput();
        List<double> Holding { get; set; }
        List<double> HoldingChar { get; set; }
    }
}
