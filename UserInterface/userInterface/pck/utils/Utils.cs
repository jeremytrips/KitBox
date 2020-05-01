using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class Utils
    {
        static public Dictionary<string, int> ClearBill(List<List<List<string>>> bill)
        {
            Dictionary<string, int> clearedBill = new Dictionary<string, int> { };
            foreach(List<List<string>> kitbox in bill)
            {
                foreach(List<string> block in kitbox )
                {
                    foreach(string component in block)
                    {
                        if(clearedBill.ContainsKey(component))
                        {
                            // Incrémenter le composent
                            clearedBill[component] = clearedBill[component] + 1;
                        } else
                        {
                            clearedBill.Add(component, 1);
                        }
                    }
                }
            }
            //foreach(KeyValuePair<string, int > keyValue in clearedBill)
            //{
            //    Console.WriteLine(String.Format("{0}: {1}", keyValue.Key, keyValue.Value));
            //}
            return clearedBill;
        }
    }
}
