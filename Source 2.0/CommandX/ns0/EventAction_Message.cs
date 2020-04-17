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
	// Token: 0x02000A36 RID: 2614
	public sealed class EventAction_Message : EventAction
	{
		// Token: 0x0600531F RID: 21279 RVA: 0x00026951 File Offset: 0x00024B51
		public EventAction_Message()
		{
			this.eventActionType = EventAction.EventActionType.Message;
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00220100 File Offset: 0x0021E300
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_Message");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("SideID", this.SideID);
				xmlWriter_0.WriteElementString("Text", this.strText);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100507", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x002201B0 File Offset: 0x0021E3B0
		public static EventAction_Message Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventAction_Message result;
			try
			{
				EventAction_Message eventAction_Message = new EventAction_Message();
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
									if (Operators.CompareString(name, "Text", false) == 0)
									{
										eventAction_Message.strText = xmlNode.InnerText;
									}
								}
								else
								{
									eventAction_Message.SideID = xmlNode.InnerText;
								}
							}
							else
							{
								eventAction_Message.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventAction_Message.SetGuid(xmlNode.InnerText);
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
				result = eventAction_Message;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100508", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventAction_Message();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x002202FC File Offset: 0x0021E4FC
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
							scenario_0.LogMessage(this.strText, LoggedMessage.MessageType.SpecialMessage, 0, null, side, null);
							break;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100509", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x002203A4 File Offset: 0x0021E5A4
		public override EventAction Clone()
		{
			EventAction_Message eventAction_Message = (EventAction_Message)base.MemberwiseClone();
			eventAction_Message.SetGuid(Guid.NewGuid().ToString());
			eventAction_Message.strDescription = "[CLONE] " + this.strDescription;
			eventAction_Message.Name = "[CLONE] " + this.Name;
			return eventAction_Message;
		}

		// Token: 0x040026FD RID: 9981
		public string SideID = "";

		// Token: 0x040026FE RID: 9982
		public string strText = "";
	}
}
