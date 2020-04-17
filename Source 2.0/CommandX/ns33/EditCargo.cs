using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns33
{
	// Token: 0x02000CE8 RID: 3304
	[DesignerGenerated]
	public sealed partial class EditCargo : Form
	{
		// Token: 0x06006C50 RID: 27728 RVA: 0x0002E6CE File Offset: 0x0002C8CE
		public EditCargo()
		{
			base.Load += new EventHandler(this.EditCargo_Load);
			this.InitializeComponent();
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x003CE6B0 File Offset: 0x003CC8B0
		[CompilerGenerated]
		internal  ElementHost vmethod_0()
		{
			return this.elementHost_0;
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x0002E6EE File Offset: 0x0002C8EE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x003CE6C8 File Offset: 0x003CC8C8
		private void EditCargo_Load(object sender, EventArgs e)
		{
			if (this.ParentPlatform is Group)
			{
				Interaction.MsgBox("Please choose an individual unit, not a group.", MsgBoxStyle.OkOnly, null);
				base.Close();
			}
			else
			{
				((EditCargoControl)this.vmethod_0().Child).DataContext = new EditCargoViewModel(this, this.ParentPlatform);
			}
		}

		// Token: 0x04003E6A RID: 15978
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x04003E6C RID: 15980
		public ActiveUnit ParentPlatform;
	}
}
