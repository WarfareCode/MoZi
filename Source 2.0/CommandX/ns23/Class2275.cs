using System;
using ns28;

namespace ns23
{
	// Token: 0x020006B4 RID: 1716
	public sealed class Class2275
	{
		// Token: 0x06002B68 RID: 11112 RVA: 0x000179E4 File Offset: 0x00015BE4
		public Class2275(Class2275 class2275_0) : this(class2275_0.double_1, class2275_0.double_0)
		{
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000179F8 File Offset: 0x00015BF8
		public Class2275(double double_2, double double_3)
		{
			Class2347.smethod_0(double_2 <= double_3);
			this.double_1 = double_2;
			this.double_0 = double_3;
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00100544 File Offset: 0x000FE744
		public  double vmethod_0()
		{
			return (this.double_1 + this.double_0) / 2.0;
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0010056C File Offset: 0x000FE76C
		public  Class2275 vmethod_1(Class2275 class2275_0)
		{
			this.double_0 = Math.Max(this.double_0, class2275_0.double_0);
			this.double_1 = Math.Min(this.double_1, class2275_0.double_1);
			return this;
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00017A1A File Offset: 0x00015C1A
		public   bool vmethod_2(Class2275 class2275_0)
		{
			return class2275_0.double_1 <= this.double_0 && class2275_0.double_0 >= this.double_1;
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x001005AC File Offset: 0x000FE7AC
		public override bool Equals(object obj)
		{
			bool result;
			if (!(obj is Class2275))
			{
				result = false;
			}
			else
			{
				Class2275 @class = (Class2275)obj;
				result = (this.double_1 == @class.double_1 && this.double_0 == @class.double_0);
			}
			return result;
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04001490 RID: 5264
		private double double_0;

		// Token: 0x04001491 RID: 5265
		private double double_1;
	}
}
