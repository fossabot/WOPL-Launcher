using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace WOPL_Launcher.Classes.Cryptography {
	class SHA1_Hash {
		public static string GenerateFromString(string input) {
			HashAlgorithm algorithm = SHA1.Create();
			StringBuilder sb = new StringBuilder();
			foreach (byte b in algorithm.ComputeHash(Encoding.UTF8.GetBytes(input))) {
				sb.Append(b.ToString("X2"));
			}

			return sb.ToString();
		}

		public static string GenerateFromFile(Stream stream) {
			SHA1 sha1 = new SHA1CryptoServiceProvider();
			byte[] retVal = sha1.ComputeHash(stream);

			StringBuilder sb = new StringBuilder();
			for (int i = 0;i < retVal.Length;i++) {
				sb.Append(retVal[i].ToString("x2"));
			}

			return sb.ToString().ToUpper();
		}
	}
}
