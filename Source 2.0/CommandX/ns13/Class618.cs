using System;

namespace ns13
{
	// Token: 0x020003CE RID: 974
	public sealed class Class618 : IComparable
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x0001010E File Offset: 0x0000E30E
		public Class618(object object_2, double double_1, Class618 class618_1, object object_3)
		{
			this.object_0 = object_2;
			this.double_0 = double_1;
			this.class618_0 = class618_1;
			this.int_0 = 1;
			if (class618_1 != null)
			{
				this.int_0 = 2;
			}
			this.object_1 = object_3;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0009660C File Offset: 0x0009480C
		public object method_0()
		{
			return this.object_0;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00010147 File Offset: 0x0000E347
		public bool method_1()
		{
			return this.class618_0 == null;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00010152 File Offset: 0x0000E352
		public bool method_2()
		{
			return this.class618_0 != null;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00096624 File Offset: 0x00094824
		public Class618 method_3()
		{
			return this.class618_0;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0009663C File Offset: 0x0009483C
		public int method_4()
		{
			return this.int_1;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00010160 File Offset: 0x0000E360
		public void method_5(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00096654 File Offset: 0x00094854
		public object method_6()
		{
			return this.object_1;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0009666C File Offset: 0x0009486C
		public int CompareTo(object target)
		{
			Class618 @class = (Class618)target;
			int result;
			if (this.double_0 < @class.double_0)
			{
				result = -1;
			}
			else if (this.double_0 > @class.double_0)
			{
				result = 1;
			}
			else if (this.int_0 < @class.int_0)
			{
				result = -1;
			}
			else if (this.int_0 > @class.int_0)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x040009ED RID: 2541
		private object object_0;

		// Token: 0x040009EE RID: 2542
		private double double_0;

		// Token: 0x040009EF RID: 2543
		private int int_0;

		// Token: 0x040009F0 RID: 2544
		private Class618 class618_0;

		// Token: 0x040009F1 RID: 2545
		private int int_1;

		// Token: 0x040009F2 RID: 2546
		private object object_1;
	}
}
