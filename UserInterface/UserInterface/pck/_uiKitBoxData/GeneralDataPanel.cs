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
        private Label label1 = new Label();
        private Label label2 = new Label();
        private Label label3 = new Label();

        private ComboBox depthList = new ComboBox();
        private ComboBox widthList = new ComboBox();

        // General Data of the kitbox
        private int width;
        private int depth;

        public GeneralDataPanel() : base()
        {

            this.MountLayout();
            this.SetComboBox();

            this.depthList.SelectedIndexChanged += new System.EventHandler(this.SetDepth);
            this.widthList.SelectedIndexChanged += new EventHandler(this.SetWidth);
        }

        public override Dictionary<string, object> GetData()
        {
            return new Dictionary<string, object>{ { "width", this.width }, { "height", this.depth }};
        }

        public override void SetData(Dictionary<string, object> dataToSet)
        {
            this.widthList.SelectedItem = (int) dataToSet["width"];
            this.width = (int) dataToSet["width"];

            this.depthList.SelectedItem = (int)dataToSet["depth"];
            this.depth = (int)dataToSet["depth"];
        }

        private void SetWidth(object sender, EventArgs e)
        {
            this.width =  (int) this.widthList.SelectedItem;
        }

        private void SetDepth(object sender, EventArgs e)
        {
            this.depth = (int)this.depthList.SelectedItem;
        }

        private void SetComboBox()
        {
            List<List<int>> dimensions = Database.FetchAvailableDimension();
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
            this.Location = new System.Drawing.Point(30, 100);
            this.Size = new System.Drawing.Size(400, 113);

            // Label 1 mounting
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.Text = "GeneralData";

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

            // width ComboBox mounting
            this.widthList.FormattingEnabled = false;
            this.widthList.Location = new System.Drawing.Point(30, 82);
            this.widthList.Size = new System.Drawing.Size(121, 21);

            // depth ComBox mounting
            this.depthList.FormattingEnabled = true;
            this.depthList.Location = new System.Drawing.Point(239, 82);
            this.depthList.Size = new System.Drawing.Size(121, 21);

        }
    }
}
