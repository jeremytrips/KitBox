﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface { 
    class LeftRightPanel : Panel
    {
        const string secAttribute = "G";

        public LeftRightPanel()
        {
        }

        public override string GetCode()
        {
            return this.attribute + secAttribute + this.Depth.ToString() + this.Height.ToString() + this.sColor;
        }

        public override Dictionary<string, Component> getData()
        {
            throw new NotImplementedException();
        }
    }
}
