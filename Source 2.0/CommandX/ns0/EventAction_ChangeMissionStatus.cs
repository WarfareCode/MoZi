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
	// Token: 0x02000A35 RID: 2613
	public sealed class EventAction_ChangeMissionStatus : EventAction
	{
		// Token: 0x0600531A RID: 21274 RVA: 0x00026937 File Offset: 0x00024B37
		public EventAction_ChangeMissionStatus()
		{
			this.eventActionType = EventAction.EventActionType.ChangeMissionStatus;
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0021FDB0 File Offset: 0x0021DFB0
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_ChangeMissionStatus");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("MissionID", this.MissionID);
				string localName = "NewStatus";
				byte b = (byte)this.missionStatus;
				xmlWriter_0.WriteElementString(localName, b.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100502", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0021FE6C File Offset: 0x0021E06C
		public static EventAction_ChangeMissionStatus smethod_1(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventAction_ChangeMissionStatus eventAction_ChangeMissionStatus = new EventAction_ChangeMissionStatus();
			EventAction_ChangeMissionStatus result;
			try
			{
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
								if (Operators.CompareString(name, "MissionID", false) != 0)
								{
									if (Operators.CompareString(name, "NewStatus", false) == 0)
									{
										eventAction_ChangeMissionStatus.missionStatus = (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText);
									}
								}
								else
								{
									eventAction_ChangeMissionStatus.MissionID = xmlNode.InnerText;
								}
							}
							else
							{
								eventAction_ChangeMissionStatus.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventAction_ChangeMissionStatus.SetGuid(xmlNode.InnerText);
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
				result = eventAction_ChangeMissionStatus;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100503", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventAction_ChangeMissionStatus();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x0021FFBC File Offset: 0x0021E1BC
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
						foreach (Mission current in side.GetMissionCollection())
						{
							if (string.CompareOrdinal(current.GetGuid(), this.MissionID) == 0)
							{
								current.SetMissionStatus(scenario_0, this.missionStatus);
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100504", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x0022009C File Offset: 0x0021E29C
		public override EventAction Clone()
		{
			EventAction_ChangeMissionStatus eventAction_ChangeMissionStatus = (EventAction_ChangeMissionStatus)base.MemberwiseClone();
			eventAction_ChangeMissionStatus.SetGuid(Guid.NewGuid().ToString());
			eventAction_ChangeMissionStatus.strDescription = "[CLONE] " + this.strDescription;
			eventAction_ChangeMissionStatus.Name = "[CLONE] " + this.Name;
			return eventAction_ChangeMissionStatus;
		}

		// Token: 0x040026FB RID: 9979
		public string MissionID = "";

		// Token: 0x040026FC RID: 9980
		public Mission._MissionStatus missionStatus;
	}
}
