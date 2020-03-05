using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * TODO : Fix the ToListDescription

*/

namespace userInterface
{
    public abstract class Component
    {
        protected double price;
        protected int length;
        protected string name;
        protected string code;
        
        public Component()
        {

        }

        public Dictionary<String, Component> getDescription()
        {
            return null;
        }

        public string ToListDescription()
        {
            return "I'm the description";
        }

        public override string ToString()
        {
            return String.Format("{}", this.price) ;
        }
    }
}
