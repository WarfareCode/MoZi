using System;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 0x02000B85 RID: 2949
	public sealed class XSection : Subject
	{
		// Token: 0x06006184 RID: 24964 RVA: 0x002F2238 File Offset: 0x002F0438
		public void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("XSection");
				xmlWriter_0.WriteElementString("Front", XmlConvert.ToString(this.Front));
				xmlWriter_0.WriteElementString("Side", XmlConvert.ToString(this.Side));
				xmlWriter_0.WriteElementString("Rear", XmlConvert.ToString(this.Rear));
				xmlWriter_0.WriteElementString("Top", XmlConvert.ToString(this.Top));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int signatureType = (int)this.SignatureType;
				xmlWriter.WriteElementString(localName, signatureType.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101079", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x002F2324 File Offset: 0x002F0524
		public float GetFrontXSection(ActiveUnit activeUnit_)
		{
			float num = 0f;
			float result;
			try
			{
				if (activeUnit_.IsSubmarine)
				{
					Submarine submarine = (Submarine)activeUnit_;
					if (submarine.IsShallowerThanPeriscopeDepth())
					{
						num = this.Front;
					}
					else if (submarine.IsAtPeriscopeDepth())
					{
						if (activeUnit_.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
						{
							XSection._SignatureType signatureType = this.SignatureType;
							if (signatureType - XSection._SignatureType.VisualDetectionRange > 1)
							{
								if (signatureType - XSection._SignatureType.InfraredDetectionRange > 1)
								{
									if (signatureType - XSection._SignatureType.Radar_A_D_Band <= 1)
									{
										num = -20f;
									}
									else
									{
										num = this.Front;
									}
								}
								else
								{
									num = 2f;
								}
							}
							else
							{
								num = 2f;
							}
						}
						else
						{
							XSection._SignatureType signatureType2 = this.SignatureType;
							if (signatureType2 - XSection._SignatureType.VisualDetectionRange > 1)
							{
								if (signatureType2 - XSection._SignatureType.InfraredDetectionRange > 1)
								{
									if (signatureType2 - XSection._SignatureType.Radar_A_D_Band <= 1)
									{
										num = -30f;
									}
									else
									{
										num = this.Front;
									}
								}
								else
								{
									num = 2f;
								}
							}
							else
							{
								num = 2f;
							}
						}
					}
					else
					{
						num = this.Front;
					}
				}
				else if (activeUnit_.IsAircraft)
				{
					XSection._SignatureType signatureType3 = this.SignatureType;
					if (signatureType3 != XSection._SignatureType.InfraredDetectionRange)
					{
						if (signatureType3 - XSection._SignatureType.Radar_A_D_Band <= 1)
						{
							num = this.GetTargetRCSModifiedByLoadout((Aircraft)activeUnit_, this.Front, this.SignatureType, XSection.Enum94.Front);
						}
						else
						{
							num = this.Front;
						}
					}
					else
					{
						double num2 = (double)Class263.GetIRCrossSectionModifier((double)activeUnit_.GetCurrentAltitude_ASL(false), (double)activeUnit_.GetCurrentSpeed());
						float num3;
						if (num2 > 1.0)
						{
							num3 = (float)((double)this.Front * num2);
						}
						else
						{
							num3 = this.Front;
						}
						num = num3;
					}
				}
				else if (activeUnit_.IsGuidedWeapon_RV_HGV())
				{
					XSection._SignatureType signatureType4 = this.SignatureType;
					if (signatureType4 != XSection._SignatureType.VisualDetectionRange && signatureType4 != XSection._SignatureType.InfraredDetectionRange)
					{
						num = this.Front;
						result = num;
						return result;
					}
					Engine._PropulsionType propulsionType = activeUnit_.GetEngines()[0].PropulsionType;
					float num3;
					if (propulsionType == Engine._PropulsionType.Rocket)
					{
						Weapon weapon = (Weapon)activeUnit_;
						if (!Information.IsNothing(weapon.LaunchPoint) && weapon.HorizontalRangeTo(weapon.LaunchPoint) <= weapon.GetLargestRangeMaxOfAllDomains())
						{
							num3 = 5f * this.Front;
						}
						else
						{
							num3 = this.Front;
						}
					}
					else
					{
						num3 = this.Front;
					}
					double num4 = (double)Class263.GetIRCrossSectionModifier((double)activeUnit_.GetCurrentAltitude_ASL(false), (double)activeUnit_.GetCurrentSpeed());
					if (num4 > 1.0)
					{
						num3 = (float)((double)num3 * num4);
					}
					num = num3;
				}
				else
				{
					num = this.Front;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101288", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = this.Front;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x002F265C File Offset: 0x002F085C
		public float GetSideXSection(ActiveUnit activeUnit_)
		{
			float num = 0f;
			float result;
			try
			{
				if (activeUnit_.IsSubmarine)
				{
					if (((Submarine)activeUnit_).IsShallowerThanPeriscopeDepth())
					{
						num = this.Side;
					}
					else if (((Submarine)activeUnit_).IsAtPeriscopeDepth())
					{
						XSection._SignatureType signatureType = this.SignatureType;
						if (signatureType - XSection._SignatureType.VisualDetectionRange > 1)
						{
							if (signatureType - XSection._SignatureType.InfraredDetectionRange > 1)
							{
								if (signatureType - XSection._SignatureType.Radar_A_D_Band <= 1)
								{
									num = -30f;
								}
								else
								{
									num = this.Side;
								}
							}
							else
							{
								num = 2f;
							}
						}
						else
						{
							num = 2f;
						}
					}
					else
					{
						num = this.Side;
					}
				}
				else if (activeUnit_.IsAircraft)
				{
					XSection._SignatureType signatureType = this.SignatureType;
					if (signatureType != XSection._SignatureType.InfraredDetectionRange)
					{
						if (signatureType - XSection._SignatureType.Radar_A_D_Band > 1)
						{
							num = this.Side;
						}
						else
						{
							num = this.GetTargetRCSModifiedByLoadout((Aircraft)activeUnit_, this.Side, this.SignatureType, XSection.Enum94.Side);
						}
					}
					else
					{
						float side = this.Side;
						double num2 = (double)Class263.GetIRCrossSectionModifier((double)activeUnit_.GetCurrentAltitude_ASL(false), (double)activeUnit_.GetCurrentSpeed());
						if (num2 < 1.0)
						{
							num2 = 1.0;
						}
						switch (activeUnit_.GetThrottle())
						{
						case ActiveUnit.Throttle.FullStop:
							num = (float)((double)side * num2 * 1.5);
							break;
						case ActiveUnit.Throttle.Loiter:
							num = (float)((double)side * num2 * 0.85);
							break;
						case ActiveUnit.Throttle.Cruise:
							num = (float)((double)side * num2);
							break;
						case ActiveUnit.Throttle.Full:
							num = (float)((double)side * num2 * 1.2);
							break;
						case ActiveUnit.Throttle.Flank:
							num = (float)((double)side * num2 * 1.5);
							break;
						default:
							num = this.Side;
							break;
						}
					}
				}
				else if (activeUnit_.IsGuidedWeapon_RV_HGV())
				{
					XSection._SignatureType signatureType = this.SignatureType;
					if (signatureType != XSection._SignatureType.VisualDetectionRange && signatureType != XSection._SignatureType.InfraredDetectionRange)
					{
						num = this.Side;
						result = num;
						return result;
					}
					Engine._PropulsionType propulsionType = activeUnit_.GetEngines()[0].PropulsionType;
					float num3;
					if (propulsionType == Engine._PropulsionType.Rocket)
					{
						Weapon weapon = (Weapon)activeUnit_;
						if (!Information.IsNothing(weapon.LaunchPoint) && weapon.HorizontalRangeTo(weapon.LaunchPoint) <= weapon.GetLargestRangeMaxOfAllDomains())
						{
							num3 = 5f * this.Side;
						}
						else
						{
							num3 = this.Side;
						}
					}
					else
					{
						num3 = this.Side;
					}
					double num4 = (double)Class263.GetIRCrossSectionModifier((double)activeUnit_.GetCurrentAltitude_ASL(false), (double)activeUnit_.GetCurrentSpeed());
					if (num4 > 1.0)
					{
						num3 = (float)((double)num3 * num4);
					}
					num = num3;
				}
				else
				{
					num = this.Side;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101289", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = this.Side;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x002F2994 File Offset: 0x002F0B94
		public float GetRearXSection(ActiveUnit activeUnit_)
		{
			float num = 0f;
			float result;
			try
			{
				if (activeUnit_.IsSubmarine)
				{
					if (((Submarine)activeUnit_).IsShallowerThanPeriscopeDepth())
					{
						num = this.Rear;
					}
					else if (((Submarine)activeUnit_).IsAtPeriscopeDepth())
					{
						XSection._SignatureType signatureType = this.SignatureType;
						if (signatureType - XSection._SignatureType.VisualDetectionRange > 1)
						{
							if (signatureType - XSection._SignatureType.InfraredDetectionRange > 1)
							{
								if (signatureType - XSection._SignatureType.Radar_A_D_Band <= 1)
								{
									num = -30f;
								}
								else
								{
									num = this.Rear;
								}
							}
							else
							{
								num = 2f;
							}
						}
						else
						{
							num = 2f;
						}
					}
					else
					{
						num = this.Rear;
					}
				}
				else if (activeUnit_.IsAircraft)
				{
					XSection._SignatureType signatureType2 = this.SignatureType;
					if (signatureType2 != XSection._SignatureType.InfraredDetectionRange)
					{
						if (signatureType2 - XSection._SignatureType.Radar_A_D_Band > 1)
						{
							num = this.Rear;
						}
						else
						{
							num = this.GetTargetRCSModifiedByLoadout((Aircraft)activeUnit_, this.Rear, this.SignatureType, XSection.Enum94.Rear);
						}
					}
					else
					{
						float rear = this.Rear;
						switch (activeUnit_.GetThrottle())
						{
						case ActiveUnit.Throttle.FullStop:
							num = (float)((double)rear * 1.5);
							break;
						case ActiveUnit.Throttle.Loiter:
							num = (float)((double)rear * 0.85);
							break;
						case ActiveUnit.Throttle.Cruise:
							num = rear;
							break;
						case ActiveUnit.Throttle.Full:
							num = (float)((double)rear * 1.2);
							break;
						case ActiveUnit.Throttle.Flank:
							num = (float)((double)rear * 1.5);
							break;
						default:
							num = this.Rear;
							break;
						}
					}
				}
				else if (activeUnit_.IsGuidedWeapon_RV_HGV())
				{
					XSection._SignatureType signatureType3 = this.SignatureType;
					if (signatureType3 != XSection._SignatureType.VisualDetectionRange && signatureType3 != XSection._SignatureType.InfraredDetectionRange)
					{
						num = this.Rear;
						result = num;
						return result;
					}
					Engine._PropulsionType propulsionType = activeUnit_.GetEngines()[0].PropulsionType;
					float num2;
					if (propulsionType == Engine._PropulsionType.Rocket)
					{
						Weapon weapon = (Weapon)activeUnit_;
						if (!Information.IsNothing(weapon.LaunchPoint) && weapon.HorizontalRangeTo(weapon.LaunchPoint) <= weapon.GetLargestRangeMaxOfAllDomains())
						{
							num2 = 5f * this.Rear;
						}
						else
						{
							num2 = this.Rear;
						}
					}
					else
					{
						num2 = this.Rear;
					}
					double num3 = (double)Class263.GetIRCrossSectionModifier((double)activeUnit_.GetCurrentAltitude_ASL(false), (double)activeUnit_.GetCurrentSpeed());
					if (num3 > 1.0)
					{
						num2 = (float)((double)num2 * num3);
					}
					num = num2;
				}
				else
				{
					num = this.Rear;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101290", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = this.Rear;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x0002B213 File Offset: 0x00029413
		private XSection()
		{
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x0002B226 File Offset: 0x00029426
		public XSection(XSection._SignatureType signatureType_, float Front_, float Side_, float Rear_, float Top_)
		{
			this.SignatureType = signatureType_;
			this.Front = Front_;
			this.Side = Side_;
			this.Rear = Rear_;
			this.Top = Top_;
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x002F2C90 File Offset: 0x002F0E90
		private float GetTargetRCSModifiedByLoadout(Aircraft aircraft_, float XSection_, XSection._SignatureType SignatureType_, XSection.Enum94 direction_)
		{
			ECM.Target target = new ECM.Target();
			float result = 0f;
			try
			{
				if (Information.IsNothing(aircraft_.GetLoadout()))
				{
					result = XSection_;
				}
				else
				{
					target.RCS = (double)XSection_;
					float num = (float)target.GetRCS_m2();
					WeaponRec[] weaponRecArray = aircraft_.GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
					{
						WeaponRec weaponRec = weaponRecArray[i];
						if (!weaponRec.IW)
						{
							Weapon weapon = weaponRec.GetWeapon(aircraft_.m_Scenario);
							if (weapon.IsTank())
							{
								if (Information.IsNothing(this.weapon_JDAM))
								{
									this.weapon_JDAM = aircraft_.m_Scenario.GetWeapon(554);
								}
								weapon = this.weapon_JDAM;
							}
							else if (weapon.GetWeaponType() == Weapon._WeaponType.SensorPod)
							{
								if (Information.IsNothing(this.weapon_KAB_1500))
								{
									this.weapon_KAB_1500 = aircraft_.m_Scenario.GetWeapon(641);
								}
								weapon = this.weapon_KAB_1500;
							}
							XSection crossSection = Sensor.GetCrossSection(weapon, SignatureType_);
							if (Information.IsNothing(crossSection))
							{
								crossSection = Sensor.GetCrossSection(weapon, SignatureType_);
							}
							if (!Information.IsNothing(crossSection))
							{
								float num2 = 0f;
								short num3 = 0;
								switch (direction_)
								{
								case XSection.Enum94.Front:
								{
									num2 = Sensor.GetCrossSection(weapon, SignatureType_).GetFrontXSection(weapon);
									num3 = (short)weaponRec.GetCurrentLoad();
									short num4 = num3;
									if (num4 > 6)
									{
										if (num4 <= 12)
										{
											num3 = 6;
										}
										else
										{
											num3 = (short)Math.Round(Math.Floor((double)num3 / 3.0));
										}
									}
									break;
								}
								case XSection.Enum94.Side:
									num2 = Sensor.GetCrossSection(weapon, SignatureType_).GetSideXSection(weapon);
									num3 = (short)Math.Round((double)weaponRec.GetCurrentLoad() / 2.0);
									break;
								case XSection.Enum94.Rear:
								{
									num2 = Sensor.GetCrossSection(weapon, SignatureType_).GetRearXSection(weapon);
									num3 = (short)weaponRec.GetCurrentLoad();
									short num5 = num3;
									if (num5 > 6)
									{
										if (num5 <= 12)
										{
											num3 = 6;
										}
										else
										{
											num3 = (short)Math.Round(Math.Floor((double)num3 / 6.0));
										}
									}
									break;
								}
								}
								if (num2 != 0f)
								{
									target.RCS = (double)num2;
									float num6 = (float)target.GetRCS_m2();
									num = (float)((double)num + (double)(num6 * (float)num3) * 1.2);
								}
							}
						}
					}
					target.SetRCS((double)num);
					result = (float)target.RCS;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101081", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04003470 RID: 13424
		private float Front;

		// Token: 0x04003471 RID: 13425
		private float Side;

		// Token: 0x04003472 RID: 13426
		private float Rear = 0f;

		// Token: 0x04003473 RID: 13427
		private float Top;

		// Token: 0x04003474 RID: 13428
		public XSection._SignatureType SignatureType;

		// Token: 0x04003475 RID: 13429
		private Weapon weapon_JDAM;

		// Token: 0x04003476 RID: 13430
		private Weapon weapon_KAB_1500;

		// Token: 0x02000B86 RID: 2950
		public enum _SignatureType : short
		{
			// Token: 0x04003478 RID: 13432
			PassiveSonar_VLF = 1001,
			// Token: 0x04003479 RID: 13433
			PassiveSonar_LF,
			// Token: 0x0400347A RID: 13434
			PassiveSonar_MF,
			// Token: 0x0400347B RID: 13435
			PassiveSonar_HF,
			// Token: 0x0400347C RID: 13436
			ActiveSonar_VLF_HF = 2001,
			// Token: 0x0400347D RID: 13437
			VisualDetectionRange = 3001,
			// Token: 0x0400347E RID: 13438
			VisualClassificationRange,
			// Token: 0x0400347F RID: 13439
			InfraredDetectionRange = 4001,
			// Token: 0x04003480 RID: 13440
			InfraredClassificationRange,
			// Token: 0x04003481 RID: 13441
			Radar_A_D_Band = 5001,
			// Token: 0x04003482 RID: 13442
			Radar_E_M_Band
		}

		// Token: 0x02000B87 RID: 2951
		public enum Enum94 : short
		{
			// Token: 0x04003484 RID: 13444
			Front,
			// Token: 0x04003485 RID: 13445
			Side,
			// Token: 0x04003486 RID: 13446
			Rear
		}
	}
}
