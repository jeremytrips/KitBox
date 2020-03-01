using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    class Box : IBox
    {
        private string pannelsColor;
        private int height;
        private int width;
        private int depth;
        private bool hasDoor;
        private string doorColor;
        private Part[] parts;

        public Box(int height, string pannelsColor,  int[] size, string door)
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

        public Part[] GetParts()
        {
            return this.parts;
        }
        
        public double GetPrice()
        {
            return -1;
        }
    }
}
