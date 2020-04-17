using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns32;
using ns35;

namespace ns33
{
	// Token: 0x02000991 RID: 2449
	[DesignerGenerated]
	public sealed partial class SteamPublishScenarioForm : CommandForm
	{
		// Token: 0x06003DDE RID: 15838 RVA: 0x00143100 File Offset: 0x00141300
		public SteamPublishScenarioForm()
		{
			base.Shown += new EventHandler(this.SteamPublishScenarioForm_Shown);
			base.Load += new EventHandler(this.SteamPublishScenarioForm_Load);
			this.string_0 = Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "screenshot.png");
			this.string_1 = Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "screenshot_thumb.png");
			this.InitializeComponent();
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x001437A4 File Offset: 0x001419A4
		[CompilerGenerated]
		internal  PictureBox vmethod_0()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x000202BB File Offset: 0x0001E4BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x001437BC File Offset: 0x001419BC
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x001437D4 File Offset: 0x001419D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_1);
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

		// Token: 0x06003DE5 RID: 15845 RVA: 0x00143820 File Offset: 0x00141A20
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00143838 File Offset: 0x00141A38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00143884 File Offset: 0x00141A84
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_2;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x0014389C File Offset: 0x00141A9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06003DE9 RID: 15849 RVA: 0x001438E8 File Offset: 0x00141AE8
		[CompilerGenerated]
		internal  TextBox vmethod_8()
		{
			return this.textBox_0;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x000202C4 File Offset: 0x0001E4C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TextBox textBox_3)
		{
			this.textBox_0 = textBox_3;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00143900 File Offset: 0x00141B00
		[CompilerGenerated]
		internal  TextBox vmethod_10()
		{
			return this.textBox_1;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x000202CD File Offset: 0x0001E4CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TextBox textBox_3)
		{
			this.textBox_1 = textBox_3;
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00143918 File Offset: 0x00141B18
		[CompilerGenerated]
		internal  TextBox vmethod_12()
		{
			return this.textBox_2;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000202D6 File Offset: 0x0001E4D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TextBox textBox_3)
		{
			this.textBox_2 = textBox_3;
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00143930 File Offset: 0x00141B30
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_0;
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x000202DF File Offset: 0x0001E4DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00143948 File Offset: 0x00141B48
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_1;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000202E8 File Offset: 0x0001E4E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00143960 File Offset: 0x00141B60
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_18()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x000202F1 File Offset: 0x0001E4F1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00143978 File Offset: 0x00141B78
		[CompilerGenerated]
		internal  Button vmethod_20()
		{
			return this.button_3;
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00143990 File Offset: 0x00141B90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06003DF7 RID: 15863 RVA: 0x001439DC File Offset: 0x00141BDC
		private void method_1(object sender, EventArgs e)
		{
			this.vmethod_18().Filter = "";
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			string text = string.Empty;
			ImageCodecInfo[] array = imageEncoders;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					ImageCodecInfo imageCodecInfo = array[i];
					string text2 = imageCodecInfo.CodecName.Substring(8).Replace("Codec", "Files").Trim();
					this.vmethod_18().Filter = string.Format("{0}{1}{2} ({3})|{3}", new object[]
					{
						this.vmethod_18().Filter,
						text,
						text2,
						imageCodecInfo.FilenameExtension
					});
					text = "|";
				}
				this.vmethod_18().Filter = string.Format("{0}{1}{2} ({3})|{3}", new object[]
				{
					this.vmethod_18().Filter,
					text,
					"All Files",
					"*.*"
				});
				this.vmethod_18().FilterIndex = 1;
				if (this.vmethod_18().ShowDialog() == DialogResult.OK)
				{
					if (File.Exists(this.string_0))
					{
						File.Delete(this.string_0);
					}
					File.Copy(this.vmethod_18().FileName, this.string_0);
					Image image = Image.FromFile(this.vmethod_18().FileName);
					this.method_5(image, image.RawFormat);
				}
			}
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00143B40 File Offset: 0x00141D40
		private void method_2(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_8().Text))
			{
				Interaction.MsgBox("Please provide a scenario title!", MsgBoxStyle.OkOnly, null);
			}
			else if (string.IsNullOrEmpty(this.vmethod_10().Text))
			{
				Interaction.MsgBox("Please provide a scenario filename!", MsgBoxStyle.OkOnly, null);
			}
			else if (string.IsNullOrEmpty(this.vmethod_12().Text))
			{
				Interaction.MsgBox("Please provide a scenario description!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				SteamWorkshop.smethod_1(new SteamWorkshop.Class2504
				{
					string_0 = this.vmethod_8().Text,
					string_1 = this.vmethod_10().Text,
					string_3 = this.string_1,
					string_2 = this.vmethod_12().Text.Replace("/", "").Replace("\\", "").Replace(":", "")
				});
			}
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00143C38 File Offset: 0x00141E38
		private void SteamPublishScenarioForm_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().Text = Client.GetClientScenario().GetScenarioTitle();
			if (!string.IsNullOrEmpty(Client.GetClientScenario().GetDescription()))
			{
				this.vmethod_10().Text = Class266.smethod_0(Client.GetClientScenario().GetDescription());
			}
			if (!string.IsNullOrEmpty(Client.string_3))
			{
				this.vmethod_12().Text = Path.GetFileNameWithoutExtension(Client.string_3);
			}
			else
			{
				this.vmethod_12().Text = "Input Scenario Filename Here";
			}
			string text = Path.ChangeExtension(Client.string_3, "jpg");
			if (!Information.IsNothing(Client.string_3) && File.Exists(text))
			{
				Image image = Image.FromFile(text);
				this.method_5(image, image.RawFormat);
			}
			else
			{
				this.method_3();
			}
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00143D00 File Offset: 0x00141F00
		private void method_3()
		{
			try
			{
				if (File.Exists(this.string_0))
				{
					File.Delete(this.string_0);
				}
				CommandFactory.GetCommandMain().GetMainForm().GetMapBox().BackgroundImage.Save(this.string_0, ImageFormat.Png);
				this.method_5(CommandFactory.GetCommandMain().GetMainForm().GetMapBox().BackgroundImage, ImageFormat.Png);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200407", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x000202FA File Offset: 0x0001E4FA
		private void method_4(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00143DBC File Offset: 0x00141FBC
		private void method_5(Image image_0, ImageFormat imageFormat_0)
		{
			Image image = Class2529.smethod_4(image_0, new Size(637, 358), true);
			image.Save(this.string_1, imageFormat_0);
			this.vmethod_0().Image = Class2529.smethod_4(image, new Size(256, 256), true);
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00143E10 File Offset: 0x00142010
		private void method_6(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_8().Text))
			{
				Interaction.MsgBox("Please provide a scenario title!", MsgBoxStyle.OkOnly, null);
			}
			else if (string.IsNullOrEmpty(this.vmethod_10().Text))
			{
				Interaction.MsgBox("Please provide a scenario filename!", MsgBoxStyle.OkOnly, null);
			}
			else if (string.IsNullOrEmpty(this.vmethod_12().Text))
			{
				Interaction.MsgBox("Please provide a scenario description!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				SteamUpdateScenarioForm.class2504_0 = new SteamWorkshop.Class2504
				{
					string_0 = this.vmethod_8().Text,
					string_1 = this.vmethod_10().Text,
					string_3 = this.string_1,
					string_2 = this.vmethod_12().Text.Replace("/", "").Replace("\\", "").Replace(":", "")
				};
				CommandFactory.GetCommandMain().GetSteamUpdateScenarioForm().Show();
				base.Close();
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void SteamPublishScenarioForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001C61 RID: 7265
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x04001C62 RID: 7266
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001C63 RID: 7267
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001C64 RID: 7268
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001C65 RID: 7269
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001C66 RID: 7270
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04001C67 RID: 7271
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x04001C68 RID: 7272
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001C69 RID: 7273
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001C6A RID: 7274
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04001C6B RID: 7275
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001C6C RID: 7276
		private string string_0;

		// Token: 0x04001C6D RID: 7277
		private string string_1;
	}
}
