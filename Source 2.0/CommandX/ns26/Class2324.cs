using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;
using ns25;
using ns28;

namespace ns26
{
	// Token: 0x0200078D RID: 1933
	public sealed class Class2324
	{
		// Token: 0x06002FAB RID: 12203 RVA: 0x00019C9C File Offset: 0x00017E9C
		public Class2324(IGeometryFactory igeometryFactory_1)
		{
			this.igeometryFactory_0 = igeometryFactory_1;
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00107B5C File Offset: 0x00105D5C
		public  IList vmethod_0()
		{
			return this.method_1(this.ilist_0);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00107B78 File Offset: 0x00105D78
		public  void vmethod_1(IList ilist_1, IList ilist_2)
		{
			Class2208.smethod_1(ilist_2);
			IList ienumerable_ = this.method_0(ilist_1);
			IList list = new ArrayList();
			IList ienumerable_2 = Class2324.smethod_0(ienumerable_, this.ilist_0, list);
			Class2324.smethod_3(ienumerable_2, this.ilist_0, list);
			Class2324.smethod_4(this.ilist_0, list);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00107BC0 File Offset: 0x00105DC0
		private IList method_0(IEnumerable ienumerable_0)
		{
			IList list = new ArrayList();
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				if (@class.vmethod_18() && @class.vmethod_1().vmethod_7() && @class.vmethod_15() == null)
				{
					Class2206 class2 = new Class2206(@class, this.igeometryFactory_0);
					list.Add(class2);
					class2.vmethod_10();
				}
			}
			return list;
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00107C38 File Offset: 0x00105E38
		private static IList smethod_0(IEnumerable ienumerable_0, IList ilist_1, IList ilist_2)
		{
			IList list = new ArrayList();
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2206 @class = (Class2206)enumerator.Current;
				if (@class.vmethod_5() > 2)
				{
					@class.vmethod_14();
					IList list2 = @class.vmethod_15();
					Class2205 class2 = Class2324.smethod_1(list2);
					if (class2 != null)
					{
						Class2324.smethod_2(class2, list2);
						ilist_1.Add(class2);
						continue;
					}
					IEnumerator enumerator2 = list2.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object current = enumerator2.Current;
							ilist_2.Add(current);
						}
						continue;
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				list.Add(@class);
			}
			return list;
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00107D00 File Offset: 0x00105F00
		private static Class2205 smethod_1(IEnumerable ienumerable_0)
		{
			int num = 0;
			Class2205 result = null;
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2205 @class = (Class2207)enumerator.Current;
				if (!@class.vmethod_0())
				{
					result = @class;
					num++;
				}
			}
			Class2347.smethod_1(num <= 1, "found two shells in MinimalEdgeRing list");
			return result;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00107D54 File Offset: 0x00105F54
		private static void smethod_2(Class2205 class2205_0, IEnumerable ienumerable_0)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2207 @class = (Class2207)enumerator.Current;
				if (@class.vmethod_0())
				{
					@class.vmethod_3(class2205_0);
				}
			}
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00107D90 File Offset: 0x00105F90
		private static void smethod_3(IEnumerable ienumerable_0, IList ilist_1, IList ilist_2)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2205 @class = (Class2205)enumerator.Current;
				@class.vmethod_10();
				if (@class.vmethod_0())
				{
					ilist_2.Add(@class);
				}
				else
				{
					ilist_1.Add(@class);
				}
			}
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00107DE0 File Offset: 0x00105FE0
		private static void smethod_4(IEnumerable ienumerable_0, IEnumerable ienumerable_1)
		{
			IEnumerator enumerator = ienumerable_1.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2205 @class = (Class2205)enumerator.Current;
				if (@class.vmethod_2() == null)
				{
					Class2205 class2 = Class2324.smethod_5(@class, ienumerable_0);
                    //ZSP TEST 
                    Class2347.smethod_1(class2 != null, "unable to assign hole to a shell");
					@class.vmethod_3(class2);
				}
			}

       }

        // Token: 0x06002FB4 RID: 12212 RVA: 0x00107E38 File Offset: 0x00106038
        private static Class2205 smethod_5(Class2205 class2205_0, IEnumerable ienumerable_0)
		{
			ILinearRing linearRing = class2205_0.vmethod_1();
			IEnvelope envelopeInternal = linearRing.GetEnvelopeInternal();
			Coordinate p = linearRing.GetCoordinates()[0];
			Class2205 @class = null;
			IEnvelope ienvelope_ = null;
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2205 class2 = (Class2205)enumerator.Current;
				ILinearRing linearRing2 = class2.vmethod_1();
				IEnvelope envelopeInternal2 = linearRing2.GetEnvelopeInternal();
				if (@class != null)
				{
					ienvelope_ = @class.vmethod_1().GetEnvelopeInternal();
				}
				bool flag = false;
				if (Class2183.smethod_9(envelopeInternal2, envelopeInternal) && CgAlgorithms.IsPointInRing(p, linearRing2.GetCoordinates()))
				{
					flag = true;
				}
				if (flag && (@class == null || Class2183.smethod_9(ienvelope_, envelopeInternal2)))
				{
					@class = class2;
				}
			}
			return @class;
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00107EF4 File Offset: 0x001060F4
		private IList method_1(IEnumerable ienumerable_0)
		{
			IList list = new ArrayList();
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2205 @class = (Class2205)enumerator.Current;
				IPolygon value = @class.vmethod_7(this.igeometryFactory_0);
				list.Add(value);
			}
			return list;
		}

		// Token: 0x04001613 RID: 5651
		private readonly IGeometryFactory igeometryFactory_0;

		// Token: 0x04001614 RID: 5652
		private readonly IList ilist_0 = new ArrayList();
	}
}
