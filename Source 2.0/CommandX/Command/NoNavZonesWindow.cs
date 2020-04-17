using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns31;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000A11 RID: 2577
	[DesignerGenerated]
	public sealed partial class NoNavZonesWindow : CommandForm
	{
		// Token: 0x06004F49 RID: 20297 RVA: 0x001FE8A8 File Offset: 0x001FCAA8
		public NoNavZonesWindow()
		{
			base.FormClosing += new FormClosingEventHandler(this.NoNavZonesWindow_FormClosing);
			base.Load += new EventHandler(this.NoNavZonesWindow_Load);
			base.KeyDown += new KeyEventHandler(this.NoNavZonesWindow_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x001FF648 File Offset: 0x001FD848
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x001FF660 File Offset: 0x001FD860
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_17);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged -= value;
				dataGridView.CellClick -= value2;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged += value;
				dataGridView.CellClick += value2;
			}
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x001FF6C4 File Offset: 0x001FD8C4
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x0002538E File Offset: 0x0002358E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x001FF6DC File Offset: 0x001FD8DC
		[CompilerGenerated]
		internal  AreaEditor vmethod_4()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x00025397 File Offset: 0x00023597
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x001FF6F4 File Offset: 0x001FD8F4
		[CompilerGenerated]
		internal  CheckBox vmethod_6()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x001FF70C File Offset: 0x001FD90C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(CheckBox checkBox_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_11);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_0 = checkBox_6;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x001FF758 File Offset: 0x001FD958
		[CompilerGenerated]
		internal  CheckBox vmethod_8()
		{
			return this.checkBox_1;
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x001FF770 File Offset: 0x001FD970
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(CheckBox checkBox_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_13);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_1 = checkBox_6;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x001FF7BC File Offset: 0x001FD9BC
		[CompilerGenerated]
		internal  CheckBox vmethod_10()
		{
			return this.checkBox_2;
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x001FF7D4 File Offset: 0x001FD9D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_12);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_2 = checkBox_6;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x001FF820 File Offset: 0x001FDA20
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_1;
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x000253A0 File Offset: 0x000235A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x001FF838 File Offset: 0x001FDA38
		[CompilerGenerated]
		internal  CheckBox vmethod_14()
		{
			return this.checkBox_3;
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x001FF850 File Offset: 0x001FDA50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(CheckBox checkBox_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_10);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_3 = checkBox_6;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x001FF89C File Offset: 0x001FDA9C
		[CompilerGenerated]
		internal  TextBox vmethod_16()
		{
			return this.textBox_0;
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x000253A9 File Offset: 0x000235A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x001FF8B4 File Offset: 0x001FDAB4
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x000253B2 File Offset: 0x000235B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x001FF8CC File Offset: 0x001FDACC
		[CompilerGenerated]
		internal  Button vmethod_20()
		{
			return this.button_0;
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x001FF8E4 File Offset: 0x001FDAE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_4;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x001FF930 File Offset: 0x001FDB30
		[CompilerGenerated]
		internal  Button vmethod_22()
		{
			return this.button_1;
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x001FF948 File Offset: 0x001FDB48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_6);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_4;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x001FF994 File Offset: 0x001FDB94
		[CompilerGenerated]
		internal  CheckBox vmethod_24()
		{
			return this.checkBox_4;
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x001FF9AC File Offset: 0x001FDBAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(CheckBox checkBox_6)
		{
			EventHandler value = new EventHandler(this.method_9);
			CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_4 = checkBox_6;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x001FF9F8 File Offset: 0x001FDBF8
		[CompilerGenerated]
		internal  Button vmethod_26()
		{
			return this.button_2;
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x001FFA10 File Offset: 0x001FDC10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_14);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_4;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x001FFA5C File Offset: 0x001FDC5C
		[CompilerGenerated]
		internal  Button vmethod_28()
		{
			return this.button_3;
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x001FFA74 File Offset: 0x001FDC74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_15);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_4;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x001FFAC0 File Offset: 0x001FDCC0
		[CompilerGenerated]
		internal  CheckBox vmethod_30()
		{
			return this.checkBox_5;
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x001FFAD8 File Offset: 0x001FDCD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(CheckBox checkBox_6)
		{
			EventHandler value = new EventHandler(this.method_16);
			CheckBox checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_5 = checkBox_6;
			checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x001FFB24 File Offset: 0x001FDD24
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x000253BB File Offset: 0x000235BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x001FFB3C File Offset: 0x001FDD3C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x000253C4 File Offset: 0x000235C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x001FFB54 File Offset: 0x001FDD54
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_36()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x000253CD File Offset: 0x000235CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x001FFB6C File Offset: 0x001FDD6C
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_38()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x000253D6 File Offset: 0x000235D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x001FFB84 File Offset: 0x001FDD84
		[CompilerGenerated]
		internal  SaveFileDialog vmethod_40()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x000253DF File Offset: 0x000235DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x001FFB9C File Offset: 0x001FDD9C
		public NoNavZone method_1()
		{
			return this.noNavZone_0;
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x001FFBB4 File Offset: 0x001FDDB4
		public void method_2(NoNavZone noNavZone_1)
		{
			this.noNavZone_0 = noNavZone_1;
			if (!Information.IsNothing(noNavZone_1))
			{
				this.vmethod_16().Text = noNavZone_1.Description;
				this.vmethod_14().Checked = this.noNavZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Aircraft);
				this.vmethod_10().Checked = this.noNavZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Ship);
				this.vmethod_8().Checked = this.noNavZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Submarine);
				this.vmethod_6().Checked = this.noNavZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Facility);
				this.vmethod_24().Checked = this.noNavZone_0.IsLocked;
				this.vmethod_4().list_0 = this.noNavZone_0.Area;
				this.vmethod_4().method_0("禁航区");
				this.vmethod_4().method_1();
				this.method_3();
			}
			bool flag = false;
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					using (List<NoNavZone>.Enumerator enumerator = side.NoNavZoneList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == this.method_1())
							{
								foreach (ReferencePoint current in this.method_1().Area)
								{
									if (side.GetReferencePoints().Contains(current))
									{
										flag = true;
										break;
									}
								}
								if (flag)
								{
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
				this.vmethod_30().Checked = flag;
				Client.b_Completed = true;
			}
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x000253E8 File Offset: 0x000235E8
		private void NoNavZonesWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_2(null);
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x001FFD8C File Offset: 0x001FDF8C
		private void method_3()
		{
			if (!Information.IsNothing(this.method_1()) && Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_24().Visible = this.method_1().IsLocked;
				this.vmethod_24().Enabled = false;
				this.vmethod_16().Enabled = !this.method_1().IsLocked;
				this.vmethod_14().Enabled = !this.method_1().IsLocked;
				this.vmethod_10().Enabled = !this.method_1().IsLocked;
				this.vmethod_8().Enabled = !this.method_1().IsLocked;
				this.vmethod_6().Enabled = !this.method_1().IsLocked;
				this.vmethod_24().Checked = this.method_1().IsLocked;
				this.vmethod_4().Enabled = !this.method_1().IsLocked;
				this.vmethod_20().Enabled = !this.method_1().IsLocked;
				this.vmethod_22().Enabled = !this.method_1().IsLocked;
			}
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x001FFEBC File Offset: 0x001FE0BC
		private void method_4()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			dataTable.Columns.Add("IsActive", typeof(bool));
			foreach (NoNavZone current in Client.GetClientSide().NoNavZoneList)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["ID"] = current.GetGuid();
				dataRow["Description"] = current.Description;
				dataRow["IsActive"] = current.IsActive;
				dataTable.Rows.Add(dataRow);
			}
			this.vmethod_0().DataSource = dataTable;
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0002540D File Offset: 0x0002360D
		private void method_5(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_1()))
			{
				this.method_1().Description = this.vmethod_16().Text;
				this.method_4();
			}
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00025438 File Offset: 0x00023638
		private void method_6(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_1()))
			{
				Client.GetClientSide().NoNavZoneList.Remove(this.method_1());
				this.method_2(null);
				this.method_4();
			}
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x001FFFBC File Offset: 0x001FE1BC
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				int num = this.vmethod_0().Rows.IndexOf(this.vmethod_0().SelectedRows[0]);
				if (num != -1)
				{
					this.method_2(Client.GetClientSide().NoNavZoneList[num]);
				}
			}
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x0020001C File Offset: 0x001FE21C
		private void method_8()
		{
			if (Information.IsNothing(this.method_1()))
			{
				if (Client.GetClientSide().NoNavZoneList.Count <= 0)
				{
					return;
				}
				this.method_2(Client.GetClientSide().NoNavZoneList[0]);
			}
			this.method_1().GetAffectedUnitTypes().Clear();
			if (this.vmethod_14().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Aircraft);
			}
			if (this.vmethod_10().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Ship);
			}
			if (this.vmethod_8().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Submarine);
			}
			if (this.vmethod_6().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Facility);
			}
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x002000FC File Offset: 0x001FE2FC
		private void NoNavZonesWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_4();
			if (Client.GetClientSide().NoNavZoneList.Count > 0 && Information.IsNothing(this.method_1()))
			{
				this.method_2(Client.GetClientSide().NoNavZoneList[0]);
			}
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x0002546A File Offset: 0x0002366A
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_1()))
			{
				this.method_1().IsLocked = this.vmethod_24().Checked;
			}
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x0002548F File Offset: 0x0002368F
		private void method_10(object sender, MouseEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x0002548F File Offset: 0x0002368F
		private void method_11(object sender, MouseEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x0002548F File Offset: 0x0002368F
		private void method_12(object sender, MouseEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x0002548F File Offset: 0x0002368F
		private void method_13(object sender, MouseEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void NoNavZonesWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x00200164 File Offset: 0x001FE364
		private void method_14(object sender, EventArgs e)
		{
			this.vmethod_41(new SaveFileDialog());
			this.vmethod_40().InitialDirectory = GameGeneral.strScenariosDir;
			if (this.vmethod_40().ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileStream fileStream = File.Create(this.vmethod_40().FileName);
					XmlWriterSettings settings = new XmlWriterSettings();
					Stream1 stream = new Stream1();
					using (XmlWriter xmlWriter = XmlWriter.Create(stream, settings))
					{
						xmlWriter.WriteStartElement("NoNavZone");
						xmlWriter.WriteElementString("Description", this.method_1().Description);
						xmlWriter.WriteStartElement("Area");
						foreach (ReferencePoint current in this.method_1().Area)
						{
							XmlWriter xmlWriter2 = xmlWriter;
							HashSet<string> hashSet = null;
							current.Save(ref xmlWriter2, ref hashSet);
							xmlWriter.Flush();
						}
						xmlWriter.WriteEndElement();
						xmlWriter.WriteElementString("AffectedUnitTypes", string.Join("_", this.method_1().GetAffectedUnitTypes().Select(NoNavZonesWindow.ActiveUnitTypeFunc)));
						xmlWriter.WriteElementString("IsLocked", this.method_1().IsLocked.ToString());
						xmlWriter.WriteEndElement();
					}
					fileStream.Write(stream.ToArray(), 0, (int)stream.Position);
					fileStream.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101279", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				Client.b_Completed = true;
			}
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00200350 File Offset: 0x001FE550
		private void method_15(object sender, EventArgs e)
		{
			checked
			{
				if (Information.IsNothing(this.method_1()))
				{
					Interaction.MsgBox("Please select a No Navigation Zone.", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					this.vmethod_39(new OpenFileDialog());
					this.vmethod_38().InitialDirectory = GameGeneral.strScenariosDir;
					if (this.vmethod_38().ShowDialog() == DialogResult.OK)
					{
						FileStream fileStream = new FileStream(this.vmethod_38().FileName, FileMode.Open, FileAccess.Read);
						XmlDocument xmlDocument = new XmlDocument();
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
									Interaction.MsgBox("File is improperly formatted, read failed!", MsgBoxStyle.OkOnly, null);
									ProjectData.ClearProjectError();
								}
							}
							NoNavZone noNavZone = this.method_1();
							bool flag = true;
							XmlNode xmlNode = xmlDocument.SelectSingleNode("/NoNavZone");
							if (Information.IsNothing(xmlNode))
							{
								xmlNode = xmlDocument.SelectSingleNode("/ExclusionZone");
								flag = false;
							}
							if (xmlNode != null)
							{
								IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator.Current;
										string name = xmlNode2.Name;
										if (Operators.CompareString(name, "Description", false) != 0)
										{
											if (Operators.CompareString(name, "Area", false) != 0)
											{
												if (Operators.CompareString(name, "AffectedUnitTypes", false) == 0)
												{
													noNavZone.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>());
													string[] array = xmlNode2.InnerText.Split(new char[]
													{
														'_'
													});
													for (int i = 0; i < array.Length; i++)
													{
														string text = array[i];
														if (Versioned.IsNumeric(text))
														{
															int num = Conversions.ToInteger(text);
															noNavZone.GetAffectedUnitTypes().Add(unchecked((GlobalVariables.ActiveUnitType)num));
														}
													}
													continue;
												}
												if (Operators.CompareString(name, "IsLocked", false) == 0)
												{
													noNavZone.IsLocked = Conversions.ToBoolean(xmlNode2.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator2.MoveNext())
													{
														XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
														Dictionary<string, Subject> dictionary = null;
														ReferencePoint referencePoint = ReferencePoint.Load(ref xmlNode3, ref dictionary);
														if (!flag)
														{
															referencePoint.ClearGuid();
														}
														noNavZone.Area.Add(referencePoint);
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
										noNavZone.Description = xmlNode2.InnerText;
									}
								}
								finally
								{
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
								if (Information.IsNothing(noNavZone.GetAffectedUnitTypes()))
								{
									noNavZone.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>
									{
										GlobalVariables.ActiveUnitType.Aircraft,
										GlobalVariables.ActiveUnitType.Ship,
										GlobalVariables.ActiveUnitType.Submarine,
										GlobalVariables.ActiveUnitType.Facility
									});
								}
								this.vmethod_4().method_1();
							}
							else
							{
								Interaction.MsgBox("No XML data found.", MsgBoxStyle.OkOnly, null);
							}
							bool flag2 = false;
							Side[] sides = Client.GetClientScenario().GetSides();
							for (int j = 0; j < sides.Length; j++)
							{
								Side side = sides[j];
								using (List<NoNavZone>.Enumerator enumerator3 = side.NoNavZoneList.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										if (enumerator3.Current == this.method_1())
										{
											foreach (ReferencePoint current in this.method_1().Area)
											{
												if (!side.GetReferencePoints().Contains(current))
												{
													side.GetReferencePoints().Add(current);
												}
											}
											flag2 = true;
											break;
										}
									}
								}
								if (flag2)
								{
									break;
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 101278", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						Client.b_Completed = true;
					}
				}
			}
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x00200808 File Offset: 0x001FEA08
		private void method_16(object sender, EventArgs e)
		{
			bool flag = false;
			flag = this.vmethod_30().Checked;
			bool flag2 = false;
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					using (List<NoNavZone>.Enumerator enumerator = side.NoNavZoneList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == this.method_1())
							{
								foreach (ReferencePoint current in this.method_1().Area)
								{
									if (flag)
									{
										if (!side.GetReferencePoints().Contains(current))
										{
											side.GetReferencePoints().Add(current);
										}
									}
									else if (side.GetReferencePoints().Contains(current))
									{
										side.GetReferencePoints().Remove(current);
									}
								}
								flag2 = true;
								break;
							}
						}
					}
					if (flag2)
					{
						break;
					}
				}
				Client.b_Completed = true;
			}
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x00200938 File Offset: 0x001FEB38
		private void method_17(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && Operators.CompareString(this.vmethod_0().Columns[e.ColumnIndex].Name, "Active", false) == 0)
			{
				DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_0()[e.ColumnIndex, e.RowIndex];
				NoNavZone noNavZone = null;
				string right = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				foreach (NoNavZone current in Client.GetClientSide().NoNavZoneList)
				{
					if (Operators.CompareString(current.GetGuid(), right, false) == 0)
					{
						noNavZone = current;
						break;
					}
				}
				if (!Information.IsNothing(noNavZone))
				{
					if (noNavZone.IsActive)
					{
						dataGridViewCheckBoxCell.Value = false;
						noNavZone.IsActive = false;
					}
					else
					{
						dataGridViewCheckBoxCell.Value = true;
						noNavZone.IsActive = true;
					}
					Client.b_Completed = true;
					this.method_4();
				}
			}
		}

		// Token: 0x04002562 RID: 9570
		public static Func<GlobalVariables.ActiveUnitType, string> ActiveUnitTypeFunc = delegate(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			int num = (int)activeUnitType_0;
			return num.ToString();
		};

		// Token: 0x04002564 RID: 9572
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002565 RID: 9573
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002566 RID: 9574
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04002567 RID: 9575
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002568 RID: 9576
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002569 RID: 9577
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x0400256A RID: 9578
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400256B RID: 9579
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x0400256C RID: 9580
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x0400256D RID: 9581
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x0400256E RID: 9582
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400256F RID: 9583
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002570 RID: 9584
		[CompilerGenerated]
		private CheckBox checkBox_4;

		// Token: 0x04002571 RID: 9585
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04002572 RID: 9586
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04002573 RID: 9587
		[CompilerGenerated]
		private CheckBox checkBox_5;

		// Token: 0x04002574 RID: 9588
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04002575 RID: 9589
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04002576 RID: 9590
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04002577 RID: 9591
		private NoNavZone noNavZone_0;

		// Token: 0x04002578 RID: 9592
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04002579 RID: 9593
		[CompilerGenerated]
		private SaveFileDialog saveFileDialog_0;
	}
}
