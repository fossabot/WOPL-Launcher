﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WOPL_Launcher.UI;

namespace WOPL_Launcher {
	static class Program {
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
