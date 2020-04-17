using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns23
{
	// Token: 0x0200067B RID: 1659
	public sealed class Class2257
	{
		// Token: 0x06002A36 RID: 10806 RVA: 0x000170EC File Offset: 0x000152EC
		public Class2257(IList<Coordinate> ilist_1, int int_3, int int_4, object object_1)
		{
			this.ilist_0 = ilist_1;
			this.int_1 = int_3;
			this.int_0 = int_4;
			this.object_0 = object_1;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000FE4DC File Offset: 0x000FC6DC
		public  int vmethod_0()
		{
			return this.int_2;
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00017118 File Offset: 0x00015318
		public  void vmethod_1(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000FE4F4 File Offset: 0x000FC6F4
		public  object vmethod_2()
		{
			return this.object_0;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000FE50C File Offset: 0x000FC70C
		public  Envelope vmethod_3()
		{
			if (this.envelope_0 == null)
			{
				Coordinate coordinate_ = this.ilist_0[this.int_1];
				Coordinate coordinate_2 = this.ilist_0[this.int_0];
				this.envelope_0 = new Envelope(coordinate_, coordinate_2);
			}
			return this.envelope_0;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000FE560 File Offset: 0x000FC760
		public  LineSegment vmethod_4(int int_3)
		{
			return new LineSegment(this.ilist_0[int_3], this.ilist_0[int_3 + 1]);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00017121 File Offset: 0x00015321
		public  void vmethod_5(IEnvelope ienvelope_0, Class2242 class2242_0)
		{
			this.method_0(ienvelope_0, this.int_1, this.int_0, class2242_0);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000FE590 File Offset: 0x000FC790
		private void method_0(IEnvelope ienvelope_0, int int_3, int int_4, Class2242 class2242_0)
		{
			Coordinate p = this.ilist_0[int_3];
			Coordinate p2 = this.ilist_0[int_4];
			class2242_0.envelope_0.Init(p, p2);
			if (int_4 - int_3 == 1)
			{
				class2242_0.vmethod_0(this, int_3);
			}
			else if (Class2183.smethod_15(ienvelope_0, class2242_0.envelope_0))
			{
				int num = (int_3 + int_4) / 2;
				if (int_3 < num)
				{
					this.method_0(ienvelope_0, int_3, num, class2242_0);
				}
				if (num < int_4)
				{
					this.method_0(ienvelope_0, num, int_4, class2242_0);
				}
			}
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00017137 File Offset: 0x00015337
		public  void vmethod_6(Class2257 class2257_0, Class2259 class2259_0)
		{
			this.method_1(this.int_1, this.int_0, class2257_0, class2257_0.int_1, class2257_0.int_0, class2259_0);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000FE618 File Offset: 0x000FC818
		private void method_1(int int_3, int int_4, Class2257 class2257_0, int int_5, int int_6, Class2259 class2259_0)
		{
			Coordinate p = this.ilist_0[int_3];
			Coordinate p2 = this.ilist_0[int_4];
			Coordinate p3 = class2257_0.ilist_0[int_5];
			Coordinate p4 = class2257_0.ilist_0[int_6];
			if (int_4 - int_3 == 1 && int_6 - int_5 == 1)
			{
				class2259_0.vmethod_0(this, int_3, class2257_0, int_5);
			}
			else
			{
				class2259_0.method_0().Init(p, p2);
				class2259_0.method_1().Init(p3, p4);
				if (Class2183.smethod_15(class2259_0.method_0(), class2259_0.method_1()))
				{
					int num = (int_3 + int_4) / 2;
					int num2 = (int_5 + int_6) / 2;
					if (int_3 < num)
					{
						if (int_5 < num2)
						{
							this.method_1(int_3, num, class2257_0, int_5, num2, class2259_0);
						}
						if (num2 < int_6)
						{
							this.method_1(int_3, num, class2257_0, num2, int_6, class2259_0);
						}
					}
					if (num < int_4)
					{
						if (int_5 < num2)
						{
							this.method_1(num, int_4, class2257_0, int_5, num2, class2259_0);
						}
						if (num2 < int_6)
						{
							this.method_1(num, int_4, class2257_0, num2, int_6, class2259_0);
						}
					}
				}
			}
		}

		// Token: 0x04001428 RID: 5160
		private readonly object object_0;

		// Token: 0x04001429 RID: 5161
		private readonly int int_0;

		// Token: 0x0400142A RID: 5162
		private readonly IList<Coordinate> ilist_0;

		// Token: 0x0400142B RID: 5163
		private readonly int int_1;

		// Token: 0x0400142C RID: 5164
		private Envelope envelope_0;

		// Token: 0x0400142D RID: 5165
		private int int_2 = 0;
	}
}
