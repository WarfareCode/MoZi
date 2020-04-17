using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns24;
using ns25;

namespace ns27
{
	// Token: 0x0200074B RID: 1867
	public sealed class Class2311
	{
		// Token: 0x06002E57 RID: 11863 RVA: 0x0001939D File Offset: 0x0001759D
		private Class2311(IGeometry igeometry_1, IGeometry igeometry_2) : this(igeometry_1, igeometry_2, 0.0)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00105B38 File Offset: 0x00103D38
		public Class2311(IGeometry igeometry_1, IGeometry igeometry_2, double double_2)
		{
			this.igeometry_0 = new Geometry[2];
			this.igeometry_0[0] = igeometry_1;
			this.igeometry_0[1] = igeometry_2;
			this.double_0 = double_2;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00105B8C File Offset: 0x00103D8C
		public static Coordinate[] smethod_0(IGeometry igeometry_1, IGeometry igeometry_2)
		{
			Class2311 @class = new Class2311(igeometry_1, igeometry_2);
			return @class.vmethod_0();
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00105BAC File Offset: 0x00103DAC
		public  Coordinate[] vmethod_0()
		{
			this.method_1();
			return new Coordinate[]
			{
				this.class2312_0[0].vmethod_0(),
				this.class2312_0[1].vmethod_0()
			};
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00105BEC File Offset: 0x00103DEC
		private void method_0(Class2312[] class2312_1, bool bool_0)
		{
			if (class2312_1[0] != null)
			{
				if (bool_0)
				{
					this.class2312_0[0] = class2312_1[1];
					this.class2312_0[1] = class2312_1[0];
				}
				else
				{
					this.class2312_0[0] = class2312_1[0];
					this.class2312_0[1] = class2312_1[1];
				}
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000193B0 File Offset: 0x000175B0
		private void method_1()
		{
			if (this.class2312_0 == null)
			{
				this.class2312_0 = new Class2312[2];
				this.method_2();
				if (this.double_1 > this.double_0)
				{
					this.method_5();
				}
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00105C38 File Offset: 0x00103E38
		private void method_2()
		{
			IList list = Class2232.smethod_0(this.igeometry_0[0]);
			IList list2 = Class2232.smethod_0(this.igeometry_0[1]);
			Class2312[] array = new Class2312[2];
			if (list2.Count > 0)
			{
				IList ilist_ = Class2309.smethod_0(this.igeometry_0[0]);
				this.method_3(ilist_, list2, array);
				if (this.double_1 <= this.double_0)
				{
					this.class2312_0[0] = array[0];
					this.class2312_0[1] = array[1];
					return;
				}
			}
			if (list.Count > 0)
			{
				IList ilist_2 = Class2309.smethod_0(this.igeometry_0[1]);
				this.method_3(ilist_2, list, array);
				if (this.double_1 <= this.double_0)
				{
					this.class2312_0[0] = array[1];
					this.class2312_0[1] = array[0];
				}
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00105D04 File Offset: 0x00103F04
		private void method_3(IList ilist_0, IList ilist_1, Class2312[] class2312_1)
		{
			for (int i = 0; i < ilist_0.Count; i++)
			{
				Class2312 class2312_2 = (Class2312)ilist_0[i];
				for (int j = 0; j < ilist_1.Count; j++)
				{
					Polygon igeometry_ = (Polygon)ilist_1[j];
					this.method_4(class2312_2, igeometry_, class2312_1);
					if (this.double_1 <= this.double_0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00105D6C File Offset: 0x00103F6C
		private void method_4(Class2312 class2312_1, IGeometry igeometry_1, Class2312[] class2312_2)
		{
			Coordinate coordinate = class2312_1.vmethod_0();
			if (LocationType.Exterior != this.class2246_0.vmethod_0(coordinate, igeometry_1))
			{
				this.double_1 = 0.0;
				class2312_2[0] = class2312_1;
				Class2312 @class = new Class2312(igeometry_1, coordinate);
				class2312_2[1] = @class;
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00105DB4 File Offset: 0x00103FB4
		private void method_5()
		{
			Class2312[] array = new Class2312[2];
			IList ilist_ = Class2230.smethod_0(this.igeometry_0[0]);
			IList list = Class2230.smethod_0(this.igeometry_0[1]);
			IList list2 = Class2231.smethod_0(this.igeometry_0[0]);
			IList ilist_2 = Class2231.smethod_0(this.igeometry_0[1]);
			this.method_6(ilist_, list, array);
			this.method_0(array, false);
			if (this.double_1 > this.double_0)
			{
				array[0] = null;
				array[1] = null;
				this.method_8(ilist_, ilist_2, array);
				this.method_0(array, false);
				if (this.double_1 > this.double_0)
				{
					array[0] = null;
					array[1] = null;
					this.method_8(list, list2, array);
					this.method_0(array, true);
					if (this.double_1 > this.double_0)
					{
						array[0] = null;
						array[1] = null;
						this.method_7(list2, ilist_2, array);
						this.method_0(array, false);
					}
				}
			}
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00105E90 File Offset: 0x00104090
		private void method_6(IList ilist_0, IList ilist_1, Class2312[] class2312_1)
		{
			for (int i = 0; i < ilist_0.Count; i++)
			{
				LineString ilineString_ = (LineString)ilist_0[i];
				for (int j = 0; j < ilist_1.Count; j++)
				{
					LineString ilineString_2 = (LineString)ilist_1[j];
					this.method_9(ilineString_, ilineString_2, class2312_1);
					if (this.double_1 <= this.double_0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00105EF8 File Offset: 0x001040F8
		private void method_7(IList ilist_0, IList ilist_1, Class2312[] class2312_1)
		{
			for (int i = 0; i < ilist_0.Count; i++)
			{
				Point point = (Point)ilist_0[i];
				for (int j = 0; j < ilist_1.Count; j++)
				{
					Point point2 = (Point)ilist_1[j];
					double num = point.GetCoordinate().Distance(point2.GetCoordinate());
					if (num < this.double_1)
					{
						this.double_1 = num;
						class2312_1[0] = new Class2312(point, 0, point.GetCoordinate());
						class2312_1[1] = new Class2312(point2, 0, point2.GetCoordinate());
					}
					if (this.double_1 <= this.double_0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00105FA8 File Offset: 0x001041A8
		private void method_8(IList ilist_0, IList ilist_1, Class2312[] class2312_1)
		{
			for (int i = 0; i < ilist_0.Count; i++)
			{
				LineString ilineString_ = (LineString)ilist_0[i];
				for (int j = 0; j < ilist_1.Count; j++)
				{
					Point point_ = (Point)ilist_1[j];
					this.method_10(ilineString_, point_, class2312_1);
					if (this.double_1 <= this.double_0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00106010 File Offset: 0x00104210
		private void method_9(ILineString ilineString_0, ILineString ilineString_1, Class2312[] class2312_1)
		{
			if (Class2183.smethod_10(ilineString_0.GetEnvelopeInternal(), ilineString_1.GetEnvelopeInternal()) <= this.double_1)
			{
				IList<Coordinate> coordinates = ilineString_0.GetCoordinates();
				IList<Coordinate> coordinates2 = ilineString_1.GetCoordinates();
				for (int i = 0; i < coordinates.Count - 1; i++)
				{
					for (int j = 0; j < coordinates2.Count - 1; j++)
					{
						double num = CgAlgorithms.DistanceLineLine(coordinates[i], coordinates[i + 1], coordinates2[j], coordinates2[j + 1]);
						if (num < this.double_1)
						{
							this.double_1 = num;
							LineSegment lineSegment = new LineSegment(coordinates[i], coordinates[i + 1]);
							LineSegment line = new LineSegment(coordinates2[j], coordinates2[j + 1]);
							Coordinate[] array = lineSegment.ClosestPoints(line);
							class2312_1[0] = new Class2312(ilineString_0, i, new Coordinate(array[0]));
							class2312_1[1] = new Class2312(ilineString_1, j, new Coordinate(array[1]));
						}
						if (this.double_1 <= this.double_0)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00106130 File Offset: 0x00104330
		private void method_10(ILineString ilineString_0, Point point_0, Class2312[] class2312_1)
		{
			if (Class2183.smethod_10(ilineString_0.GetEnvelopeInternal(), point_0.GetEnvelopeInternal()) <= this.double_1)
			{
				IList<Coordinate> coordinates = ilineString_0.GetCoordinates();
				Coordinate coordinate = point_0.GetCoordinate();
				for (int i = 0; i < coordinates.Count - 1; i++)
				{
					double num = CgAlgorithms.DistancePointLine(coordinate, coordinates[i], coordinates[i + 1]);
					if (num < this.double_1)
					{
						this.double_1 = num;
						LineSegment lineSegment = new LineSegment(coordinates[i], coordinates[i + 1]);
						Coordinate coordinate_ = new Coordinate(lineSegment.ClosestPoint(coordinate));
						class2312_1[0] = new Class2312(ilineString_0, i, coordinate_);
						class2312_1[1] = new Class2312(point_0, 0, coordinate);
					}
					if (this.double_1 <= this.double_0)
					{
						break;
					}
				}
			}
		}

		// Token: 0x04001596 RID: 5526
		private readonly IGeometry[] igeometry_0;

		// Token: 0x04001597 RID: 5527
		private readonly Class2246 class2246_0 = new Class2246();

		// Token: 0x04001598 RID: 5528
		private readonly double double_0;

		// Token: 0x04001599 RID: 5529
		private double double_1 = 1.7976931348623157E+308;

		// Token: 0x0400159A RID: 5530
		private Class2312[] class2312_0;
	}
}
