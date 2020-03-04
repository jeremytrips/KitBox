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
        private KitboxListView BlockList =  new KitboxListView();

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

        // Add a new layer to the kitbox.
        private void AddBlock(object sender, EventArgs e)
        {
            Box boxToAdd = new Box(12, new System.Drawing.Color(), new[] { 125, 258 }, "dqcd");
            this.BlockList.AddBox(boxToAdd);
        }

        // Add differents components on the Custom TabPage
        private void MountTab()
        {
            // Block list mounting
            this.Controls.Add(BlockList);
            this.Controls.Add(new AddBlockButton(this.AddBlock));//this.AddBlockButton);

            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(570, 360);
            this.TabIndex = 0;
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
