using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 挂载方案
	public sealed class Loadout : Subject
	{
		// 保存
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Loadout");
					xmlWriter_0.WriteElementString("ID", base.GetGuid());
					if (hashSet_0.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_0.Add(base.GetGuid());
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("Name", this.Name);
						xmlWriter_0.WriteElementString("ROF", this.ROF.ToString());
						xmlWriter_0.WriteElementString("MC", this.MaxCapacity.ToString());
						xmlWriter_0.WriteElementString("RT", this.ReadyTime.ToString());
						xmlWriter_0.WriteElementString("NOW", this.NOW.ToString());
						xmlWriter_0.WriteStartElement("Weaps");
						WeaponRec[] weaponRecArray = this.WeaponRecArray;
						for (int i = 0; i < weaponRecArray.Length; i++)
						{
							weaponRecArray[i].Save(ref xmlWriter_0, ref hashSet_0, ref scenario_0);
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "Role";
						int num = (int)this.loadoutRole;
						xmlWriter.WriteElementString(localName, num.ToString());
						xmlWriter_0.WriteElementString("PayloadWeight", this.PayloadWeight.ToString());
						xmlWriter_0.WriteElementString("PayloadWeightDroppable", this.PayloadWeightDroppable.ToString());
						xmlWriter_0.WriteElementString("WeightDragModifier", this.WeightDragModifier.ToString());
						xmlWriter_0.WriteElementString("CombatRadius", this.CombatRadius.ToString());
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "TimeOnStation_Minutes";
						num = (int)this.TimeOnStation_Minutes;
						xmlWriter2.WriteElementString(localName2, num.ToString());
						xmlWriter_0.WriteElementString("QuickTurnaround", this.QuickTurnaround.ToString());
						xmlWriter_0.WriteElementString("QT_ReadyTime", this.QT_ReadyTime.ToString());
						xmlWriter_0.WriteElementString("QT_AirborneTime", this.QT_AirborneTime.ToString());
						xmlWriter_0.WriteElementString("QT_MaxSorties", this.QT_MaxSorties.ToString());
						xmlWriter_0.WriteElementString("QT_AdditionalTimePenalty", this.QT_AdditionalTimePenalty.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "QT_TimeofDay";
						num = (int)this.QT_TimeofDay;
						xmlWriter3.WriteElementString(localName3, num.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "WinchesterShotgun";
						num = (int)this.WinchesterShotgunWeaponState;
						xmlWriter4.WriteElementString(localName4, num.ToString());
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101007", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00028BD5 File Offset: 0x00026DD5
		private Loadout()
		{
			this.WeaponRecArray = new WeaponRec[0];
			this.NOW = false;
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x00284688 File Offset: 0x00282888
		public static Loadout Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, ref Aircraft aircraft_0, ref Scenario scenario_0)
		{
			Loadout loadout = null;
			checked
			{
				Loadout result;
				try
				{
					Loadout loadout2 = new Loadout();
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							uint num = Class382.smethod_0(name);
							if (num <= 1903707726u)
							{
								if (num <= 1172297281u)
								{
									if (num <= 266367750u)
									{
										if (num != 135860981u)
										{
											if (num != 166976667u)
											{
												if (num == 266367750u && Operators.CompareString(name, "Name", false) == 0)
												{
													loadout2.Name = xmlNode.InnerText;
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name, "QuickTurnaround_ReadyTime", false) != 0)
											{
												continue;
											}
										}
										else if (Operators.CompareString(name, "QT_ReadyTime", false) != 0)
										{
											continue;
										}
										loadout2.QT_ReadyTime = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									if (num <= 715769686u)
									{
										if (num != 583075911u)
										{
											if (num != 715769686u)
											{
												continue;
											}
											if (Operators.CompareString(name, "QuickTurnaround_MaxSorties", false) != 0)
											{
												continue;
											}
											goto IL_515;
										}
										else
										{
											if (Operators.CompareString(name, "QuickTurnaround_TimeofDay", false) != 0)
											{
												continue;
											}
											goto IL_6A6;
										}
									}
									else if (num != 1071332996u)
									{
										if (num != 1172297281u)
										{
											continue;
										}
										if (Operators.CompareString(name, "MC", false) != 0)
										{
											continue;
										}
										goto IL_75C;
									}
									else if (Operators.CompareString(name, "QuickTurnaround_AdditionalTimePenalty", false) != 0)
									{
										continue;
									}
								}
								else if (num <= 1571885256u)
								{
									if (num <= 1458105184u)
									{
										if (num != 1456985430u)
										{
											if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
											{
												continue;
											}
											if (!dictionary_0.ContainsKey(xmlNode.InnerText))
											{
												loadout2.SetGuid(xmlNode.InnerText);
												dictionary_0.Add(loadout2.GetGuid(), loadout2);
												continue;
											}
											loadout = (Loadout)dictionary_0[xmlNode.InnerText];
											result = loadout;
											return result;
										}
										else
										{
											if (Operators.CompareString(name, "Weapons", false) != 0)
											{
												continue;
											}
											goto IL_619;
										}
									}
									else if (num != 1467171417u)
									{
										if (num == 1571885256u && Operators.CompareString(name, "PayloadWeightDroppable", false) == 0)
										{
											loadout2.PayloadWeightDroppable = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "PayloadWeight", false) == 0)
										{
											loadout2.PayloadWeight = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 1761926707u)
								{
									if (num != 1703851952u)
									{
										if (num != 1761926707u)
										{
											continue;
										}
										if (Operators.CompareString(name, "RT", false) != 0)
										{
											continue;
										}
										goto IL_431;
									}
									else
									{
										if (Operators.CompareString(name, "QuickTurnaround_AirborneTime", false) != 0)
										{
											continue;
										}
										goto IL_3BC;
									}
								}
								else if (num != 1858496319u)
								{
									if (num != 1903707726u || Operators.CompareString(name, "QT_AdditionalTimePenalty", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "CombatRadius", false) == 0)
									{
										loadout2.CombatRadius = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								loadout2.QT_AdditionalTimePenalty = Conversions.ToInteger(xmlNode.InnerText);
								continue;
							}
							if (num <= 2505807413u)
							{
								if (num <= 2232591701u)
								{
									if (num <= 2133995686u)
									{
										if (num != 1978145240u)
										{
											if (num == 2133995686u && Operators.CompareString(name, "QT_AirborneTime", false) == 0)
											{
												goto IL_3BC;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "ROF", false) == 0)
											{
												loadout2.ROF = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 2187602126u)
									{
										if (num == 2232591701u && Operators.CompareString(name, "ReadyTime", false) == 0)
										{
											goto IL_431;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "DBID", false) == 0)
										{
											loadout2.DBID = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2418769465u)
								{
									if (num != 2316227376u)
									{
										if (num != 2418769465u || Operators.CompareString(name, "Role", false) != 0)
										{
											continue;
										}
										if (Versioned.IsNumeric(xmlNode.InnerText))
										{
											loadout2.loadoutRole = (Loadout.LoadoutRole)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										loadout2.loadoutRole = (Loadout.LoadoutRole)Enum.Parse(typeof(Loadout.LoadoutRole), xmlNode.InnerText, true);
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "QT_MaxSorties", false) == 0)
										{
											goto IL_515;
										}
										continue;
									}
								}
								else if (num != 2424405304u)
								{
									if (num == 2505807413u && Operators.CompareString(name, "WinchesterShotgun", false) == 0)
									{
										loadout2.WinchesterShotgunWeaponState = (Doctrine._WeaponState)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "Sensors", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 3100949293u)
							{
								if (num > 2665397489u)
								{
									goto IL_675;
								}
								if (num == 2655529854u)
								{
									if (Operators.CompareString(name, "WeightDragModifier", false) == 0)
									{
										loadout2.WeightDragModifier = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
								else
								{
									if (num == 2665397489u && Operators.CompareString(name, "Weaps", false) == 0)
									{
										goto IL_619;
									}
									continue;
								}
							}
							else if (num <= 3675003861u)
							{
								if (num != 3452475902u)
								{
									if (num == 3675003861u && Operators.CompareString(name, "MaxCapacity", false) == 0)
									{
										goto IL_75C;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "QuickTurnaround", false) == 0)
									{
										loadout2.QuickTurnaround = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3750622950u)
							{
								if (num == 4034711405u && Operators.CompareString(name, "TimeOnStation_Minutes", false) == 0)
								{
									loadout2.TimeOnStation_Minutes = Conversions.ToShort(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "Sens", false) != 0)
							{
								continue;
							}
							if (xmlNode.HasChildNodes)
							{
								WeaponRec[] weaponRecArray = DBFunctions.smethod_47(ref scenario_0, loadout2.DBID, loadout2.NOW).WeaponRecArray;
								for (int i = 0; i < weaponRecArray.Length; i++)
								{
									WeaponRec weaponRec = weaponRecArray[i];
									if (weaponRec.GetWeapon(scenario_0).GetWeaponType() == Weapon._WeaponType.SensorPod)
									{
										loadout2.AddWeaponRec(weaponRec);
									}
								}
								continue;
							}
							continue;
							IL_3BC:
							loadout2.QT_AirborneTime = Conversions.ToInteger(xmlNode.InnerText);
							continue;
							IL_431:
							loadout2.ReadyTime = Conversions.ToInteger(xmlNode.InnerText);
							continue;
							IL_515:
							loadout2.QT_MaxSorties = Conversions.ToInteger(xmlNode.InnerText);
							continue;
							IL_619:
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
									WeaponRec weaponRec_ = WeaponRec.smethod_2(ref xmlNode2, ref dictionary_0, ref scenario_0);
									loadout2.AddWeaponRec(weaponRec_);
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
							IL_675:
							if (num != 2867742231u)
							{
								if (num != 3100949293u || Operators.CompareString(name, "QT_TimeofDay", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "NOW", false) == 0)
								{
									loadout2.NOW = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							IL_6A6:
							if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								loadout2.QT_TimeofDay = (Loadout._LoadoutDayNight)Conversions.ToShort(xmlNode.InnerText);
								continue;
							}
							loadout2.QT_TimeofDay = (Loadout._LoadoutDayNight)Enum.Parse(typeof(Loadout._LoadoutDayNight), xmlNode.InnerText, true);
							continue;
							IL_75C:
							loadout2.MaxCapacity = Conversions.ToInteger(xmlNode.InnerText);
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					if (loadout2.PayloadWeight == 0)
					{
						DBFunctions.smethod_50(ref scenario_0, ref loadout2);
					}
					if (loadout2.WinchesterShotgunWeaponState == Doctrine._WeaponState.LoadoutSetting)
					{
						loadout2.WinchesterShotgunWeaponState = Doctrine._WeaponState.Winchester;
					}
					Loadout loadout3 = DBFunctions.smethod_47(ref scenario_0, loadout2.DBID, false);
					loadout2.Cargo_Type = loadout3.Cargo_Type;
					loadout2.Cargo_Area = loadout3.Cargo_Area;
					loadout2.Cargo_Crew = loadout3.Cargo_Crew;
					loadout2.Cargo_Mass = loadout3.Cargo_Mass;
					loadout2.Cargo_ParadropCapable = loadout3.Cargo_ParadropCapable;
					loadout = loadout2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101008", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					loadout = new Loadout();
					ProjectData.ClearProjectError();
				}
				result = loadout;
				return result;
			}
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x00285048 File Offset: 0x00283248
		public Sensor[] GetPoddedSensors(Scenario scenario_0)
		{
			Sensor[] array = new Sensor[0];
			Sensor[] result;
			try
			{
				int num = this.WeaponRecArray.Length;
				if (num > 0)
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						WeaponRec weaponRec = this.WeaponRecArray[i];
						checked
						{
							if (weaponRec.GetWeapon(scenario_0).GetWeaponType() == Weapon._WeaponType.SensorPod)
							{
								Sensor[] noneMCMSensors = weaponRec.GetWeapon(scenario_0).GetNoneMCMSensors();
								for (int j = 0; j < noneMCMSensors.Length; j++)
								{
									Sensor sensor_ = noneMCMSensors[j];
									ScenarioArrayUtil.AddSensor(ref array, sensor_);
								}
							}
						}
					}
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101009", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00285138 File Offset: 0x00283338
		public bool method_13()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole;
			return loadoutRole - Loadout.LoadoutRole.Intercept_BVR <= 5 || loadoutRole == Loadout.LoadoutRole.AntiSatellite_Intercept;
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00285164 File Offset: 0x00283364
		public bool LoadoutRoleIsASWPatrol()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole;
			return loadoutRole - Loadout.LoadoutRole.ASW_Patrol <= 1;
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00285188 File Offset: 0x00283388
		public bool method_15()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole;
			if (loadoutRole <= Loadout.LoadoutRole.NavalMineLaying)
			{
				if (loadoutRole - Loadout.LoadoutRole.OECM > 2 && loadoutRole != Loadout.LoadoutRole.SearchAndRescue && loadoutRole != Loadout.LoadoutRole.NavalMineLaying)
				{
					goto IL_60;
				}
			}
			else if (loadoutRole - Loadout.LoadoutRole.Forward_Observer > 1 && loadoutRole != Loadout.LoadoutRole.Unarmed_Recon && loadoutRole != Loadout.LoadoutRole.AirRefueling)
			{
				goto IL_60;
			}
			bool result = true;
			return result;
			IL_60:
			result = false;
			return result;
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x002851F8 File Offset: 0x002833F8
		public int method_16()
		{
			int result = 0;
			try
			{
				WeaponRec[] weaponRecArray = this.WeaponRecArray;
				int num = 0;
				for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
				{
					WeaponRec weaponRec = weaponRecArray[i];
					num += (int)Math.Round(Math.Round((double)weaponRec.GetCurrentLoad() / (double)weaponRec.Multiple, 0));
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101010", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x002852A0 File Offset: 0x002834A0
		public LoadoutMissionProfile GetMissionProfile(Scenario Scenario_)
		{
			if (Information.IsNothing(this.MissionProfile))
			{
				int dBID = this.DBID;
				SQLiteConnection sQLiteConnection = Scenario_.GetSQLiteConnection();
				this.MissionProfile = DBFunctions.LoadDefaultMissionProfile(dBID, ref sQLiteConnection, Scenario_);
			}
			return this.MissionProfile;
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x002852E4 File Offset: 0x002834E4
		public Loadout(int int_11, string string_2, int int_12, int int_13, int int_14, int int_15, Loadout.LoadoutRole loadoutRole_1, Loadout._LoadoutDayNight _LoadoutDayNight_2, Loadout._WeatherProfile WeatherProfile_, float float_4, int int_16, short short_1, bool bool_13, bool bool_14, bool bool_15, int int_17, int int_18, int int_19, int int_20, Loadout._LoadoutDayNight _LoadoutDayNight_3, Doctrine._WeaponState _WeaponState_1)
		{
			this.WeaponRecArray = new WeaponRec[0];
			this.NOW = false;
			this.DBID = int_11;
			this.Name = string_2;
			this.ROF = int_12;
			this.MaxCapacity = int_13;
			this.ReadyTime = int_14;
			this.int_3 = int_15;
			this.WeaponRecArray = new WeaponRec[0];
			this.loadoutRole = loadoutRole_1;
			this._LoadoutDayNight_0 = _LoadoutDayNight_2;
			this.WeatherProfile = WeatherProfile_;
			this.WeightDragModifier = float_4;
			this.CombatRadius = int_16;
			this.TimeOnStation_Minutes = short_1;
			this.bool_9 = bool_13;
			this.NOW = bool_14;
			this.QuickTurnaround = bool_15;
			this.QT_ReadyTime = int_17;
			this.QT_MaxSorties = int_18;
			this.QT_AdditionalTimePenalty = int_19;
			this.QT_AirborneTime = int_20;
			this.QT_TimeofDay = _LoadoutDayNight_3;
			this.WinchesterShotgunWeaponState = _WeaponState_1;
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x00028C09 File Offset: 0x00026E09
		public void AddWeaponRec(WeaponRec weaponRec_1)
		{
			ScenarioArrayUtil.AddWeaponRec(ref this.WeaponRecArray, weaponRec_1);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00028C17 File Offset: 0x00026E17
		public void RemoveWeaponRec(WeaponRec weaponRec_1)
		{
			ScenarioArrayUtil.RemoveWeaponRec(ref this.WeaponRecArray, weaponRec_1);
		}

		// Token: 0x04002D0C RID: 11532
		public int DBID;

		// Token: 0x04002D0D RID: 11533
		public int ROF;

		// Token: 0x04002D0E RID: 11534
		public int MaxCapacity;

		// Token: 0x04002D0F RID: 11535
		public int ReadyTime = 0;

		// Token: 0x04002D10 RID: 11536
		public int int_3 = 0;

		// Token: 0x04002D11 RID: 11537
		public WeaponRec[] WeaponRecArray;

		// Token: 0x04002D12 RID: 11538
		public Loadout.LoadoutRole loadoutRole;

		// Token: 0x04002D13 RID: 11539
		public Loadout._LoadoutDayNight _LoadoutDayNight_0;

		// Token: 0x04002D14 RID: 11540
		public Loadout._WeatherProfile WeatherProfile;

		// Token: 0x04002D15 RID: 11541
		public float WeightDragModifier;

		// Token: 0x04002D16 RID: 11542
		public int CombatRadius;

		// Token: 0x04002D17 RID: 11543
		public short TimeOnStation_Minutes;

		// Token: 0x04002D18 RID: 11544
		public int PayloadWeight;

		// Token: 0x04002D19 RID: 11545
		public int PayloadWeightDroppable;

		// Token: 0x04002D1A RID: 11546
		public bool NOW;

		// Token: 0x04002D1B RID: 11547
		private LoadoutMissionProfile MissionProfile;

		// Token: 0x04002D1C RID: 11548
		public bool bool_9;

		// Token: 0x04002D1D RID: 11549
		public bool QuickTurnaround;

		// Token: 0x04002D1E RID: 11550
		public int QT_ReadyTime;

		// Token: 0x04002D1F RID: 11551
		public int QT_MaxSorties;

		// Token: 0x04002D20 RID: 11552
		public int QT_AdditionalTimePenalty;

		// Token: 0x04002D21 RID: 11553
		public int QT_AirborneTime;

		// Token: 0x04002D22 RID: 11554
		public Loadout._LoadoutDayNight QT_TimeofDay;

		// Token: 0x04002D23 RID: 11555
		public Doctrine._WeaponState WinchesterShotgunWeaponState;

		// Token: 0x04002D24 RID: 11556
		public bool Hypothetical;

		// Token: 0x04002D25 RID: 11557
		public float Cargo_Crew;

		// Token: 0x04002D26 RID: 11558
		public float Cargo_Area = 0f;

		// Token: 0x04002D27 RID: 11559
		public _CargoType Cargo_Type;

		// Token: 0x04002D28 RID: 11560
		public float Cargo_Mass;

		// Token: 0x04002D29 RID: 11561
		public bool Cargo_ParadropCapable;

        // Token: 0x02000AFD RID: 2813（此处的注释参见数据库表说明，EnumLoadoutRole挂载方案的作用）
        public enum LoadoutRole
		{
			// Token: 0x04002D2B RID: 11563
			None = 1001,
            // 拦截，超视距
            Intercept_BVR = 2001,
			// Token: 0x04002D2D RID: 11565
			Intercept_WVR,
			// Token: 0x04002D2E RID: 11566
			AirSuperiority_BVR,
			// Token: 0x04002D2F RID: 11567
			AirSuperiority_WVR,
			// Token: 0x04002D30 RID: 11568
			PointDefence_BVR,
			// Token: 0x04002D31 RID: 11569
			PointDefence_WVR,
			// Token: 0x04002D32 RID: 11570
			GunsOnly,
			// Token: 0x04002D33 RID: 11571
			AntiSatellite_Intercept = 2101,
			// Token: 0x04002D34 RID: 11572
			AirborneLaser,
			// Token: 0x04002D35 RID: 11573
			LandNaval_Strike = 3001,
			// Token: 0x04002D36 RID: 11574
			LandNaval_Standoff,
			// Token: 0x04002D37 RID: 11575
			LandNaval_SEAD_ARM,
			// Token: 0x04002D38 RID: 11576
			LandNaval_SEAD_TALD,
			// Token: 0x04002D39 RID: 11577
			LandNaval_DEAD,
			// Token: 0x04002D3A RID: 11578
			LandOnly_Strike = 3101,
			// Token: 0x04002D3B RID: 11579
			LandOnly_Standoff,
			// Token: 0x04002D3C RID: 11580
			LandOnly_SEAD_ARM,
			// Token: 0x04002D3D RID: 11581
			LandOnly_SEAD_TALD,
			// Token: 0x04002D3E RID: 11582
			LandOnly_DEAD,
			// Token: 0x04002D3F RID: 11583
			NavalOnly_Strike = 3201,
			// Token: 0x04002D40 RID: 11584
			NavalOnly_Standoff,
			// Token: 0x04002D41 RID: 11585
			NavalOnly_SEAD_ARM,
			// Token: 0x04002D42 RID: 11586
			NavalOnly_SEAD_TALD,
			// Token: 0x04002D43 RID: 11587
			NavalOnly_DEAD,
			// Token: 0x04002D44 RID: 11588
			BAI_CAS = 3401,
			// Token: 0x04002D45 RID: 11589
			Buddy_Illumination = 3501,
			// Token: 0x04002D46 RID: 11590
			OECM = 4001,
			// Token: 0x04002D47 RID: 11591
			AEW,
			// Token: 0x04002D48 RID: 11592
			CommandPost,
			// Token: 0x04002D49 RID: 11593
			ChaffLaying,
			// 搜救
			SearchAndRescue = 4101,
			// Token: 0x04002D4B RID: 11595
			CombatSearchAndRescue,
			// Token: 0x04002D4C RID: 11596
			MineSweeping = 4201,
			// Token: 0x04002D4D RID: 11597
			MineRecon,
			// Token: 0x04002D4E RID: 11598
			NavalMineLaying = 4301,
			// Token: 0x04002D4F RID: 11599
			ASW_Patrol = 6001,
			// Token: 0x04002D50 RID: 11600
			ASW_Attack,
			// Token: 0x04002D51 RID: 11601
			Forward_Observer = 7001,
			// Token: 0x04002D52 RID: 11602
			Area_Surveillance,
			// Token: 0x04002D53 RID: 11603
			Armed_Recon,
			// Token: 0x04002D54 RID: 11604
			Unarmed_Recon,
			// Token: 0x04002D55 RID: 11605
			Maritime_Surveillance,
			// Token: 0x04002D56 RID: 11606
			Paratroopers = 7101,
			// Token: 0x04002D57 RID: 11607
			Troop_Transport,
			// Token: 0x04002D58 RID: 11608
			Cargo = 7201,
			// Token: 0x04002D59 RID: 11609
			AirRefueling = 8001,
			// Token: 0x04002D5A RID: 11610
			Training = 8101,
			// Token: 0x04002D5B RID: 11611
			TargetTow,
			// Token: 0x04002D5C RID: 11612
			TargetDrone,
			// Token: 0x04002D5D RID: 11613
			Ferry = 9001,
			// Token: 0x04002D5E RID: 11614
			Unavailable,
			// Token: 0x04002D5F RID: 11615
			Reserve,
			// Token: 0x04002D60 RID: 11616
			ArmedFerry
		}

		// Token: 0x02000AFE RID: 2814
		public enum _WeatherProfile : short
		{
			// Token: 0x04002D62 RID: 11618
			None = 1001,
			// Token: 0x04002D63 RID: 11619
			AllWeather = 2001,
			// Token: 0x04002D64 RID: 11620
			LimitedAllWeather,
			// Token: 0x04002D65 RID: 11621
			ClearWeather
		}

		// Token: 0x02000AFF RID: 2815
		public enum _LoadoutDayNight : short
		{
			// Token: 0x04002D67 RID: 11623
			None = 1001,
			// Token: 0x04002D68 RID: 11624
			DayNight = 2001,
			// Token: 0x04002D69 RID: 11625
			NightOnly,
			// Token: 0x04002D6A RID: 11626
			DayOnly
		}
	}
}
