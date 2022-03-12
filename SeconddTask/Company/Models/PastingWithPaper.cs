namespace SeconddTask
{
	internal class PastingWithPaper : IProcessing
	{
		/// <summary>
		/// This method deals with papering the table and increases the cost of the table accordingly
		/// </summary>
		/// <param name="table">The input parameter is the finished table that needs to be processed</param>
		public void Operation(Table table)
			=> table.Price *= 1.5m;
	}
}
