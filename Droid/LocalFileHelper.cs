using System;
using System.IO;
using dhruvWeek4.Droid;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(LocalFileHelper))]
namespace dhruvWeek4.Droid
{
	public class LocalFileHelper : ILocalFileHelper
	{
		public string GetLocalFilePath(string fileName)
		{
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string path = Path.Combine(documentsPath, fileName);
			return path;
		}
	}
}