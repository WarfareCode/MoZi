using System;
using System.Collections;

namespace ns27
{
	// Token: 0x020006FB RID: 1787
	public sealed class Class2293 : IEnumerator
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x00102434 File Offset: 0x00100634
		public object Current
		{
			get
			{
				return this.class2291_0;
			}
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0010244C File Offset: 0x0010064C
		public bool MoveNext()
		{
			bool result;
			if (this.class2291_0 == null)
			{
				this.class2291_0 = this.class2291_1;
				this.int_0 = this.class2291_0.int_0;
				this.method_0();
				result = true;
			}
			else if (this.class2291_1 == null)
			{
				result = false;
			}
			else if (this.class2291_1.int_0 == this.class2291_0.int_0)
			{
				this.class2291_0 = this.class2291_1;
				this.int_0 = this.class2291_0.int_0;
				this.method_0();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000183AF File Offset: 0x000165AF
		public void Reset()
		{
			this.ienumerator_0.Reset();
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000183BC File Offset: 0x000165BC
		private void method_0()
		{
			if (this.ienumerator_0.MoveNext())
			{
				this.class2291_1 = (Class2291)this.ienumerator_0.Current;
			}
			else
			{
				this.class2291_1 = null;
			}
		}

		// Token: 0x04001500 RID: 5376
		private readonly IEnumerator ienumerator_0;

		// Token: 0x04001501 RID: 5377
		private Class2291 class2291_0;

		// Token: 0x04001502 RID: 5378
		private int int_0;

		// Token: 0x04001503 RID: 5379
		private Class2291 class2291_1;
	}
}
