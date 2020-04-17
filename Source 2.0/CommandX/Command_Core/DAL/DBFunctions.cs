using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;
using ns4;

// 数据获取层，Data Access Level？
namespace Command_Core.DAL
{
	// Token: 0x02000BB1 RID: 2993
	public sealed class DBFunctions
	{
		// Token: 0x060062B4 RID: 25268 RVA: 0x00302644 File Offset: 0x00300844
		public static void LoadPlatformDataTables(ref DataTable AircraftDataTable, ref DataTable ShipDataTable, ref DataTable SubmarineDataTable, ref DataTable FacilityDataTable, ref DataTable SatelliteDataTable, ref DataTable WeaponsDataTable, ref SQLiteConnection sqliteConnection_0)
		{
			AircraftDataTable = DBFunctions.GetAircraftDataTable(sqliteConnection_0);
			ShipDataTable = DBFunctions.GetShipDataTable(sqliteConnection_0);
			SubmarineDataTable = DBFunctions.GetSubmarineDataTable(sqliteConnection_0);
			FacilityDataTable = DBFunctions.GetFacilityDataTable(sqliteConnection_0);
			WeaponsDataTable = DBFunctions.GetWeaponsDataTable(sqliteConnection_0);
			try
			{
				SatelliteDataTable = DBFunctions.GetSatelliteDataTable(sqliteConnection_0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200066", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x003026E0 File Offset: 0x003008E0
		public static DataTable GetAircraftDataTable(SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string text = "Select DataAircraft.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical from DataAircraft, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataAircraft.OperatorCountry and EOS.ID = DataAircraft.OperatorService and Type > 1001 ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_100(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = CachedDataBase.GetDataTable(db, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x00302760 File Offset: 0x00300960
		public static DataTable GetShipDataTable(SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string text = "SELECT DataShip.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Length, PhysicalSizeCode from DataShip, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataShip.OperatorCountry and EOS.ID = DataShip.OperatorService and Type > 1001 ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_100(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = CachedDataBase.GetDataTable(db, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x003027E0 File Offset: 0x003009E0
		public static DataTable GetSubmarineDataTable(SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string text = "SELECT DataSubmarine.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Length, PhysicalSizeCode from DataSubmarine, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataSubmarine.OperatorCountry and EOS.ID = DataSubmarine.OperatorService and Type > 1001 ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_100(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = CachedDataBase.GetDataTable(db, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x00302860 File Offset: 0x00300A60
		public static DataTable GetFacilityDataTable(SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string text = "SELECT DataFacility.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName , OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical from DataFacility, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataFacility.OperatorCountry and EOS.ID = DataFacility.OperatorService ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_100(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = CachedDataBase.GetDataTable(db, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x003028E0 File Offset: 0x00300AE0
		public static DataTable GetSatelliteDataTable(SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string text = "SELECT DataSatellite.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, EnumSatelliteType.Description as TypeString, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical from DataSatellite, EnumSatelliteType, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EnumSatelliteType.ID = DataSatellite.Type and EOC.ID = DataSatellite.OperatorCountry and EOS.ID = DataSatellite.OperatorService ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_100(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = CachedDataBase.GetDataTable(db, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x00302960 File Offset: 0x00300B60
		public static DataTable GetWeaponsDataTable(SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string text = "SELECT ID, Name, Name ||  CASE WHEN Comments = '-' THEN '' ELSE ' -- ' || Comments END as LongName, Type, Hypothetical from DataWeapon where Type > 1001";
			if (!DBFunctions.smethod_100(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = CachedDataBase.GetDataTable(db, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x003029E0 File Offset: 0x00300BE0
		public static DataTable GetSatelliteOrbitsDataTable(int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "Select * from DataSatelliteOrbits where ID=" + Conversions.ToString(int_0);
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x00302A10 File Offset: 0x00300C10
		public static DataTable GetOperatorCountryDataTable(ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID, Description from EnumOperatorCountry ORDER BY CASE WHEN ID >= 2000 THEN Description END ASC, CASE WHEN ID < 2000 THEN ID END ASC ";
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x00302A34 File Offset: 0x00300C34
		public static int smethod_9(List<int> list_0, GlobalVariables.ActiveUnitType activeUnitType_0, SQLiteConnection sqliteConnection_0)
		{
			string text = "";
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraft";
				goto IL_61;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShip";
				goto IL_61;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarine";
				goto IL_61;
			case GlobalVariables.ActiveUnitType.Facility:
				text = "DataFacility";
				goto IL_61;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeapon";
				goto IL_61;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			IL_61:
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = string.Concat(new string[]
			{
				"SELECT COUNT(DISTINCT Name) FROM ",
				text,
				" where ID in (",
				string.Join<int>(",", list_0.ToArray()),
				")"
			});
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x00302AF8 File Offset: 0x00300CF8
		public static List<int> smethod_10(List<int> list_0, GlobalVariables.ActiveUnitType activeUnitType_, Scenario scenario_, SQLiteConnection sqliteConnection_0)
		{
			DBFunctions.UnitTypeChecker unitTypeChecker = new DBFunctions.UnitTypeChecker(null);
			unitTypeChecker.activeUnitType = activeUnitType_;
			List<int> result;
			try
			{
				List<int> list = new List<int>();
				if (list_0.Count == 0)
				{
					result = list;
				}
				else
				{
					list_0 = list_0.OrderBy(DBFunctions.intFunc0).ToList<int>();
					SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
					string string_ = "EmitterIDs_" + unitTypeChecker.activeUnitType.ToString() + "_" + string.Join<int>("_", list_0);
					object objectValue = RuntimeHelpers.GetObjectValue(CachedDataBase.smethod_2(db, string_));
					if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
					{
						List<int> list2 = scenario_.GetActiveUnitList().Where(new Func<ActiveUnit, bool>(unitTypeChecker.IsPlatformOfSameTypeWithMe)).Select(DBFunctions.ActiveUnitFunc1).Select(DBFunctions.intFunc2).ToList<int>();
						if (list2.Count == 0)
						{
							result = list;
						}
						else
						{
							new List<int>();
							DataTable dataTable = null;
							int count = list_0.Count;
							switch (unitTypeChecker.activeUnitType)
							{
							case GlobalVariables.ActiveUnitType.Aircraft:
								dataTable = DBFunctions.GetAircraftDataTable(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Ship:
								dataTable = DBFunctions.GetShipDataTable(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Submarine:
								dataTable = DBFunctions.GetSubmarineDataTable(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Facility:
								dataTable = DBFunctions.GetFacilityDataTable(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Weapon:
								dataTable = DBFunctions.GetWeaponsDataTable(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Satellite:
								dataTable = DBFunctions.GetSatelliteDataTable(sqliteConnection_0);
								break;
							}
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									int num = Conversions.ToInteger(((DataRow)enumerator.Current)["ID"]);
									if (list2.Contains(num))
									{
										List<int> second = DBFunctions.smethod_11(unitTypeChecker.activeUnitType, num, sqliteConnection_0);
										if (list_0.Intersect(second).Count<int>() == count)
										{
											list.Add(num);
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
							CachedDataBase.smethod_3(db, string_, list);
							result = list;
						}
					}
					else
					{
						result = (List<int>)objectValue;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101082", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<int>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x00302D80 File Offset: 0x00300F80
		public static List<int> smethod_11(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			string text = "";
			string text2 = "";
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraftSensors";
				text2 = "DataAircraftMounts";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShipSensors";
				text2 = "DataShipMounts";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarineSensors";
				text2 = "DataSubmarineMounts";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				text = "DataFacilitySensors";
				text2 = "DataFacilityMounts";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeaponSensors";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				text = "DataSatelliteSensors";
				text2 = "DataSatelliteMounts";
				break;
			}
			string string_ = "Select DataSensor.ID as SensorID, DataSensor.Type as SensorType, DataSensor.MasqueradeAs from DataSensor, " + text + " as theTable where DataSensor.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			DataTable dataTable2;
			if (!string.IsNullOrEmpty(text2))
			{
				string_ = string.Concat(new string[]
				{
					"SELECT DataSensor.ID as SensorID, DataSensor.Type as SensorType, DataSensor.MasqueradeAs from DataSensor, DataMountSensors, ",
					text2,
					" where DataSensor.ID = DataMountSensors.ComponentID and DataMountSensors.ID = ",
					text2,
					".ComponentID and ",
					text2,
					".ID = ",
					Conversions.ToString(int_0)
				});
				dataTable2 = CachedDataBase.GetDataTable(db, string_);
				if (dataTable2.Rows.Count > 0)
				{
					dataTable.Merge(dataTable2);
				}
			}
			string_ = string.Concat(new string[]
			{
				"SELECT DataSensor.ID as SensorID, DataSensor.Type as SensorType, DataSensor.MasqueradeAs from DataSensor, DataSensorSensorGroups, ",
				text,
				" where ",
				text,
				".ID = ",
				Conversions.ToString(int_0),
				" And DataSensorSensorGroups.ID = ",
				text,
				".ComponentID And DataSensor.ID = DataSensorSensorGroups.ComponentID"
			});
			dataTable2 = CachedDataBase.GetDataTable(db, string_);
			if (dataTable2.Rows.Count > 0)
			{
				dataTable.Merge(dataTable2);
			}
			HashSet<int> hashSet = new HashSet<int>();
			List<int> list;
			List<int> result;
			if (dataTable.Rows.Count == 0)
			{
				list = hashSet.ToList<int>();
			}
			else
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							if (Misc.HasActiveMode((Sensor.SensorType)Conversions.ToShort(dataRow["SensorType"])))
							{
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["MasqueradeAs"])) && Conversions.ToInteger(dataRow["MasqueradeAs"]) != 1001)
								{
									hashSet.Add(Conversions.ToInteger(dataRow["MasqueradeAs"]));
								}
								else
								{
									hashSet.Add(Conversions.ToInteger(dataRow["SensorID"]));
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
					ex2.Data.Add("Error at 200067", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					list = hashSet.ToList<int>();
					ProjectData.ClearProjectError();
					result = list;
					return result;
				}
				list = hashSet.ToList<int>();
			}
			result = list;
			return result;
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x003030A8 File Offset: 0x003012A8
		public static int smethod_12(string string_0, GlobalVariables.ActiveUnitType activeUnitType_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "";
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				string_ = "SELECT ID FROM DataAircraft where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				string_ = "SELECT ID FROM DataShip where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				string_ = "SELECT ID FROM DataSubmarine where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				string_ = "SELECT ID FROM DataFacility where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				string_ = "SELECT ID FROM DataWeapon where Name = '" + string_0 + "'";
				break;
			}
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00303154 File Offset: 0x00301354
		public static List<float> smethod_13(int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			List<float> list = new List<float>();
			List<float> list2;
			List<float> result;
			try
			{
				string string_ = "Select NumberOfEngines, ThrustPerEngineMilitary, ThrustPerEngineAfterburner, SFCMilitary, SFCAfterburner from DataPropulsion where ID=" + Conversions.ToString(int_0);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				if (dataTable.Rows.Count == 0)
				{
					list2 = list;
					result = list2;
					return result;
				}
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						list.Add(Conversions.ToSingle(dataRow["NumberOfEngines"]));
						list.Add(Conversions.ToSingle(dataRow["ThrustPerEngineMilitary"]));
						list.Add(Conversions.ToSingle(dataRow["ThrustPerEngineAfterburner"]));
						list.Add(Conversions.ToSingle(dataRow["SFCMilitary"]));
						list.Add(Conversions.ToSingle(dataRow["SFCAfterburner"]));
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
				ex2.Data.Add("Error at 200068", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			list2 = list;
			result = list2;
			return result;
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x003032D0 File Offset: 0x003014D0
		public static List<float> GetTorpedoData(int DBID_, SQLiteConnection sqliteConnection_)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_);
			List<float> list = new List<float>();
			List<float> list2;
			List<float> result;
			try
			{
				string string_ = "Select TorpedoSpeedCruise, TorpedoRangeCruise, TorpedoSpeedFull, TorpedoRangeFull from DataWeapon where ID=" + Conversions.ToString(DBID_);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				if (dataTable.Rows.Count == 0)
				{
					list2 = list;
					result = list2;
					return result;
				}
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						list.Add(Conversions.ToSingle(dataRow["TorpedoSpeedCruise"]));
						list.Add(Conversions.ToSingle(dataRow["TorpedoRangeCruise"]));
						list.Add(Conversions.ToSingle(dataRow["TorpedoSpeedFull"]));
						list.Add(Conversions.ToSingle(dataRow["TorpedoRangeFull"]));
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
				ex2.Data.Add("Error at 200069", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			list2 = list;
			result = list2;
			return result;
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x0030342C File Offset: 0x0030162C
		public static void smethod_15(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, SQLiteConnection sqliteConnection_0, ref int int_1, ref int int_2, ref int int_3)
		{
			if (activeUnitType_0 != GlobalVariables.ActiveUnitType.Weapon)
			{
				string str = "";
				SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
				switch (activeUnitType_0)
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					str = "DataAircraft";
					break;
				case GlobalVariables.ActiveUnitType.Ship:
					str = "DataShip";
					break;
				case GlobalVariables.ActiveUnitType.Submarine:
					str = "DataSubmarine";
					break;
				case GlobalVariables.ActiveUnitType.Facility:
					str = "DataFacility";
					break;
				case GlobalVariables.ActiveUnitType.Satellite:
					str = "DataSatellite";
					break;
				}
				try
				{
					string string_ = "SELECT OODADetectionCycle, OODATargetingCycle, OODAEvasiveCycle FROM " + str + " where ID = " + Conversions.ToString(int_0);
					DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							int_1 = Conversions.ToInteger(dataRow["OODADetectionCycle"]);
							int_2 = Conversions.ToInteger(dataRow["OODATargetingCycle"]);
							int_3 = Conversions.ToInteger(dataRow["OODAEvasiveCycle"]);
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
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string string_ = "SELECT  OODATargetingCycle, OODAEvasiveCycle FROM " + str + " where ID = " + Conversions.ToString(int_0);
					DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							int_1 = 15;
							int_2 = Conversions.ToInteger(dataRow2["OODATargetingCycle"]);
							int_3 = Conversions.ToInteger(dataRow2["OODAEvasiveCycle"]);
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x00303610 File Offset: 0x00301810
		public static List<string> smethod_16(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			string text = "";
			string text2 = "";
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			List<string> list = new List<string>();
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraftCodes";
				text2 = "EnumAircraftCode";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShipCodes";
				text2 = "EnumShipCode";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarineCodes";
				text2 = "EnumSubmarineCode";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeaponCodes";
				text2 = "EnumWeaponCode";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				text = "DataSatelliteCodes";
				text2 = "EnumSatelliteCode";
				break;
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT EC.* from ",
				text2,
				" as EC, ",
				text,
				" as DC where EC.ID = DC.CodeID and DC.ID = ",
				Conversions.ToString(int_0)
			});
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			List<string> result;
			if (dataTable.Rows.Count == 0)
			{
				result = list;
			}
			else
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						list.Add(Conversions.ToString(dataRow["Description"]));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x00303780 File Offset: 0x00301980
		public static string smethod_17(CommDevice.CommLinkType commLinkType_0, Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "Select Description from EnumCommType where ID=" + Conversions.ToString((int)commLinkType_0);
			return CachedDataBase.ExecuteScalar(db, string_);
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x003037B4 File Offset: 0x003019B4
		public static string smethod_18(XSection._SignatureType enum93_0, Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "Select Description from EnumSignatureType where ID=" + Conversions.ToString((int)enum93_0);
			return CachedDataBase.ExecuteScalar(db, string_);
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x003037E8 File Offset: 0x003019E8
		public static void smethod_19(ref Scenario theScen, ref Aircraft theAircraft, int AircraftDBID, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select * from DataAircraft where ID = " + Conversions.ToString(AircraftDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception("No aircraft with ID: " + Conversions.ToString(AircraftDBID) + " was found in the current database!");
			}
			DataRow dataRow = dataTable.Rows[0];
			if (!dataTable.Columns.Contains("OODADetectionCycle"))
			{
				dataTable.Columns.Add("OODADetectionCycle", typeof(string));
				dataRow["OODADetectionCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODATargetingCycle"))
			{
				dataTable.Columns.Add("OODATargetingCycle", typeof(string));
				dataRow["OODATargetingCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
			{
				dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
				dataRow["OODAEvasiveCycle"] = 0;
			}
			theAircraft.Category = (Aircraft._AircraftCategory)Conversions.ToShort(dataRow["Category"]);
			theAircraft.Type = (Aircraft._AircraftType)Conversions.ToInteger(dataRow["Type"]);
			theAircraft.DBID = AircraftDBID;
			theAircraft.UnitClass = Strings.Trim(Conversions.ToString(dataRow["Name"]));
			theAircraft.GetAircraftKinematics().SetClimbRate(Conversions.ToSingle(dataRow["ClimbRate"].ToString()));
			theAircraft.Agility = Conversions.ToSingle(dataRow["Agility"].ToString());
			theAircraft.Length = Conversions.ToSingle(dataRow["Length"].ToString());
			theAircraft.WeightEmpty = Conversions.ToInteger(dataRow["WeightEmpty"].ToString());
			theAircraft.WeightMax = Conversions.ToInteger(dataRow["WeightMax"].ToString());
			theAircraft.WeightPayload = Conversions.ToInteger(dataRow["WeightPayload"].ToString());
			theAircraft.Span = Conversions.ToSingle(dataRow["Span"].ToString());
			theAircraft.Height = Conversions.ToSingle(dataRow["Height"].ToString());
			theAircraft.Crew = Conversions.ToInteger(dataRow["Crew"].ToString());
			theAircraft.TotalEndurance = Conversions.ToInteger(dataRow["TotalEndurance"].ToString());
			theAircraft.Category = (Aircraft._AircraftCategory)Conversions.ToShort(dataRow["Category"]);
			theAircraft.RunwayLengthCode = (GlobalVariables._RunwayLengthCode)Conversions.ToInteger(dataRow["RunwayLengthCode"]);
			int num = Conversions.ToInteger(dataRow["PhysicalSizeCode"]);
			if (num != 1001)
			{
				switch (num)
				{
				case 2001:
					theAircraft.aircraftSizeClass = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 2002:
					theAircraft.aircraftSizeClass = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 2003:
					theAircraft.aircraftSizeClass = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 2004:
					theAircraft.aircraftSizeClass = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					break;
				}
			}
			else
			{
				theAircraft.aircraftSizeClass = GlobalVariables.AircraftSizeClass.None;
			}
			if (dataTable.Columns.Contains("DamagePoints") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DamagePoints"])) && Conversions.ToInteger(dataRow["DamagePoints"]) != 0)
			{
				theAircraft.SetInitialDP(Conversions.ToInteger(dataRow["DamagePoints"]));
				theAircraft.SetDamagePts(true, (float)theAircraft.GetInitialDP());
			}
			else if (theAircraft.IsAirship())
			{
				theAircraft.SetInitialDP(Aircraft.GetInitialDP((int)Math.Round((double)theAircraft.Length)));
				theAircraft.SetDamagePts(true, (float)theAircraft.GetInitialDP());
			}
			else
			{
				switch (theAircraft.aircraftSizeClass)
				{
				case GlobalVariables.AircraftSizeClass.Small:
					theAircraft.SetInitialDP(3);
					break;
				case GlobalVariables.AircraftSizeClass.Medium:
					theAircraft.SetInitialDP(5);
					break;
				case GlobalVariables.AircraftSizeClass.Large:
					theAircraft.SetInitialDP(10);
					break;
				case GlobalVariables.AircraftSizeClass.VLarge:
					theAircraft.SetInitialDP(20);
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					break;
				}
				theAircraft.SetDamagePts(true, (float)theAircraft.GetInitialDP());
			}
			if (dataTable.Columns.Contains("Visibility"))
			{
				theScen.FeatureCompatibility.CockpitVisibility = true;
				try
				{
					string[] array;
					if (dataRow["Visibility"].ToString().Contains(","))
					{
						array = dataRow["Visibility"].ToString().Split(Conversions.ToCharArrayRankOne(","));
					}
					else
					{
						array = dataRow["Visibility"].ToString().Split(Conversions.ToCharArrayRankOne("."));
					}
					string left = array[0];
					if (Operators.CompareString(left, "A", false) != 0)
					{
						if (Operators.CompareString(left, "B", false) != 0)
						{
							if (Operators.CompareString(left, "C", false) == 0)
							{
								theAircraft.ForwardCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Poor;
							}
						}
						else
						{
							theAircraft.ForwardCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Average;
						}
					}
					else
					{
						theAircraft.ForwardCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
					}
					string left2 = array[1];
					if (Operators.CompareString(left2, "A", false) != 0)
					{
						if (Operators.CompareString(left2, "B", false) != 0)
						{
							if (Operators.CompareString(left2, "C", false) == 0)
							{
								theAircraft.SidewaysCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Poor;
							}
						}
						else
						{
							theAircraft.SidewaysCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Average;
						}
					}
					else
					{
						theAircraft.SidewaysCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
					}
					string left3 = array[2];
					if (Operators.CompareString(left3, "A", false) != 0)
					{
						if (Operators.CompareString(left3, "B", false) != 0)
						{
							if (Operators.CompareString(left3, "C", false) == 0)
							{
								theAircraft.AftCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Poor;
							}
						}
						else
						{
							theAircraft.AftCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Average;
						}
					}
					else
					{
						theAircraft.AftCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			if (dataTable.Columns.Contains("FuelOffloadRate") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["FuelOffloadRate"])))
			{
				theAircraft.FuelOffloadRate = Conversions.ToSingle(dataRow["FuelOffloadRate"]);
			}
			if (dataTable.Columns.Contains("AircraftEngineArmor") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AircraftEngineArmor"])))
			{
				theAircraft.AircraftEngineArmor = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["AircraftEngineArmor"]);
			}
			else
			{
				theAircraft.AircraftEngineArmor = GlobalVariables.ArmorRating.None;
			}
			if (dataTable.Columns.Contains("AircraftCockpitArmor") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AircraftCockpitArmor"])))
			{
				theAircraft.AircraftCockpitArmor = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["AircraftCockpitArmor"]);
			}
			else
			{
				theAircraft.AircraftCockpitArmor = GlobalVariables.ArmorRating.None;
			}
			if (dataTable.Columns.Contains("AircraftFuselageArmor") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AircraftFuselageArmor"])))
			{
				theAircraft.AircraftFuselageArmor = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["AircraftFuselageArmor"]);
			}
			else
			{
				theAircraft.AircraftFuselageArmor = GlobalVariables.ArmorRating.None;
			}
			theAircraft.OODADetectionCycle = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
			theAircraft.OODATargetingCycle = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
			theAircraft.OODAEvasiveCycle = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
			theAircraft.OperatorCountry = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
			try
			{
				theAircraft.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			Aircraft aircraft = theAircraft;
			DBFunctions.smethod_36(ref aircraft, AircraftDBID);
			if (LoadComponents)
			{
				DBFunctions.LoadPlatformSensorsData(theAircraft, AircraftDBID);
				DBFunctions.LoadPlatformCommStuffData(theAircraft, AircraftDBID);
				ActiveUnit activeUnit = theAircraft;
				DBFunctions.LoadPlatformMountsData(ref theScen, ref activeUnit, AircraftDBID);
				DBFunctions.LoadPlatformPropulsionData(theAircraft, AircraftDBID);
				DBFunctions.LoadPlatformFuelsData(theAircraft, AircraftDBID);
			}
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x00304038 File Offset: 0x00302238
		public static int GetAircraftType(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataAircraft where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_));
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x00304070 File Offset: 0x00302270
		public static string GetAircraftTypeDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumAircraftType where ID = (Select Type from DataAircraft Where ID = " + Conversions.ToString(int_0) + ")";
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x003040A8 File Offset: 0x003022A8
		public static int GetShipType(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataShip where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_));
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x003040E0 File Offset: 0x003022E0
		public static string GetShipTypeDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumShipType where ID = (Select Type from DataShip Where ID = " + Conversions.ToString(int_0) + ")";
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x00304118 File Offset: 0x00302318
		public static int GetSubmarineType(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataSubmarine where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_));
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x00304150 File Offset: 0x00302350
		public static string GeSubmarineTypeDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumSubmarineType where ID = (Select Type from DataSubmarine Where ID = " + Conversions.ToString(int_0) + ")";
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x00304188 File Offset: 0x00302388
		public static int GetFacilityCategory(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Category from DataFacility where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_));
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x003041C0 File Offset: 0x003023C0
		public static int GetSatelliteType(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataSatellite where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_));
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x003041F8 File Offset: 0x003023F8
		public static string GetSatelliteTypeDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumSatelliteType where ID = (Select Type from DataSatellite Where ID = " + Conversions.ToString(int_0) + ")";
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x00304230 File Offset: 0x00302430
		public static int GetWeaponType(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataWeapon where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_));
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x00304268 File Offset: 0x00302468
		public static string GetWeaponTypeDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponType where ID = (Select Type from DataWeapon Where ID = " + Conversions.ToString(int_0) + ")";
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x003042A0 File Offset: 0x003024A0
		public static string GetWeaponWRAWeaponQtyDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponWRAWeaponQty where ID = " + Conversions.ToString(int_0);
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x003042D4 File Offset: 0x003024D4
		public static string GetWeaponWRAShooterQtyDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponWRAShooterQty where ID = " + Conversions.ToString(int_0);
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x00304308 File Offset: 0x00302508
		public static string GetWeaponWRASelfDefenceRangeDescription(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponWRASelfDefenceRange where ID = " + Conversions.ToString(int_0);
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x0030433C File Offset: 0x0030253C
		public static string GetSensorGenerationDesciption(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumSensorGeneration where ID = " + Conversions.ToString(int_0);
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(scenario_0.GetSQLiteConnection()), string_);
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x00304370 File Offset: 0x00302570
		public static string GetFacilityTypeDescription(ref Scenario scenario_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string text = CachedDataBase.smethod_4(db, "FacilityType_" + Conversions.ToString(int_0));
			string result;
			if (!string.IsNullOrEmpty(text))
			{
				result = text;
			}
			else
			{
				string string_ = "Select Name, Category from Datafacility where ID = " + Conversions.ToString(int_0);
				DataRow dataRow = CachedDataBase.GetDataTable(db, string_).Rows[0];
				Facility._FacilityCategory facilityCategory = (Facility._FacilityCategory)Conversions.ToShort(dataRow["Category"]);
				string text2;
				if (facilityCategory - Facility._FacilityCategory.Mobile_Vehicle <= 1)
				{
					text2 = Conversions.ToString((int)Facility.smethod_4(dataRow["Name"].ToString()));
				}
				else
				{
					text2 = facilityCategory.ToString();
				}
				CachedDataBase.smethod_5(db, "FacilityType_" + Conversions.ToString(int_0), text2);
				result = text2;
			}
			return result;
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x0030444C File Offset: 0x0030264C
		public static void smethod_36(ref Aircraft aircraft_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(aircraft_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select * from DataAircraftCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				DataRow dataRow = dataTable.Rows[i];
				int num2 = Conversions.ToInteger(dataRow["CodeID"]);
				if (num2 <= 8001)
				{
					if (num2 <= 6011)
					{
						if (num2 <= 5002)
						{
							if (num2 != 4001)
							{
								if (num2 != 5002)
								{
									goto IL_2BE;
								}
								aircraft_0.HIFRCapable = true;
							}
							else
							{
								aircraft_0.Supermanouverability = true;
							}
						}
						else
						{
							switch (num2)
							{
							case 6001:
								aircraft_0.SetIsTerrainAvoidance(true);
								break;
							case 6002:
								aircraft_0.SetIsTerrainFollowing(true);
								break;
							case 6003:
								aircraft_0.FlyByWire = true;
								break;
							case 6004:
								aircraft_0.BlipEnhance = true;
								break;
							default:
								if (num2 != 6011)
								{
									goto IL_2BE;
								}
								aircraft_0.NightNavigation = true;
								break;
							}
						}
					}
					else if (num2 <= 7004)
					{
						if (num2 != 6012)
						{
							switch (num2)
							{
							case 7001:
								aircraft_0.Bombsight = Aircraft._Bombsight.BasicTech;
								break;
							case 7002:
								aircraft_0.Bombsight = Aircraft._Bombsight.BallisticTech;
								break;
							case 7003:
								aircraft_0.Bombsight = Aircraft._Bombsight.ComputingTech;
								break;
							case 7004:
								aircraft_0.Bombsight = Aircraft._Bombsight.AdvancedTech;
								break;
							default:
								goto IL_2BE;
							}
						}
						else
						{
							aircraft_0.NightNavigationAndAttack = true;
						}
					}
					else if (num2 != 7010)
					{
						if (num2 != 8001)
						{
							goto IL_2BE;
						}
						aircraft_0.ProbeRefuelling = true;
					}
					else
					{
						aircraft_0.HMD = true;
					}
				}
				else
				{
					if (num2 <= 9114)
					{
						if (num2 <= 9003)
						{
							if (num2 == 8002)
							{
								aircraft_0.BoomRefuelling = true;
								goto IL_2E7;
							}
							switch (num2)
							{
							case 9001:
								aircraft_0.CenterlineDrogue = true;
								goto IL_2E7;
							case 9002:
								aircraft_0.WingDrogue = true;
								goto IL_2E7;
							case 9003:
								aircraft_0.CenterlineBoom = true;
								goto IL_2E7;
							default:
								goto IL_2BE;
							}
						}
						else if (num2 - 9101 > 3 && num2 - 9111 > 3)
						{
							goto IL_2BE;
						}
					}
					else if (num2 <= 9186)
					{
						if (num2 - 9121 > 3 && num2 - 9185 > 1)
						{
							goto IL_2BE;
						}
					}
					else if (num2 - 9191 > 1 && num2 != 9199)
					{
						goto IL_2BE;
					}
					aircraft_0.AircraftCode = (Aircraft._AircraftCode)Conversions.ToInteger(dataRow["CodeID"]);
				}
				IL_2E7:
				i++;
				continue;
				IL_2BE:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_2E7;
				}
				goto IL_2E7;
			}
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x00304754 File Offset: 0x00302954
		public static string smethod_37(int int_0, int int_1, ref SQLiteConnection sqliteConnection_0, Scenario scenario_0, bool bool_0, Loadout.LoadoutRole loadoutRole_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string result;
			if (bool_0)
			{
				string string_ = "Select EnumLoadoutWinchesterShotgun.Description from EnumLoadoutWinchesterShotgun where EnumLoadoutWinchesterShotgun.ID = " + Conversions.ToString(int_1);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				if (dataTable.Rows.Count > 0)
				{
					result = dataTable.Rows[0]["Description"].ToString();
				}
				else
				{
					result = "Winchester: Mission-specific weapons have been expended. Disengage immediately.";
				}
			}
			else
			{
				result = Aircraft.GetWinchesterString(int_0, int_1, loadoutRole_0, scenario_0);
			}
			return result;
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x003047D8 File Offset: 0x003029D8
		public static LoadoutMissionProfile LoadDefaultMissionProfile(int int_0, ref SQLiteConnection sqliteConnection_0, Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT DefaultMissionProfile from DataLoadout where ID=" + Conversions.ToString(int_0);
			return DBFunctions.LoadLoadoutMissionProfile(Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_)), ref sqliteConnection_0, scenario_0);
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x00304814 File Offset: 0x00302A14
		public static LoadoutMissionProfile LoadLoadoutMissionProfile(int int_0, ref SQLiteConnection sqliteConnection_0, Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			DataTable dataTable;
			try
			{
				string string_;
				if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.GetSQLiteConnection()))
				{
					string_ = "Select Description, FormUpTime, FormUpAltitude, CruiseAltitudeIngress, CruiseAltitudeIngressTerrainFollowing, CruiseAltitudeEgress, CruiseAltitudeEgressTerrainFollowing, CruiseThrottleSettingIngress, CruiseThrottleSettingEgress, CruiseOneWayOnly, CruiseAtOptimumAltitude, AttackAltitudeIngress, AttackAltitudeIngressTerrainFollowing, AttackAltitudeEgress, AttackAltitudeEgressTerrainFollowing, AttackThrottleSetting, AttackDistanceIngress, AttackDistanceEgress, DropBombsAtMaxRange, StationAltitude, StationAltitudeTerrainFollowing, StationThrottleSetting, ReservePercentage, ReserveLoiterTime, ReserveLoiterAltitude from EnumLoadoutMissionProfile where ID = " + Conversions.ToString(int_0);
				}
				else
				{
					string_ = "Select Description, FormUpTime, FormUpAltitude, CruiseAltitudeIngress, CruiseAltitudeEgress, CruiseThrottleSettingIngress, CruiseThrottleSettingEgress, CruiseOneWayOnly, CruiseAtOptimumAltitude, AttackAltitudeIngress, AttackAltitudeEgress, AttackThrottleSetting, AttackDistanceIngress, AttackDistanceEgress, DropBombsAtMaxRange, StationAltitude, StationThrottleSetting, ReservePercentage, ReserveLoiterTime, ReserveLoiterAltitude from EnumLoadoutMissionProfile where ID = " + Conversions.ToString(int_0);
				}
				dataTable = CachedDataBase.GetDataTable(db, string_);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string string_ = "Select Description, FormUpTime, FormUpAltitude, CruiseAltitudeIngress, CruiseAltitudeEgress, CruiseThrottleSettingIngress, CruiseThrottleSettingEgress, CruiseOneWayOnly, CruiseAtOptimumAltitude, AttackAltitudeIngress, AttackAltitudeEgress, AttackThrottleSetting, AttackDistanceIngress, AttackDistanceEgress, DropBombsAtMaxRange, StationAltitude, StationThrottleSetting, ReservePercentage from EnumLoadoutMissionProfile where ID = " + Conversions.ToString(int_0);
				dataTable = CachedDataBase.GetDataTable(db, string_);
				ProjectData.ClearProjectError();
			}
			LoadoutMissionProfile loadoutMissionProfile = new LoadoutMissionProfile();
			LoadoutMissionProfile result;
			if (dataTable.Rows.Count == 0)
			{
				result = null;
			}
			else
			{
				DataRow dataRow = dataTable.Rows[0];
				loadoutMissionProfile.DBID = (short)int_0;
				loadoutMissionProfile.strDescription = Conversions.ToString(dataRow["Description"]);
				loadoutMissionProfile.FormUpTime = Conversions.ToInteger(dataRow["FormUpTime"]);
				loadoutMissionProfile.FormUpAltitude = (float)Conversions.ToInteger(dataRow["FormUpAltitude"]) / 3.28084f;
				loadoutMissionProfile.CruiseAltitudeIngress = (float)Conversions.ToInteger(dataRow["CruiseAltitudeIngress"]) / 3.28084f;
				loadoutMissionProfile.CruiseAltitudeEgress = (float)Conversions.ToInteger(dataRow["CruiseAltitudeEgress"]) / 3.28084f;
				loadoutMissionProfile.CruiseThrottleSettingIngress = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["CruiseThrottleSettingIngress"]);
				loadoutMissionProfile.CruiseThrottleSettingEgress = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["CruiseThrottleSettingEgress"]);
				loadoutMissionProfile.CruiseOneWayOnly = Conversions.ToBoolean(dataRow["CruiseOneWayOnly"]);
				loadoutMissionProfile.CruiseAtOptimumAltitude = Conversions.ToBoolean(dataRow["CruiseAtOptimumAltitude"]);
				loadoutMissionProfile.AttackAltitudeIngress = (float)Conversions.ToInteger(dataRow["AttackAltitudeIngress"]) / 3.28084f;
				loadoutMissionProfile.AttackAltitudeEgress = (float)Conversions.ToInteger(dataRow["AttackAltitudeEgress"]) / 3.28084f;
				loadoutMissionProfile.AttackThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["AttackThrottleSetting"]);
				loadoutMissionProfile.AttackDistanceIngress = Conversions.ToInteger(dataRow["AttackDistanceIngress"]);
				loadoutMissionProfile.AttackDistanceEgress = Conversions.ToInteger(dataRow["AttackDistanceEgress"]);
				loadoutMissionProfile.DropBombsAtMaxRange = Conversions.ToBoolean(dataRow["DropBombsAtMaxRange"]);
				loadoutMissionProfile.StationAltitude = (float)Conversions.ToInteger(dataRow["StationAltitude"]) / 3.28084f;
				loadoutMissionProfile.StationThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["StationThrottleSetting"]);
				loadoutMissionProfile.ReservePercentage = Conversions.ToInteger(dataRow["ReservePercentage"]);
				if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.GetSQLiteConnection()))
				{
					loadoutMissionProfile.CruiseAltitudeIngressTerrainFollowing = Conversions.ToBoolean(dataRow["CruiseAltitudeIngressTerrainFollowing"]);
					loadoutMissionProfile.CruiseAltitudeEgressTerrainFollowing = Conversions.ToBoolean(dataRow["CruiseAltitudeEgressTerrainFollowing"]);
					loadoutMissionProfile.AttackAltitudeIngressTerrainFollowing = Conversions.ToBoolean(dataRow["AttackAltitudeIngressTerrainFollowing"]);
					loadoutMissionProfile.AttackAltitudeEgressTerrainFollowing = Conversions.ToBoolean(dataRow["AttackAltitudeEgressTerrainFollowing"]);
					loadoutMissionProfile.StationAltitudeTerrainFollowing = Conversions.ToBoolean(dataRow["StationAltitudeTerrainFollowing"]);
				}
				else
				{
					loadoutMissionProfile.CruiseAltitudeIngressTerrainFollowing = false;
					loadoutMissionProfile.CruiseAltitudeEgressTerrainFollowing = false;
					loadoutMissionProfile.AttackAltitudeIngressTerrainFollowing = false;
					loadoutMissionProfile.AttackAltitudeEgressTerrainFollowing = false;
					loadoutMissionProfile.StationAltitudeTerrainFollowing = false;
				}
				if (dataTable.Columns.Contains("ReserveLoiterTime"))
				{
					loadoutMissionProfile.ReserveLoiterTime = Conversions.ToInteger(dataRow["ReserveLoiterTime"]);
				}
				if (dataTable.Columns.Contains("ReserveLoiterAltitude"))
				{
					loadoutMissionProfile.ReserveLoiterAltitude = (float)Conversions.ToInteger(dataRow["ReserveLoiterAltitude"]) / 3.28084f;
				}
				result = loadoutMissionProfile;
			}
			return result;
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x00304BE0 File Offset: 0x00302DE0
		public static Dictionary<int, int> smethod_40(List<Aircraft> SelectedAircraft, ref SQLiteConnection theDBConn, ref bool UnlimitedAirWeapons)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (!UnlimitedAirWeapons && !Information.IsNothing(SelectedAircraft))
			{
				foreach (Aircraft current in SelectedAircraft)
				{
					if (!Information.IsNothing(current.GetLoadout()))
					{
						DataTable dataTable = new DataTable();
						dataTable = DBFunctions.LoadLoadoutWeaponsData(current.GetLoadout().DBID, ref theDBConn, ref current.GetLoadout().NOW);
						int num = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							DataRow dataRow = dataTable.Rows[i];
							int num2 = Conversions.ToInteger(dataRow["ComponentID"]);
							if (!Weapon.IsNotLaunchableFireWeapon(num2, ref current.m_Scenario))
							{
								if (dictionary.ContainsKey(num2))
								{
									Dictionary<int, int> dictionary2;
									int key;
									(dictionary2 = dictionary)[key = num2] = dictionary2[key] + Conversions.ToInteger(dataRow["Quantity"]);
								}
								else
								{
									dictionary.Add(num2, Conversions.ToInteger(dataRow["Quantity"]));
								}
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x00304D2C File Offset: 0x00302F2C
		public static List<Loadout> LoadAircraftLoadoutsData(int int_0, Scenario scenario_0)
		{
			SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			List<Loadout> list = new List<Loadout>();
			string string_ = "Select ComponentID from DataAircraftLoadouts where ID=" + Conversions.ToString(int_0);
			DataTable dataTable = sQLiteDataBase.GetDataTable(string_);
			IEnumerator enumerator = dataTable.Rows.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					Loadout item = DBFunctions.smethod_47(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), false);
					list.Add(item);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return list;
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x00304DE4 File Offset: 0x00302FE4
		public static DataTable smethod_42(int AircraftID, Dictionary<int, int> SelectedAircraftTotalWeaponQty, ref SQLiteConnection theDBConn, Scenario theScen, ref bool UnlimitedAirWeapons, ref Scenario CurrentScenario, ref Aircraft SelectedAircraft, ref int AircraftLoadoutDBID, ref bool ExcludeOptionalWeapons)
		{
			DataTable result;
			if (!Information.IsNothing(SelectedAircraft) && Information.IsNothing(SelectedAircraft.GetAircraftAirOps().GetCurrentHostUnit()))
			{
				result = null;
			}
			else
			{
				SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(theDBConn);
				DataTable dataTable;
				if (AircraftLoadoutDBID > 0)
				{
					if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.GetSQLiteConnection()))
					{
						string string_ = "SELECT ID, Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay, WinchesterShotgun from DataLoadout where DataLoadout.ID = " + Conversions.ToString(AircraftLoadoutDBID);
						dataTable = sQLiteDataBase.GetDataTable(string_);
						goto IL_1E2;
					}
					try
					{
						string string_ = "SELECT ID, Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay from DataLoadout where DataLoadout.ID = " + Conversions.ToString(AircraftLoadoutDBID);
						dataTable = sQLiteDataBase.GetDataTable(string_);
						goto IL_1E2;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string string_ = "SELECT ID, Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile from DataLoadout where DataLoadout.ID = " + Conversions.ToString(AircraftLoadoutDBID);
						dataTable = sQLiteDataBase.GetDataTable(string_);
						ProjectData.ClearProjectError();
						goto IL_1E2;
					}
				}
				if (CurrentScenario != null)
				{
					if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.GetSQLiteConnection()))
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay, WinchesterShotgun from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = sQLiteDataBase.GetDataTable(string_);
						goto IL_1E2;
					}
					try
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = sQLiteDataBase.GetDataTable(string_);
						goto IL_1E2;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = sQLiteDataBase.GetDataTable(string_);
						ProjectData.ClearProjectError();
						goto IL_1E2;
					}
				}
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.GetSQLiteConnection()))
				{
					string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, ReadyTime, ReadyTime_Sustained, LoadoutRole, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay, WinchesterShotgun from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
					dataTable = sQLiteDataBase.GetDataTable(string_);
				}
				else
				{
					try
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, ReadyTime, ReadyTime_Sustained, LoadoutRole, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = sQLiteDataBase.GetDataTable(string_);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, ReadyTime AS ReadyTime, LoadoutRole from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = sQLiteDataBase.GetDataTable(string_);
						ProjectData.ClearProjectError();
					}
				}
				IL_1E2:
				if (!dataTable.Columns.Contains("QuickTurnaround"))
				{
					dataTable.Columns.Add("QuickTurnaround", typeof(string));
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							((DataRow)enumerator.Current)["QuickTurnaround"] = 0;
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
				if (!dataTable.Columns.Contains("QuickTurnaround_ReadyTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_ReadyTime", typeof(string));
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							((DataRow)enumerator2.Current)["QuickTurnaround_ReadyTime"] = 0;
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
				if (!dataTable.Columns.Contains("QuickTurnaround_MaxSorties"))
				{
					dataTable.Columns.Add("QuickTurnaround_MaxSorties", typeof(string));
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							((DataRow)enumerator3.Current)["QuickTurnaround_MaxSorties"] = 0;
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
				if (!dataTable.Columns.Contains("QuickTurnaround_AdditionalTimePenalty"))
				{
					dataTable.Columns.Add("QuickTurnaround_AdditionalTimePenalty", typeof(string));
					IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							((DataRow)enumerator4.Current)["QuickTurnaround_AdditionalTimePenalty"] = 0;
						}
					}
					finally
					{
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AirborneTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_AirborneTime", typeof(string));
					IEnumerator enumerator5 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator5.MoveNext())
						{
							((DataRow)enumerator5.Current)["QuickTurnaround_AirborneTime"] = 0;
						}
					}
					finally
					{
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_TimeofDay"))
				{
					dataTable.Columns.Add("QuickTurnaround_TimeofDay", typeof(string));
					IEnumerator enumerator6 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator6.MoveNext())
						{
							((DataRow)enumerator6.Current)["QuickTurnaround_TimeofDay"] = 0;
						}
					}
					finally
					{
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("WinchesterShotgun"))
				{
					dataTable.Columns.Add("WinchesterShotgun", typeof(string));
					IEnumerator enumerator7 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator7.MoveNext())
						{
							((DataRow)enumerator7.Current)["WinchesterShotgun"] = 0;
						}
					}
					finally
					{
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
					}
				}
				if (CurrentScenario != null)
				{
					if (!dataTable.Columns.Contains("NumberOfLoadouts"))
					{
						dataTable.Columns.Add("NumberOfLoadouts", typeof(string));
					}
					if (!dataTable.Columns.Contains("NumberOfLoadoutsIncludingMountedWeapons"))
					{
						dataTable.Columns.Add("NumberOfLoadoutsIncludingMountedWeapons", typeof(string));
					}
					if (!dataTable.Columns.Contains("NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"))
					{
						dataTable.Columns.Add("NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly", typeof(string));
					}
					if (!dataTable.Columns.Contains("QuickTurnaroundDescription"))
					{
						dataTable.Columns.Add("QuickTurnaroundDescription", typeof(string));
					}
					if (!dataTable.Columns.Contains("WinchesterShotgunDescription"))
					{
						dataTable.Columns.Add("WinchesterShotgunDescription", typeof(string));
					}
					DataTable dataTable2 = new DataTable();
					IEnumerator enumerator8 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator8.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator8.Current;
							int num = 2147483647;
							int num2 = 2147483647;
							int num3 = 2147483647;
							dataTable2 = DBFunctions.LoadLoadoutWeaponsData(Conversions.ToInteger(dataRow["ID"]), ref theDBConn, ref ExcludeOptionalWeapons);
							int num4 = 0;
							if (!UnlimitedAirWeapons)
							{
								IEnumerator enumerator9 = dataTable2.Rows.GetEnumerator();
								try
								{
									while (enumerator9.MoveNext())
									{
										DataRow dataRow2 = (DataRow)enumerator9.Current;
										num4 = Conversions.ToInteger(dataRow2["ComponentID"]);
										int num5 = Conversions.ToInteger(dataRow2["Quantity"]);
										bool flag = Conversions.ToBoolean(dataRow2["Optional"]);
										if (!Weapon.IsNotLaunchableFireWeapon(num4, ref CurrentScenario))
										{
											int weaponLoadsInMagazines = SelectedAircraft.GetAircraftAirOps().GetCurrentHostUnit().GetWeaponry().GetWeaponLoadsInMagazines(num4);
											int num6 = 0;
											if (!Information.IsNothing(SelectedAircraftTotalWeaponQty) && SelectedAircraftTotalWeaponQty.ContainsKey(num4))
											{
												num6 = SelectedAircraftTotalWeaponQty[num4];
											}
											if (num5 > 0)
											{
												int num7 = weaponLoadsInMagazines / num5;
												if (num7 < num)
												{
													num = num7;
												}
												num7 = (weaponLoadsInMagazines + num6) / num5;
												if (num7 < num2)
												{
													num2 = num7;
												}
												if (!flag)
												{
													num7 = (weaponLoadsInMagazines + num6) / num5;
													if (num7 < num3)
													{
														num3 = num7;
													}
												}
											}
										}
									}
								}
								finally
								{
									if (enumerator9 is IDisposable)
									{
										(enumerator9 as IDisposable).Dispose();
									}
								}
							}
							if (num != 2147483647 && !UnlimitedAirWeapons)
							{
								dataRow["NumberOfLoadouts"] = num;
							}
							else
							{
								dataRow["NumberOfLoadouts"] = "Unlimited";
							}
							if (num2 != 2147483647 && !UnlimitedAirWeapons)
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapons"] = num2;
							}
							else
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapons"] = "Unlimited";
							}
							if (num3 != 2147483647 && !UnlimitedAirWeapons)
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"] = num3;
							}
							else
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"] = "Unlimited";
							}
							if (!Conversions.ToBoolean(dataRow["QuickTurnaround"]))
							{
								dataRow["QuickTurnaroundDescription"] = "-";
							}
							else
							{
								int num8 = Conversions.ToInteger(dataRow["QuickTurnaround_ReadyTime"]);
								int value = Conversions.ToInteger(dataRow["QuickTurnaround_MaxSorties"]);
								int num9 = Conversions.ToInteger(dataRow["QuickTurnaround_AirborneTime"]);
								string string_ = "Select EnumLoadoutTimeOfDay.Description from EnumLoadoutTimeOfDay, DataLoadout where EnumLoadoutTimeOfDay.ID = DataLoadout.QuickTurnaround_TimeofDay and DataLoadout.ID = " + dataRow["ID"].ToString();
								DataTable dataTable3 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
								string text;
								if (dataTable3.Rows.Count > 0)
								{
									text = dataTable3.Rows[0]["Description"].ToString();
								}
								else
								{
									text = "No time-of-day description";
								}
								dataRow["QuickTurnaroundDescription"] = string.Concat(new string[]
								{
									text,
									", ",
									Conversions.ToString(value),
									"波次@ ",
									Misc.GetTimeString((long)(num8 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
									", ",
									Misc.GetTimeString((long)(num9 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
									"飞行时间"
								});
							}
							if (Conversions.ToBoolean(dataRow["WinchesterShotgun"]) && Conversions.ToInteger(dataRow["WinchesterShotgun"]) != 0)
							{
								dataRow["WinchesterShotgunDescription"] = DBFunctions.smethod_37(num4, Conversions.ToInteger(dataRow["WinchesterShotgun"]), ref theDBConn, CurrentScenario, false, (Loadout.LoadoutRole)Conversions.ToInteger(dataRow["LoadoutRole"]));
							}
							else
							{
								dataRow["WinchesterShotgunDescription"] = "Winchester: Mission-specific weapons have been expended. Disengage immediately.";
							}
						}
					}
					finally
					{
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
					}
				}
				if (CurrentScenario != null)
				{
					IEnumerator enumerator10 = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator10.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator10.Current;
							if (!dataTable.Columns.Contains("RangeProfileDescription"))
							{
								dataTable.Columns.Add("RangeProfileDescription", typeof(string));
							}
							if (!dataTable.Columns.Contains("LoadoutRoleDescription"))
							{
								dataTable.Columns.Add("LoadoutRoleDescription", typeof(string));
							}
							if (!dataTable.Columns.Contains("Weather"))
							{
								dataTable.Columns.Add("Weather", typeof(string));
							}
							if (!dataTable.Columns.Contains("TimeofDay"))
							{
								dataTable.Columns.Add("TimeofDay", typeof(string));
							}
							if (!dataTable.Columns.Contains("ReadyTime"))
							{
								dataTable.Columns.Add("ReadyTime", typeof(string));
							}
							if (!dataTable.Columns.Contains("ReadyTime_Sustained"))
							{
								dataTable.Columns.Add("ReadyTime_Sustained", typeof(string));
							}
							string strDescription = DBFunctions.LoadDefaultMissionProfile(Conversions.ToInteger(dataRow3["ID"]), ref theDBConn, theScen).strDescription;
							int value2 = Conversions.ToInteger(dataRow3["DefaultCombatRadius"]);
							int num10 = Conversions.ToInteger(dataRow3["DefaultTimeOnStation"]);
							string str;
							if (Conversions.ToInteger(dataRow3["DefaultMissionProfile"]) == 1001)
							{
								str = "";
							}
							else if (num10 > 0)
							{
								str = Conversions.ToString(num10) + "分钟 到达" + Conversions.ToString(value2) + "海里 ";
							}
							else
							{
								str = Conversions.ToString(value2) + "海里 ";
							}
							dataRow3["RangeProfileDescription"] = str + strDescription;
							string string_ = "Select EnumLoadoutRole.Description from EnumLoadoutRole, DataLoadout where EnumLoadoutRole.ID =  DataLoadout.LoadoutRole and DataLoadout.ID = " + Conversions.ToString(Conversions.ToInteger(dataRow3["ID"]));
							DataTable dataTable4 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
							if (dataTable4.Rows.Count > 0)
							{
								string str2 = Conversions.ToString(dataTable4.Rows[0]["Description"]);
								dataRow3["LoadoutRoleDescription"] = "挂载作用: " + str2;
							}
							else
							{
								dataRow3["LoadoutRoleDescription"] = "挂载作用: 无";
							}
							string_ = "Select EnumLoadoutWeather.Description from EnumLoadoutWeather, DataLoadout where EnumLoadoutWeather.ID = DataLoadout.Weather and DataLoadout.ID = " + Conversions.ToString(Conversions.ToInteger(dataRow3["ID"]));
							DataTable dataTable5 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
							if (dataTable5.Rows.Count > 0)
							{
								string value3 = Conversions.ToString(dataTable5.Rows[0]["Description"]);
								dataRow3["Weather"] = value3;
							}
							else
							{
								dataRow3["Weather"] = "";
							}
							string_ = "Select EnumLoadoutTimeOfDay.Description from EnumLoadoutTimeOfDay, DataLoadout where EnumLoadoutTimeOfDay.ID = DataLoadout.TimeofDay and DataLoadout.ID = " + dataRow3["ID"].ToString();
							DataTable dataTable6 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
							if (dataTable6.Rows.Count > 0)
							{
								string value4 = dataTable6.Rows[0]["Description"].ToString();
								dataRow3["TimeofDay"] = value4;
							}
							else
							{
								dataRow3["TimeofDay"] = "";
							}
							try
							{
								string_ = "SELECT ReadyTime, ReadyTime_Sustained from DataLoadout where DataLoadout.ID = " + dataRow3["ID"].ToString();
								DataTable dataTable7 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
								if (dataTable7.Rows.Count > 0)
								{
									DataRow dataRow4 = dataTable7.Rows[0];
									long num11 = Conversions.ToLong(dataRow4["ReadyTime"]);
									long num12 = Conversions.ToLong(dataRow4["ReadyTime_Sustained"]);
									if (num11 > 0L)
									{
										string timeString = Misc.GetTimeString(num11 * 60L, Aircraft_AirOps._Maintenance.const_0, false, false);
										dataRow3["ReadyTime"] = timeString;
									}
									else
									{
										dataRow3["ReadyTime"] = "n/a";
									}
									if (num12 > 0L)
									{
										string timeString2 = Misc.GetTimeString(num12 * 60L, Aircraft_AirOps._Maintenance.const_0, false, false);
										dataRow3["ReadyTime_Sustained"] = timeString2;
									}
									else
									{
										dataRow3["ReadyTime_Sustained"] = "n/a";
									}
								}
								else
								{
									dataRow3["ReadyTime"] = "";
									dataRow3["ReadyTime_Sustained"] = "";
								}
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								string_ = "SELECT ReadyTime as ReadyTime from DataLoadout where DataLoadout.ID = " + dataRow3["ID"].ToString();
								DataTable dataTable7 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
								if (dataTable7.Rows.Count > 0)
								{
									long num13 = Conversions.ToLong(dataTable7.Rows[0]["ReadyTime"]);
									if (num13 > 0L)
									{
										string timeString3 = Misc.GetTimeString(num13 * 60L, Aircraft_AirOps._Maintenance.const_0, false, false);
										dataRow3["ReadyTime"] = timeString3;
									}
									else
									{
										dataRow3["ReadyTime"] = "n/a";
									}
								}
								else
								{
									dataRow3["ReadyTime"] = "";
								}
								dataRow3["ReadyTime_Sustained"] = "-";
								ProjectData.ClearProjectError();
							}
						}
					}
					finally
					{
						if (enumerator10 is IDisposable)
						{
							(enumerator10 as IDisposable).Dispose();
						}
					}
				}
				IEnumerator enumerator11 = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator11.MoveNext())
					{
						DataRow arg_101C_0 = (DataRow)enumerator11.Current;
						if (!dataTable.Columns.Contains("AttackAltitude"))
						{
							dataTable.Columns.Add("AttackAltitude", typeof(string));
							IEnumerator enumerator12 = dataTable.Rows.GetEnumerator();
							try
							{
								while (enumerator12.MoveNext())
								{
									DataRow dataRow5 = (DataRow)enumerator12.Current;
									if (!Information.IsNothing(DBFunctions.LoadDefaultMissionProfile(Conversions.ToInteger(dataRow5["ID"]), ref theDBConn, theScen)))
									{
										float num14 = DBFunctions.LoadDefaultMissionProfile(Conversions.ToInteger(dataRow5["ID"]), ref theDBConn, theScen).AttackAltitudeIngress;
										string text2 = "";
										if (num14 == 0f)
										{
											Loadout.LoadoutRole loadoutRole = (Loadout.LoadoutRole)Conversions.ToInteger(dataRow5["LoadoutRole"]);
											if (loadoutRole <= Loadout.LoadoutRole.NavalOnly_DEAD)
											{
												if (loadoutRole - Loadout.LoadoutRole.LandNaval_Strike > 4 && loadoutRole - Loadout.LoadoutRole.LandOnly_Strike > 4 && loadoutRole - Loadout.LoadoutRole.NavalOnly_Strike > 4)
												{
													goto IL_122F;
												}
											}
											else if (loadoutRole != Loadout.LoadoutRole.BAI_CAS && loadoutRole != Loadout.LoadoutRole.NavalMineLaying && loadoutRole != Loadout.LoadoutRole.ASW_Attack)
											{
												goto IL_122F;
											}
											num14 = DBFunctions.LoadDefaultMissionProfile(Conversions.ToInteger(dataRow5["ID"]), ref theDBConn, theScen).CruiseAltitudeIngress;
											if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.GetSQLiteConnection()))
											{
												if (DBFunctions.LoadDefaultMissionProfile(Conversions.ToInteger(dataRow5["ID"]), ref theDBConn, theScen).CruiseAltitudeIngressTerrainFollowing)
												{
													text2 = "(真高)(地形跟随/规避)";
												}
												else
												{
													text2 = "(海高)";
												}
											}
											if (num14 == 0f)
											{
												dataRow5["AttackAltitude"] = "-";
												continue;
											}
											if (SimConfiguration.gameOptions.UseImperialUnit())
											{
												dataRow5["AttackAltitude"] = Conversions.ToString(Math.Round((double)(num14 * 3.28084f), 0)) + " ft" + text2;
												continue;
											}
											dataRow5["AttackAltitude"] = "攻击高度: " + Conversions.ToString(num14) + "米" + text2;
											continue;
											IL_122F:
											dataRow5["AttackAltitude"] = "-";
										}
										else
										{
											if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.GetSQLiteConnection()))
											{
												if (DBFunctions.LoadDefaultMissionProfile(Conversions.ToInteger(dataRow5["ID"]), ref theDBConn, theScen).AttackAltitudeIngressTerrainFollowing)
												{
													text2 = "(真高)(地形跟随/规避)";
												}
												else
												{
													text2 = "(海高)";
												}
											}
											if (SimConfiguration.gameOptions.UseImperialUnit())
											{
												dataRow5["AttackAltitude"] = Conversions.ToString(Math.Round((double)(num14 * 3.28084f), 0)) + " ft" + text2;
											}
											else
											{
												dataRow5["AttackAltitude"] = "攻击高度: " + Conversions.ToString(num14) + "米" + text2;
											}
										}
									}
								}
							}
							finally
							{
								if (enumerator12 is IDisposable)
								{
									(enumerator12 as IDisposable).Dispose();
								}
							}
						}
					}
				}
				finally
				{
					if (enumerator11 is IDisposable)
					{
						(enumerator11 as IDisposable).Dispose();
					}
				}
				result = dataTable;
			}
			return result;
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x003062C0 File Offset: 0x003044C0
		public static Collection<int> smethod_43(int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			Collection<int> collection = new Collection<int>();
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT DISTINCT DataWeapon.ID from DataWeapon, DataLoadout, DataLoadoutWeapons, DataAircraftLoadouts, DataWeaponRecord where DataWeapon.ID = DataWeaponRecord.ComponentID and DataWeaponRecord.ID = DataLoadoutWeapons.ComponentID and DataLoadoutWeapons.ID = DataLoadout.ID and DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Name ASC";
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				collection.Add(Conversions.ToInteger(dataRow["ID"]));
			}
			return collection;
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x0030634C File Offset: 0x0030454C
		public static DataTable LoadLoadoutWeaponsData(int int_0, ref SQLiteConnection sqliteConnection_0, ref bool bool_0)
		{
			DataTable dataTable = new DataTable();
			SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT DataLoadoutWeapons.ComponentID, DataLoadoutWeapons.Optional, DataLoadoutWeapons.Internal FROM DataLoadoutWeapons, DataWeaponRecord, DataWeapon WHERE DataLoadoutWeapons.ComponentID = DataWeaponRecord.ID AND DataWeapon.ID = DataWeaponRecord.ComponentID AND DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name, DataWeaponRecord.DefaultLoad ASC";
			DataTable dataTable2;
			try
			{
				dataTable2 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_ = "SELECT DataLoadoutWeapons.ComponentID FROM DataLoadoutWeapons, DataWeaponRecord, DataWeapon WHERE DataLoadoutWeapons.ComponentID = DataWeaponRecord.ID AND DataWeapon.ID = DataWeaponRecord.ComponentID AND DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
				dataTable2 = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
				ProjectData.ClearProjectError();
			}
			dataTable.Columns.Add("ComponentID", typeof(int));
			dataTable.Columns.Add("Quantity", typeof(int));
			dataTable.Columns.Add("Item", typeof(string));
			dataTable.Columns.Add("Optional", typeof(bool));
			dataTable.Columns.Add("Internal", typeof(bool));
			int num = dataTable2.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable2.Rows[i];
				if (!dataTable2.Columns.Contains("Optional") || !Conversions.ToBoolean(dataRow["Optional"]) || !bool_0)
				{
					string_ = "Select DataWeapon.ID as ID, DataWeapon.NAME, DataWeaponRecord.DefaultLoad from DataWeapon, DataWeaponRecord where DataWeapon.ID = DataWeaponRecord.ComponentID and DataWeaponRecord.ID =" + dataRow["ComponentID"].ToString();
					SQLiteDataReader sQLiteDataReader = sQLiteDataBase.ExecuteReader(string_);
					sQLiteDataReader.Read();
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2["ComponentID"] = RuntimeHelpers.GetObjectValue(sQLiteDataReader["ID"]);
					dataRow2["Quantity"] = RuntimeHelpers.GetObjectValue(sQLiteDataReader["DefaultLoad"]);
					if (dataTable2.Columns.Contains("Optional"))
					{
						dataRow2["Optional"] = RuntimeHelpers.GetObjectValue(dataRow["Optional"]);
					}
					else
					{
						dataRow2["Optional"] = false;
					}
					if (dataTable2.Columns.Contains("Internal"))
					{
						dataRow2["Internal"] = RuntimeHelpers.GetObjectValue(dataRow["Internal"]);
					}
					else
					{
						dataRow2["Internal"] = false;
					}
					if (Conversions.ToBoolean(dataRow2["Optional"]) && Conversions.ToBoolean(dataRow2["Internal"]))
					{
						dataRow2["Item"] = sQLiteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sQLiteDataReader["Name"])) + "   (Internal, Optional)";
					}
					else if (Conversions.ToBoolean(dataRow2["Optional"]) && !Conversions.ToBoolean(dataRow2["Internal"]))
					{
						dataRow2["Item"] = sQLiteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sQLiteDataReader["Name"])) + "   (Optional)";
					}
					else if (!Conversions.ToBoolean(dataRow2["Optional"]) && Conversions.ToBoolean(dataRow2["Internal"]))
					{
						dataRow2["Item"] = sQLiteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sQLiteDataReader["Name"])) + "   (Internal)";
					}
					else
					{
						dataRow2["Item"] = sQLiteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sQLiteDataReader["Name"]));
					}
					dataTable.Rows.Add(dataRow2);
					sQLiteDataReader.Close();
				}
			}
			return dataTable;
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x0030675C File Offset: 0x0030495C
		public static Loadout smethod_45(ref Scenario scenario_0, int int_0)
		{
			Loadout loadout2;
			Loadout result;
			try
			{
				SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
				string string_ = "Select ComponentID from DataAircraftLoadouts where ID = " + Conversions.ToString(int_0);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						Loadout loadout = DBFunctions.smethod_47(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), false);
						if (loadout.loadoutRole == Loadout.LoadoutRole.Reserve)
						{
							loadout2 = loadout;
							result = loadout2;
							return result;
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
				loadout2 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101259", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				loadout2 = null;
				ProjectData.ClearProjectError();
			}
			result = loadout2;
			return result;
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x00306874 File Offset: 0x00304A74
		public static Loadout smethod_46(ref Scenario scenario_0, int int_0)
		{
			Loadout loadout2;
			Loadout result;
			try
			{
				SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
				string string_ = "Select ComponentID from DataAircraftLoadouts where ID = " + Conversions.ToString(int_0);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						Loadout loadout = DBFunctions.smethod_47(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), false);
						if (loadout.loadoutRole == Loadout.LoadoutRole.Unavailable)
						{
							loadout2 = loadout;
							result = loadout2;
							return result;
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
				loadout2 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101260", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				loadout2 = null;
				ProjectData.ClearProjectError();
			}
			result = loadout2;
			return result;
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x0030698C File Offset: 0x00304B8C
		public static Loadout smethod_47(ref Scenario scenario_0, int int_0, bool bool_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "Select * from DataLoadout where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count > 0)
			{
				DataRow dataRow = dataTable.Rows[0];
				if (!dataTable.Columns.Contains("QuickTurnaround"))
				{
					dataTable.Columns.Add("QuickTurnaround", typeof(string));
					dataRow["QuickTurnaround"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_ReadyTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_ReadyTime", typeof(string));
					dataRow["QuickTurnaround_ReadyTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_MaxSorties"))
				{
					dataTable.Columns.Add("QuickTurnaround_MaxSorties", typeof(string));
					dataRow["QuickTurnaround_MaxSorties"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AdditionalTimePenalty"))
				{
					dataTable.Columns.Add("QuickTurnaround_AdditionalTimePenalty", typeof(string));
					dataRow["QuickTurnaround_AdditionalTimePenalty"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AirborneTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_AirborneTime", typeof(string));
					dataRow["QuickTurnaround_AirborneTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_TimeofDay"))
				{
					dataTable.Columns.Add("QuickTurnaround_TimeofDay", typeof(string));
					dataRow["QuickTurnaround_TimeofDay"] = 0;
				}
				if (!dataTable.Columns.Contains("ReadyTime_Sustained"))
				{
					dataTable.Columns.Add("ReadyTime_Sustained", typeof(string));
					dataRow["ReadyTime_Sustained"] = 0;
				}
				if (!dataTable.Columns.Contains("WinchesterShotgun"))
				{
					dataTable.Columns.Add("WinchesterShotgun", typeof(string));
					dataRow["WinchesterShotgun"] = 0;
				}
				Loadout loadout = new Loadout(int_0, dataRow["Name"].ToString(), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Capacity"]), Conversions.ToInteger(dataRow["ReadyTime"]), Conversions.ToInteger(dataRow["ReadyTime_Sustained"]), (Loadout.LoadoutRole)Conversions.ToInteger(dataRow["LoadoutRole"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["TimeofDay"]), (Loadout._WeatherProfile)Conversions.ToShort(dataRow["Weather"]), Conversions.ToSingle(dataRow["PayloadWeightDragModifier"]), Conversions.ToInteger(dataRow["DefaultCombatRadius"]), Conversions.ToShort(dataRow["DefaultTimeOnStation"]), Conversions.ToBoolean(dataRow["RequiresBuddyIllumination"]), bool_0, Conversions.ToBoolean(dataRow["QuickTurnaround"]), Conversions.ToInteger(dataRow["QuickTurnaround_ReadyTime"]), Conversions.ToInteger(dataRow["QuickTurnaround_MaxSorties"]), Conversions.ToInteger(dataRow["QuickTurnaround_AdditionalTimePenalty"]), Conversions.ToInteger(dataRow["QuickTurnaround_AirborneTime"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["QuickTurnaround_TimeofDay"]), (Doctrine._WeaponState)Conversions.ToInteger(dataRow["WinchesterShotgun"]));
				try
				{
					loadout.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (dataTable.Columns.Contains("Cargo_Crew"))
				{
					try
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
						{
							loadout.Cargo_Crew = (float)Conversions.ToShort(dataRow["Cargo_Crew"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
						{
							loadout.Cargo_Area = (float)Conversions.ToShort(dataRow["Cargo_Area"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
						{
							loadout.Cargo_Type = (_CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
						{
							loadout.Cargo_Mass = (float)Conversions.ToShort(dataRow["Cargo_Mass"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_ParadropCapable"])))
						{
							loadout.Cargo_ParadropCapable = Conversions.ToBoolean(dataRow["Cargo_ParadropCapable"]);
						}
						goto IL_4BF;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						goto IL_4BF;
					}
					goto IL_4B4;
				}
				IL_4BF:
				DBFunctions.smethod_49(ref scenario_0, ref loadout, int_0, bool_0);
				return loadout;
			}
			IL_4B4:
			throw new Exception0("This loadout ID does not exist in the database.");
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x00306E84 File Offset: 0x00305084
		public static void smethod_48(ref Aircraft aircraft_0, int int_0, bool bool_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(aircraft_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select * from DataLoadout where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count > 0)
			{
				DataRow dataRow = dataTable.Rows[0];
				string text = dataRow["Name"].ToString();
				if (bool_0)
				{
					text += " - Mandatory Weapons Only";
				}
				if (!dataTable.Columns.Contains("QuickTurnaround"))
				{
					dataTable.Columns.Add("QuickTurnaround", typeof(string));
					dataRow["QuickTurnaround"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_ReadyTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_ReadyTime", typeof(string));
					dataRow["QuickTurnaround_ReadyTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_MaxSorties"))
				{
					dataTable.Columns.Add("QuickTurnaround_MaxSorties", typeof(string));
					dataRow["QuickTurnaround_MaxSorties"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AdditionalTimePenalty"))
				{
					dataTable.Columns.Add("QuickTurnaround_AdditionalTimePenalty", typeof(string));
					dataRow["QuickTurnaround_AdditionalTimePenalty"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AirborneTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_AirborneTime", typeof(string));
					dataRow["QuickTurnaround_AirborneTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_TimeofDay"))
				{
					dataTable.Columns.Add("QuickTurnaround_TimeofDay", typeof(string));
					dataRow["QuickTurnaround_TimeofDay"] = 0;
				}
				if (!dataTable.Columns.Contains("ReadyTime_Sustained"))
				{
					dataTable.Columns.Add("ReadyTime_Sustained", typeof(string));
					dataRow["ReadyTime_Sustained"] = 0;
				}
				if (!dataTable.Columns.Contains("WinchesterShotgun"))
				{
					dataTable.Columns.Add("WinchesterShotgun", typeof(string));
					dataRow["WinchesterShotgun"] = 2001;
				}
				Loadout loadout = new Loadout(int_0, text, Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Capacity"]), Conversions.ToInteger(dataRow["ReadyTime"]), Conversions.ToInteger(dataRow["ReadyTime_Sustained"]), (Loadout.LoadoutRole)Conversions.ToInteger(dataRow["LoadoutRole"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["TimeofDay"]), (Loadout._WeatherProfile)Conversions.ToShort(dataRow["Weather"]), Conversions.ToSingle(dataRow["PayloadWeightDragModifier"]), Conversions.ToInteger(dataRow["DefaultCombatRadius"]), Conversions.ToShort(dataRow["DefaultTimeOnStation"]), Conversions.ToBoolean(dataRow["RequiresBuddyIllumination"]), bool_0, Conversions.ToBoolean(dataRow["QuickTurnaround"]), Conversions.ToInteger(dataRow["QuickTurnaround_ReadyTime"]), Conversions.ToInteger(dataRow["QuickTurnaround_MaxSorties"]), Conversions.ToInteger(dataRow["QuickTurnaround_AdditionalTimePenalty"]), Conversions.ToInteger(dataRow["QuickTurnaround_AirborneTime"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["QuickTurnaround_TimeofDay"]), (Doctrine._WeaponState)Conversions.ToInteger(dataRow["WinchesterShotgun"]));
				try
				{
					loadout.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200473", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				if (dataTable.Columns.Contains("Cargo_Crew"))
				{
					try
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
						{
							loadout.Cargo_Crew = (float)Conversions.ToShort(dataRow["Cargo_Crew"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
						{
							loadout.Cargo_Area = (float)Conversions.ToShort(dataRow["Cargo_Area"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
						{
							loadout.Cargo_Type = (_CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
						{
							loadout.Cargo_Mass = (float)Conversions.ToShort(dataRow["Cargo_Mass"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_ParadropCapable"])))
						{
							loadout.Cargo_ParadropCapable = Conversions.ToBoolean(dataRow["Cargo_ParadropCapable"]);
						}
						goto IL_54C;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						goto IL_54C;
					}
					goto IL_507;
				}
				IL_54C:
				DBFunctions.smethod_49(ref aircraft_0.m_Scenario, ref loadout, int_0, bool_0);
				DBFunctions.smethod_50(ref aircraft_0.m_Scenario, ref loadout);
				aircraft_0.SetLoadout(loadout);
				return;
			}
			IL_507:
			throw new Exception0(string.Concat(new string[]
			{
				"Unable to equip aircraft: ",
				aircraft_0.Name,
				" with loadout #ID: ",
				Conversions.ToString(int_0),
				". This loadout ID does not exist in the database."
			}));
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x00307420 File Offset: 0x00305620
		public static void smethod_49(ref Scenario scenario_0, ref Loadout loadout_0, int int_0, bool bool_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "SELECT DataWeaponRecord.*, DataLoadoutWeapons.ComponentNumber, DataLoadoutWeapons.Optional, DataLoadoutWeapons.Internal from DataLoadoutWeapons, DataWeaponRecord, DataWeapon where DataWeaponRecord.ID =DataLoadoutWeapons.ComponentID And DataWeapon.ID=DataWeaponRecord.ComponentID And DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name";
			DataTable dataTable;
			try
			{
				dataTable = CachedDataBase.GetDataTable(db, string_);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_ = "SELECT DataWeaponRecord.*, DataLoadoutWeapons.ComponentNumber from DataLoadoutWeapons, DataWeaponRecord, DataWeapon where DataWeaponRecord.ID =DataLoadoutWeapons.ComponentID And DataWeapon.ID=DataWeaponRecord.ComponentID And DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name";
				dataTable = CachedDataBase.GetDataTable(db, string_);
				ProjectData.ClearProjectError();
			}
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				bool flag = dataTable.Columns.Contains("Optional") && Conversions.ToBoolean(dataRow["Optional"]);
				bool bool_ = dataTable.Columns.Contains("Internal") && Conversions.ToBoolean(dataRow["Internal"]);
				if (!flag || !bool_0)
				{
					WeaponRec weaponRec_ = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), flag, bool_);
					loadout_0.AddWeaponRec(weaponRec_);
				}
			}
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x00307594 File Offset: 0x00305794
		public static void smethod_50(ref Scenario scenario_0, ref Loadout loadout_0)
		{
			try
			{
				WeaponRec[] weaponRecArray = loadout_0.WeaponRecArray;
				int num = 0;
				int num2 = 0;
				for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
				{
					WeaponRec weaponRec = weaponRecArray[i];
					num += weaponRec.GetWeapon(scenario_0).WeightEmpty * weaponRec.GetCurrentLoad();
					if (loadout_0.GetMissionProfile(scenario_0).DropBombsAtMaxRange)
					{
						Weapon weapon = weaponRec.GetWeapon(scenario_0);
						if (weapon.TargetIsLandFacility() || weapon.TargetIsShipOrRadar() || weapon.TargetIsRadar())
						{
							num2 += weapon.WeightEmpty * weaponRec.GetCurrentLoad();
						}
					}
				}
				loadout_0.PayloadWeight = num;
				loadout_0.PayloadWeightDroppable = num2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x00307670 File Offset: 0x00305870
		public static void smethod_51(ref Scenario theScen, ref Ship theShip, int ShipDBID, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select * from DataShip where ID = " + Conversions.ToString(ShipDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int count = dataTable.Rows.Count;
			if (count == 0)
			{
				throw new Exception("No ship with ID: " + Conversions.ToString(ShipDBID) + " was found in the current database!");
			}
			int num = count - 1;
			int num2 = 0;
			while (num2 <= num)
			{
				DataRow dataRow = dataTable.Rows[num2];
				if (!dataTable.Columns.Contains("OODADetectionCycle"))
				{
					dataTable.Columns.Add("OODADetectionCycle", typeof(string));
					dataRow["OODADetectionCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODATargetingCycle"))
				{
					dataTable.Columns.Add("OODATargetingCycle", typeof(string));
					dataRow["OODATargetingCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
				{
					dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
					dataRow["OODAEvasiveCycle"] = 0;
				}
				theShip.Category = (Ship._ShipCategory)Conversions.ToInteger(dataRow["Category"].ToString());
				theShip.Type = (Ship._ShipType)Conversions.ToInteger(dataRow["Type"].ToString());
				theShip.DBID = ShipDBID;
				theShip.UnitClass = Strings.Trim(dataRow["Name"].ToString());
				theShip.Length = Conversions.ToSingle(dataRow["Length"].ToString());
				try
				{
					theShip.physicalSizeCode = (DockFacility._DockFacilityPhysicalSizeCode)Conversions.ToShort(dataRow["PhysicalSizeCode"].ToString());
					goto IL_45A;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					float length = theShip.Length;
					if (length <= 11f)
					{
						theShip.physicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.VerySmallPier;
					}
					else if (length <= 17f)
					{
						theShip.physicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.SmallPier;
					}
					else if (length <= 25f)
					{
						theShip.physicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.MediumPier;
					}
					else if (length <= 45f)
					{
						theShip.physicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.LargePier;
					}
					else if (length <= 200f)
					{
						theShip.physicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.VeryLargePier;
					}
					else
					{
						theShip.physicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.ExtraLargePier;
					}
					ex2.Data.Add("Error at 200072", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					goto IL_45A;
				}
				goto IL_2AD;
				IL_388:
				theShip.OODADetectionCycle = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
				theShip.OODATargetingCycle = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
				theShip.OODAEvasiveCycle = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
				theShip.OperatorCountry = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
				try
				{
					theShip.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 200475", ex4.Message);
					GameGeneral.LogException(ref ex4);
					bool arg_447_0 = Debugger.IsAttached;
					ProjectData.ClearProjectError();
				}
				num2++;
				continue;
				IL_2AD:
				try
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
					{
						theShip.Cargo_Crew = (float)Conversions.ToShort(dataRow["Cargo_Crew"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
					{
						theShip.Cargo_Area = (float)Conversions.ToShort(dataRow["Cargo_Area"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
					{
						theShip.Cargo_Type = (_CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
					{
						theShip.Cargo_Mass = (float)Conversions.ToShort(dataRow["Cargo_Mass"]);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				goto IL_388;
				IL_45A:
				theShip.Crew = Conversions.ToInteger(dataRow["Crew"]);
				theShip.ArmorBelt = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorBelt"]);
				theShip.ArmorBridge = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorBridge"]);
				theShip.ArmorBulkheads = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorBulkheads"]);
				theShip.ArmorCIC = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorCIC"]);
				theShip.ArmorDeck = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorDeck"]);
				theShip.ArmorEngineering = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorEngineering"]);
				theShip.ArmorRudder = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorRudder"]);
				theShip.MaxSeaState = Conversions.ToByte(dataRow["MaxSeaState"]);
				theShip.RepairCapacity = (short)Conversions.ToInteger(dataRow["RepairCapacity"]);
				theShip.TroopCapacity = (short)Conversions.ToInteger(dataRow["TroopCapacity"]);
				theShip.CargoCapacity = (short)Conversions.ToInteger(dataRow["CargoCapacity"]);
				theShip.MissileDefense = Conversions.ToShort(dataRow["MissileDefense"]);
				theShip.SetInitialDP(Conversions.ToInteger(dataRow["DamagePoints"]));
				theShip.SetDamagePts(false, Conversions.ToSingle(dataRow["DamagePoints"]));
				theShip.DisplacementEmpty = Conversions.ToDouble(dataRow["DisplacementEmpty"]);
				theShip.DisplacementStandard = Conversions.ToDouble(dataRow["DisplacementStandard"]);
				theShip.DisplacementFull = Conversions.ToDouble(dataRow["DisplacementFull"]);
				theShip.WeightEmpty = (int)Math.Round(theShip.DisplacementStandard);
				theShip.Beam = Conversions.ToSingle(dataRow["Beam"]);
				theShip.Draft = Conversions.ToSingle(dataRow["Draft"]);
				theShip.Height = Conversions.ToSingle(dataRow["Height"]);
				if (dataTable.Columns.Contains("Cargo_Crew"))
				{
					goto IL_2AD;
				}
				goto IL_388;
			}
			DBFunctions.LoadShipCodesData(ref theShip, ShipDBID);
			if (LoadComponents)
			{
				DBFunctions.LoadPlatformSensorsData(theShip, ShipDBID);
				DBFunctions.LoadPlatformCommStuffData(theShip, ShipDBID);
				ActiveUnit activeUnit = theShip;
				DBFunctions.LoadPlatformMountsData(ref theScen, ref activeUnit, ShipDBID);
				DBFunctions.LoadPlatformPropulsionData(theShip, ShipDBID);
				DBFunctions.LoadPlatformFuelsData(theShip, ShipDBID);
				Platform platform = theShip;
				DBFunctions.LoadPlatformMagazinesData(ref platform, ShipDBID);
				platform = theShip;
				DBFunctions.LoadAircraftFacilitiesData(ref platform, ShipDBID);
				platform = theShip;
				DBFunctions.LoadDockingFacilitiesData(ref platform, ShipDBID);
			}
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x00307D8C File Offset: 0x00305F8C
		public static void LoadShipCodesData(ref Ship ship_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(ship_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select * from DataShipCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 4012)
				{
					if (num2 <= 1011)
					{
						if (num2 != 1001)
						{
							if (num2 != 1002)
							{
								if (num2 != 1011)
								{
									goto IL_55B;
								}
								ship_0.ShipCode.PrairieMasker = true;
							}
							else
							{
								ship_0.ShipCode.NuclearShockResistant = true;
							}
						}
						else
						{
							ship_0.ShipCode.bool_5 = true;
						}
					}
					else if (num2 != 1012)
					{
						switch (num2)
						{
						case 3001:
							ship_0.ShipCode.PassiveOrSingleStabilizers = true;
							break;
						case 3002:
							ship_0.ShipCode.DualOrTripleStabilizers = true;
							break;
						case 3003:
							ship_0.ShipCode.bool_6 = true;
							break;
						case 3004:
							ship_0.ShipCode.bool_4 = true;
							break;
						default:
							switch (num2)
							{
							case 4001:
								ship_0.ShipCode.LowConstructionStandards = true;
								break;
							case 4002:
								ship_0.ShipCode.AllAluminumConstruction = true;
								break;
							case 4003:
								ship_0.ShipCode.AluminumSuperstructureOnly = true;
								break;
							case 4004:
							case 4005:
							case 4008:
							case 4009:
							case 4010:
								goto IL_55B;
							case 4006:
								ship_0.ShipCode.WoodenHullConstruction = true;
								break;
							case 4007:
								ship_0.ShipCode.GlassReinforcedPolyesterConstruction = true;
								break;
							case 4011:
								ship_0.ShipCode.Hovercraft_SES = true;
								break;
							case 4012:
								ship_0.ShipCode.Catamaran_TrimaranMultihull = true;
								break;
							default:
								goto IL_55B;
							}
							break;
						}
					}
					else
					{
						ship_0.ShipCode.AdvancedQuieting = true;
					}
				}
				else if (num2 <= 6004)
				{
					if (num2 != 4020)
					{
						if (num2 != 4022)
						{
							switch (num2)
							{
							case 6001:
								ship_0.ShipCode.DegaussedSteelHull = true;
								break;
							case 6002:
								ship_0.ShipCode.OnboardDegaussingGear = true;
								break;
							case 6003:
								ship_0.ShipCode.WoodenHull = true;
								break;
							case 6004:
								ship_0.ShipCode.GlassReinforcedPolyesterHull = true;
								break;
							default:
								goto IL_55B;
							}
						}
						else
						{
							ship_0.ShipCode.BuiltToMercantileStandards = true;
						}
					}
					else
					{
						ship_0.ShipCode.LaidDownBefore1930 = true;
					}
				}
				else if (num2 <= 8112)
				{
					switch (num2)
					{
					case 8001:
						ship_0.RefuelOrReplenish.RefuelToPort_Out = 1;
						break;
					case 8002:
						ship_0.RefuelOrReplenish.RefuelToPort_Out = 2;
						break;
					case 8003:
						ship_0.RefuelOrReplenish.RefuelToPort_Out = 3;
						break;
					case 8004:
						ship_0.RefuelOrReplenish.RefuelToPort_Out = 4;
						break;
					case 8005:
						ship_0.RefuelOrReplenish.RefuelToStarboard_Out = 1;
						break;
					case 8006:
						ship_0.RefuelOrReplenish.RefuelToStarboard_Out = 2;
						break;
					case 8007:
						ship_0.RefuelOrReplenish.RefuelToStarboard_Out = 3;
						break;
					case 8008:
						ship_0.RefuelOrReplenish.RefuelToStarboard_Out = 4;
						break;
					case 8009:
					case 8010:
						goto IL_55B;
					case 8011:
						ship_0.RefuelOrReplenish.RefuelToAstern_Out = 1;
						break;
					case 8012:
						ship_0.RefuelOrReplenish.RefuelToAstern_Out = 2;
						break;
					default:
						switch (num2)
						{
						case 8101:
							ship_0.RefuelOrReplenish.RefuelFromPort_In = 1;
							break;
						case 8102:
							ship_0.RefuelOrReplenish.RefuelFromPort_In = 2;
							break;
						case 8103:
							ship_0.RefuelOrReplenish.RefuelFromPort_In = 3;
							break;
						case 8104:
							ship_0.RefuelOrReplenish.RefuelFromPort_In = 4;
							break;
						case 8105:
							ship_0.RefuelOrReplenish.RefuelFromPort_In = 5;
							break;
						case 8106:
							ship_0.RefuelOrReplenish.RefuelFromStarboard_In = 1;
							break;
						case 8107:
							ship_0.RefuelOrReplenish.RefuelFromStarboard_In = 2;
							break;
						case 8108:
							ship_0.RefuelOrReplenish.RefuelFromStarboard_In = 3;
							break;
						case 8109:
							ship_0.RefuelOrReplenish.RefuelFromStarboard_In = 4;
							break;
						case 8110:
							ship_0.RefuelOrReplenish.RefuelFromStarboard_In = 5;
							break;
						case 8111:
							ship_0.RefuelOrReplenish.RefuelFromAstern_In = 1;
							break;
						case 8112:
							ship_0.RefuelOrReplenish.RefuelFromAstern_In = 2;
							break;
						default:
							goto IL_55B;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 9001:
						ship_0.RefuelOrReplenish.ReplenishToPort_Out = 1;
						break;
					case 9002:
						ship_0.RefuelOrReplenish.ReplenishToPort_Out = 2;
						break;
					case 9003:
						ship_0.RefuelOrReplenish.ReplenishToPort_Out = 3;
						break;
					case 9004:
						ship_0.RefuelOrReplenish.ReplenishToPort_Out = 4;
						break;
					case 9005:
						ship_0.RefuelOrReplenish.ReplenishToStarboard_Out = 1;
						break;
					case 9006:
						ship_0.RefuelOrReplenish.ReplenishToStarboard_Out = 2;
						break;
					case 9007:
						ship_0.RefuelOrReplenish.ReplenishToStarboard_Out = 3;
						break;
					case 9008:
						ship_0.RefuelOrReplenish.ReplenishToStarboard_Out = 4;
						break;
					default:
						switch (num2)
						{
						case 9101:
							ship_0.RefuelOrReplenish.ReplenishFromPort_In = 1;
							goto IL_670;
						case 9102:
							ship_0.RefuelOrReplenish.ReplenishFromPort_In = 2;
							goto IL_670;
						case 9103:
							ship_0.RefuelOrReplenish.ReplenishFromPort_In = 3;
							goto IL_670;
						case 9104:
							ship_0.RefuelOrReplenish.ReplenishFromPort_In = 4;
							goto IL_670;
						case 9105:
							ship_0.RefuelOrReplenish.ReplenishFromStarboard_In = 1;
							goto IL_670;
						case 9106:
							ship_0.RefuelOrReplenish.ReplenishFromStarboard_In = 2;
							goto IL_670;
						case 9107:
							ship_0.RefuelOrReplenish.ReplenishFromStarboard_In = 3;
							goto IL_670;
						case 9108:
							ship_0.RefuelOrReplenish.ReplenishFromStarboard_In = 4;
							goto IL_670;
						}
						goto IL_55B;
					}
				}
				IL_670:
				i++;
				continue;
				IL_55B:
				if (Debugger.IsAttached)
				{
					goto IL_670;
				}
				goto IL_670;
			}
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x0030841C File Offset: 0x0030661C
		public static void LoadSubmarineData(ref Scenario theScen, ref Submarine theSub, int SubDBID, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select * from DataSubmarine where ID = " + Conversions.ToString(SubDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception("No submarine with ID: " + Conversions.ToString(SubDBID) + " was found in the current database!");
			}
			DataRow dataRow = dataTable.Rows[0];
			if (!dataTable.Columns.Contains("OODADetectionCycle"))
			{
				dataTable.Columns.Add("OODADetectionCycle", typeof(string));
				dataRow["OODADetectionCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODATargetingCycle"))
			{
				dataTable.Columns.Add("OODATargetingCycle", typeof(string));
				dataRow["OODATargetingCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
			{
				dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
				dataRow["OODAEvasiveCycle"] = 0;
			}
			theSub.Category = (Submarine._SubmarineCategory)Conversions.ToInteger(dataRow["Category"]);
			theSub.Type = (Submarine._SubmarineType)Conversions.ToInteger(dataRow["Type"]);
			theSub.DBID = SubDBID;
			theSub.UnitClass = Strings.Trim(dataRow["Name"].ToString());
			theSub.Length = Conversions.ToSingle(dataRow["Length"]);
			try
			{
				theSub.PhysicalSizeCode = (DockFacility._DockFacilityPhysicalSizeCode)Conversions.ToShort(dataRow["PhysicalSizeCode"]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				float length = theSub.Length;
				if (length <= 11f)
				{
					theSub.PhysicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.VerySmallPier;
				}
				else if (length <= 17f)
				{
					theSub.PhysicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.SmallPier;
				}
				else if (length <= 25f)
				{
					theSub.PhysicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.MediumPier;
				}
				else if (length <= 45f)
				{
					theSub.PhysicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.LargePier;
				}
				else if (length <= 200f)
				{
					theSub.PhysicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.VeryLargePier;
				}
				else
				{
					theSub.PhysicalSizeCode = DockFacility._DockFacilityPhysicalSizeCode.ExtraLargePier;
				}
				ex2.Data.Add("Error at 200074", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			theSub.WeightEmpty = (int)Math.Round(Conversions.ToDouble(dataRow["DisplacementStandard"].ToString()));
			theSub.Crew = Conversions.ToInteger(dataRow["Crew"]);
			theSub.MaxDepth = Conversions.ToInteger(dataRow["MaxDepth"]);
			theSub.SetInitialDP(Conversions.ToInteger(dataRow["DamagePoints"]));
			theSub.SetDamagePts(false, Conversions.ToSingle(dataRow["DamagePoints"]));
			theSub.GetSubmarineKinematics().SetClimbRate(2f);
			theSub.Beam = Conversions.ToSingle(dataRow["Beam"]);
			theSub.Draft = Conversions.ToSingle(dataRow["Draft"]);
			theSub.Height = Conversions.ToSingle(dataRow["Height"]);
			if (dataTable.Columns.Contains("DisplacementEmpty"))
			{
				theSub.DisplacementEmpty = Conversions.ToDouble(dataRow["DisplacementEmpty"]);
			}
			if (dataTable.Columns.Contains("DisplacementStandard"))
			{
				theSub.DisplacementStandard = Conversions.ToDouble(dataRow["DisplacementStandard"]);
			}
			if (dataTable.Columns.Contains("DisplacementFull"))
			{
				theSub.DisplacementFull = Conversions.ToDouble(dataRow["DisplacementFull"]);
			}
			theSub.OODATargetingCycle = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
			theSub.OODATargetingCycle = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
			theSub.OODAEvasiveCycle = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
			theSub.OperatorCountry = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
			if (dataTable.Columns.Contains("ROVRadius"))
			{
				theSub.ROVRadius = Conversions.ToShort(dataRow["ROVRadius"].ToString());
			}
			try
			{
				theSub.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			DBFunctions.LoadSubmarineCodesData(theSub, SubDBID);
			if (LoadComponents)
			{
				DBFunctions.LoadPlatformSensorsData(theSub, SubDBID);
				DBFunctions.LoadPlatformCommStuffData(theSub, SubDBID);
				ActiveUnit activeUnit = theSub;
				DBFunctions.LoadPlatformMountsData(ref theScen, ref activeUnit, SubDBID);
				DBFunctions.LoadPlatformPropulsionData(theSub, SubDBID);
				DBFunctions.LoadPlatformFuelsData(theSub, SubDBID);
				Platform platform = theSub;
				DBFunctions.LoadPlatformMagazinesData(ref platform, SubDBID);
				platform = theSub;
				DBFunctions.LoadDockingFacilitiesData(ref platform, SubDBID);
			}
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x00308930 File Offset: 0x00306B30
		public static void LoadSubmarineCodesData(Submarine submarine_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(submarine_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select * from DataSubmarineCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 2001)
				{
					switch (num2)
					{
					case 1001:
						submarine_0.submarineCode.None = true;
						break;
					case 1002:
						submarine_0.submarineCode.NonmagneticHull = true;
						break;
					case 1003:
						submarine_0.submarineCode.NoLaunchTransient = true;
						break;
					case 1004:
						submarine_0.submarineCode.ShroudedPropulsor = true;
						break;
					case 1005:
						submarine_0.submarineCode.AdvancedPropulsor = true;
						break;
					default:
						if (num2 != 2001)
						{
							goto IL_119;
						}
						goto IL_100;
					}
				}
				else if (num2 != 2002)
				{
					if (num2 == 4004)
					{
						goto IL_100;
					}
					if (num2 != 9001)
					{
						goto IL_119;
					}
					submarine_0.submarineCode.Snorkel = true;
				}
				else
				{
					submarine_0.submarineCode.ShockResistant = true;
				}
				IL_144:
				i++;
				continue;
				IL_100:
				submarine_0.submarineCode.DoubleHull = true;
				goto IL_144;
				IL_119:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_144;
				}
				goto IL_144;
			}
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x00308A94 File Offset: 0x00306C94
		public static void LoadFacilityData(ref Scenario theScen, ref Facility theFac, int FacilityDBID, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select * from DataFacility where ID = " + Conversions.ToString(FacilityDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int count = dataTable.Rows.Count;
			if (count == 0)
			{
				throw new Exception("No facility with ID: " + Conversions.ToString(FacilityDBID) + " was found in the current database!");
			}
			int num = count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataRow dataRow = dataTable.Rows[num2];
				if (!dataTable.Columns.Contains("OODADetectionCycle"))
				{
					dataTable.Columns.Add("OODADetectionCycle", typeof(string));
					dataRow["OODADetectionCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODATargetingCycle"))
				{
					dataTable.Columns.Add("OODATargetingCycle", typeof(string));
					dataRow["OODATargetingCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
				{
					dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
					dataRow["OODAEvasiveCycle"] = 0;
				}
				theFac.DBID = FacilityDBID;
				theFac.UnitClass = dataRow["Name"].ToString();
				theFac.ArmorGeneral = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]);
				theFac.MastHeight = Conversions.ToInteger(dataRow["MastHeight"]);
				theFac.MissileDefense = Conversions.ToInteger(dataRow["MissileDefense"]);
				theFac.SetInitialDP(Conversions.ToInteger(dataRow["DamagePoints"]));
				theFac.SetDamagePts(false, Conversions.ToSingle(dataRow["DamagePoints"]));
				theFac.Category = (Facility._FacilityCategory)Conversions.ToShort(dataRow["Category"]);
				theFac.Length = Conversions.ToSingle(dataRow["Length"]);
				theFac.Width = Conversions.ToSingle(dataRow["Width"]);
				theFac.Area = Conversions.ToDouble(dataRow["Area"]);
				theFac.MountsAreAimpoints = Conversions.ToBoolean(dataRow["MountsAreAimpoints"]);
				theFac.Radius = Conversions.ToInteger(dataRow["Radius"]);
				theFac.OODADetectionCycle = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
				theFac.OODATargetingCycle = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
				theFac.OODAEvasiveCycle = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
				theFac.OperatorCountry = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
				try
				{
					theFac.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200476", ex2.Message);
					GameGeneral.LogException(ref ex2);
					bool arg_320_0 = Debugger.IsAttached;
					ProjectData.ClearProjectError();
				}
			}
			if (LoadComponents)
			{
				DBFunctions.LoadPlatformSensorsData(theFac, FacilityDBID);
				DBFunctions.LoadPlatformCommStuffData(theFac, FacilityDBID);
				ActiveUnit activeUnit = theFac;
				DBFunctions.LoadPlatformMountsData(ref theScen, ref activeUnit, FacilityDBID);
				DBFunctions.LoadPlatformFuelsData(theFac, FacilityDBID);
				Platform platform = theFac;
				DBFunctions.LoadPlatformMagazinesData(ref platform, FacilityDBID);
				platform = theFac;
				DBFunctions.LoadAircraftFacilitiesData(ref platform, FacilityDBID);
				platform = theFac;
				DBFunctions.LoadDockingFacilitiesData(ref platform, FacilityDBID);
			}
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x00308E34 File Offset: 0x00307034
		public static Weapon._WeaponType GetWeaponTyp(int DBID, Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "SELECT Type from DataWeapon where ID = " + Conversions.ToString(DBID);
			return (Weapon._WeaponType)Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x00308E70 File Offset: 0x00307070
		public static WeaponRec LoadWeaponRecordData(int int_0, Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "SELECT * from DataWeaponRecord where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			DataRow dataRow = dataTable.Rows[0];
			bool bool_ = dataTable.Columns.Contains("Optional") && Conversions.ToBoolean(dataRow["Optional"]);
			bool bool_2 = dataTable.Columns.Contains("Internal") && Conversions.ToBoolean(dataRow["Internal"]);
			return new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), bool_, bool_2);
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x00308F78 File Offset: 0x00307178
		public static void LoadWeaponData(SQLiteConnection theConn, Weapon theWeapon, int WeaponDBID, Scenario theScen, bool LoadComponents = true)
		{
			try
			{
				SQLiteDataBase db = new SQLiteDataBase(theConn);
				string string_ = "SELECT * from DataWeapon where ID = " + Conversions.ToString(WeaponDBID);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				DataRow dataRow = dataTable.Rows[0];
				if (!dataTable.Columns.Contains("TorpedoRangeCruise"))
				{
					dataTable.Columns.Add("TorpedoRangeCruise", typeof(string));
					dataRow["TorpedoRangeCruise"] = 0;
				}
				if (!dataTable.Columns.Contains("TorpedoRangeFull"))
				{
					dataTable.Columns.Add("TorpedoRangeFull", typeof(string));
					dataRow["TorpedoRangeFull"] = 0;
				}
				if (!dataTable.Columns.Contains("LandRangeMax"))
				{
					dataTable.Columns.Add("LandRangeMax", typeof(string));
					dataRow["LandRangeMax"] = 0;
				}
				if (!dataTable.Columns.Contains("LandRangeMin"))
				{
					dataTable.Columns.Add("LandRangeMin", typeof(string));
					dataRow["LandRangeMin"] = 0;
				}
				if (!dataTable.Columns.Contains("LandPOK"))
				{
					try
					{
						dataTable.Columns.Add("LandPOK", typeof(string));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					dataRow["LandPOK"] = 0;
				}
				if (!dataTable.Columns.Contains("CEPSurface"))
				{
					try
					{
						dataTable.Columns.Add("CEPSurface", typeof(string));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					dataRow["CEPSurface"] = 0;
				}
				if (dataTable.Columns.Contains("SnapUpDownAltitude"))
				{
					theWeapon.SnapUpDownAltitude_m = Conversions.ToSingle(dataRow["SnapUpDownAltitude"]);
				}
				string text = Strings.Trim(Misc.smethod_11(Conversions.ToString(dataRow["Name"])));
				theWeapon.DBID = WeaponDBID;
				theWeapon.UnitClass = text;
				theWeapon.Name = text;
				theWeapon.SetWeaponType((Weapon._WeaponType)Conversions.ToShort(dataRow["Type"]));
				theWeapon.techGenerationClass = (GlobalVariables.TechGenerationClass)Conversions.ToInteger(dataRow["Generation"]);
				theWeapon.Length = Conversions.ToSingle(dataRow["Length"]);
				theWeapon.Span = Conversions.ToSingle(dataRow["Span"]);
				theWeapon.Diameter = Conversions.ToSingle(dataRow["Diameter"]);
				theWeapon.WeightEmpty = Conversions.ToInteger(dataRow["Weight"]);
				theWeapon.WeightMax = Conversions.ToInteger(dataRow["Weight"]);
				theWeapon.BurnoutWeight = Conversions.ToInteger(dataRow["BurnoutWeight"]);
				try
				{
					theWeapon.CEPSurface = Conversions.ToInteger(dataRow["CEPSurface"]);
					if (theWeapon.CEPSurface == 0)
					{
						theWeapon.CEPSurface = Conversions.ToInteger(dataRow["CEP"]);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					theWeapon.CEPSurface = Conversions.ToInteger(dataRow["CEP"]);
					ProjectData.ClearProjectError();
				}
				theWeapon.SetCEP_Surface(theWeapon.CEPSurface);
				theWeapon.CEP = Conversions.ToInteger(dataRow["CEP"]);
				theWeapon.SetCEP_Land(theWeapon.CEP);
				theWeapon.DetonationDelay = Conversions.ToSingle(dataRow["DetonationDelay"]);
				theWeapon.CanActAsSensor = Conversions.ToBoolean(dataRow["CanActAsSensor"]);
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theConn))
				{
					theWeapon.SetCruiseAltitude_ASL(Conversions.ToSingle(dataRow["CruiseAltitude_ASL"]));
				}
				else
				{
					theWeapon.SetCruiseAltitude_ASL(Conversions.ToSingle(dataRow["CruiseAltitude"]));
				}
				theWeapon.CruiseAltitude = Conversions.ToSingle(dataRow["CruiseAltitude"]);
				theWeapon.WaypointNumber = Conversions.ToInteger(dataRow["WaypointNumber"]);
				theWeapon.IlluminationTime = Conversions.ToInteger(dataRow["IlluminationTime"]);
				theWeapon.SurfacePOK = Conversions.ToInteger(dataRow["SurfacePOK"]);
				try
				{
					theWeapon.LandPOK = Conversions.ToInteger(dataRow["LandPOK"]);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					theWeapon.LandPOK = 0;
					ProjectData.ClearProjectError();
				}
				theWeapon.SubsurfacePOK = Conversions.ToInteger(dataRow["SubsurfacePOK"]);
				theWeapon.AirPOK = Conversions.ToInteger(dataRow["AirPOK"]);
				theWeapon.GetWeaponKinematics().SetClimbRate(Conversions.ToSingle(dataRow["ClimbRate"]));
				theWeapon.LaunchSpeedMax = Conversions.ToInteger(dataRow["LaunchSpeedMax"]);
				theWeapon.LaunchSpeedMin = Conversions.ToInteger(dataRow["LaunchSpeedMin"]);
				theWeapon.RangeAAWMax = Conversions.ToSingle(dataRow["AirRangeMax"]);
				theWeapon.RangeAAWMin = Conversions.ToSingle(dataRow["AirRangeMin"]);
				theWeapon.RangeASUWMax = Conversions.ToSingle(dataRow["SurfaceRangeMax"]);
				theWeapon.RangeASUWMin = Conversions.ToSingle(dataRow["SurfaceRangeMin"]);
				theWeapon.RangeLandMax = Conversions.ToSingle(dataRow["LandRangeMax"]);
				theWeapon.RangeLandMin = Conversions.ToSingle(dataRow["LandRangeMin"]);
				theWeapon.RangeASWMax = Conversions.ToSingle(dataRow["SubsurfaceRangeMax"]);
				theWeapon.RangeASWMin = Conversions.ToSingle(dataRow["SubsurfaceRangeMin"]);
				theWeapon.TorpedoRangeFull = Conversions.ToSingle(dataRow["TorpedoRangeFull"]);
				theWeapon.TorpedoRangeCruise = Conversions.ToSingle(dataRow["TorpedoRangeCruise"]);
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theConn))
				{
					theWeapon.LaunchAltitudeMax_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMax_ASL"]), 1);
					theWeapon.LaunchAltitudeMin_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMin_ASL"]), 1);
					theWeapon.TargetAltitudeMax_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMax_ASL"]), 1);
					theWeapon.TargetAltitudeMin_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMin_ASL"]), 1);
				}
				theWeapon.LaunchAltitudeMax = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMax"]), 1);
				theWeapon.LaunchAltitudeMin = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMin"]), 1);
				theWeapon.TargetAltitudeMax = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMax"]), 1);
				theWeapon.TargetAltitudeMin = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMin"]), 1);
				theWeapon.TargetSpeedMax = Conversions.ToInteger(dataRow["TargetSpeedMax"]);
				theWeapon.TargetSpeedMin = Conversions.ToInteger(dataRow["TargetSpeedMin"]);
				theWeapon.SetInitialDP(1);
				theWeapon.SetDamagePts(false, 1f);
				try
				{
					theWeapon.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200477", ex2.Message);
					GameGeneral.LogException(ref ex2);
					bool arg_730_0 = Debugger.IsAttached;
					ProjectData.ClearProjectError();
				}
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.GetSQLiteConnection()))
				{
					theWeapon.SetCruiseAltitude_ASL(Conversions.ToSingle(dataRow["CruiseAltitude_ASL"]));
					theWeapon.LaunchAltitudeMax_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMax_ASL"]), 1);
					theWeapon.LaunchAltitudeMin_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMin_ASL"]), 1);
					theWeapon.TargetAltitudeMax_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMax_ASL"]), 1);
					theWeapon.TargetAltitudeMin_ASL = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMin_ASL"]), 1);
				}
				if (theWeapon.IsTorpedo() && theWeapon.RangeASUWMax == 6f && theWeapon.RangeASWMax == 6f)
				{
					theWeapon.RangeASUWMax = 8f;
					theWeapon.RangeASWMax = 8f;
				}
				theWeapon.weaponTarget = new WeaponTarget(WeaponDBID, ref theConn);
				DBFunctions.smethod_60(ref theWeapon, WeaponDBID);
				DBFunctions.smethod_61(ref theScen, ref theWeapon, WeaponDBID);
				DBFunctions.LoadWeaponCodesData(ref theWeapon, ref theWeapon.weaponCode);
				Doctrine doctrine;
				Dictionary<int, Doctrine.WRA_Weapon> wRA_WeaponDictionary = (doctrine = theWeapon.m_Doctrine).GetWRA_WeaponDictionary();
				DBFunctions.smethod_64(ref theWeapon, ref wRA_WeaponDictionary);
				doctrine.SetWRA_WeaponDictionary(wRA_WeaponDictionary);
				if (LoadComponents)
				{
					DBFunctions.LoadWeaponData(ref theWeapon);
				}
				if (theWeapon.RangeASUWMax > 0f && theWeapon.RangeLandMax == 0f && (theWeapon.weaponTarget.bool_15 || theWeapon.weaponTarget.IsAirfield || theWeapon.weaponTarget.IsHardLandStructures || theWeapon.weaponTarget.IsSoftLandStructures || theWeapon.weaponTarget.IsRunway || theWeapon.weaponTarget.IsRadar || theWeapon.weaponTarget.IsHardMobileUnit || theWeapon.weaponTarget.IsSoftMobileUnit || theWeapon.weaponTarget.IsUnderwaterStructure))
				{
					theWeapon.RangeLandMax = theWeapon.RangeASUWMax;
					theWeapon.RangeLandMin = theWeapon.RangeASUWMin;
					theWeapon.LandPOK = theWeapon.SurfacePOK;
				}
				if (theWeapon.TargetIsShipOrRadar() && !theWeapon.IsTorpedo() && !theWeapon.IsDecoy() && !theWeapon.IsMine() && theWeapon.GetWeaponType() != Weapon._WeaponType.Laser && theWeapon.CEPSurface == 0 && Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (theWeapon.TargetIsLandFacility() && theWeapon.CEP == 0 && Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (theWeapon.weaponCode.BallisticMissile || theWeapon.IsRVorHGV())
				{
					theWeapon.weaponCode.BOLCapable = true;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200274", ex4.Message);
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x00309A2C File Offset: 0x00307C2C
		private static void LoadWeaponData(ref Weapon weapon_)
		{
			int dBID = weapon_.DBID;
			DBFunctions.LoadPlatformPropulsionData(weapon_, dBID);
			DBFunctions.LoadPlatformSensorsData(weapon_, dBID);
			DBFunctions.LoadPlatformFuelsData(weapon_, dBID);
			DBFunctions.LoadPlatformCommStuffData(weapon_, dBID);
			DBFunctions.LoadWeaponWarheadsData(ref weapon_.m_Warheads, ref weapon_);
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00309A70 File Offset: 0x00307C70
		private static void smethod_60(ref Weapon weapon_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(weapon_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select DataSensor.ID from DataSensor, DataWeaponDirectors as theTable where DataSensor.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				weapon_0.weaponDirectorSet.Add(Conversions.ToInteger(dataRow["ID"]));
			}
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x00309AF8 File Offset: 0x00307CF8
		public static void smethod_61(ref Scenario scenario_0, ref Weapon weapon_0, int int_0)
		{
			if (weapon_0.m_Scenario.FeatureCompatibility.get_LPI_Radars(weapon_0.m_Scenario.GetSQLiteConnection()))
			{
				SQLiteDataBase db = new SQLiteDataBase(weapon_0.m_Scenario.GetSQLiteConnection());
				string string_ = "SELECT DataWeaponRecord.* FROM DataWeaponWeapons, DataWeaponRecord, DataWeapon WHERE DataWeaponWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataWeaponWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					WeaponRec weaponRec = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
					weaponRec.RecID = new int?(Conversions.ToInteger(dataRow["ID"]));
					weapon_0.GetWeaponRecCollection().Add(weaponRec);
				}
			}
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00309C1C File Offset: 0x00307E1C
		private static void smethod_62(Scenario scenario_0, ref Mount mount_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "Select DataSensor.ID from DataSensor, DataMountDirectors as theTable where DataSensor.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(mount_0.DBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int count = dataTable.Rows.Count;
			mount_0.MountDirectorSet.Clear();
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				mount_0.MountDirectorSet.Add(Conversions.ToInteger(dataRow["ID"]));
			}
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00309CB4 File Offset: 0x00307EB4
		public static void LoadWeaponCodesData(ref Weapon weapon_0, ref Weapon.WeaponCode weaponCode_)
		{
			SQLiteDataBase db = new SQLiteDataBase(weapon_0.m_Scenario.GetSQLiteConnection());
			string string_ = "SELECT * from DataWeaponCodes where ID = " + Conversions.ToString(weapon_0.DBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 6129)
				{
					if (num2 <= 6001)
					{
						if (num2 <= 3001)
						{
							if (num2 <= 1101)
							{
								switch (num2)
								{
								case 1001:
									weaponCode_.IlluminateAtLaunch = true;
									break;
								case 1002:
									weaponCode_.TerminalIllumination = true;
									break;
								case 1003:
									weaponCode_.SupportsBuddyIllumination = true;
									break;
								default:
									if (num2 != 1101)
									{
										goto IL_5D2;
									}
									weaponCode_.HomeOnJam = true;
									break;
								}
							}
							else
							{
								switch (num2)
								{
								case 2001:
									weaponCode_.AntiAir_SternChase = true;
									break;
								case 2002:
									weaponCode_.AntiAir_RearAspect = true;
									break;
								case 2003:
									weaponCode_.AntiAir_AllAspect = true;
									break;
								case 2004:
									weaponCode_.AntiAir_Dogfight_HighOffBoresight = true;
									break;
								case 2005:
									weaponCode_.NoDivingTargetMod = true;
									break;
								case 2006:
									weaponCode_.CapableVsSeaskimmer = true;
									break;
								case 2007:
								case 2008:
									goto IL_5D2;
								case 2009:
									weaponCode_.Counter_RocketArtyMortar_Capable = true;
									break;
								case 2010:
									weaponCode_.LockOnAfterLaunch_CEC_Capable = true;
									break;
								case 2011:
									weaponCode_.TerrainFollowing = true;
									break;
								case 2012:
									weaponCode_.LockOnAfterLaunch = true;
									break;
								default:
									if (num2 != 3001)
									{
										goto IL_5D2;
									}
									weaponCode_.ARMTargetMemory = true;
									break;
								}
							}
						}
						else if (num2 <= 4003)
						{
							if (num2 != 3003)
							{
								switch (num2)
								{
								case 4001:
									weaponCode_.SearchPattern = true;
									break;
								case 4002:
									weaponCode_.DriveThroughLogic = true;
									break;
								case 4003:
									weaponCode_.BOLCapable = true;
									break;
								default:
									goto IL_5D2;
								}
							}
							else
							{
								weaponCode_.ARMLoiterCapability = true;
							}
						}
						else if (num2 != 4010)
						{
							if (num2 != 6001)
							{
								goto IL_5D2;
							}
							weaponCode_.Pod_TerrainAvoidance = true;
						}
						else
						{
							weaponCode_.BallisticMissile = true;
						}
					}
					else if (num2 <= 6022)
					{
						if (num2 <= 6012)
						{
							if (num2 != 6002)
							{
								switch (num2)
								{
								case 6009:
									weaponCode_.Pod_DayOnlyNavigation = true;
									break;
								case 6010:
									weaponCode_.Pod_DayOnlyNavigationAndAttack = true;
									break;
								case 6011:
									weaponCode_.Pod_NightNavigation = true;
									break;
								case 6012:
									weaponCode_.Pod_NightNavigationAndAttack = true;
									break;
								default:
									goto IL_5D2;
								}
							}
							else
							{
								weaponCode_.Pod_TerrainFollowing = true;
							}
						}
						else if (num2 != 6021)
						{
							if (num2 != 6022)
							{
								goto IL_5D2;
							}
							weaponCode_.Pod_Recon_NightCapable = true;
						}
						else
						{
							weaponCode_.Pod_Recon_DayOnly = true;
						}
					}
					else if (num2 <= 6111)
					{
						switch (num2)
						{
						case 6101:
							weaponCode_.Weapon_INSNavigation = true;
							break;
						case 6102:
							weaponCode_.Weapon_INS_w_GPSNavigation = true;
							break;
						case 6103:
							weaponCode_.Weapon_TERCOMNavigation = true;
							break;
						default:
							if (num2 != 6111)
							{
								goto IL_5D2;
							}
							weaponCode_.Weapon_PreBriefedTargetOnly = true;
							break;
						}
					}
					else
					{
						switch (num2)
						{
						case 6121:
							weaponCode_.TerminalManeuver_Popup = true;
							break;
						case 6122:
							weaponCode_.TerminalManeuver_Zigzag = true;
							break;
						case 6123:
							weaponCode_.TerminalManeuver_Random = true;
							break;
						default:
							if (num2 != 6129)
							{
								goto IL_5D2;
							}
							weaponCode_.ReAttackCapability = true;
							break;
						}
					}
				}
				else if (num2 <= 6401)
				{
					if (num2 <= 6321)
					{
						if (num2 <= 6311)
						{
							if (num2 != 6301)
							{
								if (num2 != 6311)
								{
									goto IL_5D2;
								}
								weaponCode_.Mine_MagneticFuze_SimpleMagnetic = true;
							}
							else
							{
								weaponCode_.Mine_ContactFuze = true;
							}
						}
						else if (num2 != 6312)
						{
							if (num2 != 6321)
							{
								goto IL_5D2;
							}
							weaponCode_.Mine_PassiveAcousticFuze_BroadBand = true;
						}
						else
						{
							weaponCode_.Mine_MagneticFuze_TotalFieldMagnetometer = true;
						}
					}
					else if (num2 <= 6331)
					{
						if (num2 != 6322)
						{
							if (num2 != 6331)
							{
								goto IL_5D2;
							}
							weaponCode_.Mine_PressureFuze = true;
						}
						else
						{
							weaponCode_.Mine_PassiveAcousticFuze_NarrowBand = true;
						}
					}
					else if (num2 != 6341)
					{
						if (num2 != 6401)
						{
							goto IL_5D2;
						}
						weaponCode_.Mine_DelayCounter = true;
					}
					else
					{
						weaponCode_.Mine_SeismicFuze = true;
					}
				}
				else if (num2 <= 7003)
				{
					if (num2 <= 6501)
					{
						if (num2 != 6402)
						{
							if (num2 != 6501)
							{
								goto IL_5D2;
							}
							weaponCode_.Mine_TargetDiscriminationAndIdentification = true;
						}
						else
						{
							weaponCode_.Mine_ArmingDelay = true;
						}
					}
					else if (num2 != 6511)
					{
						switch (num2)
						{
						case 7001:
							weaponCode_.Warhead_SingleReEntryVehicle = true;
							break;
						case 7002:
							weaponCode_.Warhead_MultipleReEntryVehicles = true;
							break;
						case 7003:
							weaponCode_.Warhead_MultipleIndependentReEntryVehicles = true;
							break;
						default:
							goto IL_5D2;
						}
					}
					else
					{
						weaponCode_.Mine_RemoteControlled = true;
					}
				}
				else if (num2 <= 8002)
				{
					if (num2 != 8001)
					{
						if (num2 != 8002)
						{
							goto IL_5D2;
						}
						weaponCode_.IsRetardedMunition = true;
					}
					else
					{
						weaponCode_.CapableVsMobileLandUnit = true;
					}
				}
				else
				{
					switch (num2)
					{
					case 9001:
						weaponCode_.Torpedo_StraightRunning = true;
						break;
					case 9002:
						weaponCode_.Torpedo_WakeHoming = true;
						break;
					case 9003:
						weaponCode_.Torpedo_StraightRunningAndTimeDetonation = true;
						break;
					case 9004:
						weaponCode_.Torpedo_PatternRunning = true;
						break;
					default:
						if (num2 != 9999)
						{
							goto IL_5D2;
						}
						weaponCode_.LevelCruiseFlight = true;
						break;
					}
				}
				IL_60E:
				i++;
				continue;
				IL_5D2:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_60E;
				}
				goto IL_60E;
			}
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x0030A2E4 File Offset: 0x003084E4
		public static void smethod_64(ref Weapon weapon_, ref Dictionary<int, Doctrine.WRA_Weapon> dictionary_2)
		{
			if (weapon_.m_Doctrine.IsLethalWeapon(ref weapon_))
			{
				SQLiteDataBase db = new SQLiteDataBase(weapon_.m_Scenario.GetSQLiteConnection());
				if (Information.IsNothing(dictionary_2))
				{
					dictionary_2 = new Dictionary<int, Doctrine.WRA_Weapon>();
				}
				if (!dictionary_2.ContainsKey(weapon_.DBID))
				{
					dictionary_2.Add(weapon_.DBID, new Doctrine.WRA_Weapon());
				}
				if (!weapon_.m_Scenario.FeatureCompatibility.get_WRA(weapon_.m_Scenario.GetSQLiteConnection()))
				{
					dictionary_2[weapon_.DBID].method_0(ref weapon_);
				}
				else
				{
					string string_ = "SELECT * from DataWeaponWRA where ID = " + Conversions.ToString(weapon_.DBID);
					DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
					int count = dataTable.Rows.Count;
					if (count > 0)
					{
						int num = count - 1;
						for (int i = 0; i <= num; i++)
						{
							DataRow dataRow = dataTable.Rows[i];
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = new Doctrine.WRA_WeaponTarget((Doctrine._WRA_WeaponTargetType)Conversions.ToInteger(dataRow["CodeID"]));
							wRA_WeaponTarget.WeaponQty = new int?(Conversions.ToInteger(dataRow["WeaponQty"]));
							wRA_WeaponTarget.ShooterQty = new int?(Conversions.ToInteger(dataRow["ShooterQty"]));
							wRA_WeaponTarget.SelfDefenceRange = new int?(Conversions.ToInteger(dataRow["SelfDefenceRange"]));
							ScenarioArrayUtil.AddWRA_WeaponTarget(ref dictionary_2[weapon_.DBID].WRA_WeaponTargetArray, wRA_WeaponTarget);
						}
					}
				}
			}
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x0030A478 File Offset: 0x00308678
		public static DataTable smethod_65(ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name from DataMount";
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x0030A49C File Offset: 0x0030869C
		public static DataTable smethod_66(ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name, Cargo_Type, Cargo_Mass, Cargo_Area, Cargo_Crew from DataMount where Cargo_Type <> 0 order by Name";
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x0030A4C0 File Offset: 0x003086C0
		public static DataTable smethod_67(ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name from DataMagazine";
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0030A4E4 File Offset: 0x003086E4
		public static DataTable smethod_68(ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name from DataSensor";
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x0030A508 File Offset: 0x00308708
		public static DataTable smethod_69(ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT DataWeaponRecord.ID, DataWeaponRecord.ComponentID, DataWeaponRecord.DefaultLoad, DataWeaponRecord.MaxLoad, DataWeaponRecord.ROF, DataWeaponRecord.Multiple, DataWeapon.Name from DataWeaponRecord INNER JOIN DataWeapon on DataWeapon.ID = DataWeaponRecord.ComponentID";
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x0030A52C File Offset: 0x0030872C
		public static DataTable smethod_70(bool bool_0, ref Scenario scenario_0, ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_;
			if (bool_0)
			{
				if (!Information.IsNothing(scenario_0) && !scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.GetSQLiteConnection()))
				{
					string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin from DataWeapon";
				}
				else
				{
					string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin, DataWeapon.TargetAltitudeMax_ASL, DataWeapon.TargetAltitudeMin_ASL from DataWeapon";
				}
			}
			else if (!Information.IsNothing(scenario_0) && !scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.GetSQLiteConnection()))
			{
				string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin from DataWeapon where DataWeapon.Type not in (2005, 2006, 2007, 2008, 3001, 3002, 3003, 3004, 4003, 9001, 9002, 9003)";
			}
			else
			{
				string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin , DataWeapon.TargetAltitudeMax_ASL, DataWeapon.TargetAltitudeMin_ASL from DataWeapon where DataWeapon.Type not in (2005, 2006, 2007, 2008, 3001, 3002, 3003, 3004, 4003, 9001, 9002, 9003)";
			}
			return CachedDataBase.GetDataTable(db, string_);
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x0030A5B8 File Offset: 0x003087B8
		public static Weapon._WeaponType GetWeaponType(int DBID, ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT type from DataWeapon where ID=" + Conversions.ToString(DBID);
			return (Weapon._WeaponType)Conversions.ToShort(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x0030A5EC File Offset: 0x003087EC
		public static void LoadSatelliteData(ref Scenario theScen, ref Satellite theSatellite, int SatDBID, int OrbitNumber = 0, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select * from DataSatellite where ID = " + Conversions.ToString(SatDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception("No satellite with ID: " + Conversions.ToString(SatDBID) + " was found in the current database!");
			}
			DataRow dataRow = dataTable.Rows[0];
			theSatellite.DBID = SatDBID;
			theSatellite.UnitClass = dataRow["Name"].ToString();
			if (!dataTable.Columns.Contains("OODADetectionCycle"))
			{
				dataTable.Columns.Add("OODADetectionCycle", typeof(string));
				dataRow["OODADetectionCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODATargetingCycle"))
			{
				dataTable.Columns.Add("OODATargetingCycle", typeof(string));
				dataRow["OODATargetingCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
			{
				dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
				dataRow["OODAEvasiveCycle"] = 0;
			}
			theSatellite.OODADetectionCycle = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
			theSatellite.OODATargetingCycle = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
			theSatellite.OODAEvasiveCycle = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
			if (dataTable.Columns.Contains("Category"))
			{
				theSatellite.SatelliteCategory = (Satellite._SatelliteCategory)Conversions.ToInteger(dataRow["Category"]);
			}
			if (dataTable.Columns.Contains("Type"))
			{
				theSatellite.SatelliteType = (Satellite._SatelliteType)Conversions.ToInteger(dataRow["Type"]);
			}
			if (dataTable.Columns.Contains("Length"))
			{
				theSatellite.Length = Conversions.ToSingle(dataRow["Length"]);
			}
			if (dataTable.Columns.Contains("Span"))
			{
				theSatellite.Span = Conversions.ToSingle(dataRow["Span"]);
			}
			if (dataTable.Columns.Contains("Height"))
			{
				theSatellite.Height = Conversions.ToSingle(dataRow["Height"]);
			}
			if (dataTable.Columns.Contains("WeightEmpty"))
			{
				theSatellite.WeightEmpty = Conversions.ToDouble(dataRow["WeightEmpty"]);
			}
			if (dataTable.Columns.Contains("WeightMax"))
			{
				theSatellite.WeightMax = Conversions.ToDouble(dataRow["WeightMax"]);
			}
			if (dataTable.Columns.Contains("WeightPayload"))
			{
				theSatellite.WeightPayload = Conversions.ToDouble(dataRow["WeightPayload"]);
			}
			if (dataTable.Columns.Contains("Armor"))
			{
				theSatellite.armorRating = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["Armor"]);
			}
			if (dataTable.Columns.Contains("DamagePoints"))
			{
				theSatellite.DamagePoints = Conversions.ToSingle(dataRow["DamagePoints"]);
			}
			try
			{
				theSatellite.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (OrbitNumber != 0)
			{
				string_ = "Select * from DataSatelliteOrbits where ID = " + Conversions.ToString(SatDBID) + " and ComponentNumber = " + Conversions.ToString(OrbitNumber);
				dataTable = CachedDataBase.GetDataTable(db, string_);
				dataRow = dataTable.Rows[0];
				theSatellite.Name = dataRow["MissonName"].ToString();
				if (dataTable.Columns.Contains("TLE") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TLE"])))
				{
					string[] string_2 = Conversions.ToString(dataRow["TLE"]).Split(Conversions.ToCharArrayRankOne(Environment.NewLine)).Where(DBFunctions.stringFunc3).ToArray<string>();
					theSatellite.GetSatelliteKinematics().method_20(string_2);
				}
				else
				{
					theSatellite.GetSatelliteKinematics().method_19(Conversions.ToSingle(dataRow["Inclination"]), Conversions.ToLong(dataRow["Apogee"]) * 1000L, Conversions.ToLong(dataRow["Perigee"]) * 1000L);
				}
				theSatellite.LaunchDate = Conversions.ToDate(dataRow["LaunchDate"]);
				theSatellite.DeOrbitingDate = Conversions.ToDate(dataRow["DeOrbitingDate"]);
			}
			if (LoadComponents)
			{
				DBFunctions.LoadPlatformSensorsData(theSatellite, SatDBID);
				DBFunctions.LoadPlatformCommStuffData(theSatellite, SatDBID);
				ActiveUnit activeUnit = theSatellite;
				DBFunctions.LoadPlatformMountsData(ref theScen, ref activeUnit, SatDBID);
			}
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x0030AAD8 File Offset: 0x00308CD8
		public static void LoadAircraftFacilitiesData(ref Platform class174_0, int int_0)
		{
			string str = "";
			SQLiteDataBase db = new SQLiteDataBase(class174_0.m_Scenario.GetSQLiteConnection());
			string left = class174_0.GetType().ToString();
			if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Command_Core.Facility", false) != 0)
				{
					if (Operators.CompareString(left, "Command_Core.Submarine", false) == 0)
					{
						str = "DataSubmarineAircraftFacilities";
					}
				}
				else
				{
					str = "DataFacilityAircraftFacilities";
				}
			}
			else
			{
				str = "DataShipAircraftFacilities";
			}
			string string_ = "select * from " + str + " where id = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int facilityDBID = Conversions.ToInteger(dataTable.Rows[i]["ComponentID"]);
				SQLiteConnection sQLiteConnection = class174_0.m_Scenario.GetSQLiteConnection();
				AirFacility airFacility_ = DBFunctions.LoadAircraftFacilityDataTable(facilityDBID, ref sQLiteConnection, class174_0);
				class174_0.AddAirFacility(airFacility_);
			}
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x0030ABE0 File Offset: 0x00308DE0
		public static void LoadDockingFacilitiesData(ref Platform class174_0, int int_0)
		{
			string str = "";
			SQLiteDataBase db = new SQLiteDataBase(class174_0.m_Scenario.GetSQLiteConnection());
			string left = class174_0.GetType().ToString();
			if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Command_Core.Submarine", false) != 0)
				{
					if (Operators.CompareString(left, "Command_Core.Facility", false) == 0)
					{
						str = "DataFacilityDockingFacilities";
					}
				}
				else
				{
					str = "DataSubmarineDockingFacilities";
				}
			}
			else
			{
				str = "DataShipDockingFacilities";
			}
			string string_ = "select * from " + str + " where id = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int facilityDBID = Conversions.ToInteger(dataTable.Rows[i]["ComponentID"]);
				SQLiteConnection sQLiteConnection = class174_0.m_Scenario.GetSQLiteConnection();
				DockFacility dockFacility_ = DBFunctions.LoadDockingFacilityDataTable(facilityDBID, ref sQLiteConnection, class174_0);
				class174_0.AddDockFacility(dockFacility_);
			}
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x0030ACE8 File Offset: 0x00308EE8
		public static AirFacility LoadAircraftFacilityDataTable(int FacilityDBID, ref SQLiteConnection theDBConn, ActiveUnit theParent = null)
		{
			SQLiteDataBase db = new SQLiteDataBase(theDBConn);
			string string_ = "Select * from DataAircraftFacility where ID = " + Conversions.ToString(FacilityDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			int arg_45_0 = dataTable.Rows.Count;
			DataRow dataRow = dataTable.Rows[0];
			string text = CachedDataBase.ExecuteScalar(db, "Select Description from EnumAircraftFacilityType where ID = " + dataRow["Type"].ToString());
			string text2 = CachedDataBase.ExecuteScalar(db, "Select Description from EnumAircraftFacilityPhysicalSize where ID = " + dataRow["PhysicalSize"].ToString());
			int num = Conversions.ToInteger(dataRow["PhysicalSize"]);
			GlobalVariables.AircraftSizeClass int_ = GlobalVariables.AircraftSizeClass.None;
			if (num != 1001)
			{
				switch (num)
				{
				case 2001:
					int_ = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 2002:
					int_ = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 2003:
					int_ = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 2004:
					int_ = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					break;
				}
			}
			else
			{
				int_ = GlobalVariables.AircraftSizeClass.None;
			}
			return new AirFacility(theParent, string.Concat(new string[]
			{
				text,
				" (",
				dataRow["capacity"].ToString(),
				"x ",
				text2,
				")"
			}), (AirFacility._AirFacilityType)Conversions.ToShort(dataRow["Type"]), (int)int_, Conversions.ToInteger(dataRow["Capacity"]), (GlobalVariables._RunwayLengthCode)Conversions.ToInteger(dataRow["RunwayLength"]))
			{
				DBID = FacilityDBID
			};
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x0030AE88 File Offset: 0x00309088
		public static DockFacility LoadDockingFacilityDataTable(int FacilityDBID, ref SQLiteConnection theDBConn, ActiveUnit theParent = null)
		{
			SQLiteDataBase db = new SQLiteDataBase(theDBConn);
			string string_ = "Select * from DataDockingFacility where ID = " + Conversions.ToString(FacilityDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			int arg_45_0 = dataTable.Rows.Count;
			DataRow dataRow = dataTable.Rows[0];
			string text = CachedDataBase.ExecuteScalar(db, "Select Description from EnumDockingFacilityType where ID = " + dataRow["Type"].ToString());
			string text2 = CachedDataBase.ExecuteScalar(db, "Select Description from EnumDockingFacilityPhysicalSize where ID = " + dataRow["PhysicalSize"].ToString());
			DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode_ = (DockFacility._DockFacilityPhysicalSizeCode)Conversions.ToShort(dataRow["PhysicalSize"]);
			return new DockFacility(theParent, string.Concat(new string[]
			{
				text,
				" (",
				dataRow["capacity"].ToString(),
				"x ",
				text2,
				")"
			}), (DockFacility._DockFacilityType)Conversions.ToShort(dataRow["Type"]), physicalSizeCode_, Conversions.ToByte(dataRow["Capacity"]))
			{
				DBID = FacilityDBID
			};
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x0030AFC0 File Offset: 0x003091C0
		public static int GetCommID(string strCommName, ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "Select ID from DataComm where Name = '" + strCommName + "'";
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x0030AFF4 File Offset: 0x003091F4
		public static void LoadPlatformMagazinesData(ref Platform class174_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(class174_0.m_Scenario.GetSQLiteConnection());
			string left = class174_0.GetType().ToString();
			string text = "";
			if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Command_Core.Facility", false) != 0)
				{
					if (Operators.CompareString(left, "Command_Core.Submarine", false) == 0)
					{
						text = "DataSubmarineMagazines";
					}
				}
				else
				{
					text = "DataFacilityMagazines";
				}
			}
			else
			{
				text = "DataShipMagazines";
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT theTable.* FROM ",
				text,
				" as theTable, DataMagazine WHERE theTable.ComponentID = DataMagazine.ID And theTable.ID = ",
				Conversions.ToString(int_0),
				" ORDER BY DataMagazine.Name ASC"
			});
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Magazine magazine = DBFunctions.GetMagazine(Conversions.ToInteger(dataTable.Rows[i]["ComponentID"]), ref class174_0.m_Scenario, true);
				ScenarioArrayUtil.AddMagazine(ref class174_0.m_Magazines, magazine);
				magazine.SetParentPlatform(class174_0);
			}
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0030B11C File Offset: 0x0030931C
		public static int GetMagazineData(string strMagazineName, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID from DataMagazine where Name='" + Misc.smethod_11(strMagazineName) + "'";
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x0030B154 File Offset: 0x00309354
		public static Magazine GetMagazine(int MagazineDBID, ref Scenario theScen, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select * From DataMagazine where ID = " + Conversions.ToString(MagazineDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			DataRow dataRow = dataTable.Rows[0];
			Magazine magazine = new Magazine(null, Conversions.ToInteger(dataRow["ID"]), Conversions.ToString(dataRow["Name"]), (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Capacity"]), Conversions.ToBoolean(dataRow["AviationMagazine"]));
			try
			{
				magazine.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200478", ex2.Message);
				GameGeneral.LogException(ref ex2);
				bool arg_FE_0 = Debugger.IsAttached;
				ProjectData.ClearProjectError();
			}
			if (LoadComponents)
			{
				DBFunctions.smethod_81(ref magazine, ref theScen);
			}
			return magazine;
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x0030B28C File Offset: 0x0030948C
		private static void smethod_81(ref Magazine magazine_0, ref Scenario scenario_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "SELECT DataWeaponRecord.* FROM DataMagazineWeapons, DataWeaponRecord, DataWeapon WHERE DataMagazineWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataMagazineWeapons.ID = " + Conversions.ToString(magazine_0.DBID) + " ORDER BY DataWeapon.Name ASC";
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				WeaponRec weaponRec = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
				weaponRec.SetTimeToFire();
				magazine_0.GetWeaponRecCollection().Add(weaponRec);
			}
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x0030B378 File Offset: 0x00309578
		public static void LoadPlatformPropulsionData(ActiveUnit activeUnit_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(activeUnit_0.m_Scenario.GetSQLiteConnection());
			string str = "";
			switch (activeUnit_0.GetUnitType())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				str = "DataAircraftPropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				str = "DataShipPropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				str = "DataSubmarinePropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				str = "DataFacilityPropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				str = "DataWeaponPropulsion";
				break;
			}
			string string_ = "Select DataPropulsion.* from DataPropulsion, " + str + " as theTable where DataPropulsion.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int count = dataTable.Rows.Count;
			if (activeUnit_0.IsAircraft)
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int int_ = Conversions.ToInteger(dataRow["ID"].ToString());
						string text = dataRow["Name"].ToString();
						if (text.Split(Conversions.ToCharArrayRankOne(" ")).ToArray<string>().Length > 1 && text.Split(Conversions.ToCharArrayRankOne(" ")).ToList<string>()[0].EndsWith("x"))
						{
							string text2 = text.Split(Conversions.ToCharArrayRankOne(" ")).ToList<string>()[0];
							text = text.Substring(text2.Length + 1);
						}
						if (dataTable.Columns.Contains("NumberOfEngines"))
						{
							int num = Conversions.ToInteger(dataRow["NumberOfEngines"]);
							for (int i = 1; i <= num; i++)
							{
								Engine engine = DBFunctions.LoadPropulsionData(Conversions.ToInteger(dataRow["ID"].ToString()), ref activeUnit_0);
								engine.Name = text + " #" + Conversions.ToString(i);
								activeUnit_0.GetEngines().Add(engine);
							}
						}
						else if (text.Split(Conversions.ToCharArrayRankOne(" ")).ToArray<string>().Length > 1 && text.Split(Conversions.ToCharArrayRankOne(" ")).ToList<string>()[0].EndsWith("x"))
						{
							string text3 = text.Split(Conversions.ToCharArrayRankOne(" ")).ToList<string>()[0];
							int num2 = Conversions.ToInteger(text3.Substring(0, text3.Length - 1));
							for (int j = 1; j <= num2; j++)
							{
								Engine engine = DBFunctions.LoadPropulsionData(int_, ref activeUnit_0);
								engine.Name = text + " #" + Conversions.ToString(j);
								activeUnit_0.GetEngines().Add(engine);
							}
						}
						else
						{
							int num3 = count - 1;
							for (int k = 0; k <= num3; k++)
							{
								dataRow = dataTable.Rows[k];
								Engine engine = DBFunctions.LoadPropulsionData(int_, ref activeUnit_0);
								activeUnit_0.GetEngines().Add(engine);
							}
						}
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			int num4 = count - 1;
			for (int l = 0; l <= num4; l++)
			{
				DataRow dataRow = dataTable.Rows[l];
				Engine engine = DBFunctions.LoadPropulsionData(Conversions.ToInteger(dataRow["ID"].ToString()), ref activeUnit_0);
				activeUnit_0.GetEngines().Add(engine);
			}
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x0030B728 File Offset: 0x00309928
		public static void LoadPlatformCommStuffData(ActiveUnit activeUnit_0, int int_0)
		{
			string str = "";
			SQLiteDataBase db = new SQLiteDataBase(activeUnit_0.m_Scenario.GetSQLiteConnection());
			if (activeUnit_0.IsAircraft)
			{
				str = "DataAircraftComms";
			}
			else if (activeUnit_0.IsWeapon)
			{
				str = "DataWeaponComms";
			}
			else if (activeUnit_0.IsShip)
			{
				str = "DataShipComms";
			}
			else if (activeUnit_0.IsSubmarine)
			{
				str = "DataSubmarineComms";
			}
			else if (activeUnit_0.IsFacility)
			{
				str = "DataFacilityComms";
			}
			else if (activeUnit_0.IsSatellite())
			{
				str = "DataSatelliteComms";
			}
			string string_ = "Select DataComm.ID as CommID, theTable.* from DataComm, " + str + " as theTable where DataComm.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				CommDevice commDevice = DBFunctions.LoadCommData(Conversions.ToInteger(dataRow["CommID"]), ref activeUnit_0);
				if (dataTable.Columns.Contains("ParentSpecific"))
				{
					commDevice.ParentSpecific = Conversions.ToBoolean(dataRow["ParentSpecific"]);
				}
				if (activeUnit_0.IsWeapon && ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Sonobuoy)
				{
					commDevice.ParentSpecific = false;
				}
				activeUnit_0.AddCommDevice(commDevice);
			}
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x0030B890 File Offset: 0x00309A90
		public static void LoadWeaponWarheadsData(ref Warhead[] warhead_0, ref Weapon weapon_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(weapon_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select ComponentID, ComponentNumber from DataWeaponWarheads where ID=" + Conversions.ToString(weapon_0.DBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Warhead warhead_ = DBFunctions.LoadWarheadData(weapon_0.m_Scenario, Conversions.ToInteger(dataRow["ComponentID"]));
				ScenarioArrayUtil.AddWarhead(ref warhead_0, warhead_);
			}
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x0030B928 File Offset: 0x00309B28
		public static Warhead LoadWarheadData(Scenario scenario_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "Select DataWarhead.* from DataWarhead Where ID=" + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			Warhead warhead = null;
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataRow dataRow = dataTable.Rows[num2];
				short clusterBombDispersionAreaLength = 0;
				short clusterBombDispersionAreaWidth = 0;
				if (dataTable.Columns.Contains("ClusterBombDispersionAreaLength"))
				{
					clusterBombDispersionAreaLength = Conversions.ToShort(dataRow["ClusterBombDispersionAreaLength"]);
				}
				if (dataTable.Columns.Contains("ClusterBombDispersionAreaWidth"))
				{
					clusterBombDispersionAreaWidth = Conversions.ToShort(dataRow["ClusterBombDispersionAreaWidth"]);
				}
				warhead = new Warhead(Conversions.ToString(dataRow["Name"]), (float)Conversions.ToDouble(dataRow["DamagePoints"]), (Warhead.WarheadType)Conversions.ToInteger(dataRow["Type"]), (Warhead._ExplosivesType)Conversions.ToShort(dataRow["ExplosivesType"]), (Warhead.WarheadCaliber)Conversions.ToShort(dataRow["ProjectileCaliber"]), dataRow["NumberOfWarheads"].ToString());
				warhead.DBID = int_0;
				warhead.ClusterBombDispersionAreaLength = clusterBombDispersionAreaLength;
				warhead.ClusterBombDispersionAreaWidth = clusterBombDispersionAreaWidth;
				try
				{
					warhead.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200479", ex2.Message);
					GameGeneral.LogException(ref ex2);
					bool arg_17E_0 = Debugger.IsAttached;
					ProjectData.ClearProjectError();
				}
			}
			return warhead;
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x0030BADC File Offset: 0x00309CDC
		public static void LoadESMData(ref Sensor sensor_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "Select * from DataSensor where ID = " + Conversions.ToString(sensor_0.DBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				sensor_0.ESMSensitivity = Conversions.ToSingle(dataRow["ESMSensitivity"]);
				sensor_0.ESMSystemLoss = Conversions.ToSingle(dataRow["ESMSystemLoss"]);
				sensor_0.ESMNumberOfChannels = Conversions.ToShort(dataRow["ESMNumberOfChannels"]);
				sensor_0.ESMPreciseEmitterID = Conversions.ToBoolean(dataRow["ESMPreciseEmitterID"]);
			}
		}

		// 载入通信设备性能参数
		public static void LoadCommCapabilitiesData(ref CommDevice commDevice_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "Select CodeID from DataCommCapabilities where ID = " + Conversions.ToString(commDevice_0.DBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 1300)
				{
					if (num2 != 1200)
					{
						if (num2 != 1201)
						{
							if (num2 != 1300)
							{
								goto IL_118;
							}
							commDevice_0.commCapability.LOS_Limited = true;
						}
						else
						{
							commDevice_0.commCapability.Receive_Only = true;
						}
					}
					else
					{
						commDevice_0.commCapability.Send_Only = true;
					}
				}
				else if (num2 != 1401)
				{
					if (num2 != 1402)
					{
						switch (num2)
						{
						case 3001:
							commDevice_0.commCapability.ELFRadio = true;
							goto IL_1FC;
						case 3002:
							commDevice_0.commCapability.SLFRadio = true;
							goto IL_1FC;
						case 3003:
							commDevice_0.commCapability.VLFRadio = true;
							goto IL_1FC;
						case 3004:
							commDevice_0.commCapability.ULFRadio = true;
							goto IL_1FC;
						case 3005:
							commDevice_0.commCapability.LFRadio = true;
							goto IL_1FC;
						case 3006:
							commDevice_0.commCapability.MFRadio = true;
							goto IL_1FC;
						case 3007:
							commDevice_0.commCapability.HFRadio = true;
							goto IL_1FC;
						case 3008:
							commDevice_0.commCapability.VHFRadio = true;
							goto IL_1FC;
						case 3009:
							commDevice_0.commCapability.UHFRadio = true;
							goto IL_1FC;
						case 3010:
							commDevice_0.commCapability.SHFRadio = true;
							goto IL_1FC;
						case 3011:
							commDevice_0.commCapability.EHFRadio = true;
							goto IL_1FC;
						}
						goto IL_118;
					}
					commDevice_0.commCapability.Broadcast = true;
				}
				else
				{
					commDevice_0.commCapability.Secure = true;
				}
				IL_1FC:
				i++;
				continue;
				IL_118:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_1FC;
				}
				goto IL_1FC;
			}
		}

		// 载入雷达数据
		public static void LoadRadarData(ref Sensor sensor_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "Select * from DataSensor where ID = " + Conversions.ToString(sensor_0.DBID);
			DataRow dataRow = CachedDataBase.GetDataTable(db, string_).Rows[0];
			sensor_0.RadarHorizontalBeamwidth = Conversions.ToSingle(dataRow["RadarHorizontalBeamwidth"]);
			sensor_0.RadarVerticalBeamwidth = Conversions.ToSingle(dataRow["RadarVerticalBeamwidth"]);
			sensor_0.RadarSystemNoiseLevel = Conversions.ToSingle(dataRow["RadarSystemNoiseLevel"]);
			sensor_0.RadarProcessingGainLoss = Conversions.ToSingle(dataRow["RadarProcessingGainLoss"]);
			sensor_0.RadarPeakPower = Conversions.ToSingle(dataRow["RadarPeakPower"]);
			sensor_0.RadarPulseWidth = Conversions.ToSingle(dataRow["RadarPulseWidth"]);
			sensor_0.RadarBlindTime = Conversions.ToSingle(dataRow["RadarBlindTime"]);
			sensor_0.RadarPRF = Conversions.ToSingle(dataRow["RadarPRF"]);
			sensor_0.RadarHorizontalBeamwidthIlluminate = Conversions.ToSingle(dataRow["RadarHorizontalBeamwidthIlluminate"]);
			sensor_0.RadarVerticalBeamwidthIlluminate = Conversions.ToSingle(dataRow["RadarVerticalBeamwidthIlluminate"]);
			sensor_0.RadarSystemNoiseLevelIlluminate = Conversions.ToSingle(dataRow["RadarSystemNoiseLevelIlluminate"]);
			sensor_0.RadarProcessingGainLossIlluminate = Conversions.ToSingle(dataRow["RadarProcessingGainLossIlluminate"]);
			sensor_0.RadarPeakPowerIlluminate = Conversions.ToSingle(dataRow["RadarPeakPowerIlluminate"]);
			sensor_0.RadarPulseWidthIlluminate = Conversions.ToSingle(dataRow["RadarPulseWidthIlluminate"]);
			sensor_0.RadarBlindTimeIlluminate = Conversions.ToSingle(dataRow["RadarBlindTimeIlluminate"]);
			sensor_0.RadarPRFIlluminate = Conversions.ToSingle(dataRow["RadarPRFIlluminate"]);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x0030BF70 File Offset: 0x0030A170
		public static Engine LoadPropulsionData(int int_0, ref ActiveUnit activeUnit_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(activeUnit_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select DataPropulsion.* from DataPropulsion where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			Engine engine = null;
			Dictionary<int, AltBand> dictionary = new Dictionary<int, AltBand>();
			int num = dataTable.Rows.Count - 1;
			int num2 = 0;
			while (num2 <= num)
			{
				DataRow dataRow = dataTable.Rows[num2];
				engine = new Engine(activeUnit_0, Conversions.ToInteger(dataRow["ID"]), Conversions.ToString(dataRow["Name"]), (Engine._PropulsionType)Conversions.ToShort(dataRow["Type"]));
				engine.SetParentPlatform(activeUnit_0);
				try
				{
					engine.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
					goto IL_2F5;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200480", ex2.Message);
					GameGeneral.LogException(ref ex2);
					bool arg_10C_0 = Debugger.IsAttached;
					ProjectData.ClearProjectError();
					goto IL_2F5;
				}
				IL_11F:
				DataTable dataTable2;
				int num3 = dataTable2.Rows.Count - 1;
				bool flag = false;
				for (int i = 0; i <= num3; i++)
				{
					DataRow dataRow2 = dataTable2.Rows[i];
					int key;
					if (flag)
					{
						key = Conversions.ToInteger(dataRow2["Band"]);
					}
					else
					{
						key = Conversions.ToInteger(dataRow2["AltitudeBand"]);
					}
					AltBand altBand;
					if (dictionary.ContainsKey(key))
					{
						altBand = dictionary[key];
					}
					else
					{
						altBand = new AltBand(Conversions.ToSingle(dataRow2["AltitudeMax"]), Conversions.ToSingle(dataRow2["AltitudeMin"]));
						dictionary.Add(key, altBand);
					}
					switch (Conversions.ToByte(dataRow2["Throttle"]))
					{
					case 1:
						altBand.Consumption_Loiter = Conversions.ToSingle(dataRow2["Consumption"]);
						altBand.Speed_Loiter = Conversions.ToInteger(dataRow2["Speed"]);
						break;
					case 2:
						altBand.Consumption_Cruise = Conversions.ToSingle(dataRow2["Consumption"]);
						altBand.Speed_Cruise = Conversions.ToInteger(dataRow2["Speed"]);
						break;
					case 3:
						altBand.Consumption_Full = new float?(Conversions.ToSingle(Conversions.ToString(dataRow2["Consumption"])));
						altBand.Speed_Full = (long?)dataRow2["Speed"];
						break;
					case 4:
						altBand.Consumption_Flank = new float?(Conversions.ToSingle(Conversions.ToString(dataRow2["Consumption"])));
						altBand.Speed_Flank = (long?)dataRow2["Speed"];
						break;
					}
				}
				num2++;
				continue;
				IL_117:
				goto IL_11F;
				IL_2F5:
				string_ = "Select * from DataPropulsionPerformance as tPAS where tPAS.ID = " + Conversions.ToString(int_0);
				dataTable2 = CachedDataBase.GetDataTable(db, string_);
				if (dataTable2.Columns.Contains("AltitudeBand"))
				{
					goto IL_117;
				}
				goto IL_11F;
			}
			engine.altBands = dictionary.Values.ToArray<AltBand>();
			return engine;
		}

		// 载入通信设备数据
		public static CommDevice LoadCommData(int int_0, ref ActiveUnit activeUnit_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(activeUnit_0.m_Scenario.GetSQLiteConnection());
			string string_ = "Select * from DataComm where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			CommDevice commDevice = null;
			int num = dataTable.Rows.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataRow dataRow = dataTable.Rows[num2];
				commDevice = new CommDevice(activeUnit_0, activeUnit_0.m_Scenario, Conversions.ToInteger(dataRow["ID"]), Conversions.ToString(dataRow["Name"]), (CommDevice.CommLinkType)Conversions.ToInteger(dataRow["Type"]), Conversions.ToDouble(dataRow["Range"]), Conversions.ToInteger(dataRow["Channels"]), Conversions.ToBoolean(dataRow["IsOptional"]));
				commDevice.DBID = int_0;
				try
				{
					commDevice.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200481", ex2.Message);
					GameGeneral.LogException(ref ex2);
					bool arg_13B_0 = Debugger.IsAttached;
					ProjectData.ClearProjectError();
				}
			}
			DBFunctions.smethod_97(ref commDevice, activeUnit_0.m_Scenario.GetSQLiteConnection());
			return commDevice;
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x0030C458 File Offset: 0x0030A658
		public static string GetSensorName(int ID, ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT Name from DataSensor where ID='" + Conversions.ToString(ID) + "'";
			return CachedDataBase.ExecuteScalar(db, string_);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x0030C48C File Offset: 0x0030A68C
		public static Sensor LoadSensorData(int DBID, ref SQLiteConnection sqliteConnection_)
		{
			Sensor result;
			if (DBID == 0)
			{
				result = Sensor.GetMk1Eyeball(sqliteConnection_);
			}
			else
			{
				SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_);
				string string_ = "Select DataSensor.*, EnumSensorRole.Description from DataSensor, EnumSensorRole where EnumSensorRole.ID = DataSensor.Role and DataSensor.ID = " + Conversions.ToString(DBID);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				if (dataTable.Rows.Count == 0)
				{
					throw new Exception0("No valid sensor with ID #" + Conversions.ToString(DBID) + " ! Please pester the DB author to fix this!");
				}
				Sensor sensor = null;
				int num = dataTable.Rows.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					DataRow dataRow = dataTable.Rows[num2];
					int sensorDBID = Conversions.ToInteger(dataRow["ID"]);
					string theName = Conversions.ToString(dataRow["Name"]);
					float theVisualDetectZoom = Conversions.ToSingle(dataRow["VisualDetectionZoomLevel"]);
					float theVisualClassZoom = Conversions.ToSingle(dataRow["VisualClassificationZoomLevel"]);
					float theIRDetectZoom = Conversions.ToSingle(dataRow["IRDetectionZoomLevel"]);
					float theIRClassZoom = Conversions.ToSingle(dataRow["IRClassificationZoomLevel"]);
					Sensor.SensorType theSensorType = (Sensor.SensorType)Conversions.ToShort(dataRow["Type"]);
					Sensor._SensorRole theSensorRole = (Sensor._SensorRole)Conversions.ToLong(dataRow["Role"]);
					GlobalVariables.TechGenerationClass theGeneration = (GlobalVariables.TechGenerationClass)Conversions.ToInteger(dataRow["Generation"]);
					float theMaxRange = Conversions.ToSingle(dataRow["RangeMax"]);
					float theMinRange = Conversions.ToSingle(dataRow["RangeMin"]);
					short theMineSweepWidth = 0;
					if (dataTable.Columns.Contains("MineSweepWidth"))
					{
						theMineSweepWidth = Conversions.ToShort(dataRow["MineSweepWidth"]);
					}
					short theMineMaxSpeed = 0;
					if (dataTable.Columns.Contains("MineSweepMaximumSpeed"))
					{
						theMineMaxSpeed = Conversions.ToShort(dataRow["MineSweepMaximumSpeed"]);
					}
					int theMaxIntercept = Conversions.ToInteger(dataRow["MaxContactsIlluminate"]);
					float theMaxAltitude = (float)Conversions.ToInteger(dataRow["AltitudeMax"]);
					float theMinAltitude = (float)Conversions.ToInteger(dataRow["AltitudeMin"]);
					float theMaxAltitude_ASL = 0f;
					if (dataTable.Columns.Contains("AltitudeMax_ASL"))
					{
						theMaxAltitude_ASL = (float)Conversions.ToInteger(dataRow["AltitudeMax_ASL"]);
					}
					float theMinAltitude_ASL = 0f;
					if (dataTable.Columns.Contains("AltitudeMin_ASL"))
					{
						theMinAltitude_ASL = (float)Conversions.ToInteger(dataRow["AltitudeMin_ASL"]);
					}
					int theScanInterval = Conversions.ToInteger(dataRow["ScanInterval"]);
					float theRangeResolution = Conversions.ToSingle(dataRow["ResolutionRange"]);
					float theHeightResolution = Conversions.ToSingle(dataRow["ResolutionHeight"]);
					float theAngleResolution = Conversions.ToSingle(dataRow["ResolutionAngle"]);
					short theMasqueradeAs = Conversions.ToShort(dataRow["MasqueradeAs"]);
					short theMaxContactsAir = Conversions.ToShort(dataRow["MaxContactsAir"]);
					short theMaxContactsSurface = Conversions.ToShort(dataRow["MaxContactsSurface"]);
					short theMaxContactsSub = Conversions.ToShort(dataRow["MaxContactsSubmarine"]);
					float theAvailability = Conversions.ToSingle(dataRow["Availability"]);
					long theUpperFreq = Conversions.ToLong(dataRow["FrequencyUpper"]);
					long theLowerFreq = Conversions.ToLong(dataRow["FrequencyLower"]);
					long theUpperFreqIlluminate = Conversions.ToLong(dataRow["FrequencyUpperIlluminate"]);
					long theLowerFreqIlluminate = Conversions.ToLong(dataRow["FrequencyLowerIlluminate"]);
					float theECMGain = Conversions.ToSingle(dataRow["ECMGain"]);
					float theECMPeakPower = Conversions.ToSingle(dataRow["ECMPeakPower"]);
					float theECMPokReduction = Conversions.ToSingle(dataRow["ECMPokReduction"]);
					float theECMBandwidth = Conversions.ToSingle(dataRow["ECMBandwidth"]);
					float theECMNumberofTargets = Conversions.ToSingle(dataRow["ECMNumberOfTargets"]);
					float dFAccuracy = Conversions.ToSingle(dataRow["DirectionFindingAccuracy"]);
					bool isHypothetical = false;
					try
					{
						isHypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200482", ex2.Message);
						GameGeneral.LogException(ref ex2);
						bool arg_40B_0 = Debugger.IsAttached;
						ProjectData.ClearProjectError();
					}
					sensor = new Sensor(ref sqliteConnection_, sensorDBID, theName, theSensorType, theSensorRole, theGeneration, theMaxRange, theMinRange, 0, 0, 0, theMaxIntercept, theMaxAltitude, theMinAltitude, theMaxAltitude_ASL, theMinAltitude_ASL, theScanInterval, theRangeResolution, theAngleResolution, theHeightResolution, false, theMasqueradeAs, theMaxContactsAir, theMaxContactsSurface, theMaxContactsSub, theAvailability, theUpperFreq, theLowerFreq, theUpperFreqIlluminate, theLowerFreqIlluminate, theECMGain, theECMPeakPower, theECMBandwidth, theECMNumberofTargets, theECMPokReduction, dFAccuracy, theMineSweepWidth, theMineMaxSpeed, theVisualDetectZoom, theVisualClassZoom, theIRDetectZoom, theIRClassZoom, isHypothetical);
					sensor.Description = Conversions.ToString(dataRow["Description"]);
					DBFunctions.smethod_93(ref sensor, sqliteConnection_);
				}
				result = sensor;
			}
			return result;
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x0030C948 File Offset: 0x0030AB48
		public static void smethod_93(ref Sensor sensor_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(sqliteConnection_0);
			if (sQLiteDataBase.method_6("MiscSensorDefault"))
			{
				string string_ = "Select * from MiscSensorDefault WHERE ID = " + Conversions.ToString(sensor_0.DBID);
				DataTable dataTable = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
				if (dataTable.Rows.Count > 0)
				{
					DataRow dataRow = dataTable.Rows[0];
					Sensor sensor = sensor_0;
					sensor.coverageArc.PB1 = Conversions.ToBoolean(dataRow["PB1"]);
					sensor.coverageArc.PB2 = Conversions.ToBoolean(dataRow["PB2"]);
					sensor.coverageArc.PMF1 = Conversions.ToBoolean(dataRow["PMF1"]);
					sensor.coverageArc.PMF2 = Conversions.ToBoolean(dataRow["PMF2"]);
					sensor.coverageArc.PMA1 = Conversions.ToBoolean(dataRow["PMA1"]);
					sensor.coverageArc.PMA2 = Conversions.ToBoolean(dataRow["PMA2"]);
					sensor.coverageArc.PS1 = Conversions.ToBoolean(dataRow["PS1"]);
					sensor.coverageArc.PS2 = Conversions.ToBoolean(dataRow["PS2"]);
					sensor.coverageArc.SB1 = Conversions.ToBoolean(dataRow["SB1"]);
					sensor.coverageArc.SB2 = Conversions.ToBoolean(dataRow["SB2"]);
					sensor.coverageArc.SMF1 = Conversions.ToBoolean(dataRow["SMF1"]);
					sensor.coverageArc.SMF2 = Conversions.ToBoolean(dataRow["SMF2"]);
					sensor.coverageArc.SMA1 = Conversions.ToBoolean(dataRow["SMA1"]);
					sensor.coverageArc.SMA2 = Conversions.ToBoolean(dataRow["SMA2"]);
					sensor.coverageArc.SS1 = Conversions.ToBoolean(dataRow["SS1"]);
					sensor.coverageArc.SS2 = Conversions.ToBoolean(dataRow["SS2"]);
					sensor.coverageArcMax.PB1 = Conversions.ToBoolean(dataRow["PB1Max"]);
					sensor.coverageArcMax.PB2 = Conversions.ToBoolean(dataRow["PB2Max"]);
					sensor.coverageArcMax.PMF1 = Conversions.ToBoolean(dataRow["PMF1Max"]);
					sensor.coverageArcMax.PMF2 = Conversions.ToBoolean(dataRow["PMF2Max"]);
					sensor.coverageArcMax.PMA1 = Conversions.ToBoolean(dataRow["PMA1Max"]);
					sensor.coverageArcMax.PMA2 = Conversions.ToBoolean(dataRow["PMA2Max"]);
					sensor.coverageArcMax.PS1 = Conversions.ToBoolean(dataRow["PS1Max"]);
					sensor.coverageArcMax.PS2 = Conversions.ToBoolean(dataRow["PS2Max"]);
					sensor.coverageArcMax.SB1 = Conversions.ToBoolean(dataRow["SB1Max"]);
					sensor.coverageArcMax.SB2 = Conversions.ToBoolean(dataRow["SB2Max"]);
					sensor.coverageArcMax.SMF1 = Conversions.ToBoolean(dataRow["SMF1Max"]);
					sensor.coverageArcMax.SMF2 = Conversions.ToBoolean(dataRow["SMF2Max"]);
					sensor.coverageArcMax.SMA1 = Conversions.ToBoolean(dataRow["SMA1Max"]);
					sensor.coverageArcMax.SMA2 = Conversions.ToBoolean(dataRow["SMA2Max"]);
					sensor.coverageArcMax.SS1 = Conversions.ToBoolean(dataRow["SS1Max"]);
					sensor.coverageArcMax.SS2 = Conversions.ToBoolean(dataRow["SS2Max"]);
				}
			}
			else
			{
				Sensor sensor = sensor_0;
				sensor.coverageArc.PB1 = true;
				sensor.coverageArc.PB2 = true;
				sensor.coverageArc.PMF1 = true;
				sensor.coverageArc.PMF2 = true;
				sensor.coverageArc.PMA1 = true;
				sensor.coverageArc.PMA2 = true;
				sensor.coverageArc.PS1 = true;
				sensor.coverageArc.PS2 = true;
				sensor.coverageArc.SB1 = true;
				sensor.coverageArc.SB2 = true;
				sensor.coverageArc.SMF1 = true;
				sensor.coverageArc.SMF2 = true;
				sensor.coverageArc.SMA1 = true;
				sensor.coverageArc.SMA2 = true;
				sensor.coverageArc.SS1 = true;
				sensor.coverageArc.SS2 = true;
				sensor.coverageArcMax.PB1 = true;
				sensor.coverageArcMax.PB2 = true;
				sensor.coverageArcMax.PMF1 = true;
				sensor.coverageArcMax.PMF2 = true;
				sensor.coverageArcMax.PMA1 = true;
				sensor.coverageArcMax.PMA2 = true;
				sensor.coverageArcMax.PS1 = true;
				sensor.coverageArcMax.PS2 = true;
				sensor.coverageArcMax.SB1 = true;
				sensor.coverageArcMax.SB2 = true;
				sensor.coverageArcMax.SMF1 = true;
				sensor.coverageArcMax.SMF2 = true;
				sensor.coverageArcMax.SMA1 = true;
				sensor.coverageArcMax.SMA2 = true;
				sensor.coverageArcMax.SS1 = true;
				sensor.coverageArcMax.SS2 = true;
			}
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x0030CEE0 File Offset: 0x0030B0E0
		public static void LoadPlatformSensorsData(ActiveUnit activeUnit_0, int int_0)
		{
			string text = "";
			SQLiteDataBase db = new SQLiteDataBase(activeUnit_0.m_Scenario.GetSQLiteConnection());
			if (activeUnit_0.IsAircraft)
			{
				text = "DataAircraftSensors";
			}
			else if (activeUnit_0.IsWeapon)
			{
				text = "DataWeaponSensors";
			}
			else if (activeUnit_0.IsShip)
			{
				text = "DataShipSensors";
			}
			else if (activeUnit_0.IsSubmarine)
			{
				text = "DataSubmarineSensors";
			}
			else if (activeUnit_0.IsFacility)
			{
				text = "DataFacilitySensors";
			}
			else if (activeUnit_0.IsSatellite())
			{
				text = "DataSatelliteSensors";
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT DataSensor.ID AS SensorID, DataSensor.Type AS SensorType, theTable.* FROM DataSensor, ",
				text,
				" AS theTable WHERE DataSensor.ID = theTable.ComponentID And theTable.ID = ",
				Conversions.ToString(int_0),
				" ORDER BY DataSensor.Type, DataSensor.Name ASC"
			});
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			Operators.CompareString(text, "DataWeaponSensors", false);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				DataRow dataRow = dataTable.Rows[i];
				int dBID = Conversions.ToInteger(dataRow["SensorID"]);
				SQLiteConnection sQLiteConnection = activeUnit_0.m_Scenario.GetSQLiteConnection();
				Sensor sensor = DBFunctions.LoadSensorData(dBID, ref sQLiteConnection);
				if (sensor.sensorType == Sensor.SensorType.SensorGroup)
				{
					string_ = "Select ComponentID from DataSensorSensorGroups where ID = " + Conversions.ToString(sensor.DBID);
					DataTable dataTable2 = CachedDataBase.GetDataTable(db, string_);
					IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int dBID2 = Conversions.ToInteger(((DataRow)enumerator.Current)["ComponentID"]);
							sQLiteConnection = activeUnit_0.m_Scenario.GetSQLiteConnection();
							Sensor sensor2 = DBFunctions.LoadSensorData(dBID2, ref sQLiteConnection);
							sensor2.coverageArc.PB1 = Conversions.ToBoolean(dataRow["PB1"]);
							sensor2.coverageArc.PMA1 = Conversions.ToBoolean(dataRow["PMA1"]);
							sensor2.coverageArc.PMF1 = Conversions.ToBoolean(dataRow["PMF1"]);
							sensor2.coverageArc.PS1 = Conversions.ToBoolean(dataRow["PS1"]);
							sensor2.coverageArc.SB1 = Conversions.ToBoolean(dataRow["SB1"]);
							sensor2.coverageArc.SMA1 = Conversions.ToBoolean(dataRow["SMA1"]);
							sensor2.coverageArc.SMF1 = Conversions.ToBoolean(dataRow["SMF1"]);
							sensor2.coverageArc.SS1 = Conversions.ToBoolean(dataRow["SS1"]);
							sensor2.coverageArc.PB2 = Conversions.ToBoolean(dataRow["PB2"]);
							sensor2.coverageArc.PMA2 = Conversions.ToBoolean(dataRow["PMA2"]);
							sensor2.coverageArc.PMF2 = Conversions.ToBoolean(dataRow["PMF2"]);
							sensor2.coverageArc.PS2 = Conversions.ToBoolean(dataRow["PS2"]);
							sensor2.coverageArc.SB2 = Conversions.ToBoolean(dataRow["SB2"]);
							sensor2.coverageArc.SMA2 = Conversions.ToBoolean(dataRow["SMA2"]);
							sensor2.coverageArc.SMF2 = Conversions.ToBoolean(dataRow["SMF2"]);
							sensor2.coverageArc.SS2 = Conversions.ToBoolean(dataRow["SS2"]);
							sensor2.coverageArcMax.PB1 = Conversions.ToBoolean(dataRow["PB1MAX"]);
							sensor2.coverageArcMax.PMA1 = Conversions.ToBoolean(dataRow["PMA1MAX"]);
							sensor2.coverageArcMax.PMF1 = Conversions.ToBoolean(dataRow["PMF1MAX"]);
							sensor2.coverageArcMax.PS1 = Conversions.ToBoolean(dataRow["PS1MAX"]);
							sensor2.coverageArcMax.SB1 = Conversions.ToBoolean(dataRow["SB1MAX"]);
							sensor2.coverageArcMax.SMA1 = Conversions.ToBoolean(dataRow["SMA1MAX"]);
							sensor2.coverageArcMax.SMF1 = Conversions.ToBoolean(dataRow["SMF1MAX"]);
							sensor2.coverageArcMax.SS1 = Conversions.ToBoolean(dataRow["SS1MAX"]);
							sensor2.coverageArcMax.PB2 = Conversions.ToBoolean(dataRow["PB2MAX"]);
							sensor2.coverageArcMax.PMA2 = Conversions.ToBoolean(dataRow["PMA2MAX"]);
							sensor2.coverageArcMax.PMF2 = Conversions.ToBoolean(dataRow["PMF2MAX"]);
							sensor2.coverageArcMax.PS2 = Conversions.ToBoolean(dataRow["PS2MAX"]);
							sensor2.coverageArcMax.SB2 = Conversions.ToBoolean(dataRow["SB2MAX"]);
							sensor2.coverageArcMax.SMA2 = Conversions.ToBoolean(dataRow["SMA2MAX"]);
							sensor2.coverageArcMax.SMF2 = Conversions.ToBoolean(dataRow["SMF2MAX"]);
							sensor2.coverageArcMax.SS2 = Conversions.ToBoolean(dataRow["SS2MAX"]);
							sensor2.SetParentPlatform(activeUnit_0);
							activeUnit_0.AddSensor(sensor2);
						}
						goto IL_92F;
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					goto IL_57F;
				}
				goto IL_57F;
				IL_92F:
				i++;
				continue;
				IL_57F:
				sensor.coverageArc.PB1 = Conversions.ToBoolean(dataRow["PB1"]);
				sensor.coverageArc.PMA1 = Conversions.ToBoolean(dataRow["PMA1"]);
				sensor.coverageArc.PMF1 = Conversions.ToBoolean(dataRow["PMF1"]);
				sensor.coverageArc.PS1 = Conversions.ToBoolean(dataRow["PS1"]);
				sensor.coverageArc.SB1 = Conversions.ToBoolean(dataRow["SB1"]);
				sensor.coverageArc.SMA1 = Conversions.ToBoolean(dataRow["SMA1"]);
				sensor.coverageArc.SMF1 = Conversions.ToBoolean(dataRow["SMF1"]);
				sensor.coverageArc.SS1 = Conversions.ToBoolean(dataRow["SS1"]);
				sensor.coverageArc.PB2 = Conversions.ToBoolean(dataRow["PB2"]);
				sensor.coverageArc.PMA2 = Conversions.ToBoolean(dataRow["PMA2"]);
				sensor.coverageArc.PMF2 = Conversions.ToBoolean(dataRow["PMF2"]);
				sensor.coverageArc.PS2 = Conversions.ToBoolean(dataRow["PS2"]);
				sensor.coverageArc.SB2 = Conversions.ToBoolean(dataRow["SB2"]);
				sensor.coverageArc.SMA2 = Conversions.ToBoolean(dataRow["SMA2"]);
				sensor.coverageArc.SMF2 = Conversions.ToBoolean(dataRow["SMF2"]);
				sensor.coverageArc.SS2 = Conversions.ToBoolean(dataRow["SS2"]);
				sensor.coverageArcMax.PB1 = Conversions.ToBoolean(dataRow["PB1MAX"]);
				sensor.coverageArcMax.PMA1 = Conversions.ToBoolean(dataRow["PMA1MAX"]);
				sensor.coverageArcMax.PMF1 = Conversions.ToBoolean(dataRow["PMF1MAX"]);
				sensor.coverageArcMax.PS1 = Conversions.ToBoolean(dataRow["PS1MAX"]);
				sensor.coverageArcMax.SB1 = Conversions.ToBoolean(dataRow["SB1MAX"]);
				sensor.coverageArcMax.SMA1 = Conversions.ToBoolean(dataRow["SMA1MAX"]);
				sensor.coverageArcMax.SMF1 = Conversions.ToBoolean(dataRow["SMF1MAX"]);
				sensor.coverageArcMax.SS1 = Conversions.ToBoolean(dataRow["SS1MAX"]);
				sensor.coverageArcMax.PB2 = Conversions.ToBoolean(dataRow["PB2MAX"]);
				sensor.coverageArcMax.PMA2 = Conversions.ToBoolean(dataRow["PMA2MAX"]);
				sensor.coverageArcMax.PMF2 = Conversions.ToBoolean(dataRow["PMF2MAX"]);
				sensor.coverageArcMax.PS2 = Conversions.ToBoolean(dataRow["PS2MAX"]);
				sensor.coverageArcMax.SB2 = Conversions.ToBoolean(dataRow["SB2MAX"]);
				sensor.coverageArcMax.SMA2 = Conversions.ToBoolean(dataRow["SMA2MAX"]);
				sensor.coverageArcMax.SMF2 = Conversions.ToBoolean(dataRow["SMF2MAX"]);
				sensor.coverageArcMax.SS2 = Conversions.ToBoolean(dataRow["SS2MAX"]);
				sensor.SetParentPlatform(activeUnit_0);
				activeUnit_0.AddSensor(sensor);
				goto IL_92F;
			}
			if (activeUnit_0.IsPlatform() && (((Platform)activeUnit_0).Crew > 0 || (!activeUnit_0.IsFixedFacility() && (!activeUnit_0.IsAircraft || (((Aircraft)activeUnit_0).Type != Aircraft._AircraftType.UAV && ((Aircraft)activeUnit_0).Type != Aircraft._AircraftType.UCAV)) && (!activeUnit_0.IsSubmarine || (((Submarine)activeUnit_0).Type != Submarine._SubmarineType.UUV && ((Submarine)activeUnit_0).Type != Submarine._SubmarineType.ROV)))))
			{
				Sensor mk1Eyeball = Sensor.GetMk1Eyeball(activeUnit_0.m_Scenario.GetSQLiteConnection());
				mk1Eyeball.coverageArc.PB1 = true;
				mk1Eyeball.coverageArc.PMA1 = true;
				mk1Eyeball.coverageArc.PMF1 = true;
				mk1Eyeball.coverageArc.PS1 = true;
				mk1Eyeball.coverageArc.SB1 = true;
				mk1Eyeball.coverageArc.SMA1 = true;
				mk1Eyeball.coverageArc.SMF1 = true;
				mk1Eyeball.coverageArc.SS1 = true;
				mk1Eyeball.coverageArc.PB2 = true;
				mk1Eyeball.coverageArc.PMA2 = true;
				mk1Eyeball.coverageArc.PMF2 = true;
				mk1Eyeball.coverageArc.PS2 = true;
				mk1Eyeball.coverageArc.SB2 = true;
				mk1Eyeball.coverageArc.SMA2 = true;
				mk1Eyeball.coverageArc.SMF2 = true;
				mk1Eyeball.coverageArc.SS2 = true;
				mk1Eyeball.SetParentPlatform(activeUnit_0);
				activeUnit_0.AddSensor(mk1Eyeball);
			}
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x0030D9C8 File Offset: 0x0030BBC8
		public static void LoadSensorCodesData(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT * from DataSensorCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 2002)
				{
					if (num2 <= 1012)
					{
						switch (num2)
						{
						case 1001:
							sensor_0.sensorCode.IFF = true;
							break;
						case 1002:
							sensor_0.sensorCode.Classification_BrilliantWeapon = true;
							break;
						case 1003:
							sensor_0.sensorCode.NCTR_JEM = true;
							break;
						case 1004:
							sensor_0.sensorCode.NCTR_NBILST = true;
							break;
						default:
							if (num2 != 1011)
							{
								if (num2 != 1012)
								{
									goto IL_323;
								}
								sensor_0.sensorCode.ContinousTrackingCapability_TargetTrackingRadar = true;
							}
							else
							{
								sensor_0.sensorCode.ContinousTrackingCapability_PhasedArrayRadar = true;
							}
							break;
						}
					}
					else if (num2 <= 1033)
					{
						if (num2 != 1021)
						{
							switch (num2)
							{
							case 1031:
								sensor_0.sensorCode.PeriscopeSearch_BasicCapability = true;
								break;
							case 1032:
								sensor_0.sensorCode.PeriscopeSurfaceSearch_FineRangeResolutionAndRapidScan_1980Plus = true;
								break;
							case 1033:
								sensor_0.sensorCode.PeriscopeSurfaceSearch_AdvancedProcessing_2000Plus = true;
								break;
							default:
								goto IL_323;
							}
						}
						else
						{
							sensor_0.sensorCode.ContinousTrackingCapability_Visual = true;
						}
					}
					else if (num2 != 2001)
					{
						if (num2 != 2002)
						{
							goto IL_323;
						}
						sensor_0.sensorCode.MovingTargetIndicator = true;
					}
					else
					{
						sensor_0.sensorCode.TrackWhileScan = true;
					}
				}
				else if (num2 <= 3011)
				{
					if (num2 <= 2701)
					{
						if (num2 != 2011)
						{
							if (num2 != 2701)
							{
								goto IL_323;
							}
							sensor_0.sensorCode.LLTVNVGCCD_NightCapable_Searchlight_VisualNightCapable = true;
						}
						else
						{
							sensor_0.sensorCode.LowProbabilityOfIntercept = true;
						}
					}
					else
					{
						switch (num2)
						{
						case 3001:
							sensor_0.sensorCode.PulseOnlyRadar = true;
							break;
						case 3002:
							sensor_0.sensorCode.PulseDopplerRadar_FullLDSDCapability = true;
							break;
						case 3003:
							sensor_0.sensorCode.PulseDopplerRadar_LimitedLDSDCapability = true;
							break;
						default:
							if (num2 != 3011)
							{
								goto IL_323;
							}
							sensor_0.sensorCode.PassiveElectronicallyScannedArray = true;
							break;
						}
					}
				}
				else if (num2 <= 4003)
				{
					if (num2 != 3012)
					{
						switch (num2)
						{
						case 4001:
							sensor_0.sensorCode.ContinuousWaveIllumination = true;
							break;
						case 4002:
							sensor_0.sensorCode.InterruptedContinuousWaveIllumination = true;
							break;
						case 4003:
							sensor_0.sensorCode.WeaponFCR_NoCWIllumination = true;
							break;
						default:
							goto IL_323;
						}
					}
					else
					{
						sensor_0.sensorCode.ActiveElectronicallyScannedArray = true;
					}
				}
				else if (num2 != 9101)
				{
					if (num2 != 9102)
					{
						goto IL_323;
					}
					sensor_0.sensorCode.ShallowWaterCapableFull_ClassificationFlagRequired = true;
				}
				else
				{
					sensor_0.sensorCode.ShallowWaterCapable_Partial = true;
				}
				IL_350:
				i++;
				continue;
				IL_323:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_350;
				}
				goto IL_350;
			}
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x0030DD38 File Offset: 0x0030BF38
		public static void LoadSensorCapabilitiesData(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT * from DataSensorCapabilities where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 2004)
				{
					switch (num2)
					{
					case 1001:
						sensor_0.sensorCapability.AirSearch = true;
						break;
					case 1002:
						sensor_0.sensorCapability.SurfaceSearch = true;
						break;
					case 1003:
						sensor_0.sensorCapability.SubmarineSearch = true;
						break;
					case 1004:
						sensor_0.sensorCapability.LandSearch_Fixed = true;
						break;
					case 1005:
						sensor_0.sensorCapability.LandSearch_Mobile = true;
						break;
					case 1006:
						sensor_0.sensorCapability.PeriscopeSearch = true;
						break;
					case 1007:
					case 1008:
					case 1009:
					case 1010:
						goto IL_219;
					case 1011:
						sensor_0.sensorCapability.ABM_SpaceSearch = true;
						break;
					default:
						switch (num2)
						{
						case 1021:
							sensor_0.sensorCapability.MineObstacleSearch = true;
							break;
						case 1022:
							sensor_0.sensorCapability.TorpedoWarning = true;
							break;
						case 1023:
							sensor_0.sensorCapability.MissileApproachWarning = true;
							break;
						default:
							switch (num2)
							{
							case 2001:
								sensor_0.sensorCapability.RangeInformation = true;
								break;
							case 2002:
								sensor_0.sensorCapability.AltitudeInformation = true;
								break;
							case 2003:
								sensor_0.sensorCapability.SpeedInformation = true;
								break;
							case 2004:
								sensor_0.sensorCapability.HeadingInformation = true;
								break;
							default:
								goto IL_219;
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 4001:
						sensor_0.sensorCapability.Navigation_Only = true;
						break;
					case 4002:
						sensor_0.sensorCapability.Ground_mapping_only = true;
						break;
					case 4003:
						sensor_0.sensorCapability.TerrainAvoidanceOrFollowing = true;
						break;
					case 4004:
						sensor_0.sensorCapability.WeatherOnly = true;
						break;
					case 4005:
						sensor_0.sensorCapability.WeatherAndNavigation = true;
						break;
					default:
						if (num2 != 9001)
						{
							if (num2 != 9002)
							{
								goto IL_219;
							}
							sensor_0.sensorCapability.OTH_SurfaceWave = true;
						}
						else
						{
							sensor_0.sensorCapability.OTH_Backscatter = true;
						}
						break;
					}
				}
				IL_291:
				i++;
				continue;
				IL_219:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_291;
				}
				goto IL_291;
			}
			if (sensor_0.sensorType == Sensor.SensorType.ESM)
			{
				sensor_0.sensorCapability.AirSearch = true;
				sensor_0.sensorCapability.SurfaceSearch = true;
			}
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x0030E018 File Offset: 0x0030C218
		public static void smethod_97(ref CommDevice commDevice_, SQLiteConnection sqliteConnection_0)
		{
			try
			{
				SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
				string string_ = "SELECT * from DataCommCapabilities where ID = " + Conversions.ToString(commDevice_.DBID);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					int num2 = Conversions.ToInteger(dataRow["CodeID"]);
					if (num2 - 1200 > 1 && num2 != 1300 && num2 - 1401 > 1)
					{
						Sensor.FrequencyBand item = (Sensor.FrequencyBand)Conversions.ToLong(dataRow["CodeID"]);
						commDevice_.FrequencyBandHashSet.Add(item);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0030E10C File Offset: 0x0030C30C
		public static void LoadSensorFrequencySearchAndTrackData(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT * from DataSensorFrequencySearchAndTrack where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int count = dataTable.Rows.Count;
			sensor_0.SearchAndTrackFrequencies = new Sensor.RadioElectronicFrequency[count - 1 + 1];
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Sensor.RadioElectronicFrequency radioElectronicFrequency = new Sensor.RadioElectronicFrequency((Sensor.FrequencyBand)Conversions.ToLong(dataRow["Frequency"]));
				sensor_0.SearchAndTrackFrequencies[i] = radioElectronicFrequency;
			}
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x0030E1A4 File Offset: 0x0030C3A4
		public static void LoadSensorFrequencyIlluminateData(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT * from DataSensorFrequencyIlluminate where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int count = dataTable.Rows.Count;
			sensor_0.SensorFrequencyIlluminateArray = new Sensor.RadioElectronicFrequency[count - 1 + 1];
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Sensor.RadioElectronicFrequency radioElectronicFrequency = new Sensor.RadioElectronicFrequency((Sensor.FrequencyBand)Conversions.ToLong(dataRow["Frequency"]));
				sensor_0.SensorFrequencyIlluminateArray[i] = radioElectronicFrequency;
			}
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x0030E23C File Offset: 0x0030C43C
		public static bool smethod_100(int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT count(*) FROM sqlite_master WHERE type='table' AND name='Capabilities'";
			bool result;
			if (Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_)) == 0)
			{
				result = false;
			}
			else if (int_0 == 0)
			{
				result = true;
			}
			else
			{
				string_ = "SELECT Count(*) from Capabilities where ID='" + Conversions.ToString(int_0) + "'";
				result = (Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_)) > 0);
			}
			return result;
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x0030E2A4 File Offset: 0x0030C4A4
		public static void LoadPlatformSignaturesData(ActiveUnit activeUnit_, ref List<XSection> XSections_, int int_0)
		{
			string str = "";
			SQLiteDataBase db = new SQLiteDataBase(activeUnit_.m_Scenario.GetSQLiteConnection());
			if (Information.IsNothing(XSections_))
			{
				XSections_ = new List<XSection>();
			}
			switch (activeUnit_.GetUnitType())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				str = "DataAircraftSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				str = "DataShipSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				str = "DataSubmarineSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				str = "DataFacilitySignatures";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				str = "DataWeaponSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				str = "DataSatelliteSignatures";
				break;
			}
			string string_ = "Select * From " + str + " as theTable where theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataRow dataRow = dataTable.Rows[num2];
				XSection item = new XSection((XSection._SignatureType)Conversions.ToShort(dataRow["Type"]), Conversions.ToSingle(dataRow["Front"]), Conversions.ToSingle(dataRow["Side"]), Conversions.ToSingle(dataRow["Rear"]), 0f);
				try
				{
					XSections_.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					XSections_.Add(item);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x0030E418 File Offset: 0x0030C618
		public static void LoadPlatformFuelsData(ActiveUnit activeUnit_0, int int_0)
		{
			string str = "";
			try
			{
				SQLiteDataBase db = new SQLiteDataBase(activeUnit_0.m_Scenario.GetSQLiteConnection());
				switch (activeUnit_0.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					str = "DataAircraftFuel";
					break;
				case GlobalVariables.ActiveUnitType.Ship:
					str = "DataShipFuel";
					break;
				case GlobalVariables.ActiveUnitType.Submarine:
					str = "DataSubmarineFuel";
					break;
				case GlobalVariables.ActiveUnitType.Facility:
					str = "DataFacilityFuel";
					break;
				case GlobalVariables.ActiveUnitType.Weapon:
					str = "DataWeaponFuel";
					break;
				}
				string string_ = "Select * From " + str + " as theTable where theTable.ID = " + Conversions.ToString(int_0);
				DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					string_ = "Select * From DataFuel where ID = " + dataRow["ComponentID"].ToString();
					DataRow dataRow2 = CachedDataBase.GetDataTable(db, string_).Rows[0];
					activeUnit_0.AddFuelRec(new FuelRec(Conversions.ToInteger(dataRow2["Capacity"]), Conversions.ToShort(dataRow2["Type"]))
					{
						DBID = new int?(Conversions.ToInteger(dataRow2["ID"]))
					});
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101291", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x0030E5C4 File Offset: 0x0030C7C4
		public static int smethod_103(string string_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT ID from DataMount where Name='" + string_0 + "'";
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(db, string_));
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x0030E5F8 File Offset: 0x0030C7F8
		public static string GetMountName(int ID_, ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT Name from DataMount where ID='" + Conversions.ToString(ID_) + "'";
			return CachedDataBase.ExecuteScalar(db, string_);
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x0030E62C File Offset: 0x0030C82C
		public static Mount LoadMountData(int MountDBID, ref Scenario theScen, bool LoadComponents = true)
		{
			SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
			string string_ = "Select DataMount.* from DataMount WHERE DataMount.ID = " + Conversions.ToString(MountDBID);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception0();
			}
			Mount mount = null;
			DataRow dataRow = dataTable.Rows[0];
			mount = new Mount();
			Mount mount2 = mount;
			mount2.DBID = MountDBID;
			mount2.Name = Conversions.ToString(dataRow["Name"]);
			mount2.ArmorGeneral = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]);
			mount2.ROF = Conversions.ToInteger(dataRow["ROF"]);
			mount2.GetMagazineForMount().MagazineROF = Conversions.ToInteger(dataRow["MagazineROF"]);
			mount2.Capacity = Conversions.ToInteger(dataRow["Capacity"]);
			mount2.GetMagazineForMount().MagazineCapacity = Conversions.ToInteger(dataRow["MagazineCapacity"]);
			mount2.Autonomous = Conversions.ToBoolean(dataRow["Autonomous"]);
			mount2.Logistic = Conversions.ToBoolean(dataRow["Logistic"]);
			mount2.CanHotReload = Conversions.ToBoolean(dataRow["CanHotReload"]);
			mount2.LocalControl = Conversions.ToBoolean(dataRow["LocalControl"]);
			mount2.Trainable = Conversions.ToBoolean(dataRow["Trainable"]);
			mount2.DamagePoints = (float)Conversions.ToDouble(dataRow["DamagePoints"]);
			mount2.ReserveTarget = Conversions.ToBoolean(dataRow["ReserveTarget"]);
			try
			{
				mount2.Hypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (dataTable.Columns.Contains("Cargo_Crew"))
			{
				try
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
					{
						mount2.Cargo_Crew = Conversions.ToShort(dataRow["Cargo_Crew"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
					{
						mount2.Cargo_Area = Conversions.ToShort(dataRow["Cargo_Area"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
					{
						mount2.Cargo_Type = (_CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
					{
						mount2.Cargo_Mass = Conversions.ToShort(dataRow["Cargo_Mass"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_ParadropCapable"])))
					{
						mount2.Cargo_ParadropCapable = Conversions.ToBoolean(dataRow["Cargo_ParadropCapable"]);
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["MobileUnitCategory"])))
				{
					mount2.mobileUnitCategory = (Facility._MobileUnitCategory)Math.Round((double)Conversions.ToInteger(dataRow["MobileUnitCategory"]) / 1000.0);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			mount2 = null;
			DBFunctions.smethod_62(theScen, ref mount);
			DBFunctions.smethod_106(ref mount, theScen.GetSQLiteConnection());
			if (LoadComponents)
			{
				DBFunctions.LoadDataMountSensor(ref mount, Conversions.ToInteger(dataRow["ID"]), theScen.GetSQLiteConnection());
				DBFunctions.LoadMountedComms(ref mount, Conversions.ToInteger(dataRow["ID"]), theScen);
				DBFunctions.smethod_110(ref theScen, ref mount, Conversions.ToInteger(dataRow["ID"]));
				DBFunctions.smethod_111(ref theScen, ref mount, Conversions.ToInteger(dataRow["ID"]));
			}
			return mount;
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x0030EA34 File Offset: 0x0030CC34
		public static void smethod_106(ref Mount mount_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(sqliteConnection_0);
			if (sQLiteDataBase.method_6("MiscMountDefault"))
			{
				string string_ = "Select * from MiscMountDefault WHERE ID = " + Conversions.ToString(mount_0.DBID);
				DataTable dataTable = CachedDataBase.GetDataTable(sQLiteDataBase, string_);
				if (dataTable.Rows.Count > 0)
				{
					DataRow dataRow = dataTable.Rows[0];
					Mount mount = mount_0;
					mount.coverageArc.PB1 = Conversions.ToBoolean(dataRow["PB1"]);
					mount.coverageArc.PB2 = Conversions.ToBoolean(dataRow["PB2"]);
					mount.coverageArc.PMF1 = Conversions.ToBoolean(dataRow["PMF1"]);
					mount.coverageArc.PMF2 = Conversions.ToBoolean(dataRow["PMF2"]);
					mount.coverageArc.PMA1 = Conversions.ToBoolean(dataRow["PMA1"]);
					mount.coverageArc.PMA2 = Conversions.ToBoolean(dataRow["PMA2"]);
					mount.coverageArc.PS1 = Conversions.ToBoolean(dataRow["PS1"]);
					mount.coverageArc.PS2 = Conversions.ToBoolean(dataRow["PS2"]);
					mount.coverageArc.SB1 = Conversions.ToBoolean(dataRow["SB1"]);
					mount.coverageArc.SB2 = Conversions.ToBoolean(dataRow["SB2"]);
					mount.coverageArc.SMF1 = Conversions.ToBoolean(dataRow["SMF1"]);
					mount.coverageArc.SMF2 = Conversions.ToBoolean(dataRow["SMF2"]);
					mount.coverageArc.SMA1 = Conversions.ToBoolean(dataRow["SMA1"]);
					mount.coverageArc.SMA2 = Conversions.ToBoolean(dataRow["SMA2"]);
					mount.coverageArc.SS1 = Conversions.ToBoolean(dataRow["SS1"]);
					mount.coverageArc.SS2 = Conversions.ToBoolean(dataRow["SS2"]);
				}
			}
			else
			{
				Mount mount2 = mount_0;
				mount2.coverageArc.PB1 = true;
				mount2.coverageArc.PB2 = true;
				mount2.coverageArc.PMF1 = true;
				mount2.coverageArc.PMF2 = true;
				mount2.coverageArc.PMA1 = true;
				mount2.coverageArc.PMA2 = true;
				mount2.coverageArc.PS1 = true;
				mount2.coverageArc.PS2 = true;
				mount2.coverageArc.SB1 = true;
				mount2.coverageArc.SB2 = true;
				mount2.coverageArc.SMF1 = true;
				mount2.coverageArc.SMF2 = true;
				mount2.coverageArc.SMA1 = true;
				mount2.coverageArc.SMA2 = true;
				mount2.coverageArc.SS1 = true;
				mount2.coverageArc.SS2 = true;
			}
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x0030ED3C File Offset: 0x0030CF3C
		public static void LoadPlatformMountsData(ref Scenario scenario_0, ref ActiveUnit activeUnit_0, int int_0)
		{
			string text = "";
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			if (activeUnit_0.IsAircraft)
			{
				text = "DataAircraftMounts";
			}
			else if (activeUnit_0.IsWeapon)
			{
				text = "DataWeaponMounts";
			}
			else if (activeUnit_0.IsShip)
			{
				text = "DataShipMounts";
			}
			else if (activeUnit_0.IsSubmarine)
			{
				text = "DataSubmarineMounts";
			}
			else if (activeUnit_0.IsFacility)
			{
				text = "DataFacilityMounts";
			}
			else if (activeUnit_0.IsSatellite())
			{
				text = "DataSatelliteMounts";
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT DataMount.*, theTable.PB1, theTable.PB2, theTable.PMF1, theTable.PMF2, theTable.PMA1, theTable.PMA2, theTable.PS1, theTable.PS2, theTable.SB1, theTable.SB2, theTable.SMF1, theTable.SMF2, theTable.SMA1, theTable.SMA2, theTable.SS1, theTable.SS2 FROM DataMount, ",
				text,
				" AS theTable WHERE DataMount.ID = theTable.ComponentID And theTable.ID = ",
				Conversions.ToString(int_0),
				" ORDER BY DataMount.Name ASC"
			});
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Mount mount = new Mount();
				Mount mount2 = mount;
				mount2.SetParentPlatform(activeUnit_0);
				mount2.DBID = Conversions.ToInteger(dataRow["ID"]);
				mount2.Name = Conversions.ToString(dataRow["Name"]);
				mount2.ArmorGeneral = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]);
				mount2.ROF = Conversions.ToInteger(dataRow["ROF"]);
				mount2.GetMagazineForMount().MagazineROF = Conversions.ToInteger(dataRow["MagazineROF"]);
				mount2.Capacity = Conversions.ToInteger(dataRow["Capacity"]);
				mount2.GetMagazineForMount().MagazineCapacity = Conversions.ToInteger(dataRow["MagazineCapacity"]);
				mount2.Autonomous = Conversions.ToBoolean(dataRow["Autonomous"]);
				mount2.Logistic = Conversions.ToBoolean(dataRow["Logistic"]);
				mount2.CanHotReload = Conversions.ToBoolean(dataRow["CanHotReload"]);
				mount2.LocalControl = Conversions.ToBoolean(dataRow["LocalControl"]);
				mount2.Trainable = Conversions.ToBoolean(dataRow["Trainable"]);
				mount2.DamagePoints = Conversions.ToSingle(dataRow["DamagePoints"]);
				mount2.ReserveTarget = Conversions.ToBoolean(dataRow["ReserveTarget"]);
				mount2.coverageArc.PB1 = Conversions.ToBoolean(dataRow["PB1"]);
				mount2.coverageArc.PB2 = Conversions.ToBoolean(dataRow["PB2"]);
				mount2.coverageArc.PMF1 = Conversions.ToBoolean(dataRow["PMF1"]);
				mount2.coverageArc.PMF2 = Conversions.ToBoolean(dataRow["PMF2"]);
				mount2.coverageArc.PMA1 = Conversions.ToBoolean(dataRow["PMA1"]);
				mount2.coverageArc.PMA2 = Conversions.ToBoolean(dataRow["PMA2"]);
				mount2.coverageArc.PS1 = Conversions.ToBoolean(dataRow["PS1"]);
				mount2.coverageArc.PS2 = Conversions.ToBoolean(dataRow["PS2"]);
				mount2.coverageArc.SB1 = Conversions.ToBoolean(dataRow["SB1"]);
				mount2.coverageArc.SB2 = Conversions.ToBoolean(dataRow["SB2"]);
				mount2.coverageArc.SMF1 = Conversions.ToBoolean(dataRow["SMF1"]);
				mount2.coverageArc.SMF2 = Conversions.ToBoolean(dataRow["SMF2"]);
				mount2.coverageArc.SMA1 = Conversions.ToBoolean(dataRow["SMA1"]);
				mount2.coverageArc.SMA2 = Conversions.ToBoolean(dataRow["SMA2"]);
				mount2.coverageArc.SS1 = Conversions.ToBoolean(dataRow["SS1"]);
				mount2.coverageArc.SS2 = Conversions.ToBoolean(dataRow["SS2"]);
				DBFunctions.LoadDataMountSensor(ref mount, Conversions.ToInteger(dataRow["ID"]), scenario_0.GetSQLiteConnection());
				DBFunctions.LoadMountedComms(ref mount, Conversions.ToInteger(dataRow["ID"]), scenario_0);
				DBFunctions.smethod_110(ref scenario_0, ref mount, Conversions.ToInteger(dataRow["ID"]));
				DBFunctions.smethod_111(ref scenario_0, ref mount, Conversions.ToInteger(dataRow["ID"]));
				DBFunctions.smethod_62(scenario_0, ref mount);
				ScenarioArrayUtil.AddMount(ref activeUnit_0.m_Mounts, mount);
			}
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x0030F20C File Offset: 0x0030D40C
		public static void LoadMountedComms(ref Mount mount_, int ID_, Scenario scenario_)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_.GetSQLiteConnection());
			string string_ = "Select DataComm.ID as CommID, DataComm.Name, DataComm.Type, DataComm.Range, DataComm.Channels, DataComm.IsOptional, theTable.* from DataComm, DataMountComms as theTable where DataComm.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(ID_);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				CommDevice commDevice_ = new CommDevice(mount_.GetParentPlatform(), scenario_, Conversions.ToInteger(dataRow["CommID"]), Conversions.ToString(dataRow["Name"]), (CommDevice.CommLinkType)Conversions.ToInteger(dataRow["Type"]), Conversions.ToDouble(dataRow["Range"]), Conversions.ToInteger(dataRow["Channels"]), Conversions.ToBoolean(dataRow["IsOptional"]));
				ScenarioArrayUtil.AddCommDevice(ref mount_.m_CommDevices, commDevice_);
			}
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x0030F2FC File Offset: 0x0030D4FC
		public static void LoadDataMountSensor(ref Mount mount_, int int_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT S.ID from DataMountSensors as MS, DataSensor as S where S.ID = MS.ComponentID and MS.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			if (!Information.IsNothing(mount_.GetParentPlatform()))
			{
				mount_.GetParentPlatform();
			}
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Sensor sensor = DBFunctions.LoadSensorData(Conversions.ToInteger(dataTable.Rows[i]["ID"]), ref sqliteConnection_0);
				sensor.SetParentPlatform(mount_.GetParentPlatform());
				sensor.coverageArc.PB1 = mount_.coverageArc.PB1;
				sensor.coverageArc.PMA1 = mount_.coverageArc.PMA1;
				sensor.coverageArc.PMF1 = mount_.coverageArc.PMF1;
				sensor.coverageArc.PS1 = mount_.coverageArc.PS1;
				sensor.coverageArc.SB1 = mount_.coverageArc.SB1;
				sensor.coverageArc.SMA1 = mount_.coverageArc.SMA1;
				sensor.coverageArc.SMF1 = mount_.coverageArc.SMF1;
				sensor.coverageArc.SS1 = mount_.coverageArc.SS1;
				sensor.coverageArc.PB2 = mount_.coverageArc.PB2;
				sensor.coverageArc.PMA2 = mount_.coverageArc.PMA2;
				sensor.coverageArc.PMF2 = mount_.coverageArc.PMF2;
				sensor.coverageArc.PS2 = mount_.coverageArc.PS2;
				sensor.coverageArc.SB2 = mount_.coverageArc.SB2;
				sensor.coverageArc.SMA2 = mount_.coverageArc.SMA2;
				sensor.coverageArc.SMF2 = mount_.coverageArc.SMF2;
				sensor.coverageArc.SS2 = mount_.coverageArc.SS2;
				sensor.coverageArcMax.PB1 = mount_.coverageArc.PB1;
				sensor.coverageArcMax.PMA1 = mount_.coverageArc.PMA1;
				sensor.coverageArcMax.PMF1 = mount_.coverageArc.PMF1;
				sensor.coverageArcMax.PS1 = mount_.coverageArc.PS1;
				sensor.coverageArcMax.SB1 = mount_.coverageArc.SB1;
				sensor.coverageArcMax.SMA1 = mount_.coverageArc.SMA1;
				sensor.coverageArcMax.SMF1 = mount_.coverageArc.SMF1;
				sensor.coverageArcMax.SS1 = mount_.coverageArc.SS1;
				sensor.coverageArcMax.PB2 = mount_.coverageArc.PB2;
				sensor.coverageArcMax.PMA2 = mount_.coverageArc.PMA2;
				sensor.coverageArcMax.PMF2 = mount_.coverageArc.PMF2;
				sensor.coverageArcMax.PS2 = mount_.coverageArc.PS2;
				sensor.coverageArcMax.SB2 = mount_.coverageArc.SB2;
				sensor.coverageArcMax.SMA2 = mount_.coverageArc.SMA2;
				sensor.coverageArcMax.SMF2 = mount_.coverageArc.SMF2;
				sensor.coverageArcMax.SS2 = mount_.coverageArc.SS2;
				mount_.AddSensor(sensor);
			}
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x0030F6A4 File Offset: 0x0030D8A4
		public static void smethod_110(ref Scenario scenario_0, ref Mount mount_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "SELECT DataWeaponRecord.* FROM DataMountWeapons, DataWeaponRecord, DataWeapon WHERE DataMountWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataMountWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				WeaponRec item = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
				mount_0.GetWeaponRecCollection().Add(item);
			}
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x0030F784 File Offset: 0x0030D984
		public static void smethod_111(ref Scenario scenario_0, ref Mount mount_0, int int_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
			string string_ = "SELECT DataWeaponRecord.*, DataMountMagazineWeapons.ComponentNumber FROM DataMountMagazineWeapons, DataWeaponRecord, DataWeapon WHERE DataMountMagazineWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataMountMagazineWeapons.ID  = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				WeaponRec item = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
				mount_0.GetMagazineForMount().GetWeaponRecCollection().Add(item);
			}
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x0030F868 File Offset: 0x0030DA68
		public static void LoadWeaponTargets(ref WeaponTarget WeaponTarget_, int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string string_ = "SELECT CodeID from DataWeaponTargets where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 4001)
				{
					if (num2 <= 2004)
					{
						switch (num2)
						{
						case 1001:
							WeaponTarget_.IsAircraft = true;
							break;
						case 1002:
							WeaponTarget_.IsHelicopter = true;
							break;
						case 1003:
							WeaponTarget_.IsGuidedWeapon = true;
							break;
						case 1004:
							WeaponTarget_.IsSatellite = true;
							break;
						default:
							switch (num2)
							{
							case 2001:
								WeaponTarget_.IsSurfaceShip = true;
								break;
							case 2002:
								WeaponTarget_.IsSubsurface = true;
								break;
							case 2003:
								WeaponTarget_.IsMine = true;
								break;
							case 2004:
								WeaponTarget_.IsTorpedoe = true;
								break;
							default:
								goto IL_1D5;
							}
							break;
						}
					}
					else
					{
						switch (num2)
						{
						case 3001:
							WeaponTarget_.IsSoftLandStructures = true;
							break;
						case 3002:
							WeaponTarget_.IsHardLandStructures = true;
							break;
						case 3003:
							WeaponTarget_.IsRunway = true;
							break;
						case 3004:
							WeaponTarget_.IsRadar = true;
							break;
						default:
							if (num2 != 4001)
							{
								goto IL_1D5;
							}
							WeaponTarget_.IsSoftMobileUnit = true;
							break;
						}
					}
				}
				else if (num2 <= 5001)
				{
					if (num2 != 4002)
					{
						if (num2 != 5001)
						{
							goto IL_1D5;
						}
						WeaponTarget_.IsUnderwaterStructure = true;
					}
					else
					{
						WeaponTarget_.IsHardMobileUnit = true;
					}
				}
				else if (num2 != 6001)
				{
					if (num2 != 9001)
					{
						goto IL_1D5;
					}
					WeaponTarget_.IsAirfield = true;
				}
				else
				{
					WeaponTarget_.bool_15 = true;
				}
				IL_1F8:
				i++;
				continue;
				IL_1D5:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_1F8;
				}
				goto IL_1F8;
			}
		}

		// Token: 0x040035D4 RID: 13780
		public static Func<int, int> intFunc0 = (int int_0) => int_0;

		// Token: 0x040035D5 RID: 13781
		public static Func<ActiveUnit, int> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x040035D6 RID: 13782
		public static Func<int, int> intFunc2 = (int int_0) => int_0;

		// Token: 0x040035D7 RID: 13783
		public static Func<string, bool> stringFunc3 = (string string_0) => !string.IsNullOrEmpty(string_0);

		// Token: 0x040035D8 RID: 13784
		private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

		// Token: 0x040035D9 RID: 13785
		private static Dictionary<string, bool> dictionary_1 = new Dictionary<string, bool>();

		// Token: 0x02000BB2 RID: 2994
		[CompilerGenerated]
		public sealed class UnitTypeChecker
		{
			// Token: 0x0600632B RID: 25387 RVA: 0x0002B7B1 File Offset: 0x000299B1
			public UnitTypeChecker(DBFunctions.UnitTypeChecker UnitTypeChecker_)
			{
				if (UnitTypeChecker_ != null)
				{
					this.activeUnitType = UnitTypeChecker_.activeUnitType;
				}
			}

			// Token: 0x0600632C RID: 25388 RVA: 0x0002B7CB File Offset: 0x000299CB
			internal bool IsPlatformOfSameTypeWithMe(ActiveUnit activeUnit_)
			{
				return activeUnit_.IsPlatform() && activeUnit_.GetUnitType() == this.activeUnitType;
			}

			// Token: 0x040035DE RID: 13790
			public GlobalVariables.ActiveUnitType activeUnitType;
		}
	}
}
