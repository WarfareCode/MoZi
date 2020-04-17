using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns26
{
	// Token: 0x020007B2 RID: 1970
	public sealed class Class2330
	{
		// Token: 0x060030C3 RID: 12483 RVA: 0x0001A252 File Offset: 0x00018452
		public Class2330(GeometryGraph class2209_1)
		{
			this.class2209_0 = class2209_1;
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0010B174 File Offset: 0x00109374
		public  Coordinate vmethod_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0010B18C File Offset: 0x0010938C
		public   bool vmethod_1()
		{
			SegmentIntersector segmentIntersector = this.class2209_0.vmethod_16(this.class2239_0, true);
			bool result;
			if (segmentIntersector.vmethod_1())
			{
				this.coordinate_0 = segmentIntersector.vmethod_0();
				result = false;
			}
			else
			{
				this.class2328_0.vmethod_1(this.class2209_0);
				result = this.method_0();
			}
			return result;
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0010B1E0 File Offset: 0x001093E0
		private bool method_0()
		{
			IEnumerator enumerator = this.class2328_0.vmethod_0();
			bool result;
			while (enumerator.MoveNext())
			{
				Class2201 @class = (Class2201)enumerator.Current;
				if (!@class.vmethod_6().vmethod_2())
				{
					this.coordinate_0 = (Coordinate)@class.vmethod_5().Clone();
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0010B23C File Offset: 0x0010943C
		public   bool vmethod_2()
		{
			IEnumerator enumerator = this.class2328_0.vmethod_0();
			bool result;
			while (enumerator.MoveNext())
			{
				Class2201 @class = (Class2201)enumerator.Current;
				IEnumerator enumerator2 = @class.vmethod_6().vmethod_4();
				while (enumerator2.MoveNext())
				{
					Class2194 class2 = (Class2194)enumerator2.Current;
					if (class2.vmethod_12().Count > 1)
					{
						this.coordinate_0 = class2.vmethod_0().vmethod_16(0);
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x040016AC RID: 5804
		private readonly GeometryGraph class2209_0;

		// Token: 0x040016AD RID: 5805
		private readonly LineIntersector class2239_0 = new RobustLineIntersector();

		// Token: 0x040016AE RID: 5806
		private readonly Class2328 class2328_0 = new Class2328();

		// Token: 0x040016AF RID: 5807
		private Coordinate coordinate_0;
	}
}
