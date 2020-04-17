using System;
using System.Collections.Generic;

namespace ns24
{
	// Token: 0x02000545 RID: 1349
	public interface IBasicPolygon : ICloneable, IBasicGeometry
	{
		// Token: 0x0600231E RID: 8990
		ICollection<IBasicLineString> GetHoles();

		// Token: 0x0600231F RID: 8991
		IBasicLineString GetShell();

		// Token: 0x06002320 RID: 8992
		int GetNumHoles();
	}
}
