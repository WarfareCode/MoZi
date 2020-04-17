using System;
using ns31;

namespace ns32
{
	// Token: 0x02000502 RID: 1282
	public class Class2461
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x000DB6AC File Offset: 0x000D98AC
		protected byte method_0()
		{
			uint num = (this.uint_0[2] & 65535u) | 2u;
			return (byte)(num * (num ^ 1u) >> 8);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000DB6D4 File Offset: 0x000D98D4
		protected void method_1(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("keyData");
			}
			if (byte_0.Length != 12)
			{
				throw new InvalidOperationException("Keys not valid");
			}
			this.uint_0 = new uint[3];
			this.uint_0[0] = (uint)((int)byte_0[3] << 24 | (int)byte_0[2] << 16 | (int)byte_0[1] << 8 | (int)byte_0[0]);
			this.uint_0[1] = (uint)((int)byte_0[7] << 24 | (int)byte_0[6] << 16 | (int)byte_0[5] << 8 | (int)byte_0[4]);
			this.uint_0[2] = (uint)((int)byte_0[11] << 24 | (int)byte_0[10] << 16 | (int)byte_0[9] << 8 | (int)byte_0[8]);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000DB778 File Offset: 0x000D9978
		protected void method_2(byte byte_0)
		{
			this.uint_0[0] = Class2436.smethod_0(this.uint_0[0], byte_0);
			this.uint_0[1] = this.uint_0[1] + (uint)((byte)this.uint_0[0]);
			this.uint_0[1] = this.uint_0[1] * 134775813u + 1u;
			this.uint_0[2] = Class2436.smethod_0(this.uint_0[2], (byte)(this.uint_0[1] >> 24));
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00013FB4 File Offset: 0x000121B4
		protected void method_3()
		{
			this.uint_0[0] = 0u;
			this.uint_0[1] = 0u;
			this.uint_0[2] = 0u;
		}

		// Token: 0x0400102D RID: 4141
		private uint[] uint_0 = null;
	}
}
