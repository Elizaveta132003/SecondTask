namespace SeconddTask.Company.Models
{
	internal class SupplerOfMetal : Supplier
	{
		public override PartOfTable Order(PartOfTable partOfTable)
		{
			partOfTable.Price = 20;
			return partOfTable;
		}
	}
}
