using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WOPL_Launcher.UI;

namespace WOPL_Launcher.Classes {
	class Self {
		public static float DPIDefaultScale = 96f;
		public static String discordrpccode = "487687113983262721";

		public static void KillProcess(int processId = 2137) {
			if(processId == 2137) processId = Process.GetCurrentProcess().Id;
			Process.GetProcessById(processId).Kill();
		}

		public static void paintBorders(PaintEventArgs e, Form formname) {
			Pen p = new Pen(Color.FromArgb(4, 9, 16));
			e.Graphics.DrawRectangle(p, new Rectangle(new Point(0, 0), new Size(formname.Size.Width - 1, formname.Size.Height - 1)));
			e.Graphics.DrawRectangle(p, new Rectangle(new Point(2, 2), new Size(formname.Size.Width - 5, formname.Size.Height - 5)));
		}

		public static void MBError(String text) {
			MessageBox.Show(null, text, "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void MBWarning(String text) {
			MessageBox.Show(null, text, "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public static void MBInfo(String text) {
			MessageBox.Show(null, text, "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void MBSuccess(String text) {
			MessageBox.Show(null, text, "WorldOnlinePL", MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		public static void HideWebBrowser(Form form) {
			form.Width = 300;

			Control webBrowser1					= form.Controls.Find("webBrowser1", true).Last();
			Control logo						= form.Controls.Find("logo", true).Last();
			Control LoginBoxBorder				= form.Controls.Find("LoginBoxBorder", true).Last();
			Control PasswordBoxBorder			= form.Controls.Find("PasswordBoxBorder", true).Last();
			Control RememberMeLabel				= form.Controls.Find("RememberMeLabel", true).Last();
			Control LoginButtonBorder			= form.Controls.Find("LoginButtonBorder", true).Last();
			Control RegisterButtonBorder		= form.Controls.Find("RegisterButtonBorder", true).Last();
			Control serverStatusImage			= form.Controls.Find("serverStatusImage", true).Last();
			Control serverStatusText			= form.Controls.Find("serverStatusText", true).Last();
			Control serverStatusDescription		= form.Controls.Find("serverStatusDescription", true).Last();
			Control InfoBox						= form.Controls.Find("InfoBox", true).Last();
			Control DownloaderProgressBar		= form.Controls.Find("DownloaderProgressBar", true).Last();
			Control settingsButton				= form.Controls.Find("settingsButton", true).Last();
			Control closeButton					= form.Controls.Find("closeButton", true).Last();
			Control panelButton					= form.Controls.Find("panelButton", true).Last();

			webBrowser1.Hide();
			logo.Left = 23;
			LoginBoxBorder.Left = 23;
			PasswordBoxBorder.Left = 23;
			RememberMeLabel.Left = 23;
			LoginButtonBorder.Left = 23;
			RegisterButtonBorder.Left = 23;
			serverStatusImage.Left = 23;
			serverStatusText.Left = 48;
			serverStatusDescription.Left = 48;
			InfoBox.Left = 23;
			DownloaderProgressBar.Left = 23;
			settingsButton.Left = 234;
			closeButton.Left = 264;
			panelButton.Left = 204;
		}

		public static string calculateAspectRatio(int width, int height) {
			double divs = Math.Round((double)width / (double)height, 2);
			string sub1 = "";
			switch (divs) {
				case 1.25:
					sub1 = "5:4";
					break;
				case 1.33:
					sub1 = "4:3";
					break;
				case 1.5:
					sub1 = "3:2";
					break;
				case 1.56:
					sub1 = "14:9";
					break;
				case 1.6:
				case 2.13:
					sub1 = "16:10";
					break;
				case 1.67:
					sub1 = "5:3";
					break;
				case 1.77:
				case 1.78:
					sub1 = "16:9";
					break;
				default:
					sub1 = "Unknown";
					break;
			}

			return "[" + sub1 + "]";
		}

		public static long getTimestamp(bool valid = false) {
			long ticks = DateTime.UtcNow.Ticks - DateTime.Parse("01/01/1970 00:00:00").Ticks;

			if (valid == true) {
				ticks /= 10000000;
			} else {
				ticks /= 10000;
			}

			return ticks;
		}
	}
}
