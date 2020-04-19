
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    class Layer : Block
    {
        private Color panelColor;
        private bool hasDoor;
        private Color doorColor;
        private Component[] Component;

        public Layer(int[] size)
        {
            //this.width = size[0];
            //this.depth = size[1];

        }

        public Color DoorColor { get => doorColor; set => doorColor = value; }
        public Color PanelColor { get => panelColor; set => panelColor = value; }

        public void Build()
        {
            // Todo
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

        public Component[] GetParts()
        {
            return this.Component;
        }

        public override string ToListDescription()
        {
            return "Description in the Layer.cs";
        }
    }
}
