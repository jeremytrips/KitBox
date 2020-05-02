﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class LayerDataPanel: DataPanel
    {
        /*
         * BlockDataPanel 
         * =================
         * Simple layout that display the selecter layer data ( color, door, height, ...)
         * 
         */

        private Layer layer;
        private BlockViewer blockViewer;

        //ui 
        private RadioButtonLayout<int> availablePanelHeight;
        private RadioButtonLayout<string> availablePanelColor ;
        private RadioButtonLayout<string> avaiblableDoorColor;

        public LayerDataPanel(int heightOfBlockViewer, int width, int depth, List<string> availablePanelColor, List<int> availableHeight, List<string> avaiblableDoorColor, System.EventHandler clickHandler) : base()
        {
            this.MountLayout(availableHeight, availablePanelColor, avaiblableDoorColor);

            this.layer = new Layer(width, depth);
            this.blockViewer = new BlockViewer(heightOfBlockViewer);
            this.blockViewer.Click += clickHandler;
        }

        private void SetPanelColor(object sender, EventArgs e)
        {
            Color color = Color.FromName(ColorMapper.MapColor(this.availablePanelColor.GetChecked()));
            this.blockViewer.PanelColor = color;
            this.layer.PanelColor = color;
            this.blockViewer.BackColor = Color.FromArgb(125, color);
        }

        private void SetLayerHeight(object sender, EventArgs e)
        {
            int height = Int16.Parse(this.availablePanelHeight.GetChecked());
            this.layer.Height = height;
            this.blockViewer.LayerHeight = height;
        }
        private void SetDoorColor(object sender, EventArgs e)
        {
            string color = this.avaiblableDoorColor.GetChecked();
            if (color == "No door")
            {
                this.layer.DoorType = null;
            }
            else
            {
                if (color != "Verre")
                {
                    this.layer.DoorType = new ClassicDoor(Color.FromName(ColorMapper.MapColor(color)));
                    this.blockViewer.DoorColor = Color.FromName(ColorMapper.MapColor(color));
                } else
                {
                    this.layer.DoorType = new GlassDoor();
                }
            }
        }

        public void SetlayerWidth(int width)
        {
            this.blockViewer.LayerWidth = width;
            this.layer.Width = width;
        }

        public void SetlayerDepth(int depth)
        {
            this.blockViewer.LayerDepth = depth;
            this.layer.Depth = depth;
        }

        private void MountLayout(List<int> availablePanelHeight, List<string> availablePanelColor, List<string> avaiblableDoorColor)
        {
            avaiblableDoorColor.Add("No door");  
            this.availablePanelHeight = new RadioButtonLayout<int>(0,this.SetLayerHeight, availablePanelHeight);
            this.availablePanelColor = new RadioButtonLayout<string>(100, this.SetPanelColor, availablePanelColor);
            this.avaiblableDoorColor = new RadioButtonLayout<string>(200, this.SetDoorColor, avaiblableDoorColor);

            this.Controls.Add(this.availablePanelHeight);
            this.Controls.Add(this.availablePanelColor);

            // Mounting layout
            this.Location = new System.Drawing.Point(0, 165);
            this.Size = new System.Drawing.Size(400, 300);
            this.BackColor = System.Drawing.Color.Red;
        }

        public Block GetBlock()
        {
            return this.layer;
        }

        internal void SetBlockViewerColor(Color color)
        {
            this.blockViewer.BackColor = color;

        }

        public override void SetData(Dictionary<string, object> dataToSet)
        {
            return;
        }

        public BlockViewer GetBlockViewer()
        {
            return this.blockViewer;
        }


        public void DisplayDoorLayout(bool v)
        {
            if (v)
            {
                this.Controls.Add(this.avaiblableDoorColor);
            }
        }
    }
}
