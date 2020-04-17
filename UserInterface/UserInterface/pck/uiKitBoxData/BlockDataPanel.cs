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
    class BlockDataPanel: DataPanel
    {
        /*
         * BlockDataPanel 
         * =================
         * Simple layout that display the selecter layer data ( color, door, height, ...)
         * 
         */

        private Block layer;
        private BlockViewer blockViewer;
        private ComboBox availablePanelColor = new ComboBox();
        private ComboBox availableDoorHeightLayer = new ComboBox();
        private ComboBox availableNoDoorHeightLayer = new ComboBox();

        public BlockDataPanel(int numberOfPanelList, List<string> availablePanelColor, System.EventHandler clickHandler) : base()
        {
            Console.WriteLine(numberOfPanelList);
            this.layer = new Layer(null);
            this.blockViewer = new BlockViewer(numberOfPanelList, null);
            this.blockViewer.Click += clickHandler;
            this.availablePanelColor.Items.AddRange(availablePanelColor.ToArray());
            this.availablePanelColor.SelectedIndexChanged += new EventHandler(this.SetColor);
            this.MountLayout();
        }

        private void SetColor(object sender, EventArgs e)
        {
            Color color = Color.FromName(ColorMapper.MapColor((string)this.availablePanelColor.SelectedItem));
            this.layer.Color = color;
            this.blockViewer.BackColor = Color.FromArgb(125, color);
        }

        private void MountLayout()
        {
            this.Controls.Add(this.availablePanelColor);
            // Mounting layout
            this.Location = new System.Drawing.Point(0, 165);
            this.Size = new System.Drawing.Size(400, 300);
            this.BackColor = System.Drawing.Color.Red;

            this.availablePanelColor.FormattingEnabled = true;
            this.availablePanelColor.Location = new System.Drawing.Point(239, 82);
            this.availablePanelColor.Size = new System.Drawing.Size(121, 21);

            this.availablePanelColor.SelectedIndexChanged += new EventHandler(this.SetBlockPanelColor);
        }

        private void SetBlockPanelColor(object sender, EventArgs e)
        {
            Color color = Color.AliceBlue;
            if (this.availablePanelColor.SelectedItem.ToString().Contains("Galvani"))
            {
                color = Color.FromName("SteelBlue");

            }
            else
            // Insert here color that are not in the color map of c#
            {
                color = Color.FromName((string)this.availablePanelColor.SelectedItem);
            }
            color = Color.AliceBlue;
            this.layer.Color = color;
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
    }
}
