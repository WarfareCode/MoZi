using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0
{
	// 飞机-传感器
	public sealed class Aircraft_Sensory : ActiveUnit_Sensory
	{
		// Token: 0x06004D71 RID: 19825 RVA: 0x001F0EC0 File Offset: 0x001EF0C0
		public static Aircraft_Sensory Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Aircraft_Sensory result;
			try
			{
				Aircraft_Sensory aircraft_Sensory = new Aircraft_Sensory(ref activeUnit_1);
				aircraft_Sensory.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ObeysEMCON", false) != 0 && Operators.CompareString(name, "ObE", false) != 0)
						{
							if (Operators.CompareString(name, "ContactList_Local", false) != 0 && Operators.CompareString(name, "ContactList", false) != 0)
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
										aircraft_Sensory.ContactList_OffGrid.Add(contact.string_6, contact);
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
									if (!Information.IsNothing(text) && !aircraft_Sensory.GetContactEntryDictionary().ContainsKey(text))
									{
										aircraft_Sensory.GetContactEntryDictionary().Add(text, value);
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
						aircraft_Sensory.bObeysEMCON = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = aircraft_Sensory;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100469", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_Sensory(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00024AEC File Offset: 0x00022CEC
		public Aircraft_Sensory(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x001F1138 File Offset: 0x001EF338
		public bool HasLPIRadar()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Sensor[] noneMCMSensors = this.ParentPlatform.GetNoneMCMSensors();
					for (int i = 0; i < noneMCMSensors.Length; i++)
					{
						Sensor sensor = noneMCMSensors[i];
						if (sensor.sensorType == Sensor.SensorType.Radar && (sensor.sensorCode.PulseDopplerRadar_FullLDSDCapability || sensor.sensorCode.PulseDopplerRadar_LimitedLDSDCapability))
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
					ex2.Data.Add("Error at 100470", "");
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

		// Token: 0x06004D74 RID: 19828 RVA: 0x001F11FC File Offset: 0x001EF3FC
		public override void ScheduleEMCONEvent(Sensor[] sensor_0)
		{
			checked
			{
				try
				{
					Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttackDoctrine = this.ParentPlatform.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
					byte? b = ignoreEMCONUnderAttackDoctrine.HasValue ? new byte?((byte)ignoreEMCONUnderAttackDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && this.ParentPlatform.GetAI().vmethod_9())
					{
						for (int i = 0; i < sensor_0.Length; i++)
						{
							Sensor sensor = sensor_0[i];
							if (sensor.IsActiveCapable())
							{
								sensor.TurnOn();
							}
						}
					}
					else
					{
						base.ScheduleEMCONEvent(sensor_0);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100471", "");
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
