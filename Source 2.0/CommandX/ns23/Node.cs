using System;
using DotSpatial.Topology;
using ns24;
using ns28;

namespace ns23
{
	// Token: 0x0200069C RID: 1692
	public sealed class Node : NodeBase
	{
		// Token: 0x06002AE2 RID: 10978 RVA: 0x000FF4B0 File Offset: 0x000FD6B0
		public Node(IEnvelope env, int level)
		{
			this._env = env;
			this._level = level;
			this._centre = new Coordinate();
			this._centre.X = (env.GetMinimum().X + env.GetMaximum().X) / 2.0;
			this._centre.Y = (env.GetMinimum().Y + env.GetMaximum().Y) / 2.0;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000FF534 File Offset: 0x000FD734
		public  IEnvelope GetEnvelope()
		{
			return this._env;
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000FF54C File Offset: 0x000FD74C
		public static Node CreateNode(IEnvelope env)
		{
			Key key = new Key(env);
			return new Node(key.GetEnvelope(), key.GetLevel());
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000FF574 File Offset: 0x000FD774
		public static Node smethod_2(Node class2266_1, IEnvelope ienvelope_1)
		{
			Envelope envelope = new Envelope(ienvelope_1);
			if (class2266_1 != null)
			{
				Class2183.smethod_13(envelope, class2266_1._env);
			}
			Node node = Node.CreateNode(envelope);
			if (class2266_1 != null)
			{
				node.vmethod_6(class2266_1);
			}
			return node;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00017660 File Offset: 0x00015860
		protected override bool vmethod_2(IEnvelope ienvelope_1)
		{
			return Class2183.smethod_15(this._env, ienvelope_1);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000FF5B4 File Offset: 0x000FD7B4
		public  Node vmethod_4(IEnvelope ienvelope_1)
		{
			int num = NodeBase.smethod_0(ienvelope_1, this._centre);
			Node result;
			if (num != -1)
			{
				Node node = this.method_1(num);
				result = node.vmethod_4(ienvelope_1);
			}
			else
			{
				result = this;
			}
			return result;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000FF5EC File Offset: 0x000FD7EC
		public  NodeBase vmethod_5(IEnvelope ienvelope_1)
		{
			int num = NodeBase.smethod_0(ienvelope_1, this._centre);
			NodeBase result;
			if (num == -1)
			{
				result = this;
			}
			else if (base.Nodes[num] != null)
			{
				Node node = base.Nodes[num];
				result = node.vmethod_5(ienvelope_1);
			}
			else
			{
				result = this;
			}
			return result;
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000FF638 File Offset: 0x000FD838
		public  void vmethod_6(Node class2266_1)
		{
			Class2347.smethod_0(this._env == null || Class2183.smethod_9(this._env, class2266_1.GetEnvelope()));
			int num = NodeBase.smethod_0(class2266_1._env, this._centre);
			if (class2266_1._level == this._level - 1)
			{
				base.Nodes[num] = class2266_1;
			}
			else
			{
				Node node = this.method_2(num);
				node.vmethod_6(class2266_1);
				base.Nodes[num] = node;
			}
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000FF6B0 File Offset: 0x000FD8B0
		private Node method_1(int int_1)
		{
			if (base.Nodes[int_1] == null)
			{
				base.Nodes[int_1] = this.method_2(int_1);
			}
			return base.Nodes[int_1];
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000FF6E8 File Offset: 0x000FD8E8
		private Node method_2(int int_1)
		{
			double double_ = 0.0;
			double double_2 = 0.0;
			double double_3 = 0.0;
			double double_4 = 0.0;
			switch (int_1)
			{
			case 0:
				double_ = this._env.GetMinimum().X;
				double_2 = this._centre.X;
				double_3 = this._env.GetMinimum().Y;
				double_4 = this._centre.Y;
				break;
			case 1:
				double_ = this._centre.X;
				double_2 = this._env.GetMaximum().X;
				double_3 = this._env.GetMinimum().Y;
				double_4 = this._centre.Y;
				break;
			case 2:
				double_ = this._env.GetMinimum().X;
				double_2 = this._centre.X;
				double_3 = this._centre.Y;
				double_4 = this._env.GetMaximum().Y;
				break;
			case 3:
				double_ = this._centre.X;
				double_2 = this._env.GetMaximum().X;
				double_3 = this._centre.Y;
				double_4 = this._env.GetMaximum().Y;
				break;
			}
			Envelope env = new Envelope(double_, double_2, double_3, double_4);
			return new Node(env, this._level - 1);
		}

		// Token: 0x04001463 RID: 5219
		private readonly Coordinate _centre;

		// Token: 0x04001464 RID: 5220
		private readonly IEnvelope _env;

		// Token: 0x04001465 RID: 5221
		private readonly int _level;
	}
}
