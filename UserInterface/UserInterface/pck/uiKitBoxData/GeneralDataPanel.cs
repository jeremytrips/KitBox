using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

/*
 * Todo :   
 * 
 */

namespace userInterface
{
    class GeneralDataPanel : DataPanel
    {

        static int toRemove = 0;

        private Label label1 = new Label();
        private Label label2 = new Label();
        private Label label3 = new Label();
        private Label label4 = new Label();

        private ComboBox depthList = new ComboBox();
        private ComboBox widthList = new ComboBox();
        private ComboBox colorList = new ComboBox();

        // Store the data of each Block of the kitbox.
        private List<SpecificDataPanel> specificDataPanelList = new List<SpecificDataPanel> { };
        private SpecificDataPanel selectedSpecificDataPanel;

        // Store the graphic representation of each Block.
        private List<TestPanel> blockList = new List<TestPanel> { };
        private TestPanel selectedBlock;

        // Store the number of block to check the max ammount
        private int numberOfBLock = 0;

        // Kitbox that is currently create by the user.
        private KitBox kitbox = new KitBox();

        // Tab in the TabBox it is the actual representation of the kibtox on the interface
        private KitBoxTab kitboxTab = new KitBoxTab();

        public GeneralDataPanel(List<List<int>> dimensions, List<string> AvailableAngleColor) : base()
        {
            toRemove++;
            this.MountLayout();
            //this.Controls.Add();
            this.AddLayer();
            this.SetComboBox(dimensions, AvailableAngleColor);
            this.depthList.SelectedIndexChanged += new EventHandler(this.SetDepth);
            this.widthList.SelectedIndexChanged += new EventHandler(this.SetWidth); 
        }

        public void HandlePanelClick(object sender, EventArgs e, int index)
        {
            /*
             * Used to hide the current specific data panel and display the selected one
             */
            this.Controls.Remove(this.selectedSpecificDataPanel);
            this.selectedSpecificDataPanel = this.specificDataPanelList[index];
            this.Controls.Add(this.selectedSpecificDataPanel);
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
                SpecificDataPanel newSpecificDataPanel = new SpecificDataPanel(toRemove, this.specificDataPanelList.Count);
                TestPanel newDisplayPanel = new TestPanel(this.numberOfBLock);
                newDisplayPanel.Click += new System.EventHandler((object sender, EventArgs e) => this.HandlePanelClick(sender, e, newDisplayPanel.Index));
                this.specificDataPanelList.Add(newSpecificDataPanel);
                this.selectedSpecificDataPanel = newSpecificDataPanel;
                foreach(SpecificDataPanel temp in this.specificDataPanelList)
                {
                    this.Controls.Remove(temp);
                }
                this.Controls.Add(this.selectedSpecificDataPanel);

                this.blockList.Add(newDisplayPanel);
                this.kitboxTab.Controls.Add(newDisplayPanel);
                this.selectedBlock = newDisplayPanel;

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
                this.blockList.Remove(this.selectedBlock);
                this.kitboxTab.Controls.Remove(this.selectedBlock);
                this.selectedBlock = this.blockList[this.blockList.Count - 1];

                this.specificDataPanelList.Remove(this.selectedSpecificDataPanel);
                this.Controls.Remove(this.selectedSpecificDataPanel);
                this.selectedSpecificDataPanel = this.specificDataPanelList[this.specificDataPanelList.Count - 1];
                this.Controls.Add(this.selectedSpecificDataPanel);

                this.numberOfBLock--;
            }
        }

        public override void SetData(Dictionary<string, object> dataToSet)
        {
            // TODO : See the data frame used to retrieve data
            this.widthList.SelectedItem = (int) dataToSet["width"];
            this.kitbox.Width = (int) dataToSet["width"];

            this.depthList.SelectedItem = (int)dataToSet["depth"];
            this.kitbox.Depth = (int)dataToSet["depth"];
        }

        private void SetWidth(object sender, EventArgs e)
        {
            this.kitbox.Width = (int)this.widthList.SelectedItem;
        }

        private void SetDepth(object sender, EventArgs e)
        {
            this.kitbox.Depth = (int)this.depthList.SelectedItem;
        }

        private void SetComboBox(List<List<int>> dimensions, List<string> AvailableAngleColor)
        {
            // TODO add color combo box
            if (!(dimensions[0][0] == -1))
            {
                foreach (int i in dimensions[0])
                {
                    this.widthList.Items.Add(i);
                }
                foreach (int i in dimensions[1])
                {
                    this.depthList.Items.Add(i);
                }
                foreach (string color in AvailableAngleColor)
                {
                    this.colorList.Items.Add(color);
                }
            }
            // todo fire a server connection alert
        }

        private void MountLayout()
        {
            // Panel mounting
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depthList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorList);
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
            this.widthList.FormattingEnabled = false;
            this.widthList.Location = new System.Drawing.Point(30, 82);
            this.widthList.Size = new System.Drawing.Size(121, 21);

            // depth ComBox mounting
            this.depthList.FormattingEnabled = true;
            this.depthList.Location = new System.Drawing.Point(239, 82);
            this.depthList.Size = new System.Drawing.Size(121, 21);

            // color ComboBox mounting
            this.colorList.FormattingEnabled = true;
            this.colorList.Location = new System.Drawing.Point(30, 130);
            this.colorList.Size = new System.Drawing.Size(121, 21);

        }
    }
}
