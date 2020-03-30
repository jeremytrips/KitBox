using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class KitBox
    {
        private static int id = 0;
        private double price;
        private Box[] kitBoxComponent;
        private int selfId;
        private int width;
        private int depth;

        public KitBox()
        {
            // to fix
            //Random a = new Random();
            //this.price = a.Next();
            this.selfId = id;
            id++;
        }
        
        public int Width { get => width; set => width = value; }

        public int Depth { get => depth; set => depth = value; }

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
    }
}
