using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO.Compression;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using GameLauncher.App.Classes;

namespace GameLauncherReborn {
	public class MyWebRequest : WebClient {
		protected override WebRequest GetWebRequest(Uri address) {
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);
			request.UserAgent = "GameLauncher (+https://github.com/SoapboxRaceWorld/GameLauncher_NFSW)";
			request.Headers["X-HWID"] = Security.FingerPrint.Value();
			request.Timeout = 3000;

			return request;
		}
	}
}