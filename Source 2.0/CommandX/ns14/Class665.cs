using System;
using System.Collections;

namespace ns14
{
	// Token: 0x02000476 RID: 1142
	public sealed class Class665 : IEnumerator
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000BF814 File Offset: 0x000BDA14
		public object Current
		{
			get
			{
				return this.class651_0;
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0001220F File Offset: 0x0001040F
		private void method_0()
		{
			if (this.ienumerator_0.MoveNext())
			{
				this.class651_1 = (Class651)this.ienumerator_0.Current;
			}
			else
			{
				this.class651_1 = null;
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000BF82C File Offset: 0x000BDA2C
		public bool MoveNext()
		{
			bool result;
			if (this.class651_0 == null)
			{
				this.class651_0 = this.class651_1;
				this.int_0 = this.class651_0.int_0;
				this.method_0();
				result = true;
			}
			else if (this.class651_1 == null)
			{
				result = false;
			}
			else if (this.class651_1.int_0 == this.class651_0.int_0)
			{
				this.class651_0 = this.class651_1;
				this.int_0 = this.class651_0.int_0;
				this.method_0();
				result = true;
			}
			else
			{
				if (this.class651_1.int_0 > this.class651_0.int_0)
				{
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00012240 File Offset: 0x00010440
		public void Reset()
		{
			this.ienumerator_0.Reset();
		}

		// Token: 0x04000D2B RID: 3371
		private IEnumerator ienumerator_0;

		// Token: 0x04000D2C RID: 3372
		private Class651 class651_0;

		// Token: 0x04000D2D RID: 3373
		private Class651 class651_1;

		// Token: 0x04000D2E RID: 3374
		private int int_0;
	}
}
