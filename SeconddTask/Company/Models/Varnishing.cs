namespace SeconddTask
{
	internal class Varnishing : IProcessing
	{
		/// <summary>
		/// This method deals with the varnishing of the table and increases its cost as a result
		/// </summary>
		/// <param name="table">The input parameter is the table that needs to be locked</param>
		public void Operation(Table table)
			=> table.Price *= 1.2m;
	}
}
