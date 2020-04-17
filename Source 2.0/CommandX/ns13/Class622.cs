using System;
using System.Collections;
using GeoAPI.Geometries;
using ns14;

namespace ns13
{
	// Token: 0x020003D2 RID: 978
	public sealed class Class622
	{
		// Token: 0x0600183A RID: 6202 RVA: 0x000101AC File Offset: 0x0000E3AC
		public Class622(Class581 class581_1)
		{
			this.class581_0 = class581_1;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00096C64 File Offset: 0x00094E64
		public Class649 method_0(ICoordinate icoordinate_0, int int_0, double double_0)
		{
			Class649 @class = new Class649(icoordinate_0, int_0, double_0);
			Class649 class2 = (Class649)this.idictionary_0[@class];
			Class649 result;
			if (class2 != null)
			{
				result = class2;
			}
			else
			{
				this.idictionary_0.Add(@class, @class);
				result = @class;
			}
			return result;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00096CA8 File Offset: 0x00094EA8
		public IEnumerator method_1()
		{
			return this.idictionary_0.Values.GetEnumerator();
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00096CC8 File Offset: 0x00094EC8
		public void method_2()
		{
			int num = this.class581_0.method_3().Length - 1;
			this.method_0(this.class581_0.method_3()[0], 0, 0.0);
			this.method_0(this.class581_0.method_3()[num], num, 0.0);
		}

		// Token: 0x040009F9 RID: 2553
		private IDictionary idictionary_0 = new SortedList();

		// Token: 0x040009FA RID: 2554
		private Class581 class581_0;
	}
}
