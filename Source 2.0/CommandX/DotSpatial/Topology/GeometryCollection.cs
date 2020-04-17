using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000539 RID: 1337
	[Serializable]
	public class GeometryCollection : Geometry, IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry, IGeometryCollection
	{
		// Token: 0x1700026C RID: 620
		public virtual IGeometry this[int i]
		{
			get
			{
				return this._geometries[i];
			}
			set
			{
				this._geometries[i] = value;
			}
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00014566 File Offset: 0x00012766
		protected GeometryCollection() : base(Geometry.DefaultFactory)
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00014573 File Offset: 0x00012773
		public GeometryCollection(IGeometry[] inGeometries, IGeometryFactory factory) : base(factory)
		{
			if (inGeometries == null)
			{
				inGeometries = new IGeometry[0];
			}
			if (Geometry.HasNullElements(inGeometries))
			{
				throw new ArgumentException("geometries must not contain null elements");
			}
			this._geometries = inGeometries;
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000DEADC File Offset: 0x000DCCDC
		public GeometryCollection(IBasicGeometry inGeometry, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (inGeometry == null)
			{
				this._geometries = new IGeometry[0];
			}
			else
			{
				IBasicPolygon basicPolygon = inGeometry.GetBasicGeometryN(0) as IBasicPolygon;
				if (basicPolygon != null)
				{
					this._geometries = new IGeometry[inGeometry.GetNumGeometries()];
					for (int i = 0; i < inGeometry.GetNumGeometries(); i++)
					{
						basicPolygon = (inGeometry.GetBasicGeometryN(i) as IBasicPolygon);
						this._geometries[i] = new Polygon(basicPolygon);
					}
				}
				else
				{
					IBasicPoint basicPoint = inGeometry.GetBasicGeometryN(0) as IBasicPoint;
					if (basicPoint != null)
					{
						this._geometries = new IGeometry[inGeometry.GetNumGeometries()];
						for (int j = 0; j < inGeometry.GetNumGeometries(); j++)
						{
							basicPoint = (inGeometry.GetBasicGeometryN(j) as IBasicPoint);
							this._geometries[j] = new Point(basicPoint);
						}
					}
					else
					{
						IBasicLineString basicLineString = inGeometry.GetBasicGeometryN(0) as IBasicLineString;
						if (basicLineString != null)
						{
							this._geometries = new IGeometry[inGeometry.GetNumGeometries()];
							for (int k = 0; k < inGeometry.GetNumGeometries(); k++)
							{
								basicLineString = (inGeometry.GetBasicGeometryN(k) as IBasicLineString);
								this._geometries[k] = new LineString(basicLineString);
							}
						}
					}
				}
			}
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000DEC14 File Offset: 0x000DCE14
		public GeometryCollection(IEnumerable<IBasicGeometry> baseGeometries, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (baseGeometries != null)
			{
				int num = baseGeometries.Count<IBasicGeometry>();
				if (this._geometries == null)
				{
					this._geometries = new IGeometry[num];
				}
				if (Geometry.HasNullElements(baseGeometries))
				{
					throw new ArgumentException("geometries must not contain null elements");
				}
				int num2 = 0;
				foreach (IBasicGeometry current in baseGeometries)
				{
					this._geometries[num2] = Geometry.FromBasicGeometry(current);
					num2++;
				}
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000DECB4 File Offset: 0x000DCEB4
		public override Coordinate GetCoordinate()
		{
			Coordinate result;
			if (this.IsEmpty())
			{
				result = null;
			}
			else
			{
				result = this._geometries[0].GetCoordinate();
			}
			return result;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000DECE0 File Offset: 0x000DCEE0
		public override IList<Coordinate> GetCoordinates()
		{
			IList<Coordinate> list = new Coordinate[this.GetNumPoints()];
			int num = -1;
			for (int i = 0; i < this._geometries.Length; i++)
			{
				IList<Coordinate> coordinates = this._geometries[i].GetCoordinates();
				for (int j = 0; j < coordinates.Count; j++)
				{
					num++;
					list[num] = coordinates[j];
				}
			}
			return list;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000145AA File Offset: 0x000127AA
		public override void SetCoordinates(IList<Coordinate> ilist_0)
		{
			if (this._geometries.Length >= 1)
			{
				this._geometries[0].SetCoordinates(ilist_0);
			}
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000DED50 File Offset: 0x000DCF50
		public override bool IsEmpty()
		{
			bool result;
			for (int i = 0; i < this._geometries.Length; i++)
			{
				if (!this._geometries[i].IsEmpty())
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000DED88 File Offset: 0x000DCF88
		public override int GetNumGeometries()
		{
			return this._geometries.Length;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000DEAC4 File Offset: 0x000DCCC4
		public override IGeometry GetGeometryN(int int_0)
		{
			return this._geometries[int_0];
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000DEDA0 File Offset: 0x000DCFA0
		public override IBasicGeometry GetBasicGeometryN(int index)
		{
			return this._geometries[index];
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000DEDB8 File Offset: 0x000DCFB8
		public virtual IGeometry[] GetGeometries()
		{
			return this._geometries;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000DEDD0 File Offset: 0x000DCFD0
		public override int GetNumPoints()
		{
			int num = 0;
			for (int i = 0; i < this._geometries.Length; i++)
			{
				num += ((Geometry)this._geometries[i]).GetNumPoints();
			}
			return num;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000DEE0C File Offset: 0x000DD00C
		public override string GetGeometryType()
		{
			return "GeometryCollection";
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000DEE20 File Offset: 0x000DD020
		public  double GetArea()
		{
			double num = 0.0;
			for (int i = 0; i < this._geometries.Length; i++)
			{
				num += this._geometries[i].GetArea();
			}
			return num;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000DEE60 File Offset: 0x000DD060
		public override void Apply(ICoordinateFilter interface37_0)
		{
			for (int i = 0; i < this._geometries.Length; i++)
			{
				this._geometries[i].Apply(interface37_0);
			}
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000DEE90 File Offset: 0x000DD090
		public override void Apply(IGeometryFilter interface38_0)
		{
			interface38_0.Filter(this);
			for (int i = 0; i < this._geometries.Length; i++)
			{
				this._geometries[i].Apply(interface38_0);
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000DEEC8 File Offset: 0x000DD0C8
		public override void Apply(IGeometryComponentFilter interface31_0)
		{
			interface31_0.Filter(this);
			for (int i = 0; i < this._geometries.Length; i++)
			{
				this._geometries[i].Apply(interface31_0);
			}
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000DEF00 File Offset: 0x000DD100
		public override int CompareToSameClass(object object_0)
		{
			ArrayList a = new ArrayList(this._geometries);
			ArrayList b = new ArrayList(((GeometryCollection)object_0)._geometries);
			return this.Compare(a, b);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000DEF34 File Offset: 0x000DD134
		public IEnumerator GetEnumerator()
		{
			return new GeometryCollection.Enumerator(this);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000DEF4C File Offset: 0x000DD14C
		protected override void OnCopy(Geometry geometry_0)
		{
			GeometryCollection geometryCollection = geometry_0 as GeometryCollection;
			if (geometryCollection != null)
			{
				geometryCollection._geometries = new Geometry[this._geometries.Length];
				for (int i = 0; i < this._geometries.Length; i++)
				{
					geometryCollection._geometries[i] = (Geometry)this._geometries[i].Clone();
				}
			}
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000DEFAC File Offset: 0x000DD1AC
		protected override IEnvelope ComputeEnvelopeInternal()
		{
			Envelope envelope = new Envelope();
			for (int i = 0; i < this._geometries.Length; i++)
			{
				Class2183.smethod_13(envelope, this._geometries[i].GetEnvelopeInternal());
			}
			return envelope;
		}

		// Token: 0x040010F8 RID: 4344
		public static readonly IGeometryCollection Empty = new GeometryFactory().CreateGeometryCollection(null);

		// Token: 0x040010F9 RID: 4345
		private IGeometry[] _geometries;

		// Token: 0x0200053A RID: 1338
		public sealed class Enumerator : IEnumerator
		{
			// Token: 0x1700026D RID: 621
			// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000DEFEC File Offset: 0x000DD1EC
			public  object Current
			{
				get
				{
					object result;
					if (this._atStart)
					{
						this._atStart = false;
						result = this._parent;
					}
					else
					{
						if (this._subcollectionEnumerator != null)
						{
							if (this._subcollectionEnumerator.MoveNext())
							{
								result = this._subcollectionEnumerator.Current;
								return result;
							}
							this._subcollectionEnumerator = null;
						}
						if (this._index >= this._max)
						{
							throw new ArgumentOutOfRangeException();
						}
						IGeometry geometryN = this._parent.GetGeometryN(this._index++);
						if (geometryN is GeometryCollection)
						{
							this._subcollectionEnumerator = new GeometryCollection.Enumerator((GeometryCollection)geometryN);
							result = this._subcollectionEnumerator.Current;
						}
						else
						{
							result = geometryN;
						}
					}
					return result;
				}
			}

			// Token: 0x060022D1 RID: 8913 RVA: 0x000145DC File Offset: 0x000127DC
			internal Enumerator(IGeometryCollection igeometryCollection_1)
			{
				this._parent = igeometryCollection_1;
				this._atStart = true;
				this._index = 0;
				this._max = igeometryCollection_1.GetNumGeometries();
			}

			// Token: 0x060022D2 RID: 8914 RVA: 0x000DF0AC File Offset: 0x000DD2AC
			public  bool MoveNext()
			{
				bool result;
				if (this._atStart)
				{
					result = true;
				}
				else
				{
					if (this._subcollectionEnumerator != null)
					{
						if (this._subcollectionEnumerator.MoveNext())
						{
							result = true;
							return result;
						}
						this._subcollectionEnumerator = null;
					}
					result = (this._index < this._max);
				}
				return result;
			}

			// Token: 0x060022D3 RID: 8915 RVA: 0x00014605 File Offset: 0x00012805
			public  void Reset()
			{
				this._atStart = true;
				this._index = 0;
			}

			// Token: 0x040010FA RID: 4346
			private readonly int _max;

			// Token: 0x040010FB RID: 4347
			private readonly IGeometryCollection _parent;

			// Token: 0x040010FC RID: 4348
			private bool _atStart;

			// Token: 0x040010FD RID: 4349
			private int _index;

			// Token: 0x040010FE RID: 4350
			private GeometryCollection.Enumerator _subcollectionEnumerator;
		}
	}
}
