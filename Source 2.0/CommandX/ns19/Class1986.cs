using System;
using System.Collections;
using System.Windows.Forms;

namespace ns19
{
	// Token: 0x0200044C RID: 1100
	public sealed class Class1986 : IComparer
	{
		// Token: 0x06001C32 RID: 7218 RVA: 0x000B48F4 File Offset: 0x000B2AF4
		public int Compare(object x, object y)
		{
			int result;
			if (this.sortOrder_0 == SortOrder.None)
			{
				result = 0;
			}
			else
			{
				Class1985 @class = (Class1985)x;
				Class1985 class2 = (Class1985)y;
				int num = 0;
				switch (this.int_0)
				{
				case 0:
					num = @class.method_0().CompareTo(class2.method_0());
					break;
				case 1:
					num = @class.method_1().CompareTo(class2.method_1());
					break;
				case 2:
					num = @class.method_2().CompareTo(class2.method_2());
					break;
				case 3:
					num = @class.method_3().CompareTo(class2.method_3());
					break;
				case 4:
					num = @class.method_4().CompareTo(class2.method_4());
					break;
				case 5:
					num = @class.method_5().CompareTo(class2.method_5());
					break;
				case 6:
					num = @class.method_6().CompareTo(class2.method_6());
					break;
				}
				if (this.sortOrder_0 == SortOrder.Descending)
				{
					num = -num;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x04000C5B RID: 3163
		private int int_0;

		// Token: 0x04000C5C RID: 3164
		private SortOrder sortOrder_0 = SortOrder.Ascending;
	}
}
