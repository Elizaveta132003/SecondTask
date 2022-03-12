namespace SeconddTask
{
	public abstract class Subsystem
	{
		public Chipboard ChipboardForLeg { get; set; }
		public Chipboard ChipboardForWorktop { get; set; }

		protected Subsystem(Chipboard chipboardForLeg, Chipboard chipboardForWorktop)
		{
			ChipboardForLeg = chipboardForLeg;
			ChipboardForWorktop = chipboardForWorktop;
		}

		/// <summary>
		///  This method sends the "instructions" for making a kitchen leg to the machine and returns the finished table leg
		/// </summary>
		/// <returns></returns>
		protected abstract Leg OperationOne(Chipboard chipboardSheetForTheLeg);

		/// <summary>
		///  This method sends the "instructions" for making a countertop for a kitchen table to the machine and returns the necessary finished countertop
		/// </summary>
		/// <returns></returns>
		protected abstract Worktop OperationTwo(Chipboard chipboardSheetForTheWorktop);

		/// <summary>
		///  This method sends to the machine "instructions" for the manufacture of accessories for the kitchen table
		/// </summary>
		/// <returns></returns>
		protected abstract Accessories OperationThree();

		/// <summary>
		/// This method returns a finished table made in parts according to the "instructions"
		/// </summary>
		/// <returns></returns>
		public abstract Table OperationUnion(Chipboard chipboardSheetForTheLeg, Chipboard chipboardSheetForTheWorktop);

		/// <summary>
		/// This method takes a ready-made table and processes it
		/// </summary>
		/// <param name="table"></param>
		/// <returns></returns>
		public abstract Table OperationFour(Table table);

	}
}
