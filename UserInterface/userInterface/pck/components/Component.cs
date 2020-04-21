using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace userInterface
{
    public abstract class Component
    {
        protected int height;
        protected int depth;
        protected int width;

        public int Width { get => width; set => width = value; }
        public int Depth { get => depth; set => depth = value; }
        public int Height { get => height; set => height = value; }

        protected string description;

        //public abstract Dictionary<String, Component> getData();
        public abstract string GetCode();
        public abstract void DebugPrint();

    }
}
