using System;
using System.Collections;
using System.Collections.Generic;

namespace ns14
{
	// Token: 0x02000461 RID: 1121
	public struct Struct59<T> : IDisposable, IEnumerator<T>, IEnumerator
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000B591C File Offset: 0x000B3B1C
		public T Current
		{
			get
			{
				return (T)((object)this.ienumerator_0.Current);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000B593C File Offset: 0x000B3B3C
		object IEnumerator.Current
		{
			get
			{
				return this.ienumerator_0.Current;
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00011EA2 File Offset: 0x000100A2
		public Struct59(IEnumerator ienumerator_1)
		{
			this.ienumerator_0 = ienumerator_1;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00011EAB File Offset: 0x000100AB
		public void Dispose()
		{
			this.ienumerator_0 = null;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00011EB4 File Offset: 0x000100B4
		public bool MoveNext()
		{
			return this.ienumerator_0.MoveNext();
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00011EC1 File Offset: 0x000100C1
		public void Reset()
		{
			this.ienumerator_0.Reset();
		}

		// Token: 0x04000C86 RID: 3206
		private IEnumerator ienumerator_0;
	}
}
