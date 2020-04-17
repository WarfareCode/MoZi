using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace Command_Core
{
	// Token: 0x0200046A RID: 1130
	public class ActiveUnit_AirOps
	{
		// Token: 0x06001D19 RID: 7449 RVA: 0x000B9318 File Offset: 0x000B7518
		public static bool imethod_0(Aircraft aircraft_)
		{
			bool result;
			if (aircraft_.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked && aircraft_.GetAircraftAirOps().GetConditionTimer() == 0f)
			{
				string text = null;
				result = (aircraft_.GetMaintenanceLevel(ref text) != Aircraft_AirOps._Maintenance.Unavailable);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x000B9364 File Offset: 0x000B7564
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("ActiveUnit_AirOps");
					if (this.LandingQueue.Count<Aircraft>() > 0)
					{
						xmlWriter_0.WriteStartElement("LandingQueue");
						Aircraft[] landingQueue = this.LandingQueue;
						for (int i = 0; i < landingQueue.Length; i++)
						{
							Aircraft aircraft = landingQueue[i];
							if (!Information.IsNothing(aircraft))
							{
								xmlWriter_0.WriteElementString("ID", aircraft.GetGuid());
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100071", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x000B9430 File Offset: 0x000B7630
		public static ActiveUnit_AirOps Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			ActiveUnit_AirOps result;
			try
			{
				ActiveUnit_AirOps activeUnit_AirOps = new ActiveUnit_AirOps();
				activeUnit_AirOps.theUnit = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "LandingQueue", false) == 0)
						{
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
									ScenarioArrayUtil.AddStringToArray(ref activeUnit_AirOps.aircraftsToLanding, xmlNode2.InnerText);
								}
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
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = activeUnit_AirOps;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100072", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ActiveUnit_AirOps();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000B957C File Offset: 0x000B777C
		public virtual void AddsToLandingQueue(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0, bool bool_0)
		{
			string[] array = this.aircraftsToLanding;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					try
					{
						if (!Information.IsNothing(text))
						{
							Aircraft aircraft_ = (Aircraft)scenario_.GetActiveUnits()[text];
							ScenarioArrayUtil.AddAircraft(ref this.LandingQueue, aircraft_);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100073", "");
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

		// Token: 0x06001D1D RID: 7453 RVA: 0x0001200F File Offset: 0x0001020F
		private ActiveUnit_AirOps()
		{
			this.LandingQueue = new Aircraft[0];
			this.aircraftsToLanding = new string[0];
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000B9620 File Offset: 0x000B7820
		public virtual GlobalVariables._RunwayLengthCode vmethod_2()
		{
			checked
			{
				GlobalVariables._RunwayLengthCode result;
				try
				{
					GlobalVariables._RunwayLengthCode runwayLengthCode = GlobalVariables._RunwayLengthCode.None;
					AirFacility[] airFacilities = this.theUnit.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility = airFacilities[i];
						if (airFacility.RunwayLengthCode > runwayLengthCode)
						{
							runwayLengthCode = airFacility.RunwayLengthCode;
						}
					}
					result = runwayLengthCode;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100074", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = GlobalVariables._RunwayLengthCode.None;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000B96CC File Offset: 0x000B78CC
		public virtual GlobalVariables.AircraftSizeClass vmethod_3()
		{
			checked
			{
				GlobalVariables.AircraftSizeClass result;
				try
				{
					GlobalVariables.AircraftSizeClass aircraftSizeClass = GlobalVariables.AircraftSizeClass.None;
					AirFacility[] airFacilities = this.theUnit.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility = airFacilities[i];
						if ((airFacility.IsTakeOffOrLandingFacility() || airFacility.IsAircraftCarrierCatapult()) && airFacility.GetAircraftSizeClass() > aircraftSizeClass)
						{
							aircraftSizeClass = airFacility.GetAircraftSizeClass();
						}
					}
					result = aircraftSizeClass;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100075", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = GlobalVariables.AircraftSizeClass.None;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000B9784 File Offset: 0x000B7984
		public virtual List<Aircraft> GetHostedAircrafts()
		{
			checked
			{
				List<Aircraft> result;
				try
				{
					List<Aircraft> list = new List<Aircraft>();
					AirFacility[] airFacilities = this.theUnit.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility = airFacilities[i];
						foreach (Aircraft current in airFacility.GetHostedAircrafts().Values)
						{
							list.Add(current);
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100076", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Aircraft>();
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000B9868 File Offset: 0x000B7A68
		public virtual Aircraft[] vmethod_5()
		{
			Aircraft[] array = new Aircraft[0];
			Aircraft[] result;
			try
			{
				foreach (ActiveUnit current in this.theUnit.m_Scenario.GetActiveUnitList())
				{
					if (current.IsAircraft && current.IsOperating())
					{
						Aircraft_AirOps aircraftAirOps = ((Aircraft)current).GetAircraftAirOps();
						if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown && (aircraftAirOps.GetAssignedHostUnit(true) == this.theUnit || aircraftAirOps.GetAssignedHostUnit() == this.theUnit))
						{
							ScenarioArrayUtil.AddAircraft(ref array, (Aircraft)current);
						}
					}
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100077", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000B9980 File Offset: 0x000B7B80
		public ReadOnlyCollection<AirFacility> method_0(bool? nullable_0, Aircraft aircraft_1, ActiveUnit activeUnit_1, IEnumerable<AirFacility> ienumerable_0)
		{
			ReadOnlyCollection<AirFacility> result;
			try
			{
				if (ienumerable_0.Count<AirFacility>() == 0)
				{
					result = null;
				}
				else
				{
					DateTime currentTime = activeUnit_1.m_Scenario.GetCurrentTime(false);
					List<AirFacility> list = new List<AirFacility>();
					foreach (AirFacility current in ienumerable_0)
					{
						if (aircraft_1.aircraftSizeClass <= current.GetAircraftSizeClass())
						{
							int num = 0;
							if (current.GetAirFacilityType() == AirFacility._AirFacilityType.Elevator)
							{
								num = current.Capacity;
							}
							else if (aircraft_1.aircraftSizeClass == current.GetAircraftSizeClass())
							{
								num = 1;
							}
							else if (aircraft_1.Type != Aircraft._AircraftType.Fighter && aircraft_1.Type != Aircraft._AircraftType.Attack && aircraft_1.Type != Aircraft._AircraftType.Multirole && aircraft_1.Type != Aircraft._AircraftType.OECM && aircraft_1.Type != Aircraft._AircraftType.WildWeasel && aircraft_1.Type != Aircraft._AircraftType.Trainer && aircraft_1.Type != Aircraft._AircraftType.Recon)
							{
								num = 1;
							}
							else if (Class240.GetTimeOfDay(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second, activeUnit_1.GetLatitude(null), activeUnit_1.GetLongitude(null), 0.0) != Weather._TimeOfDay.Day)
							{
								num = 1;
							}
							else
							{
								num = 2;
							}
							if (Information.IsNothing(nullable_0))
							{
								using (IEnumerator<Aircraft> enumerator2 = current.GetHostedAircrafts().Values.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										Aircraft current2 = enumerator2.Current;
										if (current2.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff || current2.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TaxyingToPark)
										{
											num = 0;
											break;
										}
										num--;
										if (num == 0)
										{
											break;
										}
									}
									goto IL_34D;
								}
								goto IL_1E4;
							}
							goto IL_1E4;
							IL_340:
							list.Add(current);
							continue;
							IL_1E4:
							if ((nullable_0.HasValue ? new bool?(!nullable_0.GetValueOrDefault()) : nullable_0).GetValueOrDefault())
							{
								using (IEnumerator<Aircraft> enumerator3 = current.GetHostedAircrafts().Values.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										Aircraft current3 = enumerator3.Current;
										if (current3.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff && current3.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
										{
											if (aircraft_1.DBID == current3.DBID || current.GetAirFacilityType() == AirFacility._AirFacilityType.Elevator)
											{
												num--;
												if (num != 0)
												{
													continue;
												}
											}
											else
											{
												num = 0;
											}
											IL_28F:
											goto IL_34D;
										}
										num = 0;
										break;
									}
									goto IL_34D;
								}
							}
							using (IEnumerator<Aircraft> enumerator4 = current.GetHostedAircrafts().Values.GetEnumerator())
							{
								while (enumerator4.MoveNext())
								{
									Aircraft current4 = enumerator4.Current;
									if (current4.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TaxyingToPark && current4.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
									{
										if (aircraft_1.DBID == current4.DBID || current.GetAirFacilityType() == AirFacility._AirFacilityType.Elevator)
										{
											num--;
											if (num != 0)
											{
												continue;
											}
										}
										else
										{
											num = 0;
										}
										IL_32A:
										goto IL_34D;
									}
									num = 0;
									break;
								}
								goto IL_34D;
							}
							goto IL_340;
							IL_34D:
							if (num > 0)
							{
								goto IL_340;
							}
						}
					}
					result = list.AsReadOnly();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100078", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<AirFacility>().AsReadOnly();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000B9DD0 File Offset: 0x000B7FD0
		public IEnumerable<AirFacility> method_1(ActiveUnit activeUnit_1)
		{
			checked
			{
				IEnumerable<AirFacility> result;
				try
				{
					List<AirFacility> list = new List<AirFacility>();
					AirFacility[] airFacilities = activeUnit_1.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility = airFacilities[i];
						if (airFacility.IsRunwayAccessPointOrElevator() && airFacility.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && airFacility.IsRunwayAccessPointOrElevator())
						{
							list.Add(airFacility);
						}
					}
					result = list.AsReadOnly();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100079", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<AirFacility>().AsReadOnly();
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000B9E90 File Offset: 0x000B8090
		public ReadOnlyCollection<AirFacility> method_2(bool bool_0, bool bool_1, Aircraft aircraft_1, ActiveUnit activeUnit_1, bool bool_2, IEnumerable<AirFacility> ienumerable_0)
		{
			ReadOnlyCollection<AirFacility> result;
			if (ienumerable_0.Count<AirFacility>() == 0)
			{
				result = null;
			}
			else
			{
				DateTime currentTime = activeUnit_1.m_Scenario.GetCurrentTime(false);
				try
				{
					List<AirFacility> list = new List<AirFacility>();
					Collection<Aircraft> collection = new Collection<Aircraft>();
					checked
					{
						if (!bool_1)
						{
							Aircraft[] array = activeUnit_1.GetAirOps().vmethod_5();
							for (int i = 0; i < array.Length; i++)
							{
								Aircraft item = array[i];
								collection.Add(item);
							}
						}
					}
					foreach (AirFacility current in ienumerable_0)
					{
						if (aircraft_1.aircraftSizeClass <= current.GetAircraftSizeClass())
						{
							int num = 0;
							if (current.GetAirFacilityType() != AirFacility._AirFacilityType.Runway)
							{
								num = 1;
							}
							else if (aircraft_1.aircraftSizeClass == current.GetAircraftSizeAfterDamage())
							{
								num = 1;
							}
							else if (aircraft_1.Type != Aircraft._AircraftType.Fighter && aircraft_1.Type != Aircraft._AircraftType.Attack && aircraft_1.Type != Aircraft._AircraftType.Multirole && aircraft_1.Type != Aircraft._AircraftType.OECM && aircraft_1.Type != Aircraft._AircraftType.WildWeasel && aircraft_1.Type != Aircraft._AircraftType.Trainer && aircraft_1.Type != Aircraft._AircraftType.Recon)
							{
								num = 1;
							}
							else if (Class240.GetTimeOfDay(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second, activeUnit_1.GetLatitude(null), activeUnit_1.GetLongitude(null), 0.0) != Weather._TimeOfDay.Day)
							{
								num = 1;
							}
							else
							{
								num = 2;
							}
							if (bool_1)
							{
								using (IEnumerator<Aircraft> enumerator2 = current.GetHostedAircrafts().Values.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										Aircraft current2 = enumerator2.Current;
										if (current2.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TakingOff)
										{
											if (aircraft_1.DBID == current2.DBID)
											{
												num--;
												if (num != 0)
												{
													continue;
												}
											}
											else
											{
												if (!((Aircraft)this.theUnit).GetAircraftAirOps().HasLandingFacility(current, true))
												{
													continue;
												}
												num = 0;
											}
										}
										else
										{
											num = 0;
										}
										break;
									}
									goto IL_42A;
								}
								goto IL_23B;
							}
							goto IL_23B;
							IL_42A:
							if (num > 0)
							{
								list.Add(current);
								continue;
							}
							continue;
							IL_23B:
							if (bool_0)
							{
								using (IEnumerator<Aircraft> enumerator3 = current.GetHostedAircrafts().Values.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										Aircraft current3 = enumerator3.Current;
										if (current3.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown)
										{
											if (aircraft_1.DBID == current3.DBID)
											{
												num--;
												if (num != 0)
												{
													continue;
												}
											}
											else
											{
												if (!((Aircraft)this.theUnit).GetAircraftAirOps().method_70(current))
												{
													continue;
												}
												num = 0;
											}
										}
										else
										{
											num = 0;
										}
										break;
									}
									goto IL_42A;
								}
							}
							if (!bool_1 && !bool_0)
							{
								using (IEnumerator<Aircraft> enumerator4 = current.GetHostedAircrafts().Values.GetEnumerator())
								{
									while (enumerator4.MoveNext())
									{
										if (enumerator4.Current.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TakingOff)
										{
											num = 0;
											break;
										}
									}
								}
								if (collection.Count <= 0 || num <= 0)
								{
									goto IL_42A;
								}
								List<Aircraft> list2 = new List<Aircraft>();
								foreach (Aircraft current4 in collection)
								{
									if (aircraft_1.DBID == current4.DBID)
									{
										list2.Add(current4);
										num--;
										if (num != 0)
										{
											continue;
										}
									}
									else
									{
										if (!((Aircraft)this.theUnit).GetAircraftAirOps().HasLandingFacility(current, true))
										{
											continue;
										}
										list2.Add(current4);
										num = 0;
									}
									break;
								}
								using (List<Aircraft>.Enumerator enumerator6 = list2.GetEnumerator())
								{
									while (enumerator6.MoveNext())
									{
										Aircraft current5 = enumerator6.Current;
										collection.Remove(current5);
									}
									goto IL_42A;
								}
							}
							if (Debugger.IsAttached)
							{
								Debugger.Break();
								goto IL_42A;
							}
							goto IL_42A;
						}
					}
					result = list.AsReadOnly();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100080", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<AirFacility>().AsReadOnly();
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000BA3EC File Offset: 0x000B85EC
		public IEnumerable<Aircraft> method_3()
		{
			IEnumerable<Aircraft> result;
			try
			{
				result = this.GetHostedAircrafts().Where(ActiveUnit_AirOps.AircraftFunc0).AsEnumerable<Aircraft>();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100083", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Aircraft>().AsEnumerable<Aircraft>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000BA46C File Offset: 0x000B866C
		public Aircraft[] GetLandingQueue()
		{
			return this.LandingQueue;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000BA484 File Offset: 0x000B8684
		public GeoPoint method_5()
		{
			GeoPoint result = null;
			try
			{
				float num = Math2.Normalize(this.theUnit.GetCurrentHeading() + 180f);
				Waypoint waypoint = new Waypoint();
				double longitude = this.theUnit.GetLongitude(null);
				double latitude = this.theUnit.GetLatitude(null);
				Waypoint waypoint2;
				double longitude2 = (waypoint2 = waypoint).GetLongitude();
				Waypoint waypoint3;
				double latitude2 = (waypoint3 = waypoint).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)this.method_6(), (double)num);
				waypoint3.SetLatitude(latitude2);
				waypoint2.SetLongitude(longitude2);
				result = waypoint;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100084", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Waypoint(this.theUnit.GetLongitude(null), this.theUnit.GetLatitude(null), Waypoint.WaypointType.Land, Waypoint._Creator.const_1, Waypoint._Category.const_0);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000BA5A8 File Offset: 0x000B87A8
		public float method_6()
		{
			return 10f;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0001202F File Offset: 0x0001022F
		public ActiveUnit_AirOps(ref ActiveUnit activeUnit_)
		{
			this.LandingQueue = new Aircraft[0];
			this.aircraftsToLanding = new string[0];
			this.theUnit = activeUnit_;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000BA5BC File Offset: 0x000B87BC
		public void HoldOnLanding(Aircraft aircraft_)
		{
			try
			{
				if (!this.LandingQueue.Contains(aircraft_))
				{
					ScenarioArrayUtil.AddAircraft(ref this.LandingQueue, aircraft_);
					aircraft_.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue);
					aircraft_.GetAircraftAirOps().SetConditionTimer(5f);
					this.ScheduleEmergencyLandingEvent();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100085", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00012057 File Offset: 0x00010257
		public void RemoveAircraftFromLandingQueue(Aircraft aircraft_1)
		{
			ScenarioArrayUtil.RemoveAircraft(ref this.LandingQueue, aircraft_1);
			this.ScheduleEmergencyLandingEvent();
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x000BA654 File Offset: 0x000B8854
		public void UpdateLandingQueue()
		{
			try
			{
				if (this.LandingQueue.Count<Aircraft>() != 0)
				{
					List<Aircraft> list = new List<Aircraft>();
					list.AddRange(this.LandingQueue);
					foreach (Aircraft current in list)
					{
						if (Information.IsNothing(current))
						{
							this.RemoveAircraftFromLandingQueue(current);
						}
						else if (current.IsNotActive())
						{
							this.RemoveAircraftFromLandingQueue(current);
						}
						if (current.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
						{
							this.RemoveAircraftFromLandingQueue(current);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100086", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x000BA748 File Offset: 0x000B8948
		public Aircraft method_10()
		{
			Aircraft aircraft = null;
			checked
			{
				Aircraft result;
				try
				{
					AirFacility[] airFacilities = this.theUnit.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility = airFacilities[i];
						foreach (Aircraft current in airFacility.GetHostedAircrafts().Values)
						{
							if (current.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown)
							{
								aircraft = current;
								result = aircraft;
								return result;
							}
						}
					}
					aircraft = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100087", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					aircraft = null;
					ProjectData.ClearProjectError();
				}
				result = aircraft;
				return result;
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000BA834 File Offset: 0x000B8A34
		public void method_11()
		{
			try
			{
				if (!this.theUnit.IsGroup || this.theUnit.HasRunwaysOrLandingPads())
				{
					for (int i = this.theUnit.GetAirFacilities().Length - 1; i >= 0; i += -1)
					{
						AirFacility airFacility = this.theUnit.GetAirFacilities()[i];
						if (airFacility.IsRunwayAccessPointOrElevator())
						{
							using (IEnumerator<Aircraft> enumerator = airFacility.GetHostedAircrafts().Values.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TaxyingToPark)
									{
										return;
									}
								}
							}
						}
					}
					int num = 0;
					for (int j = this.theUnit.GetAirFacilities().Length - 1; j >= 0; j += -1)
					{
						AirFacility airFacility = this.theUnit.GetAirFacilities()[j];
						if (airFacility.IsRunwayAccessPointOrElevator())
						{
							foreach (Aircraft current in airFacility.GetHostedAircrafts().Values)
							{
								if (current.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff || current.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
								{
									current.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.TaxyingToPark);
									num++;
									if (num >= airFacility.GetHostedAircrafts().Values.Count)
									{
										return;
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
				ex2.Data.Add("Error at 100088", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x000BAA44 File Offset: 0x000B8C44
		public void ScheduleEmergencyLandingEvent()
		{
			checked
			{
				if (this.LandingQueue.Count<Aircraft>() != 0)
				{
					try
					{
						Aircraft[] landingQueue = this.LandingQueue.Where(ActiveUnit_AirOps.AircraftFunc1).OrderBy(ActiveUnit_AirOps.AircraftFunc2).ToArray<Aircraft>();
						this.LandingQueue = landingQueue;
						Aircraft[] landingQueue2 = this.LandingQueue;
						for (int i = 0; i < landingQueue2.Length; i++)
						{
							Aircraft aircraft = landingQueue2[i];
							if ((float)aircraft.GetAircraftKinematics().GetTimeToBingoFuel(true) >= unchecked(20f / aircraft.GetCurrentSpeed() * 3600f + 180f))
							{
								break;
							}
							aircraft.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.EmergencyLanding);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200113", "");
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

		// Token: 0x06001D30 RID: 7472 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual  bool vmethod_6(bool bool_0, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, bool bool_1, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1, bool bool_2, bool bool_3)
		{
			return false;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000BAB30 File Offset: 0x000B8D30
		public void RepairAircraft(ref Aircraft aircraft_)
		{
			int estimatedRepairTimeInSeconds = aircraft_.GetAircraftAirOps().GetEstimatedRepairTimeInSeconds();
			if (estimatedRepairTimeInSeconds > 0)
			{
				aircraft_.LogMessage(string.Concat(new string[]
				{
					aircraft_.Name,
					" (",
					aircraft_.UnitClass,
					")有毁伤大约需要",
					Misc.GetTimeString((long)estimatedRepairTimeInSeconds, Aircraft_AirOps._Maintenance.const_0, false, false),
					"进行修复。修复时间将累加到飞机的出动准备时间中。"
				}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null)));
			}
			aircraft_.GetAircraftDamage().SetFireIntensityLevel(ActiveUnit_Damage.FireIntensityLevel.NoFire);
			aircraft_.SetDamagePts(false, (float)aircraft_.GetInitialDP());
			using (IEnumerator<PlatformComponent> enumerator = aircraft_.GetAllPlatformComponents().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.vmethod_8();
				}
			}
			Aircraft_AirOps aircraftAirOps;
			(aircraftAirOps = aircraft_.GetAircraftAirOps()).SetConditionTimer(aircraftAirOps.GetConditionTimer() + (float)estimatedRepairTimeInSeconds);
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000BAC40 File Offset: 0x000B8E40
		public void RefuelAircraft(ref Aircraft aircraft_1)
		{
			checked
			{
				try
				{
					FuelRec[] fuelRecs = aircraft_1.GetFuelRecs();
					for (int i = 0; i < fuelRecs.Length; i++)
					{
						FuelRec fuelRec = fuelRecs[i];
						fuelRec.CurrentQuantity = (float)fuelRec.MaxQuantity;
					}
					aircraft_1.GetAircraftKinematics().SetBingoJokerFuel();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100090", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000BACD4 File Offset: 0x000B8ED4
		public bool method_15(ref Aircraft aircraft_1, Loadout loadout_0, int int_0, bool bool_0)
		{
			bool flag = true;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			bool result = false;
			checked
			{
				try
				{
					WeaponRec[] weaponRecArray = loadout_0.WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						WeaponRec weaponRec = weaponRecArray[i];
						int weapID = weaponRec.WeapID;
						if (!Weapon.IsNotLaunchableFireWeapon(weaponRec.WeapID, ref this.theUnit.m_Scenario))
						{
							int maxLoad = weaponRec.MaxLoad;
							if (dictionary.ContainsKey(weapID))
							{
								Dictionary<int, int> dictionary2;
								int key;
								(dictionary2 = dictionary)[key = weapID] = unchecked(dictionary2[key] + maxLoad);
							}
							else
							{
								dictionary.Add(weapID, maxLoad);
							}
						}
					}
					foreach (KeyValuePair<int, int> current in dictionary)
					{
						int weaponLoadsInMagazines = aircraft_1.GetAircraftAirOps().GetCurrentHostUnit().GetWeaponry().GetWeaponLoadsInMagazines(current.Key);
						if (current.Value > weaponLoadsInMagazines)
						{
							flag = false;
						}
					}
					result = flag;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100092", "");
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

		// Token: 0x06001D34 RID: 7476 RVA: 0x000BAE2C File Offset: 0x000B902C
		public string RearmAircraft(ref Aircraft aircraft_, int LoadoutDBID_, int int_1, bool bool_0, bool bool_1, bool LimitedBaseMags_, bool bool_3, bool bool_4)
		{
			string result = "";
			try
			{
				Aircraft_AirOps aircraftAirOps = aircraft_.GetAircraftAirOps();
				if (!Information.IsNothing(aircraft_.GetLoadout()) && !Information.IsNothing(aircraft_.GetLoadout().WeaponRecArray))
				{
					aircraftAirOps.method_65();
				}
				bool flag = true;
				checked
				{
					if (LoadoutDBID_ == 0)
					{
						if (bool_0)
						{
							aircraftAirOps.SetConditionTimer(0f);
						}
						else
						{
							aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
							if (aircraftAirOps.GetConditionTimer() < 1800f)
							{
								aircraftAirOps.SetConditionTimer(1800f);
							}
						}
					}
					else
					{
						aircraft_.SetLoadout(null);
						aircraft_.GetAircraftWeaponry().ClearWeapons();
						if (LimitedBaseMags_)
						{
							Loadout loadout = new Loadout(LoadoutDBID_, "tempLoadout", 1, 1, 1, 1, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.DayOnly, Loadout._WeatherProfile.None, 0f, 0, 0, false, bool_1, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.DayNight, Doctrine._WeaponState.LoadoutSetting);
							DBFunctions.smethod_49(ref aircraft_.m_Scenario, ref loadout, LoadoutDBID_, bool_1);
							if (!this.method_15(ref aircraft_, loadout, LoadoutDBID_, bool_1))
							{
								flag = false;
							}
							if (!bool_1 && !flag)
							{
								bool_1 = true;
								loadout = null;
								loadout = new Loadout(LoadoutDBID_, "tempLoadout", 1, 1, 1, 1, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.DayOnly, Loadout._WeatherProfile.None, 0f, 0, 0, false, true, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.DayNight, Doctrine._WeaponState.LoadoutSetting);
								DBFunctions.smethod_49(ref aircraft_.m_Scenario, ref loadout, LoadoutDBID_, true);
								if (!this.method_15(ref aircraft_, loadout, LoadoutDBID_, true))
								{
									flag = false;
								}
								else
								{
									flag = true;
									string str = "";
									if (Operators.CompareString(aircraft_.Name, aircraft_.UnitClass, false) != 0)
									{
										str = " (" + aircraft_.UnitClass + ")";
									}
									if (bool_3)
									{
										Interaction.MsgBox("飞机: " + aircraft_.Name + str + "重新装载时不带备选武器，备选武器数量不足", MsgBoxStyle.Information, "重新装载时不带备选武器!");
									}
									aircraft_.LogMessage("飞机: " + aircraft_.Name + str + "重新装载时不带备选武器，备选武器数量不足.", LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraftAirOps.GetCurrentHostUnit().GetLongitude(null), aircraftAirOps.GetCurrentHostUnit().GetLatitude(null)));
								}
							}
							if (flag)
							{
								WeaponRec[] weaponRecArray = loadout.WeaponRecArray;
								for (int i = 0; i < weaponRecArray.Length; i++)
								{
									WeaponRec weaponRec = weaponRecArray[i];
									int currentLoad = weaponRec.GetCurrentLoad();
									unchecked
									{
										for (int j = 1; j <= currentLoad; j++)
										{
											if (!Weapon.IsNotLaunchableFireWeapon(weaponRec.WeapID, ref this.theUnit.m_Scenario))
											{
												ActiveUnit_Weaponry weaponry = this.theUnit.GetWeaponry();
												int weapID = weaponRec.WeapID;
												float num = 0f;
												weaponry.vmethod_10(weapID, true, ref num);
											}
										}
									}
								}
							}
						}
					}
					Mount[] mounts = aircraft_.m_Mounts;
					for (int k = 0; k < mounts.Length; k++)
					{
						Mount mount = mounts[k];
						foreach (WeaponRec current in mount.GetWeaponRecCollection())
						{
							current.SetCurrentLoad(current.MaxLoad);
						}
					}
					if (flag)
					{
						DBFunctions.smethod_48(ref aircraft_, LoadoutDBID_, bool_1);
					}
					else
					{
						aircraft_.SetLoadout(DBFunctions.smethod_45(ref aircraft_.m_Scenario, aircraft_.DBID));
						if (Information.IsNothing(aircraft_.GetLoadout()))
						{
							aircraft_.SetLoadout(DBFunctions.smethod_46(ref aircraft_.m_Scenario, aircraft_.DBID));
						}
						aircraftAirOps.method_55(ref aircraftAirOps);
					}
				}
				if (bool_0)
				{
					aircraftAirOps.SetConditionTimer(0f);
				}
				else
				{
					Doctrine._AirOpsTempo? airOpsTempoDoctrine = aircraft_.m_Doctrine.GetAirOpsTempoDoctrine(aircraft_.m_Scenario, false, false, false, false);
					byte? b = airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && aircraftAirOps.GetConditionTimer() < (float)(aircraft_.GetLoadout().ReadyTime * 60) && !aircraftAirOps.QuickTurnaround_Enabled)
					{
						if (LoadoutDBID_ != int_1 || !bool_3)
						{
							aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
							aircraftAirOps.SetConditionTimer((float)(aircraft_.GetLoadout().ReadyTime * 60));
						}
					}
					else
					{
						airOpsTempoDoctrine = aircraft_.m_Doctrine.GetAirOpsTempoDoctrine(aircraft_.m_Scenario, false, false, false, false);
						b = (airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && aircraftAirOps.GetConditionTimer() < (float)(aircraft_.GetLoadout().int_3 * 60) && !aircraftAirOps.QuickTurnaround_Enabled)
						{
							if (LoadoutDBID_ != int_1 || !bool_3)
							{
								aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
								aircraftAirOps.SetConditionTimer((float)(aircraft_.GetLoadout().int_3 * 60));
							}
						}
						else if (aircraftAirOps.GetConditionTimer() < (float)(aircraft_.GetLoadout().QT_ReadyTime * 60) && aircraftAirOps.QuickTurnaround_Enabled && (LoadoutDBID_ != int_1 || !bool_3))
						{
							Doctrine._QuickTurnAround? quickTurnAroundDoctrine = aircraft_.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft_.m_Scenario, false, false, false, false);
							b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								aircraftAirOps.method_53(ref aircraftAirOps, ref aircraft_);
								string text = "";
								if (Operators.CompareString(aircraft_.Name, aircraft_.UnitClass, false) != 0)
								{
									text = " (" + aircraft_.UnitClass + ")";
								}
								aircraft_.LogMessage(string.Concat(new string[]
								{
									aircraft_.Name,
									text,
									"已飞行",
									Conversions.ToString(aircraftAirOps.QuickTurnaround_SortiesFlown),
									"波次，最多可飞行",
									Conversions.ToString(aircraft_.GetLoadout().QT_MaxSorties),
									"波次. 实际总留空时间为",
									Misc.GetTimeString((long)Math.Round((double)aircraftAirOps.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
									"，允许总留空时间为",
									Misc.GetTimeString((long)(aircraft_.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
									". 飞机挂载支持快速出动但是条令设置不允许进行快速出动，飞机退出!"
								}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraftAirOps.GetCurrentHostUnit().GetLongitude(null), aircraftAirOps.GetCurrentHostUnit().GetLatitude(null)));
								airOpsTempoDoctrine = aircraft_.m_Doctrine.GetAirOpsTempoDoctrine(aircraft_.m_Scenario, false, false, false, false);
								b = (airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
									aircraftAirOps.SetConditionTimer((float)(aircraft_.GetLoadout().ReadyTime * 60));
								}
								else
								{
									aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
									aircraftAirOps.SetConditionTimer((float)(aircraft_.GetLoadout().int_3 * 60));
								}
							}
							else
							{
								aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
								aircraftAirOps.SetConditionTimer((float)(aircraft_.GetLoadout().QT_ReadyTime * 60));
							}
						}
					}
					if (!bool_3 && aircraftAirOps.QuickTurnaround_Enabled)
					{
						Doctrine._QuickTurnAround? quickTurnAroundDoctrine = aircraft_.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft_.m_Scenario, false, false, false, false);
						b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							this.method_17(ref aircraftAirOps, ref aircraft_);
						}
						else
						{
							quickTurnAroundDoctrine = aircraft_.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft_.m_Scenario, false, false, false, false);
							b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								Loadout loadout2 = aircraft_.GetLoadout();
								if (loadout2.method_13() || loadout2.method_15() || loadout2.LoadoutRoleIsASWPatrol())
								{
									this.method_17(ref aircraftAirOps, ref aircraft_);
								}
							}
						}
					}
				}
				aircraft_.AbnTime = 0f;
				if (flag)
				{
					result = "OK";
				}
				else
				{
					string str2 = "";
					if (Operators.CompareString(aircraft_.Name, aircraft_.UnitClass, false) != 0)
					{
						str2 = " (" + aircraft_.UnitClass + ")";
					}
					if (bool_4)
					{
						if (bool_3)
						{
							Interaction.MsgBox("飞机: " + aircraft_.Name + str2 + "没有装备期望的挂载，这是由于存储该挂载的仓库不可用. 使用储备(空)挂载.", MsgBoxStyle.Information, "重新装载没有完成!");
						}
						aircraft_.LogMessage("飞机: " + aircraft_.Name + str2 + "没有装备期望的挂载，这是由于存储该挂载的仓库不可用. 使用储备(空)挂载.", LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraftAirOps.GetCurrentHostUnit().GetLongitude(null), aircraftAirOps.GetCurrentHostUnit().GetLatitude(null)));
					}
					result = "Incomplete";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100093", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000BB858 File Offset: 0x000B9A58
		public void method_17(ref Aircraft_AirOps aircraft_AirOps_0, ref Aircraft aircraft_1)
		{
			if (aircraft_AirOps_0.QuickTurnaround_SortiesFlown == 1)
			{
				Doctrine._AirOpsTempo? airOpsTempoDoctrine = aircraft_1.m_Doctrine.GetAirOpsTempoDoctrine(aircraft_1.m_Scenario, false, false, false, false);
				byte? b = airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					aircraft_AirOps_0.QuickTurnaround_TimePentalty += aircraft_1.GetLoadout().int_3;
				}
				else
				{
					aircraft_AirOps_0.QuickTurnaround_TimePentalty += aircraft_1.GetLoadout().ReadyTime;
				}
			}
			else
			{
				aircraft_AirOps_0.QuickTurnaround_TimePentalty += aircraft_1.GetLoadout().QT_AdditionalTimePenalty;
			}
			DateTime currentTime = aircraft_1.m_Scenario.GetCurrentTime(false);
			bool bool_ = aircraft_1.m_Scenario.IsUseDaylightSavingTime();
			string daylightSavingTime_Start = aircraft_1.m_Scenario.GetDaylightSavingTime_Start();
			string daylightSavingTime_End = aircraft_1.m_Scenario.GetDaylightSavingTime_End();
			Weather._TimeOfDay timeOfDay = Class240.GetTimeOfDay(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second, aircraft_AirOps_0.GetCurrentHostUnit().GetLatitude(null), aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), (double)aircraft_AirOps_0.GetCurrentHostUnit().GetCurrentAltitude_ASL(false));
			if (aircraft_AirOps_0.QuickTurnaround_SortiesFlown >= aircraft_AirOps_0.QuickTurnaround_SortiesTotal)
			{
				aircraft_AirOps_0.method_53(ref aircraft_AirOps_0, ref aircraft_1);
			}
			else if ((double)(aircraft_1.GetLoadout().QT_AirborneTime * 60) / (double)aircraft_AirOps_0.QuickTurnaround_SortiesTotal <= (double)(aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown / (float)aircraft_AirOps_0.QuickTurnaround_SortiesFlown))
			{
				if (aircraft_AirOps_0.QuickTurnaround_SortiesFlown <= aircraft_AirOps_0.QuickTurnaround_SortiesTotal && aircraft_AirOps_0.QuickTurnaround_SortiesFlown > 0)
				{
					float num = aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown / (float)aircraft_AirOps_0.QuickTurnaround_SortiesFlown;
					if (num + aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown > (float)(aircraft_1.GetLoadout().QT_AirborneTime * 60) && !Information.IsNothing(aircraft_1.GetLoadout()))
					{
						string text = "";
						if (Operators.CompareString(aircraft_1.Name, aircraft_1.UnitClass, false) != 0)
						{
							text = " (" + aircraft_1.UnitClass + ")";
						}
						aircraft_1.LogMessage(string.Concat(new string[]
						{
							aircraft_1.Name,
							text,
							"已经飞行",
							Conversions.ToString(aircraft_AirOps_0.QuickTurnaround_SortiesFlown),
							"波次,最大飞行波次",
							Conversions.ToString(aircraft_1.GetLoadout().QT_MaxSorties),
							".总留空时间：",
							Misc.GetTimeString((long)Math.Round((double)aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
							"，允许留空时间：",
							Misc.GetTimeString((long)(aircraft_1.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
							". 所有完成波次的平均留空时间为：",
							Misc.GetTimeString((long)Math.Round((double)num), Aircraft_AirOps._Maintenance.const_0, false, false),
							"，大于剩余允许的留空时间，这是因为飞机需要解除战备状态."
						}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), aircraft_AirOps_0.GetCurrentHostUnit().GetLatitude(null)));
						aircraft_AirOps_0.method_53(ref aircraft_AirOps_0, ref aircraft_1);
					}
				}
			}
			else if (aircraft_1.GetLoadout().QT_TimeofDay == Loadout._LoadoutDayNight.DayOnly && timeOfDay == Weather._TimeOfDay.Night)
			{
				string text2 = "";
				if (Operators.CompareString(aircraft_1.Name, aircraft_1.UnitClass, false) != 0)
				{
					text2 = " (" + aircraft_1.UnitClass + ")";
				}
				aircraft_1.LogMessage(string.Concat(new string[]
				{
					aircraft_1.Name,
					text2,
					"已经飞行",
					Conversions.ToString(aircraft_AirOps_0.QuickTurnaround_SortiesFlown),
					"波次,最大飞行波次",
					Conversions.ToString(aircraft_1.GetLoadout().QT_MaxSorties),
					". 总留空时间：",
					Misc.GetTimeString((long)Math.Round((double)aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
					" 允许留空时间：",
					Misc.GetTimeString((long)(aircraft_1.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					". 该挂载方案只支持日间快速出动，现在是夜间.为此，该飞机需要解除战备状态."
				}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), aircraft_AirOps_0.GetCurrentHostUnit().GetLatitude(null)));
				aircraft_AirOps_0.method_53(ref aircraft_AirOps_0, ref aircraft_1);
			}
			else if (aircraft_1.GetLoadout().QT_TimeofDay == Loadout._LoadoutDayNight.NightOnly && timeOfDay == Weather._TimeOfDay.Day)
			{
				string text3 = "";
				if (Operators.CompareString(aircraft_1.Name, aircraft_1.UnitClass, false) != 0)
				{
					text3 = " (" + aircraft_1.UnitClass + ")";
				}
				aircraft_1.LogMessage(string.Concat(new string[]
				{
					aircraft_1.Name,
					text3,
					"已飞行",
					Conversions.ToString(aircraft_AirOps_0.QuickTurnaround_SortiesFlown),
					"波次,最大飞行波次:",
					Conversions.ToString(aircraft_1.GetLoadout().QT_MaxSorties),
					" 总留空时间",
					Misc.GetTimeString((long)Math.Round((double)aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
					" 允许留空时间",
					Misc.GetTimeString((long)(aircraft_1.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					".该挂载方案只支持日间快速出动，现在是夜间.为此，该飞机需要解除战备状态."
				}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), aircraft_AirOps_0.GetCurrentHostUnit().GetLatitude(null)));
				aircraft_AirOps_0.method_53(ref aircraft_AirOps_0, ref aircraft_1);
			}
			else
			{
				bool arg_63E_0;
				if (aircraft_1.GetLoadout().QT_TimeofDay != Loadout._LoadoutDayNight.DayOnly)
				{
					if (aircraft_1.GetLoadout().QT_TimeofDay != Loadout._LoadoutDayNight.NightOnly)
					{
						arg_63E_0 = true;
						goto IL_63E;
					}
				}
				arg_63E_0 = (timeOfDay != Weather._TimeOfDay.DawnOrDusk);
				IL_63E:
				if (!arg_63E_0)
				{
					if (aircraft_1.GetLoadout().QT_TimeofDay == Loadout._LoadoutDayNight.NightOnly && Misc.GetLocalTime(currentTime, aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), bool_, daylightSavingTime_Start, daylightSavingTime_End).Hour < 12)
					{
						string text4 = "";
						if (Operators.CompareString(aircraft_1.Name, aircraft_1.UnitClass, false) != 0)
						{
							text4 = " (" + aircraft_1.UnitClass + ")";
						}
						aircraft_1.LogMessage(string.Concat(new string[]
						{
							aircraft_1.Name,
							text4,
							"已经飞机了",
							Conversions.ToString(aircraft_AirOps_0.QuickTurnaround_SortiesFlown),
							"波次,最大飞行波次：",
							Conversions.ToString(aircraft_1.GetLoadout().QT_MaxSorties),
							"，总留空时间：",
							Misc.GetTimeString((long)Math.Round((double)aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
							"，允许留空时间：",
							Misc.GetTimeString((long)(aircraft_1.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
							". 挂载仅支持白天快速出动，现在是黄昏，因此飞机将暂时退出."
						}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), aircraft_AirOps_0.GetCurrentHostUnit().GetLatitude(null)));
						aircraft_AirOps_0.method_53(ref aircraft_AirOps_0, ref aircraft_1);
					}
					else if (aircraft_1.GetLoadout().QT_TimeofDay == Loadout._LoadoutDayNight.DayOnly && Misc.GetLocalTime(currentTime, aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), bool_, daylightSavingTime_Start, daylightSavingTime_End).Hour > 12)
					{
						string text5 = "";
						if (Operators.CompareString(aircraft_1.Name, aircraft_1.UnitClass, false) != 0)
						{
							text5 = " (" + aircraft_1.UnitClass + ")";
						}
						aircraft_1.LogMessage(string.Concat(new string[]
						{
							aircraft_1.Name,
							text5,
							"已经飞行",
							Conversions.ToString(aircraft_AirOps_0.QuickTurnaround_SortiesFlown),
							"波次,最大飞行波次",
							Conversions.ToString(aircraft_1.GetLoadout().QT_MaxSorties),
							"总留空时间：",
							Misc.GetTimeString((long)Math.Round((double)aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
							"，允许留空时间：",
							Misc.GetTimeString((long)(aircraft_1.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
							".挂载仅支持白天快速出动，现在是黄昏，因此飞机将暂时退出."
						}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(aircraft_AirOps_0.GetCurrentHostUnit().GetLongitude(null), aircraft_AirOps_0.GetCurrentHostUnit().GetLatitude(null)));
						aircraft_AirOps_0.method_53(ref aircraft_AirOps_0, ref aircraft_1);
					}
					else
					{
						aircraft_AirOps_0.method_54(ref aircraft_AirOps_0, ref aircraft_1);
					}
				}
				else
				{
					aircraft_AirOps_0.method_54(ref aircraft_AirOps_0, ref aircraft_1);
				}
			}
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000BC1A8 File Offset: 0x000BA3A8
		public virtual bool CanBeHostedOnAirFacility(Aircraft aircraft_)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.theUnit.IsShip)
				{
					Ship._ShipCategory category = ((Ship)this.theUnit).Category;
					if (category == Ship._ShipCategory.MobileOffshoreBase_AviationCapable)
					{
						flag = true;
						result = true;
						return result;
					}
					if (aircraft_.Category == Aircraft._AircraftCategory.FixedWing_CarrierCapable && category != Ship._ShipCategory.SurfaceCombatant && aircraft_.aircraftSizeClass > GlobalVariables.AircraftSizeClass.Small)
					{
						flag = false;
						result = false;
						return result;
					}
					if (aircraft_.RunwayLengthCode == GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL && !aircraft_.IsRotaryWingAircraft() && aircraft_.aircraftSizeClass != GlobalVariables.AircraftSizeClass.Small && category != Ship._ShipCategory.SurfaceCombatant)
					{
						flag = false;
						result = false;
						return result;
					}
					if (aircraft_.Category == Aircraft._AircraftCategory.FixedWing && aircraft_.RunwayLengthCode != GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL)
					{
						flag = false;
						result = false;
						return result;
					}
				}
				for (int i = this.theUnit.GetAirFacilities().Length - 1; i >= 0; i += -1)
				{
					AirFacility airFacility = this.theUnit.GetAirFacilities()[i];
					if (airFacility.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && airFacility.IsHangarOrOpenParking() && !airFacility.IsTakeOffOrLandingFacility() && airFacility.method_40(aircraft_))
					{
						flag = true;
						result = true;
						return result;
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100095", "");
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

		// Token: 0x06001D37 RID: 7479 RVA: 0x000BC340 File Offset: 0x000BA540
		public void method_18(Aircraft aircraft_1, bool bool_0)
		{
			checked
			{
				try
				{
					if (!this.theUnit.GetAirOps().GetHostedAircrafts().Contains(aircraft_1))
					{
						AirFacility airFacility = this.method_19(aircraft_1);
						if (Information.IsNothing(airFacility))
						{
							if (!bool_0)
							{
								Interaction.MsgBox("Aircraft parking facilities on " + this.theUnit.Name + " are overfilled. Please contact the scenario author and ask to have the number of aircraft reduced to match the actual parking capacity.", MsgBoxStyle.OkOnly, null);
							}
							AirFacility[] airFacilities = this.theUnit.GetAirFacilities();
							for (int i = 0; i < airFacilities.Length; i++)
							{
								AirFacility airFacility2 = airFacilities[i];
								if (airFacility2.IsHangarOrOpenParking())
								{
									airFacility = airFacility2;
									break;
								}
							}
						}
						aircraft_1.GetAircraftAirOps().SetHostAirFacility(airFacility);
						aircraft_1.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
						aircraft_1.GetAircraftAirOps().SetAssignedHostUnit(false, this.theUnit);
						aircraft_1.GetAircraftAirOps().SetCurrentHostUnit(this.theUnit);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100097", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000BC460 File Offset: 0x000BA660
		public AirFacility method_19(Aircraft aircraft_1)
		{
			AirFacility airFacility = null;
			checked
			{
				AirFacility result;
				try
				{
					List<AirFacility> list = new List<AirFacility>();
					AirFacility[] airFacilities = this.theUnit.GetAirFacilities();
					for (int i = 0; i < airFacilities.Length; i++)
					{
						AirFacility airFacility2 = airFacilities[i];
						if (airFacility2.IsHangarOrOpenParking() && airFacility2.method_40(aircraft_1) && airFacility2.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							list.Add(airFacility2);
						}
					}
					if (list.Count > 0)
					{
						IEnumerable<AirFacility> source;
						if (this.theUnit.IsShip)
						{
							Ship._ShipCategory category = ((Ship)this.theUnit).Category;
							if ((category == Ship._ShipCategory.SurfaceCombatant || category == Ship._ShipCategory.SurfaceCombatant_AviationCapable || category == Ship._ShipCategory.MobileOffshoreBase_AviationCapable) && aircraft_1.GetAircraftAirOps().GetConditionTimer() < 60f && !Information.IsNothing(aircraft_1.GetLoadout()) && aircraft_1.GetLoadout().loadoutRole != Loadout.LoadoutRole.Reserve && aircraft_1.GetLoadout().loadoutRole != Loadout.LoadoutRole.Unavailable)
							{
								source = list.OrderByDescending(ActiveUnit_AirOps.AirFacilityFunc3).ThenBy(ActiveUnit_AirOps.AirFacilityFunc4);
								if ((double)source.ElementAtOrDefault(0).method_39() / (double)source.ElementAtOrDefault(0).GetAircraftSizeClass() > 4.0)
								{
									airFacility = source.ElementAtOrDefault(0);
									result = airFacility;
									return result;
								}
							}
						}
						source = list.OrderBy(ActiveUnit_AirOps.AirFacilityFunc5).ThenBy(ActiveUnit_AirOps.AirFacilityFunc6);
						airFacility = source.ElementAtOrDefault(0);
					}
					else
					{
						airFacility = null;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100099", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					airFacility = null;
					ProjectData.ClearProjectError();
				}
				result = airFacility;
				return result;
			}
		}

		// Token: 0x04000CE8 RID: 3304
		public static Func<Aircraft, bool> AircraftFunc0 = (Aircraft aircraft_0) => ActiveUnit_AirOps.imethod_0(aircraft_0);

		// Token: 0x04000CE9 RID: 3305
		public static Func<Aircraft, bool> AircraftFunc1 = (Aircraft aircraft_0) => !Information.IsNothing(aircraft_0);

		// Token: 0x04000CEA RID: 3306
		public static Func<Aircraft, long> AircraftFunc2 = (Aircraft aircraft_0) => aircraft_0.GetAircraftKinematics().GetTimeToBingoFuel(false);

		// Token: 0x04000CEB RID: 3307
		public static Func<AirFacility, string> AirFacilityFunc3 = (AirFacility airFacility_0) => airFacility_0.method_27();

		// Token: 0x04000CEC RID: 3308
		public static Func<AirFacility, int> AirFacilityFunc4 = (AirFacility airFacility_0) => airFacility_0.method_39();

		// Token: 0x04000CED RID: 3309
		public static Func<AirFacility, string> AirFacilityFunc5 = (AirFacility airFacility_0) => airFacility_0.method_27();

		// Token: 0x04000CEE RID: 3310
		public static Func<AirFacility, int> AirFacilityFunc6 = (AirFacility airFacility_0) => airFacility_0.method_39();

		// Token: 0x04000CEF RID: 3311
		protected ActiveUnit theUnit;

		// Token: 0x04000CF0 RID: 3312
		protected Aircraft[] LandingQueue;

		// Token: 0x04000CF1 RID: 3313
		protected string[] aircraftsToLanding;
	}
}
