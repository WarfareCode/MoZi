using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;
using ns25;
using ns28;

namespace ns27
{
	// Token: 0x02000722 RID: 1826
	public sealed class Class2303 : IComparable
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x00103A44 File Offset: 0x00101C44
		public  IList Nodes
		{
			get
			{
				return this.ilist_1;
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00018B90 File Offset: 0x00016D90
		public Class2303()
		{
			this.class2306_0 = new Class2306();
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00103A5C File Offset: 0x00101C5C
		public  IList vmethod_0()
		{
			return this.ilist_0;
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00103A74 File Offset: 0x00101C74
		public  Coordinate vmethod_1()
		{
			return this.coordinate_0;
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00103A8C File Offset: 0x00101C8C
		public  int CompareTo(object target)
		{
			Class2303 @class = (Class2303)target;
			int result;
			if (this.vmethod_1().X < @class.vmethod_1().X)
			{
				result = -1;
			}
			else if (this.vmethod_1().X > @class.vmethod_1().X)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00018BB9 File Offset: 0x00016DB9
		public  void vmethod_2(Class2200 class2200_0)
		{
			this.method_0(class2200_0);
			this.class2306_0.method_2(this.ilist_0);
			this.coordinate_0 = this.class2306_0.method_1();
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00103AE8 File Offset: 0x00101CE8
		private void method_0(Class2200 class2200_0)
		{
			Stack stack = new Stack();
			stack.Push(class2200_0);
			while (stack.Count != 0)
			{
				Class2200 class2200_ = (Class2200)stack.Pop();
				this.method_1(class2200_, stack);
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00103B28 File Offset: 0x00101D28
		private void method_1(Class2200 class2200_0, Stack stack_0)
		{
			class2200_0.vmethod_4(true);
			this.ilist_1.Add(class2200_0);
			IEnumerator enumerator = class2200_0.vmethod_6().vmethod_4();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				this.ilist_0.Add(@class);
				Class2193 class2 = @class.vmethod_29();
				Class2200 class3 = class2.vmethod_7();
				if (!class3.vmethod_3())
				{
					stack_0.Push(class3);
				}
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00103B98 File Offset: 0x00101D98
		private void method_2()
		{
			IEnumerator enumerator = this.ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				@class.vmethod_22(false);
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00103BD0 File Offset: 0x00101DD0
		public  void vmethod_3(int int_0)
		{
			this.method_2();
			Class2193 @class = this.class2306_0.method_0();
			@class.vmethod_14(Enum158.const_2, int_0);
			Class2303.smethod_2(@class);
			Class2303.smethod_0(@class);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00103C04 File Offset: 0x00101E04
		private static void smethod_0(Class2193 class2193_0)
		{
			HashSet<Class2200> hashSet = new HashSet<Class2200>();
			Queue queue = new Queue();
			Class2200 @class = class2193_0.vmethod_7();
			queue.Enqueue(@class);
			hashSet.Add(@class);
			class2193_0.vmethod_22(true);
			while (queue.Count != 0)
			{
				Class2200 class2 = (Class2200)queue.Dequeue();
				hashSet.Add(class2);
				Class2303.smethod_1(class2);
				IEnumerator enumerator = class2.vmethod_6().vmethod_4();
				while (enumerator.MoveNext())
				{
					Class2193 class3 = (Class2193)enumerator.Current;
					Class2193 class4 = class3.vmethod_29();
					if (!class4.vmethod_21())
					{
						Class2200 class5 = class4.vmethod_7();
						if (!hashSet.Contains(class5))
						{
							queue.Enqueue(class5);
							hashSet.Add(class5);
						}
					}
				}
			}
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00103CC4 File Offset: 0x00101EC4
		private static void smethod_1(Class2200 class2200_0)
		{
			Class2193 @class = null;
			IEnumerator enumerator = class2200_0.vmethod_6().vmethod_4();
            IEnumerator enumerator2;

            while (enumerator.MoveNext())
			{
				Class2193 class2 = (Class2193)enumerator.Current;
				if (class2.vmethod_21() || class2.vmethod_29().vmethod_21())
				{
					@class = class2;
					IL_45:
					Class2347.smethod_1(@class != null, "unable to find edge to compute depths at " + class2200_0.vmethod_5());
					((Class2196)class2200_0.vmethod_6()).vmethod_10(@class);
					 enumerator2 = class2200_0.vmethod_6().vmethod_4();
					while (enumerator2.MoveNext())
					{
						Class2193 class3 = (Class2193)enumerator2.Current;
						class3.vmethod_22(true);
						Class2303.smethod_2(class3);
					}
					return;
				}
			}
            Class2347.smethod_1(@class != null, "unable to find edge to compute depths at " + class2200_0.vmethod_5());
            ((Class2196)class2200_0.vmethod_6()).vmethod_10(@class);
            enumerator2 = class2200_0.vmethod_6().vmethod_4();
            while (enumerator2.MoveNext())
            {
                Class2193 class3 = (Class2193)enumerator2.Current;
                class3.vmethod_22(true);
                Class2303.smethod_2(class3);
            }
            return;
        }

		// Token: 0x06002D76 RID: 11638 RVA: 0x00103D78 File Offset: 0x00101F78
		private static void smethod_2(Class2193 class2193_0)
		{
			Class2193 @class = class2193_0.vmethod_29();
			@class.vmethod_13(Enum158.const_1, class2193_0.vmethod_12(Enum158.const_2));
			@class.vmethod_13(Enum158.const_2, class2193_0.vmethod_12(Enum158.const_1));
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00103DA8 File Offset: 0x00101FA8
		public  void vmethod_4()
		{
			IEnumerator enumerator = this.ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				if (@class.vmethod_12(Enum158.const_2) >= 1 && @class.vmethod_12(Enum158.const_1) <= 0 && !@class.vmethod_20())
				{
					@class.vmethod_19(true);
				}
			}
		}

		// Token: 0x0400153E RID: 5438
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x0400153F RID: 5439
		private readonly Class2306 class2306_0;

		// Token: 0x04001540 RID: 5440
		private readonly IList ilist_1 = new ArrayList();

		// Token: 0x04001541 RID: 5441
		private Coordinate coordinate_0;
	}
}
