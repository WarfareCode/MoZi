using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
using ns32;
using ns34;

namespace ns33
{
	// Token: 0x02000CEC RID: 3308
	[DesignerGenerated]
	public sealed partial class InsufficientLicenseWindow : Form
	{
		// Token: 0x06006CBC RID: 27836 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
		public InsufficientLicenseWindow()
		{
			base.Shown += new EventHandler(this.InsufficientLicenseWindow_Shown);
			base.Load += new EventHandler(this.InsufficientLicenseWindow_Load);
			this.InitializeComponent();
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x003D0E4C File Offset: 0x003CF04C
		[CompilerGenerated]
		internal  ShapeContainer vmethod_0()
		{
			return this.shapeContainer_0;
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x0002E8D6 File Offset: 0x0002CAD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ShapeContainer shapeContainer_1)
		{
			this.shapeContainer_0 = shapeContainer_1;
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x003D0E64 File Offset: 0x003CF064
		[CompilerGenerated]
		internal  RectangleShape vmethod_2()
		{
			return this.rectangleShape_0;
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x003D0E7C File Offset: 0x003CF07C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(RectangleShape rectangleShape_1)
		{
			MouseEventHandler obj = new MouseEventHandler(this.method_0);
			EventHandler obj2 = new EventHandler(this.method_1);
			MouseEventHandler obj3 = new MouseEventHandler(this.method_2);
			RectangleShape rectangleShape = this.rectangleShape_0;
			if (rectangleShape != null)
			{
				rectangleShape.MouseClick -= obj;
				rectangleShape.MouseLeave -= obj2;
				rectangleShape.MouseMove -= obj3;
			}
			this.rectangleShape_0 = rectangleShape_1;
			rectangleShape = this.rectangleShape_0;
			if (rectangleShape != null)
			{
				rectangleShape.MouseClick += obj;
				rectangleShape.MouseLeave += obj2;
				rectangleShape.MouseMove += obj3;
			}
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x003D0EFC File Offset: 0x003CF0FC
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x0002E8DF File Offset: 0x0002CADF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x003D0F14 File Offset: 0x003CF114
		[CompilerGenerated]
		internal  Panel vmethod_6()
		{
			return this.panel_0;
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x0002E8E8 File Offset: 0x0002CAE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Panel panel_1)
		{
			this.panel_0 = panel_1;
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x003D0F2C File Offset: 0x003CF12C
		private void InsufficientLicenseWindow_Shown(object sender, EventArgs e)
		{
			this.vmethod_6().BackColor = Color.FromArgb(160, Color.Gray);
			this.vmethod_4().BackColor = this.vmethod_6().BackColor;
			switch (this.license)
			{
			case LicenseChecker.License.CMANOBase:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_CMANO.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonBlue.png");
				this.vmethod_4().ForeColor = Color.LightSkyBlue;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommand - Modern Air/Naval Operations\r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/321410";
				}
				else
				{
					this.string_0 = "http://matrixgames.com/products/483/details/Command:.Modern.Air/Naval.Operations";
				}
				break;
			case LicenseChecker.License.NorthernInferno:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_NI.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonRed.png");
				this.vmethod_4().ForeColor = Color.DarkRed;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommand - Northern Inferno \r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/397180/";
				}
				else
				{
					this.string_0 = "http://www.matrixgames.com/products/589/details/Command:.Northern.Inferno.";
				}
				break;
			case LicenseChecker.License.CLIVE1:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_LIVE1.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonRed.png");
				this.vmethod_4().ForeColor = Color.Red;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommandX热点 #1 - Old Grudges Never Die \r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/388020/";
				}
				else
				{
					this.string_0 = "http://www.matrixgames.com/products/636/details/Command.Live:.Old.Grudges.Never.Die";
				}
				break;
			case LicenseChecker.License.CLIVE2:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_LIVE2.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonBlue.png");
				this.vmethod_4().ForeColor = Color.LightSkyBlue;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommandX热点 #2 - You Brexit, You Fix It! \r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/497611/";
				}
				else
				{
					this.string_0 = "http://www.matrixgames.com/products/640/details/CommandLive:YouBrexit,YouFixit!";
				}
				break;
			case LicenseChecker.License.CLIVE3:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_LIVE3.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonRed.png");
				this.vmethod_4().ForeColor = Color.DarkRed;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommandX热点 #3 - Spratly Spat \r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/527370/";
				}
				else
				{
					this.string_0 = "http://www.matrixgames.com/products/643/details/Command.LIVE:.Spratly.Spat";
				}
				break;
			case LicenseChecker.License.CLIVE4:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_LIVE4.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonBlue.png");
				this.vmethod_4().ForeColor = Color.LightSkyBlue;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommandX热点 #4 - Don of a New Era \r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/497610/";
				}
				else
				{
					this.string_0 = "http://www.matrixgames.com/products/648/details/CommandLive:DonofanewEra";
				}
				break;
			case LicenseChecker.License.CLIVE5:
				this.BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\NoLicense_LIVE5.jpg");
				this.vmethod_2().BackgroundImage = Image.FromFile(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Symbols\\Menu\\UpgradeButtonRed.png");
				this.vmethod_4().ForeColor = Color.DarkRed;
				this.vmethod_4().Text = "要想使用此项功能，请获取软件许可证: \r\nCommandX热点 #5 - Korean Missile Crisis \r\n点击“立即升级”获取本模块的使用许可.";
				if (Client.smethod_29())
				{
					this.string_0 = "http://store.steampowered.com/app/584260/";
				}
				else
				{
					this.string_0 = "http://www.matrixgames.com/products/681/details/Command.Live:.Korean.Missile.Crisis";
				}
				break;
			}
			this.vmethod_6().Height = this.vmethod_4().Height + 20;
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x0002E8F1 File Offset: 0x0002CAF1
		private void method_0(object sender, MouseEventArgs e)
		{
			Process.Start(this.string_0);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x0002E8FF File Offset: 0x0002CAFF
		private void method_1(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		private void method_2(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void InsufficientLicenseWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003EB3 RID: 16051
		[CompilerGenerated]
		private ShapeContainer shapeContainer_0;

		// Token: 0x04003EB4 RID: 16052
		[CompilerGenerated]
		private RectangleShape rectangleShape_0;

		// Token: 0x04003EB5 RID: 16053
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003EB6 RID: 16054
		[CompilerGenerated]
		private Panel panel_0;

		// Token: 0x04003EB7 RID: 16055
		public LicenseChecker.License license;

		// Token: 0x04003EB8 RID: 16056
		private string string_0;
	}
}
