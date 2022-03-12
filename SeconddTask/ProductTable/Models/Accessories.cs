namespace SeconddTask
{
	public class Accessories : PartOfTable
	{
		public Accessories(Metal material, Share share) : base(share, material, (decimal)(material.Lenght + material.Width + material.Thickness) * 2)
		{ }
		public Accessories() : base(null, null, 0)
		{ }


	}
}
