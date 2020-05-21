using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace userInterface
{
    class GeneralDataPanel : System.Windows.Forms.Panel
    {
        private List<List<int>> availableKitboxDimensions; // { depth, height, doorWidth, width }
        private List<string> availablePanelColorList;
        private List<string> availableDoorPanelColorList;
        private List<string> availableAngleColor;

        // Store the data of each Block of the kitbox.
        private List<LayerDataPanel> BlockDataPanelList;
        private LayerDataPanel selectedBlockDataPanel;

        // Store the number of block to check the max ammount
        private int numberOfBLock = 0;

        // Kitbox that is currently create by the user.
        private KitBox kitbox ;

        // Tab in the TabBox it is the actual representation of the kibtox on the interface
        private KitBoxTab kitboxTab;

        // ui object
        private ComboBox avaiblableAngleColorList = new ComboBox();
        private ComboBox availableDepthList = new ComboBox();
        private ComboBox availableWidthList = new ComboBox();

        private Label label1 = new Label();
        private Label label2 = new Label();
        private Label label3 = new Label();
        private Label label4 = new Label();
        private Button saveDimensionButton = new Button();

        public int LayerCount { get => this.numberOfBLock; }

        public GeneralDataPanel(List<List<int>> dimensions, List<int>availableAngleHeight, List<string> availableAngleColor, List<string> availablePanelColor, List<string> availableDoorPanelColor) : base()
        {
            this.avaiblableAngleColorList.SelectedIndexChanged += new EventHandler(this.SetAngleColor);
            this.kitbox = new KitBox();
            this.kitboxTab = new KitBoxTab();
            this.BlockDataPanelList = new List<LayerDataPanel> { };

            this.availableKitboxDimensions = dimensions;
            this.availablePanelColorList = availablePanelColor;
            this.availableDoorPanelColorList = availableDoorPanelColor;
            this.availableAngleColor = availableAngleColor;
            this.kitbox.AvailableAngleHeight = availableAngleHeight; 
            this.MountLayout();
            this.SetComboBox();
        }

        private void SetAngleColor(object sender, EventArgs e)
        {
            Color color = Color.FromName(ColorMapper.MapColor((string)this.avaiblableAngleColorList.SelectedItem));
            this.kitbox.AngleColor = color;
            this.kitboxTab.SetBackColor(color);
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

        public KitBox GetKitBox()
        {
            foreach(LayerDataPanel dataPanel in this.BlockDataPanelList)
            {
                this.kitbox.AddBlock(dataPanel.GetBlock());
            }

            return this.kitbox;
        }

        public void AddLayer()
        {
            if (this.numberOfBLock < 8)
            {
                int index = this.BlockDataPanelList.Count;
                EventHandler blockDisplayClickHandler = new System.EventHandler((object sender, EventArgs e) => this.HandlePanelClick(sender, e, index));
                LayerDataPanel newBlockDataPanel = new LayerDataPanel(index, this.kitbox.Width, this.kitbox.Depth, this.availablePanelColorList, this.availableKitboxDimensions[1], this.availableDoorPanelColorList, blockDisplayClickHandler);

                newBlockDataPanel.DisplayDoorLayout(this.kitbox.Width > 64);

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

        internal void Clear()
        { 
            foreach(LayerDataPanel ldp in this.BlockDataPanelList)
            {
                this.Controls.Remove(ldp);
            }
            this.kitboxTab.Controls.Clear();
            this.BlockDataPanelList.Clear();
            this.selectedBlockDataPanel = null;
            this.kitboxTab.ClearId();
        }

        public void RemoveLayer()
        {
            if (this.numberOfBLock > 1)
            {
                this.kitboxTab.Controls.Remove(this.selectedBlockDataPanel.GetBlockViewer());
                this.selectedBlockDataPanel = this.BlockDataPanelList[this.BlockDataPanelList.Count - 1];

                this.kitbox.RemoveBlock(this.selectedBlockDataPanel.GetBlock());
                this.BlockDataPanelList.Remove(this.selectedBlockDataPanel);
                this.Controls.Remove(this.selectedBlockDataPanel);
                this.selectedBlockDataPanel = this.BlockDataPanelList[this.BlockDataPanelList.Count - 1];
                this.Controls.Add(this.selectedBlockDataPanel);

                this.numberOfBLock--;
            }
        }

        private void SaveDimension(object sender, EventArgs e)
        {
            int depth = (int)this.availableDepthList.SelectedItem;
            int width = (int)this.availableWidthList.SelectedItem;

            this.kitbox.Width = width;
            this.kitbox.Depth = depth;
            
            this.AddLayer();
            this.Controls.Remove(this.saveDimensionButton);
            this.avaiblableAngleColorList.Enabled = false;
            this.availableDepthList.Enabled = false;
            this.availableWidthList.Enabled = false;

        }

        public void ClearKitbox()
        {
            this.kitbox.Clear();
        }

        private void SetComboBox()
        {
            if (!(this.availableKitboxDimensions[0][0] == -1))
            {
                foreach (int i in this.availableKitboxDimensions[3])
                {
                    this.availableWidthList.Items.Add(i);
                }
                this.availableWidthList.SelectedIndex = 0;
                foreach (int i in this.availableKitboxDimensions[0])
                {
                    this.availableDepthList.Items.Add(i);
                }
                this.availableDepthList.SelectedIndex = 0;
                foreach (string color in this.availableAngleColor)
                {
                    this.avaiblableAngleColorList.Items.Add(color);
                }
                this.avaiblableAngleColorList.SelectedIndex = 0;
            }
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
            this.Controls.Add(this.saveDimensionButton);
            this.Location = new System.Drawing.Point(30, 100);
            this.Size = new System.Drawing.Size(400, 465);

            // Label 1 mounting
            this.label1.AutoSize = true;
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Size = new System.Drawing.Size(400, 37);
            this.label1.Text = "Configure your KITBOX";

            // Label 2 mounting
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.Text = "Width of your KitBox: ";

            // Label 3 mounting
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.Text = "Depth of your Kitbox: ";

            // Label 4 mounting
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 118);
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.Text = "Color of the angle iron: ";

            // Save button mounting
            this.saveDimensionButton.Location = new Point(155, 142);
            this.saveDimensionButton.Size = new Size(124, 21);
            this.saveDimensionButton.Text = "Set dimensions";
            this.saveDimensionButton.Click += new EventHandler(this.SaveDimension);

            // width ComboBox mounting
            this.availableWidthList.FormattingEnabled = false;
            this.availableWidthList.Location = new System.Drawing.Point(155, 55);
            this.availableWidthList.Size = new System.Drawing.Size(121, 21);

            // depth ComBox mounting
            this.availableDepthList.FormattingEnabled = true;
            this.availableDepthList.Location = new System.Drawing.Point(155, 85);
            this.availableDepthList.Size = new System.Drawing.Size(121, 21);

            // color ComboBox mounting
            this.avaiblableAngleColorList.FormattingEnabled = true;
            this.avaiblableAngleColorList.Location = new System.Drawing.Point(155, 115);
            this.avaiblableAngleColorList.Size = new System.Drawing.Size(121, 21);

        }
    }
}
