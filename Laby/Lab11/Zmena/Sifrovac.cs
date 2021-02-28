using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zmena
{
	class Sifrovac
	{
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
		
		public static void EncryptFile(string input,string output, string password)
		{
            byte[] Salt = new byte[8];
			rngCsp.GetNonZeroBytes(Salt);

			var keyGen = new Rfc2898DeriveBytes(password, Salt);
			var cipher = new AesCryptoServiceProvider();

			cipher.Key = keyGen.GetBytes(cipher.KeySize/8);
			cipher.GenerateIV();
			var iv = cipher.IV;

			byte[] vstup = File.ReadAllBytes(input);
			byte[] sifrovano;
			using (var encryptor = cipher.CreateEncryptor())
			{
				using (var ms = new MemoryStream())
				{
					using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
					{
						cs.Write(vstup, 0, vstup.Length);
						cs.FlushFinalBlock();
						sifrovano = ms.ToArray();
					}
				}
			}
			var vystup = File.Create(output);
			vystup.Write(Salt,0,Salt.Length);
			vystup.Write(iv,0,iv.Length);
			vystup.Write(sifrovano,0,sifrovano.Length);
			vystup.Close();
		}

		public static void DecryptFile(string input, string output, string password)
		{
            byte[] Salt = new byte[8];
			var vstup = File.OpenRead(input);
            vstup.Read(Salt, 0, Salt.Length);

			var keyGen = new Rfc2898DeriveBytes(password, Salt);
			var cipher = new AesCryptoServiceProvider();

			cipher.Key = keyGen.GetBytes(cipher.KeySize / 8);

			
			byte[] iv = new byte[cipher.BlockSize / 8];
			vstup.Read(iv, 0, iv.Length);
			cipher.IV = iv;

			using (FileStream fsOut = new FileStream(output, FileMode.Create))
			{
				using (ICryptoTransform decryptor = cipher.CreateDecryptor())
				{
					using (CryptoStream cs = new CryptoStream(vstup, decryptor, CryptoStreamMode.Read))
					{
						int data;
						while ((data = cs.ReadByte()) != -1)
						{
							fsOut.WriteByte((byte)data);
						}
					}
				}
			}
			vstup.Close();

		}

	}
}
