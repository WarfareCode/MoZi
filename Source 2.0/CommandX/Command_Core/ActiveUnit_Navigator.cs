using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using DotSpatial.Topology;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns18;
using ns19;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 导航
	public class ActiveUnit_Navigator
	{
		// Token: 0x0600324A RID: 12874 RVA: 0x0010DBD8 File Offset: 0x0010BDD8
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_Navigator");
				if (!this.ParentPlatform.IsGroupLead() && this.GetPlottedCourse().Count<Waypoint>() > 0)
				{
					xmlWriter_0.WriteStartElement("PC");
					List<Waypoint> list = new List<Waypoint>();
					list.AddRange(this.GetPlottedCourse());
					foreach (Waypoint current in list)
					{
						if (!Information.IsNothing(current))
						{
							current.Save(ref xmlWriter_0, ref hashSet_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.GetPlottedCourse_PrePlanned().Count<Waypoint>() > 0)
				{
					xmlWriter_0.WriteStartElement("PC_PP");
					List<Waypoint> list2 = new List<Waypoint>();
					list2.AddRange(this.GetPlottedCourse_PrePlanned());
					foreach (Waypoint current2 in list2)
					{
						if (!Information.IsNothing(current2))
						{
							current2.Save(ref xmlWriter_0, ref hashSet_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.m_Flight))
				{
					xmlWriter_0.WriteElementString("Flight", this.m_Flight.GetGuid());
				}
				xmlWriter_0.WriteElementString("MPO", this.ManualPlotOverride.ToString());
				if (!Information.IsNothing(this.GetFormationStation()))
				{
					if (this.GetFormationStation().Bearing != 0f)
					{
						xmlWriter_0.WriteElementString("FS_B", XmlConvert.ToString(this.GetFormationStation().Bearing));
					}
					if (this.GetFormationStation().Distance != 0f)
					{
						xmlWriter_0.WriteElementString("FS_D", XmlConvert.ToString(this.GetFormationStation().Distance));
					}
					xmlWriter_0.WriteElementString("FS_BT", XmlConvert.ToString((byte)this.GetFormationStation().BearingType));
					if (this.GetFormationStation().SprintAndDrift)
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
				xmlWriter_0.WriteElementString("TTNPC", this.ManualPlotOverride.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100199", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x0010DEB4 File Offset: 0x0010C0B4
		public virtual void SetMyFlight(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0, bool bool_14)
		{
			if (this.ParentPlatform.IsAircraft)
			{
				bool flag = false;
				foreach (Mission current in this.ParentPlatform.GetSide(false).GetMissionCollection())
				{
					if (this.ParentPlatform.GetAssignedMission(false) == current && current.HasFlights())
					{
						foreach (Mission.Flight current2 in current.FlightList)
						{
							if (!Information.IsNothing(current2.GetGuid()) && Operators.CompareString(current2.GetGuid(), this.FlightName, false) == 0)
							{
								this.SetFlight(current2);
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x0010DFBC File Offset: 0x0010C1BC
		public ActiveUnit_Navigator.FormationStation GetFormationStation()
		{
			if (Information.IsNothing(this.m_FormationStation))
			{
				this.m_FormationStation = new ActiveUnit_Navigator.FormationStation();
				if (!Information.IsNothing(this.ParentPlatform.GetParentGroup(false)) && !Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetGroupLead()))
				{
					this.FollowGroupLead();
				}
			}
			return this.m_FormationStation;
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0010E020 File Offset: 0x0010C220
		public Waypoint[] GetPlottedCourse()
		{
			Waypoint[] plottedCourse;
			if (this.ParentPlatform.IsGroupLead())
			{
				plottedCourse = this.ParentPlatform.GetParentGroup(false).GetNavigator().GetPlottedCourse();
			}
			else
			{
				plottedCourse = this.PlottedCourse;
			}
			return plottedCourse;
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x0001B11D File Offset: 0x0001931D
		public void SetPlottedCourse(Waypoint[] waypoints)
		{
			this.PlottedCourse = waypoints;
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().SetPlottedCourse(waypoints);
			}
			this.short_8 = 0;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x0010E060 File Offset: 0x0010C260
		public Waypoint[] GetPlottedCourse_PrePlanned()
		{
			Waypoint[] plottedCourse_PrePlanned;
			if (this.ParentPlatform.IsGroupLead())
			{
				plottedCourse_PrePlanned = this.ParentPlatform.GetParentGroup(false).GetNavigator().GetPlottedCourse_PrePlanned();
			}
			else
			{
				plottedCourse_PrePlanned = this.PlottedCourse_PrePlanned;
			}
			return plottedCourse_PrePlanned;
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x0010E0A0 File Offset: 0x0010C2A0
		public Mission.Flight GetFlight()
		{
			Mission.Flight flight;
			if (this.ParentPlatform.IsGroupLead())
			{
				flight = this.ParentPlatform.GetParentGroup(false).GetNavigator().GetFlight();
			}
			else
			{
				flight = this.m_Flight;
			}
			return flight;
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x0001B154 File Offset: 0x00019354
		public void SetFlight(Mission.Flight Flight_)
		{
			this.m_Flight = Flight_;
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().SetFlight(Flight_);
			}
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x0010E0E0 File Offset: 0x0010C2E0
		public ActiveUnit_Navigator(ref ActiveUnit ParentPlatform_)
		{
			this.PlottedCourse = new Waypoint[0];
			this.PlottedCourse_PrePlanned = new Waypoint[0];
			this.TimeToCheckNoNavZoneViolation = 0;
			this.bool_12 = true;
			this.bool_13 = false;
			this.ParentPlatform = ParentPlatform_;
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x0010E13C File Offset: 0x0010C33C
		public virtual void ClearPlottedCourse()
		{
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().ClearPlottedCourse();
			}
			else
			{
				ScenarioArrayUtil.ClearWaypoints(ref this.PlottedCourse);
				ScenarioArrayUtil.ClearWaypoints(ref this.PlottedCourse_PrePlanned);
				if (!this.ParentPlatform.IsGroup)
				{
					Class324.smethod_7(this.ParentPlatform, null);
				}
			}
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x0001B184 File Offset: 0x00019384
		public virtual void vmethod_3()
		{
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().vmethod_3();
			}
			else
			{
				this.SetFlight(null);
			}
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x0010E1A0 File Offset: 0x0010C3A0
		public Waypoint method_6(double lat1, double lon1, ref List<ActiveUnit> list_1)
		{
			Waypoint waypoint = null;
			int num = 1;
			while (true)
			{
				int num2 = 0;
				double num3 = 0.0;
				double num4 = 0.0;
				do
				{
					GeoPointGenerator.GetOtherGeoPoint(lon1, lat1, ref num3, ref num4, (double)num, (double)num2);
					Unit parentPlatform = this.ParentPlatform;
					double lat_ = num4;
					double lon_ = num3;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					if (parentPlatform.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, null, null, ref list_1, 0f, false, false))
					{
						waypoint = new Waypoint(num3, num4, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint._Creator.const_1, Waypoint._Category.const_0);
						if (!Information.IsNothing(waypoint))
						{
							break;
						}
						num++;
						if (num > 10000)
						{
							break;
						}
					}
					else
					{
						num2++;
					}
				}
				while (num2 <= 359);
				IL_A8:
				if (!Information.IsNothing(waypoint))
				{
					break;
				}
				num++;
				if (num <= 10000)
				{
					continue;
				}
				break;
				goto IL_A8;
			}
			return waypoint;
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x0010E28C File Offset: 0x0010C48C
		public bool method_7(double lat1, double lon1, ref double lat2, ref double lon2, float float_3, ref List<ActiveUnit> list_1, bool bool_14)
		{
			int num = 1;
			while (true)
			{
				int num2 = 0;
				do
				{
					GeoPointGenerator.GetOtherGeoPoint(lon1, lat1, ref lon2, ref lat2, (double)num, (double)num2);
					Unit parentPlatform = this.ParentPlatform;
					double lat_ = lat2;
					double lon_ = lon2;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					if (parentPlatform.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, null, null, ref list_1, float_3, bool_14, false))
					{
						goto Block_1;
					}
					num2++;
				}
				while (num2 <= 359);
				num++;
				if (num > 10000)
				{
					goto IL_88;
				}
			}
			Block_1:
			bool result = true;
			return result;
			IL_88:
			result = false;
			return result;
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x0010E328 File Offset: 0x0010C528
		public void ScheduleNextUpdate(float elapsedTime)
		{
			try
			{
				this.NextUpdateTime -= elapsedTime;
				if (this.NextUpdateTime <= 0f && this.ParentPlatform.m_Scenario.SecondIsChangingOnThisPulse)
				{
					this.bUpdated = true;
					if (this.ParentPlatform.IsAircraft)
					{
						this.NextUpdateTime = (float)GameGeneral.GetRandom().Next(30, 61);
					}
					else if (this.ParentPlatform.IsFixedFacility())
					{
						this.NextUpdateTime = 3.40282347E+38f;
					}
					else
					{
						this.NextUpdateTime = (float)GameGeneral.GetRandom().Next(360, 721);
					}
					if (this.ParentPlatform.IsMineSweeper() && (this.ParentPlatform.IsShip || this.ParentPlatform.IsSubmarine) && !Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)) && this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
					{
						MineClearingMission mineClearingMission = (MineClearingMission)this.ParentPlatform.GetAssignedMission(false);
						if (this.ParentPlatform.GetNavigator().IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_12, ref mineClearingMission.list_8, 5, false, false))
						{
							this.NextUpdateTime = (float)GameGeneral.GetRandom().Next(10, 16);
						}
					}
				}
				else
				{
					this.bUpdated = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100201", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x0010E4DC File Offset: 0x0010C6DC
		public bool method_9(double lat_, double lon_, float float_3, float float_4)
		{
			bool result = false;
			try
			{
				if (this.ParentPlatform.GetCurrentSpeed() == 0f)
				{
					result = false;
				}
				else
				{
					float azimuth = Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), lat_, lon_);
					if (Math.Abs(Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), azimuth)) < 1f)
					{
						result = false;
					}
					else
					{
						float num = this.ParentPlatform.HorizontalRangeTo(lat_, lon_);
						float num2;
						if (this.ParentPlatform.IsWeapon)
						{
							float_3 = 0f;
							num2 = 0f;
						}
						else
						{
							num2 = Math.Min(this.ParentPlatform.GetCurrentSpeed() / (3600f / float_3), float_4 * 2f);
						}
						if (float_4 > 0f && num < float_4 + num2)
						{
							result = true;
						}
						else
						{
							float num3 = Misc.smethod_61(this.ParentPlatform.GetCurrentSpeed(), this.ParentPlatform.GetKinematics().GetTurnRate());
							if (num > num3 * 2f)
							{
								result = false;
							}
							else
							{
								float num4;
								float num5;
								if (this.ParentPlatform.IsWeapon)
								{
									num4 = Math2.Normalize(this.ParentPlatform.GetCurrentHeading() - 135f);
									num5 = Math2.Normalize(this.ParentPlatform.GetCurrentHeading() + 135f);
								}
								else
								{
									num4 = Math2.Normalize(this.ParentPlatform.GetCurrentHeading() - 90f);
									num5 = Math2.Normalize(this.ParentPlatform.GetCurrentHeading() + 90f);
								}
								double lon = 0.0;
								double lat = 0.0;
								GeoPointGenerator.GetOtherGeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null), ref lon, ref lat, (double)(num3 + num2 + float_4), (double)num4);
								if (Math2.GetDistance(lat, lon, lat_, lon_) < num3 + num2 + float_4)
								{
									result = true;
								}
								else
								{
									double lon2 = 0.0;
									double lat2 = 0.0;
									GeoPointGenerator.GetOtherGeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null), ref lon2, ref lat2, (double)(num3 + float_4 + float_4), (double)num5);
									result = (Math2.GetDistance(lat2, lon2, lat_, lon_) < num3 + float_4 + float_4);
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
				ex2.Data.Add("Error at 101258", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x0010E7D0 File Offset: 0x0010C9D0
		public virtual void vmethod_4(double lat_, double lon_, float float_3, float float_4)
		{
			try
			{
				if (this.method_9(lat_, lon_, float_3, float_4))
				{
					bool arg_6F_0;
					if (this.ParentPlatform.IsAircraft && this.method_25() && this.GetPlottedCourse().Count<Waypoint>() > 0)
					{
						if (this.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.Target)
						{
							if (this.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.WeaponTarget)
							{
								arg_6F_0 = false;
								goto IL_6F;
							}
						}
						arg_6F_0 = (this.ParentPlatform.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.None);
					}
					else
					{
						arg_6F_0 = true;
					}
					IL_6F:
					if (!arg_6F_0)
					{
						float float_5 = 1f;
						bool flag = true;
						this.vmethod_9(float_5, ref flag);
					}
					else if (this.GetPlottedCourse().Count<Waypoint>() > 0 && this.GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.PathfindingPoint)
					{
						float float_6 = 1f;
						bool flag = true;
						this.vmethod_9(float_6, ref flag);
					}
					else
					{
						float azimuth = Math2.GetAzimuth(lat_, lon_, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
						this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_0, azimuth);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100202", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x0010E92C File Offset: 0x0010CB2C
		public bool method_10(float float_3)
		{
			bool result = false;
			try
			{
				SupportMission supportMission = (SupportMission)this.ParentPlatform.GetAssignedMission(false);
				if (supportMission.NLT == SupportMission._NLT.const_0)
				{
					result = false;
				}
				else if (Information.IsNothing(this.SupportMission_NextRefPoint))
				{
					result = false;
				}
				else if (!this.vmethod_8(this.SupportMission_NextRefPoint.GetLatitude(), this.SupportMission_NextRefPoint.GetLongitude(), float_3))
				{
					result = false;
				}
				else if (supportMission.NavigationCourseReferencePoints.IndexOf(this.SupportMission_NextRefPoint) == supportMission.NavigationCourseReferencePoints.Count - 1)
				{
					this.SupportMission_NextRefPoint = null;
					result = true;
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
				ex2.Data.Add("Error at 100203", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x0010EA18 File Offset: 0x0010CC18
		public virtual  void vmethod_5()
		{
			Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.ParentPlatform.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false);
			byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
			bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
			if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
			{
				this.ParentPlatform.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
			}
			List<Waypoint> list = this.GetPlottedCourse().ToList<Waypoint>();
			List<Waypoint> list2 = new List<Waypoint>();
			foreach (Waypoint current in list)
			{
				if (current.waypointType == Waypoint.WaypointType.PathfindingPoint)
				{
					list2.Add(current);
				}
				else if (current.waypointType == Waypoint.WaypointType.InitialPoint || current.waypointType == Waypoint.WaypointType.WeaponLaunch || current.waypointType == Waypoint.WaypointType.Target || current.waypointType == Waypoint.WaypointType.WeaponTarget || current.waypointType == Waypoint.WaypointType.StrikeIngress)
				{
					this.method_27(current);
					this.method_28(current);
					list2.Add(current);
				}
			}
			foreach (Waypoint current2 in list2)
			{
				this.RemoveWaypoint(current2, false);
			}
			this.method_16();
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x0010EBF8 File Offset: 0x0010CDF8
		public bool method_11()
		{
			bool result;
			if (Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
			{
				result = false;
			}
			else if (this.ParentPlatform.GetAssignedMission(false).MissionClass != Mission._MissionClass.Support)
			{
				result = false;
			}
			else
			{
				SupportMission supportMission = (SupportMission)this.ParentPlatform.GetAssignedMission(false);
				if (Information.IsNothing(supportMission.NavigationCourseReferencePoints))
				{
					result = false;
				}
				else if (supportMission.NavigationCourseReferencePoints.Count == 0)
				{
					result = false;
				}
				else
				{
					bool flag;
					if (this.ParentPlatform.IsAircraft)
					{
						flag = !this.IsOnStation(ref supportMission.NavigationCourseReferencePoints, ref supportMission.list_10, ref supportMission.list_9, 10, false, false);
					}
					else
					{
						flag = !this.IsOnStation(ref supportMission.NavigationCourseReferencePoints, ref supportMission.list_8, ref supportMission.list_7, 2, false, false);
					}
					if (this.ParentPlatform.IsRTB())
					{
						flag = true;
					}
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x0010ECE8 File Offset: 0x0010CEE8
		public virtual void vmethod_6(float elapsedTime_, bool bool_14)
		{
			try
			{
				if (!Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)) && this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
				{
					SupportMission supportMission = (SupportMission)this.ParentPlatform.GetAssignedMission(false);
					if (!Information.IsNothing(supportMission) && !Information.IsNothing(supportMission.NavigationCourseReferencePoints) && supportMission.NavigationCourseReferencePoints.Count != 0)
					{
						if (Information.IsNothing(this.SupportMission_NextRefPoint))
						{
							this.SupportMission_NextRefPoint = supportMission.NavigationCourseReferencePoints[0];
						}
						else if (!supportMission.NavigationCourseReferencePoints.Contains(this.SupportMission_NextRefPoint))
						{
							this.SupportMission_NextRefPoint = supportMission.NavigationCourseReferencePoints[0];
						}
						if (this.vmethod_8(this.SupportMission_NextRefPoint.GetLatitude(), this.SupportMission_NextRefPoint.GetLongitude(), elapsedTime_))
						{
							if (supportMission.NavigationCourseReferencePoints.IndexOf(this.SupportMission_NextRefPoint) == supportMission.NavigationCourseReferencePoints.Count - 1)
							{
								if (supportMission.NLT == SupportMission._NLT.const_0)
								{
									this.SupportMission_NextRefPoint = supportMission.NavigationCourseReferencePoints[0];
								}
								else if (supportMission.NLT == SupportMission._NLT.const_1)
								{
									this.SupportMission_NextRefPoint = null;
									if (this.ParentPlatform.IsAircraft)
									{
										this.ParentPlatform.GetAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
									}
									else
									{
										this.ParentPlatform.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
									}
								}
							}
							else
							{
								this.SupportMission_NextRefPoint = supportMission.NavigationCourseReferencePoints[supportMission.NavigationCourseReferencePoints.IndexOf(this.SupportMission_NextRefPoint) + 1];
							}
						}
						if (this.HasPlottedCourse())
						{
							this.vmethod_7(elapsedTime_);
						}
						else if (!Information.IsNothing(this.SupportMission_NextRefPoint))
						{
							this.method_15(this.SupportMission_NextRefPoint);
							this.vmethod_4(this.SupportMission_NextRefPoint.GetLatitude(), this.SupportMission_NextRefPoint.GetLongitude(), 0f, 0f);
						}
						if (!this.ParentPlatform.IsAircraft && !this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
						{
							if (bool_14)
							{
								if (this.ParentPlatform.IsSubmarine)
								{
									if (!Information.IsNothing(supportMission.TransitThrottle_Submarine))
									{
										this.ParentPlatform.SetThrottle(supportMission.TransitThrottle_Submarine, null);
									}
									else
									{
										this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
									}
								}
								else if (this.ParentPlatform.IsShip)
								{
									if (!Information.IsNothing(supportMission.TransitThrottle_Ship))
									{
										this.ParentPlatform.SetThrottle(supportMission.TransitThrottle_Ship, null);
									}
									else
									{
										this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
									}
								}
								else
								{
									this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
								}
							}
							else if (this.ParentPlatform.IsSubmarine)
							{
								if (!Information.IsNothing(supportMission.StationThrottle_Submarine))
								{
									this.ParentPlatform.SetThrottle(supportMission.StationThrottle_Submarine, null);
								}
								else
								{
									this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Loiter, null);
								}
							}
							else if (this.ParentPlatform.IsShip)
							{
								if (!Information.IsNothing(supportMission.StationThrottle_Ship))
								{
									this.ParentPlatform.SetThrottle(supportMission.StationThrottle_Ship, null);
								}
								else
								{
									this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Loiter, null);
								}
							}
							else
							{
								this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Loiter, null);
							}
						}
						if (this.ParentPlatform.IsSubmarine)
						{
							int value = (int)this.ParentPlatform.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.ParentPlatform.m_Scenario, false, false, false).Value;
							Submarine_AI submarineAI = ((Submarine)this.ParentPlatform).GetSubmarineAI();
							if (!submarineAI.IsRechargingBatteries((float)value, false, false) && !this.ParentPlatform.GetKinematics().GetDesiredAltitudeOverride())
							{
								if (bool_14)
								{
									if (supportMission.TransitDepth_Submarine.HasValue)
									{
										float value2 = supportMission.TransitDepth_Submarine.Value;
										if (value2 >= -20f && !submarineAI.NeedRecharge(false, null))
										{
											this.ParentPlatform.SetDesiredAltitude(-40f);
										}
										else
										{
											this.ParentPlatform.SetDesiredAltitude(value2);
										}
									}
								}
								else if (supportMission.StationDepth_Submarine.HasValue)
								{
									float value3 = supportMission.StationDepth_Submarine.Value;
									if (value3 >= -20f && !submarineAI.NeedRecharge(false, null))
									{
										this.ParentPlatform.SetDesiredAltitude(-40f);
									}
									else
									{
										this.ParentPlatform.SetDesiredAltitude(value3);
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
				ex2.Data.Add("Error at 100204", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0010F24C File Offset: 0x0010D44C
		public void method_12(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight Flight_, bool bool_14, float float_3, double double_0, double double_1, Scenario scenario_0, bool bool_15)
		{
			ActiveUnit_Navigator.Class66 @class = new ActiveUnit_Navigator.Class66();
			@class.waypoint_0 = waypoint_2;
			@class.activeUnit_0 = activeUnit_1;
			@class.m_Flight = Flight_;
			@class.bool_0 = bool_14;
			@class.float_0 = float_3;
			@class.double_0 = double_0;
			@class.double_1 = double_1;
			@class.scenario = scenario_0;
			@class.bool_1 = bool_15;
			bool arg_50_0 = Debugger.IsAttached;
			try
			{
				if (Class324.smethod_9() && !Class324.bool_0)
				{
					Task.Factory.StartNew(new Action(@class.method_0));
				}
				if ((Information.IsNothing(@class.activeUnit_0) || @class.activeUnit_0.GetThrottle() != ActiveUnit.Throttle.FullStop || @class.activeUnit_0.GetCurrentSpeed() != 0f) && (this.bUpdated || !Information.IsNothing(@class.m_Flight)))
				{
					Exception expression = null;
					if (!Class324.smethod_8(@class.activeUnit_0, @class.m_Flight, ref expression) && Information.IsNothing(expression))
					{
						Task.Factory.StartNew(new Action(@class.method_1));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100205", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x0010F3A4 File Offset: 0x0010D5A4
		public void method_13(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight flight, bool bool_14, float float_3, double double_0, double double_1, Scenario scenario_0, bool bool_15)
		{
			this.bool_2 = true;
			try
			{
				this.vmethod_15(waypoint_2, activeUnit_1, flight, bool_14, float_3, double_0, double_1, bool_15);
				if (!Information.IsNothing(this.list_0))
				{
					bool flag = false;
					bool bool_16 = !Information.IsNothing(flight);
					while (!flag)
					{
						if (scenario_0.ThreadedOpsMustStop)
						{
							this.bool_2 = false;
							return;
						}
						this.method_48(this.list_0, bool_16, float_3, ref flag, ref flight, ref bool_14);
					}
				}
				if (!Information.IsNothing(this.list_0))
				{
					int count = this.list_0.Count;
					if (Information.IsNothing(waypoint_2))
					{
						if (Information.IsNothing(flight))
						{
							int num = count - 1;
							for (int i = 0; i <= num; i++)
							{
								this.method_43(i, this.list_0[i]);
							}
						}
						else if (bool_14)
						{
							int num2 = count - 1;
							for (int j = 0; j <= num2; j++)
							{
								Mission.Flight flight2 = flight;
								Waypoint[] waypoint_3 = flight2.GetWaypoint1();
								ActiveUnit_Navigator.InsertWayPoint(ref waypoint_3, j, this.list_0[j]);
								flight2.SetWaypoint1(waypoint_3);
							}
							flight.bool_11 = false;
						}
						else
						{
							int num3 = count - 1;
							for (int k = 0; k <= num3; k++)
							{
								Mission.Flight flight2 = flight;
								Waypoint[] waypoint_3 = flight2.GetWaypoint2();
								ActiveUnit_Navigator.InsertWayPoint(ref waypoint_3, k, this.list_0[k]);
								flight2.SetWaypoint2(waypoint_3);
							}
							flight.bool_12 = false;
						}
					}
					else if (Information.IsNothing(flight))
					{
						int num4 = Array.IndexOf<Waypoint>(this.GetPlottedCourse(), waypoint_2);
						int num5 = count - 1;
						for (int l = 0; l <= num5; l++)
						{
							this.method_43(num4 + 1 + l, this.list_0[l]);
						}
					}
				}
				if (Information.IsNothing(this.list_0) && Information.IsNothing(flight) && bool_15)
				{
					string text = "";
					if (this.ParentPlatform.IsAircraft && Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
					{
						text = " (" + this.ParentPlatform.UnitClass + ")";
					}
					string text2 = "";
					if (!Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()))
					{
						text2 = " (" + this.ParentPlatform.GetAI().GetPrimaryTarget().Name + ")";
					}
					this.ParentPlatform.LogMessage(string.Concat(new string[]
					{
						this.ParentPlatform.Name,
						text,
						" is dropping all targets from its target list (Reason: The navigator failed to plot a course to the primary target",
						text2,
						" , which means it is inaccessible. The unit will now re-build its target list based on current target availability and accessability)."
					}), LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					this.ParentPlatform.GetAI().ClearPrimaryTarget(ref this.ParentPlatform);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200330", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			this.bool_2 = false;
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x0010F72C File Offset: 0x0010D92C
		public virtual  void vmethod_7(float elapsedTime_)
		{
			if (!this.ParentPlatform.GetAI().HoldPosition)
			{
				try
				{
					if (this.GetPlottedCourse().Count<Waypoint>() != 0)
					{
						if (this.bUpdated && !this.bool_2)
						{
							if (!this.HasPathfindingCourse())
							{
								this.ParentPlatform.GetLatitude(null);
								this.ParentPlatform.GetLongitude(null);
								this.GetPlottedCourse()[0].GetLatitude();
								this.GetPlottedCourse()[0].GetLongitude();
								if (this.vmethod_16(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), this.GetPlottedCourse()[0].GetLatitude(), this.GetPlottedCourse()[0].GetLongitude(), true, 0f, true, null))
								{
									this.method_12(null, this.ParentPlatform, null, false, 0.15f, this.GetPlottedCourse()[0].GetLatitude(), this.GetPlottedCourse()[0].GetLongitude(), this.ParentPlatform.m_Scenario, false);
								}
							}
							else if (this.GetPlottedCourse().Count<Waypoint>() > 1 && this.GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.PathfindingPoint)
							{
								double approxAngularDistanceInDegrees = this.ParentPlatform.GetApproxAngularDistanceInDegrees(this.GetPlottedCourse()[1]);
								if (approxAngularDistanceInDegrees < 0.2)
								{
									if (!this.vmethod_16(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), this.GetPlottedCourse()[1].GetLatitude(), this.GetPlottedCourse()[1].GetLongitude(), true, 0f, false, null))
									{
										this.RemoveWaypoint(this.GetPlottedCourse()[0], false);
									}
								}
								else if (approxAngularDistanceInDegrees < Math2.ApproxAngularDistance(this.GetPlottedCourse()[0].GetLatitude(), this.GetPlottedCourse()[0].GetLongitude(), this.GetPlottedCourse()[1].GetLatitude(), this.GetPlottedCourse()[1].GetLongitude()) && !this.vmethod_16(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), this.GetPlottedCourse()[1].GetLatitude(), this.GetPlottedCourse()[1].GetLongitude(), true, 0f, false, null))
								{
									this.RemoveWaypoint(this.GetPlottedCourse()[0], false);
								}
							}
						}
						this.method_16();
						bool flag = false;
						this.vmethod_9(elapsedTime_, ref flag);
						if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
						{
							if (this.ParentPlatform.IsAircraft && this.ParentPlatform.GetThrottle() <= ActiveUnit.Throttle.Cruise)
							{
								this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
							}
							else if (this.ParentPlatform.IsSubmarine && this.ParentPlatform.GetThrottle() <= ActiveUnit.Throttle.Cruise)
							{
								this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
							}
							else if (this.ParentPlatform.IsNotGroupLead() && !Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetGroupLead()))
							{
								this.ParentPlatform.SetThrottle(this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetThrottle(), null);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200321", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x0010FB24 File Offset: 0x0010DD24
		public void method_14()
		{
			checked
			{
				try
				{
					List<Waypoint> list = new List<Waypoint>();
					Waypoint[] plottedCourse = this.GetPlottedCourse();
					for (int i = 0; i < plottedCourse.Length; i++)
					{
						Waypoint waypoint = plottedCourse[i];
						if (waypoint.waypointType == Waypoint.WaypointType.PathfindingPoint)
						{
							list.Add(waypoint);
						}
					}
					foreach (Waypoint current in list)
					{
						this.RemoveWaypoint(current, false);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100208", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x0010FBFC File Offset: 0x0010DDFC
		public void method_15(GeoPoint geoPoint_0)
		{
			try
			{
				if (!this.HasPathfindingCourse() && !this.bool_2 && !this.bool_2)
				{
					if (this.ParentPlatform.GetNavigator().bUpdated && this.vmethod_16(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), true, 0f, true, null))
					{
						this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude()));
						this.method_12(null, this.ParentPlatform, null, false, 0.15f, geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), this.ParentPlatform.m_Scenario, false);
					}
					else if (this.HasPathfindingCourse())
					{
						this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), this.GetPlottedCourse()[0].GetLatitude(), this.GetPlottedCourse()[0].GetLongitude()));
					}
					else
					{
						this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude()));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100209", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0010FE00 File Offset: 0x0010E000
		protected void method_16()
		{
			try
			{
				Waypoint[] plottedCourse = this.GetPlottedCourse();
				if (plottedCourse.Length > 0)
				{
					GeoPoint geoPoint = plottedCourse[0];
					ActiveUnit._TurnRate enum0_;
					if (plottedCourse[0].waypointType == Waypoint.WaypointType.TakeOff)
					{
						enum0_ = ActiveUnit._TurnRate.const_0;
					}
					else
					{
						enum0_ = ActiveUnit._TurnRate.const_1;
					}
					this.ParentPlatform.SetDesiredHeading(enum0_, this.ParentPlatform.AzimuthTo(geoPoint.GetLatitude(), geoPoint.GetLongitude()));
					this.vmethod_4(geoPoint.GetLatitude(), geoPoint.GetLongitude(), 0f, 0f);
				}
				else
				{
					this.ManualPlotOverride = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100210", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x0010FED4 File Offset: 0x0010E0D4
		public bool method_17()
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
				{
					result = false;
				}
				else if (this.ParentPlatform.GetAssignedMission(false).MissionClass != Mission._MissionClass.Patrol)
				{
					result = false;
				}
				else
				{
					Patrol patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
					if (this.ParentPlatform.IsAircraft)
					{
						result = this.IsOnStation(ref patrol.PatrolAreaVertices, ref patrol.list_13, ref patrol.list_9, 10, false, false);
					}
					else
					{
						result = this.IsOnStation(ref patrol.PatrolAreaVertices, ref patrol.list_11, ref patrol.list_7, 2, false, false);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100211", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x0010FFC4 File Offset: 0x0010E1C4
		public bool method_18()
		{
            bool flag = false;
            if (this.HasPlottedCourse())
            {
                Waypoint.WaypointType waypointType = this.GetPlottedCourse()[0].waypointType;
                switch (waypointType)
                {
                    case Waypoint.WaypointType.PathfindingPoint:
                    case Waypoint.WaypointType.TurningPoint:
                        foreach (Waypoint waypoint in this.GetPlottedCourse())
                        {
                            if ((waypoint.waypointType != Waypoint.WaypointType.TurningPoint) && (waypoint.waypointType != Waypoint.WaypointType.PathfindingPoint))
                            {
                                Waypoint.WaypointType type3 = waypoint.waypointType;
                                if (type3 <= Waypoint.WaypointType.Target)
                                {
                                    if ((type3 != Waypoint.WaypointType.InitialPoint) && (type3 != Waypoint.WaypointType.Target))
                                    {
                                        break;
                                    }
                                }
                                else if ((type3 != Waypoint.WaypointType.WeaponLaunch) && (type3 != Waypoint.WaypointType.WeaponTarget))
                                {
                                    break;
                                }
                                return true;
                            }
                        }
                        return flag;

                    case Waypoint.WaypointType.Assemble:
                    case Waypoint.WaypointType.Split:
                    case Waypoint.WaypointType.Formate:
                        goto Label_00E7;

                    case Waypoint.WaypointType.InitialPoint:
                    case Waypoint.WaypointType.Target:
                        goto Label_00EE;

                    default:
                        if ((waypointType != Waypoint.WaypointType.WeaponLaunch) && (waypointType != Waypoint.WaypointType.WeaponTarget))
                        {
                            goto Label_00E7;
                        }
                        goto Label_00EE;
                }
            }
            return false;
        Label_00E7:
            flag = false;
            return false;
        Label_00EE:
            return true;

        }

        // Token: 0x06003266 RID: 12902 RVA: 0x001100C8 File Offset: 0x0010E2C8
        public bool method_19()
		{
            bool flag = false;
            if (this.HasPlottedCourse())
            {
                switch (this.GetPlottedCourse()[0].waypointType)
                {
                    case Waypoint.WaypointType.PathfindingPoint:
                    case Waypoint.WaypointType.TurningPoint:
                        foreach (Waypoint waypoint in this.GetPlottedCourse())
                        {
                            if ((waypoint.waypointType != Waypoint.WaypointType.TurningPoint) && (waypoint.waypointType != Waypoint.WaypointType.PathfindingPoint))
                            {
                                switch (waypoint.waypointType)
                                {
                                    case Waypoint.WaypointType.Assemble:
                                    case Waypoint.WaypointType.InitialPoint:
                                    case Waypoint.WaypointType.Split:
                                    case Waypoint.WaypointType.Target:
                                    case Waypoint.WaypointType.StrikeIngress:
                                    case Waypoint.WaypointType.WeaponLaunch:
                                    case Waypoint.WaypointType.WeaponTarget:
                                        return true;
                                }
                                break;
                            }
                        }
                        return flag;

                    case Waypoint.WaypointType.Assemble:
                    case Waypoint.WaypointType.InitialPoint:
                    case Waypoint.WaypointType.Split:
                    case Waypoint.WaypointType.Target:
                    case Waypoint.WaypointType.StrikeIngress:
                    case Waypoint.WaypointType.WeaponLaunch:
                    case Waypoint.WaypointType.WeaponTarget:
                        flag = true;
                        return true;

                    case Waypoint.WaypointType.Formate:
                    case Waypoint.WaypointType.LandingMarshal:
                    case Waypoint.WaypointType.StrikeEgress:
                    case Waypoint.WaypointType.Refuel:
                    case Waypoint.WaypointType.TakeOff:
                    case Waypoint.WaypointType.Marshal:
                    case Waypoint.WaypointType.Land:
                        goto Label_00F8;

                    default:
                        goto Label_00F8;
                }
            }
            return false;
        Label_00F8:
            return false;

        }

        // Token: 0x06003267 RID: 12903 RVA: 0x001101DC File Offset: 0x0010E3DC
        public bool method_20()
		{
            bool flag = false;
            if (this.HasPlottedCourse())
            {
                Waypoint.WaypointType waypointType = this.GetPlottedCourse()[0].waypointType;
                if (waypointType > Waypoint.WaypointType.TurningPoint)
                {
                    if ((waypointType == Waypoint.WaypointType.Target) || (waypointType == Waypoint.WaypointType.WeaponTarget))
                    {
                        flag = true;
                        return true;
                    }
                }
                else if ((waypointType == Waypoint.WaypointType.PathfindingPoint) || (waypointType == Waypoint.WaypointType.TurningPoint))
                {
                    foreach (Waypoint waypoint in this.GetPlottedCourse())
                    {
                        if ((waypoint.waypointType != Waypoint.WaypointType.TurningPoint) && (waypoint.waypointType != Waypoint.WaypointType.PathfindingPoint))
                        {
                            Waypoint.WaypointType type2 = waypoint.waypointType;
                            if ((type2 != Waypoint.WaypointType.Target) && (type2 != Waypoint.WaypointType.WeaponTarget))
                            {
                                return false;
                            }
                            return true;
                        }
                    }
                    return flag;
                }
            }
            return false;

        }

        // Token: 0x06003268 RID: 12904 RVA: 0x0011029C File Offset: 0x0010E49C
        public bool method_21()
		{
			bool flag = false;
			checked
			{
				bool result;
				if (!this.HasPlottedCourse())
				{
					flag = false;
				}
				else
				{
					Waypoint.WaypointType waypointType = this.GetPlottedCourse()[0].waypointType;
					if (waypointType != Waypoint.WaypointType.PathfindingPoint && waypointType != Waypoint.WaypointType.TurningPoint)
					{
						switch (waypointType)
						{
						case Waypoint.WaypointType.Formate:
						case Waypoint.WaypointType.LandingMarshal:
						case Waypoint.WaypointType.StrikeEgress:
							result = true;
							return result;
						case Waypoint.WaypointType.Target:
						case Waypoint.WaypointType.StrikeIngress:
							result = false;
							return result;
						default:
							result = false;
							return result;
						}
					}
					else
					{
						Waypoint[] plottedCourse = this.GetPlottedCourse();
						int i = 0;
						while (i < plottedCourse.Length)
						{
							Waypoint waypoint = plottedCourse[i];
							if (waypoint.waypointType == Waypoint.WaypointType.TurningPoint || waypoint.waypointType == Waypoint.WaypointType.PathfindingPoint)
							{
								i++;
							}
							else
							{
								switch (waypoint.waypointType)
								{
								case Waypoint.WaypointType.Formate:
								case Waypoint.WaypointType.LandingMarshal:
								case Waypoint.WaypointType.StrikeEgress:
									result = true;
									return result;
								case Waypoint.WaypointType.Target:
								case Waypoint.WaypointType.StrikeIngress:
									result = false;
									return result;
								default:
									result = false;
									return result;
								}
							}
						}
					}
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00110380 File Offset: 0x0010E580
		public bool method_22()
		{
			bool result = false;
			checked
			{
				if (!this.HasPlottedCourse())
				{
					result = false;
				}
				else
				{
					Waypoint.WaypointType waypointType = this.GetPlottedCourse()[0].waypointType;
					if (waypointType != Waypoint.WaypointType.PathfindingPoint && waypointType != Waypoint.WaypointType.TurningPoint)
					{
						result = (waypointType == Waypoint.WaypointType.LandingMarshal);
					}
					else
					{
						Waypoint[] plottedCourse = this.GetPlottedCourse();
						for (int i = 0; i < plottedCourse.Length; i++)
						{
							Waypoint waypoint = plottedCourse[i];
							if (waypoint.waypointType != Waypoint.WaypointType.TurningPoint && waypoint.waypointType != Waypoint.WaypointType.PathfindingPoint)
							{
								Waypoint.WaypointType waypointType2 = waypoint.waypointType;
								result = (waypointType2 == Waypoint.WaypointType.LandingMarshal);
								break;
							}
						}
					}
				}
				return result;
			}
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00110408 File Offset: 0x0010E608
		public bool method_23()
		{
			checked
			{
				bool result;
				if (this.HasPlottedCourse())
				{
					switch (this.GetPlottedCourse()[0].waypointType)
					{
					case Waypoint.WaypointType.Split:
						result = true;
						return result;
					case Waypoint.WaypointType.Formate:
					case Waypoint.WaypointType.Target:
					case Waypoint.WaypointType.LandingMarshal:
					case Waypoint.WaypointType.StrikeIngress:
					case Waypoint.WaypointType.StrikeEgress:
					case Waypoint.WaypointType.WeaponTarget:
						result = false;
						return result;
					}
					bool flag = false;
					Waypoint[] plottedCourse = this.GetPlottedCourse();
					int i = 0;
					while (i < plottedCourse.Length)
					{
						Waypoint waypoint = plottedCourse[i];
						if (waypoint.waypointType != Waypoint.WaypointType.Formate && waypoint.waypointType != Waypoint.WaypointType.StrikeIngress && waypoint.waypointType != Waypoint.WaypointType.StrikeEgress)
						{
							i++;
						}
						else
						{
							flag = true;
							if (this.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.InitialPoint && this.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.WeaponLaunch)
							{
								Waypoint[] plottedCourse2 = this.GetPlottedCourse();
								for (int j = 0; j < plottedCourse2.Length; j++)
								{
									Waypoint waypoint2 = plottedCourse2[j];
									if (waypoint2.waypointType != Waypoint.WaypointType.TurningPoint && waypoint2.waypointType != Waypoint.WaypointType.PathfindingPoint)
									{
										switch (waypoint2.waypointType)
										{
										case Waypoint.WaypointType.PathfindingPoint:
										case Waypoint.WaypointType.TurningPoint:
											goto IL_247;
										case Waypoint.WaypointType.InitialPoint:
										case Waypoint.WaypointType.WeaponLaunch:
											result = !flag;
											return result;
										case Waypoint.WaypointType.Split:
											result = true;
											return result;
										case Waypoint.WaypointType.Formate:
										case Waypoint.WaypointType.Target:
										case Waypoint.WaypointType.LandingMarshal:
										case Waypoint.WaypointType.StrikeIngress:
										case Waypoint.WaypointType.StrikeEgress:
										case Waypoint.WaypointType.WeaponTarget:
											result = false;
											return result;
										}
										result = false;
										return result;
									}
									IL_247:;
								}
								result = false;
								return result;
							}
							result = !flag;
							return result;
						}
					}
					if (this.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.InitialPoint && this.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.WeaponLaunch)
					{
						Waypoint[] plottedCourse2 = this.GetPlottedCourse();
						for (int j = 0; j < plottedCourse2.Length; j++)
						{
							Waypoint waypoint2 = plottedCourse2[j];
							if (waypoint2.waypointType != Waypoint.WaypointType.TurningPoint && waypoint2.waypointType != Waypoint.WaypointType.PathfindingPoint)
							{
								switch (waypoint2.waypointType)
								{
								case Waypoint.WaypointType.PathfindingPoint:
								case Waypoint.WaypointType.TurningPoint:
									goto IL_158;
								case Waypoint.WaypointType.InitialPoint:
								case Waypoint.WaypointType.WeaponLaunch:
									result = !flag;
									return result;
								case Waypoint.WaypointType.Split:
									result = true;
									return result;
								case Waypoint.WaypointType.Formate:
								case Waypoint.WaypointType.Target:
								case Waypoint.WaypointType.LandingMarshal:
								case Waypoint.WaypointType.StrikeIngress:
								case Waypoint.WaypointType.StrikeEgress:
								case Waypoint.WaypointType.WeaponTarget:
									result = false;
									return result;
								}
								result = false;
								return result;
							}
							IL_158:;
						}
						result = false;
					}
					else
					{
						result = !flag;
					}
				}
				else
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00110694 File Offset: 0x0010E894
		public bool method_24()
		{
            bool flag = false;
            if (this.HasPlottedCourse())
            {
                Waypoint.WaypointType waypointType = this.GetPlottedCourse()[0].waypointType;
                if (waypointType > Waypoint.WaypointType.TurningPoint)
                {
                    if ((waypointType == Waypoint.WaypointType.Formate) || (waypointType == Waypoint.WaypointType.StrikeEgress))
                    {
                        flag = true;
                        return true;
                    }
                }
                else if ((waypointType == Waypoint.WaypointType.PathfindingPoint) || (waypointType == Waypoint.WaypointType.TurningPoint))
                {
                    foreach (Waypoint waypoint in this.GetPlottedCourse())
                    {
                        if ((waypoint.waypointType != Waypoint.WaypointType.TurningPoint) && (waypoint.waypointType != Waypoint.WaypointType.PathfindingPoint))
                        {
                            Waypoint.WaypointType type2 = waypoint.waypointType;
                            if ((type2 != Waypoint.WaypointType.Formate) && (type2 != Waypoint.WaypointType.StrikeEgress))
                            {
                                return false;
                            }
                            return true;
                        }
                    }
                    return flag;
                }
            }
            return false;

        }

        // Token: 0x0600326C RID: 12908 RVA: 0x00110754 File Offset: 0x0010E954
        public bool method_25()
		{
			checked
			{
				bool flag;
				bool result;
				if (!this.HasPlottedCourse())
				{
					flag = false;
				}
				else
				{
					Waypoint[] plottedCourse = this.GetPlottedCourse();
					for (int i = 0; i < plottedCourse.Length; i++)
					{
						switch (plottedCourse[i].waypointType)
						{
						case Waypoint.WaypointType.PathfindingPoint:
						case Waypoint.WaypointType.TurningPoint:
						{
							Waypoint[] plottedCourse2 = this.GetPlottedCourse();
							int j = 0;
							while (j < plottedCourse2.Length)
							{
								Waypoint waypoint = plottedCourse2[j];
								if (waypoint.waypointType == Waypoint.WaypointType.TurningPoint || waypoint.waypointType == Waypoint.WaypointType.PathfindingPoint)
								{
									j++;
								}
								else
								{
									switch (waypoint.waypointType)
									{
									case Waypoint.WaypointType.Assemble:
									case Waypoint.WaypointType.InitialPoint:
									case Waypoint.WaypointType.Split:
									case Waypoint.WaypointType.Formate:
									case Waypoint.WaypointType.Target:
									case Waypoint.WaypointType.LandingMarshal:
									case Waypoint.WaypointType.StrikeIngress:
									case Waypoint.WaypointType.StrikeEgress:
									case Waypoint.WaypointType.WeaponLaunch:
									case Waypoint.WaypointType.WeaponTarget:
										result = true;
										return result;
									case Waypoint.WaypointType.TurningPoint:
									case Waypoint.WaypointType.Refuel:
									case Waypoint.WaypointType.TakeOff:
									case Waypoint.WaypointType.Marshal:
									case Waypoint.WaypointType.Land:
										result = false;
										return result;
									default:
										result = false;
										return result;
									}
								}
							}
							break;
						}
						case Waypoint.WaypointType.Assemble:
						case Waypoint.WaypointType.InitialPoint:
						case Waypoint.WaypointType.Split:
						case Waypoint.WaypointType.Formate:
						case Waypoint.WaypointType.Target:
						case Waypoint.WaypointType.LandingMarshal:
						case Waypoint.WaypointType.StrikeIngress:
						case Waypoint.WaypointType.StrikeEgress:
						case Waypoint.WaypointType.WeaponLaunch:
						case Waypoint.WaypointType.WeaponTarget:
							result = true;
							return result;
						}
					}
					flag = false;
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x0001B1B5 File Offset: 0x000193B5
		public bool method_26(GeoPoint geoPoint_0, float float_3)
		{
			return this.vmethod_8(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), float_3);
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00110890 File Offset: 0x0010EA90
		public virtual  bool vmethod_8(double lat_, double lon_, float float_3)
		{
			bool result = false;
			try
			{
				if (this.ParentPlatform.GetApproxAngularDistanceInDegrees(ref lat_, ref lon_) > Misc.double_0)
				{
					result = false;
				}
				else
				{
					float distance = Math2.GetDistance(lat_, lon_, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
					float num = this.ParentPlatform.GetCurrentSpeed() / 3600f;
					result = (distance < num * 2f);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100212", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00110968 File Offset: 0x0010EB68
		public virtual  void vmethod_9(float float_3, ref bool bool_14)
		{
			try
			{
				if (this.GetPlottedCourse().Count<Waypoint>() != 0)
				{
					Waypoint geoPoint_ = this.GetPlottedCourse()[0];
					if (this.method_26(geoPoint_, float_3))
					{
						this.method_27(this.GetPlottedCourse()[0]);
						this.method_28(this.GetPlottedCourse()[0]);
						this.RemoveWaypoint(this.GetPlottedCourse()[0], false);
						if (this.GetPlottedCourse().Count<Waypoint>() > 0)
						{
							this.method_16();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100213", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x00110A30 File Offset: 0x0010EC30
		public void method_27(Waypoint waypoint_2)
		{
			if (!Information.IsNothing(this.ParentPlatform))
			{
				try
				{
					if (waypoint_2.GetDSO().HasValue)
					{
						if (!waypoint_2.DesiredSpeed.HasValue)
						{
							this.ParentPlatform.SetDesiredSpeed(0f);
						}
						else if (waypoint_2.DesiredSpeed.HasValue)
						{
							this.ParentPlatform.SetDesiredSpeed(waypoint_2.DesiredSpeed.Value);
						}
						this.ParentPlatform.GetKinematics().SetDesiredSpeedOverride(new float?(this.ParentPlatform.GetDesiredSpeed()));
						this.ParentPlatform.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
					}
					else if (waypoint_2.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
					{
						this.ParentPlatform.GetKinematics().SetSpeedPreset(waypoint_2.GetThrottlePreset());
						this.ParentPlatform.SetDesiredSpeed((float)this.ParentPlatform.GetKinematics().GetSpeed(this.ParentPlatform.GetCurrentAltitude_ASL(false), (ActiveUnit.Throttle)this.ParentPlatform.GetKinematics().GetSpeedPreset()));
						this.ParentPlatform.GetKinematics().SetDesiredSpeedOverride(new float?(this.ParentPlatform.GetDesiredSpeed()));
					}
					if (waypoint_2.GetDAO())
					{
						if (this.ParentPlatform.IsSubmarine)
						{
							((Submarine)this.ParentPlatform).GetSubmarineAI().SetDepthPreset(waypoint_2.GetDepthPreset());
						}
						if (this.ParentPlatform.IsAircraft)
						{
							((Aircraft)this.ParentPlatform).GetAircraftAI().SetAltitudePreset(waypoint_2.GetAltitudePreset());
						}
						this.ParentPlatform.GetKinematics().SetDesiredAltitudeOverride(waypoint_2.GetDAO());
						if (waypoint_2.GetAltitudePreset() != ActiveUnit_AI._AltitudePreset.None && this.ParentPlatform.IsAircraft)
						{
							((Aircraft)this.ParentPlatform).GetAircraftAI().SetDesiredAltitude();
						}
						else if (waypoint_2.GetDepthPreset() != ActiveUnit_AI._DepthPreset.None && this.ParentPlatform.IsSubmarine)
						{
							((Submarine)this.ParentPlatform).GetSubmarineAI().SetDesiredDepth(true);
						}
						else if ((this.ParentPlatform.IsAircraft || this.ParentPlatform.IsSubmarine) && waypoint_2.DesiredAltitude.HasValue)
						{
							this.ParentPlatform.SetDesiredAltitude(waypoint_2.DesiredAltitude.Value);
							float maxAltitude = this.ParentPlatform.GetKinematics().GetMaxAltitude();
							float minAltitude = this.ParentPlatform.GetKinematics().GetMinAltitude();
							if (this.ParentPlatform.GetDesiredAltitude() > maxAltitude)
							{
								this.ParentPlatform.SetDesiredAltitude(maxAltitude);
							}
							else if (this.ParentPlatform.GetDesiredAltitude() < minAltitude)
							{
								this.ParentPlatform.SetDesiredAltitude(minAltitude);
							}
						}
						if ((this.ParentPlatform.IsAircraft || this.ParentPlatform.IsSubmarine) && waypoint_2.DesiredAltitude_TerrainFollowing.HasValue && waypoint_2.IsTerrainFollowing())
						{
							this.ParentPlatform.SetDesiredAltitude_TerrainFollowing(waypoint_2.DesiredAltitude_TerrainFollowing.Value);
						}
						if (this.ParentPlatform.IsAircraft)
						{
							if (waypoint_2.DesiredAltitude_TerrainFollowing.HasValue)
							{
								this.ParentPlatform.SetIsTerrainFollowing(this.ParentPlatform, waypoint_2.IsTerrainFollowing());
							}
							else
							{
								this.ParentPlatform.SetIsTerrainFollowing(this.ParentPlatform, false);
							}
						}
					}
					this.ParentPlatform.SetDesiredTurnRate(ActiveUnit._TurnRate.const_1);
					if (!Information.IsNothing(this.ParentPlatform.GetNavigator().GetFlight()))
					{
						this.ParentPlatform.SetDesiredTurnRate_Navigation(waypoint_2.TurnRate);
					}
					else
					{
						this.ParentPlatform.SetDesiredTurnRate_Navigation(Waypoint._TurnRate.Standard);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100216", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x00110E10 File Offset: 0x0010F010
		public void method_28(Waypoint waypoint_2)
		{
			if (!Information.IsNothing(this.ParentPlatform))
			{
				try
				{
					ActiveUnit activeUnit_;
					if (this.ParentPlatform.IsGroupLead())
					{
						using (IEnumerator<ActiveUnit> enumerator = this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								activeUnit_ = enumerator.Current;
								this.method_29(activeUnit_, waypoint_2);
							}
							goto IL_77;
						}
					}
					activeUnit_ = this.ParentPlatform;
					this.method_29(activeUnit_, waypoint_2);
					IL_77:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101305", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x00110EE8 File Offset: 0x0010F0E8
		private void method_29(ActiveUnit activeUnit_1, Waypoint waypoint_2)
		{
			try
			{
				Doctrine doctrine = waypoint_2.m_Doctrine;
				if (doctrine.UseNukesHasNoValue())
				{
					activeUnit_1.m_Doctrine.method_35(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._UseNuclear? useNuclearDoctrine = doctrine.GetUseNuclearDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.method_35(activeUnit_1.m_Scenario, false, false, false, doctrine.GetUseNuclearDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.WCS_AirHasNoValue())
				{
					activeUnit_1.m_Doctrine.method_63(activeUnit_1.m_Scenario, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus? wCS_AirDoctrine = doctrine.GetWCS_AirDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false);
					byte? b = wCS_AirDoctrine.HasValue ? new byte?((byte)wCS_AirDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.method_63(activeUnit_1.m_Scenario, false, new bool?(false), false, false, doctrine.GetWCS_AirDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false));
					}
				}
				if (doctrine.WCS_LandHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWCS_LandDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus? wCS_LandDoctrine = doctrine.GetWCS_LandDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false);
					byte? b = wCS_LandDoctrine.HasValue ? new byte?((byte)wCS_LandDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWCS_LandDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, doctrine.GetWCS_LandDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false));
					}
				}
				if (doctrine.WCS_SurfaceHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWCS_SurfaceDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus? wCS_SurfaceDoctrine = doctrine.GetWCS_SurfaceDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false);
					byte? b = wCS_SurfaceDoctrine.HasValue ? new byte?((byte)wCS_SurfaceDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWCS_SurfaceDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, doctrine.GetWCS_SurfaceDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false));
					}
				}
				if (doctrine.WCS_SubmarineHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWCS_SubmarineDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus? wCS_SubmarineDoctrine = doctrine.GetWCS_SubmarineDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false);
					byte? b = wCS_SubmarineDoctrine.HasValue ? new byte?((byte)wCS_SubmarineDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWCS_SubmarineDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, doctrine.GetWCS_SubmarineDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false));
					}
				}
				if (doctrine.GunStrafeGroundTargetsHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine = doctrine.GetGunStrafeGroundTargetsDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetGunStrafeGroundTargetsDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false);
					byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false));
					}
				}
				if (doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTargetDoctrine = doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = behaviorTowardsAmbigousTargetDoctrine.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.AutomaticEvasionHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetAutomaticEvasionDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._AutomaticEvasion? automaticEvasionDoctrine = doctrine.GetAutomaticEvasionDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = automaticEvasionDoctrine.HasValue ? new byte?((byte)automaticEvasionDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetAutomaticEvasionDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetAutomaticEvasionDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.MaintainStandoffHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetMaintainStandoffDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._MaintainStandoff? maintainStandoffDoctrine = doctrine.GetMaintainStandoffDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = maintainStandoffDoctrine.HasValue ? new byte?((byte)maintainStandoffDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetMaintainStandoffDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetMaintainStandoffDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.UseRefuelHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetUseRefuelDoctrine(activeUnit_1.m_Scenario, false, false, false, false, null);
				}
				else
				{
					Doctrine._UseRefuel? useRefuelDoctrine = doctrine.GetUseRefuelDoctrine(activeUnit_1.m_Scenario, false, false, false, false);
					byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetUseRefuelDoctrine(activeUnit_1.m_Scenario, false, false, false, false, doctrine.GetUseRefuelDoctrine(activeUnit_1.m_Scenario, false, false, false, false));
					}
				}
				if (doctrine.RefuelSelectionHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetRefuelSelectionDoctrine(activeUnit_1.m_Scenario, false, false, false, false, null);
				}
				else
				{
					Doctrine._RefuelSelection? refuelSelectionDoctrine = doctrine.GetRefuelSelectionDoctrine(activeUnit_1.m_Scenario, false, false, false, false);
					byte? b = refuelSelectionDoctrine.HasValue ? new byte?((byte)refuelSelectionDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRefuelSelectionDoctrine(activeUnit_1.m_Scenario, false, false, false, false, doctrine.GetRefuelSelectionDoctrine(activeUnit_1.m_Scenario, false, false, false, false));
					}
				}
				if (doctrine.ShootTouristsHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetShootTouristsDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._ShootTourists? shootTouristsDoctrine = doctrine.GetShootTouristsDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetShootTouristsDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetShootTouristsDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.SAM_ASUWHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetUseSAMsInASuWModeDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._UseSAMsInASuWMode? useSAMsInASuWModeDoctrine = doctrine.GetUseSAMsInASuWModeDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = useSAMsInASuWModeDoctrine.HasValue ? new byte?((byte)useSAMsInASuWModeDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetUseSAMsInASuWModeDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetUseSAMsInASuWModeDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.IgnoreEMCONUnderAttackHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttackDoctrine = doctrine.GetIgnoreEMCONUnderAttackDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = ignoreEMCONUnderAttackDoctrine.HasValue ? new byte?((byte)ignoreEMCONUnderAttackDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetIgnoreEMCONUnderAttackDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.QuickTurnAroundHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetQuickTurnAroundDoctrine(activeUnit_1.m_Scenario, false, false, false, false, null);
				}
				else
				{
					Doctrine._QuickTurnAround? quickTurnAroundDoctrine = doctrine.GetQuickTurnAroundDoctrine(activeUnit_1.m_Scenario, false, false, false, false);
					byte? b = quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetQuickTurnAroundDoctrine(activeUnit_1.m_Scenario, false, false, false, false, doctrine.GetQuickTurnAroundDoctrine(activeUnit_1.m_Scenario, false, false, false, false));
					}
				}
				if (doctrine.AirOpsTempoHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetAirOpsTempoDoctrine(activeUnit_1.m_Scenario, false, false, false, false, null);
				}
				else
				{
					Doctrine._AirOpsTempo? airOpsTempoDoctrine = doctrine.GetAirOpsTempoDoctrine(activeUnit_1.m_Scenario, false, false, false, false);
					byte? b = airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetAirOpsTempoDoctrine(activeUnit_1.m_Scenario, false, false, false, false, doctrine.GetAirOpsTempoDoctrine(activeUnit_1.m_Scenario, false, false, false, false));
					}
				}
				if (doctrine.WinchesterShotgunHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWinchesterShotgunDoctrine(activeUnit_1.m_Scenario, false, false, false, false, null);
				}
				else
				{
					Doctrine._WeaponState? winchesterShotgunDoctrine = doctrine.GetWinchesterShotgunDoctrine(activeUnit_1.m_Scenario, false, false, false, false);
					int? num = winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null;
					bool? flag = num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWinchesterShotgunDoctrine(activeUnit_1.m_Scenario, false, false, false, false, doctrine.GetWinchesterShotgunDoctrine(activeUnit_1.m_Scenario, false, false, false, false));
					}
				}
				if (doctrine.WinchesterShotgunRTBHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWinchesterShotgunRTBDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._WeaponStateRTB? winchesterShotgunRTBDoctrine = doctrine.GetWinchesterShotgunRTBDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWinchesterShotgunRTBDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetWinchesterShotgunRTBDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.BingoJokerHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetBingoJokerDoctrine(activeUnit_1.m_Scenario, false, false, false, false, null);
				}
				else
				{
					Doctrine._FuelState? bingoJokerDoctrine = doctrine.GetBingoJokerDoctrine(activeUnit_1.m_Scenario, false, false, false, false);
					byte? b = bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 14) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetBingoJokerDoctrine(activeUnit_1.m_Scenario, false, false, false, false, doctrine.GetBingoJokerDoctrine(activeUnit_1.m_Scenario, false, false, false, false));
					}
				}
				if (doctrine.BingoJokerRTBHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetBingoJokerRTBDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._FuelStateRTB? bingoJokerRTBDoctrine = doctrine.GetBingoJokerRTBDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetBingoJokerRTBDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetBingoJokerRTBDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.JettisonOrdnanceHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetJettisonOrdnanceDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._JettisonOrdnance? jettisonOrdnanceDoctrine = doctrine.GetJettisonOrdnanceDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = jettisonOrdnanceDoctrine.HasValue ? new byte?((byte)jettisonOrdnanceDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetJettisonOrdnanceDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetJettisonOrdnanceDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.UseTorpedoesKinematicRangeHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRangeDoctrine = doctrine.GetUseTorpedoesKinematicRangeDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = useTorpedoesKinematicRangeDoctrine.HasValue ? new byte?((byte)useTorpedoesKinematicRangeDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetUseTorpedoesKinematicRangeDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.RefuelAlliesHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetRefuelAlliedUnitsDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._RefuelAlliedUnits? refuelAlliedUnitsDoctrine = doctrine.GetRefuelAlliedUnitsDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRefuelAlliedUnitsDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRefuelAlliedUnitsDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.AvoidContactHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._AvoidContactWhenPossible? avoidContactWhenPossibleDoctrine = doctrine.GetAvoidContactWhenPossibleDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = avoidContactWhenPossibleDoctrine.HasValue ? new byte?((byte)avoidContactWhenPossibleDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetAvoidContactWhenPossibleDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.DiveWhenThreatsDetectedHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetDiveOnContactDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._DiveOnContact? diveOnContactDoctrine = doctrine.GetDiveOnContactDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetDiveOnContactDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetDiveOnContactDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.RechargePercentagePatrolHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetRechargeBatteryPercentageDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = doctrine.GetRechargeBatteryPercentageDoctrine(activeUnit_1.m_Scenario, false, false, false);
					int? num = rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null;
					bool? flag = num.HasValue ? new bool?(num.GetValueOrDefault() == -101) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRechargeBatteryPercentageDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRechargeBatteryPercentageDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.RechargePercentageAttackHasNoValue())
				{
					activeUnit_1.m_Doctrine.method_245(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = doctrine.GetRechargeBatteryPercentageDoc(activeUnit_1.m_Scenario, false, false, false);
					int? num = rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null;
					bool? flag = num.HasValue ? new bool?(num.GetValueOrDefault() == -101) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.method_245(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRechargeBatteryPercentageDoc(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.AIPUsageHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetUseAIPDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._UseAIP? useAIPDoctrine = doctrine.GetUseAIPDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = useAIPDoctrine.HasValue ? new byte?((byte)useAIPDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetUseAIPDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetUseAIPDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.DippingSonarHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetUseDippingSonarDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._UseDippingSonar? useDippingSonarDoctrine = doctrine.GetUseDippingSonarDoctrine(activeUnit_1.m_Scenario, false, false, false);
					byte? b = useDippingSonarDoctrine.HasValue ? new byte?((byte)useDippingSonarDoctrine.GetValueOrDefault()) : null;
					bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetUseDippingSonarDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetUseDippingSonarDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.WithdrawDamageThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWithdrawDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._DamageThreshold? damageThreshold = doctrine.GetWithdrawDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 6) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWithdrawDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetWithdrawDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.WithdrawFuelThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWithdrawFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = doctrine.GetWithdrawFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 7) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWithdrawFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetWithdrawFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.WithdrawAttackThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWithdrawAttackThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.GetWithdrawAttackThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 8) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWithdrawAttackThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetWithdrawAttackThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.WithdrawDefenceThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.GetWithdrawDefenceThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 8) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetWithdrawDefenceThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.WCS_LandHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetWCS_LandDoctrine(activeUnit_1.m_Scenario, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._DamageThreshold? damageThreshold = doctrine.GetRedeployDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 6) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRedeployDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRedeployDamageThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.RedeployFuelThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetRedeployFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = doctrine.GetRedeployFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 7) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRedeployFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRedeployFuelThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 8) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (doctrine.RedeployDefenceThresholdHasNoValue())
				{
					activeUnit_1.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(activeUnit_1.m_Scenario, false, false, false, null);
				}
				else
				{
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.GetRedeployDefenceWeaponQuantityThreshold(activeUnit_1.m_Scenario, false, false, false);
					short? num2 = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
					bool? flag = num2.HasValue ? new bool?(num2.GetValueOrDefault() == 8) : null;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						activeUnit_1.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(activeUnit_1.m_Scenario, false, false, false, doctrine.GetRedeployDefenceWeaponQuantityThreshold(activeUnit_1.m_Scenario, false, false, false));
					}
				}
				if (!doctrine.EMCON_SettingsHasNoValue())
				{
					if (doctrine.GetEMCON_Settings(activeUnit_1.m_Scenario).GetEMCON_SettingsForRadar() != Doctrine.EMCON_Settings.Enum36.const_3)
					{
						activeUnit_1.m_Doctrine.SetEMCON_Settings(false);
						activeUnit_1.m_Doctrine.SetEMCON_SettingsForSonar(doctrine.GetEMCON_Settings(activeUnit_1.m_Scenario).GetEMCON_SettingsForRadar(), activeUnit_1.m_Scenario);
					}
					if (doctrine.GetEMCON_Settings(activeUnit_1.m_Scenario).GetEMCON_SettingsForSonar() != Doctrine.EMCON_Settings.Enum36.const_3)
					{
						activeUnit_1.m_Doctrine.SetEMCON_Settings(false);
						activeUnit_1.m_Doctrine.SetEMCON_SettingsForRadar(doctrine.GetEMCON_Settings(activeUnit_1.m_Scenario).GetEMCON_SettingsForSonar(), activeUnit_1.m_Scenario);
					}
					if (doctrine.GetEMCON_Settings(activeUnit_1.m_Scenario).GetEMCON_SettingsForOECM() != Doctrine.EMCON_Settings.Enum36.const_3)
					{
						activeUnit_1.m_Doctrine.SetEMCON_Settings(false);
						activeUnit_1.m_Doctrine.method_173(doctrine.GetEMCON_Settings(activeUnit_1.m_Scenario).GetEMCON_SettingsForOECM(), activeUnit_1.m_Scenario);
					}
					activeUnit_1.GetSensory().ScheduleEMCONEvent(activeUnit_1.GetAllNoneMCMSensors());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101304", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00113058 File Offset: 0x00111258
		public virtual bool IsOnFormationStation()
		{
			bool result;
			if (Information.IsNothing(this.ParentPlatform.GetParentGroup(false)))
			{
				result = false;
			}
			else if (Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetGroupLead()))
			{
				result = false;
			}
			else
			{
				double latitude = this.GetFormationStation().GetLatitude(this.ParentPlatform, this.ParentPlatform.GetParentGroup(false).GetGroupLead());
				double longitude = this.GetFormationStation().GetLongitude(this.ParentPlatform, this.ParentPlatform.GetParentGroup(false).GetGroupLead());
				result = ((double)Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), latitude, longitude) < 0.25 || ((double)Math.Abs(new GeoPoint(longitude, latitude).RelativeBearingTo(this.ParentPlatform)) > 90.0 && Math.Abs(Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetCurrentHeading())) < 20f));
			}
			return result;
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00113184 File Offset: 0x00111384
		public virtual void FollowGroupLead(float elapsedTime_)
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
				if (this.ParentPlatform.HasParentGroup() && !this.ParentPlatform.GetKinematics().GetDesiredAltitudeOverride())
				{
					this.ParentPlatform.SetDesiredAltitude(this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetDesiredAltitude());
					this.ParentPlatform.SetDesiredAltitude_TerrainFollowing(this.ParentPlatform.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing());
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
					if (this.HasPathfindingCourse())
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
							GeoPointGenerator.GetOtherGeoPoint(groupLead.GetLongitude(null), groupLead.GetLatitude(null), ref num, ref num2, (double)this.GetFormationStation().Distance, (double)this.GetFormationStation().GetBearing(this.ParentPlatform));
							if (this.GetFormationStation().SprintAndDrift)
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
									if (this.ParentPlatform.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.None)
									{
										this.ParentPlatform.SetThrottle((ActiveUnit.Throttle)this.ParentPlatform.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
									}
									else
									{
										this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().Value))), this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride());
									}
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
								double num5 = 0.0;
								double num6 = 0.0;
								GeoPointGenerator.GetOtherGeoPoint(num, num2, ref num5, ref num6, (double)this.GetFormationStation().Distance, (double)groupLead.GetCurrentHeading());
								Unit parentPlatform = this.ParentPlatform;
								double lat_ = num6;
								double lon_ = num5;
								byte b = 0;
								bool flag = true;
								bool flag2 = true;
								float? nullable_ = null;
								short? nullable_2 = null;
								List<ActiveUnit> list = null;
								if (!parentPlatform.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, nullable_, nullable_2, ref list, 0f, false, false))
								{
									num2 = groupLead.GetLatitude(null);
									num = groupLead.GetLongitude(null);
								}
							}
							this.ParentPlatform.GetAI().geoPoint_1 = new GeoPoint(num, num2);
							if (!this.HasPathfindingCourse() && !this.bool_2)
							{
								if (this.ParentPlatform.GetNavigator().bUpdated && this.vmethod_16(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num, true, 0f, true, null))
								{
									this.method_12(null, this.ParentPlatform, null, false, 0.15f, num2, num, this.ParentPlatform.m_Scenario, false);
								}
								else if (!this.GetFormationStation().SprintAndDrift)
								{
									float angleBetween2 = Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num2, num));
									if (angleBetween2 > 90f && angleBetween2 < 270f && Math.Abs(Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetParentGroup(false).GetCurrentHeading())) <= 30f)
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

		// Token: 0x06003275 RID: 12917 RVA: 0x00113BFC File Offset: 0x00111DFC
		public bool method_30(ref List<ReferencePoint> list_1, ref List<ReferencePoint> list_2, ref List<ReferencePoint> list_3, float float_3, bool bool_14)
		{
			bool flag = false;
			bool result;
			if (this.GetPlottedCourse().Count<Waypoint>() == 0)
			{
				flag = false;
			}
			else if (list_1.Count == 0)
			{
				flag = false;
			}
			else
			{
				try
				{
					bool flag2 = this.method_31(list_1, list_3);
					if (!bool_14 && !flag2)
					{
						if (this.short_8 > 0)
						{
							flag = (result = this.bool_11);
							return result;
						}
						this.short_8 = 60;
					}
					if (list_2.Count == 0 || flag2)
					{
						this.method_35(float_3, ref list_1, ref list_2, ref list_3);
					}
					foreach (ReferencePoint current in list_1)
					{
						if (current.GetLatitude() == this.GetPlottedCourse()[0].GetLatitude() && current.GetLongitude() == this.GetPlottedCourse()[0].GetLongitude())
						{
							this.bool_11 = true;
							flag = (result = this.bool_11);
							return result;
						}
						if (float_3 > 0f && Math2.GetDistance(this.GetPlottedCourse()[0].GetLatitude(), this.GetPlottedCourse()[0].GetLongitude(), current.GetLatitude(), current.GetLongitude()) <= float_3 * 2f)
						{
							this.bool_11 = true;
							flag = (result = this.bool_11);
							return result;
						}
					}
					if (list_1.Count == 1)
					{
						this.bool_11 = (Math2.GetDistance(this.GetPlottedCourse()[this.GetPlottedCourse().Count<Waypoint>() - 1].GetLatitude(), this.GetPlottedCourse()[this.GetPlottedCourse().Count<Waypoint>() - 1].GetLongitude(), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= float_3);
					}
					else if (list_1.Count > 1)
					{
						if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3) && float_3 != 0f)
						{
							GeoPoint geoPoint = this.GetPlottedCourse()[this.GetPlottedCourse().Count<Waypoint>() - 1];
							List<ReferencePoint> list = list_2.ToList<ReferencePoint>();
							this.bool_11 = geoPoint.method_22(ref list, true);
						}
						else
						{
							GeoPoint geoPoint2 = this.GetPlottedCourse()[this.GetPlottedCourse().Count<Waypoint>() - 1];
							List<ReferencePoint> list = list_1.ToList<ReferencePoint>();
							this.bool_11 = geoPoint2.method_22(ref list, true);
						}
					}
					flag = this.bool_11;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200341", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = true;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00113EF0 File Offset: 0x001120F0
		public bool method_31(List<ReferencePoint> list_1, List<ReferencePoint> list_2)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(list_2))
				{
					flag = true;
				}
				else if (list_1.Count != list_2.Count)
				{
					flag = true;
				}
				else
				{
					int num = list_1.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (list_1[i].GetLatitude() != list_2[i].GetLatitude())
						{
							if (Math.Abs(list_1[i].GetLatitude() - list_2[i].GetLatitude()) > 0.1)
							{
								flag = true;
								result = true;
								return result;
							}
						}
						else if (list_1[i].GetLongitude() != list_2[i].GetLongitude() && Math.Abs(list_1[i].GetLongitude() - list_2[i].GetLongitude()) > 0.1)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200322", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00114048 File Offset: 0x00112248
		public bool method_32(List<GeoPoint> list_1, List<GeoPoint> list_2)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(list_2))
				{
					flag = true;
				}
				else if (list_1.Count != list_2.Count)
				{
					flag = true;
				}
				else
				{
					int num = list_1.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (list_1[i].GetLatitude() != list_2[i].GetLatitude() || list_1[i].GetLongitude() != list_2[i].GetLongitude())
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200566", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00114134 File Offset: 0x00112334
		public bool IsOnStation(ref List<ReferencePoint> list_1, ref List<ReferencePoint> list_2, ref List<ReferencePoint> list_3, int int_2, bool bool_14, bool bool_15)
		{
			bool flag = false;
			bool result;
			try
			{
				if (list_1.Count == 0)
				{
					flag = false;
				}
				else
				{
					bool flag2 = this.method_31(list_1, list_3);
					if (!bool_14 && !flag2)
					{
						if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3) && int_2 != 0)
						{
							if (int_2 == 1)
							{
								if (this.short_1 > 0)
								{
									flag = (result = this.bool_4);
									return result;
								}
								this.short_1 = 60;
							}
							else if (int_2 == 2)
							{
								if (this.short_2 > 0)
								{
									flag = (result = this.bool_5);
									return result;
								}
								this.short_2 = 60;
							}
							else if (int_2 == 5)
							{
								if (bool_15)
								{
									if (this.short_7 > 0)
									{
										flag = (result = this.bool_10);
										return result;
									}
									this.short_7 = 60;
								}
								else
								{
									if (this.short_3 > 0)
									{
										flag = (result = this.bool_6);
										return result;
									}
									this.short_3 = 60;
								}
							}
							else if (int_2 == 10)
							{
								if (this.short_4 > 0)
								{
									flag = (result = this.bool_7);
									return result;
								}
								this.short_4 = 60;
							}
							else
							{
								if (this.short_5 > 0)
								{
									flag = (result = this.bool_8);
									return result;
								}
								this.short_5 = 60;
							}
						}
						else if (bool_15)
						{
							if (this.short_6 > 0)
							{
								flag = (result = this.bool_9);
								return result;
							}
							this.short_6 = 60;
						}
						else
						{
							if (this.short_0 > 0)
							{
								flag = (result = this.bool_3);
								return result;
							}
							this.short_0 = 60;
						}
					}
					if ((list_1.Count > 1 && !Information.IsNothing(list_2) && list_2.Count == 0) || flag2)
					{
						this.method_35((float)int_2, ref list_1, ref list_2, ref list_3);
					}
					if (list_1.Count == 1)
					{
						if (int_2 == 0)
						{
							this.bool_3 = false;
							this.bool_9 = false;
							flag = false;
						}
						else if (int_2 == 1)
						{
							this.bool_4 = (Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= (float)int_2);
							flag = this.bool_4;
						}
						else if (int_2 == 2)
						{
							this.bool_5 = (Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= (float)int_2);
							flag = this.bool_5;
						}
						else if (int_2 == 5)
						{
							if (bool_15)
							{
								this.bool_10 = (Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= (float)int_2);
								flag = this.bool_10;
							}
							else
							{
								this.bool_6 = (Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= (float)int_2);
								flag = this.bool_6;
							}
						}
						else if (int_2 == 10)
						{
							this.bool_7 = (Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= (float)int_2);
							flag = this.bool_7;
						}
						else
						{
							this.bool_8 = (Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), list_1[0].GetLatitude(), list_1[0].GetLongitude()) <= (float)int_2);
							flag = this.bool_8;
						}
					}
					else if (list_1.Count > 1)
					{
						if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3) && int_2 != 0)
						{
							if (int_2 == 1)
							{
								this.bool_4 = this.ParentPlatform.vmethod_40(list_2.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
								flag = this.bool_4;
							}
							else if (int_2 == 2)
							{
								this.bool_5 = this.ParentPlatform.vmethod_40(list_2.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
								flag = this.bool_5;
							}
							else if (int_2 == 5)
							{
								if (bool_15)
								{
									this.bool_10 = this.ParentPlatform.vmethod_40(list_2.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
									flag = this.bool_10;
								}
								else
								{
									this.bool_6 = this.ParentPlatform.vmethod_40(list_2.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
									flag = this.bool_6;
								}
							}
							else if (int_2 == 10)
							{
								this.bool_7 = this.ParentPlatform.vmethod_40(list_2.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
								flag = this.bool_7;
							}
							else
							{
								this.bool_8 = this.ParentPlatform.vmethod_40(list_2.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
								flag = this.bool_8;
							}
						}
						else if (bool_15)
						{
							this.bool_9 = this.ParentPlatform.vmethod_40(list_1.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
							flag = this.bool_9;
						}
						else
						{
							this.bool_3 = this.ParentPlatform.vmethod_40(list_1.ToList<ReferencePoint>(), this.ParentPlatform.m_Scenario, false);
							flag = this.bool_3;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200319", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00114820 File Offset: 0x00112A20
		public bool method_34(ref List<GeoPoint> list_1, ref List<GeoPoint> list_2, ref List<GeoPoint> list_3, float float_3)
		{
			bool flag = false;
			bool result;
			if (list_1.Count == 0)
			{
				flag = false;
			}
			else
			{
				try
				{
					if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3) && float_3 != 0f)
					{
						if (list_2.Count == 0 || this.method_32(list_1, list_3))
						{
							ActiveUnit_Navigator.smethod_0(float_3, ref list_1, ref list_2, ref list_3);
						}
						flag = (result = this.ParentPlatform.vmethod_39(list_2.ToList<GeoPoint>(), this.ParentPlatform.m_Scenario, true));
						return result;
					}
					flag = this.ParentPlatform.vmethod_39(list_1.ToList<GeoPoint>(), this.ParentPlatform.m_Scenario, true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101261", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00114920 File Offset: 0x00112B20
		public void method_35(float float_3, ref List<ReferencePoint> list_1, ref List<ReferencePoint> list_2, ref List<ReferencePoint> list_3)
		{
            try
            {
                int num5;
                list_3.Clear();
                List<ReferencePoint> list = new List<ReferencePoint>();
                int count = list_1.Count;
                int num2 = 0;
                if (count > 2)
                {
                    num2 = count;
                }
                else
                {
                    num2 = count - 1;
                }
                int num3 = count - 1;
                for (int i = 0; i <= num3; i++)
                {
                    List<ReferencePoint> list3;
                    List<ReferencePoint> list2 = list;
                    ReferencePoint point = list_1[i];
                    num5 = 0;
                    ReferencePoint point2 = (list3 = list_1)[num5 = i];
                    ReferencePoint item = point.NewReferencePoint(ref point2);
                    list3[num5] = point2;
                    list2.Add(item);
                }
                list_3 = list;
                if (float_3 == 0f)
                {
                    return;
                }
                float num6 = float_3 * 1852f;
                Class258.Class259 class2 = new Class258.Class259(list_1[0].GetLatitude(), list_1[0].GetLongitude());
                if (count == 0)
                {
                    return;
                }
                Coordinate[] coordinates = new Coordinate[num2 + 1];
                num5 = count - 1;
                for (int j = 0; j <= num5; j++)
                {
                    double num8 = 0.0;
                    double num9 = 0.0;
                    if (!class2.method_1(list_1[j].GetLatitude(), list_1[j].GetLongitude(), ref num8, ref num9, false))
                    {
                        goto Label_0425;
                    }
                    coordinates[j] = new Coordinate(num8, num9);
                }
                if (count > 2)
                {
                    coordinates[count] = coordinates[0];
                }
                list_2.Clear();
                List<ReferencePoint> list4 = new List<ReferencePoint>();
                IGeometry expression = null;
                if (count > 2)
                {
                    Polygon polygon = new Polygon(new LinearRing(coordinates));
                    try
                    {
                        expression = polygon.Buffer((double)num6, 3);
                        goto Label_02E8;
                    }
                    catch (Exception exception)
                    {
                        ProjectData.SetProjectError(exception);
                        Exception exception2 = exception;
                        exception2.Data.Add("Error at 200304", exception2.Message);
                        GameGeneral.LogException(ref exception2);
                        if (Debugger.IsAttached)
                        {
                            Debugger.Break();
                        }
                        foreach (ReferencePoint point4 in list_1)
                        {
                            list4.Add(new ReferencePoint(point4.GetLongitude(), point4.GetLatitude()));
                        }
                        list_2 = list4;
                        ProjectData.ClearProjectError();
                        return;
                    }
                }
                switch (count)
                {
                    case 2:
                        {
                            LineString str = new LineString(coordinates);
                            try
                            {
                                expression = str.Buffer((double)num6, 3);
                                break;
                            }
                            catch (Exception exception3)
                            {
                                ProjectData.SetProjectError(exception3);
                                Exception exception4 = exception3;
                                exception4.Data.Add("Error at 200309", exception4.Message);
                                GameGeneral.LogException(ref exception4);
                                if (!Debugger.IsAttached)
                                {
                                }
                                ProjectData.ClearProjectError();
                                return;
                            }
                            break;
                        }
                    case 1:
                        {
                            Point point5 = new Point(coordinates[0]);
                            try
                            {
                                expression = point5.Buffer((double)num6, 3);
                            }
                            catch (Exception exception5)
                            {
                                ProjectData.SetProjectError(exception5);
                                Exception exception6 = exception5;
                                exception6.Data.Add("Error at 200310", exception6.Message);
                                GameGeneral.LogException(ref exception6);
                                if (Debugger.IsAttached)
                                {
                                    Debugger.Break();
                                }
                                ProjectData.ClearProjectError();
                                return;
                            }
                            break;
                        }
                }
            Label_02E8:
                if (Debugger.IsAttached && (Information.IsNothing(expression) || (expression.GetCoordinates().Count == 0)))
                {
                    Debugger.Break();
                }
                if (!Information.IsNothing(expression))
                {
                    int num10 = expression.GetCoordinates().Count - 2;
                    for (int k = 0; k <= num10; k++)
                    {
                        double num12 = 0.0;
                        double num13 = 0.0;
                        class2.method_6(expression.GetCoordinates()[k].X, expression.GetCoordinates()[k].Y, ref num12, ref num13);
                        if (num13 > 180.0)
                        {
                            num13 = 180.0;
                        }
                        else if (num13 < -180.0)
                        {
                            num13 = -180.0;
                        }
                        if (num12 > 90.0)
                        {
                            num12 = 90.0;
                        }
                        else if (num12 < -90.0)
                        {
                            num12 = -90.0;
                        }
                        list4.Add(new ReferencePoint(num13, num12));
                    }
                    list_2 = list4;
                }
                return;
            Label_0425:
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
            }
            catch (Exception exception7)
            {
                ProjectData.SetProjectError(exception7);
                Exception exception8 = exception7;
                exception8.Data.Add("Error at 200303", exception8.Message);
                GameGeneral.LogException(ref exception8);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }

        }

        // Token: 0x0600327B RID: 12923 RVA: 0x00114E24 File Offset: 0x00113024
        public static void smethod_0(float float_3, ref List<GeoPoint> list_1, ref List<GeoPoint> list_2, ref List<GeoPoint> list_3)
		{
			try
			{
				list_3.Clear();
				List<GeoPoint> list = new List<GeoPoint>();
				int count = list_1.Count;
				int num;
				if (count > 2)
				{
					num = count;
				}
				else
				{
					num = count - 1;
				}
				int num2 = count - 1;
				for (int i = 0; i <= num2; i++)
				{
					list.Add(list_1[i]);
				}
				list_3 = list;
				if (float_3 != 0f)
				{
					new Class258.Class259(0.0, 0.0);
					float num3 = float_3 * 1852f;
					Class258.Class259 @class = new Class258.Class259(list_1[0].GetLatitude(), list_1[0].GetLongitude());
					if (count != 0)
					{
						Coordinate[] array = new Coordinate[num + 1];
						int num4 = count - 1;
						for (int j = 0; j <= num4; j++)
						{
							double double_ = 0.0;
							double double_2 = 0.0;
							if (!@class.method_1(list_1[j].GetLatitude(), list_1[j].GetLongitude(), ref double_, ref double_2, false))
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								return;
							}
							array[j] = new Coordinate(double_, double_2);
						}
						if (count > 2)
						{
							array[count] = array[0];
						}
						list_2.Clear();
						List<GeoPoint> list2 = new List<GeoPoint>();
						IGeometry geometry = null;
						if (count > 2)
						{
							Polygon polygon = new Polygon(new LinearRing(array));
							try
							{
								geometry = polygon.Buffer((double)num3, 3);
								goto IL_2D1;
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 200305", ex2.Message);
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								foreach (GeoPoint current in list_1)
								{
									list2.Add(new GeoPoint(current.GetLongitude(), current.GetLatitude()));
								}
								list_2 = list2;
								ProjectData.ClearProjectError();
								return;
							}
						}
						if (count == 2)
						{
							LineString lineString = new LineString(array);
							try
							{
								geometry = lineString.Buffer((double)num3, 3);
								goto IL_2D1;
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ex4.Data.Add("Error at 200317", ex4.Message);
								GameGeneral.LogException(ref ex4);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
								return;
							}
						}
						if (count == 1)
						{
							Point point = new Point(array[0]);
							try
							{
								geometry = point.Buffer((double)num3, 3);
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5);
								Exception ex6 = ex5;
								ex6.Data.Add("Error at 200318", ex6.Message);
								GameGeneral.LogException(ref ex6);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
								return;
							}
						}
						IL_2D1:
						if (!Information.IsNothing(geometry))
						{
							int num5 = geometry.GetCoordinates().Count - 2;
							for (int k = 0; k <= num5; k++)
							{
								double num6 = 0.0;
								double num7 = 0.0;
								@class.method_6(geometry.GetCoordinates()[k].X, geometry.GetCoordinates()[k].Y, ref num6, ref num7);
								if (num7 > 180.0)
								{
									num7 = 180.0;
								}
								else if (num7 < -180.0)
								{
									num7 = -180.0;
								}
								if (num6 > 90.0)
								{
									num6 = 90.0;
								}
								else if (num6 < -90.0)
								{
									num6 = -90.0;
								}
								list2.Add(new GeoPoint(num7, num6));
							}
							list_2 = list2;
						}
					}
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ex8.Data.Add("Error at 200306", ex8.Message);
				GameGeneral.LogException(ref ex8);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x001152E4 File Offset: 0x001134E4
		public virtual void HeadingToTheArea(List<ReferencePoint> MissionArea)
		{
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				switch (MissionArea.Count)
				{
				case 0:
					this.ParentPlatform.DeleteMission(false, null);
					break;
				case 1:
					num = MissionArea[0].GetLatitude();
					num2 = MissionArea[0].GetLongitude();
					break;
				case 2:
				{
					List<ReferencePoint> list = MissionArea.OrderByDescending(new Func<ReferencePoint, float>(this.RangeTo)).ToList<ReferencePoint>();
					num2 = list[0].GetLongitude();
					num = list[0].GetLatitude();
					break;
				}
				default:
				{
					bool flag = false;
					short num3 = 0;
					while (!flag)
					{
						GeoPoint geoPoint = Math2.PickSuitablePointInsideArea(MissionArea);
						if (Information.IsNothing(geoPoint))
						{
							this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " is unable to pick a suitable point inside area defined by Ref. Points: " + string.Join(" - ", MissionArea.Select(ActiveUnit_Navigator.ReferencePointFunc1)), LoggedMessage.MessageType.UnitAI, 1, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
							return;
						}
						Unit parentPlatform = this.ParentPlatform;
						double latitude = geoPoint.GetLatitude();
						double longitude = geoPoint.GetLongitude();
						byte b = 0;
						bool flag2 = true;
						bool flag3 = true;
						float? nullable_ = null;
						short? nullable_2 = null;
						List<ActiveUnit> list2 = null;
						if (parentPlatform.vmethod_41(latitude, longitude, ref b, false, ref flag2, true, ref flag3, nullable_, nullable_2, ref list2, 0f, false, false))
						{
							flag = true;
							num = geoPoint.GetLatitude();
							num2 = geoPoint.GetLongitude();
						}
						num3 += 1;
					}
					break;
				}
				}
				this.ClearPlottedCourse();
				this.AddWaypoint(num, num2, Waypoint.WaypointType.PatrolStation, Waypoint._Creator.const_1, Waypoint._Category.const_0);
				this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num, num2));
				if (this.NextUpdateTime > 2f)
				{
					this.NextUpdateTime = 2f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at KJHKJHLHJBSSGY", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00115558 File Offset: 0x00113758
		public virtual void SetDesiredHeading()
		{
			try
			{
				if (!this.ParentPlatform.m_Scenario.UserIsPlottingCourse && !Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
				{
					Patrol patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
					if (!Information.IsNothing(patrol) && !Information.IsNothing(patrol.PatrolAreaVertices))
					{
						double? num = new double?(0.0);
						double? num2 = new double?(0.0);
						switch (patrol.PatrolAreaVertices.Count)
						{
						case 0:
							if (Information.IsNothing(this.GetPlottedCourse()) || this.GetPlottedCourse().Count<Waypoint>() == 0)
							{
								this.ParentPlatform.DeleteMission(false, null);
								return;
							}
							break;
						case 1:
							if (Information.IsNothing(this.GetPlottedCourse()) || this.GetPlottedCourse().Count<Waypoint>() == 0)
							{
								num = new double?(patrol.PatrolAreaVertices[0].GetLatitude());
								num2 = new double?(patrol.PatrolAreaVertices[0].GetLongitude());
							}
							break;
						case 2:
							if (Information.IsNothing(this.GetPlottedCourse()) || this.GetPlottedCourse().Count<Waypoint>() == 0)
							{
								new List<ReferencePoint>();
								ReferencePoint referencePoint = patrol.PatrolAreaVertices.OrderByDescending(new Func<ReferencePoint, double>(this.AngularDistanceTo)).ElementAtOrDefault(0);
								num2 = new double?(referencePoint.GetLongitude());
								num = new double?(referencePoint.GetLatitude());
							}
							break;
						default:
							if (Information.IsNothing(this.GetPlottedCourse()) || this.GetPlottedCourse().Count<Waypoint>() == 0)
							{
								bool flag = false;
								int num3 = 0;
								while (!flag)
								{
									num3++;
									GeoPoint geoPoint = Math2.PickSuitablePointInsideArea(patrol.PatrolAreaVertices);
									if (Information.IsNothing(geoPoint))
									{
										this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " is unable to pick a suitable point inside patrol area defined by Ref. Points: " + string.Join(" - ", patrol.PatrolAreaVertices.Select(ActiveUnit_Navigator.ReferencePointFunc2)), LoggedMessage.MessageType.UnitAI, 1, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
										return;
									}
									Unit parentPlatform = this.ParentPlatform;
									double latitude = geoPoint.GetLatitude();
									double longitude = geoPoint.GetLongitude();
									byte b = 0;
									bool flag2 = true;
									bool flag3 = true;
									float? nullable_ = null;
									short? nullable_2 = null;
									List<ActiveUnit> list = null;
									if (parentPlatform.vmethod_41(latitude, longitude, ref b, false, ref flag2, true, ref flag3, nullable_, nullable_2, ref list, 0f, false, false))
									{
										num = new double?(geoPoint.GetLatitude());
										num2 = new double?(geoPoint.GetLongitude());
										break;
									}
									if (num3 > 1000)
									{
										this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " is unable to pick a suitable point inside patrol area defined by Ref. Points: " + string.Join(" - ", patrol.PatrolAreaVertices.Select(ActiveUnit_Navigator.ReferencePointFunc3)), LoggedMessage.MessageType.UnitAI, 1, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
										return;
									}
								}
							}
							break;
						}
						if (num.HasValue && num2.HasValue)
						{
							this.ClearPlottedCourse();
							this.AddWaypoint(num.Value, num2.Value, Waypoint.WaypointType.PatrolStation, Waypoint._Creator.const_1, Waypoint._Category.const_0);
							this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), num.Value, num2.Value));
						}
						if (this.NextUpdateTime > 2f)
						{
							this.NextUpdateTime = 2f;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100221", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x001159BC File Offset: 0x00113BBC
		public bool HasPathfindingCourse()
		{
			bool result = false;
			try
			{
				result = (!Information.IsNothing(this.GetPlottedCourse()) && this.GetPlottedCourse().Count<Waypoint>() != 0 && !Information.IsNothing(this.GetPlottedCourse()[0]) && this.GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.PathfindingPoint);
			}
			catch (NullReferenceException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200031", ex2.Message);
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

		// Token: 0x0600327F RID: 12927 RVA: 0x0001B1CA File Offset: 0x000193CA
		public bool HasManualPlottedCourse()
		{
			return this.HasPlottedCourse() && this.GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.ManualPlottedCourseWaypoint;
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00115A8C File Offset: 0x00113C8C
		public bool HasWaypointOtherPathfindingPoint()
		{
			int num = this.GetPlottedCourse().Count<Waypoint>();
			bool flag;
			bool result;
			if (num == 0)
			{
				flag = false;
			}
			else
			{
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						if (this.GetPlottedCourse()[i].waypointType != Waypoint.WaypointType.PathfindingPoint)
						{
							result = true;
							return result;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200008", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x0001B1E7 File Offset: 0x000193E7
		public bool HasPlottedCourse()
		{
			return this.GetPlottedCourse().Count<Waypoint>() > 0;
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x0001B1F7 File Offset: 0x000193F7
		public bool HasFlight()
		{
			return !Information.IsNothing(this.GetFlight());
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x0001B207 File Offset: 0x00019407
		public bool HasFlightCourse()
		{
			return !Information.IsNothing(this.GetFlight()) && !Information.IsNothing(this.GetFlight().GetFlightCourse()) && this.GetFlight().GetFlightCourse().Count<Waypoint>() > 0;
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00115B40 File Offset: 0x00113D40
		public virtual void AddWaypoint(double Lon_, double Lat_, Waypoint.WaypointType waypointType_, Waypoint._Creator Creator_, Waypoint._Category Category_)
		{
			try
			{
				if (this.ParentPlatform.IsGroupLead())
				{
					this.ParentPlatform.GetParentGroup(false).GetNavigator().AddWaypoint(new Waypoint(Lat_, Lon_, waypointType_, Creator_, Category_));
				}
				else
				{
					ScenarioArrayUtil.AddWaypoint(ref this.PlottedCourse, new Waypoint(Lat_, Lon_, waypointType_, Creator_, Category_));
				}
				this.ManualPlotOverride = (waypointType_ == Waypoint.WaypointType.ManualPlottedCourseWaypoint);
				this.short_8 = 0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100222", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x0001B23E File Offset: 0x0001943E
		public void AddWaypoint(Waypoint waypoint_)
		{
			bool arg_05_0 = Debugger.IsAttached;
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().AddWaypoint(waypoint_);
			}
			else
			{
				ScenarioArrayUtil.AddWaypoint(ref this.PlottedCourse, waypoint_);
			}
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00115BF8 File Offset: 0x00113DF8
		public void method_43(int int_2, Waypoint waypoint_2)
		{
			bool arg_05_0 = Debugger.IsAttached;
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().method_43(int_2, waypoint_2);
			}
			else
			{
				List<Waypoint> list = this.PlottedCourse.ToList<Waypoint>();
				list.Insert(int_2, waypoint_2);
				this.PlottedCourse = list.ToArray();
			}
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x0001B27B File Offset: 0x0001947B
		public static void InsertWayPoint(ref Waypoint[] waypoint_2, int int_2, Waypoint waypoint_3)
		{
			bool arg_05_0 = Debugger.IsAttached;
			ScenarioArrayUtil.InsertWayPoint(ref waypoint_2, int_2, waypoint_3);
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00115C58 File Offset: 0x00113E58
		public void Localization()
		{
			try
			{
				if (!Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()))
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					if (!this.ParentPlatform.GetNavigator().HasWaypointOtherPathfindingPoint())
					{
						flag = true;
					}
					else
					{
						GeoPoint geoPoint = this.ParentPlatform.GetNavigator().GetPlottedCourse()[0];
						Contact primaryTarget;
						List<GeoPoint> uncertaintyArea = (primaryTarget = this.ParentPlatform.GetAI().GetPrimaryTarget()).GetUncertaintyArea();
						Contact primaryTarget2;
						List<GeoPoint> list_ = (primaryTarget2 = this.ParentPlatform.GetAI().GetPrimaryTarget()).method_108();
						Contact primaryTarget3;
						List<GeoPoint> list_2 = (primaryTarget3 = this.ParentPlatform.GetAI().GetPrimaryTarget()).method_110();
						bool flag4 = geoPoint.method_20(ref uncertaintyArea, ref list_, ref list_2, 5f);
						primaryTarget3.method_111(list_2);
						primaryTarget2.method_109(list_);
						primaryTarget.SetUncertaintyArea(uncertaintyArea);
						if (!flag4)
						{
							this.ClearPlottedCourse();
							flag = true;
						}
					}
					if (flag)
					{
						GeoPoint geoPoint2 = new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null));
						int num = 0;
						List<ActiveUnit> list;
						string text;
						do
						{
							geoPoint2 = Math2.smethod_14(this.ParentPlatform.GetAI().GetPrimaryTarget().GetUncertaintyArea(), this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), true);
							double latitude = geoPoint2.GetLatitude();
							double longitude = geoPoint2.GetLongitude();
							byte b = 0;
							bool flag5 = true;
							bool flag6 = true;
							float? nullable_ = null;
							short? nullable_2 = null;
							list = null;
							if (this.ParentPlatform.vmethod_41(latitude, longitude, ref b, false, ref flag5, true, ref flag6, nullable_, nullable_2, ref list, 0f, true, false))
							{
								if (Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()))
								{
									break;
								}
								if (!this.ParentPlatform.GetAI().GetPrimaryTarget().IsSubSurface() && !this.ParentPlatform.GetAI().GetPrimaryTarget().IsSurfaceOrLandTarget())
								{
									if (!this.ParentPlatform.GetAI().GetPrimaryTarget().IsFacilityType() || !geoPoint2.IsUnderSurface())
									{
										break;
									}
									flag3 = true;
								}
								else
								{
									if (!geoPoint2.IsAboveSurface())
									{
										break;
									}
									flag2 = true;
								}
							}
							else
							{
								text = "";
								if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
								{
									text = " (" + this.ParentPlatform.UnitClass + ")";
								}
								if (flag2)
								{
									goto IL_2C8;
								}
								if (flag3)
								{
									goto IL_33C;
								}
								if (num == 10)
								{
									goto IL_3B0;
								}
							}
							num++;
						}
						while (num <= 10);
						goto IL_50C;
						IL_2C8:
						this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
						{
							this.ParentPlatform.Name,
							text,
							" is trying to plot a localization course to pinpoint contact ",
							this.ParentPlatform.GetAI().GetPrimaryTarget().Name,
							", however the target is a naval type and the search area is overland! The built-in navigator could not find a suitable spot to start searching."
						}), LoggedMessage.MessageType.AirOps, 0, null, this.ParentPlatform.GetSide(false), null);
						return;
						IL_33C:
						this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
						{
							this.ParentPlatform.Name,
							text,
							" is trying to plot a localization course to pinpoint contact ",
							this.ParentPlatform.GetAI().GetPrimaryTarget().Name,
							", however the target is a ground (facility) type and the search area is at sea! The built-in navigator could not find a suitable spot to start searching."
						}), LoggedMessage.MessageType.AirOps, 0, null, this.ParentPlatform.GetSide(false), null);
						return;
						IL_3B0:
						ActiveUnit_Navigator navigator = this.ParentPlatform.GetNavigator();
						double latitude2 = geoPoint2.GetLatitude();
						double longitude2 = geoPoint2.GetLongitude();
						float float_ = 0f;
						list = null;
						double latitude3 = 0.0;
						double longitude3 = 0.0;
						if (!navigator.method_7(latitude2, longitude2, ref latitude3, ref longitude3, float_, ref list, true))
						{
							this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
							{
								"飞机 ",
								this.ParentPlatform.Name,
								text,
								" is trying to plot a localization course to pinpoint contact ",
								this.ParentPlatform.GetAI().GetPrimaryTarget().Name,
								", however the uncertainty area is in a No-Navigation Zone or some other location where the aircraft is not allowed to go! The built-in navigator could not find a suitable spot to start searching."
							}), LoggedMessage.MessageType.AirOps, 0, null, this.ParentPlatform.GetSide(false), null);
							return;
						}
						geoPoint2.SetLatitude(latitude3);
						geoPoint2.SetLongitude(longitude3);
						this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
						{
							"飞机 ",
							this.ParentPlatform.Name,
							text,
							" is trying to plot a localization course to pinpoint contact ",
							this.ParentPlatform.GetAI().GetPrimaryTarget().Name,
							", however the uncertainty area is in a No-Navigation Zone or some other location where the aircraft is not allowed to go! A new course has been plotted as close as the built-in navigator can take the aircraft."
						}), LoggedMessage.MessageType.AirOps, 0, null, this.ParentPlatform.GetSide(false), null);
						IL_50C:
						Waypoint waypoint = new Waypoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude(), Waypoint.WaypointType.LocalizationRun, Waypoint._Creator.const_1, Waypoint._Category.const_0);
						waypoint.SetAltitude(this.ParentPlatform.GetCurrentAltitude_ASL(false));
						this.ParentPlatform.GetNavigator().AddWaypoint(waypoint);
						Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.ParentPlatform.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false);
						byte? b2 = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
						if ((b2.HasValue ? new bool?(b2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							this.ParentPlatform.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
							string str = "";
							if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
							{
								str = " (" + this.ParentPlatform.UnitClass + ")";
							}
							this.ParentPlatform.LogMessage(this.ParentPlatform.Name + str + " changed its 'Ignore Plotted Course' doctrine setting from 'Yes' to 'No' (Reason: Need to follow localization course when trying to locate target).", LoggedMessage.MessageType.UnitAI, 5, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100394", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00116358 File Offset: 0x00114558
		public void RemoveWaypoint(Waypoint waypoint_2, bool bool_14)
		{
			if (this.ParentPlatform.IsGroupLead())
			{
				this.ParentPlatform.GetParentGroup(false).GetNavigator().RemoveWaypoint(waypoint_2, bool_14);
			}
			else
			{
				if (bool_14)
				{
					ActiveUnit_Navigator.smethod_3(ref waypoint_2);
				}
				ScenarioArrayUtil.RemoveWaypoint(ref this.PlottedCourse, waypoint_2);
			}
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x001163A8 File Offset: 0x001145A8
		public static void smethod_2(Scenario scenario_0, Mission mission_0, Mission.Flight class168_1, ref Waypoint[] waypoint_2, Waypoint waypoint_3)
		{
			ActiveUnit_Navigator.smethod_3(ref waypoint_3);
			ScenarioArrayUtil.RemoveWaypoint(ref waypoint_2, waypoint_3);
			Mission.Enum60 @enum;
			if (mission_0.MissionClass == Mission._MissionClass.Strike)
			{
				@enum = ((Strike)mission_0).Bingo;
			}
			else
			{
				@enum = Mission.Enum60.const_0;
			}
			ActiveUnit referenceUnit = class168_1.GetReferenceUnit(scenario_0);
			Mission.Enum60 bingo_ = @enum;
			float num = 0f;
			StrikePlanner.smethod_8(scenario_0, mission_0, referenceUnit, class168_1, ref waypoint_2, bingo_, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00116434 File Offset: 0x00114634
		private static void smethod_3(ref Waypoint waypoint_2)
		{
			if (!Information.IsNothing(waypoint_2.WP_LeadElementWingman))
			{
				waypoint_2.WP_LeadElementWingman = null;
			}
			if (!Information.IsNothing(waypoint_2.WP_SecondElement))
			{
				waypoint_2.WP_SecondElement = null;
			}
			if (!Information.IsNothing(waypoint_2.WP_SecondElementWingman))
			{
				waypoint_2.WP_SecondElementWingman = null;
			}
			if (!Information.IsNothing(waypoint_2.WP_ThirdElement))
			{
				waypoint_2.WP_ThirdElement = null;
			}
			if (!Information.IsNothing(waypoint_2.WP_ThirdElementWingman))
			{
				waypoint_2.WP_ThirdElementWingman = null;
			}
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x001164B0 File Offset: 0x001146B0
		public void FollowGroupLead()
		{
			try
			{
				if (!Information.IsNothing(this.ParentPlatform.GetParentGroup(false)) && !this.ParentPlatform.IsGroupLead())
				{
					ActiveUnit groupLead = this.ParentPlatform.GetParentGroup(false).GetGroupLead();
					float azimuth = Math2.GetAzimuth(groupLead.GetLatitude(null), groupLead.GetLongitude(null), this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
					if (this.GetFormationStation().BearingType == ReferencePoint.OrientationType.Rotating)
					{
						this.GetFormationStation().Bearing = Class263.GetAngleBetween(groupLead.GetCurrentHeading(), azimuth);
					}
					else
					{
						this.GetFormationStation().Bearing = azimuth;
					}
					this.GetFormationStation().Distance = this.ParentPlatform.GetHorizontalRange(groupLead);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100223", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x001165E0 File Offset: 0x001147E0
		public void method_46(double double_0, double double_1, bool bool_14)
		{
			try
			{
				if (!Information.IsNothing(this.ParentPlatform.GetParentGroup(false)) && !this.ParentPlatform.IsGroupLead())
				{
					ActiveUnit groupLead = this.ParentPlatform.GetParentGroup(false).GetGroupLead();
					if (!Information.IsNothing(groupLead) && (bool_14 || (this.GetFormationStation().Bearing == 0f && this.GetFormationStation().Distance == 0f)))
					{
						float azimuth = Math2.GetAzimuth(groupLead.GetLatitude(null), groupLead.GetLongitude(null), double_1, double_0);
						if (this.GetFormationStation().BearingType == ReferencePoint.OrientationType.Rotating)
						{
							this.GetFormationStation().Bearing = Class263.GetAngleBetween(groupLead.GetCurrentHeading(), azimuth);
						}
						else
						{
							this.GetFormationStation().Bearing = azimuth;
						}
						this.GetFormationStation().Distance = Math2.GetDistance(groupLead.GetLatitude(null), groupLead.GetLongitude(null), double_1, double_0);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100224", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00116750 File Offset: 0x00114950
		public static double? smethod_4(double Latitude, double Longitude, double Heading, Unit PrimaryTargetUnit, float AverageSpeed)
		{
			double? num = new double?(0.0);
			double? result;
			try
			{
				if (Information.IsNothing(PrimaryTargetUnit))
				{
					num = null;
				}
				else if (!double.IsInfinity(PrimaryTargetUnit.GetLatitude(null)) && !double.IsInfinity(PrimaryTargetUnit.GetLongitude(null)))
				{
					if (PrimaryTargetUnit.GetCurrentSpeed() == 0f)
					{
						num = new double?((double)Math2.GetAzimuth(Latitude, Longitude, PrimaryTargetUnit.GetLatitude(null), PrimaryTargetUnit.GetLongitude(null)));
					}
					else
					{
						double targetX = 0.0;
						double targetY = 0.0;
						try
						{
							if (!new Class258.Class259(Latitude, Longitude).method_1(PrimaryTargetUnit.GetLatitude(null), PrimaryTargetUnit.GetLongitude(null), ref targetX, ref targetY, false))
							{
								num = null;
								result = num;
								return result;
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200009", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							num = null;
							ProjectData.ClearProjectError();
							result = num;
							return result;
						}
						double? num2 = ActiveUnit_Navigator.smethod_5(0.0, 0.0, Heading, targetX, targetY, (double)PrimaryTargetUnit.GetCurrentHeading(), (double)PrimaryTargetUnit.GetCurrentSpeed(), (double)AverageSpeed, true);
						if (num2.HasValue)
						{
							num = new double?(Math2.Normalize(num2.Value));
						}
						else
						{
							num = num2;
						}
					}
				}
				else
				{
					num = null;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100225", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00116978 File Offset: 0x00114B78
		private static double? smethod_5(double StartX, double StartY, double StartHeading, double TargetX, double TargetY, double TargetHeading, double TargetVelocity, double InterceptVelocity, bool InDegrees = true)
		{
			double? result = new double?(0.0);
			try
			{
				int num = 1;
				if (InDegrees)
				{
					StartHeading = StartHeading * 3.14159265358979 / 180.0;
					TargetHeading = TargetHeading * 3.14159265358979 / 180.0;
				}
				double num2 = Math.Atan2(TargetX - StartX, TargetY - StartY);
				double num3 = StartHeading - num2;
				double num4 = TargetHeading - num2;
				double num5 = (double)num * Math.Sin(num3);
				double num6 = (double)num * Math.Cos(num3);
				double num7 = TargetVelocity * Math.Sin(num4);
				double num8 = TargetVelocity * Math.Cos(num4);
				double num9 = Math.Asin((num7 - num5) / InterceptVelocity);
				double num10 = Math.Cos(num9) * InterceptVelocity;
				if (!double.IsNaN(num9) && num8 - num6 < num10)
				{
					double? num11 = new double?(InDegrees ? ((num9 + num2) * 180.0 / 3.14159265358979) : (num9 + num2));
					num11 = new double?(Math2.Normalize(num11.Value));
					result = num11;
				}
				else
				{
					double? num11 = new double?(0.0);
					result = num11;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100226", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00116B00 File Offset: 0x00114D00
		private bool method_47(double double_0, double double_1, double double_2, double double_3)
		{
			bool result = false;
			try
			{
				string text = Terrain.smethod_3(double_0, double_1);
				string text2 = Terrain.smethod_3(double_2, double_3);
				if (Operators.CompareString(text, text2, false) != 0)
				{
					result = false;
				}
				else
				{
					Tuple<int, int> tuple = Terrain.dictionary_0[text][0].method_0(double_1, double_0);
					int item = tuple.Item1;
					int item2 = tuple.Item2;
					Tuple<int, int> tuple2 = Terrain.dictionary_0[text2][0].method_0(double_3, double_2);
					int item3 = tuple2.Item1;
					int item4 = tuple2.Item2;
					result = ((item == item3 && item2 == item4) || (Math.Abs(item - item3) < 2 && Math.Abs(item2 - item4) < 2));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100227", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00116C20 File Offset: 0x00114E20
		private void method_48(List<Waypoint> list_1, bool bool_14, float float_3, ref bool bool_15, ref Mission.Flight class168_1, ref bool bool_16)
		{
			if (!Information.IsNothing(list_1))
			{
				int count = list_1.Count;
				if (list_1.Count <= 2)
				{
					bool_15 = true;
				}
				else
				{
					float float_4 = 0f;
					if (float_3 > 0f)
					{
						float_4 = 0.15f;
					}
					else
					{
						float_4 = 0f;
					}
					double num = 0.0;
					double num2 = 0.0;
					if (!Information.IsNothing(class168_1) && !bool_16 && !Information.IsNothing(class168_1.PrimaryTarget))
					{
						num = class168_1.PrimaryTarget.GetLatitude(null);
						num2 = class168_1.PrimaryTarget.GetLongitude(null);
					}
					else
					{
						num = this.ParentPlatform.GetLatitude(null);
						num2 = this.ParentPlatform.GetLongitude(null);
					}
					try
					{
						IL_2B4:
						while (!bool_15)
						{
							bool_15 = true;
							Waypoint waypoint = null;
							count = list_1.Count;
							int value = this.ParentPlatform.GetNavigator().int_1;
							int num3 = count - 1;
							int i = 0;
							while (i <= num3)
							{
								Waypoint waypoint2;
								try
								{
									waypoint2 = list_1[i];
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200427", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
									i++;
									continue;
								}
								if (waypoint2.waypointType != Waypoint.WaypointType.PathfindingPoint)
								{
									i++;
								}
								else
								{
									int num4 = list_1.IndexOf(waypoint2);
									if (num4 >= count - 1)
									{
										i++;
									}
									else
									{
										Waypoint waypoint3 = list_1[num4 + 1];
										if (num4 == 0)
										{
											if (!this.method_47(num, num2, waypoint3.GetLatitude(), waypoint3.GetLongitude()))
											{
												if (this.vmethod_16(num, num2, waypoint3.GetLatitude(), waypoint3.GetLongitude(), true, float_4, false, new int?(value)))
												{
													i++;
													continue;
												}
												waypoint = waypoint2;
											}
											else
											{
												waypoint = waypoint2;
											}
										}
										else
										{
											Waypoint waypoint4 = list_1[num4 - 1];
											if (!this.method_47(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude()))
											{
												if (this.vmethod_16(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude(), true, float_4, false, new int?(value)))
												{
													i++;
													continue;
												}
												waypoint = waypoint2;
											}
											else
											{
												waypoint = waypoint2;
											}
										}
										if (!Information.IsNothing(waypoint))
										{
											list_1.Remove(waypoint);
											bool_15 = false;
											goto IL_2B4;
										}
										goto IL_2B4;
									}
								}
							}
							if (!Information.IsNothing(waypoint))
							{
								list_1.Remove(waypoint);
								bool_15 = false;
							}
						}
						if (bool_14)
						{
							bool_15 = false;
							IL_443:
							while (!bool_15)
							{
								bool_15 = true;
								Waypoint waypoint5 = null;
								count = list_1.Count;
								int value2 = this.ParentPlatform.GetNavigator().int_1;
								for (int j = count - 1; j >= 0; j += -1)
								{
									Waypoint waypoint2 = list_1[j];
									if (waypoint2.waypointType == Waypoint.WaypointType.PathfindingPoint)
									{
										int num5 = list_1.IndexOf(waypoint2);
										if (num5 < count - 1)
										{
											Waypoint waypoint6 = list_1[num5 + 1];
											if (num5 == 0)
											{
												if (!this.method_47(num, num2, waypoint6.GetLatitude(), waypoint6.GetLongitude()))
												{
													if (this.vmethod_16(num, num2, waypoint6.GetLatitude(), waypoint6.GetLongitude(), true, float_4, false, new int?(value2)))
													{
														goto IL_3EC;
													}
													waypoint5 = waypoint2;
												}
												else
												{
													waypoint5 = waypoint2;
												}
											}
											else
											{
												Waypoint waypoint7 = list_1[num5 - 1];
												if (!this.method_47(waypoint6.GetLatitude(), waypoint6.GetLongitude(), waypoint7.GetLatitude(), waypoint7.GetLongitude()))
												{
													if (this.vmethod_16(waypoint6.GetLatitude(), waypoint6.GetLongitude(), waypoint7.GetLatitude(), waypoint7.GetLongitude(), true, float_4, false, new int?(value2)))
													{
														goto IL_3EC;
													}
													waypoint5 = waypoint2;
												}
												else
												{
													waypoint5 = waypoint2;
												}
											}
											if (!Information.IsNothing(waypoint5))
											{
												list_1.Remove(waypoint5);
												bool_15 = false;
												goto IL_443;
											}
											goto IL_443;
										}
									}
									IL_3EC:;
								}
								if (!Information.IsNothing(waypoint5))
								{
									list_1.Remove(waypoint5);
									bool_15 = false;
								}
							}
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 100228", "");
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

		// Token: 0x06003292 RID: 12946 RVA: 0x001170F4 File Offset: 0x001152F4
		protected List<Waypoint> method_49(double Latitude1, double Longitude1, double Latitude2, double Longitude2, float float_3, bool bool_14, float float_4, ref List<ActiveUnit> list_1)
		{
			List<Waypoint> list = new List<Waypoint>();
			List<Waypoint> list2 = null;
			List<Waypoint> result;
			try
			{
				if (bool_14 && Class324.interface2_0.GetType() == typeof(Class358))
				{
					float float_5;
					if (float_4 > 0f)
					{
						float_5 = 15f;
					}
					else
					{
						float_5 = 5f;
					}
					GeoPoint geoPoint = this.method_51(Latitude1, Longitude1, Latitude2, Longitude2, float_5, null, float_4, ref list_1);
					GeoPoint geoPoint2 = this.method_51(Latitude2, Longitude2, Latitude1, Longitude1, float_5, null, float_4, ref list_1);
					if (!Information.IsNothing(geoPoint) && !Information.IsNothing(geoPoint2))
					{
						list = this.method_49(geoPoint.GetLatitude(), geoPoint.GetLongitude(), geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), float_3, false, float_4, ref list_1);
						if (!Information.IsNothing(list))
						{
							list.Insert(0, new Waypoint(Longitude1, Latitude1, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
							if (this.ParentPlatform.IsAircraft)
							{
								list.Add(new Waypoint(Longitude2, Latitude2, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
							}
							else
							{
								Unit parentPlatform = this.ParentPlatform;
								byte b = 0;
								bool flag = true;
								bool flag2 = true;
								if (parentPlatform.vmethod_41(Latitude2, Longitude2, ref b, true, ref flag, true, ref flag2, null, null, ref list_1, float_4, false, false) && !this.ParentPlatform.GetNavigator().vmethod_16(Latitude2, Longitude2, list[list.Count - 1].GetLatitude(), list[list.Count - 1].GetLongitude(), false, 0f, true, null))
								{
									list.Add(new Waypoint(Longitude2, Latitude2, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
								}
							}
						}
						list2 = list;
					}
					else
					{
						list2 = list;
					}
				}
				else
				{
					if (this.ParentPlatform.IsAircraft || Math2.GetDistance(Latitude1, Longitude1, Latitude2, Longitude2) >= this.ParentPlatform.m_Scenario.Navigation_FinegrainedMaxDistance)
					{
						float num = 2f;
						float num2 = 1f;
						while (!this.ParentPlatform.m_Scenario.ThreadedOpsMustStop)
						{
							list = Class324.interface2_0.imethod_3(this.ParentPlatform, Latitude1, Longitude1, Latitude2, Longitude2, float_3, num, float_4, ref list_1, ref this.float_1);
							if (!Information.IsNothing(list))
							{
								goto IL_300;
							}
							if (num == 2f)
							{
								num = 5f;
							}
							else if (num == 5f)
							{
								num = 20f;
							}
							else if (num == 20f)
							{
								goto IL_300;
							}
							num2 += 1f;
							if (num2 > 3f)
							{
								goto IL_300;
							}
						}
						this.bool_2 = false;
						list2 = null;
						result = list2;
						return result;
					}
					if (this.ParentPlatform.m_Scenario.ThreadedOpsMustStop)
					{
						this.bool_2 = false;
						list2 = null;
						result = list2;
						return result;
					}
					list = Class324.interface2_0.imethod_2(this.ParentPlatform, Latitude1, Longitude1, Latitude2, Longitude2, float_3, this.ParentPlatform.m_Scenario.Navigation_FinegrainedThresholdDistance, float_4, ref list_1, ref this.float_1);
					IL_300:
					list2 = list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100229", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = list2;
			return result;
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00117468 File Offset: 0x00115668
		private List<GeoPoint> method_50(double double_0, double double_1, double double_2, double double_3, double double_4, float float_3, float float_4, ref List<ActiveUnit> list_1)
		{
			List<GeoPoint> list = null;
			List<GeoPoint> result;
			try
			{
				List<GeoPoint> list2 = new List<GeoPoint>();
				float val;
				float num = val = (float)(double_4 / 100.0);
				float num2 = (float)double_4;
				float num3 = Math.Max(val, 1f);
				bool flag = num3 >= 0f;
				float num4 = num;
				IL_198:
				while (flag ? (num4 <= num2) : (num4 >= num2))
				{
					short num5 = 180;
					while (!this.ParentPlatform.m_Scenario.ThreadedOpsMustStop)
					{
						double num6 = 0.0;
						double num7 = 0.0;
						GeoPointGenerator.GetOtherGeoPoint(double_2, double_3, ref num6, ref num7, (double)num4, (double)(float_3 + (float)num5));
						Unit parentPlatform = this.ParentPlatform;
						double lat_ = num6;
						double lon_ = num7;
						byte b = 0;
						bool flag2 = true;
						bool flag3 = true;
						if (parentPlatform.vmethod_41(lat_, lon_, ref b, true, ref flag2, true, ref flag3, null, null, ref list_1, float_4, true, false))
						{
							list2.Add(new GeoPoint(num7, num6));
						}
						GeoPointGenerator.GetOtherGeoPoint(double_2, double_3, ref num6, ref num7, (double)num4, (double)(float_3 - (float)num5));
						Unit parentPlatform2 = this.ParentPlatform;
						double lat_2 = num6;
						double lon_2 = num7;
						b = 0;
						flag3 = true;
						flag2 = true;
						if (parentPlatform2.vmethod_41(lat_2, lon_2, ref b, true, ref flag3, true, ref flag2, null, null, ref list_1, float_4, true, false))
						{
							list2.Add(new GeoPoint(num7, num6));
						}
						num5 += -1;
						if (num5 < 0)
						{
							num4 += num3;
							goto IL_198;
						}
					}
					result = list;
					return result;
				}
				list = list2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100230", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = list;
			return result;
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00117680 File Offset: 0x00115880
		protected virtual void vmethod_15(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight Flight_, bool bool_14, float float_3, double double_0, double double_1, bool bool_15)
		{
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				float float_4 = 0f;
				if (Information.IsNothing(waypoint_2))
				{
					if (!Information.IsNothing(activeUnit_1))
					{
						num = activeUnit_1.GetLatitude(null);
						num2 = activeUnit_1.GetLongitude(null);
						float_4 = activeUnit_1.GetCurrentHeading();
					}
					else if (!Information.IsNothing(Flight_))
					{
						if (bool_14)
						{
							num = Flight_.GetReferenceUnit(null).GetLatitude(null);
							num2 = Flight_.GetReferenceUnit(null).GetLongitude(null);
							float_4 = Flight_.GetReferenceUnit(null).GetCurrentHeading();
						}
						else if (!Information.IsNothing(Flight_.PrimaryTarget))
						{
							num = Flight_.PrimaryTarget.GetLatitude(null);
							num2 = Flight_.PrimaryTarget.GetLongitude(null);
							float_4 = Math2.GetAzimuth(num, num2, double_0, double_1);
						}
						else
						{
							num = Flight_.GetReferenceUnit(null).GetLatitude(null);
							num2 = Flight_.GetReferenceUnit(null).GetLongitude(null);
							float_4 = Flight_.GetReferenceUnit(null).GetCurrentHeading();
						}
					}
				}
				else
				{
					num = waypoint_2.GetLatitude();
					num2 = waypoint_2.GetLongitude();
					float_4 = Math2.GetAzimuth(num, num2, double_0, double_1);
				}
				List<ActiveUnit> list = null;
				if (!Information.IsNothing(activeUnit_1) && float_3 == 0.15f)
				{
					Unit parentPlatform = this.ParentPlatform;
					double lat_ = num;
					double lon_ = num2;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					if (!parentPlatform.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, new float?(0f), null, ref list, float_3, bool_15, false) && !this.method_7(num, num2, ref num, ref num2, float_3, ref list, bool_15))
					{
						return;
					}
					Unit parentPlatform2 = this.ParentPlatform;
					double lat_2 = double_0;
					double lon_2 = double_1;
					b = 0;
					flag2 = true;
					flag = true;
					if (!parentPlatform2.vmethod_41(lat_2, lon_2, ref b, true, ref flag2, true, ref flag, new float?(0f), null, ref list, float_3, bool_15, false) && !this.method_7(double_0, double_1, ref double_0, ref double_1, float_3, ref list, bool_15))
					{
						return;
					}
				}
				if (!Information.IsNothing(activeUnit_1))
				{
					double lat_3 = double_0;
					double lon_3 = double_1;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					if (activeUnit_1.vmethod_41(lat_3, lon_3, ref b, true, ref flag, true, ref flag2, null, null, ref list, float_3, false, false))
					{
						activeUnit_1.GetAI().geoPoint_1 = new GeoPoint(double_1, double_0);
						List<Waypoint> list2 = this.method_49(num, num2, double_0, double_1, float_4, true, float_3, ref list);
						if (!Information.IsNothing(list2) && list2.Count == 0)
						{
							return;
						}
						this.list_0 = list2;
						goto IL_494;
					}
				}
				if (!Information.IsNothing(Flight_) && !Information.IsNothing(Flight_.GetReferenceUnit(null)))
				{
					Unit referenceUnit = Flight_.GetReferenceUnit(null);
					double lat_4 = double_0;
					double lon_4 = double_1;
					byte b = 0;
					bool flag2 = true;
					bool flag = true;
					if (referenceUnit.vmethod_41(lat_4, lon_4, ref b, true, ref flag2, true, ref flag, null, null, ref list, float_3, false, false))
					{
						List<Waypoint> list2 = Flight_.GetReferenceUnit(null).GetNavigator().method_49(num, num2, double_0, double_1, float_4, true, float_3, ref list);
						if (!Information.IsNothing(list2) && list2.Count == 0)
						{
							return;
						}
						this.list_0 = list2;
						goto IL_494;
					}
				}
				try
				{
					double num3 = (double)Math2.GetDistance(num, num2, double_0, double_1);
					double num4 = Math2.ApproxAngularDistance(num, num2, double_0, double_1);
					if (num3 > 0.0)
					{
						List<GeoPoint> list3 = this.method_50(num, num2, double_0, double_1, num3, float_4, float_3, ref list);
						foreach (GeoPoint current in list3)
						{
							if (current.GetApproxAngularDistance(double_1, double_0) <= num4)
							{
								if (!Information.IsNothing(activeUnit_1))
								{
									activeUnit_1.GetAI().geoPoint_1 = current;
								}
								List<Waypoint> list2 = this.method_49(num, num2, current.GetLatitude(), current.GetLongitude(), float_4, true, float_3, ref list);
								if (!Information.IsNothing(list2))
								{
									this.list_0 = list2;
									break;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200010", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				IL_494:;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100231", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00117BB0 File Offset: 0x00115DB0
		public GeoPoint method_51(double lat1, double lon1, double lat2, double lon2, float float_3, int? nullable_0, float float_4, ref List<ActiveUnit> list_1)
		{
			GeoPoint geoPoint = null;
			GeoPoint result;
			try
			{
				double lat3 = lat1;
				double lon3 = lon1;
				float distance = Math2.GetDistance(lat1, lon1, lat2, lon2);
				if (!float.IsNaN(distance) && distance != 0f)
				{
					float num;
					if (!this.ParentPlatform.IsAircraft)
					{
						if (distance < this.ParentPlatform.m_Scenario.Navigation_FinegrainedMaxDistance)
						{
							num = Class324.interface2_0.imethod_1();
						}
						else
						{
							num = Class324.interface2_0.imethod_0();
						}
					}
					else
					{
						num = Class324.interface2_0.imethod_0();
					}
					Angle angle = default(Angle);
					angle.SetDegrees(lon1);
					Angle angle2 = default(Angle);
					angle2.SetDegrees(lat1);
					Angle angle3 = default(Angle);
					angle3.SetDegrees(lon2);
					Angle angle4 = default(Angle);
					angle4.SetDegrees(lat2);
					Angle angle5 = default(Angle);
					Angle angle6 = default(Angle);
					Angle d = World.ApproxAngularDistance(angle2, angle, angle4, angle3);
					float num2 = (float)d.GetDegrees();
					if (num2 < num * 2f)
					{
						geoPoint = null;
						result = geoPoint;
						return result;
					}
					int num3 = (int)Math.Round((double)(num2 / num));
					for (int i = 1; i <= num3; i++)
					{
						World.IntermediateGCPoint(num * (float)i / num2, angle2, angle, angle4, angle3, d, out angle6, out angle5);
						double degrees = angle6.GetDegrees();
						double degrees2 = angle5.GetDegrees();
						bool arg_14B_0 = Debugger.IsAttached;
						Unit parentPlatform = this.ParentPlatform;
						double lat_ = degrees;
						double lon_ = degrees2;
						byte b = 0;
						bool flag = true;
						bool flag2 = true;
						if (!parentPlatform.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, nullable_0.HasValue ? new float?((float)nullable_0.GetValueOrDefault()) : null, null, ref list_1, float_4, false, false))
						{
							break;
						}
						lat3 = degrees;
						lon3 = degrees2;
					}
					float distance2 = Math2.GetDistance(lat1, lon1, lat3, lon3);
					float num4;
					if (distance2 > float_3)
					{
						num4 = distance2 - float_3;
					}
					else
					{
						num4 = (float)((double)distance2 * 0.2);
					}
					float azimuth = Math2.GetAzimuth(lat1, lon1, lat2, lon2);
					double double_ = 0.0;
					double double_2 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(lon1, lat1, ref double_, ref double_2, (double)num4, (double)azimuth);
					geoPoint = new GeoPoint(double_, double_2);
					result = geoPoint;
					return result;
				}
				else
				{
					geoPoint = null;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100232", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = geoPoint;
			return result;
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00117E60 File Offset: 0x00116060
		public bool method_52(double double_0, double double_1, double double_2, double double_3, float float_3)
		{
			Tuple<double, double> tuple_ = new Tuple<double, double>(Class263.ToRadians(double_0), Class263.ToRadians(double_1));
			Tuple<double, double> tuple_2 = new Tuple<double, double>(Class263.ToRadians(double_2), Class263.ToRadians(double_3));
			double num = Math.Min(Class263.ToRadians(double_0), Class263.ToRadians(double_2));
			double num2 = Math.Max(Class263.ToRadians(double_0), Class263.ToRadians(double_2));
			double num3 = Math.Min(Class263.ToRadians(double_1), Class263.ToRadians(double_3));
			double num4 = Math.Max(Class263.ToRadians(double_1), Class263.ToRadians(double_3));
			bool result;
			foreach (NoNavZone current in this.ParentPlatform.GetSide(false).NoNavZoneList)
			{
				if (current.Area.Count != 0 && current.IsAffected(this.ParentPlatform))
				{
					List<Tuple<Tuple<double, double>, Tuple<double, double>>> list;
					if (float_3 == 0.2f)
					{
						if (current.list_3.Count == 0 || current.method_16(current.list_1))
						{
							current.method_12(float_3, ref current.list_3, ref current.list_1);
						}
						list = current.list_3.Take(current.list_3.Count - 1).Zip(current.list_3.Skip(1), ActiveUnit_Navigator.GeoPointFunc1).ToList<Tuple<Tuple<double, double>, Tuple<double, double>>>();
						if (list.Count > 0)
						{
							list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(list.Last<Tuple<Tuple<double, double>, Tuple<double, double>>>().Item2, list.First<Tuple<Tuple<double, double>, Tuple<double, double>>>().Item1));
						}
					}
					else if (float_3 == 0.15f)
					{
						if (current.list_4.Count == 0 || current.method_16(current.list_2))
						{
							current.method_12(float_3, ref current.list_4, ref current.list_2);
						}
						list = current.list_4.Take(current.list_4.Count - 1).Zip(current.list_4.Skip(1), ActiveUnit_Navigator.GeoPointFunc2).ToList<Tuple<Tuple<double, double>, Tuple<double, double>>>();
						if (list.Count > 0)
						{
							list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(list.Last<Tuple<Tuple<double, double>, Tuple<double, double>>>().Item2, list.First<Tuple<Tuple<double, double>, Tuple<double, double>>>().Item1));
						}
					}
					else
					{
						list = current.Area.Take(current.Area.Count - 1).Zip(current.Area.Skip(1), ActiveUnit_Navigator.ReferencePointFunc4).ToList<Tuple<Tuple<double, double>, Tuple<double, double>>>();
						list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(list.Last<Tuple<Tuple<double, double>, Tuple<double, double>>>().Item2, list.First<Tuple<Tuple<double, double>, Tuple<double, double>>>().Item1));
					}
					foreach (Tuple<Tuple<double, double>, Tuple<double, double>> current2 in list)
					{
						Tuple<double, double> tuple = Math2.smethod_25(tuple_, tuple_2, current2.Item1, current2.Item2);
						if (!Information.IsNothing(tuple))
						{
							double num5 = Math.Min(current2.Item1.Item1, current2.Item2.Item1);
							double num6 = Math.Max(current2.Item1.Item1, current2.Item2.Item1);
							double num7 = Math.Min(current2.Item1.Item2, current2.Item2.Item2);
							double num8 = Math.Max(current2.Item1.Item2, current2.Item2.Item2);
							if (tuple.Item1 < num2 && tuple.Item1 > num && tuple.Item2 < num4 && tuple.Item2 > num3 && tuple.Item1 < num6 && tuple.Item1 > num5 && tuple.Item2 < num8 && tuple.Item2 > num7)
							{
								result = true;
								return result;
							}
						}
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0011828C File Offset: 0x0011648C
		public virtual  bool vmethod_16(double Latitude_, double Longitude_, double TargetLatitude_, double TargetLongitude_, bool bool_14, float float_3, bool bool_15, int? nullable_0)
		{
			bool flag = false;
			bool result;
			try
			{
				if (bool_15)
				{
					bool flag2 = false;
					Unit parentPlatform = this.ParentPlatform;
					double latitude = this.ParentPlatform.GetLatitude(null);
					double longitude = this.ParentPlatform.GetLongitude(null);
					byte b = 0;
					bool flag3 = false;
					float? nullable_ = new float?(0f);
					short? nullable_2 = null;
					List<ActiveUnit> list = null;
					if (!parentPlatform.vmethod_41(latitude, longitude, ref b, true, ref flag3, false, ref flag2, nullable_, nullable_2, ref list, 0f, false, false))
					{
						flag = false;
						result = false;
						return result;
					}
					if (flag2)
					{
						flag = true;
						result = true;
						return result;
					}
				}
				if (this.method_52(Latitude_, Longitude_, TargetLatitude_, TargetLongitude_, float_3))
				{
					flag = true;
				}
				else
				{
					float distance = Math2.GetDistance(Latitude_, Longitude_, TargetLatitude_, TargetLongitude_);
					if (!float.IsNaN(distance) && distance != 0f)
					{
						float num;
						if (!this.ParentPlatform.IsAircraft)
						{
							if (distance < this.ParentPlatform.m_Scenario.Navigation_FinegrainedMaxDistance)
							{
								num = Class324.interface2_0.imethod_1();
							}
							else
							{
								num = Class324.interface2_0.imethod_0();
							}
						}
						else
						{
							num = Class324.interface2_0.imethod_0();
						}
						bool flag4 = false;
						Angle angle = default(Angle);
						angle.SetDegrees(Longitude_);
						Angle angle2 = default(Angle);
						angle2.SetDegrees(Latitude_);
						Angle angle3 = default(Angle);
						angle3.SetDegrees(TargetLongitude_);
						Angle angle4 = default(Angle);
						angle4.SetDegrees(TargetLatitude_);
						Angle d = World.ApproxAngularDistance(angle2, angle, angle4, angle3);
						float num2 = (float)d.GetDegrees();
						if (num2 < num * 2f)
						{
							flag = false;
							result = false;
							return result;
						}
						int num3 = (int)Math.Round((double)(num2 / num));
						Angle angle5 = default(Angle);
						Angle angle6 = default(Angle);
						int num4 = num3;
						for (int i = 1; i <= num4; i++)
						{
							World.IntermediateGCPoint(num * (float)i / num2, angle2, angle, angle4, angle3, d, out angle6, out angle5);
							double degrees = angle6.GetDegrees();
							double degrees2 = angle5.GetDegrees();
							Unit parentPlatform2 = this.ParentPlatform;
							double lat_ = degrees;
							double lon_ = degrees2;
							byte b = 0;
							bool flag3 = false;
							bool flag5 = true;
							List<ActiveUnit> list2 = null;
							if (!parentPlatform2.vmethod_41(lat_, lon_, ref b, true, ref flag3, false, ref flag5, nullable_0.HasValue ? new float?((float)nullable_0.GetValueOrDefault()) : null, null, ref list2, float_3, false, false))
							{
								flag = true;
								result = true;
								return result;
							}
						}
						flag = (result = flag4);
						return result;
					}
					else
					{
						flag = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100233", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00118584 File Offset: 0x00116784
		public static bool smethod_6(ref List<ReferencePoint> list_1, ref string string_1, string string_2, string string_3)
		{
            bool flag = false;
            try
            {
                if (list_1.Count < 3)
                {
                    goto Label_02AB;
                }
                new Class258.Class259(0.0, 0.0);
                int count = list_1.Count;
                Class258.Class259 class2 = new Class258.Class259(list_1[0].GetLatitude(), list_1[0].GetLongitude());
                Coordinate[] coordinates = new Coordinate[count + 1];
                int num2 = count - 1;
                for (int i = 0; i <= num2; i++)
                {
                    double num4 = 0.0;
                    double num5 = 0.0;
                    if (!class2.method_1(list_1[i].GetLatitude(), list_1[i].GetLongitude(), ref num4, ref num5, true))
                    {
                        goto Label_0230;
                    }
                    coordinates[i] = new Coordinate(num4, num5);
                }
                coordinates[count] = coordinates[0];
                Polygon polygon = new Polygon(new LinearRing(coordinates));
                try
                {
                    if (polygon.IsValid())
                    {
                        string_1 = "";
                        flag = true;
                        return true;
                    }
                    if (string.IsNullOrEmpty(string_3) && string.IsNullOrEmpty(string_2))
                    {
                        string_1 = "WARNING! Area validation has FAILED! The polygon that makes up the area crosses itself which means it is INVALID! This will cause problems for the AI navigator. Please check the shape of the area, and make sure that it doesn't cross itself at any point!";
                    }
                    else if (string.IsNullOrEmpty(string_2))
                    {
                        string_1 = "WARNING! Area validation for " + string_3 + " has FAILED! The polygon that makes up the area crosses itself which means it is INVALID! This will cause problems for the AI navigator. Please check the shape of the area, and make sure that it doesn't cross itself at any point!";
                    }
                    else
                    {
                        string_1 = "WARNING! Area validation for " + string_3 + " belonging to side " + string_2 + " has FAILED! The polygon that makes up the area crosses itself which means it is INVALID! This will cause problems for the AI navigator. Please check the shape of the area, and make sure that it doesn't cross itself at any point!";
                    }
                    flag = false;
                    return false;
                }
                catch (Exception exception)
                {
                    ProjectData.SetProjectError(exception);
                    Exception exception2 = exception;
                    exception2.Data.Add("Error at 200324", exception2.Message);
                    GameGeneral.LogException(ref exception2);
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
                    if (string.IsNullOrEmpty(string_3) && string.IsNullOrEmpty(string_2))
                    {
                        string_1 = "WARNING! Area validation has FAILED! This will cause problems for the AI navigator. Please check the shape of the area and make sure it makes sense.";
                    }
                    else if (string.IsNullOrEmpty(string_2))
                    {
                        string_1 = "WARNING! Area validation for " + string_3 + " has FAILED! This will cause problems for the AI navigator. Please check the shape of the area and make sure it makes sense.";
                    }
                    else
                    {
                        string_1 = "WARNING! Area validation for " + string_3 + " belonging to side " + string_2 + " has FAILED! This will cause problems for the AI navigator. Please check the shape of the area and make sure it makes sense.";
                    }
                    flag = false;
                    ProjectData.ClearProjectError();
                    return false;
                }
            Label_0230:
                if (string.IsNullOrEmpty(string_3) && string.IsNullOrEmpty(string_2))
                {
                    string_1 = "WARNING! The polygon that makes up the area is not VALID! It is either too big or the lines cross in weird ways. This will cause problems for the AI navigator.";
                }
                else if (string.IsNullOrEmpty(string_2))
                {
                    string_1 = "WARNING! The polygon that makes up the area for " + string_3 + " is not VALID! It is either too big or the lines cross in weird ways. This will cause problems for the AI navigator.";
                }
                else
                {
                    string_1 = "WARNING! The polygon that makes up the area for " + string_3 + " belonging to side " + string_2 + " is not VALID! It is either too big or the lines cross in weird ways. This will cause problems for the AI navigator.";
                }
                flag = false;
                return false;
            Label_02AB:
                flag = true;
            }
            catch (Exception exception3)
            {
                ProjectData.SetProjectError(exception3);
                Exception exception4 = exception3;
                exception4.Data.Add("Error at 101270", "");
                GameGeneral.LogException(ref exception4);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }
            return flag;

        }

        // Token: 0x06003299 RID: 12953 RVA: 0x001188BC File Offset: 0x00116ABC
        [CompilerGenerated]
		private float RangeTo(ReferencePoint Location)
		{
			return this.ParentPlatform.HorizontalRangeTo(Location.GetLatitude(), Location.GetLongitude());
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x001188E4 File Offset: 0x00116AE4
		[CompilerGenerated]
		private double AngularDistanceTo(ReferencePoint Location)
		{
			Unit parentPlatform = this.ParentPlatform;
			double latitude = Location.GetLatitude();
			double longitude = Location.GetLongitude();
			double approxAngularDistanceInDegrees = parentPlatform.GetApproxAngularDistanceInDegrees(ref latitude, ref longitude);
			Location.SetLongitude(longitude);
			Location.SetLatitude(latitude);
			return approxAngularDistanceInDegrees;
		}

		// Token: 0x04001757 RID: 5975
		public static Func<ReferencePoint, string> ReferencePointFunc1 = (ReferencePoint referencePoint_0) => referencePoint_0.Name;

		// Token: 0x04001758 RID: 5976
		public static Func<ReferencePoint, string> ReferencePointFunc2 = (ReferencePoint referencePoint_0) => referencePoint_0.Name;

		// Token: 0x04001759 RID: 5977
		public static Func<ReferencePoint, string> ReferencePointFunc3 = (ReferencePoint referencePoint_0) => referencePoint_0.Name;

		// Token: 0x0400175A RID: 5978
		public static Func<GeoPoint, GeoPoint, Tuple<Tuple<double, double>, Tuple<double, double>>> GeoPointFunc1 = (GeoPoint geoPoint_0, GeoPoint geoPoint_1) => new Tuple<Tuple<double, double>, Tuple<double, double>>(new Tuple<double, double>(Class263.ToRadians(geoPoint_0.GetLatitude()), Class263.ToRadians(geoPoint_0.GetLongitude())), new Tuple<double, double>(Class263.ToRadians(geoPoint_1.GetLatitude()), Class263.ToRadians(geoPoint_1.GetLongitude())));

		// Token: 0x0400175B RID: 5979
		public static Func<GeoPoint, GeoPoint, Tuple<Tuple<double, double>, Tuple<double, double>>> GeoPointFunc2 = (GeoPoint geoPoint_0, GeoPoint geoPoint_1) => new Tuple<Tuple<double, double>, Tuple<double, double>>(new Tuple<double, double>(Class263.ToRadians(geoPoint_0.GetLatitude()), Class263.ToRadians(geoPoint_0.GetLongitude())), new Tuple<double, double>(Class263.ToRadians(geoPoint_1.GetLatitude()), Class263.ToRadians(geoPoint_1.GetLongitude())));

		// Token: 0x0400175C RID: 5980
		public static Func<ReferencePoint, ReferencePoint, Tuple<Tuple<double, double>, Tuple<double, double>>> ReferencePointFunc4 = (ReferencePoint referencePoint_0, ReferencePoint referencePoint_1) => new Tuple<Tuple<double, double>, Tuple<double, double>>(new Tuple<double, double>(Class263.ToRadians(referencePoint_0.GetLatitude()), Class263.ToRadians(referencePoint_0.GetLongitude())), new Tuple<double, double>(Class263.ToRadians(referencePoint_1.GetLatitude()), Class263.ToRadians(referencePoint_1.GetLongitude())));

		// Token: 0x0400175D RID: 5981
		protected ActiveUnit ParentPlatform;

		// Token: 0x0400175E RID: 5982
		protected Waypoint[] PlottedCourse;

		// Token: 0x0400175F RID: 5983
		protected Waypoint[] PlottedCourse_PrePlanned;

		// Token: 0x04001760 RID: 5984
		protected Mission.Flight m_Flight;

		// Token: 0x04001761 RID: 5985
		protected string FlightName;

		// Token: 0x04001762 RID: 5986
		public bool ManualPlotOverride;

		// Token: 0x04001763 RID: 5987
		private ActiveUnit_Navigator.FormationStation m_FormationStation;

		// Token: 0x04001764 RID: 5988
		public ReferencePoint SupportMission_NextRefPoint;

		// Token: 0x04001765 RID: 5989
		public bool bUpdated;

		// Token: 0x04001766 RID: 5990
		public float NextUpdateTime;

		// Token: 0x04001767 RID: 5991
		public bool bool_2 = false;

		// Token: 0x04001768 RID: 5992
		public float float_1;

		// Token: 0x04001769 RID: 5993
		internal int int_0;

		// Token: 0x0400176A RID: 5994
		internal int int_1;

		// Token: 0x0400176B RID: 5995
		protected List<Waypoint> list_0;

		// Token: 0x0400176C RID: 5996
		public short short_0;

		// Token: 0x0400176D RID: 5997
		public short short_1;

		// Token: 0x0400176E RID: 5998
		public short short_2;

		// Token: 0x0400176F RID: 5999
		public short short_3;

		// Token: 0x04001770 RID: 6000
		public short short_4;

		// Token: 0x04001771 RID: 6001
		public short short_5;

		// Token: 0x04001772 RID: 6002
		public short short_6;

		// Token: 0x04001773 RID: 6003
		public short short_7;

		// Token: 0x04001774 RID: 6004
		public bool bool_3;

		// Token: 0x04001775 RID: 6005
		public bool bool_4;

		// Token: 0x04001776 RID: 6006
		public bool bool_5;

		// Token: 0x04001777 RID: 6007
		public bool bool_6;

		// Token: 0x04001778 RID: 6008
		public bool bool_7;

		// Token: 0x04001779 RID: 6009
		public bool bool_8;

		// Token: 0x0400177A RID: 6010
		public bool bool_9;

		// Token: 0x0400177B RID: 6011
		public bool bool_10;

		// Token: 0x0400177C RID: 6012
		public short short_8;

		// Token: 0x0400177D RID: 6013
		public bool bool_11;

		// Token: 0x0400177E RID: 6014
		public short TimeToCheckNoNavZoneViolation;

		// Token: 0x0400177F RID: 6015
		public bool bool_12;

		// Token: 0x04001780 RID: 6016
		public float float_2 = 0f;

		// Token: 0x04001781 RID: 6017
		private bool bool_13;

		// Token: 0x02000800 RID: 2048
		public sealed class FormationStation
		{
			// Token: 0x060032A2 RID: 12962 RVA: 0x00118A64 File Offset: 0x00116C64
			public double GetLatitude(ActiveUnit activeUnit_0, ActiveUnit activeUnit_1)
			{
				double num = 0.0;
				double result = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(activeUnit_1.GetLongitude(null), activeUnit_1.GetLatitude(null), ref num, ref result, (double)this.Distance, (double)this.GetBearing(activeUnit_0));
				return result;
			}

			// Token: 0x060032A3 RID: 12963 RVA: 0x00118AC0 File Offset: 0x00116CC0
			public double GetLongitude(ActiveUnit activeUnit_0, ActiveUnit activeUnit_1)
			{
				double result = 0.0;
				double num = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(activeUnit_1.GetLongitude(null), activeUnit_1.GetLatitude(null), ref result, ref num, (double)this.Distance, (double)this.GetBearing(activeUnit_0));
				return result;
			}

			// Token: 0x060032A4 RID: 12964 RVA: 0x00118B1C File Offset: 0x00116D1C
			public float GetBearing(ActiveUnit activeUnit_0)
			{
				ReferencePoint.OrientationType bearingType = this.BearingType;
				float result;
				if (bearingType != ReferencePoint.OrientationType.Fixed)
				{
					if (bearingType != ReferencePoint.OrientationType.Rotating)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = 0f;
					}
					else
					{
						result = Math2.Normalize(activeUnit_0.GetParentGroup(false).GetGroupLead().GetCurrentHeading() + this.Bearing);
					}
				}
				else
				{
					result = this.Bearing;
				}
				return result;
			}

			// Token: 0x04001788 RID: 6024
			public float Bearing;

			// Token: 0x04001789 RID: 6025
			public float Distance;

			// Token: 0x0400178A RID: 6026
			public ReferencePoint.OrientationType BearingType;

			// Token: 0x0400178B RID: 6027
			public bool SprintAndDrift;
		}

		// Token: 0x02000801 RID: 2049
		[CompilerGenerated]
		public sealed class Class66
		{
			// Token: 0x060032A6 RID: 12966 RVA: 0x0001B28B File Offset: 0x0001948B
			internal void method_0()
			{
				Class324.smethod_10(ref this.scenario);
			}

			// Token: 0x060032A7 RID: 12967 RVA: 0x00118B84 File Offset: 0x00116D84
			internal void method_1()
			{
				Class324.smethod_4(new Class356
				{
					theUnit = this.activeUnit_0,
					theFlight = this.m_Flight,
					bool_0 = this.bool_0,
					waypoint_0 = this.waypoint_0,
					float_0 = this.float_0,
					double_0 = this.double_0,
					double_1 = this.double_1,
					bool_1 = this.bool_1
				}, this.scenario);
			}

			// Token: 0x0400178C RID: 6028
			public Scenario scenario;

			// Token: 0x0400178D RID: 6029
			public ActiveUnit activeUnit_0;

			// Token: 0x0400178E RID: 6030
			public Mission.Flight m_Flight;

			// Token: 0x0400178F RID: 6031
			public bool bool_0;

			// Token: 0x04001790 RID: 6032
			public Waypoint waypoint_0;

			// Token: 0x04001791 RID: 6033
			public float float_0;

			// Token: 0x04001792 RID: 6034
			public double double_0;

			// Token: 0x04001793 RID: 6035
			public double double_1;

			// Token: 0x04001794 RID: 6036
			public bool bool_1;
		}
	}
}
