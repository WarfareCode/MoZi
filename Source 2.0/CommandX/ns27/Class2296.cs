using System;
using DotSpatial.Topology;
using ns25;
using ns28;

namespace ns27
{
	// Token: 0x02000707 RID: 1799
	public sealed class Class2296
	{
		// Token: 0x06002CD8 RID: 11480 RVA: 0x0010280C File Offset: 0x00100A0C
		public Class2296(Coordinate coordinate_5, double double_5, LineIntersector class2239_1)
		{
			this.coordinate_1 = coordinate_5;
			this.coordinate_4 = coordinate_5;
			this.double_0 = double_5;
			this.class2239_0 = class2239_1;
			if (double_5 != 1.0)
			{
				this.coordinate_4 = new Coordinate(this.method_3(coordinate_5.X), this.method_3(coordinate_5.Y));
				this.coordinate_2 = new Coordinate();
				this.coordinate_3 = new Coordinate();
			}
			this.method_2(this.coordinate_4);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x001028C8 File Offset: 0x00100AC8
		public Coordinate method_0()
		{
			return this.coordinate_1;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x001028E0 File Offset: 0x00100AE0
		public Envelope method_1()
		{
			if (this.envelope_0 == null)
			{
				double num = 0.75 / this.double_0;
				this.envelope_0 = new Envelope(this.coordinate_1.X - num, this.coordinate_1.X + num, this.coordinate_1.Y - num, this.coordinate_1.Y + num);
			}
			return this.envelope_0;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00102954 File Offset: 0x00100B54
		private void method_2(Coordinate coordinate_5)
		{
			this.double_3 = coordinate_5.X - 0.5;
			this.double_1 = coordinate_5.X + 0.5;
			this.double_4 = coordinate_5.Y - 0.5;
			this.double_2 = coordinate_5.Y + 0.5;
			this.coordinate_0[0] = new Coordinate(this.double_1, this.double_2);
			this.coordinate_0[1] = new Coordinate(this.double_3, this.double_2);
			this.coordinate_0[2] = new Coordinate(this.double_3, this.double_4);
			this.coordinate_0[3] = new Coordinate(this.double_1, this.double_4);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00102A20 File Offset: 0x00100C20
		private double method_3(double double_5)
		{
			return Math.Round(double_5 * this.double_0);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00102A3C File Offset: 0x00100C3C
		public bool method_4(Coordinate coordinate_5, Coordinate coordinate_6)
		{
			bool result;
			if (this.double_0 == 1.0)
			{
				result = this.method_6(coordinate_5, coordinate_6);
			}
			else
			{
				this.method_5(coordinate_5, this.coordinate_2);
				this.method_5(coordinate_6, this.coordinate_3);
				result = this.method_6(this.coordinate_2, this.coordinate_3);
			}
			return result;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00018630 File Offset: 0x00016830
		private void method_5(Coordinate coordinate_5, Coordinate coordinate_6)
		{
			coordinate_6.X = this.method_3(coordinate_5.X);
			coordinate_6.Y = this.method_3(coordinate_5.Y);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00102A98 File Offset: 0x00100C98
		public bool method_6(Coordinate coordinate_5, Coordinate coordinate_6)
		{
			double num = Math.Min(coordinate_5.X, coordinate_6.X);
			double num2 = Math.Max(coordinate_5.X, coordinate_6.X);
			double num3 = Math.Min(coordinate_5.Y, coordinate_6.Y);
			double num4 = Math.Max(coordinate_5.Y, coordinate_6.Y);
			bool result;
			if (this.double_1 < num || this.double_3 > num2 || this.double_2 < num3 || this.double_4 > num4)
			{
				result = false;
			}
			else
			{
				bool flag;
				Class2347.smethod_1(!(flag = this.method_7(coordinate_5, coordinate_6)), "Found bad envelope test");
				result = flag;
			}
			return result;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00102B40 File Offset: 0x00100D40
		private bool method_7(Coordinate coordinate_5, Coordinate coordinate_6)
		{
			bool flag = false;
			bool flag2 = false;
			this.class2239_0.ComputeIntersection(coordinate_5, coordinate_6, this.coordinate_0[0], this.coordinate_0[1]);
			bool result;
			if (this.class2239_0.vmethod_14())
			{
				result = true;
			}
			else
			{
				this.class2239_0.ComputeIntersection(coordinate_5, coordinate_6, this.coordinate_0[1], this.coordinate_0[2]);
				if (this.class2239_0.vmethod_14())
				{
					result = true;
				}
				else
				{
					if (this.class2239_0.HasIntersection())
					{
						flag = true;
					}
					this.class2239_0.ComputeIntersection(coordinate_5, coordinate_6, this.coordinate_0[2], this.coordinate_0[3]);
					if (this.class2239_0.vmethod_14())
					{
						result = true;
					}
					else
					{
						if (this.class2239_0.HasIntersection())
						{
							flag2 = true;
						}
						this.class2239_0.ComputeIntersection(coordinate_5, coordinate_6, this.coordinate_0[3], this.coordinate_0[0]);
						result = (this.class2239_0.vmethod_14() || (flag && flag2) || coordinate_5.Equals(this.coordinate_4) || coordinate_6.Equals(this.coordinate_4));
					}
				}
			}
			return result;
		}

		// Token: 0x04001507 RID: 5383
		private readonly Coordinate[] coordinate_0 = new Coordinate[4];

		// Token: 0x04001508 RID: 5384
		private readonly LineIntersector class2239_0;

		// Token: 0x04001509 RID: 5385
		private readonly Coordinate coordinate_1;

		// Token: 0x0400150A RID: 5386
		private readonly Coordinate coordinate_2;

		// Token: 0x0400150B RID: 5387
		private readonly Coordinate coordinate_3;

		// Token: 0x0400150C RID: 5388
		private readonly Coordinate coordinate_4;

		// Token: 0x0400150D RID: 5389
		private readonly double double_0;

		// Token: 0x0400150E RID: 5390
		private double double_1;

		// Token: 0x0400150F RID: 5391
		private double double_2 = 0.0;

		// Token: 0x04001510 RID: 5392
		private double double_3 = 0.0;

		// Token: 0x04001511 RID: 5393
		private double double_4 = 0.0;

		// Token: 0x04001512 RID: 5394
		private Envelope envelope_0;
	}
}
