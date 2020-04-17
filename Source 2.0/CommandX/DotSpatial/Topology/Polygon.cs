using System;
using System.Collections.Generic;
using ns15;
using ns24;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000612 RID: 1554
	[Serializable]
	public sealed class Polygon : Geometry, IComparable, ICloneable, IBasicGeometry, IGeometry, IBasicPolygon, IPolygon
	{
		// Token: 0x0600277E RID: 10110 RVA: 0x00016014 File Offset: 0x00014214
		public Polygon(ILinearRing shell) : this(shell, null, Geometry.DefaultFactory)
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000F0A30 File Offset: 0x000EEC30
		public Polygon(ILinearRing shell, ILinearRing[] holes, IGeometryFactory factory) : base(factory)
		{
			if (shell == null)
			{
				shell = base.GetFactory().CreateLinearRing(null);
			}
			if (holes == null)
			{
				holes = new LinearRing[0];
			}
			if (Geometry.HasNullElements(holes))
			{
				throw new PolygonException(TopologyText.GetPolygonException_HoleElementNull());
			}
			if (shell.IsEmpty() && Geometry.HasNonEmptyElements(holes))
			{
				throw new PolygonException(TopologyText.GetPolygonException_ShellEmptyButHolesNot());
			}
			this._shell = shell;
			this._holes = holes;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000F0AB4 File Offset: 0x000EECB4
		public Polygon(IBasicPolygon polygonBase) : base(Geometry.DefaultFactory)
		{
			this.SetHoles(polygonBase.GetHoles());
			LinearRing linearRing = new LinearRing(polygonBase.GetShell());
			if (Geometry.HasNullElements(this._holes))
			{
				throw new PolygonException(TopologyText.GetPolygonException_HoleElementNull());
			}
			if (linearRing.IsEmpty() && Geometry.HasNonEmptyElements(this._holes))
			{
				throw new PolygonException(TopologyText.GetPolygonException_ShellEmptyButHolesNot());
			}
			this._shell = linearRing;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000F0B2C File Offset: 0x000EED2C
		public override void Apply(ICoordinateFilter filter)
		{
			this._shell.Apply(filter);
			for (int i = 0; i < this._holes.Length; i++)
			{
				this._holes[i].Apply(filter);
			}
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00015AF1 File Offset: 0x00013CF1
		public override void Apply(IGeometryFilter filter)
		{
			filter.Filter(this);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000F0B68 File Offset: 0x000EED68
		public override void Apply(IGeometryComponentFilter filter)
		{
			filter.Filter(this);
			this._shell.Apply(filter);
			for (int i = 0; i < this._holes.Length; i++)
			{
				this._holes[i].Apply(filter);
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000F0BAC File Offset: 0x000EEDAC
		public override int CompareToSameClass(object o)
		{
			ILinearRing shell = this._shell;
			ILinearRing shell2 = ((IPolygon)o).GetShell();
			return shell.CompareToSameClass(shell2);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000F0BD8 File Offset: 0x000EEDD8
		public  ILineString GetInteriorRingN(int int_0)
		{
			return this._holes[int_0];
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000F0BF0 File Offset: 0x000EEDF0
		protected override void OnCopy(Geometry geometry_0)
		{
			base.OnCopy(geometry_0);
			Polygon polygon = geometry_0 as Polygon;
			if (polygon != null)
			{
				polygon.SetShell(Class835.smethod_0<ILinearRing>(this._shell));
				polygon.SetHoles(new ILinearRing[this._holes.Length]);
				for (int i = 0; i < this._holes.Length; i++)
				{
					polygon.GetHoles()[i] = Class835.smethod_0<ILinearRing>(this.GetHoles()[i]);
				}
			}
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000F0C64 File Offset: 0x000EEE64
		protected override IEnvelope ComputeEnvelopeInternal()
		{
			return this._shell.GetEnvelopeInternal();
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000F0C80 File Offset: 0x000EEE80
		public  IBasicLineString vmethod_6()
		{
			return this._shell;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000F0C98 File Offset: 0x000EEE98
		public  double GetArea()
		{
			double num = 0.0;
			num += Math.Abs(CgAlgorithms.SignedArea(this._shell.GetCoordinates()));
			for (int i = 0; i < this._holes.Length; i++)
			{
				num -= Math.Abs(CgAlgorithms.SignedArea(this._holes[i].GetCoordinates()));
			}
			return num;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000F0CFC File Offset: 0x000EEEFC
		public override Coordinate GetCoordinate()
		{
			return this._shell.GetCoordinate();
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000F0D18 File Offset: 0x000EEF18
		public override IList<Coordinate> GetCoordinates()
		{
			IList<Coordinate> result;
			if (this.IsEmpty())
			{
				result = new Coordinate[0];
			}
			else
			{
				List<Coordinate> list = new List<Coordinate>();
				list.AddRange(this.GetShell().GetCoordinates());
				ILinearRing[] holes = this.GetHoles();
				for (int i = 0; i < holes.Length; i++)
				{
					ILinearRing linearRing = holes[i];
					list.AddRange(linearRing.GetCoordinates());
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00016023 File Offset: 0x00014223
		public override void SetCoordinates(IList<Coordinate> ilist_0)
		{
			this.GetShell().SetCoordinates(ilist_0);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x000F0D7C File Offset: 0x000EEF7C
		public override string GetGeometryType()
		{
			return "Polygon";
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x000F0D90 File Offset: 0x000EEF90
		public ILinearRing[] GetHoles()
		{
			return this._holes;
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00016031 File Offset: 0x00014231
		public void SetHoles(ILinearRing[] ilinearRing_0)
		{
			this._holes = ilinearRing_0;
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000F0DA8 File Offset: 0x000EEFA8
		ICollection<IBasicLineString> IBasicPolygon.GetHoles()
		{
			return this._holes;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x0001603A File Offset: 0x0001423A
		public override bool IsEmpty()
		{
			return this._shell.IsEmpty();
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000F0DC0 File Offset: 0x000EEFC0
		public  int GetNumHoles()
		{
			return this._holes.Length;
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000F0DD8 File Offset: 0x000EEFD8
		public override int GetNumPoints()
		{
			int num = this._shell.GetNumPoints();
			for (int i = 0; i < this._holes.Length; i++)
			{
				num += this._holes[i].GetNumPoints();
			}
			return num;
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000F0E1C File Offset: 0x000EF01C
		public  ILinearRing GetShell()
		{
			return this._shell;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00016047 File Offset: 0x00014247
		public  void SetShell(ILinearRing ilinearRing_0)
		{
			this._shell = ilinearRing_0;
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000F0C80 File Offset: 0x000EEE80
		IBasicLineString IBasicPolygon.GetShell()
		{
			return this._shell;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000F0E34 File Offset: 0x000EF034
		private void SetHoles(ICollection<IBasicLineString> icollection_0)
		{
			if (icollection_0 == null || icollection_0.Count == 0)
			{
				this._holes = new ILinearRing[0];
			}
			else
			{
				this._holes = (icollection_0 as ILinearRing[]);
				if (this._holes == null)
				{
					List<ILinearRing> list = new List<ILinearRing>();
					foreach (IBasicLineString current in icollection_0)
					{
						list.Add(new LinearRing(Geometry.FromBasicGeometry(current) as ILineString));
					}
					this._holes = list.ToArray();
				}
			}
		}

		// Token: 0x04001308 RID: 4872
		private ILinearRing[] _holes;

		// Token: 0x04001309 RID: 4873
		private ILinearRing _shell;

		// Token: 0x0400130A RID: 4874
		public static readonly IPolygon Empty = new GeometryFactory().CreatePolygon(null, null);
	}
}
