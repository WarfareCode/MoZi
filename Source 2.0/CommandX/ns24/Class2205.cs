using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns25;
using ns28;

namespace ns24
{
	// Token: 0x0200056C RID: 1388
	public abstract class Class2205
	{
		// Token: 0x060023EA RID: 9194 RVA: 0x000E1384 File Offset: 0x000DF584
		protected Class2205(Class2193 class2193_1, IGeometryFactory igeometryFactory_1)
		{
			this.igeometryFactory_0 = igeometryFactory_1;
			this.method_4(class2193_1);
			this.method_3();
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000E13E0 File Offset: 0x000DF5E0
		protected IGeometryFactory method_0()
		{
			return this.igeometryFactory_0;
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00014C59 File Offset: 0x00012E59
		public   bool vmethod_0()
		{
			return this.bool_0;
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x000E13F8 File Offset: 0x000DF5F8
		public virtual ILinearRing vmethod_1()
		{
			return this.ilinearRing_0;
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000E1410 File Offset: 0x000DF610
		public virtual Class2205 vmethod_2()
		{
			return this.class2205_0;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00014C61 File Offset: 0x00012E61
		public  void vmethod_3(Class2205 class2205_1)
		{
			this.class2205_0 = class2205_1;
			if (class2205_1 != null)
			{
				this.class2205_0.vmethod_6(this);
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x000E1428 File Offset: 0x000DF628
		public  IList vmethod_4()
		{
			return this.ilist_0;
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000E1440 File Offset: 0x000DF640
		protected Class2193 method_1()
		{
			return this.class2193_0;
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00014C7C File Offset: 0x00012E7C
		protected void method_2(Class2193 class2193_1)
		{
			this.class2193_0 = class2193_1;
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x000E1458 File Offset: 0x000DF658
		public  int vmethod_5()
		{
			if (this.int_0 < 0)
			{
				this.method_5();
			}
			return this.int_0;
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00014C85 File Offset: 0x00012E85
		public  void vmethod_6(Class2205 class2205_1)
		{
			this.arrayList_0.Add(class2205_1);
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x000E1484 File Offset: 0x000DF684
		public virtual IPolygon vmethod_7(IGeometryFactory igeometryFactory_1)
		{
			ILinearRing[] array = new LinearRing[this.arrayList_0.Count];
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				array[i] = ((Class2205)this.arrayList_0[i]).vmethod_1();
			}
			return igeometryFactory_1.CreatePolygon(this.vmethod_1(), array);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x000E14E4 File Offset: 0x000DF6E4
		public void method_3()
		{
			if (this.ilinearRing_0 == null)
			{
				Coordinate[] array = new Coordinate[this.ilist_1.Count];
				for (int i = 0; i < this.ilist_1.Count; i++)
				{
					array[i] = (Coordinate)this.ilist_1[i];
				}
				this.ilinearRing_0 = this.method_0().CreateLinearRing(array);
				this.bool_0 = CgAlgorithms.IsCounterClockwise(this.ilinearRing_0.GetCoordinates());
			}
		}

		// Token: 0x060023F7 RID: 9207
		public abstract Class2193 vmethod_8(Class2193 class2193_1);

		// Token: 0x060023F8 RID: 9208
		public abstract void vmethod_9(Class2193 class2193_1, Class2205 class2205_1);

		// Token: 0x060023F9 RID: 9209 RVA: 0x000E1564 File Offset: 0x000DF764
		protected void method_4(Class2193 class2193_1)
		{
			this.method_2(class2193_1);
			Class2193 @class = class2193_1;
			bool bool_ = true;
			do
			{
				Class2347.smethod_1(@class != null, "found null Directed Edge");
				if (@class != null)
				{
					if (@class.vmethod_15() == this)
					{
						goto IL_97;
					}
					this.ilist_0.Add(@class);
					Class2217 class2 = @class.vmethod_1();
					Class2347.smethod_0(class2.vmethod_7());
					this.vmethod_11(class2);
					this.vmethod_13(@class.vmethod_0(), @class.vmethod_17(), bool_);
					bool_ = false;
					this.vmethod_9(@class, this);
					@class = this.vmethod_8(@class);
				}
			}
			while (@class != this.method_1());
			return;
			IL_97:
			throw new TopologyException("Directed Edge visited twice during ring-building at " + @class.vmethod_3());
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x000E1620 File Offset: 0x000DF820
		private void method_5()
		{
			this.int_0 = 0;
			Class2193 @class = this.method_1();
			do
			{
				Class2200 class2 = @class.vmethod_7();
				int num = ((Class2196)class2.vmethod_6()).vmethod_6(this);
				if (num > this.int_0)
				{
					this.int_0 = num;
				}
				@class = this.vmethod_8(@class);
			}
			while (@class != this.method_1());
			this.int_0 *= 2;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000E1698 File Offset: 0x000DF898
		public  void vmethod_10()
		{
			Class2193 @class = this.method_1();
			do
			{
				@class.vmethod_0().vmethod_2(true);
				@class = @class.vmethod_25();
			}
			while (@class != this.method_1());
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00014C94 File Offset: 0x00012E94
		protected virtual void vmethod_11(Class2217 class2217_1)
		{
			this.vmethod_12(class2217_1, 0);
			this.vmethod_12(class2217_1, 1);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000E16D0 File Offset: 0x000DF8D0
		protected virtual void vmethod_12(Class2217 class2217_1, int int_1)
		{
			LocationType locationType = class2217_1.vmethod_1(int_1, Enum158.const_2);
			if (locationType != LocationType.Null && this.class2217_0.vmethod_2(int_1) == LocationType.Null)
			{
				this.class2217_0.vmethod_4(int_1, locationType);
			}
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000E1710 File Offset: 0x000DF910
		protected virtual void vmethod_13(Class2199 class2199_0, bool bool_1, bool bool_2)
		{
			IList<Coordinate> list = class2199_0.vmethod_8();
			if (bool_1)
			{
				int num = 1;
				if (bool_2)
				{
					num = 0;
				}
				for (int i = num; i < list.Count; i++)
				{
					this.ilist_1.Add(list[i]);
				}
			}
			else
			{
				int num2 = list.Count - 2;
				if (bool_2)
				{
					num2 = list.Count - 1;
				}
				for (int j = num2; j >= 0; j--)
				{
					this.ilist_1.Add(list[j]);
				}
			}
		}

		// Token: 0x04001155 RID: 4437
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x04001156 RID: 4438
		private readonly ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04001157 RID: 4439
		private readonly IGeometryFactory igeometryFactory_0;

		// Token: 0x04001158 RID: 4440
		private readonly Class2217 class2217_0 = new Class2217(LocationType.Null);

		// Token: 0x04001159 RID: 4441
		private readonly IList ilist_1 = new ArrayList();

		// Token: 0x0400115A RID: 4442
		private bool bool_0;

		// Token: 0x0400115B RID: 4443
		private int int_0 = -1;

		// Token: 0x0400115C RID: 4444
		private ILinearRing ilinearRing_0;

		// Token: 0x0400115D RID: 4445
		private Class2205 class2205_0;

		// Token: 0x0400115E RID: 4446
		private Class2193 class2193_0;
	}
}
