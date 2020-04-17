using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;

namespace Command_Core
{
	// Token: 0x02000A32 RID: 2610
	public class EventAction : Subject
	{
		// Token: 0x06005310 RID: 21264 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x0021F9B8 File Offset: 0x0021DBB8
		public static EventAction smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			EventAction result = null;
			try
			{
				string name = xmlNode_0.Name;
				if (Operators.CompareString(name, "EventAction_Points", false) != 0)
				{
					if (Operators.CompareString(name, "EventAction_EndScenario", false) != 0)
					{
						if (Operators.CompareString(name, "EventAction_TeleportInArea", false) != 0)
						{
							if (Operators.CompareString(name, "EventAction_Message", false) != 0)
							{
								if (Operators.CompareString(name, "EventAction_ChangeMissionStatus", false) != 0)
								{
									if (Operators.CompareString(name, "EventAction_LuaScript", false) != 0)
									{
										throw new NotImplementedException();
									}
									result = EventAction_LuaScript.Load(xmlNode_0, dictionary_0, scenario_0);
								}
								else
								{
									result = EventAction_ChangeMissionStatus.smethod_1(xmlNode_0, dictionary_0, scenario_0);
								}
							}
							else
							{
								result = EventAction_Message.Load(xmlNode_0, dictionary_0, scenario_0);
							}
						}
						else
						{
							result = EventAction_TeleportInArea.Load(xmlNode_0, dictionary_0, scenario_0);
						}
					}
					else
					{
						result = EventAction_EndScenario.smethod_1(xmlNode_0, dictionary_0, scenario_0);
					}
				}
				else
				{
					result = EventAction_Points.smethod_1(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100501", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void FireEventAction(Scenario scenario_0, SimEvent simEvent_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual EventAction Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040026F1 RID: 9969
		public string strDescription = "";

		// Token: 0x040026F2 RID: 9970
		public EventAction.EventActionType eventActionType;

		// Token: 0x02000A33 RID: 2611
		public enum EventActionType : byte
		{
			// Token: 0x040026F4 RID: 9972
			Points,
			// Token: 0x040026F5 RID: 9973
			EndScenario,
			// Token: 0x040026F6 RID: 9974
			TeleportInArea,
			// Token: 0x040026F7 RID: 9975
			Message,
			// Token: 0x040026F8 RID: 9976
			ChangeMissionStatus,
			// Token: 0x040026F9 RID: 9977
			LuaScript
		}
	}
}
