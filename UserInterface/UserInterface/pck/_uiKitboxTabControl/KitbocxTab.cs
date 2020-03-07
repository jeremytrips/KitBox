using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO :   - Fix the tostring method
 *          - Find a way to add any child class of Block child class in AddBlock
 */

namespace userInterface
{
    class KitBoxTab : TabPage
    {
        static int id = 0;
        private KitBox KitBox;
      

        public KitBoxTab(KitBox kitbox)
        {
            id++;
            this.KitBox = kitbox;
            this.MountTab();
        }

        public KitBoxTab()
        {
            id++;
            this.MountTab();
        }

        // Add differents components on the Custom TabPage
        private void MountTab()
        {
            // Block list mounting
            this.Location = new System.Drawing.Point(450, 72);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(529, 480);
            this.Text = "Kitbox " + id.ToString();
            this.UseVisualStyleBackColor = true;
            this.SuspendLayout();
        } 

        public override string ToString()
        {
            return "kitbox toString";
        }
    }
}
