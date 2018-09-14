using System;
using System.Windows.Forms;

namespace WOPL_Launcher.Classes {
	class Delay {
		public static void WaitSeconds(int sec) {
			if (sec < 1)
				return;
			DateTime _desired = DateTime.Now.AddSeconds(sec);
			while (DateTime.Now < _desired) {
				Application.DoEvents();
			}
		}
	}
}
