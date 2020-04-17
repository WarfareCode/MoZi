using System;
using Command_Core;

namespace ns2
{
	// Token: 平台
	public abstract class Platform : ActiveUnit
	{
		// Token: 0x060043E2 RID: 17378 RVA: 0x00021E1B File Offset: 0x0002001B
		public Platform(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.m_Magazines = new Magazine[0];
		}

		// Token: 0x060043E3 RID: 17379
		public abstract float GetArea();

		// Token: 0x04001FC7 RID: 8135
		public int Crew;

		// Token: 0x04001FC8 RID: 8136
		public Magazine[] m_Magazines;
	}
}
