using System;

namespace SeconddTask
{
	public abstract class Material : IComparable<Material>
	{
		public double Lenght { get; set; }
		public double Width { get; set; }
		public double Thickness { get; set; }
		public decimal Price { get; set; }
		public string Name { get; }

		protected Material(double lenght, double width, double thickness, decimal price)
		{
			Lenght = lenght;
			Width = width;
			Thickness = thickness;
			Price = price;
		}

		protected Material(string name)
		{
			Name = name;
		}


		public int CompareTo(Material material)
		{
			if (material == null)
				return 1;
			if (Thickness + Lenght + Width >= material.Thickness + material.Width + material.Lenght)
				return 1;
			return -1;
		}

		public override bool Equals(object obj)
		{
			return obj is Material material &&
				   Lenght == material.Lenght &&
				   Width == material.Width &&
				   Thickness == material.Thickness &&
				   Name == material.Name;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Lenght, Width, Thickness, Name);
		}
	}
}
