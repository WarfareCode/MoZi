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
	// Token: 0x02000BF8 RID: 3064
	public sealed class EventTrigger_UnitDestroyed : EventTrigger
	{
		// Token: 0x060065F5 RID: 26101 RVA: 0x0034F380 File Offset: 0x0034D580
		public bool method_11(ActiveUnit activeUnit_1)
		{
			bool flag;
			bool result;
			if (flag = this.TargetFilter.method_12(activeUnit_1))
			{
				this.activeUnit_0 = activeUnit_1;
				activeUnit_1.m_Scenario.GetLuaSandBox().UnitX = activeUnit_1;
				result = flag;
			}
			else
			{
				this.activeUnit_0 = null;
				result = flag;
			}
			return result;
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x0002C2C5 File Offset: 0x0002A4C5
		public EventTrigger_UnitDestroyed()
		{
			this.TargetFilter = new Target();
			this.eventTriggerType = EventTrigger.EventTriggerType.UnitDestroyed;
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x0034F3C8 File Offset: 0x0034D5C8
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_UnitDestroyed");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteStartElement("TargetFilter");
				this.TargetFilter.Save(xmlWriter_0, hashSet_0, scenario_0);
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100528", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x0034F478 File Offset: 0x0034D678
		public static EventTrigger_UnitDestroyed Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_UnitDestroyed result = null;
			try
			{
				EventTrigger_UnitDestroyed eventTrigger_UnitDestroyed = new EventTrigger_UnitDestroyed();
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
								if (Operators.CompareString(name, "TargetFilter", false) == 0)
								{
									eventTrigger_UnitDestroyed.TargetFilter = Target.Load(xmlNode, dictionary_0, scenario_0);
								}
							}
							else
							{
								eventTrigger_UnitDestroyed.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_UnitDestroyed.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_UnitDestroyed;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100529", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventTrigger_UnitDestroyed();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x0034F5A4 File Offset: 0x0034D7A4
		public override EventTrigger Clone()
		{
			EventTrigger_UnitDestroyed eventTrigger_UnitDestroyed = (EventTrigger_UnitDestroyed)base.MemberwiseClone();
			eventTrigger_UnitDestroyed.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_UnitDestroyed.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_UnitDestroyed.Name = "[CLONE] " + this.Name;
			return eventTrigger_UnitDestroyed;
		}

		// Token: 0x04003803 RID: 14339
		public Target TargetFilter;

		// Token: 0x04003804 RID: 14340
		public ActiveUnit activeUnit_0;
	}
}
