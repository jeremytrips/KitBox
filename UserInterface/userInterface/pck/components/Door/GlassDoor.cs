using System;
using System.Collections.Generic;

namespace userInterface
{
    class GlassDoor : Door
    {
        public GlassDoor()
        {}

        public override void DebugPrint()
        {
            Console.WriteLine(GetCode());
        }

        public override string GetCode()
        {
            Console.WriteLine("Glass door");
            return attribute + this.height + WidthMapper.MapDoorWidth(this.width) + "VE";
        }

        public override string GetCupCode()
        {
            throw new NotImplementedException();
        }
    }
}