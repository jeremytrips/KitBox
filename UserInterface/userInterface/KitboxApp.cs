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
    public partial class KitboxApp : Form
    {

        private ConfirmOrderLayout confirmOrderLayout;
        private List<GeneralDataPanel> kitboxData = new List<GeneralDataPanel> { };
        private GeneralDataPanel selectedGeneralDataPanel;

        // Data Fetched in the Database
        List<List<int>> AvailableKitboxDimension = Database.FetchAvailableDimension();

        private List<string> availableAngleColor = Database.FetchAngleAvailableColor();
        private List<string> availablePanelColor = Database.FetchPanelAvailableColor();
        private List<string> availbleDoorPanelColor = Database.FetchDoorPanelAvailableColor();
        private List<int> availableAngleHeight = Database.FetchAvailableAngleHeight();

        public KitboxApp()
        {
            InitializeComponent();
            this.oldOrderLayout = new OldOrderLayout(this.HandleOldOrder, "Enter user name");
            this.Controls.Add(this.oldOrderLayout);
            this.confirmOrderLayout = new ConfirmOrderLayout(this.ResetApp, this.BackFromConfirmOrder);
            this.AddKitbox_Click(null, null);
        }

        public void BackFromConfirmOrder(object sender, EventArgs e)
        {
            this.Controls.Remove(this.confirmOrderLayout);
            this.confirmOrderLayout = new ConfirmOrderLayout(this.ResetApp, this.BackFromConfirmOrder  );
        }

        private void HandleOldOrder(object sender, EventArgs e)
        {
            string name = this.oldOrderLayout.GetOldOrderName();
            Console.WriteLine(name);
            if (name != "") {
                if (!Database.CheckOldOrderExistance(name))
                {
                    string message = "The Kitbox you're searching for do not exist";
                    string caption = "Kitbox warning";
                    MessageBox.Show(message, caption);
                }
                else
                {
                    if (this.kitboxData.Count != 0 )
                    {
                        string message = "Warning you are about to erase the Kitbox you have created. Are you sure?";
                        string caption = "Kitbox warning";
                        MessageBoxButtons button = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, button);
                        if (result == DialogResult.Yes)
                        {
                            this.ResetApp();
                            ClientOrder oldOrder = new ClientOrder();
                            oldOrder.FetchOldOrder(name);
                            this.confirmOrderLayout.Order = oldOrder;
                            this.Controls.Add(this.confirmOrderLayout);
                            this.confirmOrderLayout.BringToFront();
                        }

                    }

                }
            }
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

        private void removeKitBoxButton_Click(object sender, EventArgs e)
        {
            if (this.kitboxData.Count() > 1)
            {
                this.Controls.Remove(this.selectedGeneralDataPanel);
                this.kitboxData.Remove(this.selectedGeneralDataPanel);
                this.kitBoxToOrderTabs.TabPages.Remove(this.selectedGeneralDataPanel.GetKitBoxTab());

                this.selectedGeneralDataPanel = this.kitboxData.Last();
                this.kitBoxToOrderTabs.SelectedTab = this.selectedGeneralDataPanel.GetKitBoxTab();
                try
                {
                    this.Controls.Add(this.selectedGeneralDataPanel);

                }
                catch { }
            }
        }

        private void SetKitBoxData(object sender, EventArgs e)
        {
            /*
             * Used to remove current KitBox data layout and display the selected one.
             */
            try
            {
                foreach (GeneralDataPanel kitBox in this.kitboxData)
                {
                    this.Controls.Remove(kitBox);
                }
                this.selectedGeneralDataPanel = this.kitboxData[this.kitBoxToOrderTabs.SelectedIndex];
                this.Controls.Add(this.selectedGeneralDataPanel);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void RemoveLayerButton_Click(object sender, EventArgs e)
        {
            /*
             * Remove the current selected layer in the selected Kitbox.
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
            if (!(this.selectedGeneralDataPanel.LayerCount == 0))
                {
                    ClientOrder order = new ClientOrder();
                    // KITBOXLIS<COMPONENTLIS<code>>>
                    List<List<List<string>>> bill = new List<List<List<string>>> { };
                    foreach (GeneralDataPanel panel in this.kitboxData)
                    {
                        KitBox kitBox = panel.GetKitBox();
                        bill.Add(kitBox.GetCodes());
                        panel.ClearKitbox();
                    }

                    order.ClearedBill = Utils.ClearBill(bill);
                    this.confirmOrderLayout.Order = order;

                    this.Controls.Add(this.confirmOrderLayout);
                    this.confirmOrderLayout.BringToFront();
                }
                else
                {
                    string message = "Please add layer to your Kitbox before ordering ";
                    string caption = "Kitbox warning";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, button);
                }
            
        }

        private void ResetApp()
        {
            foreach(GeneralDataPanel gdp in this.kitboxData)
            {
                gdp.Clear();
                this.Controls.Remove(gdp);
            }
            this.Controls.Remove(this.confirmOrderLayout);
            this.confirmOrderLayout = new ConfirmOrderLayout(this.ResetApp, this.BackFromConfirmOrder);
            kitboxData.Clear();
            selectedGeneralDataPanel = null;
            this.kitBoxToOrderTabs.TabPages.Clear();
            this.AddKitbox_Click(null, null);

        }
    }
} 
