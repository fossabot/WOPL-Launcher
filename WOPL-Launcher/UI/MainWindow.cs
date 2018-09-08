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

namespace WOPL_Launcher.UI {
	public partial class MainWindow : Form {
		Point mouseDownPoint = Point.Empty;

		public MainWindow() {
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			float DPIDefaultScale = 96f;

			//foreach (string res in System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames()) {
			//	Console.WriteLine(res);
			//}

			InitializeComponent();

			RememberMeLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9.5f * DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);

			this.MouseDown += new MouseEventHandler(mouseDownHandler);
			this.MouseUp += new MouseEventHandler(mouseUpHandler);
			this.MouseMove += new MouseEventHandler(mouseMoveHandler);
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
	}
}
