using System;
using System.Collections;

namespace ns29
{
	// Token: 0x02000134 RID: 308
	public sealed class Class2368 : IEnumerable, ICollection
	{
		// Token: 0x17000097 RID: 151
		public Class2367 this[int int_0]
		{
			get
			{
				return (Class2367)this.class2376_0[int_0];
			}
		}

		// Token: 0x17000098 RID: 152
		public Class2367 this[string string_0]
		{
			get
			{
				return (Class2367)this.class2376_0[string_0];
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00069304 File Offset: 0x00067504
		public int Count
		{
			get
			{
				return this.class2376_0.Count;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00069320 File Offset: 0x00067520
		public object SyncRoot
		{
			get
			{
				return this.class2376_0.SyncRoot;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000078D2 File Offset: 0x00005AD2
		public bool IsSynchronized
		{
			get
			{
				return this.class2376_0.IsSynchronized;
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000078DF File Offset: 0x00005ADF
		public void method_0(Class2367 class2367_0)
		{
			if (this.class2376_0.Contains(class2367_0))
			{
				throw new ArgumentException("IniSection already exists");
			}
			this.class2376_0.Add(class2367_0.method_0(), class2367_0);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000790F File Offset: 0x00005B0F
		public void method_1(string string_0)
		{
			this.class2376_0.Remove(string_0);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000791D File Offset: 0x00005B1D
		public void CopyTo(Array array, int index)
		{
			this.class2376_0.CopyTo(array, index);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0006933C File Offset: 0x0006753C
		public IEnumerator GetEnumerator()
		{
			return this.class2376_0.GetEnumerator();
		}

		// Token: 0x0400030A RID: 778
		private Class2376 class2376_0 = new Class2376();
	}
}
