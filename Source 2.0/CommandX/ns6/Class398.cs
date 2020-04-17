using System;
using System.Collections.Specialized;
using System.Data;

namespace ns6
{
	// Token: 0x02000C80 RID: 3200
	public sealed class Class398 : Class397
	{
		// Token: 0x06006A2B RID: 27179 RVA: 0x003908B8 File Offset: 0x0038EAB8
		protected internal Class398(int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1, byte[] byte_0) : base(Enum119.const_4, int_1, stringDictionary_1, idataRecord_1)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("shapeData");
			}
			if (byte_0.Length < 48)
			{
				throw new InvalidOperationException("Invalid shape data");
			}
			this.struct49_0 = base.method_1(byte_0, 12, Enum118.const_1);
			int num = Class395.smethod_0(byte_0, 44, Enum118.const_1);
			if (byte_0.Length != 48 + 16 * num)
			{
				throw new InvalidOperationException("Invalid shape data");
			}
			this.struct48_0 = new Struct48[num];
			for (int i = 0; i < num; i++)
			{
				this.struct48_0[i] = new Struct48(Class395.smethod_1(byte_0, 48 + 16 * i, Enum118.const_1), Class395.smethod_1(byte_0, 56 + 16 * i, Enum118.const_1));
			}
		}

		// Token: 0x04003BF3 RID: 15347
		private Struct49 struct49_0;

		// Token: 0x04003BF4 RID: 15348
		private Struct48[] struct48_0;
	}
}
