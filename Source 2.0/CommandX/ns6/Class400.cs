using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace ns6
{
	// Token: 0x02000C82 RID: 3202
	public sealed class Class400 : Class397
	{
		// Token: 0x06006A2D RID: 27181 RVA: 0x0002DB50 File Offset: 0x0002BD50
		protected internal Class400(int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1, byte[] byte_0) : base(Enum119.const_3, int_1, stringDictionary_1, idataRecord_1)
		{
			base.method_2(byte_0, out this.struct49_0, out this.list_0);
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x003909E0 File Offset: 0x0038EBE0
		public List<Struct48[]> method_3()
		{
			return this.list_0;
		}

		// Token: 0x04003BF6 RID: 15350
		private Struct49 struct49_0;

		// Token: 0x04003BF7 RID: 15351
		private List<Struct48[]> list_0;
	}
}
