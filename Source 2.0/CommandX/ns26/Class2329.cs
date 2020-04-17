using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns24;
using ns25;
using ns28;

namespace ns26
{
	// Token: 0x020007B1 RID: 1969
	public sealed class Class2329
	{
		// Token: 0x060030B9 RID: 12473 RVA: 0x0001A238 File Offset: 0x00018438
		public Class2329(GeometryGraph class2209_1)
		{
			this.class2209_0 = class2209_1;
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0010AD58 File Offset: 0x00108F58
		public Coordinate method_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0010AD70 File Offset: 0x00108F70
		private static Coordinate smethod_0(IEnumerable<Coordinate> ienumerable_0, Coordinate coordinate_1)
		{
			Coordinate result;
			foreach (Coordinate current in ienumerable_0)
			{
				if (!current.Equals(coordinate_1))
				{
					result = current;
					return result;
				}
			}
			result = null;
			return result;
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0010ADC8 File Offset: 0x00108FC8
		public bool method_1()
		{
			IList ilist_ = new ArrayList();
			this.class2209_0.vmethod_14(ilist_);
			Class2208 @class = new Class2208(new Class2219());
			@class.vmethod_1(ilist_);
			Class2329.smethod_1(@class);
			@class.vmethod_7();
			IList ilist_2 = this.method_2(@class.vmethod_8());
			Class2329.smethod_2(this.class2209_0.GetGeometry(), @class);
			return !this.method_3(ilist_2);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0010AE30 File Offset: 0x00109030
		private static void smethod_1(Class2208 class2208_0)
		{
			foreach (Class2193 @class in class2208_0.vmethod_8())
			{
				if (@class.vmethod_1().vmethod_1(0, Enum158.const_2) == LocationType.Interior)
				{
					@class.vmethod_19(true);
				}
			}
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x0010AEA4 File Offset: 0x001090A4
		private IList method_2(IList ilist_0)
		{
			IList list = new ArrayList();
			foreach (Class2193 @class in ilist_0)
			{
				if (@class.vmethod_18() && @class.vmethod_15() == null)
				{
					Class2206 class2 = new Class2206(@class, this.geometryFactory_0);
					class2.vmethod_14();
					IList list2 = class2.vmethod_15();
					foreach (object current in list2)
					{
						list.Add(current);
					}
				}
			}
			return list;
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0010AF8C File Offset: 0x0010918C
		private static void smethod_2(IGeometry igeometry_0, Class2208 class2208_0)
		{
			if (igeometry_0 is Polygon)
			{
				Polygon polygon = (Polygon)igeometry_0;
				Class2329.smethod_3(polygon.GetShell(), class2208_0);
			}
			if (igeometry_0 is MultiPolygon)
			{
				MultiPolygon multiPolygon = (MultiPolygon)igeometry_0;
				IGeometry[] geometries = multiPolygon.GetGeometries();
				for (int i = 0; i < geometries.Length; i++)
				{
					Polygon polygon2 = (Polygon)geometries[i];
					Class2329.smethod_3(polygon2.GetShell(), class2208_0);
				}
			}
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x0010B000 File Offset: 0x00109200
		private static void smethod_3(IBasicGeometry interface30_0, Class2208 class2208_0)
		{
			IList<Coordinate> coordinates = interface30_0.GetCoordinates();
			Coordinate coordinate_ = coordinates[0];
			Coordinate coordinate_2 = Class2329.smethod_0(coordinates, coordinate_);
			Class2199 class2199_ = class2208_0.vmethod_3(coordinate_, coordinate_2);
			Class2193 @class = (Class2193)class2208_0.vmethod_2(class2199_);
			Class2193 class2 = null;
			if (@class.vmethod_1().vmethod_1(0, Enum158.const_2) == LocationType.Interior)
			{
				class2 = @class;
			}
			else if (@class.vmethod_29().vmethod_1().vmethod_1(0, Enum158.const_2) == LocationType.Interior)
			{
				class2 = @class.vmethod_29();
			}
			Class2347.smethod_1(class2 != null, "unable to find dirEdge with Interior on RHS");
			Class2329.smethod_4(class2);
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0010B098 File Offset: 0x00109298
		private static void smethod_4(Class2193 class2193_0)
		{
			Class2193 @class = class2193_0;
			while (@class != null)
			{
				@class.vmethod_22(true);
				@class = @class.vmethod_25();
				if (@class == class2193_0)
				{
					return;
				}
			}
			throw new Exception25();
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0010B0D0 File Offset: 0x001092D0
		private bool method_3(IList ilist_0)
		{
			bool result;
			for (int i = 0; i < ilist_0.Count; i++)
			{
				Class2205 @class = (Class2205)ilist_0[i];
				if (!@class.vmethod_0())
				{
					IList list = @class.vmethod_4();
					Class2193 class2 = (Class2193)list[0];
					if (class2.vmethod_1().vmethod_1(0, Enum158.const_2) == LocationType.Interior)
					{
						for (int j = 0; j < list.Count; j++)
						{
							class2 = (Class2193)list[j];
							if (!class2.vmethod_21())
							{
								this.coordinate_0 = class2.vmethod_3();
								result = true;
								return result;
							}
						}
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x040016A9 RID: 5801
		private readonly GeometryGraph class2209_0;

		// Token: 0x040016AA RID: 5802
		private readonly GeometryFactory geometryFactory_0 = new GeometryFactory();

		// Token: 0x040016AB RID: 5803
		private Coordinate coordinate_0;
	}
}
