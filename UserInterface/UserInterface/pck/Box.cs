
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

        public Box(int[] size)
        {
            this.width = size[0];
            this.depth = size[1];

        }

        public void Build()
        {
            // Todo
        }

        public override Dictionary<string, object> GetDescription()
        {
            Dictionary<string, object> a = new Dictionary<string, object>();
            return a;
        }

        //public override Dictionary<string, object> GetDescription()
        //{
        //    throw new System.NotImplementedException();
        //}

        public Component[] GetParts()
        {
            return this.Component;
        }
        
        public double GetPrice()
        {
            return -1;
        }

        public override string ToListDescription()
        {
            return "Description in the Box.cs";
        }
    }
}
