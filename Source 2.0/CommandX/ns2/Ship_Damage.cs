using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns2
{
	// Token: 0x02000B75 RID: 2933
	public sealed class Ship_Damage : ActiveUnit_Damage
	{
		// Token: 0x06006114 RID: 24852 RVA: 0x002E62DC File Offset: 0x002E44DC
		private Ship GetParentPlatform()
		{
			if (Information.IsNothing(this.ParentPlatform))
			{
				this.ParentPlatform = (Ship)this.activeUnit;
			}
			return this.ParentPlatform;
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x002E6314 File Offset: 0x002E4514
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Ship_Damage");
				if (this.GetFireIntensityLevel() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
				{
					xmlWriter_0.WriteElementString("Fire", ((byte)this.GetFireIntensityLevel()).ToString());
				}
				if (this.GetFloodingIntensityLevel() > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
				{
					xmlWriter_0.WriteElementString("Flood", ((byte)this.GetFloodingIntensityLevel()).ToString());
				}
				xmlWriter_0.WriteElementString("TTNSDC", XmlConvert.ToString(this.TimeToNextSystemDamageCalculation));
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100783", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x002E63EC File Offset: 0x002E45EC
		public static Ship_Damage Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Ship_Damage result = null;
			try
			{
				Ship_Damage ship_Damage = new Ship_Damage(ref activeUnit_1);
				ship_Damage.activeUnit = activeUnit_1;
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
										ship_Damage.TimeToNextSystemDamageCalculation = Math.Abs(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									}
								}
								else
								{
									ship_Damage.floodingIntensityLevel = (ActiveUnit_Damage.FloodingIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
								}
							}
							else
							{
								ship_Damage.fireIntensityLevel = (ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
							}
						}
						else
						{
							ship_Damage.activeUnit.SetInitialDP(Conversions.ToInteger(xmlNode.InnerText));
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
				result = ship_Damage;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100784", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x000247CD File Offset: 0x000229CD
		public Ship_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x002E6588 File Offset: 0x002E4788
		public override void vmethod_8(ref float float_1, Warhead.WarheadType warheadType_)
		{
			switch (warheadType_)
			{
			case Warhead.WarheadType.Cluster_AP:
			{
				GlobalVariables.ArmorRating armorBelt = ((Ship)this.activeUnit).ArmorBelt;
				if (armorBelt == GlobalVariables.ArmorRating.None)
				{
					return;
				}
				if (armorBelt == GlobalVariables.ArmorRating.Light)
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
				GlobalVariables.ArmorRating armorBelt2 = ((Ship)this.activeUnit).ArmorBelt;
				if (armorBelt2 == GlobalVariables.ArmorRating.None)
				{
					return;
				}
				switch (armorBelt2)
				{
				case GlobalVariables.ArmorRating.Light:
					float_1 = (float)(0.9 * (double)float_1);
					return;
				case GlobalVariables.ArmorRating.Medium:
					float_1 = (float)(0.7 * (double)float_1);
					return;
				case GlobalVariables.ArmorRating.Heavy:
					float_1 = (float)(0.5 * (double)float_1);
					return;
				case GlobalVariables.ArmorRating.Special:
					float_1 = (float)(0.2 * (double)float_1);
					return;
				default:
					return;
				}
				break;
			}
			default:
				if (warheadType_ != Warhead.WarheadType.Cluster_SmartSubs)
				{
					return;
				}
				break;
			}
			GlobalVariables.ArmorRating armorBelt3 = ((Ship)this.activeUnit).ArmorBelt;
			if (armorBelt3 != GlobalVariables.ArmorRating.None)
			{
				if (armorBelt3 == GlobalVariables.ArmorRating.Light)
				{
					float_1 = (float)(0.7 * (double)float_1);
				}
				else if (armorBelt3 != GlobalVariables.ArmorRating.Medium)
				{
					float_1 = 0f;
				}
				else
				{
					float_1 = (float)(0.5 * (double)float_1);
				}
			}
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x002E6700 File Offset: 0x002E4900
		public override void vmethod_9(ref float float_1)
		{
			GlobalVariables.ArmorRating armorBelt = ((Ship)this.activeUnit).ArmorBelt;
			if (armorBelt != GlobalVariables.ArmorRating.None)
			{
				switch (armorBelt)
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

		// Token: 0x0600611A RID: 24858 RVA: 0x002E6790 File Offset: 0x002E4990
		protected override void vmethod_10(Weapon theARM_, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			Ship_Damage.ARMTargetEmmiterMatcher aRMTargetEmmiterMatcher = new Ship_Damage.ARMTargetEmmiterMatcher(null);
			aRMTargetEmmiterMatcher.theARM = theARM_;
			try
			{
				Ship_Damage.WarheadMatcher warheadMatcher = new Ship_Damage.WarheadMatcher(null);
				float damagePts = this.activeUnit.GetDamagePts(false);
				warheadMatcher.warhead = aRMTargetEmmiterMatcher.theARM.m_Warheads[0];
				float num = 0f;
				double num2 = 0.0;
				if (!warheadMatcher.warhead.HasNuclearWarhead(aRMTargetEmmiterMatcher.theARM.m_Scenario) && !warheadMatcher.warhead.method_18(aRMTargetEmmiterMatcher.theARM, this.GetParentPlatform()))
				{
					num = aRMTargetEmmiterMatcher.theARM.GetPenetration(((Ship)this.activeUnit).ArmorBelt, this.activeUnit.GetTargetVisualSizeClass()) / 100f;
					num2 = (double)aRMTargetEmmiterMatcher.theARM.method_259();
				}
				else
				{
					num = 0f;
					num2 = 0.0;
				}
				double num3 = 0.0;
				if (aRMTargetEmmiterMatcher.theARM.IsLaserWeapon())
				{
					num3 = 0.0;
					num2 = base.method_1(aRMTargetEmmiterMatcher.theARM, geoPoint_0);
				}
				float theAltitude;
				if (aRMTargetEmmiterMatcher.theARM.IsGuidedWeapon_RV_HGV())
				{
					theAltitude = (float)aRMTargetEmmiterMatcher.theARM.method_188(this.GetParentPlatform());
				}
				else
				{
					theAltitude = 0f;
				}
				float num4 = warheadMatcher.warhead.DP;
				List<Warhead> list = aRMTargetEmmiterMatcher.theARM.m_Warheads.Where(new Func<Warhead, bool>(warheadMatcher.IsNotSameToMe)).ToList<Warhead>();
				foreach (Warhead current in list)
				{
					Weapon weaponFromDP = current.GetWeaponFromDP(aRMTargetEmmiterMatcher.theARM.m_Scenario);
					if (!Information.IsNothing(weaponFromDP) && weaponFromDP.m_Warheads.Length > 0)
					{
						num4 += current.GetWeaponFromDP(aRMTargetEmmiterMatcher.theARM.m_Scenario).m_Warheads[0].DP;
					}
				}
				if (aRMTargetEmmiterMatcher.theARM.weaponTarget.IsRadar && !Information.IsNothing(aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission))
				{
					IEnumerable<Sensor> source = this.activeUnit.GetAllNoneMCMSensors().Where(new Func<Sensor, bool>(aRMTargetEmmiterMatcher.HasSensorMySpecifiedEmission));
					if (source.Count<Sensor>() > 0)
					{
						int index = GameGeneral.GetRandom().Next(0, source.Count<Sensor>());
						base.method_7(aRMTargetEmmiterMatcher.theARM.m_Warheads[0].warheadType, aRMTargetEmmiterMatcher.theARM.m_Warheads[0].ExplosivesType, source.ElementAtOrDefault(index), (double)num4, damagePts, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
					}
				}
				if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
				{
					double value = 0.0;
					double value2 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), ref value, ref value2, (double)(float_1 / 1852f), (double)float_2);
					nullable_0 = new double?(value2);
					nullable_1 = new double?(value);
				}
				if (num > 0f)
				{
					this.activeUnit.m_Scenario.LogMessage(Conversions.ToString(num * 100f) + "% penetration achieved", LoggedMessage.MessageType.WeaponDamage, 20, aRMTargetEmmiterMatcher.theARM.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					if (warheadMatcher.warhead.method_13())
					{
						if (warheadMatcher.warhead.warheadType == Warhead.WarheadType.Torpedo)
						{
							num3 = (double)(num4 * 4f);
						}
						else
						{
							num3 = (double)((float)Math.Round((double)(num * 2f * num4), 2));
						}
					}
					else
					{
						num3 = (double)((float)Math.Round((double)(num * num4), 2));
					}
					if (num < 1f && warheadMatcher.warhead.method_13())
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, aRMTargetEmmiterMatcher.theARM.GetCurrentHeading(), theAltitude, num4 * (1f - num), warheadMatcher.warhead.DP, warheadMatcher.warhead.warheadType, warheadMatcher.warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
					}
					else if (((Ship)this.activeUnit).ArmorBulkheads == GlobalVariables.ArmorRating.None && warheadMatcher.warhead.method_13())
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, aRMTargetEmmiterMatcher.theARM.GetCurrentHeading(), theAltitude, (float)((double)(num4 * num) * 0.25), warheadMatcher.warhead.DP, warheadMatcher.warhead.warheadType, warheadMatcher.warhead.ExplosivesType, null, null, this.activeUnit, null, null, 0, 0, 0, 0f, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
					}
				}
				else if (warheadMatcher.warhead.method_13())
				{
					if (warheadMatcher.warhead.method_18(aRMTargetEmmiterMatcher.theARM, this.GetParentPlatform()))
					{
						new Explosion(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, aRMTargetEmmiterMatcher.theARM.GetCurrentHeading(), theAltitude, num4, warheadMatcher.warhead.DP, warheadMatcher.warhead.warheadType, warheadMatcher.warhead.ExplosivesType, null, null, null, null, null, 0, 0, 0, 0f, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
					}
					else
					{
						new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, aRMTargetEmmiterMatcher.theARM.GetCurrentHeading(), theAltitude, num4, warheadMatcher.warhead.DP, warheadMatcher.warhead.warheadType, warheadMatcher.warhead.ExplosivesType, this.activeUnit, null, null, null, null, 0, 0, 0, 0f, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
					}
				}
				else
				{
					this.activeUnit.m_Scenario.LogMessage("No armor penetration", LoggedMessage.MessageType.WeaponDamage, 20, aRMTargetEmmiterMatcher.theARM.GetGuid(), null, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					new Explosion(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), nullable_1.Value, nullable_0.Value, aRMTargetEmmiterMatcher.theARM.GetCurrentHeading(), theAltitude, num4, warheadMatcher.warhead.DP, warheadMatcher.warhead.warheadType, warheadMatcher.warhead.ExplosivesType, this.activeUnit, null, null, null, null, 0, 0, 0, 0f, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
				}
				if (Math.Round(num3 + num2, 1) > 0.0)
				{
					this.activeUnit.LogMessage(Misc.smethod_11(this.activeUnit.Name) + " has suffered weapon damage: " + Conversions.ToString(Math.Round(num3 + num2, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
				}
				this.activeUnit.SetDamagePts(false, (float)((double)this.activeUnit.GetDamagePts(false) - (num3 + num2)));
				base.method_4(warheadMatcher.warhead.warheadType, warheadMatcher.warhead.ExplosivesType, num3 + num2, damagePts, num, false, aRMTargetEmmiterMatcher.theARM.ARM_SpecifiedEmission.Key);
				base.method_5(false);
				base.method_6();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100785", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x002E70F0 File Offset: 0x002E52F0
		public override void vmethod_12(float theDamage_, Warhead.WarheadType warheadType_, float thePenetration_)
		{
			try
			{
				if (theDamage_ > 0f)
				{
					float num = theDamage_ / this.activeUnit.GetDamagePts(false);
					double num2 = (double)num;
					double num3 = (double)num;
					if (thePenetration_ > 0f)
					{
						if (warheadType_ <= Warhead.WarheadType.Torpedo)
						{
							if (warheadType_ != Warhead.WarheadType.Incendiary)
							{
								if (warheadType_ == Warhead.WarheadType.Torpedo)
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
						else if (warheadType_ != Warhead.WarheadType.Chemical && warheadType_ != Warhead.WarheadType.Biological)
						{
							if (warheadType_ == Warhead.WarheadType.AntiElectrical)
							{
								num2 = 2.0 * num2;
							}
						}
						else
						{
							num2 = 0.0;
							num3 = 0.0;
						}
						switch (this.GetParentPlatform().Category)
						{
						case Ship._ShipCategory.SurfaceCombatant:
						case Ship._ShipCategory.Carrier:
						case Ship._ShipCategory.SurfaceCombatant_AviationCapable:
							break;
						case Ship._ShipCategory.Amphibious:
							num2 = (double)((float)(1.5 * num2));
							num3 = (double)((float)(1.5 * num3));
							break;
						case Ship._ShipCategory.Auxiliary:
						case Ship._ShipCategory.Merchant:
						case Ship._ShipCategory.Civilian:
						case Ship._ShipCategory.MobileOffshoreBase_AviationCapable:
							num2 = 2.0 * num2;
							num3 = 2.0 * num3;
							break;
						default:
							throw new NotImplementedException();
						}
						num2 *= (double)thePenetration_;
						num3 *= (double)thePenetration_;
					}
					if (warheadType_ - Warhead.WarheadType.Cluster_AP <= 2 || warheadType_ == Warhead.WarheadType.Cluster_SmartSubs)
					{
						num2 = Math.Max(0.7, num2);
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
					double num7 = GameGeneral.GetRandom().NextDouble();
					if (num7 < (double)num6)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Severe);
					}
					else if (num7 < (double)num5)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Major);
					}
					else if (num7 < num4)
					{
						base.method_9(ActiveUnit_Damage.FireIntensityLevel.Minor);
					}
					double num8 = num3;
					float num9 = (float)(num2 * 0.3);
					float num10 = (float)(num2 * 0.1);
					double num11 = GameGeneral.GetRandom().NextDouble();
					if (num11 < (double)num10)
					{
						base.method_8(ActiveUnit_Damage.FloodingIntensityLevel.Severe);
					}
					else if (num11 < (double)num9)
					{
						base.method_8(ActiveUnit_Damage.FloodingIntensityLevel.Major);
					}
					else if (num11 < num8)
					{
						base.method_8(ActiveUnit_Damage.FloodingIntensityLevel.Minor);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100785", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x0002B014 File Offset: 0x00029214
		public override void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			base.vmethod_5(DamageYield, theCutOffRange_Frag, ARM_TargetedRadar);
		}

		// Token: 0x0400343A RID: 13370
		private Ship ParentPlatform;

		// Token: 0x02000B76 RID: 2934
		[CompilerGenerated]
		public sealed class WarheadMatcher
		{
			// Token: 0x0600611D RID: 24861 RVA: 0x0002B01F File Offset: 0x0002921F
			public WarheadMatcher(Ship_Damage.WarheadMatcher WarheadMatcher_)
			{
				if (WarheadMatcher_ != null)
				{
					this.warhead = WarheadMatcher_.warhead;
				}
			}

			// Token: 0x0600611E RID: 24862 RVA: 0x0002B039 File Offset: 0x00029239
			internal bool IsNotSameToMe(Warhead warhead_)
			{
				return warhead_ != this.warhead;
			}

			// Token: 0x0400343B RID: 13371
			public Warhead warhead;
		}

		// Token: 0x02000B77 RID: 2935
		[CompilerGenerated]
		public sealed class ARMTargetEmmiterMatcher
		{
			// Token: 0x0600611F RID: 24863 RVA: 0x0002B047 File Offset: 0x00029247
			public ARMTargetEmmiterMatcher(Ship_Damage.ARMTargetEmmiterMatcher ARMTargetEmmiterMatcher_)
			{
				if (ARMTargetEmmiterMatcher_ != null)
				{
					this.theARM = ARMTargetEmmiterMatcher_.theARM;
				}
			}

			// Token: 0x06006120 RID: 24864 RVA: 0x0002B061 File Offset: 0x00029261
			internal bool HasSensorMySpecifiedEmission(Sensor sensor_)
			{
				return sensor_.IsEmmitting() && (sensor_.DBID == this.theARM.ARM_SpecifiedEmission.Key || (int)sensor_.MasqueradeAs == this.theARM.ARM_SpecifiedEmission.Key);
			}

			// Token: 0x0400343C RID: 13372
			public Weapon theARM;
		}
	}
}
