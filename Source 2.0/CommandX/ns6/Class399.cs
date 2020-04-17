using System;
using System.Collections.Specialized;
using System.Data;

namespace ns6
{
	// Token: 0x02000C81 RID: 3201
	public sealed class Class399 : Class397
	{
		// Token: 0x06006A2C RID: 27180 RVA: 0x00390980 File Offset: 0x0038EB80
		protected internal Class399(int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1, byte[] byte_0) : base(Enum119.const_1, int_1, stringDictionary_1, idataRecord_1)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("shapeData");
			}
			if (byte_0.Length != 28)
			{
				throw new InvalidOperationException("Invalid shape data");
			}
			this.struct48_0 = new Struct48(Class395.smethod_1(byte_0, 12, Enum118.const_1), Class395.smethod_1(byte_0, 20, Enum118.const_1));
		}

		// Token: 0x04003BF5 RID: 15349
		private Struct48 struct48_0;
	}
}
