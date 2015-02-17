using System.IO;
using Newtonsoft.Json;

namespace NotesOblitus.Exporters
{
	class JsonObjectExporter : IObjectExporter
	{
		public void ExportObject(string filePath, object serializable)
		{
			File.WriteAllText(filePath, JsonConvert.SerializeObject(serializable, Formatting.Indented));
		}
	}
}
