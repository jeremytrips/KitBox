using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface.pck.panel
{
    class LeftRightPanel : Panel
    {
        private int width;

        public LeftRightPanel(int width, Color color)
        {
            this.width = width;
            this.Color = color;
        }

        public override Dictionary<string, Component> getData()
        {
            throw new NotImplementedException();
        }
    }
}
