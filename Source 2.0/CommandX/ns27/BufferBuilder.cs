using System;
using System.Collections;
using DotSpatial.Topology;
using ns16;
using ns23;
using ns24;
using ns25;
using ns26;

namespace ns27
{
	// Token: 0x02000715 RID: 1813
	public sealed class BufferBuilder
	{
		// Token: 0x06002D1F RID: 11551 RVA: 0x000188FB File Offset: 0x00016AFB
		public  void vmethod_0(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00018904 File Offset: 0x00016B04
		public  void vmethod_1(PrecisionModel precisionModel_1)
		{
			this.precisionModel_0 = precisionModel_1;
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0001890D File Offset: 0x00016B0D
		public  void vmethod_2(BufferStyle enum156_1)
		{
			this.enum156_0 = enum156_1;
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00103184 File Offset: 0x00101384
		private static int smethod_0(Class2217 class2217_0)
		{
			LocationType locationType = class2217_0.vmethod_1(0, Enum158.const_1);
			LocationType locationType2 = class2217_0.vmethod_1(0, Enum158.const_2);
			int result;
			if (locationType == LocationType.Interior && locationType2 == LocationType.Exterior)
			{
				result = 1;
			}
			else if (locationType == LocationType.Exterior && locationType2 == LocationType.Interior)
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x001031D0 File Offset: 0x001013D0
		public IGeometry method_0(IGeometry igeometry_0, double double_0)
		{
			PrecisionModel precisionModel_ = this.precisionModel_0 ?? new PrecisionModel(igeometry_0.GetPrecisionModel());
			this.igeometryFactory_0 = igeometry_0.GetFactory();
			Class2304 @class = new Class2304(precisionModel_, this.int_0);
			@class.vmethod_0(this.enum156_0);
			Class2305 class2 = new Class2305(igeometry_0, double_0, @class);
			IList list = class2.vmethod_0();
			IGeometry result;
			if (list.Count <= 0)
			{
				result = this.igeometryFactory_0.CreateGeometryCollection(new Geometry[0]);
			}
			else
			{
				this.method_1(list, precisionModel_);
				this.class2208_0 = new Class2208(new Class2219());
				this.class2208_0.vmethod_1(this.class2204_0.vmethod_0());
				IList ilist_ = BufferBuilder.smethod_2(this.class2208_0);
				Class2324 class3 = new Class2324(this.igeometryFactory_0);
				BufferBuilder.smethod_3(ilist_, class3);
				IList ilist_2 = class3.vmethod_0();
				result = this.igeometryFactory_0.BuildGeometry(ilist_2);
			}
			return result;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x001032B4 File Offset: 0x001014B4
		private static Interface47 smethod_1(PrecisionModel precisionModel_1)
		{
			LineIntersector lineIntersector = new RobustLineIntersector();
			lineIntersector.SetPrecisionModel(precisionModel_1);
			return new Class2287(new Class2283(lineIntersector));
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x001032DC File Offset: 0x001014DC
		private void method_1(IList ilist_0, PrecisionModel precisionModel_1)
		{
			Interface47 @interface = BufferBuilder.smethod_1(precisionModel_1);
			@interface.imethod_0(ilist_0);
			IList list = @interface.imethod_1();
			foreach (object current in list)
			{
				Class2295 @class = (Class2295)current;
				Class2217 class2217_ = (Class2217)@class.method_0();
				Class2199 class2199_ = new Class2199(@class.method_3(), new Class2217(class2217_));
				this.method_2(class2199_);
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00103374 File Offset: 0x00101574
		protected void method_2(Class2199 class2199_0)
		{
			Class2199 @class = this.class2204_0.vmethod_2(class2199_0);
			if (Class2199.smethod_1(@class, null))
			{
				Class2217 class2 = @class.vmethod_0();
				Class2217 class3 = class2199_0.vmethod_0();
				if (!@class.vmethod_20(class2199_0))
				{
					class3 = new Class2217(class2199_0.vmethod_0());
					class3.vmethod_0();
				}
				class2.vmethod_5(class3);
				int num = BufferBuilder.smethod_0(class3);
				int num2 = @class.vmethod_10();
				int int_ = num2 + num;
				@class.vmethod_11(int_);
			}
			else
			{
				this.class2204_0.vmethod_1(class2199_0);
				class2199_0.vmethod_11(BufferBuilder.smethod_0(class2199_0.vmethod_0()));
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00103408 File Offset: 0x00101608
		private static IList smethod_2(Class2208 class2208_1)
		{
			ArrayList arrayList = new ArrayList();
            IEnumerator enumerator = class2208_1.Nodes.vmethod_3();
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					Class2200 @class = (Class2200)current;
					if (!@class.vmethod_3())
					{
						Class2303 class2 = new Class2303();
						class2.vmethod_2(@class);
						arrayList.Add(class2);
					}
				}
			}
			arrayList.Sort();
			arrayList.Reverse();
			return arrayList;
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0010349C File Offset: 0x0010169C
		private static void smethod_3(IList ilist_0, Class2324 class2324_0)
		{
			IList list = new ArrayList();
			foreach (object current in ilist_0)
			{
				Class2303 @class = (Class2303)current;
				Coordinate coordinate_ = @class.vmethod_1();
				Class2307 class2 = new Class2307(list);
				int num = class2.vmethod_0(coordinate_);
				@class.vmethod_3(num);
				@class.vmethod_4();
				list.Add(@class);
				class2324_0.vmethod_1(@class.vmethod_0(), @class.Nodes);
			}
		}

		// Token: 0x04001522 RID: 5410
		private readonly EdgeList class2204_0 = new EdgeList();

		// Token: 0x04001523 RID: 5411
		private BufferStyle enum156_0 = BufferStyle.CapRound;

		// Token: 0x04001524 RID: 5412
		private IGeometryFactory igeometryFactory_0;

		// Token: 0x04001525 RID: 5413
		private Class2208 class2208_0;

		// Token: 0x04001526 RID: 5414
		private int int_0 = 8;

		// Token: 0x04001527 RID: 5415
		private PrecisionModel precisionModel_0;
	}
}
