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

        private Dictionary<KitBox, List<DataPanel>> userOrder = new Dictionary<KitBox, List<DataPanel>> { };
        private int selectedKitBox = -1;
        private OldOrderLayout oldOrederLayout;

        public Form1()
        {
            InitializeComponent();
            this.oldOrderLayout = new OldOrderLayout(this.HandleOldOrder, "Enter user name");
            this.Controls.Add(this.oldOrderLayout);
        }

        private void OldOrderButton_Click(object sender, EventArgs e)
        {
            Database.Fetch("SELECT * FROM ORDER WHERE ");
        }

        private void AddKitbox_Click(object sender, EventArgs e)
        {
            GeneralDataPanel generalDataPanel = new GeneralDataPanel();
            SpecificDataPanel specificDataPanel = new SpecificDataPanel(KitBox.Id);
            KitBoxTab toAdd = new KitBoxTab();
            KitBox newKitBox = new KitBox();
            kitBoxToOrderTabs.TabPages.Add(toAdd);
            kitBoxToOrderTabs.SelectedTab = toAdd;
            this.userOrder.Add( newKitBox, new List<DataPanel> { generalDataPanel, specificDataPanel });

            this.SetKitBoxData(null, null);

        }

        private void SetKitBoxData(object sender, EventArgs e)
        {
            this.selectedKitBox = this.kitBoxToOrderTabs.SelectedIndex;
            
            foreach (KeyValuePair<KitBox, List<DataPanel>> kitBox in this.userOrder)
            {
                try
                {
                    this.Controls.Remove(kitBox.Value[0]);
                    this.Controls.Remove(kitBox.Value[1]);
                    foreach (KeyValuePair<KitBox, List<DataPanel>> pair in this.userOrder)
                    {
                        if (pair.Key.Equals(this.selectedKitBox))
                        {
                            this.Controls.Add(pair.Value[0]);
                            this.Controls.Add(pair.Value[1]);
                            break;
                        }
                    }
                }
                catch{ }
            }
            
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
            
            
        }

    }
}
