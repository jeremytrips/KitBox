using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    public abstract class DataPanel : System.Windows.Forms.Panel, IUiData
    {
        public abstract Dictionary<string, object> GetData();
        public abstract void SetData(Dictionary<string, object> dataToSet);
    }
}
