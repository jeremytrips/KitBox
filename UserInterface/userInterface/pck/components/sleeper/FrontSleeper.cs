using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class FrontSleeper:Sleeper
    {
        private const string secAttribue = "F";
        public FrontSleeper()
        {
        }

        public override void DebugPrint()
        {
            Console.WriteLine(this.GetCode());
        }

        public override string GetCode()
        {
            return attribute + secAttribue + this.width;
        }
    }
}
