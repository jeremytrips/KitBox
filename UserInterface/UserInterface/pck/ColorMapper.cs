using System;
using System.Collections.Generic;
using System.Drawing;
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

        static private Dictionary<string, string> reverseColorMapper = new Dictionary<string, string>
            {
                { "white", "Blanc" },
                { "Brown", "Brun"  },
                { "LightSteelBlue " , "Galvanise"},
                { "black" , "Noir" }
            };

        public static string MapColor(string color)
        {
            return colorMapper[color];
        }

        public static string MapColorFrench(Color color)
        {
            return reverseColorMapper[color.Name];
        }
    }
}
