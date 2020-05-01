using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class User
    {
        private string name;
        private string address;
        private string phoneNumber;

        private bool saveOrder;
        private string orderName;

        public User(string name, string address, string phoneNumber, bool saveOrder, string orderName) 
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.saveOrder = saveOrder;
            this.orderName = orderName;
        }

        public Dictionary<string, string> DescribeUser()
        {
            Dictionary<string, string> a = new Dictionary<string, string>
            {
                { "Name", this.name },
                { "Address", this.address },
                { "Phone number", this.phoneNumber}
            };
            if (this.saveOrder)
            {
                a.Add("Order Name", this.orderName);
            }
            return a;
                
        }
    }
}
