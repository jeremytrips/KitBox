﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class Cleat : Component
    {
        private const string attribute = "TAS";

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