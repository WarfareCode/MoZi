using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x02000603 RID: 1539
	public sealed class MultiLineString : GeometryCollection, IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry, IGeometryCollection, IMultiLineString
	{
		// Token: 0x170002D1 RID: 721
		public new ILineString this[int int_0]
		{
			get
			{
				return base[int_0] as ILineString;
			}
			set
			{
				base[int_0] = value;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00015E85 File Offset: 0x00014085
		public MultiLineString(IBasicLineString[] interface33_0, IGeometryFactory igeometryFactory_0) : base(interface33_0, igeometryFactory_0)
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00015E8F File Offset: 0x0001408F
		public MultiLineString(IBasicGeometry interface30_0) : base(interface30_0, Geometry.DefaultFactory)
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00015E9D File Offset: 0x0001409D
		public MultiLineString(IBasicLineString[] interface33_0) : this(interface33_0, Geometry.DefaultFactory)
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00015EAB File Offset: 0x000140AB
		public MultiLineString()
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000F0130 File Offset: 0x000EE330
		public override string GetGeometryType()
		{
			return "MultiLineString";
		}

		// Token: 0x040012E9 RID: 4841
		public static readonly IMultiLineString interface41_0 = new MultiLineString();
	}
}
