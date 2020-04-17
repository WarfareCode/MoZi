using System;
using GeoAPI.Geometries;
using ns12;

namespace ns13
{
	// Token: 0x020003D9 RID: 985
	public sealed class Class626 : ICoordinateSequenceFactory
	{
		// Token: 0x06001875 RID: 6261 RVA: 0x00010380 File Offset: 0x0000E580
		public Class626() : this(Class626.Enum138.const_0)
		{
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00010389 File Offset: 0x0000E589
		public Class626(Class626.Enum138 enum138_1) : this(enum138_1, 3)
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00010393 File Offset: 0x0000E593
		public Class626(Class626.Enum138 enum138_1, int int_1)
		{
			this.method_0(enum138_1);
			this.method_1(int_1);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000103B7 File Offset: 0x0000E5B7
		public void method_0(Class626.Enum138 enum138_1)
		{
			if (enum138_1 != Class626.Enum138.const_0 && enum138_1 != Class626.Enum138.const_1)
			{
				throw new ArgumentException("Unknown type " + enum138_1);
			}
			this.enum138_0 = enum138_1;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000103E2 File Offset: 0x0000E5E2
		public void method_1(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000976FC File Offset: 0x000958FC
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			ICoordinateSequence result;
			if (this.enum138_0 == Class626.Enum138.const_0)
			{
				result = new Class593(icoordinate_0, this.int_0);
			}
			else
			{
				result = new Class594(icoordinate_0, this.int_0);
			}
			return result;
		}

		// Token: 0x04000A19 RID: 2585
		public static readonly Class626 class626_0 = new Class626(Class626.Enum138.const_0);

		// Token: 0x04000A1A RID: 2586
		public static readonly Class626 class626_1 = new Class626(Class626.Enum138.const_1);

		// Token: 0x04000A1B RID: 2587
		private Class626.Enum138 enum138_0 = Class626.Enum138.const_0;

		// Token: 0x04000A1C RID: 2588
		private int int_0 = 3;

		// Token: 0x020003DA RID: 986
		public enum Enum138
		{
			// Token: 0x04000A1E RID: 2590
			const_0,
			// Token: 0x04000A1F RID: 2591
			const_1
		}
	}
}
