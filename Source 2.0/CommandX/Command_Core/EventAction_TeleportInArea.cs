using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// Token: 0x02000A3A RID: 2618
	public sealed class EventAction_TeleportInArea : EventAction
	{
		// Token: 0x06005342 RID: 21314 RVA: 0x00026A45 File Offset: 0x00024C45
		public EventAction_TeleportInArea()
		{
			this.UnitIDs = new HashSet<string>();
			this.Area = new List<ReferencePoint>();
			this.eventActionType = EventAction.EventActionType.TeleportInArea;
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00220D38 File Offset: 0x0021EF38
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_1, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_TeleportInArea");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteStartElement("UnitIDs");
				foreach (string current in this.UnitIDs)
				{
					xmlWriter_0.WriteElementString("ID", current);
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Area");
				using (List<ReferencePoint>.Enumerator enumerator2 = this.Area.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_1);
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100513", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00220E74 File Offset: 0x0021F074
		public static EventAction_TeleportInArea Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventAction_TeleportInArea result;
			try
			{
				EventAction_TeleportInArea eventAction_TeleportInArea = new EventAction_TeleportInArea();
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
								if (Operators.CompareString(name, "UnitIDs", false) != 0)
								{
									if (Operators.CompareString(name, "Area", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
											eventAction_TeleportInArea.Area.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
										}
										continue;
									}
									finally
									{
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
								}
								IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
										eventAction_TeleportInArea.UnitIDs.Add(xmlNode3.InnerText);
									}
									continue;
								}
								finally
								{
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							eventAction_TeleportInArea.strDescription = xmlNode.InnerText;
						}
						else
						{
							eventAction_TeleportInArea.SetGuid(xmlNode.InnerText);
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
				result = eventAction_TeleportInArea;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100514", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventAction_TeleportInArea();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x002210A8 File Offset: 0x0021F2A8
		public override void FireEventAction(Scenario scenario_0, SimEvent simEvent_0)
		{
			try
			{
				foreach (string current in this.UnitIDs)
				{
					ActiveUnit activeUnit = null;
					try
					{
						activeUnit = scenario_0.GetActiveUnits()[current];
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200459", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
						continue;
					}
					if (!Information.IsNothing(activeUnit))
					{
						int i = 0;
						while (i < 1000)
						{
							GeoPoint geoPoint = Math2.PickSuitablePointInsideArea(this.Area);
							if (Information.IsNothing(geoPoint))
							{
								string str = "";
								if (activeUnit.IsAircraft && Operators.CompareString(activeUnit.Name, activeUnit.UnitClass, false) != 0)
								{
									str = " (" + activeUnit.UnitClass + ")";
								}
								activeUnit.LogMessage(activeUnit.Name + str + " is unable to pick a suitable point inside area defined by Ref. Points: " + string.Join(" - ", this.Area.Select(EventAction_TeleportInArea.ReferencePointFunc)), LoggedMessage.MessageType.UnitAI, 1, false, new GeoPoint(activeUnit.GetLongitude(null), activeUnit.GetLatitude(null)));
								return;
							}
							try
							{
								i++;
								Unit unit = activeUnit;
								double latitude = geoPoint.GetLatitude();
								double longitude = geoPoint.GetLongitude();
								byte b = 0;
								bool flag = true;
								bool flag2 = true;
								List<ActiveUnit> list = null;
								if (unit.vmethod_41(latitude, longitude, ref b, true, ref flag, true, ref flag2, null, null, ref list, 0f, false, false))
								{
									activeUnit.SetGeoLocation(ref scenario_0, geoPoint.GetLongitude(), geoPoint.GetLatitude());
									break;
								}
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ex4.Data.Add("Error at 200460", ex4.Message);
								GameGeneral.LogException(ref ex4);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100515", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00221378 File Offset: 0x0021F578
		public override EventAction Clone()
		{
			EventAction_TeleportInArea eventAction_TeleportInArea = (EventAction_TeleportInArea)base.MemberwiseClone();
			eventAction_TeleportInArea.SetGuid(Guid.NewGuid().ToString());
			eventAction_TeleportInArea.strDescription = "[CLONE] " + this.strDescription;
			eventAction_TeleportInArea.Name = "[CLONE] " + this.Name;
			return eventAction_TeleportInArea;
		}

		// Token: 0x04002708 RID: 9992
		public static Func<ReferencePoint, string> ReferencePointFunc = (ReferencePoint referencePoint_0) => referencePoint_0.Name;

		// Token: 0x04002709 RID: 9993
		public HashSet<string> UnitIDs;

		// Token: 0x0400270A RID: 9994
		public List<ReferencePoint> Area;
	}
}
