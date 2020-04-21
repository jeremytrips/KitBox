﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class TopBottomPanel: Panel
    {
        const string secAttribute = "H";

        public TopBottomPanel()
        {
        }


        public override string GetCode()
        {
            return this.attribute + secAttribute + this.Depth.ToString() + this.width.ToString() + this.sColor;
        }

        public override Dictionary<string, Component> getData()
        {
            throw new NotImplementedException();
        }
    }
}
