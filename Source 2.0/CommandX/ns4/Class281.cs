using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Command_Core;
using Command_Core.DAL;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns3;

namespace ns4
{
	// Token: 0x02000C45 RID: 3141
	public sealed class Class281
	{
		// Token: 0x060068BD RID: 26813 RVA: 0x0037F8FC File Offset: 0x0037DAFC
		public static LuaTable smethod_0(LuaTable luaTable_0, LuaTable luaTable_1, Scenario scenario_)
		{
			Dictionary<string, object> dictionary = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Doctrine doctrine = null;
			Side side = null;
			if (dictionary.ContainsKey("GUID"))
			{
				string text = Conversions.ToString(dictionary["GUID"]);
				try
				{
					doctrine = scenario_.GetActiveUnits()[text].m_Doctrine;
					goto IL_342;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Can't find guid '" + text + "'");
				}
			}
			if (!dictionary.ContainsKey("NAME") && !dictionary.ContainsKey("UNITNAME"))
			{
				if (dictionary.ContainsKey("MISSION"))
				{
					Class281.Class283 @class = new Class281.Class283(null);
					@class.string_0 = Conversions.ToString(dictionary["MISSION"]);
					if (dictionary.ContainsKey("SIDE"))
					{
						string str = Conversions.ToString(dictionary["SIDE"]);
						try
						{
							side = LuaUtility.smethod_15(dictionary, scenario_);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							throw new Exception2("Can't find Side '" + str + "'");
						}
						try
						{
							Mission mission = side.GetMissionCollection().FirstOrDefault(new Func<Mission, bool>(@class.method_0));
							if (dictionary.ContainsKey("ESCORT") & mission.MissionClass == Mission._MissionClass.Strike)
							{
								doctrine = ((Strike)mission).Doctrine_Escorts;
							}
							else
							{
								doctrine = mission.m_Doctrine;
							}
							goto IL_342;
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							throw new Exception2("Can't find Mission '" + @class.string_0 + "'");
						}
					}
					throw new Exception2("To select a mission you need to define a side.");
				}
				if (!dictionary.ContainsKey("SIDE"))
				{
					goto IL_342;
				}
				string str2 = Conversions.ToString(dictionary["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(dictionary, scenario_);
					doctrine = side.m_Doctrine;
					goto IL_342;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					throw new Exception2("Can't find Side '" + str2 + "'");
				}
			}
			Class281.Class282 class2 = new Class281.Class282(null);
			class2.string_0 = null;
			if (dictionary.ContainsKey("NAME"))
			{
				class2.string_0 = Conversions.ToString(dictionary["NAME"]);
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				class2.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
			}
			if (dictionary.ContainsKey("SIDE"))
			{
				string text2 = Conversions.ToString(dictionary["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(dictionary, scenario_);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					throw new Exception2("Can't find Side '" + text2 + "'");
				}
				try
				{
					doctrine = side.ActiveUnitArray.FirstOrDefault(new Func<ActiveUnit, bool>(class2.method_0)).m_Doctrine;
					goto IL_342;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					throw new Exception2(string.Concat(new string[]
					{
						"Can't find Unit '",
						class2.string_0,
						"' on Side '",
						text2,
						"'"
					}));
				}
			}
			try
			{
				doctrine = scenario_.GetActiveUnitList().FirstOrDefault(new Func<ActiveUnit, bool>(class2.method_1)).m_Doctrine;
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				throw new Exception2("Can't find Unit '" + class2.string_0 + "'");
			}
			IL_342:
			if (doctrine == null)
			{
				throw new Exception2("Need to define a guid, or a name, or a side and name, or a side and mission, or just a side.");
			}
			dictionary = LuaUtility.smethod_2(luaTable_1.GetEnumerator());
			if (dictionary.ContainsKey("use_nuclear_weapons"))
			{
				Doctrine._UseNuclear useNuclear;
				if (Operators.CompareString(Conversions.ToString(dictionary["use_nuclear_weapons"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.method_35(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._UseNuclear>(Conversions.ToString(dictionary["use_nuclear_weapons"]), out useNuclear) & Enum.IsDefined(typeof(Doctrine._UseNuclear), useNuclear))
				{
					doctrine.method_35(scenario_, false, false, false, new Doctrine._UseNuclear?(useNuclear));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["use_nuclear_weapons"])).Value)
				{
					doctrine.method_35(scenario_, false, false, false, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_1));
				}
				else
				{
					doctrine.method_35(scenario_, false, false, false, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_0));
				}
			}
			if (dictionary.ContainsKey("use_nuclear_weapons_player_editable"))
			{
				doctrine.SetUseNukes_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["use_nuclear_weapons_player_editable"]));
			}
			if (dictionary.ContainsKey("weapon_control_status_air"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["weapon_control_status_air"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.method_63(scenario_, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus weaponControlStatus;
					if (!(Enum.TryParse<Doctrine._WeaponControlStatus>(Conversions.ToString(dictionary["weapon_control_status_air"]), out weaponControlStatus) & Enum.IsDefined(typeof(Doctrine._WeaponControlStatus), weaponControlStatus)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["weapon_control_status_air"]) + "' as weapon_control_status_air allowed values are: '0','1','2' which correspond to Free, Tight, and Hold.");
					}
					doctrine.method_63(scenario_, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(weaponControlStatus));
				}
			}
			if (dictionary.ContainsKey("weapon_control_status_air_player_editable"))
			{
				doctrine.SetWCS_Air_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["weapon_control_status_air_player_editable"]));
			}
			if (dictionary.ContainsKey("weapon_control_status_surface"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["weapon_control_status_surface"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetWCS_SurfaceDoctrine(scenario_, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus weaponControlStatus2;
					if (!(Enum.TryParse<Doctrine._WeaponControlStatus>(Conversions.ToString(dictionary["weapon_control_status_surface"]), out weaponControlStatus2) & Enum.IsDefined(typeof(Doctrine._WeaponControlStatus), weaponControlStatus2)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["weapon_control_status_surface"]) + "' as weapon_control_status_surface allowed values are: '0','1','2' which correspond to Free, Tight, and Hold.");
					}
					doctrine.SetWCS_SurfaceDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(weaponControlStatus2));
				}
			}
			if (dictionary.ContainsKey("weapon_control_status_surface_player_editable"))
			{
				doctrine.SetWCS_Surface_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["weapon_control_status_surface_player_editable"]));
			}
			if (dictionary.ContainsKey("weapon_control_status_subsurface"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["weapon_control_status_subsurface"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetWCS_SubmarineDoctrine(scenario_, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus weaponControlStatus3;
					if (!(Enum.TryParse<Doctrine._WeaponControlStatus>(Conversions.ToString(dictionary["weapon_control_status_subsurface"]), out weaponControlStatus3) & Enum.IsDefined(typeof(Doctrine._WeaponControlStatus), weaponControlStatus3)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["weapon_control_status_subsurface"]) + "' as weapon_control_status_subsurface allowed values are: '0','1','2' which correspond to Free, Tight, and Hold.");
					}
					doctrine.SetWCS_SubmarineDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(weaponControlStatus3));
				}
			}
			if (dictionary.ContainsKey("weapon_control_status_subsurface_player_editable"))
			{
				doctrine.SetWCS_Submarine_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["weapon_control_status_subsurface_player_editable"]));
			}
			if (dictionary.ContainsKey("weapon_control_status_land"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["weapon_control_status_land"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetWCS_LandDoctrine(scenario_, false, new bool?(false), false, false, null);
				}
				else
				{
					Doctrine._WeaponControlStatus weaponControlStatus4;
					if (!(Enum.TryParse<Doctrine._WeaponControlStatus>(Conversions.ToString(dictionary["weapon_control_status_land"]), out weaponControlStatus4) & Enum.IsDefined(typeof(Doctrine._WeaponControlStatus), weaponControlStatus4)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["weapon_control_status_land"]) + "' as weapon_control_status_land allowed values are: '0','1','2' which correspond to Free, Tight, and Hold.");
					}
					doctrine.SetWCS_LandDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(weaponControlStatus4));
				}
			}
			if (dictionary.ContainsKey("weapon_control_status_land_player_editable"))
			{
				doctrine.SetWCSLand_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["weapon_control_status_land_player_editable"]));
			}
			if (dictionary.ContainsKey("ignore_plotted_course"))
			{
				Doctrine._IgnorePlottedCourseWhenAttacking ignorePlottedCourseWhenAttacking;
				if (Operators.CompareString(Conversions.ToString(dictionary["ignore_plotted_course"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_, false, new bool?(false), false, false, null);
				}
				else if (Enum.TryParse<Doctrine._IgnorePlottedCourseWhenAttacking>(Conversions.ToString(dictionary["ignore_plotted_course"]), out ignorePlottedCourseWhenAttacking) & Enum.IsDefined(typeof(Doctrine._IgnorePlottedCourseWhenAttacking), ignorePlottedCourseWhenAttacking))
				{
					doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(ignorePlottedCourseWhenAttacking));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["ignore_plotted_course"])).Value)
				{
					doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
				}
				else
				{
					doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
				}
			}
			if (dictionary.ContainsKey("ignore_plotted_course_player_editable"))
			{
				doctrine.SetIgnorePlottedCourseWhenAttackingPlayerEditable(scenario_, Conversions.ToBoolean(dictionary["ignore_plotted_course_player_editable"]));
			}
			if (dictionary.ContainsKey("engaging_ambiguous_targets"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["engaging_ambiguous_targets"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_, false, false, false, null);
				}
				else
				{
					Doctrine._BehaviorTowardsAmbigousTarget behaviorTowardsAmbigousTarget;
					if (!(Enum.TryParse<Doctrine._BehaviorTowardsAmbigousTarget>(Conversions.ToString(dictionary["engaging_ambiguous_targets"]), out behaviorTowardsAmbigousTarget) & Enum.IsDefined(typeof(Doctrine._BehaviorTowardsAmbigousTarget), behaviorTowardsAmbigousTarget)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["engaging_ambiguous_targets"]) + "' as engaging_ambiguous_targets allowed values are: '0','1','2' which correspond to Ignore, Optimistic, Pessimistic");
					}
					doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_, false, false, false, new Doctrine._BehaviorTowardsAmbigousTarget?(behaviorTowardsAmbigousTarget));
				}
			}
			if (dictionary.ContainsKey("engaging_ambiguous_targets_player_editable"))
			{
				doctrine.SetBehaviorTowardsAmbigousTarget_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["engaging_ambiguous_targets_player_editable"]));
			}
			if (dictionary.ContainsKey("engage_opportunity_targets"))
			{
				Doctrine._ShootTourists shootTourists;
				if (Operators.CompareString(Conversions.ToString(dictionary["engage_opportunity_targets"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetShootTouristsDoctrine(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._ShootTourists>(Conversions.ToString(dictionary["engage_opportunity_targets"]), out shootTourists) & Enum.IsDefined(typeof(Doctrine._ShootTourists), shootTourists))
				{
					doctrine.SetShootTouristsDoctrine(scenario_, false, false, false, new Doctrine._ShootTourists?(shootTourists));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["engage_opportunity_targets"])).Value)
				{
					doctrine.SetShootTouristsDoctrine(scenario_, false, false, false, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_1));
				}
				else
				{
					doctrine.SetShootTouristsDoctrine(scenario_, false, false, false, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0));
				}
			}
			if (dictionary.ContainsKey("engage_opportunity_targets_player_editable"))
			{
				doctrine.method_160(scenario_, Conversions.ToBoolean(dictionary["engage_opportunity_targets_player_editable"]));
			}
			if (dictionary.ContainsKey("ignore_emcon_while_under_attack"))
			{
				Doctrine._IgnoreEMCONUnderAttack ignoreEMCONUnderAttack;
				if (Operators.CompareString(Conversions.ToString(dictionary["ignore_emcon_while_under_attack"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._IgnoreEMCONUnderAttack>(Conversions.ToString(dictionary["ignore_emcon_while_under_attack"]), out ignoreEMCONUnderAttack) & Enum.IsDefined(typeof(Doctrine._IgnoreEMCONUnderAttack), ignoreEMCONUnderAttack))
				{
					doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_, false, false, false, new Doctrine._IgnoreEMCONUnderAttack?(ignoreEMCONUnderAttack));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["ignore_emcon_while_under_attack"])).Value)
				{
					doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_, false, false, false, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_1));
				}
				else
				{
					doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_, false, false, false, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_0));
				}
			}
			if (dictionary.ContainsKey("ignore_emcon_while_under_attack_player_editable"))
			{
				doctrine.method_170(scenario_, Conversions.ToBoolean(dictionary["ignore_emcon_while_under_attack_player_editable"]));
			}
			if (dictionary.ContainsKey("air_operations_tempo"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["air_operations_tempo"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetAirOpsTempoDoctrine(scenario_, false, false, false, false, null);
				}
				else
				{
					Doctrine._AirOpsTempo airOpsTempo;
					if (!(Enum.TryParse<Doctrine._AirOpsTempo>(Conversions.ToString(dictionary["air_operations_tempo"]), out airOpsTempo) & Enum.IsDefined(typeof(Doctrine._AirOpsTempo), airOpsTempo)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["air_operations_tempo"]) + "' as air_operations_tempo allowed values are: '0','1' corresponding to Surge, Sustained.");
					}
					doctrine.SetAirOpsTempoDoctrine(scenario_, false, false, false, false, new Doctrine._AirOpsTempo?(airOpsTempo));
				}
			}
			if (dictionary.ContainsKey("air_operations_tempo_player_editable"))
			{
				doctrine.method_184(scenario_, Conversions.ToBoolean(dictionary["air_operations_tempo_player_editable"]));
			}
			if (dictionary.ContainsKey("quick_turnaround_for_aircraft"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["quick_turnaround_for_aircraft"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetQuickTurnAroundDoctrine(scenario_, false, false, false, false, null);
				}
				else
				{
					Doctrine._QuickTurnAround quickTurnAround;
					if (!(Enum.TryParse<Doctrine._QuickTurnAround>(Conversions.ToString(dictionary["quick_turnaround_for_aircraft"]), out quickTurnAround) & Enum.IsDefined(typeof(Doctrine._QuickTurnAround), quickTurnAround)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["quick_turnaround_for_aircraft"]) + "' as quick_turnaround_for_aircraft allowed values are: '0','1','2' corresponding to Yes, Fighters and ASW, No");
					}
					doctrine.SetQuickTurnAroundDoctrine(scenario_, false, false, false, false, new Doctrine._QuickTurnAround?(quickTurnAround));
				}
			}
			if (dictionary.ContainsKey("quick_turnaround_for_aircraft_player_editable"))
			{
				doctrine.method_179(scenario_, Conversions.ToBoolean(dictionary["quick_turnaround_for_aircraft_player_editable"]));
			}
			if (dictionary.ContainsKey("rtb_when_winchester"))
			{
				Doctrine._WeaponStateRTB weaponStateRTB;
				if (Operators.CompareString(Conversions.ToString(dictionary["rtb_when_winchester"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetWinchesterShotgunRTBDoctrine(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._WeaponStateRTB>(Conversions.ToString(dictionary["rtb_when_winchester"]), out weaponStateRTB) & Enum.IsDefined(typeof(Doctrine._WeaponStateRTB), weaponStateRTB))
				{
					doctrine.SetWinchesterShotgunRTBDoctrine(scenario_, false, false, false, new Doctrine._WeaponStateRTB?(weaponStateRTB));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["rtb_when_winchester"])).Value)
				{
					doctrine.SetWinchesterShotgunRTBDoctrine(scenario_, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
				}
				else
				{
					doctrine.SetWinchesterShotgunRTBDoctrine(scenario_, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
				}
			}
			if (dictionary.ContainsKey("rtb_when_winchester_player_editable"))
			{
				doctrine.method_120(scenario_, Conversions.ToBoolean(dictionary["rtb_when_winchester_player_editable"]));
			}
			if (dictionary.ContainsKey("use_sams_in_anti_surface_mode"))
			{
				Doctrine._UseSAMsInASuWMode useSAMsInASuWMode;
				if (Operators.CompareString(Conversions.ToString(dictionary["use_sams_in_anti_surface_mode"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetUseSAMsInASuWModeDoctrine(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._UseSAMsInASuWMode>(Conversions.ToString(dictionary["use_sams_in_anti_surface_mode"]), out useSAMsInASuWMode) & Enum.IsDefined(typeof(Doctrine._UseSAMsInASuWMode), useSAMsInASuWMode))
				{
					doctrine.SetUseSAMsInASuWModeDoctrine(scenario_, false, false, false, new Doctrine._UseSAMsInASuWMode?(useSAMsInASuWMode));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["use_sams_in_anti_surface_mode"])).Value)
				{
					doctrine.SetUseSAMsInASuWModeDoctrine(scenario_, false, false, false, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_1));
				}
				else
				{
					doctrine.SetUseSAMsInASuWModeDoctrine(scenario_, false, false, false, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_0));
				}
			}
			if (dictionary.ContainsKey("use_sams_in_anti_surface_mode_player_editable"))
			{
				doctrine.method_165(scenario_, Conversions.ToBoolean(dictionary["use_sams_in_anti_surface_mode_player_editable"]));
			}
			if (dictionary.ContainsKey("maintain_standoff"))
			{
				Doctrine._MaintainStandoff maintainStandoff;
				if (Operators.CompareString(Conversions.ToString(dictionary["maintain_standoff"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetMaintainStandoffDoctrine(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._MaintainStandoff>(Conversions.ToString(dictionary["maintain_standoff"]), out maintainStandoff) & Enum.IsDefined(typeof(Doctrine._MaintainStandoff), maintainStandoff))
				{
					doctrine.SetMaintainStandoffDoctrine(scenario_, false, false, false, new Doctrine._MaintainStandoff?(maintainStandoff));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["maintain_standoff"])).Value)
				{
					doctrine.SetMaintainStandoffDoctrine(scenario_, false, false, false, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_1));
				}
				else
				{
					doctrine.SetMaintainStandoffDoctrine(scenario_, false, false, false, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_0));
				}
			}
			if (dictionary.ContainsKey("maintain_standoff_player_editable"))
			{
				doctrine.method_140(scenario_, Conversions.ToBoolean(dictionary["maintain_standoff_player_editable"]));
			}
			if (dictionary.ContainsKey("kinematic_range_for_torpedoes"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["kinematic_range_for_torpedoes"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetUseTorpedoesKinematicRangeDoctrine(scenario_, false, false, false, null);
				}
				else
				{
					Doctrine._UseTorpedoesKinematicRange useTorpedoesKinematicRange;
					if (!(Enum.TryParse<Doctrine._UseTorpedoesKinematicRange>(Conversions.ToString(dictionary["kinematic_range_for_torpedoes"]), out useTorpedoesKinematicRange) & Enum.IsDefined(typeof(Doctrine._UseTorpedoesKinematicRange), useTorpedoesKinematicRange)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["kinematic_range_for_torpedoes"]) + "' as kinematic_range_for_torpedoes allowed values are: '0','1','2' correspond to Automatic and Manual Fire, Manual Fire Only, No");
					}
					doctrine.SetUseTorpedoesKinematicRangeDoctrine(scenario_, false, false, false, new Doctrine._UseTorpedoesKinematicRange?(useTorpedoesKinematicRange));
				}
			}
			if (dictionary.ContainsKey("kinematic_range_for_torpedoes_player_editable"))
			{
				doctrine.method_199(scenario_, Conversions.ToBoolean(dictionary["kinematic_range_for_torpedoes_player_editable"]));
			}
			if (dictionary.ContainsKey("automatic_evasion"))
			{
				Doctrine._AutomaticEvasion automaticEvasion;
				if (Operators.CompareString(Conversions.ToString(dictionary["automatic_evasion"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetAutomaticEvasionDoctrine(scenario_, false, false, false, null);
				}
				else if (Enum.TryParse<Doctrine._AutomaticEvasion>(Conversions.ToString(dictionary["automatic_evasion"]), out automaticEvasion) & Enum.IsDefined(typeof(Doctrine._AutomaticEvasion), automaticEvasion))
				{
					doctrine.SetAutomaticEvasionDoctrine(scenario_, false, false, false, new Doctrine._AutomaticEvasion?(automaticEvasion));
				}
				else if (LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(dictionary["automatic_evasion"])).Value)
				{
					doctrine.SetAutomaticEvasionDoctrine(scenario_, false, false, false, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_1));
				}
				else
				{
					doctrine.SetAutomaticEvasionDoctrine(scenario_, false, false, false, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_0));
				}
			}
			if (dictionary.ContainsKey("automatic_evasion_player_editable"))
			{
				doctrine.method_135(scenario_, Conversions.ToBoolean(dictionary["automatic_evasion_player_editable"]));
			}
			if (dictionary.ContainsKey("use_refuel_unrep"))
			{
				if (Operators.CompareString(Conversions.ToString(dictionary["use_refuel_unrep"]).ToLower(), "inherit", false) == 0)
				{
					doctrine.SetUseRefuelDoctrine(scenario_, false, false, false, false, null);
				}
				else
				{
					Doctrine._UseRefuel useRefuel;
					if (!(Enum.TryParse<Doctrine._UseRefuel>(Conversions.ToString(dictionary["use_refuel_unrep"]), out useRefuel) & Enum.IsDefined(typeof(Doctrine._UseRefuel), useRefuel)))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["use_refuel_unrep"]) + "' as use_refuel_unrep allowed values are: '0','1','2' which correspond to Always Excl Tankers, Never, Always Incl Tankers");
					}
					doctrine.SetUseRefuelDoctrine(scenario_, false, false, false, false, new Doctrine._UseRefuel?(useRefuel));
				}
			}
			if (dictionary.ContainsKey("use_refuel_unrep_player_editable"))
			{
				doctrine.method_150(scenario_, Conversions.ToBoolean(dictionary["use_refuel_unrep_player_editable"]));
			}
			checked
			{
				if (dictionary.ContainsKey("refuel_unrep_allied"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["refuel_unrep_allied"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetRefuelAlliedUnitsDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._RefuelAlliedUnits refuelAlliedUnits;
						if (!(Enum.TryParse<Doctrine._RefuelAlliedUnits>(Conversions.ToString(dictionary["refuel_unrep_allied"]), out refuelAlliedUnits) & Enum.IsDefined(typeof(Doctrine._RefuelAlliedUnits), refuelAlliedUnits)))
						{
							byte[] array = (byte[])Enum.GetValues(typeof(Doctrine._RefuelAlliedUnits));
							string text3 = "; allowed values are ";
							byte[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								byte b = array2[i];
								string format = " {0}({1})";
								Doctrine._RefuelAlliedUnits refuelAlliedUnits2 = (Doctrine._RefuelAlliedUnits)b;
								string str3 = string.Format(format, refuelAlliedUnits2.ToString(), b.ToString());
								text3 += str3;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["refuel_unrep_allied"]) + "' as refuel_unrep_allied" + text3);
						}
						doctrine.SetRefuelAlliedUnitsDoctrine(scenario_, false, false, false, new Doctrine._RefuelAlliedUnits?(refuelAlliedUnits));
					}
				}
				if (dictionary.ContainsKey("refuel_unrep_allied_player_editable"))
				{
					doctrine.SetRefuelAllies_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["refuel_unrep_allied_player_editable"]));
				}
				if (dictionary.ContainsKey("fuel_state_planned"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["fuel_state_planned"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetBingoJokerDoctrine(scenario_, false, false, false, false, null);
					}
					else
					{
						Doctrine._FuelState fuelState;
						if (!(Enum.TryParse<Doctrine._FuelState>(Conversions.ToString(dictionary["fuel_state_planned"]), out fuelState) & Enum.IsDefined(typeof(Doctrine._FuelState), fuelState)))
						{
							byte[] array3 = (byte[])Enum.GetValues(typeof(Doctrine._FuelState));
							string text4 = "; allowed values are ";
							byte[] array4 = array3;
							for (int j = 0; j < array4.Length; j++)
							{
								byte b2 = array4[j];
								string format2 = " {0}({1})";
								Doctrine._FuelState fuelState2 = (Doctrine._FuelState)b2;
								string str4 = string.Format(format2, fuelState2.ToString(), b2.ToString());
								text4 += str4;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["fuel_state_planned"]) + "' as fuel_state_planned" + text4);
						}
						doctrine.SetBingoJokerDoctrine(scenario_, false, false, false, false, new Doctrine._FuelState?(fuelState));
					}
				}
				if (dictionary.ContainsKey("fuel_state_planned_player_editable"))
				{
					doctrine.method_189(scenario_, Conversions.ToBoolean(dictionary["fuel_state_planned_player_editable"]));
				}
				if (dictionary.ContainsKey("fuel_state_rtb"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["fuel_state_rtb"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetBingoJokerRTBDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._FuelStateRTB fuelStateRTB;
						if (!(Enum.TryParse<Doctrine._FuelStateRTB>(Conversions.ToString(dictionary["fuel_state_rtb"]), out fuelStateRTB) & Enum.IsDefined(typeof(Doctrine._FuelStateRTB), fuelStateRTB)))
						{
							byte[] array5 = (byte[])Enum.GetValues(typeof(Doctrine._FuelStateRTB));
							string text5 = "; allowed values are ";
							byte[] array6 = array5;
							for (int k = 0; k < array6.Length; k++)
							{
								byte b3 = array6[k];
								string format3 = " {0}({1})";
								Doctrine._FuelStateRTB fuelStateRTB2 = (Doctrine._FuelStateRTB)b3;
								string str5 = string.Format(format3, fuelStateRTB2.ToString(), b3.ToString());
								text5 += str5;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["fuel_state_rtb"]) + "' as fuel_state_rtb" + text5);
						}
						doctrine.SetBingoJokerRTBDoctrine(scenario_, false, false, false, new Doctrine._FuelStateRTB?(fuelStateRTB));
					}
				}
				if (dictionary.ContainsKey("fuel_state_rtb_player_editable"))
				{
					doctrine.method_125(scenario_, Conversions.ToBoolean(dictionary["fuel_state_rtb_player_editable"]));
				}
				if (dictionary.ContainsKey("weapon_state_planned"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["weapon_state_planned"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetWinchesterShotgunDoctrine(scenario_, false, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponState weaponState;
						if (!(Enum.TryParse<Doctrine._WeaponState>(Conversions.ToString(dictionary["weapon_state_planned"]), out weaponState) & Enum.IsDefined(typeof(Doctrine._WeaponState), weaponState)))
						{
							int[] array7 = (int[])Enum.GetValues(typeof(Doctrine._WeaponState));
							string text6 = "; allowed values are ";
							int[] array8 = array7;
							for (int l = 0; l < array8.Length; l++)
							{
								int num = array8[l];
								string format4 = " {0}({1})";
								Doctrine._WeaponState weaponState2 = (Doctrine._WeaponState)num;
								string str6 = string.Format(format4, weaponState2.ToString(), num.ToString());
								text6 += str6;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["weapon_state_planned"]) + "' as weapon_state_planned" + text6);
						}
						doctrine.SetWinchesterShotgunDoctrine(scenario_, false, false, false, false, new Doctrine._WeaponState?(weaponState));
					}
				}
				if (dictionary.ContainsKey("weapon_state_planned_player_editable"))
				{
					doctrine.method_194(scenario_, Conversions.ToBoolean(dictionary["weapon_state_planned_player_editable"]));
				}
				if (dictionary.ContainsKey("weapon_state_rtb"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["weapon_state_rtb"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetWinchesterShotgunRTBDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponStateRTB weaponStateRTB2;
						if (!(Enum.TryParse<Doctrine._WeaponStateRTB>(Conversions.ToString(dictionary["weapon_state_rtb"]), out weaponStateRTB2) & Enum.IsDefined(typeof(Doctrine._WeaponStateRTB), weaponStateRTB2)))
						{
							byte[] array9 = (byte[])Enum.GetValues(typeof(Doctrine._WeaponStateRTB));
							string text7 = "; allowed values are ";
							byte[] array10 = array9;
							for (int m = 0; m < array10.Length; m++)
							{
								byte b4 = array10[m];
								string format5 = " {0}({1})";
								Doctrine._WeaponStateRTB weaponStateRTB3 = (Doctrine._WeaponStateRTB)b4;
								string str7 = string.Format(format5, weaponStateRTB3.ToString(), b4.ToString());
								text7 += str7;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["weapon_state_rtb"]) + "' as weapon_state_rtb" + text7);
						}
						doctrine.SetWinchesterShotgunRTBDoctrine(scenario_, false, false, false, new Doctrine._WeaponStateRTB?(weaponStateRTB2));
					}
				}
				if (dictionary.ContainsKey("weapon_state_rtb_player_editable"))
				{
					doctrine.method_120(scenario_, Conversions.ToBoolean(dictionary["weapon_state_rtb_player_editable"]));
				}
				if (dictionary.ContainsKey("gun_strafing"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["gun_strafing"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetGunStrafeGroundTargetsDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._GunStrafeGroundTargets gunStrafeGroundTargets;
						if (!(Enum.TryParse<Doctrine._GunStrafeGroundTargets>(Conversions.ToString(dictionary["gun_strafing"]), out gunStrafeGroundTargets) & Enum.IsDefined(typeof(Doctrine._GunStrafeGroundTargets), gunStrafeGroundTargets)))
						{
							byte[] array11 = (byte[])Enum.GetValues(typeof(Doctrine._GunStrafeGroundTargets));
							string text8 = "; allowed values are ";
							byte[] array12 = array11;
							for (int n = 0; n < array12.Length; n++)
							{
								byte b5 = array12[n];
								string format6 = " {0}({1})";
								Doctrine._GunStrafeGroundTargets gunStrafeGroundTargets2 = (Doctrine._GunStrafeGroundTargets)b5;
								string str8 = string.Format(format6, gunStrafeGroundTargets2.ToString(), b5.ToString());
								text8 += str8;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["gun_strafing"]) + "' as gun_strafing" + text8);
						}
						doctrine.SetGunStrafeGroundTargetsDoctrine(scenario_, false, false, false, new Doctrine._GunStrafeGroundTargets?(gunStrafeGroundTargets));
					}
				}
				if (dictionary.ContainsKey("gun_strafing_player_editable"))
				{
					doctrine.method_145(scenario_, Conversions.ToBoolean(dictionary["gun_strafing_player_editable"]));
				}
				if (dictionary.ContainsKey("jettison_ordnance"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["jettison_ordnance"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetJettisonOrdnanceDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._JettisonOrdnance jettisonOrdnance;
						if (!(Enum.TryParse<Doctrine._JettisonOrdnance>(Conversions.ToString(dictionary["jettison_ordnance"]), out jettisonOrdnance) & Enum.IsDefined(typeof(Doctrine._JettisonOrdnance), jettisonOrdnance)))
						{
							byte[] array13 = (byte[])Enum.GetValues(typeof(Doctrine._JettisonOrdnance));
							string text9 = "; allowed values are ";
							byte[] array14 = array13;
							for (int num2 = 0; num2 < array14.Length; num2++)
							{
								byte b6 = array14[num2];
								string format7 = " {0}({1})";
								Doctrine._JettisonOrdnance jettisonOrdnance2 = (Doctrine._JettisonOrdnance)b6;
								string str9 = string.Format(format7, jettisonOrdnance2.ToString(), b6.ToString());
								text9 += str9;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["jettison_ordnance"]) + "' as jettison_ordnance" + text9);
						}
						doctrine.SetJettisonOrdnanceDoctrine(scenario_, false, false, false, new Doctrine._JettisonOrdnance?(jettisonOrdnance));
					}
				}
				if (dictionary.ContainsKey("jettison_ordnance_player_editable"))
				{
					doctrine.method_130(scenario_, Conversions.ToBoolean(dictionary["jettison_ordnance_player_editable"]));
				}
				if (dictionary.ContainsKey("avoid_contact"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["avoid_contact"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetAvoidContactWhenPossibleDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._AvoidContactWhenPossible avoidContactWhenPossible;
						if (!(Enum.TryParse<Doctrine._AvoidContactWhenPossible>(Conversions.ToString(dictionary["avoid_contact"]), out avoidContactWhenPossible) & Enum.IsDefined(typeof(Doctrine._AvoidContactWhenPossible), avoidContactWhenPossible)))
						{
							byte[] array15 = (byte[])Enum.GetValues(typeof(Doctrine._AvoidContactWhenPossible));
							string text10 = "; allowed values are ";
							byte[] array16 = array15;
							for (int num3 = 0; num3 < array16.Length; num3++)
							{
								byte b7 = array16[num3];
								string format8 = " {0}({1})";
								Doctrine._AvoidContactWhenPossible avoidContactWhenPossible2 = (Doctrine._AvoidContactWhenPossible)b7;
								string str10 = string.Format(format8, avoidContactWhenPossible2.ToString(), b7.ToString());
								text10 += str10;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["avoid_contact"]) + "' as avoid_contact" + text10);
						}
						doctrine.SetAvoidContactWhenPossibleDoctrine(scenario_, false, false, false, new Doctrine._AvoidContactWhenPossible?(avoidContactWhenPossible));
					}
				}
				if (dictionary.ContainsKey("avoid_contact_player_editable"))
				{
					doctrine.SetAvoidContact_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["avoid_contact_player_editable"]));
				}
				if (dictionary.ContainsKey("dive_on_threat"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["dive_on_threat"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetDiveOnContactDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._DiveOnContact diveOnContact;
						if (!(Enum.TryParse<Doctrine._DiveOnContact>(Conversions.ToString(dictionary["dive_on_threat"]), out diveOnContact) & Enum.IsDefined(typeof(Doctrine._DiveOnContact), diveOnContact)))
						{
							byte[] array17 = (byte[])Enum.GetValues(typeof(Doctrine._DiveOnContact));
							string text11 = "; allowed values are ";
							byte[] array18 = array17;
							for (int num4 = 0; num4 < array18.Length; num4++)
							{
								byte b8 = array18[num4];
								string format9 = " {0}({1})";
								Doctrine._DiveOnContact diveOnContact2 = (Doctrine._DiveOnContact)b8;
								string str11 = string.Format(format9, diveOnContact2.ToString(), b8.ToString());
								text11 += str11;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["dive_on_threat"]) + "' as dive_on_threat" + text11);
						}
						doctrine.SetDiveOnContactDoctrine(scenario_, false, false, false, new Doctrine._DiveOnContact?(diveOnContact));
					}
				}
				if (dictionary.ContainsKey("dive_on_threat_player_editable"))
				{
					doctrine.SetDiveWhenThreatsDetected_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["dive_on_threat_player_editable"]));
				}
				if (dictionary.ContainsKey("recharge_on_patrol"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["recharge_on_patrol"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetRechargeBatteryPercentageDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._RechargeBatteryPercentage rechargeBatteryPercentage;
						if (!(Enum.TryParse<Doctrine._RechargeBatteryPercentage>(Conversions.ToString(dictionary["recharge_on_patrol"]), out rechargeBatteryPercentage) & Enum.IsDefined(typeof(Doctrine._RechargeBatteryPercentage), rechargeBatteryPercentage)))
						{
							int[] array19 = (int[])Enum.GetValues(typeof(Doctrine._RechargeBatteryPercentage));
							string text12 = "; allowed values are ";
							int[] array20 = array19;
							for (int num5 = 0; num5 < array20.Length; num5++)
							{
								int num6 = array20[num5];
								string format10 = " {0}({1})";
								Doctrine._RechargeBatteryPercentage rechargeBatteryPercentage2 = (Doctrine._RechargeBatteryPercentage)num6;
								string str12 = string.Format(format10, rechargeBatteryPercentage2.ToString(), num6.ToString());
								text12 += str12;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["recharge_on_patrol"]) + "' as recharge_on_patrol" + text12);
						}
						doctrine.SetRechargeBatteryPercentageDoctrine(scenario_, false, false, false, new Doctrine._RechargeBatteryPercentage?(rechargeBatteryPercentage));
					}
				}
				if (dictionary.ContainsKey("recharge_on_patrol_player_editable"))
				{
					doctrine.SetRechargePercentagePatrol_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["recharge_on_patrol_player_editable"]));
				}
				if (dictionary.ContainsKey("recharge_on_attack"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["recharge_on_attack"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.method_245(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._RechargeBatteryPercentage rechargeBatteryPercentage3;
						if (!(Enum.TryParse<Doctrine._RechargeBatteryPercentage>(Conversions.ToString(dictionary["recharge_on_attack"]), out rechargeBatteryPercentage3) & Enum.IsDefined(typeof(Doctrine._RechargeBatteryPercentage), rechargeBatteryPercentage3)))
						{
							int[] array21 = (int[])Enum.GetValues(typeof(Doctrine._RechargeBatteryPercentage));
							string text13 = "; allowed values are ";
							int[] array22 = array21;
							for (int num7 = 0; num7 < array22.Length; num7++)
							{
								int num8 = array22[num7];
								string format11 = " {0}({1})";
								Doctrine._RechargeBatteryPercentage rechargeBatteryPercentage2 = (Doctrine._RechargeBatteryPercentage)num8;
								string str13 = string.Format(format11, rechargeBatteryPercentage2.ToString(), num8.ToString());
								text13 += str13;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["recharge_on_attack"]) + "' as recharge_on_attack" + text13);
						}
						doctrine.method_245(scenario_, false, false, false, new Doctrine._RechargeBatteryPercentage?(rechargeBatteryPercentage3));
					}
				}
				if (dictionary.ContainsKey("recharge_on_attack_player_editable"))
				{
					doctrine.SetRechargePercentageAttack_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["recharge_on_attack_player_editable"]));
				}
				if (dictionary.ContainsKey("use_aip"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["use_aip"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetUseAIPDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._UseAIP useAIP;
						if (!(Enum.TryParse<Doctrine._UseAIP>(Conversions.ToString(dictionary["use_aip"]), out useAIP) & Enum.IsDefined(typeof(Doctrine._UseAIP), useAIP)))
						{
							byte[] array23 = (byte[])Enum.GetValues(typeof(Doctrine._UseAIP));
							string text14 = "; allowed values are ";
							byte[] array24 = array23;
							for (int num9 = 0; num9 < array24.Length; num9++)
							{
								byte b9 = array24[num9];
								string format12 = " {0}({1})";
								Doctrine._UseAIP useAIP2 = (Doctrine._UseAIP)b9;
								string str14 = string.Format(format12, useAIP2.ToString(), b9.ToString());
								text14 += str14;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["use_aip"]) + "' as use_aip" + text14);
						}
						doctrine.SetUseAIPDoctrine(scenario_, false, false, false, new Doctrine._UseAIP?(useAIP));
					}
				}
				if (dictionary.ContainsKey("use_aip_player_editable"))
				{
					doctrine.SetAIPUsage_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["use_aip_player_editable"]));
				}
				if (dictionary.ContainsKey("dipping_sonar"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["dipping_sonar"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetUseDippingSonarDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._UseDippingSonar useDippingSonar;
						if (!(Enum.TryParse<Doctrine._UseDippingSonar>(Conversions.ToString(dictionary["dipping_sonar"]), out useDippingSonar) & Enum.IsDefined(typeof(Doctrine._UseDippingSonar), useDippingSonar)))
						{
							byte[] array25 = (byte[])Enum.GetValues(typeof(Doctrine._UseDippingSonar));
							string text15 = "; allowed values are ";
							byte[] array26 = array25;
							for (int num10 = 0; num10 < array26.Length; num10++)
							{
								byte b10 = array26[num10];
								string format13 = " {0}({1})";
								Doctrine._UseDippingSonar useDippingSonar2 = (Doctrine._UseDippingSonar)b10;
								string str15 = string.Format(format13, useDippingSonar2.ToString(), b10.ToString());
								text15 += str15;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["dipping_sonar"]) + "' as dipping_sonar" + text15);
						}
						doctrine.SetUseDippingSonarDoctrine(scenario_, false, false, false, new Doctrine._UseDippingSonar?(useDippingSonar));
					}
				}
				if (dictionary.ContainsKey("dipping_sonar_player_editable"))
				{
					doctrine.SetDippingSonar_PlayerEditable(scenario_, Conversions.ToBoolean(dictionary["dipping_sonar_player_editable"]));
				}
				if (dictionary.ContainsKey("withdraw_on_damage"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["withdraw_on_damage"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetWithdrawDamageThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._DamageThreshold damageThreshold;
						if (!(Enum.TryParse<Doctrine._DamageThreshold>(Conversions.ToString(dictionary["withdraw_on_damage"]), out damageThreshold) & Enum.IsDefined(typeof(Doctrine._DamageThreshold), damageThreshold)))
						{
							short[] array27 = (short[])Enum.GetValues(typeof(Doctrine._DamageThreshold));
							string text16 = "; allowed values are ";
							short[] array28 = array27;
							for (int num11 = 0; num11 < array28.Length; num11++)
							{
								short num12 = array28[num11];
								string format14 = " {0}({1})";
								Doctrine._DamageThreshold damageThreshold2 = (Doctrine._DamageThreshold)num12;
								string str16 = string.Format(format14, damageThreshold2.ToString(), num12.ToString());
								text16 += str16;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["withdraw_on_damage"]) + "' as withdraw_on_damage" + text16);
						}
						doctrine.SetWithdrawDamageThresholdDoctrine(scenario_, false, false, false, new Doctrine._DamageThreshold?(damageThreshold));
					}
				}
				if (dictionary.ContainsKey("withdraw_on_fuel"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["withdraw_on_fuel"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetWithdrawFuelThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._FuelQuantityThreshold fuelQuantityThreshold;
						if (!(Enum.TryParse<Doctrine._FuelQuantityThreshold>(Conversions.ToString(dictionary["withdraw_on_fuel"]), out fuelQuantityThreshold) & Enum.IsDefined(typeof(Doctrine._FuelQuantityThreshold), fuelQuantityThreshold)))
						{
							short[] array29 = (short[])Enum.GetValues(typeof(Doctrine._FuelQuantityThreshold));
							string text17 = "; allowed values are ";
							short[] array30 = array29;
							for (int num13 = 0; num13 < array30.Length; num13++)
							{
								short num14 = array30[num13];
								string format15 = " {0}({1})";
								Doctrine._FuelQuantityThreshold fuelQuantityThreshold2 = (Doctrine._FuelQuantityThreshold)num14;
								string str17 = string.Format(format15, fuelQuantityThreshold2.ToString(), num14.ToString());
								text17 += str17;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["withdraw_on_fuel"]) + "' as withdraw_on_fuel" + text17);
						}
						doctrine.SetWithdrawFuelThresholdDoctrine(scenario_, false, false, false, new Doctrine._FuelQuantityThreshold?(fuelQuantityThreshold));
					}
				}
				if (dictionary.ContainsKey("withdraw_on_attack"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["withdraw_on_attack"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetWithdrawAttackThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold weaponQuantityThreshold;
						if (!(Enum.TryParse<Doctrine._WeaponQuantityThreshold>(Conversions.ToString(dictionary["withdraw_on_attack"]), out weaponQuantityThreshold) & Enum.IsDefined(typeof(Doctrine._WeaponQuantityThreshold), weaponQuantityThreshold)))
						{
							short[] array31 = (short[])Enum.GetValues(typeof(Doctrine._WeaponQuantityThreshold));
							string text18 = "; allowed values are ";
							short[] array32 = array31;
							for (int num15 = 0; num15 < array32.Length; num15++)
							{
								short num16 = array32[num15];
								string format16 = " {0}({1})";
								Doctrine._WeaponQuantityThreshold weaponQuantityThreshold2 = (Doctrine._WeaponQuantityThreshold)num16;
								string str18 = string.Format(format16, weaponQuantityThreshold2.ToString(), num16.ToString());
								text18 += str18;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["withdraw_on_attack"]) + "' as withdraw_on_attack" + text18);
						}
						doctrine.SetWithdrawAttackThresholdDoctrine(scenario_, false, false, false, new Doctrine._WeaponQuantityThreshold?(weaponQuantityThreshold));
					}
				}
				if (dictionary.ContainsKey("withdraw_on_defence"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["withdraw_on_defence"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold weaponQuantityThreshold3;
						if (!(Enum.TryParse<Doctrine._WeaponQuantityThreshold>(Conversions.ToString(dictionary["withdraw_on_defence"]), out weaponQuantityThreshold3) & Enum.IsDefined(typeof(Doctrine._WeaponQuantityThreshold), weaponQuantityThreshold3)))
						{
							short[] array33 = (short[])Enum.GetValues(typeof(Doctrine._WeaponQuantityThreshold));
							string text19 = "; allowed values are ";
							short[] array34 = array33;
							for (int num17 = 0; num17 < array34.Length; num17++)
							{
								short num18 = array34[num17];
								string format17 = " {0}({1})";
								Doctrine._WeaponQuantityThreshold weaponQuantityThreshold2 = (Doctrine._WeaponQuantityThreshold)num18;
								string str19 = string.Format(format17, weaponQuantityThreshold2.ToString(), num18.ToString());
								text19 += str19;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["withdraw_on_defence"]) + "' as withdraw_on_defence" + text19);
						}
						doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_, false, false, false, new Doctrine._WeaponQuantityThreshold?(weaponQuantityThreshold3));
					}
				}
				if (dictionary.ContainsKey("deploy_on_damage"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["deploy_on_damage"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetRedeployDamageThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._DamageThreshold damageThreshold3;
						if (!(Enum.TryParse<Doctrine._DamageThreshold>(Conversions.ToString(dictionary["deploy_on_damage"]), out damageThreshold3) & Enum.IsDefined(typeof(Doctrine._DamageThreshold), damageThreshold3)))
						{
							short[] array35 = (short[])Enum.GetValues(typeof(Doctrine._DamageThreshold));
							string text20 = "; allowed values are ";
							short[] array36 = array35;
							for (int num19 = 0; num19 < array36.Length; num19++)
							{
								short num20 = array36[num19];
								string format18 = " {0}({1})";
								Doctrine._DamageThreshold damageThreshold2 = (Doctrine._DamageThreshold)num20;
								string str20 = string.Format(format18, damageThreshold2.ToString(), num20.ToString());
								text20 += str20;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["deploy_on_damage"]) + "' as deploy_on_damage" + text20);
						}
						doctrine.SetRedeployDamageThresholdDoctrine(scenario_, false, false, false, new Doctrine._DamageThreshold?(damageThreshold3));
					}
				}
				if (dictionary.ContainsKey("deploy_on_fuel"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["deploy_on_fuel"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetRedeployFuelThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._FuelQuantityThreshold fuelQuantityThreshold3;
						if (!(Enum.TryParse<Doctrine._FuelQuantityThreshold>(Conversions.ToString(dictionary["deploy_on_fuel"]), out fuelQuantityThreshold3) & Enum.IsDefined(typeof(Doctrine._FuelQuantityThreshold), fuelQuantityThreshold3)))
						{
							short[] array37 = (short[])Enum.GetValues(typeof(Doctrine._FuelQuantityThreshold));
							string text21 = "; allowed values are ";
							short[] array38 = array37;
							for (int num21 = 0; num21 < array38.Length; num21++)
							{
								short num22 = array38[num21];
								string format19 = " {0}({1})";
								Doctrine._FuelQuantityThreshold fuelQuantityThreshold2 = (Doctrine._FuelQuantityThreshold)num22;
								string str21 = string.Format(format19, fuelQuantityThreshold2.ToString(), num22.ToString());
								text21 += str21;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["deploy_on_fuel"]) + "' as deploy_on_fuel" + text21);
						}
						doctrine.SetRedeployFuelThresholdDoctrine(scenario_, false, false, false, new Doctrine._FuelQuantityThreshold?(fuelQuantityThreshold3));
					}
				}
				if (dictionary.ContainsKey("deploy_on_attack"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["deploy_on_attack"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold weaponQuantityThreshold4;
						if (!(Enum.TryParse<Doctrine._WeaponQuantityThreshold>(Conversions.ToString(dictionary["deploy_on_attack"]), out weaponQuantityThreshold4) & Enum.IsDefined(typeof(Doctrine._WeaponQuantityThreshold), weaponQuantityThreshold4)))
						{
							short[] array39 = (short[])Enum.GetValues(typeof(Doctrine._WeaponQuantityThreshold));
							string text22 = "; allowed values are ";
							short[] array40 = array39;
							for (int num23 = 0; num23 < array40.Length; num23++)
							{
								short num24 = array40[num23];
								string format20 = " {0}({1})";
								Doctrine._WeaponQuantityThreshold weaponQuantityThreshold2 = (Doctrine._WeaponQuantityThreshold)num24;
								string str22 = string.Format(format20, weaponQuantityThreshold2.ToString(), num24.ToString());
								text22 += str22;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["deploy_on_attack"]) + "' as deploy_on_attack" + text22);
						}
						doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_, false, false, false, new Doctrine._WeaponQuantityThreshold?(weaponQuantityThreshold4));
					}
				}
				if (dictionary.ContainsKey("deploy_on_defence"))
				{
					if (Operators.CompareString(Conversions.ToString(dictionary["deploy_on_defence"]).ToLower(), "inherit", false) == 0)
					{
						doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold weaponQuantityThreshold5;
						if (!(Enum.TryParse<Doctrine._WeaponQuantityThreshold>(Conversions.ToString(dictionary["deploy_on_defence"]), out weaponQuantityThreshold5) & Enum.IsDefined(typeof(Doctrine._WeaponQuantityThreshold), weaponQuantityThreshold5)))
						{
							short[] array41 = (short[])Enum.GetValues(typeof(Doctrine._WeaponQuantityThreshold));
							string text23 = "; allowed values are ";
							short[] array42 = array41;
							for (int num25 = 0; num25 < array42.Length; num25++)
							{
								short num26 = array42[num25];
								string format21 = " {0}({1})";
								Doctrine._WeaponQuantityThreshold weaponQuantityThreshold2 = (Doctrine._WeaponQuantityThreshold)num26;
								string str23 = string.Format(format21, weaponQuantityThreshold2.ToString(), num26.ToString());
								text23 += str23;
							}
							throw new Exception2("Can't understand '" + Conversions.ToString(dictionary["deploy_on_defence"]) + "' as deploy_on_defence" + text23);
						}
						doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_, false, false, false, new Doctrine._WeaponQuantityThreshold?(weaponQuantityThreshold5));
					}
				}
				luaTable_1 = Class281.smethod_1(luaTable_0, scenario_);
				return luaTable_1;
			}
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x003827E4 File Offset: 0x003809E4
		public static LuaTable smethod_1(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Doctrine doctrine = null;
			Side side = null;
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = Conversions.ToString(objectGeoLocation["GUID"]);
				try
				{
					doctrine = scenario_0.GetActiveUnits()[text].m_Doctrine;
					goto IL_340;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Can't find guid '" + text + "'");
				}
			}
			if (!objectGeoLocation.ContainsKey("NAME") && !objectGeoLocation.ContainsKey("UNITNAME"))
			{
				if (objectGeoLocation.ContainsKey("MISSION"))
				{
					Class281.Class285 @class = new Class281.Class285();
					@class.string_0 = Conversions.ToString(objectGeoLocation["MISSION"]);
					if (objectGeoLocation.ContainsKey("SIDE"))
					{
						string str = Conversions.ToString(objectGeoLocation["SIDE"]);
						try
						{
							side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							throw new Exception2("Can't find Side '" + str + "'");
						}
						try
						{
							Mission mission = side.GetMissionCollection().FirstOrDefault(new Func<Mission, bool>(@class.method_0));
							if (objectGeoLocation.ContainsKey("ESCORT") & mission.MissionClass == Mission._MissionClass.Strike)
							{
								doctrine = ((Strike)mission).Doctrine_Escorts;
							}
							else
							{
								doctrine = mission.m_Doctrine;
							}
							goto IL_340;
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							throw new Exception2("Can't find Mission '" + @class.string_0 + "'");
						}
					}
					throw new Exception2("To select a mission you need to define a side.");
				}
				if (!objectGeoLocation.ContainsKey("SIDE"))
				{
					goto IL_340;
				}
				string str2 = Conversions.ToString(objectGeoLocation["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					doctrine = side.m_Doctrine;
					goto IL_340;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					throw new Exception2("Can't find Side '" + str2 + "'");
				}
			}
			Class281.Class284 class2 = new Class281.Class284();
			class2.string_0 = null;
			if (objectGeoLocation.ContainsKey("NAME"))
			{
				class2.string_0 = Conversions.ToString(objectGeoLocation["NAME"]);
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				class2.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
			}
			if (objectGeoLocation.ContainsKey("SIDE"))
			{
				string text2 = Conversions.ToString(objectGeoLocation["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					throw new Exception2("Can't find Side '" + text2 + "'");
				}
				try
				{
					doctrine = side.ActiveUnitArray.FirstOrDefault(new Func<ActiveUnit, bool>(class2.method_0)).m_Doctrine;
					goto IL_340;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					throw new Exception2(string.Concat(new string[]
					{
						"Can't find Unit '",
						class2.string_0,
						"' on Side '",
						text2,
						"'"
					}));
				}
			}
			try
			{
				doctrine = scenario_0.GetActiveUnitList().FirstOrDefault(new Func<ActiveUnit, bool>(class2.method_1)).m_Doctrine;
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				throw new Exception2("Can't find Unit '" + class2.string_0 + "'");
			}
			IL_340:
			if (doctrine == null)
			{
				throw new Exception2("Need to define a guid, or a name, or a side and name, or a side and mission, or just a side.");
			}
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			bool flag = false;
			if (objectGeoLocation.ContainsKey("PLAYER_EDITABLE"))
			{
				flag = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["PLAYER_EDITABLE"])).Value;
			}
			if (!doctrine.WCS_AirHasNoValue())
			{
				luaTable["weapon_control_status_air"] = doctrine.GetWCS_AirDoctrine(scenario_0, false, new bool?(false), false, false).ToString();
			}
			if (!doctrine.WCS_AirHasNoValue() & flag)
			{
				luaTable["weapon_control_status_air_player_editable"] = doctrine.IsWCS_Air_PlayerEditable(scenario_0);
			}
			if (!doctrine.WCS_SurfaceHasNoValue())
			{
				luaTable["weapon_control_status_surface"] = doctrine.GetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), false, false).ToString();
			}
			if (!doctrine.WCS_SurfaceHasNoValue() & flag)
			{
				luaTable["weapon_control_status_surface_player_editable"] = doctrine.IsWCS_Surface_PlayerEditable(scenario_0);
			}
			if (!doctrine.WCS_SubmarineHasNoValue())
			{
				luaTable["weapon_control_status_subsurface"] = doctrine.GetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false).ToString();
			}
			if (!doctrine.WCS_SubmarineHasNoValue() & flag)
			{
				luaTable["weapon_control_status_subsurface_player_editable"] = doctrine.IsWCS_Submarine_PlayerEditable(scenario_0);
			}
			if (!doctrine.WCS_LandHasNoValue())
			{
				luaTable["weapon_control_status_land"] = doctrine.GetWCS_LandDoctrine(scenario_0, false, new bool?(false), false, false).ToString();
			}
			if (!doctrine.WCS_LandHasNoValue() & flag)
			{
				luaTable["weapon_control_status_land_player_editable"] = doctrine.IsWCSLand_PlayerEditable(scenario_0);
			}
			if (!doctrine.UseNukesHasNoValue())
			{
				luaTable["use_nuclear_weapons"] = doctrine.GetUseNuclearDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.UseNukesHasNoValue() & flag)
			{
				luaTable["use_nuclear_weapons_player_editable"] = doctrine.IsNukes_PlayerEditable(scenario_0);
			}
			if (!doctrine.WinchesterShotgunRTBHasNoValue())
			{
				luaTable["rtb_when_winchester"] = doctrine.GetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.WinchesterShotgunRTBHasNoValue() & flag)
			{
				luaTable["rtb_when_winchester_player_editable"] = doctrine.method_119(scenario_0);
			}
			if (!doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
			{
				luaTable["engaging_ambiguous_targets"] = doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.BehaviorTowardsAmbigousTargetHasNoValue() & flag)
			{
				luaTable["engaging_ambiguous_targets_player_editable"] = doctrine.IsBehaviorTowardsAmbigousTarget_PlayerEditable(scenario_0);
			}
			if (!doctrine.AutomaticEvasionHasNoValue())
			{
				luaTable["automatic_evasion"] = doctrine.GetAutomaticEvasionDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.AutomaticEvasionHasNoValue() & flag)
			{
				luaTable["automatic_evasion_player_editable"] = doctrine.method_134(scenario_0);
			}
			if (!doctrine.MaintainStandoffHasNoValue())
			{
				luaTable["maintain_standoff"] = doctrine.GetMaintainStandoffDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.MaintainStandoffHasNoValue() & flag)
			{
				luaTable["maintain_standoff_player_editable"] = doctrine.method_139(scenario_0);
			}
			if (!doctrine.UseRefuelHasNoValue())
			{
				luaTable["use_refuel_unrep"] = doctrine.GetUseRefuelDoctrine(scenario_0, false, false, false, false).ToString();
			}
			if (!doctrine.UseRefuelHasNoValue() & flag)
			{
				luaTable["use_refuel_unrep_player_editable"] = doctrine.method_149(scenario_0);
			}
			if (!doctrine.ShootTouristsHasNoValue())
			{
				luaTable["engage_opportunity_targets"] = doctrine.GetShootTouristsDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.ShootTouristsHasNoValue() & flag)
			{
				luaTable["engage_opportunity_targets_player_editable"] = doctrine.method_159(scenario_0);
			}
			if (!doctrine.SAM_ASUWHasNoValue())
			{
				luaTable["use_sams_in_anti_surface_mode"] = doctrine.GetUseSAMsInASuWModeDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.SAM_ASUWHasNoValue() & flag)
			{
				luaTable["use_sams_in_anti_surface_mode_player_editable"] = doctrine.method_164(scenario_0);
			}
			if (!doctrine.IgnoreEMCONUnderAttackHasNoValue())
			{
				luaTable["ignore_emcon_while_under_attack"] = doctrine.GetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.IgnoreEMCONUnderAttackHasNoValue() & flag)
			{
				luaTable["ignore_emcon_while_under_attack_player_editable"] = doctrine.method_169(scenario_0);
			}
			if (!doctrine.QuickTurnAroundHasNoValue())
			{
				luaTable["quick_turnaround_for_aircraft"] = doctrine.GetQuickTurnAroundDoctrine(scenario_0, false, false, false, false).ToString();
			}
			if (!doctrine.QuickTurnAroundHasNoValue() & flag)
			{
				luaTable["quick_turnaround_for_aircraft_player_editable"] = doctrine.method_178(scenario_0);
			}
			if (!doctrine.AirOpsTempoHasNoValue())
			{
				luaTable["air_operations_tempo"] = doctrine.GetAirOpsTempoDoctrine(scenario_0, false, false, false, false).ToString();
			}
			if (!doctrine.AirOpsTempoHasNoValue() & flag)
			{
				luaTable["air_operations_tempo_player_editable"] = doctrine.method_183(scenario_0);
			}
			if (!doctrine.UseTorpedoesKinematicRangeHasNoValue())
			{
				luaTable["kinematic_range_for_torpedoes"] = doctrine.GetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.UseTorpedoesKinematicRangeHasNoValue() & flag)
			{
				luaTable["kinematic_range_for_torpedoes_player_editable"] = doctrine.method_198(scenario_0);
			}
			if (!doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
			{
				luaTable["ignore_plotted_course"] = doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), false, false).ToString();
			}
			if (!doctrine.IgnorePlottedCourseWhenAttackingHasNoValue() & flag)
			{
				luaTable["ignore_plotted_course_player_editable"] = doctrine.IsIgnorePlottedCourseWhenAttackingPlayerEditable(scenario_0);
			}
			if (!doctrine.RefuelAlliesHasNoValue())
			{
				luaTable["refuel_unrep_allied"] = doctrine.GetRefuelAlliedUnitsDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RefuelAlliesHasNoValue() & flag)
			{
				luaTable["refuel_unrep_allied_player_editable"] = doctrine.RefuelAllies_PlayerEditable(scenario_0);
			}
			if (!doctrine.BingoJokerHasNoValue())
			{
				luaTable["fuel_state_planned"] = doctrine.GetBingoJokerDoctrine(scenario_0, false, false, false, false).ToString();
			}
			if (!doctrine.BingoJokerHasNoValue() & flag)
			{
				luaTable["fuel_state_planned_player_editable"] = doctrine.method_188(scenario_0);
			}
			if (!doctrine.BingoJokerRTBHasNoValue())
			{
				luaTable["fuel_state_rtb"] = doctrine.GetBingoJokerRTBDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.BingoJokerRTBHasNoValue() & flag)
			{
				luaTable["fuel_state_rtb_player_editable"] = doctrine.method_124(scenario_0);
			}
			if (!doctrine.WinchesterShotgunHasNoValue())
			{
				luaTable["weapon_state_planned"] = doctrine.GetWinchesterShotgunDoctrine(scenario_0, false, false, false, false).ToString();
			}
			if (!doctrine.WinchesterShotgunHasNoValue() & flag)
			{
				luaTable["weapon_state_planned_player_editable"] = doctrine.method_193(scenario_0);
			}
			if (!doctrine.WinchesterShotgunRTBHasNoValue())
			{
				luaTable["weapon_state_rtb"] = doctrine.GetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.WinchesterShotgunRTBHasNoValue() & flag)
			{
				luaTable["weapon_state_rtb_player_editable"] = doctrine.method_119(scenario_0);
			}
			if (!doctrine.GunStrafeGroundTargetsHasNoValue())
			{
				luaTable["gun_strafing"] = doctrine.GetGunStrafeGroundTargetsDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.GunStrafeGroundTargetsHasNoValue() & flag)
			{
				luaTable["gun_strafing_player_editable"] = doctrine.method_144(scenario_0);
			}
			if (!doctrine.JettisonOrdnanceHasNoValue())
			{
				luaTable["jettison_ordnance"] = doctrine.GetJettisonOrdnanceDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.JettisonOrdnanceHasNoValue() & flag)
			{
				luaTable["jettison_ordnance_player_editable"] = doctrine.method_129(scenario_0);
			}
			if (!doctrine.AvoidContactHasNoValue())
			{
				luaTable["avoid_contact"] = doctrine.GetAvoidContactWhenPossibleDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.AvoidContactHasNoValue() & flag)
			{
				luaTable["avoid_contact_player_editable"] = doctrine.AvoidContact_PlayerEditable(scenario_0);
			}
			if (!doctrine.DiveWhenThreatsDetectedHasNoValue())
			{
				luaTable["dive_on_threat"] = doctrine.GetDiveOnContactDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.DiveWhenThreatsDetectedHasNoValue() & flag)
			{
				luaTable["dive_on_threat_player_editable"] = doctrine.DiveWhenThreatsDetected_PlayerEditable(scenario_0);
			}
			if (!doctrine.RechargePercentagePatrolHasNoValue())
			{
				luaTable["recharge_on_patrol"] = doctrine.GetRechargeBatteryPercentageDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RechargePercentagePatrolHasNoValue() & flag)
			{
				luaTable["recharge_on_patrol_player_editable"] = doctrine.RechargePercentagePatrol_PlayerEditable(scenario_0);
			}
			if (!doctrine.RechargePercentageAttackHasNoValue())
			{
				luaTable["recharge_on_attack"] = doctrine.GetRechargeBatteryPercentageDoc(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RechargePercentageAttackHasNoValue() & flag)
			{
				luaTable["recharge_on_attack_player_editable"] = doctrine.RechargePercentageAttack_PlayerEditable(scenario_0);
			}
			if (!doctrine.AIPUsageHasNoValue())
			{
				luaTable["use_aip"] = doctrine.GetUseAIPDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.AIPUsageHasNoValue() & flag)
			{
				luaTable["use_aip_player_editable"] = doctrine.AIPUsage_PlayerEditable(scenario_0);
			}
			if (!doctrine.DippingSonarHasNoValue())
			{
				luaTable["dipping_sonar"] = doctrine.GetUseDippingSonarDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.DippingSonarHasNoValue() & flag)
			{
				luaTable["dipping_sonar_player_editable"] = doctrine.DippingSonar_PlayerEditable(scenario_0);
			}
			if (!doctrine.WithdrawDamageThresholdHasNoValue())
			{
				luaTable["withdraw_on_damage"] = doctrine.GetWithdrawDamageThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.WithdrawFuelThresholdHasNoValue())
			{
				luaTable["withdraw_on_fuel"] = doctrine.GetWithdrawFuelThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.WithdrawAttackThresholdHasNoValue())
			{
				luaTable["withdraw_on_attack"] = doctrine.GetWithdrawAttackThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.WithdrawDefenceThresholdHasNoValue())
			{
				luaTable["withdraw_on_defence"] = doctrine.GetWithdrawDefenceThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RedeployDamageThresholdHasNoValue())
			{
				luaTable["deploy_on_damage"] = doctrine.GetRedeployDamageThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RedeployFuelThresholdHasNoValue())
			{
				luaTable["deploy_on_fuel"] = doctrine.GetRedeployFuelThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
			{
				luaTable["deploy_on_attack"] = doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, false, false).ToString();
			}
			if (!doctrine.RedeployDefenceThresholdHasNoValue())
			{
				luaTable["deploy_on_defence"] = doctrine.GetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, false, false).ToString();
			}
			return luaTable;
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00383784 File Offset: 0x00381984
		public static LuaTable smethod_2(LuaTable luaTable_0, Scenario scenario_0)
		{
			Class281.Class286 @class = new Class281.Class286(null);
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Doctrine doctrine = null;
			Side side = null;
			Contact contact = null;
			Weapon weapon = null;
			int num = -1;
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.None;
			object obj = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			@class.string_0 = null;
			string str = null;
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = Conversions.ToString(objectGeoLocation["GUID"]);
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
					side = activeUnit.GetSide(false);
					doctrine = activeUnit.m_Doctrine;
					obj = "UNIT";
					goto IL_39B;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Can't find attacker '" + text + "'");
				}
			}
			if (!objectGeoLocation.ContainsKey("NAME") && !objectGeoLocation.ContainsKey("UNITNAME"))
			{
				if (objectGeoLocation.ContainsKey("MISSION"))
				{
					Class281.Class287 class2 = new Class281.Class287(null);
					class2.string_0 = Conversions.ToString(objectGeoLocation["MISSION"]);
					if (objectGeoLocation.ContainsKey("SIDE"))
					{
						str = Conversions.ToString(objectGeoLocation["SIDE"]);
						try
						{
							side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							throw new Exception2("Can't find Side '" + str + "'");
						}
						try
						{
							Mission mission = side.GetMissionCollection().FirstOrDefault(new Func<Mission, bool>(class2.method_0));
							if (objectGeoLocation.ContainsKey("ESCORT") & mission.MissionClass == Mission._MissionClass.Strike)
							{
								doctrine = ((Strike)mission).Doctrine_Escorts;
							}
							else
							{
								doctrine = mission.m_Doctrine;
							}
							obj = "MISSION";
							goto IL_39B;
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							throw new Exception2("Can't find Mission '" + class2.string_0 + "'");
						}
					}
					throw new Exception2("To select a mission you need to define a side.");
				}
				if (!objectGeoLocation.ContainsKey("SIDE"))
				{
					goto IL_39B;
				}
				str = Conversions.ToString(objectGeoLocation["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					doctrine = side.m_Doctrine;
					obj = "SIDE";
					goto IL_39B;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					throw new Exception2("Can't find Side '" + str + "'");
				}
			}
			if (objectGeoLocation.ContainsKey("SIDE"))
			{
				str = Conversions.ToString(objectGeoLocation["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					throw new Exception2("Can't find Side '" + str + "'");
				}
			}
			if (objectGeoLocation.ContainsKey("NAME"))
			{
				@class.string_0 = Conversions.ToString(objectGeoLocation["NAME"]);
			}
			if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
			}
			if (side == null)
			{
				List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (Operators.CompareString(current.Name.ToUpper(), @class.string_0.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid().ToUpper(), @class.string_0.ToUpper(), false) == 0)
						{
							activeUnit = current;
							side = activeUnit.GetSide(false);
							doctrine = activeUnit.m_Doctrine;
							IL_35A:
							goto IL_394;
						}
					}
					goto IL_394;
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
			doctrine = activeUnit.m_Doctrine;
			IL_394:
			obj = "UNIT";
			IL_39B:
			if (objectGeoLocation.ContainsKey("CONTACT_ID"))
			{
				string text2 = Conversions.ToString(objectGeoLocation["CONTACT_ID"]);
				try
				{
					string nameOrId = text2;
					Scenario scenarioContext = scenario_0;
					Side side2 = null;
					contact = LuaUtility.smethod_27(nameOrId, scenarioContext, ref side2);
					goto IL_47A;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					throw new Exception2("Can't find contact '" + text2 + "'");
				}
			}
			if (objectGeoLocation.ContainsKey("TARGET_TYPE"))
			{
				string text3 = Conversions.ToString(objectGeoLocation["TARGET_TYPE"]);
				try
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2;
					if (!(Enum.TryParse<Doctrine._WRA_WeaponTargetType>(text3, out wRA_WeaponTargetType2) & Enum.IsDefined(typeof(Doctrine._WRA_WeaponTargetType), wRA_WeaponTargetType2)))
					{
						throw new Exception2("Can't find target type '" + text3 + "'");
					}
					wRA_WeaponTargetType = wRA_WeaponTargetType2;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					throw new Exception2("Can't find target type '" + text3 + "'");
				}
			}
			IL_47A:
			checked
			{
				if (objectGeoLocation.ContainsKey("WEAPON_ID"))
				{
					try
					{
						int num2 = Conversions.ToInteger(objectGeoLocation["WEAPON_ID"]);
						if (activeUnit != null)
						{
							Mount[] mounts = activeUnit.m_Mounts;
							for (int i = 0; i < mounts.Length; i++)
							{
								Mount mount = mounts[i];
								if (mount.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
								{
									foreach (WeaponRec current2 in mount.GetWeaponRecCollection())
									{
										if (current2.WeapID == num2)
										{
											num = num2;
											weapon = current2.GetWeapon(scenario_0);
											break;
										}
									}
									if (num != -1)
									{
										break;
									}
								}
							}
						}
						else
						{
							num = num2;
							if (!scenario_0.Cache_Weapons.TryGetValue(num, out weapon))
							{
								Weapon weapon2 = Weapon.GetWeapon(ref scenario_0, num, null);
								DataRow[] array = scenario_0.Cache_Weapons_DT.Select("ID=" + Conversions.ToString(num));
								if (array != null && array.Count<DataRow>() > 0)
								{
									DBFunctions.LoadWeaponData(scenario_0.GetSQLiteConnection(), weapon2, num, scenario_0, true);
									weapon = weapon2;
								}
								else
								{
									num = -1;
								}
							}
							if (num == -1)
							{
								throw new Exception2("No matching weapon " + Conversions.ToString(num2));
							}
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						throw new Exception2("Can't find weapon");
					}
				}
				if (doctrine == null)
				{
					throw new Exception2("No doctrine set for unit.");
				}
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaTable result;
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.None & contact == null)
				{
					result = null;
				}
				else
				{
					if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.None & contact != null)
					{
						Doctrine doctrine2 = doctrine;
						Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType3 = doctrine.GetWRA_WeaponTargetType(ref contact);
						wRA_WeaponTargetType = doctrine2.GetWRA_WeaponTargetType(ref weapon, ref doctrine, ref contact, ref wRA_WeaponTargetType3);
					}
					if (!wRA_WeaponTargetType.Equals(Doctrine._WRA_WeaponTargetType.None) && doctrine.IsLethalWeapon(ref weapon))
					{
						int? num3 = doctrine.GetQtyByWeapon(weapon.m_Scenario, weapon, wRA_WeaponTargetType);
						int? num4 = doctrine.GetInheritedShooterQty(weapon.m_Scenario, weapon, wRA_WeaponTargetType);
						int? num5 = doctrine.method_25(weapon.m_Scenario, weapon.DBID, wRA_WeaponTargetType);
						int? num6 = doctrine.method_20(weapon.m_Scenario, weapon, wRA_WeaponTargetType);
						luaTable["WEAPON_DBID"] = weapon.DBID;
						luaTable["WEAPON_NAME"] = weapon.Name;
						luaTable["TARGET_TYPE"] = wRA_WeaponTargetType;
						luaTable["LEVEL"] = RuntimeHelpers.GetObjectValue(obj);
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						int? num7 = num3;
						if (!((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 0) : null) | !num3.HasValue).GetValueOrDefault())
						{
							num7 = num3;
							if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								luaTable2["QTY_SALVO"] = "Max";
							}
							else
							{
								luaTable2["QTY_SALVO"] = num3;
							}
						}
						if (num4.HasValue)
						{
							num7 = num4;
							if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								luaTable2["SHOOTER_SALVO"] = "Max";
							}
							else
							{
								luaTable2["SHOOTER_SALVO"] = num4;
							}
						}
						if (num4.HasValue & num3.HasValue)
						{
							if (Information.IsNothing(num5))
							{
								luaTable2["FIRING_RANGE"] = "Max";
							}
							else
							{
								num7 = num5;
								if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
								{
									luaTable2["FIRING_RANGE"] = "Max";
								}
								else
								{
									num7 = num5;
									if (!(num7.HasValue ? new bool?(num7.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										luaTable2["FIRING_RANGE"] = num5;
									}
								}
							}
						}
						num7 = num6;
						if (!((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 0) : null) | !num6.HasValue).GetValueOrDefault())
						{
							num7 = num6;
							if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								luaTable2["SELF_DEFENCE"] = "Max";
							}
							else
							{
								luaTable2["SELF_DEFENCE"] = num6;
							}
						}
						if (luaTable2.Keys.Count > 0)
						{
							luaTable["WRA"] = luaTable2;
						}
					}
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00384264 File Offset: 0x00382464
		public static LuaTable smethod_3(LuaTable luaTable_0, LuaTable luaTable_1, Scenario scenario_0)
		{
			Class281.Class288 @class = new Class281.Class288(null);
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Doctrine doctrine = null;
			ActiveUnit activeUnit = null;
			Side side = null;
			Contact contact = null;
			Weapon weapon = null;
			int num = -1;
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.None;
			string value = "SIDE";
			LuaUtility.smethod_4(ref objectGeoLocation);
			@class.string_0 = null;
			string str = null;
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = Conversions.ToString(objectGeoLocation["GUID"]);
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
					side = activeUnit.GetSide(false);
					doctrine = activeUnit.m_Doctrine;
					value = "UNIT";
					goto IL_39F;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Can't find attacker '" + text + "'");
				}
			}
			if (!objectGeoLocation.ContainsKey("NAME") && !objectGeoLocation.ContainsKey("UNITNAME"))
			{
				if (objectGeoLocation.ContainsKey("MISSION"))
				{
					Class281.Class289 class2 = new Class281.Class289(null);
					class2.string_0 = Conversions.ToString(objectGeoLocation["MISSION"]);
					if (objectGeoLocation.ContainsKey("SIDE"))
					{
						str = Conversions.ToString(objectGeoLocation["SIDE"]);
						try
						{
							side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							throw new Exception2("Can't find Side '" + str + "'");
						}
						try
						{
							Mission mission = side.GetMissionCollection().FirstOrDefault(new Func<Mission, bool>(class2.method_0));
							if (objectGeoLocation.ContainsKey("ESCORT") & mission.MissionClass == Mission._MissionClass.Strike)
							{
								doctrine = ((Strike)mission).Doctrine_Escorts;
							}
							else
							{
								doctrine = mission.m_Doctrine;
							}
							value = "MISSION";
							goto IL_39F;
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							throw new Exception2("Can't find Mission '" + class2.string_0 + "'");
						}
					}
					throw new Exception2("To select a mission you need to define a side.");
				}
				if (!objectGeoLocation.ContainsKey("SIDE"))
				{
					goto IL_39F;
				}
				str = Conversions.ToString(objectGeoLocation["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					doctrine = side.m_Doctrine;
					value = "SIDE";
					goto IL_39F;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					throw new Exception2("Can't find Side '" + str + "'");
				}
			}
			if (objectGeoLocation.ContainsKey("SIDE"))
			{
				str = Conversions.ToString(objectGeoLocation["SIDE"]);
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					throw new Exception2("Can't find Side '" + str + "'");
				}
			}
			if (objectGeoLocation.ContainsKey("NAME"))
			{
				@class.string_0 = Conversions.ToString(objectGeoLocation["NAME"]);
			}
			if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
			}
			if (side == null)
			{
				List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (Operators.CompareString(current.Name.ToUpper(), @class.string_0.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid().ToUpper(), @class.string_0.ToUpper(), false) == 0)
						{
							activeUnit = current;
							side = activeUnit.GetSide(false);
							doctrine = activeUnit.m_Doctrine;
							IL_35E:
							goto IL_398;
						}
					}
					goto IL_398;
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
			doctrine = activeUnit.m_Doctrine;
			IL_398:
			value = "UNIT";
			IL_39F:
			objectGeoLocation["LEVEL"] = value;
			if (objectGeoLocation.ContainsKey("CONTACT_ID"))
			{
				string text2 = Conversions.ToString(objectGeoLocation["CONTACT_ID"]);
				try
				{
					string nameOrId = text2;
					Side side2 = null;
					contact = LuaUtility.smethod_27(nameOrId, scenario_0, ref side2);
					goto IL_487;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					throw new Exception2("Can't find contact '" + text2 + "'");
				}
			}
			if (objectGeoLocation.ContainsKey("TARGET_TYPE"))
			{
				string text3 = Conversions.ToString(objectGeoLocation["TARGET_TYPE"]);
				try
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2;
					if (!(Enum.TryParse<Doctrine._WRA_WeaponTargetType>(text3, out wRA_WeaponTargetType2) & Enum.IsDefined(typeof(Doctrine._WRA_WeaponTargetType), wRA_WeaponTargetType2)))
					{
						throw new Exception2("Can't find target type '" + text3 + "'");
					}
					wRA_WeaponTargetType = wRA_WeaponTargetType2;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					throw new Exception2("Can't find target type '" + text3 + "'");
				}
			}
			IL_487:
			checked
			{
				if (objectGeoLocation.ContainsKey("WEAPON_ID"))
				{
					try
					{
						int num2 = Conversions.ToInteger(objectGeoLocation["WEAPON_ID"]);
						Mount[] mounts = activeUnit.m_Mounts;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							if (mount.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
							{
								foreach (WeaponRec current2 in mount.GetWeaponRecCollection())
								{
									if (current2.WeapID == num2)
									{
										num = num2;
										weapon = current2.GetWeapon(scenario_0);
										break;
									}
								}
								if (num != -1)
								{
									break;
								}
							}
						}
						if (num == -1)
						{
							throw new Exception2("No matching weapon " + Conversions.ToString(num2));
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						throw new Exception2("Can't find weapon");
					}
				}
				if (doctrine == null)
				{
					throw new Exception2("No doctrine set for unit.");
				}
				LuaTable luaTable = null;
				LuaTable result;
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.None & contact == null)
				{
					luaTable = null;
				}
				else
				{
					Dictionary<int, Doctrine.WRA_Weapon> dictionary = doctrine.GetWRA_WeaponDictionary();
					Dictionary<string, object> dictionary2 = LuaUtility.smethod_2(luaTable_1.GetEnumerator());
					if (dictionary2.Count != 4)
					{
						throw new Exception2("Require 4 values in order: weapons per salvo, shooters per salvo, firing range, self-defence range");
					}
					string text4;
					string text5;
					string text6;
					string text7;
					try
					{
						text4 = Conversions.ToString(dictionary2["1"]);
						text5 = Conversions.ToString(dictionary2["2"]);
						text6 = Conversions.ToString(dictionary2["3"]);
						text7 = Conversions.ToString(dictionary2["4"]);
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						throw new Exception2("Invalid WRA table entries");
					}
					LuaSandBox.Singleton().CreateTable();
					Collection<Doctrine.WRA_WeaponTarget> collection = new Collection<Doctrine.WRA_WeaponTarget>();
					Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
					if (dictionary == null)
					{
						dictionary = new Dictionary<int, Doctrine.WRA_Weapon>();
					}
					if (!dictionary.TryGetValue(num, out wRA_Weapon))
					{
						dictionary.Add(num, null);
					}
					dictionary.TryGetValue(num, out wRA_Weapon);
					if (Information.IsNothing(wRA_Weapon))
					{
						wRA_Weapon = new Doctrine.WRA_Weapon();
						if (dictionary.ContainsKey(num))
						{
							dictionary[num] = wRA_Weapon;
						}
					}
					bool flag = false;
					Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
					int num3 = 0;
					if (0 < wRA_WeaponTargetArray.Length)
					{
						if (wRA_WeaponTargetArray[num3].WRA_WeaponTargetType == wRA_WeaponTargetType)
						{
							flag = true;
						}
						else if (num3 != wRA_WeaponTargetArray.Length - 1)
						{
						}
						if (!flag)
						{
							Doctrine.WRA_WeaponTarget class121_ = new Doctrine.WRA_WeaponTarget(wRA_WeaponTargetType);
							ScenarioArrayUtil.AddWRA_WeaponTarget(ref wRA_Weapon.WRA_WeaponTargetArray, class121_);
						}
						try
						{
							if (wRA_Weapon.WRA_WeaponTargetArray != null)
							{
								Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray2 = wRA_Weapon.WRA_WeaponTargetArray;
								for (int j = 0; j < wRA_WeaponTargetArray2.Length; j++)
								{
									Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray2[j];
									unchecked
									{
										if (wRA_WeaponTarget.WRA_WeaponTargetType == wRA_WeaponTargetType)
										{
											if (Operators.CompareString(text4.ToLower(), "inherit", false) == 0 & Operators.CompareString(text5.ToLower(), "inherit", false) == 0 & Operators.CompareString(text6.ToLower(), "inherit", false) == 0 & Operators.CompareString(text7.ToLower(), "inherit", false) == 0)
											{
												collection.Add(wRA_WeaponTarget);
											}
											else
											{
												int value2 = 0;
												if (Operators.CompareString(text4.ToLower(), "inherit", false) == 0)
												{
													wRA_WeaponTarget.WeaponQty = null;
												}
												else if (Operators.CompareString(text4.ToLower(), "system", false) == 0)
												{
													wRA_WeaponTarget.WeaponQty = new int?(-1);
												}
												else if (Operators.CompareString(text4.ToLower(), "max", false) == 0)
												{
													wRA_WeaponTarget.WeaponQty = new int?(-99);
												}
												else if (Operators.CompareString(text4.ToLower(), "none", false) == 0)
												{
													wRA_WeaponTarget.WeaponQty = new int?(0);
												}
												else if (int.TryParse(text4, out value2))
												{
													wRA_WeaponTarget.WeaponQty = new int?(value2);
												}
												int int_ = 0;
												if (Operators.CompareString(text5.ToLower(), "inherit", false) == 0)
												{
													wRA_WeaponTarget.ShooterQty = null;
												}
												else if (Operators.CompareString(text5.ToLower(), "system", false) == 0)
												{
													wRA_WeaponTarget.ShooterQty = new int?(-1);
												}
												else if (Operators.CompareString(text5.ToLower(), "max", false) == 0)
												{
													wRA_WeaponTarget.ShooterQty = new int?(-99);
												}
												else if (int.TryParse(text5, out int_))
												{
													int value3 = Class281.smethod_5(int_, doctrine);
													wRA_WeaponTarget.ShooterQty = new int?(value3);
												}
												int num4 = 0;
												if (Operators.CompareString(text6.ToLower(), "inherit", false) == 0)
												{
													wRA_WeaponTarget.FiringRange = null;
												}
												else if (Operators.CompareString(text6.ToLower(), "max", false) == 0)
												{
													wRA_WeaponTarget.FiringRange = new int?(-99);
												}
												else if (Operators.CompareString(text6.ToLower(), "none", false) == 0)
												{
													wRA_WeaponTarget.FiringRange = new int?(0);
												}
												else if (int.TryParse(text6, out num4))
												{
													float largestRangeMaxOfAllDomains = weapon.GetLargestRangeMaxOfAllDomains();
													if (num4 < (int)Math.Round((double)largestRangeMaxOfAllDomains))
													{
														int value4 = Class281.smethod_4(num4, doctrine);
														wRA_WeaponTarget.FiringRange = new int?(value4);
													}
													else
													{
														wRA_WeaponTarget.FiringRange = new int?(-99);
													}
												}
												int num5 = 0;
												if (Operators.CompareString(text7.ToLower(), "inherit", false) == 0)
												{
													wRA_WeaponTarget.SelfDefenceRange = null;
												}
												else if (Operators.CompareString(text7.ToLower(), "system", false) == 0)
												{
													wRA_WeaponTarget.SelfDefenceRange = new int?(-1);
												}
												else if (Operators.CompareString(text7.ToLower(), "max", false) == 0)
												{
													wRA_WeaponTarget.SelfDefenceRange = new int?(-99);
												}
												else if (Operators.CompareString(text7.ToLower(), "none", false) == 0)
												{
													wRA_WeaponTarget.SelfDefenceRange = new int?(0);
												}
												else if (int.TryParse(text7, out num5))
												{
													if (num5 < (int)Math.Round((double)15f))
													{
														wRA_WeaponTarget.SelfDefenceRange = new int?(num5);
													}
													else
													{
														wRA_WeaponTarget.SelfDefenceRange = new int?(-99);
													}
												}
											}
										}
									}
								}
							}
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							throw new Exception2("Invalid WRA values");
						}
						if (collection.Count > 0)
						{
							foreach (Doctrine.WRA_WeaponTarget current3 in collection)
							{
								ScenarioArrayUtil.RemoveWRA_WeaponTarget(ref wRA_Weapon.WRA_WeaponTargetArray, current3);
							}
						}
						if (wRA_Weapon.WRA_WeaponTargetArray.Count<Doctrine.WRA_WeaponTarget>() == 0)
						{
							wRA_Weapon.WRA_WeaponTargetArray = null;
						}
						if (Information.IsNothing(wRA_Weapon.WRA_WeaponTargetArray))
						{
							dictionary.Remove(num);
						}
						if (Information.IsNothing(dictionary) || dictionary.Count == 0)
						{
							dictionary = null;
						}
						doctrine.SetWRA_WeaponDictionary(dictionary);
						LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
						luaTable = Class281.smethod_2(luaTable_0, scenario_0);
						result = luaTable;
						return result;
					}
				}
				result = luaTable;
				return result;
			}
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00384F74 File Offset: 0x00383174
		public static int smethod_4(int int_0, Doctrine doctrine_0)
		{
			int num = 0;
			int result;
			if (int_0 == -4)
			{
				result = 5;
			}
			else
			{
				if (int_0 <= 50)
				{
					num = int_0 / 5 * 5;
				}
				else if (int_0 <= 100)
				{
					num = int_0 / 10 * 10;
				}
				else if (int_0 <= 200)
				{
					num = int_0 / 25 * 25;
				}
				else if (int_0 <= 250)
				{
					num = 250;
				}
				else if (int_0 <= 300)
				{
					num = 300;
				}
				else if (int_0 <= 500)
				{
					num = 500;
				}
				else if (int_0 <= 750)
				{
					num = 750;
				}
				else if (int_0 <= 1000)
				{
					num = 1000;
				}
				else if (int_0 <= 1500)
				{
					num = 1500;
				}
				else if (int_0 <= 2000)
				{
					num = 2000;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x00385054 File Offset: 0x00383254
		public static int smethod_5(int int_0, Doctrine doctrine_0)
		{
			int num = 0;
			int result;
			if (int_0 == 1)
			{
				result = 1;
			}
			else if (int_0 == -1)
			{
				result = 2;
			}
			else if (int_0 == 4)
			{
				result = 4;
			}
			else if (int_0 > 4)
			{
				result = -99;
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x02000C46 RID: 3142
		[CompilerGenerated]
		public sealed class Class282
		{
			// Token: 0x060068C4 RID: 26820 RVA: 0x0002D075 File Offset: 0x0002B275
			public Class282(Class281.Class282 class282_0)
			{
				if (class282_0 != null)
				{
					this.string_0 = class282_0.string_0;
				}
			}

			// Token: 0x060068C5 RID: 26821 RVA: 0x0002D08F File Offset: 0x0002B28F
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x060068C6 RID: 26822 RVA: 0x0002D08F File Offset: 0x0002B28F
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04003B12 RID: 15122
			public string string_0;
		}

		// Token: 0x02000C47 RID: 3143
		[CompilerGenerated]
		public sealed class Class283
		{
			// Token: 0x060068C7 RID: 26823 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
			public Class283(Class281.Class283 class283_0)
			{
				if (class283_0 != null)
				{
					this.string_0 = class283_0.string_0;
				}
			}

			// Token: 0x060068C8 RID: 26824 RVA: 0x0002D0CA File Offset: 0x0002B2CA
			internal bool method_0(Mission mission_0)
			{
				return Operators.CompareString(mission_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(mission_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04003B13 RID: 15123
			public string string_0;
		}

		// Token: 0x02000C48 RID: 3144
		[CompilerGenerated]
		public sealed class Class284
		{
			// Token: 0x060068C9 RID: 26825 RVA: 0x003850A0 File Offset: 0x003832A0
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid().ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x060068CA RID: 26826 RVA: 0x003850A0 File Offset: 0x003832A0
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid().ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04003B14 RID: 15124
			public string string_0;
		}

		// Token: 0x02000C49 RID: 3145
		[CompilerGenerated]
		public sealed class Class285
		{
			// Token: 0x060068CC RID: 26828 RVA: 0x0002D101 File Offset: 0x0002B301
			internal bool method_0(Mission mission_)
			{
				return Operators.CompareString(mission_.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(mission_.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04003B15 RID: 15125
			public string string_0;
		}

		// Token: 0x02000C4A RID: 3146
		[CompilerGenerated]
		public sealed class Class286
		{
			// Token: 0x060068CE RID: 26830 RVA: 0x0002D138 File Offset: 0x0002B338
			public Class286(Class281.Class286 class286_0)
			{
				if (class286_0 != null)
				{
					this.string_0 = class286_0.string_0;
				}
			}

			// Token: 0x060068CF RID: 26831 RVA: 0x0002D152 File Offset: 0x0002B352
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04003B16 RID: 15126
			public string string_0;
		}

		// Token: 0x02000C4B RID: 3147
		[CompilerGenerated]
		public sealed class Class287
		{
			// Token: 0x060068D0 RID: 26832 RVA: 0x0002D18E File Offset: 0x0002B38E
			public Class287(Class281.Class287 class287_0)
			{
				if (class287_0 != null)
				{
					this.string_0 = class287_0.string_0;
				}
			}

			// Token: 0x060068D1 RID: 26833 RVA: 0x0002D1A8 File Offset: 0x0002B3A8
			internal bool method_0(Mission mission_0)
			{
				return Operators.CompareString(mission_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(mission_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04003B17 RID: 15127
			public string string_0;
		}

		// Token: 0x02000C4C RID: 3148
		[CompilerGenerated]
		public sealed class Class288
		{
			// Token: 0x060068D2 RID: 26834 RVA: 0x0002D1DF File Offset: 0x0002B3DF
			public Class288(Class281.Class288 class288_0)
			{
				if (class288_0 != null)
				{
					this.string_0 = class288_0.string_0;
				}
			}

			// Token: 0x060068D3 RID: 26835 RVA: 0x0002D1F9 File Offset: 0x0002B3F9
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04003B18 RID: 15128
			public string string_0;
		}

		// Token: 0x02000C4D RID: 3149
		[CompilerGenerated]
		public sealed class Class289
		{
			// Token: 0x060068D4 RID: 26836 RVA: 0x0002D235 File Offset: 0x0002B435
			public Class289(Class281.Class289 class289_0)
			{
				if (class289_0 != null)
				{
					this.string_0 = class289_0.string_0;
				}
			}

			// Token: 0x060068D5 RID: 26837 RVA: 0x0002D24F File Offset: 0x0002B44F
			internal bool method_0(Mission mission_0)
			{
				return Operators.CompareString(mission_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(mission_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04003B19 RID: 15129
			public string string_0;
		}
	}
}
