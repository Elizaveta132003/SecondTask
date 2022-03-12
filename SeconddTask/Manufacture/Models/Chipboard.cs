namespace SeconddTask
{
	public class Chipboard : Material
	{

		public Chipboard(double lenght, double width, double thickness) : base(lenght, width, thickness, (decimal)((lenght + width + thickness) * 2))
		{
		}
		public Chipboard() : base("Chipboard")
		{ }
	}
}
