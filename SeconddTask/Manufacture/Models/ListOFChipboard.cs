using System;
using System.Collections;
using System.Collections.Generic;

namespace SeconddTask
{
	public class ListOFChipboard : IEnumerable<Chipboard>
	{
		private List<Chipboard> chipboards;

		public ListOFChipboard()
		{
			chipboards = new List<Chipboard>();

		}

		public List<Chipboard> Chipboards => chipboards;

		/// <summary>
		///This method adds a new sheet to the list of chipboard sheets
		/// </summary>
		/// <param name="chipboard">Input parameter-chipboard sheet</param>
		public void Add(Chipboard chipboard)
		{
			chipboards.Add(chipboard);
		}

		public IEnumerator<Chipboard> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// This method removes a chipboard sheet from the list
		/// </summary>
		/// <param name="chipboard">Input parameter-chipboard sheet</param>
		public void Remove(Chipboard chipboard)
		{
			chipboards.Remove(chipboard);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}


	}
}
