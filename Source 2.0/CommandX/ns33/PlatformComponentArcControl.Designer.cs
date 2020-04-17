using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns33
{
	// Token: 0x0200097B RID: 2427
	[DesignerGenerated]
	public sealed class PlatformComponentArcControl : UserControl
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x0001FAD9 File Offset: 0x0001DCD9
		public PlatformComponentArcControl()
		{
			base.DoubleClick += new EventHandler(this.PlatformComponentArcControl_DoubleClick);
			base.Load += new EventHandler(this.PlatformComponentArcControl_Load);
			this.struct19_0 = default(PlatformComponent._CoverageArc);
			this.InitializeComponent();
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0012B3FC File Offset: 0x001295FC
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0012B440 File Offset: 0x00129640
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PlatformComponentArcControl));
			this.vmethod_1(new CheckBox());
			this.vmethod_3(new CheckBox());
			this.vmethod_5(new CheckBox());
			this.vmethod_7(new CheckBox());
			this.vmethod_9(new CheckBox());
			this.vmethod_11(new CheckBox());
			this.vmethod_13(new CheckBox());
			this.vmethod_15(new CheckBox());
			this.vmethod_17(new CheckBox());
			this.vmethod_19(new CheckBox());
			this.vmethod_21(new CheckBox());
			this.vmethod_23(new CheckBox());
			this.vmethod_25(new CheckBox());
			this.vmethod_27(new CheckBox());
			this.vmethod_29(new CheckBox());
			this.vmethod_31(new CheckBox());
			this.vmethod_33(new PictureBox());
			((ISupportInitialize)this.vmethod_32()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(20, 8);
			this.vmethod_0().Name = "CB_PB1";
			this.vmethod_0().Size = new Size(15, 14);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().Location = new Point(34, 4);
			this.vmethod_2().Name = "CB_PB2";
			this.vmethod_2().Size = new Size(15, 14);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Location = new Point(48, 4);
			this.vmethod_4().Name = "CB_SB1";
			this.vmethod_4().Size = new Size(15, 14);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().Location = new Point(62, 7);
			this.vmethod_6().Name = "CB_SB2";
			this.vmethod_6().Size = new Size(15, 14);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Location = new Point(5, 36);
			this.vmethod_8().Name = "CB_PMF1";
			this.vmethod_8().Size = new Size(15, 14);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Location = new Point(9, 22);
			this.vmethod_10().Name = "CB_PMF2";
			this.vmethod_10().Size = new Size(15, 14);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Location = new Point(78, 35);
			this.vmethod_12().Name = "CB_SMF2";
			this.vmethod_12().Size = new Size(15, 14);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Location = new Point(72, 21);
			this.vmethod_14().Name = "CB_SMF1";
			this.vmethod_14().Size = new Size(15, 14);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_16().Location = new Point(5, 51);
			this.vmethod_16().Name = "CB_PMA2";
			this.vmethod_16().Size = new Size(15, 14);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().UseVisualStyleBackColor = true;
			this.vmethod_18().Location = new Point(9, 65);
			this.vmethod_18().Name = "CB_PMA1";
			this.vmethod_18().Size = new Size(15, 14);
			this.vmethod_18().TabIndex = 10;
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_20().Location = new Point(20, 79);
			this.vmethod_20().Name = "CB_PS2";
			this.vmethod_20().Size = new Size(15, 14);
			this.vmethod_20().TabIndex = 11;
			this.vmethod_20().UseVisualStyleBackColor = true;
			this.vmethod_22().Location = new Point(34, 82);
			this.vmethod_22().Name = "CB_PS1";
			this.vmethod_22().Size = new Size(15, 14);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_22().UseVisualStyleBackColor = true;
			this.vmethod_24().Location = new Point(49, 82);
			this.vmethod_24().Name = "CB_SS2";
			this.vmethod_24().Size = new Size(15, 14);
			this.vmethod_24().TabIndex = 13;
			this.vmethod_24().UseVisualStyleBackColor = true;
			this.vmethod_26().Location = new Point(63, 77);
			this.vmethod_26().Name = "CB_SS1";
			this.vmethod_26().Size = new Size(15, 14);
			this.vmethod_26().TabIndex = 14;
			this.vmethod_26().UseVisualStyleBackColor = true;
			this.vmethod_28().Location = new Point(78, 49);
			this.vmethod_28().Name = "CB_SMA1";
			this.vmethod_28().Size = new Size(15, 14);
			this.vmethod_28().TabIndex = 15;
			this.vmethod_28().UseVisualStyleBackColor = true;
			this.vmethod_30().Location = new Point(72, 63);
			this.vmethod_30().Name = "CB_SMA2";
			this.vmethod_30().Size = new Size(15, 14);
			this.vmethod_30().TabIndex = 16;
			this.vmethod_30().UseVisualStyleBackColor = true;
            //ZSP RUN IMG this.vmethod_32().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
            this.vmethod_32().Location = new Point(22, 20);
			this.vmethod_32().Name = "PictureBox1";
			this.vmethod_32().Size = new Size(50, 61);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_32().TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_32());
			base.Name = "PlatformComponentArcControl";
			base.Size = new Size(100, 100);
			((ISupportInitialize)this.vmethod_32()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x0012BC00 File Offset: 0x00129E00
		[CompilerGenerated]
		internal  CheckBox vmethod_0()
		{
			return this.checkBox_0;
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0012BC18 File Offset: 0x00129E18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_10);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_16;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x0012BC64 File Offset: 0x00129E64
		[CompilerGenerated]
		internal  CheckBox vmethod_2()
		{
			return this.checkBox_1;
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x0012BC7C File Offset: 0x00129E7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_11);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_1 = checkBox_16;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x0012BCC8 File Offset: 0x00129EC8
		[CompilerGenerated]
		internal  CheckBox vmethod_4()
		{
			return this.checkBox_2;
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0012BCE0 File Offset: 0x00129EE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_2);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_2 = checkBox_16;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x0012BD2C File Offset: 0x00129F2C
		[CompilerGenerated]
		internal  CheckBox vmethod_6()
		{
			return this.checkBox_3;
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x0012BD44 File Offset: 0x00129F44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_3);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_3 = checkBox_16;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0012BD90 File Offset: 0x00129F90
		[CompilerGenerated]
		internal  CheckBox vmethod_8()
		{
			return this.checkBox_4;
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0012BDA8 File Offset: 0x00129FA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_12);
			CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_4 = checkBox_16;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x0012BDF4 File Offset: 0x00129FF4
		[CompilerGenerated]
		internal  CheckBox vmethod_10()
		{
			return this.checkBox_5;
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x0012BE0C File Offset: 0x0012A00C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_13);
			CheckBox checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_5 = checkBox_16;
			checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0012BE58 File Offset: 0x0012A058
		[CompilerGenerated]
		internal  CheckBox vmethod_12()
		{
			return this.checkBox_6;
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x0012BE70 File Offset: 0x0012A070
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_5);
			CheckBox checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_6 = checkBox_16;
			checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0012BEBC File Offset: 0x0012A0BC
		[CompilerGenerated]
		internal  CheckBox vmethod_14()
		{
			return this.checkBox_7;
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x0012BED4 File Offset: 0x0012A0D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_4);
			CheckBox checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_7 = checkBox_16;
			checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x0012BF20 File Offset: 0x0012A120
		[CompilerGenerated]
		internal  CheckBox vmethod_16()
		{
			return this.checkBox_8;
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x0012BF38 File Offset: 0x0012A138
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_15);
			CheckBox checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_8 = checkBox_16;
			checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x0012BF84 File Offset: 0x0012A184
		[CompilerGenerated]
		internal  CheckBox vmethod_18()
		{
			return this.checkBox_9;
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x0012BF9C File Offset: 0x0012A19C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_14);
			CheckBox checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_9 = checkBox_16;
			checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x0012BFE8 File Offset: 0x0012A1E8
		[CompilerGenerated]
		internal  CheckBox vmethod_20()
		{
			return this.checkBox_10;
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x0012C000 File Offset: 0x0012A200
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_17);
			CheckBox checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_10 = checkBox_16;
			checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x0012C04C File Offset: 0x0012A24C
		[CompilerGenerated]
		internal  CheckBox vmethod_22()
		{
			return this.checkBox_11;
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x0012C064 File Offset: 0x0012A264
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_16);
			CheckBox checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_11 = checkBox_16;
			checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x0012C0B0 File Offset: 0x0012A2B0
		[CompilerGenerated]
		internal  CheckBox vmethod_24()
		{
			return this.checkBox_12;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0012C0C8 File Offset: 0x0012A2C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_9);
			CheckBox checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_12 = checkBox_16;
			checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0012C114 File Offset: 0x0012A314
		[CompilerGenerated]
		internal  CheckBox vmethod_26()
		{
			return this.checkBox_13;
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x0012C12C File Offset: 0x0012A32C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_8);
			CheckBox checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_13 = checkBox_16;
			checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x0012C178 File Offset: 0x0012A378
		[CompilerGenerated]
		internal  CheckBox vmethod_28()
		{
			return this.checkBox_14;
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x0012C190 File Offset: 0x0012A390
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_6);
			CheckBox checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_14 = checkBox_16;
			checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x0012C1DC File Offset: 0x0012A3DC
		[CompilerGenerated]
		internal  CheckBox vmethod_30()
		{
			return this.checkBox_15;
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x0012C1F4 File Offset: 0x0012A3F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(CheckBox checkBox_16)
		{
			EventHandler value = new EventHandler(this.method_7);
			CheckBox checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_15 = checkBox_16;
			checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0012C240 File Offset: 0x0012A440
		[CompilerGenerated]
		internal  PictureBox vmethod_32()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x0012C258 File Offset: 0x0012A458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(PictureBox pictureBox_1)
		{
			EventHandler value = new EventHandler(this.method_21);
			PictureBox pictureBox = this.pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.DoubleClick -= value;
			}
			this.pictureBox_0 = pictureBox_1;
			pictureBox = this.pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.DoubleClick += value;
			}
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x0012C2A4 File Offset: 0x0012A4A4
		public bool method_0()
		{
			return !this.struct19_0.SB1 && !this.struct19_0.SB2 && !this.struct19_0.SMF1 && !this.struct19_0.SMF2 && !this.struct19_0.SMA1 && !this.struct19_0.SMA2 && !this.struct19_0.SS1 && !this.struct19_0.SS2 && !this.struct19_0.PB1 && !this.struct19_0.PB2 && !this.struct19_0.PMF1 && !this.struct19_0.PMF2 && !this.struct19_0.PMA1 && !this.struct19_0.PMA2 && !this.struct19_0.PS1 && !this.struct19_0.PS2;
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x0012C398 File Offset: 0x0012A598
		public bool method_1()
		{
			return this.struct19_0.SB1 && this.struct19_0.SB2 && this.struct19_0.SMF1 && this.struct19_0.SMF2 && this.struct19_0.SMA1 && this.struct19_0.SMA2 && this.struct19_0.SS1 && this.struct19_0.SS2 && this.struct19_0.PB1 && this.struct19_0.PB2 && this.struct19_0.PMF1 && this.struct19_0.PMF2 && this.struct19_0.PMA1 && this.struct19_0.PMA2 && this.struct19_0.PS1 && this.struct19_0.PS2;
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x0001FB17 File Offset: 0x0001DD17
		private void method_2(object sender, EventArgs e)
		{
			this.struct19_0.SB1 = this.vmethod_4().Checked;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x0001FB2F File Offset: 0x0001DD2F
		private void method_3(object sender, EventArgs e)
		{
			this.struct19_0.SB2 = this.vmethod_6().Checked;
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x0001FB47 File Offset: 0x0001DD47
		private void method_4(object sender, EventArgs e)
		{
			this.struct19_0.SMF1 = this.vmethod_14().Checked;
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x0001FB5F File Offset: 0x0001DD5F
		private void method_5(object sender, EventArgs e)
		{
			this.struct19_0.SMF2 = this.vmethod_12().Checked;
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x0001FB77 File Offset: 0x0001DD77
		private void method_6(object sender, EventArgs e)
		{
			this.struct19_0.SMA1 = this.vmethod_28().Checked;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x0001FB8F File Offset: 0x0001DD8F
		private void method_7(object sender, EventArgs e)
		{
			this.struct19_0.SMA2 = this.vmethod_30().Checked;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x0001FBA7 File Offset: 0x0001DDA7
		private void method_8(object sender, EventArgs e)
		{
			this.struct19_0.SS1 = this.vmethod_26().Checked;
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x0001FBBF File Offset: 0x0001DDBF
		private void method_9(object sender, EventArgs e)
		{
			this.struct19_0.SS2 = this.vmethod_24().Checked;
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x0001FBD7 File Offset: 0x0001DDD7
		private void method_10(object sender, EventArgs e)
		{
			this.struct19_0.PB1 = this.vmethod_0().Checked;
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x0001FBEF File Offset: 0x0001DDEF
		private void method_11(object sender, EventArgs e)
		{
			this.struct19_0.PB2 = this.vmethod_2().Checked;
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x0001FC07 File Offset: 0x0001DE07
		private void method_12(object sender, EventArgs e)
		{
			this.struct19_0.PMF1 = this.vmethod_8().Checked;
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x0001FC1F File Offset: 0x0001DE1F
		private void method_13(object sender, EventArgs e)
		{
			this.struct19_0.PMF2 = this.vmethod_10().Checked;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x0001FC37 File Offset: 0x0001DE37
		private void method_14(object sender, EventArgs e)
		{
			this.struct19_0.PMA1 = this.vmethod_18().Checked;
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x0001FC4F File Offset: 0x0001DE4F
		private void method_15(object sender, EventArgs e)
		{
			this.struct19_0.PMA2 = this.vmethod_16().Checked;
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x0001FC67 File Offset: 0x0001DE67
		private void method_16(object sender, EventArgs e)
		{
			this.struct19_0.PS1 = this.vmethod_22().Checked;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x0001FC7F File Offset: 0x0001DE7F
		private void method_17(object sender, EventArgs e)
		{
			this.struct19_0.PS2 = this.vmethod_20().Checked;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x0001FC97 File Offset: 0x0001DE97
		private void PlatformComponentArcControl_DoubleClick(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x0001FC9F File Offset: 0x0001DE9F
		private void method_18()
		{
			if (this.method_1())
			{
				this.method_20();
			}
			else
			{
				this.method_19();
			}
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x0012C488 File Offset: 0x0012A688
		private void method_19()
		{
			this.struct19_0.PB1 = true;
			this.struct19_0.PB2 = true;
			this.struct19_0.PMA1 = true;
			this.struct19_0.PMA2 = true;
			this.struct19_0.PMF1 = true;
			this.struct19_0.PMF2 = true;
			this.struct19_0.PS1 = true;
			this.struct19_0.PS2 = true;
			this.struct19_0.SB1 = true;
			this.struct19_0.SB2 = true;
			this.struct19_0.SMA1 = true;
			this.struct19_0.SMA2 = true;
			this.struct19_0.SMF1 = true;
			this.struct19_0.SMF2 = true;
			this.struct19_0.SS1 = true;
			this.struct19_0.SS2 = true;
			this.vmethod_0().Checked = true;
			this.vmethod_2().Checked = true;
			this.vmethod_18().Checked = true;
			this.vmethod_16().Checked = true;
			this.vmethod_8().Checked = true;
			this.vmethod_10().Checked = true;
			this.vmethod_22().Checked = true;
			this.vmethod_20().Checked = true;
			this.vmethod_4().Checked = true;
			this.vmethod_6().Checked = true;
			this.vmethod_28().Checked = true;
			this.vmethod_30().Checked = true;
			this.vmethod_14().Checked = true;
			this.vmethod_12().Checked = true;
			this.vmethod_26().Checked = true;
			this.vmethod_24().Checked = true;
			this.Refresh();
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x0012C61C File Offset: 0x0012A81C
		private void method_20()
		{
			this.struct19_0.PB1 = false;
			this.struct19_0.PB2 = false;
			this.struct19_0.PMA1 = false;
			this.struct19_0.PMA2 = false;
			this.struct19_0.PMF1 = false;
			this.struct19_0.PMF2 = false;
			this.struct19_0.PS1 = false;
			this.struct19_0.PS2 = false;
			this.struct19_0.SB1 = false;
			this.struct19_0.SB2 = false;
			this.struct19_0.SMA1 = false;
			this.struct19_0.SMA2 = false;
			this.struct19_0.SMF1 = false;
			this.struct19_0.SMF2 = false;
			this.struct19_0.SS1 = false;
			this.struct19_0.SS2 = false;
			this.vmethod_0().Checked = false;
			this.vmethod_2().Checked = false;
			this.vmethod_18().Checked = false;
			this.vmethod_16().Checked = false;
			this.vmethod_8().Checked = false;
			this.vmethod_10().Checked = false;
			this.vmethod_22().Checked = false;
			this.vmethod_20().Checked = false;
			this.vmethod_4().Checked = false;
			this.vmethod_6().Checked = false;
			this.vmethod_28().Checked = false;
			this.vmethod_30().Checked = false;
			this.vmethod_14().Checked = false;
			this.vmethod_12().Checked = false;
			this.vmethod_26().Checked = false;
			this.vmethod_24().Checked = false;
			this.Refresh();
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x0001FC97 File Offset: 0x0001DE97
		private void method_21(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void PlatformComponentArcControl_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001B77 RID: 7031
		private IContainer icontainer_0;

		// Token: 0x04001B78 RID: 7032
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001B79 RID: 7033
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04001B7A RID: 7034
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04001B7B RID: 7035
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04001B7C RID: 7036
		[CompilerGenerated]
		private CheckBox checkBox_4;

		// Token: 0x04001B7D RID: 7037
		[CompilerGenerated]
		private CheckBox checkBox_5;

		// Token: 0x04001B7E RID: 7038
		[CompilerGenerated]
		private CheckBox checkBox_6;

		// Token: 0x04001B7F RID: 7039
		[CompilerGenerated]
		private CheckBox checkBox_7;

		// Token: 0x04001B80 RID: 7040
		[CompilerGenerated]
		private CheckBox checkBox_8;

		// Token: 0x04001B81 RID: 7041
		[CompilerGenerated]
		private CheckBox checkBox_9;

		// Token: 0x04001B82 RID: 7042
		[CompilerGenerated]
		private CheckBox checkBox_10;

		// Token: 0x04001B83 RID: 7043
		[CompilerGenerated]
		private CheckBox checkBox_11;

		// Token: 0x04001B84 RID: 7044
		[CompilerGenerated]
		private CheckBox checkBox_12;

		// Token: 0x04001B85 RID: 7045
		[CompilerGenerated]
		private CheckBox checkBox_13;

		// Token: 0x04001B86 RID: 7046
		[CompilerGenerated]
		private CheckBox checkBox_14;

		// Token: 0x04001B87 RID: 7047
		[CompilerGenerated]
		private CheckBox checkBox_15;

		// Token: 0x04001B88 RID: 7048
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x04001B89 RID: 7049
		public PlatformComponent._CoverageArc struct19_0;
	}
}
