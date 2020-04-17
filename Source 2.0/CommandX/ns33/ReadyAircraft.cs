using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns4;

namespace ns33
{
	// Token: 0x020009BE RID: 2494
	[DesignerGenerated]
	public sealed partial class ReadyAircraft : CommandForm
	{
		// Token: 0x06004245 RID: 16965 RVA: 0x00180ECC File Offset: 0x0017F0CC
		public ReadyAircraft()
		{
			base.FormClosing += new FormClosingEventHandler(this.ReadyAircraft_FormClosing);
			base.Load += new EventHandler(this.ReadyAircraft_Load);
			base.KeyDown += new KeyEventHandler(this.ReadyAircraft_KeyDown);
			this.LoadoutWeaponsDataTable = new DataTable();
			this.dataTable_1 = new DataTable();
			this.dictionary_0 = new Dictionary<int, int>();
			this.hashSet_0 = new HashSet<int>();
			this.InitializeComponent();
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00182DAC File Offset: 0x00180FAC
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00021745 File Offset: 0x0001F945
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_8)
		{
			this.label_0 = label_8;
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00182DC4 File Offset: 0x00180FC4
		[CompilerGenerated]
		internal  DataGridView vmethod_2()
		{
			return this.dataGridView_0;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x00182DDC File Offset: 0x00180FDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridView dataGridView_2)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_14);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value;
			}
			this.dataGridView_0 = dataGridView_2;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value;
			}
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x00182E28 File Offset: 0x00181028
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x00182E40 File Offset: 0x00181040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_5;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00182E8C File Offset: 0x0018108C
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_1;
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00182EA4 File Offset: 0x001810A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_5;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00182EF0 File Offset: 0x001810F0
		[CompilerGenerated]
		internal  MenuStrip vmethod_8()
		{
			return this.menuStrip_0;
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x0002174E File Offset: 0x0001F94E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(MenuStrip menuStrip_1)
		{
			this.menuStrip_0 = menuStrip_1;
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x00182F08 File Offset: 0x00181108
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_10()
		{
			return this.toolStripMenuItem_0;
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00182F20 File Offset: 0x00181120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripMenuItem toolStripMenuItem_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_0 = toolStripMenuItem_1;
			toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x00182F6C File Offset: 0x0018116C
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_2;
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00182F84 File Offset: 0x00181184
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_9);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_5;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00182FD0 File Offset: 0x001811D0
		[CompilerGenerated]
		internal  DataGridView vmethod_14()
		{
			return this.dataGridView_1;
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x00182FE8 File Offset: 0x001811E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridView dataGridView_2)
		{
			DataGridViewCellMouseEventHandler value = new DataGridViewCellMouseEventHandler(this.method_11);
			EventHandler value2 = new EventHandler(this.method_12);
			DataGridViewCellFormattingEventHandler value3 = new DataGridViewCellFormattingEventHandler(this.method_15);
			DataGridView dataGridView = this.dataGridView_1;
			if (dataGridView != null)
			{
				dataGridView.CellMouseDoubleClick -= value;
				dataGridView.SelectionChanged -= value2;
				dataGridView.CellFormatting -= value3;
			}
			this.dataGridView_1 = dataGridView_2;
			dataGridView = this.dataGridView_1;
			if (dataGridView != null)
			{
				dataGridView.CellMouseDoubleClick += value;
				dataGridView.SelectionChanged += value2;
				dataGridView.CellFormatting += value3;
			}
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00183068 File Offset: 0x00181268
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_1;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00021757 File Offset: 0x0001F957
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_8)
		{
			this.label_1 = label_8;
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00183080 File Offset: 0x00181280
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00021760 File Offset: 0x0001F960
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_8)
		{
			this.label_2 = label_8;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00183098 File Offset: 0x00181298
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_3;
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x00021769 File Offset: 0x0001F969
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_8)
		{
			this.label_3 = label_8;
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x001830B0 File Offset: 0x001812B0
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_4;
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00021772 File Offset: 0x0001F972
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_8)
		{
			this.label_4 = label_8;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x001830C8 File Offset: 0x001812C8
		[CompilerGenerated]
		internal  Label vmethod_24()
		{
			return this.label_5;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0002177B File Offset: 0x0001F97B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_8)
		{
			this.label_5 = label_8;
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x001830E0 File Offset: 0x001812E0
		[CompilerGenerated]
		internal  Button vmethod_26()
		{
			return this.button_3;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x001830F8 File Offset: 0x001812F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_10);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_5;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x00183144 File Offset: 0x00181344
		[CompilerGenerated]
		internal  Button vmethod_28()
		{
			return this.button_4;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0018315C File Offset: 0x0018135C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_5;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x001831A8 File Offset: 0x001813A8
		[CompilerGenerated]
		internal  CheckBox vmethod_30()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x001831C0 File Offset: 0x001813C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_19);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_2;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0018320C File Offset: 0x0018140C
		[CompilerGenerated]
		internal  ComboBox vmethod_32()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x00183224 File Offset: 0x00181424
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_16);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00183270 File Offset: 0x00181470
		[CompilerGenerated]
		internal  Label vmethod_34()
		{
			return this.label_6;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00021784 File Offset: 0x0001F984
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_8)
		{
			this.label_6 = label_8;
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x00183288 File Offset: 0x00181488
		[CompilerGenerated]
		internal  CheckBox vmethod_36()
		{
			return this.checkBox_1;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x001832A0 File Offset: 0x001814A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_21);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_2;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x001832EC File Offset: 0x001814EC
		[CompilerGenerated]
		internal  Label vmethod_38()
		{
			return this.label_7;
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x0002178D File Offset: 0x0001F98D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Label label_8)
		{
			this.label_7 = label_8;
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00183304 File Offset: 0x00181504
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x00021796 File Offset: 0x0001F996
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x0018331C File Offset: 0x0018151C
		[CompilerGenerated]
		internal  DataGridViewLinkColumn vmethod_42()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x0002179F File Offset: 0x0001F99F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewLinkColumn dataGridViewLinkColumn_1)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_1;
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00183334 File Offset: 0x00181534
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x000217A8 File Offset: 0x0001F9A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x0018334C File Offset: 0x0018154C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x000217B1 File Offset: 0x0001F9B1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00183364 File Offset: 0x00181564
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x000217BA File Offset: 0x0001F9BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x0018337C File Offset: 0x0018157C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_50()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x000217C3 File Offset: 0x0001F9C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00183394 File Offset: 0x00181594
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_52()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x000217CC File Offset: 0x0001F9CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x001833AC File Offset: 0x001815AC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_54()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x000217D5 File Offset: 0x0001F9D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x001833C4 File Offset: 0x001815C4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_56()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x000217DE File Offset: 0x0001F9DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x001833DC File Offset: 0x001815DC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_58()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x000217E7 File Offset: 0x0001F9E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x001833F4 File Offset: 0x001815F4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_60()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x000217F0 File Offset: 0x0001F9F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x0018340C File Offset: 0x0018160C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_62()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000217F9 File Offset: 0x0001F9F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x00183424 File Offset: 0x00181624
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_64()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x00021802 File Offset: 0x0001FA02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x0018343C File Offset: 0x0018163C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_66()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x0002180B File Offset: 0x0001FA0B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x00183454 File Offset: 0x00181654
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetRangeProfileDescription()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00021814 File Offset: 0x0001FA14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x0018346C File Offset: 0x0018166C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x0002181D File Offset: 0x0001FA1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x00183484 File Offset: 0x00181684
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_72()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x00021826 File Offset: 0x0001FA26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x0018349C File Offset: 0x0018169C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_74()
		{
			return this.dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x0002182F File Offset: 0x0001FA2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_16 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x001834B4 File Offset: 0x001816B4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_76()
		{
			return this.dataGridViewTextBoxColumn_17;
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x00021838 File Offset: 0x0001FA38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_17 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x001834CC File Offset: 0x001816CC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_78()
		{
			return this.dataGridViewTextBoxColumn_18;
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00021841 File Offset: 0x0001FA41
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_18 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x001834E4 File Offset: 0x001816E4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_80()
		{
			return this.dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0002184A File Offset: 0x0001FA4A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_19 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x001834FC File Offset: 0x001816FC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_82()
		{
			return this.dataGridViewTextBoxColumn_20;
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00021853 File Offset: 0x0001FA53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_20 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00183514 File Offset: 0x00181714
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_84()
		{
			return this.dataGridViewTextBoxColumn_21;
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x0002185C File Offset: 0x0001FA5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_21 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x0018352C File Offset: 0x0018172C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_86()
		{
			return this.dataGridViewTextBoxColumn_22;
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x00021865 File Offset: 0x0001FA65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_22 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x00183544 File Offset: 0x00181744
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_88()
		{
			return this.dataGridViewTextBoxColumn_23;
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x0002186E File Offset: 0x0001FA6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_23 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x0018355C File Offset: 0x0018175C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_90()
		{
			return this.dataGridViewTextBoxColumn_24;
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00021877 File Offset: 0x0001FA77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_24 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00183574 File Offset: 0x00181774
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_92()
		{
			return this.dataGridViewTextBoxColumn_25;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00021880 File Offset: 0x0001FA80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_25 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x0018358C File Offset: 0x0018178C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_94()
		{
			return this.dataGridViewTextBoxColumn_26;
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x00021889 File Offset: 0x0001FA89
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_26 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ReadyAircraft_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x001835A4 File Offset: 0x001817A4
		private void ReadyAircraft_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_12().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.vmethod_26().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			if (SimConfiguration.gameOptions.OnlyShowAvailableLoadouts())
			{
				this.vmethod_36().Checked = true;
			}
			else
			{
				this.vmethod_36().Checked = false;
			}
			this.method_1();
			string text;
			string text2;
			if (this.list_0.Count > 0)
			{
				text = Misc.smethod_11(this.list_0[0].UnitClass);
				text2 = this.list_0[0].GetAircraftAirOps().GetCurrentHostUnit().Name;
			}
			else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
			{
				text = this.list_1[0].UnitClass;
				text2 = this.list_1[0].CurrentHostUnit_Name;
			}
			else
			{
				text = "<No Unit Selected>";
				text2 = "<No Host Unit Selected>";
			}
			int num = this.list_0.Count;
			if (!Information.IsNothing(this.list_1))
			{
				num += this.list_1.Count;
			}
			this.Text = string.Concat(new string[]
			{
				"飞机出动准备: ",
				Conversions.ToString(num),
				"x ",
				text,
				" at ",
				text2
			});
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00183728 File Offset: 0x00181928
		private void method_1()
		{
			List<Aircraft> selectedAircraft = this.list_0;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			bool flag = Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
			this.dictionary_0 = DBFunctions.smethod_40(selectedAircraft, ref sQLiteConnection, ref flag);
			if (this.list_0.Count > 0)
			{
				int dBID = this.list_0[0].DBID;
				Dictionary<int, int> selectedAircraftTotalWeaponQty = this.dictionary_0;
				sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
				Scenario clientScenario = Client.GetClientScenario();
				Client.GetClientScenario();
				Scenario clientScenario2 = Client.GetClientScenario();
				List<Aircraft> list;
				Aircraft value = (list = this.list_0)[0];
				int num = 0;
				bool flag2 = false;
				DataTable dataTable = DBFunctions.smethod_42(dBID, selectedAircraftTotalWeaponQty, ref sQLiteConnection, clientScenario, ref flag, ref clientScenario2, ref value, ref num, ref flag2);
				list[0] = value;
				this.dataTable_1 = dataTable;
			}
			else
			{
				if (Information.IsNothing(this.list_1) || this.list_1.Count <= 0)
				{
					return;
				}
				Scenario clientScenario2 = Client.GetClientScenario();
				Aircraft aircraft = new Aircraft(ref clientScenario2, null);
				aircraft.GetAircraftAirOps().SetCurrentHostUnit(this.list_1[0].GetHostUnit(Client.GetClientScenario()));
				int aircraftDBID = this.list_1[0].aircraftDBID;
				Dictionary<int, int> selectedAircraftTotalWeaponQty2 = this.dictionary_0;
				sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
				Scenario clientScenario3 = Client.GetClientScenario();
				Client.GetClientScenario();
				clientScenario2 = Client.GetClientScenario();
				int num = 0;
				bool flag2 = false;
				this.dataTable_1 = DBFunctions.smethod_42(aircraftDBID, selectedAircraftTotalWeaponQty2, ref sQLiteConnection, clientScenario3, ref flag, ref clientScenario2, ref aircraft, ref num, ref flag2);
			}
			DataView dataView = new DataView(this.dataTable_1);
			if (this.vmethod_36().Checked)
			{
				dataView.RowFilter = "NOT NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly = '0'";
			}
			this.vmethod_14().DataSource = dataView;
			if (this.ID == 0)
			{
				this.ID = Conversions.ToInteger(this.vmethod_14().Rows[0].Cells["ID"].Value);
			}
			this.method_6(this.dictionary_0);
			foreach (Aircraft current in this.list_0)
			{
				if (!Information.IsNothing(current.GetLoadout()) && !this.hashSet_0.Contains(current.GetLoadoutDBID()))
				{
					this.hashSet_0.Add(current.GetLoadoutDBID());
				}
			}
			if (!Information.IsNothing(this.list_1))
			{
				foreach (Mission.EmptySlot current2 in this.list_1)
				{
					if (!string.IsNullOrEmpty(Conversions.ToString(current2.LoadoutDBID)) && !this.hashSet_0.Contains(current2.LoadoutDBID))
					{
						this.hashSet_0.Add(current2.LoadoutDBID);
					}
				}
			}
			if (this.hashSet_0.Count != 1)
			{
				IEnumerator enumerator3 = ((IEnumerable)this.vmethod_14().Rows).GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						((DataGridViewRow)enumerator3.Current).Selected = false;
					}
					return;
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
			int num2 = this.hashSet_0.ElementAtOrDefault(0);
			IEnumerator enumerator4 = ((IEnumerable)this.vmethod_14().Rows).GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator4.Current;
					if (Conversions.ToInteger(dataGridViewRow.Cells["ID"].Value) == num2)
					{
						dataGridViewRow.Selected = true;
						break;
					}
					dataGridViewRow.Selected = false;
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

		// Token: 0x060042AB RID: 17067 RVA: 0x00183B34 File Offset: 0x00181D34
		private int method_2(int int_5, Dictionary<int, int> dictionary_1, bool bool_2)
		{
			int num;
			int result;
			try
			{
				if (Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
				{
					num = 2147483647;
				}
				else
				{
					int num2 = 9999999;
					DataTable dataTable = new DataTable();
					SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
					dataTable = DBFunctions.LoadLoadoutWeaponsData(int_5, ref sQLiteConnection, ref bool_2);
					ActiveUnit activeUnit = null;
					if (this.list_0.Count > 0)
					{
						if (Information.IsNothing(this.list_0[0]))
						{
							num = 0;
							result = 0;
							return result;
						}
						activeUnit = this.list_0[0].GetAircraftAirOps().GetCurrentHostUnit();
					}
					else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
					{
						activeUnit = this.list_1[0].GetHostUnit(Client.GetClientScenario());
					}
					if (Information.IsNothing(activeUnit))
					{
						num = 0;
					}
					else
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								if (!bool_2 || !Conversions.ToBoolean(dataRow["Optional"]))
								{
									int num3 = Conversions.ToInteger(dataRow["ComponentID"]);
									int num4 = Conversions.ToInteger(dataRow["Quantity"]);
									if (num4 == 0)
									{
										num = 0;
										result = 0;
										return result;
									}
									int dBID_ = num3;
									Scenario clientScenario = Client.GetClientScenario();
									if (!Weapon.IsNotLaunchableFireWeapon(dBID_, ref clientScenario))
									{
										int weaponLoadsInMagazines = activeUnit.GetWeaponry().GetWeaponLoadsInMagazines(num3);
										int num5 = 0;
										if (!Information.IsNothing(dictionary_1) && dictionary_1.ContainsKey(num3))
										{
											num5 = dictionary_1[num3];
										}
										int num6 = (weaponLoadsInMagazines + num5) / num4;
										if (num6 < num2)
										{
											num2 = num6;
										}
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
						num = num2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101137", "");
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

		// Token: 0x060042AC RID: 17068 RVA: 0x00021892 File Offset: 0x0001FA92
		private void method_3(object sender, EventArgs e)
		{
			this.method_8(false, true, false, !Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags));
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000218B0 File Offset: 0x0001FAB0
		private void method_4(object sender, EventArgs e)
		{
			this.method_8(false, true, true, !Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags));
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00183DA4 File Offset: 0x00181FA4
		private void method_6(Dictionary<int, int> dictionary_1)
		{
			try
			{
				if (Conversions.ToInteger(this.dataTable_1.AsEnumerable().ElementAtOrDefault(0)["ID"]) > 4)
				{
					DataRow[] array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.ID));
					if (array.Count<DataRow>() > 0)
					{
						this.vmethod_16().Text = Conversions.ToString(array[0]["LoadoutRoleDescription"]);
						this.vmethod_38().Text = "挂载缺省武器状态 " + Conversions.ToString(array[0]["WinchesterShotgunDescription"]);
						this.vmethod_18().Text = "缺省攻击高度: " + Conversions.ToString(array[0]["AttackAltitude"]);
						this.vmethod_20().Text = "弹药库中可用挂载数: " + Conversions.ToString(array[0]["NumberOfLoadouts"]);
						this.vmethod_22().Text = "弹药库与当前选中飞机所有可用的挂载数: " + Conversions.ToString(array[0]["NumberOfLoadoutsIncludingMountedWeapons"]);
						this.vmethod_24().Text = "弹药库与当前选中飞机所有可用的挂载数，仅包括强制性武器(排除可选): " + Conversions.ToString(array[0]["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"]);
					}
					int iD = this.ID;
					SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
					bool flag = false;
					this.LoadoutWeaponsDataTable = DBFunctions.LoadLoadoutWeaponsData(iD, ref sQLiteConnection, ref flag);
					this.LoadoutWeaponsDataTable.Columns.Add("Available");
					this.LoadoutWeaponsDataTable.Columns.Add("AvailableTotal");
					IEnumerator enumerator = this.LoadoutWeaponsDataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							int num = Conversions.ToInteger(dataRow["ComponentID"]);
							int dBID_ = num;
							Scenario clientScenario = Client.GetClientScenario();
							if (Weapon.IsNotLaunchableFireWeapon(dBID_, ref clientScenario))
							{
								dataRow["Available"] = "-";
								dataRow["AvailableTotal"] = "-";
							}
							else if (!Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
							{
								ActiveUnit activeUnit = null;
								if (this.list_0.Count > 0)
								{
									if (!Information.IsNothing(this.list_0[0]))
									{
										activeUnit = this.list_0[0].GetAircraftAirOps().GetCurrentHostUnit();
									}
								}
								else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
								{
									activeUnit = this.list_1[0].GetHostUnit(Client.GetClientScenario());
								}
								int num2;
								if (!Information.IsNothing(activeUnit))
								{
									num2 = activeUnit.GetWeaponry().GetWeaponLoadsInMagazines(Conversions.ToInteger(dataRow["ComponentID"]));
								}
								else
								{
									num2 = 0;
								}
								int num3 = 0;
								if (!Information.IsNothing(dictionary_1) && dictionary_1.ContainsKey(num))
								{
									num3 = dictionary_1[num];
								}
								dataRow["Available"] = num2;
								dataRow["AvailableTotal"] = num2 + num3;
							}
							else
							{
								dataRow["Available"] = "无限制";
								dataRow["AvailableTotal"] = "无限制";
							}
							dataRow["Item"] = Misc.smethod_11(Conversions.ToString(dataRow["Item"]));
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.vmethod_2().AutoGenerateColumns = false;
					this.vmethod_2().DataSource = this.LoadoutWeaponsDataTable;
				}
				else
				{
					this.vmethod_16().Text = "";
					this.vmethod_18().Text = "";
					this.vmethod_38().Text = "";
					this.vmethod_20().Text = "";
					this.vmethod_22().Text = "";
					this.vmethod_24().Text = "";
					this.LoadoutWeaponsDataTable.Rows.Clear();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101138", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x0018423C File Offset: 0x0018243C
		private void method_7(object sender, EventArgs e)
		{
			if (this.list_0[0].GetAircraftAirOps().GetCurrentHostUnit().GetMagazines().Length > 0)
			{
				Client.magazines = new Magazines();
				Client.magazines.activeUnit_0 = this.list_0[0].GetAircraftAirOps().GetCurrentHostUnit();
				Client.magazines.Show();
			}
			else
			{
				Interaction.MsgBox("The current host for these aircraft has no magazines available.", MsgBoxStyle.OkOnly, "No mags!");
			}
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x001842B8 File Offset: 0x001824B8
		private void method_8(bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (this.list_0.Count > 0)
				{
					foreach (Aircraft current in this.list_0)
					{
						if (!Information.IsNothing(current.GetLoadout()) && bool_5)
						{
							current.GetAircraftAirOps().method_65();
						}
					}
				}
				bool flag = false;
                Aircraft current2X;

                foreach (Aircraft current2 in this.list_0)
				{
					Aircraft_AirOps aircraftAirOps = current2.GetAircraftAirOps();
					bool flag2 = false;
					if (aircraftAirOps.QuickTurnaround_Enabled && !this.vmethod_30().Checked && !flag)
					{
						if (aircraftAirOps.QuickTurnaround_SortiesFlown > 0)
						{
							MsgBoxResult msgBoxResult = Interaction.MsgBox("飞机" + current2.Name + "打开了快速出动选项,但是选定的挂载方案不支持快速出动. 您想保持这个新配置，然后解除战备状态吗?", MsgBoxStyle.YesNoCancel, "快速出动失效与解除战备状态?");
							if (msgBoxResult == MsgBoxResult.Yes)
							{
								aircraftAirOps.QuickTurnaround_Enabled = false;
                                current2X = current2;
                                aircraftAirOps.method_53(ref aircraftAirOps, ref current2X);
							}
							else if (msgBoxResult == MsgBoxResult.No)
							{
								flag2 = true;
							}
							else
							{
								flag = true;
							}
						}
						else
						{
							aircraftAirOps.method_55(ref aircraftAirOps);
						}
					}
					bool flag3 = false;
					if (aircraftAirOps.QuickTurnaround_Enabled && !flag)
					{
						Loadout loadout = DBFunctions.smethod_47(ref current2.m_Scenario, this.ID, false);
						if (aircraftAirOps.QuickTurnaround_SortiesFlown >= loadout.QT_MaxSorties && loadout.QuickTurnaround)
						{
							MsgBoxResult msgBoxResult2 = Interaction.MsgBox("飞机" + current2.Name + " has flown more Quick Turnaround sorties than the selected loadout allows. Do you want to switch to the new loadout and stand down?", MsgBoxStyle.YesNoCancel, "Stand Down?");
							if (msgBoxResult2 == MsgBoxResult.Yes)
							{
                                current2X = current2;
                                aircraftAirOps.method_53(ref aircraftAirOps, ref current2X);
								flag2 = false;
							}
							else if (msgBoxResult2 == MsgBoxResult.No)
							{
								flag3 = true;
							}
							else
							{
								flag = true;
							}
						}
						else if (!loadout.QuickTurnaround)
						{
							aircraftAirOps.method_55(ref aircraftAirOps);
						}
						if (!flag && aircraftAirOps.QuickTurnaround_SortiesFlown > 0)
						{
							float num = aircraftAirOps.QuickTurnaround_AirborneTime_Flown / (float)aircraftAirOps.QuickTurnaround_SortiesFlown;
							if ((double)num > (double)(current2.GetLoadout().QT_AirborneTime * 60) / (double)(this.vmethod_32().SelectedIndex + 2) && !flag)
							{
								bool flag4 = false;
								if (aircraftAirOps.QuickTurnaround_SortiesFlown <= this.vmethod_32().SelectedIndex + 2 - 2)
								{
									if (num + aircraftAirOps.QuickTurnaround_AirborneTime_Flown >= (float)(current2.GetLoadout().QT_AirborneTime * 60))
									{
										flag4 = true;
									}
								}
								else
								{
									flag4 = true;
								}
								if (flag4)
								{
									MsgBoxResult msgBoxResult3 = Interaction.MsgBox(string.Concat(new string[]
									{
										"飞机",
										current2.Name,
										"已经飞行",
										Conversions.ToString(aircraftAirOps.QuickTurnaround_SortiesFlown),
										"波次,最大飞行波次",
										Conversions.ToString(loadout.QT_MaxSorties),
										". 总留空时间：",
										Misc.GetTimeString((long)Math.Round((double)aircraftAirOps.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, false),
										"，允许留空时间",
										Misc.GetTimeString((long)(current2.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
										".完成飞完波次的平均留空时间：",
										Misc.GetTimeString((long)Math.Round((double)num), Aircraft_AirOps._Maintenance.const_0, false, false),
										"，大于剩余允许的留空时间. 为此，飞机需要解除战备状态.您想切换到这个新挂载方案，然后解除战备状态吗？"
									}), MsgBoxStyle.YesNoCancel, "Stand Down?");
									if (msgBoxResult3 == MsgBoxResult.Yes)
									{
                                        current2X = current2;
                                        aircraftAirOps.method_53(ref aircraftAirOps, ref current2X);
										flag2 = false;
									}
									else if (msgBoxResult3 == MsgBoxResult.No)
									{
										flag3 = true;
									}
									else
									{
										flag = true;
									}
								}
							}
						}
					}
					int loadoutDBID_;
					if (!Information.IsNothing(current2.GetLoadout()))
					{
						loadoutDBID_ = current2.GetLoadout().DBID;
					}
					else
					{
						loadoutDBID_ = 0;
					}
					current2.SetLoadout(null);
					current2.GetAircraftWeaponry().ClearWeapons();
					ActiveUnit currentHostUnit = aircraftAirOps.GetCurrentHostUnit();
					if (!flag3 && !flag)
					{
                        current2X = current2;
                        currentHostUnit.GetAirOps().RearmAircraft(ref current2X, this.ID, loadoutDBID_, bool_2, bool_4, bool_5, bool_3, true);
					}
					else
					{
                        current2X = current2;
                        currentHostUnit.GetAirOps().RearmAircraft(ref current2X, loadoutDBID_, loadoutDBID_, bool_2, bool_4, bool_5, bool_3, true);
					}
                    current2X = current2;

                    currentHostUnit.GetAirOps().RefuelAircraft(ref current2X);
					currentHostUnit.GetAirOps().RepairAircraft(ref current2X);
					if (bool_2)
					{
						AirFacility hostAirFacility = currentHostUnit.GetAirOps().method_19(current2);
						aircraftAirOps.SetHostAirFacility(hostAirFacility);
					}
					if (this.vmethod_30().CheckState != CheckState.Indeterminate)
					{
						if (!flag2 && !flag)
						{
							aircraftAirOps.QuickTurnaround_Enabled = this.vmethod_30().Checked;
						}
						if (!Information.IsNothing(this.nullable_0))
						{
							if (this.vmethod_32().SelectedIndex >= 0 && this.vmethod_32().SelectedIndex + 2 <= current2.GetLoadout().QT_MaxSorties)
							{
								aircraftAirOps.QuickTurnaround_SortiesTotal = this.vmethod_32().SelectedIndex + 2;
							}
							else
							{
								this.nullable_0 = null;
							}
						}
						else if (!flag2 && !flag && !this.vmethod_30().Checked)
						{
							aircraftAirOps.QuickTurnaround_SortiesTotal = 0;
						}
					}
					if (!Information.IsNothing(current2.GetAssignedMission(false)))
					{
						current2.GetAssignedMission(false).int_0 = 1;
					}
				}
				if (!Information.IsNothing(this.list_1))
				{
					foreach (Mission.EmptySlot current3 in this.list_1)
					{
						current3.LoadoutDBID = this.ID;
						current3.Loadout_ExcludeOptionalWeapons = bool_4;
						if (!flag)
						{
							current3.Loadout_QuickTurnaround = this.vmethod_30().Checked;
						}
						if (!Information.IsNothing(this.nullable_0))
						{
							if (this.vmethod_32().SelectedIndex >= 0 && this.vmethod_32().SelectedIndex + 2 <= current3.Loadout_QuickTurnaround_MaxSorties)
							{
								current3.Loadout_QuickTurnaround_NumberOfSorties = this.vmethod_32().SelectedIndex + 2;
							}
							else
							{
								this.nullable_0 = null;
							}
						}
						else if (!flag && !this.vmethod_30().Checked)
						{
							current3.Loadout_QuickTurnaround_NumberOfSorties = 0;
						}
						Scenario clientScenario = Client.GetClientScenario();
						Loadout loadout2 = DBFunctions.smethod_47(ref clientScenario, this.ID, false);
						current3.LoadoutName = loadout2.Name;
						current3.Loadout_QuickTurnaround_MaxSorties = loadout2.QT_MaxSorties;
					}
				}
				if (CommandFactory.GetCommandMain().GetAirOps().Visible)
				{
					CommandFactory.GetCommandMain().GetAirOps().method_6();
				}
				if (!Information.IsNothing(Client.GetMissionEditor()) && Client.GetMissionEditor().Visible)
				{
					Client.GetMissionEditor().method_1();
				}
				this.Cursor = Cursors.Default;
				if (!flag)
				{
					base.Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101139", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x000218CE File Offset: 0x0001FACE
		private void method_9(object sender, EventArgs e)
		{
			this.method_8(true, true, false, !Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags));
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x000218EC File Offset: 0x0001FAEC
		private void method_10(object sender, EventArgs e)
		{
			this.method_8(true, true, false, false);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x001849FC File Offset: 0x00182BFC
		private void method_11(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.ID = Conversions.ToInteger(this.vmethod_14().Rows[e.RowIndex].Cells["ID"].Value);
				if (this.method_2(this.ID, this.dictionary_0, false) > 0)
				{
					this.method_8(false, true, false, true);
				}
			}
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x00184A70 File Offset: 0x00182C70
		private void method_12(object sender, EventArgs e)
		{
			if (this.vmethod_14().SelectedRows.Count != 0)
			{
				this.ID = Conversions.ToInteger(this.vmethod_14().SelectedRows[0].Cells["ID"].Value);
				if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
				{
					this.vmethod_4().Enabled = true;
					this.vmethod_28().Enabled = true;
					this.vmethod_12().Enabled = false;
					this.vmethod_26().Enabled = false;
				}
				else
				{
					this.vmethod_4().Enabled = (this.method_2(this.ID, this.dictionary_0, false) > 0);
					this.vmethod_28().Enabled = (this.method_2(this.ID, this.dictionary_0, true) > 0);
					this.vmethod_12().Enabled = this.vmethod_4().Enabled;
					this.vmethod_26().Enabled = true;
				}
				this.method_6(this.dictionary_0);
				this.method_13();
			}
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x00184B90 File Offset: 0x00182D90
		private void method_13()
		{
			bool flag = true;
			int num = 0;
			int num2 = 0;
			Aircraft aircraft = null;
			if (!Information.IsNothing(this.list_0) && this.list_0.Count > 0)
			{
				aircraft = this.list_0[0];
			}
			DataRow[] array = null;
			bool? flag2 = null;
			if (!Information.IsNothing(aircraft) && !Information.IsNothing(aircraft.GetLoadout()) && this.hashSet_0.Count == 1 && this.hashSet_0.ElementAtOrDefault(0) == this.ID)
			{
				array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.hashSet_0.ElementAtOrDefault(0)));
				if (array.Count<DataRow>() > 0)
				{
					Doctrine._AirOpsTempo? airOpsTempoDoctrine = aircraft.m_Doctrine.GetAirOpsTempoDoctrine(aircraft.m_Scenario, false, false, false, false);
					byte? b = airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						this.string_0 = Misc.GetTimeString((long)(aircraft.GetLoadout().int_3 * 60), Aircraft_AirOps._Maintenance.const_0, false, false);
					}
					else
					{
						this.string_0 = Misc.GetTimeString((long)(aircraft.GetLoadout().ReadyTime * 60), Aircraft_AirOps._Maintenance.const_0, false, false);
					}
					this.bool_0 = aircraft.GetLoadout().QuickTurnaround;
					this.int_2 = aircraft.GetLoadout().QT_ReadyTime;
					this.int_3 = aircraft.GetLoadout().QT_MaxSorties;
					this.int_4 = aircraft.GetLoadout().QT_AdditionalTimePenalty;
					this.int_1 = aircraft.GetLoadout().QT_AirborneTime;
				}
				foreach (Aircraft current in this.list_0)
				{
					num++;
					Aircraft_AirOps aircraftAirOps = current.GetAircraftAirOps();
					if (num == 1)
					{
						flag2 = new bool?(aircraftAirOps.QuickTurnaround_Enabled);
						this.nullable_0 = new int?(aircraftAirOps.QuickTurnaround_SortiesTotal);
					}
					else
					{
						bool flag3 = aircraftAirOps.QuickTurnaround_Enabled;
						if ((flag2.HasValue ? new bool?(flag3 != flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(flag2))
						{
							flag2 = null;
						}
						int num3 = aircraftAirOps.QuickTurnaround_SortiesTotal;
						int? num4 = this.nullable_0;
						if ((num4.HasValue ? new bool?(num3 != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(this.nullable_0))
						{
							this.nullable_0 = null;
						}
					}
				}
				if (Information.IsNothing(this.list_1))
				{
					goto IL_72A;
				}
				using (List<Mission.EmptySlot>.Enumerator enumerator2 = this.list_1.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Mission.EmptySlot current2 = enumerator2.Current;
						num2++;
						if (num > 0 && num2 == 1)
						{
							flag2 = new bool?(current2.Loadout_QuickTurnaround);
							this.nullable_0 = new int?(current2.Loadout_QuickTurnaround_NumberOfSorties);
						}
						else
						{
							bool flag3 = current2.Loadout_QuickTurnaround;
							if ((flag2.HasValue ? new bool?(flag3 != flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(flag2))
							{
								flag2 = null;
							}
							int num3 = current2.Loadout_QuickTurnaround_NumberOfSorties;
							int? num4 = this.nullable_0;
							if ((num4.HasValue ? new bool?(num3 != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(this.nullable_0))
							{
								this.nullable_0 = null;
							}
						}
					}
					goto IL_72A;
				}
			}
			if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0 && this.hashSet_0.Count == 1 && this.hashSet_0.ElementAtOrDefault(0) == this.ID)
			{
				array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.ID));
				if (array.Count<DataRow>() > 0)
				{
					this.string_0 = Conversions.ToString(array[0]["ReadyTime"]);
					this.bool_0 = Conversions.ToBoolean(array[0]["QuickTurnaround"]);
					this.int_2 = Conversions.ToInteger(array[0]["QuickTurnaround_ReadyTime"]);
					this.int_3 = Conversions.ToInteger(array[0]["QuickTurnaround_MaxSorties"]);
					this.int_4 = Conversions.ToInteger(array[0]["QuickTurnaround_AdditionalTimePenalty"]);
					this.int_1 = Conversions.ToInteger(array[0]["QuickTurnaround_AirborneTime"]);
				}
				using (List<Mission.EmptySlot>.Enumerator enumerator3 = this.list_1.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						Mission.EmptySlot current3 = enumerator3.Current;
						num2++;
						if (num2 == 1)
						{
							flag2 = new bool?(current3.Loadout_QuickTurnaround);
							this.nullable_0 = new int?(current3.Loadout_QuickTurnaround_NumberOfSorties);
						}
						else
						{
							bool flag3 = current3.Loadout_QuickTurnaround;
							if ((flag2.HasValue ? new bool?(flag3 != flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(flag2))
							{
								flag2 = null;
							}
							int num3 = current3.Loadout_QuickTurnaround_NumberOfSorties;
							int? num4 = this.nullable_0;
							if ((num4.HasValue ? new bool?(num3 != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(this.nullable_0))
							{
								this.nullable_0 = null;
							}
						}
					}
					goto IL_72A;
				}
			}
			array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.ID));
			if (array.Count<DataRow>() > 0)
			{
				this.string_0 = Conversions.ToString(array[0]["ReadyTime"]);
				this.bool_0 = Conversions.ToBoolean(array[0]["QuickTurnaround"]);
				this.int_2 = Conversions.ToInteger(array[0]["QuickTurnaround_ReadyTime"]);
				this.int_3 = Conversions.ToInteger(array[0]["QuickTurnaround_MaxSorties"]);
				this.int_4 = Conversions.ToInteger(array[0]["QuickTurnaround_AdditionalTimePenalty"]);
				this.int_1 = Conversions.ToInteger(array[0]["QuickTurnaround_AirborneTime"]);
			}
			IL_72A:
			if (this.bool_0)
			{
				if (!Information.IsNothing(aircraft))
				{
					Doctrine._QuickTurnAround? quickTurnAroundDoctrine = aircraft.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft.m_Scenario, false, false, false, false);
					byte? b = quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						flag = false;
					}
					else
					{
						quickTurnAroundDoctrine = aircraft.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft.m_Scenario, false, false, false, false);
						b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							if (array.Count<DataRow>() > 0)
							{
								Loadout loadout = new Loadout(Conversions.ToInteger(array[0]["ID"]), Conversions.ToString(array[0]["Name"]), 0, 0, 0, 0, (Loadout.LoadoutRole)Conversions.ToInteger(array[0]["LoadoutRole"]), (Loadout._LoadoutDayNight)0, Loadout._WeatherProfile.AllWeather, 0f, 0, 0, false, false, Conversions.ToBoolean(array[0]["QuickTurnaround"]), Conversions.ToInteger(array[0]["QuickTurnaround_ReadyTime"]), Conversions.ToInteger(array[0]["QuickTurnaround_MaxSorties"]), Conversions.ToInteger(array[0]["QuickTurnaround_AdditionalTimePenalty"]), Conversions.ToInteger(array[0]["QuickTurnaround_AirborneTime"]), (Loadout._LoadoutDayNight)1, Doctrine._WeaponState.LoadoutSetting);
								if (!loadout.method_13() && !loadout.method_15() && !loadout.LoadoutRoleIsASWPatrol())
								{
									flag = false;
								}
							}
							else
							{
								flag = false;
							}
						}
					}
				}
				else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
				{
				}
			}
			else
			{
				flag = false;
			}
			this.bool_1 = false;
			if (this.hashSet_0.Count == 1 && this.hashSet_0.ElementAtOrDefault(0) == this.ID)
			{
				if (flag)
				{
					this.vmethod_30().Enabled = true;
					if (Information.IsNothing(flag2))
					{
						this.vmethod_30().CheckState = CheckState.Indeterminate;
						this.method_20(this.nullable_0);
						this.vmethod_32().Enabled = false;
						this.vmethod_34().Enabled = true;
						this.vmethod_34().Text = "Selection includes aircraft with and without the Quick Turnaround option set.";
					}
					else if (flag2.GetValueOrDefault())
					{
						if (this.vmethod_30().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_30().CheckState = CheckState.Checked;
						}
						else
						{
							this.vmethod_30().Checked = true;
						}
						this.method_20(this.nullable_0);
						this.vmethod_32().Enabled = true;
						this.vmethod_34().Enabled = true;
						if (!Information.IsNothing(this.nullable_0))
						{
							this.vmethod_34().Text = Conversions.ToString(this.method_17());
						}
						else
						{
							this.vmethod_34().Text = "";
						}
					}
					else
					{
						if (this.vmethod_30().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_30().CheckState = CheckState.Unchecked;
						}
						else
						{
							this.vmethod_30().Checked = false;
						}
						this.method_20(new int?(this.int_3));
					}
				}
				else
				{
					this.vmethod_30().Enabled = false;
					if (this.vmethod_30().CheckState == CheckState.Indeterminate)
					{
						this.vmethod_30().CheckState = CheckState.Unchecked;
					}
					else
					{
						this.vmethod_30().Checked = false;
					}
					this.method_20(new int?(0));
				}
			}
			else
			{
				if (flag)
				{
					if (this.bool_0)
					{
						this.vmethod_30().Enabled = true;
						if (this.vmethod_30().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_30().CheckState = CheckState.Unchecked;
						}
						else
						{
							this.vmethod_30().Checked = false;
						}
					}
					else
					{
						this.vmethod_30().Enabled = false;
						if (this.vmethod_30().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_30().CheckState = CheckState.Unchecked;
						}
						else
						{
							this.vmethod_30().Checked = false;
						}
					}
				}
				else
				{
					this.vmethod_30().Enabled = false;
					if (this.vmethod_30().CheckState == CheckState.Indeterminate)
					{
						this.vmethod_30().CheckState = CheckState.Unchecked;
					}
					else
					{
						this.vmethod_30().Checked = false;
					}
				}
				this.method_20(new int?(this.int_3));
			}
			this.bool_1 = true;
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x001857D0 File Offset: 0x001839D0
		private void method_14(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && this.vmethod_2().Columns[e.ColumnIndex].CellType == typeof(DataGridViewLinkCell))
			{
				int dBID = Conversions.ToInteger(this.LoadoutWeaponsDataTable.Rows[e.RowIndex]["ComponentID"]);
				Client.ShowDBInfo("武器", dBID);
			}
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x0018584C File Offset: 0x00183A4C
		private void method_15(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if (!Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
				{
					DataGridViewRow dataGridViewRow = this.vmethod_14().Rows[e.RowIndex];
					if (Operators.CompareString(this.vmethod_14().Columns[e.ColumnIndex].Name, "NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly", false) == 0 && (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Value)) || Conversions.ToInteger(e.Value) <= 0) && !Operators.ConditionalCompareObjectEqual(e.Value, "Unlimited", false))
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.LightGray;
						dataGridViewRow.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
						dataGridViewRow.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Italic);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200110", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0018596C File Offset: 0x00183B6C
		private void ReadyAircraft_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.Return && base.Visible)
			{
				if (this.method_2(this.ID, this.dictionary_0, false) > 0)
				{
					this.method_8(false, true, false, true);
				}
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00185A54 File Offset: 0x00183C54
		private void method_16(object sender, EventArgs e)
		{
			this.vmethod_34().Text = Conversions.ToString(this.method_17());
			if (this.bool_1)
			{
				if (this.vmethod_32().SelectedIndex + 2 <= this.int_3 && this.vmethod_32().SelectedIndex >= 0)
				{
					this.nullable_0 = new int?(this.vmethod_32().SelectedIndex + 2);
				}
				else
				{
					this.nullable_0 = null;
				}
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00185AD0 File Offset: 0x00183CD0
		private object method_17()
		{
			object result;
			if (this.vmethod_32().SelectedIndex + 2 <= this.int_3)
			{
				result = string.Concat(new string[]
				{
					Conversions.ToString(this.vmethod_32().SelectedIndex + 2),
					" 波次@",
					Misc.GetTimeString((long)(this.int_1 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					"最大留空时间，",
					Misc.GetTimeString((long)(this.int_2 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					"一次往返, ",
					this.string_0,
					"休整准备时间"
				});
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00185B78 File Offset: 0x00183D78
		private void method_18(int? nullable_1)
		{
			this.vmethod_32().Items.Clear();
			if (this.vmethod_30().CheckState != CheckState.Indeterminate && this.vmethod_30().Checked)
			{
				int num = this.int_3;
				for (int i = 2; i <= num; i++)
				{
					if (i == this.int_3)
					{
						this.vmethod_32().Items.Add(Conversions.ToString(i) + "波次(最大)");
					}
					else
					{
						this.vmethod_32().Items.Add(Conversions.ToString(i) + "波次");
					}
				}
				if (!Information.IsNothing(nullable_1) && this.vmethod_32().Items.Count > 0)
				{
					this.vmethod_32().SelectedIndex = this.vmethod_32().Items.Count - 1;
				}
				else
				{
					this.vmethod_32().Items.Add("Various");
					this.vmethod_32().SelectedIndex = this.vmethod_32().Items.Count - 1;
				}
			}
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000218F8 File Offset: 0x0001FAF8
		private void method_19(object sender, EventArgs e)
		{
			this.method_20(new int?(this.int_3));
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00185CA0 File Offset: 0x00183EA0
		private void method_20(int? nullable_1)
		{
			if (this.vmethod_30().Checked)
			{
				this.vmethod_32().Enabled = true;
				this.method_18(nullable_1);
				this.vmethod_34().Enabled = true;
				this.vmethod_34().Text = Conversions.ToString(this.method_17());
			}
			else
			{
				this.vmethod_32().Enabled = false;
				this.method_18(nullable_1);
				this.vmethod_34().Enabled = false;
				this.vmethod_34().Text = "";
			}
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x0002190B File Offset: 0x0001FB0B
		private void method_21(object sender, EventArgs e)
		{
			this.method_1();
			if (this.vmethod_36().Checked)
			{
				SimConfiguration.gameOptions.SetOnlyShowAvailableLoadouts(true);
			}
			else
			{
				SimConfiguration.gameOptions.SetOnlyShowAvailableLoadouts(false);
			}
		}

		// Token: 0x04001EEF RID: 7919
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001EF0 RID: 7920
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001EF1 RID: 7921
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001EF2 RID: 7922
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001EF3 RID: 7923
		[CompilerGenerated]
		private MenuStrip menuStrip_0;

		// Token: 0x04001EF4 RID: 7924
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04001EF5 RID: 7925
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001EF6 RID: 7926
		[CompilerGenerated]
		private DataGridView dataGridView_1;

		// Token: 0x04001EF7 RID: 7927
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001EF8 RID: 7928
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001EF9 RID: 7929
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001EFA RID: 7930
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001EFB RID: 7931
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04001EFC RID: 7932
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001EFD RID: 7933
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x04001EFE RID: 7934
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001EFF RID: 7935
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001F00 RID: 7936
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04001F01 RID: 7937
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04001F02 RID: 7938
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04001F03 RID: 7939
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001F04 RID: 7940
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x04001F05 RID: 7941
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001F06 RID: 7942
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04001F07 RID: 7943
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04001F08 RID: 7944
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04001F09 RID: 7945
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04001F0A RID: 7946
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04001F0B RID: 7947
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04001F0C RID: 7948
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x04001F0D RID: 7949
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x04001F0E RID: 7950
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x04001F0F RID: 7951
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x04001F10 RID: 7952
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x04001F11 RID: 7953
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x04001F12 RID: 7954
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x04001F13 RID: 7955
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		// Token: 0x04001F14 RID: 7956
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		// Token: 0x04001F15 RID: 7957
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		// Token: 0x04001F16 RID: 7958
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		// Token: 0x04001F17 RID: 7959
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		// Token: 0x04001F18 RID: 7960
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		// Token: 0x04001F19 RID: 7961
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		// Token: 0x04001F1A RID: 7962
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		// Token: 0x04001F1B RID: 7963
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		// Token: 0x04001F1C RID: 7964
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		// Token: 0x04001F1D RID: 7965
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		// Token: 0x04001F1E RID: 7966
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		// Token: 0x04001F1F RID: 7967
		public List<Aircraft> list_0;

		// Token: 0x04001F20 RID: 7968
		public List<Mission.EmptySlot> list_1;

		// Token: 0x04001F21 RID: 7969
		public int ID;

		// Token: 0x04001F22 RID: 7970
		private DataTable LoadoutWeaponsDataTable;

		// Token: 0x04001F23 RID: 7971
		private DataTable dataTable_1;

		// Token: 0x04001F24 RID: 7972
		private Dictionary<int, int> dictionary_0;

		// Token: 0x04001F25 RID: 7973
		private HashSet<int> hashSet_0;

		// Token: 0x04001F26 RID: 7974
		private string string_0;

		// Token: 0x04001F27 RID: 7975
		private bool bool_0;

		// Token: 0x04001F28 RID: 7976
		private int int_1;

		// Token: 0x04001F29 RID: 7977
		private int int_2;

		// Token: 0x04001F2A RID: 7978
		private int int_3;

		// Token: 0x04001F2B RID: 7979
		private int int_4;

		// Token: 0x04001F2C RID: 7980
		private int? nullable_0;

		// Token: 0x04001F2D RID: 7981
		private bool bool_1;
	}
}
