using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns25;

namespace ns27
{
	// Token: 0x02000740 RID: 1856
	public sealed class Class2305
	{
		// Token: 0x06002E1B RID: 11803 RVA: 0x000191B8 File Offset: 0x000173B8
		public Class2305(IGeometry igeometry_1, double double_1, Class2304 class2304_1)
		{
			this.igeometry_0 = igeometry_1;
			this.double_0 = double_1;
			this.class2304_0 = class2304_1;
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00104F58 File Offset: 0x00103158
		public  IList vmethod_0()
		{
			this.method_2(this.igeometry_0);
			return this.ilist_0;
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00104F7C File Offset: 0x0010317C
		private void method_0(IEnumerable ienumerable_0, LocationType enum157_0, LocationType enum157_1)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				this.method_1(enumerator.Current as IList<Coordinate>, enum157_0, enum157_1);
			}
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00104FB0 File Offset: 0x001031B0
		private void method_1(IList<Coordinate> ilist_1, LocationType enum157_0, LocationType enum157_1)
		{
			if (ilist_1.Count >= 2)
			{
				Class2295 value = new Class2295(ilist_1, new Class2217(0, LocationType.Boundary, enum157_0, enum157_1));
				this.ilist_0.Add(value);
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00104FE8 File Offset: 0x001031E8
		private void method_2(IGeometry igeometry_1)
		{
			if (!igeometry_1.IsEmpty())
			{
				if (igeometry_1 is Polygon)
				{
					this.method_6((Polygon)igeometry_1);
				}
				else if (igeometry_1 is LineString)
				{
					this.method_5((LineString)igeometry_1);
				}
				else if (igeometry_1 is Point)
				{
					this.method_4((Point)igeometry_1);
				}
				else if (igeometry_1 is MultiPoint)
				{
					this.method_3((MultiPoint)igeometry_1);
				}
				else if (igeometry_1 is MultiLineString)
				{
					this.method_3((MultiLineString)igeometry_1);
				}
				else if (igeometry_1 is MultiPolygon)
				{
					this.method_3((MultiPolygon)igeometry_1);
				}
				else
				{
					if (!(igeometry_1 is GeometryCollection))
					{
						throw new NotSupportedException(igeometry_1.GetType().FullName);
					}
					this.method_3((GeometryCollection)igeometry_1);
				}
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x001050DC File Offset: 0x001032DC
		private void method_3(IGeometryCollection igeometryCollection_0)
		{
			for (int i = 0; i < igeometryCollection_0.GetNumGeometries(); i++)
			{
				IGeometry geometryN = igeometryCollection_0.GetGeometryN(i);
				this.method_2(geometryN);
			}
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x0010510C File Offset: 0x0010330C
		private void method_4(IPoint ipoint_0)
		{
			if (this.double_0 > 0.0)
			{
				IList<Coordinate> coordinates = ipoint_0.GetCoordinates();
				IList ienumerable_ = this.class2304_0.vmethod_1(coordinates, this.double_0);
				this.method_0(ienumerable_, LocationType.Exterior, LocationType.Interior);
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00105150 File Offset: 0x00103350
		private void method_5(ILineString ilineString_0)
		{
			if (this.double_0 > 0.0)
			{
				IList<Coordinate> ilist_ = Class2178.smethod_3(ilineString_0.GetCoordinates());
				IList ienumerable_ = this.class2304_0.vmethod_1(ilist_, this.double_0);
				this.method_0(ienumerable_, LocationType.Exterior, LocationType.Interior);
			}
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00105198 File Offset: 0x00103398
		private void method_6(IPolygon ipolygon_0)
		{
			double double_ = this.double_0;
			Enum158 enum158_ = Enum158.const_1;
			if (this.double_0 < 0.0)
			{
				double_ = -this.double_0;
				enum158_ = Enum158.const_2;
			}
			ILinearRing shell = ipolygon_0.GetShell();
			IList<Coordinate> ilist_ = Class2178.smethod_3(shell.GetCoordinates());
			if (this.double_0 >= 0.0 || !this.method_8(ilist_, this.double_0))
			{
				this.method_7(ilist_, double_, enum158_, LocationType.Exterior, LocationType.Interior);
				for (int i = 0; i < ipolygon_0.GetNumHoles(); i++)
				{
					ILinearRing linearRing = (ILinearRing)ipolygon_0.GetInteriorRingN(i);
					IList<Coordinate> ilist_2 = Class2178.smethod_3(linearRing.GetCoordinates());
					if (this.double_0 <= 0.0 || !this.method_8(ilist_2, -this.double_0))
					{
						this.method_7(ilist_2, double_, Class2222.smethod_0(enum158_), LocationType.Interior, LocationType.Exterior);
					}
				}
			}
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x0010527C File Offset: 0x0010347C
		private void method_7(IList<Coordinate> ilist_1, double double_1, Enum158 enum158_0, LocationType enum157_0, LocationType enum157_1)
		{
			LocationType enum157_2 = enum157_0;
			LocationType enum157_3 = enum157_1;
			if (CgAlgorithms.IsCounterClockwise(ilist_1))
			{
				enum157_2 = enum157_1;
				enum157_3 = enum157_0;
				enum158_0 = Class2222.smethod_0(enum158_0);
			}
			IList ienumerable_ = this.class2304_0.vmethod_2(ilist_1, enum158_0, double_1);
			this.method_0(ienumerable_, enum157_2, enum157_3);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x001052C0 File Offset: 0x001034C0
		private bool method_8(IList<Coordinate> ilist_1, double double_1)
		{
			bool result;
			if (ilist_1.Count < 4)
			{
				result = (double_1 < 0.0);
			}
			else if (ilist_1.Count == 4)
			{
				result = this.method_9(ilist_1, double_1);
			}
			else
			{
				ILinearRing igeometry_ = this.igeometry_0.GetFactory().CreateLinearRing(ilist_1);
				Class2245 @class = new Class2245(igeometry_);
				double num = @class.vmethod_0();
				result = (num < 2.0 * Math.Abs(double_1));
			}
			return result;
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00105338 File Offset: 0x00103538
		private bool method_9(IList<Coordinate> ilist_1, double double_1)
		{
			Class2227 @class = new Class2227(ilist_1[0], ilist_1[1], ilist_1[2]);
			Coordinate p = @class.vmethod_3();
			double num = CgAlgorithms.DistancePointLine(p, @class.vmethod_2(), @class.vmethod_1());
			return num < Math.Abs(double_1);
		}

		// Token: 0x04001580 RID: 5504
		private readonly Class2304 class2304_0;

		// Token: 0x04001581 RID: 5505
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x04001582 RID: 5506
		private readonly double double_0;

		// Token: 0x04001583 RID: 5507
		private readonly IGeometry igeometry_0;
	}
}
