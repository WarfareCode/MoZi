using System;
using System.Collections;
using System.Collections.Generic;
using ns14;

namespace ns11
{
	// Token: 0x02000356 RID: 854
	public class Class567<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x0000E513 File Offset: 0x0000C713
		public Class567(IEnumerable enumerable)
		{
			this.ienumerable_0 = enumerable;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00087EA0 File Offset: 0x000860A0
		public override bool Equals(object obj)
		{
			return obj.GetType().Equals(base.GetType()) && (obj == this || this.ienumerable_0.Equals(((Class567<T>)obj).ienumerable_0));
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00087EE8 File Offset: 0x000860E8
		public IEnumerator<T> GetEnumerator()
		{
			return new Struct59<T>(this.ienumerable_0.GetEnumerator());
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00087F0C File Offset: 0x0008610C
		public override int GetHashCode()
		{
			return this.ienumerable_0.GetHashCode();
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00087F28 File Offset: 0x00086128
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.ienumerable_0.GetEnumerator();
		}

		// Token: 0x04000863 RID: 2147
		private IEnumerable ienumerable_0;
	}
}
