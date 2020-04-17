using System;
using System.Collections;

namespace ns31
{
	// Token: 0x020004AA RID: 1194
	public sealed class Class2439 : IEnumerable
	{
		// Token: 0x17000247 RID: 583
		public Class2437 this[int int_0]
		{
			get
			{
				return (Class2437)this.class2437_0[int_0].Clone();
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000CE2AC File Offset: 0x000CC4AC
		public IEnumerator GetEnumerator()
		{
			if (this.class2437_0 == null)
			{
				throw new InvalidOperationException("ZipFile has closed");
			}
			return new Class2439.Class2440(this.class2437_0);
		}

		// Token: 0x04000E81 RID: 3713
		private Class2437[] class2437_0;

		// Token: 0x020004AB RID: 1195
		private sealed class Class2440 : IEnumerator
		{
			// Token: 0x17000248 RID: 584
			// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000CE2E0 File Offset: 0x000CC4E0
			public object Current
			{
				get
				{
					return this.class2437_0[this.int_0];
				}
			}

			// Token: 0x06001F36 RID: 7990 RVA: 0x00012CCC File Offset: 0x00010ECC
			public Class2440(Class2437[] class2437_1)
			{
				this.class2437_0 = class2437_1;
			}

			// Token: 0x06001F37 RID: 7991 RVA: 0x00012CE2 File Offset: 0x00010EE2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001F38 RID: 7992 RVA: 0x000CE2FC File Offset: 0x000CC4FC
			public bool MoveNext()
			{
				return ++this.int_0 < this.class2437_0.Length;
			}

			// Token: 0x04000E82 RID: 3714
			private Class2437[] class2437_0;

			// Token: 0x04000E83 RID: 3715
			private int int_0 = -1;
		}
	}
}
