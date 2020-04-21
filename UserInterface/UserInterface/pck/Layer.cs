
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    class Layer : Block
    {
        private Color panelColor;
        private bool hasDoor;
        private Color doorColor;
        private BackPanel backPanel = new BackPanel();
        private LeftRightPanel leftRightPanel = new LeftRightPanel();
        private TopBottomPanel topBottomPanel = new TopBottomPanel();

        public Layer(int width, int depth)
        {
            this.Width = width;
            this.Depth = depth;
        }

        public Color DoorColor { get => doorColor; set => doorColor = value; }
        public Color PanelColor { get => panelColor; set
            {
                panelColor = value;
                backPanel.Color = value;
                leftRightPanel.Color = value;
                topBottomPanel.Color = value;
            }
        }

        public bool HasDoor { get => hasDoor; set => hasDoor = value; }

        public new int Width { get => width; set
            {
                this.width = value;
                this.backPanel.Width = value;
                this.topBottomPanel.Width = value;
            }

        }

        public new int Depth
        {
            get => this.depth; set
            {
                this.depth = value;
                this.backPanel.Depth = value;
                this.topBottomPanel.Depth = value;
            }

        }


        public void Build(int width, int depth)
        {
        }

        public override double ComputePrice()
        {
            throw new System.NotImplementedException();
        }

        public override Dictionary<string, object> GetDescription()
        {
            Dictionary<string, object> a = new Dictionary<string, object>();    
            return a;
        }

        public Dictionary<string, int> GetParts()
        {
            
            return new Dictionary<string, int>
            {

            };
        }

        public override string ToListDescription()
        {
            return "Description in the Layer.cs";
        }
    }
}
