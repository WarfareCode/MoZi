using System;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns1
{
	// Token: 0x02000AA4 RID: 2724
	public sealed class GuidedProjectile_AI : Weapon_AI
	{
		// Token: 0x06005665 RID: 22117 RVA: 0x000278CA File Offset: 0x00025ACA
		public GuidedProjectile_AI(Weapon weapon_1) : base(weapon_1)
		{
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x002517A0 File Offset: 0x0024F9A0
		public override void vmethod_18(float float_3)
		{
			if (!Information.IsNothing(this.GetPrimaryTarget()))
			{
				try
				{
					float angleBetween = Class263.GetAngleBetween(this.m_ActiveUnit.GetCurrentHeading(), Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null)));
					if (315f > angleBetween && angleBetween > 45f && this.m_ActiveUnit.GetCurrentSpeed() > this.GetPrimaryTarget().GetCurrentSpeed())
					{
						base.method_52(0f, 0f);
					}
					else
					{
						Weapon._GuidanceMethod guidanceMethod = base.GetParentWeapon().GetGuidanceMethod();
						if (guidanceMethod == Weapon._GuidanceMethod.BeamRiding)
						{
							base.method_52(0f, 0f);
						}
						else
						{
							base.method_53(new float?(this.m_ActiveUnit.GetCurrentSpeed()));
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 1002343214523463564", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
