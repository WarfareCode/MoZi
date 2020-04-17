using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Command_Core;
using ns31;

namespace ns3
{
	// Token: 0x02000BC7 RID: 3015
	public sealed class DBCryptoService
	{
		// Token: 0x06006406 RID: 25606 RVA: 0x0031611C File Offset: 0x0031431C
		public static string Decrypt(string cipherText, string sharedKey = "")
		{
			if (string.IsNullOrEmpty(cipherText))
			{
				throw new ArgumentNullException("cipherText");
			}
			if (string.IsNullOrEmpty(sharedKey) && string.IsNullOrEmpty(sharedKey))
			{
				sharedKey = DBCryptoService.DefaultSharedKey;
			}
			RijndaelManaged rijndaelManaged = null;
			string result = null;
			try
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedKey, DBCryptoService.saltBytes);
				byte[] byte_ = Convert.FromBase64String(cipherText);
				using (Stream1 stream = new Stream1(byte_))
				{
					rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
					rijndaelManaged.IV = DBCryptoService.ReadByteArray(stream);
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			finally
			{
				if (rijndaelManaged != null)
				{
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00316260 File Offset: 0x00314460
		private static byte[] ReadByteArray(Stream stream_0)
		{
			byte[] array = new byte[4];
			if (stream_0.Read(array, 0, array.Length) != array.Length)
			{
				throw new SystemException("Stream did not contain properly formatted byte array");
			}
			byte[] array2 = new byte[BitConverter.ToInt32(array, 0) - 1 + 1];
			if (stream_0.Read(array2, 0, array2.Length) != array2.Length)
			{
				throw new SystemException("Did not read byte array properly");
			}
			return array2;
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x003162C4 File Offset: 0x003144C4
		public static string Encrypt(string string_2)
		{
			string result = "";
			using (FileStream fileStream = new FileStream(string_2, FileMode.Open, FileAccess.Read))
			{
				string text = "";
				using (SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider())
				{
					text = Misc.smethod_14(sHA1CryptoServiceProvider.ComputeHash(fileStream));
				}
				result = text;
			}
			return result;
		}

		// Token: 0x0400364B RID: 13899
		private static byte[] saltBytes = Encoding.ASCII.GetBytes("o6806642kbM7c5");

		// Token: 0x0400364C RID: 13900
		private static string DefaultSharedKey = "6b887c5ac993e7ae98c4c08e19f56429fdeb440755a4701b-7e80-4e57-9b96-3e9bee544da1942448a6-3112-4975-a68c-68782c80c0af";

		// Token: 0x0400364D RID: 13901
		public static string string_1 = "EBA66B7C-B09A-4EE0E860AE-410C-410D-8E7E-0AC92423D79F8F-8CD3-4BC7C54842BD8CC4DF32-BAAC-4C5F-8120-FD02B6131532";
	}
}
