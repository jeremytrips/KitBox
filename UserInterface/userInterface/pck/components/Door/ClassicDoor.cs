using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    /*Inheritance of the abstract class door, the classic door*/
    class ClassicDoor : Door
    {
        private Color color;

        public ClassicDoor()
        {}

        public override void DebugPrint()
        {
            this.GetCode();
        }

        public override string GetCode()
        {
            return this.attribute + this.height.ToString() + this.width.ToString() + ColorMapper.MapPrefix(this.color) ; 
        }
    }
}