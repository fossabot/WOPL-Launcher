using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WOPL_Launcher.UI;

namespace WOPL_Launcher {
	static class Program {
		[STAThread]
		static void Main() {

			if(!Directory.Exists("GameFiles")) {
				Directory.CreateDirectory("GameFiles");
			}

			Mutex mutex = new Mutex(false, "WOPL_Launcher");

			try {
				if(mutex.WaitOne(0, false)) {
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(true);
					Application.Run(new MainWindow());
				} else {
					MessageBox.Show(null, "Launcher został już uruchomiony.", "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} finally {
				if(mutex != null) {
					mutex.Close();
					mutex = null;
				}
			}
		}
	}
}
