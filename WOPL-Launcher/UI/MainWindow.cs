using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WOPL_Launcher.Classes;
using System.Reflection;
using WOPL_Launcher.Classes.Cryptography;
using GameLauncher;
using System.IO;
using GameLauncher.App.Classes;

namespace WOPL_Launcher.UI {
	public partial class MainWindow : Form {
		Point mouseDownPoint = Point.Empty;
		Boolean loginEnabled = false;
		DateTime DownloadStartTime;
		Downloader downloader;

		String InstallationDirectory = Directory.GetCurrentDirectory() + "\\GameFiles";

		public MainWindow() {
			float DPIDefaultScale = 96f;

			downloader = new Downloader(this, 3, 2, 16) {
				ProgressUpdated = new ProgressUpdated(this.OnDownloadProgress),
				DownloadFinished = new DownloadFinished(this.DownloadTracksFiles),
				DownloadFailed = new DownloadFailed(this.OnDownloadFailed),
				ShowMessage = new ShowMessage(this.OnShowMessage)
			};

			InitializeComponent();

			Font = new Font(Font.Name, 8.25f * DPIDefaultScale / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

			InfoBox.Font = new Font(FontManager.Instance.GetFontFamily("Airport-Cyr.ttf"), 7f * DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Regular);
			RememberMeLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9.5f * DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);
			RegisterBoxLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9f * DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);

			var pos2 = this.PointToScreen(RegisterBoxLabel.Location);
			pos2 = RegisterBoxBorder.PointToClient(pos2);
			RegisterBoxLabel.Parent = RegisterBoxBorder;
			RegisterBoxLabel.Location = pos2;
			RegisterBoxLabel.BackColor = Color.Transparent;

			this.MouseDown += new MouseEventHandler(mouseDownHandler);
			this.MouseUp += new MouseEventHandler(mouseUpHandler);
			this.MouseMove += new MouseEventHandler(mouseMoveHandler);

			LoginBoxTextBox.KeyDown += new KeyEventHandler(checkLoginEnter);
			PasswordBoxTextBox.KeyDown += new KeyEventHandler(checkLoginEnter);
			LoginBoxTextBox.KeyUp += new KeyEventHandler(enableLogin);
			PasswordBoxTextBox.KeyUp += new KeyEventHandler(enableLogin);

			this.BeginInvoke((MethodInvoker)delegate {
				launchNFSW();
			});
		}

		private void loginButton_Click(object sender, EventArgs e) {
			Server.Login(LoginBoxTextBox.Text, SHA1_Hash.GenerateFromString(PasswordBoxTextBox.Text));

			if(String.IsNullOrEmpty(Server.UserId)) {
				MessageBox.Show(Server.Description);
			} else {
				if(!File.Exists(InstallationDirectory + "\\nfsw.exe")) {
					MessageBox.Show("Zostałeś zalogowany, lecz pliki gry nie zostały jeszcze pobrane. Spróbuj ponownie po pobraniu plików");
				} else {
					InfoBox.Text = "Uruchamianie gry";
					WOPL_Launcher.Classes.GameLauncher.LaunchGameLegacy(Server.UserId, Server.LoginToken, Server.serverIP);
				}
			}
		}

