using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns1
{
	// Token: 0x02000A4B RID: 2635
	public sealed class EventTrigger_UnitEntersArea : EventTrigger
	{
		// Token: 0x060053C9 RID: 21449 RVA: 0x002255DC File Offset: 0x002237DC
		public bool method_11(Scenario scenario_0)
		{
			bool result = false;
			try
			{
				if (scenario_0.GetCurrentTime(false).CompareTo(this.ETOA) < 0)
				{
					result = false;
				}
				else if (scenario_0.GetCurrentTime(false).CompareTo(this.LTOA) > 0)
				{
					result = false;
				}
				else
				{
					ActiveUnit activeUnit = null;
					foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
					{
						if (this.TargetFilter.method_12(current))
						{
							if (current.vmethod_40(this.Area, scenario_0, false))
							{
								if (current.GetLongitude_UnitEntersAreaCheck().HasValue && current.GetLatitude_UnitEntersAreaCheck().HasValue)
								{
									if (new GeoPoint(current.GetLongitude_UnitEntersAreaCheck().Value, current.GetLatitude_UnitEntersAreaCheck().Value).method_22(ref this.Area, true))
									{
										continue;
									}
									activeUnit = current;
									current.SetLongitude_UnitEntersAreaCheck(new double?(current.GetLongitude(null)));
									current.SetLatitude_UnitEntersAreaCheck(new double?(current.GetLatitude(null)));
								}
								else
								{
									activeUnit = current;
									current.SetLongitude_UnitEntersAreaCheck(new double?(current.GetLongitude(null)));
									current.SetLatitude_UnitEntersAreaCheck(new double?(current.GetLatitude(null)));
								}
								break;
							}
							current.SetLongitude_UnitEntersAreaCheck(null);
							current.SetLatitude_UnitEntersAreaCheck(null);
						}
					}
					bool flag;
					if (!Information.IsNothing(activeUnit))
					{
						flag = !this.NOT;
					}
					else
					{
						flag = this.NOT;
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
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100532", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x00026C7B File Offset: 0x00024E7B
		public EventTrigger_UnitEntersArea()
		{
			this.TargetFilter = new Target();
			this.Area = new List<ReferencePoint>();
			this.eventTriggerType = EventTrigger.EventTriggerType.UnitEntersArea;
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00225864 File Offset: 0x00223A64
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_UnitEntersArea");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteStartElement("TargetFilter");
				this.TargetFilter.Save(xmlWriter_0, hashSet_0, scenario_0);
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Area");
				using (List<ReferencePoint>.Enumerator enumerator = this.Area.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("ETOA", this.ETOA.ToBinary().ToString());
				xmlWriter_0.WriteElementString("LTOA", this.LTOA.ToBinary().ToString());
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
				ex2.Data.Add("Error at 100533", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x002259C4 File Offset: 0x00223BC4
		public static EventTrigger_UnitEntersArea Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_UnitEntersArea result = null;
			try
			{
				EventTrigger_UnitEntersArea eventTrigger_UnitEntersArea = new EventTrigger_UnitEntersArea();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1458105184u)
						{
							if (num != 498456164u)
							{
								if (num != 1127254853u)
								{
									if (num == 1458105184u && Operators.CompareString(name, "ID", false) == 0)
									{
										eventTrigger_UnitEntersArea.SetGuid(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LTOA", false) == 0)
									{
										eventTrigger_UnitEntersArea.LTOA = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
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
										eventTrigger_UnitEntersArea.Area.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
						if (num <= 2884519850u)
						{
							if (num != 1725856265u)
							{
								if (num == 2884519850u && Operators.CompareString(name, "NOT", false) == 0)
								{
									eventTrigger_UnitEntersArea.NOT = true;
								}
							}
							else if (Operators.CompareString(name, "Description", false) == 0)
							{
								eventTrigger_UnitEntersArea.strDescription = xmlNode.InnerText;
							}
						}
						else if (num != 3169090008u)
						{
							if (num == 3467603482u && Operators.CompareString(name, "TargetFilter", false) == 0)
							{
								eventTrigger_UnitEntersArea.TargetFilter = Target.Load(xmlNode, dictionary_0, scenario_0);
							}
						}
						else if (Operators.CompareString(name, "ETOA", false) == 0)
						{
							eventTrigger_UnitEntersArea.ETOA = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
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
				result = eventTrigger_UnitEntersArea;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100534", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x00225C9C File Offset: 0x00223E9C
		public override EventTrigger Clone()
		{
			EventTrigger_UnitEntersArea eventTrigger_UnitEntersArea = (EventTrigger_UnitEntersArea)base.MemberwiseClone();
			eventTrigger_UnitEntersArea.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_UnitEntersArea.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_UnitEntersArea.Name = "[CLONE] " + this.Name;
			return eventTrigger_UnitEntersArea;
		}

		// Token: 0x04002764 RID: 10084
		public Target TargetFilter;

		// Token: 0x04002765 RID: 10085
		public List<ReferencePoint> Area;

		// Token: 0x04002766 RID: 10086
		public DateTime ETOA;

		// Token: 0x04002767 RID: 10087
		public DateTime LTOA;

		// Token: 0x04002768 RID: 10088
		public bool NOT;

		// Token: 0x04002769 RID: 10089
		public ActiveUnit activeUnit_0;
	}
}
