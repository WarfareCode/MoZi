using System;
using System.Collections;
using GeoAPI.Geometries;

namespace ns12
{
	// Token: 0x020003B4 RID: 948
	public sealed class Class604 : Class603
	{
		// Token: 0x06001777 RID: 6007 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		public Class604() : this(10)
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0000FCA6 File Offset: 0x0000DEA6
		public Class604(int int_1) : base(int_1)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000928DC File Offset: 0x00090ADC
		private double method_1(double double_0, double double_1)
		{
			return (double_0 + double_1) / 2.0;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000928F8 File Offset: 0x00090AF8
		private double method_2(IEnvelope ienvelope_0)
		{
			return this.method_1(ienvelope_0.imethod_3(), ienvelope_0.imethod_1());
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0009291C File Offset: 0x00090B1C
		private double method_3(IEnvelope ienvelope_0)
		{
			return this.method_1(ienvelope_0.imethod_4(), ienvelope_0.imethod_2());
		}

		// Token: 0x020003B5 RID: 949
		private sealed class Class606 : IComparer
		{
			// Token: 0x0600177C RID: 6012 RVA: 0x00092940 File Offset: 0x00090B40
			public int Compare(object x, object y)
			{
				return this.class604_0.method_0(this.class604_0.method_2((IEnvelope)((Interface23)x).imethod_0()), this.class604_0.method_2((IEnvelope)((Interface23)y).imethod_0()));
			}

			// Token: 0x040009AA RID: 2474
			private Class604 class604_0;
		}

		// Token: 0x020003B6 RID: 950
		private sealed class Class607 : IComparer
		{
			// Token: 0x0600177E RID: 6014 RVA: 0x00092990 File Offset: 0x00090B90
			public int Compare(object x, object y)
			{
				return this.class604_0.method_0(this.class604_0.method_3((IEnvelope)((Interface23)x).imethod_0()), this.class604_0.method_3((IEnvelope)((Interface23)y).imethod_0()));
			}

			// Token: 0x040009AB RID: 2475
			private Class604 class604_0;
		}
	}
}
