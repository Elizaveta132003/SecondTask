namespace SeconddTask
{
	public class Leg : PartOfTable
	{

		public Leg(Material material) : base(new RectangularShape(), material, (decimal)(material.Lenght + material.Width + material.Thickness) * 2)
		{ }
		public Leg() : base(new RectangularShape(), null, 0)
		{ }
	}
}
