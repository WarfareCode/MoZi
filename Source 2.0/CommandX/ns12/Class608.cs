using System;

namespace ns12
{
	// Token: 0x020003B8 RID: 952
	public abstract class Class608 : Interface23
	{
		// Token: 0x06001781 RID: 6017
		protected abstract object vmethod_0();

		// Token: 0x06001782 RID: 6018 RVA: 0x000929E0 File Offset: 0x00090BE0
		public object imethod_0()
		{
			if (this.object_0 == null)
			{
				this.object_0 = this.vmethod_0();
			}
			return this.object_0;
		}

		// Token: 0x040009AC RID: 2476
		private object object_0;
	}
}
