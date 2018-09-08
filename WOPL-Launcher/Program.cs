using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WOPL_Launcher.UI;

namespace WOPL_Launcher {
	static class Program {
		[STAThread]
		static void Main() {

			if(!Directory.Exists("GameFiles")) {
				Directory.CreateDirectory("GameFiles");
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new MainWindow());
		}
	}
}
