using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using MSDN.Html.Editor;

namespace ns33
{
	// Token: 0x0200096D RID: 2413
	[DesignerGenerated]
	public sealed partial class TitleAndDescription : CommandForm
	{
		// Token: 0x06003B3A RID: 15162 RVA: 0x0001F6FB File Offset: 0x0001D8FB
		public TitleAndDescription()
		{
			base.Shown += new EventHandler(this.TitleAndDescription_Shown);
			base.Load += new EventHandler(this.TitleAndDescription_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00124E80 File Offset: 0x00123080
		[CompilerGenerated]
		public  HtmlEditorControl vmethod_0()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x0001F72D File Offset: 0x0001D92D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_1(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00124E98 File Offset: 0x00123098
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00124EB0 File Offset: 0x001230B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_3;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00124EFC File Offset: 0x001230FC
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00124F14 File Offset: 0x00123114
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_3;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00124F60 File Offset: 0x00123160
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_0;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x0001F736 File Offset: 0x0001D936
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00124F78 File Offset: 0x00123178
		[CompilerGenerated]
		internal  TextBox vmethod_8()
		{
			return this.textBox_0;
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x0001F73F File Offset: 0x0001D93F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00124F90 File Offset: 0x00123190
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_1;
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x0001F748 File Offset: 0x0001D948
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00124FA8 File Offset: 0x001231A8
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_2;
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00124FC0 File Offset: 0x001231C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_3;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x0001F751 File Offset: 0x0001D951
		private void method_1(object sender, EventArgs e)
		{
			this.string_0 = this.vmethod_8().Text;
			this.string_1 = this.vmethod_0().BodyHtml;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x0001F782 File Offset: 0x0001D982
		private void method_2(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x0001F791 File Offset: 0x0001D991
		private void TitleAndDescription_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().Text = this.string_0;
			if (!string.IsNullOrEmpty(this.string_1))
			{
				this.vmethod_0().BodyHtml = this.string_1;
			}
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x0001F7C2 File Offset: 0x0001D9C2
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_0().HtmlContentsEdit();
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void TitleAndDescription_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001B00 RID: 6912
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x04001B01 RID: 6913
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001B02 RID: 6914
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001B03 RID: 6915
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001B04 RID: 6916
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001B05 RID: 6917
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001B06 RID: 6918
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001B07 RID: 6919
		public string string_0;

		// Token: 0x04001B08 RID: 6920
		public string string_1;
	}
}
