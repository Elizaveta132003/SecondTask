namespace SeconddTask
{
	internal class MachineForAnyShape : IMachine
	{
		/// <summary>
		/// This method cuts out of the material the part of any shape we need
		/// </summary>
		/// <param name="partOfTable">The first input parameter is the part of the table that we need to get</param>
		/// <param name="material">The second input parameter is the material from which we will cut</param>
		/// <returns></returns>
		public PartOfTable CreaterOfPart(PartOfTable partOfTable, Material material)
		{
			material.Lenght -= partOfTable.Material.Lenght;
			material.Width -= partOfTable.Material.Width;
			material.Thickness -= partOfTable.Material.Thickness;


			return partOfTable;
		}
	}
}
