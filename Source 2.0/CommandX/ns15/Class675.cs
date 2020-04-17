using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x020004A3 RID: 1187
	public sealed class Class675 : CollectionBase
	{
		// Token: 0x17000246 RID: 582
		public TreeNode this[int int_0]
		{
			get
			{
				return (TreeNode)base.List[int_0];
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00012B35 File Offset: 0x00010D35
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void method_0(Delegate35 delegate35_3)
		{
			this.delegate35_0 = (Delegate35)Delegate.Combine(this.delegate35_0, delegate35_3);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00012B4E File Offset: 0x00010D4E
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void method_1(Delegate35 delegate35_3)
		{
			this.delegate35_1 = (Delegate35)Delegate.Combine(this.delegate35_1, delegate35_3);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00012B67 File Offset: 0x00010D67
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void method_2(Delegate35 delegate35_3)
		{
			this.delegate35_2 = (Delegate35)Delegate.Combine(this.delegate35_2, delegate35_3);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00012B80 File Offset: 0x00010D80
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void method_3(EventHandler eventHandler_1)
		{
			this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000CC28C File Offset: 0x000CA48C
		public int method_4(TreeNode treeNode_0)
		{
			if (this.delegate35_0 != null)
			{
				this.delegate35_0(treeNode_0);
			}
			return base.List.Add(treeNode_0);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00012B99 File Offset: 0x00010D99
		protected override void OnClear()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
			base.OnClear();
		}

		// Token: 0x04000E39 RID: 3641
		private Delegate35 delegate35_0;

		// Token: 0x04000E3A RID: 3642
		private Delegate35 delegate35_1;

		// Token: 0x04000E3B RID: 3643
		private Delegate35 delegate35_2;

		// Token: 0x04000E3C RID: 3644
		private EventHandler eventHandler_0;
	}
}
