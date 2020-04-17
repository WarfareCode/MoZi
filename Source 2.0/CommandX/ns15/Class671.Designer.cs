using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x02000491 RID: 1169
	public sealed class Class671 : Panel, ISupportInitialize
	{
		// Token: 0x06001E31 RID: 7729 RVA: 0x000125B6 File Offset: 0x000107B6
		public Class671()
		{
			this.method_0();
			this.BackColor = Color.CornflowerBlue;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000125EF File Offset: 0x000107EF
		public void BeginInit()
		{
			this.bool_0 = true;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000125F8 File Offset: 0x000107F8
		public void EndInit()
		{
			this.bool_0 = false;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_0()
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000C3794 File Offset: 0x000C1994
		private void method_1(int num)
		{
			for (int i = num; i >= 0; i--)
			{
				if (i != this.class672_0.Count - 1)
				{
					this.class672_0.method_2(i).Top = this.class672_0.method_2(i + 1).Bottom + this.int_0;
				}
				else
				{
					this.class672_0.method_2(i).Top = this.int_0;
				}
				this.class672_0.method_2(i).Left = this.int_1;
				this.class672_0.method_2(i).Width = base.Width - 2 * this.int_1;
				if (base.VScroll)
				{
					Class670 @class = this.class672_0.method_2(i);
					@class.Width -= SystemInformation.VerticalScrollBarWidth;
				}
			}
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000C3870 File Offset: 0x000C1A70
		private void method_2(object sender, EventArgs2 e)
		{
			int num = this.class672_0.method_4(e.method_0());
			if (-1 != num)
			{
				int num2 = num - 1;
				this.method_1(num2);
			}
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000C38A4 File Offset: 0x000C1AA4
		protected override void OnControlAdded(ControlEventArgs controlEventArg)
		{
			base.OnControlAdded(controlEventArg);
			if (controlEventArg.Control is Class670)
			{
				controlEventArg.Control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				if (!this.bool_0)
				{
					this.class672_0.method_3(0, (Class670)controlEventArg.Control);
					this.class672_0.method_2(0).method_0(new Delegate34(this.method_2));
				}
				else
				{
					this.class672_0.method_0((Class670)controlEventArg.Control);
					this.class672_0.method_2(this.class672_0.Count - 1).method_0(new Delegate34(this.method_2));
				}
				this.method_1(this.class672_0.Count - 1);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x000C396C File Offset: 0x000C1B6C
		protected override void OnControlRemoved(ControlEventArgs controlEventArg)
		{
			base.OnControlRemoved(controlEventArg);
			if (controlEventArg.Control is Class670)
			{
				int num = this.class672_0.method_4((Class670)controlEventArg.Control);
				if (-1 != num)
				{
					this.class672_0.method_1(num);
					this.method_1(this.class672_0.Count - 1);
				}
			}
		}

		// Token: 0x04000DB6 RID: 3510
		private Class672 class672_0 = new Class672();

		// Token: 0x04000DB7 RID: 3511
		private int int_0 = 8;

		// Token: 0x04000DB8 RID: 3512
		private int int_1 = 8;

		// Token: 0x04000DB9 RID: 3513
		private bool bool_0 = false;
	}
}
