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
	// Token: 0x02000A0D RID: 2573
	[DesignerGenerated]
	public sealed partial class ExclusionZonesWindow : CommandForm
	{
		// Token: 0x06004ED2 RID: 20178 RVA: 0x001FB3AC File Offset: 0x001F95AC
		public ExclusionZonesWindow()
		{
			base.FormClosing += new FormClosingEventHandler(this.ExclusionZonesWindow_FormClosing);
			base.Load += new EventHandler(this.ExclusionZonesWindow_Load);
			base.KeyDown += new KeyEventHandler(this.ExclusionZonesWindow_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x001FC288 File Offset: 0x001FA488
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x001FC2A0 File Offset: 0x001FA4A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_16);
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

		// Token: 0x06004ED7 RID: 20183 RVA: 0x001FC304 File Offset: 0x001FA504
		[CompilerGenerated]
		internal  ComboBox vmethod_2()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x001FC31C File Offset: 0x001FA51C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x001FC368 File Offset: 0x001FA568
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x00025167 File Offset: 0x00023367
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_4)
		{
			this.label_0 = label_4;
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x001FC380 File Offset: 0x001FA580
		[CompilerGenerated]
		internal  TextBox vmethod_6()
		{
			return this.textBox_0;
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x00025170 File Offset: 0x00023370
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x001FC398 File Offset: 0x001FA598
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_1;
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x00025179 File Offset: 0x00023379
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_4)
		{
			this.label_1 = label_4;
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x001FC3B0 File Offset: 0x001FA5B0
		[CompilerGenerated]
		internal  Button vmethod_10()
		{
			return this.button_0;
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x001FC3C8 File Offset: 0x001FA5C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06004EE1 RID: 20193 RVA: 0x001FC414 File Offset: 0x001FA614
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_1;
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x001FC42C File Offset: 0x001FA62C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06004EE3 RID: 20195 RVA: 0x001FC478 File Offset: 0x001FA678
		[CompilerGenerated]
		internal  CheckBox vmethod_14()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x001FC490 File Offset: 0x001FA690
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(CheckBox checkBox_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_11);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_0 = checkBox_5;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x001FC4DC File Offset: 0x001FA6DC
		[CompilerGenerated]
		internal  CheckBox vmethod_16()
		{
			return this.checkBox_1;
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x001FC4F4 File Offset: 0x001FA6F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(CheckBox checkBox_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_10);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_1 = checkBox_5;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x001FC540 File Offset: 0x001FA740
		[CompilerGenerated]
		internal  CheckBox vmethod_18()
		{
			return this.checkBox_2;
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x001FC558 File Offset: 0x001FA758
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(CheckBox checkBox_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_9);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.MouseClick -= value;
			}
			this.checkBox_2 = checkBox_5;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.MouseClick += value;
			}
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x001FC5A4 File Offset: 0x001FA7A4
		[CompilerGenerated]
		internal  CheckBox vmethod_20()
		{
			return this.checkBox_3;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x001FC5BC File Offset: 0x001FA7BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(CheckBox checkBox_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Enter -= value;
			}
			this.checkBox_3 = checkBox_5;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Enter += value;
			}
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x001FC608 File Offset: 0x001FA808
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_2;
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00025182 File Offset: 0x00023382
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_4)
		{
			this.label_2 = label_4;
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0002518B File Offset: 0x0002338B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_24(ColorDialog colorDialog_1)
		{
			this.colorDialog_0 = colorDialog_1;
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x001FC620 File Offset: 0x001FA820
		[CompilerGenerated]
		internal  AreaEditor vmethod_25()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x00025194 File Offset: 0x00023394
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_26(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x001FC638 File Offset: 0x001FA838
		[CompilerGenerated]
		internal  Label vmethod_27()
		{
			return this.label_3;
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0002519D File Offset: 0x0002339D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_28(Label label_4)
		{
			this.label_3 = label_4;
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x001FC650 File Offset: 0x001FA850
		[CompilerGenerated]
		internal  Button vmethod_29()
		{
			return this.button_2;
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x001FC668 File Offset: 0x001FA868
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_30(Button button_4)
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

		// Token: 0x06004EF4 RID: 20212 RVA: 0x001FC6B4 File Offset: 0x001FA8B4
		[CompilerGenerated]
		internal  Button vmethod_31()
		{
			return this.button_3;
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x001FC6CC File Offset: 0x001FA8CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_32(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_13);
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

		// Token: 0x06004EF6 RID: 20214 RVA: 0x001FC718 File Offset: 0x001FA918
		[CompilerGenerated]
		internal  CheckBox vmethod_33()
		{
			return this.checkBox_4;
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x001FC730 File Offset: 0x001FA930
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_34(CheckBox checkBox_5)
		{
			EventHandler value = new EventHandler(this.method_15);
			CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_4 = checkBox_5;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x001FC77C File Offset: 0x001FA97C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_35()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x000251A6 File Offset: 0x000233A6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_36(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x001FC794 File Offset: 0x001FA994
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_37()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x000251AF File Offset: 0x000233AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_38(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x001FC7AC File Offset: 0x001FA9AC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_39()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x000251B8 File Offset: 0x000233B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_40(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x001FC7C4 File Offset: 0x001FA9C4
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_41()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x000251C1 File Offset: 0x000233C1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_42(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x001FC7DC File Offset: 0x001FA9DC
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_43()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x000251CA File Offset: 0x000233CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_44(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x001FC7F4 File Offset: 0x001FA9F4
		[CompilerGenerated]
		internal  SaveFileDialog vmethod_45()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x000251D3 File Offset: 0x000233D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_46(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x001FC80C File Offset: 0x001FAA0C
		public ExclusionZone method_1()
		{
			return this.exclusionZone_0;
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x001FC824 File Offset: 0x001FAA24
		public void method_2(ExclusionZone exclusionZone_1)
		{
			this.exclusionZone_0 = exclusionZone_1;
			if (!Information.IsNothing(exclusionZone_1))
			{
				this.vmethod_6().Text = exclusionZone_1.Description;
				Misc.PostureStance markViolatorAs = exclusionZone_1.MarkViolatorAs;
				if (markViolatorAs != Misc.PostureStance.Unfriendly)
				{
					if (markViolatorAs == Misc.PostureStance.Hostile)
					{
						this.vmethod_2().SelectedIndex = 1;
					}
				}
				else
				{
					this.vmethod_2().SelectedIndex = 0;
				}
				this.vmethod_20().Checked = this.exclusionZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Aircraft);
				this.vmethod_18().Checked = this.exclusionZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Ship);
				this.vmethod_16().Checked = this.exclusionZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Submarine);
				this.vmethod_14().Checked = this.exclusionZone_0.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Facility);
				this.vmethod_25().list_0 = this.exclusionZone_0.Area;
				this.vmethod_25().method_0("封锁区");
				this.vmethod_25().method_1();
			}
			bool flag = false;
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					using (List<ExclusionZone>.Enumerator enumerator = side.ExclusionZoneList.GetEnumerator())
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
				this.vmethod_33().Checked = flag;
				Client.b_Completed = true;
			}
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x000251DC File Offset: 0x000233DC
		private void ExclusionZonesWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_2(null);
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x001FCA14 File Offset: 0x001FAC14
		private void method_3()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			dataTable.Columns.Add("MarkViolatorAs", typeof(string));
			dataTable.Columns.Add("IsActive", typeof(bool));
			foreach (ExclusionZone current in Client.GetClientSide().ExclusionZoneList)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["ID"] = current.GetGuid();
				dataRow["Description"] = current.Description;
				dataRow["MarkViolatorAs"] = Misc.GetPostureStanceString(current.MarkViolatorAs);
				dataRow["IsActive"] = current.IsActive;
				dataTable.Rows.Add(dataRow);
			}
			this.vmethod_0().DataSource = dataTable;
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x001FCB44 File Offset: 0x001FAD44
		private void method_4(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_1()))
			{
				int selectedIndex = this.vmethod_2().SelectedIndex;
				if (selectedIndex != 0)
				{
					if (selectedIndex == 1)
					{
						this.method_1().MarkViolatorAs = Misc.PostureStance.Hostile;
					}
				}
				else
				{
					this.method_1().MarkViolatorAs = Misc.PostureStance.Unfriendly;
				}
				this.method_3();
			}
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x00025201 File Offset: 0x00023401
		private void method_5(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_1()))
			{
				this.method_1().Description = this.vmethod_6().Text;
				this.method_3();
			}
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x0002522C File Offset: 0x0002342C
		private void method_6(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_1()))
			{
				Client.GetClientSide().ExclusionZoneList.Remove(this.method_1());
				this.method_2(null);
				this.method_3();
			}
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x001FCB9C File Offset: 0x001FAD9C
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				int num = this.vmethod_0().Rows.IndexOf(this.vmethod_0().SelectedRows[0]);
				if (num != -1)
				{
					this.method_2(Client.GetClientSide().ExclusionZoneList[num]);
				}
			}
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x0002525E File Offset: 0x0002345E
		private void method_8(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x0002525E File Offset: 0x0002345E
		private void method_9(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x0002525E File Offset: 0x0002345E
		private void method_10(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x0002525E File Offset: 0x0002345E
		private void method_11(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x001FCBFC File Offset: 0x001FADFC
		private void method_12()
		{
			if (Information.IsNothing(this.method_1()))
			{
				if (Client.GetClientSide().ExclusionZoneList.Count <= 0)
				{
					return;
				}
				this.method_2(Client.GetClientSide().ExclusionZoneList[0]);
			}
			this.method_1().GetAffectedUnitTypes().Clear();
			if (this.vmethod_20().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Aircraft);
			}
			if (this.vmethod_18().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Ship);
			}
			if (this.vmethod_16().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Submarine);
			}
			if (this.vmethod_14().Checked)
			{
				this.method_1().GetAffectedUnitTypes().Add(GlobalVariables.ActiveUnitType.Facility);
			}
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x001FCCDC File Offset: 0x001FAEDC
		private void ExclusionZonesWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_3();
			if (Client.GetClientSide().ExclusionZoneList.Count > 0 && Information.IsNothing(this.method_1()))
			{
				this.method_2(Client.GetClientSide().ExclusionZoneList[0]);
			}
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void ExclusionZonesWindow_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06004F13 RID: 20243 RVA: 0x001FCD44 File Offset: 0x001FAF44
		private void method_13(object sender, EventArgs e)
		{
			this.vmethod_46(new SaveFileDialog());
			this.vmethod_45().InitialDirectory = GameGeneral.strScenariosDir;
			if (this.vmethod_45().ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileStream fileStream = File.Create(this.vmethod_45().FileName);
					XmlWriterSettings settings = new XmlWriterSettings();
					Stream1 stream = new Stream1();
					using (XmlWriter xmlWriter = XmlWriter.Create(stream, settings))
					{
						xmlWriter.WriteStartElement("ExclusionZone");
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
						xmlWriter.WriteElementString("AffectedUnitTypes", string.Join("_", this.method_1().GetAffectedUnitTypes().Select(ExclusionZonesWindow.ActiveUnitTypeFunc)));
						xmlWriter.WriteEndElement();
					}
					fileStream.Write(stream.ToArray(), 0, (int)stream.Position);
					fileStream.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101277", "");
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

		// Token: 0x06004F14 RID: 20244 RVA: 0x001FCEF0 File Offset: 0x001FB0F0
		private void method_14(object sender, EventArgs e)
		{
			checked
			{
				if (Information.IsNothing(this.method_1()))
				{
					Interaction.MsgBox("Please select a No Navigation Zone.", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					this.vmethod_44(new OpenFileDialog());
					this.vmethod_43().InitialDirectory = GameGeneral.strScenariosDir;
					if (this.vmethod_43().ShowDialog() == DialogResult.OK)
					{
						FileStream fileStream = new FileStream(this.vmethod_43().FileName, FileMode.Open, FileAccess.Read);
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
									Interaction.MsgBox("文件格式不对,读取失败!", MsgBoxStyle.OkOnly, null);
									ProjectData.ClearProjectError();
								}
							}
							ExclusionZone exclusionZone = this.method_1();
							bool flag = true;
							XmlNode xmlNode = xmlDocument.SelectSingleNode("/ExclusionZone");
							if (Information.IsNothing(xmlNode))
							{
								xmlNode = xmlDocument.SelectSingleNode("/NoNavZone");
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
													exclusionZone.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>());
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
															exclusionZone.GetAffectedUnitTypes().Add(unchecked((GlobalVariables.ActiveUnitType)num));
														}
													}
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
														exclusionZone.Area.Add(referencePoint);
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
										exclusionZone.Description = xmlNode2.InnerText;
									}
								}
								finally
								{
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
								if (Information.IsNothing(exclusionZone.GetAffectedUnitTypes()))
								{
									exclusionZone.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>
									{
										GlobalVariables.ActiveUnitType.Aircraft,
										GlobalVariables.ActiveUnitType.Ship,
										GlobalVariables.ActiveUnitType.Submarine,
										GlobalVariables.ActiveUnitType.Facility
									});
								}
								this.vmethod_25().method_1();
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
								using (List<ExclusionZone>.Enumerator enumerator3 = side.ExclusionZoneList.GetEnumerator())
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
							ex2.Data.Add("Error at 101276", "");
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

		// Token: 0x06004F15 RID: 20245 RVA: 0x001FD378 File Offset: 0x001FB578
		private void method_15(object sender, EventArgs e)
		{
			bool flag = false;
			flag = this.vmethod_33().Checked;
			bool flag2 = false;
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					using (List<ExclusionZone>.Enumerator enumerator = side.ExclusionZoneList.GetEnumerator())
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

		// Token: 0x06004F16 RID: 20246 RVA: 0x001FD4A8 File Offset: 0x001FB6A8
		private void method_16(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && Operators.CompareString(this.vmethod_0().Columns[e.ColumnIndex].Name, "Active", false) == 0)
			{
				DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_0()[e.ColumnIndex, e.RowIndex];
				ExclusionZone exclusionZone = null;
				string right = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				foreach (ExclusionZone current in Client.GetClientSide().ExclusionZoneList)
				{
					if (Operators.CompareString(current.GetGuid(), right, false) == 0)
					{
						exclusionZone = current;
						break;
					}
				}
				if (!Information.IsNothing(exclusionZone))
				{
					if (exclusionZone.IsActive)
					{
						dataGridViewCheckBoxCell.Value = false;
						exclusionZone.IsActive = false;
					}
					else
					{
						dataGridViewCheckBoxCell.Value = true;
						exclusionZone.IsActive = true;
					}
					Client.b_Completed = true;
					this.method_3();
				}
			}
		}

		// Token: 0x04002535 RID: 9525
		public static Func<GlobalVariables.ActiveUnitType, string> ActiveUnitTypeFunc = delegate(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			int num = (int)activeUnitType_0;
			return num.ToString();
		};

		// Token: 0x04002537 RID: 9527
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002538 RID: 9528
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04002539 RID: 9529
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400253A RID: 9530
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x0400253B RID: 9531
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400253C RID: 9532
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400253D RID: 9533
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x0400253E RID: 9534
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x0400253F RID: 9535
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002540 RID: 9536
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04002541 RID: 9537
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04002542 RID: 9538
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002543 RID: 9539
		[CompilerGenerated]
		private ColorDialog colorDialog_0;

		// Token: 0x04002544 RID: 9540
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04002545 RID: 9541
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002546 RID: 9542
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04002547 RID: 9543
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04002548 RID: 9544
		[CompilerGenerated]
		private CheckBox checkBox_4;

		// Token: 0x04002549 RID: 9545
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400254A RID: 9546
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400254B RID: 9547
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x0400254C RID: 9548
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x0400254D RID: 9549
		private ExclusionZone exclusionZone_0;

		// Token: 0x0400254E RID: 9550
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x0400254F RID: 9551
		[CompilerGenerated]
		private SaveFileDialog saveFileDialog_0;
	}
}
