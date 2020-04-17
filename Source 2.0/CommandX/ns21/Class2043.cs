using System;
using ns16;

namespace ns21
{
	// Token: 0x02000069 RID: 105
	public sealed class Class2043 : Class2020
	{
		// Token: 0x06000206 RID: 518 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2043()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000055CC File Offset: 0x000037CC
		public Class2043(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000055DB File Offset: 0x000037DB
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
			if (base.CompareTo(this.method_3()) > 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00059EAC File Offset: 0x000580AC
		public Class2020 method_2()
		{
			return new Class2020("-90");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00059EC8 File Offset: 0x000580C8
		public Class2020 method_3()
		{
			return new Class2020("90");
		}
	}
}
