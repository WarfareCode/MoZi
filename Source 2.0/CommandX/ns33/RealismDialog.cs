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
	// Token: 0x02000CEA RID: 3306
	[DesignerGenerated]
	public sealed partial class RealismDialog : Form
	{
		// Token: 0x06006CA8 RID: 27816 RVA: 0x0002E847 File Offset: 0x0002CA47
		public RealismDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x003D06DC File Offset: 0x003CE8DC
		[CompilerGenerated]
		internal  ElementHost vmethod_0()
		{
			return this.elementHost_0;
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x0002E855 File Offset: 0x0002CA55
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x0002E85E File Offset: 0x0002CA5E
		public void method_0(Scenario scenario_0)
		{
			((RealismDialogControl)this.vmethod_0().Child).DataContext = new RealismDialogViewModel(this, scenario_0);
		}

		// Token: 0x04003EAC RID: 16044
		[CompilerGenerated]
		private ElementHost elementHost_0;
	}
}
