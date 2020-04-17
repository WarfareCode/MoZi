using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns26
{
	// Token: 0x020007CD RID: 1997
	public sealed class IsValidOp
	{
		// Token: 0x06003174 RID: 12660 RVA: 0x0001A9AB File Offset: 0x00018BAB
		public IsValidOp(Geometry geometry_1)
		{
			this._parentGeometry = geometry_1;
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0001A9BA File Offset: 0x00018BBA
		public bool method_0()
		{
			return this._isSelfTouchingRingFormingHoleValid;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0001A9C2 File Offset: 0x00018BC2
		public  bool IsValid()
		{
			this.method_1(this._parentGeometry);
			return this._validErr == null;
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0001A9D9 File Offset: 0x00018BD9
		public static bool IsValidCoordinate(Coordinate coord)
		{
			return !double.IsNaN(coord.X) && !double.IsInfinity(coord.X) && !double.IsNaN(coord.Y) && !double.IsInfinity(coord.Y);
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x0010C020 File Offset: 0x0010A220
		public static Coordinate FindPointNotNode(IList<Coordinate> testCoords, ILinearRing ilinearRing_0, GeometryGraph class2209_0)
		{
			Class2199 @class = class2209_0.vmethod_13(ilinearRing_0);
			Class2203 class2 = @class.vmethod_12();
			Coordinate result;
			foreach (Coordinate current in testCoords)
			{
				if (!class2.vmethod_2(current))
				{
					result = current;
					return result;
				}
			}
			result = null;
			return result;
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x0010C088 File Offset: 0x0010A288
		private void method_1(IGeometry igeometry_0)
		{
			this._validErr = null;
			if (!igeometry_0.IsEmpty())
			{
				this.method_2(igeometry_0);
				if (igeometry_0 is ILineString)
				{
					this.method_3(igeometry_0);
				}
				ILinearRing linearRing = igeometry_0 as ILinearRing;
				if (linearRing != null)
				{
					this.method_4(linearRing);
				}
				IPolygon polygon = igeometry_0 as IPolygon;
				if (polygon != null)
				{
					this.method_5(polygon);
				}
				IMultiPolygon multiPolygon = igeometry_0 as IMultiPolygon;
				if (multiPolygon != null)
				{
					this.method_6(multiPolygon);
				}
				else
				{
					IGeometryCollection geometryCollection = igeometry_0 as IGeometryCollection;
					if (geometryCollection != null)
					{
						this.method_7(geometryCollection);
					}
				}
			}
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x0001AA13 File Offset: 0x00018C13
		private void method_2(IBasicGeometry interface30_0)
		{
			this.method_8(interface30_0.GetCoordinates());
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x0010C118 File Offset: 0x0010A318
		private void method_3(IGeometry igeometry_0)
		{
			GeometryGraph class2209_ = new GeometryGraph(0, igeometry_0);
			this.method_12(class2209_);
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x0010C134 File Offset: 0x0010A334
		private void method_4(ILinearRing ilinearRing_0)
		{
			this.method_11(ilinearRing_0);
			if (this._validErr == null)
			{
				GeometryGraph geometryGraph = new GeometryGraph(0, ilinearRing_0);
				LineIntersector class2239_ = new RobustLineIntersector();
				geometryGraph.vmethod_16(class2239_, true);
				this.method_14(geometryGraph);
			}
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x0010C174 File Offset: 0x0010A374
		private void method_5(IPolygon ipolygon_0)
		{
			this.method_10(ipolygon_0);
			if (this._validErr == null)
			{
				GeometryGraph class2209_ = new GeometryGraph(0, ipolygon_0);
				this.method_13(class2209_);
				if (this._validErr == null)
				{
					if (!this.method_0())
					{
						this.method_14(class2209_);
						if (this._validErr != null)
						{
							return;
						}
					}
					this.method_16(ipolygon_0, class2209_);
					if (this._validErr == null)
					{
						this.method_17(ipolygon_0, class2209_);
						if (this._validErr == null)
						{
							this.method_20(class2209_);
						}
					}
				}
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x0010C1F4 File Offset: 0x0010A3F4
		private void method_6(IMultiPolygon imultiPolygon_0)
		{
			IGeometry[] geometries = imultiPolygon_0.GetGeometries();
			int i = 0;
			while (i < geometries.Length)
			{
				Polygon ipolygon_ = (Polygon)geometries[i];
				this.method_9(ipolygon_);
				if (this._validErr == null)
				{
					this.method_10(ipolygon_);
					if (this._validErr == null)
					{
						i++;
						continue;
					}
				}
				return;
			}
			GeometryGraph class2209_ = new GeometryGraph(0, imultiPolygon_0);
			this.method_12(class2209_);
			if (this._validErr != null)
			{
				return;
			}
			this.method_13(class2209_);
			if (this._validErr != null)
			{
				return;
			}
			if (!this.method_0())
			{
				this.method_14(class2209_);
				if (this._validErr != null)
				{
					return;
				}
			}
			IGeometry[] geometries2 = imultiPolygon_0.GetGeometries();
			for (int j = 0; j < geometries2.Length; j++)
			{
				Polygon ipolygon_2 = (Polygon)geometries2[j];
				this.method_16(ipolygon_2, class2209_);
				if (this._validErr != null)
				{
					return;
				}
			}
			IGeometry[] geometries3 = imultiPolygon_0.GetGeometries();
			for (int k = 0; k < geometries3.Length; k++)
			{
				Polygon ipolygon_3 = (Polygon)geometries3[k];
				this.method_17(ipolygon_3, class2209_);
				if (this._validErr != null)
				{
					return;
				}
			}
			this.method_18(imultiPolygon_0, class2209_);
			if (this._validErr == null)
			{
				this.method_20(class2209_);
				return;
			}
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x0010C334 File Offset: 0x0010A534
		private void method_7(IGeometryCollection igeometryCollection_0)
		{
			IGeometry[] geometries = igeometryCollection_0.GetGeometries();
			for (int i = 0; i < geometries.Length; i++)
			{
				Geometry igeometry_ = (Geometry)geometries[i];
				this.method_1(igeometry_);
				if (this._validErr != null)
				{
					break;
				}
			}
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0010C374 File Offset: 0x0010A574
		private void method_8(IEnumerable<Coordinate> ienumerable_0)
		{
			foreach (Coordinate current in ienumerable_0)
			{
				if (!IsValidOp.IsValidCoordinate(current))
				{
					this._validErr = new TopologyValidationError(TopologyValidationErrorType.InvalidCoordinate, current);
					break;
				}
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0010C3D4 File Offset: 0x0010A5D4
		private void method_9(IPolygon ipolygon_0)
		{
			this.method_8(ipolygon_0.GetShell().GetCoordinates());
			if (this._validErr == null)
			{
				ILinearRing[] holes = ipolygon_0.GetHoles();
				for (int i = 0; i < holes.Length; i++)
				{
					LineString lineString = (LineString)holes[i];
					this.method_8(lineString.GetCoordinates());
					if (this._validErr != null)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0010C434 File Offset: 0x0010A634
		private void method_10(IPolygon ipolygon_0)
		{
			this.method_11(ipolygon_0.GetShell());
			if (this._validErr == null)
			{
				ILinearRing[] holes = ipolygon_0.GetHoles();
				for (int i = 0; i < holes.Length; i++)
				{
					LineString lineString = (LineString)holes[i];
					this.method_11((LinearRing)lineString);
					if (this._validErr != null)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x0001AA21 File Offset: 0x00018C21
		private void method_11(ILinearRing ilinearRing_0)
		{
			if (!ilinearRing_0.imethod_19())
			{
				this._validErr = new TopologyValidationError(TopologyValidationErrorType.RingNotClosed, ilinearRing_0.GetCoordinates()[0]);
			}
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x0001AA44 File Offset: 0x00018C44
		private void method_12(GeometryGraph class2209_0)
		{
			if (class2209_0.HasTooFewPoints())
			{
				this._validErr = new TopologyValidationError(TopologyValidationErrorType.TooFewPoints, class2209_0.GetInvalidPoint());
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x0010C490 File Offset: 0x0010A690
		private void method_13(GeometryGraph class2209_0)
		{
			Class2330 @class = new Class2330(class2209_0);
			if (!@class.vmethod_1())
			{
				this._validErr = new TopologyValidationError(TopologyValidationErrorType.SelfIntersection, @class.vmethod_0());
			}
			else if (@class.vmethod_2())
			{
				this._validErr = new TopologyValidationError(TopologyValidationErrorType.DuplicateRings, @class.vmethod_0());
			}
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x0010C4E0 File Offset: 0x0010A6E0
		private void method_14(GeometryGraph class2209_0)
		{
			IEnumerator enumerator = class2209_0.vmethod_5();
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				this.method_15(@class.vmethod_12());
				if (this._validErr != null)
				{
					break;
				}
			}
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x0010C524 File Offset: 0x0010A724
		private void method_15(Class2203 class2203_0)
		{
			HashSet<Coordinate> hashSet = new HashSet<Coordinate>();
			bool flag = true;
            IEnumerator enumerator = class2203_0.vmethod_1();
			{
				while (enumerator.MoveNext())
				{
					Class2202 @class = (Class2202)enumerator.Current;
					if (flag)
					{
						flag = false;
					}
					else
					{
						if (hashSet.Contains(@class.vmethod_0()))
						{
							this._validErr = new TopologyValidationError(TopologyValidationErrorType.RingSelfIntersection, @class.vmethod_0());
							break;
						}
						hashSet.Add(@class.vmethod_0());
					}
				}
			}
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x0010C5BC File Offset: 0x0010A7BC
		private void method_16(IPolygon ipolygon_0, GeometryGraph class2209_0)
		{
			ILinearRing shell = ipolygon_0.GetShell();
			Interface42 @interface = new Class2241(shell);
			int i = 0;
			while (i < ipolygon_0.GetNumHoles())
			{
				LinearRing linearRing = (LinearRing)ipolygon_0.GetInteriorRingN(i);
				Coordinate coordinate = IsValidOp.FindPointNotNode(linearRing.GetCoordinates(), shell, class2209_0);
				if (!Coordinate.Equals(coordinate, null))
				{
					if (@interface.imethod_0(coordinate))
					{
						i++;
						continue;
					}
					this._validErr = new TopologyValidationError(TopologyValidationErrorType.HoleOutsideShell, coordinate);
				}
				return;
			}
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x0010C630 File Offset: 0x0010A830
		private void method_17(IPolygon ipolygon_0, GeometryGraph class2209_0)
		{
			Class2332 @class = new Class2332(class2209_0);
			ILinearRing[] holes = ipolygon_0.GetHoles();
			for (int i = 0; i < holes.Length; i++)
			{
				LinearRing linearRing_ = (LinearRing)holes[i];
				@class.vmethod_1(linearRing_);
			}
			if (!@class.vmethod_2())
			{
				this._validErr = new TopologyValidationError(TopologyValidationErrorType.NestedHoles, @class.vmethod_0());
			}
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x0010C688 File Offset: 0x0010A888
		private void method_18(IGeometry igeometry_0, GeometryGraph class2209_0)
		{
			for (int i = 0; i < igeometry_0.GetNumGeometries(); i++)
			{
				Polygon polygon = (Polygon)igeometry_0.GetGeometryN(i);
				LinearRing linearRing_ = (LinearRing)polygon.vmethod_6();
				for (int j = 0; j < igeometry_0.GetNumGeometries(); j++)
				{
					if (i != j)
					{
						Polygon polygon_ = (Polygon)igeometry_0.GetGeometryN(j);
						this.method_19(linearRing_, polygon_, class2209_0);
						if (this._validErr != null)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x0010C700 File Offset: 0x0010A900
		private void method_19(LinearRing linearRing_0, Polygon polygon_0, GeometryGraph class2209_0)
		{
			IList<Coordinate> coordinates = linearRing_0.GetCoordinates();
			LinearRing linearRing = (LinearRing)polygon_0.vmethod_6();
			IList<Coordinate> coordinates2 = linearRing.GetCoordinates();
			Coordinate coordinate = IsValidOp.FindPointNotNode(coordinates, linearRing, class2209_0);
			if (!Coordinate.Equals(coordinate, null) && CgAlgorithms.IsPointInRing(coordinate, coordinates2))
			{
				if (polygon_0.GetNumHoles() <= 0)
				{
					this._validErr = new TopologyValidationError(TopologyValidationErrorType.NestedShells, coordinate);
				}
				else
				{
					Coordinate coordinate2 = null;
					for (int i = 0; i < polygon_0.GetNumHoles(); i++)
					{
						LinearRing linearRing_ = (LinearRing)polygon_0.GetInteriorRingN(i);
						coordinate2 = IsValidOp.smethod_2(linearRing_0, linearRing_, class2209_0);
						if (Coordinate.Equals(coordinate2, null))
						{
							return;
						}
					}
					this._validErr = new TopologyValidationError(TopologyValidationErrorType.NestedShells, coordinate2);
				}
			}
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0010C7B0 File Offset: 0x0010A9B0
		private static Coordinate smethod_2(LinearRing linearRing_0, LinearRing linearRing_1, GeometryGraph class2209_0)
		{
			IList<Coordinate> coordinates = linearRing_0.GetCoordinates();
			IList<Coordinate> coordinates2 = linearRing_1.GetCoordinates();
			Coordinate coordinate = IsValidOp.FindPointNotNode(coordinates, linearRing_1, class2209_0);
			Coordinate result;
			if (Coordinate.NotEquals(coordinate, null) && !CgAlgorithms.IsPointInRing(coordinate, coordinates2))
			{
				result = coordinate;
			}
			else
			{
				Coordinate coordinate2 = IsValidOp.FindPointNotNode(coordinates2, linearRing_0, class2209_0);
				if (!Coordinate.NotEquals(coordinate2, null))
				{
					throw new Exception26();
				}
				if (!CgAlgorithms.IsPointInRing(coordinate2, coordinates))
				{
					result = null;
				}
				else
				{
					result = coordinate2;
				}
			}
			return result;
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0010C81C File Offset: 0x0010AA1C
		private void method_20(GeometryGraph class2209_0)
		{
			Class2329 @class = new Class2329(class2209_0);
			if (!@class.method_1())
			{
				this._validErr = new TopologyValidationError(TopologyValidationErrorType.DisconnectedInteriors, @class.method_0());
			}
		}

		// Token: 0x040016F4 RID: 5876
		private readonly Geometry _parentGeometry;

		// Token: 0x040016F5 RID: 5877
		private bool _isSelfTouchingRingFormingHoleValid;

		// Token: 0x040016F6 RID: 5878
		private TopologyValidationError _validErr;
	}
}
