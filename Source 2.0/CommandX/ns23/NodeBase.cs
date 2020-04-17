using System;
using System.Collections;
using DotSpatial.Topology;

namespace ns23
{
	// Token: 0x02000690 RID: 1680
	public abstract class NodeBase
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000FEF7C File Offset: 0x000FD17C
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x00017474 File Offset: 0x00015674
		public Node[] Nodes
		{
			get
			{
				return this._subnode;
			}
			set
			{
				this._subnode = value;
			}
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0001747D File Offset: 0x0001567D
		public  void vmethod_0(object object_0)
		{
			this._items.Add(object_0);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000FEF94 File Offset: 0x000FD194
		public  void vmethod_1(IEnvelope ienvelope_0, Interface43 interface43_0)
		{
			if (this.vmethod_2(ienvelope_0))
			{
				this.method_0(interface43_0);
				for (int i = 0; i < 4; i++)
				{
					if (this._subnode[i] != null)
					{
						this._subnode[i].vmethod_1(ienvelope_0, interface43_0);
					}
				}
			}
		}

		// Token: 0x06002AA4 RID: 10916
		protected abstract bool vmethod_2(IEnvelope ienvelope_0);

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000FEFDC File Offset: 0x000FD1DC
		private void method_0(Interface43 interface43_0)
		{
			IEnumerator enumerator = this._items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				interface43_0.VisitItem(enumerator.Current);
			}
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000FF00C File Offset: 0x000FD20C
		public static int smethod_0(IEnvelope ienvelope_0, Coordinate coordinate_0)
		{
			int result = -1;
			if (ienvelope_0.GetMinimum().X >= coordinate_0.X)
			{
				if (ienvelope_0.GetMinimum().Y >= coordinate_0.Y)
				{
					result = 3;
				}
				if (ienvelope_0.GetMaximum().Y <= coordinate_0.Y)
				{
					result = 1;
				}
			}
			if (ienvelope_0.GetMaximum().X <= coordinate_0.X)
			{
				if (ienvelope_0.GetMinimum().Y >= coordinate_0.Y)
				{
					result = 2;
				}
				if (ienvelope_0.GetMaximum().Y <= coordinate_0.Y)
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x0400144D RID: 5197
		private IList _items = new ArrayList();

		// Token: 0x0400144E RID: 5198
		private Node[] _subnode = new Node[4];
	}
}
