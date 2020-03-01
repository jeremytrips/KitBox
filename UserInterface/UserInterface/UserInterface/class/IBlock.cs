using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    interface IBlock
    {
        Dictionary<string, object> GetDescription();
        double GetPrice();
        Part[] GetParts();
    }
}
