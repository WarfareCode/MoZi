using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;

namespace Command_Core
{
	// Token: 0x02000A3B RID: 2619
	public class EventCondition : Subject
	{
		// Token: 0x06005349 RID: 21321 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual bool CheckEventCondition(Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x002213DC File Offset: 0x0021F5DC
		public static EventCondition Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			string name = xmlNode_0.Name;
			EventCondition result;
			if (Operators.CompareString(name, "EventCondition_SidePosture", false) != 0)
			{
				if (Operators.CompareString(name, "EventCondition_ScenHasStarted", false) != 0)
				{
					if (Operators.CompareString(name, "EventCondition_LuaScript", false) != 0)
					{
						throw new NotImplementedException();
					}
					result = EventCondition_LuaScript.Load(xmlNode_0, dictionary_0, scenario_0);
				}
				else
				{
					result = EventCondition_ScenHasStarted.Load(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			else
			{
				result = EventCondition_SidePosture.Load(xmlNode_0, dictionary_0, scenario_0);
			}
			return result;
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual EventCondition Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400270C RID: 9996
		public string strDescription = "";

		// Token: 0x0400270D RID: 9997
		public EventCondition.EventConditionType eventConditionType;

		// Token: 0x02000A3C RID: 2620
		public enum EventConditionType : byte
		{
			// Token: 0x0400270F RID: 9999
			SidePosture,
			// Token: 0x04002710 RID: 10000
			ScenHasStarted,
			// Token: 0x04002711 RID: 10001
			LuaScript
		}
	}
}
