using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns3
{
	// Token: 0x02000B81 RID: 2945
	public sealed class Weapon_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x0600616F RID: 24943 RVA: 0x002EF5AC File Offset: 0x002ED7AC
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Weapon_Navigator");
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
				ex2.Data.Add("Error at 100983", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x002EF74C File Offset: 0x002ED94C
		public static Weapon_Navigator Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Weapon_Navigator result = null;
			try
			{
				Weapon_Navigator weapon_Navigator = new Weapon_Navigator(ref activeUnit_1);
				weapon_Navigator.ParentPlatform = activeUnit_1;
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
								weapon_Navigator.GetFormationStation().BearingType = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						weapon_Navigator.GetFormationStation().Bearing = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_196:
						IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
								Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode2, ref dictionary_0);
								ScenarioArrayUtil.AddWaypoint(ref weapon_Navigator.PlottedCourse, waypoint_);
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
						weapon_Navigator.ManualPlotOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_25C:
						weapon_Navigator.GetFormationStation().Distance = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_289:
						ActiveUnit_Navigator activeUnit_Navigator = weapon_Navigator;
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
				result = weapon_Navigator;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100984", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00028B71 File Offset: 0x00026D71
		public Weapon_Navigator(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x002EFAEC File Offset: 0x002EDCEC
		public override void vmethod_7(float float_3)
		{
			try
			{
				bool flag = false;
				this.vmethod_9(float_3, ref flag);
				base.method_16();
				if (this.ParentPlatform.bUnitStatusChanged && this.ParentPlatform.GetThrottle() < ActiveUnit.Throttle.Cruise)
				{
					this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100985", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x0002B1CB File Offset: 0x000293CB
		public override bool vmethod_8(double double_0, double double_1, float float_3)
		{
			return base.vmethod_8(double_0, double_1, float_3);
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x002EFB90 File Offset: 0x002EDD90
		private GeoPoint method_55(float float_3, Unit unit_0)
		{
			GeoPoint result = null;
			try
			{
				if (unit_0.GetCurrentSpeed() == 0f)
				{
					result = new GeoPoint(unit_0.GetLongitude(null), unit_0.GetLatitude(null));
				}
				else
				{
					float desiredSpeed = this.ParentPlatform.GetDesiredSpeed(unit_0, float_3, this.ParentPlatform.GetCurrentHeading());
					if (desiredSpeed > 0f && !double.IsNaN((double)desiredSpeed))
					{
						float num = (float)((long)Math.Round((double)(this.ParentPlatform.GetHorizontalRange(unit_0) / desiredSpeed * 3600f))) / 3600f * unit_0.GetCurrentSpeed();
						double double_ = 0.0;
						double double_2 = 0.0;
						GeoPointGenerator.GetOtherGeoPoint(unit_0.GetLongitude(null), unit_0.GetLatitude(null), ref double_, ref double_2, (double)num, (double)unit_0.GetCurrentHeading());
						result = new GeoPoint(double_, double_2);
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100986", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x002EFCDC File Offset: 0x002EDEDC
		public bool method_56(ActiveUnit activeUnit_)
		{
			bool result;
			if (Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()))
			{
				result = false;
			}
			else
			{
				float horizontalRange = activeUnit_.GetHorizontalRange(this.ParentPlatform.GetAI().GetPrimaryTarget());
				float num = activeUnit_.AzimuthTo(this.ParentPlatform.GetAI().GetPrimaryTarget());
				float maxRangeToTarget = ((Weapon)this.ParentPlatform).GetMaxRangeToTarget(this.ParentPlatform, this.ParentPlatform.GetAI().GetPrimaryTarget(), false, activeUnit_.m_Doctrine, false);
				List<Waypoint> list = new List<Waypoint>();
				Random random = GameGeneral.GetRandom();
				int num2 = 1;
				do
				{
					int num3;
					if (activeUnit_.IsAircraft)
					{
						num3 = random.Next(-45, 46);
					}
					else
					{
						num3 = random.Next(-80, 81);
					}
					int num4 = random.Next(1, (int)Math.Round((double)(horizontalRange / 2f)));
					double num5 = 0.0;
					double num6 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null), ref num5, ref num6, (double)num4, (double)Math2.Normalize(num + (float)num3));
					float num7 = activeUnit_.HorizontalRangeTo(num6, num5);
					float num8 = this.ParentPlatform.GetAI().GetPrimaryTarget().HorizontalRangeTo(num6, num5);
					if (num7 + num8 < maxRangeToTarget)
					{
						list.Add(new Waypoint(num5, num6, Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_1, Waypoint._Category.const_0));
					}
					num2++;
				}
				while (num2 <= 10000);
				if (!list.Any<Waypoint>())
				{
					result = false;
				}
				else
				{
					if (list.Count == 1)
					{
						base.AddWaypoint(list[0]);
					}
					else
					{
						Waypoint waypoint_ = list[random.Next(0, list.Count)];
						base.AddWaypoint(waypoint_);
					}
					base.AddWaypoint(new Waypoint(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null), Waypoint.WaypointType.WeaponTerminalPoint, Waypoint._Creator.const_1, Waypoint._Category.const_0));
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x002EFF14 File Offset: 0x002EE114
		public bool method_57(float Speed_, bool HasAircraftDataLinkParent_)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()))
				{
					flag = false;
				}
				else
				{
					Waypoint waypoint = new Waypoint();
					Weapon weapon = (Weapon)this.ParentPlatform;
					Waypoint waypoint2;
					if (base.HasPlottedCourse())
					{
						if (base.GetPlottedCourse().Last<Waypoint>().waypointType == Waypoint.WaypointType.WeaponTerminalPoint)
						{
							if (base.GetPlottedCourse().Count<Waypoint>() > 1)
							{
								waypoint2 = base.GetPlottedCourse()[base.GetPlottedCourse().Count<Waypoint>() - 2];
							}
							else
							{
								waypoint2 = new Waypoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null), Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0);
							}
						}
						else
						{
							waypoint2 = base.GetPlottedCourse()[base.GetPlottedCourse().Count<Waypoint>() - 1];
						}
					}
					else
					{
						waypoint2 = new Waypoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null), Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0);
					}
					Weapon._GuidanceMethod guidanceMethod = weapon.GetGuidanceMethod();
					if (guidanceMethod == Weapon._GuidanceMethod.InertiallyGuided)
					{
						try
						{
							if (this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentSpeed() > 0f)
							{
								double? num = ActiveUnit_Navigator.smethod_4(waypoint2.GetLatitude(), waypoint2.GetLongitude(), (double)this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetAI().GetPrimaryTarget(), Speed_);
								if (!num.HasValue)
								{
									flag = false;
									result = false;
									return result;
								}
								float angleBetween = Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetAI().GetAzimuth(this.ParentPlatform.GetAI().GetPrimaryTarget()));
								GeoPoint geoPoint = null;
								if ((angleBetween > 10f && angleBetween < 350f) || (angleBetween > 170f && angleBetween < 190f))
								{
									geoPoint = Class263.smethod_12(new GeoPoint(waypoint2.GetLongitude(), waypoint2.GetLatitude()), num.Value, new GeoPoint(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null)), (double)this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentHeading());
								}
								if (Information.IsNothing(geoPoint))
								{
									GeoPoint geoPoint2 = this.method_55(Speed_, this.ParentPlatform.GetAI().GetPrimaryTarget());
									if (Information.IsNothing(geoPoint2))
									{
										waypoint.SetLatitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null));
										waypoint.SetLongitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null));
									}
									else
									{
										waypoint.SetLatitude(geoPoint2.GetLatitude());
										waypoint.SetLongitude(geoPoint2.GetLongitude());
									}
								}
								else
								{
									waypoint.SetLatitude(geoPoint.GetLatitude());
									waypoint.SetLongitude(geoPoint.GetLongitude());
								}
							}
							else
							{
								waypoint.SetLatitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null));
								waypoint.SetLongitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null));
							}
							goto IL_E98;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 101230", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
							goto IL_E98;
						}
					}
					try
					{
						if (this.ParentPlatform.GetAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint && this.ParentPlatform.GetAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint)
						{
							double[] array = new double[this.ParentPlatform.GetNoneMCMSensors().Length + 1];
							int num2 = this.ParentPlatform.GetNoneMCMSensors().Length - 1;
							for (int i = 0; i <= num2; i++)
							{
								if (this.ParentPlatform.GetNoneMCMSensors()[i].sensorType != Sensor.SensorType.ESM || weapon.weaponTarget.IsRadar)
								{
									array[i] = (double)this.ParentPlatform.GetNoneMCMSensors()[i].MaxRange;
								}
							}
							double num3 = array.Max();
							if (this.ParentPlatform.GetNoneMCMSensors().Length == 0)
							{
								Warhead[] warheads = weapon.m_Warheads;
								for (int j = 0; j < warheads.Length; j = checked(j + 1))
								{
									Warhead warhead = warheads[j];
									if (warhead.warheadType == Warhead.WarheadType.Weapon)
									{
										Weapon weaponFromDP = warhead.GetWeaponFromDP(weapon.m_Scenario);
										int num4 = weaponFromDP.GetNoneMCMSensors().Length - 1;
										for (int k = 0; k <= num4; k++)
										{
											if (weaponFromDP.GetNoneMCMSensors()[k].sensorType != Sensor.SensorType.ESM || weapon.weaponTarget.IsRadar)
											{
												array[k] = (double)weaponFromDP.GetNoneMCMSensors()[k].MaxRange;
											}
										}
									}
								}
								num3 = array.Max();
							}
							if (((Weapon)this.ParentPlatform).IsGuidedWeapon_RV_HGV() && this.ParentPlatform.GetAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine)
							{
								num3 = 0.0;
							}
							if (HasAircraftDataLinkParent_ && this.ParentPlatform.GetAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine && ((Weapon)this.ParentPlatform).weaponCode.SearchPattern)
							{
								num3 = 0.0;
							}
							float distance = waypoint2.GetDistance(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null));
							float num5 = this.ParentPlatform.GetCurrentSpeed() / 3600f * 2f;
							if (this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentSpeed() <= 0f)
							{
								double num6;
								if ((double)distance > num3)
								{
									num6 = (double)distance - num3 * 0.8;
									if (num6 < (double)num5)
									{
										num6 = 0.0001;
									}
								}
								else
								{
									num6 = (double)distance * 0.5;
									if (num6 < (double)num5)
									{
										num6 = 0.0001;
									}
								}
								double longitude = waypoint2.GetLongitude();
								double latitude = waypoint2.GetLatitude();
								Waypoint waypoint3;
								double num7 = (waypoint3 = waypoint).GetLongitude();
								Waypoint waypoint4;
								double num8 = (waypoint4 = waypoint).GetLatitude();
								GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num7, ref num8, (double)((float)num6), (double)Math2.GetAzimuth(waypoint2.GetLatitude(), waypoint2.GetLongitude(), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null)));
								waypoint4.SetLatitude(num8);
								waypoint3.SetLongitude(num7);
							}
							else
							{
								double? num9 = ActiveUnit_Navigator.smethod_4(waypoint2.GetLatitude(), waypoint2.GetLongitude(), (double)this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetAI().GetPrimaryTarget(), Speed_);
								if (!num9.HasValue)
								{
									flag = false;
									result = false;
									return result;
								}
								if (this.ParentPlatform.GetAI().GetPrimaryTarget().IsAirSpace())
								{
									double num10 = (double)this.ParentPlatform.GetDesiredSpeed(this.ParentPlatform.GetAI().GetPrimaryTarget(), this.ParentPlatform.GetCurrentSpeed(), this.ParentPlatform.GetCurrentHeading());
									float angleBetween2 = Class263.GetAngleBetween(this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetAI().GetAzimuth(this.ParentPlatform.GetAI().GetPrimaryTarget()));
									GeoPoint geoPoint3 = null;
									if (((angleBetween2 > 5f && angleBetween2 < 355f) || (angleBetween2 > 175f && angleBetween2 < 185f)) && num10 < (double)this.ParentPlatform.GetCurrentSpeed() * 1.25)
									{
										geoPoint3 = Class263.smethod_12(new GeoPoint(waypoint2.GetLongitude(), waypoint2.GetLatitude()), num9.Value, new GeoPoint(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null)), (double)this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentHeading());
									}
									if (Information.IsNothing(geoPoint3) && ((angleBetween2 > 10f && angleBetween2 < 350f) || (angleBetween2 > 170f && angleBetween2 < 190f)))
									{
										geoPoint3 = Class263.smethod_12(new GeoPoint(waypoint2.GetLongitude(), waypoint2.GetLatitude()), num9.Value, new GeoPoint(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null)), (double)this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentHeading());
									}
									double num7 = 0.0;
									double num8 = 0.0;
									if (Information.IsNothing(geoPoint3))
									{
										double num6;
										if ((double)distance > num3 * 0.8)
										{
											num6 = (double)(distance / 2f);
											if (num6 < (double)num5)
											{
												num6 = 0.0001;
											}
										}
										else
										{
											num6 = 0.0001;
										}
										double longitude2 = waypoint2.GetLongitude();
										double latitude2 = waypoint2.GetLatitude();
										Waypoint waypoint3;
										num7 = (waypoint3 = waypoint).GetLongitude();
										Waypoint waypoint4;
										num8 = (waypoint4 = waypoint).GetLatitude();
										GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref num7, ref num8, (double)((float)num6), (double)((float)num9.Value));
										waypoint4.SetLatitude(num8);
										waypoint3.SetLongitude(num7);
									}
									else
									{
										float distance2 = Math2.GetDistance(waypoint2.GetLatitude(), waypoint2.GetLongitude(), geoPoint3.GetLatitude(), geoPoint3.GetLongitude());
										double num6;
										if ((double)distance < num3 * 0.8)
										{
											num6 = 0.0001;
										}
										else if ((double)distance2 > (double)distance - num3 * 0.8)
										{
											num6 = (double)(distance2 - (float)((double)distance2 - ((double)distance - num3 * 0.8)));
											if (num6 <= 0.0)
											{
												num6 = 0.0001;
											}
											if (num6 < (double)num5)
											{
												num6 = 0.0001;
											}
										}
										else
										{
											num6 = (double)distance2;
											if (num6 < (double)num5)
											{
												num6 = 0.0001;
											}
										}
										double longitude3 = waypoint2.GetLongitude();
										double latitude3 = waypoint2.GetLatitude();
										Waypoint waypoint4;
										num8 = (waypoint4 = waypoint).GetLongitude();
										Waypoint waypoint3;
										num7 = (waypoint3 = waypoint).GetLatitude();
										GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude3, ref num8, ref num7, (double)((float)num6), (double)Math2.GetAzimuth(waypoint2.GetLatitude(), waypoint2.GetLongitude(), geoPoint3.GetLatitude(), geoPoint3.GetLongitude()));
										waypoint3.SetLatitude(num7);
										waypoint4.SetLongitude(num8);
									}
								}
								else
								{
									GeoPoint geoPoint3 = Class263.smethod_12(new GeoPoint(waypoint2.GetLongitude(), waypoint2.GetLatitude()), num9.Value, new GeoPoint(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null), this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null)), (double)this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentHeading());
									double num7 = 0.0;
									double num8 = 0.0;
									if (Information.IsNothing(geoPoint3))
									{
										double num6;
										if ((double)distance > num3 * 0.8)
										{
											num6 = (double)(distance / 2f);
											if (num6 < (double)num5)
											{
												num6 = 0.0001;
											}
										}
										else
										{
											num6 = 0.0001;
										}
										double longitude4 = waypoint2.GetLongitude();
										double latitude4 = waypoint2.GetLatitude();
										Waypoint waypoint3;
										num7 = (waypoint3 = waypoint).GetLongitude();
										Waypoint waypoint4;
										num8 = (waypoint4 = waypoint).GetLatitude();
										GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num7, ref num8, (double)((float)num6), (double)((float)num9.Value));
										waypoint4.SetLatitude(num8);
										waypoint3.SetLongitude(num7);
									}
									else
									{
										float distance3 = Math2.GetDistance(waypoint2.GetLatitude(), waypoint2.GetLongitude(), geoPoint3.GetLatitude(), geoPoint3.GetLongitude());
										double num6;
										if ((double)distance3 < num3 * 0.8)
										{
											num6 = 0.0001;
										}
										else if ((double)distance3 > (double)distance - num3 * 0.8)
										{
											num6 = (double)(distance3 - (float)((double)distance3 - ((double)distance - num3 * 0.8)));
											if (num6 <= 0.0)
											{
												num6 = 0.0001;
											}
											if (num6 < (double)num5)
											{
												num6 = 0.0001;
											}
										}
										else
										{
											num6 = (double)distance3 - num3 * 0.8;
											if (num6 < (double)num5)
											{
												num6 = 0.0001;
											}
										}
										double longitude5 = waypoint2.GetLongitude();
										double latitude5 = waypoint2.GetLatitude();
										Waypoint waypoint4;
										num8 = (waypoint4 = waypoint).GetLongitude();
										Waypoint waypoint3;
										num7 = (waypoint3 = waypoint).GetLatitude();
										GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num8, ref num7, (double)((float)num6), (double)Math2.GetAzimuth(waypoint2.GetLatitude(), waypoint2.GetLongitude(), geoPoint3.GetLatitude(), geoPoint3.GetLongitude()));
										waypoint3.SetLatitude(num7);
										waypoint4.SetLongitude(num8);
									}
								}
							}
						}
						else
						{
							waypoint.SetLatitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLatitude(null));
							waypoint.SetLongitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetLongitude(null));
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 101231", "");
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					IL_E98:
					if (((Weapon)this.ParentPlatform).m_Warheads.Length > 0)
					{
						if (((Weapon)this.ParentPlatform).m_Warheads[0].method_15())
						{
							waypoint.SetAltitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false) + 700f);
						}
						else
						{
							waypoint.SetAltitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false));
						}
					}
					if (((Weapon)this.ParentPlatform).GetWeaponType() == Weapon._WeaponType.Decoy_Expendable)
					{
						waypoint.SetAltitude(this.ParentPlatform.GetCurrentAltitude_ASL(false));
					}
					if (base.HasWaypointOtherPathfindingPoint() && base.GetPlottedCourse().Last<Waypoint>().waypointType == Waypoint.WaypointType.WeaponTerminalPoint)
					{
						base.GetPlottedCourse()[base.GetPlottedCourse().Count<Waypoint>() - 1].SetLatitude(waypoint.GetLatitude());
						base.GetPlottedCourse()[base.GetPlottedCourse().Count<Waypoint>() - 1].SetLongitude(waypoint.GetLongitude());
					}
					else
					{
						this.AddWaypoint(waypoint.GetLatitude(), waypoint.GetLongitude(), Waypoint.WaypointType.WeaponTerminalPoint, Waypoint._Creator.const_1, Waypoint._Category.const_0);
					}
					flag = true;
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100987", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x002F0F6C File Offset: 0x002EF16C
		public override void vmethod_9(float float_3, ref bool bool_14)
		{
			Weapon weapon = (Weapon)this.ParentPlatform;
			if (weapon.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided || weapon.IsTorpedo() || weapon.GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle || base.GetPlottedCourse().Count<Waypoint>() != 1)
			{
				bool flag = false;
				base.vmethod_9(float_3, ref flag);
				if (base.GetPlottedCourse().Count<Waypoint>() == 0 && weapon.GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle)
				{
					this.ParentPlatform.GetAI().SetPrimaryTarget(null);
				}
			}
		}
	}
}
