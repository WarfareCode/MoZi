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
	// Token: 0x02000A4E RID: 2638
	public sealed class EventTrigger_Points : EventTrigger
	{
		// Token: 0x060053E9 RID: 21481 RVA: 0x00226C28 File Offset: 0x00224E28
		public bool method_11(Side side_0, int int_1, int int_2)
		{
			bool result;
			if (Operators.CompareString(side_0.GetGuid(), this.SideID, false) != 0)
			{
				result = false;
			}
			else
			{
				switch (this.reachDirection)
				{
				case EventTrigger_Points._ReachDirection.const_0:
					result = (int_1 < this.PointValue & this.PointValue <= int_2);
					break;
				case EventTrigger_Points._ReachDirection.const_1:
					result = (int_2 == this.PointValue);
					break;
				case EventTrigger_Points._ReachDirection.const_2:
					result = (int_1 > this.PointValue & this.PointValue >= int_2);
					break;
				default:
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x00026D39 File Offset: 0x00024F39
		public EventTrigger_Points()
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.Points;
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00226CAC File Offset: 0x00224EAC
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_Points");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("SideID", this.SideID);
				xmlWriter_0.WriteElementString("PointValue", this.PointValue.ToString());
				string localName = "ReachDirection";
				byte b = (byte)this.reachDirection;
				xmlWriter_0.WriteElementString(localName, b.ToString());
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

		// Token: 0x060053EC RID: 21484 RVA: 0x00226D7C File Offset: 0x00224F7C
		public static EventTrigger_Points Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_Points result = null;
			try
			{
				EventTrigger_Points eventTrigger_Points = new EventTrigger_Points();
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
									if (Operators.CompareString(name, "PointValue", false) != 0)
									{
										if (Operators.CompareString(name, "ReachDirection", false) == 0)
										{
											eventTrigger_Points.reachDirection = (EventTrigger_Points._ReachDirection)Conversions.ToByte(xmlNode.InnerText);
										}
									}
									else
									{
										eventTrigger_Points.PointValue = Conversions.ToInteger(xmlNode.InnerText);
									}
								}
								else
								{
									eventTrigger_Points.SideID = xmlNode.InnerText;
								}
							}
							else
							{
								eventTrigger_Points.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_Points.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_Points;
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
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00226F0C File Offset: 0x0022510C
		public override EventTrigger Clone()
		{
			EventTrigger_Points eventTrigger_Points = (EventTrigger_Points)base.MemberwiseClone();
			eventTrigger_Points.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_Points.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_Points.Name = "[CLONE] " + this.Name;
			return eventTrigger_Points;
		}

		// Token: 0x04002778 RID: 10104
		public string SideID;

		// Token: 0x04002779 RID: 10105
		public int PointValue;

		// Token: 0x0400277A RID: 10106
		public EventTrigger_Points._ReachDirection reachDirection;

		// Token: 0x02000A4F RID: 2639
		public enum _ReachDirection : byte
		{
			// Token: 0x0400277C RID: 10108
			const_0,
			// Token: 0x0400277D RID: 10109
			const_1,
			// Token: 0x0400277E RID: 10110
			const_2
		}
	}
}
