using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Todo :   - Fix the set and get data function
 *          - May be set this class as an interface and create a class for every kind of block
 * 
 */

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
        private RadioButtonLayout availablePanelHeight;
        private RadioButtonLayout availablePanelColor ;
        private RadioButtonLayout avaiblableDoorColor;

        private int kitBoxWidth;

        public LayerDataPanel(int heightOfBlockViewer, List<string> availablePanelColor, List<int> availableHeight, List<string> avaiblableDoorColor, System.EventHandler clickHandler) : base()
        {
            this.layer = new Layer(null);
            this.blockViewer = new BlockViewer(heightOfBlockViewer, null);
            this.blockViewer.Click += clickHandler;

            this.MountLayout(availableHeight, availablePanelColor, avaiblableDoorColor);
        }

        private void SetPanelColor(object sender, EventArgs e)
        {
            Color color = Color.FromName(ColorMapper.MapColor(this.availablePanelColor.GetStringChecked()));
            this.layer.PanelColor = color;
            this.blockViewer.BackColor = Color.FromArgb(125, color);
        }

        private void SetHeight(object sender, EventArgs e)
        {
            this.layer.Height = this.availablePanelHeight.GetIntChecked();
        }
        private void SetDoorColor(object sender, EventArgs e)
        {
            string color = this.avaiblableDoorColor.GetStringChecked();
            if (color != "Verre")
            {
                this.blockViewer.DoorColor = Color.FromName(ColorMapper.MapColor(color));
                this.layer.DoorColor = Color.FromName(ColorMapper.MapColor(color));
            }
        }


        private void MountLayout(List<int> availablePanelHeight, List<string> availablePanelColor, List<string> avaiblableDoorColor)
        {
            this.avaiblableDoorColor = new RadioButtonLayout(200, this.SetDoorColor, new List<string>{ "coucou" });     
            this.availablePanelHeight = new RadioButtonLayout(0,this.SetHeight, availablePanelHeight);
            this.availablePanelColor = new RadioButtonLayout(100, this.SetPanelColor, availablePanelColor);
            
            this.Controls.Add(this.availablePanelHeight);
            this.Controls.Add(this.availablePanelColor);
            // Mounting layout
            this.Location = new System.Drawing.Point(0, 165);
            this.Size = new System.Drawing.Size(400, 300);
            this.BackColor = System.Drawing.Color.Red;
        }

        public override Dictionary<String, object> GetData()
        {
            return new Dictionary<String, object>
            {
                
            };
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

        internal void DisplayDoorData()
        {
            throw new NotImplementedException();
        }

        internal void DiplaysDoorLayout(bool v)
        {
            if (v)
            {
                this.Controls.Add(avaiblableDoorColor);
            }else
            {
                this.Controls.Remove(avaiblableDoorColor);
            }
        }
    }
}
