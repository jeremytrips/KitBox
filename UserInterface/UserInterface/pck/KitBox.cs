using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class KitBox
    {
        private double price;
        private Box[] kitBoxComponent;

        public KitBox()
        {
            // to fix
            Random a = new Random();
            this.price = a.Next();
        }
    }
}
