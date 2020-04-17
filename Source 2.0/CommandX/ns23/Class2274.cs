using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;
using ns28;

namespace ns23
{
	// Token: 0x020006BC RID: 1724
	public sealed class Class2274 : Class2272, ISpatialIndex
	{
		// Token: 0x06002B89 RID: 11145 RVA: 0x00017B37 File Offset: 0x00015D37
		public Class2274() : this(10)
		{
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00017B41 File Offset: 0x00015D41
		public Class2274(int int_1) : base(int_1)
		{
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00100750 File Offset: 0x000FE950
		protected override Class2272.Interface46 vmethod_1()
		{
			return new Class2274.Class2279();
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00017B4A File Offset: 0x00015D4A
		public  void Insert(IEnvelope ienvelope_0, object object_0)
		{
			if (!ienvelope_0.IsNull())
			{
				base.vmethod_7(ienvelope_0, object_0);
			}
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00100764 File Offset: 0x000FE964
		public  IList Query(IEnvelope ienvelope_0)
		{
			return base.vmethod_8(ienvelope_0);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00017B5F File Offset: 0x00015D5F
		public  void vmethod_11(IEnvelope ienvelope_0, Interface43 interface43_0)
		{
			base.vmethod_9(ienvelope_0, interface43_0);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0010077C File Offset: 0x000FE97C
		private static double smethod_0(double double_0, double double_1)
		{
			return (double_0 + double_1) / 2.0;
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00100798 File Offset: 0x000FE998
		private static double smethod_1(IEnvelope ienvelope_0)
		{
			return Class2274.smethod_0(ienvelope_0.GetMinimum().X, ienvelope_0.GetMaximum().X);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x001007C4 File Offset: 0x000FE9C4
		private static double smethod_2(IEnvelope ienvelope_0)
		{
			return Class2274.smethod_0(ienvelope_0.GetMinimum().Y, ienvelope_0.GetMaximum().Y);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x001007F0 File Offset: 0x000FE9F0
		protected override IList vmethod_4(IList ilist_0, int int_1)
		{
			Class2347.smethod_0(ilist_0.Count != 0);
			int num = (int)Math.Ceiling((double)ilist_0.Count / (double)this.vmethod_0());
			ArrayList arrayList = new ArrayList(ilist_0);
			arrayList.Sort(new Class2274.Class2280(this));
			IList[] ilist_ = this.vmethod_13(arrayList, (int)Math.Ceiling(Math.Sqrt((double)num)));
			return this.method_3(ilist_, int_1);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00100858 File Offset: 0x000FEA58
		private IList method_3(IList[] ilist_0, int int_1)
		{
			Class2347.smethod_0(ilist_0.Length > 0);
			IList list = new ArrayList();
			for (int i = 0; i < ilist_0.Length; i++)
			{
				IList list2 = this.vmethod_12(ilist_0[i], int_1);
				foreach (object current in list2)
				{
					list.Add(current);
				}
			}
			return list;
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x001008E4 File Offset: 0x000FEAE4
		protected  IList vmethod_12(IList ilist_0, int int_1)
		{
			return base.vmethod_4(ilist_0, int_1);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x001008FC File Offset: 0x000FEAFC
		protected  IList[] vmethod_13(IList ilist_0, int int_1)
		{
			int num = (int)Math.Ceiling((double)ilist_0.Count / (double)int_1);
			IList[] array = new IList[int_1];
			IEnumerator enumerator = ilist_0.GetEnumerator();
			for (int i = 0; i < int_1; i++)
			{
				array[i] = new ArrayList();
				int num2 = 0;
				while (num2 < num && enumerator.MoveNext())
				{
					Interface45 value = (Interface45)enumerator.Current;
					array[i].Add(value);
					num2++;
				}
			}
			return array;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0010097C File Offset: 0x000FEB7C
		protected override Class2269 vmethod_3(int int_1)
		{
			return new Class2274.Class2271(int_1);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00100994 File Offset: 0x000FEB94
		protected override IComparer vmethod_10()
		{
			return new Class2274.Class2281(this);
		}

		// Token: 0x020006BD RID: 1725
		private sealed class Class2271 : Class2269
		{
			// Token: 0x06002B98 RID: 11160 RVA: 0x00017ACC File Offset: 0x00015CCC
			public Class2271(int int_1) : base(int_1)
			{
			}

			// Token: 0x06002B99 RID: 11161 RVA: 0x001009AC File Offset: 0x000FEBAC
			protected override object vmethod_1()
			{
				Envelope envelope = null;
				IEnumerator enumerator = this.vmethod_0().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Interface45 @interface = (Interface45)enumerator.Current;
					if (envelope == null)
					{
						envelope = new Envelope((Envelope)@interface.imethod_0());
					}
					else
					{
						Class2183.smethod_13(envelope, (Envelope)@interface.imethod_0());
					}
				}
				return envelope;
			}
		}

		// Token: 0x020006BE RID: 1726
		private sealed class Class2279 : Class2272.Interface46
		{
			// Token: 0x06002B9A RID: 11162 RVA: 0x00017B69 File Offset: 0x00015D69
			public bool imethod_0(object object_0, object object_1)
			{
				return Class2183.smethod_15((Envelope)object_0, (Envelope)object_1);
			}
		}

		// Token: 0x020006BF RID: 1727
		private sealed class Class2280 : IComparer
		{
			// Token: 0x06002B9C RID: 11164 RVA: 0x00017B7C File Offset: 0x00015D7C
			public Class2280(Class2274 class2274_1)
			{
				this.class2274_0 = class2274_1;
			}

			// Token: 0x06002B9D RID: 11165 RVA: 0x00100A10 File Offset: 0x000FEC10
			public int Compare(object x, object y)
			{
				return this.class2274_0.vmethod_6(Class2274.smethod_1((Envelope)((Interface45)x).imethod_0()), Class2274.smethod_1((Envelope)((Interface45)y).imethod_0()));
			}

			// Token: 0x04001496 RID: 5270
			private readonly Class2274 class2274_0;
		}

		// Token: 0x020006C0 RID: 1728
		private sealed class Class2281 : IComparer
		{
			// Token: 0x06002B9E RID: 11166 RVA: 0x00017B8B File Offset: 0x00015D8B
			public Class2281(Class2274 class2274_1)
			{
				this.class2274_0 = class2274_1;
			}

			// Token: 0x06002B9F RID: 11167 RVA: 0x00100A54 File Offset: 0x000FEC54
			public int Compare(object x, object y)
			{
				return this.class2274_0.vmethod_6(Class2274.smethod_2((Envelope)((Interface45)x).imethod_0()), Class2274.smethod_2((Envelope)((Interface45)y).imethod_0()));
			}

			// Token: 0x04001497 RID: 5271
			private readonly Class2274 class2274_0;
		}
	}
}
