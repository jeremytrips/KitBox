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
        private int width;

        public BackPanel(int width, Color color)
        {
            this.width = width;
            this.Color = color;
        }

        public int Width { get => width; set => width = value; }

        // public BackPanel(int ) base()
        public override Dictionary<string, Component> getData()
        {
            throw new NotImplementedException();
        }
    }
}
