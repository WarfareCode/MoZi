using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200044E RID: 1102
	[Serializable]
	public sealed class Polygon : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable, IGeometry, IPolygon
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x000B4A00 File Offset: 0x000B2C00
		public Polygon(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (ilinearRing_0 == null)
			{
				ilinearRing_0 = base.imethod_0().imethod_6(null);
			}
			if (ilinearRing_1 == null)
			{
				ilinearRing_1 = new ILinearRing[0];
			}
			if (Geometry.smethod_1(ilinearRing_1))
			{
				throw new ArgumentException("holes must not contain null elements");
			}
			if (ilinearRing_0.imethod_10() && Geometry.smethod_0(ilinearRing_1))
			{
				throw new ArgumentException("shell is empty but holes are not");
			}
			this.shell = ilinearRing_0;
			this.holes = ilinearRing_1;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x000B4A88 File Offset: 0x000B2C88
		public override ICoordinate imethod_5()
		{
			return this.shell.imethod_5();
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x000B4AA4 File Offset: 0x000B2CA4
		public override ICoordinate[] imethod_6()
		{
			ICoordinate[] result;
			if (this.imethod_10())
			{
				result = new ICoordinate[0];
			}
			else
			{
				ICoordinate[] array = new ICoordinate[this.imethod_3()];
				int num = -1;
				ICoordinate[] array2 = this.shell.imethod_6();
				for (int i = 0; i < array2.Length; i++)
				{
					num++;
					array[num] = array2[i];
				}
				for (int j = 0; j < this.holes.Length; j++)
				{
					ICoordinate[] array3 = this.holes[j].imethod_6();
					for (int k = 0; k < array3.Length; k++)
					{
						num++;
						array[num] = array3[k];
					}
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000B4B54 File Offset: 0x000B2D54
		public override int imethod_3()
		{
			int num = this.shell.imethod_3();
			for (int i = 0; i < this.holes.Length; i++)
			{
				num += this.holes[i].imethod_3();
			}
			return num;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public override Dimensions imethod_7()
		{
			return Dimensions.Surface;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0000945D File Offset: 0x0000765D
		public override Dimensions imethod_4()
		{
			return Dimensions.Curve;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00011AB3 File Offset: 0x0000FCB3
		public override bool imethod_10()
		{
			return this.shell.imethod_10();
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000B4B98 File Offset: 0x000B2D98
		public ILineString imethod_11()
		{
			return this.shell;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x000B4BB0 File Offset: 0x000B2DB0
		public int imethod_13()
		{
			return this.holes.Length;
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x000B4BC8 File Offset: 0x000B2DC8
		public ILineString[] imethod_14()
		{
			return this.holes;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x000B4BE0 File Offset: 0x000B2DE0
		public ILineString imethod_15(int int_0)
		{
			return this.holes[int_0];
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000B4BF8 File Offset: 0x000B2DF8
		protected override IEnvelope vmethod_1()
		{
			return this.shell.imethod_8();
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x000B4C14 File Offset: 0x000B2E14
		public  object Clone()
		{
			Polygon polygon = (Polygon)base.Clone();
			polygon.shell = (LinearRing)this.shell.Clone();
			polygon.holes = new ILinearRing[this.holes.Length];
			for (int i = 0; i < this.holes.Length; i++)
			{
				polygon.holes[i] = (LinearRing)this.holes[i].Clone();
			}
			return polygon;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000B4C88 File Offset: 0x000B2E88
		protected internal override int vmethod_2(object object_0)
		{
			LinearRing linearRing = (LinearRing)this.shell;
			ILinearRing object_ = ((IPolygon)object_0).imethod_12();
			return linearRing.vmethod_2(object_);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000B4CB8 File Offset: 0x000B2EB8
		public ILinearRing imethod_12()
		{
			return this.shell;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000B4CD0 File Offset: 0x000B2ED0
		public ILinearRing[] imethod_16()
		{
			return this.holes;
		}

		// Token: 0x04000C5D RID: 3165
		public static readonly IPolygon Empty = new GeometryFactory().imethod_7(null, null);

		// Token: 0x04000C5E RID: 3166
		protected ILinearRing shell = null;

		// Token: 0x04000C5F RID: 3167
		protected ILinearRing[] holes;
	}
}
