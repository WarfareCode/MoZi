using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200063B RID: 1595
	public sealed class Class2245
	{
		// Token: 0x06002879 RID: 10361 RVA: 0x000166AB File Offset: 0x000148AB
		public Class2245(IGeometry igeometry_1) : this(igeometry_1, false)
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000F3B44 File Offset: 0x000F1D44
		public Class2245(IGeometry igeometry_1, bool bool_1)
		{
			this.igeometry_0 = igeometry_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000F3BA0 File Offset: 0x000F1DA0
		public  double vmethod_0()
		{
			this.method_0();
			return this.double_0;
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000F3BBC File Offset: 0x000F1DBC
		private void method_0()
		{
			if (!this.coordinate_0.IsEmpty())
			{
				if (this.bool_0)
				{
					this.method_1(this.igeometry_0);
				}
				else
				{
					IGeometry igeometry_ = new Class2236(this.igeometry_0).vmethod_0();
					this.method_1(igeometry_);
				}
			}
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000F3C0C File Offset: 0x000F1E0C
		private void method_1(IGeometry igeometry_1)
		{
			IList<Coordinate> coordinates;
			if (igeometry_1 is Polygon)
			{
				coordinates = ((Polygon)igeometry_1).GetShell().GetCoordinates();
			}
			else
			{
				coordinates = igeometry_1.GetCoordinates();
			}
			if (coordinates.Count == 0)
			{
				this.double_0 = 0.0;
				this.coordinate_0 = Coordinate.GetEmpty();
				this.lineSegment_0 = null;
			}
			else if (coordinates.Count == 1)
			{
				this.double_0 = 0.0;
				this.coordinate_0 = coordinates[0];
				this.lineSegment_0.SetP0(coordinates[0]);
				this.lineSegment_0.SetP1(coordinates[0]);
			}
			else if (coordinates.Count != 2 && coordinates.Count != 3)
			{
				this.method_2(coordinates);
			}
			else
			{
				this.double_0 = 0.0;
				this.coordinate_0 = coordinates[0];
				this.lineSegment_0.SetP0(coordinates[0]);
				this.lineSegment_0.SetP1(coordinates[1]);
			}
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000F3D24 File Offset: 0x000F1F24
		private void method_2(IList<Coordinate> ilist_0)
		{
			this.double_0 = 1.7976931348623157E+308;
			int int_ = 1;
			LineSegment lineSegment = new LineSegment();
			for (int i = 0; i < ilist_0.Count - 1; i++)
			{
				lineSegment.SetP0(ilist_0[i]);
				lineSegment.SetP1(ilist_0[i + 1]);
				int_ = this.method_3(ilist_0, lineSegment, int_);
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000F3D84 File Offset: 0x000F1F84
		private int method_3(IList<Coordinate> ilist_0, Interface40 interface40_0, int int_1)
		{
			double num = interface40_0.DistancePerpendicular(ilist_0[int_1]);
			double num2 = num;
			int num3 = int_1;
			int num4 = num3;
			while (num2 >= num)
			{
				num = num2;
				num3 = num4;
				num4 = Class2245.smethod_0(ilist_0, num3);
				num2 = interface40_0.DistancePerpendicular(ilist_0[num4]);
			}
			if (num < this.double_0)
			{
				this.int_0 = num3;
				this.double_0 = num;
				this.coordinate_0 = ilist_0[this.int_0];
				this.lineSegment_0 = new LineSegment(interface40_0);
			}
			return num3;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000F3E0C File Offset: 0x000F200C
		private static int smethod_0(ICollection<Coordinate> icollection_0, int int_1)
		{
			int_1++;
			if (int_1 >= icollection_0.Count)
			{
				int_1 = 0;
			}
			return int_1;
		}

		// Token: 0x0400135E RID: 4958
		private readonly IGeometry igeometry_0;

		// Token: 0x0400135F RID: 4959
		private readonly bool bool_0;

		// Token: 0x04001360 RID: 4960
		private LineSegment lineSegment_0 = new LineSegment();

		// Token: 0x04001361 RID: 4961
		private int int_0;

		// Token: 0x04001362 RID: 4962
		private double double_0;

		// Token: 0x04001363 RID: 4963
		private Coordinate coordinate_0 = new Coordinate(0.0, 0.0, 0.0, 0.0);
	}
}
