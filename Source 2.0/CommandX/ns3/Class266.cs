using System;
using System.Text.RegularExpressions;

namespace ns3
{
	// Token: 0x02000C06 RID: 3078
	public sealed class Class266
	{
		// Token: 0x06006673 RID: 26227 RVA: 0x00353A40 File Offset: 0x00351C40
		public static string smethod_0(string string_0)
		{
			return Class266.regex_0.Replace(string_0, string.Empty).Replace("&nbsp;", " ");
		}

		// Token: 0x0400384C RID: 14412
		private static Regex regex_0 = new Regex("<.*?>", RegexOptions.Compiled);
	}
}
