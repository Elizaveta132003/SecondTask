using System.Linq;

namespace SeconddTask
{
	public class Client
	{
		private ListOFChipboard _chipboards;

		public Client(ListOFChipboard chipboards)
		{
			_chipboards = chipboards;
		}

		public Table ClientCode(Facade facade)
		{
			var chiboard = SearchForSuitableChipboardForLeg(facade);
			return facade.Operation(chiboard, SearchForSuitableChipboardForWorktop(facade, chiboard));
		}

		/// <summary>
		/// This method removes from the list of chipboards those that have already been used
		/// </summary>
		public void RemovingChipboardFromList()
		{
			foreach (var chipboard in _chipboards.Chipboards)
			{
				if (chipboard.Thickness <= 0 || chipboard.Width <= 0 || chipboard.Lenght <= 0)
				{
					_chipboards.Remove(chipboard);
				}
			}
		}

		/// <summary>
		/// This method searches for a suitable chipboard sheet for the leg
		/// </summary>
		/// <param name="facade">The input parameter is the facade object</param>
		/// <returns></returns>
		public Chipboard SearchForSuitableChipboardForLeg(Facade facade)
		{
			if (facade.ChipboardForLeg != null)
			{
				var appropriateChipboardLeg = (from i in _chipboards.Chipboards
											   where
						  i.Lenght >= facade._subsystem.ChipboardForLeg.Lenght &&
						  i.Width >= facade._subsystem.ChipboardForLeg.Width &&
						  i.Thickness >= facade._subsystem.ChipboardForLeg.Thickness
											   select i).ToList();
				if (appropriateChipboardLeg != null)
				{
					return appropriateChipboardLeg.Min();
				}
			}
			return null;
		}

		/// <summary>
		/// This method searches for a suitable chipboard sheet for the worktop
		/// </summary>
		/// <param name="facade">The input parameter is the facade object</param>
		/// <param name="chipboard">The input parameter is the chipboard object</param>
		/// <returns></returns>
		public Chipboard SearchForSuitableChipboardForWorktop(Facade facade, Chipboard chipboard)
		{
			if (facade._subsystem.ChipboardForWorktop != null)
			{
				var appropriateChipboardWorktop = (from i in _chipboards.Chipboards
												   where
						  i.Lenght >= facade._subsystem.ChipboardForWorktop.Lenght &&
						  i.Width >= facade._subsystem.ChipboardForWorktop.Width &&
						  i.Thickness >= facade._subsystem.ChipboardForWorktop.Thickness
												   select i).ToList();
				appropriateChipboardWorktop.Remove(chipboard);
				if (appropriateChipboardWorktop != null)
				{
					return appropriateChipboardWorktop.Min();
				}
			}
			return null;
		}


	}
}
