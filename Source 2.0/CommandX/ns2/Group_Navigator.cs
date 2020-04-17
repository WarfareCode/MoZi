using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns2
{
	// Token: 0x02000AF6 RID: 2806
	public sealed class Group_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x06005A9F RID: 23199 RVA: 0x00283714 File Offset: 0x00281914
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Group_Navigator");
				xmlWriter_0.WriteStartElement("PlottedCourse");
				List<Waypoint> list = new List<Waypoint>();
				list.AddRange(base.GetPlottedCourse());
				foreach (Waypoint current in list)
				{
					if (!Information.IsNothing(current))
					{
						current.Save(ref xmlWriter_0, ref hashSet_0);
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("PC_PP");
				List<Waypoint> list2 = new List<Waypoint>();
				list2.AddRange(base.GetPlottedCourse_PrePlanned());
				foreach (Waypoint current2 in list2)
				{
					if (!Information.IsNothing(current2))
					{
						current2.Save(ref xmlWriter_0, ref hashSet_0);
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("ManualPlotOverride", this.ManualPlotOverride.ToString());
				if (!Information.IsNothing(this.SupportMission_NextRefPoint))
				{
					xmlWriter_0.WriteStartElement("SupportMission_NextRefPoint");
					ReferencePoint supportMission_NextRefPoint = this.SupportMission_NextRefPoint;
					HashSet<string> hashSet = null;
					supportMission_NextRefPoint.Save(ref xmlWriter_0, ref hashSet);
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100620", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x002838D0 File Offset: 0x00281AD0
		public static Group_Navigator Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Group_Navigator result = null;
			try
			{
				Group_Navigator group_Navigator = new Group_Navigator(ref activeUnit_1);
				group_Navigator.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "PlottedCourse", false) != 0)
						{
							if (Operators.CompareString(name, "PC_PP", false) != 0)
							{
								if (Operators.CompareString(name, "ManualPlotOverride", false) == 0)
								{
									group_Navigator.ManualPlotOverride = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								if (Operators.CompareString(name, "SupportMission_NextRefPoint", false) == 0)
								{
									ActiveUnit_Navigator activeUnit_Navigator = group_Navigator;
									XmlNode xmlNode2 = xmlNode.ChildNodes[0];
									activeUnit_Navigator.SupportMission_NextRefPoint = ReferencePoint.Load(ref xmlNode2, ref dictionary_0);
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
										XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
										Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode3, ref dictionary_0);
										ScenarioArrayUtil.AddWaypoint(ref group_Navigator.PlottedCourse_PrePlanned, waypoint_);
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
						IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								XmlNode xmlNode4 = (XmlNode)enumerator3.Current;
								Waypoint waypoint_2 = Waypoint.smethod_9(ref xmlNode4, ref dictionary_0);
								ScenarioArrayUtil.AddWaypoint(ref group_Navigator.PlottedCourse, waypoint_2);
							}
						}
						finally
						{
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
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
				result = group_Navigator;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100621", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00028B71 File Offset: 0x00026D71
		public Group_Navigator(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x00028B7A File Offset: 0x00026D7A
		public override void SetDesiredHeading()
		{
			base.SetDesiredHeading();
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00283B30 File Offset: 0x00281D30
		public override void ClearPlottedCourse()
		{
			base.ClearPlottedCourse();
			try
			{
				if (this.ParentPlatform.IsGroup)
				{
					foreach (ActiveUnit current in ((Group)this.ParentPlatform).GetUnitsInGroup().Values)
					{
						if (!current.IsGroupLead())
						{
							current.GetNavigator().ClearPlottedCourse();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100622", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_7(float float_3)
		{
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_6(float float_3, bool bool_14)
		{
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_4(double double_0, double double_1, float float_3, float float_4)
		{
		}
	}
}
