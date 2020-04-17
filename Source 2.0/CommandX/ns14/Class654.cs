using System;
using GeoAPI.Geometries;
using ns13;

namespace ns14
{
	// Token: 0x02000462 RID: 1122
	public sealed class Class654 : Class653
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x000B5958 File Offset: 0x000B3B58
		public static Class666 smethod_0(IGeometry igeometry_0, IGeometry igeometry_1)
		{
			Class654 @class = new Class654(igeometry_0, igeometry_1);
			return @class.method_2();
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00011ECE File Offset: 0x000100CE
		public Class654(IGeometry igeometry_0, IGeometry igeometry_1) : base(igeometry_0, igeometry_1)
		{
			this.class641_0 = new Class641(this.class640_0);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000B5978 File Offset: 0x000B3B78
		public Class666 method_2()
		{
			return this.class641_0.method_0();
		}

		// Token: 0x04000C87 RID: 3207
		private Class641 class641_0 = null;
	}
}
