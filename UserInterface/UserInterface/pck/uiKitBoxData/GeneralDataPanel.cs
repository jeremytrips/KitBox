using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

/*
 * Todo :   
 * 
 */

namespace userInterface
{
    class GeneralDataPanel : DataPanel
    {
        private bool displayDoor = false;
        private List<List<int>> availableKitboxDimensions; //{depth, height, doorWidth, width}
        private List<string> availablePanelColorList;
        private List<string> availableDoorPanelColorList;


        // Store the data of each Block of the kitbox.
        private List<LayerDataPanel> BlockDataPanelList = new List<LayerDataPanel> { };
        private LayerDataPanel selectedBlockDataPanel;

        // Store the number of block to check the max ammount
        private int numberOfBLock = 0;

        // Kitbox that is currently create by the user.
        private KitBox kitbox = new KitBox();

        // Tab in the TabBox it is the actual representation of the kibtox on the interface
        private KitBoxTab kitboxTab = new KitBoxTab();

        // ui object
        private ComboBox avaiblableAngleColorList = new ComboBox();
        private ComboBox availableDepthList = new ComboBox();
        private ComboBox availableWidthList = new ComboBox();

        private Label label1 = new Label();
        private Label label2 = new Label();
        private Label label3 = new Label();
        private Label label4 = new Label();

        public GeneralDataPanel(List<List<int>> dimensions, List<string> availableAngleColor, List<string> availablePanelColor, List<string> availableDoorPanelColor) : base()
        {
            this.availableKitboxDimensions = dimensions;
            this.availablePanelColorList = availablePanelColor;
            this.availableDoorPanelColorList = availableDoorPanelColor;
            this.MountLayout();
            this.AddLayer();
            this.SetComboBox(availableAngleColor);
            this.availableDepthList.SelectedIndexChanged += new EventHandler(this.SetDepth);
            this.availableWidthList.SelectedIndexChanged += new EventHandler(this.SetWidth);
            this.avaiblableAngleColorList.SelectedIndexChanged += new EventHandler(this.SetColor);
        }

        private void SetColor(object sender, EventArgs e)
        {
            Color color = Color.FromName(ColorMapper.MapColor((string)this.avaiblableAngleColorList.SelectedItem));
            this.kitbox.AngleColor = color;
            this.kitboxTab.SetBackColor(color);
        }

        private void SetDataPanelColor(Color color)
        {
            this.selectedBlockDataPanel.SetBlockViewerColor(color);
        }

        public void HandlePanelClick(object sender, EventArgs e, int index)
        {
            /*
             * Used to hide the current specific data panel and display the selected one
             */
            this.Controls.Remove(this.selectedBlockDataPanel);
            this.selectedBlockDataPanel = this.BlockDataPanelList[index];
            this.Controls.Add(this.selectedBlockDataPanel);
        }
        
        public KitBoxTab GetKitBoxTab()
        {
            return this.kitboxTab;
        }

        public override Dictionary<string, object> GetData()
        {
            return this.kitbox.GetData();
        }


        public void AddLayer()
        {
            if (this.numberOfBLock < 8)
            {
                int index = this.BlockDataPanelList.Count;
                EventHandler blockDisplayClickHandler = new System.EventHandler((object sender, EventArgs e) => this.HandlePanelClick(sender, e, index));
                LayerDataPanel newBlockDataPanel = new LayerDataPanel(index, this.availablePanelColorList, this.availableKitboxDimensions[2], this.availableDoorPanelColorList, blockDisplayClickHandler);

                this.BlockDataPanelList.Add(newBlockDataPanel);
                this.selectedBlockDataPanel = newBlockDataPanel;
                foreach(LayerDataPanel temp in this.BlockDataPanelList)
                {
                    this.Controls.Remove(temp);
                }
                this.Controls.Add(this.selectedBlockDataPanel);

                this.kitboxTab.Controls.Add(newBlockDataPanel.GetBlockViewer());

                this.numberOfBLock++;
            }
            else
            {
                MessageBox.Show("You can't add more than 8 layer to your kitbox", "Warning");
            }
        }

        public void RemoveLayer()
        {
            if (this.numberOfBLock > 1)
            {
                this.kitboxTab.Controls.Remove(this.selectedBlockDataPanel.GetBlockViewer());
                this.selectedBlockDataPanel = this.BlockDataPanelList[this.BlockDataPanelList.Count - 1];

                this.BlockDataPanelList.Remove(this.selectedBlockDataPanel);
                this.Controls.Remove(this.selectedBlockDataPanel);
                this.selectedBlockDataPanel = this.BlockDataPanelList[this.BlockDataPanelList.Count - 1];
                this.Controls.Add(this.selectedBlockDataPanel);

                this.numberOfBLock--;
            }
        }

        public override void SetData(Dictionary<string, object> dataToSet)
        {
            // TODO : See the data frame used to retrieve data
            this.availableWidthList.SelectedItem = (int) dataToSet["width"];
            this.kitbox.Width = (int) dataToSet["width"];

            this.availableDepthList.SelectedItem = (int)dataToSet["depth"];
            this.kitbox.Depth = (int) dataToSet["depth"];
        }

        private void SetWidth(object sender, EventArgs e)
        {
            int width = (int)this.availableWidthList.SelectedItem;
            this.kitbox.Width = width;
            foreach (LayerDataPanel block in this.BlockDataPanelList)
            {
                block.DiplaysDoorLayout(width > 64);
            }
        }

        private void SetDepth(object sender, EventArgs e)
        {
            this.kitbox.Depth = (int)this.availableDepthList.SelectedItem;
        }

        private void SetComboBox(List<string> availableAngleColor)
        {
            // TODO add color combo box
            if (!(this.availableKitboxDimensions[0][0] == -1))
            {
                foreach (int i in this.availableKitboxDimensions[3])
                {
                    this.availableWidthList.Items.Add(i);
                }
                foreach (int i in this.availableKitboxDimensions[0])
                {
                    this.availableDepthList.Items.Add(i);
                }
                foreach (string color in availableAngleColor)
                {
                    this.avaiblableAngleColorList.Items.Add(color);
                }
            }
            // todo fire a server connection alert
        }

        private void MountLayout()
        {
            // Panel mounting
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availableDepthList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableWidthList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avaiblableAngleColorList);
            this.Controls.Add(this.label4);
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Location = new System.Drawing.Point(30, 100);
            this.Size = new System.Drawing.Size(400, 465);

            // Label 1 mounting
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.Text = "General Data";

            // Label 2 mounting
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.Text = "KitBox width: ";

            // Label 3 mounting
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 66);
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.Text = "KitBox depth: ";

            // Label 4 mounting
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.Text = "KitBox angle Color: ";

            // width ComboBox mounting
            this.availableWidthList.FormattingEnabled = false;
            this.availableWidthList.Location = new System.Drawing.Point(30, 82);
            this.availableWidthList.Size = new System.Drawing.Size(121, 21);

            // depth ComBox mounting
            this.availableDepthList.FormattingEnabled = true;
            this.availableDepthList.Location = new System.Drawing.Point(239, 82);
            this.availableDepthList.Size = new System.Drawing.Size(121, 21);

            // color ComboBox mounting
            this.avaiblableAngleColorList.FormattingEnabled = true;
            this.avaiblableAngleColorList.Location = new System.Drawing.Point(30, 130);
            this.avaiblableAngleColorList.Size = new System.Drawing.Size(121, 21);

        }
    }
}
