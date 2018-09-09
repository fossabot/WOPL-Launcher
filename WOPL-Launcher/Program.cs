using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Security.AccessControl;
using WOPL_Launcher.UI;
using GameLauncherReborn;

namespace WOPL_Launcher {
	static class Program {
		[STAThread]
		static void Main() {
			Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));

			try {
				using (var client = new MyWebRequest()) {
					using (client.OpenRead("http://clients1.google.com/generate_204")) {

					}
				}
			} catch {
				MessageBox.Show(null, "Najprawdopodobniej launcher jest blokowany przez systemy firewall, lub nie masz dostepu do internetu.", "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try {
				DirectorySecurity ds = Directory.GetAccessControl(Directory.GetCurrentDirectory());

				if (!Directory.Exists("GameFiles")) {
					Directory.CreateDirectory("GameFiles");
				}

				Mutex mutex = new Mutex(false, "WOPL_Launcher");

				try {
					if (mutex.WaitOne(0, false)) {
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(true);
						Application.Run(new MainWindow());
					} else {
						MessageBox.Show(null, "Launcher został już uruchomiony.", "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				} finally {
					if (mutex != null) {
						mutex.Close();
						mutex = null;
					}
				}
			} catch (UnauthorizedAccessException) {
				MessageBox.Show(null, "Launcher nie posiada uprawnien do zapisywania plikow w danym katalogu.\nSprobuj uruchomic launcher jako administrator lub zainstalować go w innym katalogu", "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
