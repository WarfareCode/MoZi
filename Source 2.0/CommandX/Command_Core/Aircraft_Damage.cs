using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace Command_Core
{
	// Token: 飞机毁伤
	public sealed class Aircraft_Damage : ActiveUnit_Damage
	{
		// Token: 0x06004C91 RID: 19601 RVA: 0x001E552C File Offset: 0x001E372C
		private Aircraft GetParentAircraft()
		{
			if (Information.IsNothing(this.ParentAircraft))
			{
				this.ParentAircraft = (Aircraft)this.activeUnit;
			}
			return this.ParentAircraft;
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x001E5564 File Offset: 0x001E3764
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			try
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
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100445", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x001E5618 File Offset: 0x001E3818
		public static Aircraft_Damage Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_Damage result = null;
			try
			{
				Aircraft_Damage aircraft_Damage = new Aircraft_Damage(ref activeUnit_1);
				aircraft_Damage.activeUnit = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "Fire", false) != 0)
						{
							if (Operators.CompareString(name, "TTNSDC", false) == 0)
							{
								aircraft_Damage.TimeToNextSystemDamageCalculation = Math.Abs(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							}
						}
						else
						{
							aircraft_Damage.fireIntensityLevel = (ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
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
				result = aircraft_Damage;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100446", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_Damage(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x000247CD File Offset: 0x000229CD
		public Aircraft_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x001E574C File Offset: 0x001E394C
		public override void vmethod_11(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			if (!this.GetParentAircraft().IsAirship() && !this.GetParentAircraft().m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.AircraftDamageModel))
			{
				this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
			}
			else
			{
				string text = "";
				base.vmethod_11(weapon_0, geoPoint_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref text);
			}
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x001E57B4 File Offset: 0x001E39B4
		protected override void vmethod_10(Weapon weapon_, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			try
			{
				float damagePts = this.activeUnit.GetDamagePts(false);
				double num;
				if (weapon_.IsGuidedWeapon())
				{
					num = (double)Class263.GetAngleBetween(this.activeUnit.GetCurrentHeading(), this.activeUnit.AzimuthTo(weapon_));
				}
				else
				{
					num = (double)Class263.GetAngleBetween(this.activeUnit.GetCurrentHeading(), this.activeUnit.AzimuthTo(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude()));
				}
				Warhead warhead = weapon_.m_Warheads[0];
				Random random = GameGeneral.GetRandom();
				double num2 = 0.0;
				double num3;
				if (weapon_.method_138() && (UnguidedWeapon.ContainsSalvo(weapon_.Name) || UnguidedWeapon.ContainsBurst(weapon_.Name)))
				{
					num3 = (double)((float)((double)random.Next(1, 11) * 0.1 * (double)warhead.DP));
				}
				else
				{
					num3 = (double)warhead.DP;
				}
				if (weapon_.IsLaserWeapon())
				{
					num3 = 0.0;
					num2 = base.method_1(weapon_, geoPoint_0);
				}
				string text = "";
				if (Operators.CompareString(this.GetParentAircraft().Name, this.GetParentAircraft().UnitClass, false) != 0)
				{
					text = " (" + this.GetParentAircraft().UnitClass + ")";
				}
				if (this.GetParentAircraft().IsAirship())
				{
					if (warhead.method_18(weapon_, this.GetParentAircraft()))
					{
					}
				}
				else
				{
					float num4 = weapon_.GetPenetration(this.GetParentAircraft().AircraftFuselageArmor, this.activeUnit.GetTargetVisualSizeClass()) / 100f;
					double num5 = (double)num4 * (num3 + num2);
					this.activeUnit.SetDamagePts(false, (float)((double)this.activeUnit.GetDamagePts(false) - num5));
					this.activeUnit.LogMessage(string.Concat(new string[]
					{
						Misc.smethod_11(this.activeUnit.Name),
						text,
						"遭受武器毁伤: ",
						Conversions.ToString(Math.Round(num5, 1)),
						"毁伤点数"
					}), LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					double num6 = 0.0;
					switch (this.GetParentAircraft().aircraftSizeClass)
					{
					case GlobalVariables.AircraftSizeClass.Small:
						num6 = 0.4;
						break;
					case GlobalVariables.AircraftSizeClass.Medium:
						num6 = 0.3;
						break;
					case GlobalVariables.AircraftSizeClass.Large:
						num6 = 0.2;
						break;
					case GlobalVariables.AircraftSizeClass.VLarge:
						num6 = 0.1;
						break;
					}
					if (weapon_.method_138())
					{
						num6 = (double)((float)(num6 * 0.2));
					}
					double num7 = num;
					if (num7 < 45.0)
					{
						num6 *= 1.5;
					}
					else if (num7 >= 135.0)
					{
						if (num7 < 225.0)
						{
							num6 *= 0.5;
						}
						else if (num7 >= 315.0)
						{
							num6 *= 1.5;
						}
					}
					if (random.NextDouble() < num6)
					{
						num4 = weapon_.GetPenetration(this.GetParentAircraft().AircraftCockpitArmor, this.activeUnit.GetTargetVisualSizeClass()) / 100f;
						this.activeUnit.LogMessage("命中座舱- 侵入" + Conversions.ToString(num4 * 100f) + "%", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.GetParentAircraft().GetLongitude(null), this.GetParentAircraft().GetLatitude(null)));
						if ((double)num4 > 0.5)
						{
							this.activeUnit.LogMessage("座舱和飞行员丧失能力 - 飞机失控!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.GetParentAircraft().GetLongitude(null), this.GetParentAircraft().GetLatitude(null)));
							this.GetParentAircraft().m_Scenario.RemoveUnit(this.GetParentAircraft());
							return;
						}
					}
					float num8 = 0f;
					switch (this.GetParentAircraft().aircraftSizeClass)
					{
					case GlobalVariables.AircraftSizeClass.Small:
						num8 = 0.5f;
						break;
					case GlobalVariables.AircraftSizeClass.Medium:
						num8 = 0.3f;
						break;
					case GlobalVariables.AircraftSizeClass.Large:
						num8 = 0.2f;
						break;
					case GlobalVariables.AircraftSizeClass.VLarge:
						num8 = 0.1f;
						break;
					}
					if (weapon_.method_138())
					{
						num8 = (float)((double)num8 * 0.2);
					}
					if (random.NextDouble() < (double)num8)
					{
						num4 = weapon_.GetPenetration(this.GetParentAircraft().AircraftEngineArmor, this.activeUnit.GetTargetVisualSizeClass()) / 100f;
						this.activeUnit.LogMessage("命中发动机- 侵入" + Conversions.ToString(num4 * 100f) + "%", LoggedMessage.MessageType.UnitLost, 0, false, new GeoPoint(this.GetParentAircraft().GetLongitude(null), this.GetParentAircraft().GetLatitude(null)));
						if ((double)num4 > 0.5)
						{
							IEnumerable<Engine> source = this.GetParentAircraft().GetEngines().Where(Aircraft_Damage.EngineFunc);
							if (source.Count<Engine>() > 0)
							{
								Engine engine = source.ElementAtOrDefault(random.Next(0, source.Count<Engine>()));
								engine.BeDestroyed(this.GetParentAircraft().GetSide(false), false, false);
								this.activeUnit.LogMessage("发动机 " + engine.Name + "被摧毁!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.GetParentAircraft().GetLongitude(null), this.GetParentAircraft().GetLatitude(null)));
							}
						}
					}
					base.method_4(warhead.warheadType, warhead.ExplosivesType, num3 + num2, damagePts, num4, false, weapon_.ARM_SpecifiedEmission.Key);
				}
				base.method_5(true);
				base.method_6();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100447", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x001E5E48 File Offset: 0x001E4048
		public override void vmethod_12(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
			try
			{
				if (float_1 > 0f)
				{
					double num = (double)(float_1 / this.activeUnit.GetDamagePts(false));
					num = 0.3;
					if (warheadType_0 != Warhead.WarheadType.Fragmentation && warheadType_0 != Warhead.WarheadType.ContinuousRod)
					{
						if (warheadType_0 == Warhead.WarheadType.DirectionalContinousRod)
						{
							num += 0.4;
						}
					}
					else
					{
						num += 0.2;
					}
					if (num >= 0.9)
					{
						num = 0.9;
					}
					double num2 = num;
					float num3 = (float)(num - 0.1);
					float num4 = (float)(num - 0.2);
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

		// Token: 0x06004C98 RID: 19608 RVA: 0x001E5F88 File Offset: 0x001E4188
		public override void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			try
			{
				if (this.GetParentAircraft().IsAirship())
				{
					base.vmethod_5(DamageYield, theCutOffRange_Frag, 0);
					if (this.activeUnit.GetDamagePts(false) <= 0f)
					{
						this.activeUnit.SetDamagePts(false, 0f);
						this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
					}
				}
				else
				{
					this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100448", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x001E6050 File Offset: 0x001E4250
		public override void vmethod_6(float float_1, Warhead.WarheadType warheadType_0, Warhead._ExplosivesType enum87_0, Weapon._DetonationMedium enum90_0)
		{
			try
			{
				if (float_1 >= 2f)
				{
					if (this.GetParentAircraft().IsAirship())
					{
						base.vmethod_6(float_1, warheadType_0, enum87_0, enum90_0);
					}
					else
					{
						this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100449", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void vmethod_15(float float_1)
		{
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x001E60E8 File Offset: 0x001E42E8
		public override void UpdateDamageStatus(float elapsedTime)
		{
			if (this.GetParentAircraft().m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.AircraftDamageModel))
			{
				try
				{
					float num = 0f;
					switch (this.GetFireIntensityLevel())
					{
					case ActiveUnit_Damage.FireIntensityLevel.Minor:
						num = (float)((double)this.activeUnit.GetInitialDP() * 0.2 * (double)(elapsedTime / 3600f));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Major:
						num = (float)((double)this.activeUnit.GetInitialDP() * 0.4 * (double)(elapsedTime / 3600f));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Severe:
						num = (float)((double)this.activeUnit.GetInitialDP() * 0.8 * (double)(elapsedTime / 3600f));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
						num = (float)this.activeUnit.GetInitialDP() * (elapsedTime / 3600f);
						if (GameGeneral.GetRandom().Next(1, 101) <= 5)
						{
							this.activeUnit.LogMessage(this.activeUnit.Name + "发生燃油爆炸，正在解体!!!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
							return;
						}
						break;
					}
					if (num > 0f)
					{
						this.activeUnit.SetDamagePts(false, this.activeUnit.GetDamagePts(false) - num);
					}
					if (this.activeUnit.GetDamage().GetDamagePts() > 80f)
					{
						this.activeUnit.LogMessage(this.activeUnit.Name + "超过80%的结构和机身毁伤，正在解体!!!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
					}
					else if (this.GetParentAircraft().m_Scenario.FifthSecondIsChangingOnThisPulse && this.GetFireIntensityLevel() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
					{
						byte b = (byte)GameGeneral.GetRandom().Next(1, 11);
						GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit.GetProficiencyLevel();
						int? num2 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							b += 3;
						}
						else
						{
							num2 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								b += 2;
							}
							else
							{
								num2 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									b += 1;
								}
								else
								{
									num2 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (!(num2.HasValue ? new bool?(num2.GetValueOrDefault() == 3) : null).GetValueOrDefault())
									{
										num2 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											b = (byte)Math.Max(0, (int)(b - 2));
										}
									}
								}
							}
						}
						b = (byte)Math.Max(0, (int)b);
						if (b <= 10)
						{
							switch (b)
							{
							case 1:
							case 2:
							case 3:
							case 4:
								this.SetFireIntensityLevel((ActiveUnit_Damage.FireIntensityLevel)Math.Max(0, (int)(this.GetFireIntensityLevel() - ActiveUnit_Damage.FireIntensityLevel.Minor)));
								goto IL_47A;
							case 5:
							case 6:
							case 7:
							case 8:
								goto IL_47A;
							case 9:
							case 10:
								break;
							default:
								goto IL_47A;
							}
						}
						if (this.GetFireIntensityLevel() != ActiveUnit_Damage.FireIntensityLevel.Conflagration)
						{
							this.SetFireIntensityLevel(this.GetFireIntensityLevel() + 1);
						}
					}
					IL_47A:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200283", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0400241C RID: 9244
		public static Func<Engine, bool> EngineFunc = (Engine engine_0) => engine_0.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational;

		// Token: 毁伤模型所在的飞机
		private Aircraft ParentAircraft;
	}
}
