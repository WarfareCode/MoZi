using System;
using DotSpatial.Topology;
using ns24;
using ns28;

namespace ns23
{
	// Token: 0x0200069E RID: 1694
	public sealed class Root : NodeBase
	{
		// Token: 0x06002AF2 RID: 10994 RVA: 0x000FF9AC File Offset: 0x000FDBAC
		public  void Insert(IEnvelope itemEnv, object item)
		{
			int num = NodeBase.smethod_0(itemEnv, Root.Origin);
			if (num == -1)
			{
				this.vmethod_0(item);
			}
			else
			{
				Node node = base.Nodes[num];
				if (node == null || !Class2183.smethod_9(node.GetEnvelope(), itemEnv))
				{
					Node node2 = Node.smethod_2(node, itemEnv);
					base.Nodes[num] = node2;
				}
				Root.smethod_1(base.Nodes[num], itemEnv, item);
			}
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000FFA14 File Offset: 0x000FDC14
		private static void smethod_1(Node class2266_1, IEnvelope ienvelope_0, object object_0)
		{
			Class2347.smethod_0(Class2183.smethod_9(class2266_1.GetEnvelope(), ienvelope_0));
			bool flag = Class2263.smethod_0(ienvelope_0.GetMinimum().X, ienvelope_0.GetMaximum().X);
			bool flag2 = Class2263.smethod_0(ienvelope_0.GetMinimum().X, ienvelope_0.GetMaximum().X);
			NodeBase nodeBase;
			if (!flag && !flag2)
			{
				nodeBase = class2266_1.vmethod_4(ienvelope_0);
			}
			else
			{
				nodeBase = class2266_1.vmethod_5(ienvelope_0);
			}
			nodeBase.vmethod_0(object_0);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x0000945D File Offset: 0x0000765D
		protected override bool vmethod_2(IEnvelope ienvelope_0)
		{
			return true;
		}

		// Token: 0x04001468 RID: 5224
		private static readonly Coordinate Origin = new Coordinate(0.0, 0.0);
	}
}
