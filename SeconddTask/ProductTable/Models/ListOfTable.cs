using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SeconddTask.ProductTable.Models
{
	public class ListOfTable : IEnumerable<Table>
	{
		private List<Table> listOfTables;

		public ListOfTable()
		{
			listOfTables = new List<Table>();
		}
		public ListOfTable(List<Table> tables)
		{
			listOfTables = tables;
		}

		/// <summary>
		/// This method adds a new table to the list of tables
		/// </summary>
		/// <param name="table">Input parameter-table</param>
		public void Add(Table table)
		{
			listOfTables.Add(table);
		}

		public IEnumerator<Table> GetEnumerator()
		{
			return listOfTables.GetEnumerator();
		}

		/// <summary>
		/// This method removes a table from the list of tables
		/// </summary>
		/// <param name="table">Input parameter-table</param>
		public void Remove(Table table)
		{
			listOfTables.Remove(table);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// This method sorts the list of tables by name
		/// </summary>
		public void SortingTablesByName()
		{
			var sortedTablesByName = listOfTables.OrderBy(t => t.Name);
		}

		/// <summary>
		/// This method sorts the list of tables by price
		/// </summary>
		public void SortingByPrice()
		{
			var sortedTablesByPrice = listOfTables.OrderBy(t => t.Price);
		}
	}
}
