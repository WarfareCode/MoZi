using System;
using System.Collections;
using GeoAPI.Geometries;
using ns12;
using ns14;

namespace GisSharpBlog.NetTopologySuite.GeometriesGraph
{
	// Token: 0x0200040A RID: 1034
	public sealed class NodeMap
	{
		// Token: 0x060019C9 RID: 6601 RVA: 0x00010C67 File Offset: 0x0000EE67
		public NodeMap(Class582 class582_1)
		{
			this.class582_0 = class582_1;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0009E2C8 File Offset: 0x0009C4C8
		public Class579 method_0(ICoordinate icoordinate_0)
		{
			Class579 @class = (Class579)this.idictionary_0[icoordinate_0];
			if (@class == null)
			{
				@class = this.class582_0.vmethod_0(icoordinate_0);
				this.idictionary_0.Add(icoordinate_0, @class);
			}
			return @class;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0009E310 File Offset: 0x0009C510
		public void method_1(Class573 class573_0)
		{
			ICoordinate icoordinate_ = class573_0.method_3();
			Class579 @class = this.method_0(icoordinate_);
			@class.method_4(class573_0);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0009E334 File Offset: 0x0009C534
		public Class579 method_2(ICoordinate icoordinate_0)
		{
			return (Class579)this.idictionary_0[icoordinate_0];
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0009E354 File Offset: 0x0009C554
		public IEnumerator method_3()
		{
			return this.idictionary_0.Values.GetEnumerator();
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0009E374 File Offset: 0x0009C574
		public IList method_4()
		{
			return new ArrayList(this.idictionary_0.Values);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0009E394 File Offset: 0x0009C594
		public IList method_5(int int_0)
		{
			IList list = new ArrayList();
			IEnumerator enumerator = this.method_3();
			while (enumerator.MoveNext())
			{
				Class579 @class = (Class579)enumerator.Current;
				if (@class.method_0().method_2(int_0) == Enum143.const_1)
				{
					list.Add(@class);
				}
			}
			return list;
		}

		// Token: 0x04000AA0 RID: 2720
		private IDictionary idictionary_0 = new SortedList();

		// Token: 0x04000AA1 RID: 2721
		private Class582 class582_0;
	}
}
