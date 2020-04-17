using System;
using System.Collections.Generic;
using System.Linq;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;

namespace ns3
{
	// Token: 0x02000BC5 RID: 3013
	public sealed class ScenarioArrayUtil
	{
		// Token: 0x060063D0 RID: 25552 RVA: 0x0002BAFB File Offset: 0x00029CFB
		public static void AddActiveUnit(ref ActiveUnit[] activeUnit_0, ActiveUnit activeUnit_1)
		{
			activeUnit_0 = (ActiveUnit[])Utils.CopyArray(activeUnit_0, new ActiveUnit[activeUnit_0.Length + 1]);
			activeUnit_0[activeUnit_0.Length - 1] = activeUnit_1;
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00315D24 File Offset: 0x00313F24
		public static void RemoveActiveUnit(ref ActiveUnit[] activeUnit_0, ActiveUnit activeUnit_1)
		{
			List<ActiveUnit> list = activeUnit_0.ToList<ActiveUnit>();
			list.Remove(activeUnit_1);
			activeUnit_0 = list.ToArray();
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x0002BB20 File Offset: 0x00029D20
		public static void AddAircraft(ref Aircraft[] aircraft_0, Aircraft aircraft_1)
		{
			aircraft_0 = (Aircraft[])Utils.CopyArray(aircraft_0, new Aircraft[aircraft_0.Length + 1]);
			aircraft_0[aircraft_0.Length - 1] = aircraft_1;
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x00315D4C File Offset: 0x00313F4C
		public static void RemoveAircraft(ref Aircraft[] aircraft_0, Aircraft aircraft_1)
		{
			List<Aircraft> list = aircraft_0.ToList<Aircraft>();
			list.Remove(aircraft_1);
			aircraft_0 = list.ToArray();
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x0002BB45 File Offset: 0x00029D45
		public static void AddAirFacility(ref AirFacility[] airFacility_0, AirFacility airFacility_1)
		{
			airFacility_0 = (AirFacility[])Utils.CopyArray(airFacility_0, new AirFacility[airFacility_0.Length + 1]);
			airFacility_0[airFacility_0.Length - 1] = airFacility_1;
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x0002BB6A File Offset: 0x00029D6A
		public static void NewAirFacilityArray(ref AirFacility[] airFacility_0)
		{
			airFacility_0 = new AirFacility[0];
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x0002BB74 File Offset: 0x00029D74
		public static void AddCargo(ref Cargo[] cargo_0, Cargo cargo_1)
		{
			cargo_0 = (Cargo[])Utils.CopyArray(cargo_0, new Cargo[cargo_0.Length + 1]);
			cargo_0[cargo_0.Length - 1] = cargo_1;
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00315D74 File Offset: 0x00313F74
		public static void RemoveCargo(ref Cargo[] cargo_0, Cargo cargo_1)
		{
			List<Cargo> list = cargo_0.ToList<Cargo>();
			list.Remove(cargo_1);
			cargo_0 = list.ToArray();
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x0002BB99 File Offset: 0x00029D99
		public static void NewCargoArray(ref Cargo[] cargo_0)
		{
			cargo_0 = new Cargo[0];
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x0002BBA3 File Offset: 0x00029DA3
		public static void AddCommDevice(ref CommDevice[] commDevice_0, CommDevice commDevice_1)
		{
			commDevice_0 = (CommDevice[])Utils.CopyArray(commDevice_0, new CommDevice[commDevice_0.Length + 1]);
			commDevice_0[commDevice_0.Length - 1] = commDevice_1;
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00315D9C File Offset: 0x00313F9C
		public static void RemoveCommDevice(ref CommDevice[] commDevice_0, CommDevice commDevice_1)
		{
			List<CommDevice> list = commDevice_0.ToList<CommDevice>();
			list.Remove(commDevice_1);
			commDevice_0 = list.ToArray();
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x0002BBC8 File Offset: 0x00029DC8
		public static void AddActiveUnit_CommLink(ref ActiveUnit_CommLink[] class139_0, ActiveUnit_CommLink class139_1)
		{
			class139_0 = (ActiveUnit_CommLink[])Utils.CopyArray(class139_0, new ActiveUnit_CommLink[class139_0.Length + 1]);
			class139_0[class139_0.Length - 1] = class139_1;
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00315DC4 File Offset: 0x00313FC4
		public static void RemoveActiveUnit_CommLink(ref ActiveUnit_CommLink[] class139_0, ActiveUnit_CommLink class139_1)
		{
			List<ActiveUnit_CommLink> list = class139_0.ToList<ActiveUnit_CommLink>();
			list.Remove(class139_1);
			class139_0 = list.ToArray();
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0002BBED File Offset: 0x00029DED
		public static void AddContact(ref Contact[] contact_0, Contact contact_1)
		{
			contact_0 = (Contact[])Utils.CopyArray(contact_0, new Contact[contact_0.Length + 1]);
			contact_0[contact_0.Length - 1] = contact_1;
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x00315DEC File Offset: 0x00313FEC
		public static void RemoveContact(ref Contact[] contact_0, Contact contact_1)
		{
			List<Contact> list = contact_0.ToList<Contact>();
			list.Remove(contact_1);
			contact_0 = list.ToArray();
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x0002BC12 File Offset: 0x00029E12
		public static void NewContactArray(ref Contact[] contact_0)
		{
			contact_0 = new Contact[0];
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00315E14 File Offset: 0x00314014
		public static bool IsContactExists(ref Contact[] contact_0, Contact contact_1)
		{
			int num = contact_0.Length - 1;
			bool result;
			for (int i = 0; i <= num; i++)
			{
				if (contact_0[i] == contact_1)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x0002BC1C File Offset: 0x00029E1C
		public static void AddDockFacility(ref DockFacility[] dockFacility_0, DockFacility dockFacility_1)
		{
			dockFacility_0 = (DockFacility[])Utils.CopyArray(dockFacility_0, new DockFacility[dockFacility_0.Length + 1]);
			dockFacility_0[dockFacility_0.Length - 1] = dockFacility_1;
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x0002BC41 File Offset: 0x00029E41
		public static void NewDockFacilityArray(ref DockFacility[] dockFacility_0)
		{
			dockFacility_0 = new DockFacility[0];
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x0002BC4B File Offset: 0x00029E4B
		public static void AddFuelRec(ref FuelRec[] fuelRec_0, FuelRec fuelRec_1)
		{
			fuelRec_0 = (FuelRec[])Utils.CopyArray(fuelRec_0, new FuelRec[fuelRec_0.Length + 1]);
			fuelRec_0[fuelRec_0.Length - 1] = fuelRec_1;
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x0002BC70 File Offset: 0x00029E70
		public static void AddMagazine(ref Magazine[] magazine_0, Magazine magazine_1)
		{
			magazine_0 = (Magazine[])Utils.CopyArray(magazine_0, new Magazine[magazine_0.Length + 1]);
			magazine_0[magazine_0.Length - 1] = magazine_1;
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00315E4C File Offset: 0x0031404C
		public static void RemoveMagazine(ref Magazine[] magazine_0, Magazine magazine_1)
		{
			List<Magazine> list = magazine_0.ToList<Magazine>();
			list.Remove(magazine_1);
			magazine_0 = list.ToArray();
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x0002BC95 File Offset: 0x00029E95
		public static void NewMagazineArray(ref Magazine[] magazine_0)
		{
			magazine_0 = new Magazine[0];
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x0002BC9F File Offset: 0x00029E9F
		public static void AddMount(ref Mount[] mount_0, Mount mount_1)
		{
			mount_0 = (Mount[])Utils.CopyArray(mount_0, new Mount[mount_0.Length + 1]);
			mount_0[mount_0.Length - 1] = mount_1;
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00315E74 File Offset: 0x00314074
		public static void RemoveMount(ref Mount[] mount_0, Mount mount_1)
		{
			List<Mount> list = mount_0.ToList<Mount>();
			list.Remove(mount_1);
			mount_0 = list.ToArray();
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		public static void NewMountArray(ref Mount[] mount_0)
		{
			mount_0 = new Mount[0];
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x0002BCCE File Offset: 0x00029ECE
		public static void AddSensor(ref Sensor[] sensor_0, Sensor sensor_1)
		{
			sensor_0 = (Sensor[])Utils.CopyArray(sensor_0, new Sensor[sensor_0.Length + 1]);
			sensor_0[sensor_0.Length - 1] = sensor_1;
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x00315E9C File Offset: 0x0031409C
		public static void RemoveSensor(ref Sensor[] sensor_0, Sensor sensor_1)
		{
			List<Sensor> list = sensor_0.ToList<Sensor>();
			list.Remove(sensor_1);
			sensor_0 = list.ToArray();
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x0002BCF3 File Offset: 0x00029EF3
		public static void NewSensorArray(ref Sensor[] sensor_0)
		{
			sensor_0 = new Sensor[0];
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x00315EC4 File Offset: 0x003140C4
		public static Sensor[] smethod_29(ref Sensor[] sensor_0, ref Sensor[] sensor_1)
		{
			Sensor[] array = new Sensor[sensor_0.Length + sensor_1.Length - 1 + 1];
			sensor_0.CopyTo(array, 0);
			sensor_1.CopyTo(array, sensor_0.Length);
			return array;
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x0002BCFD File Offset: 0x00029EFD
		public static void AddShooter(ref WeaponSalvo.Shooter[] Shooters, WeaponSalvo.Shooter Shooter_)
		{
			Shooters = (WeaponSalvo.Shooter[])Utils.CopyArray(Shooters, new WeaponSalvo.Shooter[Shooters.Length + 1]);
			Shooters[Shooters.Length - 1] = Shooter_;
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x00315EFC File Offset: 0x003140FC
		public static void RemoveShooter(ref WeaponSalvo.Shooter[] Shooters, WeaponSalvo.Shooter Shooter_)
		{
			List<WeaponSalvo.Shooter> list = Shooters.ToList<WeaponSalvo.Shooter>();
			list.Remove(Shooter_);
			Shooters = list.ToArray();
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x0002BD22 File Offset: 0x00029F22
		public static void AddSide(ref Side[] side_0, Side side_1)
		{
			side_0 = (Side[])Utils.CopyArray(side_0, new Side[side_0.Length + 1]);
			side_0[side_0.Length - 1] = side_1;
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x00315F24 File Offset: 0x00314124
		public static void RemoveSide(ref Side[] side_0, Side side_1)
		{
			List<Side> list = side_0.ToList<Side>();
			list.Remove(side_1);
			side_0 = list.ToArray();
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x0002BD47 File Offset: 0x00029F47
		public static void AddStringToArray(ref string[] string_0, string string_1)
		{
			string_0 = (string[])Utils.CopyArray(string_0, new string[string_0.Length + 1]);
			string_0[string_0.Length - 1] = string_1;
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x00315F4C File Offset: 0x0031414C
		public static void RemoveStringFromArray(ref string[] string_0, string string_1)
		{
			List<string> list = string_0.ToList<string>();
			list.Remove(string_1);
			string_0 = list.ToArray();
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0002BD6C File Offset: 0x00029F6C
		public static void AddWarhead(ref Warhead[] warhead_0, Warhead warhead_1)
		{
			warhead_0 = (Warhead[])Utils.CopyArray(warhead_0, new Warhead[warhead_0.Length + 1]);
			warhead_0[warhead_0.Length - 1] = warhead_1;
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00315F74 File Offset: 0x00314174
		public static void RemoveWarhead(ref Warhead[] warhead_0, Warhead warhead_1)
		{
			List<Warhead> list = warhead_0.ToList<Warhead>();
			list.Remove(warhead_1);
			warhead_0 = list.ToArray();
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x0002BD91 File Offset: 0x00029F91
		public static void AddWaypoint(ref Waypoint[] waypoint_0, Waypoint waypoint_1)
		{
			waypoint_0 = (Waypoint[])Utils.CopyArray(waypoint_0, new Waypoint[waypoint_0.Length + 1]);
			waypoint_0[waypoint_0.Length - 1] = waypoint_1;
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x00315F9C File Offset: 0x0031419C
		public static void RemoveWaypoint(ref Waypoint[] waypoint_0, Waypoint waypoint_1)
		{
			List<Waypoint> list = waypoint_0.ToList<Waypoint>();
			list.Remove(waypoint_1);
			waypoint_0 = list.ToArray();
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0002BDB6 File Offset: 0x00029FB6
		public static void ClearWaypoints(ref Waypoint[] waypointArray)
		{
			waypointArray = new Waypoint[0];
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x00315FC4 File Offset: 0x003141C4
		public static void InsertWayPoint(ref Waypoint[] waypointArray, int index, Waypoint waypoint_)
		{
			List<Waypoint> list = waypointArray.ToList<Waypoint>();
			list.Insert(index, waypoint_);
			waypointArray = list.ToArray();
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		public static void AddWeapon(ref Weapon[] weapon_0, Weapon weapon_1)
		{
			weapon_0 = (Weapon[])Utils.CopyArray(weapon_0, new Weapon[weapon_0.Length + 1]);
			weapon_0[weapon_0.Length - 1] = weapon_1;
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0002BDE5 File Offset: 0x00029FE5
		public static void NewWeapon(ref Weapon[] weapon_0)
		{
			weapon_0 = new Weapon[0];
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0002BDEF File Offset: 0x00029FEF
		public static void AddWeaponSalvo(ref WeaponSalvo[] WeaponSalvos, WeaponSalvo WeaponSalvo_)
		{
			WeaponSalvos = (WeaponSalvo[])Utils.CopyArray(WeaponSalvos, new WeaponSalvo[WeaponSalvos.Length + 1]);
			WeaponSalvos[WeaponSalvos.Length - 1] = WeaponSalvo_;
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x00315FEC File Offset: 0x003141EC
		public static void RemoveWeaponSalvo(ref WeaponSalvo[] WeaponSalvos, WeaponSalvo WeaponSalvo_)
		{
			List<WeaponSalvo> list = WeaponSalvos.ToList<WeaponSalvo>();
			list.Remove(WeaponSalvo_);
			WeaponSalvos = list.ToArray();
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x0002BE14 File Offset: 0x0002A014
		public static void AddWeaponRec(ref WeaponRec[] weaponRec_0, WeaponRec weaponRec_1)
		{
			weaponRec_0 = (WeaponRec[])Utils.CopyArray(weaponRec_0, new WeaponRec[weaponRec_0.Length + 1]);
			weaponRec_0[weaponRec_0.Length - 1] = weaponRec_1;
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00316014 File Offset: 0x00314214
		public static void RemoveWeaponRec(ref WeaponRec[] weaponRec_0, WeaponRec weaponRec_1)
		{
			List<WeaponRec> list = weaponRec_0.ToList<WeaponRec>();
			list.Remove(weaponRec_1);
			weaponRec_0 = list.ToArray();
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x0002BE39 File Offset: 0x0002A039
		public static void AddWRA_WeaponTarget(ref Doctrine.WRA_WeaponTarget[] class121_0, Doctrine.WRA_WeaponTarget class121_1)
		{
			class121_0 = (Doctrine.WRA_WeaponTarget[])Utils.CopyArray(class121_0, new Doctrine.WRA_WeaponTarget[class121_0.Length + 1]);
			class121_0[class121_0.Length - 1] = class121_1;
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x0031603C File Offset: 0x0031423C
		public static void RemoveWRA_WeaponTarget(ref Doctrine.WRA_WeaponTarget[] class121_0, Doctrine.WRA_WeaponTarget class121_1)
		{
			List<Doctrine.WRA_WeaponTarget> list = class121_0.ToList<Doctrine.WRA_WeaponTarget>();
			list.Remove(class121_1);
			class121_0 = list.ToArray();
		}
	}
}
