using System;
using System.IO;
using System.Windows.Forms;

using Mophi;
using Mophi.Xml;

namespace MathFactory
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());

			//ConfigDataBase.AddLogger(new LoggerConsole());
			ConfigDataBase.Initialize(new MathParserFactory());

			var s = Directory.GetCurrentDirectory();
			ConfigDataBase cfgDBFromXml = GenNewConfigDatabase(LocalDefines.XML_PATH, _FileFormat.Xml);
		}

		public static ConfigDataBase GenNewConfigDatabase(string basePath, int fileFormat)
		{
			var cfgSetting = GetCfgSetting(basePath, fileFormat);

			ConfigDataBase cfgDB = ConfigDataBase.DefaultCfg;

			return cfgDB;
		}

		public static ConfigSetting GetCfgSetting(string basePath, int fileFormat)
		{
			string fileExt = fileFormat == _FileFormat.ProtoBufBinary ? ".bytes" : ".xml";

			ConfigSetting cfgSetting = new ConfigSetting(fileFormat);

			return cfgSetting;
		}
	}
}
