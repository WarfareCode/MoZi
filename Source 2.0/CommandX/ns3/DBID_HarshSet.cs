using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using ns0;

namespace ns3
{
	// Token: 0x02000BB8 RID: 3000
	public sealed class DBID_HarshSet
	{
		// Token: 0x06006352 RID: 25426 RVA: 0x00310CA8 File Offset: 0x0030EEA8
		public static void smethod_0(Scenario scenario_0, ref string string_0)
		{
			DBOps.DBFileCheckResult dbfileCheckResult_ = DBOps.DBFileCheckResult.Undefined;
			DBRecord dBRecord = DBOps.GetDBRecord(scenario_0.GetDBUsed(), ref dbfileCheckResult_, true, true);
			if (Information.IsNothing(dBRecord))
			{
				throw new Exception(DBOps.smethod_7(dbfileCheckResult_));
			}
			string text = Guid.NewGuid().ToString() + Path.GetExtension(dBRecord.Filename);
			File.Copy(MyTemplate.GetApp().Info.DirectoryPath + "\\DB\\" + dBRecord.Filename, MyTemplate.GetApp().Info.DirectoryPath + "\\DB\\" + text);
			SQLiteConnection sqliteConnection_ = new SQLiteConnection(string.Concat(new string[]
			{
				"Data Source=",
				MyTemplate.GetApp().Info.DirectoryPath,
				"\\DB\\",
				text,
				";Version=3"
			}));
			SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(sqliteConnection_);
			DBID_HarshSet.smethod_1(scenario_0);
			DBID_HarshSet.smethod_3(sQLiteDataBase);
			sQLiteDataBase.ExecuteNonQuery("VACUUM");
			string dBUsed = DBCryptoService.Encrypt(MyTemplate.GetApp().Info.DirectoryPath + "\\DB\\" + text);
			scenario_0.SetDBUsed(dBUsed);
			string_0 = MyTemplate.GetApp().Info.DirectoryPath + "\\DB\\" + text;
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00310DF0 File Offset: 0x0030EFF0
		private static void smethod_1(Scenario scenario_0)
		{
			DBID_HarshSet.hashSet_Aircraft.Clear();
			DBID_HarshSet.hashSet_Facility.Clear();
			DBID_HarshSet.hashSet_Ship.Clear();
			DBID_HarshSet.hashSet_Submarine.Clear();
			DBID_HarshSet.hashSet_Satellite.Clear();
			DBID_HarshSet.hashSet_Sensor.Clear();
			DBID_HarshSet.hashSet_Weapon.Clear();
			DBID_HarshSet.hashSet_Mount.Clear();
			DBID_HarshSet.hashSet_Magazine.Clear();
			DBID_HarshSet.hashSet_Loadout.Clear();
			DBID_HarshSet.hashSet_commDevice_.Clear();
			DBID_HarshSet.hashSet_Engine.Clear();
			DBID_HarshSet.hashSet_Warhead.Clear();
			DBID_HarshSet.hashSet_AirFacility.Clear();
			DBID_HarshSet.hashSet_DockFacility.Clear();
			DBID_HarshSet.hashSet_FuelRec.Clear();
			DBID_HarshSet.hashSet_WeaponRec.Clear();
			using (List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DBID_HarshSet.smethod_2(enumerator.Current, scenario_0);
				}
			}
			foreach (UnguidedWeapon current in scenario_0.GetUnguidedWeapons().Values)
			{
				DBID_HarshSet.hashSet_Weapon.Add(current.GetWeapon().DBID);
			}
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x00310F40 File Offset: 0x0030F140
		private static void smethod_2(ActiveUnit activeUnit_0, Scenario scenario_0)
		{
			switch (activeUnit_0.GetUnitType())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				DBID_HarshSet.hashSet_Aircraft.Add(activeUnit_0.DBID);
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				DBID_HarshSet.hashSet_Ship.Add(activeUnit_0.DBID);
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				DBID_HarshSet.hashSet_Submarine.Add(activeUnit_0.DBID);
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				DBID_HarshSet.hashSet_Facility.Add(activeUnit_0.DBID);
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				DBID_HarshSet.hashSet_Weapon.Add(activeUnit_0.DBID);
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				DBID_HarshSet.hashSet_Satellite.Add(activeUnit_0.DBID);
				break;
			}
			Sensor[] allNoneMCMSensors = activeUnit_0.GetAllNoneMCMSensors();
			checked
			{
				for (int i = 0; i < allNoneMCMSensors.Length; i++)
				{
					Sensor sensor = allNoneMCMSensors[i];
					if (!sensor.IsEyeball())
					{
						DBID_HarshSet.hashSet_Sensor.Add(sensor.DBID);
					}
				}
				Mount[] mounts = activeUnit_0.m_Mounts;
				for (int j = 0; j < mounts.Length; j++)
				{
					Mount mount = mounts[j];
					DBID_HarshSet.hashSet_Mount.Add(mount.DBID);
					if (!Information.IsNothing(mount.GetMagazineForMount()))
					{
						DBID_HarshSet.hashSet_Magazine.Add(mount.GetMagazineForMount().DBID);
					}
					Sensor[] sensors = mount.GetSensors();
					for (int k = 0; k < sensors.Length; k++)
					{
						Sensor sensor2 = sensors[k];
						DBID_HarshSet.hashSet_Sensor.Add(sensor2.DBID);
					}
					CommDevice[] commDevices = mount.m_CommDevices;
					for (int l = 0; l < commDevices.Length; l++)
					{
						CommDevice commDevice = commDevices[l];
						DBID_HarshSet.hashSet_commDevice_.Add(commDevice.DBID);
					}
					foreach (WeaponRec current in mount.GetWeaponRecCollection())
					{
						if (current.RecID.HasValue)
						{
							DBID_HarshSet.hashSet_WeaponRec.Add(current.RecID.Value);
						}
						DBID_HarshSet.smethod_2(current.GetWeapon(scenario_0), scenario_0);
					}
				}
				if (!Information.IsNothing(activeUnit_0.GetMagazines()))
				{
					Magazine[] magazines = activeUnit_0.GetMagazines();
					for (int m = 0; m < magazines.Length; m++)
					{
						Magazine magazine = magazines[m];
						DBID_HarshSet.hashSet_Magazine.Add(magazine.DBID);
					}
				}
				if (activeUnit_0.IsAircraft)
				{
					List<Loadout> list = DBFunctions.LoadAircraftLoadoutsData(activeUnit_0.DBID, scenario_0);
					foreach (Loadout current2 in list)
					{
						DBID_HarshSet.hashSet_Loadout.Add(current2.DBID);
						WeaponRec[] weaponRecArray = current2.WeaponRecArray;
						for (int n = 0; n < weaponRecArray.Length; n++)
						{
							WeaponRec weaponRec = weaponRecArray[n];
							if (weaponRec.RecID.HasValue)
							{
								DBID_HarshSet.hashSet_WeaponRec.Add(weaponRec.RecID.Value);
							}
							DBID_HarshSet.smethod_2(weaponRec.GetWeapon(scenario_0), scenario_0);
						}
						Sensor[] poddedSensors = current2.GetPoddedSensors(scenario_0);
						for (int num = 0; num < poddedSensors.Length; num++)
						{
							Sensor sensor3 = poddedSensors[num];
							DBID_HarshSet.hashSet_Sensor.Add(sensor3.DBID);
						}
					}
				}
				if (activeUnit_0.IsWeapon)
				{
					Warhead[] warheads = ((Weapon)activeUnit_0).m_Warheads;
					for (int num2 = 0; num2 < warheads.Length; num2++)
					{
						Warhead warhead = warheads[num2];
						DBID_HarshSet.hashSet_Warhead.Add(warhead.DBID);
					}
				}
				foreach (WeaponRec current3 in activeUnit_0.GetWeaponry().method_1(true).Values)
				{
					if (current3.RecID.HasValue)
					{
						DBID_HarshSet.hashSet_WeaponRec.Add(current3.RecID.Value);
					}
					DBID_HarshSet.smethod_2(current3.GetWeapon(scenario_0), scenario_0);
				}
				CommDevice[] commDevices2 = activeUnit_0.GetCommDevices();
				for (int num3 = 0; num3 < commDevices2.Length; num3++)
				{
					CommDevice commDevice2 = commDevices2[num3];
					DBID_HarshSet.hashSet_commDevice_.Add(commDevice2.DBID);
				}
				foreach (Engine current4 in activeUnit_0.GetEngines())
				{
					DBID_HarshSet.hashSet_Engine.Add(current4.DBID);
				}
				AirFacility[] airFacilities = activeUnit_0.GetAirFacilities();
				for (int num4 = 0; num4 < airFacilities.Length; num4++)
				{
					AirFacility airFacility = airFacilities[num4];
					DBID_HarshSet.hashSet_AirFacility.Add(airFacility.DBID);
				}
				DockFacility[] dockFacilities = activeUnit_0.GetDockFacilities();
				for (int num5 = 0; num5 < dockFacilities.Length; num5++)
				{
					DockFacility dockFacility = dockFacilities[num5];
					DBID_HarshSet.hashSet_DockFacility.Add(dockFacility.DBID);
				}
				FuelRec[] fuelRecs = activeUnit_0.GetFuelRecs();
				for (int num6 = 0; num6 < fuelRecs.Length; num6++)
				{
					FuelRec fuelRec = fuelRecs[num6];
					if (fuelRec.DBID.HasValue)
					{
						DBID_HarshSet.hashSet_FuelRec.Add(fuelRec.DBID.Value);
					}
				}
			}
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x003114B0 File Offset: 0x0030F6B0
		public static void smethod_3(SQLiteDataBase db)
		{
			string string_ = "DELETE FROM DataAircraft WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftCodes WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftFacility WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_AirFacility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftFuel WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftLoadouts WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftMounts WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftPropulsion WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftSensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataAircraftSignatures WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Aircraft) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataComm WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_commDevice_) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataCommCapabilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_commDevice_) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataCommDirectors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_commDevice_) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataDockingFacility WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_DockFacility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacility WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilityAircraftFacilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilityComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilityDockingFacilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilityFuel WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilityMagazines WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilityMounts WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilitySensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFacilitySignatures WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Facility) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataFuel WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_FuelRec) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataLoadout WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Loadout) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataLoadoutWeapons WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Loadout) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMagazine WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Magazine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMagazineWeapons WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Magazine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMount WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Mount) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMountComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Mount) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMountDirectors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Mount) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMountMagazineWeapons WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Mount) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMountSensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Mount) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataMountWeapons WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Mount) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataPropulsion WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Engine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataPropulsionPerformance WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Engine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatellite WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatelliteCodes WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatelliteComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatelliteMounts WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatelliteOrbits WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatelliteSensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSatelliteSignatures WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Satellite) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSensor WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Sensor) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSensorCapabilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Sensor) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSensorCodes WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Sensor) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSensorFrequencyIlluminate WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Sensor) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSensorFrequencySearchAndTrack WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Sensor) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSensorSensorGroups WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Sensor) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShip WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipAircraftFacilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipCodes WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipDockingFacilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipFuel WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipMagazines WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipMounts WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipPropulsion WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipSensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataShipSignatures WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Ship) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarine WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineCodes WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineDockingFacilities WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineFuel WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineMagazines WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineMounts WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarinePropulsion WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineSensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataSubmarineSignatures WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Submarine) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWarhead WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Warhead) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeapon WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponCodes WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponComms WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponDirectors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponFuel WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponPropulsion WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponRecord WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_WeaponRec) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponSensors WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponSignatures WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponTargets WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponWarheads WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponWeapons WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
			string_ = "DELETE FROM DataWeaponWRA WHERE NOT ID IN (" + string.Join<int>(",", DBID_HarshSet.hashSet_Weapon) + ")";
			db.ExecuteNonQuery(string_);
		}

		// Token: 0x040035F6 RID: 13814
		private static HashSet<int> hashSet_Aircraft = new HashSet<int>();

		// Token: 0x040035F7 RID: 13815
		private static HashSet<int> hashSet_Facility = new HashSet<int>();

		// Token: 0x040035F8 RID: 13816
		private static HashSet<int> hashSet_Ship = new HashSet<int>();

		// Token: 0x040035F9 RID: 13817
		private static HashSet<int> hashSet_Submarine = new HashSet<int>();

		// Token: 0x040035FA RID: 13818
		private static HashSet<int> hashSet_Satellite = new HashSet<int>();

		// Token: 0x040035FB RID: 13819
		private static HashSet<int> hashSet_Sensor = new HashSet<int>();

		// Token: 0x040035FC RID: 13820
		private static HashSet<int> hashSet_Weapon = new HashSet<int>();

		// Token: 0x040035FD RID: 13821
		private static HashSet<int> hashSet_Mount = new HashSet<int>();

		// Token: 0x040035FE RID: 13822
		private static HashSet<int> hashSet_Magazine = new HashSet<int>();

		// Token: 0x040035FF RID: 13823
		private static HashSet<int> hashSet_Loadout = new HashSet<int>();

		// Token: 0x04003600 RID: 13824
		private static HashSet<int> hashSet_commDevice_ = new HashSet<int>();

		// Token: 0x04003601 RID: 13825
		private static HashSet<int> hashSet_Engine = new HashSet<int>();

		// Token: 0x04003602 RID: 13826
		private static HashSet<int> hashSet_Warhead = new HashSet<int>();

		// Token: 0x04003603 RID: 13827
		private static HashSet<int> hashSet_AirFacility = new HashSet<int>();

		// Token: 0x04003604 RID: 13828
		private static HashSet<int> hashSet_DockFacility = new HashSet<int>();

		// Token: 0x04003605 RID: 13829
		private static HashSet<int> hashSet_FuelRec = new HashSet<int>();

		// Token: 0x04003606 RID: 13830
		private static HashSet<int> hashSet_WeaponRec = new HashSet<int>();
	}
}
