using System;
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    public class Angle: Component 
    {
        private Color color;
        private bool cutted;
        protected string attribute = "COR";

        public Color Color { get => color; set => color = value; }

        public Angle()
        {
        }

        public override string GetCode()
        {
            string dec = this.cutted ? "DEC" : "";
            return this.attribute + this.height.ToString() + ColorMapper.MapPrefix(this.Color) + dec;

        }

        public override void DebugPrint()
        {
            this.GetCode();
        }


        /*Returns a dictionary with all panel information*/
        public Dictionary<string, Object> GetDescription()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>();
            Description.Add("color", this.Color);
            Description.Add("code", this.height);
            return Description;
        }

    }
}

