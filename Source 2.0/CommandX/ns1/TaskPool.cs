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
	// Token: 0x02000A7D RID: 2685
	public sealed class TaskPool : Mission
	{
		// Token: 0x060054FB RID: 21755 RVA: 0x00237338 File Offset: 0x00235538
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("TaskPool");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.category).ToString());
				xmlWriter_0.WriteStartElement("Packages");
				foreach (Mission current in this.Packages)
				{
					if (!Information.IsNothing(current))
					{
						xmlWriter_0.WriteElementString("ID", current.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				if (this.START.HasValue)
				{
					xmlWriter_0.WriteElementString("START", this.START.Value.ToBinary().ToString());
				}
				if (this.END.HasValue)
				{
					xmlWriter_0.WriteElementString("END", this.END.Value.ToBinary().ToString());
				}
				if (this.TakeOffTime.HasValue)
				{
					xmlWriter_0.WriteElementString("TakeOffTime", this.TakeOffTime.Value.ToBinary().ToString());
				}
				if (this.TimeOnTarget.HasValue)
				{
					xmlWriter_0.WriteElementString("TimeOnTarget", this.TimeOnTarget.Value.ToBinary().ToString());
				}
				xmlWriter_0.WriteElementString("Deactivation_UnassignUnits", this.Deactivation_UnassignUnits.ToString());
				xmlWriter_0.WriteElementString("CheckBox_OrderRTB", this.CheckBox_OrderRTB.ToString());
				xmlWriter_0.WriteElementString("CheckBox_DeleteMission", this.CheckBox_DeleteMission.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200648", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00237590 File Offset: 0x00235790
		public new static TaskPool Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			TaskPool taskPool = null;
			TaskPool result;
			try
			{
				Side side = null;
				TaskPool taskPool2 = new TaskPool(ref side, ref scenario_0, "", Mission.MissionCategory.Mission);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Name", false) != 0)
							{
								if (Operators.CompareString(name, "Category", false) != 0)
								{
									if (Operators.CompareString(name, "Packages", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
											taskPool2.PackageNames.Add(xmlNode2.InnerText);
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
								taskPool2.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
							}
							else
							{
								taskPool2.Name = xmlNode.InnerText;
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								taskPool = (TaskPool)dictionary_0[xmlNode.InnerText];
								result = taskPool;
								return result;
							}
							taskPool2.SetGuid(xmlNode.InnerText);
							dictionary_0.Add(taskPool2.GetGuid(), taskPool2);
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
				taskPool = taskPool2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200649", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = taskPool;
			return result;
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x0002716D File Offset: 0x0002536D
		public TaskPool(ref Side side_0, ref Scenario scenario_0, string string_3, Mission.MissionCategory enum58_1) : base(side_0, scenario_0)
		{
			this.Packages = new List<Mission>();
			this.PackageNames = new List<string>();
			this.IsMission = true;
			this.Name = string_3;
			this.category = enum58_1;
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x002377A8 File Offset: 0x002359A8
		public override string GetTypeString(Scenario scenario_0)
		{
			return "任务（Task）池";
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x002377BC File Offset: 0x002359BC
		public override void vmethod_6(ref Scenario scenario_0, Side side_0, bool bool_15)
		{
			checked
			{
				try
				{
					foreach (string current in this.PackageNames)
					{
						Side[] sides = scenario_0.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							foreach (Mission current2 in side.GetMissionCollection())
							{
								if (Operators.CompareString(current2.GetGuid(), current, false) == 0)
								{
									this.Packages.Add(current2);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200650", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x04002931 RID: 10545
		public List<Mission> Packages;

		// Token: 0x04002932 RID: 10546
		public List<string> PackageNames;
	}
}
