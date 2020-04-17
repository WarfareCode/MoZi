using System;
using System.Runtime.CompilerServices;
using DotSpatial.Topology;

namespace ns23
{
	// Token: 0x0200067D RID: 1661
	public class Class2259
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x000FE838 File Offset: 0x000FCA38
		public Envelope method_0()
		{
			return this.envelope_0;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000FE850 File Offset: 0x000FCA50
		public Envelope method_1()
		{
			return this.envelope_1;
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000FE868 File Offset: 0x000FCA68
		[CompilerGenerated]
		protected LineSegment method_2()
		{
			return this.lineSegment_0;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00017159 File Offset: 0x00015359
		[CompilerGenerated]
		protected void method_3(LineSegment lineSegment_2)
		{
			this.lineSegment_0 = lineSegment_2;
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000FE880 File Offset: 0x000FCA80
		[CompilerGenerated]
		protected LineSegment method_4()
		{
			return this.lineSegment_1;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00017162 File Offset: 0x00015362
		[CompilerGenerated]
		protected void method_5(LineSegment lineSegment_2)
		{
			this.lineSegment_1 = lineSegment_2;
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0001716B File Offset: 0x0001536B
		public  void vmethod_0(Class2257 class2257_0, int int_0, Class2257 class2257_1, int int_1)
		{
			this.method_3(class2257_0.vmethod_4(int_0));
			this.method_5(class2257_1.vmethod_4(int_1));
			this.vmethod_1(this.method_2(), this.method_4());
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_1(LineSegment lineSegment_2, LineSegment lineSegment_3)
		{
		}

		// Token: 0x0400142E RID: 5166
		private Envelope envelope_0 = new Envelope();

		// Token: 0x0400142F RID: 5167
		private Envelope envelope_1 = new Envelope();

		// Token: 0x04001430 RID: 5168
		[CompilerGenerated]
		private LineSegment lineSegment_0;

		// Token: 0x04001431 RID: 5169
		[CompilerGenerated]
		private LineSegment lineSegment_1;
	}
}
