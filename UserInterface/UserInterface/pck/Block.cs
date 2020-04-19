using System;
using System.Collections.Generic;
using System.Drawing;
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
        private int height;

        private string code;

        public int Height { get => height; set =>height = value;}
        protected string Code { get => code; set => code = value; }

        public abstract String ToListDescription();
        public abstract Dictionary<string, object> GetDescription();
        public abstract double ComputePrice();
    }
}
