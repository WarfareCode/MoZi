using System;
using Microsoft.VisualBasic;
using ns2;

namespace Command_Core
{
	// Token: 0x020005B5 RID: 1461
	public sealed class AltBand : Subject
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x000E875C File Offset: 0x000E695C
		public int GetMaxSpeed()
		{
			int result;
			if (!Information.IsNothing(this.Speed_Flank))
			{
				result = (int)this.Speed_Flank.Value;
			}
			else if (!Information.IsNothing(this.Speed_Full))
			{
				result = (int)this.Speed_Full.Value;
			}
			else
			{
				result = this.Speed_Cruise;
			}
			return result;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x0001542D File Offset: 0x0001362D
		private AltBand()
		{
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00015435 File Offset: 0x00013635
		public AltBand(float float_4, float float_5)
		{
			this.MaxAltitude = float_4;
			this.MinAltitude = float_5;
		}

		// Token: 0x040011FC RID: 4604
		public float MaxAltitude;

		// Token: 0x040011FD RID: 4605
		public float MinAltitude;

		// Token: 0x040011FE RID: 4606
		public int Speed_Loiter;

		// Token: 0x040011FF RID: 4607
		public int Speed_Cruise;

		// Token: 0x04001200 RID: 4608
		public long? Speed_Full;

		// Token: 0x04001201 RID: 4609
		public long? Speed_Flank;

		// Token: 0x04001202 RID: 4610
		public float Consumption_Loiter;

		// Token: 0x04001203 RID: 4611
		public float Consumption_Cruise;

		// Token: 0x04001204 RID: 4612
		public float? Consumption_Full;

		// Token: 0x04001205 RID: 4613
		public float? Consumption_Flank;
	}
}
