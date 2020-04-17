using System;
using System.Collections;

namespace ns16
{
	// Token: 0x020004BA RID: 1210
	public sealed class WorldWindPlacenameFile
	{
		// Token: 0x04000EF6 RID: 3830
		public string dataFilename;

		// Token: 0x04000EF7 RID: 3831
		public float north;

		// Token: 0x04000EF8 RID: 3832
		public float south;

		// Token: 0x04000EF9 RID: 3833
		public float west = 0f;

		// Token: 0x04000EFA RID: 3834
		public float east;

		// Token: 0x04000EFB RID: 3835
		public ArrayList m_placeNames = new ArrayList();
	}
}
