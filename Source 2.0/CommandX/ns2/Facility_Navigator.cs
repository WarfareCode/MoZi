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
	// Token: 0x02000ABF RID: 2751
	public sealed class Facility_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x060057EA RID: 22506 RVA: 0x00269558 File Offset: 0x00267758
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Navigator");
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
				if (!Information.IsNothing(base.GetFormationStation()))
				{
					xmlWriter_0.WriteElementString("MPO", this.ManualPlotOverride.ToString());
					xmlWriter_0.WriteElementString("FS_B", XmlConvert.ToString(base.GetFormationStation().Bearing));
					xmlWriter_0.WriteElementString("FS_D", XmlConvert.ToString(base.GetFormationStation().Distance));
					xmlWriter_0.WriteElementString("FS_BT", XmlConvert.ToString((byte)base.GetFormationStation().BearingType));
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
				ex2.Data.Add("Error at 100561", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x0026970C File Offset: 0x0026790C
		public static Facility_Navigator Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Facility_Navigator result = null;
			try
			{
				Facility_Navigator facility_Navigator = new Facility_Navigator(ref activeUnit_1);
				facility_Navigator.ParentPlatform = activeUnit_1;
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
							if (num <= 527431413u)
							{
								if (num != 426765699u)
								{
									if (num != 527431413u)
									{
										continue;
									}
									if (Operators.CompareString(name, "FS_D", false) != 0)
									{
										continue;
									}
									goto IL_25C;
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
									goto IL_289;
								}
								else
								{
									if (Operators.CompareString(name, "PC", false) != 0)
									{
										continue;
									}
									goto IL_196;
								}
							}
							else
							{
								if (Operators.CompareString(name, "MPO", false) != 0)
								{
									continue;
								}
								goto IL_20D;
							}
						}
						else if (num <= 3750830438u)
						{
							if (num == 2922860948u)
							{
								goto IL_1F5;
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
									goto IL_196;
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
									goto IL_25C;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SM_NRP", false) == 0)
								{
									goto IL_289;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "FS_BT", false) == 0)
							{
								facility_Navigator.GetFormationStation().BearingType = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						facility_Navigator.GetFormationStation().Bearing = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_196:
						IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
								Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode2, ref dictionary_0);
								ScenarioArrayUtil.AddWaypoint(ref facility_Navigator.PlottedCourse, waypoint_);
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
						IL_1F5:
						if (Operators.CompareString(name, "ManualPlotOverride", false) != 0)
						{
							continue;
						}
						IL_20D:
						facility_Navigator.ManualPlotOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_25C:
						facility_Navigator.GetFormationStation().Distance = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_289:
						ActiveUnit_Navigator activeUnit_Navigator = facility_Navigator;
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
				result = facility_Navigator;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100562", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Facility_Navigator(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00269AB4 File Offset: 0x00267CB4
		public Facility_Navigator(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			try
			{
				this.int_0 = (int)Math.Round(Math.Min(Math.Sqrt(((Facility)this.ParentPlatform).Area), 10.0) * 2.0);
				this.int_1 = 2000;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100563", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00269B5C File Offset: 0x00267D5C
		public override void SetDesiredHeading()
		{
			base.SetDesiredHeading();
			try
			{
				float? desiredSpeedOverride = this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride();
				long? num = desiredSpeedOverride.HasValue ? new long?((long)Math.Round((double)desiredSpeedOverride.GetValueOrDefault())) : null;
				long? num2 = num.HasValue ? new long?(~num.GetValueOrDefault()) : num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() != 0L) : null).GetValueOrDefault())
				{
					if (!Information.IsNothing(this.ParentPlatform.GetParentGroup(false)))
					{
						if (this.ParentPlatform.GetParentGroup(false).GetThrottle() == ActiveUnit.Throttle.Flank)
						{
							this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Flank, null);
						}
						else
						{
							this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Full, null);
						}
					}
					this.ParentPlatform.SetDesiredSpeed((float)this.ParentPlatform.GetKinematics().GetSpeed(0f, this.ParentPlatform.GetThrottle()));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100564", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00269CE8 File Offset: 0x00267EE8
		protected override void vmethod_15(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight class168_1, bool bool_14, float float_3, double double_0, double double_1, bool bool_15)
		{
			try
			{
				double latitude;
				double longitude;
				float num;
				if (Information.IsNothing(waypoint_2))
				{
					latitude = activeUnit_1.GetLatitude(null);
					longitude = activeUnit_1.GetLongitude(null);
					num = activeUnit_1.GetCurrentHeading();
				}
				else
				{
					latitude = waypoint_2.GetLatitude();
					longitude = waypoint_2.GetLongitude();
					num = Math2.GetAzimuth(latitude, longitude, double_0, double_1);
				}
				byte b = 0;
				bool flag = true;
				bool flag2 = true;
				float? nullable_ = null;
				short? nullable_2 = null;
				List<ActiveUnit> list = null;
				if (activeUnit_1.vmethod_41(double_0, double_1, ref b, true, ref flag, true, ref flag2, nullable_, nullable_2, ref list, float_3, bool_15, false))
				{
					activeUnit_1.GetAI().geoPoint_1 = new GeoPoint(double_1, double_0);
					double latitude2 = latitude;
					double longitude2 = longitude;
					float float_4 = num;
					list = new List<ActiveUnit>();
					List<Waypoint> list_ = base.method_49(latitude2, longitude2, double_0, double_1, float_4, true, float_3, ref list);
					this.list_0 = list_;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100565", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}
	}
}
