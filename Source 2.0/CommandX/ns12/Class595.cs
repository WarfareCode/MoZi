using System;
using System.Collections;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x020003BB RID: 955
	public sealed class Class595 : GeometryCollection, IComparable<IGeometry>, IEquatable<IGeometry>, IEnumerable, IComparable, ICloneable, IGeometry, IGeometryCollection, Interface25
	{
		// Token: 0x06001788 RID: 6024 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public Class595(ILineString[] ilineString_0, IGeometryFactory igeometryFactory_0) : base(ilineString_0, igeometryFactory_0)
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0000945D File Offset: 0x0000765D
		public override Dimensions imethod_7()
		{
			return Dimensions.Curve;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00092A80 File Offset: 0x00090C80
		public override Dimensions imethod_4()
		{
			Dimensions result;
			if (this.method_5())
			{
				result = Dimensions.False;
			}
			else
			{
				result = Dimensions.Point;
			}
			return result;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00092AA4 File Offset: 0x00090CA4
		public bool method_5()
		{
			bool flag;
			bool result;
			if (this.imethod_10())
			{
				flag = false;
			}
			else
			{
				for (int i = 0; i < this.geometries.Length; i++)
				{
					if (!((ILineString)this.geometries[i]).imethod_12())
					{
						result = false;
						return result;
					}
				}
				flag = true;
			}
			result = flag;
			return result;
		}

		// Token: 0x040009AF RID: 2479
		public static readonly Interface25 interface25_0 = new GeometryFactory().imethod_9(null);
	}
}
