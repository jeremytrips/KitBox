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
        private ConfirmOrderLayout confirmOrderLayout = new ConfirmOrderLayout();
        private List<GeneralDataPanel> kitboxData = new List<GeneralDataPanel> { };
        private GeneralDataPanel selectedGeneralDataPanel;

        // Data Fetched in the Database
        List<List<int>> AvailableKitboxDimension = Database.FetchAvailableDimension();

        private List<string> availableAngleColor = Database.FetchAngleAvailableColor();
        private List<string> availablePanelColor = Database.FetchPanelAvailableColor();
        private List<string> availbleDoorPanelColor = Database.FetchDoorPanelAvailableColor();
        private List<int> availableAngleHeight = Database.FetchAvailableAngleHeight();

        public Form1()
        {
            InitializeComponent();
            this.oldOrderLayout = new OldOrderLayout(this.HandleOldOrder, "Enter user name");
            this.Controls.Add(this.oldOrderLayout);
        }

        private void OldOrderButton_Click(object sender, EventArgs e)
        {
            if(this.kitboxData.Count != 0)
            {
                // Warning delete actual order
            }
            // Handle the fetched order.
        }

        private void AddKitbox_Click(object sender, EventArgs e)
        {
            /*
             * Add a new kitbox
             */
            GeneralDataPanel generalDataPanel = new GeneralDataPanel(this.AvailableKitboxDimension, this.availableAngleHeight, this.availableAngleColor, this.availablePanelColor, this.availbleDoorPanelColor);
            this.kitboxData.Add(generalDataPanel);
            this.selectedGeneralDataPanel = generalDataPanel;
            this.Controls.Add(generalDataPanel);

            this.kitBoxToOrderTabs.TabPages.Add(generalDataPanel.GetKitBoxTab());
            this.kitBoxToOrderTabs.SelectedTab = generalDataPanel.GetKitBoxTab();
        }

        private void SetKitBoxData(object sender, EventArgs e)
        {
            /*
             * Used to remove current KitBox data layout and display the selected one.
             */
            foreach (GeneralDataPanel kitBox in this.kitboxData)
            {
                try
                {
                    this.Controls.Remove(kitBox);
                }
                catch { }
            }
            this.selectedGeneralDataPanel = this.kitboxData[this.kitBoxToOrderTabs.SelectedIndex];
            this.Controls.Add(this.selectedGeneralDataPanel);
        }

        private void HandleOldOrder(object sender, EventArgs e)
        {
            /* TODO:    
                        - fetch data from the database using the orderToFetch string
                        - Add a columns name 'order_name' wich will be used to retreive the 
                                string querry = "SELECT * FROM order"
                        - use user name and fecth a list of old order to display in a list.
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
            this.selectedGeneralDataPanel.RemoveLayer();
        }

        private void AddLayerButton_Click(object sender, EventArgs e)
        {
            /*
             * Add a layer in the current selected kitbox.
             */
            this.selectedGeneralDataPanel.AddLayer();
        }

        private void order_Click(object sender, EventArgs e)
        {
            // KITBOXLIS<COMPONENTLIS<code, number>>>
            List<List<List<string>>> bill = new List<List<List<string>>> { };
            foreach (GeneralDataPanel panel in this.kitboxData)
            {
                KitBox kitBox = panel.GetKitBox();
                bill.Add(kitBox.GetCodes());
                panel.ClearKitbox();
            }

            Dictionary<string, int> clearedBill = Utils.ClearBill(bill);

            List<List<object>> lists = Database.HandleOrder(clearedBill);
            this.confirmOrderLayout.Data = lists;

            this.Controls.Add(this.confirmOrderLayout);
            this.confirmOrderLayout.BringToFront();
        }
    }
} 
