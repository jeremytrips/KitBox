using System;
using System.Collections.Generic;
using System.Drawing;


namespace userInterface
{
    class KitBox
    {
        
        private Angle angle = new Angle();

        private List<Block> kitBoxBlock = new List<Block> { };

        private static int id = 0;

        private int selfId;

        private int width;
        private int depth;
        private int height;

        private List<int> availableAngleHeight;

        public KitBox()
        {
        }

        private void ComputeHeight()
        {
            int height = 0;
            foreach(Block block in this.kitBoxBlock)
            {
                height += block.Height + 2 * 2;
            }
            this.height = height;
            if (this.availableAngleHeight.Contains(this.height))
            {
                this.angle.Height = this.height;
                this.angle.Cutted = false;  
            } else
            {
                foreach(int x in this.availableAngleHeight)
                {
                    if(x>this.height)
                    {
                        this.angle.Height = x;
                        this.angle.Cutted = true;
                        break;
                    }
                }
            }
        }

        public void AddBlock(Block block)
        {
            this.kitBoxBlock.Add(block);
            this.ComputeHeight();
        }

        public void RemoveBlock(Block block)
        {
            this.kitBoxBlock.Remove(block);
            this.ComputeHeight();
        }
        
        public void Clear()
        {
            this.kitBoxBlock.Clear();
        }

        public int Width { get => width; set => this.width = value;  }

        public int Depth { get => depth; set => this.depth = value; }

        public Color AngleColor
        {
            set
            {
                this.angle.Color = value;
            }
        }

        public List<int> AvailableAngleHeight
        {
            get => availableAngleHeight; set
            {
                value.Sort();
                availableAngleHeight = value;
            }
        }
        public bool Equals(int i)
        {
            return this.selfId == i;
        }

        public double ComputePrice()
        {
            double price = 0;
            foreach (Layer box in this.kitBoxBlock)
            {
                price += box.ComputePrice();
            }
            return price;
        }

        public List<List<string>> GetCodes()
        {
            List<List<string>> bill =  new List<List<string>> { };
            foreach(Block block in this.kitBoxBlock)
            {
                bill.Add(block.GetCodes());
            }
            return bill;
        }
    }
}
