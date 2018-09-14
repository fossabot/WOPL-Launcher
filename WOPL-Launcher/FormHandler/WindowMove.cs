using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WOPL_Launcher.Classes;

namespace WOPL_Launcher.FormHandler {
	class WindowMove {
		Form mainForm;
		Point mouseDownPoint = Point.Empty;

		public WindowMove(Form form) {
			mainForm = form;
		}

		public void mouseDownHandler(object sender, MouseEventArgs e) {
			if (e.Y <= 200) {
				mouseDownPoint = new Point(e.X, e.Y);
			}
		}

		public void mouseUpHandler(object sender, MouseEventArgs e) {
			mouseDownPoint = Point.Empty;
			mainForm.Opacity = 1;
		}

		public void mouseMoveHandler(object sender, MouseEventArgs e) {
			if (mouseDownPoint.IsEmpty) {
				return;
			}

			Form thisForm = mainForm as Form;
			thisForm.Location = new Point(thisForm.Location.X + (e.X - mouseDownPoint.X), thisForm.Location.Y + (e.Y - mouseDownPoint.Y)); //hard math, wow
			mainForm.Opacity = 0.9;
		}

		public void Close(object sender, EventArgs e) {
			Self.KillProcess();
		}

		public void Panel(object sender, EventArgs e) {
			if(Server.LoginToken == String.Empty) {
				Process.Start(@"http://panel.nfswonline.pl/login.php");
			} else {
				Process.Start(@"http://panel.nfswonline.pl/login.php?token=" + Server.LoginToken);
			}
		}

		public void ResetPassword(object sender, EventArgs e) {
			Process.Start(@"https://panel.nfswonline.pl/zapomnialem_hasla.php");
		}
	}
}
