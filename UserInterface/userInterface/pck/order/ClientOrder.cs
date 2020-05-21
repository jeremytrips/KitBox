using System;
using System.Collections.Generic;

namespace userInterface
{
	public class ClientOrder
	{
		User user;
		private DateTime date = DateTime.Now;
		private short id = Database.GetNumberOfOrder();
		private Dictionary<string, int> clearedBill;
		private List<List<object>> billDescription;
		private double price;
		private double alreadyPaid;

		public ClientOrder()
		{}

		public Dictionary<string, int> ClearedBill
		{
			get => clearedBill; set
			{
				clearedBill = value;
				this.billDescription = Database.HandleOrder(this.clearedBill);
			}
		}

		private void CheckAvailability()
		{
			foreach(List<object> list in this.billDescription)
			{
				if(!(bool)list[2])
				{
					this.alreadyPaid = this.price / 10;
				}
				else
				{
					this.alreadyPaid = this.price;
				}
			}
		}
		public List<List<object>> BillDescription { get => billDescription; }
		public double Price { get => price; set => price = value; }
		internal User User { get => user; set => user = value; }

		public void SaveOrder()
		{
			this.CheckAvailability();
;			Database.CreateOrder(this.id, this.date, this.price, this.alreadyPaid, this.user.OrderName);
			foreach (KeyValuePair < string, int> keyValuePair in this.clearedBill)
			{
				Database.SaveOrder(keyValuePair, this.id);
				Database.HandleStock(keyValuePair);
			}
		}

        internal void FetchOldOrder(string oldOrderName)
        {
			List<object> userData = Database.FetchUserData(oldOrderName);
			this.clearedBill = Database.FetchClearedBill((short)userData[0]);
			this.billDescription = Database.HandleOrder(this.clearedBill);
        }

    }
}