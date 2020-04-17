using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace ns1
{
	// Token: 0x02000AA0 RID: 2720
	public sealed class GuidedProjectile : Weapon
	{
		// Token: 0x06005630 RID: 22064 RVA: 0x000277B5 File Offset: 0x000259B5
		public GuidedProjectile() : base(null)
		{
			this.IsWeapon = true;
			base.SetWeaponType(Weapon._WeaponType.GuidedProjectile);
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x000277D0 File Offset: 0x000259D0
		public GuidedProjectile(ref Scenario theScen, int WeaponDBID, string theGUID = null) : base(theGUID)
		{
			this.IsWeapon = true;
			base.SetWeaponType(Weapon._WeaponType.GuidedProjectile);
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x0024DE84 File Offset: 0x0024C084
		public override Weapon_AI GetWeaponAI()
		{
			if (Information.IsNothing(this.guidedProjectile_AI))
			{
				this.guidedProjectile_AI = new GuidedProjectile_AI(this);
			}
			return this.guidedProjectile_AI;
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x0024DEB8 File Offset: 0x0024C0B8
		public override Weapon_Kinematics GetWeaponKinematics()
		{
			if (Information.IsNothing(this.guidedProjectile_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.guidedProjectile_Kinematics = new GuidedProjectile_Kinematics(ref activeUnit);
			}
			return this.guidedProjectile_Kinematics;
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x0006D5A0 File Offset: 0x0006B7A0
		public override float GetPitch()
		{
			return this.Pitch;
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x00009334 File Offset: 0x00007534
		public override void SetPitch(float float_47)
		{
			this.Pitch = float_47;
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
		public override float vmethod_19()
		{
			return this.float_5;
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x00009346 File Offset: 0x00007546
		public override void vmethod_20(float float_47)
		{
			this.float_5 = float_47;
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0024DEEC File Offset: 0x0024C0EC
		public override float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			return base.GetCurrentAltitude_ASL(DoSanityCheck);
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x000277EB File Offset: 0x000259EB
		public override void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			if (DoSanityCheck && base.IsGuidedWeapon() && value < 6.09599972f)
			{
				value = 6.09599972f;
			}
			this.GetCurrentAltitude_ASL(false);
			base.SetAltitude_ASL(DoSanityCheck, value);
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsGuidedProjectile()
		{
			return true;
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x0024DF04 File Offset: 0x0024C104
		public static GuidedProjectile Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_1, bool bool_21)
		{
			GuidedProjectile result = null;
			try
			{
				GuidedProjectile guidedProjectile = new GuidedProjectile();
				guidedProjectile.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (GuidedProjectile)dictionary_0[innerText];
				}
				else
				{
					guidedProjectile.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = guidedProjectile;
					}
					else
					{
						dictionary_0.Add(guidedProjectile.GetGuid(), guidedProjectile);
						int weaponDBID = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						DBFunctions.LoadWeaponData(scenario_1.GetSQLiteConnection(), guidedProjectile, weaponDBID, scenario_1, bool_21);
						if (bool_21)
						{
							guidedProjectile.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_21)
						{
							Weapon.smethod_3(guidedProjectile, scenario_1, xmlNode_0, dictionary_0);
						}
						Weapon.smethod_5(guidedProjectile, scenario_1, xmlNode_0, dictionary_0);
						result = guidedProjectile;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100882", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new GuidedProjectile();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x0024E03C File Offset: 0x0024C23C
		public override bool IsPrimaryTargetAttackable(float elapsedTime)
		{
			bool flag;
			bool result;
			if (!(flag = base.IsPrimaryTargetAttackable(elapsedTime)))
			{
				float num = base.RelativeBearingTo(this.GetWeaponAI().GetPrimaryTarget());
				if (num > 100f && num < 260f)
				{
					result = true;
					return result;
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0024E088 File Offset: 0x0024C288
		public override void ScheduleLifeCycleActivities(float float_47, ref Random random_1)
		{
			if (!this.bPrimaryTargetAttackable)
			{
				if (!this.IsUnderWater() && !this.IsUnderGround())
				{
					if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && base.RelativeBearingTo(this.GetWeaponAI().GetPrimaryTarget()) > 100f && base.RelativeBearingTo(this.GetWeaponAI().GetPrimaryTarget()) < 260f)
					{
						double latitude = this.GetLatitude(null);
						double longitude = this.GetLongitude(null);
						float currentAltitude_ASL = this.GetCurrentAltitude_ASL(false);
						Random random = base.GetRandom();
						base.Detonation(latitude, longitude, currentAltitude_ASL, ref random);
						return;
					}
					if ((double)base.HorizontalRangeTo(this.LaunchPoint) > (double)base.GetLargestRangeMaxOfAllDomains() * 1.05)
					{
						this.m_Scenario.RemoveUnit(this);
						return;
					}
				}
				else
				{
					if (this.m_Warheads.Any<Warhead>() && this.m_Warheads[0].method_13())
					{
						double latitude2 = this.GetLatitude(null);
						double longitude2 = this.GetLongitude(null);
						float currentAltitude_ASL2 = this.GetCurrentAltitude_ASL(false);
						Random random = base.GetRandom();
						base.Detonation(latitude2, longitude2, currentAltitude_ASL2, ref random);
						return;
					}
					this.m_Scenario.RemoveUnit(this);
					return;
				}
			}
			base.ScheduleLifeCycleActivities(float_47, ref random_1);
		}

		// Token: 0x04002A77 RID: 10871
		private GuidedProjectile_AI guidedProjectile_AI;

		// Token: 0x04002A78 RID: 10872
		private GuidedProjectile_Kinematics guidedProjectile_Kinematics;
	}
}
