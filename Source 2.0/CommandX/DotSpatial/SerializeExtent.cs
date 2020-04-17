using System;
using System.ComponentModel;

namespace DotSpatial
{
	// Token: 0x02000648 RID: 1608
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class SerializeExtent : ICloneable
	{
		// Token: 0x0600294E RID: 10574 RVA: 0x000FCED4 File Offset: 0x000FB0D4
		public SerializeExtent()
		{
			this.XMin = 1.7976931348623157E+308;
			this.XMax = -1.7976931348623157E+308;
			this.YMin = 1.7976931348623157E+308;
			this.YMax = -1.7976931348623157E+308;
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00016A06 File Offset: 0x00014C06
		public SerializeExtent(double double_0, double double_1, double double_2, double double_3)
		{
			this.XMin = double_0;
			this.YMin = double_1;
			this.XMax = double_2;
			this.YMax = double_3;
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000FCF24 File Offset: 0x000FB124
		public object Clone()
		{
			return new SerializeExtent(this.XMin, this.YMin, this.XMax, this.YMax);
		}

		// Token: 0x040013C9 RID: 5065
		public double XMax;

		// Token: 0x040013CA RID: 5066
		public double XMin;

		// Token: 0x040013CB RID: 5067
		public double YMax;

		// Token: 0x040013CC RID: 5068
		public double YMin;
	}
}
