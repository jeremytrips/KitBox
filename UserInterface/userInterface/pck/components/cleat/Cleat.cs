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

        const string attribute = "TAS";
        /*Builder*/
        public Cleat()
        {}

        public override string GetCode()
        {
            return attribute + this.height.ToString();
        }

        public override void DebugPrint()
        {
            Console.WriteLine(this.GetCode());
        }

        //public override Dictionary<string, Component> getData()
        //{
        //    throw new NotImplementedException();
        //}

        /*Returns a dictionary with all panel information*/
        //public Dictionary<string, Object> GetDescription()
        //{
        //    Dictionary<string, Object> Description = new Dictionary<string, Object>
        //    {
        //        { "price", this.price },
        //        { "length", this.length },
        //        { "ref", this.name }
        //    };
        //    return Description;
        //}
    }
}