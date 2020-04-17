using System;
using System.Collections.Generic;
using ns15;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000606 RID: 1542
	[Serializable]
	public sealed class Point : Geometry, IComparable, ICloneable, IBasicGeometry, IGeometry, ICoordinate, IBasicPoint, IPoint
	{
		// Token: 0x170002D3 RID: 723
		public double this[int int_0]
		{
			get
			{
				return this.GetCoordinate()[int_0];
			}
			set
			{
				this.GetCoordinate()[int_0] = value;
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00015F1E File Offset: 0x0001411E
		public Point()
		{
			this._coordinates.Add(new Coordinate());
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00015F41 File Offset: 0x00014141
		public Point(Coordinate coordinate_0) : this(coordinate_0, new GeometryFactory())
		{
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00015F4F File Offset: 0x0001414F
		public Point(ICoordinate interface34_0) : this(new Coordinate(interface34_0), new GeometryFactory())
		{
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00015F62 File Offset: 0x00014162
		public Point(Coordinate coordinate_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			this._coordinates.Add(coordinate_0);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00015F82 File Offset: 0x00014182
		public Point(double double_0, double double_1) : this(new Coordinate(double_0, double_1), Geometry.DefaultFactory)
		{
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00015F96 File Offset: 0x00014196
		public override void Apply(ICoordinateFilter interface37_0)
		{
			if (!this.IsEmpty())
			{
				interface37_0.Filter(this.GetCoordinate());
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00015AF1 File Offset: 0x00013CF1
		public override void Apply(IGeometryFilter interface38_0)
		{
			interface38_0.Filter(this);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00015AFA File Offset: 0x00013CFA
		public override void Apply(IGeometryComponentFilter interface31_0)
		{
			interface31_0.Filter(this);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000F025C File Offset: 0x000EE45C
		public override int CompareToSameClass(object object_0)
		{
			Point point = (Point)object_0;
			return this.GetCoordinate().CompareTo(point.GetCoordinate());
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000F0284 File Offset: 0x000EE484
		protected override void OnCopy(Geometry geometry_0)
		{
			base.OnCopy(geometry_0);
			Point point = geometry_0 as Point;
			if (point != null)
			{
				point.SetCoordinate(Class835.smethod_0<Coordinate>(this.GetCoordinate()));
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000F02B8 File Offset: 0x000EE4B8
		protected override IEnvelope ComputeEnvelopeInternal()
		{
			IEnvelope result;
			if (this.IsEmpty())
			{
				result = new Envelope();
			}
			else
			{
				result = new Envelope(this.GetCoordinate().X, this.GetCoordinate().X, this.GetCoordinate().Y, this.GetCoordinate().Y);
			}
			return result;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000F030C File Offset: 0x000EE50C
		public override Coordinate GetCoordinate()
		{
			if (this._coordinates == null)
			{
				this._coordinates = new List<Coordinate>();
			}
			if (this._coordinates.Count == 0)
			{
				this._coordinates.Add(new Coordinate());
			}
			return this._coordinates[0];
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000F0364 File Offset: 0x000EE564
		public override IList<Coordinate> GetCoordinates()
		{
			return this._coordinates;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00015FAF File Offset: 0x000141AF
		public override void SetCoordinates(IList<Coordinate> ilist_0)
		{
			this._coordinates = ilist_0;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000F037C File Offset: 0x000EE57C
		public override string GetGeometryType()
		{
			return "Point";
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00015FB8 File Offset: 0x000141B8
		public override bool IsEmpty()
		{
			return Coordinate.Equals(this.GetCoordinate(), null);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsValid()
		{
			return true;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x000F0390 File Offset: 0x000EE590
		public  double GetM()
		{
			if (Coordinate.Equals(this.GetCoordinate(), null))
			{
				throw new ArgumentOutOfRangeException();
			}
			return this.GetCoordinate().M;
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000F03C4 File Offset: 0x000EE5C4
		public override int GetNumPoints()
		{
			int result;
			if (!this.IsEmpty())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000F03E0 File Offset: 0x000EE5E0
		public double[] GetValues()
		{
			return this.GetCoordinate().ToArray();
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x000F03FC File Offset: 0x000EE5FC
		public  double GetX()
		{
			return this.GetCoordinate().X;
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000F0418 File Offset: 0x000EE618
		public  double GetY()
		{
			return this.GetCoordinate().Y;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000F0434 File Offset: 0x000EE634
		public  double GetZ()
		{
			return this.GetCoordinate().Z;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000F0450 File Offset: 0x000EE650
		public void SetCoordinate(Coordinate value)
		{
			if (this._coordinates == null)
			{
				this._coordinates = new List<Coordinate>();
			}
			if (this._coordinates.Count == 0)
			{
				this._coordinates.Add(value);
			}
			else
			{
				this._coordinates[0] = value;
			}
		}

		// Token: 0x040012EC RID: 4844
		private const Coordinate EMPTY_COORDINATE = null;

		// Token: 0x040012ED RID: 4845
		private IList<Coordinate> _coordinates = new List<Coordinate>();

		// Token: 0x040012EE RID: 4846
		private int _recordNumber;

		// Token: 0x040012EF RID: 4847
		public static readonly IPoint Empty = new GeometryFactory().CreatePoint(null);
	}
}
