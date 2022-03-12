namespace SeconddTask
{
	public class Facade
	{
		public Subsystem _subsystem;

		public Chipboard ChipboardForLeg { get => _subsystem.ChipboardForLeg; set => _subsystem.ChipboardForLeg = value; }
		public Chipboard ChipboardForWorktop { get => _subsystem.ChipboardForWorktop; set => _subsystem.ChipboardForWorktop = value; }

		public Facade(Subsystem subsystem)
		{
			this._subsystem = subsystem;
		}

		/// <summary>
		/// This method returns the finished table that we need
		/// </summary>
		/// <returns></returns>
		public Table Operation(Chipboard chipboardSheetForTheLeg, Chipboard chipboardSheetForTheWorktop)
		{
			Table table = _subsystem.OperationUnion(chipboardSheetForTheLeg, chipboardSheetForTheWorktop);
			_subsystem.OperationFour(table);
			return table;
		}
	}
}
