using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns29;
using ns3;
using ns32;
using ns33;
using ns4;

namespace Command
{
	// Token: 0x02000B50 RID: 2896
	[DesignerGenerated]
	public sealed partial class DoctrineForm : CommandForm
	{
		// Token: 0x06005D69 RID: 23913 RVA: 0x002B4D20 File Offset: 0x002B2F20
		public DoctrineForm()
		{
			base.Load += new EventHandler(this.DoctrineForm_Load);
			base.KeyDown += new KeyEventHandler(this.DoctrineForm_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.DoctrineForm_FormClosed);
			base.FormClosing += new FormClosingEventHandler(this.DoctrineForm_FormClosing);
			this.collection_1 = new Collection<int>();
			this.bool_2 = true;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.InitializeComponent();
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x002BADA4 File Offset: 0x002B8FA4
		[CompilerGenerated]
		internal  TabControl vmethod_0()
		{
			return this.tabControl_0;
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x002BADBC File Offset: 0x002B8FBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TabControl tabControl_1)
		{
			EventHandler value = new EventHandler(this.method_13);
			TabControl tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value;
			}
			this.tabControl_0 = tabControl_1;
			tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x002BAE08 File Offset: 0x002B9008
		[CompilerGenerated]
		internal  TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x00029822 File Offset: 0x00027A22
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_4)
		{
			this.tabPage_0 = tabPage_4;
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x002BAE20 File Offset: 0x002B9020
		[CompilerGenerated]
		internal  TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x0002982B File Offset: 0x00027A2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_4)
		{
			this.tabPage_1 = tabPage_4;
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x002BAE38 File Offset: 0x002B9038
		[CompilerGenerated]
		internal  ComboBox GetCB_EMCON_Radar()
		{
			return this.comboBox_0;
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x002BAE50 File Offset: 0x002B9050
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_52);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_41;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x002BAE9C File Offset: 0x002B909C
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_0;
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x00029834 File Offset: 0x00027A34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_51)
		{
			this.label_0 = label_51;
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x002BAEB4 File Offset: 0x002B90B4
		[CompilerGenerated]
		internal  CheckBox GetCB_EMCON_Inherits()
		{
			return this.checkBox_0;
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x002BAECC File Offset: 0x002B90CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_51);
			MouseEventHandler value2 = new MouseEventHandler(this.method_103);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
				checkBox.MouseUp -= value2;
			}
			this.checkBox_0 = checkBox_31;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
				checkBox.MouseUp += value2;
			}
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x002BAF30 File Offset: 0x002B9130
		[CompilerGenerated]
		internal  ComboBox GetCB_EMCON_OECM()
		{
			return this.comboBox_1;
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x002BAF48 File Offset: 0x002B9148
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_53);
			ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_41;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x002BAF94 File Offset: 0x002B9194
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_1;
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x0002983D File Offset: 0x00027A3D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_51)
		{
			this.label_1 = label_51;
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x002BAFAC File Offset: 0x002B91AC
		[CompilerGenerated]
		internal  ComboBox GetCB_EMCON_Sonar()
		{
			return this.comboBox_2;
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x002BAFC4 File Offset: 0x002B91C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_54);
			ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_41;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x002BB010 File Offset: 0x002B9210
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x00029846 File Offset: 0x00027A46
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_51)
		{
			this.label_2 = label_51;
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x002BB028 File Offset: 0x002B9228
		[CompilerGenerated]
		internal  TabPage vmethod_20()
		{
			return this.tabPage_2;
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x0002984F File Offset: 0x00027A4F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TabPage tabPage_4)
		{
			this.tabPage_2 = tabPage_4;
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x002BB040 File Offset: 0x002B9240
		[CompilerGenerated]
		internal  TreeGridView GetTGV_WRA()
		{
			return this.TGV_WRA;
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x002BB058 File Offset: 0x002B9258
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTGV_WRA(TreeGridView treeGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.TGV_WRA_CellClick);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.TGV_WRA_CellValueChanged);
			EventHandler value3 = new EventHandler(this.TGV_WRA_CellValueChanged_CurrentCellDirtyStateChanged);
			Delegate41 delegate41_ = new Delegate41(this.method_92);
			Delegate43 delegate43_ = new Delegate43(this.method_93);
			DataGridViewDataErrorEventHandler value4 = new DataGridViewDataErrorEventHandler(this.TGV_WRA_DataError);
			TreeGridView tGV_WRA = this.TGV_WRA;
			if (tGV_WRA != null)
			{
				tGV_WRA.CellClick -= value;
				tGV_WRA.CellValueChanged -= value2;
				tGV_WRA.CurrentCellDirtyStateChanged -= value3;
				tGV_WRA.method_11(delegate41_);
				tGV_WRA.method_13(delegate43_);
				tGV_WRA.DataError -= value4;
			}
			this.TGV_WRA = treeGridView_1;
			tGV_WRA = this.TGV_WRA;
			if (tGV_WRA != null)
			{
				tGV_WRA.CellClick += value;
				tGV_WRA.CellValueChanged += value2;
				tGV_WRA.CurrentCellDirtyStateChanged += value3;
				tGV_WRA.method_10(delegate41_);
				tGV_WRA.method_12(delegate43_);
				tGV_WRA.DataError += value4;
			}
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x002BB140 File Offset: 0x002B9340
		[CompilerGenerated]
		internal  Button GetButton_ResetCurrent_WRA()
		{
			return this.button_0;
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x002BB158 File Offset: 0x002B9358
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_94);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_9;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x002BB1A4 File Offset: 0x002B93A4
		[CompilerGenerated]
		internal  TableLayoutPanel vmethod_26()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x00029858 File Offset: 0x00027A58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x002BB1BC File Offset: 0x002B93BC
		[CompilerGenerated]
		internal  Label vmethod_28()
		{
			return this.label_3;
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x00029861 File Offset: 0x00027A61
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Label label_51)
		{
			this.label_3 = label_51;
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x002BB1D4 File Offset: 0x002B93D4
		[CompilerGenerated]
		internal  Label vmethod_30()
		{
			return this.label_4;
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0002986A File Offset: 0x00027A6A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Label label_51)
		{
			this.label_4 = label_51;
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x002BB1EC File Offset: 0x002B93EC
		[CompilerGenerated]
		internal  Label vmethod_32()
		{
			return this.label_5;
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x00029873 File Offset: 0x00027A73
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Label label_51)
		{
			this.label_5 = label_51;
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x002BB204 File Offset: 0x002B9404
		[CompilerGenerated]
		internal  Label vmethod_34()
		{
			return this.label_6;
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x0002987C File Offset: 0x00027A7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_51)
		{
			this.label_6 = label_51;
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x002BB21C File Offset: 0x002B941C
		[CompilerGenerated]
		internal  Label vmethod_36()
		{
			return this.label_7;
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x00029885 File Offset: 0x00027A85
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Label label_51)
		{
			this.label_7 = label_51;
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x002BB234 File Offset: 0x002B9434
		[CompilerGenerated]
		internal  Label vmethod_38()
		{
			return this.label_8;
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0002988E File Offset: 0x00027A8E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Label label_51)
		{
			this.label_8 = label_51;
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x002BB24C File Offset: 0x002B944C
		[CompilerGenerated]
		internal  Label vmethod_40()
		{
			return this.label_9;
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x00029897 File Offset: 0x00027A97
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Label label_51)
		{
			this.label_9 = label_51;
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x002BB264 File Offset: 0x002B9464
		[CompilerGenerated]
		internal  CheckBox vmethod_42()
		{
			return this.checkBox_1;
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x002BB27C File Offset: 0x002B947C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_50);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_31;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x002BB2C8 File Offset: 0x002B94C8
		[CompilerGenerated]
		internal  Label vmethod_44()
		{
			return this.label_10;
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x000298A0 File Offset: 0x00027AA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Label label_51)
		{
			this.label_10 = label_51;
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x002BB2E0 File Offset: 0x002B94E0
		[CompilerGenerated]
		internal  CheckBox vmethod_46()
		{
			return this.checkBox_2;
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x002BB2F8 File Offset: 0x002B94F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_18);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_2 = checkBox_31;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x002BB344 File Offset: 0x002B9544
		[CompilerGenerated]
		internal  CheckBox vmethod_48()
		{
			return this.checkBox_3;
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x002BB35C File Offset: 0x002B955C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_15);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_3 = checkBox_31;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x002BB3A8 File Offset: 0x002B95A8
		[CompilerGenerated]
		internal  Label vmethod_50()
		{
			return this.label_11;
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x000298A9 File Offset: 0x00027AA9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Label label_51)
		{
			this.label_11 = label_51;
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x002BB3C0 File Offset: 0x002B95C0
		[CompilerGenerated]
		internal  ComboBox vmethod_52()
		{
			return this.comboBox_3;
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x002BB3D8 File Offset: 0x002B95D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_55);
			EventHandler value2 = new EventHandler(this.method_56);
			ComboBox comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_3 = comboBox_41;
			comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x002BB43C File Offset: 0x002B963C
		[CompilerGenerated]
		internal  ComboBox vmethod_54()
		{
			return this.comboBox_4;
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x002BB454 File Offset: 0x002B9654
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_33);
			EventHandler value2 = new EventHandler(this.method_44);
			ComboBox comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_4 = comboBox_41;
			comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x002BB4B8 File Offset: 0x002B96B8
		[CompilerGenerated]
		internal  ComboBox vmethod_56()
		{
			return this.comboBox_5;
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x002BB4D0 File Offset: 0x002B96D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_27);
			EventHandler value2 = new EventHandler(this.method_38);
			ComboBox comboBox = this.comboBox_5;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_5 = comboBox_41;
			comboBox = this.comboBox_5;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x002BB534 File Offset: 0x002B9734
		[CompilerGenerated]
		internal  Label vmethod_58()
		{
			return this.label_12;
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x000298B2 File Offset: 0x00027AB2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Label label_51)
		{
			this.label_12 = label_51;
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x002BB54C File Offset: 0x002B974C
		[CompilerGenerated]
		internal  ComboBox GetCombo_BehaviorTowardsAmbigousTarget()
		{
			return this.comboBox_6;
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x002BB564 File Offset: 0x002B9764
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_61);
			EventHandler value2 = new EventHandler(this.method_62);
			ComboBox comboBox = this.comboBox_6;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_6 = comboBox_41;
			comboBox = this.comboBox_6;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x002BB5C8 File Offset: 0x002B97C8
		[CompilerGenerated]
		internal  CheckBox vmethod_62()
		{
			return this.checkBox_4;
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x002BB5E0 File Offset: 0x002B97E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_63);
			CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_4 = checkBox_31;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x002BB62C File Offset: 0x002B982C
		[CompilerGenerated]
		internal  Label vmethod_64()
		{
			return this.label_13;
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x000298BB File Offset: 0x00027ABB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Label label_51)
		{
			this.label_13 = label_51;
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x002BB644 File Offset: 0x002B9844
		[CompilerGenerated]
		internal  ComboBox vmethod_66()
		{
			return this.comboBox_7;
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x002BB65C File Offset: 0x002B985C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_64);
			EventHandler value2 = new EventHandler(this.method_65);
			ComboBox comboBox = this.comboBox_7;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_7 = comboBox_41;
			comboBox = this.comboBox_7;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x002BB6C0 File Offset: 0x002B98C0
		[CompilerGenerated]
		internal  CheckBox vmethod_68()
		{
			return this.checkBox_5;
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x002BB6D8 File Offset: 0x002B98D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_66);
			CheckBox checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_5 = checkBox_31;
			checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x002BB724 File Offset: 0x002B9924
		[CompilerGenerated]
		internal  ComboBox vmethod_70()
		{
			return this.comboBox_8;
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x002BB73C File Offset: 0x002B993C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_68);
			EventHandler value2 = new EventHandler(this.method_128);
			ComboBox comboBox = this.comboBox_8;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_8 = comboBox_41;
			comboBox = this.comboBox_8;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x002BB7A0 File Offset: 0x002B99A0
		[CompilerGenerated]
		internal  CheckBox vmethod_72()
		{
			return this.checkBox_6;
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x002BB7B8 File Offset: 0x002B99B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_67);
			CheckBox checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_6 = checkBox_31;
			checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x002BB804 File Offset: 0x002B9A04
		[CompilerGenerated]
		internal  ComboBox vmethod_74()
		{
			return this.comboBox_9;
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x002BB81C File Offset: 0x002B9A1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_71);
			EventHandler value2 = new EventHandler(this.method_72);
			ComboBox comboBox = this.comboBox_9;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_9 = comboBox_41;
			comboBox = this.comboBox_9;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x002BB880 File Offset: 0x002B9A80
		[CompilerGenerated]
		internal  CheckBox vmethod_76()
		{
			return this.checkBox_7;
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x002BB898 File Offset: 0x002B9A98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_23);
			CheckBox checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_7 = checkBox_31;
			checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x002BB8E4 File Offset: 0x002B9AE4
		[CompilerGenerated]
		internal  ComboBox vmethod_78()
		{
			return this.comboBox_10;
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x002BB8FC File Offset: 0x002B9AFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_69);
			EventHandler value2 = new EventHandler(this.method_70);
			ComboBox comboBox = this.comboBox_10;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_10 = comboBox_41;
			comboBox = this.comboBox_10;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x002BB960 File Offset: 0x002B9B60
		[CompilerGenerated]
		internal  CheckBox vmethod_80()
		{
			return this.checkBox_8;
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x002BB978 File Offset: 0x002B9B78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_75);
			CheckBox checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_8 = checkBox_31;
			checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x002BB9C4 File Offset: 0x002B9BC4
		[CompilerGenerated]
		internal  ComboBox vmethod_82()
		{
			return this.comboBox_11;
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x002BB9DC File Offset: 0x002B9BDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_76);
			EventHandler value2 = new EventHandler(this.method_77);
			EventHandler value3 = new EventHandler(this.method_78);
			ComboBox comboBox = this.comboBox_11;
			if (comboBox != null)
			{
				comboBox.Click -= value;
				comboBox.Enter -= value2;
				comboBox.SelectionChangeCommitted -= value3;
			}
			this.comboBox_11 = comboBox_41;
			comboBox = this.comboBox_11;
			if (comboBox != null)
			{
				comboBox.Click += value;
				comboBox.Enter += value2;
				comboBox.SelectionChangeCommitted += value3;
			}
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x002BBA5C File Offset: 0x002B9C5C
		[CompilerGenerated]
		internal  CheckBox vmethod_84()
		{
			return this.checkBox_9;
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x002BBA74 File Offset: 0x002B9C74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_25);
			EventHandler value2 = new EventHandler(this.method_25);
			CheckBox checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
				checkBox.Click -= value2;
			}
			this.checkBox_9 = checkBox_31;
			checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
				checkBox.Click += value2;
			}
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x002BBAD8 File Offset: 0x002B9CD8
		[CompilerGenerated]
		internal  ComboBox vmethod_86()
		{
			return this.comboBox_12;
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x002BBAF0 File Offset: 0x002B9CF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_79);
			EventHandler value2 = new EventHandler(this.method_80);
			EventHandler value3 = new EventHandler(this.method_81);
			ComboBox comboBox = this.comboBox_12;
			if (comboBox != null)
			{
				comboBox.Click -= value;
				comboBox.Enter -= value2;
				comboBox.SelectionChangeCommitted -= value3;
			}
			this.comboBox_12 = comboBox_41;
			comboBox = this.comboBox_12;
			if (comboBox != null)
			{
				comboBox.Click += value;
				comboBox.Enter += value2;
				comboBox.SelectionChangeCommitted += value3;
			}
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x002BBB70 File Offset: 0x002B9D70
		[CompilerGenerated]
		internal  CheckBox vmethod_88()
		{
			return this.checkBox_10;
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x002BBB88 File Offset: 0x002B9D88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_22);
			CheckBox checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_10 = checkBox_31;
			checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x002BBBD4 File Offset: 0x002B9DD4
		[CompilerGenerated]
		internal  Label vmethod_90()
		{
			return this.label_14;
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x000298C4 File Offset: 0x00027AC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Label label_51)
		{
			this.label_14 = label_51;
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x002BBBEC File Offset: 0x002B9DEC
		[CompilerGenerated]
		internal  ComboBox vmethod_92()
		{
			return this.comboBox_13;
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x002BBC04 File Offset: 0x002B9E04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_28);
			EventHandler value2 = new EventHandler(this.method_39);
			ComboBox comboBox = this.comboBox_13;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_13 = comboBox_41;
			comboBox = this.comboBox_13;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x002BBC68 File Offset: 0x002B9E68
		[CompilerGenerated]
		internal  ComboBox vmethod_94()
		{
			return this.comboBox_14;
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x002BBC80 File Offset: 0x002B9E80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_32);
			EventHandler value2 = new EventHandler(this.method_43);
			ComboBox comboBox = this.comboBox_14;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_14 = comboBox_41;
			comboBox = this.comboBox_14;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x002BBCE4 File Offset: 0x002B9EE4
		[CompilerGenerated]
		internal  CheckBox vmethod_96()
		{
			return this.checkBox_11;
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x002BBCFC File Offset: 0x002B9EFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_83);
			CheckBox checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_11 = checkBox_31;
			checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x002BBD48 File Offset: 0x002B9F48
		[CompilerGenerated]
		internal  CheckBox vmethod_98()
		{
			return this.checkBox_12;
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x002BBD60 File Offset: 0x002B9F60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_86);
			CheckBox checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_12 = checkBox_31;
			checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x002BBDAC File Offset: 0x002B9FAC
		[CompilerGenerated]
		internal  Label vmethod_100()
		{
			return this.label_15;
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x000298CD File Offset: 0x00027ACD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(Label label_51)
		{
			this.label_15 = label_51;
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x002BBDC4 File Offset: 0x002B9FC4
		[CompilerGenerated]
		internal  ComboBox vmethod_102()
		{
			return this.comboBox_15;
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x002BBDDC File Offset: 0x002B9FDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_29);
			EventHandler value2 = new EventHandler(this.method_40);
			ComboBox comboBox = this.comboBox_15;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_15 = comboBox_41;
			comboBox = this.comboBox_15;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x002BBE40 File Offset: 0x002BA040
		[CompilerGenerated]
		internal  CheckBox vmethod_104()
		{
			return this.checkBox_13;
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x002BBE58 File Offset: 0x002BA058
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_82);
			CheckBox checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_13 = checkBox_31;
			checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x002BBEA4 File Offset: 0x002BA0A4
		[CompilerGenerated]
		internal  Label vmethod_106()
		{
			return this.label_16;
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x000298D6 File Offset: 0x00027AD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Label label_51)
		{
			this.label_16 = label_51;
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x002BBEBC File Offset: 0x002BA0BC
		[CompilerGenerated]
		internal  Label vmethod_108()
		{
			return this.label_17;
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x000298DF File Offset: 0x00027ADF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(Label label_51)
		{
			this.label_17 = label_51;
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x002BBED4 File Offset: 0x002BA0D4
		[CompilerGenerated]
		internal  Label vmethod_110()
		{
			return this.label_18;
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x000298E8 File Offset: 0x00027AE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(Label label_51)
		{
			this.label_18 = label_51;
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x002BBEEC File Offset: 0x002BA0EC
		[CompilerGenerated]
		internal  Label vmethod_112()
		{
			return this.label_19;
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x000298F1 File Offset: 0x00027AF1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(Label label_51)
		{
			this.label_19 = label_51;
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x002BBF04 File Offset: 0x002BA104
		[CompilerGenerated]
		internal  Label vmethod_114()
		{
			return this.label_20;
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x000298FA File Offset: 0x00027AFA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(Label label_51)
		{
			this.label_20 = label_51;
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x002BBF1C File Offset: 0x002BA11C
		[CompilerGenerated]
		internal  Label vmethod_116()
		{
			return this.label_21;
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00029903 File Offset: 0x00027B03
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(Label label_51)
		{
			this.label_21 = label_51;
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x002BBF34 File Offset: 0x002BA134
		[CompilerGenerated]
		internal  Button vmethod_118()
		{
			return this.button_1;
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x002BBF4C File Offset: 0x002BA14C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_99);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_9;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x002BBF98 File Offset: 0x002BA198
		[CompilerGenerated]
		internal  Button vmethod_120()
		{
			return this.button_2;
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x002BBFB0 File Offset: 0x002BA1B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_98);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_9;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x002BBFFC File Offset: 0x002BA1FC
		[CompilerGenerated]
		internal  Button vmethod_122()
		{
			return this.button_3;
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x002BC014 File Offset: 0x002BA214
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_97);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_9;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x002BC060 File Offset: 0x002BA260
		[CompilerGenerated]
		internal  Button GetButton_ResetAffectedMissions_WRA()
		{
			return this.button_4;
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x002BC078 File Offset: 0x002BA278
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_96);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_9;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x002BC0C4 File Offset: 0x002BA2C4
		[CompilerGenerated]
		internal  Button GetButton_ResetAffectedUnits_WRA()
		{
			return this.button_5;
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x002BC0DC File Offset: 0x002BA2DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_95);
			Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_9;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x002BC128 File Offset: 0x002BA328
		[CompilerGenerated]
		internal  Button GetButton_ResetAffectedMissions_EMCON()
		{
			return this.button_6;
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x002BC140 File Offset: 0x002BA340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_102);
			Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_9;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x002BC18C File Offset: 0x002BA38C
		[CompilerGenerated]
		internal  Button GetButton_ResetAffectedUnits_EMCON()
		{
			return this.button_7;
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x002BC1A4 File Offset: 0x002BA3A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_101);
			Button button = this.button_7;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_7 = button_9;
			button = this.button_7;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x002BC1F0 File Offset: 0x002BA3F0
		[CompilerGenerated]
		internal  Button GetButton_ResetCurrent_EMCON()
		{
			return this.button_8;
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x002BC208 File Offset: 0x002BA408
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_100);
			Button button = this.button_8;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_8 = button_9;
			button = this.button_8;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x002BC254 File Offset: 0x002BA454
		[CompilerGenerated]
		internal  Label vmethod_134()
		{
			return this.label_22;
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x0002990C File Offset: 0x00027B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Label label_51)
		{
			this.label_22 = label_51;
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x002BC26C File Offset: 0x002BA46C
		[CompilerGenerated]
		internal  ComboBox vmethod_136()
		{
			return this.comboBox_16;
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x002BC284 File Offset: 0x002BA484
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_17);
			EventHandler value2 = new EventHandler(this.method_49);
			ComboBox comboBox = this.comboBox_16;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_16 = comboBox_41;
			comboBox = this.comboBox_16;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x002BC2E8 File Offset: 0x002BA4E8
		[CompilerGenerated]
		internal  CheckBox vmethod_138()
		{
			return this.checkBox_14;
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x002BC300 File Offset: 0x002BA500
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_16);
			CheckBox checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_14 = checkBox_31;
			checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x002BC34C File Offset: 0x002BA54C
		[CompilerGenerated]
		internal  Label vmethod_140()
		{
			return this.label_23;
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00029915 File Offset: 0x00027B15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Label label_51)
		{
			this.label_23 = label_51;
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x002BC364 File Offset: 0x002BA564
		[CompilerGenerated]
		internal  Label vmethod_142()
		{
			return this.label_24;
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x0002991E File Offset: 0x00027B1E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(Label label_51)
		{
			this.label_24 = label_51;
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x002BC37C File Offset: 0x002BA57C
		[CompilerGenerated]
		internal  Label vmethod_144()
		{
			return this.label_25;
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x00029927 File Offset: 0x00027B27
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_145(Label label_51)
		{
			this.label_25 = label_51;
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x002BC394 File Offset: 0x002BA594
		[CompilerGenerated]
		internal  CheckBox vmethod_146()
		{
			return this.checkBox_15;
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x002BC3AC File Offset: 0x002BA5AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_147(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_19);
			CheckBox checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_15 = checkBox_31;
			checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x002BC3F8 File Offset: 0x002BA5F8
		[CompilerGenerated]
		internal  CheckBox vmethod_148()
		{
			return this.checkBox_16;
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x002BC410 File Offset: 0x002BA610
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_149(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_20);
			CheckBox checkBox = this.checkBox_16;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_16 = checkBox_31;
			checkBox = this.checkBox_16;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x002BC45C File Offset: 0x002BA65C
		[CompilerGenerated]
		internal  CheckBox vmethod_150()
		{
			return this.checkBox_17;
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x002BC474 File Offset: 0x002BA674
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_151(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_21);
			CheckBox checkBox = this.checkBox_17;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_17 = checkBox_31;
			checkBox = this.checkBox_17;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x002BC4C0 File Offset: 0x002BA6C0
		[CompilerGenerated]
		internal  ComboBox vmethod_152()
		{
			return this.comboBox_17;
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x002BC4D8 File Offset: 0x002BA6D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_153(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_34);
			EventHandler value2 = new EventHandler(this.method_45);
			ComboBox comboBox = this.comboBox_17;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_17 = comboBox_41;
			comboBox = this.comboBox_17;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x002BC53C File Offset: 0x002BA73C
		[CompilerGenerated]
		internal  ComboBox vmethod_154()
		{
			return this.comboBox_18;
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x002BC554 File Offset: 0x002BA754
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_155(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_35);
			EventHandler value2 = new EventHandler(this.method_46);
			ComboBox comboBox = this.comboBox_18;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_18 = comboBox_41;
			comboBox = this.comboBox_18;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x002BC5B8 File Offset: 0x002BA7B8
		[CompilerGenerated]
		internal  ComboBox vmethod_156()
		{
			return this.comboBox_19;
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x002BC5D0 File Offset: 0x002BA7D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_157(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_36);
			EventHandler value2 = new EventHandler(this.method_47);
			ComboBox comboBox = this.comboBox_19;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_19 = comboBox_41;
			comboBox = this.comboBox_19;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x002BC634 File Offset: 0x002BA834
		[CompilerGenerated]
		internal  Label vmethod_158()
		{
			return this.label_26;
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x00029930 File Offset: 0x00027B30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_159(Label label_51)
		{
			this.label_26 = label_51;
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x002BC64C File Offset: 0x002BA84C
		[CompilerGenerated]
		internal  CheckBox vmethod_160()
		{
			return this.checkBox_18;
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x002BC664 File Offset: 0x002BA864
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_161(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_26);
			CheckBox checkBox = this.checkBox_18;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_18 = checkBox_31;
			checkBox = this.checkBox_18;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x002BC6B0 File Offset: 0x002BA8B0
		[CompilerGenerated]
		internal  ComboBox vmethod_162()
		{
			return this.comboBox_20;
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x002BC6C8 File Offset: 0x002BA8C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_163(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_37);
			EventHandler value2 = new EventHandler(this.method_48);
			ComboBox comboBox = this.comboBox_20;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_20 = comboBox_41;
			comboBox = this.comboBox_20;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x002BC72C File Offset: 0x002BA92C
		[CompilerGenerated]
		internal  Label vmethod_164()
		{
			return this.label_27;
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x00029939 File Offset: 0x00027B39
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_165(Label label_51)
		{
			this.label_27 = label_51;
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x002BC744 File Offset: 0x002BA944
		[CompilerGenerated]
		internal  Label vmethod_166()
		{
			return this.label_28;
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00029942 File Offset: 0x00027B42
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_167(Label label_51)
		{
			this.label_28 = label_51;
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x002BC75C File Offset: 0x002BA95C
		[CompilerGenerated]
		internal  Label vmethod_168()
		{
			return this.label_29;
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x0002994B File Offset: 0x00027B4B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_169(Label label_51)
		{
			this.label_29 = label_51;
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x002BC774 File Offset: 0x002BA974
		[CompilerGenerated]
		internal  ComboBox vmethod_170()
		{
			return this.comboBox_21;
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x002BC78C File Offset: 0x002BA98C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_171(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_30);
			EventHandler value2 = new EventHandler(this.method_41);
			ComboBox comboBox = this.comboBox_21;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_21 = comboBox_41;
			comboBox = this.comboBox_21;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x002BC7F0 File Offset: 0x002BA9F0
		[CompilerGenerated]
		internal  ComboBox vmethod_172()
		{
			return this.comboBox_22;
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x002BC808 File Offset: 0x002BAA08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_173(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_31);
			EventHandler value2 = new EventHandler(this.method_42);
			ComboBox comboBox = this.comboBox_22;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_22 = comboBox_41;
			comboBox = this.comboBox_22;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x002BC86C File Offset: 0x002BAA6C
		[CompilerGenerated]
		internal  CheckBox vmethod_174()
		{
			return this.checkBox_19;
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x002BC884 File Offset: 0x002BAA84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_175(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_85);
			CheckBox checkBox = this.checkBox_19;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_19 = checkBox_31;
			checkBox = this.checkBox_19;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x002BC8D0 File Offset: 0x002BAAD0
		[CompilerGenerated]
		internal  CheckBox vmethod_176()
		{
			return this.checkBox_20;
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x002BC8E8 File Offset: 0x002BAAE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_177(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_84);
			CheckBox checkBox = this.checkBox_20;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_20 = checkBox_31;
			checkBox = this.checkBox_20;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x002BC934 File Offset: 0x002BAB34
		[CompilerGenerated]
		internal  ComboBox vmethod_178()
		{
			return this.comboBox_23;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x002BC94C File Offset: 0x002BAB4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_179(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_59);
			EventHandler value2 = new EventHandler(this.method_60);
			ComboBox comboBox = this.comboBox_23;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_23 = comboBox_41;
			comboBox = this.comboBox_23;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x002BC9B0 File Offset: 0x002BABB0
		[CompilerGenerated]
		internal  Label vmethod_180()
		{
			return this.label_30;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x00029954 File Offset: 0x00027B54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_181(Label label_51)
		{
			this.label_30 = label_51;
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x002BC9C8 File Offset: 0x002BABC8
		[CompilerGenerated]
		internal  CheckBox vmethod_182()
		{
			return this.checkBox_21;
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x002BC9E0 File Offset: 0x002BABE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_183(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_110);
			CheckBox checkBox = this.checkBox_21;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_21 = checkBox_31;
			checkBox = this.checkBox_21;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x002BCA2C File Offset: 0x002BAC2C
		[CompilerGenerated]
		internal  CheckBox vmethod_184()
		{
			return this.checkBox_22;
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x002BCA44 File Offset: 0x002BAC44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_185(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_109);
			CheckBox checkBox = this.checkBox_22;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_22 = checkBox_31;
			checkBox = this.checkBox_22;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x002BCA90 File Offset: 0x002BAC90
		[CompilerGenerated]
		internal  ComboBox vmethod_186()
		{
			return this.comboBox_24;
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x002BCAA8 File Offset: 0x002BACA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_187(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_57);
			EventHandler value2 = new EventHandler(this.method_58);
			ComboBox comboBox = this.comboBox_24;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_24 = comboBox_41;
			comboBox = this.comboBox_24;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x002BCB0C File Offset: 0x002BAD0C
		[CompilerGenerated]
		internal  Label vmethod_188()
		{
			return this.label_31;
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x0002995D File Offset: 0x00027B5D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_189(Label label_51)
		{
			this.label_31 = label_51;
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x002BCB24 File Offset: 0x002BAD24
		[CompilerGenerated]
		internal  Label vmethod_190()
		{
			return this.label_32;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00029966 File Offset: 0x00027B66
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_191(Label label_51)
		{
			this.label_32 = label_51;
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x002BCB3C File Offset: 0x002BAD3C
		[CompilerGenerated]
		internal  ComboBox vmethod_192()
		{
			return this.comboBox_25;
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x002BCB54 File Offset: 0x002BAD54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_193(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_118);
			EventHandler value2 = new EventHandler(this.method_125);
			ComboBox comboBox = this.comboBox_25;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_25 = comboBox_41;
			comboBox = this.comboBox_25;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x002BCBB8 File Offset: 0x002BADB8
		[CompilerGenerated]
		internal  Label vmethod_194()
		{
			return this.label_33;
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x0002996F File Offset: 0x00027B6F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_195(Label label_51)
		{
			this.label_33 = label_51;
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x002BCBD0 File Offset: 0x002BADD0
		[CompilerGenerated]
		internal  CheckBox vmethod_196()
		{
			return this.checkBox_23;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x002BCBE8 File Offset: 0x002BADE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_197(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_111);
			CheckBox checkBox = this.checkBox_23;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_23 = checkBox_31;
			checkBox = this.checkBox_23;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x002BCC34 File Offset: 0x002BAE34
		[CompilerGenerated]
		internal  Label vmethod_198()
		{
			return this.label_34;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00029978 File Offset: 0x00027B78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_199(Label label_51)
		{
			this.label_34 = label_51;
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x002BCC4C File Offset: 0x002BAE4C
		[CompilerGenerated]
		internal  ComboBox vmethod_200()
		{
			return this.comboBox_26;
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x002BCC64 File Offset: 0x002BAE64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_201(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_119);
			EventHandler value2 = new EventHandler(this.method_126);
			ComboBox comboBox = this.comboBox_26;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_26 = comboBox_41;
			comboBox = this.comboBox_26;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x002BCCC8 File Offset: 0x002BAEC8
		[CompilerGenerated]
		internal  Label vmethod_202()
		{
			return this.label_35;
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00029981 File Offset: 0x00027B81
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_203(Label label_51)
		{
			this.label_35 = label_51;
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x002BCCE0 File Offset: 0x002BAEE0
		[CompilerGenerated]
		internal  ComboBox vmethod_204()
		{
			return this.comboBox_27;
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x002BCCF8 File Offset: 0x002BAEF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_205(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_120);
			EventHandler value2 = new EventHandler(this.method_127);
			ComboBox comboBox = this.comboBox_27;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_27 = comboBox_41;
			comboBox = this.comboBox_27;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x002BCD5C File Offset: 0x002BAF5C
		[CompilerGenerated]
		internal  CheckBox vmethod_206()
		{
			return this.checkBox_24;
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x002BCD74 File Offset: 0x002BAF74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_207(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_112);
			CheckBox checkBox = this.checkBox_24;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_24 = checkBox_31;
			checkBox = this.checkBox_24;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x002BCDC0 File Offset: 0x002BAFC0
		[CompilerGenerated]
		internal  CheckBox vmethod_208()
		{
			return this.checkBox_25;
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x002BCDD8 File Offset: 0x002BAFD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_209(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_113);
			CheckBox checkBox = this.checkBox_25;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_25 = checkBox_31;
			checkBox = this.checkBox_25;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x002BCE24 File Offset: 0x002BB024
		[CompilerGenerated]
		internal  Label vmethod_210()
		{
			return this.label_36;
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x0002998A File Offset: 0x00027B8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_211(Label label_51)
		{
			this.label_36 = label_51;
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x002BCE3C File Offset: 0x002BB03C
		[CompilerGenerated]
		internal  ComboBox vmethod_212()
		{
			return this.comboBox_28;
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x002BCE54 File Offset: 0x002BB054
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_213(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_121);
			EventHandler value2 = new EventHandler(this.method_129);
			ComboBox comboBox = this.comboBox_28;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_28 = comboBox_41;
			comboBox = this.comboBox_28;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x002BCEB8 File Offset: 0x002BB0B8
		[CompilerGenerated]
		internal  CheckBox vmethod_214()
		{
			return this.checkBox_26;
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x002BCED0 File Offset: 0x002BB0D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_215(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_114);
			CheckBox checkBox = this.checkBox_26;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_26 = checkBox_31;
			checkBox = this.checkBox_26;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x002BCF1C File Offset: 0x002BB11C
		[CompilerGenerated]
		internal  Label vmethod_216()
		{
			return this.label_37;
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00029993 File Offset: 0x00027B93
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_217(Label label_51)
		{
			this.label_37 = label_51;
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x002BCF34 File Offset: 0x002BB134
		[CompilerGenerated]
		internal  ComboBox vmethod_218()
		{
			return this.comboBox_29;
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x002BCF4C File Offset: 0x002BB14C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_219(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_122);
			EventHandler value2 = new EventHandler(this.method_130);
			ComboBox comboBox = this.comboBox_29;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_29 = comboBox_41;
			comboBox = this.comboBox_29;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x002BCFB0 File Offset: 0x002BB1B0
		[CompilerGenerated]
		internal  CheckBox vmethod_220()
		{
			return this.checkBox_27;
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x002BCFC8 File Offset: 0x002BB1C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_221(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_115);
			CheckBox checkBox = this.checkBox_27;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_27 = checkBox_31;
			checkBox = this.checkBox_27;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x002BD014 File Offset: 0x002BB214
		[CompilerGenerated]
		internal  Label vmethod_222()
		{
			return this.label_38;
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x0002999C File Offset: 0x00027B9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_223(Label label_51)
		{
			this.label_38 = label_51;
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x002BD02C File Offset: 0x002BB22C
		[CompilerGenerated]
		internal  ComboBox vmethod_224()
		{
			return this.comboBox_30;
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x002BD044 File Offset: 0x002BB244
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_225(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_123);
			EventHandler value2 = new EventHandler(this.method_131);
			ComboBox comboBox = this.comboBox_30;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_30 = comboBox_41;
			comboBox = this.comboBox_30;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x002BD0A8 File Offset: 0x002BB2A8
		[CompilerGenerated]
		internal  CheckBox vmethod_226()
		{
			return this.checkBox_28;
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x002BD0C0 File Offset: 0x002BB2C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_227(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_116);
			CheckBox checkBox = this.checkBox_28;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_28 = checkBox_31;
			checkBox = this.checkBox_28;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x002BD10C File Offset: 0x002BB30C
		[CompilerGenerated]
		internal  Label vmethod_228()
		{
			return this.label_39;
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x000299A5 File Offset: 0x00027BA5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_229(Label label_51)
		{
			this.label_39 = label_51;
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x002BD124 File Offset: 0x002BB324
		[CompilerGenerated]
		internal  ComboBox vmethod_230()
		{
			return this.comboBox_31;
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x002BD13C File Offset: 0x002BB33C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_231(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_124);
			EventHandler value2 = new EventHandler(this.method_132);
			ComboBox comboBox = this.comboBox_31;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.Enter -= value2;
			}
			this.comboBox_31 = comboBox_41;
			comboBox = this.comboBox_31;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.Enter += value2;
			}
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x002BD1A0 File Offset: 0x002BB3A0
		[CompilerGenerated]
		internal  CheckBox vmethod_232()
		{
			return this.checkBox_29;
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x002BD1B8 File Offset: 0x002BB3B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_233(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_117);
			CheckBox checkBox = this.checkBox_29;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_29 = checkBox_31;
			checkBox = this.checkBox_29;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x002BD204 File Offset: 0x002BB404
		[CompilerGenerated]
		internal  TabPage vmethod_234()
		{
			return this.tabPage_3;
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x000299AE File Offset: 0x00027BAE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_235(TabPage tabPage_4)
		{
			this.tabPage_3 = tabPage_4;
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x002BD21C File Offset: 0x002BB41C
		[CompilerGenerated]
		internal  ComboBox GetCombo_WithdrawDefenceThreshold()
		{
			return this.comboBox_32;
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x002BD234 File Offset: 0x002BB434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_237(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_145);
			EventHandler value2 = new EventHandler(this.method_146);
			ComboBox comboBox = this.comboBox_32;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_32 = comboBox_41;
			comboBox = this.comboBox_32;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x002BD298 File Offset: 0x002BB498
		[CompilerGenerated]
		internal  ComboBox GetCombo_WithdrawAttackThreshold()
		{
			return this.comboBox_33;
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x002BD2B0 File Offset: 0x002BB4B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_239(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_141);
			EventHandler value2 = new EventHandler(this.method_142);
			ComboBox comboBox = this.comboBox_33;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_33 = comboBox_41;
			comboBox = this.comboBox_33;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x002BD314 File Offset: 0x002BB514
		[CompilerGenerated]
		internal  ComboBox GetCombo_WithdrawFuelThreshold()
		{
			return this.comboBox_34;
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x002BD32C File Offset: 0x002BB52C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_241(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_137);
			EventHandler value2 = new EventHandler(this.method_138);
			ComboBox comboBox = this.comboBox_34;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_34 = comboBox_41;
			comboBox = this.comboBox_34;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x002BD390 File Offset: 0x002BB590
		[CompilerGenerated]
		internal  Label vmethod_242()
		{
			return this.label_40;
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x000299B7 File Offset: 0x00027BB7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_243(Label label_51)
		{
			this.label_40 = label_51;
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x002BD3A8 File Offset: 0x002BB5A8
		[CompilerGenerated]
		internal  Label vmethod_244()
		{
			return this.label_41;
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x000299C0 File Offset: 0x00027BC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_245(Label label_51)
		{
			this.label_41 = label_51;
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x002BD3C0 File Offset: 0x002BB5C0
		[CompilerGenerated]
		internal  Label vmethod_246()
		{
			return this.label_42;
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x000299C9 File Offset: 0x00027BC9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_247(Label label_51)
		{
			this.label_42 = label_51;
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x002BD3D8 File Offset: 0x002BB5D8
		[CompilerGenerated]
		internal  Label vmethod_248()
		{
			return this.label_43;
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x000299D2 File Offset: 0x00027BD2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_249(Label label_51)
		{
			this.label_43 = label_51;
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x002BD3F0 File Offset: 0x002BB5F0
		[CompilerGenerated]
		internal  ComboBox GetCombo_WithdrawDamageThreshold()
		{
			return this.comboBox_35;
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x002BD408 File Offset: 0x002BB608
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_251(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_133);
			EventHandler value2 = new EventHandler(this.method_135);
			ComboBox comboBox = this.comboBox_35;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_35 = comboBox_41;
			comboBox = this.comboBox_35;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x002BD46C File Offset: 0x002BB66C
		[CompilerGenerated]
		internal  Label vmethod_252()
		{
			return this.label_44;
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x000299DB File Offset: 0x00027BDB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_253(Label label_51)
		{
			this.label_44 = label_51;
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x002BD484 File Offset: 0x002BB684
		[CompilerGenerated]
		internal  ComboBox GetCombo_RedeployDefenceThreshold()
		{
			return this.comboBox_36;
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x002BD49C File Offset: 0x002BB69C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_255(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_147);
			EventHandler value2 = new EventHandler(this.method_148);
			ComboBox comboBox = this.comboBox_36;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_36 = comboBox_41;
			comboBox = this.comboBox_36;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x002BD500 File Offset: 0x002BB700
		[CompilerGenerated]
		internal  ComboBox GetCombo_RedeployAttackThreshold()
		{
			return this.comboBox_37;
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x002BD518 File Offset: 0x002BB718
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_257(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_143);
			EventHandler value2 = new EventHandler(this.method_144);
			ComboBox comboBox = this.comboBox_37;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_37 = comboBox_41;
			comboBox = this.comboBox_37;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x002BD57C File Offset: 0x002BB77C
		[CompilerGenerated]
		internal  ComboBox GetCombo_RedeployFuelThreshold()
		{
			return this.comboBox_38;
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x002BD594 File Offset: 0x002BB794
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_259(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_139);
			EventHandler value2 = new EventHandler(this.method_140);
			ComboBox comboBox = this.comboBox_38;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_38 = comboBox_41;
			comboBox = this.comboBox_38;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x002BD5F8 File Offset: 0x002BB7F8
		[CompilerGenerated]
		internal  Label vmethod_260()
		{
			return this.label_45;
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x000299E4 File Offset: 0x00027BE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_261(Label label_51)
		{
			this.label_45 = label_51;
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x002BD610 File Offset: 0x002BB810
		[CompilerGenerated]
		internal  Label vmethod_262()
		{
			return this.label_46;
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x000299ED File Offset: 0x00027BED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_263(Label label_51)
		{
			this.label_46 = label_51;
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x002BD628 File Offset: 0x002BB828
		[CompilerGenerated]
		internal  Label vmethod_264()
		{
			return this.label_47;
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x000299F6 File Offset: 0x00027BF6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_265(Label label_51)
		{
			this.label_47 = label_51;
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x002BD640 File Offset: 0x002BB840
		[CompilerGenerated]
		internal  Label vmethod_266()
		{
			return this.label_48;
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x000299FF File Offset: 0x00027BFF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_267(Label label_51)
		{
			this.label_48 = label_51;
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x002BD658 File Offset: 0x002BB858
		[CompilerGenerated]
		internal  ComboBox vmethod_268()
		{
			return this.comboBox_39;
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x002BD670 File Offset: 0x002BB870
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_269(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_134);
			EventHandler value2 = new EventHandler(this.method_136);
			ComboBox comboBox = this.comboBox_39;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_39 = comboBox_41;
			comboBox = this.comboBox_39;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x002BD6D4 File Offset: 0x002BB8D4
		[CompilerGenerated]
		internal  Label vmethod_270()
		{
			return this.label_49;
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00029A08 File Offset: 0x00027C08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_271(Label label_51)
		{
			this.label_49 = label_51;
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x002BD6EC File Offset: 0x002BB8EC
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn GetTargetType()
		{
			return this.class2383_0;
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x00029A11 File Offset: 0x00027C11
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_273(TreeGridViewTextBoxColumn class2383_1)
		{
			this.class2383_0 = class2383_1;
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x002BD704 File Offset: 0x002BB904
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetWeaponsPerSalvo()
		{
			return this.CB_WeaponsPerSalvo;
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x00029A1A File Offset: 0x00027C1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetWeaponsPerSalvo(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.CB_WeaponsPerSalvo = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x002BD71C File Offset: 0x002BB91C
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetShootersPerSalvo()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x00029A23 File Offset: 0x00027C23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_277(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x002BD734 File Offset: 0x002BB934
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetFiringRange()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x00029A2C File Offset: 0x00027C2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_279(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x002BD74C File Offset: 0x002BB94C
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetSelfDefenceRange()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x00029A35 File Offset: 0x00027C35
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_281(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x002BD764 File Offset: 0x002BB964
		[CompilerGenerated]
		internal  Label vmethod_282()
		{
			return this.label_50;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x00029A3E File Offset: 0x00027C3E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_283(Label label_51)
		{
			this.label_50 = label_51;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x002BD77C File Offset: 0x002BB97C
		[CompilerGenerated]
		internal  CheckBox vmethod_284()
		{
			return this.checkBox_30;
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x002BD794 File Offset: 0x002BB994
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_285(CheckBox checkBox_31)
		{
			EventHandler value = new EventHandler(this.method_24);
			CheckBox checkBox = this.checkBox_30;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_30 = checkBox_31;
			checkBox = this.checkBox_30;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x002BD7E0 File Offset: 0x002BB9E0
		[CompilerGenerated]
		internal  ComboBox vmethod_286()
		{
			return this.comboBox_40;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x002BD7F8 File Offset: 0x002BB9F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_287(ComboBox comboBox_41)
		{
			EventHandler value = new EventHandler(this.method_73);
			EventHandler value2 = new EventHandler(this.method_74);
			ComboBox comboBox = this.comboBox_40;
			if (comboBox != null)
			{
				comboBox.Enter -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_40 = comboBox_41;
			comboBox = this.comboBox_40;
			if (comboBox != null)
			{
				comboBox.Enter += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x002BD85C File Offset: 0x002BBA5C
		private void method_1(Subject class137_1, bool? nullable_38, bool bool_6, bool bool_7, bool bool_8, bool bool_9)
		{
			if (!bool_7 && !bool_9 && !Information.IsNothing(class137_1) && class137_1.IsActiveUnit() && ((ActiveUnit)class137_1).IsOperating() && (!bool_6 || class137_1 == Client.GetHookedUnit()) && !Information.IsNothing(nullable_38) && base.Visible && (class137_1 == this.subject || Information.IsNothing(this.subject)) && this.vmethod_0().SelectedIndex == 0)
			{
				this.method_14();
			}
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x002BD8E0 File Offset: 0x002BBAE0
		private void method_2(Subject class137_1, bool? nullable_38, bool bool_6, bool bool_7, bool bool_8, bool bool_9)
		{
			if (!bool_7 && !bool_9 && !Information.IsNothing(class137_1) && class137_1.IsActiveUnit() && (!bool_6 || class137_1 == Client.GetHookedUnit()) && this.bool_2 && !Information.IsNothing(nullable_38) && base.Visible && (class137_1 == this.subject || Information.IsNothing(this.subject)) && this.vmethod_0().SelectedIndex == 1)
			{
				this.method_14();
			}
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x002BD960 File Offset: 0x002BBB60
		private void DoctrineForm_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_0(new Doctrine.Delegate9(this.method_1));
			Doctrine.smethod_2(new Doctrine.Delegate10(this.method_2));
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				if (this.bool_3)
				{
					this.Text = "对地面飞机的作战条令与交战规则";
				}
				else if (this.bool_4)
				{
					this.Text = "对停靠/吊柱上的舰艇的作战条令与交战规则";
				}
				else
				{
					this.Text = "对多个作战单元的作战条令与交战规则";
				}
				this.m_Doctrine = this.method_104();
			}
			else
			{
				if (this.subject.GetType() == typeof(Side))
				{
					this.Text = "作战条令与交战规则—针对推演方: " + ((Side)this.subject).GetSideName();
					this.m_Doctrine = ((Side)this.subject).m_Doctrine;
				}
				else if (this.subject.IsMission)
				{
					if (this.bool_5)
					{
						this.Text = "作战条令与交战规则—针对护航任务: " + ((Mission)this.subject).Name;
						this.m_Doctrine = ((Strike)this.subject).Doctrine_Escorts;
					}
					else
					{
						this.Text = "作战条令与交战规则—针对作战任务: " + ((Mission)this.subject).Name;
						this.m_Doctrine = ((Mission)this.subject).m_Doctrine;
					}
				}
				else if (this.subject.GetType() == typeof(Group))
				{
					this.Text = "作战条令与交战规则—针对编组: " + ((Group)this.subject).Name;
					this.m_Doctrine = ((Group)this.subject).m_Doctrine;
				}
				else if (this.subject.GetType() == typeof(Waypoint))
				{
					string text = ((Waypoint)this.subject).Name;
					if (string.IsNullOrEmpty(text))
					{
						text = "无名称";
					}
					this.Text = string.Concat(new string[]
					{
						"作战条令与交战规则—针对航路点: ",
						text,
						" (类型: ",
						Waypoint.GetWaypointTypeString(((Waypoint)this.subject).waypointType),
						")"
					});
					this.m_Doctrine = ((Waypoint)this.subject).m_Doctrine;
				}
				else
				{
					this.Text = "作战条令与交战规则—针对作战单元: " + ((ActiveUnit)this.subject).Name;
					this.m_Doctrine = ((ActiveUnit)this.subject).m_Doctrine;
				}
				this.m_Doctrine.Init();
			}
			this.vmethod_0().SelectedIndex = 0;
			this.method_14();
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x002BDC40 File Offset: 0x002BBE40
		private void method_3()
		{
			this.method_106();
			if (!Information.IsNothing(this.subject))
			{
				if (this.subject.GetType() == typeof(Side))
				{
					this.vmethod_122().Enabled = false;
					this.vmethod_120().Enabled = true;
					this.vmethod_118().Enabled = true;
				}
				else if (this.subject.IsMission)
				{
					this.vmethod_122().Enabled = true;
					this.vmethod_120().Enabled = true;
					this.vmethod_118().Enabled = false;
				}
				else if (this.subject.GetType() == typeof(Group))
				{
					this.vmethod_122().Enabled = true;
					this.vmethod_120().Enabled = true;
					this.vmethod_118().Enabled = false;
				}
				else if (this.subject.GetType() == typeof(Waypoint))
				{
					this.vmethod_122().Enabled = false;
					this.vmethod_120().Enabled = false;
					this.vmethod_118().Enabled = false;
				}
				else
				{
					this.vmethod_122().Enabled = true;
					this.vmethod_120().Enabled = false;
					this.vmethod_118().Enabled = false;
				}
			}
			else
			{
				this.vmethod_122().Enabled = true;
				this.vmethod_120().Enabled = false;
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsGroup)
						{
							this.vmethod_120().Enabled = true;
							break;
						}
					}
				}
				this.vmethod_118().Enabled = false;
			}
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				this.m_Doctrine = this.method_104();
			}
			this.vmethod_48().Checked = this.m_Doctrine.IsNukes_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_48().Visible = false;
				this.vmethod_56().Enabled = this.m_Doctrine.IsNukes_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_56();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_263(ref comboBox_, ref clientScenario, this.UseNuclearDoc);
			this.vmethod_57(comboBox_);
			this.vmethod_46().Checked = this.m_Doctrine.IsWCS_Air_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_46().Visible = false;
				this.vmethod_54().Enabled = this.m_Doctrine.IsWCS_Air_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine2 = this.m_Doctrine;
			comboBox_ = this.vmethod_54();
			clientScenario = Client.GetClientScenario();
			doctrine2.method_265(ref comboBox_, ref clientScenario, this.WCS_AirDoc);
			this.vmethod_55(comboBox_);
			this.vmethod_146().Checked = this.m_Doctrine.IsWCS_Surface_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_146().Visible = false;
				this.vmethod_152().Enabled = this.m_Doctrine.IsWCS_Surface_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine3 = this.m_Doctrine;
			comboBox_ = this.vmethod_152();
			clientScenario = Client.GetClientScenario();
			doctrine3.method_267(ref comboBox_, ref clientScenario, this.WCS_SurfaceDoc);
			this.vmethod_153(comboBox_);
			this.vmethod_148().Checked = this.m_Doctrine.IsWCS_Submarine_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_148().Visible = false;
				this.vmethod_154().Enabled = this.m_Doctrine.IsWCS_Submarine_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine4 = this.m_Doctrine;
			comboBox_ = this.vmethod_154();
			clientScenario = Client.GetClientScenario();
			doctrine4.method_269(ref comboBox_, ref clientScenario, this.WCS_SubmarineDoc);
			this.vmethod_155(comboBox_);
			this.vmethod_150().Checked = this.m_Doctrine.IsWCSLand_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_150().Visible = false;
				this.vmethod_156().Enabled = this.m_Doctrine.IsWCSLand_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine5 = this.m_Doctrine;
			comboBox_ = this.vmethod_156();
			clientScenario = Client.GetClientScenario();
			doctrine5.method_271(ref comboBox_, ref clientScenario, this.WCS_LandDoc);
			this.vmethod_157(comboBox_);
			this.vmethod_160().Checked = this.m_Doctrine.method_144(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_160().Visible = false;
				this.vmethod_162().Enabled = this.m_Doctrine.method_144(Client.GetClientScenario());
			}
			Doctrine doctrine6 = this.m_Doctrine;
			comboBox_ = this.vmethod_162();
			clientScenario = Client.GetClientScenario();
			doctrine6.method_287(ref comboBox_, ref clientScenario, this.GunStrafeGroundTargetsDoc);
			this.vmethod_163(comboBox_);
			this.vmethod_138().Checked = this.m_Doctrine.IsIgnorePlottedCourseWhenAttackingPlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_138().Visible = false;
				this.vmethod_136().Enabled = this.m_Doctrine.IsIgnorePlottedCourseWhenAttackingPlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine7 = this.m_Doctrine;
			comboBox_ = this.vmethod_136();
			clientScenario = Client.GetClientScenario();
			doctrine7.method_273(ref comboBox_, ref clientScenario, this.IgnorePlottedCourseWhenAttackingDoc);
			this.vmethod_137(comboBox_);
			this.vmethod_42().Checked = this.m_Doctrine.method_119(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_42().Visible = false;
				this.vmethod_52().Enabled = this.m_Doctrine.method_119(Client.GetClientScenario());
			}
			Doctrine doctrine8 = this.m_Doctrine;
			comboBox_ = this.vmethod_52();
			clientScenario = Client.GetClientScenario();
			doctrine8.method_275(ref comboBox_, ref clientScenario, this.WinchesterShotgunRTBDoc);
			this.vmethod_53(comboBox_);
			this.vmethod_184().Checked = this.m_Doctrine.method_124(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_184().Visible = false;
				this.vmethod_186().Enabled = this.m_Doctrine.method_124(Client.GetClientScenario());
			}
			Doctrine doctrine9 = this.m_Doctrine;
			comboBox_ = this.vmethod_186();
			clientScenario = Client.GetClientScenario();
			doctrine9.method_277(ref comboBox_, ref clientScenario, this.FuelStateRTBDoc);
			this.vmethod_187(comboBox_);
			this.vmethod_182().Checked = this.m_Doctrine.method_129(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_182().Visible = false;
				this.vmethod_178().Enabled = this.m_Doctrine.method_129(Client.GetClientScenario());
			}
			Doctrine doctrine10 = this.m_Doctrine;
			comboBox_ = this.vmethod_178();
			clientScenario = Client.GetClientScenario();
			doctrine10.method_279(ref comboBox_, ref clientScenario, this.JettisonOrdnanceDoc);
			this.vmethod_179(comboBox_);
			this.vmethod_62().Checked = this.m_Doctrine.IsBehaviorTowardsAmbigousTarget_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_62().Visible = false;
				this.GetCombo_BehaviorTowardsAmbigousTarget().Enabled = this.m_Doctrine.IsBehaviorTowardsAmbigousTarget_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine11 = this.m_Doctrine;
			comboBox_ = this.GetCombo_BehaviorTowardsAmbigousTarget();
			clientScenario = Client.GetClientScenario();
			doctrine11.method_281(ref comboBox_, ref clientScenario, this.BehaviorTowardsAmbigousTargetDoc);
			this.vmethod_61(comboBox_);
			this.vmethod_68().Checked = this.m_Doctrine.method_134(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_68().Visible = false;
				this.vmethod_66().Enabled = this.m_Doctrine.method_134(Client.GetClientScenario());
			}
			Doctrine doctrine12 = this.m_Doctrine;
			comboBox_ = this.vmethod_66();
			clientScenario = Client.GetClientScenario();
			doctrine12.method_283(ref comboBox_, ref clientScenario, this.AutomaticEvasionDoc);
			this.vmethod_67(comboBox_);
			this.vmethod_72().Checked = this.m_Doctrine.method_139(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_72().Visible = false;
				this.vmethod_70().Enabled = this.m_Doctrine.method_139(Client.GetClientScenario());
			}
			Doctrine doctrine13 = this.m_Doctrine;
			comboBox_ = this.vmethod_70();
			clientScenario = Client.GetClientScenario();
			doctrine13.method_285(ref comboBox_, ref clientScenario, this.MaintainStandoffDoc);
			this.vmethod_71(comboBox_);
			this.vmethod_76().Checked = this.m_Doctrine.method_149(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_76().Visible = false;
				this.vmethod_74().Enabled = this.m_Doctrine.method_149(Client.GetClientScenario());
			}
			Doctrine doctrine14 = this.m_Doctrine;
			comboBox_ = this.vmethod_74();
			clientScenario = Client.GetClientScenario();
			doctrine14.method_289(ref comboBox_, ref clientScenario, this.UseRefuelDoc);
			this.vmethod_75(comboBox_);
			this.vmethod_284().Checked = this.m_Doctrine.method_154(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_284().Visible = false;
				this.vmethod_286().Enabled = this.m_Doctrine.method_154(Client.GetClientScenario());
			}
			Doctrine doctrine15 = this.m_Doctrine;
			comboBox_ = this.vmethod_286();
			clientScenario = Client.GetClientScenario();
			doctrine15.method_291(ref comboBox_, ref clientScenario, this.RefuelSelectionDoc);
			this.vmethod_287(comboBox_);
			this.vmethod_80().Checked = this.m_Doctrine.method_159(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_80().Visible = false;
				this.vmethod_78().Enabled = this.m_Doctrine.method_159(Client.GetClientScenario());
			}
			Doctrine doctrine16 = this.m_Doctrine;
			comboBox_ = this.vmethod_78();
			clientScenario = Client.GetClientScenario();
			doctrine16.method_293(ref comboBox_, ref clientScenario, this.ShootTouristsDoc);
			this.vmethod_79(comboBox_);
			this.vmethod_84().Checked = this.m_Doctrine.method_164(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_84().Visible = false;
				this.vmethod_82().Enabled = this.m_Doctrine.method_164(Client.GetClientScenario());
			}
			Doctrine doctrine17 = this.m_Doctrine;
			comboBox_ = this.vmethod_82();
			clientScenario = Client.GetClientScenario();
			doctrine17.method_295(ref comboBox_, ref clientScenario, this.UseSAMsInASuWModeDoc);
			this.vmethod_83(comboBox_);
			this.vmethod_88().Checked = this.m_Doctrine.method_169(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_88().Visible = false;
				this.vmethod_86().Enabled = this.m_Doctrine.method_169(Client.GetClientScenario());
			}
			Doctrine doctrine18 = this.m_Doctrine;
			comboBox_ = this.vmethod_86();
			clientScenario = Client.GetClientScenario();
			doctrine18.method_297(ref comboBox_, ref clientScenario, this.IgnoreEMCONUnderAttackDoc);
			this.vmethod_87(comboBox_);
			this.vmethod_96().Checked = this.m_Doctrine.method_178(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_96().Visible = false;
				this.vmethod_92().Enabled = this.m_Doctrine.method_178(Client.GetClientScenario());
			}
			Doctrine doctrine19 = this.m_Doctrine;
			comboBox_ = this.vmethod_92();
			clientScenario = Client.GetClientScenario();
			doctrine19.method_299(ref comboBox_, ref clientScenario, ref this.bool_0, this.QuickTurnAroundDoc);
			this.vmethod_93(comboBox_);
			this.vmethod_104().Checked = this.m_Doctrine.method_183(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_104().Visible = false;
				this.vmethod_102().Enabled = this.m_Doctrine.method_183(Client.GetClientScenario());
			}
			Doctrine doctrine20 = this.m_Doctrine;
			comboBox_ = this.vmethod_102();
			clientScenario = Client.GetClientScenario();
			doctrine20.method_301(ref comboBox_, ref clientScenario, ref this.bool_0, this.AirOpsTempoDoc);
			this.vmethod_103(comboBox_);
			this.vmethod_174().Checked = this.m_Doctrine.method_188(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_174().Visible = false;
				this.vmethod_170().Enabled = this.m_Doctrine.method_188(Client.GetClientScenario());
			}
			Doctrine doctrine21 = this.m_Doctrine;
			comboBox_ = this.vmethod_170();
			clientScenario = Client.GetClientScenario();
			doctrine21.method_303(ref comboBox_, ref clientScenario, ref this.bool_0, this.BingoJokerDoct);
			this.vmethod_171(comboBox_);
			this.vmethod_176().Checked = this.m_Doctrine.method_193(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_176().Visible = false;
				this.vmethod_172().Enabled = this.m_Doctrine.method_193(Client.GetClientScenario());
			}
			Doctrine doctrine22 = this.m_Doctrine;
			comboBox_ = this.vmethod_172();
			clientScenario = Client.GetClientScenario();
			doctrine22.method_305(ref comboBox_, ref clientScenario, ref this.bool_0, this.WinchesterShotgunDoc);
			this.vmethod_173(comboBox_);
			this.vmethod_98().Checked = this.m_Doctrine.method_198(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_98().Visible = false;
				this.vmethod_94().Enabled = this.m_Doctrine.method_198(Client.GetClientScenario());
			}
			Doctrine doctrine23 = this.m_Doctrine;
			comboBox_ = this.vmethod_94();
			clientScenario = Client.GetClientScenario();
			doctrine23.method_307(ref comboBox_, ref clientScenario, this.UseTorpedoesKinematicRangeDoc);
			this.vmethod_95(comboBox_);
			this.vmethod_196().Checked = this.m_Doctrine.RefuelAllies_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_196().Visible = false;
				this.vmethod_192().Enabled = this.m_Doctrine.RefuelAllies_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine24 = this.m_Doctrine;
			comboBox_ = this.vmethod_192();
			clientScenario = Client.GetClientScenario();
			doctrine24.method_319(ref comboBox_, ref clientScenario, this.RefuelAlliedUnitsDoc);
			this.vmethod_193(comboBox_);
			this.vmethod_206().Checked = this.m_Doctrine.AvoidContact_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_206().Visible = false;
				this.vmethod_200().Enabled = this.m_Doctrine.AvoidContact_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine25 = this.m_Doctrine;
			comboBox_ = this.vmethod_200();
			clientScenario = Client.GetClientScenario();
			doctrine25.method_321(ref comboBox_, ref clientScenario, this.AvoidContactWhenPossibleDoc);
			this.vmethod_201(comboBox_);
			this.vmethod_208().Checked = this.m_Doctrine.DiveWhenThreatsDetected_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_208().Visible = false;
				this.vmethod_204().Enabled = this.m_Doctrine.DiveWhenThreatsDetected_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine26 = this.m_Doctrine;
			comboBox_ = this.vmethod_204();
			clientScenario = Client.GetClientScenario();
			doctrine26.method_323(ref comboBox_, ref clientScenario, this.DiveOnContactDoc);
			this.vmethod_205(comboBox_);
			this.vmethod_214().Checked = this.m_Doctrine.RechargePercentagePatrol_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_214().Visible = false;
				this.vmethod_212().Enabled = this.m_Doctrine.RechargePercentagePatrol_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine27 = this.m_Doctrine;
			comboBox_ = this.vmethod_212();
			clientScenario = Client.GetClientScenario();
			doctrine27.method_325(ref comboBox_, ref clientScenario, this.RechargeBatteryPercentageDoc);
			this.vmethod_213(comboBox_);
			this.vmethod_220().Checked = this.m_Doctrine.RechargePercentageAttack_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_220().Visible = false;
				this.vmethod_218().Enabled = this.m_Doctrine.RechargePercentageAttack_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine28 = this.m_Doctrine;
			comboBox_ = this.vmethod_218();
			clientScenario = Client.GetClientScenario();
			doctrine28.method_327(ref comboBox_, ref clientScenario, this.nullable_27);
			this.vmethod_219(comboBox_);
			this.vmethod_226().Checked = this.m_Doctrine.AIPUsage_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_226().Visible = false;
				this.vmethod_224().Enabled = this.m_Doctrine.AIPUsage_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine29 = this.m_Doctrine;
			comboBox_ = this.vmethod_224();
			clientScenario = Client.GetClientScenario();
			doctrine29.method_329(ref comboBox_, ref clientScenario, this._UseAIPDoc);
			this.vmethod_225(comboBox_);
			this.vmethod_232().Checked = this.m_Doctrine.DippingSonar_PlayerEditable(Client.GetClientScenario());
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				this.vmethod_232().Visible = false;
				this.vmethod_230().Enabled = this.m_Doctrine.DippingSonar_PlayerEditable(Client.GetClientScenario());
			}
			Doctrine doctrine30 = this.m_Doctrine;
			comboBox_ = this.vmethod_230();
			clientScenario = Client.GetClientScenario();
			doctrine30.method_331(ref comboBox_, ref clientScenario, this.UseDippingSonarDoc);
			this.vmethod_231(comboBox_);
			this.method_107(true);
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x002BED0C File Offset: 0x002BCF0C
		private void method_4()
		{
			this.method_106();
			if (!Information.IsNothing(this.subject))
			{
				if (this.subject.GetType() == typeof(Side))
				{
					this.GetButton_ResetCurrent_EMCON().Enabled = false;
					this.GetButton_ResetAffectedUnits_EMCON().Enabled = true;
					this.GetButton_ResetAffectedMissions_EMCON().Enabled = true;
				}
				else if (this.subject.IsMission)
				{
					this.GetButton_ResetCurrent_EMCON().Enabled = true;
					this.GetButton_ResetAffectedUnits_EMCON().Enabled = true;
					this.GetButton_ResetAffectedMissions_EMCON().Enabled = false;
				}
				else if (this.subject.GetType() == typeof(Group))
				{
					this.GetButton_ResetCurrent_EMCON().Enabled = true;
					this.GetButton_ResetAffectedUnits_EMCON().Enabled = true;
					this.GetButton_ResetAffectedMissions_EMCON().Enabled = false;
				}
				else if (this.subject.GetType() == typeof(Waypoint))
				{
					this.GetButton_ResetCurrent_EMCON().Enabled = false;
					this.GetButton_ResetAffectedUnits_EMCON().Enabled = false;
					this.GetButton_ResetAffectedMissions_EMCON().Enabled = false;
				}
				else
				{
					this.GetButton_ResetCurrent_EMCON().Enabled = true;
					this.GetButton_ResetAffectedUnits_EMCON().Enabled = false;
					this.GetButton_ResetAffectedMissions_EMCON().Enabled = false;
				}
			}
			else
			{
				this.GetButton_ResetCurrent_EMCON().Enabled = true;
				this.GetButton_ResetAffectedUnits_EMCON().Enabled = false;
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsGroup)
						{
							this.GetButton_ResetAffectedUnits_EMCON().Enabled = true;
							break;
						}
					}
				}
				this.GetButton_ResetAffectedMissions_EMCON().Enabled = false;
			}
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				this.m_Doctrine = this.method_104();
			}
			this.m_Doctrine.bool_30 = true;
			Doctrine doctrine = this.m_Doctrine;
			CheckBox cB_EMCON_Inherits = this.GetCB_EMCON_Inherits();
			doctrine.method_312(ref cB_EMCON_Inherits, ref this.subject, ref this.m_Doctrine);
			this.vmethod_11(cB_EMCON_Inherits);
			this.m_Doctrine.bool_30 = false;
			Doctrine doctrine2 = this.m_Doctrine;
			ComboBox comboBox_ = this.GetCB_EMCON_Radar();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine2.method_309(ref comboBox_, ref clientScenario, ref this.m_Doctrine);
			this.vmethod_7(comboBox_);
			Doctrine doctrine3 = this.m_Doctrine;
			comboBox_ = this.GetCB_EMCON_OECM();
			clientScenario = Client.GetClientScenario();
			doctrine3.method_310(ref comboBox_, ref clientScenario, ref this.m_Doctrine);
			this.vmethod_13(comboBox_);
			Doctrine doctrine4 = this.m_Doctrine;
			comboBox_ = this.GetCB_EMCON_Sonar();
			clientScenario = Client.GetClientScenario();
			doctrine4.method_311(ref comboBox_, ref clientScenario, ref this.m_Doctrine);
			this.vmethod_17(comboBox_);
			this.method_107(true);
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x002BEFD0 File Offset: 0x002BD1D0
		private void method_5()
		{
			if (!Information.IsNothing(this.subject))
			{
				if (this.subject.GetType() == typeof(Side))
				{
					this.GetButton_ResetCurrent_WRA().Enabled = true;
					this.GetButton_ResetAffectedUnits_WRA().Enabled = true;
					this.GetButton_ResetAffectedMissions_WRA().Enabled = true;
					this.GetButton_ResetCurrent_WRA().Text = "重置武器使用规则(使用系统缺省设置)";
				}
				else if (this.subject.IsMission)
				{
					this.GetButton_ResetCurrent_WRA().Enabled = true;
					this.GetButton_ResetAffectedUnits_WRA().Enabled = true;
					this.GetButton_ResetAffectedMissions_WRA().Enabled = false;
				}
				else if (this.subject.GetType() == typeof(Group))
				{
					this.GetButton_ResetCurrent_WRA().Enabled = true;
					this.GetButton_ResetAffectedUnits_WRA().Enabled = true;
					this.GetButton_ResetAffectedMissions_WRA().Enabled = false;
				}
				else if (this.subject.GetType() == typeof(Waypoint))
				{
					this.GetButton_ResetCurrent_WRA().Enabled = false;
					this.GetButton_ResetAffectedUnits_WRA().Enabled = false;
					this.GetButton_ResetAffectedMissions_WRA().Enabled = false;
				}
				else
				{
					this.GetButton_ResetCurrent_WRA().Enabled = true;
					this.GetButton_ResetAffectedUnits_WRA().Enabled = false;
					this.GetButton_ResetAffectedMissions_WRA().Enabled = false;
				}
			}
			else
			{
				this.GetButton_ResetCurrent_WRA().Enabled = true;
				this.GetButton_ResetAffectedUnits_WRA().Enabled = false;
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsGroup)
						{
							this.GetButton_ResetAffectedUnits_WRA().Enabled = true;
							break;
						}
					}
				}
				this.GetButton_ResetAffectedMissions_WRA().Enabled = false;
			}
			checked
			{
				try
				{
					if (!Information.IsNothing(Client.GetClientSide()) && Client.GetClientSide().ActiveUnitArray.Length != 0)
					{
						this.method_106();
						int num = 0;
						int index = 0;
						int firstDisplayedScrollingRowIndex = this.GetTGV_WRA().FirstDisplayedScrollingRowIndex;
						if (this.GetTGV_WRA().SelectedCells.Count > 0)
						{
							num = this.GetTGV_WRA().SelectedCells[0].RowIndex;
							index = this.GetTGV_WRA().SelectedCells[0].ColumnIndex;
						}
						this.GetTGV_WRA().Nodes.Clear();
						this.WRA_WeaponDictionary = new Dictionary<int, Doctrine.WRA_Weapon>();
						if (Information.IsNothing(this.ActiveUnitCollection))
						{
							this.method_7(ref this.m_Doctrine);
						}
						else
						{
							foreach (ActiveUnit current in this.ActiveUnitCollection)
							{
								this.method_7(ref current.m_Doctrine);
							}
						}
						if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Side))
						{
							foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current2 in this.WRA_WeaponDictionary)
							{
								int key = current2.Key;
								Weapon weapon = current2.Value.method_1(Client.GetClientScenario(), key);
								if (!Information.IsNothing(weapon.m_Doctrine.GetWRA_WeaponDictionary()))
								{
									foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current3 in weapon.m_Doctrine.GetWRA_WeaponDictionary())
									{
										Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current3.Value.WRA_WeaponTargetArray;
										int i = 0;
										IL_3EA:
										while (i < wRA_WeaponTargetArray.Length)
										{
											Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
											Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray2 = current2.Value.WRA_WeaponTargetArray;
											for (int j = 0; j < wRA_WeaponTargetArray2.Length; j++)
											{
												Doctrine.WRA_WeaponTarget wRA_WeaponTarget2 = wRA_WeaponTargetArray2[j];
												if (wRA_WeaponTarget2.WRA_WeaponTargetType == wRA_WeaponTarget.WRA_WeaponTargetType)
												{
													wRA_WeaponTarget2.WeaponQty = new int?(-1);
													wRA_WeaponTarget2.ShooterQty = new int?(-1);
													wRA_WeaponTarget2.SelfDefenceRange = new int?(-1);
													i++;
													goto IL_3EA;
												}
											}
											i++;
										}
									}
								}
							}
						}
						if (!Information.IsNothing(this.ActiveUnitCollection))
						{
							this.method_105();
						}
						this.method_8(ref this.m_Doctrine);
						List<KeyValuePair<int, Doctrine.WRA_Weapon>> list = this.WRA_WeaponDictionary.OrderBy(DoctrineForm.KeyWaluePairFunc0, new Class265<string[]>(true)).ToList<KeyValuePair<int, Doctrine.WRA_Weapon>>();
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current4 in list)
						{
							TreeGridViewRowNodes nodes = this.GetTGV_WRA().Nodes;
							object[] array = new object[3];
							array[0] = current4.Value.method_1(Client.GetClientScenario(), current4.Key).Name;
							TreeGridViewRow treeGridViewRow = nodes.method_1(array);
							treeGridViewRow.Tag = current4;
							Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray3 = current4.Value.WRA_WeaponTargetArray;
							for (int k = 0; k < wRA_WeaponTargetArray3.Length; k++)
							{
								Doctrine.WRA_WeaponTarget wRA_WeaponTarget3 = wRA_WeaponTargetArray3[k];
								int num2 = this.m_Doctrine.method_208(ref wRA_WeaponTarget3.WRA_WeaponTargetType, wRA_WeaponTarget3.WeaponQty);
								int num3 = this.m_Doctrine.method_210(wRA_WeaponTarget3.ShooterQty);
								int num4 = this.m_Doctrine.method_212(ref wRA_WeaponTarget3.WRA_WeaponTargetType, wRA_WeaponTarget3.SelfDefenceRange);
								int num5 = this.m_Doctrine.method_214(wRA_WeaponTarget3.FiringRange);
								TreeGridViewRow treeGridViewRow2 = treeGridViewRow.Nodes.method_1(new object[]
								{
									this.m_Doctrine.GetWRA_WeaponTargetTypeString(wRA_WeaponTarget3.WRA_WeaponTargetType),
									num2,
									num3,
									num5,
									num4
								});
								treeGridViewRow2.Tag = wRA_WeaponTarget3;
								if (this.m_Doctrine.method_32(ref wRA_WeaponTarget3.WRA_WeaponTargetType))
								{
									treeGridViewRow2.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
								}
							}
							DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
							DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
							DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
							DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
							dataGridViewTextBoxCell3.Value = "";
							this.GetTGV_WRA()[this.GetWeaponsPerSalvo().Index, treeGridViewRow.method_0()] = dataGridViewTextBoxCell;
							this.GetTGV_WRA()[this.GetShootersPerSalvo().Index, treeGridViewRow.method_0()] = dataGridViewTextBoxCell4;
							this.GetTGV_WRA()[this.GetFiringRange().Index, treeGridViewRow.method_0()] = dataGridViewTextBoxCell2;
							this.GetTGV_WRA()[this.GetSelfDefenceRange().Index, treeGridViewRow.method_0()] = dataGridViewTextBoxCell3;
							dataGridViewTextBoxCell.ReadOnly = true;
							dataGridViewTextBoxCell2.ReadOnly = true;
							dataGridViewTextBoxCell3.ReadOnly = true;
							dataGridViewTextBoxCell4.ReadOnly = true;
							foreach (int current5 in this.collection_1)
							{
								foreach (TreeGridViewRow current6 in this.GetTGV_WRA().Nodes)
								{
									try
									{
										if (((KeyValuePair<int, Doctrine.WRA_Weapon>)current6.Tag).Key == current5)
										{
											current6.vmethod_4();
										}
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										ex2.Data.Add("Error at 200268", ex2.Message);
										GameGeneral.LogException(ref ex2);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										ProjectData.ClearProjectError();
									}
								}
							}
						}
						if (this.GetTGV_WRA().GetRows().Count != 0 & num != 0)
						{
							this.GetTGV_WRA().GetRows()[num].Cells[index].Selected = true;
							if (firstDisplayedScrollingRowIndex != -1)
							{
								this.GetTGV_WRA().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
							}
						}
						this.method_107(true);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 101195", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x002BF904 File Offset: 0x002BDB04
		private void method_6()
		{
			this.method_106();
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				this.m_Doctrine = this.method_104();
			}
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.GetCombo_WithdrawDamageThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_342(ref comboBox_, ref clientScenario, this.WithdrawDamageThresholdDoc);
			this.vmethod_251(comboBox_);
			Doctrine doctrine2 = this.m_Doctrine;
			comboBox_ = this.GetCombo_WithdrawFuelThreshold();
			clientScenario = Client.GetClientScenario();
			doctrine2.method_343(ref comboBox_, ref clientScenario, this.WithdrawFuelThresholdDoc);
			this.vmethod_241(comboBox_);
			Doctrine doctrine3 = this.m_Doctrine;
			comboBox_ = this.GetCombo_WithdrawAttackThreshold();
			clientScenario = Client.GetClientScenario();
			doctrine3.method_344(ref comboBox_, ref clientScenario, this.WithdrawAttackThresholdDoc);
			this.vmethod_239(comboBox_);
			Doctrine doctrine4 = this.m_Doctrine;
			comboBox_ = this.GetCombo_WithdrawDefenceThreshold();
			clientScenario = Client.GetClientScenario();
			doctrine4.method_345(ref comboBox_, ref clientScenario, this.WithdrawDefenceThresholdDoc);
			this.vmethod_237(comboBox_);
			Doctrine doctrine5 = this.m_Doctrine;
			comboBox_ = this.vmethod_268();
			clientScenario = Client.GetClientScenario();
			doctrine5.method_346(ref comboBox_, ref clientScenario, this.RedeployDamageThresholdDoc);
			this.vmethod_269(comboBox_);
			Doctrine doctrine6 = this.m_Doctrine;
			comboBox_ = this.GetCombo_RedeployFuelThreshold();
			clientScenario = Client.GetClientScenario();
			doctrine6.method_347(ref comboBox_, ref clientScenario, this.RedeployFuelThresholdDoc);
			this.vmethod_259(comboBox_);
			Doctrine doctrine7 = this.m_Doctrine;
			comboBox_ = this.GetCombo_RedeployAttackThreshold();
			clientScenario = Client.GetClientScenario();
			doctrine7.method_348(ref comboBox_, ref clientScenario, this.RedeployAttackWeaponQuantityThresholdDoc);
			this.vmethod_257(comboBox_);
			Doctrine doctrine8 = this.m_Doctrine;
			comboBox_ = this.GetCombo_RedeployDefenceThreshold();
			clientScenario = Client.GetClientScenario();
			doctrine8.method_349(ref comboBox_, ref clientScenario, this.RedeployDefenceWeaponQuantityThresholdDoc);
			this.vmethod_255(comboBox_);
			this.method_107(true);
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x002BFA9C File Offset: 0x002BDC9C
		private void method_7(ref Doctrine doctrine_1)
		{
			foreach (ActiveUnit current in doctrine_1.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
			{
				if (current.GetSide(false) == Client.GetClientSide() && !current.IsWeapon)
				{
					if (current.IsAircraft)
					{
						this.method_11(current);
						this.method_9(current);
					}
					else if (current.IsShip || current.IsSubmarine || current.IsFacility)
					{
						this.method_11(current);
						this.method_10(current);
					}
				}
			}
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x002BFB58 File Offset: 0x002BDD58
		private void method_8(ref Doctrine doctrine_1)
		{
			checked
			{
				if (!Information.IsNothing(doctrine_1.GetWRA_WeaponDictionary()))
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current in doctrine_1.GetWRA_WeaponDictionary())
					{
						int key = current.Key;
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = current.Value.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (this.WRA_WeaponDictionary.ContainsKey(key))
							{
								Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
								this.WRA_WeaponDictionary.TryGetValue(key, out wRA_Weapon);
								Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray2 = wRA_Weapon.WRA_WeaponTargetArray;
								for (int j = 0; j < wRA_WeaponTargetArray2.Length; j++)
								{
									Doctrine.WRA_WeaponTarget wRA_WeaponTarget2 = wRA_WeaponTargetArray2[j];
									if (wRA_WeaponTarget2.WRA_WeaponTargetType == wRA_WeaponTarget.WRA_WeaponTargetType)
									{
										wRA_WeaponTarget2.WeaponQty = wRA_WeaponTarget.WeaponQty;
										wRA_WeaponTarget2.ShooterQty = wRA_WeaponTarget.ShooterQty;
										wRA_WeaponTarget2.SelfDefenceRange = wRA_WeaponTarget.SelfDefenceRange;
										wRA_WeaponTarget2.FiringRange = wRA_WeaponTarget.FiringRange;
										break;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x002BFC90 File Offset: 0x002BDE90
		public void method_9(ActiveUnit activeUnit_)
		{
			checked
			{
				if (!Information.IsNothing(((Aircraft)activeUnit_).GetLoadout()))
				{
					WeaponRec[] weaponRecArray = ((Aircraft)activeUnit_).GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						Weapon weapon = weaponRecArray[i].GetWeapon(Client.GetClientScenario());
						if (this.m_Doctrine.IsLethalWeapon(ref weapon))
						{
							this.method_12(ref weapon);
						}
					}
				}
			}
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x002BFCF8 File Offset: 0x002BDEF8
		public void method_10(ActiveUnit activeUnit_)
		{
			IEnumerable<Magazine> enumerable = activeUnit_.GetMagazines().OrderBy(DoctrineForm.MagazineFunc1);
			foreach (Magazine current in enumerable)
			{
				if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
				{
					using (IEnumerator<WeaponRec> enumerator2 = current.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Weapon weapon = enumerator2.Current.GetWeapon(Client.GetClientScenario());
							if (this.m_Doctrine.IsLethalWeapon(ref weapon))
							{
								this.method_12(ref weapon);
							}
						}
					}
				}
			}
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x002BFDBC File Offset: 0x002BDFBC
		public void method_11(ActiveUnit activeUnit_0)
		{
			IEnumerable<Mount> enumerable = activeUnit_0.m_Mounts.OrderBy(DoctrineForm.MountFunc2);
			foreach (Mount current in enumerable)
			{
				if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
				{
					using (IEnumerator<WeaponRec> enumerator2 = current.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Weapon weapon = enumerator2.Current.GetWeapon(Client.GetClientScenario());
							if (this.m_Doctrine.IsLethalWeapon(ref weapon))
							{
								this.method_12(ref weapon);
							}
						}
					}
				}
			}
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x002BFE80 File Offset: 0x002BE080
		public void method_12(ref Weapon weapon_)
		{
			if (!this.WRA_WeaponDictionary.ContainsKey(weapon_.DBID))
			{
				Doctrine.WRA_Weapon value = new Doctrine.WRA_Weapon(ref weapon_, Client.GetClientScenario());
				this.WRA_WeaponDictionary.Add(weapon_.DBID, value);
			}
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x00029A47 File Offset: 0x00027C47
		private void method_13(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x002BFEC0 File Offset: 0x002BE0C0
		private void method_14()
		{
			if (!CommandFactory.GetCommandMain().GetMainForm().rightColumnWPF_0.bool_1 && (!Information.IsNothing(this.subject) || !Information.IsNothing(this.ActiveUnitCollection)))
			{
				switch (this.vmethod_0().SelectedIndex)
				{
				case 0:
					this.method_3();
					break;
				case 1:
					this.method_4();
					break;
				case 2:
					this.method_5();
					break;
				case 3:
					this.method_6();
					break;
				}
			}
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x00029A4F File Offset: 0x00027C4F
		private void method_15(object sender, EventArgs e)
		{
			this.m_Doctrine.SetUseNukes_PlayerEditable(Client.GetClientScenario(), this.vmethod_48().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x00029A86 File Offset: 0x00027C86
		private void method_16(object sender, EventArgs e)
		{
			this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingPlayerEditable(Client.GetClientScenario(), this.vmethod_138().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x00029ABD File Offset: 0x00027CBD
		private void method_17(object sender, EventArgs e)
		{
			this.int_5 = this.vmethod_136().SelectedIndex;
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x00029AD0 File Offset: 0x00027CD0
		private void method_18(object sender, EventArgs e)
		{
			this.m_Doctrine.SetWCS_Air_PlayerEditable(Client.GetClientScenario(), this.vmethod_46().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x00029B07 File Offset: 0x00027D07
		private void method_19(object sender, EventArgs e)
		{
			this.m_Doctrine.SetWCS_Surface_PlayerEditable(Client.GetClientScenario(), this.vmethod_146().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x00029B3E File Offset: 0x00027D3E
		private void method_20(object sender, EventArgs e)
		{
			this.m_Doctrine.SetWCS_Submarine_PlayerEditable(Client.GetClientScenario(), this.vmethod_148().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x00029B75 File Offset: 0x00027D75
		private void method_21(object sender, EventArgs e)
		{
			this.m_Doctrine.SetWCSLand_PlayerEditable(Client.GetClientScenario(), this.vmethod_150().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00029BAC File Offset: 0x00027DAC
		private void method_22(object sender, EventArgs e)
		{
			this.m_Doctrine.method_170(Client.GetClientScenario(), this.vmethod_88().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x00029BE3 File Offset: 0x00027DE3
		private void method_23(object sender, EventArgs e)
		{
			this.m_Doctrine.method_150(Client.GetClientScenario(), this.vmethod_76().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00029C1A File Offset: 0x00027E1A
		private void method_24(object sender, EventArgs e)
		{
			this.m_Doctrine.method_155(Client.GetClientScenario(), this.vmethod_284().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x00029C51 File Offset: 0x00027E51
		private void method_25(object sender, EventArgs e)
		{
			this.m_Doctrine.method_165(Client.GetClientScenario(), this.vmethod_84().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x00029C88 File Offset: 0x00027E88
		private void method_26(object sender, EventArgs e)
		{
			this.m_Doctrine.method_145(Client.GetClientScenario(), this.vmethod_160().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x00029CBF File Offset: 0x00027EBF
		private void method_27(object sender, EventArgs e)
		{
			this.int_0 = this.vmethod_56().SelectedIndex;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x00029CD2 File Offset: 0x00027ED2
		private void method_28(object sender, EventArgs e)
		{
			this.int_15 = this.vmethod_92().SelectedIndex;
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x00029CE5 File Offset: 0x00027EE5
		private void method_29(object sender, EventArgs e)
		{
			this.int_16 = this.vmethod_102().SelectedIndex;
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00029CF8 File Offset: 0x00027EF8
		private void method_30(object sender, EventArgs e)
		{
			this.int_17 = this.vmethod_170().SelectedIndex;
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x00029D0B File Offset: 0x00027F0B
		private void method_31(object sender, EventArgs e)
		{
			this.int_19 = this.vmethod_172().SelectedIndex;
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00029D1E File Offset: 0x00027F1E
		private void method_32(object sender, EventArgs e)
		{
			this.int_21 = this.vmethod_94().SelectedIndex;
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00029D31 File Offset: 0x00027F31
		private void method_33(object sender, EventArgs e)
		{
			this.int_1 = this.vmethod_54().SelectedIndex;
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00029D44 File Offset: 0x00027F44
		private void method_34(object sender, EventArgs e)
		{
			this.int_2 = this.vmethod_152().SelectedIndex;
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00029D57 File Offset: 0x00027F57
		private void method_35(object sender, EventArgs e)
		{
			this.int_3 = this.vmethod_154().SelectedIndex;
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00029D6A File Offset: 0x00027F6A
		private void method_36(object sender, EventArgs e)
		{
			this.int_4 = this.vmethod_156().SelectedIndex;
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x00029D7D File Offset: 0x00027F7D
		private void method_37(object sender, EventArgs e)
		{
			this.int_22 = this.vmethod_162().SelectedIndex;
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x002BFF48 File Offset: 0x002BE148
		private void method_38(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_56();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_264(ref comboBox_, ref clientScenario, ref this.int_0, true, false);
			this.vmethod_57(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x002BFF88 File Offset: 0x002BE188
		private void method_39(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_92();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_300(ref comboBox_, ref clientScenario, ref this.int_15, ref this.bool_0, true, false);
			this.vmethod_93(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x002BFFD0 File Offset: 0x002BE1D0
		private void method_40(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_102();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_302(ref comboBox_, ref clientScenario, ref this.int_16, ref this.bool_0, true, false);
			this.vmethod_103(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x002C0018 File Offset: 0x002BE218
		private void method_41(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_170();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_304(ref comboBox_, ref clientScenario, ref this.int_17, ref this.bool_0, ref this.bool_5, true, false);
			this.vmethod_171(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x002C0064 File Offset: 0x002BE264
		private void method_42(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_172();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_306(ref comboBox_, ref clientScenario, ref this.int_19, ref this.bool_0, true, false);
			this.vmethod_173(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x002C00AC File Offset: 0x002BE2AC
		private void method_43(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_94();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_308(ref comboBox_, ref clientScenario, ref this.int_21, true, false);
			this.vmethod_95(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x002C00EC File Offset: 0x002BE2EC
		private void method_44(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_54();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_266(ref comboBox_, ref clientScenario, ref this.int_1, true, false);
			this.vmethod_55(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x002C012C File Offset: 0x002BE32C
		private void method_45(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_152();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_268(ref comboBox_, ref clientScenario, ref this.int_2, true, false);
			this.vmethod_153(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x002C016C File Offset: 0x002BE36C
		private void method_46(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_154();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_270(ref comboBox_, ref clientScenario, ref this.int_3, true, false);
			this.vmethod_155(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x002C01AC File Offset: 0x002BE3AC
		private void method_47(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_156();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_272(ref comboBox_, ref clientScenario, ref this.int_4, true, false);
			this.vmethod_157(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x002C01EC File Offset: 0x002BE3EC
		private void method_48(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_162();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_288(ref comboBox_, ref clientScenario, ref this.int_22, true, false);
			this.vmethod_163(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x002C022C File Offset: 0x002BE42C
		private void method_49(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_136();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_274(ref comboBox_, ref clientScenario, ref this.int_5, true, false);
			this.vmethod_137(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x00029D90 File Offset: 0x00027F90
		private void method_50(object sender, EventArgs e)
		{
			this.m_Doctrine.method_120(Client.GetClientScenario(), this.vmethod_42().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x002C026C File Offset: 0x002BE46C
		private void method_51(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Side))
			{
				this.GetCB_EMCON_Inherits().Checked = false;
				this.GetCB_EMCON_Inherits().Enabled = false;
			}
			else
			{
				Doctrine doctrine = this.m_Doctrine;
				CheckBox cB_EMCON_Inherits = this.GetCB_EMCON_Inherits();
				ComboBox cB_EMCON_Radar = this.GetCB_EMCON_Radar();
				ComboBox cB_EMCON_OECM = this.GetCB_EMCON_OECM();
				ComboBox comboBox_ = this.GetCB_EMCON_Sonar();
				doctrine.method_313(ref cB_EMCON_Inherits, ref cB_EMCON_Radar, ref cB_EMCON_OECM, ref comboBox_, ref this.m_Doctrine, Client.GetClientScenario(), true, false);
				this.vmethod_17(comboBox_);
				this.vmethod_13(cB_EMCON_OECM);
				this.vmethod_7(cB_EMCON_Radar);
				this.vmethod_11(cB_EMCON_Inherits);
				Doctrine doctrine2 = this.m_Doctrine;
				comboBox_ = this.GetCB_EMCON_Radar();
				Scenario clientScenario = Client.GetClientScenario();
				doctrine2.method_309(ref comboBox_, ref clientScenario, ref this.m_Doctrine);
				this.vmethod_7(comboBox_);
				Doctrine doctrine3 = this.m_Doctrine;
				comboBox_ = this.GetCB_EMCON_OECM();
				clientScenario = Client.GetClientScenario();
				doctrine3.method_310(ref comboBox_, ref clientScenario, ref this.m_Doctrine);
				this.vmethod_13(comboBox_);
				Doctrine doctrine4 = this.m_Doctrine;
				comboBox_ = this.GetCB_EMCON_Sonar();
				clientScenario = Client.GetClientScenario();
				doctrine4.method_311(ref comboBox_, ref clientScenario, ref this.m_Doctrine);
				this.vmethod_17(comboBox_);
			}
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x002C03B4 File Offset: 0x002BE5B4
		private void method_52(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox cB_EMCON_Radar = this.GetCB_EMCON_Radar();
			Scenario clientScenario = Client.GetClientScenario();
			bool bool_ = false;
			bool flag = !this.bool_3 && !this.bool_4;
			doctrine.method_314(ref cB_EMCON_Radar, ref clientScenario, ref this.m_Doctrine, bool_, ref flag, ref this.bool_5, true, false);
			this.vmethod_7(cB_EMCON_Radar);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			this.method_14();
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x002C0424 File Offset: 0x002BE624
		private void method_53(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox cB_EMCON_OECM = this.GetCB_EMCON_OECM();
			Scenario clientScenario = Client.GetClientScenario();
			bool bool_ = false;
			bool flag = !this.bool_3 && !this.bool_4;
			doctrine.method_315(ref cB_EMCON_OECM, ref clientScenario, ref this.m_Doctrine, bool_, ref flag, ref this.bool_5, true, false);
			this.vmethod_13(cB_EMCON_OECM);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			this.method_14();
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x002C0494 File Offset: 0x002BE694
		private void method_54(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox cB_EMCON_Sonar = this.GetCB_EMCON_Sonar();
			Scenario clientScenario = Client.GetClientScenario();
			bool bool_ = false;
			bool flag = !this.bool_3 && !this.bool_4;
			doctrine.method_316(ref cB_EMCON_Sonar, ref clientScenario, ref this.m_Doctrine, bool_, ref flag, ref this.bool_5, true, false);
			this.vmethod_17(cB_EMCON_Sonar);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			this.method_14();
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x00029DC7 File Offset: 0x00027FC7
		private void method_55(object sender, EventArgs e)
		{
			this.int_20 = this.vmethod_52().SelectedIndex;
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x002C0504 File Offset: 0x002BE704
		private void method_56(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_52();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_276(ref comboBox_, ref clientScenario, ref this.int_20, true, false);
			this.vmethod_53(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x00029DDA File Offset: 0x00027FDA
		private void method_57(object sender, EventArgs e)
		{
			this.int_18 = this.vmethod_186().SelectedIndex;
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x002C0544 File Offset: 0x002BE744
		private void method_58(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_186();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_278(ref comboBox_, ref clientScenario, ref this.int_18, true, false);
			this.vmethod_187(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x00029DED File Offset: 0x00027FED
		private void method_59(object sender, EventArgs e)
		{
			this.int_6 = this.vmethod_178().SelectedIndex;
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x002C0584 File Offset: 0x002BE784
		private void method_60(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_178();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_280(ref comboBox_, ref clientScenario, ref this.int_6, true, false);
			this.vmethod_179(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x00029E00 File Offset: 0x00028000
		private void method_61(object sender, EventArgs e)
		{
			this.int_7 = this.GetCombo_BehaviorTowardsAmbigousTarget().SelectedIndex;
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x002C05C4 File Offset: 0x002BE7C4
		private void method_62(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_BehaviorTowardsAmbigousTarget = this.GetCombo_BehaviorTowardsAmbigousTarget();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_282(ref combo_BehaviorTowardsAmbigousTarget, ref clientScenario, ref this.int_7, true, false);
			this.vmethod_61(combo_BehaviorTowardsAmbigousTarget);
			this.method_14();
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x00029E13 File Offset: 0x00028013
		private void method_63(object sender, EventArgs e)
		{
			this.m_Doctrine.SetBehaviorTowardsAmbigousTarget_PlayerEditable(Client.GetClientScenario(), this.vmethod_62().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x00029E4A File Offset: 0x0002804A
		private void method_64(object sender, EventArgs e)
		{
			this.int_8 = this.vmethod_66().SelectedIndex;
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x002C0604 File Offset: 0x002BE804
		private void method_65(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_66();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_284(ref comboBox_, ref clientScenario, ref this.int_8, true, false);
			this.vmethod_67(comboBox_);
			this.method_14();
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x00029E5D File Offset: 0x0002805D
		private void method_66(object sender, EventArgs e)
		{
			this.m_Doctrine.method_135(Client.GetClientScenario(), this.vmethod_68().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x00029E94 File Offset: 0x00028094
		private void method_67(object sender, EventArgs e)
		{
			this.m_Doctrine.method_140(Client.GetClientScenario(), this.vmethod_72().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x002C0644 File Offset: 0x002BE844
		private void method_68(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_70();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_286(ref comboBox_, ref clientScenario, ref this.int_9, true, false);
			this.vmethod_71(comboBox_);
			this.method_14();
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x00029ECB File Offset: 0x000280CB
		private void method_69(object sender, EventArgs e)
		{
			this.int_12 = this.vmethod_78().SelectedIndex;
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x002C0684 File Offset: 0x002BE884
		private void method_70(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_78();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_294(ref comboBox_, ref clientScenario, ref this.int_12, true, false);
			this.vmethod_79(comboBox_);
			Doctrine doctrine2 = this.m_Doctrine;
			clientScenario = Client.GetClientScenario();
			Side clientSide = Client.GetClientSide();
			doctrine2.method_333(ref clientScenario, ref clientSide);
			Client.SetClientSide(clientSide);
			this.method_14();
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x00029EDE File Offset: 0x000280DE
		private void method_71(object sender, EventArgs e)
		{
			this.int_10 = this.vmethod_74().SelectedIndex;
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x002C06EC File Offset: 0x002BE8EC
		private void method_72(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_74()).SelectedIndex;
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_290(ref selectedIndex, ref clientScenario, ref this.int_10, true, false, false);
			comboBox.SelectedIndex = selectedIndex;
			this.method_14();
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x00029EF1 File Offset: 0x000280F1
		private void method_73(object sender, EventArgs e)
		{
			this.int_11 = this.vmethod_286().SelectedIndex;
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x002C0734 File Offset: 0x002BE934
		private void method_74(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_286()).SelectedIndex;
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_292(ref selectedIndex, ref clientScenario, ref this.int_11, true, false, false);
			comboBox.SelectedIndex = selectedIndex;
			this.method_14();
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x002C077C File Offset: 0x002BE97C
		private void DoctrineForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (Operators.CompareString(e.KeyValue.ToString(), "120", false) == 0 && e.Control && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x00029F04 File Offset: 0x00028104
		private void method_75(object sender, EventArgs e)
		{
			this.m_Doctrine.method_160(Client.GetClientScenario(), this.vmethod_80().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x00029F3B File Offset: 0x0002813B
		private void method_76(object sender, EventArgs e)
		{
			this.m_Doctrine.method_165(Client.GetClientScenario(), this.vmethod_84().Checked);
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x00029F58 File Offset: 0x00028158
		private void method_77(object sender, EventArgs e)
		{
			this.int_13 = this.vmethod_82().SelectedIndex;
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x002C0880 File Offset: 0x002BEA80
		private void method_78(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_82();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_296(ref comboBox_, ref clientScenario, ref this.int_14, true, false);
			this.vmethod_83(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x00029F6B File Offset: 0x0002816B
		private void method_79(object sender, EventArgs e)
		{
			this.m_Doctrine.method_170(Client.GetClientScenario(), this.vmethod_88().Checked);
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x00029F88 File Offset: 0x00028188
		private void method_80(object sender, EventArgs e)
		{
			this.int_14 = this.vmethod_86().SelectedIndex;
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x002C08C0 File Offset: 0x002BEAC0
		private void method_81(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_86();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_298(ref comboBox_, ref clientScenario, ref this.int_14, true, false);
			this.vmethod_87(comboBox_);
			this.method_14();
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x00029F9B File Offset: 0x0002819B
		private void method_82(object sender, EventArgs e)
		{
			this.m_Doctrine.method_184(Client.GetClientScenario(), this.vmethod_104().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x00029FD2 File Offset: 0x000281D2
		private void method_83(object sender, EventArgs e)
		{
			this.m_Doctrine.method_179(Client.GetClientScenario(), this.vmethod_96().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0002A009 File Offset: 0x00028209
		private void method_84(object sender, EventArgs e)
		{
			this.m_Doctrine.method_194(Client.GetClientScenario(), this.vmethod_176().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x0002A040 File Offset: 0x00028240
		private void method_85(object sender, EventArgs e)
		{
			this.m_Doctrine.method_189(Client.GetClientScenario(), this.vmethod_174().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x0002A077 File Offset: 0x00028277
		private void method_86(object sender, EventArgs e)
		{
			this.m_Doctrine.method_199(Client.GetClientScenario(), this.vmethod_98().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x002C0900 File Offset: 0x002BEB00
		private void TGV_WRA_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1 && e.ColumnIndex != -1)
				{
					foreach (TreeGridViewRow current in this.GetTGV_WRA().Nodes)
					{
						if (current.Selected)
						{
							break;
						}
						int key = ((KeyValuePair<int, Doctrine.WRA_Weapon>)current.Tag).Key;
						Weapon weapon = ((KeyValuePair<int, Doctrine.WRA_Weapon>)current.Tag).Value.method_1(Client.GetClientScenario(), key);
						foreach (TreeGridViewRow current2 in current.Nodes)
						{
							if (current2.Selected)
							{
								DataTable dataSource = new DataTable();
								DataTable dataSource2 = new DataTable();
								DataTable dataSource3 = new DataTable();
								DataTable dataSource4 = new DataTable();
								Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = ((Doctrine.WRA_WeaponTarget)current2.Tag).WRA_WeaponTargetType;
								DataGridViewColumn dataGridViewColumn = this.GetTGV_WRA().Columns[e.ColumnIndex];
								if (Operators.CompareString(dataGridViewColumn.Name, "WeaponsPerSalvo", false) != 0)
								{
									if (Operators.CompareString(dataGridViewColumn.Name, "ShootersPerSalvo", false) != 0)
									{
										if (Operators.CompareString(dataGridViewColumn.Name, "SelfDefenceRange", false) != 0)
										{
											if (Operators.CompareString(dataGridViewColumn.Name, "FiringRange", false) != 0)
											{
												continue;
											}
											DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.GetTGV_WRA()[this.GetFiringRange().Index, current2.method_0()];
											this.m_Doctrine.method_203(ref dataSource4, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
											DataGridViewComboBoxCell dataGridViewComboBoxCell2 = dataGridViewComboBoxCell;
											dataGridViewComboBoxCell2.DataSource = dataSource4;
											dataGridViewComboBoxCell2.DropDownWidth = 500;
											dataGridViewComboBoxCell2.DisplayMember = "Description";
											dataGridViewComboBoxCell2.ValueMember = "ID";
											this.GetTGV_WRA().BeginEdit(true);
											((DataGridViewComboBoxEditingControl)this.GetTGV_WRA().EditingControl).DroppedDown = true;
										}
										else
										{
											DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.GetTGV_WRA()[this.GetSelfDefenceRange().Index, current2.method_0()];
											this.m_Doctrine.method_202(ref dataSource3, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell3.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
											DataGridViewComboBoxCell dataGridViewComboBoxCell4 = dataGridViewComboBoxCell3;
											dataGridViewComboBoxCell4.DataSource = dataSource3;
											dataGridViewComboBoxCell4.DropDownWidth = 500;
											dataGridViewComboBoxCell4.DisplayMember = "Description";
											dataGridViewComboBoxCell4.ValueMember = "ID";
											this.GetTGV_WRA().BeginEdit(true);
											((DataGridViewComboBoxEditingControl)this.GetTGV_WRA().EditingControl).DroppedDown = true;
										}
									}
									else
									{
										DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.GetTGV_WRA()[this.GetShootersPerSalvo().Index, current2.method_0()];
										this.m_Doctrine.method_201(ref dataSource2, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell5.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
										DataGridViewComboBoxCell dataGridViewComboBoxCell6 = dataGridViewComboBoxCell5;
										dataGridViewComboBoxCell6.DataSource = dataSource2;
										dataGridViewComboBoxCell6.DisplayMember = "Description";
										dataGridViewComboBoxCell6.ValueMember = "ID";
										dataGridViewComboBoxCell6.DropDownWidth = 500;
										this.GetTGV_WRA().BeginEdit(true);
										((DataGridViewComboBoxEditingControl)this.GetTGV_WRA().EditingControl).DroppedDown = true;
									}
								}
								else
								{
									DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)this.GetTGV_WRA()[this.GetWeaponsPerSalvo().Index, current2.method_0()];
									this.m_Doctrine.method_200(ref dataSource, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell7.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
									DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell7;
									dataGridViewComboBoxCell8.DataSource = dataSource;
									dataGridViewComboBoxCell8.DisplayMember = "Description";
									dataGridViewComboBoxCell8.ValueMember = "ID";
									dataGridViewComboBoxCell8.DropDownWidth = 500;
									this.GetTGV_WRA().BeginEdit(true);
									((DataGridViewComboBoxEditingControl)this.GetTGV_WRA().EditingControl).DroppedDown = true;
								}
								break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200123", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x002C0E08 File Offset: 0x002BF008
		private void TGV_WRA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bool_1 && this.GetTGV_WRA().SelectedRows.Count != 0)
			{
				TreeGridViewRow treeGridViewRow = null;
				foreach (TreeGridViewRow current in this.GetTGV_WRA().Nodes)
				{
					bool flag = false;
					foreach (TreeGridViewRow current2 in current.Nodes)
					{
						if (current2.Selected)
						{
							treeGridViewRow = current2;
							flag = true;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (!Information.IsNothing(treeGridViewRow) && !Information.IsNothing(treeGridViewRow.method_7()))
				{
					TreeGridViewRow class2384_ = treeGridViewRow.method_7();
					this.method_90(e, treeGridViewRow, class2384_);
				}
			}
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x0002A0AE File Offset: 0x000282AE
		private void TGV_WRA_CellValueChanged_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			this.bool_1 = true;
			if (this.GetTGV_WRA().IsCurrentCellDirty)
			{
				this.GetTGV_WRA().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x002C0F00 File Offset: 0x002BF100
		private void method_90(DataGridViewCellEventArgs dataGridViewCellEventArgs_0, TreeGridViewRow class2384_0, TreeGridViewRow class2384_1)
		{
			RuntimeHelpers.GetObjectValue(this.GetTGV_WRA()[dataGridViewCellEventArgs_0.ColumnIndex, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue = RuntimeHelpers.GetObjectValue(this.GetTGV_WRA()[this.GetWeaponsPerSalvo().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(this.GetTGV_WRA()[this.GetShootersPerSalvo().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(this.GetTGV_WRA()[this.GetSelfDefenceRange().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(this.GetTGV_WRA()[this.GetFiringRange().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = ((Doctrine.WRA_WeaponTarget)class2384_0.Tag).WRA_WeaponTargetType;
			bool bChangeWeaponsPerSalvo = false;
			int? weaponsPerSalvo = new int?(0);
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.GetWeaponsPerSalvo().Index)
			{
				bChangeWeaponsPerSalvo = true;
				weaponsPerSalvo = this.m_Doctrine.GetWeaponsPerSalvo(ref wRA_WeaponTargetType, ref objectValue);
			}
			bool bChangeShootersPerSalvo = false;
			int? shootersPerSalvo = new int?(0);
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.GetShootersPerSalvo().Index)
			{
				bChangeShootersPerSalvo = true;
				shootersPerSalvo = this.m_Doctrine.GetShootersPerSalvo(ref objectValue2);
			}
			bool bChangeSelfDefenceRange = false;
			int? selfDefenceRange = new int?(0);
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.GetSelfDefenceRange().Index)
			{
				bChangeSelfDefenceRange = true;
				selfDefenceRange = this.m_Doctrine.GetSelfDefenceRange(ref wRA_WeaponTargetType, ref objectValue3);
			}
			bool bChangeFiringRange = false;
			int? firingRange = new int?(0);
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.GetFiringRange().Index)
			{
				bChangeFiringRange = true;
				firingRange = this.m_Doctrine.GetFiringRange(ref objectValue4);
			}
			int key = ((KeyValuePair<int, Doctrine.WRA_Weapon>)class2384_1.Tag).Key;
			KeyValuePair<int, Doctrine.WRA_Weapon> arg_1F9_0 = (KeyValuePair<int, Doctrine.WRA_Weapon>)class2384_1.Tag;
			this.method_91(ref this.m_Doctrine, weaponsPerSalvo, bChangeWeaponsPerSalvo, shootersPerSalvo, bChangeShootersPerSalvo, firingRange, bChangeFiringRange, selfDefenceRange, bChangeSelfDefenceRange, key, wRA_WeaponTargetType);
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				foreach (ActiveUnit current in this.ActiveUnitCollection)
				{
					this.method_91(ref current.m_Doctrine, weaponsPerSalvo, bChangeWeaponsPerSalvo, shootersPerSalvo, bChangeShootersPerSalvo, firingRange, bChangeFiringRange, selfDefenceRange, bChangeSelfDefenceRange, key, wRA_WeaponTargetType);
				}
			}
			if (this.m_Doctrine.method_32(ref wRA_WeaponTargetType))
			{
				this.method_14();
			}
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x002C11B0 File Offset: 0x002BF3B0
		private void method_91(ref Doctrine doctrine_1, int? WeaponsPerSalvo_, bool bChangeWeaponsPerSalvo, int? iShootersPerSalvo, bool bChangeShootersPerSalvo, int? iFiringRange_, bool bChangeFiringRange, int? iSelfDefenceRange_, bool bChangeSelfDefenceRange, int key, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			new Doctrine.WRA_WeaponTarget();
			bool flag = false;
			checked
			{
				if (!Information.IsNothing(doctrine_1.GetWRA_WeaponDictionary()) && doctrine_1.GetWRA_WeaponDictionary().ContainsKey(key))
				{
					Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
					doctrine_1.GetWRA_WeaponDictionary().TryGetValue(key, out wRA_Weapon);
					if (!Information.IsNothing(wRA_Weapon))
					{
						Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
						for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
						{
							Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
							if (wRA_WeaponTarget.WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
							{
								if (bChangeWeaponsPerSalvo)
								{
									wRA_WeaponTarget.WeaponQty = WeaponsPerSalvo_;
								}
								else if (bChangeShootersPerSalvo)
								{
									wRA_WeaponTarget.ShooterQty = iShootersPerSalvo;
								}
								else if (bChangeSelfDefenceRange)
								{
									wRA_WeaponTarget.SelfDefenceRange = iSelfDefenceRange_;
								}
								else if (bChangeFiringRange)
								{
									wRA_WeaponTarget.FiringRange = iFiringRange_;
								}
								flag = true;
							}
						}
					}
				}
				if (!flag)
				{
					if (Information.IsNothing(doctrine_1.GetWRA_WeaponDictionary()))
					{
						doctrine_1.SetWRA_WeaponDictionary(new Dictionary<int, Doctrine.WRA_Weapon>());
					}
					if (!doctrine_1.GetWRA_WeaponDictionary().ContainsKey(key))
					{
						doctrine_1.GetWRA_WeaponDictionary().Add(key, null);
					}
					Doctrine.WRA_Weapon wRA_Weapon2 = new Doctrine.WRA_Weapon();
					doctrine_1.GetWRA_WeaponDictionary().TryGetValue(key, out wRA_Weapon2);
					if (Information.IsNothing(wRA_Weapon2))
					{
						wRA_Weapon2 = new Doctrine.WRA_Weapon();
						if (doctrine_1.GetWRA_WeaponDictionary().ContainsKey(key))
						{
							doctrine_1.GetWRA_WeaponDictionary()[key] = wRA_Weapon2;
						}
					}
					Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray2 = wRA_Weapon2.WRA_WeaponTargetArray;
					int j = 0;
					bool flag2 = false;
					while (j < wRA_WeaponTargetArray2.Length)
					{
						if (wRA_WeaponTargetArray2[j].WRA_WeaponTargetType == _WRA_WeaponTargetType_0)
						{
							goto IL_1E8;
						}
						j++;
					}
					Doctrine.WRA_WeaponTarget wRA_WeaponTarget2 = new Doctrine.WRA_WeaponTarget(_WRA_WeaponTargetType_0);
					if (!flag2)
					{
						if (bChangeWeaponsPerSalvo)
						{
							wRA_WeaponTarget2.WeaponQty = WeaponsPerSalvo_;
						}
						else if (bChangeShootersPerSalvo)
						{
							wRA_WeaponTarget2.ShooterQty = iShootersPerSalvo;
						}
						else if (bChangeSelfDefenceRange)
						{
							wRA_WeaponTarget2.SelfDefenceRange = iSelfDefenceRange_;
						}
						else if (bChangeFiringRange)
						{
							wRA_WeaponTarget2.FiringRange = iFiringRange_;
						}
						ScenarioArrayUtil.AddWRA_WeaponTarget(ref wRA_Weapon2.WRA_WeaponTargetArray, wRA_WeaponTarget2);
					}
				}
				IL_1E8:
				if (!Information.IsNothing(doctrine_1.GetWRA_WeaponDictionary()) && Information.IsNothing(WeaponsPerSalvo_) && Information.IsNothing(iShootersPerSalvo) && Information.IsNothing(iSelfDefenceRange_) && Information.IsNothing(iFiringRange_))
				{
					Collection<Doctrine.WRA_WeaponTarget> collection = new Collection<Doctrine.WRA_WeaponTarget>();
					Doctrine.WRA_Weapon wRA_Weapon3 = new Doctrine.WRA_Weapon();
					if (doctrine_1.GetWRA_WeaponDictionary().Count > 0)
					{
						doctrine_1.GetWRA_WeaponDictionary().TryGetValue(key, out wRA_Weapon3);
						if (!Information.IsNothing(wRA_Weapon3.WRA_WeaponTargetArray))
						{
							Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray3 = wRA_Weapon3.WRA_WeaponTargetArray;
							for (int k = 0; k < wRA_WeaponTargetArray3.Length; k++)
							{
								Doctrine.WRA_WeaponTarget wRA_WeaponTarget3 = wRA_WeaponTargetArray3[k];
								if (wRA_WeaponTarget3.WRA_WeaponTargetType == _WRA_WeaponTargetType_0 && Information.IsNothing(wRA_WeaponTarget3.WeaponQty) && Information.IsNothing(wRA_WeaponTarget3.SelfDefenceRange) && Information.IsNothing(wRA_WeaponTarget3.FiringRange))
								{
									collection.Add(wRA_WeaponTarget3);
								}
							}
							if (collection.Count > 0)
							{
								foreach (Doctrine.WRA_WeaponTarget current in collection)
								{
									ScenarioArrayUtil.RemoveWRA_WeaponTarget(ref wRA_Weapon3.WRA_WeaponTargetArray, current);
								}
							}
							if (wRA_Weapon3.WRA_WeaponTargetArray.Count<Doctrine.WRA_WeaponTarget>() == 0)
							{
								wRA_Weapon3.WRA_WeaponTargetArray = null;
							}
						}
					}
					if (Information.IsNothing(wRA_Weapon3.WRA_WeaponTargetArray))
					{
						doctrine_1.GetWRA_WeaponDictionary().Remove(key);
					}
					if (Information.IsNothing(doctrine_1.GetWRA_WeaponDictionary()) || doctrine_1.GetWRA_WeaponDictionary().Count == 0)
					{
						doctrine_1.SetWRA_WeaponDictionary(null);
					}
				}
			}
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x002C1578 File Offset: 0x002BF778
		private void method_92(object sender, EventArgs6 e)
		{
			if (e.method_0().method_6() == 1)
			{
				int key = ((KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag).Key;
				if (!this.collection_1.Contains(key))
				{
					this.collection_1.Add(key);
				}
				Weapon weapon = ((KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag).Value.method_1(Client.GetClientScenario(), key);
				foreach (TreeGridViewRow current in e.method_0().Nodes)
				{
					DataTable dataSource = new DataTable();
					DataTable dataSource2 = new DataTable();
					DataTable dataSource3 = new DataTable();
					DataTable dataSource4 = new DataTable();
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = ((Doctrine.WRA_WeaponTarget)current.Tag).WRA_WeaponTargetType;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)current.Cells[this.GetWeaponsPerSalvo().Index];
					DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)current.Cells[this.GetShootersPerSalvo().Index];
					DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)current.Cells[this.GetSelfDefenceRange().Index];
					DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)current.Cells[this.GetFiringRange().Index];
					this.m_Doctrine.method_200(ref dataSource, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
					this.m_Doctrine.method_201(ref dataSource2, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell2.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
					this.m_Doctrine.method_202(ref dataSource3, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell3.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
					this.m_Doctrine.method_203(ref dataSource4, wRA_WeaponTargetType, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell4.Value), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1);
					DataGridViewComboBoxCell dataGridViewComboBoxCell5 = dataGridViewComboBoxCell;
					dataGridViewComboBoxCell5.DataSource = dataSource;
					dataGridViewComboBoxCell5.DisplayMember = "Description";
					dataGridViewComboBoxCell5.ValueMember = "ID";
					DataGridViewComboBoxCell dataGridViewComboBoxCell6 = dataGridViewComboBoxCell2;
					dataGridViewComboBoxCell6.DataSource = dataSource2;
					dataGridViewComboBoxCell6.DisplayMember = "Description";
					dataGridViewComboBoxCell6.ValueMember = "ID";
					DataGridViewComboBoxCell dataGridViewComboBoxCell7 = dataGridViewComboBoxCell3;
					dataGridViewComboBoxCell7.DataSource = dataSource3;
					dataGridViewComboBoxCell7.DisplayMember = "Description";
					dataGridViewComboBoxCell7.ValueMember = "ID";
					DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell4;
					dataGridViewComboBoxCell8.DataSource = dataSource4;
					dataGridViewComboBoxCell8.DisplayMember = "Description";
					dataGridViewComboBoxCell8.ValueMember = "ID";
				}
			}
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x002C1870 File Offset: 0x002BFA70
		private void method_93(object sender, EventArgs5 e)
		{
			if (e.method_0().method_6() == 1)
			{
				this.collection_1.Remove(((KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag).Key);
			}
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x002C18B4 File Offset: 0x002BFAB4
		private void method_94(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				if (!Information.IsNothing(this.m_Doctrine.GetWRA_WeaponDictionary()))
				{
					this.m_Doctrine.SetWRA_WeaponDictionary(null);
				}
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (!Information.IsNothing(current.m_Doctrine.GetWRA_WeaponDictionary()))
						{
							current.m_Doctrine.SetWRA_WeaponDictionary(null);
						}
					}
					goto IL_203;
				}
			}
			if (this.subject.GetType() == typeof(Side))
			{
				if (!Information.IsNothing(((Side)this.subject).m_Doctrine.GetWRA_WeaponDictionary()))
				{
					((Side)this.subject).m_Doctrine.SetWRA_WeaponDictionary(null);
				}
			}
			else if (this.subject.IsMission)
			{
				if (this.bool_5)
				{
					if (((Strike)this.subject).MissionClass == Mission._MissionClass.Strike && !Information.IsNothing(((Strike)this.subject).Doctrine_Escorts.GetWRA_WeaponDictionary()))
					{
						((Strike)this.subject).Doctrine_Escorts.SetWRA_WeaponDictionary(null);
					}
				}
				else if (!Information.IsNothing(((Mission)this.subject).m_Doctrine.GetWRA_WeaponDictionary()))
				{
					((Mission)this.subject).m_Doctrine.SetWRA_WeaponDictionary(null);
				}
			}
			else if (this.subject.IsGroup)
			{
				if (!Information.IsNothing(((Group)this.subject).m_Doctrine.GetWRA_WeaponDictionary()))
				{
					((Group)this.subject).m_Doctrine.SetWRA_WeaponDictionary(null);
				}
			}
			else if (this.subject.IsActiveUnit())
			{
				ActiveUnit activeUnit = (ActiveUnit)this.subject;
				if (activeUnit.IsWeapon)
				{
					return;
				}
				if (!Information.IsNothing(activeUnit.m_Doctrine.GetWRA_WeaponDictionary()))
				{
					activeUnit.m_Doctrine.SetWRA_WeaponDictionary(null);
				}
			}
			IL_203:
			this.method_5();
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x002C1ADC File Offset: 0x002BFCDC
		private void method_95(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						foreach (ActiveUnit current2 in current.m_Doctrine.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
						{
							if (current2.IsGroup)
							{
								if (!Information.IsNothing(current2.m_Doctrine.GetWRA_WeaponDictionary()))
								{
									current2.m_Doctrine.SetWRA_WeaponDictionary(null);
								}
							}
							else if (current2.IsActiveUnit() && !current2.IsWeapon && !Information.IsNothing(current2.m_Doctrine.GetWRA_WeaponDictionary()))
							{
								current2.m_Doctrine.SetWRA_WeaponDictionary(null);
							}
						}
					}
					return;
				}
			}
			checked
			{
				if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Side))
				{
					ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
					for (int i = 0; i < activeUnitArray.Length; i++)
					{
						ActiveUnit activeUnit = activeUnitArray[i];
						if (!activeUnit.IsWeapon && !Information.IsNothing(activeUnit.m_Doctrine.GetWRA_WeaponDictionary()))
						{
							activeUnit.m_Doctrine.SetWRA_WeaponDictionary(null);
						}
					}
				}
				else
				{
					foreach (ActiveUnit current3 in this.m_Doctrine.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
					{
						if (current3.IsGroup)
						{
							if (!Information.IsNothing(current3.m_Doctrine.GetWRA_WeaponDictionary()))
							{
								current3.m_Doctrine.SetWRA_WeaponDictionary(null);
							}
						}
						else if (current3.IsActiveUnit() && !current3.IsWeapon && !Information.IsNothing(current3.m_Doctrine.GetWRA_WeaponDictionary()))
						{
							current3.m_Doctrine.SetWRA_WeaponDictionary(null);
						}
					}
				}
			}
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x002C1D28 File Offset: 0x002BFF28
		private void method_96(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Side))
			{
				foreach (Mission current in Client.GetClientSide().GetMissionCollection())
				{
					if (!Information.IsNothing(current.m_Doctrine.GetWRA_WeaponDictionary()))
					{
						current.m_Doctrine.SetWRA_WeaponDictionary(null);
					}
				}
			}
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x002C1DC4 File Offset: 0x002BFFC4
		private void method_97(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				ActiveUnit activeUnit = null;
				Doctrine.smethod_5(ref activeUnit, ref this.m_Doctrine, Client.GetClientScenario());

                ActiveUnit currentX;

                foreach (ActiveUnit current in this.ActiveUnitCollection)
				{
					if (!current.IsWeapon)
					{
                        currentX = current;
                        Doctrine.smethod_5(ref currentX, ref current.m_Doctrine, Client.GetClientScenario());
					}
				}
				this.m_Doctrine = this.method_104();
			}
			else
			{
				if (!Information.IsNothing(this.subject) && this.subject.GetType() != typeof(Side))
				{
					if (this.subject.IsMission)
					{
						Doctrine doctrine = null;
						if (this.bool_5)
						{
							doctrine = ((Strike)this.subject).Doctrine_Escorts;
						}
						else
						{
							doctrine = ((Mission)this.subject).m_Doctrine;
						}
						ActiveUnit activeUnit = null;
						Doctrine.smethod_5(ref activeUnit, ref doctrine, Client.GetClientScenario());
					}
					else if (this.subject.IsGroup)
					{
						Doctrine doctrine2 = ((Group)this.subject).m_Doctrine;
						ActiveUnit activeUnit = null;
						Doctrine.smethod_5(ref activeUnit, ref doctrine2, Client.GetClientScenario());
					}
					else if (this.subject.IsActiveUnit())
					{
						ActiveUnit activeUnit2 = (ActiveUnit)this.subject;
						if (activeUnit2.IsWeapon)
						{
							return;
						}
						Doctrine.smethod_5(ref activeUnit2, ref activeUnit2.m_Doctrine, Client.GetClientScenario());
					}
				}
				this.m_Doctrine.Init();
			}
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(true);
			this.method_3();
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x002C1F7C File Offset: 0x002C017C
		private void method_98(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
                        ActiveUnit current2X;

                        foreach (ActiveUnit current2 in current.m_Doctrine.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
						{
							if (current2.IsGroup)
							{
                                current2X = current2;
                                Doctrine.smethod_5(ref current2X, ref current2.m_Doctrine, Client.GetClientScenario());
							}
							else if (current2.IsActiveUnit() && !current2.IsWeapon)
							{
                                current2X = current2;
                                Doctrine.smethod_5(ref current2X, ref current2.m_Doctrine, Client.GetClientScenario());
							}
						}
					}
					return;
				}
			}
			checked
			{
				if (this.subject.GetType() == typeof(Side))
				{
					ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
					for (int i = 0; i < activeUnitArray.Length; i++)
					{
						ActiveUnit activeUnit = activeUnitArray[i];
						if (activeUnit.IsGroup)
						{
							Doctrine.smethod_5(ref activeUnit, ref activeUnit.m_Doctrine, Client.GetClientScenario());
						}
						else if (activeUnit.IsActiveUnit() && !activeUnit.IsWeapon)
						{
							Doctrine.smethod_5(ref activeUnit, ref activeUnit.m_Doctrine, Client.GetClientScenario());
						}
					}
				}
				else
				{
                    ActiveUnit current3X;

                    foreach (ActiveUnit current3 in this.m_Doctrine.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
					{
						if (current3.IsGroup)
						{
                            current3X = current3;
                            Doctrine.smethod_5(ref current3X, ref current3.m_Doctrine, Client.GetClientScenario());
						}
						else if (current3.IsActiveUnit() && !current3.IsWeapon)
						{
                            current3X = current3;
                            Doctrine.smethod_5(ref current3X, ref current3.m_Doctrine, Client.GetClientScenario());
						}
					}
				}
				CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(true);
				this.method_3();
			}
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x002C21C4 File Offset: 0x002C03C4
		private void method_99(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Side))
			{
				foreach (Mission current in Client.GetClientSide().GetMissionCollection())
				{
					ActiveUnit activeUnit = null;
					Doctrine.smethod_5(ref activeUnit, ref current.m_Doctrine, Client.GetClientScenario());
				}
			}
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(true);
			this.method_3();
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x002C2278 File Offset: 0x002C0478
		private void method_100(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				ActiveUnit activeUnit = null;
				Doctrine.smethod_5(ref activeUnit, ref this.m_Doctrine, Client.GetClientScenario());
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Unit current = enumerator.Current;
						if (current.IsGroup)
						{
							if (!((Group)current).m_Doctrine.EMCON_SettingsHasNoValue())
							{
								((Group)current).m_Doctrine.SetEMCON_Settings(true);
							}
						}
						else if (current.IsActiveUnit())
						{
							ActiveUnit activeUnit2 = (ActiveUnit)current;
							if (activeUnit2.IsWeapon)
							{
								return;
							}
							if (!activeUnit2.m_Doctrine.EMCON_SettingsHasNoValue())
							{
								activeUnit2.m_Doctrine.SetEMCON_Settings(true);
							}
						}
					}
					goto IL_1EC;
				}
			}
			if (this.subject.GetType() != typeof(Side))
			{
				if (this.subject.IsMission)
				{
					if (this.bool_5)
					{
						if (!((Strike)this.subject).Doctrine_Escorts.EMCON_SettingsHasNoValue())
						{
							((Strike)this.subject).Doctrine_Escorts.SetEMCON_Settings(true);
						}
					}
					else if (!((Mission)this.subject).m_Doctrine.EMCON_SettingsHasNoValue())
					{
						((Mission)this.subject).m_Doctrine.SetEMCON_Settings(true);
					}
				}
				else if (this.subject.IsGroup)
				{
					if (!((Group)this.subject).m_Doctrine.EMCON_SettingsHasNoValue())
					{
						((Group)this.subject).m_Doctrine.SetEMCON_Settings(true);
					}
				}
				else if (this.subject.IsActiveUnit())
				{
					ActiveUnit activeUnit3 = (ActiveUnit)this.subject;
					if (activeUnit3.IsWeapon)
					{
						return;
					}
					if (!activeUnit3.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						activeUnit3.m_Doctrine.SetEMCON_Settings(true);
					}
				}
			}
			IL_1EC:
			if (!this.bool_3 && !this.bool_4)
			{
				Doctrine doctrine = this.m_Doctrine;
				Scenario clientScenario = Client.GetClientScenario();
				doctrine.method_317(ref clientScenario, ref this.m_Doctrine, ref this.bool_5, true, false);
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
			this.method_4();
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x002C24EC File Offset: 0x002C06EC
		private void method_101(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						foreach (ActiveUnit current2 in current.m_Doctrine.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
						{
							if (current2.IsGroup)
							{
								if (!current2.m_Doctrine.EMCON_SettingsHasNoValue())
								{
									current2.m_Doctrine.SetEMCON_Settings(true);
								}
							}
							else if (current2.IsActiveUnit())
							{
								if (current2.IsWeapon)
								{
									continue;
								}
								if (!current2.m_Doctrine.EMCON_SettingsHasNoValue())
								{
									current2.m_Doctrine.SetEMCON_Settings(true);
								}
							}
							current2.GetSensory().ScheduleEMCONEvent(current2.GetAllNoneMCMSensors());
						}
					}
					if (!Information.IsNothing(this.ActiveUnitCollection))
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.ActiveUnitCollection.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								Unit current3 = enumerator3.Current;
								((ActiveUnit)current3).m_Doctrine.method_2(current3, new bool?(false), true, true, false, false);
							}
							CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
							CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
							this.method_4();
						}
					}
				}
			}
			checked
			{
				if (this.subject.GetType() == typeof(Side))
				{
					ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
					int i = 0;
					while (i < activeUnitArray.Length)
					{
						ActiveUnit activeUnit = activeUnitArray[i];
						if (activeUnit.IsGroup)
						{
							if (!activeUnit.m_Doctrine.EMCON_SettingsHasNoValue())
							{
								activeUnit.m_Doctrine.SetEMCON_Settings(true);
								goto IL_208;
							}
							goto IL_208;
						}
						else
						{
							if (!activeUnit.IsActiveUnit())
							{
								goto IL_208;
							}
							if (!activeUnit.IsWeapon)
							{
								if (!activeUnit.m_Doctrine.EMCON_SettingsHasNoValue())
								{
									activeUnit.m_Doctrine.SetEMCON_Settings(true);
									goto IL_208;
								}
								goto IL_208;
							}
						}
						IL_21B:
						i++;
						continue;
						IL_208:
						activeUnit.GetSensory().ScheduleEMCONEvent(activeUnit.GetAllNoneMCMSensors());
						goto IL_21B;
					}
				}
				else
				{
					foreach (ActiveUnit current4 in this.m_Doctrine.GetDoctrineActiveUnit(Client.GetClientScenario(), new bool?(this.bool_5)))
					{
						if (current4.IsGroup)
						{
							if (!current4.m_Doctrine.EMCON_SettingsHasNoValue())
							{
								current4.m_Doctrine.SetEMCON_Settings(true);
							}
						}
						else if (current4.IsActiveUnit())
						{
							if (current4.IsWeapon)
							{
								continue;
							}
							if (!current4.m_Doctrine.EMCON_SettingsHasNoValue())
							{
								current4.m_Doctrine.SetEMCON_Settings(true);
							}
						}
						current4.GetSensory().ScheduleEMCONEvent(current4.GetAllNoneMCMSensors());
					}
				}
				if (!Information.IsNothing(this.ActiveUnitCollection))
				{
					using (IEnumerator<ActiveUnit> enumerator3 = this.ActiveUnitCollection.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							Unit current3 = enumerator3.Current;
							((ActiveUnit)current3).m_Doctrine.method_2(current3, new bool?(false), true, true, false, false);
						}
						goto IL_360;
					}
				}
				this.m_Doctrine.method_2(this.subject, new bool?(false), false, true, false, false);
				IL_360:
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
				this.method_4();
			}
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x002C2904 File Offset: 0x002C0B04
		private void method_102(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Side))
			{
				foreach (Mission current in Client.GetClientSide().GetMissionCollection())
				{
					if (!current.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						current.m_Doctrine.SetEMCON_Settings(true);
					}
				}
			}
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				using (IEnumerator<ActiveUnit> enumerator2 = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Unit current2 = enumerator2.Current;
						((ActiveUnit)current2).m_Doctrine.method_2(current2, new bool?(false), true, true, false, false);
					}
					goto IL_E9;
				}
			}
			this.m_Doctrine.method_2(this.subject, new bool?(false), false, true, false, false);
			IL_E9:
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
			this.method_4();
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x0002A0D8 File Offset: 0x000282D8
		private void DoctrineForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Doctrine.smethod_1(new Doctrine.Delegate9(this.method_1));
			Doctrine.smethod_3(new Doctrine.Delegate10(this.method_2));
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x002C2A48 File Offset: 0x002C0C48
		private void DoctrineForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			checked
			{
				if (!Information.IsNothing(this.subject) && this.subject.GetType() == typeof(Waypoint))
				{
					bool flag = false;
					Waypoint value = (Waypoint)this.subject;
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						foreach (Mission current in side.GetMissionCollection())
						{
							foreach (Mission.Flight current2 in current.FlightList)
							{
								if (current2.GetFlightCourse().Contains(value) && current.MissionClass == Mission._MissionClass.Strike)
								{
									Scenario clientScenario = Client.GetClientScenario();
									Mission theStrikeMission_ = current;
									ActiveUnit referenceUnit = current2.GetReferenceUnit(Client.GetClientScenario());
									Mission.Flight theFlight_ = current2;
									Mission.Flight flight;
									Waypoint[] flightCourse = (flight = current2).GetFlightCourse();
									Mission.Enum60 bingo = ((Strike)current).Bingo;
									float num = 0f;
									StrikePlanner.smethod_8(clientScenario, theStrikeMission_, referenceUnit, theFlight_, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
									flight.SetFlightCourse(flightCourse);
									CommandFactory.GetCommandMain().GetMainForm().method_157();
									flag = true;
									break;
								}
							}
							if (flag)
							{
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
					if (Client.flightPlanEditor.Visible)
					{
						Client.flightPlanEditor.method_6();
					}
				}
			}
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x002C2C54 File Offset: 0x002C0E54
		private void method_103(object sender, MouseEventArgs e)
		{
			Scenario scenario = null;
			Side clientSide;
			if (!Information.IsNothing(this.ActiveUnitCollection))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.ActiveUnitCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Doctrine doctrine = enumerator.Current.m_Doctrine;
						clientSide = Client.GetClientSide();
						scenario = Client.GetClientScenario();
						doctrine.method_318(ref clientSide, ref scenario, ref this.bool_5);
						Client.SetClientSide(clientSide);
					}
					goto IL_8E;
				}
			}
			Doctrine doctrine2 = this.m_Doctrine;
			clientSide = Client.GetClientSide();
			scenario = Client.GetClientScenario();
			doctrine2.method_318(ref clientSide, ref scenario, ref this.bool_5);
			Client.SetClientSide(clientSide);
			IL_8E:
			this.bool_2 = false;
			this.m_Doctrine.method_2(this.subject, new bool?(false), !Information.IsNothing(this.ActiveUnitCollection) && this.ActiveUnitCollection.Count > 1, true, false, false);
			this.bool_2 = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x002C2D54 File Offset: 0x002C0F54
		private Doctrine method_104()
		{
			int num = 0;
			foreach (ActiveUnit current in this.ActiveUnitCollection)
			{
				current.m_Doctrine.Init();
				num++;
				if (num == 1)
				{
					Aircraft aircraft = new Aircraft(ref current.m_Scenario, null);
					aircraft.SetSide(false, current.GetSide(false));
					if (!Information.IsNothing(current.GetAssignedMission(false)))
					{
						aircraft.DeleteMission(true, current.GetAssignedMission(false));
					}
					aircraft.GetAircraftAI().IsEscort = current.GetAI().IsEscort;
					if (current.IsAircraft)
					{
						aircraft.GetAircraftAirOps().SetAirOpsCondition(((Aircraft)current).GetAircraftAirOps().GetAirOpsCondition());
					}
					else
					{
						aircraft.GetDockingOps().SetDockingOpsCondition(current.GetDockingOps().GetDockingOpsCondition());
					}
					this.m_Doctrine = new Doctrine(aircraft, ref this.ActiveUnitCollection);
					this.UseNuclearDoc = null;
					this.WCS_AirDoc = null;
					this.WCS_SurfaceDoc = null;
					this.WCS_SubmarineDoc = null;
					this.WCS_LandDoc = null;
					this.GunStrafeGroundTargetsDoc = null;
					this.IgnorePlottedCourseWhenAttackingDoc = null;
					this.WinchesterShotgunRTBDoc = null;
					this.WinchesterShotgunDoc = null;
					this.BingoJokerDoct = null;
					this.FuelStateRTBDoc = null;
					this.BehaviorTowardsAmbigousTargetDoc = null;
					this.AutomaticEvasionDoc = null;
					this.MaintainStandoffDoc = null;
					this.UseRefuelDoc = null;
					this.RefuelSelectionDoc = null;
					this.ShootTouristsDoc = null;
					this.UseSAMsInASuWModeDoc = null;
					this.IgnoreEMCONUnderAttackDoc = null;
					this.QuickTurnAroundDoc = null;
					this.AirOpsTempoDoc = null;
					this.UseTorpedoesKinematicRangeDoc = null;
					this.EMCON_SettingsForRadar = Doctrine.EMCON_Settings.Enum36.const_0;
					this.EMCON_SettingsForSonar = Doctrine.EMCON_Settings.Enum36.const_0;
					this.EMCON_SettingsForOECM = Doctrine.EMCON_Settings.Enum36.const_0;
					this.RefuelAlliedUnitsDoc = null;
					this.AvoidContactWhenPossibleDoc = null;
					this.DiveOnContactDoc = null;
					this.RechargeBatteryPercentageDoc = null;
					this.RechargeBatteryPercentageDoc = null;
					this._UseAIPDoc = null;
					this.UseDippingSonarDoc = null;
					this.JettisonOrdnanceDoc = null;
					this.WithdrawDamageThresholdDoc = null;
					this.WithdrawFuelThresholdDoc = null;
					this.WithdrawAttackThresholdDoc = null;
					this.WithdrawDefenceThresholdDoc = null;
					this.RedeployDamageThresholdDoc = null;
					this.RedeployFuelThresholdDoc = null;
					this.RedeployAttackWeaponQuantityThresholdDoc = null;
					this.RedeployDefenceWeaponQuantityThresholdDoc = null;
					if (!current.m_Doctrine.UseNukesHasNoValue())
					{
						this.m_Doctrine.method_35(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetUseNuclearDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine = current.m_Doctrine;
						Scenario clientScenario = Client.GetClientScenario();
						bool flag = true;
						this.UseNuclearDoc = doctrine.GetDoctrine(clientScenario, ref flag).GetUseNuclearDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.UseNuclearDoc = current.m_Doctrine.GetUseNuclearDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.WCS_AirHasNoValue())
					{
						this.m_Doctrine.method_63(Client.GetClientScenario(), false, new bool?(false), true, true, current.m_Doctrine.GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false));
						Doctrine doctrine2 = current.m_Doctrine;
						Scenario clientScenario2 = Client.GetClientScenario();
						bool flag = true;
						this.WCS_AirDoc = doctrine2.GetDoctrine(clientScenario2, ref flag).GetWCS_AirDoctrine(Client.GetClientScenario(), true, null, false, false);
					}
					else
					{
						this.WCS_AirDoc = current.m_Doctrine.GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					}
					if (!current.m_Doctrine.WCS_SurfaceHasNoValue())
					{
						this.m_Doctrine.SetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, current.m_Doctrine.GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false));
						Doctrine doctrine3 = current.m_Doctrine;
						Scenario clientScenario3 = Client.GetClientScenario();
						bool flag = true;
						this.WCS_SurfaceDoc = doctrine3.GetDoctrine(clientScenario3, ref flag).GetWCS_SurfaceDoctrine(Client.GetClientScenario(), true, null, false, false);
					}
					else
					{
						this.WCS_SurfaceDoc = current.m_Doctrine.GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					}
					if (!current.m_Doctrine.WCS_SubmarineHasNoValue())
					{
						this.m_Doctrine.SetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, current.m_Doctrine.GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false));
						Doctrine doctrine4 = current.m_Doctrine;
						Scenario clientScenario4 = Client.GetClientScenario();
						bool flag = true;
						this.WCS_SubmarineDoc = doctrine4.GetDoctrine(clientScenario4, ref flag).GetWCS_SubmarineDoctrine(Client.GetClientScenario(), true, null, false, false);
					}
					else
					{
						this.WCS_SubmarineDoc = current.m_Doctrine.GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					}
					if (!current.m_Doctrine.WCS_LandHasNoValue())
					{
						this.m_Doctrine.SetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, current.m_Doctrine.GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false));
						Doctrine doctrine5 = current.m_Doctrine;
						Scenario clientScenario5 = Client.GetClientScenario();
						bool flag = true;
						this.WCS_LandDoc = doctrine5.GetDoctrine(clientScenario5, ref flag).GetWCS_LandDoctrine(Client.GetClientScenario(), true, null, false, false);
					}
					else
					{
						this.WCS_LandDoc = current.m_Doctrine.GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					}
					if (!current.m_Doctrine.GunStrafeGroundTargetsHasNoValue())
					{
						this.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine6 = current.m_Doctrine;
						Scenario clientScenario6 = Client.GetClientScenario();
						bool flag = true;
						this.GunStrafeGroundTargetsDoc = doctrine6.GetDoctrine(clientScenario6, ref flag).GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.GunStrafeGroundTargetsDoc = current.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
					{
						this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, current.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false));
						Doctrine doctrine7 = current.m_Doctrine;
						Scenario clientScenario7 = Client.GetClientScenario();
						bool flag = true;
						this.IgnorePlottedCourseWhenAttackingDoc = doctrine7.GetDoctrine(clientScenario7, ref flag).GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), true, null, false, false);
					}
					else
					{
						this.IgnorePlottedCourseWhenAttackingDoc = current.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					}
					if (!current.m_Doctrine.WinchesterShotgunRTBHasNoValue())
					{
						this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine8 = current.m_Doctrine;
						Scenario clientScenario8 = Client.GetClientScenario();
						bool flag = true;
						this.WinchesterShotgunRTBDoc = doctrine8.GetDoctrine(clientScenario8, ref flag).GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.WinchesterShotgunRTBDoc = current.m_Doctrine.GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.WinchesterShotgunHasNoValue())
					{
						this.m_Doctrine.SetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, true, true, current.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false));
						Doctrine doctrine9 = current.m_Doctrine;
						Scenario clientScenario9 = Client.GetClientScenario();
						bool flag = true;
						this.WinchesterShotgunDoc = doctrine9.GetDoctrine(clientScenario9, ref flag).GetWinchesterShotgunDoctrine(Client.GetClientScenario(), true, false, false, false);
					}
					else
					{
						this.WinchesterShotgunDoc = current.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false);
					}
					if (!current.m_Doctrine.BingoJokerRTBHasNoValue())
					{
						this.m_Doctrine.SetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine10 = current.m_Doctrine;
						Scenario clientScenario10 = Client.GetClientScenario();
						bool flag = true;
						this.FuelStateRTBDoc = doctrine10.GetDoctrine(clientScenario10, ref flag).GetBingoJokerRTBDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.FuelStateRTBDoc = current.m_Doctrine.GetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.BingoJokerHasNoValue())
					{
						this.m_Doctrine.SetBingoJokerDoctrine(Client.GetClientScenario(), false, false, true, true, current.m_Doctrine.GetBingoJokerDoctrine(Client.GetClientScenario(), false, false, false, false));
						Doctrine doctrine11 = current.m_Doctrine;
						Scenario clientScenario11 = Client.GetClientScenario();
						bool flag = true;
						this.BingoJokerDoct = doctrine11.GetDoctrine(clientScenario11, ref flag).GetBingoJokerDoctrine(Client.GetClientScenario(), true, false, false, false);
					}
					else
					{
						this.BingoJokerDoct = current.m_Doctrine.GetBingoJokerDoctrine(Client.GetClientScenario(), false, false, false, false);
					}
					if (!current.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
					{
						this.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine12 = current.m_Doctrine;
						Scenario clientScenario12 = Client.GetClientScenario();
						bool flag = true;
						this.BehaviorTowardsAmbigousTargetDoc = doctrine12.GetDoctrine(clientScenario12, ref flag).GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.BehaviorTowardsAmbigousTargetDoc = current.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.AutomaticEvasionHasNoValue())
					{
						this.m_Doctrine.SetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine13 = current.m_Doctrine;
						Scenario clientScenario13 = Client.GetClientScenario();
						bool flag = true;
						this.AutomaticEvasionDoc = doctrine13.GetDoctrine(clientScenario13, ref flag).GetAutomaticEvasionDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.AutomaticEvasionDoc = current.m_Doctrine.GetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.MaintainStandoffHasNoValue())
					{
						this.m_Doctrine.SetMaintainStandoffDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetMaintainStandoffDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine14 = current.m_Doctrine;
						Scenario clientScenario14 = Client.GetClientScenario();
						bool flag = true;
						this.MaintainStandoffDoc = doctrine14.GetDoctrine(clientScenario14, ref flag).GetMaintainStandoffDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.MaintainStandoffDoc = current.m_Doctrine.GetMaintainStandoffDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.UseRefuelHasNoValue())
					{
						this.m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, true, true, false, current.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false));
						Doctrine doctrine15 = current.m_Doctrine;
						Scenario clientScenario15 = Client.GetClientScenario();
						bool flag = true;
						this.UseRefuelDoc = doctrine15.GetDoctrine(clientScenario15, ref flag).GetUseRefuelDoctrine(Client.GetClientScenario(), true, false, false, false);
					}
					else
					{
						this.UseRefuelDoc = current.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
					}
					if (!current.m_Doctrine.RefuelSelectionHasNoValue())
					{
						this.m_Doctrine.SetRefuelSelectionDoctrine(Client.GetClientScenario(), false, true, true, false, current.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false));
						Doctrine doctrine16 = current.m_Doctrine;
						Scenario clientScenario16 = Client.GetClientScenario();
						bool flag = true;
						this.RefuelSelectionDoc = doctrine16.GetDoctrine(clientScenario16, ref flag).GetRefuelSelectionDoctrine(Client.GetClientScenario(), true, false, false, false);
					}
					else
					{
						this.RefuelSelectionDoc = current.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false);
					}
					if (!current.m_Doctrine.ShootTouristsHasNoValue())
					{
						this.m_Doctrine.SetShootTouristsDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetShootTouristsDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine17 = current.m_Doctrine;
						Scenario clientScenario17 = Client.GetClientScenario();
						bool flag = true;
						this.ShootTouristsDoc = doctrine17.GetDoctrine(clientScenario17, ref flag).GetShootTouristsDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.ShootTouristsDoc = current.m_Doctrine.GetShootTouristsDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.SAM_ASUWHasNoValue())
					{
						this.m_Doctrine.SetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine18 = current.m_Doctrine;
						Scenario clientScenario18 = Client.GetClientScenario();
						bool flag = true;
						this.UseSAMsInASuWModeDoc = doctrine18.GetDoctrine(clientScenario18, ref flag).GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.UseSAMsInASuWModeDoc = current.m_Doctrine.GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue())
					{
						this.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine19 = current.m_Doctrine;
						Scenario clientScenario19 = Client.GetClientScenario();
						bool flag = true;
						this.IgnoreEMCONUnderAttackDoc = doctrine19.GetDoctrine(clientScenario19, ref flag).GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.IgnoreEMCONUnderAttackDoc = current.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.QuickTurnAroundHasNoValue())
					{
						this.m_Doctrine.SetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, current.m_Doctrine.GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false));
						this.QuickTurnAroundDoc = current.m_Doctrine.GetDoctrine(Client.GetClientScenario(), ref this.bool_0).GetQuickTurnAroundDoctrine(Client.GetClientScenario(), true, true, false, false);
					}
					else
					{
						this.QuickTurnAroundDoc = current.m_Doctrine.GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
					}
					if (!current.m_Doctrine.AirOpsTempoHasNoValue())
					{
						this.m_Doctrine.SetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, current.m_Doctrine.GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false));
						this.AirOpsTempoDoc = current.m_Doctrine.GetDoctrine(Client.GetClientScenario(), ref this.bool_0).GetAirOpsTempoDoctrine(Client.GetClientScenario(), true, true, false, false);
					}
					else
					{
						this.AirOpsTempoDoc = current.m_Doctrine.GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
					}
					if (!current.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue())
					{
						this.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine20 = current.m_Doctrine;
						Scenario clientScenario20 = Client.GetClientScenario();
						bool flag = true;
						this.UseTorpedoesKinematicRangeDoc = doctrine20.GetDoctrine(clientScenario20, ref flag).GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.UseTorpedoesKinematicRangeDoc = current.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.WithdrawDamageThresholdHasNoValue())
					{
						this.m_Doctrine.SetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine21 = current.m_Doctrine;
						Scenario clientScenario21 = Client.GetClientScenario();
						bool flag = true;
						this.WithdrawDamageThresholdDoc = doctrine21.GetDoctrine(clientScenario21, ref flag).GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.WithdrawDamageThresholdDoc = current.m_Doctrine.GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.WithdrawFuelThresholdHasNoValue())
					{
						this.m_Doctrine.SetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine22 = current.m_Doctrine;
						Scenario clientScenario22 = Client.GetClientScenario();
						bool flag = true;
						this.WithdrawFuelThresholdDoc = doctrine22.GetDoctrine(clientScenario22, ref flag).GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.WithdrawFuelThresholdDoc = current.m_Doctrine.GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.WithdrawAttackThresholdHasNoValue())
					{
						this.m_Doctrine.SetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine23 = current.m_Doctrine;
						Scenario clientScenario23 = Client.GetClientScenario();
						bool flag = true;
						this.WithdrawAttackThresholdDoc = doctrine23.GetDoctrine(clientScenario23, ref flag).GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.WithdrawAttackThresholdDoc = current.m_Doctrine.GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.WithdrawDefenceThresholdHasNoValue())
					{
						this.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine24 = current.m_Doctrine;
						Scenario clientScenario24 = Client.GetClientScenario();
						bool flag = true;
						this.WithdrawDefenceThresholdDoc = doctrine24.GetDoctrine(clientScenario24, ref flag).GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.WithdrawDefenceThresholdDoc = current.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.RedeployDamageThresholdHasNoValue())
					{
						this.m_Doctrine.SetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine25 = current.m_Doctrine;
						Scenario clientScenario25 = Client.GetClientScenario();
						bool flag = true;
						this.RedeployDamageThresholdDoc = doctrine25.GetDoctrine(clientScenario25, ref flag).GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.RedeployDamageThresholdDoc = current.m_Doctrine.GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.RedeployFuelThresholdHasNoValue())
					{
						this.m_Doctrine.SetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine26 = current.m_Doctrine;
						Scenario clientScenario26 = Client.GetClientScenario();
						bool flag = true;
						this.RedeployFuelThresholdDoc = doctrine26.GetDoctrine(clientScenario26, ref flag).GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.RedeployFuelThresholdDoc = current.m_Doctrine.GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
					{
						this.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine27 = current.m_Doctrine;
						Scenario clientScenario27 = Client.GetClientScenario();
						bool flag = true;
						this.RedeployAttackWeaponQuantityThresholdDoc = doctrine27.GetDoctrine(clientScenario27, ref flag).GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.RedeployAttackWeaponQuantityThresholdDoc = current.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.RedeployDefenceThresholdHasNoValue())
					{
						this.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine28 = current.m_Doctrine;
						Scenario clientScenario28 = Client.GetClientScenario();
						bool flag = true;
						this.RedeployDefenceWeaponQuantityThresholdDoc = doctrine28.GetDoctrine(clientScenario28, ref flag).GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.RedeployDefenceWeaponQuantityThresholdDoc = current.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						this.m_Doctrine.SetEMCON_Settings(false);
						this.m_Doctrine.SetEMCON_SettingsForSonar(current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar(), Client.GetClientScenario());
						this.m_Doctrine.SetEMCON_SettingsForRadar(current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar(), Client.GetClientScenario());
						this.m_Doctrine.method_173(current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM(), Client.GetClientScenario());
					}
					else
					{
						this.m_Doctrine.SetEMCON_Settings(true);
						this.EMCON_SettingsForRadar = current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar();
						this.EMCON_SettingsForSonar = current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar();
						this.EMCON_SettingsForOECM = current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM();
					}
					if (!current.m_Doctrine.RefuelAlliesHasNoValue())
					{
						this.m_Doctrine.SetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine29 = current.m_Doctrine;
						Scenario clientScenario29 = Client.GetClientScenario();
						bool flag = true;
						this.RefuelAlliedUnitsDoc = doctrine29.GetDoctrine(clientScenario29, ref flag).GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.RefuelAlliedUnitsDoc = current.m_Doctrine.GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.AvoidContactHasNoValue())
					{
						this.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine29 = current.m_Doctrine;
						Scenario clientScenario29 = Client.GetClientScenario();
						bool flag = true;
						this.AvoidContactWhenPossibleDoc = doctrine29.GetDoctrine(clientScenario29, ref flag).GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.AvoidContactWhenPossibleDoc = current.m_Doctrine.GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.DiveWhenThreatsDetectedHasNoValue())
					{
						this.m_Doctrine.SetDiveOnContactDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetDiveOnContactDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine29 = current.m_Doctrine;
						Scenario clientScenario29 = Client.GetClientScenario();
						bool flag = true;
						this.DiveOnContactDoc = doctrine29.GetDoctrine(clientScenario29, ref flag).GetDiveOnContactDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.DiveOnContactDoc = current.m_Doctrine.GetDiveOnContactDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.RechargePercentagePatrolHasNoValue())
					{
						this.m_Doctrine.SetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine29 = current.m_Doctrine;
						Scenario clientScenario29 = Client.GetClientScenario();
						bool flag = true;
						this.RechargeBatteryPercentageDoc = doctrine29.GetDoctrine(clientScenario29, ref flag).GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.RechargeBatteryPercentageDoc = current.m_Doctrine.GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.RechargePercentageAttackHasNoValue())
					{
						this.m_Doctrine.method_245(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine30 = current.m_Doctrine;
						Scenario clientScenario30 = Client.GetClientScenario();
						bool flag = true;
						this.nullable_27 = doctrine30.GetDoctrine(clientScenario30, ref flag).GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.nullable_27 = current.m_Doctrine.GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.AIPUsageHasNoValue())
					{
						this.m_Doctrine.SetUseAIPDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetUseAIPDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine31 = current.m_Doctrine;
						Scenario clientScenario31 = Client.GetClientScenario();
						bool flag = true;
						this._UseAIPDoc = doctrine31.GetDoctrine(clientScenario31, ref flag).GetUseAIPDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this._UseAIPDoc = current.m_Doctrine.GetUseAIPDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.DippingSonarHasNoValue())
					{
						this.m_Doctrine.SetUseDippingSonarDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetUseDippingSonarDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine32 = current.m_Doctrine;
						Scenario clientScenario32 = Client.GetClientScenario();
						bool flag = true;
						this.UseDippingSonarDoc = doctrine32.GetDoctrine(clientScenario32, ref flag).GetUseDippingSonarDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.UseDippingSonarDoc = current.m_Doctrine.GetUseDippingSonarDoctrine(Client.GetClientScenario(), false, false, false);
					}
					if (!current.m_Doctrine.JettisonOrdnanceHasNoValue())
					{
						this.m_Doctrine.SetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, true, true, current.m_Doctrine.GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, false, false));
						Doctrine doctrine33 = current.m_Doctrine;
						Scenario clientScenario33 = Client.GetClientScenario();
						bool flag = true;
						this.JettisonOrdnanceDoc = doctrine33.GetDoctrine(clientScenario33, ref flag).GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), true, false, false);
					}
					else
					{
						this.JettisonOrdnanceDoc = current.m_Doctrine.GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, false, false);
					}
				}
				else
				{
					Doctrine._UseNuclear? useNuclear = this.m_Doctrine.GetUseNuclearDoctrine(Client.GetClientScenario(), false, false, false);
					byte? b = useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null;
					bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null;
					byte? b2;
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.UseNukesHasNoValue() && !current.m_Doctrine.UseNukesHasNoValue())
						{
							useNuclear = this.m_Doctrine.GetUseNuclearDoctrine(Client.GetClientScenario(), false, false, false);
							b = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							useNuclear = current.m_Doctrine.GetUseNuclearDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.method_35(Client.GetClientScenario(), false, true, true, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_2));
							}
						}
						else if (this.m_Doctrine.UseNukesHasNoValue() && !current.m_Doctrine.UseNukesHasNoValue())
						{
							this.m_Doctrine.method_35(Client.GetClientScenario(), false, true, true, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_2));
						}
						else if (!this.m_Doctrine.UseNukesHasNoValue() && current.m_Doctrine.UseNukesHasNoValue())
						{
							this.m_Doctrine.method_35(Client.GetClientScenario(), false, true, true, new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_2));
						}
					}
					useNuclear = this.UseNuclearDoc;
					b2 = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.UseNukesHasNoValue())
						{
							useNuclear = this.UseNuclearDoc;
							b2 = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							Doctrine doctrine34 = current.m_Doctrine;
							Scenario clientScenario34 = Client.GetClientScenario();
							bool flag = true;
							useNuclear = doctrine34.GetDoctrine(clientScenario34, ref flag).GetUseNuclearDoctrine(Client.GetClientScenario(), true, false, false);
							b = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseNuclearDoc = new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_2);
							}
						}
						else
						{
							useNuclear = this.UseNuclearDoc;
							b = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							useNuclear = current.m_Doctrine.GetUseNuclearDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useNuclear.HasValue ? new byte?((byte)useNuclear.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseNuclearDoc = new Doctrine._UseNuclear?(Doctrine._UseNuclear.const_2);
							}
						}
					}
					Doctrine._WeaponControlStatus? weaponControlStatus = this.m_Doctrine.GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WCS_AirHasNoValue() && !current.m_Doctrine.WCS_AirHasNoValue())
						{
							weaponControlStatus = this.m_Doctrine.GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.method_63(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
							}
						}
						else if (this.m_Doctrine.WCS_AirHasNoValue() && !current.m_Doctrine.WCS_AirHasNoValue())
						{
							this.m_Doctrine.method_63(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
						else if (!this.m_Doctrine.WCS_AirHasNoValue() && current.m_Doctrine.WCS_AirHasNoValue())
						{
							this.m_Doctrine.method_63(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
					}
					weaponControlStatus = this.WCS_AirDoc;
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WCS_AirHasNoValue())
						{
							weaponControlStatus = this.WCS_AirDoc;
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							Doctrine doctrine35 = current.m_Doctrine;
							Scenario clientScenario35 = Client.GetClientScenario();
							bool flag = true;
							weaponControlStatus = doctrine35.GetDoctrine(clientScenario35, ref flag).GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(true), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_AirDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
						else
						{
							weaponControlStatus = this.WCS_AirDoc;
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_AirDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_AirDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
					}
					weaponControlStatus = this.m_Doctrine.GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WCS_SurfaceHasNoValue() && !current.m_Doctrine.WCS_SurfaceHasNoValue())
						{
							weaponControlStatus = this.m_Doctrine.GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
							}
						}
						else if (this.m_Doctrine.WCS_SurfaceHasNoValue() && !current.m_Doctrine.WCS_SurfaceHasNoValue())
						{
							this.m_Doctrine.SetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
						else if (!this.m_Doctrine.WCS_SurfaceHasNoValue() && current.m_Doctrine.WCS_SurfaceHasNoValue())
						{
							this.m_Doctrine.SetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
					}
					weaponControlStatus = this.WCS_SurfaceDoc;
					b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WCS_SurfaceHasNoValue())
						{
							weaponControlStatus = this.WCS_SurfaceDoc;
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							Doctrine doctrine36 = current.m_Doctrine;
							Scenario clientScenario36 = Client.GetClientScenario();
							bool flag = true;
							weaponControlStatus = doctrine36.GetDoctrine(clientScenario36, ref flag).GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(true), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_SurfaceDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
						else
						{
							weaponControlStatus = this.WCS_SurfaceDoc;
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_SurfaceDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_SurfaceDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
					}
					weaponControlStatus = this.m_Doctrine.GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WCS_SubmarineHasNoValue() && !current.m_Doctrine.WCS_SubmarineHasNoValue())
						{
							weaponControlStatus = this.m_Doctrine.GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
							}
						}
						else if (this.m_Doctrine.WCS_SubmarineHasNoValue() && !current.m_Doctrine.WCS_SubmarineHasNoValue())
						{
							this.m_Doctrine.SetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
						else if (!this.m_Doctrine.WCS_SubmarineHasNoValue() && current.m_Doctrine.WCS_SubmarineHasNoValue())
						{
							this.m_Doctrine.SetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
					}
					weaponControlStatus = this.WCS_SubmarineDoc;
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WCS_SubmarineHasNoValue())
						{
							weaponControlStatus = this.WCS_SubmarineDoc;
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							Doctrine doctrine37 = current.m_Doctrine;
							Scenario clientScenario37 = Client.GetClientScenario();
							bool flag = true;
							weaponControlStatus = doctrine37.GetDoctrine(clientScenario37, ref flag).GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(true), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_SubmarineDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
						else
						{
							weaponControlStatus = this.WCS_SubmarineDoc;
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_SubmarineDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_SubmarineDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
					}
					weaponControlStatus = this.m_Doctrine.GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WCS_LandHasNoValue() && !current.m_Doctrine.WCS_LandHasNoValue())
						{
							weaponControlStatus = this.m_Doctrine.GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
							}
						}
						else if (this.m_Doctrine.WCS_LandHasNoValue() && !current.m_Doctrine.WCS_LandHasNoValue())
						{
							this.m_Doctrine.SetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
						else if (!this.m_Doctrine.WCS_LandHasNoValue() && current.m_Doctrine.WCS_LandHasNoValue())
						{
							this.m_Doctrine.SetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3));
						}
					}
					weaponControlStatus = this.WCS_LandDoc;
					b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WCS_LandHasNoValue())
						{
							weaponControlStatus = this.WCS_LandDoc;
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							Doctrine doctrine38 = current.m_Doctrine;
							Scenario clientScenario38 = Client.GetClientScenario();
							bool flag = true;
							weaponControlStatus = doctrine38.GetDoctrine(clientScenario38, ref flag).GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(true), false, false);
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_LandDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
						else
						{
							weaponControlStatus = this.WCS_LandDoc;
							b = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							weaponControlStatus = current.m_Doctrine.GetWCS_LandDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (weaponControlStatus.HasValue ? new byte?((byte)weaponControlStatus.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WCS_LandDoc = new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.const_3);
							}
						}
					}
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = this.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.GunStrafeGroundTargetsHasNoValue() && !current.m_Doctrine.GunStrafeGroundTargetsHasNoValue())
						{
							gunStrafeGroundTargets = this.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							gunStrafeGroundTargets = current.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false);
							b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various));
							}
						}
						else if (this.m_Doctrine.GunStrafeGroundTargetsHasNoValue() && !current.m_Doctrine.GunStrafeGroundTargetsHasNoValue())
						{
							this.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various));
						}
						else if (!this.m_Doctrine.GunStrafeGroundTargetsHasNoValue() && current.m_Doctrine.GunStrafeGroundTargetsHasNoValue())
						{
							this.m_Doctrine.SetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various));
						}
					}
					gunStrafeGroundTargets = this.GunStrafeGroundTargetsDoc;
					b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.GunStrafeGroundTargetsHasNoValue())
						{
							gunStrafeGroundTargets = this.GunStrafeGroundTargetsDoc;
							b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							Doctrine doctrine39 = current.m_Doctrine;
							Scenario clientScenario39 = Client.GetClientScenario();
							bool flag = true;
							gunStrafeGroundTargets = doctrine39.GetDoctrine(clientScenario39, ref flag).GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.GunStrafeGroundTargetsDoc = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various);
							}
						}
						else
						{
							gunStrafeGroundTargets = this.GunStrafeGroundTargetsDoc;
							b2 = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							gunStrafeGroundTargets = current.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(Client.GetClientScenario(), false, false, false);
							b = (gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.GunStrafeGroundTargetsDoc = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various);
							}
						}
					}
					Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttacking = this.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
					b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue() && !current.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
						{
							ignorePlottedCourseWhenAttacking = this.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							ignorePlottedCourseWhenAttacking = current.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_2));
							}
						}
						else if (this.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue() && !current.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
						{
							this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_2));
						}
						else if (!this.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue() && current.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
						{
							this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), true, true, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_2));
						}
					}
					ignorePlottedCourseWhenAttacking = this.IgnorePlottedCourseWhenAttackingDoc;
					b2 = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.IgnorePlottedCourseWhenAttackingHasNoValue())
						{
							ignorePlottedCourseWhenAttacking = this.IgnorePlottedCourseWhenAttackingDoc;
							b2 = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							Doctrine doctrine40 = current.m_Doctrine;
							Scenario clientScenario40 = Client.GetClientScenario();
							bool flag = true;
							ignorePlottedCourseWhenAttacking = doctrine40.GetDoctrine(clientScenario40, ref flag).GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(true), false, false);
							b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.IgnorePlottedCourseWhenAttackingDoc = new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_2);
							}
						}
						else
						{
							ignorePlottedCourseWhenAttacking = this.IgnorePlottedCourseWhenAttackingDoc;
							b = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							ignorePlottedCourseWhenAttacking = current.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(Client.GetClientScenario(), false, new bool?(false), false, false);
							b2 = (ignorePlottedCourseWhenAttacking.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttacking.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.IgnorePlottedCourseWhenAttackingDoc = new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_2);
							}
						}
					}
					Doctrine._WeaponStateRTB? weaponStateRTB = this.m_Doctrine.GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WinchesterShotgunRTBHasNoValue() && !current.m_Doctrine.WinchesterShotgunRTBHasNoValue())
						{
							weaponStateRTB = this.m_Doctrine.GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							weaponStateRTB = current.m_Doctrine.GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, false, false);
							b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various));
							}
						}
						else if (this.m_Doctrine.WinchesterShotgunRTBHasNoValue() && !current.m_Doctrine.WinchesterShotgunRTBHasNoValue())
						{
							this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various));
						}
						else if (!this.m_Doctrine.WinchesterShotgunRTBHasNoValue() && current.m_Doctrine.WinchesterShotgunRTBHasNoValue())
						{
							this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various));
						}
					}
					weaponStateRTB = this.WinchesterShotgunRTBDoc;
					b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WinchesterShotgunRTBHasNoValue())
						{
							weaponStateRTB = this.WinchesterShotgunRTBDoc;
							b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							Doctrine doctrine41 = current.m_Doctrine;
							Scenario clientScenario41 = Client.GetClientScenario();
							bool flag = true;
							weaponStateRTB = doctrine41.GetDoctrine(clientScenario41, ref flag).GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WinchesterShotgunRTBDoc = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various);
							}
						}
						else
						{
							weaponStateRTB = this.WinchesterShotgunRTBDoc;
							b2 = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							weaponStateRTB = current.m_Doctrine.GetWinchesterShotgunRTBDoctrine(Client.GetClientScenario(), false, false, false);
							b = (weaponStateRTB.HasValue ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WinchesterShotgunRTBDoc = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various);
							}
						}
					}
					Doctrine._WeaponState? weaponState = this.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false);
					int? num2 = weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null;
					flag2 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null);
					int? num3;
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WinchesterShotgunHasNoValue() && !current.m_Doctrine.WinchesterShotgunHasNoValue())
						{
							weaponState = this.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false);
							num2 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							weaponState = current.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false);
							num3 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (((num2.HasValue & num3.HasValue) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, true, true, new Doctrine._WeaponState?(Doctrine._WeaponState.Various));
							}
						}
						else if (this.m_Doctrine.WinchesterShotgunHasNoValue() && !current.m_Doctrine.WinchesterShotgunHasNoValue())
						{
							this.m_Doctrine.SetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, true, true, new Doctrine._WeaponState?(Doctrine._WeaponState.Various));
						}
						else if (!this.m_Doctrine.WinchesterShotgunHasNoValue() && current.m_Doctrine.WinchesterShotgunHasNoValue())
						{
							this.m_Doctrine.SetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, true, true, new Doctrine._WeaponState?(Doctrine._WeaponState.Various));
						}
					}
					weaponState = this.WinchesterShotgunDoc;
					num3 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
					flag2 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WinchesterShotgunHasNoValue())
						{
							weaponState = this.WinchesterShotgunDoc;
							num3 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							Doctrine doctrine42 = current.m_Doctrine;
							Scenario clientScenario42 = Client.GetClientScenario();
							bool flag = true;
							weaponState = doctrine42.GetDoctrine(clientScenario42, ref flag).GetWinchesterShotgunDoctrine(Client.GetClientScenario(), true, false, false, false);
							num2 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (((num3.HasValue & num2.HasValue) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WinchesterShotgunDoc = new Doctrine._WeaponState?(Doctrine._WeaponState.Various);
							}
						}
						else
						{
							weaponState = this.WinchesterShotgunDoc;
							num2 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							weaponState = current.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false);
							num3 = (weaponState.HasValue ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (((num2.HasValue & num3.HasValue) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WinchesterShotgunDoc = new Doctrine._WeaponState?(Doctrine._WeaponState.Various);
							}
						}
					}
					Doctrine._FuelStateRTB? fuelStateRTB = this.m_Doctrine.GetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, false, false);
					b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.BingoJokerRTBHasNoValue() && !current.m_Doctrine.BingoJokerRTBHasNoValue())
						{
							fuelStateRTB = this.m_Doctrine.GetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, false, false);
							b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							fuelStateRTB = current.m_Doctrine.GetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various));
							}
						}
						else if (this.m_Doctrine.BingoJokerRTBHasNoValue() && !current.m_Doctrine.BingoJokerRTBHasNoValue())
						{
							this.m_Doctrine.SetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various));
						}
						else if (!this.m_Doctrine.BingoJokerRTBHasNoValue() && current.m_Doctrine.BingoJokerRTBHasNoValue())
						{
							this.m_Doctrine.SetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various));
						}
					}
					fuelStateRTB = this.FuelStateRTBDoc;
					b2 = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.BingoJokerRTBHasNoValue())
						{
							fuelStateRTB = this.FuelStateRTBDoc;
							b2 = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							Doctrine doctrine43 = current.m_Doctrine;
							Scenario clientScenario43 = Client.GetClientScenario();
							bool flag = true;
							fuelStateRTB = doctrine43.GetDoctrine(clientScenario43, ref flag).GetBingoJokerRTBDoctrine(Client.GetClientScenario(), true, false, false);
							b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.FuelStateRTBDoc = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various);
							}
						}
						else
						{
							fuelStateRTB = this.FuelStateRTBDoc;
							b = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							fuelStateRTB = current.m_Doctrine.GetBingoJokerRTBDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (fuelStateRTB.HasValue ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.FuelStateRTBDoc = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various);
							}
						}
					}
					Doctrine._FuelState? fuelState = this.m_Doctrine.GetBingoJokerDoctrine(Client.GetClientScenario(), false, false, false, false);
					b2 = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 12) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.BingoJokerHasNoValue() && !current.m_Doctrine.BingoJokerHasNoValue())
						{
							fuelState = this.m_Doctrine.GetBingoJokerDoctrine(Client.GetClientScenario(), false, false, false, false);
							b2 = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							fuelState = current.m_Doctrine.GetBingoJokerDoctrine(Client.GetClientScenario(), false, false, false, false);
							b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetBingoJokerDoctrine(Client.GetClientScenario(), false, false, true, true, new Doctrine._FuelState?(Doctrine._FuelState.Various));
							}
						}
						else if (this.m_Doctrine.BingoJokerHasNoValue() && !current.m_Doctrine.BingoJokerHasNoValue())
						{
							this.m_Doctrine.SetBingoJokerDoctrine(Client.GetClientScenario(), false, false, true, true, new Doctrine._FuelState?(Doctrine._FuelState.Various));
						}
						else if (!this.m_Doctrine.BingoJokerHasNoValue() && current.m_Doctrine.BingoJokerHasNoValue())
						{
							this.m_Doctrine.SetBingoJokerDoctrine(Client.GetClientScenario(), false, false, true, true, new Doctrine._FuelState?(Doctrine._FuelState.Various));
						}
					}
					fuelState = this.BingoJokerDoct;
					b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 12) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.BingoJokerHasNoValue())
						{
							fuelState = this.BingoJokerDoct;
							b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							Doctrine doctrine44 = current.m_Doctrine;
							Scenario clientScenario44 = Client.GetClientScenario();
							bool flag = true;
							fuelState = doctrine44.GetDoctrine(clientScenario44, ref flag).GetBingoJokerDoctrine(Client.GetClientScenario(), true, false, false, false);
							b2 = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.BingoJokerDoct = new Doctrine._FuelState?(Doctrine._FuelState.Various);
							}
						}
						else
						{
							fuelState = this.BingoJokerDoct;
							b2 = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							fuelState = current.m_Doctrine.GetBingoJokerDoctrine(Client.GetClientScenario(), false, false, false, false);
							b = (fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.BingoJokerDoct = new Doctrine._FuelState?(Doctrine._FuelState.Various);
							}
						}
					}
					Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTarget = this.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, false, false);
					b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue() && !current.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
						{
							behaviorTowardsAmbigousTarget = this.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, false, false);
							b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							behaviorTowardsAmbigousTarget = current.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.const_3));
							}
						}
						else if (this.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue() && !current.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
						{
							this.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.const_3));
						}
						else if (!this.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue() && current.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
						{
							this.m_Doctrine.SetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.const_3));
						}
					}
					behaviorTowardsAmbigousTarget = this.BehaviorTowardsAmbigousTargetDoc;
					b2 = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.BehaviorTowardsAmbigousTargetHasNoValue())
						{
							behaviorTowardsAmbigousTarget = this.BehaviorTowardsAmbigousTargetDoc;
							b2 = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							Doctrine doctrine45 = current.m_Doctrine;
							Scenario clientScenario45 = Client.GetClientScenario();
							bool flag = true;
							behaviorTowardsAmbigousTarget = doctrine45.GetDoctrine(clientScenario45, ref flag).GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), true, false, false);
							b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.BehaviorTowardsAmbigousTargetDoc = new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.const_3);
							}
						}
						else
						{
							behaviorTowardsAmbigousTarget = this.BehaviorTowardsAmbigousTargetDoc;
							b = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							behaviorTowardsAmbigousTarget = current.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (behaviorTowardsAmbigousTarget.HasValue ? new byte?((byte)behaviorTowardsAmbigousTarget.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.BehaviorTowardsAmbigousTargetDoc = new Doctrine._BehaviorTowardsAmbigousTarget?(Doctrine._BehaviorTowardsAmbigousTarget.const_3);
							}
						}
					}
					Doctrine._AutomaticEvasion? automaticEvasion = this.m_Doctrine.GetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.AutomaticEvasionHasNoValue() && !current.m_Doctrine.AutomaticEvasionHasNoValue())
						{
							automaticEvasion = this.m_Doctrine.GetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							automaticEvasion = current.m_Doctrine.GetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, false, false);
							b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_2));
							}
						}
						else if (this.m_Doctrine.AutomaticEvasionHasNoValue() && !current.m_Doctrine.AutomaticEvasionHasNoValue())
						{
							this.m_Doctrine.SetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_2));
						}
						else if (!this.m_Doctrine.AutomaticEvasionHasNoValue() && current.m_Doctrine.AutomaticEvasionHasNoValue())
						{
							this.m_Doctrine.SetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_2));
						}
					}
					automaticEvasion = this.AutomaticEvasionDoc;
					b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.AutomaticEvasionHasNoValue())
						{
							automaticEvasion = this.AutomaticEvasionDoc;
							b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							Doctrine doctrine46 = current.m_Doctrine;
							Scenario clientScenario46 = Client.GetClientScenario();
							bool flag = true;
							automaticEvasion = doctrine46.GetDoctrine(clientScenario46, ref flag).GetAutomaticEvasionDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.AutomaticEvasionDoc = new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_2);
							}
						}
						else
						{
							automaticEvasion = this.AutomaticEvasionDoc;
							b2 = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							automaticEvasion = current.m_Doctrine.GetAutomaticEvasionDoctrine(Client.GetClientScenario(), false, false, false);
							b = (automaticEvasion.HasValue ? new byte?((byte)automaticEvasion.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.AutomaticEvasionDoc = new Doctrine._AutomaticEvasion?(Doctrine._AutomaticEvasion.const_2);
							}
						}
					}
					Doctrine._MaintainStandoff? maintainStandoff = this.m_Doctrine.GetMaintainStandoffDoctrine(Client.GetClientScenario(), false, false, false);
					b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.MaintainStandoffHasNoValue() && !current.m_Doctrine.MaintainStandoffHasNoValue())
						{
							maintainStandoff = this.m_Doctrine.GetMaintainStandoffDoctrine(Client.GetClientScenario(), false, false, false);
							b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							maintainStandoff = current.m_Doctrine.GetMaintainStandoffDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetMaintainStandoffDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_2));
							}
						}
						else if (this.m_Doctrine.MaintainStandoffHasNoValue() && !current.m_Doctrine.MaintainStandoffHasNoValue())
						{
							this.m_Doctrine.SetMaintainStandoffDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_2));
						}
						else if (!this.m_Doctrine.MaintainStandoffHasNoValue() && current.m_Doctrine.MaintainStandoffHasNoValue())
						{
							this.m_Doctrine.SetMaintainStandoffDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_2));
						}
					}
					maintainStandoff = this.MaintainStandoffDoc;
					b2 = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.MaintainStandoffHasNoValue())
						{
							maintainStandoff = this.MaintainStandoffDoc;
							b2 = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							Doctrine doctrine47 = current.m_Doctrine;
							Scenario clientScenario29 = Client.GetClientScenario();
							bool flag = true;
							maintainStandoff = doctrine47.GetDoctrine(clientScenario29, ref flag).GetMaintainStandoffDoctrine(Client.GetClientScenario(), true, false, false);
							b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.MaintainStandoffDoc = new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_2);
							}
						}
						else
						{
							maintainStandoff = this.MaintainStandoffDoc;
							b = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							maintainStandoff = current.m_Doctrine.GetMaintainStandoffDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (maintainStandoff.HasValue ? new byte?((byte)maintainStandoff.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.MaintainStandoffDoc = new Doctrine._MaintainStandoff?(Doctrine._MaintainStandoff.const_2);
							}
						}
					}
					Doctrine._UseRefuel? useRefuel = this.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
					b2 = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.UseRefuelHasNoValue() && !current.m_Doctrine.UseRefuelHasNoValue())
						{
							useRefuel = this.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
							b2 = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							useRefuel = current.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
							b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, true, true, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_3));
							}
						}
						else if (this.m_Doctrine.UseRefuelHasNoValue() && !current.m_Doctrine.UseRefuelHasNoValue())
						{
							this.m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, true, true, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_3));
						}
						else if (!this.m_Doctrine.UseRefuelHasNoValue() && current.m_Doctrine.UseRefuelHasNoValue())
						{
							this.m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, true, true, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_3));
						}
					}
					useRefuel = this.UseRefuelDoc;
					b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.UseRefuelHasNoValue())
						{
							useRefuel = this.UseRefuelDoc;
							b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							Doctrine doctrine48 = current.m_Doctrine;
							Scenario clientScenario47 = Client.GetClientScenario();
							bool flag = true;
							useRefuel = doctrine48.GetDoctrine(clientScenario47, ref flag).GetUseRefuelDoctrine(Client.GetClientScenario(), true, false, false, false);
							b2 = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseRefuelDoc = new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_3);
							}
						}
						else
						{
							useRefuel = this.UseRefuelDoc;
							b2 = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							useRefuel = current.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
							b = (useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseRefuelDoc = new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_3);
							}
						}
					}
					Doctrine._RefuelSelection? refuelSelection = this.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false);
					b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RefuelSelectionHasNoValue() && !current.m_Doctrine.RefuelSelectionHasNoValue())
						{
							refuelSelection = this.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false);
							b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							refuelSelection = current.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false);
							b2 = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRefuelSelectionDoctrine(Client.GetClientScenario(), false, true, true, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_3));
							}
						}
						else if (this.m_Doctrine.RefuelSelectionHasNoValue() && !current.m_Doctrine.RefuelSelectionHasNoValue())
						{
							this.m_Doctrine.SetRefuelSelectionDoctrine(Client.GetClientScenario(), false, true, true, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_3));
						}
						else if (!this.m_Doctrine.RefuelSelectionHasNoValue() && current.m_Doctrine.RefuelSelectionHasNoValue())
						{
							this.m_Doctrine.SetRefuelSelectionDoctrine(Client.GetClientScenario(), false, true, true, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_3));
						}
					}
					refuelSelection = this.RefuelSelectionDoc;
					b2 = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RefuelSelectionHasNoValue())
						{
							refuelSelection = this.RefuelSelectionDoc;
							b2 = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							Doctrine doctrine49 = current.m_Doctrine;
							Scenario clientScenario48 = Client.GetClientScenario();
							bool flag = true;
							refuelSelection = doctrine49.GetDoctrine(clientScenario48, ref flag).GetRefuelSelectionDoctrine(Client.GetClientScenario(), true, false, false, false);
							b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RefuelSelectionDoc = new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_3);
							}
						}
						else
						{
							refuelSelection = this.RefuelSelectionDoc;
							b = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							refuelSelection = current.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false);
							b2 = (refuelSelection.HasValue ? new byte?((byte)refuelSelection.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RefuelSelectionDoc = new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_3);
							}
						}
					}
					Doctrine._ShootTourists? shootTourists = this.m_Doctrine.GetShootTouristsDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.ShootTouristsHasNoValue() && !current.m_Doctrine.ShootTouristsHasNoValue())
						{
							shootTourists = this.m_Doctrine.GetShootTouristsDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							shootTourists = current.m_Doctrine.GetShootTouristsDoctrine(Client.GetClientScenario(), false, false, false);
							b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetShootTouristsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_2));
							}
						}
						else if (this.m_Doctrine.ShootTouristsHasNoValue() && !current.m_Doctrine.ShootTouristsHasNoValue())
						{
							this.m_Doctrine.SetShootTouristsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_2));
						}
						else if (!this.m_Doctrine.ShootTouristsHasNoValue() && current.m_Doctrine.ShootTouristsHasNoValue())
						{
							this.m_Doctrine.SetShootTouristsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_2));
						}
					}
					shootTourists = this.ShootTouristsDoc;
					b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.ShootTouristsHasNoValue())
						{
							shootTourists = this.ShootTouristsDoc;
							b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							Doctrine doctrine50 = current.m_Doctrine;
							Scenario clientScenario49 = Client.GetClientScenario();
							bool flag = true;
							shootTourists = doctrine50.GetDoctrine(clientScenario49, ref flag).GetShootTouristsDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.ShootTouristsDoc = new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_2);
							}
						}
						else
						{
							shootTourists = this.ShootTouristsDoc;
							b2 = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							shootTourists = current.m_Doctrine.GetShootTouristsDoctrine(Client.GetClientScenario(), false, false, false);
							b = (shootTourists.HasValue ? new byte?((byte)shootTourists.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.ShootTouristsDoc = new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_2);
							}
						}
					}
					Doctrine._UseSAMsInASuWMode? useSAMsInASuWMode = this.m_Doctrine.GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, false, false);
					b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.SAM_ASUWHasNoValue() && !current.m_Doctrine.SAM_ASUWHasNoValue())
						{
							useSAMsInASuWMode = this.m_Doctrine.GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, false, false);
							b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							useSAMsInASuWMode = current.m_Doctrine.GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_2));
							}
						}
						else if (this.m_Doctrine.SAM_ASUWHasNoValue() && !current.m_Doctrine.SAM_ASUWHasNoValue())
						{
							this.m_Doctrine.SetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_2));
						}
						else if (!this.m_Doctrine.SAM_ASUWHasNoValue() && current.m_Doctrine.SAM_ASUWHasNoValue())
						{
							this.m_Doctrine.SetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_2));
						}
					}
					useSAMsInASuWMode = this.UseSAMsInASuWModeDoc;
					b2 = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.SAM_ASUWHasNoValue())
						{
							useSAMsInASuWMode = this.UseSAMsInASuWModeDoc;
							b2 = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							Doctrine doctrine51 = current.m_Doctrine;
							Scenario clientScenario50 = Client.GetClientScenario();
							bool flag = true;
							useSAMsInASuWMode = doctrine51.GetDoctrine(clientScenario50, ref flag).GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), true, false, false);
							b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseSAMsInASuWModeDoc = new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_2);
							}
						}
						else
						{
							useSAMsInASuWMode = this.UseSAMsInASuWModeDoc;
							b = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							useSAMsInASuWMode = current.m_Doctrine.GetUseSAMsInASuWModeDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useSAMsInASuWMode.HasValue ? new byte?((byte)useSAMsInASuWMode.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseSAMsInASuWModeDoc = new Doctrine._UseSAMsInASuWMode?(Doctrine._UseSAMsInASuWMode.const_2);
							}
						}
					}
					Doctrine._IgnoreEMCONUnderAttack? ignoreEMCONUnderAttack = this.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue() && !current.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue())
						{
							ignoreEMCONUnderAttack = this.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							ignoreEMCONUnderAttack = current.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, false, false);
							b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_2));
							}
						}
						else if (this.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue() && !current.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue())
						{
							this.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_2));
						}
						else if (!this.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue() && current.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue())
						{
							this.m_Doctrine.SetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_2));
						}
					}
					ignoreEMCONUnderAttack = this.IgnoreEMCONUnderAttackDoc;
					b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.IgnoreEMCONUnderAttackHasNoValue())
						{
							ignoreEMCONUnderAttack = this.IgnoreEMCONUnderAttackDoc;
							b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							Doctrine doctrine52 = current.m_Doctrine;
							Scenario clientScenario51 = Client.GetClientScenario();
							bool flag = true;
							ignoreEMCONUnderAttack = doctrine52.GetDoctrine(clientScenario51, ref flag).GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.IgnoreEMCONUnderAttackDoc = new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_2);
							}
						}
						else
						{
							ignoreEMCONUnderAttack = this.IgnoreEMCONUnderAttackDoc;
							b2 = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							ignoreEMCONUnderAttack = current.m_Doctrine.GetIgnoreEMCONUnderAttackDoctrine(Client.GetClientScenario(), false, false, false);
							b = (ignoreEMCONUnderAttack.HasValue ? new byte?((byte)ignoreEMCONUnderAttack.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.IgnoreEMCONUnderAttackDoc = new Doctrine._IgnoreEMCONUnderAttack?(Doctrine._IgnoreEMCONUnderAttack.const_2);
							}
						}
					}
					Doctrine._QuickTurnAround? quickTurnAround = this.m_Doctrine.GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
					b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.QuickTurnAroundHasNoValue() && !current.m_Doctrine.QuickTurnAroundHasNoValue())
						{
							quickTurnAround = this.m_Doctrine.GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							quickTurnAround = current.m_Doctrine.GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b2 = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_3));
							}
						}
						else if (this.m_Doctrine.QuickTurnAroundHasNoValue() && !current.m_Doctrine.QuickTurnAroundHasNoValue())
						{
							this.m_Doctrine.SetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_3));
						}
						else if (!this.m_Doctrine.QuickTurnAroundHasNoValue() && current.m_Doctrine.QuickTurnAroundHasNoValue())
						{
							this.m_Doctrine.SetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_3));
						}
					}
					quickTurnAround = this.QuickTurnAroundDoc;
					b2 = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.QuickTurnAroundHasNoValue())
						{
							quickTurnAround = this.QuickTurnAroundDoc;
							b2 = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							Doctrine doctrine53 = current.m_Doctrine;
							Scenario clientScenario52 = Client.GetClientScenario();
							bool flag = true;
							quickTurnAround = doctrine53.GetDoctrine(clientScenario52, ref flag).GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.QuickTurnAroundDoc = new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_3);
							}
						}
						else
						{
							quickTurnAround = this.QuickTurnAroundDoc;
							b = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							quickTurnAround = current.m_Doctrine.GetQuickTurnAroundDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b2 = (quickTurnAround.HasValue ? new byte?((byte)quickTurnAround.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.QuickTurnAroundDoc = new Doctrine._QuickTurnAround?(Doctrine._QuickTurnAround.const_3);
							}
						}
					}
					Doctrine._AirOpsTempo? airOpsTempo = this.m_Doctrine.GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
					b2 = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.AirOpsTempoHasNoValue() && !current.m_Doctrine.AirOpsTempoHasNoValue())
						{
							airOpsTempo = this.m_Doctrine.GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b2 = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							airOpsTempo = current.m_Doctrine.GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_2));
							}
						}
						else if (this.m_Doctrine.AirOpsTempoHasNoValue() && !current.m_Doctrine.AirOpsTempoHasNoValue())
						{
							this.m_Doctrine.SetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_2));
						}
						else if (!this.m_Doctrine.AirOpsTempoHasNoValue() && current.m_Doctrine.AirOpsTempoHasNoValue())
						{
							this.m_Doctrine.SetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, true, true, new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_2));
						}
					}
					airOpsTempo = this.AirOpsTempoDoc;
					b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.AirOpsTempoHasNoValue())
						{
							airOpsTempo = this.AirOpsTempoDoc;
							b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							Doctrine doctrine54 = current.m_Doctrine;
							Scenario clientScenario53 = Client.GetClientScenario();
							bool flag = true;
							airOpsTempo = doctrine54.GetDoctrine(clientScenario53, ref flag).GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b2 = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.AirOpsTempoDoc = new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_2);
							}
						}
						else
						{
							airOpsTempo = this.AirOpsTempoDoc;
							b2 = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							airOpsTempo = current.m_Doctrine.GetAirOpsTempoDoctrine(Client.GetClientScenario(), false, this.bool_0, false, false);
							b = (airOpsTempo.HasValue ? new byte?((byte)airOpsTempo.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.AirOpsTempoDoc = new Doctrine._AirOpsTempo?(Doctrine._AirOpsTempo.const_2);
							}
						}
					}
					Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRange = this.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, false, false);
					b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue() && !current.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue())
						{
							useTorpedoesKinematicRange = this.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, false, false);
							b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							useTorpedoesKinematicRange = current.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_3));
							}
						}
						else if (this.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue() && !current.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue())
						{
							this.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_3));
						}
						else if (!this.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue() && current.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue())
						{
							this.m_Doctrine.SetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_3));
						}
					}
					useTorpedoesKinematicRange = this.UseTorpedoesKinematicRangeDoc;
					b2 = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.UseTorpedoesKinematicRangeHasNoValue())
						{
							useTorpedoesKinematicRange = this.UseTorpedoesKinematicRangeDoc;
							b2 = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							Doctrine doctrine55 = current.m_Doctrine;
							Scenario clientScenario54 = Client.GetClientScenario();
							bool flag = true;
							useTorpedoesKinematicRange = doctrine55.GetDoctrine(clientScenario54, ref flag).GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), true, false, false);
							b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseTorpedoesKinematicRangeDoc = new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_3);
							}
						}
						else
						{
							useTorpedoesKinematicRange = this.UseTorpedoesKinematicRangeDoc;
							b = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							useTorpedoesKinematicRange = current.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useTorpedoesKinematicRange.HasValue ? new byte?((byte)useTorpedoesKinematicRange.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseTorpedoesKinematicRangeDoc = new Doctrine._UseTorpedoesKinematicRange?(Doctrine._UseTorpedoesKinematicRange.const_3);
							}
						}
					}
					Doctrine._DamageThreshold? damageThreshold = this.m_Doctrine.GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					short? num4 = damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null);
					short? num5;
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WithdrawDamageThresholdHasNoValue() && !current.m_Doctrine.WithdrawDamageThresholdHasNoValue())
						{
							damageThreshold = this.m_Doctrine.GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							damageThreshold = current.m_Doctrine.GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
							}
						}
						else if (this.m_Doctrine.WithdrawDamageThresholdHasNoValue() && !current.m_Doctrine.WithdrawDamageThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
						}
						else if (!this.m_Doctrine.WithdrawDamageThresholdHasNoValue() && current.m_Doctrine.WithdrawDamageThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
						}
					}
					damageThreshold = this.WithdrawDamageThresholdDoc;
					num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WithdrawDamageThresholdHasNoValue())
						{
							damageThreshold = this.WithdrawDamageThresholdDoc;
							num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine56 = current.m_Doctrine;
							Scenario clientScenario55 = Client.GetClientScenario();
							bool flag = true;
							damageThreshold = doctrine56.GetDoctrine(clientScenario55, ref flag).GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawDamageThresholdDoc = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
							}
						}
						else
						{
							damageThreshold = this.WithdrawDamageThresholdDoc;
							num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							damageThreshold = current.m_Doctrine.GetWithdrawDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawDamageThresholdDoc = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
							}
						}
					}
					Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.m_Doctrine.GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 6) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WithdrawFuelThresholdHasNoValue() && !current.m_Doctrine.WithdrawFuelThresholdHasNoValue())
						{
							fuelQuantityThreshold = this.m_Doctrine.GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							fuelQuantityThreshold = current.m_Doctrine.GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
							}
						}
						else if (this.m_Doctrine.WithdrawFuelThresholdHasNoValue() && !current.m_Doctrine.WithdrawFuelThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
						}
						else if (!this.m_Doctrine.WithdrawFuelThresholdHasNoValue() && current.m_Doctrine.WithdrawFuelThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
						}
					}
					fuelQuantityThreshold = this.WithdrawFuelThresholdDoc;
					num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WithdrawFuelThresholdHasNoValue())
						{
							fuelQuantityThreshold = this.WithdrawFuelThresholdDoc;
							num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine57 = current.m_Doctrine;
							Scenario clientScenario56 = Client.GetClientScenario();
							bool flag = true;
							fuelQuantityThreshold = doctrine57.GetDoctrine(clientScenario56, ref flag).GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawFuelThresholdDoc = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
							}
						}
						else
						{
							fuelQuantityThreshold = this.WithdrawFuelThresholdDoc;
							num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							fuelQuantityThreshold = current.m_Doctrine.GetWithdrawFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawFuelThresholdDoc = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
							}
						}
					}
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.m_Doctrine.GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 7) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WithdrawAttackThresholdHasNoValue() && !current.m_Doctrine.WithdrawAttackThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.m_Doctrine.GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						else if (this.m_Doctrine.WithdrawAttackThresholdHasNoValue() && !current.m_Doctrine.WithdrawAttackThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
						else if (!this.m_Doctrine.WithdrawAttackThresholdHasNoValue() && current.m_Doctrine.WithdrawAttackThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
					}
					weaponQuantityThreshold = this.WithdrawAttackThresholdDoc;
					num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WithdrawAttackThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.WithdrawAttackThresholdDoc;
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine58 = current.m_Doctrine;
							Scenario clientScenario57 = Client.GetClientScenario();
							bool flag = true;
							weaponQuantityThreshold = doctrine58.GetDoctrine(clientScenario57, ref flag).GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawAttackThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
						else
						{
							weaponQuantityThreshold = this.WithdrawAttackThresholdDoc;
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetWithdrawAttackThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawAttackThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
					}
					weaponQuantityThreshold = this.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 7) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.WithdrawDefenceThresholdHasNoValue() && !current.m_Doctrine.WithdrawDefenceThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						else if (this.m_Doctrine.WithdrawDefenceThresholdHasNoValue() && !current.m_Doctrine.WithdrawDefenceThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
						else if (!this.m_Doctrine.WithdrawDefenceThresholdHasNoValue() && current.m_Doctrine.WithdrawDefenceThresholdHasNoValue())
						{
							this.m_Doctrine.SetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
					}
					weaponQuantityThreshold = this.WithdrawDefenceThresholdDoc;
					num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.WithdrawDefenceThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.WithdrawDefenceThresholdDoc;
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine59 = current.m_Doctrine;
							Scenario clientScenario58 = Client.GetClientScenario();
							bool flag = true;
							weaponQuantityThreshold = doctrine59.GetDoctrine(clientScenario58, ref flag).GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawDefenceThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
						else
						{
							weaponQuantityThreshold = this.WithdrawDefenceThresholdDoc;
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetWithdrawDefenceThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.WithdrawDefenceThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
					}
					damageThreshold = this.m_Doctrine.GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RedeployDamageThresholdHasNoValue() && !current.m_Doctrine.RedeployDamageThresholdHasNoValue())
						{
							damageThreshold = this.m_Doctrine.GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							damageThreshold = current.m_Doctrine.GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
							}
						}
						else if (this.m_Doctrine.RedeployDamageThresholdHasNoValue() && !current.m_Doctrine.RedeployDamageThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
						}
						else if (!this.m_Doctrine.RedeployDamageThresholdHasNoValue() && current.m_Doctrine.RedeployDamageThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
						}
					}
					damageThreshold = this.RedeployDamageThresholdDoc;
					num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RedeployDamageThresholdHasNoValue())
						{
							damageThreshold = this.RedeployDamageThresholdDoc;
							num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine60 = current.m_Doctrine;
							Scenario clientScenario59 = Client.GetClientScenario();
							bool flag = true;
							damageThreshold = doctrine60.GetDoctrine(clientScenario59, ref flag).GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployDamageThresholdDoc = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
							}
						}
						else
						{
							damageThreshold = this.RedeployDamageThresholdDoc;
							num4 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							damageThreshold = current.m_Doctrine.GetRedeployDamageThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (damageThreshold.HasValue ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployDamageThresholdDoc = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
							}
						}
					}
					fuelQuantityThreshold = this.m_Doctrine.GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 6) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RedeployFuelThresholdHasNoValue() && !current.m_Doctrine.RedeployFuelThresholdHasNoValue())
						{
							fuelQuantityThreshold = this.m_Doctrine.GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							fuelQuantityThreshold = current.m_Doctrine.GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
							}
						}
						else if (this.m_Doctrine.RedeployFuelThresholdHasNoValue() && !current.m_Doctrine.RedeployFuelThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
						}
						else if (!this.m_Doctrine.RedeployFuelThresholdHasNoValue() && current.m_Doctrine.RedeployFuelThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
						}
					}
					fuelQuantityThreshold = this.RedeployFuelThresholdDoc;
					num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RedeployFuelThresholdHasNoValue())
						{
							fuelQuantityThreshold = this.RedeployFuelThresholdDoc;
							num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine61 = current.m_Doctrine;
							Scenario clientScenario60 = Client.GetClientScenario();
							bool flag = true;
							fuelQuantityThreshold = doctrine61.GetDoctrine(clientScenario60, ref flag).GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployFuelThresholdDoc = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
							}
						}
						else
						{
							fuelQuantityThreshold = this.RedeployFuelThresholdDoc;
							num5 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							fuelQuantityThreshold = current.m_Doctrine.GetRedeployFuelThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (fuelQuantityThreshold.HasValue ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployFuelThresholdDoc = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
							}
						}
					}
					weaponQuantityThreshold = this.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, false, false);
					num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 7) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue() && !current.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						else if (this.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue() && !current.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
						else if (!this.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue() && current.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
					}
					weaponQuantityThreshold = this.RedeployAttackWeaponQuantityThresholdDoc;
					num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RedeployAttackWeaponQuantityThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.RedeployAttackWeaponQuantityThresholdDoc;
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine62 = current.m_Doctrine;
							Scenario clientScenario61 = Client.GetClientScenario();
							bool flag = true;
							weaponQuantityThreshold = doctrine62.GetDoctrine(clientScenario61, ref flag).GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), true, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployAttackWeaponQuantityThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
						else
						{
							weaponQuantityThreshold = this.RedeployAttackWeaponQuantityThresholdDoc;
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetRedeployAttackWeaponQuantityThresholdDoctrine(Client.GetClientScenario(), false, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployAttackWeaponQuantityThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
					}
					weaponQuantityThreshold = this.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, false, false);
					num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 7) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RedeployDefenceThresholdHasNoValue() && !current.m_Doctrine.RedeployDefenceThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						else if (this.m_Doctrine.RedeployDefenceThresholdHasNoValue() && !current.m_Doctrine.RedeployDefenceThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
						else if (!this.m_Doctrine.RedeployDefenceThresholdHasNoValue() && current.m_Doctrine.RedeployDefenceThresholdHasNoValue())
						{
							this.m_Doctrine.SetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
						}
					}
					weaponQuantityThreshold = this.RedeployDefenceWeaponQuantityThresholdDoc;
					num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					flag2 = (num4.HasValue ? new bool?(num4.GetValueOrDefault() == 5) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RedeployDefenceThresholdHasNoValue())
						{
							weaponQuantityThreshold = this.RedeployDefenceWeaponQuantityThresholdDoc;
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							Doctrine doctrine63 = current.m_Doctrine;
							Scenario clientScenario62 = Client.GetClientScenario();
							bool flag = true;
							weaponQuantityThreshold = doctrine63.GetDoctrine(clientScenario62, ref flag).GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), true, false, false);
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num4.HasValue & num5.HasValue) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployDefenceWeaponQuantityThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
						else
						{
							weaponQuantityThreshold = this.RedeployDefenceWeaponQuantityThresholdDoc;
							num5 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							weaponQuantityThreshold = current.m_Doctrine.GetRedeployDefenceWeaponQuantityThreshold(Client.GetClientScenario(), false, false, false);
							num4 = (weaponQuantityThreshold.HasValue ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num5.HasValue & num4.HasValue) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RedeployDefenceWeaponQuantityThresholdDoc = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
							}
						}
					}
					Doctrine._RefuelAlliedUnits? refuelAlliedUnits = this.m_Doctrine.GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RefuelAlliesHasNoValue() && !current.m_Doctrine.RefuelAlliesHasNoValue())
						{
							refuelAlliedUnits = this.m_Doctrine.GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							refuelAlliedUnits = current.m_Doctrine.GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, false, false);
							b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various));
							}
						}
						else if (this.m_Doctrine.RefuelAlliesHasNoValue() && !current.m_Doctrine.RefuelAlliesHasNoValue())
						{
							this.m_Doctrine.SetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various));
						}
						else if (!this.m_Doctrine.RefuelAlliesHasNoValue() && current.m_Doctrine.RefuelAlliesHasNoValue())
						{
							this.m_Doctrine.SetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various));
						}
					}
					refuelAlliedUnits = this.RefuelAlliedUnitsDoc;
					b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RefuelAlliesHasNoValue())
						{
							refuelAlliedUnits = this.RefuelAlliedUnitsDoc;
							b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							Doctrine doctrine64 = current.m_Doctrine;
							Scenario clientScenario63 = Client.GetClientScenario();
							bool flag = true;
							refuelAlliedUnits = doctrine64.GetDoctrine(clientScenario63, ref flag).GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RefuelAlliedUnitsDoc = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various);
							}
						}
						else
						{
							refuelAlliedUnits = this.RefuelAlliedUnitsDoc;
							b2 = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							refuelAlliedUnits = current.m_Doctrine.GetRefuelAlliedUnitsDoctrine(Client.GetClientScenario(), false, false, false);
							b = (refuelAlliedUnits.HasValue ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RefuelAlliedUnitsDoc = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various);
							}
						}
					}
					Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible = this.m_Doctrine.GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, false, false);
					b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.AvoidContactHasNoValue() && !current.m_Doctrine.AvoidContactHasNoValue())
						{
							avoidContactWhenPossible = this.m_Doctrine.GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, false, false);
							b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							avoidContactWhenPossible = current.m_Doctrine.GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various));
							}
						}
						else if (this.m_Doctrine.AvoidContactHasNoValue() && !current.m_Doctrine.AvoidContactHasNoValue())
						{
							this.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various));
						}
						else if (!this.m_Doctrine.AvoidContactHasNoValue() && current.m_Doctrine.AvoidContactHasNoValue())
						{
							this.m_Doctrine.SetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various));
						}
					}
					avoidContactWhenPossible = this.AvoidContactWhenPossibleDoc;
					b2 = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.AvoidContactHasNoValue())
						{
							avoidContactWhenPossible = this.AvoidContactWhenPossibleDoc;
							b2 = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							Doctrine doctrine65 = current.m_Doctrine;
							Scenario clientScenario64 = Client.GetClientScenario();
							bool flag = true;
							avoidContactWhenPossible = doctrine65.GetDoctrine(clientScenario64, ref flag).GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), true, false, false);
							b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.AvoidContactWhenPossibleDoc = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various);
							}
						}
						else
						{
							avoidContactWhenPossible = this.AvoidContactWhenPossibleDoc;
							b = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							avoidContactWhenPossible = current.m_Doctrine.GetAvoidContactWhenPossibleDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (avoidContactWhenPossible.HasValue ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.AvoidContactWhenPossibleDoc = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various);
							}
						}
					}
					Doctrine._DiveOnContact? diveOnContact = this.m_Doctrine.GetDiveOnContactDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.DiveWhenThreatsDetectedHasNoValue() && !current.m_Doctrine.DiveWhenThreatsDetectedHasNoValue())
						{
							diveOnContact = this.m_Doctrine.GetDiveOnContactDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							diveOnContact = current.m_Doctrine.GetDiveOnContactDoctrine(Client.GetClientScenario(), false, false, false);
							b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetDiveOnContactDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various));
							}
						}
						else if (this.m_Doctrine.DiveWhenThreatsDetectedHasNoValue() && !current.m_Doctrine.DiveWhenThreatsDetectedHasNoValue())
						{
							this.m_Doctrine.SetDiveOnContactDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various));
						}
						else if (!this.m_Doctrine.DiveWhenThreatsDetectedHasNoValue() && current.m_Doctrine.DiveWhenThreatsDetectedHasNoValue())
						{
							this.m_Doctrine.SetDiveOnContactDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various));
						}
					}
					diveOnContact = this.DiveOnContactDoc;
					b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.DiveWhenThreatsDetectedHasNoValue())
						{
							diveOnContact = this.DiveOnContactDoc;
							b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							Doctrine doctrine66 = current.m_Doctrine;
							Scenario clientScenario65 = Client.GetClientScenario();
							bool flag = true;
							diveOnContact = doctrine66.GetDoctrine(clientScenario65, ref flag).GetDiveOnContactDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.DiveOnContactDoc = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various);
							}
						}
						else
						{
							diveOnContact = this.DiveOnContactDoc;
							b2 = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							diveOnContact = current.m_Doctrine.GetDiveOnContactDoctrine(Client.GetClientScenario(), false, false, false);
							b = (diveOnContact.HasValue ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.DiveOnContactDoc = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various);
							}
						}
					}
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = this.m_Doctrine.GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, false, false);
					num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					flag2 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == -100) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RechargePercentagePatrolHasNoValue() && !current.m_Doctrine.RechargePercentagePatrolHasNoValue())
						{
							rechargeBatteryPercentage = this.m_Doctrine.GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, false, false);
							num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							rechargeBatteryPercentage = current.m_Doctrine.GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, false, false);
							num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num3.HasValue & num2.HasValue) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
							}
						}
						else if (this.m_Doctrine.RechargePercentagePatrolHasNoValue() && !current.m_Doctrine.RechargePercentagePatrolHasNoValue())
						{
							this.m_Doctrine.SetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
						}
						else if (!this.m_Doctrine.RechargePercentagePatrolHasNoValue() && current.m_Doctrine.RechargePercentagePatrolHasNoValue())
						{
							this.m_Doctrine.SetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
						}
					}
					rechargeBatteryPercentage = this.RechargeBatteryPercentageDoc;
					num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					flag2 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RechargePercentagePatrolHasNoValue())
						{
							rechargeBatteryPercentage = this.RechargeBatteryPercentageDoc;
							num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							Doctrine doctrine67 = current.m_Doctrine;
							Scenario clientScenario66 = Client.GetClientScenario();
							bool flag = true;
							rechargeBatteryPercentage = doctrine67.GetDoctrine(clientScenario66, ref flag).GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), true, false, false);
							num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num2.HasValue & num3.HasValue) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RechargeBatteryPercentageDoc = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
							}
						}
						else
						{
							rechargeBatteryPercentage = this.RechargeBatteryPercentageDoc;
							num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							rechargeBatteryPercentage = current.m_Doctrine.GetRechargeBatteryPercentageDoctrine(Client.GetClientScenario(), false, false, false);
							num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num3.HasValue & num2.HasValue) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.RechargeBatteryPercentageDoc = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
							}
						}
					}
					rechargeBatteryPercentage = this.m_Doctrine.GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), false, false, false);
					num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					flag2 = (num2.HasValue ? new bool?(num2.GetValueOrDefault() == -100) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.RechargePercentageAttackHasNoValue() && !current.m_Doctrine.RechargePercentageAttackHasNoValue())
						{
							rechargeBatteryPercentage = this.m_Doctrine.GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), false, false, false);
							num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							rechargeBatteryPercentage = current.m_Doctrine.GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), false, false, false);
							num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num2.HasValue & num3.HasValue) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.method_245(Client.GetClientScenario(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
							}
						}
						else if (this.m_Doctrine.RechargePercentageAttackHasNoValue() && !current.m_Doctrine.RechargePercentageAttackHasNoValue())
						{
							this.m_Doctrine.method_245(Client.GetClientScenario(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
						}
						else if (!this.m_Doctrine.RechargePercentageAttackHasNoValue() && current.m_Doctrine.RechargePercentageAttackHasNoValue())
						{
							this.m_Doctrine.method_245(Client.GetClientScenario(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
						}
					}
					rechargeBatteryPercentage = this.nullable_27;
					num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					flag2 = (num3.HasValue ? new bool?(num3.GetValueOrDefault() == -100) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.RechargePercentageAttackHasNoValue())
						{
							rechargeBatteryPercentage = this.nullable_27;
							num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							Doctrine doctrine29 = current.m_Doctrine;
							Scenario clientScenario29 = Client.GetClientScenario();
							bool flag = true;
							rechargeBatteryPercentage = doctrine29.GetDoctrine(clientScenario29, ref flag).GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), true, false, false);
							num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num3.HasValue & num2.HasValue) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.nullable_27 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
							}
						}
						else
						{
							rechargeBatteryPercentage = this.nullable_27;
							num2 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							rechargeBatteryPercentage = current.m_Doctrine.GetRechargeBatteryPercentageDoc(Client.GetClientScenario(), false, false, false);
							num3 = (rechargeBatteryPercentage.HasValue ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num2.HasValue & num3.HasValue) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.nullable_27 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
							}
						}
					}
					Doctrine._UseAIP? useAIP = this.m_Doctrine.GetUseAIPDoctrine(Client.GetClientScenario(), false, false, false);
					b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.AIPUsageHasNoValue() && !current.m_Doctrine.AIPUsageHasNoValue())
						{
							useAIP = this.m_Doctrine.GetUseAIPDoctrine(Client.GetClientScenario(), false, false, false);
							b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							useAIP = current.m_Doctrine.GetUseAIPDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetUseAIPDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseAIP?(Doctrine._UseAIP.Various));
							}
						}
						else if (this.m_Doctrine.AIPUsageHasNoValue() && !current.m_Doctrine.AIPUsageHasNoValue())
						{
							this.m_Doctrine.SetUseAIPDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseAIP?(Doctrine._UseAIP.Various));
						}
						else if (!this.m_Doctrine.AIPUsageHasNoValue() && current.m_Doctrine.AIPUsageHasNoValue())
						{
							this.m_Doctrine.SetUseAIPDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseAIP?(Doctrine._UseAIP.Various));
						}
					}
					useAIP = this._UseAIPDoc;
					b2 = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 3) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.AIPUsageHasNoValue())
						{
							useAIP = this._UseAIPDoc;
							b2 = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							Doctrine doctrine68 = current.m_Doctrine;
							Scenario clientScenario67 = Client.GetClientScenario();
							bool flag = true;
							useAIP = doctrine68.GetDoctrine(clientScenario67, ref flag).GetUseAIPDoctrine(Client.GetClientScenario(), true, false, false);
							b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this._UseAIPDoc = new Doctrine._UseAIP?(Doctrine._UseAIP.Various);
							}
						}
						else
						{
							useAIP = this._UseAIPDoc;
							b = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							useAIP = current.m_Doctrine.GetUseAIPDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useAIP.HasValue ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this._UseAIPDoc = new Doctrine._UseAIP?(Doctrine._UseAIP.Various);
							}
						}
					}
					Doctrine._UseDippingSonar? useDippingSonar = this.m_Doctrine.GetUseDippingSonarDoctrine(Client.GetClientScenario(), false, false, false);
					b2 = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.DippingSonarHasNoValue() && !current.m_Doctrine.DippingSonarHasNoValue())
						{
							useDippingSonar = this.m_Doctrine.GetUseDippingSonarDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							useDippingSonar = current.m_Doctrine.GetUseDippingSonarDoctrine(Client.GetClientScenario(), false, false, false);
							b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetUseDippingSonarDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various));
							}
						}
						else if (this.m_Doctrine.DippingSonarHasNoValue() && !current.m_Doctrine.DippingSonarHasNoValue())
						{
							this.m_Doctrine.SetUseDippingSonarDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various));
						}
						else if (!this.m_Doctrine.DippingSonarHasNoValue() && current.m_Doctrine.DippingSonarHasNoValue())
						{
							this.m_Doctrine.SetUseDippingSonarDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various));
						}
					}
					useDippingSonar = this.UseDippingSonarDoc;
					b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.DippingSonarHasNoValue())
						{
							useDippingSonar = this.UseDippingSonarDoc;
							b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							Doctrine doctrine69 = current.m_Doctrine;
							Scenario clientScenario68 = Client.GetClientScenario();
							bool flag = true;
							useDippingSonar = doctrine69.GetDoctrine(clientScenario68, ref flag).GetUseDippingSonarDoctrine(Client.GetClientScenario(), true, false, false);
							b2 = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseDippingSonarDoc = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various);
							}
						}
						else
						{
							useDippingSonar = this.UseDippingSonarDoc;
							b2 = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							useDippingSonar = current.m_Doctrine.GetUseDippingSonarDoctrine(Client.GetClientScenario(), false, false, false);
							b = (useDippingSonar.HasValue ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.UseDippingSonarDoc = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various);
							}
						}
					}
					Doctrine._JettisonOrdnance? jettisonOrdnance = this.m_Doctrine.GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, false, false);
					b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
					flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!this.m_Doctrine.JettisonOrdnanceHasNoValue() && !current.m_Doctrine.JettisonOrdnanceHasNoValue())
						{
							jettisonOrdnance = this.m_Doctrine.GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, false, false);
							b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							jettisonOrdnance = current.m_Doctrine.GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.m_Doctrine.SetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various));
							}
						}
						else if (this.m_Doctrine.JettisonOrdnanceHasNoValue() && !current.m_Doctrine.JettisonOrdnanceHasNoValue())
						{
							this.m_Doctrine.SetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various));
						}
						else if (!this.m_Doctrine.JettisonOrdnanceHasNoValue() && current.m_Doctrine.JettisonOrdnanceHasNoValue())
						{
							this.m_Doctrine.SetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, true, true, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various));
						}
					}
					jettisonOrdnance = this.JettisonOrdnanceDoc;
					b2 = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
					flag2 = (b2.HasValue ? new bool?(b2.GetValueOrDefault() == 4) : null);
					if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
					{
						if (!current.m_Doctrine.DiveWhenThreatsDetectedHasNoValue())
						{
							jettisonOrdnance = this.JettisonOrdnanceDoc;
							b2 = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							Doctrine doctrine70 = current.m_Doctrine;
							Scenario clientScenario69 = Client.GetClientScenario();
							bool flag = true;
							jettisonOrdnance = doctrine70.GetDoctrine(clientScenario69, ref flag).GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), true, false, false);
							b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							if (((b2.HasValue & b.HasValue) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.JettisonOrdnanceDoc = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various);
							}
						}
						else
						{
							jettisonOrdnance = this.JettisonOrdnanceDoc;
							b = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							jettisonOrdnance = current.m_Doctrine.GetJettisonOrdnanceDoctrine(Client.GetClientScenario(), false, false, false);
							b2 = (jettisonOrdnance.HasValue ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
							if (((b.HasValue & b2.HasValue) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.JettisonOrdnanceDoc = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various);
							}
						}
					}
					if (this.m_Doctrine.EMCON_SettingsHasNoValue() != current.m_Doctrine.EMCON_SettingsHasNoValue() && !this.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						this.m_Doctrine.SetEMCON_Settings(true);
					}
					if (Information.IsNothing(this.EMCON_SettingsForRadar))
					{
						if (this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() != Doctrine.EMCON_Settings.Enum36.const_2 && this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar())
						{
							this.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_2, Client.GetClientScenario());
						}
					}
					else if (!current.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						if (this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar())
						{
							this.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_2, Client.GetClientScenario());
						}
					}
					else if (this.EMCON_SettingsForRadar != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar())
					{
						this.EMCON_SettingsForRadar = Doctrine.EMCON_Settings.Enum36.const_2;
					}
					if (Information.IsNothing(this.EMCON_SettingsForSonar))
					{
						if (this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() != Doctrine.EMCON_Settings.Enum36.const_2 && this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar())
						{
							this.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_2, Client.GetClientScenario());
						}
					}
					else if (!current.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						if (this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar())
						{
							this.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_2, Client.GetClientScenario());
						}
					}
					else if (this.EMCON_SettingsForSonar != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar())
					{
						this.EMCON_SettingsForSonar = Doctrine.EMCON_Settings.Enum36.const_2;
					}
					if (Information.IsNothing(this.EMCON_SettingsForOECM))
					{
						if (this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() != Doctrine.EMCON_Settings.Enum36.const_2 && this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM())
						{
							this.m_Doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_2, Client.GetClientScenario());
						}
					}
					else if (!current.m_Doctrine.EMCON_SettingsHasNoValue())
					{
						if (this.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM())
						{
							this.m_Doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_2, Client.GetClientScenario());
						}
					}
					else if (this.EMCON_SettingsForOECM != current.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM())
					{
						this.EMCON_SettingsForOECM = Doctrine.EMCON_Settings.Enum36.const_2;
					}
				}
			}
			return this.m_Doctrine;
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x002CE0D0 File Offset: 0x002CC2D0
		private void method_105()
		{
			int num = 0;
			foreach (ActiveUnit current in this.ActiveUnitCollection)
			{
				num++;
				checked
				{
					if (num == 1)
					{
						if (Information.IsNothing(current.m_Doctrine.GetWRA_WeaponDictionary()))
						{
							continue;
						}
						using (Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator2 = current.m_Doctrine.GetWRA_WeaponDictionary().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								KeyValuePair<int, Doctrine.WRA_Weapon> current2 = enumerator2.Current;
								int key = current2.Key;
								Doctrine.WRA_Weapon wRA_Weapon = new Doctrine.WRA_Weapon();
								current.m_Doctrine.GetWRA_WeaponDictionary().TryGetValue(key, out wRA_Weapon);
								Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray = wRA_Weapon.WRA_WeaponTargetArray;
								for (int i = 0; i < wRA_WeaponTargetArray.Length; i++)
								{
									Doctrine.WRA_WeaponTarget wRA_WeaponTarget = wRA_WeaponTargetArray[i];
									if (Information.IsNothing(this.m_Doctrine.GetWRA_WeaponDictionary()))
									{
										this.m_Doctrine.SetWRA_WeaponDictionary(new Dictionary<int, Doctrine.WRA_Weapon>());
									}
									if (!this.m_Doctrine.GetWRA_WeaponDictionary().ContainsKey(key))
									{
										Doctrine.WRA_Weapon value = new Doctrine.WRA_Weapon();
										this.m_Doctrine.GetWRA_WeaponDictionary().Add(key, value);
									}
									if (this.m_Doctrine.GetWRA_WeaponDictionary().ContainsKey(key))
									{
										Doctrine.WRA_Weapon wRA_Weapon2 = new Doctrine.WRA_Weapon();
										this.m_Doctrine.GetWRA_WeaponDictionary().TryGetValue(key, out wRA_Weapon2);
										Doctrine.WRA_WeaponTarget wRA_WeaponTarget2 = new Doctrine.WRA_WeaponTarget(wRA_WeaponTarget.WRA_WeaponTargetType);
										wRA_WeaponTarget2.WeaponQty = wRA_WeaponTarget.WeaponQty;
										wRA_WeaponTarget2.ShooterQty = wRA_WeaponTarget.ShooterQty;
										wRA_WeaponTarget2.SelfDefenceRange = wRA_WeaponTarget.SelfDefenceRange;
										wRA_WeaponTarget2.FiringRange = wRA_WeaponTarget.FiringRange;
										ScenarioArrayUtil.AddWRA_WeaponTarget(ref wRA_Weapon2.WRA_WeaponTargetArray, wRA_WeaponTarget2);
									}
								}
							}
							continue;
						}
					}
					if (!Information.IsNothing(this.m_Doctrine.GetWRA_WeaponDictionary()))
					{
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current3 in this.m_Doctrine.GetWRA_WeaponDictionary())
						{
							int key2 = current3.Key;
							Doctrine.WRA_Weapon wRA_Weapon3 = new Doctrine.WRA_Weapon();
							this.m_Doctrine.GetWRA_WeaponDictionary().TryGetValue(key2, out wRA_Weapon3);
							Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray2 = wRA_Weapon3.WRA_WeaponTargetArray;
							for (int j = 0; j < wRA_WeaponTargetArray2.Length; j++)
							{
								Doctrine.WRA_WeaponTarget wRA_WeaponTarget3 = wRA_WeaponTargetArray2[j];
								int? num2 = null;
								int? num3 = null;
								int? num4 = null;
								int? num5 = null;
								if (!Information.IsNothing(current.m_Doctrine.GetWRA_WeaponDictionary()) && current.m_Doctrine.GetWRA_WeaponDictionary().ContainsKey(key2))
								{
									Doctrine.WRA_Weapon wRA_Weapon4 = new Doctrine.WRA_Weapon();
									current.m_Doctrine.GetWRA_WeaponDictionary().TryGetValue(key2, out wRA_Weapon4);
									if (!Information.IsNothing(wRA_Weapon4))
									{
										Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray3 = wRA_Weapon4.WRA_WeaponTargetArray;
										for (int k = 0; k < wRA_WeaponTargetArray3.Length; k++)
										{
											Doctrine.WRA_WeaponTarget wRA_WeaponTarget4 = wRA_WeaponTargetArray3[k];
											if (wRA_WeaponTarget3.WRA_WeaponTargetType == wRA_WeaponTarget4.WRA_WeaponTargetType)
											{
												num2 = wRA_WeaponTarget4.WeaponQty;
												num3 = wRA_WeaponTarget4.ShooterQty;
												num4 = wRA_WeaponTarget4.SelfDefenceRange;
												num5 = wRA_WeaponTarget4.FiringRange;
												break;
											}
										}
									}
								}
								int? num6 = wRA_WeaponTarget3.WeaponQty;
								bool? flag = num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null;
								if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									if (!Information.IsNothing(wRA_WeaponTarget3.WeaponQty) && !Information.IsNothing(num2))
									{
										num6 = wRA_WeaponTarget3.WeaponQty;
										if (((num6.HasValue & num2.HasValue) ? new bool?(num6.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
										{
											wRA_WeaponTarget3.WeaponQty = new int?(-100);
										}
									}
									else if (Information.IsNothing(wRA_WeaponTarget3.WeaponQty) && !Information.IsNothing(num2))
									{
										wRA_WeaponTarget3.WeaponQty = new int?(-100);
									}
									else if (!Information.IsNothing(wRA_WeaponTarget3.WeaponQty) && Information.IsNothing(num2))
									{
										wRA_WeaponTarget3.WeaponQty = new int?(-100);
									}
								}
								num6 = wRA_WeaponTarget3.ShooterQty;
								flag = (num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null);
								if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									if (!Information.IsNothing(wRA_WeaponTarget3.ShooterQty) && !Information.IsNothing(num3))
									{
										num6 = wRA_WeaponTarget3.ShooterQty;
										if (((num6.HasValue & num3.HasValue) ? new bool?(num6.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
										{
											wRA_WeaponTarget3.ShooterQty = new int?(-100);
										}
									}
									else if (Information.IsNothing(wRA_WeaponTarget3.ShooterQty) && !Information.IsNothing(num3))
									{
										wRA_WeaponTarget3.ShooterQty = new int?(-100);
									}
									else if (!Information.IsNothing(wRA_WeaponTarget3.ShooterQty) && Information.IsNothing(num3))
									{
										wRA_WeaponTarget3.ShooterQty = new int?(-100);
									}
								}
								num6 = wRA_WeaponTarget3.SelfDefenceRange;
								flag = (num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null);
								if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									if (!Information.IsNothing(wRA_WeaponTarget3.SelfDefenceRange) && !Information.IsNothing(num4))
									{
										num6 = wRA_WeaponTarget3.SelfDefenceRange;
										if (((num6.HasValue & num4.HasValue) ? new bool?(num6.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
										{
											wRA_WeaponTarget3.SelfDefenceRange = new int?(-100);
										}
									}
									else if (Information.IsNothing(wRA_WeaponTarget3.SelfDefenceRange) && !Information.IsNothing(num4))
									{
										wRA_WeaponTarget3.SelfDefenceRange = new int?(-100);
									}
									else if (!Information.IsNothing(wRA_WeaponTarget3.SelfDefenceRange) && Information.IsNothing(num4))
									{
										wRA_WeaponTarget3.SelfDefenceRange = new int?(-100);
									}
								}
								num6 = wRA_WeaponTarget3.FiringRange;
								flag = (num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null);
								if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									if (!Information.IsNothing(wRA_WeaponTarget3.FiringRange) && !Information.IsNothing(num5))
									{
										num6 = wRA_WeaponTarget3.FiringRange;
										if (((num6.HasValue & num5.HasValue) ? new bool?(num6.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
										{
											wRA_WeaponTarget3.FiringRange = new int?(-100);
										}
									}
									else if (Information.IsNothing(wRA_WeaponTarget3.FiringRange) && !Information.IsNothing(num5))
									{
										wRA_WeaponTarget3.FiringRange = new int?(-100);
									}
									else if (!Information.IsNothing(wRA_WeaponTarget3.FiringRange) && Information.IsNothing(num5))
									{
										wRA_WeaponTarget3.FiringRange = new int?(-100);
									}
								}
							}
						}
					}
					if (!Information.IsNothing(current.m_Doctrine.GetWRA_WeaponDictionary()))
					{
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> current4 in current.m_Doctrine.GetWRA_WeaponDictionary())
						{
							int key3 = current4.Key;
							Doctrine.WRA_Weapon wRA_Weapon5 = new Doctrine.WRA_Weapon();
							current.m_Doctrine.GetWRA_WeaponDictionary().TryGetValue(key3, out wRA_Weapon5);
							Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray4 = wRA_Weapon5.WRA_WeaponTargetArray;
							for (int l = 0; l < wRA_WeaponTargetArray4.Length; l++)
							{
								Doctrine.WRA_WeaponTarget wRA_WeaponTarget5 = wRA_WeaponTargetArray4[l];
								if (Information.IsNothing(this.m_Doctrine.GetWRA_WeaponDictionary()))
								{
									this.m_Doctrine.SetWRA_WeaponDictionary(new Dictionary<int, Doctrine.WRA_Weapon>());
								}
								if (!this.m_Doctrine.GetWRA_WeaponDictionary().ContainsKey(key3))
								{
									Doctrine.WRA_Weapon value2 = new Doctrine.WRA_Weapon();
									this.m_Doctrine.GetWRA_WeaponDictionary().Add(key3, value2);
								}
								if (this.m_Doctrine.GetWRA_WeaponDictionary().ContainsKey(key3))
								{
									Doctrine.WRA_Weapon wRA_Weapon6 = new Doctrine.WRA_Weapon();
									this.m_Doctrine.GetWRA_WeaponDictionary().TryGetValue(key3, out wRA_Weapon6);
									bool flag2 = false;
									Doctrine.WRA_WeaponTarget[] wRA_WeaponTargetArray5 = wRA_Weapon6.WRA_WeaponTargetArray;
									int m = 0;
									while (m < wRA_WeaponTargetArray5.Length)
									{
										Doctrine.WRA_WeaponTarget wRA_WeaponTarget6 = wRA_WeaponTargetArray5[m];
										if (wRA_WeaponTarget6.WRA_WeaponTargetType != wRA_WeaponTarget5.WRA_WeaponTargetType)
										{
											m++;
										}
										else
										{
											flag2 = true;
											int? num6 = wRA_WeaponTarget6.WeaponQty;
											bool? flag3 = num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null;
											bool? flag;
											flag3 = (flag = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3));
											int? num7;
											if (((!flag3.HasValue || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(wRA_WeaponTarget6.WeaponQty)) : new bool?(true)).GetValueOrDefault())
											{
												if (!Information.IsNothing(wRA_WeaponTarget6.WeaponQty) && !Information.IsNothing(wRA_WeaponTarget5.WeaponQty))
												{
													num6 = wRA_WeaponTarget6.WeaponQty;
													num7 = wRA_WeaponTarget5.WeaponQty;
													if (((num6.HasValue & num7.HasValue) ? new bool?(num6.GetValueOrDefault() != num7.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														wRA_WeaponTarget6.WeaponQty = new int?(-100);
													}
												}
												else if (Information.IsNothing(wRA_WeaponTarget6.WeaponQty) && !Information.IsNothing(wRA_WeaponTarget5.WeaponQty))
												{
													wRA_WeaponTarget6.WeaponQty = new int?(-100);
												}
												else if (!Information.IsNothing(wRA_WeaponTarget6.WeaponQty) && Information.IsNothing(wRA_WeaponTarget5.WeaponQty))
												{
													wRA_WeaponTarget6.WeaponQty = new int?(-100);
												}
											}
											num7 = wRA_WeaponTarget6.ShooterQty;
											flag3 = (num7.HasValue ? new bool?(num7.GetValueOrDefault() == -100) : null);
											flag3 = (flag = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3));
											if (((!flag3.HasValue || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(wRA_WeaponTarget6.ShooterQty)) : new bool?(true)).GetValueOrDefault())
											{
												if (!Information.IsNothing(wRA_WeaponTarget6.ShooterQty) && !Information.IsNothing(wRA_WeaponTarget5.ShooterQty))
												{
													num7 = wRA_WeaponTarget6.ShooterQty;
													num6 = wRA_WeaponTarget5.ShooterQty;
													if (((num7.HasValue & num6.HasValue) ? new bool?(num7.GetValueOrDefault() != num6.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														wRA_WeaponTarget6.ShooterQty = new int?(-100);
													}
												}
												else if (Information.IsNothing(wRA_WeaponTarget6.ShooterQty) && !Information.IsNothing(wRA_WeaponTarget5.ShooterQty))
												{
													wRA_WeaponTarget6.ShooterQty = new int?(-100);
												}
												else if (!Information.IsNothing(wRA_WeaponTarget6.ShooterQty) && Information.IsNothing(wRA_WeaponTarget5.ShooterQty))
												{
													wRA_WeaponTarget6.ShooterQty = new int?(-100);
												}
											}
											num6 = wRA_WeaponTarget6.SelfDefenceRange;
											flag3 = (num6.HasValue ? new bool?(num6.GetValueOrDefault() == -100) : null);
											flag3 = (flag = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3));
											if (((!flag3.HasValue || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(wRA_WeaponTarget6.SelfDefenceRange)) : new bool?(true)).GetValueOrDefault())
											{
												if (!Information.IsNothing(wRA_WeaponTarget6.SelfDefenceRange) && !Information.IsNothing(wRA_WeaponTarget5.SelfDefenceRange))
												{
													num6 = wRA_WeaponTarget6.SelfDefenceRange;
													num7 = wRA_WeaponTarget5.SelfDefenceRange;
													if (((num6.HasValue & num7.HasValue) ? new bool?(num6.GetValueOrDefault() != num7.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														wRA_WeaponTarget6.SelfDefenceRange = new int?(-100);
													}
												}
												else if (Information.IsNothing(wRA_WeaponTarget6.SelfDefenceRange) && !Information.IsNothing(wRA_WeaponTarget5.SelfDefenceRange))
												{
													wRA_WeaponTarget6.SelfDefenceRange = new int?(-100);
												}
												else if (!Information.IsNothing(wRA_WeaponTarget6.SelfDefenceRange) && Information.IsNothing(wRA_WeaponTarget5.SelfDefenceRange))
												{
													wRA_WeaponTarget6.SelfDefenceRange = new int?(-100);
												}
											}
											num7 = wRA_WeaponTarget6.FiringRange;
											flag3 = (num7.HasValue ? new bool?(num7.GetValueOrDefault() == -100) : null);
											flag3 = (flag = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3));
											if (((!flag3.HasValue || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(wRA_WeaponTarget6.FiringRange)) : new bool?(true)).GetValueOrDefault())
											{
												if (!Information.IsNothing(wRA_WeaponTarget6.FiringRange) && !Information.IsNothing(wRA_WeaponTarget5.FiringRange))
												{
													num7 = wRA_WeaponTarget6.FiringRange;
													num6 = wRA_WeaponTarget5.FiringRange;
													if (((num7.HasValue & num6.HasValue) ? new bool?(num7.GetValueOrDefault() != num6.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														wRA_WeaponTarget6.FiringRange = new int?(-100);
													}
												}
												else if (Information.IsNothing(wRA_WeaponTarget6.FiringRange) && !Information.IsNothing(wRA_WeaponTarget5.FiringRange))
												{
													wRA_WeaponTarget6.FiringRange = new int?(-100);
												}
												else if (!Information.IsNothing(wRA_WeaponTarget6.FiringRange) && Information.IsNothing(wRA_WeaponTarget5.FiringRange))
												{
													wRA_WeaponTarget6.FiringRange = new int?(-100);
												}
											}
											if (!flag2)
											{
												Doctrine.WRA_WeaponTarget wRA_WeaponTarget7 = new Doctrine.WRA_WeaponTarget(wRA_WeaponTarget5.WRA_WeaponTargetType);
												if (!Information.IsNothing(wRA_WeaponTarget5.WeaponQty))
												{
													wRA_WeaponTarget7.WeaponQty = new int?(-100);
												}
												if (!Information.IsNothing(wRA_WeaponTarget5.ShooterQty))
												{
													wRA_WeaponTarget7.ShooterQty = new int?(-100);
												}
												if (!Information.IsNothing(wRA_WeaponTarget5.SelfDefenceRange))
												{
													wRA_WeaponTarget7.SelfDefenceRange = new int?(-100);
												}
												if (!Information.IsNothing(wRA_WeaponTarget5.FiringRange))
												{
													wRA_WeaponTarget7.FiringRange = new int?(-100);
												}
												ScenarioArrayUtil.AddWRA_WeaponTarget(ref wRA_Weapon6.WRA_WeaponTargetArray, wRA_WeaponTarget7);
												goto IL_114F;
											}
											goto IL_114F;
										}
									}
									if (!flag2)
									{
										Doctrine.WRA_WeaponTarget wRA_WeaponTarget7 = new Doctrine.WRA_WeaponTarget(wRA_WeaponTarget5.WRA_WeaponTargetType);
										if (!Information.IsNothing(wRA_WeaponTarget5.WeaponQty))
										{
											wRA_WeaponTarget7.WeaponQty = new int?(-100);
										}
										if (!Information.IsNothing(wRA_WeaponTarget5.ShooterQty))
										{
											wRA_WeaponTarget7.ShooterQty = new int?(-100);
										}
										if (!Information.IsNothing(wRA_WeaponTarget5.SelfDefenceRange))
										{
											wRA_WeaponTarget7.SelfDefenceRange = new int?(-100);
										}
										if (!Information.IsNothing(wRA_WeaponTarget5.FiringRange))
										{
											wRA_WeaponTarget7.FiringRange = new int?(-100);
										}
										ScenarioArrayUtil.AddWRA_WeaponTarget(ref wRA_Weapon6.WRA_WeaponTargetArray, wRA_WeaponTarget7);
									}
								}
								IL_114F:;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005EF9 RID: 24313
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr intptr_0, int int_38, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06005EFA RID: 24314 RVA: 0x0002A0FC File Offset: 0x000282FC
		private void method_106()
		{
			DoctrineForm.SendMessage(base.Handle, 11, new IntPtr(0), IntPtr.Zero);
			CommandFactory.GetCommandMain().GetMainForm().rightColumnWPF_0.method_0();
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x0002A12B File Offset: 0x0002832B
		private void method_107(bool Refresh = true)
		{
			DoctrineForm.SendMessage(base.Handle, 11, new IntPtr(-1), IntPtr.Zero);
			if (Refresh)
			{
				this.Refresh();
			}
			CommandFactory.GetCommandMain().GetMainForm().rightColumnWPF_0.method_1();
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void TGV_WRA_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x0002A166 File Offset: 0x00028366
		private void method_109(object sender, EventArgs e)
		{
			this.m_Doctrine.method_125(Client.GetClientScenario(), this.vmethod_184().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0002A19D File Offset: 0x0002839D
		private void method_110(object sender, EventArgs e)
		{
			this.m_Doctrine.method_130(Client.GetClientScenario(), this.vmethod_182().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0002A1D4 File Offset: 0x000283D4
		private void method_111(object sender, EventArgs e)
		{
			this.m_Doctrine.SetRefuelAllies_PlayerEditable(Client.GetClientScenario(), this.vmethod_196().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x0002A20B File Offset: 0x0002840B
		private void method_112(object sender, EventArgs e)
		{
			this.m_Doctrine.SetAvoidContact_PlayerEditable(Client.GetClientScenario(), this.vmethod_206().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x0002A242 File Offset: 0x00028442
		private void method_113(object sender, EventArgs e)
		{
			this.m_Doctrine.SetDiveWhenThreatsDetected_PlayerEditable(Client.GetClientScenario(), this.vmethod_208().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x0002A279 File Offset: 0x00028479
		private void method_114(object sender, EventArgs e)
		{
			this.m_Doctrine.SetRechargePercentagePatrol_PlayerEditable(Client.GetClientScenario(), this.vmethod_214().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x0002A2B0 File Offset: 0x000284B0
		private void method_115(object sender, EventArgs e)
		{
			this.m_Doctrine.SetRechargePercentageAttack_PlayerEditable(Client.GetClientScenario(), this.vmethod_220().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x0002A2E7 File Offset: 0x000284E7
		private void method_116(object sender, EventArgs e)
		{
			this.m_Doctrine.SetAIPUsage_PlayerEditable(Client.GetClientScenario(), this.vmethod_226().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x0002A31E File Offset: 0x0002851E
		private void method_117(object sender, EventArgs e)
		{
			this.m_Doctrine.SetDippingSonar_PlayerEditable(Client.GetClientScenario(), this.vmethod_232().Checked);
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2474_0.method_0(false);
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x002CF2D8 File Offset: 0x002CD4D8
		private void method_118(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_192();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_320(ref comboBox_, ref clientScenario, ref this.int_23, true, false);
			this.vmethod_193(comboBox_);
			Doctrine doctrine2 = this.m_Doctrine;
			clientScenario = Client.GetClientScenario();
			Side clientSide = Client.GetClientSide();
			doctrine2.method_333(ref clientScenario, ref clientSide);
			Client.SetClientSide(clientSide);
			this.method_14();
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x002CF340 File Offset: 0x002CD540
		private void method_119(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_200();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_322(ref comboBox_, ref clientScenario, ref this.int_24, true, false);
			this.vmethod_201(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x002CF380 File Offset: 0x002CD580
		private void method_120(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_204();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_324(ref comboBox_, ref clientScenario, ref this.int_25, true, false);
			this.vmethod_205(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x002CF3C0 File Offset: 0x002CD5C0
		private void method_121(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_212();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_326(ref comboBox_, ref clientScenario, ref this.int_26, true, false);
			this.vmethod_213(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x002CF400 File Offset: 0x002CD600
		private void method_122(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_218();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_328(ref comboBox_, ref clientScenario, ref this.int_27, true, false);
			this.vmethod_219(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x002CF440 File Offset: 0x002CD640
		private void method_123(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_224();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_330(ref comboBox_, ref clientScenario, ref this.int_28, true, false);
			this.vmethod_225(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x002CF480 File Offset: 0x002CD680
		private void method_124(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_230();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_332(ref comboBox_, ref clientScenario, ref this.int_29, true, false);
			this.vmethod_231(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x0002A355 File Offset: 0x00028555
		private void method_125(object sender, EventArgs e)
		{
			this.int_23 = this.vmethod_192().SelectedIndex;
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x0002A368 File Offset: 0x00028568
		private void method_126(object sender, EventArgs e)
		{
			this.int_24 = this.vmethod_200().SelectedIndex;
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0002A37B File Offset: 0x0002857B
		private void method_127(object sender, EventArgs e)
		{
			this.int_25 = this.vmethod_204().SelectedIndex;
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x0002A38E File Offset: 0x0002858E
		private void method_128(object sender, EventArgs e)
		{
			this.int_9 = this.vmethod_70().SelectedIndex;
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x0002A3A1 File Offset: 0x000285A1
		private void method_129(object sender, EventArgs e)
		{
			this.int_26 = this.vmethod_212().SelectedIndex;
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x0002A3B4 File Offset: 0x000285B4
		private void method_130(object sender, EventArgs e)
		{
			this.int_27 = this.vmethod_218().SelectedIndex;
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x0002A3C7 File Offset: 0x000285C7
		private void method_131(object sender, EventArgs e)
		{
			this.int_28 = this.vmethod_224().SelectedIndex;
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x0002A3DA File Offset: 0x000285DA
		private void method_132(object sender, EventArgs e)
		{
			this.int_29 = this.vmethod_230().SelectedIndex;
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0002A3ED File Offset: 0x000285ED
		private void method_133(object sender, EventArgs e)
		{
			this.int_30 = this.GetCombo_WithdrawDamageThreshold().SelectedIndex;
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x0002A400 File Offset: 0x00028600
		private void method_134(object sender, EventArgs e)
		{
			this.int_34 = this.vmethod_268().SelectedIndex;
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x002CF4C0 File Offset: 0x002CD6C0
		private void method_135(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_WithdrawDamageThreshold = this.GetCombo_WithdrawDamageThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_350(ref combo_WithdrawDamageThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_251(combo_WithdrawDamageThreshold);
			this.method_14();
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x002CF500 File Offset: 0x002CD700
		private void method_136(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox comboBox_ = this.vmethod_268();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_351(ref comboBox_, ref clientScenario, ref num, true, true);
			this.vmethod_269(comboBox_);
			this.method_14();
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0002A413 File Offset: 0x00028613
		private void method_137(object sender, EventArgs e)
		{
			this.int_31 = this.GetCombo_WithdrawFuelThreshold().SelectedIndex;
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x002CF540 File Offset: 0x002CD740
		private void method_138(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_WithdrawFuelThreshold = this.GetCombo_WithdrawFuelThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_352(ref combo_WithdrawFuelThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_241(combo_WithdrawFuelThreshold);
			this.method_14();
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x0002A426 File Offset: 0x00028626
		private void method_139(object sender, EventArgs e)
		{
			this.int_35 = this.GetCombo_RedeployFuelThreshold().SelectedIndex;
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x002CF580 File Offset: 0x002CD780
		private void method_140(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_RedeployFuelThreshold = this.GetCombo_RedeployFuelThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_353(ref combo_RedeployFuelThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_259(combo_RedeployFuelThreshold);
			this.method_14();
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x0002A439 File Offset: 0x00028639
		private void method_141(object sender, EventArgs e)
		{
			this.int_32 = this.GetCombo_WithdrawAttackThreshold().SelectedIndex;
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x002CF5C0 File Offset: 0x002CD7C0
		private void method_142(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_WithdrawAttackThreshold = this.GetCombo_WithdrawAttackThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_354(ref combo_WithdrawAttackThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_239(combo_WithdrawAttackThreshold);
			this.method_14();
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x0002A44C File Offset: 0x0002864C
		private void method_143(object sender, EventArgs e)
		{
			this.int_36 = this.GetCombo_RedeployAttackThreshold().SelectedIndex;
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x002CF600 File Offset: 0x002CD800
		private void method_144(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_RedeployAttackThreshold = this.GetCombo_RedeployAttackThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_355(ref combo_RedeployAttackThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_257(combo_RedeployAttackThreshold);
			this.method_14();
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x0002A45F File Offset: 0x0002865F
		private void method_145(object sender, EventArgs e)
		{
			this.int_33 = this.GetCombo_WithdrawDefenceThreshold().SelectedIndex;
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x002CF640 File Offset: 0x002CD840
		private void method_146(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_WithdrawDefenceThreshold = this.GetCombo_WithdrawDefenceThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_356(ref combo_WithdrawDefenceThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_237(combo_WithdrawDefenceThreshold);
			this.method_14();
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x0002A472 File Offset: 0x00028672
		private void method_147(object sender, EventArgs e)
		{
			this.int_37 = this.GetCombo_RedeployDefenceThreshold().SelectedIndex;
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x002CF680 File Offset: 0x002CD880
		private void method_148(object sender, EventArgs e)
		{
			Doctrine doctrine = this.m_Doctrine;
			ComboBox combo_RedeployDefenceThreshold = this.GetCombo_RedeployDefenceThreshold();
			Scenario clientScenario = Client.GetClientScenario();
			int num = 0;
			doctrine.method_357(ref combo_RedeployDefenceThreshold, ref clientScenario, ref num, true, true);
			this.vmethod_255(combo_RedeployDefenceThreshold);
			this.method_14();
		}

		// Token: 0x04003164 RID: 12644
		public static Func<KeyValuePair<int, Doctrine.WRA_Weapon>, string> KeyWaluePairFunc0 = (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair_0) => keyValuePair_0.Value.method_1(Client.GetClientScenario(), keyValuePair_0.Key).Name;

		// Token: 0x04003165 RID: 12645
		public static Func<Magazine, string> MagazineFunc1 = (Magazine magazine_0) => magazine_0.Name;

		// Token: 0x04003166 RID: 12646
		public static Func<Mount, string> MountFunc2 = (Mount mount_0) => mount_0.Name;

		// Token: 0x04003168 RID: 12648
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04003169 RID: 12649
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400316A RID: 12650
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x0400316B RID: 12651
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x0400316C RID: 12652
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400316D RID: 12653
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x0400316E RID: 12654
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x0400316F RID: 12655
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04003170 RID: 12656
		[CompilerGenerated]
		private ComboBox comboBox_2;

		// Token: 0x04003171 RID: 12657
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04003172 RID: 12658
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04003173 RID: 12659
		[CompilerGenerated]
		private TreeGridView TGV_WRA;

		// Token: 0x04003174 RID: 12660
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003175 RID: 12661
		[CompilerGenerated]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04003176 RID: 12662
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04003177 RID: 12663
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04003178 RID: 12664
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04003179 RID: 12665
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x0400317A RID: 12666
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x0400317B RID: 12667
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x0400317C RID: 12668
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x0400317D RID: 12669
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x0400317E RID: 12670
		[CompilerGenerated]
		private Label label_10;

		// Token: 0x0400317F RID: 12671
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04003180 RID: 12672
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04003181 RID: 12673
		[CompilerGenerated]
		private Label label_11;

		// Token: 0x04003182 RID: 12674
		[CompilerGenerated]
		private ComboBox comboBox_3;

		// Token: 0x04003183 RID: 12675
		[CompilerGenerated]
		private ComboBox comboBox_4;

		// Token: 0x04003184 RID: 12676
		[CompilerGenerated]
		private ComboBox comboBox_5;

		// Token: 0x04003185 RID: 12677
		[CompilerGenerated]
		private Label label_12;

		// Token: 0x04003186 RID: 12678
		[CompilerGenerated]
		private ComboBox comboBox_6;

		// Token: 0x04003187 RID: 12679
		[CompilerGenerated]
		private CheckBox checkBox_4;

		// Token: 0x04003188 RID: 12680
		[CompilerGenerated]
		private Label label_13;

		// Token: 0x04003189 RID: 12681
		[CompilerGenerated]
		private ComboBox comboBox_7;

		// Token: 0x0400318A RID: 12682
		[CompilerGenerated]
		private CheckBox checkBox_5;

		// Token: 0x0400318B RID: 12683
		[CompilerGenerated]
		private ComboBox comboBox_8;

		// Token: 0x0400318C RID: 12684
		[CompilerGenerated]
		private CheckBox checkBox_6;

		// Token: 0x0400318D RID: 12685
		[CompilerGenerated]
		private ComboBox comboBox_9;

		// Token: 0x0400318E RID: 12686
		[CompilerGenerated]
		private CheckBox checkBox_7;

		// Token: 0x0400318F RID: 12687
		[CompilerGenerated]
		private ComboBox comboBox_10;

		// Token: 0x04003190 RID: 12688
		[CompilerGenerated]
		private CheckBox checkBox_8;

		// Token: 0x04003191 RID: 12689
		[CompilerGenerated]
		private ComboBox comboBox_11;

		// Token: 0x04003192 RID: 12690
		[CompilerGenerated]
		private CheckBox checkBox_9;

		// Token: 0x04003193 RID: 12691
		[CompilerGenerated]
		private ComboBox comboBox_12;

		// Token: 0x04003194 RID: 12692
		[CompilerGenerated]
		private CheckBox checkBox_10;

		// Token: 0x04003195 RID: 12693
		[CompilerGenerated]
		private Label label_14;

		// Token: 0x04003196 RID: 12694
		[CompilerGenerated]
		private ComboBox comboBox_13;

		// Token: 0x04003197 RID: 12695
		[CompilerGenerated]
		private ComboBox comboBox_14;

		// Token: 0x04003198 RID: 12696
		[CompilerGenerated]
		private CheckBox checkBox_11;

		// Token: 0x04003199 RID: 12697
		[CompilerGenerated]
		private CheckBox checkBox_12;

		// Token: 0x0400319A RID: 12698
		[CompilerGenerated]
		private Label label_15;

		// Token: 0x0400319B RID: 12699
		[CompilerGenerated]
		private ComboBox comboBox_15;

		// Token: 0x0400319C RID: 12700
		[CompilerGenerated]
		private CheckBox checkBox_13;

		// Token: 0x0400319D RID: 12701
		[CompilerGenerated]
		private Label label_16;

		// Token: 0x0400319E RID: 12702
		[CompilerGenerated]
		private Label label_17;

		// Token: 0x0400319F RID: 12703
		[CompilerGenerated]
		private Label label_18;

		// Token: 0x040031A0 RID: 12704
		[CompilerGenerated]
		private Label label_19;

		// Token: 0x040031A1 RID: 12705
		[CompilerGenerated]
		private Label label_20;

		// Token: 0x040031A2 RID: 12706
		[CompilerGenerated]
		private Label label_21;

		// Token: 0x040031A3 RID: 12707
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040031A4 RID: 12708
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x040031A5 RID: 12709
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x040031A6 RID: 12710
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x040031A7 RID: 12711
		[CompilerGenerated]
		private Button button_5;

		// Token: 0x040031A8 RID: 12712
		[CompilerGenerated]
		private Button button_6;

		// Token: 0x040031A9 RID: 12713
		[CompilerGenerated]
		private Button button_7;

		// Token: 0x040031AA RID: 12714
		[CompilerGenerated]
		private Button button_8;

		// Token: 0x040031AB RID: 12715
		[CompilerGenerated]
		private Label label_22;

		// Token: 0x040031AC RID: 12716
		[CompilerGenerated]
		private ComboBox comboBox_16;

		// Token: 0x040031AD RID: 12717
		[CompilerGenerated]
		private CheckBox checkBox_14;

		// Token: 0x040031AE RID: 12718
		[CompilerGenerated]
		private Label label_23;

		// Token: 0x040031AF RID: 12719
		[CompilerGenerated]
		private Label label_24;

		// Token: 0x040031B0 RID: 12720
		[CompilerGenerated]
		private Label label_25;

		// Token: 0x040031B1 RID: 12721
		[CompilerGenerated]
		private CheckBox checkBox_15;

		// Token: 0x040031B2 RID: 12722
		[CompilerGenerated]
		private CheckBox checkBox_16;

		// Token: 0x040031B3 RID: 12723
		[CompilerGenerated]
		private CheckBox checkBox_17;

		// Token: 0x040031B4 RID: 12724
		[CompilerGenerated]
		private ComboBox comboBox_17;

		// Token: 0x040031B5 RID: 12725
		[CompilerGenerated]
		private ComboBox comboBox_18;

		// Token: 0x040031B6 RID: 12726
		[CompilerGenerated]
		private ComboBox comboBox_19;

		// Token: 0x040031B7 RID: 12727
		[CompilerGenerated]
		private Label label_26;

		// Token: 0x040031B8 RID: 12728
		[CompilerGenerated]
		private CheckBox checkBox_18;

		// Token: 0x040031B9 RID: 12729
		[CompilerGenerated]
		private ComboBox comboBox_20;

		// Token: 0x040031BA RID: 12730
		[CompilerGenerated]
		private Label label_27;

		// Token: 0x040031BB RID: 12731
		[CompilerGenerated]
		private Label label_28;

		// Token: 0x040031BC RID: 12732
		[CompilerGenerated]
		private Label label_29;

		// Token: 0x040031BD RID: 12733
		[CompilerGenerated]
		private ComboBox comboBox_21;

		// Token: 0x040031BE RID: 12734
		[CompilerGenerated]
		private ComboBox comboBox_22;

		// Token: 0x040031BF RID: 12735
		[CompilerGenerated]
		private CheckBox checkBox_19;

		// Token: 0x040031C0 RID: 12736
		[CompilerGenerated]
		private CheckBox checkBox_20;

		// Token: 0x040031C1 RID: 12737
		[CompilerGenerated]
		private ComboBox comboBox_23;

		// Token: 0x040031C2 RID: 12738
		[CompilerGenerated]
		private Label label_30;

		// Token: 0x040031C3 RID: 12739
		[CompilerGenerated]
		private CheckBox checkBox_21;

		// Token: 0x040031C4 RID: 12740
		[CompilerGenerated]
		private CheckBox checkBox_22;

		// Token: 0x040031C5 RID: 12741
		[CompilerGenerated]
		private ComboBox comboBox_24;

		// Token: 0x040031C6 RID: 12742
		[CompilerGenerated]
		private Label label_31;

		// Token: 0x040031C7 RID: 12743
		[CompilerGenerated]
		private Label label_32;

		// Token: 0x040031C8 RID: 12744
		[CompilerGenerated]
		private ComboBox comboBox_25;

		// Token: 0x040031C9 RID: 12745
		[CompilerGenerated]
		private Label label_33;

		// Token: 0x040031CA RID: 12746
		[CompilerGenerated]
		private CheckBox checkBox_23;

		// Token: 0x040031CB RID: 12747
		[CompilerGenerated]
		private Label label_34;

		// Token: 0x040031CC RID: 12748
		[CompilerGenerated]
		private ComboBox comboBox_26;

		// Token: 0x040031CD RID: 12749
		[CompilerGenerated]
		private Label label_35;

		// Token: 0x040031CE RID: 12750
		[CompilerGenerated]
		private ComboBox comboBox_27;

		// Token: 0x040031CF RID: 12751
		[CompilerGenerated]
		private CheckBox checkBox_24;

		// Token: 0x040031D0 RID: 12752
		[CompilerGenerated]
		private CheckBox checkBox_25;

		// Token: 0x040031D1 RID: 12753
		[CompilerGenerated]
		private Label label_36;

		// Token: 0x040031D2 RID: 12754
		[CompilerGenerated]
		private ComboBox comboBox_28;

		// Token: 0x040031D3 RID: 12755
		[CompilerGenerated]
		private CheckBox checkBox_26;

		// Token: 0x040031D4 RID: 12756
		[CompilerGenerated]
		private Label label_37;

		// Token: 0x040031D5 RID: 12757
		[CompilerGenerated]
		private ComboBox comboBox_29;

		// Token: 0x040031D6 RID: 12758
		[CompilerGenerated]
		private CheckBox checkBox_27;

		// Token: 0x040031D7 RID: 12759
		[CompilerGenerated]
		private Label label_38;

		// Token: 0x040031D8 RID: 12760
		[CompilerGenerated]
		private ComboBox comboBox_30;

		// Token: 0x040031D9 RID: 12761
		[CompilerGenerated]
		private CheckBox checkBox_28;

		// Token: 0x040031DA RID: 12762
		[CompilerGenerated]
		private Label label_39;

		// Token: 0x040031DB RID: 12763
		[CompilerGenerated]
		private ComboBox comboBox_31;

		// Token: 0x040031DC RID: 12764
		[CompilerGenerated]
		private CheckBox checkBox_29;

		// Token: 0x040031DD RID: 12765
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x040031DE RID: 12766
		[CompilerGenerated]
		private ComboBox comboBox_32;

		// Token: 0x040031DF RID: 12767
		[CompilerGenerated]
		private ComboBox comboBox_33;

		// Token: 0x040031E0 RID: 12768
		[CompilerGenerated]
		private ComboBox comboBox_34;

		// Token: 0x040031E1 RID: 12769
		[CompilerGenerated]
		private Label label_40;

		// Token: 0x040031E2 RID: 12770
		[CompilerGenerated]
		private Label label_41;

		// Token: 0x040031E3 RID: 12771
		[CompilerGenerated]
		private Label label_42;

		// Token: 0x040031E4 RID: 12772
		[CompilerGenerated]
		private Label label_43;

		// Token: 0x040031E5 RID: 12773
		[CompilerGenerated]
		private ComboBox comboBox_35;

		// Token: 0x040031E6 RID: 12774
		[CompilerGenerated]
		private Label label_44;

		// Token: 0x040031E7 RID: 12775
		[CompilerGenerated]
		private ComboBox comboBox_36;

		// Token: 0x040031E8 RID: 12776
		[CompilerGenerated]
		private ComboBox comboBox_37;

		// Token: 0x040031E9 RID: 12777
		[CompilerGenerated]
		private ComboBox comboBox_38;

		// Token: 0x040031EA RID: 12778
		[CompilerGenerated]
		private Label label_45;

		// Token: 0x040031EB RID: 12779
		[CompilerGenerated]
		private Label label_46;

		// Token: 0x040031EC RID: 12780
		[CompilerGenerated]
		private Label label_47;

		// Token: 0x040031ED RID: 12781
		[CompilerGenerated]
		private Label label_48;

		// Token: 0x040031EE RID: 12782
		[CompilerGenerated]
		private ComboBox comboBox_39;

		// Token: 0x040031EF RID: 12783
		[CompilerGenerated]
		private Label label_49;

		// Token: 0x040031F0 RID: 12784
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_0;

		// Token: 0x040031F1 RID: 12785
		[CompilerGenerated]
		private DataGridViewComboBoxColumn CB_WeaponsPerSalvo;

		// Token: 0x040031F2 RID: 12786
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x040031F3 RID: 12787
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x040031F4 RID: 12788
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x040031F5 RID: 12789
		[CompilerGenerated]
		private Label label_50;

		// Token: 0x040031F6 RID: 12790
		[CompilerGenerated]
		private CheckBox checkBox_30;

		// Token: 0x040031F7 RID: 12791
		[CompilerGenerated]
		private ComboBox comboBox_40;

		// Token: 0x040031F8 RID: 12792
		public Subject subject;

		// Token: 0x040031F9 RID: 12793
		public Collection<ActiveUnit> ActiveUnitCollection;

		// Token: 0x040031FA RID: 12794
		public bool bool_0;

		// Token: 0x040031FB RID: 12795
		private Doctrine m_Doctrine;

		// Token: 0x040031FC RID: 12796
		private Dictionary<int, Doctrine.WRA_Weapon> WRA_WeaponDictionary;

		// Token: 0x040031FD RID: 12797
		private Collection<int> collection_1;

		// Token: 0x040031FE RID: 12798
		private int int_0;

		// Token: 0x040031FF RID: 12799
		private int int_1;

		// Token: 0x04003200 RID: 12800
		private int int_2 = 0;

		// Token: 0x04003201 RID: 12801
		private int int_3 = 0;

		// Token: 0x04003202 RID: 12802
		private int int_4;

		// Token: 0x04003203 RID: 12803
		private int int_5;

		// Token: 0x04003204 RID: 12804
		private int int_6;

		// Token: 0x04003205 RID: 12805
		private int int_7;

		// Token: 0x04003206 RID: 12806
		private int int_8;

		// Token: 0x04003207 RID: 12807
		private int int_9;

		// Token: 0x04003208 RID: 12808
		private int int_10;

		// Token: 0x04003209 RID: 12809
		private int int_11;

		// Token: 0x0400320A RID: 12810
		private int int_12;

		// Token: 0x0400320B RID: 12811
		private int int_13;

		// Token: 0x0400320C RID: 12812
		private int int_14;

		// Token: 0x0400320D RID: 12813
		private int int_15;

		// Token: 0x0400320E RID: 12814
		private int int_16;

		// Token: 0x0400320F RID: 12815
		private int int_17;

		// Token: 0x04003210 RID: 12816
		private int int_18;

		// Token: 0x04003211 RID: 12817
		private int int_19;

		// Token: 0x04003212 RID: 12818
		private int int_20;

		// Token: 0x04003213 RID: 12819
		private int int_21;

		// Token: 0x04003214 RID: 12820
		private int int_22;

		// Token: 0x04003215 RID: 12821
		private int int_23;

		// Token: 0x04003216 RID: 12822
		private int int_24;

		// Token: 0x04003217 RID: 12823
		private int int_25;

		// Token: 0x04003218 RID: 12824
		private int int_26;

		// Token: 0x04003219 RID: 12825
		private int int_27;

		// Token: 0x0400321A RID: 12826
		private int int_28;

		// Token: 0x0400321B RID: 12827
		private int int_29;

		// Token: 0x0400321C RID: 12828
		private int int_30;

		// Token: 0x0400321D RID: 12829
		private int int_31;

		// Token: 0x0400321E RID: 12830
		private int int_32;

		// Token: 0x0400321F RID: 12831
		private int int_33;

		// Token: 0x04003220 RID: 12832
		private int int_34;

		// Token: 0x04003221 RID: 12833
		private int int_35;

		// Token: 0x04003222 RID: 12834
		private int int_36;

		// Token: 0x04003223 RID: 12835
		private int int_37;

		// Token: 0x04003224 RID: 12836
		private Doctrine._UseNuclear? UseNuclearDoc;

		// Token: 0x04003225 RID: 12837
		private Doctrine._WeaponControlStatus? WCS_AirDoc;

		// Token: 0x04003226 RID: 12838
		private Doctrine._WeaponControlStatus? WCS_SurfaceDoc;

		// Token: 0x04003227 RID: 12839
		private Doctrine._WeaponControlStatus? WCS_SubmarineDoc;

		// Token: 0x04003228 RID: 12840
		private Doctrine._WeaponControlStatus? WCS_LandDoc;

		// Token: 0x04003229 RID: 12841
		private Doctrine._IgnorePlottedCourseWhenAttacking? IgnorePlottedCourseWhenAttackingDoc;

		// Token: 0x0400322A RID: 12842
		private Doctrine._WeaponStateRTB? WinchesterShotgunRTBDoc;

		// Token: 0x0400322B RID: 12843
		private Doctrine._FuelStateRTB? FuelStateRTBDoc;

		// Token: 0x0400322C RID: 12844
		private Doctrine._JettisonOrdnance? JettisonOrdnanceDoc;

		// Token: 0x0400322D RID: 12845
		private Doctrine._BehaviorTowardsAmbigousTarget? BehaviorTowardsAmbigousTargetDoc;

		// Token: 0x0400322E RID: 12846
		private Doctrine._AutomaticEvasion? AutomaticEvasionDoc;

		// Token: 0x0400322F RID: 12847
		private Doctrine._MaintainStandoff? MaintainStandoffDoc;

		// Token: 0x04003230 RID: 12848
		private Doctrine._UseRefuel? UseRefuelDoc;

		// Token: 0x04003231 RID: 12849
		private Doctrine._RefuelSelection? RefuelSelectionDoc;

		// Token: 0x04003232 RID: 12850
		private Doctrine._ShootTourists? ShootTouristsDoc;

		// Token: 0x04003233 RID: 12851
		private Doctrine._UseSAMsInASuWMode? UseSAMsInASuWModeDoc;

		// Token: 0x04003234 RID: 12852
		private Doctrine._IgnoreEMCONUnderAttack? IgnoreEMCONUnderAttackDoc;

		// Token: 0x04003235 RID: 12853
		private Doctrine._QuickTurnAround? QuickTurnAroundDoc;

		// Token: 0x04003236 RID: 12854
		private Doctrine._AirOpsTempo? AirOpsTempoDoc;

		// Token: 0x04003237 RID: 12855
		private Doctrine._FuelState? BingoJokerDoct;

		// Token: 0x04003238 RID: 12856
		private Doctrine._WeaponState? WinchesterShotgunDoc;

		// Token: 0x04003239 RID: 12857
		private Doctrine._UseTorpedoesKinematicRange? UseTorpedoesKinematicRangeDoc;

		// Token: 0x0400323A RID: 12858
		private Doctrine.EMCON_Settings.Enum36 EMCON_SettingsForRadar;

		// Token: 0x0400323B RID: 12859
		private Doctrine.EMCON_Settings.Enum36 EMCON_SettingsForSonar;

		// Token: 0x0400323C RID: 12860
		private Doctrine.EMCON_Settings.Enum36 EMCON_SettingsForOECM;

		// Token: 0x0400323D RID: 12861
		private Doctrine._GunStrafeGroundTargets? GunStrafeGroundTargetsDoc;

		// Token: 0x0400323E RID: 12862
		private Doctrine._RefuelAlliedUnits? RefuelAlliedUnitsDoc;

		// Token: 0x0400323F RID: 12863
		private Doctrine._AvoidContactWhenPossible? AvoidContactWhenPossibleDoc;

		// Token: 0x04003240 RID: 12864
		private Doctrine._DiveOnContact? DiveOnContactDoc;

		// Token: 0x04003241 RID: 12865
		private Doctrine._RechargeBatteryPercentage? RechargeBatteryPercentageDoc;

		// Token: 0x04003242 RID: 12866
		private Doctrine._RechargeBatteryPercentage? nullable_27;

		// Token: 0x04003243 RID: 12867
		private Doctrine._UseAIP? _UseAIPDoc;

		// Token: 0x04003244 RID: 12868
		private Doctrine._UseDippingSonar? UseDippingSonarDoc;

		// Token: 0x04003245 RID: 12869
		private Doctrine._DamageThreshold? WithdrawDamageThresholdDoc;

		// Token: 0x04003246 RID: 12870
		private Doctrine._FuelQuantityThreshold? WithdrawFuelThresholdDoc;

		// Token: 0x04003247 RID: 12871
		private Doctrine._WeaponQuantityThreshold? WithdrawAttackThresholdDoc;

		// Token: 0x04003248 RID: 12872
		private Doctrine._WeaponQuantityThreshold? WithdrawDefenceThresholdDoc;

		// Token: 0x04003249 RID: 12873
		private Doctrine._DamageThreshold? RedeployDamageThresholdDoc;

		// Token: 0x0400324A RID: 12874
		private Doctrine._FuelQuantityThreshold? RedeployFuelThresholdDoc;

		// Token: 0x0400324B RID: 12875
		private Doctrine._WeaponQuantityThreshold? RedeployAttackWeaponQuantityThresholdDoc;

		// Token: 0x0400324C RID: 12876
		private Doctrine._WeaponQuantityThreshold? RedeployDefenceWeaponQuantityThresholdDoc;

		// Token: 0x0400324D RID: 12877
		private bool bool_1;

		// Token: 0x0400324E RID: 12878
		private bool bool_2 = false;

		// Token: 0x0400324F RID: 12879
		public bool bool_3;

		// Token: 0x04003250 RID: 12880
		public bool bool_4;

		// Token: 0x04003251 RID: 12881
		public bool bool_5;
	}
}
