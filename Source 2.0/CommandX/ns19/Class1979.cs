using System;

namespace ns19
{
	// Token: 0x0200042E RID: 1070
	public abstract class Class1979 : IDisposable
	{
		// Token: 0x06001B75 RID: 7029 RVA: 0x000114CD File Offset: 0x0000F6CD
		protected Class1979(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000B0FF8 File Offset: 0x000AF1F8
		public object method_0()
		{
			return this.object_0;
		}

		// Token: 0x06001B77 RID: 7031
		public abstract bool vmethod_0();

		// Token: 0x06001B78 RID: 7032
		public abstract void vmethod_1();

		// Token: 0x06001B79 RID: 7033 RVA: 0x000B1010 File Offset: 0x000AF210
		public virtual float vmethod_2()
		{
			return 0f;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000114DC File Offset: 0x0000F6DC
		public  void vmethod_3()
		{
			Class1979.class1978_0.method_0(this);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void Dispose()
		{
		}

		// Token: 0x04000BC3 RID: 3011
		internal static Class1978 class1978_0;

		// Token: 0x04000BC4 RID: 3012
		private object object_0;
	}
}
