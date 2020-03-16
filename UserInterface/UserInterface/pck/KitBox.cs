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

        public KitBox()
        {
            // to fix
            //Random a = new Random();
            //this.price = a.Next();
            this.selfId = id;
            id++;
        }

        public int Id { get
            {
                return this.selfId;
            }
        }

        public bool Equals(int i)
        {
            return this.selfId == i;
        }

        public override string ToString()
        {
            return this.selfId.ToString();
        }
    }
}
