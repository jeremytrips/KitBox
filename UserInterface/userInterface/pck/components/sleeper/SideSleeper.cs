using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class SideSleeper : Sleeper
    {
        private const string secAttribue = "G";
        public SideSleeper()
        {
        }

        public override void DebugPrint()
        {
            Console.WriteLine(this.GetCode());
        }

        public override string GetCode()
        {
            return attribute + secAttribue + this.depth;
        }
    }
}
