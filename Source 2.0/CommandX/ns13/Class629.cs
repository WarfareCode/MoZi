using System;
using System.Collections;
using GeoAPI.Geometries;
using ns12;

namespace ns13
{
	// Token: 0x020003EA RID: 1002
	public sealed class Class629 : IComparable
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000995B0 File Offset: 0x000977B0
		public IList Nodes
		{
			get
			{
				return this.nodes;
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0001066F File Offset: 0x0000E86F
		public Class629()
		{
			this.class576_0 = new Class576();
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000995C8 File Offset: 0x000977C8
		public ICoordinate method_0()
		{
			return this.icoordinate_0;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x000995E0 File Offset: 0x000977E0
		public int CompareTo(object target)
		{
			Class629 @class = (Class629)target;
			int result;
			if (this.method_0().imethod_0() < @class.method_0().imethod_0())
			{
				result = -1;
			}
			else if (this.method_0().imethod_0() > @class.method_0().imethod_0())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x04000A3C RID: 2620
		private Class576 class576_0;

		// Token: 0x04000A3D RID: 2621
		private IList ilist_0 = new ArrayList();

		// Token: 0x04000A3E RID: 2622
		private IList nodes = new ArrayList();

		// Token: 0x04000A3F RID: 2623
		private ICoordinate icoordinate_0 = null;
	}
}
