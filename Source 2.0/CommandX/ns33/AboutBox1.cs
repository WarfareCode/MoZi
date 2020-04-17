using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns34;

namespace ns33
{
	// Token: 0x0200099C RID: 2460
	[DesignerGenerated]
	public sealed partial class AboutBox1 : CommandForm
	{
		// Token: 0x06003EFB RID: 16123 RVA: 0x00152560 File Offset: 0x00150760
		public AboutBox1()
		{
			base.Load += new EventHandler(this.AboutBox1_Load);
			base.KeyDown += new KeyEventHandler(this.AboutBox1_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.AboutBox1_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00152B38 File Offset: 0x00150D38
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000207E9 File Offset: 0x0001E9E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_5)
		{
			this.label_0 = label_5;
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00152B50 File Offset: 0x00150D50
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x00152B68 File Offset: 0x00150D68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_1)
		{
			EventHandler value = new EventHandler(this.method_1);
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

		// Token: 0x06003F02 RID: 16130 RVA: 0x00152BB4 File Offset: 0x00150DB4
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x000207F2 File Offset: 0x0001E9F2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_5)
		{
			this.label_1 = label_5;
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x00152BCC File Offset: 0x00150DCC
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_2;
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x000207FB File Offset: 0x0001E9FB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_5)
		{
			this.label_2 = label_5;
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x00152BE4 File Offset: 0x00150DE4
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_3;
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x00020804 File Offset: 0x0001EA04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_5)
		{
			this.label_3 = label_5;
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x00152BFC File Offset: 0x00150DFC
		[CompilerGenerated]
		internal  PictureBox vmethod_10()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0002080D File Offset: 0x0001EA0D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00152C14 File Offset: 0x00150E14
		[CompilerGenerated]
		internal  TextBox vmethod_12()
		{
			return this.textBox_0;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00020816 File Offset: 0x0001EA16
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x00152C2C File Offset: 0x00150E2C
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_4;
		}

		

		// Token: 0x06003F0E RID: 16142 RVA: 0x00152C44 File Offset: 0x00150E44
		private void AboutBox1_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (GameGeneral.bProfessionEdition)
			{
				this.vmethod_0().Text = GameGeneral.strVersion + "专业版 - 授权用户: " + LicenseFile.CustomerName;
			}
			else
			{
				this.vmethod_0().Text = GameGeneral.strVersion;
			}
			string str = "";
			if (Client.smethod_29())
			{
				str += "Running in Steam mode.\r\n";
			}
			str += "授权模块: ";
			List<string> list = new List<string>();
			if (LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase))
			{
				list.Add("CommandX专业版");
			}
			if (LicenseChecker.HoldLicense(LicenseChecker.License.NorthernInferno))
			{
				list.Add("CommandX战役系列：北方地狱");
			}
			if (LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE1))
			{
				list.Add("CommandX时事热点版 - 俄土叙利亚争端");
			}
			if (LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE2))
			{
				list.Add("CommandX时事热点版 - 北约与俄国对抗");
			}
			if (LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE3))
			{
				list.Add("CommandX时事热点版 - 中美南海冲突");
			}
			if (LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE4))
			{
				list.Add("CommandX时事热点版- 欧俄乌克兰危机");
			}
			if (LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE5))
			{
				list.Add("CommandX时事热点版 - 朝鲜导弹危机");
			}
			this.vmethod_14().Text = str + string.Join("; ", list);
			StringBuilder stringBuilder = new StringBuilder();

			this.vmethod_12().Text = stringBuilder.ToString();
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void AboutBox1_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06003F11 RID: 16145 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AboutBox1_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04001CF9 RID: 7417
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001CFA RID: 7418
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001CFB RID: 7419
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001CFC RID: 7420
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001CFD RID: 7421
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001CFE RID: 7422
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x04001CFF RID: 7423
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001D00 RID: 7424
		[CompilerGenerated]
		private Label label_4;
	}
}
