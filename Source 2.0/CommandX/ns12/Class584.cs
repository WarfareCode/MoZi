using System;

namespace ns12
{
	// Token: 0x02000379 RID: 889
	public sealed class Class584 : IComparable<Class584>, IComparable, ICloneable
	{
		// Token: 0x06001554 RID: 5460 RVA: 0x0000EE7B File Offset: 0x0000D07B
		public Class584()
		{
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		public Class584(int int_2, double double_1) : this(0, int_2, double_1)
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0000EEAB File Offset: 0x0000D0AB
		public Class584(int int_2, int int_3, double double_1)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.double_0 = double_1;
			this.method_0();
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0008B480 File Offset: 0x00089680
		private void method_0()
		{
			if (this.double_0 < 0.0)
			{
				this.double_0 = 0.0;
			}
			if (this.double_0 > 1.0)
			{
				this.double_0 = 1.0;
			}
			if (this.int_0 < 0)
			{
				this.int_0 = 0;
				this.int_1 = 0;
				this.double_0 = 0.0;
			}
			if (this.int_1 < 0)
			{
				this.int_1 = 0;
				this.double_0 = 0.0;
			}
			if (this.double_0 == 1.0)
			{
				this.double_0 = 0.0;
				this.int_1++;
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0008B55C File Offset: 0x0008975C
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0008B574 File Offset: 0x00089774
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0008B58C File Offset: 0x0008978C
		public double method_3()
		{
			return this.double_0;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0008B5A4 File Offset: 0x000897A4
		public int CompareTo(object target)
		{
			Class584 other = (Class584)target;
			return this.CompareTo(other);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0008B5C4 File Offset: 0x000897C4
		public int CompareTo(Class584 other)
		{
			int result;
			if (this.int_0 < other.method_1())
			{
				result = -1;
			}
			else if (this.int_0 > other.method_1())
			{
				result = 1;
			}
			else if (this.int_1 < other.method_2())
			{
				result = -1;
			}
			else if (this.int_1 > other.method_2())
			{
				result = 1;
			}
			else if (this.double_0 < other.method_3())
			{
				result = -1;
			}
			else if (this.double_0 > other.method_3())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0008B664 File Offset: 0x00089864
		public object Clone()
		{
			return new Class584(this.int_1, this.double_0);
		}

		// Token: 0x040008EA RID: 2282
		private int int_0 = 0;

		// Token: 0x040008EB RID: 2283
		private int int_1 = 0;

		// Token: 0x040008EC RID: 2284
		private double double_0 = 0.0;
	}
}
