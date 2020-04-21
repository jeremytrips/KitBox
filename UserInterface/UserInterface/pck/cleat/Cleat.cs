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
        private double price;
        private int length;
        private string name;

        /*Builder*/
        public Cleat(float price, int length)
        {

        }

        public override string GetCode()
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, Component> getData()
        {
            throw new NotImplementedException();
        }

        /*Returns a dictionary with all panel information*/
        public Dictionary<string, Object> GetDescription()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>
            {
                { "price", this.price },
                { "length", this.length },
                { "ref", this.name }
            };
            return Description;
        }


    }
}