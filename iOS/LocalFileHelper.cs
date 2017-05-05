using System;
using System.IO;
using dhruvWeek4.iOS;
using Xamarin.Forms;
[assembly: Dependency(typeof(LocalFileHelper))]
namespace dhruvWeek4.iOS
{
	public class LocalFileHelper : ILocalFileHelper
	{
		public string GetLocalFilePath(string fileName)
		{

			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}
			return Path.Combine(libFolder, fileName);
		}

	}
}
