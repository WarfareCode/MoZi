using System;
using System.Collections;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.GeometriesGraph;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x0200040B RID: 1035
	public class Class639
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0009E3E4 File Offset: 0x0009C5E4
		public IList Nodes
		{
			get
			{
				return new ArrayList(this.nodes.method_4());
			}
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00010C81 File Offset: 0x0000EE81
		public Class639()
		{
			this.nodes = new NodeMap(new Class582());
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0009E404 File Offset: 0x0009C604
		public IEnumerator method_0()
		{
			return this.ilist_0.GetEnumerator();
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0009E420 File Offset: 0x0009C620
		public bool method_1(int int_0, ICoordinate icoordinate_0)
		{
			Class579 @class = this.nodes.method_2(icoordinate_0);
			bool result;
			if (@class == null)
			{
				result = false;
			}
			else
			{
				Class652 class2 = @class.method_0();
				result = (class2 != null && class2.method_2(int_0) == Enum143.const_1);
			}
			return result;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00010CB6 File Offset: 0x0000EEB6
		protected void method_2(Class581 class581_0)
		{
			this.ilist_0.Add(class581_0);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0009E464 File Offset: 0x0009C664
		public IEnumerator method_3()
		{
			return this.nodes.method_3();
		}

		// Token: 0x04000AA2 RID: 2722
		protected IList ilist_0 = new ArrayList();

		// Token: 0x04000AA3 RID: 2723
		protected NodeMap nodes = null;

		// Token: 0x04000AA4 RID: 2724
		protected IList ilist_1 = new ArrayList();
	}
}
