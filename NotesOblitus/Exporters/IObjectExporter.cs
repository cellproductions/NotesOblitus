namespace NotesOblitus.Exporters
{
	interface IObjectExporter
	{
		void ExportObject(string filePath, object serializable);
	}
}
