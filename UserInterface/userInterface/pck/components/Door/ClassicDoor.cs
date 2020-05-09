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
        private Color color = Color.White;
        private Cup cup = new Cup();

        public ClassicDoor(Color doorColor)
        {
            this.color = doorColor;
        }

        public override void DebugPrint()
        {
            this.GetCode();
        }

        public override string GetCode()
        {
            Console.WriteLine("classic door");
            return string.Concat(attribute, this.height.ToString(), WidthMapper.MapDoorWidth(this.width), ColorMapper.MapPrefix(this.color));
        }

        public override string GetCupCode()
        {
            return this.cup.GetCode();
        }
    }
}