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
	// Token: 0x02000A47 RID: 2631
	public sealed class EventTrigger_RegularTime : EventTrigger
	{
		// Token: 0x060053A8 RID: 21416 RVA: 0x002243D4 File Offset: 0x002225D4
		public bool method_11(Scenario scenario_0)
		{
			bool result;
			switch (this.Interval)
			{
			case EventTrigger_RegularTime._Interval.Second:
				result = scenario_0.SecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.FifthSecond:
				result = scenario_0.FifthSecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.FifteenthSecond:
				result = scenario_0.FifteenthSecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.ThirtiethSecond:
				result = scenario_0.ThirtiethSecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.Minute:
				result = scenario_0.MinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.FifthMinute:
				result = scenario_0.FifthMinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.FifteenthMinute:
				result = scenario_0.FifteenthMinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.ThirtiethMinute:
				result = scenario_0.ThirtiethMinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime._Interval.Hour:
				result = scenario_0.HourIsChangingOnThisPulse;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x00026C12 File Offset: 0x00024E12
		public EventTrigger_RegularTime()
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.RegularTime;
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00224468 File Offset: 0x00222668
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_RegularTime");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				string localName = "Interval";
				int interval = (int)this.Interval;
				xmlWriter_0.WriteElementString(localName, interval.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100320968409868", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00224514 File Offset: 0x00222714
		public static EventTrigger_RegularTime Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_RegularTime result = null;
			try
			{
				EventTrigger_RegularTime eventTrigger_RegularTime = new EventTrigger_RegularTime();
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
								if (Operators.CompareString(name, "Interval", false) == 0)
								{
									eventTrigger_RegularTime.Interval = (EventTrigger_RegularTime._Interval)Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else
							{
								eventTrigger_RegularTime.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_RegularTime.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_RegularTime;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 10004356945678578882", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00224640 File Offset: 0x00222840
		public override EventTrigger Clone()
		{
			EventTrigger_RegularTime eventTrigger_RegularTime = (EventTrigger_RegularTime)base.MemberwiseClone();
			eventTrigger_RegularTime.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_RegularTime.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_RegularTime.Name = "[CLONE] " + this.Name;
			return eventTrigger_RegularTime;
		}

		// Token: 0x04002747 RID: 10055
		public EventTrigger_RegularTime._Interval Interval;

		// Token: 0x02000A48 RID: 2632
		public enum _Interval
		{
			// Token: 0x04002749 RID: 10057
			Second,
			// Token: 0x0400274A RID: 10058
			FifthSecond,
			// Token: 0x0400274B RID: 10059
			FifteenthSecond,
			// Token: 0x0400274C RID: 10060
			ThirtiethSecond,
			// Token: 0x0400274D RID: 10061
			Minute,
			// Token: 0x0400274E RID: 10062
			FifthMinute,
			// Token: 0x0400274F RID: 10063
			FifteenthMinute,
			// Token: 0x04002750 RID: 10064
			ThirtiethMinute,
			// Token: 0x04002751 RID: 10065
			Hour
		}
	}
}
