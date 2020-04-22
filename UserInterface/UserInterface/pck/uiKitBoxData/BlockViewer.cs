using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class BlockViewer : System.Windows.Forms.Panel
    {
        Label label1 = new System.Windows.Forms.Label();
        Label label2 = new System.Windows.Forms.Label();
        Label label3 = new System.Windows.Forms.Label();
        Label label5 = new System.Windows.Forms.Label();
        Label label6 = new System.Windows.Forms.Label();
        Label label7 = new System.Windows.Forms.Label();

        Label doorIndicator = new System.Windows.Forms.Label();
        Label doorColorIndicator = new System.Windows.Forms.Label();
        Label panelColorIndicator = new System.Windows.Forms.Label();
        Label HeightIndicator = new System.Windows.Forms.Label();
        Label widthIndicator = new System.Windows.Forms.Label();
        Label depthIndicator = new System.Windows.Forms.Label();

        private int index;
        private bool hasDoor;
        private Color doorColor;
        private int layerHeight;
        private int layerWidth;
        private int layerDepth;
        private Color panelColor;

        public BlockViewer(int pos_y) : base()
        {
            this.MountLayout(pos_y);

        }

        public int Index { get => this.index; }

        public Color PanelColor {set{
                panelColor = value;
                this.panelColorIndicator.Text = value.Name;
            }
        }

        public Color DoorColor { set { 
                doorColor = value;
                this.doorColorIndicator.Text = value.Name;
            }
        }

        public int LayerHeight {set
            {
                layerHeight = value;
                this.HeightIndicator.Text = value.ToString();
            }
        }

        public int LayerWidth
        {
            set
            {
                layerWidth = value;
                this.widthIndicator.Text = value.ToString();
            }
        }

        public int LayerDepth {set
            {
                layerDepth = value;
                this.depthIndicator.Text = value.ToString();
            }
        }

        public void setNoColorColor(string noColor)
        {
            // Sometimes selected color are not really color so we need to pass string to set the selected door
            // TODO
        }

        private void MountLayout(int pos_y)
        {
            this.index = pos_y;
            this.Size = new System.Drawing.Size(521, 53);
            int a = 399 - (pos_y * 55);
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, a);

            this.Controls.Add(this.label6);
            this.Controls.Add(this.widthIndicator);
            this.Controls.Add(this.HeightIndicator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelColorIndicator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doorColorIndicator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doorIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depthIndicator);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOOR";
            // 
            // doorIndicator
            // 
            this.doorIndicator.AutoSize = true;
            this.doorIndicator.Location = new System.Drawing.Point(23, 29);
            this.doorIndicator.Name = "doorIndicator";
            this.doorIndicator.Size = new System.Drawing.Size(31, 13);
            this.doorIndicator.TabIndex = 1;
            this.doorIndicator.Text = "nope";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOOR COLOR";
            // 
            // doorColorIndicator
            // 
            this.doorColorIndicator.AutoSize = true;
            this.doorColorIndicator.Location = new System.Drawing.Point(115, 29);
            this.doorColorIndicator.Name = "doorColorIndicator";
            this.doorColorIndicator.Size = new System.Drawing.Size(31, 13);
            this.doorColorIndicator.TabIndex = 3;
            this.doorColorIndicator.Text = "nope";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PANEL COLOR";
            // 
            // panelColorIndicator
            // 
            this.panelColorIndicator.AutoSize = true;
            this.panelColorIndicator.Location = new System.Drawing.Point(234, 29);
            this.panelColorIndicator.Name = "panelColorIndicator";
            this.panelColorIndicator.Size = new System.Drawing.Size(31, 13);
            this.panelColorIndicator.TabIndex = 5;
            this.panelColorIndicator.Text = "nope";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height";
            // 
            // HeightIndicator
            // 
            this.HeightIndicator.AutoSize = true;
            this.HeightIndicator.Location = new System.Drawing.Point(314, 29);
            this.HeightIndicator.Name = "HeightIndicator";
            this.HeightIndicator.Size = new System.Drawing.Size(38, 13);
            this.HeightIndicator.TabIndex = 7;
            this.HeightIndicator.Text = "Height";
            // 
            // widthIndicator
            // 
            this.widthIndicator.AutoSize = true;
            this.widthIndicator.Location = new System.Drawing.Point(375, 29);
            this.widthIndicator.Name = "widthIndicator";
            this.widthIndicator.Size = new System.Drawing.Size(35, 13);
            this.widthIndicator.TabIndex = 8;
            this.widthIndicator.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Width";


            this.depthIndicator.AutoSize = true;
            this.depthIndicator.Location = new System.Drawing.Point(425, 29);
            this.depthIndicator.Name = "widthIndicator";
            this.depthIndicator.Size = new System.Drawing.Size(35, 13);
            this.depthIndicator.TabIndex = 8;
            this.depthIndicator.Text = "Depth";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 9);
            this.label7.Name = "label6";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Depth";
        }
    }
}
