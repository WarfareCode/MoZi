using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns26;

namespace ns27
{
	// Token: 0x02000776 RID: 1910
	public sealed class Class2320 : Class2319
	{
		// Token: 0x06002F3F RID: 12095 RVA: 0x00107304 File Offset: 0x00105504
		public  void vmethod_4(LineString lineString_0)
		{
			if (!lineString_0.IsEmpty())
			{
				IList<Coordinate> list = Class2178.smethod_3(lineString_0.GetCoordinates());
				Coordinate coordinate_ = list[0];
				Coordinate coordinate_2 = list[list.Count - 1];
				Class2318 @class = this.method_0(coordinate_);
				Class2318 class2 = this.method_0(coordinate_2);
				Class2314 class2314_ = new Class2315(@class, class2, list[1], true);
				Class2314 class2314_2 = new Class2315(class2, @class, list[list.Count - 2], false);
				Class2316 class3 = new Class2317(lineString_0);
				class3.method_2(class2314_, class2314_2);
				this.vmethod_2(class3);
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00107398 File Offset: 0x00105598
		private Class2318 method_0(Coordinate coordinate_0)
		{
			Class2318 @class = this.vmethod_0(coordinate_0);
			if (@class == null)
			{
				@class = new Class2318(coordinate_0);
				this.vmethod_1(@class);
			}
			return @class;
		}
	}
}
