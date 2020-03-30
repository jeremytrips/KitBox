﻿using System;
using System.Collections.Generic;

namespace userInterface
{
    /*
     * Class that groups all panels
     */
    abstract class Panel : Component
    {
        private string color;

        /*
         * Returns a dictionary with all panel information
         */
        public Dictionary<string, Object> GetDescription()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>
            {
                { "price", this.price },
                { "length", this.length },
                { "color", this.color },
                { "code", this.code },
                { "ref", this.name }
            };
            return Description;
        }
    }
}