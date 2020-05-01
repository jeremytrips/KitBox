using System;
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    public class Angle: Component 
    {
        private Color color = Color.White;
        private bool cutted = false;
        protected string attribute = "COR";

        public Color Color { get => color; set => color = value; }
        public bool Cutted { get => cutted; set => cutted = value; }

        public Angle()
        {
        }

        public override string GetCode()
        {
            string dec = this.Cutted ? "DEC" : "";
            return this.attribute + this.height.ToString() + ColorMapper.MapPrefix(this.Color) + dec;

        }

        public override void DebugPrint()
        {
            this.GetCode();
        }
    }
}

