using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class TestPanel : System.Windows.Forms.Panel
    {
        private int index;
        public TestPanel(int pos_y) : base()
        {
            this.index = pos_y;
            this.Size = new System.Drawing.Size(521, 53);
            int a = 399 - (pos_y * 55);
            Console.WriteLine(a);
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, a);

        }

        public int Index { get => this.index; }
    }
}
