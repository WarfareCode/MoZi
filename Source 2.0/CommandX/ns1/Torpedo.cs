using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace ns1
{
	// Token: 0x02000AAB RID: 2731
	public sealed class Torpedo : Weapon
	{
		// Token: 0x0600569C RID: 22172 RVA: 0x0025344C File Offset: 0x0025164C
		public override Weapon_AI GetWeaponAI()
		{
			if (Information.IsNothing(this.torpedo_AI))
			{
				this.torpedo_AI = new Torpedo_AI(this);
			}
			return this.torpedo_AI;
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00253480 File Offset: 0x00251680
		public override Weapon_Kinematics GetWeaponKinematics()
		{
			if (Information.IsNothing(this.torpedo_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.torpedo_Kinematics = new Torpedo_Kinematics(ref activeUnit);
			}
			return this.torpedo_Kinematics;
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x0002794D File Offset: 0x00025B4D
		public Torpedo(ref Scenario theScen, int WeaponDBID, string theGUID = null) : base(null)
		{
			this.IsWeapon = true;
			base.SetWeaponType(Weapon._WeaponType.Torpedo);
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x0002794D File Offset: 0x00025B4D
		private Torpedo() : base(null)
		{
			this.IsWeapon = true;
			base.SetWeaponType(Weapon._WeaponType.Torpedo);
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsTorpedo()
		{
			return true;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x002534B4 File Offset: 0x002516B4
		public static Torpedo Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_1, bool bool_21)
		{
			Torpedo result = null;
			try
			{
				Torpedo torpedo = new Torpedo();
				torpedo.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Torpedo)dictionary_0[innerText];
				}
				else
				{
					torpedo.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = torpedo;
					}
					else
					{
						dictionary_0.Add(torpedo.GetGuid(), torpedo);
						int weaponDBID = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						DBFunctions.LoadWeaponData(scenario_1.GetSQLiteConnection(), torpedo, weaponDBID, scenario_1, bool_21);
						if (bool_21)
						{
							torpedo.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_21)
						{
							Weapon.smethod_3(torpedo, scenario_1, xmlNode_0, dictionary_0);
						}
						Weapon.smethod_5(torpedo, scenario_1, xmlNode_0, dictionary_0);
						float maxAltitude = torpedo.GetWeaponKinematics().GetMaxAltitude();
						float minAltitude = torpedo.GetWeaponKinematics().GetMinAltitude();
						if (torpedo.GetCurrentAltitude_ASL(false) > maxAltitude)
						{
							torpedo.SetAltitude_ASL(false, maxAltitude);
						}
						else if (torpedo.GetCurrentAltitude_ASL(false) < minAltitude)
						{
							torpedo.SetAltitude_ASL(false, minAltitude);
						}
						if (torpedo.GetDesiredAltitude() > maxAltitude)
						{
							torpedo.SetDesiredAltitude(maxAltitude);
						}
						else if (torpedo.GetDesiredAltitude() < minAltitude)
						{
							torpedo.SetDesiredAltitude(minAltitude);
						}
						result = torpedo;
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
				result = new Torpedo();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x0025367C File Offset: 0x0025187C
		public override void ScheduleLifeCycleActivities(float elapsedTime_, ref Random random_)
		{
			checked
			{
				try
				{
					if (base.GetTerrainElevation(false, false, false) >= 0)
					{
						base.Detonation(this.GetLatitude(null), this.GetLongitude(null), -1f, ref random_);
					}
					switch (base.GetGuidanceMethod())
					{
					case Weapon._GuidanceMethod.PassiveTerminalGuidance:
						if (base.method_223())
						{
							return;
						}
						if (base.method_225(60f, true, false, true, elapsedTime_))
						{
							return;
						}
						break;
					case Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
						if (base.method_223())
						{
							return;
						}
						if (base.method_225(60f, true, false, false, elapsedTime_))
						{
							return;
						}
						break;
					case Weapon._GuidanceMethod.const_5:
						base.CommandGuidance(elapsedTime_);
						break;
					case Weapon._GuidanceMethod.ActiveTerminalGuidance:
						if (base.method_223())
						{
							return;
						}
						if (base.method_225(60f, true, false, true, elapsedTime_))
						{
							return;
						}
						if (!base.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
						{
							Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
							for (int i = 0; i < noneMCMSensors.Length; i++)
							{
								Sensor sensor = noneMCMSensors[i];
								if (sensor.IsActiveCapable() && !sensor.IsEmmitting())
								{
									sensor.TurnOn();
								}
							}
						}
						else
						{
							base.method_208();
						}
						break;
					case Weapon._GuidanceMethod.const_7:
						if (this.GetNoneMCMSensors().Length > 0 && this.GetNoneMCMSensors()[0].IsEmmitting())
						{
							if (base.method_220(elapsedTime_))
							{
								return;
							}
							if (base.method_221(elapsedTime_))
							{
								return;
							}
							if (base.method_225(60f, true, true, true, elapsedTime_))
							{
								return;
							}
						}
						else
						{
							base.CommandGuidance(elapsedTime_);
							base.method_208();
						}
						break;
					case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
						if (base.method_223())
						{
							return;
						}
						if (base.method_225(60f, true, false, false, elapsedTime_))
						{
							return;
						}
						if (this.GetNoneMCMSensors().Length > 0 && !this.GetNoneMCMSensors()[0].IsEmmitting())
						{
							base.method_208();
						}
						break;
					case Weapon._GuidanceMethod.CommandGuided:
						base.CommandGuidance(elapsedTime_);
						break;
					case Weapon._GuidanceMethod.InertiallyGuided:
						this.InertialGuidance(elapsedTime_, ref random_);
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100905", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				if ((!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.bPrimaryTargetAttackable) || base.IsTargetAttackable(elapsedTime_))
				{
					float val;
					if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
					{
						val = Math.Max(this.GetWeaponAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false), -10f);
					}
					else
					{
						val = this.GetWeaponAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false);
					}
					if (this.m_Warheads.Length > 0 && this.m_Warheads[0].HasNuclearWarhead(this.m_Scenario))
					{
						if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
						{
							base.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null), Math.Max(val, -10f), ref random_);
						}
						else
						{
							base.WeaponEndGame(this.GetWeaponAI().GetPrimaryTarget().ActualUnit, ref this.m_Scenario, false, ref random_);
							this.m_Scenario.RemoveUnit(this);
						}
						return;
					}
					if (this.bPrimaryTargetAttackable)
					{
						if (this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint && this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint)
						{
							if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetWeaponry()))
							{
								ActiveUnit_Weaponry weaponry = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetWeaponry();
								Weapon weapon = this;
								weaponry.AttackTarget(elapsedTime_, ref weapon);
							}
							else
							{
								this.m_Scenario.RemoveUnit(this);
							}
						}
					}
					else
					{
						if (!this.GetWeaponAI().GetPrimaryTarget().IsFacilityType())
						{
							this.GetWeaponAI().DropTargeting(this.GetWeaponAI().GetPrimaryTarget(), true);
							return;
						}
						base.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null), (float)this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false), ref random_);
					}
				}
				if (this.DetonationDelay > 0f)
				{
					this.DetonationDelay -= elapsedTime_;
					if (this.DetonationDelay <= 0f)
					{
						base.Detonation(this.GetLatitude(null), this.GetLongitude(null), (float)base.GetTerrainElevation(false, false, false), ref random_);
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100906", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00253C18 File Offset: 0x00251E18
		public override bool IsPrimaryTargetAttackable(float elapsedTime)
		{
			bool flag;
			bool result;
			if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
			{
				flag = false;
			}
			else if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
			{
				flag = false;
			}
			else
			{
				GlobalVariables.ActiveUnitType unitType = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetUnitType();
				if (unitType != GlobalVariables.ActiveUnitType.Ship)
				{
					if (unitType == GlobalVariables.ActiveUnitType.Submarine)
					{
						float num = ((Submarine)this.GetWeaponAI().GetPrimaryTarget().ActualUnit).Length / 1852f;
						if (base.GetHorizontalRange(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) < num)
						{
							result = true;
							return result;
						}
					}
				}
				else
				{
					float num = ((Ship)this.GetWeaponAI().GetPrimaryTarget().ActualUnit).Length / 1852f;
					if (base.GetHorizontalRange(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) < num)
					{
						result = true;
						return result;
					}
				}
				flag = base.IsPrimaryTargetAttackable(elapsedTime);
			}
			result = flag;
			return result;
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00253D24 File Offset: 0x00251F24
		private void InertialGuidance(float elapsedTime_, ref Random random_)
		{
			try
			{
				if (base.HasNuclearWarhead())
				{
					if (!base.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
					{
						base.Detonation(this.GetLatitude(null), this.GetLongitude(null), this.GetCurrentAltitude_ASL(false), ref random_);
						this.m_Scenario.RemoveUnit(this);
					}
				}
				else if (base.IsGuidingToTarget())
				{
					float num = this.GetCurrentSpeed() / 3600f * elapsedTime_;
					List<ActiveUnit> list = new List<ActiveUnit>();
					foreach (ActiveUnit current in this.m_Scenario.GetActiveUnitList())
					{
						if ((current.IsShip || current.IsSubmarine || (current.IsFacility && !current.IsOnLand())) && current.GetCurrentAltitude_ASL(false) >= -20f)
						{
							float angleBetween = Class263.GetAngleBetween(this.GetCurrentHeading(), Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), current.GetLatitude(null), current.GetLongitude(null)));
							if (270f <= angleBetween || angleBetween <= 90f)
							{
								float num2 = 0f;
								if (current.IsShip)
								{
									num2 = ((Ship)current).Length / 2f;
								}
								else if (current.IsSubmarine)
								{
									num2 = ((Submarine)current).Length / 2f;
								}
								else if (current.IsFacility)
								{
									num2 = (float)Math.Sqrt(((Facility)current).Area / 3.14159265358979);
								}
								float num3 = num2 / 1852f;
								float horizontalRange = base.GetHorizontalRange(current);
								if (horizontalRange <= num3)
								{
									list.Add(current);
								}
								else if (horizontalRange <= num)
								{
									list.Add(current);
								}
							}
						}
					}
					int count = list.Count;
					if (count != 0)
					{
						if (count == 1)
						{
							base.WeaponEndGame(list[0], ref this.m_Scenario, false, ref random_);
							this.m_Scenario.RemoveUnit(this);
						}
						else
						{
							base.WeaponEndGame(list[random_.Next(list.Count - 1)], ref this.m_Scenario, false, ref random_);
							this.m_Scenario.RemoveUnit(this);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100940", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04002A8F RID: 10895
		private Torpedo_AI torpedo_AI;

		// Token: 0x04002A90 RID: 10896
		private Torpedo_Kinematics torpedo_Kinematics;
	}
}
