using System;
using DotSpatial.Topology;
using ns25;

namespace ns24
{
	// Token: 0x02000567 RID: 1383
	public abstract class Class2198
	{
		// Token: 0x060023BA RID: 9146 RVA: 0x000E0BD8 File Offset: 0x000DEDD8
		public virtual Class2217 vmethod_0()
		{
			return this.class2217_0;
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00014B22 File Offset: 0x00012D22
		public  void vmethod_1(Class2217 class2217_1)
		{
			this.class2217_0 = class2217_1;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00014B2B File Offset: 0x00012D2B
		public  void vmethod_2(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00014B34 File Offset: 0x00012D34
		public   bool vmethod_3()
		{
			return this.bool_1;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00014B3C File Offset: 0x00012D3C
		public  void vmethod_4(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x060023BF RID: 9151
		public abstract Coordinate vmethod_5();

		// Token: 0x04001143 RID: 4419
		private bool bool_0;

		// Token: 0x04001144 RID: 4420
		private bool bool_1;

		// Token: 0x04001145 RID: 4421
		private Class2217 class2217_0;
	}
}
