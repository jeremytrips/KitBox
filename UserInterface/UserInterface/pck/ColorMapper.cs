using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class ColorMapper
    {
        static private Dictionary<string, string> colorMapper = new Dictionary<string, string>
            {
                { "Blanc", "white" },
                { "Brun", "Brown" },
                { "Galvanise", "LightSteelBlue " },
                { "Noir", "black" }
            };

        public static string MapColor(string color)
        {
            return colorMapper[color];
        }
    }
}
