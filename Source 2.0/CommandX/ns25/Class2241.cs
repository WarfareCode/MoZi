using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns23;
using ns24;

namespace ns25
{
	// Token: 0x02000638 RID: 1592
	public sealed class Class2241 : Interface42
	{
		// Token: 0x0600286F RID: 10351 RVA: 0x0001661E File Offset: 0x0001481E
		public Class2241(ILinearRing ilinearRing_1)
		{
			this.ilinearRing_0 = ilinearRing_1;
			this.method_0();
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000F3940 File Offset: 0x000F1B40
		public bool imethod_0(Coordinate coordinate_0)
		{
			this.int_0 = 0;
			Envelope ienvelope_ = new Envelope(double.NegativeInfinity, double.PositiveInfinity, coordinate_0.Y, coordinate_0.Y);
			this.class2252_0.vmethod_1(coordinate_0.Y);
			this.class2252_0.vmethod_3(coordinate_0.Y);
			IList list = this.class2251_0.vmethod_1(this.class2252_0);
			Class2241.Class2243 class2242_ = new Class2241.Class2243(this, coordinate_0);
			IEnumerator enumerator = list.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2257 class2257_ = (Class2257)enumerator.Current;
				Class2241.smethod_0(ienvelope_, class2242_, class2257_);
			}
			return this.int_0 % 2 == 1;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000F39E8 File Offset: 0x000F1BE8
		private void method_0()
		{
			this.class2251_0 = new Class2251();
			IList<Coordinate> ilist_ = Class2178.smethod_3(this.ilinearRing_0.GetCoordinates());
			IList list = Class2258.smethod_1(ilist_);
			for (int i = 0; i < list.Count; i++)
			{
				Class2257 @class = (Class2257)list[i];
				Envelope envelope = @class.vmethod_3();
				this.class2252_0.vmethod_1(envelope.GetMinimum().Y);
				this.class2252_0.vmethod_3(envelope.GetMaximum().Y);
				this.class2251_0.vmethod_0(this.class2252_0, @class);
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0001663E File Offset: 0x0001483E
		private static void smethod_0(IEnvelope ienvelope_0, Class2242 class2242_0, Class2257 class2257_0)
		{
			class2257_0.vmethod_5(ienvelope_0, class2242_0);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000F3A80 File Offset: 0x000F1C80
		private void method_1(Coordinate coordinate_0, ILineSegmentBase interface39_0)
		{
			Coordinate p = interface39_0.GetP0();
			Coordinate p2 = interface39_0.GetP1();
			double x = p.X - coordinate_0.X;
			double num = p.Y - coordinate_0.Y;
			double x2 = p2.X - coordinate_0.X;
			double num2 = p2.Y - coordinate_0.Y;
			if ((num > 0.0 && num2 <= 0.0) || (num2 > 0.0 && num <= 0.0))
			{
				double num3 = (double)RobustDeterminant.SignOfDet2X2(x, num, x2, num2) / (num2 - num);
				if (0.0 < num3)
				{
					this.int_0++;
				}
			}
		}

		// Token: 0x04001356 RID: 4950
		private readonly Class2252 class2252_0 = new Class2252();

		// Token: 0x04001357 RID: 4951
		private readonly ILinearRing ilinearRing_0;

		// Token: 0x04001358 RID: 4952
		private int int_0;

		// Token: 0x04001359 RID: 4953
		private Class2251 class2251_0;

		// Token: 0x02000639 RID: 1593
		private sealed class Class2243 : Class2242
		{
			// Token: 0x06002874 RID: 10356 RVA: 0x00016648 File Offset: 0x00014848
			public Class2243(Class2241 class2241_1, Coordinate coordinate_1)
			{
				this.class2241_0 = class2241_1;
				this.coordinate_0 = coordinate_1;
			}

			// Token: 0x06002875 RID: 10357 RVA: 0x00016669 File Offset: 0x00014869
			public  void vmethod_1(LineSegment lineSegment_1)
			{
				this.class2241_0.method_1(this.coordinate_0, lineSegment_1);
			}

			// Token: 0x0400135A RID: 4954
			private readonly Class2241 class2241_0;

			// Token: 0x0400135B RID: 4955
			private readonly Coordinate coordinate_0 = Coordinate.GetEmpty();
		}
	}
}
