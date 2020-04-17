using System;
using System.Runtime.CompilerServices;
using ns31;

namespace ns30
{
	// Token: 0x02000416 RID: 1046
	public class Class2410
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x000A03F0 File Offset: 0x0009E5F0
		[CompilerGenerated]
		public Class2420 method_0()
		{
			return this.class2420_0;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00011071 File Offset: 0x0000F271
		[CompilerGenerated]
		protected void method_1(Class2420 class2420_2)
		{
			this.class2420_0 = class2420_2;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000A0408 File Offset: 0x0009E608
		[CompilerGenerated]
		public Class2420 method_2()
		{
			return this.class2420_1;
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0001107A File Offset: 0x0000F27A
		[CompilerGenerated]
		protected void method_3(Class2420 class2420_2)
		{
			this.class2420_1 = class2420_2;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00011083 File Offset: 0x0000F283
		public Class2410() : this(new Class2420(), new Class2420())
		{
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00011095 File Offset: 0x0000F295
		public Class2410(Class2420 class2420_2, Class2420 class2420_3)
		{
			this.method_1(class2420_2);
			this.method_3(class2420_3);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000110AB File Offset: 0x0000F2AB
		public void method_4(double double_0)
		{
			this.method_0().method_8(double_0);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000110B9 File Offset: 0x0000F2B9
		public void method_5(double double_0)
		{
			this.method_2().method_8(double_0);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000A0420 File Offset: 0x0009E620
		public override string ToString()
		{
			return string.Format("km:({0:F0}, {1:F0}, {2:F0}) km/s:({3:F1}, {4:F1}, {5:F1})", new object[]
			{
				this.method_0().method_0(),
				this.method_0().method_2(),
				this.method_0().method_4(),
				this.method_2().method_0(),
				this.method_2().method_2(),
				this.method_2().method_4()
			});
		}

		// Token: 0x04000B31 RID: 2865
		[CompilerGenerated]
		private Class2420 class2420_0;

		// Token: 0x04000B32 RID: 2866
		[CompilerGenerated]
		private Class2420 class2420_1;
	}
}
