namespace SeconddTask
{
	public interface IMachine
	{
		/// <summary>
		///This method creates a part of the table
		/// </summary>
		/// <param name="partOfTable">The first parameter is the "instruction" for creating the necessary part of the table</param>
		/// <param name="material">The second parameter is the material from which it is necessary to make a part of the table</param>
		/// <returns></returns>
		public PartOfTable CreaterOfPart(PartOfTable partOfTable, Material material);
	}
}