		private void checkLoginEnter(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Return && loginEnabled == true) {
				loginButton_Click(null, null);
				e.SuppressKeyPress = true;
			} else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V) {
                e.SuppressKeyPress = true;
            }
		}

		private void enableLogin(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(LoginBoxTextBox.Text) || String.IsNullOrEmpty(PasswordBoxTextBox.Text)) {
				loginEnabled = false;
			} else {
				loginEnabled = true;
			}
		}

		private void mouseDownHandler(object sender, MouseEventArgs e) {
			if(e.Y <= 100) {
				mouseDownPoint = new Point(e.X, e.Y);
			}
		}

		private void mouseUpHandler(object sender, MouseEventArgs e) {
			mouseDownPoint = Point.Empty;
			this.Opacity = 1;
		}

		private void mouseMoveHandler(object sender, MouseEventArgs e) {
			if(mouseDownPoint.IsEmpty) {
				return;
			}

			Form thisForm = this as Form;
			thisForm.Location = new Point(thisForm.Location.X + (e.X - mouseDownPoint.X), thisForm.Location.Y + (e.Y - mouseDownPoint.Y)); //hard math, wow
			this.Opacity = 0.9;
		}

		private void launchNFSW() {
			InfoBox.Text = "Pobieranie plikow gry";

			if (!File.Exists(InstallationDirectory + "/Sound/Speech/copspeechhdr_en.big")) {
				InfoBox.Text = "Sprawdzam liste plikow do pobrania";

				Kernel32.GetDiskFreeSpaceEx(InstallationDirectory, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
				if (lpFreeBytesAvailable <= 4000000000) {
					DownloaderProgressBar.Value = 100;
					DownloaderProgressBar.ProgressColor = Color.Orange;

					InfoBox.Text = "Brak miejsca na dysku, jest wymagane minimum 4GB";
				} else {
					DownloadCoreFiles();
				}
			} else {
				OnDownloadFinished();
			}
		}

		private string FormatFileSize(long byteCount) {
			double[] numArray = new double[] { 1073741824, 1048576, 1024, 0 };
			string[] strArrays = new string[] { "GB", "MB", "KB", "Bytes" };
			for (int i = 0;i < (int)numArray.Length;i++) {
				if ((double)byteCount >= numArray[i]) {
					return string.Concat(string.Format("{0:0.00}", (double)byteCount / numArray[i]), strArrays[i]);
				}
			}

			return "0 Bytes";
		}

		public void DownloadCoreFiles() {
			InfoBox.Text = "Sprawdzam glowne pliki gry";

			if (!File.Exists(InstallationDirectory + "/nfsw.exe")) {
				DownloadStartTime = DateTime.Now;
				downloader.StartDownload("http://static.cdn.ea.com/blackbox/u/f/NFSWO/1614b/client", "", InstallationDirectory, false, false, 1130632198);
			} else {
				DownloadTracksFiles();
			}
		}

		private void OnDownloadProgress(long downloadLength, long downloadCurrent, long compressedLength, string filename, int skiptime = 0) {
			if (downloadCurrent < compressedLength) {
				string file = filename.Replace(InstallationDirectory + "/", "").ToUpper();
				InfoBox.Text = string.Format("Pobieranie {2} ({0}/{1})", this.FormatFileSize(downloadCurrent), this.FormatFileSize(compressedLength), file);
			}

			try {
				DownloaderProgressBar.Value = (int)((long)100 * downloadCurrent / compressedLength);
			} catch {
				DownloaderProgressBar.Value = 0;
			}
		}

		public void DownloadTracksFiles() {
			InfoBox.Text = "Sprawdzam pliki normalnej jakosci";

			if (!File.Exists(InstallationDirectory + "/TracksHigh/STREAML5RA_98.BUN")) {
				DownloadStartTime = DateTime.Now;
				downloader.StartDownload("http://static.cdn.ea.com/blackbox/u/f/NFSWO/1614b/client", "TracksHigh", InstallationDirectory, false, false, 615494528);
			} else {
				DownloadSpeechFiles();
			}
		}

		public void DownloadSpeechFiles() {
			InfoBox.Text = "Sprawdzam pliki glosowe";

			if (!File.Exists(InstallationDirectory + "\\Sound\\Speech\\copspeechsth_en.big")) {
				downloader.StartDownload("http://static.cdn.ea.com/blackbox/u/f/NFSWO/1614b/client", "en", InstallationDirectory, false, false, 141805935);
			} else {
				DownloadTracksHighFiles();
			}
		}

		public void DownloadTracksHighFiles() {
			InfoBox.Text = "Sprawdzam pliki wysokiej jakosci.";
			if (!File.Exists(InstallationDirectory + "\\Tracks\\STREAML5RA_98.BUN")) {
				DownloadStartTime = DateTime.Now;
				downloader.StartDownload("http://static.cdn.ea.com/blackbox/u/f/NFSWO/1614b/client", "Tracks", InstallationDirectory, false, false, 278397707);
			} else {
				OnDownloadFinished();
			}
		}

		private void OnDownloadFinished() {
			InfoBox.Text = "Pobieranie ukończone.";
			DownloaderProgressBar.Value = 100;
		}

		private void OnDownloadFailed(Exception ex) {
			String failureMessage;

			try {
				failureMessage = ex.Message;
			} catch {
				failureMessage = "";
			}

			DownloaderProgressBar.Value = 100;
			InfoBox.Text = String.Format("Blad pobierania plikow. {0}", failureMessage).ToUpper();
			DownloaderProgressBar.ProgressColor = Color.Red;
		}

		private void OnShowMessage(string message, string header) {
			MessageBox.Show(message, header);
		}
	}
}
