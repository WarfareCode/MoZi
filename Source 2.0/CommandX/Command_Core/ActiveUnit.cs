using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 活动单元类
	public abstract class ActiveUnit : Unit
	{
		// Token: 0x06000A0C RID: 2572 RVA: 0x0006FBFC File Offset: 0x0006DDFC
		[CompilerGenerated]
		public virtual ObservableCollection<Engine> GetEngines()
		{
			return this.m_EngineCollection;
		}

		// Token: 设置引擎
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void SetEngines(ObservableCollection<Engine> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.EngineCollection_CollectionChanged);
			ObservableCollection<Engine> engineCollection = this.m_EngineCollection;
			if (engineCollection != null)
			{
				engineCollection.CollectionChanged -= value;
			}
			this.m_EngineCollection = observableCollection_1;
			engineCollection = this.m_EngineCollection;
			if (engineCollection != null)
			{
				engineCollection.CollectionChanged += value;
			}
		}

		// Token: 取纬度
		public double? GetLatitudeLR()
		{
			if (!this.LatitudeLR.HasValue)
			{
				this.LatitudeLR = new double?(this.GetLatitude(null));
			}
			return this.LatitudeLR;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0000947A File Offset: 0x0000767A
		public void SetLatitudeLR(double? value)
		{
			this.LatitudeLR = value;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0006FC9C File Offset: 0x0006DE9C
		public double? GetLongitudeLR()
		{
			if (!this.LongitudeLR.HasValue)
			{
				this.LongitudeLR = new double?(this.GetLongitude(null));
			}
			return this.LongitudeLR;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00009483 File Offset: 0x00007683
		public void SetLongitudeLR(double? value)
		{
			this.LongitudeLR = value;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsActiveUnit()
		{
			return true;
		}

		// Token: 生成随机数
		public Random GetRandom()
		{
			if (Information.IsNothing(this.random))
			{
				this.random = GameGeneral.GetRandom();
			}
			return this.random;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0006FD08 File Offset: 0x0006DF08
		public int GetInitialDP()
		{
			return this.InitialDP;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0000948C File Offset: 0x0000768C
		public void SetInitialDP(int value)
		{
			this.InitialDP = value;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0006FD20 File Offset: 0x0006DF20
		public override double GetLongitude(bool? _HintIsOperating = null)
		{
			bool flag;
			if (_HintIsOperating.HasValue)
			{
				flag = _HintIsOperating.Value;
			}
			else
			{
				flag = this.IsOperating();
			}
			double result;
			if (flag)
			{
				result = base.GetLongitude(null);
			}
			else
			{
				ActiveUnit currentHostUnit = this.GetDockingOps().GetCurrentHostUnit();
				if (Information.IsNothing(currentHostUnit))
				{
					if (!Debugger.IsAttached)
					{
					}
					result = 0.0;
				}
				else
				{
					result = currentHostUnit.GetLongitude(null);
				}
			}
			return result;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0006FDB0 File Offset: 0x0006DFB0
		public override void SetLongitude(bool? _HintIsOperating, double value)
		{
			base.SetLongitude(null, value);
			this.GetDockingOps().method_4();
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0006FDD8 File Offset: 0x0006DFD8
		public override double GetLatitude(bool? _HintIsOperating = null)
		{
			bool flag;
			if (_HintIsOperating.HasValue)
			{
				flag = _HintIsOperating.Value;
			}
			else
			{
				flag = this.IsOperating();
			}
			double result;
			if (flag)
			{
				result = base.GetLatitude(null);
			}
			else
			{
				ActiveUnit currentHostUnit = this.GetDockingOps().GetCurrentHostUnit();
				if (Information.IsNothing(currentHostUnit))
				{
					if (!Debugger.IsAttached)
					{
					}
					result = 0.0;
				}
				else
				{
					result = currentHostUnit.GetLatitude(null);
				}
			}
			return result;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0006FE68 File Offset: 0x0006E068
		public override void SetLatitude(bool? _HintIsOperating, double value)
		{
			base.SetLatitude(null, value);
			this.GetDockingOps().method_4();
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0006FE90 File Offset: 0x0006E090
		public override float GetCurrentHeading()
		{
			return base.GetCurrentHeading();
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00009495 File Offset: 0x00007695
		public override void SetCurrentHeading(float value)
		{
			base.SetCurrentHeading(value);
			this.GetDockingOps().method_4();
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0006FEA8 File Offset: 0x0006E0A8
		public virtual GlobalVariables.ProficiencyLevel? GetProficiencyLevel()
		{
			GlobalVariables.ProficiencyLevel? result;
			if (Information.IsNothing(this.m_ProficiencyLevel))
			{
				result = new GlobalVariables.ProficiencyLevel?(this.GetSide(false).GetProficiencyLevel());
			}
			else
			{
				result = new GlobalVariables.ProficiencyLevel?(this.m_ProficiencyLevel.Value);
			}
			return result;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000094A9 File Offset: 0x000076A9
		public virtual void SetProficiencyLevel(GlobalVariables.ProficiencyLevel? value)
		{
			this.m_ProficiencyLevel = value;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
		public virtual bool IsMoving()
		{
			bool flag;
			bool result;
			if (this.IsOperating())
			{
				flag = true;
			}
			else
			{
				ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.GetDockingOps().GetDockingOpsCondition();
				if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Docked && dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Readying)
				{
					result = true;
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0006FF38 File Offset: 0x0006E138
		public virtual string GetUnitTypeName()
		{
			string result;
			if (string.IsNullOrEmpty(this.strUnitType))
			{
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					this.strUnitType = "Aircraft";
					result = this.strUnitType;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					this.strUnitType = "Ship";
					result = this.strUnitType;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					this.strUnitType = "Submarine";
					result = this.strUnitType;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					this.strUnitType = "Facility";
					result = this.strUnitType;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					this.strUnitType = "Weapon";
					result = this.strUnitType;
					return result;
				case GlobalVariables.ActiveUnitType.Satellite:
					this.strUnitType = "Satellite";
					result = this.strUnitType;
					return result;
				}
				if (!Debugger.IsAttached)
				{
					throw new NotImplementedException();
				}
				Debugger.Break();
			}
			result = this.strUnitType;
			return result;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0007001C File Offset: 0x0006E21C
		public ReadOnlyCollection<XSection> GetXSections()
		{
			if (Information.IsNothing(this.m_XSections))
			{
				string key = this.GetUnitTypeName() + "_" + Conversions.ToString(this.DBID);
				if (this.m_Scenario.Cache_XSections.ContainsKey(key))
				{
					this.m_XSections = this.m_Scenario.Cache_XSections[key];
				}
				else
				{
					DBFunctions.LoadPlatformSignaturesData(this, ref this.m_XSections, this.DBID);
					this.m_Scenario.Cache_XSections.TryAdd(key, this.m_XSections);
				}
			}
			return this.m_XSections.AsReadOnly();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.None;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000700BC File Offset: 0x0006E2BC
		public virtual int GetUnitTypeID()
		{
			switch (this.GetUnitType())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
			{
				int num = DBFunctions.GetAircraftType(ref this.m_Scenario, this.DBID);
				int result = num;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Ship:
			{
				int num = DBFunctions.GetShipType(ref this.m_Scenario, this.DBID);
				int result = num;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Submarine:
			{
				int num = DBFunctions.GetSubmarineType(ref this.m_Scenario, this.DBID);
				int result = num;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Facility:
			{
				int num = DBFunctions.GetFacilityCategory(ref this.m_Scenario, this.DBID);
				int result = num;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Weapon:
			{
				int num = DBFunctions.GetWeaponType(ref this.m_Scenario, this.DBID);
				int result = num;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Satellite:
			{
				int num = DBFunctions.GetSatelliteType(ref this.m_Scenario, this.DBID);
				int result = num;
				return result;
			}
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00070194 File Offset: 0x0006E394
		public virtual string GetUnitTypeDescription()
		{
			switch (this.GetUnitType())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
			{
				string text = DBFunctions.GetAircraftTypeDescription(ref this.m_Scenario, this.DBID);
				string result = text;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Ship:
			{
				string text = DBFunctions.GetShipTypeDescription(ref this.m_Scenario, this.DBID);
				string result = text;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Submarine:
			{
				string text = DBFunctions.GeSubmarineTypeDescription(ref this.m_Scenario, this.DBID);
				string result = text;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Facility:
			{
				string text = DBFunctions.GetFacilityTypeDescription(ref this.m_Scenario, this.DBID);
				string result = text;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Weapon:
			{
				string text = DBFunctions.GetWeaponTypeDescription(ref this.m_Scenario, this.DBID);
				string result = text;
				return result;
			}
			case GlobalVariables.ActiveUnitType.Satellite:
			{
				string text = DBFunctions.GetSatelliteTypeDescription(ref this.m_Scenario, this.DBID);
				string result = text;
				return result;
			}
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0007026C File Offset: 0x0006E46C
		public bool method_61()
		{
			GlobalVariables.ActiveUnitType unitType = this.GetUnitType();
			bool result;
			bool flag;
			if (unitType == GlobalVariables.ActiveUnitType.Facility)
			{
				Facility._FacilityCategory category = ((Facility)this).Category;
				if (category - Facility._FacilityCategory.Runway > 2 && category - Facility._FacilityCategory.Building_Bunker > 1 && category != Facility._FacilityCategory.AirBase)
				{
					result = false;
					return result;
				}
				flag = true;
			}
			else
			{
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000094B2 File Offset: 0x000076B2
		public bool IsDetected(Side side_)
		{
			return this.IsAutoDetectable(side_);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000094BB File Offset: 0x000076BB
		public bool HasAssignedPatrolMission()
		{
			return !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).IsActive() && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000094EB File Offset: 0x000076EB
		public bool HasAssignedStrikeMission()
		{
			return !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).IsActive() && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0000951B File Offset: 0x0000771B
		public bool HasAssignedMiningMission()
		{
			return !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).IsActive() && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0000954B File Offset: 0x0000774B
		public bool HasAssignedMineClearingMission()
		{
			return !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).IsActive() && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0000957B File Offset: 0x0000777B
		public bool HasAssignedCargoMission()
		{
			return !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).IsActive() && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Cargo;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool IsMineSweeper()
		{
			return false;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool HasNavalMineLayingLoadout()
		{
			return false;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual ActiveUnit._ActiveUnitFuelState GetFuelState(GeoPoint geoPoint_0)
		{
			return ActiveUnit._ActiveUnitFuelState.None;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000702D0 File Offset: 0x0006E4D0
		public virtual ActiveUnit._ActiveUnitFuelState GetActiveUnitFuelState(ActiveUnit activeUnit_, GeoPoint geoPoint_0)
		{
			ActiveUnit._ActiveUnitFuelState result = ActiveUnit._ActiveUnitFuelState.None;
			try
			{
				if (this.GetTimeToBurnOut(ActiveUnit.Throttle.Cruise, null, null, null) <= 900L)
				{
					result = ActiveUnit._ActiveUnitFuelState.IsBingo;
				}
				else
				{
					float num;
					if (Information.IsNothing(geoPoint_0))
					{
						num = base.GetHorizontalRange(activeUnit_);
					}
					else
					{
						float num2 = activeUnit_.HorizontalRangeTo(geoPoint_0);
						num = base.HorizontalRangeTo(geoPoint_0) + num2;
					}
					if ((double)this.GetKinematics().vmethod_20(true, null, null) >= (double)num * 1.1)
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else
					{
						result = ActiveUnit._ActiveUnitFuelState.IsBingo;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101183", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000703C4 File Offset: 0x0006E5C4
		public virtual Weather.WeatherProfile GetWeatherProfile()
		{
			Scenario.WeatherModellingLevel weatherLevel = this.m_Scenario.WeatherLevel;
			if (weatherLevel != Scenario.WeatherModellingLevel.Level0)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw new NotImplementedException();
			}
			return Weather.GetWeatherProfile(this.m_Scenario, this.GetLatitude(null), this.GetLongitude(null), (int)Math.Round((double)this.GetCurrentAltitude_ASL(false)));
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00070434 File Offset: 0x0006E634
		public virtual float GetDamagePts(bool ScenEditAction = false)
		{
			return this.DamagePts;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0007044C File Offset: 0x0006E64C
		public virtual void SetDamagePts(bool ScenEditAction, float value)
		{
			try
			{
				bool flag = this.DamagePts != value;
				float damagePts = this.GetDamage().GetDamagePts();
				float damagePts2 = this.DamagePts;
				if (this.IsFacility && !Information.IsNothing(this.GetAirFacilities()) && this.GetAirFacilities().Where(ActiveUnit.AirFacilityFunc).Any<AirFacility>())
				{
					value = Math.Max(1f, value);
				}
				this.DamagePts = value;
				float damagePts3 = this.GetDamage().GetDamagePts();
				if (!ScenEditAction)
				{
					if (this.DamagePts <= 0f && damagePts2 > 0f)
					{
						if (this.IsShip)
						{
							((Ship)this).method_140(damagePts);
						}
						else
						{
							this.m_Scenario.RemoveUnit(this);
						}
					}
					if ((!this.IsShip || !((Ship)this).IsDestroyed()) && flag && value < damagePts2)
					{
						List<EventTrigger> list = new List<EventTrigger>();
						foreach (EventTrigger current in this.m_Scenario.GetEventTriggers().Values)
						{
							if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitDamaged && ((EventTrigger_UnitDamaged)current).method_11(this, damagePts, damagePts3))
							{
								list.Add(current);
							}
						}
						this.m_Scenario.TriggerEvents(list);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101184", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0007062C File Offset: 0x0006E82C
		public virtual ActiveUnit._ContrailDetected GetContrailDetected()
		{
			ActiveUnit._ContrailDetected contrailDetected;
			ActiveUnit._ContrailDetected result;
			if (this.GetCurrentAltitude_ASL(false) < 8000f)
			{
				contrailDetected = ActiveUnit._ContrailDetected.None;
			}
			else
			{
				if (this.IsWeapon)
				{
					if (this.GetEngines().Count > 0)
					{
						Engine._PropulsionType propulsionType = this.GetEngines()[0].PropulsionType;
						if (propulsionType <= Engine._PropulsionType.Nuclear)
						{
							if (propulsionType != Engine._PropulsionType.None && propulsionType != Engine._PropulsionType.Nuclear)
							{
								goto IL_92;
							}
						}
						else if (propulsionType != Engine._PropulsionType.Electric && propulsionType != Engine._PropulsionType.WeaponCoast)
						{
							goto IL_92;
						}
						result = ActiveUnit._ContrailDetected.None;
						return result;
					}
					result = ActiveUnit._ContrailDetected.None;
					return result;
				}
				IL_92:
				Weather._Atmosphere atmosphere = default(Weather._Atmosphere);
				Weather.smethod_2(Weather._AtmosphereType.const_5, (int)Math.Round((double)this.GetCurrentAltitude_ASL(false)), ref atmosphere, null);
				if (atmosphere.double_1 > 233.0)
				{
					contrailDetected = ActiveUnit._ContrailDetected.None;
				}
				else
				{
					switch (this.GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						contrailDetected = ActiveUnit._ContrailDetected.None;
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						contrailDetected = ActiveUnit._ContrailDetected.VerySmall;
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						contrailDetected = ActiveUnit._ContrailDetected.Small;
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						contrailDetected = ActiveUnit._ContrailDetected.Medium;
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						contrailDetected = ActiveUnit._ContrailDetected.Large;
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						contrailDetected = ActiveUnit._ContrailDetected.VeryLarge;
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
				}
			}
			result = contrailDetected;
			return result;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00070764 File Offset: 0x0006E964
		public override float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			return base.GetCurrentAltitude_ASL(false);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0007077C File Offset: 0x0006E97C
		public override void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			if (DoSanityCheck)
			{
				float maxAltitude = this.GetKinematics().GetMaxAltitude();
				float num = this.GetKinematics().GetMinAltitude();
				if (this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Sonobuoy)
				{
					num = (float)base.GetTerrainElevation(false, false, false);
				}
				if (value > maxAltitude)
				{
					value = maxAltitude - 1f;
				}
				if (value < num)
				{
					value = num + 1f;
				}
			}
			if (value != this.GetCurrentAltitude_ASL(false) && this.IsSubmarine)
			{
				((Submarine)this).SetEngine(null);
			}
			base.SetAltitude_ASL(false, value);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00070824 File Offset: 0x0006EA24
		public override Side GetSide(bool SetSideOnly = false)
		{
			checked
			{
				if (Information.IsNothing(this.m_Side))
				{
					Side[] sides = this.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (side.ActiveUnitArray.Contains(this) || Operators.CompareString(side.GetSideName(), this.strSide, false) == 0)
						{
							this.m_Side = side;
							break;
						}
					}
				}
				return this.m_Side;
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000708A0 File Offset: 0x0006EAA0
		public override void SetSide(bool SetSideOnly, Side value)
		{
			if (value != this.m_Side)
			{
				if (SetSideOnly)
				{
					if (!Information.IsNothing(this.m_Side))
					{
						ScenarioArrayUtil.RemoveActiveUnit(ref this.m_Side.ActiveUnitArray, this);
						if (this.HasParentGroup() && this.GetParentGroup(false).GetSide(false) != value)
						{
							this.GetParentGroup(false).GetUnitsInGroup().Remove(new KeyValuePair<string, ActiveUnit>(base.GetGuid(), this));
							this.SetParentGroup(false, null);
						}
						if (!Information.IsNothing(this.GetAssignedMission(false)))
						{
							this.DeleteMission(false, null);
						}
						ActiveUnit_AI aI = this.GetAI();
						ActiveUnit activeUnit = this;
						aI.ClearPrimaryTarget(ref activeUnit);
						this.GetAI().AddThreats();
					}
					if (!Information.IsNothing(value))
					{
						ScenarioArrayUtil.AddActiveUnit(ref value.ActiveUnitArray, this);
					}
				}
				this.m_Side = value;
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00070978 File Offset: 0x0006EB78
		public virtual Group GetParentGroup(bool UsingStrikePlanner = false)
		{
			return this.parentGroup;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00070990 File Offset: 0x0006EB90
		public virtual void SetParentGroup(bool UsingStrikePlanner, Group value)
		{
			bool flag;
			if (flag = (value != this.parentGroup))
			{
				Group group = this.parentGroup;
				if (!Information.IsNothing(group))
				{
					group.GetUnitsInGroup().Remove(base.GetGuid());
				}
				this.parentGroup = value;
				if (!Information.IsNothing(value))
				{
					value.GetUnitsInGroup().Add(base.GetGuid(), this);
				}
				if (!Information.IsNothing(value) && Information.IsNothing(value.m_Scenario))
				{
					value.m_Scenario = this.m_Scenario;
				}
				if (!UsingStrikePlanner && flag && !Information.IsNothing(value) && !this.IsGroupLead())
				{
					this.GetNavigator().ClearPlottedCourse();
					this.GetNavigator().method_46(this.GetLongitude(null), this.GetLatitude(null), false);
					this.GetNavigator().vmethod_3();
				}
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00070A78 File Offset: 0x0006EC78
		public virtual FuelRec[] GetFuelRecs()
		{
			return this.m_FuelRecs;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00070A90 File Offset: 0x0006EC90
		public virtual float GetDesiredHeading(ActiveUnit._TurnRate enum0_1)
		{
			return this.desiredHeading;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000095AB File Offset: 0x000077AB
		public virtual void SetDesiredHeading(ActiveUnit._TurnRate enum0_1, float value)
		{
			if (float.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.desiredHeading = value;
				if (!Information.IsNothing(enum0_1))
				{
					this.SetDesiredTurnRate(enum0_1);
				}
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00070AA8 File Offset: 0x0006ECA8
		public virtual float GetDesiredSpeed()
		{
			return this.desiredSpeed;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00070AC0 File Offset: 0x0006ECC0
		public virtual void SetDesiredSpeed(float value)
		{
			if (value > 0f)
			{
				float num = (float)this.GetKinematics().GetMaxSpeed();
				if (value > num)
				{
					value = num;
				}
			}
			float minSpeed = this.GetKinematics().GetMinSpeed(this.GetCurrentAltitude_ASL(false));
			if (value < minSpeed)
			{
				value = minSpeed;
			}
			this.desiredSpeed = value;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00070B1C File Offset: 0x0006ED1C
		public virtual float GetDesiredAltitude()
		{
			return this.desiredAltitude;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00070B34 File Offset: 0x0006ED34
		public virtual void SetDesiredAltitude(float value)
		{
			float maxAltitude = this.GetKinematics().GetMaxAltitude();
			if (value > maxAltitude)
			{
				value = maxAltitude;
			}
			value = (float)Math.Round((double)value, 2);
			this.desiredAltitude = value;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00070B6C File Offset: 0x0006ED6C
		public virtual float GetDesiredAltitude_TerrainFollowing()
		{
			return this.DesiredAltitude_TerrainFollowing;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00070B84 File Offset: 0x0006ED84
		public virtual void SetDesiredAltitude_TerrainFollowing(float value)
		{
			float maxAltitude = this.GetKinematics().GetMaxAltitude();
			if (value > maxAltitude)
			{
				value = maxAltitude;
			}
			value = (float)Math.Round((double)value, 2);
			this.DesiredAltitude_TerrainFollowing = value;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool IsTerrainFollowing(ActiveUnit activeUnit_0)
		{
			return false;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void SetIsTerrainFollowing(ActiveUnit activeUnit_0, bool bool_17)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00070BBC File Offset: 0x0006EDBC
		public virtual ActiveUnit._TurnRate GetDesiredTurnRate()
		{
			return this.DesiredTurnRate;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000095E4 File Offset: 0x000077E4
		public virtual void SetDesiredTurnRate(ActiveUnit._TurnRate value)
		{
			if (!Information.IsNothing(value))
			{
				this.DesiredTurnRate = value;
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00070BD4 File Offset: 0x0006EDD4
		public virtual Waypoint._TurnRate GetDesiredTurnRate_Navigation()
		{
			return this.desiredTurnRate_Navigation;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000095FA File Offset: 0x000077FA
		public virtual void SetDesiredTurnRate_Navigation(Waypoint._TurnRate TurnRate_)
		{
			if (!Information.IsNothing(TurnRate_))
			{
				this.desiredTurnRate_Navigation = TurnRate_;
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00070BEC File Offset: 0x0006EDEC
		public virtual ActiveUnit.Throttle GetMaxThrottleAvailable()
		{
			if (!this.m_Throttle.HasValue)
			{
				if (this.GetEngines().Count == 0)
				{
					this.m_Throttle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.FullStop);
				}
				else if (this.GetKinematics().HasFlankAltBand())
				{
					this.m_Throttle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Flank);
				}
				else if (this.GetKinematics().HasFullAltBand())
				{
					this.m_Throttle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Full);
				}
				else
				{
					this.m_Throttle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
			}
			return this.m_Throttle.Value;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00070C7C File Offset: 0x0006EE7C
		public virtual ActiveUnit.Throttle GetMinThrottleAvailable()
		{
			ActiveUnit.Throttle result;
			if (this.IsAircraft && !((Aircraft)this).IsRotaryWingAircraft())
			{
				result = ActiveUnit.Throttle.Loiter;
			}
			else
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			return result;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00070CAC File Offset: 0x0006EEAC
		public virtual ActiveUnit.Throttle GetThrottle()
		{
			return this.currentThrottle;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00070CC4 File Offset: 0x0006EEC4
		public virtual ActiveUnit_Navigator GetNavigator()
		{
			ActiveUnit_Navigator activeUnit_Navigator;
			ActiveUnit_Navigator result;
			if (Information.IsNothing(this.m_Navigator))
			{
				if (this.IsGroup)
				{
					activeUnit_Navigator = ((Group)this).GetNavigator();
					result = activeUnit_Navigator;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_Navigator = ((Aircraft)this).GetAircraftNavigator();
					result = activeUnit_Navigator;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_Navigator = ((Ship)this).GetShipNavigator();
					result = activeUnit_Navigator;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_Navigator = ((Submarine)this).GetSubmarineNavigator();
					result = activeUnit_Navigator;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_Navigator = ((Facility)this).GetFacilityNavigator();
					result = activeUnit_Navigator;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					activeUnit_Navigator = ((Weapon)this).GetWeaponNavigator();
					result = activeUnit_Navigator;
					return result;
				}
				ActiveUnit activeUnit = this;
				this.m_Navigator = new ActiveUnit_Navigator(ref activeUnit);
			}
			activeUnit_Navigator = this.m_Navigator;
			result = activeUnit_Navigator;
			return result;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00070D98 File Offset: 0x0006EF98
		public virtual ActiveUnit_AI GetAI()
		{
			ActiveUnit_AI activeUnit_AI;
			ActiveUnit_AI result;
			if (Information.IsNothing(this.m_AI))
			{
				if (this.IsGroup)
				{
					activeUnit_AI = ((Group)this).GetAI();
					result = activeUnit_AI;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_AI = ((Aircraft)this).GetAircraftAI();
					result = activeUnit_AI;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_AI = ((Ship)this).GetShipAI();
					result = activeUnit_AI;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_AI = ((Submarine)this).GetSubmarineAI();
					result = activeUnit_AI;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_AI = ((Facility)this).GetFacilityAI();
					result = activeUnit_AI;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					activeUnit_AI = ((Weapon)this).GetWeaponAI();
					result = activeUnit_AI;
					return result;
				}
				this.m_AI = new ActiveUnit_AI(this);
			}
			activeUnit_AI = this.m_AI;
			result = activeUnit_AI;
			return result;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00070E68 File Offset: 0x0006F068
		public virtual ActiveUnit_Kinematics GetKinematics()
		{
			ActiveUnit_Kinematics activeUnit_Kinematics;
			ActiveUnit_Kinematics result;
			if (Information.IsNothing(this.m_Kinematics))
			{
				if (this.IsGroup)
				{
					activeUnit_Kinematics = ((Group)this).GetGroupKinematics();
					result = activeUnit_Kinematics;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_Kinematics = ((Aircraft)this).GetAircraftKinematics();
					result = activeUnit_Kinematics;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_Kinematics = ((Ship)this).GetShipKinematics();
					result = activeUnit_Kinematics;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_Kinematics = ((Submarine)this).GetSubmarineKinematics();
					result = activeUnit_Kinematics;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_Kinematics = ((Facility)this).GetFacilityKinematics();
					result = activeUnit_Kinematics;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					activeUnit_Kinematics = ((Weapon)this).GetWeaponKinematics();
					result = activeUnit_Kinematics;
					return result;
				case GlobalVariables.ActiveUnitType.Satellite:
					activeUnit_Kinematics = ((Satellite)this).GetSatelliteKinematics();
					result = activeUnit_Kinematics;
					return result;
				}
				ActiveUnit activeUnit = this;
				this.m_Kinematics = new ActiveUnit_Kinematics(ref activeUnit);
			}
			activeUnit_Kinematics = this.m_Kinematics;
			result = activeUnit_Kinematics;
			return result;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00070F50 File Offset: 0x0006F150
		public virtual ActiveUnit_Sensory GetSensory()
		{
			ActiveUnit_Sensory activeUnit_Sensory;
			ActiveUnit_Sensory result;
			if (Information.IsNothing(this.m_Sensory))
			{
				if (this.IsGroup)
				{
					activeUnit_Sensory = ((Group)this).GetSensory();
					result = activeUnit_Sensory;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_Sensory = ((Aircraft)this).GetAircraftSensory();
					result = activeUnit_Sensory;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_Sensory = ((Ship)this).GetShipSensory();
					result = activeUnit_Sensory;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_Sensory = ((Submarine)this).GetSubmarineSensory();
					result = activeUnit_Sensory;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_Sensory = ((Facility)this).GetFacilitySensory();
					result = activeUnit_Sensory;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					activeUnit_Sensory = ((Weapon)this).GetWeaponSensory();
					result = activeUnit_Sensory;
					return result;
				}
				ActiveUnit activeUnit = this;
				this.m_Sensory = new ActiveUnit_Sensory(ref activeUnit);
			}
			activeUnit_Sensory = this.m_Sensory;
			result = activeUnit_Sensory;
			return result;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00071024 File Offset: 0x0006F224
		public virtual ActiveUnit_Weaponry GetWeaponry()
		{
			ActiveUnit_Weaponry activeUnit_Weaponry;
			ActiveUnit_Weaponry result;
			if (Information.IsNothing(this.m_Weaponry))
			{
				if (this.IsGroup)
				{
					activeUnit_Weaponry = ((Group)this).GetWeaponry();
					result = activeUnit_Weaponry;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_Weaponry = ((Aircraft)this).GetAircraftWeaponry();
					result = activeUnit_Weaponry;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_Weaponry = ((Ship)this).GetShipWeaponry();
					result = activeUnit_Weaponry;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_Weaponry = ((Submarine)this).GetSubmarineWeaponry();
					result = activeUnit_Weaponry;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_Weaponry = ((Facility)this).GetFacilityWeaponry();
					result = activeUnit_Weaponry;
					return result;
				default:
					this.m_Weaponry = new ActiveUnit_Weaponry(this);
					break;
				}
			}
			activeUnit_Weaponry = this.m_Weaponry;
			result = activeUnit_Weaponry;
			return result;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000710D8 File Offset: 0x0006F2D8
		public virtual ActiveUnit_CommStuff GetCommStuff()
		{
			ActiveUnit_CommStuff activeUnit_CommStuff;
			ActiveUnit_CommStuff result;
			if (Information.IsNothing(this.m_CommStuff))
			{
				if (this.IsGroup)
				{
					activeUnit_CommStuff = ((Group)this).GetCommStuff();
					result = activeUnit_CommStuff;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_CommStuff = ((Aircraft)this).GetAircraftCommStuff();
					result = activeUnit_CommStuff;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_CommStuff = ((Ship)this).GetShipCommStuff();
					result = activeUnit_CommStuff;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_CommStuff = ((Submarine)this).GetSubmarineCommStuff();
					result = activeUnit_CommStuff;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_CommStuff = ((Facility)this).GetFacilityCommStuff();
					result = activeUnit_CommStuff;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					activeUnit_CommStuff = ((Weapon)this).GetWeaponCommStuff();
					result = activeUnit_CommStuff;
					return result;
				}
				ActiveUnit activeUnit = this;
				this.m_CommStuff = new ActiveUnit_CommStuff(ref activeUnit);
			}
			activeUnit_CommStuff = this.m_CommStuff;
			result = activeUnit_CommStuff;
			return result;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000711AC File Offset: 0x0006F3AC
		public virtual ActiveUnit_Damage GetDamage()
		{
			ActiveUnit_Damage activeUnit_Damage;
			ActiveUnit_Damage result;
			if (Information.IsNothing(this.m_Damage))
			{
				if (this.IsGroup)
				{
					activeUnit_Damage = ((Group)this).method_133();
					result = activeUnit_Damage;
					return result;
				}
				switch (this.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					activeUnit_Damage = ((Aircraft)this).GetAircraftDamage();
					result = activeUnit_Damage;
					return result;
				case GlobalVariables.ActiveUnitType.Ship:
					activeUnit_Damage = ((Ship)this).GetShipDamage();
					result = activeUnit_Damage;
					return result;
				case GlobalVariables.ActiveUnitType.Submarine:
					activeUnit_Damage = ((Submarine)this).GetSubmarineDamage();
					result = activeUnit_Damage;
					return result;
				case GlobalVariables.ActiveUnitType.Facility:
					activeUnit_Damage = ((Facility)this).GetFacilityDamage();
					result = activeUnit_Damage;
					return result;
				case GlobalVariables.ActiveUnitType.Weapon:
					activeUnit_Damage = ((Weapon)this).GetWeaponDamage();
					result = activeUnit_Damage;
					return result;
				case GlobalVariables.ActiveUnitType.Satellite:
					activeUnit_Damage = ((Satellite)this).GetSatelliteDamage();
					result = activeUnit_Damage;
					return result;
				}
				ActiveUnit activeUnit = this;
				this.m_Damage = new ActiveUnit_Damage(ref activeUnit);
			}
			activeUnit_Damage = this.m_Damage;
			result = activeUnit_Damage;
			return result;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00071294 File Offset: 0x0006F494
		public virtual ActiveUnit_AirOps GetAirOps()
		{
			ActiveUnit_AirOps activeUnit_AirOps;
			ActiveUnit_AirOps result;
			if (Information.IsNothing(this.m_AirOps))
			{
				if (this.IsGroup)
				{
					activeUnit_AirOps = ((Group)this).GetAirOps();
					result = activeUnit_AirOps;
					return result;
				}
				GlobalVariables.ActiveUnitType unitType = this.GetUnitType();
				if (unitType == GlobalVariables.ActiveUnitType.Aircraft)
				{
					activeUnit_AirOps = ((Aircraft)this).GetAircraftAirOps();
					result = activeUnit_AirOps;
					return result;
				}
				ActiveUnit activeUnit = this;
				this.m_AirOps = new ActiveUnit_AirOps(ref activeUnit);
			}
			activeUnit_AirOps = this.m_AirOps;
			result = activeUnit_AirOps;
			return result;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00071308 File Offset: 0x0006F508
		public virtual ActiveUnit_DockingOps GetDockingOps()
		{
			if (Information.IsNothing(this.m_DockingOps))
			{
				ActiveUnit activeUnit = this;
				this.m_DockingOps = new ActiveUnit_DockingOps(ref activeUnit);
			}
			return this.m_DockingOps;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0007133C File Offset: 0x0006F53C
		public virtual CommDevice[] GetCommDevices()
		{
			CommDevice[] result;
			if (this.m_Mounts.Length > 0)
			{
				CommDevice[] array = new CommDevice[this.m_CommDevices.Length - 1 + 1];
				Array.Copy(this.m_CommDevices, array, this.m_CommDevices.Length);
				int num = this.m_Mounts.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Mount mount = this.m_Mounts[i];
					int num2 = mount.m_CommDevices.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						CommDevice commDevice_ = mount.m_CommDevices[j];
						ScenarioArrayUtil.AddCommDevice(ref array, commDevice_);
					}
				}
				result = array;
			}
			else
			{
				result = this.m_CommDevices;
			}
			return result;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000713F0 File Offset: 0x0006F5F0
		public virtual List<Sensor> GetMineCounterMeasures()
		{
			return this.m_Sensors.Where(ActiveUnit.MineCounterMeasureFilterFunc1).ToList<Sensor>();
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00071414 File Offset: 0x0006F614
		public Sensor[] GetAllNoneMCMSensors()
		{
			if (Information.IsNothing(this.m_AllNoneMCMSensors))
			{
				this.m_AllNoneMCMSensors = this.GetNoneMCMSensors();
			}
			return this.m_AllNoneMCMSensors;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00009610 File Offset: 0x00007810
		public void SetAllNoneMCMSensors(Sensor[] sensors)
		{
			this.m_AllNoneMCMSensors = sensors;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00071448 File Offset: 0x0006F648
		public virtual Sensor[] GetNoneMCMSensors()
		{
			Sensor[] result = null;
			try
			{
				LinkedList<Sensor> linkedList = new LinkedList<Sensor>();
				Sensor[] sensors = this.m_Sensors;
				checked
				{
					for (int i = 0; i < sensors.Length; i++)
					{
						Sensor sensor = sensors[i];
						if (!sensor.IsMineCounterMeasure())
						{
							linkedList.AddLast(sensor);
						}
					}
				}
				int num = this.m_Mounts.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					Sensor[] sensors2 = this.m_Mounts[j].GetSensors();
					checked
					{
						for (int k = 0; k < sensors2.Length; k++)
						{
							Sensor value = sensors2[k];
							linkedList.AddLast(value);
						}
					}
				}
				int count = linkedList.Count;
				Sensor[] array = new Sensor[count - 1 + 1];
				int num2 = count - 1;
				for (int l = 0; l <= num2; l++)
				{
					array[l] = linkedList.ElementAtOrDefault(l);
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101185", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0007157C File Offset: 0x0006F77C
		public bool HasEmmittingSensor()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (this.GetAllNoneMCMSensors().Length == 0)
					{
						flag = false;
					}
					else
					{
						Sensor[] allNoneMCMSensors = this.GetAllNoneMCMSensors();
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							if (allNoneMCMSensors[i].IsEmmitting())
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
					ex2.Data.Add("Error at 101186", "");
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
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00071620 File Offset: 0x0006F820
		public virtual bool IsRunOutOfFuel()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (this.GetFuelRecs().Length == 0)
					{
						flag = false;
					}
					else
					{
						FuelRec[] fuelRecs = this.GetFuelRecs();
						for (int i = 0; i < fuelRecs.Length; i++)
						{
							if (fuelRecs[i].CurrentQuantity > 0f)
							{
								flag = false;
								result = false;
								return result;
							}
						}
						flag = true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101187", "");
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
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000716CC File Offset: 0x0006F8CC
		public virtual float GetFuelConsumption(ActiveUnit.Throttle throttle_, AltBand altBand_, float? desiredSpeed_, float? altitude_asl, bool bool_17, bool bool_18, bool bool_19, bool bool_20)
		{
			return 1E-07f;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00009619 File Offset: 0x00007819
		public bool IsNotActive()
		{
			return this.isDestroyed || !this.m_Scenario.GetActiveUnits().ContainsKey(base.GetGuid()) || this.m_Scenario.GetUnitRemovals().Contains(this);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000716E0 File Offset: 0x0006F8E0
		public virtual AirFacility[] GetAirFacilities()
		{
			return this.m_AirFacilities;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000716F8 File Offset: 0x0006F8F8
		public virtual DockFacility[] GetDockFacilities()
		{
			return this.m_DockFacilities;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00071710 File Offset: 0x0006F910
		public bool HasMineNeutralizations()
		{
			bool result;
			using (List<Sensor>.Enumerator enumerator = this.GetMineCounterMeasures().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsMineNeutralization())
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0007176C File Offset: 0x0006F96C
		public virtual Mission GetAssignedMission(bool SetMissionOnly = false)
		{
			Mission result = null;
			try
			{
				if (Information.IsNothing(this.AssignedMission) && !string.IsNullOrEmpty(this.AssignedMissionName))
				{
					ReadOnlyCollection<Mission> patrolMissionCollection = this.GetSide(false).GetPatrolMissionCollection(this.m_Scenario);
					int num = patrolMissionCollection.Count - 1;
					int i = 0;
					while (i <= num)
					{
						Mission mission = patrolMissionCollection[i];
						if (Information.IsNothing(mission) || Operators.CompareString(mission.GetGuid(), this.AssignedMissionName, false) != 0)
						{
							i++;
						}
						else
						{
							this.AssignedMission = mission;
							if (Information.IsNothing(this.AssignedMission))
							{
								this.AssignedMissionName = null;
								goto IL_B4;
							}
							goto IL_B4;
						}
					}
					if (Information.IsNothing(this.AssignedMission))
					{
						this.AssignedMissionName = null;
					}
				}
				IL_B4:
				if (!Information.IsNothing(this.AssignedMission) && this.AssignedMission.category == Mission.MissionCategory.Package && !string.IsNullOrEmpty(this.AssignedMission.GetTaskPoolID(this.GetSide(false))))
				{
					this.AssignedTaskPoolName = this.AssignedMission.GetTaskPoolID(this.GetSide(false));
				}
				result = this.AssignedMission;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101188", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000718E8 File Offset: 0x0006FAE8
		public virtual void DeleteMission(bool SetMissionOnly, Mission Mission_)
		{
			checked
			{
				try
				{
					bool flag = Mission_ != this.AssignedMission;
					if (Information.IsNothing(Mission_))
					{
						if (this.GetAI().GetTargets().Length > 0)
						{
							bool flag2 = this.GetAI().IsOnPatrolStation();
							Contact[] targets = this.GetAI().GetTargets();
							for (int i = 0; i < targets.Length; i++)
							{
								Contact contact = targets[i];
								if (this.GetAI().GetTargetingBehavior(contact) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted)
								{
									ActiveUnit_AI aI = this.GetAI();
									Contact theContact = contact;
									Mission assignedMission = this.AssignedMission;
									Doctrine._ShootTourists? shootTouristsDoc_ = new Doctrine._ShootTourists?(this.m_Doctrine.GetShootTouristsDoctrine(this.m_Scenario, false, false, false).Value);
									bool onPatrolStation_ = flag2;
									string text = "";
									int num = 0;
									if (aI.IsTargetForMission(theContact, assignedMission, shootTouristsDoc_, false, onPatrolStation_, true, ref text, ref num))
									{
										this.GetAI().DropTargeting(contact, true);
									}
								}
							}
						}
						if (Information.IsNothing(this.AssignedMission) || (!Information.IsNothing(this.AssignedMission) && this.AssignedMission.category != Mission.MissionCategory.Package))
						{
							this.AssignedTaskPool = null;
							this.AssignedTaskPoolName = "";
						}
						this.AssignedMission = null;
						this.AssignedMissionName = "";
						if (SetMissionOnly)
						{
							return;
						}
						if (!this.IsRTB())
						{
							this.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
						}
					}
					else
					{
						if (Mission_.category == Mission.MissionCategory.TaskPool)
						{
							this.AssignedTaskPool = Mission_;
							this.AssignedTaskPoolName = Mission_.GetGuid();
							return;
						}
						this.AssignedMission = Mission_;
						this.AssignedMissionName = Mission_.GetGuid();
						if (SetMissionOnly)
						{
							return;
						}
						this.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
						if (!Information.IsNothing(this.GetSide(false)))
						{
							this.GetSide(false).AddMission(Mission_);
						}
						if (this.GetNavigator().HasPlottedCourse() && this.GetNavigator().GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
						{
							this.GetNavigator().ClearPlottedCourse();
						}
						if (Mission_.MissionClass != Mission._MissionClass.Escort)
						{
							this.GetAI().string_0 = null;
						}
						if (Mission_.MissionClass == Mission._MissionClass.Patrol)
						{
							this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(this.m_Scenario, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
						}
						if (Mission_.MissionClass == Mission._MissionClass.Ferry)
						{
							FerryMission.FerryMissionBehavior ferryMissionBehavior = ((FerryMission)Mission_).GetFerryMissionBehavior();
							if (ferryMissionBehavior != FerryMission.FerryMissionBehavior.Cycle)
							{
								if (ferryMissionBehavior == FerryMission.FerryMissionBehavior.Random)
								{
									if (this.IsAircraft)
									{
										((Aircraft)this).GetAircraftAirOps().method_31(((Aircraft)this).GetAircraftAirOps().GetAssignedHostUnit(false));
									}
									else if (this.IsShip || this.IsSubmarine)
									{
										this.GetDockingOps().method_40(((Aircraft_AirOps)this.GetAirOps()).GetAssignedHostUnit(false));
									}
								}
							}
							else
							{
								this.GetAI().SetFerryCycleLegIsOutbound();
							}
						}
					}
					if (flag)
					{
						this.GetAI().IsEscort = false;
						if (this.IsGroupLead())
						{
							this.GetParentGroup(false).DeleteMission(false, Mission_);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101189", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00071C58 File Offset: 0x0006FE58
		public void AssignToMission(ref Scenario scenario_, ref ActiveUnit activeUnit_, ref Mission mission_, ref bool bIsEscort)
		{
			try
			{
				string str = "";
				if (activeUnit_.IsAircraft && Operators.CompareString(activeUnit_.Name, activeUnit_.UnitClass, false) != 0)
				{
					str = " (" + activeUnit_.UnitClass + ")";
				}
				if (mission_.MissionClass == Mission._MissionClass.Ferry && !activeUnit_.IsAircraft && (!activeUnit_.IsGroup || ((Group)activeUnit_).GetGroupType() != Group.GroupType.AirGroup))
				{
					scenario_.LogMessage(activeUnit_.Name + "不是飞机，不能分配转场任务", LoggedMessage.MessageType.UnitAI, 0, activeUnit_.GetGuid(), activeUnit_.GetSide(false), new GeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null)));
				}
				else if (mission_.category == Mission.MissionCategory.TaskPool)
				{
					activeUnit_.DeleteMission(false, null);
					if (Information.IsNothing(activeUnit_.GetAssignedTaskPool()) || activeUnit_.GetAssignedTaskPool() != mission_)
					{
						activeUnit_.SetAssignedTaskPool(mission_);
						activeUnit_.m_Scenario.LogMessage(activeUnit_.Name + str + "已分配给任务（Task）池: " + mission_.Name, LoggedMessage.MessageType.UnitAI, 0, activeUnit_.GetGuid(), activeUnit_.GetSide(false), new GeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null)));
						if (activeUnit_.IsGroup)
						{
							Group group = (Group)activeUnit_;
							using (IEnumerator<ActiveUnit> enumerator = group.GetUnitsInGroup().Values.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.GetAI().TargetingContacts(0f, false, true);
								}
								goto IL_1D4;
							}
						}
						activeUnit_.GetAI().TargetingContacts(0f, false, true);
						IL_1D4:
						activeUnit_.m_Doctrine.Init();
					}
				}
				else if (activeUnit_.GetAssignedMission(false) != mission_ || (activeUnit_.GetAssignedMission(false) == mission_ && bIsEscort != activeUnit_.GetAI().IsEscort))
				{
					activeUnit_.DeleteMission(false, mission_);
					if (activeUnit_.GetAssignedMission(false).category == Mission.MissionCategory.Package)
					{
						using (IEnumerator<Mission> enumerator2 = activeUnit_.GetSide(false).GetMissionCollection().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								Mission current = enumerator2.Current;
								if (Operators.CompareString(current.GetGuid(), activeUnit_.GetAssignedMission(false).GetTaskPoolID(activeUnit_.GetSide(false)), false) == 0)
								{
									activeUnit_.SetAssignedTaskPool(current);
									break;
								}
							}
							goto IL_2AF;
						}
					}
					activeUnit_.SetAssignedTaskPool(null);
					IL_2AF:
					if (activeUnit_.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && bIsEscort)
					{
						activeUnit_.GetAI().IsEscort = true;
						scenario_.LogMessage(activeUnit_.Name + str + " has been assigned as an escort to mission: " + mission_.Name, LoggedMessage.MessageType.UnitAI, 0, activeUnit_.GetGuid(), activeUnit_.GetSide(false), new GeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null)));
					}
					else
					{
						activeUnit_.GetAI().IsEscort = false;
						scenario_.LogMessage(activeUnit_.Name + str + " has been assigned to mission: " + mission_.Name, LoggedMessage.MessageType.UnitAI, 0, activeUnit_.GetGuid(), activeUnit_.GetSide(false), new GeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null)));
					}
					activeUnit_.m_Doctrine.Init();
					activeUnit_.GetSensory().ScheduleEMCONEvent(activeUnit_.GetAllNoneMCMSensors());
					if (activeUnit_.IsGroup)
					{
						Group group2 = (Group)activeUnit_;
						using (IEnumerator<ActiveUnit> enumerator3 = group2.GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								ActiveUnit current2 = enumerator3.Current;
								current2.GetAI().TargetingContacts(0f, false, true);
								current2.m_Doctrine.Init();
								current2.GetSensory().ScheduleEMCONEvent(activeUnit_.GetAllNoneMCMSensors());
							}
							goto IL_446;
						}
					}
					activeUnit_.GetAI().TargetingContacts(0f, false, true);
					IL_446:
					activeUnit_.m_Doctrine.Init();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101189", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00072160 File Offset: 0x00070360
		public virtual Mission GetAssignedTaskPool()
		{
			Mission result = null;
			try
			{
				if (Information.IsNothing(this.AssignedTaskPool))
				{
					if (!Information.IsNothing(this.AssignedMission) && this.AssignedMission.category == Mission.MissionCategory.Package && !string.IsNullOrEmpty(this.AssignedMission.GetTaskPoolID(this.GetSide(false))))
					{
						this.AssignedTaskPoolName = this.AssignedMission.GetTaskPoolID(this.GetSide(false));
					}
					if (!string.IsNullOrEmpty(this.AssignedTaskPoolName))
					{
						ReadOnlyCollection<Mission> patrolMissionCollection = this.GetSide(false).GetPatrolMissionCollection(this.m_Scenario);
						int num = patrolMissionCollection.Count - 1;
						int i = 0;
						while (i <= num)
						{
							Mission mission = patrolMissionCollection[i];
							if (Information.IsNothing(mission) || Operators.CompareString(mission.GetGuid(), this.AssignedTaskPoolName, false) != 0)
							{
								i++;
							}
							else
							{
								this.AssignedTaskPool = mission;
								if (Information.IsNothing(this.AssignedTaskPool))
								{
									this.AssignedTaskPoolName = null;
									goto IL_106;
								}
								goto IL_106;
							}
						}
						if (Information.IsNothing(this.AssignedTaskPool))
						{
							this.AssignedTaskPoolName = null;
						}
					}
				}
				IL_106:
				result = this.AssignedTaskPool;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200638", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000722E0 File Offset: 0x000704E0
		public virtual void SetAssignedTaskPool(Mission mission_)
		{
			try
			{
				if (Information.IsNothing(mission_))
				{
					this.AssignedTaskPool = null;
					this.AssignedTaskPoolName = "";
				}
				else
				{
					this.AssignedTaskPool = mission_;
					this.AssignedTaskPoolName = mission_.GetGuid();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200639", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool CanRefuelOrUNREP(ActiveUnit activeUnit_)
		{
			return false;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool IsRefuel_Out()
		{
			return false;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0000945D File Offset: 0x0000765D
		public virtual bool HasEnoughFuelLeftAboardToServe(ActiveUnit activeUnit_0, Aircraft_AirOps aircraft_AirOps_0, float float_20, bool bool_17)
		{
			return true;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00072370 File Offset: 0x00070570
		public virtual ActiveUnit._ActiveUnitStatus GetUnitStatus()
		{
			return this.activeUnitStatus;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00072388 File Offset: 0x00070588
		public virtual void SetUnitStatus(ActiveUnit._ActiveUnitStatus ActiveUnitStatus_)
		{
			this.bUnitStatusChanged = (ActiveUnitStatus_ != this.activeUnitStatus);
			if (this.bUnitStatusChanged)
			{
				this.m_ActiveUnitStatus = this.activeUnitStatus;
				if (((ActiveUnitStatus_ == ActiveUnit._ActiveUnitStatus.RTB && this.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsBingo) || ActiveUnitStatus_ == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || ActiveUnitStatus_ == ActiveUnit._ActiveUnitStatus.Refuelling) && (this.activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB || this.GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsBingo) && this.activeUnitStatus != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.activeUnitStatus != ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					this.SBR = this.activeUnitStatus;
					this.FuelStateBR = this.activeUnitFuelState;
					if (this.IsNotGroupLead() && !Information.IsNothing(this.IsGroupLead()))
					{
						if (this.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.SBR_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().SBEngagedDefensive_ThrottleSetting;
						}
						else if (this.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							this.SBR_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().SBEngagedOffensive_ThrottleSetting;
						}
						else
						{
							this.SBR_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().GetThrottle();
						}
					}
					else
					{
						this.SBR_ThrottleSetting = this.GetThrottle();
					}
					this.SBR_Altitude = this.GetDesiredAltitude();
					this.SBR_Altitude_TerrainFollowing = this.GetDesiredAltitude_TerrainFollowing();
					this.SBR_TerrainFollowing = this.IsTerrainFollowing(this);
					this.SetIsTerrainFollowing(this, false);
				}
				else if (ActiveUnitStatus_ == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
				{
					this.SBEngagedDefensive = this.activeUnitStatus;
					if (this.m_ActiveUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
					{
						this.SBEngagedDefensive_ThrottleSetting = this.SBEngagedOffensive_ThrottleSetting;
						this.SBEngagedDefensive_Altitude = this.SBEngagedOffensive_Altitude;
						this.SBEngagedDefensive_Altitude_TerrainFollowing = this.SBEngagedOffensive_Altitude_TerrainFollowing;
						this.SBEngagedDefensive_TerrainFollowing = this.SBEngagedOffensive_TerrainFollowing;
					}
					else if (this.m_ActiveUnitStatus != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.m_ActiveUnitStatus != ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						if (this.IsNotGroupLead() && !Information.IsNothing(this.IsGroupLead()))
						{
							if (this.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
							{
								this.SBEngagedDefensive_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().SBEngagedDefensive_ThrottleSetting;
							}
							else if (this.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
							{
								this.SBEngagedDefensive_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().SBEngagedOffensive_ThrottleSetting;
							}
							else
							{
								this.SBEngagedDefensive_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().GetThrottle();
							}
						}
						else
						{
							this.SBEngagedDefensive_ThrottleSetting = this.GetThrottle();
						}
						this.SBEngagedDefensive_Altitude = this.GetDesiredAltitude();
						this.SBEngagedDefensive_Altitude_TerrainFollowing = this.GetDesiredAltitude_TerrainFollowing();
						this.SBEngagedDefensive_TerrainFollowing = this.IsTerrainFollowing(this);
					}
					else
					{
						this.SBEngagedDefensive_ThrottleSetting = this.SBR_ThrottleSetting;
						this.SBEngagedDefensive_Altitude = this.SBR_Altitude;
						this.SBEngagedDefensive_Altitude_TerrainFollowing = this.SBR_Altitude_TerrainFollowing;
						this.SBEngagedDefensive_TerrainFollowing = this.SBR_TerrainFollowing;
					}
				}
				else if (ActiveUnitStatus_ == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
				{
					this.SBEngagedOffensive = this.activeUnitStatus;
					if (this.m_ActiveUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						this.SBEngagedOffensive_ThrottleSetting = this.SBEngagedDefensive_ThrottleSetting;
						this.SBEngagedOffensive_Altitude = this.SBEngagedDefensive_Altitude;
						this.SBEngagedOffensive_Altitude_TerrainFollowing = this.SBEngagedDefensive_Altitude_TerrainFollowing;
						this.SBEngagedOffensive_TerrainFollowing = this.SBEngagedDefensive_TerrainFollowing;
					}
					else if (this.m_ActiveUnitStatus != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.m_ActiveUnitStatus != ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						if (this.IsNotGroupLead() && !Information.IsNothing(this.IsGroupLead()))
						{
							if (this.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
							{
								this.SBEngagedOffensive_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().SBEngagedDefensive_ThrottleSetting;
							}
							else if (this.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
							{
								this.SBEngagedOffensive_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().SBEngagedOffensive_ThrottleSetting;
							}
							else
							{
								this.SBEngagedOffensive_ThrottleSetting = this.GetParentGroup(false).GetGroupLead().GetThrottle();
							}
						}
						else
						{
							this.SBEngagedOffensive_ThrottleSetting = this.GetThrottle();
						}
						this.SBEngagedOffensive_Altitude = this.GetDesiredAltitude();
						this.SBEngagedOffensive_Altitude_TerrainFollowing = this.GetDesiredAltitude_TerrainFollowing();
						this.SBEngagedOffensive_TerrainFollowing = this.IsTerrainFollowing(this);
					}
					else
					{
						this.SBEngagedOffensive_ThrottleSetting = this.SBR_ThrottleSetting;
						this.SBEngagedOffensive_Altitude = this.SBR_Altitude;
						this.SBEngagedOffensive_Altitude_TerrainFollowing = this.SBR_Altitude_TerrainFollowing;
						this.SBEngagedOffensive_TerrainFollowing = this.SBR_TerrainFollowing;
					}
				}
				else
				{
					bool arg_47E_0;
					if (this.m_ActiveUnitStatus == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
						if (ActiveUnitStatus_ != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							arg_47E_0 = false;
							goto IL_47E;
						}
					}
					arg_47E_0 = (this.m_ActiveUnitStatus != ActiveUnit._ActiveUnitStatus.Refuelling);
					IL_47E:
					if (!arg_47E_0)
					{
						if (!this.IsNotGroupLead())
						{
							this.SetThrottle(this.SBR_ThrottleSetting, null);
							this.SetDesiredAltitude(this.SBR_Altitude);
							this.SetDesiredAltitude_TerrainFollowing(this.SBR_Altitude_TerrainFollowing);
							this.SetIsTerrainFollowing(this, this.SBR_TerrainFollowing);
						}
					}
					else if (this.m_ActiveUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						if (!this.IsNotGroupLead())
						{
							this.SetThrottle(this.SBEngagedDefensive_ThrottleSetting, null);
							this.SetDesiredAltitude(this.SBEngagedDefensive_Altitude);
							this.SetDesiredAltitude_TerrainFollowing(this.SBEngagedDefensive_Altitude_TerrainFollowing);
							this.SetIsTerrainFollowing(this, this.SBEngagedDefensive_TerrainFollowing);
						}
					}
					else if (this.m_ActiveUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedOffensive && !this.IsNotGroupLead())
					{
						this.SetThrottle(this.SBEngagedOffensive_ThrottleSetting, null);
						this.SetDesiredAltitude(this.SBEngagedOffensive_Altitude);
						this.SetDesiredAltitude_TerrainFollowing(this.SBEngagedOffensive_Altitude_TerrainFollowing);
						this.SetIsTerrainFollowing(this, this.SBEngagedOffensive_TerrainFollowing);
					}
				}
			}
			if (this.bUnitStatusChanged && (this.IsShip || this.IsSubmarine))
			{
				if (ActiveUnitStatus_ == ActiveUnit._ActiveUnitStatus.RTB && this.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsBingo && this.GetDockingOps().HasUNREPTargetUnit())
				{
					if (!string.IsNullOrEmpty(this.GetDockingOps().UNREP_Port))
					{
						ActiveUnit activeUnit = this.m_Scenario.GetActiveUnits()[this.GetDockingOps().UNREP_Port];
						if (!Information.IsNothing(activeUnit) && !activeUnit.IsNotActive())
						{
							activeUnit.GetDockingOps().FinishUNREP();
						}
					}
					if (!string.IsNullOrEmpty(this.GetDockingOps().UNREP_Starboard))
					{
						ActiveUnit activeUnit2 = this.m_Scenario.GetActiveUnits()[this.GetDockingOps().UNREP_Starboard];
						if (!Information.IsNothing(activeUnit2) && !activeUnit2.IsNotActive())
						{
							activeUnit2.GetDockingOps().FinishUNREP();
						}
					}
					if (!string.IsNullOrEmpty(this.GetDockingOps().UNREP_Astern))
					{
						ActiveUnit activeUnit3 = this.m_Scenario.GetActiveUnits()[this.GetDockingOps().UNREP_Astern];
						if (!Information.IsNothing(activeUnit3) && !activeUnit3.IsNotActive())
						{
							activeUnit3.GetDockingOps().FinishUNREP();
						}
					}
				}
				if (ActiveUnitStatus_ <= ActiveUnit._ActiveUnitStatus.RTB)
				{
					if (ActiveUnitStatus_ != ActiveUnit._ActiveUnitStatus.Unassigned && ActiveUnitStatus_ != ActiveUnit._ActiveUnitStatus.RTB)
					{
						goto IL_6EB;
					}
				}
				else if (ActiveUnitStatus_ != ActiveUnit._ActiveUnitStatus.RTB_Manual && ActiveUnitStatus_ != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && ActiveUnitStatus_ != ActiveUnit._ActiveUnitStatus.RTB_Group)
				{
					goto IL_6EB;
				}
				if (this.activeUnitStatus == ActiveUnit._ActiveUnitStatus.Refuelling || this.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Replenishing)
				{
					this.GetDockingOps().FinishUNREP();
				}
			}
			IL_6EB:
			this.activeUnitStatus = ActiveUnitStatus_;
			if (this.IsRTB() && !this.IsAircraft && this.HasParentGroup())
			{
				this.SetParentGroup(false, null);
			}
			if (this.IsRTB() && this.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0)
			{
				this.GetNavigator().ClearPlottedCourse();
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00072ADC File Offset: 0x00070CDC
		public virtual ActiveUnit._ActiveUnitFuelState GetFuelState()
		{
			return this.activeUnitFuelState;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0000964F File Offset: 0x0000784F
		public virtual void SetFuelState(ActiveUnit._ActiveUnitFuelState _ActiveUnitFuelState_2)
		{
			this.activeUnitFuelState = _ActiveUnitFuelState_2;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00072AF4 File Offset: 0x00070CF4
		public virtual ActiveUnit._ActiveUnitWeaponState GetWeaponState()
		{
			return this.weaponState;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00009658 File Offset: 0x00007858
		public virtual void SetWeaponState(ActiveUnit._ActiveUnitWeaponState _ActiveUnitWeaponState_1)
		{
			this.weaponState = _ActiveUnitWeaponState_1;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00072B0C File Offset: 0x00070D0C
		public bool IsRTB()
		{
			ActiveUnit._ActiveUnitStatus unitStatus = this.GetUnitStatus();
			bool flag = false;
			bool result;
			if (unitStatus <= ActiveUnit._ActiveUnitStatus.RTB_Manual)
			{
				if (unitStatus == ActiveUnit._ActiveUnitStatus.RTB || unitStatus == ActiveUnit._ActiveUnitStatus.RTB_Manual)
				{
					result = true;
					return result;
				}
			}
			else
			{
				if (unitStatus == ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
				{
					result = true;
					return result;
				}
				if (unitStatus == ActiveUnit._ActiveUnitStatus.RTB_Group)
				{
					result = true;
					return result;
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00009661 File Offset: 0x00007861
		public virtual long GetTimeToBurnOut(ActiveUnit.Throttle throttle_4, AltBand altBand_0, float? nullable_14, float? nullable_15)
		{
			return 0L;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0000966C File Offset: 0x0000786C
		public virtual int GetFuelRecsMaxQuantity()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return 2147483647;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00072B64 File Offset: 0x00070D64
		public virtual int GetCurrentFuelQuantity()
		{
			FuelRec[] fuelRecs = this.GetFuelRecs();
			int num = 0;
			checked
			{
				for (int i = 0; i < fuelRecs.Length; i++)
				{
					FuelRec fuelRec = fuelRecs[i];
					num = unchecked((int)Math.Round((double)((float)num + fuelRec.CurrentQuantity)));
				}
				return num;
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00009682 File Offset: 0x00007882
		public bool IsDecoy()
		{
			return this.IsAirDecoy() || this.IsSurfaceDecoy() || this.IsSubsurfaceDecoy();
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0000969D File Offset: 0x0000789D
		public bool IsAirDecoy()
		{
			return this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle && ((Weapon)this).RangeAAWMax > 0f;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000096CE File Offset: 0x000078CE
		public bool IsSurfaceDecoy()
		{
			return this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle && ((Weapon)this).RangeASUWMax > 0f;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000096FF File Offset: 0x000078FF
		public bool IsSubsurfaceDecoy()
		{
			return this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle && ((Weapon)this).RangeASWMax > 0f;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00009730 File Offset: 0x00007930
		public override bool IsPlatform()
		{
			return base.GetType().BaseType == typeof(Platform);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00072BA4 File Offset: 0x00070DA4
		public Magazine[] GetMagazinesForAllMounts()
		{
			checked
			{
				Magazine[] result;
				if (!Information.IsNothing(this.m_Mounts))
				{
					List<Magazine> list = new List<Magazine>();
					list.AddRange(this.GetMagazines());
					Mount[] mounts = this.m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						if (!Information.IsNothing(mount.GetMagazineForMount()))
						{
							list.Add(mount.GetMagazineForMount());
						}
					}
					result = list.ToArray();
				}
				else
				{
					result = this.GetMagazines();
				}
				return result;
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00072C1C File Offset: 0x00070E1C
		public virtual Magazine[] GetMagazines()
		{
			Magazine[] result;
			if (this.IsPlatform())
			{
				result = ((Platform)this).m_Magazines;
			}
			else if (this.IsGroup)
			{
				result = ((Group)this).GetMagazines();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0000974C File Offset: 0x0000794C
		public void AddMagazine(Magazine magazine_0)
		{
			if (this.IsPlatform())
			{
				ScenarioArrayUtil.AddMagazine(ref ((Platform)this).m_Magazines, magazine_0);
				magazine_0.SetParentPlatform(this);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00072C60 File Offset: 0x00070E60
		public bool IsAutoDetectable(Side side_1)
		{
			return !this.IsGroup && (this.bAutoDetectable || (!Information.IsNothing(side_1) && ((this.vmethod_109() && side_1.CATC) || side_1.GetAwarenessLevel() == Side.AwarenessLevel.Omniscient || (this.GetSide(false).GetPostureStance(side_1) == Misc.PostureStance.Friendly && this.GetCommStuff().IsNotOutOfComms()))));
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00009771 File Offset: 0x00007971
		public void SetIsAutoDetectable(Side side_1, bool value)
		{
			this.bAutoDetectable = value;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00072CC8 File Offset: 0x00070EC8
		public   bool vmethod_109()
		{
			int operatorCountry = this.OperatorCountry;
			return operatorCountry == 1101 || operatorCountry == 1102;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00072CF0 File Offset: 0x00070EF0
		public  double GetFuelLeft(ref double CurrentQuantity_, ref double MaxQuantity_, bool bool_17)
		{
			double result;
			if (this.GetEngines().Count > 0 && this.GetEngines()[0].PropulsionType == Engine._PropulsionType.Nuclear)
			{
				result = 1.0;
			}
			else if (this.GetFuelRecs().Count<FuelRec>() == 0)
			{
				result = 0.0;
			}
			else
			{
				FuelRec[] fuelRecs = this.GetFuelRecs();
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					if (!this.IsShip || this.GetEngines()[0].IsFueTypeSuitable(fuelRec.FuelType))
					{
						CurrentQuantity_ += (double)fuelRec.CurrentQuantity;
						MaxQuantity_ += (double)fuelRec.MaxQuantity;
					}
				}
				if (bool_17 && this.IsAircraft)
				{
					CurrentQuantity_ -= (double)this.GetKinematics().GetReserveFuel();
					MaxQuantity_ -= (double)this.GetKinematics().GetReserveFuel();
				}
				if (MaxQuantity_ <= 0.0)
				{
					result = 0.0;
				}
				else
				{
					result = CurrentQuantity_ / MaxQuantity_;
				}
			}
			return result;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00072E1C File Offset: 0x0007101C
		public virtual ReadOnlyCollection<PlatformComponent> GetAllPlatformComponents()
		{
			List<PlatformComponent> list = new List<PlatformComponent>();
			Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
			checked
			{
				for (int i = 0; i < noneMCMSensors.Length; i++)
				{
					Sensor item = noneMCMSensors[i];
					list.Add(item);
				}
				Mount[] mounts = this.m_Mounts;
				for (int j = 0; j < mounts.Length; j++)
				{
					Mount item2 = mounts[j];
					list.Add(item2);
				}
				CommDevice[] commDevices = this.GetCommDevices();
				for (int k = 0; k < commDevices.Length; k++)
				{
					CommDevice item3 = commDevices[k];
					list.Add(item3);
				}
				DockFacility[] dockFacilities = this.GetDockFacilities();
				for (int l = 0; l < dockFacilities.Length; l++)
				{
					DockFacility item4 = dockFacilities[l];
					list.Add(item4);
				}
				AirFacility[] airFacilities = this.GetAirFacilities();
				for (int m = 0; m < airFacilities.Length; m++)
				{
					AirFacility item5 = airFacilities[m];
					list.Add(item5);
				}
				Cargo[] onboardCargos = this.m_OnboardCargos;
				for (int n = 0; n < onboardCargos.Length; n++)
				{
					Cargo item6 = onboardCargos[n];
					list.Add(item6);
				}
				foreach (Engine current in this.GetEngines())
				{
					list.Add(current);
				}
				if (!Information.IsNothing(this.GetMagazines()))
				{
					Magazine[] magazines = this.GetMagazines();
					for (int num = 0; num < magazines.Length; num++)
					{
						Magazine item7 = magazines[num];
						list.Add(item7);
					}
				}
				return list.AsReadOnly();
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0000977A File Offset: 0x0000797A
		public bool HasTrackingAndDirectingSensor()
		{
			return this.GetNoneMCMSensors().Where(ActiveUnit.TrackingAndDirectingSensorFilter).Count<Sensor>() > 0;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00009794 File Offset: 0x00007994
		public bool HasTerminalIlluminatorForGuidedWeaponsInAir()
		{
			return this.m_Scenario.GetGuidedWeaponsInAir().Count != 0 && this.m_Scenario.GetGuidedWeaponsInAir().Where(new Func<Weapon, bool>(this.IsFiringParentOfTerminalIlluminationWeapon)).Count<Weapon>() > 0;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00072FBC File Offset: 0x000711BC
		public bool HasFireControllerForTarget(Contact Target_)
		{
			ActiveUnit.FireControl fireControl = new ActiveUnit.FireControl();
			fireControl.Target = Target_;
			return this.GetNoneMCMSensors().Where(new Func<Sensor, bool>(fireControl.IsTargetTracked)).Count<Sensor>() > 0;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00072FF8 File Offset: 0x000711F8
		public GlobalVariables.Enum104 method_88()
		{
			XSection crossSection = Sensor.GetCrossSection(this, XSection._SignatureType.PassiveSonar_VLF);
			if (Information.IsNothing(crossSection))
			{
				crossSection = Sensor.GetCrossSection(this, XSection._SignatureType.PassiveSonar_VLF);
			}
			GlobalVariables.Enum104 result;
			if (Information.IsNothing(crossSection))
			{
				result = GlobalVariables.Enum104.const_2;
			}
			else
			{
				float rearXSection = crossSection.GetRearXSection(this);
				if (rearXSection < 100f)
				{
					result = GlobalVariables.Enum104.const_4;
				}
				else if (rearXSection < 120f)
				{
					result = GlobalVariables.Enum104.const_3;
				}
				else if (rearXSection < 130f)
				{
					result = GlobalVariables.Enum104.const_2;
				}
				else if (rearXSection < 140f)
				{
					result = GlobalVariables.Enum104.const_1;
				}
				else
				{
					result = GlobalVariables.Enum104.const_0;
				}
			}
			return result;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000097CF File Offset: 0x000079CF
		public virtual GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00073088 File Offset: 0x00071288
		public override void ClearGuid()
		{
			base.ClearGuid();
			Sensor[] sensors = this.m_Sensors;
			checked
			{
				for (int i = 0; i < sensors.Length; i++)
				{
					sensors[i].ClearGuid();
				}
				CommDevice[] commDevices = this.m_CommDevices;
				for (int j = 0; j < commDevices.Length; j++)
				{
					commDevices[j].ClearGuid();
				}
				using (IEnumerator<Engine> enumerator = this.GetEngines().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.ClearGuid();
					}
				}
				using (IEnumerator<XSection> enumerator2 = this.GetXSections().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						enumerator2.Current.ClearGuid();
					}
				}
				FuelRec[] fuelRecs = this.m_FuelRecs;
				for (int k = 0; k < fuelRecs.Length; k++)
				{
					fuelRecs[k].ClearGuid();
				}
				Mount[] mounts = this.m_Mounts;
				for (int l = 0; l < mounts.Length; l++)
				{
					mounts[l].ClearGuid();
				}
				Cargo[] onboardCargos = this.m_OnboardCargos;
				for (int m = 0; m < onboardCargos.Length; m++)
				{
					onboardCargos[m].ClearGuid();
				}
				AirFacility[] airFacilities = this.m_AirFacilities;
				for (int n = 0; n < airFacilities.Length; n++)
				{
					airFacilities[n].ClearGuid();
				}
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00073200 File Offset: 0x00071400
		public void CheckNoNavZone(float elapsedTime)
		{
			if (!Misc.smethod_15(this.lazy_1.Value))
			{
				this.lazy_1.Value.Clear();
			}
			if (this.GetSide(false).NoNavZoneList.Count > 0 && this.GetNavigator().TimeToCheckNoNavZoneViolation != -32768)
			{
				ActiveUnit_Navigator navigator = this.GetNavigator();
				ActiveUnit_Navigator expr_55 = navigator;
				expr_55.TimeToCheckNoNavZoneViolation -= (short)Math.Round((double)elapsedTime);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00073278 File Offset: 0x00071478
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("ActiveUnit");
					xmlWriter_0.WriteElementString("ID", base.GetGuid());
					if (hashSet_0.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_0.Add(base.GetGuid());
						xmlWriter_0.WriteElementString("Name", this.Name);
						xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.GetCurrentHeading()));
						xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.GetCurrentSpeed()));
						xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
						xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.GetLongitude(null)));
						xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.GetLatitude(null)));
						xmlWriter_0.WriteElementString("UnitClass", this.UnitClass);
						if (base.GetRangeSymbols().Count > 0)
						{
							xmlWriter_0.WriteStartElement("RangeSymbols");
							using (List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.Save(ref xmlWriter_0);
								}
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("Side", this.GetSide(false).GetSideName());
						if (!string.IsNullOrEmpty(this.Message))
						{
							xmlWriter_0.WriteElementString("Message", this.Message);
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("DesiredHeading", XmlConvert.ToString(this.GetDesiredHeading(ActiveUnit._TurnRate.const_0)));
						xmlWriter_0.WriteElementString("DesiredSpeed", XmlConvert.ToString(this.GetDesiredSpeed()));
						xmlWriter_0.WriteElementString("DesiredAltitude", XmlConvert.ToString(this.GetDesiredAltitude()));
						xmlWriter_0.WriteElementString("DesiredAltitude_TerrainFollowing", XmlConvert.ToString(this.GetDesiredAltitude_TerrainFollowing()));
						xmlWriter_0.WriteElementString("DesiredTurnRate", ((byte)this.GetDesiredTurnRate()).ToString());
						xmlWriter_0.WriteElementString("DesiredTurnRate_Navigation", ((byte)this.GetDesiredTurnRate_Navigation()).ToString());
						xmlWriter_0.WriteElementString("TerrainFollowing", this.IsTerrainFollowing(this).ToString());
						xmlWriter_0.WriteElementString("Weight", XmlConvert.ToString(this.WeightEmpty));
						xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.GetThrottle()).ToString());
						if (!Information.IsNothing(this.m_ProficiencyLevel))
						{
							xmlWriter_0.WriteElementString("Prof", ((int)this.m_ProficiencyLevel.Value).ToString());
						}
						xmlWriter_0.WriteStartElement("Sensors");
						Sensor[] sensors = this.m_Sensors;
						for (int i = 0; i < sensors.Length; i++)
						{
							sensors[i].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Comms");
						CommDevice[] commDevices = this.m_CommDevices;
						for (int j = 0; j < commDevices.Length; j++)
						{
							commDevices[j].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Propulsion");
						using (IEnumerator<Engine> enumerator2 = this.GetEngines().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("XSections");
						using (IEnumerator<XSection> enumerator3 = this.GetXSections().GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.Save(ref xmlWriter_0);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Fuel");
						FuelRec[] fuelRecs = this.m_FuelRecs;
						for (int k = 0; k < fuelRecs.Length; k++)
						{
							fuelRecs[k].Save(ref xmlWriter_0);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Mounts");
						Mount[] mounts = this.m_Mounts;
						for (int l = 0; l < mounts.Length; l++)
						{
							mounts[l].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("OnboardCargo");
						Cargo[] onboardCargos = this.m_OnboardCargos;
						for (int m = 0; m < onboardCargos.Length; m++)
						{
							onboardCargos[m].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "Status";
						byte b = (byte)this.activeUnitStatus;
						xmlWriter.WriteElementString(localName, b.ToString());
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "FuelState";
						b = (byte)this.activeUnitFuelState;
						xmlWriter2.WriteElementString(localName2, b.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "WeaponState";
						b = (byte)this.weaponState;
						xmlWriter3.WriteElementString(localName3, b.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "SBR";
						b = (byte)this.SBR;
						xmlWriter4.WriteElementString(localName4, b.ToString());
						XmlWriter xmlWriter5 = xmlWriter_0;
						string localName5 = "SBED";
						b = (byte)this.SBEngagedDefensive;
						xmlWriter5.WriteElementString(localName5, b.ToString());
						XmlWriter xmlWriter6 = xmlWriter_0;
						string localName6 = "SBEO";
						b = (byte)this.SBEngagedOffensive;
						xmlWriter6.WriteElementString(localName6, b.ToString());
						XmlWriter xmlWriter7 = xmlWriter_0;
						string localName7 = "FSBR";
						b = (byte)this.FuelStateBR;
						xmlWriter7.WriteElementString(localName7, b.ToString());
						xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.SBR_Altitude));
						xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.SBR_Altitude_TerrainFollowing));
						xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.SBR_TerrainFollowing));
						XmlWriter xmlWriter8 = xmlWriter_0;
						string localName8 = "SBR_ThrottleSetting";
						b = (byte)this.SBR_ThrottleSetting;
						xmlWriter8.WriteElementString(localName8, b.ToString());
						xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.SBEngagedDefensive_Altitude));
						xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.SBEngagedDefensive_Altitude_TerrainFollowing));
						xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.SBEngagedDefensive_TerrainFollowing));
						XmlWriter xmlWriter9 = xmlWriter_0;
						string localName9 = "SBED_ThrottleSetting";
						b = (byte)this.SBEngagedDefensive_ThrottleSetting;
						xmlWriter9.WriteElementString(localName9, b.ToString());
						xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.SBEngagedOffensive_Altitude));
						xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.SBEngagedOffensive_Altitude_TerrainFollowing));
						xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.SBEngagedOffensive_TerrainFollowing));
						XmlWriter xmlWriter10 = xmlWriter_0;
						string localName10 = "SBEO_ThrottleSetting";
						b = (byte)this.SBEngagedOffensive_ThrottleSetting;
						xmlWriter10.WriteElementString(localName10, b.ToString());
						xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.DamagePts));
						if (this.m_AirFacilities.Length > 0)
						{
							xmlWriter_0.WriteStartElement("AirFacilities");
							AirFacility[] airFacilities = this.m_AirFacilities;
							for (int n = 0; n < airFacilities.Length; n++)
							{
								airFacilities[n].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.m_DockFacilities.Count<DockFacility>() > 0)
						{
							xmlWriter_0.WriteStartElement("DockFacilities");
							DockFacility[] dockFacilities = this.m_DockFacilities;
							for (int num = 0; num < dockFacilities.Length; num++)
							{
								dockFacilities[num].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (!Information.IsNothing(this.GetAssignedMission(false)))
						{
							xmlWriter_0.WriteElementString("AssignedMission", this.AssignedMission.GetGuid());
						}
						if (!Information.IsNothing(this.GetAssignedTaskPool()))
						{
							xmlWriter_0.WriteElementString("AssignedTaskPool", this.AssignedTaskPool.GetGuid());
						}
						if (!Information.IsNothing(this.GetParentGroup(false)))
						{
							xmlWriter_0.WriteElementString("ParentGroup", this.parentGroup.GetGuid());
						}
						if (this.IsAutoDetectable(null))
						{
							xmlWriter_0.WriteElementString("IsAD", this.IsAutoDetectable(null).ToString());
						}
						this.m_Doctrine.Save(ref xmlWriter_0, ref this.m_Scenario, "Doctrine");
						this.m_Navigator.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("ActiveUnit_AI");
						this.m_AI.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("ActiveUnit_Kinematics");
						this.m_Kinematics.Save(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.m_Sensory.Save(ref xmlWriter_0);
						this.m_Weaponry.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("ActiveUnit_CommStuff");
						this.m_CommStuff.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.m_Damage.Save(ref xmlWriter_0);
						this.m_AirOps.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100000", string.Concat(new string[]
					{
						"Name: ",
						this.Name,
						" DBID: ",
						Conversions.ToString(this.DBID),
						" ObjectID: ",
						base.GetGuid()
					}));
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00073C4C File Offset: 0x00071E4C
		public static ActiveUnit Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			ActiveUnit activeUnit = null;
			ActiveUnit result;
			try
			{
				string name = xmlNode_0.Name;
				uint num = Class382.smethod_0(name);
				if (num <= 1158526071u)
				{
					if (num != 91525164u)
					{
						if (num != 746798495u)
						{
							if (num == 1158526071u && Operators.CompareString(name, "Submarine", false) == 0)
							{
								activeUnit = Submarine.ShallowRebuild(ref xmlNode_0, ref dictionary_0, ref scenario_1);
								result = activeUnit;
								return result;
							}
						}
						else if (Operators.CompareString(name, "Ship", false) == 0)
						{
							activeUnit = Ship.smethod_1(ref xmlNode_0, ref dictionary_0, ref scenario_1);
							result = activeUnit;
							return result;
						}
					}
					else if (Operators.CompareString(name, "Group", false) == 0)
					{
						activeUnit = Group.Load(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						result = activeUnit;
						return result;
					}
				}
				else if (num <= 3082879841u)
				{
					if (num != 2722002328u)
					{
						if (num == 3082879841u && Operators.CompareString(name, "Weapon", false) == 0)
						{
							activeUnit = Weapon.Load(ref xmlNode_0, ref dictionary_0, ref scenario_1);
							result = activeUnit;
							return result;
						}
					}
					else if (Operators.CompareString(name, "Facility", false) == 0)
					{
						activeUnit = Facility.ShallowRebuild(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						result = activeUnit;
						return result;
					}
				}
				else if (num != 3388951946u)
				{
					if (num == 4032298643u && Operators.CompareString(name, "Aircraft", false) == 0)
					{
						activeUnit = Aircraft.ShallowRebuild(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						result = activeUnit;
						return result;
					}
				}
				else if (Operators.CompareString(name, "Satellite", false) == 0)
				{
					activeUnit = Satellite.smethod_1(ref xmlNode_0, ref dictionary_0, ref scenario_1);
					result = activeUnit;
					return result;
				}
				activeUnit = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100001", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = activeUnit;
			return result;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00073E3C File Offset: 0x0007203C
		protected void LoadAirFacilities(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			try
			{
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "AirFacilities", false) == 0)
						{
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
									this.AirFacilities.Add(xmlNode2.ChildNodes[0].InnerXml);
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
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100002", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00073F74 File Offset: 0x00072174
		public void method_91(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0)
		{
			try
			{
				if (!Information.IsNothing(this.ParentGroupName))
				{
					try
					{
						this.SetParentGroup(true, (Group)scenario_.GetActiveUnits()[this.ParentGroupName]);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200004", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100003", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00074048 File Offset: 0x00072248
		public virtual void vmethod_113(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0, bool bool_17)
		{
			try
			{
				this.SetSide(false, Side.GetSideByName(this.strSide, ref dictionary_0));
				this.GetAirOps().AddsToLandingQueue(ref scenario_, dictionary_0, bool_17);
				this.GetNavigator().SetMyFlight(ref scenario_, dictionary_0, bool_17);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100004", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x000097E5 File Offset: 0x000079E5
		public virtual bool IsParkedInPlace()
		{
			return this.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Docked && this.GetDockingOps().CT == 0.0;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0000980E File Offset: 0x00007A0E
		public virtual bool IsParking()
		{
			return this.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Docked && this.GetDockingOps().CT > 0.0;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0000945D File Offset: 0x0000765D
		public   bool vmethod_116(ref string string_9)
		{
			return true;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000740D4 File Offset: 0x000722D4
		public ActiveUnit()
		{
			this.m_Sensors = new Sensor[0];
			this.m_CommDevices = new CommDevice[0];
			this.SetEngines(new ObservableCollection<Engine>());
			this.m_FuelRecs = new FuelRec[0];
			this.m_Mounts = new Mount[0];
			this.m_OnboardCargos = new Cargo[0];
			this.m_AirFacilities = new AirFacility[0];
			this.m_DockFacilities = new DockFacility[0];
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.float_19 = 1801f;
			this.isDestroyed = false;
			this.m_Weapons = new Weapon[0];
			this.RefuelOrReplenish = default(ActiveUnit._RefuelOrReplenish);
			this.AirFacilities = new List<string>();
			this.DEC = false;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000741A0 File Offset: 0x000723A0
		public ActiveUnit(ref Scenario theScen, string theGUID = null)
		{
			this.m_Sensors = new Sensor[0];
			this.m_CommDevices = new CommDevice[0];
			this.SetEngines(new ObservableCollection<Engine>());
			this.m_FuelRecs = new FuelRec[0];
			this.m_Mounts = new Mount[0];
			this.m_OnboardCargos = new Cargo[0];
			this.m_AirFacilities = new AirFacility[0];
			this.m_DockFacilities = new DockFacility[0];
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.float_19 = 1801f;
			this.isDestroyed = false;
			this.m_Weapons = new Weapon[0];
			this.RefuelOrReplenish = default(ActiveUnit._RefuelOrReplenish);
			this.AirFacilities = new List<string>();
			this.DEC = false;
			try
			{
				this.m_Scenario = theScen;
				if (!Information.IsNothing(theGUID))
				{
					base.SetGuid(theGUID);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100005", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void ScheduleLifeCycleActivities(float elapsedTime, ref Random random_1)
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000742D0 File Offset: 0x000724D0
		public virtual bool IsOperating()
		{
			bool flag = false;
			bool result;
			switch (this.GetDockingOps().GetDockingOpsCondition())
			{
			case ActiveUnit_DockingOps._DockingOpsCondition.Underway:
			case ActiveUnit_DockingOps._DockingOpsCondition.RTB:
			case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
			case ActiveUnit_DockingOps._DockingOpsCondition.Replenishing:
			case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
			case ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries:
				result = true;
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Docked:
			case ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway:
			case ActiveUnit_DockingOps._DockingOpsCondition.Docking:
			case ActiveUnit_DockingOps._DockingOpsCondition.Readying:
				result = false;
				break;
			default:
				result = flag;
				break;
			}
			return result;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00009837 File Offset: 0x00007A37
		public virtual bool vmethod_119()
		{
			return !this.IsOperating() && !Information.IsNothing(this.GetDockingOps().GetHostDockFacility()) && this.GetDockingOps().GetHostDockFacility().method_26();
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00074328 File Offset: 0x00072528
		public virtual float GetMaxFuelQuantityToFill()
		{
			float result = 0f;
			try
			{
				FuelRec fuelRec = this.GetFuelRecs()[0];
				result = (float)fuelRec.MaxQuantity - fuelRec.CurrentQuantity;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100006", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00009866 File Offset: 0x00007A66
		public void AddCommDevice(CommDevice commDevice_)
		{
			ScenarioArrayUtil.AddCommDevice(ref this.m_CommDevices, commDevice_);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00009874 File Offset: 0x00007A74
		public void AddSensor(Sensor sensor_)
		{
			ScenarioArrayUtil.AddSensor(ref this.m_Sensors, sensor_);
			this.SetAllNoneMCMSensors(null);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00009889 File Offset: 0x00007A89
		public void AddAirFacility(AirFacility airFacility_)
		{
			ScenarioArrayUtil.AddAirFacility(ref this.m_AirFacilities, airFacility_);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00009897 File Offset: 0x00007A97
		public void AddDockFacility(DockFacility dockFacility_)
		{
			ScenarioArrayUtil.AddDockFacility(ref this.m_DockFacilities, dockFacility_);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000098A5 File Offset: 0x00007AA5
		public void AddFuelRec(FuelRec fuelRec_)
		{
			ScenarioArrayUtil.AddFuelRec(ref this.m_FuelRecs, fuelRec_);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000098B3 File Offset: 0x00007AB3
		public virtual void AddThreats()
		{
			this.GetAI().AddThreats();
			this.GetAI().SetPrimaryThreat(null);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000743A8 File Offset: 0x000725A8
		public void NeutralizeMine(UnguidedWeapon theMine, Sensor MineNeutralizer)
		{
			try
			{
				string str = "";
				if (this.IsAircraft && Operators.CompareString(this.Name, this.UnitClass, false) != 0)
				{
					str = " (" + this.UnitClass + ")";
				}
				theMine.ExportUnitDestroyed(ref this.m_Scenario);
				this.m_Scenario.LogMessage(this.Name + str + "已排雷: " + theMine.Name, LoggedMessage.MessageType.WeaponEndgame, 0, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
				MineNeutralizer.BeDestroyed(this.GetSide(false), false, false);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100007", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000744A8 File Offset: 0x000726A8
		public void ApplyingDamage(bool ScenEditAction, bool bool_18, float DamagePts)
		{
			checked
			{
				try
				{
					if (!ScenEditAction && !this.DEC)
					{
						if (!this.IsShip || (this.IsShip && bool_18))
						{
							this.m_Scenario.UnitDestroyedEventsTrigger(this, DamagePts);
						}
						this.DEC = true;
					}
					if (this.GetAirFacilities().Length > 0)
					{
						using (List<Aircraft>.Enumerator enumerator = this.GetAirOps().GetHostedAircrafts().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.DestroyUnit(ScenEditAction, base.MountsAreAimpoints(), true);
							}
						}
					}
					if (this.GetDockFacilities().Length > 0)
					{
						using (IEnumerator<ActiveUnit> enumerator2 = this.GetDockingOps().GetDockedUnits().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.DestroyUnit(ScenEditAction, base.MountsAreAimpoints(), true);
							}
						}
					}
					using (IEnumerator<PlatformComponent> enumerator3 = this.GetAllPlatformComponents().GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.BeDestroyed(this.GetSide(false), ScenEditAction, base.MountsAreAimpoints());
						}
					}
					Mission[] array = this.m_Scenario.GetSides().SelectMany(ActiveUnit.MissionFunc).ToArray<Mission>();
					for (int i = 0; i < array.Length; i++)
					{
						Mission mission = array[i];
						if (mission is Strike)
						{
							Strike strike = (Strike)mission;
							Contact[] array2 = strike.SpecificTargets.OfType<Contact>().ToArray<Contact>();
							for (int j = 0; j < array2.Length; j++)
							{
								Contact contact = array2[j];
								if (!Information.IsNothing(contact.ActualUnit))
								{
									if (contact.ActualUnit == this)
									{
										strike.SpecificTargets.Remove(contact);
									}
								}
								else
								{
									strike.SpecificTargets.Remove(contact);
								}
							}
							ActiveUnit[] array3 = strike.SpecificTargets.OfType<ActiveUnit>().ToArray<ActiveUnit>();
							for (int k = 0; k < array3.Length; k++)
							{
								ActiveUnit activeUnit = array3[k];
								if (activeUnit == this)
								{
									strike.SpecificTargets.Remove(activeUnit);
								}
							}
						}
					}
					Cargo[] onboardCargos = this.m_OnboardCargos;
					for (int l = 0; l < onboardCargos.Length; l++)
					{
						Cargo cargo = onboardCargos[l];
						if (cargo.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed && cargo.GetCurrentType() == Cargo._CargoType.const_1)
						{
							((Mount)cargo.GetCargo()).BeDestroyed(this.GetSide(false), ScenEditAction, true);
						}
					}
					ScenarioArrayUtil.NewSensorArray(ref this.m_Sensors);
					ScenarioArrayUtil.NewMountArray(ref this.m_Mounts);
					ScenarioArrayUtil.NewAirFacilityArray(ref this.m_AirFacilities);
					ScenarioArrayUtil.NewDockFacilityArray(ref this.m_DockFacilities);
					ScenarioArrayUtil.NewCargoArray(ref this.m_OnboardCargos);
					if (!Information.IsNothing(this.GetMagazines()))
					{
						Magazine[] magazines = this.GetMagazines();
						ScenarioArrayUtil.NewMagazineArray(ref magazines);
					}
					if (!Information.IsNothing(this.GetSide(false)))
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						list.AddRange(this.GetSide(false).ActiveUnitArray);
						List<ActiveUnit_CommLink> list2 = new List<ActiveUnit_CommLink>();
						foreach (ActiveUnit current in list)
						{
							list2.AddRange(current.GetCommStuff().GetCommLinksEstablished());
							foreach (ActiveUnit_CommLink current2 in list2)
							{
								if (current2.CommPartner == this)
								{
									current.GetCommStuff().RemoveCommLink(current2);
									if (current.IsWeapon)
									{
										Weapon weapon = (Weapon)current;
										if (!Information.IsNothing(weapon.GetDataLinkParent()))
										{
											weapon.SetDataLinkParent(null);
											Weapon weapon2 = weapon;
											float elapsedTime = 0f;
											Random random = GameGeneral.GetRandom();
											weapon2.ScheduleLifeCycleActivities(elapsedTime, ref random);
										}
									}
								}
							}
							list2.Clear();
						}
					}
					List<ActiveUnit> list3 = new List<ActiveUnit>();
					list3.AddRange(this.m_Scenario.GetActiveUnitList());
					foreach (ActiveUnit current3 in list3.Where(ActiveUnit.PlatformFilterFunc))
					{
						if (current3.IsOperating())
						{
							if (current3.IsAircraft)
							{
								if (((Aircraft)current3).GetAircraftAirOps().GetAssignedHostUnit(false) == this)
								{
									((Aircraft)current3).GetAircraftAirOps().AssignNewHostUnit();
								}
							}
							else if ((current3.IsShip || current3.IsSubmarine) && current3.GetDockingOps().GetAssignedHostUnit(false) == this)
							{
								current3.GetDockingOps().PickNewHostUnit();
							}
						}
					}
					if (!Information.IsNothing(this.GetAI().GetPrimaryTarget()))
					{
						try
						{
							ConcurrentDictionary<string, ActiveUnit> concurrentDictionary = this.GetAI().GetPrimaryTarget().method_112(this.m_Scenario, this.GetSide(false), null);
							string guid = base.GetGuid();
							ActiveUnit activeUnit2 = this;
							concurrentDictionary.TryRemove(guid, out activeUnit2);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200005", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
					if (!Information.IsNothing(this.GetSide(false)))
					{
						if (!this.IsWeapon)
						{
							this.GetSide(false).RemoveWeaponSalvoByShooterID(ref this.m_Scenario, base.GetGuid());
						}
						else
						{
							Side side = this.GetSide(false);
							string guid2 = base.GetGuid();
							side.RemoveWeaponSalvoByID(ref guid2);
						}
					}
					else if (!this.IsWeapon)
					{
						Side[] sides = this.m_Scenario.GetSides();
						for (int m = 0; m < sides.Length; m++)
						{
							sides[m].RemoveWeaponSalvoByShooterID(ref this.m_Scenario, base.GetGuid());
						}
					}
					else
					{
						Side[] sides2 = this.m_Scenario.GetSides();
						for (int n = 0; n < sides2.Length; n++)
						{
							Side side2 = sides2[n];
							string guid2 = base.GetGuid();
							side2.RemoveWeaponSalvoByID(ref guid2);
						}
					}
					if (this.HasParentGroup())
					{
						this.GetParentGroup(false).GetUnitsInGroup().Remove(base.GetGuid());
					}
					if (!ScenEditAction && !Information.IsNothing(this.GetSide(false)))
					{
						if (!this.IsShip && !this.IsWeapon && !this.IsGroup)
						{
							string str = "";
							if (this.IsAircraft && Operators.CompareString(this.Name, this.UnitClass, false) != 0)
							{
								str = " (" + this.UnitClass + ")";
							}
							this.m_Scenario.LogMessage(this.Name + str + "被摧毁!", LoggedMessage.MessageType.UnitLost, 0, base.GetGuid(), this.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
						if (!this.IsWeapon && !this.IsGroup && !base.MountsAreAimpoints())
						{
							this.GetSide(false).m_AAR.LossesAdd(this, false);
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 100008", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00074CE4 File Offset: 0x00072EE4
		private int GetMaxRisingMineRange()
		{
			int result = 0;
			try
			{
				if (!this.m_Scenario.MaxRisingMineRange_meters.HasValue)
				{
					DataTable weaponsDataTable = DBFunctions.GetWeaponsDataTable(this.m_Scenario.GetSQLiteConnection());
					float num = 0f;
					IEnumerator enumerator = weaponsDataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							if (Conversions.ToInteger(dataRow["Type"]) == 4008)
							{
								Weapon weaponFromDP = this.m_Scenario.GetWeapon(Conversions.ToInteger(dataRow["ID"])).m_Warheads[0].GetWeaponFromDP(this.m_Scenario);
								if (!Information.IsNothing(weaponFromDP))
								{
									if (weaponFromDP.RangeASUWMax > num)
									{
										num = weaponFromDP.RangeASUWMax;
									}
									if (weaponFromDP.RangeASWMax > num)
									{
										num = weaponFromDP.RangeASWMax;
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
					this.m_Scenario.MaxRisingMineRange_meters = new int?((int)Math.Round((double)(num * 1852f)));
				}
				result = this.m_Scenario.MaxRisingMineRange_meters.Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100009", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00074E94 File Offset: 0x00073094
		public virtual int GetMaxMineRange()
		{
			return this.GetMaxRisingMineRange();
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00074EAC File Offset: 0x000730AC
		public virtual int GetMaxMineRange(Weapon._WeaponType weaponType)
		{
			int result = 0;
			try
			{
				if (weaponType == Weapon._WeaponType.RisingMine)
				{
					result = this.GetMaxRisingMineRange();
				}
				else if (this.IsMineSweeper())
				{
					result = 100;
				}
				else
				{
					result = 400;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100010", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00074F38 File Offset: 0x00073138
		public virtual void DestroyUnit(bool ScenEditAction, bool IsFacilityAimpoint, bool DestroyUnitNow = false)
		{
			checked
			{
				try
				{
					this.isDestroyed = true;
					this.ApplyingDamage(ScenEditAction, false, this.GetDamage().GetDamagePts());
					Side[] sides = this.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						sides[i].RemoveActiveUnits(this, ScenEditAction);
					}
					foreach (ActiveUnit current in this.m_Scenario.GetAllWeaponsAlive())
					{
						List<Contact> list = new List<Contact>();
						Contact[] targets = current.GetAI().GetTargets();
						for (int j = 0; j < targets.Length; j++)
						{
							Contact contact = targets[j];
							if (contact.ActualUnit == this)
							{
								list.Add(contact);
							}
						}
						foreach (Contact current2 in list)
						{
							current.GetAI().DropTargeting(current2, true);
						}
					}
					using (IEnumerator<ActiveUnit> enumerator3 = this.GetDockingOps().GetDockedUnits().GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.DestroyUnit(ScenEditAction, base.MountsAreAimpoints(), true);
						}
					}
					using (List<Aircraft>.Enumerator enumerator4 = this.GetAirOps().GetHostedAircrafts().GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.DestroyUnit(ScenEditAction, base.MountsAreAimpoints(), true);
						}
					}
					if (ScenEditAction)
					{
						this.Destroy();
					}
					else if (DestroyUnitNow)
					{
						this.m_Scenario.RemoveUnit(this);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100011", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000098CC File Offset: 0x00007ACC
		protected void Destroy()
		{
			this.m_Scenario.GetActiveUnits().Remove(base.GetGuid());
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000751A4 File Offset: 0x000733A4
		public virtual void SetThrottle(ActiveUnit.Throttle newThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (this.GetThrottle() != newThrottleSetting || !Information.IsNothing(SpecificDesiredSpeed) || this.m_Scenario.MinuteIsChangingOnThisPulse)
				{
					if (newThrottleSetting > ActiveUnit.Throttle.Flank)
					{
						newThrottleSetting = ActiveUnit.Throttle.Flank;
					}
					if (newThrottleSetting < ActiveUnit.Throttle.FullStop)
					{
						newThrottleSetting = ActiveUnit.Throttle.FullStop;
					}
					if (newThrottleSetting > this.GetMaxThrottleAvailable())
					{
						newThrottleSetting = this.GetMaxThrottleAvailable();
					}
					this.currentThrottle = newThrottleSetting;
					if (!this.IsGroup)
					{
						if (Information.IsNothing(SpecificDesiredSpeed))
						{
							this.SetDesiredSpeed((float)this.GetKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle));
						}
						else if (this.GetKinematics().GetSpeedPreset() == ActiveUnit_Kinematics._SpeedPreset.None)
						{
							float? num = SpecificDesiredSpeed;
							float num2 = (float)this.GetKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), newThrottleSetting);
							bool? flag = num.HasValue ? new bool?(num.GetValueOrDefault() > num2) : null;
							bool? flag2;
							flag = (flag2 = (flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag));
							bool? flag3;
							bool? flag4;
							if (flag.HasValue && !flag2.GetValueOrDefault())
							{
								flag3 = new bool?(false);
							}
							else
							{
								num = SpecificDesiredSpeed;
								num2 = (float)this.GetKinematics().vmethod_29((float)((int)Math.Round((double)this.GetCurrentAltitude_ASL(false))), newThrottleSetting);
								flag = (num.HasValue ? new bool?(num.GetValueOrDefault() < num2) : null);
								flag = (flag4 = (flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag));
								flag3 = (flag.HasValue ? (flag2 & flag4.GetValueOrDefault()) : null);
							}
							flag4 = flag3;
							if (flag4.GetValueOrDefault())
							{
								this.SetDesiredSpeed(SpecificDesiredSpeed.Value);
							}
							else
							{
								this.currentThrottle = this.GetKinematics().vmethod_38(this.GetCurrentAltitude_ASL(false), SpecificDesiredSpeed.Value);
								num = SpecificDesiredSpeed;
								num2 = (float)this.GetKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() > num2) : null).GetValueOrDefault())
								{
									this.SetDesiredSpeed((float)this.GetKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle));
								}
							}
						}
						else
						{
							this.SetDesiredSpeed((float)this.GetKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), (ActiveUnit.Throttle)this.GetKinematics().GetSpeedPreset()));
						}
					}
					this.method_101(this, this.currentThrottle);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100013", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000754B0 File Offset: 0x000736B0
		public void method_101(ActiveUnit activeUnit_0, ActiveUnit.Throttle throttle_4)
		{
			ActiveUnit.Delegate0 @delegate = ActiveUnit.delegate0_0;
			if (@delegate != null)
			{
				@delegate(activeUnit_0, throttle_4);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000754D4 File Offset: 0x000736D4
		public bool HasRunwaysOrLandingPads()
		{
			AirFacility[] airFacilities = this.GetAirFacilities();
			checked
			{
				bool result;
				for (int i = 0; i < airFacilities.Length; i++)
				{
					if (airFacilities[i].IsTakeOffOrLandingFacility())
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000098E5 File Offset: 0x00007AE5
		public bool HasAirFacilities()
		{
			return !Information.IsNothing(this.GetAirFacilities()) && this.GetAirFacilities().Length > 0;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00009902 File Offset: 0x00007B02
		public bool HasOnboardCargos()
		{
			return this.m_OnboardCargos.Count<Cargo>() != 0;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00009915 File Offset: 0x00007B15
		public bool HasDockFacilities()
		{
			return !Information.IsNothing(this.GetDockFacilities()) && this.GetDockFacilities().Length > 0;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0007550C File Offset: 0x0007370C
		public bool HasRadar()
		{
			bool flag = false;
			bool result;
			try
			{
				List<Sensor> list = new List<Sensor>();
				list.AddRange(this.GetAllNoneMCMSensors());
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (list[i].sensorType == Sensor.SensorType.Radar)
					{
						flag = true;
						result = true;
						return result;
					}
				}
				if (this.IsWeapon)
				{
					Weapon weapon = (Weapon)this;
					Warhead[] warheads = weapon.m_Warheads;
					for (int j = 0; j < warheads.Length; j = checked(j + 1))
					{
						Warhead warhead = warheads[j];
						if (warhead.warheadType == Warhead.WarheadType.Weapon)
						{
							Weapon weaponFromDP = warhead.GetWeaponFromDP(weapon.m_Scenario);
							List<Sensor> list2 = new List<Sensor>();
							list2.AddRange(weaponFromDP.GetAllNoneMCMSensors());
							int num2 = list2.Count - 1;
							for (int k = 0; k <= num2; k++)
							{
								if (list2[k].sensorType == Sensor.SensorType.Radar)
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100014", "");
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

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0007568C File Offset: 0x0007388C
		public bool HasInfraredSensor()
		{
			bool flag = false;
			bool result;
			try
			{
				List<Sensor> list = new List<Sensor>();
				list.AddRange(this.GetAllNoneMCMSensors());
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (list[i].sensorType == Sensor.SensorType.Infrared)
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
				ex2.Data.Add("Error at 100015", "");
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

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00009932 File Offset: 0x00007B32
		public bool HaveMineCounterMeasures()
		{
			return this.GetMineCounterMeasures().Count > 0;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00009942 File Offset: 0x00007B42
		public bool HasPassiveSensor()
		{
			return this.GetNoneMCMSensors().Where(ActiveUnit.IsPassiveSensor).Count<Sensor>() > 0;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00075740 File Offset: 0x00073940
		public bool HasActiveSonar()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Sensor[] allNoneMCMSensors = this.GetAllNoneMCMSensors();
					for (int i = 0; i < allNoneMCMSensors.Length; i++)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if (sensor.IsSonar() && sensor.IsActiveCapable())
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
					ex2.Data.Add("Error at 100016", "");
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
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0000995C File Offset: 0x00007B5C
		public bool HasParentGroup()
		{
			return !Information.IsNothing(this.GetParentGroup(false));
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0000996D File Offset: 0x00007B6D
		public bool IsNotGroupLead()
		{
			return this.HasParentGroup() && !this.IsGroupLead();
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00009983 File Offset: 0x00007B83
		public bool IsGroupLead()
		{
			return this.HasParentGroup() && this.GetParentGroup(false).GetGroupLead() == this;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000757E0 File Offset: 0x000739E0
		public void method_114(Mission.Flight Flight_, int FlightRole_)
		{
			if (this.HasParentGroup())
			{
				switch (FlightRole_)
				{
				case 1:
					this.FlightRole = Mission.Flight._FlightRole.const_1;
					break;
				case 2:
					if (this.GetParentGroup(false).GetUnitsInGroup().Count == 3)
					{
						this.FlightRole = Mission.Flight._FlightRole.const_7;
					}
					else
					{
						this.FlightRole = Mission.Flight._FlightRole.const_2;
					}
					break;
				case 3:
					if (this.GetParentGroup(false).GetUnitsInGroup().Count == 3)
					{
						this.FlightRole = Mission.Flight._FlightRole.const_7;
					}
					else
					{
						this.FlightRole = Mission.Flight._FlightRole.const_3;
					}
					break;
				case 4:
					this.FlightRole = Mission.Flight._FlightRole.const_4;
					break;
				case 5:
					this.FlightRole = Mission.Flight._FlightRole.const_5;
					break;
				case 6:
					this.FlightRole = Mission.Flight._FlightRole.const_6;
					break;
				default:
					this.FlightRole = Mission.Flight._FlightRole.const_7;
					break;
				}
			}
			else
			{
				this.FlightRole = Mission.Flight._FlightRole.const_0;
			}
			this.GetNavigator().SetFlight(Flight_);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0000999F File Offset: 0x00007B9F
		public void LogMessage(string string_9, LoggedMessage.MessageType messageType_0, byte byte_0, bool bool_17, GeoPoint geoPoint_0)
		{
			if (bool_17)
			{
				this.Message = string_9;
			}
			this.m_Scenario.LogMessage(string_9, messageType_0, byte_0, base.GetGuid(), this.GetSide(false), geoPoint_0);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000099CC File Offset: 0x00007BCC
		public void RemoveCommDevice(CommDevice commDevice_1)
		{
			ScenarioArrayUtil.RemoveCommDevice(ref this.m_CommDevices, commDevice_1);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000758B8 File Offset: 0x00073AB8
		public virtual void TransferFuel(float FuelQuantity_, FuelRec._FuelType FuelType_)
		{
			try
			{
				float num = FuelQuantity_;
				FuelRec[] fuelRecs = this.GetFuelRecs();
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					if (num == 0f)
					{
						break;
					}
					if (fuelRec.FuelType == FuelType_)
					{
						float num2 = (float)fuelRec.MaxQuantity - fuelRec.CurrentQuantity;
						if (num2 > num)
						{
							fuelRec.CurrentQuantity += num;
							num = 0f;
						}
						else
						{
							fuelRec.CurrentQuantity = (float)fuelRec.MaxQuantity;
							num -= num2;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100017", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00075994 File Offset: 0x00073B94
		public virtual void ConsumeFuel(float FuelConsumed_, FuelRec._FuelType FuelType_)
		{
			ActiveUnit.FuelTyeComparator fuelTyeComparator = new ActiveUnit.FuelTyeComparator();
			fuelTyeComparator.fuelType = FuelType_;
			try
			{
				if (FuelConsumed_ != 0f)
				{
					FuelRec fuelRec = this.GetFuelRecs().Select(ActiveUnit.FuelRecFunc).Where(new Func<FuelRec, bool>(fuelTyeComparator.IsSame)).ElementAtOrDefault(0);
					if (fuelRec.CurrentQuantity > FuelConsumed_)
					{
						fuelRec.CurrentQuantity -= FuelConsumed_;
					}
					else
					{
						bool flag = fuelRec.CurrentQuantity > 0f;
						fuelRec.CurrentQuantity = 0f;
						this.SetThrottle(ActiveUnit.Throttle.FullStop, null);
						if (flag)
						{
							this.LogMessage(this.Name + " (" + Misc.smethod_11(this.UnitClass) + ")燃油耗尽!", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100018", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void UpdatePropulsionState(float elapsedTime)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00075AD0 File Offset: 0x00073CD0
		public virtual void SetHomeBase(ActiveUnit NewHost_)
		{
			bool flag = !NewHost_.IsGroup;
			bool flag2 = false;
			bool flag3 = false;
			if (NewHost_.IsGroup)
			{
				if (((Group)NewHost_).GetGroupType() == Group.GroupType.AirBase)
				{
					flag3 = true;
				}
				else
				{
					flag2 = true;
				}
			}
			if (flag || flag3)
			{
				string text = this.GetDockingOps().method_42(NewHost_);
				if (Operators.CompareString(text, "OK", false) == 0)
				{
					this.GetDockingOps().SetAssignedHostUnit(false, NewHost_);
					this.m_Scenario.LogMessage(NewHost_.Name + " 成为" + this.Name + "的基地", LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else
				{
					this.m_Scenario.LogMessage(string.Concat(new string[]
					{
						"不能将",
						NewHost_.Name,
						"设置成为",
						this.Name,
						"的新基地，原因为: ",
						text
					}), LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
			}
			if (flag2)
			{
				Unit unit = null;
				foreach (ActiveUnit current in ((Group)NewHost_).GetUnitsInGroup().Values)
				{
					if (Operators.CompareString(this.GetDockingOps().method_42(current), "OK", false) == 0)
					{
						this.GetDockingOps().SetAssignedHostUnit(false, current);
						unit = current;
						break;
					}
				}
				if (unit == null)
				{
					this.m_Scenario.LogMessage(string.Concat(new string[]
					{
						"不能将",
						NewHost_.Name,
						"设为",
						this.Name,
						"的新基地"
					}), LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else
				{
					this.m_Scenario.LogMessage(NewHost_.Name + "现在成为" + this.Name + "的新基地", LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00075D10 File Offset: 0x00073F10
		public void method_117()
		{
			checked
			{
				try
				{
					ActiveUnit_AI aI = this.GetAI();
					ActiveUnit activeUnit = this;
					aI.ClearPrimaryTarget(ref activeUnit);
					Side[] sides = this.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						sides[i].AddToLazy3Dictionary(this);
					}
					ActiveUnit currentHostUnit;
					if (this.IsAircraft)
					{
						currentHostUnit = ((Aircraft)this).GetAircraftAirOps().GetCurrentHostUnit();
					}
					else
					{
						currentHostUnit = this.GetDockingOps().GetCurrentHostUnit();
					}
					if (!Information.IsNothing(currentHostUnit))
					{
						if (currentHostUnit.GetCommStuff().IsNotOutOfComms())
						{
							this.GetCommStuff().SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.const_0, true);
						}
						else if (this.GetCommStuff().IsNotOutOfComms())
						{
							ActiveUnit_CommStuff._OOCReason reasonOfOffGrid = currentHostUnit.GetCommStuff().GetReasonOfOffGrid();
							currentHostUnit.GetCommStuff().SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.const_0, true);
							currentHostUnit.GetCommStuff().SetIsNotOutOfComms(reasonOfOffGrid, false);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100019", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00075E38 File Offset: 0x00074038
		public void RemoveSensor(Sensor sensor_)
		{
			checked
			{
				try
				{
					ScenarioArrayUtil.RemoveSensor(ref this.m_Sensors, sensor_);
					Mount[] mounts = this.m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						mounts[i].RemoveSensor(sensor_);
					}
					this.SetAllNoneMCMSensors(null);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100020", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000099DA File Offset: 0x00007BDA
		private void EngineCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.GetKinematics().ResetMaxSpeed();
			this.m_Throttle = null;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00075EC8 File Offset: 0x000740C8
		public bool HasBeenTargeted(Scenario scenario_)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (scenario_.GetGuidedWeaponsInAir().Count > 0)
					{
						List<Weapon> guidedWeaponsInAir = scenario_.GetGuidedWeaponsInAir();
						if (Information.IsNothing(guidedWeaponsInAir))
						{
							flag = false;
							result = false;
							return result;
						}
						foreach (Weapon current in guidedWeaponsInAir)
						{
							if (!Information.IsNothing(current))
							{
								Weapon_AI weaponAI = current.GetWeaponAI();
								if (!Information.IsNothing(weaponAI) && !Information.IsNothing(weaponAI.GetPrimaryTarget()) && !Information.IsNothing(weaponAI.GetPrimaryTarget().ActualUnit) && weaponAI.GetPrimaryTarget().ActualUnit == this)
								{
									flag = true;
									result = true;
									return result;
								}
								if (current.IsMREV_GuidedBallisticMissile())
								{
									Contact[] targets = weaponAI.GetTargets();
									for (int i = 0; i < targets.Length; i++)
									{
										Contact contact = targets[i];
										if (!Information.IsNothing(contact.ActualUnit) && contact.ActualUnit == this)
										{
											flag = true;
											result = true;
											return result;
										}
									}
								}
							}
						}
					}
					if (scenario_.GetUnitAdditions().Count > 0)
					{
						List<ActiveUnit> list = scenario_.GetUnitAdditions().ToList<ActiveUnit>();
						foreach (ActiveUnit current2 in list)
						{
							if (current2.IsWeapon)
							{
								Weapon_AI weaponAI = ((Weapon)current2).GetWeaponAI();
								if (!Information.IsNothing(weaponAI.GetPrimaryTarget()) && !Information.IsNothing(weaponAI.GetPrimaryTarget().ActualUnit) && weaponAI.GetPrimaryTarget().ActualUnit == this)
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200273", ex2.Message);
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
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00076130 File Offset: 0x00074330
		public void method_121(bool bool_17, bool bool_18)
		{
			if (!this.IsWeapon && this.HasParentGroup())
			{
				try
				{
					if (this.IsGroupLead() && this.GetParentGroup(false).GetUnitsInGroup().Count > 1)
					{
						ActiveUnit activeUnit = null;
						if (this.IsFacility)
						{
							using (IEnumerator<ActiveUnit> enumerator = this.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									ActiveUnit current = enumerator.Current;
									if (current != this)
									{
										activeUnit = current;
									}
								}
								goto IL_FA;
							}
						}
						double num = 0.0;
						foreach (ActiveUnit current2 in this.GetParentGroup(false).GetUnitsInGroup().Values)
						{
							if (current2 != this && (double)current2.WeightEmpty > num)
							{
								activeUnit = current2;
								num = (double)current2.WeightEmpty;
							}
						}
						IL_FA:
						if (!Information.IsNothing(activeUnit))
						{
							this.GetParentGroup(false).SetGroupLead(activeUnit);
							activeUnit.SetUnitStatus(this.GetUnitStatus());
							activeUnit.GetKinematics().SetDesiredSpeedOverride(this.GetKinematics().GetDesiredSpeedOverride());
							activeUnit.GetKinematics().SetDesiredAltitudeOverride(this.GetKinematics().GetDesiredAltitudeOverride());
							activeUnit.SetDesiredAltitude(this.GetDesiredAltitude());
							activeUnit.SetDesiredAltitude_TerrainFollowing(this.GetDesiredAltitude_TerrainFollowing());
							activeUnit.SetDesiredSpeed(this.GetDesiredSpeed());
							activeUnit.SetIsTerrainFollowing(activeUnit, this.IsTerrainFollowing(this));
						}
					}
					if (bool_17)
					{
						string str = "";
						if (this.IsAircraft && Operators.CompareString(this.Name, this.UnitClass, false) != 0)
						{
							str = " (" + this.UnitClass + ")";
						}
						this.m_Scenario.LogMessage(this.Name + str + "已脱离作战编组: " + this.GetParentGroup(false).Name, LoggedMessage.MessageType.UnitAI, 5, base.GetGuid(), this.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
					this.SetParentGroup(false, null);
					if (bool_18)
					{
						this.GetNavigator().ClearPlottedCourse();
					}
					this.GetKinematics().SetDesiredSpeedOverride(null);
					this.GetKinematics().SetDesiredAltitudeOverride(false);
					this.m_Doctrine.Init();
					this.GetSensory().ScheduleEMCONEvent(this.GetAllNoneMCMSensors());
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101262", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00076444 File Offset: 0x00074644
		public bool method_122(double Lat_, double Lon_, float float_20)
		{
			bool flag = false;
			bool result;
			try
			{
				foreach (NoNavZone current in this.GetSide(false).NoNavZoneList)
				{
					if (current.Area.Count != 0 && current.IsAffected(this))
					{
						if (float_20 == 0.2f)
						{
							if (current.list_1.Count == 0 || current.method_16(current.list_1))
							{
								current.method_12(float_20, ref current.list_3, ref current.list_1);
							}
							if (new GeoPoint(Lon_, Lat_).method_21(ref current.list_3, true))
							{
								flag = true;
								result = true;
								return result;
							}
						}
						else if (float_20 == 0.15f)
						{
							if (current.list_2.Count == 0 || current.method_16(current.list_2))
							{
								current.method_12(float_20, ref current.list_4, ref current.list_2);
							}
							if (new GeoPoint(Lon_, Lat_).method_21(ref current.list_4, true))
							{
								flag = true;
								result = true;
								return result;
							}
						}
						else if (new GeoPoint(Lon_, Lat_).method_22(ref current.Area, true))
						{
							flag = true;
							result = true;
							return result;
						}
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101268", "");
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

		// Token: 0x06000ABC RID: 2748 RVA: 0x0007660C File Offset: 0x0007480C
		public bool AboutToEnterNoNavZone()
		{
			bool result = false;
			try
			{
				if (this.GetSide(false).NoNavZoneList.Count == 0)
				{
					result = false;
				}
				else
				{
					if (this.GetNavigator().TimeToCheckNoNavZoneViolation <= 0)
					{
						float num = 3.40282347E+38f;
						foreach (NoNavZone current in this.GetSide(false).NoNavZoneList)
						{
							if (current.Area.Count != 0 && current.IsAffected(this))
							{
								float num2 = current.method_13(this.GetLatitude(null), this.GetLongitude(null), this.m_Scenario);
								if (num2 < num)
								{
									num = num2;
								}
							}
						}
						if (num < 10f)
						{
							this.GetNavigator().TimeToCheckNoNavZoneViolation = 300;
							this.GetNavigator().bool_12 = true;
						}
						else
						{
							double num3 = (double)((num - 5f) / (float)this.GetKinematics().GetMaxSpeed() * 3600f);
							if (num3 > 300.0)
							{
								num3 = 300.0;
							}
							this.GetNavigator().TimeToCheckNoNavZoneViolation = (short)Math.Round(num3);
							this.GetNavigator().bool_12 = false;
						}
					}
					result = this.GetNavigator().bool_12;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200340", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.GetNavigator().TimeToCheckNoNavZoneViolation = 300;
				this.GetNavigator().bool_12 = true;
				result = true;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00076810 File Offset: 0x00074A10
		internal void ExportFuelConsumed(float FuelConsumption_, FuelRec._FuelType FuelType_)
		{
			foreach (IEventExporter current in this.m_Scenario.GetEventExporters())
			{
				if (current.IsExportFuelConsumed())
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>(9);
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), this.m_Scenario.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = this.m_Scenario.GetCurrentTime(false).Subtract(this.m_Scenario.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), this.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + this.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), this.Name));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), this.UnitClass));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), this.GetSide(false).GetSideName()));
					dictionary.Add("FuelQuantity", new Tuple<Type, string>(typeof(float), Conversions.ToString(FuelConsumption_)));
					dictionary.Add("FuelType", new Tuple<Type, string>(typeof(int), Conversions.ToString((int)FuelType_)));
					dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), ""));
					current.ExportEvent(ExportedEventType.FuelConsumed, dictionary, this.m_Scenario);
				}
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00076A54 File Offset: 0x00074C54
		internal void ExportFuelTransfer(ActiveUnit activeUnit_, float FuelTransfered_, FuelRec._FuelType FuelType_)
		{
			foreach (IEventExporter current in this.m_Scenario.GetEventExporters())
			{
				if (current.IsExportFuelTransfer())
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>(13);
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), this.m_Scenario.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = this.m_Scenario.GetCurrentTime(false).Subtract(this.m_Scenario.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), this.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + this.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), this.Name));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), this.UnitClass));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), this.GetSide(false).GetSideName()));
					dictionary.Add("ReceiverID", new Tuple<Type, string>(typeof(string), activeUnit_.GetGuid()));
					dictionary.Add("ReceiverName", new Tuple<Type, string>(typeof(string), activeUnit_.Name));
					dictionary.Add("ReceiverClass", new Tuple<Type, string>(typeof(string), activeUnit_.UnitClass));
					dictionary.Add("ReceiverSide", new Tuple<Type, string>(typeof(string), activeUnit_.GetSide(false).GetSideName()));
					dictionary.Add("FuelQuantity", new Tuple<Type, string>(typeof(float), Conversions.ToString(FuelTransfered_)));
					dictionary.Add("FuelType", new Tuple<Type, string>(typeof(int), Conversions.ToString((int)FuelType_)));
					dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), ""));
					current.ExportEvent(ExportedEventType.FuelTransfer, dictionary, this.m_Scenario);
				}
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000099F3 File Offset: 0x00007BF3
		[CompilerGenerated]
		private bool IsFiringParentOfTerminalIlluminationWeapon(Weapon weapon_)
		{
			return weapon_.GetFiringParent() == this && weapon_.weaponCode.TerminalIllumination;
		}

		// Token: 0x0400042D RID: 1069
		public static Func<AirFacility, bool> AirFacilityFunc = (AirFacility airFacility_0) => airFacility_0.method_35();

		// Token: 0x0400042E RID: 1070
		public static Func<Sensor, bool> MineCounterMeasureFilterFunc1 = (Sensor sensor_0) => sensor_0.IsMineCounterMeasure();

		// Token: 0x0400042F RID: 1071
		public static Func<Sensor, bool> TrackingAndDirectingSensorFilter = (Sensor sensor_0) => sensor_0.GetTargetsTrackedForFireControl().Count > 0 || sensor_0.SemiActiveGuidedWeaponList.Count > 0;

		// Token: 0x04000430 RID: 1072
		public static Func<Side, IEnumerable<Mission>> MissionFunc = (Side side_0) => side_0.GetMissionCollection();

		// Token: 0x04000431 RID: 1073
		public static Func<ActiveUnit, bool> PlatformFilterFunc = (ActiveUnit activeUnit_0) => activeUnit_0.IsPlatform();

		// Token: 0x04000432 RID: 1074
		public static Func<Sensor, bool> IsPassiveSensor = (Sensor sensor_0) => !sensor_0.IsActiveCapable();

		// Token: 0x04000433 RID: 1075
		public static Func<FuelRec, FuelRec> FuelRecFunc = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x04000434 RID: 1076
		public int DBID;

		// Token: 0x04000435 RID: 1077
		private double? LongitudeLR;

		// Token: 0x04000436 RID: 1078
		private double? LatitudeLR;

		// Token: 0x04000437 RID: 1079
		protected float desiredHeading;

		// Token: 0x04000438 RID: 1080
		protected float desiredSpeed;

		// Token: 0x04000439 RID: 1081
		protected float desiredAltitude;

		// Token: 0x0400043A RID: 1082
		protected float DesiredAltitude_TerrainFollowing;

		// Token: 0x0400043B RID: 1083
		protected ActiveUnit._TurnRate DesiredTurnRate;

		// Token: 0x0400043C RID: 1084
		protected Waypoint._TurnRate desiredTurnRate_Navigation;

		// Token: 0x0400043D RID: 1085
		protected bool bTerrainFollowing;

		// Token: 0x0400043E RID: 1086
		public float float_11;

		// Token: 0x0400043F RID: 1087
		public int WeightEmpty;

		// Token: 0x04000440 RID: 1088
		public int WeightMax;

		// Token: 0x04000441 RID: 1089
		public int WeightPayload = 0;

		// Token: 0x04000442 RID: 1090
		public Scenario m_Scenario;

		// Token: 0x04000443 RID: 1091
		protected ActiveUnit.Throttle currentThrottle;

		// Token: 0x04000444 RID: 1092
		protected Sensor[] m_Sensors;

		// Token: 0x04000445 RID: 1093
		protected CommDevice[] m_CommDevices;

		// Token: 0x04000446 RID: 1094
		[CompilerGenerated]
		private ObservableCollection<Engine> m_EngineCollection;

		// Token: 0x04000447 RID: 1095
		protected FuelRec[] m_FuelRecs;

		// Token: 0x04000448 RID: 1096
		private List<XSection> m_XSections;

		// Token: 0x04000449 RID: 1097
		public Mount[] m_Mounts;

		// Token: 0x0400044A RID: 1098
		public Cargo[] m_OnboardCargos;

		// Token: 0x0400044B RID: 1099
		protected ActiveUnit._ActiveUnitStatus activeUnitStatus;

		// Token: 0x0400044C RID: 1100
		protected ActiveUnit._ActiveUnitFuelState activeUnitFuelState;

		// Token: 0x0400044D RID: 1101
		protected ActiveUnit._ActiveUnitWeaponState weaponState;

		// Token: 0x0400044E RID: 1102
		private float DamagePts;

		// Token: 0x0400044F RID: 1103
		protected AirFacility[] m_AirFacilities;

		// Token: 0x04000450 RID: 1104
		protected DockFacility[] m_DockFacilities;

		// Token: 0x04000451 RID: 1105
		protected Mission AssignedMission;

		// Token: 0x04000452 RID: 1106
		protected string AssignedMissionName;

		// Token: 0x04000453 RID: 1107
		protected Mission AssignedTaskPool;

		// Token: 0x04000454 RID: 1108
		protected string AssignedTaskPoolName;

		// Token: 0x04000455 RID: 1109
		protected Group parentGroup;

		// Token: 0x04000456 RID: 1110
		protected string ParentGroupName;

		// Token: 0x04000457 RID: 1111
		private bool bAutoDetectable;

		// Token: 0x04000458 RID: 1112
		public Doctrine m_Doctrine;

		// Token: 0x04000459 RID: 1113
		internal bool bUnitStatusChanged;

		// Token: 0x0400045A RID: 1114
		protected string strSide;

		// Token: 0x0400045B RID: 1115
		internal short OODADetectionCycle;

		// Token: 0x0400045C RID: 1116
		internal short OODATargetingCycle;

		// Token: 0x0400045D RID: 1117
		internal short OODAEvasiveCycle;

		// Token: 0x0400045E RID: 1118
		private ActiveUnit.Throttle? m_Throttle;

		// Token: 0x0400045F RID: 1119
		internal ActiveUnit._ActiveUnitStatus m_ActiveUnitStatus;

		// Token: 0x04000460 RID: 1120
		internal ActiveUnit._ActiveUnitStatus SBR;

		// Token: 0x04000461 RID: 1121
		internal ActiveUnit._ActiveUnitStatus SBEngagedDefensive;

		// Token: 0x04000462 RID: 1122
		internal ActiveUnit._ActiveUnitStatus SBEngagedOffensive;

		// Token: 0x04000463 RID: 1123
		internal ActiveUnit._ActiveUnitFuelState FuelStateBR;

		// Token: 0x04000464 RID: 1124
		internal float SBR_Altitude;

		// Token: 0x04000465 RID: 1125
		internal float SBR_Altitude_TerrainFollowing;

		// Token: 0x04000466 RID: 1126
		internal bool SBR_TerrainFollowing;

		// Token: 0x04000467 RID: 1127
		internal ActiveUnit.Throttle SBR_ThrottleSetting;

		// Token: 0x04000468 RID: 1128
		internal float SBEngagedDefensive_Altitude;

		// Token: 0x04000469 RID: 1129
		internal float SBEngagedDefensive_Altitude_TerrainFollowing;

		// Token: 0x0400046A RID: 1130
		internal bool SBEngagedDefensive_TerrainFollowing;

		// Token: 0x0400046B RID: 1131
		internal ActiveUnit.Throttle SBEngagedDefensive_ThrottleSetting;

		// Token: 0x0400046C RID: 1132
		internal float SBEngagedOffensive_Altitude;

		// Token: 0x0400046D RID: 1133
		internal float SBEngagedOffensive_Altitude_TerrainFollowing;

		// Token: 0x0400046E RID: 1134
		internal bool SBEngagedOffensive_TerrainFollowing;

		// Token: 0x0400046F RID: 1135
		internal ActiveUnit.Throttle SBEngagedOffensive_ThrottleSetting;

		// Token: 0x04000470 RID: 1136
		public float float_19;

		// Token: 0x04000471 RID: 1137
		protected GlobalVariables.ProficiencyLevel? m_ProficiencyLevel;

		// Token: 0x04000472 RID: 1138
		public int OperatorCountry = 0;

		// Token: 0x04000473 RID: 1139
		public bool Hypothetical;

		// Token: 0x04000474 RID: 1140
		private string strUnitType;

		// Token: 0x04000475 RID: 1141
		public bool isDestroyed;

		// Token: 0x04000476 RID: 1142
		public Weapon[] m_Weapons;

		// Token: 0x04000477 RID: 1143
		private Random random;

		// Token: 0x04000478 RID: 1144
		private int InitialDP;

		// Token: 0x04000479 RID: 1145
		public Mission.Flight._FlightRole FlightRole;

		// Token: 0x0400047A RID: 1146
		public ActiveUnit._RefuelOrReplenish RefuelOrReplenish;

		// Token: 0x0400047B RID: 1147
		private ActiveUnit_Navigator m_Navigator;

		// Token: 0x0400047C RID: 1148
		protected ActiveUnit_AI m_AI;

		// Token: 0x0400047D RID: 1149
		private ActiveUnit_Kinematics m_Kinematics;

		// Token: 0x0400047E RID: 1150
		protected ActiveUnit_Sensory m_Sensory;

		// Token: 0x0400047F RID: 1151
		private ActiveUnit_Weaponry m_Weaponry;

		// Token: 0x04000480 RID: 1152
		protected ActiveUnit_CommStuff m_CommStuff;

		// Token: 0x04000481 RID: 1153
		protected ActiveUnit_Damage m_Damage;

		// Token: 0x04000482 RID: 1154
		protected ActiveUnit_DockingOps m_DockingOps;

		// Token: 0x04000483 RID: 1155
		protected ActiveUnit_AirOps m_AirOps;

		// Token: 0x04000484 RID: 1156
		internal List<string> AirFacilities;

		// Token: 0x04000485 RID: 1157
		[CompilerGenerated]
		private static ActiveUnit.Delegate0 delegate0_0;

		// Token: 0x04000486 RID: 1158
		protected bool DEC;

		// Token: 0x04000487 RID: 1159
		private Sensor[] m_AllNoneMCMSensors;

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x06000AC9 RID: 2761
		public delegate void Delegate0(ActiveUnit theUnit, ActiveUnit.Throttle NewThrottleSetting);

		// Token: 拐弯速率
		public enum _TurnRate : byte
		{
			// Token: 0x04000490 RID: 1168
			const_0,
			// Token: 0x04000491 RID: 1169
			const_1
		}

		// Token: 0x020001BE RID: 446
		public enum Throttle : byte
		{
			// Token: 0x04000493 RID: 1171
			FullStop,
			// Token: 0x04000494 RID: 1172
			Loiter,
			// Token: 0x04000495 RID: 1173
			Cruise,
			// Token: 0x04000496 RID: 1174
			Full,
			// Token: 0x04000497 RID: 1175
			Flank
		}

		// Token: 单元状态
		public enum _ActiveUnitStatus : byte
		{
			// Token: 未指定
			Unassigned,
			// Token: 绘制航向
			OnPlottedCourse,
			// Token: 进攻作战
			EngagedOffensive,
			// Token: 防卫作战
			EngagedDefensive,
			// Token: 0x0400049D RID: 1181
			OnAttackRun,
			// Token: 巡逻
			OnPatrol,
			// Token: 返回机场
			RTB,
			// Token: 0x040004A0 RID: 1184
			Tasked,
			// Token: 0x040004A1 RID: 1185
			FormingUp,
			// Token: 0x040004A2 RID: 1186
			RTB_Manual = 10,
			// Token: 0x040004A3 RID: 1187
			OnSupportMission,
			// Token: 0x040004A4 RID: 1188
			OnFerryMission,
			// Token: 0x040004A5 RID: 1189
			HeadingToRefuelPoint,
			// Token: 0x040004A6 RID: 1190
			Refuelling,
			// Token: 0x040004A7 RID: 1191
			RTB_MissionOver,
			// Token: 0x040004A8 RID: 1192
			GroupLead_SlowingToAllowFormUp,
			// Token: 0x040004A9 RID: 1193
			RTB_Group = 19,
			// Token: 0x040004AA RID: 1194
			RTB_CalledOff
		}

		// Token: 燃料状态
		public enum _ActiveUnitFuelState : byte
		{
			// Token: 0x040004AC RID: 1196
			None,
			// Token: 0x040004AD RID: 1197
			IsBingo,
			// Token: 0x040004AE RID: 1198
			IsJoker,
			// Token: 0x040004AF RID: 1199
			IgnoreBingoAndJoker
		}

		// Token: 武器状态
		public enum _ActiveUnitWeaponState : byte
		{
			// Token: 0x040004B1 RID: 1201
			None,
			// Token: 0x040004B2 RID: 1202
			IsWinchester,
			// Token: 0x040004B3 RID: 1203
			IsWinchester_EngagingToO,
			// Token: 0x040004B4 RID: 1204
			IsShotgun,
			// Token: 0x040004B5 RID: 1205
			IsShotgun_EngagingToO,
			// Token: 0x040004B6 RID: 1206
			IgnoreWinchesterAndShotgun
		}

		// Token: 0x020001C2 RID: 450
		public enum _ContrailDetected : byte
		{
			// Token: 0x040004B8 RID: 1208
			None,
			// Token: 0x040004B9 RID: 1209
			VerySmall,
			// Token: 0x040004BA RID: 1210
			Small,
			// Token: 0x040004BB RID: 1211
			Medium,
			// Token: 0x040004BC RID: 1212
			Large,
			// Token: 0x040004BD RID: 1213
			VeryLarge
		}

		// Token: 0x020001C3 RID: 451
		public struct _RefuelOrReplenish
		{
			// Token: 0x040004BE RID: 1214
			internal byte byte_0;

			// Token: 0x040004BF RID: 1215
			internal byte byte_1;

			// Token: 0x040004C0 RID: 1216
			internal byte RefuelFromAstern_In;

			// Token: 0x040004C1 RID: 1217
			internal byte RefuelToAstern_Out;

			// Token: 0x040004C2 RID: 1218
			internal byte RefuelFromPort_In;

			// Token: 0x040004C3 RID: 1219
			internal byte RefuelToPort_Out;

			// Token: 0x040004C4 RID: 1220
			internal byte RefuelFromStarboard_In;

			// Token: 0x040004C5 RID: 1221
			internal byte RefuelToStarboard_Out;

			// Token: 0x040004C6 RID: 1222
			internal byte ReplenishFromPort_In;

			// Token: 0x040004C7 RID: 1223
			internal byte ReplenishToPort_Out;

			// Token: 0x040004C8 RID: 1224
			internal byte ReplenishFromStarboard_In;

			// Token: 0x040004C9 RID: 1225
			internal byte ReplenishToStarboard_Out;
		}

		// Token: 0x020001C4 RID: 452
		[CompilerGenerated]
		public sealed class FireControl
		{
			// Token: 0x06000ACC RID: 2764 RVA: 0x00009A50 File Offset: 0x00007C50
			internal bool IsTargetTracked(Sensor sensor_)
			{
				return sensor_.GetTargetsTrackedForFireControl().Contains(this.Target);
			}

			// Token: 0x040004CA RID: 1226
			public Contact Target;
		}

		// Token: 0x020001C5 RID: 453
		[CompilerGenerated]
		public sealed class FuelTyeComparator
		{
			// Token: 0x06000ACE RID: 2766 RVA: 0x00009A63 File Offset: 0x00007C63
			internal bool IsSame(FuelRec fuelRec)
			{
				return fuelRec.FuelType == this.fuelType;
			}

			// Token: 0x040004CB RID: 1227
			public FuelRec._FuelType fuelType;
		}
	}
}
