using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OldOrderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddKitbox_Click(object sender, EventArgs e)
        {
            String title = "Kitbox " + (kitBoxToOrderTabs.TabCount + 1).ToString();
            KitBoxTab toAdd = new KitBoxTab();
            kitBoxToOrderTabs.TabPages.Add(toAdd);
        }

        private void AddBlockButton_Click(object sender, EventArgs e)
        {
            var item1 = new ListViewItem(new[] { "id123", "Tom", "24" });
            int selectedTab = kitBoxToOrderTabs.SelectedIndex;
            Console.WriteLine(selectedTab);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
