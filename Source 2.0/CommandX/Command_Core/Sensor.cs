using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using Sharp3D.Math.Core;

namespace Command_Core
{
	// Token: 传感器部件
	public sealed class Sensor : PlatformComponent
	{
		// Token: 0x06005B9E RID: 23454 RVA: 0x00295428 File Offset: 0x00293628
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Sensor");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (!Information.IsNothing(hashSet_1))
				{
					if (hashSet_1.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
						return;
					}
					hashSet_1.Add(base.GetGuid());
				}
				xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
				if (this.m_ComponentStatus != PlatformComponent._ComponentStatus.Operational)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "St";
					byte componentStatus = (byte)this.m_ComponentStatus;
					xmlWriter.WriteElementString(localName, componentStatus.ToString());
				}
				if (base.GetDamageSeverity() != PlatformComponent._DamageSeverityFactor.Light)
				{
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
				}
				xmlWriter_0.WriteElementString("Name", this.Name);
				if (this.coverageArc.HasSomeCoverage())
				{
					this.coverageArc.Save(xmlWriter_0, false);
				}
				if (this.coverageArcMax.HasSomeCoverage())
				{
					this.coverageArcMax.Save(xmlWriter_0, true);
				}
				if (this.TargetsTrackedForFireControl.Count > 0)
				{
					xmlWriter_0.WriteStartElement("TTFFC");
					foreach (Contact current in this.TargetsTrackedForFireControl)
					{
						if (!Information.IsNothing(current))
						{
							xmlWriter_0.WriteElementString("ID", current.GetGuid());
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.SemiActiveGuidedWeaponList.Count > 0)
				{
					xmlWriter_0.WriteStartElement("SAWG");
					List<Weapon> list = this.SemiActiveGuidedWeaponList.ToList<Weapon>();
					foreach (Weapon current2 in list)
					{
						if (!Information.IsNothing(current2))
						{
							xmlWriter_0.WriteElementString("ID", current2.GetGuid());
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.IsEmmitting())
				{
					xmlWriter_0.WriteElementString("IsA", this.IsEmmitting().ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100693", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x002956E8 File Offset: 0x002938E8
		private Sensor() : base(null)
		{
			this.sensorCapability = default(Sensor.SensorCapability);
			this.sensorCode = default(Sensor.SensorCode);
			this.SearchAndTrackFrequencies = new Sensor.RadioElectronicFrequency[0];
			this.SensorFrequencyIlluminateArray = new Sensor.RadioElectronicFrequency[0];
			this.TargetsTrackedForFireControl = new List<Contact>();
			this.SemiActiveGuidedWeaponList = new List<Weapon>();
			this.SemiActiveWeaponsGuided = new Collection<string>();
			this.coverageArcMax = default(PlatformComponent._CoverageArc);
			this.m_Radar = new ECM.Radar();
			this.Receiver = default(ECM.Receiver);
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x00295770 File Offset: 0x00293970
		public static Sensor Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, ActiveUnit activeUnit_1)
		{
			Sensor sensor2;
			Sensor result;
			try
			{
				Sensor sensor = new Sensor();
				sensor.SetParentPlatform(activeUnit_1);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1376249658u)
						{
							if (num <= 330354518u)
							{
								if (num <= 266367750u)
								{
									if (num != 6222351u)
									{
										if (num == 266367750u && Operators.CompareString(name, "Name", false) == 0)
										{
											sensor.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "Status", false) != 0)
									{
										continue;
									}
								}
								else if (num != 280566373u)
								{
									if (num != 330354518u)
									{
										continue;
									}
									if (Operators.CompareString(name, "SemiActiveWeaponsGuided", false) != 0)
									{
										continue;
									}
									goto IL_541;
								}
								else
								{
									if (Operators.CompareString(name, "TargetsIlluminated", false) != 0)
									{
										continue;
									}
									goto IL_222;
								}
							}
							else if (num <= 1258451042u)
							{
								if (num != 429170076u)
								{
									if (num != 1258451042u || Operators.CompareString(name, "St", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "IsA", false) != 0)
									{
										continue;
									}
									goto IL_4A7;
								}
							}
							else if (num != 1351886453u)
							{
								if (num != 1376249658u)
								{
									continue;
								}
								if (Operators.CompareString(name, "TTFFC", false) != 0)
								{
									continue;
								}
								goto IL_222;
							}
							else
							{
								if (Operators.CompareString(name, "TargetsTrackedForFireControl", false) == 0)
								{
									goto IL_222;
								}
								continue;
							}
							string innerText = xmlNode.InnerText;
							if (Operators.CompareString(innerText, "Operational", false) == 0)
							{
								sensor.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
								continue;
							}
							if (Operators.CompareString(innerText, "Damaged", false) == 0)
							{
								sensor.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
								continue;
							}
							if (Operators.CompareString(innerText, "Destroyed", false) != 0)
							{
								sensor.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							sensor.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
							continue;
							IL_222:
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Contact contact = Contact.GetContact(((XmlNode)enumerator2.Current).InnerText, ref dictionary_0);
									sensor.TargetsTrackedForFireControl.Add(contact);
								}
								continue;
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						if (num <= 1548823463u)
						{
							if (num <= 1458105184u)
							{
								if (num != 1413108551u)
								{
									if (num != 1458105184u || (Operators.CompareString(name, "ID", false) != 0 || Information.IsNothing(dictionary_0)))
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										sensor.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(sensor.GetGuid(), sensor);
										continue;
									}
									sensor2 = (Sensor)dictionary_0[xmlNode.InnerText];
									result = sensor2;
									return result;
								}
								else
								{
									if (Operators.CompareString(name, "Cov_Ill", false) != 0)
									{
										continue;
									}
									goto IL_51E;
								}
							}
							else if (num != 1528329603u)
							{
								if (num == 1548823463u && Operators.CompareString(name, "DamageSeverity", false) == 0)
								{
									sensor.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "Cov", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 2187602126u)
						{
							if (num != 2130724671u)
							{
								if (num == 2187602126u && Operators.CompareString(name, "DBID", false) == 0)
								{
									int dBID = Conversions.ToInteger(xmlNode.InnerText);
									SQLiteConnection sQLiteConnection = activeUnit_1.m_Scenario.GetSQLiteConnection();
									Sensor sensor3 = DBFunctions.LoadSensorData(dBID, ref sQLiteConnection);
									sensor3.SetGuid(sensor.GetGuid());
									sensor3.m_ComponentStatus = sensor.GetComponentStatus();
									sensor3.Name = sensor.Name;
									sensor3.DBID = Conversions.ToInteger(xmlNode.InnerText);
									sensor3.coverageArc = sensor.coverageArc;
									foreach (Contact current in sensor.GetTargetsTrackedForFireControl())
									{
										sensor3.TargetsTrackedForFireControl.Add(current);
									}
									sensor3.SemiActiveGuidedWeaponList = sensor.SemiActiveGuidedWeaponList;
									if (sensor.IsEmmitting())
									{
										sensor3.TurnOn();
									}
									sensor = sensor3;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "IsActive", false) == 0)
								{
									goto IL_4A7;
								}
								continue;
							}
						}
						else if (num != 2890953655u)
						{
							if (num != 2967663950u)
							{
								if (num != 3309953595u || Operators.CompareString(name, "Coverage", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Coverage_Illuminate", false) == 0)
								{
									goto IL_51E;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "SAWG", false) == 0)
							{
								goto IL_541;
							}
							continue;
						}
						sensor.coverageArc = PlatformComponent._CoverageArc.SetCoverageIlluminate(ref xmlNode);
						continue;
						IL_51E:
						sensor.coverageArcMax = PlatformComponent._CoverageArc.SetCoverageIlluminate(ref xmlNode);
						continue;
						IL_4A7:
						sensor.bActive = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_541:
						IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator4.Current;
								sensor.SemiActiveWeaponsGuided.Add(xmlNode2.ChildNodes[0].InnerText);
							}
						}
						finally
						{
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
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
				if (string.IsNullOrEmpty(sensor.Name))
				{
					if (sensor.DBID == 0)
					{
						sensor.Name = "Mk1 Eyeball";
					}
					else
					{
						Subject subject = sensor;
						int dBID2 = sensor.DBID;
						SQLiteConnection sQLiteConnection = activeUnit_1.m_Scenario.GetSQLiteConnection();
						subject.Name = DBFunctions.GetSensorName(dBID2, ref sQLiteConnection);
					}
				}
				sensor2 = sensor;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100694", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				sensor2 = new Sensor();
				ProjectData.ClearProjectError();
			}
			result = sensor2;
			return result;
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00285998 File Offset: 0x00283B98
		public override PlatformComponent._ComponentStatus GetComponentStatus()
		{
			return base.GetComponentStatus();
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x0002909D File Offset: 0x0002729D
		public bool IsScanningOrTrackingThisPulse()
		{
			return this.NextScan <= 0 || this.GetTargetsTrackedForFireControl().Count > 0;
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x000290B9 File Offset: 0x000272B9
		public bool IsEndOfDetectionCycle()
		{
			return this.OODADetectionCycle <= 0;
		}

        // Token: 0x06005BA4 RID: 23460 RVA: 0x00295E84 File Offset: 0x00294084
        //public bool method_28(bool IsRadarConsidered, bool IsSonarConsidered)
        public bool IsRadarSonarVisual(bool IsRadarConsidered, bool IsSonarConsidered)
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool result;
			if (sensorType != Sensor.SensorType.Radar)
			{
				if (sensorType - Sensor.SensorType.Visual <= 1)
				{
					result = true;
					return result;
				}
			}
			else if (IsRadarConsidered && this.sensorCode.Classification_BrilliantWeapon)
			{
				result = true;
				return result;
			}
			result = (IsSonarConsidered && this.IsSonar() && !this.IsEmmitting());
			return result;
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00295EE8 File Offset: 0x002940E8
		public bool IsEmissionDetectionOnly()
		{
			Sensor.SensorType sensorType = this.sensorType;
			return sensorType == Sensor.SensorType.ESM || sensorType == Sensor.SensorType.PingIntercept;
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00295F18 File Offset: 0x00294118
		public bool IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand frequencyBand_)
		{
			Sensor.RadioElectronicFrequency[] searchAndTrackFrequencies = this.SearchAndTrackFrequencies;
			checked
			{
				bool result;
				for (int i = 0; i < searchAndTrackFrequencies.Length; i++)
				{
					if (searchAndTrackFrequencies[i].frequencyBand == frequencyBand_)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00295F54 File Offset: 0x00294154
		public bool IsIlluminateFrequenciesCover(Sensor.FrequencyBand frequencyBand_0)
		{
			Sensor.RadioElectronicFrequency[] sensorFrequencyIlluminateArray = this.SensorFrequencyIlluminateArray;
			checked
			{
				bool result;
				for (int i = 0; i < sensorFrequencyIlluminateArray.Length; i++)
				{
					if (sensorFrequencyIlluminateArray[i].frequencyBand == frequencyBand_0)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x00295F90 File Offset: 0x00294190
		public float GetCombinedPortAndStarboardArcs()
		{
			return this.GetPortSensorCoverage() + this.GetStarboardSensorCoverage();
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00295FAC File Offset: 0x002941AC
		public float GetPortSensorCoverage()
		{
			float result = 0f;
			try
			{
				float num = 0f;
				if (this.coverageArc.PB2 || this.coverageArc.PS1)
				{
					num = (float)((double)this.MaxRange * Math2.Sin_D(22.5));
				}
				if (this.coverageArc.PB1 || this.coverageArc.PS2)
				{
					num = (float)((double)this.MaxRange * Math2.Sin_D(45.0));
				}
				if (this.coverageArc.PMF2 || this.coverageArc.PMA1)
				{
					num = (float)((double)this.MaxRange * Math2.Sin_D(67.5));
				}
				if (this.coverageArc.PMF1 || this.coverageArc.PMA2)
				{
					num = this.MaxRange;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100695", "");
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

		// Token: 0x06005BAA RID: 23466 RVA: 0x002960F0 File Offset: 0x002942F0
		public float GetStarboardSensorCoverage()
		{
			float result = 0f;
			try
			{
				float num = 0f;
				if (this.coverageArc.SB2 || this.coverageArc.SS1)
				{
					num = (float)((double)this.MaxRange * Math2.Sin_D(22.5));
				}
				if (this.coverageArc.SB1 || this.coverageArc.SS2)
				{
					num = (float)((double)this.MaxRange * Math2.Sin_D(45.0));
				}
				if (this.coverageArc.SMF2 || this.coverageArc.SMA1)
				{
					num = (float)((double)this.MaxRange * Math2.Sin_D(67.5));
				}
				if (this.coverageArc.SMF1 || this.coverageArc.SMA2)
				{
					num = this.MaxRange;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100696", "");
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

		// Token: 0x06005BAB RID: 23467 RVA: 0x00296234 File Offset: 0x00294434
		public bool IsJammerTo(Sensor targetSensor)
		{
			bool flag;
			bool result;
			if (!this.IsOperating())
			{
				flag = false;
			}
			else
			{
				if (this.IsFrequencyAligned(targetSensor))
				{
					Sensor.SensorType sensorType = targetSensor.sensorType;
					if (sensorType <= Sensor.SensorType.HullSonar_ActiveOnly)
					{
						if (sensorType - Sensor.SensorType.Radar <= 1)
						{
							result = (this.IsECMOrIRCM() || this.IsJammer());
							return result;
						}
						if (sensorType == Sensor.SensorType.Infrared)
						{
							result = (this.sensorRole == Sensor._SensorRole.IRCM);
							return result;
						}
						if (sensorType - Sensor.SensorType.HullSonar_ActivePassive <= 1)
						{
							result = (this.sensorRole == Sensor._SensorRole.AcousticJammer);
							return result;
						}
					}
					else if (sensorType == Sensor.SensorType.TowedArray_ActiveOnly || sensorType == Sensor.SensorType.VDS_ActiveOnly || sensorType - Sensor.SensorType.DippingSonar_ActivePassive <= 1)
					{
						result = (this.sensorRole == Sensor._SensorRole.AcousticJammer);
						return result;
					}
					result = false;
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x000290C7 File Offset: 0x000272C7
		public bool HasJammingCondition(CommDevice commDevice_0)
		{
			return this.IsOperating() && this.IsFrequencyAligned(commDevice_0) && commDevice_0.commLinkType != CommDevice.CommLinkType.Land_Line;
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x0029631C File Offset: 0x0029451C
		public bool IsJammerFor(Sensor TargetSensor)
		{
			bool flag;
			bool result;
			if (Information.IsNothing(base.GetParentPlatform()))
			{
				flag = false;
			}
			else if (this.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
			{
				flag = false;
			}
			else
			{
				if (this.IsFrequencyAligned(TargetSensor))
				{
					Sensor.SensorType sensorType = TargetSensor.sensorType;
					if (sensorType <= Sensor.SensorType.HullSonar_ActiveOnly)
					{
						if (sensorType - Sensor.SensorType.Radar <= 1)
						{
							result = (this.IsECMOrIRCM() || this.IsJammer());
							return result;
						}
						if (sensorType == Sensor.SensorType.Infrared)
						{
							result = (this.sensorRole == Sensor._SensorRole.IRCM);
							return result;
						}
						if (sensorType - Sensor.SensorType.HullSonar_ActivePassive <= 1)
						{
							result = (this.sensorRole == Sensor._SensorRole.AcousticJammer);
							return result;
						}
					}
					else if (sensorType == Sensor.SensorType.TowedArray_ActiveOnly || sensorType == Sensor.SensorType.VDS_ActiveOnly || sensorType - Sensor.SensorType.DippingSonar_ActivePassive <= 1)
					{
						result = (this.sensorRole == Sensor._SensorRole.AcousticJammer);
						return result;
					}
					result = false;
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x00296418 File Offset: 0x00294618
		public long GetUpperFreqSearchAndTrack()
		{
			checked
			{
				long result;
				if (this.UpperFreq > 0L)
				{
					result = this.UpperFreq;
				}
				else if (this.SearchAndTrackFrequencies.Length == 0)
				{
					result = 0L;
				}
				else
				{
					long num = 0L;
					Sensor.RadioElectronicFrequency[] searchAndTrackFrequencies = this.SearchAndTrackFrequencies;
					for (int i = 0; i < searchAndTrackFrequencies.Length; i++)
					{
						Sensor.RadioElectronicFrequency radioElectronicFrequency = searchAndTrackFrequencies[i];
						if (radioElectronicFrequency.GetFrequencyBandLow() > num)
						{
							num = radioElectronicFrequency.GetFrequencyBandLow();
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x002964B0 File Offset: 0x002946B0
		public long GetLowerFreqSearchAndTrack()
		{
			checked
			{
				long result;
				if (this.LowerFreq > 0L)
				{
					result = this.LowerFreq;
				}
				else if (this.SearchAndTrackFrequencies.Length == 0)
				{
					result = 0L;
				}
				else
				{
					long num = 9223372036854775807L;
					Sensor.RadioElectronicFrequency[] searchAndTrackFrequencies = this.SearchAndTrackFrequencies;
					for (int i = 0; i < searchAndTrackFrequencies.Length; i++)
					{
						Sensor.RadioElectronicFrequency radioElectronicFrequency = searchAndTrackFrequencies[i];
						if (radioElectronicFrequency.GetFrequencyBandHi() < num)
						{
							num = radioElectronicFrequency.GetFrequencyBandHi();
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00296548 File Offset: 0x00294748
		public long GetUpperFreqIlluminate()
		{
			long result = 0L;
			checked
			{
				try
				{
					if (this.UpperFreqIlluminate > 0L)
					{
						result = this.UpperFreqIlluminate;
					}
					else if (this.SensorFrequencyIlluminateArray.Length == 0)
					{
						result = 0L;
					}
					else
					{
						long num = 0L;
						Sensor.RadioElectronicFrequency[] sensorFrequencyIlluminateArray = this.SensorFrequencyIlluminateArray;
						for (int i = 0; i < sensorFrequencyIlluminateArray.Length; i++)
						{
							Sensor.RadioElectronicFrequency radioElectronicFrequency = sensorFrequencyIlluminateArray[i];
							if (radioElectronicFrequency.GetFrequencyBandLow() > num)
							{
								num = radioElectronicFrequency.GetFrequencyBandLow();
							}
						}
						result = num;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100698", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0L;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x0029663C File Offset: 0x0029483C
		public long GetLowerFreqIlluminate()
		{
			long result = 0L;
			checked
			{
				try
				{
					if (this.LowerFreqIlluminate > 0L)
					{
						result = this.LowerFreqIlluminate;
					}
					else if (this.SensorFrequencyIlluminateArray.Length == 0)
					{
						result = 0L;
					}
					else
					{
						long num = 9223372036854775807L;
						Sensor.RadioElectronicFrequency[] sensorFrequencyIlluminateArray = this.SensorFrequencyIlluminateArray;
						for (int i = 0; i < sensorFrequencyIlluminateArray.Length; i++)
						{
							Sensor.RadioElectronicFrequency radioElectronicFrequency = sensorFrequencyIlluminateArray[i];
							if (radioElectronicFrequency.GetFrequencyBandHi() < num)
							{
								num = radioElectronicFrequency.GetFrequencyBandHi();
							}
						}
						result = num;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100699", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0L;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x00296730 File Offset: 0x00294930
		public void CreateSemiActiveGuidedWeaponList(ref Scenario scenario_0)
		{
			try
			{
				if (this.SemiActiveWeaponsGuided.Count > 0)
				{
					foreach (string current in this.SemiActiveWeaponsGuided)
					{
						Weapon weapon = (Weapon)scenario_0.GetActiveUnits()[current];
						if (!Information.IsNothing(weapon))
						{
							this.SemiActiveGuidedWeaponList.Add(weapon);
							weapon.SetDirector(this);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100700", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x00296808 File Offset: 0x00294A08
		public List<Contact> GetTargetsTrackedForFireControl()
		{
			return this.TargetsTrackedForFireControl;
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x00296820 File Offset: 0x00294A20
		public bool IsPreciselyLocatedEnable()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (this.IsSonar())
					{
						flag = this.IsEmmitting();
					}
					else
					{
						Sensor.SensorType sensorType = this.sensorType;
						if (sensorType != Sensor.SensorType.Radar)
						{
							flag = (sensorType != Sensor.SensorType.ESM && sensorType != Sensor.SensorType.PingIntercept && (this.RangeResolution == 0f || this.AngleResolution == 0f));
						}
						else if (this.IsOTH())
						{
							flag = false;
						}
						else if (this.IsIlluminator())
						{
							flag = true;
						}
						else if (this.sensorCapability.ABM_SpaceSearch && (this.sensorRole == Sensor._SensorRole.Radar_BallisticMissileBattleManagement | this.sensorRole == Sensor._SensorRole.Radar_BallisticMissileEngagement | this.sensorRole == Sensor._SensorRole.Radar_BallisticMissileTracker))
						{
							flag = true;
						}
						else
						{
							Sensor.RadioElectronicFrequency[] searchAndTrackFrequencies = this.SearchAndTrackFrequencies;
							for (int i = 0; i < searchAndTrackFrequencies.Length; i++)
							{
								Sensor.FrequencyBand frequencyBand = searchAndTrackFrequencies[i].frequencyBand;
								if (unchecked(frequencyBand - Sensor.FrequencyBand.CBand) <= 10L)
								{
									flag = true;
									result = true;
									return result;
								}
							}
							flag = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100701", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x000290ED File Offset: 0x000272ED
		public bool IsEmmitting()
		{
			return this.IsActiveCapable() && this.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && this.bActive;
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00029108 File Offset: 0x00027308
        //欺骗干扰
		public void SetIsSpoofed(bool? value)
		{
			this.bSpoofed = value;
		}

        // Token: 0x06005BB7 RID: 23479 RVA: 0x002969C0 File Offset: 0x00294BC0
        //欺骗干扰
        public bool? IsSpoofed()
		{
			return this.bSpoofed;
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x002969D8 File Offset: 0x00294BD8
		public bool IsActiveModeOnly()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool flag = false;
			bool result;
			if (sensorType <= Sensor.SensorType.LaserRangefinder)
			{
				if (sensorType <= Sensor.SensorType.ECM)
				{
					if (sensorType == Sensor.SensorType.Radar || sensorType == Sensor.SensorType.ECM)
					{
						result = true;
						return result;
					}
				}
				else if (sensorType == Sensor.SensorType.LaserDesignator || sensorType == Sensor.SensorType.LaserRangefinder)
				{
					result = true;
					return result;
				}
			}
			else if (sensorType <= Sensor.SensorType.TowedArray_ActiveOnly)
			{
				if (sensorType == Sensor.SensorType.HullSonar_ActiveOnly || sensorType == Sensor.SensorType.TowedArray_ActiveOnly)
				{
					result = true;
					return result;
				}
			}
			else
			{
				if (sensorType == Sensor.SensorType.VDS_ActiveOnly)
				{
					result = true;
					return result;
				}
				if (sensorType == Sensor.SensorType.DippingSonar_ActiveOnly)
				{
					result = true;
					return result;
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00296A90 File Offset: 0x00294C90
		public int GetScanInterval()
		{
			if (this.ScanInterval < 1)
			{
				this.ScanInterval = 1;
			}
			return this.ScanInterval;
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00029111 File Offset: 0x00027311
		public void SetScanInterval(int value)
		{
			this.ScanInterval = Math.Max(value, 1);
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00029120 File Offset: 0x00027320
		public bool NonSearchAndTrackSensorOtherThanMCMAndMAD()
		{
			return !this.IsMineCounterMeasure() && this.sensorType != Sensor.SensorType.MAD && this.SearchAndTrackFrequencies.Count<Sensor.RadioElectronicFrequency>() == 0;
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00029148 File Offset: 0x00027348
		public bool IsContinousTrackingCapable()
		{
			return this.sensorCode.ContinousTrackingCapability_PhasedArrayRadar || this.sensorCode.ContinousTrackingCapability_TargetTrackingRadar || this.sensorCode.ContinousTrackingCapability_Visual;
		}

        // Token: 0x06005BBD RID: 23485 RVA: 0x00296ABC File Offset: 0x00294CBC
        //FCR FireControlRadar 火控雷达
        public bool IsFireControlRadar()
		{
			bool flag;
			bool result;
			if (this.sensorType != Sensor.SensorType.Radar)
			{
				flag = false;
			}
			else
			{
				Sensor._SensorRole sensorRole = this.sensorRole;
				if (sensorRole <= Sensor._SensorRole.Radar_FCR_SurfaceToAirAndSurfaceToSurface_ShortRange)
				{
					long num = sensorRole - Sensor._SensorRole.Radar_FCR_AirToAir_LongRange;
					if (num <= 22L)
					{
						switch ((uint)num)
						{
						case 0u:
						case 1u:
						case 2u:
							result = true;
							return result;
						case 3u:
						case 4u:
						case 5u:
						case 6u:
						case 7u:
						case 8u:
						case 9u:
						case 16u:
						case 17u:
						case 18u:
						case 19u:
							goto IL_12E;
						case 10u:
						case 11u:
						case 12u:
							result = true;
							return result;
						case 13u:
						case 14u:
						case 15u:
							result = true;
							return result;
						case 20u:
						case 21u:
						case 22u:
							result = true;
							return result;
						}
					}
					if (sensorRole - Sensor._SensorRole.Radar_FCR_SurfaceToAirAndSurfaceToSurface_LongRange <= 2L)
					{
						result = true;
						return result;
					}
				}
				else if (sensorRole - Sensor._SensorRole.Radar_FCR_SurfaceToSurface > 1L && sensorRole != Sensor._SensorRole.Radar_FCR_SurfaceToSurface_withTorpedo && sensorRole == Sensor._SensorRole.Radar_FCR_WeaponDirector)
				{
					result = true;
					return result;
				}
				IL_12E:
				flag = false;
			}
			result = flag;
			return result;
		}

        // Token: 0x06005BBE RID: 23486 RVA: 0x00296C00 File Offset: 0x00294E00
        //WeaponDirector
        //public bool method_54()
        public bool IsWeaponDirector()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool flag;
			bool result;
			if (sensorType == Sensor.SensorType.Radar)
			{
				if (this.NonSearchAndTrackSensorOtherThanMCMAndMAD())
				{
					flag = false;
				}
				else
				{
					Sensor._SensorRole sensorRole = this.sensorRole;
					if (sensorRole - Sensor._SensorRole.Radar_TargetIndicator_2D_SurfaceToAir > 3L)
					{
						long num = sensorRole - Sensor._SensorRole.Radar_FCR_AirToAirAndAirToSurface_LongRange;
						if (num <= 22L)
						{
							switch ((uint)num)
							{
							case 0u:
							case 1u:
							case 2u:
							case 3u:
							case 4u:
							case 5u:
							case 10u:
							case 11u:
							case 12u:
							case 20u:
							case 21u:
							case 22u:
								goto IL_E9;
							case 6u:
							case 7u:
							case 8u:
							case 9u:
							case 13u:
							case 14u:
							case 15u:
							case 16u:
							case 17u:
							case 18u:
							case 19u:
								goto IL_E2;
							}
						}
						if (sensorRole == Sensor._SensorRole.Radar_FCR_WeaponDirector)
						{
							goto IL_E9;
						}
						IL_E2:
						result = false;
						return result;
					}
					IL_E9:
					flag = true;
				}
			}
			else
			{
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x00296D04 File Offset: 0x00294F04
		public bool IsAirSearchRadar()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool flag;
			bool result;
			if (sensorType == Sensor.SensorType.Radar)
			{
				if (this.NonSearchAndTrackSensorOtherThanMCMAndMAD())
				{
					flag = false;
				}
				else
				{
					Sensor._SensorRole sensorRole = this.sensorRole;
					long num = sensorRole - Sensor._SensorRole.Radar_AirSearch_2D_LongRange;
					if (num <= 18L)
					{
						switch ((uint)num)
						{
						case 0u:
						case 1u:
						case 2u:
						case 3u:
						case 4u:
						case 5u:
						case 10u:
						case 11u:
						case 12u:
						case 13u:
						case 14u:
						case 15u:
						case 16u:
						case 17u:
						case 18u:
							result = true;
							return result;
						}
					}
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x00296DC8 File Offset: 0x00294FC8
		public bool HasOffensiveECMSensorRole()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool result;
			bool flag;
			if (sensorType == Sensor.SensorType.ECM)
			{
				Sensor._SensorRole sensorRole = this.sensorRole;
				if (sensorRole != Sensor._SensorRole.OffensiveECM && sensorRole != Sensor._SensorRole.OffensiveAndDefensiveECM)
				{
					result = false;
					return result;
				}
				flag = true;
			}
			else
			{
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x00296E20 File Offset: 0x00295020
		public bool IsSearchAndTrackSensor()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool result;
			if (sensorType <= Sensor.SensorType.TVM)
			{
				if (sensorType == Sensor.SensorType.None || sensorType == Sensor.SensorType.SemiActive || sensorType == Sensor.SensorType.TVM)
				{
					result = false;
					return result;
				}
			}
			else
			{
				if (sensorType == Sensor.SensorType.ECM || sensorType - Sensor.SensorType.LaserDesignator <= 2)
				{
					result = false;
					return result;
				}
				if (sensorType == Sensor.SensorType.SensorGroup)
				{
					result = false;
					return result;
				}
			}
			if (this.NonSearchAndTrackSensorOtherThanMCMAndMAD())
			{
				result = false;
			}
			else
			{
				Sensor._SensorRole sensorRole = this.sensorRole;
				if (sensorRole <= Sensor._SensorRole.Radar_FCR_WeaponDirector)
				{
					long num = sensorRole - Sensor._SensorRole.Radar_Navigation;
					if (num <= 4L)
					{
						switch ((uint)num)
						{
						case 0u:
						case 1u:
						case 2u:
						case 3u:
						case 4u:
							result = false;
							return result;
						}
					}
					if (sensorRole != Sensor._SensorRole.Radar_FCR_WeaponDirector)
					{
					}
				}
				else
				{
					long num2 = sensorRole - Sensor._SensorRole.Radar_Illuminator_LongRange;
					if (num2 <= 2L)
					{
						switch ((uint)num2)
						{
						case 0u:
						case 1u:
						case 2u:
							result = false;
							return result;
						}
					}
					if (sensorRole != Sensor._SensorRole.Radar_RangeOnly && sensorRole != Sensor._SensorRole.HullSonar_PassiveOnly_Ranging_FlankArray_SearchAndTrack)
					{
						result = true;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x00296F6C File Offset: 0x0029516C
		public bool IsHeightFinderRadar()
		{
			Sensor._SensorRole sensorRole = this.sensorRole;
			long num = sensorRole - Sensor._SensorRole.Radar_HeightFinder_LongRange;
			bool result;
			if (num <= 2L)
			{
				switch ((uint)num)
				{
				case 0u:
				case 1u:
				case 2u:
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x00296FB8 File Offset: 0x002951B8
		public bool IsIlluminator()
		{
			return this.MaxIntercept != 0 && (this.SensorFrequencyIlluminateArray.Count<Sensor.RadioElectronicFrequency>() != 0 || this.UpperFreqIlluminate != 0L || this.LowerFreqIlluminate != 0L);
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x00029172 File Offset: 0x00027372
		public bool IsActiveCapable()
		{
			return this.IsMineCounterMeasure() || (this.sensorRole != Sensor._SensorRole.DefensiveECM && this.sensorRole != Sensor._SensorRole.IRCM && Misc.HasActiveMode(this.sensorType));
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x00297008 File Offset: 0x00295208
		public bool IsSuitableMineCounterMeasureForWeapon(UnguidedWeapon unguidedWeapon_0)
		{
			bool flag;
			bool result;
			if (!this.IsMineCounterMeasure())
			{
				flag = false;
			}
			else
			{
				Sensor.SensorType sensorType = this.sensorType;
				if (sensorType <= Sensor.SensorType.MineSweep_TwoShipMagneticInfluence)
				{
					switch (sensorType)
					{
					case Sensor.SensorType.MineSweep_MechanicalCableCutter:
						result = (unguidedWeapon_0.GetWeaponType() == Weapon._WeaponType.MooredMine);
						return result;
					case Sensor.SensorType.MineSweep_MagneticInfluence:
						result = true;
						return result;
					case Sensor.SensorType.MineSweep_AcousticInfluence:
						result = true;
						return result;
					case Sensor.SensorType.MineSweep_MagneticAndAcousticMultiInfluence:
						result = true;
						return result;
					default:
						if (sensorType == Sensor.SensorType.MineSweep_TwoShipMagneticInfluence)
						{
							result = true;
							return result;
						}
						break;
					}
				}
				else
				{
					if (sensorType == Sensor.SensorType.MineNeutralization_MooredMineCableCutter)
					{
						result = (unguidedWeapon_0.GetWeaponType() == Weapon._WeaponType.MooredMine);
						return result;
					}
					if (sensorType == Sensor.SensorType.MineNeutralization_ExplosiveChargeMineDisposal)
					{
						result = true;
						return result;
					}
					if (sensorType == Sensor.SensorType.MineNeutralization_DiverdeployedExplosiveCharge)
					{
						result = true;
						return result;
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x002970D8 File Offset: 0x002952D8
		public List<GeoPoint> GetMineSweepingAreaVertices()
		{
			List<GeoPoint> result = null;
			try
			{
				if (!this.IsMineCounterMeasure())
				{
					result = null;
				}
				else if (!this.IsEmmitting())
				{
					result = null;
				}
				else
				{
					double num = (double)this.MineSweepWidth / 1852.0;
					float num2 = Math2.Normalize(base.GetParentPlatform().GetCurrentHeading() + 180f);
					GeoPoint geoPoint = new GeoPoint();
					GeoPoint geoPoint2 = new GeoPoint();
					GeoPoint geoPoint3 = new GeoPoint();
					List<GeoPoint> list = new List<GeoPoint>();
					if (!base.GetParentPlatform().IsShip && !base.GetParentPlatform().IsSubmarine)
					{
						double longitude = base.GetParentPlatform().GetLongitude(null);
						double latitude = base.GetParentPlatform().GetLatitude(null);
						GeoPoint geoPoint4;
						double num3 = (geoPoint4 = geoPoint2).GetLongitude();
						GeoPoint geoPoint5;
						double num4 = (geoPoint5 = geoPoint2).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num3, ref num4, (double)((float)(num * 3.0)), (double)num2);
						geoPoint5.SetLatitude(num4);
						geoPoint4.SetLongitude(num3);
						double longitude2 = geoPoint2.GetLongitude();
						double latitude2 = geoPoint2.GetLatitude();
						num4 = (geoPoint5 = geoPoint3).GetLongitude();
						num3 = (geoPoint4 = geoPoint3).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref num4, ref num3, (double)((float)(num / 2.0)), (double)Math2.Normalize(num2 - 90f));
						geoPoint4.SetLatitude(num3);
						geoPoint5.SetLongitude(num4);
						double longitude3 = geoPoint2.GetLongitude();
						double latitude3 = geoPoint2.GetLatitude();
						num3 = (geoPoint4 = geoPoint).GetLongitude();
						num4 = (geoPoint5 = geoPoint).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude3, ref num3, ref num4, (double)((float)(num / 2.0)), (double)Math2.Normalize(num2 + 90f));
						geoPoint5.SetLatitude(num4);
						geoPoint4.SetLongitude(num3);
						list.Add(new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						list.Add(geoPoint3);
						list.Add(geoPoint2);
						list.Add(geoPoint);
					}
					else
					{
						Sensor.SensorType sensorType = this.sensorType;
						if (sensorType == Sensor.SensorType.MineSweep_MechanicalCableCutter)
						{
							double longitude4 = base.GetParentPlatform().GetLongitude(null);
							double latitude4 = base.GetParentPlatform().GetLatitude(null);
							GeoPoint geoPoint4;
							double num5 = (geoPoint4 = geoPoint2).GetLongitude();
							GeoPoint geoPoint5;
							double num6 = (geoPoint5 = geoPoint2).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num5, ref num6, (double)((float)(num * 3.0)), (double)num2);
							geoPoint5.SetLatitude(num6);
							geoPoint4.SetLongitude(num5);
							double num7 = geoPoint2.GetLongitude();
							double num8 = geoPoint2.GetLatitude();
							num6 = (geoPoint5 = geoPoint3).GetLongitude();
							num5 = (geoPoint4 = geoPoint3).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(num7, num8, ref num6, ref num5, (double)((float)num), (double)Math2.Normalize(num2 + 90f));
							geoPoint4.SetLatitude(num5);
							geoPoint5.SetLongitude(num6);
						}
						else
						{
							double longitude5 = base.GetParentPlatform().GetLongitude(null);
							double latitude5 = base.GetParentPlatform().GetLatitude(null);
							GeoPoint geoPoint4;
							double num7 = (geoPoint4 = geoPoint2).GetLongitude();
							GeoPoint geoPoint5;
							double num8 = (geoPoint5 = geoPoint2).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num7, ref num8, (double)((float)(num * 3.0)), (double)num2);
							geoPoint5.SetLatitude(num8);
							geoPoint4.SetLongitude(num7);
							double longitude6 = geoPoint2.GetLongitude();
							double latitude6 = geoPoint2.GetLatitude();
							num8 = (geoPoint5 = geoPoint3).GetLongitude();
							num7 = (geoPoint4 = geoPoint3).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude6, latitude6, ref num8, ref num7, (double)((float)num), (double)Math2.Normalize(num2 + 90f));
							geoPoint4.SetLatitude(num7);
							geoPoint5.SetLongitude(num8);
						}
						list.Add(new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						list.Add(geoPoint2);
						list.Add(geoPoint3);
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100702", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00297560 File Offset: 0x00295760
		public bool IsCapableOfDetect(GlobalVariables.ActiveUnitType targetType)
		{
			bool flag;
			bool result;
			if (this.sensorType == Sensor.SensorType.ESM)
			{
				flag = true;
			}
			else if (this.sensorType == Sensor.SensorType.PingIntercept)
			{
				flag = true;
			}
			else
			{
				switch (targetType)
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
				case GlobalVariables.ActiveUnitType.Weapon:
					result = this.sensorCapability.AirSearch;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					result = this.sensorCapability.SurfaceSearch;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					result = (this.sensorRole == Sensor._SensorRole.TowedArraySonarSystem_Passive_TorpedoWarning || this.sensorCapability.SubmarineSearch);
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					result = (this.sensorCapability.LandSearch_Fixed || this.sensorCapability.LandSearch_Mobile);
					return result;
				case GlobalVariables.ActiveUnitType.Satellite:
					result = this.sensorCapability.ABM_SpaceSearch;
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00297640 File Offset: 0x00295840
		public bool IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType activeUnitType_0, Weapon weapon_0)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.sensorType == Sensor.SensorType.ESM)
				{
					if (weapon_0.weaponTarget.IsRadar)
					{
						if (weapon_0.RangeAAWMax > 0f)
						{
							flag = true;
							result = true;
							return result;
						}
						if (weapon_0.RangeASUWMax > 0f)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					if (weapon_0.IsDecoy())
					{
						flag = true;
						result = true;
						return result;
					}
				}
				if (this.sensorType == Sensor.SensorType.PingIntercept)
				{
					flag = true;
				}
				else
				{
					switch (activeUnitType_0)
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
					case GlobalVariables.ActiveUnitType.Weapon:
						if (weapon_0.weaponTarget.IsAircraft || weapon_0.weaponTarget.IsHelicopter || weapon_0.weaponTarget.IsGuidedWeapon)
						{
							flag = (result = this.sensorCapability.AirSearch);
							return result;
						}
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						if (this.IsSonar() || this.IsAcousticIntercept_ActiveSonarWarning())
						{
							flag = true;
							result = true;
							return result;
						}
						if (weapon_0.weaponTarget.IsSurfaceShip)
						{
							flag = (result = this.sensorCapability.SurfaceSearch);
							return result;
						}
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						if (weapon_0.weaponTarget.IsSubsurface)
						{
							flag = (result = this.sensorCapability.SubmarineSearch);
							return result;
						}
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						if (weapon_0.weaponTarget.IsHardLandStructures || weapon_0.weaponTarget.IsSoftLandStructures || weapon_0.weaponTarget.IsHardMobileUnit || weapon_0.weaponTarget.IsSoftMobileUnit)
						{
							flag = (result = (this.sensorCapability.LandSearch_Fixed || this.sensorCapability.LandSearch_Mobile));
							return result;
						}
						break;
					case GlobalVariables.ActiveUnitType.Satellite:
						if (weapon_0.weaponTarget.IsSatellite)
						{
							flag = (result = this.sensorCapability.ABM_SpaceSearch);
							return result;
						}
						break;
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100703", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x0029788C File Offset: 0x00295A8C
		public bool IsTargetDetectableByMe(ActiveUnit TargetUnit_)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(TargetUnit_))
			{
				flag = false;
			}
			else
			{
				try
				{
					if (this.sensorType == Sensor.SensorType.ESM)
					{
						flag = (TargetUnit_.IsSubmarine || TargetUnit_.IsFacility || (TargetUnit_.HasEmmittingSensor() && !TargetUnit_.IsUnderGround() && !TargetUnit_.IsUnderWater()));
					}
					else if (this.sensorRole == Sensor._SensorRole.MAWS_MissileApproachWarningSystem && TargetUnit_.IsWeapon)
					{
						flag = true;
					}
					else
					{
						if (this.sensorType == Sensor.SensorType.PingIntercept)
						{
							if (TargetUnit_.IsSubmarine || TargetUnit_.IsShip)
							{
								flag = true;
								result = true;
								return result;
							}
							if (TargetUnit_.IsWeapon)
							{
								if (TargetUnit_.IsTorpedo())
								{
									flag = true;
									result = true;
									return result;
								}
								if (((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.Sonobuoy)
								{
									flag = true;
									result = true;
									return result;
								}
							}
							if (TargetUnit_.IsAircraft && ((Aircraft)TargetUnit_).GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
							{
								flag = true;
								result = true;
								return result;
							}
						}
						if (TargetUnit_.IsAircraft)
						{
							if (((Aircraft)TargetUnit_).IsAirship())
							{
								flag = (this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft) || this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Ship) || this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Facility));
							}
							else
							{
								flag = this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft);
							}
						}
						else if (TargetUnit_.IsShip)
						{
							flag = this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Ship);
						}
						else if (TargetUnit_.IsSubmarine)
						{
							flag = (((((Submarine)TargetUnit_).IsShallowerThanPeriscopeDepth() || (this.sensorCapability.PeriscopeSearch && ((Submarine)TargetUnit_).IsAtPeriscopeDepth())) && this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Ship)) || this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Submarine));
						}
						else if (TargetUnit_.IsFacility)
						{
							if (!this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Facility))
							{
								flag = false;
							}
							else if (((Facility)TargetUnit_).IsMobile())
							{
								flag = this.sensorCapability.LandSearch_Mobile;
							}
							else
							{
								flag = this.sensorCapability.LandSearch_Fixed;
							}
						}
						else
						{
							if (TargetUnit_.IsWeapon)
							{
								Weapon._WeaponType weaponType = ((Weapon)TargetUnit_).GetWeaponType();
								if (weaponType <= Weapon._WeaponType.Torpedo)
								{
									if (weaponType != Weapon._WeaponType.GuidedWeapon)
									{
										if (weaponType != Weapon._WeaponType.Decoy_Vehicle)
										{
											if (weaponType != Weapon._WeaponType.Torpedo)
											{
												goto IL_37C;
											}
										}
										else
										{
											if (((Weapon)TargetUnit_).IsAirDecoy())
											{
												flag = (result = this.sensorCapability.AirSearch);
												return result;
											}
											if (((Weapon)TargetUnit_).IsSurfaceDecoy())
											{
												flag = (result = this.sensorCapability.SurfaceSearch);
												return result;
											}
											if (((Weapon)TargetUnit_).IsSubsurfaceDecoy())
											{
												flag = (result = this.sensorCapability.SubmarineSearch);
												return result;
											}
											goto IL_37C;
										}
									}
									else
									{
										if (((Weapon)TargetUnit_).weaponCode.BallisticMissile)
										{
											flag = (result = (this.sensorCapability.ABM_SpaceSearch || this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft)));
											return result;
										}
										flag = (result = this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft));
										return result;
									}
								}
								else if (weaponType - Weapon._WeaponType.BottomMine > 4)
								{
									if (weaponType == Weapon._WeaponType.RV || weaponType == Weapon._WeaponType.HGV)
									{
										flag = (result = (this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Satellite) || this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Weapon)));
										return result;
									}
									goto IL_37C;
								}
								flag = (result = this.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Submarine));
								return result;
							}
							IL_37C:
							flag = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100704", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00297C78 File Offset: 0x00295E78
		public bool IsOperating()
		{
			bool result = false;
			try
			{
				result = (!Information.IsNothing(base.GetParentPlatform()) && this.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && Operators.CompareString(this.CheckPlatformStatus(), "None", false) == 0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100705", "");
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

		// Token: 0x06005BCB RID: 23499 RVA: 0x00297D1C File Offset: 0x00295F1C
		public override string CheckPlatformStatus()
		{
			string text;
			string result;
			if (Information.IsNothing(base.GetParentPlatform()))
			{
				text = "None";
			}
			else
			{
				if (base.GetParentPlatform().IsSubmarine)
				{
					if (this.sensorType == Sensor.SensorType.ESM)
					{
						if (!((Submarine)base.GetParentPlatform()).IsAtPeriscopeDepth() && !((Submarine)base.GetParentPlatform()).IsShallowerThanPeriscopeDepth())
						{
							text = "潜艇必须处于潜望镜深度以上";
							result = text;
							return result;
						}
						if (base.GetParentPlatform().GetCurrentSpeed() > 10f)
						{
							text = "电子支援设施只能在10节（含）以下使用";
							result = text;
							return result;
						}
					}
					if (this.sensorType == Sensor.SensorType.Visual && ((Submarine)base.GetParentPlatform()).Type != Submarine._SubmarineType.ROV && ((Submarine)base.GetParentPlatform()).Type != Submarine._SubmarineType.UUV)
					{
						if (!((Submarine)base.GetParentPlatform()).IsAtPeriscopeDepth() && !((Submarine)base.GetParentPlatform()).IsShallowerThanPeriscopeDepth())
						{
							text = "潜艇必须处于潜望镜深度以上";
							result = text;
							return result;
						}
						if (base.GetParentPlatform().GetCurrentSpeed() > 10f)
						{
							text = "潜望镜只能在10节（含）以下使用";
							result = text;
							return result;
						}
					}
				}
				if (this.IsTowedArraySonar())
				{
					int terrainElevation = base.GetParentPlatform().GetTerrainElevation(false, false, false);
					if (this.sensorRole == Sensor._SensorRole.TowedArraySonarSystem_Passive_TorpedoWarning)
					{
						if (terrainElevation > -20)
						{
							text = "鱼雷告警拖曳阵不能在很浅深度下(<20m)工作";
							result = text;
							return result;
						}
					}
					else if (terrainElevation > -150)
					{
						text = "拖曳阵不能在小潜深(<150米)下工作";
						result = text;
						return result;
					}
				}
				if (this.IsDippingSonar() && base.GetParentPlatform().IsAircraft && (((Aircraft)base.GetParentPlatform()).GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar || base.GetParentPlatform().GetCurrentAltitude_ASL(false) > 50f || base.GetParentPlatform().GetCurrentSpeed() != 0f))
				{
					text = "平台没有悬停部署传感器";
				}
				else
				{
					this.IsECMOrIRCM();
					if (this.IsActiveModeOnly() && !this.IsEmmitting())
					{
						text = "传感器只有主动模式但没有开机";
					}
					else
					{
						text = "None";
					}
				}
			}
			result = text;
			return result;
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x000291AF File Offset: 0x000273AF
		public bool IsMineCounterMeasure()
		{
			return this.sensorType > (Sensor.SensorType)6000 && this.sensorType < (Sensor.SensorType)7000;
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x000291CE File Offset: 0x000273CE
		public bool IsMineNeutralization()
		{
			return this.sensorType == Sensor.SensorType.MineNeutralization_ExplosiveChargeMineDisposal || this.sensorType == Sensor.SensorType.MineNeutralization_DiverdeployedExplosiveCharge;
		}

        // Token: 0x06005BCE RID: 23502 RVA: 0x000291ED File Offset: 0x000273ED
        //天波超视距和地波超视距 OTH-B (Backscatter)
        public bool IsOTH()
		{
			return this.sensorCapability.OTH_Backscatter || this.sensorCapability.OTH_SurfaceWave;
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x0002920A File Offset: 0x0002740A
		public bool IsDippingSonar()
		{
			return this.sensorType == Sensor.SensorType.DippingSonar_ActiveOnly || this.sensorType == Sensor.SensorType.DippingSonar_ActivePassive || this.sensorType == Sensor.SensorType.DippingSonar_PassiveOnly;
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x00297F50 File Offset: 0x00296150
		public bool IsECMOrIRCM()
		{
			Sensor._SensorRole sensorRole = this.sensorRole;
			return sensorRole == Sensor._SensorRole.DefensiveECM || sensorRole == Sensor._SensorRole.OffensiveAndDefensiveECM || sensorRole == Sensor._SensorRole.IRCM;
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x00029236 File Offset: 0x00027436
        //雷障搜索
		public bool IsMineObstacleSearchCapable()
		{
			return this.sensorCapability.MineObstacleSearch;
		}

        // Token: 0x06005BD2 RID: 23506 RVA: 0x00297F8C File Offset: 0x0029618C
        //409 Communications Jammer
        public bool IsCommunicationsJammer()
		{
			Sensor._SensorRole sensorRole = this.sensorRole;
			return sensorRole == Sensor._SensorRole.CommunicationsJammer;
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00297FAC File Offset: 0x002961AC
		public bool IsJammer()
		{
			Sensor._SensorRole sensorRole = this.sensorRole;
			return sensorRole == Sensor._SensorRole.OffensiveECM || sensorRole == Sensor._SensorRole.OffensiveAndDefensiveECM || sensorRole == Sensor._SensorRole.CommunicationsJammer;
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x00297FFC File Offset: 0x002961FC
		public bool IsTowedArraySonar()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool result;
			switch (sensorType)
			{
			case Sensor.SensorType.TowedArray_PassiveOnly:
			case Sensor.SensorType.TowedArray_ActivePassive:
			case Sensor.SensorType.TowedArray_ActiveOnly:
				break;
			default:
				if (sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly)
				{
					result = false;
					return result;
				}
				break;
			}
			result = true;
			return result;
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x0029803C File Offset: 0x0029623C
		public bool IsSonar()
		{
			Sensor.SensorType sensorType = this.sensorType;
			bool result;
			if (sensorType <= Sensor.SensorType.TowedArray_ActiveOnly)
			{
				switch (sensorType)
				{
				case Sensor.SensorType.HullSonar_PassiveOnly:
				case Sensor.SensorType.HullSonar_ActivePassive:
				case Sensor.SensorType.HullSonar_ActiveOnly:
					break;
				default:
					switch (sensorType)
					{
					case Sensor.SensorType.TowedArray_PassiveOnly:
					case Sensor.SensorType.TowedArray_ActivePassive:
					case Sensor.SensorType.TowedArray_ActiveOnly:
						break;
					default:
						result = false;
						return result;
					}
					break;
				}
			}
			else
			{
				switch (sensorType)
				{
				case Sensor.SensorType.VDS_PassiveOnly:
				case Sensor.SensorType.VDS_ActivePassive:
				case Sensor.SensorType.VDS_ActiveOnly:
					break;
				default:
					switch (sensorType)
					{
					case Sensor.SensorType.DippingSonar_PassiveOnly:
					case Sensor.SensorType.DippingSonar_ActivePassive:
					case Sensor.SensorType.DippingSonar_ActiveOnly:
						break;
					default:
						if (sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly)
						{
							result = false;
							return result;
						}
						break;
					}
					break;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x002980D8 File Offset: 0x002962D8
		public bool IsAcousticIntercept_ActiveSonarWarning()
		{
			Sensor.SensorType sensorType = this.sensorType;
			return sensorType == Sensor.SensorType.PingIntercept;
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x002980F4 File Offset: 0x002962F4
		public Sensor(ref SQLiteConnection theConn, int SensorDBID, string theName, Sensor.SensorType theSensorType, Sensor._SensorRole theSensorRole, GlobalVariables.TechGenerationClass theGeneration, float theMaxRange, float theMinRange, byte theArcLeft, byte theArcRight, int thePassiveInput, int theMaxIntercept, float theMaxAltitude, float theMinAltitude, float theMaxAltitude_ASL, float theMinAltitude_ASL, int theScanInterval, float theRangeResolution, float theAngleResolution, float theHeightResolution, bool IsEyeball, short theMasqueradeAs = 0, short theMaxContactsAir = 0, short theMaxContactsSurface = 0, short theMaxContactsSub = 0, float theAvailability = 0f, long theUpperFreq = 0L, long theLowerFreq = 0L, long theUpperFreqIlluminate = 0L, long theLowerFreqIlluminate = 0L, float theECMGain = 0f, float theECMPeakPower = 0f, float theECMBandwidth = 0f, float theECMNumberofTargets = 0f, float theECMPokReduction = 0f, float DFAccuracy = 0f, short theMineSweepWidth = 0, short theMineMaxSpeed = 0, float theVisualDetectZoom = 0f, float theVisualClassZoom = 0f, float theIRDetectZoom = 0f, float theIRClassZoom = 0f, bool IsHypothetical = false)
		{
			this.sensorCapability = default(Sensor.SensorCapability);
			this.sensorCode = default(Sensor.SensorCode);
			this.SearchAndTrackFrequencies = new Sensor.RadioElectronicFrequency[0];
			this.SensorFrequencyIlluminateArray = new Sensor.RadioElectronicFrequency[0];
			this.TargetsTrackedForFireControl = new List<Contact>();
			this.SemiActiveGuidedWeaponList = new List<Weapon>();
			this.SemiActiveWeaponsGuided = new Collection<string>();
			this.coverageArcMax = default(PlatformComponent._CoverageArc);
			this.m_Radar = new ECM.Radar();
			this.Receiver = default(ECM.Receiver);
			try
			{
				this.DBID = SensorDBID;
				this.MaxRange = theMaxRange;
				this.MinRange = theMinRange;
				this.Name = theName;
				this.MaxIntercept = theMaxIntercept;
				this.MaxAltitude = theMaxAltitude;
				this.MinAltitude = theMinAltitude;
				this.MaxAltitude_ASL = theMaxAltitude_ASL;
				this.MinAltitude_ASL = theMinAltitude_ASL;
				this.sensorType = theSensorType;
				this.sensorRole = theSensorRole;
				this.techGenerationClass = theGeneration;
				this.SetScanInterval(theScanInterval);
				this.HeightResolution = theHeightResolution;
				this.MasqueradeAs = theMasqueradeAs;
				this.MaxContactsAir = theMaxContactsAir;
				this.MaxContactsSurface = theMaxContactsSurface;
				this.MaxContactsSub = theMaxContactsSub;
				this.Availability = theAvailability;
				this.UpperFreq = theUpperFreq;
				this.LowerFreq = theLowerFreq;
				this.UpperFreqIlluminate = theUpperFreqIlluminate;
				this.LowerFreqIlluminate = theLowerFreqIlluminate;
				this.MineSweepWidth = theMineSweepWidth;
				this.MineMaxSpeed = theMineMaxSpeed;
				this.VisualDetectZoom = Math.Max(1f, theVisualDetectZoom);
				this.VisualClassZoom = Math.Max(1f, theVisualClassZoom);
				this.IRDetectZoom = Math.Max(1f, theIRDetectZoom);
				this.IRClassZoom = Math.Max(1f, theIRClassZoom);
				if (this.sensorType == Sensor.SensorType.ESM)
				{
					Sensor sensor = this;
					DBFunctions.LoadESMData(ref sensor, theConn);
				}
				if (this.sensorType == Sensor.SensorType.Radar)
				{
					Sensor sensor = this;
					DBFunctions.LoadRadarData(ref sensor, theConn);
				}
				this.ECMGain = theECMGain;
				this.ECMPeakPower = theECMPeakPower;
				this.ECMBandwidth = theECMBandwidth;
				this.ECMNumberofTargets = theECMNumberofTargets;
				this.ECMPokReduction = theECMPokReduction;
				this.AngleResolution = theAngleResolution;
				if (this.AngleResolution == 0f)
				{
					this.AngleResolution = DFAccuracy;
				}
				if (this.AngleResolution == 0f)
				{
					this.AngleResolution = 5f;
				}
				if (this.IsSonar() || this.IsAcousticIntercept_ActiveSonarWarning())
				{
					this.RangeResolution = (float)(0.2 * (double)this.MaxRange);
					switch (this.techGenerationClass)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						this.AngleResolution = 30f;
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						this.AngleResolution = 25f;
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						this.AngleResolution = 20f;
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						this.AngleResolution = 15f;
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						this.AngleResolution = 10f;
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						this.AngleResolution = 5f;
						break;
					default:
						this.AngleResolution = 2f;
						break;
					}
				}
				if (!IsEyeball)
				{
					Sensor sensor = this;
					DBFunctions.LoadSensorCapabilitiesData(ref sensor, SensorDBID, theConn);
					sensor = this;
					DBFunctions.LoadSensorCodesData(ref sensor, SensorDBID, theConn);
					sensor = this;
					DBFunctions.LoadSensorFrequencySearchAndTrackData(ref sensor, SensorDBID, theConn);
					sensor = this;
					DBFunctions.LoadSensorFrequencyIlluminateData(ref sensor, SensorDBID, theConn);
				}
				if (this.NonSearchAndTrackSensorOtherThanMCMAndMAD())
				{
					this.sensorCode.ContinousTrackingCapability_TargetTrackingRadar = true;
				}
				if ((this.IsSonar() || this.IsAcousticIntercept_ActiveSonarWarning()) && !this.IsActiveModeOnly())
				{
					this.sensorCode.ContinousTrackingCapability_PhasedArrayRadar = true;
				}
				this.NextScan = GameGeneral.GetRandom().Next(0, this.GetScanInterval());
				this.OODADetectionCycle = 0;
				this.bIsHypothetical = IsHypothetical;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100706", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x002984E8 File Offset: 0x002966E8
        //欺骗干扰算法实现
		public bool IsSensorSpoofed(ref Sensor sensor_0, ref ActiveUnit activeUnit_1)
		{
			bool result = false;
			try
			{
				float eCMPokReduction = this.ECMPokReduction;
				StringBuilder stringBuilder = new StringBuilder();
				float num = 0f;
				if (this.techGenerationClass == GlobalVariables.TechGenerationClass.NotApplicable)
				{
					num = eCMPokReduction;
				}
				else if (this.sensorRole == Sensor._SensorRole.IRCM)
				{
					num = eCMPokReduction;
				}
				else
				{
					int num2 = this.techGenerationClass - sensor_0.techGenerationClass;
					if (num2 < -3)
					{
						num = eCMPokReduction - 15f;
					}
					else if (num2 == -3)
					{
						num = eCMPokReduction - 10f;
					}
					else if (num2 == -2)
					{
						num = eCMPokReduction - 5f;
					}
					else if (num2 == -1)
					{
						num = eCMPokReduction;
					}
					else if (num2 == 0)
					{
						num = eCMPokReduction;
					}
					else if (num2 == 1)
					{
						num = eCMPokReduction;
					}
					else if (num2 == 2)
					{
						num = eCMPokReduction + 5f;
					}
					else if (num2 == 3)
					{
						num = eCMPokReduction + 10f;
					}
					else if (num2 > 3)
					{
						num = eCMPokReduction + 15f;
					}
				}
				if (sensor_0.sensorType == Sensor.SensorType.Radar && sensor_0.sensorCode.ActiveElectronicallyScannedArray)
				{
					num -= 30f;
				}
				num = Math.Max(num, 5f);
				stringBuilder.Append(string.Concat(new string[]
				{
					"防御性干扰机(",
					Misc.smethod_11(this.Name),
					"; 技术水平: ",
					Misc.GetTechGenerationString(this.techGenerationClass),
					") 平台 ",
					activeUnit_1.Name,
					" 试图干扰传感器: ",
					Misc.smethod_11(sensor_0.Name),
					"(技术水平: ",
					Misc.GetTechGenerationString(sensor_0.techGenerationClass),
					")(平台: ",
					sensor_0.GetParentPlatform().Name,
					"). 最终概率: ",
					Conversions.ToString(Math.Round((double)num, 2)),
					"%. "
				}));
				int num3 = GameGeneral.GetRandom().Next(1, 101);
				bool flag = false;
				if ((float)num3 <= num)
				{
					stringBuilder.Append("结果: " + Conversions.ToString(num3) + " - 成功");
					flag = true;
				}
				else
				{
					stringBuilder.Append("结果: " + Conversions.ToString(num3) + " - 失败");
				}
				base.GetParentPlatform().m_Scenario.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.WeaponEndgame, 10, base.GetGuid(), null, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
				result = flag;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100707", "");
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

		// Token: 0x06005BD9 RID: 23513 RVA: 0x00298808 File Offset: 0x00296A08
		public void TurnOn()
		{
			if (!this.bActive && this.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
			{
				this.bActive = true;
				base.method_24();
				this.NextScan = GameGeneral.GetRandom().Next(0, this.GetScanInterval());
				this.OODADetectionCycle = 0;
			}
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x00029243 File Offset: 0x00027443
		public void TurnOff()
		{
			if (this.bActive)
			{
				this.bActive = false;
				if (this.TargetsTrackedForFireControl.Count > 0)
				{
					this.TargetsTrackedForFireControl.Clear();
				}
				base.method_24();
			}
		}

        // Token: 0x06005BDB RID: 23515 RVA: 0x0029885C File Offset: 0x00296A5C
        //public override void vmethod_9(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
        public override void StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			try
			{
				List<Contact> list = new List<Contact>();
				foreach (Contact current in this.TargetsTrackedForFireControl)
				{
					list.Add(current);
				}
                Contact current2X;

                foreach (Contact current2 in list)
				{
                    current2X = current2;
                    this.StopIlluminateTarget(ref current2X, false);
				}
				if (this.IsActiveCapable() && this.IsEmmitting())
				{
					this.TurnOff();
				}
				base.StopIlluminateAndTurnOff(_DamageSeverityFactor_1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100708", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00298968 File Offset: 0x00296B68
		public override void BeDestroyed(Side side_0, bool bool_12, bool bool_13)
		{
			try
			{
				if (!bool_13)
				{
					base.BeDestroyed(side_0, bool_12, bool_13);
				}
				List<Contact> list = new List<Contact>();
				foreach (Contact current in this.TargetsTrackedForFireControl)
				{
					list.Add(current);
				}
                Contact current2X;

                foreach (Contact current2 in list)
				{
                    current2X = current2;
                    this.StopIlluminateTarget(ref current2X, false);
				}
				this.TurnOff();
				this.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100709", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x0002927B File Offset: 0x0002747B
		public bool IsDirectorFor(ref Weapon weapon_)
		{
			return weapon_.weaponDirectorSet.Contains(this.DBID);
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x00298A68 File Offset: 0x00296C68
		public void AddTargetsTrackedForFireControl(ref Contact target)
		{
			try
			{
				if (!this.TargetsTrackedForFireControl.Contains(target))
				{
					this.TargetsTrackedForFireControl.Add(target);
				}
				if (this.IsActiveCapable())
				{
					if (!this.IsEmmitting())
					{
						this.TurnOn();
					}
					this.SetBlindTime(target);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100711", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

        // Token: 0x06005BDF RID: 23519 RVA: 0x00298B00 File Offset: 0x00296D00
        //private void method_83(Contact contact_0)
        private void SetBlindTime(Contact contact_0)
		{
			try
			{
				List<ActiveUnit> activeUnitList = base.GetParentPlatform().m_Scenario.GetActiveUnitList();
				foreach (ActiveUnit current in activeUnitList)
				{
					if (current.IsWeapon && !Information.IsNothing(current.GetAI().GetPrimaryTarget()) && current.GetAI().GetPrimaryTarget() == contact_0)
					{
						((Weapon)current).SetBlindTime(0f);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100712", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x0002928F File Offset: 0x0002748F
		public bool IsTargetTracked(ref Contact theTarget)
		{
			return this.IsEmmitting() && this.TargetsTrackedForFireControl.Contains(theTarget);
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x00298BE4 File Offset: 0x00296DE4
		public bool IsTrackingTargetUnit(ref ActiveUnit TargetUnit_)
		{
			bool flag = false;
			bool result;
			try
			{
				if (!this.IsEmmitting())
				{
					flag = false;
				}
				else if (this.TargetsTrackedForFireControl.Count < 1)
				{
					flag = false;
				}
				else
				{
					List<Contact> list = new List<Contact>();
					list.AddRange(this.TargetsTrackedForFireControl.ToList<Contact>());
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Contact contact = list[i];
						if (!Information.IsNothing(contact) && contact.ActualUnit == TargetUnit_)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200034", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x00298CD0 File Offset: 0x00296ED0
		public void StopIlluminateTarget(ref Contact theTarget, bool WillRetryToPaint = false)
		{
			try
			{
				if (this.TargetsTrackedForFireControl.Contains(theTarget))
				{
					try
					{
						this.TargetsTrackedForFireControl.Remove(theTarget);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200035", ex2.Message);
						GameGeneral.LogException(ref ex2);
						ProjectData.ClearProjectError();
					}
					if (!WillRetryToPaint)
					{
						foreach (ActiveUnit current in base.GetParentPlatform().m_Scenario.GetActiveUnits().Values)
						{
							if (current.IsWeapon && current.GetSide(false) == base.GetParentPlatform().GetSide(false) && this.SemiActiveGuidedWeaponList.Contains((Weapon)current) && current.GetAI().GetPrimaryTarget() == theTarget)
							{
								try
								{
									this.SemiActiveGuidedWeaponList.Remove((Weapon)current);
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ex4.Data.Add("Error at 200036", ex4.Message);
									GameGeneral.LogException(ref ex4);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					if (this.TargetsTrackedForFireControl.Count == 0 && this.NonSearchAndTrackSensorOtherThanMCMAndMAD())
					{
						this.TurnOff();
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100713", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x000292A9 File Offset: 0x000274A9
		public bool IsFireChannelsEnough()
		{
			return this.TargetsTrackedForFireControl.Count < this.MaxIntercept;
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00298ED0 File Offset: 0x002970D0
        //探雷距离算法
		public bool MineObstacleSearchAttempt(ActiveUnit ParentPlatform_, Unit TargetUnit_, float Range_)
		{
			bool result = false;
			try
			{
				if (this.MaxRange < Range_)
				{
					result = false;
				}
				else if (!base.IsTargetInCoverageArc(TargetUnit_, null))
				{
					result = false;
				}
				else if (TargetUnit_.GetType() == typeof(UnguidedWeapon) && ((UnguidedWeapon)TargetUnit_).IsMine())
				{
					if (this.sensorType == Sensor.SensorType.Visual)
					{
						if (((UnguidedWeapon)TargetUnit_).GetWeaponType() != Weapon._WeaponType.FloatingMine)
						{
							result = false;
						}
						else
						{
							float num = 0.161987036f;
							this.VisualSensorDetectionAttempt(ParentPlatform_, TargetUnit_, ref num);
							result = (num > Range_);
						}
					}
					else if ((this.IsSonar() || this.IsAcousticIntercept_ActiveSonarWarning()) && this.IsEmmitting() && (this.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar) || this.sensorCapability.MineObstacleSearch))
					{
						float num2;
						switch (((UnguidedWeapon)TargetUnit_).GetWeaponType())
						{
						case Weapon._WeaponType.BottomMine:
						case Weapon._WeaponType.MovingMine:
							num2 = 0.5f;
							break;
						case Weapon._WeaponType.MooredMine:
						case Weapon._WeaponType.RisingMine:
							num2 = 1f;
							break;
						case Weapon._WeaponType.FloatingMine:
							num2 = 0.7f;
							break;
						default:
							throw new NotImplementedException();
						}
						result = (this.MaxRange * num2 >= Range_);
					}
					else
					{
						result = false;
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100714", "");
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

		// Token: 0x06005BE5 RID: 23525 RVA: 0x0029909C File Offset: 0x0029729C
		public bool SensorDetectionAttempt(Sensor.DetectionAttemptType detectionAttemptType, ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, ref List<GeoPoint> DetectionAOU_, float SlantRange, ref Lazy<ObservableDictionary<int, EmissionContainer>> lazy_1, List<ActiveUnit> AffectingJammers, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar)
		{
			bool flag = false;
			bool result;
			if (this.MaxRange < SlantRange)
			{
				flag = false;
			}
			else if (!this.IsTargetDetectableByMe(TargetUnit_))
			{
				flag = false;
			}
			else if (!base.IsTargetInCoverageArc(TargetUnit_, null))
			{
				flag = false;
			}
			else if (Information.IsNothing(TargetUnit_))
			{
				flag = false;
			}
			else
			{
				float altitude_AGL = TargetUnit_.GetAltitude_AGL();
				if (this.MaxAltitude > 0f && altitude_AGL > this.MaxAltitude)
				{
					flag = false;
				}
				else if (this.MinAltitude > 0f && altitude_AGL < this.MinAltitude)
				{
					flag = false;
				}
				else if (this.MaxAltitude_ASL > 0f && TargetUnit_.GetCurrentAltitude_ASL(false) > this.MaxAltitude_ASL)
				{
					flag = false;
				}
				else if (this.MinAltitude_ASL > 0f && TargetUnit_.GetCurrentAltitude_ASL(false) < this.MinAltitude_ASL)
				{
					flag = false;
				}
				else
				{
					try
					{
						Sensor.SensorType sensorType = this.sensorType;
						bool? flag2;
						if (sensorType <= Sensor.SensorType.TowedArray_ActiveOnly)
						{
							if (sensorType <= Sensor.SensorType.ESM)
							{
								switch (sensorType)
								{
								case Sensor.SensorType.Radar:
									flag2 = new bool?(this.RadarDetectAttempt(ParentPlatform_, TargetUnit_, SlantRange, AffectingJammers, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW));
									goto IL_587;
								case Sensor.SensorType.SemiActive:
									goto IL_650;
								case Sensor.SensorType.Visual:
									flag2 = new bool?(this.VisualDetectAttempt(ParentPlatform_, TargetUnit_, SlantRange, ref LOS_Exists_Visual));
									goto IL_587;
								case Sensor.SensorType.Infrared:
									flag2 = new bool?(this.InfraredDetectAttempt(ParentPlatform_, TargetUnit_, SlantRange, ref LOS_Exists_Visual));
									goto IL_587;
								default:
									if (sensorType == Sensor.SensorType.ESM)
									{
										if (ParentPlatform_.IsWeapon && !((Weapon)ParentPlatform_).IsDecoy())
										{
											if (TargetUnit_.IsSatellite())
											{
												flag = false;
												result = false;
												return result;
											}
											if (((Weapon)ParentPlatform_).RangeAAWMax == 0f)
											{
												if (TargetUnit_.IsAircraft | TargetUnit_.IsWeapon)
												{
													flag = false;
													result = false;
													return result;
												}
											}
											else if (((Weapon)ParentPlatform_).RangeASUWMax == 0f)
											{
												flag = false;
												result = false;
												return result;
											}
										}
										flag2 = new bool?(this.ESMDetectAttempt(ParentPlatform_, TargetUnit_, SlantRange, ref lazy_1, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW));
										goto IL_587;
									}
									goto IL_650;
								}
							}
							else if (sensorType - Sensor.SensorType.HullSonar_PassiveOnly > 2)
							{
								if (sensorType - Sensor.SensorType.TowedArray_PassiveOnly > 2)
								{
									goto IL_650;
								}
								int terrainElevation = ParentPlatform_.GetTerrainElevation(false, false, false);
								SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), terrainElevation);
								float value = 0f;
								if (ParentPlatform_.IsShip)
								{
									value = (float)(layer.Bottom - 20);
								}
								else if (ParentPlatform_.IsSubmarine)
								{
									if (ParentPlatform_.GetCurrentAltitude_ASL(false) > (float)layer.Bottom && (float)(layer.Ceiling + 30) > ParentPlatform_.GetCurrentAltitude_ASL(false))
									{
										value = (float)(layer.Bottom - 20);
									}
									else
									{
										value = (float)((int)Math.Round((double)ParentPlatform_.GetCurrentAltitude_ASL(false)));
									}
								}
								if (this.IsActiveModeOnly())
								{
									flag2 = new bool?(this.ActiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, LOS_Exists_Sonar, new float?(value)));
									goto IL_587;
								}
								if (this.IsEmmitting())
								{
									flag2 = new bool?(this.ActiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, LOS_Exists_Sonar, new float?(value)));
									goto IL_587;
								}
								flag2 = new bool?(this.PassiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, lazy_1, LOS_Exists_Sonar, new float?(value)));
								goto IL_587;
							}
						}
						else if (sensorType <= Sensor.SensorType.DippingSonar_ActiveOnly)
						{
							if (sensorType - Sensor.SensorType.VDS_PassiveOnly > 2 && sensorType - Sensor.SensorType.DippingSonar_PassiveOnly > 2)
							{
								goto IL_650;
							}
							SonarEnvironment.Thermocline layer2 = SonarEnvironment.GetLayer(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), ParentPlatform_.GetTerrainElevation(false, false, false));
							float value2;
							if (GameGeneral.GetRandom().Next(0, 101) > 50)
							{
								value2 = (float)((int)Math.Round((double)layer2.Ceiling / 2.0));
							}
							else
							{
								value2 = (float)(layer2.Bottom - 30);
							}
							if (this.IsActiveModeOnly())
							{
								flag2 = new bool?(this.ActiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, LOS_Exists_Sonar, new float?(value2)));
								goto IL_587;
							}
							if (this.IsEmmitting())
							{
								flag2 = new bool?(this.ActiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, LOS_Exists_Sonar, new float?(value2)));
								goto IL_587;
							}
							flag2 = new bool?(this.PassiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, lazy_1, LOS_Exists_Sonar, new float?(value2)));
							goto IL_587;
						}
						else if (sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly)
						{
							if (sensorType == Sensor.SensorType.MAD)
							{
								flag2 = new bool?(this.MADDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange));
								goto IL_587;
							}
							if (sensorType == Sensor.SensorType.PingIntercept)
							{
								flag2 = new bool?(this.PingInterceptDetectAttempt(ParentPlatform_, TargetUnit_, SlantRange, lazy_1, LOS_Exists_Sonar));
								goto IL_587;
							}
							goto IL_650;
						}
						if (this.IsActiveModeOnly())
						{
							flag2 = new bool?(this.ActiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, LOS_Exists_Sonar, null));
						}
						else if (this.IsEmmitting())
						{
							flag2 = new bool?(this.ActiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, LOS_Exists_Sonar, null));
						}
						else
						{
							flag2 = new bool?(this.PassiveSonarDetectionAttempt(ParentPlatform_, TargetUnit_, SlantRange, lazy_1, LOS_Exists_Sonar, null));
						}
						IL_587:
						bool? flag3 = flag2;
						if ((flag3.HasValue ? new bool?(flag3.GetValueOrDefault()) : null).GetValueOrDefault() && !this.IsPreciselyLocatedEnable() && !TargetUnit_.IsFixedFacility())
						{
							List<GeoPoint> detectionAOU = ParentPlatform_.GetSensory().GetDetectionAOU(this, TargetUnit_, ParentPlatform_.GetHorizontalRange(TargetUnit_), lazy_1.Value);
							DetectionAOU_ = detectionAOU;
						}
						flag3 = flag2;
						Sensor._DetectionAttemptResult value3;
						if ((flag3.HasValue ? new bool?(flag3.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							value3 = Sensor._DetectionAttemptResult.Success;
						}
						else
						{
							value3 = Sensor._DetectionAttemptResult.NoSignature;
						}
						this.ExportSensorDetectionAttempt(ParentPlatform_, ParentPlatform_.GetSide(false), TargetUnit_, detectionAttemptType, DetectionAOU_, new Sensor._DetectionAttemptResult?(value3));
						flag = flag2.Value;
						goto IL_699;
						IL_650:
						flag = false;
						result = false;
						return result;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100715", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						flag = false;
						ProjectData.ClearProjectError();
					}
				}
			}
			IL_699:
			result = flag;
			return result;
		}

        // Token: 0x06005BE6 RID: 23526 RVA: 0x00299764 File Offset: 0x00297964
        //探测事件输出 Bluefor_SensorDetectionAttempt.csv
        private void ExportSensorDetectionAttempt(ActiveUnit activeUnit_1, Side side_0, ActiveUnit activeUnit_2, Sensor.DetectionAttemptType detectionAttemptType_0, List<GeoPoint> DetectionAOU_, Sensor._DetectionAttemptResult? enum79_0)
		{
			try
			{
				foreach (IEventExporter current in activeUnit_1.m_Scenario.GetEventExporters())
				{
					if ((current.IsExportSensorDetectionSuccess() && enum79_0 == Sensor._DetectionAttemptResult.Success) || (current.IsExportSensorDetectionFailure() && enum79_0 != Sensor._DetectionAttemptResult.Success))
					{
						Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>(24);
						dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), activeUnit_1.m_Scenario.TimelineID));
						if (current.IsUseZeroHour())
						{
							TimeSpan timeSpan = activeUnit_1.m_Scenario.GetCurrentTime(false).Subtract(activeUnit_1.m_Scenario.ZeroHour);
							dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
						}
						else
						{
							dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), activeUnit_1.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + activeUnit_1.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
						}
						dictionary.Add("SensorID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
						dictionary.Add("SensorName", new Tuple<Type, string>(typeof(string), this.Name));
						dictionary.Add("SensorParentID", new Tuple<Type, string>(typeof(string), activeUnit_1.GetGuid()));
						dictionary.Add("SensorParentName", new Tuple<Type, string>(typeof(string), activeUnit_1.Name));
						dictionary.Add("SensorParentLongitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_1.GetLongitude(null))));
						dictionary.Add("SensorParentLatitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_1.GetLatitude(null))));
						dictionary.Add("SensorParentAltitude_ASL", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_1.GetCurrentAltitude_ASL(false))));
						dictionary.Add("SensorParentAltitude_AGL", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_1.GetAltitude_AGL())));
						if (Information.IsNothing(side_0))
						{
							dictionary.Add("SensorParentSide", new Tuple<Type, string>(typeof(string), "-"));
						}
						else
						{
							dictionary.Add("SensorParentSide", new Tuple<Type, string>(typeof(string), side_0.GetSideName()));
						}
						dictionary.Add("DetectionMode", new Tuple<Type, string>(typeof(string), Misc.GetDetectionAttemptTypeString(detectionAttemptType_0)));
						dictionary.Add("TargetID", new Tuple<Type, string>(typeof(string), activeUnit_2.GetGuid()));
						dictionary.Add("TargetName", new Tuple<Type, string>(typeof(string), activeUnit_2.Name));
						dictionary.Add("TargetSide", new Tuple<Type, string>(typeof(string), activeUnit_2.GetSide(false).GetSideName()));
						dictionary.Add("TargetLongitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_2.GetLongitude(null))));
						dictionary.Add("TargetLatitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_2.GetLatitude(null))));
						dictionary.Add("TargetAltitude_ASL_m", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_2.GetCurrentAltitude_ASL(false))));
						dictionary.Add("TargetAltitude_AGL_m", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_2.GetAltitude_AGL())));
						dictionary.Add("TargetRangeHoriz_nm", new Tuple<Type, string>(typeof(float), activeUnit_1.GetHorizontalRange(activeUnit_2).ToString()));
						dictionary.Add("TargetRangeSlant_nm", new Tuple<Type, string>(typeof(float), activeUnit_1.GetSlantRange(activeUnit_2, 0f).ToString()));
						dictionary.Add("DetectionResult", new Tuple<Type, string>(typeof(string), Conversions.ToString(Interaction.IIf(enum79_0 == Sensor._DetectionAttemptResult.Success, "SUCCESS", "FAILURE"))));
						if (Information.IsNothing(DetectionAOU_))
						{
							dictionary.Add("DetectionAOU", new Tuple<Type, string>(typeof(string), "-"));
						}
						else
						{
							StringBuilder stringBuilder = new StringBuilder();
							foreach (GeoPoint current2 in DetectionAOU_)
							{
								stringBuilder.Append("{Lon:").Append(current2.GetLongitude()).Append(" - Lat:").Append(current2.GetLatitude()).Append("}");
							}
							dictionary.Add("DetectionAOU", new Tuple<Type, string>(typeof(string), stringBuilder.ToString()));
						}
						current.ExportEvent(ExportedEventType.SensorDetectionAttempt, dictionary, activeUnit_1.m_Scenario);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101326", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x00299D7C File Offset: 0x00297F7C
        //雷达探测判断
		private bool RadarDetectAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float SlantRange, List<ActiveUnit> AffectingJammers, ref bool? LOS_Exists_Radar, ref bool? TargetInLineOfSight_IgnoreHorizon)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.sensorCapability.OTH_SurfaceWave)
				{
					bool? flag2;
					bool? flag3;
					if (!TargetInLineOfSight_IgnoreHorizon.HasValue)
					{
						flag2 = new bool?(false);
					}
					else
					{
						flag3 = TargetInLineOfSight_IgnoreHorizon;
						flag2 = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3);
					}
					flag3 = flag2;
					if (flag3.GetValueOrDefault())
					{
						flag = false;
						result = false;
						return result;
					}
				}
				else
				{
					bool? flag3;
					bool? flag4;
					if (!LOS_Exists_Radar.HasValue)
					{
						flag4 = new bool?(false);
					}
					else
					{
						flag3 = LOS_Exists_Radar;
						flag4 = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3);
					}
					flag3 = flag4;
					if (flag3.GetValueOrDefault())
					{
						flag = false;
						result = false;
						return result;
					}
				}
				if (this.NonSearchAndTrackSensorOtherThanMCMAndMAD())
				{
					flag = (this.RadarWeaponGuidanceAttempt(ParentPlatform_, TargetUnit_, SlantRange, AffectingJammers, true, false, ref LOS_Exists_Radar, ref TargetInLineOfSight_IgnoreHorizon) == Sensor._DetectionAttemptResult.Success);
				}
				else
				{
					if (TargetUnit_.IsSubmarine && TargetUnit_.GetCurrentAltitude_ASL(false) >= -20f)
					{
						Submarine._SubmarineType type = ((Submarine)TargetUnit_).Type;
						if (type == Submarine._SubmarineType.None || type - Submarine._SubmarineType.Biologics <= 1)
						{
							flag = false;
							result = false;
							return result;
						}
					}
					if (TargetUnit_.IsSubmarine && TargetUnit_.GetCurrentAltitude_ASL(false) >= -20f && TargetUnit_.GetCurrentAltitude_ASL(false) < -5f && !this.sensorCapability.PeriscopeSearch)
					{
						flag = false;
					}
					else
					{
						if ((TargetUnit_.IsAircraft || TargetUnit_.IsGuidedWeapon_RV_HGV()) && ParentPlatform_.GetCurrentAltitude_ASL(false) > TargetUnit_.GetCurrentAltitude_ASL(false) && !this.sensorCode.PulseDopplerRadar_FullLDSDCapability)
						{
							float value = (float)Class258.GetLookDownAngle((double)ParentPlatform_.GetHorizontalRange(TargetUnit_), (double)ParentPlatform_.GetCurrentAltitude_ASL(false), (double)TargetUnit_.GetCurrentAltitude_ASL(false));
							if (this.sensorCode.PulseDopplerRadar_LimitedLDSDCapability && Math.Abs(value) > 15f)
							{
								flag = false;
								result = false;
								return result;
							}
							if (!this.sensorCode.PulseDopplerRadar_LimitedLDSDCapability && Math.Abs(value) > 5f)
							{
								flag = false;
								result = false;
								return result;
							}
						}
						float num = Math2.Normalize(base.GetParentPlatform().RelativeBearingTo(TargetUnit_, false));
						XSection._SignatureType signatureType;
						if (!this.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.ABand) && !this.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.BBand) && !this.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.CBand) && !this.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.DBand))
						{
							signatureType = XSection._SignatureType.Radar_E_M_Band;
						}
						else
						{
							signatureType = XSection._SignatureType.Radar_A_D_Band;
						}
						if (!Information.IsNothing(signatureType))
						{
							XSection crossSection = Sensor.GetCrossSection(TargetUnit_, signatureType);
							if (Information.IsNothing(crossSection))
							{
								crossSection = Sensor.GetCrossSection(TargetUnit_, signatureType);
							}
							if (Information.IsNothing(crossSection))
							{
								flag = false;
							}
							else
							{
								float num2 = 0f;
								if (num < 315f && num > 45f)
								{
									if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
									{
										num2 = crossSection.GetSideXSection(TargetUnit_);
									}
									else if (num >= 135f && num <= 225f)
									{
										num2 = crossSection.GetRearXSection(TargetUnit_);
									}
								}
								else
								{
									num2 = crossSection.GetFrontXSection(TargetUnit_);
								}
								if (TargetUnit_.IsFacility && ((Facility)TargetUnit_).IsMobile())
								{
									ECM.Target target = new ECM.Target();
									target.RCS = (double)num2;
									double num3 = target.GetRCS_m2();
									if (TargetUnit_.MountsAreAimpoints())
									{
										Mount[] mounts = TargetUnit_.m_Mounts;
										int num4 = 0;
										for (int i = 0; i < mounts.Length; i = checked(i + 1))
										{
											if (mounts[i].GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
											{
												num4++;
											}
										}
										if (num4 == 0)
										{
											flag = false;
											result = false;
											return result;
										}
										num3 *= Math.Sqrt((double)num4);
									}
									float num5 = TargetUnit_.GetCurrentSpeed() / (float)TargetUnit_.GetKinematics().GetSpeed(TargetUnit_.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Flank);
									float num6;
									if (num5 == 0f)
									{
										num6 = 1f;
									}
									else if (num5 < 0.2f)
									{
										num6 = 30f;
									}
									else if (num5 < 0.4f)
									{
										num6 = 60f;
									}
									else if (num5 < 0.6f)
									{
										num6 = 120f;
									}
									else if (num5 < 0.8f)
									{
										num6 = 250f;
									}
									else
									{
										num6 = 500f;
									}
									Sensor.RadioElectronicFrequency[] searchAndTrackFrequencies = this.SearchAndTrackFrequencies;
									float num7 = 0f;
									checked
									{
										for (int j = 0; j < searchAndTrackFrequencies.Length; j++)
										{
											Sensor.RadioElectronicFrequency radioElectronicFrequency = searchAndTrackFrequencies[j];
											if (radioElectronicFrequency.frequencyBand == Sensor.FrequencyBand.JBand)
											{
												num7 = 0.1f;
											}
											if (radioElectronicFrequency.frequencyBand == Sensor.FrequencyBand.KBand)
											{
												num7 = 0.2f;
											}
											if (radioElectronicFrequency.frequencyBand == Sensor.FrequencyBand.LBand)
											{
												num7 = 0.3f;
											}
											if (radioElectronicFrequency.frequencyBand == Sensor.FrequencyBand.MBand)
											{
												num7 = 0.4f;
											}
										}
									}
									num6 = Math.Max(1f, num6 + num7);
									num3 *= (double)num6;
									target.SetRCS(num3);
									num2 = (float)target.RCS;
								}
								if (!this.IsTargetDetectedByRadar(ParentPlatform_, TargetUnit_, num2, SlantRange, Sensor.Enum80.const_0, AffectingJammers, ParentPlatform_.GetWeatherProfile()))
								{
									flag = false;
								}
								else if (this.sensorCapability.OTH_Backscatter)
								{
									flag = true;
								}
								else if (this.sensorCapability.ABM_SpaceSearch && TargetUnit_.IsWeapon && (((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.RV || ((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.HGV))
								{
									flag = (Class363.smethod_1(ParentPlatform_, TargetUnit_) > Math2.GetDistance(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)));
								}
								else if (this.sensorCapability.OTH_SurfaceWave)
								{
									if (!TargetInLineOfSight_IgnoreHorizon.HasValue)
									{
										TargetInLineOfSight_IgnoreHorizon = new bool?(ParentPlatform_.IsLOS_Exists_Radar(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
									}
									flag = TargetInLineOfSight_IgnoreHorizon.Value;
								}
								else
								{
									if (!LOS_Exists_Radar.HasValue)
									{
										LOS_Exists_Radar = new bool?(ParentPlatform_.IsLOS_Exists_Radar(TargetUnit_, ref ParentPlatform_.m_Scenario, false));
									}
									flag = LOS_Exists_Radar.Value;
								}
							}
						}
						else
						{
							flag = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100716", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x0029A45C File Offset: 0x0029865C
		public static XSection GetCrossSection(ActiveUnit activeUnit_, XSection._SignatureType SignatureType_)
		{
			XSection xSection2;
			XSection result;
			try
			{
				int num = activeUnit_.GetXSections().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					XSection xSection = activeUnit_.GetXSections()[i];
					if (!Information.IsNothing(xSection) && xSection.SignatureType == SignatureType_)
					{
						xSection2 = xSection;
						result = xSection2;
						return result;
					}
				}
				xSection2 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200034", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				xSection2 = null;
				ProjectData.ClearProjectError();
			}
			result = xSection2;
			return result;
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x0029A514 File Offset: 0x00298714
		internal float GetModifiedVisualDetectRange(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_)
		{
			float result = 0f;
			try
			{
				float num = Math2.Normalize(base.GetParentPlatform().RelativeBearingTo(TargetUnit_, false));
				XSection._SignatureType signatureType_ = XSection._SignatureType.VisualDetectionRange;
				XSection crossSection = Sensor.GetCrossSection(TargetUnit_, XSection._SignatureType.VisualDetectionRange);
				if (Information.IsNothing(crossSection))
				{
					crossSection = Sensor.GetCrossSection(TargetUnit_, signatureType_);
				}
				if (Information.IsNothing(crossSection))
				{
					result = 0f;
				}
				else
				{
					float num2 = 0f;
					if (num < 315f && num > 45f)
					{
						if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
						{
							num2 = crossSection.GetSideXSection(TargetUnit_);
						}
						else if (num >= 135f && num <= 225f)
						{
							num2 = crossSection.GetRearXSection(TargetUnit_);
						}
					}
					else
					{
						num2 = crossSection.GetFrontXSection(TargetUnit_);
					}
					bool flag = false;
					if (!Information.IsNothing(ParentPlatform_) && !Information.IsNothing(ParentPlatform_.GetSide(false)) && !Information.IsNothing(ParentPlatform_.GetSide(false).GetContactObservableDictionary()) && !Information.IsNothing(TargetUnit_))
					{
						flag = ParentPlatform_.GetSide(false).GetContactObservableDictionary().ContainsKey(TargetUnit_.GetGuid());
					}
					float val;
					if (flag && this.VisualClassZoom > this.VisualDetectZoom)
					{
						val = num2 * this.VisualClassZoom;
					}
					else
					{
						val = num2 * this.VisualDetectZoom;
					}
					this.VisualSensorDetectionAttempt(ParentPlatform_, TargetUnit_, ref val);
					result = Math.Min(this.MaxRange, val);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100719", "");
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

        // Token: 0x06005BEA RID: 23530 RVA: 0x0029A6F4 File Offset: 0x002988F4//
        //internal float method_93(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_)
        internal float GetModifyIRDetectionRange(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_)
		{
			float result = 0f;
			try
			{
				float num = Math2.Normalize(base.GetParentPlatform().RelativeBearingTo(TargetUnit_, false));
				XSection crossSection = Sensor.GetCrossSection(TargetUnit_, XSection._SignatureType.InfraredDetectionRange);
				if (Information.IsNothing(crossSection))
				{
					result = 0f;
				}
				else
				{
					float num2 = 0f;
					if (num < 315f && num > 45f)
					{
						if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
						{
							num2 = crossSection.GetSideXSection(TargetUnit_);
						}
						else if (num >= 135f && num <= 225f)
						{
							num2 = crossSection.GetRearXSection(TargetUnit_);
						}
					}
					else
					{
						num2 = crossSection.GetFrontXSection(TargetUnit_);
					}
					float val;
					if (!Information.IsNothing(ParentPlatform_.GetSide(false)))
					{
						if (ParentPlatform_.GetSide(false).GetContactObservableDictionary().ContainsKey(TargetUnit_.GetGuid()) && this.IRClassZoom > this.IRDetectZoom)
						{
							val = num2 * this.IRClassZoom;
						}
						else
						{
							val = num2 * this.IRDetectZoom;
						}
					}
					else
					{
						val = num2 * this.IRDetectZoom;
					}
					this.ModifyIRDetectionRangeByRainAndFUR(ParentPlatform_, TargetUnit_, ref val);
					result = Math.Min(this.MaxRange, val);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100720", "");
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

		// Token: 0x06005BEB RID: 23531 RVA: 0x0029A894 File Offset: 0x00298A94
		public float GetDetectionRange(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_)
		{
			float num;
			float result;
			switch (this.sensorType)
			{
			case Sensor.SensorType.Radar:
				num = this.GetRadarDetectionRange(TargetUnit_);
				result = num;
				return result;
			case Sensor.SensorType.Visual:
				num = this.GetVisualDetectionRange(ParentPlatform_, TargetUnit_);
				result = num;
				return result;
			case Sensor.SensorType.Infrared:
				num = this.GetIRDetectionRange(ParentPlatform_, TargetUnit_);
				result = num;
				return result;
			}
			num = 0f;
			result = num;
			return result;
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x0029A8FC File Offset: 0x00298AFC
		private float GetVisualDetectionRange(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2)
		{
			float result = 0f;
			if (activeUnit_2.IsSubmarine && activeUnit_2.GetCurrentAltitude_ASL(false) < -20f)
			{
				result = 0f;
			}
			else
			{
				try
				{
					float num = Math2.Normalize(base.GetParentPlatform().RelativeBearingTo(activeUnit_2, false));
					XSection._SignatureType signatureType_ = XSection._SignatureType.VisualClassificationRange;
					XSection crossSection = Sensor.GetCrossSection(activeUnit_2, XSection._SignatureType.VisualClassificationRange);
					if (Information.IsNothing(crossSection))
					{
						crossSection = Sensor.GetCrossSection(activeUnit_2, signatureType_);
					}
					if (Information.IsNothing(crossSection))
					{
						result = 0f;
					}
					else
					{
						float num2 = 0f;
						if (num < 315f && num > 45f)
						{
							if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
							{
								num2 = crossSection.GetSideXSection(activeUnit_2);
							}
							else if (num >= 135f && num <= 225f)
							{
								num2 = crossSection.GetRearXSection(activeUnit_2);
							}
						}
						else
						{
							num2 = crossSection.GetFrontXSection(activeUnit_2);
						}
						float num3 = num2 * this.VisualClassZoom;
						this.VisualSensorDetectionAttempt(activeUnit_1, activeUnit_2, ref num3);
						result = num3;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100721", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x0029AA78 File Offset: 0x00298C78
		private float GetRadarDetectionRange(ActiveUnit activeUnit_1)
{
			float result;
			if (!this.sensorCode.Classification_BrilliantWeapon)
			{
				result = 0f;
			}
			else
			{
				result = this.MaxRange / 4f;
			}
			return result;
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x0029AAB0 File Offset: 0x00298CB0
		private float GetIRDetectionRange(ActiveUnit parentPlatform_, ActiveUnit targetUnit_)
		{
			float result = 0f;
			if (targetUnit_.IsSubmarine && !((Submarine)targetUnit_).IsShallowerThanPeriscopeDepth())
			{
				result = 0f;
			}
			else
			{
				try
				{
					float num = Math2.Normalize(base.GetParentPlatform().RelativeBearingTo(targetUnit_, false));
					XSection crossSection = Sensor.GetCrossSection(targetUnit_, XSection._SignatureType.InfraredClassificationRange);
					if (Information.IsNothing(crossSection))
					{
						result = 0f;
					}
					else
					{
						float num2 = 0f;
						if (num < 315f && num > 45f)
						{
							if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
							{
								num2 = crossSection.GetSideXSection(targetUnit_);
							}
							else if (num >= 135f && num <= 225f)
							{
								num2 = crossSection.GetRearXSection(targetUnit_);
							}
						}
						else
						{
							num2 = crossSection.GetFrontXSection(targetUnit_);
						}
						float num3 = num2 * this.IRClassZoom;
						this.ModifyIRDetectionRangeByRainAndFUR(parentPlatform_, targetUnit_, ref num3);
						result = num3;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100722", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x0029AC08 File Offset: 0x00298E08
		private void ModifyLaserDetectionRangeByRainAndFUR(ActiveUnit parentPlatform_, ActiveUnit targetUnit_, ref float LaserDetectionRange_)
		{
			if (LaserDetectionRange_ != 0f)
			{
				Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(targetUnit_.m_Scenario, targetUnit_.GetLatitude(null), targetUnit_.GetLongitude(null), 0);
				float rainFallRate = weatherProfile.RainFallRate;
				if (rainFallRate > 40f)
				{
					LaserDetectionRange_ = (float)((double)LaserDetectionRange_ * 0.05);
				}
				else if (rainFallRate > 30f)
				{
					LaserDetectionRange_ = (float)((double)LaserDetectionRange_ * 0.1);
				}
				else if (rainFallRate > 20f)
				{
					LaserDetectionRange_ = (float)((double)LaserDetectionRange_ * 0.25);
				}
				else if (rainFallRate > 10f)
				{
					LaserDetectionRange_ = (float)((double)LaserDetectionRange_ * 0.5);
				}
				else if (rainFallRate > 0f)
				{
					LaserDetectionRange_ = (float)((double)LaserDetectionRange_ * 0.75);
				}
				Sensor.ModifyVisualDetectRangeByFUR(weatherProfile, parentPlatform_, targetUnit_, ref LaserDetectionRange_);
			}
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x0029AC08 File Offset: 0x00298E08
		private void ModifyIRDetectionRangeByRainAndFUR(ActiveUnit parentPlatform_, ActiveUnit targetUnit_, ref float IRDetectionRange_)
		{
			if (IRDetectionRange_ != 0f)
			{
				Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(targetUnit_.m_Scenario, targetUnit_.GetLatitude(null), targetUnit_.GetLongitude(null), 0);
				float rainFallRate = weatherProfile.RainFallRate;
				if (rainFallRate > 40f)
				{
					IRDetectionRange_ = (float)((double)IRDetectionRange_ * 0.05);
				}
				else if (rainFallRate > 30f)
				{
					IRDetectionRange_ = (float)((double)IRDetectionRange_ * 0.1);
				}
				else if (rainFallRate > 20f)
				{
					IRDetectionRange_ = (float)((double)IRDetectionRange_ * 0.25);
				}
				else if (rainFallRate > 10f)
				{
					IRDetectionRange_ = (float)((double)IRDetectionRange_ * 0.5);
				}
				else if (rainFallRate > 0f)
				{
					IRDetectionRange_ = (float)((double)IRDetectionRange_ * 0.75);
				}
				Sensor.ModifyVisualDetectRangeByFUR(weatherProfile, parentPlatform_, targetUnit_, ref IRDetectionRange_);
			}
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x0029ACF8 File Offset: 0x00298EF8
		private void VisualSensorDetectionAttempt(ActiveUnit ParentPlatform_, Unit TargetUnit_, ref float VisualDetectRange)
		{
			if (VisualDetectRange != 0f)
			{
				try
				{
					if (!this.sensorCode.LLTVNVGCCD_NightCapable_Searchlight_VisualNightCapable)
					{
						DateTime currentTime = base.GetParentPlatform().m_Scenario.GetCurrentTime(false);
						float num = 0f;
						float num2 = 0f;
						switch (Class240.GetTimeOfDay(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second, TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null), 0.0))
						{
						case Weather._TimeOfDay.Day:
							num = 1f;
							num2 = 1f;
							break;
						case Weather._TimeOfDay.DawnOrDusk:
							num = 0.75f;
							num2 = 0.8f;
							break;
						case Weather._TimeOfDay.Night:
							num = 0.35f;
							num2 = 0.45f;
							break;
						}
						if (!TargetUnit_.IsAircraft && !TargetUnit_.IsGuidedWeapon_RV_HGV())
						{
							VisualDetectRange *= num2;
						}
						else
						{
							VisualDetectRange *= num;
						}
					}
					Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(base.GetParentPlatform().m_Scenario, TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null), 0);
					float rainFallRate = weatherProfile.RainFallRate;
					if (rainFallRate > 40f)
					{
						VisualDetectRange = (float)((double)VisualDetectRange * 0.2);
					}
					else if (rainFallRate > 30f)
					{
						VisualDetectRange = (float)((double)VisualDetectRange * 0.3);
					}
					else if (rainFallRate > 20f)
					{
						VisualDetectRange = (float)((double)VisualDetectRange * 0.5);
					}
					else if (rainFallRate > 10f)
					{
						VisualDetectRange = (float)((double)VisualDetectRange * 0.7);
					}
					else if (rainFallRate > 0f)
					{
						VisualDetectRange = (float)((double)VisualDetectRange * 0.9);
					}
					Sensor.ModifyVisualDetectRangeByFUR(weatherProfile, ParentPlatform_, TargetUnit_, ref VisualDetectRange);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100723", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x0029AF38 File Offset: 0x00299138
		private static void ModifyVisualDetectRangeByFUR(Weather.WeatherProfile Env_, ActiveUnit ParentPlatform_, Unit TargetUnit_, ref float VisualDetectRange)
		{
			float altitude_AGL = ParentPlatform_.GetAltitude_AGL();
			float altitude_AGL2 = TargetUnit_.GetAltitude_AGL();
			float fUR = Env_.GetFUR();
			if (fUR > 0.9f)
			{
				if ((10972.8f > altitude_AGL && altitude_AGL > 2133.6f) || (10972.8f > altitude_AGL2 && altitude_AGL2 > 2133.6f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.1);
				}
				else if (609.600037f > altitude_AGL || 609.600037f > altitude_AGL2)
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.1);
				}
			}
			else if (fUR > 0.8f)
			{
				if ((10972.8f > altitude_AGL && altitude_AGL > 2133.6f) || (10972.8f > altitude_AGL2 && altitude_AGL2 > 2133.6f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.1);
				}
				else if (609.600037f > altitude_AGL || 609.600037f > altitude_AGL2)
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.2);
				}
			}
			else if (fUR > 0.7f)
			{
				if ((4876.80029f > altitude_AGL && altitude_AGL > 2133.6f) || (4876.80029f > altitude_AGL2 && altitude_AGL2 > 2133.6f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.1);
				}
				else if ((10972.8f > altitude_AGL && altitude_AGL > 9144f) || (10972.8f > altitude_AGL2 && altitude_AGL2 > 9144f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.3);
				}
			}
			else if (fUR > 0.6f)
			{
				if ((4876.80029f > altitude_AGL && altitude_AGL > 2133.6f) || (4876.80029f > altitude_AGL2 && altitude_AGL2 > 2133.6f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.3);
				}
				else if ((9144f > altitude_AGL && altitude_AGL > 8229.601f) || (9144f > altitude_AGL2 && altitude_AGL2 > 8229.601f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.7);
				}
			}
			else if (fUR > 0.5f)
			{
				if ((8534.4f > altitude_AGL && altitude_AGL > 7620f) || (8534.4f > altitude_AGL2 && altitude_AGL2 > 7620f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.3);
				}
			}
			else if (fUR > 0.4f)
			{
				if ((4876.80029f > altitude_AGL && altitude_AGL > 2133.6f) || (4876.80029f > altitude_AGL2 && altitude_AGL2 > 2133.6f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.3);
				}
			}
			else if (fUR > 0.3f)
			{
				if ((2133.6f > altitude_AGL && altitude_AGL > 609.600037f) || (2133.6f > altitude_AGL2 && altitude_AGL2 > 609.600037f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.3);
				}
			}
			else if (fUR > 0.2f)
			{
				if ((7010.4f > altitude_AGL && altitude_AGL > 6096f) || (7010.4f > altitude_AGL2 && altitude_AGL2 > 6096f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.7);
				}
			}
			else if (fUR > 0.1f)
			{
				if ((4876.80029f > altitude_AGL && altitude_AGL > 3048f) || (4876.80029f > altitude_AGL2 && altitude_AGL2 > 3048f))
				{
					VisualDetectRange = (float)((double)VisualDetectRange * 0.7);
				}
			}
			else if (fUR > 0f && ((2133.6f > altitude_AGL && altitude_AGL > 1524f) || (2133.6f > altitude_AGL2 && altitude_AGL2 > 1524f)))
			{
				VisualDetectRange = (float)((double)VisualDetectRange * 0.7);
			}
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x000292BE File Offset: 0x000274BE
		public bool IsEyeball()
		{
			return this.b_Eyeball;
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x0029B34C File Offset: 0x0029954C
		private bool VisualDetectAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual)
		{
			bool flag = false;
			bool result;
			try
			{
				if (ParentPlatform_.IsAircraft && this.IsEyeball())
				{
					double num = (double)(ParentPlatform_.GetHorizontalRange(TargetUnit_) * 1852f);
					double num2 = Math.Atan2((double)(TargetUnit_.GetCurrentAltitude_ASL(false) - ParentPlatform_.GetCurrentAltitude_ASL(false)), num);
					double num3 = (double)ParentPlatform_.RelativeBearingTo(TargetUnit_) * 0.0174532925199433;
					Vector3D vector3D_ = new Vector3D(num * Math.Sin(num2) * Math.Cos(num3), num * Math.Sin(num2) * Math.Sin(num3), num * Math.Cos(num2));
					Matrix3D identity = Matrix3D.Identity;
					double num4 = -(double)ParentPlatform_.GetRoll() * 0.0174532925199433;
					double num5 = Math.Sin(num4);
					double double_ = Math.Cos(num4);
					identity.method_7(double_);
					identity.method_9(num5);
					identity.method_13(-num5);
					identity.method_15(double_);
					Matrix3D identity2 = Matrix3D.Identity;
					double num6 = -(double)ParentPlatform_.GetPitch() * 0.0174532925199433;
					double num7 = Math.Sin(num6);
					double double_2 = Math.Cos(num6);
					identity2.method_1(double_2);
					identity2.method_4(-num7);
					identity2.method_11(num7);
					identity2.method_15(double_2);
					Matrix3D.smethod_3(Matrix3D.smethod_2(identity2, identity), vector3D_);
					double num8 = Math.Atan2(vector3D_.method_1(), vector3D_.method_3()) * 57.2957795130823;
					double num9 = (double)ParentPlatform_.RelativeBearingTo(TargetUnit_);
					if (num8 < -45.0)
					{
						flag = false;
						result = false;
						return result;
					}
					Aircraft._CockpitVisibilityLevel cockpitVisibilityLevel;
					if (num9 < 315.0 && num9 > 45.0)
					{
						if (num9 > 45.0 && num9 < 135.0)
						{
							cockpitVisibilityLevel = ((Aircraft)ParentPlatform_).SidewaysCockpitVisibilityLevel;
						}
						else if (num9 >= 135.0 && num9 <= 225.0)
						{
							cockpitVisibilityLevel = ((Aircraft)ParentPlatform_).AftCockpitVisibilityLevel;
						}
						else
						{
							cockpitVisibilityLevel = ((Aircraft)ParentPlatform_).SidewaysCockpitVisibilityLevel;
						}
					}
					else
					{
						cockpitVisibilityLevel = ((Aircraft)ParentPlatform_).ForwardCockpitVisibilityLevel;
					}
					switch (cockpitVisibilityLevel)
					{
					case Aircraft._CockpitVisibilityLevel.Excellent:
						if (ParentPlatform_.GetRandom().Next(1, 101) > 95)
						{
							flag = false;
							result = false;
							return result;
						}
						break;
					case Aircraft._CockpitVisibilityLevel.Average:
						if (num8 < -25.0)
						{
							flag = false;
							result = false;
							return result;
						}
						if (ParentPlatform_.GetRandom().Next(1, 101) > 50)
						{
							flag = false;
							result = false;
							return result;
						}
						break;
					case Aircraft._CockpitVisibilityLevel.Poor:
						if (ParentPlatform_.GetRandom().Next(1, 101) > 2)
						{
							flag = false;
							result = false;
							return result;
						}
						break;
					}
				}
				bool? flag2;
				if (!LOS_Exists_Visual.HasValue)
				{
					flag2 = new bool?(false);
				}
				else
				{
					Unit._LOS_Exists_Visual? lOS_Exists_Visual = LOS_Exists_Visual;
					int? num10 = lOS_Exists_Visual.HasValue ? new int?((int)lOS_Exists_Visual.GetValueOrDefault()) : null;
					flag2 = (num10.HasValue ? new bool?(num10.GetValueOrDefault() != 1) : null);
				}
				bool? flag3 = flag2;
				if (flag3.GetValueOrDefault())
				{
					flag = false;
				}
				else
				{
					bool flag4 = false;
					if ((TargetUnit_.IsShip || TargetUnit_.IsSubmarine) && (ParentPlatform_.IsAircraft || ParentPlatform_.IsGuidedWeapon_RV_HGV() || ParentPlatform_.IsSatellite()))
					{
						float num11 = 0f;
						Ship._WakeDetected wakeDetected = Ship._WakeDetected.None;
						if (TargetUnit_.IsShip)
						{
							wakeDetected = ((Ship)TargetUnit_).GetWakeDetected();
						}
						if (TargetUnit_.IsSubmarine)
						{
							wakeDetected = ((Submarine)TargetUnit_).GetWakeDetected();
						}
						switch (wakeDetected)
						{
						case Ship._WakeDetected.None:
							num11 = 0f;
							break;
						case Ship._WakeDetected.VerySmall:
							num11 = 3f;
							break;
						case Ship._WakeDetected.Small:
							num11 = 10f;
							break;
						case Ship._WakeDetected.Medium:
							num11 = 19f;
							break;
						case Ship._WakeDetected.Large:
							num11 = 25f;
							break;
						case Ship._WakeDetected.VeryLarge:
							num11 = 32f;
							break;
						}
						this.VisualSensorDetectionAttempt(ParentPlatform_, TargetUnit_, ref num11);
						flag4 = (num11 > TargetRange);
					}
					bool flag5 = false;
					if (TargetUnit_.IsAircraft || TargetUnit_.IsGuidedWeapon_RV_HGV())
					{
						float num12 = 0f;
						switch (TargetUnit_.GetContrailDetected())
						{
						case ActiveUnit._ContrailDetected.None:
							num12 = 0f;
							break;
						case ActiveUnit._ContrailDetected.VerySmall:
							num12 = 2f;
							break;
						case ActiveUnit._ContrailDetected.Small:
							num12 = 10f;
							break;
						case ActiveUnit._ContrailDetected.Medium:
							num12 = 20f;
							break;
						case ActiveUnit._ContrailDetected.Large:
							num12 = 30f;
							break;
						case ActiveUnit._ContrailDetected.VeryLarge:
							num12 = 50f;
							break;
						}
						this.VisualSensorDetectionAttempt(ParentPlatform_, TargetUnit_, ref num12);
						flag5 = (num12 > TargetRange);
					}
					if (TargetUnit_.IsFacility && TargetUnit_.GetCurrentSpeed() > 0f)
					{
						flag4 = ((float)((int)Math.Round((double)(this.GetModifiedVisualDetectRange(ParentPlatform_, TargetUnit_) * (1f + TargetUnit_.GetCurrentSpeed() / 10f)))) > TargetRange);
					}
					bool flag6;
					if (!(flag6 = (TargetRange <= this.MaxRange)) && !flag4 && !flag5)
					{
						flag = false;
					}
					else if (flag6 && !flag4 && !flag5 && this.GetModifiedVisualDetectRange(ParentPlatform_, TargetUnit_) < TargetRange)
					{
						flag = false;
					}
					else if (this.sensorCapability.ABM_SpaceSearch && TargetUnit_.IsWeapon && (((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.RV || ((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.HGV))
					{
						float num13 = (float)((int)Math.Round((double)TargetUnit_.GetCurrentAltitude_ASL(false)));
						flag = (Class363.smethod_3(ParentPlatform_, ref num13) > Math2.GetDistance(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)) && flag6);
					}
					else
					{
						if (!LOS_Exists_Visual.HasValue)
						{
							LOS_Exists_Visual = new Unit._LOS_Exists_Visual?(ParentPlatform_.IsLOS_Exists_Visual(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
						}
						flag = (LOS_Exists_Visual.Value == Unit._LOS_Exists_Visual.Yes);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100724", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x0029B9C4 File Offset: 0x00299BC4
		private bool ESMDetectAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, ref Lazy<ObservableDictionary<int, EmissionContainer>> lazy_1, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW)
		{
			bool flag = false;
			checked
			{
				bool result;
				if (this.MaxRange < TargetRange_)
				{
					flag = false;
				}
				else
				{
					try
					{
						Sensor[] allNoneMCMSensors = TargetUnit_.GetAllNoneMCMSensors();
						int i = 0;
						bool flag2 = false;
						while (i < allNoneMCMSensors.Length)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorCapability.OTH_SurfaceWave)
							{
								bool? flag3;
								bool? flag4;
								if (!LOS_Exists_RadarSW.HasValue)
								{
									flag3 = new bool?(false);
								}
								else
								{
									flag4 = LOS_Exists_RadarSW;
									flag3 = (flag4.HasValue ? new bool?(!flag4.GetValueOrDefault()) : flag4);
								}
								flag4 = flag3;
								if (!flag4.GetValueOrDefault())
								{
									goto IL_D4;
								}
							}
							else
							{
								bool? flag4;
								bool? flag5;
								if (!LOS_Exists_Radar.HasValue)
								{
									flag5 = new bool?(false);
								}
								else
								{
									flag4 = LOS_Exists_Radar;
									flag5 = (flag4.HasValue ? new bool?(!flag4.GetValueOrDefault()) : flag4);
								}
								flag4 = flag5;
								if (!flag4.GetValueOrDefault())
								{
									goto IL_D4;
								}
							}
							IL_4AC:
							i++;
							continue;
							IL_D4:
							if ((sensor.sensorType != Sensor.SensorType.Radar && !sensor.IsJammer()) || !sensor.IsEmmitting() || !sensor.IsOperating() || (sensor.IsJammer() && this.sensorRole == Sensor._SensorRole.RWR_RadarWarningReceiver) || !sensor.IsTargetInCoverageArc(ParentPlatform_, null) || !this.IsFrequencyAligned(sensor))
							{
								goto IL_4AC;
							}
							bool flag6;
							Sensor.Enum80 enum79_;
							if (flag6 = (sensor.SemiActiveGuidedWeaponList.Count > 0 || sensor.NonSearchAndTrackSensorOtherThanMCMAndMAD()))
							{
								enum79_ = Sensor.Enum80.Illuminate;
							}
							else
							{
								enum79_ = Sensor.Enum80.const_0;
							}
                            //如果该探测器ESM没有侦察到目标,继续检索Sensor
                            if (!this.IsTargetEmissionDetected(sensor, TargetRange_, enum79_, ParentPlatform_.GetWeatherProfile()))
							{
								goto IL_4AC;
							}
							if (!this.sensorCapability.OTH_Backscatter)
							{
								if (sensor.sensorCapability.OTH_SurfaceWave)
								{
									if (sensor.MaxRange < TargetRange_)
									{
										flag = false;
										result = false;
										return result;
									}
									if (!LOS_Exists_RadarSW.HasValue)
									{
										LOS_Exists_RadarSW = new bool?(ParentPlatform_.IsLOS_Exists_Radar(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
									}
									if (!LOS_Exists_RadarSW.Value)
									{
										goto IL_4AC;
									}
								}
								else
								{
									if (!LOS_Exists_Radar.HasValue)
									{
										LOS_Exists_Radar = new bool?(ParentPlatform_.IsLOS_Exists_Radar(TargetUnit_, ref ParentPlatform_.m_Scenario, false));
									}
									if (!LOS_Exists_Radar.Value)
									{
										goto IL_4AC;
									}
								}
							}
							flag2 = true;
							int key;
							if (sensor.MasqueradeAs != 1001)
							{
								key = (int)sensor.MasqueradeAs;
							}
							else
							{
								key = sensor.DBID;
							}
							if (!lazy_1.Value.ContainsKey(key))
							{
								lazy_1.Value.Add(key, new EmissionContainer(0.0, flag6, this.ESMPreciseEmitterID));
							}
							if (!lazy_1.Value[key].bool_0 && flag6)
							{
								lazy_1.Value[key].bool_0 = true;
							}
							if (!lazy_1.Value[key].bool_1 && this.ESMPreciseEmitterID)
							{
								lazy_1.Value[key].bool_1 = true;
							}
							if (ParentPlatform_.IsSubmarine)
							{
								if (sensor.sensorCapability.PeriscopeSearch)
								{
									ParentPlatform_.float_19 = 0f;
								}
								else if (sensor.sensorCapability.SurfaceSearch && ParentPlatform_.GetCurrentAltitude_ASL(false) >= -5f)
								{
									ParentPlatform_.float_19 = 0f;
								}
							}
							if ((!ParentPlatform_.IsAircraft && !ParentPlatform_.IsShip && !ParentPlatform_.IsSubmarine && !ParentPlatform_.IsFacility) || ParentPlatform_.m_Weapons.Length <= 0)
							{
								goto IL_4AC;
							}
							Contact contact = ParentPlatform_.GetSide(false).GetContactObservableDictionary()[TargetUnit_.GetGuid()];
							if (Information.IsNothing(contact) || contact.GetPostureStance(ParentPlatform_.GetSide(false)) == Misc.PostureStance.Hostile)
							{
								goto IL_4AC;
							}
							Contact contact2 = TargetUnit_.GetSide(false).GetContactObservableDictionary()[ParentPlatform_.GetGuid()];
							if (!Information.IsNothing(contact2) && sensor.GetTargetsTrackedForFireControl().Contains(contact2))
							{
								contact.MarkAs(ParentPlatform_.GetSide(false), false, Misc.PostureStance.Hostile);
								string text = "";
								if (ParentPlatform_.IsAircraft && Operators.CompareString(ParentPlatform_.Name, ParentPlatform_.UnitClass, false) != 0)
								{
									text = " (" + ParentPlatform_.UnitClass + ")";
								}
								ParentPlatform_.m_Scenario.LogMessage(string.Concat(new string[]
								{
									"目标: ",
									contact.Name,
									" 正在照射",
									ParentPlatform_.Name,
									text,
									"，被视为敌对方!"
								}), LoggedMessage.MessageType.ContactChange, 0, null, ParentPlatform_.GetSide(false), new GeoPoint(contact.GetLongitude(null), contact.GetLatitude(null)));
								goto IL_4AC;
							}
							goto IL_4AC;
						}
						flag = flag2;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100725", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						flag = false;
						ProjectData.ClearProjectError();
					}
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x0029BEFC File Offset: 0x0029A0FC
        //磁场异常 探测,如果是非磁性外壳,可探测距离减半
		private bool MADDetectionAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float SlantRange)
		{
			bool result = false;
			if (TargetUnit_.IsSubmarine && ((Submarine)TargetUnit_).Type == Submarine._SubmarineType.Biologics)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				try
				{
					if (TargetUnit_.IsSubmarine && ((Submarine)TargetUnit_).submarineCode.NonmagneticHull)
					{
						flag = true;
					}
					if (flag)
					{
						result = (SlantRange < this.MaxRange / 2f);
					}
					else
					{
						result = (SlantRange < this.MaxRange);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100726", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x0029BFCC File Offset: 0x0029A1CC
		private float GetActiveSonarRangeModifierBySeaBottom(ActiveUnit TargetUnit_)
		{
			float num = 1f;
			float num2 = 0f;
			float result;
			try
			{
				float altitude_AGL = TargetUnit_.GetAltitude_AGL();
				if (altitude_AGL < 10f)
				{
					num = 0.2f;
				}
				else if (altitude_AGL < 20f)
				{
					num = 0.4f;
				}
				else if (altitude_AGL < 30f)
				{
					num = 0.7f;
				}
				if (num != 1f)
				{
					switch (this.techGenerationClass)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						num = num;
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						num = (float)((double)num + 0.1);
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						num = (float)((double)num + 0.2);
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						num = (float)((double)num + 0.3);
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						num = (float)((double)num + 0.4);
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						num = (float)((double)num + 0.5);
						break;
					case GlobalVariables.TechGenerationClass.Early2010s:
					case GlobalVariables.TechGenerationClass.Late2010s:
						num = (float)((double)num + 0.6);
						break;
					default:
						throw new NotImplementedException();
					}
					Sensor.FrequencyBand frequencyBand = this.SearchAndTrackFrequencies[0].frequencyBand;
					long num3 = frequencyBand - Sensor.FrequencyBand.LFSonar;
					if (num3 <= 3L)
					{
						switch ((uint)num3)
						{
						case 0u:
							num = (float)((double)num - 0.3);
							break;
						case 1u:
							num = (float)((double)num - 0.1);
							break;
						case 2u:
							num = num;
							break;
						case 3u:
							num = (float)((double)num - 0.5);
							break;
						default:
							goto IL_1A5;
						}
						num = (float)Math.Min(0.9, (double)num);
						num2 = num;
						result = num2;
						return result;
					}
					IL_1A5:
					throw new NotImplementedException();
				}
				num2 = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101327", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num2 = 1f;
				ProjectData.ClearProjectError();
			}
			result = num2;
			return result;
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x0029C1F0 File Offset: 0x0029A3F0
		private float GetSonarRangeModifierBySeaDepth(double TargetUnitLatitude, double TargetUnitLongitude, int TargetUnitTerrainElevation)
		{
			float num = 0f;
			float result;
			try
			{
				float num2;
				if (TargetUnitTerrainElevation <= -300)
				{
					num2 = 1f;
				}
				else if (TargetUnitTerrainElevation >= -50)
				{
					num2 = 0.5f;
				}
				else
				{
					num2 = (float)(0.5 + 0.5 * ((double)(Math.Abs(TargetUnitTerrainElevation) - 50) / 250.0));
				}
				bool flag = ArcticSeaIce.IsNearMarginalIceZone(TargetUnitLongitude, TargetUnitLatitude);
				if (num2 < 1f || flag)
				{
					float num3;
					if (flag)
					{
						num3 = 0.5f;
					}
					else
					{
						num3 = num2;
					}
					switch (this.techGenerationClass)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						num3 = num3;
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						num3 = (float)((double)num3 + 0.1);
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						num3 = (float)((double)num3 + 0.2);
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						num3 = (float)((double)num3 + 0.3);
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						num3 = (float)((double)num3 + 0.4);
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						num3 = (float)((double)num3 + 0.5);
						break;
					case GlobalVariables.TechGenerationClass.Early2010s:
					case GlobalVariables.TechGenerationClass.Late2010s:
						num3 = (float)((double)num3 + 0.6);
						break;
					default:
						throw new NotImplementedException();
					}
					Sensor.FrequencyBand frequencyBand = this.SearchAndTrackFrequencies[0].frequencyBand;
					long num4 = frequencyBand - Sensor.FrequencyBand.LFSonar;
					if (num4 <= 3L)
					{
						switch ((uint)num4)
						{
						case 0u:
							num3 = (float)((double)num3 - 0.3);
							break;
						case 1u:
							num3 = (float)((double)num3 - 0.1);
							break;
						case 2u:
							num3 = num3;
							break;
						case 3u:
							num3 = (float)((double)num3 - 0.5);
							break;
						default:
							goto IL_1D3;
						}
						num3 = (float)Math.Min(0.9, (double)num3);
						num = num3;
						result = num;
						return result;
					}
					IL_1D3:
					throw new NotImplementedException();
				}
				num = 1f;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100727", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 1f;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x0029C448 File Offset: 0x0029A648
		private float SonarRangeModifierBySensorDepth(ActiveUnit myParent, float SonarRangeModifier, float? ExplicitSensorDepth)
		{
			float result = 0f;
			try
			{
				SonarRangeModifier /= 2f;
				SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(myParent.GetLatitude(null), myParent.GetLongitude(null), myParent.GetTerrainElevation(false, false, false));
				float num;
				if (ExplicitSensorDepth.HasValue)
				{
					num = ExplicitSensorDepth.Value;
				}
				else
				{
					num = (float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)));
				}
				SonarEnvironment._SonobuoyDepthSetting sonobuoyDepthSetting = SonarEnvironment.GetSonobuoyDepthSetting(num, layer);
				SonarEnvironment._SonobuoyDepthSetting sonobuoyDepthSetting2 = SonarEnvironment.GetSonobuoyDepthSetting((float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false))), layer);
				float strength = layer.Strength;
				if (sonobuoyDepthSetting != SonarEnvironment._SonobuoyDepthSetting.Shallow || sonobuoyDepthSetting2 != SonarEnvironment._SonobuoyDepthSetting.Shallow)
				{
					if (sonobuoyDepthSetting == SonarEnvironment._SonobuoyDepthSetting.Intermediate && sonobuoyDepthSetting2 == SonarEnvironment._SonobuoyDepthSetting.Intermediate)
					{
						SonarRangeModifier = (float)((double)SonarRangeModifier * Math.Max(0.1, (double)(1f - strength * 2f)));
					}
					else if (sonobuoyDepthSetting != SonarEnvironment._SonobuoyDepthSetting.Intermediate && sonobuoyDepthSetting2 != SonarEnvironment._SonobuoyDepthSetting.Intermediate)
					{
						if (sonobuoyDepthSetting != sonobuoyDepthSetting2)
						{
							SonarRangeModifier *= 1f - strength;
						}
						else if (sonobuoyDepthSetting == SonarEnvironment._SonobuoyDepthSetting.Deep && sonobuoyDepthSetting2 == SonarEnvironment._SonobuoyDepthSetting.Deep)
						{
							if (layer.method_0(num) && layer.method_0((float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)))))
							{
								SonarRangeModifier *= 2f;
							}
							else if (layer.method_0(num) || layer.method_0((float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)))))
							{
								SonarRangeModifier = (float)((double)SonarRangeModifier * 1.5);
							}
						}
					}
					else
					{
						SonarRangeModifier *= 1f - strength / 2f;
					}
				}
				result = SonarRangeModifier;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100728", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = SonarRangeModifier / 2f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x0029C654 File Offset: 0x0029A854
		private bool ActiveSonarDetectionAttempt(ActiveUnit myParent, ActiveUnit TargetUnit_, float TargetRange, bool? LOS_Exists_Sonar, float? ExplicitSensorDepth = null)
		{
			bool result = false;
			try
			{
				if ((LOS_Exists_Sonar.HasValue ? (LOS_Exists_Sonar.HasValue ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar) : new bool?(false)).GetValueOrDefault())
				{
					result = false;
				}
				else
				{
					short num;
					if (this.IsTowedArraySonar())
					{
						num = 25;
					}
					else
					{
						num = 30;
					}
					if (myParent.GetCurrentSpeed() >= (float)num && !myParent.IsWeapon)
					{
						result = false;
					}
					else
					{
						if (myParent.IsTorpedo())
						{
							TargetRange = myParent.GetHorizontalRange(TargetUnit_);
						}
						float maxRange = this.MaxRange;
						float num2;
						if (myParent.IsTorpedo())
						{
							num2 = 1f;
						}
						else
						{
							float num3 = (float)myParent.GetKinematics().GetSpeed(myParent.GetKinematics().GetMinAltitude(), ActiveUnit.Throttle.Flank);
							float num4;
							float num5;
							if (myParent.GetCurrentSpeed() <= 5f)
							{
								num4 = 0f;
								num5 = 0f;
							}
							else
							{
								num4 = (float)((double)(myParent.GetDesiredSpeed() - 5f) / ((double)num3 + 1E-06 - 5.0));
								Sensor.SensorType sensorType = this.sensorType;
								if (sensorType - Sensor.SensorType.TowedArray_ActivePassive <= 1 || sensorType - Sensor.SensorType.VDS_ActivePassive <= 1)
								{
									num4 = this.SonarRangeModifierBySensorDepth(myParent, num4, ExplicitSensorDepth);
								}
								num5 = (float)((double)(myParent.GetCurrentSpeed() - 5f) / ((double)num3 + 1E-06 - 5.0));
							}
							num2 = (float)(1.0 - (0.75 * (double)num4 + 0.25 * (double)num5));
						}
						float num6 = Math2.Normalize(base.GetParentPlatform().RelativeBearingTo(TargetUnit_, false));
						XSection crossSection = Sensor.GetCrossSection(TargetUnit_, XSection._SignatureType.ActiveSonar_VLF_HF);
						if (Information.IsNothing(crossSection))
						{
							result = false;
						}
						else
						{
							float num7 = 0f;
							float num8 = 0f;
							if (num6 < 315f && num6 > 45f)
							{
								if ((num6 >= 45f && num6 <= 135f) || (num6 >= 225f && num6 <= 315f))
								{
									num7 = crossSection.GetSideXSection(TargetUnit_);
									if (myParent.IsTorpedo())
									{
										num8 = 100f;
									}
									else
									{
										num8 = 250f;
									}
								}
								else if (num6 >= 135f && num6 <= 225f)
								{
									num7 = crossSection.GetRearXSection(TargetUnit_);
									if (myParent.IsTorpedo())
									{
										num8 = 15f;
									}
									else
									{
										num8 = 60f;
									}
								}
							}
							else
							{
								num7 = crossSection.GetFrontXSection(TargetUnit_);
								if (myParent.IsTorpedo())
								{
									num8 = 15f;
								}
								else
								{
									num8 = 60f;
								}
							}
							float num9 = num7 / num8;
							float sonarRangeModifierBySensorDepth = this.GetSonarRangeModifierByFactors(myParent, TargetUnit_, ExplicitSensorDepth);
							float sonarRangeModifierBySeaDepth = this.GetSonarRangeModifierBySeaDepth(TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null), TargetUnit_.GetTerrainElevation(false, false, false));
							float activeSonarRangeModifierBySeaBottom = this.GetActiveSonarRangeModifierBySeaBottom(TargetUnit_);
							float num10 = (float)(9.87473 * (double)sonarRangeModifierBySensorDepth * (double)sonarRangeModifierBySeaDepth * (double)activeSonarRangeModifierBySeaBottom);
							float num11 = maxRange * num2 * sonarRangeModifierBySensorDepth * sonarRangeModifierBySeaDepth * activeSonarRangeModifierBySeaBottom * num9;
							if (TargetRange <= num10 && TargetRange <= num11)
							{
								result = true;
							}
							else if (this.CanActiveSonarDetectTarget(myParent, TargetUnit_, num11, TargetRange, num11, ExplicitSensorDepth))
							{
								result = true;
							}
							else if (this.CanActiveSonarDetectTarget(myParent, TargetUnit_, num11, ref TargetRange, ExplicitSensorDepth))
							{
								result = true;
							}
							else if (TargetRange > num10)
							{
								result = false;
							}
							else if (TargetRange > num11)
							{
								result = false;
							}
							else
							{
								if (!LOS_Exists_Sonar.HasValue)
								{
									bool flag = false;
									LOS_Exists_Sonar = new bool?(myParent.IsLOS_Exists_Sonar(TargetUnit_, ref myParent.m_Scenario, ref flag, ExplicitSensorDepth));
								}
								result = LOS_Exists_Sonar.Value;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100729", "");
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

		// Token: 0x06005BFB RID: 23547 RVA: 0x0029CA70 File Offset: 0x0029AC70
		private bool PingInterceptDetectAttempt(ActiveUnit MyParent, ActiveUnit TargetUnit, float TargetRange, Lazy<ObservableDictionary<int, EmissionContainer>> lazy_1, bool? LOS_Exists_Sonar)
		{
			bool flag = false;
			bool result;
			try
			{
				if ((LOS_Exists_Sonar.HasValue ? (LOS_Exists_Sonar.HasValue ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar) : new bool?(false)).GetValueOrDefault())
				{
					flag = false;
				}
				else if (this.MaxRange < TargetRange)
				{
					flag = false;
				}
				else
				{
					if (!LOS_Exists_Sonar.HasValue)
					{
						bool flag2 = true;
						if (base.GetParentPlatform().IsShip && TargetUnit.IsShip)
						{
							flag2 = false;
						}
						if (this.sensorType == Sensor.SensorType.PingIntercept && TargetUnit.IsAircraft && ((Aircraft)TargetUnit).GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
						{
							flag2 = false;
						}
						if (flag2)
						{
							bool flag3 = false;
							LOS_Exists_Sonar = new bool?(MyParent.IsLOS_Exists_Sonar(TargetUnit, ref MyParent.m_Scenario, ref flag3, null));
							if ((LOS_Exists_Sonar.HasValue ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar).GetValueOrDefault())
							{
								flag = (result = LOS_Exists_Sonar.Value);
								return result;
							}
						}
					}
					float num = (float)MyParent.GetKinematics().GetSpeed(MyParent.GetKinematics().GetMinAltitude(), ActiveUnit.Throttle.Flank);
					float num2 = (float)((double)base.GetParentPlatform().GetDesiredSpeed() / ((double)num + 1E-06));
					float num3 = (float)((double)MyParent.GetCurrentSpeed() / ((double)num + 1E-06));
					float num4 = (float)(1.0 - (0.75 * (double)num2 + 0.25 * (double)num3));
					float num5 = this.MaxRange * num4;
					float sonarRangeModifierBySensorDepth = this.GetSonarRangeModifierByFactors(MyParent, TargetUnit, null);
					float num6 = (float)(9.87473 * (double)sonarRangeModifierBySensorDepth);
					float maxSensorRange = num5 * sonarRangeModifierBySensorDepth;
					bool flag4 = this.CanActiveSonarDetectTarget(MyParent, TargetUnit, maxSensorRange, ref TargetRange, null);
					Sensor[] allNoneMCMSensors = TargetUnit.GetAllNoneMCMSensors();
					bool flag5 = false;
					checked
					{
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if ((sensor.IsSonar() || sensor.IsAcousticIntercept_ActiveSonarWarning()) && sensor.IsEmmitting() && sensor.IsOperating() && sensor.IsTargetInCoverageArc(MyParent, null) && this.IsFrequencyAligned(sensor))
							{
								if (TargetRange < num6)
								{
									flag5 = true;
								}
								else if (flag4)
								{
									flag5 = true;
								}
								if (flag5)
								{
									int key;
									if (sensor.MasqueradeAs != 1001)
									{
										key = (int)sensor.MasqueradeAs;
									}
									else
									{
										key = sensor.DBID;
									}
									if (!lazy_1.Value.ContainsKey(key))
									{
										lazy_1.Value.Add(key, new EmissionContainer(0.0, false, this.ESMPreciseEmitterID));
									}
									if (!lazy_1.Value[key].bool_1 && this.ESMPreciseEmitterID)
									{
										lazy_1.Value[key].bool_1 = true;
									}
								}
							}
						}
						flag = flag5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100730", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x0029CDEC File Offset: 0x0029AFEC
		private bool PassiveSonarDetectionAttempt(ActiveUnit myParent, ActiveUnit TargetUnit, float TargetRange, Lazy<ObservableDictionary<int, EmissionContainer>> DetectedEmissions, bool? LOS_Exists_Sonar, float? ExplicitSensorDepth = null)
		{
			bool flag = false;
			bool result;
			try
			{
				if ((LOS_Exists_Sonar.HasValue ? (LOS_Exists_Sonar.HasValue ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar) : new bool?(false)).GetValueOrDefault())
				{
					flag = false;
				}
				else
				{
					if (this.sensorType == Sensor.SensorType.BottomFixedSonar_PassiveOnly)
					{
						ExplicitSensorDepth = new float?((float)(myParent.GetTerrainElevation(false, false, false) + 1));
					}
					if (myParent.IsTorpedo())
					{
						TargetRange = myParent.GetHorizontalRange(TargetUnit);
					}
					short num;
					if (this.IsTowedArraySonar())
					{
						num = 25;
					}
					else if (myParent.IsTorpedo())
					{
						num = 200;
					}
					else
					{
						num = 30;
					}
					if (myParent.GetCurrentSpeed() >= (float)num)
					{
						flag = false;
					}
					else if (TargetRange > this.MaxRange)
					{
						flag = false;
					}
					else
					{
						bool flag2 = true;
						bool flag3 = false;
						if (base.GetParentPlatform().IsShip && TargetUnit.IsShip)
						{
							flag2 = false;
						}
						if (this.sensorType == Sensor.SensorType.BottomFixedSonar_PassiveOnly)
						{
							flag2 = false;
							flag3 = true;
						}
						if (this.IsDippingSonar())
						{
							flag2 = false;
						}
						if (flag2)
						{
							if (!LOS_Exists_Sonar.HasValue)
							{
								LOS_Exists_Sonar = new bool?(myParent.IsLOS_Exists_Sonar(TargetUnit, ref myParent.m_Scenario, ref flag3, null));
							}
							if ((LOS_Exists_Sonar.HasValue ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar).GetValueOrDefault())
							{
								flag = (result = LOS_Exists_Sonar.Value);
								return result;
							}
						}
						if (!Information.IsNothing(DetectedEmissions) && this.PingInterceptDetectAttempt(myParent, TargetUnit, TargetRange, DetectedEmissions, LOS_Exists_Sonar))
						{
							flag = true;
						}
						else
						{
							if (flag3)
							{
								if (!LOS_Exists_Sonar.HasValue)
								{
									LOS_Exists_Sonar = new bool?(myParent.IsLOS_Exists_Sonar(TargetUnit, ref myParent.m_Scenario, ref flag3, null));
								}
								if ((LOS_Exists_Sonar.HasValue ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar).GetValueOrDefault())
								{
									flag = false;
									result = false;
									return result;
								}
							}
							float num2;
							if (this.IsDippingSonar())
							{
								num2 = 1f;
							}
							else
							{
								float num3 = (float)myParent.GetKinematics().GetSpeed(myParent.GetKinematics().GetMinAltitude(), ActiveUnit.Throttle.Flank);
								float num4;
								float num5;
								if (myParent.GetCurrentSpeed() <= 5f)
								{
									num4 = 0f;
									num5 = 0f;
								}
								else
								{
									num4 = (float)((double)(myParent.GetDesiredSpeed() - 5f) / ((double)num3 + 1E-06 - 5.0));
									Sensor.SensorType sensorType = this.sensorType;
									if (sensorType - Sensor.SensorType.TowedArray_ActivePassive <= 1 || sensorType - Sensor.SensorType.VDS_ActivePassive <= 1)
									{
										num4 = this.SonarRangeModifierBySensorDepth(myParent, num4, ExplicitSensorDepth);
									}
									num5 = (float)((double)(myParent.GetCurrentSpeed() - 5f) / ((double)num3 + 1E-06 - 5.0));
								}
								num2 = (float)(1.0 - (0.75 * (double)num4 + 0.25 * (double)num5));
							}
							if (myParent.IsTorpedo())
							{
								num2 = (float)Math.Max(0.9, (double)num2);
							}
							float num6 = (float)TargetUnit.GetKinematics().GetSpeed(TargetUnit.GetKinematics().GetMinAltitude(), ActiveUnit.Throttle.Flank);
							double num7;
							if ((TargetUnit.IsShip && ((Ship)TargetUnit).IsNuclearPowered()) || (TargetUnit.IsSubmarine && ((Submarine)TargetUnit).IsNuclearPropelled()))
							{
								num7 = Math.Min(1.0, (double)(TargetUnit.GetDesiredSpeed() + 5f) / ((double)num6 + 1E-06));
							}
							else
							{
								num7 = (double)TargetUnit.GetDesiredSpeed() / ((double)num6 + 1E-06);
							}
							float num8 = (float)((double)TargetUnit.GetCurrentSpeed() / ((double)num6 + 1E-06));
							float num9 = (float)(0.75 * num7 + 0.25 * (double)num8);
							XSection xSection = null;
							Sensor.FrequencyBand frequencyBand = this.SearchAndTrackFrequencies[0].frequencyBand;
							long num10 = frequencyBand - Sensor.FrequencyBand.LFSonar;
							int num11 = 0;
							if (num10 <= 3L)
							{
								switch ((uint)num10)
								{
								case 0u:
									xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_LF);
									if (Information.IsNothing(xSection))
									{
										xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_LF);
									}
									num11 = 112;
									break;
								case 1u:
									xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_MF);
									if (Information.IsNothing(xSection))
									{
										xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_MF);
									}
									num11 = 104;
									break;
								case 2u:
									xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_HF);
									if (Information.IsNothing(xSection))
									{
										xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_HF);
									}
									num11 = 96;
									break;
								case 3u:
									xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_VLF);
									if (Information.IsNothing(xSection))
									{
										xSection = Sensor.GetCrossSection(TargetUnit, XSection._SignatureType.PassiveSonar_VLF);
									}
									num11 = 142;
									break;
								}
							}
							if (Information.IsNothing(xSection))
							{
								flag = false;
							}
							else
							{
								float num12 = myParent.RelativeBearingTo(TargetUnit, false);
								float num13 = 0f;
								if (num12 < 315f && num12 > 45f)
								{
									if ((num12 >= 45f && num12 <= 135f) || (num12 >= 225f && num12 <= 315f))
									{
										num13 = xSection.GetSideXSection(TargetUnit);
									}
									else if (num12 >= 135f && num12 <= 225f)
									{
										num13 = xSection.GetRearXSection(TargetUnit);
									}
								}
								else
								{
									num13 = xSection.GetFrontXSection(TargetUnit);
								}
								if ((TargetUnit.IsShip && ((Ship)TargetUnit).method_127()) || (TargetUnit.IsSubmarine && ((Submarine)TargetUnit).method_135()))
								{
									num13 += 15f;
								}
								if (TargetUnit.IsSubmarine && TargetUnit.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									num13 += 15f;
								}
								float num14 = num13 / (float)num11;
								float num15 = this.MaxRange * num2 * num9 * num14;
								float sonarRangeModifierBySensorDepth = this.GetSonarRangeModifierByFactors(myParent, TargetUnit, ExplicitSensorDepth);
								float sonarRangeModifierBySeaDepth = this.GetSonarRangeModifierBySeaDepth(TargetUnit.GetLatitude(null), TargetUnit.GetLongitude(null), TargetUnit.GetTerrainElevation(false, false, false));
								float num16 = (float)(9.87473 * (double)sonarRangeModifierBySensorDepth * (double)sonarRangeModifierBySeaDepth);
								float num17 = num15 * sonarRangeModifierBySensorDepth * sonarRangeModifierBySeaDepth;
								flag = ((TargetRange < num16 && TargetRange < num17) || (this.sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly && this.CanActiveSonarDetectTarget(myParent, TargetUnit, num17, ref TargetRange, ExplicitSensorDepth) && TargetRange < num17) || ((this.sensorType == Sensor.SensorType.BottomFixedSonar_PassiveOnly || TargetRange <= num16) && num17 >= TargetRange));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100731", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x0029D554 File Offset: 0x0029B754
		public float GetSonarRangeModifierByFactors(ActiveUnit SensorParent, ActiveUnit TargetUnit, float? ExplicitSensorDepth = null)
		{
			float result = 1f;
			this.ModifySonarRangeInShallowWater(SensorParent, TargetUnit, ref result, ExplicitSensorDepth);
			this.ModifySonarRangeByDepth(SensorParent, TargetUnit, ref result, ExplicitSensorDepth);
			this.SonarDetectionRangeByEnvLayer(SensorParent, TargetUnit, ref result, ExplicitSensorDepth);
			return result;
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x0029D58C File Offset: 0x0029B78C
		private void ModifySonarRangeInShallowWater(ActiveUnit myParent, ActiveUnit TargetUnit, ref float DetectionRange, float? ExplicitSensorDepth = null)
		{
			try
			{
				int num = -50;
				float num2;
				if (ExplicitSensorDepth.HasValue)
				{
					num2 = ExplicitSensorDepth.Value;
				}
				else
				{
					num2 = (float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)));
				}
				if (num2 > (float)num && TargetUnit.GetCurrentAltitude_ASL(false) > (float)num)
				{
					DetectionRange = (float)(1.5 * (double)DetectionRange);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100732", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x0029D640 File Offset: 0x0029B840
		private bool CanActiveSonarDetectTarget(ActiveUnit myParent, ActiveUnit TargetUnit_, float MaxSensorRange, float TargetRange, float ActualDetectionRange, float? ExplicitSensorDepth = null)
		{
			float num;
			if (ExplicitSensorDepth.HasValue)
			{
				num = ExplicitSensorDepth.Value;
			}
			else
			{
				num = (float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)));
			}
			float num2 = ActualDetectionRange;
			bool flag = false;
			bool result;
			try
			{
				GeoPoint geoPoint = new GeoPoint();
				float num3 = num - (float)Terrain.GetElevation(myParent.GetLatitude(null), myParent.GetLongitude(null), false);
				float num4 = TargetUnit_.GetCurrentAltitude_ASL(false) - (float)Terrain.GetElevation(TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null), false);
				float num5 = num3 * TargetRange / (num3 + num4);
				double longitude = myParent.GetLongitude(null);
				double latitude = myParent.GetLatitude(null);
				GeoPoint geoPoint2;
				double longitude2 = (geoPoint2 = geoPoint).GetLongitude();
				GeoPoint geoPoint3;
				double latitude2 = (geoPoint3 = geoPoint).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num5, (double)Math2.GetAzimuth(myParent.GetLatitude(null), myParent.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)));
				geoPoint3.SetLatitude(latitude2);
				geoPoint2.SetLongitude(longitude2);
				float num6 = 1f;
				this.ModifySonarRangeByDepth(myParent, TargetUnit_, ref num6, ExplicitSensorDepth);
				if (num6 < 1f)
				{
					num2 = ActualDetectionRange * (1f + num6 / 2f);
				}
				GeoPoint geoPoint4 = new GeoPoint(myParent.GetLongitude(null), myParent.GetLatitude(null), num);
				GeoPoint geoPoint_ = new GeoPoint(TargetUnit_.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetCurrentAltitude_ASL(false));
				if (geoPoint4.GetSlantDistance(geoPoint) + geoPoint.GetSlantDistance(geoPoint_) < num2)
				{
					float num7 = Terrain.smethod_5(geoPoint.GetLatitude(), geoPoint.GetLongitude(), false);
					float num8 = 1f - num7;
					switch (this.techGenerationClass)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						num8 = (float)((double)num8 + 0.1);
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						num8 = (float)((double)num8 + 0.2);
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						num8 = (float)((double)num8 + 0.3);
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						num8 = (float)((double)num8 + 0.4);
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						num8 = (float)((double)num8 + 0.5);
						break;
					case GlobalVariables.TechGenerationClass.Early2010s:
					case GlobalVariables.TechGenerationClass.Late2010s:
						num8 = (float)((double)num8 + 0.6);
						break;
					default:
						throw new NotImplementedException();
					}
					Sensor.FrequencyBand frequencyBand = this.SearchAndTrackFrequencies[0].frequencyBand;
					long num9 = frequencyBand - Sensor.FrequencyBand.LFSonar;
					if (num9 <= 3L)
					{
						switch ((uint)num9)
						{
						case 0u:
							num8 = (float)((double)num8 - 0.3);
							break;
						case 1u:
							num8 = (float)((double)num8 - 0.1);
							break;
						case 2u:
							num8 = num8;
							break;
						case 3u:
							num8 = (float)((double)num8 - 0.5);
							break;
						default:
							goto IL_360;
						}
						num2 *= num8;
						if (num2 <= ActualDetectionRange)
						{
							flag = true;
							result = true;
							return result;
						}
						flag = false;
						result = false;
						return result;
					}
					IL_360:
					throw new NotImplementedException();
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100733", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x0029DA1C File Offset: 0x0029BC1C
		private bool CanActiveSonarDetectTarget(ActiveUnit myParent, ActiveUnit theUnit, float MaxSensorRange, ref float TargetRange, float? ExplicitSensorDepth = null)
		{
			bool flag = false;
			bool result;
			try
			{
				float convergenceZoneIncrement = SonarEnvironment.GetConvergenceZoneIncrement(myParent.GetLatitude(null));
				float num = 5f;
				float num2 = convergenceZoneIncrement + num;
				int num3 = 1;
				while (true)
				{
					float num4 = (float)((double)((float)num3 * convergenceZoneIncrement) - (double)num * 0.5);
					float num5 = (float)((double)((float)num3 * convergenceZoneIncrement) + (double)num * 0.5);
					if (num4 > MaxSensorRange)
					{
						break;
					}
					if (TargetRange > num4 && num5 > TargetRange)
					{
						goto IL_83;
					}
					num3++;
				}
				flag = false;
				result = false;
				return result;
				IL_83:
				GeoPoint geoPoint = new GeoPoint();
				float azimuth = Math2.GetAzimuth(myParent.GetLatitude(null), myParent.GetLongitude(null), theUnit.GetLatitude(null), theUnit.GetLongitude(null));
				int num6 = 0;
				while (true)
				{
					float num7 = num2 * (float)num6 + convergenceZoneIncrement / 2f;
					if (num7 > TargetRange)
					{
						break;
					}
					double longitude = myParent.GetLongitude(null);
					double latitude = myParent.GetLatitude(null);
					GeoPoint geoPoint2;
					double longitude2 = (geoPoint2 = geoPoint).GetLongitude();
					GeoPoint geoPoint3;
					double latitude2 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num7, (double)azimuth);
					geoPoint3.SetLatitude(latitude2);
					geoPoint2.SetLongitude(longitude2);
					if (Terrain.GetElevation(geoPoint.GetLatitude(), geoPoint.GetLongitude(), false) > -200)
					{
						goto IL_17D;
					}
					num6++;
				}
				flag = true;
				goto IL_1C6;
				IL_17D:
				flag = false;
				result = false;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100733", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			IL_1C6:
			result = flag;
			return result;
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x0029DC10 File Offset: 0x0029BE10
		private void SonarDetectionRangeByEnvLayer(ActiveUnit myParent, ActiveUnit theUnit, ref float DetectionRange, float? ExplicitSensorDepth = null)
		{
			try
			{
				SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(myParent.GetLatitude(null), myParent.GetLongitude(null), myParent.GetTerrainElevation(false, false, false));
				SonarEnvironment.Thermocline layer2 = SonarEnvironment.GetLayer(theUnit.GetLatitude(null), theUnit.GetLongitude(null), theUnit.GetTerrainElevation(false, false, false));
				float num;
				if (ExplicitSensorDepth.HasValue)
				{
					num = ExplicitSensorDepth.Value;
				}
				else
				{
					num = (float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)));
				}
				int sonobuoyDepthSetting = (int)SonarEnvironment.GetSonobuoyDepthSetting(num, layer);
				SonarEnvironment._SonobuoyDepthSetting sonobuoyDepthSetting2 = SonarEnvironment.GetSonobuoyDepthSetting((float)((int)Math.Round((double)theUnit.GetCurrentAltitude_ASL(false))), layer2);
				if (sonobuoyDepthSetting == 2 && sonobuoyDepthSetting2 == SonarEnvironment._SonobuoyDepthSetting.Deep)
				{
					if (layer.method_0(num) && layer2.method_0((float)((int)Math.Round((double)theUnit.GetCurrentAltitude_ASL(false)))))
					{
						DetectionRange *= 2f;
					}
					else if (layer.method_0(num) || layer2.method_0((float)((int)Math.Round((double)theUnit.GetCurrentAltitude_ASL(false)))))
					{
						DetectionRange = (float)((double)DetectionRange * 1.5);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 102134656566777", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x0029DD9C File Offset: 0x0029BF9C
		private void ModifySonarRangeByDepth(ActiveUnit myParent, ActiveUnit theUnit, ref float DetectionRangeModifier, float? ExplicitSensorDepth = null)
		{
			try
			{
				SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(myParent.GetLatitude(null), myParent.GetLongitude(null), myParent.GetTerrainElevation(false, false, false));
				SonarEnvironment.Thermocline layer2 = SonarEnvironment.GetLayer(theUnit.GetLatitude(null), theUnit.GetLongitude(null), theUnit.GetTerrainElevation(false, false, false));
				float altitude_ASL_;
				if (ExplicitSensorDepth.HasValue)
				{
					altitude_ASL_ = ExplicitSensorDepth.Value;
				}
				else
				{
					altitude_ASL_ = (float)((int)Math.Round((double)myParent.GetCurrentAltitude_ASL(false)));
				}
				SonarEnvironment._SonobuoyDepthSetting sonobuoyDepthSetting = SonarEnvironment.GetSonobuoyDepthSetting(altitude_ASL_, layer);
				SonarEnvironment._SonobuoyDepthSetting sonobuoyDepthSetting2 = SonarEnvironment.GetSonobuoyDepthSetting((float)((int)Math.Round((double)theUnit.GetCurrentAltitude_ASL(false))), layer2);
				float num = (layer.Strength + layer2.Strength) / 2f;
				if (sonobuoyDepthSetting != SonarEnvironment._SonobuoyDepthSetting.Shallow || sonobuoyDepthSetting2 != SonarEnvironment._SonobuoyDepthSetting.Shallow)
				{
					if (sonobuoyDepthSetting == SonarEnvironment._SonobuoyDepthSetting.Intermediate && sonobuoyDepthSetting2 == SonarEnvironment._SonobuoyDepthSetting.Intermediate)
					{
						DetectionRangeModifier = (float)((double)DetectionRangeModifier * Math.Max(0.1, (double)(1f - num * 2f)));
					}
					else if (sonobuoyDepthSetting != SonarEnvironment._SonobuoyDepthSetting.Intermediate && sonobuoyDepthSetting2 != SonarEnvironment._SonobuoyDepthSetting.Intermediate)
					{
						if (sonobuoyDepthSetting != sonobuoyDepthSetting2)
						{
							DetectionRangeModifier *= 1f - num;
						}
						else if (sonobuoyDepthSetting == SonarEnvironment._SonobuoyDepthSetting.Deep)
						{
						}
					}
					else
					{
						DetectionRangeModifier *= 1f - num / 2f;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100734", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x0029DF50 File Offset: 0x0029C150
		private bool InfraredDetectAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual)
		{
			bool result = false;
			try
			{
				bool? flag;
				if (!LOS_Exists_Visual.HasValue)
				{
					flag = new bool?(false);
				}
				else
				{
					Unit._LOS_Exists_Visual? lOS_Exists_Visual = LOS_Exists_Visual;
					int? num = lOS_Exists_Visual.HasValue ? new int?((int)lOS_Exists_Visual.GetValueOrDefault()) : null;
					flag = (num.HasValue ? new bool?(num.GetValueOrDefault() != 1) : null);
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault())
				{
					result = false;
				}
				else if (TargetRange_ > this.MaxRange)
				{
					result = false;
				}
				else if (TargetUnit_.IsSubmarine && TargetUnit_.GetCurrentAltitude_ASL(false) >= -20f && TargetUnit_.GetCurrentAltitude_ASL(false) < -5f && !this.sensorCapability.PeriscopeSearch)
				{
					result = false;
				}
				else if (this.GetModifyIRDetectionRange(ParentPlatform_, TargetUnit_) < TargetRange_)
				{
					result = false;
				}
				else if (this.sensorCapability.ABM_SpaceSearch && TargetUnit_.IsWeapon && (((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.RV || ((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.HGV))
				{
					float num2 = (float)((int)Math.Round((double)TargetUnit_.GetCurrentAltitude_ASL(false)));
					result = (Class363.smethod_3(ParentPlatform_, ref num2) > Math2.GetDistance(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)));
				}
				else
				{
					if (!LOS_Exists_Visual.HasValue)
					{
						LOS_Exists_Visual = new Unit._LOS_Exists_Visual?(ParentPlatform_.IsLOS_Exists_Visual(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
					}
					result = (LOS_Exists_Visual.Value == Unit._LOS_Exists_Visual.Yes);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100735", "");
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

		// Token: 0x06005C04 RID: 23556 RVA: 0x0029E178 File Offset: 0x0029C378
		public Sensor._DetectionAttemptResult WeaponGuidanceAttempt(ActiveUnit ParentPlatform_, ref Contact theTarget_, ref Scenario scenario_0, float TargetRange_, List<ActiveUnit> AffectingJammers, bool ParentIsShip_, bool bool_13, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar)
		{
			ActiveUnit actualUnit = theTarget_.ActualUnit;
			return this.WeaponGuidanceAttempt(ParentPlatform_, actualUnit, TargetRange_, AffectingJammers, ParentIsShip_, bool_13, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x0029E1A8 File Offset: 0x0029C3A8
		private Sensor._DetectionAttemptResult RadarWeaponGuidanceAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, List<ActiveUnit> AffectingJammers, bool ParentIsShip_, bool bool_13, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW)
		{
			Sensor._DetectionAttemptResult detectionAttemptResult = Sensor._DetectionAttemptResult.Failure;
			Sensor._DetectionAttemptResult result;
			try
			{
				if (this.sensorCapability.OTH_SurfaceWave)
				{
					bool? flag;
					bool? flag2;
					if (!LOS_Exists_RadarSW.HasValue)
					{
						flag = new bool?(false);
					}
					else
					{
						flag2 = LOS_Exists_RadarSW;
						flag = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag;
					if (flag2.GetValueOrDefault())
					{
						detectionAttemptResult = Sensor._DetectionAttemptResult.LOS_NotExists;
						result = Sensor._DetectionAttemptResult.LOS_NotExists;
						return result;
					}
				}
				else
				{
					bool? flag2;
					bool? flag3;
					if (!LOS_Exists_Radar.HasValue)
					{
						flag3 = new bool?(false);
					}
					else
					{
						flag2 = LOS_Exists_Radar;
						flag3 = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag3;
					if (flag2.GetValueOrDefault())
					{
						detectionAttemptResult = Sensor._DetectionAttemptResult.LOS_NotExists;
						result = Sensor._DetectionAttemptResult.LOS_NotExists;
						return result;
					}
				}
				if ((!ParentIsShip_ || TargetRange_ <= 5f) && !bool_13 && !this.IsTargetInSensorArc(TargetUnit_, null))
				{
					detectionAttemptResult = Sensor._DetectionAttemptResult.TargetNotInSensorCoverageArc;
				}
				else
				{
					float num = base.GetParentPlatform().RelativeBearingTo(TargetUnit_, false);
					XSection._SignatureType signatureType;
					if (!this.IsIlluminateFrequenciesCover(Sensor.FrequencyBand.ABand) && !this.IsIlluminateFrequenciesCover(Sensor.FrequencyBand.BBand) && !this.IsIlluminateFrequenciesCover(Sensor.FrequencyBand.CBand) && !this.IsIlluminateFrequenciesCover(Sensor.FrequencyBand.DBand))
					{
						signatureType = XSection._SignatureType.Radar_E_M_Band;
					}
					else
					{
						signatureType = XSection._SignatureType.Radar_A_D_Band;
					}
					if (!Information.IsNothing(signatureType))
					{
						XSection crossSection = Sensor.GetCrossSection(TargetUnit_, signatureType);
						if (Information.IsNothing(crossSection))
						{
							detectionAttemptResult = Sensor._DetectionAttemptResult.NoSignature;
						}
						else
						{
							float targetRCS_ = 0f;
							if (num < 315f && num > 45f)
							{
								if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
								{
									targetRCS_ = crossSection.GetSideXSection(TargetUnit_);
								}
								else if (num >= 135f && num <= 225f)
								{
									targetRCS_ = crossSection.GetRearXSection(TargetUnit_);
								}
							}
							else
							{
								targetRCS_ = crossSection.GetFrontXSection(TargetUnit_);
							}
							if (!this.IsTargetDetectedByRadar(ParentPlatform_, TargetUnit_, targetRCS_, TargetRange_, Sensor.Enum80.Illuminate, AffectingJammers, ParentPlatform_.GetWeatherProfile()))
							{
								detectionAttemptResult = Sensor._DetectionAttemptResult.SNRUnderDetectThreshold;
							}
							else if (this.sensorCapability.ABM_SpaceSearch && TargetUnit_.IsWeapon && (((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.RV || ((Weapon)TargetUnit_).GetWeaponType() == Weapon._WeaponType.HGV))
							{
								if (Class363.smethod_1(ParentPlatform_, TargetUnit_) > Math2.GetDistance(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)))
								{
									detectionAttemptResult = Sensor._DetectionAttemptResult.Success;
								}
								else
								{
									detectionAttemptResult = Sensor._DetectionAttemptResult.const_6;
								}
							}
							else if (this.sensorCapability.OTH_SurfaceWave)
							{
								if (!LOS_Exists_RadarSW.HasValue)
								{
									LOS_Exists_RadarSW = new bool?(ParentPlatform_.IsLOS_Exists_Radar(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
								}
								if (LOS_Exists_RadarSW.Value)
								{
									detectionAttemptResult = Sensor._DetectionAttemptResult.Success;
								}
								else
								{
									detectionAttemptResult = Sensor._DetectionAttemptResult.LOS_NotExists;
								}
							}
							else
							{
								if (!LOS_Exists_Radar.HasValue)
								{
									LOS_Exists_Radar = new bool?(ParentPlatform_.IsLOS_Exists_Radar(TargetUnit_, ref ParentPlatform_.m_Scenario, false));
								}
								if (LOS_Exists_Radar.Value)
								{
									detectionAttemptResult = Sensor._DetectionAttemptResult.Success;
								}
								else
								{
									detectionAttemptResult = Sensor._DetectionAttemptResult.LOS_NotExists;
								}
							}
						}
					}
					else
					{
						detectionAttemptResult = Sensor._DetectionAttemptResult.NoSignature;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100736", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				detectionAttemptResult = Sensor._DetectionAttemptResult.Failure;
				ProjectData.ClearProjectError();
			}
			result = detectionAttemptResult;
			return result;
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x0029E55C File Offset: 0x0029C75C
		private Sensor._DetectionAttemptResult VisualWeaponGuidanceAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, bool ParentIsShip_, bool bool_13, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual)
		{
			Sensor._DetectionAttemptResult result = Sensor._DetectionAttemptResult.Failure;
			try
			{
				if (LOS_Exists_Visual.HasValue && LOS_Exists_Visual.Value != Unit._LOS_Exists_Visual.Yes)
				{
					Unit._LOS_Exists_Visual value = LOS_Exists_Visual.Value;
					switch (value)
					{
					case Unit._LOS_Exists_Visual.const_2:
						result = Sensor._DetectionAttemptResult.const_6;
						break;
					case Unit._LOS_Exists_Visual.No:
						result = Sensor._DetectionAttemptResult.LOS_NotExists;
						break;
					case Unit._LOS_Exists_Visual.CannotLookThroughCloud:
						result = Sensor._DetectionAttemptResult.CannotLookThroughCloud;
						break;
					default:
						if (value != Unit._LOS_Exists_Visual.CannotLookThroughWater)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = Sensor._DetectionAttemptResult.NoSignature;
						}
						else
						{
							result = Sensor._DetectionAttemptResult.NoSignature;
						}
						break;
					}
				}
				else if ((!ParentIsShip_ || TargetRange_ <= 5f) && !bool_13 && !this.IsTargetInSensorArc(TargetUnit_, null))
				{
					result = Sensor._DetectionAttemptResult.TargetNotInSensorCoverageArc;
				}
				else
				{
					float num = 0f;
					switch (TargetUnit_.GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						num = (float)((double)this.MaxRange * 0.1);
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						num = (float)((double)this.MaxRange * 0.18);
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						num = (float)((double)this.MaxRange * 0.4);
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						num = (float)((double)this.MaxRange * 0.62);
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						num = (float)((double)this.MaxRange * 0.8);
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						num = this.MaxRange;
						break;
					}
					if (TargetRange_ > num)
					{
						result = Sensor._DetectionAttemptResult.OutOfDetectRange;
					}
					else if (this.sensorCapability.ABM_SpaceSearch && TargetUnit_.IsWeapon && ((Weapon)TargetUnit_).IsRVorHGV())
					{
						float num2 = (float)((int)Math.Round((double)TargetUnit_.GetCurrentAltitude_ASL(false)));
						if (Class363.smethod_3(ParentPlatform_, ref num2) > Math2.GetDistance(ParentPlatform_.GetLatitude(null), ParentPlatform_.GetLongitude(null), TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)))
						{
							result = Sensor._DetectionAttemptResult.Success;
						}
						else
						{
							result = Sensor._DetectionAttemptResult.const_6;
						}
					}
					else
					{
						if (!LOS_Exists_Visual.HasValue)
						{
							LOS_Exists_Visual = new Unit._LOS_Exists_Visual?(ParentPlatform_.IsLOS_Exists_Visual(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
						}
						if (LOS_Exists_Visual.Value == Unit._LOS_Exists_Visual.Yes)
						{
							result = Sensor._DetectionAttemptResult.Success;
						}
						else
						{
							Unit._LOS_Exists_Visual value2 = LOS_Exists_Visual.Value;
							switch (value2)
							{
							case Unit._LOS_Exists_Visual.const_2:
								result = Sensor._DetectionAttemptResult.const_6;
								break;
							case Unit._LOS_Exists_Visual.No:
								result = Sensor._DetectionAttemptResult.LOS_NotExists;
								break;
							case Unit._LOS_Exists_Visual.CannotLookThroughCloud:
								result = Sensor._DetectionAttemptResult.CannotLookThroughCloud;
								break;
							default:
								if (value2 != Unit._LOS_Exists_Visual.CannotLookThroughWater)
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									result = Sensor._DetectionAttemptResult.NoSignature;
								}
								else
								{
									result = Sensor._DetectionAttemptResult.NoSignature;
								}
								break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100737", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor._DetectionAttemptResult.Failure;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x0029E854 File Offset: 0x0029CA54
		private Sensor._DetectionAttemptResult LaserWeaponGuidanceAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual)
		{
			Sensor._DetectionAttemptResult result = Sensor._DetectionAttemptResult.Failure;
			try
			{
				bool? flag;
				if (!LOS_Exists_Visual.HasValue)
				{
					flag = new bool?(false);
				}
				else
				{
					Unit._LOS_Exists_Visual? lOS_Exists_Visual = LOS_Exists_Visual;
					int? num = lOS_Exists_Visual.HasValue ? new int?((int)lOS_Exists_Visual.GetValueOrDefault()) : null;
					flag = (num.HasValue ? new bool?(num.GetValueOrDefault() != 1) : null);
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault())
				{
					Unit._LOS_Exists_Visual value = LOS_Exists_Visual.Value;
					if (value != Unit._LOS_Exists_Visual.No)
					{
						if (value == Unit._LOS_Exists_Visual.CannotLookThroughCloud)
						{
							result = Sensor._DetectionAttemptResult.CannotLookThroughCloud;
						}
						else
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = Sensor._DetectionAttemptResult.NoSignature;
						}
					}
					else
					{
						result = Sensor._DetectionAttemptResult.LOS_NotExists;
					}
				}
				else
				{
					float maxRange = this.MaxRange;
					this.ModifyLaserDetectionRangeByRainAndFUR(ParentPlatform_, TargetUnit_, ref maxRange);
					if (TargetRange_ > maxRange)
					{
						result = Sensor._DetectionAttemptResult.OutOfDetectRange;
					}
					else
					{
						if (!LOS_Exists_Visual.HasValue)
						{
							LOS_Exists_Visual = new Unit._LOS_Exists_Visual?(ParentPlatform_.IsLOS_Exists_Visual(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
						}
						if (LOS_Exists_Visual.Value == Unit._LOS_Exists_Visual.Yes)
						{
							result = Sensor._DetectionAttemptResult.Success;
						}
						else
						{
							Unit._LOS_Exists_Visual value2 = LOS_Exists_Visual.Value;
							switch (value2)
							{
							case Unit._LOS_Exists_Visual.const_2:
								result = Sensor._DetectionAttemptResult.const_6;
								break;
							case Unit._LOS_Exists_Visual.No:
								result = Sensor._DetectionAttemptResult.LOS_NotExists;
								break;
							case Unit._LOS_Exists_Visual.CannotLookThroughCloud:
								result = Sensor._DetectionAttemptResult.CannotLookThroughCloud;
								break;
							default:
								if (value2 != Unit._LOS_Exists_Visual.CannotLookThroughWater)
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									result = Sensor._DetectionAttemptResult.NoSignature;
								}
								else
								{
									result = Sensor._DetectionAttemptResult.NoSignature;
								}
								break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100738", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor._DetectionAttemptResult.NoSignature;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x0029EA34 File Offset: 0x0029CC34
		private Sensor._DetectionAttemptResult InfraredWeaponGuidanceAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual)
		{
			Sensor._DetectionAttemptResult result = Sensor._DetectionAttemptResult.Failure;
			try
			{
				if (LOS_Exists_Visual.HasValue && LOS_Exists_Visual.Value != Unit._LOS_Exists_Visual.Yes)
				{
					Unit._LOS_Exists_Visual value = LOS_Exists_Visual.Value;
					switch (value)
					{
					case Unit._LOS_Exists_Visual.const_2:
						result = Sensor._DetectionAttemptResult.const_6;
						break;
					case Unit._LOS_Exists_Visual.No:
						result = Sensor._DetectionAttemptResult.LOS_NotExists;
						break;
					case Unit._LOS_Exists_Visual.CannotLookThroughCloud:
						result = Sensor._DetectionAttemptResult.CannotLookThroughCloud;
						break;
					default:
						if (value != Unit._LOS_Exists_Visual.CannotLookThroughWater)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = Sensor._DetectionAttemptResult.NoSignature;
						}
						else
						{
							result = Sensor._DetectionAttemptResult.NoSignature;
						}
						break;
					}
				}
				else if (TargetRange_ > this.MaxRange)
				{
					result = Sensor._DetectionAttemptResult.OutOfDetectRange;
				}
				else
				{
					if (!LOS_Exists_Visual.HasValue)
					{
						LOS_Exists_Visual = new Unit._LOS_Exists_Visual?(ParentPlatform_.IsLOS_Exists_Visual(TargetUnit_, ref ParentPlatform_.m_Scenario, true));
					}
					if (LOS_Exists_Visual.Value == Unit._LOS_Exists_Visual.Yes)
					{
						result = Sensor._DetectionAttemptResult.Success;
					}
					else
					{
						Unit._LOS_Exists_Visual value2 = LOS_Exists_Visual.Value;
						switch (value2)
						{
						case Unit._LOS_Exists_Visual.const_2:
							result = Sensor._DetectionAttemptResult.const_6;
							break;
						case Unit._LOS_Exists_Visual.No:
							result = Sensor._DetectionAttemptResult.LOS_NotExists;
							break;
						case Unit._LOS_Exists_Visual.CannotLookThroughCloud:
							result = Sensor._DetectionAttemptResult.CannotLookThroughCloud;
							break;
						default:
							if (value2 != Unit._LOS_Exists_Visual.CannotLookThroughWater)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								result = Sensor._DetectionAttemptResult.NoSignature;
							}
							else
							{
								result = Sensor._DetectionAttemptResult.NoSignature;
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
				ex2.Data.Add("Error at 100739", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor._DetectionAttemptResult.Failure;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x0029EBC0 File Offset: 0x0029CDC0
		public Sensor._DetectionAttemptResult WeaponGuidanceAttempt(ActiveUnit ParentPlatform_, ActiveUnit TargetUnit_, float TargetRange_, List<ActiveUnit> AffectingJammers, bool ParentIsShip_, bool IsShip_, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar)
		{
			Sensor._DetectionAttemptResult detectionAttemptResult = Sensor._DetectionAttemptResult.Failure;
			Sensor._DetectionAttemptResult result;
			try
			{
				if ((!ParentIsShip_ || TargetRange_ <= 5f) && !IsShip_ && !this.IsTargetInSensorArc(TargetUnit_, null))
				{
					detectionAttemptResult = Sensor._DetectionAttemptResult.TargetNotInSensorCoverageArc;
				}
				else if (this.MaxRange < TargetRange_)
				{
					detectionAttemptResult = Sensor._DetectionAttemptResult.OutOfDetectRange;
				}
				else if (!this.IsTargetDetectableByMe(TargetUnit_))
				{
					detectionAttemptResult = Sensor._DetectionAttemptResult.TargetNotDetectable;
				}
				else
				{
					Sensor.SensorType sensorType = this.sensorType;
					Sensor._DetectionAttemptResult detectionAttemptResult2;
					switch (sensorType)
					{
					case Sensor.SensorType.Radar:
						detectionAttemptResult2 = this.RadarWeaponGuidanceAttempt(ParentPlatform_, TargetUnit_, TargetRange_, AffectingJammers, ParentIsShip_, IsShip_, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW);
						goto IL_D5;
					case Sensor.SensorType.SemiActive:
						break;
					case Sensor.SensorType.Visual:
						detectionAttemptResult2 = this.VisualWeaponGuidanceAttempt(ParentPlatform_, TargetUnit_, TargetRange_, ParentIsShip_, IsShip_, ref LOS_Exists_Visual);
						goto IL_D5;
					case Sensor.SensorType.Infrared:
						detectionAttemptResult2 = this.InfraredWeaponGuidanceAttempt(ParentPlatform_, TargetUnit_, TargetRange_, ref LOS_Exists_Visual);
						goto IL_D5;
					default:
						if (sensorType == Sensor.SensorType.LaserDesignator)
						{
							detectionAttemptResult2 = this.LaserWeaponGuidanceAttempt(ParentPlatform_, TargetUnit_, TargetRange_, ref LOS_Exists_Visual);
							goto IL_D5;
						}
						break;
					}
					detectionAttemptResult = Sensor._DetectionAttemptResult.Failure;
					result = Sensor._DetectionAttemptResult.Failure;
					return result;
					IL_D5:
					this.ExportSensorDetectionAttempt(ParentPlatform_, ParentPlatform_.GetSide(false), TargetUnit_, Sensor.DetectionAttemptType.WeaponGuidance, null, new Sensor._DetectionAttemptResult?(detectionAttemptResult2));
					detectionAttemptResult = detectionAttemptResult2;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100740", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				detectionAttemptResult = Sensor._DetectionAttemptResult.Failure;
				ProjectData.ClearProjectError();
			}
			result = detectionAttemptResult;
			return result;
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x0029ED18 File Offset: 0x0029CF18
        //判断目标是否在传感器作用角度范围之内，条件判断
		public bool IsTargetInSensorArc(Unit theTarget, float? CustomParentHeading = null)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(theTarget))
				{
					result = false;
				}
				else
				{
					ActiveUnit parentPlatform = base.GetParentPlatform();
					float azimuth = Math2.GetAzimuth(parentPlatform.GetLatitude(null), parentPlatform.GetLongitude(null), theTarget.GetLatitude(null), theTarget.GetLongitude(null));
					float num;
					if (Information.IsNothing(CustomParentHeading))
					{
						num = parentPlatform.GetCurrentHeading();
					}
					else
					{
						num = CustomParentHeading.Value;
					}
					float num2 = Math2.Normalize(azimuth - num);
					if (num2 <= 22.5f)
					{
						result = this.coverageArcMax.SB1;
					}
					else if (num2 <= 45f)
					{
						result = this.coverageArcMax.SB2;
					}
					else if (num2 <= 67.5f)
					{
						result = this.coverageArcMax.SMF1;
					}
					else if (num2 <= 90f)
					{
						result = this.coverageArcMax.SMF2;
					}
					else if (num2 <= 112.5f)
					{
						result = this.coverageArcMax.SMA1;
					}
					else if (num2 <= 135f)
					{
						result = this.coverageArcMax.SMA2;
					}
					else if (num2 <= 157.5f)
					{
						result = this.coverageArcMax.SS1;
					}
					else if (num2 <= 180f)
					{
						result = this.coverageArcMax.SS2;
					}
					else if (num2 <= 202.5f)
					{
						result = this.coverageArcMax.PS1;
					}
					else if (num2 <= 225f)
					{
						result = this.coverageArcMax.PS2;
					}
					else if (num2 <= 247.5f)
					{
						result = this.coverageArcMax.PMA1;
					}
					else if (num2 <= 270f)
					{
						result = this.coverageArcMax.PMA2;
					}
					else if (num2 <= 292.5f)
					{
						result = this.coverageArcMax.PMF1;
					}
					else if (num2 <= 315f)
					{
						result = this.coverageArcMax.PMF2;
					}
					else if (num2 <= 337.5f)
					{
						result = this.coverageArcMax.PB1;
					}
					else
					{
						result = this.coverageArcMax.PB2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100741", "");
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

		// Token: 0x06005C0B RID: 23563 RVA: 0x0029EFBC File Offset: 0x0029D1BC
        //获取频段
		public HashSet<Sensor.FrequencyBand> GetFrequencyBandHashSet()
		{
			HashSet<Sensor.FrequencyBand> result = null;
			try
			{
				if (Information.IsNothing(this.FrequencyBandHashSet))
				{
					List<Sensor.FrequencyBand> list = new List<Sensor.FrequencyBand>();
					list.AddRange(this.SearchAndTrackFrequencies.Select(Sensor.RadioElectronicFrequencyFunc));
					list.AddRange(this.SensorFrequencyIlluminateArray.Select(Sensor.RadioElectronicFrequencyFunc));
					this.FrequencyBandHashSet = new HashSet<Sensor.FrequencyBand>(list);
				}
				result = this.FrequencyBandHashSet;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x000292C6 File Offset: 0x000274C6
        //干扰通讯装备频率判断
		private bool IsFrequencyAligned(CommDevice commDevice_)
		{
			return this.GetFrequencyBandHashSet().Intersect(commDevice_.FrequencyBandHashSet).Any<Sensor.FrequencyBand>();
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x0029F044 File Offset: 0x0029D244
        //频率判断，为传感器干扰和被动探测服务！
		private bool IsFrequencyAligned(Sensor sensor_)
		{
			int dBID;
			int dBID2;
			if (this.DBID > sensor_.DBID)
			{
				dBID = this.DBID;
				dBID2 = sensor_.DBID;
			}
			else
			{
				dBID2 = this.DBID;
				dBID = sensor_.DBID;
			}
			ConcurrentDictionary<int, bool> concurrentDictionary;
			if (base.GetParentPlatform().m_Scenario.Cache_SensorCompatibleFrequencies.ContainsKey(dBID))
			{
				concurrentDictionary = base.GetParentPlatform().m_Scenario.Cache_SensorCompatibleFrequencies[dBID];
			}
			else
			{
				concurrentDictionary = new ConcurrentDictionary<int, bool>();
				base.GetParentPlatform().m_Scenario.Cache_SensorCompatibleFrequencies.TryAdd(dBID, concurrentDictionary);
			}
			bool result;
			if (!concurrentDictionary.ContainsKey(dBID2))
			{
				bool flag = this.GetFrequencyBandHashSet().Intersect(sensor_.GetFrequencyBandHashSet()).Any<Sensor.FrequencyBand>();
				concurrentDictionary.TryAdd(dBID2, flag);
				result = flag;
			}
			else
			{
				result = concurrentDictionary[dBID2];
			}
			return result;
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x0029F110 File Offset: 0x0029D310
        //ESM  探测算法
		private bool IsTargetEmissionDetected(Sensor sensor_, float distance, Sensor.Enum80 enum79_0, Weather.WeatherProfile Env_)
		{
			bool result = false;
			try
			{
				ECM.Radar radar = new ECM.Radar();
				ECM.Receiver receiver = default(ECM.Receiver);
				radar.AntennaHeight = (float)((int)Math.Round((double)sensor_.GetParentPlatform().GetCurrentAltitude_ASL(false)));
				radar.double_16 = ECM.smethod_6((double)distance, (double)sensor_.GetParentPlatform().GetCurrentAltitude_ASL(false), (double)base.GetParentPlatform().GetCurrentAltitude_ASL(false), ref Env_);
				if (enum79_0 != Sensor.Enum80.const_0)
				{
					if (enum79_0 == Sensor.Enum80.Illuminate)
					{
						radar.SetBeamwidth((double)sensor_.RadarHorizontalBeamwidthIlluminate, (double)sensor_.RadarVerticalBeamwidthIlluminate);
						radar.PeakPower = (double)sensor_.RadarPeakPowerIlluminate;
						radar.SetPulseWidth((double)sensor_.RadarPulseWidthIlluminate);
						radar.SetProcessingGainLoss((double)sensor_.RadarProcessingGainLossIlluminate);
						radar.SetSystemNoiseLevel((double)sensor_.RadarSystemNoiseLevelIlluminate);
						radar.Frequency = (double)(sensor_.GetUpperFreqIlluminate() + sensor_.GetLowerFreqIlluminate()) / 2.0;
						radar.SetPRF((double)sensor_.RadarPRFIlluminate);
					}
				}
				else
				{
					radar.SetBeamwidth((double)sensor_.RadarHorizontalBeamwidth, (double)sensor_.RadarVerticalBeamwidth);
					radar.PeakPower = (double)sensor_.RadarPeakPower;
					radar.SetPulseWidth((double)sensor_.RadarPulseWidth);
					radar.SetProcessingGainLoss((double)sensor_.RadarProcessingGainLoss);
					radar.SetSystemNoiseLevel((double)sensor_.RadarSystemNoiseLevel);
					radar.Frequency = (double)(sensor_.GetUpperFreqSearchAndTrack() + sensor_.GetLowerFreqSearchAndTrack()) / 2.0;
					radar.SetPRF((double)sensor_.RadarPRF);
				}
				if (sensor_.sensorCode.ActiveElectronicallyScannedArray)
				{
					radar.PeakPower *= 0.025;
				}
				receiver.AntennaHeight = (float)((int)Math.Round((double)base.GetParentPlatform().GetCurrentAltitude_ASL(false)));
				receiver.Sensitivity = (double)this.ESMSensitivity;
				receiver.SystemLoss = (double)this.ESMSystemLoss;
				ECM.IEmitter emitter = radar;
				ECM.Receiver receiver2 = receiver;
				double distanceToEmitter = (double)distance;
				double azimouthOffEmitterBoresight = 0.0;
				Weather.WeatherProfile env = Env_;
				ECM.IPropLossMatrix propLossMatrix = null;
                //判断是否探测到电磁信号
				result = ECM.IsEmitterDectect(emitter, receiver2, distanceToEmitter, azimouthOffEmitterBoresight, env, ref propLossMatrix);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100742", "");
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

		// Token: 0x06005C0F RID: 23567 RVA: 0x0029F358 File Offset: 0x0029D558
        //雷达探测算法
		private bool IsTargetDetectedByRadar(Unit SensorPlatform_, Unit TargetActualUnit_, float TargetRCS_, float DistanceToTarget_, Sensor.Enum80 enum79_0, List<ActiveUnit> JammerCarrierList, Weather.WeatherProfile Env_)
		{
			bool result = false;
			try
			{
				ECM.Target target = new ECM.Target();
				this.m_Radar.AntennaHeight = SensorPlatform_.GetAntennaHeight(SensorPlatform_);
				this.m_Radar.double_16 = ECM.smethod_6((double)DistanceToTarget_, (double)base.GetParentPlatform().GetCurrentAltitude_ASL(false), (double)TargetActualUnit_.GetCurrentAltitude_ASL(false), ref Env_);
				if (enum79_0 != Sensor.Enum80.const_0)
				{
					if (enum79_0 == Sensor.Enum80.Illuminate)
					{
						this.m_Radar.SetBeamwidth((double)this.RadarHorizontalBeamwidthIlluminate, (double)this.RadarVerticalBeamwidthIlluminate);
						this.m_Radar.PeakPower = (double)this.RadarPeakPowerIlluminate;
						this.m_Radar.SetPulseWidth((double)this.RadarPulseWidthIlluminate);
						this.m_Radar.SetProcessingGainLoss((double)this.RadarProcessingGainLossIlluminate);
						this.m_Radar.SetSystemNoiseLevel((double)this.RadarSystemNoiseLevelIlluminate);
						this.m_Radar.Frequency = (double)(this.GetUpperFreqIlluminate() + this.GetLowerFreqIlluminate()) * 0.5;
						this.m_Radar.SetPRF((double)this.RadarPRFIlluminate);
					}
				}
				else
				{
					this.m_Radar.SetBeamwidth((double)this.RadarHorizontalBeamwidth, (double)this.RadarVerticalBeamwidth);
					this.m_Radar.PeakPower = (double)this.RadarPeakPower;
					this.m_Radar.SetPulseWidth((double)this.RadarPulseWidth);
					this.m_Radar.SetProcessingGainLoss((double)this.RadarProcessingGainLoss);
					this.m_Radar.SetSystemNoiseLevel((double)this.RadarSystemNoiseLevel);
					this.m_Radar.Frequency = (double)(this.GetUpperFreqSearchAndTrack() + this.GetLowerFreqSearchAndTrack()) * 0.5;
					this.m_Radar.SetPRF((double)this.RadarPRF);
				}
				if (!TargetActualUnit_.IsShip && !TargetActualUnit_.IsFacility && !TargetActualUnit_.IsSubmarine)
				{
					target.fAntennaAltitude_ASL = TargetActualUnit_.GetAntennaAltitude_ASL(TargetActualUnit_);
				}
				else
				{
					target.AntennaAltitude_ASL = (double)TargetActualUnit_.GetAntennaAltitude_ASL(TargetActualUnit_);
					target.enum111_0 = ECM.Enum111.const_3;
					if (this.sensorCode.PeriscopeSearch_BasicCapability)
					{
						this.m_Radar.method_7(ECM.Enum112.E_BasicCapability);
					}
					else if (this.sensorCode.PeriscopeSurfaceSearch_FineRangeResolutionAndRapidScan_1980Plus)
					{
						this.m_Radar.method_7(ECM.Enum112.E_1980Plus);
					}
					else if (this.sensorCode.PeriscopeSurfaceSearch_AdvancedProcessing_2000Plus)
					{
						this.m_Radar.method_7(ECM.Enum112.E_2000Plus);
					}
				}
				target.RCS = (double)TargetRCS_;
				if (Information.IsNothing(JammerCarrierList))
				{
					JammerCarrierList = base.GetParentPlatform().GetSensory().GetAffectingJammers(false);
				}
				List<Sensor> list = new List<Sensor>();
				float azimuth;
				int count;
				checked
				{
					using (List<ActiveUnit>.Enumerator enumerator = JammerCarrierList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Sensor[] allNoneMCMSensors = enumerator.Current.GetAllNoneMCMSensors();
							for (int i = 0; i < allNoneMCMSensors.Length; i++)
							{
								Sensor sensor = allNoneMCMSensors[i];
								if (sensor.IsJammer() && sensor.IsJammerTo(this))
								{
									list.Add(sensor);
								}
							}
						}
					}
					azimuth = Math2.GetAzimuth(base.GetParentPlatform().GetLatitude(null), base.GetParentPlatform().GetLongitude(null), TargetActualUnit_.GetLatitude(null), TargetActualUnit_.GetLongitude(null));
					count = list.Count;
				}
				ECM.Jammer[] array = new ECM.Jammer[count - 1 + 1];
				double[] array2 = new double[count - 1 + 1];
				double[] array3 = new double[count - 1 + 1];
				int num = count - 1;
				for (int j = 0; j <= num; j++)
				{
					Sensor sensor2 = list[j];
					ECM.Jammer jammer = new ECM.Jammer();
					jammer.SetBandwidth((double)sensor2.ECMBandwidth);
					jammer.SetAntennaAltitude((double)sensor2.GetParentPlatform().GetCurrentAltitude_ASL(false));
					jammer.SetFrequency(this.m_Radar.Frequency);
					jammer.SetAntennaGain((double)sensor2.ECMGain);
					jammer.SetPeakPower((double)sensor2.ECMPeakPower);
					if (this.sensorCode.ActiveElectronicallyScannedArray)
					{
						jammer.SetPeakPower(jammer.GetPeakPower() * 0.1);
					}
					else if (this.sensorCode.PassiveElectronicallyScannedArray)
					{
						jammer.SetPeakPower(jammer.GetPeakPower() * 0.5);
					}
					int num2 = this.techGenerationClass - sensor2.techGenerationClass;
					if (num2 < -3)
					{
						jammer.SetPeakPower(jammer.GetPeakPower() * 20.0);
					}
					else if (num2 == -3)
					{
						jammer.SetPeakPower(jammer.GetPeakPower() * 10.0);
					}
					else if (num2 == -2)
					{
						jammer.SetPeakPower(jammer.GetPeakPower() * 5.0);
					}
					else if (num2 == -1)
					{
						jammer.SetPeakPower(jammer.GetPeakPower() * 2.0);
					}
					else if (num2 != 0)
					{
						if (num2 == 1)
						{
							jammer.SetPeakPower(jammer.GetPeakPower() * 0.5);
						}
						else if (num2 == 2)
						{
							jammer.SetPeakPower(jammer.GetPeakPower() * 0.2);
						}
						else if (num2 == 3)
						{
							jammer.SetPeakPower(jammer.GetPeakPower() * 0.1);
						}
						else if (num2 > 3)
						{
							jammer.SetPeakPower(jammer.GetPeakPower() * 0.05);
						}
					}
					array[j] = jammer;
					float slantRange = base.GetParentPlatform().GetSlantRange(sensor2.GetParentPlatform(), 0f);
					array2[j] = (double)slantRange;
					float num3 = Class263.RelativeBearingTo(azimuth, Math2.GetAzimuth(base.GetParentPlatform().GetLatitude(null), base.GetParentPlatform().GetLongitude(null), sensor2.GetParentPlatform().GetLatitude(null), sensor2.GetParentPlatform().GetLongitude(null)));
					array3[j] = (double)num3;
				}
				ECM._TerrainType terrainType = ECM._TerrainType.const_0;
				float num4;
				if (this.m_Radar.double_16 <= 0.0)
				{
					num4 = 0f;
				}
				else if (!TargetActualUnit_.IsShip && !TargetActualUnit_.IsSubmarine && (!TargetActualUnit_.IsAircraft || TargetActualUnit_.IsOnLand()))
				{
					if (Terrain.GetElevation(TargetActualUnit_.GetLatitude(null), TargetActualUnit_.GetLongitude(null), false) <= 0)
					{
						terrainType = ECM._TerrainType.const_8;
					}
					else
					{
						float num5 = Terrain.smethod_5(TargetActualUnit_.GetLatitude(null), TargetActualUnit_.GetLongitude(null), false);
						if (num5 < 0.1f)
						{
							terrainType = ECM._TerrainType.const_8;
						}
						else if (num5 < 0.2f)
						{
							terrainType = ECM._TerrainType.const_4;
						}
						else if (num5 < 0.3f)
						{
							terrainType = ECM._TerrainType.const_3;
						}
						else if (num5 < 0.4f)
						{
							terrainType = ECM._TerrainType.const_2;
						}
						else
						{
							terrainType = ECM._TerrainType.const_1;
						}
					}
					num4 = 0f;
				}
				else
				{
					num4 = 1f - Terrain.smethod_6(TargetActualUnit_.GetLatitude(null), TargetActualUnit_.GetLongitude(null), 2f);
				}
				ECM.Radar radar = this.m_Radar;
				ECM.Target target2 = target;
				int numJammers = count;
				ECM.Jammer[] jammers = array;
				double distanceToTarget = (double)DistanceToTarget_;
				double[] distancesToJammers = array2;
				double[] azimouthsToJammers = array3;
				Weather.WeatherProfile env = Env_;
				float fractionOverWater = num4;
				double chaffDensity = 0.0;
				double chaffCloudThickness = 0.0;
				ECM.Radar radar2 = null;
				result = ECM.IsTargetDetected(radar, target2, numJammers, jammers, distanceToTarget, distancesToJammers, azimouthsToJammers, env, fractionOverWater, chaffDensity, chaffCloudThickness, ref radar2, 0.0, terrainType);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100743", "");
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

		// Token: 0x06005C10 RID: 23568 RVA: 0x0029FB7C File Offset: 0x0029DD7C
        //人为观察传感器模拟
		public static Sensor GetMk1Eyeball(SQLiteConnection sqliteConnection_0)
		{
			Sensor result;
			try
			{
				Sensor sensor = new Sensor(ref sqliteConnection_0, 0, "Mk1 Eyeball", Sensor.SensorType.Visual, Sensor._SensorRole.Radar_AirAndSurfaceSearch_3D_ShortRange, GlobalVariables.TechGenerationClass.NotApplicable, 50f, 0f, 180, 180, 10, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, true, 0, 0, 0, 0, 0f, 0L, 0L, 0L, 0L, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0, 0f, 0f, 0f, 0f, false);
				sensor.b_Eyeball = true;
				sensor.sensorCapability.AirSearch = true;
				sensor.sensorCapability.SurfaceSearch = true;
				sensor.sensorCapability.LandSearch_Mobile = true;
				sensor.sensorCapability.LandSearch_Fixed = true;
				sensor.sensorCapability.PeriscopeSearch = true;
				sensor.sensorCapability.AltitudeInformation = true;
				sensor.sensorCapability.HeadingInformation = true;
				sensor.sensorCapability.RangeInformation = true;
				sensor.sensorCode.ContinousTrackingCapability_Visual = true;
				sensor.sensorCode.IFF = true;
				sensor.sensorCode.Classification_BrilliantWeapon = true;
				sensor.SearchAndTrackFrequencies = new Sensor.RadioElectronicFrequency[1];
				sensor.SearchAndTrackFrequencies[0] = new Sensor.RadioElectronicFrequency(Sensor.FrequencyBand.VisualLight);
				sensor.SetScanInterval(1);
				sensor.AngleResolution = 0f;
				sensor.RangeResolution = 0f;
				sensor.VisualDetectZoom = 1f;
				sensor.VisualClassZoom = 1f;
				result = sensor;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100745", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Sensor();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x0029FD90 File Offset: 0x0029DF90
        //传感器毁伤算法,由平台毁伤估算传感器毁伤
		public override void DamageAssessment(float float_37)
		{
			if (this.sensorType != Sensor.SensorType.Visual && this.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
			{
				float num;
				if (float_37 < 0.1f)
				{
					num = 0.05f;
				}
				else if (float_37 < 0.25f)
				{
					num = 0.15f;
				}
				else if (float_37 < 0.5f)
				{
					num = 0.3f;
				}
				else if (float_37 < 0.75f)
				{
					num = 0.5f;
				}
				else
				{
					num = 0.75f;
				}
				GlobalVariables.TechGenerationClass techGenerationClass = this.techGenerationClass;
				if (techGenerationClass < GlobalVariables.TechGenerationClass.Early1960s)
				{
					num = (float)((double)num - 0.3);
				}
				else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1970s)
				{
					num = (float)((double)num + 0.1);
				}
				else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1980s)
				{
					num = (float)((double)num + 0.3);
				}
				else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1980s)
				{
					num = (float)((double)num + 0.4);
				}
				else
				{
					num = (float)((double)num + 0.5);
				}
				if (!this.IsOperating())
				{
					num /= 3f;
				}
				if ((double)num < 0.05)
				{
					num = 0.05f;
				}
				if ((double)num > 0.95)
				{
					num = 0.95f;
				}
				float num2 = num;
				float num3 = (float)((double)num - 0.1);
				float num4 = (float)((double)num - 0.2);
				float num5 = (float)((double)num - 0.3);
				double num6 = GameGeneral.GetRandom().NextDouble();
				if (num6 < (double)num5)
				{
					this.BeDestroyed(base.GetParentPlatform().GetSide(false), false, base.GetParentPlatform().MountsAreAimpoints());
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "毁伤报告: " + Misc.smethod_11(this.Name) + "已被摧毁!", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
				}
				else if (num6 < (double)num4)
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "毁伤报告: " + Misc.smethod_11(this.Name) + "遭受重度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
				}
				else if (num6 < (double)num3)
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "毁伤报告: " + Misc.smethod_11(this.Name) + "遭受中度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
				}
				else if (num6 < (double)num2)
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "毁伤报告: " + Misc.smethod_11(this.Name) + "遭受轻度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
				}
			}
		}

		// Token: 0x04002F2E RID: 12078
		public static Func<Sensor.RadioElectronicFrequency, Sensor.FrequencyBand> RadioElectronicFrequencyFunc = (Sensor.RadioElectronicFrequency radioElectronicFrequency_0) => radioElectronicFrequency_0.frequencyBand;

		// Token: 0x04002F2F RID: 12079
		public float MaxRange;

		// Token: 0x04002F30 RID: 12080
		public float MinRange;

		// Token: 0x04002F31 RID: 12081
		public Sensor.SensorType sensorType;

		// Token: 0x04002F32 RID: 12082
		public Sensor._SensorRole sensorRole;

		// Token: 0x04002F33 RID: 12083
		public string Description;

		// Token: 0x04002F34 RID: 12084
		public int MaxIntercept;

		// Token: 0x04002F35 RID: 12085
		public float MaxAltitude;

		// Token: 0x04002F36 RID: 12086
		public float MinAltitude;

		// Token: 0x04002F37 RID: 12087
		public float MaxAltitude_ASL;

		// Token: 0x04002F38 RID: 12088
		public float MinAltitude_ASL;

		// Token: 0x04002F39 RID: 12089
		public float RangeResolution;

		// Token: 0x04002F3A RID: 12090
		public float HeightResolution;

		// Token: 0x04002F3B RID: 12091
		public float AngleResolution;

		// Token: 0x04002F3C RID: 12092
		private int ScanInterval;

		// Token: 0x04002F3D RID: 12093
		public int NextScan;

		// Token: 0x04002F3E RID: 12094
		public int OODADetectionCycle;

		// Token: 0x04002F3F RID: 12095
		public Sensor.SensorCapability sensorCapability;

		// Token: 0x04002F40 RID: 12096
		public Sensor.SensorCode sensorCode;

		// Token: 0x04002F41 RID: 12097
		public Sensor.RadioElectronicFrequency[] SearchAndTrackFrequencies;

		// Token: 0x04002F42 RID: 12098
		public Sensor.RadioElectronicFrequency[] SensorFrequencyIlluminateArray;

		// Token: 0x04002F43 RID: 12099
		private List<Contact> TargetsTrackedForFireControl;

		// Token: 0x04002F44 RID: 12100
		public List<Weapon> SemiActiveGuidedWeaponList;

		// Token: 0x04002F45 RID: 12101
		private Collection<string> SemiActiveWeaponsGuided;

		// Token: 0x04002F46 RID: 12102
		private bool bActive;

		// Token: 0x04002F47 RID: 12103
		private bool? bSpoofed;

		// Token: 0x04002F48 RID: 12104
		public PlatformComponent._CoverageArc coverageArcMax;

		// Token: 0x04002F49 RID: 12105
		public GlobalVariables.TechGenerationClass techGenerationClass;

		// Token: 0x04002F4A RID: 12106
		private ECM.Radar m_Radar;

		// Token: 0x04002F4B RID: 12107
		private ECM.Receiver Receiver;

		// Token: 0x04002F4C RID: 12108
		public bool bIsHypothetical;

		// Token: 0x04002F4D RID: 12109
		internal short MasqueradeAs;

		// Token: 0x04002F4E RID: 12110
		private short MaxContactsAir;

		// Token: 0x04002F4F RID: 12111
		private short MaxContactsSurface;

		// Token: 0x04002F50 RID: 12112
		private short MaxContactsSub;

		// Token: 0x04002F51 RID: 12113
		private float Availability;

		// Token: 0x04002F52 RID: 12114
		private long UpperFreq;

		// Token: 0x04002F53 RID: 12115
		private long LowerFreq;

		// Token: 0x04002F54 RID: 12116
		private long UpperFreqIlluminate;

		// Token: 0x04002F55 RID: 12117
		private long LowerFreqIlluminate;

		// Token: 0x04002F56 RID: 12118
		internal float RadarHorizontalBeamwidth;

		// Token: 0x04002F57 RID: 12119
		internal float RadarVerticalBeamwidth;

		// Token: 0x04002F58 RID: 12120
		internal float RadarSystemNoiseLevel;

		// Token: 0x04002F59 RID: 12121
		internal float RadarProcessingGainLoss;

		// Token: 0x04002F5A RID: 12122
		internal float RadarPeakPower;

		// Token: 0x04002F5B RID: 12123
		internal float RadarPulseWidth;

		// Token: 0x04002F5C RID: 12124
		internal float RadarBlindTime;

		// Token: 0x04002F5D RID: 12125
		internal float RadarPRF;

		// Token: 0x04002F5E RID: 12126
		internal float RadarHorizontalBeamwidthIlluminate;

		// Token: 0x04002F5F RID: 12127
		internal float RadarVerticalBeamwidthIlluminate;

		// Token: 0x04002F60 RID: 12128
		internal float RadarSystemNoiseLevelIlluminate;

		// Token: 0x04002F61 RID: 12129
		internal float RadarProcessingGainLossIlluminate;

		// Token: 0x04002F62 RID: 12130
		internal float RadarPeakPowerIlluminate;

		// Token: 0x04002F63 RID: 12131
		internal float RadarPulseWidthIlluminate;

		// Token: 0x04002F64 RID: 12132
		internal float RadarBlindTimeIlluminate;

		// Token: 0x04002F65 RID: 12133
		internal float RadarPRFIlluminate;

		// Token: 0x04002F66 RID: 12134
		internal float ESMSensitivity;

		// Token: 0x04002F67 RID: 12135
		internal float ESMSystemLoss;

		// Token: 0x04002F68 RID: 12136
		internal short ESMNumberOfChannels;

		// Token: 0x04002F69 RID: 12137
		internal float ECMGain;

		// Token: 0x04002F6A RID: 12138
		internal float ECMPeakPower;

		// Token: 0x04002F6B RID: 12139
		internal float ECMBandwidth;

		// Token: 0x04002F6C RID: 12140
		internal float ECMNumberofTargets;

		// Token: 0x04002F6D RID: 12141
		internal float ECMPokReduction;

		// Token: 0x04002F6E RID: 12142
		public bool ESMPreciseEmitterID;

		// Token: 0x04002F6F RID: 12143
		public short MineSweepWidth;

		// Token: 0x04002F70 RID: 12144
		internal short MineMaxSpeed;

		// Token: 0x04002F71 RID: 12145
		internal float VisualDetectZoom;

		// Token: 0x04002F72 RID: 12146
		internal float VisualClassZoom;

		// Token: 0x04002F73 RID: 12147
		internal float IRDetectZoom;

		// Token: 0x04002F74 RID: 12148
		internal float IRClassZoom;

		// Token: 0x04002F75 RID: 12149
		private bool b_Eyeball;

		// Token: 0x04002F76 RID: 12150
		private HashSet<Sensor.FrequencyBand> FrequencyBandHashSet;

		// Token: 0x02000B21 RID: 2849
		public struct SensorCapability
		{
			// Token: 0x04002F78 RID: 12152
			public bool AirSearch;

			// Token: 0x04002F79 RID: 12153
			public bool SurfaceSearch;

			// Token: 0x04002F7A RID: 12154
			public bool SubmarineSearch;

			// Token: 0x04002F7B RID: 12155
			public bool LandSearch_Mobile;

			// Token: 0x04002F7C RID: 12156
			public bool LandSearch_Fixed;

			// Token: 0x04002F7D RID: 12157
			public bool PeriscopeSearch;

			// Token: 0x04002F7E RID: 12158
			public bool ABM_SpaceSearch;

			// Token: 0x04002F7F RID: 12159
			public bool MineObstacleSearch;

			// Token: 0x04002F80 RID: 12160
			public bool RangeInformation;

			// Token: 0x04002F81 RID: 12161
			public bool HeadingInformation;

			// Token: 0x04002F82 RID: 12162
			public bool AltitudeInformation;

			// Token: 0x04002F83 RID: 12163
			public bool SpeedInformation;

			// Token: 0x04002F84 RID: 12164
			public bool Navigation_Only;

			// Token: 0x04002F85 RID: 12165
			public bool Ground_mapping_only;

			// Token: 0x04002F86 RID: 12166
			public bool TerrainAvoidanceOrFollowing;

			// Token: 0x04002F87 RID: 12167
			public bool WeatherOnly;

			// Token: 0x04002F88 RID: 12168
			public bool WeatherAndNavigation;

			// Token: 0x04002F89 RID: 12169
			public bool OTH_Backscatter;

			// Token: 0x04002F8A RID: 12170
			public bool OTH_SurfaceWave;

			// Token: 0x04002F8B RID: 12171
			public bool TorpedoWarning;

			// Token: 0x04002F8C RID: 12172
			public bool MissileApproachWarning;
		}

		// Token: 0x02000B22 RID: 2850
		public struct SensorCode
		{
            // Token: 0x04002F8D RID: 12173
            //Identification Friend or Foe (IFF) [Side Info]
            public bool IFF;

			// Token: 0x04002F8E RID: 12174
			public bool Classification_BrilliantWeapon;

            // Token: 0x04002F8F RID: 12175
            //Non-Coperative Target Recognition (NCTR)  - Jet Engine Modulation [Class Info]
            public bool NCTR_JEM;

            // Token: 0x04002F90 RID: 12176
            //Non-Coperative Target Recognition (NCTR)  - Narrow Beam Interleaved Search and Track [Class Info]
            public bool NCTR_NBILST;

			// Token: 0x04002F91 RID: 12177
			public bool ContinousTrackingCapability_PhasedArrayRadar;

			// Token: 0x04002F92 RID: 12178
			public bool ContinousTrackingCapability_TargetTrackingRadar;

			// Token: 0x04002F93 RID: 12179
			public bool ContinousTrackingCapability_Visual;

			// Token: 0x04002F94 RID: 12180
			public bool TrackWhileScan;

			// Token: 0x04002F95 RID: 12181
			public bool MovingTargetIndicator;

			// Token: 0x04002F96 RID: 12182
			public bool LowProbabilityOfIntercept;

			// Token: 0x04002F97 RID: 12183
			public bool LLTVNVGCCD_NightCapable_Searchlight_VisualNightCapable;

			// Token: 0x04002F98 RID: 12184
			public bool PulseOnlyRadar;

			// Token: 0x04002F99 RID: 12185
			public bool PulseDopplerRadar_LimitedLDSDCapability;

			// Token: 0x04002F9A RID: 12186
			public bool PulseDopplerRadar_FullLDSDCapability;

			// Token: 0x04002F9B RID: 12187
			public bool ContinuousWaveIllumination;

			// Token: 0x04002F9C RID: 12188
			public bool InterruptedContinuousWaveIllumination;

			// Token: 0x04002F9D RID: 12189
			public bool WeaponFCR_NoCWIllumination;

			// Token: 0x04002F9E RID: 12190
			public bool ShallowWaterCapable_Partial;

			// Token: 0x04002F9F RID: 12191
			public bool ShallowWaterCapableFull_ClassificationFlagRequired;

			// Token: 0x04002FA0 RID: 12192
			public bool PassiveElectronicallyScannedArray;

			// Token: 0x04002FA1 RID: 12193
			public bool ActiveElectronicallyScannedArray;

            // Token: 0x04002FA2 RID: 12194
            //Periscope 潜望镜;  
            public bool PeriscopeSearch_BasicCapability;

			// Token: 0x04002FA3 RID: 12195
			public bool PeriscopeSurfaceSearch_FineRangeResolutionAndRapidScan_1980Plus;

			// Token: 0x04002FA4 RID: 12196
			public bool PeriscopeSurfaceSearch_AdvancedProcessing_2000Plus;
		}

		// Token: 0x02000B23 RID: 2851
		public enum FrequencyBand : long
		{
			// Token: 0x04002FA6 RID: 12198
			ABand = 1001L,
			// Token: 0x04002FA7 RID: 12199
			BBand,
			// Token: 0x04002FA8 RID: 12200
			CBand,
			// Token: 0x04002FA9 RID: 12201
			DBand,
			// Token: 0x04002FAA RID: 12202
			EBand,
			// Token: 0x04002FAB RID: 12203
			FBand,
			// Token: 0x04002FAC RID: 12204
			GBand,
			// Token: 0x04002FAD RID: 12205
			HBand,
			// Token: 0x04002FAE RID: 12206
			IBand,
			// Token: 0x04002FAF RID: 12207
			JBand,
			// Token: 0x04002FB0 RID: 12208
			KBand,
			// Token: 0x04002FB1 RID: 12209
			LBand,
			// Token: 0x04002FB2 RID: 12210
			MBand,
			// Token: 0x04002FB3 RID: 12211
			VisualLight = 2001L,
			// Token: 0x04002FB4 RID: 12212
			NearIR,
			// Token: 0x04002FB5 RID: 12213
			FarIR,
			// Token: 0x04002FB6 RID: 12214
			Laser,
			// Token: 0x04002FB7 RID: 12215
			ELFRadio = 3001L,
			// Token: 0x04002FB8 RID: 12216
			SLFRadio,
			// Token: 0x04002FB9 RID: 12217
			ULFRadio,
			// Token: 0x04002FBA RID: 12218
			VLFRadio,
			// Token: 0x04002FBB RID: 12219
			LFRadio,
			// Token: 0x04002FBC RID: 12220
			MFRadio,
			// Token: 0x04002FBD RID: 12221
			HFRadio,
			// Token: 0x04002FBE RID: 12222
			VHFRadio,
			// Token: 0x04002FBF RID: 12223
			UHFRadio,
			// Token: 0x04002FC0 RID: 12224
			SHFRadio,
			// Token: 0x04002FC1 RID: 12225
			EHFRadio,
			// Token: 0x04002FC2 RID: 12226
			LFSonar = 4001L,
			// Token: 0x04002FC3 RID: 12227
			MFSonar,
			// Token: 0x04002FC4 RID: 12228
			HFSonar,
			// Token: 0x04002FC5 RID: 12229
			VLFSonar
		}

		// Token: 0x02000B24 RID: 2852
		public enum SensorType : short
		{
			// Token: 0x04002FC7 RID: 12231
			None = 1001,
			// Token: 0x04002FC8 RID: 12232
			Radar = 2001,
			// Token: 0x04002FC9 RID: 12233
			SemiActive,
			// Token: 0x04002FCA RID: 12234
			Visual,
			// Token: 0x04002FCB RID: 12235
			Infrared,
			// Token: 0x04002FCC RID: 12236
			TVM,
			// Token: 0x04002FCD RID: 12237
			ESM = 3001,
			// Token: 0x04002FCE RID: 12238
			ECM,
			// Token: 0x04002FCF RID: 12239
			LaserDesignator = 4001,
			// Token: 0x04002FD0 RID: 12240
			LaserSpotTracker,
			// Token: 0x04002FD1 RID: 12241
			LaserRangefinder,
			// Token: 0x04002FD2 RID: 12242
			HullSonar_PassiveOnly = 5001,
			// Token: 0x04002FD3 RID: 12243
			HullSonar_ActivePassive,
			// Token: 0x04002FD4 RID: 12244
			HullSonar_ActiveOnly,
			// Token: 0x04002FD5 RID: 12245
			TowedArray_PassiveOnly = 5011,
			// Token: 0x04002FD6 RID: 12246
			TowedArray_ActivePassive,
			// Token: 0x04002FD7 RID: 12247
			TowedArray_ActiveOnly,
            // Token: 0x04002FD8 RID: 12248
            //VDS (Variable Depth Sonar)
            VDS_PassiveOnly = 5021,
			// Token: 0x04002FD9 RID: 12249
			VDS_ActivePassive,
			// Token: 0x04002FDA RID: 12250
			VDS_ActiveOnly,
			// Token: 0x04002FDB RID: 12251
			DippingSonar_PassiveOnly = 5031,
			// Token: 0x04002FDC RID: 12252
			DippingSonar_ActivePassive,
			// Token: 0x04002FDD RID: 12253
			DippingSonar_ActiveOnly,
			// Token: 0x04002FDE RID: 12254
			BottomFixedSonar_PassiveOnly = 5041,
			// Token: 0x04002FDF RID: 12255
			MAD = 5101,
			// Token: 0x04002FE0 RID: 12256
			PingIntercept = 5901,
			// Token: 0x04002FE1 RID: 12257
			MineSweep_MechanicalCableCutter = 6001,
			// Token: 0x04002FE2 RID: 12258
			MineSweep_MagneticInfluence,
			// Token: 0x04002FE3 RID: 12259
			MineSweep_AcousticInfluence,
			// Token: 0x04002FE4 RID: 12260
			MineSweep_MagneticAndAcousticMultiInfluence,
			// Token: 0x04002FE5 RID: 12261
			MineSweep_TwoShipMagneticInfluence = 6011,
			// Token: 0x04002FE6 RID: 12262
			MineNeutralization_MooredMineCableCutter = 6021,
			// Token: 0x04002FE7 RID: 12263
			MineNeutralization_ExplosiveChargeMineDisposal,
			// Token: 0x04002FE8 RID: 12264
			MineNeutralization_DiverdeployedExplosiveCharge = 6031,
			// Token: 0x04002FE9 RID: 12265
			SensorGroup = 9001
		}

		// Token: 0x02000B25 RID: 2853
		public enum _SensorRole : long
		{
			// Token: 0x04002FEB RID: 12267
			None = 1001L,
			// Token: 0x04002FEC RID: 12268
			Radar_AirSearch_2D_LongRange = 2001L,
			// Token: 0x04002FED RID: 12269
			Radar_AirSearch_3D_LongRange,
			// Token: 0x04002FEE RID: 12270
			Radar_AirSearch_2D_MediumRange,
			// Token: 0x04002FEF RID: 12271
			Radar_AirSearch_3D_MediumRange,
			// Token: 0x04002FF0 RID: 12272
			Radar_AirSearch_2D_ShortRange,
			// Token: 0x04002FF1 RID: 12273
			Radar_AirSearch_3D_ShortRange,
			// Token: 0x04002FF2 RID: 12274
			Radar_AirAndSurfaceSearch_2D_LongRange = 2011L,
			// Token: 0x04002FF3 RID: 12275
			Radar_AirAndSurfaceSearch_3D_LongRange,
			// Token: 0x04002FF4 RID: 12276
			Radar_AirAndSurface_Search_2D_MediumRange,
			// Token: 0x04002FF5 RID: 12277
			Radar_AirAndSurfaceSearch_3D_MediumRange,
			// Token: 0x04002FF6 RID: 12278
			Radar_AirAndSurfaceSearch_2D_ShortRange,
			// Token: 0x04002FF7 RID: 12279
			Radar_AirAndSurfaceSearch_3D_ShortRange,
			// Token: 0x04002FF8 RID: 12280
			Radar_HeightFinder_LongRange,
			// Token: 0x04002FF9 RID: 12281
			Radar_HeightFinder_MediumRange,
			// Token: 0x04002FFA RID: 12282
			Radar_HeightFinder_ShortRange,
			// Token: 0x04002FFB RID: 12283
			Radar_SurfaceSearch_LongRange = 2021L,
			// Token: 0x04002FFC RID: 12284
			Radar_SurfaceSearch_MediumRange,
			// Token: 0x04002FFD RID: 12285
			Radar_SurfaceSearch_ShortRange,
			// Token: 0x04002FFE RID: 12286
			Radar_SurfaceSearch_OTH = 2027L,
			// Token: 0x04002FFF RID: 12287
			Radar_SurfaceSearch_Navigation,
			// Token: 0x04003000 RID: 12288
			Radar_Navigation = 2031L,
			// Token: 0x04003001 RID: 12289
			Radar_GroundMapping,
			// Token: 0x04003002 RID: 12290
			Radar_TerrainFollowing,
			// Token: 0x04003003 RID: 12291
			Radar_Weather,
			// Token: 0x04003004 RID: 12292
			Radar_WeatherAndNavigation,
			// Token: 0x04003005 RID: 12293
			Radar_TargetIndicator_2D_SurfaceToAir = 2101L,
			// Token: 0x04003006 RID: 12294
			Radar_TargetIndicator_3D_SurfaceToAir,
			// Token: 0x04003007 RID: 12295
			Radar_TargetIndicator_2D_SurfaceToAirAndSurfaceToSurface,
			// Token: 0x04003008 RID: 12296
			Radar_TargetIndicator_3D_SurfaceToAirAndSurfaceToSurface,
			// Token: 0x04003009 RID: 12297
			Radar_TargetIndicator_SurfaceToSurface,
			// Token: 0x0400300A RID: 12298
			Radar_CounterBattery = 2109L,
			// Token: 0x0400300B RID: 12299
			Radar_FCR_AirToAir_LongRange = 2111L,
			// Token: 0x0400300C RID: 12300
			Radar_FCR_AirToAir_MediumRange,
			// Token: 0x0400300D RID: 12301
			Radar_FCR_AirToAir_ShortRange,
			// Token: 0x0400300E RID: 12302
			Radar_FCR_AirToAirAndAirToSurface_LongRange = 2121L,
			// Token: 0x0400300F RID: 12303
			Radar_FCR_AirToAirAndAirToSurface_MediumRange,
			// Token: 0x04003010 RID: 12304
			Radar_FCR_AirToAirAndAirToSurface_ShortRange,
			// Token: 0x04003011 RID: 12305
			Radar_FCR_AirToSurface_LongRange,
			// Token: 0x04003012 RID: 12306
			Radar_FCR_AirToSurface_MediumRange,
			// Token: 0x04003013 RID: 12307
			Radar_FCR_AirToSurface_ShortRange,
			// Token: 0x04003014 RID: 12308
			Radar_FCR_SurfaceToAir_LongRange = 2131L,
			// Token: 0x04003015 RID: 12309
			Radar_FCR_SurfaceToAir_MediumRange,
			// Token: 0x04003016 RID: 12310
			Radar_FCR_SurfaceToAir_ShortRange,
			// Token: 0x04003017 RID: 12311
			Radar_FCR_SurfaceToAirAndSurfaceToSurface_LongRange = 2141L,
			// Token: 0x04003018 RID: 12312
			Radar_FCR_SurfaceToAirAndSurfaceToSurface_MediumRange,
			// Token: 0x04003019 RID: 12313
			Radar_FCR_SurfaceToAirAndSurfaceToSurface_ShortRange,
			// Token: 0x0400301A RID: 12314
			Radar_FCR_SurfaceToSurface = 2151L,
			// Token: 0x0400301B RID: 12315
			Radar_FCR_SurfaceToSurface_withOTH,
			// Token: 0x0400301C RID: 12316
			Radar_FCR_SurfaceToSurface_withTorpedo = 2161L,
			// Token: 0x0400301D RID: 12317
			Radar_FCR_WeaponDirector = 2191L,
			// Token: 0x0400301E RID: 12318
			Radar_Illuminator_LongRange = 2201L,
			// Token: 0x0400301F RID: 12319
			Radar_Illuminator_MediumRange,
			// Token: 0x04003020 RID: 12320
			Radar_Illuminator_ShortRange,
			// Token: 0x04003021 RID: 12321
			WeaponSeeker_ActiveRadar = 2211L,
			// Token: 0x04003022 RID: 12322
			Radar_RangeOnly = 2301L,
			// Token: 0x04003023 RID: 12323
			Radar_AirTrafficControl = 2311L,
			// Token: 0x04003024 RID: 12324
			Radar_ShipboardAirTrafficControl,
			// Token: 0x04003025 RID: 12325
			Radar_BallisticMissileEarlyWarning = 2401L,
			// Token: 0x04003026 RID: 12326
			Radar_BallisticMissileBattleManagement,
			// Token: 0x04003027 RID: 12327
			Radar_BallisticMissileTracker,
			// Token: 0x04003028 RID: 12328
			Radar_BallisticMissileEngagement,
			// Token: 0x04003029 RID: 12329
			LLTV_MineReconnaissance = 2791L,
			// Token: 0x0400302A RID: 12330
			MAWS_MissileApproachWarningSystem = 2891L,
			// Token: 0x0400302B RID: 12331
			RWR_RadarWarningReceiver = 3001L,
			// Token: 0x0400302C RID: 12332
			LWR_LaserWarningReceiver,
			// Token: 0x0400302D RID: 12333
			ELINT = 3011L,
			// Token: 0x0400302E RID: 12334
			ELINT_with_OTH_Targeting,
			// Token: 0x0400302F RID: 12335
			COMINT = 3021L,
			// Token: 0x04003030 RID: 12336
			SIGINT_ELINTAndCOMINT = 3031L,
			// Token: 0x04003031 RID: 12337
			SIGINT_ELINTAndCOMINT_with_OTH_Targeting,
			// Token: 0x04003032 RID: 12338
			MASINT = 3041L,
			// Token: 0x04003033 RID: 12339
			HF_DF = 3101L,
			// Token: 0x04003034 RID: 12340
			HF_DF_with_OTH_Targeting,
			// Token: 0x04003035 RID: 12341
			EmitterLocator_ForARMMissile = 3201L,
			// Token: 0x04003036 RID: 12342
			EmitterLocatorSystem = 3211L,
			// Token: 0x04003037 RID: 12343
			OffensiveECM = 4001L,
			// Token: 0x04003038 RID: 12344
			DefensiveECM = 4011L,
			// Token: 0x04003039 RID: 12345
			OffensiveAndDefensiveECM = 4021L,
			// Token: 0x0400303A RID: 12346
			Repeater = 4031L,
			// Token: 0x0400303B RID: 12347
			IRCM = 4041L,
			// Token: 0x0400303C RID: 12348
			CommunicationsJammer = 4091L,
			// Token: 0x0400303D RID: 12349
			AcousticJammer = 4901L,
			// Token: 0x0400303E RID: 12350
			AcousticRepeater,
			// Token: 0x0400303F RID: 12351
			HullSonar_PassiveOnly_Search = 5001L,
			// Token: 0x04003040 RID: 12352
			HullSonar_PassiveOnly_SearchAndTrack,
			// Token: 0x04003041 RID: 12353
			HullSonar_PassiveOnly_Ranging_FlankArray_SearchAndTrack,
			// Token: 0x04003042 RID: 12354
			HullSonar_PassiveOnly_TorpedoWarning,
			// Token: 0x04003043 RID: 12355
			TowedArraySonarSystem_PassiveOnly = 5101L,
			// Token: 0x04003044 RID: 12356
			TowedArraySonarSystem_PassiveOnly_FatLine,
			// Token: 0x04003045 RID: 12357
			TowedArraySonarSystem_PassiveOnly_ThinLine,
			// Token: 0x04003046 RID: 12358
			TowedArraySonarSystem_PassiveOnly_AreaSurveillance,
			// Token: 0x04003047 RID: 12359
			TowedArraySonarSystem_Passive_TorpedoWarning = 5111L,
			// Token: 0x04003048 RID: 12360
			TowedArraySonarSystem_ActiveAndPassive = 5131L,
			// Token: 0x04003049 RID: 12361
			TowedArraySonarSystem_ActiveAndPassive_AreaSurveillance,
			// Token: 0x0400304A RID: 12362
			TowedArraySonarSystem_ActiveOnly = 5161L,
			// Token: 0x0400304B RID: 12363
			SurveillanceTowedArraySonarSystem_PassiveOnly = 5191L,
			// Token: 0x0400304C RID: 12364
			SurveillanceTowedArraySonarSystem_ActiveAndPassive,
			// Token: 0x0400304D RID: 12365
			SurveillanceTowedArraySonarSystem_ActiveOnly,
			// Token: 0x0400304E RID: 12366
			VariableDepthSonar_PassiveOnly = 5201L,
			// Token: 0x0400304F RID: 12367
			VariableDepthSonar_ActiveAndPassive = 5231L,
			// Token: 0x04003050 RID: 12368
			VariableDepthSonar_ActiveOnly = 5261L,
			// Token: 0x04003051 RID: 12369
			const_102 = 5012L,
			// Token: 0x04003052 RID: 12370
			const_103 = 5021L,
			// Token: 0x04003053 RID: 12371
			HullSonar_ActiveOnly_MineAvoidance = 5091L,
			// Token: 0x04003054 RID: 12372
			HullSonar_ActiveOnly_MineObstacleAvoidance,
			// Token: 0x04003055 RID: 12373
			HullSonar_ActiveOnly_ShallowWater_MineObstacleAvoidance,
			// Token: 0x04003056 RID: 12374
			HullSonar_ActiveOnly_ShallowWater_HighDefinition_MineObstacleAvoidance,
			// Token: 0x04003057 RID: 12375
			HullSonar_ActiveOnly_UnderIceNavigation_MineObstacleAvoidance
		}

		// Token: 0x02000B26 RID: 2854
		public enum DetectionAttemptType
		{
			// Token: 0x04003059 RID: 12377
			VolumeSearch,
			// Token: 0x0400305A RID: 12378
			SpecificTargetTracking,
			// Token: 0x0400305B RID: 12379
			WeaponGuidance,
			// Token: 0x0400305C RID: 12380
			Recon
		}

		// Token: 0x02000B27 RID: 2855
		public enum _DetectionAttemptResult
		{
			// Token: 0x0400305E RID: 12382
			Failure,
			// Token: 0x0400305F RID: 12383
			Success,
			// Token: 0x04003060 RID: 12384
			OutOfDetectRange,
			// Token: 0x04003061 RID: 12385
			LOS_NotExists,
            // Token: 0x04003062 RID: 12386
            //const_4,
            CannotLookThroughCloud,
            // Token: 0x04003063 RID: 12387
            const_5,
			// Token: 0x04003064 RID: 12388
			const_6,
			// Token: 0x04003065 RID: 12389
			TargetNotInSensorCoverageArc,
			// Token: 0x04003066 RID: 12390
			TargetNotDetectable,
			// Token: 0x04003067 RID: 12391
			const_9,
			// Token: 0x04003068 RID: 12392
			SNRUnderDetectThreshold,
			// Token: 0x04003069 RID: 12393
			NoSignature = 9999
		}

		// Token: 0x02000B28 RID: 2856
		public enum Enum80 : byte
		{
			// Token: 0x0400306B RID: 12395
			const_0,
			// Token: 0x0400306C RID: 12396
			Illuminate
		}

		// Token: 0x02000B29 RID: 2857
		public sealed class RadioElectronicFrequency
		{
			// Token: 0x06005C14 RID: 23572 RVA: 0x00029302 File Offset: 0x00027502
			public RadioElectronicFrequency(Sensor.FrequencyBand frequencyBand_1)
			{
				this.frequencyBand = frequencyBand_1;
			}

			// Token: 0x06005C15 RID: 23573 RVA: 0x002A01FC File Offset: 0x0029E3FC
			public long GetFrequencyBandLow()
			{
				Sensor.FrequencyBand frequencyBand = this.frequencyBand;
				long num = frequencyBand - Sensor.FrequencyBand.ABand;
				long result;
				if (num <= 12L)
				{
					switch ((uint)num)
					{
					case 0u:
						result = 250000000L;
						return result;
					case 1u:
						result = 500000000L;
						return result;
					case 2u:
						result = 1000000000L;
						return result;
					case 3u:
						result = 2000000000L;
						return result;
					case 4u:
						result = 3000000000L;
						return result;
					case 5u:
						result = 4000000000L;
						return result;
					case 6u:
						result = 6000000000L;
						return result;
					case 7u:
						result = 8000000000L;
						return result;
					case 8u:
						result = 10000000000L;
						return result;
					case 9u:
						result = 20000000000L;
						return result;
					case 10u:
						result = 40000000000L;
						return result;
					case 11u:
						result = 60000000000L;
						return result;
					case 12u:
						result = 100000000000L;
						return result;
					}
				}
				result = 0L;
				return result;
			}

			// Token: 0x06005C16 RID: 23574 RVA: 0x002A0320 File Offset: 0x0029E520
			public long GetFrequencyBandHi()
			{
				Sensor.FrequencyBand frequencyBand = this.frequencyBand;
				long num = frequencyBand - Sensor.FrequencyBand.ABand;
				long result;
				if (num <= 12L)
				{
					switch ((uint)num)
					{
					case 0u:
						result = 1000000L;
						return result;
					case 1u:
						result = 250000000L;
						return result;
					case 2u:
						result = 500000000L;
						return result;
					case 3u:
						result = 1000000000L;
						return result;
					case 4u:
						result = 2000000000L;
						return result;
					case 5u:
						result = 3000000000L;
						return result;
					case 6u:
						result = 4000000000L;
						return result;
					case 7u:
						result = 6000000000L;
						return result;
					case 8u:
						result = 8000000000L;
						return result;
					case 9u:
						result = 10000000000L;
						return result;
					case 10u:
						result = 20000000000L;
						return result;
					case 11u:
						result = 40000000000L;
						return result;
					case 12u:
						result = 60000000000L;
						return result;
					}
				}
				result = 0L;
				return result;
			}

			// Token: 0x0400306D RID: 12397
			public Sensor.FrequencyBand frequencyBand;
		}
	}
}
