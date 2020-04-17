using System;
using GeoAPI.Geometries;
using ns12;
using ns13;

namespace ns14
{
	// Token: 0x02000454 RID: 1108
	public class Class653
	{
		// Token: 0x06001C77 RID: 7287 RVA: 0x000B5138 File Offset: 0x000B3338
		protected Class596 method_0()
		{
			return this.class596_0;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000B5150 File Offset: 0x000B3350
		public Class653(IGeometry igeometry_0, IGeometry igeometry_1)
		{
			if (igeometry_0.imethod_1().CompareTo(igeometry_1.imethod_1()) >= 0)
			{
				this.method_1(igeometry_0.imethod_1());
			}
			else
			{
				this.method_1(igeometry_1.imethod_1());
			}
			this.class640_0 = new Class640[2];
			this.class640_0[0] = new Class640(0, igeometry_0);
			this.class640_0[1] = new Class640(1, igeometry_1);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00011D1D File Offset: 0x0000FF1D
		protected void method_1(IPrecisionModel iprecisionModel_1)
		{
			this.iprecisionModel_0 = iprecisionModel_1;
			this.method_0().method_0(this.iprecisionModel_0);
		}

		// Token: 0x04000C68 RID: 3176
		private Class596 class596_0 = new Class597();

		// Token: 0x04000C69 RID: 3177
		protected IPrecisionModel iprecisionModel_0;

		// Token: 0x04000C6A RID: 3178
		protected Class640[] class640_0;
	}
}
