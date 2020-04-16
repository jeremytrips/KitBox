using System;
using System.Collections.Generic;
using System.Drawing;
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

        //public KitBoxTab(KitBox kitbox)
        //{
        //    id++;
        //    this.KitBox = kitbox;
        //    this.MountTab();
        //}

        public KitBoxTab()
        {
            id++;
            this.MountTab();
        }

        public void SetBackColor(Color color)
        {
            this.BackColor = color;
        }

        // Add differents components on the Custom TabPage
        private void MountTab()
        {
            // Block list mounting
            this.Location = new System.Drawing.Point(450, 72);
            //this.Padding = new System.Windows.Forms.Padding();
            this.Size = new System.Drawing.Size(530, 480);
            this.Text = "Kitbox " + id.ToString();
            this.UseVisualStyleBackColor = true;
            this.BackColor = Color.YellowGreen;
            //this.BackColor = System.Drawing.Color.Aquamarine;
            this.SuspendLayout();
        } 

        public override string ToString()
        {
            return "kitbox toString";
        }
    }
}
