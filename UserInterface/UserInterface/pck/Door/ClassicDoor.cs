using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    /*Inheritance of the abstract class door, the classic door*/
    class ClassicDoor : Door
    {
        private string color;

        public ClassicDoor(string color) /*builder*/
        {
            this.color = color;
            this.height = height;
            this.type = "ClassicDoor";
        }

        /*Returns a dictionary with all panel information*/
        public override Dictionary<string, Object> GetDescription()
        {
            Dictionary<string, Object> Description = new Dictionary<string, Object>
            {
                { "height", this.height},
                { "color", this.color },
                { "type", this.type },
                { "code", this.code }
            };
            return Description;
        }
    }
}