using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0
{
	// Token: 0x02000A37 RID: 2615
	public sealed class EventAction_EndScenario : EventAction
	{
		// Token: 0x06005324 RID: 21284 RVA: 0x00026976 File Offset: 0x00024B76
		public EventAction_EndScenario()
		{
			this.eventActionType = EventAction.EventActionType.EndScenario;
			this.strDescription = "End the scenario";
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x00220408 File Offset: 0x0021E608
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_EndScenario");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100505", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x00220488 File Offset: 0x0021E688
		public static EventAction_EndScenario smethod_1(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventAction_EndScenario result;
			try
			{
				EventAction_EndScenario eventAction_EndScenario = new EventAction_EndScenario();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) == 0)
						{
							eventAction_EndScenario.SetGuid(xmlNode.InnerText);
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
				result = eventAction_EndScenario;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100506", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventAction_EndScenario();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00026990 File Offset: 0x00024B90
		public override void FireEventAction(Scenario scenario_0, SimEvent simEvent_0)
		{
			scenario_0.ScenCompleted();
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x00220570 File Offset: 0x0021E770
		public override EventAction Clone()
		{
			EventAction_EndScenario eventAction_EndScenario = (EventAction_EndScenario)base.MemberwiseClone();
			eventAction_EndScenario.SetGuid(Guid.NewGuid().ToString());
			eventAction_EndScenario.strDescription = "[CLONE] " + this.strDescription;
			eventAction_EndScenario.Name = "[CLONE] " + this.Name;
			return eventAction_EndScenario;
		}
	}
}
