using GameLauncherReborn;
using SimpleJSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WOPL_Launcher.Classes {
	class Server {
		public static String serverIP = "http://145.239.5.103:8680/soapbox-race-core/Engine.svc";
		public static String AuthEndpoint = serverIP + "/User/authenticateUser";
		public static String RegisterEndpoint = serverIP + "/User/createUser";
		public static String GetServerInformationEndpoint = serverIP + "/GetServerInformation";

		public static String UserId = String.Empty;
		public static String LoginToken = String.Empty;
		public static String Description = String.Empty;

		public String GetStats() {
			String data = "---";

			try {
				MyWebRequest gsi_data = new MyWebRequest();
				gsi_data.CancelAsync();
				gsi_data.DownloadStringAsync(new Uri(GetServerInformationEndpoint));
				gsi_data.DownloadStringCompleted += (sender, e) => {
					if (e.Cancelled) {
						data = "---";
					} else if (e.Error != null) {
						data = "---";
					} else {
						JSONNode GSI_Node = SimpleJSON.JSON.Parse(e.Result);

						data = GSI_Node["onlineNumber"] + "/" + GSI_Node["numberOfRegistered"];
					}
				};
			} catch {
				data = "---";
			}

			return data;
		}

		public static void Login(String email, String hashPassword) {
			Logout();

			string serverLoginResponse = "";
			int errorcode = 200;

			try {
				MyWebRequest wc = new MyWebRequest();
				string BuildURL = AuthEndpoint + "?email=" + email + "&password=" + hashPassword.ToLower();
				serverLoginResponse = wc.DownloadString(BuildURL);
			} catch (WebException ex) {
				HttpWebResponse serverReply = (HttpWebResponse)ex.Response;

				if (serverReply == null) {
					errorcode = 500;
					serverLoginResponse = "<LoginStatusVO><UserId/><LoginToken/><Description>Failed to get reply from server. Please retry.</Description></LoginStatusVO>";
				} else {
					using (StreamReader sr = new StreamReader(serverReply.GetResponseStream())) {
						errorcode = (int)serverReply.StatusCode;
						serverLoginResponse = sr.ReadToEnd();
					}
				}
			}

			if (String.IsNullOrEmpty(serverLoginResponse)) {
				Description = "Serwer jest offline. Prosimy spróbować później.";
			} else {
				try {
					XmlDocument SBRW_XML = new XmlDocument();
					SBRW_XML.LoadXml(serverLoginResponse);
					XmlNode ExtraNode;
					XmlNode LoginTokenNode;
					XmlNode UserIdNode;

					LoginTokenNode = SBRW_XML.SelectSingleNode("LoginStatusVO/LoginToken");
					UserIdNode = SBRW_XML.SelectSingleNode("LoginStatusVO/UserId");

					if (SBRW_XML.SelectSingleNode("LoginStatusVO/Ban") == null) {
						if (SBRW_XML.SelectSingleNode("LoginStatusVO/Description") == null) {
							ExtraNode = SBRW_XML.SelectSingleNode("html/body");
						} else {
							ExtraNode = SBRW_XML.SelectSingleNode("LoginStatusVO/Description");
						}
					} else {
						ExtraNode = SBRW_XML.SelectSingleNode("LoginStatusVO/Ban");
					}

					if (!String.IsNullOrEmpty(ExtraNode.InnerText)) {
						if (ExtraNode.SelectSingleNode("Reason") != null) {
							if (ExtraNode.SelectSingleNode("Expires") != null) {
								Description = "Wygląda na to, że zostałeś zbanowany na okres " + ExtraNode.SelectSingleNode("Expires").InnerText + ". Powód: " + ExtraNode.SelectSingleNode("Reason").InnerText + "\n";
							} else {
								Description = "Wygląda na to, że zostałeś permanentnie zbanowany na tym serwerze. Powód: " + ExtraNode.SelectSingleNode("Reason").InnerText + "\n";
							}
						} else {
							if (ExtraNode.InnerText == "Please use MeTonaTOR's launcher. Or, are you tampering?") {
								Description = "Błąd launchera. Wygląda na złą kompilacje. Spróbuj pobrać oryginalny launcher ze strony.";
							} else {
								if (SBRW_XML.SelectSingleNode("html/body") == null) {
									if (ExtraNode.InnerText == "LOGIN ERROR") {
										Description = "Błędne dane logowania.";
									} else {
										Description = ExtraNode.InnerText;
									}
								} else {
									Description = "ERROR " + errorcode + ": " + ExtraNode.InnerText;
								}
							}
						}
					} else {
						UserId = UserIdNode.InnerText;
						LoginToken = LoginTokenNode.InnerText;
					}
				} catch {
					Description = "Serwer jest offline. Prosimy spróbować później.";
				}
			}
		}

		public static void Register(String email, String hashPassword) {

		}

		public static void Logout() {
			UserId = String.Empty;
			LoginToken = String.Empty;
			Description = String.Empty;
		}
	}
}
