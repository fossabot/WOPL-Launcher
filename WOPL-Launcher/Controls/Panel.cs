using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WOPL_Launcher.Controls {
	public class MyPanel : Panel {
		public MyPanel() {
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
		}

		protected override void OnPaint(PaintEventArgs e) {
			using (SolidBrush brush = new SolidBrush(BackColor))
				e.Graphics.FillRectangle(brush, ClientRectangle);

			e.Graphics.DrawRectangle(new Pen(Color.FromArgb(66, 179, 189)), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
		}

	}
}
