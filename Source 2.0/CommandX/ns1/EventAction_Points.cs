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
	// Token: 0x02000BF7 RID: 3063
	public sealed class EventAction_Points : EventAction
	{
		// Token: 0x060065F0 RID: 26096 RVA: 0x0002C2AB File Offset: 0x0002A4AB
		public EventAction_Points()
		{
			this.eventActionType = EventAction.EventActionType.Points;
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x0034F020 File Offset: 0x0034D220
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_Points");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("SideID", this.SideID);
				xmlWriter_0.WriteElementString("PointChange", this.PointChange.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100510", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0034F0D8 File Offset: 0x0034D2D8
		public static EventAction_Points smethod_1(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventAction_Points result = null;
			try
			{
				EventAction_Points eventAction_Points = new EventAction_Points();
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
								if (Operators.CompareString(name, "SideID", false) != 0)
								{
									if (Operators.CompareString(name, "PointChange", false) == 0)
									{
										eventAction_Points.PointChange = Conversions.ToInteger(xmlNode.InnerText);
									}
								}
								else
								{
									eventAction_Points.SideID = xmlNode.InnerText;
								}
							}
							else
							{
								eventAction_Points.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventAction_Points.SetGuid(xmlNode.InnerText);
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
				result = eventAction_Points;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100511", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x0034F228 File Offset: 0x0034D428
		public override void FireEventAction(Scenario scenario_0, SimEvent simEvent_0)
		{
			checked
			{
				try
				{
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (Operators.CompareString(side.GetGuid(), this.SideID, false) == 0)
						{
							Side side2;
							string reasonForChange;
							(side2 = side).ChangeScore(scenario_0, reasonForChange = string.Concat(new string[]
							{
								"事件动作: '",
								this.strDescription,
								"' 已触发(为事件: '",
								simEvent_0.Description,
								"的组成部分')"
							}), unchecked(side2.GetTotalScore(scenario_0, reasonForChange) + this.PointChange));
							break;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100512", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x0034F31C File Offset: 0x0034D51C
		public override EventAction Clone()
		{
			EventAction_Points eventAction_Points = (EventAction_Points)base.MemberwiseClone();
			eventAction_Points.SetGuid(Guid.NewGuid().ToString());
			eventAction_Points.strDescription = "[CLONE] " + this.strDescription;
			eventAction_Points.Name = "[CLONE] " + this.Name;
			return eventAction_Points;
		}

		// Token: 0x04003801 RID: 14337
		public string SideID = "";

		// Token: 0x04003802 RID: 14338
		public int PointChange;
	}
}
