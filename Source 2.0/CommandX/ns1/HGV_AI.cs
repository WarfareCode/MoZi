using System;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns1
{
	// Token: 0x02000AAA RID: 2730
	public sealed class HGV_AI : Weapon_AI
	{
		// Token: 0x06005697 RID: 22167 RVA: 0x000278CA File Offset: 0x00025ACA
		public HGV_AI(Weapon weapon_1) : base(weapon_1)
		{
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x0024FAFC File Offset: 0x0024DCFC
		public override void vmethod_18(float float_3)
		{
			if (!Information.IsNothing(this.GetPrimaryTarget()))
			{
				try
				{
					this.m_ActiveUnit.GetCurrentHeading();
					float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null));
					if (this.m_ActiveUnit.GetCurrentHeading() != azimuth)
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
								base.method_53(new float?(this.m_ActiveUnit.GetDesiredSpeed()));
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100969", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x00253228 File Offset: 0x00251428
		private void method_110()
		{
			if (!Information.IsNothing(this.GetPrimaryTarget()))
			{
				base.GetParentWeapon().SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
				double num = Math.Atan2((double)(base.GetParentWeapon().GetCurrentAltitude_ASL(false) - this.GetPrimaryTarget().GetCurrentAltitude_ASL(false)), (double)(base.GetParentWeapon().GetHorizontalRange(this.GetPrimaryTarget()) * 1852f)) * 57.2957795130823;
				if (num > 0.0)
				{
					num = -num;
				}
				base.GetParentWeapon().vmethod_20((float)num);
			}
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x002532BC File Offset: 0x002514BC
		private void method_111(float float_3)
		{
			try
			{
				if ((double)base.GetParentWeapon().GetCurrentAltitude_ASL(false) > (double)base.GetParentWeapon().GetCruiseAltitude_ASL() * 1.2)
				{
					if (!Information.IsNothing(base.GetParentWeapon().LaunchPoint))
					{
						if ((double)this.m_ActiveUnit.HorizontalRangeTo(base.GetParentWeapon().LaunchPoint) < 539.9568034557235)
						{
							base.GetParentWeapon().SetDesiredAltitude(base.GetParentWeapon().GetCruiseAltitude_ASL());
							base.GetParentWeapon().vmethod_20(-45f);
						}
						else
						{
							this.method_110();
						}
					}
				}
				else
				{
					this.method_110();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100319757711", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x002533B0 File Offset: 0x002515B0
		public override void Navigate(float elapsedTime_)
		{
			try
			{
				Weapon parentWeapon = base.GetParentWeapon();
				if (!base.method_59(ref parentWeapon) && this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
				{
					this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
					this.method_111(elapsedTime_);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100970", "");
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
