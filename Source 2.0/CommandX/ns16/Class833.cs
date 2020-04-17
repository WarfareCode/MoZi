using System;
using System.Collections.Generic;
using System.Linq;
using DotSpatial.Serialization;
using DotSpatial.Topology;
using ns15;

namespace ns16
{
	// Token: 0x020004EB RID: 1259
	public sealed class Class833 : BaseList<Coordinate>, ICloneable
	{
		// Token: 0x060020D4 RID: 8404 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public Class833()
		{
			base.SetInnerList(new List<Coordinate>());
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000D52F0 File Offset: 0x000D34F0
		public Class833(IEnumerable<Coordinate> ienumerable_0, bool bool_0)
		{
			if (!bool_0)
			{
				List<Coordinate> list = new List<Coordinate>();
				Coordinate coordinate = null;
				foreach (Coordinate current in ienumerable_0)
				{
					if (!Coordinate.NotEquals(null, coordinate) || !coordinate.Equals2D(current))
					{
						list.Add(current);
						coordinate = current;
					}
				}
				base.SetInnerList(list);
			}
			else
			{
				base.SetInnerList(ienumerable_0.ToList<Coordinate>());
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000D537C File Offset: 0x000D357C
		public object Clone()
		{
			Class833 @class = new Class833();
			foreach (Coordinate current in this)
			{
				@class.Add(Class835.smethod_0<Coordinate>(current));
			}
			return @class;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00013BE3 File Offset: 0x00011DE3
		public  void vmethod_8(IEnumerable<Coordinate> ienumerable_0, bool bool_0, bool bool_1)
		{
			if (!bool_1)
			{
				ienumerable_0.Reverse<Coordinate>();
			}
			this.method_6(ienumerable_0, bool_0);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00013BF7 File Offset: 0x00011DF7
		public  void vmethod_9(IEnumerable<Coordinate> ienumerable_0, bool bool_0)
		{
			this.vmethod_8(ienumerable_0, bool_0, true);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00013C02 File Offset: 0x00011E02
		public  void vmethod_10(Coordinate coordinate_0, bool bool_0)
		{
			this.method_5(coordinate_0, bool_0);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000D53D8 File Offset: 0x000D35D8
		protected void method_5(Coordinate coordinate_0, bool bool_0)
		{
			if (!bool_0 && base.Count >= 1)
			{
				Coordinate coordinate = base[base.Count - 1];
				if (coordinate.Equals2D(coordinate_0))
				{
					return;
				}
			}
			base.Add(coordinate_0);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000D5418 File Offset: 0x000D3618
		protected void method_6(IEnumerable<Coordinate> ienumerable_0, bool bool_0)
		{
			foreach (Coordinate current in ienumerable_0)
			{
				this.method_5(current, bool_0);
			}
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00013C0C File Offset: 0x00011E0C
		public  void vmethod_11()
		{
			if (base.Count > 0)
			{
				this.vmethod_10(base[0], false);
			}
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000D5468 File Offset: 0x000D3668
		public  Coordinate[] vmethod_12()
		{
			return base.GetInnerList().ToArray();
		}
	}
}
