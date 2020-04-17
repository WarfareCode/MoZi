using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace ns6
{
	// Token: 0x02000C83 RID: 3203
	public class Class401 : Class397
	{
		// Token: 0x06006A2F RID: 27183 RVA: 0x0002DB70 File Offset: 0x0002BD70
		protected internal Class401(int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1) : base(Enum119.const_2, int_1, stringDictionary_1, idataRecord_1)
		{
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x0002DB7C File Offset: 0x0002BD7C
		protected internal Class401(int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1, byte[] byte_0) : base(Enum119.const_2, int_1, stringDictionary_1, idataRecord_1)
		{
			base.method_2(byte_0, out this.struct49_0, out this.list_0);
		}

		// Token: 0x04003BF8 RID: 15352
		internal Struct49 struct49_0;

		// Token: 0x04003BF9 RID: 15353
		internal List<Struct48[]> list_0;
	}
}
