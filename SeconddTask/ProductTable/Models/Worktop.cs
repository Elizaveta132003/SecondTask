namespace SeconddTask
{
	public class Worktop : PartOfTable
	{

		public Worktop(Share share, Chipboard material) : base(share, material, (decimal)(material.Lenght + material.Width + material.Thickness) * 2)
		{ }

		public Worktop() : base(null, new Chipboard(), 0)
		{ }
	}
}
