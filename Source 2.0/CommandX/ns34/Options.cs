using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns33;
using ns35;
using ns4;

namespace ns34
{
	// Token: 0x020009E6 RID: 2534
	[DesignerGenerated]
	public sealed partial class Options : CommandForm
	{
		// Token: 0x06004B00 RID: 19200 RVA: 0x001D41E4 File Offset: 0x001D23E4
		public Options()
		{
			base.Load += new EventHandler(this.Options_Load);
			base.KeyDown += new KeyEventHandler(this.Options_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Options_FormClosing);
			this.bool_0 = false;
			this.bool_1 = false;
			this.InitializeComponent();
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x001D6CC0 File Offset: 0x001D4EC0
		[CompilerGenerated]
		internal  TabPage vmethod_0()
		{
			return this.tabPage_0;
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00023EAB File Offset: 0x000220AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TabPage tabPage_5)
		{
			this.tabPage_0 = tabPage_5;
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x001D6CD8 File Offset: 0x001D4ED8
		[CompilerGenerated]
		internal  DataGridView vmethod_2()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x001D6CF0 File Offset: 0x001D4EF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridView dataGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_51);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value;
			}
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x001D6D3C File Offset: 0x001D4F3C
		[CompilerGenerated]
		internal  TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00023EB4 File Offset: 0x000220B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_5)
		{
			this.tabPage_1 = tabPage_5;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x001D6D54 File Offset: 0x001D4F54
		[CompilerGenerated]
		internal  CheckBox GetCB_RunCoreMultithreaded()
		{
			return this.CB_RunCoreMultithreaded;
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x001D6D6C File Offset: 0x001D4F6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_RunCoreMultithreaded(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.CB_RunCoreMultithreaded_Click);
			CheckBox cB_RunCoreMultithreaded = this.CB_RunCoreMultithreaded;
			if (cB_RunCoreMultithreaded != null)
			{
				cB_RunCoreMultithreaded.Click -= value;
			}
			this.CB_RunCoreMultithreaded = checkBox_33;
			cB_RunCoreMultithreaded = this.CB_RunCoreMultithreaded;
			if (cB_RunCoreMultithreaded != null)
			{
				cB_RunCoreMultithreaded.Click += value;
			}
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x001D6DB8 File Offset: 0x001D4FB8
		[CompilerGenerated]
		internal  CheckBox GetCB_UseAutosave()
		{
			return this.checkBox_1;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x001D6DD0 File Offset: 0x001D4FD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_27);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_33;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x001D6E1C File Offset: 0x001D501C
		[CompilerGenerated]
		internal  TabControl vmethod_10()
		{
			return this.tabControl_0;
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00023EBD File Offset: 0x000220BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabControl tabControl_1)
		{
			this.tabControl_0 = tabControl_1;
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x001D6E34 File Offset: 0x001D5034
		[CompilerGenerated]
		internal  CheckBox GetCB_MessageLogInWindow()
		{
			return this.checkBox_2;
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x001D6E4C File Offset: 0x001D504C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_35);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_2 = checkBox_33;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x001D6E98 File Offset: 0x001D5098
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00023EC6 File Offset: 0x000220C6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x001D6EB0 File Offset: 0x001D50B0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00023ECF File Offset: 0x000220CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x001D6EC8 File Offset: 0x001D50C8
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_18()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00023ED8 File Offset: 0x000220D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x001D6EE0 File Offset: 0x001D50E0
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_20()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x00023EE1 File Offset: 0x000220E1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x001D6EF8 File Offset: 0x001D50F8
		[CompilerGenerated]
		internal  CheckBox GetCB_AltitudeInFeet()
		{
			return this.checkBox_3;
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x001D6F10 File Offset: 0x001D5110
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_36);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_3 = checkBox_33;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x001D6F5C File Offset: 0x001D515C
		[CompilerGenerated]
		internal  CheckBox GetCB_ZoomOnCursor()
		{
			return this.checkBox_4;
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x001D6F74 File Offset: 0x001D5174
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_37);
			CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_4 = checkBox_33;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x001D6FC0 File Offset: 0x001D51C0
		[CompilerGenerated]
		internal  CheckBox GetCB_HighFidelityMode()
		{
			return this.checkBox_5;
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x001D6FD8 File Offset: 0x001D51D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_24);
			CheckBox checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_5 = checkBox_33;
			checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x001D7024 File Offset: 0x001D5224
		[CompilerGenerated]
		internal  TabPage vmethod_28()
		{
			return this.tabPage_2;
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00023EEA File Offset: 0x000220EA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TabPage tabPage_5)
		{
			this.tabPage_2 = tabPage_5;
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x001D703C File Offset: 0x001D523C
		[CompilerGenerated]
		internal  CheckBox vmethod_30()
		{
			return this.checkBox_6;
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x001D7054 File Offset: 0x001D5254
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_47);
			CheckBox checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_6 = checkBox_33;
			checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x001D70A0 File Offset: 0x001D52A0
		[CompilerGenerated]
		internal  CheckBox vmethod_32()
		{
			return this.checkBox_7;
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x001D70B8 File Offset: 0x001D52B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_48);
			CheckBox checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_7 = checkBox_33;
			checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x001D7104 File Offset: 0x001D5304
		[CompilerGenerated]
		internal  Button vmethod_34()
		{
			return this.button_0;
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x001D711C File Offset: 0x001D531C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Button button_1)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_1;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x001D7168 File Offset: 0x001D5368
		[CompilerGenerated]
		internal  CheckBox vmethod_36()
		{
			return this.checkBox_8;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x001D7180 File Offset: 0x001D5380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_25);
			CheckBox checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_8 = checkBox_33;
			checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x001D71CC File Offset: 0x001D53CC
		[CompilerGenerated]
		internal  TabPage vmethod_38()
		{
			return this.tabPage_3;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00023EF3 File Offset: 0x000220F3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(TabPage tabPage_5)
		{
			this.tabPage_3 = tabPage_5;
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x001D71E4 File Offset: 0x001D53E4
		[CompilerGenerated]
		internal  ComboBox vmethod_40()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x001D71FC File Offset: 0x001D53FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_41);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_9;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x001D7248 File Offset: 0x001D5448
		[CompilerGenerated]
		internal  ComboBox vmethod_42()
		{
			return this.comboBox_1;
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x001D7260 File Offset: 0x001D5460
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_40);
			ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_9;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x001D72AC File Offset: 0x001D54AC
		[CompilerGenerated]
		internal  Label vmethod_44()
		{
			return this.label_0;
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x00023EFC File Offset: 0x000220FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Label label_12)
		{
			this.label_0 = label_12;
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x001D72C4 File Offset: 0x001D54C4
		[CompilerGenerated]
		internal  ComboBox vmethod_46()
		{
			return this.comboBox_2;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x001D72DC File Offset: 0x001D54DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_39);
			ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_9;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x001D7328 File Offset: 0x001D5528
		[CompilerGenerated]
		internal  Label vmethod_48()
		{
			return this.label_1;
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00023F05 File Offset: 0x00022105
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Label label_12)
		{
			this.label_1 = label_12;
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x001D7340 File Offset: 0x001D5540
		[CompilerGenerated]
		internal  ComboBox GetCB_MapSymbols()
		{
			return this.CB_MapSymbols;
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x001D7358 File Offset: 0x001D5558
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_MapSymbols(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.CB_MapSymbols_SelectionChangeCommitted);
			ComboBox cB_MapSymbols = this.CB_MapSymbols;
			if (cB_MapSymbols != null)
			{
				cB_MapSymbols.SelectionChangeCommitted -= value;
			}
			this.CB_MapSymbols = comboBox_9;
			cB_MapSymbols = this.CB_MapSymbols;
			if (cB_MapSymbols != null)
			{
				cB_MapSymbols.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x001D73A4 File Offset: 0x001D55A4
		[CompilerGenerated]
		internal  Label vmethod_52()
		{
			return this.label_2;
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00023F0E File Offset: 0x0002210E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Label label_12)
		{
			this.label_2 = label_12;
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x001D73BC File Offset: 0x001D55BC
		[CompilerGenerated]
		internal  ComboBox vmethod_54()
		{
			return this.comboBox_4;
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x001D73D4 File Offset: 0x001D55D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_43);
			ComboBox comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_4 = comboBox_9;
			comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x001D7420 File Offset: 0x001D5620
		[CompilerGenerated]
		internal  Label vmethod_56()
		{
			return this.label_3;
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00023F17 File Offset: 0x00022117
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Label label_12)
		{
			this.label_3 = label_12;
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x001D7438 File Offset: 0x001D5638
		[CompilerGenerated]
		internal  ComboBox GetCP_ShowGhostedGroupMembers()
		{
			return this.comboBox_5;
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x001D7450 File Offset: 0x001D5650
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_30);
			ComboBox comboBox = this.comboBox_5;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_5 = comboBox_9;
			comboBox = this.comboBox_5;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x001D749C File Offset: 0x001D569C
		[CompilerGenerated]
		internal  Label vmethod_60()
		{
			return this.label_4;
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x00023F20 File Offset: 0x00022120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Label label_12)
		{
			this.label_4 = label_12;
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x001D74B4 File Offset: 0x001D56B4
		[CompilerGenerated]
		internal  Label vmethod_62()
		{
			return this.label_5;
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x00023F29 File Offset: 0x00022129
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Label label_12)
		{
			this.label_5 = label_12;
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x001D74CC File Offset: 0x001D56CC
		[CompilerGenerated]
		internal  CheckBox vmethod_64()
		{
			return this.checkBox_9;
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x001D74E4 File Offset: 0x001D56E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_38);
			CheckBox checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_9 = checkBox_33;
			checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x001D7530 File Offset: 0x001D5730
		[CompilerGenerated]
		internal  CheckBox GetCB_PlacenameVisibility()
		{
			return this.CB_PlacenameVisibility;
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x001D7548 File Offset: 0x001D5748
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_PlacenameVisibility(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.CB_PlacenameVisibility_Click);
			CheckBox cB_PlacenameVisibility = this.CB_PlacenameVisibility;
			if (cB_PlacenameVisibility != null)
			{
				cB_PlacenameVisibility.Click -= value;
			}
			this.CB_PlacenameVisibility = checkBox_33;
			cB_PlacenameVisibility = this.CB_PlacenameVisibility;
			if (cB_PlacenameVisibility != null)
			{
				cB_PlacenameVisibility.Click += value;
			}
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x001D7594 File Offset: 0x001D5794
		[CompilerGenerated]
		internal  CheckBox GetCB_PlacenameShowInChinese()
		{
			return this.CB_PlacenameShowInChinese;
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x001D75AC File Offset: 0x001D57AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_PlacenameShowInChinese(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.CB_PlacenameShowInChinese_Click);
			CheckBox cB_PlacenameShowInChinese = this.CB_PlacenameShowInChinese;
			if (cB_PlacenameShowInChinese != null)
			{
				cB_PlacenameShowInChinese.Click -= value;
			}
			this.CB_PlacenameShowInChinese = checkBox_33;
			cB_PlacenameShowInChinese = this.CB_PlacenameShowInChinese;
			if (cB_PlacenameShowInChinese != null)
			{
				cB_PlacenameShowInChinese.Click += value;
			}
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x001D75F8 File Offset: 0x001D57F8
		[CompilerGenerated]
		internal  CheckBox vmethod_68()
		{
			return this.checkBox_11;
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x001D7610 File Offset: 0x001D5810
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_26);
			CheckBox checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_11 = checkBox_33;
			checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x001D765C File Offset: 0x001D585C
		[CompilerGenerated]
		internal  CheckBox GetCB_MessageLogCanvas()
		{
			return this.checkBox_12;
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x001D7674 File Offset: 0x001D5874
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_29);
			CheckBox checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_12 = checkBox_33;
			checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x001D76C0 File Offset: 0x001D58C0
		[CompilerGenerated]
		internal  TextBox vmethod_72()
		{
			return this.textBox_0;
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x001D76D8 File Offset: 0x001D58D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(TextBox textBox_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			EventHandler value2 = new EventHandler(this.method_6);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_0 = textBox_2;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x001D773C File Offset: 0x001D593C
		[CompilerGenerated]
		internal  TextBox vmethod_74()
		{
			return this.textBox_1;
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x001D7754 File Offset: 0x001D5954
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(TextBox textBox_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_4);
			TextBox textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_1 = textBox_2;
			textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x001D77B8 File Offset: 0x001D59B8
		[CompilerGenerated]
		internal  Label vmethod_76()
		{
			return this.label_6;
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00023F32 File Offset: 0x00022132
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Label label_12)
		{
			this.label_6 = label_12;
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x001D77D0 File Offset: 0x001D59D0
		[CompilerGenerated]
		internal  Label vmethod_78()
		{
			return this.label_7;
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00023F3B File Offset: 0x0002213B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Label label_12)
		{
			this.label_7 = label_12;
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x001D77E8 File Offset: 0x001D59E8
		[CompilerGenerated]
		internal  CheckBox vmethod_80()
		{
			return this.checkBox_13;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x001D7800 File Offset: 0x001D5A00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_44);
			CheckBox checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_13 = checkBox_33;
			checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x001D784C File Offset: 0x001D5A4C
		[CompilerGenerated]
		internal  TabPage vmethod_82()
		{
			return this.tabPage_4;
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00023F44 File Offset: 0x00022144
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(TabPage tabPage_5)
		{
			this.tabPage_4 = tabPage_5;
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x001D7864 File Offset: 0x001D5A64
		[CompilerGenerated]
		internal  GroupBox vmethod_84()
		{
			return this.groupBox_0;
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00023F4D File Offset: 0x0002214D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(GroupBox groupBox_3)
		{
			this.groupBox_0 = groupBox_3;
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x001D787C File Offset: 0x001D5A7C
		[CompilerGenerated]
		internal  CheckBox vmethod_86()
		{
			return this.checkBox_14;
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x001D7894 File Offset: 0x001D5A94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_22);
			CheckBox checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_14 = checkBox_33;
			checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x001D78E0 File Offset: 0x001D5AE0
		[CompilerGenerated]
		internal  GroupBox vmethod_88()
		{
			return this.groupBox_1;
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x00023F56 File Offset: 0x00022156
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(GroupBox groupBox_3)
		{
			this.groupBox_1 = groupBox_3;
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x001D78F8 File Offset: 0x001D5AF8
		[CompilerGenerated]
		internal  CheckBox vmethod_90()
		{
			return this.checkBox_15;
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x001D7910 File Offset: 0x001D5B10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_19);
			CheckBox checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_15 = checkBox_33;
			checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x001D795C File Offset: 0x001D5B5C
		[CompilerGenerated]
		internal  CheckBox vmethod_92()
		{
			return this.checkBox_16;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x001D7974 File Offset: 0x001D5B74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_20);
			CheckBox checkBox = this.checkBox_16;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_16 = checkBox_33;
			checkBox = this.checkBox_16;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x001D79C0 File Offset: 0x001D5BC0
		[CompilerGenerated]
		internal  CheckBox vmethod_94()
		{
			return this.checkBox_17;
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x001D79D8 File Offset: 0x001D5BD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_21);
			CheckBox checkBox = this.checkBox_17;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_17 = checkBox_33;
			checkBox = this.checkBox_17;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x001D7A24 File Offset: 0x001D5C24
		[CompilerGenerated]
		internal  GroupBox vmethod_96()
		{
			return this.groupBox_2;
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x00023F5F File Offset: 0x0002215F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(GroupBox groupBox_3)
		{
			this.groupBox_2 = groupBox_3;
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x001D7A3C File Offset: 0x001D5C3C
		[CompilerGenerated]
		internal  CheckBox vmethod_98()
		{
			return this.checkBox_18;
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x001D7A54 File Offset: 0x001D5C54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_10);
			CheckBox checkBox = this.checkBox_18;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_18 = checkBox_33;
			checkBox = this.checkBox_18;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x001D7AA0 File Offset: 0x001D5CA0
		[CompilerGenerated]
		internal  CheckBox vmethod_100()
		{
			return this.checkBox_19;
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x001D7AB8 File Offset: 0x001D5CB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_9);
			CheckBox checkBox = this.checkBox_19;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_19 = checkBox_33;
			checkBox = this.checkBox_19;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x001D7B04 File Offset: 0x001D5D04
		[CompilerGenerated]
		internal  CheckBox vmethod_102()
		{
			return this.checkBox_20;
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x001D7B1C File Offset: 0x001D5D1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_15);
			CheckBox checkBox = this.checkBox_20;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_20 = checkBox_33;
			checkBox = this.checkBox_20;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x001D7B68 File Offset: 0x001D5D68
		[CompilerGenerated]
		internal  CheckBox vmethod_104()
		{
			return this.checkBox_21;
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x001D7B80 File Offset: 0x001D5D80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_18);
			CheckBox checkBox = this.checkBox_21;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_21 = checkBox_33;
			checkBox = this.checkBox_21;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x001D7BCC File Offset: 0x001D5DCC
		[CompilerGenerated]
		internal  CheckBox vmethod_106()
		{
			return this.checkBox_22;
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x001D7BE4 File Offset: 0x001D5DE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_23);
			CheckBox checkBox = this.checkBox_22;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_22 = checkBox_33;
			checkBox = this.checkBox_22;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x001D7C30 File Offset: 0x001D5E30
		[CompilerGenerated]
		internal  CheckBox vmethod_108()
		{
			return this.checkBox_23;
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x001D7C48 File Offset: 0x001D5E48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_17);
			CheckBox checkBox = this.checkBox_23;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_23 = checkBox_33;
			checkBox = this.checkBox_23;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x001D7C94 File Offset: 0x001D5E94
		[CompilerGenerated]
		internal  CheckBox vmethod_110()
		{
			return this.checkBox_24;
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x001D7CAC File Offset: 0x001D5EAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_16);
			CheckBox checkBox = this.checkBox_24;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_24 = checkBox_33;
			checkBox = this.checkBox_24;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x001D7CF8 File Offset: 0x001D5EF8
		[CompilerGenerated]
		internal  CheckBox vmethod_112()
		{
			return this.checkBox_25;
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x001D7D10 File Offset: 0x001D5F10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_14);
			CheckBox checkBox = this.checkBox_25;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_25 = checkBox_33;
			checkBox = this.checkBox_25;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x001D7D5C File Offset: 0x001D5F5C
		[CompilerGenerated]
		internal  CheckBox vmethod_114()
		{
			return this.checkBox_26;
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x001D7D74 File Offset: 0x001D5F74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_13);
			CheckBox checkBox = this.checkBox_26;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_26 = checkBox_33;
			checkBox = this.checkBox_26;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x001D7DC0 File Offset: 0x001D5FC0
		[CompilerGenerated]
		internal  CheckBox vmethod_116()
		{
			return this.checkBox_27;
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x001D7DD8 File Offset: 0x001D5FD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_12);
			CheckBox checkBox = this.checkBox_27;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_27 = checkBox_33;
			checkBox = this.checkBox_27;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x001D7E24 File Offset: 0x001D6024
		[CompilerGenerated]
		internal  CheckBox vmethod_118()
		{
			return this.checkBox_28;
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x001D7E3C File Offset: 0x001D603C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_11);
			CheckBox checkBox = this.checkBox_28;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_28 = checkBox_33;
			checkBox = this.checkBox_28;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x001D7E88 File Offset: 0x001D6088
		[CompilerGenerated]
		internal  Label vmethod_120()
		{
			return this.label_8;
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00023F68 File Offset: 0x00022168
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(Label label_12)
		{
			this.label_8 = label_12;
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x001D7EA0 File Offset: 0x001D60A0
		[CompilerGenerated]
		internal  CheckBox vmethod_122()
		{
			return this.checkBox_29;
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x001D7EB8 File Offset: 0x001D60B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_31);
			CheckBox checkBox = this.checkBox_29;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_29 = checkBox_33;
			checkBox = this.checkBox_29;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x001D7F04 File Offset: 0x001D6104
		[CompilerGenerated]
		internal  CheckBox vmethod_124()
		{
			return this.checkBox_30;
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x001D7F1C File Offset: 0x001D611C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_32);
			CheckBox checkBox = this.checkBox_30;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_30 = checkBox_33;
			checkBox = this.checkBox_30;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x001D7F68 File Offset: 0x001D6168
		[CompilerGenerated]
		internal  CheckBox vmethod_126()
		{
			return this.checkBox_31;
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x001D7F80 File Offset: 0x001D6180
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_33);
			CheckBox checkBox = this.checkBox_31;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_31 = checkBox_33;
			checkBox = this.checkBox_31;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x001D7FCC File Offset: 0x001D61CC
		[CompilerGenerated]
		internal  CheckBox vmethod_128()
		{
			return this.checkBox_32;
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x001D7FE4 File Offset: 0x001D61E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(CheckBox checkBox_33)
		{
			EventHandler value = new EventHandler(this.method_34);
			CheckBox checkBox = this.checkBox_32;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_32 = checkBox_33;
			checkBox = this.checkBox_32;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x001D8030 File Offset: 0x001D6230
		[CompilerGenerated]
		internal  ComboBox vmethod_130()
		{
			return this.comboBox_6;
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x001D8048 File Offset: 0x001D6248
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_50);
			ComboBox comboBox = this.comboBox_6;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_6 = comboBox_9;
			comboBox = this.comboBox_6;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x001D8094 File Offset: 0x001D6294
		[CompilerGenerated]
		internal  ComboBox vmethod_132()
		{
			return this.comboBox_7;
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x001D80AC File Offset: 0x001D62AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_45);
			ComboBox comboBox = this.comboBox_7;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_7 = comboBox_9;
			comboBox = this.comboBox_7;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x001D80F8 File Offset: 0x001D62F8
		[CompilerGenerated]
		internal  Label vmethod_134()
		{
			return this.label_9;
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00023F71 File Offset: 0x00022171
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Label label_12)
		{
			this.label_9 = label_12;
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x001D8110 File Offset: 0x001D6310
		[CompilerGenerated]
		internal  Label vmethod_136()
		{
			return this.label_10;
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00023F7A File Offset: 0x0002217A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(Label label_12)
		{
			this.label_10 = label_12;
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x001D8128 File Offset: 0x001D6328
		[CompilerGenerated]
		internal  ComboBox vmethod_138()
		{
			return this.comboBox_8;
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x001D8140 File Offset: 0x001D6340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(ComboBox comboBox_9)
		{
			EventHandler value = new EventHandler(this.method_46);
			ComboBox comboBox = this.comboBox_8;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_8 = comboBox_9;
			comboBox = this.comboBox_8;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x001D818C File Offset: 0x001D638C
		[CompilerGenerated]
		internal  Label vmethod_140()
		{
			return this.label_11;
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x00023F83 File Offset: 0x00022183
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Label label_12)
		{
			this.label_11 = label_12;
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x001D81A4 File Offset: 0x001D63A4
		private void Options_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_138().Visible = false;
			this.vmethod_132().Visible = false;
			this.vmethod_140().Visible = false;
			this.vmethod_136().Visible = false;
			this.gameOptions = SimConfiguration.gameOptions;
			this.method_1();
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x001D820C File Offset: 0x001D640C
		private void method_1()
		{
			this.GetCB_UseAutosave().Checked = this.gameOptions.IsUseAutosave();
			this.vmethod_80().Checked = this.gameOptions.IsShowDiagnostics();
			this.GetCB_MessageLogInWindow().Checked = this.gameOptions.IsMessageLogInWindow();
			this.vmethod_30().Checked = this.gameOptions.IsGameSoundsON();
			this.vmethod_32().Checked = this.gameOptions.IsGameMusicON();
			this.GetCB_AltitudeInFeet().Checked = this.gameOptions.UseImperialUnit();
			this.GetCB_ZoomOnCursor().Checked = this.gameOptions.IsZoomOnCursor();
			this.vmethod_46().SelectedIndex = (int)this.gameOptions.GetSonobuoyVisibility();
			this.vmethod_130().SelectedIndex = (int)this.gameOptions.GetDPIScalingMethod();
			this.vmethod_42().SelectedIndex = (int)this.gameOptions.GetRefPointVisibility();
			this.GetCB_MapSymbols().SelectedIndex = (int)this.gameOptions.GetMapSymbolsSet();
			this.vmethod_40().SelectedIndex = (int)this.gameOptions.GetMapCursorBox();
			this.GetCP_ShowGhostedGroupMembers().SelectedIndex = (int)this.gameOptions.ShowGhostedGroupMembers();
			this.vmethod_54().SelectedIndex = (int)this.gameOptions.GetShowPlottedPaths();
			this.vmethod_132().SelectedIndex = (int)this.gameOptions.GetShowFlightPlans_Airborne();
			this.vmethod_138().SelectedIndex = (int)this.gameOptions.GetShowFlightPlans_Planned();
			this.vmethod_74().Text = Conversions.ToString(this.gameOptions.GetNavigationMaxDistanceNMSetting());
			this.vmethod_72().Text = Conversions.ToString(this.gameOptions.GetNavigationThresholdDistanceDegSetting());
			this.vmethod_122().Checked = this.gameOptions.IsShowGameSpeedButton();
			this.vmethod_124().Checked = this.gameOptions.LogDebugInfoToFile();
			this.vmethod_126().Checked = this.gameOptions.UseMemoryProtection();
			this.GetCB_HighFidelityMode().Checked = this.gameOptions.IsHighFidelityMode();
			this.vmethod_36().Checked = this.gameOptions.NoPulseMapUpdate();
			this.vmethod_64().Checked = this.gameOptions.IsShowUnitStatusImage();
			this.GetCB_PlacenameVisibility().Checked = this.gameOptions.GetPlacenameVisibility();
			this.GetCB_PlacenameShowInChinese().Checked = this.gameOptions.IsPlacenameShowInChinese();
			this.GetCB_MessageLogCanvas().Checked = this.gameOptions.IsMessageLogCanvas();
			this.vmethod_68().Enabled = PowerSchemeManager.Win32NTVersion6Above();
			this.vmethod_68().Checked = (this.gameOptions.IsAllowPowerPlanSwitch() && PowerSchemeManager.Win32NTVersion6Above());
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("MessageType_Hidden", typeof(string));
			dataTable.Columns.Add("MessageType", typeof(string));
			dataTable.Columns.Add("MessageLog", typeof(bool));
			dataTable.Columns.Add("PopUp", typeof(bool));
			Dictionary<LoggedMessage.MessageType, LoggedMessage.MessageShowOptions>.KeyCollection.Enumerator enumerator = SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					LoggedMessage.MessageType current = enumerator.Current;
					if ((current != LoggedMessage.MessageType.CommsIsolatedMessage || Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsDisruption)) && (current != LoggedMessage.MessageType.UnguidedWeaponModifiers || GameGeneral.bProfessionEdition))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["MessageType_Hidden"] = current.ToString();
						dataRow["MessageType"] = Misc.GetMessageTypeString(current);
						dataRow["MessageLog"] = SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[current].bool_0;
						dataRow["PopUp"] = SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[current].bool_1;
						dataTable.Rows.Add(dataRow);
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
			this.vmethod_2().DataSource = dataTable;
			this.vmethod_100().Checked = this.gameOptions.IsHighFidelityMode();
			this.vmethod_98().Checked = this.gameOptions.NoPulseMapUpdate();
			this.vmethod_118().Checked = Client.GetMap().IsShowNonFriendly();
			this.vmethod_118().Enabled = this.vmethod_118().Checked;
			this.vmethod_116().Checked = (this.gameOptions.GetNavigationMaxDistanceNMSetting() != 8f || (double)this.gameOptions.GetNavigationThresholdDistanceDegSetting() != 0.5);
			this.vmethod_116().Enabled = this.vmethod_116().Checked;
			this.vmethod_114().Checked = this.gameOptions.GetPlacenameVisibility();
			this.vmethod_112().Checked = (SimConfiguration.gameOptions.ShowMissionArea() == Configuration.GameOptions._ShowMissionArea.const_0);
			this.vmethod_112().Enabled = this.vmethod_112().Checked;
			this.vmethod_102().Checked = (Client.GetMap().GetShowTargetingVectors() == MapProfile._UnitCoverage.const_0);
			this.vmethod_102().Enabled = this.vmethod_102().Checked;
			this.vmethod_110().Checked = (Client.GetMap().GetShowDatalinks() == MapProfile._UnitCoverage.const_0);
			this.vmethod_110().Enabled = this.vmethod_110().Checked;
			this.vmethod_108().Checked = this.gameOptions.IsMessageLogCanvas();
			this.vmethod_106().Checked = (this.gameOptions.ShowGhostedGroupMembers() == Configuration.GameOptions._ShowGhostedGroupMembers.ALL || this.gameOptions.ShowGhostedGroupMembers() == Configuration.GameOptions._ShowGhostedGroupMembers.SEL);
			this.vmethod_106().Enabled = this.vmethod_106().Checked;
			this.vmethod_104().Enabled = PowerSchemeManager.Win32NTVersion6Above();
			this.vmethod_104().Checked = (!this.gameOptions.IsAllowPowerPlanSwitch() && PowerSchemeManager.Win32NTVersion6Above());
			this.vmethod_128().Checked = this.gameOptions.UseMemoryProtection();
			this.vmethod_90().Checked = (Client.GetMap().GetShowRangeSymbols() == MapProfile._UnitCoverage.const_0);
			this.vmethod_90().Enabled = this.vmethod_90().Checked;
			this.vmethod_92().Checked = (Client.GetMap().GetShowIlluminationVectors() == MapProfile._UnitCoverage.const_0);
			this.vmethod_92().Enabled = this.vmethod_92().Checked;
			this.vmethod_94().Checked = (Client.GetMap().GetShowContactEmissions() == MapProfile._UnitCoverage.const_0);
			this.vmethod_94().Enabled = this.vmethod_94().Checked;
			this.vmethod_86().Checked = this.gameOptions.IsUseAutosave();
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void Options_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00023F8C File Offset: 0x0002218C
		private void method_2(object sender, EventArgs e)
		{
			Class267.dictionary_0.Clear();
			SimConfiguration.SaveConfig();
			Interaction.MsgBox("Positions & sizes of secondary windows have been reset to default values", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00023FAA File Offset: 0x000221AA
		private void Options_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_7();
			this.method_8();
			SimConfiguration.SaveConfig();
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00023FD2 File Offset: 0x000221D2
		private void method_3(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.method_1();
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00023FE1 File Offset: 0x000221E1
		private void method_4(object sender, EventArgs e)
		{
			this.method_7();
			this.method_1();
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x00023FEF File Offset: 0x000221EF
		private void method_5(object sender, EventArgs e)
		{
			this.bool_1 = true;
			this.method_1();
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00023FFE File Offset: 0x000221FE
		private void method_6(object sender, EventArgs e)
		{
			this.method_8();
			this.method_1();
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x001D88B0 File Offset: 0x001D6AB0
		private void method_7()
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				if (string.IsNullOrEmpty(this.vmethod_74().Text) || !Versioned.IsNumeric(this.vmethod_74().Text))
				{
					this.gameOptions.SetNavigationMaxDistanceNMSetting(0f);
					if (!Information.IsNothing(Client.GetClientScenario()))
					{
						Client.GetClientScenario().Navigation_FinegrainedMaxDistance = 0f;
					}
					this.vmethod_74().Text = Conversions.ToString(0);
				}
				else
				{
					if (Conversions.ToSingle(this.vmethod_74().Text) != Client.GetClientScenario().Navigation_FinegrainedMaxDistance)
					{
						Interaction.MsgBox(string.Concat(new string[]
						{
							"IMPORTANT NOTE! You have selected to use fine-grained navigation for distances up to ",
							this.vmethod_74().Text,
							" nm, and look for paths up to ",
							this.vmethod_72().Text,
							" degrees lat/lon outside the start and end points. Fine-grained navigation is extremely CPU intensive, and for instance a 50 nm course with 2 degrees lat/lon search area outside the start and end points may take up to five minutes to compute since it involves checking nearly one million (!) points. Do not alter these settings unless you know what you do. The default setting is 8 nm and 0.5 degrees."
						}), MsgBoxStyle.OkOnly, null);
					}
					this.gameOptions.SetNavigationMaxDistanceNMSetting(Conversions.ToSingle(this.vmethod_74().Text));
					if (!Information.IsNothing(Client.GetClientScenario()))
					{
						Client.GetClientScenario().Navigation_FinegrainedMaxDistance = Conversions.ToSingle(this.vmethod_74().Text);
					}
				}
			}
			else
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x001D89EC File Offset: 0x001D6BEC
		private void method_8()
		{
			if (this.bool_1)
			{
				this.bool_1 = false;
				if (string.IsNullOrEmpty(this.vmethod_72().Text) || !Versioned.IsNumeric(this.vmethod_72().Text))
				{
					this.gameOptions.SetNavigationThresholdDistanceDegSetting(0f);
					if (!Information.IsNothing(Client.GetClientScenario()))
					{
						Client.GetClientScenario().Navigation_FinegrainedThresholdDistance = 0f;
					}
					this.vmethod_72().Text = Conversions.ToString(0);
				}
				else
				{
					if (Conversions.ToSingle(this.vmethod_72().Text) != Client.GetClientScenario().Navigation_FinegrainedThresholdDistance)
					{
						Interaction.MsgBox(string.Concat(new string[]
						{
							"IMPORTANT NOTE! You have selected to use fine-grained navigation for distances up to ",
							this.vmethod_74().Text,
							" nm, and look for paths up to ",
							this.vmethod_72().Text,
							" degrees lat/lon outside the start and end points. Fine-grained navigation is extremely CPU intensive, and for instance a 50 nm course with 2 degrees lat/lon search area outside the start and end points may take up to five minutes to compute since it involves checking nearly one million (!) points. Do not alter these settings unless you know what you do. The default setting is 8 nm and 0.5 degrees."
						}), MsgBoxStyle.OkOnly, null);
					}
					this.gameOptions.SetNavigationThresholdDistanceDegSetting(Conversions.ToSingle(this.vmethod_72().Text));
					if (!Information.IsNothing(Client.GetClientScenario()))
					{
						Client.GetClientScenario().Navigation_FinegrainedThresholdDistance = Conversions.ToSingle(this.vmethod_72().Text);
					}
				}
			}
			else
			{
				this.bool_1 = false;
			}
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x0002400C File Offset: 0x0002220C
		private void method_9(object sender, EventArgs e)
		{
			this.gameOptions.SetHighFidelityMode(this.vmethod_100().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00024030 File Offset: 0x00022230
		private void method_10(object sender, EventArgs e)
		{
			this.gameOptions.SetNoPulseMapUpdate(this.vmethod_98().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x001D8B28 File Offset: 0x001D6D28
		private void method_11(object sender, EventArgs e)
		{
			if (!this.vmethod_118().Checked)
			{
				Client.GetMap().SetIsShowNonFriendly(false);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_118().Enabled = this.vmethod_118().Checked;
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x001D8B80 File Offset: 0x001D6D80
		private void method_12(object sender, EventArgs e)
		{
			if (!this.vmethod_116().Checked)
			{
				this.gameOptions.SetNavigationMaxDistanceNMSetting(8f);
				this.gameOptions.SetNavigationThresholdDistanceDegSetting(0.5f);
				Client.GetClientScenario().Navigation_FinegrainedMaxDistance = 8f;
				Client.GetClientScenario().Navigation_FinegrainedThresholdDistance = 0.5f;
				this.vmethod_116().Enabled = false;
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x00024054 File Offset: 0x00022254
		private void method_13(object sender, EventArgs e)
		{
			this.gameOptions.SetPlacenameVisibility(this.vmethod_114().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x001D8BF0 File Offset: 0x001D6DF0
		private void method_14(object sender, EventArgs e)
		{
			if (!this.vmethod_112().Checked)
			{
				this.gameOptions.method_35(Configuration.GameOptions._ShowMissionArea.const_2);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_112().Enabled = false;
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x001D8C40 File Offset: 0x001D6E40
		private void method_15(object sender, EventArgs e)
		{
			if (!this.vmethod_102().Checked)
			{
				Client.GetMap().SetShowTargetingVectors(MapProfile._UnitCoverage.const_2);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_102().Enabled = false;
			}
			else
			{
				Client.GetMap().SetShowTargetingVectors(MapProfile._UnitCoverage.const_0);
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x001D8C9C File Offset: 0x001D6E9C
		private void method_16(object sender, EventArgs e)
		{
			if (!this.vmethod_110().Checked)
			{
				Client.GetMap().SetShowDatalinks(MapProfile._UnitCoverage.const_2);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_110().Enabled = false;
			}
			else
			{
				Client.GetMap().SetShowDatalinks(MapProfile._UnitCoverage.const_0);
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x00024078 File Offset: 0x00022278
		private void method_17(object sender, EventArgs e)
		{
			this.gameOptions.SetMessageLogCanvas(this.vmethod_108().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x0002409C File Offset: 0x0002229C
		private void method_18(object sender, EventArgs e)
		{
			this.gameOptions.SetAllowPowerPlanSwitch(!this.vmethod_104().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x001D8CF8 File Offset: 0x001D6EF8
		private void method_19(object sender, EventArgs e)
		{
			if (!this.vmethod_90().Checked)
			{
				Client.GetMap().SetShowRangeSymbols(MapProfile._UnitCoverage.const_2);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_90().Enabled = false;
			}
			else
			{
				Client.GetMap().SetShowRangeSymbols(MapProfile._UnitCoverage.const_0);
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x001D8D54 File Offset: 0x001D6F54
		private void method_20(object sender, EventArgs e)
		{
			if (!this.vmethod_92().Checked)
			{
				Client.GetMap().SetShowIlluminationVectors(MapProfile._UnitCoverage.const_2);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_92().Enabled = false;
			}
			else
			{
				Client.GetMap().SetShowIlluminationVectors(MapProfile._UnitCoverage.const_0);
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x001D8DB0 File Offset: 0x001D6FB0
		private void method_21(object sender, EventArgs e)
		{
			if (!this.vmethod_94().Checked)
			{
				Client.GetMap().SetShowContactEmissions(MapProfile._UnitCoverage.const_2);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_94().Enabled = false;
			}
			else
			{
				Client.GetMap().SetShowContactEmissions(MapProfile._UnitCoverage.const_0);
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x000240C3 File Offset: 0x000222C3
		private void method_22(object sender, EventArgs e)
		{
			this.gameOptions.SetUseAutosave(this.vmethod_86().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x001D8E0C File Offset: 0x001D700C
		private void method_23(object sender, EventArgs e)
		{
			if (!this.vmethod_106().Checked)
			{
				this.gameOptions.method_33(Configuration.GameOptions._ShowGhostedGroupMembers.NONE);
				CommandFactory.GetCommandMain().GetMainForm().RenderMap();
				this.vmethod_106().Enabled = false;
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x000240E7 File Offset: 0x000222E7
		private void method_24(object sender, EventArgs e)
		{
			this.gameOptions.SetHighFidelityMode(this.GetCB_HighFidelityMode().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x0002410B File Offset: 0x0002230B
		private void method_25(object sender, EventArgs e)
		{
			this.gameOptions.SetNoPulseMapUpdate(this.vmethod_36().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x001D8E5C File Offset: 0x001D705C
		private void method_26(object sender, EventArgs e)
		{
			bool flag = this.gameOptions.IsAllowPowerPlanSwitch() != this.vmethod_68().Checked;
			this.gameOptions.SetAllowPowerPlanSwitch(this.vmethod_68().Checked);
			if (flag)
			{
				if (this.gameOptions.IsAllowPowerPlanSwitch())
				{
					PowerSchemeManager.smethod_0();
				}
				else
				{
					PowerSchemeManager.RestorePowerScheme();
				}
			}
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x0002412F File Offset: 0x0002232F
		private void method_27(object sender, EventArgs e)
		{
			this.gameOptions.SetUseAutosave(this.GetCB_UseAutosave().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x00024153 File Offset: 0x00022353
		private void CB_PlacenameVisibility_Click(object sender, EventArgs e)
		{
			this.gameOptions.SetPlacenameVisibility(this.GetCB_PlacenameVisibility().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00024177 File Offset: 0x00022377
		private void CB_PlacenameShowInChinese_Click(object sender, EventArgs e)
		{
			this.gameOptions.SetPlacenameShowInChinese(this.GetCB_PlacenameShowInChinese().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x0002419B File Offset: 0x0002239B
		private void method_29(object sender, EventArgs e)
		{
			this.gameOptions.SetMessageLogCanvas(this.GetCB_MessageLogCanvas().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x000241BF File Offset: 0x000223BF
		private void method_30(object sender, EventArgs e)
		{
			this.gameOptions.method_33((Configuration.GameOptions._ShowGhostedGroupMembers)this.GetCP_ShowGhostedGroupMembers().SelectedIndex);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x000241E4 File Offset: 0x000223E4
		private void method_31(object sender, EventArgs e)
		{
			this.gameOptions.SetShowGameSpeedButton(this.vmethod_122().Checked);
			Client.b_Completed = true;
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x00024202 File Offset: 0x00022402
		private void method_32(object sender, EventArgs e)
		{
			this.gameOptions.SetLogDebugInfoToFile(this.vmethod_124().Checked);
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0002421A File Offset: 0x0002241A
		private void method_33(object sender, EventArgs e)
		{
			this.gameOptions.SetMemoryProtection(this.vmethod_126().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x0002423E File Offset: 0x0002243E
		private void method_34(object sender, EventArgs e)
		{
			this.gameOptions.SetMemoryProtection(this.vmethod_128().Checked);
			Client.b_Completed = true;
			this.method_1();
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x001D8ECC File Offset: 0x001D70CC
		private void method_35(object sender, EventArgs e)
		{
			this.gameOptions.SetMessageLogInWindow(this.GetCB_MessageLogInWindow().Checked);
			if (this.gameOptions.IsMessageLogInWindow())
			{
				CommandFactory.GetCommandMain().GetMessageLogWindow().Show();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMessageLogWindow().Close();
			}
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00024262 File Offset: 0x00022462
		private void method_36(object sender, EventArgs e)
		{
			this.gameOptions.SetUseImperialUnit(this.GetCB_AltitudeInFeet().Checked);
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x0002427A File Offset: 0x0002247A
		private void method_37(object sender, EventArgs e)
		{
			this.gameOptions.SetZoomOnCursor(this.GetCB_ZoomOnCursor().Checked);
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00024292 File Offset: 0x00022492
		private void method_38(object sender, EventArgs e)
		{
			this.gameOptions.SetIsShowUnitStatusImage(this.vmethod_64().Checked);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x000242AA File Offset: 0x000224AA
		private void method_39(object sender, EventArgs e)
		{
			this.gameOptions.SetSonobuoyVisibility((Configuration.GameOptions._SonobuoyVisibility)this.vmethod_46().SelectedIndex);
			CommandFactory.GetCommandMain().GetMainForm().RenderMap();
			Client.b_Completed = true;
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x000242D8 File Offset: 0x000224D8
		private void method_40(object sender, EventArgs e)
		{
			this.gameOptions.SetRefPointVisibility((Configuration.GameOptions._RefPointVisibility)this.vmethod_42().SelectedIndex);
			CommandFactory.GetCommandMain().GetMainForm().RenderMap();
			Client.b_Completed = true;
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00024306 File Offset: 0x00022506
		private void method_41(object sender, EventArgs e)
		{
			this.gameOptions.SetMapCursorBox((Configuration.GameOptions._MapCursorBox)this.vmethod_40().SelectedIndex);
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x0002431F File Offset: 0x0002251F
		private void CB_MapSymbols_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.gameOptions.SetMapSymbolsSet((Configuration.GameOptions._MapSymbolsSet)this.GetCB_MapSymbols().SelectedIndex);
			Client.LoadSymbolsSet();
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x0002433D File Offset: 0x0002253D
		private void method_43(object sender, EventArgs e)
		{
			this.gameOptions.SetShowPlottedPaths((Configuration.GameOptions.Enum45)this.vmethod_54().SelectedIndex);
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00024356 File Offset: 0x00022556
		private void method_44(object sender, EventArgs e)
		{
			this.gameOptions.SetShowDiagnostics(this.vmethod_80().Checked);
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x0002436E File Offset: 0x0002256E
		private void method_45(object sender, EventArgs e)
		{
			this.gameOptions.SetShowFlightPlans_Airborne((Configuration.GameOptions._ShowFlightPlans_Airborne)this.vmethod_132().SelectedIndex);
			CommandFactory.GetCommandMain().GetMainForm().RenderMap();
			Client.b_Completed = true;
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x0002439C File Offset: 0x0002259C
		private void method_46(object sender, EventArgs e)
		{
			this.gameOptions.SetShowFlightPlans_Planned((Configuration.GameOptions._ShowFlightPlans_Planned)this.vmethod_138().SelectedIndex);
			Client.b_Completed = true;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000243BB File Offset: 0x000225BB
		private void method_47(object sender, EventArgs e)
		{
			this.gameOptions.SetGameSoundsON(this.vmethod_30().Checked);
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000243D3 File Offset: 0x000225D3
		private void method_48(object sender, EventArgs e)
		{
			this.gameOptions.SetGameMusicON(this.vmethod_32().Checked);
			if (this.gameOptions.IsGameMusicON())
			{
				Class2531.smethod_1();
			}
			else
			{
				Class2531.class2530_0.method_1();
			}
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void CB_RunCoreMultithreaded_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x0002440C File Offset: 0x0002260C
		private void method_50(object sender, EventArgs e)
		{
			this.gameOptions.SetDPIScalingMethod((Configuration.GameOptions._DPIScalingMethod)this.vmethod_130().SelectedIndex);
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x001D8F20 File Offset: 0x001D7120
		private void method_51(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex >= 2)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_2().Rows[e.RowIndex];
				dataGridViewRow.Cells[e.ColumnIndex].Value = Operators.NotObject(dataGridViewRow.Cells[e.ColumnIndex].Value);
				string value = Conversions.ToString(dataGridViewRow.Cells[0].Value);
				LoggedMessage.MessageType key = (LoggedMessage.MessageType)Conversions.ToByte(Enum.Parse(typeof(LoggedMessage.MessageType), value, true));
				LoggedMessage.MessageShowOptions messageShowOptions = SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[key];
				messageShowOptions.bool_0 = Conversions.ToBoolean(dataGridViewRow.Cells[2].Value);
				messageShowOptions.bool_1 = Conversions.ToBoolean(dataGridViewRow.Cells[3].Value);
			}
		}

		// Token: 0x04002333 RID: 9011
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04002334 RID: 9012
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002335 RID: 9013
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04002336 RID: 9014
		[CompilerGenerated]
		private CheckBox CB_RunCoreMultithreaded;

		// Token: 0x04002337 RID: 9015
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002338 RID: 9016
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04002339 RID: 9017
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x0400233A RID: 9018
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400233B RID: 9019
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400233C RID: 9020
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x0400233D RID: 9021
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x0400233E RID: 9022
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x0400233F RID: 9023
		[CompilerGenerated]
		private CheckBox checkBox_4;

		// Token: 0x04002340 RID: 9024
		[CompilerGenerated]
		private CheckBox checkBox_5;

		// Token: 0x04002341 RID: 9025
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04002342 RID: 9026
		[CompilerGenerated]
		private CheckBox checkBox_6;

		// Token: 0x04002343 RID: 9027
		[CompilerGenerated]
		private CheckBox checkBox_7;

		// Token: 0x04002344 RID: 9028
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002345 RID: 9029
		[CompilerGenerated]
		private CheckBox checkBox_8;

		// Token: 0x04002346 RID: 9030
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04002347 RID: 9031
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04002348 RID: 9032
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04002349 RID: 9033
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400234A RID: 9034
		[CompilerGenerated]
		private ComboBox comboBox_2;

		// Token: 0x0400234B RID: 9035
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400234C RID: 9036
		[CompilerGenerated]
		private ComboBox CB_MapSymbols;

		// Token: 0x0400234D RID: 9037
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x0400234E RID: 9038
		[CompilerGenerated]
		private ComboBox comboBox_4;

		// Token: 0x0400234F RID: 9039
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002350 RID: 9040
		[CompilerGenerated]
		private ComboBox comboBox_5;

		// Token: 0x04002351 RID: 9041
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002352 RID: 9042
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04002353 RID: 9043
		[CompilerGenerated]
		private CheckBox checkBox_9;

		// Token: 0x04002354 RID: 9044
		[CompilerGenerated]
		private CheckBox CB_PlacenameVisibility;

		// Token: 0x04002355 RID: 9045
		private CheckBox CB_PlacenameShowInChinese;

		// Token: 0x04002356 RID: 9046
		[CompilerGenerated]
		private CheckBox checkBox_11;

		// Token: 0x04002357 RID: 9047
		[CompilerGenerated]
		private CheckBox checkBox_12;

		// Token: 0x04002358 RID: 9048
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002359 RID: 9049
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x0400235A RID: 9050
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x0400235B RID: 9051
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x0400235C RID: 9052
		[CompilerGenerated]
		private CheckBox checkBox_13;

		// Token: 0x0400235D RID: 9053
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x0400235E RID: 9054
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x0400235F RID: 9055
		[CompilerGenerated]
		private CheckBox checkBox_14;

		// Token: 0x04002360 RID: 9056
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x04002361 RID: 9057
		[CompilerGenerated]
		private CheckBox checkBox_15;

		// Token: 0x04002362 RID: 9058
		[CompilerGenerated]
		private CheckBox checkBox_16;

		// Token: 0x04002363 RID: 9059
		[CompilerGenerated]
		private CheckBox checkBox_17;

		// Token: 0x04002364 RID: 9060
		[CompilerGenerated]
		private GroupBox groupBox_2;

		// Token: 0x04002365 RID: 9061
		[CompilerGenerated]
		private CheckBox checkBox_18;

		// Token: 0x04002366 RID: 9062
		[CompilerGenerated]
		private CheckBox checkBox_19;

		// Token: 0x04002367 RID: 9063
		[CompilerGenerated]
		private CheckBox checkBox_20;

		// Token: 0x04002368 RID: 9064
		[CompilerGenerated]
		private CheckBox checkBox_21;

		// Token: 0x04002369 RID: 9065
		[CompilerGenerated]
		private CheckBox checkBox_22;

		// Token: 0x0400236A RID: 9066
		[CompilerGenerated]
		private CheckBox checkBox_23;

		// Token: 0x0400236B RID: 9067
		[CompilerGenerated]
		private CheckBox checkBox_24;

		// Token: 0x0400236C RID: 9068
		[CompilerGenerated]
		private CheckBox checkBox_25;

		// Token: 0x0400236D RID: 9069
		[CompilerGenerated]
		private CheckBox checkBox_26;

		// Token: 0x0400236E RID: 9070
		[CompilerGenerated]
		private CheckBox checkBox_27;

		// Token: 0x0400236F RID: 9071
		[CompilerGenerated]
		private CheckBox checkBox_28;

		// Token: 0x04002370 RID: 9072
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04002371 RID: 9073
		[CompilerGenerated]
		private CheckBox checkBox_29;

		// Token: 0x04002372 RID: 9074
		[CompilerGenerated]
		private CheckBox checkBox_30;

		// Token: 0x04002373 RID: 9075
		[CompilerGenerated]
		private CheckBox checkBox_31;

		// Token: 0x04002374 RID: 9076
		[CompilerGenerated]
		private CheckBox checkBox_32;

		// Token: 0x04002375 RID: 9077
		[CompilerGenerated]
		private ComboBox comboBox_6;

		// Token: 0x04002376 RID: 9078
		[CompilerGenerated]
		private ComboBox comboBox_7;

		// Token: 0x04002377 RID: 9079
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x04002378 RID: 9080
		[CompilerGenerated]
		private Label label_10;

		// Token: 0x04002379 RID: 9081
		[CompilerGenerated]
		private ComboBox comboBox_8;

		// Token: 0x0400237A RID: 9082
		[CompilerGenerated]
		private Label label_11;

		// Token: 0x0400237B RID: 9083
		private Configuration.GameOptions gameOptions;

		// Token: 0x0400237C RID: 9084
		private bool bool_0;

		// Token: 0x0400237D RID: 9085
		private bool bool_1;
	}
}
