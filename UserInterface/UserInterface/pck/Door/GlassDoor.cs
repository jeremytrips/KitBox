using System;
using System.Collections.Generic;

namespace userInterface
{
    /*Inheritance of the abstract class door*/
    class GlassDoor : Door
    {
        /*Builder*/
        public GlassDoor()
        {
            this.width = width;
            this.type = "GlassDoor";
        }

        /*
         * Returns a dictionary with all panel information
         */
        public override Dictionary<string, Object> GetData()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>
            {
                { "type", this.type },
                { "ref", this.name },
                { "code", this.code },
            };
            return Description;
        }
    }
}