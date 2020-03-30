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
        protected int height;
        protected string description;
        protected string code;

        public abstract Dictionary<String, Component> getData();

    }
}
