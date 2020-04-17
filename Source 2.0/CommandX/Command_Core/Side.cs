using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 作战方
	public sealed class Side : Subject
	{
		// Token: 0x060061BF RID: 25023 RVA: 0x002F4E18 File Offset: 0x002F3018
		[CompilerGenerated]
		internal  ObservableCollection<ActiveUnit> GetActiveUnitCollection0()
		{
			return this.observableCollection_0;
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x002F4E30 File Offset: 0x002F3030
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void SetActiveUnitCollectionEvent0(ObservableCollection<ActiveUnit> observableCollection_3)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.SetActiveUnitList0Event);
			ObservableCollection<ActiveUnit> observableCollection = this.observableCollection_0;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged -= value;
			}
			this.observableCollection_0 = observableCollection_3;
			observableCollection = this.observableCollection_0;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged += value;
			}
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x002F4E7C File Offset: 0x002F307C
		[CompilerGenerated]
		internal  ObservableCollection<ActiveUnit> GetActiveUnitCollection1()
		{
			return this.observableCollection_1;
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x002F4E94 File Offset: 0x002F3094
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void SetActiveUnitCollectionEvent1(ObservableCollection<ActiveUnit> observableCollection_3)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.SetActiveUnitList1Event);
			ObservableCollection<ActiveUnit> observableCollection = this.observableCollection_1;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged -= value;
			}
			this.observableCollection_1 = observableCollection_3;
			observableCollection = this.observableCollection_1;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged += value;
			}
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x002F4EE0 File Offset: 0x002F30E0
		[CompilerGenerated]
		internal  ObservableDictionary<string, Contact> GetContactDictionary()
		{
			return this.ContactDictionary;
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x002F4EF8 File Offset: 0x002F30F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void SetContactDictionary(ObservableDictionary<string, Contact> observableDictionary_2)
		{
			INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler(this.ContactDictionary_DictionaryChanged);
			ObservableDictionary<string, Contact> contactDictionary = this.ContactDictionary;
			if (contactDictionary != null)
			{
				contactDictionary.DictionaryChanged -= value;
			}
			this.ContactDictionary = observableDictionary_2;
			contactDictionary = this.ContactDictionary;
			if (contactDictionary != null)
			{
				contactDictionary.DictionaryChanged += value;
			}
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x002F4F44 File Offset: 0x002F3144
		[CompilerGenerated]
		internal  ObservableDictionary<string, Contact> GetContactsObservableDictionary()
		{
			return this.ContactObservableDictionary;
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x002F4F5C File Offset: 0x002F315C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetContactsObservableDictionary(ObservableDictionary<string, Contact> observableDictionary_2)
		{
			INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler(this.SetBaseContactsEvent);
			ObservableDictionary<string, Contact> contactObservableDictionary = this.ContactObservableDictionary;
			if (contactObservableDictionary != null)
			{
				contactObservableDictionary.DictionaryChanged -= value;
			}
			this.ContactObservableDictionary = observableDictionary_2;
			contactObservableDictionary = this.ContactObservableDictionary;
			if (contactObservableDictionary != null)
			{
				contactObservableDictionary.DictionaryChanged += value;
			}
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x002F4FA8 File Offset: 0x002F31A8
		[CompilerGenerated]
		public  ObservableCollection<ReferencePoint> GetReferencePoints()
		{
			return this.ReferencePointCollection;
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x002F4FC0 File Offset: 0x002F31C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetReferencePoints(ObservableCollection<ReferencePoint> observableCollection_3)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.ReferencePointCollection_CollectionChanged);
			ObservableCollection<ReferencePoint> referencePointCollection = this.ReferencePointCollection;
			if (referencePointCollection != null)
			{
				referencePointCollection.CollectionChanged -= value;
			}
			this.ReferencePointCollection = observableCollection_3;
			referencePointCollection = this.ReferencePointCollection;
			if (referencePointCollection != null)
			{
				referencePointCollection.CollectionChanged += value;
			}
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x002F500C File Offset: 0x002F320C
		[CompilerGenerated]
		public static void smethod_0(Side.Delegate23 delegate23_1)
		{
			Side.Delegate23 @delegate = Side.delegate23_0;
			Side.Delegate23 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate23 value = (Side.Delegate23)Delegate.Combine(delegate2, delegate23_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate23>(ref Side.delegate23_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x002F5044 File Offset: 0x002F3244
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_3, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Side");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_3.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_3.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("Name", this.GetSideName());
					if (this.PosturesDictionary.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Postures");
						foreach (KeyValuePair<Side, Misc.PostureStance> current in this.PosturesDictionary)
						{
							xmlWriter_0.WriteElementString("Posture_" + current.Key.GetGuid(), ((int)current.Value).ToString());
							xmlWriter_0.Flush();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.GetReferencePoints().Count > 0)
					{
						xmlWriter_0.WriteStartElement("ReferencePoints");
						List<ReferencePoint> list = this.GetReferencePoints().ToList<ReferencePoint>();
						foreach (ReferencePoint current2 in list)
						{
							if (!Information.IsNothing(current2))
							{
								current2.Save(ref xmlWriter_0, ref hashSet_3);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (!Information.IsNothing(this.m_Doctrine))
					{
						this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
					}
					if (this.ExclusionZoneList.Count > 0)
					{
						xmlWriter_0.WriteStartElement("ExclusionZones");
						List<ExclusionZone> list2 = this.ExclusionZoneList.ToList<ExclusionZone>();
						using (List<ExclusionZone>.Enumerator enumerator3 = list2.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.Save(ref xmlWriter_0, ref hashSet_3, ref scenario_0);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.NoNavZoneList.Count > 0)
					{
						xmlWriter_0.WriteStartElement("NoNavZones");
						List<NoNavZone> list3 = this.NoNavZoneList.ToList<NoNavZone>();
						using (List<NoNavZone>.Enumerator enumerator4 = list3.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.Save(ref xmlWriter_0, ref hashSet_3, ref scenario_0);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
                    //CollectiveResponsibility 集体责任
                    xmlWriter_0.WriteElementString("CollectiveResponsibility", this.CollectiveResponsibility.ToString());
					if (this.CATC)
					{
						xmlWriter_0.WriteElementString("CATC", this.CATC.ToString());
					}
					if (this.QuickJumpSlots.Count > 0)
					{
						xmlWriter_0.WriteStartElement("QuickJumpSlots");
						using (Dictionary<byte, QuickJumpSlot>.ValueCollection.Enumerator enumerator5 = this.QuickJumpSlots.Values.GetEnumerator())
						{
							while (enumerator5.MoveNext())
							{
								enumerator5.Current.Save(ref xmlWriter_0);
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (!string.IsNullOrEmpty(this.Briefing))
					{
						xmlWriter_0.WriteElementString("Briefing", this.Briefing);
					}
					if (!Information.IsNothing(this.MapCenter))
					{
						xmlWriter_0.WriteStartElement("MapCenter");
						this.MapCenter.Save(ref xmlWriter_0, ref hashSet_3);
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("CameraAlt", XmlConvert.ToString(this.CameraAlt));
					xmlWriter_0.WriteElementString("TotalScore", XmlConvert.ToString(this.TotalScore));
					if (this.ScoringLogs.Count > 0)
					{
						xmlWriter_0.WriteStartElement("ScoringLog");
						foreach (string current3 in this.ScoringLogs)
						{
							xmlWriter_0.WriteElementString("msg", current3);
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.Scoring_Disaster.HasValue)
					{
						xmlWriter_0.WriteElementString("Scoring_Disaster", XmlConvert.ToString(this.Scoring_Disaster.Value));
					}
					if (this.Scoring_Triumph.HasValue)
					{
						xmlWriter_0.WriteElementString("Scoring_Triumph", XmlConvert.ToString(this.Scoring_Triumph.Value));
					}
					xmlWriter_0.WriteElementString("AwarenessLevel", Conversions.ToString((int)this.GetAwarenessLevel()));
					if (this.GetContactObservableDictionary().Count > 0)
					{
						xmlWriter_0.WriteStartElement("Contacts");
						List<Contact> list4 = this.GetContactList().ToList<Contact>();
						foreach (Contact current4 in list4)
						{
							if (!Information.IsNothing(current4.ActualUnit))
							{
								current4.Save(ref xmlWriter_0, ref hashSet_3);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("ContactAutoIncrement", this.ContactAutoIncrement.ToString());
					if (this.GetContactsObDictionary().Count > 0)
					{
						xmlWriter_0.WriteStartElement("BaseContacts");
						List<Contact> list5 = this.GetBaseContacts().ToList<Contact>();
						foreach (Contact current5 in list5)
						{
							if (!Information.IsNothing(current5.ActualUnit))
							{
								current5.Save(ref xmlWriter_0, ref hashSet_3);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.Contacts_NonAU.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Contacts_NonAU");
						List<string> list6 = this.Contacts_NonAU.ToList<string>();
						foreach (string current6 in list6)
						{
							xmlWriter_0.WriteElementString("ID", current6);
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.Missions.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Missions");
						foreach (Mission current7 in this.Missions)
						{
							if (!Information.IsNothing(current7))
							{
								current7.Save(ref xmlWriter_0, ref hashSet_3, ref scenario_0);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.SpecialActions.Any<KeyValuePair<string, SpecialAction>>())
					{
						xmlWriter_0.WriteStartElement("SpecialActions");
						using (Dictionary<string, SpecialAction>.ValueCollection.Enumerator enumerator11 = this.SpecialActions.Values.GetEnumerator())
						{
							while (enumerator11.MoveNext())
							{
								enumerator11.Current.Save(xmlWriter_0, hashSet_3, scenario_0);
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("Prof", Conversions.ToString((byte)this.GetProficiencyLevel()));
					xmlWriter_0.WriteElementString("PackageID", Conversions.ToString(this.PackageID));
					this.GetMapProfile().method_0(ref xmlWriter_0);
					xmlWriter_0.WriteElementString("IsAIOnly", this.bAIOnly.ToString());
					this.m_AAR.Save(ref xmlWriter_0);
					checked
					{
						if (this.WeaponSalvos.Length > 0)
						{
							xmlWriter_0.WriteStartElement("WeaponSalvos");
							WeaponSalvo[] weaponSalvos = this.WeaponSalvos;
							for (int i = 0; i < weaponSalvos.Length; i++)
							{
								weaponSalvos[i].Save(ref xmlWriter_0, ref hashSet_3);
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteEndElement();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101048", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x002F58F8 File Offset: 0x002F3AF8
		private Side()
		{
            // 立场
            this.PosturesDictionary = new Dictionary<Side, Misc.PostureStance>();
			this.dictionary_1 = new Dictionary<string, Misc.PostureStance>();
			this.SetActiveUnitCollectionEvent0(new ObservableCollection<ActiveUnit>());
			this.SetActiveUnitCollectionEvent1(new ObservableCollection<ActiveUnit>());
			this.Units = new List<Unit>();
			this.Missions = new List<Mission>();
			this.Goals = new Collection<Goal>();
			this.SpecialActions = new Dictionary<string, SpecialAction>();
			this.TimeToNextContactProcessCycle = 0f;
			this.SetContactDictionary(new ObservableDictionary<string, Contact>());
			this.SetContactsObservableDictionary(new ObservableDictionary<string, Contact>());
			this.Contacts_NonAU = new HashSet<string>();
			this.LazyContactList_OnGrid = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazyNewContactDictionary = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_3 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_4 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.ActiveUnitArray = new ActiveUnit[0];
			this.SetReferencePoints(new ObservableCollection<ReferencePoint>());
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.m_AAR = new Side.AAR();
			this.ExclusionZoneList = new List<ExclusionZone>();
			this.NoNavZoneList = new List<NoNavZone>();
			this.CollectiveResponsibility = true;
			this.CATC = false;
			this.QuickJumpSlots = new Dictionary<byte, QuickJumpSlot>();
			this.WeaponSalvos = new WeaponSalvo[0];
			this.ScoringLogs = new List<string>();
			this.NoneWeaponFriendlyUnits = new ActiveUnit[0];
			this.activeUnit_2 = new ActiveUnit[0];
			this.hashSet_1 = new HashSet<string>();
			this.hashSet_2 = new HashSet<string>();
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x002F5A68 File Offset: 0x002F3C68
		public static Side GetSideByName(string string_4, ref Dictionary<string, Subject> dictionary_4)
		{
			Side side;
			Side result;
			try
			{
				foreach (Subject current in dictionary_4.Values)
				{
					if (current.GetType() == typeof(Side) && Operators.CompareString(((Side)current).GetSideName(), string_4, false) == 0)
					{
						side = (Side)current;
						result = side;
						return result;
					}
				}
				side = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101049", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				side = null;
				ProjectData.ClearProjectError();
			}
			result = side;
			return result;
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x002F5B4C File Offset: 0x002F3D4C
		public static Side GetSideByContainsKey(string string_4, ref Dictionary<string, Subject> dictionary_4)
		{
			Side result = null;
			if (dictionary_4.ContainsKey(string_4))
			{
				result = (Side)dictionary_4[string_4];
			}
			return result;
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x002F5B7C File Offset: 0x002F3D7C
		public static Side GetSideXmlNode(ref XmlNode xmlNode_0, ref Scenario scenario_0, ref Dictionary<string, Subject> dictionary_4)
		{
			Side side = null;
			Side result;
			try
			{
				Side side2 = new Side();
				side2.SetIsAIOnly(false);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1923902225u)
						{
							if (num <= 1295785029u)
							{
								if (num <= 918043797u)
								{
									if (num <= 266367750u)
									{
										if (num != 137391154u)
										{
											if (num == 266367750u && Operators.CompareString(name, "Name", false) == 0)
											{
												side2.SetSideName(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Scoring_Triumph", false) == 0)
											{
												side2.Scoring_Triumph = new int?(XmlConvert.ToInt32(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else if (num != 644518253u)
									{
										if (num == 918043797u && Operators.CompareString(name, "CameraAlt", false) == 0)
										{
											side2.CameraAlt = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ReferencePoints", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
												side2.GetReferencePoints().Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_4));
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
								if (num <= 1005578654u)
								{
									if (num != 982696622u)
									{
										if (num != 1005578654u || Operators.CompareString(name, "Missions", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
												side2.Missions.Add(Mission.Load(ref xmlNode3, ref dictionary_4, ref scenario_0));
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
									if (Operators.CompareString(name, "NoNavZones", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (num != 1181444488u)
									{
										if (num != 1295785029u || Operators.CompareString(name, "QuickJumpSlots", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator4.MoveNext())
											{
												QuickJumpSlot quickJumpSlot = QuickJumpSlot.Load((XmlNode)enumerator4.Current);
												side2.QuickJumpSlots.Add(quickJumpSlot.I, quickJumpSlot);
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
									if (Operators.CompareString(name, "Scoring_Disaster", false) == 0)
									{
										side2.Scoring_Disaster = new int?(XmlConvert.ToInt32(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num <= 1509618259u)
							{
								if (num <= 1444793274u)
								{
									if (num != 1422437055u)
									{
										if (num == 1444793274u && Operators.CompareString(name, "Prof", false) == 0)
										{
											side2.SetProficiencyLevel((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											side2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, side2);
											continue;
										}
										continue;
									}
								}
								else if (num != 1458105184u)
								{
									if (num == 1509618259u && Operators.CompareString(name, "CollectiveResponsibility", false) == 0)
									{
										side2.CollectiveResponsibility = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_4.ContainsKey(xmlNode.InnerText))
									{
										side2.SetGuid(xmlNode.InnerText);
										dictionary_4.Add(side2.GetGuid(), side2);
										continue;
									}
									side = (Side)dictionary_4[xmlNode.InnerText];
									result = side;
									return result;
								}
							}
							else
							{
								if (num <= 1889854453u)
								{
									if (num != 1531209416u)
									{
										if (num != 1889854453u || Operators.CompareString(name, "BaseContacts", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator5.MoveNext())
											{
												XmlNode xmlNode4 = (XmlNode)enumerator5.Current;
												Contact contact = Contact.Load(ref xmlNode4, ref dictionary_4);
												if (Information.IsNothing(contact))
												{
													side2.hashSet_2.Add(xmlNode4.ChildNodes[0].InnerText);
												}
												else
												{
													side2.GetContactsObservableDictionary().Add(contact.string_6, contact);
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
									if (Operators.CompareString(name, "Postures", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator6.MoveNext())
										{
											XmlNode xmlNode5 = (XmlNode)enumerator6.Current;
											if (Operators.CompareString(xmlNode5.Name, "Posture", false) == 0)
											{
												Posture.Load(ref xmlNode5, ref dictionary_4);
												string innerText = Misc.smethod_48(xmlNode5.ChildNodes, "PostureTarget").InnerText;
												Misc.PostureStance value = (Misc.PostureStance)Conversions.ToByte(Misc.smethod_48(xmlNode5.ChildNodes, "PostureType").InnerText);
												try
												{
													if (!side2.dictionary_1.ContainsKey(innerText))
													{
														side2.dictionary_1.Add(innerText, value);
													}
													continue;
												}
												catch (Exception ex)
												{
													ProjectData.SetProjectError(ex);
													Exception ex2 = ex;
													ex2.Data.Add("Error at 200058", ex2.Message);
													GameGeneral.LogException(ref ex2);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													ProjectData.ClearProjectError();
													continue;
												}
											}
											string key = xmlNode5.Name.Split(new char[]
											{
												'_'
											})[1];
											Misc.PostureStance value2 = (Misc.PostureStance)Conversions.ToByte(xmlNode5.InnerText);
											try
											{
												if (!side2.dictionary_1.ContainsKey(key))
												{
													side2.dictionary_1.Add(key, value2);
												}
											}
											catch (Exception ex3)
											{
												ProjectData.SetProjectError(ex3);
												Exception ex4 = ex3;
												ex4.Data.Add("Error at 200590", ex4.Message);
												GameGeneral.LogException(ref ex4);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												ProjectData.ClearProjectError();
											}
										}
										continue;
									}
									finally
									{
										if (enumerator6 is IDisposable)
										{
											(enumerator6 as IDisposable).Dispose();
										}
									}
								}
								if (num != 1894700857u)
								{
									if (num == 1923902225u && Operators.CompareString(name, "IsAIOnly", false) == 0)
									{
										side2.SetIsAIOnly(Conversions.ToBoolean(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Briefing", false) == 0)
									{
										side2.Briefing = xmlNode.InnerText;
										side2.Briefing = side2.Briefing.Replace("<HR>", "");
										continue;
									}
									continue;
								}
							}
						}
						else
						{
							if (num > 3230275693u)
							{
								goto IL_A70;
							}
							if (num <= 2776682687u)
							{
								if (num <= 2658415675u)
								{
									if (num != 2313581294u)
									{
										if (num != 2658415675u || Operators.CompareString(name, "SpecialActions", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator7 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator7.MoveNext())
											{
												SpecialAction specialAction = SpecialAction.Load((XmlNode)enumerator7.Current, dictionary_4, scenario_0);
												side2.SpecialActions.Add(specialAction.GetGuid(), specialAction);
											}
											continue;
										}
										finally
										{
											if (enumerator7 is IDisposable)
											{
												(enumerator7 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "Contacts_NonAU", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator8 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator8.MoveNext())
										{
											XmlNode xmlNode6 = (XmlNode)enumerator8.Current;
											side2.Contacts_NonAU.Add(xmlNode6.InnerText);
										}
										continue;
									}
									finally
									{
										if (enumerator8 is IDisposable)
										{
											(enumerator8 as IDisposable).Dispose();
										}
									}
								}
								if (num != 2725963789u)
								{
									if (num == 2776682687u && Operators.CompareString(name, "AAR", false) == 0)
									{
										side2.m_AAR = Side.AAR.Load(ref xmlNode);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TotalScore", false) == 0)
									{
										side2.TotalScore = XmlConvert.ToInt32(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num <= 2995555222u)
								{
									if (num != 2953011716u)
									{
										if (num == 2995555222u && Operators.CompareString(name, "PackageID", false) == 0)
										{
											side2.PackageID = (int)Conversions.ToShort(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ScoringLog", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator9 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator9.MoveNext())
											{
												XmlNode xmlNode7 = (XmlNode)enumerator9.Current;
												side2.ScoringLogs.Add(xmlNode7.InnerText);
											}
											continue;
										}
										finally
										{
											if (enumerator9 is IDisposable)
											{
												(enumerator9 as IDisposable).Dispose();
											}
										}
									}
								}
								if (num == 3132951781u)
								{
									if (Operators.CompareString(name, "ContactAutoIncrement", false) == 0)
									{
										side2.ContactAutoIncrement = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (num != 3230275693u || Operators.CompareString(name, "NavZones", false) != 0)
								{
									continue;
								}
							}
						}
						IEnumerator enumerator10 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator10.MoveNext())
							{
								XmlNode xmlNode8 = (XmlNode)enumerator10.Current;
								side2.NoNavZoneList.Add(NoNavZone.Load(ref xmlNode8, ref dictionary_4, ref scenario_0));
							}
							continue;
						}
						finally
						{
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
						}
						IL_A70:
						if (num <= 3409555040u)
						{
							if (num <= 3397363308u)
							{
								if (num != 3366850832u)
								{
									if (num == 3397363308u && Operators.CompareString(name, "CATC", false) == 0)
									{
										side2.CATC = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Contacts", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator11 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator11.MoveNext())
										{
											XmlNode xmlNode9 = (XmlNode)enumerator11.Current;
											Contact contact2 = Contact.Load(ref xmlNode9, ref dictionary_4);
											if (Information.IsNothing(contact2))
											{
												if (!side2.hashSet_1.Contains(xmlNode9.ChildNodes[0].InnerText))
												{
													side2.hashSet_1.Add(xmlNode9.ChildNodes[0].InnerText);
												}
											}
											else if (!side2.GetContactDictionary().ContainsKey(contact2.string_6))
											{
												side2.GetContactDictionary().Add(contact2.string_6, contact2);
											}
										}
										continue;
									}
									finally
									{
										if (enumerator11 is IDisposable)
										{
											(enumerator11 as IDisposable).Dispose();
										}
									}
								}
							}
							if (num != 3407638882u)
							{
								if (num == 3409555040u && Operators.CompareString(name, "MapCenter", false) == 0)
								{
									Side side3 = side2;
									XmlNode xmlNode10 = xmlNode.ChildNodes[0];
									side3.MapCenter = GeoPoint.Load(ref xmlNode10, ref dictionary_4);
								}
							}
							else if (Operators.CompareString(name, "MapProfile", false) == 0)
							{
								side2.SetMapProfile(MapProfile.Load(xmlNode));
							}
						}
						else
						{
							if (num <= 3716338637u)
							{
								if (num != 3545511361u)
								{
									if (num != 3716338637u)
									{
										continue;
									}
									if (Operators.CompareString(name, "ForbiddenZones", false) != 0)
									{
										continue;
									}
									goto IL_DCE;
								}
								else
								{
									if (Operators.CompareString(name, "WeaponSalvos", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator12 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator12.MoveNext())
										{
											XmlNode xmlNode11 = (XmlNode)enumerator12.Current;
											WeaponSalvo weaponSalvo = WeaponSalvo.Load(ref xmlNode11, dictionary_4, ref scenario_0);
											if (!Information.IsNothing(weaponSalvo.Target))
											{
												ScenarioArrayUtil.AddWeaponSalvo(ref side2.WeaponSalvos, weaponSalvo);
											}
										}
										continue;
									}
									finally
									{
										if (enumerator12 is IDisposable)
										{
											(enumerator12 as IDisposable).Dispose();
										}
									}
								}
							}
							if (num == 4229809279u)
							{
								if (Operators.CompareString(name, "Goals", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator13 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator13.MoveNext())
									{
										XmlNode xmlNode_ = (XmlNode)enumerator13.Current;
										side2.Goals.Add(Goal.Load(xmlNode_, dictionary_4, scenario_0));
									}
									continue;
								}
								finally
								{
									if (enumerator13 is IDisposable)
									{
										(enumerator13 as IDisposable).Dispose();
									}
								}
							}
							if (num != 4253613222u)
							{
								if (num == 4270878956u && Operators.CompareString(name, "AwarenessLevel", false) == 0)
								{
									side2.SetAwarenessLevel((Side.AwarenessLevel)Conversions.ToInteger(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "ExclusionZones", false) != 0)
							{
								continue;
							}
							IL_DCE:
							IEnumerator enumerator14 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator14.MoveNext())
								{
									XmlNode xmlNode12 = (XmlNode)enumerator14.Current;
									side2.ExclusionZoneList.Add(ExclusionZone.Load(ref xmlNode12, ref dictionary_4, ref scenario_0));
								}
							}
							finally
							{
								if (enumerator14 is IDisposable)
								{
									(enumerator14 as IDisposable).Dispose();
								}
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
				side = side2;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 101050", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				side = new Side();
				ProjectData.ClearProjectError();
			}
			result = side;
			return result;
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x002F6BDC File Offset: 0x002F4DDC
		public void SetXDictionary(ref Scenario scenario_0, Dictionary<string, Subject> dictionary_4, bool bool_12)
		{
			try
			{
				foreach (KeyValuePair<string, Misc.PostureStance> current in this.dictionary_1)
				{
					Side side = Side.GetSideByContainsKey(current.Key, ref dictionary_4);
					if (!Information.IsNothing(side))
					{
						this.PosturesDictionary.Add(side, current.Value);
					}
				}
				foreach (string current2 in this.hashSet_1)
				{
					try
					{
						Contact contact = (Contact)dictionary_4[current2];
						this.GetContactObservableDictionary().Add(contact.string_6, contact);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200059", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				foreach (string current3 in this.hashSet_2)
				{
					try
					{
						Contact contact2 = (Contact)dictionary_4[current3];
						this.GetContactsObDictionary().Add(contact2.string_6, contact2);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 200060", ex4.Message);
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 101051", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x002F6E48 File Offset: 0x002F5048
		public ObservableDictionary<string, Contact> GetContactObservableDictionary()
		{
			return this.GetContactDictionary();
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x002F6E60 File Offset: 0x002F5060
		public ObservableDictionary<string, Contact> GetContactsObDictionary()
		{
			return this.GetContactsObservableDictionary();
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x002F6E78 File Offset: 0x002F5078
		public void AddToContactList_OnGrid(Contact contact_)
		{
			try
			{
				this.LazyContactList_OnGrid.Value.TryAdd(contact_.ActualUnit.GetGuid(), contact_);
				contact_.ActualUnit.Name.Contains("Wierd");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101052", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x002F6F08 File Offset: 0x002F5108
		public void AddToNewContactDictionary(Contact theTarget)
		{
			try
			{
				this.lazyNewContactDictionary.Value.TryAdd(theTarget.ActualUnit.GetGuid(), theTarget);
				theTarget.ActualUnit.Name.Contains("Wierd");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101053", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x002F6F98 File Offset: 0x002F5198
		public void Lazy3DictionaryTryAdd(Contact theTarget, ref Scenario scenario_0, bool IsContactLost)
		{
			checked
			{
				try
				{
					if (!this.GetContactObservableDictionary().ContainsKey(theTarget.ActualUnit.GetGuid()))
					{
						return;
					}
					this.lazy_3.Value.TryAdd(theTarget.ActualUnit.GetGuid(), theTarget);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					string key = "";
					foreach (KeyValuePair<string, Contact> current in this.GetContactDictionary())
					{
						if (current.Value == theTarget)
						{
							key = current.Key;
							break;
						}
					}
					this.GetContactDictionary().Remove(key);
					ActiveUnit[] activeUnitArray = this.ActiveUnitArray;
					for (int i = 0; i < activeUnitArray.Length; i++)
					{
						activeUnitArray[i].GetSensory().RemoveContactEntry(ref key);
					}
					ex2.Data.Add("Error at 200061", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				if (IsContactLost)
				{
					scenario_0.LogMessage("目标 " + theTarget.Name + " 已丢失.", LoggedMessage.MessageType.ContactChange, 5, null, this, new GeoPoint(theTarget.GetLongitude(null), theTarget.GetLatitude(null)));
				}
				ActiveUnit[] activeUnitArray2 = this.ActiveUnitArray;
				for (int j = 0; j < activeUnitArray2.Length; j++)
				{
					activeUnitArray2[j].GetSensory().StopIlluminateTarget(theTarget);
				}
			}
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x0002B34C File Offset: 0x0002954C
		public void GetObservableContactList()
		{
			this.SetContactList(null);
			this.GetContactList();
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x002F7140 File Offset: 0x002F5340
		public void Lazy4DictionaryTryAdd(Contact theC, ref Scenario theScen, bool LogMessage = true)
		{
			try
			{
				if (!this.GetContactsObDictionary().ContainsKey(theC.ActualUnit.GetGuid()))
				{
					return;
				}
				this.lazy_4.Value.TryAdd(theC.ActualUnit.GetGuid(), theC);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string key = "";
				foreach (KeyValuePair<string, Contact> current in this.GetContactsObservableDictionary())
				{
					if (current.Value == theC)
					{
						key = current.Key;
					}
				}
				this.GetContactsObservableDictionary().Remove(key);
				ex2.Data.Add("Error at 200062", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			if (LogMessage)
			{
				theScen.LogMessage("基本目标 " + theC.Name + "已丢失.", LoggedMessage.MessageType.ContactChange, 5, null, this, new GeoPoint(theC.GetLongitude(null), theC.GetLatitude(null)));
			}
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x002F7288 File Offset: 0x002F5488
		public void ProcessContact(Scenario scenario_, float elapsedTime_)
		{
			try
			{
				if (this.TimeToNextContactProcessCycle <= 0f)
				{
					foreach (ActiveUnit current in scenario_.GetActiveUnitList())
					{
						if (current.IsDetected(this) && current.IsOperating() && current.GetSide(false) != this && (!GameGeneral.SideFriendsDictionary[this].Contains(current.GetSide(false)) || !GameGeneral.SideFriendsDictionary[current.GetSide(false)].Contains(this)))
						{
							if (!this.GetContactDictionary().ContainsKey(current.GetGuid()))
							{
								Contact contact = null;
								ActiveUnit_Sensory.NewContactDetected(ref contact, ref current.m_Scenario, this, current, null, Contact_Base.IdentificationStatus.PreciseID, null);
							}
							else
							{
								this.GetContactDictionary()[current.GetGuid()].SetIsPreciselyLocatedOnThisPulse(true);
								this.GetContactDictionary()[current.GetGuid()].TargetIdentification(scenario_, this, null, null, false, true, Contact_Base.IdentificationStatus.PreciseID);
							}
						}
					}
					this.TimeToNextContactProcessCycle = 60f;
				}
				else
				{
					this.TimeToNextContactProcessCycle -= elapsedTime_;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101054", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x002F7428 File Offset: 0x002F5628
		public void UpdateContactsState(ref Scenario scenario_)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				list = this.GetActiveUnitList1();
                ActiveUnit currentX;

                foreach (ActiveUnit current in list)
				{
					Group group = (Group)current;
					if (group.GetGroupType() == Group.GroupType.MobileGroup)
					{
						bool flag = false;
						foreach (Unit current2 in group.GetUnitsInGroup().Values)
						{
							if (this.GetContactObservableDictionary().ContainsKey(current2.GetGuid()))
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							ActiveUnit_Sensory sensory = current.GetSensory();
							Side side = this;
                            currentX = current;

                            sensory.UpdateContactState(ref currentX, ref side);
						}
					}
					else
					{
						ActiveUnit_Sensory sensory = current.GetSensory();
						Side side = this;
                        currentX = current;
                        sensory.UpdateContactState(ref currentX, ref side);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101055", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x002F757C File Offset: 0x002F577C
		public void LazyContactListOnGridClear(Scenario scenario_)
		{
			checked
			{
				try
				{
					if (!this.LazyContactList_OnGrid.Value.IsEmpty)
					{
						foreach (string current in this.LazyContactList_OnGrid.Value.Keys)
						{
							if (!this.GetContactDictionary().ContainsKey(current))
							{
								this.GetContactDictionary().Add(current, this.LazyContactList_OnGrid.Value[current]);
							}
							Contact contact = null;
							if (this.GetContactDictionary().TryGetValue(current, ref contact) && contact.OriginalDetectorSide != this)
							{
								contact.bool_11 = false;
							}
						}
						this.LazyContactList_OnGrid.Value.Clear();
					}
					if (!this.lazy_3.Value.IsEmpty)
					{
                        string current2X;
                        foreach (string current2 in this.lazy_3.Value.Keys)
						{
							Contact contact2 = this.lazy_3.Value[current2];
							this.RemoveWeaponSalvoByContact(ref scenario_, contact2);
							ActiveUnit[] activeUnitArray = this.ActiveUnitArray;
							for (int i = 0; i < activeUnitArray.Length; i++)
							{
								ActiveUnit activeUnit = activeUnitArray[i];
								ActiveUnit_AI aI = activeUnit.GetAI();
								Side side = this;
								aI.DropTargetFromMySide(ref contact2, ref side);
                                current2X = current2;

                                activeUnit.GetSensory().RemoveContactEntry(ref current2X);
							}
							this.GetContactDictionary().Remove(current2);
							if (this.GetUnitReadOnlyCollection().Contains(contact2))
							{
								this.RemoveUnits(contact2);
							}
						}
						this.lazy_3.Value.Clear();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101056", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x002F77B8 File Offset: 0x002F59B8
		public void LazyNewContactDictionaryClear(Scenario scenario_0)
		{
			try
			{
				if (!this.lazyNewContactDictionary.Value.IsEmpty)
				{
					foreach (string current in this.lazyNewContactDictionary.Value.Keys)
					{
						if (!this.GetContactsObservableDictionary().ContainsKey(current))
						{
							this.GetContactsObservableDictionary().Add(current, this.lazyNewContactDictionary.Value[current]);
						}
					}
					this.lazyNewContactDictionary.Value.Clear();
				}
				if (!this.lazy_4.Value.IsEmpty)
				{
					foreach (string current2 in this.lazy_4.Value.Keys)
					{
						Contact contact = this.lazy_4.Value[current2];
						this.GetContactsObservableDictionary().Remove(current2);
						if (this.GetUnitReadOnlyCollection().Contains(contact))
						{
							this.RemoveUnits(contact);
						}
					}
					this.lazy_4.Value.Clear();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101057", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x002F7970 File Offset: 0x002F5B70
		public int GetTotalScore(Scenario theScen, string ReasonForChange = null)
		{
			return this.TotalScore;
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x002F7988 File Offset: 0x002F5B88
		public void ChangeScore(Scenario theScen, string ReasonForChange, int value)
		{
			try
			{
				bool flag = value != this.TotalScore;
				int totalScore = this.TotalScore;
				this.TotalScore = value;
				if (flag)
				{
					this.ScoringLogs.Add(string.Concat(new string[]
					{
						theScen.GetCurrentTime(false).ToShortDateString(),
						" ",
						theScen.GetCurrentTime(false).ToShortTimeString(),
						": 推演成绩从",
						Conversions.ToString(totalScore),
						"变为",
						Conversions.ToString(value),
						". 原因: ",
						ReasonForChange
					}));
					List<EventTrigger> list = new List<EventTrigger>();
					foreach (EventTrigger current in theScen.GetEventTriggers().Values)
					{
						if (current.eventTriggerType == EventTrigger.EventTriggerType.Points && ((EventTrigger_Points)current).method_11(this, totalScore, value))
						{
							list.Add(current);
						}
					}
					theScen.TriggerEvents(list);
					Side.Delegate23 @delegate = Side.delegate23_0;
					if (@delegate != null)
					{
						@delegate(this);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101058", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x002F7B2C File Offset: 0x002F5D2C
        //熟练程度
		public GlobalVariables.ProficiencyLevel GetProficiencyLevel()
		{
			if (!this.m_ProficiencyLevel.HasValue)
			{
				this.m_ProficiencyLevel = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Regular);
			}
			return this.m_ProficiencyLevel.Value;
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x0002B35C File Offset: 0x0002955C
		public void SetProficiencyLevel(GlobalVariables.ProficiencyLevel proficiencyLevel_0)
		{
			this.m_ProficiencyLevel = new GlobalVariables.ProficiencyLevel?(proficiencyLevel_0);
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x002F7B60 File Offset: 0x002F5D60
		public GeoPoint GetMapCenter()
		{
			if (Information.IsNothing(this.MapCenter))
			{
				this.MapCenter = new GeoPoint(0.0, 0.0);
			}
			return this.MapCenter;
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x0002B36A File Offset: 0x0002956A
		public void SetMapCenter(GeoPoint geoPoint_1)
		{
			this.MapCenter = geoPoint_1;
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x002F7BA4 File Offset: 0x002F5DA4
        //知自知彼水平
		public Side.AwarenessLevel GetAwarenessLevel()
		{
			return this.awarenessLevel;
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x0002B373 File Offset: 0x00029573
		public void SetAwarenessLevel(Side.AwarenessLevel awarenessLevel_Enum_1)
		{
			this.awarenessLevel = awarenessLevel_Enum_1;
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x002F7BBC File Offset: 0x002F5DBC
		public int ScoringMode5()
		{
			int result;
			if (this.Scoring_Disaster.HasValue && this.Scoring_Triumph.HasValue)
			{
				double num = (double)this.ScoringMode1();
				int? num2 = (this.Scoring_Triumph - this.ScoringMode1()) * 2;
				double num3 = num;
				double? num4 = num2.HasValue ? new double?((double)num2.GetValueOrDefault()) : null;
				num4 = (num4.HasValue ? new double?(num4.GetValueOrDefault() / 3.0) : null);
				result = (int)Math.Round((num4.HasValue ? new double?(num3 - num4.GetValueOrDefault()) : null).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x002F7CE0 File Offset: 0x002F5EE0
		public int ScoringMode4()
		{
			int result;
			if (this.Scoring_Disaster.HasValue && this.Scoring_Triumph.HasValue)
			{
				double num = (double)this.ScoringMode1();
				int? num2 = this.Scoring_Triumph - this.ScoringMode1();
				int? num3 = num2.HasValue ? new int?(num2.GetValueOrDefault()) : null;
				double num4 = num;
				double? num5 = num3.HasValue ? new double?((double)num3.GetValueOrDefault()) : null;
				num5 = (num5.HasValue ? new double?(num5.GetValueOrDefault() / 3.0) : null);
				result = (int)Math.Round((num5.HasValue ? new double?(num4 - num5.GetValueOrDefault()) : null).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x002F7E04 File Offset: 0x002F6004

		public int ScoringMode1()
		{
			int result;
			if (this.Scoring_Disaster.HasValue && this.Scoring_Triumph.HasValue)
			{
				int? numTriumph = this.Scoring_Triumph;
				double? num2 = numTriumph.HasValue ? new double?((double)numTriumph.GetValueOrDefault()) : null;
				numTriumph = this.Scoring_Triumph - this.Scoring_Disaster;
				double? num3 = num2;
				double? num4 = numTriumph.HasValue ? new double?((double)numTriumph.GetValueOrDefault()) : null;
				num4 = (num4.HasValue ? new double?(num4.GetValueOrDefault() / 2.0) : null);
				result = (int)Math.Round(((num3.HasValue & num4.HasValue) ? new double?(num3.GetValueOrDefault() - num4.GetValueOrDefault()) : null).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x002F7F44 File Offset: 0x002F6144
		public int ScoringMode2()
		{
			int result;
			if (this.Scoring_Disaster.HasValue && this.Scoring_Triumph.HasValue)
			{
				double num = (double)this.ScoringMode1();
				int? num2 = this.Scoring_Triumph - this.ScoringMode1();
				int? num3 = num2.HasValue ? new int?(num2.GetValueOrDefault()) : null;
				double num4 = num;
				double? num5 = num3.HasValue ? new double?((double)num3.GetValueOrDefault()) : null;
				num5 = (num5.HasValue ? new double?(num5.GetValueOrDefault() / 3.0) : null);
				result = (int)Math.Round((num5.HasValue ? new double?(num4 + num5.GetValueOrDefault()) : null).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x002F8068 File Offset: 0x002F6268
		public int ScoringMode3()
		{
			int result;
			if (this.Scoring_Disaster.HasValue && this.Scoring_Triumph.HasValue)
			{
				double num = (double)this.ScoringMode1();
				int? num2 = (this.Scoring_Triumph - this.ScoringMode1()) * 2;
				double num3 = num;
				double? num4 = num2.HasValue ? new double?((double)num2.GetValueOrDefault()) : null;
				num4 = (num4.HasValue ? new double?(num4.GetValueOrDefault() / 3.0) : null);
				result = (int)Math.Round((num4.HasValue ? new double?(num3 + num4.GetValueOrDefault()) : null).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x002F818C File Offset: 0x002F638C
		public ReadOnlyCollection<Mission> GetMissionCollection()
		{
			return this.Missions.AsReadOnly();
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x002F81A8 File Offset: 0x002F63A8
		public ReadOnlyCollection<Mission> GetPatrolMissionCollection(Scenario scenario_)
		{
			ReadOnlyCollection<Mission> result;
			try
			{
				if (Information.IsNothing(this.readOnlyPatrolMissions))
				{
					List<Mission> list = new List<Mission>();
					list.AddRange(this.Missions);
					try
					{
						foreach (Group current in scenario_.Groups)
						{
							if (current.GetSide(false) == this)
							{
								list.AddRange(current.GetPatrols());
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200063", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					this.readOnlyPatrolMissions = list.AsReadOnly();
				}
				result = this.readOnlyPatrolMissions;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101059", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x0002B37C File Offset: 0x0002957C
		public void ClearPatrolMissions()
		{
			this.readOnlyPatrolMissions = null;
		}

		// Token: 0x060061EB RID: 25067 RVA: 0x0002B385 File Offset: 0x00029585
		public void AddMission(Mission mission_)
		{
			if (!this.Missions.Contains(mission_))
			{
				this.Missions.Add(mission_);
				this.ClearPatrolMissions();
			}
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x002F82EC File Offset: 0x002F64EC
		public void RemoveMission(Mission mission_)
		{
			switch (mission_.category)
			{
			case Mission.MissionCategory.Mission:
				goto IL_C3;
			case Mission.MissionCategory.Package:
				using (List<Mission>.Enumerator enumerator = this.Missions.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Mission current = enumerator.Current;
						if (current.category == Mission.MissionCategory.TaskPool)
						{
							TaskPool taskPool = (TaskPool)current;
							if (taskPool.Packages.Contains(mission_))
							{
								taskPool.Packages.Remove(mission_);
								IL_73:
								goto IL_C3;
							}
						}
					}
					goto IL_C3;
				}
				break;
			case Mission.MissionCategory.TaskPool:
				break;
			default:
				goto IL_C3;
			}
			TaskPool taskPool2 = (TaskPool)mission_;
			for (int i = taskPool2.Packages.Count - 1; i >= 0; i += -1)
			{
				Mission mission_2 = taskPool2.Packages[i];
				this.RemoveMission(mission_2);
			}
			IL_C3:
			if (this.Missions.Remove(mission_))
			{
				this.ClearPatrolMissions();
			}
		}

        // Token: 0x060061ED RID: 25069 RVA: 0x002F83E4 File Offset: 0x002F65E4
        //如果由人扮演,则删除该使命
        public void RemoveMissionSISIH(Scenario scenario_0)
		{
			List<Mission> list = new List<Mission>();
			foreach (Mission current in this.GetMissionCollection())
			{
                //如果由人扮演则删除该使命
                if (current.SISIH)
				{
					list.Add(current);
				}
			}
			foreach (Mission current2 in list)
			{
				List<ActiveUnit> unitsAssignedToMe = current2.GetUnitsAssignedToMe(scenario_0);
				using (List<ActiveUnit>.Enumerator enumerator3 = unitsAssignedToMe.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						enumerator3.Current.DeleteMission(false, null);
					}
				}
				this.RemoveMission(current2);
			}
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x002F84CC File Offset: 0x002F66CC
		public List<ActiveUnit> GetJammerPlatforms(bool bool_12)
		{
			List<ActiveUnit> result = null;
			checked
			{
				try
				{
					if (Information.IsNothing(this.m_JammerPlatforms) || bool_12)
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						ActiveUnit[] activeUnitArray = this.ActiveUnitArray;
						for (int i = 0; i < activeUnitArray.Length; i++)
						{
							ActiveUnit activeUnit = activeUnitArray[i];
							if (!activeUnit.IsGroup && activeUnit.GetSensory().HasEmittingJammer() && activeUnit.IsOperating())
							{
								list.Add(activeUnit);
							}
						}
						this.m_JammerPlatforms = list;
					}
					result = this.m_JammerPlatforms;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101060", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = this.m_JammerPlatforms;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x002F85B0 File Offset: 0x002F67B0
		public MapProfile GetMapProfile()
		{
			if (Information.IsNothing(this.mapProfile))
			{
				this.mapProfile = MapProfile.GetDefaultMapProfile();
			}
			return this.mapProfile;
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x0002B3A7 File Offset: 0x000295A7
		public void SetMapProfile(MapProfile value)
		{
			this.mapProfile = value;
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x002F85E0 File Offset: 0x002F67E0
		public List<ActiveUnit> GetActiveUnitList0()
		{
			List<ActiveUnit> result;
			if (Information.IsNothing(this.list_6))
			{
				this.list_6 = new List<ActiveUnit>();
				this.list_6.AddRange(this.GetActiveUnitCollection0());
				result = this.list_6;
			}
			else
			{
				result = this.list_6;
			}
			return result;
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x0002B3B0 File Offset: 0x000295B0
		public void SetActiveUnitList0(List<ActiveUnit> list_10)
		{
			this.list_6 = list_10;
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x002F8630 File Offset: 0x002F6830
		public List<ActiveUnit> GetActiveUnitList1()
		{
			List<ActiveUnit> result;
			if (Information.IsNothing(this.list_7))
			{
				this.list_7 = new List<ActiveUnit>();
				this.list_7.AddRange(this.GetActiveUnitCollection1());
				result = this.list_7;
			}
			else
			{
				result = this.list_7;
			}
			return result;
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x0002B3B9 File Offset: 0x000295B9
		public void SetActiveUnitList1(List<ActiveUnit> list_10)
		{
			this.list_7 = list_10;
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x002F8680 File Offset: 0x002F6880
		public List<Contact> GetContactList()
		{
			List<Contact> contactList;
			if (Information.IsNothing(this.ContactList))
			{
				this.ContactList = new List<Contact>();
				this.ContactList.AddRange(this.GetContactObservableDictionary().Values);
				contactList = this.ContactList;
			}
			else
			{
				if (this.ContactList.Count != this.GetContactObservableDictionary().Count)
				{
					this.ContactList = new List<Contact>();
					this.ContactList.AddRange(this.GetContactObservableDictionary().Values);
				}
				contactList = this.ContactList;
			}
			return contactList;
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x0002B3C2 File Offset: 0x000295C2
		public void SetContactList(List<Contact> Contacts_)
		{
			this.ContactList = Contacts_;
		}

		// Token: 0x060061F7 RID: 25079 RVA: 0x002F870C File Offset: 0x002F690C
		public List<Contact> GetBaseContacts()
		{
			List<Contact> result;
			if (Information.IsNothing(this.list_9))
			{
				this.list_9 = new List<Contact>();
				this.list_9.AddRange(this.GetContactsObDictionary().Values);
				result = this.list_9;
			}
			else
			{
				if (this.list_9.Count != this.GetContactsObDictionary().Count)
				{
					this.list_9 = new List<Contact>();
					this.list_9.AddRange(this.GetContactsObDictionary().Values);
				}
				result = this.list_9;
			}
			return result;
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x0002B3CB File Offset: 0x000295CB
		public void SetBaseContacts(List<Contact> list_10)
		{
			this.list_9 = list_10;
		}

        // Token: 0x060061F9 RID: 25081 RVA: 0x002F8798 File Offset: 0x002F6998
        //IsOperating 
        public ActiveUnit[] GetNoneWeaponFriendlyUnitsIsOperating(Scenario scenario_0)
		{
			return this.GetNoneWeaponFriendlyUnits(scenario_0).Where(Side.ActiveUnitFunc).ToArray<ActiveUnit>();
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x002F87C0 File Offset: 0x002F69C0
		public ActiveUnit[] GetNoneWeaponFriendlyUnits(Scenario scenario_)
		{
			ActiveUnit[] noneWeaponFriendlyUnits;
			try
			{
				if (Information.IsNothing(this.NoneWeaponFriendlyUnits))
				{
					HashSet<ActiveUnit> hashSet = new HashSet<ActiveUnit>();
					foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
					{
						if (current.IsWeapon)
						{
							goto IL_49;
						}
						if (current.GetSide(false) != this)
						{
							goto IL_49;
						}
						bool arg_5C_0 = false;
						IL_5C:
						if (!arg_5C_0)
						{
							hashSet.Add(current);
							continue;
						}
						continue;
						IL_49:
						arg_5C_0 = (this.GetPostureStance(current.GetSide(false)) != Misc.PostureStance.Friendly);
						goto IL_5C;
					}
					this.NoneWeaponFriendlyUnits = hashSet.ToArray<ActiveUnit>();
				}
				noneWeaponFriendlyUnits = this.NoneWeaponFriendlyUnits;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101061", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				noneWeaponFriendlyUnits = this.NoneWeaponFriendlyUnits;
				ProjectData.ClearProjectError();
			}
			return noneWeaponFriendlyUnits;
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x0002B3D4 File Offset: 0x000295D4
		public void SetNoneWeaponFriendlyUnits(Scenario scenario_0, ActiveUnit[] activeUnit_3)
		{
			this.NoneWeaponFriendlyUnits = activeUnit_3;
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x002F88C8 File Offset: 0x002F6AC8
		public string GetSideName()
		{
			return this.strSideName;
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x0002B3DD File Offset: 0x000295DD
		public void SetSideName(string string_4)
		{
			this.strSideName = string_4;
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x0002B3E6 File Offset: 0x000295E6
		public bool IsAIOnly()
		{
			return this.bAIOnly;
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x0002B3EE File Offset: 0x000295EE
		public void SetIsAIOnly(bool bool_12)
		{
			this.bAIOnly = bool_12;
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x002F88E0 File Offset: 0x002F6AE0
		public List<LoggedMessage> GetLoggedMessageList(Scenario scenario_0)
		{
			int count = scenario_0.MessageLog.Count;
			List<LoggedMessage> list = new List<LoggedMessage>(count);
			List<LoggedMessage> result;
			try
			{
				list = scenario_0.MessageLog.Values.Where(new Func<LoggedMessage, bool>(this.IsThisLoggedMessageSide)).ToList<LoggedMessage>();
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200065", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = list;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x002F897C File Offset: 0x002F6B7C
		public ReadOnlyCollection<Unit> GetUnitReadOnlyCollection()
		{
			return this.Units.AsReadOnly();
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x002F8998 File Offset: 0x002F6B98
		public Side(string string_4, ref Scenario scenario_0)
		{
			this.PosturesDictionary = new Dictionary<Side, Misc.PostureStance>();
			this.dictionary_1 = new Dictionary<string, Misc.PostureStance>();
			this.SetActiveUnitCollectionEvent0(new ObservableCollection<ActiveUnit>());
			this.SetActiveUnitCollectionEvent1(new ObservableCollection<ActiveUnit>());
			this.Units = new List<Unit>();
			this.Missions = new List<Mission>();
			this.Goals = new Collection<Goal>();
			this.SpecialActions = new Dictionary<string, SpecialAction>();
			this.TimeToNextContactProcessCycle = 0f;
			this.SetContactDictionary(new ObservableDictionary<string, Contact>());
			this.SetContactsObservableDictionary(new ObservableDictionary<string, Contact>());
			this.Contacts_NonAU = new HashSet<string>();
			this.LazyContactList_OnGrid = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazyNewContactDictionary = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_3 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_4 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.ActiveUnitArray = new ActiveUnit[0];
			this.SetReferencePoints(new ObservableCollection<ReferencePoint>());
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.m_AAR = new Side.AAR();
			this.ExclusionZoneList = new List<ExclusionZone>();
			this.NoNavZoneList = new List<NoNavZone>();
			this.CollectiveResponsibility = true;
			this.CATC = false;
			this.QuickJumpSlots = new Dictionary<byte, QuickJumpSlot>();
			this.WeaponSalvos = new WeaponSalvo[0];
			this.ScoringLogs = new List<string>();
			this.NoneWeaponFriendlyUnits = new ActiveUnit[0];
			this.activeUnit_2 = new ActiveUnit[0];
			this.hashSet_1 = new HashSet<string>();
			this.hashSet_2 = new HashSet<string>();
			this.SetSideName(string_4);
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x002F8B10 File Offset: 0x002F6D10
		public void MarkAsHostile(ActiveUnit activeUnit_3, Contact contact_0, WeaponRec weaponRec_0)
		{
			if (!Information.IsNothing(contact_0))
			{
				try
				{
					if (contact_0.contactType != Contact_Base.ContactType.Aimpoint && contact_0.contactType != Contact_Base.ContactType.ActivationPoint && !weaponRec_0.GetWeapon(activeUnit_3.m_Scenario).IsDecoy() && (contact_0.ActualUnit.GetSide(false) == this || contact_0.ActualUnit.GetSide(false).GetPostureStance(this) == Misc.PostureStance.Friendly))
					{
						foreach (Contact current in this.GetContactObservableDictionary().Values)
						{
							if (!current.IsDestroyed(activeUnit_3.m_Scenario) && current.ActualUnit == activeUnit_3)
							{
								if (current.GetPostureStance(this) != Misc.PostureStance.Hostile && !current.ActualUnit.IsWeapon)
								{
									bool flag = false;
									string str = "";
									if (!Information.IsNothing(current.TimeSinceDetection_Visual))
									{
										float? num = current.TimeSinceDetection_Visual;
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() < 30f) : null).GetValueOrDefault())
										{
											flag = true;
											str = " (原因: 视距发现武器发射)";
										}
									}
									if (!flag && !Information.IsNothing(current.TimeSinceDetection_Infrared))
									{
										float? num = current.TimeSinceDetection_Infrared;
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() < 30f) : null).GetValueOrDefault())
										{
											flag = true;
											str = " (原因: 红外系统探测到武器发射)";
										}
									}
									if (!flag && !Information.IsNothing(current.TimeSinceDetection_SonarPassive))
									{
										float? num = current.TimeSinceDetection_SonarPassive;
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() < 30f) : null).GetValueOrDefault())
										{
											flag = true;
											str = " (原因: 被动声纳探测到武器发射)";
										}
									}
									if (flag)
									{
										current.MarkAs(this, false, Misc.PostureStance.Hostile);
										activeUnit_3.m_Scenario.LogMessage("发现目标: " + current.Name + " 正在攻击友方作战单元，现视之为敌对方!" + str, LoggedMessage.MessageType.ContactChange, 0, null, this, new GeoPoint(current.GetLongitude(null), current.GetLatitude(null)));
									}
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
					ex2.Data.Add("Error at 101062", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x002F8DEC File Offset: 0x002F6FEC
		public void AddToLazy3Dictionary(ActiveUnit activeUnit_)
		{
			Side.ActualUnitChecker actualUnitChecker = new Side.ActualUnitChecker(null);
			actualUnitChecker.actualUnit = activeUnit_;
			try
			{
				IEnumerable<Contact> enumerable = this.GetContactObservableDictionary().Values.Where(new Func<Contact, bool>(actualUnitChecker.IsActualUnitOf));
				new Collection<Contact>();
				foreach (Contact current in enumerable)
				{
					this.Lazy3DictionaryTryAdd(current, ref actualUnitChecker.actualUnit.m_Scenario, true);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101063", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x002F8EC4 File Offset: 0x002F70C4
		public void ContactUpdateToContact(Contact contact_0, Contact contact_1, ActiveUnit activeUnit_3, Scenario scenario_0, bool bool_12)
		{
            bool? nullable;
            if (!Information.IsNothing(activeUnit_3))
            {
                nullable = null;
                nullable = null;
                activeUnit_3.LogMessage("更新目标: " + contact_0.Name + "数据, 新信息源：: " + activeUnit_3.Name, LoggedMessage.MessageType.ContactChange, 0, false, new GeoPoint(activeUnit_3.GetLongitude(nullable), activeUnit_3.GetLatitude(nullable)));
            }
            if (contact_0.Age >= contact_1.Age)
            {
                if (contact_1.Speed_Known)
                {
                    contact_0.Speed_Known = true;
                }
                if (contact_1.Heading_Known)
                {
                    contact_0.Heading_Known = true;
                }
                if (contact_1.Altitude_Known)
                {
                    contact_0.Altitude_Known = true;
                }
                if (bool_12 && (!Information.IsNothing(contact_0.GetUncertaintyArea()) || !Information.IsNothing(contact_1.GetUncertaintyArea())))
                {
                    if (!(Information.IsNothing(contact_0.GetUncertaintyArea()) || Information.IsNothing(contact_1.GetUncertaintyArea())))
                    {
                        contact_0.SetUncertaintyArea(ActiveUnit_Sensory.smethod_7(contact_0.GetUncertaintyArea(), contact_1.GetUncertaintyArea()));
                    }
                    else if (((!Information.IsNothing(contact_0.GetUncertaintyArea()) || Information.IsNothing(contact_1.GetUncertaintyArea())) && !Information.IsNothing(contact_0.GetUncertaintyArea())) && Information.IsNothing(contact_1.GetUncertaintyArea()))
                    {
                        contact_0.SetUncertaintyArea(null);
                    }
                }
                contact_0.Age = contact_1.Age;
                contact_0.HeldFor = contact_1.HeldFor;
                if ((((!contact_0.SideIsKnown || !contact_1.SideIsKnown) && (!contact_0.SideIsKnown || contact_1.SideIsKnown)) && !contact_0.SideIsKnown) && contact_1.SideIsKnown)
                {
                    contact_0.SideIsKnown = true;
                }
                ActiveUnit_Sensory.smethod_3(contact_0, contact_1.GetEmissionContainerObDictionary());
                if (!(Information.IsNothing(contact_0.list_6) || Information.IsNothing(contact_1.list_6)))
                {
                    contact_0.list_6 = contact_0.list_6.Union<int>(contact_1.list_6).ToList<int>();
                }
                if (contact_0.TimeSinceDetection_Radar.HasValue)
                {
                    if (contact_1.TimeSinceDetection_Radar.HasValue)
                    {
                        contact_0.TimeSinceDetection_Radar = new float?(Math.Min(contact_0.TimeSinceDetection_Radar.Value, contact_1.TimeSinceDetection_Radar.Value));
                    }
                }
                else if (contact_1.TimeSinceDetection_Radar.HasValue)
                {
                    contact_0.TimeSinceDetection_Radar = new float?(contact_1.TimeSinceDetection_Radar.Value);
                }
                if (contact_0.TimeSinceDetection_ESM.HasValue)
                {
                    if (contact_1.TimeSinceDetection_ESM.HasValue)
                    {
                        contact_0.TimeSinceDetection_ESM = new float?(Math.Min(contact_0.TimeSinceDetection_ESM.Value, contact_1.TimeSinceDetection_ESM.Value));
                    }
                }
                else if (contact_1.TimeSinceDetection_ESM.HasValue)
                {
                    contact_0.TimeSinceDetection_ESM = new float?(contact_1.TimeSinceDetection_ESM.Value);
                }
                if (contact_0.TimeSinceDetection_Visual.HasValue)
                {
                    if (contact_1.TimeSinceDetection_Visual.HasValue)
                    {
                        contact_0.TimeSinceDetection_Visual = new float?(Math.Min(contact_0.TimeSinceDetection_Visual.Value, contact_1.TimeSinceDetection_Visual.Value));
                    }
                }
                else if (contact_1.TimeSinceDetection_Visual.HasValue)
                {
                    contact_0.TimeSinceDetection_Visual = new float?(contact_1.TimeSinceDetection_Visual.Value);
                }
                if (contact_0.TimeSinceDetection_Infrared.HasValue)
                {
                    if (contact_1.TimeSinceDetection_Infrared.HasValue)
                    {
                        contact_0.TimeSinceDetection_Infrared = new float?(Math.Min(contact_0.TimeSinceDetection_Infrared.Value, contact_1.TimeSinceDetection_Infrared.Value));
                    }
                }
                else if (contact_1.TimeSinceDetection_Infrared.HasValue)
                {
                    contact_0.TimeSinceDetection_Infrared = new float?(contact_1.TimeSinceDetection_Infrared.Value);
                }
                if (contact_0.TimeSinceDetection_SonarActive.HasValue)
                {
                    if (contact_1.TimeSinceDetection_SonarActive.HasValue)
                    {
                        contact_0.TimeSinceDetection_SonarActive = new float?(Math.Min(contact_0.TimeSinceDetection_SonarActive.Value, contact_1.TimeSinceDetection_SonarActive.Value));
                    }
                }
                else if (contact_1.TimeSinceDetection_SonarActive.HasValue)
                {
                    contact_0.TimeSinceDetection_SonarActive = new float?(contact_1.TimeSinceDetection_SonarActive.Value);
                }
                if (contact_0.TimeSinceDetection_SonarPassive.HasValue)
                {
                    if (contact_1.TimeSinceDetection_SonarPassive.HasValue)
                    {
                        contact_0.TimeSinceDetection_SonarPassive = new float?(Math.Min(contact_0.TimeSinceDetection_SonarPassive.Value, contact_1.TimeSinceDetection_SonarPassive.Value));
                    }
                }
                else if (contact_1.TimeSinceDetection_SonarPassive.HasValue)
                {
                    contact_0.TimeSinceDetection_SonarPassive = new float?(contact_1.TimeSinceDetection_SonarPassive.Value);
                }
            }
            if (contact_0.TS_BDA > contact_1.TS_BDA)
            {
                if (contact_1.GetBattleDamageAssessment(this).HasValue)
                {
                    contact_0.SetBattleDamageAssessment(this, contact_1.GetBattleDamageAssessment(this));
                }
                if (contact_1.GetBDA_Fire(this).HasValue)
                {
                    contact_0.SetBDA_Fire(this, contact_1.GetBDA_Fire(this));
                }
                if (contact_1.GetBDA_Flood(this).HasValue)
                {
                    contact_0.SetBDA_Flood(this, contact_1.GetBDA_Flood(this));
                }
            }
            if (contact_0.TS_Recon > contact_1.TS_Recon)
            {
                List<Contact.HostUnitOfRadarRadiation> list = new List<Contact.HostUnitOfRadarRadiation>();
                //ZSP ERR 被动探测重点关注点之一
                Contact.HostUnitOfRadarRadiation radiationX;
                foreach (Contact.HostUnitOfRadarRadiation radiation in contact_0.GetRadiationHostUnits(this))
                {
                    bool flag = false;
                    radiationX = radiation;
                    foreach (Contact.HostUnitOfRadarRadiation radiation2 in contact_1.GetRadiationHostUnits(this))
                    {
                        if (radiation2.UID == radiation.UID)
                        {
                            flag = true;
                            if (radiation2.identificationStatus > radiation.identificationStatus)
                            {
                                radiationX = radiation2;
                            }
                        }
                    }
                    if (!flag)
                    {
                        list.Add(radiation);
                    }
                }
                foreach (Contact.HostUnitOfRadarRadiation radiation3 in list)
                {
                    contact_0.GetRadiationHostUnits(this).Remove(radiation3);
                }
            }
            if (contact_1.GetIdentificationStatus() > contact_0.GetIdentificationStatus())
            {
                contact_0.TargetIdentification(scenario_0, this, null, null, false, true, contact_1.GetIdentificationStatus());
                nullable = null;
                scenario_0.LogMessage("目标: " + contact_0.Name + "查证实际为: " + contact_1.Name, LoggedMessage.MessageType.ContactChange, 0, null, this, new GeoPoint(contact_0.GetLongitude(nullable), contact_0.GetLatitude((bool?)null)));
                contact_0.Name = contact_1.Name;
            }

        }

        // Token: 0x06006206 RID: 25094 RVA: 0x002F9564 File Offset: 0x002F7764
        public void AddUnits(Unit unit_0)
		{
			if (!this.Units.Contains(unit_0))
			{
				this.Units.Add(unit_0);
			}
			Side.Delegate22 @delegate = this.delegate22_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x002F95A0 File Offset: 0x002F77A0
		public void RemoveUnits(Unit unit_0)
		{
			this.Units.Remove(unit_0);
			Side.Delegate22 @delegate = this.delegate22_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x002F95D0 File Offset: 0x002F77D0
		public void ClearUnits()
		{
			this.Units.Clear();
			Side.Delegate22 @delegate = this.delegate22_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x002F95FC File Offset: 0x002F77FC
		public void RemoveActiveUnits(ActiveUnit activeUnit_, bool ScenEditAction_)
		{
			if (activeUnit_.GetSide(false) != this)
			{
				Collection<Contact> collection = new Collection<Contact>();
				Collection<Contact> collection2 = new Collection<Contact>();
				try
				{
					foreach (Contact current in this.GetContactObservableDictionary().Values)
					{
						if (current.ActualUnit == activeUnit_)
						{
							collection.Add(current);
						}
					}
					foreach (Contact current2 in collection)
					{
						this.Lazy3DictionaryTryAdd(current2, ref activeUnit_.m_Scenario, true);
						if (this.GetUnitReadOnlyCollection().Contains(current2))
						{
							this.RemoveUnits(current2);
						}
					}
					foreach (Contact current3 in this.GetContactsObDictionary().Values)
					{
						if (current3.ActualUnit == activeUnit_)
						{
							collection2.Add(current3);
						}
					}
					foreach (Contact current4 in collection2)
					{
						this.Lazy4DictionaryTryAdd(current4, ref activeUnit_.m_Scenario, true);
						if (this.GetUnitReadOnlyCollection().Contains(current4))
						{
							this.RemoveUnits(current4);
						}
					}
					ActiveUnit activeUnit = activeUnit_;
					Side side = this;
					StrikePlanner.smethod_35(ref activeUnit.m_Scenario, ref side, ref activeUnit_);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101064", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x002F983C File Offset: 0x002F7A3C
		public void OutdatedContact(Scenario scenario_)
		{
			try
			{
				Collection<Contact> collection = new Collection<Contact>();
				foreach (Contact current in this.GetContactObservableDictionary().Values)
				{
					if (current.IsOutdated())
					{
						collection.Add(current);
					}
				}
				foreach (Contact current2 in collection)
				{
					this.Lazy3DictionaryTryAdd(current2, ref scenario_, this == scenario_.GetCurrentSide());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 300011", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x002F993C File Offset: 0x002F7B3C
		public bool ActiveUnitIsContact(ActiveUnit activeUnit_)
		{
			Side.ClassActiveUnit @class = new Side.ClassActiveUnit();
			@class.activeUnit_0 = activeUnit_;
			return this.GetContactObservableDictionary().Values.Where(new Func<Contact, bool>(@class.IsActualUnit)).Count<Contact>() > 0;
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x002F997C File Offset: 0x002F7B7C
		public bool IsFriendlyToSide(Side side_)
		{
			bool? flag = new bool?(this.GetPostureStance(side_) == Misc.PostureStance.Friendly && side_.GetPostureStance(this) == Misc.PostureStance.Friendly);
			return !Information.IsNothing(flag) && flag.Value;
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x002F99C0 File Offset: 0x002F7BC0
		public Misc.PostureStance GetPostureStance(Side side_0)
		{
			Misc.PostureStance result;
			Misc.PostureStance postureStance;
			if (Information.IsNothing(side_0))
			{
				result = Misc.PostureStance.Unknown;
			}
			else if (side_0 == this)
			{
				result = Misc.PostureStance.Friendly;
			}
			else if (this.PosturesDictionary.TryGetValue(side_0, out postureStance))
			{
				result = postureStance;
			}
			else
			{
				result = Misc.PostureStance.Neutral;
			}
			return result;
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x002F9A08 File Offset: 0x002F7C08
		public void SetPostureStance(Side side_, Misc.PostureStance postureStance_)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(side_))
					{
						bool? flag;
						if (this.PosturesDictionary.ContainsKey(side_))
						{
							flag = new bool?(this.PosturesDictionary[side_] != postureStance_);
							if (flag.GetValueOrDefault())
							{
								this.PosturesDictionary[side_] = postureStance_;
							}
						}
						else
						{
							flag = new bool?(true);
							this.PosturesDictionary.Add(side_, postureStance_);
						}
						if (flag.GetValueOrDefault())
						{
							foreach (Contact current in this.GetContactObservableDictionary().Values)
							{
								if (current.SideIsKnown && !Information.IsNothing(current.ActualUnit) && !Information.IsNothing(current.ActualUnit.GetSide(false)) && current.ActualUnit.GetSide(false) == side_)
								{
									current.MarkAs(this, false, postureStance_);
									current.bool_11 = false;
								}
							}
							foreach (Contact current2 in this.GetContactsObDictionary().Values)
							{
								if (current2.SideIsKnown && !Information.IsNothing(current2.ActualUnit) && !Information.IsNothing(current2.ActualUnit.GetSide(false)) && current2.ActualUnit.GetSide(false) == side_)
								{
									current2.MarkAs(this, false, postureStance_);
									current2.bool_11 = false;
								}
							}
						}
						if (flag.GetValueOrDefault())
						{
							if (this.GetContactObservableDictionary().Count > 0 && !Information.IsNothing(this.GetContactObservableDictionary().Values.ElementAtOrDefault(0).ActualUnit))
							{
								Scenario scenario = this.GetContactObservableDictionary().Values.ElementAtOrDefault(0).ActualUnit.m_Scenario;
								Dictionary<Side, List<Side>> dictionary = new Dictionary<Side, List<Side>>();
								Side[] sides = scenario.GetSides();
								for (int i = 0; i < sides.Length; i++)
								{
									Side side = sides[i];
									List<Side> list = new List<Side>();
									side.EvaluateSides(scenario, list, null);
									list.Remove(side);
									dictionary.Add(side, list);
								}
								GameGeneral.smethod_21(scenario, dictionary);
							}
							if (!Information.IsNothing(postureStance_) && (postureStance_ == Misc.PostureStance.Unfriendly || postureStance_ == Misc.PostureStance.Hostile) && this.ActiveUnitArray.Length > 0)
							{
								if (postureStance_ == Misc.PostureStance.Unfriendly)
								{
									this.ActiveUnitArray[0].m_Scenario.LogMessage("推演方：'" + side_.GetSideName() + "'现视为非友方", LoggedMessage.MessageType.ContactChange, 0, null, null, null);
								}
								else if (postureStance_ == Misc.PostureStance.Hostile)
								{
									this.ActiveUnitArray[0].m_Scenario.LogMessage("推演方：'" + side_.GetSideName() + "'现视为敌对方", LoggedMessage.MessageType.ContactChange, 0, null, null, null);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101065", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x002F9D6C File Offset: 0x002F7F6C
		public void EvaluateSides(Scenario theScen, List<Side> FriendsList, List<Side> SidesAlreadyEvaludated = null)
		{
			checked
			{
				try
				{
					if (Information.IsNothing(SidesAlreadyEvaludated))
					{
						SidesAlreadyEvaludated = new List<Side>();
					}
					Side[] sides = theScen.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (side != this && !SidesAlreadyEvaludated.Contains(side) && this.GetPostureStance(side) == Misc.PostureStance.Friendly)
						{
							if (!FriendsList.Contains(side))
							{
								FriendsList.Add(side);
							}
							SidesAlreadyEvaludated.Add(side);
							side.EvaluateSides(theScen, FriendsList, SidesAlreadyEvaludated);
						}
					}
					foreach (Side current in FriendsList.ToList<Side>())
					{
						Misc.PostureStance postureStance = Misc.PostureStance.Neutral;
						if (this.PosturesDictionary.TryGetValue(current, out postureStance) && !Information.IsNothing(postureStance) && postureStance != Misc.PostureStance.Friendly)
						{
							FriendsList.Remove(current);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101066", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x002F9EA8 File Offset: 0x002F80A8
		private void ReferencePointCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			try
			{
				if (e.Action == NotifyCollectionChangedAction.Remove)
				{
					foreach (Mission current in this.Missions)
					{
						if (current.MissionClass == Mission._MissionClass.Patrol)
						{
							Patrol patrol = (Patrol)current;
                            //巡逻区
							if (patrol.PatrolAreaVertices.Contains((ReferencePoint)e.OldItems[0]))
							{
								patrol.PatrolAreaVertices.Remove((ReferencePoint)e.OldItems[0]);
							}
                            //警戒区
                            if (patrol.ProsecutionAreaVertices.Contains((ReferencePoint)e.OldItems[0]))
							{
								patrol.ProsecutionAreaVertices.Remove((ReferencePoint)e.OldItems[0]);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101067", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x0002B3F7 File Offset: 0x000295F7
		private void SetActiveUnitList0Event(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.SetActiveUnitList0(null);
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x0002B400 File Offset: 0x00029600
		private void SetActiveUnitList1Event(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.SetActiveUnitList1(null);
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x0002B409 File Offset: 0x00029609
		private void ContactDictionary_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, Contact> e)
		{
			this.SetContactList(null);
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x0002B412 File Offset: 0x00029612
		private void SetBaseContactsEvent(object sender, NotifyDictionaryChangedEventArgs<string, Contact> e)
		{
			this.SetBaseContacts(null);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x002F9FEC File Offset: 0x002F81EC
		public List<WeaponSalvo> GetWeaponSalvoListForTarget(Contact Target_)
		{
			checked
			{
				List<WeaponSalvo> result;
				try
				{
					List<WeaponSalvo> list = new List<WeaponSalvo>();
					WeaponSalvo[] weaponSalvos = this.WeaponSalvos;
					for (int i = 0; i < weaponSalvos.Length; i++)
					{
						WeaponSalvo weaponSalvo = weaponSalvos[i];
						if (weaponSalvo.Target == Target_)
						{
							list.Add(weaponSalvo);
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200549", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<WeaponSalvo>();
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x002FA094 File Offset: 0x002F8294
		public List<Weapon> GetWeaponsForTarget(ref ActiveUnit activeUnit, ref Contact theTarget)
		{
			List<Weapon> list = new List<Weapon>();
			List<Weapon> result = null;
			try
			{
				for (int i = activeUnit.GetSide(false).WeaponSalvos.Length - 1; i >= 0; i += -1)
				{
					WeaponSalvo weaponSalvo = activeUnit.GetSide(false).WeaponSalvos[i];
					checked
					{
						if (theTarget == weaponSalvo.Target)
						{
							WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
							for (int j = 0; j < shooters.Length; j++)
							{
								if (Operators.CompareString(shooters[j].ShooterObjectID, activeUnit.GetGuid(), false) == 0)
								{
									list.Add(weaponSalvo.GetWeapon(activeUnit.m_Scenario));
								}
							}
						}
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200550", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Weapon>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x002FA19C File Offset: 0x002F839C
		public int GetQuantityToFireForTheTarget(ref ActiveUnit activeUnit_, ref Contact theTarget)
		{
			int num = activeUnit_.GetSide(false).WeaponSalvos.Length;
			int num2 = 0;
			int result;
			try
			{
				int i = num - 1;
				int num3 = 0;
				while (i >= 0)
				{
					WeaponSalvo weaponSalvo;
					try
					{
						if (activeUnit_.GetSide(false).WeaponSalvos.Length == 0)
						{
							i += -1;
							continue;
						}
						if (activeUnit_.GetSide(false).WeaponSalvos.Length - 1 < i)
						{
							i = activeUnit_.GetSide(false).WeaponSalvos.Length - 1;
						}
						weaponSalvo = activeUnit_.GetSide(false).WeaponSalvos[i];
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200651", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
						i += -1;
						continue;
					}
					if (!Information.IsNothing(weaponSalvo) && theTarget == weaponSalvo.Target)
					{
						int j = weaponSalvo.m_Shooters.Length - 1;
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
								ex4.Data.Add("Error at 200467", ex4.Message);
								GameGeneral.LogException(ref ex4);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
								j += -1;
								continue;
							}
							if (Information.IsNothing(shooter) || Operators.CompareString(shooter.ShooterObjectID, activeUnit_.GetGuid(), false) != 0)
							{
								j += -1;
							}
							else
							{
								if (shooter.QuantityAssigned == 2147483647)
								{
									num2 = shooter.QuantityAssigned;
									result = num2;
									return result;
								}
								if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
								{
									num3 += shooter.QuantityAssigned - shooter.QuantityFired;
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
				num2 = num3;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 200551", ex6.Message);
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num2 = 0;
				ProjectData.ClearProjectError();
			}
			result = num2;
			return result;
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x002FA46C File Offset: 0x002F866C
		public int GetQuantityToFireForTheWeapon(ref ActiveUnit activeUnit_, int weaponDBID)
		{
			int num = 0;
			checked
			{
				int result;
				try
				{
					WeaponSalvo[] weaponSalvos = activeUnit_.GetSide(false).WeaponSalvos;
					int num2 = 0;
					for (int i = 0; i < weaponSalvos.Length; i++)
					{
						WeaponSalvo weaponSalvo = weaponSalvos[i];
						if (weaponDBID == weaponSalvo.WeaponDBID)
						{
							WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
							for (int j = 0; j < shooters.Length; j++)
							{
								WeaponSalvo.Shooter shooter = shooters[j];
								unchecked
								{
									if (Operators.CompareString(shooter.ShooterObjectID, activeUnit_.GetGuid(), false) == 0)
									{
										if (shooter.QuantityAssigned == 2147483647)
										{
											num = shooter.QuantityAssigned;
											result = num;
											return result;
										}
										if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
										{
											num2 += shooter.QuantityAssigned - shooter.QuantityFired;
										}
									}
								}
							}
						}
					}
					num = num2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200552", ex2.Message);
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
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x002FA59C File Offset: 0x002F879C
		public int GetQuantityToFireForThePlatform(ref ActiveUnit activeUnit_)
		{
			int num = 0;
			checked
			{
				int result;
				try
				{
					WeaponSalvo[] weaponSalvos = activeUnit_.GetSide(false).WeaponSalvos;
					int num2 = 0;
					for (int i = 0; i < weaponSalvos.Length; i++)
					{
						WeaponSalvo.Shooter[] shooters = weaponSalvos[i].m_Shooters;
						for (int j = 0; j < shooters.Length; j++)
						{
							WeaponSalvo.Shooter shooter = shooters[j];
							unchecked
							{
								if (Operators.CompareString(shooter.ShooterObjectID, activeUnit_.GetGuid(), false) == 0)
								{
									if (shooter.QuantityAssigned == 2147483647)
									{
										num = shooter.QuantityAssigned;
										result = num;
										return result;
									}
									if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
									{
										num2 += shooter.QuantityAssigned - shooter.QuantityFired;
									}
								}
							}
						}
					}
					num = num2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200553", ex2.Message);
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
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x002FA6BC File Offset: 0x002F88BC
		public List<WeaponSalvo> GetWeaponSalvosForTarget(ref ActiveUnit activeUnit_, ref Contact Target_)
		{
			List<WeaponSalvo> list = new List<WeaponSalvo>();
			checked
			{
				List<WeaponSalvo> result;
				try
				{
					WeaponSalvo[] weaponSalvos = activeUnit_.GetSide(false).WeaponSalvos;
					for (int i = 0; i < weaponSalvos.Length; i++)
					{
						WeaponSalvo weaponSalvo = weaponSalvos[i];
						if (Target_ == weaponSalvo.Target)
						{
							WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
							for (int j = 0; j < shooters.Length; j++)
							{
								if (Operators.CompareString(shooters[j].ShooterObjectID, activeUnit_.GetGuid(), false) == 0)
								{
									list.Add(weaponSalvo);
								}
							}
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200554", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<WeaponSalvo>();
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x002FA7A8 File Offset: 0x002F89A8
		public List<WeaponSalvo> GetWeaponSalvoList(ref ActiveUnit activeUnit_)
		{
			List<WeaponSalvo> list = new List<WeaponSalvo>();
			checked
			{
				List<WeaponSalvo> result;
				try
				{
					WeaponSalvo[] weaponSalvos = activeUnit_.GetSide(false).WeaponSalvos;
					for (int i = 0; i < weaponSalvos.Length; i++)
					{
						WeaponSalvo weaponSalvo = weaponSalvos[i];
						WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
						for (int j = 0; j < shooters.Length; j++)
						{
							if (Operators.CompareString(shooters[j].ShooterObjectID, activeUnit_.GetGuid(), false) == 0)
							{
								list.Add(weaponSalvo);
							}
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200555", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<WeaponSalvo>();
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x002FA884 File Offset: 0x002F8A84
		public int? GetWeaponQuantity(int? weaponQuantity_, ref ActiveUnit activeUnit_, ref Contact target_, ref Weapon weapon_)
		{
			int? num = weaponQuantity_;
			int? num2 = num;
			int? num3 = null;
			int? result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -2) : null).GetValueOrDefault())
			{
				weaponQuantity_ = new int?(activeUnit_.GetWeaponry().GetMissileDefenseValueForTarget(ref target_));
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -5) : null).GetValueOrDefault())
				{
					weaponQuantity_ = new int?(activeUnit_.GetWeaponry().GetMissileDefenseValueForTarget(ref target_));
					num2 = weaponQuantity_;
					if (!(num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						num2 = weaponQuantity_;
						if (!(num2.HasValue ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							num2 = weaponQuantity_;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() > 2) : null).GetValueOrDefault())
							{
								weaponQuantity_ = new int?((int)Math.Round(Math.Round((double)weaponQuantity_.Value / 2.0, 0)));
								goto IL_3C8;
							}
							goto IL_3C8;
						}
					}
					num3 = new int?(1);
					result = num3;
					return result;
				}
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -6) : null).GetValueOrDefault())
				{
					weaponQuantity_ = new int?(activeUnit_.GetWeaponry().GetMissileDefenseValueForTarget(ref target_));
					num2 = weaponQuantity_;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() >= 1) : null).GetValueOrDefault())
					{
						num2 = weaponQuantity_;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() <= 4) : null).GetValueOrDefault())
						{
							num3 = new int?(1);
							result = num3;
							return result;
						}
					}
					num2 = weaponQuantity_;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() > 4) : null).GetValueOrDefault())
					{
						weaponQuantity_ = new int?((int)Math.Round(Math.Round((double)weaponQuantity_.Value / 4.0, 0)));
					}
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -3) : null).GetValueOrDefault())
					{
						weaponQuantity_ = new int?(Convert.ToInt32(Math.Round(new decimal(activeUnit_.GetWeaponry().GetMissileDefenseValueForTarget(ref target_) * 2), 0)));
					}
					else
					{
						num2 = num;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -4) : null).GetValueOrDefault())
						{
							weaponQuantity_ = new int?(Convert.ToInt32(Math.Round(new decimal(activeUnit_.GetWeaponry().GetMissileDefenseValueForTarget(ref target_) * 4), 0)));
						}
						else
						{
							num2 = num;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								Doctrine doctrine = activeUnit_.m_Doctrine;
								Scenario scenario = activeUnit_.m_Scenario;
								Weapon theWeapon = weapon_;
								Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = activeUnit_.m_Doctrine.GetWRA_WeaponTargetType(ref target_);
								num2 = null;
								int? num4 = null;
								weaponQuantity_ = doctrine.GetWeaponQty(scenario, theWeapon, wRA_WeaponTargetType, false, ref num2, ref num4);
							}
						}
					}
				}
			}
			IL_3C8:
			num3 = weaponQuantity_;
			result = num3;
			return result;
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x002FAC60 File Offset: 0x002F8E60
		private void ExportEngagementCycle(string string_4, Contact contact_0, string string_5, Scenario scenario_0)
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
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), ""));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), ""));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), ""));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), this.GetSideName()));
					dictionary.Add("CycleAction", new Tuple<Type, string>(typeof(string), string_4));
					dictionary.Add("ContactID", new Tuple<Type, string>(typeof(string), contact_0.GetGuid()));
					dictionary.Add("ContactName", new Tuple<Type, string>(typeof(string), contact_0.Name));
					dictionary.Add("ContactLongitude", new Tuple<Type, string>(typeof(double), contact_0.GetLongitude(null).ToString()));
					dictionary.Add("ContactLatitude", new Tuple<Type, string>(typeof(double), contact_0.GetLatitude(null).ToString()));
					dictionary.Add("ContactRangeHoriz_nm", new Tuple<Type, string>(typeof(float), ""));
					dictionary.Add("ContactRangeSlant_nm", new Tuple<Type, string>(typeof(float), ""));
					if (!Information.IsNothing(contact_0.ActualUnit))
					{
						dictionary.Add("ContactActualUnitID", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.GetGuid()));
						dictionary.Add("ContactActualUnitName", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.Name));
						dictionary.Add("ContactActualUnitClass", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.UnitClass));
						dictionary.Add("ContactActualUnitSide", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.GetSide(false).GetSideName()));
					}
					else
					{
						dictionary.Add("ContactActualUnitID", new Tuple<Type, string>(typeof(string), "-"));
						dictionary.Add("ContactActualUnitName", new Tuple<Type, string>(typeof(string), contact_0.Name));
						dictionary.Add("ContactActualUnitClass", new Tuple<Type, string>(typeof(string), "-"));
						dictionary.Add("ContactActualUnitSide", new Tuple<Type, string>(typeof(string), "-"));
					}
					dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), string_5));
					current.ExportEvent(ExportedEventType.EngagementCycle, dictionary, scenario_0);
				}
			}
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x002FB060 File Offset: 0x002F9260
		public WeaponSalvo WeaponSalvoAssigned(Scenario scenario_0, ref Weapon weapon_0, ref Contact contact_0, int? nullable_3, int int_4, int? nullable_4, bool bool_12, ref string string_4, ref int? nullable_5, DateTime dateTime_0)
		{
			if (Information.IsNothing(nullable_5))
			{
				nullable_5 = new int?(1);
			}
			if (Information.IsNothing(nullable_3))
			{
				nullable_3 = new int?(2147483647);
			}
			if (Information.IsNothing(nullable_4))
			{
				nullable_4 = new int?(2147483647);
			}
			int? num = nullable_3;
			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2147483647) : null).GetValueOrDefault())
			{
				nullable_4 = nullable_3;
			}
			bool theFireSimultaneouslyFromMultipleMounts = true;
			if (weapon_0.IsGuidedWeapon() || weapon_0.IsTorpedo() || weapon_0.IsRVorHGV() || weapon_0.IsDecoyVehicle())
			{
				theFireSimultaneouslyFromMultipleMounts = false;
			}
			WeaponSalvo weaponSalvo = new WeaponSalvo(ref weapon_0.DBID, nullable_3.Value, int_4, nullable_4.Value, ref contact_0, ref bool_12, string_4, nullable_5.Value, theFireSimultaneouslyFromMultipleMounts, dateTime_0, null);
			ScenarioArrayUtil.AddWeaponSalvo(ref this.WeaponSalvos, weaponSalvo);
			if (EventExporters.listRegular.Any<IEventExporter>())
			{
				string text = "";
				try
				{
					text = scenario_0.GetActiveUnits()[string_4].Name;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text = "UNKNOWN";
					ProjectData.ClearProjectError();
				}
				this.ExportEngagementCycle("Assigning new weapon salvo", contact_0, string.Concat(new string[]
				{
					"Weapons assigned: ",
					nullable_3.HasValue ? Conversions.ToString(nullable_3.GetValueOrDefault()) : null,
					"x ",
					weapon_0.Name,
					" [DBID: ",
					Conversions.ToString(weapon_0.DBID),
					"]. Shooter: ",
					text
				}), scenario_0);
			}
			return weaponSalvo;
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x002FB248 File Offset: 0x002F9448
		public void SetWeaponSalvoParameter(ref WeaponSalvo WeaponSalvo_, int? nullable_3, int int_4, int? nullable_4, bool bool_12, ref string string_4)
		{
			try
			{
				if (Information.IsNothing(nullable_4))
				{
					nullable_4 = new int?(2147483647);
				}
				if (Information.IsNothing(nullable_3))
				{
					nullable_3 = new int?(2147483647);
				}
				int? num = nullable_3;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2147483647) : null).GetValueOrDefault())
				{
					nullable_4 = nullable_3;
				}
				if (bool_12)
				{
					WeaponSalvo.Shooter[] shooters = WeaponSalvo_.m_Shooters;
					for (int i = 0; i < shooters.Length; i = checked(i + 1))
					{
						WeaponSalvo.Shooter shooter = shooters[i];
						if (Operators.CompareString(shooter.ShooterObjectID, string_4, false) == 0)
						{
							shooter.QuantityAssigned += nullable_3.Value;
							WeaponSalvo_.Quantity_Total += nullable_3.Value;
							WeaponSalvo_.ManualFire = bool_12;
							goto IL_1F2;
						}
					}
					WeaponSalvo_.Quantity_Total += nullable_3.Value;
					WeaponSalvo_.ManualFire = bool_12;
				}
				else
				{
					int totalQuantityAssigned = WeaponSalvo_.GetTotalQuantityAssigned();
					int quantity_Total = WeaponSalvo_.Quantity_Total;
					if (quantity_Total != -99)
					{
						num = nullable_4;
						int num2 = quantity_Total - totalQuantityAssigned;
						bool? flag;
						bool? flag2;
						if (!(num.HasValue ? new bool?(num.GetValueOrDefault() > num2) : null).GetValueOrDefault())
						{
							flag = new bool?(false);
						}
						else
						{
							num = nullable_4;
							flag2 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 2147483647) : null);
							flag = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
						}
						flag2 = flag;
						if (flag2.GetValueOrDefault())
						{
							nullable_4 = new int?(quantity_Total - totalQuantityAssigned);
						}
					}
					WeaponSalvo.Shooter shooter_ = new WeaponSalvo.Shooter(string_4, nullable_4.Value, int_4);
					ScenarioArrayUtil.AddShooter(ref WeaponSalvo_.m_Shooters, shooter_);
				}
				IL_1F2:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200557", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x002FB4A8 File Offset: 0x002F96A8
		public void RemoveWeaponSalvoForTarget(ref Scenario scenario_, ref ActiveUnit activeUnit_3, ref Contact Target, ref WeaponSalvo WeaponSalvo_)
		{
			List<WeaponSalvo> list = new List<WeaponSalvo>();
			try
			{
				List<WeaponSalvo> list2 = activeUnit_3.GetSide(false).WeaponSalvos.ToList<WeaponSalvo>();
				for (int i = list2.Count - 1; i >= 0; i += -1)
				{
					WeaponSalvo weaponSalvo = list2[i];
					if (!Information.IsNothing(weaponSalvo) && (Information.IsNothing(Target) || weaponSalvo.Target == Target) && (Information.IsNothing(WeaponSalvo_) || weaponSalvo == WeaponSalvo_))
					{
						List<WeaponSalvo.Shooter> list3 = new List<WeaponSalvo.Shooter>();
						List<WeaponSalvo.Shooter> list4 = weaponSalvo.m_Shooters.ToList<WeaponSalvo.Shooter>();
						for (int j = list4.Count - 1; j >= 0; j += -1)
						{
							WeaponSalvo.Shooter shooter = list4[j];
							if (!Information.IsNothing(activeUnit_3) && !Information.IsNothing(shooter) && Operators.CompareString(activeUnit_3.GetGuid(), shooter.ShooterObjectID, false) == 0)
							{
								if (shooter.QuantityFired == 0)
								{
									this.UnguidedWeaponDestroyed(ref scenario_, null, shooter.ShooterObjectID, ref weaponSalvo);
									list3.Add(shooter);
								}
								else
								{
									shooter.QuantityAssigned = shooter.QuantityFired;
								}
								IL_110:
								foreach (WeaponSalvo.Shooter current in list3)
								{
									ScenarioArrayUtil.RemoveShooter(ref weaponSalvo.m_Shooters, current);
									list.Add(weaponSalvo);
								}
								goto IL_151;
							}
						}
                        foreach (WeaponSalvo.Shooter current in list3)
                        {
                            ScenarioArrayUtil.RemoveShooter(ref weaponSalvo.m_Shooters, current);
                            list.Add(weaponSalvo);
                        }
                        goto IL_151;
                    }
					IL_151:;
				}
				for (int k = list.Count - 1; k >= 0; k += -1)
				{
					WeaponSalvo weaponSalvo_ = list[k];
					this.RemoveWeaponSalvo(weaponSalvo_);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200558", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x002FB6BC File Offset: 0x002F98BC
		public void RemoveWeaponSalvoByID(ref string string_4)
		{
			checked
			{
				try
				{
					List<WeaponSalvo> list = new List<WeaponSalvo>();
					WeaponSalvo[] weaponSalvos = this.WeaponSalvos;
					int i = 0;
					IL_E7:
					while (i < weaponSalvos.Length)
					{
						WeaponSalvo weaponSalvo = weaponSalvos[i];
						List<string> list2 = new List<string>();
						string[] weaponObjectIDArray = weaponSalvo.WeaponObjectIDArray;
						for (int j = 0; j < weaponObjectIDArray.Length; j++)
						{
							if (Operators.CompareString(weaponObjectIDArray[j], string_4, false) == 0)
							{
								list2.Add(string_4);
								foreach (string current in list2)
								{
									ScenarioArrayUtil.RemoveStringFromArray(ref weaponSalvo.WeaponObjectIDArray, current);
									list.Add(weaponSalvo);
								}
								i++;
								goto IL_E7;
							}
						}
						foreach (string current in list2)
						{
							ScenarioArrayUtil.RemoveStringFromArray(ref weaponSalvo.WeaponObjectIDArray, current);
							list.Add(weaponSalvo);
						}
						i++;
					}
					foreach (WeaponSalvo current2 in list)
					{
						this.RemoveWeaponSalvo(current2);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200559", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x002FB898 File Offset: 0x002F9A98
		public void UnguidedWeaponDestroyed(ref Scenario scenario_0, Contact contact_0, string string_4, ref WeaponSalvo class142_1)
		{
			Side.Class193 @class = new Side.Class193(null);
			@class.string_0 = string_4;
			if (!Information.IsNothing(contact_0) && !Information.IsNothing(contact_0.ActualUnit))
			{
				Side.Class192 class2 = new Side.Class192(null);
				for (int i = class142_1.WeaponObjectIDArray.Count<string>() - 1; i >= 0; i += -1)
				{
					class2.WeaponGUID = class142_1.WeaponObjectIDArray[i];
					if (scenario_0.GetUnguidedWeapons().ContainsKey(class2.WeaponGUID))
					{
						UnguidedWeapon unguidedWeapon = scenario_0.GetUnguidedWeapons().Values.Where((class2.func_0 == null) ? (class2.func_0 = new Func<UnguidedWeapon, bool>(class2.method_0)) : class2.func_0).ElementAtOrDefault(0);
						if (!Information.IsNothing(unguidedWeapon) && (unguidedWeapon.GetWeaponType() == Weapon._WeaponType.IronBomb || unguidedWeapon.GetWeaponType() == Weapon._WeaponType.Rocket || unguidedWeapon.GetWeaponType() == Weapon._WeaponType.DepthCharge))
						{
							UnguidedWeapon unguidedWeapon2 = unguidedWeapon;
							ActiveUnit actualUnit = contact_0.ActualUnit;
							Random random = GameGeneral.GetRandom();
							unguidedWeapon2.method_75(actualUnit, contact_0, ref scenario_0, ref random);
							unguidedWeapon.ExportUnitDestroyed(ref scenario_0);
						}
					}
				}
			}
			if (!string.IsNullOrEmpty(@class.string_0))
			{
				Side.Class194 class3 = new Side.Class194(null);
				class3.class193_0 = @class;
				class3.class142_0 = class142_1;
				IEnumerable<UnguidedWeapon> source = scenario_0.GetUnguidedWeapons().Values.Where(new Func<UnguidedWeapon, bool>(class3.method_0));
				for (int j = source.Count<UnguidedWeapon>() - 1; j >= 0; j += -1)
				{
					UnguidedWeapon unguidedWeapon3 = source.ElementAtOrDefault(j);
					if (!Information.IsNothing(unguidedWeapon3.Target) && !Information.IsNothing(unguidedWeapon3.Target.ActualUnit) && (unguidedWeapon3.GetWeaponType() == Weapon._WeaponType.IronBomb || unguidedWeapon3.GetWeaponType() == Weapon._WeaponType.Rocket || unguidedWeapon3.GetWeaponType() == Weapon._WeaponType.DepthCharge))
					{
						UnguidedWeapon unguidedWeapon4 = unguidedWeapon3;
						ActiveUnit actualUnit2 = unguidedWeapon3.Target.ActualUnit;
						Contact target = unguidedWeapon3.Target;
						Random random = GameGeneral.GetRandom();
						unguidedWeapon4.method_75(actualUnit2, target, ref scenario_0, ref random);
						unguidedWeapon3.ExportUnitDestroyed(ref scenario_0);
					}
				}
			}
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x002FBAD0 File Offset: 0x002F9CD0
		public void RemoveWeaponSalvoByContact(ref Scenario scenario_0, Contact contact_0)
		{
			try
			{
				List<WeaponSalvo> list = new List<WeaponSalvo>();
				for (int i = this.WeaponSalvos.Length - 1; i >= 0; i += -1)
				{
					WeaponSalvo weaponSalvo = this.WeaponSalvos[i];
					if (weaponSalvo.Target == contact_0)
					{
						this.UnguidedWeaponDestroyed(ref scenario_0, contact_0, null, ref weaponSalvo);
						if (this.WeaponSalvos.Contains(weaponSalvo))
						{
							list.Add(weaponSalvo);
						}
					}
				}
				for (int j = list.Count - 1; j >= 0; j += -1)
				{
					WeaponSalvo weaponSalvo = list[j];
					ScenarioArrayUtil.RemoveWeaponSalvo(ref this.WeaponSalvos, weaponSalvo);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200564", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x002FBBB8 File Offset: 0x002F9DB8
		public void RemoveWeaponSalvoByShooterID(ref Scenario scenario_0, string string_4)
		{
			try
			{
				List<WeaponSalvo> list = new List<WeaponSalvo>();
				int i = this.WeaponSalvos.Length - 1;
				IL_114:
				while (i >= 0)
				{
					WeaponSalvo weaponSalvo = this.WeaponSalvos[i];
					List<WeaponSalvo.Shooter> list2 = new List<WeaponSalvo.Shooter>();
					for (int j = weaponSalvo.m_Shooters.Length - 1; j >= 0; j += -1)
					{
						WeaponSalvo.Shooter shooter = weaponSalvo.m_Shooters[j];
						if (Operators.CompareString(shooter.ShooterObjectID, string_4, false) == 0)
						{
							this.UnguidedWeaponDestroyed(ref scenario_0, null, string_4, ref weaponSalvo);
							if (weaponSalvo.m_Shooters.Contains(shooter))
							{
								list2.Add(shooter);
							}
							foreach (WeaponSalvo.Shooter current in list2)
							{
								ScenarioArrayUtil.RemoveShooter(ref weaponSalvo.m_Shooters, current);
								list.Add(weaponSalvo);
							}
							i += -1;
							goto IL_114;
						}
					}
					foreach (WeaponSalvo.Shooter current in list2)
					{
						ScenarioArrayUtil.RemoveShooter(ref weaponSalvo.m_Shooters, current);
						list.Add(weaponSalvo);
					}
					i += -1;
				}
				for (int k = list.Count - 1; k >= 0; k += -1)
				{
					WeaponSalvo weaponSalvo = list[k];
					this.RemoveWeaponSalvo(weaponSalvo);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200563", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x002FBDA4 File Offset: 0x002F9FA4
		public void RemoveWeaponSalvoByKeyValue(ref Scenario scenario_0, string string_4, ref WeaponSalvo class142_1)
		{
            try
            {
                List<WeaponSalvo.Shooter> list2;
                WeaponSalvo.Shooter shooter;
                int num3;
                List<WeaponSalvo> list = new List<WeaponSalvo>();
                int index = this.WeaponSalvos.Length - 1;
            Label_0012:
                if (index < 0)
                {
                    goto Label_0127;
                }
                WeaponSalvo item = this.WeaponSalvos[index];
                if (item == class142_1)
                {
                    list2 = new List<WeaponSalvo.Shooter>();
                    for (int i = item.m_Shooters.Length - 1; i >= 0; i += -1)
                    {
                        shooter = item.m_Shooters[i];
                        if (shooter.ShooterObjectID == string_4)
                        {
                            goto Label_00B9;
                        }
                    }
                    foreach (WeaponSalvo.Shooter shooter2 in list2)
                    {
                        ScenarioArrayUtil.RemoveShooter(ref item.m_Shooters, shooter2);
                        list.Add(item);
                    }
                }
                goto Label_011E;
            Label_00B9:
                this.UnguidedWeaponDestroyed(ref scenario_0, null, string_4, ref item);
                if (item.m_Shooters.Contains<WeaponSalvo.Shooter>(shooter))
                {
                    list2.Add(shooter);
                }
                foreach (WeaponSalvo.Shooter shooter2 in list2)
                {
                    ScenarioArrayUtil.RemoveShooter(ref item.m_Shooters, shooter2);
                    list.Add(item);
                }
            Label_011E:
                index += -1;
                goto Label_0012;
            Label_0127:
                num3 = list.Count - 1;
                while (num3 >= 0)
                {
                    item = list[num3];
                    this.RemoveWeaponSalvo(item);
                    num3 += -1;
                }
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Exception exception2 = exception;
                exception2.Data.Add("Error at 200562", exception2.Message);
                GameGeneral.LogException(ref exception2);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }

        }

        // Token: 0x06006226 RID: 25126 RVA: 0x002FBF94 File Offset: 0x002FA194
        public void RemoveWeaponSalvo(WeaponSalvo WeaponSalvo_)
		{
			if (WeaponSalvo_.WeaponObjectIDArray.Count<string>() <= 0)
			{
				if (WeaponSalvo_.GetTotalQuantityFired() >= WeaponSalvo_.GetTotalQuantityAssigned())
				{
					ScenarioArrayUtil.RemoveWeaponSalvo(ref this.WeaponSalvos, WeaponSalvo_);
				}
				else if (WeaponSalvo_.m_Shooters.Length <= 0)
				{
					ScenarioArrayUtil.RemoveWeaponSalvo(ref this.WeaponSalvos, WeaponSalvo_);
				}
				else if (WeaponSalvo_.WeaponObjectIDArray.Count<string>() == 0 && WeaponSalvo_.GetTotalQuantityFired() > 0 && (!WeaponSalvo_.ManualFire || (WeaponSalvo_.ManualFire && SimConfiguration.gameOptions.IsSalvoTimeout())))
				{
					if (!WeaponSalvo_.FireSimultaneouslyFromMultipleMounts)
					{
						ScenarioArrayUtil.RemoveWeaponSalvo(ref this.WeaponSalvos, WeaponSalvo_);
					}
					else if (!WeaponSalvo_.ManualFire)
					{
						ScenarioArrayUtil.RemoveWeaponSalvo(ref this.WeaponSalvos, WeaponSalvo_);
					}
				}
			}
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x002FC058 File Offset: 0x002FA258
		public int PackageIDInc()
		{
			this.PackageID++;
			return this.PackageID;
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x002FC07C File Offset: 0x002FA27C
		public int GetPackageID()
		{
			if (this.PackageID < 1000)
			{
				this.PackageID = GameGeneral.GetRandom().Next(1000, 8000);
			}
			else if (this.PackageID > 9999)
			{
				this.PackageID = 1000;
			}
			return this.PackageID;
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x0002B41B File Offset: 0x0002961B
		[CompilerGenerated]
		private bool IsThisLoggedMessageSide(LoggedMessage loggedMessage_0)
		{
			return !Information.IsNothing(loggedMessage_0) && (Information.IsNothing(loggedMessage_0.side) || loggedMessage_0.side == this);
		}

		// Token: 0x0400352E RID: 13614
		public static Func<ActiveUnit, bool> ActiveUnitFunc = (ActiveUnit activeUnit_0) => activeUnit_0.IsOperating();

		// Token: 0x0400352F RID: 13615
		private string strSideName;

		// Token: 0x04003530 RID: 13616
		private Dictionary<Side, Misc.PostureStance> PosturesDictionary;

		// Token: 0x04003531 RID: 13617
		private Dictionary<string, Misc.PostureStance> dictionary_1;

		// Token: 0x04003532 RID: 13618
		public bool bool_8;

		// Token: 0x04003533 RID: 13619
		[CompilerGenerated]
		private ObservableCollection<ActiveUnit> observableCollection_0;

		// Token: 0x04003534 RID: 13620
		[CompilerGenerated]
		private ObservableCollection<ActiveUnit> observableCollection_1;

		// Token: 0x04003535 RID: 13621
		public string Briefing;

		// Token: 0x04003536 RID: 13622
		private List<Unit> Units;

		// Token: 0x04003537 RID: 13623
		private GeoPoint MapCenter;

		// Token: 0x04003538 RID: 13624
		public double CameraAlt;

		// Token: 0x04003539 RID: 13625
		private List<Mission> Missions;

		// Token: 0x0400353A RID: 13626
		private Collection<Goal> Goals;

		// Token: 0x0400353B RID: 13627
		private int TotalScore;

		// Token: 0x0400353C RID: 13628
		public int? Scoring_Disaster;

		// Token: 0x0400353D RID: 13629
		public int? Scoring_Triumph;

		// Token: 0x0400353E RID: 13630
		private Side.AwarenessLevel awarenessLevel;

		// Token: 0x0400353F RID: 13631
		private GlobalVariables.ProficiencyLevel? m_ProficiencyLevel;

		// Token: 0x04003540 RID: 13632
		public Dictionary<string, SpecialAction> SpecialActions;

		// Token: 0x04003541 RID: 13633
		private float TimeToNextContactProcessCycle;

		// Token: 0x04003542 RID: 13634
		[CompilerGenerated]
		private ObservableDictionary<string, Contact> ContactDictionary;

		// Token: 0x04003543 RID: 13635
		[CompilerGenerated]
		private ObservableDictionary<string, Contact> ContactObservableDictionary;

		// Token: 0x04003544 RID: 13636
		public HashSet<string> Contacts_NonAU;

		// Token: 0x04003545 RID: 13637
		internal int ContactAutoIncrement;

		// Token: 0x04003546 RID: 13638
		internal int ContactNo = 0;

		// Token: 0x04003547 RID: 13639
		internal Lazy<ConcurrentDictionary<string, Contact>> LazyContactList_OnGrid;

		// Token: 0x04003548 RID: 13640
		internal Lazy<ConcurrentDictionary<string, Contact>> lazyNewContactDictionary;

		// Token: 0x04003549 RID: 13641
		internal Lazy<ConcurrentDictionary<string, Contact>> lazy_3;

		// Token: 0x0400354A RID: 13642
		internal Lazy<ConcurrentDictionary<string, Contact>> lazy_4;

		// Token: 0x0400354B RID: 13643
		private bool bAIOnly;

		// Token: 0x0400354C RID: 13644
		public ActiveUnit[] ActiveUnitArray;

		// Token: 0x0400354D RID: 13645
		[CompilerGenerated]
		private ObservableCollection<ReferencePoint> ReferencePointCollection;

		// Token: 0x0400354E RID: 13646
		private List<ActiveUnit> m_JammerPlatforms;

		// Token: 0x0400354F RID: 13647
		public Doctrine m_Doctrine;

		// Token: 0x04003550 RID: 13648
		public Side.AAR m_AAR;

		// Token: 0x04003551 RID: 13649
		public List<ExclusionZone> ExclusionZoneList;

		// Token: 0x04003552 RID: 13650
		public List<NoNavZone> NoNavZoneList;

		// Token: 0x04003553 RID: 13651
		public bool CollectiveResponsibility;

		// Token: 0x04003554 RID: 13652
		public bool CATC;

		// Token: 0x04003555 RID: 13653
		public Dictionary<byte, QuickJumpSlot> QuickJumpSlots;

		// Token: 0x04003556 RID: 13654
		internal WeaponSalvo[] WeaponSalvos;

		// Token: 0x04003557 RID: 13655
		public List<string> ScoringLogs;

		// Token: 0x04003558 RID: 13656
		private int PackageID;

		// Token: 0x04003559 RID: 13657
		private MapProfile mapProfile;

		// Token: 0x0400355A RID: 13658
		private List<ActiveUnit> list_6;

		// Token: 0x0400355B RID: 13659
		private List<ActiveUnit> list_7;

		// Token: 0x0400355C RID: 13660
		private List<Contact> ContactList;

		// Token: 0x0400355D RID: 13661
		private List<Contact> list_9;

		// Token: 0x0400355E RID: 13662
		private ActiveUnit[] NoneWeaponFriendlyUnits;

		// Token: 0x0400355F RID: 13663
		private ActiveUnit[] activeUnit_2;

		// Token: 0x04003560 RID: 13664
		private HashSet<string> hashSet_1;

		// Token: 0x04003561 RID: 13665
		private HashSet<string> hashSet_2;

		// Token: 0x04003562 RID: 13666
		[CompilerGenerated]
		private Side.Delegate22 delegate22_0;

		// Token: 0x04003563 RID: 13667
		[CompilerGenerated]
		private static Side.Delegate23 delegate23_0;

		// Token: 0x04003564 RID: 13668
		private ReadOnlyCollection<Mission> readOnlyPatrolMissions;

		// Token: 0x02000B98 RID: 2968
		// (Invoke) Token: 0x0600622D RID: 25133
		public delegate void Delegate22();

		// Token: 0x02000B99 RID: 2969
		// (Invoke) Token: 0x06006231 RID: 25137
		public delegate void Delegate23(Side theSide);

		// Token: 0x02000B9A RID: 2970
		public sealed class AAR
		{
			// Token: 0x06006234 RID: 25140 RVA: 0x0002B465 File Offset: 0x00029665
			public AAR()
			{
				this.Losses = new Dictionary<string, HashSet<string>>();
				this.Expenditures = new Dictionary<int, int>();
			}

			// Token: 0x06006235 RID: 25141 RVA: 0x002FC0DC File Offset: 0x002FA2DC
			public void AddToExpenditures(int DBID_, int Num)
			{
				if (Information.IsNothing(this.Expenditures))
				{
					this.Expenditures = new Dictionary<int, int>();
				}
				if (this.Expenditures.ContainsKey(DBID_))
				{
					this.Expenditures[DBID_] = this.Expenditures[DBID_] + Num;
				}
				else
				{
					this.Expenditures.Add(DBID_, Num);
				}
			}

			// Token: 0x06006236 RID: 25142 RVA: 0x002FC140 File Offset: 0x002FA340
			public void LossesAdd(Subject theSubject, bool bool_0)
			{
				if (Information.IsNothing(this.Losses))
				{
					this.Losses = new Dictionary<string, HashSet<string>>();
				}
				string key = "";
				if (theSubject.IsAircraft)
				{
					key = "Aircraft_" + Conversions.ToString(((Aircraft)theSubject).DBID);
				}
				else if (theSubject.IsShip)
				{
					key = "Ship_" + Conversions.ToString(((Ship)theSubject).DBID);
				}
				else if (theSubject.IsSubmarine)
				{
					key = "Submarine_" + Conversions.ToString(((Submarine)theSubject).DBID);
				}
				else if (theSubject.IsFacility)
				{
					key = "Facility_" + Conversions.ToString(((Facility)theSubject).DBID);
				}
				else if (bool_0)
				{
					key = "FacilityAimpoint_" + Conversions.ToString(((Mount)theSubject).DBID);
				}
				else if (theSubject.IsSatellite())
				{
					key = "Satellite_" + Conversions.ToString(((Satellite)theSubject).DBID);
				}
				else if (theSubject is Cargo)
				{
					Cargo cargo = (Cargo)theSubject;
					if (cargo.GetCurrentType() == Cargo._CargoType.const_1)
					{
						Mount mount = (Mount)cargo.GetCargo();
						key = "FacilityAimpoint_" + Conversions.ToString(mount.DBID);
					}
					else if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (this.Losses.ContainsKey(key))
				{
					this.Losses[key].Add(theSubject.GetGuid());
				}
				else
				{
					HashSet<string> hashSet = new HashSet<string>();
					hashSet.Add(theSubject.GetGuid());
					this.Losses.Add(key, hashSet);
				}
			}

			// Token: 0x06006237 RID: 25143 RVA: 0x002FC31C File Offset: 0x002FA51C
			public void Save(ref XmlWriter xmlWriter_0)
			{
				try
				{
					xmlWriter_0.WriteStartElement("AAR");
					if (Information.IsNothing(this.Losses))
					{
						this.Losses = new Dictionary<string, HashSet<string>>();
					}
					xmlWriter_0.WriteStartElement("Losses");
					foreach (KeyValuePair<string, HashSet<string>> current in this.Losses)
					{
						xmlWriter_0.WriteElementString(current.Key.ToString(), string.Join("_", current.Value));
					}
					xmlWriter_0.WriteEndElement();
					if (Information.IsNothing(this.Expenditures))
					{
						this.Expenditures = new Dictionary<int, int>();
					}
					xmlWriter_0.WriteStartElement("Expenditures");
					foreach (KeyValuePair<int, int> current2 in this.Expenditures)
					{
						xmlWriter_0.WriteElementString("Weapon_" + current2.Key.ToString(), current2.Value.ToString());
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101068", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06006238 RID: 25144 RVA: 0x002FC4D8 File Offset: 0x002FA6D8
			public static Side.AAR Load(ref XmlNode xmlNode_0)
			{
				Side.AAR aAR = new Side.AAR();
				Side.AAR result;
				try
				{
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "Losses", false) != 0)
							{
								if (Operators.CompareString(name, "Expenditures", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										string[] array = xmlNode2.Name.Split(new char[]
										{
											'_'
										});
										aAR.Expenditures.Add(Conversions.ToInteger(array[1]), Conversions.ToInteger(xmlNode2.InnerText));
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
							IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
									if (Versioned.IsNumeric(xmlNode3.InnerText))
									{
										int num = Conversions.ToInteger(xmlNode3.InnerText);
										HashSet<string> hashSet = new HashSet<string>();
										int num2 = num;
										for (int i = 1; i <= num2; i++)
										{
											hashSet.Add(Guid.NewGuid().ToString());
										}
										aAR.Losses.Add(xmlNode3.Name, hashSet);
									}
									else
									{
										List<string> list = xmlNode3.InnerText.Split(new char[]
										{
											'_'
										}).ToList<string>();
										int count = list.Count;
										HashSet<string> hashSet2 = new HashSet<string>();
										int num3 = count - 1;
										for (int j = 0; j <= num3; j++)
										{
											hashSet2.Add(list[j]);
										}
										aAR.Losses.Add(xmlNode3.Name, hashSet2);
									}
								}
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
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					result = aAR;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101069", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new Side.AAR();
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x04003566 RID: 13670
			public Dictionary<int, int> Expenditures;

			// Token: 0x04003567 RID: 13671
			public Dictionary<string, HashSet<string>> Losses;
		}

		// Token: 0x02000B9B RID: 2971
		[Attribute0]
		public enum AwarenessLevel
		{
			// Token: 0x04003569 RID: 13673
			Blind = -1,
			// Token: 0x0400356A RID: 13674
			Normal,
			// Token: 0x0400356B RID: 13675
			AutoSideID,
			// Token: 0x0400356C RID: 13676
			AutoSideAndUnitID,
			// Token: 0x0400356D RID: 13677
			Omniscient
		}

		// Token: 0x02000B9C RID: 2972
		[CompilerGenerated]
		public sealed class ActualUnitChecker
		{
			// Token: 0x06006239 RID: 25145 RVA: 0x0002B483 File Offset: 0x00029683
			public ActualUnitChecker(Side.ActualUnitChecker ActualUnitChecker_)
			{
				if (ActualUnitChecker_ != null)
				{
					this.actualUnit = ActualUnitChecker_.actualUnit;
				}
			}

			// Token: 0x0600623A RID: 25146 RVA: 0x0002B49D File Offset: 0x0002969D
			internal bool IsActualUnitOf(Contact contact_)
			{
				return contact_.ActualUnit == this.actualUnit;
			}

			// Token: 0x0400356E RID: 13678
			public ActiveUnit actualUnit;
		}

		// Token: 0x02000B9D RID: 2973
		[CompilerGenerated]
		public sealed class ClassActiveUnit
		{
			// Token: 0x0600623B RID: 25147 RVA: 0x0002B4AD File Offset: 0x000296AD
			internal bool IsActualUnit(Contact contact_0)
			{
				return contact_0.ActualUnit == this.activeUnit_0;
			}

			// Token: 0x0400356F RID: 13679
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000B9E RID: 2974
		[CompilerGenerated]
		public sealed class Class192
		{
			// Token: 0x0600623D RID: 25149 RVA: 0x0002B4BD File Offset: 0x000296BD
			public Class192(Side.Class192 class192_0)
			{
				if (class192_0 != null)
				{
					this.WeaponGUID = class192_0.WeaponGUID;
				}
			}

			// Token: 0x0600623E RID: 25150 RVA: 0x0002B4D7 File Offset: 0x000296D7
			internal bool method_0(UnguidedWeapon unguidedWeapon_)
			{
				return Operators.CompareString(unguidedWeapon_.GetGuid(), this.WeaponGUID, false) == 0;
			}

			// Token: 0x04003570 RID: 13680
			public string WeaponGUID;

			// Token: 0x04003571 RID: 13681
			public Func<UnguidedWeapon, bool> func_0;
		}

		// Token: 0x02000B9F RID: 2975
		[CompilerGenerated]
		public sealed class Class193
		{
			// Token: 0x0600623F RID: 25151 RVA: 0x0002B4EE File Offset: 0x000296EE
			public Class193(Side.Class193 class193_0)
			{
				if (class193_0 != null)
				{
					this.string_0 = class193_0.string_0;
				}
			}

			// Token: 0x04003572 RID: 13682
			public string string_0;
		}

		// Token: 0x02000BA0 RID: 2976
		[CompilerGenerated]
		public sealed class Class194
		{
			// Token: 0x06006240 RID: 25152 RVA: 0x0002B508 File Offset: 0x00029708
			public Class194(Side.Class194 class194_0)
			{
				if (class194_0 != null)
				{
					this.class142_0 = class194_0.class142_0;
				}
			}

			// Token: 0x06006241 RID: 25153 RVA: 0x0002B522 File Offset: 0x00029722
			internal bool method_0(UnguidedWeapon unguidedWeapon_0)
			{
				return Operators.CompareString(unguidedWeapon_0.FiringParentName, this.class193_0.string_0, false) == 0 && this.class142_0.WeaponObjectIDArray.Contains(unguidedWeapon_0.GetGuid());
			}

			// Token: 0x04003573 RID: 13683
			public WeaponSalvo class142_0;

			// Token: 0x04003574 RID: 13684
			public Side.Class193 class193_0;
		}
	}
}
