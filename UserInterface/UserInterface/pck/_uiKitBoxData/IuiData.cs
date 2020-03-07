using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    interface IUiData
    {
        Dictionary<String, object> GetData();
        void SetData(Dictionary<string, object> dataToSet);

    }
}
