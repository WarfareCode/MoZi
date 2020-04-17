using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DotSpatial.Topology;
using ns16;
using ns24;
using ns25;

namespace ns27
{
	// Token: 0x02000731 RID: 1841
	public sealed class Class2304
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x0010411C File Offset: 0x0010231C
		public Class2304(PrecisionModel precisionModel_1, int int_0)
		{
			this.precisionModel_0 = precisionModel_1;
			this.class2239_0 = new RobustLineIntersector();
			int num = (int_0 < 1) ? 1 : int_0;
			this.double_0 = 1.5707963267948966 / (double)num;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00018EB0 File Offset: 0x000170B0
		public  void vmethod_0(BufferStyle enum156_1)
		{
			this.enum156_0 = enum156_1;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00104190 File Offset: 0x00102390
		private IList<Coordinate> method_0()
		{
			if (this.ilist_0.Count > 1)
			{
				Coordinate coordinate = this.ilist_0.First<Coordinate>();
				Coordinate obj = this.ilist_0.Last<Coordinate>();
				if (!coordinate.Equals(obj))
				{
					this.method_4(coordinate);
				}
			}
			return this.ilist_0;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x001041E0 File Offset: 0x001023E0
		public  IList vmethod_1(IList<Coordinate> ilist_1, double double_2)
		{
			IList list = new ArrayList();
			IList result;
			if (double_2 <= 0.0)
			{
				result = list;
			}
			else
			{
				this.method_1(double_2);
				if (ilist_1.Count <= 1)
				{
					switch (this.enum156_0)
					{
					case BufferStyle.CapRound:
						this.method_12(ilist_1[0], double_2);
						break;
					case BufferStyle.CapSquare:
						this.method_13(ilist_1[0], double_2);
						break;
					}
				}
				else
				{
					this.method_2(ilist_1);
				}
				IList<Coordinate> value = this.method_0();
				list.Add(value);
				result = list;
			}
			return result;
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00104270 File Offset: 0x00102470
		public  IList vmethod_2(IList<Coordinate> ilist_1, Enum158 enum158_1, double double_2)
		{
			IList list = new ArrayList();
			this.method_1(double_2);
			IList result;
			if (ilist_1.Count <= 2)
			{
				result = this.vmethod_1(ilist_1, double_2);
			}
			else if (double_2 == 0.0)
			{
				list.Add(Class2304.smethod_0(ilist_1));
				result = list;
			}
			else
			{
				this.method_3(ilist_1, enum158_1);
				list.Add(this.method_0());
				result = list;
			}
			return result;
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x001042DC File Offset: 0x001024DC
		private static IList<Coordinate> smethod_0(IEnumerable<Coordinate> ienumerable_0)
		{
			return EnumerableExt.CloneList<Coordinate>(ienumerable_0);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00018EB9 File Offset: 0x000170B9
		private void method_1(double double_2)
		{
			this.double_1 = double_2;
			this.ilist_0 = new List<Coordinate>();
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x001042F4 File Offset: 0x001024F4
		private void method_2(IList<Coordinate> ilist_1)
		{
			int num = ilist_1.Count - 1;
			this.method_6(ilist_1[0], ilist_1[1], Enum158.const_1);
			for (int i = 2; i <= num; i++)
			{
				this.method_7(ilist_1[i], true);
			}
			this.method_8();
			this.method_9(ilist_1[num - 1], ilist_1[num]);
			this.method_6(ilist_1[num], ilist_1[num - 1], Enum158.const_1);
			for (int j = num - 2; j >= 0; j--)
			{
				this.method_7(ilist_1[j], true);
			}
			this.method_8();
			this.method_9(ilist_1[1], ilist_1[0]);
			this.method_5();
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x001043B4 File Offset: 0x001025B4
		private void method_3(IList<Coordinate> ilist_1, Enum158 enum158_1)
		{
			int num = ilist_1.Count - 1;
			this.method_6(ilist_1[num - 1], ilist_1[0], enum158_1);
			for (int i = 1; i <= num; i++)
			{
				bool bool_ = i != 1;
				this.method_7(ilist_1[i], bool_);
			}
			this.method_5();
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00104410 File Offset: 0x00102610
		private void method_4(Coordinate coordinate_3)
		{
			Coordinate coordinate = new Coordinate(coordinate_3);
			this.precisionModel_0.MakePrecise(coordinate);
			Coordinate obj = null;
			if (this.ilist_0.Count >= 1)
			{
				obj = this.ilist_0.Last<Coordinate>();
			}
			if (!Coordinate.NotEquals(obj, null) || !coordinate.Equals(obj))
			{
				this.ilist_0.Add(coordinate);
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00104474 File Offset: 0x00102674
		private void method_5()
		{
			if (this.ilist_0.Count >= 1)
			{
				Coordinate coordinate = new Coordinate(this.ilist_0[0]);
				Coordinate obj = this.ilist_0[this.ilist_0.Count - 1];
				if (!coordinate.Equals(obj))
				{
					this.ilist_0.Add(coordinate);
				}
			}
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00018ECD File Offset: 0x000170CD
		private void method_6(Coordinate coordinate_3, Coordinate coordinate_4, Enum158 enum158_1)
		{
			this.coordinate_1 = coordinate_3;
			this.coordinate_2 = coordinate_4;
			this.enum158_0 = enum158_1;
			this.lineSegment_3.SetCoordinates(coordinate_3, coordinate_4);
			Class2304.smethod_1(this.lineSegment_3, enum158_1, this.double_1, this.lineSegment_1);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x001044D8 File Offset: 0x001026D8
		private void method_7(Coordinate coordinate_3, bool bool_0)
		{
			this.coordinate_0 = this.coordinate_1;
			this.coordinate_1 = this.coordinate_2;
			this.coordinate_2 = coordinate_3;
			this.lineSegment_2.SetCoordinates(this.coordinate_0, this.coordinate_1);
			Class2304.smethod_1(this.lineSegment_2, this.enum158_0, this.double_1, this.lineSegment_0);
			this.lineSegment_3.SetCoordinates(this.coordinate_1, this.coordinate_2);
			Class2304.smethod_1(this.lineSegment_3, this.enum158_0, this.double_1, this.lineSegment_1);
			if (!this.coordinate_1.Equals(this.coordinate_2))
			{
				int num = CgAlgorithms.ComputeOrientation(this.coordinate_0, this.coordinate_1, this.coordinate_2);
				bool flag = (num == -1 && this.enum158_0 == Enum158.const_1) || (num == 1 && this.enum158_0 == Enum158.const_2);
				bool flag2 = flag;
				if (num == 0)
				{
					this.class2239_0.ComputeIntersection(this.coordinate_0, this.coordinate_1, this.coordinate_1, this.coordinate_2);
					int num2 = this.class2239_0.vmethod_11();
					if (num2 >= 2)
					{
						this.method_10(this.coordinate_1, this.lineSegment_0.GetP1(), this.lineSegment_1.GetP0(), -1, this.double_1);
					}
				}
				else if (flag2)
				{
					if (bool_0)
					{
						this.method_4(this.lineSegment_0.GetP1());
					}
					this.method_10(this.coordinate_1, this.lineSegment_0.GetP1(), this.lineSegment_1.GetP0(), num, this.double_1);
					this.method_4(this.lineSegment_1.GetP0());
				}
				else
				{
					this.class2239_0.ComputeIntersection(this.lineSegment_0.GetP0(), this.lineSegment_0.GetP1(), this.lineSegment_1.GetP0(), this.lineSegment_1.GetP1());
					if (this.class2239_0.HasIntersection())
					{
						this.method_4(this.class2239_0.GetIntersection(0));
					}
					else if (new Coordinate(this.lineSegment_0.GetP1()).Distance(this.lineSegment_1.GetP0()) < this.double_1 / 1000.0)
					{
						this.method_4(this.lineSegment_0.GetP1());
					}
					else
					{
						this.method_4(this.lineSegment_0.GetP1());
						this.method_4(this.coordinate_1);
						this.method_4(this.lineSegment_1.GetP0());
					}
				}
			}
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00018F09 File Offset: 0x00017109
		private void method_8()
		{
			this.method_4(this.lineSegment_1.GetP1());
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x0010476C File Offset: 0x0010296C
		private static void smethod_1(ILineSegmentBase interface39_0, Enum158 enum158_1, double double_2, ILineSegmentBase interface39_1)
		{
			int num = (enum158_1 == Enum158.const_1) ? 1 : -1;
			double num2 = interface39_0.GetP1().X - interface39_0.GetP0().X;
			double num3 = interface39_0.GetP1().Y - interface39_0.GetP0().Y;
			double num4 = Math.Sqrt(num2 * num2 + num3 * num3);
			double num5 = (double)num * double_2 * num2 / num4;
			double num6 = (double)num * double_2 * num3 / num4;
			interface39_1.GetP0().X = interface39_0.GetP0().X - num6;
			interface39_1.GetP0().Y = interface39_0.GetP0().Y + num5;
			interface39_1.GetP1().X = interface39_0.GetP1().X - num6;
			interface39_1.GetP1().Y = interface39_0.GetP1().Y + num5;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00104838 File Offset: 0x00102A38
		private void method_9(Coordinate coordinate_3, Coordinate coordinate_4)
		{
			LineSegment interface39_ = new LineSegment(coordinate_3, coordinate_4);
			LineSegment lineSegment = new LineSegment();
			Class2304.smethod_1(interface39_, Enum158.const_1, this.double_1, lineSegment);
			LineSegment lineSegment2 = new LineSegment();
			Class2304.smethod_1(interface39_, Enum158.const_2, this.double_1, lineSegment2);
			double x = coordinate_4.X - coordinate_3.X;
			double y = coordinate_4.Y - coordinate_3.Y;
			double num = Math.Atan2(y, x);
			switch (this.enum156_0)
			{
			case BufferStyle.CapRound:
				this.method_4(lineSegment.GetP1());
				this.method_11(coordinate_4, num + 1.5707963267948966, num - 1.5707963267948966, -1, this.double_1);
				this.method_4(lineSegment2.GetP1());
				break;
			case BufferStyle.CapButt:
				this.method_4(lineSegment.GetP1());
				this.method_4(lineSegment2.GetP1());
				break;
			case BufferStyle.CapSquare:
			{
				Coordinate coordinate = new Coordinate();
				coordinate.X = Math.Abs(this.double_1) * Math.Cos(num);
				coordinate.Y = Math.Abs(this.double_1) * Math.Sin(num);
				Coordinate coordinate_5 = new Coordinate(lineSegment.GetP1().X + coordinate.X, lineSegment.GetP1().Y + coordinate.Y);
				Coordinate coordinate_6 = new Coordinate(lineSegment2.GetP1().X + coordinate.X, lineSegment2.GetP1().Y + coordinate.Y);
				this.method_4(coordinate_5);
				this.method_4(coordinate_6);
				break;
			}
			}
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x001049C4 File Offset: 0x00102BC4
		private void method_10(Coordinate coordinate_3, Coordinate coordinate_4, Coordinate coordinate_5, int int_0, double double_2)
		{
			double x = coordinate_4.X - coordinate_3.X;
			double y = coordinate_4.Y - coordinate_3.Y;
			double num = Math.Atan2(y, x);
			double x2 = coordinate_5.X - coordinate_3.X;
			double y2 = coordinate_5.Y - coordinate_3.Y;
			double num2 = Math.Atan2(y2, x2);
			if (int_0 == -1)
			{
				if (num <= num2)
				{
					num += 6.2831853071795862;
				}
			}
			else if (num >= num2)
			{
				num -= 6.2831853071795862;
			}
			this.method_4(coordinate_4);
			this.method_11(coordinate_3, num, num2, int_0, double_2);
			this.method_4(coordinate_5);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00104A6C File Offset: 0x00102C6C
		private void method_11(Coordinate coordinate_3, double double_2, double double_3, int int_0, double double_4)
		{
			int num = (int_0 == -1) ? -1 : 1;
			double num2 = Math.Abs(double_2 - double_3);
			int num3 = (int)(num2 / this.double_0 + 0.5);
			if (num3 >= 1)
			{
				double num4 = num2 / (double)num3;
				double num5 = 0.0;
				Coordinate coordinate = new Coordinate();
				while (num5 < num2)
				{
					double num6 = double_2 + (double)num * num5;
					coordinate.X = coordinate_3.X + double_4 * Math.Cos(num6);
					coordinate.Y = coordinate_3.Y + double_4 * Math.Sin(num6);
					this.method_4(coordinate);
					num5 += num4;
				}
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00104B10 File Offset: 0x00102D10
		private void method_12(Coordinate coordinate_3, double double_2)
		{
			Coordinate coordinate_4 = new Coordinate(coordinate_3.X + double_2, coordinate_3.Y);
			this.method_4(coordinate_4);
			this.method_11(coordinate_3, 0.0, 6.2831853071795862, -1, double_2);
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00104B54 File Offset: 0x00102D54
		private void method_13(Coordinate coordinate_3, double double_2)
		{
			this.method_4(new Coordinate(coordinate_3.X + double_2, coordinate_3.Y + double_2));
			this.method_4(new Coordinate(coordinate_3.X + double_2, coordinate_3.Y - double_2));
			this.method_4(new Coordinate(coordinate_3.X - double_2, coordinate_3.Y - double_2));
			this.method_4(new Coordinate(coordinate_3.X - double_2, coordinate_3.Y + double_2));
			this.method_4(new Coordinate(coordinate_3.X + double_2, coordinate_3.Y + double_2));
		}

		// Token: 0x0400155A RID: 5466
		private readonly double double_0;

		// Token: 0x0400155B RID: 5467
		private readonly LineIntersector class2239_0;

		// Token: 0x0400155C RID: 5468
		private readonly LineSegment lineSegment_0 = new LineSegment();

		// Token: 0x0400155D RID: 5469
		private readonly LineSegment lineSegment_1 = new LineSegment();

		// Token: 0x0400155E RID: 5470
		private readonly PrecisionModel precisionModel_0;

		// Token: 0x0400155F RID: 5471
		private readonly LineSegment lineSegment_2 = new LineSegment();

		// Token: 0x04001560 RID: 5472
		private readonly LineSegment lineSegment_3 = new LineSegment();

		// Token: 0x04001561 RID: 5473
		private double double_1;

		// Token: 0x04001562 RID: 5474
		private BufferStyle enum156_0 = BufferStyle.CapRound;

		// Token: 0x04001563 RID: 5475
		private IList<Coordinate> ilist_0;

		// Token: 0x04001564 RID: 5476
		private Coordinate coordinate_0;

		// Token: 0x04001565 RID: 5477
		private Coordinate coordinate_1;

		// Token: 0x04001566 RID: 5478
		private Coordinate coordinate_2;

		// Token: 0x04001567 RID: 5479
		private Enum158 enum158_0;
	}
}
