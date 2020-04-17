using System;
using System.Collections.Generic;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns14;

namespace ns12
{
	// Token: 0x020003C3 RID: 963
	public abstract class Class612
	{
		// Token: 0x060017CD RID: 6093
		public abstract IGeometry vmethod_0(Class661 class661_0, IGeometryFactory igeometryFactory_0);

		// Token: 0x060017CE RID: 6094 RVA: 0x0000FE7A File Offset: 0x0000E07A
		protected bool method_0()
		{
			return Class612.smethod_0(this.shapeGeometryType_0);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0000FE87 File Offset: 0x0000E087
		public static bool smethod_0(ShapeGeometryType shapeGeometryType_1)
		{
			return shapeGeometryType_1 == ShapeGeometryType.PointZ || shapeGeometryType_1 == ShapeGeometryType.PointZM || shapeGeometryType_1 == ShapeGeometryType.LineStringZ || shapeGeometryType_1 == ShapeGeometryType.LineStringZM || shapeGeometryType_1 == ShapeGeometryType.PolygonZ || shapeGeometryType_1 == ShapeGeometryType.PolygonZM;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0000FEAA File Offset: 0x0000E0AA
		protected bool method_1()
		{
			return Class612.smethod_1(this.shapeGeometryType_0);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0000FEB7 File Offset: 0x0000E0B7
		public static bool smethod_1(ShapeGeometryType shapeGeometryType_1)
		{
			return shapeGeometryType_1 == ShapeGeometryType.PointM || shapeGeometryType_1 == ShapeGeometryType.PointZM || shapeGeometryType_1 == ShapeGeometryType.LineStringM || shapeGeometryType_1 == ShapeGeometryType.LineStringZM || shapeGeometryType_1 == ShapeGeometryType.PolygonM || shapeGeometryType_1 == ShapeGeometryType.PolygonZM;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0000FEDA File Offset: 0x0000E0DA
		protected void method_2(Class661 class661_0, IDictionary<ShapeGeometryType, double> idictionary_0)
		{
			class661_0.ReadDouble();
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0000FEDA File Offset: 0x0000E0DA
		protected void method_3(Class661 class661_0, IDictionary<ShapeGeometryType, double> idictionary_0)
		{
			class661_0.ReadDouble();
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0009326C File Offset: 0x0009146C
		protected void method_4(Class661 class661_0)
		{
			if (this.method_0() || this.method_1())
			{
				IDictionary<ShapeGeometryType, double> idictionary_ = new Dictionary<ShapeGeometryType, double>(2);
				if (this.method_0())
				{
					this.method_2(class661_0, idictionary_);
				}
				if (this.method_1())
				{
					this.method_3(class661_0, idictionary_);
				}
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000932BC File Offset: 0x000914BC
		protected void method_5(Class661 class661_0)
		{
			if (this.method_0() || this.method_1())
			{
				IDictionary<ShapeGeometryType, double>[] array = new Dictionary<ShapeGeometryType, double>[this.igeometry_0.imethod_3()];
				if (this.method_0())
				{
					this.double_0[this.int_0++] = class661_0.ReadDouble();
					this.double_0[this.int_0++] = class661_0.ReadDouble();
					for (int i = 0; i < this.igeometry_0.imethod_3(); i++)
					{
						if (array[i] == null)
						{
							array[i] = new Dictionary<ShapeGeometryType, double>(2);
						}
						this.method_2(class661_0, array[i]);
					}
				}
				if (this.method_1())
				{
					this.double_0[this.int_0++] = class661_0.ReadDouble();
					this.double_0[this.int_0++] = class661_0.ReadDouble();
					for (int i = 0; i < this.igeometry_0.imethod_3(); i++)
					{
						if (array[i] == null)
						{
							array[i] = new Dictionary<ShapeGeometryType, double>(2);
						}
						this.method_3(class661_0, array[i]);
					}
				}
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x000933F0 File Offset: 0x000915F0
		protected int method_6()
		{
			this.int_0 = 0;
			int num = 4;
			if (this.method_0())
			{
				num += 2;
			}
			if (this.method_1())
			{
				num += 2;
			}
			return num;
		}

		// Token: 0x040009B8 RID: 2488
		protected int int_0 = 0;

		// Token: 0x040009B9 RID: 2489
		protected double[] double_0;

		// Token: 0x040009BA RID: 2490
		protected ShapeGeometryType shapeGeometryType_0;

		// Token: 0x040009BB RID: 2491
		protected IGeometry igeometry_0;
	}
}
