using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO : reset the component attribute to the AddComponent method
 */


namespace userInterface
{
    class KitboxListView: ListBox
    {

        public KitboxListView(): base()
        {
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "blockList";
            this.Size = new System.Drawing.Size(560, 250);
            this.TabIndex = 0;
            this.SelectedIndexChanged += new EventHandler(this.UpdateData); 
        }

        private void UpdateData(object sender, EventArgs e)
        {
            Console.WriteLine(this.SelectedIndex);
        }

        public void AddBox(Box box)
        {
            if (this.Items.Count <= 7)
            {

                this.Items.Add(box.ToListDescription());
            } else
            {
                MessageBox.Show("You can't add more than 8 box in your KitBox.");
            }
        }
    }
}
