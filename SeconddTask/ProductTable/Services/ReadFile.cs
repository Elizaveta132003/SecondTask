namespace SeconddTask.ProductTable.Services
{
	public class ReadFile
	{
		/// <summary>
		/// This method reads from an XML file using StreamReader
		/// </summary>
		/// <param name="_filename">The input parameter is the file name</param>
		public void ReadWithStreamReader(string _filename)
		{
			System.Xml.Serialization.XmlSerializer reader =
				new System.Xml.Serialization.XmlSerializer(typeof(Table));

			System.IO.StreamReader file = new System.IO.StreamReader(_filename);

			Table table = (Table)reader.Deserialize(file);

		}

	}
}
