using System;
using System.ComponentModel;

namespace ns24
{
	// Token: 0x02000543 RID: 1347
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public interface ICoordinate : IComparable, ICloneable
	{
		// Token: 0x1700027E RID: 638
		double this[int index]
		{
			get;
			set;
		}

		// Token: 0x06002319 RID: 8985
		double GetM();

		// Token: 0x0600231A RID: 8986
		double[] GetValues();

		// Token: 0x0600231B RID: 8987
		double GetX();

		// Token: 0x0600231C RID: 8988
		double GetY();

		// Token: 0x0600231D RID: 8989
		double GetZ();
	}
}
