using System;
using System.Collections;

namespace ns23
{
	// Token: 0x02000657 RID: 1623
	public sealed class ArrayListVisitor : Interface43
	{
		// Token: 0x06002973 RID: 10611 RVA: 0x000FD714 File Offset: 0x000FB914
		public  ArrayList GetItems()
		{
			return this._items;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00016AF2 File Offset: 0x00014CF2
		public  void VisitItem(object item)
		{
			this._items.Add(item);
		}

		// Token: 0x040013E5 RID: 5093
		private readonly ArrayList _items = new ArrayList();
	}
}
