using System;
using System.Collections.Generic;


namespace userInterface
{
	abstract class Order
	{	
		protected Dictionary<string, int> orderedComponents = new Dictionary<string, int> { };	
	}
}