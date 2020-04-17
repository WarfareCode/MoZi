using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns23;
using ns25;

namespace ns27
{
	// Token: 0x0200070D RID: 1805
	public sealed class Class2299 : Interface47
	{
		// Token: 0x06002CF2 RID: 11506 RVA: 0x00102D10 File Offset: 0x00100F10
		public IList imethod_1()
		{
			return Class2295.smethod_0(this.ilist_0);
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x0001872F File Offset: 0x0001692F
		public void imethod_0(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
			this.class2287_0 = new Class2287();
			this.class2297_0 = new Class2297(this.class2287_0.method_2());
			this.method_0(ilist_1, this.class2239_0);
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00102D2C File Offset: 0x00100F2C
		private void method_0(IList ilist_1, LineIntersector class2239_1)
		{
			IList ilist_2 = this.method_1(ilist_1, class2239_1);
			this.method_2(ilist_2);
			this.method_3(ilist_1);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00102D50 File Offset: 0x00100F50
		private IList method_1(IList ilist_1, LineIntersector class2239_1)
		{
			Class2284 @class = new Class2284(class2239_1);
			this.class2287_0.method_1(@class);
			this.class2287_0.imethod_0(ilist_1);
			return @class.method_0();
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00102D84 File Offset: 0x00100F84
		private void method_2(IList ilist_1)
		{
			foreach (object current in ilist_1)
			{
				Coordinate coordinate_ = (Coordinate)current;
				Class2296 class2296_ = new Class2296(coordinate_, this.double_0, this.class2239_0);
				this.class2297_0.method_1(class2296_);
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00102DFC File Offset: 0x00100FFC
		public void method_3(IList ilist_1)
		{
			foreach (object current in ilist_1)
			{
				Class2295 class2295_ = (Class2295)current;
				this.method_4(class2295_);
			}
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00102E58 File Offset: 0x00101058
		private void method_4(Class2295 class2295_0)
		{
			IList<Coordinate> list = class2295_0.method_3();
			for (int i = 0; i < list.Count - 1; i++)
			{
				Class2296 class2296_ = new Class2296(list[i], this.double_0, this.class2239_0);
				if (this.class2297_0.method_0(class2296_, class2295_0, i))
				{
					class2295_0.method_9(list[i], i);
				}
			}
		}

		// Token: 0x0400151A RID: 5402
		private readonly LineIntersector class2239_0;

		// Token: 0x0400151B RID: 5403
		private readonly double double_0;

		// Token: 0x0400151C RID: 5404
		private IList ilist_0;

		// Token: 0x0400151D RID: 5405
		private Class2287 class2287_0;

		// Token: 0x0400151E RID: 5406
		private Class2297 class2297_0;
	}
}
