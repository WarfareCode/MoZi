using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0
{
	// Token: 0x02000A3D RID: 2621
	public sealed class EventCondition_LuaScript : EventCondition
	{
		// Token: 0x0600534E RID: 21326 RVA: 0x00026AA1 File Offset: 0x00024CA1
		public EventCondition_LuaScript()
		{
			this.eventConditionType = EventCondition.EventConditionType.LuaScript;
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00221458 File Offset: 0x0021F658
		public override bool CheckEventCondition(Scenario scenario_0)
		{
			bool result = false;
			try
			{
				result = bool.Parse(scenario_0.GetLuaSandBox().RunScript(this.ScriptText, false, this.strDescription).ElementAt(0).ToString());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101318", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x002214E0 File Offset: 0x0021F6E0
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventCondition_LuaScript");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("ScriptText", this.ScriptText);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101319", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00221580 File Offset: 0x0021F780
		public static EventCondition_LuaScript Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventCondition_LuaScript result = null;
			try
			{
				EventCondition_LuaScript eventCondition_LuaScript = new EventCondition_LuaScript();
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
									eventCondition_LuaScript.ScriptText = xmlNode.InnerText;
								}
							}
							else
							{
								eventCondition_LuaScript.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventCondition_LuaScript.SetGuid(xmlNode.InnerText);
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
				result = eventCondition_LuaScript;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101320", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04002712 RID: 10002
		public string ScriptText = "";
	}
}
