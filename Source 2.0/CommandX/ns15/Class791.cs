using System;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x020005E9 RID: 1513
	public sealed class Class791
	{
		// Token: 0x06002648 RID: 9800 RVA: 0x00015A2C File Offset: 0x00013C2C
		internal Class791(ColumnHeader columnHeader_1, Class680 class680_1)
		{
			if (columnHeader_1 == null)
			{
				throw new ArgumentNullException("columnHeader");
			}
			if (class680_1 == null)
			{
				throw new ArgumentNullException("listView");
			}
			this.columnHeader_0 = columnHeader_1;
			this.class680_0 = class680_1;
		}

		// Token: 0x04001260 RID: 4704
		private readonly ColumnHeader columnHeader_0;

		// Token: 0x04001261 RID: 4705
		private readonly Class680 class680_0;
	}
}
