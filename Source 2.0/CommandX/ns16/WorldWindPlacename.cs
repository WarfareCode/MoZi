using System;
using System.Collections;
using Microsoft.DirectX;

namespace ns16
{
	// Token: 0x020004BB RID: 1211
	public struct WorldWindPlacename
	{
		// Token: 0x04000EFC RID: 3836
		public string ID;

		// Token: 0x04000EFD RID: 3837
		public string Name;

		// Token: 0x04000EFE RID: 3838
		public string ChineseName;

		// Token: 0x04000EFF RID: 3839
		public float Lat;

		// Token: 0x04000F00 RID: 3840
		public float Lon;

		// Token: 0x04000F01 RID: 3841
		public Vector3 cartesianPoint;

		// Token: 0x04000F02 RID: 3842
		public Hashtable metaData;
	}
}
