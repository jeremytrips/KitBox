using System;
using System.Collections.Generic;

namespace userInterface
{
    /*Inheritance of the abstract class door*/
    class GlassDoor : Door
    {
        /*Builder*/
        public GlassDoor()
        {}

        public override void DebugPrint()
        {
            Console.WriteLine(GetCode());
        }

        public override string GetCode()
        {
            return this.attribute + this.height + WidthMapper.MapDoorWidth(this.width) + "VE";
        }
    }
}