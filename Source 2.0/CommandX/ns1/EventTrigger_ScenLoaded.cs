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
	// Token: 0x02000A44 RID: 2628
	public sealed class EventTrigger_ScenLoaded : EventTrigger
	{
		// Token: 0x06005375 RID: 21365 RVA: 0x00026B55 File Offset: 0x00024D55
		public EventTrigger_ScenLoaded()
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.ScenLoaded;
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00222D68 File Offset: 0x00220F68
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_ScenLoaded");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100520", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00222DF8 File Offset: 0x00220FF8
		public static EventTrigger_ScenLoaded Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_ScenLoaded result = null;
			try
			{
				EventTrigger_ScenLoaded eventTrigger_ScenLoaded = new EventTrigger_ScenLoaded();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Description", false) == 0)
							{
								eventTrigger_ScenLoaded.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_ScenLoaded.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_ScenLoaded;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100521", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventTrigger_ScenLoaded();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x00222F00 File Offset: 0x00221100
		public override EventTrigger Clone()
		{
			EventTrigger_ScenLoaded eventTrigger_ScenLoaded = (EventTrigger_ScenLoaded)base.MemberwiseClone();
			eventTrigger_ScenLoaded.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_ScenLoaded.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_ScenLoaded.Name = "[CLONE] " + this.Name;
			return eventTrigger_ScenLoaded;
		}
	}
}
