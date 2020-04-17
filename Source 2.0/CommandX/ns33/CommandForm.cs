using System;
using System.Drawing;
using System.Windows.Forms;
using Command;
using Command_Core;
using ns32;
using ns4;

namespace ns33
{
	// 命令窗口，其它具体的命令都从此类继承
	public class CommandForm : Form
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x0001F5F5 File Offset: 0x0001D7F5
		public CommandForm()
		{
			base.Activated += new EventHandler(this.CommandForm_Activated);
			base.FormClosing += new FormClosingEventHandler(this.CommandForm_FormClosing);
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00124518 File Offset: 0x00122718
		protected override void OnMove(EventArgs e)
		{
			base.OnMove(e);
			if (base.Visible)
			{
				Class267.smethod_0(base.Name, base.Location.X, base.Location.Y, base.Width, base.Height);
			}
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x0012456C File Offset: 0x0012276C
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (base.Visible)
			{
				Class267.smethod_0(base.Name, base.Location.X, base.Location.Y, base.Width, base.Height);
			}
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x0001F621 File Offset: 0x0001D821
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (base.Visible)
			{
				Class267.smethod_1(this);
			}
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x0001F63B File Offset: 0x0001D83B
		private void CommandForm_Activated(object sender, EventArgs e)
		{
			if (!Client.bool_6)
			{
				base.Owner = CommandFactory.GetCommandMain().GetMainForm();
			}
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x001245C0 File Offset: 0x001227C0
		public Color GetComponentColor(PlatformComponent platformComponent_)
		{
			Color color;
			Color result;
			if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
			{
				switch (platformComponent_.GetDamageSeverity())
				{
				case PlatformComponent._DamageSeverityFactor.Light:
					color = Color.Yellow;
					result = color;
					return result;
				case PlatformComponent._DamageSeverityFactor.Medium:
					color = Color.Orange;
					result = color;
					return result;
				case PlatformComponent._DamageSeverityFactor.Heavy:
					color = Color.OrangeRed;
					result = color;
					return result;
				}
			}
			if (platformComponent_.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
			{
				color = Color.Red;
			}
			else
			{
				if (platformComponent_.GetType() == typeof(AirFacility))
				{
					AirFacility airFacility = (AirFacility)platformComponent_;
					if (airFacility.GetAircraftSizeClass() > airFacility.GetAircraftSizeAfterDamage())
					{
						color = Color.Yellow;
						result = color;
						return result;
					}
				}
				color = Color.White;
			}
			result = color;
			return result;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00004D83 File Offset: 0x00002F83
		private void CommandForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}
	}
}
