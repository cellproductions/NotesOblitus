using System.IO;
using System.Xml.Serialization;

namespace NotesOblitus.Exporters
{
	class XmlObjectExporter : IObjectExporter
	{
		public void ExportObject(string filePath, object serializable)
		{
			var serialiser = new XmlSerializer(serializable.GetType());
			using (var stream = new FileStream(filePath, FileMode.Create))
			{
				serialiser.Serialize(stream, serializable);
			}
		}
	}
}
