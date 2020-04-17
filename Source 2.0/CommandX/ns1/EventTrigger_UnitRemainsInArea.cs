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
	// Token: 0x02000A4D RID: 2637
	public sealed class EventTrigger_UnitRemainsInArea : EventTrigger
	{
		// Token: 0x060053E4 RID: 21476 RVA: 0x00226704 File Offset: 0x00224904
		public bool method_11(Scenario scenario_0, float float_0)
		{
			bool result = false;
			try
			{
				ActiveUnit activeUnit = null;
				foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
				{
					if (this.TargetFilter.method_12(current) && current.vmethod_40(this.referencePointList, scenario_0, false))
					{
						activeUnit = current;
						break;
					}
				}
				bool flag;
				if (!Information.IsNothing(activeUnit))
				{
					this.TA += (double)float_0;
					if (this.TA > (double)this.TD)
					{
						this.TA = 0.0;
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					this.TA = 0.0;
					flag = false;
				}
				if (flag & !Information.IsNothing(activeUnit))
				{
					this.activeUnit_0 = activeUnit;
					activeUnit.m_Scenario.GetLuaSandBox().UnitX = activeUnit;
				}
				else
				{
					this.activeUnit_0 = null;
				}
				result = flag;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100535", "");
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

		// Token: 0x060053E5 RID: 21477 RVA: 0x00026D14 File Offset: 0x00024F14
		public EventTrigger_UnitRemainsInArea()
		{
			this.TargetFilter = new Target();
			this.referencePointList = new List<ReferencePoint>();
			this.eventTriggerType = EventTrigger.EventTriggerType.UnitRemainsInArea;
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x0022685C File Offset: 0x00224A5C
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_UnitRemainsInArea");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteStartElement("TargetFilter");
				this.TargetFilter.Save(xmlWriter_0, hashSet_0, scenario_0);
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Area");
				using (List<ReferencePoint>.Enumerator enumerator = this.referencePointList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("TD", this.TD.ToString());
				xmlWriter_0.WriteElementString("TA", this.TA.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100536", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x00226988 File Offset: 0x00224B88
		public static EventTrigger_UnitRemainsInArea Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_UnitRemainsInArea result = null;
			try
			{
				EventTrigger_UnitRemainsInArea eventTrigger_UnitRemainsInArea = new EventTrigger_UnitRemainsInArea();
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
								if (Operators.CompareString(name, "TargetFilter", false) != 0)
								{
									if (Operators.CompareString(name, "Area", false) != 0)
									{
										if (Operators.CompareString(name, "TD", false) == 0)
										{
											eventTrigger_UnitRemainsInArea.TD = XmlConvert.ToInt64(xmlNode.InnerText);
											continue;
										}
										if (Operators.CompareString(name, "TA", false) == 0)
										{
											eventTrigger_UnitRemainsInArea.TA = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
												eventTrigger_UnitRemainsInArea.referencePointList.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
								}
								eventTrigger_UnitRemainsInArea.TargetFilter = Target.Load(xmlNode, dictionary_0, scenario_0);
							}
							else
							{
								eventTrigger_UnitRemainsInArea.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_UnitRemainsInArea.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_UnitRemainsInArea;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100537", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventTrigger_UnitRemainsInArea();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00226BC4 File Offset: 0x00224DC4
		public override EventTrigger Clone()
		{
			EventTrigger_UnitRemainsInArea eventTrigger_UnitRemainsInArea = (EventTrigger_UnitRemainsInArea)base.MemberwiseClone();
			eventTrigger_UnitRemainsInArea.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_UnitRemainsInArea.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_UnitRemainsInArea.Name = "[CLONE] " + this.Name;
			return eventTrigger_UnitRemainsInArea;
		}

		// Token: 0x04002773 RID: 10099
		public Target TargetFilter;

		// Token: 0x04002774 RID: 10100
		public List<ReferencePoint> referencePointList;

		// Token: 0x04002775 RID: 10101
		public long TD;

		// Token: 0x04002776 RID: 10102
		private double TA;

		// Token: 0x04002777 RID: 10103
		public ActiveUnit activeUnit_0;
	}
}
