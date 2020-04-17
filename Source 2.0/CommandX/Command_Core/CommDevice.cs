using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// 通信设备
	public sealed class CommDevice : PlatformComponent
	{
		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("CD");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_1 != null)
				{
					if (hashSet_1.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
						return;
					}
					hashSet_1.Add(base.GetGuid());
				}
				if (this.DBID == 0 && !string.IsNullOrEmpty(this.Name))
				{
					string name = this.Name;
					SQLiteConnection sQLiteConnection = base.GetParentPlatform().m_Scenario.GetSQLiteConnection();
					this.DBID = DBFunctions.GetCommID(name, ref sQLiteConnection);
				}
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "St";
				byte componentStatus = (byte)this.m_ComponentStatus;
				xmlWriter.WriteElementString(localName, componentStatus.ToString());
				xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
				xmlWriter_0.WriteElementString("OC", this.OccupiedChannels.ToString());
				xmlWriter_0.WriteElementString("PS", this.ParentSpecific.ToString());
				if (this.IsJammed)
				{
					xmlWriter_0.WriteElementString("IJ", this.IsJammed.ToString());
				}
				if (base.GetDamageSeverity() != PlatformComponent._DamageSeverityFactor.Light)
				{
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100662", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00028F11 File Offset: 0x00027111
		private CommDevice()
		{
			this.commCapability = default(CommDevice._CommCapability);
			this.ParentSpecific = true;
			this.FrequencyBandHashSet = new HashSet<Sensor.FrequencyBand>();
		}

		// 载入
		public static CommDevice Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ActiveUnit activeUnit_1)
		{
			CommDevice commDevice = null;
			CommDevice result;
			try
			{
				CommDevice commDevice2 = new CommDevice();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						if (Operators.CompareString(xmlNode.Name, "DBID", false) == 0)
						{
							commDevice2.DBID = Conversions.ToInteger(xmlNode.InnerText);
							if (commDevice2.DBID > 0)
							{
								commDevice2 = DBFunctions.LoadCommData(Conversions.ToInteger(xmlNode.InnerText), ref activeUnit_1);
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
				IEnumerator enumerator2 = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
						if (Operators.CompareString(xmlNode2.Name, "ID", false) == 0)
						{
							commDevice2.SetGuid(xmlNode2.InnerText);
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				if (commDevice2.DBID > 0)
				{
					IEnumerator enumerator3 = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
							string name = xmlNode3.Name;
							uint num = Class382.smethod_0(name);
							if (num <= 1258451042u)
							{
								if (num != 6222351u)
								{
									if (num != 1040194900u)
									{
										if (num != 1258451042u)
										{
											continue;
										}
										if (Operators.CompareString(name, "St", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "PS", false) == 0)
										{
											commDevice2.ParentSpecific = Conversions.ToBoolean(xmlNode3.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "Status", false) != 0)
								{
									continue;
								}
								string innerText = xmlNode3.InnerText;
								if (Operators.CompareString(innerText, "Operational", false) != 0)
								{
									if (Operators.CompareString(innerText, "Damaged", false) != 0)
									{
										if (Operators.CompareString(innerText, "Destroyed", false) != 0)
										{
											commDevice2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode3.InnerText);
										}
										else
										{
											commDevice2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										commDevice2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									commDevice2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
								}
							}
							else if (num <= 1692991850u)
							{
								if (num != 1548823463u)
								{
									if (num == 1692991850u && Operators.CompareString(name, "IJ", false) == 0)
									{
										commDevice2.IsJammed = Conversions.ToBoolean(xmlNode3.InnerText);
									}
								}
								else if (Operators.CompareString(name, "DamageSeverity", false) == 0)
								{
									commDevice2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode3.InnerText));
								}
							}
							else
							{
								if (num != 2380580039u)
								{
									if (num != 2905213033u)
									{
										continue;
									}
									if (Operators.CompareString(name, "OccupiedChannels", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "OC", false) != 0)
								{
									continue;
								}
								commDevice2.OccupiedChannels = Conversions.ToInteger(xmlNode3.InnerText);
							}
						}
						goto IL_AAA;
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
				IEnumerator enumerator4 = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
						string name2 = xmlNode4.Name;
						uint num = Class382.smethod_0(name2);
						if (num <= 1548823463u)
						{
							if (num <= 1109584844u)
							{
								if (num != 6222351u)
								{
									if (num != 266367750u)
									{
										if (num != 1109584844u || Operators.CompareString(name2, "Flags", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator5 = xmlNode4.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator5.MoveNext())
											{
												string name3 = ((XmlNode)enumerator5.Current).Name;
												num = Class382.smethod_0(name3);
												if (num <= 1757675636u)
												{
													if (num <= 969230539u)
													{
														if (num != 328253564u)
														{
															if (num != 553795081u)
															{
																if (num == 969230539u && Operators.CompareString(name3, "LF_Radio", false) == 0)
																{
																	commDevice2.commCapability.LFRadio = true;
																}
															}
															else if (Operators.CompareString(name3, "Receive_Only", false) == 0)
															{
																commDevice2.commCapability.Receive_Only = true;
															}
														}
														else if (Operators.CompareString(name3, "LOS_Limited", false) == 0)
														{
															commDevice2.commCapability.LOS_Limited = true;
														}
													}
													else if (num != 987648279u)
													{
														if (num != 1471782266u)
														{
															if (num == 1757675636u && Operators.CompareString(name3, "Broadcast", false) == 0)
															{
																commDevice2.commCapability.Broadcast = true;
															}
														}
														else if (Operators.CompareString(name3, "UHF_Radio", false) == 0)
														{
															commDevice2.commCapability.UHFRadio = true;
														}
													}
													else if (Operators.CompareString(name3, "VLF_Radio", false) == 0)
													{
														commDevice2.commCapability.ULFRadio = true;
													}
												}
												else if (num <= 2421138180u)
												{
													if (num != 1986766942u)
													{
														if (num != 2125292527u)
														{
															if (num == 2421138180u && Operators.CompareString(name3, "SHF_Radio", false) == 0)
															{
																commDevice2.commCapability.SHFRadio = true;
															}
														}
														else if (Operators.CompareString(name3, "HF_Radio", false) == 0)
														{
															commDevice2.commCapability.HFRadio = true;
														}
													}
													else if (Operators.CompareString(name3, "ELF_Radio", false) == 0)
													{
														commDevice2.commCapability.ELFRadio = true;
													}
												}
												else if (num <= 3041136386u)
												{
													if (num != 2717875696u)
													{
														if (num == 3041136386u && Operators.CompareString(name3, "Send_Only", false) == 0)
														{
															commDevice2.commCapability.Send_Only = true;
														}
													}
													else if (Operators.CompareString(name3, "Secure", false) == 0)
													{
														commDevice2.commCapability.Secure = true;
													}
												}
												else if (num != 3061779338u)
												{
													if (num == 3288487379u && Operators.CompareString(name3, "VHF_Radio", false) == 0)
													{
														commDevice2.commCapability.VHFRadio = true;
													}
												}
												else if (Operators.CompareString(name3, "MF_Radio", false) == 0)
												{
													commDevice2.commCapability.MFRadio = true;
												}
											}
											continue;
										}
										finally
										{
											if (enumerator5 is IDisposable)
											{
												(enumerator5 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name2, "Name", false) == 0)
									{
										commDevice2.Name = xmlNode4.InnerText;
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name2, "Status", false) != 0)
								{
									continue;
								}
							}
							else if (num != 1258451042u)
							{
								if (num != 1458105184u)
								{
									if (num == 1548823463u && Operators.CompareString(name2, "DamageSeverity", false) == 0)
									{
										commDevice2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode4.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name2, "ID", false) != 0)
									{
										continue;
									}
									if (dictionary_0 == null)
									{
										commDevice2.SetGuid(xmlNode4.InnerText);
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode4.InnerText))
									{
										commDevice2.SetGuid(xmlNode4.InnerText);
										dictionary_0.Add(commDevice2.GetGuid(), commDevice2);
										continue;
									}
									commDevice = (CommDevice)dictionary_0[xmlNode4.InnerText];
									result = commDevice;
									return result;
								}
							}
							else if (Operators.CompareString(name2, "St", false) != 0)
							{
								continue;
							}
							string innerText2 = xmlNode4.InnerText;
							if (Operators.CompareString(innerText2, "Operational", false) != 0)
							{
								if (Operators.CompareString(innerText2, "Damaged", false) != 0)
								{
									if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
									{
										commDevice2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode4.InnerText);
									}
									else
									{
										commDevice2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
									}
								}
								else
								{
									commDevice2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
								}
							}
							else
							{
								commDevice2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
							}
						}
						else if (num <= 2018130377u)
						{
							if (num != 1676149913u)
							{
								if (num != 1692991850u)
								{
									if (num == 2018130377u && Operators.CompareString(name2, "IsOptional", false) == 0)
									{
										commDevice2.IsOptional = Conversions.ToBoolean(xmlNode4.InnerText);
									}
								}
								else if (Operators.CompareString(name2, "IJ", false) == 0)
								{
									commDevice2.IsJammed = Conversions.ToBoolean(xmlNode4.InnerText);
								}
							}
							else if (Operators.CompareString(name2, "MaxChannels", false) == 0)
							{
								commDevice2.MaxChannels = Conversions.ToInteger(xmlNode4.InnerText);
							}
						}
						else
						{
							if (num <= 2735859570u)
							{
								if (num != 2380580039u)
								{
									if (num == 2735859570u && Operators.CompareString(name2, "Range", false) == 0)
									{
										commDevice2.Range = XmlConvert.ToDouble(xmlNode4.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name2, "OC", false) != 0)
								{
									continue;
								}
							}
							else if (num != 2905213033u)
							{
								if (num != 3512062061u || Operators.CompareString(name2, "Type", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode4.InnerText))
								{
									commDevice2.commLinkType = (CommDevice.CommLinkType)Conversions.ToInteger(xmlNode4.InnerText);
									continue;
								}
								CommDevice.CommLinkType commLinkType = (CommDevice.CommLinkType)Enum.Parse(typeof(CommDevice.CommLinkType), xmlNode4.InnerText, true);
								commDevice2.commLinkType = commLinkType;
								continue;
							}
							else if (Operators.CompareString(name2, "OccupiedChannels", false) != 0)
							{
								continue;
							}
							commDevice2.OccupiedChannels = Conversions.ToInteger(xmlNode4.InnerText);
						}
					}
				}
				finally
				{
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				IL_AAA:
				commDevice = commDevice2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100663", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = commDevice;
			return result;
		}

		// 取占用通道数
		public int GetOccupiedChannels()
		{
			return this.OccupiedChannels;
		}

		// 设置占用通道数
		public void SetOccupiedChannels(int int_2)
		{
			this.OccupiedChannels = int_2;
		}

		// 声纳浮标
		public bool IsSonobuoyLink()
		{
			bool result;
			switch (this.commLinkType)
			{
			case CommDevice.CommLinkType.NATO_SonobuoyLink:
			case CommDevice.CommLinkType.RGB_SonobuoyLink:
			case CommDevice.CommLinkType.BM_SonobuoyLink:
			case CommDevice.CommLinkType.Generic_SonobuoyLink:
			case CommDevice.CommLinkType.Type75_SonobuoyLink:
				result = true;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// 构造函数
		public CommDevice(ActiveUnit theParent, Scenario theScen, int DeviceDBID, string theName, CommDevice.CommLinkType theType, double theRange, int theMaxChannels, bool DeviceIsOptional = false) : base(theParent)
		{
			this.commCapability = default(CommDevice._CommCapability);
			this.ParentSpecific = true;
			this.FrequencyBandHashSet = new HashSet<Sensor.FrequencyBand>();
			this.DBID = DeviceDBID;
			this.Name = theName;
			this.commLinkType = theType;
			this.Range = theRange;
			this.MaxChannels = theMaxChannels;
			this.IsOptional = DeviceIsOptional;
			CommDevice commDevice = this;
			DBFunctions.LoadCommCapabilitiesData(ref commDevice, theScen.GetSQLiteConnection());
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x00288DB4 File Offset: 0x00286FB4
		public bool method_29()
		{
			int num = (int)this.commLinkType;
			return num == 16 || num == 4011 || num == 5006 || num == 8002 || num == 9001 || num == 9002 || num > 10000;
		}

		// 是否卫星通信
		public bool IsSATCOM()
		{
			return this.commLinkType == CommDevice.CommLinkType.Big_Ball_SATCOM || this.commLinkType == CommDevice.CommLinkType.Commercial_SATCOM || this.commLinkType == CommDevice.CommLinkType.DSCS_SATCOM || this.commLinkType == CommDevice.CommLinkType.USN_FLTSATCOM || this.commLinkType == CommDevice.CommLinkType.MILSTAR_SATCOM || this.commLinkType == CommDevice.CommLinkType.Punch_Bowl_SATCOM || this.commLinkType == CommDevice.CommLinkType.Skynet_SATCOM || this.commLinkType == CommDevice.CommLinkType.SSIXS_SATCOM || this.commLinkType == CommDevice.CommLinkType.Syracuse_SATCOM;
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00288E94 File Offset: 0x00287094
		public override void DamageAssessment(float float_0)
		{
			if (this.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
			{
				float num;
				if (float_0 < 0.1f)
				{
					num = 0.05f;
				}
				else if (float_0 < 0.25f)
				{
					num = 0.15f;
				}
				else if (float_0 < 0.5f)
				{
					num = 0.3f;
				}
				else if (float_0 < 0.75f)
				{
					num = 0.5f;
				}
				else
				{
					num = 0.75f;
				}
				if (this.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
				{
					num /= 2f;
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
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
				}
				else if (num6 < (double)num4)
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "遭受重度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
				}
				else if (num6 < (double)num3)
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "遭受中度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
				}
				else if (num6 < (double)num2)
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "遭受轻度毁伤.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
				}
			}
		}

		// Token: 0x04002DD4 RID: 11732
		public CommDevice.CommLinkType commLinkType;

		// Token: 0x04002DD5 RID: 11733
		public double Range;

		// Token: 0x04002DD6 RID: 11734
		public int MaxChannels;

		// Token: 0x04002DD7 RID: 11735
		public CommDevice._CommCapability commCapability;

		// Token: 0x04002DD8 RID: 11736
		private int OccupiedChannels;

		// Token: 0x04002DD9 RID: 11737
		public bool IsOptional;

		// Token: 0x04002DDA RID: 11738
		public bool ParentSpecific;

		// Token: 0x04002DDB RID: 11739
		public bool Hypothetical;

		// Token: 0x04002DDC RID: 11740
		public HashSet<Sensor.FrequencyBand> FrequencyBandHashSet;

		// Token: 0x04002DDD RID: 11741
		public bool IsJammed;

		// 通信链路类型
		public enum CommLinkType
		{
			// Token: 0x04002DDF RID: 11743
			NONE = 1001,
			// Token: 0x04002DE0 RID: 11744
			Commercial_SATCOM = 2001,
			// Token: 0x04002DE1 RID: 11745
			USN_FLTSATCOM,
			// Token: 0x04002DE2 RID: 11746
			MILSTAR_SATCOM,
			// Token: 0x04002DE3 RID: 11747
			DSCS_SATCOM,
			// Token: 0x04002DE4 RID: 11748
			Skynet_SATCOM,
			// Token: 0x04002DE5 RID: 11749
			Big_Ball_SATCOM,
			// Token: 0x04002DE6 RID: 11750
			SSIXS_SATCOM,
			// Token: 0x04002DE7 RID: 11751
			Syracuse_SATCOM,
			// Token: 0x04002DE8 RID: 11752
			Punch_Bowl_SATCOM,
			// Token: 0x04002DE9 RID: 11753
			Visual_Comm = 3001,
			// Token: 0x04002DEA RID: 11754
			Laser_Comm,
			// Token: 0x04002DEB RID: 11755
			Land_Line,
			// Token: 0x04002DEC RID: 11756
			Link4 = 4001,
			// Token: 0x04002DED RID: 11757
			Link10,
			// Token: 0x04002DEE RID: 11758
			Link11,
			// Token: 0x04002DEF RID: 11759
			Link16,
			// Token: 0x04002DF0 RID: 11760
			Link14,
			// Token: 0x04002DF1 RID: 11761
			LinkW = 4008,
			// Token: 0x04002DF2 RID: 11762
			LinkY,
			// Token: 0x04002DF3 RID: 11763
			LinkZ,
			// Token: 0x04002DF4 RID: 11764
			AKT22_Datalink = 5001,
			// Token: 0x04002DF5 RID: 11765
			PEAB_TDMA_Datalink,
			// Token: 0x04002DF6 RID: 11766
			TERMA_Datalink,
			// Token: 0x04002DF7 RID: 11767
			LAMPS_Datalink,
			// Token: 0x04002DF8 RID: 11768
			APD15_Datalink,
			// Token: 0x04002DF9 RID: 11769
			A346Z_Datalink,
			// Token: 0x04002DFA RID: 11770
			ELF_Link = 6001,
			// Token: 0x04002DFB RID: 11771
			Radio = 7001,
			// Token: 0x04002DFC RID: 11772
			HaveQuick_Radio,
			// Token: 0x04002DFD RID: 11773
			OneWay_WireGuidance = 8001,
			// Token: 0x04002DFE RID: 11774
			TwoWay_WireGuidance,
			// Token: 0x04002DFF RID: 11775
			NATO_SonobuoyLink = 9001,
			// Token: 0x04002E00 RID: 11776
			RGB_SonobuoyLink,
			// Token: 0x04002E01 RID: 11777
			BM_SonobuoyLink,
			// Token: 0x04002E02 RID: 11778
			Generic_SonobuoyLink,
			// Token: 0x04002E03 RID: 11779
			Type75_SonobuoyLink,
			// Token: 0x04002E04 RID: 11780
			AEGIS_WeaponLink = 10001,
			// Token: 0x04002E05 RID: 11781
			AWG9_WeaponLink,
			// Token: 0x04002E06 RID: 11782
			NTU_WeaponLink,
			// Token: 0x04002E07 RID: 11783
			NASAMS_WeaponLink,
			// Token: 0x04002E08 RID: 11784
			AGM142_WeaponLink,
			// Token: 0x04002E09 RID: 11785
			Patriot_WeaponLink,
			// Token: 0x04002E0A RID: 11786
			AGM154_WeaponLink,
			// Token: 0x04002E0B RID: 11787
			Rapier_WeaponLink,
			// Token: 0x04002E0C RID: 11788
			AIM120_WeaponLink,
			// Token: 0x04002E0D RID: 11789
			Roland_WeaponLink,
			// Token: 0x04002E0E RID: 11790
			AAW9_13_WeaponLink,
			// Token: 0x04002E0F RID: 11791
			SA12_WeaponLink,
			// Token: 0x04002E10 RID: 11792
			AJ168_WeaponLink,
			// Token: 0x04002E11 RID: 11793
			SA5_WeaponLink,
			// Token: 0x04002E12 RID: 11794
			AS12_WeaponWire,
			// Token: 0x04002E13 RID: 11795
			SA10_WeaponLink,
			// Token: 0x04002E14 RID: 11796
			AS15TT_WeaponLink,
			// Token: 0x04002E15 RID: 11797
			HUMRAAM_WeaponLink,
			// Token: 0x04002E16 RID: 11798
			AS30_WeaponLink,
			// Token: 0x04002E17 RID: 11799
			HOT_WeaponLink,
			// Token: 0x04002E18 RID: 11800
			APK8_9_WeaponLink,
			// Token: 0x04002E19 RID: 11801
			IKARA_WeaponLink,
			// Token: 0x04002E1A RID: 11802
			AS7_WeaponLink,
			// Token: 0x04002E1B RID: 11803
			MICA_WeaponLink,
			// Token: 0x04002E1C RID: 11804
			Aster_WeaponLink,
			// Token: 0x04002E1D RID: 11805
			Otomat_WeaponLink,
			// Token: 0x04002E1E RID: 11806
			GBU15_WeaponLink,
			// Token: 0x04002E1F RID: 11807
			RBS15_WeaponLink,
			// Token: 0x04002E20 RID: 11808
			ABM_WeaponLink,
			// Token: 0x04002E21 RID: 11809
			ADATS_WeaponLink,
			// Token: 0x04002E22 RID: 11810
			Arrow_WeaponLink,
			// Token: 0x04002E23 RID: 11811
			AT2_3_6_12_16_WeaponLink,
			// Token: 0x04002E24 RID: 11812
			Bamse_WeaponLink,
			// Token: 0x04002E25 RID: 11813
			Barak_WeaponLink,
			// Token: 0x04002E26 RID: 11814
			Blowpipe_WeaponLink,
			// Token: 0x04002E27 RID: 11815
			Bullpup_WeaponLink,
			// Token: 0x04002E28 RID: 11816
			C701_WeaponLink,
			// Token: 0x04002E29 RID: 11817
			CADSN1_WeaponLink,
			// Token: 0x04002E2A RID: 11818
			ASM_SSM_WeaponLink,
			// Token: 0x04002E2B RID: 11819
			Crotale_WeaponLink,
			// Token: 0x04002E2C RID: 11820
			EFOGM_WeaponLink,
			// Token: 0x04002E2D RID: 11821
			Gabriel_WeaponLink,
			// Token: 0x04002E2E RID: 11822
			MarteMk2_WeaponLink,
			// Token: 0x04002E2F RID: 11823
			Javelin_WeaponLink,
			// Token: 0x04002E30 RID: 11824
			SAM1_WeaponLink,
			// Token: 0x04002E31 RID: 11825
			SAM4_WeaponLink,
			// Token: 0x04002E32 RID: 11826
			SeaCat_WeaponLink,
			// Token: 0x04002E33 RID: 11827
			SeaSkua_WeaponLink,
			// Token: 0x04002E34 RID: 11828
			SeaWolf_WeaponLink,
			// Token: 0x04002E35 RID: 11829
			SkyBow_WeaponLink,
			// Token: 0x04002E36 RID: 11830
			Starstreak_WeaponLink,
			// Token: 0x04002E37 RID: 11831
			THAAD_WeaponLink,
			// Token: 0x04002E38 RID: 11832
			TOW_WeaponLink,
			// Token: 0x04002E39 RID: 11833
			AA10_12_WeaponLink,
			// Token: 0x04002E3A RID: 11834
			AA9_13_WeaponLink,
			// Token: 0x04002E3B RID: 11835
			AA5_WeaponLink,
			// Token: 0x04002E3C RID: 11836
			AA7_WeaponLink,
			// Token: 0x04002E3D RID: 11837
			AAM4_WeaponLink,
			// Token: 0x04002E3E RID: 11838
			SkySwordII_WeaponLink,
			// Token: 0x04002E3F RID: 11839
			RBS70_90_WeaponLink,
			// Token: 0x04002E40 RID: 11840
			Derby_WeaponLink
		}

		// Token: 0x02000B0F RID: 2831
		public struct _CommCapability
		{
			// Token: 0x04002E41 RID: 11841
			public bool Broadcast;

			// Token: 0x04002E42 RID: 11842
			public bool Secure;

			// Token: 0x04002E43 RID: 11843
			public bool Receive_Only;

			// Token: 0x04002E44 RID: 11844
			public bool Send_Only;

			// Token: 0x04002E45 RID: 11845
			public bool LOS_Limited;

			// Token: 0x04002E46 RID: 11846
			public bool ELFRadio;

			// Token: 0x04002E47 RID: 11847
			public bool SLFRadio;

			// Token: 0x04002E48 RID: 11848
			public bool ULFRadio;

			// Token: 0x04002E49 RID: 11849
			public bool VLFRadio;

			// Token: 0x04002E4A RID: 11850
			public bool LFRadio;

			// Token: 0x04002E4B RID: 11851
			public bool MFRadio;

			// Token: 0x04002E4C RID: 11852
			public bool HFRadio;

			// Token: 0x04002E4D RID: 11853
			public bool VHFRadio;

			// Token: 0x04002E4E RID: 11854
			public bool UHFRadio;

			// Token: 0x04002E4F RID: 11855
			public bool SHFRadio;

			// Token: 0x04002E50 RID: 11856
			public bool EHFRadio;
		}
	}
}
