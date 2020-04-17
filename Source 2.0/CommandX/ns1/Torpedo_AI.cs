using System;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns1
{
	// Token: 0x02000AAC RID: 2732
	public sealed class Torpedo_AI : Weapon_AI
	{
		// Token: 0x060056A5 RID: 22181 RVA: 0x000278CA File Offset: 0x00025ACA
		public Torpedo_AI(Weapon weapon_1) : base(weapon_1)
		{
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x0025401C File Offset: 0x0025221C
		public override void Navigate(float elapsedTime_)
		{
			try
			{
				if (base.GetParentWeapon().GetBlindTime() <= 0f)
				{
					Weapon parentWeapon = base.GetParentWeapon();
					if (!base.method_59(ref parentWeapon))
					{
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							this.vmethod_28(elapsedTime_);
						}
						else if (base.GetParentWeapon().GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
						{
							if (base.GetParentWeapon().weaponCode.SearchPattern)
							{
								if (!Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit) && !this.GetPrimaryTarget().ActualUnit.IsFixedFacility())
								{
									if (base.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_2)
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.m_ActiveUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0) + 10f * elapsedTime_));
										if (this.m_ActiveUnit.GetKinematics().method_9())
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										}
									}
									else if (base.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_1)
									{
										base.method_91();
									}
									else
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
									}
								}
								else if (!base.GetParentWeapon().GetWeaponNavigator().HasPlottedCourse() && base.GetParentWeapon().weaponCode.SearchPattern && base.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_2)
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.m_ActiveUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0) + 10f * elapsedTime_));
									if (this.m_ActiveUnit.GetKinematics().method_9())
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
									}
									else
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
									}
								}
								else if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().ActualUnit.IsFixedFacility())
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetAzimuth(this.GetPrimaryTarget()));
								}
								else
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
								}
							}
							else if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								if (!Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
								{
									if (!base.GetParentWeapon().bPrimaryTargetAttackable)
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetHeadingToPredicatedTargetLocation(this.GetPrimaryTarget().ActualUnit));
									}
									else
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
									}
								}
								else
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetAzimuth(this.GetPrimaryTarget()));
								}
							}
							else
							{
								this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
							}
							this.vmethod_28(elapsedTime_);
						}
					}
					else
					{
						this.vmethod_28(elapsedTime_);
						if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint)
						{
							base.SetPrimaryTarget_LastKnown_Lat(this.GetPrimaryTarget().GetLatitude(null));
							base.SetPrimaryTarget_LastKnown_Lon(this.GetPrimaryTarget().GetLongitude(null));
							base.SetPrimaryTarget_LastKnown_Alt(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
						}
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint() && !Information.IsNothing(base.GetParentWeapon().GetDataLinkParent()))
						{
							if (!this.GetPrimaryTarget().IsFixedFacility())
							{
								Weapon._GuidanceMethod guidanceMethod = base.GetParentWeapon().GetGuidanceMethod();
								if (guidanceMethod <= Weapon._GuidanceMethod.const_5)
								{
									if (guidanceMethod != Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance && guidanceMethod != Weapon._GuidanceMethod.const_5)
									{
										goto IL_46B;
									}
								}
								else if (guidanceMethod != Weapon._GuidanceMethod.const_7 && guidanceMethod != Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance)
								{
									goto IL_46B;
								}
								((Weapon_Navigator)this.m_ActiveUnit.GetNavigator()).method_57((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), this.m_ActiveUnit.GetMaxThrottleAvailable()), !Information.IsNothing(base.GetParentWeapon().GetDataLinkParent()) && base.GetParentWeapon().GetDataLinkParent().IsAircraft);
							}
							IL_46B:
							this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							if (base.GetParentWeapon().GetHorizontalRange(this.GetPrimaryTarget().ActualUnit) < 2f)
							{
								this.method_110();
							}
						}
						else if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
						{
							this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
						}
						else if (Information.IsNothing(this.GetPrimaryTarget()) || this.GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint)
						{
							if (base.GetParentWeapon().GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
							{
								this.vmethod_18(elapsedTime_);
								if (base.GetParentWeapon().GetHorizontalRange(this.GetPrimaryTarget().ActualUnit) < 2f)
								{
									this.method_110();
								}
							}
							else if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								base.GetParentWeapon().GetWeaponNavigator().AddWaypoint(new Waypoint(this.GetPrimaryTarget().GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), Waypoint.WaypointType.WeaponTerminalPoint, Waypoint._Creator.const_1, Waypoint._Category.const_0));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 10398777441", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00254614 File Offset: 0x00252814
		private void method_110()
		{
			try
			{
				if (this.m_ActiveUnit.GetMaxThrottleAvailable() > ActiveUnit.Throttle.Cruise && this.m_ActiveUnit.GetThrottle() < ActiveUnit.Throttle.Full)
				{
					float num = this.m_ActiveUnit.GetFuelConsumption(ActiveUnit.Throttle.Cruise, null, null, null, false, false, false, false);
					if (num <= 0f)
					{
						num = 1f;
					}
					float num2 = this.m_ActiveUnit.GetFuelConsumption(ActiveUnit.Throttle.Full, null, null, null, false, false, false, false);
					if (num2 <= 0f)
					{
						num2 = 1f;
					}
					FuelRec[] fuelRecs = this.m_ActiveUnit.GetFuelRecs();
					float num3 = 0f;
					for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
					{
						FuelRec fuelRec = fuelRecs[i];
						num3 += fuelRec.CurrentQuantity;
					}
					float num4 = 0.75f;
					num3 = num3 * (num / num2) * num4;
					if (this.m_ActiveUnit.method_49(this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), (float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Full), this.m_ActiveUnit.GetCurrentHeading()), this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget())) < num3)
					{
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100972", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x002547D4 File Offset: 0x002529D4
		public override void vmethod_28(float float_3)
		{
			if (!base.GetParentWeapon().GetWeaponNavigator().HasPlottedCourse())
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					Weapon weapon = base.GetParentWeapon();
					if (!base.method_59(ref weapon) && base.GetParentWeapon().weaponCode.SearchPattern && base.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_2)
					{
						if (this.GetPrimaryTarget().Altitude_Known && (double)base.GetParentWeapon().GetCurrentAltitude_ASL(false) > (double)this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) * 0.7)
						{
							base.GetParentWeapon().SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
						}
						else if (!this.GetPrimaryTarget().Altitude_Known && base.GetParentWeapon().GetCurrentAltitude_ASL(false) > -40f)
						{
							base.GetParentWeapon().SetDesiredAltitude(-40f);
						}
						else
						{
							(weapon = base.GetParentWeapon()).SetDesiredAltitude(weapon.GetDesiredAltitude() + -2f * float_3);
						}
					}
					else if (this.GetPrimaryTarget().Altitude_Known)
					{
						base.GetParentWeapon().SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
					}
				}
				else if (base.GetParentWeapon().weaponCode.SearchPattern && base.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_2)
				{
					Weapon weapon = null;
					(weapon = base.GetParentWeapon()).SetDesiredAltitude(weapon.GetDesiredAltitude() + -2f * float_3);
				}
			}
			if (this.m_ActiveUnit.GetDesiredAltitude() > -10f)
			{
				base.GetParentWeapon().SetDesiredAltitude(-10f);
			}
		}
	}
}
