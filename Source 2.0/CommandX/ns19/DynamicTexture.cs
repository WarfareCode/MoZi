using System;
using Microsoft.DirectX.Direct3D;

namespace ns19
{
	// Token: 0x020003C6 RID: 966
	public sealed class DynamicTexture : IDisposable
	{
		// Token: 0x060017E8 RID: 6120 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public void Dispose()
		{
		}

		// Token: 0x040009D7 RID: 2519
		public CustomVertex.PositionNormalTextured[] nwVerts;

		// Token: 0x040009D8 RID: 2520
		public CustomVertex.PositionNormalTextured[] neVerts;

		// Token: 0x040009D9 RID: 2521
		public CustomVertex.PositionNormalTextured[] swVerts;

		// Token: 0x040009DA RID: 2522
		public CustomVertex.PositionNormalTextured[] seVerts;
	}
}
