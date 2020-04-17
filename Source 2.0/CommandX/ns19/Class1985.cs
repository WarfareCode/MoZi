using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace ns19
{
	// Token: 0x0200044B RID: 1099
	public sealed class Class1985 : ListViewItem
	{
		// Token: 0x06001C28 RID: 7208 RVA: 0x000B4740 File Offset: 0x000B2940
		public DateTime method_0()
		{
			return this.dateTime_0;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000B4758 File Offset: 0x000B2958
		public long method_1()
		{
			return this.long_0;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000B4770 File Offset: 0x000B2970
		public long method_2()
		{
			return this.long_1;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000B4788 File Offset: 0x000B2988
		public string method_3()
		{
			return this.string_0;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000B47A0 File Offset: 0x000B29A0
		public string method_4()
		{
			return this.string_1;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000B47B8 File Offset: 0x000B29B8
		public string method_5()
		{
			return this.string_2;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000B47D0 File Offset: 0x000B29D0
		public string method_6()
		{
			return this.string_3;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000B47E8 File Offset: 0x000B29E8
		public override string ToString()
		{
			string text = WebRequest.DefaultWebProxy.GetProxy(new Uri(this.method_4())).ToString();
			return string.Format(CultureInfo.CurrentCulture, "Start time: {7}{0}Total download time: {10}{0}Average transfer rate: {11:f1} kbit/s{0}Url: {1}{0}Target file: {2}{0}Progress: {3}/{4} bytes{0}Status: {5}{0}Proxy: {8}{0}{0}Response headers:{0}{9}{0}{6}{0}", new object[]
			{
				Environment.NewLine,
				this.string_1,
				this.string_2,
				this.long_0,
				this.method_2(),
				this.string_0,
				this.method_6(),
				this.dateTime_0,
				text,
				"".PadRight(40, '='),
				this.timeSpan_0,
				(this.long_1 > 0L) ? ((double)(this.long_1 * 8L) / this.timeSpan_0.TotalSeconds / 1000.0) : 0.0
			});
		}

		// Token: 0x04000C50 RID: 3152
		private DateTime dateTime_0;

		// Token: 0x04000C51 RID: 3153
		private TimeSpan timeSpan_0;

		// Token: 0x04000C52 RID: 3154
		private long long_0;

		// Token: 0x04000C53 RID: 3155
		private long long_1;

		// Token: 0x04000C54 RID: 3156
		private string string_0;

		// Token: 0x04000C55 RID: 3157
		private string string_1;

		// Token: 0x04000C56 RID: 3158
		private string string_2 = "";

		// Token: 0x04000C57 RID: 3159
		private string string_3 = "";

		// Token: 0x04000C58 RID: 3160
		private static Color color_0 = Color.Blue;

		// Token: 0x04000C59 RID: 3161
		private static Color color_1 = Color.Red;

		// Token: 0x04000C5A RID: 3162
		private static Color color_2 = Color.Black;
	}
}
