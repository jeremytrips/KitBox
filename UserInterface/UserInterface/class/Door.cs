using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class Door: Component
    {
        private int width;
        private string type;
        
        public Door(int i): base(i)
        {
            Console.WriteLine("Door " + i + " instanciate");
        }
    }
}
