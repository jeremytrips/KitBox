using System;
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    public class Angle
    {
        private readonly Color color;
        private int height;

        public Angle(Color color, int height)
        {
            this.color = color;
            this.height = height;
        }


        /*Returns a dictionary with all panel information*/
        public Dictionary<string, Object> GetDescription()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>();
            Description.Add("color", this.color);
            Description.Add("code", this.height);
            return Description;
        }

    }
}

