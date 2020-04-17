using System;
using System.Collections;

namespace ns15
{
	// Token: 0x02000492 RID: 1170
	public sealed class Class672 : CollectionBase
	{
		// Token: 0x06001E39 RID: 7737 RVA: 0x00012601 File Offset: 0x00010801
		public void method_0(Class670 class670_0)
		{
			base.List.Add(class670_0);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00012610 File Offset: 0x00010810
		public void method_1(int int_0)
		{
			if (int_0 >= base.Count || int_0 < 0)
			{
				throw new IndexOutOfRangeException("The supplied index is out of range");
			}
			base.List.RemoveAt(int_0);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000C39D0 File Offset: 0x000C1BD0
		public Class670 method_2(int int_0)
		{
			if (int_0 >= base.Count || int_0 < 0)
			{
				throw new IndexOutOfRangeException("The supplied index is out of range");
			}
			return (Class670)base.List[int_0];
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0001263E File Offset: 0x0001083E
		public void method_3(int int_0, Class670 class670_0)
		{
			base.List.Insert(int_0, class670_0);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000C3A10 File Offset: 0x000C1C10
		public int method_4(Class670 class670_0)
		{
			return base.List.IndexOf(class670_0);
		}
	}
}
