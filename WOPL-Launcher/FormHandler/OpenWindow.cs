using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WOPL_Launcher.UI;

namespace WOPL_Launcher.FormHandler {
	class OpenWindow {
		Form Form1; Form Form2; Form Form3;

		public OpenWindow(Form x, Form y, Form z) {
			Form1 = x;
			Form2 = y;
			Form3 = z;
		}

		public void RegistrationWindow(object sender, EventArgs e) {
			if (Form3.Visible == false) {
				Form f = Form1 as Form;
				Form3.Show(f);
				Form3.Left = f.Left + (f.Size.Width / 2 - Form3.Size.Width / 2);
				Form3.Top = f.Top + (f.Size.Height / 2 - Form3.Size.Height / 2);
			}
		}

		public void SettingsWindow(object sender, EventArgs e) {
			if (Form2.Visible == false) {
				Form f = Form1 as Form;
				Form2.Show(f);
				Form2.Left = f.Left + (f.Size.Width / 2 - Form2.Size.Width / 2);
				Form2.Top = f.Top + (f.Size.Height / 2 - Form2.Size.Height / 2);
			}
		}
	}
}
