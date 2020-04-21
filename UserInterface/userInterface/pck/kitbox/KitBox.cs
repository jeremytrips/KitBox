using System;
using System.Collections.Generic;
using System.Drawing;


namespace userInterface
{
    class KitBox
    {
        private Color angleColor = Color.White;
        private Angle angle = new Angle();

        private List<Block> kitBoxComponent = new List<Block> { };

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

        public void AddBlock(Block block)
        {
            this.kitBoxComponent.Add(block);
        }

        public void RemoveBlock(Block block)
        {
            this.kitBoxComponent.Remove(block);
        }
        
        public int Width { get => width; set
            {
                width = value;
                try
                {

                    foreach (Block block in this.kitBoxComponent)
                    {
                        block.Width = value;
                    }
                }
                catch { }
            }
        }

        public int Depth { get => depth; set
            {
                depth = value;
                try
                {
                    foreach (Block block in this.kitBoxComponent)
                    {
                        block.Depth = value;
                    }
                } catch { }
            }
        }
        public Color AngleColor
        {
            get => angleColor; set
            {
                angleColor = value;
                this.angle.Color = value;
            }
        }

        public bool Equals(int i)
        {
            return this.selfId == i;
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
