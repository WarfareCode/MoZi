using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns23
{
	// Token: 0x0200069D RID: 1693
	public sealed class Quadtree : ISpatialIndex
	{
		// Token: 0x06002AEC RID: 10988 RVA: 0x0001766E File Offset: 0x0001586E
		public Quadtree()
		{
			this.Root = new Root();
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000FF84C File Offset: 0x000FDA4C
		public  void Insert(IEnvelope itemEnv, object item)
		{
			this.CollectStats(itemEnv);
			IEnvelope itemEnv2 = Quadtree.EnsureExtent(itemEnv, this._minExtent);
			this.Root.Insert(itemEnv2, item);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000FF87C File Offset: 0x000FDA7C
		public  IList Query(IEnvelope searchEnv)
		{
			ArrayListVisitor arrayListVisitor = new ArrayListVisitor();
			this.vmethod_0(searchEnv, arrayListVisitor);
			return arrayListVisitor.GetItems();
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00017690 File Offset: 0x00015890
		public  void vmethod_0(IEnvelope ienvelope_0, Interface43 interface43_0)
		{
			this.Root.vmethod_1(ienvelope_0, interface43_0);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000FF8A0 File Offset: 0x000FDAA0
		public static IEnvelope EnsureExtent(IEnvelope ienvelope_0, double double_1)
		{
			double num = ienvelope_0.GetMinimum().X;
			double num2 = ienvelope_0.GetMaximum().X;
			double num3 = ienvelope_0.GetMinimum().Y;
			double num4 = ienvelope_0.GetMaximum().Y;
			IEnvelope result;
			if (num != num2 && num3 != num4)
			{
				result = ienvelope_0;
			}
			else
			{
				if (num == num2)
				{
					num -= double_1 / 2.0;
					num2 = num + double_1 / 2.0;
				}
				if (num3 == num4)
				{
					num3 -= double_1 / 2.0;
					num4 = num3 + double_1 / 2.0;
				}
				result = new Envelope(num, num2, num3, num4);
			}
			return result;
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000FF948 File Offset: 0x000FDB48
		private void CollectStats(Interface29 interface29_0)
		{
			double width = interface29_0.GetWidth();
			if (width < this._minExtent && width > 0.0)
			{
				this._minExtent = width;
			}
			double width2 = interface29_0.GetWidth();
			if (width2 < this._minExtent && width2 > 0.0)
			{
				this._minExtent = width2;
			}
		}

		// Token: 0x04001466 RID: 5222
		protected readonly Root Root;

		// Token: 0x04001467 RID: 5223
		private double _minExtent = 1.0;
	}
}
