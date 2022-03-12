namespace SeconddTask
{
	public abstract class PartOfTable
	{
		public Share Share { get; set; }
		public Material Material { get; set; }
		public decimal Price { get; set; }

		protected PartOfTable(Share share, Material material, decimal price)
		{
			Share = share;
			Material = material;
			Price = price;
		}
	}
}
