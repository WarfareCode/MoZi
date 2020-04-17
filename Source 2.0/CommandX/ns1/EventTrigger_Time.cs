using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1
{
	// Token: 0x02000A50 RID: 2640
	public sealed class EventTrigger_Time : EventTrigger
	{
		// Token: 0x060053EE RID: 21486 RVA: 0x00026D48 File Offset: 0x00024F48
		public bool Before(DateTime dateTime_1)
		{
			return this.m_Time.CompareTo(dateTime_1) <= 0;
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x00026D5C File Offset: 0x00024F5C
		public EventTrigger_Time(DateTime dateTime_1)
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.Time;
			this.m_Time = dateTime_1;
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00026D72 File Offset: 0x00024F72
		private EventTrigger_Time()
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.Time;
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00226F70 File Offset: 0x00225170
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_Time");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("Time", this.m_Time.ToBinary().ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100524", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x0022701C File Offset: 0x0022521C
		public static EventTrigger_Time Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_Time result = null;
			try
			{
				EventTrigger_Time eventTrigger_Time = new EventTrigger_Time();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Description", false) != 0)
							{
								if (Operators.CompareString(name, "Time", false) == 0)
								{
									eventTrigger_Time.m_Time = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
								}
							}
							else
							{
								eventTrigger_Time.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_Time.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_Time;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100525", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventTrigger_Time();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00227154 File Offset: 0x00225354
		public override EventTrigger Clone()
		{
			EventTrigger_Time eventTrigger_Time = (EventTrigger_Time)base.MemberwiseClone();
			eventTrigger_Time.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_Time.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_Time.Name = "[CLONE] " + this.Name;
			return eventTrigger_Time;
		}

		// Token: 0x0400277F RID: 10111
		public DateTime m_Time;
	}
}
