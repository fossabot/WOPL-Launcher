using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace WOPL_Launcher.Classes {
	class GameLauncher {
		public static Int32 NFSW_PID;

		public static void LaunchGameLegacy(string UserId, string LoginToken, string ServerIP) {
			string filename = Directory.GetCurrentDirectory() + "\\GameFiles\\nfsw.exe"; //temporarely hardcoded

			String cParams = "WOPL " + ServerIP + " " + LoginToken + " " + UserId + " -legacyLaunch";
			var proc = Process.Start(filename, cParams);
			proc.EnableRaisingEvents = true;

			NFSW_PID = proc.Id;

			proc.Exited += (sender2, e2) => {
				NFSW_PID = 0;
				Self.KillProcess();
			};
		}

		public static void Play() {
			LaunchGameLegacy(Server.UserId, Server.LoginToken, Server.serverIP);

			DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();

			DiscordRpc.EventHandlers handlers = new DiscordRpc.EventHandlers();
			DiscordRpc.Initialize(Self.discordrpccode, ref handlers, true, "");
			presence.state = "W Grze";
			presence.largeImageText = "WorldOnlinePL";
			presence.largeImageKey = "worldonline";
			presence.startTimestamp = Self.getTimestamp(true);
			presence.instance = true;
			DiscordRpc.UpdatePresence(presence);
		}
	}
}
