using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace Command_Core
{
	// Token: 毁伤
	public class ActiveUnit_Damage
	{
		// Token: 0x06001E66 RID: 7782 RVA: 0x000C67A8 File Offset: 0x000C49A8
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_Damage.Delegate1 delegate1_1)
		{
			ActiveUnit_Damage.Delegate1 @delegate = ActiveUnit_Damage.delegate1_0;
			ActiveUnit_Damage.Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_Damage.Delegate1 value = (ActiveUnit_Damage.Delegate1)Delegate.Combine(delegate2, delegate1_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_Damage.Delegate1>(ref ActiveUnit_Damage.delegate1_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000C67E0 File Offset: 0x000C49E0
		public virtual void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_Damage");
				if (this.GetFireIntensityLevel() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Fire";
					byte b = (byte)this.fireIntensityLevel;
					xmlWriter.WriteElementString(localName, b.ToString());
				}
				if (this.GetFloodingIntensityLevel() > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
				{
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "Flood";
					byte b = (byte)this.floodingIntensityLevel;
					xmlWriter2.WriteElementString(localName2, b.ToString());
				}
				xmlWriter_0.WriteElementString("TTNSDC", XmlConvert.ToString(this.TimeToNextSystemDamageCalculation));
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100109", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00004A21 File Offset: 0x00002C21
		private  ActiveUnit_Damage()
		{
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000C68C4 File Offset: 0x000C4AC4
		public virtual ActiveUnit_Damage.FloodingIntensityLevel GetFloodingIntensityLevel()
		{
			return this.floodingIntensityLevel;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000C68DC File Offset: 0x000C4ADC
		public virtual void vmethod_2(ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel_1)
		{
			try
			{
				if (floodingIntensityLevel_1 != this.floodingIntensityLevel)
				{
					this.floodingIntensityLevel = floodingIntensityLevel_1;
					switch (this.floodingIntensityLevel)
					{
					case ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding:
						this.activeUnit.LogMessage(this.activeUnit.Name + "已堵住所有渗漏.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
						this.activeUnit.LogMessage(this.activeUnit.Name + "小规模进水.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Major:
						this.activeUnit.LogMessage(this.activeUnit.Name + "大规模进水.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
						this.activeUnit.LogMessage(this.activeUnit.Name + "发生严重进水.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
						this.activeUnit.LogMessage("警告: " + this.activeUnit.Name + "面临沉没风险!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100111", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000C6B24 File Offset: 0x000C4D24
		public virtual ActiveUnit_Damage.FireIntensityLevel GetFireIntensityLevel()
		{
			return this.fireIntensityLevel;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000C6B3C File Offset: 0x000C4D3C
		public virtual void SetFireIntensityLevel(ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel_1)
		{
			try
			{
				if (fireIntensityLevel_1 != this.fireIntensityLevel)
				{
					this.fireIntensityLevel = fireIntensityLevel_1;
					switch (this.fireIntensityLevel)
					{
					case ActiveUnit_Damage.FireIntensityLevel.NoFire:
						this.activeUnit.LogMessage(this.activeUnit.Name + "已扑灭所有失火.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Minor:
						this.activeUnit.LogMessage(this.activeUnit.Name + "发生小型失火.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Major:
						this.activeUnit.LogMessage(this.activeUnit.Name + "发生大型失火.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Severe:
						this.activeUnit.LogMessage(this.activeUnit.Name + "发生严重失火.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
						this.activeUnit.LogMessage("警告: " + this.activeUnit.Name + "面临失火失控风险!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100112", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000C6D84 File Offset: 0x000C4F84
		public virtual float GetDamagePts()
		{
			float result = 0f;
			try
			{
				if (this.activeUnit.IsFacility)
				{
					if (((Facility)this.activeUnit).MountsAreAimpoints)
					{
						int num = this.activeUnit.m_Mounts.Where(ActiveUnit_Damage.UndestroyedMount).Count<Mount>();
						if (num == 0)
						{
							result = 100f;
						}
						else
						{
							result = Math.Max(0f, Math.Min(100f, (float)(100.0 - (double)num / (double)this.activeUnit.m_Mounts.Length * 100.0)));
						}
					}
					else if (this.activeUnit.GetDamagePts(false) == (float)this.activeUnit.GetInitialDP())
					{
						result = 0f;
					}
					else
					{
						result = Math.Max(0f, Math.Min(100f, (float)Math.Round((double)(100f - this.activeUnit.GetDamagePts(false) / (float)this.activeUnit.GetInitialDP() * 100f), 1)));
					}
				}
				else if (this.activeUnit.GetDamagePts(false) == (float)this.activeUnit.GetInitialDP())
				{
					result = 0f;
				}
				else
				{
					result = Math.Max(0f, Math.Min(100f, (float)Math.Round((double)(100f - this.activeUnit.GetDamagePts(false) / (float)this.activeUnit.GetInitialDP() * 100f), 1)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100113", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.activeUnit.GetDamagePts(false);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00012713 File Offset: 0x00010913
		public  ActiveUnit_Damage(ref ActiveUnit activeUnit_1)
		{
			this.activeUnit = activeUnit_1;
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000C6F70 File Offset: 0x000C5170
		public virtual void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			float damagePts = this.activeUnit.GetDamagePts(false);
			try
			{
				if (DamageYield > 0f)
				{
					new WeaponImpact(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), this.activeUnit.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
					if ((int)Math.Round((double)DamageYield) == 0)
					{
						this.activeUnit.LogMessage(this.activeUnit.Name + "遭受轻度破片杀伤", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					}
					else
					{
						this.activeUnit.LogMessage(this.activeUnit.Name + "遭受破片杀伤: " + Conversions.ToString(Math.Round((double)DamageYield, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
					}
					this.activeUnit.SetDamagePts(false, this.activeUnit.GetDamagePts(false) - DamageYield);
					this.method_4(Warhead.WarheadType.Fragmentation, Warhead._ExplosivesType.const_31, (double)DamageYield, damagePts, 0f, true, ARM_TargetedRadar);
					this.method_5(true);
					this.method_6();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100114", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000C7140 File Offset: 0x000C5340
		public virtual double method_1(Weapon weapon_0, GeoPoint geoPoint_0)
		{
			this.activeUnit.GetDamagePts(false);
			double result = 0.0;
			try
			{
				double num = (double)(geoPoint_0.GetSlantDistance(new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null))) / weapon_0.GetLargestRangeMaxOfAllDomains());
				double num2 = (double)weapon_0.m_Warheads[0].DP * Math.Pow(1.0 - num, 2.0);
				if (geoPoint_0.GetAltitude() <= 12000f || this.activeUnit.GetCurrentAltitude_ASL(false) <= 12000f)
				{
					double num3;
					if (geoPoint_0.GetAltitude() < 12000f && this.activeUnit.GetCurrentAltitude_ASL(false) < 12000f)
					{
						num3 = 1.0;
					}
					else
					{
						float num4 = Math.Abs(geoPoint_0.GetAltitude() - this.activeUnit.GetCurrentAltitude_ASL(false));
						if (geoPoint_0.GetAltitude() > 12000f && this.activeUnit.GetCurrentAltitude_ASL(false) < 12000f)
						{
							num3 = (double)((12000f - this.activeUnit.GetCurrentAltitude_ASL(false)) / num4);
						}
						else
						{
							num3 = (double)((12000f - geoPoint_0.GetAltitude()) / num4);
						}
					}
					Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(this.activeUnit.m_Scenario, this.activeUnit.GetLatitude(null), this.activeUnit.GetLongitude(null), (int)Math.Round((double)this.activeUnit.GetCurrentAltitude_ASL(false)));
					double num5 = (double)(1f - weatherProfile.GetFUR());
					float rainFallRate = weatherProfile.RainFallRate;
					double num6;
					if (rainFallRate > 40f)
					{
						num6 = 0.05;
					}
					else if (rainFallRate > 30f)
					{
						num6 = 0.1;
					}
					else if (rainFallRate > 20f)
					{
						num6 = 0.25;
					}
					else if (rainFallRate > 10f)
					{
						num6 = 0.5;
					}
					else if (rainFallRate > 0f)
					{
						num6 = 0.75;
					}
					else
					{
						num6 = 1.0;
					}
					double num7 = num5 * num6;
					if (num3 < 1.0 && num7 < 1.0)
					{
						num7 *= 1.0 - num3;
					}
					num2 *= num7;
				}
				result = num2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 10011205314", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000C7448 File Offset: 0x000C5648
		public virtual void vmethod_6(float yield_, Warhead.WarheadType warheadType_, Warhead._ExplosivesType explosivesType_, Weapon._DetonationMedium detonationMedium_)
		{
			float damagePts = this.activeUnit.GetDamagePts(false);
			try
			{
				if (this.activeUnit.IsMineSweeper() && detonationMedium_ == Weapon._DetonationMedium.Underwater)
				{
					yield_ = (float)((double)yield_ * 0.1);
				}
				this.vmethod_9(ref yield_);
				if (Math.Round((double)yield_, 1) > 0.0)
				{
					new WeaponImpact(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), this.activeUnit.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
					bool flag = this.activeUnit.GetAirFacilities().Length > 0 && this.activeUnit.GetAirFacilities().Length == this.activeUnit.GetAirFacilities().Where(ActiveUnit_Damage.AirFacilityFunc1).Count<AirFacility>();
					if (!this.activeUnit.IsFixedFacility() || !flag)
					{
						if (!this.activeUnit.IsWeapon)
						{
							this.activeUnit.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "遭受爆炸杀伤: " + Conversions.ToString(Math.Round((double)yield_, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						this.activeUnit.SetDamagePts(false, this.activeUnit.GetDamagePts(false) - yield_);
						this.method_4(warheadType_, explosivesType_, (double)yield_, damagePts, 0f, true, 0);
					}
					this.method_5(true);
					this.method_6();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100115", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000C7650 File Offset: 0x000C5850
		public virtual void vmethod_7(float float_1, Warhead.WarheadType warheadType_, Warhead._ExplosivesType explosivesType_, float clusterCoverageLength_)
		{
			if (float_1 != 0f)
			{
				try
				{
					float damagePts = this.activeUnit.GetDamagePts(false);
					this.vmethod_8(ref float_1, warheadType_);
					if (Math.Round((double)float_1, 1) > 0.0)
					{
						new WeaponImpact(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), this.activeUnit.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
						this.activeUnit.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "遭受炸弹杀伤: " + Conversions.ToString(Math.Round((double)float_1, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						this.activeUnit.SetDamagePts(false, this.activeUnit.GetDamagePts(false) - float_1);
						this.method_4(warheadType_, explosivesType_, (double)float_1, damagePts, 0f, true, 0);
						this.method_5(true);
						this.method_6();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100116", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000097CF File Offset: 0x000079CF
		public virtual void vmethod_8(ref float float_1, Warhead.WarheadType warheadType_)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void vmethod_9(ref float float_1)
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000097CF File Offset: 0x000079CF
		protected virtual void vmethod_10(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000C77DC File Offset: 0x000C59DC
		public virtual void vmethod_11(Weapon theAntiRadiationMissile_, GeoPoint LaunchPoint_, float MissDistance_, float MissAzimuth_, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			ActiveUnit_Damage.AntiRadiationMissile antiRadiationMissile = new ActiveUnit_Damage.AntiRadiationMissile();
			antiRadiationMissile.ARM = theAntiRadiationMissile_;
			try
			{
				if (antiRadiationMissile.ARM.m_Warheads.Length != 0)
				{
					if (MissDistance_ == 0f)
					{
						this.vmethod_10(antiRadiationMissile.ARM, LaunchPoint_, MissDistance_, MissAzimuth_, ref activeUnit_1, nullable_0, nullable_1, nullable_2);
					}
					else
					{
						float damagePts = this.activeUnit.GetDamagePts(false);
						if (antiRadiationMissile.ARM.weaponTarget.IsRadar && !Information.IsNothing(antiRadiationMissile.ARM.ARM_SpecifiedEmission))
						{
							IEnumerable<Sensor> source = this.activeUnit.GetAllNoneMCMSensors().Where(new Func<Sensor, bool>(antiRadiationMissile.IsTargetForMe));
							if (source.Count<Sensor>() > 0)
							{
								int index = GameGeneral.GetRandom().Next(0, source.Count<Sensor>());
								this.method_7(antiRadiationMissile.ARM.m_Warheads[0].warheadType, antiRadiationMissile.ARM.m_Warheads[0].ExplosivesType, source.ElementAtOrDefault(index), (double)antiRadiationMissile.ARM.m_Warheads[0].DP, damagePts, antiRadiationMissile.ARM.ARM_SpecifiedEmission.Key);
							}
						}
						this.method_2(antiRadiationMissile.ARM, MissDistance_, MissAzimuth_, activeUnit_1, nullable_0, nullable_1, nullable_2);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100117", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000C7978 File Offset: 0x000C5B78
		public void method_2(Weapon weapon_, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			Warhead warhead = weapon_.m_Warheads[0];
			if (warhead.method_13() || warhead.IsIncendiary())
			{
				if (Information.IsNothing(nullable_2))
				{
					if (weapon_.GetWeaponNavigator().HasPlottedCourse() && weapon_.GetWeaponNavigator().GetPlottedCourse()[0].GetAltitude() > 4000f)
					{
						nullable_2 = new float?((float)((int)Math.Round((double)weapon_.GetCurrentAltitude_ASL(false))));
					}
					else
					{
						nullable_2 = new float?((float)((int)Math.Round((double)(this.activeUnit.GetCurrentAltitude_ASL(false) + (float)weapon_.method_188(this.activeUnit)))));
					}
				}
				else
				{
					float? num = nullable_2;
					float num2 = (float)weapon_.method_188(this.activeUnit);
					nullable_2 = (num.HasValue ? new float?(num.GetValueOrDefault() + num2) : null);
				}
				if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
				{
					double value = 0.0;
					double value2 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), ref value, ref value2, (double)(float_1 / 1852f), (double)float_2);
					nullable_0 = new double?(value2);
					nullable_1 = new double?(value);
				}
				new Explosion(ref this.activeUnit.m_Scenario, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_.GetCurrentHeading(), nullable_2.Value, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, activeUnit_1, null, null, 0, 0, 0, 0f, 0);
			}
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void vmethod_12(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000C7B50 File Offset: 0x000C5D50
		public bool IsMountHasSensorsInEmissionContainer(Mount theMount_, KeyValuePair<int, EmissionContainer> EmissionContainerPair_)
		{
			ActiveUnit_Damage.EmissionContainerMan emissionContainerMan = new ActiveUnit_Damage.EmissionContainerMan();
			emissionContainerMan.EmissionContainerPair = EmissionContainerPair_;
			bool result = false;
			try
			{
				result = (theMount_.GetSensors().Select(ActiveUnit_Damage.SensorFunc2).Where(new Func<Sensor, bool>(emissionContainerMan.IsEmissionInMyContainer)).Count<Sensor>() > 0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100118", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000C7BE8 File Offset: 0x000C5DE8
		protected void method_4(Warhead.WarheadType theWarheadType, Warhead._ExplosivesType theWarheadExplosivesType, double theDamage, float TargetDP_BeforeDamage, float thePenetration, bool IsAreaEffect, int ARM_TargetedRadar = 0)
		{
			try
			{
				int num = this.method_10(theDamage, theWarheadType, TargetDP_BeforeDamage, thePenetration, ARM_TargetedRadar);
				bool flag = ARM_TargetedRadar == 0;
				if (num > this.activeUnit.GetAllPlatformComponents().Count)
				{
					num = this.activeUnit.GetAllPlatformComponents().Count;
				}
				if (num > 0)
				{
					int num2 = num;
					for (int i = 1; i <= num2; i++)
					{
						PlatformComponent platformComponent = this.vmethod_14(ARM_TargetedRadar, flag);
						if (!Information.IsNothing(platformComponent) && !string.IsNullOrEmpty(platformComponent.Name) && platformComponent.IsSensor() && ((Sensor)platformComponent).IsEyeball())
						{
							platformComponent = null;
						}
						if (!Information.IsNothing(platformComponent))
						{
							this.method_7(theWarheadType, theWarheadExplosivesType, platformComponent, theDamage, TargetDP_BeforeDamage, ARM_TargetedRadar);
						}
						if (!flag)
						{
							flag = true;
						}
					}
				}
				this.vmethod_12((float)theDamage, theWarheadType, thePenetration);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100119", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000C7D0C File Offset: 0x000C5F0C
		protected void method_5(bool bool_0)
		{
			checked
			{
				if (bool_0)
				{
					AirFacility[] airFacilities = this.activeUnit.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility = airFacilities[i];
						if (airFacility.method_35())
						{
							double num = GameGeneral.GetRandom().NextDouble();
							PlatformComponent._DamageSeverityFactor damageSeverityFactor;
							if (num > 0.7)
							{
								damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Heavy;
							}
							else if (num > 0.3)
							{
								damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Medium;
							}
							else
							{
								damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Light;
							}
							if (this.activeUnit.IsFacility && (((Facility)this.activeUnit).Category == Facility._FacilityCategory.Building_Reveted || ((Facility)this.activeUnit).Category == Facility._FacilityCategory.Structure_Reveted) && damageSeverityFactor != PlatformComponent._DamageSeverityFactor.Light)
							{
								damageSeverityFactor = unchecked((PlatformComponent._DamageSeverityFactor)(damageSeverityFactor - PlatformComponent._DamageSeverityFactor.Medium));
							}
							airFacility.method_28(damageSeverityFactor);
						}
					}
				}
			}
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000C7DE4 File Offset: 0x000C5FE4
		protected void method_6()
		{
			ActiveUnit_Damage.Delegate1 @delegate = ActiveUnit_Damage.delegate1_0;
			if (@delegate != null)
			{
				@delegate(this.activeUnit);
			}
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000C7E0C File Offset: 0x000C600C
		public void method_7(Warhead.WarheadType warheadType_, Warhead._ExplosivesType ExplosivesType_, PlatformComponent platformComponent_, double double_0, float float_1, int int_0)
		{
			int num = GameGeneral.GetRandom().Next(1, 101);
			try
			{
				if (num < 10 && platformComponent_.IsSensor() && int_0 == platformComponent_.DBID)
				{
					num = 10;
				}
				GlobalVariables.ArmorRating armorRating = GlobalVariables.ArmorRating.None;
				if (platformComponent_.IsMount())
				{
					armorRating = ((Mount)platformComponent_).ArmorGeneral;
				}
				if (platformComponent_.IsMagazine())
				{
					armorRating = ((Magazine)platformComponent_).armorRating;
				}
				if (armorRating != GlobalVariables.ArmorRating.None)
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						if (ExplosivesType_ <= Warhead._ExplosivesType.const_36)
						{
							if (ExplosivesType_ != Warhead._ExplosivesType.const_31 && ExplosivesType_ != Warhead._ExplosivesType.const_36)
							{
								goto IL_E7;
							}
						}
						else if (ExplosivesType_ != Warhead._ExplosivesType.const_51 && ExplosivesType_ != Warhead._ExplosivesType.const_53 && ExplosivesType_ != Warhead._ExplosivesType.const_54)
						{
							goto IL_E7;
						}
						num -= 90;
						break;
						IL_E7:
						num -= 10;
						break;
					case GlobalVariables.ArmorRating.Medium:
						if (ExplosivesType_ <= Warhead._ExplosivesType.const_37)
						{
							if (ExplosivesType_ <= Warhead._ExplosivesType.const_27)
							{
								if (ExplosivesType_ - Warhead._ExplosivesType.const_24 > 1 && ExplosivesType_ != Warhead._ExplosivesType.const_27)
								{
									goto IL_198;
								}
							}
							else
							{
								if (ExplosivesType_ == Warhead._ExplosivesType.const_31 || ExplosivesType_ == Warhead._ExplosivesType.const_36)
								{
									goto IL_191;
								}
								if (ExplosivesType_ != Warhead._ExplosivesType.const_37)
								{
									goto IL_198;
								}
							}
						}
						else if (ExplosivesType_ <= Warhead._ExplosivesType.const_47)
						{
							if (ExplosivesType_ != Warhead._ExplosivesType.const_43 && ExplosivesType_ != Warhead._ExplosivesType.const_47)
							{
								goto IL_198;
							}
						}
						else
						{
							if (ExplosivesType_ == Warhead._ExplosivesType.const_51 || ExplosivesType_ == Warhead._ExplosivesType.const_53 || ExplosivesType_ == Warhead._ExplosivesType.const_54)
							{
								goto IL_191;
							}
							goto IL_198;
						}
						num -= 90;
						break;
						IL_191:
						num = 0;
						break;
						IL_198:
						num -= 30;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						if (ExplosivesType_ <= Warhead._ExplosivesType.const_38)
						{
							if (ExplosivesType_ <= Warhead._ExplosivesType.const_27)
							{
								if (ExplosivesType_ - Warhead._ExplosivesType.const_24 > 1)
								{
									if (ExplosivesType_ == Warhead._ExplosivesType.const_26)
									{
										goto IL_26D;
									}
									if (ExplosivesType_ != Warhead._ExplosivesType.const_27)
									{
										goto IL_2A4;
									}
								}
							}
							else
							{
								if (ExplosivesType_ == Warhead._ExplosivesType.const_28)
								{
									goto IL_26D;
								}
								if (ExplosivesType_ == Warhead._ExplosivesType.const_31)
								{
									goto IL_29D;
								}
								switch (ExplosivesType_)
								{
								case Warhead._ExplosivesType.const_36:
									goto IL_29D;
								case Warhead._ExplosivesType.const_37:
									break;
								case Warhead._ExplosivesType.const_38:
									goto IL_26D;
								default:
									goto IL_2A4;
								}
							}
						}
						else if (ExplosivesType_ <= Warhead._ExplosivesType.const_47)
						{
							if (ExplosivesType_ != Warhead._ExplosivesType.const_43)
							{
								if (ExplosivesType_ == Warhead._ExplosivesType.const_44)
								{
									goto IL_26D;
								}
								if (ExplosivesType_ != Warhead._ExplosivesType.const_47)
								{
									goto IL_2A4;
								}
							}
						}
						else if (ExplosivesType_ <= Warhead._ExplosivesType.const_51)
						{
							if (ExplosivesType_ == Warhead._ExplosivesType.const_48)
							{
								goto IL_26D;
							}
							if (ExplosivesType_ != Warhead._ExplosivesType.const_51)
							{
								goto IL_2A4;
							}
							goto IL_29D;
						}
						else
						{
							if (ExplosivesType_ == Warhead._ExplosivesType.const_53 || ExplosivesType_ == Warhead._ExplosivesType.const_54)
							{
								goto IL_29D;
							}
							goto IL_2A4;
						}
						num = 0;
						break;
						IL_26D:
						num -= 90;
						break;
						IL_29D:
						num = 0;
						break;
						IL_2A4:
						num -= 50;
						break;
					case GlobalVariables.ArmorRating.Special:
						if (ExplosivesType_ <= Warhead._ExplosivesType.const_39)
						{
							if (ExplosivesType_ <= Warhead._ExplosivesType.const_26)
							{
								if (ExplosivesType_ - Warhead._ExplosivesType.const_24 > 1)
								{
									if (ExplosivesType_ != Warhead._ExplosivesType.const_26)
									{
										goto IL_3A9;
									}
									goto IL_375;
								}
							}
							else
							{
								switch (ExplosivesType_)
								{
								case Warhead._ExplosivesType.const_27:
									break;
								case Warhead._ExplosivesType.const_28:
									goto IL_375;
								case Warhead._ExplosivesType.const_29:
									goto IL_379;
								default:
									if (ExplosivesType_ == Warhead._ExplosivesType.const_31)
									{
										goto IL_3A5;
									}
									switch (ExplosivesType_)
									{
									case Warhead._ExplosivesType.const_36:
										goto IL_3A5;
									case Warhead._ExplosivesType.const_37:
										break;
									case Warhead._ExplosivesType.const_38:
										goto IL_375;
									case Warhead._ExplosivesType.const_39:
										goto IL_379;
									default:
										goto IL_3A9;
									}
									break;
								}
							}
						}
						else if (ExplosivesType_ <= Warhead._ExplosivesType.const_49)
						{
							switch (ExplosivesType_)
							{
							case Warhead._ExplosivesType.const_43:
								break;
							case Warhead._ExplosivesType.const_44:
								goto IL_375;
							case Warhead._ExplosivesType.const_45:
								goto IL_379;
							default:
								switch (ExplosivesType_)
								{
								case Warhead._ExplosivesType.const_47:
									break;
								case Warhead._ExplosivesType.const_48:
									goto IL_375;
								case Warhead._ExplosivesType.const_49:
									goto IL_379;
								default:
									goto IL_3A9;
								}
								break;
							}
						}
						else
						{
							if (ExplosivesType_ == Warhead._ExplosivesType.const_51 || ExplosivesType_ == Warhead._ExplosivesType.const_53 || ExplosivesType_ == Warhead._ExplosivesType.const_54)
							{
								goto IL_3A5;
							}
							goto IL_3A9;
						}
						num = 0;
						break;
						IL_375:
						num = 0;
						break;
						IL_379:
						num -= 90;
						break;
						IL_3A5:
						num = 0;
						break;
						IL_3A9:
						num -= 70;
						break;
					}
				}
				string string_;
				if (platformComponent_.GetType() == typeof(Cargo))
				{
					if (((Cargo)platformComponent_).GetCurrentType() == Cargo._CargoType.const_1)
					{
						string_ = "[Cargo] " + ((Mount)((Cargo)platformComponent_).GetCargo()).Name;
					}
					else
					{
						string_ = platformComponent_.Name;
					}
				}
				else
				{
					string_ = platformComponent_.Name;
				}
				int num2 = num;
				if (num2 >= 10)
				{
					if (num2 < 30)
					{
						if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit.IsWeapon)
							{
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "遭受轻度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
						}
						else if (!this.activeUnit.IsWeapon)
						{
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "遭受额外的轻度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						platformComponent_.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
					}
					else if (num2 < 40)
					{
						if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit.IsWeapon)
							{
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "遭受中度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
						}
						else if (!this.activeUnit.IsWeapon)
						{
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "进一步遭受中度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						platformComponent_.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
					}
					else if (num2 < 70)
					{
						if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit.IsWeapon)
							{
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "遭受重度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
						}
						else if (!this.activeUnit.IsWeapon)
						{
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "进一步遭受重度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						platformComponent_.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
					}
					else if (platformComponent_.IsAirFacility() && ((AirFacility)platformComponent_).method_35())
					{
						if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit.IsWeapon)
							{
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "遭受重度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
						}
						else if (!this.activeUnit.IsWeapon)
						{
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "进一步遭受重度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						platformComponent_.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
					}
					else
					{
						if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit.IsWeapon)
							{
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
						}
						else if (!this.activeUnit.IsWeapon)
						{
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(string_) + "进一步遭受毁伤.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						platformComponent_.BeDestroyed(this.activeUnit.GetSide(false), false, false);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100120", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000C8914 File Offset: 0x000C6B14
		public virtual void UpdateDamageStatus(float elapsedTime)
		{
			try
			{
				float num = 0f;
				switch (this.GetFireIntensityLevel())
				{
				case ActiveUnit_Damage.FireIntensityLevel.Minor:
					num = (float)((double)this.activeUnit.GetInitialDP() * 0.04 * (double)(elapsedTime / 3600f));
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Major:
					num = (float)((double)this.activeUnit.GetInitialDP() * 0.08 * (double)(elapsedTime / 3600f));
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Severe:
					num = (float)((double)this.activeUnit.GetInitialDP() * 0.12 * (double)(elapsedTime / 3600f));
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
				{
					num = (float)((double)this.activeUnit.GetInitialDP() * 0.24 * (double)(elapsedTime / 3600f));
					bool flag = this.activeUnit.GetAirFacilities().Where(ActiveUnit_Damage.AirFacilityFunc3).Any<AirFacility>();
					if ((!this.activeUnit.IsFacility || !flag) && GameGeneral.GetRandom().Next(1, 101) <= 5)
					{
						this.activeUnit.LogMessage(this.activeUnit.Name + "失火已失控，正在解体!!!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						if (this.activeUnit.IsShip)
						{
							if (((Ship)this.activeUnit).IsDestroyed())
							{
								this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
							}
							else
							{
								this.activeUnit.SetDamagePts(false, Math.Min(this.activeUnit.GetDamagePts(false), -1f));
							}
						}
						else
						{
							this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
						}
						return;
					}
					break;
				}
				}
				float num2 = 0f;
				switch (this.GetFloodingIntensityLevel())
				{
				case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
					num2 = (float)((double)this.activeUnit.GetInitialDP() * 0.04 * (double)(elapsedTime / 3600f));
					break;
				case ActiveUnit_Damage.FloodingIntensityLevel.Major:
					num2 = (float)((double)this.activeUnit.GetInitialDP() * 0.08 * (double)(elapsedTime / 3600f));
					break;
				case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
					num2 = (float)((double)this.activeUnit.GetInitialDP() * 0.12 * (double)(elapsedTime / 3600f));
					break;
				case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
					num2 = (float)((double)this.activeUnit.GetInitialDP() * 0.24 * (double)(elapsedTime / 3600f));
					if (this.activeUnit.IsShip && GameGeneral.GetRandom().Next(1, 101) <= 5)
					{
						this.activeUnit.LogMessage(this.activeUnit.Name + " is capsizing - abandoning ship!!!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						if (((Ship)this.activeUnit).IsDestroyed())
						{
							this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
						}
						else
						{
							this.activeUnit.SetDamagePts(false, Math.Min(this.activeUnit.GetDamagePts(false), -1f));
						}
						return;
					}
					break;
				}
				if (num + num2 > 0f)
				{
					this.activeUnit.SetDamagePts(false, this.activeUnit.GetDamagePts(false) - (num + num2));
				}
				this.TimeToNextSystemDamageCalculation -= elapsedTime;
				if (this.TimeToNextSystemDamageCalculation <= 0f && num + num2 != 0f)
				{
					if (this.GetFireIntensityLevel() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
					{
						byte b = (byte)GameGeneral.GetRandom().Next(1, 11);
						GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit.GetProficiencyLevel();
						int? num3 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
						if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							b += 3;
						}
						else
						{
							num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								b += 2;
							}
							else
							{
								num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									b += 1;
								}
								else
								{
									num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
									{
										num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
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
								goto IL_62E;
							case 5:
							case 6:
							case 7:
							case 8:
								goto IL_62E;
							case 9:
							case 10:
								break;
							default:
								goto IL_62E;
							}
						}
						if (this.GetFireIntensityLevel() != ActiveUnit_Damage.FireIntensityLevel.Conflagration)
						{
							this.SetFireIntensityLevel(this.GetFireIntensityLevel() + 1);
						}
					}
					IL_62E:
					if (this.GetFloodingIntensityLevel() > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
					{
						byte b2 = (byte)GameGeneral.GetRandom().Next(1, 11);
						GlobalVariables.ProficiencyLevel? proficiencyLevel2 = this.activeUnit.GetProficiencyLevel();
						int? num3 = proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null;
						if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							b2 += 3;
						}
						else
						{
							num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								b2 += 2;
							}
							else
							{
								num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									b2 += 1;
								}
								else
								{
									num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
									if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
									{
										num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											b2 = (byte)Math.Max(0, (int)(b2 - 2));
										}
									}
								}
							}
						}
						b2 = (byte)Math.Max(0, (int)b2);
						if (b2 <= 10)
						{
							switch (b2)
							{
							case 1:
							case 2:
							case 3:
							case 4:
								this.vmethod_2((ActiveUnit_Damage.FloodingIntensityLevel)Math.Max(0, (int)(this.GetFloodingIntensityLevel() - ActiveUnit_Damage.FloodingIntensityLevel.Minor)));
								goto IL_8A5;
							case 5:
							case 6:
							case 7:
							case 8:
								goto IL_8A5;
							case 9:
							case 10:
								break;
							default:
								goto IL_8A5;
							}
						}
						if (this.GetFloodingIntensityLevel() != ActiveUnit_Damage.FloodingIntensityLevel.Capsizing)
						{
							this.vmethod_2(this.GetFloodingIntensityLevel() + 1);
						}
					}
					IL_8A5:
					this.TimeToNextSystemDamageCalculation = (float)GameGeneral.GetRandom().Next(900, 1801);
				}
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

		// Token: 0x06001E7F RID: 7807 RVA: 0x000C9244 File Offset: 0x000C7444
		protected void method_8(ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel_1)
		{
			try
			{
				if (floodingIntensityLevel_1 > this.GetFloodingIntensityLevel())
				{
					this.vmethod_2(floodingIntensityLevel_1);
				}
				else if (floodingIntensityLevel_1 == this.GetFloodingIntensityLevel() && this.GetFloodingIntensityLevel() != ActiveUnit_Damage.FloodingIntensityLevel.Capsizing)
				{
					double num = 0.0;
					switch (floodingIntensityLevel_1)
					{
					case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
						num = 0.5;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Major:
						num = 0.25;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
						num = 0.1;
						break;
					}
					if (GameGeneral.GetRandom().NextDouble() < num)
					{
						this.vmethod_2(this.GetFloodingIntensityLevel() + 1);
					}
				}
				this.TimeToNextSystemDamageCalculation = (float)GameGeneral.GetRandom().Next(120, 181);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100122", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000C934C File Offset: 0x000C754C
		protected void method_9(ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel_)
		{
			try
			{
				if (fireIntensityLevel_ > this.GetFireIntensityLevel())
				{
					this.SetFireIntensityLevel(fireIntensityLevel_);
				}
				else if (fireIntensityLevel_ == this.GetFireIntensityLevel() && this.GetFireIntensityLevel() != ActiveUnit_Damage.FireIntensityLevel.Conflagration)
				{
					double num = 0.0;
					switch (fireIntensityLevel_)
					{
					case ActiveUnit_Damage.FireIntensityLevel.Minor:
						num = 0.5;
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Major:
						num = 0.25;
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Severe:
						num = 0.1;
						break;
					}
					if (GameGeneral.GetRandom().NextDouble() < num)
					{
						this.SetFireIntensityLevel(this.GetFireIntensityLevel() + 1);
					}
				}
				this.TimeToNextSystemDamageCalculation = (float)GameGeneral.GetRandom().Next(120, 181);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100123", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000C9454 File Offset: 0x000C7654
		protected virtual PlatformComponent vmethod_14(int ARM_SpecifiedEmission = 0, bool ARM_ResolvedHitOnTargetedRadar = false)
		{
			PlatformComponent platformComponent = null;
			PlatformComponent result;
			try
			{
				if (!ARM_ResolvedHitOnTargetedRadar && ARM_SpecifiedEmission > 0)
				{
					List<PlatformComponent> list = new List<PlatformComponent>();
					foreach (PlatformComponent current in this.activeUnit.GetAllPlatformComponents())
					{
						if (current.IsSensor() && (((Sensor)current).DBID == ARM_SpecifiedEmission || (int)((Sensor)current).MasqueradeAs == ARM_SpecifiedEmission))
						{
							list.Add(current);
						}
					}
					if (list.Count > 0)
					{
						int index = GameGeneral.GetRandom().Next(0, list.Count);
						platformComponent = list[index];
						result = platformComponent;
						return result;
					}
				}
				float num = (float)(1.0 / (double)this.activeUnit.GetAllPlatformComponents().Count);
				if (num < 5f)
				{
					num = 5f;
				}
				int num2;
				PlatformComponent platformComponent2;
				float num3;
				do
				{
					num2 = GameGeneral.GetRandom().Next(0, this.activeUnit.GetAllPlatformComponents().Count);
					platformComponent2 = this.activeUnit.GetAllPlatformComponents()[num2];
					if (!platformComponent2.IsSensor() && !platformComponent2.IsMount() && !platformComponent2.IsCommDevice())
					{
						if (platformComponent2.IsAirFacility())
						{
							AirFacility._AirFacilityType airFacilityType = ((AirFacility)platformComponent2).GetAirFacilityType();
							switch (airFacilityType)
							{
							case AirFacility._AirFacilityType.Runway:
							case AirFacility._AirFacilityType.RunwayWithArrest:
							case AirFacility._AirFacilityType.RunwayAccessPoint:
							case AirFacility._AirFacilityType.AircraftCarrierSkiJump:
							case AirFacility._AirFacilityType.AircraftCarrierArrestingGear:
								goto IL_16C;
							case AirFacility._AirFacilityType.RunwayGradeTaxiway:
							case AirFacility._AirFacilityType.AircraftCarrierCatapult:
								break;
							default:
								if (airFacilityType - AirFacility._AirFacilityType.Pad <= 1 || airFacilityType - AirFacility._AirFacilityType.OpenParking <= 1)
								{
									goto IL_16C;
								}
								break;
							}
							num3 = num / 3f;
							goto IL_18E;
							IL_16C:
							num3 = num * 3f;
						}
						else
						{
							num3 = num / 3f;
						}
					}
					else
					{
						num3 = 2f * num;
					}
					IL_18E:
					if ((double)num3 > 0.9)
					{
						num3 = 0.9f;
					}
					num2 = GameGeneral.GetRandom().Next(1, 101);
				}
				while ((double)num2 / 100.0 >= (double)num3);
				platformComponent = platformComponent2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100124", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				platformComponent = null;
				ProjectData.ClearProjectError();
			}
			result = platformComponent;
			return result;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000C9708 File Offset: 0x000C7908
		protected int method_10(double ShockDamage, Warhead.WarheadType WarheadType, float TargetDP, float PenetrationPercentage, int ARM_TargetedRadar = 0)
		{
			int num = 0;
			int result;
			try
			{
				float num2 = (float)Math.Round(ShockDamage / (double)TargetDP, 2);
				if (this.activeUnit.GetAllPlatformComponents().Count == 0)
				{
					num = 0;
				}
				else if (WarheadType != Warhead.WarheadType.Fragmentation && WarheadType != Warhead.WarheadType.Cluster_AP && WarheadType != Warhead.WarheadType.Cluster_AT)
				{
					int num3 = GameGeneral.GetRandom().Next(1, 8);
					num3 = (int)Math.Round((double)((float)num3 * (PenetrationPercentage + 1f)));
					if (WarheadType == Warhead.WarheadType.Torpedo)
					{
						num3 += 5;
					}
					double num4 = Math.Round((double)num2, 1);
					if (num4 < 0.1)
					{
						num = num3 - 6;
						result = num;
						return result;
					}
					if (num4 == 0.1)
					{
						num = num3 - 4;
						result = num;
						return result;
					}
					if (num4 == 0.2)
					{
						num = num3 - 3;
						result = num;
						return result;
					}
					if (num4 == 0.3)
					{
						num = num3 - 2;
						result = num;
						return result;
					}
					if (num4 == 0.4)
					{
						num = num3 - 1;
						result = num;
						return result;
					}
					if (num4 == 0.5)
					{
						num = num3;
						result = num;
						return result;
					}
					if (num4 == 0.6)
					{
						num = num3 + 1;
						result = num;
						return result;
					}
					if (num4 == 0.7)
					{
						num = num3 + 2;
						result = num;
						return result;
					}
					if (num4 == 0.8)
					{
						num = num3 + 3;
						result = num;
						return result;
					}
					if (num4 == 0.9)
					{
						num = num3 + 4;
						result = num;
						return result;
					}
					num = num3 + 5;
					result = num;
					return result;
				}
				else
				{
					int num5 = 0;
					int num6;
					if (ShockDamage <= 10.0)
					{
						num6 = 1;
					}
					else if (ShockDamage <= 20.0)
					{
						num6 = 2;
					}
					else if (ShockDamage <= 50.0)
					{
						num6 = 3;
					}
					else if (ShockDamage <= 100.0)
					{
						num6 = 4;
					}
					else
					{
						num6 = 5;
					}
					int num7 = num6;
					for (int i = 1; i <= num7; i++)
					{
						int num3 = GameGeneral.GetRandom().Next(1, 8);
						num5 += num3;
					}
					num = num5;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100125", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000C99B8 File Offset: 0x000C7BB8
		public virtual void vmethod_15(float elapsedTime_)
		{
			if (this.activeUnit.m_Scenario.SecondIsChangingOnThisPulse && this.activeUnit.m_Scenario.GetCurrentTime(false).Minute == 0 && this.activeUnit.m_Scenario.GetCurrentTime(false).Second == 0)
			{
				this.DoRepair(this.activeUnit.GetProficiencyLevel().Value);
				if (this.activeUnit.IsFacility)
				{
					this.PutOffFireOrFloodingDisaster(this.activeUnit.GetProficiencyLevel().Value);
				}
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000C9A58 File Offset: 0x000C7C58
		public void PutOffFireOrFloodingDisaster(GlobalVariables.ProficiencyLevel proficiencyLevel_)
		{
			try
			{
				if (this.GetFireIntensityLevel() <= ActiveUnit_Damage.FireIntensityLevel.Minor && this.GetFloodingIntensityLevel() <= ActiveUnit_Damage.FloodingIntensityLevel.Minor && this.activeUnit.GetDamagePts(false) < (float)this.activeUnit.GetInitialDP())
				{
					float num = 100f - this.GetDamagePts();
					switch (proficiencyLevel_)
					{
					case GlobalVariables.ProficiencyLevel.Novice:
						num = (float)((double)num * 0.3);
						break;
					case GlobalVariables.ProficiencyLevel.Cadet:
						num = (float)((double)num * 0.5);
						break;
					case GlobalVariables.ProficiencyLevel.Regular:
						num = (float)((double)num * 0.8);
						break;
					case GlobalVariables.ProficiencyLevel.Veteran:
						num = (float)((double)num * 1.0);
						break;
					case GlobalVariables.ProficiencyLevel.Ace:
						num = (float)((double)num * 1.5);
						break;
					}
					if ((float)GameGeneral.GetRandom().Next(1, 101) < num)
					{
						ActiveUnit activeUnit;
						(activeUnit = this.activeUnit).SetDamagePts(false, activeUnit.GetDamagePts(false) + (float)((int)Math.Round((double)(this.activeUnit.GetDamagePts(false) / 100f))));
						if (this.activeUnit.GetDamagePts(false) >= (float)this.activeUnit.GetInitialDP())
						{
							if (this.activeUnit.GetDamagePts(false) > (float)this.activeUnit.GetInitialDP())
							{
								this.activeUnit.SetDamagePts(false, (float)this.activeUnit.GetInitialDP());
							}
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + ":全面恢复结构完整性! ", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
						else
						{
							this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + ":结构性毁伤已恢复,恢复率:" + Conversions.ToString(Math.Round((double)this.activeUnit.GetDamage().GetDamagePts(), 1)) + "%. ", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100128", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000C9D20 File Offset: 0x000C7F20
		public void DoRepair(GlobalVariables.ProficiencyLevel proficiencyLevel_)
		{
			try
			{
				float num = 100f - this.GetDamagePts();
				switch (proficiencyLevel_)
				{
				case GlobalVariables.ProficiencyLevel.Novice:
					num = (float)((double)num * 0.3);
					break;
				case GlobalVariables.ProficiencyLevel.Cadet:
					num = (float)((double)num * 0.5);
					break;
				case GlobalVariables.ProficiencyLevel.Regular:
					num = (float)((double)num * 0.8);
					break;
				case GlobalVariables.ProficiencyLevel.Veteran:
					num = (float)((double)num * 1.0);
					break;
				case GlobalVariables.ProficiencyLevel.Ace:
					num = (float)((double)num * 1.5);
					break;
				}
				foreach (PlatformComponent current in this.activeUnit.GetAllPlatformComponents())
				{
					if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
					{
						switch (current.GetDamageSeverity())
						{
						case PlatformComponent._DamageSeverityFactor.Light:
							num -= 10f;
							if ((float)GameGeneral.GetRandom().Next(1, 101) < num)
							{
								current.method_25(false);
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(current.Name) + "已被全面修复.", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
							break;
						case PlatformComponent._DamageSeverityFactor.Medium:
							if (this.activeUnit.IsOperating() && !this.activeUnit.IsFacility)
							{
								return;
							}
							num -= 20f;
							if ((float)GameGeneral.GetRandom().Next(1, 101) < num)
							{
								current.SetDamageSeverity(PlatformComponent._DamageSeverityFactor.Light);
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(current.Name) + "正在修复(轻度毁伤).", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
							break;
						case PlatformComponent._DamageSeverityFactor.Heavy:
							if (this.activeUnit.IsOperating() && !this.activeUnit.IsFacility)
							{
								return;
							}
							num -= 30f;
							if ((float)GameGeneral.GetRandom().Next(1, 101) < num)
							{
								current.SetDamageSeverity(PlatformComponent._DamageSeverityFactor.Medium);
								this.activeUnit.m_Scenario.LogMessage(Misc.smethod_11(this.activeUnit.Name) + "毁伤状态报告: " + Misc.smethod_11(current.Name) + "正在修复(中度毁伤).", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit.GetGuid(), this.activeUnit.GetSide(false), new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100128", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000CA0D4 File Offset: 0x000C82D4
		public void AssessDamage(float float_1)
		{
			if (float_1 != 0f && !this.activeUnit.IsUnderGround() && !this.activeUnit.IsUnderWater())
			{
				if (this.activeUnit.GetNoneMCMSensors().Length > 0 || this.activeUnit.GetCommDevices().Length > 0)
				{
					this.activeUnit.LogMessage(this.activeUnit.Name + "被电磁脉冲波命中!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)));
				}
				new WeaponImpact(ref this.activeUnit.m_Scenario, this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null), this.activeUnit.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.const_1);
				using (IEnumerator<PlatformComponent> enumerator = this.activeUnit.GetAllPlatformComponents().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.DamageAssessment(float_1);
					}
				}
			}
		}

		// Token: 0x04000DF3 RID: 3571
		public static Func<Mount, bool> UndestroyedMount = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04000DF4 RID: 3572
		public static Func<AirFacility, bool> AirFacilityFunc1 = (AirFacility airFacility_0) => airFacility_0.method_35();

		// Token: 0x04000DF5 RID: 3573
		public static Func<Sensor, Sensor> SensorFunc2 = (Sensor sensor_0) => sensor_0;

		// Token: 0x04000DF6 RID: 3574
		public static Func<AirFacility, bool> AirFacilityFunc3 = (AirFacility airFacility_0) => airFacility_0.method_35();

		// Token: 0x04000DF7 RID: 3575
		protected ActiveUnit activeUnit;

		// Token: 0x04000DF8 RID: 3576
		[CompilerGenerated]
		private static ActiveUnit_Damage.Delegate1 delegate1_0;

		// Token: 0x04000DF9 RID: 3577
		protected ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel;

		// Token: 0x04000DFA RID: 3578
		protected ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel;

		// Token: 0x04000DFB RID: 3579
		protected float TimeToNextSystemDamageCalculation;

		// Token: 0x0200049B RID: 1179
		// (Invoke) Token: 0x06001E8D RID: 7821
		public delegate void Delegate1(ActiveUnit myUnit);

		// Token: 0x0200049C RID: 1180
		public enum FireIntensityLevel : byte
		{
			// Token: 0x04000E01 RID: 3585
			NoFire,
			// Token: 0x04000E02 RID: 3586
			Minor,
			// Token: 0x04000E03 RID: 3587
			Major,
			// Token: 0x04000E04 RID: 3588
			Severe,
			// Token: 0x04000E05 RID: 3589
			Conflagration
		}

		// Token: 0x0200049D RID: 1181
		public enum FloodingIntensityLevel : byte
		{
			// Token: 0x04000E07 RID: 3591
			NoFlooding,
			// Token: 0x04000E08 RID: 3592
			Minor,
			// Token: 0x04000E09 RID: 3593
			Major,
			// Token: 0x04000E0A RID: 3594
			Severe,
			// Token: 0x04000E0B RID: 3595
			Capsizing
		}

		// Token: 0x0200049E RID: 1182
		[CompilerGenerated]
		public sealed class AntiRadiationMissile
		{
			// Token: 0x06001E90 RID: 7824 RVA: 0x00012731 File Offset: 0x00010931
			internal bool IsTargetForMe(Sensor sensor_)
			{
				return sensor_.IsEmmitting() && (sensor_.DBID == this.ARM.ARM_SpecifiedEmission.Key || (int)sensor_.MasqueradeAs == this.ARM.ARM_SpecifiedEmission.Key);
			}

			// Token: 0x04000E0C RID: 3596
			public Weapon ARM;
		}

		// Token: 0x0200049F RID: 1183
		[CompilerGenerated]
		public sealed class EmissionContainerMan
		{
			// Token: 0x06001E92 RID: 7826 RVA: 0x00012771 File Offset: 0x00010971
			internal bool IsEmissionInMyContainer(Sensor sensor_)
			{
				return sensor_.DBID == this.EmissionContainerPair.Key || (int)sensor_.MasqueradeAs == this.EmissionContainerPair.Key;
			}

			// Token: 0x04000E0D RID: 3597
			public KeyValuePair<int, EmissionContainer> EmissionContainerPair;
		}
	}
}
