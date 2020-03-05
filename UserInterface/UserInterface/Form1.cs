using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO:    - handleOldOrder function
 *          - 
 */

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
            Database.Fetch("SELECT * FROM ORDER WHERE ");
        }

        private void AddKitbox_Click(object sender, EventArgs e)
        {
            KitBoxTab toAdd = new KitBoxTab();
            kitBoxToOrderTabs.TabPages.Add(toAdd);
            kitBoxToOrderTabs.SelectedTab = toAdd;
        }

        private void HandleOldOrder(object sender, EventArgs e)
        {
            /* TODO:    - fetch data from the database using the orderToFetch string
                        - Add a columns name 'order_name' wich will be used to retreive the 
                                string querry = "SELECT * FROM order"
                          use user name and fecth a list of ol order to display in a list.
                                string querry = "SELECT * FROM order WHERE "user_id"=id of the user 
             */
            string orderToFetch = this.oldOrderLayout.GetOldOrderName();
            
            Console.WriteLine(this.oldOrderLayout.GetOldOrderName());
            Console.WriteLine(e);
            Console.WriteLine("mabite");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
