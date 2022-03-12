using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeconddTask;
using SeconddTask.ProductTable.Models;
using SeconddTask.ProductTable.Services;
using System.Collections.Generic;

namespace SeconddTaskTests
{
	[TestClass]
	public class ProductTableServicesTests
	{

		[TestMethod]
		public void WritingAnXMLFile_WriteToFileTableFromListTheTable_MethodCompletedWithoutExeption()
		{
			var table = new List<Table>
			{
				new KitchenTable(
					new Leg(new Chipboard(2,3,4)),
					new Worktop(new OvalShape(), new Chipboard(100,299,4)),
					new Accessories(new Metal(1,2,2),new RectangularShape()))
			};


			WriterFile writerFile = new WriterFile();
			ListOfTable listOfTable = new ListOfTable(table);
			writerFile.WriteWithXML(listOfTable);
		}


		[TestMethod]
		public void WritingJSONFile_WriteToFileTableFromListTheTable_MethodCompletedWithoutExeption()
		{
			var table = new List<Table>
			{
				new KitchenTable(
					new Leg(new Chipboard(2,3,4)),
					new Worktop(new OvalShape(),new Chipboard(100,299,4)),
					new Accessories(new Metal(1,2,2),new RoundShape()))
			};

			WriterFile writerFile = new WriterFile();
			ListOfTable listOfTable = new ListOfTable(table);
			writerFile.JsonFile(listOfTable);
		}


	}
}
