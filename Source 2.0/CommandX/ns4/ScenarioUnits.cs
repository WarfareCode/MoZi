using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;
using ns31;

namespace ns4
{
	// Token: 0x02000C92 RID: 3218
	public sealed class ScenarioUnits
	{
		// Token: 0x06006AA8 RID: 27304 RVA: 0x00393F3C File Offset: 0x0039213C
		public static void Save(Scenario scenario_0, Stream stream_0)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			try
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(stream_0, xmlWriterSettings))
				{
					xmlWriter.WriteStartElement("ScenarioUnits");
					foreach (ActiveUnit current in scenario_0.GetActiveUnits().Values)
					{
						xmlWriter.WriteStartElement("Unit_" + current.GetGuid());
						xmlWriter.WriteComment(string.Concat(new string[]
						{
							current.Name,
							" (",
							current.UnitClass,
							" [",
							Conversions.ToString(current.DBID),
							"])"
						}));
						xmlWriter.WriteEndElement();
					}
					xmlWriter.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101113", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x00394094 File Offset: 0x00392294
		public static ActiveUnit AddUnit(ActiveUnit activeUnit_0, double double_0, double double_1)
		{
			ActiveUnit result = null;
			try
			{
				ActiveUnit activeUnit = null;
				try
				{
					switch (activeUnit_0.GetUnitType())
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
						activeUnit = activeUnit_0.m_Scenario.AddAircraft(activeUnit_0.GetSide(false), activeUnit_0.Name, double_1, double_0, activeUnit_0.DBID, ((Aircraft)activeUnit_0).GetLoadout().DBID, activeUnit_0.GetCurrentAltitude_ASL(false), null);
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						activeUnit = activeUnit_0.m_Scenario.AddShip(activeUnit_0.GetSide(false), activeUnit_0.DBID, activeUnit_0.Name, double_1, double_0, false, null);
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						activeUnit = activeUnit_0.m_Scenario.AddSubmarine(activeUnit_0.GetSide(false), activeUnit_0.DBID, activeUnit_0.Name, double_1, double_0, false, null);
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						activeUnit = activeUnit_0.m_Scenario.AddFacility(activeUnit_0.GetSide(false), activeUnit_0.DBID, activeUnit_0.Name, double_1, double_0, false, null);
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox("Error: " + ex2.Message, MsgBoxStyle.Critical, null);
					ProjectData.ClearProjectError();
				}
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.Indent = true;
				xmlWriterSettings.IndentChars = "    ";
				xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
				Stream1 stream = new Stream1();
				XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings);
				xmlWriter.WriteStartElement("ScenarioUnits");
				StreamWriter streamWriter_ = null;
				int num = 0;
				ScenarioUnits.smethod_4(activeUnit_0, activeUnit_0.m_Scenario, xmlWriter, streamWriter_, ref num);
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
				if (stream.Length <= 60L)
				{
					result = activeUnit;
				}
				else
				{
					try
					{
						xmlWriter.WriteEndElement();
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
					xmlWriter.Flush();
					stream.Seek(0L, SeekOrigin.Begin);
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(stream);
					ScenarioUnits.smethod_2(xmlDocument.SelectSingleNode("/ScenarioUnits").ChildNodes[0], "", "Unit_" + activeUnit.GetGuid());
					stream = new Stream1();
					xmlDocument.Save(stream);
					stream.Seek(0L, SeekOrigin.Begin);
					ScenarioUnits.smethod_8(activeUnit_0.m_Scenario, null, true, stream);
					activeUnit.SetCurrentHeading(activeUnit_0.GetCurrentHeading());
					result = activeUnit;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00394358 File Offset: 0x00392558
		public static XmlNode smethod_2(XmlNode xmlNode_0, string string_0, string string_1)
		{
			XmlNode result;
			if (xmlNode_0.NodeType == XmlNodeType.Element)
			{
				XmlElement xmlElement = (XmlElement)xmlNode_0;
				XmlElement xmlElement2 = xmlNode_0.OwnerDocument.CreateElement(string_1, string_0);
				while (xmlElement.HasAttributes)
				{
					xmlElement2.SetAttributeNode(xmlElement.RemoveAttributeNode(xmlElement.Attributes[0]));
				}
				while (xmlElement.HasChildNodes)
				{
					xmlElement2.AppendChild(xmlElement.FirstChild);
				}
				if (xmlElement.ParentNode != null)
				{
					xmlElement.ParentNode.ReplaceChild(xmlElement2, xmlElement);
				}
				result = xmlElement2;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x003943E4 File Offset: 0x003925E4
		public static void smethod_3(Scenario scenario_0, Stream stream_0, string string_0, ActiveUnit activeUnit_0)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			try
			{
				string str = string.Concat(new string[]
				{
					"Scenario: ",
					scenario_0.GetScenarioTitle(),
					"\r\nScenario file: ",
					MyTemplate.GetApp().Info.DirectoryPath,
					"\\Scenarios\\",
					scenario_0.FileName,
					".scen\r\nConfig file:   ",
					string_0
				});
				StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR INI template log file.txt");
				streamWriter.Write("\r\n\r\n" + str);
				streamWriter.Close();
				int num = 0;
				using (XmlWriter xmlWriter = XmlWriter.Create(stream_0, xmlWriterSettings))
				{
					xmlWriter.WriteStartElement("ScenarioUnits");
					if (!Information.IsNothing(activeUnit_0))
					{
						ScenarioUnits.smethod_4(activeUnit_0, scenario_0, xmlWriter, streamWriter, ref num);
					}
					else
					{
						using (IEnumerator<ActiveUnit> enumerator = scenario_0.GetActiveUnits().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ScenarioUnits.smethod_4(enumerator.Current, scenario_0, xmlWriter, streamWriter, ref num);
							}
						}
					}
					xmlWriter.WriteEndElement();
				}
				if (Information.IsNothing(activeUnit_0))
				{
					if (num != 0)
					{
						Interaction.MsgBox(string.Concat(new string[]
						{
							"INI template completed with errors.\r\n\r\nNUMBER OF ERRORS FOUND: ",
							Conversions.ToString(num),
							"\r\n\r\n Please check '",
							MyTemplate.GetApp().Info.DirectoryPath,
							"\\Logs\\SBR INI template log file.txt' for details."
						}), MsgBoxStyle.OkOnly, null);
					}
					else
					{
						Interaction.MsgBox("INI template completed, no errors detected.", MsgBoxStyle.OkOnly, null);
					}
				}
				str = "Export Completed";
				streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR INI template log file.txt");
				streamWriter.Write("\r\n" + str);
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101114", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x00394650 File Offset: 0x00392850
		public static void smethod_4(ActiveUnit activeUnit_0, Scenario scenario_0, XmlWriter xmlWriter_0, StreamWriter streamWriter_0, ref int int_0)
        {

            int num7;
            int num8;
            string str5;
            bool flag3;
            WeaponRec rec;
            bool flag4;
            int num9;
            string name;
            int num10;
            DataTable table23;
            int num13;
            string str7;
            int num14;
            string str8;
            int num15;
            int num18;
            int num24;
            int num26;
            string str9;
            int num27;
            int num30;
            int num35;
            DataRow row25;
            SQLiteDataBase base2 = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
            string str = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            DataTable table = null;
            IEnumerator enumerator = null;
            switch (activeUnit_0.GetUnitType())
            {
                case GlobalVariables.ActiveUnitType.Aircraft:
                    str = "select ComponentID, Name, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2 from DataAircraftMounts as dsm, DataMount as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID) ORDER BY dm.Name ASC";
                    str2 = "select ComponentID, Name, Type, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2, SB1Max, SB2Max, SMF1Max, SMF2Max, SMA1Max, SMA2Max, SS1Max, SS2Max, PB1Max, PB2Max, PMF1Max, PMF2Max, PMA1Max, PMA2Max, PS1Max, PS2Max from DataAircraftSensors as dsm, DataSensor as dm where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and dsm.ComponentID = dm.ID) and Type <> 9001 ORDER BY dm.Type, dm.Name ASC";
                    str3 = "select ComponentID, Name from DataAircraftComms as dsm, DataComm as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID)";
                    break;

                case GlobalVariables.ActiveUnitType.Ship:
                    str = "select ComponentID, Name, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2 from DataShipMounts as dsm, DataMount as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID) ORDER BY dm.Name ASC";
                    str4 = "select ComponentID, Name from DataShipMagazines as dsmag, DataMagazine as dmag  where (dsmag.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsmag.ComponentID = dmag.ID) ORDER BY dmag.Name ASC";
                    str2 = "select ComponentID, Name, Type, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2, SB1Max, SB2Max, SMF1Max, SMF2Max, SMA1Max, SMA2Max, SS1Max, SS2Max, PB1Max, PB2Max, PMF1Max, PMF2Max, PMA1Max, PMA2Max, PS1Max, PS2Max from DataShipSensors as dsm, DataSensor as dm where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and dsm.ComponentID = dm.ID) and Type <> 9001 ORDER BY dm.Type, dm.Name ASC";
                    str3 = "select ComponentID, Name from DataShipComms as dsm, DataComm as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID)";
                    break;

                case GlobalVariables.ActiveUnitType.Submarine:
                    str = "select ComponentID, Name, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2 from DataSubmarineMounts as dsm, DataMount as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID) ORDER BY dm.Name ASC";
                    str4 = "select ComponentID, Name from DataSubmarineMagazines as dsmag, DataMagazine as dmag  where (dsmag.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsmag.ComponentID = dmag.ID) ORDER BY dmag.Name ASC";
                    str2 = "select ComponentID, Name, Type, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2, SB1Max, SB2Max, SMF1Max, SMF2Max, SMA1Max, SMA2Max, SS1Max, SS2Max, PB1Max, PB2Max, PMF1Max, PMF2Max, PMA1Max, PMA2Max, PS1Max, PS2Max from DataSubmarineSensors as dsm, DataSensor as dm where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and dsm.ComponentID = dm.ID) and Type <> 9001 ORDER BY dm.Type, dm.Name ASC";
                    str3 = "select ComponentID, Name from DataSubmarineComms as dsm, DataComm as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID)";
                    break;

                case GlobalVariables.ActiveUnitType.Facility:
                    str = "select ComponentID, Name, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2 from DataFacilityMounts as dsm, DataMount as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID) ORDER BY dm.Name ASC";
                    str4 = "select ComponentID, Name from DataFacilityMagazines as dsmag, DataMagazine as dmag  where (dsmag.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsmag.ComponentID = dmag.ID) ORDER BY dmag.Name ASC";
                    str2 = "select ComponentID, Name, Type, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2, SB1Max, SB2Max, SMF1Max, SMF2Max, SMA1Max, SMA2Max, SS1Max, SS2Max, PB1Max, PB2Max, PMF1Max, PMF2Max, PMA1Max, PMA2Max, PS1Max, PS2Max from DataFacilitySensors as dsm, DataSensor as dm where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and dsm.ComponentID = dm.ID) and Type <> 9001 ORDER BY dm.Type, dm.Name ASC";
                    str3 = "select ComponentID, Name from DataFacilityComms as dsm, DataComm as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID)";
                    break;

                case GlobalVariables.ActiveUnitType.Satellite:
                    str = "select ComponentID, Name, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2 from DataSatelliteMounts as dsm, DataMount as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID) ORDER BY dm.Name ASC";
                    str2 = "select ComponentID, Name, Type, SB1, SB2, SMF1, SMF2, SMA1, SMA2, SS1, SS2, PB1, PB2, PMF1, PMF2, PMA1, PMA2, PS1, PS2, SB1Max, SB2Max, SMF1Max, SMF2Max, SMA1Max, SMA2Max, SS1Max, SS2Max, PB1Max, PB2Max, PMF1Max, PMF2Max, PMA1Max, PMA2Max, PS1Max, PS2Max from DataSatelliteSensors as dsm, DataSensor as dm where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and dsm.ComponentID = dm.ID) and Type <> 9001 ORDER BY dm.Type, dm.Name ASC";
                    str3 = "select ComponentID, Name from DataSatelliteComms as dsm, DataComm as dm  where (dsm.ID = " + Conversions.ToString(activeUnit_0.DBID) + " and  dsm.ComponentID = dm.ID)";
                    break;
            }
            bool flag = false;
            if (!(activeUnit_0.IsOperating() & ((((activeUnit_0.IsAircraft | activeUnit_0.IsFacility) | activeUnit_0.IsShip) | activeUnit_0.IsSubmarine) | activeUnit_0.IsSatellite())))
            {
                return;
            }
            if (activeUnit_0.IsAircraft)
            {
                Aircraft aircraft = (Aircraft)activeUnit_0;
                if (aircraft.GetFuelRecsMaxQuantity() != aircraft.GetCurrentFuelQuantity())
                {
                    flag = true;
                }
            }
            else if (!activeUnit_0.IsFacility && !activeUnit_0.IsShip)
            {
            }
            DataTable table2 = new DataTable();
            if (!table2.Columns.Contains("DBID"))
            {
                table2.Columns.Add("DBID", typeof(int));
            }
            if (!table2.Columns.Contains("Name"))
            {
                table2.Columns.Add("Name", typeof(string));
            }
            if (!activeUnit_0.GetSensory().IsObeysEMCON())
            {
                foreach (Sensor sensor in activeUnit_0.GetAllNoneMCMSensors())
                {
                    if (sensor.IsEmmitting())
                    {
                        table2.Rows.Add(new object[] { sensor.DBID, sensor.Name });
                    }
                }
            }
            DataTable dataTable = base2.GetDataTable(str);
            if (!dataTable.Columns.Contains("MountIndex"))
            {
                dataTable.Columns.Add("MountIndex", typeof(int));
            }
            DataTable table4 = null;
            DataTable table5 = null;
            DataTable table6 = null;
            DataTable table7 = null;
            DataTable table8 = null;
            DataTable table9 = null;
            DataTable table10 = null;
            int num2 = 0;
            DataTable expression = null;
            DataTable table12 = null;
            DataTable table13 = null;
            DataTable table14 = null;
            DataTable table15 = null;
            DataTable table16 = null;
            int num3 = dataTable.Rows.Count - 1;
            for (int i = 0; i <= num3; i++)
            {
                dataTable.Rows[i]["MountIndex"] = i;
            }
            DataTable table17 = new DataTable();
            table17.Columns.Add("ID", typeof(int));
            table17.Columns.Add("Name", typeof(string));
            table17.Columns.Add("SB1", typeof(bool));
            table17.Columns.Add("SB2", typeof(bool));
            table17.Columns.Add("SMF1", typeof(bool));
            table17.Columns.Add("SMF2", typeof(bool));
            table17.Columns.Add("SMA1", typeof(bool));
            table17.Columns.Add("SMA2", typeof(bool));
            table17.Columns.Add("SS1", typeof(bool));
            table17.Columns.Add("SS2", typeof(bool));
            table17.Columns.Add("PB1", typeof(bool));
            table17.Columns.Add("PB2", typeof(bool));
            table17.Columns.Add("PMF1", typeof(bool));
            table17.Columns.Add("PMF2", typeof(bool));
            table17.Columns.Add("PMA1", typeof(bool));
            table17.Columns.Add("PMA2", typeof(bool));
            table17.Columns.Add("PS1", typeof(bool));
            table17.Columns.Add("PS2", typeof(bool));
            table17.Columns.Add("Has360Coverage", typeof(bool));
            DataTable table18 = new DataTable();
            table18.Columns.Add("MountID", typeof(int));
            table18.Columns.Add("MountIndex", typeof(int));
            table18.Columns.Add("MountName", typeof(string));
            DataTable table19 = new DataTable();
            table19.Columns.Add("MountID", typeof(int));
            table19.Columns.Add("MountIndex", typeof(int));
            table19.Columns.Add("WeaponID", typeof(int));
            table19.Columns.Add("WeaponQty", typeof(int));
            table19.Columns.Add("WeaponName", typeof(string));
            DataTable table20 = new DataTable();
            table20.Columns.Add("MountID", typeof(int));
            table20.Columns.Add("MountIndex", typeof(int));
            table20.Columns.Add("WeapRecID", typeof(int));
            table20.Columns.Add("WeaponName", typeof(string));
            table20.Columns.Add("WeaponID", typeof(string));
            DataTable table21 = new DataTable();
            table21.Columns.Add("MountID", typeof(int));
            table21.Columns.Add("MountIndex", typeof(int));
            table21.Columns.Add("WeaponID", typeof(int));
            table21.Columns.Add("WeaponName", typeof(string));
            DataTable table22 = new DataTable();
            table22.Columns.Add("MountID", typeof(int));
            table22.Columns.Add("MountIndex", typeof(int));
            table22.Columns.Add("MountName", typeof(string));
            table4 = new DataTable();
            table4.Columns.Add("MountID", typeof(int));
            table4.Columns.Add("MountIndex", typeof(int));
            table4.Columns.Add("WeaponID", typeof(int));
            table4.Columns.Add("WeaponQty", typeof(int));
            table4.Columns.Add("WeaponName", typeof(string));
            table5 = new DataTable();
            table5.Columns.Add("MountID", typeof(int));
            table5.Columns.Add("MountIndex", typeof(int));
            table5.Columns.Add("WeapRecID", typeof(int));
            table5.Columns.Add("WeaponName", typeof(string));
            table5.Columns.Add("WeaponID", typeof(string));
            table6 = new DataTable();
            table6.Columns.Add("MountID", typeof(int));
            table6.Columns.Add("MountIndex", typeof(int));
            table6.Columns.Add("WeaponID", typeof(int));
            table6.Columns.Add("WeaponName", typeof(string));
            table7 = new DataTable();
            table7.Columns.Add("MagID", typeof(int));
            table7.Columns.Add("MagIndex", typeof(int));
            table7.Columns.Add("MagName", typeof(string));
            table8 = new DataTable();
            table8.Columns.Add("MagID", typeof(int));
            table8.Columns.Add("MagIndex", typeof(int));
            table8.Columns.Add("WeaponID", typeof(int));
            table8.Columns.Add("WeaponQty", typeof(int));
            table8.Columns.Add("WeaponName", typeof(string));
            table9 = new DataTable();
            table9.Columns.Add("MagID", typeof(int));
            table9.Columns.Add("MagIndex", typeof(int));
            table9.Columns.Add("WeapRecID", typeof(int));
            table9.Columns.Add("WeaponName", typeof(string));
            table9.Columns.Add("WeaponID", typeof(string));
            table10 = new DataTable();
            table10.Columns.Add("MagID", typeof(int));
            table10.Columns.Add("MagIndex", typeof(int));
            table10.Columns.Add("WeaponID", typeof(int));
            table10.Columns.Add("WeaponName", typeof(string));
            int num5 = dataTable.Rows.Count - 1;
            Mount[] mounts = activeUnit_0.m_Mounts;
            int index = 0;
            bool flag2 = false;
            while (index < mounts.Length)
            {
                Mount mount = mounts[index];
                flag2 = false;
                num7 = 0;
                IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
                try
                {
                    DataRow current;
                    while (enumerator2.MoveNext())
                    {
                        current = (DataRow)enumerator2.Current;
                        if (((((((((((((((((Conversions.ToInteger(current["ComponentID"]) == mount.DBID) & (mount.coverageArc.SB1 == Conversions.ToBoolean(current["SB1"]))) & (mount.coverageArc.SB2 == Conversions.ToBoolean(current["SB2"]))) & (mount.coverageArc.SMF1 == Conversions.ToBoolean(current["SMF1"]))) & (mount.coverageArc.SMF2 == Conversions.ToBoolean(current["SMF2"]))) & (mount.coverageArc.SMA1 == Conversions.ToBoolean(current["SMA1"]))) & (mount.coverageArc.SMA2 == Conversions.ToBoolean(current["SMA2"]))) & (mount.coverageArc.SS1 == Conversions.ToBoolean(current["SS1"]))) & (mount.coverageArc.SS2 == Conversions.ToBoolean(current["SS2"]))) & (mount.coverageArc.PB1 == Conversions.ToBoolean(current["PB1"]))) & (mount.coverageArc.PB2 == Conversions.ToBoolean(current["PB2"]))) & (mount.coverageArc.PMF1 == Conversions.ToBoolean(current["PMF1"]))) & (mount.coverageArc.PMF2 == Conversions.ToBoolean(current["PMF2"]))) & (mount.coverageArc.PMA1 == Conversions.ToBoolean(current["PMA1"]))) & (mount.coverageArc.PMA2 == Conversions.ToBoolean(current["PMA2"]))) & (mount.coverageArc.PS1 == Conversions.ToBoolean(current["PS1"]))) & (mount.coverageArc.PS2 == Conversions.ToBoolean(current["PS2"])))
                        {
                            goto Label_0ECF;
                        }
                    }
                    goto Label_0F0F;
                Label_0ECF:
                    num7 = Conversions.ToInteger(current["MountIndex"].ToString());
                    current.Delete();
                    flag2 = true;
                }
                finally
                {
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
            Label_0F0F:
                if (!flag2 && !flag2)
                {
                    num7 = num5 + 1;
                    num5++;
                }
                if (!flag2)
                {
                    table17.Rows.Add(new object[] {
                mount.DBID, mount.Name, mount.coverageArc.SB1, mount.coverageArc.SB2, mount.coverageArc.SMF1, mount.coverageArc.SMF2, mount.coverageArc.SMA1, mount.coverageArc.SMA2, mount.coverageArc.SS1, mount.coverageArc.SS2, mount.coverageArc.PB1, mount.coverageArc.PB2, mount.coverageArc.PMF1, mount.coverageArc.PMF2, mount.coverageArc.PMA1, mount.coverageArc.PMA2,
                mount.coverageArc.PS1, mount.coverageArc.PS2, mount.coverageArc.Is360Coverage()
            });
                }
                str5 = "select dwr.ComponentID, DefaultLoad, MaxLoad, Multiple, Name from DataWeaponRecord dwr, DataMountWeapons dmw, DataWeapon dw where dmw.ID = " + Conversions.ToString(mount.DBID) + " and  dmw.ComponentID = dwr.ID and dw.ID = dwr.ComponentID;";
                table = base2.GetDataTable(str5);
                flag3 = false;
                using (IEnumerator<WeaponRec> enumerator3 = mount.GetWeaponRecCollection().GetEnumerator())
                {
                Label_1105:
                    if (!enumerator3.MoveNext())
                    {
                        goto Label_1C0C;
                    }
                    rec = enumerator3.Current;
                    flag4 = false;
                    IEnumerator enumerator4 = table.Rows.GetEnumerator();
                    try
                    {
                        DataRow row2;
                        while (enumerator4.MoveNext())
                        {
                            row2 = (DataRow)enumerator4.Current;
                            num9 = Conversions.ToInteger(row2["ComponentID"]);
                            name = Conversions.ToString(row2["Name"]);
                            num10 = Conversions.ToInteger(row2["DefaultLoad"]);
                            int num11 = Conversions.ToInteger(row2["MaxLoad"]);
                            int num12 = Conversions.ToInteger(row2["Multiple"]);
                            if (((num9 == rec.WeapID) & (num11 == rec.MaxLoad)) & (num12 == rec.Multiple))
                            {
                                goto Label_11D4;
                            }
                        }
                        goto Label_1BEF;
                    Label_11D4:
                        row2.Delete();
                        flag4 = true;
                        if (num10 != rec.GetCurrentLoad())
                        {
                            table19.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), name });
                            flag3 = true;
                        }
                        goto Label_1BEF;
                    }
                    finally
                    {
                        if (enumerator4 is IDisposable)
                        {
                            (enumerator4 as IDisposable).Dispose();
                        }
                    }
                Label_126C:
                    rec.SetTimeToFire();
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.GetCurrentLoad()) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and ROF = " + Conversions.ToString(rec.TimeToFire) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if (table23.Rows.Count > 0)
                    {
                        DataRow row3 = table23.Rows[0];
                        num13 = Conversions.ToInteger(row3["ID"]);
                        name = Conversions.ToString(row3["Name"]);
                        table20.Rows.Add(new object[] { mount.DBID, num7, num13, name, rec.WeapID });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.DefaultLoad) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and ROF = " + Conversions.ToString(rec.TimeToFire) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row4 = table23.Rows[0];
                        num13 = Conversions.ToInteger(row4["ID"]);
                        name = Conversions.ToString(row4["Name"]);
                        table20.Rows.Add(new object[] { mount.DBID, num7, num13, name, rec.WeapID });
                        table19.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), name });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.GetCurrentLoad()) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row5 = table23.Rows[0];
                        num13 = Conversions.ToInteger(row5["ID"]);
                        name = Conversions.ToString(row5["Name"]);
                        table20.Rows.Add(new object[] { mount.DBID, num7, num13, name, rec.WeapID });
                        table19.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), name });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.DefaultLoad) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row6 = table23.Rows[0];
                        num13 = Conversions.ToInteger(row6["ID"]);
                        name = Conversions.ToString(row6["Name"]);
                        table20.Rows.Add(new object[] { mount.DBID, num7, num13, name, rec.WeapID });
                        table19.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), name });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row7 = table23.Rows[0];
                        num13 = Conversions.ToInteger(row7["ID"]);
                        name = Conversions.ToString(row7["Name"]);
                        table20.Rows.Add(new object[] { mount.DBID, num7, num13, name, rec.WeapID });
                        table19.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), name });
                        flag4 = true;
                        flag3 = true;
                    }
                    if ((!flag4 && Information.IsNothing(rec.RecID)) && (rec.MaxLoad == 0x2710))
                    {
                        num13 = 0;
                        name = "";
                        if (!Information.IsNothing(rec.GetWeapon(scenario_0)))
                        {
                            name = rec.GetWeapon(scenario_0).Name;
                        }
                        else
                        {
                            name = "ERROR! Name not found";
                        }
                        table20.Rows.Add(new object[] { mount.DBID, num7, num13, name, rec.WeapID });
                        table19.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), name });
                        flag4 = true;
                        flag3 = true;
                    }
                    if (!flag4)
                    {
                        str7 = "WARNING: Mount " + mount.Name + " (ID: " + Conversions.ToString(mount.DBID) + ") has a new weapons added to it, however a good match could not be found in the database! Weapon ID: " + Conversions.ToString(rec.WeapID) + " Default Load: " + Conversions.ToString(rec.DefaultLoad) + " Max Load: " + Conversions.ToString(rec.MaxLoad) + " Multiple: " + Conversions.ToString(rec.Multiple);
                        streamWriter_0 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR INI template log file.txt");
                        streamWriter_0.Write("\r\n      " + str7);
                        streamWriter_0.Close();
                        num2++;
                    }
                    goto Label_1105;
                Label_1BEF:
                    if (flag4)
                    {
                        goto Label_1105;
                    }
                    goto Label_126C;
                }
            Label_1C0C:
                if (table.Rows.Count > 0)
                {
                    IEnumerator enumerator5 = table.Rows.GetEnumerator();
                    try
                    {
                        while (enumerator5.MoveNext())
                        {
                            DataRow row8 = (DataRow)enumerator5.Current;
                            num9 = Conversions.ToInteger(row8["ComponentID"]);
                            name = Conversions.ToString(row8["Name"]);
                            table21.Rows.Add(new object[] { mount.DBID, num7, num9, name });
                        }
                    }
                    finally
                    {
                        if (enumerator5 is IDisposable)
                        {
                            (enumerator5 as IDisposable).Dispose();
                        }
                    }
                    flag3 = true;
                }
                str5 = "select dwr.ComponentID, DefaultLoad, MaxLoad, Multiple, Name from DataWeaponRecord dwr, DataMountMagazineWeapons dmw, DataWeapon dw where dmw.ID = " + Conversions.ToString(mount.DBID) + " and  dmw.ComponentID = dwr.ID and dw.ID = dwr.ComponentID;";
                table = base2.GetDataTable(str5);
                flag2 = false;
                using (IEnumerator<WeaponRec> enumerator6 = mount.GetMagazineForMount().GetWeaponRecCollection().GetEnumerator())
                {
                Label_1D17:
                    if (!enumerator6.MoveNext())
                    {
                        goto Label_2817;
                    }
                    rec = enumerator6.Current;
                    flag4 = false;
                    IEnumerator enumerator7 = table.Rows.GetEnumerator();
                    try
                    {
                        DataRow row9;
                        while (enumerator7.MoveNext())
                        {
                            row9 = (DataRow)enumerator7.Current;
                            num14 = Conversions.ToInteger(row9["ComponentID"]);
                            str8 = Conversions.ToString(row9["Name"]);
                            num15 = Conversions.ToInteger(row9["DefaultLoad"]);
                            int num16 = Conversions.ToInteger(row9["MaxLoad"]);
                            int num17 = Conversions.ToInteger(row9["Multiple"]);
                            if (((num14 == rec.WeapID) & (num16 == rec.MaxLoad)) & (num17 == rec.Multiple))
                            {
                                goto Label_1DE6;
                            }
                        }
                        goto Label_27FA;
                    Label_1DE6:
                        row9.Delete();
                        flag4 = true;
                        if (num15 != rec.GetCurrentLoad())
                        {
                            table4.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), str8 });
                            flag3 = true;
                        }
                        goto Label_27FA;
                    }
                    finally
                    {
                        if (enumerator7 is IDisposable)
                        {
                            (enumerator7 as IDisposable).Dispose();
                        }
                    }
                Label_1E7E:
                    rec.SetTimeToFire();
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.GetCurrentLoad()) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and ROF = " + Conversions.ToString(rec.TimeToFire) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if (table23.Rows.Count > 0)
                    {
                        DataRow row10 = table23.Rows[0];
                        num18 = Conversions.ToInteger(row10["ID"]);
                        str8 = Conversions.ToString(row10["Name"]);
                        table5.Rows.Add(new object[] { mount.DBID, num7, num18, str8, rec.WeapID });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.DefaultLoad) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and ROF = " + Conversions.ToString(rec.TimeToFire) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row11 = table23.Rows[0];
                        num18 = Conversions.ToInteger(row11["ID"]);
                        str8 = Conversions.ToString(row11["Name"]);
                        table5.Rows.Add(new object[] { mount.DBID, num7, num18, str8, rec.WeapID });
                        table4.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), str8 });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.GetCurrentLoad()) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row12 = table23.Rows[0];
                        num18 = Conversions.ToInteger(row12["ID"]);
                        str8 = Conversions.ToString(row12["Name"]);
                        table5.Rows.Add(new object[] { mount.DBID, num7, num18, str8, rec.WeapID });
                        table4.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), str8 });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.DefaultLoad) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row13 = table23.Rows[0];
                        num18 = Conversions.ToInteger(row13["ID"]);
                        str8 = Conversions.ToString(row13["Name"]);
                        table5.Rows.Add(new object[] { mount.DBID, num7, num18, str8, rec.WeapID });
                        table4.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), str8 });
                        flag4 = true;
                        flag3 = true;
                    }
                    str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                    table23 = base2.GetDataTable(str5);
                    if ((table23.Rows.Count > 0) & !flag4)
                    {
                        DataRow row14 = table23.Rows[0];
                        num18 = Conversions.ToInteger(row14["ID"]);
                        str8 = Conversions.ToString(row14["Name"]);
                        table5.Rows.Add(new object[] { mount.DBID, num7, num18, str8, rec.WeapID });
                        table4.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), str8 });
                        flag4 = true;
                        flag3 = true;
                    }
                    if ((!flag4 && Information.IsNothing(rec.RecID)) && (rec.MaxLoad == 0x2710))
                    {
                        num18 = 0;
                        if (!Information.IsNothing(rec.GetWeapon(scenario_0)))
                        {
                            str8 = rec.GetWeapon(scenario_0).Name;
                        }
                        else
                        {
                            str8 = "ERROR! Name not found";
                        }
                        table5.Rows.Add(new object[] { mount.DBID, num7, num18, str8, rec.WeapID });
                        table4.Rows.Add(new object[] { mount.DBID, num7, rec.WeapID, rec.GetCurrentLoad(), str8 });
                        flag4 = true;
                        flag3 = true;
                    }
                    if (!flag4)
                    {
                        str7 = "WARNING: Mount " + mount.Name + " (ID: " + Conversions.ToString(mount.DBID) + ") has a new mount magazine weapons added to it, however a good match could not be found in the database! Weapon ID: " + Conversions.ToString(rec.WeapID) + " Default Load: " + Conversions.ToString(rec.DefaultLoad) + " Max Load: " + Conversions.ToString(rec.MaxLoad) + " Multiple: " + Conversions.ToString(rec.Multiple);
                        streamWriter_0 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR INI template log file.txt");
                        streamWriter_0.Write("\r\n      " + str7);
                        streamWriter_0.Close();
                        num2++;
                    }
                    goto Label_1D17;
                Label_27FA:
                    if (flag4)
                    {
                        goto Label_1D17;
                    }
                    goto Label_1E7E;
                }
            Label_2817:
                if (table.Rows.Count > 0)
                {
                    IEnumerator enumerator8 = table.Rows.GetEnumerator();
                    try
                    {
                        while (enumerator8.MoveNext())
                        {
                            DataRow row15 = (DataRow)enumerator8.Current;
                            num14 = Conversions.ToInteger(row15["ComponentID"]);
                            str8 = Conversions.ToString(row15["Name"]);
                            table6.Rows.Add(new object[] { mount.DBID, num7, num14, str8 });
                        }
                    }
                    finally
                    {
                        if (enumerator8 is IDisposable)
                        {
                            (enumerator8 as IDisposable).Dispose();
                        }
                    }
                    flag3 = true;
                }
                if (flag3)
                {
                    table18.Rows.Add(new object[] { mount.DBID, num7, mount.Name });
                }
                index++;
            }
            int num19 = 0;
            if (!Information.IsNothing(activeUnit_0.m_OnboardCargos))
            {
                num19 = activeUnit_0.m_OnboardCargos.Count<Cargo>();
            }
            if ((activeUnit_0.IsFacility | activeUnit_0.IsShip) | activeUnit_0.IsSubmarine)
            {
                expression = base2.GetDataTable(str4);
                if (!expression.Columns.Contains("MagIndex"))
                {
                    expression.Columns.Add("MagIndex", typeof(int));
                }
                int num20 = expression.Rows.Count - 1;
                for (int k = 0; k <= num20; k++)
                {
                    expression.Rows[k]["MagIndex"] = k;
                }
                table12 = new DataTable();
                table12.Columns.Add("ID", typeof(int));
                table12.Columns.Add("Name", typeof(string));
                int num22 = expression.Rows.Count - 1;
                foreach (Magazine magazine2 in activeUnit_0.GetMagazines())
                {
                    bool flag5 = false;
                    num24 = 0;
                    IEnumerator enumerator9 = expression.Rows.GetEnumerator();
                    try
                    {
                        DataRow row16;
                        while (enumerator9.MoveNext())
                        {
                            row16 = (DataRow)enumerator9.Current;
                            if (Conversions.ToInteger(row16["ComponentID"]) == magazine2.DBID)
                            {
                                goto Label_2AA7;
                            }
                        }
                        goto Label_2AE7;
                    Label_2AA7:
                        num24 = Conversions.ToInteger(row16["MagIndex"].ToString());
                        row16.Delete();
                        flag5 = true;
                    }
                    finally
                    {
                        if (enumerator9 is IDisposable)
                        {
                            (enumerator9 as IDisposable).Dispose();
                        }
                    }
                Label_2AE7:
                    if (!flag5 && !flag2)
                    {
                        num24 = num22 + 1;
                        num22++;
                    }
                    if (!flag5)
                    {
                        table12.Rows.Add(new object[] { magazine2.DBID, magazine2.Name });
                    }
                    str5 = "select dwr.ComponentID, DefaultLoad, MaxLoad, Multiple, Name from DataWeaponRecord dwr, DataMagazineWeapons dmw, DataWeapon dw where dmw.ID = " + Conversions.ToString(magazine2.DBID) + " and  dmw.ComponentID = dwr.ID and dw.ID = dwr.ComponentID;";
                    table = base2.GetDataTable(str5);
                    flag3 = false;
                    using (IEnumerator<WeaponRec> enumerator10 = magazine2.GetWeaponRecCollection().GetEnumerator())
                    {
                    Label_2B6A:
                        if (!enumerator10.MoveNext())
                        {
                            goto Label_366A;
                        }
                        rec = enumerator10.Current;
                        flag4 = false;
                        IEnumerator enumerator11 = table.Rows.GetEnumerator();
                        try
                        {
                            DataRow row17;
                            while (enumerator11.MoveNext())
                            {
                                row17 = (DataRow)enumerator11.Current;
                                num26 = Conversions.ToInteger(row17["ComponentID"]);
                                str9 = Conversions.ToString(row17["Name"]);
                                num27 = Conversions.ToInteger(row17["DefaultLoad"]);
                                int num28 = Conversions.ToInteger(row17["MaxLoad"]);
                                int num29 = Conversions.ToInteger(row17["Multiple"]);
                                if (((num26 == rec.WeapID) & (num28 == rec.MaxLoad)) & (num29 == rec.Multiple))
                                {
                                    goto Label_2C39;
                                }
                            }
                            goto Label_364D;
                        Label_2C39:
                            row17.Delete();
                            flag4 = true;
                            if (num27 != rec.GetCurrentLoad())
                            {
                                table8.Rows.Add(new object[] { magazine2.DBID, num24, rec.WeapID, rec.GetCurrentLoad(), str9 });
                                flag3 = true;
                            }
                            goto Label_364D;
                        }
                        finally
                        {
                            if (enumerator11 is IDisposable)
                            {
                                (enumerator11 as IDisposable).Dispose();
                            }
                        }
                    Label_2CD1:
                        rec.SetTimeToFire();
                        str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.GetCurrentLoad()) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and ROF = " + Conversions.ToString(rec.TimeToFire) + " and dw.ID = dwr.ComponentID;";
                        table23 = base2.GetDataTable(str5);
                        if (table23.Rows.Count > 0)
                        {
                            DataRow row18 = table23.Rows[0];
                            num30 = Conversions.ToInteger(row18["ID"]);
                            str9 = Conversions.ToString(row18["Name"]);
                            table9.Rows.Add(new object[] { magazine2.DBID, num24, num30, str9, rec.WeapID });
                            flag4 = true;
                            flag3 = true;
                        }
                        str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.DefaultLoad) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and ROF = " + Conversions.ToString(rec.TimeToFire) + " and dw.ID = dwr.ComponentID;";
                        table23 = base2.GetDataTable(str5);
                        if ((table23.Rows.Count > 0) & !flag4)
                        {
                            DataRow row19 = table23.Rows[0];
                            num30 = Conversions.ToInteger(row19["ID"]);
                            str9 = Conversions.ToString(row19["Name"]);
                            table9.Rows.Add(new object[] { magazine2.DBID, num24, num30, str9, rec.WeapID });
                            table8.Rows.Add(new object[] { magazine2.DBID, num24, rec.WeapID, rec.GetCurrentLoad(), str9 });
                            flag4 = true;
                            flag3 = true;
                        }
                        str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.GetCurrentLoad()) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                        table23 = base2.GetDataTable(str5);
                        if ((table23.Rows.Count > 0) & !flag4)
                        {
                            DataRow row20 = table23.Rows[0];
                            num30 = Conversions.ToInteger(row20["ID"]);
                            str9 = Conversions.ToString(row20["Name"]);
                            table9.Rows.Add(new object[] { magazine2.DBID, num24, num30, str9, rec.WeapID });
                            table8.Rows.Add(new object[] { magazine2.DBID, num24, rec.WeapID, rec.GetCurrentLoad(), str9 });
                            flag4 = true;
                            flag3 = true;
                        }
                        str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and DefaultLoad = " + Conversions.ToString(rec.DefaultLoad) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                        table23 = base2.GetDataTable(str5);
                        if ((table23.Rows.Count > 0) & !flag4)
                        {
                            DataRow row21 = table23.Rows[0];
                            num30 = Conversions.ToInteger(row21["ID"]);
                            str9 = Conversions.ToString(row21["Name"]);
                            table9.Rows.Add(new object[] { magazine2.DBID, num24, num30, str9, rec.WeapID });
                            table8.Rows.Add(new object[] { magazine2.DBID, num24, rec.WeapID, rec.GetCurrentLoad(), str9 });
                            flag4 = true;
                            flag3 = true;
                        }
                        str5 = "select dwr.ID, dw.Name from DataWeaponRecord dwr, DataWeapon dw where dwr.ComponentID = " + Conversions.ToString(rec.WeapID) + " and MaxLoad = " + Conversions.ToString(rec.MaxLoad) + " and Multiple = " + Conversions.ToString(rec.Multiple) + " and dw.ID = dwr.ComponentID;";
                        table23 = base2.GetDataTable(str5);
                        if ((table23.Rows.Count > 0) & !flag4)
                        {
                            DataRow row22 = table23.Rows[0];
                            num30 = Conversions.ToInteger(row22["ID"]);
                            str9 = Conversions.ToString(row22["Name"]);
                            table9.Rows.Add(new object[] { magazine2.DBID, num24, num30, str9, rec.WeapID });
                            table8.Rows.Add(new object[] { magazine2.DBID, num24, rec.WeapID, rec.GetCurrentLoad(), str9 });
                            flag4 = true;
                            flag3 = true;
                        }
                        if ((!flag4 && Information.IsNothing(rec.RecID)) && (rec.MaxLoad == 0x2710))
                        {
                            num30 = 0;
                            if (!Information.IsNothing(rec.GetWeapon(scenario_0)))
                            {
                                str9 = rec.GetWeapon(scenario_0).Name;
                            }
                            else
                            {
                                str9 = "ERROR! Name not found";
                            }
                            table9.Rows.Add(new object[] { magazine2.DBID, num24, num30, str9, rec.WeapID });
                            table8.Rows.Add(new object[] { magazine2.DBID, num24, rec.WeapID, rec.GetCurrentLoad(), str9 });
                            flag4 = true;
                            flag3 = true;
                        }
                        if (!flag4)
                        {
                            str7 = "WARNING: Magazine " + magazine2.Name + " (ID: " + Conversions.ToString(magazine2.DBID) + ") has a new weapons added to it, however a good match could not be found in the database! Weapon ID: " + Conversions.ToString(rec.WeapID) + " Default Load: " + Conversions.ToString(rec.DefaultLoad) + " Max Load: " + Conversions.ToString(rec.MaxLoad) + " Multiple: " + Conversions.ToString(rec.Multiple);
                            streamWriter_0 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR INI template log file.txt");
                            streamWriter_0.Write("\r\n      " + str7);
                            streamWriter_0.Close();
                            num2++;
                        }
                        goto Label_2B6A;
                    Label_364D:
                        if (flag4)
                        {
                            goto Label_2B6A;
                        }
                        goto Label_2CD1;
                    }
                Label_366A:
                    if (table.Rows.Count > 0)
                    {
                        IEnumerator enumerator12 = table.Rows.GetEnumerator();
                        try
                        {
                            while (enumerator12.MoveNext())
                            {
                                DataRow row23 = (DataRow)enumerator12.Current;
                                num26 = Conversions.ToInteger(row23["ComponentID"]);
                                str9 = Conversions.ToString(row23["Name"]);
                                table10.Rows.Add(new object[] { magazine2.DBID, num24, num26, str9 });
                            }
                        }
                        finally
                        {
                            if (enumerator12 is IDisposable)
                            {
                                (enumerator12 as IDisposable).Dispose();
                            }
                        }
                        flag3 = true;
                    }
                    if (flag3)
                    {
                        table7.Rows.Add(new object[] { magazine2.DBID, num24, magazine2.Name });
                    }
                }
            }
            else
            {
                if (!Information.IsNothing(expression))
                {
                    expression.Rows.Clear();
                }
                if (!Information.IsNothing(table12))
                {
                    table12.Rows.Clear();
                }
            }
            table13 = base2.GetDataTable(str2);
            if (!table13.Columns.Contains("SensorIndex"))
            {
                table13.Columns.Add("SensorIndex", typeof(int));
            }
            int num31 = table13.Rows.Count - 1;
            for (int j = 0; j <= num31; j++)
            {
                table13.Rows[j]["SensorIndex"] = j;
            }
            table14 = new DataTable();
            table14.Columns.Add("ID", typeof(int));
            table14.Columns.Add("Name", typeof(string));
            table14.Columns.Add("Type", typeof(int));
            table14.Columns.Add("SB1", typeof(bool));
            table14.Columns.Add("SB2", typeof(bool));
            table14.Columns.Add("SMF1", typeof(bool));
            table14.Columns.Add("SMF2", typeof(bool));
            table14.Columns.Add("SMA1", typeof(bool));
            table14.Columns.Add("SMA2", typeof(bool));
            table14.Columns.Add("SS1", typeof(bool));
            table14.Columns.Add("SS2", typeof(bool));
            table14.Columns.Add("PB1", typeof(bool));
            table14.Columns.Add("PB2", typeof(bool));
            table14.Columns.Add("PMF1", typeof(bool));
            table14.Columns.Add("PMF2", typeof(bool));
            table14.Columns.Add("PMA1", typeof(bool));
            table14.Columns.Add("PMA2", typeof(bool));
            table14.Columns.Add("PS1", typeof(bool));
            table14.Columns.Add("PS2", typeof(bool));
            table14.Columns.Add("SB1Max", typeof(bool));
            table14.Columns.Add("SB2Max", typeof(bool));
            table14.Columns.Add("SMF1Max", typeof(bool));
            table14.Columns.Add("SMF2Max", typeof(bool));
            table14.Columns.Add("SMA1Max", typeof(bool));
            table14.Columns.Add("SMA2Max", typeof(bool));
            table14.Columns.Add("SS1Max", typeof(bool));
            table14.Columns.Add("SS2Max", typeof(bool));
            table14.Columns.Add("PB1Max", typeof(bool));
            table14.Columns.Add("PB2Max", typeof(bool));
            table14.Columns.Add("PMF1Max", typeof(bool));
            table14.Columns.Add("PMF2Max", typeof(bool));
            table14.Columns.Add("PMA1Max", typeof(bool));
            table14.Columns.Add("PMA2Max", typeof(bool));
            table14.Columns.Add("PS1Max", typeof(bool));
            table14.Columns.Add("PS2Max", typeof(bool));
            table14.Columns.Add("Has360Coverage", typeof(bool));
            table14.Columns.Add("Has360CoverageMax", typeof(bool));
            Sensor[] noneMCMSensors = activeUnit_0.GetNoneMCMSensors();
            int num33 = 0;
        Label_3C51:
            if (num33 >= noneMCMSensors.Length)
            {
                int num42;
                table15 = base2.GetDataTable(str3);
                if (!table15.Columns.Contains("CommIndex"))
                {
                    table15.Columns.Add("CommIndex", typeof(int));
                }
                int num39 = table15.Rows.Count - 1;
                for (int m = 0; m <= num39; m++)
                {
                    table15.Rows[m]["CommIndex"] = m;
                }
                table16 = new DataTable();
                table16.Columns.Add("ID", typeof(int));
                table16.Columns.Add("Name", typeof(string));
                foreach (CommDevice device in activeUnit_0.GetCommDevices())
                {
                    bool flag7 = false;
                    IEnumerator enumerator16 = table15.Rows.GetEnumerator();
                    try
                    {
                        DataRow row26;
                        while (enumerator16.MoveNext())
                        {
                            row26 = (DataRow)enumerator16.Current;
                            if (Conversions.ToInteger(row26["ComponentID"]) == device.DBID)
                            {
                                goto Label_4BB0;
                            }
                        }
                        goto Label_4BD8;
                    Label_4BB0:
                        row26.Delete();
                        flag7 = true;
                    }
                    finally
                    {
                        if (enumerator16 is IDisposable)
                        {
                            (enumerator16 as IDisposable).Dispose();
                        }
                    }
                Label_4BD8:
                    if (!flag7)
                    {
                        switch (activeUnit_0.GetUnitType())
                        {
                            case GlobalVariables.ActiveUnitType.Aircraft:
                                str2 = "SELECT ComponentID from DataMountComms where  ID in (Select ComponentID from DataAircraftMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                                break;

                            case GlobalVariables.ActiveUnitType.Ship:
                                str2 = "SELECT ComponentID from DataMountComms where  ID in (Select ComponentID from DataShipMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                                break;

                            case GlobalVariables.ActiveUnitType.Submarine:
                                str2 = "SELECT ComponentID from DataMountComms where  ID in (Select ComponentID from DataSubmarineMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                                break;

                            case GlobalVariables.ActiveUnitType.Facility:
                                str2 = "SELECT ComponentID from DataMountComms where  ID in (Select ComponentID from DataFacilityMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                                break;

                            case GlobalVariables.ActiveUnitType.Satellite:
                                str2 = "SELECT ComponentID from DataMountComms where  ID in (Select ComponentID from DataSatelliteMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                                break;
                        }
                        IEnumerator enumerator17 = base2.GetDataTable(str2).Rows.GetEnumerator();
                        try
                        {
                            while (enumerator17.MoveNext())
                            {
                                num42 = Conversions.ToInteger(((DataRow)enumerator17.Current)["ComponentID"]);
                                if (device.DBID == num42)
                                {
                                    goto Label_4CF2;
                                }
                            }
                            goto Label_4D13;
                        Label_4CF2:
                            flag7 = true;
                        }
                        finally
                        {
                            if (enumerator17 is IDisposable)
                            {
                                (enumerator17 as IDisposable).Dispose();
                            }
                        }
                    }
                Label_4D13:
                    if (!flag7)
                    {
                        table16.Rows.Add(new object[] { device.DBID, device.Name });
                    }
                }
                if (((((((num19 > 0) || flag) || ((table2.Rows.Count > 0) || (dataTable.Rows.Count > 0))) || ((table17.Rows.Count > 0) || (!Information.IsNothing(expression) && (expression.Rows.Count > 0)))) || (((!Information.IsNothing(table12) && (table12.Rows.Count > 0)) || ((table13.Rows.Count > 0) || (table14.Rows.Count > 0))) || (((table15.Rows.Count > 0) || (table16.Rows.Count > 0)) || ((table21.Rows.Count > 0) || (table20.Rows.Count > 0))))) || ((((table19.Rows.Count > 0) || (table6.Rows.Count > 0)) || ((table5.Rows.Count > 0) || (table4.Rows.Count > 0))) || ((table10.Rows.Count > 0) || (table9.Rows.Count > 0)))) || (table8.Rows.Count > 0))
                {
                    int num34;
                    int count;
                    string str10;
                    DataRow row36;
                    string str12;
                    string str13;
                    xmlWriter_0.WriteStartElement("Unit_" + activeUnit_0.GetGuid());
                    xmlWriter_0.WriteComment(activeUnit_0.Name + " (" + activeUnit_0.UnitClass + " [" + Conversions.ToString(activeUnit_0.DBID) + "])");
                    foreach (Cargo cargo in activeUnit_0.m_OnboardCargos)
                    {
                        xmlWriter_0.WriteStartElement("CargoAdd");
                        HashSet<string> set = null;
                        cargo.Save(ref xmlWriter_0, ref set, activeUnit_0.m_Scenario);
                        xmlWriter_0.WriteEndElement();
                    }
                    if (flag)
                    {
                        if (activeUnit_0.IsAircraft)
                        {
                            float currentFuelQuantity = ((Aircraft)activeUnit_0).GetCurrentFuelQuantity();
                            xmlWriter_0.WriteStartElement("SetFuel_" + Conversions.ToString(currentFuelQuantity));
                            xmlWriter_0.WriteEndElement();
                        }
                        else if (!activeUnit_0.IsFacility && !activeUnit_0.IsShip)
                        {
                        }
                    }
                    if (table17.Rows.Count > 0)
                    {
                        int num45 = table17.Rows.Count - 1;
                        for (int n = 0; n <= num45; n++)
                        {
                            row25 = table17.Rows[n];
                            num8 = Conversions.ToInteger(row25["ID"].ToString());
                            str10 = Conversions.ToString(row25["Name"]);
                            xmlWriter_0.WriteStartElement("MountAdd_" + Conversions.ToString(num8));
                            xmlWriter_0.WriteComment(str10);
                            str7 = SaveCoverageData(xmlWriter_0, false, row25, activeUnit_0, str10);
                            if (str7 != "")
                            {
                                streamWriter_0 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR INI template log file.txt");
                                streamWriter_0.Write("\r\n      " + str7);
                                streamWriter_0.Close();
                                num2++;
                            }
                        }
                    }
                    if (table18.Rows.Count > 0)
                    {
                        int num47 = table18.Rows.Count - 1;
                        for (int num48 = 0; num48 <= num47; num48++)
                        {
                            int num52;
                            row25 = table18.Rows[num48];
                            num8 = Conversions.ToInteger(row25["MountID"].ToString());
                            num7 = Conversions.ToInteger(row25["MountIndex"].ToString());
                            str10 = Conversions.ToString(row25["MountName"]);
                            xmlWriter_0.WriteStartElement("Mount_" + Conversions.ToString((int)(num7 + 1)) + "_" + Conversions.ToString(num8));
                            xmlWriter_0.WriteComment(str10);
                            if (table21.Rows.Count > 0)
                            {
                                int num49 = table21.Rows.Count - 1;
                                for (int num50 = 0; num50 <= num49; num50++)
                                {
                                    row25 = table21.Rows[num50];
                                    int num51 = Conversions.ToInteger(row25["MountID"].ToString());
                                    num52 = Conversions.ToInteger(row25["MountIndex"].ToString());
                                    num9 = Conversions.ToInteger(row25["WeaponID"].ToString());
                                    name = Conversions.ToString(row25["WeaponName"]);
                                    if ((num51 == num8) & (num52 == num7))
                                    {
                                        xmlWriter_0.WriteStartElement("WeaponRemove_" + Conversions.ToString(num9));
                                        xmlWriter_0.WriteEndElement();
                                        xmlWriter_0.WriteComment(name);
                                    }
                                }
                            }
                            if (table20.Rows.Count > 0)
                            {
                                int num53 = table20.Rows.Count - 1;
                                for (int num54 = 0; num54 <= num53; num54++)
                                {
                                    row25 = table20.Rows[num54];
                                    int num55 = Conversions.ToInteger(row25["MountID"].ToString());
                                    num52 = Conversions.ToInteger(row25["MountIndex"].ToString());
                                    num13 = Conversions.ToInteger(row25["WeapRecID"].ToString());
                                    name = Conversions.ToString(row25["WeaponName"]);
                                    num9 = Conversions.ToInteger(row25["WeaponID"].ToString());
                                    if ((num55 == num8) & (num52 == num7))
                                    {
                                        xmlWriter_0.WriteStartElement("WeaponRecAdd_" + Conversions.ToString(num13) + "_" + Conversions.ToString(num9));
                                        xmlWriter_0.WriteEndElement();
                                        xmlWriter_0.WriteComment(name);
                                    }
                                }
                            }
                            if (table19.Rows.Count > 0)
                            {
                                int num56 = table19.Rows.Count - 1;
                                for (int num57 = 0; num57 <= num56; num57++)
                                {
                                    row25 = table19.Rows[num57];
                                    int num58 = Conversions.ToInteger(row25["MountID"].ToString());
                                    num52 = Conversions.ToInteger(row25["MountIndex"].ToString());
                                    num9 = Conversions.ToInteger(row25["WeaponID"].ToString());
                                    num10 = Conversions.ToInteger(row25["WeaponQty"].ToString());
                                    name = Conversions.ToString(row25["WeaponName"]);
                                    if ((num58 == num8) & (num52 == num7))
                                    {
                                        xmlWriter_0.WriteStartElement("WeaponEdit_" + Conversions.ToString(num9) + "_" + Conversions.ToString(num10));
                                        xmlWriter_0.WriteEndElement();
                                        xmlWriter_0.WriteComment(name);
                                    }
                                }
                            }
                            if (((table6.Rows.Count > 0) | (table5.Rows.Count > 0)) | (table4.Rows.Count > 0))
                            {
                                int num61;
                                int num62;
                                xmlWriter_0.WriteStartElement("MountMag");
                                if (table6.Rows.Count > 0)
                                {
                                    int num59 = table6.Rows.Count - 1;
                                    for (int num60 = 0; num60 <= num59; num60++)
                                    {
                                        DataRow row27 = table6.Rows[num60];
                                        num61 = Conversions.ToInteger(row27["MountID"].ToString());
                                        num62 = Conversions.ToInteger(row27["MountIndex"].ToString());
                                        num14 = Conversions.ToInteger(row27["WeaponID"].ToString());
                                        str8 = Conversions.ToString(row27["WeaponName"]);
                                        if ((num61 == num8) & (num62 == num7))
                                        {
                                            xmlWriter_0.WriteStartElement("WeaponRemove_" + Conversions.ToString(num14));
                                            xmlWriter_0.WriteEndElement();
                                            xmlWriter_0.WriteComment(str8);
                                        }
                                    }
                                }
                                if (table5.Rows.Count > 0)
                                {
                                    int num63 = table5.Rows.Count - 1;
                                    for (int num64 = 0; num64 <= num63; num64++)
                                    {
                                        DataRow row28 = table5.Rows[num64];
                                        num61 = Conversions.ToInteger(row28["MountID"].ToString());
                                        num62 = Conversions.ToInteger(row28["MountIndex"].ToString());
                                        num18 = Conversions.ToInteger(row28["WeapRecID"].ToString());
                                        str8 = Conversions.ToString(row28["WeaponName"]);
                                        num14 = Conversions.ToInteger(row28["WeaponID"].ToString());
                                        if ((num61 == num8) & (num62 == num7))
                                        {
                                            xmlWriter_0.WriteStartElement("WeaponRecAdd_" + Conversions.ToString(num18) + "_" + Conversions.ToString(num14));
                                            xmlWriter_0.WriteEndElement();
                                            xmlWriter_0.WriteComment(str8);
                                        }
                                    }
                                }
                                if (table4.Rows.Count > 0)
                                {
                                    int num65 = table4.Rows.Count - 1;
                                    for (int num66 = 0; num66 <= num65; num66++)
                                    {
                                        DataRow row29 = table4.Rows[num66];
                                        num61 = Conversions.ToInteger(row29["MountID"].ToString());
                                        num62 = Conversions.ToInteger(row29["MountIndex"].ToString());
                                        num14 = Conversions.ToInteger(row29["WeaponID"].ToString());
                                        num15 = Conversions.ToInteger(row29["WeaponQty"].ToString());
                                        str8 = Conversions.ToString(row29["WeaponName"]);
                                        if ((num61 == num8) & (num62 == num7))
                                        {
                                            xmlWriter_0.WriteStartElement("WeaponEdit_" + Conversions.ToString(num14) + "_" + Conversions.ToString(num15));
                                            xmlWriter_0.WriteEndElement();
                                            xmlWriter_0.WriteComment(str8);
                                        }
                                    }
                                }
                                xmlWriter_0.WriteEndElement();
                            }
                            xmlWriter_0.WriteEndElement();
                        }
                    }
                    if (dataTable.Rows.Count > 0)
                    {
                        count = dataTable.Rows.Count;
                        int num67 = count - 1;
                        for (int num68 = 0; num68 <= num67; num68++)
                        {
                            row25 = dataTable.Rows[(count - 1) - num68];
                            num8 = Conversions.ToInteger(row25["ComponentID"].ToString());
                            str10 = Conversions.ToString(row25["Name"]);
                            num7 = Conversions.ToInteger(row25["MountIndex"].ToString());
                            xmlWriter_0.WriteStartElement("MountRemove_" + Conversions.ToString((int)(num7 + 1)) + "_" + Conversions.ToString(num8));
                            xmlWriter_0.WriteEndElement();
                            xmlWriter_0.WriteComment(str10);
                        }
                    }
                    if ((activeUnit_0.IsFacility | activeUnit_0.IsShip) | activeUnit_0.IsSubmarine)
                    {
                        int num25;
                        string str11;
                        if (table12.Rows.Count > 0)
                        {
                            int num69 = table12.Rows.Count - 1;
                            for (int num70 = 0; num70 <= num69; num70++)
                            {
                                DataRow row30 = table12.Rows[num70];
                                num25 = Conversions.ToInteger(row30["ID"].ToString());
                                str11 = Conversions.ToString(row30["Name"]);
                                xmlWriter_0.WriteStartElement("MagAdd_" + Conversions.ToString(num25));
                                xmlWriter_0.WriteEndElement();
                                xmlWriter_0.WriteComment(str11);
                            }
                        }
                        if (table7.Rows.Count > 0)
                        {
                            int num71 = table7.Rows.Count - 1;
                            for (int num72 = 0; num72 <= num71; num72++)
                            {
                                int num75;
                                int num76;
                                DataRow row31 = table7.Rows[num72];
                                num25 = Conversions.ToInteger(row31["MagID"].ToString());
                                num24 = Conversions.ToInteger(row31["MagIndex"].ToString());
                                str11 = Conversions.ToString(row31["MagName"]);
                                xmlWriter_0.WriteStartElement("Mag_" + Conversions.ToString((int)(num24 + 1)) + "_" + Conversions.ToString(num25));
                                xmlWriter_0.WriteComment(str11);
                                if (table10.Rows.Count > 0)
                                {
                                    int num73 = table10.Rows.Count - 1;
                                    for (int num74 = 0; num74 <= num73; num74++)
                                    {
                                        DataRow row32 = table10.Rows[num74];
                                        num75 = Conversions.ToInteger(row32["MagID"].ToString());
                                        num76 = Conversions.ToInteger(row32["MagIndex"].ToString());
                                        num26 = Conversions.ToInteger(row32["WeaponID"].ToString());
                                        str9 = Conversions.ToString(row32["WeaponName"]);
                                        if ((num75 == num25) & (num76 == num24))
                                        {
                                            xmlWriter_0.WriteStartElement("WeaponRemove_" + Conversions.ToString(num26));
                                            xmlWriter_0.WriteEndElement();
                                            xmlWriter_0.WriteComment(str9);
                                        }
                                    }
                                }
                                if (table9.Rows.Count > 0)
                                {
                                    int num77 = table9.Rows.Count - 1;
                                    for (int num78 = 0; num78 <= num77; num78++)
                                    {
                                        DataRow row33 = table9.Rows[num78];
                                        num75 = Conversions.ToInteger(row33["MagID"].ToString());
                                        num76 = Conversions.ToInteger(row33["MagIndex"].ToString());
                                        num30 = Conversions.ToInteger(row33["WeapRecID"].ToString());
                                        num26 = Conversions.ToInteger(row33["WeaponID"].ToString());
                                        str9 = Conversions.ToString(row33["WeaponName"]);
                                        if ((num75 == num25) & (num76 == num24))
                                        {
                                            xmlWriter_0.WriteStartElement("WeaponRecAdd_" + Conversions.ToString(num30) + "_" + Conversions.ToString(num26));
                                            xmlWriter_0.WriteEndElement();
                                            xmlWriter_0.WriteComment(str9);
                                        }
                                    }
                                }
                                if (table8.Rows.Count > 0)
                                {
                                    int num79 = table8.Rows.Count - 1;
                                    for (int num80 = 0; num80 <= num79; num80++)
                                    {
                                        DataRow row34 = table8.Rows[num80];
                                        num75 = Conversions.ToInteger(row34["MagID"].ToString());
                                        num76 = Conversions.ToInteger(row34["MagIndex"].ToString());
                                        num26 = Conversions.ToInteger(row34["WeaponID"].ToString());
                                        num27 = Conversions.ToInteger(row34["WeaponQty"].ToString());
                                        str9 = Conversions.ToString(row34["WeaponName"]);
                                        if ((num75 == num25) & (num76 == num24))
                                        {
                                            xmlWriter_0.WriteStartElement("WeaponEdit_" + Conversions.ToString(num26) + "_" + Conversions.ToString(num27));
                                            xmlWriter_0.WriteEndElement();
                                            xmlWriter_0.WriteComment(str9);
                                        }
                                    }
                                }
                                xmlWriter_0.WriteEndElement();
                            }
                        }
                        if (expression.Rows.Count > 0)
                        {
                            count = expression.Rows.Count;
                            int num81 = count - 1;
                            for (int num82 = 0; num82 <= num81; num82++)
                            {
                                DataRow row35 = expression.Rows[(count - 1) - num82];
                                num25 = Conversions.ToInteger(row35["ComponentID"].ToString());
                                str11 = Conversions.ToString(row35["Name"]);
                                num24 = Conversions.ToInteger(row35["MagIndex"].ToString());
                                xmlWriter_0.WriteStartElement("MagRemove_" + Conversions.ToString((int)(num24 + 1)) + "_" + Conversions.ToString(num25));
                                xmlWriter_0.WriteEndElement();
                                xmlWriter_0.WriteComment(str11);
                            }
                        }
                    }
                    if (table14.Rows.Count > 0)
                    {
                        int num83 = table14.Rows.Count - 1;
                        for (int num84 = 0; num84 <= num83; num84++)
                        {
                            row36 = table14.Rows[num84];
                            num34 = Conversions.ToInteger(row36["ID"].ToString());
                            str12 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row36["Name"])), "", RuntimeHelpers.GetObjectValue(row36["Name"])));
                            xmlWriter_0.WriteStartElement("SensorAdd_" + Conversions.ToString(num34));
                            xmlWriter_0.WriteComment(str12);
                            SaveCoverageData(xmlWriter_0, true, row36, activeUnit_0, str12);
                        }
                    }
                    if (table13.Rows.Count > 0)
                    {
                        count = table13.Rows.Count;
                        int num85 = count - 1;
                        for (int num86 = 0; num86 <= num85; num86++)
                        {
                            row36 = table13.Rows[(count - 1) - num86];
                            num34 = Conversions.ToInteger(row36["ComponentID"].ToString());
                            str12 = Conversions.ToString(row36["Name"]);
                            int num87 = Conversions.ToInteger(row36["SensorIndex"].ToString());
                            xmlWriter_0.WriteStartElement("SensorRemove_" + Conversions.ToString((int)(num87 + 1)) + "_" + Conversions.ToString(num34));
                            xmlWriter_0.WriteEndElement();
                            xmlWriter_0.WriteComment(str12);
                        }
                    }
                    if (table16.Rows.Count > 0)
                    {
                        int num88 = table16.Rows.Count - 1;
                        for (int num89 = 0; num89 <= num88; num89++)
                        {
                            DataRow row37 = table16.Rows[num89];
                            num42 = Conversions.ToInteger(row37["ID"].ToString());
                            str13 = Conversions.ToString(row37["Name"]);
                            xmlWriter_0.WriteStartElement("CommAdd_" + Conversions.ToString(num42));
                            xmlWriter_0.WriteEndElement();
                            xmlWriter_0.WriteComment(str13);
                        }
                    }
                    if (table15.Rows.Count > 0)
                    {
                        count = table15.Rows.Count;
                        int num90 = count - 1;
                        for (int num91 = 0; num91 <= num90; num91++)
                        {
                            DataRow row38 = table15.Rows[(count - 1) - num91];
                            num42 = Conversions.ToInteger(row38["ComponentID"].ToString());
                            str13 = Conversions.ToString(row38["Name"]);
                            int num92 = Conversions.ToInteger(row38["CommIndex"].ToString());
                            xmlWriter_0.WriteStartElement("CommRemove_" + Conversions.ToString((int)(num92 + 1)) + "_" + Conversions.ToString(num42));
                            xmlWriter_0.WriteEndElement();
                            xmlWriter_0.WriteComment(str13);
                        }
                    }
                    if (table2.Rows.Count > 0)
                    {
                        count = table2.Rows.Count;
                        int num93 = count - 1;
                        for (int num94 = 0; num94 <= num93; num94++)
                        {
                            DataRow row39 = table2.Rows[(count - 1) - num94];
                            num34 = Conversions.ToInteger(row39["DBID"]);
                            str12 = row39["Name"].ToString();
                            xmlWriter_0.WriteStartElement("SensorActive_" + Conversions.ToString(num34));
                            xmlWriter_0.WriteEndElement();
                            xmlWriter_0.WriteComment(str12);
                        }
                        table2.Clear();
                    }
                    xmlWriter_0.WriteEndElement();
                }
                return;
            }
            Sensor sensor2 = noneMCMSensors[num33];
            bool flag6 = false;
            IEnumerator enumerator13 = table13.Rows.GetEnumerator();
            try
            {
                DataRow row24;
                while (enumerator13.MoveNext())
                {
                    row24 = (DataRow)enumerator13.Current;
                    if (((((((((((((((((((((((((((((((((Conversions.ToInteger(row24["ComponentID"]) == sensor2.DBID) & (sensor2.coverageArc.SB1 == Conversions.ToBoolean(row24["SB1"]))) & (sensor2.coverageArc.SB2 == Conversions.ToBoolean(row24["SB2"]))) & (sensor2.coverageArc.SMF1 == Conversions.ToBoolean(row24["SMF1"]))) & (sensor2.coverageArc.SMF2 == Conversions.ToBoolean(row24["SMF2"]))) & (sensor2.coverageArc.SMA1 == Conversions.ToBoolean(row24["SMA1"]))) & (sensor2.coverageArc.SMA2 == Conversions.ToBoolean(row24["SMA2"]))) & (sensor2.coverageArc.SS1 == Conversions.ToBoolean(row24["SS1"]))) & (sensor2.coverageArc.SS2 == Conversions.ToBoolean(row24["SS2"]))) & (sensor2.coverageArc.PB1 == Conversions.ToBoolean(row24["PB1"]))) & (sensor2.coverageArc.PB2 == Conversions.ToBoolean(row24["PB2"]))) & (sensor2.coverageArc.PMF1 == Conversions.ToBoolean(row24["PMF1"]))) & (sensor2.coverageArc.PMF2 == Conversions.ToBoolean(row24["PMF2"]))) & (sensor2.coverageArc.PMA1 == Conversions.ToBoolean(row24["PMA1"]))) & (sensor2.coverageArc.PMA2 == Conversions.ToBoolean(row24["PMA2"]))) & (sensor2.coverageArc.PS1 == Conversions.ToBoolean(row24["PS1"]))) & (sensor2.coverageArc.PS2 == Conversions.ToBoolean(row24["PS2"]))) & (sensor2.coverageArcMax.SB1 == Conversions.ToBoolean(row24["SB1Max"]))) & (sensor2.coverageArcMax.SB2 == Conversions.ToBoolean(row24["SB2Max"]))) & (sensor2.coverageArcMax.SMF1 == Conversions.ToBoolean(row24["SMF1Max"]))) & (sensor2.coverageArcMax.SMF2 == Conversions.ToBoolean(row24["SMF2Max"]))) & (sensor2.coverageArcMax.SMA1 == Conversions.ToBoolean(row24["SMA1Max"]))) & (sensor2.coverageArcMax.SMA2 == Conversions.ToBoolean(row24["SMA2Max"]))) & (sensor2.coverageArcMax.SS1 == Conversions.ToBoolean(row24["SS1Max"]))) & (sensor2.coverageArcMax.SS2 == Conversions.ToBoolean(row24["SS2Max"]))) & (sensor2.coverageArcMax.PB1 == Conversions.ToBoolean(row24["PB1Max"]))) & (sensor2.coverageArcMax.PB2 == Conversions.ToBoolean(row24["PB2Max"]))) & (sensor2.coverageArcMax.PMF1 == Conversions.ToBoolean(row24["PMF1Max"]))) & (sensor2.coverageArcMax.PMF2 == Conversions.ToBoolean(row24["PMF2Max"]))) & (sensor2.coverageArcMax.PMA1 == Conversions.ToBoolean(row24["PMA1Max"]))) & (sensor2.coverageArcMax.PMA2 == Conversions.ToBoolean(row24["PMA2Max"]))) & (sensor2.coverageArcMax.PS1 == Conversions.ToBoolean(row24["PS1Max"]))) & (sensor2.coverageArcMax.PS2 == Conversions.ToBoolean(row24["PS2Max"])))
                    {
                        goto Label_40BB;
                    }
                }
                goto Label_40C5;
            Label_40BB:
                row24.Delete();
                flag6 = true;
            Label_40C5:
                if (!flag6)
                {
                    switch (activeUnit_0.GetUnitType())
                    {
                        case GlobalVariables.ActiveUnitType.Aircraft:
                            str2 = "SELECT ComponentID from DataMountSensors where  ID in (Select ComponentID from DataAircraftMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ") UNION SELECT ComponentID from DataSensorSensorGroups where ID in (Select ComponentID from DataAircraftSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                            break;

                        case GlobalVariables.ActiveUnitType.Ship:
                            str2 = "SELECT ComponentID from DataMountSensors where  ID in (Select ComponentID from DataShipMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ") UNION SELECT ComponentID from DataSensorSensorGroups where ID in (Select ComponentID from DataShipSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                            break;

                        case GlobalVariables.ActiveUnitType.Submarine:
                            str2 = "SELECT ComponentID from DataMountSensors where  ID in (Select ComponentID from DataSubmarineMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ") UNION SELECT ComponentID from DataSensorSensorGroups where ID in (Select ComponentID from DataSubmarineSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                            break;

                        case GlobalVariables.ActiveUnitType.Facility:
                            str2 = "SELECT ComponentID from DataMountSensors where  ID in (Select ComponentID from DataFacilityMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ") UNION SELECT ComponentID from DataSensorSensorGroups where ID in (Select ComponentID from DataFacilitySensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                            break;

                        case GlobalVariables.ActiveUnitType.Satellite:
                            str2 = "SELECT ComponentID from DataMountSensors where  ID in (Select ComponentID from DataSatelliteMounts where ID = " + Conversions.ToString(activeUnit_0.DBID) + ") UNION SELECT ComponentID from DataSensorSensorGroups where ID in (Select ComponentID from DataSatelliteSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                            break;
                    }
                    enumerator = base2.GetDataTable(str2).Rows.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            num35 = Conversions.ToInteger(((DataRow)enumerator.Current)["ComponentID"]);
                            if (sensor2.DBID == num35)
                            {
                                goto Label_42CE;
                            }
                        }
                        goto Label_4A71;
                    Label_42CE:
                        flag6 = true;
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }
                goto Label_4A71;
            }
            finally
            {
                if (enumerator13 is IDisposable)
                {
                    (enumerator13 as IDisposable).Dispose();
                }
            }
        Label_4315:
            str2 = "SELECT dws.ComponentID from DataWeaponSensors dws where dws.ID in (Select dw.ComponentID from DataWeaponRecord dw where dw.ID in (Select dlw.ComponentID from DataLoadoutWeapons dlw where dlw.ID in (Select dal.ComponentID from DataAircraftLoadouts dal where dal.ID = " + Conversions.ToString(activeUnit_0.DBID) + ")))";
            IEnumerator enumerator14 = base2.GetDataTable(str2).Rows.GetEnumerator();
            try
            {
                while (enumerator14.MoveNext())
                {
                    num35 = Conversions.ToInteger(((DataRow)enumerator14.Current)["ComponentID"]);
                    if (sensor2.DBID == num35)
                    {
                        goto Label_4382;
                    }
                }
                goto Label_43A3;
            Label_4382:
                flag6 = true;
            }
            finally
            {
                if (enumerator14 is IDisposable)
                {
                    (enumerator14 as IDisposable).Dispose();
                }
            }
        Label_43A3:
            if (!flag6)
            {
                switch (activeUnit_0.GetUnitType())
                {
                    case GlobalVariables.ActiveUnitType.Aircraft:
                        str2 = "SELECT ComponentID from DataSensorSensorGroups where ComponentID = " + Conversions.ToString(sensor2.DBID) + " and ID not in (Select ComponentID from DataAircraftSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                        break;

                    case GlobalVariables.ActiveUnitType.Ship:
                        str2 = "SELECT ComponentID from DataSensorSensorGroups where ComponentID = " + Conversions.ToString(sensor2.DBID) + " and ID not in (Select ComponentID from DataShipSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                        break;

                    case GlobalVariables.ActiveUnitType.Submarine:
                        str2 = "SELECT ComponentID from DataSensorSensorGroups where ComponentID = " + Conversions.ToString(sensor2.DBID) + " and ID not in (Select ComponentID from DataSubmarineSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                        break;

                    case GlobalVariables.ActiveUnitType.Facility:
                        str2 = "SELECT ComponentID from DataSensorSensorGroups where ComponentID = " + Conversions.ToString(sensor2.DBID) + " and ID not in (Select ComponentID from DataFacilitySensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                        break;

                    case GlobalVariables.ActiveUnitType.Satellite:
                        str2 = "SELECT ComponentID from DataSensorSensorGroups where ComponentID = " + Conversions.ToString(sensor2.DBID) + " and ID not in (Select ComponentID from DataSatelliteSensors where ID = " + Conversions.ToString(activeUnit_0.DBID) + ")";
                        break;
                }
                if (base2.GetDataTable(str2).Rows.Count > 0)
                {
                    str7 = "WARNING: Sensor " + sensor2.Name + " to be added to unit " + activeUnit_0.Name + " (" + activeUnit_0.UnitClass + " [" + Conversions.ToString(activeUnit_0.DBID) + "]) belongs to a Sensor Group. The SBR cannot handle sensor groups and the sensor itself has been added to the INI file. Please change the sensor to the corresponding sensor group in the INI file manually.";
                    streamWriter_0 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR INI template log file.txt");
                    streamWriter_0.Write("\r\n      " + str7);
                    streamWriter_0.Close();
                    num2++;
                }
            }
            if (!flag6 && (table17.Rows.Count > 0))
            {
                int num37 = table17.Rows.Count - 1;
                for (int num38 = 0; num38 <= num37; num38++)
                {
                    row25 = table17.Rows[num38];
                    num8 = Conversions.ToInteger(row25["ID"].ToString());
                    str2 = "SELECT ComponentID from DataMountSensors where  ID = " + Conversions.ToString(num8);
                    IEnumerator enumerator15 = base2.GetDataTable(str2).Rows.GetEnumerator();
                    try
                    {
                        while (enumerator15.MoveNext())
                        {
                            num35 = Conversions.ToInteger(((DataRow)enumerator15.Current)["ComponentID"]);
                            if (sensor2.DBID == num35)
                            {
                                goto Label_46F0;
                            }
                        }
                        continue;
                    Label_46F0:
                        flag6 = true;
                    }
                    finally
                    {
                        if (enumerator15 is IDisposable)
                        {
                            (enumerator15 as IDisposable).Dispose();
                        }
                    }
                }
            }
            if (!flag6 & !sensor2.IsEyeball())
            {
                table14.Rows.Add(new object[] {
            sensor2.DBID, sensor2.Name, sensor2.sensorType, sensor2.coverageArc.SB1, sensor2.coverageArc.SB2, sensor2.coverageArc.SMF1, sensor2.coverageArc.SMF2, sensor2.coverageArc.SMA1, sensor2.coverageArc.SMA2, sensor2.coverageArc.SS1, sensor2.coverageArc.SS2, sensor2.coverageArc.PB1, sensor2.coverageArc.PB2, sensor2.coverageArc.PMF1, sensor2.coverageArc.PMF2, sensor2.coverageArc.PMA1,
            sensor2.coverageArc.PMA2, sensor2.coverageArc.PS1, sensor2.coverageArc.PS2, sensor2.coverageArcMax.SB1, sensor2.coverageArcMax.SB2, sensor2.coverageArcMax.SMF1, sensor2.coverageArcMax.SMF2, sensor2.coverageArcMax.SMA1, sensor2.coverageArcMax.SMA2, sensor2.coverageArcMax.SS1, sensor2.coverageArcMax.SS2, sensor2.coverageArcMax.PB1, sensor2.coverageArcMax.PB2, sensor2.coverageArcMax.PMF1, sensor2.coverageArcMax.PMF2, sensor2.coverageArcMax.PMA1,
            sensor2.coverageArcMax.PMA2, sensor2.coverageArcMax.PS1, sensor2.coverageArcMax.PS2, sensor2.coverageArc.Is360Coverage(), sensor2.coverageArcMax.Is360Coverage()
        });
            }
            num33++;
            goto Label_3C51;
        Label_4A71:
            if (!(!flag6 & (activeUnit_0.GetUnitType() == GlobalVariables.ActiveUnitType.Aircraft)))
            {
                goto Label_43A3;
            }
            goto Label_4315;

        }

        // Token: 0x06006AAD RID: 27309 RVA: 0x0039A9A0 File Offset: 0x00398BA0
        private static string SaveCoverageData(XmlWriter xmlWriter_0, bool bool_0, DataRow dataRow_0, ActiveUnit activeUnit_0, string string_0)
		{
			string result = "";
			try
			{
				xmlWriter_0.WriteStartElement("Cov");
				if (Conversions.ToBoolean(dataRow_0["Has360Coverage"]))
				{
					xmlWriter_0.WriteElementString("Seg", "360");
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (Conversions.ToBoolean(dataRow_0["PB1"]))
					{
						stringBuilder.Append("PB1,");
					}
					if (Conversions.ToBoolean(dataRow_0["PB2"]))
					{
						stringBuilder.Append("PB2,");
					}
					if (Conversions.ToBoolean(dataRow_0["PMA1"]))
					{
						stringBuilder.Append("PMA1,");
					}
					if (Conversions.ToBoolean(dataRow_0["PMA2"]))
					{
						stringBuilder.Append("PMA2,");
					}
					if (Conversions.ToBoolean(dataRow_0["PMF1"]))
					{
						stringBuilder.Append("PMF1,");
					}
					if (Conversions.ToBoolean(dataRow_0["PMF2"]))
					{
						stringBuilder.Append("PMF2,");
					}
					if (Conversions.ToBoolean(dataRow_0["PS1"]))
					{
						stringBuilder.Append("PS1,");
					}
					if (Conversions.ToBoolean(dataRow_0["PS2"]))
					{
						stringBuilder.Append("PS2,");
					}
					if (Conversions.ToBoolean(dataRow_0["SB1"]))
					{
						stringBuilder.Append("SB1,");
					}
					if (Conversions.ToBoolean(dataRow_0["SB2"]))
					{
						stringBuilder.Append("SB2,");
					}
					if (Conversions.ToBoolean(dataRow_0["SMA1"]))
					{
						stringBuilder.Append("SMA1,");
					}
					if (Conversions.ToBoolean(dataRow_0["SMA2"]))
					{
						stringBuilder.Append("SMA2,");
					}
					if (Conversions.ToBoolean(dataRow_0["SMF1"]))
					{
						stringBuilder.Append("SMF1,");
					}
					if (Conversions.ToBoolean(dataRow_0["SMF2"]))
					{
						stringBuilder.Append("SMF2,");
					}
					if (Conversions.ToBoolean(dataRow_0["SS2"]))
					{
						stringBuilder.Append("SS2,");
					}
					if (Conversions.ToBoolean(dataRow_0["SS1"]))
					{
						stringBuilder.Append("SS1,");
					}
					xmlWriter_0.WriteElementString("Seg", stringBuilder.ToString());
				}
				xmlWriter_0.WriteEndElement();
				string text = "";
				if (!Conversions.ToBoolean(dataRow_0["PB1"]) & !Conversions.ToBoolean(dataRow_0["PB2"]) & !Conversions.ToBoolean(dataRow_0["PMA1"]) & !Conversions.ToBoolean(dataRow_0["PMA2"]) & !Conversions.ToBoolean(dataRow_0["PMF1"]) & !Conversions.ToBoolean(dataRow_0["PMF2"]) & !Conversions.ToBoolean(dataRow_0["PS1"]) & !Conversions.ToBoolean(dataRow_0["PS2"]) & !Conversions.ToBoolean(dataRow_0["SB1"]) & !Conversions.ToBoolean(dataRow_0["SB2"]) & !Conversions.ToBoolean(dataRow_0["SMA1"]) & !Conversions.ToBoolean(dataRow_0["SMA2"]) & !Conversions.ToBoolean(dataRow_0["SMF1"]) & !Conversions.ToBoolean(dataRow_0["SMF2"]) & !Conversions.ToBoolean(dataRow_0["SS1"]) & !Conversions.ToBoolean(dataRow_0["SS2"]))
				{
					text = string.Concat(new string[]
					{
						"ERROR: Component ",
						string_0,
						" on unit ",
						activeUnit_0.Name,
						" (",
						activeUnit_0.UnitClass,
						" [",
						Conversions.ToString(activeUnit_0.DBID),
						"]) does not have a valid arc!"
					});
				}
				if (bool_0)
				{
					xmlWriter_0.WriteStartElement("Cov_Ill");
					if (Conversions.ToBoolean(dataRow_0["Has360CoverageMax"]))
					{
						xmlWriter_0.WriteElementString("Seg", "360");
					}
					else
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						if (Conversions.ToBoolean(dataRow_0["PB1Max"]))
						{
							stringBuilder2.Append("PB1,");
						}
						if (Conversions.ToBoolean(dataRow_0["PB2Max"]))
						{
							stringBuilder2.Append("PB2,");
						}
						if (Conversions.ToBoolean(dataRow_0["PMA1Max"]))
						{
							stringBuilder2.Append("PMA1,");
						}
						if (Conversions.ToBoolean(dataRow_0["PMA2Max"]))
						{
							stringBuilder2.Append("PMA2,");
						}
						if (Conversions.ToBoolean(dataRow_0["PMF1Max"]))
						{
							stringBuilder2.Append("PMF1,");
						}
						if (Conversions.ToBoolean(dataRow_0["PMF2Max"]))
						{
							stringBuilder2.Append("PMF2,");
						}
						if (Conversions.ToBoolean(dataRow_0["PS1Max"]))
						{
							stringBuilder2.Append("PS1,");
						}
						if (Conversions.ToBoolean(dataRow_0["PS2Max"]))
						{
							stringBuilder2.Append("PS2,");
						}
						if (Conversions.ToBoolean(dataRow_0["SB1Max"]))
						{
							stringBuilder2.Append("SB1,");
						}
						if (Conversions.ToBoolean(dataRow_0["SB2Max"]))
						{
							stringBuilder2.Append("SB2,");
						}
						if (Conversions.ToBoolean(dataRow_0["SMA1Max"]))
						{
							stringBuilder2.Append("SMA1,");
						}
						if (Conversions.ToBoolean(dataRow_0["SMA2Max"]))
						{
							stringBuilder2.Append("SMA2,");
						}
						if (Conversions.ToBoolean(dataRow_0["SMF1Max"]))
						{
							stringBuilder2.Append("SMF1,");
						}
						if (Conversions.ToBoolean(dataRow_0["SMF2Max"]))
						{
							stringBuilder2.Append("SMF2,");
						}
						if (Conversions.ToBoolean(dataRow_0["SS2Max"]))
						{
							stringBuilder2.Append("SS2,");
						}
						if (Conversions.ToBoolean(dataRow_0["SS1Max"]))
						{
							stringBuilder2.Append("SS1,");
						}
						xmlWriter_0.WriteElementString("Seg", stringBuilder2.ToString());
					}
					xmlWriter_0.WriteEndElement();
					if (!Conversions.ToBoolean(dataRow_0["PB1Max"]) & !Conversions.ToBoolean(dataRow_0["PB2Max"]) & !Conversions.ToBoolean(dataRow_0["PMA1Max"]) & !Conversions.ToBoolean(dataRow_0["PMA2Max"]) & !Conversions.ToBoolean(dataRow_0["PMF1Max"]) & !Conversions.ToBoolean(dataRow_0["PMF2Max"]) & !Conversions.ToBoolean(dataRow_0["PS1Max"]) & !Conversions.ToBoolean(dataRow_0["PS2Max"]) & !Conversions.ToBoolean(dataRow_0["PS1Max"]) & !Conversions.ToBoolean(dataRow_0["SB2Max"]) & !Conversions.ToBoolean(dataRow_0["SMA1Max"]) & !Conversions.ToBoolean(dataRow_0["SMA2Max"]) & !Conversions.ToBoolean(dataRow_0["SMF1Max"]) & !Conversions.ToBoolean(dataRow_0["SMF2Max"]) & !Conversions.ToBoolean(dataRow_0["SS1Max"]) & !Conversions.ToBoolean(dataRow_0["SS2Max"]))
					{
						text = string.Concat(new string[]
						{
							"ERROR: Component ",
							string_0,
							" on unit ",
							activeUnit_0.Name,
							" (",
							activeUnit_0.UnitClass,
							" [",
							Conversions.ToString(activeUnit_0.DBID),
							"]) does not have a valid Max/Illuminate arc!"
						});
					}
				}
				xmlWriter_0.WriteEndElement();
				result = text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101115", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x0039B244 File Offset: 0x00399444
		private static int smethod_6(Scenario scenario_0, ref Mount mount_0, XmlNode xmlNode_0, int int_0)
		{
			int result = 0;
			try
			{
				bool flag = false;
				bool flag2 = false;
				int num = 0;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string[] array = xmlNode.Name.Split(new char[]
						{
							'_'
						});
						string left = array[0];
						if (Operators.CompareString(left, "#comment", false) != 0)
						{
							if (Operators.CompareString(left, "WeaponEdit", false) != 0)
							{
								if (Operators.CompareString(left, "WeaponRecAdd", false) != 0)
								{
									if (Operators.CompareString(left, "WeaponRemove", false) != 0)
									{
										if (Operators.CompareString(left, "MountMag", false) == 0)
										{
											Magazine magazineForMount = mount_0.GetMagazineForMount();
											ScenarioUnits.smethod_7(scenario_0, ref magazineForMount, xmlNode, int_0, true);
										}
									}
									else
									{
										int num2 = Conversions.ToInteger(array[1]);
										bool flag3 = false;
										List<WeaponRec> list = new List<WeaponRec>();
										foreach (WeaponRec current in mount_0.GetWeaponRecCollection())
										{
											if (current.WeapID == num2)
											{
												list.Add(current);
											}
										}
										foreach (WeaponRec current2 in list)
										{
											mount_0.GetWeaponRecCollection().Remove(current2);
											flag3 = true;
											if (int_0 == 0)
											{
												flag = true;
											}
											string str = "Removed Weapon with DBID " + Conversions.ToString(num2);
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str);
											streamWriter.Close();
											num++;
										}
										if (!flag3 & int_0 != 0)
										{
											string str = "ERROR: WEAPON WITH DBID " + Conversions.ToString(num2) + " COULD NOT BE REMOVED, NOT FOUND ON MOUNT!";
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str);
											streamWriter.Close();
										}
									}
								}
								else
								{
									int num3 = Conversions.ToInteger(array[1]);
									int num2 = 0;
									if (array.Length > 2)
									{
										num2 = Conversions.ToInteger(array[2]);
									}
									else
									{
										num2 = 0;
									}
									if (num3 == 0)
									{
										WeaponRec weaponRec = new WeaponRec(ref scenario_0, num2, 0, 10000, 1, 1, false, false);
										mount_0.GetWeaponRecCollection().Add(weaponRec);
										if (int_0 == 0)
										{
											flag = true;
										}
										string str = "Added non-database 0/10000 WeaponRec, Weapon DBID " + Conversions.ToString(weaponRec.WeapID) + " to magazine " + mount_0.Name;
										StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n      " + str);
										streamWriter.Close();
										num++;
									}
									else
									{
										SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
										string string_ = "SELECT * from DataWeaponRecord where ID = " + Conversions.ToString(num3);
										if (CachedDataBase.GetDataTable(db, string_).Rows.Count != 0)
										{
											WeaponRec weaponRec2 = DBFunctions.LoadWeaponRecordData(num3, mount_0.GetParentPlatform().m_Scenario);
											mount_0.GetWeaponRecCollection().Add(weaponRec2);
											if (int_0 == 0)
											{
												flag = true;
											}
											string str = string.Concat(new string[]
											{
												"Added WeaponRec ",
												Conversions.ToString(num3),
												", Weapon DBID ",
												Conversions.ToString(weaponRec2.WeapID),
												" to mount ",
												mount_0.Name
											});
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str);
											streamWriter.Close();
											num++;
										}
										else if (int_0 != 0)
										{
											string str = "ERROR: WEAPON RECORD " + Conversions.ToString(num3) + " COULD NOT BE ADDED, NOT FOUND IN DATABASE!";
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str);
											streamWriter.Close();
										}
									}
								}
							}
							else
							{
								int num2 = Conversions.ToInteger(array[1]);
								int num4 = Conversions.ToInteger(array[2]);
								bool flag3 = false;
								foreach (WeaponRec current3 in mount_0.GetWeaponRecCollection())
								{
									if (current3.WeapID == num2)
									{
										flag3 = true;
										current3.SetCurrentLoad(num4);
										if (int_0 == 0)
										{
											flag = true;
										}
										string str = "Updated Weapon with DBID " + Conversions.ToString(num2) + ", Qty: " + Conversions.ToString(num4);
										StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n      " + str);
										streamWriter.Close();
										num++;
									}
								}
								if (!flag3 & int_0 != 0)
								{
									string str = "ERROR: WEAPON QTY COULD NOT BE UPDATED, WEAPON WITH DBID " + Conversions.ToString(num2) + " NOT FOUND ON MOUNT!";
									StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
									streamWriter.Write("\r\n      " + str);
									streamWriter.Close();
								}
							}
						}
						else
						{
							string str = xmlNode.InnerText;
							StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
							if (!flag2 & int_0 != 0)
							{
								flag2 = true;
								streamWriter.Write("\r\n    " + str);
							}
							else if ((flag2 & int_0 != 0) | (int_0 == 0 & flag))
							{
								streamWriter.Write(" -- " + str);
							}
							streamWriter.Close();
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
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101116", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x0039B968 File Offset: 0x00399B68
		private static int smethod_7(Scenario scenario_0, ref Magazine magazine_0, XmlNode xmlNode_0, int int_0, bool bool_0)
		{
			bool flag = false;
			bool flag2 = false;
			if (bool_0)
			{
				flag2 = true;
			}
			string str;
			if (bool_0)
			{
				str = "    ";
			}
			else
			{
				str = "";
			}
			int result = 0;
			try
			{
				int num = 0;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string[] array = xmlNode.Name.Split(new char[]
						{
							'_'
						});
						string left = array[0];
						if (Operators.CompareString(left, "#comment", false) != 0)
						{
							if (Operators.CompareString(left, "WeaponEdit", false) != 0)
							{
								if (Operators.CompareString(left, "WeaponRecAdd", false) != 0)
								{
									if (Operators.CompareString(left, "WeaponRemove", false) == 0)
									{
										int num2 = Conversions.ToInteger(array[1]);
										bool flag3 = false;
										List<WeaponRec> list = new List<WeaponRec>();
										foreach (WeaponRec current in magazine_0.GetWeaponRecCollection())
										{
											if (current.WeapID == num2)
											{
												list.Add(current);
											}
										}
										foreach (WeaponRec current2 in list)
										{
											magazine_0.GetWeaponRecCollection().Remove(current2);
											flag3 = true;
											if (int_0 == 0)
											{
												flag = true;
											}
											string text = "Removed Weapon DBID " + Conversions.ToString(num2);
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str + text);
											streamWriter.Close();
											num++;
										}
										if (!flag3 & int_0 != 0)
										{
											string text = "ERROR: WEAPON WITH DBID " + Conversions.ToString(num2) + " COULD NOT BE REMOVED, NOT FOUND ON MOUNT!";
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str + text);
											streamWriter.Close();
										}
									}
								}
								else
								{
									int num3 = Conversions.ToInteger(array[1]);
									int num2 = 0;
									if (array.Length > 2)
									{
										num2 = Conversions.ToInteger(array[2]);
									}
									else
									{
										num2 = 0;
									}
									if (num3 == 0)
									{
										WeaponRec weaponRec = new WeaponRec(ref scenario_0, num2, 0, 10000, 1, 1, false, false);
										magazine_0.GetWeaponRecCollection().Add(weaponRec);
										if (int_0 == 0)
										{
											flag = true;
										}
										string text = "Added non-database 0/10000 WeaponRec, Weapon DBID " + Conversions.ToString(weaponRec.WeapID) + " to magazine " + magazine_0.Name;
										StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n      " + str + text);
										streamWriter.Close();
										num++;
									}
									else
									{
										SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
										string string_ = "SELECT * from DataWeaponRecord where ID = " + Conversions.ToString(num3);
										if (CachedDataBase.GetDataTable(db, string_).Rows.Count != 0)
										{
											WeaponRec weaponRec2 = DBFunctions.LoadWeaponRecordData(num3, magazine_0.GetParentPlatform().m_Scenario);
											magazine_0.GetWeaponRecCollection().Add(weaponRec2);
											if (int_0 == 0)
											{
												flag = true;
											}
											string text = string.Concat(new string[]
											{
												"Added WeaponRec ",
												Conversions.ToString(num3),
												", Weapon DBID ",
												Conversions.ToString(weaponRec2.WeapID),
												" to magazine ",
												magazine_0.Name
											});
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str + text);
											streamWriter.Close();
											num++;
										}
										else if (int_0 != 0)
										{
											string text = "ERROR: WEAPON RECORD " + Conversions.ToString(num3) + " COULD NOT BE ADDED, NOT FOUND IN DATABASE!";
											StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n      " + str + text);
											streamWriter.Close();
										}
									}
								}
							}
							else
							{
								bool flag3 = false;
								int num2 = Conversions.ToInteger(array[1]);
								int num4 = Conversions.ToInteger(array[2]);
								foreach (WeaponRec current3 in magazine_0.GetWeaponRecCollection())
								{
									if (current3.WeapID == num2)
									{
										flag3 = true;
										current3.SetCurrentLoad(num4);
										if (int_0 == 0)
										{
											flag = true;
										}
										string text = "Updated Weapon with DBID " + Conversions.ToString(num2) + ", Qty: " + Conversions.ToString(num4);
										StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n      " + str + text);
										streamWriter.Close();
										num++;
									}
								}
								if (!flag3 & int_0 != 0)
								{
									string text = "ERROR: WEAPON QTY COULD NOT BE UPDATED, WEAPON WITH DBID " + Conversions.ToString(num2) + " NOT FOUND IN MAGAZINE!";
									StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
									streamWriter.Write("\r\n      " + str + text);
									streamWriter.Close();
								}
							}
						}
						else
						{
							string text = xmlNode.InnerText;
							StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
							if (!flag2 & int_0 != 0)
							{
								flag2 = true;
								streamWriter.Write("\r\n   " + text);
							}
							else if ((flag2 & int_0 != 0) | (int_0 == 0 & flag))
							{
								streamWriter.Write(" -- " + text);
							}
							streamWriter.Close();
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
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101117", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x0039C090 File Offset: 0x0039A290
		public static void smethod_8(Scenario theScen, string theFileName, bool IsUnitCloningOperation, Stream theStream = null)
        {
            if (theStream == null)
            {
                theStream = new FileStream(theFileName, FileMode.Open, FileAccess.Read);
            }
            XmlDocument document = new XmlDocument();
            try
            {
                Stream stream = theStream;
                try
                {
                    document.Load(theStream);
                }
                catch (Exception exception)
                {
                    ProjectData.SetProjectError(exception);
                    Interaction.MsgBox("XML file " + theFileName + " is improperly formatted, read failed!", MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                    }
                }
                XmlNode node = document.SelectSingleNode("/ScenarioUnits");
                string innerText = "";
                if (node != null)
                {
                    innerText = "\r\nPlatform list: \r\n  DBID -- Unit name  ----  Class Info  ----  ObjectID";
                    StreamWriter writer = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                    writer.Write(innerText);
                    writer.Close();
                    IEnumerator enumerator = node.ChildNodes.GetEnumerator();
                    try
                    {
                        ActiveUnit unit;
                        while (enumerator.MoveNext())
                        {
                            XmlNode current = (XmlNode)enumerator.Current;
                            string str2 = current.Name.Split(new char[] { '_' })[1];
                            unit = theScen.GetActiveUnits()[str2];
                            if (unit == null)
                            {
                                innerText = "ERROR: UNIT # " + str2 + " DOES NOT EXIST IN SCENARIO!";
                                StreamWriter writer2 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                writer2.Write("\r\n  " + innerText);
                                writer2.Close();
                                continue;
                            }
                            SQLiteDataBase db = new SQLiteDataBase(theScen.GetSQLiteConnection());
                            string str3 = "";
                            string str4 = "";
                            string str5 = "";
                            switch (unit.GetUnitType())
                            {
                                case GlobalVariables.ActiveUnitType.Aircraft:
                                    str3 = "Select YearCommissioned, YearDecommissioned from DataAircraft where ID = " + Conversions.ToString(unit.DBID);
                                    str4 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataAircraft where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    str5 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataAircraft where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    break;

                                case GlobalVariables.ActiveUnitType.Ship:
                                    str3 = "Select YearCommissioned, YearDecommissioned from DataShip where ID = " + Conversions.ToString(unit.DBID);
                                    str4 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataShip where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    str5 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataShip where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    break;

                                case GlobalVariables.ActiveUnitType.Submarine:
                                    str3 = "Select YearCommissioned, YearDecommissioned from DataSubmarine where ID = " + Conversions.ToString(unit.DBID);
                                    str4 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataSubmarine where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    str5 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataSubmarine where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    break;

                                case GlobalVariables.ActiveUnitType.Facility:
                                    str3 = "Select YearCommissioned, YearDecommissioned from DataFacility where ID = " + Conversions.ToString(unit.DBID);
                                    str4 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataFacility where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    str5 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataFacility where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    break;

                                case GlobalVariables.ActiveUnitType.Satellite:
                                    str3 = "Select YearCommissioned, YearDecommissioned from DataSatellite where ID = " + Conversions.ToString(unit.DBID);
                                    str4 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataSatellite where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    str5 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataSatellite where ID = " + Conversions.ToString(unit.DBID) + ")";
                                    break;
                            }
                            if (unit.IsOperating() & ((((unit.IsAircraft | unit.IsFacility) | unit.IsShip) | unit.IsSubmarine) | unit.IsSatellite()))
                            {
                                DataTable dataTable = CachedDataBase.GetDataTable(db, str3);
                                DataTable table2 = CachedDataBase.GetDataTable(db, str4);
                                DataTable table3 = CachedDataBase.GetDataTable(db, str5);
                                if (!(((dataTable.Rows.Count != 0) & (table2.Rows.Count != 0)) & (table3.Rows.Count != 0)))
                                {
                                    goto Label_227B;
                                }
                                DataRow row = dataTable.Rows[0];
                                DataRow row2 = table2.Rows[0];
                                DataRow row3 = table3.Rows[0];
                                string str6 = Strings.Trim(row2["Description"].ToString());
                                string str7 = Strings.Trim(row3["Description"].ToString());
                                string str8 = Conversions.ToString(Conversions.ToInteger(row["YearCommissioned"].ToString()));
                                string str9 = Conversions.ToString(Conversions.ToInteger(row["YearDecommissioned"].ToString()));
                                innerText = Conversions.ToString(unit.DBID) + " -- " + unit.Name + "  ----  " + unit.UnitClass + " -- " + str6 + " (" + str7 + "), " + str8 + "-" + str9 + "  ----  " + unit.GetGuid();
                                StreamWriter writer4 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                writer4.Write("\r\n  " + innerText);
                                writer4.Close();
                                IEnumerator enumerator2 = current.ChildNodes.GetEnumerator();
                                try
                                {
                                    while (enumerator2.MoveNext())
                                    {
                                        int num2;
                                        int num4;
                                        int num7;
                                        int num11;
                                        int num12;
                                        int num14;
                                        XmlNode node3 = (XmlNode)enumerator2.Current;
                                        string str10 = node3.Name.Split(new char[] { '_' })[0];
                                        uint num = Class382.smethod_0(str10);
                                        if (num <= 0x7d86c550)
                                        {
                                            int num8;
                                            int num10;
                                            if (num <= 0x36379c81)
                                            {
                                                switch (num)
                                                {
                                                    case 0x1c1d34f5:
                                                        {
                                                            if (str10 == "SensorActive")
                                                            {
                                                                if (unit.GetSensory().IsObeysEMCON())
                                                                {
                                                                    unit.GetSensory().SetIsObeysEMCON(false);
                                                                }
                                                                float num5 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                                foreach (Sensor sensor2 in unit.GetAllNoneMCMSensors())
                                                                {
                                                                    if (!((sensor2.DBID != num5) || sensor2.IsEmmitting()))
                                                                    {
                                                                        sensor2.TurnOn();
                                                                    }
                                                                }
                                                            }
                                                            continue;
                                                        }
                                                    case 0x282cc2cf:
                                                        {
                                                            if (str10 == "MagAdd")
                                                            {
                                                                num4 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                                if (num4 > 0)
                                                                {
                                                                    string str13 = "SELECT Name from DataMagazine where ID = " + Conversions.ToString(num4);
                                                                    if (CachedDataBase.GetDataTable(db, str13).Rows.Count != 0)
                                                                    {
                                                                        Magazine magazine = DBFunctions.GetMagazine(num4, ref theScen, true);
                                                                        unit.AddMagazine(magazine);
                                                                        magazine.SetParentPlatform(unit);
                                                                        innerText = "Added magazine, DBID: " + Conversions.ToString(num4) + " Name " + magazine.Name;
                                                                        StreamWriter writer8 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                        writer8.Write("\r\n    " + innerText);
                                                                        writer8.Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        innerText = "ERROR: MAGAZINE WITH DBID " + Conversions.ToString(num4) + " COULD NOT BE ADDED, NOT FOUND IN DATABASE!";
                                                                        StreamWriter writer9 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                        writer9.Write("\r\n    " + innerText);
                                                                        writer9.Close();
                                                                    }
                                                                }
                                                            }
                                                            continue;
                                                        }
                                                }
                                                if ((num == 0x36379c81) && (str10 == "MountAdd"))
                                                {
                                                    num2 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                    bool flag = false;
                                                    if (num2 > 0)
                                                    {
                                                        string str11 = "SELECT Name from DataMount where ID = " + Conversions.ToString(num2);
                                                        if (CachedDataBase.GetDataTable(db, str11).Rows.Count == 0)
                                                        {
                                                            innerText = "ERROR: MOUNT WITH DBID " + Conversions.ToString(num2) + " COULD NOT BE ADDED, NOT FOUND IN DATABASE!";
                                                            StreamWriter writer5 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer5.Write("\r\n    " + innerText);
                                                            writer5.Close();
                                                        }
                                                        else
                                                        {
                                                            Mount mount = DBFunctions.LoadMountData(num2, ref theScen, true);
                                                            ScenarioArrayUtil.AddMount(ref unit.m_Mounts, mount);
                                                            mount.SetParentPlatform(unit);
                                                            IEnumerator enumerator3 = node3.ChildNodes.GetEnumerator();
                                                            try
                                                            {
                                                                while (enumerator3.MoveNext())
                                                                {
                                                                    XmlNode node4 = (XmlNode)enumerator3.Current;
                                                                    switch (node4.Name)
                                                                    {
                                                                        case "Coverage":
                                                                        case "Cov":
                                                                            mount.coverageArc = PlatformComponent._CoverageArc.SetCoverageIlluminate(ref node4);
                                                                            flag = true;
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            finally
                                                            {
                                                                if (enumerator3 is IDisposable)
                                                                {
                                                                    (enumerator3 as IDisposable).Dispose();
                                                                }
                                                            }
                                                            if (flag && (mount.GetSensors().Count<Sensor>() > 0))
                                                            {
                                                                foreach (Sensor sensor in mount.GetSensors())
                                                                {
                                                                    sensor.SetParentPlatform(unit);
                                                                    sensor.coverageArc.PB1 = mount.coverageArc.PB1;
                                                                    sensor.coverageArc.PB2 = mount.coverageArc.PB2;
                                                                    sensor.coverageArc.PMA1 = mount.coverageArc.PMA1;
                                                                    sensor.coverageArc.PMA2 = mount.coverageArc.PMA2;
                                                                    sensor.coverageArc.PMF1 = mount.coverageArc.PMF1;
                                                                    sensor.coverageArc.PMF2 = mount.coverageArc.PMF2;
                                                                    sensor.coverageArc.PS1 = mount.coverageArc.PS1;
                                                                    sensor.coverageArc.PS2 = mount.coverageArc.PS2;
                                                                    sensor.coverageArc.SB1 = mount.coverageArc.SB1;
                                                                    sensor.coverageArc.SB2 = mount.coverageArc.SB2;
                                                                    sensor.coverageArc.SMA1 = mount.coverageArc.SMA1;
                                                                    sensor.coverageArc.SMA2 = mount.coverageArc.SMA2;
                                                                    sensor.coverageArc.SMF1 = mount.coverageArc.SMF1;
                                                                    sensor.coverageArc.SMF2 = mount.coverageArc.SMF2;
                                                                    sensor.coverageArc.SS1 = mount.coverageArc.SS1;
                                                                    sensor.coverageArc.SS2 = mount.coverageArc.SS2;
                                                                }
                                                            }
                                                            innerText = "Added mount, DBID: " + Conversions.ToString(num2) + " Name " + mount.Name;
                                                            StreamWriter writer6 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer6.Write("\r\n    " + innerText);
                                                            writer6.Close();
                                                            if (!flag)
                                                            {
                                                                innerText = "ERROR: MOUNT WITH DBID " + Conversions.ToString(num2) + " HAS NO ARCS SET!";
                                                                StreamWriter writer7 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                writer7.Write("\r\n    " + innerText);
                                                                writer7.Close();
                                                            }
                                                        }
                                                    }
                                                }
                                                continue;
                                            }
                                            if (num <= 0x3e12805a)
                                            {
                                                if (num != 0x38125a32)
                                                {
                                                    if ((num != 0x3e12805a) || (str10 != "Mount"))
                                                    {
                                                        continue;
                                                    }
                                                    num7 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                    num2 = 0;
                                                    try
                                                    {
                                                        num2 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[2]);
                                                    }
                                                    catch (Exception exception2)
                                                    {
                                                        ProjectData.SetProjectError(exception2);
                                                        num2 = 0;
                                                        if (num7 != 0)
                                                        {
                                                            innerText = "ERROR: MOUNT WITH INDEX " + Conversions.ToString(num7) + " HAS NO DBID LISTED (Example: <Mount_<MountIndex>_<MountDBID>> ). THIS MAY CAUSE THE WRONG MOUNT TO BE UPDATED IN CASE A DATABASE UPDATE ALTERS THE MOUNT INDEX!";
                                                            StreamWriter writer10 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer10.Write("\r\n    " + innerText);
                                                            writer10.Close();
                                                        }
                                                        ProjectData.ClearProjectError();
                                                    }
                                                    try
                                                    {
                                                        if (num7 == 0)
                                                        {
                                                            num8 = 0;
                                                            innerText = "Updating all relevant Mounts:";
                                                            StreamWriter writer11 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer11.Write("\r\n    " + innerText);
                                                            writer11.Close();
                                                            Mount mount2X;
                                                            foreach (Mount mount2 in unit.m_Mounts)
                                                            {
                                                                mount2X = mount2;
                                                                num10 = smethod_6(theScen, ref mount2X, node3, num7);
                                                                num8 += num10;
                                                            }
                                                            if (num8 == 0)
                                                            {
                                                                innerText = "ERROR: ATTEMPTING TO UPDATE ALL RELEVANT MOUNTS, COULD NOT FIND ANY MOUNTS TO UPDATE!";
                                                                StreamWriter writer12 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                writer12.Write("\r\n      " + innerText);
                                                                writer12.Close();
                                                            }
                                                        }
                                                        else if ((unit.m_Mounts[num7 - 1].DBID == num2) | (num2 == 0))
                                                        {
                                                            num8 = smethod_6(theScen, ref unit.m_Mounts[num7 - 1], node3, num7);
                                                        }
                                                        else
                                                        {
                                                            innerText = "ERROR: MOUNT WITH INDEX " + Conversions.ToString(num7) + " DOES NOT MATCH DBID " + Conversions.ToString(num2) + "! A DATABASE UPDATE MAY HAVE ALTERED THE MOUNT INDEX, YOU NEED TO CHANGE THE MOUNT INDEX TO THE CORRECT VALUE!";
                                                            StreamWriter writer13 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer13.Write("\r\n    " + innerText);
                                                            writer13.Close();
                                                        }
                                                        continue;
                                                    }
                                                    catch (Exception exception3)
                                                    {
                                                        ProjectData.SetProjectError(exception3);
                                                        innerText = "ERROR: MOUNT WITH INDEX " + Conversions.ToString(num7) + " DOES NOT EXIST ON UNIT!";
                                                        StreamWriter writer14 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer14.Write("\r\n    " + innerText);
                                                        writer14.Close();
                                                        ProjectData.ClearProjectError();
                                                        continue;
                                                    }
                                                }
                                                if (str10 == "CargoAdd")
                                                {
                                                    CargoComparer comparer = new CargoComparer(null);
                                                    CargoComparer comparer2 = comparer;
                                                    XmlNode firstChild = node3.FirstChild;
                                                    Dictionary<string, Subject> dictionary = null;
                                                    comparer2.m_Cargo = Cargo.Load(ref firstChild, ref dictionary, unit);
                                                    if (IsUnitCloningOperation)
                                                    {
                                                        comparer.m_Cargo.ClearGuid();
                                                    }
                                                    if (unit.m_OnboardCargos.FirstOrDefault<Cargo>(new Func<Cargo, bool>(comparer.Equal)) == null)
                                                    {
                                                        ScenarioArrayUtil.AddCargo(ref unit.m_OnboardCargos, comparer.m_Cargo);
                                                    }
                                                }
                                                continue;
                                            }
                                            if (num != 0x55a80b14)
                                            {
                                                if ((num == 0x7d86c550) && (str10 == "CommAdd"))
                                                {
                                                    num11 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                    if (num11 > 0)
                                                    {
                                                        string str14 = "SELECT Name from DataComm where ID = " + Conversions.ToString(num11);
                                                        if (CachedDataBase.GetDataTable(db, str14).Rows.Count != 0)
                                                        {
                                                            CommDevice device = DBFunctions.LoadCommData(num11, ref unit);
                                                            unit.AddCommDevice(device);
                                                            device.SetParentPlatform(unit);
                                                            innerText = "Added comms gear, DBID: " + Conversions.ToString(num11) + " Name: " + device.Name;
                                                            StreamWriter writer15 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer15.Write("\r\n    " + innerText);
                                                            writer15.Close();
                                                        }
                                                        else
                                                        {
                                                            innerText = "ERROR: COMM WITH DBID " + Conversions.ToString(num11) + " COULD NOT BE ADDED, NOT FOUND IN DATABASE!";
                                                            StreamWriter writer16 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer16.Write("\r\n    " + innerText);
                                                            writer16.Close();
                                                        }
                                                    }
                                                }
                                                continue;
                                            }
                                            if (str10 != "Mag")
                                            {
                                                continue;
                                            }
                                            num12 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                            num4 = 0;
                                            try
                                            {
                                                num4 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[2]);
                                            }
                                            catch (Exception exception4)
                                            {
                                                ProjectData.SetProjectError(exception4);
                                                num4 = 0;
                                                if (num12 != 0)
                                                {
                                                    innerText = "ERROR: MAGAZINE WITH INDEX " + Conversions.ToString(num12) + " HAS NO DBID LISTED (Example: <Mag_<MagIndex>_<MagDBID>> ). THIS MAY CAUSE THE WRONG MAGAZINE TO BE UPDATED IN CASE A DATABASE UPDATE ALTERS THE MAGAZINE INDEX!";
                                                    StreamWriter writer17 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer17.Write("\r\n    " + innerText);
                                                    writer17.Close();
                                                }
                                                ProjectData.ClearProjectError();
                                            }
                                            try
                                            {
                                                if (num12 == 0)
                                                {
                                                    num8 = 0;
                                                    innerText = "Updating all relevant Magazines:";
                                                    StreamWriter writer18 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer18.Write("\r\n    " + innerText);
                                                    writer18.Close();
                                                    Magazine magazine2X;
                                                    foreach (Magazine magazine2 in unit.GetMagazines())
                                                    {
                                                        magazine2X = magazine2;
                                                        num10 = smethod_7(theScen, ref magazine2X, node3, num12, false);
                                                        num8 += num10;
                                                    }
                                                    if (num8 == 0)
                                                    {
                                                        innerText = "ERROR: COULD NOT FIND ANY MAGAZINES TO UPDATE!";
                                                        StreamWriter writer19 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer19.Write("\r\n      " + innerText);
                                                        writer19.Close();
                                                    }
                                                }
                                                else if ((unit.GetMagazines()[num12 - 1].DBID == num4) | (num4 == 0))
                                                {
                                                    num8 = smethod_7(theScen, ref unit.GetMagazines()[num12 - 1], node3, num12, false);
                                                }
                                                else
                                                {
                                                    innerText = "ERROR: MAGAZINE WITH INDEX " + Conversions.ToString(num12) + " DOES NOT MATCH DBID " + Conversions.ToString(num4) + "! A DATABASE UPDATE MAY HAVE ALTERED THE MOUNT INDEX, YOU NEED TO CHANGE THE MOUNT INDEX TO THE CORRECT VALUE!";
                                                    StreamWriter writer20 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer20.Write("\r\n    " + innerText);
                                                    writer20.Close();
                                                }
                                                continue;
                                            }
                                            catch (Exception exception5)
                                            {
                                                ProjectData.SetProjectError(exception5);
                                                innerText = "ERROR: MAGAZINE WITH INDEX " + Conversions.ToString((int)(num12 - 1)) + " DOES NOT EXIST ON UNIT!";
                                                StreamWriter writer21 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                writer21.Write("\r\n    " + innerText);
                                                writer21.Close();
                                                ProjectData.ClearProjectError();
                                                continue;
                                            }
                                        }
                                        if (num <= 0x98e003ee)
                                        {
                                            if (num != 0x8a231264)
                                            {
                                                if (num != 0x9235cf5e)
                                                {
                                                    if ((num == 0x98e003ee) && (str10 == "SensorAdd"))
                                                    {
                                                        num14 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                        bool flag2 = false;
                                                        bool flag3 = false;
                                                        if (num14 > 0)
                                                        {
                                                            string str15 = "SELECT Name from DataSensor where ID = " + Conversions.ToString(num14);
                                                            if (CachedDataBase.GetDataTable(db, str15).Rows.Count == 0)
                                                            {
                                                                innerText = "ERROR: MAGAZINE WITH DBID " + Conversions.ToString(num14) + " COULD NOT BE ADDED, NOT FOUND IN DATABASE!";
                                                                StreamWriter writer22 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                writer22.Write("\r\n    " + innerText);
                                                                writer22.Close();
                                                            }
                                                            else
                                                            {
                                                                int dBID = num14;
                                                                SQLiteConnection sQLiteConnection = unit.m_Scenario.GetSQLiteConnection();
                                                                Sensor sensor3 = DBFunctions.LoadSensorData(dBID, ref sQLiteConnection);
                                                                unit.AddSensor(sensor3);
                                                                sensor3.SetParentPlatform(unit);
                                                                IEnumerator enumerator4 = node3.ChildNodes.GetEnumerator();
                                                                try
                                                                {
                                                                    while (enumerator4.MoveNext())
                                                                    {
                                                                        XmlNode node6 = (XmlNode)enumerator4.Current;
                                                                        switch (node6.Name)
                                                                        {
                                                                            case "Coverage":
                                                                            case "Cov":
                                                                                sensor3.coverageArc = PlatformComponent._CoverageArc.SetCoverageIlluminate(ref node6);
                                                                                flag2 = true;
                                                                                break;

                                                                            case "Coverage_Illuminate":
                                                                            case "Cov_Ill":
                                                                                sensor3.coverageArcMax = PlatformComponent._CoverageArc.SetCoverageIlluminate(ref node6);
                                                                                flag3 = true;
                                                                                break;
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
                                                                innerText = "Added sensor, DBID: " + Conversions.ToString(num14) + " Name: " + sensor3.Name;
                                                                StreamWriter writer23 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                writer23.Write("\r\n    " + innerText);
                                                                writer23.Close();
                                                                if (!flag2)
                                                                {
                                                                    innerText = "ERROR: SENSOR WITH DBID " + Conversions.ToString(num14) + " HAS NO ARCS SET!";
                                                                    StreamWriter writer24 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                    writer24.Write("\r\n    " + innerText);
                                                                    writer24.Close();
                                                                }
                                                                if (!flag3)
                                                                {
                                                                    innerText = "ERROR: SENSOR WITH DBID " + Conversions.ToString(num14) + " HAS NO ILLUMINATION ARCS SET!";
                                                                    StreamWriter writer25 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                                    writer25.Write("\r\n    " + innerText);
                                                                    writer25.Close();
                                                                }
                                                            }
                                                        }
                                                    }
                                                    continue;
                                                }
                                                if (str10 != "MountRemove")
                                                {
                                                    continue;
                                                }
                                                num7 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                num2 = 0;
                                                try
                                                {
                                                    num2 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[2]);
                                                }
                                                catch (Exception exception6)
                                                {
                                                    ProjectData.SetProjectError(exception6);
                                                    num2 = 0;
                                                    if (num7 != 0)
                                                    {
                                                        innerText = "ERROR: MOUNT WITH INDEX " + Conversions.ToString(num7) + " HAS NO DBID LISTED (Example: <MountRemove_<MountIndex>_<MountDBID> ). THIS MAY CAUSE THE WRONG MOUNT TO BE DELETED IN CASE A DATABASE UPDATE ALTERS THE MOUNT INDEX!";
                                                        StreamWriter writer26 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer26.Write("\r\n    " + innerText);
                                                        writer26.Close();
                                                    }
                                                    ProjectData.ClearProjectError();
                                                }
                                                if (num7 <= 0)
                                                {
                                                    continue;
                                                }
                                                try
                                                {
                                                    if (unit.m_Mounts[num7 - 1].DBID == num2)
                                                    {
                                                        string name = unit.m_Mounts[num7 - 1].Name;
                                                        unit.m_Mounts[num7 - 1] = null;
                                                        ScenarioArrayUtil.RemoveMount(ref unit.m_Mounts, unit.m_Mounts[num7 - 1]);
                                                        innerText = ("Removed Mount with index " + Conversions.ToString(num7) + ", DBID: " + Conversions.ToString(num2) + " Name: " + name) ?? "";
                                                        StreamWriter writer27 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer27.Write("\r\n    " + innerText);
                                                        writer27.Close();
                                                    }
                                                    else
                                                    {
                                                        innerText = "ERROR: MOUNT WITH INDEX " + Conversions.ToString(num7) + " ON THE UNIT DOES NOT HAVE A DBID OF " + Conversions.ToString(num2);
                                                        StreamWriter writer28 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer28.Write("\r\n    " + innerText);
                                                        writer28.Close();
                                                    }
                                                    continue;
                                                }
                                                catch (Exception exception7)
                                                {
                                                    ProjectData.SetProjectError(exception7);
                                                    innerText = "ERROR: MOUNT WITH INDEX " + Conversions.ToString(num7) + " AND DBID " + Conversions.ToString(num2) + " COULD NOT BE DELETED, NOT FOUND ON UNIT!";
                                                    StreamWriter writer29 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer29.Write("\r\n    " + innerText);
                                                    writer29.Close();
                                                    ProjectData.ClearProjectError();
                                                    continue;
                                                }
                                            }
                                            if (str10 != "MagRemove")
                                            {
                                                continue;
                                            }
                                            num12 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                            num4 = 0;
                                            try
                                            {
                                                num4 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[2]);
                                            }
                                            catch (Exception exception8)
                                            {
                                                ProjectData.SetProjectError(exception8);
                                                num4 = 0;
                                                if (num12 != 0)
                                                {
                                                    innerText = "ERROR: MAGAZINE WITH INDEX " + Conversions.ToString(num12) + " HAS NO DBID LISTED (Example: <MagRemove_<MagIndex>_<MagDBID> ). THIS MAY CAUSE THE WRONG MAGAZINE TO BE DELETED IN CASE A DATABASE UPDATE ALTERS THE MAGAZINE INDEX!";
                                                    StreamWriter writer30 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer30.Write("\r\n    " + innerText);
                                                    writer30.Close();
                                                }
                                                ProjectData.ClearProjectError();
                                            }
                                            if (num12 <= 0)
                                            {
                                                continue;
                                            }
                                            try
                                            {
                                                if (unit.GetMagazines()[num12 - 1].DBID == num4)
                                                {
                                                    string str18 = unit.GetMagazines()[num12 - 1].Name;
                                                    unit.GetMagazines()[num12 - 1] = null;

                                                    Magazine[] magazines2X = unit.GetMagazines();

                                                    ScenarioArrayUtil.RemoveMagazine(ref magazines2X, unit.GetMagazines()[num12 - 1]);
                                                    innerText = "Removed Mag with index " + Conversions.ToString(num12) + ", DBID: " + Conversions.ToString(num4) + " Name: " + str18;
                                                    StreamWriter writer31 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer31.Write("\r\n    " + innerText);
                                                    writer31.Close();
                                                }
                                                else
                                                {
                                                    innerText = "ERROR: MAG WITH INDEX " + Conversions.ToString(num12) + " ON THE UNIT DOES NOT HAVE A DBID OF " + Conversions.ToString(num4);
                                                    StreamWriter writer32 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer32.Write("\r\n    " + innerText);
                                                    writer32.Close();
                                                }
                                                continue;
                                            }
                                            catch (Exception exception9)
                                            {
                                                ProjectData.SetProjectError(exception9);
                                                innerText = "ERROR: MAGAZINE WITH INDEX " + Conversions.ToString(num12) + " AND DBID " + Conversions.ToString(num4) + " COULD NOT BE DELETED, NOT FOUND ON UNIT!";
                                                StreamWriter writer33 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                writer33.Write("\r\n    " + innerText);
                                                writer33.Close();
                                                ProjectData.ClearProjectError();
                                                continue;
                                            }
                                        }
                                        if (num <= 0xd592ac2f)
                                        {
                                            if (num != 0xc419b557)
                                            {
                                                if ((num == 0xd592ac2f) && (str10 == "#comment"))
                                                {
                                                    innerText = node3.InnerText;
                                                    StreamWriter writer34 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer34.Write("  --  " + innerText);
                                                    writer34.Close();
                                                }
                                            }
                                            else if (str10 == "SetFuel")
                                            {
                                                float num16 = Conversions.ToSingle(node3.Name.Split(new char[] { '_' })[1].Replace(",", "."));
                                                if (unit.IsAircraft)
                                                {
                                                    ((Aircraft)unit).SetFuelQuantity(num16);
                                                }
                                                else if ((!unit.IsFacility && !unit.IsShip) && unit.IsSubmarine)
                                                {
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (num != 0xd9fdd647)
                                            {
                                                if ((num != 0xe611c299) || (str10 != "CommRemove"))
                                                {
                                                    continue;
                                                }
                                                int num17 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                try
                                                {
                                                    num11 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[2]);
                                                }
                                                catch (Exception exception10)
                                                {
                                                    ProjectData.SetProjectError(exception10);
                                                    num11 = 0;
                                                    if (num17 != 0)
                                                    {
                                                        innerText = "ERROR: COMM WITH INDEX " + Conversions.ToString(num17) + " HAS NO DBID LISTED (Example: <CommRemove_<CommIndex>_<CommDBID> ). THIS MAY CAUSE THE WRONG COMM GEAR TO BE DELETED IN CASE A DATABASE UPDATE ALTERS THE COMM INDEX!";
                                                        StreamWriter writer35 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer35.Write("\r\n    " + innerText);
                                                        writer35.Close();
                                                    }
                                                    ProjectData.ClearProjectError();
                                                }
                                                if (num17 <= 0)
                                                {
                                                    continue;
                                                }
                                                try
                                                {
                                                    if (num11 == unit.GetCommDevices()[num17 - 1].DBID)
                                                    {
                                                        string str19 = unit.GetCommDevices()[num17 - 1].Name;
                                                        unit.RemoveCommDevice(unit.GetCommDevices()[num17 - 1]);
                                                        innerText = "Removed Comm with index " + Conversions.ToString(num17) + ", DBID: " + Conversions.ToString(num11) + " Name: " + str19;
                                                        StreamWriter writer36 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer36.Write("\r\n    " + innerText);
                                                        writer36.Close();
                                                    }
                                                    else
                                                    {
                                                        innerText = "ERROR: COMM GEAR WITH INDEX " + Conversions.ToString(num17) + " ON THE UNIT DOES NOT HAVE A DBID OF " + Conversions.ToString(num11);
                                                        StreamWriter writer37 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer37.Write("\r\n    " + innerText);
                                                        writer37.Close();
                                                    }
                                                    continue;
                                                }
                                                catch (Exception exception11)
                                                {
                                                    ProjectData.SetProjectError(exception11);
                                                    innerText = "ERROR: COMM GEAR WITH INDEX " + Conversions.ToString(num17) + " AND DBID " + Conversions.ToString(num11) + " COULD NOT BE DELETED, NOT FOUND ON UNIT!";
                                                    StreamWriter writer38 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                    writer38.Write("\r\n    " + innerText);
                                                    writer38.Close();
                                                    ProjectData.ClearProjectError();
                                                    continue;
                                                }
                                            }
                                            if (str10 == "SensorRemove")
                                            {
                                                int num18 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[1]);
                                                num14 = 0;
                                                try
                                                {
                                                    num14 = Conversions.ToInteger(node3.Name.Split(new char[] { '_' })[2]);
                                                }
                                                catch (Exception exception12)
                                                {
                                                    ProjectData.SetProjectError(exception12);
                                                    num14 = 0;
                                                    if (num18 != 0)
                                                    {
                                                        innerText = "ERROR: SENSOR WITH INDEX " + Conversions.ToString(num18) + " HAS NO DBID LISTED (Example: <SensorRemove_<SensorIndex>_<SensorDBID> ). THIS MAY CAUSE THE WRONG SENSOR TO BE DELETED IN CASE A DATABASE UPDATE ALTERS THE SENSOR INDEX!";
                                                        StreamWriter writer39 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer39.Write("\r\n    " + innerText);
                                                        writer39.Close();
                                                    }
                                                    ProjectData.ClearProjectError();
                                                }
                                                if (num18 > 0)
                                                {
                                                    try
                                                    {
                                                        if (num14 == unit.GetNoneMCMSensors()[num18 - 1].DBID)
                                                        {
                                                            string str20 = unit.GetNoneMCMSensors()[num18 - 1].Name;
                                                            unit.RemoveSensor(unit.GetNoneMCMSensors()[num18 - 1]);
                                                            innerText = "Removed Sensor with index " + Conversions.ToString(num18) + ", DBID: " + Conversions.ToString(num14) + " Name: " + str20;
                                                            StreamWriter writer40 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer40.Write("\r\n    " + innerText);
                                                            writer40.Close();
                                                        }
                                                        else
                                                        {
                                                            innerText = "ERROR: SENSOR WITH INDEX " + Conversions.ToString(num18) + " ON THE UNIT DOES NOT HAVE A DBID OF " + Conversions.ToString(num14);
                                                            StreamWriter writer41 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                            writer41.Write("\r\n    " + innerText);
                                                            writer41.Close();
                                                        }
                                                        continue;
                                                    }
                                                    catch (Exception exception13)
                                                    {
                                                        ProjectData.SetProjectError(exception13);
                                                        innerText = "ERROR: SENSOR WITH INDEX " + Conversions.ToString(num18) + " AND DBID " + Conversions.ToString(num14) + " COULD NOT BE DELETED, NOT FOUND ON UNIT!";
                                                        StreamWriter writer42 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                                                        writer42.Write("\r\n    " + innerText);
                                                        writer42.Close();
                                                        ProjectData.ClearProjectError();
                                                        continue;
                                                    }
                                                }
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
                        }
                        return;
                    Label_227B:
                        innerText = "  ERROR: NO UNIT WITH DBID " + Conversions.ToString(unit.DBID) + " FOUND IN DATABASE!\r\n";
                        StreamWriter writer3 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                        writer3.Write("\r\n  " + innerText);
                        writer3.Close();
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
                innerText = "ERROR: NO INI CONFIGURATION FILE FOUND!";
                StreamWriter writer43 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + @"\Logs\SBR log file.txt");
                writer43.Write("\r\n  " + innerText);
                writer43.Close();
                Interaction.MsgBox("No XML data found.", MsgBoxStyle.ApplicationModal, null);
            }
            catch (Exception exception14)
            {
                ProjectData.SetProjectError(exception14);
                Exception exception15 = exception14;
                exception15.Data.Add("Error at 101118", "");
                GameGeneral.LogException(ref exception15);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }

        }

        // Token: 0x06006AB1 RID: 27313 RVA: 0x0039E5EC File Offset: 0x0039C7EC
        public static void smethod_9(Scenario scenario_0)
		{
			checked
			{
				try
				{
					string text = "\r\nPlatform list: \r\n  DBID -- Unit name  ----  Class Info  ----  ObjectID\r\n";
					StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
					streamWriter.Write(text);
					streamWriter.Close();
					foreach (ActiveUnit current in scenario_0.GetActiveUnits().Values)
					{
						SQLiteDataBase db = new SQLiteDataBase(scenario_0.GetSQLiteConnection());
						string string_ = "";
						string string_2 = "";
						string string_3 = "";
						switch (current.GetUnitType())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							string_ = "Select YearCommissioned, YearDecommissioned from DataAircraft where ID = " + Conversions.ToString(current.DBID);
							string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataAircraft where ID = " + Conversions.ToString(current.DBID) + ")";
							string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataAircraft where ID = " + Conversions.ToString(current.DBID) + ")";
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							string_ = "Select YearCommissioned, YearDecommissioned from DataShip where ID = " + Conversions.ToString(current.DBID);
							string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataShip where ID = " + Conversions.ToString(current.DBID) + ")";
							string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataShip where ID = " + Conversions.ToString(current.DBID) + ")";
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							string_ = "Select YearCommissioned, YearDecommissioned from DataSubmarine where ID = " + Conversions.ToString(current.DBID);
							string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataSubmarine where ID = " + Conversions.ToString(current.DBID) + ")";
							string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataSubmarine where ID = " + Conversions.ToString(current.DBID) + ")";
							break;
						case GlobalVariables.ActiveUnitType.Facility:
							string_ = "Select YearCommissioned, YearDecommissioned from DataFacility where ID = " + Conversions.ToString(current.DBID);
							string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataFacility where ID = " + Conversions.ToString(current.DBID) + ")";
							string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataFacility where ID = " + Conversions.ToString(current.DBID) + ")";
							break;
						case GlobalVariables.ActiveUnitType.Satellite:
							string_ = "Select YearCommissioned, YearDecommissioned from DataSatellite where ID = " + Conversions.ToString(current.DBID);
							string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataSatellite where ID = " + Conversions.ToString(current.DBID) + ")";
							string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataSatellite where ID = " + Conversions.ToString(current.DBID) + ")";
							break;
						}
						if (current.IsAircraft | current.IsFacility | current.IsShip | current.IsSubmarine | current.IsSatellite())
						{
							DataTable dataTable = CachedDataBase.GetDataTable(db, string_);
							DataTable dataTable2 = CachedDataBase.GetDataTable(db, string_2);
							DataTable dataTable3 = CachedDataBase.GetDataTable(db, string_3);
							if (!(dataTable.Rows.Count != 0 & dataTable2.Rows.Count != 0 & dataTable3.Rows.Count != 0))
							{
								text = "  ERROR: NO UNIT WITH ID " + Conversions.ToString(current.DBID) + " FOUND IN DATABASE!\r\n";
								StreamWriter streamWriter2 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
								streamWriter2.Write("\r\n  " + text);
								streamWriter2.Close();
								break;
							}
							DataRow dataRow = dataTable.Rows[0];
							DataRow dataRow2 = dataTable2.Rows[0];
							DataRow dataRow3 = dataTable3.Rows[0];
							string text2 = Strings.Trim(dataRow2["Description"].ToString());
							string text3 = Strings.Trim(dataRow3["Description"].ToString());
							string text4 = Conversions.ToString(Conversions.ToInteger(dataRow["YearCommissioned"].ToString()));
							string text5 = Conversions.ToString(Conversions.ToInteger(dataRow["YearDecommissioned"].ToString()));
							if (current.IsOperating())
							{
								if (current.IsAircraft)
								{
									Aircraft aircraft = (Aircraft)current;
									text = string.Concat(new string[]
									{
										"  ",
										Conversions.ToString(aircraft.DBID),
										" -- ",
										aircraft.Name,
										" -- ",
										aircraft.UnitClass,
										" -- ",
										text2,
										" (",
										text3,
										"), ",
										text4,
										"-",
										text5,
										" : ",
										Conversions.ToString(aircraft.GetLoadoutDBID()),
										" -- ",
										aircraft.GetLoadoutName(),
										"  ----  ",
										aircraft.GetGuid(),
										"\r\n"
									});
								}
								else
								{
									text = string.Concat(new string[]
									{
										"  ",
										Conversions.ToString(current.DBID),
										" -- ",
										current.Name,
										"  ----  ",
										current.UnitClass,
										" -- ",
										text2,
										" (",
										text3,
										"), ",
										text4,
										"-",
										text5,
										"  ----  ",
										current.GetGuid(),
										"\r\n"
									});
								}
								StreamWriter streamWriter3 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
								streamWriter3.Write(text);
								streamWriter3.Close();
								try
								{
									AirFacility[] airFacilities = current.GetAirFacilities();
									for (int i = 0; i < airFacilities.Length; i++)
									{
										AirFacility airFacility = airFacilities[i];
										foreach (Aircraft current2 in airFacility.GetHostedAircrafts().Values)
										{
											string_ = "Select YearCommissioned, YearDecommissioned from DataAircraft where ID = " + Conversions.ToString(current2.DBID);
											string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataAircraft where ID = " + Conversions.ToString(current2.DBID) + ")";
											string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataAircraft where ID = " + Conversions.ToString(current2.DBID) + ")";
											dataTable = CachedDataBase.GetDataTable(db, string_);
											dataTable2 = CachedDataBase.GetDataTable(db, string_2);
											dataTable3 = CachedDataBase.GetDataTable(db, string_3);
											if (!(dataTable.Rows.Count != 0 & dataTable2.Rows.Count != 0 & dataTable3.Rows.Count != 0))
											{
												text = "  ERROR: NO UNIT WITH ID " + Conversions.ToString(current2.DBID) + " FOUND IN DATABASE!\r\n";
												StreamWriter streamWriter4 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
												streamWriter4.Write("\r\n  " + text);
												streamWriter4.Close();
												return;
											}
											DataRow dataRow4 = dataTable.Rows[0];
											DataRow dataRow5 = dataTable2.Rows[0];
											DataRow dataRow6 = dataTable3.Rows[0];
											text2 = Strings.Trim(dataRow5["Description"].ToString());
											text3 = Strings.Trim(dataRow6["Description"].ToString());
											text4 = dataRow4["YearCommissioned"].ToString();
											text5 = dataRow4["YearDecommissioned"].ToString();
											text = string.Concat(new string[]
											{
												"    ",
												Conversions.ToString(current2.DBID),
												" -- ",
												current2.UnitClass,
												" -- ",
												text2,
												" (",
												text3,
												"), ",
												text4,
												"-",
												text5,
												" : ",
												Conversions.ToString(current2.GetLoadoutDBID()),
												" -- ",
												current2.GetLoadoutName(),
												"  ----  ",
												current2.Name,
												"  ----  ",
												current2.GetGuid(),
												"\r\n"
											});
											StreamWriter streamWriter5 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
											streamWriter5.Write(text);
											streamWriter5.Close();
										}
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200097", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
								try
								{
									DockFacility[] dockFacilities = current.GetDockFacilities();
									for (int j = 0; j < dockFacilities.Length; j++)
									{
										DockFacility dockFacility = dockFacilities[j];
										foreach (ActiveUnit current3 in dockFacility.LazyDockedUnitsDictionary.Value.Values)
										{
											GlobalVariables.ActiveUnitType unitType = current.GetUnitType();
											if (unitType != GlobalVariables.ActiveUnitType.Ship)
											{
												if (unitType == GlobalVariables.ActiveUnitType.Submarine)
												{
													string_ = "Select YearCommissioned, YearDecommissioned from DataSubmarine where ID = " + Conversions.ToString(current3.DBID);
													string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataSubmarine where ID = " + Conversions.ToString(current3.DBID) + ")";
													string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataSubmarine where ID = " + Conversions.ToString(current3.DBID) + ")";
												}
											}
											else
											{
												string_ = "Select YearCommissioned, YearDecommissioned from DataShip where ID = " + Conversions.ToString(current3.DBID);
												string_2 = "Select Description from EnumOperatorCountry where ID in (Select OperatorCountry from DataShip where ID = " + Conversions.ToString(current3.DBID) + ")";
												string_3 = "Select Description from EnumOperatorService where ID in (Select OperatorService from DataShip where ID = " + Conversions.ToString(current3.DBID) + ")";
											}
											dataTable = CachedDataBase.GetDataTable(db, string_);
											dataTable2 = CachedDataBase.GetDataTable(db, string_2);
											dataTable3 = CachedDataBase.GetDataTable(db, string_3);
											if (!(dataTable.Rows.Count != 0 & dataTable2.Rows.Count != 0 & dataTable3.Rows.Count != 0))
											{
												text = "  ERROR: NO UNIT WITH ID " + Conversions.ToString(current3.DBID) + " FOUND IN DATABASE!\r\n";
												StreamWriter streamWriter6 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
												streamWriter6.Write("\r\n  " + text);
												streamWriter6.Close();
												return;
											}
											DataRow dataRow7 = dataTable.Rows[0];
											DataRow dataRow8 = dataTable2.Rows[0];
											DataRow dataRow9 = dataTable3.Rows[0];
											text2 = Strings.Trim(dataRow8["Description"].ToString());
											text3 = Strings.Trim(dataRow9["Description"].ToString());
											text4 = Conversions.ToString(Conversions.ToInteger(dataRow7["YearCommissioned"].ToString()));
											text5 = Conversions.ToString(Conversions.ToInteger(dataRow7["YearDecommissioned"].ToString()));
											text = string.Concat(new string[]
											{
												"    ",
												Conversions.ToString(current3.DBID),
												" -- ",
												current3.Name,
												" -- ",
												text2,
												" (",
												text3,
												"), ",
												text4,
												"-",
												text5,
												"  ----  ",
												current3.UnitClass,
												"  ----  ",
												current3.GetGuid(),
												"\r\n"
											});
											StreamWriter streamWriter7 = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
											streamWriter7.Write(text);
											streamWriter7.Close();
										}
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ex4.Data.Add("Error at 200098", ex4.Message);
									GameGeneral.LogException(ref ex4);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ex6.Data.Add("Error at 101119", "");
					GameGeneral.LogException(ref ex6);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x0039F370 File Offset: 0x0039D570
		public static void smethod_10(ref Scenario scenario_0)
		{
			List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ActiveUnit current = enumerator.Current;
					if (current.IsAircraft)
					{
						((Aircraft)current).GetAircraftSensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
					}
					else if (current.IsFacility)
					{
						((Facility)current).GetFacilitySensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
					}
					else if (current.IsShip)
					{
						((Ship)current).GetShipSensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
					}
					else if (current.IsSubmarine)
					{
						((Submarine)current).GetSubmarineSensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
					}
					else if (current.IsSatellite())
					{
						((Satellite)current).GetSensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
					}
				}
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

		// Token: 0x06006AB3 RID: 27315 RVA: 0x0039F47C File Offset: 0x0039D67C
		public static void smethod_11(string string_0)
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			XmlDocument xmlDocument = new XmlDocument();
			checked
			{
				try
				{
					using (fileStream)
					{
						try
						{
							xmlDocument.Load(fileStream);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							Interaction.MsgBox("Scenario List file is improperly formatted, read failed!", MsgBoxStyle.OkOnly, null);
							ProjectData.ClearProjectError();
						}
					}
					XmlNode xmlNode = xmlDocument.SelectSingleNode("/ScenarioList");
					if (xmlNode != null)
					{
						XmlNodeList childNodes = xmlNode.ChildNodes;
						IEnumerator enumerator = childNodes.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator.Current;
								StreamWriter streamWriter;
								try
								{
									string text = "";
									string text2 = "";
									IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
											string left = xmlNode3.Name.Split(new char[]
											{
												'_'
											})[0];
											if (Operators.CompareString(left, "ScenarioFilePath", false) != 0)
											{
												if (Operators.CompareString(left, "ConfigFilePath", false) != 0)
												{
													continue;
												}
												try
												{
													IEnumerator enumerator3 = xmlNode3.ChildNodes.GetEnumerator();
													try
													{
														while (enumerator3.MoveNext())
														{
															XmlNode xmlNode4 = (XmlNode)enumerator3.Current;
															string left2 = xmlNode4.Name.Split(new char[]
															{
																'_'
															})[0];
															if (Operators.CompareString(left2, "#comment", false) == 0)
															{
																text = xmlNode4.InnerText;
															}
														}
													}
													finally
													{
														if (enumerator3 is IDisposable)
														{
															(enumerator3 as IDisposable).Dispose();
														}
													}
													continue;
												}
												catch (Exception projectError2)
												{
													ProjectData.SetProjectError(projectError2);
													Interaction.MsgBox("No config file path found.", MsgBoxStyle.OkOnly, null);
													ProjectData.ClearProjectError();
													continue;
												}
											}
											try
											{
												IEnumerator enumerator4 = xmlNode3.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator4.MoveNext())
													{
														XmlNode xmlNode5 = (XmlNode)enumerator4.Current;
														string left2 = xmlNode5.Name.Split(new char[]
														{
															'_'
														})[0];
														if (Operators.CompareString(left2, "#comment", false) == 0)
														{
															text2 = xmlNode5.InnerText;
															Application.DoEvents();
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
											}
											catch (Exception projectError3)
											{
												ProjectData.SetProjectError(projectError3);
												Interaction.MsgBox("No scenario file path found.", MsgBoxStyle.OkOnly, null);
												ProjectData.ClearProjectError();
											}
										}
									}
									finally
									{
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
									int value = 0;
									value = 1;
									if (File.Exists(text2))
									{
										Scenario scenario = null;
										Scenario expression = scenario;
										if (!Information.IsNothing(expression))
										{
											GameGeneral.ClearActiveUnits(ref expression);
										}
										ScenContainer scenContainer = ScenContainer.smethod_2(text2);
										string text3 = "";
										double num = 0.0;
										scenario = scenContainer.LoadScenario(ref text3, ref num, false);
										GameGeneral.ClearScenarioStreamDictionary();
										string text4 = string.Concat(new string[]
										{
											"Scenario ",
											Conversions.ToString(value),
											": ",
											scenario.GetScenarioTitle(),
											"\r\nScenario file: ",
											text2,
											"\r\nConfig file:   ",
											text
										});
										streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n\r\n" + text4);
										streamWriter.Close();
										streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
										streamWriter.Write("\r\n\r\n" + text4);
										streamWriter.Close();
										DBOps.DBFileCheckResult dbfileCheckResult_ = DBOps.DBFileCheckResult.Undefined;
										DBRecord dBRecord = DBOps.GetDBRecord(scenario.GetDBUsed(), ref dbfileCheckResult_, true, true);
										if (Information.IsNothing(dBRecord))
										{
											Interaction.MsgBox("Error: " + DBOps.smethod_7(dbfileCheckResult_) + "\r\nAborting...", MsgBoxStyle.OkOnly, null);
											break;
										}
										scenario.GetDBUsed();
										string dBRecordHash = DBOps.GetDBRecordHash(dBRecord.DBID);
										scenario.SetDBUsed(dBRecordHash);
										List<string> list = ScenarioUnits.smethod_12(scenario, dBRecordHash, false);
										if (list.Count > 0)
										{
											text4 = "  ERROR: ONE OR MORE PLATFORMS FEATURED IN THIS SCENARIO IS MISSING FROM THE DATABASE YOU ARE ATTEMPTING TO MIGRATE TO.\r\n  THE MISSING PLATFORMS ARE AS FOLLOWS:\r\n";
											foreach (string current in list)
											{
												text4 = text4 + "  " + current + "\r\n";
											}
											text4 += "  Please contact the author of this DB in order to have this problem rectified. The unit(s) have to be deleted and replaced with units that actually exist in the database.\r\n";
											text4 += "  MIGRATION ABORTED!";
											streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Close();
											text4 = "Scenario " + Conversions.ToString(value) + ": ERROR! REBUILD FAILED!";
											streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n\r\n" + text4);
											streamWriter.Close();
											continue;
										}
										scenario.LastSavedInScenEdit = true;
										Class260.SaveTempScenarioFile(scenario, scenario.GetSides()[0], text2, true, false);
										scenario = null;
										GameGeneral.ForceGarbageCollection();
										Thread.Sleep(2000);
										expression = scenario;
										if (!Information.IsNothing(expression))
										{
											GameGeneral.ClearActiveUnits(ref expression);
										}
										ScenContainer scenContainer2 = ScenContainer.smethod_2(text2);
										text3 = "";
										num = 0.0;
										scenario = scenContainer2.LoadScenario(ref text3, ref num, true);
										GameGeneral.ClearScenarioStreamDictionary();
										List<string> list2 = ScenarioUnits.smethod_13(scenario);
										if (list2.Count > 0)
										{
											text4 = "  ERROR: ONE OR MORE AIRCRAFT FEATURED IN THIS SCENARIO CARRY A LOADOUT THAT IS NOT IN THE AIRCRAFT'S LOADOUT LIST.\r\n  PLATFORMS ARE AS FOLLOWS:\r\n";
											foreach (string current2 in list2)
											{
												text4 = text4 + "  " + current2 + "\r\n";
											}
											text4 += "  Please contact the author of this DB in order to have this problem rectified.";
											streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n" + text4);
											streamWriter.Close();
										}
										List<string> list3 = new List<string>();
										Side[] sides = scenario.GetSides();
										for (int i = 0; i < sides.Length; i++)
										{
											Side side = sides[i];
											if (!Information.IsNothing(side.GetMissionCollection()))
											{
                                                Mission current3X;
                                                foreach (Mission current3 in side.GetPatrolMissionCollection(scenario))
												{
                                                    current3X = current3;
                                                    list3.AddRange(scenario.FlightSizeHardLimitCheckInfo(ref side, ref current3X));
												}
											}
										}
										if (list3.Count > 0)
										{
											text4 = "  警告!由于编队规模限制，该任务行动中的某些飞机不能起飞!\r\n\r\n为解决这个问题，您可以改变编队规模，向任务行动中分配更多飞机，也可以改变现有飞机的挂载方案使得足够多的飞机具备相同的挂载，或者取消对“飞机数量低于编队规模不允许起飞”标志位的选择。\r\n";
											foreach (string current4 in list3)
											{
												text4 = text4 + "\r\n    " + current4;
											}
											streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n" + text4);
											streamWriter.Close();
										}
										text4 = "";
										scenario.ZoneAreaCheck(true, ref text4);
										if (!string.IsNullOrEmpty(text4))
										{
											text4 = "  ERROR! SOME AREAS IN THIS SCENARIO HAS PROBLEMS!\r\n" + text4;
											streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
											streamWriter.Write("\r\n" + text4);
											streamWriter.Close();
										}
										ScenarioUnits.smethod_8(scenario, text, false, null);
										ScenarioUnits.smethod_9(scenario);
										foreach (ActiveUnit current5 in scenario.GetActiveUnitList())
										{
											current5.GetSensory().ScheduleEMCONEvent(current5.GetAllNoneMCMSensors());
										}
										scenario.LastSavedInScenEdit = true;
										Class260.SaveTempScenarioFile(scenario, scenario.GetSides()[0], text2, true, false);
										text4 = "Scenario " + Conversions.ToString(value) + ": Rebuild Completed";
										streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n" + text4);
										streamWriter.Close();
										streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
										streamWriter.Write(text4);
										streamWriter.Close();
									}
									else
									{
										string text4 = "Scenario " + Conversions.ToString(value) + ": ERROR! FILE NOT FOUND!";
										streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
										streamWriter.Write("\r\n\r\n" + text4);
										streamWriter.Close();
										streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
										streamWriter.Write("\r\n\r\n" + text4);
										streamWriter.Close();
									}
								}
								catch (Exception projectError4)
								{
									ProjectData.SetProjectError(projectError4);
									int value = 0;
									string text4 = "Scenario " + Conversions.ToString(0) + ": ERROR! LOAD FAILED!";
									streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
									streamWriter.Write("\r\n\r\n" + text4);
									streamWriter.Close();
									ProjectData.ClearProjectError();
								}
								streamWriter.Dispose();
								streamWriter = null;
								GameGeneral.ForceGarbageCollection();
								Thread.Sleep(2000);
							}
							goto IL_9C9;
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					Interaction.MsgBox("No XML data found.", MsgBoxStyle.OkOnly, null);
					IL_9C9:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101120", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x003A0000 File Offset: 0x0039E200
		public static List<string> smethod_12(Scenario scenario_0, string string_0, bool bool_0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			List<string> list = new List<string>();
			List<string> result = null;
			checked
			{
				try
				{
					DBOps.DBFileCheckResult dbfileCheckResult_ = DBOps.DBFileCheckResult.Undefined;
					DBRecord dBRecord = DBOps.GetDBRecord(string_0, ref dbfileCheckResult_, true, true);
					if (Information.IsNothing(dBRecord))
					{
						throw new Exception(DBOps.smethod_7(dbfileCheckResult_));
					}
					List<string> list2 = dBRecord.method_0();
					Weapon[] array = null;
					List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ActiveUnit current = enumerator.Current;
							if (current.IsAircraft)
							{
								if (hashSet.Contains("Aircraft #" + Conversions.ToString(current.DBID)))
								{
									continue;
								}
								hashSet.Add("Aircraft #" + Conversions.ToString(current.DBID));
								if (!list2.Contains("Aircraft #" + Conversions.ToString(current.DBID)))
								{
									list.Add("Aircraft #" + Conversions.ToString(current.DBID) + ", " + current.UnitClass);
								}
							}
							else if (current.IsShip)
							{
								if (hashSet.Contains("Ship #" + Conversions.ToString(current.DBID)))
								{
									continue;
								}
								hashSet.Add("Ship #" + Conversions.ToString(current.DBID));
								if (!list2.Contains("Ship #" + Conversions.ToString(current.DBID)))
								{
									list.Add("Ship #" + Conversions.ToString(current.DBID) + ", " + current.UnitClass);
								}
							}
							else if (current.IsSubmarine)
							{
								if (hashSet.Contains("Submarine #" + Conversions.ToString(current.DBID)))
								{
									continue;
								}
								hashSet.Add("Submarine #" + Conversions.ToString(current.DBID));
								if (!list2.Contains("Submarine #" + Conversions.ToString(current.DBID)))
								{
									list.Add("Submarine #" + Conversions.ToString(current.DBID) + ", " + current.UnitClass);
								}
							}
							else if (current.IsFacility)
							{
								if (hashSet.Contains("Facility #" + Conversions.ToString(current.DBID)))
								{
									continue;
								}
								hashSet.Add("Facility #" + Conversions.ToString(current.DBID));
								if (!list2.Contains("Facility #" + Conversions.ToString(current.DBID)))
								{
									list.Add("Facility #" + Conversions.ToString(current.DBID) + ", " + current.UnitClass);
								}
							}
							else if (current.IsWeapon)
							{
								if (hashSet.Contains("Weapon #" + Conversions.ToString(current.DBID)))
								{
									continue;
								}
								hashSet.Add("Weapon #" + Conversions.ToString(current.DBID));
								if (!list2.Contains("Weapon #" + Conversions.ToString(current.DBID)))
								{
									list.Add("Weapon #" + Conversions.ToString(current.DBID) + ", " + current.Name);
								}
							}
							else if (current.IsSatellite())
							{
								if (hashSet.Contains("Satellite #" + Conversions.ToString(current.DBID)))
								{
									continue;
								}
								hashSet.Add("Satellite #" + Conversions.ToString(current.DBID));
								if (!list2.Contains("Satellite #" + Conversions.ToString(current.DBID)))
								{
									list.Add("Satellite #" + Conversions.ToString(current.DBID) + ", " + current.UnitClass);
								}
							}
							else if (!current.IsGroup)
							{
								throw new NotImplementedException();
							}
							if (bool_0)
							{
								array = current.GetWeaponry().GetAvailableWeapons(true);
								Weapon[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									Weapon weapon = array2[i];
									if (!hashSet.Contains("Weapon #" + Conversions.ToString(current.DBID)))
									{
										hashSet.Add("Weapon #" + Conversions.ToString(current.DBID));
										if (!list2.Contains("Weapon #" + Conversions.ToString(weapon.DBID)))
										{
											list.Add("Weapon #" + Conversions.ToString(current.DBID) + ", " + weapon.Name);
										}
									}
								}
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					if (!Information.IsNothing(array))
					{
						ScenarioArrayUtil.NewWeapon(ref array);
					}
					array = null;
					if (!Information.IsNothing(hashSet))
					{
						hashSet.Clear();
					}
					hashSet = null;
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101121", "");
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

		// Token: 0x06006AB5 RID: 27317 RVA: 0x003A05B8 File Offset: 0x0039E7B8
		public static List<string> smethod_13(Scenario scenario_)
		{
			SQLiteDataBase sQLiteDataBase = new SQLiteDataBase(scenario_.GetSQLiteConnection());
			List<string> list = new List<string>();
			List<string> result = null;
			try
			{
				foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
				{
					if (current.IsAircraft)
					{
						Aircraft aircraft = (Aircraft)current;
						string string_ = "Select ID from DataAircraftLoadouts where ID = " + Conversions.ToString(aircraft.DBID) + " and ComponentID = " + Conversions.ToString(aircraft.GetLoadoutDBID());
						if (sQLiteDataBase.GetDataTable(string_).Rows.Count == 0 & aircraft.GetLoadoutDBID() > 0)
						{
							Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
							string item;
							if (!current.IsOperating())
							{
								item = string.Concat(new string[]
								{
									"Aircraft: ",
									aircraft.UnitClass,
									", Callsign: ",
									aircraft.Name,
									", DBID: ",
									Conversions.ToString(aircraft.DBID),
									", Loadout: ",
									aircraft.GetLoadout().Name,
									", DBID: ",
									Conversions.ToString(aircraft.GetLoadout().DBID),
									" (Parked on ",
									aircraftAirOps.GetCurrentHostUnit().UnitClass,
									")"
								});
							}
							else
							{
								item = string.Concat(new string[]
								{
									"Aircraft: ",
									aircraft.UnitClass,
									", DBID: ",
									Conversions.ToString(aircraft.DBID),
									", Loadout: ",
									aircraft.GetLoadout().Name,
									", DBID: ",
									Conversions.ToString(aircraft.GetLoadout().DBID),
									" (Airborne)"
								});
							}
							list.Add(item);
						}
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101122", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x02000C93 RID: 3219
		[CompilerGenerated]
		public sealed class CargoComparer
		{
			// Token: 0x06006AB7 RID: 27319 RVA: 0x0002DDE3 File Offset: 0x0002BFE3
			public CargoComparer(ScenarioUnits.CargoComparer value)
			{
				if (value != null)
				{
					this.m_Cargo = value.m_Cargo;
				}
			}

			// Token: 0x06006AB8 RID: 27320 RVA: 0x0002DDFD File Offset: 0x0002BFFD
			internal bool Equal(Cargo cargo_1)
			{
				return Operators.CompareString(cargo_1.GetGuid(), this.m_Cargo.GetGuid(), false) == 0;
			}

			// Token: 0x04003C43 RID: 15427
			public Cargo m_Cargo;
		}
	}
}
