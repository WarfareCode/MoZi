using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using SmartAssembly.Zip;

namespace SmartAssembly.StringsEncoding
{
	// Token: 0x0200127F RID: 4735
	public sealed class Strings
	{
		// Token: 0x0600A6E0 RID: 42720 RVA: 0x004DEFCC File Offset: 0x004DD1CC
		public static string Get(int stringID)
		{
			stringID -= Strings.offset;
			if (Strings.cacheStrings)
			{
				string text = (string)Strings.hashtable[stringID];
				if (text != null)
				{
					return text;
				}
			}
			int index = stringID;
			int num = (int)Strings.bytes[index++];
			int num2;
			if ((num & 128) == 0)
			{
				num2 = num;
				if (num2 == 0)
				{
					return string.Empty;
				}
			}
			else if ((num & 64) == 0)
			{
				num2 = ((num & 63) << 8) + (int)Strings.bytes[index++];
			}
			else
			{
				num2 = ((num & 31) << 24) + ((int)Strings.bytes[index++] << 16) + ((int)Strings.bytes[index++] << 8) + (int)Strings.bytes[index++];
			}
			string result;
			try
			{
				byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(Strings.bytes, index, num2));
				string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (Strings.cacheStrings)
				{
					try
					{
						Strings.hashtable.Add(stringID, text2);
					}
					catch
					{
					}
				}
				result = text2;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x004DF0EC File Offset: 0x004DD2EC
		static Strings()
		{
			if (Strings.MustUseCache == "1")
			{
				Strings.cacheStrings = true;
				Strings.hashtable = new Hashtable();
			}
			Strings.offset = Convert.ToInt32(Strings.OffsetValue);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("{875a1a09-ea23-4568-ab19-b869ff6bf17d}"))
			{
				int num = Convert.ToInt32(manifestResourceStream.Length);
				byte[] buffer = new byte[num];
				manifestResourceStream.Read(buffer, 0, num);
				Strings.bytes = SimpleZip.Unzip(buffer);
				manifestResourceStream.Close();
			}
		}

		// Token: 0x04005653 RID: 22099
		private static readonly string MustUseCache = "1";

		// Token: 0x04005654 RID: 22100
		private static readonly string OffsetValue = "253";

		// Token: 0x04005655 RID: 22101
		private static readonly byte[] bytes = null;

		// Token: 0x04005656 RID: 22102
		private static readonly Hashtable hashtable = null;

		// Token: 0x04005657 RID: 22103
		private static readonly bool cacheStrings = false;

		// Token: 0x04005658 RID: 22104
		private static readonly int offset = 0;
	}
}
