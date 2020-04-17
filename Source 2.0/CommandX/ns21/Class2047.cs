using System;
using ns16;

namespace ns21
{
	// Token: 0x020000F8 RID: 248
	public sealed class Class2047 : Class2020
	{
		// Token: 0x06000539 RID: 1337 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2047()
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00006EA1 File Offset: 0x000050A1
		public Class2047(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00006EB0 File Offset: 0x000050B0
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

		// Token: 0x0600053C RID: 1340 RVA: 0x00059EAC File Offset: 0x000580AC
		public Class2020 method_2()
		{
			return new Class2020("-90");
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00059EC8 File Offset: 0x000580C8
		public Class2020 method_3()
		{
			return new Class2020("90");
		}
	}
}
