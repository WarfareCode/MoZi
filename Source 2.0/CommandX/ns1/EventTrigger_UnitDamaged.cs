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
	// Token: 0x02000A51 RID: 2641
	public sealed class EventTrigger_UnitDamaged : EventTrigger
	{
		// Token: 0x060053F4 RID: 21492 RVA: 0x002271B8 File Offset: 0x002253B8
		public bool method_11(ActiveUnit activeUnit_1, float float_0, float float_1)
		{
			bool flag = false;
			if (float_1 >= 100f && float_0 < (float)this.DamagePercent && this.TargetFilter.method_12(activeUnit_1))
			{
				flag = true;
			}
			else if (float_0 < (float)this.DamagePercent && float_1 >= (float)this.DamagePercent && this.TargetFilter.method_12(activeUnit_1))
			{
				flag = true;
			}
			if (flag)
			{
				this.activeUnit_0 = activeUnit_1;
				activeUnit_1.m_Scenario.GetLuaSandBox().UnitX = activeUnit_1;
			}
			else
			{
				this.activeUnit_0 = null;
			}
			return flag;
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00026D81 File Offset: 0x00024F81
		public EventTrigger_UnitDamaged()
		{
			this.TargetFilter = new Target();
			this.eventTriggerType = EventTrigger.EventTriggerType.UnitDamaged;
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x00227244 File Offset: 0x00225444
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_UnitDamaged");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("DamagePercent", this.DamagePercent.ToString());
				xmlWriter_0.WriteStartElement("TargetFilter");
				this.TargetFilter.Save(xmlWriter_0, hashSet_0, scenario_0);
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100526", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00227308 File Offset: 0x00225508
		public static EventTrigger_UnitDamaged Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_UnitDamaged result = null;
			try
			{
				EventTrigger_UnitDamaged eventTrigger_UnitDamaged = new EventTrigger_UnitDamaged();
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
								if (Operators.CompareString(name, "DamagePercent", false) != 0)
								{
									if (Operators.CompareString(name, "TargetFilter", false) == 0)
									{
										eventTrigger_UnitDamaged.TargetFilter = Target.Load(xmlNode, dictionary_0, scenario_0);
									}
								}
								else
								{
									eventTrigger_UnitDamaged.DamagePercent = Conversions.ToByte(xmlNode.InnerText);
								}
							}
							else
							{
								eventTrigger_UnitDamaged.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_UnitDamaged.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_UnitDamaged;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100527", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x00227458 File Offset: 0x00225658
		public override EventTrigger Clone()
		{
			EventTrigger_UnitDamaged eventTrigger_UnitDamaged = (EventTrigger_UnitDamaged)base.MemberwiseClone();
			eventTrigger_UnitDamaged.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_UnitDamaged.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_UnitDamaged.Name = "[CLONE] " + this.Name;
			return eventTrigger_UnitDamaged;
		}

		// Token: 0x04002780 RID: 10112
		public Target TargetFilter;

		// Token: 0x04002781 RID: 10113
		public byte DamagePercent;

		// Token: 0x04002782 RID: 10114
		public ActiveUnit activeUnit_0;
	}
}
