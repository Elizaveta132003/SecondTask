using SeconddTask.ProductTable.Models;

namespace SeconddTask.Company.Models
{
	public class KitchenTableSubsystem : Subsystem
	{
		public KitchenTableSubsystem() : base(new Chipboard(150, 5, 5), new Chipboard(200, 100, 3))
		{
		}


		/// <summary>
		/// This method takes a ready-made table and processes it
		/// </summary>
		/// <param name="table">Input parameter-ready table</param>
		/// <returns></returns>
		public override Table OperationFour(Table table)
		{
			Varnishing varnishing = new Varnishing();
			varnishing.Operation(table);
			PastingWithPaper pastingWithPaper = new PastingWithPaper();
			pastingWithPaper.Operation(table);
			return table;
		}

		/// <summary>
		/// This method returns a finished table made in parts according to the "instructions"
		/// </summary>
		/// <returns></returns>
		public override Table OperationUnion(Chipboard chipboardSheetForTheLeg, Chipboard chipboardSheetForTheWorktop)
		{
			return new KitchenTable(OperationOne(chipboardSheetForTheLeg), OperationTwo(chipboardSheetForTheWorktop), OperationThree());
		}

		/// <summary>
		/// This method sends the "instructions" for making a kitchen leg to the machine and returns the finished table leg
		/// </summary>
		/// <returns></returns>
		protected override Leg OperationOne(Chipboard chipboardSheetForTheLeg)
		{

			MachineForAnyShape machineForAnyShape = new MachineForAnyShape();
			Leg leg = (Leg)machineForAnyShape.CreaterOfPart(new Leg(ChipboardForLeg), chipboardSheetForTheLeg);
			return leg;

		}

		/// <summary>
		/// This method sends to the machine "instructions" for the manufacture of accessories for the kitchen table 
		/// </summary>
		/// <returns></returns>
		protected override Accessories OperationThree()
		{
			var supplerOfMetal = new SupplerOfMetal();
			Accessories accessories = (Accessories)supplerOfMetal.Order(new Accessories(new Metal(2, 1, 1), new OvalShape()));
			return accessories;
		}


		/// <summary>
		/// This method sends the "instructions" for making a countertop for a kitchen table to the machine and returns the necessary finished countertop
		/// </summary>
		/// <returns></returns>
		protected override Worktop OperationTwo(Chipboard chipboardSheetForTheWorktop)
		{

			MachineForRectangularShape machineForRectangularShape = new MachineForRectangularShape();
			Worktop worktop = (Worktop)machineForRectangularShape.CreaterOfPart(new Worktop(new RectangularShape(),
				ChipboardForWorktop), chipboardSheetForTheWorktop);
			return worktop;
		}
	}
}
