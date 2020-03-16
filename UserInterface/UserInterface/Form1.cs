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
        private KitBox selectedKitBox = null;

        public Form1()
        {
            InitializeComponent();
            this.oldOrderLayout = new OldOrderLayout(this.HandleOldOrder, "Enter user name");
            this.Controls.Add(this.oldOrderLayout);
        }

        private void OldOrderButton_Click(object sender, EventArgs e)
        {
            if(this.userOrder.Count != 0)
            {
                // Warning delete actual order
            }
            Database.Fetch("SELECT * FROM ORDER WHERE ");
        }

        private void AddKitbox_Click(object sender, EventArgs e)
        {
            KitBoxTab toAdd = new KitBoxTab();
            KitBox newKitBox = new KitBox();
            GeneralDataPanel generalDataPanel = new GeneralDataPanel();
            SpecificDataPanel specificDataPanel = new SpecificDataPanel(newKitBox.Id);
            
            kitBoxToOrderTabs.TabPages.Add(toAdd);
            kitBoxToOrderTabs.SelectedTab = toAdd;
            this.userOrder.Add( newKitBox, new List<DataPanel> { generalDataPanel, specificDataPanel });

            this.selectedKitBox = newKitBox;
            this.SetKitBoxData(null, null);
        }

        private void SetKitBoxData(object sender, EventArgs e)
        {
            /*
             * Used to remove current KitBox data layout and display the selected one.
             */
            // this.selectedKitBox;
            foreach (KeyValuePair<KitBox, List<DataPanel>> kitBox in this.userOrder)
            {
                try
                {
                    if (kitBox.Key.Equals(this.kitBoxToOrderTabs.SelectedIndex))
                    {
                        this.selectedKitBox = kitBox.Key;
                    }
                    this.Controls.Remove(kitBox.Value[0]);
                    this.Controls.Remove(kitBox.Value[1]);
                    
                }
                catch { }
            }
            this.Controls.Add(this.userOrder[this.selectedKitBox][0]);
            this.Controls.Add(this.userOrder[this.selectedKitBox][1]);
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

        private void RemoveLayerButton_Click(object sender, EventArgs e)
        {
            /*
             * Remove the current selected layer in the 
             * 
             */
            //this.selectedKitBox.RemoveLayer(i);
        }
    }
}
