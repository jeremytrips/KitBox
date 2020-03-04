
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    class Box : Block
    {
        private string pannelsColor;
        private int height;
        private int width;
        private int depth;
        private bool hasDoor;
        private string doorColor;
        private Component[] Component;

        public Box(int height, Color pannelsColor,  int[] size, string door)
        {
            this.height = height;
            this.hasDoor = (door == null) ? false : true;
            if (this.hasDoor)
            {
                this.doorColor = door;
            }
            this.width = size[0];
            this.height = size[1];

        }

        public void Build()
        {
            // Todo
        }

        public Dictionary<string, object> GetDescription()
        {
            Dictionary<string, object> a = new Dictionary<string, object>();
            return a;
        }

        public Component[] GetParts()
        {
            return this.Component;
        }
        
        public double GetPrice()
        {
            return -1;
        }

        public new string ToListDescription()
        {
            return null;
        }
    }
}
