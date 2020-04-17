using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns25;
using ns28;

namespace ns24
{
	// Token: 0x0200058E RID: 1422
	public sealed class GeometryGraph : Class2208
	{
		// Token: 0x06002487 RID: 9351 RVA: 0x00015009 File Offset: 0x00013209
		public GeometryGraph(int int_1, IGeometry igeometry_1)
		{
			this._argIndex = int_1;
			this._parentGeom = igeometry_1;
			if (igeometry_1 != null)
			{
				this.method_1(igeometry_1);
			}
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00015037 File Offset: 0x00013237
		public  bool HasTooFewPoints()
		{
			return this._hasTooFewPoints;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x000E2574 File Offset: 0x000E0774
		public  Coordinate GetInvalidPoint()
		{
			return this._invalidPoint;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000E258C File Offset: 0x000E078C
		public  IGeometry GetGeometry()
		{
			return this._parentGeom;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00010F26 File Offset: 0x0000F126
		public static bool IsInBoundary(int boundaryCount)
		{
			return boundaryCount % 2 == 1;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000E25A4 File Offset: 0x000E07A4
		public static LocationType DetermineBoundary(int boundaryCount)
		{
			LocationType result;
			if (!GeometryGraph.IsInBoundary(boundaryCount))
			{
				result = LocationType.Interior;
			}
			else
			{
				result = LocationType.Boundary;
			}
			return result;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000E25C0 File Offset: 0x000E07C0
		private static EdgeSetIntersector smethod_4()
		{
			return new Class2211();
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000E25D4 File Offset: 0x000E07D4
		public  Class2199 vmethod_13(ILineString ilineString_0)
		{
			return (Class2199)this._lineEdgeMap[ilineString_0];
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000E25F4 File Offset: 0x000E07F4
		public  void vmethod_14(IList ilist_2)
		{
			IEnumerator enumerator = base.method_0().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				@class.vmethod_12().vmethod_4(ilist_2);
			}
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000E2630 File Offset: 0x000E0830
		private void method_1(IGeometry igeometry_1)
		{
			if (!igeometry_1.IsEmpty())
			{
				if (igeometry_1 is GeometryCollection && !(igeometry_1 is MultiPolygon))
				{
					this._useBoundaryDeterminationRule = true;
				}
				if (igeometry_1 is Polygon)
				{
					this.method_4((Polygon)igeometry_1);
				}
				else if (igeometry_1 is LineString)
				{
					this.method_5(igeometry_1);
				}
				else if (igeometry_1 is Point)
				{
					this.vmethod_15(igeometry_1.GetCoordinate());
				}
				else
				{
					this.method_2(igeometry_1);
				}
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000E26BC File Offset: 0x000E08BC
		private void method_2(IGeometry igeometry_1)
		{
			for (int i = 0; i < igeometry_1.GetNumGeometries(); i++)
			{
				IGeometry geometryN = igeometry_1.GetGeometryN(i);
				this.method_1(geometryN);
			}
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000E26EC File Offset: 0x000E08EC
		private void method_3(IBasicGeometry interface30_0, LocationType enum157_0, LocationType enum157_1)
		{
			IList<Coordinate> list = Class2178.smethod_3(interface30_0.GetCoordinates());
			if (list.Count < 4)
			{
				this._hasTooFewPoints = true;
				this._invalidPoint = list[0];
			}
			else
			{
				LocationType enum157_2 = enum157_0;
				LocationType enum157_3 = enum157_1;
				if (CgAlgorithms.IsCounterClockwise(list))
				{
					enum157_2 = enum157_1;
					enum157_3 = enum157_0;
				}
				Class2199 @class = new Class2199(list, new Class2217(this._argIndex, LocationType.Boundary, enum157_2, enum157_3));
				this._lineEdgeMap.Add(interface30_0, @class);
				this.vmethod_6(@class);
				this.method_6(this._argIndex, list[0], LocationType.Boundary);
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x000E277C File Offset: 0x000E097C
		private void method_4(Polygon polygon_0)
		{
			this.method_3(polygon_0.vmethod_6(), LocationType.Exterior, LocationType.Interior);
			for (int i = 0; i < polygon_0.GetNumHoles(); i++)
			{
				this.method_3(polygon_0.GetInteriorRingN(i), LocationType.Interior, LocationType.Exterior);
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x000E27BC File Offset: 0x000E09BC
		private void method_5(IBasicGeometry interface30_0)
		{
			IList<Coordinate> list = Class2178.smethod_3(interface30_0.GetCoordinates());
			if (list.Count < 2)
			{
				this._hasTooFewPoints = true;
				this._invalidPoint = list[0];
			}
			else
			{
				Class2199 @class = new Class2199(list, new Class2217(this._argIndex, LocationType.Interior));
				this._lineEdgeMap.Add(interface30_0, @class);
				this.vmethod_6(@class);
				Class2347.smethod_1(list.Count >= 2, "found LineString with single point");
				this.method_7(this._argIndex, list[0]);
				this.method_7(this._argIndex, list[list.Count - 1]);
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0001503F File Offset: 0x0001323F
		public  void vmethod_15(Coordinate coordinate_1)
		{
			this.method_6(this._argIndex, coordinate_1, LocationType.Interior);
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000E2864 File Offset: 0x000E0A64
		public  SegmentIntersector vmethod_16(LineIntersector class2239_0, bool bool_2)
		{
			SegmentIntersector segmentIntersector = new SegmentIntersector(class2239_0, true, false);
			EdgeSetIntersector edgeSetIntersector = GeometryGraph.smethod_4();
			if (!bool_2 && (this._parentGeom is ILinearRing || this._parentGeom is IPolygon || this._parentGeom is IMultiPolygon))
			{
				edgeSetIntersector.ComputeIntersections(base.method_0(), segmentIntersector, false);
			}
			else
			{
				edgeSetIntersector.ComputeIntersections(base.method_0(), segmentIntersector, true);
			}
			this.method_8(this._argIndex);
			return segmentIntersector;
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000E28E4 File Offset: 0x000E0AE4
		private void method_6(int int_1, Coordinate coordinate_1, LocationType enum157_0)
		{
			Class2200 @class = this.Nodes.vmethod_0(coordinate_1);
			Class2217 class2 = @class.vmethod_0();
			if (class2 == null)
			{
				@class.vmethod_1(new Class2217(int_1, enum157_0));
			}
			else
			{
				class2.vmethod_4(int_1, enum157_0);
			}
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x000E2928 File Offset: 0x000E0B28
		private void method_7(int int_1, Coordinate coordinate_1)
		{
			Class2200 @class = this.Nodes.vmethod_0(coordinate_1);
			Class2217 class2 = @class.vmethod_0();
			int num = 1;
			LocationType locationType = LocationType.Null;
			if (class2 != null)
			{
				locationType = class2.vmethod_1(int_1, Enum158.const_0);
			}
			if (locationType == LocationType.Boundary)
			{
				num++;
			}
			LocationType enum157_ = GeometryGraph.DetermineBoundary(num);
			if (class2 != null)
			{
				class2.vmethod_4(int_1, enum157_);
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x000E2980 File Offset: 0x000E0B80
		private void method_8(int int_1)
		{
			IEnumerator enumerator = base.method_0().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				LocationType enum157_ = @class.vmethod_0().vmethod_2(int_1);
				IEnumerator enumerator2 = @class.vmethod_12().vmethod_1();
				while (enumerator2.MoveNext())
				{
					Class2202 class2 = (Class2202)enumerator2.Current;
					this.method_9(int_1, class2.vmethod_0(), enum157_);
				}
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0001504F File Offset: 0x0001324F
		private void method_9(int int_1, Coordinate coordinate_1, LocationType enum157_0)
		{
			if (!this.vmethod_9(int_1, coordinate_1))
			{
				if (enum157_0 == LocationType.Boundary && this._useBoundaryDeterminationRule)
				{
					this.method_7(int_1, coordinate_1);
				}
				else
				{
					this.method_6(int_1, coordinate_1, enum157_0);
				}
			}
		}

		// Token: 0x04001195 RID: 4501
		private readonly int _argIndex;

		// Token: 0x04001196 RID: 4502
		private readonly IDictionary _lineEdgeMap = new Hashtable();

		// Token: 0x04001197 RID: 4503
		private readonly IGeometry _parentGeom;

		// Token: 0x04001198 RID: 4504
		private bool _hasTooFewPoints;

		// Token: 0x04001199 RID: 4505
		private Coordinate _invalidPoint;

		// Token: 0x0400119A RID: 4506
		private bool _useBoundaryDeterminationRule;
	}
}
