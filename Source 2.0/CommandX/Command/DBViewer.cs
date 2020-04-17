using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns32;
using ns33;
using ns35;

namespace Command
{
	// 数据库查看窗口
	[DesignerGenerated]
	public sealed partial class DBViewer : CommandForm
	{
		// Token: 0x06003E7A RID: 15994 RVA: 0x001477E0 File Offset: 0x001459E0
		internal static string method_5(WeaponRec weaponRec_0)
		{
			return string.Concat(new string[]
			{
				Conversions.ToString(Interaction.IIf(weaponRec_0.GetCurrentLoad() == 0, "<i style='color:gray'>", "")),
				Conversions.ToString(weaponRec_0.GetCurrentLoad()),
				"x ",
				weaponRec_0.GetWeapon(Client.GetClientScenario()).Name,
				" (max ",
				Conversions.ToString(weaponRec_0.MaxLoad),
				")",
				Conversions.ToString(Interaction.IIf(weaponRec_0.GetCurrentLoad() == 0, "</i>", ""))
			});
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00147884 File Offset: 0x00145A84
		public DBViewer()
		{
			base.FormClosing += new FormClosingEventHandler(this.DBViewer_FormClosing);
			base.Load += new EventHandler(this.DBViewer_Load);
			base.Load += new EventHandler(this.DBViewer_Load_1);
			base.Shown += new EventHandler(this.DBViewer_Shown);
			base.KeyDown += new KeyEventHandler(this.DBViewer_KeyDown);
			base.MouseWheel += new MouseEventHandler(this.DBViewer_MouseWheel);
			this.dataTable_0 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00148004 File Offset: 0x00146204
//		[CompilerGenerated]
//		internal  ListBox vmethod_0()
//		{
//			return this.listBox_0;
//		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x0014801C File Offset: 0x0014621C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(ListBox listBox_1)
//		{
//			EventHandler value = new EventHandler(this.method_4);
//			MouseEventHandler value2 = new MouseEventHandler(this.method_42);
//			EventHandler value3 = new EventHandler(this.method_43);
//			EventHandler value4 = new EventHandler(this.method_44);
//			ListBox listBox = this.listBox_0;
//			if (listBox != null)
//			{
//				listBox.SelectedIndexChanged -= value;
//				listBox.MouseWheel -= value2;
//				listBox.MouseEnter -= value3;
//				listBox.MouseLeave -= value4;
//			}
//			this.listBox_0 = listBox_1;
//			listBox = this.listBox_0;
//			if (listBox != null)
//			{
//				listBox.SelectedIndexChanged += value;
//				listBox.MouseWheel += value2;
//				listBox.MouseEnter += value3;
//				listBox.MouseLeave += value4;
//			}
//		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x001480C4 File Offset: 0x001462C4
//		[CompilerGenerated]
//		internal  GroupBox vmethod_2()
//		{
//			return this.groupBox_0;
//		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00020655 File Offset: 0x0001E855
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(GroupBox groupBox_1)
//		{
//			this.groupBox_0 = groupBox_1;
//		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x001480DC File Offset: 0x001462DC
//		[CompilerGenerated]
//		internal  ComboBox vmethod_4()
//		{
//			return this.comboBox_0;
//		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x001480F4 File Offset: 0x001462F4
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(ComboBox comboBox_3)
//		{
//			EventHandler value = new EventHandler(this.method_6);
//			ComboBox comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted -= value;
//			}
//			this.comboBox_0 = comboBox_3;
//			comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted += value;
//			}
//		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00148140 File Offset: 0x00146340
//		[CompilerGenerated]
//		internal  Label vmethod_6()
//		{
//			return this.label_0;
//		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x0002065E File Offset: 0x0001E85E
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_7(Label label_4)
//		{
//			this.label_0 = label_4;
//		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00148158 File Offset: 0x00146358
//		[CompilerGenerated]
//		internal  Label vmethod_8()
//		{
//			return this.label_1;
//		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00020667 File Offset: 0x0001E867
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_9(Label label_4)
//		{
//			this.label_1 = label_4;
//		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00148170 File Offset: 0x00146370
//		[CompilerGenerated]
//		internal  TextBox vmethod_10()
//		{
//			return this.textBox_0;
//		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00148188 File Offset: 0x00146388
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_11(TextBox textBox_1)
//		{
//			EventHandler value = new EventHandler(this.method_2);
//			TextBox textBox = this.textBox_0;
//			if (textBox != null)
//			{
//				textBox.TextChanged -= value;
//			}
//			this.textBox_0 = textBox_1;
//			textBox = this.textBox_0;
//			if (textBox != null)
//			{
//				textBox.TextChanged += value;
//			}
//		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x001481D4 File Offset: 0x001463D4
//		[CompilerGenerated]
//		internal  ComboBox vmethod_12()
//		{
//			return this.comboBox_1;
//		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x001481EC File Offset: 0x001463EC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_13(ComboBox comboBox_3)
//		{
//			EventHandler value = new EventHandler(this.method_5);
//			ComboBox comboBox = this.comboBox_1;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted -= value;
//			}
//			this.comboBox_1 = comboBox_3;
//			comboBox = this.comboBox_1;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted += value;
//			}
//		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x00148238 File Offset: 0x00146438
//		[CompilerGenerated]
//		internal  Label vmethod_14()
//		{
//			return this.label_2;
//		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x00020670 File Offset: 0x0001E870
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_15(Label label_4)
//		{
//			this.label_2 = label_4;
//		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x00148250 File Offset: 0x00146450
//		[CompilerGenerated]
//		internal  WebBrowser vmethod_16()
//		{
//			return this.webBrowser_0;
//		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x00148268 File Offset: 0x00146468
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_17(WebBrowser webBrowser_1)
//		{
//			PreviewKeyDownEventHandler value = new PreviewKeyDownEventHandler(this.method_46);
//			WebBrowser webBrowser = this.webBrowser_0;
//			if (webBrowser != null)
//			{
//				webBrowser.PreviewKeyDown -= value;
//			}
//			this.webBrowser_0 = webBrowser_1;
//			webBrowser = this.webBrowser_0;
//			if (webBrowser != null)
//			{
//				webBrowser.PreviewKeyDown += value;
//			}
//		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x001482B4 File Offset: 0x001464B4
//		[CompilerGenerated]
//		internal  ComboBox vmethod_18()
//		{
//			return this.comboBox_2;
//		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x001482CC File Offset: 0x001464CC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_19(ComboBox comboBox_3)
//		{
//			EventHandler value = new EventHandler(this.method_45);
//			ComboBox comboBox = this.comboBox_2;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted -= value;
//			}
//			this.comboBox_2 = comboBox_3;
//			comboBox = this.comboBox_2;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted += value;
//			}
//		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00148318 File Offset: 0x00146518
//		[CompilerGenerated]
//		internal  Label vmethod_20()
//		{
//			return this.label_3;
//		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x00020679 File Offset: 0x0001E879
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_21(Label label_4)
//		{
//			this.label_3 = label_4;
//		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00004D83 File Offset: 0x00002F83
		private void DBViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void DBViewer_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00148330 File Offset: 0x00146530
		public void method_1()
		{
			if (!string.IsNullOrEmpty(this.strUnitType) && this.DBID != 0)
			{
				this.comboBox_1.SelectedItem = this.strUnitType;
				this.method_3();
				this.bool_0 = true;
				this.listBox_0.SelectedValue = this.DBID;
				this.bool_0 = false;
				this.string_1 = this.listBox_0.Text;
				string theHTML = "";
				string left = this.strUnitType;
				if (Operators.CompareString(left, "飞机", false) != 0)
				{
					if (Operators.CompareString(left, "水面舰艇", false) != 0)
					{
						if (Operators.CompareString(left, "潜艇", false) != 0)
						{
							if (Operators.CompareString(left, "战场设施", false) != 0)
							{
								if (Operators.CompareString(left, "卫星", false) != 0)
								{
									if (Operators.CompareString(left, "武器", false) == 0)
									{
										Weapon weapon = Client.GetClientScenario().GetWeapon(this.DBID);
										theHTML = this.method_41(weapon);
									}
								}
								else
								{
									Scenario clientScenario = Client.GetClientScenario();
									Satellite satellite_ = new Satellite(ref clientScenario);
									clientScenario = Client.GetClientScenario();
									DBFunctions.LoadSatelliteData(ref clientScenario, ref satellite_, this.DBID, 0, true);
									theHTML = this.GetSatelliteHTMLData(satellite_);
								}
							}
							else
							{
								Scenario clientScenario = Client.GetClientScenario();
								Facility facility_ = new Facility(ref clientScenario, "");
								clientScenario = Client.GetClientScenario();
								DBFunctions.LoadFacilityData(ref clientScenario, ref facility_, this.DBID, true);
								theHTML = this.GetFacilityHTMLData(facility_);
							}
						}
						else
						{
							Scenario clientScenario = Client.GetClientScenario();
							Submarine submarine_ = new Submarine(ref clientScenario, "");
							clientScenario = Client.GetClientScenario();
							DBFunctions.LoadSubmarineData(ref clientScenario, ref submarine_, this.DBID, true);
							theHTML = this.GetSubmarineHTMLData(submarine_);
						}
					}
					else
					{
						Scenario clientScenario = Client.GetClientScenario();
						Ship ship_ = new Ship(ref clientScenario, "");
						clientScenario = Client.GetClientScenario();
						DBFunctions.smethod_51(ref clientScenario, ref ship_, this.DBID, true);
						theHTML = this.GetShipHTMLData(ship_);
					}
				}
				else
				{
					Scenario clientScenario = Client.GetClientScenario();
					Aircraft aircraft_ = new Aircraft(ref clientScenario, "");
					clientScenario = Client.GetClientScenario();
					DBFunctions.smethod_19(ref clientScenario, ref aircraft_, this.DBID, true);
					theHTML = this.GetAircraftHTMLData(aircraft_);
				}
				Class2529.smethod_7(this.webBrowser_0, theHTML, default(Color));
			}
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00020682 File Offset: 0x0001E882
		private void DBViewer_Load_1(object sender, EventArgs e)
		{
			this.comboBox_1.SelectedIndex = 0;
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x00020690 File Offset: 0x0001E890
		private void method_2(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.textBox_0.Text, "", false) != 0)
			{
				this.method_3();
			}
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x00148568 File Offset: 0x00146768
		private void method_3()
		{
			switch (this.comboBox_1.SelectedIndex)
			{
			case 0:
				this.dataTable_0 = Client.GetClientScenario().Cache_Aircraft_DT;
				break;
			case 1:
				this.dataTable_0 = Client.GetClientScenario().Cache_Ships_DT;
				break;
			case 2:
				this.dataTable_0 = Client.GetClientScenario().Cache_Subs_DT;
				break;
			case 3:
				this.dataTable_0 = Client.GetClientScenario().Cache_Facilities_DT;
				break;
			case 4:
				this.dataTable_0 = Client.GetClientScenario().Cache_Satellites_DT;
				break;
			case 5:
				this.dataTable_0 = Client.GetClientScenario().Cache_Weapons_DT;
				break;
			default:
				return;
			}
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "LongName ASC";
			if (Operators.CompareString(this.textBox_0.Text, "", false) != 0 || this.comboBox_0.SelectedIndex != 0 || this.comboBox_2.SelectedIndex != 0)
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.textBox_0.Text, "", false) != 0)
				{
					string str = this.textBox_0.Text.Replace("'", "''");
					text = text + " AND LongName LIKE '%" + str + "%' ";
				}
				if (this.comboBox_0.Enabled && this.comboBox_0.SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + this.comboBox_0.SelectedValue.ToString();
				}
				if (this.comboBox_2.SelectedIndex == 1)
				{
					text += " AND Hypothetical=FALSE";
				}
				else if (this.comboBox_2.SelectedIndex == 2)
				{
					text += " AND Hypothetical=TRUE";
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				dataView.RowFilter = text;
			}
			this.bool_0 = true;
			this.listBox_0.DataSource = dataView;
			this.listBox_0.DisplayMember = "LongName";
			this.listBox_0.ValueMember = "ID";
			this.bool_0 = false;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x001487B4 File Offset: 0x001469B4
		private void method_4(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.DBID = Conversions.ToInteger(this.listBox_0.SelectedValue);
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.comboBox_1.SelectedItem)))
				{
					this.strUnitType = Conversions.ToString(this.comboBox_1.SelectedItem);
				}
				if (!string.IsNullOrEmpty(this.strUnitType))
				{
					this.method_1();
				}
			}
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00148820 File Offset: 0x00146A20
		private void method_5(object sender, EventArgs e)
		{
			this.strUnitType = Conversions.ToString(this.comboBox_1.SelectedItem);
			this.textBox_0.Clear();
			this.comboBox_0.Enabled = (Operators.CompareString(this.strUnitType, "武器", false) != 0);
			this.method_3();
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x000206B3 File Offset: 0x0001E8B3
		private void method_6(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x00148878 File Offset: 0x00146A78
		private void DBViewer_Shown(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.strUnitType))
			{
				this.strUnitType = "飞机";
			}
			if (this.DBID > 0)
			{
				this.method_1();
			}
			this.comboBox_0.Enabled = (Operators.CompareString(this.strUnitType, "武器", false) != 0);
			DataTable cache_OperatorCountries_DT = Client.GetClientScenario().Cache_OperatorCountries_DT;
			this.comboBox_0.DataSource = cache_OperatorCountries_DT;
			this.comboBox_0.DisplayMember = "Description";
			this.comboBox_0.ValueMember = "ID";
			this.comboBox_0.SelectedIndex = 0;
			this.comboBox_2.Items.Clear();
			this.comboBox_2.Items.Add("显示所有平台,包括列装与假想");
			this.comboBox_2.Items.Add("仅显示列装平台");
			this.comboBox_2.Items.Add("仅显示假想平台");
			this.comboBox_2.SelectedIndex = 0;
			this.webBrowser_0.Focus();
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x00148984 File Offset: 0x00146B84
		public string GetAircraftHTMLData(Aircraft aircraft_)
		{
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Platform.html");
			string text = "";
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (aircraft_.Hypothetical)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.DBID),
				" - ",
				aircraft_.UnitClass,
				text2
			}));
			text = text.Replace("<%Image%>", this.GetPlatformImageDirectory(aircraft_));
			text = text.Replace("<%Description%>", this.method_23(aircraft_));
			text = text.Replace("<%General%>", this.ShowGENERALDATA(aircraft_));
			text = text.Replace("<%Sensors%>", this.ShowSensorsAndEW(aircraft_));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.ShowMounts(aircraft_));
			text = text.Replace("<%Stores%>", this.method_27(aircraft_));
			text = text.Replace("<%Loadouts%>", this.method_28(aircraft_));
			text = text.Replace("<%Magazines%>", "");
			text = text.Replace("<%Comms%>", this.method_30(aircraft_));
			text = text.Replace("<%AirFacilities%>", "");
			text = text.Replace("<%DockingFacilities%>", "");
			text = text.Replace("<%Signatures%>", this.method_35(aircraft_));
			text = text.Replace("<%Flags%>", this.method_36(aircraft_));
			text = text.Replace("<%Propulsion%>", this.method_38(aircraft_));
			text = text.Replace("<%Fuel%>", this.method_39(aircraft_));
			return text;
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x00148B70 File Offset: 0x00146D70
		public string GetShipHTMLData(Ship ship_)
		{
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Platform.html");
			string text = "";
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (ship_.Hypothetical)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.DBID),
				" - ",
				ship_.UnitClass,
				text2
			}));
			text = text.Replace("<%Image%>", this.GetPlatformImageDirectory(ship_));
			text = text.Replace("<%Description%>", this.method_23(ship_));
			text = text.Replace("<%General%>", this.GetShipGeneralData(ship_));
			text = text.Replace("<%Sensors%>", this.ShowSensorsAndEW(ship_));
			text = text.Replace("<%MineCountermeasures%>", this.ShowMineCounterMeasuresGear(ship_));
			text = text.Replace("<%Mounts%>", this.ShowMounts(ship_));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", this.method_29(ship_));
			text = text.Replace("<%Comms%>", this.method_30(ship_));
			text = text.Replace("<%AirFacilities%>", this.method_31(ship_));
			text = text.Replace("<%DockingFacilities%>", this.method_32(ship_));
			text = text.Replace("<%Signatures%>", this.method_35(ship_));
			text = text.Replace("<%Flags%>", this.method_36(ship_));
			text = text.Replace("<%Propulsion%>", this.method_38(ship_));
			text = text.Replace("<%Fuel%>", this.method_39(ship_));
			return text;
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00148D60 File Offset: 0x00146F60
		public string GetSubmarineHTMLData(Submarine submarine_)
		{
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Platform.html");
			string text = "";
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (submarine_.Hypothetical)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.DBID),
				" - ",
				submarine_.UnitClass,
				text2
			}));
			text = text.Replace("<%Image%>", this.GetPlatformImageDirectory(submarine_));
			text = text.Replace("<%Description%>", this.method_23(submarine_));
			text = text.Replace("<%General%>", this.GetSubmarineGeneralData(submarine_));
			text = text.Replace("<%Sensors%>", this.ShowSensorsAndEW(submarine_));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.ShowMounts(submarine_));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", this.method_29(submarine_));
			text = text.Replace("<%Comms%>", this.method_30(submarine_));
			text = text.Replace("<%AirFacilities%>", "");
			text = text.Replace("<%DockingFacilities%>", this.method_32(submarine_));
			text = text.Replace("<%Signatures%>", this.method_35(submarine_));
			text = text.Replace("<%Flags%>", this.method_36(submarine_));
			text = text.Replace("<%Propulsion%>", this.method_38(submarine_));
			text = text.Replace("<%Fuel%>", this.method_39(submarine_));
			return text;
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x00148F4C File Offset: 0x0014714C
		public string GetFacilityHTMLData(Facility facility_0)
		{
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Platform.html");
			string text = "";
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (facility_0.Hypothetical)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.DBID),
				" - ",
				facility_0.UnitClass,
				text2
			}));
			text = text.Replace("<%Image%>", this.GetPlatformImageDirectory(facility_0));
			text = text.Replace("<%Description%>", this.method_23(facility_0));
			text = text.Replace("<%General%>", this.GetFacilityGeneralData(facility_0));
			text = text.Replace("<%Sensors%>", this.ShowSensorsAndEW(facility_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.ShowMounts(facility_0));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", this.method_29(facility_0));
			text = text.Replace("<%Comms%>", this.method_30(facility_0));
			text = text.Replace("<%AirFacilities%>", this.method_31(facility_0));
			text = text.Replace("<%DockingFacilities%>", this.method_32(facility_0));
			text = text.Replace("<%Signatures%>", this.method_35(facility_0));
			text = text.Replace("<%Flags%>", "");
			return text;
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00149110 File Offset: 0x00147310
		public string GetSatelliteHTMLData(Satellite satellite_0)
		{
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Platform.html");
			string text = "";
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (satellite_0.Hypothetical)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.DBID),
				" - ",
				satellite_0.UnitClass,
				text2
			}));
			text = text.Replace("<%Image%>", this.GetPlatformImageDirectory(satellite_0));
			text = text.Replace("<%Description%>", this.method_23(satellite_0));
			text = text.Replace("<%General%>", this.GetSatelliteGeneralData(satellite_0));
			text = text.Replace("<%Sensors%>", this.ShowSensorsAndEW(satellite_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.ShowMounts(satellite_0));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", "");
			text = text.Replace("<%AirFacilities%>", "");
			text = text.Replace("<%DockingFacilities%>", "");
			text = text.Replace("<%Signatures%>", this.method_35(satellite_0));
			text = text.Replace("<%Flags%>", this.method_36(satellite_0));
			return text;
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x001492BC File Offset: 0x001474BC
		public string ShowGENERALDATA(Aircraft aircraft_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体数据</strong></span></div>";
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Aircraft.html");
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.GetAircraftCategoryDescription(aircraft_0.Category, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Type%>", Misc.GetAircraftTypeDescription(aircraft_0.Type, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Length%>", Conversions.ToString(aircraft_0.Length));
			text = text.Replace("<%ClimbRate%>", Conversions.ToString(Math.Round((double)aircraft_0.GetAircraftKinematics().GetClimbRate())));
			text = text.Replace("<%InstantaneousClimbRate%>", Conversions.ToString(Math.Round((double)(aircraft_0.GetAircraftKinematics().GetClimbRate() * 3f))));
			text = text.Replace("<%ClimbRateFeetPrMin%>", Conversions.ToString(Math.Round((double)aircraft_0.GetAircraftKinematics().GetClimbRate() / 0.3048 * 60.0 / 10.0) * 10.0));
			text = text.Replace("<%InstantaneousClimbRateFeetPrMin%>", Conversions.ToString(Math.Round((double)(aircraft_0.GetAircraftKinematics().GetClimbRate() * 3f) / 0.3048 * 60.0 / 10.0) * 10.0));
			text = text.Replace("<%Span%>", Conversions.ToString(aircraft_0.Span));
			text = text.Replace("<%Height%>", Conversions.ToString(aircraft_0.Height));
			text = text.Replace("<%Agility%>", Conversions.ToString(aircraft_0.Agility));
			text = text.Replace("<%EmptyWeight%>", Conversions.ToString(aircraft_0.WeightEmpty));
			text = text.Replace("<%MaxWeight%>", Conversions.ToString(aircraft_0.WeightMax));
			text = text.Replace("<%DamagePoints%>", Conversions.ToString(aircraft_0.GetDamagePts(false)));
			text = text.Replace("<%MaxPayloadWeight%>", Conversions.ToString(aircraft_0.WeightPayload));
			text = text.Replace("<%Crew%>", Conversions.ToString(aircraft_0.Crew));
			text = text.Replace("<%Visibility%>", this.method_13(aircraft_0));
			text = text.Replace("<%Armor%>", this.GetAircraftFuselageArmorString(aircraft_0));
			text = text.Replace("<%RunwayLengthNeeded%>", Misc.GetAircraftRunwayLengthDescription(aircraft_0.RunwayLengthCode, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%PhysicalSize%>", Misc.GetAircraftSizeClassString(aircraft_0.aircraftSizeClass, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%OODA%>", this.GetOODAString(aircraft_0.GetUnitType(), aircraft_0.DBID));
			return text;
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x001495A8 File Offset: 0x001477A8
		private string method_13(Aircraft aircraft_0)
		{
			string result;
			if (Client.GetClientScenario().FeatureCompatibility.CockpitVisibility)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("前面: ").Append(Misc.GetCockpitVisibilityLevelString(aircraft_0.ForwardCockpitVisibilityLevel)).Append("<br>");
				stringBuilder.Append("侧面: ").Append(Misc.GetCockpitVisibilityLevelString(aircraft_0.SidewaysCockpitVisibilityLevel)).Append("<br>");
				stringBuilder.Append("后面: ").Append(Misc.GetCockpitVisibilityLevelString(aircraft_0.AftCockpitVisibilityLevel));
				result = stringBuilder.ToString();
			}
			else
			{
				result = "Not supported by this database.";
			}
			return result;
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x00149650 File Offset: 0x00147850
		private string GetAircraftFuselageArmorString(Aircraft aircraft_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("机身: ").Append(Misc.GetArmorTypeDescription(aircraft_0.AircraftFuselageArmor, Client.GetClientScenario().GetSQLiteConnection())).Append("<br>");
			stringBuilder.Append("座舱: ").Append(Misc.GetArmorTypeDescription(aircraft_0.AircraftCockpitArmor, Client.GetClientScenario().GetSQLiteConnection())).Append("<br>");
			stringBuilder.Append("发动机: ").Append(Misc.GetArmorTypeDescription(aircraft_0.AircraftEngineArmor, Client.GetClientScenario().GetSQLiteConnection()));
			return stringBuilder.ToString();
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x001496F4 File Offset: 0x001478F4
		public string GetOODAString(GlobalVariables.ActiveUnitType activeUnitType_, int DBID_)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int value = 0;
			int num = 0;
			int value2 = 0;
			DBFunctions.smethod_15(activeUnitType_, DBID_, Client.GetClientScenario().GetSQLiteConnection(), ref value, ref num, ref value2);
			stringBuilder.Append("<table style='font-family:Verdana;font-size:8pt'>");
			stringBuilder.Append("<tr>");
			stringBuilder.Append("<td>探测:</td><td>" + Conversions.ToString(value) + "秒 OODA (反应时间)<td>");
			stringBuilder.Append("</tr>");
			stringBuilder.Append("<tr>");
			stringBuilder.Append(string.Concat(new string[]
			{
				"<td valign=top>瞄准:</td><td>",
				Conversions.ToString(num * 2),
				"秒 (新手)<br>",
				Conversions.ToString((double)num * 1.5),
				"秒 (实习)<br>",
				Conversions.ToString((double)num * 1.2),
				"秒 (普通)<br>",
				Conversions.ToString(num),
				"秒 (老手)<br>",
				Conversions.ToString((double)num * 0.8),
				"秒 (顶级)</td>"
			}));
			stringBuilder.Append("</tr>");
			stringBuilder.Append("<tr>");
			stringBuilder.Append("<td>规避:</td><td>" + Conversions.ToString(value2) + "秒</td>");
			stringBuilder.Append("</tr>");
			stringBuilder.Append("</table>");
			return stringBuilder.ToString();
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x0014986C File Offset: 0x00147A6C
		public string GetWeaponGeneralData(Weapon weapon_)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体数据</strong></span></div>";
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Weapon.html");
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			string text2 = text;
			string oldValue = "<%Type%>";
			Scenario clientScenario = Client.GetClientScenario();
			text = text2.Replace(oldValue, DBFunctions.GetWeaponTypeDescription(ref clientScenario, weapon_.DBID));
			if (weapon_.Span > 0f)
			{
				text = text.Replace("<%Span%>", Conversions.ToString(weapon_.Span) + "米");
			}
			else
			{
				text = text.Replace("<%Span%>", "-");
			}
			if (weapon_.Length > 0f)
			{
				text = text.Replace("<%Length%>", Conversions.ToString(weapon_.Length) + "米");
			}
			else
			{
				text = text.Replace("<%Length%>", "-");
			}
			if (weapon_.Diameter > 0f)
			{
				text = text.Replace("<%Diameter%>", Conversions.ToString(weapon_.Diameter) + "米");
			}
			else
			{
				text = text.Replace("<%Diameter%>", "-");
			}
			if (weapon_.WeightEmpty > 0)
			{
				text = text.Replace("<%Weight%>", Conversions.ToString(weapon_.WeightEmpty) + "公斤");
			}
			else
			{
				text = text.Replace("<%Weight%>", "-");
			}
			if (weapon_.BurnoutWeight > 0)
			{
				text = text.Replace("<%BurnoutWeight%>", Conversions.ToString(weapon_.BurnoutWeight) + "公斤");
			}
			else
			{
				text = text.Replace("<%BurnoutWeight%>", "-");
			}
			if (weapon_.CruiseAltitude > 0f)
			{
				text = text.Replace("<%CruiseAlt%>", Conversions.ToString(Math.Round((double)weapon_.CruiseAltitude, 0)) + "米(真高)");
				text = text.Replace("<%CruiseAltFeet%>", Conversions.ToString(Math.Round((double)weapon_.CruiseAltitude / 0.3048 / 10.0) * 10.0) + "英尺(真高), ");
			}
			else if (weapon_.GetCruiseAltitude_ASL() > 0f)
			{
				text = text.Replace("<%CruiseAlt%>", Conversions.ToString(Math.Round((double)weapon_.GetCruiseAltitude_ASL(), 0)) + "米(海高)");
				text = text.Replace("<%CruiseAltFeet%>", Conversions.ToString(Math.Round((double)weapon_.GetCruiseAltitude_ASL() / 0.3048 / 10.0) * 10.0) + "英尺(海高), ");
			}
			else
			{
				text = text.Replace("<%CruiseAlt%>", "");
				text = text.Replace("<%CruiseAltFeet%>", "-");
			}
			if (weapon_.RangeAAWMax > 0f)
			{
				if (weapon_.RangeAAWMin > 0f)
				{
					text = text.Replace("<%RangeAAW%>", Conversions.ToString(weapon_.RangeAAWMin) + " - " + Conversions.ToString(weapon_.RangeAAWMax) + "海里");
				}
				else
				{
					text = text.Replace("<%RangeAAW%>", Conversions.ToString(weapon_.RangeAAWMax) + "海里");
				}
				text = text.Replace("<%AirPOK%>", Conversions.ToString(weapon_.AirPOK) + " %");
			}
			else
			{
				text = text.Replace("<%RangeAAW%>", "-");
				text = text.Replace("<%AirPOK%>", "-");
			}
			if (weapon_.RangeASUWMax > 0f)
			{
				if (weapon_.RangeASUWMin > 0f)
				{
					text = text.Replace("<%RangeASUW%>", Conversions.ToString(weapon_.RangeASUWMin) + " - " + Conversions.ToString(weapon_.RangeASUWMax) + "海里");
				}
				else
				{
					text = text.Replace("<%RangeASUW%>", Conversions.ToString(weapon_.RangeASUWMax) + "海里");
				}
				text = text.Replace("<%SurfPOK%>", Conversions.ToString(weapon_.SurfacePOK) + " %");
			}
			else
			{
				text = text.Replace("<%RangeASUW%>", "-");
				text = text.Replace("<%SurfPOK%>", "-");
			}
			if (weapon_.RangeLandMax > 0f)
			{
				if (weapon_.RangeLandMin > 0f)
				{
					text = text.Replace("<%RangeLand%>", Conversions.ToString(weapon_.RangeLandMin) + " - " + Conversions.ToString(weapon_.RangeLandMax) + "海里");
				}
				else
				{
					text = text.Replace("<%RangeLand%>", Conversions.ToString(weapon_.RangeLandMax) + "海里");
				}
				text = text.Replace("<%LandPOK%>", Conversions.ToString(weapon_.LandPOK) + " %");
			}
			else
			{
				text = text.Replace("<%RangeLand%>", "-");
				text = text.Replace("<%LandPOK%>", "-");
			}
			if (weapon_.RangeASWMax > 0f)
			{
				if (weapon_.RangeASWMin > 0f)
				{
					text = text.Replace("<%RangeASW%>", Conversions.ToString(weapon_.RangeASWMin) + " - " + Conversions.ToString(weapon_.RangeASWMax) + "海里");
				}
				else
				{
					text = text.Replace("<%RangeASW%>", Conversions.ToString(weapon_.RangeASWMax) + "海里");
				}
				text = text.Replace("<%SubPOK%>", Conversions.ToString(weapon_.SubsurfacePOK) + " %");
			}
			else
			{
				text = text.Replace("<%RangeASW%>", "-");
				text = text.Replace("<%SubPOK%>", "-");
			}
			if (weapon_.RangeASUWMax > 0f && weapon_.GetCEP_Surface() > 0)
			{
				text = text.Replace("<%CEP_Surface%>", Conversions.ToString(weapon_.GetCEP_Surface()) + "米");
			}
			else
			{
				text = text.Replace("<%CEP_Surface%>", "-");
			}
			if (weapon_.RangeLandMax > 0f && weapon_.GetCEP_Land() > 0)
			{
				text = text.Replace("<%CEP_Land%>", Conversions.ToString(weapon_.GetCEP_Land()) + "米");
			}
			else
			{
				text = text.Replace("<%CEP_Land%>", "-");
			}
			if (weapon_.LaunchAltitudeMin >= 0f && (weapon_.LaunchAltitudeMax > 0f || weapon_.LaunchAltitudeMax_ASL > 0f) && ((weapon_.GetWeaponType() != Weapon._WeaponType.Torpedo && !weapon_.IsMine()) || !weapon_.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(weapon_.m_Scenario.GetSQLiteConnection())))
			{
				text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin, 0)) + "米(真高) - ");
				text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin / 0.3048 / 10.0) * 10.0) + "英尺(真高) - ");
			}
			else if (weapon_.LaunchAltitudeMin_ASL >= 0f && (weapon_.LaunchAltitudeMax > 0f || weapon_.LaunchAltitudeMax_ASL > 0f))
			{
				text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL, 0)) + "米(海高)- ");
				text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高) - ");
			}
			else if (weapon_.LaunchAltitudeMin > 0f && (weapon_.LaunchAltitudeMax <= 0f || weapon_.LaunchAltitudeMax_ASL <= 0f))
			{
				text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin, 0)) + "米(真高)");
				text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin / 0.3048 / 10.0) * 10.0) + "英尺(真高), ");
			}
			else if (weapon_.LaunchAltitudeMin_ASL > 0f && (weapon_.LaunchAltitudeMax <= 0f || weapon_.LaunchAltitudeMax_ASL <= 0f))
			{
				text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL, 0)) + "米(海高)");
				text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高), ");
			}
			else if (weapon_.GetWeaponType() != Weapon._WeaponType.Torpedo && !weapon_.IsMine())
			{
				if (weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && weapon_.LaunchAltitudeMin < 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL, 0)) + "米 - ");
					text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + "英尺 - ");
				}
				else if (weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && weapon_.LaunchAltitudeMin_ASL < 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL, 0)) + "米 - ");
					text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + "英尺 - ");
				}
				else if (weapon_.LaunchAltitudeMax == 0f && weapon_.LaunchAltitudeMax_ASL == 0f && weapon_.LaunchAltitudeMin == 0f && weapon_.LaunchAltitudeMin_ASL == 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", "-");
					text = text.Replace("<%LaunchAltFeetMin%>", "");
				}
				else if (weapon_.GetWeaponType() == Weapon._WeaponType.RV | weapon_.GetWeaponType() == Weapon._WeaponType.HGV)
				{
					text = text.Replace("<%LaunchAltMin%>", "-");
					text = text.Replace("<%LaunchAltFeetMin%>", "");
				}
				else
				{
					text = text.Replace("<%LaunchAltMin%>", "");
					text = text.Replace("<%LaunchAltFeetMin%>", "");
				}
			}
			else if (weapon_.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(weapon_.m_Scenario.GetSQLiteConnection()))
			{
				text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL, 0)) + "米 - ");
				text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + " ft - ");
			}
			else
			{
				text = text.Replace("<%LaunchAltMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin, 0)) + "米 - ");
				text = text.Replace("<%LaunchAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMin / 0.3048 / 10.0) * 10.0) + " ft - ");
			}
			if (weapon_.LaunchAltitudeMax > 0f)
			{
				text = text.Replace("<%LaunchAltMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax, 0)) + "米(真高)");
				text = text.Replace("<%LaunchAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax / 0.3048 / 10.0) * 10.0) + "英尺(真高), ");
			}
			else if (weapon_.LaunchAltitudeMax_ASL > 0f)
			{
				text = text.Replace("<%LaunchAltMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax_ASL, 0)) + "米(海高)");
				text = text.Replace("<%LaunchAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高), ");
			}
			else if (weapon_.GetWeaponType() != Weapon._WeaponType.Torpedo && !weapon_.IsMine())
			{
				if (weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && weapon_.LaunchAltitudeMin < 0f)
				{
					text = text.Replace("<%LaunchAltMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax, 0)) + "米(真高)");
					text = text.Replace("<%LaunchAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax / 0.3048 / 10.0) * 10.0) + "英尺(真高), ");
				}
				else if (weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && weapon_.LaunchAltitudeMin_ASL < 0f)
				{
					text = text.Replace("<%LaunchAltMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax_ASL, 0)) + "米(海高)");
					text = text.Replace("<%LaunchAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高), ");
				}
				else
				{
					text = text.Replace("<%LaunchAltMax%>", "");
					text = text.Replace("<%LaunchAltFeetMax%>", "");
				}
			}
			else if (weapon_.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(weapon_.m_Scenario.GetSQLiteConnection()))
			{
				text = text.Replace("<%LaunchAltMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax_ASL, 0)) + "米");
				text = text.Replace("<%LaunchAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax_ASL / 0.3048 / 10.0) * 10.0) + "英尺, ");
			}
			else
			{
				text = text.Replace("<%LaunchAltMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax, 0)) + "米");
				text = text.Replace("<%LaunchAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.LaunchAltitudeMax / 0.3048 / 10.0) * 10.0) + "英尺, ");
			}
			if (weapon_.LaunchSpeedMin >= 0 && weapon_.LaunchSpeedMax > 0)
			{
				text = text.Replace("<%LaunchSpdMin%>", Conversions.ToString(weapon_.LaunchSpeedMin) + " - ");
			}
			else if (weapon_.LaunchSpeedMin > 0 && weapon_.LaunchSpeedMax <= 0)
			{
				text = text.Replace("<%LaunchSpdMin%>", Conversions.ToString(weapon_.LaunchSpeedMin) + "节");
			}
			else
			{
				text = text.Replace("<%LaunchSpdMin%>", "-");
			}
			if (weapon_.LaunchSpeedMax > 0)
			{
				text = text.Replace("<%LaunchSpdMax%>", Conversions.ToString(weapon_.LaunchSpeedMax) + "节");
			}
			else
			{
				text = text.Replace("<%LaunchSpdMax%>", "");
			}
			if (weapon_.TargetSpeedMin >= 0 && weapon_.TargetSpeedMax > 0)
			{
				text = text.Replace("<%TargetSpdMin%>", Conversions.ToString(weapon_.TargetSpeedMin) + " - ");
			}
			else if (weapon_.TargetSpeedMin > 0 && weapon_.TargetSpeedMax <= 0)
			{
				text = text.Replace("<%TargetSpdMin%>", Conversions.ToString(weapon_.TargetSpeedMin) + "节");
			}
			else if (weapon_.TargetSpeedMin <= 0 && weapon_.TargetSpeedMax > 0)
			{
				text = text.Replace("<%TargetSpdMin%>", "n/a");
			}
			else
			{
				text = text.Replace("<%TargetSpdMin%>", "-");
			}
			if (weapon_.TargetSpeedMax > 0)
			{
				text = text.Replace("<%TargetSpdMax%>", Conversions.ToString(weapon_.TargetSpeedMax) + "节");
			}
			else
			{
				text = text.Replace("<%TargetSpdMax%>", "");
			}
			if (weapon_.TargetAltitudeMin > 0f && (weapon_.TargetAltitudeMax != 0f || weapon_.TargetAltitudeMax_ASL > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin, 0)) + "米(真高) - ");
				text = text.Replace("<%TargetAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin / 0.3048 / 10.0) * 10.0) + "英尺(真高) - ");
			}
			else if (weapon_.TargetAltitudeMin_ASL > 0f && (weapon_.TargetAltitudeMax != 0f || weapon_.TargetAltitudeMax_ASL > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin_ASL, 0)) + "米(海高)- ");
				text = text.Replace("<%TargetAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高) - ");
			}
			else if (weapon_.TargetAltitudeMin > 0f && (weapon_.TargetAltitudeMax <= 0f || weapon_.TargetAltitudeMax_ASL <= 0f))
			{
				text = text.Replace("<%TargetAltMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin, 0)) + "米(真高) - ");
				text = text.Replace("<%TargetAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin / 0.3048 / 10.0) * 10.0) + "英尺(真高) - ");
			}
			else if (weapon_.TargetAltitudeMin_ASL > 0f && (weapon_.TargetAltitudeMax <= 0f || weapon_.TargetAltitudeMax_ASL <= 0f))
			{
				text = text.Replace("<%TargetAltMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin_ASL, 0)) + "米(海高)- ");
				text = text.Replace("<%TargetAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高) - ");
			}
			else if (weapon_.TargetAltitudeMin <= 0f && (weapon_.TargetAltitudeMax > 0f || weapon_.TargetAltitudeMax_ASL > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", "n/a");
				text = text.Replace("<%TargetAltFeetMin%>", "n/a");
			}
			else if (weapon_.TargetAltitudeMin_ASL <= 0f && (weapon_.TargetAltitudeMax > 0f || weapon_.TargetAltitudeMax_ASL > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", "n/a");
				text = text.Replace("<%TargetAltFeetMin%>", "n/a");
			}
			else if (weapon_.GetWeaponType() != Weapon._WeaponType.Torpedo && !weapon_.IsMine())
			{
				text = text.Replace("<%TargetAltMin%>", "-");
				text = text.Replace("<%TargetAltFeetMin%>", "");
			}
			else if (weapon_.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(weapon_.m_Scenario.GetSQLiteConnection()))
			{
				text = text.Replace("<%TargetAltMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin_ASL, 0)) + "米 - ");
				text = text.Replace("<%TargetAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin_ASL / 0.3048 / 10.0) * 10.0) + " ft - ");
			}
			else
			{
				text = text.Replace("<%TargetAltMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin, 0)) + "米 - ");
				text = text.Replace("<%TargetAltFeetMin%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMin / 0.3048 / 10.0) * 10.0) + " ft - ");
			}
			if (weapon_.TargetAltitudeMax > 0f)
			{
				text = text.Replace("<%TargetAltMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax, 0)) + "米(真高)");
				text = text.Replace("<%TargetAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax / 0.3048 / 10.0) * 10.0) + "英尺(真高), ");
			}
			else if (weapon_.TargetAltitudeMax_ASL > 0f)
			{
				text = text.Replace("<%TargetAltMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax_ASL, 0)) + "米(海高)");
				text = text.Replace("<%TargetAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax_ASL / 0.3048 / 10.0) * 10.0) + "英尺(海高), ");
			}
			else if (weapon_.GetWeaponType() != Weapon._WeaponType.Torpedo && !weapon_.IsMine())
			{
				text = text.Replace("<%TargetAltMax%>", "");
				text = text.Replace("<%TargetAltFeetMax%>", "");
			}
			else if (weapon_.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(weapon_.m_Scenario.GetSQLiteConnection()))
			{
				text = text.Replace("<%TargetAltMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax_ASL, 0)) + "米");
				text = text.Replace("<%TargetAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax_ASL / 0.3048 / 10.0) * 10.0) + "英尺, ");
			}
			else
			{
				text = text.Replace("<%TargetAltMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax, 0)) + "米");
				text = text.Replace("<%TargetAltFeetMax%>", Conversions.ToString(Math.Round((double)weapon_.TargetAltitudeMax / 0.3048 / 10.0) * 10.0) + "英尺, ");
			}
			if (weapon_.GetWeaponKinematics().GetClimbRate() > 0f)
			{
				text = text.Replace("<%ClimbRate%>", Conversions.ToString(Math.Round((double)weapon_.GetWeaponKinematics().GetClimbRate())) + "米/秒");
				text = text.Replace("<%ClimbRateFeetPrMin%>", Conversions.ToString(Math.Round((double)weapon_.GetWeaponKinematics().GetClimbRate() / 0.3048 * 60.0 / 10.0) * 10.0) + " 英尺/分, ");
			}
			else
			{
				text = text.Replace("<%ClimbRate%>", "");
				text = text.Replace("<%ClimbRateFeetPrMin%>", "-");
			}
			if (weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && weapon_.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && weapon_.SnapUpDownAltitude_m > 0f)
			{
				text = text.Replace("<%SnapUpDownAltitude%>", string.Concat(new string[]
				{
					"<td>急跃升/下降高度:</td><td colspan = 9>",
					Conversions.ToString(Math.Round((double)weapon_.SnapUpDownAltitude_m / 0.3048)),
					"英尺, ",
					Conversions.ToString(Math.Round((double)weapon_.SnapUpDownAltitude_m)),
					"米</td>"
				}));
			}
			if (weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || weapon_.GetWeaponType() == Weapon._WeaponType.Torpedo)
			{
				text = text.Replace("<%GuidanceType%>", "<td>制导方式:</td><td colspan = 9>" + weapon_.GetWeaponCodeString() + "</td>");
			}
			List<float> list = new List<float>();
			try
			{
				list = DBFunctions.GetTorpedoData(weapon_.DBID, Client.GetClientScenario().GetSQLiteConnection());
				if (list.Count > 0)
				{
					if (list[0] > 0f)
					{
						text = text.Replace("<%TorpedoKinematicRangeCruise%>", string.Concat(new string[]
						{
							"<td>动力航程:</td><td>",
							Conversions.ToString(list[1]),
							"海里 速度：",
							Conversions.ToString(list[0]),
							"节</td>"
						}));
					}
					else
					{
						text = text.Replace("<%TorpedoKinematicRangeCruise%>", "<td></td><td></td>");
					}
					if (list[3] > 0f)
					{
						text = text.Replace("<%TorpedoKinematicRangeFull%>", string.Concat(new string[]
						{
							"<td></td><td>",
							Conversions.ToString(list[3]),
							"海里 速度：",
							Conversions.ToString(list[2]),
							"节</td>"
						}));
					}
					else
					{
						text = text.Replace("<%TorpedoKinematicRangeFull%>", "<td></td><td></td>");
					}
				}
				else
				{
					text = text.Replace("<%TorpedoKinematicRangeCruise%>", "<td></td><td></td>");
					text = text.Replace("<%TorpedoKinematicRangeFull%>", "<td></td><td></td>");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				text = text.Replace("<%TorpedoKinematicRangeCruise%>", "<td></td><td></td>");
				text = text.Replace("<%TorpedoKinematicRangeFull%>", "<td></td><td></td>");
				ex2.Data.Add("Error at 200375", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return text;
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x0014B448 File Offset: 0x00149648
		public string GetShipGeneralData(Ship ship_)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体数据</strong></span></div>";
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Ship.html");
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.GetShipCategoryDescription(ship_.Category, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Type%>", Misc.GetShipTypeDescription(ship_.Type, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(ship_.GetInitialDP()));
			text = text.Replace("<%Length%>", Conversions.ToString(ship_.Length));
			text = text.Replace("<%Beam%>", Conversions.ToString(ship_.Beam));
			text = text.Replace("<%Draft%>", Conversions.ToString(ship_.Draft));
			text = text.Replace("<%Height%>", Conversions.ToString(ship_.Height));
			text = text.Replace("<%Crew%>", Conversions.ToString(ship_.Crew));
			if (ship_.DisplacementEmpty > 0.0)
			{
				text = text.Replace("<%Displacement_Empty%>", Conversions.ToString(ship_.DisplacementEmpty) + "吨");
			}
			else
			{
				text = text.Replace("<%Displacement_Empty%>", "-");
			}
			text = text.Replace("<%Displacement_Standard%>", Conversions.ToString(ship_.DisplacementStandard) + "吨");
			if (ship_.DisplacementFull > 0.0)
			{
				text = text.Replace("<%Displacement_Full%>", Conversions.ToString(ship_.DisplacementFull) + "吨");
			}
			else
			{
				text = text.Replace("<%Displacement_Full%>", "-");
			}
			text = text.Replace("<%DockingPhysicalSize%>", Misc.GetDockingFacilityPhysicalSizeDescription(ship_.physicalSizeCode, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%MaxSeaState%>", Conversions.ToString(ship_.MaxSeaState));
			if (ship_.TroopCapacity > 0)
			{
				text = text.Replace("<%TroopCapacity%>", Conversions.ToString((int)ship_.TroopCapacity) + "人");
			}
			else
			{
				text = text.Replace("<%TroopCapacity%>", "-");
			}
			if (ship_.CargoCapacity > 0)
			{
				text = text.Replace("<%CargoCapacity%>", Conversions.ToString((int)ship_.CargoCapacity) + "吨");
			}
			else
			{
				text = text.Replace("<%CargoCapacity%>", "-");
			}
			text = text.Replace("<%Armor_Belt%>", Misc.GetArmorTypeDescription(ship_.ArmorBelt, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Armor_Bulkhead%>", Misc.GetArmorTypeDescription(ship_.ArmorBulkheads, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Armor_Deck%>", Misc.GetArmorTypeDescription(ship_.ArmorDeck, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Armor_Engineering%>", Misc.GetArmorTypeDescription(ship_.ArmorEngineering, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Armor_Bridge%>", Misc.GetArmorTypeDescription(ship_.ArmorBridge, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Armor_CIC%>", Misc.GetArmorTypeDescription(ship_.ArmorCIC, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Armor_Rudder%>", Misc.GetArmorTypeDescription(ship_.ArmorRudder, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%OODA%>", this.GetOODAString(ship_.GetUnitType(), ship_.DBID));
			text = text.Replace("<%MissileDefence%>", Conversions.ToString((int)ship_.MissileDefense) + "个捕鲸叉/SLAM/Maverick导弹等效数");
			return text;
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0014B81C File Offset: 0x00149A1C
		public string GetSubmarineGeneralData(Submarine submarine_)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体数据</strong></span></div>";
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Submarine.html");
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.GetSubmarineCategoryDescription(submarine_.Category, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Type%>", Misc.GetSubmarineTypeDescription(submarine_.Type, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(submarine_.GetInitialDP()));
			text = text.Replace("<%Length%>", Conversions.ToString(submarine_.Length));
			text = text.Replace("<%Beam%>", Conversions.ToString(submarine_.Beam));
			text = text.Replace("<%Draft%>", Conversions.ToString(submarine_.Draft));
			text = text.Replace("<%Height%>", Conversions.ToString(submarine_.Height));
			text = text.Replace("<%Crew%>", Conversions.ToString(submarine_.Crew));
			if (submarine_.DisplacementEmpty > 0.0)
			{
				text = text.Replace("<%Displacement_Empty%>", Conversions.ToString(submarine_.DisplacementEmpty) + "吨");
			}
			else
			{
				text = text.Replace("<%Displacement_Empty%>", "-");
			}
			text = text.Replace("<%Displacement_Standard%>", Conversions.ToString(submarine_.DisplacementStandard) + "吨");
			if (submarine_.DisplacementFull > 0.0)
			{
				text = text.Replace("<%Displacement_Full%>", Conversions.ToString(submarine_.DisplacementFull) + "吨");
			}
			else
			{
				text = text.Replace("<%Displacement_Full%>", "-");
			}
			text = text.Replace("<%DockingPhysicalSize%>", Misc.GetDockingFacilityPhysicalSizeDescription(submarine_.PhysicalSizeCode, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%ROVRadius%>", Conversions.ToString((int)submarine_.ROVRadius));
			text = text.Replace("<%MaxDepth%>", Conversions.ToString(submarine_.MaxDepth));
			text = text.Replace("<%OODA%>", this.GetOODAString(submarine_.GetUnitType(), submarine_.DBID));
			return text;
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x0014BA7C File Offset: 0x00149C7C
		public string GetFacilityGeneralData(Facility facility_)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体数据</strong></span></div>";
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Facility.html");
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.GetFacilityCategoryDesciption(facility_.Category, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(facility_.GetDamagePts(false)));
			text = text.Replace("<%Length%>", Conversions.ToString(facility_.Length));
			text = text.Replace("<%Width%>", Conversions.ToString(facility_.Width));
			text = text.Replace("<%Area%>", Conversions.ToString(facility_.Area));
			text = text.Replace("<%Crew%>", Conversions.ToString(facility_.Crew));
			text = text.Replace("<%Armor_General%>", Misc.GetArmorTypeDescription(facility_.ArmorGeneral, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%MastHeight%>", Conversions.ToString(facility_.MastHeight));
			text = text.Replace("<%AimpointDispersalRadius%>", Conversions.ToString(facility_.Radius));
			text = text.Replace("<%OODA%>", this.GetOODAString(facility_.GetUnitType(), facility_.DBID));
			text = text.Replace("<%MissileDefence%>", Conversions.ToString(facility_.MissileDefense) + "个捕鲸叉/SLAM/Maverick导弹等效数");
			return text;
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x0014BC10 File Offset: 0x00149E10
		public string GetSatelliteGeneralData(Satellite satellite_)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体数据</strong></span></div>";
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Satellite.html");
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.GetSatelliteCategoryDescription(satellite_.SatelliteCategory, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%Type%>", Misc.GetSatelliteTypeDescription(satellite_.SatelliteType, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(satellite_.GetInitialDP()));
			text = text.Replace("<%Length%>", Conversions.ToString(satellite_.Length));
			text = text.Replace("<%Span%>", Conversions.ToString(satellite_.Span));
			text = text.Replace("<%Height%>", Conversions.ToString(satellite_.Height));
			text = text.Replace("<%WeightEmpty%>", Conversions.ToString(satellite_.WeightEmpty));
			text = text.Replace("<%WeightMax%>", Conversions.ToString(satellite_.WeightMax));
			text = text.Replace("<%WeightPayload%>", Conversions.ToString(satellite_.WeightPayload));
			text = text.Replace("<%Armor%>", Misc.GetArmorTypeDescription(satellite_.armorRating, Client.GetClientScenario().GetSQLiteConnection()));
			text = text.Replace("<%OODA%>", "-");
			return text;
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0014BD94 File Offset: 0x00149F94
		public string GetPlatformImageDirectory(ActiveUnit activeUnit_)
		{
			string str;
			if (activeUnit_.IsAircraft)
			{
				str = "Aircraft";
			}
			else if (activeUnit_.IsShip)
			{
				str = "Ship";
			}
			else if (activeUnit_.IsSubmarine)
			{
				str = "Submarine";
			}
			else if (activeUnit_.IsFacility)
			{
				str = "Facility";
			}
			else if (activeUnit_.IsSatellite())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_.IsWeapon)
				{
					throw new NotImplementedException();
				}
				str = "Weapon";
			}
			DBOps.DBFileCheckResult dBFileCheckResult = DBOps.DBFileCheckResult.Undefined;
			DBRecord dBRecord = DBOps.GetDBRecord(Client.GetClientScenario().GetDBUsed(), ref dBFileCheckResult, true, true);
			string str2;
			switch (dBRecord.DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			default:
				str2 = "DB3000";
				break;
			}
			this.Text = "数据库浏览器: " + dBRecord.DBName;
			string text = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Images\\" + str2;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + ".jpg");
			string text3 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + "_t1.jpg");
			string text4 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + "_t2.jpg");
			string text5 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + "_t3.jpg");
			string text6 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + "_t4.jpg");
			string text7 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + "_t5.jpg");
			string text8 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_.DBID) + "_t6.jpg");
			string text9;
			if (File.Exists(text2))
			{
				text9 = "<div><table width='100%'><tr><td width='10%'><td><td width='80%' align='center'><img src='" + text2 + "' width='900px'  style='float:middle;margin:0 5px 5px 0;' /></td><td width='10%'></td></tr></table></div><br/>";
				if (File.Exists(text3) || File.Exists(text4) || File.Exists(text5))
				{
					text9 += "<div align = 'center'>";
					if (File.Exists(text3))
					{
						text9 = text9 + "<img src='" + text3 + "' width='250px' style='float:middle;margin:0 5px 5px 0;'/>";
					}
					if (File.Exists(text4))
					{
						text9 = text9 + "<img src='" + text4 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
					}
					if (File.Exists(text5))
					{
						text9 = text9 + "<img src='" + text5 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
					}
					text9 += "</div><br/>";
				}
				if (File.Exists(text6) || File.Exists(text7) || File.Exists(text8))
				{
					text9 += "<div align = 'center'>";
					if (File.Exists(text6))
					{
						text9 = text9 + "<img src='" + text6 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
					}
					if (File.Exists(text7))
					{
						text9 = text9 + "<img src='" + text7 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
					}
					if (File.Exists(text8))
					{
						text9 = text9 + "<img src='" + text8 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
					}
					text9 += "</div><br/>";
				}
			}
			else
			{
				text9 = "";
			}
			return text9;
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x0014C120 File Offset: 0x0014A320
		public string method_22(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.IsAircraft)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.IsShip)
			{
				str = "Ship";
			}
			else if (activeUnit_0.IsSubmarine)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.IsFacility)
			{
				str = "Facility";
			}
			else if (activeUnit_0.IsSatellite())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.IsWeapon)
				{
					throw new NotImplementedException();
				}
				str = "Weapon";
			}
			DBOps.DBFileCheckResult dBFileCheckResult = DBOps.DBFileCheckResult.Undefined;
			DBRecord dBRecord = DBOps.GetDBRecord(Client.GetClientScenario().GetDBUsed(), ref dBFileCheckResult, true, true);
			string str2;
			switch (dBRecord.DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			default:
				str2 = "DB3000";
				break;
			}
			string text = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Images\\" + str2;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i1.jpg");
			string text3 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i2.jpg");
			string text4 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i3.jpg");
			string text5 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i4.jpg");
			string text6;
			if (File.Exists(text2))
			{
				text6 = "<img src='" + text2 + "' width='200'/>";
				if (File.Exists(text3))
				{
					text6 = text6 + "<br><br><img src='" + text3 + "' width='200'/>";
				}
				if (File.Exists(text4))
				{
					text6 = text6 + "<br><br><img src='" + text4 + "' width='200'/>";
				}
				if (File.Exists(text5))
				{
					text6 = text6 + "<br><br><img src='" + text5 + "' width='200'/>";
				}
			}
			else
			{
				text6 = "";
			}
			return text6;
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x0014C348 File Offset: 0x0014A548
		public string method_23(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.IsAircraft)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.IsShip)
			{
				str = "Ship";
			}
			else if (activeUnit_0.IsSubmarine)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.IsFacility)
			{
				str = "Facility";
			}
			else if (activeUnit_0.IsSatellite())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.IsWeapon)
				{
					throw new NotImplementedException();
				}
				str = "Weapon";
			}
			string str2 = "";
			DBOps.DBFileCheckResult dBFileCheckResult = DBOps.DBFileCheckResult.Undefined;
			DBRecord dBRecord = DBOps.GetDBRecord(Client.GetClientScenario().GetDBUsed(), ref dBFileCheckResult, true, true);
			switch (dBRecord.DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			}
			string text = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Descriptions\\" + str2;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string path = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + ".txt");
			string text3;
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				string text2 = "";
				using (streamReader)
				{
					text2 += streamReader.ReadToEnd();
				}
				text2 = HttpUtility.HtmlEncode(text2);
				text3 = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>总体描述</strong></span></div>";
				text3 = string.Concat(new string[]
				{
					text3,
					"<div><span><table><tr><td valign='top'>",
					this.method_22(activeUnit_0),
					"</td><td valign='top' style='font-family:Verdana;font-size:8pt;'>",
					text2.Replace(Environment.NewLine, "<br/>"),
					"</td><tr></table></span></div> <br/>"
				});
			}
			else
			{
				text3 = "";
			}
			return text3;
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x0014C530 File Offset: 0x0014A730
		public string ShowSensorsAndEW(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetAllNoneMCMSensors().Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>传感器/电子战</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>型号</td><td align='center'>最大距离</td><td>说明</td><td>能力</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Sensor>> enumerable = activeUnit_0.GetAllNoneMCMSensors().GroupBy(DBViewer.SensorFunc0);
				foreach (IGrouping<int, Sensor> current in enumerable)
				{
					Sensor sensor = current.ElementAtOrDefault(0);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append(string.Concat(new string[]
					{
						"<td valign='top'>",
						Conversions.ToString(current.Count<Sensor>()),
						"x ",
						sensor.Name,
						"</td>"
					}));
					if (sensor.MaxRange > 0f)
					{
						stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(sensor.MaxRange) + "海里</td>");
					}
					else
					{
						stringBuilder.Append("<td align='center' valign='top'>-</td>");
					}
					stringBuilder.Append("<td valign='top'>" + sensor.Description + "</td>");
					stringBuilder.Append("<td valign='top'>");
					List<string> list = new List<string>();
					if (sensor.sensorType == Sensor.SensorType.Radar || sensor.sensorType == Sensor.SensorType.ESM || sensor.sensorType == Sensor.SensorType.ECM || sensor.sensorType == Sensor.SensorType.Visual || sensor.sensorType == Sensor.SensorType.Infrared || sensor.sensorType == Sensor.SensorType.BottomFixedSonar_PassiveOnly || sensor.sensorType == Sensor.SensorType.DippingSonar_ActiveOnly || sensor.sensorType == Sensor.SensorType.DippingSonar_ActivePassive || sensor.sensorType == Sensor.SensorType.DippingSonar_PassiveOnly || sensor.sensorType == Sensor.SensorType.HullSonar_ActiveOnly || sensor.sensorType == Sensor.SensorType.HullSonar_ActivePassive || sensor.sensorType == Sensor.SensorType.HullSonar_PassiveOnly || sensor.sensorType == Sensor.SensorType.PingIntercept || sensor.sensorType == Sensor.SensorType.TowedArray_ActiveOnly || sensor.sensorType == Sensor.SensorType.TowedArray_ActivePassive || sensor.sensorType == Sensor.SensorType.TowedArray_PassiveOnly || sensor.sensorType == Sensor.SensorType.VDS_ActiveOnly || sensor.sensorType == Sensor.SensorType.VDS_ActivePassive)
					{
						goto IL_27A;
					}
					if (sensor.sensorType == Sensor.SensorType.VDS_PassiveOnly)
					{
						goto IL_27A;
					}
					bool arg_281_0 = true;
					IL_281:
					if (!arg_281_0)
					{
						List<string> list2 = list;
						Scenario clientScenario = Client.GetClientScenario();
						list2.Add(DBFunctions.GetSensorGenerationDesciption(ref clientScenario, (int)sensor.techGenerationClass) + "技术水平");
					}
					if (sensor.sensorCapability.AirSearch)
					{
						list.Add("对空搜索");
					}
					if (sensor.sensorCapability.SurfaceSearch)
					{
						list.Add("对海搜索");
					}
					if (sensor.sensorCapability.SubmarineSearch)
					{
						list.Add("水下搜索");
					}
					if (sensor.sensorCapability.MineObstacleSearch)
					{
						list.Add("探雷障");
					}
					if (sensor.sensorCapability.LandSearch_Fixed)
					{
						list.Add("对地搜索(高度)");
					}
					if (sensor.sensorCapability.LandSearch_Mobile)
					{
						list.Add("对地搜索(机动)");
					}
					if (sensor.sensorCapability.Ground_mapping_only)
					{
						list.Add("仅地面测绘");
					}
					if (sensor.sensorCapability.Navigation_Only)
					{
						list.Add("仅导航");
					}
					if (sensor.sensorCapability.ABM_SpaceSearch)
					{
						list.Add("反导与空间搜索");
					}
					if (sensor.sensorCapability.OTH_Backscatter)
					{
						list.Add("超视距雷达(天波)");
					}
					if (sensor.sensorCapability.OTH_SurfaceWave)
					{
						list.Add("超视距雷达(地波)");
					}
					if (sensor.sensorCapability.TerrainAvoidanceOrFollowing)
					{
						list.Add("地形规避/跟随");
					}
					if (sensor.sensorCapability.WeatherAndNavigation)
					{
						list.Add("气象与导航");
					}
					if (sensor.sensorCapability.WeatherOnly)
					{
						list.Add("仅气象");
					}
					if (sensor.sensorCode.NCTR_JEM)
					{
						list.Add("NCTR - JEM");
					}
					if (sensor.sensorCode.NCTR_NBILST)
					{
						list.Add("NCTR - NBILST");
					}
					if (sensor.sensorType == Sensor.SensorType.ESM && sensor.ESMPreciseEmitterID)
					{
						list.Add("特定辐射源ID");
					}
					if (sensor.sensorCapability.RangeInformation)
					{
						list.Add("测距信息");
					}
					if (sensor.sensorCapability.AltitudeInformation)
					{
						list.Add("测高信息");
					}
					if (sensor.sensorCapability.SpeedInformation)
					{
						list.Add("测速信息");
					}
					if (sensor.sensorCapability.HeadingInformation)
					{
						list.Add("测向信息");
					}
					stringBuilder.Append(string.Join(", ", list) + "</td></tr>");
					continue;
					IL_27A:
					arg_281_0 = sensor.IsEyeball();
					goto IL_281;
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x0014CACC File Offset: 0x0014ACCC
		public string ShowMineCounterMeasuresGear(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetMineCounterMeasures().Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>反水雷装置</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>型号</td><td>说明</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Sensor>> enumerable = activeUnit_0.GetMineCounterMeasures().GroupBy(DBViewer.SensorFunc1);
				foreach (IGrouping<int, Sensor> current in enumerable)
				{
					Sensor sensor = current.ElementAtOrDefault(0);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append(string.Concat(new string[]
					{
						"<td valign='top'>",
						Conversions.ToString(current.Count<Sensor>()),
						"x ",
						sensor.Name,
						"</td>"
					}));
					stringBuilder.Append("<td valign='top'>" + sensor.Description + "</td>");
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0014CC2C File Offset: 0x0014AE2C
		public string ShowMounts(ActiveUnit activeUnit_)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_.m_Mounts.Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>挂架/弹药储备/武器</strong></span></div>");
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>挂架(火炮/发射架/弹射器等)</span>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>挂架</td><td align='center'>容量</td><td align='center'>发射间隔</td><td align='center'>装甲</td><td align='center'>平台传感器</td><td>武器数(按挂架)</td>");
				stringBuilder.Append("<td>说明</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Mount>> enumerable = activeUnit_.m_Mounts.GroupBy(DBViewer.MountFunc2);
				foreach (IGrouping<int, Mount> current in enumerable)
				{
					DBViewer.MountDirector mountDirector = new DBViewer.MountDirector(null);
					mountDirector.mount = current.ElementAtOrDefault(0);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append(string.Concat(new string[]
					{
						"<td valign='top'>",
						Conversions.ToString(current.Count<Mount>()),
						"x ",
						mountDirector.mount.Name,
						"</td>"
					}));
					if (mountDirector.mount.GetMagazineForMount().MagazineCapacity > 0 & Strings.InStr(mountDirector.mount.Name, "Rail", CompareMethod.Binary) > 0)
					{
						stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(mountDirector.mount.GetMagazineForMount().MagazineCapacity) + "</td>");
					}
					else
					{
						stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(mountDirector.mount.Capacity + mountDirector.mount.GetMagazineForMount().MagazineCapacity) + "</td>");
					}
					if (mountDirector.mount.GetMagazineForMount().MagazineCapacity > 0 & Strings.InStr(mountDirector.mount.Name, "Rail", CompareMethod.Binary) > 0)
					{
						Mount mount = mountDirector.mount;
						int num = 0;
						int num2 = 0;
						if (mount.method_35(ref num, ref num2) > 1)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							string[] array = new string[5];
							array[0] = "<td align='center' valign='top'>On-rail: ";
							array[1] = Conversions.ToString(mountDirector.mount.ROF);
							array[2] = "<br>齐射: ";
							int rOF = mountDirector.mount.ROF;
							int magazineROF = mountDirector.mount.GetMagazineForMount().MagazineROF;
							Mount mount2 = mountDirector.mount;
							num2 = 0;
							num = 0;
							array[3] = Conversions.ToString(rOF + magazineROF * mount2.method_35(ref num2, ref num));
							array[4] = "</td>";
							stringBuilder2.Append(string.Concat(array));
						}
						else
						{
							stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(mountDirector.mount.GetMagazineForMount().MagazineROF) + "</td>");
						}
					}
					else
					{
						stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(mountDirector.mount.ROF) + "</td>");
					}
					stringBuilder.Append("<td align='center' valign='top'>" + mountDirector.mount.ArmorGeneral.ToString() + "</td>");
					stringBuilder.Append("<td valign='top'>" + string.Join("<br/>", mountDirector.mount.GetSensors().Select(DBViewer.SensorFunc3).ToArray<string>()) + "</td>");
					stringBuilder.Append("<td valign='top'>");
					foreach (WeaponRec current2 in mountDirector.mount.GetWeaponRecCollection())
					{
						Weapon weapon = current2.GetWeapon(Client.GetClientScenario());
						stringBuilder.Append(RuntimeHelpers.GetObjectValue(Interaction.IIf(current2.GetCurrentLoad() == 0, "<i style='color:blue'>", "")));
						stringBuilder.Append(Conversions.ToString(current2.GetCurrentLoad()) + "x " + weapon.Name);
						foreach (WeaponRec current3 in mountDirector.mount.GetMagazineForMount().GetWeaponRecCollection())
						{
							if (current3.WeapID == current2.WeapID)
							{
								stringBuilder.Append(" (+" + Conversions.ToString(current3.GetCurrentLoad()) + " on mount magazine)");
							}
						}
						stringBuilder.Append(RuntimeHelpers.GetObjectValue(Interaction.IIf(current2.GetCurrentLoad() == 0, "</i>", "")));
						if (!weapon.IsDecoy())
						{
							stringBuilder.Append("<br/><font style='color:gray'>" + this.method_40(activeUnit_, weapon) + "</font>");
						}
						stringBuilder.Append("<br/>");
					}
					stringBuilder.Append("</td>");
					stringBuilder.Append("<td valign='top'>");
					if (mountDirector.mount.MountDirectorSet.Count > 0)
					{
						IEnumerable<IGrouping<int, Sensor>> enumerable2 = activeUnit_.GetAllNoneMCMSensors().Where(new Func<Sensor, bool>(mountDirector.IsDirectorMountedOnMe)).GroupBy(DBViewer.SensorFunc4);
						if (enumerable2.Count<IGrouping<int, Sensor>>() > 0)
						{
							List<string> list = new List<string>();
							foreach (IGrouping<int, Sensor> current4 in enumerable2)
							{
								list.Add(current4.ElementAtOrDefault(0).Name);
							}
							stringBuilder.Append(" 制导雷达: " + string.Join(", ", list) + ". ");
						}
					}
					if (mountDirector.mount.LocalControl)
					{
						stringBuilder.Append("可局部控制. ");
					}
					if (mountDirector.mount.Autonomous)
					{
						stringBuilder.Append("自主操作(无OODA延迟). ");
					}
					stringBuilder.Append("</td>");
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x0014D2BC File Offset: 0x0014B4BC
		public string method_27(Aircraft aircraft_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int dBID = aircraft_0.DBID;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			if (DBFunctions.smethod_43(dBID, ref sQLiteConnection).Count > 0)
			{
				if (aircraft_0.m_Mounts.Length == 0)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>可挂载武器</strong></span></div>");
				}
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>飞机可挂载武器及使用要求</span>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>可挂载武器</td><td align='center'>武器发射对载机速度要求</td><td align='center'>武器发射对载机高度要求</td><td>描述</td>");
				stringBuilder.Append("</tr>");
				int dBID2 = aircraft_0.DBID;
				sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
				foreach (int current in DBFunctions.smethod_43(dBID2, ref sQLiteConnection))
				{
					Weapon weapon = Client.GetClientScenario().GetWeapon(current);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append("<td valign='top'>" + weapon.Name + "</td>");
					string str;
					if (weapon.LaunchSpeedMin <= 0 && weapon.LaunchSpeedMax <= 0)
					{
						str = "";
					}
					else
					{
						str = Conversions.ToString(weapon.LaunchSpeedMin) + " - " + Conversions.ToString(weapon.LaunchSpeedMax) + "节";
					}
					string str2;
					if (weapon.LaunchAltitudeMin <= 0f && weapon.LaunchAltitudeMax <= 0f && weapon.LaunchAltitudeMin_ASL <= 0f && weapon.LaunchAltitudeMax_ASL <= 0f)
					{
						str2 = "";
					}
					else
					{
						float num;
						string text;
						if (weapon.LaunchAltitudeMin != 0f)
						{
							num = weapon.LaunchAltitudeMin;
							text = "(真高)";
						}
						else
						{
							num = weapon.LaunchAltitudeMin_ASL;
							text = "(海高)";
						}
						float num2;
						string text2;
						if (weapon.LaunchAltitudeMax != 0f)
						{
							num2 = weapon.LaunchAltitudeMax;
							text2 = "(真高)";
						}
						else
						{
							num2 = weapon.LaunchAltitudeMax_ASL;
							text2 = "(海高)";
						}
						str2 = string.Concat(new string[]
						{
							Conversions.ToString(Math.Round((double)(num * 3.28084f))),
							" 英尺",
							text,
							" - ",
							Conversions.ToString(Math.Round((double)(num2 * 3.28084f))),
							" 英尺",
							text2,
							"<br>",
							Conversions.ToString(Math.Round((double)(num * 10f)) / 10.0),
							"米",
							text,
							" - ",
							Conversions.ToString(Math.Round((double)(num2 * 10f)) / 10.0),
							"米",
							text2
						});
					}
					stringBuilder.Append("<td valign='top' align='center'>" + str + "</td>");
					stringBuilder.Append("<td valign='top' align='center'>" + str2 + "</td>");
					if (!weapon.IsDecoy() && !weapon.IsTank() && weapon.GetWeaponType() != Weapon._WeaponType.SensorPod)
					{
						stringBuilder.Append("<td valign='top' align='left'>" + this.method_40(aircraft_0, weapon) + "</td>");
					}
					else
					{
						stringBuilder.Append("<td></td>");
					}
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0014D690 File Offset: 0x0014B890
		public string method_28(Aircraft aircraft_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int dBID = aircraft_0.DBID;
			Dictionary<int, int> selectedAircraftTotalWeaponQty = null;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			Scenario clientScenario = Client.GetClientScenario();
			bool flag = false;
			Scenario scenario = null;
			Aircraft aircraft = null;
			int i = 0;
			bool flag2 = false;
			DataTable dataTable = DBFunctions.smethod_42(dBID, selectedAircraftTotalWeaponQty, ref sQLiteConnection, clientScenario, ref flag, ref scenario, ref aircraft, ref i, ref flag2);
			if (dataTable.Rows.Count > 0)
			{
				bool flag3 = aircraft_0.m_Mounts.Length == 0;
				int dBID2 = aircraft_0.DBID;
				sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
				if (flag3 & DBFunctions.smethod_43(dBID2, ref sQLiteConnection).Count == 0)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>挂架/储存/武器</strong></span></div>");
				}
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>飞机挂载</span>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>名称</td><td>挂载方案</td><td>作战半径与航行剖面</td><td align='center'>出动准备时间</td><td align='center'>昼夜与气象条件</td><td align='center'>预置飞机返航武器状态条件</td><td>DB ID#</td></td>");
				stringBuilder.Append("</tr>");
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						scenario = Client.GetClientScenario();
						Loadout loadout = DBFunctions.smethod_47(ref scenario, Conversions.ToInteger(dataRow["ID"]), false);
						stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td valign='middle'>" + loadout.Name);
						if (loadout.loadoutRole != Loadout.LoadoutRole.Ferry && loadout.loadoutRole != Loadout.LoadoutRole.Reserve && loadout.loadoutRole != Loadout.LoadoutRole.Unavailable)
						{
							stringBuilder.Append("<br>(" + Misc.GetLoadoutRoleDescription(loadout.loadoutRole, Client.GetClientScenario().GetSQLiteConnection()) + ")");
						}
						stringBuilder.Append("</td>");
						stringBuilder.Append("<td valign='middle'>");
						WeaponRec[] weaponRecArray = loadout.WeaponRecArray;
						checked
						{
							for (i = 0; i < weaponRecArray.Length; i++)
							{
								WeaponRec weaponRec = weaponRecArray[i];
								stringBuilder.Append(Conversions.ToString(weaponRec.GetCurrentLoad()) + "x " + weaponRec.GetWeapon(Client.GetClientScenario()).Name + "<br/>");
							}
							stringBuilder.Append(RuntimeHelpers.GetObjectValue(Interaction.IIf(loadout.bool_9, "<br/></br>需要外部照射.", "")));
							stringBuilder.Append("</td>");
							stringBuilder.Append("<td valign='middle'>");
							string str = "";
							string text;
							if (!Information.IsNothing(loadout.GetMissionProfile(Client.GetClientScenario())))
							{
								text = loadout.GetMissionProfile(Client.GetClientScenario()).strDescription;
								if (loadout.GetMissionProfile(Client.GetClientScenario()).DBID == 1001)
								{
									str = "";
								}
								else if (loadout.TimeOnStation_Minutes > 0)
								{
									str = Conversions.ToString((int)loadout.TimeOnStation_Minutes) + "分钟 作战半径：" + Conversions.ToString(loadout.CombatRadius) + "海里 ";
								}
								else
								{
									str = Conversions.ToString(loadout.CombatRadius) + "海里 ";
								}
							}
							else
							{
								text = "n/a";
							}
							text = str + text;
							stringBuilder.Append(text);
							stringBuilder.Append("</td>");
						}
						string str2;
						if (loadout.ReadyTime > 0)
						{
							str2 = Misc.GetTimeString((long)(loadout.ReadyTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false);
						}
						else
						{
							str2 = "";
						}
						stringBuilder.Append("<td align='center' valign='middle'>" + str2 + "</td>");
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td align='center' valign='middle'>",
							Misc.GetLoadoutDayNightString(loadout._LoadoutDayNight_0),
							"<br/>",
							Misc.GetWeatherProfileString(loadout.WeatherProfile),
							"</td>"
						}));
						string str3;
						if (Client.GetClientScenario().FeatureCompatibility.get_WeaponAGL_ASL(Client.GetClientScenario().GetSQLiteConnection()))
						{
							int dBID3 = loadout.DBID;
							int winchesterShotgunWeaponState = (int)loadout.WinchesterShotgunWeaponState;
							sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
							str3 = DBFunctions.smethod_37(dBID3, winchesterShotgunWeaponState, ref sQLiteConnection, Client.GetClientScenario(), false, loadout.loadoutRole);
						}
						else
						{
							str3 = "Winchester: 任务相关的武器已经消耗完毕，立即脱离战斗.";
						}
						stringBuilder.Append("<td align='center' valign='middle'>" + str3 + "</td>");
						stringBuilder.Append("<td>" + Conversions.ToString(loadout.DBID) + "</td>");
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0014DB64 File Offset: 0x0014BD64
		public string method_29(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				if (activeUnit_0.GetMagazines().Length > 0)
				{
					stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>弹药库</span>");
					stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
					stringBuilder.Append("<td>弹药库</td><td align='center'>容量</td><td align='center'>重新装载速率</td><td align='center'>装甲</td><td>弹药储备</td>");
					stringBuilder.Append("</tr>");
					Magazine[] magazines = activeUnit_0.GetMagazines();
					for (int i = 0; i < magazines.Length; i++)
					{
						Magazine magazine = magazines[i];
						stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td valign='top'>" + magazine.Name + "</td>");
						stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(magazine.MagazineCapacity) + "</td>");
						stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(magazine.MagazineROF) + "</td>");
						stringBuilder.Append("<td align='center' valign='top'>" + magazine.armorRating.ToString() + "</td>");
						stringBuilder.Append("<td valign='top'>" + string.Join("<br/>", magazine.GetWeaponRecCollection().Select(DBViewer.WeaponRecFunc5).ToArray<string>()) + "</td>");
						stringBuilder.Append("</tr>");
					}
					stringBuilder.Append("</table>");
					stringBuilder.Append("<br/>");
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0014DCDC File Offset: 0x0014BEDC
		public string method_30(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetCommDevices().Count<CommDevice>() > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>通信/ 数据链</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>名称</td><td align='center'>类型</td><td align='center'>最大距离</td><td align='center'>频道</td><td>属性</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, CommDevice>> enumerable = activeUnit_0.GetCommDevices().GroupBy(DBViewer.CommDeviceFunc6);
				using (IEnumerator<IGrouping<int, CommDevice>> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						CommDevice commDevice = enumerator.Current.ElementAtOrDefault(0);
						stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td>" + commDevice.Name + "</td>");
						stringBuilder.Append("<td align='center'>" + DBFunctions.smethod_17(commDevice.commLinkType, Client.GetClientScenario()) + "</td>");
						if (commDevice.Range > 0.0)
						{
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(commDevice.Range) + "海里</td>");
						}
						else
						{
							stringBuilder.Append("<td align='center'>-</td>");
						}
						if (commDevice.MaxChannels > 0)
						{
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(commDevice.MaxChannels) + "</td>");
						}
						else
						{
							stringBuilder.Append("<td align='center'>-</td>");
						}
						stringBuilder.Append("<td>");
						List<string> list = new List<string>();
						if (!commDevice.ParentSpecific)
						{
							list.Add("支持CEC");
						}
						if (commDevice.commCapability.Broadcast)
						{
							list.Add("广播");
						}
						if (commDevice.commCapability.ELFRadio)
						{
							list.Add("ELF无线电");
						}
						if (commDevice.commCapability.HFRadio)
						{
							list.Add("HF无线电");
						}
						if (commDevice.commCapability.LFRadio)
						{
							list.Add("LF无线电");
						}
						if (commDevice.commCapability.LOS_Limited)
						{
							list.Add("视距限制");
						}
						if (commDevice.commCapability.MFRadio)
						{
							list.Add("MF无线电");
						}
						if (commDevice.commCapability.Receive_Only)
						{
							list.Add("只收");
						}
						if (commDevice.commCapability.Secure)
						{
							list.Add("安全");
						}
						if (commDevice.commCapability.Send_Only)
						{
							list.Add("只发");
						}
						if (commDevice.commCapability.SHFRadio)
						{
							list.Add("SHF无线电");
						}
						if (commDevice.commCapability.UHFRadio)
						{
							list.Add("UHF无线电");
						}
						if (commDevice.commCapability.VHFRadio)
						{
							list.Add("VHF无线电");
						}
						if (commDevice.commCapability.ULFRadio)
						{
							list.Add("VLF无线电");
						}
						stringBuilder.Append(string.Join(", ", list) + "</td>");
						stringBuilder.Append("</tr>");
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0014E050 File Offset: 0x0014C250
		public string method_31(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetAirFacilities().Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>航空保障设施</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>类型</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, AirFacility>> enumerable = activeUnit_0.GetAirFacilities().GroupBy(DBViewer.AirFacilityFunc7);
				foreach (IGrouping<int, AirFacility> current in enumerable)
				{
					AirFacility airFacility = current.ElementAtOrDefault(0);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append(string.Concat(new string[]
					{
						"<td>",
						Conversions.ToString(current.Count<AirFacility>()),
						"x ",
						airFacility.Name,
						"</td>"
					}));
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0014E18C File Offset: 0x0014C38C
		public string method_32(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetDockFacilities().Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>停靠设施</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>类型</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, DockFacility>> enumerable = activeUnit_0.GetDockFacilities().GroupBy(DBViewer.DockFacilityFunc8);
				foreach (IGrouping<int, DockFacility> current in enumerable)
				{
					DockFacility dockFacility = current.ElementAtOrDefault(0);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append(string.Concat(new string[]
					{
						"<td>",
						Conversions.ToString(current.Count<DockFacility>()),
						"x ",
						dockFacility.Name,
						"</td>"
					}));
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0014E2C8 File Offset: 0x0014C4C8
		public string method_33(Weapon weapon_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string result;
			if (weapon_0.GetWeaponType() != Weapon._WeaponType.BuddyStore && weapon_0.GetWeaponType() != Weapon._WeaponType.Cargo && weapon_0.GetWeaponType() != Weapon._WeaponType.DropTank && weapon_0.GetWeaponType() != Weapon._WeaponType.FerryTank && weapon_0.GetWeaponType() != Weapon._WeaponType.HeliTowedPackage && weapon_0.GetWeaponType() != Weapon._WeaponType.None && weapon_0.GetWeaponType() != Weapon._WeaponType.Paratroops && weapon_0.GetWeaponType() != Weapon._WeaponType.SensorPod && weapon_0.GetWeaponType() != Weapon._WeaponType.TrainingRound && weapon_0.GetWeaponType() != Weapon._WeaponType.Troops && weapon_0.GetWeaponType() != Weapon._WeaponType.Sonobuoy)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>有效目标</strong></span></div>");
				stringBuilder.Append("<div style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<td>");
				List<string> validTargetsList = weapon_0.GetValidTargetsList();
				string value = Conversions.ToString(Interaction.IIf(validTargetsList.Count > 0, string.Join("<br/>", validTargetsList), ""));
				stringBuilder.Append(value);
				stringBuilder.Append("</td>");
				stringBuilder.Append("</tr>");
				stringBuilder.Append("</table>");
				stringBuilder.Append("</div>");
				stringBuilder.Append("<br/>");
				string text = stringBuilder.ToString();
				result = text;
			}
			else
			{
				string text = stringBuilder.ToString();
				result = text;
			}
			return result;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0014E440 File Offset: 0x0014C640
		public string method_34(Weapon weapon_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				string result;
				if (Information.IsNothing(weapon_0.m_Doctrine.GetWRA_WeaponDictionary()))
				{
					result = stringBuilder.ToString();
				}
				else
				{
					string[] array = new string[4];
					array[2] = "EnumWeaponWRA";
					if (weapon_0.m_Scenario.GetSQLiteConnection().GetSchema("Tables", array).Rows.Count == 0)
					{
						result = stringBuilder.ToString();
					}
					else
					{
						stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>武器使用规则[缺省]</strong></span></div>");
						stringBuilder.Append("<div style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
						stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
						stringBuilder.Append("<td>目标类型</td><td align='left'>齐射武器数</td><td align='left'>齐射最大发射单元数</td><td align='left'>自防御距离</td>");
						stringBuilder.Append("</tr>");
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in weapon_0.m_Doctrine.GetWRA_WeaponDictionary())
						{
							Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
							for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
							{
								Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
								stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
								stringBuilder.Append("<td>");
								stringBuilder.Append(weapon_0.m_Doctrine.GetWRA_WeaponTargetTypeString(wRA_WeaponTarget.WRA_WeaponTargetType));
								stringBuilder.Append("</td>");
								stringBuilder.Append("<td>");
								StringBuilder stringBuilder2 = stringBuilder;
								Scenario clientScenario = Client.GetClientScenario();
								stringBuilder2.Append(DBFunctions.GetWeaponWRAWeaponQtyDescription(ref clientScenario, wRA_WeaponTarget.WeaponQty.Value));
								stringBuilder.Append("</td>");
								stringBuilder.Append("<td>");
								StringBuilder stringBuilder3 = stringBuilder;
								clientScenario = Client.GetClientScenario();
								stringBuilder3.Append(DBFunctions.GetWeaponWRAShooterQtyDescription(ref clientScenario, wRA_WeaponTarget.ShooterQty.Value));
								stringBuilder.Append("</td>");
								stringBuilder.Append("<td>");
								StringBuilder stringBuilder4 = stringBuilder;
								clientScenario = Client.GetClientScenario();
								stringBuilder4.Append(DBFunctions.GetWeaponWRASelfDefenceRangeDescription(ref clientScenario, wRA_WeaponTarget.SelfDefenceRange.Value));
								stringBuilder.Append("</td>");
								stringBuilder.Append("</tr>");
							}
						}
						stringBuilder.Append("</table>");
						stringBuilder.Append("</div>");
						stringBuilder.Append("<br/>");
						result = stringBuilder.ToString();
					}
				}
				return result;
			}
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0014E6BC File Offset: 0x0014C8BC
		public string method_35(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string result;
			if (activeUnit_0.IsWeapon && (((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.BuddyStore || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Cargo || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Dispenser || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.DropTank || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.FerryTank || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Gun || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.HeliTowedPackage || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.IronBomb || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Laser || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.None || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Paratroops || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Rocket || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.SensorPod || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.TrainingRound || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Troops || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.DepthCharge || ((Weapon)activeUnit_0).GetWeaponType() == Weapon._WeaponType.Sonobuoy))
			{
				result = stringBuilder.ToString();
			}
			else
			{
				if (activeUnit_0.GetXSections().Count > 0)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>信号特征</strong></span></div>");
					stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
					stringBuilder.Append("<td>信号特征类型</td><td align='center'>前面</td><td align='center'>侧面</td><td align='center'>后面</td>");
					stringBuilder.Append("</tr>");
				}
				foreach (XSection current in activeUnit_0.GetXSections())
				{
					if ((current.GetFrontXSection(activeUnit_0) != 0f || current.GetSideXSection(activeUnit_0) != 0f || current.GetRearXSection(activeUnit_0) != 0f) && current.GetFrontXSection(activeUnit_0) != -10000f && current.GetSideXSection(activeUnit_0) != -10000f && current.GetRearXSection(activeUnit_0) != -10000f)
					{
						stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td>" + DBFunctions.smethod_18(current.SignatureType, Client.GetClientScenario()) + "</td>");
						if (current.SignatureType == XSection._SignatureType.PassiveSonar_VLF || current.SignatureType == XSection._SignatureType.PassiveSonar_LF || current.SignatureType == XSection._SignatureType.PassiveSonar_MF || current.SignatureType == XSection._SignatureType.PassiveSonar_HF)
						{
							string str = " dB";
							string str2 = " dB";
							string str3 = " dB";
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetFrontXSection(activeUnit_0)) + str + "</td>");
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetSideXSection(activeUnit_0)) + str2 + "</td>");
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetRearXSection(activeUnit_0)) + str3 + "</td>");
							stringBuilder.Append("</tr>");
						}
						else if (current.SignatureType == XSection._SignatureType.ActiveSonar_VLF_HF)
						{
							string str = " dB";
							string str2 = " dB";
							string str3 = " dB";
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetFrontXSection(activeUnit_0)) + str + "</td>");
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetSideXSection(activeUnit_0)) + str2 + "</td>");
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetRearXSection(activeUnit_0)) + str3 + "</td>");
							stringBuilder.Append("</tr>");
						}
						else if (current.SignatureType != XSection._SignatureType.VisualDetectionRange && current.SignatureType != XSection._SignatureType.VisualClassificationRange && current.SignatureType != XSection._SignatureType.InfraredDetectionRange && current.SignatureType != XSection._SignatureType.InfraredClassificationRange)
						{
							if (current.SignatureType != XSection._SignatureType.Radar_A_D_Band && current.SignatureType != XSection._SignatureType.Radar_E_M_Band)
							{
								string str = "";
								string str2 = "";
								string str3 = "";
								stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetFrontXSection(activeUnit_0)) + str + "</td>");
								stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetSideXSection(activeUnit_0)) + str2 + "</td>");
								stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetRearXSection(activeUnit_0)) + str3 + "</td>");
								stringBuilder.Append("</tr>");
							}
							else
							{
								double num = Math.Pow(10.0, (double)(current.GetFrontXSection(activeUnit_0) / 10f));
								int digits;
								if (num < 1.0 & num >= 0.1)
								{
									digits = 2;
								}
								else if (num < 0.1 & num >= 0.01)
								{
									digits = 3;
								}
								else if (num < 0.01 & num >= 0.001)
								{
									digits = 4;
								}
								else if (num < 0.001 & num >= 0.0001)
								{
									digits = 5;
								}
								else if (num < 0.0001 & num >= 1E-05)
								{
									digits = 6;
								}
								else
								{
									digits = 1;
								}
								string str = " dBsm, " + Conversions.ToString(Math.Round(Math.Pow(10.0, (double)(current.GetFrontXSection(activeUnit_0) / 10f)), digits)) + " sq.m.";
								string str2 = " dBsm, " + Conversions.ToString(Math.Round(Math.Pow(10.0, (double)(current.GetSideXSection(activeUnit_0) / 10f)), digits)) + " sq.m.";
								string str3 = " dBsm, " + Conversions.ToString(Math.Round(Math.Pow(10.0, (double)(current.GetRearXSection(activeUnit_0) / 10f)), digits)) + " sq.m.";
								stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetFrontXSection(activeUnit_0)) + str + "</td>");
								stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetSideXSection(activeUnit_0)) + str2 + "</td>");
								stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetRearXSection(activeUnit_0)) + str3 + "</td>");
								stringBuilder.Append("</tr>");
							}
						}
						else
						{
							string str = "海里";
							string str2 = "海里";
							string str3 = "海里";
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetFrontXSection(activeUnit_0)) + str + "</td>");
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetSideXSection(activeUnit_0)) + str2 + "</td>");
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(current.GetRearXSection(activeUnit_0)) + str3 + "</td>");
							stringBuilder.Append("</tr>");
						}
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0014EEA8 File Offset: 0x0014D0A8
		public string method_36(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			new List<string>();
			if (DBFunctions.smethod_16(activeUnit_0.GetUnitType(), activeUnit_0.DBID, Client.GetClientScenario().GetSQLiteConnection()).Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>属性</strong></span></div>");
				stringBuilder.Append("<div style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<td>");
				stringBuilder.Append(string.Join("<br/>", DBFunctions.smethod_16(activeUnit_0.GetUnitType(), activeUnit_0.DBID, Client.GetClientScenario().GetSQLiteConnection())));
				stringBuilder.Append("</td>");
				stringBuilder.Append("</tr>");
				stringBuilder.Append("</table>");
				stringBuilder.Append("</div>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0014EF98 File Offset: 0x0014D198
		public string method_37(Weapon weapon_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (weapon_0.m_Warheads.Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>战斗部</strong></span></div>");
				stringBuilder.Append("<div style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<td>");
				IEnumerable<IGrouping<string, Warhead>> enumerable = weapon_0.m_Warheads.GroupBy(DBViewer.WarheadFunc9);
				List<string> list = new List<string>();
				foreach (IGrouping<string, Warhead> current in enumerable)
				{
					string text = "";
					if (current.Count<Warhead>() > 1)
					{
						text = Conversions.ToString(current.Count<Warhead>()) + "x ";
					}
					string text2;
					string text3;
					if (current.ElementAtOrDefault(0).HasNuclearWarhead(Client.GetClientScenario()) & current.ElementAtOrDefault(0).warheadType != Warhead.WarheadType.Weapon)
					{
						if (current.ElementAtOrDefault(0).DP >= 1E+09f)
						{
							text2 = Convert.ToString(current.ElementAtOrDefault(0).DP / 1E+09f);
							text3 = " mT";
						}
						else
						{
							text2 = Convert.ToString(current.ElementAtOrDefault(0).DP / 1000000f);
							text3 = "kT";
						}
					}
					else if (current.ElementAtOrDefault(0).warheadType == Warhead.WarheadType.Weapon)
					{
						text2 = "";
						text3 = "";
					}
					else
					{
						text2 = Convert.ToString(current.ElementAtOrDefault(0).DP);
						text3 = " DP";
					}
					list.Add(string.Concat(new string[]
					{
						text,
						current.ElementAtOrDefault(0).Name,
						" (",
						text2,
						text3,
						")"
					}));
				}
				string value = Conversions.ToString(Interaction.IIf(list.Count > 0, string.Join(" - ", list), ""));
				stringBuilder.Append(value);
				stringBuilder.Append("</td>");
				stringBuilder.Append("</tr>");
				stringBuilder.Append("</table>");
				stringBuilder.Append("</div>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0014F218 File Offset: 0x0014D418
		public string method_38(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetEngines().Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>推进系统</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>引擎</td><td>类型</td><td>最大速度</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Engine>> enumerable = activeUnit_0.GetEngines().GroupBy(DBViewer.EngineDBIDFunc);
				foreach (IGrouping<int, Engine> current in enumerable)
				{
					string str;
					if (current.Count<Engine>() > 1)
					{
						str = Conversions.ToString(current.Count<Engine>()) + "x ";
					}
					else
					{
						str = "";
					}
					Engine engine = current.ElementAtOrDefault(0);
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					try
					{
						if (engine.altBands.Select(DBViewer.AltBandFunc11).Max() > 0)
						{
							stringBuilder.Append("<td>" + str + engine.Name + "</td>");
							stringBuilder.Append("<td valign='top'>" + Misc.GetPropulsionTypeDescription(engine.PropulsionType, Client.GetClientScenario().GetSQLiteConnection()) + "</td>");
							stringBuilder.Append("<td valign='top'>" + Conversions.ToString(engine.altBands.Select(DBViewer.AltBandFunc12).Max()) + "节</td>");
						}
						else
						{
							stringBuilder.Append("<td>无</td>");
							stringBuilder.Append("<td></td>");
							stringBuilder.Append("<td></td>");
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						stringBuilder.Append("<td>无</td>");
						stringBuilder.Append("<td></td>");
						stringBuilder.Append("<td></td>");
						ex2.Data.Add("Error at 200376", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
				if (activeUnit_0.IsAircraft)
				{
					using (IEnumerator<IGrouping<int, Engine>> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Engine engine = enumerator2.Current.ElementAtOrDefault(0);
							List<float> list = new List<float>();
							try
							{
								list = DBFunctions.smethod_13(engine.DBID, Client.GetClientScenario().GetSQLiteConnection());
								if (list.Count > 0)
								{
									stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>技术指标</span>");
									stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
									stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
									stringBuilder.Append("<td>军事静态推力 S/L</td><td>加力燃烧室静态推力 S/L</td><td>军事静态SFC  S/L</td><td>加力燃烧室静态SFC S/L</td>");
									stringBuilder.Append("</tr>");
									stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
									if (list[0] == 1f)
									{
										stringBuilder.Append("<td>" + Conversions.ToString(list[1]) + " 公斤</td>");
										if (list[2] > 0f)
										{
											stringBuilder.Append("<td>" + Conversions.ToString(list[2]) + " 公斤</td>");
										}
										else
										{
											stringBuilder.Append("<td>-</td>");
										}
									}
									else
									{
										stringBuilder.Append("<td>" + Conversions.ToString(list[1]) + " 公斤 每引擎</td>");
										if (list[2] > 0f)
										{
											stringBuilder.Append("<td>" + Conversions.ToString(list[2]) + " 公斤 每引擎</td>");
										}
										else
										{
											stringBuilder.Append("<td>-</td>");
										}
									}
									stringBuilder.Append("<td>" + Conversions.ToString(list[3]) + " kg/h/kg</td>");
									if (list[4] > 0f)
									{
										stringBuilder.Append("<td>" + Conversions.ToString(list[4]) + " kg/h/kg</td>");
									}
									else
									{
										stringBuilder.Append("<td>-</td>");
									}
									stringBuilder.Append("</tr>");
									stringBuilder.Append("</table>");
									stringBuilder.Append("<br/>");
								}
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ex4.Data.Add("Error at 200377", ex4.Message);
								GameGeneral.LogException(ref ex4);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				using (IEnumerator<IGrouping<int, Engine>> enumerator3 = enumerable.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						Engine engine = enumerator3.Current.ElementAtOrDefault(0);
						int num = 1;
						if (engine.altBands.Length > 0)
						{
							if (activeUnit_0.GetEngines().Count > 1)
							{
								stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>性能指标：" + DBFunctions.LoadPropulsionData(engine.DBID, ref activeUnit_0).Name + "</span>");
							}
							else
							{
								stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>性能指标</span>");
							}
							stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
							stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
							if (engine.PropulsionType == Engine._PropulsionType.Nuclear)
							{
								if (activeUnit_0.IsSubmarine)
								{
									stringBuilder.Append("<td>高度范围与油门</td><td>高度</td><td>速度</td>");
								}
								else
								{
									stringBuilder.Append("<td>高度范围与油门</td><td>速度</td>");
								}
							}
							else if (!activeUnit_0.IsAircraft && !activeUnit_0.IsGuidedWeapon_RV_HGV())
							{
								if (!activeUnit_0.IsSubmarine && !activeUnit_0.IsTorpedo())
								{
									stringBuilder.Append("<td>高度范围与油门</td><td>速度</td><td>耗油率</td>");
								}
								else
								{
									stringBuilder.Append("<td>高度范围与油门</td><td>深度</td><td>速度</td><td>耗油率</td>");
								}
							}
							else
							{
								stringBuilder.Append("<td>高度范围与油门</td><td>高度</td><td>速度</td><td>耗油率</td>");
							}
							stringBuilder.Append("</tr>");
							AltBand[] altBands = engine.altBands;
							for (int i = 0; i < altBands.Length; i = checked(i + 1))
							{
								AltBand altBand = altBands[i];
								try
								{
									if (altBand.Speed_Loiter > 0)
									{
										stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.IsAircraft && !activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											if (!activeUnit_0.IsSubmarine && !activeUnit_0.IsTorpedo())
											{
												stringBuilder.Append("<td valign='top'>低速油门</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 低速油门</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 低速</td>");
										}
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f))),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f))),
												" 英尺<br>",
												Conversions.ToString(altBand.MinAltitude),
												" - ",
												Conversions.ToString(altBand.MaxAltitude),
												"米</td>"
											}));
										}
										if (activeUnit_0.IsSubmarine || activeUnit_0.IsTorpedo())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f)) * -1.0),
												" 英尺<br>",
												Conversions.ToString(altBand.MaxAltitude * -1f),
												" - ",
												Conversions.ToString(altBand.MinAltitude * -1f),
												"米</td>"
											}));
										}
										stringBuilder.Append("<td>" + Conversions.ToString(altBand.Speed_Loiter) + "节");
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append("<br>" + Conversions.ToString(Math.Round((double)(Class263.GetIRCrossSectionModifier((double)altBand.MinAltitude, (double)altBand.Speed_Loiter) * 100f)) / 100.0) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.PropulsionType != Engine._PropulsionType.Nuclear)
										{
											if (engine.PropulsionType != Engine._PropulsionType.Electric && engine.PropulsionType != Engine._PropulsionType.AirIndependent)
											{
												if (activeUnit_0.IsWeapon)
												{
													stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.Consumption_Loiter) + " 燃油点 /秒</td>");
												}
												else
												{
													stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.Consumption_Loiter) + "公斤/分钟</td>");
												}
											}
											else
											{
												stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.Consumption_Loiter) + "电池单元/分钟</td>");
											}
										}
										stringBuilder.Append("</tr>");
									}
									if (altBand.Speed_Cruise > 0)
									{
										stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.IsAircraft && !activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											if (!activeUnit_0.IsSubmarine && !activeUnit_0.IsTorpedo())
											{
												stringBuilder.Append("<td valign='top'>巡航油门</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 巡航油门</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 巡航速度</td>");
										}
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f))),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f))),
												" 英尺<br>",
												Conversions.ToString(altBand.MinAltitude),
												" - ",
												Conversions.ToString(altBand.MaxAltitude),
												"米</td>"
											}));
										}
										if (activeUnit_0.IsSubmarine || activeUnit_0.IsTorpedo())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f)) * -1.0),
												" 英尺<br>",
												Conversions.ToString(altBand.MaxAltitude * -1f),
												" - ",
												Conversions.ToString(altBand.MinAltitude * -1f),
												"米</td>"
											}));
										}
										stringBuilder.Append("<td>" + Conversions.ToString(altBand.Speed_Cruise) + "节");
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append("<br>" + Conversions.ToString(Math.Round((double)(Class263.GetIRCrossSectionModifier((double)altBand.MinAltitude, (double)altBand.Speed_Cruise) * 100f)) / 100.0) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.PropulsionType != Engine._PropulsionType.Nuclear)
										{
											if (engine.PropulsionType != Engine._PropulsionType.Electric && engine.PropulsionType != Engine._PropulsionType.AirIndependent)
											{
												if (activeUnit_0.IsWeapon)
												{
													stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.Consumption_Cruise) + " 燃油点 /秒</td>");
												}
												else
												{
													stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.Consumption_Cruise) + "公斤/分钟</td>");
												}
											}
											else
											{
												stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.Consumption_Cruise) + "电池单元/分钟</td>");
											}
										}
										stringBuilder.Append("</tr>");
									}
									if (altBand.Speed_Full.HasValue)
									{
										stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.IsAircraft && !activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											if (!activeUnit_0.IsSubmarine && !activeUnit_0.IsTorpedo())
											{
												stringBuilder.Append("<td valign='top'>全速油门</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 全速油门</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 军事速度</td>");
										}
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f))),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f))),
												" 英尺<br>",
												Conversions.ToString(altBand.MinAltitude),
												" - ",
												Conversions.ToString(altBand.MaxAltitude),
												"米</td>"
											}));
										}
										if (activeUnit_0.IsSubmarine || activeUnit_0.IsTorpedo())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f)) * -1.0),
												" 英尺<br>",
												Conversions.ToString(altBand.MaxAltitude * -1f),
												" - ",
												Conversions.ToString(altBand.MinAltitude * -1f),
												"米</td>"
											}));
										}
										StringBuilder stringBuilder2 = stringBuilder;
										string str2 = "<td>";
										long? num3;
										long? num2 = num3 = altBand.Speed_Full;
										stringBuilder2.Append(str2 + (num2.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "节");
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append("<br>" + Conversions.ToString(Math.Round((double)(Class263.GetIRCrossSectionModifier((double)altBand.MinAltitude, (double)altBand.Speed_Full.Value) * 100f)) / 100.0) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.PropulsionType != Engine._PropulsionType.Nuclear)
										{
											if (engine.PropulsionType != Engine._PropulsionType.Electric && engine.PropulsionType != Engine._PropulsionType.AirIndependent)
											{
												if (activeUnit_0.IsWeapon)
												{
													StringBuilder stringBuilder3 = stringBuilder;
													string str3 = "<td valign='top'>";
													float? num5;
													float? num4 = num5 = altBand.Consumption_Full;
													stringBuilder3.Append(str3 + (num4.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + " 燃油点 /秒</td>");
												}
												else
												{
													StringBuilder stringBuilder4 = stringBuilder;
													string str4 = "<td valign='top'>";
													float? num5;
													float? num4 = num5 = altBand.Consumption_Full;
													stringBuilder4.Append(str4 + (num4.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "公斤/分钟</td>");
												}
											}
											else
											{
												StringBuilder stringBuilder5 = stringBuilder;
												string str5 = "<td valign='top'>";
												float? num5;
												float? num4 = num5 = altBand.Consumption_Full;
												stringBuilder5.Append(str5 + (num4.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "电池单元/分钟</td>");
											}
										}
										stringBuilder.Append("</tr>");
									}
									if (altBand.Speed_Flank.HasValue)
									{
										stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.IsAircraft && !activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											if (!activeUnit_0.IsSubmarine && !activeUnit_0.IsTorpedo())
											{
												stringBuilder.Append("<td valign='top'>最大油门</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 最大油门</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>范围 " + Conversions.ToString(num) + ", 加力速度</td>");
										}
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f))),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f))),
												" 英尺<br>",
												Conversions.ToString(altBand.MinAltitude),
												" - ",
												Conversions.ToString(altBand.MaxAltitude),
												"米</td>"
											}));
										}
										if (activeUnit_0.IsSubmarine || activeUnit_0.IsTorpedo())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Math.Round((double)(altBand.MaxAltitude * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Math.Round((double)(altBand.MinAltitude * 3.28084f)) * -1.0),
												" 英尺<br>",
												Conversions.ToString(altBand.MaxAltitude * -1f),
												" - ",
												Conversions.ToString(altBand.MinAltitude * -1f),
												"米</td>"
											}));
										}
										StringBuilder stringBuilder6 = stringBuilder;
										string str6 = "<td>";
										long? num3;
										long? num2 = num3 = altBand.Speed_Flank;
										stringBuilder6.Append(str6 + (num2.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "节");
										if (activeUnit_0.IsAircraft || activeUnit_0.IsGuidedWeapon_RV_HGV())
										{
											stringBuilder.Append("<br>" + Conversions.ToString(Math.Round((double)(Class263.GetIRCrossSectionModifier((double)altBand.MinAltitude, (double)altBand.Speed_Flank.Value) * 100f)) / 100.0) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.PropulsionType != Engine._PropulsionType.Nuclear)
										{
											if (engine.PropulsionType != Engine._PropulsionType.Electric && engine.PropulsionType != Engine._PropulsionType.AirIndependent)
											{
												if (activeUnit_0.IsWeapon)
												{
													StringBuilder stringBuilder7 = stringBuilder;
													string str7 = "<td valign='top'>";
													float? num5;
													float? num4 = num5 = altBand.Consumption_Flank;
													stringBuilder7.Append(str7 + (num4.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + " 燃油点 /秒</td>");
												}
												else
												{
													StringBuilder stringBuilder8 = stringBuilder;
													string str8 = "<td valign='top'>";
													float? num5;
													float? num4 = num5 = altBand.Consumption_Flank;
													stringBuilder8.Append(str8 + (num4.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "公斤/分钟</td>");
												}
											}
											else
											{
												StringBuilder stringBuilder9 = stringBuilder;
												string str9 = "<td valign='top'>";
												float? num5;
												float? num4 = num5 = altBand.Consumption_Flank;
												stringBuilder9.Append(str9 + (num4.HasValue ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "电池单元/分钟</td>");
											}
										}
										stringBuilder.Append("</tr>");
									}
									goto IL_14C4;
								}
								catch (Exception ex5)
								{
									ProjectData.SetProjectError(ex5);
									Exception ex6 = ex5;
									ex6.Data.Add("Error at 200378", ex6.Message);
									GameGeneral.LogException(ref ex6);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
									goto IL_14C4;
								}
								break;
								IL_14C4:
								num++;
							}
							stringBuilder.Append("</table>");
							stringBuilder.Append("<br/>");
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x001507AC File Offset: 0x0014E9AC
		public string method_39(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.GetFuelRecs().Count<FuelRec>() > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>燃油</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center' border='1' bordercolor='Silver' cellpadding='2' cellspacing='0' rules='rows' style='font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: white; border: 1px none silver; height: 10px; border-collapse: collapse;'>");
				stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>燃油类型</td><td>数量</td>");
				stringBuilder.Append("</tr>");
				FuelRec[] fuelRecs = activeUnit_0.GetFuelRecs();
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					stringBuilder.Append("<tr style='color:Black;background-color:WhiteSmoke;font-family:Verdana;font-size:8pt;'>");
					double num = (double)fuelRec.MaxQuantity;
					string str;
					if (!activeUnit_0.IsAircraft & !activeUnit_0.IsWeapon)
					{
						if (fuelRec.FuelType != FuelRec._FuelType.Battery && fuelRec.FuelType != FuelRec._FuelType.AirIndepedent)
						{
							num /= 1000.0;
							str = "吨";
						}
						else if (num > 120.0)
						{
							num = Math.Round(num / 60.0 * 10.0) / 10.0;
							str = "小时(低速油门)";
						}
						else
						{
							str = "分钟(低速油门)";
						}
					}
					else if (activeUnit_0.IsWeapon)
					{
						if (num > 120.0)
						{
							num = Math.Round(num / 60.0 * 10.0) / 10.0;
							str = "分钟";
						}
						else
						{
							str = "秒";
						}
					}
					else
					{
						str = "公斤";
					}
					stringBuilder.Append("<td>" + Misc.GetFuelTypeDescription(fuelRec.FuelType, Client.GetClientScenario().GetSQLiteConnection()) + "</td>");
					stringBuilder.Append("<td>" + Conversions.ToString(num) + str + "</td>");
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x001509BC File Offset: 0x0014EBBC
		public string method_40(ActiveUnit activeUnit_0, Weapon weapon_0)
		{
			DBViewer.OnboardSeekerForWeapon onboardSeekerForWeapon = new DBViewer.OnboardSeekerForWeapon(null);
			onboardSeekerForWeapon.weapon = weapon_0;
			string text = onboardSeekerForWeapon.weapon.GetWeaponTypeString() + ". ";
			string text2 = "目标: " + string.Join(", ", onboardSeekerForWeapon.weapon.GetValidTargetsList()) + ". ";
			string text3 = Conversions.ToString(Interaction.IIf(onboardSeekerForWeapon.weapon.GetWeaponKinematics().GetMaxSpeed() > 0, "最大速度: " + Conversions.ToString(onboardSeekerForWeapon.weapon.GetWeaponKinematics().GetMaxSpeed()) + "节. ", ""));
			string text4 = Conversions.ToString(Interaction.IIf(onboardSeekerForWeapon.weapon.GetLargestRangeMaxOfAllDomains() > 0f, "最大距离: " + Conversions.ToString(onboardSeekerForWeapon.weapon.GetLargestRangeMaxOfAllDomains()) + "海里. ", ""));
			IEnumerable<IGrouping<string, Warhead>> enumerable = onboardSeekerForWeapon.weapon.m_Warheads.GroupBy(DBViewer.WarheadNameFunc);
			List<string> list = new List<string>();
			foreach (IGrouping<string, Warhead> current in enumerable)
			{
				string text5 = "";
				if (current.Count<Warhead>() > 1)
				{
					text5 = Conversions.ToString(current.Count<Warhead>()) + "x ";
				}
				if (current.ElementAtOrDefault(0).HasNuclearWarhead(Client.GetClientScenario()))
				{
					list.Add(text5 + current.ElementAtOrDefault(0).Name);
				}
				else if (current.ElementAtOrDefault(0).DP >= 0f)
				{
					list.Add(text5 + current.ElementAtOrDefault(0).Name);
				}
				else
				{
					list.Add(string.Concat(new string[]
					{
						text5,
						current.ElementAtOrDefault(0).Name,
						" (",
						Conversions.ToString(current.ElementAtOrDefault(0).DP),
						" DPs)"
					}));
				}
			}
			string text6 = Conversions.ToString(Interaction.IIf(list.Count > 0, RuntimeHelpers.GetObjectValue(Interaction.IIf(onboardSeekerForWeapon.weapon.m_Warheads.Length > 1, "战斗部: " + string.Join(" - ", list), "战斗部: " + string.Join(" - ", list))), "")) + ". ";
			string text7 = "";
			if (onboardSeekerForWeapon.weapon.IsGuidedWeapon() && onboardSeekerForWeapon.weapon.weaponDirectorSet.Count > 0)
			{
				IEnumerable<IGrouping<int, Sensor>> enumerable2 = activeUnit_0.GetAllNoneMCMSensors().Where(new Func<Sensor, bool>(onboardSeekerForWeapon.IsOnboardSeekerForWeapon)).GroupBy(DBViewer.SensorDBIDFunc);
				if (enumerable2.Count<IGrouping<int, Sensor>>() > 0)
				{
					List<string> list2 = new List<string>();
					foreach (IGrouping<int, Sensor> current2 in enumerable2)
					{
						list2.Add(current2.ElementAtOrDefault(0).Name);
					}
					text7 = " 制导雷达: " + string.Join(", ", list2) + ". ";
				}
			}
			string text8 = "";
			if (onboardSeekerForWeapon.weapon.IsMine())
			{
				text8 = string.Concat(new string[]
				{
					"部署深度: ",
					Conversions.ToString(Math.Round((double)(onboardSeekerForWeapon.weapon.TargetAltitudeMin_ASL * 3.28084f))),
					" 英尺 - ",
					Conversions.ToString(Math.Round((double)(onboardSeekerForWeapon.weapon.TargetAltitudeMax_ASL * 3.28084f))),
					"英尺, ",
					Conversions.ToString(onboardSeekerForWeapon.weapon.TargetAltitudeMin_ASL),
					"米 - ",
					Conversions.ToString(onboardSeekerForWeapon.weapon.TargetAltitudeMax_ASL),
					"米. "
				});
			}
			return string.Concat(new string[]
			{
				text,
				text2,
				text3,
				text4,
				text6,
				text8,
				text7
			});
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x00150E40 File Offset: 0x0014F040
		public string method_41(Weapon weapon_0)
		{
			StreamReader streamReader = new StreamReader(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Templates\\Platform.html");
			string text = "";
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			text = text.Replace("<%PlatformName%>", "#" + Conversions.ToString(this.DBID) + " - " + weapon_0.UnitClass);
			text = text.Replace("<%Image%>", this.GetPlatformImageDirectory(weapon_0));
			text = text.Replace("<%Description%>", this.method_23(weapon_0));
			text = text.Replace("<%General%>", this.GetWeaponGeneralData(weapon_0));
			text = text.Replace("<%Sensors%>", this.ShowSensorsAndEW(weapon_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Comms%>", this.method_30(weapon_0));
			text = text.Replace("<%Signatures%>", this.method_35(weapon_0));
			text = text.Replace("<%Flags%>", this.method_36(weapon_0));
			text = text.Replace("<%Warheads%>", this.method_37(weapon_0));
			text = text.Replace("<%ValidTargets%>", this.method_33(weapon_0));
			text = text.Replace("<%WRA%>", this.method_34(weapon_0));
			text = text.Replace("<%Propulsion%>", this.method_38(weapon_0));
			text = text.Replace("<%Fuel%>", this.method_39(weapon_0));
			return text;
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x00150FC0 File Offset: 0x0014F1C0
		private void DBViewer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!this.bool_1 && !this.comboBox_1.Focused && !this.textBox_0.Focused && !this.comboBox_0.Focused && !this.comboBox_2.Focused && !this.listBox_0.Focused && base.Visible && e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.End && e.KeyCode != Keys.Home)
			{
				CommandFactory.GetCommandMain().GetMainForm().Focus();
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x000206BB File Offset: 0x0001E8BB
		private void DBViewer_MouseWheel(object sender, MouseEventArgs e)
		{
			if (this.bool_1)
			{
				this.listBox_0.Focus();
			}
			else
			{
				this.webBrowser_0.Focus();
			}
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x001510C8 File Offset: 0x0014F2C8
		private void method_42(object sender, MouseEventArgs e)
		{
			bool flag;
			if (flag = (e.Delta > 0))
			{
				if (flag)
				{
					this.listBox_0.TopIndex = this.listBox_0.TopIndex - 3;
				}
			}
			else
			{
				this.listBox_0.TopIndex = this.listBox_0.TopIndex + 3;
			}
			((HandledMouseEventArgs)e).Handled = true;
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x000206E2 File Offset: 0x0001E8E2
		private void method_43(object sender, EventArgs e)
		{
			if (!this.listBox_0.Focused)
			{
				this.listBox_0.Focus();
			}
			this.bool_1 = true;
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00020704 File Offset: 0x0001E904
		private void method_44(object sender, EventArgs e)
		{
			this.bool_1 = false;
			this.webBrowser_0.Focus();
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x000206B3 File Offset: 0x0001E8B3
		private void method_45(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0015112C File Offset: 0x0014F32C
		private void method_46(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!this.bool_1 && !this.comboBox_1.Focused && !this.textBox_0.Focused && !this.comboBox_0.Focused && !this.comboBox_2.Focused && !this.listBox_0.Focused && e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.End && e.KeyCode != Keys.Home)
			{
				CommandFactory.GetCommandMain().GetMainForm().Focus();
				KeyEventArgs e2 = new KeyEventArgs(e.KeyData);
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e2);
			}
		}

		// Token: 0x04001CB8 RID: 7352
		public static Func<Sensor, int> SensorFunc0 = (Sensor sensor_0) => sensor_0.DBID;

		// Token: 0x04001CB9 RID: 7353
		public static Func<Sensor, int> SensorFunc1 = (Sensor sensor_0) => sensor_0.DBID;

		// Token: 0x04001CBA RID: 7354
		public static Func<Mount, int> MountFunc2 = (Mount mount_0) => mount_0.DBID;

		// Token: 0x04001CBB RID: 7355
		public static Func<Sensor, string> SensorFunc3 = (Sensor sensor_0) => sensor_0.Name;

		// Token: 0x04001CBC RID: 7356
		public static Func<Sensor, int> SensorFunc4 = (Sensor sensor_0) => sensor_0.DBID;

		// Token: 0x04001CBD RID: 7357
		public static Func<WeaponRec, string> WeaponRecFunc5 = (WeaponRec weaponRec_0) => DBViewer.method_5(weaponRec_0);

		// Token: 0x04001CBE RID: 7358
		public static Func<CommDevice, int> CommDeviceFunc6 = (CommDevice commDevice_0) => commDevice_0.DBID;

		// Token: 0x04001CBF RID: 7359
		public static Func<AirFacility, int> AirFacilityFunc7 = (AirFacility airFacility_0) => airFacility_0.DBID;

		// Token: 0x04001CC0 RID: 7360
		public static Func<DockFacility, int> DockFacilityFunc8 = (DockFacility dockFacility_0) => dockFacility_0.DBID;

		// Token: 0x04001CC1 RID: 7361
		public static Func<Warhead, string> WarheadFunc9 = (Warhead warhead_0) => warhead_0.Name;

		// Token: 0x04001CC2 RID: 7362
		public static Func<Engine, int> EngineDBIDFunc = (Engine engine_0) => engine_0.DBID;

		// Token: 0x04001CC3 RID: 7363
		public static Func<AltBand, int> AltBandFunc11 = (AltBand altBand_0) => altBand_0.GetMaxSpeed();

		// Token: 0x04001CC4 RID: 7364
		public static Func<AltBand, int> AltBandFunc12 = (AltBand altBand_0) => altBand_0.GetMaxSpeed();

		// Token: 0x04001CC5 RID: 7365
		public static Func<Warhead, string> WarheadNameFunc = (Warhead warhead_0) => warhead_0.Name;

		// Token: 0x04001CC6 RID: 7366
		public static Func<Sensor, int> SensorDBIDFunc = (Sensor sensor_0) => sensor_0.DBID;

		// Token: 0x04001CC8 RID: 7368
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x04001CC9 RID: 7369
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04001CCA RID: 7370
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001CCB RID: 7371
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001CCC RID: 7372
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001CCD RID: 7373
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001CCE RID: 7374
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04001CCF RID: 7375
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001CD0 RID: 7376
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04001CD1 RID: 7377
		[CompilerGenerated]
		private ComboBox comboBox_2;

		// Token: 0x04001CD2 RID: 7378
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001CD3 RID: 7379
		public string strUnitType;

		// Token: 0x04001CD4 RID: 7380
		public int DBID;

		// Token: 0x04001CD5 RID: 7381
		private string string_1;

		// Token: 0x04001CD6 RID: 7382
		private DataTable dataTable_0;

		// Token: 0x04001CD7 RID: 7383
		private bool bool_0;

		// Token: 0x04001CD8 RID: 7384
		private bool bool_1;

		// Token: 0x02000999 RID: 2457
		[CompilerGenerated]
		public sealed class MountDirector
		{
			// Token: 0x06003ED8 RID: 16088 RVA: 0x00020719 File Offset: 0x0001E919
			public MountDirector(DBViewer.MountDirector MountDirector_)
			{
				if (MountDirector_ != null)
				{
					this.mount = MountDirector_.mount;
				}
			}

			// Token: 0x06003ED9 RID: 16089 RVA: 0x00020733 File Offset: 0x0001E933
			internal bool IsDirectorMountedOnMe(Sensor sensor_)
			{
				return this.mount.MountDirectorSet.Contains(sensor_.DBID);
			}

			// Token: 0x04001CE8 RID: 7400
			public Mount mount;
		}

		// Token: 0x0200099A RID: 2458
		[CompilerGenerated]
		public sealed class OnboardSeekerForWeapon
		{
			// Token: 0x06003EDA RID: 16090 RVA: 0x0002074B File Offset: 0x0001E94B
			public OnboardSeekerForWeapon(DBViewer.OnboardSeekerForWeapon OnboardSeekerForWeapon_)
			{
				if (OnboardSeekerForWeapon_ != null)
				{
					this.weapon = OnboardSeekerForWeapon_.weapon;
				}
			}

			// Token: 0x06003EDB RID: 16091 RVA: 0x00020765 File Offset: 0x0001E965
			internal bool IsOnboardSeekerForWeapon(Sensor sensor_)
			{
				return this.weapon.weaponDirectorSet.Contains(sensor_.DBID);
			}

			// Token: 0x04001CE9 RID: 7401
			public Weapon weapon;
		}
	}
}
