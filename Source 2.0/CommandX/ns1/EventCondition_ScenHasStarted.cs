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
	// Token: 0x02000A3E RID: 2622
	public sealed class EventCondition_ScenHasStarted : EventCondition
	{
		// Token: 0x06005352 RID: 21330 RVA: 0x00026ABB File Offset: 0x00024CBB
		public EventCondition_ScenHasStarted()
		{
			this.eventConditionType = EventCondition.EventConditionType.ScenHasStarted;
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x002216A4 File Offset: 0x0021F8A4
		public override bool CheckEventCondition(Scenario scenario_0)
		{
			bool result = false;
			try
			{
				if (!this.NOT)
				{
					result = scenario_0.HasStarted();
				}
				else
				{
					result = !scenario_0.HasStarted();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101321", "");
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

		// Token: 0x06005354 RID: 21332 RVA: 0x00221720 File Offset: 0x0021F920
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventCondition_ScenHasStarted");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				if (this.NOT)
				{
					xmlWriter_0.WriteElementString("NOT", 1.ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101322", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x002217D0 File Offset: 0x0021F9D0
		public static EventCondition_ScenHasStarted Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventCondition_ScenHasStarted result = null;
			try
			{
				EventCondition_ScenHasStarted eventCondition_ScenHasStarted = new EventCondition_ScenHasStarted();
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
								if (Operators.CompareString(name, "NOT", false) == 0)
								{
									eventCondition_ScenHasStarted.NOT = true;
								}
							}
							else
							{
								eventCondition_ScenHasStarted.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventCondition_ScenHasStarted.SetGuid(xmlNode.InnerText);
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
				result = eventCondition_ScenHasStarted;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101323", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventCondition_ScenHasStarted();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x002218F4 File Offset: 0x0021FAF4
		public override EventCondition Clone()
		{
			EventCondition_ScenHasStarted eventCondition_ScenHasStarted = (EventCondition_ScenHasStarted)base.MemberwiseClone();
			eventCondition_ScenHasStarted.SetGuid(Guid.NewGuid().ToString());
			eventCondition_ScenHasStarted.strDescription = "[CLONE] " + this.strDescription;
			eventCondition_ScenHasStarted.Name = "[CLONE] " + this.Name;
			return eventCondition_ScenHasStarted;
		}

		// Token: 0x04002713 RID: 10003
		public bool NOT;
	}
}
