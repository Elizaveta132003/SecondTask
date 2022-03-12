namespace SeconddTask.ProductTable.Models
{
	public class KitchenTable : Table
	{
		public KitchenTable(Leg leg, Worktop worktop, Accessories accessories) : base(leg, worktop, accessories, "Kitchen table")
		{
		}
	}
}
