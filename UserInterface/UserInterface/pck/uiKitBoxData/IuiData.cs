using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    interface IUiData
    {
        Dictionary<string, object> GetData();
        void SetData(Dictionary<string, object> dataToSet);

    }
}
