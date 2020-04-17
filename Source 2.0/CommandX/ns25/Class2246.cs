using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns24;

namespace ns25
{
	// Token: 0x0200063D RID: 1597
	public sealed class Class2246
	{
		// Token: 0x06002882 RID: 10370 RVA: 0x000F3E30 File Offset: 0x000F2030
		public  LocationType vmethod_0(Coordinate coordinate_0, IGeometry igeometry_0)
		{
			LocationType result;
			if (igeometry_0.IsEmpty())
			{
				result = LocationType.Exterior;
			}
			else if (igeometry_0 is ILineString)
			{
				result = Class2246.smethod_0(coordinate_0, (ILineString)igeometry_0);
			}
			else if (igeometry_0 is IPolygon)
			{
				result = Class2246.smethod_2(coordinate_0, (IPolygon)igeometry_0);
			}
			else
			{
				this.bool_0 = false;
				this.int_0 = 0;
				this.method_0(coordinate_0, igeometry_0);
				if (GeometryGraph.IsInBoundary(this.int_0))
				{
					result = LocationType.Boundary;
				}
				else if (this.int_0 <= 0 && !this.bool_0)
				{
					result = LocationType.Exterior;
				}
				else
				{
					result = LocationType.Interior;
				}
			}
			return result;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000F3ECC File Offset: 0x000F20CC
		private void method_0(Coordinate coordinate_0, IGeometry igeometry_0)
		{
			if (igeometry_0 is ILineString)
			{
				this.method_1(this.vmethod_0(coordinate_0, igeometry_0));
			}
			else if (igeometry_0 is IPolygon)
			{
				this.method_1(this.vmethod_0(coordinate_0, igeometry_0));
			}
			else if (igeometry_0 is IMultiLineString)
			{
				IMultiLineString multiLineString = (IMultiLineString)igeometry_0;
				IGeometry[] geometries = multiLineString.GetGeometries();
				for (int i = 0; i < geometries.Length; i++)
				{
					ILineString igeometry_ = (ILineString)geometries[i];
					this.method_1(this.vmethod_0(coordinate_0, igeometry_));
				}
			}
			else if (igeometry_0 is IMultiPolygon)
			{
				IMultiPolygon multiPolygon = (IMultiPolygon)igeometry_0;
				IGeometry[] geometries2 = multiPolygon.GetGeometries();
				for (int j = 0; j < geometries2.Length; j++)
				{
					IPolygon igeometry_2 = (IPolygon)geometries2[j];
					this.method_1(this.vmethod_0(coordinate_0, igeometry_2));
				}
			}
			else if (igeometry_0 is IGeometryCollection)
			{
				IEnumerator enumerator = new GeometryCollection.Enumerator((IGeometryCollection)igeometry_0);
				while (enumerator.MoveNext())
				{
					IGeometry geometry = (IGeometry)enumerator.Current;
					if (geometry != igeometry_0)
					{
						this.method_0(coordinate_0, geometry);
					}
				}
			}
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000166B5 File Offset: 0x000148B5
		private void method_1(LocationType enum157_0)
		{
			if (enum157_0 == LocationType.Interior)
			{
				this.bool_0 = true;
			}
			if (enum157_0 == LocationType.Boundary)
			{
				this.int_0++;
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000F3FF8 File Offset: 0x000F21F8
		private static LocationType smethod_0(Coordinate coordinate_0, ILineString ilineString_0)
		{
			IList<Coordinate> coordinates = ilineString_0.GetCoordinates();
			LocationType result;
			if (!ilineString_0.imethod_19() && (coordinate_0.Equals(coordinates[0]) || coordinate_0.Equals(coordinates[coordinates.Count - 1])))
			{
				result = LocationType.Boundary;
			}
			else if (CgAlgorithms.IsOnLine(coordinate_0, coordinates))
			{
				result = LocationType.Interior;
			}
			else
			{
				result = LocationType.Exterior;
			}
			return result;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000F405C File Offset: 0x000F225C
		private static LocationType smethod_1(Coordinate coordinate_0, IBasicGeometry interface30_0)
		{
			LocationType result;
			if (CgAlgorithms.IsOnLine(coordinate_0, interface30_0.GetCoordinates()))
			{
				result = LocationType.Boundary;
			}
			else if (CgAlgorithms.IsPointInRing(coordinate_0, interface30_0.GetCoordinates()))
			{
				result = LocationType.Interior;
			}
			else
			{
				result = LocationType.Exterior;
			}
			return result;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000F4098 File Offset: 0x000F2298
		private static LocationType smethod_2(Coordinate coordinate_0, IPolygon ipolygon_0)
		{
			LocationType result;
			if (ipolygon_0.IsEmpty())
			{
				result = LocationType.Exterior;
			}
			else
			{
				LinearRing interface30_ = (LinearRing)ipolygon_0.GetShell();
				LocationType locationType = Class2246.smethod_1(coordinate_0, interface30_);
				if (locationType == LocationType.Exterior)
				{
					result = LocationType.Exterior;
				}
				else if (locationType == LocationType.Boundary)
				{
					result = LocationType.Boundary;
				}
				else
				{
					ILinearRing[] holes = ipolygon_0.GetHoles();
					int i = 0;
					while (i < holes.Length)
					{
						LinearRing interface30_2 = (LinearRing)holes[i];
						LocationType locationType2 = Class2246.smethod_1(coordinate_0, interface30_2);
						LocationType locationType3;
						if (locationType2 != LocationType.Interior)
						{
							if (locationType2 != LocationType.Boundary)
							{
								i++;
								continue;
							}
							locationType3 = LocationType.Boundary;
						}
						else
						{
							locationType3 = LocationType.Exterior;
						}
						result = locationType3;
						return result;
					}
					result = LocationType.Interior;
				}
			}
			return result;
		}

		// Token: 0x04001364 RID: 4964
		private bool bool_0;

		// Token: 0x04001365 RID: 4965
		private int int_0;
	}
}
