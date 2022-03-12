namespace SeconddTask
{
	public class Metal : Material
	{

		public Metal(double lenght, double width, double thickness) : base(lenght, width, thickness, (decimal)((lenght + width + thickness) * 2))
		{
		}
	}
}
