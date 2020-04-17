using System;
using ns16;

namespace ns21
{
	// Token: 0x0200006C RID: 108
	public sealed class Class2046 : Class2020
	{
		// Token: 0x06000215 RID: 533 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2046()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000056B9 File Offset: 0x000038B9
		public Class2046(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000056C8 File Offset: 0x000038C8
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

		// Token: 0x06000218 RID: 536 RVA: 0x00059EE4 File Offset: 0x000580E4
		public Class2020 method_2()
		{
			return new Class2020("-180");
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}
