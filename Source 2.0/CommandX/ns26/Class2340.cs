using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns24;

namespace ns26
{
	// Token: 0x020007ED RID: 2029
	public sealed class Class2340
	{
		// Token: 0x0600321A RID: 12826 RVA: 0x0001AFE4 File Offset: 0x000191E4
		public Class2340(PrecisionModel precisionModel_1)
		{
			this.precisionModel_0 = precisionModel_1;
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x0010D460 File Offset: 0x0010B660
		public  IGeometry vmethod_0(IGeometry igeometry_0)
		{
			Class2188 @class;
			if (this.bool_0)
			{
				GeometryFactory igeometryFactory_ = new GeometryFactory(this.precisionModel_0);
				@class = new Class2188(igeometryFactory_);
			}
			else
			{
				@class = new Class2188();
			}
			return @class.vmethod_0(igeometry_0, new Class2340.Class2190(this));
		}

		// Token: 0x0400173E RID: 5950
		private readonly PrecisionModel precisionModel_0;

		// Token: 0x0400173F RID: 5951
		private bool bool_0;

		// Token: 0x04001740 RID: 5952
		private bool bool_1 = true;

		// Token: 0x020007EE RID: 2030
		private sealed class Class2190 : Class2188.Class2189
		{
			// Token: 0x0600321C RID: 12828 RVA: 0x0001AFFA File Offset: 0x000191FA
			public Class2190(Class2340 class2340_1)
			{
				this.class2340_0 = class2340_1;
			}

			// Token: 0x0600321D RID: 12829 RVA: 0x0010D4A4 File Offset: 0x0010B6A4
			public override IList<Coordinate> vmethod_0(IList<Coordinate> ilist_0, IGeometry igeometry_0)
			{
				IList<Coordinate> result;
				if (ilist_0.Count == 0)
				{
					result = null;
				}
				else
				{
					Coordinate[] array = new Coordinate[ilist_0.Count];
					for (int i = 0; i < ilist_0.Count; i++)
					{
						Coordinate coordinate = new Coordinate(ilist_0[i]);
						new PrecisionModel(this.class2340_0.precisionModel_0).MakePrecise(coordinate);
						array[i] = coordinate;
					}
					Class833 @class = new Class833(array, false);
					Coordinate[] array2 = @class.vmethod_12();
					int num = 0;
					if (igeometry_0 is LineString)
					{
						num = 2;
					}
					if (igeometry_0 is LinearRing)
					{
						num = 4;
					}
					Coordinate[] array3 = array;
					if (this.class2340_0.bool_1)
					{
						array3 = null;
					}
					if (array2.Length < num)
					{
						result = array3;
					}
					else
					{
						result = array2;
					}
				}
				return result;
			}

			// Token: 0x04001741 RID: 5953
			private readonly Class2340 class2340_0;
		}
	}
}
