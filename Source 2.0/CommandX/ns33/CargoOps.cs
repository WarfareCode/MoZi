using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns33
{
	// Token: 0x02000CE7 RID: 3303
	[DesignerGenerated]
	public sealed partial class CargoOps : Form
	{
		// Token: 0x06006C4A RID: 27722 RVA: 0x0002E67C File Offset: 0x0002C87C
		public CargoOps()
		{
			base.Load += new EventHandler(this.CargoOps_Load);
			this.InitializeComponent();
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x003CE554 File Offset: 0x003CC754
		[CompilerGenerated]
		internal  ElementHost vmethod_0()
		{
			return this.elementHost_0;
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x0002E69C File Offset: 0x0002C89C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x0002E6A5 File Offset: 0x0002C8A5
		private void CargoOps_Load(object sender, EventArgs e)
		{
			((CargoOpsControl)this.vmethod_0().Child).DataContext = new CargoOpsViewModel(this, this.activeUnit_0, this.activeUnit_1);
		}

		// Token: 0x04003E65 RID: 15973
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x04003E67 RID: 15975
		public ActiveUnit activeUnit_0;

		// Token: 0x04003E68 RID: 15976
		public ActiveUnit activeUnit_1;
	}
}
