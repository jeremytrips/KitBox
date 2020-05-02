using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace userInterface
{
    class KitBoxTab : TabPage
    {
        static int id = 0; 

        public KitBoxTab()
        {
            id++;
            this.MountTab();
        }

        public void ClearId()
        {
            id = 0;
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
            //this.BackColor = System.Drawing.Color.Aquamarine;
            this.SuspendLayout();
        } 
    }
}
