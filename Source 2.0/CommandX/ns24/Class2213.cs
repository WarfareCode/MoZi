using System;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns24
{
	// Token: 0x0200059C RID: 1436
	public sealed class Class2213
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x000E2E38 File Offset: 0x000E1038
		public Class2213(Class2199 class2199_1)
		{
			this.class2199_0 = class2199_1;
			this.ilist_0 = class2199_1.vmethod_8();
			Class2214 @class = new Class2214();
			this.int_0 = @class.vmethod_0(this.ilist_0);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000E2E8C File Offset: 0x000E108C
		public  int[] vmethod_0()
		{
			return this.int_0;
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000E2EA4 File Offset: 0x000E10A4
		public  double vmethod_1(int int_1)
		{
			double x = this.ilist_0[this.int_0[int_1]].X;
			double x2 = this.ilist_0[this.int_0[int_1 + 1]].X;
			double result;
			if (x >= x2)
			{
				result = x2;
			}
			else
			{
				result = x;
			}
			return result;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000E2EF4 File Offset: 0x000E10F4
		public  double vmethod_2(int int_1)
		{
			double x = this.ilist_0[this.int_0[int_1]].X;
			double x2 = this.ilist_0[this.int_0[int_1 + 1]].X;
			double result;
			if (x <= x2)
			{
				result = x2;
			}
			else
			{
				result = x;
			}
			return result;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00015196 File Offset: 0x00013396
		public  void vmethod_3(int int_1, Class2213 class2213_0, int int_2, SegmentIntersector class2215_0)
		{
			this.method_0(this.int_0[int_1], this.int_0[int_1 + 1], class2213_0, class2213_0.int_0[int_2], class2213_0.int_0[int_2 + 1], class2215_0);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000E2F44 File Offset: 0x000E1144
		private void method_0(int int_1, int int_2, Class2213 class2213_0, int int_3, int int_4, SegmentIntersector class2215_0)
		{
			Coordinate p = this.ilist_0[int_1];
			Coordinate p2 = this.ilist_0[int_2];
			Coordinate p3 = class2213_0.ilist_0[int_3];
			Coordinate p4 = class2213_0.ilist_0[int_4];
			if (int_2 - int_1 == 1 && int_4 - int_3 == 1)
			{
				class2215_0.vmethod_2(this.class2199_0, int_1, class2213_0.class2199_0, int_3);
			}
			else
			{
				this.envelope_0.Init(p, p2);
				this.envelope_1.Init(p3, p4);
				if (Class2183.smethod_15(this.envelope_0, this.envelope_1))
				{
					int num = (int_1 + int_2) / 2;
					int num2 = (int_3 + int_4) / 2;
					if (int_1 < num)
					{
						if (int_3 < num2)
						{
							this.method_0(int_1, num, class2213_0, int_3, num2, class2215_0);
						}
						if (num2 < int_4)
						{
							this.method_0(int_1, num, class2213_0, num2, int_4, class2215_0);
						}
					}
					if (num < int_2)
					{
						if (int_3 < num2)
						{
							this.method_0(num, int_2, class2213_0, int_3, num2, class2215_0);
						}
						if (num2 < int_4)
						{
							this.method_0(num, int_2, class2213_0, num2, int_4, class2215_0);
						}
					}
				}
			}
		}

		// Token: 0x040011B3 RID: 4531
		private readonly Class2199 class2199_0;

		// Token: 0x040011B4 RID: 4532
		private readonly Envelope envelope_0 = new Envelope();

		// Token: 0x040011B5 RID: 4533
		private readonly Envelope envelope_1 = new Envelope();

		// Token: 0x040011B6 RID: 4534
		private readonly IList<Coordinate> ilist_0;

		// Token: 0x040011B7 RID: 4535
		private readonly int[] int_0;
	}
}
