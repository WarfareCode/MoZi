using System;
using System.Collections;
using ns23;

namespace ns24
{
	// Token: 0x0200056B RID: 1387
	public sealed class EdgeList
	{
		// Token: 0x1700028B RID: 651
		public  Class2199 this[int int_0]
		{
			get
			{
				return this.vmethod_3(int_0);
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x000E12FC File Offset: 0x000DF4FC
		public  IList vmethod_0()
		{
			return this._edges;
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00014C1A File Offset: 0x00012E1A
		public  void vmethod_1(Class2199 class2199_0)
		{
			this._edges.Add(class2199_0);
			this._index.Insert(class2199_0.vmethod_9(), class2199_0);
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000E1314 File Offset: 0x000DF514
		public  Class2199 vmethod_2(Class2199 class2199_0)
		{
			ICollection collection = this._index.Query(class2199_0.vmethod_9());
			IEnumerator enumerator = collection.GetEnumerator();
			Class2199 result;
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				if (@class.Equals(class2199_0))
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x000E1364 File Offset: 0x000DF564
		public  Class2199 vmethod_3(int int_0)
		{
			return (Class2199)this._edges[int_0];
		}

		// Token: 0x04001153 RID: 4435
		private readonly IList _edges = new ArrayList();

		// Token: 0x04001154 RID: 4436
		private readonly ISpatialIndex _index = new Quadtree();
	}
}
