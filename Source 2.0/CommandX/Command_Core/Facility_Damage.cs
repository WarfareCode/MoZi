using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns3;

namespace Command_Core
{
	// Token: 设施毁伤
	public sealed class Facility_Damage : ActiveUnit_Damage
	{
		// Token: 0x060057C8 RID: 22472 RVA: 0x00267A04 File Offset: 0x00265C04
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			xmlWriter_0.WriteStartElement("Damage");
			if (this.fireIntensityLevel > ActiveUnit_Damage.FireIntensityLevel.NoFire)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Fire";
				byte fireIntensityLevel = (byte)this.fireIntensityLevel;
				xmlWriter.WriteElementString(localName, fireIntensityLevel.ToString());
			}
			xmlWriter_0.WriteElementString("TTNSDC", XmlConvert.ToString(this.TimeToNextSystemDamageCalculation));
			xmlWriter_0.WriteEndElement();
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00267A68 File Offset: 0x00265C68
		public static Facility_Damage smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Facility_Damage result;
			try
			{
				Facility_Damage facility_Damage = new Facility_Damage(ref activeUnit_1);
				facility_Damage.activeUnit = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "InitialDP", false) != 0)
						{
							if (Operators.CompareString(name, "Fire", false) != 0)
							{
								if (Operators.CompareString(name, "TTNSDC", false) == 0)
								{
									facility_Damage.TimeToNextSystemDamageCalculation = Math.Abs(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								}
							}
							else
							{
								facility_Damage.fireIntensityLevel = (ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
							}
						}
						else
						{
							facility_Damage.activeUnit.SetInitialDP(Conversions.ToInteger(xmlNode.InnerText));
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = facility_Damage;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100553", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Facility_Damage(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x000247CD File Offset: 0x000229CD
		public Facility_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00267BC8 File Offset: 0x00265DC8
		public override void vmethod_12(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
			try
			{
				if (float_1 > 0f)
				{
					double num = (double)(float_1 / this.activeUnit.GetDamagePts(false));
					if (float_2 > 0f)
					{
						if (warheadType_0 <= Warhead.WarheadType.Chemical)
						{
							if (warheadType_0 == Warhead.WarheadType.Incendiary)
							{
								num = 8.0 * num;
								goto IL_8B;
							}
							if (warheadType_0 != Warhead.WarheadType.Chemical)
							{
								goto IL_8B;
							}
						}
						else if (warheadType_0 != Warhead.WarheadType.Biological)
						{
							if (warheadType_0 == Warhead.WarheadType.AntiElectrical)
							{
								num = 2.0 * num;
								goto IL_8B;
							}
							goto IL_8B;
						}
						num = 0.0;
						IL_8B:
						num *= (double)float_2;
					}
					if (num >= 0.9)
					{
						num = 0.9;
					}
					double num2 = num;
					float num3 = (float)(num * 0.3);
					float num4 = (float)(num * 0.1);
					double num5 = GameGeneral.GetRandom().NextDouble();
					if (num5 < (double)num4)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Severe);
					}
					else if (num5 < (double)num3)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Major);
					}
					else if (num5 < num2)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Minor);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100554", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00267D3C File Offset: 0x00265F3C
		public override void vmethod_8(ref float float_1, Warhead.WarheadType warheadType_0)
		{
			if (warheadType_0 != Warhead.WarheadType.SuperFrag)
			{
				switch (warheadType_0)
				{
				case Warhead.WarheadType.Cluster_AP:
				{
					GlobalVariables.ArmorRating armorGeneral = ((Facility)this.activeUnit).ArmorGeneral;
					if (armorGeneral == GlobalVariables.ArmorRating.None)
					{
						return;
					}
					if (armorGeneral == GlobalVariables.ArmorRating.Light)
					{
						float_1 = (float)(0.5 * (double)float_1);
						return;
					}
					float_1 = 0f;
					return;
				}
				case Warhead.WarheadType.Cluster_AT:
					break;
				case Warhead.WarheadType.Cluster_Penetrator:
				{
					GlobalVariables.ArmorRating armorGeneral2 = ((Facility)this.activeUnit).ArmorGeneral;
					if (armorGeneral2 == GlobalVariables.ArmorRating.None)
					{
						float_1 = 3f * float_1;
						return;
					}
					switch (armorGeneral2)
					{
					case GlobalVariables.ArmorRating.Light:
						float_1 = 2f * float_1;
						return;
					case GlobalVariables.ArmorRating.Medium:
						float_1 = float_1;
						return;
					case GlobalVariables.ArmorRating.Heavy:
						float_1 = (float)(0.75 * (double)float_1);
						return;
					case GlobalVariables.ArmorRating.Special:
						float_1 = (float)(0.5 * (double)float_1);
						return;
					default:
						return;
					}
					break;
				}
				default:
					if (warheadType_0 != Warhead.WarheadType.Cluster_SmartSubs)
					{
						return;
					}
					break;
				}
				GlobalVariables.ArmorRating armorGeneral3 = ((Facility)this.activeUnit).ArmorGeneral;
				if (armorGeneral3 != GlobalVariables.ArmorRating.None)
				{
					if (armorGeneral3 == GlobalVariables.ArmorRating.Light)
					{
						float_1 = (float)(0.7 * (double)float_1);
					}
					else if (armorGeneral3 != GlobalVariables.ArmorRating.Medium)
					{
						float_1 = 0f;
					}
					else
					{
						float_1 = (float)(0.5 * (double)float_1);
					}
				}
			}
			else
			{
				GlobalVariables.ArmorRating armorGeneral4 = ((Facility)this.activeUnit).ArmorGeneral;
				if (armorGeneral4 != GlobalVariables.ArmorRating.None && armorGeneral4 != GlobalVariables.ArmorRating.Light)
				{
					float_1 = 0f;
				}
			}
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00267EF0 File Offset: 0x002660F0
		public override void vmethod_9(ref float float_1)
		{
			GlobalVariables.ArmorRating armorGeneral = ((Facility)this.activeUnit).ArmorGeneral;
			if (armorGeneral != GlobalVariables.ArmorRating.None)
			{
				switch (armorGeneral)
				{
				case GlobalVariables.ArmorRating.Light:
					float_1 = (float)(0.9 * (double)float_1);
					break;
				case GlobalVariables.ArmorRating.Medium:
					float_1 = (float)(0.6 * (double)float_1);
					break;
				case GlobalVariables.ArmorRating.Heavy:
					float_1 = (float)(0.3 * (double)float_1);
					break;
				case GlobalVariables.ArmorRating.Special:
					float_1 = (float)(0.1 * (double)float_1);
					break;
				}
			}
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00267F80 File Offset: 0x00266180
		protected override void vmethod_10(Weapon weapon_, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			try
			{
				double num = (double)this.activeUnit.GetDamagePts(false);
				Warhead warhead = weapon_.m_Warheads[0];
				double num2 = 0.0;
				double num3;
				if (!warhead.HasNuclearWarhead(weapon_.m_Scenario) && !warhead.method_18(weapon_, this.activeUnit) && !warhead.IsIncendiary())
				{
					num3 = (double)(weapon_.GetPenetration(((Facility)this.activeUnit).ArmorGeneral, this.activeUnit.GetTargetVisualSizeClass()) / 100f);
					num2 = (double)weapon_.method_259();
				}
				else
				{
					num3 = 0.0;
				}
				double num4 = 0.0;
				if (weapon_.IsLaserWeapon())
				{
					num4 = 0.0;
					num2 = base.method_1(weapon_, geoPoint_0);
				}
				float theAltitude;
				if (this.activeUnit.GetAltitude_AGL() >= 0f)
				{
					if (weapon_.m_Warheads.Length > 0)
					{
						theAltitude = this.activeUnit.GetCurrentAltitude_ASL(false) + (float)weapon_.method_188(this.activeUnit);
					}
					else
					{
						theAltitude = this.activeUnit.GetCurrentAltitude_ASL(false);
					}
				}
				else
				{
					theAltitude = this.activeUnit.GetCurrentAltitude_ASL(false);
				}
				if (((Facility)this.activeUnit).Category == Facility._FacilityCategory.Building_Underground && weapon_.m_Warheads[0].warheadType == Warhead.WarheadType.HardTargetPenetrator)
				{
					theAltitude = (float)(this.activeUnit.GetTerrainElevation(false, false, false) - 20);
				}
				bool flag = false;
				if (this.activeUnit.GetAirFacilities().Where(Facility_Damage.AirFacilityFunc0).Count<AirFacility>() > 0)
				{
					flag = (this.activeUnit.GetAirFacilities().Length > 0 && this.activeUnit.GetAirFacilities().Length == this.activeUnit.GetAirFacilities().Where(Facility_Damage.AirFacilityFunc1).Count<AirFacility>());
				}
				if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
				{
					double value = 0.0;
					double value2 = 0.0;
					Math2.GetAnotherGeopoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), ref value, ref value2, float_1 / 1852f, float_2);
					nullable_0 = new double?(value2);
					nullable_1 = new double?(value);
				}
				if (num3 > 0.0)
				{
					this.activeUnit.m_Scenario.LogMessage(Conversions.ToString(num3 * 100.0) + "% penetration achieved", LoggedMessage.MessageType.WeaponDamage, 20, weapon_.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					if (flag)
					{
						if (num3 < 0.6 && warhead.DP < 100f)
						{
							num4 = Math.Round(num3 * (double)warhead.DP / 8.0, 2);
						}
						else if (num3 < 0.4 && warhead.DP < 250f)
						{
							num4 = Math.Round(num3 * (double)warhead.DP / 2.0, 2);
						}
						else if (num3 < 0.2 && warhead.DP < 500f)
						{
							num4 = Math.Round(num3 * (double)warhead.DP, 2);
						}
						else
						{
							num4 = Math.Round(num3 * 2.0 * (double)warhead.DP, 2);
						}
					}
					else if (warhead.method_13())
					{
						num4 = Math.Round(num3 * 2.0 * (double)warhead.DP, 2);
					}
					else
					{
						num4 = Math.Round(num3 * (double)warhead.DP, 2);
					}
					if (num3 < 1.0 && warhead.method_13())
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), theAltitude, (float)((double)warhead.DP * (1.0 - num3)), warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, weapon_.ARM_SpecifiedEmission.Key);
					}
					else if (((Facility)this.activeUnit).ArmorGeneral == GlobalVariables.ArmorRating.None && warhead.method_13())
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), theAltitude, (float)((double)warhead.DP * num3 * 0.25), warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, weapon_.ARM_SpecifiedEmission.Key);
					}
					else
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), theAltitude, 0f, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, weapon_.ARM_SpecifiedEmission.Key);
					}
				}
				else if (warhead.method_13())
				{
					if (warhead.method_18(weapon_, this.activeUnit))
					{
						new Explosion(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), (float)this.activeUnit.GetTerrainElevation(false, false, false), warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, null, null, 0, 0, 0, 0f, weapon_.ARM_SpecifiedEmission.Key);
					}
					else
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), theAltitude, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, this.activeUnit, null, null, null, null, 0, 0, 0, 0f, weapon_.ARM_SpecifiedEmission.Key);
					}
				}
				else
				{
					this.activeUnit.m_Scenario.LogMessage("没有穿甲弹!", LoggedMessage.MessageType.WeaponDamage, 20, weapon_.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), theAltitude, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, weapon_.ARM_SpecifiedEmission.Key);
				}
				if (Math.Round(num4 + num2, 1) > 0.0)
				{
					this.activeUnit.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "遭受武器毁伤: " + Conversions.ToString(Math.Round(num4 + num2, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
				}
				this.activeUnit.SetDamagePts(false, (float)((double)this.activeUnit.GetDamagePts(false) - (num4 + num2)));
				base.method_4(warhead.warheadType, warhead.ExplosivesType, (double)((float)(num4 + num2)), (float)num, (float)num3, false, weapon_.ARM_SpecifiedEmission.Key);
				base.method_5(false);
				base.method_6();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100555", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x002688CC File Offset: 0x00266ACC
		private void method_14(Weapon weapon_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			try
			{
				bool flag = false;
				if (string.IsNullOrEmpty(string_0))
				{
					IEnumerable<Mount> enumerable = ((Facility)this.activeUnit).m_Mounts.Where(Facility_Damage.MountFunc2);
					if (weapon_0.m_Warheads.Length > 1)
					{
						int num = weapon_0.m_Warheads.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (enumerable.Count<Mount>() > 0)
							{
								int num2 = GameGeneral.GetRandom().Next(1, enumerable.Count<Mount>());
								enumerable.ElementAtOrDefault(num2 - 1).method_41(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
								if (!Information.IsNothing(enumerable) && enumerable.Count<Mount>() > 0 && enumerable.Count<Mount>() >= num2)
								{
									string_0 = enumerable.ElementAtOrDefault(num2 - 1).GetGuid();
								}
								flag = true;
							}
							if (weapon_0.m_Warheads.Length > 0)
							{
								ScenarioArrayUtil.RemoveWarhead(ref weapon_0.m_Warheads, weapon_0.m_Warheads[0]);
							}
							enumerable = ((Facility)this.activeUnit).m_Mounts.Where(Facility_Damage.MountFunc3);
						}
					}
					else if (enumerable.Count<Mount>() > 0)
					{
						int num3 = GameGeneral.GetRandom().Next(1, enumerable.Count<Mount>());
						enumerable.ElementAtOrDefault(num3 - 1).method_41(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
						if (!Information.IsNothing(enumerable) && enumerable.Count<Mount>() > 0 && enumerable.Count<Mount>() >= num3)
						{
							string_0 = enumerable.ElementAtOrDefault(num3 - 1).GetGuid();
						}
						flag = true;
					}
				}
				else
				{
					Facility_Damage.MountMatcher mountMatcher = new Facility_Damage.MountMatcher(null);
					mountMatcher.strMountID = string_0;
					IEnumerable<Mount> enumerable = ((Facility)this.activeUnit).m_Mounts.Where(new Func<Mount, bool>(mountMatcher.IsSameWithMe));
					if (enumerable.Count<Mount>() > 0)
					{
						enumerable.ElementAtOrDefault(0).method_41(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
						flag = true;
					}
				}
				if (!flag)
				{
					if (Information.IsNothing(nullable_0))
					{
						nullable_0 = new double?(this.activeUnit.GetLatitude(null));
					}
					if (Information.IsNothing(nullable_1))
					{
						nullable_0 = new double?(this.activeUnit.GetLongitude(null));
					}
					if (Information.IsNothing(nullable_2))
					{
						nullable_0 = new double?((double)this.activeUnit.GetTerrainElevation(true, false, false));
					}
					base.method_2(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100556", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00268BB4 File Offset: 0x00266DB4
		public override void vmethod_11(Weapon theARM_, GeoPoint geoPoint_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			Facility_Damage.ARMTargetMatcher aRMTargetMatcher = new Facility_Damage.ARMTargetMatcher(null);
			aRMTargetMatcher.facility_Damage = this;
			aRMTargetMatcher.ARM = theARM_;
			try
			{
				bool mountsAreAimpoints;
				if (mountsAreAimpoints = ((Facility)this.activeUnit).MountsAreAimpoints)
				{
					if (mountsAreAimpoints)
					{
						float num = (float)(100.0 * (1.0 - (double)this.activeUnit.m_Mounts.Where(Facility_Damage.MountFunc4).Count<Mount>() / (double)this.activeUnit.m_Mounts.Length));
						if (aRMTargetMatcher.ARM.weaponTarget.IsRadar)
						{
							IEnumerable<Mount> source = this.activeUnit.m_Mounts.Where(new Func<Mount, bool>(aRMTargetMatcher.IsMountHasTargetRadarsForMe));
							if (source.Count<Mount>() > 0)
							{
								IEnumerable<Mount> source2 = source.Where(Facility_Damage.MountFunc5);
								if (source2.Count<Mount>() > 0)
								{
									if (source2.Count<Mount>() == 1)
									{
										source2.ElementAtOrDefault(0).method_41(aRMTargetMatcher.ARM, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
									}
									else
									{
										int num2 = GameGeneral.GetRandom().Next(1, source2.Count<Mount>());
										source2.ElementAtOrDefault(num2 - 1).method_41(aRMTargetMatcher.ARM, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
									}
								}
								else
								{
									int num3 = GameGeneral.GetRandom().Next(1, source.Count<Mount>());
									source.ElementAtOrDefault(num3 - 1).method_41(aRMTargetMatcher.ARM, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
								}
							}
							else
							{
								this.method_14(aRMTargetMatcher.ARM, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref string_0);
							}
						}
						else
						{
							this.method_14(aRMTargetMatcher.ARM, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref string_0);
						}
						float num4 = (float)(100.0 * (1.0 - (double)this.activeUnit.m_Mounts.Where(Facility_Damage.MountFunc6).Count<Mount>() / (double)this.activeUnit.m_Mounts.Length));
						if (num4 != num)
						{
							List<EventTrigger> list = new List<EventTrigger>();
							foreach (EventTrigger current in this.activeUnit.m_Scenario.GetEventTriggers().Values)
							{
								if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitDamaged && ((EventTrigger_UnitDamaged)current).method_11(this.activeUnit, num, num4))
								{
									list.Add(current);
								}
							}
							this.activeUnit.m_Scenario.TriggerEvents(list);
						}
						if (((Facility)this.activeUnit).m_Mounts.Where(Facility_Damage.MountFunc7).Count<Mount>() == 0)
						{
							this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
						}
					}
				}
				else
				{
					base.vmethod_11(aRMTargetMatcher.ARM, geoPoint_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref string_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100557", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00268F14 File Offset: 0x00267114
		public override void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			try
			{
				if (((Facility)this.activeUnit).ArmorGeneral <= GlobalVariables.ArmorRating.None)
				{
					double num = (double)this.activeUnit.GetDamagePts(false);
					if (DamageYield > 0f)
					{
						new WeaponImpact(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), this.activeUnit.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
						this.activeUnit.LogMessage(this.activeUnit.Name + " has suffered fragmentation damage: " + Conversions.ToString(Math.Round((double)DamageYield, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						this.activeUnit.SetDamagePts(false, this.activeUnit.GetDamagePts(false) - DamageYield);
						base.method_4(Warhead.WarheadType.Fragmentation, Warhead._ExplosivesType.const_31, (double)DamageYield, (float)num, 0f, true, 0);
						base.method_5(true);
						base.method_6();
						if (this.activeUnit.GetDamagePts(false) <= 0f)
						{
							this.activeUnit.SetDamagePts(false, 0f);
							this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100558", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04002B31 RID: 11057
		public static Func<AirFacility, bool> AirFacilityFunc0 = (AirFacility airFacility_0) => airFacility_0.method_35();

		// Token: 0x04002B32 RID: 11058
		public new static Func<AirFacility, bool> AirFacilityFunc1 = (AirFacility airFacility_0) => airFacility_0.method_35();

		// Token: 0x04002B33 RID: 11059
		public static Func<Mount, bool> MountFunc2 = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002B34 RID: 11060
		public static Func<Mount, bool> MountFunc3 = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002B35 RID: 11061
		public static Func<Mount, bool> MountFunc4 = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002B36 RID: 11062
		public static Func<Mount, bool> MountFunc5 = (Mount mount_0) => mount_0.HasActiveSensor();

		// Token: 0x04002B37 RID: 11063
		public static Func<Mount, bool> MountFunc6 = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002B38 RID: 11064
		public static Func<Mount, bool> MountFunc7 = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x02000ABC RID: 2748
		[CompilerGenerated]
		public sealed class MountMatcher
		{
			// Token: 0x060057DB RID: 22491 RVA: 0x00027D3A File Offset: 0x00025F3A
			public MountMatcher(Facility_Damage.MountMatcher MountMatcher_)
			{
				if (MountMatcher_ != null)
				{
					this.strMountID = MountMatcher_.strMountID;
				}
			}

			// Token: 0x060057DC RID: 22492 RVA: 0x00027D54 File Offset: 0x00025F54
			internal bool IsSameWithMe(Mount mount_)
			{
				return Operators.CompareString(mount_.GetGuid(), this.strMountID, false) == 0;
			}

			// Token: 0x04002B41 RID: 11073
			public string strMountID;
		}

		// Token: 0x02000ABD RID: 2749
		[CompilerGenerated]
		public sealed class ARMTargetMatcher
		{
			// Token: 0x060057DD RID: 22493 RVA: 0x00027D6B File Offset: 0x00025F6B
			public ARMTargetMatcher(Facility_Damage.ARMTargetMatcher ARMTargetMatcher_)
			{
				if (ARMTargetMatcher_ != null)
				{
					this.ARM = ARMTargetMatcher_.ARM;
				}
			}

			// Token: 0x060057DE RID: 22494 RVA: 0x00027D85 File Offset: 0x00025F85
			internal bool IsMountHasTargetRadarsForMe(Mount theMount_)
			{
				return this.facility_Damage.IsMountHasSensorsInEmissionContainer(theMount_, this.ARM.ARM_SpecifiedEmission);
			}

			// Token: 0x04002B42 RID: 11074
			public Weapon ARM;

			// Token: 0x04002B43 RID: 11075
			public Facility_Damage facility_Damage;
		}
	}
}
