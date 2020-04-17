using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
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
	// Token: 挂架
	public sealed class Mount : PlatformComponent
	{
		// Token: 0x06005B58 RID: 23384 RVA: 0x0028B60C File Offset: 0x0028980C
		[CompilerGenerated]
		public  ObservableCollection<WeaponRec> GetWeaponRecCollection()
		{
			return this.m_WeaponRecCollection;
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x0028B624 File Offset: 0x00289824
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_12(ObservableCollection<WeaponRec> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.WeaponRecCollection_CollectionChanged);
			ObservableCollection<WeaponRec> weaponRecCollection = this.m_WeaponRecCollection;
			if (weaponRecCollection != null)
			{
				weaponRecCollection.CollectionChanged -= value;
			}
			this.m_WeaponRecCollection = observableCollection_1;
			weaponRecCollection = this.m_WeaponRecCollection;
			if (weaponRecCollection != null)
			{
				weaponRecCollection.CollectionChanged += value;
			}
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x0028B670 File Offset: 0x00289870
		[CompilerGenerated]
		public static void smethod_2(Mount.Delegate20 delegate20_1)
		{
			Mount.Delegate20 @delegate = Mount.delegate20_0;
			Mount.Delegate20 delegate2;
			do
			{
				delegate2 = @delegate;
				Mount.Delegate20 value = (Mount.Delegate20)Delegate.Combine(delegate2, delegate20_1);
				@delegate = Interlocked.CompareExchange<Mount.Delegate20>(ref Mount.delegate20_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x0028B6A8 File Offset: 0x002898A8
		[CompilerGenerated]
		public static void smethod_3(Mount.Delegate20 delegate20_1)
		{
			Mount.Delegate20 @delegate = Mount.delegate20_0;
			Mount.Delegate20 delegate2;
			do
			{
				delegate2 = @delegate;
				Mount.Delegate20 value = (Mount.Delegate20)Delegate.Remove(delegate2, delegate20_1);
				@delegate = Interlocked.CompareExchange<Mount.Delegate20>(ref Mount.delegate20_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x0028B6E0 File Offset: 0x002898E0
		public override void ClearGuid()
		{
			checked
			{
				try
				{
					base.ClearGuid();
					using (IEnumerator<WeaponRec> enumerator = this.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.ClearGuid();
						}
					}
					if (!Information.IsNothing(this.m_MagazineForMount))
					{
						this.m_MagazineForMount.ClearGuid();
					}
					Sensor[] sensors = this.m_Sensors;
					for (int i = 0; i < sensors.Length; i++)
					{
						sensors[i].ClearGuid();
					}
					CommDevice[] commDevices = this.m_CommDevices;
					for (int j = 0; j < commDevices.Length; j++)
					{
						commDevices[j].ClearGuid();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100675", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x0028B7E0 File Offset: 0x002899E0
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_2, Scenario scenario_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Mount");
					try
					{
						xmlWriter_0.WriteElementString("ID", base.GetGuid());
						if (!Information.IsNothing(hashSet_2))
						{
							if (hashSet_2.Contains(base.GetGuid()))
							{
								xmlWriter_0.WriteEndElement();
								return;
							}
							hashSet_2.Add(base.GetGuid());
						}
						if (!string.IsNullOrEmpty(this.Name))
						{
							xmlWriter_0.WriteElementString("Name", this.Name);
						}
						if (this.m_ComponentStatus != PlatformComponent._ComponentStatus.Operational)
						{
							XmlWriter xmlWriter = xmlWriter_0;
							string localName = "Status";
							byte b = (byte)this.m_ComponentStatus;
							xmlWriter.WriteElementString(localName, b.ToString());
						}
						if (base.GetDamageSeverity() != PlatformComponent._DamageSeverityFactor.Light)
						{
							xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
						}
						if (this.m_ParentPlatform != null)
						{
							xmlWriter_0.WriteElementString("PP", this.m_ParentPlatform.GetGuid());
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100676-A", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					try
					{
						if (this.GetWeaponRecCollection().Count > 0)
						{
							xmlWriter_0.WriteStartElement("MW");
							using (IEnumerator<WeaponRec> enumerator = this.GetWeaponRecCollection().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.Save(ref xmlWriter_0, ref hashSet_2, ref scenario_0);
								}
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.GetMagazineForMount().GetWeaponRecCollection().Count > 0)
						{
							xmlWriter_0.WriteStartElement("MMW");
							using (IEnumerator<WeaponRec> enumerator2 = this.GetMagazineForMount().GetWeaponRecCollection().GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_2, ref scenario_0);
								}
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.m_Sensors.Length > 0)
						{
							xmlWriter_0.WriteStartElement("Sensors");
							Sensor[] sensors = this.m_Sensors;
							for (int i = 0; i < sensors.Length; i++)
							{
								sensors[i].Save(ref xmlWriter_0, ref hashSet_2, scenario_0);
							}
							xmlWriter_0.WriteEndElement();
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 100676-B", "");
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					try
					{
						if (this.m_CommDevices.Length > 0)
						{
							xmlWriter_0.WriteStartElement("CommDevices");
							CommDevice[] commDevices = this.m_CommDevices;
							for (int j = 0; j < commDevices.Length; j++)
							{
								commDevices[j].Save(ref xmlWriter_0, ref hashSet_2, scenario_0);
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.coverageArc.HasSomeCoverage())
						{
							this.coverageArc.Save(xmlWriter_0, false);
						}
						if (this.TimeToFire != 0f)
						{
							xmlWriter_0.WriteElementString("TTF", XmlConvert.ToString(this.TimeToFire));
						}
						if (this.GetMagazineForMount().GetTimeToFire() != 0f)
						{
							xmlWriter_0.WriteElementString("TTF_MountMagazine", XmlConvert.ToString(this.GetMagazineForMount().GetTimeToFire()));
						}
						xmlWriter_0.WriteElementString("DP", XmlConvert.ToString(this.DamagePoints));
						if (this.ReserveTarget)
						{
							xmlWriter_0.WriteElementString("ReserveTarget", this.ReserveTarget.ToString());
						}
						if (this.ReloadStatus != Mount._ReloadStatus.const_0)
						{
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = "ReloadStatus";
							byte b = (byte)this.ReloadStatus;
							xmlWriter2.WriteElementString(localName2, b.ToString());
						}
						if (this.RPrioritySet.Count > 0)
						{
							string value = "";
							foreach (int current in this.RPrioritySet)
							{
								value = current.ToString() + ",";
							}
							xmlWriter_0.WriteElementString("RPriority", value);
						}
						if (this.GetAimpointOffset_Bearing() != 0)
						{
							xmlWriter_0.WriteElementString("AO_B", XmlConvert.ToString(this.GetAimpointOffset_Bearing()));
						}
						if (this.GetAimpointOffset_Distance() != 0f)
						{
							xmlWriter_0.WriteElementString("AO_D", XmlConvert.ToString(this.GetAimpointOffset_Distance()));
						}
						xmlWriter_0.WriteEndElement();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ex6.Data.Add("Error at 100676-C", "");
						GameGeneral.LogException(ref ex6);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ex8.Data.Add("Error at 100676", "");
					GameGeneral.LogException(ref ex8);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x0028BD98 File Offset: 0x00289F98
		public static Mount Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ActiveUnit activeUnit_1)
		{
			Mount mount = null;
			checked
			{
				Mount result;
				try
				{
					int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
					if (num == 0)
					{
						num = DBFunctions.smethod_103(Misc.smethod_11(Misc.smethod_48(xmlNode_0.ChildNodes, "Name").InnerText), activeUnit_1.m_Scenario.GetSQLiteConnection());
					}
					Mount mount2 = DBFunctions.LoadMountData(num, ref activeUnit_1.m_Scenario, false);
					mount2.SetParentPlatform(activeUnit_1);
					string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
					if (!Information.IsNothing(dictionary_0))
					{
						if (dictionary_0.ContainsKey(innerText))
						{
							mount = (Mount)dictionary_0[innerText];
							result = mount;
							return result;
						}
						mount2.SetGuid(innerText);
						dictionary_0.Add(mount2.GetGuid(), mount2);
					}
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							uint num2 = Class382.smethod_0(name);
							if (num2 > 1626034646u)
							{
								if (num2 > 3161544654u)
								{
									if (num2 <= 3450734260u)
									{
										if (num2 != 3218297559u)
										{
											if (num2 != 3309953595u)
											{
												if (num2 == 3450734260u && Operators.CompareString(name, "ReloadPriority", false) == 0)
												{
													goto IL_384;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Coverage", false) == 0)
												{
													goto IL_78E;
												}
												continue;
											}
										}
										else if (Operators.CompareString(name, "AimpointOffset_Distance", false) != 0)
										{
											continue;
										}
									}
									else if (num2 != 3590359932u)
									{
										if (num2 != 3976247152u)
										{
											if (num2 != 4076912866u || Operators.CompareString(name, "AO_D", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "AO_B", false) == 0)
											{
												goto IL_2C5;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "CommDevices", false) == 0)
										{
											IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
													CommDevice commDevice = CommDevice.Load(ref xmlNode2, ref dictionary_0, activeUnit_1);
													commDevice.SetParentPlatform(activeUnit_1);
													ScenarioArrayUtil.AddCommDevice(ref mount2.m_CommDevices, commDevice);
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
											goto IL_289;
										}
										continue;
									}
									mount2.AimpointOffset_Distance = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								IL_289:
								if (num2 <= 2822034830u)
								{
									if (num2 != 2424405304u)
									{
										if (num2 == 2822034830u && Operators.CompareString(name, "AimpointOffset_Bearing", false) == 0)
										{
											goto IL_2C5;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Sensors", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												Sensor sensor = Sensor.Load((XmlNode)enumerator3.Current, dictionary_0, mount2.GetParentPlatform());
												sensor.SetParentPlatform(activeUnit_1);
												ScenarioArrayUtil.AddSensor(ref mount2.m_Sensors, sensor);
											}
											continue;
										}
										finally
										{
											if (enumerator3 is IDisposable)
											{
												(enumerator3 as IDisposable).Dispose();
											}
										}
									}
								}
								if (num2 == 2835904185u)
								{
									if (Operators.CompareString(name, "RPriority", false) == 0)
									{
										goto IL_384;
									}
									continue;
								}
								else if (num2 != 3112826795u)
								{
									if (num2 == 3161544654u && Operators.CompareString(name, "ReserveTarget", false) == 0)
									{
										mount2.ReserveTarget = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MountWeapons", false) == 0)
									{
										goto IL_674;
									}
									continue;
								}
								IL_2C5:
								mount2.AimpointOffset_Bearing = new int?(XmlConvert.ToInt32(xmlNode.InnerText));
								continue;
								IL_384:
								string[] array = xmlNode.InnerText.Split(new char[]
								{
									','
								});
								for (int i = 0; i < array.Length; i++)
								{
									string text = array[i];
									if (Operators.CompareString(text, "", false) != 0)
									{
										mount2.RPrioritySet.Add(Conversions.ToInteger(text));
									}
								}
								continue;
							}
							if (num2 <= 808157257u)
							{
								if (num2 <= 580728861u)
								{
									if (num2 != 6222351u)
									{
										if (num2 == 580728861u && Operators.CompareString(name, "TTF_MountMagazine", false) == 0)
										{
											mount2.GetMagazineForMount().SetTimeToFire(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Status", false) != 0)
										{
											continue;
										}
										string innerText2 = xmlNode.InnerText;
										if (Operators.CompareString(innerText2, "Operational", false) == 0)
										{
											mount2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
											continue;
										}
										if (Operators.CompareString(innerText2, "Damaged", false) == 0)
										{
											mount2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
											continue;
										}
										if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
										{
											mount2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										mount2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										continue;
									}
								}
								else
								{
									if (num2 != 625939272u)
									{
										if (num2 != 684613497u)
										{
											if (num2 != 808157257u)
											{
												continue;
											}
											if (Operators.CompareString(name, "MountMagazineWeapons", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "DP", false) == 0)
											{
												mount2.DamagePoints = XmlConvert.ToSingle(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (Operators.CompareString(name, "MMW", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator4.MoveNext())
										{
											XmlNode xmlNode3 = (XmlNode)enumerator4.Current;
											WeaponRec item = WeaponRec.smethod_2(ref xmlNode3, ref dictionary_0, ref activeUnit_1.m_Scenario);
											mount2.GetMagazineForMount().GetWeaponRecCollection().Add(item);
										}
										continue;
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
							if (num2 <= 970965853u)
							{
								if (num2 == 963109897u)
								{
									goto IL_6DA;
								}
								if (num2 != 970965853u || Operators.CompareString(name, "MW", false) != 0)
								{
									continue;
								}
							}
							else if (num2 != 1528329603u)
							{
								if (num2 != 1548823463u)
								{
									if (num2 == 1626034646u && Operators.CompareString(name, "ReloadStatus", false) == 0)
									{
										mount2.ReloadStatus = (Mount._ReloadStatus)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DamageSeverity", false) == 0)
									{
										mount2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Cov", false) == 0)
								{
									goto IL_78E;
								}
								continue;
							}
							IL_674:
							IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator5.MoveNext())
								{
									XmlNode xmlNode4 = (XmlNode)enumerator5.Current;
									WeaponRec item2 = WeaponRec.smethod_2(ref xmlNode4, ref dictionary_0, ref activeUnit_1.m_Scenario);
									mount2.GetWeaponRecCollection().Add(item2);
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
							IL_6DA:
							if (Operators.CompareString(name, "TTF", false) == 0)
							{
								mount2.TimeToFire = XmlConvert.ToSingle(xmlNode.InnerText);
								continue;
							}
							continue;
							IL_78E:
							mount2.coverageArc = PlatformComponent._CoverageArc.SetCoverageIlluminate(ref xmlNode);
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					mount = mount2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100677", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					mount = new Mount();
					ProjectData.ClearProjectError();
				}
				result = mount;
				return result;
			}
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x0028C650 File Offset: 0x0028A850
		public Mount() : base(null)
		{
			this.vmethod_12(new ObservableCollection<WeaponRec>());
			this.m_Sensors = new Sensor[0];
			this.m_CommDevices = new CommDevice[0];
			this.RPrioritySet = new HashSet<int>();
			this.MountDirectorSet = new HashSet<int>();
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x0028C6B8 File Offset: 0x0028A8B8
		public int GetAimpointOffset_Bearing()
		{
			int result;
			if (base.GetParentPlatform() == null)
			{
				result = 0;
			}
			else if (!base.GetParentPlatform().MountsAreAimpoints())
			{
				result = 0;
			}
			else
			{
				if (!this.AimpointOffset_Bearing.HasValue)
				{
					this.AimpointOffset_Bearing = new int?(GameGeneral.GetRandom().Next(0, 360));
				}
				result = this.AimpointOffset_Bearing.Value;
			}
			return result;
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x0028C724 File Offset: 0x0028A924
		public float GetAimpointOffset_Distance()
		{
			float result;
			if (base.GetParentPlatform() == null)
			{
				result = 0f;
			}
			else if (!base.GetParentPlatform().MountsAreAimpoints())
			{
				result = 0f;
			}
			else
			{
				if (!this.AimpointOffset_Distance.HasValue)
				{
					if (this.GetWeaponRecCollection().Count > 0)
					{
						this.AimpointOffset_Distance = new float?((float)((double)GameGeneral.GetRandom().Next(75, 101) / 100.0 * (double)((Facility)base.GetParentPlatform()).Radius));
					}
					else
					{
						this.AimpointOffset_Distance = new float?((float)((double)GameGeneral.GetRandom().Next(0, 51) / 100.0 * (double)((Facility)base.GetParentPlatform()).Radius));
					}
				}
				result = this.AimpointOffset_Distance.Value;
			}
			return result;
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x0028C80C File Offset: 0x0028AA0C
		public float GetTimeToFire()
		{
			return this.TimeToFire;
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00028FF9 File Offset: 0x000271F9
		public void SetTimeToFire(float value)
		{
			this.TimeToFire = value;
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x0028C824 File Offset: 0x0028AA24
		public float method_30()
		{
			return this.float_1;
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x00029002 File Offset: 0x00027202
		public void method_31(float float_3)
		{
			this.float_1 = float_3;
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x0028C83C File Offset: 0x0028AA3C
		public Magazine GetMagazineForMount()
		{
			if (Information.IsNothing(this.m_MagazineForMount))
			{
				this.m_MagazineForMount = new Magazine(base.GetParentPlatform(), 0, "Magazine for mount: " + Misc.smethod_11(this.Name), this.ArmorGeneral, this.int_2, this.int_3, false);
			}
			if (Information.IsNothing(this.m_MagazineForMount.GetParentPlatform()))
			{
				this.m_MagazineForMount.SetParentPlatform(base.GetParentPlatform());
			}
			return this.m_MagazineForMount;
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x0028C8C4 File Offset: 0x0028AAC4
		public bool HasDecoy()
		{
			Weapon._WeaponType weaponType = this.GetWeaponRecCollection()[0].GetWeapon(base.GetParentPlatform().m_Scenario).GetWeaponType();
			return weaponType == Weapon._WeaponType.Decoy_Expendable || weaponType == Weapon._WeaponType.Decoy_Towed;
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x0028C908 File Offset: 0x0028AB08
		public bool HasActiveSensor()
		{
			Sensor[] sensors = this.GetSensors();
			checked
			{
				bool result;
				for (int i = 0; i < sensors.Length; i++)
				{
					if (sensors[i].IsEmmitting())
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x0028C940 File Offset: 0x0028AB40
		public int method_35(ref int int_4, ref int int_5)
		{
			int_4 = 0;
			int_5 = 0;
			foreach (WeaponRec current in this.GetWeaponRecCollection())
			{
				if (current.GetCurrentLoad() != 0)
				{
					if (current.Multiple > 1)
					{
						float num = (float)current.GetCurrentLoad() / (float)current.Multiple;
						if (num != (float)((int)Math.Round((double)num)))
						{
							int_5++;
							int_4 += (int)Math.Round(Math.Floor((double)current.GetCurrentLoad() / (double)current.Multiple));
						}
						else
						{
							int_4 += (int)Math.Round((double)num);
						}
					}
					else
					{
						int_4 += current.GetCurrentLoad();
					}
				}
			}
			return int_4 + int_5;
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x0028CA14 File Offset: 0x0028AC14
		public Sensor[] GetSensors()
		{
			return this.m_Sensors;
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x0002900B File Offset: 0x0002720B
		public bool IsEmpty()
		{
			return this.GetWeaponRecCollection().Where(Mount.WeaponRecFunc0).Count<WeaponRec>() == this.GetWeaponRecCollection().Count;
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x0028CA2C File Offset: 0x0028AC2C
		public bool HasGun()
		{
			bool result;
			using (IEnumerator<WeaponRec> enumerator = this.GetWeaponRecCollection().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetWeapon(base.GetParentPlatform().m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun)
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x0002902F File Offset: 0x0002722F
		public void AddSensor(Sensor sensor_1)
		{
			ScenarioArrayUtil.AddSensor(ref this.m_Sensors, sensor_1);
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x0002903D File Offset: 0x0002723D
		public void RemoveSensor(Sensor sensor_1)
		{
			ScenarioArrayUtil.RemoveSensor(ref this.m_Sensors, sensor_1);
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x0028CAA0 File Offset: 0x0028ACA0
		public override void BeDestroyed(Side side_0, bool bool_16, bool bool_17)
		{
			checked
			{
				try
				{
					base.BeDestroyed(side_0, bool_16, bool_17);
					Sensor[] sensors = this.m_Sensors;
					for (int i = 0; i < sensors.Length; i++)
					{
						sensors[i].BeDestroyed(side_0, bool_16, bool_17);
					}
					CommDevice[] commDevices = this.m_CommDevices;
					for (int j = 0; j < commDevices.Length; j++)
					{
						commDevices[j].BeDestroyed(side_0, bool_16, bool_17);
					}
					if (bool_17 && bool_17 && !bool_16)
					{
						side_0.m_AAR.LossesAdd(this, bool_17);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100678", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x0028CB68 File Offset: 0x0028AD68
		public void method_41(Weapon theWeapon_, float range_m, float bearing_, ActiveUnit activeUnit_1, double? theLatitude_Graphics_, double? theLongitude_Graphics_, float? nullable_4)
		{
			try
			{
				Warhead warhead = theWeapon_.m_Warheads[0];
				double num = 0.0;
				double num2 = 0.0;
				if (base.GetParentPlatform().MountsAreAimpoints())
				{
					double lng = 0.0;
					double lat = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), ref lng, ref lat, (double)(this.GetAimpointOffset_Distance() / 1852f), (double)this.GetAimpointOffset_Bearing());
					GeoPointGenerator.GetOtherGeoPoint(lng, lat, ref num, ref num2, (double)(range_m / 1852f), (double)bearing_);
				}
				else
				{
					GeoPointGenerator.GetOtherGeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), ref num, ref num2, (double)(range_m / 1852f), (double)bearing_);
				}
				float num3;
				if ((theWeapon_.IsRVorHGV() || theWeapon_.weaponCode.BallisticMissile) && theWeapon_.GetWeaponNavigator().HasPlottedCourse())
				{
					num3 = Math.Max(theWeapon_.GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetAltitude(), (float)((int)Terrain.GetElevation(theWeapon_.GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetLatitude(), theWeapon_.GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetLongitude(), false) + theWeapon_.method_188(base.GetParentPlatform())));
				}
				else
				{
					num3 = (float)((int)Terrain.GetElevation(num2, num, false) + theWeapon_.method_188(base.GetParentPlatform()));
				}
				if (Information.IsNothing(theLatitude_Graphics_) || Information.IsNothing(theLongitude_Graphics_))
				{
					double value = 0.0;
					double value2 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(num, num2, ref value, ref value2, (double)(range_m / 1852f), (double)bearing_);
					theLatitude_Graphics_ = new double?(value2);
					theLongitude_Graphics_ = new double?(value);
				}
				if (range_m == 0f)
				{
					if (!warhead.method_15() && warhead.warheadType != Warhead.WarheadType.Fragmentation)
					{
						this.method_42(theWeapon_, activeUnit_1, theLatitude_Graphics_, theLongitude_Graphics_, nullable_4);
					}
					else
					{
						new Explosion(ref base.GetParentPlatform().m_Scenario, num, num2, theLongitude_Graphics_.Value, theLatitude_Graphics_.Value, theWeapon_.GetCurrentHeading(), num3, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, this, null, 0, 0, 0, 0f, 0);
					}
				}
				else
				{
					double num4 = Math.Sqrt(Math.Pow((double)Math.Abs(num3 - base.GetParentPlatform().GetCurrentAltitude_ASL(false)), 2.0) + Math.Pow((double)range_m, 2.0));
					if (theWeapon_.m_Warheads.Length > 0 && theWeapon_.m_Warheads[0].method_18(theWeapon_, base.GetParentPlatform()))
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							base.GetParentPlatform().m_Scenario.LogMessage(string.Concat(new string[]
							{
								"Weapon: ",
								theWeapon_.UnitClass,
								" airbursted off ",
								Misc.smethod_11(this.Name),
								" (of ",
								base.GetParentPlatform().Name,
								") by ",
								Conversions.ToString(Math.Max(1, (int)Math.Round(num4 * 3.2808399200439453))),
								"ft"
							}), LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(num, num2));
						}
						else
						{
							base.GetParentPlatform().m_Scenario.LogMessage(string.Concat(new string[]
							{
								"Weapon: ",
								theWeapon_.UnitClass,
								" airbursted off ",
								Misc.smethod_11(this.Name),
								" (of ",
								base.GetParentPlatform().Name,
								") by ",
								Conversions.ToString(Math.Max(1, (int)Math.Round(num4))),
								"m"
							}), LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(num, num2));
						}
					}
					else if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						base.GetParentPlatform().m_Scenario.LogMessage(string.Concat(new string[]
						{
							"Weapon: ",
							theWeapon_.UnitClass,
							" missed ",
							Misc.smethod_11(this.Name),
							" (of ",
							base.GetParentPlatform().Name,
							") by ",
							Conversions.ToString(Math.Max(1, (int)Math.Round(num4 * 3.2808399200439453))),
							"ft"
						}), LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(num, num2));
					}
					else
					{
						base.GetParentPlatform().m_Scenario.LogMessage(string.Concat(new string[]
						{
							"Weapon: ",
							theWeapon_.UnitClass,
							" missed ",
							Misc.smethod_11(this.Name),
							" (of ",
							base.GetParentPlatform().Name,
							") by ",
							Conversions.ToString(Math.Max(1, (int)Math.Round(num4))),
							"m"
						}), LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(num, num2));
					}
					if (warhead.method_13() || warhead.IsIncendiary())
					{
						Warhead.WarheadType warheadType = warhead.warheadType;
						if (warheadType != Warhead.WarheadType.Fragmentation && warheadType != Warhead.WarheadType.ContinuousRod && warheadType != Warhead.WarheadType.DirectionalContinousRod)
						{
							double num5 = (double)Warhead.smethod_4(num4 / 1852.0, (double)this.DamagePoints, warhead.warheadType, (double)warhead.DP, Weapon._DetonationMedium.Air);
							if (num5 > 0.0)
							{
								this.method_47(num5, warhead.warheadType);
							}
						}
						else
						{
							float theCutOffRange_Frag = Explosion.smethod_2((double)theWeapon_.m_Warheads[0].DP, Weapon._DetonationMedium.Air);
							double damageYield = (double)Warhead.smethod_3(num4 / 1852.0, warhead.warheadType, (double)warhead.DP, Weapon._DetonationMedium.Air);
							this.method_44(damageYield, theCutOffRange_Frag, 0);
						}
						new Explosion(ref base.GetParentPlatform().m_Scenario, num, num2, theLongitude_Graphics_.Value, theLatitude_Graphics_.Value, theWeapon_.GetCurrentHeading(), num3, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, this, null, 0, 0, 0, 0f, 0);
					}
				}
				if (this.DamagePoints <= 0f)
				{
					this.DamagePoints = 0f;
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(num, num2));
					}
					this.BeDestroyed(base.GetParentPlatform().GetSide(false), false, base.GetParentPlatform().MountsAreAimpoints());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100679", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x0028D338 File Offset: 0x0028B538
		private void method_42(Weapon weapon_0, ActiveUnit activeUnit_1, double? nullable_2, double? nullable_3, float? nullable_4)
		{
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				float theAltitude;
				if (base.GetParentPlatform().MountsAreAimpoints())
				{
					Math2.GetAnotherGeopoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), ref num, ref num2, this.GetAimpointOffset_Distance() / 1852f, (float)this.GetAimpointOffset_Bearing());
					theAltitude = (float)((int)Terrain.GetElevation(num2, num, false) + weapon_0.method_188(base.GetParentPlatform()));
				}
				else
				{
					num2 = base.GetParentPlatform().GetLatitude(null);
					num = base.GetParentPlatform().GetLongitude(null);
					theAltitude = base.GetParentPlatform().GetCurrentAltitude_ASL(false);
				}
				base.GetParentPlatform().m_Scenario.LogMessage(string.Concat(new string[]
				{
					"武器: ",
					weapon_0.UnitClass,
					"命中",
					Misc.smethod_11(this.Name),
					" (平台: ",
					base.GetParentPlatform().Name,
					")"
				}), LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(num, num2));
				Warhead warhead = weapon_0.m_Warheads[0];
				double val = 0.0;
				double num3;
				if (!warhead.HasNuclearWarhead(weapon_0.m_Scenario) && !warhead.method_18(weapon_0, base.GetParentPlatform()))
				{
					num3 = (double)(weapon_0.GetPenetration(this.ArmorGeneral, base.GetParentPlatform().GetTargetVisualSizeClass()) / 100f);
					val = (double)weapon_0.method_259();
				}
				else
				{
					num3 = 0.0;
				}
				if (Information.IsNothing(nullable_2) || Information.IsNothing(nullable_3))
				{
					nullable_2 = new double?(num2);
					nullable_3 = new double?(num);
				}
				double val2 = 0.0;
				if (num3 > 0.0)
				{
					base.GetParentPlatform().m_Scenario.LogMessage(Conversions.ToString(num3 * 100.0) + "% penetration achieved", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.GetGuid(), null, new GeoPoint(num, num2));
					if (warhead.method_13())
					{
						val2 = Math.Round(num3 * 2.0 * (double)warhead.DP, 2);
					}
					else
					{
						val2 = Math.Round(num3 * (double)warhead.DP, 2);
					}
					if (num3 < 1.0 && warhead.method_13())
					{
						new Explosion(ref base.GetParentPlatform().m_Scenario, num, num2, nullable_3.Value, nullable_2.Value, weapon_0.GetCurrentHeading(), theAltitude, (float)((double)warhead.DP * (1.0 - num3)), warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, this, null, 0, 0, 0, 0f, 0);
					}
					else if (((Facility)base.GetParentPlatform()).ArmorGeneral == GlobalVariables.ArmorRating.None && warhead.method_13())
					{
						new Explosion(ref base.GetParentPlatform().m_Scenario, num, num2, nullable_3.Value, nullable_2.Value, weapon_0.GetCurrentHeading(), theAltitude, (float)((double)warhead.DP * num3 * 0.25), warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, this, null, 0, 0, 0, 0f, 0);
					}
				}
				else if (warhead.method_13() || warhead.IsIncendiary())
				{
					new Explosion(ref base.GetParentPlatform().m_Scenario, num, num2, nullable_3.Value, nullable_2.Value, weapon_0.GetCurrentHeading(), theAltitude, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, this, null, null, null, 0, 0, 0, 0f, 0);
				}
				if (num3 > 0.0)
				{
					base.GetParentPlatform().LogMessage(Misc.smethod_11(this.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(num, num2));
					this.BeDestroyed(base.GetParentPlatform().GetSide(false), false, base.GetParentPlatform().MountsAreAimpoints());
				}
				float num4 = (float)Math.Max(val, val2);
				this.method_43((double)num4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100680", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x0028D820 File Offset: 0x0028BA20
		public void method_43(double double_0)
		{
			foreach (Sensor current in this.GetSensors().Where(Mount.SensorFunc1))
			{
				if (double_0 < 1.0)
				{
					if (current.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Light)
					{
						if (!base.GetParentPlatform().IsWeapon)
						{
							base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(current.Name) + " has been lightly damaged. ", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						}
						current.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
					}
				}
				else if (double_0 < 2.0)
				{
					if (current.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Medium)
					{
						if (!base.GetParentPlatform().IsWeapon)
						{
							base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(current.Name) + " has been moderately damaged. ", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						}
						current.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
					}
				}
				else if (double_0 < 5.0)
				{
					if (current.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Heavy)
					{
						if (!base.GetParentPlatform().IsWeapon)
						{
							base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(current.Name) + " has been heavily damaged. ", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						}
						current.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
					}
				}
				else
				{
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(current.Name) + " has been destroyed. ", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					current.BeDestroyed(base.GetParentPlatform().GetSide(false), false, false);
				}
			}
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x0028DB70 File Offset: 0x0028BD70
		public void method_44(double DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			try
			{
				if (DamageYield != 0.0)
				{
					this.method_43(DamageYield);
					if (this.ArmorGeneral <= GlobalVariables.ArmorRating.None)
					{
						this.DamagePoints = (float)Math.Round((double)this.DamagePoints - DamageYield, 1);
						if (Math.Round(DamageYield, 2) > 0.0)
						{
							new WeaponImpact(ref base.GetParentPlatform().m_Scenario, base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), base.GetParentPlatform().GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
							if (this.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								base.GetParentPlatform().LogMessage(Misc.smethod_11(this.Name) + " has suffered fragmentation damage: " + Conversions.ToString(Math.Ceiling(DamageYield)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
							}
							else
							{
								base.GetParentPlatform().LogMessage(Misc.smethod_11(this.Name) + " has suffered additional fragmentation damage: " + Conversions.ToString(Math.Ceiling(DamageYield)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
							}
							if (this.DamagePoints <= 0f)
							{
								this.DamagePoints = 0f;
								if (!base.GetParentPlatform().IsWeapon)
								{
									base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
								}
								this.BeDestroyed(base.GetParentPlatform().GetSide(false), false, base.GetParentPlatform().MountsAreAimpoints());
							}
							else
							{
								int num = GameGeneral.GetRandom().Next(0, 3);
								if (num != 0)
								{
									if (num != 1)
									{
										if (base.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Heavy)
										{
											this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
										}
									}
									else if (base.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Medium)
									{
										this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
									}
								}
								else if (base.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Light)
								{
									this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100681", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x0028DE70 File Offset: 0x0028C070
		public void method_45(double double_0, Warhead.WarheadType warheadType_0, float float_3)
		{
			try
			{
				if (double_0 != 0.0)
				{
					this.method_46(ref double_0, warheadType_0);
					this.DamagePoints = (float)Math.Round((double)this.DamagePoints - double_0, 1);
					this.method_43(double_0);
					if (Math.Round(double_0, 2) > 0.0)
					{
						new WeaponImpact(ref base.GetParentPlatform().m_Scenario, base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), base.GetParentPlatform().GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
						base.GetParentPlatform().LogMessage(Misc.smethod_11(this.Name) + " has suffered bomblet damage: " + Conversions.ToString(Math.Round(double_0, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						if (this.DamagePoints <= 0f)
						{
							this.DamagePoints = 0f;
							if (!base.GetParentPlatform().IsWeapon)
							{
								base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
							}
							this.BeDestroyed(base.GetParentPlatform().GetSide(false), false, base.GetParentPlatform().MountsAreAimpoints());
						}
						else
						{
							int num = GameGeneral.GetRandom().Next(0, 3);
							if (num != 0)
							{
								if (num != 1)
								{
									if (base.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Heavy)
									{
										this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
									}
								}
								else if (base.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Medium)
								{
									this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
								}
							}
							else if (base.GetDamageSeverity() < PlatformComponent._DamageSeverityFactor.Light)
							{
								this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100682", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x0028E0F8 File Offset: 0x0028C2F8
		private void method_46(ref double double_0, Warhead.WarheadType warheadType_0)
		{
			if (warheadType_0 != Warhead.WarheadType.SuperFrag)
			{
				switch (warheadType_0)
				{
				case Warhead.WarheadType.Cluster_AP:
				{
					GlobalVariables.ArmorRating armorGeneral = this.ArmorGeneral;
					if (armorGeneral == GlobalVariables.ArmorRating.None)
					{
						return;
					}
					if (armorGeneral == GlobalVariables.ArmorRating.Light)
					{
						double_0 = 0.5 * double_0;
						return;
					}
					double_0 = 0.0;
					return;
				}
				case Warhead.WarheadType.Cluster_AT:
					break;
				case Warhead.WarheadType.Cluster_Penetrator:
				{
					if (base.AreAimpoints())
					{
						return;
					}
					GlobalVariables.ArmorRating armorGeneral2 = this.ArmorGeneral;
					if (armorGeneral2 == GlobalVariables.ArmorRating.None)
					{
						return;
					}
					switch (armorGeneral2)
					{
					case GlobalVariables.ArmorRating.Light:
						double_0 = 0.9 * double_0;
						return;
					case GlobalVariables.ArmorRating.Medium:
						double_0 = 0.7 * double_0;
						return;
					case GlobalVariables.ArmorRating.Heavy:
						double_0 = 0.5 * double_0;
						return;
					case GlobalVariables.ArmorRating.Special:
						double_0 = 0.2 * double_0;
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
				if (!base.AreAimpoints())
				{
					GlobalVariables.ArmorRating armorGeneral3 = this.ArmorGeneral;
					if (armorGeneral3 != GlobalVariables.ArmorRating.None)
					{
						if (armorGeneral3 == GlobalVariables.ArmorRating.Light)
						{
							double_0 = 0.7 * double_0;
						}
						else if (armorGeneral3 != GlobalVariables.ArmorRating.Medium)
						{
							double_0 = 0.0;
						}
						else
						{
							double_0 = 0.5 * double_0;
						}
					}
				}
			}
			else
			{
				GlobalVariables.ArmorRating armorGeneral4 = this.ArmorGeneral;
				if (armorGeneral4 != GlobalVariables.ArmorRating.None && armorGeneral4 != GlobalVariables.ArmorRating.Light)
				{
					double_0 = 0.0;
				}
			}
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x0028E2A4 File Offset: 0x0028C4A4
		public void method_47(double double_0, Warhead.WarheadType warheadType_0)
		{
			try
			{
				GlobalVariables.ArmorRating armorGeneral = this.ArmorGeneral;
				int num = 0;
				if (armorGeneral != GlobalVariables.ArmorRating.None)
				{
					switch (armorGeneral)
					{
					case GlobalVariables.ArmorRating.Light:
						num = 10;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num = 30;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						num = 75;
						break;
					case GlobalVariables.ArmorRating.Special:
						num = 100;
						break;
					}
				}
				else
				{
					num = 1;
				}
				if (!base.GetParentPlatform().IsWeapon)
				{
					base.GetParentPlatform().LogMessage(Misc.smethod_11(this.Name) + " has suffered blast damage: " + Conversions.ToString(Math.Round(double_0, 1)) + " DPs", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
				}
				this.method_43(double_0);
				if (double_0 > (double)num)
				{
					new WeaponImpact(ref base.GetParentPlatform().m_Scenario, base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), base.GetParentPlatform().GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.BeDestroyed(base.GetParentPlatform().GetSide(false), false, base.GetParentPlatform().MountsAreAimpoints());
				}
				else if (double_0 > (double)num / 2.0)
				{
					new WeaponImpact(ref base.GetParentPlatform().m_Scenario, base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null), base.GetParentPlatform().GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
					if (!base.GetParentPlatform().IsWeapon)
					{
						base.GetParentPlatform().m_Scenario.LogMessage(Misc.smethod_11(base.GetParentPlatform().Name) + "战损报告: " + Misc.smethod_11(this.Name) + " has been damaged.", LoggedMessage.MessageType.UnitDamage, 5, base.GetParentPlatform().GetGuid(), base.GetParentPlatform().GetSide(false), new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					}
					this.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100683", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x0028E5C8 File Offset: 0x0028C7C8
		public override void DamageAssessment(float float_3)
		{
			Sensor[] sensors = this.GetSensors();
			checked
			{
				for (int i = 0; i < sensors.Length; i++)
				{
					sensors[i].DamageAssessment(float_3);
				}
				CommDevice[] commDevices = this.m_CommDevices;
				for (int j = 0; j < commDevices.Length; j++)
				{
					commDevices[j].DamageAssessment(float_3);
				}
			}
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x0028E618 File Offset: 0x0028C818
		private void WeaponRecCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			Mount.Delegate20 @delegate = Mount.delegate20_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x04002E8B RID: 11915
		public static Func<WeaponRec, bool> WeaponRecFunc0 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() == 0;

		// Token: 0x04002E8C RID: 11916
		public static Func<Sensor, bool> SensorFunc1 = (Sensor sensor_0) => !sensor_0.IsEyeball();

		// Token: 0x04002E8D RID: 11917
		public GlobalVariables.ArmorRating ArmorGeneral;

		// Token: 0x04002E8E RID: 11918
		public int ROF;

		// Token: 0x04002E8F RID: 11919
		public int Capacity;

		// Token: 0x04002E90 RID: 11920
		public bool Autonomous;

		// Token: 0x04002E91 RID: 11921
		public bool Logistic;

		// Token: 0x04002E92 RID: 11922
		public bool LocalControl;

		// Token: 0x04002E93 RID: 11923
		public bool Trainable;

		// Token: 0x04002E94 RID: 11924
		public Mount._ReloadStatus ReloadStatus;

		// Token: 0x04002E95 RID: 11925
		public bool ReserveTarget;

		// Token: 0x04002E96 RID: 11926
		[CompilerGenerated]
		private ObservableCollection<WeaponRec> m_WeaponRecCollection;

		// Token: 0x04002E97 RID: 11927
		private Magazine m_MagazineForMount;

		// Token: 0x04002E98 RID: 11928
		private int int_2 = 0;

		// Token: 0x04002E99 RID: 11929
		private int int_3 = 0;

		// Token: 0x04002E9A RID: 11930
		private Sensor[] m_Sensors;

		// Token: 0x04002E9B RID: 11931
		public CommDevice[] m_CommDevices;

		// Token: 0x04002E9C RID: 11932
		private float TimeToFire;

		// Token: 0x04002E9D RID: 11933
		private float float_1;

		// Token: 0x04002E9E RID: 11934
		public float DamagePoints = 0f;

		// Token: 0x04002E9F RID: 11935
		public bool CanHotReload;

		// Token: 0x04002EA0 RID: 11936
		public HashSet<int> RPrioritySet;

		// Token: 0x04002EA1 RID: 11937
		private int? AimpointOffset_Bearing;

		// Token: 0x04002EA2 RID: 11938
		private float? AimpointOffset_Distance;

		// Token: 0x04002EA3 RID: 11939
		public HashSet<int> MountDirectorSet;

		// Token: 0x04002EA4 RID: 11940
		public bool Hypothetical;

		// Token: 0x04002EA5 RID: 11941
		public short Cargo_Crew;

		// Token: 0x04002EA6 RID: 11942
		public short Cargo_Area;

		// Token: 0x04002EA7 RID: 11943
		public _CargoType Cargo_Type;

		// Token: 0x04002EA8 RID: 11944
		public short Cargo_Mass;

		// Token: 0x04002EA9 RID: 11945
		public bool Cargo_ParadropCapable;

		// Token: 0x04002EAA RID: 11946
		public Facility._MobileUnitCategory mobileUnitCategory;

		// Token: 0x04002EAB RID: 11947
		[CompilerGenerated]
		private static Mount.Delegate20 delegate20_0;

		// Token: 0x02000B16 RID: 2838
		// (Invoke) Token: 0x06005B7D RID: 23421
		public delegate void Delegate20(Mount theMount);

		// Token: 0x02000B17 RID: 2839
		public enum _ReloadStatus : byte
		{
			// Token: 0x04002EAF RID: 11951
			const_0,
			// Token: 0x04002EB0 RID: 11952
			Reloading,
			// Token: 0x04002EB1 RID: 11953
			Unloading
		}
	}
}
