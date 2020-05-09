using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class WidthMapper
    {
        static private Dictionary<int, string> widthMapper = new Dictionary<int, string>
        {
            {62, "32" },
            {80, "42" },
            {100, "52" },
            {120, "62" }
        };

        public static string MapDoorWidth(int width)
        {
            Console.WriteLine(width);
            return widthMapper[width];
        }
    }
}
