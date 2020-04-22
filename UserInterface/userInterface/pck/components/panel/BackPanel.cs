using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class BackPanel : Panel
    {
        const string secAttribute = "R";

        public BackPanel()
        {
        }

        public override string GetCode()
        {
            return this.attribute + secAttribute +this.Depth.ToString() + this.width.ToString() + this.sColor;
        }

        public override void DebugPrint()
        {
            Console.WriteLine(this.GetCode());
        }

        //public override Dictionary<string, Component> getData()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
