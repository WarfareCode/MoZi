using System;

namespace ns32
{
	// Token: 0x020004AE RID: 1198
	public sealed class Class2441 : ICloneable
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class2441()
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x000CE324 File Offset: 0x000CC524
		public object Clone()
		{
			Class2441 @class = new Class2441();
			@class.string_0 = this.string_0;
			@class.class2442_0 = (Class2442)this.class2442_0.Clone();
			@class.method_1(this.method_0());
			return @class;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00012CFC File Offset: 0x00010EFC
		public override bool Equals(object obj)
		{
			return obj is Class2441 && this.method_0().Equals(((Class2441)obj).method_0());
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x000CE368 File Offset: 0x000CC568
		public override int GetHashCode()
		{
			return this.method_0().GetHashCode();
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x000CE384 File Offset: 0x000CC584
		public string method_0()
		{
			return this.class2442_0.method_0();
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00012D1F File Offset: 0x00010F1F
		public void method_1(string string_1)
		{
			this.class2442_0.method_1(string_1);
		}

		// Token: 0x04000E84 RID: 3716
		private string string_0;

		// Token: 0x04000E85 RID: 3717
		private Class2442 class2442_0;
	}
}
