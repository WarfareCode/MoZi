using System;
using System.Collections.Generic;
using System.Linq;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x020005EA RID: 1514
	[Serializable]
	public class LineString : Geometry, IComparable, ICloneable, IBasicGeometry, IGeometry, IBasicLineString, ILineString
	{
		// Token: 0x170002CA RID: 714
		public  Coordinate this[int n]
		{
			get
			{
				return this._points[n];
			}
			set
			{
				this._points[n] = value;
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00015A79 File Offset: 0x00013C79
		public LineString(IList<Coordinate> points, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (points == null)
			{
				points = new Coordinate[0];
			}
			if (points.Count == 1)
			{
				throw new ArgumentException("point array must contain 0 or > 1 elements");
			}
			this._points = points;
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00015AB3 File Offset: 0x00013CB3
		public LineString(IList<Coordinate> points) : base(Geometry.DefaultFactory)
		{
			if (points == null)
			{
				points = new Coordinate[0];
			}
			if (points.Count == 1)
			{
				throw new ArgumentException("point array must contain 0 or >1 elements");
			}
			this._points = points;
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000E9CCC File Offset: 0x000E7ECC
		public LineString(IBasicLineString lineStringBase) : base(Geometry.DefaultFactory)
		{
			if (lineStringBase.GetNumPoints() == 0)
			{
				this._points = new Coordinate[0];
			}
			if (lineStringBase.GetNumPoints() == 1)
			{
				throw new ArgumentException("point array must contain 0 or > 1 elements");
			}
			this._points = lineStringBase.GetCoordinates();
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000E9D24 File Offset: 0x000E7F24
		public LineString(IEnumerable<Coordinate> coordinates) : base(Geometry.DefaultFactory)
		{
			if (coordinates == null)
			{
				this._points = new List<Coordinate>();
			}
			else
			{
				this._points = (coordinates as IList<Coordinate>);
				if (this._points == null)
				{
					this._points = new List<Coordinate>();
					foreach (Coordinate current in coordinates)
					{
						this._points.Add(current);
					}
				}
			}
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000E9DB8 File Offset: 0x000E7FB8
		public override void Apply(ICoordinateFilter filter)
		{
			foreach (Coordinate current in this._points)
			{
				filter.Filter(current);
			}
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00015AF1 File Offset: 0x00013CF1
		public override void Apply(IGeometryFilter filter)
		{
			filter.Filter(this);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00015AFA File Offset: 0x00013CFA
		public override void Apply(IGeometryComponentFilter filter)
		{
			filter.Filter(this);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000E9E0C File Offset: 0x000E800C
		public override int CompareToSameClass(object object_0)
		{
			LineString lineString = object_0 as LineString;
			int num = 0;
			int num2 = 0;
			int result;
			if (lineString != null)
			{
				while (num < this._points.Count && num2 < lineString._points.Count)
				{
					int num3 = this._points[num].CompareTo(lineString._points[num2]);
					if (num3 != 0)
					{
						result = num3;
						return result;
					}
					num++;
					num2++;
				}
			}
			if (num < this._points.Count)
			{
				result = 1;
			}
			else if (lineString != null && num2 < lineString._points.Count)
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000E9EC0 File Offset: 0x000E80C0
		protected override IEnvelope ComputeEnvelopeInternal()
		{
			IEnvelope result;
			if (this.IsEmpty())
			{
				result = new Envelope();
			}
			else
			{
				double num = this._points[0].X;
				double num2 = this._points[0].Y;
				double num3 = this._points[0].X;
				double num4 = this._points[0].Y;
				for (int i = 1; i < this._points.Count; i++)
				{
					num = ((num < this._points[i].X) ? num : this._points[i].X);
					num3 = ((num3 > this._points[i].X) ? num3 : this._points[i].X);
					num2 = ((num2 < this._points[i].Y) ? num2 : this._points[i].Y);
					num4 = ((num4 > this._points[i].Y) ? num4 : this._points[i].Y);
				}
				result = new Envelope(num, num3, num2, num4);
			}
			return result;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000EA00C File Offset: 0x000E820C
		protected override void OnCopy(Geometry geometry_0)
		{
			base.OnCopy(geometry_0);
			LineString lineString = geometry_0 as LineString;
			if (lineString != null)
			{
				lineString.SetCoordinates(new List<Coordinate>());
				foreach (Coordinate current in this._points)
				{
					lineString.GetCoordinates().Add(current);
				}
			}
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000E9CB0 File Offset: 0x000E7EB0
		public  Coordinate vmethod_6(int int_0)
		{
			return this._points[int_0];
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000EA084 File Offset: 0x000E8284
		public override Coordinate GetCoordinate()
		{
			Coordinate result;
			if (this.IsEmpty())
			{
				result = null;
			}
			else
			{
				result = this._points.First<Coordinate>();
			}
			return result;
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000EA0B0 File Offset: 0x000E82B0
		public override IList<Coordinate> GetCoordinates()
		{
			return this._points;
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00015B03 File Offset: 0x00013D03
		public override void SetCoordinates(IList<Coordinate> ilist_0)
		{
			this._points = ilist_0;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000EA0C8 File Offset: 0x000E82C8
		public override string GetGeometryType()
		{
			return "LineString";
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00015B0C File Offset: 0x00013D0C
		public virtual bool imethod_19()
		{
			return !this.IsEmpty() && new Coordinate(this.vmethod_6(0)).Equals2D(this.vmethod_6(this.GetNumPoints() - 1));
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00015B38 File Offset: 0x00013D38
		public override bool IsEmpty()
		{
			return this._points.Count == 0;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000EA0DC File Offset: 0x000E82DC
		public override int GetNumPoints()
		{
			return this._points.Count;
		}

		// Token: 0x04001262 RID: 4706
		public static readonly ILineString Empty = new GeometryFactory().CreateLineString(new Coordinate[0]);

		// Token: 0x04001263 RID: 4707
		private IList<Coordinate> _points;
	}
}
