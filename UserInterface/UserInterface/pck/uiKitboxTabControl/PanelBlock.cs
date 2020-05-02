using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * TODO :  remove
 */


namespace userInterface.pck._uiKitboxTabControl
{
    class PanelBlock: System.Windows.Forms.Panel
    {
        public PanelBlock(Block toDescribe, int posY)
        {

            this.MountLayout(posY);
        }

        private void MountLayout(int posY)
        {
            // Mounting self layout
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(530, 60);
        }
    }
}
