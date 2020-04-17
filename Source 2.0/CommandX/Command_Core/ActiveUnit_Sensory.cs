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
using Command_Core.DAL;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial.Euclidean;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 0x0200097D RID: 2429
	public class ActiveUnit_Sensory
	{
		// Token: 0x06003C8A RID: 15498 RVA: 0x0012D25C File Offset: 0x0012B45C
		[CompilerGenerated]
		protected virtual ObservableDictionary<string, ActiveUnit_Sensory.ContactEntry> GetContactEntryDictionary()
		{
			return this.ContactEntryDictionary;
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x0012D274 File Offset: 0x0012B474
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		protected virtual void vmethod_1(ObservableDictionary<string, ActiveUnit_Sensory.ContactEntry> observableDictionary_2)
		{
			INotifyDictionaryChanged<string, ActiveUnit_Sensory.ContactEntry>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, ActiveUnit_Sensory.ContactEntry>.DictionaryChangedEventHandler(this.method_66);
			ObservableDictionary<string, ActiveUnit_Sensory.ContactEntry> contactEntryDictionary = this.ContactEntryDictionary;
			if (contactEntryDictionary != null)
			{
				contactEntryDictionary.DictionaryChanged -= value;
			}
			this.ContactEntryDictionary = observableDictionary_2;
			contactEntryDictionary = this.ContactEntryDictionary;
			if (contactEntryDictionary != null)
			{
				contactEntryDictionary.DictionaryChanged += value;
			}
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x0012D2C0 File Offset: 0x0012B4C0
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_Sensory.Delegate4 delegate4_1)
		{
			ActiveUnit_Sensory.Delegate4 @delegate = ActiveUnit_Sensory.delegate4_0;
			ActiveUnit_Sensory.Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_Sensory.Delegate4 value = (ActiveUnit_Sensory.Delegate4)Delegate.Combine(delegate2, delegate4_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_Sensory.Delegate4>(ref ActiveUnit_Sensory.delegate4_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x0012D2F8 File Offset: 0x0012B4F8
		public virtual void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Sensory");
				xmlWriter_0.WriteElementString("ObE", this.bObeysEMCON.ToString());
				if (this.GetContactEntryDictionary().Count > 0)
				{
					xmlWriter_0.WriteStartElement("ContactList_Local");
					foreach (ActiveUnit_Sensory.ContactEntry current in this.GetContactEntryDictionary().Values)
					{
						if (!Information.IsNothing(current.m_Contact) && !Information.IsNothing(current.m_Contact.ActualUnit))
						{
							current.Save(ref xmlWriter_0, this.ParentPlatform.GetSide(false));
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.ContactList_OffGrid.Count > 0)
				{
					xmlWriter_0.WriteStartElement("ContactList_OffGrid");
					List<Contact> list = this.ContactList_OffGrid.Values.ToList<Contact>();
					foreach (Contact current2 in list)
					{
						if (!Information.IsNothing(current2.ActualUnit))
						{
							Contact contact = current2;
							HashSet<string> hashSet = null;
							contact.Save(ref xmlWriter_0, ref hashSet);
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100234", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0012D4DC File Offset: 0x0012B6DC
		public static ActiveUnit_Sensory GetSensoryByXmlNode(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			ActiveUnit_Sensory result;
			try
			{
				ActiveUnit_Sensory activeUnit_Sensory = new ActiveUnit_Sensory();
				activeUnit_Sensory.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ObeysEMCON", false) != 0 && Operators.CompareString(name, "ObE", false) != 0)
						{
							if (Operators.CompareString(name, "ContactList", false) != 0 && Operators.CompareString(name, "ContactList_Local", false) != 0)
							{
								if (Operators.CompareString(name, "ContactList_OffGrid", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										Contact contact = Contact.Load(ref xmlNode2, ref dictionary_1);
										activeUnit_Sensory.ContactList_OffGrid.Add(contact.string_6, contact);
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
									string text = "";
									ActiveUnit_Sensory.ContactEntry value = ActiveUnit_Sensory.ContactEntry.Load(ref xmlNode3, ref dictionary_1, ref text);
									if (!Information.IsNothing(text) && !activeUnit_Sensory.GetContactEntryDictionary().ContainsKey(text))
									{
										activeUnit_Sensory.GetContactEntryDictionary().Add(text, value);
									}
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
						activeUnit_Sensory.bObeysEMCON = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = activeUnit_Sensory;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100235", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ActiveUnit_Sensory();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x0012D750 File Offset: 0x0012B950
		public List<Contact> GetContactList()
		{
			List<Contact> result;
			if (this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
			{
				result = this.ParentPlatform.GetSide(false).GetContactList();
			}
			else
			{
				result = this.ParentPlatform.GetSensory().GetContactList_OffGrid();
			}
			return result;
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x0001FD7B File Offset: 0x0001DF7B
		public virtual bool IsObeysEMCON()
		{
			return this.bObeysEMCON;
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x0001FD83 File Offset: 0x0001DF83
		public virtual void SetIsObeysEMCON(bool value)
		{
			this.bObeysEMCON = value;
			if (value)
			{
				this.ScheduleEMCONEvent(this.ParentPlatform.GetAllNoneMCMSensors());
			}
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x0012D79C File Offset: 0x0012B99C
		public bool HasOperatingTowedArraySonar()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
					for (int i = 0; i < allNoneMCMSensors.Length; i++)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor.IsTowedArraySonar())
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100236", "");
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

		// Token: 0x06003C93 RID: 15507 RVA: 0x0012D844 File Offset: 0x0012BA44
		private ActiveUnit_Sensory()
		{
			this.list_0 = new List<Contact>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<long, LoggedMessage>>();
			this.lazy_1 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.LazyContactDictionary = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_Sensory.ContactEntry>());
			this.ContactList_OffGrid = new Dictionary<string, Contact>();
			this.list_1 = new List<string>();
			this.JammerCarriersLazyDictionary = new Lazy<Dictionary<bool, List<ActiveUnit>>>();
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0001FDA3 File Offset: 0x0001DFA3
		internal void ContactEntryDictionaryClear()
		{
			this.GetContactEntryDictionary().Clear();
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0012D8C8 File Offset: 0x0012BAC8
		internal void ContactList_OffGridAdd()
		{
			foreach (Contact current in this.ParentPlatform.GetSide(false).GetContactList())
			{
				if (!Information.IsNothing(current.ActualUnit))
				{
					Contact contact = current.method_135();
					this.ContactList_OffGrid.Add(contact.ActualUnit.GetGuid(), contact);
				}
			}
		}

        // Token: 0x06003C96 RID: 15510 RVA: 0x0012D94C File Offset: 0x0012BB4C
        // public void method_4()
        public void RejoinedComNetwork()
		{
			this.ParentPlatform.LogMessage(this.ParentPlatform.Name + "重新加入通信网络.", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
			foreach (KeyValuePair<string, Contact> current in this.ContactList_OffGrid)
			{
				if (!Information.IsNothing(current.Value.ActualUnit))
				{
					if (!Information.IsNothing(current.Value.ActualUnit.GetSide(false)))
					{
						Side side = current.Value.ActualUnit.GetSide(false);
						if (side == this.ParentPlatform.GetSide(false))
						{
							this.ParentPlatform.GetAI().DropTargeting(current.Value, true);
						}
						else if (side.GetPostureStance(this.ParentPlatform.GetSide(false)) == Misc.PostureStance.Friendly)
						{
							this.ParentPlatform.GetAI().DropTargeting(current.Value, true);
						}
						else if (this.ParentPlatform.GetSide(false).GetContactObservableDictionary().ContainsKey(current.Key))
						{
							this.ParentPlatform.GetSide(false).ContactUpdateToContact(this.ParentPlatform.GetSide(false).GetContactObservableDictionary()[current.Key], current.Value, this.ParentPlatform, this.ParentPlatform.m_Scenario, true);
						}
						else
						{
							this.ParentPlatform.LogMessage("NEW DELAYED CONTACT: " + current.Value.Name, LoggedMessage.MessageType.ContactChange, 0, false, new GeoPoint(current.Value.GetLongitude(null), current.Value.GetLatitude(null)));
							this.ParentPlatform.GetSide(false).AddToContactList_OnGrid(current.Value);
							current.Value.method_123(this.ParentPlatform.GetSide(false), false);
						}
					}
					else
					{
						this.ParentPlatform.GetAI().DropTargeting(current.Value, true);
					}
				}
				else
				{
					this.ParentPlatform.GetAI().DropTargeting(current.Value, true);
				}
			}
			this.ContactList_OffGrid.Clear();
			List<Contact> list = new List<Contact>();
			foreach (Contact current2 in this.ParentPlatform.GetSide(false).GetContactList())
			{
				if (!Information.IsNothing(current2.ActualUnit) && current2.ActualUnit == this.ParentPlatform)
				{
					list.Add(current2);
				}
			}
			foreach (Contact current3 in list)
			{
				this.ParentPlatform.GetSide(false).Lazy3DictionaryTryAdd(current3, ref this.ParentPlatform.m_Scenario, false);
			}
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0012DCC8 File Offset: 0x0012BEC8
		private List<Contact> GetContactList_OffGrid()
		{
			return this.ContactList_OffGrid.Values.ToList<Contact>();
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x0012DCE8 File Offset: 0x0012BEE8
		public virtual void ScheduleEMCONEvent(Sensor[] SensorArray_)
		{
			try
			{
				if (!this.ParentPlatform.IsGroup)
				{
					if (this.ParentPlatform.IsSatellite())
					{
						for (int i = 0; i < SensorArray_.Length; i++)
						{
							Sensor sensor = SensorArray_[i];
							if (sensor.IsActiveCapable())
							{
								sensor.TurnOn();
							}
						}
					}
					else
					{
						if (this.ParentPlatform.IsWeapon && ((Weapon)this.ParentPlatform).IsDecoy())
						{
							for (int j = 0; j < SensorArray_.Length; j++)
							{
								Sensor sensor2 = SensorArray_[j];
								if (sensor2.IsJammer() && !sensor2.IsEmmitting())
								{
									sensor2.TurnOn();
								}
							}
						}
						if (this.IsObeysEMCON())
						{
							Doctrine.EMCON_Settings eMCON_Settings = this.ParentPlatform.m_Doctrine.GetEMCON_Settings(this.ParentPlatform.m_Scenario);
							bool bool_ = false;
							if (eMCON_Settings.method_0() && !Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
							{
								if (this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
								{
									if (((Patrol)this.ParentPlatform.GetAssignedMission(false)).AEOIPA)
									{
										Patrol patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
										if (this.ParentPlatform.IsAircraft)
										{
											if (!this.ParentPlatform.GetNavigator().IsOnStation(ref patrol.PatrolAreaVertices, ref patrol.list_12, ref patrol.list_8, 5, true, false) && !this.ParentPlatform.GetNavigator().IsOnStation(ref patrol.ProsecutionAreaVertices, ref patrol.list_20, ref patrol.list_18, 5, true, true))
											{
												bool_ = true;
											}
										}
										else if (!this.ParentPlatform.GetNavigator().IsOnStation(ref patrol.PatrolAreaVertices, ref patrol.list_11, ref patrol.list_7, 2, true, false) && !this.ParentPlatform.GetNavigator().IsOnStation(ref patrol.ProsecutionAreaVertices, ref patrol.list_19, ref patrol.list_17, 2, true, true))
										{
											bool_ = true;
										}
									}
								}
								else if (this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support && ((SupportMission)this.ParentPlatform.GetAssignedMission(false)).AEOOS && this.ParentPlatform.GetNavigator().method_11())
								{
									bool_ = true;
								}
							}
							int num = SensorArray_.Count<Sensor>() - 1;
							Sensor sensor_ = null;
							for (int num2 = 0; num2 <= num; num2++)
							{
								try
								{
									sensor_ = SensorArray_[num2];
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200429", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
								this.SensorTurnOnOrOff(sensor_, eMCON_Settings, bool_);
							}
							if (this.ParentPlatform.IsMineSweeper())
							{
								IEnumerable<Sensor> mineCounterMeasures = this.ParentPlatform.GetMineCounterMeasures();
								if (mineCounterMeasures.Count<Sensor>() > 0)
								{
									int num3 = mineCounterMeasures.Count<Sensor>() - 1;
									for (int num4 = 0; num4 <= num3; num4++)
									{
										try
										{
											sensor_ = mineCounterMeasures.ElementAtOrDefault(num4);
										}
										catch (Exception ex3)
										{
											ProjectData.SetProjectError(ex3);
											Exception ex4 = ex3;
											ex4.Data.Add("Error at 200430", ex4.Message);
											GameGeneral.LogException(ref ex4);
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
											ProjectData.ClearProjectError();
										}
										this.SensorTurnOnOrOff(sensor_, eMCON_Settings, bool_);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100237", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

        // Token: 0x06003C99 RID: 15513 RVA: 0x0012E0F8 File Offset: 0x0012C2F8
        //private void method_6(Sensor sensor_, Doctrine.EMCON_Settings EMCON_Settings_, bool bool_1)

        private void SensorTurnOnOrOff(Sensor sensor_, Doctrine.EMCON_Settings EMCON_Settings_, bool bool_1)
		{
			if (!Information.IsNothing(sensor_))
			{
				try
				{
					if (sensor_.NonSearchAndTrackSensorOtherThanMCMAndMAD())
					{
						if (sensor_.SemiActiveGuidedWeaponList.Count == 0)
						{
							sensor_.TurnOff();
						}
					}
					else if (sensor_.GetTargetsTrackedForFireControl().Count <= 0)
					{
						bool flag = false;
						if (sensor_.sensorType == Sensor.SensorType.Radar)
						{
							if (EMCON_Settings_.GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_1 && !bool_1)
							{
								flag = true;
							}
							else if (sensor_.GetTargetsTrackedForFireControl().Count == 0)
							{
								flag = false;
							}
						}
						if (sensor_.IsJammer())
						{
							flag = (EMCON_Settings_.GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_1 && !bool_1);
						}
						bool flag2;
						if (!(flag2 = this.ParentPlatform.IsMineSweeper()) && sensor_.IsSonar() && sensor_.IsActiveCapable())
						{
							bool arg_110_0;
							if (sensor_.sensorType == Sensor.SensorType.DippingSonar_ActiveOnly && this.ParentPlatform.IsAircraft)
							{
								if (((Aircraft)this.ParentPlatform).GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
								{
									arg_110_0 = true;
									goto IL_110;
								}
							}
							arg_110_0 = (EMCON_Settings_.GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_1 && !bool_1);
							IL_110:
							flag = arg_110_0;
						}
						if (flag2 && !Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)) && this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
						{
							MineClearingMission mineClearingMission = (MineClearingMission)this.ParentPlatform.GetAssignedMission(false);
							if (this.ParentPlatform.GetNavigator().IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_12, ref mineClearingMission.list_8, 5, false, false))
							{
								if (this.ParentPlatform.IsAircraft && (this.ParentPlatform.GetCurrentAltitude_ASL(false) > 76.5048f || this.ParentPlatform.GetCurrentSpeed() > 30f))
								{
									flag = false;
								}
								else if ((sensor_.IsMineCounterMeasure() || sensor_.IsMineObstacleSearchCapable()) && sensor_.IsActiveCapable())
								{
									flag = true;
								}
							}
						}
						if (flag)
						{
							sensor_.TurnOn();
						}
						else if (sensor_.IsEmmitting())
						{
							sensor_.TurnOff();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200431", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

        // Token: 0x06003C9A RID: 15514 RVA: 0x0012E364 File Offset: 0x0012C564
        //public bool method_7(Sensor[] sensor_0)
        public bool HasOperatingSensor(Sensor[] sensors)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (Information.IsNothing(sensors))
					{
						sensors = this.ParentPlatform.GetAllNoneMCMSensors();
					}
					if (sensors.Length == 0)
					{
						flag = false;
					}
					else
					{
						Sensor[] array = sensors;
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].IsOperating())
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
					ex2.Data.Add("Error at 100238", "");
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

        // Token: 0x06003C9B RID: 15515 RVA: 0x0012E418 File Offset: 0x0012C618
        //public bool method_8()
        public bool IsSensorJamCapable()
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.ParentPlatform.IsSatellite())
				{
					flag = false;
				}
				else if (this.ParentPlatform.IsSubmarine && this.ParentPlatform.GetCurrentAltitude_ASL(false) < -20f)
				{
					flag = false;
				}
				else
				{
					new HashSet<ActiveUnit>();
					Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
					if (!Information.IsNothing(allNoneMCMSensors))
					{
						bool flag2 = false;
						int num = allNoneMCMSensors.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorType == Sensor.SensorType.Radar && sensor.IsEmmitting())
							{
								Side[] sides = this.ParentPlatform.m_Scenario.GetSides();
								for (int j = 0; j < sides.Length; j = checked(j + 1))
								{
									Side side = sides[j];
									if (side != this.ParentPlatform.GetSide(false) && !this.ParentPlatform.GetSide(false).IsFriendlyToSide(side))
									{
										for (int k = side.GetJammerPlatforms(false).Count - 1; k >= 0; k += -1)
										{
											ActiveUnit jammerCarrier_;
											try
											{
												jammerCarrier_ = side.GetJammerPlatforms(false)[k];
											}
											catch (Exception ex)
											{
												ProjectData.SetProjectError(ex);
												Exception ex2 = ex;
												ex2.Data.Add("Error at 200432", ex2.Message);
												GameGeneral.LogException(ref ex2);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												ProjectData.ClearProjectError();
												k += -1;
												continue;
											}
											if (this.IsJamCapable(jammerCarrier_))
											{
												flag = true;
												result = true;
												return result;
											}
										}
									}
								}
								flag = false;
								result = false;
								return result;
							}
						}
						if (!flag2)
						{
							flag = false;
							result = false;
							return result;
						}
						Side[] sides2 = this.ParentPlatform.m_Scenario.GetSides();
						for (int j = 0; j < sides2.Length; j = checked(j + 1))
						{
							Side side = sides2[j];
							if (side != this.ParentPlatform.GetSide(false) && !this.ParentPlatform.GetSide(false).IsFriendlyToSide(side))
							{
								for (int k = side.GetJammerPlatforms(false).Count - 1; k >= 0; k += -1)
								{
									ActiveUnit jammerCarrier_;
									try
									{
										jammerCarrier_ = side.GetJammerPlatforms(false)[k];
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										ex2.Data.Add("Error at 200432", ex2.Message);
										GameGeneral.LogException(ref ex2);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										ProjectData.ClearProjectError();
										k += -1;
										continue;
									}
									if (this.IsJamCapable(jammerCarrier_))
									{
										flag = true;
										result = true;
										return result;
									}
								}
							}
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
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100239", "");
				GameGeneral.LogException(ref ex4);
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

		// Token: 0x06003C9C RID: 15516 RVA: 0x0012E764 File Offset: 0x0012C964
		public List<ActiveUnit> GetAffectingJammers(bool bool_1)
		{
			List<ActiveUnit> list = null;
			List<ActiveUnit> result;
			try
			{
				if (this.ParentPlatform.IsWeapon && ((Weapon)this.ParentPlatform).weaponCode.HomeOnJam)
				{
					list = new List<ActiveUnit>();
				}
				else if (!this.JammerCarriersLazyDictionary.Value.ContainsKey(bool_1))
				{
					HashSet<ActiveUnit> hashSet = new HashSet<ActiveUnit>();
					List<ActiveUnit> list2 = new List<ActiveUnit>();
					if (bool_1)
					{
						Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
						bool flag = false;
						int num = allNoneMCMSensors.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorType == Sensor.SensorType.Radar && sensor.IsEmmitting())
							{
								goto IL_11C;
							}
						}
						if (!flag)
						{
							list2 = hashSet.ToList<ActiveUnit>();
							try
							{
								this.JammerCarriersLazyDictionary.Value.Add(bool_1, list2);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 200433", ex2.Message);
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
							list = list2;
							result = list;
							return result;
						}
					}
					IL_11C:
					Side[] sides = this.ParentPlatform.m_Scenario.GetSides();
					for (int j = 0; j < sides.Length; j = checked(j + 1))
					{
						Side side = sides[j];
						if (!Information.IsNothing(side) && !Information.IsNothing(this.ParentPlatform.GetSide(false)) && side != this.ParentPlatform.GetSide(false) && !this.ParentPlatform.GetSide(false).IsFriendlyToSide(side))
						{
							for (int k = side.GetJammerPlatforms(false).Count - 1; k >= 0; k += -1)
							{
								ActiveUnit activeUnit = side.GetJammerPlatforms(false)[k];
								if (this.IsJamCapable(activeUnit))
								{
									hashSet.Add(activeUnit);
								}
							}
						}
					}
					list2 = hashSet.ToList<ActiveUnit>();
					try
					{
						this.JammerCarriersLazyDictionary.Value.Add(bool_1, list2);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 200434", ex4.Message);
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					list = list2;
				}
				else
				{
					list = this.JammerCarriersLazyDictionary.Value[bool_1];
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100240", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list = new List<ActiveUnit>();
				ProjectData.ClearProjectError();
			}
			result = list;
			return result;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0012EA5C File Offset: 0x0012CC5C
		private bool IsJamCapable(ActiveUnit JammerCarrier_)
		{
            bool flag = false;
            if (Information.IsNothing(JammerCarrier_))
            {
                return false;
            }
            try
            {
                bool flag2 = false;
                Sensor[] allNoneMCMSensors = JammerCarrier_.GetAllNoneMCMSensors();
                bool flag3 = false;
                for (int i = allNoneMCMSensors.Length - 1; i >= 0; i += -1)
                {
                    Sensor sensor = allNoneMCMSensors[i];
                    if (sensor.IsJammer())
                    {
                        float? nullable;
                        if (sensor.IsOTH())
                        {
                            flag3 = true;
                        }
                        if (sensor.IsEmmitting() && sensor.IsTargetInCoverageArc(this.ParentPlatform, (float?)(nullable = null)))
                        {
                            for (int j = this.ParentPlatform.GetAllNoneMCMSensors().Length - 1; j >= 0; j += -1)
                            {
                                Sensor targetSensor = this.ParentPlatform.GetAllNoneMCMSensors()[j];
                                nullable = null;
                                if (targetSensor.IsTargetInCoverageArc(JammerCarrier_, nullable) && sensor.IsJammerTo(targetSensor))
                                {
                                    goto Label_00E4;
                                }
                            }
                            if (flag2)
                            {
                                break;
                            }
                        }
                    }
                }
                goto Label_00E6;
            Label_00E4:
                flag2 = true;
            Label_00E6:
                if (!flag2)
                {
                    return false;
                }
                if (!(flag3 || this.ParentPlatform.IsLOS_Exists_Radar(JammerCarrier_, ref this.ParentPlatform.m_Scenario, false)))
                {
                    return false;
                }
                flag = true;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Exception exception2 = exception;
                exception2.Data.Add("Error at 200352", exception2.Message);
                GameGeneral.LogException(ref exception2);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;

        }

        // Token: 0x06003C9E RID: 15518 RVA: 0x0012EBE0 File Offset: 0x0012CDE0
        public ActiveUnit_Sensory(ref ActiveUnit activeUnit_1)
		{
			this.list_0 = new List<Contact>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<long, LoggedMessage>>();
			this.lazy_1 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.LazyContactDictionary = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_Sensory.ContactEntry>());
			this.ContactList_OffGrid = new Dictionary<string, Contact>();
			this.list_1 = new List<string>();
			this.JammerCarriersLazyDictionary = new Lazy<Dictionary<bool, List<ActiveUnit>>>();
			this.ParentPlatform = activeUnit_1;
			this.bObeysEMCON = true;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0012EC70 File Offset: 0x0012CE70
		public bool HasEmittingJammer()
		{
			Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
			checked
			{
				bool result;
				for (int i = 0; i < allNoneMCMSensors.Length; i++)
				{
					Sensor sensor = allNoneMCMSensors[i];
					if (sensor.IsJammer() && sensor.IsEmmitting())
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x0012ECBC File Offset: 0x0012CEBC
		private Sensor[] GetSearchingAndTrackingSensors(Sensor[] sensors)
		{
			Sensor[] result;
			if (sensors.Length == 0)
			{
				result = new Sensor[0];
			}
			else
			{
				List<Sensor> list = new List<Sensor>(sensors.Length);
				int count;
				checked
				{
					for (int i = 0; i < sensors.Length; i++)
					{
						Sensor sensor = sensors[i];
                        //ZSP ESM
                        if (sensor.sensorType == Sensor.SensorType.ESM && this.IsSearchingOrTracking(sensor))
                        {
                            list.Add(sensor);
                        }
                        if (sensor.IsSearchAndTrackSensor() && this.IsSearchingOrTracking(sensor))
						{
							list.Add(sensor);
						}
					}
					count = list.Count;
				}
				if (count == 0)
				{
					result = new Sensor[0];
				}
				else
				{
					Sensor[] array = new Sensor[count - 1 + 1];
					int num = count - 1;
					for (int j = 0; j <= num; j++)
					{
						array[j] = list[j];
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x0012ED74 File Offset: 0x0012CF74
		private Sensor[] GetNonSearchAndTrackSensorsWithTargetsTracked(Sensor[] sensors)
		{
			return sensors.Where(ActiveUnit_Sensory.SensorFunc1).ToArray<Sensor>();
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
		private bool IsSearchingOrTracking(Sensor sensor_)
		{
			return sensor_.IsOperating() && (!sensor_.IsActiveModeOnly() || sensor_.IsEmmitting()) && sensor_.IsScanningOrTrackingThisPulse();
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x0001FDD3 File Offset: 0x0001DFD3
		private bool IsSensorAtEndOfDetectionCycle(Sensor sensor_)
		{
			return sensor_.IsEndOfDetectionCycle();
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x0001FDDB File Offset: 0x0001DFDB
		public virtual void UpdateContactState(ref ActiveUnit detectedUnit, ref Side side_)
		{
			this.UpdateContactInfo(detectedUnit, side_);
		}

        public virtual void ScheduleDetectionInteraction(Sensor[] sensors, ActiveUnit[] activeUnits, float elapsedTime)
        {
            checked
            {
                if (!this.ParentPlatform.IsGroup && !Information.IsNothing(this.ParentPlatform))
                {
                    try
                    {
                        if (this.ParentPlatform.GetSide(false).GetAwarenessLevel() != Side.AwarenessLevel.Blind && (this.ParentPlatform.GetAllNoneMCMSensors().Length != 0 || this.ParentPlatform.m_Mounts.Length <= 0))
                        {
                            if (this.ParentPlatform.HasBeenTargeted(this.ParentPlatform.m_Scenario))
                            {
                                Sensor[] noneMCMSensors = this.ParentPlatform.GetNoneMCMSensors();
                                for (int i = 0; i < noneMCMSensors.Length; i++)
                                {
                                    Sensor sensor = noneMCMSensors[i];
                                    if (sensor.sensorType == Sensor.SensorType.ESM || sensor.sensorType == Sensor.SensorType.Infrared || sensor.sensorType == Sensor.SensorType.Visual || sensor.sensorType == Sensor.SensorType.PingIntercept)
                                    {
                                        sensor.NextScan = 0;
                                        sensor.OODADetectionCycle = 0;
                                    }
                                    if (sensor.sensorType == Sensor.SensorType.Radar)
                                    {
                                        sensor.OODADetectionCycle = 0;
                                    }
                                }
                            }
                            if (this.HasOperatingSensor(sensors))
                            {
                                Sensor[] searchingAndTrackingSensors = this.GetSearchingAndTrackingSensors(sensors);
                                Sensor[] nonSearchAndTrackSensorsWithTargetsTracked = this.GetNonSearchAndTrackSensorsWithTargetsTracked(sensors);
                                if (searchingAndTrackingSensors.Length != 0 || nonSearchAndTrackSensorsWithTargetsTracked.Length != 0)
                                {
                                    Sensor[] array = searchingAndTrackingSensors.Where(new Func<Sensor, bool>(this.IsSensorOtherThanHeightFinderAtEndOfDetectionCycle)).ToArray<Sensor>();
                                    Sensor[] source = searchingAndTrackingSensors.Where(new Func<Sensor, bool>(this.IsSensorOtherThanHeightFinderNotAtEndOfDetectionCycle)).ToArray<Sensor>();
                                    Sensor[] source2 = searchingAndTrackingSensors.Where(ActiveUnit_Sensory.HeightFinderRadarFilter).ToArray<Sensor>();
                                    List<ActiveUnit> list = new List<ActiveUnit>();
                                    List<ActiveUnit> list2 = new List<ActiveUnit>();
                                    List<ActiveUnit> list3 = new List<ActiveUnit>();
                                    if (array.Length > 0)
                                    {
                                        if (this.ParentPlatform.IsWeapon)
                                        {
                                            Weapon weapon = (Weapon)this.ParentPlatform;
                                            if (weapon.method_211() && !weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
                                            {
                                                list = this.ParentPlatform.m_Scenario.GetActiveUnitList().ToList<ActiveUnit>();
                                            }
                                            else
                                            {
                                                list = this.ParentPlatform.GetSide(false).GetActiveUnitList0();
                                            }
                                        }
                                        else if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
                                        {
                                            list = this.ParentPlatform.m_Scenario.GetActiveUnitList().ToList<ActiveUnit>();
                                        }
                                        else
                                        {
                                            list = this.ParentPlatform.GetSide(false).GetActiveUnitList0();
                                        }
                                    }
                                    for (int j = 0; j < activeUnits.Length; j++)
                                    {
                                        ActiveUnit activeUnit = activeUnits[j];
                                        if (activeUnit != this.ParentPlatform && (!activeUnit.IsWeapon || ((Weapon)activeUnit).GetFiringParent() != this.ParentPlatform) && !list.Contains(activeUnit))
                                        {
                                            list.Add(activeUnit);
                                        }
                                    }
                                    if (this.ParentPlatform.IsWeapon)
                                    {
                                        ActiveUnit dataLinkParent = ((Weapon)this.ParentPlatform).GetDataLinkParent();
                                        if (!Information.IsNothing(dataLinkParent) && list.Contains(dataLinkParent))
                                        {
                                            list.Remove(dataLinkParent);
                                        }
                                    }
                                    if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
                                    {
                                        foreach (Weapon current in this.ParentPlatform.m_Scenario.GetGuidedWeaponsInAir())
                                        {
                                            if (current.GetFiringParent() == this.ParentPlatform && list.Contains(current))
                                            {
                                                list.Remove(current);
                                            }
                                        }
                                    }
                                    if (source.Count<Sensor>() > 0)
                                    {
                                        foreach (Contact current2 in this.ParentPlatform.GetSensory().method_63().Values)
                                        {
                                            if (!Information.IsNothing(current2.ActualUnit))
                                            {
                                                list2.Add(current2.ActualUnit);
                                            }
                                        }
                                    }
                                    if (source2.Count<Sensor>() > 0)
                                    {
                                        foreach (Contact current3 in this.ParentPlatform.GetSide(false).GetContactList())
                                        {
                                            if (!Information.IsNothing(current3.ActualUnit))
                                            {
                                                list3.Add(current3.ActualUnit);
                                            }
                                        }
                                    }
                                    List<ActiveUnit_Sensory.TargetUnitInDetectRange> list4 = new List<ActiveUnit_Sensory.TargetUnitInDetectRange>();
                                    List<ActiveUnit_Sensory.TargetUnitInDetectRange> list5 = new List<ActiveUnit_Sensory.TargetUnitInDetectRange>();
                                    List<ActiveUnit_Sensory.TargetUnitInDetectRange> list6 = new List<ActiveUnit_Sensory.TargetUnitInDetectRange>();
                                    new List<ActiveUnit_Sensory.TargetUnitInDetectRange>();
                                    if (array.Length > 0 && list.Count > 0)
                                    {
                                        list4 = this.GetTargetUnitsInDetectRange(ref array, list);
                                    }
                                    if (source.Count<Sensor>() > 0 && list2.Count > 0)
                                    {
                                        list5 = this.GetTargetUnitsInDetectRange(ref source, list2);
                                        if (!Information.IsNothing(list5))
                                        {
                                            list4.AddRange(list5);
                                        }
                                    }
                                    if (source2.Count<Sensor>() > 0 && list3.Count > 0)
                                    {
                                        list6 = this.GetTargetUnitsInDetectRange(ref source2, list3);
                                        if (!Information.IsNothing(list6))
                                        {
                                            list4.AddRange(list6);
                                        }
                                    }
                                    if (nonSearchAndTrackSensorsWithTargetsTracked.Count<Sensor>() > 0)
                                    {
                                        Sensor[] array2 = nonSearchAndTrackSensorsWithTargetsTracked;
                                        for (int k = 0; k < array2.Length; k++)
                                        {
                                            Sensor sensor2 = array2[k];
                                            foreach (Contact current4 in sensor2.GetTargetsTrackedForFireControl())
                                            {
                                                if (!Information.IsNothing(current4.ActualUnit))
                                                {
                                                    Sensor[] array3 = new Sensor[]
                                                    {
                                                        sensor2
                                                    };
                                                    ActiveUnit_Sensory.TargetUnitInDetectRange targetUnitInDetectRange = new ActiveUnit_Sensory.TargetUnitInDetectRange(ref current4.ActualUnit, ref array3);
                                                    if (!Information.IsNothing(targetUnitInDetectRange))
                                                    {
                                                        list4.Add(targetUnitInDetectRange);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (list4.Count > 0)
                                    {
                                        List<ActiveUnit> list7 = null;
                                        Sensor[] array4 = searchingAndTrackingSensors;
                                        for (int l = 0; l < array4.Length; l++)
                                        {
                                            if (array4[l].sensorType == Sensor.SensorType.Radar)
                                            {
                                                if (Information.IsNothing(list7))
                                                {
                                                    list7 = this.GetAffectingJammers(true);
                                                }
                                            IL_5E9:
                                                Sensor[] array5X = nonSearchAndTrackSensorsWithTargetsTracked;
                                                for (int m = 0; m < array5X.Length; m++)
                                                {
                                                    if (array5X[m].sensorType == Sensor.SensorType.Radar)
                                                    {
                                                        if (Information.IsNothing(list7))
                                                        {
                                                            list7 = this.GetAffectingJammers(true);
                                                        }
                                                        this.concurrentBag_0 = new ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>>();
                                                        this.DetectedMinesBag = new ConcurrentBag<string>();
                                                        foreach (ActiveUnit_Sensory.TargetUnitInDetectRange current5 in list4)
                                                        {
                                                            try
                                                            {
                                                                this.DetectTargetsInRange(current5, list7);
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                ProjectData.SetProjectError(ex);
                                                                Exception ex2 = ex;
                                                                ex2.Data.Add("Error at 101168", "");
                                                                GameGeneral.LogException(ref ex2);
                                                                if (Debugger.IsAttached)
                                                                {
                                                                    Debugger.Break();
                                                                }
                                                                ProjectData.ClearProjectError();
                                                            }
                                                        }
                                                        goto IL_6BE;
                                                    }
                                                }
                                                //ZSP goto IL_62F;
                                                this.concurrentBag_0 = new ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>>();
                                                this.DetectedMinesBag = new ConcurrentBag<string>();
                                                foreach (ActiveUnit_Sensory.TargetUnitInDetectRange current5 in list4)
                                                {
                                                    try
                                                    {
                                                        this.DetectTargetsInRange(current5, list7);
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        ProjectData.SetProjectError(ex);
                                                        Exception ex2 = ex;
                                                        ex2.Data.Add("Error at 101168", "");
                                                        GameGeneral.LogException(ref ex2);
                                                        if (Debugger.IsAttached)
                                                        {
                                                            Debugger.Break();
                                                        }
                                                        ProjectData.ClearProjectError();
                                                    }
                                                }
                                                goto IL_6BE;
                                            }
                                        }
                                        //ZSP goto IL_5E9;
                                        Sensor[] array5 = nonSearchAndTrackSensorsWithTargetsTracked;
                                                for (int m = 0; m < array5.Length; m++)
                                                {
                                                    if (array5[m].sensorType == Sensor.SensorType.Radar)
                                                    {
                                                        if (Information.IsNothing(list7))
                                                        {
                                                            list7 = this.GetAffectingJammers(true);
                                                        }
                                                        this.concurrentBag_0 = new ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>>();
                                                        this.DetectedMinesBag = new ConcurrentBag<string>();
                                                        foreach (ActiveUnit_Sensory.TargetUnitInDetectRange current5 in list4)
                                                        {
                                                            try
                                                            {
                                                                this.DetectTargetsInRange(current5, list7);
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                ProjectData.SetProjectError(ex);
                                                                Exception ex2 = ex;
                                                                ex2.Data.Add("Error at 101168", "");
                                                                GameGeneral.LogException(ref ex2);
                                                                if (Debugger.IsAttached)
                                                                {
                                                                    Debugger.Break();
                                                                }
                                                                ProjectData.ClearProjectError();
                                                            }
                                                        }
                                                        goto IL_6BE;
                                                    }
                                                }
                                                //ZSP goto IL_62F;
                                                this.concurrentBag_0 = new ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>>();
                                                this.DetectedMinesBag = new ConcurrentBag<string>();
                                                foreach (ActiveUnit_Sensory.TargetUnitInDetectRange current5 in list4)
                                                {
                                                    try
                                                    {
                                                        this.DetectTargetsInRange(current5, list7);
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        ProjectData.SetProjectError(ex);
                                                        Exception ex2 = ex;
                                                        ex2.Data.Add("Error at 101168", "");
                                                        GameGeneral.LogException(ref ex2);
                                                        if (Debugger.IsAttached)
                                                        {
                                                            Debugger.Break();
                                                        }
                                                        ProjectData.ClearProjectError();
                                                    }
                                                }
                                                goto IL_6BE;
                                    }
                                IL_6BE:
                                    if (array.Length > 0)
                                    {
                                        this.SearchMineObstacles(array);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex3)
                    {
                        ProjectData.SetProjectError(ex3);
                        Exception ex4 = ex3;
                        ex4.Data.Add("Error at 100242", "");
                        GameGeneral.LogException(ref ex4);
                        if (Debugger.IsAttached)
                        {
                            Debugger.Break();
                        }
                        ProjectData.ClearProjectError();
                    }
                }
            }
        }

        // Token: 0x06003CA5 RID: 15525 RVA: 0x0012ED94 File Offset: 0x0012CF94
        public virtual void ScheduleDetectionInteraction_BAK(Sensor[] sensors, ActiveUnit[] activeUnits, float elapsedTime)
		{
            if (!this.ParentPlatform.IsGroup && !Information.IsNothing(this.ParentPlatform))
            {
                try
                {
                    if ((this.ParentPlatform.GetSide(false).GetAwarenessLevel() == Side.AwarenessLevel.Blind) || ((this.ParentPlatform.GetAllNoneMCMSensors().Length == 0) && (this.ParentPlatform.m_Mounts.Length > 0)))
                    {
                        return;
                    }
                    if (this.ParentPlatform.HasBeenTargeted(this.ParentPlatform.m_Scenario))
                    {
                        foreach (Sensor sensor in this.ParentPlatform.GetNoneMCMSensors())
                        {
                            if ((((sensor.sensorType == Sensor.SensorType.ESM) || (sensor.sensorType == Sensor.SensorType.Infrared)) || (sensor.sensorType == Sensor.SensorType.Visual)) || (sensor.sensorType == Sensor.SensorType.PingIntercept))
                            {
                                sensor.NextScan = 0;
                                sensor.OODADetectionCycle = 0;
                            }
                            if (sensor.sensorType == Sensor.SensorType.Radar)
                            {
                                sensor.OODADetectionCycle = 0;
                            }
                        }
                    }
                    if (!this.HasOperatingSensor(sensors))
                    {
                        return;
                    }
                    Sensor[] searchingAndTrackingSensors = this.GetSearchingAndTrackingSensors(sensors);
                    Sensor[] nonSearchAndTrackSensorsWithTargetsTracked = this.GetNonSearchAndTrackSensorsWithTargetsTracked(sensors);
                    if ((searchingAndTrackingSensors.Length == 0) && (nonSearchAndTrackSensorsWithTargetsTracked.Length == 0))
                    {
                        return;
                    }
                    Sensor[] sensorArray = searchingAndTrackingSensors.Where<Sensor>(new Func<Sensor, bool>(this.IsSensorOtherThanHeightFinderAtEndOfDetectionCycle)).ToArray<Sensor>();
                    Sensor[] source = searchingAndTrackingSensors.Where<Sensor>(new Func<Sensor, bool>(this.IsSensorOtherThanHeightFinderNotAtEndOfDetectionCycle)).ToArray<Sensor>();
                    Sensor[] sensorArray6 = searchingAndTrackingSensors.Where<Sensor>(HeightFinderRadarFilter).ToArray<Sensor>();
                    List<ActiveUnit> list = new List<ActiveUnit>();
                    List<ActiveUnit> list2 = new List<ActiveUnit>();
                    List<ActiveUnit> list3 = new List<ActiveUnit>();
                    if (sensorArray.Length > 0)
                    {
                        if (this.ParentPlatform.IsWeapon)
                        {
                            Weapon parentPlatform = (Weapon)this.ParentPlatform;
                            if (!(!parentPlatform.method_211() || parentPlatform.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon()))
                            {
                                list = this.ParentPlatform.m_Scenario.GetActiveUnitList().ToList<ActiveUnit>();
                            }
                            else
                            {
                                list = this.ParentPlatform.GetSide(false).GetActiveUnitList0();
                            }
                        }
                        else if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
                        {
                            list = this.ParentPlatform.m_Scenario.GetActiveUnitList().ToList<ActiveUnit>();
                        }
                        else
                        {
                            list = this.ParentPlatform.GetSide(false).GetActiveUnitList0();
                        }
                    }
                    for (int i = 0; i < activeUnits.Length; i++)
                    {
                        ActiveUnit item = activeUnits[i];
                        if (!(((item == this.ParentPlatform) || (item.IsWeapon && (((Weapon)item).GetFiringParent() == this.ParentPlatform))) || list.Contains(item)))
                        {
                            list.Add(item);
                        }
                    }
                    if (this.ParentPlatform.IsWeapon)
                    {
                        ActiveUnit dataLinkParent = ((Weapon)this.ParentPlatform).GetDataLinkParent();
                        if (!(Information.IsNothing(dataLinkParent) || !list.Contains(dataLinkParent)))
                        {
                            list.Remove(dataLinkParent);
                        }
                    }
                    if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
                    {
                        foreach (Weapon weapon2 in this.ParentPlatform.m_Scenario.GetGuidedWeaponsInAir())
                        {
                            if ((weapon2.GetFiringParent() == this.ParentPlatform) && list.Contains(weapon2))
                            {
                                list.Remove(weapon2);
                            }
                        }
                    }
                    if (source.Count<Sensor>() > 0)
                    {
                        foreach (Contact contact in this.ParentPlatform.GetSensory().method_63().Values)
                        {
                            if (!Information.IsNothing(contact.ActualUnit))
                            {
                                list2.Add(contact.ActualUnit);
                            }
                        }
                    }
                    if (sensorArray6.Count<Sensor>() > 0)
                    {
                        foreach (Contact contact2 in this.ParentPlatform.GetSide(false).GetContactList())
                        {
                            if (!Information.IsNothing(contact2.ActualUnit))
                            {
                                list3.Add(contact2.ActualUnit);
                            }
                        }
                    }
                    List<TargetUnitInDetectRange> targetUnitsInDetectRange = new List<TargetUnitInDetectRange>();
                    List<TargetUnitInDetectRange> expression = new List<TargetUnitInDetectRange>();
                    List<TargetUnitInDetectRange> list6 = new List<TargetUnitInDetectRange>();
                    new List<TargetUnitInDetectRange>();
                    if ((sensorArray.Length > 0) && (list.Count > 0))
                    {
                        targetUnitsInDetectRange = this.GetTargetUnitsInDetectRange(ref sensorArray, list);
                    }
                    if ((source.Count<Sensor>() > 0) && (list2.Count > 0))
                    {
                        expression = this.GetTargetUnitsInDetectRange(ref source, list2);
                        if (!Information.IsNothing(expression))
                        {
                            targetUnitsInDetectRange.AddRange(expression);
                        }
                    }
                    if ((sensorArray6.Count<Sensor>() > 0) && (list3.Count > 0))
                    {
                        list6 = this.GetTargetUnitsInDetectRange(ref sensorArray6, list3);
                        if (!Information.IsNothing(list6))
                        {
                            targetUnitsInDetectRange.AddRange(list6);
                        }
                    }
                    if (nonSearchAndTrackSensorsWithTargetsTracked.Count<Sensor>() > 0)
                    {
                        foreach (Sensor sensor2 in nonSearchAndTrackSensorsWithTargetsTracked)
                        {
                            foreach (Contact contact3 in sensor2.GetTargetsTrackedForFireControl())
                            {
                                if (!Information.IsNothing(contact3.ActualUnit))
                                {
                                    Sensor[] sensorArray9 = new Sensor[] { sensor2 };
                                    TargetUnitInDetectRange range = new TargetUnitInDetectRange(ref contact3.ActualUnit, ref sensorArray9);
                                    if (!Information.IsNothing(range))
                                    {
                                        targetUnitsInDetectRange.Add(range);
                                    }
                                }
                            }
                        }
                    }
                    if (targetUnitsInDetectRange.Count <= 0)
                    {
                        goto Label_06BE;
                    }
                    List<ActiveUnit> affectingJammers = null;
                    Sensor[] sensorArray10 = searchingAndTrackingSensors;
                    Sensor[] sensorArray11 = null;
                    for (int j = 0; j < sensorArray10.Length; j++)
                    {
                        if (sensorArray10[j].sensorType == Sensor.SensorType.Radar)
                        {
                            goto Label_05D4;
                        }
                    }
                    goto Label_05E9;
                Label_05D4:
                    if (Information.IsNothing(affectingJammers))
                    {
                        affectingJammers = this.GetAffectingJammers(true);
                    }
                Label_05E9:
                    sensorArray11 = nonSearchAndTrackSensorsWithTargetsTracked;
                    for (int k = 0; k < sensorArray11.Length; k++)
                    {
                        if (sensorArray11[k].sensorType == Sensor.SensorType.Radar)
                        {
                            goto Label_061A;
                        }
                    }
                    goto Label_062F;
                Label_061A:
                    if (Information.IsNothing(affectingJammers))
                    {
                        affectingJammers = this.GetAffectingJammers(true);
                    }
                Label_062F:
                    this.concurrentBag_0 = new ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, Enum8>>();
                    this.DetectedMinesBag = new ConcurrentBag<string>();
                    foreach (TargetUnitInDetectRange range2 in targetUnitsInDetectRange)
                    {
                        try
                        {
                            this.DetectTargetsInRange(range2, affectingJammers);
                        }
                        catch (Exception exception)
                        {
                            ProjectData.SetProjectError(exception);
                            Exception exception2 = exception;
                            exception2.Data.Add("Error at 101168", "");
                            GameGeneral.LogException(ref exception2);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                    }
                Label_06BE:
                    if (sensorArray.Length > 0)
                    {
                        this.SearchMineObstacles(sensorArray);
                    }
                }
                catch (Exception exception3)
                {
                    ProjectData.SetProjectError(exception3);
                    Exception exception4 = exception3;
                    exception4.Data.Add("Error at 100242", "");
                    GameGeneral.LogException(ref exception4);
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
                    ProjectData.ClearProjectError();
                }
            }

        }

        // Token: 0x06003CA6 RID: 15526 RVA: 0x0012F564 File Offset: 0x0012D764
        private List<ActiveUnit_Sensory.TargetUnitInDetectRange> GetTargetUnitsInDetectRange(ref Sensor[] sensorArray, List<ActiveUnit> activeUnits)
		{
			List<ActiveUnit_Sensory.TargetUnitInDetectRange> result;
			try
			{
				List<ActiveUnit_Sensory.TargetUnitInDetectRange> list = new List<ActiveUnit_Sensory.TargetUnitInDetectRange>();
				List<Sensor> maxRangeCoverageAirSpaceSensorList = this.GetMaxRangeCoverageAirSpaceSensorList(false, false, true, true, ref sensorArray);
				List<Sensor> maxRangeCoverageSurfaceSensorList = this.GetMaxRangeCoverageSurfaceSensorList(false, false, true, true, ref sensorArray);
				List<Sensor> maxRangeCoverageLandSensorList = this.GetMaxRangeCoverageLandSensorList(false, false, true, true, ref sensorArray);
				List<Sensor> maxRangeCoverageSubsurfaceSensorList = this.GetMaxRangeCoverageSubsurfaceSensorList(false, false, true, true, ref sensorArray, false);
				if (maxRangeCoverageAirSpaceSensorList.Count > 0)
				{
					this.MaxAirDetectRange = maxRangeCoverageAirSpaceSensorList[0].MaxRange;
				}
				else
				{
					this.MaxAirDetectRange = 0f;
				}
				if (maxRangeCoverageSurfaceSensorList.Count > 0)
				{
					this.MaxSurfaceDetectRange = maxRangeCoverageSurfaceSensorList[0].MaxRange;
				}
				else
				{
					this.MaxSurfaceDetectRange = 0f;
				}
				if (maxRangeCoverageLandSensorList.Count > 0)
				{
					this.MaxLandDetectRange = maxRangeCoverageLandSensorList[0].MaxRange;
				}
				else
				{
					this.MaxLandDetectRange = 0f;
				}
				if (maxRangeCoverageSubsurfaceSensorList.Count > 0)
				{
					this.MaxSubsurfaceDetectRange = maxRangeCoverageSubsurfaceSensorList[0].MaxRange;
				}
				else
				{
					this.MaxSubsurfaceDetectRange = 0f;
				}
				this.MaxDetectRange = Math.Max(Math.Max(Math.Max(this.MaxAirDetectRange, this.MaxSurfaceDetectRange), this.MaxSubsurfaceDetectRange), this.MaxLandDetectRange);
				if (this.MaxDetectRange == 0f)
				{
					result = list;
				}
				else
				{
					double latitude = this.ParentPlatform.GetLatitude(null);
					double longitude = this.ParentPlatform.GetLongitude(null);
					List<ActiveUnit> unitsInRange = RangeCalculator.GetUnitsInRange(activeUnits, true, latitude, longitude, (double)this.MaxDetectRange);
					int num = unitsInRange.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ActiveUnit activeUnit = unitsInRange[i];
						if (!Information.IsNothing(activeUnit) && !activeUnit.IsGroup)
						{
							float num2 = 0f;
							if (activeUnit.IsFacility)
							{
								num2 = this.MaxLandDetectRange;
							}
							else if (activeUnit.IsShip)
							{
								num2 = this.MaxSurfaceDetectRange;
							}
							else if (activeUnit.IsSubmarine)
							{
								num2 = Math.Max(this.MaxSubsurfaceDetectRange, this.MaxSurfaceDetectRange);
							}
							else if (activeUnit.IsAircraft || activeUnit.IsGuidedWeapon_RV_HGV() || activeUnit.IsSatellite() || activeUnit.IsAirDecoy())
							{
								num2 = this.MaxAirDetectRange;
							}
							if (num2 != 0f && num2 > this.ParentPlatform.GetHorizontalRange(activeUnit))
							{
								ActiveUnit_Sensory.TargetUnitInDetectRange item = new ActiveUnit_Sensory.TargetUnitInDetectRange(ref activeUnit, ref sensorArray);
								list.Add(item);
							}
						}
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101224", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit_Sensory.TargetUnitInDetectRange>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0012F85C File Offset: 0x0012DA5C
		private void SearchMineObstacles(Sensor[] sensors)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.ParentPlatform.m_Scenario.Mines) && this.ParentPlatform.m_Scenario.Mines.Count != 0 && !this.ParentPlatform.IsFacility && this.ParentPlatform.m_Scenario.GetUnguidedWeapons().Values.Count > 0)
					{
						if (this.ParentPlatform.IsWeapon)
						{
							Weapon weapon = (Weapon)this.ParentPlatform;
							if (weapon.GetWeaponType() != Weapon._WeaponType.HeliTowedPackage && !weapon.weaponTarget.IsMine)
							{
								return;
							}
						}
						Sensor[] array = new Sensor[0];
						for (int i = 0; i < sensors.Length; i++)
						{
							Sensor sensor = sensors[i];
							if (sensor.IsSonar())
							{
								if (sensor.IsEmmitting() && sensor.IsOperating() && (sensor.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar) || sensor.sensorCapability.MineObstacleSearch))
								{
									ScenarioArrayUtil.AddSensor(ref array, sensor);
								}
							}
							else if (sensor.sensorType == Sensor.SensorType.Visual && (this.ParentPlatform.IsAircraft || this.ParentPlatform.IsShip) && this.ParentPlatform.GetCurrentAltitude_ASL(false) < 150f && this.ParentPlatform.GetCurrentSpeed() < 200f)
							{
								ScenarioArrayUtil.AddSensor(ref array, sensor);
							}
						}
						if (array.Length != 0)
						{
							List<ActiveUnit_Sensory.MineObstacleSearchManager> list = new List<ActiveUnit_Sensory.MineObstacleSearchManager>();
							list = this.GetMineObstacleSearchSonarsForMines(ref array, ref this.ParentPlatform.m_Scenario.Mines);
							if (list.Count > 0)
							{
								foreach (ActiveUnit_Sensory.MineObstacleSearchManager current in list)
								{
									this.MineObstacleSearch(current, array);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101272", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x0012FAC4 File Offset: 0x0012DCC4
		private List<ActiveUnit_Sensory.MineObstacleSearchManager> GetMineObstacleSearchSonarsForMines(ref Sensor[] EmmittingMineObstacleSearchSonarArray_, ref List<UnguidedWeapon> Mines_)
		{
			List<ActiveUnit_Sensory.MineObstacleSearchManager> result;
			try
			{
				List<ActiveUnit_Sensory.MineObstacleSearchManager> list = new List<ActiveUnit_Sensory.MineObstacleSearchManager>();
				List<Sensor> maxRangeMaxCoverageSensorList = this.GetMaxRangeMaxCoverageSensorList(ref EmmittingMineObstacleSearchSonarArray_);
				if (EmmittingMineObstacleSearchSonarArray_.Count<Sensor>() > 0)
				{
					float num = maxRangeMaxCoverageSensorList[0].MaxRange;
					if (num > 1f)
					{
						num = 1f;
					}
					float num2 = (float)Math2.ApproxAngularDistance((double)num);
					int num3 = Mines_.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						UnguidedWeapon unguidedWeapon = Mines_[i];
						if (Math.Abs(this.ParentPlatform.GetLatitude(null) - unguidedWeapon.GetLatitude(null)) <= (double)num2 && (double)num2 > this.ParentPlatform.GetApproxAngularDistanceInDegrees(unguidedWeapon))
						{
							ActiveUnit_Sensory.MineObstacleSearchManager item = new ActiveUnit_Sensory.MineObstacleSearchManager(ref unguidedWeapon, ref EmmittingMineObstacleSearchSonarArray_);
							list.Add(item);
						}
					}
					result = list;
				}
				else
				{
					result = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101224", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit_Sensory.MineObstacleSearchManager>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0012FC0C File Offset: 0x0012DE0C
		private void MineObstacleSearch(ActiveUnit_Sensory.MineObstacleSearchManager MineObstacleSearchManager_, Sensor[] MineObstacleSearchSonars)
		{
			checked
			{
				try
				{
					UnguidedWeapon mine = MineObstacleSearchManager_.Mine;
					float slantRange = this.ParentPlatform.GetSlantRange(mine, 0f);
					for (int i = 0; i < MineObstacleSearchSonars.Length; i++)
					{
						if (MineObstacleSearchSonars[i].MineObstacleSearchAttempt(this.ParentPlatform, mine, slantRange))
						{
							this.DetectedMinesBag.Add(mine.GetGuid());
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100244", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0012FCB8 File Offset: 0x0012DEB8
		private void DetectTargetsInRange(ActiveUnit_Sensory.TargetUnitInDetectRange TargetUnitInDetectRange_, List<ActiveUnit> JammerCarrierList)
		{
			Side side = this.ParentPlatform.GetSide(false);
			checked
			{
				try
				{
					ActiveUnit targetUnit = TargetUnitInDetectRange_.TargetUnit;
					Sensor[] sensorArray = TargetUnitInDetectRange_.sensorArray;
					if (!Information.IsNothing(targetUnit) && targetUnit != this.ParentPlatform)
					{
						Side side2 = targetUnit.GetSide(false);
						if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms() || !targetUnit.GetCommStuff().IsNotOutOfComms() || (side != side2 && side2.GetPostureStance(side) != Misc.PostureStance.Friendly))
						{
							Contact contact = null;
							bool flag;
							if ((flag = targetUnit.IsDetected(side)) && side != side2)
							{
								if (this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
								{
									if (!side.GetContactObservableDictionary().TryGetValue(targetUnit.GetGuid(), ref contact))
									{
										return;
									}
								}
								else if (!this.ContactList_OffGrid.TryGetValue(targetUnit.GetGuid(), out contact))
								{
									return;
								}
								if (!Information.IsNothing(contact) && !this.ParentPlatform.IsWeapon)
								{
									if (contact.GetRadiationHostUnits(side).Count > 0)
									{
										if (contact.TS_BDA < 10f)
										{
											return;
										}
									}
									else if (contact.TS_BDA < 15f)
									{
										return;
									}
								}
							}
							List<Sensor> item = new List<Sensor>();
							float? num = null;
							if (this.ParentPlatform.IsSubmarine && targetUnit.IsAircraft && ((Aircraft)targetUnit).GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
							{
								num = new float?(this.ParentPlatform.GetHorizontalRange(targetUnit));
							}
							else
							{
								num = new float?(this.ParentPlatform.GetSlantRange(targetUnit, 0f));
							}
							bool? flag2 = null;
							bool? flag3 = null;
							Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
							bool? flag4 = null;
							if (flag && side != side2)
							{
								if (targetUnit.HasEmmittingSensor())
								{
									Contact contact2 = this.GetContactBy(targetUnit, sensorArray, num.Value, ref item, JammerCarrierList, ref flag2, ref flag3, ref lOS_Exists_Visual, ref flag4, true);
									if (!Information.IsNothing(contact2))
									{
										ActiveUnit_Sensory.smethod_3(contact, contact2.GetEmissionContainerObDictionary());
									}
								}
								if (!this.ParentPlatform.IsWeapon || (!((Weapon)this.ParentPlatform).method_209() && this.ParentPlatform.GetCommStuff().GetCommLinksEstablished().Count<ActiveUnit_CommLink>() != 0))
								{
									Sensor[] array = this.ParentPlatform.GetAllNoneMCMSensors().Where(ActiveUnit_Sensory.VisualSensorFilter).ToArray<Sensor>();
									if (array.Length > 0)
									{
										Sensor[] array2 = array;
										for (int i = 0; i < array2.Length; i++)
										{
											Sensor sensor = array2[i];
											Sensor sensor2 = sensor;
											ActiveUnit parentPlatform = this.ParentPlatform;
											ActiveUnit targetUnit_ = targetUnit;
											List<GeoPoint> list = new List<GeoPoint>();
											float value = num.Value;
											Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
											if (sensor2.SensorDetectionAttempt(Sensor.DetectionAttemptType.Recon, parentPlatform, targetUnit_, ref list, value, ref lazy, JammerCarrierList, ref flag2, ref flag3, ref lOS_Exists_Visual, ref flag4))
											{
												this.TargetBattleDamageAssessment(contact, targetUnit, sensor);
												this.method_31(contact, targetUnit, sensor);
											}
										}
									}
								}
								if (!this.ParentPlatform.IsWeapon)
								{
									return;
								}
							}
							contact = this.GetContactBy(targetUnit, sensorArray, num.Value, ref item, JammerCarrierList, ref flag2, ref flag3, ref lOS_Exists_Visual, ref flag4, false);
							if (!Information.IsNothing(contact))
							{
								this.concurrentBag_0.Add(new Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>(contact, targetUnit, item, num.Value, ActiveUnit_Sensory.Enum8.const_0));
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100245", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00130074 File Offset: 0x0012E274
		public virtual void ScheduleDetectInterationOnGrid()
		{
			try
			{
				this.ParentPlatform.GetSensory().method_68();
				if (!Information.IsNothing(this.concurrentBag_0))
				{
					foreach (Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8> current in this.concurrentBag_0)
					{
						if (!Information.IsNothing(current))
						{
							this.vmethod_9(current.Item1, current.Item2, current.Item3, current.Item4, current.Item5);
						}
					}
				}
				if (!Information.IsNothing(this.DetectedMinesBag))
				{
					foreach (string current2 in this.DetectedMinesBag)
					{
						if (!string.IsNullOrEmpty(current2) && !this.ParentPlatform.GetSide(false).Contacts_NonAU.Contains(current2))
						{
							this.ParentPlatform.GetSide(false).Contacts_NonAU.Add(current2);
							try
							{
								UnguidedWeapon unguidedWeapon = this.ParentPlatform.m_Scenario.GetUnguidedWeapons()[current2];
								if (unguidedWeapon.IsMine())
								{
									string text = "";
									if (this.ParentPlatform.IsAircraft && Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
									{
										text = " (" + this.ParentPlatform.UnitClass + ")";
									}
									this.ParentPlatform.LogMessage(string.Concat(new string[]
									{
										"发现新水雷! 探测平台:",
										this.ParentPlatform.Name,
										text,
										" 探测方位:",
										Conversions.ToString((int)Math.Round((double)this.ParentPlatform.GetAI().GetAzimuth(unguidedWeapon))),
										"度 -探测距离:",
										Conversions.ToString(Math.Round((double)this.ParentPlatform.GetHorizontalRange(unguidedWeapon), 1)),
										"海里"
									}), LoggedMessage.MessageType.NewMineContact, 1, false, new GeoPoint(unguidedWeapon.GetLongitude(null), unguidedWeapon.GetLatitude(null)));
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
					}
				}
				if (!Information.IsNothing(this.lazy_0) && !Misc.smethod_18(this.lazy_0.Value))
				{
					foreach (LoggedMessage current3 in this.lazy_0.Value.Values)
					{
						this.ParentPlatform.m_Scenario.MessageLogTryAdd(current3);
					}
					this.lazy_0.Value.Clear();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100246", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00130414 File Offset: 0x0012E614
		public void ScheduleDetectInterationOffGrid()
		{
			try
			{
				this.ParentPlatform.GetSensory().method_68();
				if (!Information.IsNothing(this.concurrentBag_0))
				{
					foreach (Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8> current in this.concurrentBag_0)
					{
						if (!Information.IsNothing(current))
						{
							this.vmethod_10(current.Item1, current.Item2, current.Item3, current.Item4, current.Item5);
						}
					}
				}
				if (!Information.IsNothing(this.DetectedMinesBag))
				{
					foreach (string current2 in this.DetectedMinesBag)
					{
						if (!string.IsNullOrEmpty(current2) && !this.list_1.Contains(current2))
						{
							this.list_1.Add(current2);
							try
							{
								UnguidedWeapon unguidedWeapon = this.ParentPlatform.m_Scenario.GetUnguidedWeapons()[current2];
								if (unguidedWeapon.IsMine())
								{
									this.ParentPlatform.LogMessage(string.Concat(new string[]
									{
										"发现新水雷目标! 探测平台：",
										this.ParentPlatform.Name,
										" 方位",
										Conversions.ToString((int)Math.Round((double)this.ParentPlatform.GetAI().GetAzimuth(unguidedWeapon))),
										"度 -距离",
										Conversions.ToString(Math.Round((double)this.ParentPlatform.GetHorizontalRange(unguidedWeapon), 1)),
										"海里"
									}), LoggedMessage.MessageType.CommsIsolatedMessage, 1, false, new GeoPoint(unguidedWeapon.GetLongitude(null), unguidedWeapon.GetLatitude(null)));
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
					}
				}
				if (!Information.IsNothing(this.lazy_0))
				{
					foreach (LoggedMessage current3 in this.lazy_0.Value.Values)
					{
						this.ParentPlatform.m_Scenario.MessageLogTryAdd(current3);
					}
				}
				this.lazy_0.Value.Clear();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200653", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw ex2;
			}
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x00130728 File Offset: 0x0012E928
		public static void smethod_2(ref Contact myContact, ActiveUnit ContactsActualUnit, bool ContactIsNew, List<GeoPoint> theUncertaintyArea = null)
		{
			try
			{
				bool flag = false;
				if (ContactIsNew)
				{
					flag = true;
				}
				else
				{
					Contact_Base.ContactType contactType = myContact.contactType;
					if (contactType <= Contact_Base.ContactType.Facility_Fixed)
					{
						if (contactType == Contact_Base.ContactType.Aimpoint || contactType == Contact_Base.ContactType.Facility_Fixed)
						{
							goto IL_41;
						}
					}
					else if (contactType == Contact_Base.ContactType.Explosion || contactType == Contact_Base.ContactType.ActivationPoint)
					{
						goto IL_41;
					}
					flag = true;
				}
				IL_41:
				if (flag)
				{
					if (!Information.IsNothing(theUncertaintyArea))
					{
						if (Information.IsNothing(myContact.GetUncertaintyArea()))
						{
							if (ContactIsNew)
							{
								myContact.SetUncertaintyArea(theUncertaintyArea);
							}
						}
						else if (!myContact.GetIsPreciselyLocatedOnThisPulse())
						{
							if (!Information.IsNothing(myContact.ActualUnit))
							{
								myContact.SetUncertaintyArea(ActiveUnit_Sensory.smethod_7(myContact.GetUncertaintyArea(), theUncertaintyArea));
							}
							else
							{
								myContact.SetUncertaintyArea(theUncertaintyArea);
							}
						}
					}
					myContact.SetCurrentHeading(ContactsActualUnit.GetCurrentHeading());
					myContact.SetCurrentSpeed(ContactsActualUnit.GetCurrentSpeed());
					myContact.SetAltitude_ASL(false, ContactsActualUnit.GetCurrentAltitude_ASL(false));
					myContact.RecordPreviousLocation();
				}
				myContact.SetDetectedLocation(ContactsActualUnit);
				myContact.Age = 0f;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100247", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x00130870 File Offset: 0x0012EA70
		public void StopIlluminateTarget(Contact theTarget)
		{
			Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
			checked
			{
				for (int i = 0; i < allNoneMCMSensors.Length; i++)
				{
					Sensor sensor = allNoneMCMSensors[i];
					if (sensor.GetTargetsTrackedForFireControl().Contains(theTarget))
					{
						sensor.StopIlluminateTarget(ref theTarget, false);
					}
				}
			}
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x001308B8 File Offset: 0x0012EAB8
		public static void smethod_3(Contact contact_0, ObservableDictionary<int, EmissionContainer> observableDictionary_2)
		{
			try
			{
				foreach (KeyValuePair<int, EmissionContainer> current in observableDictionary_2)
				{
					if (contact_0.GetEmissionContainerObDictionary().ContainsKey(current.Key))
					{
						if (contact_0.GetEmissionContainerObDictionary()[current.Key].bool_1)
						{
							current.Value.bool_1 = true;
						}
						contact_0.GetEmissionContainerObDictionary()[current.Key] = current.Value;
					}
					else
					{
						try
						{
							contact_0.GetEmissionContainerObDictionary().Add(current.Key, current.Value);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200011", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100248", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x00130A14 File Offset: 0x0012EC14
		private void method_23(List<Sensor> SensorList, Contact theTarget)
		{
			foreach (Sensor current in SensorList)
			{
				if (current.IsContinousTrackingCapable())
				{
					theTarget.SetRCTT(Math.Max(theTarget.GetRCTT(), (float)current.GetScanInterval()));
					if (current.IsPreciselyLocatedEnable())
					{
						theTarget.SetRCTTP(Math.Max(theTarget.GetRCTTP(), (float)current.GetScanInterval()));
					}
				}
				else
				{
					Sensor sensor = current;
					ActiveUnit actualUnit = theTarget.ActualUnit;
					if (sensor.IsTrackingTargetUnit(ref actualUnit))
					{
						theTarget.SetRCTT(Math.Max(theTarget.GetRCTT(), (float)current.GetScanInterval()));
						if (current.IsPreciselyLocatedEnable())
						{
							theTarget.SetRCTTP(Math.Max(theTarget.GetRCTTP(), (float)current.GetScanInterval()));
						}
					}
					else if (current.sensorType == Sensor.SensorType.Radar)
					{
						theTarget.SetRCTT(Math.Max(theTarget.GetRCTT(), 3f));
						if (current.IsPreciselyLocatedEnable())
						{
							theTarget.SetRCTTP(Math.Max(theTarget.GetRCTTP(), (float)current.GetScanInterval()));
						}
					}
					else if (theTarget.IsFixed())
					{
						theTarget.SetRCTT(Math.Max(theTarget.GetRCTT(), (float)(current.GetScanInterval() * 6)));
						if (current.IsPreciselyLocatedEnable())
						{
							theTarget.SetRCTTP(Math.Max(theTarget.GetRCTTP(), (float)current.GetScanInterval()));
						}
					}
					else
					{
						theTarget.SetRCTT(Math.Max(theTarget.GetRCTT(), 1f));
					}
				}
			}
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x00130BC0 File Offset: 0x0012EDC0
		protected virtual void vmethod_9(Contact theTarget, Unit targetUnit_, List<Sensor> SensorList, float rangeToTarget_, ActiveUnit_Sensory.Enum8 enum8_0)
		{
			List<GeoPoint> list = null;
			ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = theTarget.GetEmissionContainerObDictionary();
			checked
			{
				try
				{
					bool flag = this.ParentPlatform.GetSide(false).LazyContactList_OnGrid.Value.ContainsKey(targetUnit_.GetGuid());
					bool flag2 = this.ParentPlatform.GetSide(false).GetContactObservableDictionary().ContainsKey(targetUnit_.GetGuid());
					bool flag3 = this.ParentPlatform.GetSensory().method_63().ContainsKey(targetUnit_.GetGuid());
					Contact contact = null;
					if (flag2)
					{
						contact = this.ParentPlatform.GetSide(false).GetContactObservableDictionary()[targetUnit_.GetGuid()];
						if (contact.HasEmissionContainer() || theTarget.HasEmissionContainer())
						{
							ActiveUnit_Sensory.smethod_3(contact, theTarget.GetEmissionContainerObDictionary());
						}
					}
					else
					{
						if (flag)
						{
							return;
						}
						contact = theTarget;
					}
					if (!Information.IsNothing(theTarget.GetUncertaintyArea()))
					{
						list = theTarget.GetUncertaintyArea();
					}
					this.method_23(SensorList, contact);
					if (this.ParentPlatform.GetSide(false).GetAwarenessLevel() >= Side.AwarenessLevel.AutoSideID && !contact.SideIsKnown)
					{
						contact.SideIsKnown = true;
						contact.bool_11 = false;
					}
					string name = contact.Name;
					Contact_Base.IdentificationStatus? identificationStatus = null;
					Contact_Base.IdentificationStatus? identificationStatus2 = null;
					if (SensorList.Count != 0)
					{
						foreach (Sensor current in SensorList)
						{
							if (flag2)
							{
								this.method_24(current, contact, (ActiveUnit)targetUnit_, rangeToTarget_, ref identificationStatus, ref identificationStatus2);
							}
							this.TargetBattleDamageAssessment(contact, (ActiveUnit)targetUnit_, current);
							this.TargetTSDInitialization(current, contact);
							if (!current.IsPreciselyLocatedEnable())
							{
								if (!contact.GetIsPreciselyLocatedOnThisPulse() && !targetUnit_.IsFixedFacility())
								{
									List<GeoPoint> detectionAOU = this.GetDetectionAOU(current, targetUnit_, this.ParentPlatform.GetHorizontalRange(targetUnit_), emissionContainerObDictionary);
									if (Information.IsNothing(list))
									{
										list = detectionAOU;
									}
									else
									{
										ActiveUnit_Sensory.smethod_7(list, detectionAOU);
									}
								}
								if (current.sensorCapability.AltitudeInformation || this.ParentPlatform.IsWeapon)
								{
									contact.Altitude_Known = true;
								}
							}
							else
							{
								contact.SetIsPreciselyLocatedOnThisPulse(true);
							}
						}
					}
					if (!Information.IsNothing(identificationStatus))
					{
						short? num = identificationStatus.HasValue ? new short?((short)identificationStatus.GetValueOrDefault()) : null;
						bool? flag4;
						if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
						{
							if (!contact.IsAir())
							{
								flag4 = new bool?(false);
							}
							else
							{
								num = (identificationStatus.HasValue ? new short?((short)identificationStatus.GetValueOrDefault()) : null);
								flag4 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null);
							}
						}
						else
						{
							flag4 = new bool?(true);
						}
						bool? flag5 = flag4;
						if (flag5.GetValueOrDefault() && !contact.ActualUnit.GetCommStuff().IsNotOutOfComms() && (contact.ActualUnit.GetSide(false) == this.ParentPlatform.GetSide(false) || contact.ActualUnit.GetSide(false).GetPostureStance(this.ParentPlatform.GetSide(false)) == Misc.PostureStance.Friendly))
						{
							if (flag3)
							{
								this.ParentPlatform.LogMessage(string.Concat(new string[]
								{
									"目标: ",
									name,
									" 经",
									this.ParentPlatform.Name,
									"识别为",
									targetUnit_.Name,
									", 是失去通信联系的作战单元。放弃目标并更新作战单元的最后报告位置。"
								}), LoggedMessage.MessageType.ContactChange, 0, false, new GeoPoint(contact.GetLongitude(null), contact.GetLatitude(null)));
							}
							try
							{
								this.ParentPlatform.GetSide(false).Lazy3DictionaryTryAdd(contact, ref this.ParentPlatform.m_Scenario, false);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							if (Information.IsNothing(list))
							{
								ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)targetUnit_, !flag2, null);
							}
							else
							{
								ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)targetUnit_, !flag2, list);
							}
							contact.ActualUnit.SetLatitudeLR(new double?(contact.GetLatitude(null)));
							contact.ActualUnit.SetLongitudeLR(new double?(contact.GetLongitude(null)));
							return;
						}
					}
					if (flag2)
					{
						if (Information.IsNothing(list))
						{
							ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)targetUnit_, false, null);
						}
						else
						{
							ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)targetUnit_, false, list);
						}
					}
					else
					{
						identificationStatus = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.Unknown);
						identificationStatus2 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.Unknown);
						ActiveUnit[] array = new ActiveUnit[0];
						Side[] sides = this.ParentPlatform.m_Scenario.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (side == this.ParentPlatform.GetSide(false) | side.GetPostureStance(this.ParentPlatform.GetSide(false)) == Misc.PostureStance.Friendly)
							{
								ActiveUnit[] activeUnitArray = side.ActiveUnitArray;
								for (int j = 0; j < activeUnitArray.Length; j++)
								{
									ActiveUnit activeUnit = activeUnitArray[j];
									if (!activeUnit.GetCommStuff().IsNotOutOfComms())
									{
										ScenarioArrayUtil.AddActiveUnit(ref array, activeUnit);
									}
								}
							}
						}
						if (array.Length > 0)
						{
							if (Information.IsNothing(list))
							{
								ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)targetUnit_, true, null);
							}
							else
							{
								ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)targetUnit_, true, list);
							}
							ActiveUnit[] array2 = array;
							for (int k = 0; k < array2.Length; k++)
							{
								ActiveUnit activeUnit2 = array2[k];
								bool arg_5CF_0 = Debugger.IsAttached;
								if (((activeUnit2.IsAircraft && contact.IsAir()) || (activeUnit2.IsShip && contact.IsSurface()) || (activeUnit2.IsSubmarine && contact.IsSubSurface()) || (activeUnit2.IsFacility && contact.contactType == Contact_Base.ContactType.Facility_Mobile)) && contact.HorizontalRangeTo(activeUnit2.GetLatitudeLR().Value, activeUnit2.GetLongitudeLR().Value) < 1f)
								{
									activeUnit2.SetLatitudeLR(new double?(contact.GetLatitude(null)));
									activeUnit2.SetLongitudeLR(new double?(contact.GetLongitude(null)));
									return;
								}
							}
						}
						contact.SetUncertaintyArea(list);
						ActiveUnit_Sensory.NewContactDetected(ref contact, ref this.ParentPlatform.m_Scenario, this.ParentPlatform.GetSide(false), targetUnit_, this.ParentPlatform, Contact_Base.IdentificationStatus.KnownDomain, SensorList);
					}
					this.method_26(theTarget);
					if (!Information.IsNothing(identificationStatus) && !Information.IsNothing(identificationStatus2) && (Information.IsNothing(enum8_0) || enum8_0 == ActiveUnit_Sensory.Enum8.const_0))
					{
						List<EventTrigger> list2 = new List<EventTrigger>();
						foreach (EventTrigger current2 in this.ParentPlatform.m_Scenario.GetEventTriggers().Values)
						{
							if (current2.eventTriggerType == EventTrigger.EventTriggerType.UnitDetected && ((EventTrigger_UnitDetected)current2).method_11((ActiveUnit)targetUnit_, this.ParentPlatform.GetSide(false), flag, identificationStatus.Value, new Contact_Base.IdentificationStatus?(identificationStatus2.Value)))
							{
								list2.Add(current2);
							}
						}
						this.ParentPlatform.m_Scenario.TriggerEvents(list2);
					}
					if (flag3)
					{
						string guid = targetUnit_.GetGuid();
						this.method_64(ref guid, SensorList);
					}
					else
					{
						this.lazy_1.Value.TryAdd(targetUnit_.GetGuid(), contact);
						string guid = targetUnit_.GetGuid();
						this.method_64(ref guid, SensorList);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100249", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
			}
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x0013146C File Offset: 0x0012F66C
		private void method_24(Sensor sensor_, Contact contact_, ActiveUnit targetUnit_, float RangeToTarget_, ref Contact_Base.IdentificationStatus? IdentificationStatus_0, ref Contact_Base.IdentificationStatus? IdentificationStatus_1)
		{
			if (sensor_.sensorCapability.HeadingInformation)
			{
				contact_.Heading_Known = true;
			}
			if (sensor_.sensorCapability.SpeedInformation)
			{
				contact_.Speed_Known = true;
			}
			if (sensor_.sensorCapability.AltitudeInformation || this.ParentPlatform.IsWeapon)
			{
				contact_.Altitude_Known = true;
			}
			IdentificationStatus_1 = new Contact_Base.IdentificationStatus?(contact_.GetIdentificationStatus());
			bool bool_ = false;
			Sensor.SensorType sensorType = sensor_.sensorType;
			if (sensorType <= Sensor.SensorType.HullSonar_ActivePassive)
			{
				switch (sensorType)
				{
				case Sensor.SensorType.Radar:
					if (contact_.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
					{
						goto IL_389;
					}
					IdentificationStatus_0 = this.GetIdentificationStatusFromNCTR(contact_, targetUnit_, sensor_, RangeToTarget_);
					if (!Information.IsNothing(IdentificationStatus_0))
					{
						bool_ = true;
						goto IL_389;
					}
					goto IL_389;
				case Sensor.SensorType.SemiActive:
					goto IL_389;
				case Sensor.SensorType.Visual:
				{
					float detectionRange = sensor_.GetDetectionRange(this.ParentPlatform, targetUnit_);
					if (RangeToTarget_ < detectionRange)
					{
						switch (contact_.contactType)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Orbital:
						case Contact_Base.ContactType.Facility_Mobile:
						case Contact_Base.ContactType.Torpedo:
						case Contact_Base.ContactType.Mine:
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
							goto IL_389;
						case Contact_Base.ContactType.Missile:
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_389;
						case Contact_Base.ContactType.Surface:
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.PreciseID);
							goto IL_389;
						case Contact_Base.ContactType.Submarine:
							if (((Submarine)contact_.ActualUnit).IsShallowerThanPeriscopeDepth())
							{
								IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
								goto IL_389;
							}
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_389;
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Facility_Fixed:
							goto IL_389;
						default:
							goto IL_389;
						}
					}
					else
					{
						if (RangeToTarget_ < detectionRange * 3f)
						{
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_389;
						}
						IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
						goto IL_389;
					}
					break;
				}
				case Sensor.SensorType.Infrared:
				{
					if (!sensor_.sensorCode.Classification_BrilliantWeapon)
					{
						goto IL_389;
					}
					float detectionRange2 = sensor_.GetDetectionRange(this.ParentPlatform, targetUnit_);
					if (RangeToTarget_ < detectionRange2)
					{
						switch (contact_.contactType)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Surface:
						case Contact_Base.ContactType.Orbital:
						case Contact_Base.ContactType.Facility_Mobile:
						case Contact_Base.ContactType.Torpedo:
						case Contact_Base.ContactType.Mine:
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
							goto IL_389;
						case Contact_Base.ContactType.Missile:
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_389;
						case Contact_Base.ContactType.Submarine:
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Facility_Fixed:
							goto IL_389;
						default:
							goto IL_389;
						}
					}
					else
					{
						if (RangeToTarget_ < detectionRange2 * 3f)
						{
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_389;
						}
						IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
						goto IL_389;
					}
					break;
				}
				default:
					if (sensorType != Sensor.SensorType.ESM)
					{
						if (sensorType - Sensor.SensorType.HullSonar_PassiveOnly > 1)
						{
							goto IL_389;
						}
					}
					else
					{
						Contact_Base.ContactType contactType = contact_.contactType;
						if (contactType == Contact_Base.ContactType.Facility_Mobile)
						{
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
						}
						if (sensor_.sensorRole == Sensor._SensorRole.RWR_RadarWarningReceiver)
						{
							goto IL_389;
						}
						this.method_28(contact_, RangeToTarget_);
						if (contact_.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
						{
							IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(this.method_38(contact_, targetUnit_, sensor_));
							goto IL_389;
						}
						goto IL_389;
					}
					break;
				}
			}
			else if (sensorType <= Sensor.SensorType.VDS_ActivePassive)
			{
				if (sensorType - Sensor.SensorType.TowedArray_PassiveOnly > 1 && sensorType - Sensor.SensorType.VDS_PassiveOnly > 1)
				{
					goto IL_389;
				}
			}
			else if (sensorType - Sensor.SensorType.DippingSonar_PassiveOnly > 1 && sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly)
			{
				goto IL_389;
			}
			if (!sensor_.IsEmmitting())
			{
				this.method_27(contact_, RangeToTarget_);
				IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(this.method_39(contact_, targetUnit_, sensor_));
			}
			IL_389:
			if (this.ParentPlatform.GetSide(false).GetAwarenessLevel() >= Side.AwarenessLevel.AutoSideAndUnitID)
			{
				IdentificationStatus_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.PreciseID);
			}
			if (IdentificationStatus_0.HasValue)
			{
				Contact_Base.IdentificationStatus? identificationStatus = IdentificationStatus_0;
				short? num = identificationStatus.HasValue ? new short?((short)identificationStatus.GetValueOrDefault()) : null;
				short identificationStatus2 = (short)contact_.GetIdentificationStatus();
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() != identificationStatus2) : null).GetValueOrDefault())
				{
					if (Information.IsNothing(contact_.GetUncertaintyArea()))
					{
						contact_.TargetIdentification(this.ParentPlatform.m_Scenario, this.ParentPlatform.GetSide(false), sensor_, new float?((float)Math.Round((double)RangeToTarget_, 1)), bool_, this.ParentPlatform.GetCommStuff().IsNotOutOfComms(), IdentificationStatus_0.Value);
					}
					else
					{
						contact_.TargetIdentification(this.ParentPlatform.m_Scenario, this.ParentPlatform.GetSide(false), sensor_, new float?((float)Math.Round((double)this.ParentPlatform.GetSlantRange(contact_, 0f), 1)), bool_, this.ParentPlatform.GetCommStuff().IsNotOutOfComms(), IdentificationStatus_0.Value);
					}
				}
			}
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x0013194C File Offset: 0x0012FB4C
		private void TargetTSDInitialization(Sensor theSensor, Contact theTarget)
		{
			Sensor.SensorType sensorType = theSensor.sensorType;
			if (sensorType <= Sensor.SensorType.TowedArray_ActiveOnly)
			{
				if (sensorType <= Sensor.SensorType.ESM)
				{
					switch (sensorType)
					{
					case Sensor.SensorType.Radar:
						theTarget.TimeSinceDetection_Radar = new float?(0f);
						return;
					case Sensor.SensorType.SemiActive:
						return;
					case Sensor.SensorType.Visual:
						theTarget.TimeSinceDetection_Visual = new float?(0f);
						return;
					case Sensor.SensorType.Infrared:
						theTarget.TimeSinceDetection_Infrared = new float?(0f);
						return;
					default:
						if (sensorType == Sensor.SensorType.ESM)
						{
							theTarget.TimeSinceDetection_ESM = new float?(0f);
							return;
						}
						return;
					}
				}
				else if (sensorType - Sensor.SensorType.HullSonar_PassiveOnly > 2 && sensorType - Sensor.SensorType.TowedArray_PassiveOnly > 2)
				{
					return;
				}
			}
			else if (sensorType <= Sensor.SensorType.DippingSonar_ActiveOnly)
			{
				if (sensorType - Sensor.SensorType.VDS_PassiveOnly > 2 && sensorType - Sensor.SensorType.DippingSonar_PassiveOnly > 2)
				{
					return;
				}
			}
			else if (sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly)
			{
				if (sensorType == Sensor.SensorType.PingIntercept)
				{
					theTarget.TimeSinceDetection_SonarPassive = new float?(0f);
					return;
				}
				return;
			}
			if (theSensor.IsActiveModeOnly())
			{
				theTarget.TimeSinceDetection_SonarActive = new float?(0f);
			}
			else if (theSensor.IsEmmitting())
			{
				theTarget.TimeSinceDetection_SonarActive = new float?(0f);
			}
			else
			{
				theTarget.TimeSinceDetection_SonarPassive = new float?(0f);
			}
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00131AB4 File Offset: 0x0012FCB4
		protected virtual void vmethod_10(Contact theTarget, Unit theUnit, List<Sensor> Sensors, float float_5, ActiveUnit_Sensory.Enum8 enum8_0)
		{
			try
			{
				List<GeoPoint> list = null;
				theTarget.GetEmissionContainerObDictionary();
				bool flag = this.ParentPlatform.GetSide(false).LazyContactList_OnGrid.Value.ContainsKey(theUnit.GetGuid());
				bool flag2 = this.ContactList_OffGrid.ContainsKey(theUnit.GetGuid());
				bool flag3 = this.ParentPlatform.GetSensory().method_63().ContainsKey(theUnit.GetGuid());
				Contact contact = null;
				if (flag2)
				{
					contact = this.ContactList_OffGrid[theUnit.GetGuid()];
					if (contact.HasEmissionContainer() || theTarget.HasEmissionContainer())
					{
						ActiveUnit_Sensory.smethod_3(contact, theTarget.GetEmissionContainerObDictionary());
					}
				}
				else
				{
					if (flag)
					{
						return;
					}
					contact = theTarget;
				}
				if (enum8_0 != ActiveUnit_Sensory.Enum8.const_0 && !Information.IsNothing(theTarget.GetUncertaintyArea()))
				{
					list = theTarget.GetUncertaintyArea();
				}
				this.method_23(Sensors, contact);
				if (this.ParentPlatform.GetSide(false).GetAwarenessLevel() >= Side.AwarenessLevel.AutoSideID && !contact.SideIsKnown)
				{
					contact.SideIsKnown = true;
				}
				if (Sensors.Count != 0)
				{
					foreach (Sensor current in Sensors)
					{
						if (flag2)
						{
							Contact_Base.IdentificationStatus? identificationStatus = null;
							Contact_Base.IdentificationStatus? identificationStatus2 = null;
							this.method_24(current, contact, (ActiveUnit)theUnit, float_5, ref identificationStatus, ref identificationStatus2);
						}
						this.TargetTSDInitialization(current, contact);
						this.TargetBattleDamageAssessment(contact, (ActiveUnit)theUnit, current);
						this.method_31(contact, (ActiveUnit)theUnit, current);
						if (current.IsPreciselyLocatedEnable())
						{
							if (!Information.IsNothing(contact.GetUncertaintyArea()))
							{
								contact.SetHasUncertaintyArea(true);
							}
							contact.SetIsPreciselyLocatedOnThisPulse(true);
							contact.SetUncertaintyArea(null);
						}
					}
				}
				if (flag2)
				{
					if (Information.IsNothing(list))
					{
						ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)theUnit, false, null);
					}
					else
					{
						ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)theUnit, false, list);
					}
				}
				else
				{
					contact.SetUncertaintyArea(list);
					ActiveUnit_Sensory.NewContactDetected(ref contact, ref this.ParentPlatform.m_Scenario, this.ParentPlatform.GetSide(false), theUnit, this.ParentPlatform, Contact_Base.IdentificationStatus.KnownDomain, Sensors);
				}
				this.method_26(theTarget);
				if (contact.IsMissileOrTorpedo() && this.ParentPlatform.GetAI().method_14(contact))
				{
					contact.MarkAs(this.ParentPlatform.GetSide(false), false, Misc.PostureStance.Hostile);
				}
				if (!flag2 && !this.ContactList_OffGrid.ContainsKey(theUnit.GetGuid()))
				{
					this.ContactList_OffGrid.Add(theUnit.GetGuid(), contact);
				}
				if (flag3)
				{
					string guid = theUnit.GetGuid();
					this.method_64(ref guid, Sensors);
				}
				else
				{
					this.lazy_1.Value.TryAdd(theUnit.GetGuid(), contact);
					string guid = theUnit.GetGuid();
					this.method_64(ref guid, Sensors);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100249", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw ex2;
			}
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00131DFC File Offset: 0x0012FFFC
		private void method_26(Contact contact_0)
		{
			checked
			{
				if (contact_0.contactType == Contact_Base.ContactType.Torpedo)
				{
					Weapon weapon = (Weapon)contact_0.ActualUnit;
					if (!Information.IsNothing(weapon.GetFiringParent()) && weapon.GetFiringParent().IsSubmarine)
					{
						bool flag = false;
						foreach (Contact current in this.ParentPlatform.GetSide(false).GetContactList())
						{
							if (current.contactType == Contact_Base.ContactType.Submarine && Math.Abs(Class263.RelativeBearingTo(Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), current.GetLatitude(null), current.GetLongitude(null)), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null)))) < 45f)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							bool flag2 = false;
							foreach (Contact current2 in this.ParentPlatform.GetSide(false).GetContactList())
							{
								if (current2.contactType == Contact_Base.ContactType.Submarine && current2.ActualUnit == ((Weapon)contact_0.ActualUnit).GetFiringParent())
								{
									flag2 = true;
									break;
								}
							}
							if (!flag2)
							{
								Contact contact = new Contact(((Weapon)contact_0.ActualUnit).GetFiringParent(), 0);
								contact.SetLatitude(null, contact_0.ActualUnit.GetLatitude(null));
								contact.SetLongitude(null, contact_0.ActualUnit.GetLongitude(null));
								Class258.Location[] array = new Class258.Location[46];
								GeoPointGenerator.GetOtherPointsAroundAGeoPoint(contact.GetLatitude(null), contact.GetLongitude(null), 10.0, 45, ref array);
								List<GeoPoint> list = new List<GeoPoint>();
								Class258.Location[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									Class258.Location location = array2[i];
									list.Add(new GeoPoint(location.longitude, location.latitude));
								}
								contact.SetUncertaintyArea(list);
								this.concurrentBag_0.Add(new Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>(contact, ((Weapon)contact_0.ActualUnit).GetFiringParent(), new List<Sensor>(), 0f, ActiveUnit_Sensory.Enum8.const_1));
							}
						}
					}
				}
				if (contact_0.contactType == Contact_Base.ContactType.Missile)
				{
					Weapon weapon2 = (Weapon)contact_0.ActualUnit;
					if (!weapon2.IsDecoy() && !Information.IsNothing(weapon2.GetFiringParent()))
					{
						if (weapon2.GetFiringParent().IsSubmarine)
						{
							if (weapon2.GetHorizontalRange(weapon2.GetFiringParent()) < 1f)
							{
								bool flag3 = false;
								foreach (Contact current3 in this.ParentPlatform.GetSide(false).GetContactList())
								{
									if (current3.contactType == Contact_Base.ContactType.Submarine && Math.Abs(Class263.RelativeBearingTo(Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), current3.GetLatitude(null), current3.GetLongitude(null)), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null)))) < 45f)
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									bool flag4 = false;
									foreach (Contact current4 in this.ParentPlatform.GetSide(false).GetContactList())
									{
										if (current4.contactType == Contact_Base.ContactType.Submarine && current4.ActualUnit == ((Weapon)contact_0.ActualUnit).GetFiringParent())
										{
											flag4 = true;
											break;
										}
									}
									if (!flag4)
									{
										Contact contact2 = new Contact(((Weapon)contact_0.ActualUnit).GetFiringParent(), 0);
										contact2.SetLatitude(null, contact_0.ActualUnit.GetLatitude(null));
										contact2.SetLongitude(null, contact_0.ActualUnit.GetLongitude(null));
										Class258.Location[] array3 = new Class258.Location[46];
										GeoPointGenerator.GetOtherPointsAroundAGeoPoint(contact2.GetLatitude(null), contact2.GetLongitude(null), 1.0, 45, ref array3);
										List<GeoPoint> list2 = new List<GeoPoint>();
										Class258.Location[] array4 = array3;
										for (int j = 0; j < array4.Length; j++)
										{
											Class258.Location location2 = array4[j];
											list2.Add(new GeoPoint(location2.longitude, location2.latitude));
										}
										contact2.SetUncertaintyArea(list2);
										this.concurrentBag_0.Add(new Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>(contact2, ((Weapon)contact_0.ActualUnit).GetFiringParent(), new List<Sensor>(), 0f, ActiveUnit_Sensory.Enum8.const_2));
									}
								}
							}
						}
						else
						{
							Contact contact3 = this.ParentPlatform.GetSide(false).GetContactObservableDictionary()[weapon2.GetFiringParent().GetGuid()];
							if (!Information.IsNothing(contact3) && contact3.GetPostureStance(this.ParentPlatform.GetSide(false)) != Misc.PostureStance.Hostile && !Information.IsNothing(weapon2.GetWeaponAI().GetPrimaryTarget()) && weapon2.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint && weapon2.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint)
							{
								Contact primaryTarget = weapon2.GetWeaponAI().GetPrimaryTarget();
								if (!Information.IsNothing(primaryTarget.ActualUnit) && (primaryTarget.ActualUnit.GetSide(false) == this.ParentPlatform.GetSide(false) || primaryTarget.ActualUnit.GetSide(false).GetPostureStance(this.ParentPlatform.GetSide(false)) == Misc.PostureStance.Friendly))
								{
									bool flag5 = false;
									string text = "";
									if (contact3.GetIdentificationStatus() > Contact_Base.IdentificationStatus.KnownDomain)
									{
										flag5 = true;
										text = " (原因: 目标类型)";
									}
									if (!flag5)
									{
										foreach (int current5 in contact3.GetEmissionContainerObDictionary().Keys)
										{
											if (contact3.GetEmissionContainerObDictionary()[current5].method_0(current5, this.ParentPlatform.m_Scenario).IsFireControlRadar())
											{
												flag5 = true;
												text = " (原因: 电磁辐射模式)";
												break;
											}
										}
									}
									if (flag5)
									{
										contact3.MarkAs(this.ParentPlatform.GetSide(false), false, Misc.PostureStance.Hostile);
										this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
										{
											"目标: ",
											contact3.Name,
											"很可能是",
											contact_0.Name,
											"的发射单元，视为敌对方!",
											text
										}), LoggedMessage.MessageType.ContactChange, 0, null, this.ParentPlatform.GetSide(false), new GeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null)));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x0013267C File Offset: 0x0013087C
		protected virtual void UpdateContactInfo(Unit detectedUnit, Side side_)
		{
			try
			{
				bool flag = side_.GetContactsObDictionary().ContainsKey(detectedUnit.GetGuid());
				bool flag2 = side_.lazyNewContactDictionary.Value.ContainsKey(detectedUnit.GetGuid());
				Contact contact;
				if (flag)
				{
					contact = side_.GetContactsObDictionary()[detectedUnit.GetGuid()];
				}
				else
				{
					if (flag2)
					{
						return;
					}
					contact = new Contact((ActiveUnit)detectedUnit, 0);
				}
				contact.SideIsKnown = true;
				if (flag)
				{
					contact.SetCurrentHeading(detectedUnit.GetCurrentHeading());
					contact.SetCurrentSpeed(detectedUnit.GetCurrentSpeed());
					contact.SetAltitude_ASL(false, detectedUnit.GetCurrentAltitude_ASL(false));
					contact.SetLongitude(null, detectedUnit.GetLongitude(null));
					contact.SetLatitude(null, detectedUnit.GetLatitude(null));
				}
				else
				{
					ActiveUnit_Sensory.AddNewContact(contact, ref this.ParentPlatform.m_Scenario, side_, detectedUnit, this.ParentPlatform, Contact_Base.IdentificationStatus.PreciseID);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100250", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x001327C4 File Offset: 0x001309C4
		private void method_27(Contact theTarget, float float_5)
		{
			if (!theTarget.Heading_Known || !theTarget.Speed_Known || !theTarget.Altitude_Known)
			{
				float num = this.method_48(theTarget, float_5);
				if (num >= 0.5f)
				{
					if (num < 0.65f)
					{
						theTarget.Speed_Known = true;
					}
					else if (num < 0.85f)
					{
						theTarget.Speed_Known = true;
						theTarget.Heading_Known = true;
					}
					else
					{
						theTarget.Speed_Known = true;
						theTarget.Heading_Known = true;
						theTarget.Altitude_Known = true;
					}
				}
			}
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00132848 File Offset: 0x00130A48
		private void method_28(Contact contact_0, float float_5)
		{
			if (!contact_0.Heading_Known || !contact_0.Speed_Known)
			{
				if (Information.IsNothing(contact_0.GetUncertaintyArea()))
				{
					contact_0.Speed_Known = true;
					contact_0.Heading_Known = true;
				}
				else
				{
					float num = this.method_47(contact_0, float_5);
					if (num >= 0.5f)
					{
						if (num < 0.75f)
						{
							contact_0.Heading_Known = true;
						}
						else
						{
							contact_0.Speed_Known = true;
							contact_0.Heading_Known = true;
						}
					}
				}
			}
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x001328C0 File Offset: 0x00130AC0
		public void method_29(ActiveUnit activeUnit_1, Contact contact_0, Sensor sensor_0)
		{
			Contact.HostUnitOfRadarRadiation hostUnitOfRadarRadiation = new Contact.HostUnitOfRadarRadiation();
			hostUnitOfRadarRadiation.UID = activeUnit_1.GetGuid();
			hostUnitOfRadarRadiation.RA = 0f;
			hostUnitOfRadarRadiation.identificationStatus = Contact_Base.IdentificationStatus.KnownDomain;
			contact_0.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)).Add(hostUnitOfRadarRadiation);
			LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.ContactChange;
			if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
			{
				messageType_ = LoggedMessage.MessageType.CommsIsolatedMessage;
			}
			this.ParentPlatform.LogMessage(string.Concat(new string[]
			{
				"New ",
				activeUnit_1.GetUnitTypeName().ToLower(),
				" spotted on ",
				contact_0.Name,
				" by ",
				this.ParentPlatform.Name,
				" (传感器: ",
				sensor_0.Name,
				"). "
			}), messageType_, 0, false, new GeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null)));
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x001329B8 File Offset: 0x00130BB8
		private void method_30(AirFacility airFacility_, Sensor sensor_, Contact target_, float rangeToTarget_)
		{
			if (airFacility_.method_35() && airFacility_.GetHostedAircrafts().Count != 0)
			{
				LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.ContactChange;
				if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
				{
					messageType_ = LoggedMessage.MessageType.CommsIsolatedMessage;
				}
				float num = 0f;
				foreach (Aircraft current in airFacility_.GetHostedAircrafts().Values)
				{
					num = sensor_.GetDetectionRange(this.ParentPlatform, current);
					if (num * 3f >= rangeToTarget_)
					{
						Contact.HostUnitOfRadarRadiation hostUnitOfRadarRadiation = null;
						foreach (Contact.HostUnitOfRadarRadiation current2 in target_.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)))
						{
							if (Operators.CompareString(current2.UID, current.GetGuid(), false) == 0)
							{
								hostUnitOfRadarRadiation = current2;
								hostUnitOfRadarRadiation.RA = 0f;
								break;
							}
						}
						if (!Information.IsNothing(hostUnitOfRadarRadiation))
						{
							if (rangeToTarget_ < num)
							{
								if (hostUnitOfRadarRadiation.identificationStatus < Contact_Base.IdentificationStatus.KnownClass)
								{
									hostUnitOfRadarRadiation.identificationStatus = Contact_Base.IdentificationStatus.KnownClass;
									this.ParentPlatform.LogMessage(string.Concat(new string[]
									{
										"Aircraft previously spotted on ",
										target_.Name,
										" has been identified as: ",
										current.UnitClass,
										" (recon by: ",
										this.ParentPlatform.Name,
										" - Sensor: ",
										sensor_.Name,
										"). "
									}), messageType_, 0, false, new GeoPoint(target_.GetLongitude(null), target_.GetLatitude(null)));
								}
							}
							else if (rangeToTarget_ < num * 2f && hostUnitOfRadarRadiation.identificationStatus < Contact_Base.IdentificationStatus.KnownType)
							{
								hostUnitOfRadarRadiation.identificationStatus = Contact_Base.IdentificationStatus.KnownType;
								this.ParentPlatform.LogMessage(string.Concat(new string[]
								{
									"Aircraft previously spotted on ",
									target_.Name,
									" has been type-classified as: ",
									current.GetUnitTypeDescription(),
									" (recon by: ",
									this.ParentPlatform.Name,
									" - Sensor: ",
									sensor_.Name,
									"). "
								}), messageType_, 0, false, new GeoPoint(target_.GetLongitude(null), target_.GetLatitude(null)));
							}
							hostUnitOfRadarRadiation.RA = 0f;
						}
						else
						{
							this.method_29(current, target_, sensor_);
						}
					}
				}
				Lazy<List<Contact.HostUnitOfRadarRadiation>> lazy = new Lazy<List<Contact.HostUnitOfRadarRadiation>>();
				foreach (Contact.HostUnitOfRadarRadiation current3 in target_.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)))
				{
					ActiveUnit activeUnit = null;
					this.ParentPlatform.m_Scenario.GetActiveUnits().TryGetValue(current3.UID, ref activeUnit);
					if (Information.IsNothing(activeUnit))
					{
						if (rangeToTarget_ < num * 2f)
						{
							lazy.Value.Add(current3);
						}
					}
					else if (!airFacility_.GetParentPlatform().GetDockingOps().GetDockedUnits().Contains(activeUnit) && (!activeUnit.IsAircraft || !airFacility_.GetParentPlatform().GetAirOps().GetHostedAircrafts().Contains((Aircraft)activeUnit)) && rangeToTarget_ < num * 2f)
					{
						lazy.Value.Add(current3);
					}
				}
				foreach (Contact.HostUnitOfRadarRadiation current4 in lazy.Value)
				{
					target_.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)).Remove(current4);
				}
			}
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00132E20 File Offset: 0x00131020
		public void method_31(Contact contact_, ActiveUnit TargetUnit_, Sensor sensor_)
		{
			checked
			{
				if ((Information.IsNothing(contact_.ActualUnit) || !contact_.ActualUnit.IsSubmarine) && !TargetUnit_.IsAircraft && sensor_.IsRadarSonarVisual(true, false))
				{
					float slantRange = this.ParentPlatform.GetSlantRange(TargetUnit_, 0f);
					AirFacility[] airFacilities = TargetUnit_.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility_ = airFacilities[i];
						this.method_30(airFacility_, sensor_, contact_, slantRange);
					}
					DockFacility[] dockFacilities = TargetUnit_.GetDockFacilities();
					for (int j = 0; j < dockFacilities.Length; j++)
					{
						DockFacility dockFacility_ = dockFacilities[j];
						this.method_75(dockFacility_, sensor_, contact_, slantRange);
					}
				}
			}
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00132EC8 File Offset: 0x001310C8
		public void TargetBattleDamageAssessment(Contact contact_, ActiveUnit TargetUnit_, Sensor sensor_)
		{
			try
			{
				if ((Information.IsNothing(contact_.ActualUnit) || !contact_.ActualUnit.IsSubmarine || ((Submarine)contact_.ActualUnit).IsShallowerThanPeriscopeDepth()) && !TargetUnit_.IsAircraft && sensor_.IsRadarSonarVisual(true, true))
				{
					string text = Misc.GetBDAString(contact_.GetBattleDamageAssessment(this.ParentPlatform.GetSide(false))) + Misc.GetFireIntensityString(contact_.GetBDA_Fire(this.ParentPlatform.GetSide(false)));
					if (this.ParentPlatform.IsShip || this.ParentPlatform.IsSubmarine)
					{
						text += Misc.GetFloodingIntensityString(contact_.GetBDA_Flood(this.ParentPlatform.GetSide(false)));
					}
					Sensor.SensorType sensorType = sensor_.sensorType;
					if (sensorType != Sensor.SensorType.Radar)
					{
						if (sensorType - Sensor.SensorType.Visual <= 1)
						{
							this.TargetBDA(contact_, TargetUnit_, sensor_);
							this.TargetBDA_Fire(contact_, TargetUnit_, sensor_);
							this.TargetBDA_Flood(contact_, TargetUnit_, sensor_);
						}
					}
					else if (sensor_.sensorCode.Classification_BrilliantWeapon)
					{
						this.TargetBDA(contact_, TargetUnit_, sensor_);
					}
					if (sensor_.IsSonar() && !sensor_.IsEmmitting())
					{
						this.TargetBDA_Flood(contact_, TargetUnit_, sensor_);
					}
					string text2 = Misc.GetBDAString(contact_.GetBattleDamageAssessment(this.ParentPlatform.GetSide(false))) + Misc.GetFireIntensityString(contact_.GetBDA_Fire(this.ParentPlatform.GetSide(false)));
					if (this.ParentPlatform.IsShip || this.ParentPlatform.IsSubmarine)
					{
						text2 += Misc.GetFloodingIntensityString(contact_.GetBDA_Flood(this.ParentPlatform.GetSide(false)));
					}
					if (string.CompareOrdinal(text2, text) != 0 && !string.IsNullOrEmpty(text))
					{
						this.ReportBDAStatusChange(contact_, this.ParentPlatform.GetSide(false));
					}
					if (!Information.IsNothing(contact_))
					{
						contact_.TS_BDA = 0f;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100251", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00133110 File Offset: 0x00131310
		public void ReportBDAStatusChange(Contact contact_0, Side side_0)
		{
			try
			{
				if (!Information.IsNothing(contact_0.ActualUnit))
				{
					string text = this.ParentPlatform.Name + "报告战损评估状态变更，目标: " + contact_0.Name;
					if (contact_0.GetBattleDamageAssessment(side_0).HasValue)
					{
						text = text + " - " + Misc.GetBDAString(contact_0.GetBattleDamageAssessment(side_0));
					}
					if (contact_0.GetBDA_Fire(side_0).HasValue)
					{
						text = text + " - " + Misc.GetFireIntensityString(contact_0.GetBDA_Fire(side_0));
					}
					if ((contact_0.ActualUnit.IsShip || contact_0.ActualUnit.IsSubmarine) && contact_0.GetBDA_Flood(side_0).HasValue)
					{
						text = text + " - " + Misc.GetFloodingIntensityString(contact_0.GetBDA_Flood(side_0));
					}
					long messageIncrement = this.ParentPlatform.m_Scenario.GetMessageIncrement();
					this.ParentPlatform.m_Scenario.AddMessageIncrement();
					LoggedMessage value = new LoggedMessage(messageIncrement, text, LoggedMessage.MessageType.ContactChange, this.ParentPlatform.m_Scenario.GetCurrentTime(false), this.ParentPlatform.GetGuid(), 0, side_0, new GeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null)));
					this.lazy_0.Value.TryAdd(messageIncrement, value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100252", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x001332D0 File Offset: 0x001314D0
		private void TargetBDA(Contact theTarget, ActiveUnit TargetUnit_, Sensor sensor_)
		{
			try
			{
				if (!Information.IsNothing(TargetUnit_) && !TargetUnit_.IsAircraft && !TargetUnit_.IsWeapon)
				{
					float damagePts = TargetUnit_.GetDamage().GetDamagePts();
					if (damagePts == 0f)
					{
						theTarget.SetBattleDamageAssessment(this.ParentPlatform.GetSide(false), new Contact._BattleDamageAssessment?(Contact._BattleDamageAssessment.NoDamage));
					}
					else if (damagePts < 20f)
					{
						theTarget.SetBattleDamageAssessment(this.ParentPlatform.GetSide(false), new Contact._BattleDamageAssessment?(Contact._BattleDamageAssessment.LightDamage));
					}
					else if (damagePts < 50f)
					{
						theTarget.SetBattleDamageAssessment(this.ParentPlatform.GetSide(false), new Contact._BattleDamageAssessment?(Contact._BattleDamageAssessment.MediumDamage));
					}
					else if (damagePts < 100f)
					{
						theTarget.SetBattleDamageAssessment(this.ParentPlatform.GetSide(false), new Contact._BattleDamageAssessment?(Contact._BattleDamageAssessment.HeavyDamage));
					}
					else
					{
						theTarget.SetBattleDamageAssessment(this.ParentPlatform.GetSide(false), new Contact._BattleDamageAssessment?(Contact._BattleDamageAssessment.Destroyed));
					}
				}
				else
				{
					theTarget.SetBattleDamageAssessment(this.ParentPlatform.GetSide(false), null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100253", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00133438 File Offset: 0x00131638
		private void TargetBDA_Fire(Contact contact_, ActiveUnit targetUnit_, Sensor sensor_)
		{
			try
			{
				if (!Information.IsNothing(targetUnit_) && !targetUnit_.IsAircraft && !targetUnit_.IsWeapon)
				{
					contact_.SetBDA_Fire(this.ParentPlatform.GetSide(false), new ActiveUnit_Damage.FireIntensityLevel?(targetUnit_.GetDamage().GetFireIntensityLevel()));
				}
				else
				{
					contact_.SetBDA_Fire(this.ParentPlatform.GetSide(false), null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100254", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x001334F0 File Offset: 0x001316F0
		private void TargetBDA_Flood(Contact contact_, ActiveUnit targetUnit_, Sensor sensor_)
		{
			try
			{
				if (!Information.IsNothing(targetUnit_) && !targetUnit_.IsAircraft && !targetUnit_.IsWeapon)
				{
					contact_.SetBDA_Flood(this.ParentPlatform.GetSide(false), new ActiveUnit_Damage.FloodingIntensityLevel?(targetUnit_.GetDamage().GetFloodingIntensityLevel()));
				}
				else
				{
					contact_.SetBDA_Flood(this.ParentPlatform.GetSide(false), null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100255", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x001335A8 File Offset: 0x001317A8
		private Contact_Base.IdentificationStatus? GetIdentificationStatusFromNCTR(Contact contact_, ActiveUnit targetUnit_, Sensor sensor_, float RangeToTarget_)
		{
			Contact_Base.IdentificationStatus? identificationStatus = null;
			Contact_Base.IdentificationStatus? result;
			try
			{
				if (!sensor_.sensorCode.NCTR_JEM && !sensor_.sensorCode.NCTR_NBILST)
				{
					identificationStatus = null;
				}
				else if (contact_.contactType != Contact_Base.ContactType.Air)
				{
					identificationStatus = null;
				}
				else if (contact_.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
				{
					identificationStatus = null;
				}
				else
				{
					if (sensor_.sensorCode.NCTR_JEM && Math.Abs(this.ParentPlatform.RelativeBearingTo(targetUnit_, true)) <= 15f)
					{
						float num = 0.75f;
						float num2 = 0.5f;
						if (sensor_.IsContinousTrackingCapable())
						{
							num = (float)((double)num * 1.25);
							num2 = (float)((double)num2 * 1.25);
						}
						GlobalVariables.TechGenerationClass techGenerationClass = sensor_.techGenerationClass;
						if (techGenerationClass - GlobalVariables.TechGenerationClass.Early1950s > 3)
						{
							if (techGenerationClass - GlobalVariables.TechGenerationClass.Early1970s <= 2)
							{
								GlobalVariables.ProficiencyLevel? proficiencyLevel = this.ParentPlatform.GetProficiencyLevel();
								int? num3 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num = (float)((double)num * 0.25);
									num2 = (float)((double)num2 * 0.25);
								}
								else
								{
									num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										num = (float)((double)num * 0.5);
										num2 = (float)((double)num2 * 0.5);
									}
									else
									{
										num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										bool? flag2;
										bool? flag = flag2 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null);
										bool? flag3;
										bool? flag4;
										if (flag.HasValue && flag2.GetValueOrDefault())
										{
											flag3 = new bool?(true);
										}
										else
										{
											num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											flag = (flag4 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null));
											flag3 = (flag.HasValue ? (flag2 | flag4.GetValueOrDefault()) : null);
										}
										bool? flag5;
										flag4 = (flag5 = flag3);
										bool? flag6;
										bool? flag7;
										if (flag4.HasValue && flag5.GetValueOrDefault())
										{
											flag6 = new bool?(true);
										}
										else
										{
											num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											flag4 = (flag7 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null));
											flag6 = (flag4.HasValue ? (flag5 | flag7.GetValueOrDefault()) : null);
										}
										flag7 = flag6;
										flag7.GetValueOrDefault();
									}
								}
							}
						}
						else
						{
							GlobalVariables.ProficiencyLevel? proficiencyLevel2 = this.ParentPlatform.GetProficiencyLevel();
							int? num3 = proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null;
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num = (float)((double)num * 0.1);
								num2 = (float)((double)num2 * 0.1);
							}
							else
							{
								num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num = (float)((double)num * 0.25);
									num2 = (float)((double)num2 * 0.25);
								}
								else
								{
									num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										num = (float)((double)num * 0.5);
										num2 = (float)((double)num2 * 0.5);
									}
									else
									{
										num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
										if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												num = (float)((double)num * 1.5);
												num2 = (float)((double)num2 * 1.5);
											}
										}
									}
								}
							}
						}
						float num4 = RangeToTarget_ / sensor_.MaxRange;
						if (num4 <= num)
						{
						}
						if (num4 <= num2)
						{
							identificationStatus = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
							result = identificationStatus;
							return result;
						}
					}
					if (sensor_.sensorCode.NCTR_NBILST)
					{
						float num5 = 0.6f;
						float num6 = 0.3f;
						GlobalVariables.TechGenerationClass techGenerationClass2 = sensor_.techGenerationClass;
						if (techGenerationClass2 - GlobalVariables.TechGenerationClass.Early1950s > 3)
						{
							if (techGenerationClass2 - GlobalVariables.TechGenerationClass.Early1970s <= 2)
							{
								GlobalVariables.ProficiencyLevel? proficiencyLevel3 = this.ParentPlatform.GetProficiencyLevel();
								int? num3 = proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null;
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num5 = (float)((double)num5 * 0.25);
									num6 = (float)((double)num6 * 0.25);
								}
								else
								{
									num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										num5 = (float)((double)num5 * 0.5);
										num6 = (float)((double)num6 * 0.5);
									}
									else
									{
										num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
										bool? flag4;
										bool? flag = flag4 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null);
										bool? flag2;
										bool? flag8;
										if (flag.HasValue && flag4.GetValueOrDefault())
										{
											flag8 = new bool?(true);
										}
										else
										{
											num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
											flag = (flag2 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null));
											flag8 = (flag.HasValue ? (flag4 | flag2.GetValueOrDefault()) : null);
										}
										bool? flag7;
										flag2 = (flag7 = flag8);
										bool? flag5;
										bool? flag9;
										if (flag2.HasValue && flag7.GetValueOrDefault())
										{
											flag9 = new bool?(true);
										}
										else
										{
											num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
											flag2 = (flag5 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null));
											flag9 = (flag2.HasValue ? (flag7 | flag5.GetValueOrDefault()) : null);
										}
										flag5 = flag9;
										flag5.GetValueOrDefault();
									}
								}
							}
						}
						else
						{
							GlobalVariables.ProficiencyLevel? proficiencyLevel4 = this.ParentPlatform.GetProficiencyLevel();
							int? num3 = proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null;
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num5 = (float)((double)num5 * 0.1);
								num6 = (float)((double)num6 * 0.1);
							}
							else
							{
								num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
								if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num5 = (float)((double)num5 * 0.25);
									num6 = (float)((double)num6 * 0.25);
								}
								else
								{
									num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										num5 = (float)((double)num5 * 0.5);
										num6 = (float)((double)num6 * 0.5);
									}
									else
									{
										num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
										if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												num5 = (float)((double)num5 * 1.5);
												num6 = (float)((double)num6 * 1.5);
											}
										}
									}
								}
							}
						}
						float num7 = RangeToTarget_ / sensor_.MaxRange;
						if (num7 >= num5)
						{
						}
						if (num7 >= num6)
						{
							identificationStatus = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100256", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = identificationStatus;
			return result;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00134148 File Offset: 0x00132348
		private Contact_Base.IdentificationStatus method_38(Contact contact_, ActiveUnit activeUnit_, Sensor sensor_)
		{
			Contact_Base.IdentificationStatus identificationStatus;
			Contact_Base.IdentificationStatus result;
			try
			{
				if (contact_.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
				{
					identificationStatus = Contact_Base.IdentificationStatus.Unknown;
				}
				else if (contact_.float_10 < 15f)
				{
					identificationStatus = Contact_Base.IdentificationStatus.Unknown;
				}
				else if (!contact_.HasEmissionContainer())
				{
					identificationStatus = Contact_Base.IdentificationStatus.Unknown;
				}
				else
				{
					Scenario scenario = this.ParentPlatform.m_Scenario;
					GlobalVariables.ActiveUnitType activeUnitType;
					switch (contact_.contactType)
					{
					case Contact_Base.ContactType.Air:
						activeUnitType = GlobalVariables.ActiveUnitType.Aircraft;
						goto IL_9A;
					case Contact_Base.ContactType.Missile:
					case Contact_Base.ContactType.Torpedo:
						activeUnitType = GlobalVariables.ActiveUnitType.Weapon;
						goto IL_9A;
					case Contact_Base.ContactType.Surface:
						activeUnitType = GlobalVariables.ActiveUnitType.Ship;
						goto IL_9A;
					case Contact_Base.ContactType.Submarine:
						activeUnitType = GlobalVariables.ActiveUnitType.Submarine;
						goto IL_9A;
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
						activeUnitType = GlobalVariables.ActiveUnitType.Facility;
						goto IL_9A;
					}
					identificationStatus = Contact_Base.IdentificationStatus.Unknown;
					result = Contact_Base.IdentificationStatus.Unknown;
					return result;
					IL_9A:
					List<int> list = new List<int>();
					foreach (int current in contact_.GetEmissionContainerObDictionary().Keys)
					{
						if (contact_.GetEmissionContainerObDictionary()[current].bool_1)
						{
							list.Add(current);
						}
					}
					if (Information.IsNothing(contact_.list_6))
					{
						contact_.list_6 = DBFunctions.smethod_10(list, activeUnitType, scenario, scenario.GetSQLiteConnection());
					}
					list = null;
					if (contact_.list_6.Count == 0)
					{
						identificationStatus = Contact_Base.IdentificationStatus.Unknown;
					}
					else
					{
						Contact_Base.IdentificationStatus identificationStatus2 = Contact_Base.IdentificationStatus.Unknown;
						if (contact_.list_6.Count == 1)
						{
							contact_.float_10 = 0f;
							identificationStatus = Contact_Base.IdentificationStatus.KnownClass;
						}
						else
						{
							HashSet<int> hashSet = new HashSet<int>();
							switch (activeUnitType)
							{
							case GlobalVariables.ActiveUnitType.Aircraft:
								using (List<int>.Enumerator enumerator2 = contact_.list_6.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										int current2 = enumerator2.Current;
										hashSet.Add(DBFunctions.GetAircraftType(ref scenario, current2));
									}
									goto IL_2E6;
								}
								break;
							case GlobalVariables.ActiveUnitType.Ship:
								break;
							case GlobalVariables.ActiveUnitType.Submarine:
								goto IL_21D;
							case GlobalVariables.ActiveUnitType.Facility:
								goto IL_262;
							case GlobalVariables.ActiveUnitType.Aimpoint:
								goto IL_2E6;
							case GlobalVariables.ActiveUnitType.Weapon:
								goto IL_2A4;
							default:
								goto IL_2E6;
							}
							using (List<int>.Enumerator enumerator3 = contact_.list_6.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									int current3 = enumerator3.Current;
									hashSet.Add(DBFunctions.GetShipType(ref scenario, current3));
								}
								goto IL_2E6;
							}
							IL_21D:
							using (List<int>.Enumerator enumerator4 = contact_.list_6.GetEnumerator())
							{
								while (enumerator4.MoveNext())
								{
									int current4 = enumerator4.Current;
									hashSet.Add(DBFunctions.GetSubmarineType(ref scenario, current4));
								}
								goto IL_2E6;
							}
							IL_262:
							using (List<int>.Enumerator enumerator5 = contact_.list_6.GetEnumerator())
							{
								while (enumerator5.MoveNext())
								{
									int current5 = enumerator5.Current;
									hashSet.Add(DBFunctions.GetFacilityCategory(ref scenario, current5));
								}
								goto IL_2E6;
							}
							IL_2A4:
							foreach (int current6 in contact_.list_6)
							{
								hashSet.Add(DBFunctions.GetWeaponType(ref scenario, current6));
							}
							IL_2E6:
							if (hashSet.Count == 1)
							{
								contact_.float_10 = 0f;
								identificationStatus2 = Contact_Base.IdentificationStatus.KnownType;
							}
							if (identificationStatus2 < Contact_Base.IdentificationStatus.KnownType)
							{
								short num = (short)(30 + (sensor_.techGenerationClass - GlobalVariables.TechGenerationClass.Early1970s));
								float heldFor = contact_.HeldFor;
								if (heldFor >= 180f)
								{
									if (heldFor < 360f)
									{
										num += 5;
									}
									else if (heldFor < 540f)
									{
										num += 10;
									}
									else if (heldFor < 720f)
									{
										num += 15;
									}
									else if (heldFor < 900f)
									{
										num += 25;
									}
									else
									{
										num += 30;
									}
								}
								int count = hashSet.Count;
								if (count < 5)
								{
									num = (short)Math.Round((double)num / 2.0);
								}
								else if (count < 10)
								{
									num = (short)Math.Round((double)num / 5.0);
								}
								else
								{
									num = (short)Math.Round((double)num / 10.0);
								}
								if (GameGeneral.GetRandom().Next(0, 101) < (int)num)
								{
									contact_.float_10 = 0f;
									identificationStatus2 = Contact_Base.IdentificationStatus.KnownType;
								}
							}
							if (contact_.list_6.Count == 1)
							{
								contact_.float_10 = 0f;
								identificationStatus2 = Contact_Base.IdentificationStatus.KnownClass;
							}
							else
							{
								byte b = (byte)(10 + (sensor_.techGenerationClass - GlobalVariables.TechGenerationClass.Early1970s));
								float heldFor2 = contact_.HeldFor;
								if (heldFor2 >= 180f)
								{
									if (heldFor2 < 360f)
									{
										b += 5;
									}
									else if (heldFor2 < 540f)
									{
										b += 10;
									}
									else if (heldFor2 < 720f)
									{
										b += 15;
									}
									else if (heldFor2 < 900f)
									{
										b += 25;
									}
									else
									{
										b += 30;
									}
								}
								int num2 = DBFunctions.smethod_9(contact_.list_6, activeUnitType, this.ParentPlatform.m_Scenario.GetSQLiteConnection());
								if (num2 < 5)
								{
									b = (byte)Math.Round((double)b / 2.0);
								}
								else if (num2 < 10)
								{
									b = (byte)Math.Round((double)b / 5.0);
								}
								else
								{
									b = (byte)Math.Round((double)b / 10.0);
								}
								if (GameGeneral.GetRandom().Next(40, 101) < (int)b)
								{
									contact_.float_10 = 0f;
									identificationStatus2 = Contact_Base.IdentificationStatus.KnownClass;
								}
							}
							hashSet = null;
							identificationStatus = identificationStatus2;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100257", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				identificationStatus = Contact_Base.IdentificationStatus.Unknown;
				ProjectData.ClearProjectError();
			}
			result = identificationStatus;
			return result;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x001347C0 File Offset: 0x001329C0
		private Contact_Base.IdentificationStatus method_39(Contact contact_, ActiveUnit targetUnit_, Sensor sensor_)
		{
			Contact_Base.IdentificationStatus result;
			try
			{
				int num = 0;
				switch (targetUnit_.method_88())
				{
				case GlobalVariables.Enum104.const_0:
					if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.VLFSonar))
					{
						num = 25;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.LFSonar))
					{
						num = 20;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.MFSonar))
					{
						num = 15;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar))
					{
						num = 10;
					}
					break;
				case GlobalVariables.Enum104.const_1:
					if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.VLFSonar))
					{
						num = 20;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.LFSonar))
					{
						num = 15;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.MFSonar))
					{
						num = 10;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar))
					{
						num = 5;
					}
					break;
				case GlobalVariables.Enum104.const_2:
					if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.VLFSonar))
					{
						num = 15;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.LFSonar))
					{
						num = 10;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.MFSonar))
					{
						num = 5;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar))
					{
						num = -1;
					}
					break;
				case GlobalVariables.Enum104.const_3:
					if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.VLFSonar))
					{
						num = 10;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.LFSonar))
					{
						num = 5;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.MFSonar))
					{
						num = -1;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar))
					{
						num = -1;
					}
					break;
				case GlobalVariables.Enum104.const_4:
					if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.VLFSonar))
					{
						num = 5;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.LFSonar))
					{
						num = -1;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.MFSonar))
					{
						num = -1;
					}
					else if (sensor_.IsSearchAndTrackFrequenciesCover(Sensor.FrequencyBand.HFSonar))
					{
						num = -1;
					}
					break;
				}
				if (num < 0)
				{
					result = Contact_Base.IdentificationStatus.Unknown;
				}
				else
				{
					float desiredSpeed = targetUnit_.GetDesiredSpeed();
					if (desiredSpeed >= 6f)
					{
						if (desiredSpeed < 12f)
						{
							num += 5;
						}
						else if (desiredSpeed < 18f)
						{
							num += 10;
						}
						else if (desiredSpeed < 24f)
						{
							num += 15;
						}
						else
						{
							num += 20;
						}
					}
					if (targetUnit_.IsSubmarine && ((Submarine)targetUnit_).GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						num += 15;
					}
					float heldFor = contact_.HeldFor;
					int num2;
					if (heldFor < 360f)
					{
						num2 = num;
					}
					else if (heldFor < 720f)
					{
						num2 = num + 5;
					}
					else if (heldFor < 1080f)
					{
						num2 = num + 10;
					}
					else if (heldFor < 1440f)
					{
						num2 = num + 15;
					}
					else if (heldFor < 1800f)
					{
						num2 = num + 25;
					}
					else
					{
						num2 = num + 30;
					}
					int num3 = (int)Math.Round((double)num2 / 2.0);
					int num4 = num2 + 20;
					int num5 = GameGeneral.GetRandom().Next(20, 101);
					if (num5 < num3)
					{
						result = Contact_Base.IdentificationStatus.PreciseID;
					}
					else if (num5 < num2)
					{
						result = Contact_Base.IdentificationStatus.KnownClass;
					}
					else if (num5 < num4)
					{
						result = Contact_Base.IdentificationStatus.KnownType;
					}
					else
					{
						result = Contact_Base.IdentificationStatus.KnownDomain;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100258", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Contact_Base.IdentificationStatus.KnownDomain;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00134BD8 File Offset: 0x00132DD8
		public static void NewContactDetected(ref Contact theContact, ref Scenario theScen, Side theDetectingSide, Unit theDetectedUnit, ActiveUnit DetectorUnit = null, Contact_Base.IdentificationStatus IDStatus = Contact_Base.IdentificationStatus.KnownDomain, List<Sensor> DetectingSensors = null)
		{
			try
			{
				List<GeoPoint> uncertaintyArea = null;
				ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = null;
				float rCTT = 0f;
				if (!Information.IsNothing(theContact))
				{
					if (!Information.IsNothing(theContact.GetUncertaintyArea()))
					{
						uncertaintyArea = theContact.GetUncertaintyArea();
					}
					if (theContact.HasEmissionContainer())
					{
						emissionContainerObDictionary = theContact.GetEmissionContainerObDictionary();
					}
					rCTT = theContact.GetRCTT();
				}

                //ZSP Emission
                //if (theContact.HasEmissionContainer())
                //{
                //    emissionContainerObDictionary = theContact.GetEmissionContainerObDictionary();
                //}

                theDetectingSide.ContactAutoIncrement++;
				theContact = new Contact((ActiveUnit)theDetectedUnit, theDetectingSide.ContactAutoIncrement);
				theContact.SetUncertaintyArea(uncertaintyArea);
				theContact.SetEmissionContainerObDictionary(emissionContainerObDictionary);
				theContact.SetRCTT(rCTT);
				if (Information.IsNothing(DetectorUnit))
				{
					theContact.TargetIdentification(theScen, theDetectingSide, null, null, false, true, IDStatus);
				}
				else
				{
					theContact.TargetIdentification(theScen, theDetectingSide, null, null, false, DetectorUnit.GetCommStuff().IsNotOutOfComms(), IDStatus);
				}
				theContact.OriginalDetectorSide = theDetectingSide;
				ActiveUnit_Sensory.smethod_2(ref theContact, (ActiveUnit)theDetectedUnit, true, null);
				if (!Information.IsNothing(DetectorUnit))
				{
					if (DetectorUnit.GetCommStuff().IsNotOutOfComms())
					{
						theDetectingSide.AddToContactList_OnGrid(theContact);
					}
					else
					{
						DetectorUnit.GetSensory().ContactList_OffGrid[theDetectedUnit.GetGuid()] = theContact;
					}
				}
				else
				{
					theDetectingSide.AddToContactList_OnGrid(theContact);
				}
				if (theDetectedUnit.IsActiveUnit() && ((ActiveUnit)theDetectedUnit).IsAutoDetectable(theDetectingSide))
				{
					theContact.SetIsPreciselyLocatedOnThisPulse(true);
					theContact.Heading_Known = true;
					theContact.Speed_Known = true;
					theContact.Altitude_Known = true;
				}
				else
				{
					if (!Information.IsNothing(DetectingSensors))
					{
						using (List<Sensor>.Enumerator enumerator = DetectingSensors.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.IsPreciselyLocatedEnable())
								{
									theContact.SetIsPreciselyLocatedOnThisPulse(true);
									break;
								}
							}
						}
					}
					string text = "";
					try
					{
						if (Information.IsNothing(theContact.GetUncertaintyArea()))
						{
							text = Math.Round((double)DetectorUnit.GetHorizontalRange(theContact), 1).ToString();
						}
						else
						{
							text = "预测：" + Math.Round((double)DetectorUnit.GetHorizontalRange(theContact), 0).ToString();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200012", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						text = "[unspecified]";
						ProjectData.ClearProjectError();
					}
					string text2;
					try
					{
						text2 = ((int)Math.Round((double)DetectorUnit.GetAI().GetAzimuth(theContact))).ToString();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 200015", ex4.Message);
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						text2 = "[unspecified]";
						ProjectData.ClearProjectError();
					}
					LoggedMessage.MessageType messageType_;
					if (!Information.IsNothing(DetectorUnit) && !DetectorUnit.GetCommStuff().IsNotOutOfComms())
					{
						messageType_ = LoggedMessage.MessageType.CommsIsolatedMessage;
					}
					else if (theContact.ActualUnit.IsWeapon & !theContact.ActualUnit.IsDecoy())
					{
						messageType_ = LoggedMessage.MessageType.NewWeaponContact;
					}
					else
					{
						switch (theContact.ActualUnit.GetUnitType())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							messageType_ = LoggedMessage.MessageType.NewAirContact;
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							messageType_ = LoggedMessage.MessageType.NewSurfaceContact;
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							messageType_ = LoggedMessage.MessageType.NewUnderwaterContact;
							break;
						case GlobalVariables.ActiveUnitType.Facility:
							messageType_ = LoggedMessage.MessageType.NewGroundContact;
							break;
						default:
							messageType_ = LoggedMessage.MessageType.NewContact;
							break;
						}
					}
					string contrailOrWakeDetectedString = ActiveUnit_Sensory.GetContrailOrWakeDetectedString(DetectingSensors, theDetectedUnit, DetectorUnit);
					string text3 = "";
					if (DetectorUnit.IsAircraft && Operators.CompareString(DetectorUnit.Name, DetectorUnit.UnitClass, false) != 0)
					{
						text3 = " (" + DetectorUnit.UnitClass + ")";
					}
					if (DetectingSensors.Count == 0)
					{
						DetectorUnit.LogMessage(string.Concat(new string[]
						{
							"发现新目标! 批号：",
							theContact.Name,
							" - 探测平台 ",
							DetectorUnit.Name,
							text3,
							" 方位",
							Conversions.ToString((int)Math.Round((double)DetectorUnit.GetAI().GetAzimuth(theContact))),
							"度，距离",
							Conversions.ToString(Math.Round((double)DetectorUnit.GetHorizontalRange(theContact), 1)),
							"海里"
						}), messageType_, 1, false, new GeoPoint(theContact.GetLongitude(null), theContact.GetLatitude(null)));
					}
					else
					{
						string text4 = "";
						using (List<Sensor>.Enumerator enumerator2 = DetectingSensors.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								text4 = Misc.smethod_11(enumerator2.Current.Name) + ", ";
							}
						}
						if (DetectingSensors.Count > 0)
						{
							text4 = Strings.Left(text4, Strings.Len(text4) - 2);
						}
						DetectorUnit.LogMessage(string.Concat(new string[]
						{
							"发现新目标! 批号：",
							theContact.Name,
							" - 探测平台 ",
							DetectorUnit.Name,
							text3,
							"  [传感器: ",
							text4,
							"] 方位",
							text2,
							"度，距离",
							text,
							"海里",
							contrailOrWakeDetectedString
						}), messageType_, 1, false, new GeoPoint(theContact.GetLongitude(null), theContact.GetLatitude(null)));
					}
					foreach (IEventExporter current in theScen.GetEventExporters())
					{
						if (current.IsExportEngagementCycle())
						{
							Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
							dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), DetectorUnit.m_Scenario.TimelineID));
							if (current.IsUseZeroHour())
							{
								TimeSpan timeSpan = DetectorUnit.m_Scenario.GetCurrentTime(false).Subtract(DetectorUnit.m_Scenario.ZeroHour);
								dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
							}
							else
							{
								dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), DetectorUnit.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + DetectorUnit.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
							}
							dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), DetectorUnit.GetGuid()));
							dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), DetectorUnit.Name));
							dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), DetectorUnit.UnitClass));
							dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), DetectorUnit.GetSide(false).GetSideName()));
							dictionary.Add("CycleAction", new Tuple<Type, string>(typeof(string), "New contact"));
							dictionary.Add("ContactID", new Tuple<Type, string>(typeof(string), theContact.GetGuid()));
							dictionary.Add("ContactName", new Tuple<Type, string>(typeof(string), theContact.Name));
							dictionary.Add("ContactLongitude", new Tuple<Type, string>(typeof(double), theContact.GetLongitude(null).ToString()));
							dictionary.Add("ContactLatitude", new Tuple<Type, string>(typeof(double), theContact.GetLatitude(null).ToString()));
							dictionary.Add("ContactRangeHoriz_nm", new Tuple<Type, string>(typeof(float), DetectorUnit.GetHorizontalRange(theContact).ToString()));
							dictionary.Add("ContactRangeSlant_nm", new Tuple<Type, string>(typeof(float), DetectorUnit.GetSlantRange(theContact, 0f).ToString()));
							dictionary.Add("ContactActualUnitID", new Tuple<Type, string>(typeof(string), theContact.ActualUnit.GetGuid()));
							dictionary.Add("ContactActualUnitName", new Tuple<Type, string>(typeof(string), theContact.ActualUnit.Name));
							dictionary.Add("ContactActualUnitClass", new Tuple<Type, string>(typeof(string), theContact.ActualUnit.UnitClass));
							dictionary.Add("ContactActualUnitSide", new Tuple<Type, string>(typeof(string), theContact.ActualUnit.GetSide(false).GetSideName()));
							dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), ""));
							current.ExportEvent(ExportedEventType.EngagementCycle, dictionary, theScen);
						}
					}
					if (!Information.IsNothing(DetectorUnit) && DetectorUnit.GetCommStuff().IsNotOutOfComms())
					{
						ActiveUnit_Sensory.Delegate4 @delegate = ActiveUnit_Sensory.delegate4_0;
						if (@delegate != null)
						{
							@delegate(theDetectingSide, theContact.contactType);
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100259", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x0013563C File Offset: 0x0013383C
		private static string GetContrailOrWakeDetectedString(List<Sensor> DetectingSensors_, Unit theDetectedUnit, ActiveUnit DetectorUnit)
		{
			string text;
			string result;
			if (!Information.IsNothing(DetectingSensors_))
			{
				using (List<Sensor>.Enumerator enumerator = DetectingSensors_.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.sensorType == Sensor.SensorType.Visual)
						{
							if ((theDetectedUnit.IsShip | theDetectedUnit.IsSubmarine) & (DetectorUnit.IsAircraft | DetectorUnit.IsGuidedWeapon_RV_HGV()))
							{
								Ship._WakeDetected wakeDetected = Ship._WakeDetected.None;
								if (theDetectedUnit.IsShip)
								{
									wakeDetected = ((Ship)theDetectedUnit).GetWakeDetected();
								}
								if (theDetectedUnit.IsSubmarine)
								{
									wakeDetected = ((Submarine)theDetectedUnit).GetWakeDetected();
								}
								switch (wakeDetected)
								{
								case Ship._WakeDetected.None:
									text = " - 没探测到尾流.";
									result = text;
									return result;
								case Ship._WakeDetected.VerySmall:
									text = " - 探测到微小尾流.";
									result = text;
									return result;
								case Ship._WakeDetected.Small:
									text = " - 探测到小型尾流.";
									result = text;
									return result;
								case Ship._WakeDetected.Medium:
									text = " - 探测到中型尾流.";
									result = text;
									return result;
								case Ship._WakeDetected.Large:
									text = " - 探测到大型尾流.";
									result = text;
									return result;
								case Ship._WakeDetected.VeryLarge:
									text = " - 探测到超大型尾流.";
									result = text;
									return result;
								}
							}
							if (theDetectedUnit.IsAircraft | theDetectedUnit.IsGuidedWeapon_RV_HGV())
							{
								ActiveUnit._ContrailDetected contrailDetected = ActiveUnit._ContrailDetected.None;
								if (theDetectedUnit.IsAircraft)
								{
									contrailDetected = ((ActiveUnit)theDetectedUnit).GetContrailDetected();
								}
								if (theDetectedUnit.IsGuidedWeapon_RV_HGV())
								{
									contrailDetected = ((ActiveUnit)theDetectedUnit).GetContrailDetected();
								}
								switch (contrailDetected)
								{
								case ActiveUnit._ContrailDetected.None:
									text = " - 没探测到凝迹.";
									result = text;
									return result;
								case ActiveUnit._ContrailDetected.VerySmall:
									text = " - 探测到微小凝迹.";
									result = text;
									return result;
								case ActiveUnit._ContrailDetected.Small:
									text = " - 探测到小型凝迹.";
									result = text;
									return result;
								case ActiveUnit._ContrailDetected.Medium:
									text = " - 探测到中型凝迹.";
									result = text;
									return result;
								case ActiveUnit._ContrailDetected.Large:
									text = " - 探测到大型凝迹.";
									result = text;
									return result;
								case ActiveUnit._ContrailDetected.VeryLarge:
									text = " - 探测到超大型凝迹.";
									result = text;
									return result;
								}
							}
						}
					}
				}
			}
			text = "";
			result = text;
			return result;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00135828 File Offset: 0x00133A28
		public static void AddNewContact(Contact theContact, ref Scenario theScen, Side theDetectingSide, Unit theDetectedUnit, ActiveUnit DetectorUnit = null, Contact_Base.IdentificationStatus IDStatus = Contact_Base.IdentificationStatus.KnownDomain)
		{
			try
			{
				theDetectingSide.ContactNo++;
				theContact = new Contact((ActiveUnit)theDetectedUnit, theDetectingSide.ContactNo);
				theContact.SetUncertaintyArea(null);
				theContact.SetIsPreciselyLocatedOnThisPulse(true);
				theContact.Heading_Known = true;
				theContact.Speed_Known = true;
				theContact.Altitude_Known = true;
				theContact.TargetIdentification(theScen, theDetectingSide, null, null, false, DetectorUnit.GetCommStuff().IsNotOutOfComms(), IDStatus);
				theContact.OriginalDetectorSide = theDetectingSide;
				theContact.Age = 0f;
				theContact.SetDetectedLocation((ActiveUnit)theDetectedUnit);
				theDetectingSide.AddToNewContactDictionary(theContact);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100260", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00135910 File Offset: 0x00133B10
		public bool HasTrackingSensorForTarget(Contact Target_)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
					for (int i = 0; i < allNoneMCMSensors.Length; i++)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if (sensor.IsEmmitting() && sensor.GetTargetsTrackedForFireControl().Contains(Target_))
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100261", "");
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

		// Token: 0x06003CC8 RID: 15560 RVA: 0x001359C0 File Offset: 0x00133BC0
		public bool IsIlluminating(Contact Target_, Weapon weapon_, ref Sensor director_, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (this.ParentPlatform.IsGuidedWeapon_RV_HGV())
					{
						flag = false;
					}
					else if (!this.ParentPlatform.IsOperating())
					{
						flag = false;
					}
					else
					{
						List<ActiveUnit> list = null;
						Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.IsDirectorFor(ref weapon_))
							{
								if (sensor.IsTargetTracked(ref Target_))
								{
									flag = true;
									result = true;
									return result;
								}
								if (sensor.IsFireChannelsEnough())
								{
									if (Information.IsNothing(Target_) || Information.IsNothing(Target_.ActualUnit))
									{
										flag = false;
										result = false;
										return result;
									}
									ActiveUnit actualUnit = Target_.ActualUnit;
									if (Information.IsNothing(actualUnit))
									{
										flag = false;
										result = false;
										return result;
									}
									if (sensor.sensorType == Sensor.SensorType.Radar && Information.IsNothing(list))
									{
										list = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
									}
									if (sensor.WeaponGuidanceAttempt(this.ParentPlatform, actualUnit, this.ParentPlatform.GetHorizontalRange(Target_), list, this.ParentPlatform.IsShip, false, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar) == Sensor._DetectionAttemptResult.Success)
									{
										director_ = sensor;
										flag = true;
										result = true;
										return result;
									}
								}
							}
						}
						flag = false;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100262", "");
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

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00135B78 File Offset: 0x00133D78
		public bool IsIlluminatingTarget(Contact target_, Weapon weapon_, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
					for (int i = 0; i < allNoneMCMSensors.Length; i++)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && (sensor.IsFireChannelsEnough() || sensor.IsTargetTracked(ref target_)) && sensor.IsDirectorFor(ref weapon_))
						{
							List<ActiveUnit> list = null;
							if (sensor.sensorType == Sensor.SensorType.Radar && Information.IsNothing(list))
							{
								list = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
							}
							if (sensor.WeaponGuidanceAttempt(this.ParentPlatform, target_.ActualUnit, this.ParentPlatform.GetHorizontalRange(target_), list, this.ParentPlatform.IsShip, false, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar) == Sensor._DetectionAttemptResult.Success)
							{
								sensor.AddTargetsTrackedForFireControl(ref target_);
								if (!sensor.SemiActiveGuidedWeaponList.Contains(weapon_))
								{
									sensor.SemiActiveGuidedWeaponList.Add(weapon_);
									weapon_.SetDirector(sensor);
								}
								flag = true;
								result = true;
								return result;
							}
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100263", "");
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

        // Token: 0x06003CCA RID: 15562 RVA: 0x00135CD0 File Offset: 0x00133ED0
        //private Contact method_43(Unit TargetUnit, Sensor[] mySensors, float SlantRange, ref List<Sensor> SensorsThatMadeDetection, List<ActiveUnit> AffectingJammers, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar, bool EmissionDetectionOnly = false)

        private Contact GetContactBy(Unit TargetUnit, Sensor[] mySensors, float SlantRange, ref List<Sensor> SensorsThatMadeDetection, List<ActiveUnit> AffectingJammers, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit._LOS_Exists_Visual? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar, bool EmissionDetectionOnly = false)
		{
			Contact contact = null;
			Contact result;
			try
			{
				if (this.ParentPlatform.IsGuidedWeapon() && TargetUnit.IsGuidedWeapon() && TargetUnit.IsActiveUnit())
				{
					Contact_Base.ContactType primaryTargetType = ((ActiveUnit)TargetUnit).GetAI().GetPrimaryTargetType();
					if (!Information.IsNothing(primaryTargetType) && (primaryTargetType == Contact_Base.ContactType.Air || primaryTargetType == Contact_Base.ContactType.Missile || primaryTargetType == Contact_Base.ContactType.Orbital))
					{
						contact = null;
						result = contact;
						return result;
					}
				}
				Sensor[] array;
				if (EmissionDetectionOnly)
				{
					array = mySensors.Where(ActiveUnit_Sensory.EmissionDetectionOnlySensorFilter).ToArray<Sensor>();
				}
				else
				{
					array = mySensors;
				}
				int num = array.Length - 1;
				Contact contact2 = null;
				for (int num2 = 0; num2 <= num; num2++)
				{
					Sensor sensor = array[num2];
					if (sensor.IsOperating())
					{
						Sensor sensor2 = sensor;
						ActiveUnit activeUnit = (ActiveUnit)TargetUnit;
						if (sensor2.IsTrackingTargetUnit(ref activeUnit) && sensor.IsScanningOrTrackingThisPulse() && sensor.IsIlluminator() && sensor.WeaponGuidanceAttempt(this.ParentPlatform, (ActiveUnit)TargetUnit, SlantRange, AffectingJammers, this.ParentPlatform.IsShip, false, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar) == Sensor._DetectionAttemptResult.Success)
						{
							SensorsThatMadeDetection.Add(sensor);
							if (Information.IsNothing(contact2))
							{
								contact2 = new Contact((ActiveUnit)TargetUnit, 0);
							}
						}
						if (sensor.IsScanningOrTrackingThisPulse() && sensor.IsSearchAndTrackSensor() && (sensor.sensorType != Sensor.SensorType.Radar || (sensor.sensorCode.PassiveElectronicallyScannedArray && !sensor.sensorCode.ActiveElectronicallyScannedArray && !sensor.sensorCode.InterruptedContinuousWaveIllumination) || sensor.GetTargetsTrackedForFireControl().Count <= 0))
						{
							List<GeoPoint> list = null;
							Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
							if (sensor.SensorDetectionAttempt(Sensor.DetectionAttemptType.VolumeSearch, this.ParentPlatform, (ActiveUnit)TargetUnit, ref list, SlantRange, ref lazy, AffectingJammers, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar))
							{
								SensorsThatMadeDetection.Add(sensor);
								if (Information.IsNothing(contact2))
								{
									contact2 = new Contact((ActiveUnit)TargetUnit, 0);
									if (!Information.IsNothing(list))
									{
										contact2.SetUncertaintyArea(list);
									}
								}
								else if (!Information.IsNothing(list))
								{
									contact2.SetUncertaintyArea(list);
								}
								if (sensor.IsPreciselyLocatedEnable())
								{
									contact2.SetIsPreciselyLocatedOnThisPulse(true);
								}
								try
								{
									foreach (int current in lazy.Value.Keys)
									{
										if (contact2.GetEmissionContainerObDictionary().ContainsKey(current))
										{
											contact2.GetEmissionContainerObDictionary()[current].elapsedTime = 0f;
											if (lazy.Value[current].bool_0)
											{
												contact2.GetEmissionContainerObDictionary()[current].bool_0 = true;
											}
											if (lazy.Value[current].bool_1)
											{
												contact2.GetEmissionContainerObDictionary()[current].bool_1 = true;
											}
										}
										else
										{
											contact2.GetEmissionContainerObDictionary().Add(current, new EmissionContainer(0.0, lazy.Value[current].bool_0, lazy.Value[current].bool_1));
										}
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 101169", "");
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
							}
						}
					}
				}
				contact = contact2;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100264", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				contact = null;
				ProjectData.ClearProjectError();
			}
			result = contact;
			return result;
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x001360F0 File Offset: 0x001342F0
		public void DoScanningAndDetecting(Sensor[] sensorArray_)
		{
			try
			{
				for (int i = 0; i < sensorArray_.Length; i = checked(i + 1))
				{
					Sensor sensor = sensorArray_[i];
					if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
					{
						sensor.NextScan--;
						sensor.OODADetectionCycle--;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100265", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x0013618C File Offset: 0x0013438C
		public void ScheduleNextDetectionCycle(Sensor[] sensorArray_)
		{
			checked
			{
				try
				{
					for (int i = 0; i < sensorArray_.Length; i++)
					{
						Sensor sensor = sensorArray_[i];
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor.IsScanningOrTrackingThisPulse())
						{
							sensor.NextScan = sensor.GetScanInterval();
							if (sensor.IsEndOfDetectionCycle() && !Information.IsNothing(sensor.GetParentPlatform()))
							{
								sensor.OODADetectionCycle = (int)sensor.GetParentPlatform().OODADetectionCycle;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100266", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00136248 File Offset: 0x00134448
		public bool HasOperationalDippingSonar()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
					for (int i = 0; i < allNoneMCMSensors.Length; i++)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if (sensor.IsDippingSonar() && sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100267", "");
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

		// Token: 0x06003CCE RID: 15566 RVA: 0x001362F4 File Offset: 0x001344F4
		public float method_47(Contact contact_0, float float_5)
		{
			float result = 0f;
			try
			{
				int num = (int)Math.Round((double)contact_0.HeldFor);
				if (num == 0)
				{
					result = 0f;
				}
				else if (float_5 < 10f)
				{
					result = (float)Math.Min((double)num / 600.0, 0.99);
				}
				else if (float_5 < 25f)
				{
					result = (float)Math.Min((double)num / 900.0, 0.99);
				}
				else if (float_5 < 50f)
				{
					result = (float)Math.Min((double)num / 1800.0, 0.99);
				}
				else
				{
					result = (float)Math.Min((double)num / 3600.0, 0.99);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100268", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.99f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00136420 File Offset: 0x00134620
		public float method_48(Contact theTarget, float float_5)
		{
			float result = 0f;
			try
			{
				if (Information.IsNothing(theTarget.GetUncertaintyArea()))
				{
					result = 1f;
				}
				else
				{
					int num = (int)Math.Round((double)theTarget.HeldFor);
					if (num == 0)
					{
						result = 0f;
					}
					else if (float_5 < 2.5f)
					{
						result = (float)Math.Min((double)num / 600.0, 0.99);
					}
					else if (float_5 < 5f)
					{
						result = (float)Math.Min((double)num / 900.0, 0.99);
					}
					else if (float_5 < 10f)
					{
						result = (float)Math.Min((double)num / 1800.0, 0.99);
					}
					else
					{
						result = (float)Math.Min((double)num / 3600.0, 0.99);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100269", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.99f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00136568 File Offset: 0x00134768
		public List<GeoPoint> GetDetectionAOU(Sensor sensor_, Unit unit_, float float_5, ObservableDictionary<int, EmissionContainer> observableDictionary_2)
		{
			List<GeoPoint> result = null;
			if (Information.IsNothing(this.ParentPlatform))
			{
				result = null;
			}
			else if (Information.IsNothing(this.ParentPlatform.GetSide(false)))
			{
				result = null;
			}
			else
			{
				bool flag = false;
				try
				{
					float num = 0f;
					if (sensor_.sensorType == Sensor.SensorType.ESM)
					{
						Contact contact = null;
						this.ParentPlatform.GetSide(false).GetContactObservableDictionary().TryGetValue(unit_.GetGuid(), ref contact);
						if (!Information.IsNothing(contact) && sensor_.sensorRole != Sensor._SensorRole.RWR_RadarWarningReceiver && float_5 <= 300f)
						{
							float num2 = this.method_47(contact, float_5);
							num = float_5 * (1f - num2);
							flag = true;
						}
					}
					else if (sensor_.IsSonar() && !sensor_.IsEmmitting())
					{
						float num3 = (float)((double)SonarEnvironment.GetConvergenceZoneIncrement(this.ParentPlatform.GetLatitude(null)) - 2.5);
						if (float_5 < num3)
						{
							Contact contact2 = null;
							this.ParentPlatform.GetSide(false).GetContactObservableDictionary().TryGetValue(unit_.GetGuid(), ref contact2);
							if (!Information.IsNothing(contact2) && float_5 <= 20f)
							{
								float num4 = this.method_48(contact2, float_5);
								num = float_5 * (1f - num4);
								flag = true;
							}
						}
					}
					else if (sensor_.sensorType == Sensor.SensorType.Radar)
					{
						num = float_5 / 20f;
					}
					else
					{
						num = sensor_.RangeResolution * (float_5 / sensor_.MaxRange);
					}
					double num5 = (double)Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), unit_.GetLatitude(null), unit_.GetLongitude(null));
					Random random = GameGeneral.GetRandom();
					float num6 = (float)Math2.Normalize(num5 + (double)sensor_.AngleResolution * ((double)random.Next(-90, 91) / 100.0));
					float num7 = (float)Math.Max(0.0, (double)float_5 + (double)num * ((double)random.Next(-90, 91) / 100.0));
					List<GeoPoint> list = new List<GeoPoint>();
					float num8 = 0f;
					float num9 = 0f;
					if (sensor_.sensorType == Sensor.SensorType.ESM)
					{
						if (flag)
						{
							num8 = Math.Max(num7 - num, 0f);
							num9 = num7 + num;
						}
						else
						{
							num8 = Math.Max(num7 - sensor_.MaxRange / 3f, 0f);
							float num10 = Class363.smethod_1(this.ParentPlatform, unit_);
							if (!float.IsInfinity(num10) && !float.IsNaN(num10))
							{
								num9 = Math.Min(num10, num7 + sensor_.MaxRange / 3f);
							}
							else
							{
								num9 = num7 + sensor_.MaxRange / 3f;
							}
						}
						if (unit_.IsShip || unit_.IsFacility || unit_.IsSubmarine)
						{
							bool flag2 = false;
							foreach (int current in observableDictionary_2.Keys)
							{
								EmissionContainer emissionContainer = observableDictionary_2[current];
								if (emissionContainer.bool_1)
								{
									if (!emissionContainer.method_0(current, this.ParentPlatform.m_Scenario).IsOTH())
									{
										continue;
									}
									flag2 = true;
								}
								else
								{
									flag2 = true;
								}
								break;
							}
							if (!sensor_.IsOTH() && !flag2)
							{
								Unit parentPlatform = this.ParentPlatform;
								float num11 = 0f;
								num9 = Math.Min(Class363.smethod_0(parentPlatform, ref num11), num9);
							}
						}
					}
					else if (sensor_.IsSonar() && !sensor_.IsEmmitting())
					{
						float num12 = (float)((double)SonarEnvironment.GetConvergenceZoneIncrement(this.ParentPlatform.GetLatitude(null)) - 2.5);
						if (float_5 < num12)
						{
							if (flag)
							{
								num8 = Math.Max(num7 - num, 0f);
								num9 = num7 + num;
							}
							else
							{
								num8 = 1E-05f;
								num9 = num12;
							}
						}
						else
						{
							num8 = num12;
							num9 = sensor_.MaxRange;
						}
					}
					else
					{
						num8 = Math.Max(num7 - num, 0f);
						num9 = num7 + num;
					}
					float num13 = Math2.Normalize(num6 - sensor_.AngleResolution);
					float num14 = Math2.Normalize(num6 + sensor_.AngleResolution);
					float num15 = Math2.Normalize(num6);
					GeoPoint geoPoint = new GeoPoint();
					double longitude = this.ParentPlatform.GetLongitude(null);
					double latitude = this.ParentPlatform.GetLatitude(null);
					GeoPoint geoPoint2;
					double num16 = (geoPoint2 = geoPoint).GetLongitude();
					GeoPoint geoPoint3;
					double num17 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num16, ref num17, (double)num8, (double)num13);
					geoPoint3.SetLatitude(num17);
					geoPoint2.SetLongitude(num16);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude2 = this.ParentPlatform.GetLongitude(null);
					double latitude2 = this.ParentPlatform.GetLatitude(null);
					num17 = (geoPoint3 = geoPoint).GetLongitude();
					num16 = (geoPoint2 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref num17, ref num16, (double)num8, (double)num15);
					geoPoint2.SetLatitude(num16);
					geoPoint3.SetLongitude(num17);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude3 = this.ParentPlatform.GetLongitude(null);
					double latitude3 = this.ParentPlatform.GetLatitude(null);
					num16 = (geoPoint2 = geoPoint).GetLongitude();
					num17 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude3, ref num16, ref num17, (double)num8, (double)num14);
					geoPoint3.SetLatitude(num17);
					geoPoint2.SetLongitude(num16);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude4 = this.ParentPlatform.GetLongitude(null);
					double latitude4 = this.ParentPlatform.GetLatitude(null);
					num17 = (geoPoint3 = geoPoint).GetLongitude();
					num16 = (geoPoint2 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num17, ref num16, (double)num9, (double)num14);
					geoPoint2.SetLatitude(num16);
					geoPoint3.SetLongitude(num17);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude5 = this.ParentPlatform.GetLongitude(null);
					double latitude5 = this.ParentPlatform.GetLatitude(null);
					num16 = (geoPoint2 = geoPoint).GetLongitude();
					num17 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num16, ref num17, (double)num9, (double)num15);
					geoPoint3.SetLatitude(num17);
					geoPoint2.SetLongitude(num16);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude6 = this.ParentPlatform.GetLongitude(null);
					double latitude6 = this.ParentPlatform.GetLatitude(null);
					num17 = (geoPoint3 = geoPoint).GetLongitude();
					num16 = (geoPoint2 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude6, latitude6, ref num17, ref num16, (double)num9, (double)num13);
					geoPoint2.SetLatitude(num16);
					geoPoint3.SetLongitude(num17);
					list.Add(geoPoint);
					foreach (GeoPoint current2 in list)
					{
						if (current2.GetLatitude() > 90.0)
						{
							current2.SetLatitude(90.0);
						}
						if (current2.GetLatitude() < -90.0)
						{
							current2.SetLatitude(-90.0);
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200585", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00136DD4 File Offset: 0x00134FD4
		public static List<GeoPoint> smethod_7(List<GeoPoint> theUncertaintyArea, List<GeoPoint> theUncertaintyArea_)
		{
			List<GeoPoint> result = null;
			try
			{
				if (theUncertaintyArea.Count > 100)
				{
					theUncertaintyArea = Math2.smethod_15(theUncertaintyArea);
				}
				if (theUncertaintyArea_.Count > 100)
				{
					theUncertaintyArea_ = Math2.smethod_15(theUncertaintyArea_);
				}
				List<Vector3D> list = theUncertaintyArea.Select(new Func<GeoPoint, Vector3D>(Class263.smethod_16)).ToList<Vector3D>();
				List<Vector3D> list2 = theUncertaintyArea_.Select(new Func<GeoPoint, Vector3D>(Class263.smethod_16)).ToList<Vector3D>();
				Vector3D vector3D = default(Vector3D);
				foreach (Vector3D current in list2)
				{
					vector3D += current;
				}
				foreach (Vector3D current2 in list)
				{
					vector3D += current2;
				}
				vector3D /= (double)(list2.Count + list.Count);
				vector3D /= vector3D.Length;
				Matrix<double> matrix = Matrix3D.RotationTo(vector3D, new Vector3D(1.0, 0.0, 0.0), null);
				Matrix<double> m = matrix.Inverse();
				int num = list2.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					list2[i] = list2[i].TransformBy(matrix);
				}
				int num2 = list.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					list[j] = list[j].TransformBy(matrix);
				}
				List<GeoPoint> list3 = list.Select(new Func<Vector3D, GeoPoint>(Class263.smethod_15)).ToList<GeoPoint>();
				List<GeoPoint> list4 = list2.Select(new Func<Vector3D, GeoPoint>(Class263.smethod_15)).ToList<GeoPoint>();
				List<GeoPoint> list5 = Math2.smethod_21(list3, list4);
				if (list5.Count == 0)
				{
					result = theUncertaintyArea_;
				}
				else
				{
					List<Vector3D> list6 = list5.Select(new Func<GeoPoint, Vector3D>(Class263.smethod_16)).ToList<Vector3D>();
					int num3 = list6.Count - 1;
					for (int k = 0; k <= num3; k++)
					{
						list6[k] = list6[k].TransformBy(m);
					}
					List<GeoPoint> list7 = list6.Select(new Func<Vector3D, GeoPoint>(Class263.smethod_15)).ToList<GeoPoint>();
					if (list7.Count > 100)
					{
						list7 = Math2.smethod_15(list7);
					}
					result = list7;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200586", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = theUncertaintyArea_;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x00137100 File Offset: 0x00135300
		public List<Sensor> GetAirSpaceSensors()
		{
			List<Sensor> result = null;
			try
			{
				Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
				if (Information.IsNothing(allNoneMCMSensors))
				{
					result = new List<Sensor>();
				}
				else
				{
					int num = allNoneMCMSensors.Length;
					List<Sensor> list = new List<Sensor>();
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if ((sensor.IsSearchAndTrackSensor() || sensor.GetTargetsTrackedForFireControl().Count != 0) && (sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft) || sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Satellite) || sensor.sensorCapability.ABM_SpaceSearch))
						{
							list.Add(sensor);
						}
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100272", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00137204 File Offset: 0x00135404
		public List<Sensor> GetMaxRangeCoverageAirSpaceSensorList(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> list4 = null;
			List<Sensor> result;
			try
			{
				list3 = this.GetAirSpaceSensorList(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				float num = 0f;
				int num2 = 0;
				foreach (Sensor current in list3)
				{
					if (current.MaxRange >= num)
					{
						list2.Add(current);
						num = current.MaxRange;
						num2 = 1;
					}
					else if (current.MaxRange == num)
					{
						list2.Add(current);
						num2++;
					}
				}
				if (list2.Count == 0)
				{
					list4 = list;
				}
				else
				{
					foreach (Sensor current2 in list2)
					{
						if (current2.MaxRange == num)
						{
							if (num2 == 1)
							{
								list.Add(current2);
							}
							else
							{
								if (current2.coverageArc.Is360Coverage())
								{
									list.Add(current2);
									list4 = list;
									result = list4;
									return result;
								}
								num2--;
							}
						}
					}
					list4 = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100273", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list4 = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			result = list4;
			return result;
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x001373D0 File Offset: 0x001355D0
		public List<Sensor> GetMaxRangeCoverageSurfaceAndLandSensorList(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> list4 = new List<Sensor>();
			List<Sensor> list5 = null;
			List<Sensor> result;
			try
			{
				list4 = this.GetSurfaceAndLandSensorList(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				if (Information.IsNothing(list4))
				{
					list5 = new List<Sensor>();
				}
				else
				{
					float num = 0f;
					int num2 = 0;
					float num3 = 0f;
					int num4 = 0;
					foreach (Sensor current in list4)
					{
						if (current.MaxRange >= num && !current.sensorCapability.OTH_SurfaceWave)
						{
							if (current.MaxRange >= num)
							{
								list2.Add(current);
								num = current.MaxRange;
								num2 = 1;
							}
							else if (current.MaxRange == num)
							{
								list2.Add(current);
								num2++;
							}
						}
						else if (current.MaxRange >= num3 && current.sensorCapability.OTH_SurfaceWave)
						{
							if (current.MaxRange >= num)
							{
								list3.Add(current);
								num3 = current.MaxRange;
								num4 = 1;
							}
							else if (current.MaxRange == num)
							{
								list3.Add(current);
								num4++;
							}
						}
					}
					if (list2.Count == 0 && list3.Count == 0)
					{
						list5 = list;
					}
					else
					{
						if (list3.Count == 0)
						{
							using (List<Sensor>.Enumerator enumerator2 = list2.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									Sensor current2 = enumerator2.Current;
									if (current2.MaxRange == num)
									{
										if (num2 == 1)
										{
											list.Add(current2);
										}
										else
										{
											if (current2.coverageArc.Is360Coverage())
											{
												list.Add(current2);
												list5 = list;
												result = list5;
												return result;
											}
											num2--;
										}
									}
								}
								goto IL_26E;
							}
						}
						foreach (Sensor current3 in list3)
						{
							if (current3.MaxRange == num3)
							{
								if (num4 == 1)
								{
									list.Add(current3);
								}
								else
								{
									if (current3.coverageArc.Is360Coverage())
									{
										list.Add(current3);
										list5 = list;
										result = list5;
										return result;
									}
									num4--;
								}
							}
						}
						IL_26E:
						list5 = list;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100274", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list5 = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			result = list5;
			return result;
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00137704 File Offset: 0x00135904
		public List<Sensor> GetMaxRangeCoverageSurfaceSensorList(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> list4 = null;
			List<Sensor> result;
			try
			{
				list3 = this.GetSurfaceSensorList(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				float num = 0f;
				int num2 = 0;
				foreach (Sensor current in list3)
				{
					if (current.MaxRange >= num)
					{
						list2.Add(current);
						num = current.MaxRange;
						num2 = 1;
					}
					else if (current.MaxRange == num)
					{
						list2.Add(current);
						num2++;
					}
				}
				if (list2.Count == 0)
				{
					list4 = list;
				}
				else
				{
					foreach (Sensor current2 in list2)
					{
						if (current2.MaxRange == num)
						{
							if (num2 == 1)
							{
								list.Add(current2);
							}
							else
							{
								if (current2.coverageArc.Is360Coverage())
								{
									list.Add(current2);
									list4 = list;
									result = list4;
									return result;
								}
								num2--;
							}
						}
					}
					list4 = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100275", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list4 = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			result = list4;
			return result;
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x001378D0 File Offset: 0x00135AD0
		public List<Sensor> GetMaxRangeCoverageLandSensorList(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> list4 = null;
			List<Sensor> result;
			try
			{
				list3 = this.GetLandSensorList(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				float num = 0f;
				int num2 = 0;
				foreach (Sensor current in list3)
				{
					if (current.MaxRange >= num)
					{
						list2.Add(current);
						num = current.MaxRange;
						num2 = 1;
					}
					else if (current.MaxRange == num)
					{
						list2.Add(current);
						num2++;
					}
				}
				if (list2.Count == 0)
				{
					list4 = list;
				}
				else
				{
					foreach (Sensor current2 in list2)
					{
						if (current2.MaxRange == num)
						{
							if (num2 == 1)
							{
								list.Add(current2);
							}
							else
							{
								if (current2.coverageArc.Is360Coverage())
								{
									list.Add(current2);
									list4 = list;
									result = list4;
									return result;
								}
								num2--;
							}
						}
					}
					list4 = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100276", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list4 = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			result = list4;
			return result;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00137A9C File Offset: 0x00135C9C
		public List<Sensor> GetMaxRangeCoverageSubsurfaceSensorList(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> list4 = null;
			List<Sensor> result;
			try
			{
				list3 = this.GetSubsurfaceSensorList(ActiveCapableSensorsOnly, EmmittingSensorsOnly, OnlyOperatingSensors, OnlySensorsScanningThisPulse, ref theSensorList, SonarsOnly);
				float num = 0f;
				int num2 = 0;
				foreach (Sensor current in list3)
				{
					if (current.MaxRange > num)
					{
						list2.Add(current);
						num = current.MaxRange;
						num2 = 1;
					}
					else if (current.MaxRange == num)
					{
						list2.Add(current);
						num2++;
					}
				}
				if (list2.Count == 0)
				{
					list4 = list;
				}
				else
				{
					foreach (Sensor current2 in list2)
					{
						if (current2.MaxRange == num)
						{
							if (num2 == 1)
							{
								list.Add(current2);
							}
							else
							{
								if (current2.coverageArc.Is360Coverage())
								{
									list.Add(current2);
									list4 = list;
									result = list4;
									return result;
								}
								num2--;
							}
						}
					}
					list4 = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100277", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list4 = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			result = list4;
			return result;
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00137C6C File Offset: 0x00135E6C
		public List<Sensor> GetMaxRangeMaxCoverageSensorList(ref Sensor[] sensors)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = null;
			List<Sensor> result;
			try
			{
				Sensor[] array = sensors;
				float num = 0f;
				int num2 = 0;
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					Sensor sensor = array[i];
					if (sensor.MaxRange >= num)
					{
						list2.Add(sensor);
						num = sensor.MaxRange;
						num2 = 1;
					}
					else if (sensor.MaxRange == num)
					{
						list2.Add(sensor);
						num2++;
					}
				}
				if (list2.Count == 0)
				{
					list3 = list;
				}
				else
				{
					foreach (Sensor current in list2)
					{
						if (current.MaxRange == num)
						{
							if (num2 == 1)
							{
								list.Add(current);
							}
							else
							{
								if (current.coverageArc.Is360Coverage())
								{
									list.Add(current);
									list3 = list;
									result = list3;
									return result;
								}
								num2--;
							}
						}
					}
					list3 = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101273", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list3 = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			result = list3;
			return result;
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00137DE4 File Offset: 0x00135FE4
		public List<Sensor> GetAirSpaceSensorList(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			List<Sensor> result = null;
			try
			{
				List<Sensor> list = new List<Sensor>();
				Sensor[] array;
				if (Information.IsNothing(theSensorList))
				{
					array = this.GetAirSpaceSensors().ToArray();
				}
				else
				{
					array = theSensorList;
				}
				if (Information.IsNothing(array))
				{
					result = list;
				}
				else
				{
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						Sensor sensor = array[i];
                        //ZSP ESM
                        if (sensor.sensorType == Sensor.SensorType.ESM)
                        {
                            list.Add(sensor);
                        }

                        if ((!ActiveCapableSensorsOnly || sensor.IsActiveCapable()) && (!EmmittingSensorsOnly || sensor.IsEmmitting()) && (!OnlySensorsScanningThisPulse || sensor.IsScanningOrTrackingThisPulse()) && (sensor.IsSearchAndTrackSensor() || sensor.GetTargetsTrackedForFireControl().Count != 0) && (!OnlyOperatingSensors || sensor.IsOperating()))
						{
							if (this.ParentPlatform.IsWeapon)
							{
								if (!sensor.IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft, (Weapon)this.ParentPlatform) && !sensor.IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType.Weapon, (Weapon)this.ParentPlatform))
								{
									goto IL_106;
								}
							}
							else if (!sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft) && !sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Weapon) && !sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Satellite))
							{
								goto IL_106;
							}
							list.Add(sensor);
						}
						IL_106:;
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100278", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00137F78 File Offset: 0x00136178
		public List<Sensor> GetSurfaceAndLandSensorList(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.ParentPlatform.GetAllNoneMCMSensors();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> result = null;
			if (Information.IsNothing(array))
			{
				result = new List<Sensor>();
			}
			else
			{
				List<Sensor> list = new List<Sensor>();
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.IsActiveCapable()) && (!EmmittingSensorsOnly || sensor.IsEmmitting()) && (!OnlySensorsScanningThisPulse || sensor.IsScanningOrTrackingThisPulse()) && sensor.IsSearchAndTrackSensor() && (!OnlyOperatingSensors || sensor.IsOperating()) && (sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Ship) || sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Facility)))
						{
							list.Add(sensor);
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100279", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001380A8 File Offset: 0x001362A8
		public List<Sensor> GetSurfaceSensorList(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.ParentPlatform.GetAllNoneMCMSensors();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> list = new List<Sensor>();
			List<Sensor> result = null;
			if (Information.IsNothing(array))
			{
				result = list;
			}
			else
			{
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.IsActiveCapable()) && (!EmmittingSensorsOnly || sensor.IsEmmitting()) && (!OnlySensorsScanningThisPulse || sensor.IsScanningOrTrackingThisPulse()) && sensor.IsSearchAndTrackSensor() && (!OnlyOperatingSensors || sensor.IsOperating()))
						{
							if (this.ParentPlatform.IsWeapon)
							{
								if (!sensor.IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType.Ship, (Weapon)this.ParentPlatform))
								{
									goto IL_CC;
								}
							}
							else if (!sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Ship))
							{
								goto IL_CC;
							}
							list.Add(sensor);
						}
						IL_CC:;
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100280", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x001381F4 File Offset: 0x001363F4
		public List<Sensor> GetLandSensorList(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.ParentPlatform.GetAllNoneMCMSensors();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> list = new List<Sensor>();
			List<Sensor> result = null;
			if (Information.IsNothing(array))
			{
				result = list;
			}
			else
			{
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.IsActiveCapable()) && (!EmmittingSensorsOnly || sensor.IsEmmitting()) && (!OnlySensorsScanningThisPulse || sensor.IsScanningOrTrackingThisPulse()) && sensor.IsSearchAndTrackSensor() && (!OnlyOperatingSensors || sensor.IsOperating()))
						{
							if (this.ParentPlatform.IsWeapon)
							{
								if (!sensor.IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType.Facility, (Weapon)this.ParentPlatform))
								{
									goto IL_CC;
								}
							}
							else if (!sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Facility))
							{
								goto IL_CC;
							}
							list.Add(sensor);
						}
						IL_CC:;
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100281", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00138340 File Offset: 0x00136540
		public List<Sensor> GetSubsurfaceSensorList(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			List<Sensor> list = new List<Sensor>();
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.ParentPlatform.GetAllNoneMCMSensors();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> result = null;
			if (Information.IsNothing(array))
			{
				result = list;
			}
			else
			{
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!SonarsOnly || sensor.IsSonar()) && (!ActiveCapableSensorsOnly || sensor.IsActiveCapable()) && (!EmmittingSensorsOnly || sensor.IsEmmitting()) && (!OnlySensorsScanningThisPulse || sensor.IsScanningOrTrackingThisPulse()) && sensor.IsSearchAndTrackSensor() && (!OnlyOperatingSensors || sensor.IsOperating()))
						{
							if (this.ParentPlatform.IsWeapon)
							{
								if (((Weapon)this.ParentPlatform).GetWeaponType() != Weapon._WeaponType.Sonobuoy && !sensor.IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType.Submarine, (Weapon)this.ParentPlatform))
								{
									if (!sensor.IsSeekerCapableOfDetect(GlobalVariables.ActiveUnitType.Ship, (Weapon)this.ParentPlatform))
									{
										goto IL_115;
									}
									if (!this.ParentPlatform.IsTorpedo())
									{
										goto IL_115;
									}
								}
							}
							else if (!sensor.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Submarine))
							{
								goto IL_115;
							}
							list.Add(sensor);
						}
						IL_115:;
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100282", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x001384D8 File Offset: 0x001366D8
		public void ScheduleTrackInteration()
		{
			checked
			{
				try
				{
					bool flag = false;
					Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
					Sensor[] array = allNoneMCMSensors;
					int num = 0;
					if (0 < array.Length)
					{
						if (array[num].GetTargetsTrackedForFireControl().Contains(this.ParentPlatform.GetAI().GetPrimaryTarget()))
						{
							flag = true;
						}
						else if (num != array.Length - 1)
						{
						}
						Sensor[] array2 = allNoneMCMSensors;
						for (int i = 0; i < array2.Length; i++)
						{
							Sensor sensor = array2[i];
							if (sensor.GetTargetsTrackedForFireControl().Count > 0)
							{
								if (sensor.SemiActiveGuidedWeaponList.Count == 0)
								{
									List<Contact> list = new List<Contact>();
									foreach (Contact current in sensor.GetTargetsTrackedForFireControl())
									{
										if (current.IsTargetOutOfUnitInterceptRange(this.ParentPlatform))
										{
											list.Add(current);
										}
									}
									if (!flag && !sensor.IsFireChannelsEnough())
									{
										list.Add(sensor.GetTargetsTrackedForFireControl()[0]);
									}
									using (List<Contact>.Enumerator enumerator2 = list.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											Contact current2 = enumerator2.Current;
											sensor.StopIlluminateTarget(ref current2, false);
										}
										goto IL_1F3;
									}
								}
								List<Contact> list2 = new List<Contact>();
								foreach (Contact current3 in sensor.GetTargetsTrackedForFireControl())
								{
									if (Information.IsNothing(current3))
									{
										list2.Add(current3);
									}
									else if (current3.IsDestroyed(this.ParentPlatform.m_Scenario))
									{
										list2.Add(current3);
									}
								}
                                Contact current4X;

                                foreach (Contact current4 in list2)
								{
                                    current4X = current4;
                                    sensor.StopIlluminateTarget(ref current4X, false);
								}
							}
							IL_1F3:;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100283", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x001387A4 File Offset: 0x001369A4
		public ObservableDictionary<string, Contact> method_63()
		{
			ObservableDictionary<string, Contact> result;
			try
			{
				if (Information.IsNothing(this.observableDictionary_1))
				{
					ObservableDictionary<string, Contact> observableDictionary = new ObservableDictionary<string, Contact>();
					foreach (KeyValuePair<string, ActiveUnit_Sensory.ContactEntry> current in this.GetContactEntryDictionary())
					{
						if (!Information.IsNothing(current.Value.m_Contact))
						{
							observableDictionary.Add(current.Key, current.Value.m_Contact);
						}
						else
						{
							this.LazyContactDictionary.Value.TryAdd(current.Key, null);
						}
					}
					this.observableDictionary_1 = observableDictionary;
				}
				result = this.observableDictionary_1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101216", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ObservableDictionary<string, Contact>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x001388B8 File Offset: 0x00136AB8
		public void method_64(ref string string_0, List<Sensor> list_2)
		{
			if (this.GetContactEntryDictionary().ContainsKey(string_0))
			{
				ActiveUnit_Sensory.ContactEntry contactEntry = this.GetContactEntryDictionary()[string_0];
				contactEntry.NoDetectionCount = 0f;
				foreach (Sensor current in list_2)
				{
					Sensor.SensorType sensorType = current.sensorType;
					if (sensorType <= Sensor.SensorType.TowedArray_ActiveOnly)
					{
						if (sensorType <= Sensor.SensorType.ESM)
						{
							switch (sensorType)
							{
							case Sensor.SensorType.Radar:
								contactEntry.TSD_Radar = new float?(0f);
								continue;
							case Sensor.SensorType.SemiActive:
								continue;
							case Sensor.SensorType.Visual:
								contactEntry.TSD_Visual = new float?(0f);
								continue;
							case Sensor.SensorType.Infrared:
								contactEntry.TSD_Infrared = new float?(0f);
								continue;
							default:
								if (sensorType == Sensor.SensorType.ESM)
								{
									contactEntry.TSD_ESM = new float?(0f);
									continue;
								}
								continue;
							}
						}
						else if (sensorType - Sensor.SensorType.HullSonar_PassiveOnly > 2 && sensorType - Sensor.SensorType.TowedArray_PassiveOnly > 2)
						{
							continue;
						}
					}
					else if (sensorType <= Sensor.SensorType.DippingSonar_ActiveOnly)
					{
						if (sensorType - Sensor.SensorType.VDS_PassiveOnly > 2 && sensorType - Sensor.SensorType.DippingSonar_PassiveOnly > 2)
						{
							continue;
						}
					}
					else if (sensorType != Sensor.SensorType.BottomFixedSonar_PassiveOnly)
					{
						if (sensorType == Sensor.SensorType.PingIntercept)
						{
							contactEntry.TSD_SonarPassive = new float?(0f);
							continue;
						}
						continue;
					}
					if (current.IsActiveModeOnly())
					{
						contactEntry.TSD_SonarActive = new float?(0f);
					}
					else if (current.IsEmmitting())
					{
						contactEntry.TSD_SonarActive = new float?(0f);
					}
					else
					{
						contactEntry.TSD_SonarPassive = new float?(0f);
					}
				}
			}
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00138AA0 File Offset: 0x00136CA0
		public float? method_65(ref Contact contact_0)
		{
			float? result = null;
			if (!Information.IsNothing(contact_0.ActualUnit))
			{
				if (this.GetContactEntryDictionary().ContainsKey(contact_0.ActualUnit.GetGuid()))
				{
					result = new float?(this.GetContactEntryDictionary()[contact_0.ActualUnit.GetGuid()].TimeSinceDetection);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x0001FDE7 File Offset: 0x0001DFE7
		private void method_66(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit_Sensory.ContactEntry> e)
		{
			this.observableDictionary_1 = null;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
		public void RemoveContactEntry(ref string string_0)
		{
			if (this.GetContactEntryDictionary().ContainsKey(string_0))
			{
				this.GetContactEntryDictionary().Remove(string_0);
			}
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00138B10 File Offset: 0x00136D10
		public void method_68()
		{
			try
			{
				if (!Misc.smethod_17(this.lazy_1.Value))
				{
					foreach (string current in this.lazy_1.Value.Keys)
					{
						ActiveUnit_Sensory.ContactEntry contactEntry = new ActiveUnit_Sensory.ContactEntry();
						contactEntry.m_Contact = this.lazy_1.Value[current];
						if (!this.GetContactEntryDictionary().ContainsKey(current))
						{
							this.GetContactEntryDictionary().Add(current, contactEntry);
						}
					}
					this.lazy_1.Value.Clear();
				}
				if (!Misc.smethod_17(this.LazyContactDictionary.Value))
				{
					foreach (string current2 in this.LazyContactDictionary.Value.Keys)
					{
						this.GetContactEntryDictionary().Remove(current2);
					}
					this.LazyContactDictionary.Value.Clear();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101220", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00138C84 File Offset: 0x00136E84
		public void UpdateContactsOffGridInfo(float elapsedTime)
		{
			try
			{
				foreach (KeyValuePair<string, ActiveUnit_Sensory.ContactEntry> current in this.GetContactEntryDictionary())
				{
					ActiveUnit_Sensory.ContactEntry value = current.Value;
					value.TimeSinceDetection = current.Value.TimeSinceDetection + elapsedTime;
					if (value.TimeSinceDetection > (float)this.ParentPlatform.OODATargetingCycle)
					{
						if (this.ParentPlatform.OODATargetingCycle > 0 && this.ParentPlatform.GetSide(false).GetWeaponSalvoListForTarget(value.m_Contact).Count > 0)
						{
							value.NoDetectionCount = 0f;
						}
						else if (value.NoDetectionCount > 300f)
						{
							this.LazyContactDictionary.Value.TryAdd(current.Key, value.m_Contact);
						}
						else
						{
							float num = 1f;
							if (this.ParentPlatform.m_Scenario.IsFastMode())
							{
								num = 10f;
							}
							value.NoDetectionCount += 1f / num;
						}
					}
					if (!Information.IsNothing(value.TSD_Radar))
					{
						ActiveUnit_Sensory.ContactEntry expr_10E = value;
						float? num2 = expr_10E.TSD_Radar;
						expr_10E.TSD_Radar = (num2.HasValue ? new float?(num2.GetValueOrDefault() + elapsedTime) : null);
					}
					if (!Information.IsNothing(value.TSD_ESM))
					{
						ActiveUnit_Sensory.ContactEntry expr_156 = value;
						float? num2 = expr_156.TSD_ESM;
						expr_156.TSD_ESM = (num2.HasValue ? new float?(num2.GetValueOrDefault() + elapsedTime) : null);
					}
					if (!Information.IsNothing(value.TSD_Visual))
					{
						ActiveUnit_Sensory.ContactEntry expr_19E = value;
						float? num2 = expr_19E.TSD_Visual;
						expr_19E.TSD_Visual = (num2.HasValue ? new float?(num2.GetValueOrDefault() + elapsedTime) : null);
					}
					if (!Information.IsNothing(value.TSD_Infrared))
					{
						ActiveUnit_Sensory.ContactEntry expr_1E6 = value;
						float? num2 = expr_1E6.TSD_Infrared;
						expr_1E6.TSD_Infrared = (num2.HasValue ? new float?(num2.GetValueOrDefault() + elapsedTime) : null);
					}
					if (!Information.IsNothing(value.TSD_SonarActive))
					{
						ActiveUnit_Sensory.ContactEntry expr_22E = value;
						float? num2 = expr_22E.TSD_SonarActive;
						expr_22E.TSD_SonarActive = (num2.HasValue ? new float?(num2.GetValueOrDefault() + elapsedTime) : null);
					}
					if (!Information.IsNothing(value.TSD_SonarPassive))
					{
						ActiveUnit_Sensory.ContactEntry expr_276 = value;
						float? num2 = expr_276.TSD_SonarPassive;
						expr_276.TSD_SonarPassive = (num2.HasValue ? new float?(num2.GetValueOrDefault() + elapsedTime) : null);
					}
				}
				using (Dictionary<string, Contact>.ValueCollection.Enumerator enumerator2 = this.ContactList_OffGrid.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						enumerator2.Current.UpdateContactOffGridInfo(this.ParentPlatform.GetSide(false), elapsedTime, this.ParentPlatform.m_Scenario);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101223", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00139038 File Offset: 0x00137238
		public void method_70(float elapsedTime)
		{
			if (this.JammerCarriersLazyDictionary.Value.Count > 0)
			{
				this.JammerCarriersLazyDictionary.Value.Clear();
			}
			if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
			{
				using (List<Contact>.Enumerator enumerator = this.GetContactList_OffGrid().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.method_53(elapsedTime, this.ParentPlatform.m_Scenario);
					}
				}
			}
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x001390D0 File Offset: 0x001372D0
		public void method_71(float float_5)
		{
			if (this.JammerCarriersLazyDictionary.Value.Count > 0)
			{
				this.JammerCarriersLazyDictionary.Value.Clear();
			}
			if (!this.ParentPlatform.GetCommStuff().IsNotOutOfComms())
			{
				using (List<Contact>.Enumerator enumerator = this.GetContactList_OffGrid().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.method_54(float_5, this.ParentPlatform.GetSide(false), this.ParentPlatform.m_Scenario);
					}
				}
				this.method_72();
			}
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00139178 File Offset: 0x00137378
		private void method_72()
		{
			checked
			{
				try
				{
					if (this.ContactList_OffGrid.Count > 0)
					{
						Contact[] array = this.ContactList_OffGrid.Values.ToArray<Contact>();
						for (int i = 0; i < array.Length; i++)
						{
							Contact contact = array[i];
							if (Information.IsNothing(contact) || contact.IsOutdated() || contact.IsDestroyed(this.ParentPlatform.m_Scenario))
							{
								this.ParentPlatform.m_Scenario.LogMessage(this.ParentPlatform.Name + ": 私有目标 " + contact.Name + " 已丢失.", LoggedMessage.MessageType.CommsIsolatedMessage, 5, null, this.ParentPlatform.GetSide(false), new GeoPoint(contact.GetLongitude(null), contact.GetLatitude(null)));
								try
								{
									this.ContactList_OffGrid.Remove(contact.ActualUnit.GetGuid());
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									KeyValuePair<string, Contact>[] array2 = this.ContactList_OffGrid.ToArray<KeyValuePair<string, Contact>>();
									for (int j = 0; j < array2.Length; j++)
									{
										KeyValuePair<string, Contact> keyValuePair = array2[j];
										if (keyValuePair.Value == contact)
										{
											this.ContactList_OffGrid.Remove(keyValuePair.Key);
											break;
										}
									}
									ProjectData.ClearProjectError();
								}
							}
						}
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
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x0013934C File Offset: 0x0013754C
		public void method_73(ref ActiveUnit activeUnit_1, Dictionary<string, Subject> dictionary_1)
		{
			foreach (KeyValuePair<string, ActiveUnit_Sensory.ContactEntry> current in this.GetContactEntryDictionary())
			{
				if (activeUnit_1.GetSide(false).GetContactObservableDictionary().ContainsKey(current.Key))
				{
					current.Value.m_Contact = activeUnit_1.GetSide(false).GetContactObservableDictionary()[current.Key];
				}
			}
			foreach (Contact current2 in this.ContactList_OffGrid.Values)
			{
				ActiveUnit parentPlatform = this.ParentPlatform;
				ActiveUnit parentPlatform2;
				Side side = (parentPlatform2 = this.ParentPlatform).GetSide(false);
				current2.method_56(ref parentPlatform.m_Scenario, ref dictionary_1, ref side);
				parentPlatform2.SetSide(false, side);
			}
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00139450 File Offset: 0x00137650
		public void ClearContactsEntries()
		{
			try
			{
				foreach (KeyValuePair<string, ActiveUnit_Sensory.ContactEntry> current in this.GetContactEntryDictionary())
				{
					if (!Information.IsNothing(current.Value.m_Contact) && !Information.IsNothing(current.Value.m_Contact.ActualUnit))
					{
						current.Value.m_Contact.ActualUnit = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101225", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00139524 File Offset: 0x00137724
		private void method_75(DockFacility dockFacility_, Sensor sensor_, Contact contact_, float float_5)
		{
			if (dockFacility_.method_26() && dockFacility_.LazyDockedUnitsDictionary.Value.Count != 0)
			{
				float num = 0f;
				foreach (ActiveUnit current in dockFacility_.LazyDockedUnitsDictionary.Value.Values)
				{
					num = sensor_.GetDetectionRange(this.ParentPlatform, current);
					if (num * 3f >= float_5)
					{
						Contact.HostUnitOfRadarRadiation hostUnitOfRadarRadiation = null;
						foreach (Contact.HostUnitOfRadarRadiation current2 in contact_.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)))
						{
							if (Operators.CompareString(current2.UID, current.GetGuid(), false) == 0)
							{
								hostUnitOfRadarRadiation = current2;
								hostUnitOfRadarRadiation.RA = 0f;
								break;
							}
						}
						if (!Information.IsNothing(hostUnitOfRadarRadiation))
						{
							if (float_5 < num)
							{
								if (hostUnitOfRadarRadiation.identificationStatus < Contact_Base.IdentificationStatus.KnownClass)
								{
									hostUnitOfRadarRadiation.identificationStatus = Contact_Base.IdentificationStatus.KnownClass;
									this.ParentPlatform.LogMessage(string.Concat(new string[]
									{
										current.GetUnitTypeName(),
										" previously spotted on ",
										contact_.Name,
										" has been identified as: ",
										current.UnitClass,
										" (recon by: ",
										this.ParentPlatform.Name,
										" - Sensor: ",
										sensor_.Name,
										"). "
									}), LoggedMessage.MessageType.ContactChange, 0, false, new GeoPoint(contact_.GetLongitude(null), contact_.GetLatitude(null)));
								}
							}
							else if (float_5 < num * 2f && hostUnitOfRadarRadiation.identificationStatus < Contact_Base.IdentificationStatus.KnownType)
							{
								hostUnitOfRadarRadiation.identificationStatus = Contact_Base.IdentificationStatus.KnownType;
								this.ParentPlatform.LogMessage(string.Concat(new string[]
								{
									current.GetUnitTypeName(),
									" previously spotted on ",
									contact_.Name,
									" has been type-classified as: ",
									current.GetUnitTypeDescription(),
									" (recon by: ",
									this.ParentPlatform.Name,
									" - Sensor: ",
									sensor_.Name,
									"). "
								}), LoggedMessage.MessageType.ContactChange, 0, false, new GeoPoint(contact_.GetLongitude(null), contact_.GetLatitude(null)));
							}
							hostUnitOfRadarRadiation.RA = 0f;
						}
						else
						{
							this.method_29(current, contact_, sensor_);
						}
					}
				}
				Lazy<List<Contact.HostUnitOfRadarRadiation>> lazy = new Lazy<List<Contact.HostUnitOfRadarRadiation>>();
				foreach (Contact.HostUnitOfRadarRadiation current3 in contact_.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)))
				{
					ActiveUnit activeUnit = null;
					this.ParentPlatform.m_Scenario.GetActiveUnits().TryGetValue(current3.UID, ref activeUnit);
					if (Information.IsNothing(activeUnit))
					{
						if (float_5 < num * 2f)
						{
							lazy.Value.Add(current3);
						}
					}
					else if (!dockFacility_.GetParentPlatform().GetDockingOps().GetDockedUnits().Contains(activeUnit) && (!activeUnit.IsAircraft || !dockFacility_.GetParentPlatform().GetAirOps().GetHostedAircrafts().Contains((Aircraft)activeUnit)) && float_5 < num * 2f)
					{
						lazy.Value.Add(current3);
					}
				}
				foreach (Contact.HostUnitOfRadarRadiation current4 in lazy.Value)
				{
					contact_.GetRadiationHostUnits(this.ParentPlatform.GetSide(false)).Remove(current4);
				}
			}
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0001FE12 File Offset: 0x0001E012
		[CompilerGenerated]
		private bool IsSensorOtherThanHeightFinderAtEndOfDetectionCycle(Sensor sensor_0)
		{
			return this.IsSensorAtEndOfDetectionCycle(sensor_0) && !sensor_0.IsHeightFinderRadar();
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x0001FE29 File Offset: 0x0001E029
		[CompilerGenerated]
		private bool IsSensorOtherThanHeightFinderNotAtEndOfDetectionCycle(Sensor sensor_0)
		{
			return !this.IsSensorAtEndOfDetectionCycle(sensor_0) && !sensor_0.IsHeightFinderRadar();
		}

		// Token: 0x04001B9A RID: 7066
		public static Func<Sensor, bool> SensorFunc1 = (Sensor sensor_0) => !sensor_0.IsSearchAndTrackSensor() && sensor_0.GetTargetsTrackedForFireControl().Count > 0;

		// Token: 0x04001B9B RID: 7067
		public static Func<Sensor, bool> HeightFinderRadarFilter = (Sensor sensor_0) => sensor_0.IsHeightFinderRadar();

		// Token: 0x04001B9C RID: 7068
		public static Func<Sensor, bool> VisualSensorFilter = (Sensor sensor_0) => sensor_0.IsRadarSonarVisual(false, false);

		// Token: 0x04001B9D RID: 7069
		public static Func<Sensor, bool> EmissionDetectionOnlySensorFilter = (Sensor sensor_0) => sensor_0.IsEmissionDetectionOnly();

		// Token: 0x04001B9E RID: 7070
		protected ActiveUnit ParentPlatform;

		// Token: 0x04001B9F RID: 7071
		protected bool bObeysEMCON;

		// Token: 0x04001BA0 RID: 7072
		internal ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>> concurrentBag_0;

		// Token: 0x04001BA1 RID: 7073
		internal ConcurrentBag<string> DetectedMinesBag;

		// Token: 0x04001BA2 RID: 7074
		private List<Contact> list_0;

		// Token: 0x04001BA3 RID: 7075
		internal Lazy<ConcurrentDictionary<long, LoggedMessage>> lazy_0;

		// Token: 0x04001BA4 RID: 7076
		public Lazy<ConcurrentDictionary<string, Contact>> lazy_1;

		// Token: 0x04001BA5 RID: 7077
		public Lazy<ConcurrentDictionary<string, Contact>> LazyContactDictionary;

		// Token: 0x04001BA6 RID: 7078
		[CompilerGenerated]
		private ObservableDictionary<string, ActiveUnit_Sensory.ContactEntry> ContactEntryDictionary;

		// Token: 0x04001BA7 RID: 7079
		protected Dictionary<string, Contact> ContactList_OffGrid;

		// Token: 0x04001BA8 RID: 7080
		protected List<string> list_1;

		// Token: 0x04001BA9 RID: 7081
		private float MaxAirDetectRange;

		// Token: 0x04001BAA RID: 7082
		private float MaxSurfaceDetectRange;

		// Token: 0x04001BAB RID: 7083
		private float MaxLandDetectRange = 0f;

		// Token: 0x04001BAC RID: 7084
		private float MaxSubsurfaceDetectRange;

		// Token: 0x04001BAD RID: 7085
		private float MaxDetectRange = 0f;

		// Token: 0x04001BAE RID: 7086
		private Lazy<Dictionary<bool, List<ActiveUnit>>> JammerCarriersLazyDictionary;

		// Token: 0x04001BAF RID: 7087
		[CompilerGenerated]
		private static ActiveUnit_Sensory.Delegate4 delegate4_0;

		// Token: 0x04001BB0 RID: 7088
		private ObservableDictionary<string, Contact> observableDictionary_1;

		// Token: 0x0200097E RID: 2430
		// (Invoke) Token: 0x06003CF4 RID: 15604
		public delegate void Delegate4(Side DetectingSide, Contact_Base.ContactType ContactType);

		// Token: 0x0200097F RID: 2431
		public enum Enum8
		{
			// Token: 0x04001BB6 RID: 7094
			const_0,
			// Token: 0x04001BB7 RID: 7095
			const_1,
			// Token: 0x04001BB8 RID: 7096
			const_2
		}

		// Token: 0x02000980 RID: 2432
		public sealed class TargetUnitInDetectRange
		{
			// Token: 0x06003CF7 RID: 15607 RVA: 0x0001FE75 File Offset: 0x0001E075
			public TargetUnitInDetectRange(ref ActiveUnit activeUnit_1, ref Sensor[] sensorArray_)
			{
				this.TargetUnit = activeUnit_1;
				this.sensorArray = sensorArray_;
			}

			// Token: 0x04001BB9 RID: 7097
			public ActiveUnit TargetUnit;

			// Token: 0x04001BBA RID: 7098
			public Sensor[] sensorArray;
		}

		// Token: 0x02000981 RID: 2433
		public sealed class MineObstacleSearchManager
		{
			// Token: 0x06003CF8 RID: 15608 RVA: 0x0001FE8D File Offset: 0x0001E08D
			public MineObstacleSearchManager(ref UnguidedWeapon theMine, ref Sensor[] sensors)
			{
				this.Mine = theMine;
				this.MineObstacleSearchSonarArray = sensors;
			}

			// Token: 0x04001BBB RID: 7099
			public UnguidedWeapon Mine;

			// Token: 0x04001BBC RID: 7100
			public Sensor[] MineObstacleSearchSonarArray;
		}

		// Token: 0x02000982 RID: 2434
		public sealed class ContactEntry : Subject
		{
			// Token: 0x06003CF9 RID: 15609 RVA: 0x00139A24 File Offset: 0x00137C24
			public void Save(ref XmlWriter xmlWriter_0, Side side_0)
			{
				try
				{
					if (!Information.IsNothing(this.m_Contact) && side_0.GetContactObservableDictionary().ContainsKey(this.m_Contact.ActualUnit.GetGuid()))
					{
						xmlWriter_0.WriteStartElement("ContactEntry");
						xmlWriter_0.WriteElementString("Contact", this.m_Contact.ActualUnit.GetGuid());
						xmlWriter_0.WriteElementString("TSD", this.TimeSinceDetection.ToString());
						if (!Information.IsNothing(this.TSD_Radar))
						{
							xmlWriter_0.WriteElementString("TSD_Radar", this.TSD_Radar.ToString());
						}
						if (!Information.IsNothing(this.TSD_ESM))
						{
							xmlWriter_0.WriteElementString("TSD_ESM", this.TSD_ESM.ToString());
						}
						if (!Information.IsNothing(this.TSD_Visual))
						{
							xmlWriter_0.WriteElementString("TSD_Visual", this.TSD_Visual.ToString());
						}
						if (!Information.IsNothing(this.TSD_Infrared))
						{
							xmlWriter_0.WriteElementString("TSD_Infrared", this.TSD_Infrared.ToString());
						}
						if (!Information.IsNothing(this.TSD_SonarActive))
						{
							xmlWriter_0.WriteElementString("TSD_SonarActive", this.TSD_SonarActive.ToString());
						}
						if (!Information.IsNothing(this.TSD_SonarPassive))
						{
							xmlWriter_0.WriteElementString("TSD_SonarPassive", this.TSD_SonarPassive.ToString());
						}
						xmlWriter_0.WriteElementString("NDC", this.NoDetectionCount.ToString());
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101217", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06003CFA RID: 15610 RVA: 0x00139C38 File Offset: 0x00137E38
			public static ActiveUnit_Sensory.ContactEntry Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref string string_2)
			{
				ActiveUnit_Sensory.ContactEntry result = null;
				try
				{
					ActiveUnit_Sensory.ContactEntry contactEntry = new ActiveUnit_Sensory.ContactEntry();
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							uint num = Class382.smethod_0(name);
							if (num <= 998171479u)
							{
								if (num <= 770528374u)
								{
									if (num <= 687476049u)
									{
										if (num != 196400981u)
										{
											if (num != 687476049u)
											{
												continue;
											}
											if (Operators.CompareString(name, "TimeSinceDetection", false) != 0)
											{
												continue;
											}
											goto IL_1BB;
										}
										else if (Operators.CompareString(name, "TSD_Visual", false) != 0)
										{
											continue;
										}
									}
									else if (num != 755333778u)
									{
										if (num != 770528374u || Operators.CompareString(name, "TimeSinceDetection_Visual", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TimeSinceDetection_Radar", false) != 0)
										{
											continue;
										}
										goto IL_2C6;
									}
									contactEntry.TSD_Visual = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								if (num <= 863132826u)
								{
									if (num != 818239444u)
									{
										if (num != 863132826u)
										{
											continue;
										}
										if (Operators.CompareString(name, "TSD_SonarActive", false) != 0)
										{
											continue;
										}
										goto IL_3E5;
									}
									else
									{
										if (Operators.CompareString(name, "NoDetectionCount", false) != 0)
										{
											continue;
										}
										goto IL_22A;
									}
								}
								else if (num != 894866588u)
								{
									if (num != 998171479u)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeSinceDetection_Infrared", false) != 0)
									{
										continue;
									}
									goto IL_3A9;
								}
								else if (Operators.CompareString(name, "TSD", false) != 0)
								{
									continue;
								}
								IL_1BB:
								contactEntry.TimeSinceDetection = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
								continue;
							}
							if (num <= 1940690115u)
							{
								if (num <= 1591216164u)
								{
									if (num != 1453604037u)
									{
										if (num == 1591216164u && Operators.CompareString(name, "NDC", false) == 0)
										{
											goto IL_22A;
										}
										continue;
									}
									else if (Operators.CompareString(name, "TimeSinceDetection_ESM", false) != 0)
									{
										continue;
									}
								}
								else if (num != 1779304655u)
								{
									if (num == 1940690115u && Operators.CompareString(name, "Contact", false) == 0)
									{
										contactEntry.m_Contact = null;
										string_2 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TSD_Radar", false) == 0)
									{
										goto IL_2C6;
									}
									continue;
								}
							}
							else
							{
								if (num <= 2732107685u)
								{
									if (num != 2183398782u)
									{
										if (num != 2732107685u)
										{
											continue;
										}
										if (Operators.CompareString(name, "TSD_SonarPassive", false) != 0)
										{
											continue;
										}
									}
									else if (Operators.CompareString(name, "TimeSinceDetection_SonarPassive", false) != 0)
									{
										continue;
									}
									contactEntry.TSD_SonarPassive = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								if (num != 2988962680u)
								{
									if (num != 3093760719u)
									{
										if (num == 3704493208u && Operators.CompareString(name, "TSD_Infrared", false) == 0)
										{
											goto IL_3A9;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TimeSinceDetection_SonarActive", false) == 0)
										{
											goto IL_3E5;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "TSD_ESM", false) != 0)
								{
									continue;
								}
							}
							contactEntry.TSD_ESM = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
							IL_22A:
							contactEntry.NoDetectionCount = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							continue;
							IL_2C6:
							contactEntry.TSD_Radar = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
							IL_3A9:
							contactEntry.TSD_Infrared = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
							IL_3E5:
							contactEntry.TSD_SonarActive = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					result = contactEntry;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101218", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new ActiveUnit_Sensory.ContactEntry();
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06003CFB RID: 15611 RVA: 0x0001FEA5 File Offset: 0x0001E0A5
			public ContactEntry()
			{
				this.TimeSinceDetection = 0f;
				this.NoDetectionCount = 0f;
			}

			// Token: 0x04001BBD RID: 7101
			public float TimeSinceDetection;

			// Token: 0x04001BBE RID: 7102
			public float? TSD_Radar;

			// Token: 0x04001BBF RID: 7103
			public float? TSD_ESM;

			// Token: 0x04001BC0 RID: 7104
			public float? TSD_Visual;

			// Token: 0x04001BC1 RID: 7105
			public float? TSD_Infrared;

			// Token: 0x04001BC2 RID: 7106
			public float? TSD_SonarActive;

			// Token: 0x04001BC3 RID: 7107
			public float? TSD_SonarPassive;

			// Token: 0x04001BC4 RID: 7108
			public Contact m_Contact;

			// Token: 0x04001BC5 RID: 7109
			public float NoDetectionCount;
		}
	}
}
