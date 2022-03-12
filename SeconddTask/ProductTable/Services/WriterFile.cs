using SeconddTask.ProductTable.Models;
using System.IO;
using System.Text.Json;
using System.Xml;

namespace SeconddTask.ProductTable.Services
{
	public class WriterFile
	{
		public string _filaname { get; set; }

		public WriterFile()
		{
			_filaname = "test.xml";
		}

		/// <summary>
		/// This method writes data to an Xml file using XmlWriter
		/// </summary>
		/// <param name="tables">The input parameter is a list of tables</param>
		public void WriteWithXML(ListOfTable tables)
		{

			var xmlWriter = XmlWriter.Create(_filaname);
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("tables");

			foreach (var table in tables)
			{
				xmlWriter.WriteStartElement("table");
				xmlWriter.WriteAttributeString("name", table.Name);

				xmlWriter.WriteStartElement("worktop");
				XmlWriteParametersOfProduct(table.Worktop, xmlWriter);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteStartElement("leg");
				XmlWriteParametersOfProduct(table.Leg, xmlWriter);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteStartElement("Accessories");
				XmlWriteParametersOfProduct(table.Accessories, xmlWriter);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteStartElement("Price");
				xmlWriter.WriteString(XmlConvert.ToString(table.Price));
				xmlWriter.WriteEndElement();

			}

		}

		/// <summary>
		/// This method writes data about a part of the table to an xml file
		/// </summary>
		/// <param name="partOfTable">The first input parameter is a part of the table</param>
		/// <param name="xmlWriter">The second input parameter is the XmlWriter object</param>
		public void XmlWriteParametersOfProduct(PartOfTable partOfTable, XmlWriter xmlWriter)
		{
			xmlWriter.WriteStartElement("Share");
			xmlWriter.WriteString(partOfTable.Share.Name);
			xmlWriter.WriteEndElement();

			xmlWriter.WriteStartElement("Material");


			xmlWriter.WriteStartElement("Thickness");
			xmlWriter.WriteString(XmlConvert.ToString(partOfTable.Material.Thickness));
			xmlWriter.WriteEndElement();

			xmlWriter.WriteStartElement("Width");
			xmlWriter.WriteString(XmlConvert.ToString(partOfTable.Material.Width));
			xmlWriter.WriteEndElement();

			xmlWriter.WriteStartElement("Lenght");
			xmlWriter.WriteString(XmlConvert.ToString(partOfTable.Material.Lenght));
			xmlWriter.WriteEndElement();
		}

		/// <summary>
		/// This method writes data to an Xml file using StreamWriter
		/// </summary>
		/// <param name="tables">The input parameter is a list of tables</param>
		public void XmlWriteWithStreamWriter(ListOfTable tables)
		{
			System.Xml.Serialization.XmlSerializer writer =
					new System.Xml.Serialization.XmlSerializer(typeof(Table));
			var file = new StreamWriter(_filaname);

			foreach (Table table in tables)
			{
				writer.Serialize(file, table);
			}
			file.Close();
		}

		/// <summary>
		/// This method writes this to a JSON file
		/// </summary>
		/// <param name="tables">The input parameter is a list of tables</param>
		public async void JsonFile(ListOfTable tables)
		{
			using (FileStream fs = new FileStream(_filaname, FileMode.OpenOrCreate))
			{
				foreach (Table table in tables)
				{
					await JsonSerializer.SerializeAsync<Table>(fs, table);
				}

			}
		}
	}
}
