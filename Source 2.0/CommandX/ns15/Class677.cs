using System;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x02000563 RID: 1379
	public class Class677<TControl> : Class676 where TControl : Control
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000E0410 File Offset: 0x000DE610
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x000E0444 File Offset: 0x000DE644
		public object Tag
		{
			get
			{
				return this.method_5<object>((TControl argument0) => argument0.Tag);
			}
			set
			{
				this.method_4(delegate(TControl argument0)
				{
					argument0.Tag = value;
				});
			}
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00014A94 File Offset: 0x00012C94
		internal Class677(TControl tControl) : base(tControl)
		{
			this.gparam_0 = tControl;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000E0470 File Offset: 0x000DE670
		internal TControl method_3()
		{
			return this.gparam_0;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000E0488 File Offset: 0x000DE688
		internal void method_4(Action<TControl> action)
		{
			TControl tControl = this.gparam_0;
			if (!tControl.InvokeRequired)
			{
				action(this.gparam_0);
			}
			else
			{
				TControl tControl2 = this.gparam_0;
				object[] args = new object[]
				{
					this.gparam_0
				};
				tControl2.BeginInvoke(action, args);
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000E04E8 File Offset: 0x000DE6E8
		internal T method_5<T>(Func<TControl, T> func)
		{
			TControl tControl = this.gparam_0;
			T result;
			if (!tControl.InvokeRequired)
			{
				result = func(this.gparam_0);
			}
			else
			{
				TControl tControl2 = this.gparam_0;
				object[] args = new object[]
				{
					this.gparam_0
				};
				result = (T)((object)tControl2.Invoke(func, args));
			}
			return result;
		}

		// Token: 0x0400113C RID: 4412
		protected readonly TControl gparam_0;
	}
}
