using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface { 
    class Cup: Component
    {
        protected string attribute = "COUPEL";

    public override void DebugPrint()
    {
        Console.WriteLine(this.GetCode());
    }

    public override string GetCode()
    {
        return this.attribute;
    }
}
}
