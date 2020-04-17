using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1
{
	// Token: 0x02000A3F RID: 2623
	public sealed class EventCondition_SidePosture : EventCondition
	{
		// Token: 0x06005357 RID: 21335 RVA: 0x00026ACA File Offset: 0x00024CCA
		public EventCondition_SidePosture()
		{
			this.eventConditionType = EventCondition.EventConditionType.SidePosture;
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x00221958 File Offset: 0x0021FB58
		public override bool CheckEventCondition(Scenario scenario_0)
		{
			bool result = false;
			checked
			{
				try
				{
					Side side = null;
					Side side2 = null;
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side3 = sides[i];
						if (Operators.CompareString(side3.GetGuid(), this.ObserverSideID, false) == 0)
						{
							side = side3;
						}
						if (Operators.CompareString(side3.GetGuid(), this.TargetSideID, false) == 0)
						{
							side2 = side3;
						}
					}
					if (!Information.IsNothing(side) && !Information.IsNothing(side2))
					{
						bool? flag = new bool?(side.GetPostureStance(side2) == this.TargetPosture);
						if (Information.IsNothing(flag))
						{
							result = false;
						}
						else if (!this.NOT)
						{
							result = flag.Value;
						}
						else
						{
							result = !flag.Value;
						}
					}
					else
					{
						result = false;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100516", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00221A7C File Offset: 0x0021FC7C
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventCondition_SidePosture");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("ObserverSideID", this.ObserverSideID);
				xmlWriter_0.WriteElementString("TargetSideID", this.TargetSideID);
				if (!Information.IsNothing(this.TargetPosture))
				{
					xmlWriter_0.WriteElementString("TargetPosture", Conversions.ToString((int)this.TargetPosture));
				}
				if (this.NOT)
				{
					xmlWriter_0.WriteElementString("NOT", 1.ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100517", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x00221B74 File Offset: 0x0021FD74
		public static EventCondition_SidePosture Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventCondition_SidePosture result = null;
			try
			{
				EventCondition_SidePosture eventCondition_SidePosture = new EventCondition_SidePosture();
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
								if (Operators.CompareString(name, "ObserverSideID", false) != 0)
								{
									if (Operators.CompareString(name, "TargetSideID", false) != 0)
									{
										if (Operators.CompareString(name, "TargetPosture", false) != 0)
										{
											if (Operators.CompareString(name, "NOT", false) == 0)
											{
												eventCondition_SidePosture.NOT = true;
											}
										}
										else
										{
											eventCondition_SidePosture.TargetPosture = (Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText);
										}
									}
									else
									{
										eventCondition_SidePosture.TargetSideID = xmlNode.InnerText;
									}
								}
								else
								{
									eventCondition_SidePosture.ObserverSideID = xmlNode.InnerText;
								}
							}
							else
							{
								eventCondition_SidePosture.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventCondition_SidePosture.SetGuid(xmlNode.InnerText);
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
				result = eventCondition_SidePosture;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100518", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventCondition_SidePosture();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00221D20 File Offset: 0x0021FF20
		public override EventCondition Clone()
		{
			EventCondition_SidePosture eventCondition_SidePosture = (EventCondition_SidePosture)base.MemberwiseClone();
			eventCondition_SidePosture.SetGuid(Guid.NewGuid().ToString());
			eventCondition_SidePosture.strDescription = "[CLONE] " + this.strDescription;
			eventCondition_SidePosture.Name = "[CLONE] " + this.Name;
			return eventCondition_SidePosture;
		}

		// Token: 0x04002714 RID: 10004
		public string ObserverSideID;

		// Token: 0x04002715 RID: 10005
		public string TargetSideID;

		// Token: 0x04002716 RID: 10006
		public Misc.PostureStance TargetPosture;

		// Token: 0x04002717 RID: 10007
		public bool NOT;
	}
}
