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
		Boolean loginEnabled = false;

		public MainWindow() {
			this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

			float DPIDefaultScale = 96f;

			InitializeComponent();

			RememberMeLabel.Font = new Font(FontManager.Instance.GetFontFamily("Akrobat-Bold.otf"), 9.5f * DPIDefaultScale / CreateGraphics().DpiX, FontStyle.Bold);
			RegisterBoxLabel.Text = RegisterBoxLabel.Text.ToUpper();
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
		}

		private void loginButton_Click(object sender, EventArgs e) {
			MessageBox.Show("OK");
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
	}
}
