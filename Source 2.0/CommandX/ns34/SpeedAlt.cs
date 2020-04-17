using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
using ns2;
using ns32;
using ns33;
using ns4;

namespace ns34
{
	// Token: 0x02000ABA RID: 2746
	[DesignerGenerated]
	public sealed partial class SpeedAlt : CommandForm
	{
		// Token: 0x060056F3 RID: 22259 RVA: 0x002593BC File Offset: 0x002575BC
		public SpeedAlt()
		{
			base.Load += new EventHandler(this.SpeedAlt_Load);
			base.KeyDown += new KeyEventHandler(this.SpeedAlt_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.SpeedAlt_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.SpeedAlt_FormClosed);
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = true;
			this.InitializeComponent();
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x0025C128 File Offset: 0x0025A328
		[CompilerGenerated]
		internal  TrackBar vmethod_0()
		{
			return this.trackBar_0;
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x0025C140 File Offset: 0x0025A340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TrackBar trackBar_2)
		{
			EventHandler value = new EventHandler(this.method_13);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_0 = trackBar_2;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x0025C18C File Offset: 0x0025A38C
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x00027AD5 File Offset: 0x00025CD5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_29)
		{
			this.label_0 = label_29;
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x0025C1A4 File Offset: 0x0025A3A4
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x00027ADE File Offset: 0x00025CDE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_29)
		{
			this.label_1 = label_29;
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x0025C1BC File Offset: 0x0025A3BC
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_2;
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x00027AE7 File Offset: 0x00025CE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_29)
		{
			this.label_2 = label_29;
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x0025C1D4 File Offset: 0x0025A3D4
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_3;
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x00027AF0 File Offset: 0x00025CF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_29)
		{
			this.label_3 = label_29;
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x0025C1EC File Offset: 0x0025A3EC
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_4;
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x00027AF9 File Offset: 0x00025CF9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_29)
		{
			this.label_4 = label_29;
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x0025C204 File Offset: 0x0025A404
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_5;
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00027B02 File Offset: 0x00025D02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_29)
		{
			this.label_5 = label_29;
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x0025C21C File Offset: 0x0025A41C
		[CompilerGenerated]
		internal  Timer vmethod_14()
		{
			return this.timer_0;
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x0025C234 File Offset: 0x0025A434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x0025C280 File Offset: 0x0025A480
		[CompilerGenerated]
		internal  TrackBar vmethod_16()
		{
			return this.trackBar_1;
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x0025C298 File Offset: 0x0025A498
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TrackBar trackBar_2)
		{
			EventHandler value = new EventHandler(this.method_14);
			TrackBar trackBar = this.trackBar_1;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_1 = trackBar_2;
			trackBar = this.trackBar_1;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x0025C2E4 File Offset: 0x0025A4E4
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_6;
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00027B0B File Offset: 0x00025D0B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_29)
		{
			this.label_6 = label_29;
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x0025C2FC File Offset: 0x0025A4FC
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_7;
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00027B14 File Offset: 0x00025D14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_29)
		{
			this.label_7 = label_29;
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x0025C314 File Offset: 0x0025A514
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_8;
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x00027B1D File Offset: 0x00025D1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_29)
		{
			this.label_8 = label_29;
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x0025C32C File Offset: 0x0025A52C
		[CompilerGenerated]
		internal  Label vmethod_24()
		{
			return this.label_9;
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00027B26 File Offset: 0x00025D26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_29)
		{
			this.label_9 = label_29;
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x0025C344 File Offset: 0x0025A544
		[CompilerGenerated]
		internal  Label vmethod_26()
		{
			return this.label_10;
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00027B2F File Offset: 0x00025D2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Label label_29)
		{
			this.label_10 = label_29;
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x0025C35C File Offset: 0x0025A55C
		[CompilerGenerated]
		internal  Label vmethod_28()
		{
			return this.label_11;
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00027B38 File Offset: 0x00025D38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Label label_29)
		{
			this.label_11 = label_29;
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x0025C374 File Offset: 0x0025A574
		[CompilerGenerated]
		internal  GroupBox vmethod_30()
		{
			return this.groupBox_0;
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00027B41 File Offset: 0x00025D41
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(GroupBox groupBox_6)
		{
			this.groupBox_0 = groupBox_6;
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x0025C38C File Offset: 0x0025A58C
		[CompilerGenerated]
		internal  GroupBox vmethod_32()
		{
			return this.groupBox_1;
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00027B4A File Offset: 0x00025D4A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(GroupBox groupBox_6)
		{
			this.groupBox_1 = groupBox_6;
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x0025C3A4 File Offset: 0x0025A5A4
		[CompilerGenerated]
		internal  GroupBox vmethod_34()
		{
			return this.groupBox_2;
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00027B53 File Offset: 0x00025D53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(GroupBox groupBox_6)
		{
			this.groupBox_2 = groupBox_6;
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0025C3BC File Offset: 0x0025A5BC
		[CompilerGenerated]
		internal  CheckBox GetCB_AltOverride()
		{
			return this.checkBox_0;
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x0025C3D4 File Offset: 0x0025A5D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_42);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_0 = checkBox_3;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x0025C420 File Offset: 0x0025A620
		[CompilerGenerated]
		internal  CheckBox vmethod_38()
		{
			return this.checkBox_1;
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x0025C438 File Offset: 0x0025A638
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_43);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_3;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x0025C484 File Offset: 0x0025A684
		[CompilerGenerated]
		internal  GroupBox GetGroupBox_SubDepthPreset()
		{
			return this.groupBox_3;
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x00027B5C File Offset: 0x00025D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(GroupBox groupBox_6)
		{
			this.groupBox_3 = groupBox_6;
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x0025C49C File Offset: 0x0025A69C
		[CompilerGenerated]
		internal  RadioButton GetRB_MaxDepth()
		{
			return this.radioButton_0;
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x0025C4B4 File Offset: 0x0025A6B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_24);
			RadioButton radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_0 = radioButton_21;
			radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x0025C500 File Offset: 0x0025A700
		[CompilerGenerated]
		internal  RadioButton GetRB_UnderLayer()
		{
			return this.radioButton_1;
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x0025C518 File Offset: 0x0025A718
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_23);
			RadioButton radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_1 = radioButton_21;
			radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x0025C564 File Offset: 0x0025A764
		[CompilerGenerated]
		internal  RadioButton GetRB_OverLayer()
		{
			return this.radioButton_2;
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x0025C57C File Offset: 0x0025A77C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_22);
			RadioButton radioButton = this.radioButton_2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_2 = radioButton_21;
			radioButton = this.radioButton_2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x0025C5C8 File Offset: 0x0025A7C8
		[CompilerGenerated]
		internal  RadioButton GetRB_Periscope()
		{
			return this.radioButton_3;
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x0025C5E0 File Offset: 0x0025A7E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_20);
			RadioButton radioButton = this.radioButton_3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_3 = radioButton_21;
			radioButton = this.radioButton_3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x0025C62C File Offset: 0x0025A82C
		[CompilerGenerated]
		internal  RadioButton GetRB_Shallow()
		{
			return this.radioButton_4;
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x0025C644 File Offset: 0x0025A844
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_21);
			RadioButton radioButton = this.radioButton_4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_4 = radioButton_21;
			radioButton = this.radioButton_4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x0025C690 File Offset: 0x0025A890
		[CompilerGenerated]
		internal  GroupBox GetGroupBox_AltitudePresets()
		{
			return this.groupBox_4;
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00027B65 File Offset: 0x00025D65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(GroupBox groupBox_6)
		{
			this.groupBox_4 = groupBox_6;
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x0025C6A8 File Offset: 0x0025A8A8
		[CompilerGenerated]
		internal  RadioButton GetRB_MediumAltitude12000()
		{
			return this.radioButton_5;
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x0025C6C0 File Offset: 0x0025A8C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_30);
			RadioButton radioButton = this.radioButton_5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_5 = radioButton_21;
			radioButton = this.radioButton_5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0025C70C File Offset: 0x0025A90C
		[CompilerGenerated]
		internal  RadioButton GetRB_LowAltitude2000()
		{
			return this.radioButton_6;
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x0025C724 File Offset: 0x0025A924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_31);
			RadioButton radioButton = this.radioButton_6;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_6 = radioButton_21;
			radioButton = this.radioButton_6;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x0025C770 File Offset: 0x0025A970
		[CompilerGenerated]
		internal  RadioButton GetRB_MinAltitude()
		{
			return this.radioButton_7;
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x0025C788 File Offset: 0x0025A988
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_33);
			RadioButton radioButton = this.radioButton_7;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_7 = radioButton_21;
			radioButton = this.radioButton_7;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x0025C7D4 File Offset: 0x0025A9D4
		[CompilerGenerated]
		internal  RadioButton GetRB_LowAltitude1000()
		{
			return this.radioButton_8;
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x0025C7EC File Offset: 0x0025A9EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_32);
			RadioButton radioButton = this.radioButton_8;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_8 = radioButton_21;
			radioButton = this.radioButton_8;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x0025C838 File Offset: 0x0025AA38
		[CompilerGenerated]
		internal  RadioButton GetRB_HighAltitude25000()
		{
			return this.radioButton_9;
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x0025C850 File Offset: 0x0025AA50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_29);
			RadioButton radioButton = this.radioButton_9;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_9 = radioButton_21;
			radioButton = this.radioButton_9;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x0025C89C File Offset: 0x0025AA9C
		[CompilerGenerated]
		internal  RadioButton GetRB_HighAltitude36000()
		{
			return this.radioButton_10;
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x0025C8B4 File Offset: 0x0025AAB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_28);
			RadioButton radioButton = this.radioButton_10;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_10 = radioButton_21;
			radioButton = this.radioButton_10;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x0025C900 File Offset: 0x0025AB00
		[CompilerGenerated]
		internal  RadioButton GetRB_MaxAltitude()
		{
			return this.radioButton_11;
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x0025C918 File Offset: 0x0025AB18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_26);
			RadioButton radioButton = this.radioButton_11;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_11 = radioButton_21;
			radioButton = this.radioButton_11;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x0025C964 File Offset: 0x0025AB64
		[CompilerGenerated]
		internal  RadioButton GetRB_Surface()
		{
			return this.radioButton_12;
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x0025C97C File Offset: 0x0025AB7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_19);
			RadioButton radioButton = this.radioButton_12;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_12 = radioButton_21;
			radioButton = this.radioButton_12;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x0025C9C8 File Offset: 0x0025ABC8
		[CompilerGenerated]
		internal  TextBox vmethod_70()
		{
			return this.textBox_0;
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x0025C9E0 File Offset: 0x0025ABE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(TextBox textBox_3)
		{
			EventHandler value = new EventHandler(this.method_34);
			EventHandler value2 = new EventHandler(this.method_35);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_40);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
				textBox.KeyPress -= value3;
			}
			this.textBox_0 = textBox_3;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
				textBox.KeyPress += value3;
			}
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x0025CA60 File Offset: 0x0025AC60
		[CompilerGenerated]
		internal  Label vmethod_72()
		{
			return this.label_12;
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x00027B6E File Offset: 0x00025D6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Label label_29)
		{
			this.label_12 = label_29;
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x0025CA78 File Offset: 0x0025AC78
		[CompilerGenerated]
		internal  TextBox vmethod_74()
		{
			return this.textBox_1;
		}

		// Token: 0x06005741 RID: 22337 RVA: 0x0025CA90 File Offset: 0x0025AC90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(TextBox textBox_3)
		{
			EventHandler value = new EventHandler(this.method_36);
			EventHandler value2 = new EventHandler(this.method_38);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_41);
			TextBox textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
				textBox.KeyPress -= value3;
			}
			this.textBox_1 = textBox_3;
			textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
				textBox.KeyPress += value3;
			}
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x0025CB10 File Offset: 0x0025AD10
		[CompilerGenerated]
		internal  Label vmethod_76()
		{
			return this.label_13;
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x00027B77 File Offset: 0x00025D77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Label label_29)
		{
			this.label_13 = label_29;
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x0025CB28 File Offset: 0x0025AD28
		[CompilerGenerated]
		internal  RadioButton vmethod_78()
		{
			return this.radioButton_13;
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x0025CB40 File Offset: 0x0025AD40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_10);
			RadioButton radioButton = this.radioButton_13;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_13 = radioButton_21;
			radioButton = this.radioButton_13;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x0025CB8C File Offset: 0x0025AD8C
		[CompilerGenerated]
		internal  RadioButton vmethod_80()
		{
			return this.radioButton_14;
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x0025CBA4 File Offset: 0x0025ADA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_9);
			RadioButton radioButton = this.radioButton_14;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_14 = radioButton_21;
			radioButton = this.radioButton_14;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x0025CBF0 File Offset: 0x0025ADF0
		[CompilerGenerated]
		internal  RadioButton vmethod_82()
		{
			return this.radioButton_15;
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0025CC08 File Offset: 0x0025AE08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_8);
			RadioButton radioButton = this.radioButton_15;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_15 = radioButton_21;
			radioButton = this.radioButton_15;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0025CC54 File Offset: 0x0025AE54
		[CompilerGenerated]
		internal  RadioButton vmethod_84()
		{
			return this.radioButton_16;
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x0025CC6C File Offset: 0x0025AE6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_7);
			RadioButton radioButton = this.radioButton_16;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_16 = radioButton_21;
			radioButton = this.radioButton_16;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x0025CCB8 File Offset: 0x0025AEB8
		[CompilerGenerated]
		internal  RadioButton vmethod_86()
		{
			return this.radioButton_17;
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x0025CCD0 File Offset: 0x0025AED0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_12);
			RadioButton radioButton = this.radioButton_17;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_17 = radioButton_21;
			radioButton = this.radioButton_17;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x0025CD1C File Offset: 0x0025AF1C
		[CompilerGenerated]
		internal  FlowLayoutPanel vmethod_88()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00027B80 File Offset: 0x00025D80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x0025CD34 File Offset: 0x0025AF34
		[CompilerGenerated]
		internal  Label vmethod_90()
		{
			return this.label_14;
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00027B89 File Offset: 0x00025D89
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Label label_29)
		{
			this.label_14 = label_29;
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x0025CD4C File Offset: 0x0025AF4C
		[CompilerGenerated]
		internal  GroupBox vmethod_92()
		{
			return this.groupBox_5;
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x00027B92 File Offset: 0x00025D92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(GroupBox groupBox_6)
		{
			this.groupBox_5 = groupBox_6;
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x0025CD64 File Offset: 0x0025AF64
		[CompilerGenerated]
		internal  Label vmethod_94()
		{
			return this.label_15;
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x00027B9B File Offset: 0x00025D9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Label label_29)
		{
			this.label_15 = label_29;
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x0025CD7C File Offset: 0x0025AF7C
		[CompilerGenerated]
		internal  Label vmethod_96()
		{
			return this.label_16;
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00027BA4 File Offset: 0x00025DA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Label label_29)
		{
			this.label_16 = label_29;
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x0025CD94 File Offset: 0x0025AF94
		[CompilerGenerated]
		internal  Label vmethod_98()
		{
			return this.label_17;
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00027BAD File Offset: 0x00025DAD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Label label_29)
		{
			this.label_17 = label_29;
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x0025CDAC File Offset: 0x0025AFAC
		[CompilerGenerated]
		internal  TextBox vmethod_100()
		{
			return this.textBox_2;
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x0025CDC4 File Offset: 0x0025AFC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(TextBox textBox_3)
		{
			EventHandler value = new EventHandler(this.method_46);
			EventHandler value2 = new EventHandler(this.method_47);
			TextBox textBox = this.textBox_2;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_2 = textBox_3;
			textBox = this.textBox_2;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x0025CE28 File Offset: 0x0025B028
		[CompilerGenerated]
		internal  ComboBox GetCB_WaypointType()
		{
			return this.comboBox_0;
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x0025CE40 File Offset: 0x0025B040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_44);
			EventHandler value2 = new EventHandler(this.method_45);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.DropDown -= value;
				comboBox.SelectionChangeCommitted -= value2;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.DropDown += value;
				comboBox.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x0025CEA4 File Offset: 0x0025B0A4
		[CompilerGenerated]
		internal  Label vmethod_104()
		{
			return this.label_18;
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x00027BB6 File Offset: 0x00025DB6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(Label label_29)
		{
			this.label_18 = label_29;
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x0025CEBC File Offset: 0x0025B0BC
		[CompilerGenerated]
		internal  Label vmethod_106()
		{
			return this.label_19;
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00027BBF File Offset: 0x00025DBF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Label label_29)
		{
			this.label_19 = label_29;
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x0025CED4 File Offset: 0x0025B0D4
		[CompilerGenerated]
		internal  PictureBox vmethod_108()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00027BC8 File Offset: 0x00025DC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(PictureBox pictureBox_8)
		{
			this.pictureBox_0 = pictureBox_8;
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x0025CEEC File Offset: 0x0025B0EC
		[CompilerGenerated]
		internal  PictureBox vmethod_110()
		{
			return this.pictureBox_1;
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x00027BD1 File Offset: 0x00025DD1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(PictureBox pictureBox_8)
		{
			this.pictureBox_1 = pictureBox_8;
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x0025CF04 File Offset: 0x0025B104
		[CompilerGenerated]
		internal  PictureBox vmethod_112()
		{
			return this.pictureBox_2;
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00027BDA File Offset: 0x00025DDA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(PictureBox pictureBox_8)
		{
			this.pictureBox_2 = pictureBox_8;
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x0025CF1C File Offset: 0x0025B11C
		[CompilerGenerated]
		internal  PictureBox vmethod_114()
		{
			return this.pictureBox_3;
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x00027BE3 File Offset: 0x00025DE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(PictureBox pictureBox_8)
		{
			this.pictureBox_3 = pictureBox_8;
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x0025CF34 File Offset: 0x0025B134
		[CompilerGenerated]
		internal  PictureBox vmethod_116()
		{
			return this.pictureBox_4;
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x00027BEC File Offset: 0x00025DEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(PictureBox pictureBox_8)
		{
			this.pictureBox_4 = pictureBox_8;
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x0025CF4C File Offset: 0x0025B14C
		[CompilerGenerated]
		internal  Label vmethod_118()
		{
			return this.label_20;
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x00027BF5 File Offset: 0x00025DF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(Label label_29)
		{
			this.label_20 = label_29;
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x0025CF64 File Offset: 0x0025B164
		[CompilerGenerated]
		internal  Label vmethod_120()
		{
			return this.label_21;
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x00027BFE File Offset: 0x00025DFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(Label label_29)
		{
			this.label_21 = label_29;
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x0025CF7C File Offset: 0x0025B17C
		[CompilerGenerated]
		internal  Label vmethod_122()
		{
			return this.label_22;
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00027C07 File Offset: 0x00025E07
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(Label label_29)
		{
			this.label_22 = label_29;
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x0025CF94 File Offset: 0x0025B194
		[CompilerGenerated]
		internal  Label vmethod_124()
		{
			return this.label_23;
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x00027C10 File Offset: 0x00025E10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(Label label_29)
		{
			this.label_23 = label_29;
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x0025CFAC File Offset: 0x0025B1AC
		[CompilerGenerated]
		internal  PictureBox vmethod_126()
		{
			return this.pictureBox_5;
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00027C19 File Offset: 0x00025E19
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(PictureBox pictureBox_8)
		{
			this.pictureBox_5 = pictureBox_8;
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x0025CFC4 File Offset: 0x0025B1C4
		[CompilerGenerated]
		internal  PictureBox vmethod_128()
		{
			return this.pictureBox_6;
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00027C22 File Offset: 0x00025E22
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(PictureBox pictureBox_8)
		{
			this.pictureBox_6 = pictureBox_8;
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x0025CFDC File Offset: 0x0025B1DC
		[CompilerGenerated]
		internal  PictureBox vmethod_130()
		{
			return this.pictureBox_7;
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00027C2B File Offset: 0x00025E2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(PictureBox pictureBox_8)
		{
			this.pictureBox_7 = pictureBox_8;
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x0025CFF4 File Offset: 0x0025B1F4
		[CompilerGenerated]
		internal  Label vmethod_132()
		{
			return this.label_24;
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x00027C34 File Offset: 0x00025E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Label label_29)
		{
			this.label_24 = label_29;
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x0025D00C File Offset: 0x0025B20C
		[CompilerGenerated]
		internal  Label vmethod_134()
		{
			return this.label_25;
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x00027C3D File Offset: 0x00025E3D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Label label_29)
		{
			this.label_25 = label_29;
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x0025D024 File Offset: 0x0025B224
		[CompilerGenerated]
		internal  Label vmethod_136()
		{
			return this.label_26;
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00027C46 File Offset: 0x00025E46
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(Label label_29)
		{
			this.label_26 = label_29;
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x0025D03C File Offset: 0x0025B23C
		[CompilerGenerated]
		internal  Label vmethod_138()
		{
			return this.label_27;
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x00027C4F File Offset: 0x00025E4F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(Label label_29)
		{
			this.label_27 = label_29;
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x0025D054 File Offset: 0x0025B254
		[CompilerGenerated]
		internal  Label vmethod_140()
		{
			return this.label_28;
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00027C58 File Offset: 0x00025E58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Label label_29)
		{
			this.label_28 = label_29;
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x0025D06C File Offset: 0x0025B26C
		[CompilerGenerated]
		internal  CheckBox vmethod_142()
		{
			return this.checkBox_2;
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x0025D084 File Offset: 0x0025B284
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_50);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_2 = checkBox_3;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x0025D0D0 File Offset: 0x0025B2D0
		[CompilerGenerated]
		internal  ShapeContainer vmethod_144()
		{
			return this.shapeContainer_0;
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x00027C61 File Offset: 0x00025E61
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_145(ShapeContainer shapeContainer_1)
		{
			this.shapeContainer_0 = shapeContainer_1;
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x0025D0E8 File Offset: 0x0025B2E8
		[CompilerGenerated]
		internal  LineShape vmethod_146()
		{
			return this.lineShape_0;
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x00027C6A File Offset: 0x00025E6A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_147(LineShape lineShape_2)
		{
			this.lineShape_0 = lineShape_2;
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x0025D100 File Offset: 0x0025B300
		[CompilerGenerated]
		internal  LineShape vmethod_148()
		{
			return this.lineShape_1;
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x00027C73 File Offset: 0x00025E73
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_149(LineShape lineShape_2)
		{
			this.lineShape_1 = lineShape_2;
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x0025D118 File Offset: 0x0025B318
		[CompilerGenerated]
		internal  RadioButton vmethod_150()
		{
			return this.radioButton_18;
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x0025D130 File Offset: 0x0025B330
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_151(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_11);
			RadioButton radioButton = this.radioButton_18;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_18 = radioButton_21;
			radioButton = this.radioButton_18;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x0025D17C File Offset: 0x0025B37C
		[CompilerGenerated]
		internal  RadioButton GetRB_NoAltitudePreset()
		{
			return this.radioButton_19;
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x0025D194 File Offset: 0x0025B394
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_153(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_27);
			RadioButton radioButton = this.radioButton_19;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_19 = radioButton_21;
			radioButton = this.radioButton_19;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x0025D1E0 File Offset: 0x0025B3E0
		[CompilerGenerated]
		internal  RadioButton GetRB_NoDepthPreset()
		{
			return this.radioButton_20;
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x0025D1F8 File Offset: 0x0025B3F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_155(RadioButton radioButton_21)
		{
			EventHandler value = new EventHandler(this.method_25);
			RadioButton radioButton = this.radioButton_20;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_20 = radioButton_21;
			radioButton = this.radioButton_20;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00027C7C File Offset: 0x00025E7C
		private void SpeedAlt_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_1();
			this.vmethod_14().Interval = 250;
			this.vmethod_14().Start();
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x0025D244 File Offset: 0x0025B444
		public void method_1()
		{
			this.method_3();
			this.bool_2 = false;
			if (SimConfiguration.gameOptions.UseImperialUnit())
			{
				this.vmethod_76().Text = "英尺";
			}
			else
			{
				this.vmethod_76().Text = "米";
				this.GetRB_HighAltitude36000().Text = "高空(10973米)";
				this.GetRB_HighAltitude25000().Text = "高空(7620 米)";
				this.GetRB_MediumAltitude12000().Text = "中空(3658 米)";
				this.GetRB_LowAltitude2000().Text = "低空(610 米)";
				this.GetRB_LowAltitude1000().Text = "低空(305 米)";
			}
			if (!Information.IsNothing(this.HookedUnit))
			{
				if (!this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
				{
					this.vmethod_84().Text = "停车";
					this.vmethod_82().Text = "低速";
					this.vmethod_78().Text = "全速";
					this.vmethod_86().Text = "最大";
				}
				else
				{
					this.vmethod_84().Text = "悬停";
					this.vmethod_82().Text = "低速";
					this.vmethod_78().Text = "军用";
					this.vmethod_86().Text = "加力";
				}
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				this.vmethod_84().Text = "悬停";
				this.vmethod_82().Text = "低速";
				this.vmethod_78().Text = "军用";
				this.vmethod_86().Text = "加力";
			}
			this.vmethod_76().Visible = false;
			this.vmethod_74().Visible = false;
			this.GetCB_AltOverride().Visible = false;
			this.vmethod_18().Visible = false;
			this.vmethod_20().Visible = false;
			this.vmethod_26().Visible = false;
			this.vmethod_28().Visible = false;
			this.vmethod_10().Visible = true;
			this.vmethod_12().Visible = true;
			this.GetRB_HighAltitude36000().Enabled = true;
			this.GetRB_HighAltitude25000().Enabled = true;
			this.GetRB_MediumAltitude12000().Enabled = true;
			this.GetRB_LowAltitude2000().Enabled = true;
			this.GetRB_LowAltitude1000().Enabled = true;
			this.GetRB_Periscope().Enabled = true;
			this.GetRB_Shallow().Enabled = true;
			this.GetRB_OverLayer().Enabled = true;
			this.GetRB_UnderLayer().Enabled = true;
			this.vmethod_84().Enabled = true;
			this.vmethod_142().Enabled = true;
			this.GetCB_WaypointType().Enabled = false;
			this.vmethod_100().Enabled = false;
			float num = 0f;
			float num2 = 0f;
			if (!Information.IsNothing(this.HookedUnit))
			{
				num = this.HookedUnit.GetKinematics().GetMaxAltitude();
				num2 = this.HookedUnit.GetKinematics().GetMinAltitude();
			}
			this.vmethod_16().Maximum = (int)Math.Round((double)num);
			this.vmethod_16().Minimum = (int)Math.Round((double)num2);
			if (!Information.IsNothing(this.HookedUnit))
			{
				if (!this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
				{
					if (this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
					{
						if (num2 > -20f)
						{
							this.GetRB_Periscope().Enabled = false;
						}
						if (num2 > -40f)
						{
							this.GetRB_Shallow().Enabled = false;
						}
						if ((num2 > Submarine_AI.GetJustOverLayerDepth(this.HookedUnit) && this.HookedUnit.IsSubmarine) | (num2 > Group_AI.smethod_2(this.HookedUnit) && this.HookedUnit.IsGroup))
						{
							this.GetRB_OverLayer().Enabled = false;
						}
						if ((num2 > Submarine_AI.GetJustUnderLayerDepth(this.HookedUnit) && this.HookedUnit.IsSubmarine) | (num2 > Group_AI.smethod_3(this.HookedUnit) && this.HookedUnit.IsGroup))
						{
							this.GetRB_UnderLayer().Enabled = false;
						}
					}
				}
				else
				{
					if (num * 3.28084f < 36000f)
					{
						this.GetRB_HighAltitude36000().Enabled = false;
					}
					if (num * 3.28084f < 25000f)
					{
						this.GetRB_HighAltitude25000().Enabled = false;
					}
					if (num * 3.28084f < 12000f)
					{
						this.GetRB_MediumAltitude12000().Enabled = false;
					}
					if (num * 3.28084f < 2000f)
					{
						this.GetRB_LowAltitude2000().Enabled = false;
					}
					if (num * 3.28084f < 1000f)
					{
						this.GetRB_LowAltitude1000().Enabled = false;
					}
				}
			}
			if (Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
			{
				if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						this.GetGroupBox_SubDepthPreset().Visible = true;
					}
					else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)
					{
						this.GetGroupBox_SubDepthPreset().Visible = true;
					}
					else
					{
						this.GetGroupBox_SubDepthPreset().Visible = false;
					}
					if (this.HookedUnit.IsAircraft)
					{
						this.GetGroupBox_AltitudePresets().Visible = true;
						this.vmethod_142().Enabled = true;
					}
					else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
					{
						this.GetGroupBox_AltitudePresets().Visible = true;
						this.vmethod_142().Enabled = true;
					}
					else
					{
						this.GetGroupBox_AltitudePresets().Visible = false;
						this.vmethod_142().Enabled = false;
					}
					if (this.HookedUnit.IsFacility)
					{
						if (this.HookedUnit.GetDesiredSpeed() > (float)this.vmethod_0().Maximum)
						{
							this.vmethod_0().Value = this.vmethod_0().Maximum;
						}
						else
						{
							this.vmethod_0().Value = (int)Math.Round((double)this.HookedUnit.GetDesiredSpeed());
						}
					}
					else if (this.HookedUnit.IsSubmarine || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup) || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
					{
						this.vmethod_76().Visible = true;
						this.vmethod_74().Visible = true;
						this.vmethod_26().Visible = true;
						this.vmethod_28().Visible = true;
						this.GetCB_AltOverride().Visible = true;
						this.vmethod_18().Visible = true;
						this.vmethod_20().Visible = true;
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							this.vmethod_22().Text = Conversions.ToString((int)Math.Round((double)(num * 3.28084f))) + "英尺";
							this.vmethod_24().Text = Conversions.ToString((int)Math.Round((double)(num2 * 3.28084f))) + "英尺";
						}
						else
						{
							this.vmethod_22().Text = Conversions.ToString(num) + "米";
							this.vmethod_24().Text = Conversions.ToString(num2) + "米";
						}
					}
					this.vmethod_150().Visible = false;
					this.GetRB_NoDepthPreset().Visible = false;
					this.GetRB_NoAltitudePreset().Visible = false;
					if (this.HookedUnit.IsWeapon && ((Weapon)this.HookedUnit).weaponCode.TerrainFollowing)
					{
						this.vmethod_142().Enabled = true;
					}
				}
			}
			else
			{
				this.GetRB_Surface().Checked = false;
				this.GetRB_Periscope().Checked = false;
				this.GetRB_Shallow().Checked = false;
				this.GetRB_OverLayer().Checked = false;
				this.GetRB_UnderLayer().Checked = false;
				this.GetRB_MaxDepth().Checked = false;
				this.GetRB_MaxAltitude().Checked = false;
				this.GetRB_HighAltitude36000().Checked = false;
				this.GetRB_HighAltitude25000().Checked = false;
				this.GetRB_MediumAltitude12000().Checked = false;
				this.GetRB_LowAltitude2000().Checked = false;
				this.GetRB_LowAltitude1000().Checked = false;
				this.GetRB_MinAltitude().Checked = false;
				this.vmethod_84().Checked = false;
				this.vmethod_82().Checked = false;
				this.vmethod_80().Checked = false;
				this.vmethod_78().Checked = false;
				this.vmethod_86().Checked = false;
				this.vmethod_150().Checked = false;
				this.GetRB_NoDepthPreset().Checked = false;
				this.GetRB_NoAltitudePreset().Checked = false;
				if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsFacility)
					{
						this.vmethod_76().Visible = false;
						this.vmethod_74().Visible = false;
					}
					else if (!this.HookedUnit.IsSubmarine && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
					{
						this.vmethod_76().Visible = false;
						this.vmethod_74().Visible = false;
					}
					else
					{
						this.vmethod_76().Visible = true;
						this.vmethod_74().Visible = true;
					}
				}
				this.GetCB_WaypointType().Enabled = true;
				this.vmethod_100().Enabled = true;
				Waypoint wayPointSelected;
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					wayPointSelected = Client.GetWayPointSelected();
				}
				else
				{
					wayPointSelected = this.waypoint_0;
				}
				switch (wayPointSelected.GetThrottlePreset())
				{
				case ActiveUnit_Kinematics._SpeedPreset.FullStop:
					this.vmethod_84().Checked = true;
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Loiter:
					this.vmethod_82().Checked = true;
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Cruise:
					this.vmethod_80().Checked = true;
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Full:
					this.vmethod_78().Checked = true;
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Flank:
					this.vmethod_86().Checked = true;
					break;
				}
				switch (wayPointSelected.GetAltitudePreset())
				{
				case ActiveUnit_AI._AltitudePreset.MinAltitude:
					this.GetRB_MinAltitude().Checked = true;
					break;
				case ActiveUnit_AI._AltitudePreset.LowAltitude1000:
					this.GetRB_LowAltitude1000().Checked = true;
					break;
				case ActiveUnit_AI._AltitudePreset.LowAltitude2000:
					this.GetRB_LowAltitude2000().Checked = true;
					break;
				case ActiveUnit_AI._AltitudePreset.MediumAltitude12000:
					this.GetRB_MediumAltitude12000().Checked = true;
					break;
				case ActiveUnit_AI._AltitudePreset.HighAltitude25000:
					this.GetRB_HighAltitude25000().Checked = true;
					break;
				case ActiveUnit_AI._AltitudePreset.HighAltitude36000:
					this.GetRB_HighAltitude36000().Checked = true;
					break;
				case ActiveUnit_AI._AltitudePreset.MaxAltitude:
					this.GetRB_MaxAltitude().Checked = true;
					break;
				}
				switch (wayPointSelected.GetDepthPreset())
				{
				case ActiveUnit_AI._DepthPreset.Periscope:
					this.GetRB_Periscope().Checked = true;
					break;
				case ActiveUnit_AI._DepthPreset.Shallow:
					this.GetRB_Shallow().Checked = true;
					break;
				case ActiveUnit_AI._DepthPreset.OverLayer:
					this.GetRB_OverLayer().Checked = true;
					break;
				case ActiveUnit_AI._DepthPreset.UnderLayer:
					this.GetRB_UnderLayer().Checked = true;
					break;
				case ActiveUnit_AI._DepthPreset.MaxDepth:
					this.GetRB_MaxDepth().Checked = true;
					break;
				case ActiveUnit_AI._DepthPreset.Surface:
					this.GetRB_Surface().Checked = true;
					break;
				}
				if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup) || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
					{
						this.vmethod_20().Visible = true;
						this.vmethod_26().Visible = true;
						this.vmethod_28().Visible = true;
						this.vmethod_76().Visible = true;
						this.vmethod_74().Visible = true;
						this.GetCB_AltOverride().Visible = true;
						this.vmethod_18().Visible = true;
						this.vmethod_20().Visible = true;
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.vmethod_20().Visible = true;
					this.vmethod_26().Visible = true;
					this.vmethod_76().Visible = true;
					this.vmethod_74().Visible = true;
					this.GetCB_AltOverride().Visible = true;
					this.vmethod_20().Visible = true;
					this.vmethod_10().Visible = false;
					this.vmethod_12().Visible = false;
				}
				if (Information.IsNothing(wayPointSelected.GetDSO()))
				{
					if (wayPointSelected.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
					{
						this.vmethod_150().Visible = true;
					}
					else
					{
						this.vmethod_150().Visible = false;
					}
				}
				else
				{
					this.vmethod_150().Visible = false;
				}
				this.GetRB_NoDepthPreset().Visible = false;
				this.GetRB_NoAltitudePreset().Visible = false;
				if (!Information.IsNothing(this.HookedUnit))
				{
					if (!this.HookedUnit.IsSubmarine && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.SubGroup))
					{
						this.GetGroupBox_SubDepthPreset().Visible = false;
					}
					else
					{
						this.GetGroupBox_SubDepthPreset().Visible = true;
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.GetGroupBox_SubDepthPreset().Visible = false;
				}
				if (!Information.IsNothing(this.HookedUnit))
				{
					if (!this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
					{
						this.GetGroupBox_AltitudePresets().Visible = false;
					}
					else
					{
						this.GetGroupBox_AltitudePresets().Visible = true;
						if (this.HookedUnit.IsAircraft && !((Aircraft)this.HookedUnit).IsRotaryWing(false))
						{
							this.vmethod_84().Enabled = false;
						}
						if (this.HookedUnit.IsGroup)
						{
							if (Information.IsNothing(((Group)this.HookedUnit).GetGroupLead()))
							{
								return;
							}
							if (!((Aircraft)((Group)this.HookedUnit).GetGroupLead()).IsRotaryWing(false))
							{
								this.vmethod_84().Enabled = false;
							}
						}
						this.vmethod_142().Enabled = true;
					}
				}
				if (!Information.IsNothing(this.HookedUnit) && this.HookedUnit.IsWeapon)
				{
					this.vmethod_84().Enabled = false;
					this.vmethod_82().Enabled = false;
					if (((Weapon)this.HookedUnit).weaponCode.TerrainFollowing)
					{
						this.vmethod_142().Enabled = true;
					}
				}
			}
			Client.smethod_17(new Client.Delegate52(this.method_2));
			Client.smethod_19(new Client.Delegate53(this.method_2));
			this.bool_2 = true;
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x0025E17C File Offset: 0x0025C37C
		private void method_2()
		{
			if (base.Visible)
			{
				try
				{
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						this.method_49();
						if (this.bool_0)
						{
							this.bool_0 = false;
						}
					}
					else if (!Information.IsNothing(this.HookedUnit) && this.HookedUnit.IsActiveUnit())
					{
						this.method_49();
						if (this.bool_0)
						{
							this.bool_0 = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200636", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x0025E258 File Offset: 0x0025C458
		private void method_3()
		{
			this.bool_2 = false;
			try
			{
				if (!(Information.IsNothing(this.HookedUnit) & Information.IsNothing(Client.GetWayPointSelected()) & Information.IsNothing(this.waypoint_0)) && (Information.IsNothing(this.HookedUnit) || !this.HookedUnit.IsGroup || !Information.IsNothing(((Group)this.HookedUnit).GetGroupLead())))
				{
					if (Information.IsNothing(this.waypoint_0) && (this.HookedUnit.IsShip || this.HookedUnit.IsSubmarine))
					{
						this.vmethod_140().Visible = true;
						int num = this.HookedUnit.GetKinematics().method_8(this.HookedUnit.GetCurrentAltitude_ASL(false));
						if (num == 2147483647)
						{
							this.vmethod_140().Font = new Font(this.vmethod_140().Font, FontStyle.Regular);
							this.vmethod_140().ForeColor = Color.Black;
							this.vmethod_140().Text = "不会发生空泡现象";
						}
						else if (this.HookedUnit.GetCurrentSpeed() >= (float)num)
						{
							this.vmethod_140().Font = new Font(this.vmethod_140().Font, FontStyle.Bold);
							this.vmethod_140().ForeColor = Color.Red;
							this.vmethod_140().Text = "空泡!!! (" + Conversions.ToString(num) + "节)";
						}
						else
						{
							this.vmethod_140().Font = new Font(this.vmethod_140().Font, FontStyle.Regular);
							this.vmethod_140().ForeColor = Color.Black;
							this.vmethod_140().Text = "空泡发生于" + Conversions.ToString(num) + " 节";
						}
					}
					else
					{
						this.vmethod_140().Visible = false;
					}
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						if (Operators.CompareString(Client.GetWayPointSelected().Name, "", false) == 0)
						{
							this.Text = "导航航路点：油门与高度设置";
						}
						else
						{
							this.Text = "油门与高度设置: " + Client.GetWayPointSelected().Name;
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.Text = string.Concat(new string[]
						{
							"油门与高度设置: ",
							this.waypoint_0.Name,
							" (类型: ",
							Waypoint.GetWaypointTypeString(this.waypoint_0.waypointType),
							")"
						});
					}
					else if (!Information.IsNothing(this.HookedUnit) && this.HookedUnit.IsActiveUnit())
					{
						this.Text = "油门与高度设置: " + this.HookedUnit.Name;
					}
					if (!Information.IsNothing(this.HookedUnit))
					{
						this.vmethod_86().Enabled = (this.HookedUnit.GetMaxThrottleAvailable() == ActiveUnit.Throttle.Flank);
						this.vmethod_78().Enabled = (this.HookedUnit.GetMaxThrottleAvailable() >= ActiveUnit.Throttle.Full);
					}
					if (Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						if (!this.vmethod_0().Visible)
						{
							this.vmethod_0().Visible = true;
							this.vmethod_4().Visible = true;
							this.vmethod_2().Visible = true;
						}
						if (!this.HookedUnit.IsSubmarine && !this.HookedUnit.IsTorpedo() && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup) && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.SubGroup))
						{
							if (this.vmethod_16().Visible)
							{
								this.vmethod_16().Visible = false;
								this.vmethod_22().Visible = false;
								this.vmethod_24().Visible = false;
							}
						}
						else if (!this.vmethod_16().Visible)
						{
							this.vmethod_16().Visible = true;
							this.vmethod_22().Visible = true;
							this.vmethod_24().Visible = true;
						}
					}
					else
					{
						if (this.vmethod_0().Visible)
						{
							this.vmethod_0().Visible = false;
							this.vmethod_4().Visible = false;
							this.vmethod_2().Visible = false;
						}
						if (this.vmethod_16().Visible)
						{
							this.vmethod_16().Visible = false;
							this.vmethod_22().Visible = false;
							this.vmethod_24().Visible = false;
						}
					}
					double num2 = 0.0;
					float num3 = 0f;
					float num4 = 0f;
					float num5 = 0f;
					float num6 = 0f;
					float num7 = 0f;
					float num8 = 0f;
					if (!Information.IsNothing(this.HookedUnit))
					{
						num7 = this.HookedUnit.GetKinematics().GetMaxAltitude();
						num8 = this.HookedUnit.GetKinematics().GetMinAltitude();
					}
					if (Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						if (!Information.IsNothing(this.HookedUnit))
						{
							if (this.HookedUnit.IsGroup)
							{
								this.vmethod_8().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetDesiredSpeed(), 0)) + "节";
								this.vmethod_12().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentSpeed(), 1)) + "节";
							}
							else
							{
								this.vmethod_8().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetDesiredSpeed(), 0)) + "节";
								this.vmethod_12().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentSpeed(), 1)) + "节(油门: " + this.GetThrottleString() + ")";
							}
							if (!this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									this.vmethod_26().Text = Conversions.ToString(Math.Round((double)(this.HookedUnit.GetDesiredAltitude() * 3.28084f), 0)) + "英尺";
									this.vmethod_28().Text = Conversions.ToString(Math.Round((double)(this.HookedUnit.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺";
								}
								else
								{
									this.vmethod_26().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetDesiredAltitude(), 0)) + "米";
									this.vmethod_28().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentAltitude_ASL(false), 0)) + "米";
								}
							}
							else
							{
								bool flag;
								float desiredAltitude_TerrainFollowing;
								if (this.HookedUnit.IsNotGroupLead() && !Information.IsNothing(this.HookedUnit.GetParentGroup(false).GetGroupLead()) && !this.HookedUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									flag = this.HookedUnit.GetParentGroup(false).GetGroupLead().IsTerrainFollowing(this.HookedUnit.GetParentGroup(false).GetGroupLead());
									desiredAltitude_TerrainFollowing = this.HookedUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing();
								}
								else
								{
									flag = this.HookedUnit.IsTerrainFollowing(this.HookedUnit);
									desiredAltitude_TerrainFollowing = this.HookedUnit.GetDesiredAltitude_TerrainFollowing();
								}
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (flag)
									{
										this.vmethod_26().Text = Conversions.ToString(Math.Round((double)(desiredAltitude_TerrainFollowing * 3.28084f), 0)) + "英尺(真高)";
									}
									else
									{
										this.vmethod_26().Text = Conversions.ToString(Math.Round((double)(this.HookedUnit.GetDesiredAltitude() * 3.28084f), 0)) + "英尺（海高）";
									}
									if (this.HookedUnit.IsOnLand())
									{
										this.vmethod_28().Text = Conversions.ToString(Math.Round((double)(this.HookedUnit.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺（海高）(" + Conversions.ToString(Math.Round((double)(this.HookedUnit.GetAltitude_AGL() * 3.28084f), 0)) + "英尺(真高))";
									}
									else
									{
										this.vmethod_28().Text = Conversions.ToString(Math.Round((double)(this.HookedUnit.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺（海高）";
									}
								}
								else
								{
									if (flag)
									{
										this.vmethod_26().Text = Conversions.ToString(Math.Round((double)desiredAltitude_TerrainFollowing, 0)) + "米(真高)";
									}
									else
									{
										this.vmethod_26().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetDesiredAltitude(), 0)) + "米(海高)";
									}
									if (this.HookedUnit.IsOnLand())
									{
										this.vmethod_28().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentAltitude_ASL(false), 0)) + "米(海拔)(" + Conversions.ToString(Math.Round((double)this.HookedUnit.GetAltitude_AGL(), 0)) + "米(真高))";
									}
									else
									{
										this.vmethod_28().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentAltitude_ASL(false), 0)) + "米(海拔)";
									}
								}
							}
							if (this.HookedUnit.IsGroup)
							{
								Group group = (Group)this.HookedUnit;
								if (!Information.IsNothing(group.GetGroupLead()))
								{
									this.vmethod_142().Checked = group.GetGroupLead().IsTerrainFollowing(group.GetGroupLead());
								}
							}
							else
							{
								this.vmethod_142().Checked = this.HookedUnit.IsTerrainFollowing(this.HookedUnit);
							}
							if (!this.bool_0)
							{
								bool flag2;
								float desiredAltitude_TerrainFollowing2;
								if (this.HookedUnit.IsNotGroupLead() && !Information.IsNothing(this.HookedUnit.GetParentGroup(false).GetGroupLead()) && !this.HookedUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									flag2 = this.HookedUnit.GetParentGroup(false).GetGroupLead().IsTerrainFollowing(this.HookedUnit.GetParentGroup(false).GetGroupLead());
									desiredAltitude_TerrainFollowing2 = this.HookedUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing();
								}
								else
								{
									flag2 = this.HookedUnit.IsTerrainFollowing(this.HookedUnit);
									desiredAltitude_TerrainFollowing2 = this.HookedUnit.GetDesiredAltitude_TerrainFollowing();
								}
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (this.HookedUnit.IsGroup && (((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup | ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
									{
										if (flag2)
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(desiredAltitude_TerrainFollowing2 * 3.28084f)));
										}
										else
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(this.HookedUnit.GetDesiredAltitude() * 3.28084f)));
										}
									}
									else if (this.HookedUnit.IsAircraft | this.HookedUnit.IsSubmarine)
									{
										if (flag2)
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(desiredAltitude_TerrainFollowing2 * 3.28084f)));
										}
										else
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(this.HookedUnit.GetDesiredAltitude() * 3.28084f)));
										}
									}
								}
								else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
								{
									if (this.HookedUnit.IsTerrainFollowing(this.HookedUnit))
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)this.HookedUnit.GetDesiredAltitude_TerrainFollowing()));
									}
									else
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)this.HookedUnit.GetDesiredAltitude()));
									}
								}
								else if (this.HookedUnit.IsAircraft | this.HookedUnit.IsSubmarine)
								{
									if (this.HookedUnit.IsTerrainFollowing(this.HookedUnit))
									{
										this.vmethod_74().Text = Conversions.ToString(this.HookedUnit.GetDesiredAltitude_TerrainFollowing());
									}
									else
									{
										this.vmethod_74().Text = Conversions.ToString(this.HookedUnit.GetDesiredAltitude());
									}
								}
								this.vmethod_70().Text = Conversions.ToString(this.HookedUnit.GetDesiredSpeed());
							}
							if (this.HookedUnit.IsGroup)
							{
								if (Information.IsNothing(((Group)this.HookedUnit).GetGroupLead()))
								{
									return;
								}
								this.vmethod_38().Checked = this.HookedUnit.GetKinematics().GetDesiredSpeedOverride().HasValue;
								this.GetCB_AltOverride().Checked = this.HookedUnit.GetKinematics().GetDesiredAltitudeOverride();
							}
							else
							{
								this.vmethod_38().Checked = this.HookedUnit.GetKinematics().GetDesiredSpeedOverride().HasValue;
								this.GetCB_AltOverride().Checked = this.HookedUnit.GetKinematics().GetDesiredAltitudeOverride();
							}
							this.vmethod_2().Text = this.vmethod_0().Minimum.ToString() + "节";
							this.vmethod_4().Text = this.vmethod_0().Maximum.ToString() + "节";
							if (this.HookedUnit.GetDesiredSpeed() > (float)this.vmethod_0().Maximum)
							{
								this.vmethod_0().Value = this.vmethod_0().Maximum;
							}
							else if (this.HookedUnit.GetDesiredSpeed() < (float)this.vmethod_0().Minimum)
							{
								this.vmethod_0().Value = this.vmethod_0().Minimum;
							}
							else
							{
								this.vmethod_0().Value = (int)Math.Round((double)this.HookedUnit.GetDesiredSpeed());
							}
							if (this.HookedUnit.GetDesiredAltitude() > (float)this.vmethod_16().Maximum)
							{
								this.vmethod_16().Value = this.vmethod_16().Maximum;
							}
							else if (this.HookedUnit.GetDesiredAltitude() < (float)this.vmethod_16().Minimum)
							{
								this.vmethod_16().Value = this.vmethod_16().Minimum;
							}
							else
							{
								this.vmethod_16().Value = (int)Math.Round((double)this.HookedUnit.GetDesiredAltitude());
							}
							bool flag3 = false;
							if (this.HookedUnit.IsAircraft | this.HookedUnit.IsShip | this.HookedUnit.IsSubmarine)
							{
								flag3 = true;
							}
							if (this.HookedUnit.IsGroup && (((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup | ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SurfaceGroup | ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
							{
								flag3 = true;
							}
							if (flag3 && this.HookedUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0)
							{
								try
								{
									if (this.HookedUnit.GetCurrentSpeed() > 0f && this.HookedUnit.GetDesiredSpeed() > 0f)
									{
										num2 = (double)this.HookedUnit.HorizontalRangeTo(this.HookedUnit.GetNavigator().GetPlottedCourse()[0]);
										num3 = (float)(num2 / (double)this.HookedUnit.GetCurrentSpeed() * 3600.0);
										num4 = (float)(num2 / (double)this.HookedUnit.GetDesiredSpeed() * 3600.0);
										ActiveUnit activeUnit;
										if (this.HookedUnit.IsGroup)
										{
											activeUnit = ((Group)this.HookedUnit).GetGroupLead();
										}
										else
										{
											activeUnit = this.HookedUnit;
										}
										num5 = num3 * activeUnit.GetFuelConsumption(activeUnit.GetKinematics().vmethod_38(activeUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)activeUnit.GetCurrentSpeed()))), null, new float?((float)((int)Math.Round((double)activeUnit.GetCurrentSpeed()))), new float?(activeUnit.GetCurrentAltitude_ASL(false)), false, false, false, false);
										num6 = num4 * activeUnit.GetFuelConsumption(activeUnit.GetThrottle(), null, new float?((float)((int)Math.Round((double)activeUnit.GetDesiredSpeed()))), new float?(activeUnit.GetDesiredAltitude()), false, false, false, false);
										this.vmethod_96().Text = "剩余航行距离: " + Conversions.ToString(Math.Round(num2, 1)) + "海里";
										if ((int)Math.Round((double)num4) != (int)Math.Round((double)num3))
										{
											this.vmethod_94().Text = string.Concat(new string[]
											{
												"剩余航行时间: ",
												Misc.GetTimeString((long)Math.Round((double)num3), Aircraft_AirOps._Maintenance.const_0, false, false),
												" (当前), ",
												Misc.GetTimeString((long)Math.Round((double)num4), Aircraft_AirOps._Maintenance.const_0, false, false),
												" (期望) "
											});
											this.vmethod_98().Text = string.Concat(new string[]
											{
												"需要燃油数: ",
												Conversions.ToString(Math.Round((double)num5, 1)),
												"公斤(当前), ",
												Conversions.ToString(Math.Round((double)num6, 1)),
												"公斤(期望) "
											});
										}
										else
										{
											this.vmethod_94().Text = "剩余航行时间: " + Misc.GetTimeString((long)Math.Round((double)num4), Aircraft_AirOps._Maintenance.const_0, false, false);
											this.vmethod_98().Text = "需要燃油数: " + Conversions.ToString(Math.Round((double)num6, 1)) + "公斤";
										}
										if (Operators.CompareString(this.HookedUnit.GetNavigator().GetPlottedCourse()[0].Name, "", false) == 0)
										{
											this.vmethod_90().Text = "下一航路点: 导航航路点 ";
										}
										else
										{
											this.vmethod_90().Text = "下一航路点: " + this.HookedUnit.GetNavigator().GetPlottedCourse()[0].Name;
										}
									}
									else
									{
										this.vmethod_90().Text = "至少一个速度指令为0节, 不能估计剩余航行距离/时间/燃油量";
										this.vmethod_96().Text = "";
										this.vmethod_94().Text = "";
										this.vmethod_98().Text = "";
									}
									this.vmethod_100().Text = this.HookedUnit.GetNavigator().GetPlottedCourse()[0].Description;
									Waypoint.WaypointType waypointType = this.HookedUnit.GetNavigator().GetPlottedCourse()[0].waypointType;
									if (waypointType <= Waypoint.WaypointType.Assemble)
									{
										if (waypointType != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
										{
											if (waypointType == Waypoint.WaypointType.Assemble)
											{
												this.GetCB_WaypointType().SelectedIndex = 0;
											}
										}
										else
										{
											this.GetCB_WaypointType().SelectedIndex = 1;
										}
									}
									else if (waypointType == Waypoint.WaypointType.Target || waypointType == Waypoint.WaypointType.WeaponTarget)
									{
										this.GetCB_WaypointType().SelectedIndex = 2;
									}
									goto IL_13F7;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200414", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
									goto IL_13F7;
								}
							}
							this.vmethod_90().Text = "";
							this.vmethod_96().Text = "";
							this.vmethod_94().Text = "";
							this.vmethod_98().Text = "";
							this.vmethod_100().Text = "";
							this.GetCB_WaypointType().SelectedIndex = -1;
							IL_13F7:
							this.vmethod_0().Maximum = Math.Max(this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), this.HookedUnit.GetMaxThrottleAvailable()), this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetDesiredAltitude()));
							this.vmethod_16().Maximum = (int)Math.Round((double)num7);
							this.vmethod_16().Minimum = (int)Math.Round((double)num8);
							if (this.HookedUnit.IsAircraft)
							{
								if (!((Aircraft)this.HookedUnit).IsRotaryWing(false))
								{
									this.vmethod_0().Minimum = ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter);
									this.vmethod_84().Enabled = false;
								}
								this.vmethod_80().Enabled = true;
								this.vmethod_82().Enabled = true;
							}
							else if (this.HookedUnit.IsShip)
							{
								this.vmethod_0().Minimum = 0;
								this.vmethod_80().Enabled = true;
								this.vmethod_82().Enabled = true;
								this.vmethod_84().Enabled = true;
							}
							else if (this.HookedUnit.IsSubmarine)
							{
								this.vmethod_0().Minimum = 0;
								this.vmethod_80().Enabled = true;
								this.vmethod_82().Enabled = true;
								this.vmethod_84().Enabled = true;
							}
							else if (this.HookedUnit.IsFacility)
							{
								this.vmethod_0().Minimum = 0;
								if (((Facility)this.HookedUnit).Category != Facility._FacilityCategory.Mobile_Vehicle && ((Facility)this.HookedUnit).Category != Facility._FacilityCategory.Mobile_Personnel)
								{
									this.vmethod_82().Enabled = false;
									this.vmethod_80().Enabled = false;
									this.vmethod_84().Enabled = true;
								}
								else
								{
									this.vmethod_82().Enabled = true;
									this.vmethod_80().Enabled = true;
									this.vmethod_84().Enabled = true;
								}
							}
							else if (this.HookedUnit.IsWeapon)
							{
								this.vmethod_0().Minimum = ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise);
								this.vmethod_84().Enabled = false;
								this.vmethod_82().Enabled = false;
								this.vmethod_80().Enabled = true;
							}
							else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
							{
								if (Information.IsNothing(((Group)this.HookedUnit).GetGroupLead()))
								{
									return;
								}
								Aircraft aircraft = (Aircraft)((Group)this.HookedUnit).GetGroupLead();
								if (!aircraft.IsRotaryWing(false))
								{
									this.vmethod_0().Minimum = aircraft.GetAircraftKinematics().GetSpeed(aircraft.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter);
									this.vmethod_84().Enabled = false;
								}
								this.vmethod_82().Enabled = true;
							}
							else
							{
								this.vmethod_0().Minimum = (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false)));
							}
							if (this.HookedUnit.IsSubmarine && !Information.IsNothing(this.HookedUnit.GetKinematics().GetSpeedPreset()) && this.HookedUnit.GetDesiredSpeed() != (float)this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), (ActiveUnit.Throttle)this.HookedUnit.GetKinematics().GetSpeedPreset()))
							{
								this.vmethod_84().Checked = false;
								this.vmethod_82().Checked = false;
								this.vmethod_80().Checked = false;
								this.vmethod_78().Checked = false;
								this.vmethod_86().Checked = false;
								switch (this.HookedUnit.GetKinematics().GetSpeedPreset())
								{
								case ActiveUnit_Kinematics._SpeedPreset.FullStop:
									this.vmethod_84().Checked = true;
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Loiter:
									this.vmethod_82().Checked = true;
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Cruise:
									this.vmethod_80().Checked = true;
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Full:
									this.vmethod_78().Checked = true;
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Flank:
									this.vmethod_86().Checked = true;
									break;
								}
							}
							if (!Information.IsNothing(this.HookedUnit.GetKinematics().GetSpeedPreset()))
							{
								switch (this.HookedUnit.GetKinematics().GetSpeedPreset())
								{
								case ActiveUnit_Kinematics._SpeedPreset.FullStop:
									if (!this.vmethod_84().Checked)
									{
										this.vmethod_84().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Loiter:
									if (!this.vmethod_82().Checked)
									{
										this.vmethod_82().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Cruise:
									if (!this.vmethod_80().Checked)
									{
										this.vmethod_80().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Full:
									if (!this.vmethod_78().Checked)
									{
										this.vmethod_78().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics._SpeedPreset.Flank:
									if (!this.vmethod_86().Checked)
									{
										this.vmethod_86().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics._SpeedPreset.None:
									if (!this.vmethod_150().Checked)
									{
										this.vmethod_150().Checked = true;
									}
									break;
								default:
									if (this.vmethod_84().Checked)
									{
										this.vmethod_84().Checked = false;
									}
									if (this.vmethod_82().Checked)
									{
										this.vmethod_82().Checked = false;
									}
									if (this.vmethod_80().Checked)
									{
										this.vmethod_80().Checked = false;
									}
									if (this.vmethod_78().Checked)
									{
										this.vmethod_78().Checked = false;
									}
									if (this.vmethod_86().Checked)
									{
										this.vmethod_86().Checked = false;
									}
									if (this.vmethod_150().Checked)
									{
										this.vmethod_150().Checked = false;
									}
									break;
								}
							}
							else
							{
								this.vmethod_84().Checked = false;
								this.vmethod_82().Checked = false;
								this.vmethod_80().Checked = false;
								this.vmethod_78().Checked = false;
								this.vmethod_86().Checked = false;
								this.vmethod_150().Checked = false;
							}
							if (this.HookedUnit.IsAircraft)
							{
								switch (((Aircraft)this.HookedUnit).GetAircraftAI().GetAltitudePreset())
								{
								case ActiveUnit_AI._AltitudePreset.None:
									if (!this.GetRB_NoAltitudePreset().Checked)
									{
										this.GetRB_NoAltitudePreset().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.MinAltitude:
									if (!this.GetRB_MinAltitude().Checked)
									{
										this.GetRB_MinAltitude().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.LowAltitude1000:
									if (!this.GetRB_LowAltitude1000().Checked)
									{
										this.GetRB_LowAltitude1000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.LowAltitude2000:
									if (!this.GetRB_LowAltitude2000().Checked)
									{
										this.GetRB_LowAltitude2000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.MediumAltitude12000:
									if (!this.GetRB_MediumAltitude12000().Checked)
									{
										this.GetRB_MediumAltitude12000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.HighAltitude25000:
									if (!this.GetRB_HighAltitude25000().Checked)
									{
										this.GetRB_HighAltitude25000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.HighAltitude36000:
									if (!this.GetRB_HighAltitude36000().Checked)
									{
										this.GetRB_HighAltitude36000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.MaxAltitude:
									if (!this.GetRB_MaxAltitude().Checked)
									{
										this.GetRB_MaxAltitude().Checked = true;
									}
									break;
								default:
									if (this.GetRB_MaxAltitude().Checked)
									{
										this.GetRB_MaxAltitude().Checked = false;
									}
									if (this.GetRB_HighAltitude36000().Checked)
									{
										this.GetRB_HighAltitude36000().Checked = false;
									}
									if (this.GetRB_HighAltitude25000().Checked)
									{
										this.GetRB_HighAltitude25000().Checked = false;
									}
									if (this.GetRB_MediumAltitude12000().Checked)
									{
										this.GetRB_MediumAltitude12000().Checked = false;
									}
									if (this.GetRB_LowAltitude2000().Checked)
									{
										this.GetRB_LowAltitude2000().Checked = false;
									}
									if (this.GetRB_LowAltitude1000().Checked)
									{
										this.GetRB_LowAltitude1000().Checked = false;
									}
									if (this.GetRB_MinAltitude().Checked)
									{
										this.GetRB_MinAltitude().Checked = false;
									}
									if (this.GetRB_NoAltitudePreset().Checked)
									{
										this.GetRB_NoAltitudePreset().Checked = false;
									}
									break;
								}
							}
							else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
							{
								switch (((Aircraft_AI)((Group)this.HookedUnit).GetGroupLead().GetAI()).GetAltitudePreset())
								{
								case ActiveUnit_AI._AltitudePreset.None:
									if (!this.GetRB_NoAltitudePreset().Checked)
									{
										this.GetRB_NoAltitudePreset().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.MinAltitude:
									if (!this.GetRB_MinAltitude().Checked)
									{
										this.GetRB_MinAltitude().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.LowAltitude1000:
									if (!this.GetRB_LowAltitude1000().Checked)
									{
										this.GetRB_LowAltitude1000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.LowAltitude2000:
									if (!this.GetRB_LowAltitude2000().Checked)
									{
										this.GetRB_LowAltitude2000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.MediumAltitude12000:
									if (!this.GetRB_MediumAltitude12000().Checked)
									{
										this.GetRB_MediumAltitude12000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.HighAltitude25000:
									if (!this.GetRB_HighAltitude25000().Checked)
									{
										this.GetRB_HighAltitude25000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.HighAltitude36000:
									if (!this.GetRB_HighAltitude36000().Checked)
									{
										this.GetRB_HighAltitude36000().Checked = true;
									}
									break;
								case ActiveUnit_AI._AltitudePreset.MaxAltitude:
									if (!this.GetRB_MaxAltitude().Checked)
									{
										this.GetRB_MaxAltitude().Checked = true;
									}
									break;
								default:
									if (this.GetRB_MaxAltitude().Checked)
									{
										this.GetRB_MaxAltitude().Checked = false;
									}
									if (this.GetRB_HighAltitude36000().Checked)
									{
										this.GetRB_HighAltitude36000().Checked = false;
									}
									if (this.GetRB_HighAltitude25000().Checked)
									{
										this.GetRB_HighAltitude25000().Checked = false;
									}
									if (this.GetRB_MediumAltitude12000().Checked)
									{
										this.GetRB_MediumAltitude12000().Checked = false;
									}
									if (this.GetRB_LowAltitude2000().Checked)
									{
										this.GetRB_LowAltitude2000().Checked = false;
									}
									if (this.GetRB_LowAltitude1000().Checked)
									{
										this.GetRB_LowAltitude1000().Checked = false;
									}
									if (this.GetRB_MinAltitude().Checked)
									{
										this.GetRB_MinAltitude().Checked = false;
									}
									if (this.GetRB_NoAltitudePreset().Checked)
									{
										this.GetRB_NoAltitudePreset().Checked = false;
									}
									break;
								}
							}
							if (this.HookedUnit.IsSubmarine)
							{
								switch (((Submarine)this.HookedUnit).GetSubmarineAI().GetDepthPreset())
								{
								case ActiveUnit_AI._DepthPreset.None:
									if (!this.GetRB_NoDepthPreset().Checked)
									{
										this.GetRB_NoDepthPreset().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.Periscope:
									if (!this.GetRB_Periscope().Checked)
									{
										this.GetRB_Periscope().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.Shallow:
									if (!this.GetRB_Shallow().Checked)
									{
										this.GetRB_Shallow().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.OverLayer:
									if (!this.GetRB_OverLayer().Checked)
									{
										this.GetRB_OverLayer().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.UnderLayer:
									if (!this.GetRB_UnderLayer().Checked)
									{
										this.GetRB_UnderLayer().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.MaxDepth:
									if (!this.GetRB_MaxDepth().Checked)
									{
										this.GetRB_MaxDepth().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.Surface:
									if (!this.GetRB_Surface().Checked)
									{
										this.GetRB_Surface().Checked = true;
									}
									break;
								default:
									if (this.GetRB_Surface().Checked)
									{
										this.GetRB_Surface().Checked = false;
									}
									if (this.GetRB_Periscope().Checked)
									{
										this.GetRB_Periscope().Checked = false;
									}
									if (this.GetRB_Shallow().Checked)
									{
										this.GetRB_Shallow().Checked = false;
									}
									if (this.GetRB_OverLayer().Checked)
									{
										this.GetRB_OverLayer().Checked = false;
									}
									if (this.GetRB_UnderLayer().Checked)
									{
										this.GetRB_UnderLayer().Checked = false;
									}
									if (this.GetRB_MaxDepth().Checked)
									{
										this.GetRB_MaxDepth().Checked = false;
									}
									if (this.GetRB_NoDepthPreset().Checked)
									{
										this.GetRB_NoDepthPreset().Checked = false;
									}
									break;
								}
							}
							else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)
							{
								switch (((Submarine_AI)((Group)this.HookedUnit).GetGroupLead().GetAI()).GetDepthPreset())
								{
								case ActiveUnit_AI._DepthPreset.None:
									if (!this.GetRB_NoDepthPreset().Checked)
									{
										this.GetRB_NoDepthPreset().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.Periscope:
									if (!this.GetRB_Periscope().Checked)
									{
										this.GetRB_Periscope().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.Shallow:
									if (!this.GetRB_Shallow().Checked)
									{
										this.GetRB_Shallow().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.OverLayer:
									if (!this.GetRB_OverLayer().Checked)
									{
										this.GetRB_OverLayer().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.UnderLayer:
									if (!this.GetRB_UnderLayer().Checked)
									{
										this.GetRB_UnderLayer().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.MaxDepth:
									if (!this.GetRB_MaxDepth().Checked)
									{
										this.GetRB_MaxDepth().Checked = true;
									}
									break;
								case ActiveUnit_AI._DepthPreset.Surface:
									if (!this.GetRB_Surface().Checked)
									{
										this.GetRB_Surface().Checked = true;
									}
									break;
								default:
									if (this.GetRB_Surface().Checked)
									{
										this.GetRB_Surface().Checked = false;
									}
									if (this.GetRB_Periscope().Checked)
									{
										this.GetRB_Periscope().Checked = false;
									}
									if (this.GetRB_Shallow().Checked)
									{
										this.GetRB_Shallow().Checked = false;
									}
									if (this.GetRB_OverLayer().Checked)
									{
										this.GetRB_OverLayer().Checked = false;
									}
									if (this.GetRB_UnderLayer().Checked)
									{
										this.GetRB_UnderLayer().Checked = false;
									}
									if (this.GetRB_MaxDepth().Checked)
									{
										this.GetRB_MaxDepth().Checked = false;
									}
									if (this.GetRB_NoDepthPreset().Checked)
									{
										this.GetRB_NoDepthPreset().Checked = false;
									}
									break;
								}
							}
						}
					}
					else
					{
						Waypoint wayPointSelected;
						if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
						{
							wayPointSelected = Client.GetWayPointSelected();
						}
						else
						{
							wayPointSelected = this.waypoint_0;
						}
						if (wayPointSelected.GetDSO().HasValue)
						{
							if (!Information.IsNothing(wayPointSelected.DesiredSpeed))
							{
								this.vmethod_8().Text = Conversions.ToString(Math.Round((double)wayPointSelected.DesiredSpeed.Value, 0)) + "节";
							}
							else
							{
								if (wayPointSelected.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.FullStop)
								{
									this.vmethod_8().Text = "停车";
								}
								if (wayPointSelected.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.Loiter)
								{
									if (Information.IsNothing(this.waypoint_0) && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
									{
										this.vmethod_8().Text = "低速";
									}
									else
									{
										this.vmethod_8().Text = "低速";
									}
								}
								if (wayPointSelected.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.Cruise)
								{
									this.vmethod_8().Text = "巡航";
								}
								if (wayPointSelected.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.Full)
								{
									if (Information.IsNothing(this.waypoint_0) && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
									{
										this.vmethod_8().Text = "全速";
									}
									else
									{
										this.vmethod_8().Text = "军用";
									}
								}
								if (wayPointSelected.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.Flank)
								{
									if (Information.IsNothing(this.waypoint_0) && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
									{
										this.vmethod_8().Text = "最大";
									}
									else
									{
										this.vmethod_8().Text = "加力";
									}
								}
							}
						}
						else
						{
							this.vmethod_8().Text = "未设定";
						}
						if (wayPointSelected.GetDAO())
						{
							if (Information.IsNothing(wayPointSelected.DesiredAltitude) && Information.IsNothing(wayPointSelected.DesiredAltitude_TerrainFollowing))
							{
								if (!Information.IsNothing(this.HookedUnit))
								{
									if (this.HookedUnit.IsSubmarine && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.SubGroup) && wayPointSelected.GetDepthPreset() == ActiveUnit_AI._DepthPreset.MaxDepth)
									{
										this.vmethod_26().Text = "最大深度";
									}
									if (this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup))
									{
										if (wayPointSelected.GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.MaxAltitude)
										{
											this.vmethod_26().Text = "最大高度";
										}
										if (wayPointSelected.GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.MinAltitude)
										{
											this.vmethod_26().Text = "最低高度";
										}
									}
								}
								else if (!Information.IsNothing(this.waypoint_0))
								{
									if (wayPointSelected.GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.MaxAltitude)
									{
										this.vmethod_26().Text = "最大高度";
									}
									if (wayPointSelected.GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.MinAltitude)
									{
										this.vmethod_26().Text = "最低高度";
									}
								}
							}
							else if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								if (Information.IsNothing(this.waypoint_0) && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
								{
									Control arg_2760_0 = this.vmethod_26();
									float? num9 = wayPointSelected.DesiredAltitude;
									arg_2760_0.Text = Conversions.ToString((int)Math.Round((double)(num9.HasValue ? new float?(num9.GetValueOrDefault() * 3.28084f) : null).Value)) + "英尺";
								}
								else if (wayPointSelected.IsTerrainFollowing() && !Information.IsNothing(wayPointSelected.DesiredAltitude_TerrainFollowing))
								{
									Control arg_27DF_0 = this.vmethod_26();
									float? num9 = wayPointSelected.DesiredAltitude_TerrainFollowing;
									arg_27DF_0.Text = Conversions.ToString((int)Math.Round((double)(num9.HasValue ? new float?(num9.GetValueOrDefault() * 3.28084f) : null).Value)) + "英尺(真高)";
								}
								else if (!Information.IsNothing(wayPointSelected.DesiredAltitude))
								{
									Control arg_2855_0 = this.vmethod_26();
									float? num9 = wayPointSelected.DesiredAltitude;
									arg_2855_0.Text = Conversions.ToString((int)Math.Round((double)(num9.HasValue ? new float?(num9.GetValueOrDefault() * 3.28084f) : null).Value)) + "英尺(海高)";
								}
							}
							else if (Information.IsNothing(this.waypoint_0) && !this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
							{
								this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)wayPointSelected.DesiredAltitude.Value)) + "米";
							}
							else if (wayPointSelected.IsTerrainFollowing() && !Information.IsNothing(wayPointSelected.DesiredAltitude_TerrainFollowing))
							{
								this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)wayPointSelected.DesiredAltitude_TerrainFollowing.Value)) + "米(真高)";
							}
							else if (!Information.IsNothing(wayPointSelected.DesiredAltitude))
							{
								this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)wayPointSelected.DesiredAltitude.Value)) + "米(海高)";
							}
						}
						else
						{
							this.vmethod_26().Text = "未设定";
						}
						if (!this.bool_0)
						{
							this.vmethod_70().Text = this.vmethod_8().Text;
							this.vmethod_74().Text = this.vmethod_26().Text;
						}
						this.vmethod_142().Checked = wayPointSelected.IsTerrainFollowing();
						if (!Information.IsNothing(this.HookedUnit))
						{
							if (this.HookedUnit.IsGroup)
							{
								this.vmethod_12().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentSpeed(), 1)) + "节";
							}
							else
							{
								this.vmethod_12().Text = Conversions.ToString(Math.Round((double)this.HookedUnit.GetCurrentSpeed(), 1)) + "节(油门: " + this.GetThrottleString() + ")";
							}
						}
						if (!Information.IsNothing(this.HookedUnit))
						{
							if (!this.HookedUnit.IsAircraft && (!this.HookedUnit.IsGroup || ((Group)this.HookedUnit).GetGroupType() != Group.GroupType.AirGroup))
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)(this.HookedUnit.GetCurrentAltitude_ASL(false) * 3.28084f))) + "英尺";
								}
								else
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)this.HookedUnit.GetCurrentAltitude_ASL(false))) + "米";
								}
							}
							else if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								if (this.HookedUnit.IsOnLand())
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)(this.HookedUnit.GetCurrentAltitude_ASL(false) * 3.28084f))) + "英尺（海高）(" + Conversions.ToString(Math.Round((double)(this.HookedUnit.GetAltitude_AGL() * 3.28084f), 0)) + "英尺(真高))";
								}
								else
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)(this.HookedUnit.GetCurrentAltitude_ASL(false) * 3.28084f))) + "英尺（海高）";
								}
							}
							else if (this.HookedUnit.IsOnLand())
							{
								this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)this.HookedUnit.GetCurrentAltitude_ASL(false))) + "米(海高) (" + Conversions.ToString(Math.Round((double)this.HookedUnit.GetAltitude_AGL(), 0)) + "米(真高))";
							}
							else
							{
								this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)this.HookedUnit.GetCurrentAltitude_ASL(false))) + "米(海高)";
							}
						}
						if (!this.bool_0)
						{
							if (wayPointSelected.DesiredAltitude.HasValue || wayPointSelected.DesiredAltitude_TerrainFollowing.HasValue || wayPointSelected.GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.None || wayPointSelected.GetDepthPreset() == ActiveUnit_AI._DepthPreset.None)
							{
								if (!wayPointSelected.GetDAO())
								{
									this.vmethod_74().Text = "";
								}
								else if (wayPointSelected.DesiredAltitude.HasValue || wayPointSelected.DesiredAltitude_TerrainFollowing.HasValue)
								{
									if (SimConfiguration.gameOptions.UseImperialUnit())
									{
										if (wayPointSelected.IsTerrainFollowing() && !Information.IsNothing(wayPointSelected.DesiredAltitude_TerrainFollowing))
										{
											Control arg_2D3A_0 = this.vmethod_74();
											float? num9 = wayPointSelected.DesiredAltitude_TerrainFollowing;
											arg_2D3A_0.Text = Conversions.ToString((int)Math.Round((double)(num9.HasValue ? new float?(num9.GetValueOrDefault() * 3.28084f) : null).Value));
										}
										else if (!Information.IsNothing(wayPointSelected.DesiredAltitude))
										{
											Control arg_2DA6_0 = this.vmethod_74();
											float? num9 = wayPointSelected.DesiredAltitude;
											arg_2DA6_0.Text = Conversions.ToString((int)Math.Round((double)(num9.HasValue ? new float?(num9.GetValueOrDefault() * 3.28084f) : null).Value));
										}
									}
									else if (wayPointSelected.IsTerrainFollowing() && !Information.IsNothing(wayPointSelected.DesiredAltitude_TerrainFollowing))
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)wayPointSelected.DesiredAltitude_TerrainFollowing.Value));
									}
									else if (!Information.IsNothing(wayPointSelected.DesiredAltitude))
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)wayPointSelected.DesiredAltitude.Value));
									}
								}
							}
							if (wayPointSelected.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.None)
							{
								if (!wayPointSelected.GetDSO().HasValue)
								{
									this.vmethod_70().Text = "";
								}
								else if (wayPointSelected.DesiredSpeed.HasValue)
								{
									this.vmethod_70().Text = Conversions.ToString(wayPointSelected.DesiredSpeed.Value);
								}
							}
						}
						this.vmethod_38().Checked = wayPointSelected.GetDSO().HasValue;
						this.GetCB_AltOverride().Checked = wayPointSelected.GetDAO();
						if (Information.IsNothing(wayPointSelected.GetDSO()))
						{
							if (wayPointSelected.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
							{
								this.vmethod_150().Visible = true;
							}
							else
							{
								this.vmethod_150().Visible = false;
							}
						}
						else
						{
							this.vmethod_150().Visible = false;
						}
						if (!wayPointSelected.GetDAO())
						{
							if (wayPointSelected.GetAltitudePreset() != ActiveUnit_AI._AltitudePreset.None)
							{
								this.GetRB_NoAltitudePreset().Visible = true;
							}
							else
							{
								this.GetRB_NoAltitudePreset().Visible = false;
							}
							if (wayPointSelected.GetDepthPreset() != ActiveUnit_AI._DepthPreset.None)
							{
								this.GetRB_NoDepthPreset().Visible = true;
							}
							else
							{
								this.GetRB_NoDepthPreset().Visible = false;
							}
						}
						else
						{
							this.GetRB_NoDepthPreset().Visible = false;
							this.GetRB_NoAltitudePreset().Visible = false;
						}
						if (!Information.IsNothing(wayPointSelected.GetThrottlePreset()))
						{
							switch (wayPointSelected.GetThrottlePreset())
							{
							case ActiveUnit_Kinematics._SpeedPreset.FullStop:
								if (!this.vmethod_84().Checked)
								{
									this.vmethod_84().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics._SpeedPreset.Loiter:
								if (!this.vmethod_82().Checked)
								{
									this.vmethod_82().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics._SpeedPreset.Cruise:
								if (!this.vmethod_80().Checked)
								{
									this.vmethod_80().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics._SpeedPreset.Full:
								if (!this.vmethod_78().Checked)
								{
									this.vmethod_78().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics._SpeedPreset.Flank:
								if (!this.vmethod_86().Checked)
								{
									this.vmethod_86().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics._SpeedPreset.None:
								if (!this.vmethod_150().Checked)
								{
									this.vmethod_150().Checked = true;
								}
								break;
							default:
								if (this.vmethod_84().Checked)
								{
									this.vmethod_84().Checked = false;
								}
								if (this.vmethod_82().Checked)
								{
									this.vmethod_82().Checked = false;
								}
								if (this.vmethod_80().Checked)
								{
									this.vmethod_80().Checked = false;
								}
								if (this.vmethod_78().Checked)
								{
									this.vmethod_78().Checked = false;
								}
								if (this.vmethod_86().Checked)
								{
									this.vmethod_86().Checked = false;
								}
								if (this.vmethod_150().Checked)
								{
									this.vmethod_150().Checked = false;
								}
								break;
							}
						}
						else
						{
							this.vmethod_84().Checked = false;
							this.vmethod_82().Checked = false;
							this.vmethod_80().Checked = false;
							this.vmethod_78().Checked = false;
							this.vmethod_86().Checked = false;
							this.vmethod_150().Checked = false;
						}
						if (!Information.IsNothing(this.HookedUnit))
						{
							int num10 = Array.IndexOf<Waypoint>(this.HookedUnit.GetNavigator().GetPlottedCourse(), Client.GetWayPointSelected());
							bool flag4 = false;
							if (num10 >= 0)
							{
								if (this.HookedUnit.IsAircraft || this.HookedUnit.IsShip || this.HookedUnit.IsSubmarine)
								{
									flag4 = true;
								}
								if (!flag4 && this.HookedUnit.IsGroup && (((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup | ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SurfaceGroup | ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
								{
									flag4 = true;
								}
							}
							if (flag4)
							{
								int num11 = 0;
								int num12 = 0;
								try
								{
									int num13 = num10;
									for (int i = 0; i <= num13; i++)
									{
										if (i == 0)
										{
											num11 = (int)Math.Round((double)this.HookedUnit.GetCurrentSpeed());
											num12 = (int)Math.Round((double)this.HookedUnit.GetDesiredSpeed());
											float num14 = this.HookedUnit.GetCurrentAltitude_ASL(false);
											float num15 = this.HookedUnit.GetDesiredAltitude();
											num2 = (double)this.HookedUnit.HorizontalRangeTo(this.HookedUnit.GetNavigator().GetPlottedCourse()[0]);
											num3 = (float)(num2 / (double)num11 * 3600.0);
											num4 = (float)(num2 / (double)num12 * 3600.0);
											ActiveUnit activeUnit2;
											if (this.HookedUnit.IsGroup)
											{
												activeUnit2 = ((Group)this.HookedUnit).GetGroupLead();
											}
											else
											{
												activeUnit2 = this.HookedUnit;
											}
											num5 = num3 * activeUnit2.GetFuelConsumption(activeUnit2.GetKinematics().vmethod_38(num14, (float)num11), null, new float?((float)num11), new float?(num14), false, false, false, false);
											num6 = num4 * activeUnit2.GetFuelConsumption(activeUnit2.GetThrottle(), null, new float?((float)num12), new float?(num15), false, false, false, false);
										}
										else if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i].GetLatitude() != this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetLatitude() && this.HookedUnit.GetNavigator().GetPlottedCourse()[i].GetLongitude() != this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetLongitude())
										{
											double num16 = (double)Math2.GetDistance(this.HookedUnit.GetNavigator().GetPlottedCourse()[i].GetLatitude(), this.HookedUnit.GetNavigator().GetPlottedCourse()[i].GetLongitude(), this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetLatitude(), this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetLongitude());
											float num14 = 0f;
											float num15 = 0f;
											if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetDAO())
											{
												if (!Information.IsNothing(this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].DesiredAltitude))
												{
													num14 = this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].DesiredAltitude.Value;
													num15 = this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].DesiredAltitude.Value;
													if (num14 < num8)
													{
														num14 = num8;
													}
													if (num14 > num7)
													{
														num14 = num7;
													}
													if (num15 < num8)
													{
														num15 = num8;
													}
													if (num15 > num7)
													{
														num15 = num7;
													}
												}
												else if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetDepthPreset() != ActiveUnit_AI._DepthPreset.None)
												{
													if (this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup))
													{
														if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetDepthPreset() == ActiveUnit_AI._DepthPreset.Surface)
														{
															num14 = 0f;
															num15 = 0f;
														}
														if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetDepthPreset() == ActiveUnit_AI._DepthPreset.MaxDepth)
														{
															num14 = num8;
															num15 = num8;
														}
													}
												}
												else if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetAltitudePreset() != ActiveUnit_AI._AltitudePreset.None && (this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)))
												{
													if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.MaxAltitude)
													{
														num14 = num7;
														num15 = num7;
													}
													if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetAltitudePreset() == ActiveUnit_AI._AltitudePreset.MinAltitude)
													{
														num14 = num8;
														num15 = num8;
													}
												}
											}
											if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetDSO().HasValue)
											{
												if (!Information.IsNothing(this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].DesiredSpeed))
												{
													num11 = (int)Math.Round((double)this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].DesiredSpeed.Value);
													num12 = (int)Math.Round((double)this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].DesiredSpeed.Value);
													if (num11 > this.HookedUnit.GetKinematics().GetSpeed(num14))
													{
														num11 = this.HookedUnit.GetKinematics().GetSpeed(num14);
													}
													if (num12 > this.HookedUnit.GetKinematics().GetSpeed(num15))
													{
														num12 = this.HookedUnit.GetKinematics().GetSpeed(num15);
													}
													if (this.HookedUnit.IsAircraft)
													{
														if (!((Aircraft)this.HookedUnit).IsRotaryWing(false))
														{
															if (num11 < ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(num14, ActiveUnit.Throttle.Loiter))
															{
																num11 = ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(num14, ActiveUnit.Throttle.Loiter);
															}
															if (num12 < ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(num15, ActiveUnit.Throttle.Loiter))
															{
																num12 = ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(num15, ActiveUnit.Throttle.Loiter);
															}
														}
													}
													else if (this.HookedUnit.IsWeapon)
													{
														if (num11 < ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(num14, ActiveUnit.Throttle.Cruise))
														{
															num11 = ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(num14, ActiveUnit.Throttle.Cruise);
														}
														if (num12 < ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(num15, ActiveUnit.Throttle.Cruise))
														{
															num12 = ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(num15, ActiveUnit.Throttle.Cruise);
														}
													}
													else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
													{
														if (Information.IsNothing(((Group)this.HookedUnit).GetGroupLead()))
														{
															return;
														}
														Aircraft aircraft2 = (Aircraft)((Group)this.HookedUnit).GetGroupLead();
														if (!aircraft2.IsRotaryWing(false))
														{
															if (num11 < aircraft2.GetAircraftKinematics().GetSpeed(num14, ActiveUnit.Throttle.Loiter))
															{
																num11 = aircraft2.GetAircraftKinematics().GetSpeed(num14, ActiveUnit.Throttle.Loiter);
															}
															if (num12 < aircraft2.GetAircraftKinematics().GetSpeed(num15, ActiveUnit.Throttle.Loiter))
															{
																num12 = aircraft2.GetAircraftKinematics().GetSpeed(num15, ActiveUnit.Throttle.Loiter);
															}
														}
													}
													else
													{
														if (num11 < (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(num14)))
														{
															num11 = (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false)));
														}
														if (num12 < (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(num15)))
														{
															num12 = (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(this.HookedUnit.GetDesiredAltitude()));
														}
													}
												}
											}
											else if (this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
											{
												num11 = this.HookedUnit.GetKinematics().GetSpeed(num14, (ActiveUnit.Throttle)this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetThrottlePreset());
												num12 = this.HookedUnit.GetKinematics().GetSpeed(num15, (ActiveUnit.Throttle)this.HookedUnit.GetNavigator().GetPlottedCourse()[i - 1].GetThrottlePreset());
											}
											if (num11 <= 0 | num12 <= 0)
											{
												break;
											}
											num2 += num16;
											ActiveUnit activeUnit3;
											if (this.HookedUnit.IsGroup)
											{
												activeUnit3 = ((Group)this.HookedUnit).GetGroupLead();
											}
											else
											{
												activeUnit3 = this.HookedUnit;
											}
											if (num11 > 0)
											{
												num3 = (float)((double)num3 + num16 / (double)num11 * 3600.0);
												num5 = (float)((double)num5 + num16 / (double)num11 * 3600.0 * (double)activeUnit3.GetFuelConsumption(activeUnit3.GetKinematics().vmethod_38(num14, (float)num11), null, new float?((float)num11), new float?(num14), false, false, false, false));
											}
											if (num12 > 0)
											{
												num4 = (float)((double)num4 + num16 / (double)num12 * 3600.0);
												num6 = (float)((double)num6 + num16 / (double)num12 * 3600.0 * (double)activeUnit3.GetFuelConsumption(activeUnit3.GetKinematics().vmethod_38(num14, (float)num11), null, new float?((float)num12), new float?(num15), false, false, false, false));
											}
										}
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ex4.Data.Add("Error at 200412", ex4.Message);
									GameGeneral.LogException(ref ex4);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
								try
								{
									if (num11 > 0 && num12 > 0)
									{
										this.vmethod_96().Text = "剩余航行距离: " + Conversions.ToString(Math.Round(num2, 1)) + "海里";
										if ((int)Math.Round((double)num4) != (int)Math.Round((double)num3))
										{
											this.vmethod_94().Text = string.Concat(new string[]
											{
												"剩余航行时间： ",
												Misc.GetTimeString((long)Math.Round((double)num3), Aircraft_AirOps._Maintenance.const_0, false, false),
												" (当前), ",
												Misc.GetTimeString((long)Math.Round((double)num4), Aircraft_AirOps._Maintenance.const_0, false, false),
												" (期望) "
											});
											this.vmethod_98().Text = string.Concat(new string[]
											{
												"需要燃油量: ",
												Conversions.ToString(Math.Round((double)num5, 1)),
												"高度(当前), ",
												Conversions.ToString(Math.Round((double)num6, 1)),
												"公斤(期望) "
											});
										}
										else
										{
											this.vmethod_94().Text = "剩余航行时间： " + Misc.GetTimeString((long)Math.Round((double)num4), Aircraft_AirOps._Maintenance.const_0, false, false);
											this.vmethod_98().Text = "需要燃油量: " + Conversions.ToString(Math.Round((double)num6, 1)) + "公斤";
										}
										this.vmethod_90().Text = "航路点#" + Conversions.ToString(num10 + 1) + "—作战单元：" + this.HookedUnit.Name;
									}
									else
									{
										this.vmethod_90().Text = "至少一个航速指令为0节,不能估计剩余航行距离/时间/燃油量";
										this.vmethod_96().Text = "";
										this.vmethod_94().Text = "";
										this.vmethod_98().Text = "";
									}
									goto IL_3E36;
								}
								catch (Exception ex5)
								{
									ProjectData.SetProjectError(ex5);
									Exception ex6 = ex5;
									ex6.Data.Add("Error at 200413", ex6.Message);
									GameGeneral.LogException(ref ex6);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
									goto IL_3E36;
								}
							}
							this.vmethod_90().Text = "";
							this.vmethod_96().Text = "";
							this.vmethod_94().Text = "";
							this.vmethod_98().Text = "";
						}
						IL_3E36:
						if (!this.bool_1)
						{
							this.vmethod_100().Text = wayPointSelected.Description;
							Waypoint.WaypointType waypointType2 = wayPointSelected.waypointType;
							if (waypointType2 <= Waypoint.WaypointType.Assemble)
							{
								if (waypointType2 != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
								{
									if (waypointType2 == Waypoint.WaypointType.Assemble)
									{
										this.GetCB_WaypointType().SelectedIndex = 0;
									}
								}
								else
								{
									this.GetCB_WaypointType().SelectedIndex = 1;
								}
							}
							else if (waypointType2 == Waypoint.WaypointType.Target || waypointType2 == Waypoint.WaypointType.WeaponTarget)
							{
								this.GetCB_WaypointType().SelectedIndex = 2;
							}
						}
					}
					this.method_4();
					this.bool_2 = true;
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ex8.Data.Add("Error at 200637", ex8.Message);
				GameGeneral.LogException(ref ex8);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x002621C8 File Offset: 0x002603C8
		private void method_4()
		{
			if (!this.vmethod_16().Visible)
			{
				this.vmethod_130().Visible = false;
				this.vmethod_114().Visible = false;
				this.vmethod_128().Visible = false;
				this.vmethod_126().Visible = false;
				this.vmethod_116().Visible = false;
				this.vmethod_148().Visible = false;
				this.vmethod_146().Visible = false;
				this.vmethod_134().Visible = false;
				this.vmethod_132().Visible = false;
				this.vmethod_124().Visible = false;
				this.vmethod_138().Visible = false;
				this.vmethod_136().Visible = false;
				this.vmethod_112().Visible = false;
				this.vmethod_108().Visible = false;
				this.vmethod_110().Visible = false;
				this.vmethod_118().Visible = false;
				this.vmethod_120().Visible = false;
				this.vmethod_122().Visible = false;
			}
			else
			{
				ActiveUnit activeUnit = this.HookedUnit;
				if (activeUnit.IsGroup)
				{
					activeUnit = ((Group)activeUnit).GetGroupLead();
				}
				float num = (float)activeUnit.GetTerrainElevation(false, true, false);
				Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(activeUnit.m_Scenario, activeUnit.GetLatitude(null), activeUnit.GetLongitude(null), (int)Math.Round((double)activeUnit.GetCurrentAltitude_ASL(true)));
				int num2 = 0;
				int num3 = 0;
				float num4 = 0f;
				SonarEnvironment.SetLayerData(activeUnit.GetLatitude(null), activeUnit.GetLongitude(null), (int)Math.Round((double)activeUnit.GetCurrentAltitude_ASL(true)), ref num2, ref num3, ref num4, true);
				double num5 = (double)(this.vmethod_16().Top + this.vmethod_16().Margin.Top + 10);
				double num6 = (double)(this.vmethod_16().Top + this.vmethod_16().Height - this.vmethod_16().Margin.Top - this.vmethod_16().Margin.Bottom - 7);
				double num7 = (double)this.vmethod_16().Maximum;
				double num8 = (double)this.vmethod_16().Minimum;
				double num9 = num7;
				double num10 = num8;
				double num11 = num5;
				double num12 = num6;
				if (activeUnit.GetUnitType() == GlobalVariables.ActiveUnitType.Aircraft)
				{
					this.vmethod_148().Visible = true;
					this.vmethod_146().Visible = true;
					double num13;
					double num14;
					if (num < 0f | (double)num > num7 | (double)num < num8)
					{
						this.vmethod_124().Visible = false;
						this.vmethod_116().Visible = false;
					}
					else
					{
						num13 = (double)num;
						num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_116().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_116().Height / 2.0);
						this.vmethod_116().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_124().Visible = true;
							this.vmethod_124().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_124().Height / 2.0 - 1.0);
							this.vmethod_124().Text = "真高";
						}
						else
						{
							this.vmethod_124().Visible = false;
						}
					}
					float num15 = (float)((double)weatherProfile.GetFUR() - 0.001);
					if (weatherProfile.GetFUR() == 0f)
					{
						num15 = 0f;
					}
					double num16;
					double num17;
					double num18;
					double num19;
					if ((double)num15 > 0.9)
					{
						num16 = 36000.0;
						num17 = 7000.0;
						num18 = 2000.0;
						num19 = 1.0;
						this.vmethod_134().Text = "多云";
						this.vmethod_132().Text = "多云";
						this.vmethod_138().Text = "浓雾";
						this.vmethod_136().Text = "浓雾";
					}
					else if ((double)num15 > 0.8)
					{
						num16 = 36000.0;
						num17 = 7000.0;
						num18 = 2000.0;
						num19 = 1.0;
						this.vmethod_134().Text = "多云";
						this.vmethod_132().Text = "多云";
						this.vmethod_138().Text = "薄雾";
						this.vmethod_136().Text = "薄雾";
					}
					else if ((double)num15 > 0.7)
					{
						num16 = 36000.0;
						num17 = 30000.0;
						num18 = 16000.0;
						num19 = 7000.0;
						this.vmethod_134().Text = "有云";
						this.vmethod_132().Text = "有云";
						this.vmethod_138().Text = "多云";
						this.vmethod_136().Text = "多云";
					}
					else if ((double)num15 > 0.6)
					{
						num16 = 30000.0;
						num17 = 27000.0;
						num18 = 16000.0;
						num19 = 7000.0;
						this.vmethod_134().Text = "少云";
						this.vmethod_132().Text = "少云";
						this.vmethod_138().Text = "有云";
						this.vmethod_136().Text = "有云";
					}
					else if ((double)num15 > 0.5)
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 28000.0;
						num19 = 25000.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "有云";
						this.vmethod_136().Text = "有云";
					}
					else if ((double)num15 > 0.4)
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 16000.0;
						num19 = 7000.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "有云";
						this.vmethod_136().Text = "有云";
					}
					else if ((double)num15 > 0.3)
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 7000.0;
						num19 = 2000.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "有云";
						this.vmethod_136().Text = "有云";
					}
					else if ((double)num15 > 0.2)
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 23000.0;
						num19 = 20000.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "少云";
						this.vmethod_136().Text = "少云";
					}
					else if ((double)num15 > 0.1)
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 16000.0;
						num19 = 10000.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "少云";
						this.vmethod_136().Text = "少云";
					}
					else if ((double)num15 > 0.0)
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 7000.0;
						num19 = 5000.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "少云";
						this.vmethod_136().Text = "少云";
					}
					else
					{
						num16 = 0.0;
						num17 = 0.0;
						num18 = 0.0;
						num19 = 0.0;
						this.vmethod_134().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_132().Text = "";
						this.vmethod_138().Text = "";
					}
					double num20 = num16 / 3.2808399200439453;
					double num21 = num17 / 3.2808399200439453;
					double num22 = num18 / 3.2808399200439453;
					double num23 = num19 / 3.2808399200439453;
					num13 = num20;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_148().Y1 = (int)Math.Round(num14 - (double)this.vmethod_114().Height);
					num13 = num21;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_148().Y2 = (int)Math.Round(num14 - (double)this.vmethod_130().Height);
					num13 = num22;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_146().Y1 = (int)Math.Round(num14 - (double)this.vmethod_126().Height);
					num13 = num23;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_146().Y2 = (int)Math.Round(num14 - (double)this.vmethod_128().Height);
					if (num20 == 0.0 | num20 < (double)num | num20 > num7 | num20 < num8)
					{
						this.vmethod_114().Visible = false;
						this.vmethod_134().Visible = false;
					}
					else
					{
						num13 = num20;
						num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_114().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_114().Height / 2.0);
						this.vmethod_114().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_134().Visible = true;
							this.vmethod_134().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_134().Height / 2.0 - 1.0);
						}
						else
						{
							this.vmethod_134().Visible = false;
						}
					}
					if (num21 == 0.0 | num21 < (double)num | num21 > num7 | num21 < num8)
					{
						this.vmethod_130().Visible = false;
						this.vmethod_132().Visible = false;
					}
					else
					{
						num13 = num21;
						num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_130().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_130().Height / 2.0);
						this.vmethod_130().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_132().Visible = true;
							this.vmethod_132().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_132().Height / 2.0 - 1.0);
						}
						else
						{
							this.vmethod_132().Visible = false;
						}
					}
					if (num22 == 0.0 | num22 < (double)num | num22 > num7 | num22 < num8)
					{
						this.vmethod_126().Visible = false;
						this.vmethod_138().Visible = false;
					}
					else
					{
						num13 = num22;
						num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_126().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_126().Height / 2.0);
						this.vmethod_126().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_138().Visible = true;
							this.vmethod_138().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_134().Height / 2.0 - 1.0);
						}
						else
						{
							this.vmethod_138().Visible = false;
						}
					}
					if (num23 == 0.0 | num23 < (double)num | num23 > num7 | num23 < num8)
					{
						this.vmethod_128().Visible = false;
						this.vmethod_136().Visible = false;
					}
					else
					{
						num13 = num23;
						num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_128().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_128().Height / 2.0);
						this.vmethod_128().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_136().Visible = true;
							this.vmethod_136().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_136().Height / 2.0 - 1.0);
						}
						else
						{
							this.vmethod_136().Visible = false;
						}
					}
				}
				else
				{
					this.vmethod_130().Visible = false;
					this.vmethod_114().Visible = false;
					this.vmethod_128().Visible = false;
					this.vmethod_126().Visible = false;
					this.vmethod_116().Visible = false;
					this.vmethod_148().Visible = false;
					this.vmethod_146().Visible = false;
					this.vmethod_134().Visible = false;
					this.vmethod_132().Visible = false;
					this.vmethod_124().Visible = false;
					this.vmethod_138().Visible = false;
					this.vmethod_136().Visible = false;
				}
				if (activeUnit.GetUnitType() != GlobalVariables.ActiveUnitType.Submarine)
				{
					this.vmethod_112().Visible = false;
					this.vmethod_108().Visible = false;
					this.vmethod_110().Visible = false;
					this.vmethod_118().Visible = false;
					this.vmethod_120().Visible = false;
					this.vmethod_122().Visible = false;
				}
				else
				{
					if ((float)num2 < num | (double)num2 > num7 | (double)num2 < num8)
					{
						this.vmethod_108().Visible = false;
						this.vmethod_118().Visible = false;
					}
					else
					{
						double num13 = (double)num2;
						double num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_108().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_108().Height / 2.0);
						this.vmethod_108().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_118().Visible = true;
							this.vmethod_118().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_118().Height / 2.0 - 1.0);
							this.vmethod_118().Text = "温跃层高限";
						}
						else
						{
							this.vmethod_118().Visible = false;
						}
					}
					if ((float)num3 < num | (double)num3 > num7 | (double)num3 < num8)
					{
						this.vmethod_110().Visible = false;
						this.vmethod_120().Visible = false;
					}
					else
					{
						double num13 = (double)num3;
						double num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_110().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_110().Height / 2.0);
						this.vmethod_110().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_120().Visible = true;
							this.vmethod_120().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_120().Height / 2.0 - 1.0);
							this.vmethod_120().Text = "温跃层低限";
						}
						else
						{
							this.vmethod_120().Visible = false;
						}
					}
					if ((double)num < num8 | (double)num > num7 | (double)num < num8)
					{
						this.vmethod_112().Visible = false;
						this.vmethod_122().Visible = false;
					}
					else
					{
						double num13 = (double)num;
						double num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
						this.vmethod_112().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_112().Height / 2.0);
						this.vmethod_112().Visible = true;
						if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
						{
							this.vmethod_122().Visible = true;
							this.vmethod_122().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_122().Height / 2.0 - 1.0);
							this.vmethod_122().Text = "海床";
						}
						else
						{
							this.vmethod_122().Visible = false;
						}
					}
				}
			}
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00263540 File Offset: 0x00261740
		private string GetThrottleString()
		{
			string result;
			if (Information.IsNothing(this.HookedUnit))
			{
				result = "-";
			}
			else
			{
				switch (this.HookedUnit.GetThrottle())
				{
				case ActiveUnit.Throttle.FullStop:
					result = "停车";
					break;
				case ActiveUnit.Throttle.Loiter:
					if (this.HookedUnit.IsAircraft)
					{
						result = "低速";
					}
					else
					{
						result = "低速";
					}
					break;
				case ActiveUnit.Throttle.Cruise:
					result = "巡航";
					break;
				case ActiveUnit.Throttle.Full:
					if (this.HookedUnit.IsAircraft)
					{
						result = "军用";
					}
					else
					{
						result = "全速";
					}
					break;
				case ActiveUnit.Throttle.Flank:
					if (this.HookedUnit.IsAircraft)
					{
						result = "加力";
					}
					else
					{
						result = "最大";
					}
					break;
				default:
					throw new NotImplementedException();
				}
			}
			return result;
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x00027CB7 File Offset: 0x00025EB7
		private void method_6(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x00263608 File Offset: 0x00261808
		private void method_7(object sender, EventArgs e)
		{
			if (this.bool_2 && this.vmethod_84().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.FullStop);
					Client.GetWayPointSelected().DesiredSpeed = null;
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.FullStop);
					this.waypoint_0.DesiredSpeed = null;
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.FullStop);
					this.HookedUnit.GetKinematics().SetThrottle();
					this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum));
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x0026381C File Offset: 0x00261A1C
		private void method_8(object sender, EventArgs e)
		{
			if (this.bool_2 && this.vmethod_82().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
					Client.GetWayPointSelected().DesiredSpeed = null;
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
					this.waypoint_0.DesiredSpeed = null;
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
					this.HookedUnit.GetKinematics().SetThrottle();
					if (Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00263A78 File Offset: 0x00261C78
		private void method_9(object sender, EventArgs e)
		{
			if (this.bool_2 && this.vmethod_80().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
					Client.GetWayPointSelected().DesiredSpeed = null;
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
					this.waypoint_0.DesiredSpeed = null;
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
					this.HookedUnit.GetKinematics().SetThrottle();
					if (Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00263CD4 File Offset: 0x00261ED4
		private void method_10(object sender, EventArgs e)
		{
			if (this.bool_2 && this.vmethod_78().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Full);
					Client.GetWayPointSelected().DesiredSpeed = null;
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Full);
					this.waypoint_0.DesiredSpeed = null;
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.Full);
					this.HookedUnit.GetKinematics().SetThrottle();
					if (Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00263F30 File Offset: 0x00262130
		private void method_11(object sender, EventArgs e)
		{
			if (this.bool_2 && this.vmethod_150().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
					Client.GetWayPointSelected().DesiredSpeed = null;
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
					this.waypoint_0.DesiredSpeed = null;
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_0;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
			}
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x002640A8 File Offset: 0x002622A8
		private void method_12(object sender, EventArgs e)
		{
			if (this.bool_2 && this.vmethod_86().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Flank);
					Client.GetWayPointSelected().DesiredSpeed = null;
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Flank);
					this.waypoint_0.DesiredSpeed = null;
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.Flank);
					this.HookedUnit.GetKinematics().SetThrottle();
					if (Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredSpeed(), (float)this.vmethod_0().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00264304 File Offset: 0x00262504
		private void method_13(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.HookedUnit))
			{
				this.HookedUnit.SetDesiredSpeed((float)this.vmethod_0().Value);
				this.method_16();
				this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
			}
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00264378 File Offset: 0x00262578
		private void method_14(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.HookedUnit))
			{
				this.HookedUnit.SetDesiredAltitude((float)this.vmethod_16().Value);
				this.method_15();
				this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
			}
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x002643EC File Offset: 0x002625EC
		private void method_15()
		{
			if (!(Information.IsNothing(this.HookedUnit) & Information.IsNothing(Client.GetWayPointSelected())) || !Information.IsNothing(this.waypoint_0))
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDAO(true);
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDAO(true);
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetDesiredAltitudeOverride(true);
				}
				this.method_18();
				if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
				}
				this.GetCB_AltOverride().Checked = true;
				if (!Information.IsNothing(this.HookedUnit))
				{
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x002644F0 File Offset: 0x002626F0
		private void method_16()
		{
			if (!(Information.IsNothing(this.HookedUnit) & Information.IsNothing(Client.GetWayPointSelected())) || !Information.IsNothing(this.waypoint_0))
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDSO(Client.GetWayPointSelected().DesiredSpeed);
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDSO(this.waypoint_0.DesiredSpeed);
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					Scenario clientScenario = Client.GetClientScenario();
					Mission mission = this.m_Mission;
					ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					Mission.Flight flight = this.m_Flight;
					Mission.Flight flight2;
					Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
					Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
					float num = 0f;
					StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight2.SetFlightCourse(flightCourse);
					Client.b_Completed = true;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetKinematics().SetDesiredSpeedOverride(new float?(this.HookedUnit.GetDesiredSpeed()));
				}
				this.method_17();
				if (!Information.IsNothing(this.HookedUnit))
				{
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
				}
				this.vmethod_38().Checked = true;
				if (!Information.IsNothing(this.HookedUnit))
				{
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x002646D4 File Offset: 0x002628D4
		private void method_17()
		{
			if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
			{
				Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
			}
			else if (!Information.IsNothing(this.HookedUnit))
			{
				this.HookedUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
			}
			this.vmethod_84().Checked = false;
			this.vmethod_82().Checked = false;
			this.vmethod_80().Checked = false;
			this.vmethod_78().Checked = false;
			this.vmethod_86().Checked = false;
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x00264784 File Offset: 0x00262984
		private void method_18()
		{
			if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
			{
				Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.None);
				Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.None);
				this.GetRB_Surface().Checked = false;
				this.GetRB_Periscope().Checked = false;
				this.GetRB_Shallow().Checked = false;
				this.GetRB_OverLayer().Checked = false;
				this.GetRB_UnderLayer().Checked = false;
				this.GetRB_MaxDepth().Checked = false;
				this.GetRB_MaxAltitude().Checked = false;
				this.GetRB_HighAltitude36000().Checked = false;
				this.GetRB_HighAltitude25000().Checked = false;
				this.GetRB_MediumAltitude12000().Checked = false;
				this.GetRB_LowAltitude2000().Checked = false;
				this.GetRB_LowAltitude1000().Checked = false;
				this.GetRB_MinAltitude().Checked = false;
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.None);
				this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.None);
				this.GetRB_Surface().Checked = false;
				this.GetRB_Periscope().Checked = false;
				this.GetRB_Shallow().Checked = false;
				this.GetRB_OverLayer().Checked = false;
				this.GetRB_UnderLayer().Checked = false;
				this.GetRB_MaxDepth().Checked = false;
				this.GetRB_MaxAltitude().Checked = false;
				this.GetRB_HighAltitude36000().Checked = false;
				this.GetRB_HighAltitude25000().Checked = false;
				this.GetRB_MediumAltitude12000().Checked = false;
				this.GetRB_LowAltitude2000().Checked = false;
				this.GetRB_LowAltitude1000().Checked = false;
				this.GetRB_MinAltitude().Checked = false;
			}
			else if (!Information.IsNothing(this.HookedUnit))
			{
				if (this.HookedUnit.IsSubmarine)
				{
					((Submarine_AI)this.HookedUnit.GetAI()).SetDepthPreset(ActiveUnit_AI._DepthPreset.None);
					this.GetRB_Surface().Checked = false;
					this.GetRB_Periscope().Checked = false;
					this.GetRB_Shallow().Checked = false;
					this.GetRB_OverLayer().Checked = false;
					this.GetRB_UnderLayer().Checked = false;
					this.GetRB_MaxDepth().Checked = false;
				}
				if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)
				{
					((Group_AI)this.HookedUnit.GetAI()).method_88(ActiveUnit_AI._DepthPreset.None);
					this.GetRB_Surface().Checked = false;
					this.GetRB_Periscope().Checked = false;
					this.GetRB_Shallow().Checked = false;
					this.GetRB_OverLayer().Checked = false;
					this.GetRB_UnderLayer().Checked = false;
					this.GetRB_MaxDepth().Checked = false;
				}
				if (this.HookedUnit.IsAircraft)
				{
					((Aircraft_AI)this.HookedUnit.GetAI()).SetAltitudePreset(ActiveUnit_AI._AltitudePreset.None);
					this.GetRB_MaxAltitude().Checked = false;
					this.GetRB_HighAltitude36000().Checked = false;
					this.GetRB_HighAltitude25000().Checked = false;
					this.GetRB_MediumAltitude12000().Checked = false;
					this.GetRB_LowAltitude2000().Checked = false;
					this.GetRB_LowAltitude1000().Checked = false;
					this.GetRB_MinAltitude().Checked = false;
				}
				if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
				{
					((Group_AI)this.HookedUnit.GetAI()).method_89(ActiveUnit_AI._AltitudePreset.None);
					this.GetRB_MaxAltitude().Checked = false;
					this.GetRB_HighAltitude36000().Checked = false;
					this.GetRB_HighAltitude25000().Checked = false;
					this.GetRB_MediumAltitude12000().Checked = false;
					this.GetRB_LowAltitude2000().Checked = false;
					this.GetRB_LowAltitude1000().Checked = false;
					this.GetRB_MinAltitude().Checked = false;
				}
			}
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x00264B44 File Offset: 0x00262D44
		private void method_19(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_Surface().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.Surface);
					Client.GetWayPointSelected().method_25();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.Surface);
					this.waypoint_0.method_25();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.HookedUnit.GetAI();
						submarine_AI.SetDepthPreset(ActiveUnit_AI._DepthPreset.Surface);
						submarine_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_88(ActiveUnit_AI._DepthPreset.Surface);
						group_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00264D14 File Offset: 0x00262F14
		private void method_20(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_Periscope().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.Periscope);
					Client.GetWayPointSelected().method_25();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.Periscope);
					this.waypoint_0.method_25();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.HookedUnit.GetAI();
						submarine_AI.SetDepthPreset(ActiveUnit_AI._DepthPreset.Periscope);
						submarine_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_88(ActiveUnit_AI._DepthPreset.Periscope);
						group_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00264EE4 File Offset: 0x002630E4
		private void method_21(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_Shallow().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.Shallow);
					Client.GetWayPointSelected().method_25();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.Shallow);
					this.waypoint_0.method_25();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.HookedUnit.GetAI();
						submarine_AI.SetDepthPreset(ActiveUnit_AI._DepthPreset.Shallow);
						submarine_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_88(ActiveUnit_AI._DepthPreset.Shallow);
						group_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x002650B4 File Offset: 0x002632B4
		private void method_22(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_OverLayer().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.OverLayer);
					Client.GetWayPointSelected().method_25();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.OverLayer);
					this.waypoint_0.method_25();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.HookedUnit.GetAI();
						submarine_AI.SetDepthPreset(ActiveUnit_AI._DepthPreset.OverLayer);
						submarine_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_88(ActiveUnit_AI._DepthPreset.OverLayer);
						group_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x00265284 File Offset: 0x00263484
		private void method_23(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_UnderLayer().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.UnderLayer);
					Client.GetWayPointSelected().method_25();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.UnderLayer);
					this.waypoint_0.method_25();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.HookedUnit.GetAI();
						submarine_AI.SetDepthPreset(ActiveUnit_AI._DepthPreset.UnderLayer);
						submarine_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_88(ActiveUnit_AI._DepthPreset.UnderLayer);
						group_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x00265454 File Offset: 0x00263654
		private void method_24(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_MaxDepth().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.MaxDepth);
					Client.GetWayPointSelected().method_25();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.MaxDepth);
					this.waypoint_0.method_25();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsSubmarine)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.HookedUnit.GetAI();
						submarine_AI.SetDepthPreset(ActiveUnit_AI._DepthPreset.MaxDepth);
						submarine_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_88(ActiveUnit_AI._DepthPreset.MaxDepth);
						group_AI.SetDesiredDepth(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00265624 File Offset: 0x00263824
		private void method_25(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsSubmarine || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.SubGroup)) && this.GetRB_NoDepthPreset().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDepthPreset(ActiveUnit_AI._DepthPreset.None);
					Client.GetWayPointSelected().DesiredAltitude = null;
					Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDepthPreset(ActiveUnit_AI._DepthPreset.None);
					this.waypoint_0.DesiredAltitude = null;
					this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
				}
			}
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x00265710 File Offset: 0x00263910
		private void method_26(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_MaxAltitude().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MaxAltitude);
					Client.GetWayPointSelected().DesiredAltitude = null;
					Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MaxAltitude);
					this.waypoint_0.DesiredAltitude = null;
					this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MaxAltitude);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_89(ActiveUnit_AI._AltitudePreset.MaxAltitude);
						group_AI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00265908 File Offset: 0x00263B08
		private void method_27(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_NoAltitudePreset().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.None);
					Client.GetWayPointSelected().DesiredAltitude = null;
					Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.None);
					this.waypoint_0.DesiredAltitude = null;
					this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
				}
			}
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x002659F4 File Offset: 0x00263BF4
		private void method_28(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_HighAltitude36000().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.HighAltitude36000);
					Client.GetWayPointSelected().method_24();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.HighAltitude36000);
					this.waypoint_0.method_24();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.HighAltitude36000);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI arg_147_0 = (Group_AI)this.HookedUnit.GetAI();
						((Group_AI)this.HookedUnit.GetAI()).method_89(ActiveUnit_AI._AltitudePreset.HighAltitude36000);
						((Group_AI)this.HookedUnit.GetAI()).SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00265BE0 File Offset: 0x00263DE0
		private void method_29(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_HighAltitude25000().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.HighAltitude25000);
					Client.GetWayPointSelected().method_24();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.HighAltitude25000);
					this.waypoint_0.method_24();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.HighAltitude25000);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI arg_147_0 = (Group_AI)this.HookedUnit.GetAI();
						((Group_AI)this.HookedUnit.GetAI()).method_89(ActiveUnit_AI._AltitudePreset.HighAltitude25000);
						((Group_AI)this.HookedUnit.GetAI()).SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00265DCC File Offset: 0x00263FCC
		private void method_30(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_MediumAltitude12000().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MediumAltitude12000);
					Client.GetWayPointSelected().method_24();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MediumAltitude12000);
					this.waypoint_0.method_24();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MediumAltitude12000);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI arg_147_0 = (Group_AI)this.HookedUnit.GetAI();
						((Group_AI)this.HookedUnit.GetAI()).method_89(ActiveUnit_AI._AltitudePreset.MediumAltitude12000);
						((Group_AI)this.HookedUnit.GetAI()).SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x00265FB8 File Offset: 0x002641B8
		private void method_31(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_LowAltitude2000().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.LowAltitude2000);
					Client.GetWayPointSelected().method_24();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.LowAltitude2000);
					this.waypoint_0.method_24();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.LowAltitude2000);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI arg_147_0 = (Group_AI)this.HookedUnit.GetAI();
						((Group_AI)this.HookedUnit.GetAI()).method_89(ActiveUnit_AI._AltitudePreset.LowAltitude2000);
						((Group_AI)this.HookedUnit.GetAI()).SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x002661A4 File Offset: 0x002643A4
		private void method_32(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_LowAltitude1000().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.LowAltitude1000);
					Client.GetWayPointSelected().method_24();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.LowAltitude1000);
					this.waypoint_0.method_24();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.LowAltitude1000);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_89(ActiveUnit_AI._AltitudePreset.LowAltitude1000);
						group_AI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00266370 File Offset: 0x00264570
		private void method_33(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.waypoint_0) || this.HookedUnit.IsAircraft || (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.GetRB_MinAltitude().Checked)
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MinAltitude);
					Client.GetWayPointSelected().method_24();
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MinAltitude);
					this.waypoint_0.method_24();
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						Aircraft_AI aircraftAI = ((Aircraft)this.HookedUnit).GetAircraftAI();
						aircraftAI.SetAltitudePreset(ActiveUnit_AI._AltitudePreset.MinAltitude);
						aircraftAI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					else if (this.HookedUnit.IsGroup)
					{
						Group_AI group_AI = (Group_AI)this.HookedUnit.GetAI();
						group_AI.method_89(ActiveUnit_AI._AltitudePreset.MinAltitude);
						group_AI.SetDesiredAltitude();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.HookedUnit.GetDesiredAltitude(), (float)this.vmethod_16().Minimum));
					}
					this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
			}
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00027CBF File Offset: 0x00025EBF
		private void method_34(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00027CC8 File Offset: 0x00025EC8
		private void method_35(object sender, EventArgs e)
		{
			this.method_37();
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00027CBF File Offset: 0x00025EBF
		private void method_36(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x0026653C File Offset: 0x0026473C
		private void method_37()
		{
			if (this.bool_0)
			{
				this.method_17();
				if (Operators.CompareString(this.vmethod_70().Text, "", false) == 0 && !Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDSO(null);
					Client.GetWayPointSelected().DesiredSpeed = null;
					this.vmethod_38().Checked = false;
					Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
					this.method_17();
				}
				else if (Operators.CompareString(this.vmethod_70().Text, "", false) == 0 && !Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDSO(null);
					this.waypoint_0.DesiredSpeed = null;
					this.vmethod_38().Checked = false;
					this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					this.method_17();
				}
				else if ((Versioned.IsNumeric(this.vmethod_70().Text) || Information.IsNothing(Client.GetWayPointSelected()) || !Information.IsNothing(this.waypoint_0)) && (Versioned.IsNumeric(this.vmethod_70().Text) || Information.IsNothing(this.waypoint_0)) && (Operators.CompareString(this.vmethod_70().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_70().Text)))
				{
					int num = Conversions.ToInteger(this.vmethod_70().Text);
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						Client.GetWayPointSelected().DesiredSpeed = new float?((float)num);
						Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_1;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.waypoint_0.DesiredSpeed = new float?((float)num);
						this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_1;
					}
					else if (!Information.IsNothing(this.HookedUnit))
					{
						if (num > Math.Max(this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), this.HookedUnit.GetMaxThrottleAvailable()), this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetDesiredAltitude())))
						{
							num = Math.Max(this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), this.HookedUnit.GetMaxThrottleAvailable()), this.HookedUnit.GetKinematics().GetSpeed(this.HookedUnit.GetDesiredAltitude()));
						}
						if (this.HookedUnit.IsAircraft)
						{
							if (!((Aircraft)this.HookedUnit).IsRotaryWing(false) && num < ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter))
							{
								num = ((Aircraft)this.HookedUnit).GetAircraftKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter);
							}
						}
						else if (this.HookedUnit.IsWeapon)
						{
							if (num < ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise))
							{
								num = ((Weapon)this.HookedUnit).GetWeaponKinematics().GetSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise);
							}
						}
						else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
						{
							if (Information.IsNothing(((Group)this.HookedUnit).GetGroupLead()))
							{
								return;
							}
							Aircraft aircraft = (Aircraft)((Group)this.HookedUnit).GetGroupLead();
							if (!aircraft.IsRotaryWing(false) && num < aircraft.GetAircraftKinematics().GetSpeed(aircraft.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter))
							{
								num = aircraft.GetAircraftKinematics().GetSpeed(aircraft.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter);
							}
						}
						else if (num < (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false))))
						{
							num = (int)Math.Round((double)this.HookedUnit.GetKinematics().GetMinSpeed(this.HookedUnit.GetCurrentAltitude_ASL(false)));
						}
						this.HookedUnit.SetDesiredSpeed((float)num);
					}
					this.method_16();
				}
			}
			this.bool_0 = false;
			this.method_3();
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00027CD0 File Offset: 0x00025ED0
		private void method_38(object sender, EventArgs e)
		{
			this.method_39();
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x002669DC File Offset: 0x00264BDC
		private void method_39()
		{
			if (this.bool_0)
			{
				this.method_18();
				if (Operators.CompareString(this.vmethod_74().Text, "", false) == 0 && !Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDAO(false);
					Client.GetWayPointSelected().DesiredAltitude = null;
					Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
				}
				else if (Operators.CompareString(this.vmethod_74().Text, "", false) == 0 && !Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDAO(false);
					this.waypoint_0.DesiredAltitude = null;
					this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
				}
				else if ((Versioned.IsNumeric(this.vmethod_74().Text) || Information.IsNothing(Client.GetWayPointSelected()) || !Information.IsNothing(this.waypoint_0)) && (Versioned.IsNumeric(this.vmethod_74().Text) || Information.IsNothing(this.waypoint_0)) && (Operators.CompareString(this.vmethod_74().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_74().Text)))
				{
					float num = Conversions.ToSingle(this.vmethod_74().Text);
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						num /= 3.28084f;
						num = (float)Math.Round((double)num, 1);
					}
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						if (Client.GetWayPointSelected().IsTerrainFollowing())
						{
							Client.GetWayPointSelected().DesiredAltitude = null;
							Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = new float?(num);
						}
						else
						{
							Client.GetWayPointSelected().DesiredAltitude = new float?(num);
							Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						if (this.waypoint_0.IsTerrainFollowing())
						{
							this.waypoint_0.DesiredAltitude = null;
							this.waypoint_0.DesiredAltitude_TerrainFollowing = new float?(num);
						}
						else
						{
							this.waypoint_0.DesiredAltitude = new float?(num);
							this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
						}
					}
					else if (!Information.IsNothing(this.HookedUnit))
					{
						float maxAltitude = this.HookedUnit.GetKinematics().GetMaxAltitude();
						float minAltitude = this.HookedUnit.GetKinematics().GetMinAltitude();
						if (num < minAltitude)
						{
							num = minAltitude;
						}
						if (num > maxAltitude)
						{
							num = maxAltitude;
						}
						this.HookedUnit.SetDesiredAltitude(num);
						if (this.HookedUnit.IsTerrainFollowing(this.HookedUnit))
						{
							this.HookedUnit.SetDesiredAltitude_TerrainFollowing(num);
						}
						else
						{
							this.HookedUnit.SetDesiredAltitude(num);
						}
					}
					this.method_15();
				}
			}
			this.bool_0 = false;
			this.method_3();
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00025FB9 File Offset: 0x000241B9
		private void method_40(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00025FB9 File Offset: 0x000241B9
		private void method_41(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00266CEC File Offset: 0x00264EEC
		private void SpeedAlt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F2 && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Space))
			{
				if ((this.bool_0 || this.bool_1) && (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12))
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (!this.bool_0 && !this.bool_1)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00266E58 File Offset: 0x00265058
		private void method_42(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.HookedUnit) || !Information.IsNothing(this.waypoint_0)))
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetDAO(this.GetCB_AltOverride().Checked);
					if (Information.IsNothing(this.waypoint_0.DesiredAltitude))
					{
						this.waypoint_0.DesiredAltitude = new float?(0f);
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetDAO(this.GetCB_AltOverride().Checked);
					if (Information.IsNothing(this.waypoint_0.DesiredAltitude))
					{
						this.waypoint_0.DesiredAltitude = new float?(0f);
					}
				}
				else
				{
					this.HookedUnit.GetKinematics().SetDesiredAltitudeOverride(this.GetCB_AltOverride().Checked);
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
				if (!this.GetCB_AltOverride().Checked)
				{
					this.method_18();
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						Client.GetWayPointSelected().DesiredAltitude = null;
						Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.waypoint_0.DesiredAltitude = null;
						this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
					}
					else
					{
						this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					}
				}
				if (Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
				this.method_3();
			}
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x00267078 File Offset: 0x00265278
		private void method_43(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.HookedUnit) || !Information.IsNothing(this.waypoint_0)))
			{
				if (this.vmethod_38().Checked)
				{
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						if (Client.GetWayPointSelected().DesiredSpeed.HasValue)
						{
							Client.GetWayPointSelected().SetDSO(Client.GetWayPointSelected().DesiredSpeed);
						}
						else
						{
							this.waypoint_0.DesiredSpeed = new float?(0f);
							this.waypoint_0.SetDSO(this.waypoint_0.DesiredSpeed);
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						if (this.waypoint_0.DesiredSpeed.HasValue)
						{
							this.waypoint_0.SetDSO(this.waypoint_0.DesiredSpeed);
						}
						else
						{
							this.waypoint_0.DesiredSpeed = new float?(0f);
							this.waypoint_0.SetDSO(this.waypoint_0.DesiredSpeed);
						}
					}
					else
					{
						this.HookedUnit.GetKinematics().SetDesiredSpeedOverride(new float?(this.HookedUnit.GetDesiredSpeed()));
					}
				}
				else
				{
					this.method_17();
					if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
					{
						Client.GetWayPointSelected().SpeedFixed = Waypoint.Enum52.const_0;
						Client.GetWayPointSelected().SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
						Client.GetWayPointSelected().SetDSO(null);
						Client.GetWayPointSelected().DesiredSpeed = null;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.waypoint_0.SpeedFixed = Waypoint.Enum52.const_0;
						this.waypoint_0.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
						this.waypoint_0.SetDSO(null);
						this.waypoint_0.DesiredSpeed = null;
						Scenario clientScenario = Client.GetClientScenario();
						Mission mission = this.m_Mission;
						ActiveUnit referenceUnit = this.m_Flight.GetReferenceUnit(Client.GetClientScenario());
						Mission.Flight flight = this.m_Flight;
						Mission.Flight flight2;
						Waypoint[] flightCourse = (flight2 = this.m_Flight).GetFlightCourse();
						Mission.Enum60 bingo = ((Strike)this.m_Mission).Bingo;
						float num = 0f;
						StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
						flight2.SetFlightCourse(flightCourse);
						Client.b_Completed = true;
					}
					else
					{
						this.HookedUnit.GetKinematics().SetDesiredSpeedOverride(null);
						this.HookedUnit.GetAI().method_18(ref this.HookedUnit);
					}
				}
				if (Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), this.HookedUnit, false);
				}
				this.method_3();
			}
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x00027CD8 File Offset: 0x00025ED8
		private void method_44(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x0026739C File Offset: 0x0026559C
		private void method_45(object sender, EventArgs e)
		{
			switch (this.GetCB_WaypointType().SelectedIndex)
			{
			case 0:
				Client.GetWayPointSelected().waypointType = Waypoint.WaypointType.Assemble;
				break;
			case 1:
				Client.GetWayPointSelected().waypointType = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
				break;
			case 2:
				Client.GetWayPointSelected().waypointType = Waypoint.WaypointType.Target;
				break;
			}
			this.bool_1 = false;
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00027CD8 File Offset: 0x00025ED8
		private void method_46(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00027CE1 File Offset: 0x00025EE1
		private void method_47(object sender, EventArgs e)
		{
			this.method_48();
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x002673F8 File Offset: 0x002655F8
		private void method_48()
		{
			if (this.bool_1)
			{
				if (Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().Description = this.vmethod_100().Text;
				}
				else
				{
					this.waypoint_0.Description = this.vmethod_100().Text;
				}
			}
			this.bool_1 = false;
			this.method_3();
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00027CE9 File Offset: 0x00025EE9
		private void SpeedAlt_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_49();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x0026745C File Offset: 0x0026565C
		private void method_49()
		{
			if (this.vmethod_74().Focused)
			{
				this.method_39();
			}
			if (this.vmethod_70().Focused)
			{
				this.method_37();
			}
			if (this.vmethod_100().Focused)
			{
				this.method_48();
			}
			checked
			{
				if (!Information.IsNothing(this.waypoint_0) || !Information.IsNothing(Client.GetWayPointSelected()))
				{
					bool flag = false;
					Waypoint wayPointSelected;
					if (!Information.IsNothing(this.waypoint_0))
					{
						wayPointSelected = this.waypoint_0;
					}
					else
					{
						wayPointSelected = Client.GetWayPointSelected();
					}
					if (wayPointSelected.Category == Waypoint._Category.const_1)
					{
						Side[] sides = Client.GetClientScenario().GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							foreach (Mission current in side.GetMissionCollection())
							{
								foreach (Mission.Flight current2 in current.FlightList)
								{
									if (current2.GetFlightCourse().Contains(wayPointSelected))
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
				this.vmethod_38().Select();
			}
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00027D00 File Offset: 0x00025F00
		private void SpeedAlt_FormClosed(object sender, FormClosedEventArgs e)
		{
			Client.smethod_18(new Client.Delegate52(this.method_2));
			Client.smethod_20(new Client.Delegate53(this.method_2));
			this.waypoint_0 = null;
			this.HookedUnit = null;
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x002676A4 File Offset: 0x002658A4
		private void method_50(object sender, EventArgs e)
		{
			if (this.bool_2 && (!Information.IsNothing(this.HookedUnit) || !Information.IsNothing(this.waypoint_0)))
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()) && Information.IsNothing(this.waypoint_0))
				{
					Client.GetWayPointSelected().SetIsTerrainFollowing(this.vmethod_142().Checked);
					if (Client.GetWayPointSelected().IsTerrainFollowing())
					{
						Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = Client.GetWayPointSelected().DesiredAltitude;
						Client.GetWayPointSelected().DesiredAltitude = null;
					}
					else
					{
						Client.GetWayPointSelected().DesiredAltitude = Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing;
						Client.GetWayPointSelected().DesiredAltitude_TerrainFollowing = null;
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.SetIsTerrainFollowing(this.vmethod_142().Checked);
					if (this.waypoint_0.IsTerrainFollowing())
					{
						this.waypoint_0.DesiredAltitude_TerrainFollowing = this.waypoint_0.DesiredAltitude;
						this.waypoint_0.DesiredAltitude = null;
					}
					else
					{
						this.waypoint_0.DesiredAltitude = this.waypoint_0.DesiredAltitude_TerrainFollowing;
						this.waypoint_0.DesiredAltitude_TerrainFollowing = null;
					}
				}
				else if (!Information.IsNothing(this.HookedUnit))
				{
					if (this.HookedUnit.IsAircraft)
					{
						this.HookedUnit.SetIsTerrainFollowing(this.HookedUnit, this.vmethod_142().Checked);
					}
					else if (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup)
					{
						Group group = (Group)this.HookedUnit;
						if (!Information.IsNothing(group.IsGroupLead()))
						{
							group.GetGroupLead().SetIsTerrainFollowing(group.GetGroupLead(), this.vmethod_142().Checked);
						}
					}
					if (this.HookedUnit.IsAircraft | (this.HookedUnit.IsGroup && ((Group)this.HookedUnit).GetGroupType() == Group.GroupType.AirGroup))
					{
						if (this.HookedUnit.IsTerrainFollowing(this.HookedUnit))
						{
							if (this.HookedUnit.GetDesiredAltitude() > 0f)
							{
								this.HookedUnit.SetDesiredAltitude_TerrainFollowing(this.HookedUnit.GetDesiredAltitude());
							}
							else if (!this.HookedUnit.IsNotGroupLead())
							{
								this.HookedUnit.SetDesiredAltitude_TerrainFollowing(200f);
							}
							else if (!Information.IsNothing(this.HookedUnit.GetParentGroup(false).GetGroupLead()))
							{
								if (this.HookedUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing() > 0f)
								{
									this.HookedUnit.SetDesiredAltitude_TerrainFollowing(this.HookedUnit.GetParentGroup(false).GetGroupLead().GetDesiredAltitude_TerrainFollowing());
								}
								else
								{
									this.HookedUnit.SetDesiredAltitude_TerrainFollowing(200f);
								}
							}
						}
						else
						{
							float num = this.HookedUnit.GetDesiredAltitude_TerrainFollowing();
							float maxAltitude = this.HookedUnit.GetKinematics().GetMaxAltitude();
							float minAltitude = this.HookedUnit.GetKinematics().GetMinAltitude();
							if (num < minAltitude)
							{
								num = minAltitude;
							}
							if (num > maxAltitude)
							{
								num = maxAltitude;
							}
							this.HookedUnit.SetDesiredAltitude(num);
						}
					}
				}
			}
		}

		// Token: 0x04002ADC RID: 10972
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x04002ADD RID: 10973
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002ADE RID: 10974
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002ADF RID: 10975
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002AE0 RID: 10976
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002AE1 RID: 10977
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002AE2 RID: 10978
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04002AE3 RID: 10979
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04002AE4 RID: 10980
		[CompilerGenerated]
		private TrackBar trackBar_1;

		// Token: 0x04002AE5 RID: 10981
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04002AE6 RID: 10982
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04002AE7 RID: 10983
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04002AE8 RID: 10984
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x04002AE9 RID: 10985
		[CompilerGenerated]
		private Label label_10;

		// Token: 0x04002AEA RID: 10986
		[CompilerGenerated]
		private Label label_11;

		// Token: 0x04002AEB RID: 10987
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04002AEC RID: 10988
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x04002AED RID: 10989
		[CompilerGenerated]
		private GroupBox groupBox_2;

		// Token: 0x04002AEE RID: 10990
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002AEF RID: 10991
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002AF0 RID: 10992
		[CompilerGenerated]
		private GroupBox groupBox_3;

		// Token: 0x04002AF1 RID: 10993
		[CompilerGenerated]
		private RadioButton radioButton_0;

		// Token: 0x04002AF2 RID: 10994
		[CompilerGenerated]
		private RadioButton radioButton_1;

		// Token: 0x04002AF3 RID: 10995
		[CompilerGenerated]
		private RadioButton radioButton_2;

		// Token: 0x04002AF4 RID: 10996
		[CompilerGenerated]
		private RadioButton radioButton_3;

		// Token: 0x04002AF5 RID: 10997
		[CompilerGenerated]
		private RadioButton radioButton_4;

		// Token: 0x04002AF6 RID: 10998
		[CompilerGenerated]
		private GroupBox groupBox_4;

		// Token: 0x04002AF7 RID: 10999
		[CompilerGenerated]
		private RadioButton radioButton_5;

		// Token: 0x04002AF8 RID: 11000
		[CompilerGenerated]
		private RadioButton radioButton_6;

		// Token: 0x04002AF9 RID: 11001
		[CompilerGenerated]
		private RadioButton radioButton_7;

		// Token: 0x04002AFA RID: 11002
		[CompilerGenerated]
		private RadioButton radioButton_8;

		// Token: 0x04002AFB RID: 11003
		[CompilerGenerated]
		private RadioButton radioButton_9;

		// Token: 0x04002AFC RID: 11004
		[CompilerGenerated]
		private RadioButton radioButton_10;

		// Token: 0x04002AFD RID: 11005
		[CompilerGenerated]
		private RadioButton radioButton_11;

		// Token: 0x04002AFE RID: 11006
		[CompilerGenerated]
		private RadioButton radioButton_12;

		// Token: 0x04002AFF RID: 11007
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002B00 RID: 11008
		[CompilerGenerated]
		private Label label_12;

		// Token: 0x04002B01 RID: 11009
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04002B02 RID: 11010
		[CompilerGenerated]
		private Label label_13;

		// Token: 0x04002B03 RID: 11011
		[CompilerGenerated]
		private RadioButton radioButton_13;

		// Token: 0x04002B04 RID: 11012
		[CompilerGenerated]
		private RadioButton radioButton_14;

		// Token: 0x04002B05 RID: 11013
		[CompilerGenerated]
		private RadioButton radioButton_15;

		// Token: 0x04002B06 RID: 11014
		[CompilerGenerated]
		private RadioButton radioButton_16;

		// Token: 0x04002B07 RID: 11015
		[CompilerGenerated]
		private RadioButton radioButton_17;

		// Token: 0x04002B08 RID: 11016
		[CompilerGenerated]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04002B09 RID: 11017
		[CompilerGenerated]
		private Label label_14;

		// Token: 0x04002B0A RID: 11018
		[CompilerGenerated]
		private GroupBox groupBox_5;

		// Token: 0x04002B0B RID: 11019
		[CompilerGenerated]
		private Label label_15;

		// Token: 0x04002B0C RID: 11020
		[CompilerGenerated]
		private Label label_16;

		// Token: 0x04002B0D RID: 11021
		[CompilerGenerated]
		private Label label_17;

		// Token: 0x04002B0E RID: 11022
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x04002B0F RID: 11023
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04002B10 RID: 11024
		[CompilerGenerated]
		private Label label_18;

		// Token: 0x04002B11 RID: 11025
		[CompilerGenerated]
		private Label label_19;

		// Token: 0x04002B12 RID: 11026
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x04002B13 RID: 11027
		[CompilerGenerated]
		private PictureBox pictureBox_1;

		// Token: 0x04002B14 RID: 11028
		[CompilerGenerated]
		private PictureBox pictureBox_2;

		// Token: 0x04002B15 RID: 11029
		[CompilerGenerated]
		private PictureBox pictureBox_3;

		// Token: 0x04002B16 RID: 11030
		[CompilerGenerated]
		private PictureBox pictureBox_4;

		// Token: 0x04002B17 RID: 11031
		[CompilerGenerated]
		private Label label_20;

		// Token: 0x04002B18 RID: 11032
		[CompilerGenerated]
		private Label label_21;

		// Token: 0x04002B19 RID: 11033
		[CompilerGenerated]
		private Label label_22;

		// Token: 0x04002B1A RID: 11034
		[CompilerGenerated]
		private Label label_23;

		// Token: 0x04002B1B RID: 11035
		[CompilerGenerated]
		private PictureBox pictureBox_5;

		// Token: 0x04002B1C RID: 11036
		[CompilerGenerated]
		private PictureBox pictureBox_6;

		// Token: 0x04002B1D RID: 11037
		[CompilerGenerated]
		private PictureBox pictureBox_7;

		// Token: 0x04002B1E RID: 11038
		[CompilerGenerated]
		private Label label_24;

		// Token: 0x04002B1F RID: 11039
		[CompilerGenerated]
		private Label label_25;

		// Token: 0x04002B20 RID: 11040
		[CompilerGenerated]
		private Label label_26;

		// Token: 0x04002B21 RID: 11041
		[CompilerGenerated]
		private Label label_27;

		// Token: 0x04002B22 RID: 11042
		[CompilerGenerated]
		private Label label_28;

		// Token: 0x04002B23 RID: 11043
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04002B24 RID: 11044
		[CompilerGenerated]
		private ShapeContainer shapeContainer_0;

		// Token: 0x04002B25 RID: 11045
		[CompilerGenerated]
		private LineShape lineShape_0;

		// Token: 0x04002B26 RID: 11046
		[CompilerGenerated]
		private LineShape lineShape_1;

		// Token: 0x04002B27 RID: 11047
		[CompilerGenerated]
		private RadioButton radioButton_18;

		// Token: 0x04002B28 RID: 11048
		[CompilerGenerated]
		private RadioButton radioButton_19;

		// Token: 0x04002B29 RID: 11049
		[CompilerGenerated]
		private RadioButton radioButton_20;

		// Token: 0x04002B2A RID: 11050
		public ActiveUnit HookedUnit;

		// Token: 0x04002B2B RID: 11051
		public Waypoint waypoint_0;

		// Token: 0x04002B2C RID: 11052
		public Mission.Flight m_Flight;

		// Token: 0x04002B2D RID: 11053
		public Mission m_Mission;

		// Token: 0x04002B2E RID: 11054
		private bool bool_0;

		// Token: 0x04002B2F RID: 11055
		private bool bool_1;

		// Token: 0x04002B30 RID: 11056
		private bool bool_2;
	}
}
