using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns26
{
	// Token: 0x020007F5 RID: 2037
	public sealed class Class2344
	{
		// Token: 0x06003230 RID: 12848 RVA: 0x0001B070 File Offset: 0x00019270
		public Class2344(LineString lineString_1, int int_1)
		{
			this.lineString_0 = lineString_1;
			this.int_0 = int_1;
			this.method_0();
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0010D83C File Offset: 0x0010BA3C
		private void method_0()
		{
			IList<Coordinate> coordinates = this.lineString_0.GetCoordinates();
			this.class2225_0 = new Class2225[coordinates.Count - 1];
			for (int i = 0; i < coordinates.Count - 1; i++)
			{
				Class2225 @class = new Class2225(coordinates[i], coordinates[i + 1], this.lineString_0, i);
				this.class2225_0[i] = @class;
			}
		}

		// Token: 0x0400174D RID: 5965
		private readonly int int_0;

		// Token: 0x0400174E RID: 5966
		private readonly LineString lineString_0;

		// Token: 0x0400174F RID: 5967
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x04001750 RID: 5968
		private Class2225[] class2225_0;
	}
}
