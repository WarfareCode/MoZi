using System;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x02000629 RID: 1577
	public sealed class Class682 : Class677<TreeView>
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x000F18B4 File Offset: 0x000EFAB4
		public Class813 Nodes
		{
			get
			{
				return this.class813_0;
			}
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000162FD File Offset: 0x000144FD
		internal Class682(TreeView treeView_0) : base(treeView_0)
		{
			this.class813_0 = new Class813(treeView_0.Nodes, this);
		}

		// Token: 0x0400133D RID: 4925
		protected readonly Class813 class813_0;
	}
}
