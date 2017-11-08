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
        void CallInput();
        void StoreInput();
        Dictionary<int, string> storedProcedures { get; set; }
        int dictKeycounter { get; set; }
        List<double> holding { get; set; }
        List<double> holdingChar { get; set; }
    }
}
