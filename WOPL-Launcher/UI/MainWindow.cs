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
using WOPL_Launcher.FormHandler;

namespace WOPL_Launcher.UI {
	public partial class MainWindow : Form {
		protected override void OnPaint(PaintEventArgs e) {
			Self.paintBorders(e, this);
		}

		protected override CreateParams CreateParams {
			get {
				const int CS_DROPSHADOW = 0x20000;
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

		Boolean loginEnabled = false;
		DateTime DownloadStartTime;
		Downloader downloader;
		String discordrpccode = "487687113983262721";
		DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();

		String InstallationDirectory = Directory.GetCurrentDirectory() + "\\GameFiles";

		public MainWindow() {
			downloader = new Downloader(this, 3, 2, 16) {
				ProgressUpdated = new ProgressUpdated(this.OnDownloadProgress),
				DownloadFinished = new DownloadFinished(this.DownloadTracksFiles),
				DownloadFailed = new DownloadFailed(this.OnDownloadFailed),
				ShowMessage = new ShowMessage(this.OnShowMessage)
			};

			InitializeComponent();

			Font = new Font(Font.Name, 8.25f * Self.DPIDefaultScale / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

			InfoBox.Font = new Font(FontManager.Instance.GetFontFamily("Airport-Cyr.ttf"), 6.75f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Regular);
			serverStatusDescription.Font = new Font(FontManager.Instance.GetFontFamily("Airport-Cyr.ttf"), 6.75f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Regular);
			RememberMeLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);
			LoginButtonLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);
			RegisterButtonLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);
			serverStatusText.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-SemiBold.otf"), 9f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Regular);

			var pos1 = this.PointToScreen(LoginButtonLabel.Location);
			pos1 = LoginButtonBorder.PointToClient(pos1);
			LoginButtonLabel.Parent = LoginButtonBorder;
			LoginButtonLabel.Location = pos1;
			LoginButtonLabel.BackColor = Color.Transparent;

			var pos2 = this.PointToScreen(RegisterButtonLabel.Location);
			pos2 = RegisterButtonBorder.PointToClient(pos2);
			RegisterButtonLabel.Parent = RegisterButtonBorder;
			RegisterButtonLabel.Location = pos2;
			RegisterButtonLabel.BackColor = Color.Transparent;


			WindowMove wmHandler = new WindowMove(this);
			this.MouseDown += new MouseEventHandler(wmHandler.mouseDownHandler);
			this.MouseUp += new MouseEventHandler(wmHandler.mouseUpHandler);
			this.MouseMove += new MouseEventHandler(wmHandler.mouseMoveHandler);
			logo.MouseDown += new MouseEventHandler(wmHandler.mouseDownHandler);
			logo.MouseUp += new MouseEventHandler(wmHandler.mouseUpHandler);
			logo.MouseMove += new MouseEventHandler(wmHandler.mouseMoveHandler);
			closeButton.Click += new EventHandler(wmHandler.Close);

			LoginButtonLabel.Click += new EventHandler(loginButton_Click);
			LoginBoxTextBox.KeyDown += new KeyEventHandler(checkLoginEnter);
			PasswordBoxTextBox.KeyDown += new KeyEventHandler(checkLoginEnter);
			LoginBoxTextBox.KeyUp += new KeyEventHandler(enableLogin);
			PasswordBoxTextBox.KeyUp += new KeyEventHandler(enableLogin);

			RegisterButtonLabel.Click += new EventHandler((x, y) => { MessageBox.Show("Not implemented."); });

			OpenWindow open = new OpenWindow(this, new settingsWindow(), null);
			settingsButton.Click += new EventHandler(open.SettingsWindow);

			DiscordRpc.EventHandlers handlers = new DiscordRpc.EventHandlers();
			DiscordRpc.Initialize(discordrpccode, ref handlers, true, "");
			presence.state = "W Launcherze: " + Application.ProductVersion;
			presence.largeImageText = "WorldOnlinePL";
			presence.largeImageKey = "worldonline";
			presence.instance = true;
			DiscordRpc.UpdatePresence(presence);

			this.BeginInvoke((MethodInvoker)delegate {
				Server.GetStats(serverStatusImage, serverStatusText, serverStatusDescription);
				launchNFSW();
			});
		}

		private void loginButton_Click(object sender, EventArgs e) {
			InfoBox.Text = "Logowanie, prosze czekac";
			Server.Login(LoginBoxTextBox.Text, SHA1_Hash.GenerateFromString(PasswordBoxTextBox.Text));

			if(String.IsNullOrEmpty(Server.UserId)) {
				MessageBox.Show(Server.Description);
				InfoBox.Text = "Gra jest gotowa do uruchomienia.";
			} else {
				if(!File.Exists(InstallationDirectory + "\\nfsw.exe")) {
					MessageBox.Show("Zostałeś zalogowany, lecz pliki gry nie zostały jeszcze pobrane. Spróbuj ponownie po pobraniu plików");
				} else {
					InfoBox.Text = "Uruchamianie gry";
					WOPL_Launcher.Classes.GameLauncher.LaunchGameLegacy(Server.UserId, Server.LoginToken, Server.serverIP);

					DiscordRpc.EventHandlers handlers = new DiscordRpc.EventHandlers();
					DiscordRpc.Initialize(discordrpccode, ref handlers, true, "");
					presence.state = "W Grze: [[EVENT_UNKNOWN]]";
					presence.largeImageText = "WorldOnlinePL";
					presence.largeImageKey = "worldonline";
					presence.startTimestamp = Self.getTimestamp(true);
					presence.instance = true;
					DiscordRpc.UpdatePresence(presence);
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

		private void launchNFSW() {
			InfoBox.Text = "Pobieranie plikow gry";

			if (!File.Exists(InstallationDirectory + "/Sound/Speech/copspeechhdr_en.big")) {
				InfoBox.Text = "Sprawdzam liste plikow do pobrania";

				Kernel32.GetDiskFreeSpaceEx(InstallationDirectory, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
				if (lpFreeBytesAvailable <= 4000000000) {
					DownloaderProgressBar.Value = 100;
					DownloaderProgressBar.ProgressColor = Color.Orange;
					DownloaderProgressBar.BorderColor = Color.Orange;

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
				InfoBox.Text = string.Format("Pobieranie: {2} ({0}/{1})", this.FormatFileSize(downloadCurrent), this.FormatFileSize(compressedLength), file);
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
			InfoBox.Text = "Gra jest gotowa do uruchomienia.";
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
			DownloaderProgressBar.BorderColor = Color.Red;
		}

		private void OnShowMessage(string message, string header) {
			MessageBox.Show(message, header);
		}

		private void button1_Click(object sender, EventArgs e) {
			Self.HideWebBrowser(this);
		}
	}
}
