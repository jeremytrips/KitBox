using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Todo :   - Fix the set and get data function
 *          - May be set this class as an interface and create a class for every kind of block
 * 
 */

namespace userInterface
{
    class SpecificDataPanel: DataPanel
    {
        /*
         * SpecificDataPanel 
         * =================
         * Simple layout that display the selecter layer data ( color, door, height, ...)
         * 
         */

        public SpecificDataPanel(int x, int y): base()
        {
            this.MountLayout();
        }

        private void MountLayout()
        {
            // Mounting layout
            this.Location = new System.Drawing.Point(0, 165);
            this.Size = new System.Drawing.Size(400, 300);
            this.BackColor = System.Drawing.Color.Red;
        }

        public override Dictionary<String, object> GetData()
        {
            return new Dictionary<String, object>
            {
                {"color", System.Drawing.Color.Red}
            };
        }
           
        public override void SetData(Dictionary<string, object> dataToSet)
        {
            return;
        }
    }
}
