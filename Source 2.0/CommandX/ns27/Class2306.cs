using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;
using ns25;
using ns28;

namespace ns27
{
	// Token: 0x02000746 RID: 1862
	public sealed class Class2306
	{
		// Token: 0x06002E40 RID: 11840 RVA: 0x001054A8 File Offset: 0x001036A8
		public Class2193 method_0()
		{
			return this.class2193_1;
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x001054C0 File Offset: 0x001036C0
		public Coordinate method_1()
		{
			return this.coordinate_0;
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x001054D8 File Offset: 0x001036D8
		public void method_2(IList ilist_0)
		{
			IEnumerator enumerator = ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				if (@class.vmethod_17())
				{
					this.method_5(@class);
				}
			}
			Class2347.smethod_1(this.int_0 != 0 || this.coordinate_0.Equals(this.class2193_0.vmethod_3()), "inconsistency in rightmost processing");
			if (this.int_0 == 0)
			{
				this.method_3();
			}
			else
			{
				this.method_4();
			}
			this.class2193_1 = this.class2193_0;
			Enum158 @enum = this.method_6(this.class2193_0, this.int_0);
			if (@enum == Enum158.const_1)
			{
				this.class2193_1 = this.class2193_0.vmethod_29();
			}
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00105594 File Offset: 0x00103794
		private void method_3()
		{
			Class2200 @class = this.class2193_0.vmethod_7();
			Class2196 class2 = (Class2196)@class.vmethod_6();
			this.class2193_0 = class2.vmethod_7();
			if (!this.class2193_0.vmethod_17())
			{
				this.class2193_0 = this.class2193_0.vmethod_29();
				this.int_0 = this.class2193_0.vmethod_0().vmethod_8().Count - 1;
			}
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00105600 File Offset: 0x00103800
		private void method_4()
		{
			IList<Coordinate> list = this.class2193_0.vmethod_0().vmethod_8();
			Class2347.smethod_1(this.int_0 > 0 && this.int_0 < list.Count, "rightmost point expected to be interior vertex of edge");
			Coordinate coordinate = list[this.int_0 - 1];
			Coordinate coordinate2 = list[this.int_0 + 1];
			int num = CgAlgorithms.ComputeOrientation(this.coordinate_0, coordinate2, coordinate);
			bool flag = false;
			if (coordinate.Y < this.coordinate_0.Y && coordinate2.Y < this.coordinate_0.Y && num == 1)
			{
				flag = true;
			}
			else if (coordinate.Y > this.coordinate_0.Y && coordinate2.Y > this.coordinate_0.Y && num == -1)
			{
				flag = true;
			}
			if (flag)
			{
				this.int_0--;
			}
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x001056F4 File Offset: 0x001038F4
		private void method_5(Class2193 class2193_2)
		{
			IList<Coordinate> list = class2193_2.vmethod_0().vmethod_8();
			for (int i = 0; i < list.Count - 1; i++)
			{
				if (Coordinate.Equals(this.coordinate_0, null) || list[i].X > this.coordinate_0.X)
				{
					this.class2193_0 = class2193_2;
					this.int_0 = i;
					this.coordinate_0 = list[i];
				}
			}
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x0010576C File Offset: 0x0010396C
		private Enum158 method_6(Class2193 class2193_2, int int_1)
		{
			Enum158 @enum = Class2306.smethod_0(class2193_2, int_1);
			if (@enum < Enum158.const_0)
			{
				@enum = Class2306.smethod_0(class2193_2, int_1 - 1);
			}
			if (@enum < Enum158.const_0)
			{
				this.coordinate_0 = null;
				this.method_5(class2193_2);
			}
			return @enum;
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x001057B0 File Offset: 0x001039B0
		private static Enum158 smethod_0(Class2192 class2192_0, int int_1)
		{
			Class2199 @class = class2192_0.vmethod_0();
			IList<Coordinate> list = @class.vmethod_8();
			Enum158 result;
			if (int_1 < 0 || int_1 + 1 >= list.Count)
			{
				result = Enum158.const_3;
			}
			else if (list[int_1].Y == list[int_1 + 1].Y)
			{
				result = Enum158.const_3;
			}
			else
			{
				Enum158 @enum = Enum158.const_1;
				if (list[int_1].Y < list[int_1 + 1].Y)
				{
					@enum = Enum158.const_2;
				}
				result = @enum;
			}
			return result;
		}

		// Token: 0x0400158C RID: 5516
		private Coordinate coordinate_0;

		// Token: 0x0400158D RID: 5517
		private Class2193 class2193_0;

		// Token: 0x0400158E RID: 5518
		private int int_0 = -1;

		// Token: 0x0400158F RID: 5519
		private Class2193 class2193_1;
	}
}
