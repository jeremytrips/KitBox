using System.Collections.Generic;
using System.Drawing;


namespace userInterface
{
    class KitBox
    {
        private Color angleColor;
        private Angle[] angles;

        private Block[] kitBoxComponent;

        private static int id = 0;
        private double price;

        private int selfId;

        private int width;
        private int depth;

        public KitBox()
        {
        }

        public KitBox(List<Block> blockList)
        {
            // Recontruct kitbox from order
        }
        
        public int Width { get => width; set => width = value; }

        public int Depth { get => depth; set => depth = value; }
        public Color AngleColor { get => angleColor; set => angleColor = value; }

        public bool Equals(int i)
        {
            return this.selfId == i;
        }

        public override string ToString()
        {
            return this.selfId.ToString();
        }

        public Dictionary<string, object> GetData()
        {
            return new Dictionary<string, object>
            {

            };
        }

        public double ComputePrice()
        {
            double price = 0;
            foreach (Layer box in this.kitBoxComponent)
            {
                price += box.ComputePrice();
            }

            return price;
        }
    }
}
