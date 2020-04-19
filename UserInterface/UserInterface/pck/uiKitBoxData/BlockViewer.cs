using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class BlockViewer : System.Windows.Forms.Panel
    {
        private int index;
        private System.Drawing.Color doorColor;

        public BlockViewer(int pos_y, object setDataPanelColor) : base()
        {
            this.index = pos_y;
            this.Size = new System.Drawing.Size(521, 53);
            int a = 399 - (pos_y * 55);
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, a);

        }

        public int Index { get => this.index; }
        public Color DoorColor {set => doorColor = value; }
    }
}
