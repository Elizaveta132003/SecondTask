using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeconddTask;
using SeconddTask.Company.Models;

namespace SeconddTaskTests
{
	[TestClass]
	public class ClientTests
	{
		[TestMethod]
		public void CreatingTable_CreateNecessaryTable_MethodCompletedWithoutExeption()
		{
			Client client = new Client(CreateListOfChiboard());
			client.ClientCode(new Facade(new KitchenTableSubsystem()));
		}

		private ListOFChipboard CreateListOfChiboard()
		{
			var chipboard = new ListOFChipboard();
			chipboard.Add(new Chipboard(12, 45, 78));
			chipboard.Add(new Chipboard(200, 200, 200));
			chipboard.Add(new Chipboard(200, 150, 120));

			return chipboard;
		}
	}
}

