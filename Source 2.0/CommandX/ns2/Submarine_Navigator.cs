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
	// Token: 0x02000B3A RID: 2874
	public sealed class Submarine_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x06005C8D RID: 23693 RVA: 0x002AABFC File Offset: 0x002A8DFC
		private Submarine GetParentPlatform()
		{
			if (Information.IsNothing(this.submarine))
			{
				this.submarine = (Submarine)this.ParentPlatform;
			}
			return this.submarine;
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x002AAC34 File Offset: 0x002A8E34
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Submarine_Navigator");
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
				ex2.Data.Add("Error at 100837", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x002AAE08 File Offset: 0x002A9008
		public static Submarine_Navigator Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Submarine_Navigator result = null;
			try
			{
				Submarine_Navigator submarine_Navigator = new Submarine_Navigator(ref activeUnit_1);
				submarine_Navigator.ParentPlatform = activeUnit_1;
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
											submarine_Navigator.GetFormationStation().SprintAndDrift = true;
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
								submarine_Navigator.GetFormationStation().BearingType = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						submarine_Navigator.GetFormationStation().Bearing = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_1CD:
						IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
								Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode2, ref dictionary_0);
								ScenarioArrayUtil.AddWaypoint(ref submarine_Navigator.PlottedCourse, waypoint_);
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
						submarine_Navigator.ManualPlotOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_293:
						submarine_Navigator.GetFormationStation().Distance = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_2C0:
						ActiveUnit_Navigator activeUnit_Navigator = submarine_Navigator;
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
				result = submarine_Navigator;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100838", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_Navigator(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x002AB1E8 File Offset: 0x002A93E8
		public Submarine_Navigator(ref ActiveUnit activeUnit_) : base(ref activeUnit_)
		{
			this.int_0 = (int)Math.Round((double)(Math.Min(((Submarine)this.ParentPlatform).Length, 100f) * 2f));
			this.int_1 = 500;
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x002AB234 File Offset: 0x002A9434
		public override bool vmethod_8(double lat_, double lon_, float float_3)
		{
			return (double)Math2.GetDistance(lat_, lon_, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null)) < 0.25;
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x002AB27C File Offset: 0x002A947C
		public override void vmethod_7(float float_3)
		{
			if (base.HasPlottedCourse())
			{
				if (this.GetParentPlatform().IsROV())
				{
					ActiveUnit assignedHostUnit = this.ParentPlatform.GetDockingOps().GetAssignedHostUnit(false);
					if (!Information.IsNothing(assignedHostUnit) && (double)assignedHostUnit.GetHorizontalRange(this.GetParentPlatform()) > (double)this.GetParentPlatform().ROVRadius / 1852.0 * 1.25)
					{
						base.RemoveWaypoint(base.GetPlottedCourse()[0], false);
						return;
					}
				}
				base.vmethod_7(float_3);
			}
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x002AB310 File Offset: 0x002A9510
		public override void SetDesiredHeading()
		{
			if (this.GetParentPlatform().Type == Submarine._SubmarineType.ROV && this.GetParentPlatform().HasAssignedMineClearingMission())
			{
				float num;
				if (this.GetParentPlatform().IsROV())
				{
					num = (float)((double)this.GetParentPlatform().ROVRadius / 1852.0);
				}
				else if (this.GetParentPlatform().GetAllNoneMCMSensors().Length > 0)
				{
					num = this.GetParentPlatform().GetAllNoneMCMSensors()[0].MaxRange;
				}
				else
				{
					num = 5f;
				}
				double latitude = this.GetParentPlatform().GetDockingOps().GetAssignedHostUnit(false).GetLatitude(null);
				double longitude = this.GetParentPlatform().GetDockingOps().GetAssignedHostUnit(false).GetLongitude(null);
				float currentHeading = this.GetParentPlatform().GetDockingOps().GetAssignedHostUnit(false).GetCurrentHeading();
				ReferencePoint referencePoint = new ReferencePoint();
				ReferencePoint referencePoint2 = new ReferencePoint();
				ReferencePoint referencePoint3 = new ReferencePoint();
				ReferencePoint referencePoint4 = new ReferencePoint();
				ReferencePoint referencePoint5 = new ReferencePoint();
				ReferencePoint referencePoint6 = new ReferencePoint();
				List<ReferencePoint> list = new List<ReferencePoint>();
				double lat = latitude;
				ReferencePoint referencePoint7;
				double num2 = (referencePoint7 = referencePoint).GetLatitude();
				ReferencePoint referencePoint8;
				double num3 = (referencePoint8 = referencePoint).GetLongitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, lat, ref num2, ref num3, (double)((float)((double)num * 0.1)), (double)Math2.Normalize(currentHeading - 45f));
				referencePoint8.SetLongitude(num3);
				referencePoint7.SetLatitude(num2);
				list.Add(referencePoint);
				double lat2 = latitude;
				num3 = (referencePoint8 = referencePoint2).GetLatitude();
				num2 = (referencePoint7 = referencePoint2).GetLongitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, lat2, ref num3, ref num2, (double)num, (double)Math2.Normalize(currentHeading - 45f));
				referencePoint7.SetLongitude(num2);
				referencePoint8.SetLatitude(num3);
				list.Add(referencePoint2);
				double lat3 = latitude;
				num2 = (referencePoint7 = referencePoint3).GetLatitude();
				num3 = (referencePoint8 = referencePoint3).GetLongitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, lat3, ref num2, ref num3, (double)num, (double)currentHeading);
				referencePoint8.SetLongitude(num3);
				referencePoint7.SetLatitude(num2);
				list.Add(referencePoint3);
				double lat4 = latitude;
				num3 = (referencePoint8 = referencePoint4).GetLatitude();
				num2 = (referencePoint7 = referencePoint4).GetLongitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, lat4, ref num3, ref num2, (double)num, (double)Math2.Normalize(currentHeading + 45f));
				referencePoint7.SetLongitude(num2);
				referencePoint8.SetLatitude(num3);
				list.Add(referencePoint4);
				double lat5 = latitude;
				num2 = (referencePoint7 = referencePoint5).GetLatitude();
				num3 = (referencePoint8 = referencePoint5).GetLongitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, lat5, ref num2, ref num3, (double)((float)((double)num * 0.1)), (double)Math2.Normalize(currentHeading + 45f));
				referencePoint8.SetLongitude(num3);
				referencePoint7.SetLatitude(num2);
				list.Add(referencePoint5);
				double lat6 = latitude;
				num3 = (referencePoint8 = referencePoint6).GetLatitude();
				num2 = (referencePoint7 = referencePoint6).GetLongitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, lat6, ref num3, ref num2, (double)((float)((double)num * 0.1)), (double)currentHeading);
				referencePoint7.SetLongitude(num2);
				referencePoint8.SetLatitude(num3);
				list.Add(referencePoint6);
				this.HeadingToTheArea(list);
			}
			else
			{
				base.SetDesiredHeading();
			}
			if (this.NextUpdateTime > 2f)
			{
				this.NextUpdateTime = 2f;
			}
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x002AB658 File Offset: 0x002A9858
		public override void FollowGroupLead(float elapsedTime_)
		{
			try
			{
				if (Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetGroupLead()))
				{
					this.ParentPlatform.GetParentGroup(false).SetGroupLead();
					if (Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetGroupLead()))
					{
						return;
					}
				}
				if (this.ParentPlatform.HasParentGroup() && !Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetGroupLead()) && (this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling) && this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetDockingOps().GetUNREPDestinationUnit() == this.ParentPlatform)
				{
					if (this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetNavigator().HasPlottedCourse())
					{
						Waypoint waypoint = this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetNavigator().GetPlottedCourse()[0];
						this.ParentPlatform.SetDesiredHeading(this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetDesiredTurnRate(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), waypoint.GetLatitude(), waypoint.GetLongitude()));
						this.vmethod_4(waypoint.GetLatitude(), waypoint.GetLongitude(), 0f, 0f);
					}
				}
				else if (!this.ParentPlatform.IsGroupLead())
				{
					if (base.HasPathfindingCourse())
					{
						this.vmethod_7(elapsedTime_);
					}
					else
					{
						ActiveUnit groupLead = this.ParentPlatform.GetParentGroup(false).GetGroupLead();
						if (!Information.IsNothing(groupLead))
						{
							double num = 0.0;
							double num2 = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(groupLead.GetLongitude(null), groupLead.GetLatitude(null), ref num, ref num2, (double)base.GetFormationStation().Distance, (double)base.GetFormationStation().GetBearing(this.ParentPlatform));
							if (base.GetFormationStation().SprintAndDrift)
							{
								ActiveUnit_Kinematics._SprintAndDriftControl sprintAndDriftControl = this.ParentPlatform.GetKinematics().SprintAndDriftControl;
								if (sprintAndDriftControl != ActiveUnit_Kinematics._SprintAndDriftControl.Sprinting)
								{
									if (sprintAndDriftControl == ActiveUnit_Kinematics._SprintAndDriftControl.Drifting)
									{
										this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), groupLead.GetCurrentHeading());
										this.ParentPlatform.SetDesiredSpeed(Math.Min(5f, groupLead.GetCurrentSpeed() - 1f));
										this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
										if (this.ParentPlatform.HorizontalRangeTo(num2, num) > 5f)
										{
											this.ParentPlatform.GetKinematics().SprintAndDriftControl = ActiveUnit_Kinematics._SprintAndDriftControl.Sprinting;
										}
									}
								}
								else
								{
									double num3 = 0.0;
									double num4 = 0.0;
									GeoPointGenerator.GetOtherGeoPoint(num, num2, ref num3, ref num4, 5.0, (double)groupLead.GetCurrentHeading());
									this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num4, num3));
									this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Flank, null);
									if (this.vmethod_8(num4, num3, elapsedTime_))
									{
										this.ParentPlatform.GetKinematics().SprintAndDriftControl = ActiveUnit_Kinematics._SprintAndDriftControl.Drifting;
									}
								}
							}
							else
							{
								if (this.vmethod_8(num2, num, elapsedTime_))
								{
									float angleBetween = Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num));
									if (angleBetween > 90f && angleBetween < 270f)
									{
										this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), this.ParentPlatform.GetParentGroup(false).GetDesiredHeading(ActiveUnit._TurnRate.const_0));
										this.ParentPlatform.SetDesiredSpeed(this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetCurrentSpeed() - 1f);
									}
									else
									{
										this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num));
										this.ParentPlatform.SetDesiredSpeed(this.ParentPlatform.GetParentGroup(false).GetDesiredSpeed());
									}
									this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
									return;
								}
								this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num));
								if (this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									this.ParentPlatform.SetDesiredSpeed(this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().Value);
									ActiveUnit parentPlatform = this.ParentPlatform;
									ActiveUnit.Throttle newThrottleSetting = this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().Value)));
									float? desiredSpeedOverride = this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride();
									int? num5 = desiredSpeedOverride.HasValue ? new int?((int)Math.Round((double)desiredSpeedOverride.GetValueOrDefault())) : null;
									parentPlatform.SetThrottle(newThrottleSetting, num5.HasValue ? new float?((float)num5.GetValueOrDefault()) : null);
								}
								else if (this.ParentPlatform.HasParentGroup())
								{
									if (this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetThrottle() > ActiveUnit.Throttle.Full)
									{
										this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Flank, null);
									}
									else
									{
										this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Full, null);
									}
								}
								else
								{
									this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Full, null);
								}
							}
							if (groupLead.GetCurrentSpeed() > 0f)
							{
								double num6 = 0.0;
								double num7 = 0.0;
								GeoPointGenerator.GetOtherGeoPoint(num, num2, ref num6, ref num7, (double)base.GetFormationStation().Distance, (double)groupLead.GetCurrentHeading());
								Unit parentPlatform2 = this.ParentPlatform;
								double lat_ = num7;
								double lon_ = num6;
								byte b = 0;
								bool flag = true;
								bool flag2 = true;
								float? nullable_ = null;
								short? nullable_2 = null;
								List<ActiveUnit> list = null;
								if (!parentPlatform2.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, nullable_, nullable_2, ref list, 0f, false, false))
								{
									num2 = groupLead.GetLatitude(null);
									num = groupLead.GetLongitude(null);
								}
							}
							this.ParentPlatform.GetAI().geoPoint_1 = new GeoPoint(num, num2);
							if (!base.HasPathfindingCourse() && !this.bool_2)
							{
								if (this.ParentPlatform.GetNavigator().bUpdated && this.vmethod_16(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num, true, 0f, true, null))
								{
									base.method_12(null, this.ParentPlatform, null, false, 0.15f, num2, num, this.ParentPlatform.m_Scenario, false);
								}
								else if (!base.GetFormationStation().SprintAndDrift)
								{
									float angleBetween2 = Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num));
									if (angleBetween2 > 90f && angleBetween2 < 270f && Math.Abs(Class263.RelativeBearingTo(this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetParentGroup(false).GetCurrentHeading())) <= 30f)
									{
										this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), this.ParentPlatform.GetParentGroup(false).GetCurrentHeading());
										this.ParentPlatform.SetDesiredSpeed((float)((double)this.ParentPlatform.GetParentGroup(false).GetCurrentSpeed() * 0.2));
										this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
									}
									else
									{
										this.ParentPlatform.SetDesiredHeading(groupLead.GetDesiredTurnRate(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num));
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100217", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x040030C2 RID: 12482
		private Submarine submarine;
	}
}
