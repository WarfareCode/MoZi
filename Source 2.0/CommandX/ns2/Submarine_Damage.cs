using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns2
{
	// Token: 0x02000B37 RID: 2871
	public sealed class Submarine_Damage : ActiveUnit_Damage
	{
		// Token: 0x06005C64 RID: 23652 RVA: 0x002A89C4 File Offset: 0x002A6BC4
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			xmlWriter_0.WriteStartElement("Submarine_Damage");
			if (this.fireIntensityLevel > ActiveUnit_Damage.FireIntensityLevel.NoFire)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Fire";
				byte b = (byte)this.fireIntensityLevel;
				xmlWriter.WriteElementString(localName, b.ToString());
			}
			if (this.floodingIntensityLevel > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
			{
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "Flood";
				byte b = (byte)this.floodingIntensityLevel;
				xmlWriter2.WriteElementString(localName2, b.ToString());
			}
			xmlWriter_0.WriteElementString("TTNSDC", XmlConvert.ToString(this.TimeToNextSystemDamageCalculation));
			xmlWriter_0.WriteEndElement();
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x002A8A58 File Offset: 0x002A6C58
		public static Submarine_Damage Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Submarine_Damage result;
			try
			{
				Submarine_Damage submarine_Damage = new Submarine_Damage(ref activeUnit_1);
				submarine_Damage.activeUnit = activeUnit_1;
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
								if (Operators.CompareString(name, "Flood", false) != 0)
								{
									if (Operators.CompareString(name, "TTNSDC", false) == 0)
									{
										submarine_Damage.TimeToNextSystemDamageCalculation = Math.Abs(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									}
								}
								else
								{
									submarine_Damage.floodingIntensityLevel = (ActiveUnit_Damage.FloodingIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
								}
							}
							else
							{
								submarine_Damage.fireIntensityLevel = (ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
							}
						}
						else
						{
							submarine_Damage.activeUnit.SetInitialDP(Conversions.ToInteger(xmlNode.InnerText));
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
				result = submarine_Damage;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100828", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_Damage(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x000247CD File Offset: 0x000229CD
		public Submarine_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x002A8BF8 File Offset: 0x002A6DF8
		public override ActiveUnit_Damage.FireIntensityLevel GetFireIntensityLevel()
		{
			return base.GetFireIntensityLevel();
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x002A8C10 File Offset: 0x002A6E10
		public override void SetFireIntensityLevel(ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel_1)
		{
			bool flag = fireIntensityLevel_1 != this.GetFireIntensityLevel();
			base.SetFireIntensityLevel(fireIntensityLevel_1);
			if (flag && this.GetFireIntensityLevel() > ActiveUnit_Damage.FireIntensityLevel.Minor)
			{
				this.activeUnit.LogMessage(this.activeUnit.Name + " must urgently rise to periscope depth because of the fire onboard!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
			}
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x002A8C98 File Offset: 0x002A6E98
		public override ActiveUnit_Damage.FloodingIntensityLevel GetFloodingIntensityLevel()
		{
			return base.GetFloodingIntensityLevel();
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x002A8CB0 File Offset: 0x002A6EB0
		public override void vmethod_2(ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel_1)
		{
			bool flag = floodingIntensityLevel_1 != this.GetFloodingIntensityLevel();
			base.vmethod_2(floodingIntensityLevel_1);
			if (flag && this.GetFloodingIntensityLevel() > ActiveUnit_Damage.FloodingIntensityLevel.Minor)
			{
				this.activeUnit.LogMessage(this.activeUnit.Name + " must urgently rise to the surface because of the flooding onboard!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
			}
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x002A8D38 File Offset: 0x002A6F38
		public override void vmethod_11(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			try
			{
				if (weapon_0.m_Warheads.Length != 0)
				{
					Warhead warhead = weapon_0.m_Warheads[0];
					if (weapon_0.m_Warheads[0].warheadType == Warhead.WarheadType.Weapon)
					{
						warhead = weapon_0.m_Warheads[0].GetWeaponFromDP(weapon_0.m_Scenario).m_Warheads[0];
					}
					if (float_1 == 0f)
					{
						this.vmethod_10(weapon_0, geoPoint_0, float_1, float_2, ref activeUnit_1, nullable_0, nullable_1, nullable_2);
					}
					else if (warhead.method_13() || warhead.IsIncendiary())
					{
						if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
						{
							double value = 0.0;
							double value2 = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), ref value, ref value2, (double)(float_1 / 1852f), (double)float_2);
							nullable_0 = new double?(value2);
							nullable_1 = new double?(value);
						}
						if (Terrain.GetElevation(nullable_0.Value, nullable_1.Value, false) <= 0)
						{
							new WaterSplash(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, Explosion.smethod_1((double)warhead.DP, Weapon._DetonationMedium.Underwater));
						}
						if (Information.IsNothing(nullable_2))
						{
							if (weapon_0.IsTorpedo())
							{
								nullable_2 = new float?((float)((int)Math.Round((double)weapon_0.GetCurrentAltitude_ASL(false))));
							}
							else if (weapon_0.IsGuidedWeapon_RV_HGV())
							{
								nullable_2 = new float?((float)((int)Math.Round((double)(this.activeUnit.GetCurrentAltitude_ASL(false) + (float)weapon_0.method_188(this.activeUnit)))));
							}
							else if (weapon_0.GetWeaponType() != Weapon._WeaponType.DepthCharge && (weapon_0.m_Warheads[0].warheadType != Warhead.WarheadType.Weapon || weapon_0.m_Warheads[0].GetWeaponFromDP(this.activeUnit.m_Scenario).GetWeaponType() != Weapon._WeaponType.DepthCharge))
							{
								nullable_2 = new float?((float)Math.Max(0, (int)Terrain.GetElevation(nullable_0.Value, nullable_1.Value, false)));
							}
							else
							{
								nullable_2 = new float?((float)((int)Math.Round(Math.Max(-100.0, (double)Terrain.GetElevation(nullable_0.Value, nullable_1.Value, false) / 2.0))));
							}
						}
						new Explosion(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_0.GetCurrentHeading(), nullable_2.Value, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, weapon_0.GetFiringParent(), null, null, 0, 0, 0, 0f, 0);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100829", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x002A9084 File Offset: 0x002A7284
		public override void vmethod_8(ref float float_1, Warhead.WarheadType warheadType_0)
		{
			if (warheadType_0 != Warhead.WarheadType.SuperFrag)
			{
				switch (warheadType_0)
				{
				case Warhead.WarheadType.Cluster_AP:
					float_1 = (float)(0.5 * (double)float_1);
					return;
				case Warhead.WarheadType.Cluster_AT:
					break;
				case Warhead.WarheadType.Cluster_Penetrator:
					float_1 = (float)(0.9 * (double)float_1);
					return;
				default:
					if (warheadType_0 != Warhead.WarheadType.Cluster_SmartSubs)
					{
						return;
					}
					break;
				}
				float_1 = (float)(0.7 * (double)float_1);
			}
			else
			{
				float_1 = (float)(0.6 * (double)float_1);
			}
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x002A9108 File Offset: 0x002A7308
		public override void vmethod_12(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
			try
			{
				if (float_1 > 0f)
				{
					float num = float_1 / this.activeUnit.GetDamagePts(false);
					double num2 = (double)num;
					double num3 = (double)num;
					if (float_2 > 0f)
					{
						if (warheadType_0 <= Warhead.WarheadType.Torpedo)
						{
							if (warheadType_0 != Warhead.WarheadType.Incendiary)
							{
								if (warheadType_0 == Warhead.WarheadType.Torpedo)
								{
									num3 = 4.0 * num3;
								}
							}
							else
							{
								num2 = 8.0 * num2;
								num3 = 0.0;
							}
						}
						else if (warheadType_0 != Warhead.WarheadType.Chemical && warheadType_0 != Warhead.WarheadType.Biological)
						{
							if (warheadType_0 == Warhead.WarheadType.AntiElectrical)
							{
								num2 = 2.0 * num2;
							}
						}
						else
						{
							num2 = 0.0;
							num3 = 0.0;
						}
						num2 *= (double)float_2;
						num3 *= (double)float_2;
					}
					if (num2 >= 0.9)
					{
						num2 = 0.9;
					}
					if (num3 >= 0.9)
					{
						num3 = 0.9;
					}
					double num4 = num2;
					float num5 = (float)(num2 * 0.3);
					float num6 = (float)(num2 * 0.1);
					int num7 = GameGeneral.GetRandom().Next(1, 101);
					if ((float)num7 < num6)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Severe);
					}
					else if ((float)num7 < num5)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Major);
					}
					else if ((double)num7 < num4)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Minor);
					}
					double num8 = num3;
					float num9 = (float)(num2 * 0.3);
					float num10 = (float)(num2 * 0.1);
					int num11 = GameGeneral.GetRandom().Next(1, 101);
					if ((float)num11 < num10)
					{
						base.method_8(ActiveUnit_Damage.FloodingIntensityLevel.Severe);
					}
					else if ((float)num11 < num9)
					{
						base.method_8(ActiveUnit_Damage.FloodingIntensityLevel.Major);
					}
					else if ((double)num11 < num8)
					{
						base.method_8(ActiveUnit_Damage.FloodingIntensityLevel.Minor);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100830", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x002A9344 File Offset: 0x002A7544
		protected override void vmethod_10(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			try
			{
				double num = (double)this.activeUnit.GetDamagePts(false);
				if (weapon_0.m_Warheads[0].warheadType == Warhead.WarheadType.Weapon)
				{
					weapon_0 = weapon_0.m_Warheads[0].GetWeaponFromDP(weapon_0.m_Scenario);
				}
				Warhead warhead = weapon_0.m_Warheads[0];
				double num2 = 0.0;
				double num3;
				if (!warhead.HasNuclearWarhead(weapon_0.m_Scenario) && !warhead.method_18(weapon_0, this.activeUnit))
				{
					num3 = (double)(weapon_0.GetPenetration(GlobalVariables.ArmorRating.Light, this.activeUnit.GetTargetVisualSizeClass()) / 100f);
					if (((Submarine)this.activeUnit).submarineCode.DoubleHull)
					{
						num3 *= 0.5;
					}
					num2 = (double)weapon_0.method_259();
				}
				else
				{
					num3 = 0.0;
				}
				double num4 = 0.0;
				if (weapon_0.IsLaserWeapon())
				{
					num4 = 0.0;
					num2 = base.method_1(weapon_0, geoPoint_0);
				}
				if (num3 > 0.0)
				{
					this.activeUnit.m_Scenario.LogMessage(Conversions.ToString(num3 * 100.0) + "% penetration achieved", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					num4 = Math.Round(num3 * (double)warhead.DP, 2);
					if (num3 < 1.0 && warhead.method_13())
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), weapon_0.GetCurrentHeading(), this.activeUnit.GetCurrentAltitude_ASL(false), (float)((double)warhead.DP * (1.0 - num3)), warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, 0);
					}
					else if (!warhead.method_13() && !warhead.IsIncendiary())
					{
						this.activeUnit.m_Scenario.LogMessage("No armor penetration!", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					}
					else
					{
						if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
						{
							double value = 0.0;
							double value2 = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), ref value, ref value2, (double)GameGeneral.GetRandom().Next((int)Math.Round((double)(warhead.DP / 2f)), (int)Math.Round((double)(warhead.DP * 2f))), (double)GameGeneral.GetRandom().Next(0, 360));
							nullable_0 = new double?(value2);
							nullable_1 = new double?(value);
						}
						if (warhead.method_18(weapon_0, this.activeUnit))
						{
							new Explosion(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_0.GetCurrentHeading(), this.activeUnit.GetCurrentAltitude_ASL(false), warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, null, null, 0, 0, 0, 0f, 0);
						}
						else
						{
							new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), (double)weapon_0.GetCurrentHeading(), nullable_1.Value, nullable_0.Value, (float)this.activeUnit.GetLatitude(null), this.activeUnit.GetCurrentAltitude_ASL(false), warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, this.activeUnit, null, null, null, null, 0, 0, 0, 0f, 0);
						}
					}
				}
				else if (!warhead.method_13() && !warhead.IsIncendiary())
				{
					this.activeUnit.m_Scenario.LogMessage("No armor penetration!", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
				}
				else
				{
					if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
					{
						double value3 = 0.0;
						double value4 = 0.0;
						GeoPointGenerator.GetOtherGeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), ref value3, ref value4, (double)((float)((double)GameGeneral.GetRandom().Next((int)Math.Round((double)(warhead.DP / 5f)), (int)Math.Round((double)warhead.DP)) / 1852.0)), (double)GameGeneral.GetRandom().Next(0, 360));
						nullable_0 = new double?(value4);
						nullable_1 = new double?(value3);
					}
					if (warhead.method_18(weapon_0, this.activeUnit))
					{
						new Explosion(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_0.GetCurrentHeading(), this.activeUnit.GetCurrentAltitude_ASL(false), warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, null, null, 0, 0, 0, 0f, 0);
					}
					else
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, weapon_0.GetCurrentHeading(), this.activeUnit.GetCurrentAltitude_ASL(false), warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, this.activeUnit, null, null, null, null, 0, 0, 0, 0f, 0);
					}
				}
				if (Math.Round(num4 + num2, 1) > 0.0)
				{
					this.activeUnit.LogMessage(Misc.smethod_11(this.activeUnit.Name) + " has suffered weapon damage: " + Conversions.ToString((int)Math.Round(num4 + num2)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
				}
				this.activeUnit.SetDamagePts(false, (float)((double)this.activeUnit.GetDamagePts(false) - (num4 + num2)));
				base.method_4(warhead.warheadType, warhead.ExplosivesType, (double)((float)(num4 + num2)), (float)num, (float)num3, false, weapon_0.ARM_SpecifiedEmission.Key);
				base.method_5(false);
				base.method_6();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100831", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x002A9B6C File Offset: 0x002A7D6C
		public override void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			try
			{
				double num = (double)this.activeUnit.GetDamagePts(false);
				if (Math.Round((double)DamageYield, 1) > 0.0)
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
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100832", "");
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
