using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userInterface;

/*
 * TODO :   - Remember how to impose a child class to have a certain function (ToListDescription)
 *          - Create a widget class to properly display block
 */

namespace userInterface
{
    abstract class Block
    {
        protected double price;
        protected int length;
        protected string name;
        protected string code;

        public abstract String ToListDescription();
        Dictionary<string, object> GetDescription()
        {
            return null;
        }
        double GetPrice()
        {
            return this.price;
        }
        //Component[] GetParts();
    }
}
