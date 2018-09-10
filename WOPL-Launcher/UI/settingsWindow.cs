using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WOPL_Launcher.Classes;
using static GameLauncher.App.Classes.User32;

namespace WOPL_Launcher.UI {
	public partial class settingsWindow : Form {
		String UserSettings			= Environment.GetEnvironmentVariable("AppData") + "/Need for Speed World/Settings/UserSettings.xml";
		XmlDocument UserSettingsXML = new XmlDocument();

		String LauncherSettings			= Environment.GetEnvironmentVariable("AppData") + "/Need for Speed World/Settings/LauncherSettings.xml";
		XmlDocument LauncherSettingsXML = new XmlDocument();

		String currentIngameRes = String.Empty;
		Int32 currentIngameRR = 60;

		protected override void OnPaint(PaintEventArgs e) {
			Self.paintBorders(e, this);
		}

		public settingsWindow() {
			InitializeComponent();
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
		}

		private void settingsWindow_Load(object sender, EventArgs e) {
			//UserSettings.xml
			/*try {
				UserSettingsXML.Load(UserSettings);
				XmlNode screenWidthNode = UserSettingsXML.SelectSingleNode("Settings/VideoConfig/screenwidth");
				XmlNode screenHeightNode = UserSettingsXML.SelectSingleNode("Settings/VideoConfig/screenheight");
				XmlNode screenRefreshNode = UserSettingsXML.SelectSingleNode("Settings/VideoConfig/screenheight");

				currentIngameRes = screenWidthNode.InnerText + "x" + screenHeightNode.InnerText;
				currentIngameRR = Convert.ToInt32(screenRefreshNode.InnerText);
			} catch {
				File.Delete(UserSettings);
				XmlNode Setting = UserSettingsXML.AppendChild(UserSettingsXML.CreateElement("Settings"));
				XmlNode PersistentValue = Setting.AppendChild(UserSettingsXML.CreateElement("PersistentValue"));
				XmlNode Chat = PersistentValue.AppendChild(UserSettingsXML.CreateElement("Chat"));
				XmlNode UI = Setting.AppendChild(UserSettingsXML.CreateElement("UI"));
				Chat.InnerXml = "<DefaultChatGroup Type=\"string\">PL</DefaultChatGroup>";
				UI.InnerXml = "<Language Type=\"string\">PL</Language>";
				DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(UserSettings));
			}

			//Rozdzielczosc gry
			List<Object> ListaRozdzielczosci = new List<Object>();
			DEVMODE vDevMode = new DEVMODE();
			string aspect = String.Empty;
			int oldw = 0;
			int oldh = 0;
			int i = 0;
			while (EnumDisplaySettings(null, i, ref vDevMode)) {
				if (vDevMode.dmPelsWidth != oldw || vDevMode.dmPelsHeight != oldh) {
					ListaRozdzielczosci.Add(vDevMode.dmPelsWidth + "x" + vDevMode.dmPelsHeight);
					oldw = vDevMode.dmPelsWidth;
					oldh = vDevMode.dmPelsHeight;
				}

				i++;
			}

			if (!ListaRozdzielczosci.Contains(currentIngameRes)) {
				ListaRozdzielczosci.Add(currentIngameRes);
			}

			RozdzielczoscGry.DataSource = ListaRozdzielczosci;

			//Odswiezanie ekranu
			*/

			//Czcionki
			RozdzielczoscGryLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);
			JezykGryLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9f * Self.DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);

		}
	}
}
