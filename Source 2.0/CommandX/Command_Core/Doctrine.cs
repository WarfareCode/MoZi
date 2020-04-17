using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 作战条令
	public sealed class Doctrine
	{
		// Token: 0x06006466 RID: 25702 RVA: 0x0031A504 File Offset: 0x00318704
		[CompilerGenerated]
		public static void smethod_0(Doctrine.Delegate9 delegate9_1)
		{
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			Doctrine.Delegate9 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate9 value = (Doctrine.Delegate9)Delegate.Combine(delegate2, delegate9_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate9>(ref Doctrine.delegate9_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x0031A53C File Offset: 0x0031873C
		[CompilerGenerated]
		public static void smethod_1(Doctrine.Delegate9 delegate9_1)
		{
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			Doctrine.Delegate9 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate9 value = (Doctrine.Delegate9)Delegate.Remove(delegate2, delegate9_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate9>(ref Doctrine.delegate9_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x0031A574 File Offset: 0x00318774
		[CompilerGenerated]
		public static void smethod_2(Doctrine.Delegate10 delegate10_1)
		{
			Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
			Doctrine.Delegate10 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate10 value = (Doctrine.Delegate10)Delegate.Combine(delegate2, delegate10_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate10>(ref Doctrine.delegate10_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x0031A5AC File Offset: 0x003187AC
		[CompilerGenerated]
		public static void smethod_3(Doctrine.Delegate10 delegate10_1)
		{
			Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
			Doctrine.Delegate10 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate10 value = (Doctrine.Delegate10)Delegate.Remove(delegate2, delegate10_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate10>(ref Doctrine.delegate10_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x0031A5E4 File Offset: 0x003187E4
		public Doctrine(Subject theSubject, ref Collection<ActiveUnit> collection_1)
		{
			try
			{
				this.subject = theSubject;
				this.m_ActiveUnits = collection_1;
				if (this.subject.GetType() == typeof(Side))
				{
					this.Nukes = new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_0);
					this.Nukes_Player = false;
					this.WCS_Air = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight);
					this.WCS_Air_Player = true;
					this.WCS_Surface = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight);
					this.WCS_Surface_Player = true;
					this.WCS_Submarine = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight);
					this.WCS_Submarine_Player = true;
					this.WCS_Land = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight);
					this.WCS_Player_Land = true;
					this.GunStrafeGroundTargets = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.No);
					this.GS_Player = true;
					this.IgnorePlottedCourseWhenAttacking = new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0);
					this.IPCWA_Player = true;
					this.BehaviorTowardsAmbigousTarget = new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Pessimistic);
					this.BehaviorTowardsAmbigousTarget_Player = true;
					this.AutomaticEvasion = new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_1);
					this.AE_Player = true;
					this.MaintainStandoff = new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_1);
					this.MS_Player = true;
					this.UseRefuel = new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0);
					this.UR_Player = true;
					this.RefuelSelection = new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_0);
					this.RS_Player = true;
					this.ShootTourists = new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0);
					this.ST_Player = true;
					this.SAM_ASUW = new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_0);
					this.SAM_ASUW_Player = true;
					this.IgnoreEMCONUnderAttack = new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_1);
					this.IgnoreEMCONUnderAttack_Player = true;
					this.QuickTurnAround = new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_1);
					this.QTA_Player = false;
					this.AirOpsTempo = new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_0);
					this.AirOpsTempo_Player = false;
					this.WinchesterShotgun = new Doctrine._WeaponState?(Doctrine._WeaponState.LoadoutSetting);
					this.WinchesterShotgun_Player = true;
					this.WinchesterShotgunRTB = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit);
					this.WinchesterShotgunRTB_Player = true;
					this.BingoJoker = new Doctrine._FuelState?(Doctrine._FuelState.Bingo);
					this.BingoJoker_Player = true;
					this.BingoJokerRTB_Player = true;
					this.BingoJokerRTB = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit);
					this.JettisonOrdnance = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.No);
					this.JettisonOrdnance_Player = true;
					this.UseTorpedoesKinematicRange = new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_2);
					this.UseTorpedoesKinematicRange_Player = true;
					this.RefuelAllies = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes);
					this.RefuelAllies_Player = true;
					this.AvoidContact = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.No);
					this.AvoidContact_Player = true;
					this.DiveWhenThreatsDetected = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes);
					this.DiveWhenThreatsDetected_Player = true;
					this.RechargePercentagePatrol = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent);
					this.RechargePercentagePatrol_Player = true;
					this.RechargePercentageAttack = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent);
					this.RechargePercentageAttack_Player = true;
					this.AIPUsage = new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_AttackOnly);
					this.AIPUsage_Player = true;
					this.DippingSonar = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft);
					this.DippingSonar_Player = true;
					this.m_EMCON_Settings = new Doctrine.EMCON_Settings();
					this.WithdrawDamageThreshold = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore);
					this.WithdrawFuelThreshold = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo);
					this.WithdrawAttackThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore);
					this.WithdrawDefenceThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore);
					this.RedeployDamageThreshold = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5);
					this.RedeployFuelThreshold = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent100);
					this.RedeployAttackThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100);
					this.RedeployDefenceThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100);
				}
				else if (this.subject.GetType() == typeof(Waypoint))
				{
					this.Nukes = new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_3);
					this.WCS_Air = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_4);
					this.WCS_Surface = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_4);
					this.WCS_Submarine = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_4);
					this.WCS_Land = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_4);
					this.GunStrafeGroundTargets = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.NotConfigured);
					this.IgnorePlottedCourseWhenAttacking = new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_3);
					this.BehaviorTowardsAmbigousTarget = new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.const_4);
					this.AutomaticEvasion = new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_3);
					this.MaintainStandoff = new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_3);
					this.UseRefuel = new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_4);
					this.RefuelSelection = new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_4);
					this.ShootTourists = new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_3);
					this.SAM_ASUW = new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_3);
					this.IgnoreEMCONUnderAttack = new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_3);
					this.QuickTurnAround = new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_4);
					this.AirOpsTempo = new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_3);
					this.WinchesterShotgun = new Doctrine._WeaponState?(Doctrine._WeaponState.NotConfigured);
					this.WinchesterShotgunRTB = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.NotConfigured);
					this.BingoJoker = new Doctrine._FuelState?(Doctrine._FuelState.NotConfigured);
					this.BingoJokerRTB = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.NotConfigured);
					this.JettisonOrdnance = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.NotConfigured);
					this.UseTorpedoesKinematicRange = new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_4);
					this.RefuelAllies = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.NotConfigured);
					this.AvoidContact = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.NotConfigured);
					this.DiveWhenThreatsDetected = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.NotConfigured);
					this.RechargePercentagePatrol = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.NotConfigured);
					this.RechargePercentageAttack = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.NotConfigured);
					this.AIPUsage = new Doctrine._UseAIP?(Doctrine._UseAIP.NotConfigured);
					this.DippingSonar = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.NotConfigured);
					this.WithdrawDamageThreshold = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.NotConfigured);
					this.WithdrawFuelThreshold = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.NotConfigured);
					this.WithdrawAttackThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
					this.WithdrawDefenceThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
					this.RedeployDamageThreshold = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.NotConfigured);
					this.RedeployFuelThreshold = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.NotConfigured);
					this.RedeployAttackThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
					this.RedeployDefenceThreshold = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101000", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x0031AB24 File Offset: 0x00318D24
		public Doctrine NewDoctrineEMCON(ref Doctrine doctrine_1, Subject class137_1, ref Scenario scenario_0)
		{
			Doctrine.EMCON_Settings.Enum36 enum36_;
			Doctrine.EMCON_Settings.Enum36 enum36_2;
			Doctrine.EMCON_Settings.Enum36 enum36_3;
			if (doctrine_1.EMCON_SettingsHasNoValue() && this.subject.GetType() == typeof(Waypoint))
			{
				enum36_ = Doctrine.EMCON_Settings.Enum36.const_3;
				enum36_2 = Doctrine.EMCON_Settings.Enum36.const_3;
				enum36_3 = Doctrine.EMCON_Settings.Enum36.const_3;
			}
			else
			{
				enum36_ = doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar();
				enum36_2 = doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar();
				enum36_3 = doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM();
			}
			return new Doctrine(ref scenario_0, ref class137_1, doctrine_1.Nukes, doctrine_1.UseNukesHasNoValue(), doctrine_1.WCS_Air, doctrine_1.WCS_AirHasNoValue(), doctrine_1.WCS_Surface, doctrine_1.WCS_SurfaceHasNoValue(), doctrine_1.WCS_Submarine, doctrine_1.WCS_SubmarineHasNoValue(), doctrine_1.WCS_Land, doctrine_1.WCS_LandHasNoValue(), doctrine_1.GunStrafeGroundTargets, doctrine_1.GunStrafeGroundTargetsHasNoValue(), doctrine_1.IgnorePlottedCourseWhenAttacking, doctrine_1.IgnorePlottedCourseWhenAttackingHasNoValue(), doctrine_1.BehaviorTowardsAmbigousTarget, doctrine_1.BehaviorTowardsAmbigousTargetHasNoValue(), doctrine_1.AutomaticEvasion, doctrine_1.AutomaticEvasionHasNoValue(), doctrine_1.MaintainStandoff, doctrine_1.MaintainStandoffHasNoValue(), doctrine_1.UseRefuel, doctrine_1.UseRefuelHasNoValue(), doctrine_1.RefuelSelection, doctrine_1.RefuelSelectionHasNoValue(), doctrine_1.ShootTourists, doctrine_1.ShootTouristsHasNoValue(), doctrine_1.SAM_ASUW, doctrine_1.SAM_ASUWHasNoValue(), doctrine_1.IgnoreEMCONUnderAttack, doctrine_1.IgnoreEMCONUnderAttackHasNoValue(), doctrine_1.QuickTurnAround, doctrine_1.QuickTurnAroundHasNoValue(), doctrine_1.AirOpsTempo, doctrine_1.AirOpsTempoHasNoValue(), doctrine_1.WinchesterShotgun, doctrine_1.WinchesterShotgunHasNoValue(), doctrine_1.WinchesterShotgunRTB, doctrine_1.WinchesterShotgunRTBHasNoValue(), doctrine_1.BingoJoker, doctrine_1.BingoJokerHasNoValue(), doctrine_1.BingoJokerRTB, doctrine_1.BingoJokerRTBHasNoValue(), doctrine_1.JettisonOrdnance, doctrine_1.JettisonOrdnanceHasNoValue(), doctrine_1.UseTorpedoesKinematicRange, doctrine_1.UseTorpedoesKinematicRangeHasNoValue(), doctrine_1.RefuelAllies, doctrine_1.RefuelAlliesHasNoValue(), doctrine_1.AvoidContact, doctrine_1.AvoidContactHasNoValue(), doctrine_1.DiveWhenThreatsDetected, doctrine_1.DiveWhenThreatsDetectedHasNoValue(), doctrine_1.RechargePercentagePatrol, doctrine_1.RechargePercentagePatrolHasNoValue(), doctrine_1.RechargePercentageAttack, doctrine_1.RechargePercentageAttackHasNoValue(), doctrine_1.AIPUsage, doctrine_1.AIPUsageHasNoValue(), doctrine_1.DippingSonar, doctrine_1.DippingSonarHasNoValue(), doctrine_1.WithdrawDamageThreshold, doctrine_1.WithdrawDamageThresholdHasNoValue(), doctrine_1.WithdrawFuelThreshold, doctrine_1.WithdrawFuelThresholdHasNoValue(), doctrine_1.WithdrawAttackThreshold, doctrine_1.WithdrawAttackThresholdHasNoValue(), doctrine_1.WithdrawDefenceThreshold, doctrine_1.WithdrawDefenceThresholdHasNoValue(), doctrine_1.RedeployDamageThreshold, doctrine_1.RedeployDamageThresholdHasNoValue(), doctrine_1.RedeployFuelThreshold, doctrine_1.RedeployFuelThresholdHasNoValue(), doctrine_1.RedeployAttackThreshold, doctrine_1.RedeployAttackWeaponQuantityThresholdHasNoValue(), doctrine_1.RedeployDefenceThreshold, doctrine_1.RedeployDefenceThresholdHasNoValue(), enum36_, enum36_2, enum36_3, doctrine_1.EMCON_SettingsHasNoValue());
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x0031ADBC File Offset: 0x00318FBC
		public Doctrine(ref Scenario scenario_0, ref Subject _subject, Doctrine._UseNuclear? nullable_38, bool bool_31, Doctrine._WeaponControlStatus? nullable_39, bool bool_32, Doctrine._WeaponControlStatus? nullable_40, bool bool_33, Doctrine._WeaponControlStatus? nullable_41, bool bool_34, Doctrine._WeaponControlStatus? nullable_42, bool bool_35, Doctrine._GunStrafeGroundTargets? nullable_43, bool bool_36, Doctrine._IgnorePlottedCourseWhenAttacking? nullable_44, bool bool_37, Doctrine._BehaviorTowardsAmbigousTarget? nullable_45, bool bool_38, Doctrine._AutomaticEvasion? nullable_46, bool bool_39, Doctrine._MaintainStandoff? nullable_47, bool bool_40, Doctrine._UseRefuel? nullable_48, bool bool_41, Doctrine._RefuelSelection? nullable_49, bool bool_42, Doctrine._ShootTourists? nullable_50, bool bool_43, Doctrine._UseSAMsInASuWMode? nullable_51, bool bool_44, Doctrine._IgnoreEMCONUnderAttack? nullable_52, bool bool_45, Doctrine._QuickTurnAround? nullable_53, bool bool_46, Doctrine._AirOpsTempo? nullable_54, bool bool_47, Doctrine._WeaponState? nullable_55, bool bool_48, Doctrine._WeaponStateRTB? nullable_56, bool bool_49, Doctrine._FuelState? nullable_57, bool bool_50, Doctrine._FuelStateRTB? nullable_58, bool bool_51, Doctrine._JettisonOrdnance? nullable_59, bool bool_52, Doctrine._UseTorpedoesKinematicRange? nullable_60, bool bool_53, Doctrine._RefuelAlliedUnits? nullable_61, bool bool_54, Doctrine._AvoidContactWhenPossible? nullable_62, bool bool_55, Doctrine._DiveOnContact? nullable_63, bool bool_56, Doctrine._RechargeBatteryPercentage? nullable_64, bool bool_57, Doctrine._RechargeBatteryPercentage? nullable_65, bool bool_58, Doctrine._UseAIP? nullable_66, bool bool_59, Doctrine._UseDippingSonar? nullable_67, bool bool_60, Doctrine._DamageThreshold? nullable_68, bool bool_61, Doctrine._FuelQuantityThreshold? nullable_69, bool bool_62, Doctrine._WeaponQuantityThreshold? nullable_70, bool bool_63, Doctrine._WeaponQuantityThreshold? nullable_71, bool bool_64, Doctrine._DamageThreshold? nullable_72, bool bool_65, Doctrine._FuelQuantityThreshold? nullable_73, bool bool_66, Doctrine._WeaponQuantityThreshold? nullable_74, bool bool_67, Doctrine._WeaponQuantityThreshold? nullable_75, bool bool_68, Doctrine.EMCON_Settings.Enum36 enum36_0, Doctrine.EMCON_Settings.Enum36 enum36_1, Doctrine.EMCON_Settings.Enum36 enum36_2, bool bool_69)
		{
			try
			{
				this.subject = _subject;
				if (bool_31)
				{
					this.Nukes = null;
				}
				else
				{
					this.Nukes = nullable_38;
				}
				if (bool_32)
				{
					this.WCS_Air = null;
				}
				else
				{
					this.WCS_Air = nullable_39;
				}
				if (bool_33)
				{
					this.WCS_Surface = null;
				}
				else
				{
					this.WCS_Surface = nullable_40;
				}
				if (bool_34)
				{
					this.WCS_Submarine = null;
				}
				else
				{
					this.WCS_Submarine = nullable_41;
				}
				if (bool_35)
				{
					this.WCS_Land = null;
				}
				else
				{
					this.WCS_Land = nullable_42;
				}
				if (bool_36)
				{
					this.GunStrafeGroundTargets = null;
				}
				else
				{
					this.GunStrafeGroundTargets = nullable_43;
				}
				if (bool_37)
				{
					this.IgnorePlottedCourseWhenAttacking = null;
				}
				else
				{
					this.IgnorePlottedCourseWhenAttacking = nullable_44;
				}
				if (bool_38)
				{
					this.BehaviorTowardsAmbigousTarget = null;
				}
				else
				{
					this.BehaviorTowardsAmbigousTarget = nullable_45;
				}
				if (bool_39)
				{
					this.AutomaticEvasion = null;
				}
				else
				{
					this.AutomaticEvasion = nullable_46;
				}
				if (bool_40)
				{
					this.MaintainStandoff = null;
				}
				else
				{
					this.MaintainStandoff = nullable_47;
				}
				if (bool_41)
				{
					this.UseRefuel = null;
				}
				else
				{
					this.UseRefuel = nullable_48;
				}
				if (bool_42)
				{
					this.RefuelSelection = null;
				}
				else
				{
					this.RefuelSelection = nullable_49;
				}
				if (bool_43)
				{
					this.ShootTourists = null;
				}
				else
				{
					this.ShootTourists = nullable_50;
				}
				if (bool_44)
				{
					this.SAM_ASUW = null;
				}
				else
				{
					this.SAM_ASUW = nullable_51;
				}
				if (bool_45)
				{
					this.IgnoreEMCONUnderAttack = null;
				}
				else
				{
					this.IgnoreEMCONUnderAttack = nullable_52;
				}
				if (bool_46)
				{
					this.QuickTurnAround = null;
				}
				else
				{
					this.QuickTurnAround = nullable_53;
				}
				if (bool_47)
				{
					this.AirOpsTempo = null;
				}
				else
				{
					this.AirOpsTempo = nullable_54;
				}
				if (bool_48)
				{
					this.WinchesterShotgun = null;
				}
				else
				{
					this.WinchesterShotgun = nullable_55;
				}
				if (bool_49)
				{
					this.WinchesterShotgunRTB = null;
				}
				else
				{
					this.WinchesterShotgunRTB = nullable_56;
				}
				if (bool_50)
				{
					this.BingoJoker = null;
				}
				else
				{
					this.BingoJoker = nullable_57;
				}
				if (bool_51)
				{
					this.BingoJokerRTB = null;
				}
				else
				{
					this.BingoJokerRTB = nullable_58;
				}
				if (bool_52)
				{
					this.JettisonOrdnance = null;
				}
				else
				{
					this.JettisonOrdnance = nullable_59;
				}
				if (bool_53)
				{
					this.UseTorpedoesKinematicRange = null;
				}
				else
				{
					this.UseTorpedoesKinematicRange = nullable_60;
				}
				if (bool_54)
				{
					this.RefuelAllies = null;
				}
				else
				{
					this.RefuelAllies = nullable_61;
				}
				if (bool_55)
				{
					this.AvoidContact = null;
				}
				else
				{
					this.AvoidContact = nullable_62;
				}
				if (bool_56)
				{
					this.DiveWhenThreatsDetected = null;
				}
				else
				{
					this.DiveWhenThreatsDetected = nullable_63;
				}
				if (bool_57)
				{
					this.RechargePercentagePatrol = null;
				}
				else
				{
					this.RechargePercentagePatrol = nullable_64;
				}
				if (bool_58)
				{
					this.RechargePercentageAttack = null;
				}
				else
				{
					this.RechargePercentageAttack = nullable_65;
				}
				if (bool_59)
				{
					this.AIPUsage = null;
				}
				else
				{
					this.AIPUsage = nullable_66;
				}
				if (bool_60)
				{
					this.DippingSonar = null;
				}
				else
				{
					this.DippingSonar = nullable_67;
				}
				if (bool_61)
				{
					this.WithdrawDamageThreshold = null;
				}
				else
				{
					this.WithdrawDamageThreshold = nullable_68;
				}
				if (bool_62)
				{
					this.WithdrawFuelThreshold = null;
				}
				else
				{
					this.WithdrawFuelThreshold = nullable_69;
				}
				if (bool_63)
				{
					this.WithdrawAttackThreshold = null;
				}
				else
				{
					this.WithdrawAttackThreshold = nullable_70;
				}
				if (bool_64)
				{
					this.WithdrawDefenceThreshold = null;
				}
				else
				{
					this.WithdrawDefenceThreshold = nullable_71;
				}
				if (bool_65)
				{
					this.RedeployDamageThreshold = null;
				}
				else
				{
					this.RedeployDamageThreshold = nullable_72;
				}
				if (bool_66)
				{
					this.RedeployFuelThreshold = null;
				}
				else
				{
					this.RedeployFuelThreshold = nullable_73;
				}
				if (bool_67)
				{
					this.RedeployAttackThreshold = null;
				}
				else
				{
					this.RedeployAttackThreshold = nullable_74;
				}
				if (bool_68)
				{
					this.RedeployDefenceThreshold = null;
				}
				else
				{
					this.RedeployDefenceThreshold = nullable_75;
				}
				if (bool_69)
				{
					this.SetEMCON_Settings(bool_69);
				}
				else
				{
					this.SetEMCON_Settings(bool_69);
					this.SetEMCON_SettingsForSonar(enum36_0, scenario_0);
					this.SetEMCON_SettingsForRadar(enum36_1, scenario_0);
					this.method_173(enum36_2, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101306", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x0031B2BC File Offset: 0x003194BC
		public void method_1(Subject class137_1, bool? nullable_38, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(class137_1, nullable_38, bool_31, bool_32, bool_33, bool_34);
			}
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x0031B2E4 File Offset: 0x003194E4
		public void method_2(Subject class137_1, bool? nullable_38, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
			if (@delegate != null)
			{
				@delegate(class137_1, nullable_38, bool_31, bool_32, bool_33, bool_34);
			}
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x0031B30C File Offset: 0x0031950C
		public Doctrine GetDoctrine(Scenario scenario_0, ref bool bool_31)
		{
			checked
			{
				Doctrine doctrine;
				Doctrine result;
				try
				{
					if (Information.IsNothing(this.m_Doctrine))
					{
						try
						{
							if (!bool_31 && this.subject.IsActiveUnit())
							{
								ActiveUnit activeUnit = (ActiveUnit)this.subject;
								if (activeUnit.IsAircraft)
								{
									Aircraft aircraft = (Aircraft)activeUnit;
									if (!aircraft.IsOperating())
									{
										Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
										if (!Information.IsNothing(aircraftAirOps.GetCurrentHostUnit()))
										{
											doctrine = aircraftAirOps.GetCurrentHostUnit().m_Doctrine;
											result = doctrine;
											return result;
										}
									}
								}
								else if (!activeUnit.IsShip)
								{
								}
							}
							if (this.subject.IsGroup)
							{
								Group group = (Group)this.subject;
								if (!Information.IsNothing(group.GetAssignedMission(false)) && group.GetAssignedMission(false).IsActive())
								{
									if (!Information.IsNothing(group.GetGroupLead()) && group.GetGroupLead().GetAI().IsEscort)
									{
										if (group.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
										{
											this.m_Doctrine = ((Strike)group.GetAssignedMission(false)).Doctrine_Escorts;
										}
										else
										{
											this.m_Doctrine = group.GetAssignedMission(false).m_Doctrine;
										}
									}
									else
									{
										this.m_Doctrine = group.GetAssignedMission(false).m_Doctrine;
									}
								}
								else
								{
									this.m_Doctrine = group.GetSide(false).m_Doctrine;
								}
							}
							else if (this.subject.IsActiveUnit())
							{
								ActiveUnit activeUnit2 = (ActiveUnit)this.subject;
								if (activeUnit2.HasParentGroup())
								{
									this.m_Doctrine = activeUnit2.GetParentGroup(false).m_Doctrine;
								}
								else if (!Information.IsNothing(activeUnit2.GetAssignedMission(false)) && activeUnit2.GetAssignedMission(false).IsActive())
								{
									if (activeUnit2.GetAI().IsEscort && activeUnit2.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
									{
										this.m_Doctrine = ((Strike)activeUnit2.GetAssignedMission(false)).Doctrine_Escorts;
									}
									else
									{
										this.m_Doctrine = activeUnit2.GetAssignedMission(false).m_Doctrine;
									}
								}
								else
								{
									this.m_Doctrine = activeUnit2.GetSide(false).m_Doctrine;
								}
							}
							else if (this.subject.IsMission)
							{
								Mission value = (Mission)this.subject;
								Side[] sides = scenario_0.GetSides();
								for (int i = 0; i < sides.Length; i++)
								{
									Side side = sides[i];
									if (side.GetPatrolMissionCollection(scenario_0).Contains(value))
									{
										this.m_Doctrine = side.m_Doctrine;
										break;
									}
								}
							}
							else if (this.subject.IsWayPoint)
							{
								Waypoint waypoint = (Waypoint)this.subject;
								bool flag = false;
								if (waypoint.Category == Waypoint._Category.const_0)
								{
									using (List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator())
									{
										while (enumerator.MoveNext())
										{
											ActiveUnit current = enumerator.Current;
											if (current.GetNavigator().HasPlottedCourse() && current.GetNavigator().GetPlottedCourse().Contains(waypoint))
											{
												this.m_Doctrine = current.m_Doctrine;
												break;
											}
										}
										goto IL_457;
									}
								}
								Side[] sides2 = scenario_0.GetSides();
								for (int j = 0; j < sides2.Length; j++)
								{
									Side side2 = sides2[j];
									foreach (Mission current2 in side2.GetMissionCollection())
									{
										if (current2.HasFlightCourse())
										{
											using (List<Mission.Flight>.Enumerator enumerator3 = current2.FlightList.GetEnumerator())
											{
												while (enumerator3.MoveNext())
												{
													if (enumerator3.Current.GetFlightCourse().Contains(waypoint))
													{
														this.m_Doctrine = current2.m_Doctrine;
														flag = true;
														break;
													}
												}
											}
										}
										if (flag)
										{
											break;
										}
									}
									if (flag)
									{
										break;
									}
								}
							}
							else if (this.subject.GetType() == typeof(Side))
							{
								this.m_Doctrine = ((Side)this.subject).m_Doctrine;
							}
							IL_457:
							if (!Information.IsNothing(this.m_ActiveUnits) && Information.IsNothing(this.m_Doctrine))
							{
								Side currentSide = scenario_0.GetCurrentSide();
								if (!Information.IsNothing(currentSide))
								{
									doctrine = currentSide.m_Doctrine;
									result = doctrine;
									return result;
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 101171", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
					doctrine = this.m_Doctrine;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 101001", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					doctrine = scenario_0.GetCurrentSide().m_Doctrine;
					ProjectData.ClearProjectError();
				}
				result = doctrine;
				return result;
			}
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x0002BF44 File Offset: 0x0002A144
		public void Init()
		{
			this.m_Doctrine = null;
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x0031B8CC File Offset: 0x00319ACC
		public List<ActiveUnit> GetDoctrineActiveUnit(Scenario scenario_0, bool? nullable_38)
		{
			List<ActiveUnit> list = null;
			List<ActiveUnit> result;
			try
			{
				List<ActiveUnit> list2 = new List<ActiveUnit>();
				if (this.subject.GetType() == typeof(Side))
				{
					list2.AddRange(((Side)this.subject).ActiveUnitArray);
				}
				else
				{
					if (this.subject.GetType() == typeof(Waypoint))
					{
						list = new List<ActiveUnit>();
						result = list;
						return result;
					}
					if (this.subject.IsMission)
					{
						using (List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ActiveUnit current = enumerator.Current;
								if (current.GetAssignedMission(false) == this.subject)
								{
									if (Information.IsNothing(nullable_38))
									{
										list2.Add(current);
									}
									bool? flag2;
									bool? flag = flag2 = nullable_38;
									if (((!flag.HasValue || flag2.GetValueOrDefault()) ? (flag2 & current.GetAI().IsEscort) : new bool?(false)).GetValueOrDefault())
									{
										list2.Add(current);
									}
									flag = (flag2 = (nullable_38.HasValue ? new bool?(!nullable_38.GetValueOrDefault()) : nullable_38));
									if (((!flag.HasValue || flag2.GetValueOrDefault()) ? (flag2 & !current.GetAI().IsEscort) : new bool?(false)).GetValueOrDefault())
									{
										list2.Add(current);
									}
								}
							}
							goto IL_1E2;
						}
					}
					if (this.subject.IsGroup)
					{
						list2.AddRange(((Group)this.subject).GetUnitsInGroup().Values);
					}
					else
					{
						list2.Add((ActiveUnit)this.subject);
					}
				}
				IL_1E2:
				list = list2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101002", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list = new List<ActiveUnit>();
				ProjectData.ClearProjectError();
			}
			result = list;
			return result;
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x0031BB3C File Offset: 0x00319D3C
		public Doctrine.EMCON_Settings GetEMCON_Settings(Scenario scenario_0)
		{
			Doctrine.EMCON_Settings eMCON_Settings;
			if (this.EMCON_SettingsHasNoValue())
			{
				bool flag = true;
				eMCON_Settings = this.GetDoctrine(scenario_0, ref flag).GetEMCON_Settings(scenario_0);
			}
			else
			{
				eMCON_Settings = this.m_EMCON_Settings;
			}
			return eMCON_Settings;
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x0002BF4D File Offset: 0x0002A14D
		public bool EMCON_SettingsHasNoValue()
		{
			return Information.IsNothing(this.m_EMCON_Settings);
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x0002BF5A File Offset: 0x0002A15A
		public void SetEMCON_Settings(bool bool_31)
		{
			if (!bool_31)
			{
				if (Information.IsNothing(this.m_EMCON_Settings))
				{
					this.m_EMCON_Settings = new Doctrine.EMCON_Settings();
				}
			}
			else
			{
				this.m_EMCON_Settings = null;
			}
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x0031BB74 File Offset: 0x00319D74
		public int? GetWeaponQty(Scenario theScen, Weapon theWeapon, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheritedWeaponQty, ref int? TargetType_UnspecifiedWeaponQty)
		{
			int? result = null;
			if (this.subject.GetType() != typeof(Side) && theWeapon.DBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheritedWeaponQty = this.GetDoctrine(theScen, ref flag).GetQtyByWeapon(theScen, theWeapon, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheritedWeaponQty = this.GetQtyByWeapon(theScen, theWeapon, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheritedWeaponQty) && !this.method_32(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref selectedNodeTargetType);
					TargetType_UnspecifiedWeaponQty = this.GetQtyByWeapon(theScen, theWeapon, wRA_WeaponTargetType_);
					result = TargetType_UnspecifiedWeaponQty;
				}
				else
				{
					result = TargetType_InheritedWeaponQty;
				}
			}
			return result;
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x0031BC38 File Offset: 0x00319E38
		public int? GetQtyByWeapon(Scenario scenario_0, Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.GetQtyByWeaponIDExt(weapon_0.DBID, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.subject.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.GetDoctrine(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.GetQtyByWeapon(scenario_0, weapon_0, _WRA_WeaponTargetType_0);
				}
			}
			int? result = null;
			if (Information.IsNothing(num))
			{
				result = this.GetQtyByWeaponType(weapon_0, _WRA_WeaponTargetType_0);
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x0031BCCC File Offset: 0x00319ECC
		public int? GetQtyByWeaponType(Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (!Information.IsNothing(weapon_0.m_Doctrine.GetWRA_WeaponDictionary()))
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (_WRA_WeaponTargetType_0 == wRA_WeaponTarget.WRA_WeaponTargetType)
							{
								num = wRA_WeaponTarget.WeaponQty;
								result = num;
								return result;
							}
						}
					}
				}
				result = null;
				return result;
			}
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x0031BD88 File Offset: 0x00319F88
		public int? GetQtyByWeaponIDExt(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.GetQtyByWeaponID(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x0031BDA0 File Offset: 0x00319FA0
		private int? GetQtyByWeaponID(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (Information.IsNothing(this.WRA_WeaponDictionary))
				{
					num = null;
				}
				else if (!this.WRA_WeaponDictionary.ContainsKey(int_0))
				{
					num = null;
				}
				else
				{
					Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
					this.WRA_WeaponDictionary.TryGetValue(int_0, out wRA_Weapon);
					if (!Information.IsNothing(wRA_Weapon))
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
							{
								num = wRA_WeaponTarget.WeaponQty;
								result = num;
								return result;
							}
						}
					}
					num = null;
				}
				result = num;
				return result;
			}
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x0031BE4C File Offset: 0x0031A04C
		public int? GetShooterQty(Scenario theScen, Weapon theWeapon, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheritedShooterQty, ref int? TargetType_UnspecifiedShooterQty)
		{
			int? result = null;
			if (this.subject.GetType() != typeof(Side) && theWeapon.DBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheritedShooterQty = this.GetDoctrine(theScen, ref flag).GetInheritedShooterQty(theScen, theWeapon, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheritedShooterQty = this.GetInheritedShooterQty(theScen, theWeapon, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheritedShooterQty) && !this.method_32(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref selectedNodeTargetType);
					TargetType_UnspecifiedShooterQty = this.GetInheritedShooterQty(theScen, theWeapon, wRA_WeaponTargetType_);
					result = TargetType_UnspecifiedShooterQty;
				}
				else
				{
					result = TargetType_InheritedShooterQty;
				}
			}
			return result;
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x0031BF10 File Offset: 0x0031A110
		public int? GetInheritedShooterQty(Scenario scenario_0, Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.GetShooterQtydByExt(weapon_0.DBID, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.subject.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.GetDoctrine(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.GetInheritedShooterQty(scenario_0, weapon_0, _WRA_WeaponTargetType_0);
				}
			}
			int? result = null;
			if (Information.IsNothing(num))
			{
				result = this.GetWeaponTargetShooterQty(weapon_0, _WRA_WeaponTargetType_0);
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x0031BFA4 File Offset: 0x0031A1A4
		public int? GetWeaponTargetShooterQty(Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (!Information.IsNothing(weapon_0.m_Doctrine.GetWRA_WeaponDictionary()))
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (_WRA_WeaponTargetType_0 == wRA_WeaponTarget.WRA_WeaponTargetType)
							{
								num = wRA_WeaponTarget.ShooterQty;
								result = num;
								return result;
							}
						}
					}
				}
				result = null;
				return result;
			}
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x0031C060 File Offset: 0x0031A260
		public int? GetShooterQtydByExt(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.GetShooterQtydBy(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x0031C078 File Offset: 0x0031A278
		private int? GetShooterQtydBy(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (Information.IsNothing(this.WRA_WeaponDictionary))
				{
					num = null;
				}
				else if (!this.WRA_WeaponDictionary.ContainsKey(int_0))
				{
					num = null;
				}
				else
				{
					Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
					this.WRA_WeaponDictionary.TryGetValue(int_0, out wRA_Weapon);
					if (!Information.IsNothing(wRA_Weapon))
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
							{
								num = wRA_WeaponTarget.ShooterQty;
								result = num;
								return result;
							}
						}
					}
					num = null;
				}
				result = num;
				return result;
			}
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x0031C124 File Offset: 0x0031A324
		public int? method_19(Scenario theScen, Weapon theWeapon, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheriteSelfDefenceRange, ref int? TargetType_UnspecifiedSelfDefenceRange)
		{
			int? result = null;
			if (this.subject.GetType() != typeof(Side) && theWeapon.DBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheriteSelfDefenceRange = this.GetDoctrine(theScen, ref flag).method_20(theScen, theWeapon, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheriteSelfDefenceRange = this.method_20(theScen, theWeapon, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheriteSelfDefenceRange) && !this.method_32(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref selectedNodeTargetType);
					TargetType_UnspecifiedSelfDefenceRange = this.method_20(theScen, theWeapon, wRA_WeaponTargetType_);
					result = TargetType_UnspecifiedSelfDefenceRange;
				}
				else
				{
					result = TargetType_InheriteSelfDefenceRange;
				}
			}
			return result;
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x0031C1E8 File Offset: 0x0031A3E8
		public int? method_20(Scenario scenario_0, Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.method_22(weapon_0.DBID, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.subject.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.GetDoctrine(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.method_20(scenario_0, weapon_0, _WRA_WeaponTargetType_0);
				}
			}
			int? result = null;
			if (Information.IsNothing(num))
			{
				result = this.method_21(weapon_0, _WRA_WeaponTargetType_0);
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x0031C27C File Offset: 0x0031A47C
		public int? method_21(Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (!Information.IsNothing(weapon_0.m_Doctrine.GetWRA_WeaponDictionary()))
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (_WRA_WeaponTargetType_0 == wRA_WeaponTarget.WRA_WeaponTargetType)
							{
								num = wRA_WeaponTarget.SelfDefenceRange;
								result = num;
								return result;
							}
						}
					}
				}
				result = null;
				return result;
			}
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x0031C338 File Offset: 0x0031A538
		public int? method_22(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.method_23(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x0031C350 File Offset: 0x0031A550
		private int? method_23(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (Information.IsNothing(this.WRA_WeaponDictionary))
				{
					num = null;
				}
				else if (!this.WRA_WeaponDictionary.ContainsKey(int_0))
				{
					num = null;
				}
				else
				{
					Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
					this.WRA_WeaponDictionary.TryGetValue(int_0, out wRA_Weapon);
					if (!Information.IsNothing(wRA_Weapon))
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
							{
								num = wRA_WeaponTarget.SelfDefenceRange;
								result = num;
								return result;
							}
						}
					}
					num = null;
				}
				result = num;
				return result;
			}
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x0031C3FC File Offset: 0x0031A5FC
		public int? GetFiringRange(Scenario theScen, int theWeaponDBID, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheritedFiringRange, ref int? TargetType_UnspecifiedFiringRange)
		{
			int? result = null;
			if (this.subject.GetType() != typeof(Side) && theWeaponDBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheritedFiringRange = this.GetDoctrine(theScen, ref flag).method_25(theScen, theWeaponDBID, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheritedFiringRange = this.method_25(theScen, theWeaponDBID, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheritedFiringRange) && !this.method_32(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref selectedNodeTargetType);
					TargetType_UnspecifiedFiringRange = this.method_25(theScen, theWeaponDBID, wRA_WeaponTargetType_);
					result = TargetType_UnspecifiedFiringRange;
				}
				else
				{
					result = TargetType_InheritedFiringRange;
				}
			}
			return result;
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x0031C4BC File Offset: 0x0031A6BC
		public int? method_25(Scenario scenario_0, int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.GetFiringRangeByExt(int_0, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.subject.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.GetDoctrine(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.method_25(scenario_0, int_0, _WRA_WeaponTargetType_0);
				}
			}
			return num;
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x0031C524 File Offset: 0x0031A724
		public int? GetFiringRangeByExt(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.GetFiringRangeBy(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0031C53C File Offset: 0x0031A73C
		private int? GetFiringRangeBy(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = null;
			checked
			{
				int? result;
				if (Information.IsNothing(this.WRA_WeaponDictionary))
				{
					num = null;
				}
				else if (!this.WRA_WeaponDictionary.ContainsKey(int_0))
				{
					num = null;
				}
				else
				{
					Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
					this.WRA_WeaponDictionary.TryGetValue(int_0, out wRA_Weapon);
					if (!Information.IsNothing(wRA_Weapon))
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
							{
								num = wRA_WeaponTarget.FiringRange;
								result = num;
								return result;
							}
						}
					}
					num = null;
				}
				result = num;
				return result;
			}
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x0031C5E8 File Offset: 0x0031A7E8
		public Dictionary<int, Doctrine.WRA_Weapon> GetWRA_WeaponDictionary()
		{
			return this.WRA_WeaponDictionary;
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x0002BF83 File Offset: 0x0002A183
		public void SetWRA_WeaponDictionary(Dictionary<int, Doctrine.WRA_Weapon> dictionary_1)
		{
			this.WRA_WeaponDictionary = dictionary_1;
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x0031C600 File Offset: 0x0031A800
		public Doctrine._WRA_WeaponTargetType GetWRA_WeaponTargetType(ref Weapon weapon_0, ref Doctrine doctrine_1, ref Contact contact_0, ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType;
			Doctrine._WRA_WeaponTargetType result;
			if (weapon_0.weaponTarget.IsRadar)
			{
				wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.Radar_Unspecified;
			}
			else if (weapon_0.weaponTarget.IsSubsurface && _WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
			{
				wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.Submarine_Unspecified;
			}
			else if (weapon_0.weaponTarget.IsTorpedoe && contact_0.contactType == Contact_Base.ContactType.Torpedo)
			{
				wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type;
			}
			else
			{
				if (contact_0.contactType == Contact_Base.ContactType.Decoy_Air && contact_0.GetEmissionContainerObDictionary().Count > 0)
				{
					foreach (KeyValuePair<int, EmissionContainer> current in contact_0.GetEmissionContainerObDictionary())
					{
						if (current.Value.method_0(current.Key, weapon_0.m_Scenario).IsJammer())
						{
							result = Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
							return result;
						}
					}
				}
				wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
			}
			result = wRA_WeaponTargetType;
			return result;
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x0031C71C File Offset: 0x0031A91C
		public Doctrine._WRA_WeaponTargetType GetWRA_WeaponTargetType(ref Contact target_)
		{
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType;
			Doctrine._WRA_WeaponTargetType result;
			if (target_.GetIdentificationStatus() == Contact_Base.IdentificationStatus.Unknown)
			{
				wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.None;
			}
			else
			{
				if (target_.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
				{
					if (!Information.IsNothing(target_.ActualUnit))
					{
						ActiveUnit actualUnit = target_.ActualUnit;
						switch (target_.contactType)
						{
						case Contact_Base.ContactType.Air:
						{
							if (actualUnit.IsWeapon && ((Weapon)actualUnit).IsDecoy())
							{
								result = Doctrine._WRA_WeaponTargetType.Decoy;
								return result;
							}
							Aircraft aircraft = (Aircraft)actualUnit;
							if (aircraft.IsRotaryWingAircraft())
							{
								result = Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified;
								return result;
							}
							Aircraft._AircraftType type = aircraft.Type;
							if (type <= Aircraft._AircraftType.Bomber)
							{
								if (type - Aircraft._AircraftType.Fighter > 1 && type - Aircraft._AircraftType.Attack > 1)
								{
									if (type != Aircraft._AircraftType.Bomber)
									{
										goto IL_27E;
									}
									if ((double)aircraft.Agility >= 2.0)
									{
										result = Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers;
										return result;
									}
									if ((double)aircraft.Agility >= 1.5)
									{
										result = Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Bombers;
										return result;
									}
									if ((double)aircraft.Agility >= 1.0)
									{
										result = Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers;
										return result;
									}
									goto IL_D2C;
								}
							}
							else
							{
								if (type <= Aircraft._AircraftType.OECM)
								{
									if (type == Aircraft._AircraftType.CAS)
									{
										goto IL_1A8;
									}
									if (type != Aircraft._AircraftType.OECM)
									{
										goto IL_27E;
									}
								}
								else
								{
									if (type - Aircraft._AircraftType.AEW <= 1)
									{
										result = Doctrine._WRA_WeaponTargetType.Aircraft_AEW;
										return result;
									}
									if (type - Aircraft._AircraftType.Recon > 2)
									{
										goto IL_27E;
									}
								}
								if ((double)aircraft.Agility >= 4.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW;
									return result;
								}
								if ((double)aircraft.Agility >= 3.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Recon_EW;
									return result;
								}
								if ((double)aircraft.Agility >= 2.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW;
									return result;
								}
								goto IL_D2C;
							}
							IL_1A8:
							if ((double)aircraft.Agility >= 5.0)
							{
								result = Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation;
								return result;
							}
							if ((double)aircraft.Agility >= 4.0)
							{
								result = Doctrine._WRA_WeaponTargetType.Aircraft_4th_Generation;
								return result;
							}
							if ((double)aircraft.Agility >= 3.0)
							{
								result = Doctrine._WRA_WeaponTargetType.Aircraft_3rd_Generation;
								return result;
							}
							if ((double)aircraft.Agility >= 2.0)
							{
								result = Doctrine._WRA_WeaponTargetType.Aircraft_Less_Capable;
								return result;
							}
							goto IL_D2C;
							IL_27E:
							result = Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
							return result;
						}
						case Contact_Base.ContactType.Missile:
							if (((Weapon)actualUnit).weaponCode.BallisticMissile)
							{
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic;
								return result;
							}
							if (!target_.Speed_Known)
							{
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified;
								return result;
							}
							if (target_.GetCurrentSpeed() > 600f)
							{
								if (target_.Altitude_Known && target_.GetCurrentAltitude_ASL(false) <= 30.48f)
								{
									result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming;
									return result;
								}
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic;
								return result;
							}
							else
							{
								if (target_.Altitude_Known && target_.GetCurrentAltitude_ASL(false) <= 30.48f)
								{
									result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming;
									return result;
								}
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic;
								return result;
							}
							break;
						case Contact_Base.ContactType.Surface:
						{
							Ship ship = (Ship)actualUnit;
							switch (ship.Category)
							{
							case Ship._ShipCategory.SurfaceCombatant:
							case Ship._ShipCategory.MobileOffshoreBase_AviationCapable:
								if (ship.DisplacementStandard >= 95001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 45001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Carrier_45001_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 25001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Carrier_25001_45000_tons;
									return result;
								}
								result = Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons;
								return result;
							case Ship._ShipCategory.Carrier:
							case Ship._ShipCategory.SurfaceCombatant_AviationCapable:
								if (ship.DisplacementStandard >= 95001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 45001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_45001_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 25001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_25001_45000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 10001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_10001_25000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 5001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_5001_10000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 1501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 501.0)
								{
									Ship._ShipType type2 = ship.Type;
									if (type2 - Ship._ShipType.DE > 2 && type2 - Ship._ShipType.F > 3)
									{
										result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons;
										return result;
									}
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons;
									return result;
								}
								else
								{
									if (ship.DisplacementStandard < 0.0)
									{
										goto IL_D2C;
									}
									Ship._ShipType type3 = ship.Type;
									if (type3 <= Ship._ShipType.PGM)
									{
										if (type3 != Ship._ShipType.PCFG && type3 != Ship._ShipType.PGM)
										{
											goto IL_954;
										}
									}
									else if (type3 != Ship._ShipType.PHM && type3 != Ship._ShipType.MTB)
									{
										goto IL_954;
									}
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons;
									return result;
									IL_954:
									bool flag = false;
									foreach (Weapon current in ship.GetShipWeaponry().GetWeaponsDictionary(false).Values)
									{
										if (current.IsGuidedWeapon_RV_HGV() && (current.TargetIsShipOrRadar() || current.TargetIsLandFacility()))
										{
											flag = true;
											break;
										}
									}
									if (flag)
									{
										result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons;
										return result;
									}
									result = Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons;
									return result;
								}
								break;
							case Ship._ShipCategory.Amphibious:
								if (ship.DisplacementStandard >= 95001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 45001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_45001_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 25001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_25001_45000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 10001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_10001_25000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 5001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_5001_10000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 1501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_1501_5000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_501_1500_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 0.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons;
									return result;
								}
								goto IL_D2C;
							case Ship._ShipCategory.Auxiliary:
								if (ship.DisplacementStandard >= 95001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 45001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_45001_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 25001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_25001_45000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 10001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_10001_25000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 5001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_5001_10000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 1501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_1501_5000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_501_1500_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 0.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons;
									return result;
								}
								goto IL_D2C;
							case Ship._ShipCategory.Merchant:
							case Ship._ShipCategory.Civilian:
								if (ship.DisplacementStandard >= 95001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 45001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_45001_95000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 25001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_25001_45000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 10001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_10001_25000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 5001.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_5001_10000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 1501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_1501_5000_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 501.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_501_1500_tons;
									return result;
								}
								if (ship.DisplacementStandard >= 0.0)
								{
									result = Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons;
									return result;
								}
								goto IL_D2C;
							default:
								result = Doctrine._WRA_WeaponTargetType.Ship_Unspecified;
								return result;
							}
							break;
						}
						case Contact_Base.ContactType.Submarine:
							if (((Submarine)actualUnit).IsShallowerThanPeriscopeDepth())
							{
								result = Doctrine._WRA_WeaponTargetType.Submarine_Surfaced;
								return result;
							}
							result = Doctrine._WRA_WeaponTargetType.Submarine_Unspecified;
							return result;
						case Contact_Base.ContactType.Orbital:
							result = Doctrine._WRA_WeaponTargetType.Satellite_Unspecified;
							return result;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
						{
							Facility facility = (Facility)actualUnit;
							Facility._FacilityCategory category = facility.Category;
							if (category <= Facility._FacilityCategory.Underwater)
							{
								switch (category)
								{
								case Facility._FacilityCategory.Runway:
									result = Doctrine._WRA_WeaponTargetType.Runway;
									return result;
								case Facility._FacilityCategory.RunwayGrade_Taxiway:
									result = Doctrine._WRA_WeaponTargetType.Runway_Grade_Taxiway;
									return result;
								case Facility._FacilityCategory.RunwayAccessPoint:
									result = Doctrine._WRA_WeaponTargetType.Runway_Access_Point;
									return result;
								default:
									switch (category)
									{
									case Facility._FacilityCategory.Building_Surface:
										if (facility.ArmorGeneral >= GlobalVariables.ArmorRating.Light)
										{
											result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface;
											return result;
										}
										result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface;
										return result;
									case Facility._FacilityCategory.Building_Reveted:
										if (facility.ArmorGeneral >= GlobalVariables.ArmorRating.Light)
										{
											result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Reveted;
											return result;
										}
										result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted;
										return result;
									case Facility._FacilityCategory.Building_Bunker:
										result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Bunker;
										return result;
									case Facility._FacilityCategory.Building_Underground:
										result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Underground;
										return result;
									case Facility._FacilityCategory.Structure_Open:
										if (facility.ArmorGeneral >= GlobalVariables.ArmorRating.Light)
										{
											result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Open;
											return result;
										}
										result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open;
										return result;
									case Facility._FacilityCategory.Structure_Reveted:
										if (facility.ArmorGeneral >= GlobalVariables.ArmorRating.Light)
										{
											result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted;
											return result;
										}
										result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted;
										return result;
									default:
										if (category == Facility._FacilityCategory.Underwater)
										{
											result = Doctrine._WRA_WeaponTargetType.Underwater_Structure;
											return result;
										}
										break;
									}
									break;
								}
							}
							else if (category <= Facility._FacilityCategory.Mobile_Personnel)
							{
								if (category == Facility._FacilityCategory.Mobile_Vehicle)
								{
									result = Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle;
									return result;
								}
								if (category == Facility._FacilityCategory.Mobile_Personnel)
								{
									result = Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel;
									return result;
								}
							}
							else
							{
								if (category == Facility._FacilityCategory.AerostatMooring)
								{
									result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified;
									return result;
								}
								if (category == Facility._FacilityCategory.AirBase)
								{
									result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified;
									return result;
								}
							}
							if (facility.ArmorGeneral >= GlobalVariables.ArmorRating.Light)
							{
								result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified;
								return result;
							}
							result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified;
							return result;
						}
						case Contact_Base.ContactType.Torpedo:
							goto IL_D2C;
						}
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
					result = Doctrine._WRA_WeaponTargetType.None;
					return result;
				}
				IL_D2C:
				if (target_.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownDomain)
				{
					if (!Information.IsNothing(target_.ActualUnit))
					{
						ActiveUnit actualUnit2 = target_.ActualUnit;
						switch (target_.contactType)
						{
						case Contact_Base.ContactType.Air:
							result = Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type;
							return result;
						case Contact_Base.ContactType.Missile:
							if (((Weapon)actualUnit2).weaponCode.BallisticMissile)
							{
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic;
								return result;
							}
							if (!target_.Speed_Known)
							{
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified;
								return result;
							}
							if (target_.GetCurrentSpeed() > 600f)
							{
								if (target_.Altitude_Known && target_.GetCurrentAltitude_ASL(false) <= 30.48f)
								{
									result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming;
									return result;
								}
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic;
								return result;
							}
							else
							{
								if (target_.Altitude_Known && target_.GetCurrentAltitude_ASL(false) <= 30.48f)
								{
									result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming;
									return result;
								}
								result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic;
								return result;
							}
							break;
						case Contact_Base.ContactType.Surface:
							result = Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type;
							return result;
						case Contact_Base.ContactType.Submarine:
							if (((Submarine)actualUnit2).IsShallowerThanPeriscopeDepth())
							{
								result = Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type;
								return result;
							}
							result = Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type;
							return result;
						case Contact_Base.ContactType.Orbital:
							result = Doctrine._WRA_WeaponTargetType.Satellite_Unspecified;
							return result;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							result = Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type;
							return result;
						case Contact_Base.ContactType.Torpedo:
							goto IL_F08;
						case Contact_Base.ContactType.Decoy_Air:
						case Contact_Base.ContactType.Decoy_Surface:
						case Contact_Base.ContactType.Decoy_Land:
						case Contact_Base.ContactType.Decoy_Sub:
							result = Doctrine._WRA_WeaponTargetType.Decoy;
							return result;
						}
						throw new NotImplementedException();
					}
					result = Doctrine._WRA_WeaponTargetType.None;
					return result;
				}
				IL_F08:
				wRA_WeaponTargetType = Doctrine._WRA_WeaponTargetType.None;
			}
			result = wRA_WeaponTargetType;
			return result;
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x0031D64C File Offset: 0x0031B84C
		public bool method_32(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
			bool result;
			if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified)
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified)
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type <= 1)
					{
						result = true;
						return result;
					}
					if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						result = true;
						return result;
					}
					if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified)
					{
						result = true;
						return result;
					}
				}
				else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Unspecified)
				{
					if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type <= 1)
					{
						result = true;
						return result;
					}
				}
				else
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type <= 1)
					{
						result = true;
						return result;
					}
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type <= 1)
					{
						result = true;
						return result;
					}
				}
			}
			else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
			{
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified)
				{
					result = true;
					return result;
				}
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified)
				{
					result = true;
					return result;
				}
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
				{
					result = true;
					return result;
				}
			}
			else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
			{
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified)
				{
					result = true;
					return result;
				}
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
				{
					result = true;
					return result;
				}
			}
			else
			{
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Underwater_Structure)
				{
					result = true;
					return result;
				}
				if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x0031D794 File Offset: 0x0031B994
		public Doctrine._WRA_WeaponTargetType GetWRA_WeaponTargetType(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
			Doctrine._WRA_WeaponTargetType result;
			if (wRA_WeaponTargetType > Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7)
						{
							result = Doctrine._WRA_WeaponTargetType.None;
							return result;
						}
						result = Doctrine._WRA_WeaponTargetType.Ship_Unspecified;
						return result;
					}
					else
					{
						if (wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							result = Doctrine._WRA_WeaponTargetType.Ship_Unspecified;
							return result;
						}
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface > 1 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open > 1)
						{
							result = Doctrine._WRA_WeaponTargetType.None;
							return result;
						}
					}
				}
				else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
				{
					if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface <= 5)
						{
							result = Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified;
							return result;
						}
						result = Doctrine._WRA_WeaponTargetType.None;
						return result;
					}
				}
				else
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway <= 2)
					{
						result = Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified;
						return result;
					}
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle <= 1)
					{
						result = Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified;
						return result;
					}
					if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle)
					{
						result = Doctrine._WRA_WeaponTargetType.None;
						return result;
					}
					result = Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified;
					return result;
				}
				result = Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified;
			}
			else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_AEW)
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation > 3 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
					{
						result = Doctrine._WRA_WeaponTargetType.None;
						return result;
					}
				}
				else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW)
				{
					result = Doctrine._WRA_WeaponTargetType.None;
					return result;
				}
				result = Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
			}
			else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
			{
				if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
				{
					result = Doctrine._WRA_WeaponTargetType.None;
				}
				else
				{
					result = Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified;
				}
			}
			else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons > 3 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
			{
				result = Doctrine._WRA_WeaponTargetType.None;
			}
			else
			{
				result = Doctrine._WRA_WeaponTargetType.Ship_Unspecified;
			}
			return result;
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x0031D990 File Offset: 0x0031BB90
		public Doctrine._UseNuclear? GetUseNuclearDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._UseNuclear? result = null;
			try
			{
				if (this.UseNukesHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetUseNuclearDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._UseNuclear?(this.Nukes.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200447", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_0);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x0031DA48 File Offset: 0x0031BC48
		public void method_35(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._UseNuclear? nullable_38)
		{
			this.Nukes = nullable_38;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x0002BF8C File Offset: 0x0002A18C
		public bool UseNukesHasNoValue()
		{
			return !this.Nukes.HasValue;
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x0031DA80 File Offset: 0x0031BC80
		public bool IsNukes_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.Nukes_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).IsNukes_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x0031DACC File Offset: 0x0031BCCC
		public void SetUseNukes_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.Nukes_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetUseNukes_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x0031DB14 File Offset: 0x0031BD14
		public void method_39(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseNuclear? UseNuclearDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "授权 -使用核武器";
			string text2 = "不授权 - 禁止使用核武器";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(UseNuclearDoc_))
				{
					b = (UseNuclearDoc_.HasValue ? new byte?((byte)UseNuclearDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (UseNuclearDoc_.HasValue ? new byte?((byte)UseNuclearDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseNuclear? useNuclearDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseNuclearDoctrine(scenario_0, false, false, false);
					b = (useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._UseNuclear? useNuclearDoctrine2 = this.GetUseNuclearDoctrine(scenario_0, false, false, false);
				b = (useNuclearDoctrine2.HasValue ? new byte?((byte)useNuclearDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x0031DEC8 File Offset: 0x0031C0C8
		public void method_40(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponControlStatus? WeaponControlStatusDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "自由开火 - 只要不是友方目标就开火";
			string text2 = "谨慎开火 - 只有查证为敌方目标才能开火";
			string text3 = "限制开火 - 只有在自卫情况下才能开火(只能手动开火)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(WeaponControlStatusDoc_))
				{
					b = (WeaponControlStatusDoc_.HasValue ? new byte?((byte)WeaponControlStatusDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (WeaponControlStatusDoc_.HasValue ? new byte?((byte)WeaponControlStatusDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (WeaponControlStatusDoc_.HasValue ? new byte?((byte)WeaponControlStatusDoc_.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponControlStatus? wCS_AirDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWCS_AirDoctrine(scenario_0, false, null, false, false);
					b = (wCS_AirDoctrine.HasValue ? new byte?((byte)wCS_AirDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (wCS_AirDoctrine.HasValue ? new byte?((byte)wCS_AirDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._WeaponControlStatus? wCS_AirDoctrine2 = this.GetWCS_AirDoctrine(scenario_0, false, new bool?(false), false, false);
				b = (wCS_AirDoctrine2.HasValue ? new byte?((byte)wCS_AirDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x0031E3C4 File Offset: 0x0031C5C4
		public void method_41(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "自由开火 - 只要不是友方目标就开火";
			string text2 = "谨慎开火 - 只有查证为敌方目标才能开火";
			string text3 = "限制开火 - 只有在自卫情况下才能开火(只能手动开火)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponControlStatus? wCS_SurfaceDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWCS_SurfaceDoctrine(scenario_0, false, null, false, false);
					b = (wCS_SurfaceDoctrine.HasValue ? new byte?((byte)wCS_SurfaceDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (wCS_SurfaceDoctrine.HasValue ? new byte?((byte)wCS_SurfaceDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._WeaponControlStatus? wCS_SurfaceDoctrine2 = this.GetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), false, false);
				b = (wCS_SurfaceDoctrine2.HasValue ? new byte?((byte)wCS_SurfaceDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x0031E8C0 File Offset: 0x0031CAC0
		public void method_42(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "自由开火 - 只要不是友方目标就开火";
			string text2 = "谨慎开火 - 只有查证为敌方目标才能开火";
			string text3 = "限制开火 - 只有在自卫情况下才能开火(只能手动开火)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponControlStatus? wCS_SubmarineDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWCS_SubmarineDoctrine(scenario_0, false, null, false, false);
					b = (wCS_SubmarineDoctrine.HasValue ? new byte?((byte)wCS_SubmarineDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (wCS_SubmarineDoctrine.HasValue ? new byte?((byte)wCS_SubmarineDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._WeaponControlStatus? wCS_SubmarineDoctrine2 = this.GetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false);
				b = (wCS_SubmarineDoctrine2.HasValue ? new byte?((byte)wCS_SubmarineDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x0031EDBC File Offset: 0x0031CFBC
		public void method_43(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "自由开火 - 只要不是友方目标就开火";
			string text2 = "谨慎开火 - 只有查证为敌方目标才能开火";
			string text3 = "限制开火 - 只有在自卫情况下才能开火(只能手动开火)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponControlStatus? wCS_LandDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWCS_LandDoctrine(scenario_0, false, null, false, false);
					b = (wCS_LandDoctrine.HasValue ? new byte?((byte)wCS_LandDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (wCS_LandDoctrine.HasValue ? new byte?((byte)wCS_LandDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._WeaponControlStatus? wCS_LandDoctrine2 = this.GetWCS_LandDoctrine(scenario_0, false, new bool?(false), false, false);
				b = (wCS_LandDoctrine2.HasValue ? new byte?((byte)wCS_LandDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x0031F2B8 File Offset: 0x0031D4B8
		public void method_44(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._IgnorePlottedCourseWhenAttacking? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.GetDoctrine(scenario_0, ref flag).GetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, null, false, false);
					b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine2 = this.GetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), false, false);
				b = (ignorePlottedCourseWhenAttackingDoctrine2.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x0031F67C File Offset: 0x0031D87C
		public void method_45(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponStateRTB? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是, 当达到武器状态时飞机离开飞行编队返回基地";
			string text2 = "是, 当飞行编队中第一架飞机达到武器状态时返回基地";
			string text3 = "是, 当飞行编队中最后一架飞机达到武器状态时返回基地";
			string text4 = "否, 飞机达到武器状态时并不返回基地";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"与上级一致, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponStateRTB? winchesterShotgunRTBDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false);
					b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text4
								});
							}
						}
					}
				}
				Doctrine._WeaponStateRTB? winchesterShotgunRTBDoctrine2 = this.GetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false);
				b = (winchesterShotgunRTBDoctrine2.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x0031FCD8 File Offset: 0x0031DED8
		public void method_46(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._FuelStateRTB? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是, 当飞机达到燃油状态时离开飞机编队返回机场";
			string text2 = "是, 当飞行编队中第一架飞机达到燃油状态时返回基地";
			string text3 = "是, 当飞行编队中最后一架飞机达到燃油状态时返回基地(警告: 并不建议!)";
			string text4 = "否, 当达到燃油状态时作战单元并不返回基地";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"与上级一致, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._FuelStateRTB? bingoJokerRTBDoctrine = this.GetDoctrine(scenario_0, ref flag).GetBingoJokerRTBDoctrine(scenario_0, false, false, false);
					b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text4
								});
							}
						}
					}
				}
				Doctrine._FuelStateRTB? bingoJokerRTBDoctrine2 = this.GetBingoJokerRTBDoctrine(scenario_0, false, false, false);
				b = (bingoJokerRTBDoctrine2.HasValue ? new byte?((byte)bingoJokerRTBDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00320334 File Offset: 0x0031E534
		public void method_47(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._JettisonOrdnance? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "受到攻击时抛弃弹药";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._JettisonOrdnance? jettisonOrdnanceDoctrine = this.GetDoctrine(scenario_0, ref flag).GetJettisonOrdnanceDoctrine(scenario_0, false, false, false);
					b = (jettisonOrdnanceDoctrine.HasValue ? new byte?((byte)jettisonOrdnanceDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._JettisonOrdnance? jettisonOrdnanceDoctrine2 = this.GetJettisonOrdnanceDoctrine(scenario_0, false, false, false);
				b = (jettisonOrdnanceDoctrine2.HasValue ? new byte?((byte)jettisonOrdnanceDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x003206E8 File Offset: 0x0031E8E8
		public void method_48(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._BehaviorTowardsAmbigousTarget? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略模糊性";
			string text2 = "乐观决策";
			string text3 = "悲观决策";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTargetDoctrine = this.GetDoctrine(scenario_0, ref flag).GetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, false, false);
					b = (behaviorTowardsAmbigousTargetDoctrine.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (behaviorTowardsAmbigousTargetDoctrine.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTargetDoctrine2 = this.GetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, false, false);
				b = (behaviorTowardsAmbigousTargetDoctrine2.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00320BD4 File Offset: 0x0031EDD4
		private void method_49(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._AutomaticEvasion? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._AutomaticEvasion? automaticEvasionDoctrine = this.GetDoctrine(scenario_0, ref flag).GetAutomaticEvasionDoctrine(scenario_0, false, true, false);
					b = (automaticEvasionDoctrine.HasValue ? new byte?((byte)automaticEvasionDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._AutomaticEvasion? automaticEvasionDoctrine2 = this.GetAutomaticEvasionDoctrine(scenario_0, false, true, false);
				b = (automaticEvasionDoctrine2.HasValue ? new byte?((byte)automaticEvasionDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00320F88 File Offset: 0x0031F188
		public void method_50(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._MaintainStandoff? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._MaintainStandoff? maintainStandoffDoctrine = this.GetDoctrine(scenario_0, ref flag).GetMaintainStandoffDoctrine(scenario_0, false, false, false);
					b = (maintainStandoffDoctrine.HasValue ? new byte?((byte)maintainStandoffDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._MaintainStandoff? maintainStandoffDoctrine2 = this.GetMaintainStandoffDoctrine(scenario_0, false, false, false);
				b = (maintainStandoffDoctrine2.HasValue ? new byte?((byte)maintainStandoffDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x0032133C File Offset: 0x0031F53C
		public void method_51(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._GunStrafeGroundTargets? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine = this.GetDoctrine(scenario_0, ref flag).GetGunStrafeGroundTargetsDoctrine(scenario_0, false, false, false);
					b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine2 = this.GetGunStrafeGroundTargetsDoctrine(scenario_0, false, false, false);
				b = (gunStrafeGroundTargetsDoctrine2.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x003216F0 File Offset: 0x0031F8F0
		public void method_52(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseRefuel? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "允许";
			string text2 = "允许, 但不允许加油机对加油机进行加油";
			string text3 = "不允许";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseRefuel? useRefuelDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseRefuelDoctrine(scenario_0, false, false, false, false);
					b = (useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._UseRefuel? useRefuelDoctrine2 = this.GetUseRefuelDoctrine(scenario_0, false, false, false, false);
				b = (useRefuelDoctrine2.HasValue ? new byte?((byte)useRefuelDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
                if (this.subject.GetType() == typeof(Waypoint))
                {
                    dataTable_0.Rows.Add(new object[]
                    {
                        4,
                        "未配置"
                    });
                }
            }
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x00321B98 File Offset: 0x0031FD98
		public void method_53(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RefuelSelection? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "选择最近的加油机";
			string text2 = "选择位于我们和目标(作战目标或者巡逻区, 如果返回则是基地)之间的加油机";
			string text3 = "优先考虑位于我们和目标(作战目标或者巡逻区, 如果返回则是基地)之间的加油机, 但不允许往回飞";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RefuelSelection? refuelSelectionDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRefuelSelectionDoctrine(scenario_0, false, false, false, false);
					b = (refuelSelectionDoctrine.HasValue ? new byte?((byte)refuelSelectionDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (refuelSelectionDoctrine.HasValue ? new byte?((byte)refuelSelectionDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._RefuelSelection? refuelSelectionDoctrine2 = this.GetRefuelSelectionDoctrine(scenario_0, false, false, false, false);
				b = (refuelSelectionDoctrine2.HasValue ? new byte?((byte)refuelSelectionDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
                if (this.subject.GetType() == typeof(Waypoint))
                {
                    dataTable_0.Rows.Add(new object[]
                    {
                        4,
                        "未配置"
                    });
                }
            }
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00322040 File Offset: 0x00320240
		public void method_54(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._ShootTourists? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是 (可与任何目标交战)";
			string text2 = "否 (只与任务相关的目标交战)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._ShootTourists? shootTouristsDoctrine = this.GetDoctrine(scenario_0, ref flag).GetShootTouristsDoctrine(scenario_0, false, false, false);
					b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._ShootTourists? shootTouristsDoctrine2 = this.GetShootTouristsDoctrine(scenario_0, false, false, false);
				b = (shootTouristsDoctrine2.HasValue ? new byte?((byte)shootTouristsDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x003223F4 File Offset: 0x003205F4
		public void method_55(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseSAMsInASuWMode? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是, 以舰舰模式使用舰空导弹";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseSAMsInASuWMode? useSAMsInASuWModeDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseSAMsInASuWModeDoctrine(scenario_0, false, false, false);
					b = (useSAMsInASuWModeDoctrine.HasValue ? new byte?((byte)useSAMsInASuWModeDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._UseSAMsInASuWMode? useSAMsInASuWModeDoctrine2 = this.GetUseSAMsInASuWModeDoctrine(scenario_0, false, false, false);
				b = (useSAMsInASuWModeDoctrine2.HasValue ? new byte?((byte)useSAMsInASuWModeDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x003227A8 File Offset: 0x003209A8
		public void method_56(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._IgnoreEMCONUnderAttack? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是";
			string text2 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttackDoctrine = this.GetDoctrine(scenario_0, ref flag).GetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, false, false);
					b = (ignoreEMCONUnderAttackDoctrine.HasValue ? new byte?((byte)ignoreEMCONUnderAttackDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttackDoctrine2 = this.GetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, false, false);
				b = (ignoreEMCONUnderAttackDoctrine2.HasValue ? new byte?((byte)ignoreEMCONUnderAttackDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00322B5C File Offset: 0x00320D5C
		public void method_57(ref DataTable dataTable_0, Scenario scenario_0, bool bool_31, Doctrine._QuickTurnAround? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是";
			string text2 = "战斗机与反潜战挂载";
			string text3 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					Doctrine._QuickTurnAround? quickTurnAroundDoctrine = this.GetDoctrine(scenario_0, ref bool_31).GetQuickTurnAroundDoctrine(scenario_0, false, true, false, false);
					b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._QuickTurnAround? quickTurnAroundDoctrine2 = this.GetQuickTurnAroundDoctrine(scenario_0, false, true, false, false);
				b = (quickTurnAroundDoctrine2.HasValue ? new byte?((byte)quickTurnAroundDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x00323048 File Offset: 0x00321248
		private void method_58(ref DataTable dataTable_0, Scenario scenario_0, bool bool_31, Doctrine._AirOpsTempo? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "快速出动";
			string text2 = "一般强度出动";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					Doctrine._AirOpsTempo? airOpsTempoDoctrine = this.GetDoctrine(scenario_0, ref bool_31).GetAirOpsTempoDoctrine(scenario_0, false, true, false, false);
					b = (airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._AirOpsTempo? airOpsTempoDoctrine2 = this.GetAirOpsTempoDoctrine(scenario_0, false, true, false, false);
				b = (airOpsTempoDoctrine2.HasValue ? new byte?((byte)airOpsTempoDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x003233FC File Offset: 0x003215FC
		public void method_59(ref DataTable dataTable_0, Scenario scenario_0, bool bool_31, Doctrine._WeaponState? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "使用挂载设置";
			string text2 = "Winchester: 任务武器已耗光.立即脱离战斗";
			string text3 = "Winchester: 任务武器已耗光. 允许使用航炮与临机出现目标格斗.推荐!";
			string text4 = "Shotgun: 所有超视距与防区外打击武器已经耗光.立即脱离战斗";
			string text5 = "Shotgun: 所有超视距与防区外打击武器已经耗光. 允许使用视距内或防区内打击武器对较易攻击的临机出现目标进行攻击. 不使用航炮";
			string text6 = "Shotgun: 所有超视距与防区外打击武器已经耗光. 允许使用视距内、防区内打击武器或者航炮对较易攻击的临机出现目标进行攻击";
			string text7 = "Shotgun: 使用超视距或防区外打击武器进行一次交战.立即脱离战斗";
			string text8 = "Shotgun: 使用超视距或防区外打击武器进行一次交战. 允许使用视距内或防区内打击武器对较易攻击的临机出现目标进行攻击. 不使用航炮. 推荐!";
			string text9 = "Shotgun: 使用超视距或防区外打击武器进行一次交战. 允许使用视距内、防区内打击武器或者航炮对较易攻击的临机出现目标进行攻击";
			string text10 = "Shotgun: 同时使用超视距/视距内或防区外/防区内打击武器进行一次交战.不使用航炮.";
			string text11 = "Shotgun: 同时使用超视距/视距内或防区外/防区内打击武器进行一次交战. 允许使用航炮对较易攻击的临机出现目标进行攻击. 推荐!";
			string text12 = "Shotgun: 使用视距内或防区内打击武器进行一次交战. 立即脱离战斗";
			string text13 = "Shotgun: 使用视距内或防区内打击武器进行一次交战. 允许使用航炮与临机出现目标格斗. 推荐!";
			string text14 = "Shotgun: 使用航炮进行一次交战";
			string text15 = "Shotgun: 25%相关武器已经耗光. 立即脱离战斗";
			string text16 = "Shotgun: 25%相关武器已经耗光. 允许与临机出现目标交战，包括航炮";
			string text17 = "Shotgun: 50%相关武器已经耗光. 立即脱离战斗";
			string text18 = "Shotgun: 50%相关武器已经耗光. 允许与临机出现目标交战，包括航炮";
			string text19 = "Shotgun: 75%相关武器已经耗光. 立即脱离战斗";
			string text20 = "Shotgun: 75%相关武器已经耗光. 允许与临机出现目标交战，包括航炮";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				text11
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				text12
			});
			dataTable_0.Rows.Add(new object[]
			{
				12,
				text13
			});
			dataTable_0.Rows.Add(new object[]
			{
				13,
				text14
			});
			dataTable_0.Rows.Add(new object[]
			{
				14,
				text15
			});
			dataTable_0.Rows.Add(new object[]
			{
				15,
				text16
			});
			dataTable_0.Rows.Add(new object[]
			{
				16,
				text17
			});
			dataTable_0.Rows.Add(new object[]
			{
				17,
				text18
			});
			dataTable_0.Rows.Add(new object[]
			{
				18,
				text19
			});
			dataTable_0.Rows.Add(new object[]
			{
				19,
				text20
			});
			if (this.subject.GetType() != typeof(Side))
			{
				int? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							20,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								20,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									20,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										20,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											20,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												20,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													20,
													"与上级一致, " + text7
												});
											}
											else
											{
												num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														20,
														"与上级一致, " + text8
													});
												}
												else
												{
													num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															20,
															"与上级一致, " + text9
														});
													}
													else
													{
														num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																20,
																"与上级一致, " + text10
															});
														}
														else
														{
															num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	20,
																	"与上级一致, " + text11
																});
															}
															else
															{
																num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		20,
																		"与上级一致, " + text12
																	});
																}
																else
																{
																	num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																	if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		dataTable_0.Rows.Add(new object[]
																		{
																			20,
																			"与上级一致, " + text13
																		});
																	}
																	else
																	{
																		num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																		if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			dataTable_0.Rows.Add(new object[]
																			{
																				20,
																				"与上级一致, " + text14
																			});
																		}
																		else
																		{
																			num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				dataTable_0.Rows.Add(new object[]
																				{
																					20,
																					"与上级一致, " + text15
																				});
																			}
																			else
																			{
																				num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					dataTable_0.Rows.Add(new object[]
																					{
																						20,
																						"与上级一致, " + text16
																					});
																				}
																				else
																				{
																					num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						dataTable_0.Rows.Add(new object[]
																						{
																							20,
																							"与上级一致, " + text17
																						});
																					}
																					else
																					{
																						num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							dataTable_0.Rows.Add(new object[]
																							{
																								20,
																								"与上级一致, " + text18
																							});
																						}
																						else
																						{
																							num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								dataTable_0.Rows.Add(new object[]
																								{
																									20,
																									"与上级一致, " + text19
																								});
																							}
																							else
																							{
																								num = (nullable_38.HasValue ? new int?((int)nullable_38.GetValueOrDefault()) : null);
																								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4022) : null).GetValueOrDefault())
																								{
																									dataTable_0.Rows.Add(new object[]
																									{
																										20,
																										"与上级一致, " + text20
																									});
																								}
																								else
																								{
																									dataTable_0.Rows.Add(new object[]
																									{
																										20,
																										"Inherited, Various"
																									});
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					Doctrine._WeaponState? winchesterShotgunDoctrine = this.GetDoctrine(scenario_0, ref bool_31).GetWinchesterShotgunDoctrine(scenario_0, false, true, false, false);
					num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							20,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								20,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									20,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										20,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											20,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												20,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													20,
													"与上级一致, " + text7
												});
											}
											else
											{
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														20,
														"与上级一致, " + text8
													});
												}
												else
												{
													num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															20,
															"与上级一致, " + text9
														});
													}
													else
													{
														num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																20,
																"与上级一致, " + text10
															});
														}
														else
														{
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	20,
																	"与上级一致, " + text11
																});
															}
															else
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		20,
																		"与上级一致, " + text12
																	});
																}
																else
																{
																	num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																	if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		dataTable_0.Rows.Add(new object[]
																		{
																			20,
																			"与上级一致, " + text13
																		});
																	}
																	else
																	{
																		num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																		if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			dataTable_0.Rows.Add(new object[]
																			{
																				20,
																				"与上级一致, " + text14
																			});
																		}
																		else
																		{
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				dataTable_0.Rows.Add(new object[]
																				{
																					20,
																					"与上级一致, " + text15
																				});
																			}
																			else
																			{
																				num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					dataTable_0.Rows.Add(new object[]
																					{
																						20,
																						"与上级一致, " + text16
																					});
																				}
																				else
																				{
																					num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						dataTable_0.Rows.Add(new object[]
																						{
																							20,
																							"与上级一致, " + text17
																						});
																					}
																					else
																					{
																						num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							dataTable_0.Rows.Add(new object[]
																							{
																								20,
																								"与上级一致, " + text18
																							});
																						}
																						else
																						{
																							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								dataTable_0.Rows.Add(new object[]
																								{
																									20,
																									"与上级一致, " + text19
																								});
																							}
																							else
																							{
																								dataTable_0.Rows.Add(new object[]
																								{
																									20,
																									"与上级一致, " + text20
																								});
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponState? winchesterShotgunDoctrine2 = this.GetWinchesterShotgunDoctrine(scenario_0, false, true, false, false);
				num = (winchesterShotgunDoctrine2.HasValue ? new int?((int)winchesterShotgunDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						21,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						21,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00324F60 File Offset: 0x00323160
		public void method_60(ref DataTable dataTable_0, Scenario scenario_0, bool bool_31, Doctrine._FuelState? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Bingo: 达到计划储备燃油状态立即终止任务返回基地";
			string text2 = "Joker: 剩余10%任务燃油时即终止任务返回基地（即超过10%的Bingo）";
			string text3 = "Joker: 超过Bingo状态20%";
			string text4 = "Joker: 超过Bingo状态25%";
			string text5 = "Joker: 超过Bingo状态30%";
			string text6 = "Joker: 超过Bingo状态40%";
			string text7 = "Joker: 超过Bingo状态50%";
			string text8 = "Joker: 超过Bingo状态60%";
			string text9 = "Joker: 超过Bingo状态70%";
			string text10 = "Joker: 超过Bingo状态75%";
			string text11 = "Joker: 超过Bingo状态80%";
			string text12 = "Joker: 超过Bingo状态90%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				text11
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				text12
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_38))
				{
					b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							12,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								12,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									12,
									"与上级一致, " + text3
								});
							}
							else
							{
								b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										12,
										"与上级一致, " + text4
									});
								}
								else
								{
									b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											12,
											"与上级一致, " + text5
										});
									}
									else
									{
										b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												12,
												"与上级一致, " + text6
											});
										}
										else
										{
											b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													12,
													"与上级一致, " + text7
												});
											}
											else
											{
												b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														12,
														"与上级一致, " + text8
													});
												}
												else
												{
													b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															12,
															"与上级一致, " + text9
														});
													}
													else
													{
														b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																12,
																"与上级一致, " + text10
															});
														}
														else
														{
															b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	12,
																	"与上级一致, " + text11
																});
															}
															else
															{
																b = (nullable_38.HasValue ? new byte?((byte)nullable_38.GetValueOrDefault()) : null);
																if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 11) : null).GetValueOrDefault())
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		12,
																		"与上级一致, " + text12
																	});
																}
																else
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		12,
																		"Inherited, Various"
																	});
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					Doctrine._FuelState? bingoJokerDoctrine = this.GetDoctrine(scenario_0, ref bool_31).GetBingoJokerDoctrine(scenario_0, false, true, false, false);
					b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							12,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								12,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									12,
									"与上级一致, " + text3
								});
							}
							else
							{
								b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										12,
										"与上级一致, " + text4
									});
								}
								else
								{
									b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											12,
											"与上级一致, " + text5
										});
									}
									else
									{
										b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												12,
												"与上级一致, " + text6
											});
										}
										else
										{
											b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													12,
													"与上级一致, " + text7
												});
											}
											else
											{
												b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														12,
														"与上级一致, " + text8
													});
												}
												else
												{
													b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															12,
															"与上级一致, " + text9
														});
													}
													else
													{
														b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																12,
																"与上级一致, " + text10
															});
														}
														else
														{
															b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	12,
																	"与上级一致, " + text11
																});
															}
															else
															{
																dataTable_0.Rows.Add(new object[]
																{
																	12,
																	"与上级一致, " + text12
																});
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._FuelState? bingoJokerDoctrine2 = this.GetBingoJokerDoctrine(scenario_0, false, true, false, false);
				b = (bingoJokerDoctrine2.HasValue ? new byte?((byte)bingoJokerDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 12) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						13,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						13,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00326000 File Offset: 0x00324200
		private void method_61(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseTorpedoesKinematicRange? UseTorpedoesKinematicRange_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "自动与手动发射都使用动力航程";
			string text2 = "只有手动发射时使用动力航程";
			string text3 = "实际航程";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(UseTorpedoesKinematicRange_))
				{
					b = (UseTorpedoesKinematicRange_.HasValue ? new byte?((byte)UseTorpedoesKinematicRange_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (UseTorpedoesKinematicRange_.HasValue ? new byte?((byte)UseTorpedoesKinematicRange_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (UseTorpedoesKinematicRange_.HasValue ? new byte?((byte)UseTorpedoesKinematicRange_.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRangeDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, false, false);
					b = (useTorpedoesKinematicRangeDoctrine.HasValue ? new byte?((byte)useTorpedoesKinematicRangeDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (useTorpedoesKinematicRangeDoctrine.HasValue ? new byte?((byte)useTorpedoesKinematicRangeDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRangeDoctrine2 = this.GetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, false, false);
				b = (useTorpedoesKinematicRangeDoctrine2.HasValue ? new byte?((byte)useTorpedoesKinematicRangeDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x003264EC File Offset: 0x003246EC
		public Doctrine._WeaponControlStatus? GetWCS_AirDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponControlStatus? result;
			try
			{
				if (this.WCS_AirHasNoValue())
				{
					bool flag = true;
					result = this.GetDoctrine(scenario_0, ref flag).GetWCS_AirDoctrine(scenario_0, bool_31, nullable_38, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._WeaponControlStatus?(this.WCS_Air.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200448", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x0032658C File Offset: 0x0032478C
		public void method_63(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33, Doctrine._WeaponControlStatus? nullable_39)
		{
			this.WCS_Air = nullable_39;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, nullable_38, bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x0002BF9C File Offset: 0x0002A19C
		public bool WCS_AirHasNoValue()
		{
			return !this.WCS_Air.HasValue;
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x003265C0 File Offset: 0x003247C0
		public bool IsWCS_Air_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.WCS_Air_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).IsWCS_Air_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x0032660C File Offset: 0x0032480C
		public void SetWCS_Air_PlayerEditable(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.WCS_Air_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetWCS_Air_PlayerEditable(scenario_0, bool_31);
			}
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00326654 File Offset: 0x00324854
		public Doctrine._WeaponControlStatus? GetWCS_SurfaceDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponControlStatus? result;
			try
			{
				if (this.WCS_SurfaceHasNoValue())
				{
					bool flag = true;
					result = this.GetDoctrine(scenario_0, ref flag).GetWCS_SurfaceDoctrine(scenario_0, bool_31, nullable_38, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._WeaponControlStatus?(this.WCS_Surface.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200449", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x003266F4 File Offset: 0x003248F4
		public void SetWCS_SurfaceDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33, Doctrine._WeaponControlStatus? doctrine_)
		{
			this.WCS_Surface = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, nullable_38, bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		public bool WCS_SurfaceHasNoValue()
		{
			return !this.WCS_Surface.HasValue;
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00326728 File Offset: 0x00324928
		public bool IsWCS_Surface_PlayerEditable(Scenario scenario_)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.WCS_Surface_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_, ref flag).IsWCS_Surface_PlayerEditable(scenario_);
			}
			return result;
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00326774 File Offset: 0x00324974
		public void SetWCS_Surface_PlayerEditable(Scenario scenario_, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.WCS_Surface_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_, ref flag).SetWCS_Surface_PlayerEditable(scenario_, value);
			}
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x003267BC File Offset: 0x003249BC
		public Doctrine._WeaponControlStatus? GetWCS_SubmarineDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponControlStatus? result;
			try
			{
				if (this.WCS_SubmarineHasNoValue())
				{
					bool flag = true;
					result = this.GetDoctrine(scenario_0, ref flag).GetWCS_SubmarineDoctrine(scenario_0, bool_31, nullable_38, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._WeaponControlStatus?(this.WCS_Submarine.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200450", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x0032685C File Offset: 0x00324A5C
		public void SetWCS_SubmarineDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33, Doctrine._WeaponControlStatus? doctrine_)
		{
			this.WCS_Submarine = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, nullable_38, bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		public bool WCS_SubmarineHasNoValue()
		{
			return !this.WCS_Submarine.HasValue;
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00326890 File Offset: 0x00324A90
		public bool IsWCS_Submarine_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.WCS_Submarine_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).IsWCS_Submarine_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x003268DC File Offset: 0x00324ADC
		public void SetWCS_Submarine_PlayerEditable(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.WCS_Submarine_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetWCS_Submarine_PlayerEditable(scenario_0, bool_31);
			}
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x00326924 File Offset: 0x00324B24
		public Doctrine._WeaponControlStatus? GetWCS_LandDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponControlStatus? result;
			try
			{
				if (this.WCS_LandHasNoValue())
				{
					bool flag = true;
					result = this.GetDoctrine(scenario_0, ref flag).GetWCS_LandDoctrine(scenario_0, bool_31, nullable_38, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._WeaponControlStatus?(this.WCS_Land.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200451", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x003269C4 File Offset: 0x00324BC4
		public void SetWCS_LandDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33, Doctrine._WeaponControlStatus? nullable_39)
		{
			this.WCS_Land = nullable_39;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, nullable_38, bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x0002BFCC File Offset: 0x0002A1CC
		public bool WCS_LandHasNoValue()
		{
			return !this.WCS_Land.HasValue;
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x003269F8 File Offset: 0x00324BF8
		public bool IsWCSLand_PlayerEditable(Scenario scenario_)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.WCS_Player_Land;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_, ref flag).IsWCSLand_PlayerEditable(scenario_);
			}
			return result;
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00326A44 File Offset: 0x00324C44
		public void SetWCSLand_PlayerEditable(Scenario scenario_, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.WCS_Player_Land = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_, ref flag).SetWCSLand_PlayerEditable(scenario_, value);
			}
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x00326A8C File Offset: 0x00324C8C
		public Doctrine._IgnorePlottedCourseWhenAttacking? GetIgnorePlottedCourseWhenAttackingDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33)
		{
			Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine;
			if (this.IgnorePlottedCourseWhenAttackingHasNoValue())
			{
				bool flag = true;
				ignorePlottedCourseWhenAttackingDoctrine = this.GetDoctrine(scenario_0, ref flag).GetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, bool_31, nullable_38, bool_32, bool_33);
			}
			else
			{
				if (this.IgnorePlottedCourseWhenAttacking.Value == (Doctrine._IgnorePlottedCourseWhenAttacking)255)
				{
					this.IgnorePlottedCourseWhenAttacking = new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1);
				}
				ignorePlottedCourseWhenAttackingDoctrine = new Doctrine._IgnorePlottedCourseWhenAttacking?(this.IgnorePlottedCourseWhenAttacking.Value);
			}
			return ignorePlottedCourseWhenAttackingDoctrine;
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x00326AF8 File Offset: 0x00324CF8
		public void SetIgnorePlottedCourseWhenAttackingDoctrine(Scenario scenario_0, bool bool_31, bool? nullable_38, bool bool_32, bool bool_33, Doctrine._IgnorePlottedCourseWhenAttacking? doctrine_)
		{
			bool flag = false;
			if (!this.IgnorePlottedCourseWhenAttacking.HasValue)
			{
				flag = true;
			}
			else
			{
				byte value = (byte)this.IgnorePlottedCourseWhenAttacking.Value;
				byte? b = doctrine_.HasValue ? new byte?((byte)doctrine_.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(value != b.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.IgnorePlottedCourseWhenAttacking = doctrine_;
			if (flag)
			{
				Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
				if (@delegate != null)
				{
					@delegate(this.subject, nullable_38, bool_31, bool_32, bool_33, false);
				}
			}
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		public bool IgnorePlottedCourseWhenAttackingHasNoValue()
		{
			return !this.IgnorePlottedCourseWhenAttacking.HasValue;
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00326BAC File Offset: 0x00324DAC
		public bool IsIgnorePlottedCourseWhenAttackingPlayerEditable(Scenario scenario_)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.IPCWA_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_, ref flag).IsIgnorePlottedCourseWhenAttackingPlayerEditable(scenario_);
			}
			return result;
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x00326BF8 File Offset: 0x00324DF8
		public void SetIgnorePlottedCourseWhenAttackingPlayerEditable(Scenario scenario_, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.IPCWA_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_, ref flag).SetIgnorePlottedCourseWhenAttackingPlayerEditable(scenario_, value);
			}
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x00326C40 File Offset: 0x00324E40
		public Doctrine._BehaviorTowardsAmbigousTarget? GetBehaviorTowardsAmbigousTargetDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTargetDoctrine;
			if (this.BehaviorTowardsAmbigousTargetHasNoValue())
			{
				bool flag = true;
				behaviorTowardsAmbigousTargetDoctrine = this.GetDoctrine(scenario_0, ref flag).GetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				behaviorTowardsAmbigousTargetDoctrine = new Doctrine._BehaviorTowardsAmbigousTarget?(this.BehaviorTowardsAmbigousTarget.Value);
			}
			return behaviorTowardsAmbigousTargetDoctrine;
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x00326C88 File Offset: 0x00324E88
		public void SetBehaviorTowardsAmbigousTargetDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._BehaviorTowardsAmbigousTarget? doctrine_)
		{
			this.BehaviorTowardsAmbigousTarget = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x0002BFEC File Offset: 0x0002A1EC
		public bool BehaviorTowardsAmbigousTargetHasNoValue()
		{
			return !this.BehaviorTowardsAmbigousTarget.HasValue;
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x00326CC0 File Offset: 0x00324EC0
		public bool IsBehaviorTowardsAmbigousTarget_PlayerEditable(Scenario scenario_)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.BehaviorTowardsAmbigousTarget_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_, ref flag).IsBehaviorTowardsAmbigousTarget_PlayerEditable(scenario_);
			}
			return result;
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00326D0C File Offset: 0x00324F0C
		public void SetBehaviorTowardsAmbigousTarget_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.BehaviorTowardsAmbigousTarget_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetBehaviorTowardsAmbigousTarget_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00326D54 File Offset: 0x00324F54
		public Doctrine._DamageThreshold? GetWithdrawDamageThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._DamageThreshold? withdrawDamageThresholdDoctrine;
			if (this.WithdrawDamageThresholdHasNoValue())
			{
				bool flag = true;
				withdrawDamageThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawDamageThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				withdrawDamageThresholdDoctrine = new Doctrine._DamageThreshold?(this.WithdrawDamageThreshold.Value);
			}
			return withdrawDamageThresholdDoctrine;
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x00326D9C File Offset: 0x00324F9C
		public void SetWithdrawDamageThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._DamageThreshold? WithdrawDamageThreshold_)
		{
			this.WithdrawDamageThreshold = WithdrawDamageThreshold_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		public bool WithdrawDamageThresholdHasNoValue()
		{
			return !this.WithdrawDamageThreshold.HasValue;
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x00326DD4 File Offset: 0x00324FD4
		public Doctrine._FuelQuantityThreshold? GetWithdrawFuelThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._FuelQuantityThreshold? withdrawFuelThresholdDoctrine;
			if (this.WithdrawFuelThresholdHasNoValue())
			{
				bool flag = true;
				withdrawFuelThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawFuelThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				withdrawFuelThresholdDoctrine = new Doctrine._FuelQuantityThreshold?(this.WithdrawFuelThreshold.Value);
			}
			return withdrawFuelThresholdDoctrine;
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x00326E1C File Offset: 0x0032501C
		public void SetWithdrawFuelThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._FuelQuantityThreshold? nullable_38)
		{
			this.WithdrawFuelThreshold = nullable_38;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x0002C00C File Offset: 0x0002A20C
		public bool WithdrawFuelThresholdHasNoValue()
		{
			return !this.WithdrawFuelThreshold.HasValue;
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x00326E54 File Offset: 0x00325054
		public Doctrine._WeaponQuantityThreshold? GetWithdrawAttackThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponQuantityThreshold? withdrawAttackThresholdDoctrine;
			if (this.WithdrawAttackThresholdHasNoValue())
			{
				bool flag = true;
				withdrawAttackThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawAttackThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				withdrawAttackThresholdDoctrine = new Doctrine._WeaponQuantityThreshold?(this.WithdrawAttackThreshold.Value);
			}
			return withdrawAttackThresholdDoctrine;
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x00326E9C File Offset: 0x0032509C
		public void SetWithdrawAttackThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._WeaponQuantityThreshold? doctrine_)
		{
			this.WithdrawAttackThreshold = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x0002C01C File Offset: 0x0002A21C
		public bool WithdrawAttackThresholdHasNoValue()
		{
			return !this.WithdrawAttackThreshold.HasValue;
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x00326ED4 File Offset: 0x003250D4
		public Doctrine._WeaponQuantityThreshold? GetWithdrawDefenceThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponQuantityThreshold? withdrawDefenceThresholdDoctrine;
			if (this.WithdrawDefenceThresholdHasNoValue())
			{
				bool flag = true;
				withdrawDefenceThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawDefenceThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				withdrawDefenceThresholdDoctrine = new Doctrine._WeaponQuantityThreshold?(this.WithdrawDefenceThreshold.Value);
			}
			return withdrawDefenceThresholdDoctrine;
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00326F1C File Offset: 0x0032511C
		public void SetWithdrawDefenceThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._WeaponQuantityThreshold? doctrine_)
		{
			this.WithdrawDefenceThreshold = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x0002C02C File Offset: 0x0002A22C
		public bool WithdrawDefenceThresholdHasNoValue()
		{
			return !this.WithdrawDefenceThreshold.HasValue;
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00326F54 File Offset: 0x00325154
		public Doctrine._DamageThreshold? GetRedeployDamageThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._DamageThreshold? redeployDamageThresholdDoctrine;
			if (this.RedeployDamageThresholdHasNoValue())
			{
				bool flag = true;
				redeployDamageThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRedeployDamageThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				redeployDamageThresholdDoctrine = new Doctrine._DamageThreshold?(this.RedeployDamageThreshold.Value);
			}
			return redeployDamageThresholdDoctrine;
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00326F9C File Offset: 0x0032519C
		public void SetRedeployDamageThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._DamageThreshold? doctrine_)
		{
			this.RedeployDamageThreshold = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x0002C03C File Offset: 0x0002A23C
		public bool RedeployDamageThresholdHasNoValue()
		{
			return !this.RedeployDamageThreshold.HasValue;
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x00326FD4 File Offset: 0x003251D4
		public Doctrine._FuelQuantityThreshold? GetRedeployFuelThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._FuelQuantityThreshold? redeployFuelThresholdDoctrine;
			if (this.RedeployFuelThresholdHasNoValue())
			{
				bool flag = true;
				redeployFuelThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRedeployFuelThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				redeployFuelThresholdDoctrine = new Doctrine._FuelQuantityThreshold?(this.RedeployFuelThreshold.Value);
			}
			return redeployFuelThresholdDoctrine;
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x0032701C File Offset: 0x0032521C
		public void SetRedeployFuelThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._FuelQuantityThreshold? doctrine_)
		{
			this.RedeployFuelThreshold = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x0002C04C File Offset: 0x0002A24C
		public bool RedeployFuelThresholdHasNoValue()
		{
			return !this.RedeployFuelThreshold.HasValue;
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x00327054 File Offset: 0x00325254
		public Doctrine._WeaponQuantityThreshold? GetRedeployAttackWeaponQuantityThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponQuantityThreshold? redeployAttackWeaponQuantityThresholdDoctrine;
			if (this.RedeployAttackWeaponQuantityThresholdHasNoValue())
			{
				bool flag = true;
				redeployAttackWeaponQuantityThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				redeployAttackWeaponQuantityThresholdDoctrine = new Doctrine._WeaponQuantityThreshold?(this.RedeployAttackThreshold.Value);
			}
			return redeployAttackWeaponQuantityThresholdDoctrine;
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x0032709C File Offset: 0x0032529C
		public void SetRedeployAttackWeaponQuantityThresholdDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._WeaponQuantityThreshold? doctrine_)
		{
			this.RedeployAttackThreshold = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x0002C05C File Offset: 0x0002A25C
		public bool RedeployAttackWeaponQuantityThresholdHasNoValue()
		{
			return !this.RedeployAttackThreshold.HasValue;
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x003270D4 File Offset: 0x003252D4
		public Doctrine._WeaponQuantityThreshold? GetRedeployDefenceWeaponQuantityThreshold(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponQuantityThreshold? redeployDefenceWeaponQuantityThreshold;
			if (this.RedeployDefenceThresholdHasNoValue())
			{
				bool flag = true;
				redeployDefenceWeaponQuantityThreshold = this.GetDoctrine(scenario_0, ref flag).GetRedeployDefenceWeaponQuantityThreshold(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				redeployDefenceWeaponQuantityThreshold = new Doctrine._WeaponQuantityThreshold?(this.RedeployDefenceThreshold.Value);
			}
			return redeployDefenceWeaponQuantityThreshold;
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x0032711C File Offset: 0x0032531C
		public void SetRedeployDefenceWeaponQuantityThreshold(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._WeaponQuantityThreshold? doctrine_)
		{
			this.RedeployDefenceThreshold = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x0002C06C File Offset: 0x0002A26C
		public bool RedeployDefenceThresholdHasNoValue()
		{
			return !this.RedeployDefenceThreshold.HasValue;
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00327154 File Offset: 0x00325354
		public Doctrine._WeaponStateRTB? GetWinchesterShotgunRTBDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._WeaponStateRTB? winchesterShotgunRTBDoctrine;
			if (this.WinchesterShotgunRTBHasNoValue())
			{
				bool flag = true;
				winchesterShotgunRTBDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWinchesterShotgunRTBDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				winchesterShotgunRTBDoctrine = new Doctrine._WeaponStateRTB?(this.WinchesterShotgunRTB.Value);
			}
			return winchesterShotgunRTBDoctrine;
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x0032719C File Offset: 0x0032539C
		public void SetWinchesterShotgunRTBDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._WeaponStateRTB? doctrine_)
		{
			this.WinchesterShotgunRTB = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x0002C07C File Offset: 0x0002A27C
		public bool WinchesterShotgunRTBHasNoValue()
		{
			return !this.WinchesterShotgunRTB.HasValue;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x003271D4 File Offset: 0x003253D4
		public bool method_119(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.WinchesterShotgunRTB_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_119(scenario_0);
			}
			return result;
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00327220 File Offset: 0x00325420
		public void method_120(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.WinchesterShotgunRTB_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_120(scenario_0, bool_31);
			}
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00327268 File Offset: 0x00325468
		public Doctrine._FuelStateRTB? GetBingoJokerRTBDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._FuelStateRTB? bingoJokerRTBDoctrine;
			if (this.BingoJokerRTBHasNoValue())
			{
				bool flag = true;
				bingoJokerRTBDoctrine = this.GetDoctrine(scenario_0, ref flag).GetBingoJokerRTBDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				bingoJokerRTBDoctrine = new Doctrine._FuelStateRTB?(this.BingoJokerRTB.Value);
			}
			return bingoJokerRTBDoctrine;
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x003272B0 File Offset: 0x003254B0
		public void SetBingoJokerRTBDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._FuelStateRTB? doctrine_)
		{
			this.BingoJokerRTB = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x0002C08C File Offset: 0x0002A28C
		public bool BingoJokerRTBHasNoValue()
		{
			return !this.BingoJokerRTB.HasValue;
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x003272E8 File Offset: 0x003254E8
		public bool method_124(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.BingoJokerRTB_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_124(scenario_0);
			}
			return result;
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00327334 File Offset: 0x00325534
		public void method_125(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.BingoJokerRTB_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_125(scenario_0, bool_31);
			}
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x0032737C File Offset: 0x0032557C
		public Doctrine._JettisonOrdnance? GetJettisonOrdnanceDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._JettisonOrdnance? jettisonOrdnanceDoctrine;
			if (this.JettisonOrdnanceHasNoValue())
			{
				bool flag = true;
				jettisonOrdnanceDoctrine = this.GetDoctrine(scenario_0, ref flag).GetJettisonOrdnanceDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				jettisonOrdnanceDoctrine = new Doctrine._JettisonOrdnance?(this.JettisonOrdnance.Value);
			}
			return jettisonOrdnanceDoctrine;
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x003273C4 File Offset: 0x003255C4
		public void SetJettisonOrdnanceDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._JettisonOrdnance? doctrine_)
		{
			this.JettisonOrdnance = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x0002C09C File Offset: 0x0002A29C
		public bool JettisonOrdnanceHasNoValue()
		{
			return !this.JettisonOrdnance.HasValue;
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x003273FC File Offset: 0x003255FC
		public bool method_129(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.JettisonOrdnance_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_129(scenario_0);
			}
			return result;
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00327448 File Offset: 0x00325648
		public void method_130(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.JettisonOrdnance_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_130(scenario_0, bool_31);
			}
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00327490 File Offset: 0x00325690
		public Doctrine._AutomaticEvasion? GetAutomaticEvasionDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._AutomaticEvasion? automaticEvasionDoctrine;
			if (this.AutomaticEvasionHasNoValue())
			{
				bool flag = true;
				automaticEvasionDoctrine = this.GetDoctrine(scenario_0, ref flag).GetAutomaticEvasionDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				automaticEvasionDoctrine = new Doctrine._AutomaticEvasion?(this.AutomaticEvasion.Value);
			}
			return automaticEvasionDoctrine;
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x003274D8 File Offset: 0x003256D8
		public void SetAutomaticEvasionDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._AutomaticEvasion? doctrine_)
		{
			this.AutomaticEvasion = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x0002C0AC File Offset: 0x0002A2AC
		public bool AutomaticEvasionHasNoValue()
		{
			return !this.AutomaticEvasion.HasValue;
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00327510 File Offset: 0x00325710
		public bool method_134(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.AE_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_134(scenario_0);
			}
			return result;
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x0032755C File Offset: 0x0032575C
		public void method_135(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.AE_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_135(scenario_0, bool_31);
			}
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x003275A4 File Offset: 0x003257A4
		public Doctrine._MaintainStandoff? GetMaintainStandoffDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._MaintainStandoff? maintainStandoffDoctrine;
			if (this.MaintainStandoffHasNoValue())
			{
				bool flag = true;
				maintainStandoffDoctrine = this.GetDoctrine(scenario_0, ref flag).GetMaintainStandoffDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				maintainStandoffDoctrine = new Doctrine._MaintainStandoff?(this.MaintainStandoff.Value);
			}
			return maintainStandoffDoctrine;
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x003275EC File Offset: 0x003257EC
		public void SetMaintainStandoffDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._MaintainStandoff? doctrine_)
		{
			this.MaintainStandoff = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		public bool MaintainStandoffHasNoValue()
		{
			return !this.MaintainStandoff.HasValue;
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00327624 File Offset: 0x00325824
		public bool method_139(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.MS_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_139(scenario_0);
			}
			return result;
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00327670 File Offset: 0x00325870
		public void method_140(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.MS_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_140(scenario_0, bool_31);
			}
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x003276B8 File Offset: 0x003258B8
		public Doctrine._GunStrafeGroundTargets? GetGunStrafeGroundTargetsDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine;
			if (this.GunStrafeGroundTargetsHasNoValue())
			{
				bool flag = true;
				gunStrafeGroundTargetsDoctrine = this.GetDoctrine(scenario_0, ref flag).GetGunStrafeGroundTargetsDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				gunStrafeGroundTargetsDoctrine = new Doctrine._GunStrafeGroundTargets?(this.GunStrafeGroundTargets.Value);
			}
			return gunStrafeGroundTargetsDoctrine;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00327700 File Offset: 0x00325900
		public void SetGunStrafeGroundTargetsDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._GunStrafeGroundTargets? doctrine_)
		{
			this.GunStrafeGroundTargets = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		public bool GunStrafeGroundTargetsHasNoValue()
		{
			return !this.GunStrafeGroundTargets.HasValue;
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00327738 File Offset: 0x00325938
		public bool method_144(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.GS_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_144(scenario_0);
			}
			return result;
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00327784 File Offset: 0x00325984
		public void method_145(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.GS_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_145(scenario_0, bool_31);
			}
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x003277CC File Offset: 0x003259CC
		public Doctrine._UseRefuel? GetUseRefuelDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			Doctrine._UseRefuel? useRefuelDoctrine;
			if (this.UseRefuelHasNoValue())
			{
				bool flag = true;
				useRefuelDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseRefuelDoctrine(scenario_0, bool_31, bool_32, bool_33, bool_34);
			}
			else
			{
				useRefuelDoctrine = new Doctrine._UseRefuel?(this.UseRefuel.Value);
			}
			return useRefuelDoctrine;
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00327814 File Offset: 0x00325A14
		public void SetUseRefuelDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34, Doctrine._UseRefuel? doctrine_)
		{
			this.UseRefuel = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, bool_34);
			}
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x0002C0DC File Offset: 0x0002A2DC
		public bool UseRefuelHasNoValue()
		{
			return !this.UseRefuel.HasValue;
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00327850 File Offset: 0x00325A50
		public bool method_149(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.UR_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_149(scenario_0);
			}
			return result;
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x0032789C File Offset: 0x00325A9C
		public void method_150(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.UR_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_150(scenario_0, bool_31);
			}
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x003278E4 File Offset: 0x00325AE4
		public Doctrine._RefuelSelection? GetRefuelSelectionDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			Doctrine._RefuelSelection? refuelSelectionDoctrine;
			if (this.RefuelSelectionHasNoValue())
			{
				bool flag = true;
				refuelSelectionDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRefuelSelectionDoctrine(scenario_0, bool_31, bool_32, bool_33, bool_34);
			}
			else
			{
				refuelSelectionDoctrine = new Doctrine._RefuelSelection?(this.RefuelSelection.Value);
			}
			return refuelSelectionDoctrine;
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x0032792C File Offset: 0x00325B2C
		public void SetRefuelSelectionDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34, Doctrine._RefuelSelection? nullable_38)
		{
			this.RefuelSelection = nullable_38;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, bool_34);
			}
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x0002C0EC File Offset: 0x0002A2EC
		public bool RefuelSelectionHasNoValue()
		{
			return !this.RefuelSelection.HasValue;
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x00327968 File Offset: 0x00325B68
		public bool method_154(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.RS_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_154(scenario_0);
			}
			return result;
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x003279B4 File Offset: 0x00325BB4
		public void method_155(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.RS_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_155(scenario_0, bool_31);
			}
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x003279FC File Offset: 0x00325BFC
		public Doctrine._ShootTourists? GetShootTouristsDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._ShootTourists? shootTouristsDoctrine;
			if (this.ShootTouristsHasNoValue())
			{
				bool flag = true;
				shootTouristsDoctrine = this.GetDoctrine(scenario_0, ref flag).GetShootTouristsDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				shootTouristsDoctrine = new Doctrine._ShootTourists?(this.ShootTourists.Value);
			}
			return shootTouristsDoctrine;
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x00327A44 File Offset: 0x00325C44
		public void SetShootTouristsDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._ShootTourists? nullable_38)
		{
			this.ShootTourists = nullable_38;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x0002C0FC File Offset: 0x0002A2FC
		public bool ShootTouristsHasNoValue()
		{
			return !this.ShootTourists.HasValue;
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x00327A7C File Offset: 0x00325C7C
		public bool method_159(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.ST_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_159(scenario_0);
			}
			return result;
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x00327AC8 File Offset: 0x00325CC8
		public void method_160(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.ST_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_160(scenario_0, bool_31);
			}
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x00327B10 File Offset: 0x00325D10
		public Doctrine._UseSAMsInASuWMode? GetUseSAMsInASuWModeDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._UseSAMsInASuWMode? useSAMsInASuWModeDoctrine;
			if (this.SAM_ASUWHasNoValue())
			{
				bool flag = true;
				useSAMsInASuWModeDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseSAMsInASuWModeDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				useSAMsInASuWModeDoctrine = new Doctrine._UseSAMsInASuWMode?(this.SAM_ASUW.Value);
			}
			return useSAMsInASuWModeDoctrine;
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00327B58 File Offset: 0x00325D58
		public void SetUseSAMsInASuWModeDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._UseSAMsInASuWMode? doctrine_)
		{
			this.SAM_ASUW = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x0002C10C File Offset: 0x0002A30C
		public bool SAM_ASUWHasNoValue()
		{
			return !this.SAM_ASUW.HasValue;
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x00327B90 File Offset: 0x00325D90
		public bool method_164(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.SAM_ASUW_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_164(scenario_0);
			}
			return result;
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x00327BDC File Offset: 0x00325DDC
		public void method_165(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.SAM_ASUW_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_165(scenario_0, bool_31);
			}
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x00327C24 File Offset: 0x00325E24
		public Doctrine._IgnoreEMCONUnderAttack? GetIgnoreEMCONUnderAttackDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttackDoctrine;
			if (this.IgnoreEMCONUnderAttackHasNoValue())
			{
				bool flag = true;
				ignoreEMCONUnderAttackDoctrine = this.GetDoctrine(scenario_0, ref flag).GetIgnoreEMCONUnderAttackDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				ignoreEMCONUnderAttackDoctrine = new Doctrine._IgnoreEMCONUnderAttack?(this.IgnoreEMCONUnderAttack.Value);
			}
			return ignoreEMCONUnderAttackDoctrine;
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x00327C6C File Offset: 0x00325E6C
		public void SetIgnoreEMCONUnderAttackDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._IgnoreEMCONUnderAttack? doctrine_)
		{
			this.IgnoreEMCONUnderAttack = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x0002C11C File Offset: 0x0002A31C
		public bool IgnoreEMCONUnderAttackHasNoValue()
		{
			return !this.IgnoreEMCONUnderAttack.HasValue;
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00327CA4 File Offset: 0x00325EA4
		public bool method_169(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.IgnoreEMCONUnderAttack_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_169(scenario_0);
			}
			return result;
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x00327CF0 File Offset: 0x00325EF0
		public void method_170(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.IgnoreEMCONUnderAttack_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_170(scenario_0, bool_31);
			}
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x00327D38 File Offset: 0x00325F38
		public void SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36 enum36_0, Scenario scenario_0)
		{
			if (this.EMCON_SettingsHasNoValue())
			{
				this.m_EMCON_Settings = new Doctrine.EMCON_Settings(enum36_0, this.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar(), this.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM());
			}
			else
			{
				this.m_EMCON_Settings = new Doctrine.EMCON_Settings(enum36_0, this.m_EMCON_Settings.GetEMCON_SettingsForSonar(), this.m_EMCON_Settings.GetEMCON_SettingsForOECM());
			}
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x00327D98 File Offset: 0x00325F98
		public void SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36 enum36_0, Scenario scenario_0)
		{
			if (this.EMCON_SettingsHasNoValue())
			{
				this.m_EMCON_Settings = new Doctrine.EMCON_Settings(this.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar(), enum36_0, this.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM());
			}
			else
			{
				this.m_EMCON_Settings = new Doctrine.EMCON_Settings(this.m_EMCON_Settings.GetEMCON_SettingsForRadar(), enum36_0, this.m_EMCON_Settings.GetEMCON_SettingsForOECM());
			}
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x00327DF8 File Offset: 0x00325FF8
		public void method_173(Doctrine.EMCON_Settings.Enum36 enum36_0, Scenario scenario_0)
		{
			if (this.EMCON_SettingsHasNoValue())
			{
				this.m_EMCON_Settings = new Doctrine.EMCON_Settings(this.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar(), this.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar(), enum36_0);
			}
			else
			{
				this.m_EMCON_Settings = new Doctrine.EMCON_Settings(this.m_EMCON_Settings.GetEMCON_SettingsForRadar(), this.m_EMCON_Settings.GetEMCON_SettingsForSonar(), enum36_0);
			}
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x0002C12C File Offset: 0x0002A32C
		public void method_174(Doctrine.EMCON_Settings.Enum36 enum36_0, Doctrine.EMCON_Settings.Enum36 enum36_1, Doctrine.EMCON_Settings.Enum36 enum36_2)
		{
			this.m_EMCON_Settings = new Doctrine.EMCON_Settings(enum36_0, enum36_1, enum36_2);
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00327E58 File Offset: 0x00326058
		public Doctrine._QuickTurnAround? GetQuickTurnAroundDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			if (!bool_32)
			{
				this.Init();
			}
			Doctrine._QuickTurnAround? result;
			if (this.QuickTurnAroundHasNoValue())
			{
				Doctrine._QuickTurnAround? quickTurnAroundDoctrine = this.GetDoctrine(scenario_0, ref bool_32).GetQuickTurnAroundDoctrine(scenario_0, bool_31, true, bool_33, bool_34);
				if (!bool_32)
				{
					this.Init();
				}
				result = quickTurnAroundDoctrine;
			}
			else
			{
				result = new Doctrine._QuickTurnAround?(this.QuickTurnAround.Value);
			}
			return result;
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00327EB4 File Offset: 0x003260B4
		public void SetQuickTurnAroundDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34, Doctrine._QuickTurnAround? value)
		{
			this.QuickTurnAround = value;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_33, bool_34, false);
			}
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x0002C13C File Offset: 0x0002A33C
		public bool QuickTurnAroundHasNoValue()
		{
			return !this.QuickTurnAround.HasValue;
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x00327EF0 File Offset: 0x003260F0
		public bool method_178(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.QTA_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_178(scenario_0);
			}
			return result;
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00327F3C File Offset: 0x0032613C
		public void method_179(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.QTA_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_179(scenario_0, bool_31);
			}
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x00327F84 File Offset: 0x00326184
		public Doctrine._AirOpsTempo? GetAirOpsTempoDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			if (!bool_32)
			{
				this.Init();
			}
			Doctrine._AirOpsTempo? result;
			if (this.AirOpsTempoHasNoValue())
			{
				Doctrine._AirOpsTempo? airOpsTempoDoctrine = this.GetDoctrine(scenario_0, ref bool_32).GetAirOpsTempoDoctrine(scenario_0, bool_31, true, bool_33, bool_34);
				if (!bool_32)
				{
					this.Init();
				}
				result = airOpsTempoDoctrine;
			}
			else
			{
				result = new Doctrine._AirOpsTempo?(this.AirOpsTempo.Value);
			}
			return result;
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x00327FE0 File Offset: 0x003261E0
		public void SetAirOpsTempoDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34, Doctrine._AirOpsTempo? doctrine_)
		{
			this.AirOpsTempo = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_33, bool_34, false);
			}
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x0002C14C File Offset: 0x0002A34C
		public bool AirOpsTempoHasNoValue()
		{
			return !this.AirOpsTempo.HasValue;
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x0032801C File Offset: 0x0032621C
		public bool method_183(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.AirOpsTempo_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_183(scenario_0);
			}
			return result;
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00328068 File Offset: 0x00326268
		public void method_184(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.AirOpsTempo_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_184(scenario_0, bool_31);
			}
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x003280B0 File Offset: 0x003262B0
		public Doctrine._FuelState? GetBingoJokerDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			Doctrine._FuelState? bingoJokerDoctrine;
			if (this.BingoJokerHasNoValue())
			{
				bingoJokerDoctrine = this.GetDoctrine(scenario_0, ref bool_32).GetBingoJokerDoctrine(scenario_0, bool_31, true, bool_33, bool_34);
			}
			else
			{
				bingoJokerDoctrine = new Doctrine._FuelState?(this.BingoJoker.Value);
			}
			return bingoJokerDoctrine;
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x003280F8 File Offset: 0x003262F8
		public void SetBingoJokerDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34, Doctrine._FuelState? FuelState_)
		{
			this.BingoJoker = FuelState_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_33, bool_34, false);
			}
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x0002C15C File Offset: 0x0002A35C
		public bool BingoJokerHasNoValue()
		{
			return !this.BingoJoker.HasValue;
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x00328134 File Offset: 0x00326334
		public bool method_188(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.BingoJoker_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_188(scenario_0);
			}
			return result;
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x00328180 File Offset: 0x00326380
		public void method_189(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.BingoJoker_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_189(scenario_0, bool_31);
			}
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x003281C8 File Offset: 0x003263C8
		public Doctrine._WeaponState? GetWinchesterShotgunDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34)
		{
			Doctrine._WeaponState? winchesterShotgunDoctrine;
			if (this.WinchesterShotgunHasNoValue())
			{
				winchesterShotgunDoctrine = this.GetDoctrine(scenario_0, ref bool_32).GetWinchesterShotgunDoctrine(scenario_0, bool_31, true, bool_33, bool_34);
			}
			else
			{
				winchesterShotgunDoctrine = new Doctrine._WeaponState?(this.WinchesterShotgun.Value);
			}
			return winchesterShotgunDoctrine;
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x00328210 File Offset: 0x00326410
		public void SetWinchesterShotgunDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, bool bool_34, Doctrine._WeaponState? doctrine_)
		{
			this.WinchesterShotgun = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_33, bool_34, false);
			}
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0002C16C File Offset: 0x0002A36C
		public bool WinchesterShotgunHasNoValue()
		{
			return !this.WinchesterShotgun.HasValue;
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x0032824C File Offset: 0x0032644C
		public bool method_193(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.WinchesterShotgun_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_193(scenario_0);
			}
			return result;
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x00328298 File Offset: 0x00326498
		public void method_194(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.WinchesterShotgun_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_194(scenario_0, bool_31);
			}
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x003282E0 File Offset: 0x003264E0
		public Doctrine._UseTorpedoesKinematicRange? GetUseTorpedoesKinematicRangeDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRangeDoctrine;
			if (this.UseTorpedoesKinematicRangeHasNoValue())
			{
				bool flag = true;
				useTorpedoesKinematicRangeDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseTorpedoesKinematicRangeDoctrine(scenario_0, bool_31, bool_32, bool_33);
			}
			else
			{
				useTorpedoesKinematicRangeDoctrine = new Doctrine._UseTorpedoesKinematicRange?(this.UseTorpedoesKinematicRange.Value);
			}
			return useTorpedoesKinematicRangeDoctrine;
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00328328 File Offset: 0x00326528
		public void SetUseTorpedoesKinematicRangeDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._UseTorpedoesKinematicRange? doctrine_)
		{
			this.UseTorpedoesKinematicRange = doctrine_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x0002C17C File Offset: 0x0002A37C
		public bool UseTorpedoesKinematicRangeHasNoValue()
		{
			return !this.UseTorpedoesKinematicRange.HasValue;
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00328360 File Offset: 0x00326560
		public bool method_198(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.UseTorpedoesKinematicRange_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).method_198(scenario_0);
			}
			return result;
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x003283AC File Offset: 0x003265AC
		public void method_199(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.UseTorpedoesKinematicRange_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).method_199(scenario_0, bool_31);
			}
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x003283F4 File Offset: 0x003265F4
		public void method_200(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_31)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num = null;
			int? num2 = null;
			int? num3 = null;
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType;
			checked
			{
				foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
				{
					int arg_9B_0 = current.Key;
					Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
					for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
					{
						Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
						if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
						{
							num = wRA_WeaponTarget.WeaponQty;
							break;
						}
					}
				}
				if (!bool_31)
				{
					if (this.subject.GetType() != typeof(Side))
					{
						this.GetWeaponQty(weapon_0.m_Scenario, weapon_0, _WRA_WeaponTargetType_0, true, ref num2, ref num3);
					}
					else if (!this.method_32(ref _WRA_WeaponTargetType_0))
					{
						Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref _WRA_WeaponTargetType_0);
						num3 = this.GetQtyByWeapon(weapon_0.m_Scenario, weapon_0, wRA_WeaponTargetType_);
					}
				}
				wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
			}
			if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2)
						{
							goto IL_1EAC;
						}
					}
					else if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4)
					{
						goto IL_1EAC;
					}
				}
				else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
				{
					if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
					{
						if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
						{
							if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
							{
								goto IL_1EAC;
							}
							goto IL_135E;
						}
						else
						{
							if (this.subject.GetType() != typeof(Side))
							{
								if (Information.IsNothing(num))
								{
									if (Information.IsNothing(num2) && Information.IsNothing(num3))
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"与上级一致"
										});
									}
									else if (Information.IsNothing(num2))
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"与上级一致, " + this.method_215(num3, !Information.IsNothing(num3))
										});
									}
									else if (!Information.IsNothing(num2))
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"与上级一致, " + this.method_215(num, !Information.IsNothing(num3))
										});
									}
								}
								else if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致"
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
									});
								}
							}
							if (!Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"系统缺省"
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"系统缺省, " + this.method_215(num, false)
									});
								}
							}
							else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"未配置"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"未配置, " + this.method_215(num3, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"未配置, " + this.method_215(num, !Information.IsNothing(num3))
									});
								}
							}
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"不要对该目标类型使用武器"
							});
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"1发"
							});
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"2发"
							});
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"对目标使用所有武器"
							});
							if (int_0 == this.method_208(ref _WRA_WeaponTargetType_0, new int?(-100)))
							{
								dataTable_0.Rows.Add(new object[]
								{
									6,
									"Various settings"
								});
								return;
							}
							return;
						}
					}
				}
				else
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Unspecified > 4 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
					{
						goto IL_1EAC;
					}
					goto IL_C4D;
				}
				if (this.subject.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_215(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_215(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省, " + this.method_215(num, false)
						});
					}
				}
				else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified)
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_215(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_215(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"不要对该目标类型使用武器"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"1发(较易攻击目标或红外制导武器)"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"2发(非合作目标)"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"3发(极难对付的目标，很少使用)"
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"对目标使用所有武器"
				});
				if (int_0 == this.method_208(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						7,
						"Various settings"
					});
					return;
				}
				return;
			}
			else
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons <= 7 || wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons <= 7 || wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							goto IL_C4D;
						}
						goto IL_1EAC;
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
					{
						switch (wRA_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
							goto IL_135E;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
							break;
						case (Doctrine._WRA_WeaponTargetType)5003:
						case (Doctrine._WRA_WeaponTargetType)5004:
						case (Doctrine._WRA_WeaponTargetType)5007:
						case (Doctrine._WRA_WeaponTargetType)5008:
						case (Doctrine._WRA_WeaponTargetType)5009:
						case (Doctrine._WRA_WeaponTargetType)5010:
							goto IL_1EAC;
						default:
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
							{
								goto IL_1EAC;
							}
							break;
						}
					}
					else
					{
						if (this.subject.GetType() != typeof(Side))
						{
							if (Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_215(num3, !Information.IsNothing(num3))
									});
								}
								else if (!Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_215(num, !Information.IsNothing(num3))
									});
								}
							}
							else if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"与上级一致"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
								});
							}
						}
						if (!Information.IsNothing(num))
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"系统缺省"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"系统缺省, " + this.method_215(num, false)
								});
							}
						}
						else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Submarine_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type)
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置"
								});
							}
							else if (Information.IsNothing(num2))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置, " + this.method_215(num3, !Information.IsNothing(num3))
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置, " + this.method_215(num, !Information.IsNothing(num3))
								});
							}
						}
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"不要对该目标类型使用武器"
						});
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"1发"
						});
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"2发"
						});
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"3发"
						});
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"4发"
						});
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"对目标使用所有武器"
						});
						if (int_0 == this.method_208(ref _WRA_WeaponTargetType_0, new int?(-100)))
						{
							dataTable_0.Rows.Add(new object[]
							{
								8,
								"Various settings"
							});
							return;
						}
						return;
					}
				}
				else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
					{
						goto IL_1EAC;
					}
				}
				else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					goto IL_1EAC;
				}
				if (this.subject.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_215(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_215(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省, " + this.method_215(num, false)
						});
					}
				}
				else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Underwater_Structure && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_215(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_215(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"不要对该目标类型使用武器"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"使用目标导弹防御值相同的武器数"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"使用目标导弹防御值2倍的武器数"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"使用目标导弹防御值4倍的武器数"
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"使用目标导弹防御值1/2的武器数"
				});
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"使用目标导弹防御值1/4的武器数"
				});
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"1发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					9,
					"2发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					10,
					"3发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					11,
					"4发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"5发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					13,
					"6发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					14,
					"7发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					15,
					"8发"
				});
				dataTable_0.Rows.Add(new object[]
				{
					16,
					"对目标使用所有武器"
				});
				if (int_0 == this.method_208(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						17,
						"Various settings"
					});
					return;
				}
				return;
			}
			IL_C4D:
			if (this.subject.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省, " + this.method_215(num, false)
					});
				}
			}
			else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Ship_Unspecified)
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_215(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_215(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"不要对该目标类型使用武器"
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				"使用目标导弹防御值相同的武器数"
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				"使用目标导弹防御值2倍的武器数"
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				"使用目标导弹防御值4倍的武器数"
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				"使用目标导弹防御值1/2的武器数"
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				"使用目标导弹防御值1/4的武器数"
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				"1发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				"2发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				"3发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				"4发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				12,
				"5发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				13,
				"6发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				14,
				"7发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				15,
				"8发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				16,
				"对目标使用所有武器"
			});
			if (int_0 == this.method_208(ref _WRA_WeaponTargetType_0, new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					17,
					"Various settings"
				});
				return;
			}
			return;
			IL_135E:
			if (this.subject.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_215(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致, " + this.method_215(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省, " + this.method_215(num, false)
					});
				}
			}
			else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type)
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_215(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_215(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"不要对该目标类型使用武器"
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				"1发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				"2发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				"3发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				"4发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				"5发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				"6发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				"7发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				"8发"
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				"对目标使用所有武器"
			});
			if (int_0 == this.method_208(ref _WRA_WeaponTargetType_0, new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"Various settings"
				});
				return;
			}
			return;
			IL_1EAC:
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Not implemented"
			});
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x0032A9C0 File Offset: 0x00328BC0
		public void method_201(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_31)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num = null;
			checked
			{
				foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
				{
					int arg_8A_0 = current.Key;
					Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
					for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
					{
						Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
						if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
						{
							num = wRA_WeaponTarget.ShooterQty;
							break;
						}
					}
				}
				int? num2 = null;
				int? num3 = null;
				if (!bool_31)
				{
					if (this.subject.GetType() != typeof(Side))
					{
						this.GetShooterQty(weapon_0.m_Scenario, weapon_0, _WRA_WeaponTargetType_0, true, ref num2, ref num3);
					}
					else if (!this.method_32(ref _WRA_WeaponTargetType_0))
					{
						Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref _WRA_WeaponTargetType_0);
						num3 = this.GetInheritedShooterQty(weapon_0.m_Scenario, weapon_0, wRA_WeaponTargetType_);
					}
				}
				if (this.subject.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_216(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_216(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_216(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_216(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省, " + this.method_216(num, false)
						});
					}
				}
				else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified)
				{
					if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_216(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_216(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"开火的作战单元数满足齐射武器数量需求"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"1个作战单元"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"2个作战单元"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"4个作战单元"
				});
				if (int_0 == this.method_210(new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various settings"
					});
				}
			}
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x0032B00C File Offset: 0x0032920C
		public void method_202(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_31)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num = null;
			int? num2 = null;
			int? num3 = null;
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType;
			checked
			{
				foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
				{
					int arg_9B_0 = current.Key;
					Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
					for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
					{
						Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
						if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
						{
							num = wRA_WeaponTarget.SelfDefenceRange;
							break;
						}
					}
				}
				if (!bool_31)
				{
					if (this.subject.GetType() != typeof(Side))
					{
						this.method_19(weapon_0.m_Scenario, weapon_0, _WRA_WeaponTargetType_0, true, ref num2, ref num3);
					}
					else if (!this.method_32(ref _WRA_WeaponTargetType_0))
					{
						Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref _WRA_WeaponTargetType_0);
						num3 = this.method_20(weapon_0.m_Scenario, weapon_0, wRA_WeaponTargetType_);
					}
				}
				wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
			}
			if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
						{
							goto IL_17A6;
						}
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						goto IL_17A6;
					}
				}
				else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
					{
						if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
						{
							goto IL_17A6;
						}
						if (this.subject.GetType() != typeof(Side))
						{
							if (Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_217(num3, !Information.IsNothing(num3))
									});
								}
								else if (!Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_217(num, !Information.IsNothing(num3))
									});
								}
							}
							else if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"与上级一致"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
								});
							}
						}
						if (!Information.IsNothing(num))
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"系统缺省"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"系统缺省, " + this.method_217(num, false)
								});
							}
						}
						else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
						{
							if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置"
								});
							}
							else if (Information.IsNothing(num2))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置, " + this.method_217(num3, !Information.IsNothing(num3))
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置, " + this.method_217(num, !Information.IsNothing(num3))
								});
							}
						}
						if (int_0 == this.method_212(ref _WRA_WeaponTargetType_0, new int?(-100)))
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Various settings"
							});
							return;
						}
						return;
					}
				}
				else
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
					{
						goto IL_17A6;
					}
					goto IL_C05;
				}
				if (this.subject.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_217(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_217(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省, " + this.method_217(num, false)
						});
					}
				}
				else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified)
				{
					if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_217(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_217(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"武器不用于自防御"
				});
				if (weapon_0.RangeAAWMax > 2f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						" 2海里"
					});
				}
				if (weapon_0.RangeAAWMax > 5f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						" 5海里"
					});
				}
				if (weapon_0.RangeAAWMax > 10f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"10海里"
					});
				}
				if (weapon_0.RangeAAWMax > 15f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"15海里"
					});
				}
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"最大射程"
				});
				if (int_0 == this.method_212(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various settings"
					});
					return;
				}
				return;
			}
			else
			{
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons <= 7 || wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons <= 7 || wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							goto IL_C05;
						}
						goto IL_17A6;
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
					{
						switch (wRA_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
							break;
						case (Doctrine._WRA_WeaponTargetType)5003:
						case (Doctrine._WRA_WeaponTargetType)5004:
						case (Doctrine._WRA_WeaponTargetType)5007:
						case (Doctrine._WRA_WeaponTargetType)5008:
						case (Doctrine._WRA_WeaponTargetType)5009:
						case (Doctrine._WRA_WeaponTargetType)5010:
							goto IL_17A6;
						default:
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
							{
								goto IL_17A6;
							}
							break;
						}
					}
					else
					{
						if (this.subject.GetType() != typeof(Side))
						{
							if (Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_217(num3, !Information.IsNothing(num3))
									});
								}
								else if (!Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"与上级一致, " + this.method_217(num, !Information.IsNothing(num3))
									});
								}
							}
							else if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"与上级一致"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
								});
							}
						}
						if (!Information.IsNothing(num))
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"系统缺省"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"系统缺省, " + this.method_217(num, false)
								});
							}
						}
						else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Submarine_Unspecified)
						{
							if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置"
								});
							}
							else if (Information.IsNothing(num2))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置, " + this.method_217(num3, !Information.IsNothing(num3))
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"未配置, " + this.method_217(num, !Information.IsNothing(num3))
								});
							}
						}
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"不要将武器用于自防御"
						});
						if (weapon_0.RangeASWMax > 2f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								" 2海里"
							});
						}
						if (weapon_0.RangeASWMax > 5f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								" 5海里"
							});
						}
						if (weapon_0.RangeASWMax > 10f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"10海里"
							});
						}
						if (weapon_0.RangeASWMax > 15f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								6,
								"15海里"
							});
						}
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"最大射程"
						});
						if (int_0 == this.method_212(ref _WRA_WeaponTargetType_0, new int?(-100)))
						{
							dataTable_0.Rows.Add(new object[]
							{
								8,
								"Various settings"
							});
							return;
						}
						return;
					}
				}
				else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
				{
					if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
					{
						goto IL_17A6;
					}
				}
				else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					goto IL_17A6;
				}
				if (this.subject.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_217(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"与上级一致, " + this.method_217(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"系统缺省, " + this.method_217(num, false)
						});
					}
				}
				else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Underwater_Structure && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
				{
					if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_217(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"未配置, " + this.method_217(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"不要将武器用于自防御"
				});
				if (weapon_0.RangeLandMax > 2f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						" 2海里"
					});
				}
				if (weapon_0.RangeLandMax > 5f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						" 5海里"
					});
				}
				if (weapon_0.RangeLandMax > 10f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"10海里"
					});
				}
				if (weapon_0.RangeLandMax > 15f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"15海里"
					});
				}
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"最大射程"
				});
				if (int_0 == this.method_212(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various settings"
					});
					return;
				}
				return;
			}
			IL_C05:
			if (this.subject.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_217(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_217(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致, " + this.method_217(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.subject.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省, " + this.method_217(num, false)
					});
				}
			}
			else if (this.subject.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Ship_Unspecified)
			{
				if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_217(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_217(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"不要将武器用于自防御"
			});
			if (weapon_0.RangeASUWMax > 2f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					3,
					" 2海里"
				});
			}
			if (weapon_0.RangeASUWMax > 5f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					" 5海里"
				});
			}
			if (weapon_0.RangeASUWMax > 10f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"10海里"
				});
			}
			if (weapon_0.RangeASUWMax > 15f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"15海里"
				});
			}
			dataTable_0.Rows.Add(new object[]
			{
				7,
				"最大射程"
			});
			if (int_0 == this.method_212(ref _WRA_WeaponTargetType_0, new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"Various settings"
				});
				return;
			}
			return;
			IL_17A6:
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Not implemented"
			});
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x0032CDA0 File Offset: 0x0032AFA0
		public void method_203(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_31)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num = null;
			int? num2 = null;
			int? num3 = null;
			if (!bool_31)
			{
				if (this.subject.GetType() != typeof(Side))
				{
					this.GetFiringRange(weapon_0.m_Scenario, weapon_0.DBID, _WRA_WeaponTargetType_0, true, ref num, ref num2);
				}
				else if (!this.method_32(ref _WRA_WeaponTargetType_0))
				{
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = this.GetWRA_WeaponTargetType(ref _WRA_WeaponTargetType_0);
					num2 = this.method_25(weapon_0.m_Scenario, weapon_0.DBID, wRA_WeaponTargetType_);
				}
				else
				{
					num3 = new int?(-99);
				}
				if (Information.IsNothing(num2))
				{
					num2 = new int?(-99);
				}
			}
			if (this.subject.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num3))
				{
					if (Information.IsNothing(num) && Information.IsNothing(num2) && bool_31)
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致"
						});
					}
					else if (Information.IsNothing(num))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_218(num2, !Information.IsNothing(num2))
						});
					}
					else if (!Information.IsNothing(num))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_218(num, !Information.IsNothing(num2))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"与上级一致, " + this.method_218(num3, !Information.IsNothing(num2))
						});
					}
				}
				else if (Information.IsNothing(num) && Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"与上级一致, " + this.method_218(num, !Information.IsNothing(num2))
					});
				}
			}
			if (!Information.IsNothing(num3))
			{
				if (!Information.IsNothing(num) && !Information.IsNothing(num2) && this.subject.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省，最大射程自动开火"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"系统缺省, " + this.method_218(num3, !Information.IsNothing(num2))
					});
				}
			}
			else if (this.subject.GetType() == typeof(Side))
			{
				if (Information.IsNothing(num) && Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置"
					});
				}
				else if (!Information.IsNothing(num))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_218(num, !Information.IsNothing(num2))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"未配置, " + this.method_218(num2, !Information.IsNothing(num2))
					});
				}
			}
			else
			{
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"最大射程自动开火"
				});
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"不自动开火"
			});
			float largestRangeMaxOfAllDomains = weapon_0.GetLargestRangeMaxOfAllDomains();
			float largestRangeMinOfAllDomains = weapon_0.GetLargestRangeMinOfAllDomains();
			if (largestRangeMaxOfAllDomains > 2f && largestRangeMinOfAllDomains < 2f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					3,
					" 2海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 5f && largestRangeMinOfAllDomains < 5f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					" 5海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 10f && largestRangeMinOfAllDomains < 10f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"10海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 15f && largestRangeMinOfAllDomains < 15f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"15海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 20f && largestRangeMinOfAllDomains < 20f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"20海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 25f && largestRangeMinOfAllDomains < 25f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"25海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 30f && largestRangeMinOfAllDomains < 30f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					9,
					"30海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 35f && largestRangeMinOfAllDomains < 35f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					10,
					"35海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 40f && largestRangeMinOfAllDomains < 40f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					11,
					"40海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 45f && largestRangeMinOfAllDomains < 45f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"45海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 50f && largestRangeMinOfAllDomains < 50f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					13,
					"50海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 60f && largestRangeMinOfAllDomains < 60f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					14,
					"60海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 70f && largestRangeMinOfAllDomains < 70f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					15,
					"70海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 80f && largestRangeMinOfAllDomains < 80f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					16,
					"80海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 90f && largestRangeMinOfAllDomains < 90f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					17,
					"90海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 100f && largestRangeMinOfAllDomains < 100f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					18,
					"100海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 125f && largestRangeMinOfAllDomains < 125f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					19,
					"125海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 150f && largestRangeMinOfAllDomains < 150f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					20,
					"150海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 175f && largestRangeMinOfAllDomains < 175f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					21,
					"175海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 200f && largestRangeMinOfAllDomains < 200f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					22,
					"200海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 250f && largestRangeMinOfAllDomains < 250f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					23,
					"250海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 300f && largestRangeMinOfAllDomains < 300f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					24,
					"300海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 500f && largestRangeMinOfAllDomains < 500f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					25,
					"500海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 750f && largestRangeMinOfAllDomains < 750f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					26,
					"750海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 1000f && largestRangeMinOfAllDomains < 1000f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					27,
					"1000海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 1500f && largestRangeMinOfAllDomains < 1500f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					28,
					"1500海里"
				});
			}
			if (largestRangeMaxOfAllDomains > 2000f && largestRangeMinOfAllDomains < 2000f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					29,
					"2000海里"
				});
			}
			if (int_0 == this.method_214(new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					30,
					"Various settings"
				});
			}
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x0032DA80 File Offset: 0x0032BC80
		public string GetWRA_WeaponTargetTypeString(Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			string text;
			string result;
			if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons)
			{
				if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
				{
					if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Aircraft_AEW)
					{
						switch (_WRA_WeaponTargetType_0)
						{
						case Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type:
							text = "空中目标 - 不明类型";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified:
							text = "飞机 - 未指明";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation:
							text = "飞机 - 第5代战斗机/攻击机[过载/g: 5.0+] (F-22, Eurofighter, Rafale)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_4th_Generation:
							text = "飞机 - 第4代战斗机/攻击机 [过载/g: 4.0-4.9] (F-14, F-15, F-16, MiG-29, Su-27)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_3rd_Generation:
							text = "飞机 - 第3代战斗机/攻击机 [过载/g: 3.0-3.9] (F-4, F-5, MiG-21, MiG-23)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_Less_Capable:
							text = "飞机 - 较落后的战斗机/攻击机[过载/g: 2.0-2.9] (F-111, Lightning, Su-7, MiG-17)";
							result = text;
							return result;
						case (Doctrine._WRA_WeaponTargetType)2005:
						case (Doctrine._WRA_WeaponTargetType)2006:
						case (Doctrine._WRA_WeaponTargetType)2007:
						case (Doctrine._WRA_WeaponTargetType)2008:
						case (Doctrine._WRA_WeaponTargetType)2009:
						case (Doctrine._WRA_WeaponTargetType)2010:
							break;
						case Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers:
							text = "飞机 - 高性能轰炸机 [过载: 2.0+] (B-1B, B-2A, Tu-22M";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Bombers:
							text = "飞机 - 中性能轰炸机 [过载: 1.5-1.9] (B-52, Vulcan, Tu-16)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers:
							text = "飞机 - 低性能轰炸机 [过载: 1.0-1.4] (B-24, Canberra, Tu-95, Bison)";
							result = text;
							return result;
						default:
							switch (_WRA_WeaponTargetType_0)
							{
							case Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW:
								text = "飞机 - 高性能侦察机或电子战飞机[过载: 4.0+]";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Recon_EW:
								text = "飞机 - 中性能侦察机或电子战飞机[过载: 3.0-3.9]";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW:
								text = "飞机 - 低性能侦察机或电子战飞机[过载: 2.0-2.9]";
								result = text;
								return result;
							default:
								if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Aircraft_AEW)
								{
									text = "飞机 - 空中预警与控制机";
									result = text;
									return result;
								}
								break;
							}
							break;
						}
					}
					else
					{
						if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
						{
							text = "直升机 - 未指明";
							result = text;
							return result;
						}
						switch (_WRA_WeaponTargetType_0)
						{
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified:
							text = "制导武器 - 未指明";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming:
							text = "制导武器 - 超声速掠海飞行导弹";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming:
							text = "制导武器 - 亚声速掠海飞行导弹";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic:
							text = "制导武器 - 超声速导弹";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic:
							text = "制导武器 - 亚声速导弹";
							result = text;
							return result;
						default:
							if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
							{
								text = "制导武器 - 弹道导弹";
								result = text;
								return result;
							}
							break;
						}
					}
				}
				else if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons)
				{
					if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
					{
						text = "卫星 - 未指明";
						result = text;
						return result;
					}
					switch (_WRA_WeaponTargetType_0)
					{
					case Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type:
						text = "水面目标 - 未知类型";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Unspecified:
						text = "水面舰艇 - 未指明";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons:
						text = "航空母舰, 0-25000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_25001_45000_tons:
						text = "航空母舰, 25001-45000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_45001_95000_tons:
						text = "航空母舰, 45001-95000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons:
						text = "航空母舰, 95000+吨";
						result = text;
						return result;
					default:
						switch (_WRA_WeaponTargetType_0)
						{
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons:
							text = "水面战斗舰艇, 0-500吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons:
							text = "水面战斗舰艇, 501-1500吨, 小排水量的导弹艇";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons:
							text = "水面战斗舰艇, 1501-5000吨, 小排水量的轻型护卫舰";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_5001_10000_tons:
							text = "水面战斗舰艇, 5001-10000吨, 小排水量的导弹驱逐舰";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_10001_25000_tons:
							text = "水面战斗舰艇, 10001-25000吨, 小排水量的导弹巡洋舰";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_25001_45000_tons:
							text = "水面战斗舰艇, 25001-45000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_45001_95000_tons:
							text = "水面战斗舰艇, 45001-95000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons:
							text = "水面战斗舰艇, 95000+吨";
							result = text;
							return result;
						}
						break;
					}
				}
				else
				{
					switch (_WRA_WeaponTargetType_0)
					{
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons:
						text = "两栖舰, 0-500吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_501_1500_tons:
						text = "两栖舰, 501-1500吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_1501_5000_tons:
						text = "两栖舰, 1501-5000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_5001_10000_tons:
						text = "两栖舰, 5001-10000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_10001_25000_tons:
						text = "两栖舰, 10001-25000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_25001_45000_tons:
						text = "两栖舰, 25001-45000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_45001_95000_tons:
						text = "两栖舰, 45001-95000吨";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons:
						text = "两栖舰, 95000+吨";
						result = text;
						return result;
					default:
						switch (_WRA_WeaponTargetType_0)
						{
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons:
							text = "军辅船, 0-500吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_501_1500_tons:
							text = "军辅船, 501-1500吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_1501_5000_tons:
							text = "军辅船, 1501-5000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_5001_10000_tons:
							text = "军辅船, 5001-10000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_10001_25000_tons:
							text = "军辅船, 10001-25000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_25001_45000_tons:
							text = "军辅船, 25001-45000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_45001_95000_tons:
							text = "军辅船, 45001-95000吨";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons:
							text = "军辅船, 95000+吨";
							result = text;
							return result;
						default:
							switch (_WRA_WeaponTargetType_0)
							{
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons:
								text = "商船/民船, 0-500吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_501_1500_tons:
								text = "商船/民船, 501-1500吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_1501_5000_tons:
								text = "商船/民船, 1501-5000吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_5001_10000_tons:
								text = "商船/民船, 5001-10000吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_10001_25000_tons:
								text = "商船/民船, 10001-25000吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_25001_45000_tons:
								text = "商船/民船, 25001-45000吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_45001_95000_tons:
								text = "商船/民船, 45001-95000吨";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons:
								text = "商船/民船, 95000+吨";
								result = text;
								return result;
							}
							break;
						}
						break;
					}
				}
			}
			else if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Runway_Access_Point)
			{
				if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Submarine_Unspecified)
				{
					if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
					{
						text = "上浮潜艇";
						result = text;
						return result;
					}
					if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type)
					{
						text = "水下目标 - 未知类型";
						result = text;
						return result;
					}
					if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Submarine_Unspecified)
					{
						text = "潜艇 - 未指明";
						result = text;
						return result;
					}
				}
				else
				{
					switch (_WRA_WeaponTargetType_0)
					{
					case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
						text = "地面目标 - 未知类型";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
						text = "地面结构物 - 软 - 未描述";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
						text = "地面结构物 - 软 - 建筑(表面)";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
						text = "地面结构物 - 软 - 建筑(砖石)";
						result = text;
						return result;
					case (Doctrine._WRA_WeaponTargetType)5003:
					case (Doctrine._WRA_WeaponTargetType)5004:
					case (Doctrine._WRA_WeaponTargetType)5007:
					case (Doctrine._WRA_WeaponTargetType)5008:
					case (Doctrine._WRA_WeaponTargetType)5009:
					case (Doctrine._WRA_WeaponTargetType)5010:
						break;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
						text = "地面结构物 - 软 - 结构 (开放)";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
						text = "地面结构物 - 软 - 结构 (砖石)";
						result = text;
						return result;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
						text = "地面结构物 - 软 - Aerostat Moring";
						result = text;
						return result;
					default:
						switch (_WRA_WeaponTargetType_0)
						{
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified:
							text = "地面结构物 - 加固 - 未指明";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface:
							text = "地面结构物 - 加固 - 建筑 (表面)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Reveted:
							text = "地面结构物 - 加固 - 建筑 (砖石)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Bunker:
							text = "地面结构物 - 加固 - 建筑 (掩体)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Underground:
							text = "地面结构物 - 加固 - 建筑 (地下)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Open:
							text = "地面结构物 - 加固 - 结构 (开放)";
							result = text;
							return result;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted:
							text = "地面结构物 - 加固 - 结构 (砖石)";
							result = text;
							return result;
						default:
							switch (_WRA_WeaponTargetType_0)
							{
							case Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified:
								text = "跑道设施 - 未指明";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Runway:
								text = "跑道";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Runway_Grade_Taxiway:
								text = "跑道级滑行道";
								result = text;
								return result;
							case Doctrine._WRA_WeaponTargetType.Runway_Access_Point:
								text = "跑道接入点";
								result = text;
								return result;
							}
							break;
						}
						break;
					}
				}
			}
			else if (_WRA_WeaponTargetType_0 <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
			{
				if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
				{
					text = "雷达 - 未指明";
					result = text;
					return result;
				}
				switch (_WRA_WeaponTargetType_0)
				{
				case Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified:
					text = "移动目标 - 软 - 未指明";
					result = text;
					return result;
				case Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle:
					text = "移动目标 - 软 - 机动平台";
					result = text;
					return result;
				case Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel:
					text = "移动目标 - 软 - 机动人员";
					result = text;
					return result;
				default:
					if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
					{
						text = "移动目标 - 加固 - 未指明";
						result = text;
						return result;
					}
					break;
				}
			}
			else
			{
				if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle)
				{
					text = "移动目标 - 加固 - 机动平台";
					result = text;
					return result;
				}
				if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Underwater_Structure)
				{
					text = "水下结构";
					result = text;
					return result;
				}
				if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					text = "空军基地(一个作战单元的机场)";
					result = text;
					return result;
				}
			}
			text = _WRA_WeaponTargetType_0.ToString();
			result = text;
			return result;
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x0032E218 File Offset: 0x0032C418
		public string method_205(int? nullable_38, ActiveUnit activeUnit_0, Contact contact_0, Weapon weapon_0)
		{
			int? num = nullable_38;
			int? num2 = num;
			string result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
			{
				result = "每次齐射所有武器开火";
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "不要对该目标类型使用武器";
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -2) : null).GetValueOrDefault())
					{
						int? num3 = activeUnit_0.GetSide(false).GetWeaponQuantity(nullable_38, ref activeUnit_0, ref contact_0, ref weapon_0);
						num2 = num3;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							result = (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值相同的武器数)";
						}
						else
						{
							result = (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值相同的武器数)";
						}
					}
					else
					{
						num2 = num;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -3) : null).GetValueOrDefault())
						{
							int? num4 = activeUnit_0.GetSide(false).GetWeaponQuantity(nullable_38, ref activeUnit_0, ref contact_0, ref weapon_0);
							num2 = num4;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								result = (num4.HasValue ? Conversions.ToString(num4.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值2倍的武器数)";
							}
							else
							{
								result = (num4.HasValue ? Conversions.ToString(num4.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值2倍的武器数)";
							}
						}
						else
						{
							num2 = num;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -4) : null).GetValueOrDefault())
							{
								int? num5 = activeUnit_0.GetSide(false).GetWeaponQuantity(nullable_38, ref activeUnit_0, ref contact_0, ref weapon_0);
								num2 = num5;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									result = (num5.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值4倍的武器数)";
								}
								else
								{
									result = (num5.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值4倍的武器数)";
								}
							}
							else
							{
								num2 = num;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -5) : null).GetValueOrDefault())
								{
									int? num6 = activeUnit_0.GetSide(false).GetWeaponQuantity(nullable_38, ref activeUnit_0, ref contact_0, ref weapon_0);
									num2 = num6;
									if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										result = (num6.HasValue ? Conversions.ToString(num6.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值1/2的武器数)";
									}
									else
									{
										result = (num6.HasValue ? Conversions.ToString(num6.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值1/2的武器数)";
									}
								}
								else
								{
									num2 = num;
									if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -6) : null).GetValueOrDefault())
									{
										int? num7 = activeUnit_0.GetSide(false).GetWeaponQuantity(nullable_38, ref activeUnit_0, ref contact_0, ref weapon_0);
										num2 = num7;
										if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											result = (num7.HasValue ? Conversions.ToString(num7.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值1/4的武器数)";
										}
										else
										{
											result = (num7.HasValue ? Conversions.ToString(num7.GetValueOrDefault()) : null) + "x发齐射(使用目标导弹防御值1/4的武器数)";
										}
									}
									else
									{
										num2 = num;
										if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
										{
											result = "未明确";
										}
										else
										{
											num2 = num;
											if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
											{
												int? num8 = activeUnit_0.GetSide(false).GetWeaponQuantity(nullable_38, ref activeUnit_0, ref contact_0, ref weapon_0);
												num2 = num8;
												if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													result = (num8.HasValue ? Conversions.ToString(num8.GetValueOrDefault()) : null) + "x发齐射(系统缺省配置)";
												}
												else
												{
													result = (num8.HasValue ? Conversions.ToString(num8.GetValueOrDefault()) : null) + "x发齐射(系统缺省配置)";
												}
											}
											else
											{
												num2 = num;
												if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
												{
													result = "Various weapon quantities";
												}
												else
												{
													num2 = nullable_38;
													if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														result = nullable_38.ToString() + "x发齐射";
													}
													else
													{
														result = nullable_38.ToString() + "x发齐射";
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x0032E860 File Offset: 0x0032CA60
		public string method_206(int? nullable_38)
		{
			if (Information.IsNothing(nullable_38))
			{
				nullable_38 = new int?(-99);
			}
			int? num = nullable_38;
			int? num2 = num;
			string result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "对该目标类型禁止自动开火，只能人工开火";
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					result = "最大射程发射武器";
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
					{
						result = "未明确";
					}
					else
					{
						num2 = num;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
						{
							result = "Various firing ranges";
						}
						else
						{
							result = (nullable_38.HasValue ? Conversions.ToString(nullable_38.GetValueOrDefault()) : null) + "海里最大开火距离";
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0032E9A8 File Offset: 0x0032CBA8
		public int? GetWeaponsPerSalvo(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref object object_0)
		{
			int? num = null;
			int? result;
			try
			{
				Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2)
							{
								goto IL_5B3;
							}
						}
						else if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4)
						{
							goto IL_5B3;
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
					{
						if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
								{
									goto IL_5B3;
								}
								goto IL_3DE;
							}
							else
							{
								switch (Conversions.ToInteger(object_0))
								{
								case 2:
									num = new int?(0);
									result = num;
									return result;
								case 3:
									num = new int?(1);
									result = num;
									return result;
								case 4:
									num = new int?(2);
									result = num;
									return result;
								case 5:
									num = new int?(-99);
									result = num;
									return result;
								case 6:
									num = new int?(-100);
									result = num;
									return result;
								default:
									num = null;
									result = num;
									return result;
								}
							}
						}
					}
					else
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Unspecified > 4 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_5B3;
						}
						goto IL_22B;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						num = new int?(0);
						result = num;
						return result;
					case 3:
						num = new int?(1);
						result = num;
						return result;
					case 4:
						num = new int?(2);
						result = num;
						return result;
					case 5:
						num = new int?(3);
						result = num;
						return result;
					case 6:
						num = new int?(-99);
						result = num;
						return result;
					case 7:
						num = new int?(-100);
						result = num;
						return result;
					default:
						num = null;
						result = num;
						return result;
					}
				}
				else
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons <= 7 || wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons <= 7 || wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_22B;
							}
							goto IL_5B3;
						}
						else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wRA_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
								goto IL_3DE;
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_5B3;
							default:
								if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_5B3;
								}
								break;
							}
						}
						else
						{
							switch (Conversions.ToInteger(object_0))
							{
							case 2:
								num = new int?(0);
								result = num;
								return result;
							case 3:
								num = new int?(1);
								result = num;
								return result;
							case 4:
								num = new int?(2);
								result = num;
								return result;
							case 5:
								num = new int?(3);
								result = num;
								return result;
							case 6:
								num = new int?(4);
								result = num;
								return result;
							case 7:
								num = new int?(-99);
								result = num;
								return result;
							case 8:
								num = new int?(-100);
								result = num;
								return result;
							default:
								num = null;
								result = num;
								return result;
							}
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_5B3;
						}
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_5B3;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						num = new int?(0);
						result = num;
						return result;
					case 3:
						num = new int?(-2);
						result = num;
						return result;
					case 4:
						num = new int?(-3);
						result = num;
						return result;
					case 5:
						num = new int?(-4);
						result = num;
						return result;
					case 6:
						num = new int?(-5);
						result = num;
						return result;
					case 7:
						num = new int?(-6);
						result = num;
						return result;
					case 8:
						num = new int?(1);
						result = num;
						return result;
					case 9:
						num = new int?(2);
						result = num;
						return result;
					case 10:
						num = new int?(3);
						result = num;
						return result;
					case 11:
						num = new int?(4);
						result = num;
						return result;
					case 12:
						num = new int?(5);
						result = num;
						return result;
					case 13:
						num = new int?(6);
						result = num;
						return result;
					case 14:
						num = new int?(7);
						result = num;
						return result;
					case 15:
						num = new int?(8);
						result = num;
						return result;
					case 16:
						num = new int?(-99);
						result = num;
						return result;
					case 17:
						num = new int?(-100);
						result = num;
						return result;
					default:
						num = null;
						result = num;
						return result;
					}
				}
				IL_22B:
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					num = new int?(0);
					result = num;
					return result;
				case 3:
					num = new int?(-2);
					result = num;
					return result;
				case 4:
					num = new int?(-3);
					result = num;
					return result;
				case 5:
					num = new int?(-4);
					result = num;
					return result;
				case 6:
					num = new int?(-5);
					result = num;
					return result;
				case 7:
					num = new int?(-6);
					result = num;
					return result;
				case 8:
					num = new int?(1);
					result = num;
					return result;
				case 9:
					num = new int?(2);
					result = num;
					return result;
				case 10:
					num = new int?(3);
					result = num;
					return result;
				case 11:
					num = new int?(4);
					result = num;
					return result;
				case 12:
					num = new int?(5);
					result = num;
					return result;
				case 13:
					num = new int?(6);
					result = num;
					return result;
				case 14:
					num = new int?(7);
					result = num;
					return result;
				case 15:
					num = new int?(8);
					result = num;
					return result;
				case 16:
					num = new int?(-99);
					result = num;
					return result;
				case 17:
					num = new int?(-100);
					result = num;
					return result;
				default:
					num = null;
					result = num;
					return result;
				}
				IL_3DE:
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					num = new int?(0);
					result = num;
					return result;
				case 3:
					num = new int?(1);
					result = num;
					return result;
				case 4:
					num = new int?(2);
					result = num;
					return result;
				case 5:
					num = new int?(3);
					result = num;
					return result;
				case 6:
					num = new int?(4);
					result = num;
					return result;
				case 7:
					num = new int?(5);
					result = num;
					return result;
				case 8:
					num = new int?(6);
					result = num;
					return result;
				case 9:
					num = new int?(7);
					result = num;
					return result;
				case 10:
					num = new int?(8);
					result = num;
					return result;
				case 11:
					num = new int?(-99);
					result = num;
					return result;
				case 12:
					num = new int?(-100);
					result = num;
					return result;
				default:
					num = null;
					result = num;
					return result;
				}
				IL_5B3:
				num = new int?(0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101197", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x0032F108 File Offset: 0x0032D308
		public int method_208(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, int? WeaponQty_)
		{
			int num = 0;
			int result;
			try
			{
				Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2)
							{
								goto IL_EE5;
							}
						}
						else if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4)
						{
							goto IL_EE5;
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
					{
						if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
								{
									goto IL_EE5;
								}
								goto IL_960;
							}
							else
							{
								int? num2 = WeaponQty_;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
								{
									num = 1;
									result = 1;
									return result;
								}
								num2 = WeaponQty_;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num = 2;
									result = 2;
									return result;
								}
								num2 = WeaponQty_;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num = 3;
									result = 3;
									return result;
								}
								num2 = WeaponQty_;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									num = 4;
									result = 4;
									return result;
								}
								num2 = WeaponQty_;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
								{
									num = 5;
									result = 5;
									return result;
								}
								num2 = WeaponQty_;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
								{
									num = 6;
									result = 6;
									return result;
								}
								if (this.subject.GetType() == typeof(Side))
								{
									num = 1;
									result = 1;
									return result;
								}
								num = 0;
								result = 0;
								return result;
							}
						}
					}
					else
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Unspecified > 4 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_EE5;
						}
						goto IL_49A;
					}
					int? num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						num = 1;
						result = 1;
						return result;
					}
					num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num = 2;
						result = 2;
						return result;
					}
					num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						num = 3;
						result = 3;
						return result;
					}
					num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						num = 4;
						result = 4;
						return result;
					}
					num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						num = 5;
						result = 5;
						return result;
					}
					num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						num = 6;
						result = 6;
						return result;
					}
					num3 = WeaponQty_;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						num = 7;
						result = 7;
						return result;
					}
					if (this.subject.GetType() == typeof(Side))
					{
						num = 1;
						result = 1;
						return result;
					}
					num = 0;
					result = 0;
					return result;
				}
				else
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons <= 7 || wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons <= 7 || wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_49A;
							}
							goto IL_EE5;
						}
						else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wRA_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
								goto IL_960;
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_EE5;
							default:
								if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_EE5;
								}
								break;
							}
						}
						else
						{
							int? num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								num = 1;
								result = 1;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num = 2;
								result = 2;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								num = 3;
								result = 3;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								num = 4;
								result = 4;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								num = 5;
								result = 5;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								num = 6;
								result = 6;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								num = 7;
								result = 7;
								return result;
							}
							num4 = WeaponQty_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								num = 8;
								result = 8;
								return result;
							}
							if (this.subject.GetType() == typeof(Side))
							{
								num = 1;
								result = 1;
								return result;
							}
							num = 0;
							result = 0;
							return result;
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_EE5;
						}
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_EE5;
					}
					int? num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						num = 1;
						result = 1;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num = 2;
						result = 2;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -2) : null).GetValueOrDefault())
					{
						num = 3;
						result = 3;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -3) : null).GetValueOrDefault())
					{
						num = 4;
						result = 4;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -4) : null).GetValueOrDefault())
					{
						num = 5;
						result = 5;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -5) : null).GetValueOrDefault())
					{
						num = 6;
						result = 6;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -6) : null).GetValueOrDefault())
					{
						num = 7;
						result = 7;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						num = 8;
						result = 8;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						num = 9;
						result = 9;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						num = 10;
						result = 10;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 4) : null).GetValueOrDefault())
					{
						num = 11;
						result = 11;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 5) : null).GetValueOrDefault())
					{
						num = 12;
						result = 12;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 6) : null).GetValueOrDefault())
					{
						num = 13;
						result = 13;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 7) : null).GetValueOrDefault())
					{
						num = 14;
						result = 14;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 8) : null).GetValueOrDefault())
					{
						num = 15;
						result = 15;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						num = 16;
						result = 16;
						return result;
					}
					num5 = WeaponQty_;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						num = 17;
						result = 17;
						return result;
					}
					if (this.subject.GetType() == typeof(Side))
					{
						num = 1;
						result = 1;
						return result;
					}
					num = 0;
					result = 0;
					return result;
				}
				IL_49A:
				int? num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					num = 1;
					result = 1;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = 2;
					result = 2;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -2) : null).GetValueOrDefault())
				{
					num = 3;
					result = 3;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -3) : null).GetValueOrDefault())
				{
					num = 4;
					result = 4;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -4) : null).GetValueOrDefault())
				{
					num = 5;
					result = 5;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -5) : null).GetValueOrDefault())
				{
					num = 6;
					result = 6;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -6) : null).GetValueOrDefault())
				{
					num = 7;
					result = 7;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					num = 8;
					result = 8;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					num = 9;
					result = 9;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					num = 10;
					result = 10;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					num = 11;
					result = 11;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					num = 12;
					result = 12;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					num = 13;
					result = 13;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					num = 14;
					result = 14;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 8) : null).GetValueOrDefault())
				{
					num = 15;
					result = 15;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					num = 16;
					result = 16;
					return result;
				}
				num6 = WeaponQty_;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					num = 17;
					result = 17;
					return result;
				}
				if (this.subject.GetType() == typeof(Side))
				{
					num = 1;
					result = 1;
					return result;
				}
				num = 0;
				result = 0;
				return result;
				IL_960:
				int? num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					num = 1;
					result = 1;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = 2;
					result = 2;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					num = 3;
					result = 3;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					num = 4;
					result = 4;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					num = 5;
					result = 5;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					num = 6;
					result = 6;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					num = 7;
					result = 7;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					num = 8;
					result = 8;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					num = 9;
					result = 9;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 8) : null).GetValueOrDefault())
				{
					num = 10;
					result = 10;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					num = 11;
					result = 11;
					return result;
				}
				num7 = WeaponQty_;
				if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					num = 12;
					result = 12;
					return result;
				}
				if (this.subject.GetType() == typeof(Side))
				{
					num = 1;
					result = 1;
					return result;
				}
				num = 0;
				result = 0;
				return result;
				IL_EE5:
				num = 0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101198", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x003304B4 File Offset: 0x0032E6B4
		public int? GetShootersPerSalvo(ref object object_0)
		{
			int? result = null;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					result = new int?(-99);
					break;
				case 3:
					result = new int?(1);
					break;
				case 4:
					result = new int?(2);
					break;
				case 5:
					result = new int?(4);
					break;
				case 6:
					result = new int?(-100);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101212", "");
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

		// Token: 0x0600653E RID: 25918 RVA: 0x00330580 File Offset: 0x0032E780
		public int method_210(int? nullable_38)
		{
			int result = 0;
			try
			{
				int? num = nullable_38;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					result = 1;
				}
				else
				{
					num = nullable_38;
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						result = 2;
					}
					else
					{
						num = nullable_38;
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							result = 3;
						}
						else
						{
							num = nullable_38;
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								result = 4;
							}
							else
							{
								num = nullable_38;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									result = 5;
								}
								else
								{
									num = nullable_38;
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
									{
										result = 6;
									}
									else if (this.subject.GetType() == typeof(Side))
									{
										result = 1;
									}
									else
									{
										result = 0;
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
				ex2.Data.Add("Error at 101213", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x00330768 File Offset: 0x0032E968
		public int? GetSelfDefenceRange(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref object object_0)
		{
			int? num = null;
			int? result;
			try
			{
				Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
							{
								goto IL_3F3;
							}
						}
						else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
						{
							goto IL_3F3;
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								goto IL_3F3;
							}
							int num2 = Conversions.ToInteger(object_0);
							if (num2 == 2)
							{
								num = new int?(0);
								result = num;
								return result;
							}
							if (num2 != 3)
							{
								num = null;
								result = num;
								return result;
							}
							num = new int?(-100);
							result = num;
							return result;
						}
					}
					else
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_3F3;
						}
						goto IL_1F4;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						num = new int?(0);
						result = num;
						return result;
					case 3:
						num = new int?(2);
						result = num;
						return result;
					case 4:
						num = new int?(5);
						result = num;
						return result;
					case 5:
						num = new int?(10);
						result = num;
						return result;
					case 6:
						num = new int?(15);
						result = num;
						return result;
					case 7:
						num = new int?(-99);
						result = num;
						return result;
					case 8:
						num = new int?(-100);
						result = num;
						return result;
					default:
						num = null;
						result = num;
						return result;
					}
				}
				else
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons <= 7 || wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons <= 7 || wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_1F4;
							}
							goto IL_3F3;
						}
						else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wRA_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_3F3;
							default:
								if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_3F3;
								}
								break;
							}
						}
						else
						{
							switch (Conversions.ToInteger(object_0))
							{
							case 2:
								num = new int?(0);
								result = num;
								return result;
							case 3:
								num = new int?(2);
								result = num;
								return result;
							case 4:
								num = new int?(5);
								result = num;
								return result;
							case 5:
								num = new int?(10);
								result = num;
								return result;
							case 6:
								num = new int?(15);
								result = num;
								return result;
							case 7:
								num = new int?(-99);
								result = num;
								return result;
							case 8:
								num = new int?(-100);
								result = num;
								return result;
							default:
								num = null;
								result = num;
								return result;
							}
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_3F3;
						}
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_3F3;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						num = new int?(0);
						result = num;
						return result;
					case 3:
						num = new int?(2);
						result = num;
						return result;
					case 4:
						num = new int?(5);
						result = num;
						return result;
					case 5:
						num = new int?(10);
						result = num;
						return result;
					case 6:
						num = new int?(15);
						result = num;
						return result;
					case 7:
						num = new int?(-99);
						result = num;
						return result;
					case 8:
						num = new int?(-100);
						result = num;
						return result;
					default:
						num = null;
						result = num;
						return result;
					}
				}
				IL_1F4:
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					num = new int?(0);
					result = num;
					return result;
				case 3:
					num = new int?(2);
					result = num;
					return result;
				case 4:
					num = new int?(5);
					result = num;
					return result;
				case 5:
					num = new int?(10);
					result = num;
					return result;
				case 6:
					num = new int?(15);
					result = num;
					return result;
				case 7:
					num = new int?(-99);
					result = num;
					return result;
				case 8:
					num = new int?(-100);
					result = num;
					return result;
				default:
					num = null;
					result = num;
					return result;
				}
				IL_3F3:
				num = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101199", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = null;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x00330C70 File Offset: 0x0032EE70
		public int method_212(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, int? nullable_38)
		{
			int num = 0;
			int result;
			try
			{
				Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
							{
								goto IL_8E3;
							}
						}
						else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Aircraft_AEW && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
						{
							goto IL_8E3;
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								goto IL_8E3;
							}
							int? num2 = nullable_38;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								num = 1;
								result = 1;
								return result;
							}
							num2 = nullable_38;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num = 2;
								result = 2;
								return result;
							}
							num2 = nullable_38;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								num = 3;
								result = 3;
								return result;
							}
							num = 0;
							result = 0;
							return result;
						}
					}
					else
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type > 5 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_8E3;
						}
						goto IL_3EC;
					}
					int? num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						num = 1;
						result = 1;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num = 2;
						result = 2;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						num = 3;
						result = 3;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 5) : null).GetValueOrDefault())
					{
						num = 4;
						result = 4;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						num = 5;
						result = 5;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 15) : null).GetValueOrDefault())
					{
						num = 6;
						result = 6;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						num = 7;
						result = 7;
						return result;
					}
					num3 = nullable_38;
					if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						num = 8;
						result = 8;
						return result;
					}
					if (this.subject.GetType() == typeof(Side))
					{
						num = 1;
						result = 1;
						return result;
					}
					num = 0;
					result = 0;
					return result;
				}
				else
				{
					if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons <= 7 || wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons <= 7 || wRA_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_3EC;
							}
							goto IL_8E3;
						}
						else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wRA_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_8E3;
							default:
								if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_8E3;
								}
								break;
							}
						}
						else
						{
							int? num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								num = 1;
								result = 1;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num = 2;
								result = 2;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								num = 3;
								result = 3;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null).GetValueOrDefault())
							{
								num = 4;
								result = 4;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 10) : null).GetValueOrDefault())
							{
								num = 5;
								result = 5;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 15) : null).GetValueOrDefault())
							{
								num = 6;
								result = 6;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								num = 7;
								result = 7;
								return result;
							}
							num4 = nullable_38;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								num = 8;
								result = 8;
								return result;
							}
							if (this.subject.GetType() == typeof(Side))
							{
								num = 1;
								result = 1;
								return result;
							}
							num = 0;
							result = 0;
							return result;
						}
					}
					else if (wRA_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_8E3;
						}
					}
					else if (wRA_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wRA_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_8E3;
					}
					int? num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						num = 1;
						result = 1;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num = 2;
						result = 2;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						num = 3;
						result = 3;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 5) : null).GetValueOrDefault())
					{
						num = 4;
						result = 4;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						num = 5;
						result = 5;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 15) : null).GetValueOrDefault())
					{
						num = 6;
						result = 6;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						num = 7;
						result = 7;
						return result;
					}
					num5 = nullable_38;
					if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						num = 8;
						result = 8;
						return result;
					}
					if (this.subject.GetType() == typeof(Side))
					{
						num = 1;
						result = 1;
						return result;
					}
					num = 0;
					result = 0;
					return result;
				}
				IL_3EC:
				int? num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					num = 1;
					result = 1;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = 2;
					result = 2;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					num = 3;
					result = 3;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					num = 4;
					result = 4;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 10) : null).GetValueOrDefault())
				{
					num = 5;
					result = 5;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 15) : null).GetValueOrDefault())
				{
					num = 6;
					result = 6;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					num = 7;
					result = 7;
					return result;
				}
				num6 = nullable_38;
				if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					num = 8;
					result = 8;
					return result;
				}
				if (this.subject.GetType() == typeof(Side))
				{
					num = 1;
					result = 1;
					return result;
				}
				num = 0;
				result = 0;
				return result;
				IL_8E3:
				num = 0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101200", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x003317E0 File Offset: 0x0032F9E0
		public int? GetFiringRange(ref object object_0)
		{
			int? result = null;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 1:
					result = new int?(-99);
					break;
				case 2:
					result = new int?(0);
					break;
				case 3:
					result = new int?(2);
					break;
				case 4:
					result = new int?(5);
					break;
				case 5:
					result = new int?(10);
					break;
				case 6:
					result = new int?(15);
					break;
				case 7:
					result = new int?(20);
					break;
				case 8:
					result = new int?(25);
					break;
				case 9:
					result = new int?(30);
					break;
				case 10:
					result = new int?(35);
					break;
				case 11:
					result = new int?(40);
					break;
				case 12:
					result = new int?(45);
					break;
				case 13:
					result = new int?(50);
					break;
				case 14:
					result = new int?(60);
					break;
				case 15:
					result = new int?(70);
					break;
				case 16:
					result = new int?(80);
					break;
				case 17:
					result = new int?(90);
					break;
				case 18:
					result = new int?(100);
					break;
				case 19:
					result = new int?(125);
					break;
				case 20:
					result = new int?(150);
					break;
				case 21:
					result = new int?(175);
					break;
				case 22:
					result = new int?(200);
					break;
				case 23:
					result = new int?(250);
					break;
				case 24:
					result = new int?(300);
					break;
				case 25:
					result = new int?(500);
					break;
				case 26:
					result = new int?(750);
					break;
				case 27:
					result = new int?(1000);
					break;
				case 28:
					result = new int?(1500);
					break;
				case 29:
					result = new int?(2000);
					break;
				case 30:
					result = new int?(-100);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101201", "");
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

		// Token: 0x06006542 RID: 25922 RVA: 0x00331A70 File Offset: 0x0032FC70
		public int method_214(int? nullable_38)
		{
			int result = 0;
			try
			{
				int? num = nullable_38;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					result = 1;
				}
				else
				{
					num = nullable_38;
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						result = 2;
					}
					else
					{
						num = nullable_38;
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							result = 3;
						}
						else
						{
							num = nullable_38;
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
							{
								result = 4;
							}
							else
							{
								num = nullable_38;
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
								{
									result = 5;
								}
								else
								{
									num = nullable_38;
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 15) : null).GetValueOrDefault())
									{
										result = 6;
									}
									else
									{
										num = nullable_38;
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
										{
											result = 7;
										}
										else
										{
											num = nullable_38;
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 25) : null).GetValueOrDefault())
											{
												result = 8;
											}
											else
											{
												num = nullable_38;
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
												{
													result = 9;
												}
												else
												{
													num = nullable_38;
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 35) : null).GetValueOrDefault())
													{
														result = 10;
													}
													else
													{
														num = nullable_38;
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
														{
															result = 11;
														}
														else
														{
															num = nullable_38;
															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 45) : null).GetValueOrDefault())
															{
																result = 12;
															}
															else
															{
																num = nullable_38;
																if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
																{
																	result = 13;
																}
																else
																{
																	num = nullable_38;
																	if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
																	{
																		result = 14;
																	}
																	else
																	{
																		num = nullable_38;
																		if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
																		{
																			result = 15;
																		}
																		else
																		{
																			num = nullable_38;
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
																			{
																				result = 16;
																			}
																			else
																			{
																				num = nullable_38;
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
																				{
																					result = 17;
																				}
																				else
																				{
																					num = nullable_38;
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 100) : null).GetValueOrDefault())
																					{
																						result = 18;
																					}
																					else
																					{
																						num = nullable_38;
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 125) : null).GetValueOrDefault())
																						{
																							result = 19;
																						}
																						else
																						{
																							num = nullable_38;
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 150) : null).GetValueOrDefault())
																							{
																								result = 20;
																							}
																							else
																							{
																								num = nullable_38;
																								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 175) : null).GetValueOrDefault())
																								{
																									result = 21;
																								}
																								else
																								{
																									num = nullable_38;
																									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 200) : null).GetValueOrDefault())
																									{
																										result = 22;
																									}
																									else
																									{
																										num = nullable_38;
																										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 250) : null).GetValueOrDefault())
																										{
																											result = 23;
																										}
																										else
																										{
																											num = nullable_38;
																											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 300) : null).GetValueOrDefault())
																											{
																												result = 24;
																											}
																											else
																											{
																												num = nullable_38;
																												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 500) : null).GetValueOrDefault())
																												{
																													result = 25;
																												}
																												else
																												{
																													num = nullable_38;
																													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 750) : null).GetValueOrDefault())
																													{
																														result = 26;
																													}
																													else
																													{
																														num = nullable_38;
																														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1000) : null).GetValueOrDefault())
																														{
																															result = 27;
																														}
																														else
																														{
																															num = nullable_38;
																															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1500) : null).GetValueOrDefault())
																															{
																																result = 28;
																															}
																															else
																															{
																																num = nullable_38;
																																if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2000) : null).GetValueOrDefault())
																																{
																																	result = 29;
																																}
																																else
																																{
																																	num = nullable_38;
																																	if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
																																	{
																																		result = 30;
																																	}
																																	else if (this.subject.GetType() == typeof(Side))
																																	{
																																		result = 1;
																																	}
																																	else
																																	{
																																		result = 0;
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
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
				ex2.Data.Add("Error at 101202", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00332200 File Offset: 0x00330400
		public string method_215(int? nullable_38, bool bool_31)
		{
			string text = "";
			if (bool_31)
			{
				text = " (使用'未指明' 目标类型设置)";
			}
			int? num = nullable_38;
			int? num2 = num;
			string result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
			{
				result = "系统缺省(数据库设置)" + text;
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "不要对该目标类型使用武器" + text;
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
					{
						result = "没有明确" + text;
					}
					else
					{
						num2 = num;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
						{
							result = "所有武器" + text;
						}
						else
						{
							num2 = num;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -2) : null).GetValueOrDefault())
							{
								result = "目标导弹防御值" + text;
							}
							else
							{
								num2 = num;
								if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -3) : null).GetValueOrDefault())
								{
									result = "目标导弹防御值2倍数" + text;
								}
								else
								{
									num2 = num;
									if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -4) : null).GetValueOrDefault())
									{
										result = "目标导弹防御值4倍数" + text;
									}
									else
									{
										num2 = num;
										if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -5) : null).GetValueOrDefault())
										{
											result = "目标导弹防御值1/2倍数" + text;
										}
										else
										{
											num2 = num;
											if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -6) : null).GetValueOrDefault())
											{
												result = "目标导弹防御值1/4倍数" + text;
											}
											else
											{
												num2 = num;
												if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
												{
													result = "Various" + text;
												}
												else if (!Information.IsNothing(nullable_38))
												{
													num2 = nullable_38;
													if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() > 1) : null).GetValueOrDefault())
													{
														result = nullable_38.ToString() + "发" + text;
													}
													else
													{
														result = nullable_38.ToString() + "发" + text;
													}
												}
												else
												{
													result = text + "未配置";
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x0033256C File Offset: 0x0033076C
		public string method_216(int? nullable_38, bool bool_31)
		{
			string text = "";
			if (bool_31)
			{
				text = "(使用'未指明'目标类型设置)";
			}
			int? num = nullable_38;
			int? num2 = num;
			string result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
			{
				result = "系统缺省(数据库配置)" + text;
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					result = "开火的作战单元数满足齐射武器数量需求" + text;
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						result = "Various" + text;
					}
					else if (!Information.IsNothing(nullable_38))
					{
						num2 = nullable_38;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() > 1) : null).GetValueOrDefault())
						{
							result = nullable_38.ToString() + "个单元" + text;
						}
						else
						{
							result = nullable_38.ToString() + "个单元" + text;
						}
					}
					else
					{
						result = text + "为配置";
					}
				}
			}
			return result;
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x003326EC File Offset: 0x003308EC
		public string method_217(int? nullable_38, bool bool_31)
		{
			string text = "";
			if (bool_31)
			{
				text = "(使用'未指明'目标类型设置)";
			}
			int? num = nullable_38;
			int? num2 = num;
			string result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
			{
				result = "系统缺省(数据库配置)" + text;
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "武器不用于自防御" + text;
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
					{
						result = "未明确" + text;
					}
					else
					{
						num2 = num;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
						{
							result = "最大射程" + text;
						}
						else
						{
							num2 = num;
							if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								result = "Various" + text;
							}
							else if (!Information.IsNothing(nullable_38))
							{
								result = nullable_38.ToString() + " nm" + text;
							}
							else
							{
								result = "未配置" + text;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x003328A4 File Offset: 0x00330AA4
		public string method_218(int? nullable_38, bool bool_31)
		{
			string text = "";
			if (bool_31)
			{
				text = "(使用'未指明'目标类型设置)";
			}
			int? num = nullable_38;
			int? num2 = num;
			string result;
			if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "禁止自动使用，只能人工开火" + text;
			}
			else
			{
				num2 = num;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
				{
					result = "未明确" + text;
				}
				else
				{
					num2 = num;
					if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						result = "最大射程自动开火" + text;
					}
					else
					{
						num2 = num;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
						{
							result = "Various" + text;
						}
						else if (!Information.IsNothing(nullable_38))
						{
							result = nullable_38.ToString() + "nm" + text;
						}
						else
						{
							result = "";
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00332A10 File Offset: 0x00330C10
		public bool IsLethalWeapon(ref Weapon weapon_)
		{
			Weapon._WeaponType weaponType = weapon_.GetWeaponType();
			bool result;
			if (weaponType <= Weapon._WeaponType.FerryTank)
			{
				switch (weaponType)
				{
				case Weapon._WeaponType.Decoy_Expendable:
					result = false;
					return result;
				case Weapon._WeaponType.Decoy_Towed:
					result = false;
					return result;
				case Weapon._WeaponType.Decoy_Vehicle:
					result = false;
					return result;
				case Weapon._WeaponType.TrainingRound:
					result = false;
					return result;
				default:
					switch (weaponType)
					{
					case Weapon._WeaponType.SensorPod:
						result = false;
						return result;
					case Weapon._WeaponType.DropTank:
						result = false;
						return result;
					case Weapon._WeaponType.BuddyStore:
						result = false;
						return result;
					case Weapon._WeaponType.FerryTank:
						result = false;
						return result;
					}
					break;
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Sonobuoy)
				{
					result = false;
					return result;
				}
				if (weaponType == Weapon._WeaponType.HeliTowedPackage)
				{
					result = false;
					return result;
				}
				switch (weaponType)
				{
				case Weapon._WeaponType.Cargo:
					result = false;
					return result;
				case Weapon._WeaponType.Troops:
					result = false;
					return result;
				case Weapon._WeaponType.Paratroops:
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x00332AD8 File Offset: 0x00330CD8
		public Doctrine._RefuelAlliedUnits? GetRefuelAlliedUnitsDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._RefuelAlliedUnits? result;
			try
			{
				if (this.RefuelAlliesHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetRefuelAlliedUnitsDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._RefuelAlliedUnits?(this.RefuelAllies.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200452", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.No);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00332B88 File Offset: 0x00330D88
		public void SetRefuelAlliedUnitsDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._RefuelAlliedUnits? RefuelAlliedUnitsDoc_)
		{
			this.RefuelAllies = RefuelAlliedUnitsDoc_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x0002C18C File Offset: 0x0002A38C
		public bool RefuelAlliesHasNoValue()
		{
			return !this.RefuelAllies.HasValue;
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00332BC0 File Offset: 0x00330DC0
		public bool RefuelAllies_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.RefuelAllies_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).RefuelAllies_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00332C0C File Offset: 0x00330E0C
		public void SetRefuelAllies_PlayerEditable(Scenario scenario_0, bool bool_31)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.RefuelAllies_Player = bool_31;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetRefuelAllies_PlayerEditable(scenario_0, bool_31);
			}
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x00332C54 File Offset: 0x00330E54
		public void SetRefuelAlliedUnitsDocDataTable(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RefuelAlliedUnits? RefuelAlliedUnitsDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "Yes, receive only";
			string text3 = "Yes, offload only";
			string text4 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(RefuelAlliedUnitsDoc_))
				{
					b = (RefuelAlliedUnitsDoc_.HasValue ? new byte?((byte)RefuelAlliedUnitsDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (RefuelAlliedUnitsDoc_.HasValue ? new byte?((byte)RefuelAlliedUnitsDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (RefuelAlliedUnitsDoc_.HasValue ? new byte?((byte)RefuelAlliedUnitsDoc_.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								b = (RefuelAlliedUnitsDoc_.HasValue ? new byte?((byte)RefuelAlliedUnitsDoc_.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"与上级一致, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RefuelAlliedUnits? refuelAlliedUnitsDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRefuelAlliedUnitsDoctrine(scenario_0, false, false, false);
					b = (refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text4
								});
							}
						}
					}
				}
				Doctrine._RefuelAlliedUnits? refuelAlliedUnitsDoctrine2 = this.GetRefuelAlliedUnitsDoctrine(scenario_0, false, false, false);
				b = (refuelAlliedUnitsDoctrine2.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"未明确"
					});
				}
			}
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x003332B0 File Offset: 0x003314B0
		public Doctrine._AvoidContactWhenPossible? GetAvoidContactWhenPossibleDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._AvoidContactWhenPossible? result;
			try
			{
				if (this.AvoidContactHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetAvoidContactWhenPossibleDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._AvoidContactWhenPossible?(this.AvoidContact.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200453", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_Always);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x00333360 File Offset: 0x00331560
		public void SetAvoidContactWhenPossibleDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._AvoidContactWhenPossible? AvoidContactWhenPossibleDoc_)
		{
			this.AvoidContact = AvoidContactWhenPossibleDoc_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x0002C19C File Offset: 0x0002A39C
		public bool AvoidContactHasNoValue()
		{
			return !this.AvoidContact.HasValue;
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00333398 File Offset: 0x00331598
		public bool AvoidContact_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.AvoidContact_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).AvoidContact_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x003333E4 File Offset: 0x003315E4
		public void SetAvoidContact_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.AvoidContact_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetAvoidContact_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x0033342C File Offset: 0x0033162C
		public void SetAvoidContactWhenPossibleDocDataTable(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._AvoidContactWhenPossible? AvoidContactWhenPossibleDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "否";
			string text2 = "是, 总是如此";
			string text3 = "是, 除非自防御";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(AvoidContactWhenPossibleDoc_))
				{
					b = (AvoidContactWhenPossibleDoc_.HasValue ? new byte?((byte)AvoidContactWhenPossibleDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (AvoidContactWhenPossibleDoc_.HasValue ? new byte?((byte)AvoidContactWhenPossibleDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (AvoidContactWhenPossibleDoc_.HasValue ? new byte?((byte)AvoidContactWhenPossibleDoc_.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._AvoidContactWhenPossible? avoidContactWhenPossibleDoctrine = this.GetDoctrine(scenario_0, ref flag).GetAvoidContactWhenPossibleDoctrine(scenario_0, false, false, false);
					b = (avoidContactWhenPossibleDoctrine.HasValue ? new byte?((byte)avoidContactWhenPossibleDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (avoidContactWhenPossibleDoctrine.HasValue ? new byte?((byte)avoidContactWhenPossibleDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text3
							});
						}
					}
				}
				Doctrine._AvoidContactWhenPossible? avoidContactWhenPossibleDoctrine2 = this.GetAvoidContactWhenPossibleDoctrine(scenario_0, false, false, false);
				b = (avoidContactWhenPossibleDoctrine2.HasValue ? new byte?((byte)avoidContactWhenPossibleDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00333918 File Offset: 0x00331B18
		public Doctrine._DiveOnContact? GetDiveOnContactDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._DiveOnContact? result;
			try
			{
				if (this.DiveWhenThreatsDetectedHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetDiveOnContactDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._DiveOnContact?(this.DiveWhenThreatsDetected.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200454", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x003339C8 File Offset: 0x00331BC8
		public void SetDiveOnContactDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._DiveOnContact? DiveOnContactDoc_)
		{
			this.DiveWhenThreatsDetected = DiveOnContactDoc_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x0002C1AC File Offset: 0x0002A3AC
		public bool DiveWhenThreatsDetectedHasNoValue()
		{
			return !this.DiveWhenThreatsDetected.HasValue;
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x00333A00 File Offset: 0x00331C00
		public bool DiveWhenThreatsDetected_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.DiveWhenThreatsDetected_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).DiveWhenThreatsDetected_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x00333A4C File Offset: 0x00331C4C
		public void SetDiveWhenThreatsDetected_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.DiveWhenThreatsDetected_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetDiveWhenThreatsDetected_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x00333A94 File Offset: 0x00331C94
		public void SetDiveOnContactDocDataTable(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._DiveOnContact? DiveOnContactDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "是, 当电子侦察措施探测和目标接近时";
			string text2 = "是, 当潜望镜或能探测水面目标雷达搜索时";
			string text3 = "是, 当水面舰艇20海里内或飞机在30海里内";
			string text4 = "否";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(DiveOnContactDoc_))
				{
					b = (DiveOnContactDoc_.HasValue ? new byte?((byte)DiveOnContactDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (DiveOnContactDoc_.HasValue ? new byte?((byte)DiveOnContactDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (DiveOnContactDoc_.HasValue ? new byte?((byte)DiveOnContactDoc_.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								b = (DiveOnContactDoc_.HasValue ? new byte?((byte)DiveOnContactDoc_.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"与上级一致, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._DiveOnContact? diveOnContactDoctrine = this.GetDoctrine(scenario_0, ref flag).GetDiveOnContactDoctrine(scenario_0, false, false, false);
					b = (diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"与上级一致, " + text4
								});
							}
						}
					}
				}
				Doctrine._DiveOnContact? diveOnContactDoctrine2 = this.GetDiveOnContactDoctrine(scenario_0, false, false, false);
				b = (diveOnContactDoctrine2.HasValue ? new byte?((byte)diveOnContactDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x003340F0 File Offset: 0x003322F0
		public Doctrine._RechargeBatteryPercentage? GetRechargeBatteryPercentageDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._RechargeBatteryPercentage? result;
			try
			{
				if (this.RechargePercentagePatrolHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetRechargeBatteryPercentageDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._RechargeBatteryPercentage?(this.RechargePercentagePatrol.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200455", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x003341A0 File Offset: 0x003323A0
		public void SetRechargeBatteryPercentageDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._RechargeBatteryPercentage? RechargeBatteryPercentageDoc_)
		{
			this.RechargePercentagePatrol = RechargeBatteryPercentageDoc_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x0002C1BC File Offset: 0x0002A3BC
		public bool RechargePercentagePatrolHasNoValue()
		{
			return !this.RechargePercentagePatrol.HasValue;
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x003341D8 File Offset: 0x003323D8
		public bool RechargePercentagePatrol_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.RechargePercentagePatrol_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).RechargePercentagePatrol_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00334224 File Offset: 0x00332424
		public void SetRechargePercentagePatrol_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.RechargePercentagePatrol_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetRechargePercentagePatrol_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x0033426C File Offset: 0x0033246C
		public void method_243(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RechargeBatteryPercentage? RechargeBatteryPercentageDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "当电池耗光电量";
			string text2 = "当电池剩10%电量";
			string text3 = "20%";
			string text4 = "30%";
			string text5 = "40%";
			string text6 = "50%";
			string text7 = "60%";
			string text8 = "70%";
			string text9 = "80%";
			string text10 = "90%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			if (this.subject.GetType() != typeof(Side))
			{
				int? num;
				if (!Information.IsNothing(RechargeBatteryPercentageDoc_))
				{
					num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"与上级一致, " + text7
												});
											}
											else
											{
												num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"与上级一致, " + text8
													});
												}
												else
												{
													num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"与上级一致, " + text9
														});
													}
													else
													{
														num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"与上级一致, " + text10
															});
														}
														else
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"Inherited, Various"
															});
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentageDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRechargeBatteryPercentageDoctrine(scenario_0, false, false, false);
					num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"与上级一致, " + text7
												});
											}
											else
											{
												num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"与上级一致, " + text8
													});
												}
												else
												{
													num = (rechargeBatteryPercentageDoctrine.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"与上级一致, " + text9
														});
													}
													else
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"与上级一致, " + text10
														});
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentageDoctrine2 = this.GetRechargeBatteryPercentageDoctrine(scenario_0, false, false, false);
				num = (rechargeBatteryPercentageDoctrine2.HasValue ? new int?((int)rechargeBatteryPercentageDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00335088 File Offset: 0x00333288
		public Doctrine._RechargeBatteryPercentage? GetRechargeBatteryPercentageDoc(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._RechargeBatteryPercentage? result;
			try
			{
				if (this.RechargePercentageAttackHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetRechargeBatteryPercentageDoc(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._RechargeBatteryPercentage?(this.RechargePercentageAttack.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200456", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00335138 File Offset: 0x00333338
		public void method_245(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._RechargeBatteryPercentage? nullable_38)
		{
			this.RechargePercentageAttack = nullable_38;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		public bool RechargePercentageAttackHasNoValue()
		{
			return !this.RechargePercentageAttack.HasValue;
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x00335170 File Offset: 0x00333370
		public bool RechargePercentageAttack_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.RechargePercentageAttack_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).RechargePercentageAttack_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x003351BC File Offset: 0x003333BC
		public void SetRechargePercentageAttack_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.RechargePercentageAttack_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetRechargePercentageAttack_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x00335204 File Offset: 0x00333404
		public void SetRechargeBatteryPercentageDocDataTable(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RechargeBatteryPercentage? RechargeBatteryPercentageDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "当电池耗光电量";
			string text2 = "当电池剩10%电量";
			string text3 = "20%";
			string text4 = "30%";
			string text5 = "40%";
			string text6 = "50%";
			string text7 = "60%";
			string text8 = "70%";
			string text9 = "80%";
			string text10 = "90%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			if (this.subject.GetType() != typeof(Side))
			{
				int? num;
				if (!Information.IsNothing(RechargeBatteryPercentageDoc_))
				{
					num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"与上级一致, " + text7
												});
											}
											else
											{
												num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"与上级一致, " + text8
													});
												}
												else
												{
													num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"与上级一致, " + text9
														});
													}
													else
													{
														num = (RechargeBatteryPercentageDoc_.HasValue ? new int?((int)RechargeBatteryPercentageDoc_.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"与上级一致, " + text10
															});
														}
														else
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"Inherited, Various"
															});
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentageDoc = this.GetDoctrine(scenario_0, ref flag).GetRechargeBatteryPercentageDoc(scenario_0, false, false, false);
					num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"与上级一致, " + text7
												});
											}
											else
											{
												num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"与上级一致, " + text8
													});
												}
												else
												{
													num = (rechargeBatteryPercentageDoc.HasValue ? new int?((int)rechargeBatteryPercentageDoc.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"与上级一致, " + text9
														});
													}
													else
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"与上级一致, " + text10
														});
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentageDoc2 = this.GetRechargeBatteryPercentageDoc(scenario_0, false, false, false);
				num = (rechargeBatteryPercentageDoc2.HasValue ? new int?((int)rechargeBatteryPercentageDoc2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x00336020 File Offset: 0x00334220
		public Doctrine._UseAIP? GetUseAIPDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._UseAIP? result;
			try
			{
				if (this.AIPUsageHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetUseAIPDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._UseAIP?(this.AIPUsage.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200457", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._UseAIP?(Doctrine._UseAIP.No);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x003360D0 File Offset: 0x003342D0
		public void SetUseAIPDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._UseAIP? UseAIPDoc_)
		{
			this.AIPUsage = UseAIPDoc_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x0002C1DC File Offset: 0x0002A3DC
		public bool AIPUsageHasNoValue()
		{
			return !this.AIPUsage.HasValue;
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x00336108 File Offset: 0x00334308
		public bool AIPUsage_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.AIPUsage_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).AIPUsage_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00336154 File Offset: 0x00334354
		public void SetAIPUsage_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.AIPUsage_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetAIPUsage_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x0033619C File Offset: 0x0033439C
		private void SetUseAIPDocDataTable(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseAIP? UseAIPDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "否";
			string text2 = "是, 当参与进攻或防御行动时";
			string text3 = "是, 总是如此";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(UseAIPDoc_))
				{
					b = (UseAIPDoc_.HasValue ? new byte?((byte)UseAIPDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text3
						});
					}
					else
					{
						b = (UseAIPDoc_.HasValue ? new byte?((byte)UseAIPDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							b = (UseAIPDoc_.HasValue ? new byte?((byte)UseAIPDoc_.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"与上级一致, " + text
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseAIP? useAIPDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseAIPDoctrine(scenario_0, false, false, false);
					b = (useAIPDoctrine.HasValue ? new byte?((byte)useAIPDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"与上级一致, " + text3
						});
					}
					else
					{
						b = (useAIPDoctrine.HasValue ? new byte?((byte)useAIPDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"与上级一致, " + text
							});
						}
					}
				}
				Doctrine._UseAIP? useAIPDoctrine2 = this.GetUseAIPDoctrine(scenario_0, false, false, false);
				b = (useAIPDoctrine2.HasValue ? new byte?((byte)useAIPDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"未配置"
					});
				}
			}
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00336688 File Offset: 0x00334888
		public Doctrine._UseDippingSonar? GetUseDippingSonarDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33)
		{
			Doctrine._UseDippingSonar? result;
			try
			{
				if (this.DippingSonarHasNoValue())
				{
					Doctrine doctrine = null;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.GetDoctrine(scenario_0, ref flag);
					}
					result = doctrine.GetUseDippingSonarDoctrine(scenario_0, bool_31, bool_32, bool_33);
				}
				else
				{
					result = new Doctrine._UseDippingSonar?(this.DippingSonar.Value);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200458", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x00336738 File Offset: 0x00334938
		public void SetUseDippingSonarDoctrine(Scenario scenario_0, bool bool_31, bool bool_32, bool bool_33, Doctrine._UseDippingSonar? UseDippingSonarDoc_)
		{
			this.DippingSonar = UseDippingSonarDoc_;
			Doctrine.Delegate9 @delegate = Doctrine.delegate9_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_32, bool_33, false);
			}
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x0002C1EC File Offset: 0x0002A3EC
		public bool DippingSonarHasNoValue()
		{
			return !this.DippingSonar.HasValue;
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00336770 File Offset: 0x00334970
		public bool DippingSonar_PlayerEditable(Scenario scenario_0)
		{
			bool result;
			if (this.subject.GetType() == typeof(Side))
			{
				result = this.DippingSonar_Player;
			}
			else
			{
				bool flag = true;
				result = this.GetDoctrine(scenario_0, ref flag).DippingSonar_PlayerEditable(scenario_0);
			}
			return result;
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x003367BC File Offset: 0x003349BC
		public void SetDippingSonar_PlayerEditable(Scenario scenario_0, bool value)
		{
			if (this.subject.GetType() == typeof(Side))
			{
				this.DippingSonar_Player = value;
			}
			else
			{
				bool flag = true;
				this.GetDoctrine(scenario_0, ref flag).SetDippingSonar_PlayerEditable(scenario_0, value);
			}
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x00336804 File Offset: 0x00334A04
		public void SetUseDippingSonarDocDataTable(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseDippingSonar? UseDippingSonarDoc_)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "在盘旋于150英尺高度时自动部署";
			string text2 = "只能人工部署或者分配到任务";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.subject.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(UseDippingSonarDoc_))
				{
					b = (UseDippingSonarDoc_.HasValue ? new byte?((byte)UseDippingSonarDoc_.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						b = (UseDippingSonarDoc_.HasValue ? new byte?((byte)UseDippingSonarDoc_.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"与上级一致, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseDippingSonar? useDippingSonarDoctrine = this.GetDoctrine(scenario_0, ref flag).GetUseDippingSonarDoctrine(scenario_0, false, false, false);
					b = (useDippingSonarDoctrine.HasValue ? new byte?((byte)useDippingSonarDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"与上级一致, " + text2
						});
					}
				}
				Doctrine._UseDippingSonar? useDippingSonarDoctrine2 = this.GetUseDippingSonarDoctrine(scenario_0, false, false, false);
				b = (useDippingSonarDoctrine2.HasValue ? new byte?((byte)useDippingSonarDoctrine2.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"未配置"
					});
				}
			}
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00336BB8 File Offset: 0x00334DB8
		public void Save(ref XmlWriter theWriter, ref Scenario theScen, string theDoctrineName = "Doctrine")
		{
			checked
			{
				try
				{
					theWriter.WriteStartElement(theDoctrineName);
					if (this.Nukes.HasValue)
					{
						theWriter.WriteElementString("Nukes", ((byte)this.GetUseNuclearDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("Nukes_Player", this.Nukes_Player.ToString());
					if (this.WCS_Air.HasValue)
					{
						theWriter.WriteElementString("WCS_Air", ((byte)this.GetWCS_AirDoctrine(theScen, false, null, false, false).Value).ToString());
					}
					theWriter.WriteElementString("WCS_Air_Player", this.WCS_Air_Player.ToString());
					if (this.WCS_Surface.HasValue)
					{
						theWriter.WriteElementString("WCS_Surface", ((byte)this.GetWCS_SurfaceDoctrine(theScen, false, null, false, false).Value).ToString());
					}
					theWriter.WriteElementString("WCS_Surface_Player", this.WCS_Surface_Player.ToString());
					if (this.WCS_Submarine.HasValue)
					{
						theWriter.WriteElementString("WCS_Submarine", ((byte)this.GetWCS_SubmarineDoctrine(theScen, false, null, false, false).Value).ToString());
					}
					theWriter.WriteElementString("WCS_Submarine_Player", this.WCS_Submarine_Player.ToString());
					if (this.WCS_Land.HasValue)
					{
						theWriter.WriteElementString("WCS_Land", ((byte)this.GetWCS_LandDoctrine(theScen, false, null, false, false).Value).ToString());
					}
					theWriter.WriteElementString("WCS_Player_Land", this.WCS_Player_Land.ToString());
					if (this.IgnorePlottedCourseWhenAttacking.HasValue)
					{
						theWriter.WriteElementString("IPCWA", ((byte)this.GetIgnorePlottedCourseWhenAttackingDoctrine(theScen, false, null, false, false).Value).ToString());
					}
					theWriter.WriteElementString("IPCWA_Player", this.IPCWA_Player.ToString());
					if (this.WinchesterShotgunRTB.HasValue)
					{
						theWriter.WriteElementString("WinchesterShotgunRTB", ((byte)this.GetWinchesterShotgunRTBDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("WinchesterShotgunRTB_Player", this.WinchesterShotgunRTB_Player.ToString());
					if (this.BingoJokerRTB.HasValue)
					{
						theWriter.WriteElementString("BingoJokerRTB", ((byte)this.GetBingoJokerRTBDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("BingoJokerRTB_Player", this.BingoJokerRTB_Player.ToString());
					if (this.JettisonOrdnance.HasValue)
					{
						theWriter.WriteElementString("JettisonOrdnance", ((byte)this.GetJettisonOrdnanceDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("JettisonOrdnance_Player", this.JettisonOrdnance_Player.ToString());
					if (this.BehaviorTowardsAmbigousTarget.HasValue)
					{
						theWriter.WriteElementString("BTAT", ((byte)this.GetBehaviorTowardsAmbigousTargetDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("BTAT_Player", this.BehaviorTowardsAmbigousTarget_Player.ToString());
					if (this.AutomaticEvasion.HasValue)
					{
						theWriter.WriteElementString("AE", ((byte)this.GetAutomaticEvasionDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("AE_Player", this.AE_Player.ToString());
					if (this.MaintainStandoff.HasValue)
					{
						theWriter.WriteElementString("MS", ((byte)this.GetMaintainStandoffDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("MS_Player", this.MS_Player.ToString());
					if (this.GunStrafeGroundTargets.HasValue)
					{
						theWriter.WriteElementString("GS", ((byte)this.GetGunStrafeGroundTargetsDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("GS_Player", this.GS_Player.ToString());
					if (this.UseRefuel.HasValue)
					{
						theWriter.WriteElementString("UR", ((byte)this.GetUseRefuelDoctrine(theScen, false, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("UR_Player", this.UR_Player.ToString());
					if (this.RefuelSelection.HasValue)
					{
						theWriter.WriteElementString("RS", ((byte)this.GetRefuelSelectionDoctrine(theScen, false, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("RS_Player", this.RS_Player.ToString());
					if (this.ShootTourists.HasValue)
					{
						theWriter.WriteElementString("ST", ((byte)this.GetShootTouristsDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("ST_Player", this.ST_Player.ToString());
					if (this.SAM_ASUW.HasValue)
					{
						theWriter.WriteElementString("SAM_ASUW", ((byte)this.GetUseSAMsInASuWModeDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("SAM_ASUW_Player", this.SAM_ASUW_Player.ToString());
					if (!Information.IsNothing(this.m_EMCON_Settings))
					{
						theWriter.WriteElementString("E_Radar", ((byte)this.m_EMCON_Settings.GetEMCON_SettingsForRadar()).ToString());
						theWriter.WriteElementString("E_Sonar", ((byte)this.m_EMCON_Settings.GetEMCON_SettingsForSonar()).ToString());
						theWriter.WriteElementString("E_OECM", ((byte)this.m_EMCON_Settings.GetEMCON_SettingsForOECM()).ToString());
					}
					if (this.QuickTurnAround.HasValue)
					{
						theWriter.WriteElementString("QuickTurnAround", ((byte)this.GetQuickTurnAroundDoctrine(theScen, false, true, false, false).Value).ToString());
					}
					theWriter.WriteElementString("QTA_Player", this.QTA_Player.ToString());
					if (this.AirOpsTempo.HasValue)
					{
						theWriter.WriteElementString("AirOpsTempo", ((byte)this.GetAirOpsTempoDoctrine(theScen, false, true, false, false).Value).ToString());
					}
					theWriter.WriteElementString("AirOpsTempo_Player", this.AirOpsTempo_Player.ToString());
					if (this.BingoJoker.HasValue)
					{
						theWriter.WriteElementString("BingoJoker", ((byte)this.GetBingoJokerDoctrine(theScen, false, true, false, false).Value).ToString());
					}
					theWriter.WriteElementString("BingoJoker_Player", this.BingoJoker_Player.ToString());
					if (this.WinchesterShotgun.HasValue)
					{
						theWriter.WriteElementString("WinchesterShotgun", ((int)this.GetWinchesterShotgunDoctrine(theScen, false, true, false, false).Value).ToString());
					}
					theWriter.WriteElementString("WinchesterShotgun_Player", this.WinchesterShotgun_Player.ToString());
					if (this.WithdrawDamageThreshold.HasValue)
					{
						theWriter.WriteElementString("WithdrawDamageThreshold", ((int)this.GetWithdrawDamageThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.WithdrawFuelThreshold.HasValue)
					{
						theWriter.WriteElementString("WithdrawFuelThreshold", ((int)this.GetWithdrawFuelThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.WithdrawAttackThreshold.HasValue)
					{
						theWriter.WriteElementString("WithdrawAttackThreshold", ((int)this.GetWithdrawAttackThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.WithdrawDefenceThreshold.HasValue)
					{
						theWriter.WriteElementString("WithdrawDefenceThreshold", ((int)this.GetWithdrawDefenceThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.RedeployDamageThreshold.HasValue)
					{
						theWriter.WriteElementString("RedeployDamageThreshold", ((int)this.GetRedeployDamageThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.RedeployFuelThreshold.HasValue)
					{
						theWriter.WriteElementString("RedeployFuelThreshold", ((int)this.GetRedeployFuelThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.RedeployAttackThreshold.HasValue)
					{
						theWriter.WriteElementString("RedeployAttackThreshold", ((int)this.GetRedeployAttackWeaponQuantityThresholdDoctrine(theScen, false, false, false).Value).ToString());
					}
					if (this.RedeployDefenceThreshold.HasValue)
					{
						theWriter.WriteElementString("RedeployDefenceThreshold", ((int)this.GetRedeployDefenceWeaponQuantityThreshold(theScen, false, false, false).Value).ToString());
					}
					if (this.IgnoreEMCONUnderAttack.HasValue)
					{
						theWriter.WriteElementString("IgnoreEMCONUnderAttack", ((byte)this.GetIgnoreEMCONUnderAttackDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("IgnoreEMCONUnderAttack_Player", this.IgnoreEMCONUnderAttack_Player.ToString());
					if (this.UseTorpedoesKinematicRange.HasValue)
					{
						theWriter.WriteElementString("UseTorpedoesKinematicRange", ((byte)this.GetUseTorpedoesKinematicRangeDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("UseTorpedoesKinematicRange_Player", this.UseTorpedoesKinematicRange_Player.ToString());
					if (this.RefuelAllies.HasValue)
					{
						theWriter.WriteElementString("RefuelAllies", ((byte)this.GetRefuelAlliedUnitsDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("RefuelAllies_Player", this.RefuelAllies_Player.ToString());
					if (this.AvoidContact.HasValue)
					{
						theWriter.WriteElementString("AvoidContact", ((byte)this.GetAvoidContactWhenPossibleDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("AvoidContact_Player", this.AvoidContact_Player.ToString());
					if (this.DiveWhenThreatsDetected.HasValue)
					{
						theWriter.WriteElementString("DiveWhenThreatsDetected", ((byte)this.GetDiveOnContactDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("DiveWhenThreatsDetected_Player", this.DiveWhenThreatsDetected_Player.ToString());
					if (this.RechargePercentagePatrol.HasValue)
					{
						theWriter.WriteElementString("RechargePercentagePatrol", ((int)this.GetRechargeBatteryPercentageDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("RechargePercentagePatrol_Player", this.RechargePercentagePatrol_Player.ToString());
					if (this.RechargePercentageAttack.HasValue)
					{
						theWriter.WriteElementString("RechargePercentageAttack", ((int)this.GetRechargeBatteryPercentageDoc(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("RechargePercentageAttack_Player", this.RechargePercentageAttack_Player.ToString());
					if (this.AIPUsage.HasValue)
					{
						theWriter.WriteElementString("AIPUsage", ((byte)this.GetUseAIPDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("AIPUsage_Player", this.AIPUsage_Player.ToString());
					if (this.DippingSonar.HasValue)
					{
						theWriter.WriteElementString("DippingSonar", ((byte)this.GetUseDippingSonarDoctrine(theScen, false, false, false).Value).ToString());
					}
					theWriter.WriteElementString("DippingSonar_Player", this.DippingSonar_Player.ToString());
					if (!Information.IsNothing(this.GetWRA_WeaponDictionary()))
					{
						theWriter.WriteStartElement("WRA");
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in this.GetWRA_WeaponDictionary())
						{
							theWriter.WriteStartElement("Weapon_" + Conversions.ToString(Conversions.ToInteger(current.Key.ToString())));
							Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
							for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
							{
								Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
								XmlWriter xmlWriter = theWriter;
								string str = "WeaponTarget_";
								int wRA_WeaponTargetType = (int)wRA_WeaponTarget.WRA_WeaponTargetType;
								xmlWriter.WriteStartElement(str + wRA_WeaponTargetType.ToString());
								if (this.subject.GetType() == typeof(Side))
								{
									bool? flag;
									bool? flag2;
									if (Information.IsNothing(wRA_WeaponTarget.WeaponQty))
									{
										flag = new bool?(false);
									}
									else
									{
										int? num = wRA_WeaponTarget.WeaponQty;
										flag2 = (num.HasValue ? new bool?(num.GetValueOrDefault() == -1) : null);
										flag = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									flag2 = flag;
									if (flag2.GetValueOrDefault())
									{
										theWriter.WriteElementString("WeaponQty", wRA_WeaponTarget.WeaponQty.Value.ToString());
									}
									bool? flag3;
									if (Information.IsNothing(wRA_WeaponTarget.ShooterQty))
									{
										flag3 = new bool?(false);
									}
									else
									{
										int? num = wRA_WeaponTarget.ShooterQty;
										flag2 = (num.HasValue ? new bool?(num.GetValueOrDefault() == -1) : null);
										flag3 = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									flag2 = flag3;
									if (flag2.GetValueOrDefault())
									{
										theWriter.WriteElementString("ShooterQty", wRA_WeaponTarget.ShooterQty.Value.ToString());
									}
									bool? flag4;
									if (Information.IsNothing(wRA_WeaponTarget.SelfDefenceRange))
									{
										flag4 = new bool?(false);
									}
									else
									{
										int? num = wRA_WeaponTarget.SelfDefenceRange;
										flag2 = (num.HasValue ? new bool?(num.GetValueOrDefault() == -1) : null);
										flag4 = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									flag2 = flag4;
									if (flag2.GetValueOrDefault())
									{
										theWriter.WriteElementString("SelfDefenceRange", wRA_WeaponTarget.SelfDefenceRange.Value.ToString());
									}
									if (!Information.IsNothing(wRA_WeaponTarget.FiringRange))
									{
										theWriter.WriteElementString("FiringRange", wRA_WeaponTarget.FiringRange.Value.ToString());
									}
								}
								else
								{
									if (!Information.IsNothing(wRA_WeaponTarget.WeaponQty))
									{
										theWriter.WriteElementString("WeaponQty", wRA_WeaponTarget.WeaponQty.Value.ToString());
									}
									if (!Information.IsNothing(wRA_WeaponTarget.ShooterQty))
									{
										theWriter.WriteElementString("ShooterQty", wRA_WeaponTarget.ShooterQty.Value.ToString());
									}
									if (!Information.IsNothing(wRA_WeaponTarget.SelfDefenceRange))
									{
										theWriter.WriteElementString("SelfDefenceRange", wRA_WeaponTarget.SelfDefenceRange.Value.ToString());
									}
									if (!Information.IsNothing(wRA_WeaponTarget.FiringRange))
									{
										theWriter.WriteElementString("FiringRange", wRA_WeaponTarget.FiringRange.Value.ToString());
									}
								}
								theWriter.WriteEndElement();
							}
							theWriter.WriteEndElement();
						}
						theWriter.WriteEndElement();
					}
					theWriter.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101003", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00337BE4 File Offset: 0x00335DE4
		public static Doctrine SetDoctrineForMission(ref XmlNode xmlNode_0, Subject class137_1)
		{
			Doctrine result = null;
			try
			{
				Collection<ActiveUnit> collection = null;
				Doctrine doctrine = new Doctrine(class137_1, ref collection);
				Doctrine.EMCON_Settings.Enum36? @enum = null;
				Doctrine.EMCON_Settings.Enum36? enum2 = null;
				Doctrine.EMCON_Settings.Enum36? enum3 = null;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2148434813u)
						{
							if (num <= 1222598759u)
							{
								if (num <= 592509872u)
								{
									if (num <= 367419441u)
									{
										if (num <= 168888245u)
										{
											if (num != 96685014u)
											{
												if (num == 168888245u && Operators.CompareString(name, "IgnoreEMCONUnderAttack_Player", false) == 0)
												{
													doctrine.IgnoreEMCONUnderAttack_Player = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "RS_Player", false) == 0)
												{
													doctrine.RS_Player = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num != 328518098u)
										{
											if (num != 333190174u)
											{
												if (num == 367419441u && Operators.CompareString(name, "WCS_Submarine_Player", false) == 0)
												{
													doctrine.WCS_Submarine_Player = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "QuickTurnAround", false) == 0)
												{
													doctrine.SetQuickTurnAroundDoctrine(null, false, true, true, true, new Doctrine._QuickTurnAround?((Doctrine._QuickTurnAround)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "AvoidContact_Player", false) == 0)
											{
												doctrine.AvoidContact_Player = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num <= 418596570u)
									{
										if (num != 403125585u)
										{
											if (num != 418596570u)
											{
												continue;
											}
											if (Operators.CompareString(name, "EMCON_OECM", false) != 0)
											{
												continue;
											}
											goto IL_16C3;
										}
										else
										{
											if (Operators.CompareString(name, "RTBWW", false) != 0)
											{
												continue;
											}
											goto IL_1B84;
										}
									}
									else if (num != 539702834u)
									{
										if (num != 557852687u)
										{
											if (num == 592509872u && Operators.CompareString(name, "WCS_Surface_Player", false) == 0)
											{
												doctrine.WCS_Surface_Player = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "NukesAllowed", false) != 0)
											{
												continue;
											}
											goto IL_1912;
										}
									}
									else
									{
										if (Operators.CompareString(name, "RedeployFuelThreshold", false) == 0)
										{
											doctrine.SetRedeployFuelThresholdDoctrine(null, false, true, true, new Doctrine._FuelQuantityThreshold?((Doctrine._FuelQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num <= 879821284u)
								{
									if (num <= 691945251u)
									{
										if (num != 668277163u)
										{
											if (num == 691945251u && Operators.CompareString(name, "MS_Player", false) == 0)
											{
												doctrine.MS_Player = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "AE", false) != 0)
											{
												continue;
											}
											if (!Versioned.IsNumeric(xmlNode.InnerText))
											{
												if (Conversions.ToBoolean(xmlNode.InnerText))
												{
													doctrine.SetAutomaticEvasionDoctrine(null, false, true, true, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_1));
													continue;
												}
												doctrine.SetAutomaticEvasionDoctrine(null, false, true, true, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_0));
												continue;
											}
											else
											{
												if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
												{
													doctrine.SetAutomaticEvasionDoctrine(null, false, true, true, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_1));
													continue;
												}
												doctrine.SetAutomaticEvasionDoctrine(null, false, true, true, new Doctrine._AutomaticEvasion?((Doctrine._AutomaticEvasion)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
										}
									}
									else if (num != 765306101u)
									{
										if (num != 804597985u)
										{
											if (num == 879821284u && Operators.CompareString(name, "AirOpsTempo_Player", false) == 0)
											{
												doctrine.AirOpsTempo_Player = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "JettisonOrdnance", false) == 0)
											{
												doctrine.SetJettisonOrdnanceDoctrine(null, false, true, true, new Doctrine._JettisonOrdnance?((Doctrine._JettisonOrdnance)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "BingoJokerRTB", false) == 0)
										{
											doctrine.SetBingoJokerRTBDoctrine(null, false, true, true, new Doctrine._FuelStateRTB?((Doctrine._FuelStateRTB)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num <= 903855377u)
								{
									if (num != 886153571u)
									{
										if (num != 903688902u)
										{
											if (num != 903855377u || Operators.CompareString(name, "MS", false) != 0)
											{
												continue;
											}
											if (!Versioned.IsNumeric(xmlNode.InnerText))
											{
												if (Conversions.ToBoolean(xmlNode.InnerText))
												{
													doctrine.SetMaintainStandoffDoctrine(null, false, true, true, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_1));
													continue;
												}
												doctrine.SetMaintainStandoffDoctrine(null, false, true, true, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_0));
												continue;
											}
											else
											{
												if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
												{
													doctrine.SetMaintainStandoffDoctrine(null, false, true, true, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_1));
													continue;
												}
												doctrine.SetMaintainStandoffDoctrine(null, false, true, true, new Doctrine._MaintainStandoff?((Doctrine._MaintainStandoff)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
										}
										else if (Operators.CompareString(name, "EMCON_Radar", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "RTBWW_Player", false) != 0)
										{
											continue;
										}
										goto IL_17C4;
									}
								}
								else if (num != 926850787u)
								{
									if (num != 1121381144u)
									{
										if (num == 1222598759u && Operators.CompareString(name, "BingoJokerRTB_Player", false) == 0)
										{
											doctrine.BingoJokerRTB_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "RechargePercentageAttack", false) == 0)
										{
											doctrine.method_245(null, false, true, true, new Doctrine._RechargeBatteryPercentage?((Doctrine._RechargeBatteryPercentage)Conversions.ToInteger(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "RTBWhenWinchester", false) != 0)
									{
										continue;
									}
									goto IL_1B84;
								}
							}
							else if (num <= 1690126063u)
							{
								if (num <= 1458546423u)
								{
									if (num <= 1282069123u)
									{
										if (num != 1279327281u)
										{
											if (num == 1282069123u && Operators.CompareString(name, "UseTorpedoesKinematicRange_Player", false) == 0)
											{
												doctrine.UseTorpedoesKinematicRange_Player = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "WCS_Air_Player", false) == 0)
											{
												doctrine.WCS_Air_Player = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 1301901233u)
									{
										if (num != 1444970949u)
										{
											if (num != 1458546423u || Operators.CompareString(name, "WRA", false) != 0)
											{
												continue;
											}
											doctrine.WRA_WeaponDictionary = new Dictionary<int, Doctrine.WRA_Weapon>();
											IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
													int key = Conversions.ToInteger(xmlNode2.Name.Split(new char[]
													{
														'_'
													})[1]);
													Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
													doctrine.WRA_WeaponDictionary.Add(key, wRA_Weapon);
													IEnumerator enumerator3 = xmlNode2.ChildNodes.GetEnumerator();
													try
													{
														while (enumerator3.MoveNext())
														{
															XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
															Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType_ = (Doctrine._WRA_WeaponTargetType)Conversions.ToInteger(xmlNode3.Name.Split(new char[]
															{
																'_'
															})[1]);
															Doctrine.WRA_WeaponTarget wRA_WeaponTarget = new Doctrine.WRA_WeaponTarget(wRA_WeaponTargetType_);
															IEnumerator enumerator4 = xmlNode3.ChildNodes.GetEnumerator();
															try
															{
																while (enumerator4.MoveNext())
																{
																	XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
																	string name2 = xmlNode4.Name;
																	if (Operators.CompareString(name2, "WeaponQty", false) != 0)
																	{
																		if (Operators.CompareString(name2, "ShooterQty", false) != 0)
																		{
																			if (Operators.CompareString(name2, "SelfDefenceRange", false) != 0)
																			{
																				if (Operators.CompareString(name2, "FiringRange", false) == 0)
																				{
																					wRA_WeaponTarget.FiringRange = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																				}
																			}
																			else
																			{
																				wRA_WeaponTarget.SelfDefenceRange = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																			}
																		}
																		else
																		{
																			wRA_WeaponTarget.ShooterQty = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																		}
																	}
																	else
																	{
																		wRA_WeaponTarget.WeaponQty = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																	}
																}
															}
															finally
															{
																if (enumerator4 is IDisposable)
																{
																	(enumerator4 as IDisposable).Dispose();
																}
															}
															ScenarioArrayUtil.AddWRA_WeaponTarget(ref wRA_Weapon.WRA_WeaponTargetArray, wRA_WeaponTarget);
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
										if (Operators.CompareString(name, "GS_Player", false) == 0)
										{
											doctrine.GS_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SAM_ASUW", false) != 0)
										{
											continue;
										}
										if (!Versioned.IsNumeric(xmlNode.InnerText))
										{
											doctrine.SetUseSAMsInASuWModeDoctrine(null, false, true, true, new Doctrine._UseSAMsInASuWMode?(Conversions.ToBoolean(xmlNode.InnerText) ? Doctrine._UseSAMsInASuWMode.const_1 : Doctrine._UseSAMsInASuWMode.const_0));
											continue;
										}
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.SetUseSAMsInASuWModeDoctrine(null, false, true, true, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_0));
											continue;
										}
										doctrine.SetUseSAMsInASuWModeDoctrine(null, false, true, true, new Doctrine._UseSAMsInASuWMode?((Doctrine._UseSAMsInASuWMode)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
								else if (num <= 1549193998u)
								{
									if (num != 1459330367u)
									{
										if (num == 1549193998u && Operators.CompareString(name, "DiveWhenThreatsDetected", false) == 0)
										{
											doctrine.SetDiveOnContactDoctrine(null, false, true, true, new Doctrine._DiveOnContact?((Doctrine._DiveOnContact)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "IgnoreEMCONUnderAttack", false) == 0)
										{
											doctrine.SetIgnoreEMCONUnderAttackDoctrine(null, false, true, true, new Doctrine._IgnoreEMCONUnderAttack?((Doctrine._IgnoreEMCONUnderAttack)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num != 1565608346u)
								{
									if (num != 1650673117u)
									{
										if (num == 1690126063u && Operators.CompareString(name, "IPCWA_Player", false) == 0)
										{
											doctrine.IPCWA_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "DippingSonar", false) == 0)
										{
											doctrine.SetUseDippingSonarDoctrine(null, false, true, true, new Doctrine._UseDippingSonar?((Doctrine._UseDippingSonar)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "BTAT_Player", false) == 0)
									{
										doctrine.BehaviorTowardsAmbigousTarget_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1842416303u)
							{
								if (num <= 1749912049u)
								{
									if (num != 1693683398u)
									{
										if (num != 1749912049u)
										{
											continue;
										}
										if (Operators.CompareString(name, "EMCON_Sonar", false) != 0)
										{
											continue;
										}
										goto IL_121C;
									}
									else
									{
										if (Operators.CompareString(name, "UR", false) != 0)
										{
											continue;
										}
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.SetUseRefuelDoctrine(null, false, true, true, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
											continue;
										}
										doctrine.SetUseRefuelDoctrine(null, false, true, true, false, new Doctrine._UseRefuel?((Doctrine._UseRefuel)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
								else if (num != 1795334850u)
								{
									if (num != 1821569801u)
									{
										if (num == 1842416303u && Operators.CompareString(name, "GS", false) == 0)
										{
											doctrine.SetGunStrafeGroundTargetsDoctrine(null, false, true, true, new Doctrine._GunStrafeGroundTargets?((Doctrine._GunStrafeGroundTargets)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "BingoJoker_Player", false) == 0)
										{
											doctrine.BingoJoker_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ST", false) != 0)
									{
										continue;
									}
									if (!Versioned.IsNumeric(xmlNode.InnerText))
									{
										if (doctrine.subject.GetType() == typeof(Side))
										{
											doctrine.SetShootTouristsDoctrine(null, false, true, true, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0));
											continue;
										}
										doctrine.SetShootTouristsDoctrine(null, false, true, true, new Doctrine._ShootTourists?(Conversions.ToBoolean(xmlNode.InnerText) ? Doctrine._ShootTourists.const_1 : Doctrine._ShootTourists.const_0));
										continue;
									}
									else
									{
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.SetShootTouristsDoctrine(null, false, true, true, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0));
											continue;
										}
										doctrine.SetShootTouristsDoctrine(null, false, true, true, new Doctrine._ShootTourists?((Doctrine._ShootTourists)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
							}
							else if (num <= 1927987729u)
							{
								if (num != 1845814802u)
								{
									if (num != 1903492872u)
									{
										if (num == 1927987729u && Operators.CompareString(name, "AE_Player", false) == 0)
										{
											doctrine.AE_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SFirst", false) != 0)
										{
											continue;
										}
										goto IL_1376;
									}
								}
								else
								{
									if (Operators.CompareString(name, "RS", false) == 0)
									{
										doctrine.SetRefuelSelectionDoctrine(null, false, true, true, false, new Doctrine._RefuelSelection?((Doctrine._RefuelSelection)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else if (num != 2039869005u)
							{
								if (num != 2048548214u)
								{
									if (num != 2148434813u || Operators.CompareString(name, "IPCWA", false) != 0)
									{
										continue;
									}
									if (!Versioned.IsNumeric(xmlNode.InnerText))
									{
										if (Conversions.ToBoolean(xmlNode.InnerText))
										{
											doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(null, false, null, true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
											continue;
										}
										doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(null, false, null, true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
										continue;
									}
									else
									{
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(null, false, null, true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
											continue;
										}
										doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(null, false, null, true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?((Doctrine._IgnorePlottedCourseWhenAttacking)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "RefuelAllies_Player", false) == 0)
									{
										doctrine.RefuelAllies_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "RedeployDamageThreshold", false) == 0)
								{
									doctrine.SetRedeployDamageThresholdDoctrine(null, false, true, true, new Doctrine._DamageThreshold?((Doctrine._DamageThreshold)Conversions.ToShort(xmlNode.InnerText)));
									continue;
								}
								continue;
							}
						}
						else if (num <= 3036757307u)
						{
							if (num <= 2569853489u)
							{
								if (num <= 2407947114u)
								{
									if (num <= 2175700664u)
									{
										if (num != 2152316275u)
										{
											if (num == 2175700664u && Operators.CompareString(name, "WithdrawDefenceThreshold", false) == 0)
											{
												doctrine.SetWithdrawDefenceThresholdDoctrine(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "E_Radar", false) == 0)
											{
												goto IL_104E;
											}
											continue;
										}
									}
									else if (num != 2206632227u)
									{
										if (num != 2316341410u)
										{
											if (num == 2407947114u && Operators.CompareString(name, "RechargePercentagePatrol", false) == 0)
											{
												doctrine.SetRechargeBatteryPercentageDoctrine(null, false, true, true, new Doctrine._RechargeBatteryPercentage?((Doctrine._RechargeBatteryPercentage)Conversions.ToInteger(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "QuickTurnAround_Player", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "BingoJoker", false) == 0)
										{
											doctrine.SetBingoJokerDoctrine(null, false, true, true, true, new Doctrine._FuelState?((Doctrine._FuelState)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num <= 2505807413u)
								{
									if (num != 2501560678u)
									{
										if (num == 2505807413u && Operators.CompareString(name, "WinchesterShotgun", false) == 0)
										{
											doctrine.SetWinchesterShotgunDoctrine(null, false, true, true, true, new Doctrine._WeaponState?((Doctrine._WeaponState)Conversions.ToInteger(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WithdrawFuelThreshold", false) == 0)
										{
											doctrine.SetWithdrawFuelThresholdDoctrine(null, false, true, true, new Doctrine._FuelQuantityThreshold?((Doctrine._FuelQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num != 2528837740u)
								{
									if (num != 2530879819u)
									{
										if (num != 2569853489u)
										{
											continue;
										}
										if (Operators.CompareString(name, "BehaviorTowardsAmbigousTarget", false) != 0)
										{
											continue;
										}
										goto IL_1613;
									}
									else
									{
										if (Operators.CompareString(name, "WCS_Air", false) != 0)
										{
											continue;
										}
										goto IL_1376;
									}
								}
								else
								{
									if (Operators.CompareString(name, "E_Sonar", false) == 0)
									{
										goto IL_121C;
									}
									continue;
								}
							}
							else if (num <= 2724490744u)
							{
								if (num <= 2637333443u)
								{
									if (num != 2588410225u)
									{
										if (num == 2637333443u && Operators.CompareString(name, "SAM_ASUW_Player", false) == 0)
										{
											doctrine.SAM_ASUW_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "UseTorpedoesKinematicRange", false) == 0)
										{
											doctrine.SetUseTorpedoesKinematicRangeDoctrine(null, false, true, true, new Doctrine._UseTorpedoesKinematicRange?((Doctrine._UseTorpedoesKinematicRange)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num != 2649618078u)
								{
									if (num != 2704532014u)
									{
										if (num == 2724490744u && Operators.CompareString(name, "WCS_Land_Player", false) == 0)
										{
											doctrine.WCS_Player_Land = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "AvoidContact", false) == 0)
										{
											doctrine.SetAvoidContactWhenPossibleDoctrine(null, false, true, true, new Doctrine._AvoidContactWhenPossible?((Doctrine._AvoidContactWhenPossible)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ShootFirst", false) == 0)
									{
										goto IL_1376;
									}
									continue;
								}
							}
							else if (num <= 2957235506u)
							{
								if (num != 2909453697u)
								{
									if (num != 2953830872u)
									{
										if (num == 2957235506u && Operators.CompareString(name, "RefuelAllies", false) == 0)
										{
											doctrine.SetRefuelAlliedUnitsDoctrine(null, false, true, true, new Doctrine._RefuelAlliedUnits?((Doctrine._RefuelAlliedUnits)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "NukesAllowed_Inherits", false) == 0 && Conversions.ToBoolean(xmlNode.InnerText))
										{
											doctrine.Nukes = null;
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "QTA_Player", false) != 0)
								{
									continue;
								}
							}
							else if (num != 2999508185u)
							{
								if (num != 3019355958u)
								{
									if (num == 3036757307u && Operators.CompareString(name, "Nukes_Player", false) == 0)
									{
										doctrine.Nukes_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "BTAT", false) == 0)
									{
										goto IL_1613;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "E_OECM", false) == 0)
								{
									goto IL_16C3;
								}
								continue;
							}
							doctrine.QTA_Player = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
							IL_1613:
							if (!Versioned.IsNumeric(xmlNode.InnerText))
							{
								if (Conversions.ToBoolean(xmlNode.InnerText))
								{
									doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(null, false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Pessimistic));
									continue;
								}
								doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(null, false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Optimistic));
								continue;
							}
							else
							{
								if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
								{
									doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(null, false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Pessimistic));
									continue;
								}
								doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(null, false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?((Doctrine._BehaviorTowardsAmbigousTarget)Conversions.ToByte(xmlNode.InnerText)));
								continue;
							}
						}
						else if (num <= 3478926953u)
						{
							if (num <= 3220006457u)
							{
								if (num <= 3109207514u)
								{
									if (num != 3097459879u)
									{
										if (num == 3109207514u && Operators.CompareString(name, "WithdrawAttackThreshold", false) == 0)
										{
											doctrine.SetWithdrawAttackThresholdDoctrine(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WinchesterShotgun_Player", false) == 0)
										{
											doctrine.WinchesterShotgun_Player = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 3154946918u)
								{
									if (num != 3170035372u)
									{
										if (num == 3220006457u && Operators.CompareString(name, "WinchesterShotgunRTB_Player", false) == 0)
										{
											goto IL_17C4;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "RedeployDefenceThreshold", false) == 0)
										{
											doctrine.SetRedeployDefenceWeaponQuantityThreshold(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ST_Player", false) == 0)
									{
										doctrine.ST_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 3313931310u)
							{
								if (num != 3240019622u)
								{
									if (num == 3313931310u && Operators.CompareString(name, "RechargePercentagePatrol_Player", false) == 0)
									{
										doctrine.RechargePercentagePatrol_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "RedeployAttackThreshold", false) == 0)
									{
										doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else if (num != 3444605084u)
							{
								if (num != 3456526287u)
								{
									if (num == 3478926953u && Operators.CompareString(name, "Nukes", false) == 0)
									{
										goto IL_1912;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DippingSonar_Player", false) == 0)
									{
										doctrine.DippingSonar_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "AirOpsTempo", false) == 0)
								{
									doctrine.SetAirOpsTempoDoctrine(null, false, true, true, true, new Doctrine._AirOpsTempo?((Doctrine._AirOpsTempo)Conversions.ToByte(xmlNode.InnerText)));
									continue;
								}
								continue;
							}
						}
						else if (num <= 3938078664u)
						{
							if (num <= 3745846603u)
							{
								if (num != 3489877104u)
								{
									if (num == 3745846603u && Operators.CompareString(name, "WCS_Submarine", false) == 0)
									{
										doctrine.SetWCS_SubmarineDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?((Doctrine._WeaponControlStatus)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "AIPUsage", false) == 0)
									{
										doctrine.SetUseAIPDoctrine(null, false, true, true, new Doctrine._UseAIP?((Doctrine._UseAIP)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else if (num != 3846505587u)
							{
								if (num != 3847341200u)
								{
									if (num == 3938078664u && Operators.CompareString(name, "WCS_Surface", false) == 0)
									{
										doctrine.SetWCS_SurfaceDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?((Doctrine._WeaponControlStatus)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "WCS_Land", false) == 0)
									{
										doctrine.SetWCS_LandDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?((Doctrine._WeaponControlStatus)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "WinchesterShotgunRTB", false) == 0)
								{
									goto IL_1B84;
								}
								continue;
							}
						}
						else if (num <= 4037167626u)
						{
							if (num != 3973228320u)
							{
								if (num != 4004128433u)
								{
									if (num == 4037167626u && Operators.CompareString(name, "UR_Player", false) == 0)
									{
										doctrine.UR_Player = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "WithdrawDamageThreshold", false) == 0)
									{
										doctrine.SetWithdrawDamageThresholdDoctrine(null, false, true, true, new Doctrine._DamageThreshold?((Doctrine._DamageThreshold)Conversions.ToShort(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "RechargePercentageAttack_Player", false) == 0)
								{
									doctrine.RechargePercentageAttack_Player = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 4059101362u)
						{
							if (num != 4085195859u)
							{
								if (num == 4268668376u && Operators.CompareString(name, "AIPUsage_Player", false) == 0)
								{
									doctrine.AIPUsage_Player = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "JettisonOrdnance_Player", false) == 0)
								{
									doctrine.JettisonOrdnance_Player = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "DiveWhenThreatsDetected_Player", false) == 0)
							{
								doctrine.DiveWhenThreatsDetected_Player = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_104E:
						@enum = new Doctrine.EMCON_Settings.Enum36?((Doctrine.EMCON_Settings.Enum36)XmlConvert.ToByte(xmlNode.InnerText));
						continue;
						IL_121C:
						enum2 = new Doctrine.EMCON_Settings.Enum36?((Doctrine.EMCON_Settings.Enum36)XmlConvert.ToByte(xmlNode.InnerText));
						continue;
						IL_1376:
						if (!Versioned.IsNumeric(xmlNode.InnerText))
						{
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								doctrine.method_63(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
								doctrine.SetWCS_SurfaceDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
								doctrine.SetWCS_SubmarineDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
								doctrine.SetWCS_LandDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
								continue;
							}
							doctrine.method_63(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							doctrine.SetWCS_SurfaceDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							doctrine.SetWCS_SubmarineDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							doctrine.SetWCS_LandDoctrine(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							continue;
						}
						else
						{
							if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
							{
								doctrine.method_63(null, false, null, true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
								continue;
							}
							doctrine.method_63(null, false, null, true, true, new Doctrine._WeaponControlStatus?((Doctrine._WeaponControlStatus)Conversions.ToByte(xmlNode.InnerText)));
							continue;
						}
						IL_16C3:
						enum3 = new Doctrine.EMCON_Settings.Enum36?((Doctrine.EMCON_Settings.Enum36)XmlConvert.ToByte(xmlNode.InnerText));
						continue;
						IL_17C4:
						doctrine.WinchesterShotgunRTB_Player = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_1912:
						if (!Versioned.IsNumeric(xmlNode.InnerText))
						{
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								doctrine.method_35(null, false, true, true, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_1));
								continue;
							}
							doctrine.method_35(null, false, true, true, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_0));
							continue;
						}
						else
						{
							if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
							{
								doctrine.method_35(null, false, true, true, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_1));
								continue;
							}
							doctrine.method_35(null, false, true, true, new Doctrine._UseNuclear?((Doctrine._UseNuclear)Conversions.ToByte(xmlNode.InnerText)));
							continue;
						}
						IL_1B84:
						if (!Versioned.IsNumeric(xmlNode.InnerText))
						{
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								doctrine.SetWinchesterShotgunRTBDoctrine(null, false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
							}
							else
							{
								doctrine.SetWinchesterShotgunRTBDoctrine(null, false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
							}
						}
						else if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
						{
							doctrine.SetWinchesterShotgunRTBDoctrine(null, false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
						}
						else
						{
							doctrine.SetWinchesterShotgunRTBDoctrine(null, false, true, true, new Doctrine._WeaponStateRTB?((Doctrine._WeaponStateRTB)Conversions.ToByte(xmlNode.InnerText)));
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
				if (@enum.HasValue || enum2.HasValue || enum3.HasValue)
				{
					doctrine.m_EMCON_Settings = new Doctrine.EMCON_Settings(@enum.Value, enum2.Value, enum3.Value);
				}
				result = doctrine;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101004", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Collection<ActiveUnit> collection = null;
				result = new Doctrine(class137_1, ref collection);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00339AB0 File Offset: 0x00337CB0
		public void method_263(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseNuclear? nullable_38)
		{
			Doctrine._UseNuclear? useNuclearDoctrine = this.GetUseNuclearDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_39(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.UseNukesHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._UseNuclear? useNuclear = useNuclearDoctrine;
				byte? b = useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x00339C90 File Offset: 0x00337E90
		public void method_264(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.method_35(scenario_0, true, bool_31, bool_32, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_1));
						}
					}
				}
				this.method_35(scenario_0, false, bool_31, bool_32, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.method_35(scenario_0, true, bool_31, bool_32, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_0));
						}
					}
				}
				this.method_35(scenario_0, false, bool_31, bool_32, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.method_35(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.method_35(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x00339E5C File Offset: 0x0033805C
		public void method_265(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			Doctrine._WeaponControlStatus? wCS_AirDoctrine = this.GetWCS_AirDoctrine(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_40(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WCS_AirHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._WeaponControlStatus? weaponControlStatus = wCS_AirDoctrine;
				byte? b = weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x0033A09C File Offset: 0x0033829C
		public void method_266(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.method_63(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
						}
					}
				}
				this.method_63(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.method_63(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
						}
					}
				}
				this.method_63(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.method_63(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
						}
					}
				}
				this.method_63(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.method_63(scenario_0, true, null, bool_31, bool_32, null);
							}
						}
					}
					this.method_63(scenario_0, false, new bool?(false), bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x0033A31C File Offset: 0x0033851C
		public void method_267(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			Doctrine._WeaponControlStatus? wCS_SurfaceDoctrine = this.GetWCS_SurfaceDoctrine(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_41(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WCS_SurfaceHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._WeaponControlStatus? weaponControlStatus = wCS_SurfaceDoctrine;
				byte? b = weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x0033A55C File Offset: 0x0033875C
		public void method_268(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWCS_SurfaceDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
						}
					}
				}
				this.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWCS_SurfaceDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
						}
					}
				}
				this.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWCS_SurfaceDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
						}
					}
				}
				this.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetWCS_SurfaceDoctrine(scenario_0, true, null, bool_31, bool_32, null);
							}
						}
					}
					this.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x0033A7DC File Offset: 0x003389DC
		public void method_269(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			Doctrine._WeaponControlStatus? wCS_SubmarineDoctrine = this.GetWCS_SubmarineDoctrine(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_42(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WCS_SubmarineHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._WeaponControlStatus? weaponControlStatus = wCS_SubmarineDoctrine;
				byte? b = weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x0033AA1C File Offset: 0x00338C1C
		public void method_270(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
						}
					}
				}
				this.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
						}
					}
				}
				this.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
						}
					}
				}
				this.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, true, null, bool_31, bool_32, null);
							}
						}
					}
					this.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x0033AC9C File Offset: 0x00338E9C
		public void method_271(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponControlStatus? nullable_38)
		{
			Doctrine._WeaponControlStatus? wCS_LandDoctrine = this.GetWCS_LandDoctrine(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_43(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WCS_LandHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._WeaponControlStatus? weaponControlStatus = wCS_LandDoctrine;
				byte? b = weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x0033AEDC File Offset: 0x003390DC
		public void method_272(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWCS_LandDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
						}
					}
				}
				this.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWCS_LandDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
						}
					}
				}
				this.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWCS_LandDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
						}
					}
				}
				this.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetWCS_LandDoctrine(scenario_0, true, null, bool_31, bool_32, null);
							}
						}
					}
					this.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x0033B15C File Offset: 0x0033935C
		public void method_273(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._IgnorePlottedCourseWhenAttacking? nullable_38)
		{
			Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.GetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_44(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.IgnorePlottedCourseWhenAttackingHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttacking = ignorePlottedCourseWhenAttackingDoctrine;
				byte? b = ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x0033B340 File Offset: 0x00339540
		public void method_274(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
						}
					}
				}
				this.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, true, new bool?(false), bool_31, bool_32, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
						}
					}
				}
				this.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, true, null, bool_31, bool_32, null);
							}
						}
					}
					this.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x0033B534 File Offset: 0x00339734
		public void method_275(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponStateRTB? nullable_38)
		{
			Doctrine._WeaponStateRTB? winchesterShotgunRTBDoctrine = this.GetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_45(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WinchesterShotgunRTBHasNoValue())
			{
				comboBox.SelectedIndex = 4;
			}
			else
			{
				Doctrine._WeaponStateRTB? weaponStateRTB = winchesterShotgunRTBDoctrine;
				byte? b = weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 5;
								}
								else
								{
									b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x0033B7D8 File Offset: 0x003399D8
		public void method_276(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
						}
					}
				}
				this.SetWinchesterShotgunRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesFirstUnit));
						}
					}
				}
				this.SetWinchesterShotgunRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesFirstUnit));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
						}
					}
				}
				this.SetWinchesterShotgunRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
						}
					}
				}
				this.SetWinchesterShotgunRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
				break;
			case 4:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, true, bool_31, bool_32, null);
						}
					}
				}
				this.SetWinchesterShotgunRTBDoctrine(scenario_0, false, bool_31, bool_32, null);
				break;
			}
			foreach (ActiveUnit current in this.GetDoctrineActiveUnit(scenario_0, null))
			{
				if (current.IsAircraft)
				{
					current.SetWeaponState(ActiveUnit._ActiveUnitWeaponState.None);
					if (current.IsOperating())
					{
						current.GetAI().UpdateUnitStatus(0f, false, true);
					}
				}
			}
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x0033BB1C File Offset: 0x00339D1C
		public void method_277(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._FuelStateRTB? nullable_38)
		{
			Doctrine._FuelStateRTB? bingoJokerRTBDoctrine = this.GetBingoJokerRTBDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_46(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.BingoJokerRTBHasNoValue())
			{
				comboBox.SelectedIndex = 4;
			}
			else
			{
				Doctrine._FuelStateRTB? fuelStateRTB = bingoJokerRTBDoctrine;
				byte? b = fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 5;
								}
								else
								{
									b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x0033BDC0 File Offset: 0x00339FC0
		public void method_278(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLeaveGroup));
						}
					}
				}
				this.SetBingoJokerRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLeaveGroup));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
						}
					}
				}
				this.SetBingoJokerRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLastUnit));
						}
					}
				}
				this.SetBingoJokerRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLastUnit));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.No));
						}
					}
				}
				this.SetBingoJokerRTBDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.No));
				break;
			case 4:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, true, bool_31, bool_32, null);
						}
					}
				}
				this.SetBingoJokerRTBDoctrine(scenario_0, false, bool_31, bool_32, null);
				break;
			}
			foreach (ActiveUnit current in this.GetDoctrineActiveUnit(scenario_0, null))
			{
				if (current.IsAircraft)
				{
					current.SetFuelState(ActiveUnit._ActiveUnitFuelState.None);
					if (current.IsOperating())
					{
						current.GetAI().UpdateUnitStatus(0f, true, false);
					}
				}
			}
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x0033C104 File Offset: 0x0033A304
		public void method_279(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._JettisonOrdnance? nullable_38)
		{
			Doctrine._JettisonOrdnance? jettisonOrdnanceDoctrine = this.GetJettisonOrdnanceDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_47(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.JettisonOrdnanceHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._JettisonOrdnance? jettisonOrdnance = jettisonOrdnanceDoctrine;
				byte? b = jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x0033C2E4 File Offset: 0x0033A4E4
		public void method_280(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetJettisonOrdnanceDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Yes));
						}
					}
				}
				this.SetJettisonOrdnanceDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Yes));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetJettisonOrdnanceDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.No));
						}
					}
				}
				this.SetJettisonOrdnanceDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.No));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetJettisonOrdnanceDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetJettisonOrdnanceDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x0033C4B0 File Offset: 0x0033A6B0
		public void method_281(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._BehaviorTowardsAmbigousTarget? nullable_38)
		{
			Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTargetDoctrine = this.GetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_48(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.BehaviorTowardsAmbigousTargetHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTarget = behaviorTowardsAmbigousTargetDoctrine;
				byte? b = behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x0033C6F0 File Offset: 0x0033A8F0
		public void method_282(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Ignore));
						}
					}
				}
				this.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Optimistic));
						}
					}
				}
				this.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Optimistic));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Pessimistic));
						}
					}
				}
				this.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.Pessimistic));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, bool_31, bool_32, null);
							}
						}
					}
					this.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0033C938 File Offset: 0x0033AB38
		public void method_283(ref ComboBox comboBox_0, ref Scenario scenario_, Doctrine._AutomaticEvasion? automaticEvasionDoc)
		{
			Doctrine._AutomaticEvasion? automaticEvasionDoctrine = this.GetAutomaticEvasionDoctrine(scenario_, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_49(ref dataSource, scenario_, automaticEvasionDoc);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.AutomaticEvasionHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._AutomaticEvasion? automaticEvasion = automaticEvasionDoctrine;
				byte? b = automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x0033CB18 File Offset: 0x0033AD18
		public void method_284(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetAutomaticEvasionDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_1));
						}
					}
				}
				this.SetAutomaticEvasionDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetAutomaticEvasionDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_0));
						}
					}
				}
				this.SetAutomaticEvasionDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetAutomaticEvasionDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetAutomaticEvasionDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x0033CCE4 File Offset: 0x0033AEE4
		public void method_285(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._MaintainStandoff? nullable_38)
		{
			Doctrine._MaintainStandoff? maintainStandoffDoctrine = this.GetMaintainStandoffDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_50(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.MaintainStandoffHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._MaintainStandoff? maintainStandoff = maintainStandoffDoctrine;
				byte? b = maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x0033CEC4 File Offset: 0x0033B0C4
		public void method_286(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetMaintainStandoffDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_1));
						}
					}
				}
				this.SetMaintainStandoffDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetMaintainStandoffDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_0));
						}
					}
				}
				this.SetMaintainStandoffDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetMaintainStandoffDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetMaintainStandoffDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x0033D090 File Offset: 0x0033B290
		public void method_287(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._GunStrafeGroundTargets? nullable_38)
		{
			Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine = this.GetGunStrafeGroundTargetsDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_51(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.GunStrafeGroundTargetsHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = gunStrafeGroundTargetsDoctrine;
				byte? b = gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x0033D270 File Offset: 0x0033B470
		public void method_288(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Yes));
						}
					}
				}
				this.SetGunStrafeGroundTargetsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Yes));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					foreach (ActiveUnit current in this.m_ActiveUnits)
					{
						current.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.No));
						if (current.IsOperating() && current.IsAircraft)
						{
							current.GetAI().UpdateUnitStatus(0f, false, false);
						}
					}
				}
				this.SetGunStrafeGroundTargetsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.No));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(scenario_0, true, bool_31, bool_32, null);
						}
					}
				}
				this.SetGunStrafeGroundTargetsDoctrine(scenario_0, false, bool_31, bool_32, null);
				break;
			}
			foreach (ActiveUnit current2 in this.GetDoctrineActiveUnit(scenario_0, null))
			{
				if (current2.IsOperating() && current2.IsAircraft)
				{
					current2.GetAI().UpdateUnitStatus(0f, false, false);
				}
			}
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0033D4E0 File Offset: 0x0033B6E0
		public void method_289(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseRefuel? nullable_38)
		{
			Doctrine._UseRefuel? useRefuelDoctrine = this.GetUseRefuelDoctrine(scenario_0, false, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_52(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.UseRefuelHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._UseRefuel? useRefuel = useRefuelDoctrine;
				byte? b = useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x0033D724 File Offset: 0x0033B924
		public void method_290(ref int int_0, ref Scenario scenario_0, ref int int_1, bool bool_31, bool bool_32, bool bool_33)
		{
			switch (int_0)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetUseRefuelDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
						}
					}
				}
				this.SetUseRefuelDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetUseRefuelDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						}
					}
				}
				this.SetUseRefuelDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetUseRefuelDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
						}
					}
				}
				this.SetUseRefuelDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					int_0 = int_1;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetUseRefuelDoctrine(scenario_0, true, bool_31, bool_32, bool_33, null);
							}
						}
					}
					this.SetUseRefuelDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
				}
				break;
			}
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x0033D974 File Offset: 0x0033BB74
		public void method_291(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RefuelSelection? nullable_38)
		{
			Doctrine._RefuelSelection? refuelSelectionDoctrine = this.GetRefuelSelectionDoctrine(scenario_0, false, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_53(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RefuelSelectionHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._RefuelSelection? refuelSelection = refuelSelectionDoctrine;
				byte? b = refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x0033DBB8 File Offset: 0x0033BDB8
		public void method_292(ref int int_0, ref Scenario scenario_0, ref int int_1, bool bool_31, bool bool_32, bool bool_33)
		{
			switch (int_0)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_0));
						}
					}
				}
				this.SetRefuelSelectionDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_0));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_1));
						}
					}
				}
				this.SetRefuelSelectionDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_1));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
						}
					}
				}
				this.SetRefuelSelectionDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					int_0 = int_1;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, true, bool_31, bool_32, bool_33, null);
							}
						}
					}
					this.SetRefuelSelectionDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
				}
				break;
			}
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x0033DE08 File Offset: 0x0033C008
		public void method_293(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._ShootTourists? nullable_38)
		{
			Doctrine._ShootTourists? shootTouristsDoctrine = this.GetShootTouristsDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_54(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.ShootTouristsHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._ShootTourists? shootTourists = shootTouristsDoctrine;
				byte? b = shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x0033DFE8 File Offset: 0x0033C1E8
		public void method_294(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetShootTouristsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_1));
						}
					}
				}
				this.SetShootTouristsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetShootTouristsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0));
						}
					}
				}
				this.SetShootTouristsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetShootTouristsDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetShootTouristsDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x0033E1B4 File Offset: 0x0033C3B4
		public void method_295(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseSAMsInASuWMode? nullable_38)
		{
			Doctrine._UseSAMsInASuWMode? useSAMsInASuWModeDoctrine = this.GetUseSAMsInASuWModeDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_55(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.SAM_ASUWHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._UseSAMsInASuWMode? useSAMsInASuWMode = useSAMsInASuWModeDoctrine;
				byte? b = useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x0033E394 File Offset: 0x0033C594
		public void method_296(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetUseSAMsInASuWModeDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_1));
						}
					}
				}
				this.SetUseSAMsInASuWModeDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetUseSAMsInASuWModeDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_0));
						}
					}
				}
				this.SetUseSAMsInASuWModeDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetUseSAMsInASuWModeDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetUseSAMsInASuWModeDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0033E560 File Offset: 0x0033C760
		public void method_297(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._IgnoreEMCONUnderAttack? nullable_38)
		{
			Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttackDoctrine = this.GetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_56(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.IgnoreEMCONUnderAttackHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttack = ignoreEMCONUnderAttackDoctrine;
				byte? b = ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x0033E740 File Offset: 0x0033C940
		public void method_298(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_1));
						}
					}
				}
				this.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_0));
						}
					}
				}
				this.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x0033E90C File Offset: 0x0033CB0C
		public void method_299(ref ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_31, Doctrine._QuickTurnAround? nullable_38)
		{
			Doctrine._QuickTurnAround? quickTurnAroundDoctrine = this.GetQuickTurnAroundDoctrine(scenario_0, false, bool_31, false, false);
			DataTable dataSource = new DataTable();
			this.method_57(ref dataSource, scenario_0, bool_31, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.QuickTurnAroundHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._QuickTurnAround? quickTurnAround = quickTurnAroundDoctrine;
				byte? b = quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x0033EB54 File Offset: 0x0033CD54
		public void method_300(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_31, bool bool_32, bool bool_33)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetQuickTurnAroundDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_0));
						}
					}
				}
				this.SetQuickTurnAroundDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_0));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetQuickTurnAroundDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_1));
						}
					}
				}
				this.SetQuickTurnAroundDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_1));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetQuickTurnAroundDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_2));
						}
					}
				}
				this.SetQuickTurnAroundDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_2));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetQuickTurnAroundDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
							}
						}
					}
					this.SetQuickTurnAroundDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
				}
				break;
			}
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x0033EDB4 File Offset: 0x0033CFB4
		public void method_301(ref ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_31, Doctrine._AirOpsTempo? nullable_38)
		{
			Doctrine._AirOpsTempo? airOpsTempoDoctrine = this.GetAirOpsTempoDoctrine(scenario_0, false, bool_31, false, false);
			DataTable dataSource = new DataTable();
			this.method_58(ref dataSource, scenario_0, bool_31, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.AirOpsTempoHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._AirOpsTempo? airOpsTempo = airOpsTempoDoctrine;
				byte? b = airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x0033EF98 File Offset: 0x0033D198
		public void method_302(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_31, bool bool_32, bool bool_33)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetAirOpsTempoDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_1));
						}
					}
				}
				this.SetAirOpsTempoDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_1));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetAirOpsTempoDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_0));
						}
					}
				}
				this.SetAirOpsTempoDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_0));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetAirOpsTempoDoctrine(scenario_0, true, bool_31, bool_32, bool_33, null);
							}
						}
					}
					this.SetAirOpsTempoDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
				}
				break;
			}
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x0033F174 File Offset: 0x0033D374
		public void method_303(ref ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_31, Doctrine._FuelState? nullable_38)
		{
			Doctrine._FuelState? bingoJokerDoctrine = this.GetBingoJokerDoctrine(scenario_0, false, bool_31, false, false);
			DataTable dataSource = new DataTable();
			this.method_60(ref dataSource, scenario_0, bool_31, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.BingoJokerHasNoValue())
			{
				comboBox.SelectedIndex = 12;
			}
			else
			{
				Doctrine._FuelState? fuelState = bingoJokerDoctrine;
				byte? b = fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
										else
										{
											b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 7;
											}
											else
											{
												b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
												{
													comboBox.SelectedIndex = 8;
												}
												else
												{
													b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
													{
														comboBox.SelectedIndex = 9;
													}
													else
													{
														b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
														{
															comboBox.SelectedIndex = 10;
														}
														else
														{
															b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 11) : null).GetValueOrDefault())
															{
																comboBox.SelectedIndex = 11;
															}
															else
															{
																b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
																if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 12) : null).GetValueOrDefault())
																{
																	comboBox.SelectedIndex = 13;
																}
																else
																{
																	b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
																	if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 14) : null).GetValueOrDefault())
																	{
																		comboBox.SelectedIndex = 13;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x0033F730 File Offset: 0x0033D930
		public void method_304(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_31, ref bool bool_32, bool bool_33, bool bool_34)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Bingo));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Bingo));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker10Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker10Percent));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker20Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker20Percent));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker25Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker25Percent));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker30Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker30Percent));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker40Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker40Percent));
				break;
			case 6:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							enumerator7.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker50Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker50Percent));
				break;
			case 7:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator8 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator8.MoveNext())
						{
							enumerator8.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker60Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker60Percent));
				break;
			case 8:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator9 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator9.MoveNext())
						{
							enumerator9.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker70Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker70Percent));
				break;
			case 9:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator10 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator10.MoveNext())
						{
							enumerator10.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker75Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker75Percent));
				break;
			case 10:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator11 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator11.MoveNext())
						{
							enumerator11.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker80Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker80Percent));
				break;
			case 11:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator12 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator12.MoveNext())
						{
							enumerator12.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, true, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker90Percent));
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, new Doctrine._FuelState?(Doctrine._FuelState.Joker90Percent));
				break;
			case 12:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator13 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator13.MoveNext())
						{
							enumerator13.Current.m_Doctrine.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, null);
						}
					}
				}
				this.SetBingoJokerDoctrine(scenario_0, false, bool_31, bool_33, bool_34, null);
				break;
			}
			if (this.subject.GetType() == typeof(Side))
			{
				using (List<ActiveUnit>.Enumerator enumerator14 = scenario_0.GetActiveUnitList().GetEnumerator())
				{
					while (enumerator14.MoveNext())
					{
						enumerator14.Current.GetKinematics().SetBingoJokerFuel();
					}
					return;
				}
			}
			using (List<ActiveUnit>.Enumerator enumerator15 = this.GetDoctrineActiveUnit(scenario_0, new bool?(bool_32)).GetEnumerator())
			{
				while (enumerator15.MoveNext())
				{
					enumerator15.Current.GetKinematics().SetBingoJokerFuel();
				}
			}
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x0033FEE8 File Offset: 0x0033E0E8
		public void method_305(ref ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_31, Doctrine._WeaponState? nullable_38)
		{
			Doctrine._WeaponState? winchesterShotgunDoctrine = this.GetWinchesterShotgunDoctrine(scenario_0, false, bool_31, false, false);
			DataTable dataSource = new DataTable();
			this.method_59(ref dataSource, scenario_0, bool_31, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WinchesterShotgunHasNoValue())
			{
				comboBox.SelectedIndex = 20;
			}
			else
			{
				Doctrine._WeaponState? weaponState = winchesterShotgunDoctrine;
				int? num = weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
										else
										{
											num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 7;
											}
											else
											{
												num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
												{
													comboBox.SelectedIndex = 8;
												}
												else
												{
													num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
													{
														comboBox.SelectedIndex = 9;
													}
													else
													{
														num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
														{
															comboBox.SelectedIndex = 10;
														}
														else
														{
															num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
															{
																comboBox.SelectedIndex = 11;
															}
															else
															{
																num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																{
																	comboBox.SelectedIndex = 12;
																}
																else
																{
																	num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																	{
																		comboBox.SelectedIndex = 13;
																	}
																	else
																	{
																		num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																		{
																			comboBox.SelectedIndex = 14;
																		}
																		else
																		{
																			num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																			{
																				comboBox.SelectedIndex = 15;
																			}
																			else
																			{
																				num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																				{
																					comboBox.SelectedIndex = 16;
																				}
																				else
																				{
																					num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																					{
																						comboBox.SelectedIndex = 17;
																					}
																					else
																					{
																						num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																						{
																							comboBox.SelectedIndex = 18;
																						}
																						else
																						{
																							num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4022) : null).GetValueOrDefault())
																							{
																								comboBox.SelectedIndex = 19;
																							}
																							else
																							{
																								num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																								{
																									comboBox.SelectedIndex = 21;
																								}
																								else
																								{
																									num = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
																									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																									{
																										comboBox.SelectedIndex = 21;
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x003407F8 File Offset: 0x0033E9F8
		public void method_306(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_31, bool bool_32, bool bool_33)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.LoadoutSetting));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.LoadoutSetting));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester_ToO));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester_ToO));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR_Guns));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR_Guns));
				break;
			case 6:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							enumerator7.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR));
				break;
			case 7:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator8 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator8.MoveNext())
						{
							enumerator8.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR));
				break;
			case 8:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator9 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator9.MoveNext())
						{
							enumerator9.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR_Guns));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR_Guns));
				break;
			case 9:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator10 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator10.MoveNext())
						{
							enumerator10.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR));
				break;
			case 10:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator11 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator11.MoveNext())
						{
							enumerator11.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR_Opportunity_Guns));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR_Opportunity_Guns));
				break;
			case 11:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator12 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator12.MoveNext())
						{
							enumerator12.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR));
				break;
			case 12:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator13 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator13.MoveNext())
						{
							enumerator13.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR_Guns));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR_Guns));
				break;
			case 13:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator14 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator14.MoveNext())
						{
							enumerator14.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementGun));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementGun));
				break;
			case 14:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator15 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator15.MoveNext())
						{
							enumerator15.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25));
				break;
			case 15:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator16 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator16.MoveNext())
						{
							enumerator16.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25_ToO));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25_ToO));
				break;
			case 16:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator17 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator17.MoveNext())
						{
							enumerator17.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50));
				break;
			case 17:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator18 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator18.MoveNext())
						{
							enumerator18.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50_ToO));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50_ToO));
				break;
			case 18:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator19 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator19.MoveNext())
						{
							enumerator19.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75));
				break;
			case 19:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator20 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator20.MoveNext())
						{
							enumerator20.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, true, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75_ToO));
						}
					}
				}
				this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75_ToO));
				break;
			case 20:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator21 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator21.MoveNext())
							{
								enumerator21.Current.m_Doctrine.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
							}
						}
					}
					this.SetWinchesterShotgunDoctrine(scenario_0, false, bool_31, bool_32, bool_33, null);
				}
				break;
			}
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x003414A0 File Offset: 0x0033F6A0
		public void method_307(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseTorpedoesKinematicRange? nullable_38)
		{
			Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRangeDoctrine = this.GetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_61(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.UseTorpedoesKinematicRangeHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRange = useTorpedoesKinematicRangeDoctrine;
				byte? b = useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x003416E0 File Offset: 0x0033F8E0
		public void method_308(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_0));
						}
					}
				}
				this.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_0));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_1));
						}
					}
				}
				this.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_1));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_2));
						}
					}
				}
				this.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_2));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x00341928 File Offset: 0x0033FB28
		public void method_309(ref ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1)
		{
			comboBox_0.Items.Clear();
			comboBox_0.Items.Add("静默");
			comboBox_0.Items.Add("打开");
			if (!Information.IsNothing(this.m_ActiveUnits) && this.m_ActiveUnits.Count > 1 && !doctrine_1.EMCON_SettingsHasNoValue() && this.m_EMCON_Settings.GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_2)
			{
				comboBox_0.Items.Add("Various");
			}
			if (!doctrine_1.EMCON_SettingsHasNoValue() && this.subject.GetType() == typeof(Waypoint))
			{
				comboBox_0.Items.Add("未配置");
			}
			if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_1)
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_3)
			{
				comboBox_0.SelectedIndex = 2;
			}
			comboBox_0.Enabled = !doctrine_1.EMCON_SettingsHasNoValue();
		}

		// Token: 0x060065A3 RID: 26019 RVA: 0x00341A60 File Offset: 0x0033FC60
		public void method_310(ref ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1)
		{
			comboBox_0.Items.Clear();
			comboBox_0.Items.Add("静默");
			comboBox_0.Items.Add("打开");
			if (!Information.IsNothing(this.m_ActiveUnits) && this.m_ActiveUnits.Count > 1 && !doctrine_1.EMCON_SettingsHasNoValue() && this.m_EMCON_Settings.GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_2)
			{
				comboBox_0.Items.Add("Various");
			}
			if (!doctrine_1.EMCON_SettingsHasNoValue() && this.subject.GetType() == typeof(Waypoint))
			{
				comboBox_0.Items.Add("未配置");
			}
			if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_1)
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_3)
			{
				comboBox_0.SelectedIndex = 2;
			}
			comboBox_0.Enabled = !doctrine_1.EMCON_SettingsHasNoValue();
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x00341B98 File Offset: 0x0033FD98
		public void method_311(ref ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1)
		{
			comboBox_0.Items.Clear();
			comboBox_0.Items.Add("静默");
			comboBox_0.Items.Add("打开");
			if (!Information.IsNothing(this.m_ActiveUnits) && this.m_ActiveUnits.Count > 1 && !doctrine_1.EMCON_SettingsHasNoValue() && this.m_EMCON_Settings.GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_2)
			{
				comboBox_0.Items.Add("Various");
			}
			if (!doctrine_1.EMCON_SettingsHasNoValue() && this.subject.GetType() == typeof(Waypoint))
			{
				comboBox_0.Items.Add("未配置");
			}
			if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_1)
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_3)
			{
				comboBox_0.SelectedIndex = 2;
			}
			comboBox_0.Enabled = !doctrine_1.EMCON_SettingsHasNoValue();
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x0002C1FC File Offset: 0x0002A3FC
		public void method_312(ref CheckBox checkBox_0, ref Subject class137_1, ref Doctrine doctrine_1)
		{
			if (!Information.IsNothing(class137_1))
			{
				checkBox_0.Enabled = (class137_1.GetType() != typeof(Side));
			}
			else
			{
				checkBox_0.Enabled = true;
			}
			checkBox_0.Checked = doctrine_1.EMCON_SettingsHasNoValue();
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x00341CD0 File Offset: 0x0033FED0
		public void method_313(ref CheckBox checkBox_0, ref ComboBox comboBox_0, ref ComboBox comboBox_1, ref ComboBox comboBox_2, ref Doctrine doctrine_1, Scenario scenario_0, bool bool_31, bool bool_32)
		{
			Doctrine.EMCON_Settings.Enum36 enum36_ = Doctrine.EMCON_Settings.Enum36.const_0;
			if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_1)
			{
				enum36_ = Doctrine.EMCON_Settings.Enum36.const_1;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_4)
			{
				enum36_ = Doctrine.EMCON_Settings.Enum36.const_4;
			}
			Doctrine.EMCON_Settings.Enum36 enum36_2 = Doctrine.EMCON_Settings.Enum36.const_0;
			if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_1)
			{
				enum36_2 = Doctrine.EMCON_Settings.Enum36.const_1;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_4)
			{
				enum36_2 = Doctrine.EMCON_Settings.Enum36.const_4;
			}
			Doctrine.EMCON_Settings.Enum36 enum36_3 = Doctrine.EMCON_Settings.Enum36.const_0;
			if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_1)
			{
				enum36_3 = Doctrine.EMCON_Settings.Enum36.const_1;
			}
			else if (doctrine_1.GetEMCON_Settings(scenario_0).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_4)
			{
				enum36_3 = Doctrine.EMCON_Settings.Enum36.const_4;
			}
			doctrine_1.SetEMCON_Settings(checkBox_0.Checked);
			comboBox_0.Enabled = !doctrine_1.EMCON_SettingsHasNoValue();
			comboBox_1.Enabled = !doctrine_1.EMCON_SettingsHasNoValue();
			comboBox_2.Enabled = !doctrine_1.EMCON_SettingsHasNoValue();
			if (!doctrine_1.bool_30)
			{
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					foreach (ActiveUnit current in this.m_ActiveUnits)
					{
						current.m_Doctrine.SetEMCON_Settings(checkBox_0.Checked);
						if (!current.m_Doctrine.EMCON_SettingsHasNoValue())
						{
							current.m_Doctrine.SetEMCON_SettingsForSonar(enum36_, scenario_0);
							current.m_Doctrine.SetEMCON_SettingsForRadar(enum36_2, scenario_0);
							current.m_Doctrine.method_173(enum36_3, scenario_0);
						}
					}
				}
				if (!doctrine_1.EMCON_SettingsHasNoValue())
				{
					doctrine_1.SetEMCON_SettingsForSonar(enum36_, scenario_0);
					doctrine_1.SetEMCON_SettingsForRadar(enum36_2, scenario_0);
					doctrine_1.method_173(enum36_3, scenario_0);
				}
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Unit current2 = enumerator2.Current;
							((ActiveUnit)current2).m_Doctrine.method_2(current2, new bool?(false), true, bool_31, bool_32, false);
						}
						return;
					}
				}
				doctrine_1.method_2(this.subject, new bool?(false), false, bool_31, bool_32, false);
			}
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x00341F1C File Offset: 0x0034011C
		public void method_314(ref ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1, bool bool_31, ref bool bool_32, ref bool bool_33, bool bool_34, bool bool_35)
		{
			doctrine_1.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.smethod_0(comboBox_0.SelectedIndex), scenario_0);
			if (!Information.IsNothing(this.m_ActiveUnits))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.m_Doctrine.SetEMCON_SettingsForSonar((Doctrine.EMCON_Settings.Enum36)comboBox_0.SelectedIndex, scenario_0);
					}
				}
			}
			if (bool_32)
			{
				this.method_317(ref scenario_0, ref doctrine_1, ref bool_33, bool_34, bool_35);
			}
			Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_34, bool_35, false);
			}
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x00341FD8 File Offset: 0x003401D8
		public void method_315(ref ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1, bool bool_31, ref bool bool_32, ref bool bool_33, bool bool_34, bool bool_35)
		{
			doctrine_1.method_173(Doctrine.EMCON_Settings.smethod_0(comboBox_0.SelectedIndex), scenario_0);
			if (!Information.IsNothing(this.m_ActiveUnits))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.m_Doctrine.method_173((Doctrine.EMCON_Settings.Enum36)comboBox_0.SelectedIndex, scenario_0);
					}
				}
			}
			if (bool_32)
			{
				this.method_317(ref scenario_0, ref doctrine_1, ref bool_33, bool_34, bool_35);
			}
			Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_34, bool_35, false);
			}
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00342094 File Offset: 0x00340294
		public void method_316(ref ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1, bool bool_31, ref bool bool_32, ref bool bool_33, bool bool_34, bool bool_35)
		{
			doctrine_1.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.smethod_0(comboBox_0.SelectedIndex), scenario_0);
			if (!Information.IsNothing(this.m_ActiveUnits))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.m_Doctrine.SetEMCON_SettingsForRadar((Doctrine.EMCON_Settings.Enum36)comboBox_0.SelectedIndex, scenario_0);
					}
				}
			}
			if (bool_32)
			{
				this.method_317(ref scenario_0, ref doctrine_1, ref bool_33, bool_34, bool_35);
			}
			Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
			if (@delegate != null)
			{
				@delegate(this.subject, new bool?(false), bool_31, bool_34, bool_35, false);
			}
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x00342150 File Offset: 0x00340350
		public void method_317(ref Scenario scenario_0, ref Doctrine doctrine_1, ref bool bool_31, bool bool_32, bool bool_33)
		{
			if (this.subject.GetType() != typeof(Waypoint))
			{
				if (Interaction.MsgBox("所有受影响的作战单元都要遵从电磁管控设置? \r\n\r\n是: 所有受影响的任务、编组或单元的人工传感器设置将会重置到上述电磁管控设置.\r\n否: 受影响的作战单元继续保留各自的电磁管控设置(若有)而不使用规定的电磁管控设置.", MsgBoxStyle.YesNo, "EMCON obedience") == MsgBoxResult.Yes)
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ActiveUnit current = enumerator.Current;
								using (List<ActiveUnit>.Enumerator enumerator2 = current.m_Doctrine.GetDoctrineActiveUnit(scenario_0, new bool?(bool_31)).GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										enumerator2.Current.GetSensory().SetIsObeysEMCON(true);
									}
								}
							}
							goto IL_1E5;
						}
					}
					using (List<ActiveUnit>.Enumerator enumerator3 = doctrine_1.GetDoctrineActiveUnit(scenario_0, new bool?(bool_31)).GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.GetSensory().SetIsObeysEMCON(true);
						}
						goto IL_1E5;
					}
				}
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							ActiveUnit current2 = enumerator4.Current;
							using (List<ActiveUnit>.Enumerator enumerator5 = current2.m_Doctrine.GetDoctrineActiveUnit(scenario_0, new bool?(bool_31)).GetEnumerator())
							{
								while (enumerator5.MoveNext())
								{
									enumerator5.Current.GetSensory().ScheduleEMCONEvent(current2.GetAllNoneMCMSensors());
								}
							}
						}
						goto IL_1E5;
					}
				}
				foreach (ActiveUnit current3 in doctrine_1.GetDoctrineActiveUnit(scenario_0, new bool?(bool_31)))
				{
					current3.GetSensory().ScheduleEMCONEvent(current3.GetAllNoneMCMSensors());
				}
				IL_1E5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							Unit current4 = enumerator7.Current;
							Doctrine.Delegate10 @delegate = Doctrine.delegate10_0;
							if (@delegate != null)
							{
								@delegate(current4, new bool?(false), true, bool_32, bool_33, false);
							}
						}
						return;
					}
				}
				Doctrine.Delegate10 delegate2 = Doctrine.delegate10_0;
				if (delegate2 != null)
				{
					delegate2(this.subject, new bool?(false), false, bool_32, bool_33, false);
				}
			}
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x00342424 File Offset: 0x00340624
		public void method_318(ref Side side_0, ref Scenario scenario_0, ref bool bool_31)
		{
			checked
			{
				if (this.subject.GetType() == typeof(Side))
				{
					ActiveUnit[] activeUnitArray = side_0.ActiveUnitArray;
					for (int i = 0; i < activeUnitArray.Length; i++)
					{
						ActiveUnit activeUnit = activeUnitArray[i];
						activeUnit.GetSensory().ScheduleEMCONEvent(activeUnit.GetAllNoneMCMSensors());
					}
				}
				else
				{
					foreach (ActiveUnit current in this.GetDoctrineActiveUnit(scenario_0, new bool?(bool_31)))
					{
						current.GetSensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
					}
				}
			}
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x003424DC File Offset: 0x003406DC
		public void method_319(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RefuelAlliedUnits? nullable_38)
		{
			Doctrine._RefuelAlliedUnits? refuelAlliedUnitsDoctrine = this.GetRefuelAlliedUnitsDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.SetRefuelAlliedUnitsDocDataTable(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RefuelAlliesHasNoValue())
			{
				comboBox.SelectedIndex = 4;
			}
			else
			{
				Doctrine._RefuelAlliedUnits? refuelAlliedUnits = refuelAlliedUnitsDoctrine;
				byte? b = refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 5;
								}
								else
								{
									b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x00342780 File Offset: 0x00340980
		public void method_320(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRefuelAlliedUnitsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes));
						}
					}
				}
				this.SetRefuelAlliedUnitsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRefuelAlliedUnitsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_ReceiveOnly));
						}
					}
				}
				this.SetRefuelAlliedUnitsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_ReceiveOnly));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRefuelAlliedUnitsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_DeliverOnly));
						}
					}
				}
				this.SetRefuelAlliedUnitsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_DeliverOnly));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetRefuelAlliedUnitsDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.No));
						}
					}
				}
				this.SetRefuelAlliedUnitsDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.No));
				break;
			case 4:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator5.MoveNext())
							{
								enumerator5.Current.m_Doctrine.SetRefuelAlliedUnitsDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetRefuelAlliedUnitsDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x00342A44 File Offset: 0x00340C44
		public void method_321(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._AvoidContactWhenPossible? nullable_38)
		{
			Doctrine._AvoidContactWhenPossible? avoidContactWhenPossibleDoctrine = this.GetAvoidContactWhenPossibleDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.SetAvoidContactWhenPossibleDocDataTable(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.AvoidContactHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible = avoidContactWhenPossibleDoctrine;
				byte? b = avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x00342C84 File Offset: 0x00340E84
		public void method_322(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.No));
						}
					}
				}
				this.SetAvoidContactWhenPossibleDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.No));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_Always));
						}
					}
				}
				this.SetAvoidContactWhenPossibleDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_Always));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_ExceptSelfDefence));
						}
					}
				}
				this.SetAvoidContactWhenPossibleDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_ExceptSelfDefence));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetAvoidContactWhenPossibleDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x00342ECC File Offset: 0x003410CC
		public void method_323(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._DiveOnContact? nullable_38)
		{
			Doctrine._DiveOnContact? diveOnContactDoctrine = this.GetDiveOnContactDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.SetDiveOnContactDocDataTable(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.DiveWhenThreatsDetectedHasNoValue())
			{
				comboBox.SelectedIndex = 4;
			}
			else
			{
				Doctrine._DiveOnContact? diveOnContact = diveOnContactDoctrine;
				byte? b = diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 5;
								}
								else
								{
									b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x00343170 File Offset: 0x00341370
		public void method_324(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetDiveOnContactDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes));
						}
					}
				}
				this.SetDiveOnContactDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetDiveOnContactDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_ESM_Only));
						}
					}
				}
				this.SetDiveOnContactDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_ESM_Only));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetDiveOnContactDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_Ships20nm_Aircraft30nm));
						}
					}
				}
				this.SetDiveOnContactDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_Ships20nm_Aircraft30nm));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetDiveOnContactDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.No));
						}
					}
				}
				this.SetDiveOnContactDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.No));
				break;
			case 4:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator5.MoveNext())
							{
								enumerator5.Current.m_Doctrine.SetDiveOnContactDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetDiveOnContactDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00343434 File Offset: 0x00341634
		public void method_325(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RechargeBatteryPercentage? nullable_38)
		{
			Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentageDoctrine = this.GetRechargeBatteryPercentageDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_243(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RechargePercentagePatrolHasNoValue())
			{
				comboBox.SelectedIndex = 10;
			}
			else
			{
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = rechargeBatteryPercentageDoctrine;
				int? num = rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
										else
										{
											num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 7;
											}
											else
											{
												num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
												{
													comboBox.SelectedIndex = 8;
												}
												else
												{
													num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
													{
														comboBox.SelectedIndex = 9;
													}
													else
													{
														num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
														{
															comboBox.SelectedIndex = 11;
														}
														else
														{
															num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -101) : null).GetValueOrDefault())
															{
																comboBox.SelectedIndex = 11;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x0034392C File Offset: 0x00341B2C
		public void method_326(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
				break;
			case 6:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							enumerator7.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
				break;
			case 7:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator8 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator8.MoveNext())
						{
							enumerator8.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
				break;
			case 8:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator9 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator9.MoveNext())
						{
							enumerator9.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
				break;
			case 9:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator10 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator10.MoveNext())
						{
							enumerator10.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
						}
					}
				}
				this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
				break;
			case 10:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator11 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator11.MoveNext())
							{
								enumerator11.Current.m_Doctrine.SetRechargeBatteryPercentageDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetRechargeBatteryPercentageDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x00343EF0 File Offset: 0x003420F0
		public void method_327(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RechargeBatteryPercentage? nullable_38)
		{
			Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentageDoc = this.GetRechargeBatteryPercentageDoc(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.SetRechargeBatteryPercentageDocDataTable(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RechargePercentageAttackHasNoValue())
			{
				comboBox.SelectedIndex = 10;
			}
			else
			{
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = rechargeBatteryPercentageDoc;
				int? num = rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
										else
										{
											num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 7;
											}
											else
											{
												num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
												{
													comboBox.SelectedIndex = 8;
												}
												else
												{
													num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
													if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
													{
														comboBox.SelectedIndex = 9;
													}
													else
													{
														num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
														if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
														{
															comboBox.SelectedIndex = 11;
														}
														else
														{
															num = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
															if ((num.HasValue ? new bool?(num.GetValueOrDefault() == -101) : null).GetValueOrDefault())
															{
																comboBox.SelectedIndex = 11;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x003443E8 File Offset: 0x003425E8
		public void method_328(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
				break;
			case 6:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							enumerator7.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
				break;
			case 7:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator8 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator8.MoveNext())
						{
							enumerator8.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
				break;
			case 8:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator9 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator9.MoveNext())
						{
							enumerator9.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
				break;
			case 9:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator10 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator10.MoveNext())
						{
							enumerator10.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
						}
					}
				}
				this.method_245(scenario_0, false, bool_31, bool_32, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
				break;
			case 10:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator11 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator11.MoveNext())
							{
								enumerator11.Current.m_Doctrine.method_245(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.method_245(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x003449AC File Offset: 0x00342BAC
		public void method_329(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseAIP? nullable_38)
		{
			Doctrine._UseAIP? useAIPDoctrine = this.GetUseAIPDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.SetUseAIPDocDataTable(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.AIPUsageHasNoValue())
			{
				comboBox.SelectedIndex = 3;
			}
			else
			{
				Doctrine._UseAIP? useAIP = useAIPDoctrine;
				byte? b = useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 4;
							}
							else
							{
								b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00344BEC File Offset: 0x00342DEC
		public void method_330(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetUseAIPDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_Always));
						}
					}
				}
				this.SetUseAIPDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_Always));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetUseAIPDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_AttackOnly));
						}
					}
				}
				this.SetUseAIPDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_AttackOnly));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetUseAIPDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseAIP?(Doctrine._UseAIP.No));
						}
					}
				}
				this.SetUseAIPDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseAIP?(Doctrine._UseAIP.No));
				break;
			case 3:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.m_Doctrine.SetUseAIPDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetUseAIPDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x00344E34 File Offset: 0x00343034
		public void method_331(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseDippingSonar? nullable_38)
		{
			Doctrine._UseDippingSonar? useDippingSonarDoctrine = this.GetUseDippingSonarDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.SetUseDippingSonarDocDataTable(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.DippingSonarHasNoValue())
			{
				comboBox.SelectedIndex = 2;
			}
			else
			{
				Doctrine._UseDippingSonar? useDippingSonar = useDippingSonarDoctrine;
				byte? b = useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 3;
						}
						else
						{
							b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x00345014 File Offset: 0x00343214
		public void method_332(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetUseDippingSonarDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft));
						}
					}
				}
				this.SetUseDippingSonarDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetUseDippingSonarDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.ManualAndMissionOnly));
						}
					}
				}
				this.SetUseDippingSonarDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.ManualAndMissionOnly));
				break;
			case 2:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.m_Doctrine.SetUseDippingSonarDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetUseDippingSonarDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x003451E0 File Offset: 0x003433E0
		public void method_333(ref Scenario scenario_0, ref Side side_0)
		{
			Side[] sides = scenario_0.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					if (side == side_0 || side.IsFriendlyToSide(side_0))
					{
						using (IEnumerator<Mission> enumerator = side.GetMissionCollection().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.int_0 = 1;
							}
						}
					}
				}
			}
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x00345260 File Offset: 0x00343460
		public static void smethod_5(ref ActiveUnit activeUnit_0, ref Doctrine doctrine_1, Scenario scenario_0)
		{
			if (!Information.IsNothing(doctrine_1.GetUseNuclearDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.method_35(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWCS_AirDoctrine(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.method_63(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWCS_LandDoctrine(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWinchesterShotgunDoctrine(scenario_0, false, false, false, false)))
			{
				doctrine_1.SetWinchesterShotgunDoctrine(scenario_0, false, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetWinchesterShotgunRTBDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetBingoJokerDoctrine(scenario_0, false, false, false, false)))
			{
				doctrine_1.SetBingoJokerDoctrine(scenario_0, false, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetBingoJokerRTBDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetBingoJokerRTBDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetJettisonOrdnanceDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetJettisonOrdnanceDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetBehaviorTowardsAmbigousTargetDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetAutomaticEvasionDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetAutomaticEvasionDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetGunStrafeGroundTargetsDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetGunStrafeGroundTargetsDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetMaintainStandoffDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetMaintainStandoffDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetUseRefuelDoctrine(scenario_0, false, false, false, false)))
			{
				doctrine_1.SetUseRefuelDoctrine(scenario_0, false, true, true, false, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRefuelSelectionDoctrine(scenario_0, false, false, false, false)))
			{
				doctrine_1.SetRefuelSelectionDoctrine(scenario_0, false, true, true, false, null);
			}
			if (!Information.IsNothing(doctrine_1.GetShootTouristsDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetShootTouristsDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetUseSAMsInASuWModeDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetUseSAMsInASuWModeDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetIgnoreEMCONUnderAttackDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetUseTorpedoesKinematicRangeDoctrine(scenario_0, false, true, true, null);
			}
			if (Information.IsNothing(activeUnit_0))
			{
				if (!Information.IsNothing(doctrine_1.GetQuickTurnAroundDoctrine(scenario_0, false, false, false, false)))
				{
					doctrine_1.SetQuickTurnAroundDoctrine(scenario_0, false, false, true, true, null);
				}
				if (!Information.IsNothing(doctrine_1.GetAirOpsTempoDoctrine(scenario_0, false, false, false, false)))
				{
					doctrine_1.SetAirOpsTempoDoctrine(scenario_0, false, false, true, true, null);
				}
			}
			else
			{
				if (!Information.IsNothing(doctrine_1.GetQuickTurnAroundDoctrine(scenario_0, false, activeUnit_0.IsOperating(), false, false)))
				{
					doctrine_1.SetQuickTurnAroundDoctrine(scenario_0, false, activeUnit_0.IsOperating(), true, true, null);
				}
				if (!Information.IsNothing(doctrine_1.GetAirOpsTempoDoctrine(scenario_0, false, activeUnit_0.IsOperating(), false, false)))
				{
					doctrine_1.SetAirOpsTempoDoctrine(scenario_0, false, activeUnit_0.IsOperating(), true, true, null);
				}
			}
			if (!Information.IsNothing(activeUnit_0) && activeUnit_0.IsAircraft)
			{
				activeUnit_0.GetKinematics().SetBingoJokerFuel();
			}
			if (!Information.IsNothing(doctrine_1.GetRefuelAlliedUnitsDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetRefuelAlliedUnitsDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetAvoidContactWhenPossibleDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetAvoidContactWhenPossibleDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetDiveOnContactDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetDiveOnContactDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRechargeBatteryPercentageDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetRechargeBatteryPercentageDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRechargeBatteryPercentageDoc(scenario_0, false, false, false)))
			{
				doctrine_1.method_245(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetUseAIPDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetUseAIPDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetUseDippingSonarDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetUseDippingSonarDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWithdrawDamageThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetWithdrawDamageThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWithdrawFuelThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetWithdrawFuelThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWithdrawAttackThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetWithdrawAttackThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetWithdrawDefenceThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRedeployDamageThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetRedeployDamageThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRedeployFuelThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetRedeployFuelThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, false, false)))
			{
				doctrine_1.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.GetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, false, false)))
			{
				doctrine_1.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, true, true, null);
			}
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x003459E0 File Offset: 0x00343BE0
		private void method_334(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._DamageThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略毁伤";
			string text2 = "5%";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._DamageThreshold? withdrawDamageThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawDamageThresholdDoctrine(scenario_0, false, false, false);
					num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (withdrawDamageThresholdDoctrine.HasValue ? new short?((short)withdrawDamageThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._DamageThreshold? withdrawDamageThresholdDoctrine2 = this.GetWithdrawDamageThresholdDoctrine(scenario_0, false, false, false);
				num = (withdrawDamageThresholdDoctrine2.HasValue ? new short?((short)withdrawDamageThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x003461D8 File Offset: 0x003443D8
		private void method_335(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略燃油限制";
			string text2 = "Bingo燃油";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._FuelQuantityThreshold? withdrawFuelThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawFuelThresholdDoctrine(scenario_0, false, false, false);
					num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (withdrawFuelThresholdDoctrine.HasValue ? new short?((short)withdrawFuelThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._FuelQuantityThreshold? withdrawFuelThresholdDoctrine2 = this.GetWithdrawFuelThresholdDoctrine(scenario_0, false, false, false);
				num = (withdrawFuelThresholdDoctrine2.HasValue ? new short?((short)withdrawFuelThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x003469D0 File Offset: 0x00344BD0
		private void method_336(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略燃油限制";
			string text2 = "Bingo燃油";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			string text6 = "100%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								6,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									6,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										6,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											6,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												6,
												"与上级一致, " + text6
											});
										}
										else
										{
											dataTable_0.Rows.Add(new object[]
											{
												6,
												"Inherited, Various"
											});
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._FuelQuantityThreshold? redeployFuelThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRedeployFuelThresholdDoctrine(scenario_0, false, false, false);
					num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								6,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									6,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										6,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											6,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (redeployFuelThresholdDoctrine.HasValue ? new short?((short)redeployFuelThresholdDoctrine.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												6,
												"与上级一致, " + text6
											});
										}
									}
								}
							}
						}
					}
				}
				Doctrine._FuelQuantityThreshold? redeployFuelThresholdDoctrine2 = this.GetRedeployFuelThresholdDoctrine(scenario_0, false, false, false);
				num = (redeployFuelThresholdDoctrine2.HasValue ? new short?((short)redeployFuelThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						7,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						7,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x0034730C File Offset: 0x0034550C
		private void method_337(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略";
			string text2 = "耗光";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? withdrawAttackThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawAttackThresholdDoctrine(scenario_0, false, false, false);
					num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (withdrawAttackThresholdDoctrine.HasValue ? new short?((short)withdrawAttackThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? withdrawAttackThresholdDoctrine2 = this.GetWithdrawAttackThresholdDoctrine(scenario_0, false, false, false);
				num = (withdrawAttackThresholdDoctrine2.HasValue ? new short?((short)withdrawAttackThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00347B04 File Offset: 0x00345D04
		private void method_338(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略";
			string text2 = "耗光";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			string text6 = "100%";
			string text7 = "所有攻击武器";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"与上级一致, " + text7
												});
											}
											else
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, Various"
												});
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? redeployAttackWeaponQuantityThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, false, false);
					num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (redeployAttackWeaponQuantityThresholdDoctrine.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"与上级一致, " + text7
												});
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? redeployAttackWeaponQuantityThresholdDoctrine2 = this.GetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, false, false);
				num = (redeployAttackWeaponQuantityThresholdDoctrine2.HasValue ? new short?((short)redeployAttackWeaponQuantityThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00348584 File Offset: 0x00346784
		private void method_339(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略";
			string text2 = "耗光";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? withdrawDefenceThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetWithdrawDefenceThresholdDoctrine(scenario_0, false, false, false);
					num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (withdrawDefenceThresholdDoctrine.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? withdrawDefenceThresholdDoctrine2 = this.GetWithdrawDefenceThresholdDoctrine(scenario_0, false, false, false);
				num = (withdrawDefenceThresholdDoctrine2.HasValue ? new short?((short)withdrawDefenceThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00348D7C File Offset: 0x00346F7C
		private void method_340(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略";
			string text2 = "耗光";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			string text6 = "100%";
			string text7 = "所有防御武器";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"与上级一致, " + text7
												});
											}
											else
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, Various"
												});
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? redeployDefenceWeaponQuantityThreshold = this.GetDoctrine(scenario_0, ref flag).GetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, false, false);
					num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"与上级一致, " + text5
										});
									}
									else
									{
										num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"与上级一致, " + text6
											});
										}
										else
										{
											num = (redeployDefenceWeaponQuantityThreshold.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"与上级一致, " + text7
												});
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? redeployDefenceWeaponQuantityThreshold2 = this.GetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, false, false);
				num = (redeployDefenceWeaponQuantityThreshold2.HasValue ? new short?((short)redeployDefenceWeaponQuantityThreshold2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x003497FC File Offset: 0x003479FC
		private void method_341(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._DamageThreshold? nullable_38)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "忽略毁伤";
			string text2 = "5%";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.subject.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_38))
				{
					num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (nullable_38.HasValue ? new short?((short)nullable_38.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._DamageThreshold? redeployDamageThresholdDoctrine = this.GetDoctrine(scenario_0, ref flag).GetRedeployDamageThresholdDoctrine(scenario_0, false, false, false);
					num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"与上级一致, " + text
						});
					}
					else
					{
						num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"与上级一致, " + text2
							});
						}
						else
						{
							num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"与上级一致, " + text3
								});
							}
							else
							{
								num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"与上级一致, " + text4
									});
								}
								else
								{
									num = (redeployDamageThresholdDoctrine.HasValue ? new short?((short)redeployDamageThresholdDoctrine.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"与上级一致, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._DamageThreshold? redeployDamageThresholdDoctrine2 = this.GetRedeployDamageThresholdDoctrine(scenario_0, false, false, false);
				num = (redeployDamageThresholdDoctrine2.HasValue ? new short?((short)redeployDamageThresholdDoctrine2.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.subject.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"未配置"
					});
				}
			}
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00349FF4 File Offset: 0x003481F4
		public void method_342(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._DamageThreshold? nullable_38)
		{
			Doctrine._DamageThreshold? withdrawDamageThresholdDoctrine = this.GetWithdrawDamageThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_334(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WithdrawDamageThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 5;
			}
			else
			{
				Doctrine._DamageThreshold? damageThreshold = withdrawDamageThresholdDoctrine;
				short? num = damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 6;
									}
									else
									{
										num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x0034A2F8 File Offset: 0x003484F8
		public void method_343(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_38)
		{
			Doctrine._FuelQuantityThreshold? withdrawFuelThresholdDoctrine = this.GetWithdrawFuelThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_335(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WithdrawFuelThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 5;
			}
			else
			{
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = withdrawFuelThresholdDoctrine;
				short? num = fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 6;
									}
									else
									{
										num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x0034A5FC File Offset: 0x003487FC
		public void method_344(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			Doctrine._WeaponQuantityThreshold? withdrawAttackThresholdDoctrine = this.GetWithdrawAttackThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_337(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WithdrawAttackThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 5;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = withdrawAttackThresholdDoctrine;
				short? num = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 6;
									}
									else
									{
										num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x0034A900 File Offset: 0x00348B00
		public void method_345(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			Doctrine._WeaponQuantityThreshold? withdrawDefenceThresholdDoctrine = this.GetWithdrawDefenceThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_339(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.WithdrawDefenceThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 5;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = withdrawDefenceThresholdDoctrine;
				short? num = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 6;
									}
									else
									{
										num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x0034AC04 File Offset: 0x00348E04
		public void method_346(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._DamageThreshold? nullable_38)
		{
			Doctrine._DamageThreshold? redeployDamageThresholdDoctrine = this.GetRedeployDamageThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_341(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RedeployDamageThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 5;
			}
			else
			{
				Doctrine._DamageThreshold? damageThreshold = redeployDamageThresholdDoctrine;
				short? num = damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 6;
									}
									else
									{
										num = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x0034AF08 File Offset: 0x00349108
		public void method_347(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_38)
		{
			Doctrine._FuelQuantityThreshold? redeployFuelThresholdDoctrine = this.GetRedeployFuelThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_336(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RedeployFuelThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 6;
			}
			else
			{
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = redeployFuelThresholdDoctrine;
				short? num = fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 7;
										}
										else
										{
											num = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 7;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x0034B26C File Offset: 0x0034946C
		public void method_348(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			Doctrine._WeaponQuantityThreshold? redeployAttackWeaponQuantityThresholdDoctrine = this.GetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_338(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RedeployAttackWeaponQuantityThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 7;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = redeployAttackWeaponQuantityThresholdDoctrine;
				short? num = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
										else
										{
											num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 8;
											}
											else
											{
												num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
												{
													comboBox.SelectedIndex = 8;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x0034B630 File Offset: 0x00349830
		public void method_349(ref ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_38)
		{
			Doctrine._WeaponQuantityThreshold? redeployDefenceWeaponQuantityThreshold = this.GetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_340(ref dataSource, scenario_0, nullable_38);
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (this.RedeployDefenceThresholdHasNoValue())
			{
				comboBox.SelectedIndex = 7;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = redeployDefenceWeaponQuantityThreshold;
				short? num = weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox.SelectedIndex = 0;
				}
				else
				{
					num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox.SelectedIndex = 1;
					}
					else
					{
						num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox.SelectedIndex = 2;
						}
						else
						{
							num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox.SelectedIndex = 3;
							}
							else
							{
								num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox.SelectedIndex = 4;
								}
								else
								{
									num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox.SelectedIndex = 5;
									}
									else
									{
										num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox.SelectedIndex = 6;
										}
										else
										{
											num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox.SelectedIndex = 8;
											}
											else
											{
												num = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
												if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
												{
													comboBox.SelectedIndex = 8;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x0034B9F4 File Offset: 0x00349BF4
		public void method_350(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWithdrawDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
						}
					}
				}
				this.SetWithdrawDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWithdrawDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
						}
					}
				}
				this.SetWithdrawDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWithdrawDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
						}
					}
				}
				this.SetWithdrawDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetWithdrawDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
						}
					}
				}
				this.SetWithdrawDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetWithdrawDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
						}
					}
				}
				this.SetWithdrawDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
				break;
			case 5:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.m_Doctrine.SetWithdrawDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetWithdrawDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x0034BD38 File Offset: 0x00349F38
		public void method_351(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRedeployDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
						}
					}
				}
				this.SetRedeployDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRedeployDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
						}
					}
				}
				this.SetRedeployDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRedeployDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
						}
					}
				}
				this.SetRedeployDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetRedeployDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
						}
					}
				}
				this.SetRedeployDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetRedeployDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
						}
					}
				}
				this.SetRedeployDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
				break;
			case 5:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.m_Doctrine.SetRedeployDamageThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetRedeployDamageThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x0034C07C File Offset: 0x0034A27C
		public void method_352(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWithdrawFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
						}
					}
				}
				this.SetWithdrawFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWithdrawFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
						}
					}
				}
				this.SetWithdrawFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWithdrawFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
						}
					}
				}
				this.SetWithdrawFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetWithdrawFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
						}
					}
				}
				this.SetWithdrawFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetWithdrawFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
						}
					}
				}
				this.SetWithdrawFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
				break;
			case 5:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.m_Doctrine.SetWithdrawFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetWithdrawFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x0034C3C0 File Offset: 0x0034A5C0
		public void method_353(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
						}
					}
				}
				this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
						}
					}
				}
				this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
						}
					}
				}
				this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
						}
					}
				}
				this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
						}
					}
				}
				this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent100));
						}
					}
				}
				this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent100));
				break;
			case 6:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator7.MoveNext())
							{
								enumerator7.Current.m_Doctrine.SetRedeployFuelThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetRedeployFuelThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x0034C780 File Offset: 0x0034A980
		public void method_354(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWithdrawAttackThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
				}
				this.SetWithdrawAttackThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWithdrawAttackThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
				}
				this.SetWithdrawAttackThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWithdrawAttackThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
				}
				this.SetWithdrawAttackThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetWithdrawAttackThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
				}
				this.SetWithdrawAttackThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetWithdrawAttackThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
				}
				this.SetWithdrawAttackThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				break;
			case 5:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.m_Doctrine.SetWithdrawAttackThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetWithdrawAttackThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x0034CAC4 File Offset: 0x0034ACC4
		public void method_355(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
				break;
			case 6:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							enumerator7.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
						}
					}
				}
				this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
				break;
			case 7:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator8 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator8.MoveNext())
							{
								enumerator8.Current.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetRedeployAttackWeaponQuantityThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x0034CF00 File Offset: 0x0034B100
		public void method_356(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
				}
				this.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
				}
				this.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
				}
				this.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
				}
				this.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
				}
				this.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				break;
			case 5:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetWithdrawDefenceThresholdDoctrine(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x0034D244 File Offset: 0x0034B444
		public void method_357(ref ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_31, bool bool_32)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				break;
			case 1:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				break;
			case 2:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				break;
			case 3:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator4 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				break;
			case 4:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				break;
			case 5:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator6 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
				break;
			case 6:
				if (!Information.IsNothing(this.m_ActiveUnits))
				{
					using (IEnumerator<ActiveUnit> enumerator7 = this.m_ActiveUnits.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							enumerator7.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
						}
					}
				}
				this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
				break;
			case 7:
				if (this.subject.GetType() == typeof(Side))
				{
					Interaction.MsgBox("推演方的作战条令/交战规则设置不能从它处继承!", MsgBoxStyle.OkOnly, "设置不能继承!");
					comboBox_0.SelectedIndex = int_0;
				}
				else
				{
					if (!Information.IsNothing(this.m_ActiveUnits))
					{
						using (IEnumerator<ActiveUnit> enumerator8 = this.m_ActiveUnits.GetEnumerator())
						{
							while (enumerator8.MoveNext())
							{
								enumerator8.Current.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, true, bool_31, bool_32, null);
							}
						}
					}
					this.SetRedeployDefenceWeaponQuantityThreshold(scenario_0, false, bool_31, bool_32, null);
				}
				break;
			}
		}

		// Token: 0x04003675 RID: 13941
		private Subject subject;

		// Token: 0x04003676 RID: 13942
		private Collection<ActiveUnit> m_ActiveUnits;

		// Token: 0x04003677 RID: 13943
		private Doctrine.EMCON_Settings m_EMCON_Settings;

		// Token: 0x04003678 RID: 13944
		private Dictionary<int, Doctrine.WRA_Weapon> WRA_WeaponDictionary;

		// Token: 0x04003679 RID: 13945
		private Doctrine._WeaponControlStatus? WCS_Air;

		// Token: 0x0400367A RID: 13946
		private bool WCS_Air_Player;

		// Token: 0x0400367B RID: 13947
		private Doctrine._WeaponControlStatus? WCS_Surface;

		// Token: 0x0400367C RID: 13948
		private bool WCS_Surface_Player;

		// Token: 0x0400367D RID: 13949
		private Doctrine._WeaponControlStatus? WCS_Submarine;

		// Token: 0x0400367E RID: 13950
		private bool WCS_Submarine_Player = false;

		// Token: 0x0400367F RID: 13951
		private Doctrine._WeaponControlStatus? WCS_Land;

		// Token: 0x04003680 RID: 13952
		private bool WCS_Player_Land;

		// Token: 0x04003681 RID: 13953
		private Doctrine._GunStrafeGroundTargets? GunStrafeGroundTargets;

		// Token: 0x04003682 RID: 13954
		private bool GS_Player;

		// Token: 0x04003683 RID: 13955
		private Doctrine._IgnorePlottedCourseWhenAttacking? IgnorePlottedCourseWhenAttacking;

		// Token: 0x04003684 RID: 13956
		private bool IPCWA_Player;

		// Token: 0x04003685 RID: 13957
		private Doctrine._UseNuclear? Nukes;

		// Token: 0x04003686 RID: 13958
		private bool Nukes_Player;

		// Token: 0x04003687 RID: 13959
		private Doctrine._WeaponStateRTB? WinchesterShotgunRTB;

		// Token: 0x04003688 RID: 13960
		private bool WinchesterShotgunRTB_Player;

		// Token: 0x04003689 RID: 13961
		private Doctrine._FuelStateRTB? BingoJokerRTB;

		// Token: 0x0400368A RID: 13962
		private bool BingoJokerRTB_Player;

		// Token: 0x0400368B RID: 13963
		private Doctrine._JettisonOrdnance? JettisonOrdnance;

		// Token: 0x0400368C RID: 13964
		private bool JettisonOrdnance_Player;

		// Token: 0x0400368D RID: 13965
		private Doctrine._BehaviorTowardsAmbigousTarget? BehaviorTowardsAmbigousTarget;

		// Token: 0x0400368E RID: 13966
		private bool BehaviorTowardsAmbigousTarget_Player;

		// Token: 0x0400368F RID: 13967
		private Doctrine._AutomaticEvasion? AutomaticEvasion;

		// Token: 0x04003690 RID: 13968
		private bool AE_Player;

		// Token: 0x04003691 RID: 13969
		private Doctrine._MaintainStandoff? MaintainStandoff;

		// Token: 0x04003692 RID: 13970
		private bool MS_Player;

		// Token: 0x04003693 RID: 13971
		private Doctrine._UseRefuel? UseRefuel;

		// Token: 0x04003694 RID: 13972
		private bool UR_Player;

		// Token: 0x04003695 RID: 13973
		private Doctrine._RefuelSelection? RefuelSelection;

		// Token: 0x04003696 RID: 13974
		private bool RS_Player;

		// Token: 0x04003697 RID: 13975
		private Doctrine._ShootTourists? ShootTourists;

		// Token: 0x04003698 RID: 13976
		private bool ST_Player;

		// Token: 0x04003699 RID: 13977
		private Doctrine._UseSAMsInASuWMode? SAM_ASUW;

		// Token: 0x0400369A RID: 13978
		private bool SAM_ASUW_Player;

		// Token: 0x0400369B RID: 13979
		private Doctrine._IgnoreEMCONUnderAttack? IgnoreEMCONUnderAttack;

		// Token: 0x0400369C RID: 13980
		private bool IgnoreEMCONUnderAttack_Player;

		// Token: 0x0400369D RID: 13981
		private Doctrine._QuickTurnAround? QuickTurnAround;

		// Token: 0x0400369E RID: 13982
		private bool QTA_Player;

		// Token: 0x0400369F RID: 13983
		private Doctrine._AirOpsTempo? AirOpsTempo;

		// Token: 0x040036A0 RID: 13984
		private bool AirOpsTempo_Player;

		// Token: 0x040036A1 RID: 13985
		private Doctrine._FuelState? BingoJoker;

		// Token: 0x040036A2 RID: 13986
		private bool BingoJoker_Player;

		// Token: 0x040036A3 RID: 13987
		private Doctrine._WeaponState? WinchesterShotgun;

		// Token: 0x040036A4 RID: 13988
		private bool WinchesterShotgun_Player;

		// Token: 0x040036A5 RID: 13989
		private Doctrine._UseTorpedoesKinematicRange? UseTorpedoesKinematicRange;

		// Token: 0x040036A6 RID: 13990
		private bool UseTorpedoesKinematicRange_Player;

		// Token: 0x040036A7 RID: 13991
		private Doctrine._RefuelAlliedUnits? RefuelAllies;

		// Token: 0x040036A8 RID: 13992
		private bool RefuelAllies_Player;

		// Token: 0x040036A9 RID: 13993
		private Doctrine._AvoidContactWhenPossible? AvoidContact;

		// Token: 0x040036AA RID: 13994
		private bool AvoidContact_Player;

		// Token: 0x040036AB RID: 13995
		private Doctrine._DiveOnContact? DiveWhenThreatsDetected;

		// Token: 0x040036AC RID: 13996
		private bool DiveWhenThreatsDetected_Player;

		// Token: 0x040036AD RID: 13997
		private Doctrine._RechargeBatteryPercentage? RechargePercentagePatrol;

		// Token: 0x040036AE RID: 13998
		private bool RechargePercentagePatrol_Player;

		// Token: 0x040036AF RID: 13999
		private Doctrine._RechargeBatteryPercentage? RechargePercentageAttack;

		// Token: 0x040036B0 RID: 14000
		private bool RechargePercentageAttack_Player;

		// Token: 0x040036B1 RID: 14001
		private Doctrine._UseAIP? AIPUsage;

		// Token: 0x040036B2 RID: 14002
		private bool AIPUsage_Player;

		// Token: 0x040036B3 RID: 14003
		private Doctrine._UseDippingSonar? DippingSonar;

		// Token: 0x040036B4 RID: 14004
		private bool DippingSonar_Player;

		// Token: 0x040036B5 RID: 14005
		private Doctrine._DamageThreshold? WithdrawDamageThreshold;

		// Token: 0x040036B6 RID: 14006
		private Doctrine._FuelQuantityThreshold? WithdrawFuelThreshold;

		// Token: 0x040036B7 RID: 14007
		private Doctrine._WeaponQuantityThreshold? WithdrawAttackThreshold;

		// Token: 0x040036B8 RID: 14008
		private Doctrine._WeaponQuantityThreshold? WithdrawDefenceThreshold;

		// Token: 0x040036B9 RID: 14009
		private Doctrine._DamageThreshold? RedeployDamageThreshold;

		// Token: 0x040036BA RID: 14010
		private Doctrine._FuelQuantityThreshold? RedeployFuelThreshold;

		// Token: 0x040036BB RID: 14011
		private Doctrine._WeaponQuantityThreshold? RedeployAttackThreshold;

		// Token: 0x040036BC RID: 14012
		private Doctrine._WeaponQuantityThreshold? RedeployDefenceThreshold;

		// Token: 0x040036BD RID: 14013
		[CompilerGenerated]
		private static Doctrine.Delegate9 delegate9_0;

		// Token: 0x040036BE RID: 14014
		[CompilerGenerated]
		private static Doctrine.Delegate10 delegate10_0;

		// Token: 0x040036BF RID: 14015
		public bool bool_30;

		// Token: 0x040036C0 RID: 14016
		private Doctrine m_Doctrine;

		// Token: 0x02000BD2 RID: 3026
		// (Invoke) Token: 0x060065D5 RID: 26069
		public delegate void Delegate9(Subject theSubject, bool? viaMainForm, bool MultipleUnits, bool ViaDoctrineForm, bool ViaRightColumn, bool viaFlightPlanEditor);

		// Token: 0x02000BD3 RID: 3027
		// (Invoke) Token: 0x060065D9 RID: 26073
		public delegate void Delegate10(Subject theSubject, bool? viaMainForm, bool MultipleUnits, bool ViaDoctrineForm, bool ViaRightColumn, bool viaFlightPlanEditor);

		// Token: 0x02000BD4 RID: 3028
		public enum _BehaviorTowardsAmbigousTarget : byte
		{
			// Token: 0x040036C2 RID: 14018
			Ignore,
			// Token: 0x040036C3 RID: 14019
			Optimistic,
			// Token: 0x040036C4 RID: 14020
			Pessimistic,
			// Token: 0x040036C5 RID: 14021
			const_3,
			// Token: 0x040036C6 RID: 14022
			const_4
		}

		// Token: 0x02000BD5 RID: 3029
		public enum _WeaponControlStatus : byte
		{
			// Token: 0x040036C8 RID: 14024
			Free,
			// Token: 0x040036C9 RID: 14025
			Tight,
			// Token: 0x040036CA RID: 14026
			Hold,
			// Token: 0x040036CB RID: 14027
			const_3,
			// Token: 0x040036CC RID: 14028
			const_4
		}

		// Token: 0x02000BD6 RID: 3030
		public enum _QuickTurnAround : byte
		{
			// Token: 0x040036CE RID: 14030
			const_0,
			// Token: 0x040036CF RID: 14031
			const_1,
			// Token: 0x040036D0 RID: 14032
			const_2,
			// Token: 0x040036D1 RID: 14033
			const_3,
			// Token: 0x040036D2 RID: 14034
			const_4
		}

		// Token: 0x02000BD7 RID: 3031
		public enum _AirOpsTempo : byte
		{
			// Token: 0x040036D4 RID: 14036
			const_0,
			// Token: 0x040036D5 RID: 14037
			const_1,
			// Token: 0x040036D6 RID: 14038
			const_2,
			// Token: 0x040036D7 RID: 14039
			const_3
		}

		// Token: 0x02000BD8 RID: 3032
		public enum _WeaponState
		{
			// Token: 0x040036D9 RID: 14041
			LoadoutSetting,
			// Token: 0x040036DA RID: 14042
			Winchester = 2001,
			// Token: 0x040036DB RID: 14043
			Winchester_ToO,
			// Token: 0x040036DC RID: 14044
			ShotgunBVR = 3001,
			// Token: 0x040036DD RID: 14045
			ShotgunBVR_WVR,
			// Token: 0x040036DE RID: 14046
			ShotgunBVR_WVR_Guns,
			// Token: 0x040036DF RID: 14047
			ShotgunOneEngagementBVR = 5001,
			// Token: 0x040036E0 RID: 14048
			ShotgunOneEngagementBVR_Opportunity_WVR,
			// Token: 0x040036E1 RID: 14049
			ShotgunOneEngagementBVR_Opportunity_WVR_Guns,
			// Token: 0x040036E2 RID: 14050
			ShotgunOneEngagementBVR_And_WVR = 5005,
			// Token: 0x040036E3 RID: 14051
			ShotgunOneEngagementBVR_And_WVR_Opportunity_Guns,
			// Token: 0x040036E4 RID: 14052
			ShotgunOneEngagementWVR = 5011,
			// Token: 0x040036E5 RID: 14053
			ShotgunOneEngagementWVR_Guns,
			// Token: 0x040036E6 RID: 14054
			ShotgunOneEngagementGun = 5021,
			// Token: 0x040036E7 RID: 14055
			Shotgun25 = 4001,
			// Token: 0x040036E8 RID: 14056
			Shotgun25_ToO,
			// Token: 0x040036E9 RID: 14057
			Shotgun50 = 4011,
			// Token: 0x040036EA RID: 14058
			Shotgun50_ToO,
			// Token: 0x040036EB RID: 14059
			Shotgun75 = 4021,
			// Token: 0x040036EC RID: 14060
			Shotgun75_ToO,
			// Token: 0x040036ED RID: 14061
			Various = 1,
			// Token: 0x040036EE RID: 14062
			NotConfigured
		}

		// Token: 0x02000BD9 RID: 3033
		public enum _FuelState : byte
		{
			// Token: 0x040036F0 RID: 14064
			Bingo,
			// Token: 0x040036F1 RID: 14065
			Joker10Percent,
			// Token: 0x040036F2 RID: 14066
			Joker20Percent,
			// Token: 0x040036F3 RID: 14067
			Joker25Percent,
			// Token: 0x040036F4 RID: 14068
			Joker30Percent,
			// Token: 0x040036F5 RID: 14069
			Joker40Percent,
			// Token: 0x040036F6 RID: 14070
			Joker50Percent,
			// Token: 0x040036F7 RID: 14071
			Joker60Percent,
			// Token: 0x040036F8 RID: 14072
			Joker70Percent,
			// Token: 0x040036F9 RID: 14073
			Joker75Percent,
			// Token: 0x040036FA RID: 14074
			Joker80Percent,
			// Token: 0x040036FB RID: 14075
			Joker90Percent,
			// Token: 0x040036FC RID: 14076
			Various,
			// Token: 0x040036FD RID: 14077
			NotConfigured = 14
		}

		// Token: 0x02000BDA RID: 3034
		public enum _UseTorpedoesKinematicRange : byte
		{
			// Token: 0x040036FF RID: 14079
			const_0,
			// Token: 0x04003700 RID: 14080
			const_1,
			// Token: 0x04003701 RID: 14081
			const_2,
			// Token: 0x04003702 RID: 14082
			const_3,
			// Token: 0x04003703 RID: 14083
			const_4
		}

		// Token: 0x02000BDB RID: 3035
		public enum _UseRefuel : byte
		{
			// Token: 0x04003705 RID: 14085
			const_0,
			// Token: 0x04003706 RID: 14086
			const_1,
			// Token: 0x04003707 RID: 14087
			const_2,
			// Token: 0x04003708 RID: 14088
			const_3,
			// Token: 0x04003709 RID: 14089
			const_4
		}

		// Token: 0x02000BDC RID: 3036
		public enum _RefuelSelection : byte
		{
			// Token: 0x0400370B RID: 14091
			const_0,
			// Token: 0x0400370C RID: 14092
			const_1,
			// Token: 0x0400370D RID: 14093
			const_2,
			// Token: 0x0400370E RID: 14094
			const_3,
			// Token: 0x0400370F RID: 14095
			const_4
		}

		// Token: 0x02000BDD RID: 3037
		public enum _UseSAMsInASuWMode : byte
		{
			// Token: 0x04003711 RID: 14097
			const_0,
			// Token: 0x04003712 RID: 14098
			const_1,
			// Token: 0x04003713 RID: 14099
			const_2,
			// Token: 0x04003714 RID: 14100
			const_3
		}

		// Token: 0x02000BDE RID: 3038
		public enum _ShootTourists : byte
		{
			// Token: 0x04003716 RID: 14102
			const_0,
			// Token: 0x04003717 RID: 14103
			const_1,
			// Token: 0x04003718 RID: 14104
			const_2,
			// Token: 0x04003719 RID: 14105
			const_3
		}

		// Token: 0x02000BDF RID: 3039
		public enum _IgnoreEMCONUnderAttack : byte
		{
			// Token: 0x0400371B RID: 14107
			const_0,
			// Token: 0x0400371C RID: 14108
			const_1,
			// Token: 0x0400371D RID: 14109
			const_2,
			// Token: 0x0400371E RID: 14110
			const_3
		}

		// Token: 0x02000BE0 RID: 3040
		public enum _AutomaticEvasion : byte
		{
			// Token: 0x04003720 RID: 14112
			const_0,
			// Token: 0x04003721 RID: 14113
			const_1,
			// Token: 0x04003722 RID: 14114
			const_2,
			// Token: 0x04003723 RID: 14115
			const_3
		}

		// Token: 0x02000BE1 RID: 3041
		public enum _MaintainStandoff : byte
		{
			// Token: 0x04003725 RID: 14117
			const_0,
			// Token: 0x04003726 RID: 14118
			const_1,
			// Token: 0x04003727 RID: 14119
			const_2,
			// Token: 0x04003728 RID: 14120
			const_3
		}

		// Token: 0x02000BE2 RID: 3042
		public enum _GunStrafeGroundTargets : byte
		{
			// Token: 0x0400372A RID: 14122
			No,
			// Token: 0x0400372B RID: 14123
			Yes,
			// Token: 0x0400372C RID: 14124
			Various,
			// Token: 0x0400372D RID: 14125
			NotConfigured
		}

		// Token: 0x02000BE3 RID: 3043
		public enum _IgnorePlottedCourseWhenAttacking : byte
		{
			// Token: 0x0400372F RID: 14127
			const_0,
			// Token: 0x04003730 RID: 14128
			const_1,
			// Token: 0x04003731 RID: 14129
			const_2,
			// Token: 0x04003732 RID: 14130
			const_3
		}

		// Token: 0x02000BE4 RID: 3044
		public enum _UseNuclear : byte
		{
			// Token: 0x04003734 RID: 14132
			const_0,
			// Token: 0x04003735 RID: 14133
			const_1,
			// Token: 0x04003736 RID: 14134
			const_2,
			// Token: 0x04003737 RID: 14135
			const_3
		}

		// Token: 0x02000BE5 RID: 3045
		public enum _WeaponStateRTB : byte
		{
			// Token: 0x04003739 RID: 14137
			No,
			// Token: 0x0400373A RID: 14138
			YesLastUnit,
			// Token: 0x0400373B RID: 14139
			YesFirstUnit,
			// Token: 0x0400373C RID: 14140
			YesLeaveGroup,
			// Token: 0x0400373D RID: 14141
			Various,
			// Token: 0x0400373E RID: 14142
			NotConfigured
		}

		// Token: 0x02000BE6 RID: 3046
		public enum _FuelStateRTB : byte
		{
			// Token: 0x04003740 RID: 14144
			No,
			// Token: 0x04003741 RID: 14145
			YesLastUnit,
			// Token: 0x04003742 RID: 14146
			YesFirstUnit,
			// Token: 0x04003743 RID: 14147
			YesLeaveGroup,
			// Token: 0x04003744 RID: 14148
			Various,
			// Token: 0x04003745 RID: 14149
			NotConfigured
		}

		// Token: 0x02000BE7 RID: 3047
		public enum _JettisonOrdnance : byte
		{
			// Token: 0x04003747 RID: 14151
			No,
			// Token: 0x04003748 RID: 14152
			Yes,
			// Token: 0x04003749 RID: 14153
			Various,
			// Token: 0x0400374A RID: 14154
			NotConfigured
		}

		// Token: 0x02000BE8 RID: 3048
		public enum _RefuelAlliedUnits : byte
		{
			// Token: 0x0400374C RID: 14156
			Yes,
			// Token: 0x0400374D RID: 14157
			Yes_ReceiveOnly,
			// Token: 0x0400374E RID: 14158
			Yes_DeliverOnly,
			// Token: 0x0400374F RID: 14159
			No,
			// Token: 0x04003750 RID: 14160
			Various,
			// Token: 0x04003751 RID: 14161
			NotConfigured
		}

		// Token: 0x02000BE9 RID: 3049
		public enum _AvoidContactWhenPossible : byte
		{
			// Token: 0x04003753 RID: 14163
			No,
			// Token: 0x04003754 RID: 14164
			Yes_ExceptSelfDefence,
			// Token: 0x04003755 RID: 14165
			Yes_Always,
			// Token: 0x04003756 RID: 14166
			Various,
			// Token: 0x04003757 RID: 14167
			NotConfigured
		}

		// Token: 0x02000BEA RID: 3050
		public enum _DiveOnContact : byte
		{
			// Token: 0x04003759 RID: 14169
			Yes,
			// Token: 0x0400375A RID: 14170
			Yes_ESM_Only,
			// Token: 0x0400375B RID: 14171
			Yes_Ships20nm_Aircraft30nm,
			// Token: 0x0400375C RID: 14172
			No,
			// Token: 0x0400375D RID: 14173
			Various,
			// Token: 0x0400375E RID: 14174
			NotConfigured
		}

		// Token: 0x02000BEB RID: 3051
		public enum _RechargeBatteryPercentage
		{
			// Token: 0x04003760 RID: 14176
			Recharge_Empty,
			// Token: 0x04003761 RID: 14177
			Recharge_10_Percent = 10,
			// Token: 0x04003762 RID: 14178
			Recharge_20_Percent = 20,
			// Token: 0x04003763 RID: 14179
			Recharge_30_Percent = 30,
			// Token: 0x04003764 RID: 14180
			Recharge_40_Percent = 40,
			// Token: 0x04003765 RID: 14181
			Recharge_50_Percent = 50,
			// Token: 0x04003766 RID: 14182
			Recharge_60_Percent = 60,
			// Token: 0x04003767 RID: 14183
			Recharge_70_Percent = 70,
			// Token: 0x04003768 RID: 14184
			Recharge_80_Percent = 80,
			// Token: 0x04003769 RID: 14185
			Recharge_90_Percent = 90,
			// Token: 0x0400376A RID: 14186
			Various = -100,
			// Token: 0x0400376B RID: 14187
			NotConfigured = -101
		}

		// Token: 0x02000BEC RID: 3052
		public enum _UseAIP : byte
		{
			// Token: 0x0400376D RID: 14189
			No,
			// Token: 0x0400376E RID: 14190
			Yes_AttackOnly,
			// Token: 0x0400376F RID: 14191
			Yes_Always,
			// Token: 0x04003770 RID: 14192
			Various,
			// Token: 0x04003771 RID: 14193
			NotConfigured
		}

		// Token: 0x02000BED RID: 3053
		public enum _UseDippingSonar : byte
		{
			// Token: 0x04003773 RID: 14195
			Automatically_HoverAnd150ft,
			// Token: 0x04003774 RID: 14196
			ManualAndMissionOnly,
			// Token: 0x04003775 RID: 14197
			Various,
			// Token: 0x04003776 RID: 14198
			NotConfigured
		}

		// Token: 0x02000BEE RID: 3054
		public enum _DamageThreshold : short
		{
			// Token: 0x04003778 RID: 14200
			Ignore,
			// Token: 0x04003779 RID: 14201
			Percent5,
			// Token: 0x0400377A RID: 14202
			Percent25,
			// Token: 0x0400377B RID: 14203
			Percent50,
			// Token: 0x0400377C RID: 14204
			Percent75,
			// Token: 0x0400377D RID: 14205
			Various,
			// Token: 0x0400377E RID: 14206
			NotConfigured
		}

		// Token: 0x02000BEF RID: 3055
		public enum _FuelQuantityThreshold : short
		{
			// Token: 0x04003780 RID: 14208
			Ignore,
			// Token: 0x04003781 RID: 14209
			Bingo,
			// Token: 0x04003782 RID: 14210
			Percent25,
			// Token: 0x04003783 RID: 14211
			Percent50,
			// Token: 0x04003784 RID: 14212
			Percent75,
			// Token: 0x04003785 RID: 14213
			Percent100,
			// Token: 0x04003786 RID: 14214
			Various,
			// Token: 0x04003787 RID: 14215
			NotConfigured
		}

		// Token: 0x02000BF0 RID: 3056
		public enum _WeaponQuantityThreshold : short
		{
			// Token: 0x04003789 RID: 14217
			Ignore,
			// Token: 0x0400378A RID: 14218
			Exhausted,
			// Token: 0x0400378B RID: 14219
			Percent25,
			// Token: 0x0400378C RID: 14220
			Percent50,
			// Token: 0x0400378D RID: 14221
			Percent75,
			// Token: 0x0400378E RID: 14222
			Percent100,
			// Token: 0x0400378F RID: 14223
			LoadFullWeapons,
			// Token: 0x04003790 RID: 14224
			Various,
			// Token: 0x04003791 RID: 14225
			NotConfigured
		}

		// Token: 0x02000BF1 RID: 3057
		public sealed class EMCON_Settings
		{
			// Token: 0x060065DC RID: 26076 RVA: 0x00004A21 File Offset: 0x00002C21
			public EMCON_Settings()
			{
			}

			// Token: 0x060065DD RID: 26077 RVA: 0x0002C23C File Offset: 0x0002A43C
			public EMCON_Settings(Doctrine.EMCON_Settings.Enum36 enum36_3, Doctrine.EMCON_Settings.Enum36 enum36_4, Doctrine.EMCON_Settings.Enum36 enum36_5)
			{
				this.EMCON_SettingsForRadar = enum36_3;
				this.EMCON_SettingsForSonar = enum36_4;
				this.EMCON_SettingsForOECM = enum36_5;
			}

			// Token: 0x060065DE RID: 26078 RVA: 0x0002C259 File Offset: 0x0002A459
			public bool method_0()
			{
				return this.EMCON_SettingsForRadar == Doctrine.EMCON_Settings.Enum36.const_1 || this.EMCON_SettingsForSonar == Doctrine.EMCON_Settings.Enum36.const_1 || this.EMCON_SettingsForOECM == Doctrine.EMCON_Settings.Enum36.const_1;
			}

			// Token: 0x060065DF RID: 26079 RVA: 0x0034D680 File Offset: 0x0034B880
			public Doctrine.EMCON_Settings.Enum36 GetEMCON_SettingsForRadar()
			{
				return this.EMCON_SettingsForRadar;
			}

			// Token: 0x060065E0 RID: 26080 RVA: 0x0034D698 File Offset: 0x0034B898
			public Doctrine.EMCON_Settings.Enum36 GetEMCON_SettingsForSonar()
			{
				return this.EMCON_SettingsForSonar;
			}

			// Token: 0x060065E1 RID: 26081 RVA: 0x0034D6B0 File Offset: 0x0034B8B0
			public Doctrine.EMCON_Settings.Enum36 GetEMCON_SettingsForOECM()
			{
				return this.EMCON_SettingsForOECM;
			}

			// Token: 0x060065E2 RID: 26082 RVA: 0x0034D6C8 File Offset: 0x0034B8C8
			public static Doctrine.EMCON_Settings.Enum36 smethod_0(int int_0)
			{
				Doctrine.EMCON_Settings.Enum36 result;
				if (int_0 != 0)
				{
					if (int_0 != 1)
					{
						result = Doctrine.EMCON_Settings.Enum36.const_3;
					}
					else
					{
						result = Doctrine.EMCON_Settings.Enum36.const_1;
					}
				}
				else
				{
					result = Doctrine.EMCON_Settings.Enum36.const_0;
				}
				return result;
			}

			// Token: 0x04003792 RID: 14226
			private Doctrine.EMCON_Settings.Enum36 EMCON_SettingsForRadar;

			// Token: 0x04003793 RID: 14227
			private Doctrine.EMCON_Settings.Enum36 EMCON_SettingsForSonar;

			// Token: 0x04003794 RID: 14228
			private Doctrine.EMCON_Settings.Enum36 EMCON_SettingsForOECM;

			// Token: 0x02000BF2 RID: 3058
			public enum Enum36 : byte
			{
				// Token: 0x04003796 RID: 14230
				const_0,
				// Token: 0x04003797 RID: 14231
				const_1,
				// Token: 0x04003798 RID: 14232
				const_2,
				// Token: 0x04003799 RID: 14233
				const_3,
				// Token: 0x0400379A RID: 14234
				const_4
			}
		}

		// Token: 0x02000BF3 RID: 3059
		public sealed class WRA_Weapon
		{
			// Token: 0x060065E3 RID: 26083 RVA: 0x0002C279 File Offset: 0x0002A479
			public WRA_Weapon()
			{
				this.WRA_WeaponTargetArray = new Doctrine.WRA_WeaponTarget[0];
			}

			// Token: 0x060065E4 RID: 26084 RVA: 0x0034D6F0 File Offset: 0x0034B8F0
			public WRA_Weapon(ref Weapon weapon_1, Scenario scenario_0)
			{
				this.WRA_WeaponTargetArray = new Doctrine.WRA_WeaponTarget[0];
				if (weapon_1.weaponTarget.IsAircraft || weapon_1.weaponTarget.IsHelicopter || weapon_1.weaponTarget.IsGuidedWeapon || weapon_1.weaponTarget.IsSatellite)
				{
					Doctrine.WRA_WeaponTarget class121_ = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_);
				}
				if (weapon_1.weaponTarget.IsAircraft)
				{
					Doctrine.WRA_WeaponTarget class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_4th_Generation);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_3rd_Generation);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Less_Capable);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Bombers);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Recon_EW);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_AEW);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
					class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
				}
				else if (weapon_1.weaponTarget.IsHelicopter)
				{
					Doctrine.WRA_WeaponTarget class121_3 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_3);
				}
				if (weapon_1.weaponTarget.IsGuidedWeapon)
				{
					Doctrine.WRA_WeaponTarget class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
					class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
					class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
					class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
					class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
					class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
				}
				if (weapon_1.weaponTarget.IsSatellite)
				{
					Doctrine.WRA_WeaponTarget class121_5 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Satellite_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_5);
				}
				if (weapon_1.weaponTarget.IsSurfaceShip)
				{
					Doctrine.WRA_WeaponTarget class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Carrier_25001_45000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Carrier_45001_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_5001_10000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_10001_25000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_25001_45000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_45001_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_501_1500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_1501_5000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_5001_10000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_10001_25000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_25001_45000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_45001_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_501_1500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_1501_5000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_5001_10000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_10001_25000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_25001_45000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_45001_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_501_1500_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_1501_5000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_5001_10000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_10001_25000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_25001_45000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_45001_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
					class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Submarine_Surfaced);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
				}
				if (weapon_1.weaponTarget.IsSubsurface)
				{
					Doctrine.WRA_WeaponTarget class121_7 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Submarine_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_7);
					class121_7 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_7);
				}
				if (weapon_1.weaponTarget.IsSoftLandStructures || weapon_1.weaponTarget.IsHardLandStructures || weapon_1.weaponTarget.IsSoftMobileUnit || weapon_1.weaponTarget.IsHardMobileUnit || weapon_1.weaponTarget.IsRunway || weapon_1.weaponTarget.IsUnderwaterStructure || weapon_1.weaponTarget.bool_15 || weapon_1.weaponTarget.IsAirfield)
				{
					Doctrine.WRA_WeaponTarget class121_8 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_8);
				}
				if (weapon_1.weaponTarget.IsSoftLandStructures || weapon_1.weaponTarget.IsHardLandStructures)
				{
					Doctrine.WRA_WeaponTarget class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Reveted);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Bunker);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Underground);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Open);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
				}
				if (weapon_1.weaponTarget.IsRunway)
				{
					Doctrine.WRA_WeaponTarget class121_10 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_10);
					class121_10 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Runway);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_10);
					class121_10 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Runway_Grade_Taxiway);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_10);
					class121_10 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Runway_Access_Point);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_10);
				}
				if (weapon_1.weaponTarget.IsRadar)
				{
					Doctrine.WRA_WeaponTarget class121_11 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Radar_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_11);
				}
				if (weapon_1.weaponTarget.IsSoftMobileUnit || weapon_1.weaponTarget.IsHardMobileUnit || (weapon_1.weaponTarget.IsSoftLandStructures && !weapon_1.weaponCode.Weapon_PreBriefedTargetOnly && !weapon_1.weaponTarget.IsSoftMobileUnit) || (weapon_1.weaponTarget.IsHardLandStructures && !weapon_1.weaponCode.Weapon_PreBriefedTargetOnly && !weapon_1.weaponTarget.IsHardMobileUnit))
				{
					Doctrine.WRA_WeaponTarget class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
					class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
					class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
					class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
					class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
				}
				if (weapon_1.weaponTarget.IsUnderwaterStructure)
				{
					Doctrine.WRA_WeaponTarget class121_13 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Underwater_Structure);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_13);
				}
				if (weapon_1.weaponTarget.IsAirfield)
				{
					Doctrine.WRA_WeaponTarget class121_14 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_14);
				}
			}

			// Token: 0x060065E5 RID: 26085 RVA: 0x0034E19C File Offset: 0x0034C39C
			public void method_0(ref Weapon weapon_1)
			{
				if (weapon_1.weaponTarget.IsAircraft || weapon_1.weaponTarget.IsHelicopter || weapon_1.weaponTarget.IsGuidedWeapon || weapon_1.weaponTarget.IsSatellite)
				{
					Doctrine.WRA_WeaponTarget class121_ = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_);
				}
				if (weapon_1.weaponTarget.IsAircraft)
				{
					Doctrine.WRA_WeaponTarget class121_2 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified, new int?(2), new int?(1), new int?(0), null);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_2);
				}
				if (weapon_1.weaponTarget.IsHelicopter || weapon_1.weaponTarget.IsAircraft)
				{
					Doctrine.WRA_WeaponTarget class121_3 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified, new int?(2), new int?(1), new int?(0), null);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_3);
				}
				if (weapon_1.weaponTarget.IsGuidedWeapon)
				{
					Doctrine.WRA_WeaponTarget class121_4 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified, new int?(2), new int?(1), new int?(0), null);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_4);
				}
				if (weapon_1.weaponTarget.IsSatellite)
				{
					Doctrine.WRA_WeaponTarget class121_5 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Satellite_Unspecified, new int?(2), new int?(1), new int?(0), null);
					ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_5);
				}
				if (weapon_1.weaponTarget.IsSurfaceShip)
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						if (weapon_1.GetWeaponType() == Weapon._WeaponType.Torpedo)
						{
							Doctrine.WRA_WeaponTarget class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
							ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
							class121_6 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Unspecified, new int?(2), new int?(1), new int?(0), null);
							ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_6);
						}
						else
						{
							Doctrine.WRA_WeaponTarget class121_7 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
							ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_7);
							class121_7 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Unspecified, new int?(-2), new int?(-99), new int?(0), null);
							ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_7);
						}
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_8 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_8);
						class121_8 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Ship_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_8);
					}
				}
				if (weapon_1.weaponTarget.IsSubsurface)
				{
					if (weapon_1.GetWeaponType() == Weapon._WeaponType.DepthCharge)
					{
						Doctrine.WRA_WeaponTarget class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Submarine_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
						class121_9 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_9);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_10 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Submarine_Unspecified, new int?(2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_10);
						class121_10 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_10);
					}
				}
				if (weapon_1.weaponTarget.IsSoftLandStructures || weapon_1.weaponTarget.IsHardLandStructures || weapon_1.weaponTarget.IsSoftMobileUnit || weapon_1.weaponTarget.IsHardMobileUnit || weapon_1.weaponTarget.IsRunway || weapon_1.weaponTarget.IsUnderwaterStructure || weapon_1.weaponTarget.bool_15 || weapon_1.weaponTarget.IsAirfield)
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						Doctrine.WRA_WeaponTarget class121_11 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_11);
						class121_11 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified, new int?(2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_11);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
						class121_12 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_12);
					}
				}
				if (weapon_1.weaponTarget.IsSoftLandStructures || weapon_1.weaponTarget.IsHardLandStructures)
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						Doctrine.WRA_WeaponTarget class121_13 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified, new int?(-2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_13);
						class121_13 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified, new int?(-2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_13);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_14 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_14);
						class121_14 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_14);
					}
				}
				if (weapon_1.weaponTarget.IsRadar)
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						Doctrine.WRA_WeaponTarget class121_15 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Radar_Unspecified, new int?(-2), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_15);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_16 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Radar_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_16);
					}
				}
				if (weapon_1.weaponTarget.IsSoftMobileUnit || (weapon_1.weaponTarget.IsSoftLandStructures && !weapon_1.weaponCode.Weapon_PreBriefedTargetOnly && !weapon_1.weaponTarget.IsSoftMobileUnit) || weapon_1.weaponTarget.IsHardMobileUnit || (weapon_1.weaponTarget.IsHardLandStructures && !weapon_1.weaponCode.Weapon_PreBriefedTargetOnly && !weapon_1.weaponTarget.IsHardMobileUnit))
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						Doctrine.WRA_WeaponTarget class121_17 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified, new int?(-2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_17);
						class121_17 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified, new int?(-2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_17);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_18 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_18);
						class121_18 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_18);
					}
				}
				if (weapon_1.weaponTarget.IsUnderwaterStructure)
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						Doctrine.WRA_WeaponTarget class121_19 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Underwater_Structure, new int?(-2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_19);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_20 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Underwater_Structure, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_20);
					}
				}
				if (weapon_1.weaponTarget.IsAirfield)
				{
					if (weapon_1.GetWeaponType() != Weapon._WeaponType.Gun && weapon_1.GetWeaponType() != Weapon._WeaponType.Rocket && weapon_1.GetWeaponType() != Weapon._WeaponType.IronBomb)
					{
						Doctrine.WRA_WeaponTarget class121_21 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield, new int?(-2), new int?(1), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_21);
					}
					else
					{
						Doctrine.WRA_WeaponTarget class121_22 = new Doctrine.WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield, new int?(-99), new int?(-99), new int?(0), null);
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref this.WRA_WeaponTargetArray, class121_22);
					}
				}
			}

			// Token: 0x060065E6 RID: 26086 RVA: 0x0034EC24 File Offset: 0x0034CE24
			public Weapon method_1(Scenario scenario_0, int int_0)
			{
				if (Information.IsNothing(this.weapon_0))
				{
					if (this.method_2(scenario_0, int_0))
					{
						this.weapon_0 = scenario_0.GetWeapon(int_0);
					}
					else
					{
						this.weapon_0 = Weapon.GetWeapon(ref scenario_0, int_0, null);
					}
				}
				return this.weapon_0;
			}

			// Token: 0x060065E7 RID: 26087 RVA: 0x0034EC74 File Offset: 0x0034CE74
			public bool method_2(Scenario scenario_0, int int_0)
			{
				SQLiteConnection sQLiteConnection = scenario_0.GetSQLiteConnection();
				Weapon._WeaponType weaponType = DBFunctions.GetWeaponType(int_0, ref sQLiteConnection);
				bool flag = false;
				bool result;
				if (weaponType <= Weapon._WeaponType.DepthCharge)
				{
					if (weaponType - Weapon._WeaponType.Rocket <= 2 || weaponType == Weapon._WeaponType.DepthCharge)
					{
						result = true;
						return result;
					}
				}
				else if (weaponType == Weapon._WeaponType.Laser || weaponType - Weapon._WeaponType.Troops <= 1)
				{
					result = true;
					return result;
				}
				result = flag;
				return result;
			}

			// Token: 0x0400379B RID: 14235
			public Doctrine.WRA_WeaponTarget[] WRA_WeaponTargetArray;

			// Token: 0x0400379C RID: 14236
			private Weapon weapon_0;
		}

		// Token: 0x02000BF4 RID: 3060
		public sealed class WRA_WeaponTarget
		{
			// Token: 0x060065E8 RID: 26088 RVA: 0x00004A21 File Offset: 0x00002C21
			public WRA_WeaponTarget()
			{
			}

			// Token: 0x060065E9 RID: 26089 RVA: 0x0034ECE0 File Offset: 0x0034CEE0
			public WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_1)
			{
				try
				{
					this.WRA_WeaponTargetType = _WRA_WeaponTargetType_1;
					this.WeaponQty = null;
					this.ShooterQty = null;
					this.SelfDefenceRange = null;
					this.FiringRange = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101196", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x060065EA RID: 26090 RVA: 0x0034ED78 File Offset: 0x0034CF78
			public WRA_WeaponTarget(Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_1, int? nullable_4, int? nullable_5, int? nullable_6, int? nullable_7)
			{
				try
				{
					this.WRA_WeaponTargetType = _WRA_WeaponTargetType_1;
					this.WeaponQty = nullable_4;
					this.ShooterQty = nullable_5;
					this.SelfDefenceRange = nullable_6;
					this.FiringRange = nullable_7;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101203", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x0400379D RID: 14237
			public Doctrine._WRA_WeaponTargetType WRA_WeaponTargetType;

			// Token: 0x0400379E RID: 14238
			public int? WeaponQty;

			// Token: 0x0400379F RID: 14239
			public int? ShooterQty;

			// Token: 0x040037A0 RID: 14240
			public int? FiringRange;

			// Token: 0x040037A1 RID: 14241
			public int? SelfDefenceRange;
		}

		// Token: 0x02000BF5 RID: 3061
		public enum _WRA_WeaponTargetType
		{
			// Token: 0x040037A3 RID: 14243
			None = 1001,
			// Token: 0x040037A4 RID: 14244
			Decoy,
			// Token: 0x040037A5 RID: 14245
			Air_Contact_Unknown_Type = 1999,
			// Token: 0x040037A6 RID: 14246
			Aircraft_Unspecified,
			// Token: 0x040037A7 RID: 14247
			Aircraft_5th_Generation,
			// Token: 0x040037A8 RID: 14248
			Aircraft_4th_Generation,
			// Token: 0x040037A9 RID: 14249
			Aircraft_3rd_Generation,
			// Token: 0x040037AA RID: 14250
			Aircraft_Less_Capable,
			// Token: 0x040037AB RID: 14251
			Aircraft_High_Perf_Bombers = 2011,
			// Token: 0x040037AC RID: 14252
			Aircraft_Medium_Perf_Bombers,
			// Token: 0x040037AD RID: 14253
			Aircraft_Low_Perf_Bombers,
			// Token: 0x040037AE RID: 14254
			Aircraft_High_Perf_Recon_EW = 2021,
			// Token: 0x040037AF RID: 14255
			Aircraft_Medium_Perf_Recon_EW,
			// Token: 0x040037B0 RID: 14256
			Aircraft_Low_Perf_Recon_EW,
			// Token: 0x040037B1 RID: 14257
			Aircraft_AEW = 2031,
			// Token: 0x040037B2 RID: 14258
			Helicopter_Unspecified = 2100,
			// Token: 0x040037B3 RID: 14259
			Guided_Weapon_Unspecified = 2200,
			// Token: 0x040037B4 RID: 14260
			Guided_Weapon_Supersonic_Sea_Skimming,
			// Token: 0x040037B5 RID: 14261
			Guided_Weapon_Subsonic_Sea_Skimming,
			// Token: 0x040037B6 RID: 14262
			Guided_Weapon_Supersonic,
			// Token: 0x040037B7 RID: 14263
			Guided_Weapon_Subsonic,
			// Token: 0x040037B8 RID: 14264
			Guided_Weapon_Ballistic = 2211,
			// Token: 0x040037B9 RID: 14265
			Satellite_Unspecified = 2300,
			// Token: 0x040037BA RID: 14266
			Surface_Contact_Unknown_Type = 2999,
			// Token: 0x040037BB RID: 14267
			Ship_Unspecified,
			// Token: 0x040037BC RID: 14268
			Ship_Carrier_0_25000_tons,
			// Token: 0x040037BD RID: 14269
			Ship_Carrier_25001_45000_tons,
			// Token: 0x040037BE RID: 14270
			Ship_Carrier_45001_95000_tons,
			// Token: 0x040037BF RID: 14271
			Ship_Carrier_95000_tons,
			// Token: 0x040037C0 RID: 14272
			Ship_Surface_Combatant_0_500_tons = 3101,
			// Token: 0x040037C1 RID: 14273
			Ship_Surface_Combatant_501_1500_tons,
			// Token: 0x040037C2 RID: 14274
			Ship_Surface_Combatant_1501_5000_tons,
			// Token: 0x040037C3 RID: 14275
			Ship_Surface_Combatant_5001_10000_tons,
			// Token: 0x040037C4 RID: 14276
			Ship_Surface_Combatant_10001_25000_tons,
			// Token: 0x040037C5 RID: 14277
			Ship_Surface_Combatant_25001_45000_tons,
			// Token: 0x040037C6 RID: 14278
			Ship_Surface_Combatant_45001_95000_tons,
			// Token: 0x040037C7 RID: 14279
			Ship_Surface_Combatant_95000_tons,
			// Token: 0x040037C8 RID: 14280
			Ship_Amphibious_0_500_tons = 3201,
			// Token: 0x040037C9 RID: 14281
			Ship_Amphibious_501_1500_tons,
			// Token: 0x040037CA RID: 14282
			Ship_Amphibious_1501_5000_tons,
			// Token: 0x040037CB RID: 14283
			Ship_Amphibious_5001_10000_tons,
			// Token: 0x040037CC RID: 14284
			Ship_Amphibious_10001_25000_tons,
			// Token: 0x040037CD RID: 14285
			Ship_Amphibious_25001_45000_tons,
			// Token: 0x040037CE RID: 14286
			Ship_Amphibious_45001_95000_tons,
			// Token: 0x040037CF RID: 14287
			Ship_Amphibious_95000_tons,
			// Token: 0x040037D0 RID: 14288
			Ship_Auxiliary_0_500_tons = 3301,
			// Token: 0x040037D1 RID: 14289
			Ship_Auxiliary_501_1500_tons,
			// Token: 0x040037D2 RID: 14290
			Ship_Auxiliary_1501_5000_tons,
			// Token: 0x040037D3 RID: 14291
			Ship_Auxiliary_5001_10000_tons,
			// Token: 0x040037D4 RID: 14292
			Ship_Auxiliary_10001_25000_tons,
			// Token: 0x040037D5 RID: 14293
			Ship_Auxiliary_25001_45000_tons,
			// Token: 0x040037D6 RID: 14294
			Ship_Auxiliary_45001_95000_tons,
			// Token: 0x040037D7 RID: 14295
			Ship_Auxiliary_95000_tons,
			// Token: 0x040037D8 RID: 14296
			Ship_Merchant_Civilian_0_500_tons = 3401,
			// Token: 0x040037D9 RID: 14297
			Ship_Merchant_Civilian_501_1500_tons,
			// Token: 0x040037DA RID: 14298
			Ship_Merchant_Civilian_1501_5000_tons,
			// Token: 0x040037DB RID: 14299
			Ship_Merchant_Civilian_5001_10000_tons,
			// Token: 0x040037DC RID: 14300
			Ship_Merchant_Civilian_10001_25000_tons,
			// Token: 0x040037DD RID: 14301
			Ship_Merchant_Civilian_25001_45000_tons,
			// Token: 0x040037DE RID: 14302
			Ship_Merchant_Civilian_45001_95000_tons,
			// Token: 0x040037DF RID: 14303
			Ship_Merchant_Civilian_95000_tons,
			// Token: 0x040037E0 RID: 14304
			Submarine_Surfaced = 3501,
			// Token: 0x040037E1 RID: 14305
			Subsurface_Contact_Unknown_Type = 3999,
			// Token: 0x040037E2 RID: 14306
			Submarine_Unspecified,
			// Token: 0x040037E3 RID: 14307
			Land_Contact_Unknown_Type = 4999,
			// Token: 0x040037E4 RID: 14308
			Land_Structure_Soft_Unspecified,
			// Token: 0x040037E5 RID: 14309
			Land_Structure_Soft_Building_Surface,
			// Token: 0x040037E6 RID: 14310
			Land_Structure_Soft_Building_Reveted,
			// Token: 0x040037E7 RID: 14311
			Land_Structure_Soft_Structure_Open = 5005,
			// Token: 0x040037E8 RID: 14312
			Land_Structure_Soft_Structure_Reveted,
			// Token: 0x040037E9 RID: 14313
			Land_Structure_Soft_Aerostat_Moring = 5011,
			// Token: 0x040037EA RID: 14314
			Land_Structure_Hardened_Unspecified = 5100,
			// Token: 0x040037EB RID: 14315
			Land_Structure_Hardened_Building_Surface,
			// Token: 0x040037EC RID: 14316
			Land_Structure_Hardened_Building_Reveted,
			// Token: 0x040037ED RID: 14317
			Land_Structure_Hardened_Building_Bunker,
			// Token: 0x040037EE RID: 14318
			Land_Structure_Hardened_Building_Underground,
			// Token: 0x040037EF RID: 14319
			Land_Structure_Hardened_Structure_Open,
			// Token: 0x040037F0 RID: 14320
			Land_Structure_Hardened_Structure_Reveted,
			// Token: 0x040037F1 RID: 14321
			Runway_Facility_Unspecified = 5200,
			// Token: 0x040037F2 RID: 14322
			Runway,
			// Token: 0x040037F3 RID: 14323
			Runway_Grade_Taxiway,
			// Token: 0x040037F4 RID: 14324
			Runway_Access_Point,
			// Token: 0x040037F5 RID: 14325
			Radar_Unspecified = 5300,
			// Token: 0x040037F6 RID: 14326
			Mobile_Target_Soft_Unspecified = 5400,
			// Token: 0x040037F7 RID: 14327
			Mobile_Target_Soft_Mobile_Vehicle,
			// Token: 0x040037F8 RID: 14328
			Mobile_Target_Soft_Mobile_Personnel,
			// Token: 0x040037F9 RID: 14329
			Mobile_Target_Hardened_Unspecified = 5500,
			// Token: 0x040037FA RID: 14330
			Mobile_Target_Hardened_Mobile_Vehicle,
			// Token: 0x040037FB RID: 14331
			Underwater_Structure = 5601,
			// Token: 0x040037FC RID: 14332
			Air_Base_Single_Unit_Airfield = 5801
		}
	}
}
