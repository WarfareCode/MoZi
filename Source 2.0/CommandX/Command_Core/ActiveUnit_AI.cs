using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 活动单元的人工智能
	public class ActiveUnit_AI
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x000A15EC File Offset: 0x0009F7EC
		public static float? imethod_4(Contact contact_0)
		{
			float? airRangeMax = contact_0.GetAirRangeMax();
			float? num = airRangeMax.HasValue ? new float?(airRangeMax.GetValueOrDefault() * 2f) : null;
			float? maxRange = contact_0.GetMaxRange();
			float? result;
			if (!(num.HasValue & maxRange.HasValue))
			{
				result = null;
			}
			else
			{
				result = new float?(num.GetValueOrDefault() + maxRange.GetValueOrDefault());
			}
			return result;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000A1668 File Offset: 0x0009F868
		[CompilerGenerated]
		protected virtual ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> GetTargetList()
		{
			return this.TargetingEntryDictionary;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000A1680 File Offset: 0x0009F880
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		protected virtual void vmethod_1(ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> observableDictionary_1)
		{
			INotifyDictionaryChanged<string, ActiveUnit_AI.TargetingEntry>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, ActiveUnit_AI.TargetingEntry>.DictionaryChangedEventHandler(this.method_75);
			ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> targetingEntryDictionary = this.TargetingEntryDictionary;
			if (targetingEntryDictionary != null)
			{
				targetingEntryDictionary.DictionaryChanged -= value;
			}
			this.TargetingEntryDictionary = observableDictionary_1;
			targetingEntryDictionary = this.TargetingEntryDictionary;
			if (targetingEntryDictionary != null)
			{
				targetingEntryDictionary.DictionaryChanged += value;
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000A16CC File Offset: 0x0009F8CC
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.GetPrimaryTarget()))
					{
						xmlWriter_0.WriteElementString("PrimaryTarget", this.GetPrimaryTarget().GetGuid());
					}
					if (!Information.IsNothing(this.PrimaryTargetType))
					{
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "PrimaryTarget_Type";
						int i = (int)this.PrimaryTargetType;
						xmlWriter.WriteElementString(localName, i.ToString());
					}
					if (!Information.IsNothing(this.PrimaryThreat))
					{
						xmlWriter_0.WriteElementString("PrimaryThreat", this.PrimaryThreat.GetGuid());
					}
					if (this.GetPrimaryTarget_LastKnown_Lat() != 0.0)
					{
						xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lat", XmlConvert.ToString(this.GetPrimaryTarget_LastKnown_Lat()));
					}
					if (this.GetPrimaryTarget_LastKnown_Lon() != 0.0)
					{
						xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lon", XmlConvert.ToString(this.GetPrimaryTarget_LastKnown_Lon()));
					}
					if (this.GetPrimaryTarget_LastKnown_Alt() != 0f)
					{
						xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Alt", XmlConvert.ToString(this.GetPrimaryTarget_LastKnown_Alt()));
					}
					xmlWriter_0.WriteElementString("TTNPTE", this.TimeToNextPrimaryTargetEvent.ToString());
					xmlWriter_0.WriteElementString("PTOE", this.bPrimaryTargetOverride.ToString());
					xmlWriter_0.WriteElementString("HPos", this.HoldPosition.ToString());
					xmlWriter_0.WriteElementString("FCLIO", this.FerryCycleLegIsOutbound.ToString());
					if (this.IsEscort)
					{
						xmlWriter_0.WriteElementString("IE", this.IsEscort.ToString());
					}
					if (!Information.IsNothing(this.LastKnownTargetLocation))
					{
						xmlWriter_0.WriteStartElement("LKTL");
						GeoPoint lastKnownTargetLocation = this.LastKnownTargetLocation;
						HashSet<string> hashSet = null;
						lastKnownTargetLocation.Save(ref xmlWriter_0, ref hashSet);
						xmlWriter_0.WriteEndElement();
					}
					if (this.GetTargetList().Count > 0)
					{
						xmlWriter_0.WriteStartElement("TargetList");
						foreach (ActiveUnit_AI.TargetingEntry current in this.GetTargetList().Values)
						{
							if (!Information.IsNothing(current.Target.ActualUnit))
							{
								current.Save(ref xmlWriter_0, this.m_ActiveUnit.GetSide(false));
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.GetThreats().Length > 0)
					{
						xmlWriter_0.WriteStartElement("Threats");
						Contact[] array = this.Threats.ToArray<Contact>();
						for (int i = 0; i < array.Length; i++)
						{
							Contact contact = array[i];
							if (!Information.IsNothing(contact))
							{
								contact.Save(ref xmlWriter_0, ref hashSet_1);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.HoldPosition)
					{
						xmlWriter_0.WriteElementString("HP", this.HoldPosition.ToString());
					}
					if (!Information.IsNothing(this.SnakeAxis))
					{
						xmlWriter_0.WriteElementString("SnakeAxis", Conversions.ToString(this.SnakeAxis.Value));
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100021", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 载入数据
		public static void Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_1, ActiveUnit activeUnit_1)
		{
			try
			{
				ActiveUnit_AI activeUnit_AI = new ActiveUnit_AI();
				activeUnit_AI.m_ActiveUnit = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1925531877u)
						{
							if (num <= 2722719197u)
							{
								if (num <= 2133975202u)
								{
									if (num != 1966596370u)
									{
										if (num == 2133975202u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
										{
											activeUnit_AI.SetPrimaryTarget_LastKnown_Lat(XmlConvert.ToDouble(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
										{
											activeUnit_AI.SetPrimaryTarget_LastKnown_Lon(XmlConvert.ToDouble(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num != 2273311670u)
									{
										if (num != 2276842832u)
										{
											if (num != 2722719197u)
											{
												continue;
											}
											if (Operators.CompareString(name, "PTOE", false) != 0)
											{
												continue;
											}
											goto IL_1EC;
										}
										else
										{
											if (Operators.CompareString(name, "TargetList", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
													ActiveUnit_AI.TargetingEntry targetingEntry = ActiveUnit_AI.TargetingEntry.Load(ref xmlNode2, ref dictionary_1);
													activeUnit_AI.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
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
									}
									if (Operators.CompareString(name, "FCLIO", false) == 0)
									{
										goto IL_5D4;
									}
									continue;
								}
							}
							else if (num <= 3761246852u)
							{
								if (num != 2783884855u)
								{
									if (num != 3761246852u || Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "HPos", false) == 0)
									{
										activeUnit_AI.HoldPosition = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3957045325u)
							{
								if (num != 4025372673u)
								{
									if (num == 4076649232u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
									{
										activeUnit_AI.SetPrimaryTarget_LastKnown_Alt(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget_Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										activeUnit_AI.PrimaryTargetType = (Contact_Base.ContactType)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									activeUnit_AI.PrimaryTargetType = (Contact_Base.ContactType)Enum.Parse(typeof(Contact_Base.ContactType), xmlNode.InnerText, true);
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IPC", false) == 0)
								{
									goto IL_348;
								}
								continue;
							}
							IL_1EC:
							activeUnit_AI.bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 592141878u)
						{
							if (num <= 357111700u)
							{
								if (num != 106934956u)
								{
									if (num != 357111700u || Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
									{
										activeUnit_AI.PrimaryTarget = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
										continue;
									}
									continue;
								}
							}
							else if (num != 402376870u)
							{
								if (num != 467450941u)
								{
									if (num != 592141878u || Operators.CompareString(name, "Threats", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
											Contact contact_ = Contact.Load(ref xmlNode3, ref dictionary_1);
											ScenarioArrayUtil.AddContact(ref activeUnit_AI.Threats, contact_);
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
								if (Operators.CompareString(name, "PrimaryThreat", false) == 0)
								{
									activeUnit_AI.PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SnakeAxis", false) == 0)
								{
									activeUnit_AI.SnakeAxis = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								continue;
							}
						}
						else if (num <= 1474882803u)
						{
							if (num != 868927472u)
							{
								if (num == 1474882803u && Operators.CompareString(name, "IE", false) == 0)
								{
									activeUnit_AI.IsEscort = true;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "LKTL", false) == 0)
								{
									activeUnit_AI.LastKnownTargetLocation = GeoPoint.Load(ref xmlNode, ref dictionary_1);
									continue;
								}
								continue;
							}
						}
						else if (num != 1610968176u)
						{
							if (num != 1894470373u)
							{
								if (num == 1925531877u && Operators.CompareString(name, "FerryCycleLegIsOutbound", false) == 0)
								{
									goto IL_5D4;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "HP", false) == 0)
								{
									activeUnit_AI.HoldPosition = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "TTNPTE", false) == 0)
							{
								activeUnit_AI.TimeToNextPrimaryTargetEvent = Conversions.ToShort(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_348:
						bool flag = Conversions.ToBoolean(xmlNode.InnerText);
						if (!Information.IsNothing(activeUnit_1.m_Doctrine))
						{
							activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Conversions.ToBoolean(xmlNode.InnerText) ? Doctrine._IgnorePlottedCourseWhenAttacking.const_1 : Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
						}
						if (!flag || Information.IsNothing(activeUnit_1.GetAssignedMission(false)))
						{
							continue;
						}
						Mission assignedMission = activeUnit_1.GetAssignedMission(false);
						if (assignedMission.MissionClass == Mission._MissionClass.Patrol)
						{
							assignedMission.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
							continue;
						}
						continue;
						IL_5D4:
						activeUnit_AI.FerryCycleLegIsOutbound = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100022", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000A2140 File Offset: 0x000A0340
		private ActiveUnit_AI()
		{
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_AI.TargetingEntry>());
			this.Threats = new Contact[0];
			this.bool_3 = false;
			this.PostureStanceDictionary = new Dictionary<string, Misc.PostureStance>();
			this.Latitude = 0.0;
			this.Longitude = 0.0;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x000A21C0 File Offset: 0x000A03C0
		public double GetPrimaryTarget_LastKnown_Lat()
		{
			return this.PrimaryTarget_LastKnown_Lat;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00011232 File Offset: 0x0000F432
		public void SetPrimaryTarget_LastKnown_Lat(double double_4)
		{
			if (!Information.IsNothing(double_4))
			{
				this.PrimaryTarget_LastKnown_Lat = double_4;
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000A21D8 File Offset: 0x000A03D8
		public double GetPrimaryTarget_LastKnown_Lon()
		{
			return this.PrimaryTarget_LastKnown_Lon;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00011248 File Offset: 0x0000F448
		public void SetPrimaryTarget_LastKnown_Lon(double double_4)
		{
			if (!Information.IsNothing(double_4))
			{
				this.PrimaryTarget_LastKnown_Lon = double_4;
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000A21F0 File Offset: 0x000A03F0
		public float GetPrimaryTarget_LastKnown_Alt()
		{
			return this.PrimaryTarget_LastKnown_Alt;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0001125E File Offset: 0x0000F45E
		public void SetPrimaryTarget_LastKnown_Alt(float float_1)
		{
			if (!Information.IsNothing(float_1))
			{
				this.PrimaryTarget_LastKnown_Alt = float_1;
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x000A2208 File Offset: 0x000A0408
		public virtual Contact GetPrimaryTarget()
		{
			return this.PrimaryTarget;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000A2220 File Offset: 0x000A0420
		public virtual void SetPrimaryTarget(Contact contact_8)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					if (contact_8 != this.PrimaryTarget)
					{
						if (!Information.IsNothing(this.PrimaryTarget))
						{
							this.PrimaryTarget.method_112(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetSide(false), null).TryRemove(this.m_ActiveUnit.GetGuid(), out this.m_ActiveUnit);
						}
						if (!Information.IsNothing(contact_8))
						{
							try
							{
								if (Information.IsNothing(this.m_ActiveUnit))
								{
									return;
								}
								contact_8.method_112(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetSide(false), null).TryAdd(this.m_ActiveUnit.GetGuid(), this.m_ActiveUnit);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 101190", "");
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
						}
						if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.m_ActiveUnit.GetNavigator()) && this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
						{
							this.m_ActiveUnit.GetNavigator().method_14();
						}
						this.PrimaryTarget = contact_8;
						if (!Information.IsNothing(contact_8))
						{
							this.PrimaryTargetType = contact_8.contactType;
						}
					}
					if (!Information.IsNothing(contact_8))
					{
						this.SetPrimaryTarget_LastKnown_Lat(contact_8.GetLatitude(null));
						this.SetPrimaryTarget_LastKnown_Lon(contact_8.GetLongitude(null));
						this.SetPrimaryTarget_LastKnown_Alt(contact_8.GetCurrentAltitude_ASL(false));
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100023", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000A243C File Offset: 0x000A063C
		public virtual Contact GetPrimaryThreat()
		{
			return this.PrimaryThreat;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00011274 File Offset: 0x0000F474
		public virtual void SetPrimaryThreat(Contact contact_8)
		{
			this.PrimaryThreat = contact_8;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000A2454 File Offset: 0x000A0654
		public virtual Contact_Base.ContactType GetPrimaryTargetType()
		{
			return this.PrimaryTargetType;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0001127D File Offset: 0x0000F47D
		public virtual void SetPrimaryTargetType(Contact_Base.ContactType contactType_1)
		{
			this.PrimaryTargetType = contactType_1;
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool vmethod_9()
		{
			return false;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x000A246C File Offset: 0x000A066C
		public Contact[] GetTargets()
		{
			Contact[] result;
			try
			{
				if (Information.IsNothing(this.contact_3))
				{
					this.contact_3 = this.GetTargetList().Values.Where(ActiveUnit_AI.TargetingEntryFunc0).Select(ActiveUnit_AI.TargetingEntryFunc1).ToArray<Contact>();
				}
				result = this.contact_3;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100024", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.contact_3 = new Contact[0];
				result = this.contact_3;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000A2520 File Offset: 0x000A0720
		public HashSet<string> GetTargetIDSet()
		{
			HashSet<string> result = null;
			checked
			{
				try
				{
					if (Information.IsNothing(this.hashSet_0))
					{
						HashSet<string> hashSet = new HashSet<string>();
						Contact[] targets = this.GetTargets();
						for (int i = 0; i < targets.Length; i++)
						{
							Contact contact = targets[i];
							hashSet.Add(contact.GetGuid());
						}
						this.hashSet_0 = hashSet;
					}
					result = this.hashSet_0;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101298", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000A25D4 File Offset: 0x000A07D4
		public ActiveUnit_AI.TargetingEntry[] GetTargetArray()
		{
			ActiveUnit_AI.TargetingEntry[] result = null;
			try
			{
				bool flag = false;
				if (Information.IsNothing(this.TargetingEntryArray))
				{
					flag = true;
				}
				else if (this.GetTargets().Length != this.TargetingEntryArray.Count<ActiveUnit_AI.TargetingEntry>())
				{
					flag = true;
				}
				else if (this.m_ActiveUnit.IsAircraft && (Math.Abs(this.m_ActiveUnit.GetLatitude(null) - this.Latitude) > 0.2 || Math.Abs(this.m_ActiveUnit.GetLongitude(null) - this.Longitude) > 0.2))
				{
					flag = true;
				}
				else if (!this.m_ActiveUnit.IsAircraft && (Math.Abs(this.m_ActiveUnit.GetLatitude(null) - this.Latitude) > 0.05 || Math.Abs(this.m_ActiveUnit.GetLongitude(null) - this.Longitude) > 0.05))
				{
					flag = true;
				}
				else
				{
					bool? flag2;
					bool? flag6;
					if (Information.IsNothing(this.AirTargetDistance))
					{
						flag2 = new bool?(false);
					}
					else
					{
						float? num = this.AirTargetDistance;
						bool? flag4;
						bool? flag3 = flag4 = (num.HasValue ? new bool?(num.GetValueOrDefault() < 15f) : null);
						if (flag3.HasValue && flag4.GetValueOrDefault())
						{
							flag2 = new bool?(true);
						}
						else
						{
							bool? flag5;
							if (Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax()))
							{
								flag5 = new bool?(false);
							}
							else
							{
								num = this.AirTargetDistance;
								double? num2 = num.HasValue ? new double?((double)num.GetValueOrDefault()) : null;
								double num3 = (double)this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax().RangeAAWMax * 1.5;
								flag5 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() < num3) : null);
							}
							flag3 = (flag6 = flag5);
							flag2 = (flag3.HasValue ? (flag4 | flag6.GetValueOrDefault()) : null);
						}
					}
					flag6 = flag2;
					if (flag6.GetValueOrDefault())
					{
						flag = true;
					}
					else
					{
						bool? flag4;
						bool? flag7;
						if (Information.IsNothing(this.SurfaceTargetDistance))
						{
							flag7 = new bool?(false);
						}
						else
						{
							float? num = this.SurfaceTargetDistance;
							bool? flag3 = flag6 = (num.HasValue ? new bool?(num.GetValueOrDefault() < 15f) : null);
							if (flag3.HasValue && flag6.GetValueOrDefault())
							{
								flag7 = new bool?(true);
							}
							else
							{
								bool? flag8;
								if (Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false)))
								{
									flag8 = new bool?(false);
								}
								else
								{
									num = this.SurfaceTargetDistance;
									double? num2 = num.HasValue ? new double?((double)num.GetValueOrDefault()) : null;
									double num3 = (double)this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false).RangeASUWMax * 1.2;
									flag8 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() < num3) : null);
								}
								flag3 = (flag4 = flag8);
								flag7 = (flag3.HasValue ? (flag6 | flag4.GetValueOrDefault()) : null);
							}
						}
						flag4 = flag7;
						if (flag4.GetValueOrDefault())
						{
							flag = true;
						}
						else
						{
							bool? flag9;
							if (Information.IsNothing(this.SubSurfaceTargetDistance))
							{
								flag9 = new bool?(false);
							}
							else
							{
								float? num = this.SubSurfaceTargetDistance;
								bool? flag3 = flag4 = (num.HasValue ? new bool?(num.GetValueOrDefault() < 15f) : null);
								if (flag3.HasValue && flag4.GetValueOrDefault())
								{
									flag9 = new bool?(true);
								}
								else
								{
									bool? flag10;
									if (Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax()))
									{
										flag10 = new bool?(false);
									}
									else
									{
										num = this.SubSurfaceTargetDistance;
										double? num2 = num.HasValue ? new double?((double)num.GetValueOrDefault()) : null;
										double num3 = (double)this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax().RangeASWMax * 1.2;
										flag10 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() < num3) : null);
									}
									flag3 = (flag6 = flag10);
									flag9 = (flag3.HasValue ? (flag4 | flag6.GetValueOrDefault()) : null);
								}
							}
							flag6 = flag9;
							if (flag6.GetValueOrDefault())
							{
								flag = true;
							}
							else
							{
								bool? flag11;
								if (Information.IsNothing(this.FixedTargetDistance))
								{
									flag11 = new bool?(false);
								}
								else
								{
									float? num = this.FixedTargetDistance;
									bool? flag3 = flag6 = (num.HasValue ? new bool?(num.GetValueOrDefault() < 15f) : null);
									if (flag3.HasValue && flag6.GetValueOrDefault())
									{
										flag11 = new bool?(true);
									}
									else
									{
										bool? flag12;
										if (Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false)))
										{
											flag12 = new bool?(false);
										}
										else
										{
											num = this.FixedTargetDistance;
											double? num2 = num.HasValue ? new double?((double)num.GetValueOrDefault()) : null;
											double num3 = (double)this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false).RangeLandMax * 1.2;
											flag12 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() < num3) : null);
										}
										flag3 = (flag4 = flag12);
										flag11 = (flag3.HasValue ? (flag6 | flag4.GetValueOrDefault()) : null);
									}
								}
								flag4 = flag11;
								if (flag4.GetValueOrDefault())
								{
									flag = true;
								}
								else
								{
									foreach (ActiveUnit_AI.TargetingEntry current in this.GetTargetList().Values)
									{
										if (!Information.IsNothing(current.Target))
										{
											if (current.Target.IsAirSpace())
											{
												if (Math.Abs(current.Target.GetLatitude(null) - current.Latitude) <= 0.2 && Math.Abs(current.Target.GetLongitude(null) - current.Longitude) <= 0.2)
												{
													continue;
												}
												flag = true;
											}
											else
											{
												if (Math.Abs(current.Target.GetLatitude(null) - current.Latitude) <= 0.05 && Math.Abs(current.Target.GetLongitude(null) - current.Longitude) <= 0.05)
												{
													continue;
												}
												flag = true;
											}
											break;
										}
									}
								}
							}
						}
					}
				}
				checked
				{
					if (flag)
					{
						this.TargetingEntryArray = this.GetTargetingEntryArray(this.GetTargetList());
						this.AirSpaceTarget = null;
						this.SurfaceTarget = null;
						this.SubSurfaceTarget = null;
						this.FixedTarget = null;
						ActiveUnit_AI.TargetingEntry[] targetingEntryArray = this.TargetingEntryArray;
						for (int i = 0; i < targetingEntryArray.Length; i++)
						{
							ActiveUnit_AI.TargetingEntry targetingEntry = targetingEntryArray[i];
							if (!Information.IsNothing(targetingEntry.Target))
							{
								if (targetingEntry.Target.IsAirSpace())
								{
									if (Information.IsNothing(this.AirSpaceTarget))
									{
										this.AirSpaceTarget = targetingEntry.Target;
									}
								}
								else if (targetingEntry.Target.IsSurface())
								{
									if (Information.IsNothing(this.SurfaceTarget))
									{
										this.SurfaceTarget = targetingEntry.Target;
									}
								}
								else if (targetingEntry.Target.IsSubSurface())
								{
									if (Information.IsNothing(this.SubSurfaceTarget))
									{
										this.SubSurfaceTarget = targetingEntry.Target;
									}
								}
								else if (targetingEntry.Target.IsFixed() && Information.IsNothing(this.FixedTarget))
								{
									this.FixedTarget = targetingEntry.Target;
								}
								targetingEntry.Latitude = targetingEntry.Target.GetLatitude(null);
								targetingEntry.Longitude = targetingEntry.Target.GetLongitude(null);
							}
						}
						this.Latitude = this.m_ActiveUnit.GetLatitude(null);
						this.Longitude = this.m_ActiveUnit.GetLongitude(null);
					}
					if (!Information.IsNothing(this.AirSpaceTarget))
					{
						this.AirTargetDistance = new float?(this.m_ActiveUnit.GetSlantRange(this.AirSpaceTarget, 0f));
					}
					if (!Information.IsNothing(this.SurfaceTarget))
					{
						this.SurfaceTargetDistance = new float?(this.m_ActiveUnit.GetSlantRange(this.SurfaceTarget, 0f));
					}
					if (!Information.IsNothing(this.SubSurfaceTarget))
					{
						this.SubSurfaceTargetDistance = new float?(this.m_ActiveUnit.GetSlantRange(this.SubSurfaceTarget, 0f));
					}
					if (!Information.IsNothing(this.FixedTarget))
					{
						this.FixedTargetDistance = new float?(this.m_ActiveUnit.GetSlantRange(this.FixedTarget, 0f));
					}
					result = this.TargetingEntryArray;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101271", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000A307C File Offset: 0x000A127C
		public Contact[] GetThreats()
		{
			return this.Threats;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00011286 File Offset: 0x0000F486
		internal void ClearPostureStanceDictionary()
		{
			this.PostureStanceDictionary.Clear();
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x000A3094 File Offset: 0x000A1294
		public GeoPoint GetIntermediateTargetPoint()
		{
			GeoPoint geoPoint = null;
			checked
			{
				GeoPoint result;
				try
				{
					GeoPoint geoPoint2 = null;
					ActiveUnit._ActiveUnitStatus unitStatus = this.m_ActiveUnit.GetUnitStatus();
					if (unitStatus <= ActiveUnit._ActiveUnitStatus.RTB)
					{
						if (unitStatus != ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
						{
							if (unitStatus != ActiveUnit._ActiveUnitStatus.RTB)
							{
								goto IL_11C;
							}
						}
						else
						{
							if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
							{
								geoPoint2 = this.m_ActiveUnit.GetNavigator().GetPlottedCourse().Last<Waypoint>();
								goto IL_11C;
							}
							geoPoint2 = new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null));
							goto IL_11C;
						}
					}
					else if (unitStatus != ActiveUnit._ActiveUnitStatus.RTB_Manual)
					{
						if (unitStatus != ActiveUnit._ActiveUnitStatus.OnFerryMission)
						{
							if (unitStatus != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
							{
								goto IL_11C;
							}
						}
						else
						{
							ActiveUnit assignedHostUnit;
							if (this.m_ActiveUnit.IsAircraft)
							{
								assignedHostUnit = ((Aircraft)this.m_ActiveUnit).GetAircraftAirOps().GetAssignedHostUnit();
							}
							else
							{
								assignedHostUnit = this.m_ActiveUnit.GetDockingOps().GetAssignedHostUnit();
							}
							if (!Information.IsNothing(assignedHostUnit))
							{
								geoPoint2 = new GeoPoint(assignedHostUnit.GetLongitude(null), assignedHostUnit.GetLatitude(null));
								goto IL_11C;
							}
							goto IL_11C;
						}
					}
					geoPoint = null;
					goto IL_2FD;
					IL_11C:
					if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
					{
						geoPoint2 = this.m_ActiveUnit.GetNavigator().GetPlottedCourse().Last<Waypoint>();
					}
					if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
					{
						switch (this.m_ActiveUnit.GetAssignedMission(false).MissionClass)
						{
						case Mission._MissionClass.Strike:
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								bool arg_1CF_0;
								if (this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Air)
								{
									if (this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Missile)
									{
										arg_1CF_0 = false;
										goto IL_1CF;
									}
								}
								arg_1CF_0 = (this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) < 150f);
								IL_1CF:
								if (!arg_1CF_0)
								{
									geoPoint2 = new GeoPoint(this.GetPrimaryTarget().GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null));
								}
							}
							else if (this.m_ActiveUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0)
							{
								Waypoint[] plottedCourse = this.m_ActiveUnit.GetNavigator().GetPlottedCourse();
								for (int i = 0; i < plottedCourse.Length; i++)
								{
									Waypoint waypoint = plottedCourse[i];
									if (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponLaunch)
									{
										geoPoint2 = new GeoPoint(waypoint.GetLongitude(), waypoint.GetLatitude());
										break;
									}
								}
							}
							break;
						case Mission._MissionClass.Patrol:
							geoPoint2 = Misc.smethod_51(((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).PatrolAreaVertices);
							break;
						case Mission._MissionClass.Support:
							geoPoint2 = this.m_ActiveUnit.GetNavigator().SupportMission_NextRefPoint;
							break;
						}
					}
					geoPoint = geoPoint2;
					result = geoPoint;
					return result;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100025", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				IL_2FD:
				result = geoPoint;
				return result;
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000A33C0 File Offset: 0x000A15C0
		public ActiveUnit_AI(ActiveUnit activeUnit_1)
		{
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_AI.TargetingEntry>());
			this.Threats = new Contact[0];
			this.bool_3 = false;
			this.PostureStanceDictionary = new Dictionary<string, Misc.PostureStance>();
			this.Latitude = 0.0;
			this.Longitude = 0.0;
			this.m_ActiveUnit = activeUnit_1;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000A3448 File Offset: 0x000A1648
		public float GetOODAReactionTime(Contact theTarget_)
		{
			float result = 0f;
			try
			{
				if (Information.IsNothing(theTarget_))
				{
					result = 30f;
				}
				else if (Information.IsNothing(this.m_ActiveUnit))
				{
					result = 30f;
				}
				else if (theTarget_.contactType == Contact_Base.ContactType.ActivationPoint)
				{
					result = 0f;
				}
				else
				{
					float num = 0f;
					if (!Information.IsNothing(theTarget_.ActualUnit))
					{
						if (theTarget_.ActualUnit.IsAutoDetectable(this.m_ActiveUnit.GetSide(false)))
						{
							num = theTarget_.TSD;
						}
						if (num == 0f && theTarget_.ActualUnit.IsFixedFacility())
						{
							num = theTarget_.TSD;
						}
						if (num == 0f && this.m_ActiveUnit.IsAircraft && !theTarget_.IsAirSpace())
						{
							num = theTarget_.TSD;
						}
					}
					if (num == 0f)
					{
						float? num2 = this.m_ActiveUnit.GetSensory().method_65(ref theTarget_);
						if (!Information.IsNothing(num2))
						{
							num = num2.Value;
						}
						else if (!Information.IsNothing(theTarget_.ActualUnit))
						{
							this.m_ActiveUnit.GetSensory().lazy_1.Value.TryAdd(theTarget_.ActualUnit.GetGuid(), theTarget_);
						}
					}
					GlobalVariables.ProficiencyLevel? proficiencyLevel = this.m_ActiveUnit.GetProficiencyLevel();
					int? num3 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
					short num4 = 0;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num4 = (short)(this.m_ActiveUnit.OODATargetingCycle * 2.0);
					}
					else
					{
						num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							num4 = (short)Math.Round((double)this.m_ActiveUnit.OODATargetingCycle * 1.5);
						}
						else
						{
							num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								num4 = (short)Math.Round((double)this.m_ActiveUnit.OODATargetingCycle * 1.2);
							}
							else
							{
								num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									num4 = this.m_ActiveUnit.OODATargetingCycle;
								}
								else
								{
									num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										num4 = (short)Math.Round((double)this.m_ActiveUnit.OODATargetingCycle * 0.8);
									}
								}
							}
						}
					}
					result = Math.Max((float)num4 - num, 0f);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100026", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000A3844 File Offset: 0x000A1A44
		public ActiveUnit_AI.TargetingEntry._TargetingBehavior GetTargetingBehavior(Contact contact_8)
		{
			ActiveUnit_AI.TargetingEntry._TargetingBehavior result = ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted;
			try
			{
				ActiveUnit_AI.TargetingEntry targetingEntry = null;
				if (this.GetTargetList().TryGetValue(contact_8.GetGuid(), ref targetingEntry))
				{
					result = targetingEntry.GetTargetingBehavior();
				}
				else
				{
					result = ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100027", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000A38CC File Offset: 0x000A1ACC
		public bool method_14(Contact contact_8)
		{
			return !Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(contact_8) && contact_8.Heading_Known && Math.Abs(Class263.RelativeBearingTo(contact_8.GetCurrentHeading(), contact_8.AzimuthTo(this.m_ActiveUnit))) < 5f;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x000A3920 File Offset: 0x000A1B20
		public void method_15()
		{
			ActiveUnit[] array = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToArray<ActiveUnit>();
			List<ActiveUnit> list = new List<ActiveUnit>();
			ActiveUnit[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					ActiveUnit activeUnit = array2[i];
					if (activeUnit.IsOperating() && !activeUnit.IsGroup && !Information.IsNothing(activeUnit.GetAssignedMission(false)) && activeUnit.GetAssignedMission(false) == this.m_ActiveUnit.GetAssignedMission(false) && !activeUnit.GetAI().IsEscort)
					{
						list.Add(activeUnit);
					}
				}
				if (list.Count != 0)
				{
					ActiveUnit activeUnit2 = list.OrderBy(new Func<ActiveUnit, float>(this.RangeTo)).ToList<ActiveUnit>()[0];
					float num = this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false).Select(ActiveUnit_AI.WeaponMaxRange).Max();
					float num2 = Math.Min(5f, num / 3f);
					if (this.m_ActiveUnit.GetHorizontalRange(activeUnit2) > num2)
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_1, this.m_ActiveUnit.AzimuthTo(activeUnit2));
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_1, activeUnit2.GetCurrentHeading());
						this.m_ActiveUnit.SetDesiredSpeed(activeUnit2.GetCurrentSpeed());
					}
				}
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000A3A80 File Offset: 0x000A1C80
		public void method_16(ref Aircraft_AirOps aircraft_AirOps_0)
		{
			try
			{
				if (Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()))
				{
					this.bool_3 = false;
				}
				else
				{
					ActiveUnit groupLead = this.m_ActiveUnit.GetParentGroup(false).GetGroupLead();
					bool arg_FE_0;
					if (!this.m_ActiveUnit.IsGroupLead())
					{
						if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
						{
							if (this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.Assemble)
							{
								arg_FE_0 = true;
								goto IL_FE;
							}
						}
						arg_FE_0 = (this.m_ActiveUnit.IsNotGroupLead() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false)) && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().HasPlottedCourse() && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.Assemble);
					}
					else
					{
						arg_FE_0 = false;
					}
					IL_FE:
					bool flag = arg_FE_0;
					bool arg_18C_0;
					if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
						if (aircraft_AirOps_0.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel)
						{
							arg_18C_0 = true;
							goto IL_18C;
						}
					}
					arg_18C_0 = ((Information.IsNothing(aircraft_AirOps_0.GetA2ARefuelingDestinationAircraft()) || this.m_ActiveUnit.GetHorizontalRange(aircraft_AirOps_0.GetA2ARefuelingDestinationAircraft()) >= aircraft_AirOps_0.float_4) && (!Information.IsNothing(aircraft_AirOps_0.GetA2ARefuelingDestinationAircraft()) || groupLead.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling || this.m_ActiveUnit.GetHorizontalRange(((Aircraft)groupLead).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft()) >= aircraft_AirOps_0.float_4));
					IL_18C:
					if (!arg_18C_0)
					{
						if (Information.IsNothing(aircraft_AirOps_0.GetA2ARefuelingDestinationAircraft()) && !Information.IsNothing(((Aircraft)groupLead).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft()))
						{
							aircraft_AirOps_0.method_27(((Aircraft)this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft());
						}
						aircraft_AirOps_0.ManoeuveringToRefuel(true);
						this.bool_3 = false;
					}
					else
					{
						if (flag && this.m_ActiveUnit.GetHorizontalRange(groupLead) < 4f)
						{
							this.bool_3 = true;
						}
						else
						{
							if (this.m_ActiveUnit.GetHorizontalRange(groupLead) < 1f)
							{
								this.method_17();
								this.bool_3 = true;
								return;
							}
							this.bool_3 = false;
						}
						if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
						{
							this.m_ActiveUnit.SetDesiredAltitude(groupLead.GetDesiredAltitude());
							this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(groupLead.GetDesiredAltitude_TerrainFollowing());
						}
						if (this.m_ActiveUnit.GetCurrentSpeed() > 0f && !flag)
						{
							float num = this.m_ActiveUnit.method_49(this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.HorizontalRangeTo(groupLead.GetLatitude(null), groupLead.GetLongitude(null)));
							float num2 = groupLead.GetCurrentSpeed() * num / 3600f;
							double lon = 0.0;
							double lat = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(groupLead.GetLongitude(null), groupLead.GetLatitude(null), ref lon, ref lat, (double)num2, (double)groupLead.GetCurrentHeading());
							this.m_ActiveUnit.SetDesiredHeading(groupLead.GetDesiredTurnRate(), Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), lat, lon));
						}
						else
						{
							this.m_ActiveUnit.SetDesiredHeading(groupLead.GetDesiredTurnRate(), Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), groupLead.GetLatitude(null), groupLead.GetLongitude(null)));
						}
						this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
						if (groupLead.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							if (this.m_ActiveUnit.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsBingo)
							{
								if (this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25())
								{
									this.m_ActiveUnit.SetThrottle(groupLead.GetThrottle(), null);
								}
								else if (groupLead.GetThrottle() <= ActiveUnit.Throttle.Cruise)
								{
									this.m_ActiveUnit.SetThrottle(groupLead.GetThrottle(), null);
								}
								else
								{
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
								}
							}
							else if (this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25())
							{
								if (groupLead.GetThrottle() <= ActiveUnit.Throttle.Cruise)
								{
									this.m_ActiveUnit.SetThrottle(groupLead.GetThrottle() + 1, null);
								}
								else
								{
									this.m_ActiveUnit.SetThrottle(groupLead.GetThrottle(), null);
								}
							}
							else
							{
								this.m_ActiveUnit.SetThrottle(groupLead.GetThrottle() + 1, null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200334", ex2.Message);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				GameGeneral.LogException(ref ex2);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x000A4008 File Offset: 0x000A2208
		public void method_17()
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()))
				{
					if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride() && !this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().IsShip)
					{
						if (this.m_ActiveUnit.GetDesiredAltitude() != this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude())
						{
							this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude());
						}
						if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() != this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing())
						{
							this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing());
						}
					}
					this.m_ActiveUnit.SetDesiredHeading(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredTurnRate(), this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredHeading(ActiveUnit._TurnRate.const_0));
					if (this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredTurnRate() == ActiveUnit._TurnRate.const_1)
					{
						this.m_ActiveUnit.SetDesiredSpeed(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetCurrentSpeed());
					}
					else
					{
						this.m_ActiveUnit.SetDesiredSpeed(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredSpeed());
					}
					if (this.m_ActiveUnit.GetThrottle() != this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetThrottle())
					{
						this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetThrottle(), null);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100029", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000A4230 File Offset: 0x000A2430
		public void method_18(ref ActiveUnit activeUnit_1)
		{
			if (activeUnit_1.IsGroup)
			{
				using (IEnumerator<ActiveUnit> enumerator = ((Group)activeUnit_1).GetUnitsInGroup().Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (!current.IsGroupLead())
						{
							current.GetAI().method_17();
						}
					}
					return;
				}
			}
			if (activeUnit_1.IsNotGroupLead())
			{
				activeUnit_1.GetAI().method_17();
			}
			else if (activeUnit_1.IsGroupLead())
			{
				foreach (ActiveUnit current2 in activeUnit_1.GetParentGroup(false).GetUnitsInGroup().Values)
				{
					if (!current2.IsGroupLead())
					{
						current2.GetAI().method_17();
					}
				}
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000A4324 File Offset: 0x000A2524
		public bool method_19(Aircraft aircraft_, Contact contact_8, float float_1, float? nullable_5)
		{
			Aircraft_AirOps aircraftAirOps = aircraft_.GetAircraftAirOps();
			bool flag = false;
			ActiveUnit activeUnit = null;
			List<Mission> missionList = null;
			string text = "";
			List<Aircraft> tankersForMe = aircraftAirOps.GetTankersForMe(ref flag, ref activeUnit, false, missionList, ref text);
			float num = aircraft_.GetAircraftKinematics().vmethod_20(false, null, nullable_5);
			if (tankersForMe.Count > 1)
			{
				List<Aircraft> list = new List<Aircraft>();
				using (List<Aircraft>.Enumerator enumerator = tankersForMe.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit_AI.IdentityChecker identityChecker = new ActiveUnit_AI.IdentityChecker(null);
						identityChecker.aircraft = enumerator.Current;
						bool flag2 = false;
						foreach (Aircraft current in tankersForMe.Where((identityChecker.CheckFunc == null) ? (identityChecker.CheckFunc = new Func<Aircraft, bool>(identityChecker.IsDifferentWith)) : identityChecker.CheckFunc).ToList<Aircraft>())
						{
							if (identityChecker.aircraft.GetHorizontalRange(current) < num)
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							list.Add(identityChecker.aircraft);
						}
					}
				}
				foreach (Aircraft current2 in list)
				{
					tankersForMe.Remove(current2);
				}
			}
			bool flag3 = false;
			using (List<Aircraft>.Enumerator enumerator4 = tankersForMe.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					if (enumerator4.Current.GetHorizontalRange(this.m_ActiveUnit) < num)
					{
						flag3 = true;
						break;
					}
				}
			}
			bool result;
			if (!flag3)
			{
				result = false;
			}
			else
			{
				bool flag4 = false;
				using (List<Aircraft>.Enumerator enumerator5 = tankersForMe.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						if (enumerator5.Current.GetHorizontalRange(contact_8) < float_1)
						{
							flag4 = true;
							break;
						}
					}
				}
				result = flag4;
			}
			return result;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000A456C File Offset: 0x000A276C
		public bool method_20(Aircraft aircraft_0, Contact contact_8, int int_1, int int_2, Doctrine._UseRefuel? UseRefuelDoc, bool bool_6, ref string string_1)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(contact_8))
				{
					string_1 = "The target does not exist!";
					result = false;
				}
				else
				{
					float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(contact_8);
					if (int_2 != 0 && horizontalRange > (float)int_2)
					{
						string_1 = string.Concat(new string[]
						{
							"The mission is configured to not launch for targets beyond ",
							Conversions.ToString(int_2),
							" nm while the distance to the target is ",
							Conversions.ToString((int)Math.Round((double)horizontalRange)),
							" nm."
						});
						result = false;
					}
					else if (int_1 != 0 && horizontalRange < (float)int_1)
					{
						string_1 = string.Concat(new string[]
						{
							"The mission is configured to not launch for targets closer than ",
							Conversions.ToString(int_1),
							" nm while the distance to the target is ",
							Conversions.ToString((int)Math.Round((double)horizontalRange)),
							" nm."
						});
						result = false;
					}
					else
					{
						float num = aircraft_0.GetAircraftKinematics().vmethod_22();
						Weapon aAWWeapon_RangeMax = aircraft_0.GetAircraftWeaponry().GetAAWWeapon_RangeMax();
						if (!Information.IsNothing(aAWWeapon_RangeMax))
						{
							num += aAWWeapon_RangeMax.RangeAAWMax;
						}
						if (horizontalRange < num)
						{
							result = true;
						}
						else if (!aircraft_0.BoomRefuelling && !aircraft_0.ProbeRefuelling)
						{
							string_1 = "The target is out of range.";
							result = false;
						}
						else
						{
							byte? b = UseRefuelDoc.HasValue ? new byte?((byte)UseRefuelDoc.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								string_1 = "The mission is configured to NOT use air-to-air refuelling and the target is out of range.";
								result = false;
							}
							else
							{
								float value = 0f;
								if (!bool_6)
								{
									Aircraft_Navigator aircraftNavigator = aircraft_0.GetAircraftNavigator();
									bool flag = false;
									value = aircraftNavigator.GetTransitAltitude(ref flag);
								}
								if (!bool_6 && !this.method_19(aircraft_0, contact_8, (float)aircraft_0.GetLoadout().CombatRadius, new float?(value)))
								{
									string_1 = string.Concat(new string[]
									{
										"The mission is configured to use air-to-air refuelling. However there is no tanker available within reasonable reach. The tanker must be located between the interceptor's take-off location and the target, within tactical radius of the target (",
										Conversions.ToString(aircraft_0.GetLoadout().CombatRadius),
										"nm), or within range of the interceptor's take-off location (",
										Conversions.ToString(aircraft_0.GetAircraftKinematics().vmethod_20(false, null, new float?(value))),
										"nm)."
									});
									result = false;
								}
								else
								{
									result = true;
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
				ex2.Data.Add("Error at 101249", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000A4824 File Offset: 0x000A2A24
		public float GetWeaponRangeMax(ref Aircraft aircraft_, ref Strike.StrikeType strikeType_)
		{
			float num;
			float result;
			switch (strikeType_)
			{
			case Strike.StrikeType.Land_Strike:
			{
				Weapon weapon = aircraft_.GetAircraftWeaponry().GetLandWeapon_RangeMax(false);
				if (!Information.IsNothing(weapon))
				{
					num = weapon.RangeLandMax;
					result = num;
					return result;
				}
				break;
			}
			case Strike.StrikeType.Maritime_Strike:
			{
				Weapon weapon = aircraft_.GetAircraftWeaponry().GetASUWWeapon_RangeMax(false);
				if (!Information.IsNothing(weapon))
				{
					num = weapon.RangeASUWMax;
					result = num;
					return result;
				}
				break;
			}
			case Strike.StrikeType.Sub_Strike:
			{
				Weapon weapon = aircraft_.GetAircraftWeaponry().GetASWWeapon_RangeMax();
				if (!Information.IsNothing(weapon))
				{
					num = weapon.RangeASWMax;
					result = num;
					return result;
				}
				break;
			}
			}
			num = 0f;
			result = num;
			return result;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000A48BC File Offset: 0x000A2ABC
		public bool method_22(ref Mission.Flight theFlight_, ref Aircraft aircraft_, ref Contact theTarget_, ref Strike.StrikeType strikeType_, int int_1, int int_2, Doctrine._UseRefuel? useRefuel_, bool bool_6, Mission._RadarBehaviour radarBehaviour_, bool bool_7, bool bool_8, bool bool_9, bool bool_10, ref float float_1, ref string string_1, ref Mission mission_)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(theTarget_))
				{
					string_1 = "The target does not exist!";
					result = false;
				}
				else if (Information.IsNothing(strikeType_))
				{
					result = false;
				}
				else
				{
					float horizontalRange = aircraft_.GetHorizontalRange(theTarget_);
					if (int_2 != 0 && horizontalRange > (float)int_2)
					{
						if (theFlight_.GetWaypoint1().Count<Waypoint>() > 0)
						{
							Mission.Flight flight = theFlight_;
							Waypoint[] waypoint_ = flight.GetWaypoint1();
							ScenarioArrayUtil.ClearWaypoints(ref waypoint_);
							flight.SetWaypoint1(waypoint_);
						}
						string_1 = string.Concat(new string[]
						{
							"The mission is configured to not strike targets beyond ",
							Conversions.ToString(int_2),
							" nm while the distance to the target is ",
							Conversions.ToString((int)Math.Round((double)horizontalRange)),
							" nm. No flightplan has been generated and the mission will not launch."
						});
						result = false;
					}
					else if (int_1 != 0 && horizontalRange < (float)int_1)
					{
						if (theFlight_.GetWaypoint1().Count<Waypoint>() > 0)
						{
							Mission.Flight flight2 = theFlight_;
							Waypoint[] waypoint_ = flight2.GetWaypoint1();
							ScenarioArrayUtil.ClearWaypoints(ref waypoint_);
							flight2.SetWaypoint1(waypoint_);
						}
						string_1 = string.Concat(new string[]
						{
							"The mission is configured to not strike targets closer than ",
							Conversions.ToString(int_1),
							" nm while the distance to the target is ",
							Conversions.ToString((int)Math.Round((double)horizontalRange)),
							" nm. No flightplan has been generated and the mission will not launch."
						});
						result = false;
					}
					else
					{
						float weaponRangeMax = this.GetWeaponRangeMax(ref aircraft_, ref strikeType_);
						bool flag = false;
						if (aircraft_.GetLoadout().CombatRadius > 0 && aircraft_.GetLoadout().TimeOnStation_Minutes == 0)
						{
							flag = true;
						}
						if (flag)
						{
							if (horizontalRange <= (float)aircraft_.GetLoadout().CombatRadius + weaponRangeMax)
							{
								result = StrikePlanner.CreateFlightplan(ref theFlight_, ref aircraft_, null, theTarget_, radarBehaviour_, ref bool_7, bool_8, bool_9, bool_10, ref float_1, ref string_1, ref mission_);
							}
							else if (!aircraft_.BoomRefuelling && !aircraft_.ProbeRefuelling)
							{
								string_1 = "The target is out of range.";
								result = false;
							}
							else
							{
								byte? b = useRefuel_.HasValue ? new byte?((byte)useRefuel_.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									if (theFlight_.GetWaypoint1().Count<Waypoint>() > 0)
									{
										Mission.Flight flight3 = theFlight_;
										Waypoint[] waypoint_ = flight3.GetWaypoint1();
										ScenarioArrayUtil.ClearWaypoints(ref waypoint_);
										flight3.SetWaypoint1(waypoint_);
									}
									string_1 = "The mission is configured to NOT use air-to-air refuelling and the target is out of range. No flightplan has been generated and the mission will not launch.";
									result = false;
								}
								else
								{
									float value = 0f;
									if (!bool_6)
									{
										Aircraft_Navigator aircraftNavigator = aircraft_.GetAircraftNavigator();
										bool flag2 = false;
										value = aircraftNavigator.GetTransitAltitude(ref flag2);
									}
									if (!bool_6 && !this.method_19(aircraft_, theTarget_, (float)aircraft_.GetLoadout().CombatRadius, new float?(value)))
									{
										if (theFlight_.GetWaypoint1().Count<Waypoint>() > 0)
										{
											Mission.Flight flight4 = theFlight_;
											Waypoint[] waypoint_ = flight4.GetWaypoint1();
											ScenarioArrayUtil.ClearWaypoints(ref waypoint_);
											flight4.SetWaypoint1(waypoint_);
										}
										string_1 = string.Concat(new string[]
										{
											"The mission is configured to use air-to-air refuelling. However there is no tanker available within reasonable reach. The tanker must be located between the strike aircraft's take-off location and the target, within tactical radius of the target (",
											Conversions.ToString(aircraft_.GetLoadout().CombatRadius),
											" nm), and within range of the strike aircraft's take-off location (",
											Conversions.ToString((int)Math.Round((double)aircraft_.GetAircraftKinematics().vmethod_20(false, null, new float?(value)))),
											" nm). No flightplan has been generated and the mission will not launch."
										});
										result = false;
									}
									else
									{
										result = StrikePlanner.CreateFlightplan(ref theFlight_, ref aircraft_, new bool?(true), theTarget_, radarBehaviour_, ref bool_7, bool_8, bool_9, bool_10, ref float_1, ref string_1, ref mission_);
									}
								}
							}
						}
						else
						{
							float num = aircraft_.GetAircraftKinematics().vmethod_22();
							num += weaponRangeMax;
							if (horizontalRange < num)
							{
								result = StrikePlanner.CreateFlightplan(ref theFlight_, ref aircraft_, null, theTarget_, radarBehaviour_, ref bool_7, bool_8, bool_9, bool_10, ref float_1, ref string_1, ref mission_);
							}
							else if (!aircraft_.BoomRefuelling && !aircraft_.ProbeRefuelling)
							{
								string_1 = "The target is out of range.";
								result = false;
							}
							else
							{
								byte? b = useRefuel_.HasValue ? new byte?((byte)useRefuel_.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									if (theFlight_.GetWaypoint1().Count<Waypoint>() > 0)
									{
										Mission.Flight flight5 = theFlight_;
										Waypoint[] waypoint_ = flight5.GetWaypoint1();
										ScenarioArrayUtil.ClearWaypoints(ref waypoint_);
										flight5.SetWaypoint1(waypoint_);
									}
									string_1 = "The mission is configured to NOT use air-to-air refuelling and the target is out of range. No flightplan has been generated and the mission will not launch.";
									result = false;
								}
								else
								{
									float value2 = 0f;
									if (!bool_6)
									{
										Aircraft_Navigator aircraftNavigator2 = aircraft_.GetAircraftNavigator();
										bool flag2 = false;
										value2 = aircraftNavigator2.GetTransitAltitude(ref flag2);
									}
									if (!bool_6 && !this.method_19(aircraft_, theTarget_, (float)aircraft_.GetLoadout().CombatRadius, new float?(value2)))
									{
										if (theFlight_.GetWaypoint1().Count<Waypoint>() > 0)
										{
											Mission.Flight flight6 = theFlight_;
											Waypoint[] waypoint_ = flight6.GetWaypoint1();
											ScenarioArrayUtil.ClearWaypoints(ref waypoint_);
											flight6.SetWaypoint1(waypoint_);
										}
										string_1 = string.Concat(new string[]
										{
											"The mission is configured to use air-to-air refuelling. However there is no tanker available within reasonable reach. The tanker must be located between the strike aircraft's take-off location and the target, within tactical radius of the target (",
											Conversions.ToString(aircraft_.GetLoadout().CombatRadius),
											" nm), and within range of the strike aircraft's take-off location (",
											Conversions.ToString((int)Math.Round((double)aircraft_.GetAircraftKinematics().vmethod_20(false, null, new float?(value2)))),
											" nm). No flightplan has been generated and the mission will not launch."
										});
										result = false;
									}
									else
									{
										result = StrikePlanner.CreateFlightplan(ref theFlight_, ref aircraft_, new bool?(true), theTarget_, radarBehaviour_, ref bool_7, bool_8, bool_9, bool_10, ref float_1, ref string_1, ref mission_);
									}
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
				ex2.Data.Add("Error at 100399", "");
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

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000A4EE4 File Offset: 0x000A30E4
		public bool method_23(ref Strike strike_, Misc.PostureStance postureStance_)
		{
			bool result = false;
			if (Information.IsNothing(postureStance_))
			{
				result = false;
			}
			else
			{
				switch (strike_.MinimumContactStanceToTrigger)
				{
				case Misc.PostureStance.Unfriendly:
					result = (postureStance_ == Misc.PostureStance.Hostile || postureStance_ == Misc.PostureStance.Unfriendly);
					break;
				case Misc.PostureStance.Hostile:
					result = (postureStance_ == Misc.PostureStance.Hostile);
					break;
				case Misc.PostureStance.Unknown:
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000A4F40 File Offset: 0x000A3140
		public void DropTargetFromMySide(ref Contact contact_, ref Side side_)
		{
			try
			{
				if (Information.IsNothing(this.m_ActiveUnit) || side_ == this.m_ActiveUnit.GetSide(false))
				{
					if (!Information.IsNothing(this.GetTargets()) && this.GetTargets().Contains(contact_))
					{
						this.DropTargeting(contact_, true);
					}
					if (!Information.IsNothing(this.Threats) && this.Threats.Contains(contact_))
					{
						this.RemoveThreat(contact_);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100031", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000A5018 File Offset: 0x000A3218
		public void ClearPrimaryTarget(ref ActiveUnit activeUnit_)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					if (!activeUnit_.IsWeapon)
					{
						Side side = this.m_ActiveUnit.GetSide(false);
						ActiveUnit activeUnit = this.m_ActiveUnit;
						Contact contact = null;
						WeaponSalvo weaponSalvo = null;
						side.RemoveWeaponSalvoForTarget(ref activeUnit.m_Scenario, ref this.m_ActiveUnit, ref contact, ref weaponSalvo);
					}
					this.GetTargetList().Clear();
					this.SetPrimaryTarget(null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200327", ex2.Message);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				GameGeneral.LogException(ref ex2);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00011293 File Offset: 0x0000F493
		public void AddThreats()
		{
			ScenarioArrayUtil.NewContactArray(ref this.Threats);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x000A50D0 File Offset: 0x000A32D0
		public bool method_27(Contact contact_, ActiveUnit activeUnit_, int int_1)
		{
			bool flag = false;
			bool result;
			try
			{
				if (contact_.contactType != Contact_Base.ContactType.Aimpoint && contact_.contactType != Contact_Base.ContactType.ActivationPoint)
				{
					if (contact_.GetPostureStance(activeUnit_.GetSide(false)) == Misc.PostureStance.Friendly || contact_.GetPostureStance(activeUnit_.GetSide(false)) == Misc.PostureStance.Neutral)
					{
						flag = false;
						result = false;
						return result;
					}
					float horizontalRange = activeUnit_.GetHorizontalRange(contact_);
					float num = 0f;
					switch (activeUnit_.GetUnitType())
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
					case GlobalVariables.ActiveUnitType.Weapon:
						num = (float)Math.Min(1.5 * (double)contact_.GetAirRangeMax().GetValueOrDefault(), (double)int_1);
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						num = (float)Math.Min(1.5 * (double)contact_.GetSurfaceRangeMax().GetValueOrDefault(), (double)int_1);
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						num = (float)Math.Min(1.5 * (double)contact_.GetSubsurfaceRangeMax().GetValueOrDefault(), (double)int_1);
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						num = (float)Math.Min(1.5 * (double)contact_.GetLandRangeMax().GetValueOrDefault(), (double)int_1);
						break;
					case GlobalVariables.ActiveUnitType.Aimpoint:
						flag = false;
						result = false;
						return result;
					}
					if (horizontalRange < num)
					{
						flag = true;
						result = true;
						return result;
					}
					if (contact_.contactType == Contact_Base.ContactType.Air)
					{
						if (int_1 > 0)
						{
							if (horizontalRange < (float)int_1 && activeUnit_.GetDesiredSpeed(contact_, this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading()) > 0f)
							{
								flag = true;
								result = true;
								return result;
							}
						}
						else if (horizontalRange < 30f && activeUnit_.GetDesiredSpeed(contact_, this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading()) > 0f)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					try
					{
						if ((contact_.IsFixed() || contact_.IsSurface()) && horizontalRange < (float)int_1 && contact_.HasEmissionContainer())
						{
							foreach (KeyValuePair<int, EmissionContainer> current in contact_.GetEmissionContainerObDictionary())
							{
								Sensor sensor = current.Value.method_0(current.Key, this.m_ActiveUnit.m_Scenario);
								if (sensor.NonSearchAndTrackSensorOtherThanMCMAndMAD() || sensor.IsFireControlRadar())
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200275", ex2.Message);
						bool arg_28E_0 = Debugger.IsAttached;
						GameGeneral.LogException(ref ex2);
						ProjectData.ClearProjectError();
					}
					flag = false;
					result = false;
					return result;
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100033", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000A5414 File Offset: 0x000A3614
		private void PickPrimaryTarget(Contact[] Targets)
		{
			List<Contact> list = Targets.Where(new Func<Contact, bool>(this.HasWeaponsToAttackTargetNow)).OrderBy(new Func<Contact, float>(this.GetHorizontalRange)).ToList<Contact>();
			if (list.Count > 0)
			{
				this.SetPrimaryTarget(list[0]);
			}
			else
			{
				this.SetPrimaryTarget(null);
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000A5470 File Offset: 0x000A3670
		public bool method_29(Contact contact_)
		{
			bool flag;
			bool result;
			if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
			{
				flag = false;
			}
			else if (Information.IsNothing(contact_.ActualUnit))
			{
				flag = false;
			}
			else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike)
			{
				flag = false;
			}
			else if (this.m_ActiveUnit.IsAircraft && !((Aircraft)this.m_ActiveUnit).GetAircraftAI().method_100(contact_))
			{
				flag = false;
			}
			else
			{
				Weapon aAWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax();
				Weapon landWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false);
				Weapon aSUWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false);
				Weapon aSWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax();
				int num = 0;
				if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
				{
					num = ((Strike)this.m_ActiveUnit.GetAssignedMission(false)).Escort_ResponseRadius;
				}
				ActiveUnit[] array = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToArray<ActiveUnit>();
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					ActiveUnit activeUnit = array[i];
					if (activeUnit.IsOperating() && !activeUnit.IsGroup && !Information.IsNothing(activeUnit.GetAssignedMission(false)) && activeUnit.GetAssignedMission(false) == this.m_ActiveUnit.GetAssignedMission(false) && !activeUnit.GetAI().IsEscort)
					{
						switch (contact_.contactType)
						{
						case Contact_Base.ContactType.Air:
							if (!Information.IsNothing(aAWWeapon_RangeMax) && activeUnit.GetSlantRange(contact_, 0f) < Math.Min((float)contact_.method_72() * aAWWeapon_RangeMax.RangeAAWMax, (float)num))
							{
								result = true;
								return result;
							}
							break;
						case Contact_Base.ContactType.Surface:
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Mine:
							if (!Information.IsNothing(aSUWWeapon_RangeMax) && activeUnit.GetHorizontalRange(contact_) < Math.Min((float)contact_.method_72() * aSUWWeapon_RangeMax.RangeASUWMax, (float)num))
							{
								result = true;
								return result;
							}
							break;
						case Contact_Base.ContactType.Submarine:
							if (!Information.IsNothing(aSWWeapon_RangeMax) && activeUnit.GetHorizontalRange(contact_) < Math.Min((float)contact_.method_72() * aSWWeapon_RangeMax.RangeASWMax, (float)num))
							{
								result = true;
								return result;
							}
							break;
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							if (!Information.IsNothing(landWeapon_RangeMax) && activeUnit.GetHorizontalRange(contact_) < Math.Min((float)contact_.method_72() * landWeapon_RangeMax.RangeLandMax, (float)num))
							{
								result = true;
								return result;
							}
							break;
						}
						if (this.method_27(contact_, activeUnit, num))
						{
							result = true;
							return result;
						}
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x000A5750 File Offset: 0x000A3950
		public bool IsOnPatrolStation()
		{
			bool result;
			if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
			{
				result = false;
			}
			else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Patrol)
			{
				result = false;
			}
			else
			{
				Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
				result = this.m_ActiveUnit.GetNavigator().IsOnStation(ref patrol.PatrolAreaVertices, ref patrol.list_13, ref patrol.list_9, 10, false, false);
			}
			return result;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000A57D0 File Offset: 0x000A39D0
		public bool method_31()
		{
			bool result;
			if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
			{
				result = false;
			}
			else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Patrol)
			{
				result = false;
			}
			else
			{
				Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
				ActiveUnit_Navigator navigator = this.m_ActiveUnit.GetNavigator();
				Patrol patrol2 = patrol;
				List<ReferencePoint> list = null;
				result = navigator.IsOnStation(ref patrol2.PatrolAreaVertices, ref list, ref patrol.list_6, 0, false, false);
			}
			return result;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000A5850 File Offset: 0x000A3A50
		public bool IsTargetForMission(Contact theContact, Mission mission_, Doctrine._ShootTourists? ShootTouristsDoc_, bool bool_6, bool OnPatrolStation_, bool bool_8, ref string feedback, ref int int_1)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(mission_))
				{
					if (int_1 < 1)
					{
						feedback = "没有发现任务!";
						int_1 = 1;
					}
					flag = false;
				}
				else if (Information.IsNothing(theContact.ActualUnit))
				{
					if (int_1 < 1)
					{
						feedback = "目标的实际单元不存在！";
						int_1 = 1;
					}
					flag = false;
				}
				else
				{
					Side side = this.m_ActiveUnit.GetSide(false);
					string guid = theContact.GetGuid();
					Misc.PostureStance postureStance;
					if (!this.PostureStanceDictionary.TryGetValue(guid, out postureStance))
					{
						postureStance = theContact.GetPostureStance(side);
						this.PostureStanceDictionary.Add(guid, postureStance);
					}
					if (postureStance == Misc.PostureStance.Friendly)
					{
						if (int_1 < 2)
						{
							feedback = "目标为友方.";
							int_1 = 2;
						}
						flag = false;
					}
					else if (bool_8 && postureStance == Misc.PostureStance.Neutral)
					{
						if (int_1 < 3)
						{
							feedback = "目标为中立方.";
							int_1 = 3;
						}
						flag = false;
					}
					else
					{
						if (this.m_ActiveUnit.GetUnitType() == GlobalVariables.ActiveUnitType.Aircraft)
						{
							foreach (NoNavZone current in side.NoNavZoneList)
							{
								if (current.Area.Count != 0 && current.IsAffected(this.m_ActiveUnit) && theContact.vmethod_40(current.Area, this.m_ActiveUnit.m_Scenario, true))
								{
									if (int_1 < 4)
									{
										feedback = "目标处于禁航区内";
										int_1 = 4;
									}
									flag = false;
									result = false;
									return result;
								}
							}
						}
						Mission._MissionClass missionClass = mission_.MissionClass;
						if (missionClass != Mission._MissionClass.Strike)
						{
							if (missionClass == Mission._MissionClass.Patrol)
							{
								byte? b = ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									switch (((Patrol)mission_).patrolType)
									{
									case GlobalVariables.PatrolType.ASW:
									{
										Contact_Base.ContactType contactType = theContact.contactType;
										if (contactType - Contact_Base.ContactType.Submarine > 1)
										{
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										break;
									}
									case GlobalVariables.PatrolType.ASuW_Naval:
									{
										Contact_Base.ContactType contactType2 = theContact.contactType;
										if (contactType2 != Contact_Base.ContactType.Surface && contactType2 != Contact_Base.ContactType.UndeterminedNaval)
										{
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										break;
									}
									case GlobalVariables.PatrolType.AAW:
									{
										Contact_Base.ContactType contactType3 = theContact.contactType;
										if (contactType3 != Contact_Base.ContactType.Air)
										{
											if (contactType3 != Contact_Base.ContactType.Missile)
											{
												if (contactType3 != Contact_Base.ContactType.Orbital)
												{
													if (int_1 < 5)
													{
														feedback = "没有发现相应目标类型。";
														int_1 = 5;
													}
													flag = false;
													result = false;
													return result;
												}
												if (this.m_ActiveUnit.IsAircraft && ((Aircraft)this.m_ActiveUnit).GetLoadout().loadoutRole != Loadout.LoadoutRole.AntiSatellite_Intercept)
												{
													flag = false;
													result = false;
													return result;
												}
											}
											else if (((Weapon)theContact.ActualUnit).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
											{
												if (int_1 < 5)
												{
													feedback = "没有发现相应目标类型。";
													int_1 = 5;
												}
												flag = false;
												result = false;
												return result;
											}
										}
										break;
									}
									case GlobalVariables.PatrolType.ASuW_Land:
									{
										Contact_Base.ContactType contactType4 = theContact.contactType;
										if (contactType4 != Contact_Base.ContactType.Aimpoint && contactType4 - Contact_Base.ContactType.Facility_Fixed > 1)
										{
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										break;
									}
									case GlobalVariables.PatrolType.ASuW_Mixed:
										switch (theContact.contactType)
										{
										case Contact_Base.ContactType.Surface:
										case Contact_Base.ContactType.UndeterminedNaval:
										case Contact_Base.ContactType.Aimpoint:
										case Contact_Base.ContactType.Facility_Fixed:
										case Contact_Base.ContactType.Facility_Mobile:
											break;
										case Contact_Base.ContactType.Submarine:
										case Contact_Base.ContactType.Orbital:
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										default:
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										break;
									case GlobalVariables.PatrolType.SEAD:
									{
										float? num = theContact.GetMaxRange();
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() < 10f) : null).GetValueOrDefault())
										{
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型(对空搜索雷达探测距离大于10海里).";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										switch (theContact.GetIdentificationStatus())
										{
										case Contact_Base.IdentificationStatus.Unknown:
										case Contact_Base.IdentificationStatus.KnownDomain:
											flag = false;
											result = false;
											return result;
										case Contact_Base.IdentificationStatus.KnownType:
											if (theContact.ActualUnit.IsFacility)
											{
												Facility._MobileUnitCategory mobileUnitCategory = ((Facility)theContact.ActualUnit).GetMobileUnitCategory();
												if (mobileUnitCategory - Facility._MobileUnitCategory.AAA > 1)
												{
													if (int_1 < 6)
													{
														feedback = "没有发现相应目标类型。";
														int_1 = 6;
													}
													flag = false;
													result = false;
													return result;
												}
											}
											break;
										case Contact_Base.IdentificationStatus.KnownClass:
										case Contact_Base.IdentificationStatus.PreciseID:
											num = theContact.GetAirRangeMax();
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() < 1f) : null).GetValueOrDefault())
											{
												num = theContact.GetMaxRange();
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() < 10f) : null).GetValueOrDefault())
												{
													if (int_1 < 6)
													{
														feedback = "没有发现相应目标类型。";
														int_1 = 6;
													}
													flag = false;
													result = false;
													return result;
												}
											}
											break;
										}
										if (!OnPatrolStation_)
										{
											Weapon maxRangeWeaponFor = this.m_ActiveUnit.GetWeaponry().GetMaxRangeWeaponFor(theContact);
											if (Information.IsNothing(maxRangeWeaponFor))
											{
												if (int_1 < 6)
												{
													feedback = "没有发现相应目标类型。";
													int_1 = 6;
												}
												flag = false;
												result = false;
												return result;
											}
											if ((double)this.m_ActiveUnit.GetHorizontalRange(theContact) > (double)maxRangeWeaponFor.GetMaxRangeToTarget(this.m_ActiveUnit, theContact, true, this.m_ActiveUnit.m_Doctrine, false) * 1.5)
											{
												if (int_1 < 6)
												{
													feedback = "没有发现相应目标类型。";
													int_1 = 6;
												}
												flag = false;
												result = false;
												return result;
											}
										}
										break;
									}
									case GlobalVariables.PatrolType.SeaControl:
									{
										Contact_Base.ContactType contactType5 = theContact.contactType;
										if (contactType5 - Contact_Base.ContactType.Surface > 2)
										{
											if (int_1 < 5)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										break;
									}
									}
								}
								else
								{
									ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
									Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
									string text = "";
									int num2 = 0;
									if (!weaponry.HasWeaponsInConditionToAttackTarget(theContact, true, doctrine, ref text, ref num2, null))
									{
										if (!this.m_ActiveUnit.IsAircraft)
										{
											if (int_1 < 5)
											{
												feedback = "没有现有武器可以打击的目标.";
												int_1 = 5;
											}
											flag = false;
											result = false;
											return result;
										}
										Aircraft aircraft = (Aircraft)this.m_ActiveUnit;
										if (Information.IsNothing(aircraft.GetLoadout()))
										{
											if (int_1 < 6)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 6;
											}
											flag = false;
											result = false;
											return result;
										}
										bool arg_773_0;
										if (aircraft.GetLoadout().loadoutRole != Loadout.LoadoutRole.Maritime_Surveillance || theContact.contactType != Contact_Base.ContactType.Surface)
										{
											if (aircraft.GetLoadout().loadoutRole == Loadout.LoadoutRole.ASW_Patrol)
											{
												if (theContact.contactType == Contact_Base.ContactType.Surface)
												{
													goto IL_754;
												}
											}
											arg_773_0 = (aircraft.GetLoadout().loadoutRole == Loadout.LoadoutRole.Area_Surveillance && theContact.IsFixed());
											goto IL_773;
										}
										IL_754:
										arg_773_0 = true;
										IL_773:
										if (!arg_773_0)
										{
											if (int_1 < 6)
											{
												feedback = "没有发现相应目标类型。";
												int_1 = 6;
											}
											flag = false;
											result = false;
											return result;
										}
									}
								}
								Patrol patrol = (Patrol)mission_;
								if (!((Patrol)mission_).method_43(this.m_ActiveUnit.m_Scenario))
								{
									if (!theContact.vmethod_40(patrol.PatrolAreaVertices, this.m_ActiveUnit.m_Scenario, true))
									{
										if (int_1 < 7)
										{
											feedback = "巡逻区内没有发现相应目标类型.";
											int_1 = 7;
										}
										flag = false;
										result = false;
										return result;
									}
								}
								else if (patrol.method_42() && !theContact.vmethod_40(patrol.PatrolAreaVertices, this.m_ActiveUnit.m_Scenario, true) && !theContact.vmethod_40(patrol.ProsecutionAreaVertices, this.m_ActiveUnit.m_Scenario, true))
								{
									if (int_1 < 7)
									{
										feedback = "警戒区内没有发现相应目标类型.";
										int_1 = 7;
									}
									flag = false;
									result = false;
									return result;
								}
								flag = true;
								result = true;
								return result;
							}
						}
						else if (this.IsEscort)
						{
							if (this.m_ActiveUnit.IsAircraft)
							{
								bool flag2 = ((Aircraft)this.m_ActiveUnit).GetAircraftAI().method_100(theContact);
								byte? b = ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && flag2)
								{
									flag = true;
									result = true;
									return result;
								}
								if (!flag2)
								{
									if (int_1 < 5)
									{
										feedback = "没有与此护航飞机挂载方案相匹配的目标。";
										int_1 = 5;
									}
									flag = false;
									result = false;
									return result;
								}
							}
							int i = side.ActiveUnitArray.Length - 1;
							while (i >= 0)
							{
								ActiveUnit activeUnit = null;
								try
								{
									activeUnit = side.ActiveUnitArray[i];
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
									i += -1;
									continue;
								}
								if (activeUnit.IsGroup || activeUnit.GetAI().IsEscort)
								{
									i += -1;
								}
								else
								{
									Mission assignedMission = activeUnit.GetAssignedMission(false);
									if (!Information.IsNothing(assignedMission) && assignedMission == mission_ && activeUnit.IsOperating() && this.method_27(theContact, activeUnit, ((Strike)mission_).Escort_ResponseRadius))
									{
										flag = true;
										result = true;
										return result;
									}
									i += -1;
								}
							}
						}
						else
						{
							Strike strike = (Strike)mission_;
							if (!bool_6 && !this.method_23(ref strike, postureStance))
							{
								if (int_1 < 6)
								{
									feedback = "没有发现相应关系属性的目标。";
									int_1 = 6;
								}
								flag = false;
								result = false;
								return result;
							}
							switch (((Strike)mission_).strikeType)
							{
							case Strike.StrikeType.Air_Intercept:
							{
								Contact_Base.ContactType contactType6 = theContact.contactType;
								if (contactType6 == Contact_Base.ContactType.Air)
								{
									flag = true;
									result = true;
									return result;
								}
								if (contactType6 == Contact_Base.ContactType.Missile)
								{
									flag = (result = !((Weapon)theContact.ActualUnit).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon());
									return result;
								}
								if (contactType6 != Contact_Base.ContactType.Orbital)
								{
									if (int_1 < 7)
									{
										feedback = "没有发现与任务类型(空中截击)相关的目标.";
										int_1 = 7;
									}
									flag = false;
									result = false;
									return result;
								}
								if (this.m_ActiveUnit.IsAircraft && ((Aircraft)this.m_ActiveUnit).GetLoadout().loadoutRole != Loadout.LoadoutRole.AntiSatellite_Intercept)
								{
									flag = false;
									result = false;
									return result;
								}
								break;
							}
							case Strike.StrikeType.Land_Strike:
							{
								Contact_Base.ContactType contactType7 = theContact.contactType;
								if (contactType7 != Contact_Base.ContactType.Aimpoint && contactType7 - Contact_Base.ContactType.Facility_Fixed > 1)
								{
									if (int_1 < 7)
									{
										feedback = "没有发现相应目标类型。";
										int_1 = 7;
									}
									flag = false;
									result = false;
									return result;
								}
								if (strike.SpecificTargets.Count > 0)
								{
									if (theContact.IsSpecificTargetForStikeMission(strike))
									{
										flag = true;
										result = true;
										return result;
									}
									byte? b = ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
										Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
										string text = "";
										int num2 = 0;
										if (!weaponry.HasWeaponsInConditionToAttackTarget(theContact, true, doctrine, ref text, ref num2, null))
										{
											if (int_1 < 8)
											{
												feedback = "没有现有武器可以打击的目标.";
												int_1 = 8;
											}
											flag = false;
											result = false;
											return result;
										}
										b = (ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											flag = true;
											result = true;
											return result;
										}
									}
								}
								else
								{
									if (strike.PrePlannedOnly && strike.SpecificTargets.Count == 0)
									{
										if (int_1 < 9)
										{
											feedback = "本任务只支持对预先规划目标的打击，但目标清单已空。";
											int_1 = 9;
										}
										flag = false;
										result = false;
										return result;
									}
									flag = true;
									result = true;
									return result;
								}
								break;
							}
							case Strike.StrikeType.Maritime_Strike:
							{
								Contact_Base.ContactType contactType8 = theContact.contactType;
								if (contactType8 != Contact_Base.ContactType.Surface && contactType8 - Contact_Base.ContactType.UndeterminedNaval > 1)
								{
									if (int_1 < 7)
									{
										feedback = "没有发现相应目标类型。";
										int_1 = 7;
									}
									flag = false;
									result = false;
									return result;
								}
								if (strike.SpecificTargets.Count > 0)
								{
									if (theContact.IsSpecificTargetForStikeMission(strike))
									{
										flag = true;
										result = true;
										return result;
									}
									byte? b = ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
										Doctrine doctrine2 = this.m_ActiveUnit.m_Doctrine;
										string text = "";
										int num2 = 0;
										if (!weaponry.HasWeaponsInConditionToAttackTarget(theContact, true, doctrine2, ref text, ref num2, null))
										{
											if (int_1 < 8)
											{
												feedback = "没有现有武器可以打击的目标.";
												int_1 = 8;
											}
											flag = false;
											result = false;
											return result;
										}
										b = (ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											flag = true;
											result = true;
											return result;
										}
									}
								}
								else
								{
									if (strike.PrePlannedOnly && strike.SpecificTargets.Count == 0)
									{
										if (int_1 < 9)
										{
											feedback = "本任务只支持对预先规划目标的打击，但目标清单已空。";
											int_1 = 9;
										}
										flag = false;
										result = false;
										return result;
									}
									flag = true;
									result = true;
									return result;
								}
								break;
							}
							case Strike.StrikeType.Sub_Strike:
							{
								Contact_Base.ContactType contactType9 = theContact.contactType;
								if (contactType9 - Contact_Base.ContactType.Submarine > 1)
								{
									if (int_1 < 7)
									{
										feedback = "没有发现相应目标类型。";
										int_1 = 7;
									}
									flag = false;
									result = false;
									return result;
								}
								if (strike.SpecificTargets.Count > 0)
								{
									if (theContact.IsSpecificTargetForStikeMission(strike))
									{
										flag = true;
										result = true;
										return result;
									}
									byte? b = ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										ActiveUnit_Weaponry weaponry2 = this.m_ActiveUnit.GetWeaponry();
										Doctrine doctrine3 = this.m_ActiveUnit.m_Doctrine;
										string text = "";
										int num2 = 0;
										if (!weaponry2.HasWeaponsInConditionToAttackTarget(theContact, true, doctrine3, ref text, ref num2, null))
										{
											if (int_1 < 8)
											{
												feedback = "没有现有武器可以打击的目标.";
												int_1 = 8;
											}
											flag = false;
											result = false;
											return result;
										}
										b = (ShootTouristsDoc_.HasValue ? new byte?((byte)ShootTouristsDoc_.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											flag = true;
											result = true;
											return result;
										}
									}
								}
								else
								{
									if (strike.PrePlannedOnly && strike.SpecificTargets.Count == 0)
									{
										if (int_1 < 9)
										{
											feedback = "本任务只支持对预先规划目标的打击，但目标清单已空。";
											int_1 = 9;
										}
										flag = false;
										result = false;
										return result;
									}
									flag = true;
									result = true;
									return result;
								}
								break;
							}
							}
						}
						if (int_1 < 1)
						{
							feedback = "没有发现相应目标类型。";
							int_1 = 1;
						}
						flag = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100034", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x000112A0 File Offset: 0x0000F4A0
		public void SetFerryCycleLegIsOutbound()
		{
			this.FerryCycleLegIsOutbound = true;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000112A9 File Offset: 0x0000F4A9
		public void SwitchFerryCycleLegIsOutbound()
		{
			this.FerryCycleLegIsOutbound = !this.FerryCycleLegIsOutbound;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x000112BA File Offset: 0x0000F4BA
		public bool method_35()
		{
			return this.m_ActiveUnit.IsMineSweeper();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000112C7 File Offset: 0x0000F4C7
		public bool IsFerryCycleLegIsOutbound()
		{
			return this.FerryCycleLegIsOutbound;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000A6940 File Offset: 0x000A4B40
		public void method_37()
		{
			try
			{
				if (this.GetTargets().Length != 0)
				{
					if (this.GetTargets().Length == 1)
					{
						this.SetPrimaryTarget(this.GetTargets()[0]);
					}
					Contact contact = this.GetTargets().Select(ActiveUnit_AI.ContactFunc3).OrderByDescending(ActiveUnit_AI.ContactFunc4).ToArray<Contact>()[0];
					float? num = contact.GetMaxRange();
					if (!(num.HasValue ? new bool?(num.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
					{
						num = contact.GetAirRangeMax();
						if (!(num.HasValue ? new bool?(num.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
						{
							goto IL_C8;
						}
					}
					this.SetPrimaryTarget(contact);
				}
				IL_C8:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100035", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000A6A64 File Offset: 0x000A4C64
		private HashSet<Contact> GetTargetSet()
		{
			return new HashSet<Contact>(this.GetTargets());
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000A6A80 File Offset: 0x000A4C80
		private void method_39()
		{
			try
			{
				int num = this.m_ActiveUnit.GetSide(false).WeaponSalvos.Length;
				if (num > 0)
				{
					Lazy<HashSet<Contact>> lazy = new Lazy<HashSet<Contact>>(new Func<HashSet<Contact>>(this.GetTargetSet));
					int i = num - 1;
					while (i >= 0)
					{
						WeaponSalvo weaponSalvo;
						try
						{
							if (this.m_ActiveUnit.GetSide(false).WeaponSalvos.Length == 0)
							{
								i += -1;
								continue;
							}
							if (this.m_ActiveUnit.GetSide(false).WeaponSalvos.Length - 1 < i)
							{
								i = this.m_ActiveUnit.GetSide(false).WeaponSalvos.Length - 1;
							}
							weaponSalvo = this.m_ActiveUnit.GetSide(false).WeaponSalvos[i];
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200425", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
							i += -1;
							continue;
						}
						if (Information.IsNothing(weaponSalvo) || Information.IsNothing(weaponSalvo.m_Shooters))
						{
							i += -1;
						}
						else
						{
							int num2 = weaponSalvo.m_Shooters.Length;
							if (num2 > 0)
							{
								int j = num2 - 1;
								while (j >= 0)
								{
									WeaponSalvo.Shooter shooter;
									try
									{
										if (weaponSalvo.m_Shooters.Length == 0)
										{
											j += -1;
											continue;
										}
										if (weaponSalvo.m_Shooters.Length - 1 < j)
										{
											j = weaponSalvo.m_Shooters.Length - 1;
										}
										shooter = weaponSalvo.m_Shooters[j];
									}
									catch (Exception ex3)
									{
										ProjectData.SetProjectError(ex3);
										Exception ex4 = ex3;
										ex4.Data.Add("Error at 200426", ex4.Message);
										GameGeneral.LogException(ref ex4);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										ProjectData.ClearProjectError();
										j += -1;
										continue;
									}
									if (Information.IsNothing(shooter) || Operators.CompareString(shooter.ShooterObjectID, this.m_ActiveUnit.GetGuid(), false) != 0 || shooter.QuantityAssigned <= shooter.QuantityFired || lazy.Value.Contains(weaponSalvo.Target))
									{
										j += -1;
									}
									else
									{
										ActiveUnit_AI.TargetingEntry targetingEntry = new ActiveUnit_AI.TargetingEntry();
										targetingEntry.Target = weaponSalvo.Target;
										targetingEntry.SetTargetingBehavior(ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc);
										if (!this.GetTargetList().ContainsKey(targetingEntry.Target.GetGuid()))
										{
											this.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
											this.ExportEngagementCycle("Targeting Contact", targetingEntry.Target, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit.m_Scenario, "OODA: " + Conversions.ToString(this.GetOODAReactionTime(targetingEntry.Target)) + "s");
										}
										j += -1;
									}
								}
								i += -1;
							}
							else
							{
								i += -1;
							}
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 200640", ex6.Message);
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000A6E04 File Offset: 0x000A5004
		public virtual void TargetingContacts(float elapsedTime_, bool bool_6, bool bool_7)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.m_ActiveUnit))
					{
						this.method_39();
						this.IsOnPatrolStation();
						if (!Information.IsNothing(this.GetPrimaryTarget()))
						{
							if (this.GetPrimaryTarget().IsDestroyed(this.m_ActiveUnit.m_Scenario))
							{
								this.DropTargeting(this.GetPrimaryTarget(), true);
							}
							else if (this.GetPrimaryTarget().contactType == Contact_Base.ContactType.Aimpoint || this.GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint)
							{
								Side side = this.m_ActiveUnit.GetSide(false);
								Contact primaryTarget = this.GetPrimaryTarget();
								bool flag = side.GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref primaryTarget) != 0;
								this.SetPrimaryTarget(primaryTarget);
								if (!flag)
								{
									this.DropTargeting(this.GetPrimaryTarget(), true);
								}
							}
						}
						bool flag2 = !Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol && ((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).method_43(this.m_ActiveUnit.m_Scenario);
						if (this.GetTargets().Length > 0)
						{
							List<Contact> list = new List<Contact>();
							Contact[] targets = this.GetTargets();
							for (int i = 0; i < targets.Length; i++)
							{
								Contact contact = targets[i];
								if (!Information.IsNothing(contact))
								{
									if (Information.IsNothing(this.m_ActiveUnit))
									{
										return;
									}
									ActiveUnit_AI.TargetingEntry._TargetingBehavior? targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
									if (contact.IsDestroyed(this.m_ActiveUnit.m_Scenario))
									{
										if (!this.m_ActiveUnit.GetSensory().HasTrackingSensorForTarget(contact))
										{
											list.Add(contact);
											goto IL_10C8;
										}
									}
									else if ((bool_7 || this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) && this.m_ActiveUnit.IsAircraft)
									{
										if (contact.contactType == Contact_Base.ContactType.Submarine)
										{
											ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
											Contact theTarget = contact;
											Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
											string text = "";
											int num = 0;
											if (!weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, null) && contact.GetPostureStance(this.m_ActiveUnit.GetSide(false)) != Misc.PostureStance.Unknown && !this.m_ActiveUnit.GetSensory().HasTrackingSensorForTarget(contact))
											{
												list.Add(contact);
												if (Information.IsNothing(targetingBehavior))
												{
													targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
												}
												byte? b = targetingBehavior.HasValue ? new byte?((byte)targetingBehavior.GetValueOrDefault()) : null;
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													string text2 = "";
													if (Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
													{
														text2 = " (" + this.m_ActiveUnit.UnitClass + ")";
													}
													this.m_ActiveUnit.LogMessage(string.Concat(new string[]
													{
														this.m_ActiveUnit.Name,
														text2,
														"正在将目标： ",
														contact.Name,
														"从目标清单中舍弃(原因：没有可用武器)."
													}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
													goto IL_10C8;
												}
												goto IL_10C8;
											}
										}
										else if (contact.IsSurfaceOrLandTarget())
										{
											if (Information.IsNothing(targetingBehavior))
											{
												targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
											}
											byte? b = targetingBehavior.HasValue ? new byte?((byte)targetingBehavior.GetValueOrDefault()) : null;
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
												Contact theTarget2 = contact;
												Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
												string text = "";
												int num = 0;
												if (!weaponry.HasWeaponsInConditionToAttackTarget(theTarget2, true, doctrine, ref text, ref num, null) && contact.GetPostureStance(this.m_ActiveUnit.GetSide(false)) != Misc.PostureStance.Unknown)
												{
													list.Add(contact);
													string text3 = "";
													if (Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
													{
														text3 = " (" + this.m_ActiveUnit.UnitClass + ")";
													}
													this.m_ActiveUnit.LogMessage(string.Concat(new string[]
													{
														this.m_ActiveUnit.Name,
														text3,
														"正在将目标： ",
														contact.Name,
														"从目标清单中舍弃(原因：没有可用武器)."
													}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
													goto IL_10C8;
												}
											}
										}
									}
									if ((bool_7 || this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) && (!this.m_ActiveUnit.GetNavigator().HasFlightCourse() || this.GetTargets().Count<Contact>() > 1) && this.method_55(contact))
									{
										if (Information.IsNothing(targetingBehavior))
										{
											targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
										}
										byte? b = targetingBehavior.HasValue ? new byte?((byte)targetingBehavior.GetValueOrDefault()) : null;
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											string text4 = "";
											if (this.m_ActiveUnit.IsAircraft && Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
											{
												text4 = " (" + this.m_ActiveUnit.UnitClass + ")";
											}
											this.m_ActiveUnit.LogMessage(string.Concat(new string[]
											{
												this.m_ActiveUnit.Name,
												text4,
												"正在将目标： ",
												contact.Name,
												"从目标清单中舍弃(原因：打击此目标纯属浪费弹药)."
											}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
											list.Add(contact);
											goto IL_10C8;
										}
									}
									Contact_Base.ContactType contactType = contact.contactType;
									if (contactType != Contact_Base.ContactType.Sonobuoy)
									{
										if (unchecked(contactType - Contact_Base.ContactType.Installation) <= 3)
										{
											list.Add(contact);
										}
										else if (contact.IsBiologics())
										{
											list.Add(contact);
										}
										else
										{
											byte? b;
											if (bool_7 || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse)
											{
												Misc.PostureStance postureStance = contact.GetPostureStance(this.m_ActiveUnit.GetSide(false));
												if (postureStance <= Misc.PostureStance.Friendly)
												{
													if (Information.IsNothing(targetingBehavior))
													{
														targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
													}
													ActiveUnit_AI.TargetingEntry._TargetingBehavior? targetingBehavior2 = targetingBehavior;
													b = (targetingBehavior2.HasValue ? new byte?((byte)targetingBehavior2.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														list.Add(contact);
													}
													else
													{
														b = (targetingBehavior2.HasValue ? new byte?((byte)targetingBehavior2.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															list.Add(contact);
														}
														else
														{
															b = (targetingBehavior2.HasValue ? new byte?((byte)targetingBehavior2.GetValueOrDefault()) : null);
															(b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault();
														}
													}
												}
											}
											if ((bool_7 || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && this.m_ActiveUnit.HasAssignedPatrolMission() && !contact.method_98())
											{
												Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
												if (patrol.method_42())
												{
													if (!contact.vmethod_40(patrol.PatrolAreaVertices, this.m_ActiveUnit.m_Scenario, true) && !contact.vmethod_40(patrol.ProsecutionAreaVertices, this.m_ActiveUnit.m_Scenario, true))
													{
														if (Information.IsNothing(targetingBehavior))
														{
															targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
														}
														b = (targetingBehavior.HasValue ? new byte?((byte)targetingBehavior.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() != 1) : null).GetValueOrDefault() && !this.m_ActiveUnit.GetSensory().HasTrackingSensorForTarget(contact))
														{
															list.Add(contact);
															string text5 = "";
															if (this.m_ActiveUnit.IsAircraft && Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
															{
																text5 = " (" + this.m_ActiveUnit.UnitClass + ")";
															}
															this.m_ActiveUnit.LogMessage(string.Concat(new string[]
															{
																this.m_ActiveUnit.Name,
																text5,
																"正在将目标： ",
																contact.Name,
																"从目标清单中舍弃(原因：目标已经脱离巡逻/警戒区)."
															}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
															goto IL_10C8;
														}
													}
												}
												else if (!flag2 && contact.contactType != Contact_Base.ContactType.Missile && !contact.vmethod_40(patrol.PatrolAreaVertices, this.m_ActiveUnit.m_Scenario, true))
												{
													if (Information.IsNothing(targetingBehavior))
													{
														targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
													}
													b = (targetingBehavior.HasValue ? new byte?((byte)targetingBehavior.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() != 1) : null).GetValueOrDefault() && !this.m_ActiveUnit.GetSensory().HasTrackingSensorForTarget(contact))
													{
														list.Add(contact);
														string text6 = "";
														if (this.m_ActiveUnit.IsAircraft && Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
														{
															text6 = " (" + this.m_ActiveUnit.UnitClass + ")";
														}
														this.m_ActiveUnit.LogMessage(string.Concat(new string[]
														{
															this.m_ActiveUnit.Name,
															text6,
															"正在将目标： ",
															contact.Name,
															"从目标清单中舍弃(原因：目标已经脱离巡逻区，没有授权本作战单元到巡逻区外追击目标)."
														}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
														goto IL_10C8;
													}
												}
											}
											if (bool_7 || this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse)
											{
												if (Information.IsNothing(targetingBehavior))
												{
													targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.GetTargetingBehavior(contact));
												}
												b = (targetingBehavior.HasValue ? new byte?((byte)targetingBehavior.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && this.m_ActiveUnit.GetSide(false).GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref contact) == 0 && contact.method_92().Length == 0)
												{
													list.Add(contact);
													string text7 = "";
													if (this.m_ActiveUnit.IsAircraft && Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
													{
														text7 = " (" + this.m_ActiveUnit.UnitClass + ")";
													}
													if (contact.contactType != Contact_Base.ContactType.Aimpoint && contact.contactType != Contact_Base.ContactType.ActivationPoint)
													{
														this.m_ActiveUnit.LogMessage(string.Concat(new string[]
														{
															this.m_ActiveUnit.Name,
															text7,
															"正在将目标： ",
															contact.Name,
															"从目标清单中舍弃(原因：本目标不能自动瞄准，不存在相应的武器或者分配)."
														}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
														goto IL_10C8;
													}
													this.m_ActiveUnit.LogMessage(string.Concat(new string[]
													{
														this.m_ActiveUnit.Name,
														text7,
														"已经停止对目标",
														contact.Name,
														"的射击。"
													}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
													goto IL_10C8;
												}
											}
											Contact._BattleDamageAssessment? battleDamageAssessment = contact.GetBattleDamageAssessment(this.m_ActiveUnit.GetSide(false));
											b = (battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null);
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												list.Add(contact);
											}
											else
											{
												if ((bool_7 || this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) && this.IsEscort)
												{
													ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
													Contact theTarget = contact;
													Doctrine doctrine2 = this.m_ActiveUnit.m_Doctrine;
													string text = "";
													int num = 0;
													if (!weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine2, ref text, ref num, null))
													{
														list.Add(contact);
														goto IL_10C8;
													}
													if (this.GetTargetingBehavior(contact) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted && contact.GetPostureStance(this.m_ActiveUnit.GetSide(false)) == Misc.PostureStance.Friendly)
													{
														list.Add(contact);
														goto IL_10C8;
													}
												}
												if ((bool_7 || this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse) && this.m_ActiveUnit.IsSubmarine && contact.Heading_Known && contact.Speed_Known && !this.IsTargetReachable(contact, false))
												{
													list.Add(contact);
													string text8 = "";
													if (this.m_ActiveUnit.IsAircraft && Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
													{
														text8 = " (" + this.m_ActiveUnit.UnitClass + ")";
													}
													this.m_ActiveUnit.LogMessage(string.Concat(new string[]
													{
														this.m_ActiveUnit.Name,
														text8,
														"正在将目标： ",
														contact.Name,
														"从目标清单中舍弃(原因：不能在当前深度上以最大速度拦截目标)."
													}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
												}
											}
										}
									}
									else
									{
										list.Add(contact);
									}
								}
								IL_10C8:;
							}
							foreach (Contact current in list)
							{
								this.DropTargeting(current, true);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200328", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000A7F9C File Offset: 0x000A619C
		public bool IsTargetReachable(Contact theTarget, bool bool_6)
		{
			bool flag = false;
			bool result;
			try
			{
				Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(theTarget, false, true, this.m_ActiveUnit.m_Doctrine);
				double targetLat = 0.0;
				double targetLon = 0.0;
				if (Information.IsNothing(weapon))
				{
					targetLat = theTarget.GetLatitude(null);
					targetLon = theTarget.GetLongitude(null);
				}
				else
				{
					float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(theTarget);
					if (horizontalRange < weapon.GetMaxRangeToTarget(this.m_ActiveUnit, theTarget, false, this.m_ActiveUnit.m_Doctrine, false))
					{
						flag = true;
						result = true;
						return result;
					}
					Weapon._WeaponType weaponType = weapon.GetWeaponType();
					if (weaponType - Weapon._WeaponType.GuidedWeapon > 1 && weaponType != Weapon._WeaponType.Gun && weaponType != Weapon._WeaponType.Laser)
					{
						targetLat = theTarget.GetLatitude(null);
						targetLon = theTarget.GetLongitude(null);
					}
					else
					{
						float maxRangeToTarget = weapon.GetMaxRangeToTarget(this.m_ActiveUnit, theTarget, true, this.m_ActiveUnit.m_Doctrine, false);
						if (horizontalRange <= maxRangeToTarget)
						{
							flag = true;
							result = true;
							return result;
						}
						GeoPointGenerator.GetOtherGeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null), ref targetLon, ref targetLat, (double)(horizontalRange - maxRangeToTarget), (double)Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), theTarget.GetLatitude(null), theTarget.GetLongitude(null)));
					}
				}
				flag = this.IsTargetReachable(targetLat, targetLon, theTarget.GetCurrentHeading(), theTarget.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false)), this.m_ActiveUnit.GetCurrentHeading(), null, false, bool_6);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200591", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000A8218 File Offset: 0x000A6418
		public virtual void UpdateUnitStatus(float elapsedTime, bool bool_6, bool bool_7)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					Doctrine._AutomaticEvasion? automaticEvasionDoctrine = this.m_ActiveUnit.m_Doctrine.GetAutomaticEvasionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
					byte? b = automaticEvasionDoctrine.HasValue ? new byte?((byte)automaticEvasionDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (!Information.IsNothing(this.PrimaryThreat))
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
							return;
						}
						if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBEngagedDefensive);
						}
					}
					if (!this.m_ActiveUnit.IsRTB())
					{
						if (this.m_ActiveUnit.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester && this.m_ActiveUnit.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsShotgun)
						{
							ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = this.m_ActiveUnit.GetWeaponry().vmethod_3();
							if ((activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsWinchester || activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsShotgun) && this.m_ActiveUnit.IsAircraft && ((Aircraft)this.m_ActiveUnit).GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
							{
								return;
							}
						}
						bool? flag = new bool?(false);
						bool? flag2 = new bool?(false);
						if (!this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							flag = new bool?(false);
						}
						else
						{
							bool? flag3;
							if (Information.IsNothing(this.GetPrimaryTarget()))
							{
								flag3 = new bool?(false);
							}
							else
							{
								Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
								b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
								flag3 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
							}
							flag2 = flag3;
							flag = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
						}
						flag2 = flag;
						if (flag2.GetValueOrDefault())
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
						}
						else if (!Information.IsNothing(this.GetPrimaryTarget()))
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
						}
						else if (this.m_ActiveUnit.HasParentGroup() && this.m_ActiveUnit.GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup && this.m_ActiveUnit.GetParentGroup(false).GetUnitStatus() == ActiveUnit._ActiveUnitStatus.FormingUp)
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.FormingUp);
						}
						else
						{
							if (!this.m_ActiveUnit.IsGroup && !this.m_ActiveUnit.IsWeapon && this.m_ActiveUnit.GetAssignedMission(false) != null && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
							{
								if (this.m_ActiveUnit.GetAssignedMission(false).IsActive())
								{
									if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
									{
										this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPatrol);
										return;
									}
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
									return;
								}
								else
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
								}
							}
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200345", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000A85D8 File Offset: 0x000A67D8
		internal Contact method_41(Collection<Contact> collection_0)
		{
			Contact result = null;
			try
			{
				Contact contact = null;
				double num = 20000.0;
				foreach (Contact current in collection_0)
				{
					double num2 = (double)this.m_ActiveUnit.GetSlantRange(current, 0f);
					if (num2 < num)
					{
						contact = current;
						num = num2;
					}
				}
				result = contact;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100038", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000A86A8 File Offset: 0x000A68A8
		public void method_42()
		{
			try
			{
				Weapon[] source = this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false).Where(ActiveUnit_AI.IsMine).ToArray<Weapon>();
				if (source.Count<Weapon>() != 0)
				{
					float num;
					float num2;
					if (this.m_ActiveUnit.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.m_ActiveUnit.m_Scenario.GetSQLiteConnection()))
					{
						num = source.Select(ActiveUnit_AI.WeaponLaunchAltitudeMax_ASL).Max();
						num2 = source.Select(ActiveUnit_AI.WeaponLaunchAltitudeMin_ASL).Min();
					}
					else
					{
						num = source.Select(ActiveUnit_AI.WeaponLaunchAltitudeMax).Max();
						num2 = source.Select(ActiveUnit_AI.WeaponLaunchAltitudeMin).Min();
					}
					if (this.m_ActiveUnit.GetCurrentAltitude_ASL(false) > num)
					{
						this.m_ActiveUnit.SetDesiredAltitude(num - 10f);
					}
					if (this.m_ActiveUnit.GetCurrentAltitude_ASL(false) < num2)
					{
						this.m_ActiveUnit.SetDesiredAltitude(num2 + 10f);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100039", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000A87FC File Offset: 0x000A69FC
		public bool CanCarryOutMiningMission(float float_1)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(this.m_ActiveUnit))
				{
					result = false;
				}
				else if (!this.m_ActiveUnit.HasNavalMineLayingLoadout())
				{
					result = false;
				}
				else
				{
					bool flag = false;
					if (this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false).Where(ActiveUnit_AI.WeaponFunc10).ToArray<Weapon>().Count<Weapon>() > 0)
					{
						new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null));
						if (this.m_ActiveUnit.IsOnLand())
						{
							flag = false;
						}
						else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
						{
							MiningMission miningMission = (MiningMission)this.m_ActiveUnit.GetAssignedMission(false);
							if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_12, ref miningMission.list_7, 1, false, false))
							{
								flag = true;
							}
						}
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100040", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x000A8978 File Offset: 0x000A6B78
		public void method_44(ref Weapon weapon_)
		{
			if (!Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(weapon_))
			{
				Mount mount = null;
				Mount[] mounts = this.m_ActiveUnit.m_Mounts;
				checked
				{
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount2 = mounts[i];
						if (!Information.IsNothing(mount))
						{
							break;
						}
						if ((!this.m_ActiveUnit.IsAircraft || mount2.Trainable) && mount2.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && mount2.ReloadStatus == Mount._ReloadStatus.const_0)
						{
							foreach (WeaponRec current in mount2.GetWeaponRecCollection())
							{
								if (current.WeapID == weapon_.DBID && current.GetCurrentLoad() > 0)
								{
									mount = mount2;
									break;
								}
							}
						}
					}
				}
				if (!Information.IsNothing(mount) && !mount.IsTargetInCoverageArc(this.GetPrimaryTarget(), null))
				{
					if (weapon_.GetWeaponType() == Weapon._WeaponType.DepthCharge)
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(this.GetPrimaryTarget()));
					}
					else
					{
						int num = 1;
						int num2;
						while (true)
						{
							num2 = Math2.Normalize((int)Math.Round((double)(this.m_ActiveUnit.GetCurrentHeading() + (float)num)));
							if (mount.IsTargetInCoverageArc(this.GetPrimaryTarget(), new float?((float)num2)))
							{
								break;
							}
							num2 = Math2.Normalize((int)Math.Round((double)(this.m_ActiveUnit.GetCurrentHeading() - (float)num)));
							if (mount.IsTargetInCoverageArc(this.GetPrimaryTarget(), new float?((float)num2)))
							{
								goto IL_1CA;
							}
							num++;
							if (num > 180)
							{
								return;
							}
						}
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num2);
						return;
						IL_1CA:
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num2);
					}
				}
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000A8B70 File Offset: 0x000A6D70
		public void MarkAsHostile(ref Contact theTarget, bool bool_6)
		{
			if (bool_6 && theTarget.contactType != Contact_Base.ContactType.Aimpoint && theTarget.contactType != Contact_Base.ContactType.ActivationPoint && theTarget.GetPostureStance(this.m_ActiveUnit.GetSide(false)) != Misc.PostureStance.Hostile)
			{
				theTarget.MarkAs(this.m_ActiveUnit.GetSide(false), true, Misc.PostureStance.Hostile);
				this.m_ActiveUnit.LogMessage("目标: " + theTarget.Name + "已经被手动标记为敌方!", LoggedMessage.MessageType.ContactChange, 0, false, null);
			}
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000A8BEC File Offset: 0x000A6DEC
		public virtual void TargetingContact(Contact theTarget, bool bool_6, bool targetIsWeapon, ActiveUnit_AI.TargetingEntry._TargetingBehavior TargetingBehavior_)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit) && theTarget.contactType != Contact_Base.ContactType.Sonobuoy && !theTarget.IsDestroyed(this.m_ActiveUnit.m_Scenario) && (bool_6 || !this.method_55(theTarget)))
				{
					if (theTarget.contactType == Contact_Base.ContactType.Missile)
					{
						Weapon weapon = (Weapon)theTarget.ActualUnit;
						if (weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							if (Information.IsNothing(weapon.GetWeaponAI().GetPrimaryTarget()) || Information.IsNothing(weapon.GetWeaponAI().GetPrimaryTarget().ActualUnit))
							{
								if (bool_6)
								{
									this.m_ActiveUnit.Message = "不能对空空武器进行射击!";
								}
								return;
							}
							if (!weapon.GetWeaponAI().GetPrimaryTarget().ActualUnit.IsShip && (!weapon.GetWeaponAI().GetPrimaryTarget().ActualUnit.IsSubmarine || !((Submarine)weapon.GetWeaponAI().GetPrimaryTarget().ActualUnit).IsShallowerThanPeriscopeDepth()))
							{
								if (bool_6)
								{
									this.m_ActiveUnit.Message = "不能对空空武器进行射击!";
								}
								return;
							}
						}
					}
					if (this.m_ActiveUnit.IsWeapon && targetIsWeapon)
					{
						ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
						Weapon theWeapon = (Weapon)this.m_ActiveUnit;
						Contact theTarget2 = theTarget;
						short? num = new short?((short)Math.Max(0, this.m_ActiveUnit.GetTerrainElevation(false, false, false)));
						Mount theMount = null;
						Sensor sensor = null;
						string text = weaponry.CheckWeaponAttackCondition(theWeapon, theTarget2, ref num, false, false, theMount, ref sensor);
						if (Operators.CompareString(text, "OK", false) != 0)
						{
							this.m_ActiveUnit.LogMessage("武器：" + this.m_ActiveUnit.Name + "不能攻击此类目标! 原因: " + text, LoggedMessage.MessageType.WeaponLogic, 0, false, null);
							return;
						}
					}
					this.MarkAsHostile(ref theTarget, bool_6);
					if (this.GetTargetList().ContainsKey(theTarget.GetGuid()))
					{
						if (this.GetTargetList()[theTarget.GetGuid()].GetTargetingBehavior() != TargetingBehavior_)
						{
							this.GetTargetList()[theTarget.GetGuid()].SetTargetingBehavior(TargetingBehavior_);
						}
					}
					else
					{
						ActiveUnit_AI.TargetingEntry targetingEntry = new ActiveUnit_AI.TargetingEntry();
						targetingEntry.Target = theTarget;
						targetingEntry.SetTargetingBehavior(TargetingBehavior_);
						this.GetTargetList().Add(theTarget.GetGuid(), targetingEntry);
						this.ExportEngagementCycle("Targeting Contact", theTarget, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit.m_Scenario, "OODA: " + Conversions.ToString(this.GetOODAReactionTime(theTarget)) + "s");
					}
					if (targetIsWeapon || (bool_6 && this.m_ActiveUnit.IsWeapon))
					{
						this.SetPrimaryTarget(theTarget);
						this.bPrimaryTargetOverride = true;
					}
					this.TimeToNextPrimaryTargetEvent = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100041", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000112CF File Offset: 0x0000F4CF
		public virtual void AddThreat(Contact theTarget)
		{
			if (!this.Threats.Contains(theTarget))
			{
				ScenarioArrayUtil.AddContact(ref this.Threats, theTarget);
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000112EB File Offset: 0x0000F4EB
		public virtual void RemoveThreat(Contact theTarget)
		{
			if (this.Threats.Contains(theTarget))
			{
				if (theTarget == this.PrimaryThreat)
				{
					this.PrimaryThreat = null;
				}
				ScenarioArrayUtil.RemoveContact(ref this.Threats, theTarget);
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x000A8F20 File Offset: 0x000A7120
		public virtual void DropTargeting(Contact theTarget, bool IgnoreTargetIllumination = true)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.m_ActiveUnit) && !this.m_ActiveUnit.IsNotActive() && (!this.m_ActiveUnit.IsShip || !((Ship)this.m_ActiveUnit).IsDestroyed()) && (IgnoreTargetIllumination || !this.m_ActiveUnit.HasFireControllerForTarget(theTarget)))
					{
						if (theTarget == this.GetPrimaryTarget())
						{
							this.SetPrimaryTarget(null);
							this.bPrimaryTargetOverride = false;
						}
						this.DropTargetingForContact(theTarget);
						if (!Information.IsNothing(this.m_ActiveUnit))
						{
							if (!this.m_ActiveUnit.IsWeapon)
							{
								Side side = this.m_ActiveUnit.GetSide(false);
								ActiveUnit activeUnit = this.m_ActiveUnit;
								WeaponSalvo weaponSalvo = null;
								side.RemoveWeaponSalvoForTarget(ref activeUnit.m_Scenario, ref this.m_ActiveUnit, ref theTarget, ref weaponSalvo);
							}
							if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.m_ActiveUnit))
							{
								Sensor[] array = this.m_ActiveUnit.GetAllNoneMCMSensors().ToArray<Sensor>();
								for (int i = 0; i < array.Length; i++)
								{
									Sensor sensor = array[i];
									if (sensor.IsTargetTracked(ref theTarget))
									{
										sensor.StopIlluminateTarget(ref theTarget, false);
									}
									if (Information.IsNothing(this.m_ActiveUnit))
									{
										break;
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
					ex2.Data.Add("Error at 200326", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x000A90C4 File Offset: 0x000A72C4
		private void DropTargetingForContact(Contact contact_)
		{
			if (this.GetTargetList().ContainsKey(contact_.GetGuid()))
			{
				this.GetTargetList().Remove(contact_.GetGuid());
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					this.ExportEngagementCycle("Dropping targeting for Contact", contact_, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit.m_Scenario, "");
				}
			}
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x000A9130 File Offset: 0x000A7330
		public bool ShouldIShootTheTarget(ref Contact theTarget)
		{
			WeaponSalvo[] weaponSalvos = this.m_ActiveUnit.GetSide(false).WeaponSalvos;
			bool flag = false;
			checked
			{
				bool result;
				for (int i = 0; i < weaponSalvos.Length; i++)
				{
					WeaponSalvo weaponSalvo = weaponSalvos[i];
					if (weaponSalvo.ManualFire && weaponSalvo.Target == theTarget && weaponSalvo.GetTotalQuantityAssigned() != weaponSalvo.GetTotalQuantityFired())
					{
						WeaponSalvo.Shooter[] array = weaponSalvo.m_Shooters.ToArray<WeaponSalvo.Shooter>();
						for (int j = 0; j < array.Length; j++)
						{
							WeaponSalvo.Shooter shooter = array[j];
							if (Operators.CompareString(this.m_ActiveUnit.GetGuid(), shooter.ShooterObjectID, false) == 0 && shooter.QuantityFired == 0 && shooter.bool_0 && shooter.Timeout > 0)
							{
								result = true;
								return result;
							}
						}
					}
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x000A9204 File Offset: 0x000A7404
		public virtual void ScheduleNextPrimaryTargetEvent(short timeTick_, bool bool_6)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && !this.m_ActiveUnit.GetAssignedMission(false).IsActive())
					{
						this.SetPrimaryTarget(null);
					}
					else
					{
						this.TimeToNextPrimaryTargetEvent -= timeTick_;
						if (this.TimeToNextPrimaryTargetEvent <= 0)
						{
							if (this.m_ActiveUnit.OODATargetingCycle == 0)
							{
								this.TimeToNextPrimaryTargetEvent = (short)GameGeneral.GetRandom().Next(10, 21);
							}
							else
							{
								this.TimeToNextPrimaryTargetEvent = (short)Math.Round(Math.Min(20.0, (double)((int)this.m_ActiveUnit.OODATargetingCycle * GameGeneral.GetRandom().Next(10, 21)) / 10.0));
							}
							checked
							{
								if ((!this.bPrimaryTargetOverride || !Information.IsNothing(this.PrimaryThreat)) && !this.m_ActiveUnit.IsWeapon)
								{
									Contact[] array = new Contact[0];
									if (this.m_ActiveUnit.IsShip)
									{
										array = this.GetTargets().Where(ActiveUnit_AI.ContactFunc11).ToArray<Contact>();
									}
									else if (this.m_ActiveUnit.IsSubmarine)
									{
										array = this.GetTargets().Where(ActiveUnit_AI.ContactFunc12).ToArray<Contact>();
									}
									else if (this.m_ActiveUnit.IsFacility)
									{
										array = this.GetTargets().Where(ActiveUnit_AI.ContactFunc13).ToArray<Contact>();
									}
									else if (!this.m_ActiveUnit.IsSatellite())
									{
										array = this.GetTargets().ToArray<Contact>();
									}
									if (array.Length != 0)
									{
										Collection<Contact> collection = new Collection<Contact>();
										Contact[] array2 = array;
										for (int i = 0; i < array2.Length; i++)
										{
											Contact contact = array2[i];
											ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.GetTargetingBehavior(contact);
											if (targetingBehavior != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
											{
												if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
												{
													if (this.m_ActiveUnit.IsShip)
													{
														if (contact.IsSurface() || contact.IsSubSurface() || contact.IsFacilityType())
														{
															collection.Add(contact);
														}
													}
													else if (this.m_ActiveUnit.IsSubmarine)
													{
														if (contact.IsSurface() || contact.IsSubSurface())
														{
															collection.Add(contact);
														}
													}
													else if (this.m_ActiveUnit.IsFacility)
													{
														if (contact.IsFacilityType())
														{
															collection.Add(contact);
														}
													}
													else if (!this.m_ActiveUnit.IsSatellite())
													{
														collection.Add(contact);
													}
												}
											}
											else if (this.m_ActiveUnit.IsShip)
											{
												if ((contact.IsSurface() || contact.IsSubSurface() || contact.IsFacilityType()) && this.ShouldIShootTheTarget(ref contact))
												{
													collection.Add(contact);
												}
											}
											else if (this.m_ActiveUnit.IsSubmarine)
											{
												if ((contact.IsSurface() || contact.IsSubSurface()) && this.ShouldIShootTheTarget(ref contact))
												{
													collection.Add(contact);
												}
											}
											else if (this.m_ActiveUnit.IsFacility)
											{
												if (contact.IsFacilityType() && this.ShouldIShootTheTarget(ref contact))
												{
													collection.Add(contact);
												}
											}
											else if (!this.m_ActiveUnit.IsSatellite() && this.ShouldIShootTheTarget(ref contact))
											{
												collection.Add(contact);
											}
										}
										if (collection.Count > 0)
										{
											if (collection.Count == 1)
											{
												this.SetPrimaryTarget(collection[0]);
											}
											else
											{
												Contact[] array3 = collection.Select(ActiveUnit_AI.ContactFunc14).OrderBy(new Func<Contact, float>(this.GetHorizontalRange)).ToArray<Contact>();
												this.SetPrimaryTarget(array3[0]);
											}
										}
										else if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
										{
											this.SetPrimaryTarget(null);
										}
										else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && array.Count<Contact>() == 1)
										{
											this.SetPrimaryTarget(array[0]);
										}
										else
										{
											if (this.IsEscort)
											{
												this.PickPrimaryTarget(array);
											}
											else
											{
												bool flag = false;
												if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol && ((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).patrolType == GlobalVariables.PatrolType.SEAD)
												{
													this.method_37();
													flag = true;
												}
												if (!flag)
												{
													if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
													{
														List<IGrouping<int, Contact>> list = array.Select(ActiveUnit_AI.ContactFunc15).GroupBy(ActiveUnit_AI.ContactFunc16).ToList<IGrouping<int, Contact>>();
														this.SetPrimaryTarget(list[0].OrderBy(new Func<Contact, float>(this.GetHorizontalRange)).ToList<Contact>()[0]);
													}
													else
													{
														this.SetPrimaryTarget(array.OrderBy(new Func<Contact, float>(this.GetHorizontalRange)).ToList<Contact>()[0]);
													}
												}
											}
											Collection<Contact> collection2 = new Collection<Contact>();
											Contact[] array4 = array;
											for (int j = 0; j < array4.Length; j++)
											{
												Contact contact2 = array4[j];
												if (Information.IsNothing(this.m_ActiveUnit))
												{
													return;
												}
												if (this.GetThreats().Contains(contact2) && this.m_ActiveUnit.GetSlantRange(contact2, 0f) < 10f)
												{
													collection2.Add(contact2);
												}
												if (collection2.Count == 1)
												{
													this.SetPrimaryTarget(collection2[0]);
												}
												double num = 20000.0;
												foreach (Contact current in collection2)
												{
													double num2 = (double)this.m_ActiveUnit.GetSlantRange(current, 0f);
													if (num2 < num)
													{
														this.SetPrimaryTarget(current);
														num = num2;
													}
												}
											}
											collection2 = null;
										}
									}
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
				ex2.Data.Add("Error at 100043", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x000A98B0 File Offset: 0x000A7AB0
		public virtual void PickPrimaryThreat()
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.m_ActiveUnit) && !this.m_ActiveUnit.IsWeapon)
					{
						this.PrimaryThreat = null;
						int num = this.GetThreats().Length;
						if (num != 0)
						{
							if (num != 1)
							{
								float num2 = 20000f;
								Contact[] threats = this.GetThreats();
								for (int i = 0; i < threats.Length; i++)
								{
									Contact contact = threats[i];
									if (contact.GetLongitude(null) != 0.0 && contact.GetLatitude(null) != 0.0 && contact.GetCurrentSpeed() != 0f)
									{
										float desiredSpeed = this.m_ActiveUnit.GetDesiredSpeed(contact, this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading());
										if (desiredSpeed > 0f)
										{
											float num3 = this.m_ActiveUnit.method_49(desiredSpeed, this.DistanceBetween(this.m_ActiveUnit, ref contact));
											if (num3 < num2)
											{
												this.PrimaryThreat = contact;
												num2 = num3;
											}
										}
									}
								}
							}
							else
							{
								this.PrimaryThreat = this.GetThreats()[0];
							}
						}
						else
						{
							this.PrimaryThreat = null;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100044", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000A9A50 File Offset: 0x000A7C50
		public virtual void vmethod_18(float float_1)
		{
			ActiveUnit_AI.Class24 @class = new ActiveUnit_AI.Class24();
			@class.activeUnit_AI = this;
			@class.float_0 = float_1;
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					if (!this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
					{
						this.method_53(new float?(this.m_ActiveUnit.GetDesiredSpeed()));
					}
					if (this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
					{
						this.m_ActiveUnit.GetNavigator().vmethod_7(@class.float_0);
					}
					else
					{
						if (this.m_ActiveUnit.GetNavigator().bUpdated && !this.bool_5)
						{
							Task.Factory.StartNew(new Action(@class.method_0));
						}
						if (this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) < 1f && !Information.IsNothing(this.GetPrimaryTarget().GetUncertaintyArea()) && !this.m_ActiveUnit.GetWeaponry().method_20(this.GetPrimaryTarget(), true))
						{
							this.m_ActiveUnit.GetNavigator().Localization();
							this.m_ActiveUnit.GetNavigator().vmethod_7(@class.float_0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100045", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000A9BD4 File Offset: 0x000A7DD4
		private void method_48(float float_1, bool bool_6)
		{
			if (!this.m_ActiveUnit.GetAI().HoldPosition)
			{
				this.bool_5 = true;
				try
				{
					if (!this.m_ActiveUnit.GetNavigator().bool_2)
					{
						if (this.m_ActiveUnit.GetNavigator().vmethod_16(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), true, 0f, true, null))
						{
							Waypoint[] source = this.m_ActiveUnit.GetNavigator().GetPlottedCourse().ToArray<Waypoint>();
							if (this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
							{
								Waypoint waypoint = source.Where(ActiveUnit_AI.IsPathfindingPoint).Last<Waypoint>();
								Weapon maxRangeWeaponFor = this.m_ActiveUnit.GetWeaponry().GetMaxRangeWeaponFor(this.GetPrimaryTarget());
								float num;
								if (Information.IsNothing(maxRangeWeaponFor))
								{
									num = 1f;
								}
								else
								{
									num = maxRangeWeaponFor.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), false, null, false);
								}
								if (Math2.GetDistance(waypoint.GetLatitude(), waypoint.GetLongitude(), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null)) > num)
								{
									this.m_ActiveUnit.GetNavigator().method_12(waypoint, this.m_ActiveUnit, null, false, 0.15f, this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), this.m_ActiveUnit.m_Scenario, bool_6);
								}
								else
								{
									this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
								}
							}
							else
							{
								this.m_ActiveUnit.GetNavigator().method_12(null, this.m_ActiveUnit, null, false, 0.15f, this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), this.m_ActiveUnit.m_Scenario, bool_6);
							}
						}
						else if (this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
						{
							this.m_ActiveUnit.GetNavigator().method_14();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100046", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				this.bool_5 = false;
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000A9EA0 File Offset: 0x000A80A0
		public virtual bool IsTargetReachable(double targetLat, double targetLon, float targetHeading, float targetSpeed, float parentAltitude_ASL, float parentSpeed, float parentHeading, float? nullable_5, bool bool_6, bool bool_7)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(nullable_5))
				{
					nullable_5 = new float?(0.1f);
				}
				float num = this.m_ActiveUnit.HorizontalRangeTo(targetLat, targetLon);
				if (float.IsNaN(num))
				{
					flag = true;
				}
				else
				{
					float num2;
					if (bool_6)
					{
						num2 = parentSpeed;
						if (parentSpeed <= 0f || double.IsNaN((double)parentSpeed))
						{
							flag = false;
							result = false;
							return result;
						}
					}
					else
					{
						if (bool_7)
						{
							num2 = this.m_ActiveUnit.GetDesiredSpeed(targetLat, targetLon, targetHeading, targetSpeed, parentSpeed, parentHeading);
						}
						else
						{
							float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryThreat().GetLatitude(null), this.GetPrimaryThreat().GetLongitude(null));
							num2 = this.m_ActiveUnit.GetDesiredSpeed(targetLat, targetLon, targetHeading, targetSpeed, parentSpeed, azimuth);
						}
						if (num2 <= 0f || double.IsNaN((double)num2))
						{
							flag = false;
							result = false;
							return result;
						}
					}
					long num3 = (long)Math.Round((double)(num / num2 * 3600f));
					float num4 = (float)this.m_ActiveUnit.GetKinematics().GetFuelBurnoutTime(parentSpeed, parentAltitude_ASL, !this.m_ActiveUnit.IsAircraft, this.m_ActiveUnit.IsAircraft);
					float? num5 = nullable_5;
					num5 = (num5.HasValue ? new float?(1f + num5.GetValueOrDefault()) : null);
					float? num6 = num5.HasValue ? new float?(num4 * num5.GetValueOrDefault()) : null;
					float num7 = (float)num3;
					flag = (num6.HasValue ? new bool?(num6.GetValueOrDefault() > num7) : null).GetValueOrDefault();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100047", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000AA108 File Offset: 0x000A8308
		public bool CanBeFueledBy(Unit theTankerUnit_, float? rangeToTanker_, float TransitAltitude_, float Speed_, float CurrentHeading_, float? nullable_6, bool bool_6, bool bool_7, bool bool_8)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(nullable_6))
				{
					nullable_6 = new float?(0.1f);
				}
				if (Information.IsNothing(rangeToTanker_))
				{
					rangeToTanker_ = new float?(this.m_ActiveUnit.GetHorizontalRange(theTankerUnit_));
				}
				if (Information.IsNothing(rangeToTanker_))
				{
					flag = true;
				}
				else
				{
					float num;
					if (bool_6)
					{
						num = Speed_;
						if (Speed_ <= 0f || double.IsNaN((double)Speed_))
						{
							flag = false;
							result = false;
							return result;
						}
					}
					else
					{
						num = this.m_ActiveUnit.GetDesiredSpeed(theTankerUnit_, Speed_, CurrentHeading_);
						if (num <= 0f || double.IsNaN((double)num))
						{
							flag = false;
							result = false;
							return result;
						}
					}
					float? num2 = rangeToTanker_;
					float num3 = num;
					num2 = (num2.HasValue ? new float?(num2.GetValueOrDefault() / num3) : null);
					long num4 = (long)Math.Round((double)(num2.HasValue ? new float?(num2.GetValueOrDefault() * 3600f) : null).Value);
					num3 = (float)this.m_ActiveUnit.GetKinematics().GetFuelBurnoutTime(Speed_, TransitAltitude_, bool_7, bool_8);
					num2 = nullable_6;
					num2 = (num2.HasValue ? new float?(1f + num2.GetValueOrDefault()) : null);
					float? num5 = num2.HasValue ? new float?(num3 * num2.GetValueOrDefault()) : null;
					float num6 = (float)num4;
					flag = (num5.HasValue ? new bool?(num5.GetValueOrDefault() > num6) : null).GetValueOrDefault();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100047", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000AA344 File Offset: 0x000A8544
		public bool CanReachTargetUnit(Unit theTargetUnit_, float? rangeToTargetUnit_, float TransitAltitude_, float? Speed_, float CurrentHeading_, ActiveUnit.Throttle throttle_, float? nullable_7, bool bool_6, bool bool_7, ref bool bool_8)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(this.m_ActiveUnit))
				{
					result = false;
				}
				else
				{
					if (Information.IsNothing(Speed_))
					{
						Speed_ = new float?((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), throttle_));
					}
					result = this.CanBeFueledBy(theTargetUnit_, rangeToTargetUnit_, TransitAltitude_, Speed_.Value, CurrentHeading_, nullable_7, bool_6, bool_7, bool_8);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100048", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000AA408 File Offset: 0x000A8608
		public int? method_51(ActiveUnit activeUnit_1)
		{
			int? num = new int?(0);
			int? result;
			try
			{
				int maxSpeed = this.m_ActiveUnit.GetKinematics().GetMaxSpeed();
				int num2 = Math.Max(1, (int)Math.Round((double)maxSpeed / 100.0));
				int num3 = maxSpeed;
				int num4 = num2;
				int num5 = 1;
				while ((num4 >> 31 ^ num5) <= (num4 >> 31 ^ num3))
				{
					if (ActiveUnit_Navigator.smethod_4(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), (double)this.m_ActiveUnit.GetCurrentHeading(), activeUnit_1, (float)num5).HasValue)
					{
						num = new int?(num5);
						result = num;
						return result;
					}
					num5 += num4;
				}
				num = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100049", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000AA528 File Offset: 0x000A8728
		public void method_52(float float_1, float float_2)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit.GetNavigator().GetPlottedCourse()) && this.m_ActiveUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0 && this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.LocalizationRun)
				{
					if (!Information.IsNothing(this.GetPrimaryTarget().GetUncertaintyArea()))
					{
						return;
					}
					this.m_ActiveUnit.GetNavigator().RemoveWaypoint(this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0], false);
				}
				if (this.GetPrimaryTarget().IsAir())
				{
					Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), false, true, this.m_ActiveUnit.m_Doctrine);
					if (!Information.IsNothing(weapon))
					{
						if (weapon.RangeAAWMin > 0f && this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) <= weapon.RangeAAWMin)
						{
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.m_ActiveUnit.AzimuthTo(this.GetPrimaryTarget()) + 90f));
							return;
						}
						if (weapon.weaponCode.AntiAir_RearAspect || weapon.weaponCode.AntiAir_SternChase)
						{
							double lon = 0.0;
							double lat = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(this.GetPrimaryTarget().GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), ref lon, ref lat, (double)weapon.RangeAAWMin + 0.5, (double)Math2.Normalize(this.GetPrimaryTarget().GetCurrentHeading() + 180f));
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(lat, lon));
							return;
						}
					}
				}
				float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null));
				this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, azimuth);
				if (this.GetPrimaryTarget().GetCurrentSpeed() <= this.m_ActiveUnit.GetCurrentSpeed() / 2f)
				{
					this.m_ActiveUnit.GetNavigator().vmethod_4(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_1, float_2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100050", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000AA828 File Offset: 0x000A8A28
		public void method_53(float? EstimatedAverageSpeed = null)
		{
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
				{
					if (!Information.IsNothing(this.m_ActiveUnit.GetNavigator().GetPlottedCourse()) && this.m_ActiveUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0 && this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.LocalizationRun)
					{
						if (!Information.IsNothing(this.GetPrimaryTarget().GetUncertaintyArea()))
						{
							return;
						}
						this.m_ActiveUnit.GetNavigator().RemoveWaypoint(this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0], false);
					}
					if (this.GetPrimaryTarget().Heading_Known && this.GetPrimaryTarget().Speed_Known)
					{
						float averageSpeed;
						if (EstimatedAverageSpeed.HasValue)
						{
							averageSpeed = EstimatedAverageSpeed.Value;
						}
						else
						{
							averageSpeed = this.m_ActiveUnit.GetCurrentSpeed();
						}
						Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), false, true, this.m_ActiveUnit.m_Doctrine);
						if (!Information.IsNothing(weapon))
						{
							if (weapon.RangeAAWMin > 0f && this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) <= weapon.RangeAAWMin)
							{
								this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.m_ActiveUnit.AzimuthTo(this.GetPrimaryTarget()) + 90f));
								return;
							}
							if (weapon.weaponCode.AntiAir_RearAspect || weapon.weaponCode.AntiAir_SternChase)
							{
								double lon = 0.0;
								double lat = 0.0;
								GeoPointGenerator.GetOtherGeoPoint(this.GetPrimaryTarget().GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), ref lon, ref lat, (double)(weapon.RangeAAWMin + 1f), (double)Math2.Normalize(this.GetPrimaryTarget().GetCurrentHeading() + 180f));
								this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(lat, lon));
								return;
							}
						}
						double? num = ActiveUnit_Navigator.smethod_4(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), (double)this.m_ActiveUnit.GetCurrentHeading(), this.GetPrimaryTarget(), averageSpeed);
						if (num.HasValue)
						{
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num.Value);
						}
						else if (this.m_ActiveUnit.GetCurrentSpeed() >= this.GetPrimaryTarget().GetCurrentSpeed())
						{
							this.method_54();
						}
					}
					else
					{
						this.method_54();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100052", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000AAB50 File Offset: 0x000A8D50
		public void method_54()
		{
			try
			{
				float num;
				if (this.m_ActiveUnit.IsWeapon)
				{
					float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
					num = Math.Min(20f, horizontalRange / (this.m_ActiveUnit.GetCurrentSpeed() / 3600f));
				}
				else
				{
					num = 1f;
				}
				float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null));
				if (270f > azimuth && azimuth > 90f)
				{
					this.method_52(0f, 0f);
				}
				else
				{
					float num2 = this.GetPrimaryTarget().method_132(this.m_ActiveUnit);
					if (float.IsNaN(num2))
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, azimuth);
					}
					else
					{
						string starboardOrPort = this.GetPrimaryTarget().GetStarboardOrPort(this.m_ActiveUnit);
						if (Operators.CompareString(starboardOrPort, "Port", false) != 0)
						{
							if (Operators.CompareString(starboardOrPort, "Starboard", false) == 0)
							{
								this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(azimuth + num * num2));
							}
						}
						else
						{
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(azimuth - num * num2));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100053", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000AAD28 File Offset: 0x000A8F28
		public bool method_55(Contact target)
		{
			bool arg_28_0;
			if (target.contactType == Contact_Base.ContactType.ActivationPoint)
			{
				if (target.contactType != Contact_Base.ContactType.Aimpoint)
				{
					arg_28_0 = true;
					goto IL_28;
				}
			}
			arg_28_0 = !Information.IsNothing(target.ActualUnit);
			IL_28:
			bool flag;
			bool result;
			if (!arg_28_0)
			{
				flag = true;
			}
			else
			{
				ActiveUnit actualUnit = target.ActualUnit;
				if (Information.IsNothing(actualUnit))
				{
					if (target.contactType != Contact_Base.ContactType.Aimpoint && target.contactType != Contact_Base.ContactType.ActivationPoint)
					{
						result = true;
						return result;
					}
					flag = false;
				}
				else
				{
					flag = (actualUnit.IsFacility && target.GetBattleDamageAssessment(this.m_ActiveUnit.GetSide(false)).HasValue && target.GetBattleDamageAssessment(this.m_ActiveUnit.GetSide(false)).Value == Contact._BattleDamageAssessment.HeavyDamage && actualUnit.GetAirFacilities().Length > 0 && actualUnit.GetAirFacilities().Length == actualUnit.GetAirFacilities().Where(ActiveUnit_AI.AirFacilityFunc18).Count<AirFacility>());
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000AAE10 File Offset: 0x000A9010
		public virtual void UpdateMissionStatus(float elapsedTime)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					if (this.CanCarryOutMiningMission(elapsedTime))
					{
						ActiveUnit_AI.MiningMissionAI miningMissionAI = new ActiveUnit_AI.MiningMissionAI(null);
						miningMissionAI.m_AI = this;
						miningMissionAI.bStart = true;
						if (!Information.IsNothing(this.m_ActiveUnit.m_Scenario.Mines) && this.m_ActiveUnit.m_Scenario.Mines.Count != 0)
						{
							Parallel.ForEach<UnguidedWeapon>(this.m_ActiveUnit.m_Scenario.Mines.Where(new Func<UnguidedWeapon, bool>(this.IsFriendlySide)).ToArray<UnguidedWeapon>(), new Action<UnguidedWeapon, ParallelLoopState>(miningMissionAI.CheckStopCondition));
						}
						if (miningMissionAI.bStart)
						{
							long long_;
							if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
							{
								long_ = ((MiningMission)this.m_ActiveUnit.GetAssignedMission(false)).AD;
							}
							else if (this.m_ActiveUnit.IsAircraft)
							{
								long_ = 0L;
							}
							else
							{
								long_ = 3600L;
							}
							this.m_ActiveUnit.GetWeaponry().LayMines(elapsedTime, long_);
						}
					}
					if (this.GetTargets().Length != 0)
					{
						Doctrine._WeaponControlStatus? weaponControlStatus = new Doctrine._WeaponControlStatus?(this.m_ActiveUnit.m_Doctrine.GetWCS_AirDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false).Value);
						Doctrine._WeaponControlStatus? weaponControlStatus2 = new Doctrine._WeaponControlStatus?(this.m_ActiveUnit.m_Doctrine.GetWCS_SurfaceDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false).Value);
						Doctrine._WeaponControlStatus? weaponControlStatus3 = new Doctrine._WeaponControlStatus?(this.m_ActiveUnit.m_Doctrine.GetWCS_SubmarineDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false).Value);
						Doctrine._WeaponControlStatus? weaponControlStatus4 = new Doctrine._WeaponControlStatus?(this.m_ActiveUnit.m_Doctrine.GetWCS_LandDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false).Value);
						byte? b = weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							b = (weaponControlStatus2.HasValue ? new byte?((byte)weaponControlStatus2.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								b = (weaponControlStatus3.HasValue ? new byte?((byte)weaponControlStatus3.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									b = (weaponControlStatus4.HasValue ? new byte?((byte)weaponControlStatus4.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										return;
									}
								}
							}
						}
						ActiveUnit_AI.TargetingEntry[] targetArray = this.GetTargetArray();
						bool flag = true;
						if (!Information.IsNothing(this.AirTargetDistance))
						{
							float? airTargetDistance = this.AirTargetDistance;
							if ((airTargetDistance.HasValue ? new bool?(airTargetDistance.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag = false;
							}
							else if (!Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax()))
							{
								airTargetDistance = this.AirTargetDistance;
								double? num = airTargetDistance.HasValue ? new double?((double)airTargetDistance.GetValueOrDefault()) : null;
								double num2 = (double)this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax().RangeAAWMax * 1.5;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() < num2) : null).GetValueOrDefault())
								{
									flag = false;
								}
							}
						}
						bool flag2 = true;
						if (!Information.IsNothing(this.SurfaceTargetDistance))
						{
							float? num3 = this.SurfaceTargetDistance;
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag2 = false;
							}
							else if (!Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false)))
							{
								num3 = this.SurfaceTargetDistance;
								double? num = num3.HasValue ? new double?((double)num3.GetValueOrDefault()) : null;
								double num2 = (double)this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false).RangeASUWMax * 1.2;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() < num2) : null).GetValueOrDefault())
								{
									flag2 = false;
								}
							}
						}
						bool flag3 = true;
						if (!Information.IsNothing(this.SubSurfaceTargetDistance))
						{
							float? num3 = this.SubSurfaceTargetDistance;
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag3 = false;
							}
							else if (!Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax()))
							{
								num3 = this.SubSurfaceTargetDistance;
								double? num = num3.HasValue ? new double?((double)num3.GetValueOrDefault()) : null;
								double num2 = (double)this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax().RangeASWMax * 1.2;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() < num2) : null).GetValueOrDefault())
								{
									flag3 = false;
								}
							}
						}
						bool flag4 = true;
						if (!Information.IsNothing(this.FixedTargetDistance))
						{
							float? num3 = this.FixedTargetDistance;
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag4 = false;
							}
							else if (!Information.IsNothing(this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false)))
							{
								num3 = this.FixedTargetDistance;
								double? num = num3.HasValue ? new double?((double)num3.GetValueOrDefault()) : null;
								double num2 = (double)this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false).RangeLandMax * 1.2;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() < num2) : null).GetValueOrDefault())
								{
									flag4 = false;
								}
							}
						}
						ActiveUnit_AI.TargetingEntry[] array = targetArray;
						checked
						{
							for (int i = 0; i < array.Length; i++)
							{
								Contact target = array[i].Target;
								ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.GetTargetingBehavior(target);
								if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
								{
									if (target.IsAirSpace())
									{
										if (flag)
										{
											goto IL_BA7;
										}
										b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
										{
											goto IL_BA7;
										}
									}
									else if (target.IsSurface())
									{
										if (flag2)
										{
											goto IL_BA7;
										}
										b = (weaponControlStatus2.HasValue ? new byte?((byte)weaponControlStatus2.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
										{
											goto IL_BA7;
										}
									}
									else if (target.IsSubSurface())
									{
										if (flag3)
										{
											goto IL_BA7;
										}
										b = (weaponControlStatus3.HasValue ? new byte?((byte)weaponControlStatus3.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
										{
											goto IL_BA7;
										}
									}
									else if (target.IsFixed())
									{
										if (flag4)
										{
											goto IL_BA7;
										}
										b = (weaponControlStatus4.HasValue ? new byte?((byte)weaponControlStatus4.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
										{
											goto IL_BA7;
										}
									}
									if (target.GetPostureStance(this.m_ActiveUnit.GetSide(false)) != Misc.PostureStance.Hostile)
									{
										if (target.IsAirSpace())
										{
											b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
											bool? flag5 = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
											if ((flag5.HasValue ? new bool?(!flag5.GetValueOrDefault()) : flag5).GetValueOrDefault())
											{
												goto IL_BA7;
											}
										}
										else if (target.IsSurface())
										{
											b = (weaponControlStatus2.HasValue ? new byte?((byte)weaponControlStatus2.GetValueOrDefault()) : null);
											bool? flag5 = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
											if ((flag5.HasValue ? new bool?(!flag5.GetValueOrDefault()) : flag5).GetValueOrDefault())
											{
												goto IL_BA7;
											}
										}
										else if (target.IsSubSurface())
										{
											if (target.contactType != Contact_Base.ContactType.Torpedo)
											{
												b = (weaponControlStatus3.HasValue ? new byte?((byte)weaponControlStatus3.GetValueOrDefault()) : null);
												bool? flag5 = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
												if ((flag5.HasValue ? new bool?(!flag5.GetValueOrDefault()) : flag5).GetValueOrDefault())
												{
													goto IL_BA7;
												}
											}
										}
										else
										{
											b = (weaponControlStatus4.HasValue ? new byte?((byte)weaponControlStatus4.GetValueOrDefault()) : null);
											bool? flag5 = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
											if ((flag5.HasValue ? new bool?(!flag5.GetValueOrDefault()) : flag5).GetValueOrDefault())
											{
												goto IL_BA7;
											}
										}
									}
									if (this.method_63(target) && this.m_ActiveUnit.GetWeaponry().method_14(target, 0, 0, false, DateTime.MinValue))
									{
										break;
									}
								}
								IL_BA7:;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100054", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000ABA38 File Offset: 0x000A9C38
		private ActiveUnit_AI.TargetingEntry[] GetTargetingEntryArray(ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> observableDictionary_1)
		{
			ActiveUnit_AI.TargetingEntry[] result;
			if (Information.IsNothing(this.m_ActiveUnit))
			{
				result = new ActiveUnit_AI.TargetingEntry[0];
			}
			else
			{
				result = observableDictionary_1.Values.Select(ActiveUnit_AI.TargetingEntryFunc19).OrderBy(new Func<ActiveUnit_AI.TargetingEntry, float>(this.GetHorizontalRange)).ToArray<ActiveUnit_AI.TargetingEntry>();
			}
			return result;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000097CF File Offset: 0x000079CF
		public virtual void EngagedDefensive(float float_1)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x000ABA88 File Offset: 0x000A9C88
		public float GetRelativeBearing(ref Contact theTarget)
		{
			float result = 0f;
			try
			{
				float currentHeading = theTarget.GetCurrentHeading();
				float num = Math2.GetAzimuth(theTarget.GetLatitude(null), theTarget.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null));
				num = Math2.Normalize(num - currentHeading);
				if (num > 180f)
				{
					result = -(360f - num);
				}
				else
				{
					result = num;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100056", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000ABB6C File Offset: 0x000A9D6C
		public float GetAzimuth(Unit unit_0)
		{
			return Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), unit_0.GetLatitude(null), unit_0.GetLongitude(null));
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000ABBC8 File Offset: 0x000A9DC8
		public bool method_59(ref Weapon theWeapon)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (Information.IsNothing(this.GetPrimaryTarget()))
					{
						flag = false;
					}
					else if (!Information.IsNothing(theWeapon.GetDataLinkParent()))
					{
						flag = true;
					}
					else
					{
						if ((theWeapon.method_187() && theWeapon.method_209()) || theWeapon.method_211())
						{
							Contact[] targets = this.GetTargets();
							for (int i = 0; i < targets.Length; i++)
							{
								Contact contact = targets[i];
								if (!Information.IsNothing(contact) && !Information.IsNothing(contact.ActualUnit) && !Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit) && Operators.CompareString(contact.ActualUnit.GetGuid(), this.GetPrimaryTarget().ActualUnit.GetGuid(), false) == 0)
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
						if (theWeapon.GetGuidanceMethod() == Weapon._GuidanceMethod.SemiActive && !Information.IsNothing(theWeapon.GetFiringParent()))
						{
							ActiveUnit_Sensory sensory = theWeapon.GetFiringParent().GetSensory();
							Contact primaryTarget = theWeapon.GetWeaponAI().GetPrimaryTarget();
							Weapon weapon_ = theWeapon;
							Sensor sensor = null;
							bool? flag2 = null;
							bool? flag3 = null;
							Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
							bool? flag4 = null;
							if (sensory.IsIlluminating(primaryTarget, weapon_, ref sensor, ref flag2, ref flag3, ref lOS_Exists_Visual, ref flag4))
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
					ex2.Data.Add("Error at 100057", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000ABD94 File Offset: 0x000A9F94
		public float GetHeadingToPredicatedTargetLocation(Unit TargetUnit)
		{
			float result = 0f;
			try
			{
				float moveDistance = TargetUnit.GetMoveDistance(1f);
				float moveDistance2 = this.m_ActiveUnit.GetMoveDistance(1f);
				double lon = 0.0;
				double lat = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(TargetUnit.GetLongitude(null), TargetUnit.GetLatitude(null), ref lon, ref lat, (double)moveDistance, (double)TargetUnit.GetCurrentHeading());
				float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), lat, lon);
				double lon2 = 0.0;
				double lat2 = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null), ref lon2, ref lat2, (double)moveDistance2, (double)azimuth);
				result = Math2.GetAzimuth(lat2, lon2, lat, lon);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100058", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000ABEF4 File Offset: 0x000AA0F4
		public float DistanceBetween(Unit theUnit, ref Contact theTarget)
		{
			return Math2.GetDistance(theUnit.GetLatitude(null), theUnit.GetLongitude(null), theTarget.GetLatitude(null), theTarget.GetLongitude(null));
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000ABF48 File Offset: 0x000AA148
		public void RunOppositeTo(ref int Bearing)
		{
			try
			{
				float num = (float)Math2.Normalize(Bearing + 180);
				if (this.m_ActiveUnit.IsShip || this.m_ActiveUnit.IsSubmarine)
				{
					float num2 = 2f;
					bool flag = false;
					int num3 = 0;
					while (!flag && num3 < 72)
					{
						num3++;
						double targetLongitude_ = 0.0;
						double targetLatitude_ = 0.0;
						GeoPointGenerator.GetOtherGeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null), ref targetLongitude_, ref targetLatitude_, (double)num2, (double)num);
						if (this.m_ActiveUnit.GetNavigator().vmethod_16(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), targetLatitude_, targetLongitude_, true, 0f, false, null))
						{
							num += 5f;
						}
						else
						{
							flag = true;
						}
					}
				}
				this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, num);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100061", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000AC0D0 File Offset: 0x000AA2D0
		public bool method_63(Contact theTarget)
		{
			bool flag = false;
			bool result;
			try
			{
				Misc.PostureStance postureStance = theTarget.GetPostureStance(this.m_ActiveUnit.GetSide(false));
				if (Information.IsNothing(postureStance))
				{
					flag = false;
				}
				else
				{
					if (theTarget.contactType != Contact_Base.ContactType.Aimpoint && theTarget.contactType != Contact_Base.ContactType.ActivationPoint)
					{
						if (this.GetTargetingBehavior(theTarget) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
						{
							flag = true;
						}
						else if (postureStance == Misc.PostureStance.Hostile)
						{
							if (theTarget.IsAirSpace())
							{
								Doctrine._WeaponControlStatus? wCS_AirDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_AirDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
								byte? b = wCS_AirDoctrine.HasValue ? new byte?((byte)wCS_AirDoctrine.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									flag = false;
									result = false;
									return result;
								}
							}
							else if (theTarget.IsSurface())
							{
								Doctrine._WeaponControlStatus? wCS_SurfaceDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_SurfaceDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
								byte? b = wCS_SurfaceDoctrine.HasValue ? new byte?((byte)wCS_SurfaceDoctrine.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									flag = false;
									result = false;
									return result;
								}
							}
							else if (theTarget.IsSubSurface())
							{
								Doctrine._WeaponControlStatus? wCS_SubmarineDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_SubmarineDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
								byte? b = wCS_SubmarineDoctrine.HasValue ? new byte?((byte)wCS_SubmarineDoctrine.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									flag = false;
									result = false;
									return result;
								}
							}
							else
							{
								Doctrine._WeaponControlStatus? wCS_LandDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_LandDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
								byte? b = wCS_LandDoctrine.HasValue ? new byte?((byte)wCS_LandDoctrine.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									flag = false;
									result = false;
									return result;
								}
							}
							flag = true;
						}
						else
						{
							if (postureStance == Misc.PostureStance.Unknown || postureStance == Misc.PostureStance.Unfriendly)
							{
								if (theTarget.IsAirSpace())
								{
									Doctrine._WeaponControlStatus? wCS_AirDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_AirDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
									byte? b = wCS_AirDoctrine.HasValue ? new byte?((byte)wCS_AirDoctrine.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										flag = true;
										result = true;
										return result;
									}
								}
								else if (theTarget.IsSurface())
								{
									Doctrine._WeaponControlStatus? wCS_SurfaceDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_SurfaceDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
									byte? b = wCS_SurfaceDoctrine.HasValue ? new byte?((byte)wCS_SurfaceDoctrine.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										flag = true;
										result = true;
										return result;
									}
								}
								else if (theTarget.IsSubSurface())
								{
									if (theTarget.contactType == Contact_Base.ContactType.Torpedo)
									{
										flag = true;
										result = true;
										return result;
									}
									Doctrine._WeaponControlStatus? wCS_SubmarineDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_SubmarineDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
									byte? b = wCS_SubmarineDoctrine.HasValue ? new byte?((byte)wCS_SubmarineDoctrine.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										flag = true;
										result = true;
										return result;
									}
								}
								else
								{
									Doctrine._WeaponControlStatus? wCS_LandDoctrine = this.m_ActiveUnit.m_Doctrine.GetWCS_LandDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
									byte? b = wCS_LandDoctrine.HasValue ? new byte?((byte)wCS_LandDoctrine.GetValueOrDefault()) : null;
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										flag = true;
										result = true;
										return result;
									}
								}
							}
							if (this.m_ActiveUnit.GetSide(false).GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref theTarget) > 0)
							{
								flag = true;
								result = true;
								return result;
							}
							flag = false;
							result = false;
							return result;
						}
					}
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100062", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000AC6A0 File Offset: 0x000AA8A0
		public virtual void vmethod_22(float elapsedTime_, ref Weapon weapon_)
		{
			try
			{
				ActiveUnit_AI.WeaponMaxRangeGetter weaponMaxRangeGetter = new ActiveUnit_AI.WeaponMaxRangeGetter();
				weaponMaxRangeGetter.m_AI = this;
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					weaponMaxRangeGetter.doctrine = this.m_ActiveUnit.m_Doctrine;
					if (Information.IsNothing(weapon_))
					{
						Side side = this.m_ActiveUnit.GetSide(false);
						Contact primaryTarget = this.GetPrimaryTarget();
						List<Weapon> weaponsForTarget = side.GetWeaponsForTarget(ref this.m_ActiveUnit, ref primaryTarget);
						this.SetPrimaryTarget(primaryTarget);
						List<Weapon> list = weaponsForTarget;
						if (list.Count > 0)
						{
							weapon_ = list.OrderByDescending(new Func<Weapon, float>(weaponMaxRangeGetter.GetMaxRange)).ElementAtOrDefault(0);
						}
						else
						{
							weapon_ = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), false, true, weaponMaxRangeGetter.doctrine);
						}
					}
					if (!Information.IsNothing(weapon_))
					{
						float maxRangeToTarget = weapon_.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, weaponMaxRangeGetter.doctrine, false);
						float float_;
						if (this.GetPrimaryTarget().GetCurrentSpeed() == 0f)
						{
							float_ = this.m_ActiveUnit.GetCurrentSpeed();
						}
						else
						{
							float_ = this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading());
						}
						Weapon._WeaponType weaponType = weapon_.GetWeaponType();
						float num = 0f;
						if (weaponType != Weapon._WeaponType.Rocket && weaponType != Weapon._WeaponType.Gun)
						{
							num = weapon_.LaunchAltitudeMax;
						}
						else if (this.m_ActiveUnit.GetSlantRange(this.GetPrimaryTarget(), 0f) > maxRangeToTarget)
						{
							num = (float)(Math.Sqrt(2.0) / 2.0 * (double)maxRangeToTarget * 1852.0);
						}
						float num2 = 0f;
						if (num < this.m_ActiveUnit.GetDesiredAltitude())
						{
							num2 = (this.m_ActiveUnit.GetDesiredAltitude() - num) / this.m_ActiveUnit.GetKinematics().vmethod_19();
						}
						if (weapon_.LaunchAltitudeMin > this.m_ActiveUnit.GetDesiredAltitude())
						{
							num2 = (weapon_.LaunchAltitudeMin - this.m_ActiveUnit.GetDesiredAltitude()) / this.m_ActiveUnit.GetKinematics().GetClimbRate();
						}
						float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
						float num3;
						if (horizontalRange > maxRangeToTarget)
						{
							float float_2 = horizontalRange - maxRangeToTarget;
							num3 = this.m_ActiveUnit.method_49(float_, float_2);
						}
						else
						{
							num3 = 0f;
						}
						if (num3 >= 0f)
						{
							if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
							{
								bool flag = false;
								if (num2 >= num3)
								{
									if (num < this.m_ActiveUnit.GetDesiredAltitude())
									{
										this.m_ActiveUnit.SetDesiredAltitude(num - 100f);
										flag = true;
									}
									if (weapon_.LaunchAltitudeMin > this.m_ActiveUnit.GetDesiredAltitude())
									{
										this.m_ActiveUnit.SetDesiredAltitude(weapon_.LaunchAltitudeMin + 100f);
										flag = true;
									}
									if (!flag)
									{
										this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetDesiredAltitude());
									}
								}
							}
							if ((double)maxRangeToTarget * 1.2 < (double)horizontalRange)
							{
								this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
							}
							else
							{
								if (weapon_.LaunchSpeedMax != 0 && (float)weapon_.LaunchSpeedMax < this.m_ActiveUnit.GetCurrentSpeed())
								{
									this.m_ActiveUnit.SetDesiredSpeed((float)(weapon_.LaunchSpeedMax - 10));
								}
								if (weapon_.LaunchSpeedMin != 0 && (float)weapon_.LaunchSpeedMin > this.m_ActiveUnit.GetCurrentSpeed())
								{
									this.m_ActiveUnit.SetDesiredSpeed((float)(weapon_.LaunchSpeedMin + 10));
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
				ex2.Data.Add("Error at 100063", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x000ACAC8 File Offset: 0x000AACC8
		public void RunPerpendicularTo(int BearingToPrimaryTarget_)
		{
			try
			{
				int num = (int)Math.Round((double)this.m_ActiveUnit.GetCurrentHeading());
				int num2 = 0;
				int num3 = 0;
				int num4 = num;
				while (!Class263.IsPerpendicular(num4, BearingToPrimaryTarget_))
				{
					num4 = Math2.Normalize(num4 - 1);
					num2++;
				}
				int num5 = num;
				while (!Class263.IsPerpendicular(num5, BearingToPrimaryTarget_))
				{
					num5 = Math2.Normalize(num5 + 1);
					num3++;
				}
				if (num2 < num3)
				{
					this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num4);
				}
				else
				{
					this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num5);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100064", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void ThreatAssessment()
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000ACBA8 File Offset: 0x000AADA8
		protected void TryToClearTheMine(UnguidedWeapon theMine_, float distanceToMine_)
		{
			try
			{
				if (this.m_ActiveUnit.GetMineCounterMeasures().Count != 0)
				{
					if (distanceToMine_ * 1852f < 20f)
					{
						foreach (Sensor current in this.m_ActiveUnit.GetMineCounterMeasures())
						{
							if (current.IsMineNeutralization() && current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								this.m_ActiveUnit.NeutralizeMine(theMine_, current);
								return;
							}
						}
					}
					GeoPoint geoPoint = new GeoPoint();
					if ((double)distanceToMine_ > 0.6)
					{
						double longitude = this.m_ActiveUnit.GetLongitude(null);
						double latitude = this.m_ActiveUnit.GetLatitude(null);
						GeoPoint geoPoint2;
						double longitude2 = (geoPoint2 = geoPoint).GetLongitude();
						GeoPoint geoPoint3;
						double latitude2 = (geoPoint3 = geoPoint).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)(distanceToMine_ / 2f), (double)Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), theMine_.GetLatitude(null), theMine_.GetLongitude(null)));
						geoPoint3.SetLatitude(latitude2);
						geoPoint2.SetLongitude(longitude2);
						if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
						{
							this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].SetLatitude(geoPoint.GetLatitude());
							this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].SetLongitude(geoPoint.GetLongitude());
						}
						else
						{
							this.m_ActiveUnit.GetNavigator().AddWaypoint(new Waypoint(geoPoint.GetLongitude(), geoPoint.GetLatitude(), Waypoint.WaypointType.PatrolStation, Waypoint._Creator.const_1, Waypoint._Category.const_0));
						}
					}
					else
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), theMine_.GetLatitude(null), theMine_.GetLongitude(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100065", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000ACE54 File Offset: 0x000AB054
		protected void NavigateToClearTheMine(UnguidedWeapon theMine_, float HorizontalRange_)
		{
			try
			{
				if (this.m_ActiveUnit.GetMineCounterMeasures().Count != 0 && ((double)HorizontalRange_ >= 0.5 || !this.m_ActiveUnit.GetNavigator().HasPlottedCourse()))
				{
					Sensor sensor = this.m_ActiveUnit.GetMineCounterMeasures()[0];
					if (Information.IsNothing(sensor.GetMineSweepingAreaVertices()))
					{
						if (!this.m_ActiveUnit.GetNavigator().HasPlottedCourse() && !Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
						{
							this.m_ActiveUnit.GetNavigator().HeadingToTheArea(((MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false)).AreaVertices);
						}
					}
					else
					{
						GeoPoint geoPoint = Misc.smethod_50(sensor.GetMineSweepingAreaVertices());
						float num;
						if (this.m_ActiveUnit.IsAircraft)
						{
							num = 0f;
						}
						else
						{
							num = Math.Abs(Class263.RelativeBearingTo(this.m_ActiveUnit.GetCurrentHeading(), Math2.GetAzimuth(geoPoint.GetLatitude(), geoPoint.GetLongitude(), this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null)))) + 15f;
						}
						float num2 = (float)((double)Math2.GetDistance(geoPoint.GetLatitude(), geoPoint.GetLongitude(), this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null)) + 0.1);
						if (this.m_ActiveUnit.IsAircraft)
						{
							num2 *= 4f;
						}
						GeoPoint geoPoint2 = new GeoPoint();
						double longitude = theMine_.GetLongitude(null);
						double latitude = theMine_.GetLatitude(null);
						GeoPoint geoPoint3;
						double longitude2 = (geoPoint3 = geoPoint2).GetLongitude();
						GeoPoint geoPoint4;
						double latitude2 = (geoPoint4 = geoPoint2).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num2, (double)Math2.Normalize(num + Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), theMine_.GetLatitude(null), theMine_.GetLongitude(null))));
						geoPoint4.SetLatitude(latitude2);
						geoPoint3.SetLongitude(longitude2);
						if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
						{
							this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].SetLatitude(geoPoint2.GetLatitude());
							this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].SetLongitude(geoPoint2.GetLongitude());
						}
						else
						{
							this.m_ActiveUnit.GetNavigator().AddWaypoint(new Waypoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude(), Waypoint.WaypointType.PatrolStation, Waypoint._Creator.const_1, Waypoint._Category.const_0));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100066", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000AD1A0 File Offset: 0x000AB3A0
		public bool IsRegroupNeeded()
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(this.m_ActiveUnit))
				{
					flag = false;
				}
				else if (!this.m_ActiveUnit.IsGroupLead())
				{
					flag = false;
				}
				else if (!this.m_ActiveUnit.GetParentGroup(false).GetGroupKinematics().GetLATSD())
				{
					flag = false;
				}
				else if (this.m_ActiveUnit.GetParentGroup(false).GetGroupType() != Group.GroupType.SurfaceGroup)
				{
					flag = false;
				}
				else
				{
					IEnumerable<ActiveUnit> source = this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values.Where(new Func<ActiveUnit, bool>(this.IsActiveAndSameTypeWith)).ToList<ActiveUnit>();
					for (int i = source.Count<ActiveUnit>() - 1; i >= 0; i += -1)
					{
						if (!source.ElementAtOrDefault(i).GetNavigator().IsOnFormationStation())
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
				ex2.Data.Add("Error at 200356", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000AD2C8 File Offset: 0x000AB4C8
		public virtual void Navigate(float elapsedTime_)
		{
			try
			{
				if (!this.m_ActiveUnit.IsSatellite())
				{
					if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive && (this.m_ActiveUnit.IsAircraft || this.m_ActiveUnit.IsShip || this.m_ActiveUnit.IsSubmarine))
					{
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
						this.EngagedDefensive(elapsedTime_);
					}
					else
					{
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
							byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
								return;
							}
						}
						if (this.m_ActiveUnit.IsRTB())
						{
							if (((Aircraft)this.m_ActiveUnit).GetAircraftNavigator().method_66(((Aircraft)this.m_ActiveUnit).GetAircraftAirOps().GetAssignedHostUnit(true)))
							{
								if (!((Aircraft)this.m_ActiveUnit).GetAircraftAirOps().GetAssignedHostUnit(true).GetAirOps().GetLandingQueue().Contains((Aircraft)this.m_ActiveUnit))
								{
									((Aircraft)this.m_ActiveUnit).GetAircraftAirOps().GetAssignedHostUnit(true).GetAirOps().HoldOnLanding((Aircraft)this.m_ActiveUnit);
								}
								((Aircraft)this.m_ActiveUnit).GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
							}
							else
							{
								Aircraft_Navigator aircraftNavigator = ((Aircraft)this.m_ActiveUnit).GetAircraftNavigator();
								ActiveUnit assignedHostUnit = ((Aircraft)this.m_ActiveUnit).GetAircraftAirOps().GetAssignedHostUnit(true);
								float desiredSpeed_ = (float)this.m_ActiveUnit.GetKinematics().GetSpeed(((Aircraft)this.m_ActiveUnit).GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise);
								Aircraft_Navigator aircraftNavigator2 = ((Aircraft)this.m_ActiveUnit).GetAircraftNavigator();
								ActiveUnit activeUnit;
								ActiveUnit activeUnit2;
								bool bool_ = (activeUnit = this.m_ActiveUnit).IsTerrainFollowing(activeUnit2 = this.m_ActiveUnit);
								float transitAltitude = aircraftNavigator2.GetTransitAltitude(ref bool_);
								activeUnit.SetIsTerrainFollowing(activeUnit2, bool_);
								ActiveUnit activeUnit3;
								ActiveUnit activeUnit4;
								bool bool_2 = (activeUnit3 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit4 = this.m_ActiveUnit);
								aircraftNavigator.method_68(assignedHostUnit, desiredSpeed_, transitAltitude, ref bool_2);
								activeUnit3.SetIsTerrainFollowing(activeUnit4, bool_2);
							}
						}
						if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
								if (contactType <= Contact_Base.ContactType.Missile)
								{
									this.m_ActiveUnit.SetDesiredSpeed(0f);
								}
								else
								{
									if (this.m_ActiveUnit.GetThrottle() < ActiveUnit.Throttle.Full)
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
									}
									this.vmethod_18(elapsedTime_);
									Weapon weapon = null;
									this.vmethod_22(elapsedTime_, ref weapon);
								}
							}
						}
						else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
						{
							this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							if (this.m_ActiveUnit.IsGroupLead())
							{
								this.m_ActiveUnit.SetDesiredSpeed(this.m_ActiveUnit.GetParentGroup(false).GetDesiredSpeed());
							}
						}
						else
						{
							if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.OnPatrol)
							{
								Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
								if (Information.IsNothing(patrol))
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
									if (this.m_ActiveUnit.IsSubmarine && !this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
									{
										if (this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref patrol.PatrolAreaVertices, ref patrol.list_11, ref patrol.list_7, 2f, false))
										{
											if (patrol.TransitDepth_Submarine.Value < 0f)
											{
												this.m_ActiveUnit.SetDesiredAltitude(patrol.TransitDepth_Submarine.Value);
											}
										}
										else if (patrol.StationDepth_Submarine.Value < 0f)
										{
											this.m_ActiveUnit.SetDesiredAltitude(patrol.StationDepth_Submarine.Value);
										}
									}
								}
								else
								{
									if (!this.m_ActiveUnit.HasParentGroup())
									{
										if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
										{
											if (!this.m_ActiveUnit.GetNavigator().method_30(ref patrol.PatrolAreaVertices, ref patrol.list_14, ref patrol.list_10, 30f, false))
											{
												this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
											}
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else
										{
											this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
										}
										return;
									}
									if (this.m_ActiveUnit.IsGroupLead())
									{
										if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
										{
											if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref patrol.PatrolAreaVertices, ref patrol.list_14, ref patrol.list_10, 30f, false))
											{
												this.m_ActiveUnit.GetParentGroup(false).GetNavigator().SetDesiredHeading();
											}
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else
										{
											this.m_ActiveUnit.GetParentGroup(false).GetNavigator().SetDesiredHeading();
										}
										return;
									}
									this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
									return;
								}
							}
							if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.OnSupportMission)
							{
								if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
								}
								else
								{
									if (!this.m_ActiveUnit.HasParentGroup())
									{
										this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
										return;
									}
									if (this.m_ActiveUnit.IsGroupLead())
									{
										this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
										return;
									}
									if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
									{
										this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
										return;
									}
								}
							}
							if (this.m_ActiveUnit.HasParentGroup() && this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
							{
								this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
							}
							else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned)
							{
								this.m_ActiveUnit.SetDesiredSpeed(0f);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100068", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000ADA28 File Offset: 0x000ABC28
		public virtual void SetDesiredAltitude()
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
			{
				switch (((Aircraft)this.m_ActiveUnit).GetAircraftAI().GetAltitudePreset())
				{
				case ActiveUnit_AI._AltitudePreset.MinAltitude:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(0f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetKinematics().GetMinAltitude());
					}
					break;
				case ActiveUnit_AI._AltitudePreset.LowAltitude1000:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(304.8f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(304.8f);
					}
					break;
				case ActiveUnit_AI._AltitudePreset.LowAltitude2000:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(609.6f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(609.6f);
					}
					break;
				case ActiveUnit_AI._AltitudePreset.MediumAltitude12000:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(3657.6f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(3657.6f);
					}
					break;
				case ActiveUnit_AI._AltitudePreset.HighAltitude25000:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(7620f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(7620f);
					}
					break;
				case ActiveUnit_AI._AltitudePreset.HighAltitude36000:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(10972.8f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(10972.8f);
					}
					break;
				case ActiveUnit_AI._AltitudePreset.MaxAltitude:
					if (this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(this.m_ActiveUnit.GetKinematics().GetMaxAltitude());
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetKinematics().GetMaxAltitude());
					}
					break;
				}
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000ADC74 File Offset: 0x000ABE74
		public bool NotExceedRedeployDamageThreshold()
		{
			Doctrine._DamageThreshold? redeployDamageThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetRedeployDamageThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			short? num = redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null;
			bool result;
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					if (this.m_ActiveUnit.GetDamage().GetDamagePts() >= 5f)
					{
						result = false;
						return result;
					}
				}
				else
				{
					num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						if (this.m_ActiveUnit.GetDamage().GetDamagePts() >= 25f)
						{
							result = false;
							return result;
						}
					}
					else
					{
						num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							if (this.m_ActiveUnit.GetDamage().GetDamagePts() >= 50f)
							{
								result = false;
								return result;
							}
						}
						else
						{
							num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault() && this.m_ActiveUnit.GetDamage().GetDamagePts() >= 75f)
							{
								result = false;
								return result;
							}
						}
					}
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000ADEC0 File Offset: 0x000AC0C0
		public bool NotExceedRedeployFuelThreshold()
		{
			Doctrine._FuelQuantityThreshold? redeployFuelThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetRedeployFuelThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			short? num = redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null;
			bool result;
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					if (this.m_ActiveUnit.GetFuelState(null) == ActiveUnit._ActiveUnitFuelState.IsBingo)
					{
						result = false;
						return result;
					}
				}
				else
				{
					num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						double num2 = 0.0;
						double num3 = 0.0;
						if ((int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num2, ref num3, false) * 100.0) < 25)
						{
							result = false;
							return result;
						}
					}
					else
					{
						num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							double num4 = 0.0;
							double num5 = 0.0;
							if ((int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num4, ref num5, false) * 100.0) < 50)
							{
								result = false;
								return result;
							}
						}
						else
						{
							num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								double num6 = 0.0;
								double num7 = 0.0;
								if ((int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num6, ref num7, false) * 100.0) < 75)
								{
									result = false;
									return result;
								}
							}
							else
							{
								num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
								double num8 = 0.0;
								double num9 = 0.0;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault() && (int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num8, ref num9, false) * 100.0) < 100)
								{
									result = false;
									return result;
								}
							}
						}
					}
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000AE218 File Offset: 0x000AC418
		public bool NotExceedRedeployAttackWeaponQuantityThreshold()
		{
			Doctrine._WeaponQuantityThreshold? redeployAttackWeaponQuantityThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			short? num = redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null;
			bool result;
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					Weapon weapon = this.m_ActiveUnit.GetWeaponry().vmethod_11();
					if (!Information.IsNothing(weapon) && this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon.DBID, false) == 0)
					{
						result = false;
						return result;
					}
				}
				else
				{
					num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						Weapon weapon2 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
						if (!Information.IsNothing(weapon2))
						{
							int currentLoadForWeapon = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon2.DBID, false);
							int defaultLoadForWeapon = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon2.DBID);
							if (currentLoadForWeapon == 0 || (double)currentLoadForWeapon / (double)defaultLoadForWeapon < 0.25)
							{
								result = false;
								return result;
							}
						}
					}
					else
					{
						num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							Weapon weapon3 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
							if (!Information.IsNothing(weapon3))
							{
								int currentLoadForWeapon2 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon3.DBID, false);
								int defaultLoadForWeapon2 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon3.DBID);
								if (currentLoadForWeapon2 == 0 || (double)currentLoadForWeapon2 / (double)defaultLoadForWeapon2 < 0.5)
								{
									result = false;
									return result;
								}
							}
						}
						else
						{
							num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								Weapon weapon4 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
								if (!Information.IsNothing(weapon4))
								{
									int currentLoadForWeapon3 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon4.DBID, false);
									int defaultLoadForWeapon3 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon4.DBID);
									if (currentLoadForWeapon3 == 0 || (double)currentLoadForWeapon3 / (double)defaultLoadForWeapon3 < 0.75)
									{
										result = false;
										return result;
									}
								}
							}
							else
							{
								num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
								{
									Weapon weapon5 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
									if (!Information.IsNothing(weapon5))
									{
										int currentLoadForWeapon4 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon5.DBID, false);
										int defaultLoadForWeapon4 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon5.DBID);
										if (currentLoadForWeapon4 == 0 || currentLoadForWeapon4 != defaultLoadForWeapon4)
										{
											result = false;
											return result;
										}
									}
								}
								else
								{
									num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
									{
										List<WeaponRec> list = this.m_ActiveUnit.GetWeaponry().method_0(false);
										foreach (WeaponRec current in list)
										{
											if (current.DefaultLoad != 0)
											{
												Weapon weapon6 = current.GetWeapon(this.m_ActiveUnit.m_Scenario);
												if (weapon6.TargetIsLandFacility() || weapon6.TargetIsShipOrRadar())
												{
													int currentLoadForWeapon5 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon6.DBID, false);
													int defaultLoadForWeapon5 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon6.DBID);
													if (currentLoadForWeapon5 == 0 || currentLoadForWeapon5 != defaultLoadForWeapon5)
													{
														result = false;
														return result;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000AE780 File Offset: 0x000AC980
		public bool NotExceedRedeployDefenceWeaponQuantityThreshold()
		{
			Doctrine._WeaponQuantityThreshold? redeployDefenceWeaponQuantityThreshold = this.m_ActiveUnit.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(this.m_ActiveUnit.m_Scenario, false, false, false);
			short? num = redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null;
			bool result;
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					Weapon weaponWithMaxRange = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
					if (!Information.IsNothing(weaponWithMaxRange) && this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange.DBID, false) == 0)
					{
						result = false;
						return result;
					}
				}
				else
				{
					num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						Weapon weaponWithMaxRange2 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
						if (!Information.IsNothing(weaponWithMaxRange2))
						{
							int currentLoadForWeapon = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange2.DBID, false);
							int defaultLoadForWeapon = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange2.DBID);
							if (currentLoadForWeapon == 0 || (double)currentLoadForWeapon / (double)defaultLoadForWeapon < 0.25)
							{
								result = false;
								return result;
							}
						}
					}
					else
					{
						num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							Weapon weaponWithMaxRange3 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
							if (!Information.IsNothing(weaponWithMaxRange3))
							{
								int currentLoadForWeapon2 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange3.DBID, false);
								int defaultLoadForWeapon2 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange3.DBID);
								if (currentLoadForWeapon2 == 0 || (double)currentLoadForWeapon2 / (double)defaultLoadForWeapon2 < 0.5)
								{
									result = false;
									return result;
								}
							}
						}
						else
						{
							num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								Weapon weaponWithMaxRange4 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
								if (!Information.IsNothing(weaponWithMaxRange4))
								{
									int currentLoadForWeapon3 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange4.DBID, false);
									int defaultLoadForWeapon3 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange4.DBID);
									if (currentLoadForWeapon3 == 0 || (double)currentLoadForWeapon3 / (double)defaultLoadForWeapon3 < 0.75)
									{
										result = false;
										return result;
									}
								}
							}
							else
							{
								num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
								{
									Weapon weaponWithMaxRange5 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
									if (!Information.IsNothing(weaponWithMaxRange5))
									{
										int currentLoadForWeapon4 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange5.DBID, false);
										int defaultLoadForWeapon4 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange5.DBID);
										if (currentLoadForWeapon4 == 0 || currentLoadForWeapon4 != defaultLoadForWeapon4)
										{
											result = false;
											return result;
										}
									}
								}
								else
								{
									num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
									{
										List<WeaponRec> list = this.m_ActiveUnit.GetWeaponry().method_0(false);
										foreach (WeaponRec current in list)
										{
											if (current.DefaultLoad != 0)
											{
												Weapon weapon = current.GetWeapon(this.m_ActiveUnit.m_Scenario);
												if (weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() || weapon.TargetIsSubsurface())
												{
													int currentLoadForWeapon5 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon.DBID, false);
													int defaultLoadForWeapon5 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon.DBID);
													if (currentLoadForWeapon5 == 0 || currentLoadForWeapon5 != defaultLoadForWeapon5)
													{
														result = false;
														return result;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0001131F File Offset: 0x0000F51F
		public bool NotRedeploy()
		{
			return this.NotExceedRedeployDamageThreshold() && this.NotExceedRedeployFuelThreshold() && this.NotExceedRedeployAttackWeaponQuantityThreshold() && this.NotExceedRedeployDefenceWeaponQuantityThreshold();
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000AECE8 File Offset: 0x000ACEE8
		public bool method_73(ActiveUnit_AI._WithdrawingReason WithdrawingReason_, string strReazon)
		{
			bool result = false;
			switch (WithdrawingReason_)
			{
			case ActiveUnit_AI._WithdrawingReason.Damage:
				if (this.m_ActiveUnit.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
				{
					this.m_ActiveUnit.LogMessage(this.m_ActiveUnit.Name + "正在撤退(原因: " + strReazon + "). ", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
				}
				result = true;
				break;
			case ActiveUnit_AI._WithdrawingReason.FuelLevel:
			{
				bool flag = false;
				if (this.m_ActiveUnit.GetDockingOps().method_51(this.m_ActiveUnit.GetAI().GetIntermediateTargetPoint(), null, null, null, null))
				{
					this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
					flag = true;
				}
				else if (this.m_ActiveUnit.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
				{
					flag = true;
				}
				if (flag)
				{
					this.m_ActiveUnit.LogMessage(this.m_ActiveUnit.Name + "正在撤退(原因: " + strReazon + "). ", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
				}
				result = flag;
				break;
			}
			case ActiveUnit_AI._WithdrawingReason.PrimaryAttackWeapons:
			case ActiveUnit_AI._WithdrawingReason.PrimaryDefenceWeapons:
			{
				bool flag2 = false;
				ActiveUnit_DockingOps dockingOps = this.m_ActiveUnit.GetDockingOps();
				List<Mission> theSelectedMissions = null;
				string text = null;
				List<ActiveUnit> uNREPUnits = dockingOps.GetUNREPUnits(true, theSelectedMissions, ref text);
				if (uNREPUnits.Count > 0)
				{
					Weapon weapon;
					if (WithdrawingReason_ == ActiveUnit_AI._WithdrawingReason.PrimaryAttackWeapons)
					{
						weapon = this.m_ActiveUnit.GetWeaponry().vmethod_12();
					}
					else
					{
						weapon = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
					}
					using (List<ActiveUnit>.Enumerator enumerator = uNREPUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ActiveUnit current = enumerator.Current;
							if (current.GetWeaponry().GetCurrentLoadForWeapon(weapon.DBID, false) > 0 && this.m_ActiveUnit.GetDockingOps().method_51(this.m_ActiveUnit.GetAI().GetIntermediateTargetPoint(), current, null, null, null))
							{
								this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
								flag2 = true;
								IL_245:
								goto IL_273;
							}
						}
						goto IL_273;
					}
				}
				if (this.m_ActiveUnit.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
				{
					flag2 = true;
				}
				IL_273:
				if (flag2)
				{
					this.m_ActiveUnit.LogMessage(this.m_ActiveUnit.Name + "正在撤退(原因: " + strReazon + "). ", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)));
				}
				result = flag2;
				break;
			}
			}
			return result;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000AEFDC File Offset: 0x000AD1DC
		public bool method_74()
		{
			Doctrine._DamageThreshold? withdrawDamageThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetWithdrawDamageThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			short? num = withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null;
			bool flag = false;
			bool result;
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					if (this.m_ActiveUnit.GetDamage().GetDamagePts() >= 5f)
					{
						result = this.method_73(ActiveUnit_AI._WithdrawingReason.Damage, "毁伤超过5%");
						return result;
					}
				}
				else
				{
					num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						if (this.m_ActiveUnit.GetDamage().GetDamagePts() >= 25f)
						{
							result = this.method_73(ActiveUnit_AI._WithdrawingReason.Damage, "毁伤超过25%");
							return result;
						}
					}
					else
					{
						num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							if (this.m_ActiveUnit.GetDamage().GetDamagePts() >= 50f)
							{
								result = this.method_73(ActiveUnit_AI._WithdrawingReason.Damage, "毁伤超过50%");
								return result;
							}
						}
						else
						{
							num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault() && this.m_ActiveUnit.GetDamage().GetDamagePts() >= 75f)
							{
								result = this.method_73(ActiveUnit_AI._WithdrawingReason.Damage, "毁伤超过75%");
								return result;
							}
						}
					}
				}
			}
			Doctrine._FuelQuantityThreshold? withdrawFuelThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetWithdrawFuelThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					ActiveUnit._ActiveUnitFuelState fuelState = this.m_ActiveUnit.GetFuelState(null);
					if (fuelState == ActiveUnit._ActiveUnitFuelState.IsBingo)
					{
						this.m_ActiveUnit.SetFuelState(fuelState);
						result = this.method_73(ActiveUnit_AI._WithdrawingReason.FuelLevel, "燃油处于bingo水平");
						return result;
					}
				}
				else
				{
					num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						double num2 = 0.0;
						double num3 = 0.0;
						if ((int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num2, ref num3, false) * 100.0) < 25)
						{
							result = this.method_73(ActiveUnit_AI._WithdrawingReason.FuelLevel, "燃油低于25%");
							return result;
						}
					}
					else
					{
						num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							double num4 = 0.0;
							double num5 = 0.0;
							if ((int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num4, ref num5, false) * 100.0) < 50)
							{
								result = this.method_73(ActiveUnit_AI._WithdrawingReason.FuelLevel, "燃油低于50%");
								return result;
							}
						}
						else
						{
							num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
							double num6 = 0.0;
							double num7 = 0.0;
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault() && (int)Math.Round(this.m_ActiveUnit.GetFuelLeft(ref num6, ref num7, false) * 100.0) < 75)
							{
								result = this.method_73(ActiveUnit_AI._WithdrawingReason.FuelLevel, "燃油低于75%");
								return result;
							}
						}
					}
				}
			}
			Doctrine._WeaponQuantityThreshold? withdrawAttackThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetWithdrawAttackThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					Weapon weapon = this.m_ActiveUnit.GetWeaponry().vmethod_11();
					if (!Information.IsNothing(weapon) && this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon.DBID, false) == 0)
					{
						result = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryAttackWeapons, "主攻武器(" + weapon.Name + ")已经耗尽");
						return result;
					}
				}
				else
				{
					num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						Weapon weapon2 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
						if (!Information.IsNothing(weapon2))
						{
							int currentLoadForWeapon = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon2.DBID, false);
							int defaultLoadForWeapon = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon2.DBID);
							if (currentLoadForWeapon == 0 || (double)currentLoadForWeapon / (double)defaultLoadForWeapon < 0.25)
							{
								result = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryAttackWeapons, "主攻武器 (" + weapon2.Name + ")低于25%");
								return result;
							}
						}
					}
					else
					{
						num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							Weapon weapon3 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
							if (!Information.IsNothing(weapon3))
							{
								int currentLoadForWeapon2 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon3.DBID, false);
								int defaultLoadForWeapon2 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon3.DBID);
								if (currentLoadForWeapon2 == 0 || (double)currentLoadForWeapon2 / (double)defaultLoadForWeapon2 < 0.5)
								{
									result = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryAttackWeapons, "主攻武器(" + weapon3.Name + ") 低于50%");
									return result;
								}
							}
						}
						else
						{
							num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								Weapon weapon4 = this.m_ActiveUnit.GetWeaponry().vmethod_11();
								if (!Information.IsNothing(weapon4))
								{
									int currentLoadForWeapon3 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weapon4.DBID, false);
									int defaultLoadForWeapon3 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weapon4.DBID);
									if (currentLoadForWeapon3 == 0 || (double)currentLoadForWeapon3 / (double)defaultLoadForWeapon3 < 0.75)
									{
										result = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryAttackWeapons, "主攻武器(" + weapon4.Name + ") 低于75%");
										return result;
									}
								}
							}
						}
					}
				}
			}
			Doctrine._WeaponQuantityThreshold? withdrawDefenceThresholdDoctrine = this.m_ActiveUnit.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
			num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					Weapon weaponWithMaxRange = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
					if (!Information.IsNothing(weaponWithMaxRange) && this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange.DBID, false) == 0)
					{
						flag = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryDefenceWeapons, "主要防御武器(" + weaponWithMaxRange.Name + ") now exhausted");
					}
				}
				else
				{
					num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						Weapon weaponWithMaxRange2 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
						if (!Information.IsNothing(weaponWithMaxRange2))
						{
							int currentLoadForWeapon4 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange2.DBID, false);
							int defaultLoadForWeapon4 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange2.DBID);
							if (currentLoadForWeapon4 == 0 || (double)currentLoadForWeapon4 / (double)defaultLoadForWeapon4 < 0.25)
							{
								flag = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryDefenceWeapons, "主要防御武器(" + weaponWithMaxRange2.Name + ")低于25%");
							}
						}
					}
					else
					{
						num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							Weapon weaponWithMaxRange3 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
							if (!Information.IsNothing(weaponWithMaxRange3))
							{
								int currentLoadForWeapon5 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange3.DBID, false);
								int defaultLoadForWeapon5 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange3.DBID);
								if (currentLoadForWeapon5 == 0 || (double)currentLoadForWeapon5 / (double)defaultLoadForWeapon5 < 0.5)
								{
									flag = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryDefenceWeapons, "主要防御武器(" + weaponWithMaxRange3.Name + ")低于50%");
								}
							}
						}
						else
						{
							num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								Weapon weaponWithMaxRange4 = this.m_ActiveUnit.GetWeaponry().GetWeaponWithMaxRange();
								if (!Information.IsNothing(weaponWithMaxRange4))
								{
									int currentLoadForWeapon6 = this.m_ActiveUnit.GetWeaponry().GetCurrentLoadForWeapon(weaponWithMaxRange4.DBID, false);
									int defaultLoadForWeapon6 = this.m_ActiveUnit.GetWeaponry().GetDefaultLoadForWeapon(weaponWithMaxRange4.DBID);
									if (currentLoadForWeapon6 == 0 || (double)currentLoadForWeapon6 / (double)defaultLoadForWeapon6 < 0.75)
									{
										flag = this.method_73(ActiveUnit_AI._WithdrawingReason.PrimaryDefenceWeapons, "主要防御武器(" + weaponWithMaxRange4.Name + ")低于75%");
									}
								}
							}
						}
					}
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000AFD40 File Offset: 0x000ADF40
		public virtual void SetDesiredDepth(bool bool_6)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
			{
				Submarine_AI submarineAI = ((Submarine)this.m_ActiveUnit).GetSubmarineAI();
				float num = 0f;
				switch (submarineAI.GetDepthPreset())
				{
				case ActiveUnit_AI._DepthPreset.None:
					return;
				case ActiveUnit_AI._DepthPreset.Periscope:
					num = -20f;
					break;
				case ActiveUnit_AI._DepthPreset.Shallow:
					num = -40f;
					break;
				case ActiveUnit_AI._DepthPreset.OverLayer:
					num = Submarine_AI.GetJustOverLayerDepth(this.m_ActiveUnit);
					break;
				case ActiveUnit_AI._DepthPreset.UnderLayer:
					num = Submarine_AI.GetJustUnderLayerDepth(this.m_ActiveUnit);
					break;
				case ActiveUnit_AI._DepthPreset.MaxDepth:
					num = this.m_ActiveUnit.GetKinematics().GetMinAltitude();
					break;
				case ActiveUnit_AI._DepthPreset.Surface:
					num = 0f;
					break;
				}
				if (bool_6)
				{
					if (num >= -20f && !submarineAI.method_98(this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive || this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive, null, -1.0, -1.0))
					{
						this.m_ActiveUnit.SetDesiredAltitude(-40f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(num);
					}
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(num);
				}
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00011342 File Offset: 0x0000F542
		private void method_75(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit_AI.TargetingEntry> e)
		{
			this.contact_3 = null;
			this.hashSet_0 = null;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000AFE7C File Offset: 0x000AE07C
		private void ExportEngagementCycle(string strCycleAction, Contact contact_8, Side side_0, Scenario scenario_0, string string_2)
		{
			try
			{
				foreach (IEventExporter current in scenario_0.GetEventExporters())
				{
					if (current.IsExportEngagementCycle())
					{
						Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
						dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), scenario_0.TimelineID));
						if (current.IsUseZeroHour())
						{
							TimeSpan timeSpan = scenario_0.GetCurrentTime(false).Subtract(scenario_0.ZeroHour);
							dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
						}
						else
						{
							dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), scenario_0.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.GetCurrentTime(false).Millisecond.ToString("D3")));
						}
						if (Information.IsNothing(this.m_ActiveUnit))
						{
							dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), ""));
							dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), ""));
							dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), ""));
						}
						else
						{
							dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), this.m_ActiveUnit.GetGuid()));
							dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), this.m_ActiveUnit.Name));
							dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), this.m_ActiveUnit.UnitClass));
						}
						if (Information.IsNothing(side_0))
						{
							dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), ""));
						}
						else
						{
							dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), side_0.GetSideName()));
						}
						dictionary.Add("CycleAction", new Tuple<Type, string>(typeof(string), strCycleAction));
						dictionary.Add("ContactID", new Tuple<Type, string>(typeof(string), contact_8.GetGuid()));
						dictionary.Add("ContactName", new Tuple<Type, string>(typeof(string), contact_8.Name));
						dictionary.Add("ContactLongitude", new Tuple<Type, string>(typeof(double), contact_8.GetLongitude(null).ToString()));
						dictionary.Add("ContactLatitude", new Tuple<Type, string>(typeof(double), contact_8.GetLatitude(null).ToString()));
						if (Information.IsNothing(this.m_ActiveUnit))
						{
							dictionary.Add("ContactRangeHoriz_nm", new Tuple<Type, string>(typeof(float), ""));
							dictionary.Add("ContactRangeSlant_nm", new Tuple<Type, string>(typeof(float), ""));
						}
						else
						{
							dictionary.Add("ContactRangeHoriz_nm", new Tuple<Type, string>(typeof(float), this.m_ActiveUnit.GetHorizontalRange(contact_8).ToString()));
							dictionary.Add("ContactRangeSlant_nm", new Tuple<Type, string>(typeof(float), this.m_ActiveUnit.GetSlantRange(contact_8, 0f).ToString()));
						}
						if (!Information.IsNothing(contact_8.ActualUnit))
						{
							dictionary.Add("ContactActualUnitID", new Tuple<Type, string>(typeof(string), contact_8.ActualUnit.GetGuid()));
							dictionary.Add("ContactActualUnitName", new Tuple<Type, string>(typeof(string), contact_8.ActualUnit.Name));
							dictionary.Add("ContactActualUnitClass", new Tuple<Type, string>(typeof(string), contact_8.ActualUnit.UnitClass));
							dictionary.Add("ContactActualUnitSide", new Tuple<Type, string>(typeof(string), contact_8.ActualUnit.GetSide(false).GetSideName()));
						}
						dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), string_2));
						current.ExportEvent(ExportedEventType.EngagementCycle, dictionary, scenario_0);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x000B035C File Offset: 0x000AE55C
		public float method_77(ref Aircraft aircraft_0, ref double double_4, ref double double_5)
		{
			float result;
			if (!Information.IsNothing(aircraft_0.GetLoadout().GetMissionProfile(aircraft_0.m_Scenario).FormUpAltitude))
			{
				float num = (float)Terrain.GetElevation(double_4, double_5, false);
				if (num > 0f)
				{
					num = (float)(Math.Round((double)(num * 3.28084f / 1000f), 0) * 1000.0 / 3.2808399200439453);
				}
				else
				{
					num = 0f;
				}
				if (aircraft_0.GetLoadout().GetMissionProfile(aircraft_0.m_Scenario).FormUpAltitude > 0f)
				{
					result = aircraft_0.GetLoadout().GetMissionProfile(aircraft_0.m_Scenario).FormUpAltitude + num;
				}
				else
				{
					result = 609.6f + num;
				}
			}
			else
			{
				result = 609.6f;
			}
			return result;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000B0438 File Offset: 0x000AE638
		public float method_78(ref Aircraft aircraft_, ActiveUnit.Throttle throttle_, ref bool bool_6)
		{
			float maxAltitude = aircraft_.GetAircraftKinematics().GetMaxAltitude();
			bool_6 = false;
			float result;
			if (aircraft_.GetEngines()[0].altBands.Length >= 4)
			{
				if (maxAltitude * 3.28084f > 60001f)
				{
					if (!Information.IsNothing(throttle_))
					{
						result = aircraft_.GetEngines()[0].GetAltBand(throttle_).MaxAltitude;
					}
					else
					{
						result = maxAltitude;
					}
				}
				else if (!Information.IsNothing(throttle_))
				{
					result = aircraft_.GetEngines()[0].GetAltBand(throttle_).MinAltitude;
				}
				else
				{
					result = 10972.8f;
				}
			}
			else if (aircraft_.GetEngines()[0].altBands.Length != 1 && !aircraft_.IsRotaryWingAircraft())
			{
				if (!Information.IsNothing(throttle_))
				{
					result = aircraft_.GetEngines()[0].GetAltBand(throttle_).MaxAltitude;
				}
				else
				{
					result = maxAltitude;
				}
			}
			else if (maxAltitude >= 609.600037f)
			{
				result = 609.600037f;
			}
			else
			{
				result = maxAltitude;
			}
			return result;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000B0550 File Offset: 0x000AE750
		public virtual void vmethod_27(float float_1)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				try
				{
					ActiveUnit assignedHostUnit = this.m_ActiveUnit.GetDockingOps().GetAssignedHostUnit();
					if (Information.IsNothing(assignedHostUnit) || assignedHostUnit.IsNotActive() || !assignedHostUnit.GetDockingOps().method_37(this.m_ActiveUnit))
					{
						this.m_ActiveUnit.GetDockingOps().method_40(null);
						assignedHostUnit = this.m_ActiveUnit.GetDockingOps().GetAssignedHostUnit();
					}
					if (Information.IsNothing(assignedHostUnit))
					{
						if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
						{
							this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
						}
					}
					else
					{
						float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(assignedHostUnit);
						if (this.m_ActiveUnit.GetCurrentSpeed() == 0f && horizontalRange < 1f && this.m_ActiveUnit.GetCurrentFuelQuantity() == 0)
						{
							this.m_ActiveUnit.GetDockingOps().method_45(assignedHostUnit, false);
						}
						else if (horizontalRange * 1852f < 100f)
						{
							this.m_ActiveUnit.GetDockingOps().method_45(assignedHostUnit, false);
						}
						else
						{
							if (!this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
							{
								this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
								this.m_ActiveUnit.GetNavigator().AddWaypoint(new Waypoint(assignedHostUnit.GetLongitude(null), assignedHostUnit.GetLatitude(null), Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint._Creator.const_1, Waypoint._Category.const_0));
								this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
							}
							else
							{
								this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
							}
							this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100819", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000B0770 File Offset: 0x000AE970
		[CompilerGenerated]
		private float RangeTo(ActiveUnit activeUnit_)
		{
			return activeUnit_.GetHorizontalRange(this.m_ActiveUnit);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000B078C File Offset: 0x000AE98C
		[CompilerGenerated]
		private bool HasWeaponsToAttackTargetNow(Contact target)
		{
			ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
			Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
			string text = "";
			int num = 0;
			return weaponry.HasWeaponsInConditionToAttackTarget(target, true, doctrine, ref text, ref num, null) && this.method_29(target);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x000B07D4 File Offset: 0x000AE9D4
		[CompilerGenerated]
		private float GetHorizontalRange(Contact target)
		{
			return this.m_ActiveUnit.GetHorizontalRange(target);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00011352 File Offset: 0x0000F552
		[CompilerGenerated]
		private bool IsFriendlySide(UnguidedWeapon unguidedWeapon)
		{
			return unguidedWeapon.GetSide(false) == this.m_ActiveUnit.GetSide(false) || this.m_ActiveUnit.GetSide(false).IsFriendlyToSide(unguidedWeapon.GetSide(false));
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x000B07F0 File Offset: 0x000AE9F0
		[CompilerGenerated]
		private float GetHorizontalRange(ActiveUnit_AI.TargetingEntry targetingEntry_1)
		{
			return this.m_ActiveUnit.GetHorizontalRange(targetingEntry_1.Target);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00011384 File Offset: 0x0000F584
		[CompilerGenerated]
		private bool IsActiveAndSameTypeWith(ActiveUnit activeUnit_1)
		{
			return activeUnit_1 != this.m_ActiveUnit && activeUnit_1.IsOperating() && activeUnit_1.GetType() == this.m_ActiveUnit.GetType();
		}

		// Token: 0x04000B4A RID: 2890
		public static Func<ActiveUnit_AI.TargetingEntry, bool> TargetingEntryFunc0 = (ActiveUnit_AI.TargetingEntry targetingEntry_0) => !Information.IsNothing(targetingEntry_0.Target);

		// Token: 0x04000B4B RID: 2891
		public static Func<ActiveUnit_AI.TargetingEntry, Contact> TargetingEntryFunc1 = (ActiveUnit_AI.TargetingEntry targetingEntry_0) => targetingEntry_0.Target;

		// Token: 0x04000B4C RID: 2892
		public static Func<Weapon, float> WeaponMaxRange = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x04000B4D RID: 2893
		public static Func<Contact, Contact> ContactFunc3 = (Contact contact_0) => contact_0;

		// Token: 0x04000B4E RID: 2894
		public static Func<Contact, float?> ContactFunc4 = (Contact contact_0) => ActiveUnit_AI.imethod_4(contact_0);

		// Token: 0x04000B4F RID: 2895
		public static Func<Weapon, bool> IsMine = (Weapon weapon_0) => weapon_0.IsMine();

		// Token: 0x04000B50 RID: 2896
		public static Func<Weapon, float> WeaponLaunchAltitudeMax_ASL = (Weapon weapon_0) => weapon_0.LaunchAltitudeMax_ASL;

		// Token: 0x04000B51 RID: 2897
		public static Func<Weapon, float> WeaponLaunchAltitudeMin_ASL = (Weapon weapon_0) => weapon_0.LaunchAltitudeMin_ASL;

		// Token: 0x04000B52 RID: 2898
		public static Func<Weapon, float> WeaponLaunchAltitudeMax = (Weapon weapon_0) => weapon_0.LaunchAltitudeMax;

		// Token: 0x04000B53 RID: 2899
		public static Func<Weapon, float> WeaponLaunchAltitudeMin = (Weapon weapon_0) => weapon_0.LaunchAltitudeMin;

		// Token: 0x04000B54 RID: 2900
		public static Func<Weapon, bool> WeaponFunc10 = (Weapon weapon_0) => weapon_0.IsMine();

		// Token: 0x04000B55 RID: 2901
		public static Func<Contact, bool> ContactFunc11 = (Contact contact_0) => contact_0.IsSurface() || contact_0.IsSubSurface() || contact_0.IsFacilityType();

		// Token: 0x04000B56 RID: 2902
		public static Func<Contact, bool> ContactFunc12 = (Contact contact_0) => contact_0.IsSurface() || contact_0.IsSubSurface() || contact_0.IsFacilityType();

		// Token: 0x04000B57 RID: 2903
		public static Func<Contact, bool> ContactFunc13 = (Contact contact_0) => contact_0.IsFacilityType() || contact_0.IsFacilityType();

		// Token: 0x04000B58 RID: 2904
		public static Func<Contact, Contact> ContactFunc14 = (Contact contact_0) => contact_0;

		// Token: 0x04000B59 RID: 2905
		public static Func<Contact, Contact> ContactFunc15 = (Contact contact_0) => contact_0;

		// Token: 0x04000B5A RID: 2906
		public static Func<Contact, int> ContactFunc16 = (Contact contact_0) => contact_0.method_92().Length;

		// Token: 0x04000B5B RID: 2907
		public static Func<Waypoint, bool> IsPathfindingPoint = (Waypoint waypoint_0) => !Information.IsNothing(waypoint_0) && waypoint_0.waypointType == Waypoint.WaypointType.PathfindingPoint;

		// Token: 0x04000B5C RID: 2908
		public static Func<AirFacility, bool> AirFacilityFunc18 = (AirFacility airFacility_0) => airFacility_0.method_35();

		// Token: 0x04000B5D RID: 2909
		public static Func<ActiveUnit_AI.TargetingEntry, ActiveUnit_AI.TargetingEntry> TargetingEntryFunc19 = (ActiveUnit_AI.TargetingEntry targetingEntry_0) => targetingEntry_0;

		// Token: 0x04000B5E RID: 2910
		internal ActiveUnit m_ActiveUnit;

		// Token: 0x04000B5F RID: 2911
		protected Contact PrimaryTarget;

		// Token: 0x04000B60 RID: 2912
		protected Contact_Base.ContactType PrimaryTargetType;

		// Token: 0x04000B61 RID: 2913
		protected double PrimaryTarget_LastKnown_Lat;

		// Token: 0x04000B62 RID: 2914
		protected double PrimaryTarget_LastKnown_Lon;

		// Token: 0x04000B63 RID: 2915
		protected float PrimaryTarget_LastKnown_Alt;

		// Token: 0x04000B64 RID: 2916
		protected Contact PrimaryThreat;

		// Token: 0x04000B65 RID: 2917
		public string string_0;

		// Token: 0x04000B66 RID: 2918
		public short TimeToNextPrimaryTargetEvent;

		// Token: 0x04000B67 RID: 2919
		protected bool bPrimaryTargetOverride;

		// Token: 0x04000B68 RID: 2920
		[CompilerGenerated]
		private ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> TargetingEntryDictionary;

		// Token: 0x04000B69 RID: 2921
		protected Contact[] Threats;

		// Token: 0x04000B6A RID: 2922
		protected bool FerryCycleLegIsOutbound;

		// Token: 0x04000B6B RID: 2923
		protected GeoPoint LastKnownTargetLocation;

		// Token: 0x04000B6C RID: 2924
		protected float? SnakeAxis;

		// Token: 0x04000B6D RID: 2925
		protected int int_0;

		// Token: 0x04000B6E RID: 2926
		public GeoPoint geoPoint_1;

		// Token: 0x04000B6F RID: 2927
		public bool IsEscort = false;

		// Token: 0x04000B70 RID: 2928
		public bool bool_3;

		// Token: 0x04000B71 RID: 2929
		public bool HoldPosition;

		// Token: 0x04000B72 RID: 2930
		protected bool bool_5;

		// Token: 0x04000B73 RID: 2931
		protected Dictionary<string, Misc.PostureStance> PostureStanceDictionary;

		// Token: 0x04000B74 RID: 2932
		private Contact[] contact_3;

		// Token: 0x04000B75 RID: 2933
		private HashSet<string> hashSet_0;

		// Token: 0x04000B76 RID: 2934
		private ActiveUnit_AI.TargetingEntry[] TargetingEntryArray;

		// Token: 0x04000B77 RID: 2935
		private double Latitude = 0.0;

		// Token: 0x04000B78 RID: 2936
		private double Longitude = 0.0;

		// Token: 0x04000B79 RID: 2937
		private Contact AirSpaceTarget;

		// Token: 0x04000B7A RID: 2938
		private Contact SurfaceTarget;

		// Token: 0x04000B7B RID: 2939
		private Contact SubSurfaceTarget;

		// Token: 0x04000B7C RID: 2940
		private Contact FixedTarget;

		// Token: 0x04000B7D RID: 2941
		private float? AirTargetDistance;

		// Token: 0x04000B7E RID: 2942
		private float? SurfaceTargetDistance;

		// Token: 0x04000B7F RID: 2943
		private float? SubSurfaceTargetDistance;

		// Token: 0x04000B80 RID: 2944
		private float? FixedTargetDistance;

		// Token: 0x02000423 RID: 1059
		public enum _DepthPreset : byte
		{
			// Token: 0x04000B96 RID: 2966
			None,
			// Token: 0x04000B97 RID: 2967
			Periscope,
			// Token: 0x04000B98 RID: 2968
			Shallow,
			// Token: 0x04000B99 RID: 2969
			OverLayer,
			// Token: 0x04000B9A RID: 2970
			UnderLayer,
			// Token: 0x04000B9B RID: 2971
			MaxDepth,
			// Token: 0x04000B9C RID: 2972
			Surface
		}

		// Token: 0x02000424 RID: 1060
		public enum _AltitudePreset : byte
		{
			// Token: 0x04000B9E RID: 2974
			None,
			// Token: 0x04000B9F RID: 2975
			MinAltitude,
			// Token: 0x04000BA0 RID: 2976
			LowAltitude1000,
			// Token: 0x04000BA1 RID: 2977
			LowAltitude2000,
			// Token: 0x04000BA2 RID: 2978
			MediumAltitude12000,
			// Token: 0x04000BA3 RID: 2979
			HighAltitude25000,
			// Token: 0x04000BA4 RID: 2980
			HighAltitude36000,
			// Token: 0x04000BA5 RID: 2981
			MaxAltitude
		}

		// Token: 0x02000425 RID: 1061
		public enum _WithdrawingReason
		{
			// Token: 0x04000BA7 RID: 2983
			Damage,
			// Token: 0x04000BA8 RID: 2984
			FuelLevel,
			// Token: 0x04000BA9 RID: 2985
			PrimaryAttackWeapons,
			// Token: 0x04000BAA RID: 2986
			PrimaryDefenceWeapons
		}

		// Token: 0x02000426 RID: 1062
		public sealed class TargetingEntry : Subject
		{
			// Token: 0x06001B5E RID: 7006 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
			public void Save(ref XmlWriter xmlWriter_0, Side side_0)
			{
				try
				{
					if (!Information.IsNothing(this.Target))
					{
						xmlWriter_0.WriteStartElement("TE");
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "BHVR";
						byte targetingBehavior = (byte)this.TargetingBehavior;
						xmlWriter.WriteElementString(localName, targetingBehavior.ToString());
						if (!side_0.GetContactObservableDictionary().ContainsKey(this.Target.ActualUnit.GetGuid()))
						{
							xmlWriter_0.WriteStartElement("TGT");
							Contact target = this.Target;
							HashSet<string> hashSet = null;
							target.Save(ref xmlWriter_0, ref hashSet);
							xmlWriter_0.WriteEndElement();
						}
						else
						{
							xmlWriter_0.WriteElementString("TGT", this.Target.GetGuid());
						}
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100069", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06001B5F RID: 7007 RVA: 0x000B0CA8 File Offset: 0x000AEEA8
			public static ActiveUnit_AI.TargetingEntry Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
			{
				ActiveUnit_AI.TargetingEntry result = null;
				try
				{
					ActiveUnit_AI.TargetingEntry targetingEntry = new ActiveUnit_AI.TargetingEntry();
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "Behavior", false) != 0 && Operators.CompareString(name, "BHVR", false) != 0)
							{
								if (Operators.CompareString(name, "Target", false) == 0 || Operators.CompareString(name, "TGT", false) == 0)
								{
									if (xmlNode.ChildNodes.Count > 1)
									{
										targetingEntry.Target = Contact.Load(ref xmlNode, ref dictionary_0);
									}
									else
									{
										targetingEntry.Target = Contact.GetContact(xmlNode.InnerText, ref dictionary_0);
									}
								}
							}
							else if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								targetingEntry.TargetingBehavior = (ActiveUnit_AI.TargetingEntry._TargetingBehavior)Conversions.ToByte(xmlNode.InnerText);
							}
							else
							{
								targetingEntry.TargetingBehavior = (ActiveUnit_AI.TargetingEntry._TargetingBehavior)Enum.Parse(typeof(ActiveUnit_AI.TargetingEntry._TargetingBehavior), xmlNode.InnerText, true);
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
					result = targetingEntry;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100070", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06001B60 RID: 7008 RVA: 0x000B0E50 File Offset: 0x000AF050
			public ActiveUnit_AI.TargetingEntry._TargetingBehavior GetTargetingBehavior()
			{
				return this.TargetingBehavior;
			}

			// Token: 0x06001B61 RID: 7009 RVA: 0x0001140C File Offset: 0x0000F60C
			public void SetTargetingBehavior(ActiveUnit_AI.TargetingEntry._TargetingBehavior _TargetingBehavior_1)
			{
				this.TargetingBehavior = _TargetingBehavior_1;
			}

			// Token: 0x06001B62 RID: 7010 RVA: 0x00011415 File Offset: 0x0000F615
			public TargetingEntry()
			{
				this.Latitude = 0.0;
				this.Longitude = 0.0;
			}

			// Token: 0x04000BAB RID: 2987
			private ActiveUnit_AI.TargetingEntry._TargetingBehavior TargetingBehavior;

			// Token: 0x04000BAC RID: 2988
			public Contact Target;

			// Token: 0x04000BAD RID: 2989
			public double Latitude;

			// Token: 0x04000BAE RID: 2990
			public double Longitude;

			// Token: 0x02000427 RID: 1063
			public enum _TargetingBehavior : byte
			{
				// Token: 0x04000BB0 RID: 2992
				AutoTargeted,
				// Token: 0x04000BB1 RID: 2993
				ManualWeaponAlloc,
				// Token: 0x04000BB2 RID: 2994
				ManualTargeted
			}
		}

		// Token: 0x02000428 RID: 1064
		[CompilerGenerated]
		public sealed class IdentityChecker
		{
			// Token: 0x06001B63 RID: 7011 RVA: 0x0001143B File Offset: 0x0000F63B
			public IdentityChecker(ActiveUnit_AI.IdentityChecker IdentityChecker_)
			{
				if (IdentityChecker_ != null)
				{
					this.aircraft = IdentityChecker_.aircraft;
				}
			}

			// Token: 0x06001B64 RID: 7012 RVA: 0x00011455 File Offset: 0x0000F655
			internal bool IsDifferentWith(Aircraft aircraft_1)
			{
				return aircraft_1 != this.aircraft;
			}

			// Token: 0x04000BB3 RID: 2995
			public Aircraft aircraft;

			// Token: 0x04000BB4 RID: 2996
			public Func<Aircraft, bool> CheckFunc;
		}

		// Token: 0x02000429 RID: 1065
		[CompilerGenerated]
		public sealed class Class24
		{
			// Token: 0x06001B65 RID: 7013 RVA: 0x00011463 File Offset: 0x0000F663
			internal void method_0()
			{
				this.activeUnit_AI.method_48(this.float_0, true);
			}

			// Token: 0x04000BB5 RID: 2997
			public float float_0;

			// Token: 0x04000BB6 RID: 2998
			public ActiveUnit_AI activeUnit_AI;
		}

		// Token: 0x0200042A RID: 1066
		[CompilerGenerated]
		public sealed class MiningMissionAI
		{
			// Token: 0x06001B67 RID: 7015 RVA: 0x00011477 File Offset: 0x0000F677
			public MiningMissionAI(ActiveUnit_AI.MiningMissionAI MiningTaskMan_)
			{
				if (MiningTaskMan_ != null)
				{
					this.bStart = MiningTaskMan_.bStart;
				}
			}

			// Token: 0x06001B68 RID: 7016 RVA: 0x000B0E68 File Offset: 0x000AF068
			internal void CheckStopCondition(UnguidedWeapon unguidedWeapon, ParallelLoopState parallelLoopState)
			{
				if ((double)this.m_AI.m_ActiveUnit.GetHorizontalRange(unguidedWeapon) < (double)this.m_AI.m_ActiveUnit.GetMaxMineRange(unguidedWeapon.GetWeaponType()) / 1852.0)
				{
					this.bStart = false;
					parallelLoopState.Stop();
				}
			}

			// Token: 0x04000BB7 RID: 2999
			public bool bStart;

			// Token: 0x04000BB8 RID: 3000
			public ActiveUnit_AI m_AI;
		}

		// Token: 0x0200042B RID: 1067
		[CompilerGenerated]
		public sealed class WeaponMaxRangeGetter
		{
			// Token: 0x06001B69 RID: 7017 RVA: 0x000B0EBC File Offset: 0x000AF0BC
			internal float GetMaxRange(Weapon weapon_)
			{
				return weapon_.GetMaxRangeToTarget(this.m_AI.m_ActiveUnit, this.m_AI.GetPrimaryTarget(), true, this.doctrine, false);
			}

			// Token: 0x04000BB9 RID: 3001
			public Doctrine doctrine;

			// Token: 0x04000BBA RID: 3002
			public ActiveUnit_AI m_AI;
		}
	}
}
