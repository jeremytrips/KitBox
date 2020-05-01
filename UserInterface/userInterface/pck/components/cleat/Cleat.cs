﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    /* Class that groups all cleats*/
    class Cleat : Component
    {

        const string attribute = "TAS";
        /*Builder*/
        public Cleat()
        {}

        public override string GetCode()
        {
            return attribute + (this.height - 5).ToString();
        }

        public override void DebugPrint()
        {
            Console.WriteLine(this.GetCode());
        }
    }
}