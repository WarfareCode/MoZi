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
	// Token: 0x02000A34 RID: 2612
	public sealed class EventAction_LuaScript : EventAction
	{
		// Token: 0x06005315 RID: 21269 RVA: 0x00026928 File Offset: 0x00024B28
		public EventAction_LuaScript()
		{
			this.eventActionType = EventAction.EventActionType.LuaScript;
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0021FAE8 File Offset: 0x0021DCE8
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_LuaScript");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("ScriptText", this.ScriptText);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101317", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x0021FB88 File Offset: 0x0021DD88
		public static EventAction_LuaScript Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventAction_LuaScript result;
			try
			{
				EventAction_LuaScript eventAction_LuaScript = new EventAction_LuaScript();
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
								if (Operators.CompareString(name, "ScriptText", false) == 0)
								{
									eventAction_LuaScript.ScriptText = xmlNode.InnerText;
								}
							}
							else
							{
								eventAction_LuaScript.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventAction_LuaScript.SetGuid(xmlNode.InnerText);
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
				result = eventAction_LuaScript;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101315", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventAction_LuaScript();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x0021FCB0 File Offset: 0x0021DEB0
		public override void FireEventAction(Scenario scenario_0, SimEvent simEvent_0)
		{
			try
			{
				scenario_0.GetLuaSandBox().RunScript(this.ScriptText, false, simEvent_0.Description);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				scenario_0.LogMessage("Lua script execution error: " + ex2.Source + " " + ex2.Message, LoggedMessage.MessageType.EventEngine, 0, null, null, null);
				ex2.Data.Add("Error at 101316", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x0021FD4C File Offset: 0x0021DF4C
		public override EventAction Clone()
		{
			EventAction_LuaScript eventAction_LuaScript = (EventAction_LuaScript)base.MemberwiseClone();
			eventAction_LuaScript.SetGuid(Guid.NewGuid().ToString());
			eventAction_LuaScript.strDescription = "[CLONE] " + this.strDescription;
			eventAction_LuaScript.Name = "[CLONE] " + this.Name;
			return eventAction_LuaScript;
		}

		// Token: 0x040026FA RID: 9978
		public string ScriptText;
	}
}
