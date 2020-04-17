using System;

namespace ns30
{
	// Token: 0x02000288 RID: 648
	public sealed class Class2389 : ICloneable
	{
		// Token: 0x06000F43 RID: 3907 RVA: 0x0000C261 File Offset: 0x0000A461
		public Class2389()
		{
			this.enum173_0 = Class2389.Enum173.const_0;
			this.double_0 = 0.0;
			this.double_1 = 1.0;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0000C28E File Offset: 0x0000A48E
		public Class2389(Class2389 class2389_0)
		{
			this.enum173_0 = class2389_0.method_0();
			this.double_0 = class2389_0.method_1();
			this.double_1 = class2389_0.method_2();
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0007CC2C File Offset: 0x0007AE2C
		public Class2389.Enum173 method_0()
		{
			return this.enum173_0;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0007CC44 File Offset: 0x0007AE44
		public double method_1()
		{
			return this.double_0;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0007CC5C File Offset: 0x0007AE5C
		public double method_2()
		{
			return this.double_1;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0007CC74 File Offset: 0x0007AE74
		object ICloneable.Clone()
		{
			return new Class2389(this);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0007CC8C File Offset: 0x0007AE8C
		public override int GetHashCode()
		{
			return this.double_0.GetHashCode() ^ this.double_1.GetHashCode() ^ this.enum173_0.GetHashCode();
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0007CCC4 File Offset: 0x0007AEC4
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Class2389)
			{
				Class2389 @class = (Class2389)obj;
				result = (this.double_0 == @class.method_1() && this.double_1 == @class.method_2() && this.enum173_0 == @class.method_0());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0007CD1C File Offset: 0x0007AF1C
		public override string ToString()
		{
			string result;
			switch (this.enum173_0)
			{
			case Class2389.Enum173.const_0:
				result = string.Format("({0}, {1})", this.double_0, this.double_1);
				break;
			case Class2389.Enum173.const_1:
				result = string.Format("[{0}, {1}]", this.double_0, this.double_1);
				break;
			case Class2389.Enum173.const_2:
				result = string.Format("({0}, {1}]", this.double_0, this.double_1);
				break;
			case Class2389.Enum173.const_3:
				result = string.Format("[{0}, {1})", this.double_0, this.double_1);
				break;
			default:
				result = "Unknown interval type.";
				break;
			}
			return result;
		}

		// Token: 0x04000633 RID: 1587
		private Class2389.Enum173 enum173_0;

		// Token: 0x04000634 RID: 1588
		private double double_0;

		// Token: 0x04000635 RID: 1589
		private double double_1;

		// Token: 0x02000289 RID: 649
		public enum Enum173
		{
			// Token: 0x04000637 RID: 1591
			const_0,
			// Token: 0x04000638 RID: 1592
			const_1,
			// Token: 0x04000639 RID: 1593
			const_2,
			// Token: 0x0400063A RID: 1594
			const_3
		}
	}
}
