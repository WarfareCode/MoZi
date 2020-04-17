using System;
using System.Collections.Generic;
using System.Linq;
using ns15;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x020005EB RID: 1515
	[Serializable]
	public sealed class LinearRing : LineString, IComparable, ICloneable, IBasicGeometry, IGeometry, IBasicLineString, ILineString, ILinearRing
	{
		// Token: 0x0600265E RID: 9822 RVA: 0x00015B5F File Offset: 0x00013D5F
		public LinearRing(IEnumerable<Coordinate> coordinates) : base(coordinates)
		{
			this.ValidateConstruction();
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00015B6E File Offset: 0x00013D6E
		public LinearRing(IBasicLineString interface33_0) : base(interface33_0)
		{
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000EA0F8 File Offset: 0x000E82F8
		public override string GetGeometryType()
		{
			return "LinearRing";
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool imethod_19()
		{
			return true;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000EA10C File Offset: 0x000E830C
		private void ValidateConstruction()
		{
			if (!this.IsEmpty() && !base.imethod_19())
			{
				IList<Coordinate> list = this.GetCoordinates().ToList<Coordinate>();
				list.Add(Class835.smethod_0<Coordinate>(this.GetCoordinates()[0]));
				this.SetCoordinates(list);
			}
			if (this.GetCoordinates().Count >= 1 && this.GetCoordinates().Count < 3)
			{
				throw new ArgumentException("Number of points must be 0 or >= 3");
			}
		}
	}
}
