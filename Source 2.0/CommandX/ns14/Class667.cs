using System;
using System.Globalization;

namespace ns14
{
	// Token: 0x02000482 RID: 1154
	public sealed class Class667 : IEquatable<Class667>
	{
		// Token: 0x06001DE5 RID: 7653 RVA: 0x000C0858 File Offset: 0x000BEA58
		public Class667() : this(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, string.Empty)
		{
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000C08B0 File Offset: 0x000BEAB0
		public Class667(double double_7, double double_8, double double_9, double double_10, double double_11, double double_12, double double_13, string string_1)
		{
			this.double_0 = double_7;
			this.double_1 = double_8;
			this.double_2 = double_9;
			this.double_3 = double_10;
			this.double_4 = double_11;
			this.double_5 = double_12;
			this.double_6 = double_13;
			this.string_0 = string_1;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000C094C File Offset: 0x000BEB4C
		public string method_0()
		{
			return string.Format(CultureInfo.InvariantCulture.NumberFormat, "TOWGS84[{0}, {1}, {2}, {3}, {4}, {5}, {6}]", new object[]
			{
				this.double_0,
				this.double_1,
				this.double_2,
				this.double_3,
				this.double_4,
				this.double_5,
				this.double_6
			});
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000C09DC File Offset: 0x000BEBDC
		public override string ToString()
		{
			return this.method_0();
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000124B0 File Offset: 0x000106B0
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class667);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000C09F4 File Offset: 0x000BEBF4
		public override int GetHashCode()
		{
			return this.double_0.GetHashCode() ^ this.double_1.GetHashCode() ^ this.double_2.GetHashCode() ^ this.double_3.GetHashCode() ^ this.double_4.GetHashCode() ^ this.double_5.GetHashCode() ^ this.double_6.GetHashCode();
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000C0A58 File Offset: 0x000BEC58
		public bool Equals(Class667 other)
		{
			return other != null && other.double_0 == this.double_0 && other.double_1 == this.double_1 && other.double_2 == this.double_2 && other.double_3 == this.double_3 && other.double_4 == this.double_4 && other.double_5 == this.double_5 && other.double_6 == this.double_6;
		}

		// Token: 0x04000D58 RID: 3416
		public double double_0;

		// Token: 0x04000D59 RID: 3417
		public double double_1;

		// Token: 0x04000D5A RID: 3418
		public double double_2 = 0.0;

		// Token: 0x04000D5B RID: 3419
		public double double_3 = 0.0;

		// Token: 0x04000D5C RID: 3420
		public double double_4 = 0.0;

		// Token: 0x04000D5D RID: 3421
		public double double_5 = 0.0;

		// Token: 0x04000D5E RID: 3422
		public double double_6 = 0.0;

		// Token: 0x04000D5F RID: 3423
		public string string_0;
	}
}
