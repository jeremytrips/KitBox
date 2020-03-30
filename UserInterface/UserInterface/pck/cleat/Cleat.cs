﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    /* Class that groups all cleats*/
    class Cleat : Component
    {

        /*Builder*/
        public Cleat(float price, int length)
        {

        }

        /*Returns a dictionary with all panel information*/
        public new Dictionary<string, Object> GetDescription()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>
            {
                { "price", this.price },
                { "length", this.length },
                { "ref", this.name },
                { "code", this.code }
            };
            return Description;
        }
    }
}