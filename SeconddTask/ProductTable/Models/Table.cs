using System;
using System.Collections.Generic;

namespace SeconddTask
{
	public abstract class Table
	{
		public Leg Leg { get; set; }
		public Worktop Worktop { get; set; }
		public decimal Price { get; set; }
		public Accessories Accessories { get; set; }
		public string Name { get; set; }

		protected Table(Leg leg, Worktop worktop, Accessories accessories, string name)
		{
			Leg = leg;
			Worktop = worktop;
			Accessories = accessories;
			Price = leg.Price + worktop.Price + accessories.Price;
			Name = name;
		}
		public override bool Equals(object obj)
		{
			return obj is Table table &&
				   EqualityComparer<Leg>.Default.Equals(Leg, table.Leg) &&
				   EqualityComparer<Worktop>.Default.Equals(Worktop, table.Worktop) &&
				   Price == table.Price &&
				   EqualityComparer<Accessories>.Default.Equals(Accessories, table.Accessories);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Leg, Worktop, Price, Accessories);
		}

		public override string ToString()
		{
			return $"Затраты на ДСП:{Worktop.Material.Price + Leg.Material.Price} Затраты на фурнитуру:{Accessories.Price}";
		}
	}
}
