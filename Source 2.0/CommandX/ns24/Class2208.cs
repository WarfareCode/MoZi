using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns25;

namespace ns24
{
	// Token: 0x0200058D RID: 1421
	public class Class2208
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000E2300 File Offset: 0x000E0500
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x00014F56 File Offset: 0x00013156
		public virtual Class2221 Nodes
		{
			get
			{
				return this.class2221_0;
			}
			set
			{
				this.class2221_0 = value;
			}
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00014F5F File Offset: 0x0001315F
		public Class2208(Class2218 class2218_0)
		{
			this.class2221_0 = new Class2221(class2218_0);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00014F89 File Offset: 0x00013189
		public Class2208()
		{
			this.class2221_0 = new Class2221(new Class2218());
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00014FB7 File Offset: 0x000131B7
		public  void vmethod_0(Class2192 class2192_0)
		{
			this.class2221_0.vmethod_1(class2192_0);
			this.ilist_0.Add(class2192_0);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000E2318 File Offset: 0x000E0518
		public  void vmethod_1(IList ilist_2)
		{
			IEnumerator enumerator = ilist_2.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				this.ilist_1.Add(@class);
				Class2193 class2 = new Class2193(@class, true);
				Class2193 class3 = new Class2193(@class, false);
				class2.vmethod_30(class3);
				class3.vmethod_30(class2);
				this.vmethod_0(class2);
				this.vmethod_0(class3);
			}
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000E237C File Offset: 0x000E057C
		public virtual Class2192 vmethod_2(Class2199 class2199_0)
		{
			IEnumerator enumerator = this.vmethod_8().GetEnumerator();
			Class2192 result;
			while (enumerator.MoveNext())
			{
				Class2192 @class = (Class2192)enumerator.Current;
				if (Class2199.smethod_0(@class.vmethod_0(), class2199_0))
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000E23C4 File Offset: 0x000E05C4
		public virtual Class2199 vmethod_3(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			int i = 0;
			Class2199 result;
			while (i < this.ilist_1.Count)
			{
				Class2199 @class = (Class2199)this.ilist_1[i];
				IList<Coordinate> list = @class.vmethod_8();
				if (!Class2208.smethod_0(coordinate_0, coordinate_1, list[0], list[1]))
				{
					if (!Class2208.smethod_0(coordinate_0, coordinate_1, list[list.Count - 1], list[list.Count - 2]))
					{
						i++;
						continue;
					}
					result = @class;
				}
				else
				{
					result = @class;
				}
				return result;
			}
			result = null;
			return result;
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000E2450 File Offset: 0x000E0650
		public  IEnumerator vmethod_4()
		{
			return this.class2221_0.vmethod_3();
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x000E246C File Offset: 0x000E066C
		public  IEnumerator vmethod_5()
		{
			return this.ilist_1.GetEnumerator();
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00014FD2 File Offset: 0x000131D2
		protected virtual void vmethod_6(Class2199 class2199_0)
		{
			this.ilist_1.Add(class2199_0);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x000E2488 File Offset: 0x000E0688
		public  void vmethod_7()
		{
			IEnumerator enumerator = this.class2221_0.vmethod_3();
			while (enumerator.MoveNext())
			{
				Class2200 @class = (Class2200)enumerator.Current;
				((Class2196)@class.vmethod_6()).vmethod_8();
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00014FE1 File Offset: 0x000131E1
		private static bool smethod_0(Coordinate coordinate_0, Coordinate coordinate_1, Coordinate coordinate_2, Coordinate coordinate_3)
		{
			return coordinate_0.Equals(coordinate_2) && CgAlgorithms.ComputeOrientation(coordinate_0, coordinate_1, coordinate_3) == 0 && Class2223.smethod_1(coordinate_0, coordinate_1) == Class2223.smethod_1(coordinate_2, coordinate_3);
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x000E24C8 File Offset: 0x000E06C8
		public  IList vmethod_8()
		{
			return this.ilist_0;
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x000E24E0 File Offset: 0x000E06E0
		public IList method_0()
		{
			return this.ilist_1;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x000E24F8 File Offset: 0x000E06F8
		public   bool vmethod_9(int int_0, Coordinate coordinate_0)
		{
			Class2200 @class = this.class2221_0.vmethod_2(coordinate_0);
			bool result;
			if (@class == null)
			{
				result = false;
			}
			else
			{
				Class2217 class2 = @class.vmethod_0();
				result = (class2 != null && class2.vmethod_2(int_0) == LocationType.Boundary);
			}
			return result;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x000E2538 File Offset: 0x000E0738
		public static void smethod_1(IList ilist_2)
		{
			IEnumerator enumerator = ilist_2.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2200 @class = (Class2200)enumerator.Current;
				((Class2196)@class.vmethod_6()).vmethod_8();
			}
		}

		// Token: 0x04001192 RID: 4498
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x04001193 RID: 4499
		private IList ilist_1 = new ArrayList();

		// Token: 0x04001194 RID: 4500
		private Class2221 class2221_0;
	}
}
