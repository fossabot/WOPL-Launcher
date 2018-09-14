using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Security.AccessControl;
using WOPL_Launcher.UI;
using GameLauncherReborn;
using WOPL_Launcher.Classes;

namespace WOPL_Launcher {
	static class Program {
		[STAThread]
		static void Main() {
			Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));

			try {
				var client = new MyWebRequest();
				client.OpenRead("http://clients1.google.com/generate_204");
			} catch {
				MessageBox.Show(null, "Najprawdopodobniej launcher jest blokowany przez systemy firewall, lub nie masz dostepu do internetu.", "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try {
				DirectorySecurity ds = Directory.GetAccessControl(Directory.GetCurrentDirectory());
			} catch (UnauthorizedAccessException) {
				Self.MBError("Launcher nie posiada uprawnien do zapisywania plikow w danym katalogu.\nSprobuj uruchomic launcher jako administrator lub zainstalować go w innym katalogu");
				Self.KillProcess();
			}

			if (!Directory.Exists("GameFiles")) {
				Directory.CreateDirectory("GameFiles");
				Self.MBInfo("Hey! Przed kliknieciem 'OK' przeczytaj tą informacje. Utworzyliśmy nowy katalog 'GameFiles', gdzie bedą przechowywane pliki gry. Jeżeli posiadasz pobrane pliki do NFSW, przenieś je do tego katalogu.");
			}

			Mutex mutex = new Mutex(false, "WOPL_Launcher");

			try {
				if (mutex.WaitOne(0, false)) {
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(true);
					Application.Run(new MainWindow());
				} else {
					Self.MBError("Launcher został już uruchomiony");
				}
			} finally {
				if (mutex != null) {
					mutex.Close();
					mutex = null;
				}
			}
		}
	}
}
