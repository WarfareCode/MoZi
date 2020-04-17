using System;

namespace ns18
{
	// Token: 0x02000363 RID: 867
	public sealed class GeographicBoundingBox
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x000895AC File Offset: 0x000877AC
		public GeographicBoundingBox()
		{
			this.double_0 = 90.0;
			this.double_1 = -90.0;
			this.double_2 = -180.0;
			this.double_3 = 180.0;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00089638 File Offset: 0x00087838
		public GeographicBoundingBox(double double_6, double double_7, double double_8, double double_9)
		{
			this.double_0 = double_6;
			this.double_1 = double_7;
			this.double_2 = double_8;
			this.double_3 = double_9;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000896A4 File Offset: 0x000878A4
		public GeographicBoundingBox(double double_6, double double_7, double double_8, double double_9, double double_10, double double_11)
		{
			this.double_0 = double_6;
			this.double_1 = double_7;
			this.double_2 = double_8;
			this.double_3 = double_9;
			this.double_4 = double_10;
			this.double_5 = double_11;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0000E975 File Offset: 0x0000CB75
		public bool method_0(GeographicBoundingBox class1944_0)
		{
			return this.double_0 > class1944_0.double_1 && this.double_1 < class1944_0.double_0 && this.double_2 < class1944_0.double_3 && this.double_3 > class1944_0.double_2;
		}

		// Token: 0x040008B7 RID: 2231
		public double double_0;

		// Token: 0x040008B8 RID: 2232
		public double double_1;

		// Token: 0x040008B9 RID: 2233
		public double double_2 = 0.0;

		// Token: 0x040008BA RID: 2234
		public double double_3 = 0.0;

		// Token: 0x040008BB RID: 2235
		public double double_4 = 0.0;

		// Token: 0x040008BC RID: 2236
		public double double_5 = 0.0;
	}
}
