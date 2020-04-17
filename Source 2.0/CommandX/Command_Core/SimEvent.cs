using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 仿真事件
	public sealed class SimEvent : Subject
	{
		// Token: 0x060065FA RID: 26106 RVA: 0x0034F608 File Offset: 0x0034D808
		public void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SimEvent");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.Description);
				xmlWriter_0.WriteElementString("IsRepeatable", this.IsRepeatable.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.IsActive.ToString());
				xmlWriter_0.WriteElementString("IsShown", this.IsShown.ToString());
				xmlWriter_0.WriteElementString("Probability", this.Probability.ToString());
				xmlWriter_0.WriteStartElement("Triggers");
				foreach (EventTrigger current in this.Triggers)
				{
					if (!Information.IsNothing(current))
					{
						xmlWriter_0.WriteElementString("Trigger", current.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Conditions");
				foreach (EventCondition current2 in this.Conditions)
				{
					if (!Information.IsNothing(current2))
					{
						xmlWriter_0.WriteElementString("Condition", current2.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Actions");
				foreach (EventAction current3 in this.Actions)
				{
					if (!Information.IsNothing(current3))
					{
						xmlWriter_0.WriteElementString("Action", current3.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100538", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x0034F854 File Offset: 0x0034DA54
		public static SimEvent Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			SimEvent result = null;
			try
			{
				SimEvent simEvent = new SimEvent();
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
							if (num <= 1170788892u)
							{
								if (num != 306337606u)
								{
									if (num == 1170788892u && Operators.CompareString(name, "Probability", false) == 0)
									{
										simEvent.Probability = Conversions.ToShort(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IsShown", false) == 0)
									{
										simEvent.IsShown = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1372301015u)
							{
								if (num == 1458105184u && Operators.CompareString(name, "ID", false) == 0)
								{
									simEvent.SetGuid(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Conditions", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										EventCondition item = scenario_0.GetEventConditions()[xmlNode2.InnerText];
										simEvent.Conditions.Add(item);
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
						if (num <= 2106073694u)
						{
							if (num != 1725856265u)
							{
								if (num == 2106073694u && Operators.CompareString(name, "IsRepeatable", false) == 0)
								{
									simEvent.IsRepeatable = Conversions.ToBoolean(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "Description", false) == 0)
							{
								simEvent.Description = xmlNode.InnerText;
							}
						}
						else
						{
							if (num != 2130724671u)
							{
								if (num != 3865031940u)
								{
									if (num != 4285775472u || Operators.CompareString(name, "Triggers", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
											EventTrigger item2 = scenario_0.GetEventTriggers()[xmlNode3.InnerText];
											simEvent.Triggers.Add(item2);
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
								if (Operators.CompareString(name, "Actions", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator4.MoveNext())
									{
										XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
										EventAction item3 = scenario_0.GetEventActions()[xmlNode4.InnerText];
										simEvent.Actions.Add(item3);
									}
									continue;
								}
								finally
								{
									if (enumerator4 is IDisposable)
									{
										(enumerator4 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(name, "IsActive", false) == 0)
							{
								simEvent.IsActive = Conversions.ToBoolean(xmlNode.InnerText);
							}
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
				result = simEvent;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100539", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x0034FC9C File Offset: 0x0034DE9C
		public SimEvent()
		{
			this.Triggers = new List<EventTrigger>();
			this.Conditions = new List<EventCondition>();
			this.Actions = new List<EventAction>();
			this.IsActive = true;
			this.IsRepeatable = false;
			this.IsShown = true;
			this.Probability = 100;
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x0034FCF8 File Offset: 0x0034DEF8
		public bool IsConditionsMet(Scenario scenario_)
		{
			bool flag;
			bool result;
			if (this.Conditions.Count == 0)
			{
				flag = true;
			}
			else
			{
				using (List<EventCondition>.Enumerator enumerator = this.Conditions.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.CheckEventCondition(scenario_))
						{
							result = false;
							return result;
						}
					}
				}
				flag = true;
			}
			result = flag;
			return result;
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x0034FD70 File Offset: 0x0034DF70
		public SimEvent Clone()
		{
			SimEvent simEvent = (SimEvent)base.MemberwiseClone();
			simEvent.SetGuid(Guid.NewGuid().ToString());
			simEvent.Description = "[CLONE] " + this.Description;
			simEvent.Name = "[CLONE] " + this.Name;
			simEvent.Triggers = new List<EventTrigger>();
			simEvent.Triggers.AddRange(this.Triggers);
			simEvent.Conditions = new List<EventCondition>();
			simEvent.Conditions.AddRange(this.Conditions);
			simEvent.Actions = new List<EventAction>();
			simEvent.Actions.AddRange(this.Actions);
			return simEvent;
		}

		// Token: 0x04003805 RID: 14341
		public string Description = "";

		// Token: 0x04003806 RID: 14342
		public bool IsRepeatable;

		// Token: 0x04003807 RID: 14343
		public bool IsActive;

		// Token: 0x04003808 RID: 14344
		public bool IsShown;

		// Token: 0x04003809 RID: 14345
		public short Probability;

		// Token: 0x0400380A RID: 14346
		public List<EventTrigger> Triggers;

		// Token: 0x0400380B RID: 14347
		public List<EventCondition> Conditions;

		// Token: 0x0400380C RID: 14348
		public List<EventAction> Actions;
	}
}
