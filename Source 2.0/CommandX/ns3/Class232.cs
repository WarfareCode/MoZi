using System;
using System.Collections;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000BAC RID: 2988
	public sealed class Class232
	{
		// Token: 0x0600629D RID: 25245 RVA: 0x00301738 File Offset: 0x002FF938
		public static int GetFuelForPitchEnabledWeapons(int WeaponDBID, Scenario scenario)
		{
			Weapon weapon = Weapon.GetWeapon(ref scenario, WeaponDBID, null);
			Aircraft aircraft = new Aircraft(ref scenario, null);
			aircraft.SetLongitude(null, 2.0);
			aircraft.SetLatitude(null, 2.0);
			aircraft.SetAltitude_ASL(false, 10000f);
			aircraft.SetCurrentSpeed(660f);
			ActiveUnit activeUnit = aircraft;
			float num = 0f;
			int val = 0;
			if (weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && !weapon.TargetIsLandFacility() && !weapon.TargetIsLandFacility())
			{
				num = 0.15f;
				float rangeAAWMax = weapon.RangeAAWMax;
				float targetAltitude = 10000f;
				float targetHeading = 270f;
				double targetLongitude = 0.0;
				double targetLatitude = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(aircraft.GetLongitude(null), aircraft.GetLatitude(null), ref targetLongitude, ref targetLatitude, (double)rangeAAWMax, 90.0);
				val = Class232.smethod_1(scenario, WeaponDBID, activeUnit, activeUnit.GetLongitude(null), activeUnit.GetLatitude(null), activeUnit.GetCurrentAltitude_ASL(false), (int)Math.Round((double)aircraft.GetCurrentSpeed()), targetLongitude, targetLatitude, targetHeading, true, 660, true, targetAltitude, true, activeUnit.GetCurrentHeading(), ActiveUnit.Throttle.Cruise, null, null).Value;
			}
			int val2 = 0;
			if (weapon.TargetIsLandFacility() || weapon.TargetIsLandFacility())
			{
				num = 0.2f;
				float rangeASUWMax = weapon.RangeASUWMax;
				float targetAltitude2 = 0f;
				float targetHeading2 = 0f;
				double targetLongitude2 = 0.0;
				double targetLatitude2 = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(aircraft.GetLongitude(null), aircraft.GetLatitude(null), ref targetLongitude2, ref targetLatitude2, (double)rangeASUWMax, 90.0);
				val2 = Class232.smethod_1(scenario, WeaponDBID, activeUnit, activeUnit.GetLongitude(null), activeUnit.GetLatitude(null), activeUnit.GetCurrentAltitude_ASL(false), (int)Math.Round((double)aircraft.GetCurrentSpeed()), targetLongitude2, targetLatitude2, targetHeading2, true, 0, true, targetAltitude2, true, activeUnit.GetCurrentHeading(), ActiveUnit.Throttle.Cruise, null, null).Value;
			}
			return (int)Math.Round((double)((float)Math.Max(val, val2) * (1f + num)));
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x00301988 File Offset: 0x002FFB88
		private static int? smethod_1(Scenario theScen, int WeaponID, ActiveUnit FiringUnit, double LaunchLongitude, double LaunchLatitude, float LaunchAltitude, int LaunchSpeed, double TargetLongitude, double TargetLatitude, float TargetHeading, bool TargetHeadingKnown, int TargetSpeed, bool TargetSpeedKnown, float TargetAltitude, bool TargetAltitudeKnown, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise, ArrayList XDAT = null, ArrayList YDAT = null)
		{
			int? result = null;
			bool flag = false;
			try
			{
				Weapon weapon = Weapon.GetWeapon(ref theScen, WeaponID, null);
				weapon.SetFiringParent(FiringUnit);
				if (weapon.weaponCode.SearchPattern)
				{
					weapon.weaponCode.SearchPattern = false;
				}
				Aircraft detectedUnit = new Aircraft(ref theScen, null);
				weapon.SetLongitude(null, LaunchLongitude);
				weapon.SetLatitude(null, LaunchLatitude);
				weapon.SetAltitude_ASL(false, LaunchAltitude);
				weapon.SetCurrentSpeed((float)LaunchSpeed);
				if (ThrottleSetting <= weapon.GetMaxThrottleAvailable())
				{
					weapon.SetThrottle(ThrottleSetting, null);
				}
				else
				{
					weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), null);
				}
				if (InitialHeading > 0f)
				{
					weapon.SetCurrentHeading(InitialHeading);
				}
				else
				{
					weapon.SetCurrentHeading(Math2.GetAzimuth(LaunchLatitude, LaunchLongitude, TargetLatitude, TargetLongitude));
				}
				weapon.GetFuelRecs()[0].CurrentQuantity = 2.14748365E+09f;
				Waypoint waypoint = new Waypoint();
				waypoint.SetLongitude(weapon.GetLongitude(null));
				waypoint.SetLatitude(weapon.GetLatitude(null));
				Contact contact = new Contact(detectedUnit, 0);
				contact.ActualUnit = null;
				contact.SetAltitude_ASL(false, TargetAltitude);
				contact.Altitude_Known = TargetAltitudeKnown;
				contact.SetCurrentSpeed((float)TargetSpeed);
				contact.Speed_Known = TargetSpeedKnown;
				contact.SetCurrentHeading(TargetHeading);
				contact.Heading_Known = TargetHeadingKnown;
				contact.SetLongitude(null, TargetLongitude);
				contact.SetLatitude(null, TargetLatitude);
				weapon.GetWeaponAI().SetPrimaryTarget(contact);
				bool arg_1D1_0;
				if (!weapon.method_187())
				{
					if (weapon.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
					{
						arg_1D1_0 = true;
						goto IL_1D1;
					}
				}
				arg_1D1_0 = weapon.GetWeaponNavigator().method_57((float)weapon.GetWeaponKinematics().GetSpeed(contact.GetCurrentAltitude_ASL(false), ThrottleSetting), false);
				IL_1D1:
				if (!arg_1D1_0)
				{
					result = null;
				}
				else
				{
					weapon.GetFuelConsumption(weapon.GetThrottle(), null, null, null, false, false, false, false);
					float num = 0f;
					double value = 0.0;
					double value2 = 0.0;
					Contact contact2;
					bool? hintIsOperating;
					Contact contact3;
					bool? hintIsOperating2;
					do
					{
						double longitude = contact.GetLongitude(null);
						double latitude = contact.GetLatitude(null);
						Unit unit = contact;

						contact2 =  contact;
						hintIsOperating = null;
						value = unit.GetLongitude(hintIsOperating);
						Unit unit2 = contact;
						contact3 = contact;
						hintIsOperating2 = null;
						value2 = unit2.GetLatitude(hintIsOperating2);
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref value, ref value2, (double)(contact.GetCurrentSpeed() * 1f / 3600f), (double)contact.GetCurrentHeading());
						contact3.SetLatitude(hintIsOperating2, value2);
						contact2.SetLongitude(hintIsOperating, value);
						if (Class263.smethod_14((int)Math.Round((double)num)))
						{
							weapon.GetWeaponAI().Navigate(1f);
							if (ThrottleSetting <= weapon.GetMaxThrottleAvailable())
							{
								weapon.SetThrottle(ThrottleSetting, null);
							}
							else
							{
								weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), null);
							}
						}
						weapon.GetWeaponKinematics().UpdateUnitPositions(1f, false, true);
						if (!Information.IsNothing(XDAT))
						{
							XDAT.Add(Math2.GetDistance(waypoint.GetLatitude(), waypoint.GetLongitude(), weapon.GetLatitude(null), weapon.GetLongitude(null)));
						}
						if (!Information.IsNothing(YDAT))
						{
							YDAT.Add(weapon.GetCurrentAltitude_ASL(false));
						}
						if (weapon.IsTargetAttackable(1f) && weapon.GetSlantRange(contact, 0f) < 1f)
						{
							goto IL_3EB;
						}
						num += 1f;
					}
					while (num <= 2.14748365E+09f);
					goto IL_4D7;
					IL_3EB:
					double longitude2 = contact.GetLongitude(null);
					double latitude2 = contact.GetLatitude(null);
					Unit unit3 = contact;
					contact3 = contact;
					hintIsOperating2 = null;
					value2 = unit3.GetLongitude(hintIsOperating2);
					Unit unit4 = contact;
					contact2 = contact;
					hintIsOperating = null;
					value = unit4.GetLatitude(hintIsOperating);
					GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref value2, ref value, (double)(contact.GetCurrentSpeed() * 1f / 3600f), (double)contact.GetCurrentHeading());
					contact2.SetLatitude(hintIsOperating, value);
					contact3.SetLongitude(hintIsOperating2, value2);
					weapon.SetLatitude(null, contact.GetLatitude(null));
					weapon.SetLongitude(null, contact.GetLongitude(null));
					weapon.SetAltitude_ASL(false, contact.GetCurrentAltitude_ASL(false));
					flag = true;
					IL_4D7:
					if (flag)
					{
						result = new int?((int)Math.Round((double)(num + 1f)));
					}
					else
					{
						result = new int?(2147483647);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100324566221", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
