using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns33;
using Steamworks;

namespace Command
{
	// Token: 0x0200096C RID: 2412
	[DesignerGenerated]
	public sealed partial class SteamUpdateScenarioForm : CommandForm
	{
		// Token: 0x06003B2B RID: 15147 RVA: 0x0001F654 File Offset: 0x0001D854
		public SteamUpdateScenarioForm()
		{
			base.Load += new EventHandler(this.SteamUpdateScenarioForm_Load);
			base.Load += new EventHandler(this.SteamUpdateScenarioForm_Load_1);
			this.InitializeComponent();
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x001248D8 File Offset: 0x00122AD8
		[CompilerGenerated]
		internal  Button vmethod_0()
		{
			return this.button_0;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x001248F0 File Offset: 0x00122AF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_2;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x0012493C File Offset: 0x00122B3C
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_1;
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00124954 File Offset: 0x00122B54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_2;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x001249A0 File Offset: 0x00122BA0
		[CompilerGenerated]
		internal  ListView vmethod_4()
		{
			return this.listView_0;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x0001F686 File Offset: 0x0001D886
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ListView listView_1)
		{
			this.listView_0 = listView_1;
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x0001F68F File Offset: 0x0001D88F
		private void SteamUpdateScenarioForm_Load(object sender, EventArgs e)
		{
			this.vmethod_4().Items.AddRange(SteamWorkshop.list_2.Select(SteamUpdateScenarioForm.SteamUGCDetails_tFunc0).ToArray<ListViewItem>());
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x001249B8 File Offset: 0x00122BB8
		private void method_2(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedItems.Count == 1)
			{
				object tag = this.vmethod_4().SelectedItems[0].Tag;
				SteamUGCDetails_t steamUGCDetails_t_ = (tag != null) ? ((SteamUGCDetails_t)tag) : default(SteamUGCDetails_t);
				SteamWorkshop.smethod_0(SteamUpdateScenarioForm.class2504_0, steamUGCDetails_t_);
			}
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void SteamUpdateScenarioForm_Load_1(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001AF8 RID: 6904
		public static Func<SteamUGCDetails_t, ListViewItem> SteamUGCDetails_tFunc0 = (SteamUGCDetails_t steamUGCDetails_t_0) => new ListViewItem(steamUGCDetails_t_0.m_rgchTitle)
		{
			Tag = steamUGCDetails_t_0
		};

		// Token: 0x04001AFA RID: 6906
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001AFB RID: 6907
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001AFC RID: 6908
		[CompilerGenerated]
		private ListView listView_0;

		// Token: 0x04001AFD RID: 6909
		public static SteamWorkshop.Class2504 class2504_0;
	}
}
