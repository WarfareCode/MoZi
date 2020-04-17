using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;

namespace ns2
{
	// Token: 0x02000B79 RID: 2937
	public sealed class Ship_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x0600612D RID: 24877 RVA: 0x002E7B8C File Offset: 0x002E5D8C
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Ship_Navigator");
				if (base.GetPlottedCourse().Count<Waypoint>() > 0)
				{
					xmlWriter_0.WriteStartElement("PC");
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
				}
				xmlWriter_0.WriteElementString("MPO", this.ManualPlotOverride.ToString());
				if (!Information.IsNothing(base.GetFormationStation()))
				{
					xmlWriter_0.WriteElementString("FS_B", XmlConvert.ToString(base.GetFormationStation().Bearing));
					xmlWriter_0.WriteElementString("FS_D", XmlConvert.ToString(base.GetFormationStation().Distance));
					xmlWriter_0.WriteElementString("FS_BT", XmlConvert.ToString((byte)base.GetFormationStation().BearingType));
					if (base.GetFormationStation().SprintAndDrift)
					{
						xmlWriter_0.WriteElementString("SAD", "True");
					}
				}
				if (!Information.IsNothing(this.SupportMission_NextRefPoint))
				{
					xmlWriter_0.WriteStartElement("SM_NRP");
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
				ex2.Data.Add("Error at 100791", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x002E7D60 File Offset: 0x002E5F60
		public static Ship_Navigator Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Ship_Navigator result = null;
			try
			{
				Ship_Navigator ship_Navigator = new Ship_Navigator(ref activeUnit_1);
				ship_Navigator.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1857393043u)
						{
							if (num <= 687260455u)
							{
								if (num != 426765699u)
								{
									if (num != 527431413u)
									{
										if (num == 687260455u && Operators.CompareString(name, "SAD", false) == 0)
										{
											ship_Navigator.GetFormationStation().SprintAndDrift = true;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FS_D", false) != 0)
										{
											continue;
										}
										goto IL_293;
									}
								}
								else if (Operators.CompareString(name, "FS_B", false) != 0)
								{
									continue;
								}
							}
							else if (num != 758041653u)
							{
								if (num != 771752996u)
								{
									if (num != 1857393043u)
									{
										continue;
									}
									if (Operators.CompareString(name, "SupportMission_NextRefPoint", false) != 0)
									{
										continue;
									}
									goto IL_2C0;
								}
								else
								{
									if (Operators.CompareString(name, "PC", false) != 0)
									{
										continue;
									}
									goto IL_1CD;
								}
							}
							else
							{
								if (Operators.CompareString(name, "MPO", false) != 0)
								{
									continue;
								}
								goto IL_244;
							}
						}
						else if (num <= 3750830438u)
						{
							if (num == 2922860948u)
							{
								goto IL_22C;
							}
							if (num == 3189192397u)
							{
								if (Operators.CompareString(name, "FormationStation_Bearing", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (num == 3750830438u && Operators.CompareString(name, "PlottedCourse", false) == 0)
								{
									goto IL_1CD;
								}
								continue;
							}
						}
						else if (num != 3795020149u)
						{
							if (num != 3808473706u)
							{
								if (num == 4241447450u && Operators.CompareString(name, "FormationStation_Distance", false) == 0)
								{
									goto IL_293;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SM_NRP", false) == 0)
								{
									goto IL_2C0;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "FS_BT", false) == 0)
							{
								ship_Navigator.GetFormationStation().BearingType = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						ship_Navigator.GetFormationStation().Bearing = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_1CD:
						IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
								Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode2, ref dictionary_0);
								ScenarioArrayUtil.AddWaypoint(ref ship_Navigator.PlottedCourse, waypoint_);
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
						IL_22C:
						if (Operators.CompareString(name, "ManualPlotOverride", false) != 0)
						{
							continue;
						}
						IL_244:
						ship_Navigator.ManualPlotOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_293:
						ship_Navigator.GetFormationStation().Distance = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_2C0:
						ActiveUnit_Navigator activeUnit_Navigator = ship_Navigator;
						XmlNode xmlNode3 = xmlNode.ChildNodes[0];
						activeUnit_Navigator.SupportMission_NextRefPoint = ReferencePoint.Load(ref xmlNode3, ref dictionary_0);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = ship_Navigator;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100792", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Ship_Navigator(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x002E8140 File Offset: 0x002E6340
		public Ship_Navigator(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			this.int_0 = (int)Math.Round((double)(Math.Min(((Ship)this.ParentPlatform).Length, 100f) * 2f));
			this.int_1 = 1000;
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x002E818C File Offset: 0x002E638C
		public override void SetDesiredHeading()
		{
			base.SetDesiredHeading();
			if (Information.IsNothing(this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride()))
			{
				this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
			}
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x002E81D4 File Offset: 0x002E63D4
		public override bool vmethod_8(double double_0, double double_1, float float_3)
		{
			bool result = false;
			try
			{
				float distance = Math2.GetDistance(double_0, double_1, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
				float num;
				if (this.ParentPlatform.IsMineSweeper())
				{
					num = 0.05f;
				}
				else
				{
					num = 0.2f;
				}
				result = (distance < num);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100793", "");
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
}
