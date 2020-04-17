using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DotSpatial.Topology;
using ns23;
using ns28;

namespace ns27
{
	// Token: 0x020006EB RID: 1771
	public sealed class Class2290 : Interface47
	{
		// Token: 0x06002C4E RID: 11342 RVA: 0x00101CE0 File Offset: 0x000FFEE0
		public IList imethod_1()
		{
			IList list = this.interface47_0.imethod_1();
			if (this.bool_0)
			{
				this.method_2(list);
			}
			return list;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00101D10 File Offset: 0x000FFF10
		public void imethod_0(IList ilist_0)
		{
			IList ilist_ = ilist_0;
			if (this.bool_0)
			{
				ilist_ = this.method_0(ilist_0);
			}
			this.interface47_0.imethod_0(ilist_);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00101D40 File Offset: 0x000FFF40
		private IList method_0(ICollection icollection_0)
		{
			return Class2348.smethod_0(icollection_0, new Class2348.Delegate38<object>(this.method_4));
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00101D64 File Offset: 0x000FFF64
		private Coordinate[] method_1(IList<Coordinate> ilist_0)
		{
			Coordinate[] array = new Coordinate[ilist_0.Count];
			for (int i = 0; i < ilist_0.Count; i++)
			{
				array[i] = new Coordinate(Math.Round((ilist_0[i].X - this.double_0) * this.double_2), Math.Round((ilist_0[i].Y - this.double_1) * this.double_2));
			}
			return array;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x00018055 File Offset: 0x00016255
		private void method_2(ICollection icollection_0)
		{
			Class2348.smethod_1(icollection_0, new Class2348.Delegate38<object>(this.method_5));
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00101DDC File Offset: 0x000FFFDC
		private void method_3(IList<Coordinate> ilist_0)
		{
			for (int i = 0; i < ilist_0.Count; i++)
			{
				ilist_0[i].X = ilist_0[i].X / this.double_2 + this.double_0;
				ilist_0[i].Y = ilist_0[i].Y / this.double_2 + this.double_1;
			}
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00101E48 File Offset: 0x00100048
		[CompilerGenerated]
		private object method_4(object object_0)
		{
			Class2295 @class = (Class2295)object_0;
			return new Class2295(this.method_1(@class.method_3()), @class.method_0());
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00101E78 File Offset: 0x00100078
		[CompilerGenerated]
		private object method_5(object object_0)
		{
			Class2295 @class = (Class2295)object_0;
			this.method_3(@class.method_3());
			return null;
		}

		// Token: 0x040014F1 RID: 5361
		private readonly bool bool_0;

		// Token: 0x040014F2 RID: 5362
		private readonly Interface47 interface47_0;

		// Token: 0x040014F3 RID: 5363
		private readonly double double_0;

		// Token: 0x040014F4 RID: 5364
		private readonly double double_1;

		// Token: 0x040014F5 RID: 5365
		private readonly double double_2 = 0.0;
	}
}
