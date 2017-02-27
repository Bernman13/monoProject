using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
namespace show1
{
	public class BasicFileFunctions
	{
		private StreamReader file;
		private string line;
		private Dictionary<int,string> liste=new Dictionary<int, string>();
		private Int32 zeile=0;

		public void ReadListing ()
		{
			Console.WriteLine("\nReading hello.cs");
			string path = Directory.GetCurrentDirectory();
			Console.WriteLine("The current directory is {0}", path);
			string dir = "/home/pi/progs/hello.cs";
			file=new System.IO.StreamReader(dir);
			while((line=file.ReadLine())!=null){
				System.Console.WriteLine(line);
				liste.Add (zeile, line);
				zeile++;
			}
			Console.WriteLine("\nZeilen:{0}",zeile.ToString());
			file.Close();
		}

		public void ReadWebsite(string url){
			WebClient client = new WebClient ();
			string ganzeSeite = client.DownloadString (url);
			Console.WriteLine (ganzeSeite);
		}
	}
}

